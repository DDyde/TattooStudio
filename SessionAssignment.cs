using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TattooStudio
{
    public partial class SessionAssignment : Form
    {
        int rowId=0;
        int rule = AccessLevel.rule;

        public SessionAssignment()
        {
            InitializeComponent();
            databaseLoad();
            removeMenuItem();
        }

        private void removeMenuItem()
        {
            if (rule != 1)
            {
                positionMenuItem.Visible = false;
                serviceProvidedMenuItem.Visible = false;
                typeOfServiceMenuItem.Visible = false;
                sessionAssignmentMenuItem.Visible = false;
            }
        }

        private void databaseLoad()
        {
            ConnectionToDB connectionToDB = new ConnectionToDB();

            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter
                    (@"SELECT Назначение_сеанса.id_session_asignment, CONCAT_WS(' ', Клиент.surname, Клиент.name, Клиент.middlename) as ФИО,
                        Вид_услуги.title as Вид_услуги, Статус_сеанса.title as Статус_сеанса,date_session as Дата, time_session as Время
                        FROM Назначение_сеанса
                        JOIN Клиент ON Клиент.id_client = Назначение_сеанса.id_client
                        JOIN Предоставляемая_услуга ON Предоставляемая_услуга.id_service_provided = Назначение_сеанса.id_service_provided
                        JOIN Вид_услуги ON Вид_услуги.id_type_of_service = Предоставляемая_услуга.id_type_of_service
                        JOIN Статус_сеанса ON Статус_сеанса.id_session_status = Назначение_сеанса.id_session_status", connectionToDB.GetConnection());
            DataTable dataTable = new DataTable();
            npgsqlDataAdapter.Fill(dataTable);
            dataGridSessionAssignment.DataSource = dataTable;
            dataGridSessionAssignment.Columns[0].Visible = false;

            comboBox();
        }

        private void dataGridSessionAssignment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                comboBox();
                rowId = Convert.ToInt32(dataGridSessionAssignment[0, e.RowIndex].Value);

                ConnectionToDB connectionToDB = new ConnectionToDB();

                NpgsqlDataAdapter sqlDataAdapter = new NpgsqlDataAdapter
                   ($@"SELECT Назначение_сеанса.id_session_asignment, Клиент.id_client,
                        Вид_услуги.id_type_of_service, Статус_сеанса.id_session_status,date_session as Дата_сеанса, time_session as Время_сеанса
                        FROM Назначение_сеанса
                        JOIN Клиент ON Клиент.id_client = Назначение_сеанса.id_client
                        JOIN Предоставляемая_услуга ON Предоставляемая_услуга.id_service_provided = Назначение_сеанса.id_service_provided
                        JOIN Вид_услуги ON Вид_услуги.id_type_of_service = Предоставляемая_услуга.id_type_of_service
                        JOIN Статус_сеанса ON Статус_сеанса.id_session_status = Назначение_сеанса.id_session_status
                        WHERE Назначение_сеанса.id_session_asignment={rowId}", connectionToDB.GetConnection());
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                clientBox.SelectedValue= dataTable.Rows[0][1];
                serviceProvidedBox.SelectedValue = dataTable.Rows[0][2];
                sessionStatusBox.SelectedValue = dataTable.Rows[0][3];
                dateSession.Text = dataTable.Rows[0][4].ToString();
                timeSession.Text = dataTable.Rows[0][5].ToString();

                changeVisibleBox();
            }
            catch (InvalidCastException)
            {
                clearBox();
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void comboBox()
        {
            ConnectionToDB connectionToDB = new ConnectionToDB();
            NpgsqlDataAdapter sqlDataAdapter = new NpgsqlDataAdapter(
                $@"SELECT id_client, CONCAT_WS(' ', surname, name, middlename) as ФИО
                FROM Клиент", connectionToDB.GetConnection());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            clientBox.DataSource = dataTable;
            clientBox.DisplayMember = "ФИО";
            clientBox.ValueMember = "id_client";

            NpgsqlDataAdapter sqlDataAdapter2 = new NpgsqlDataAdapter(
                $@"Select id_service_provided, CONCAT(Вид_услуги.title, ' (', Сотрудник.surname, ' ', Сотрудник.name, ' ',Сотрудник.middlename, ')') as Сервис
                    FROM Предоставляемая_услуга
                    JOIN Вид_услуги ON Вид_услуги.id_type_of_service = Предоставляемая_услуга.id_type_of_service
                    JOIN Сотрудник ON Сотрудник.id_employee = Предоставляемая_услуга.id_employee", connectionToDB.GetConnection());
            DataTable dataTable2 = new DataTable();
            sqlDataAdapter2.Fill(dataTable2);
            serviceProvidedBox.DataSource = dataTable2;
            serviceProvidedBox.DisplayMember = "Сервис";
            serviceProvidedBox.ValueMember = "id_service_provided";

            NpgsqlDataAdapter sqlDataAdapter3 = new NpgsqlDataAdapter(
                $@"SELECT id_session_status, title
                FROM Статус_сеанса", connectionToDB.GetConnection());
            DataTable dataTable3 = new DataTable();
            sqlDataAdapter3.Fill(dataTable3);
            sessionStatusBox.DataSource = dataTable3;
            sessionStatusBox.DisplayMember = "title";
            sessionStatusBox.ValueMember = "id_session_status";
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (rule == 1 || rule == 2)
            {
                changeVisibleBox();
                ConnectionToDB connectionToDB = new ConnectionToDB();

                NpgsqlDataAdapter sqlDataAdapter = new NpgsqlDataAdapter
                   ($@"UPDATE Назначение_сеанса SET id_client='{clientBox.SelectedValue}', date_session='{dateSession.Text}',  time_session='{timeSession.Text}',  
                    id_session_status='{sessionStatusBox.SelectedValue}', id_service_provided='{serviceProvidedBox.SelectedValue}'
                    WHERE id_session_asignment='{rowId}'", connectionToDB.GetConnection());
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                dataGridSessionAssignment.Refresh();
                clearBox();
                databaseLoad();
            }
            else
            {
                MessageBox.Show("Недостаточный уровень доступа");
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (rule == 1 || rule == 2)
            {
                ConnectionToDB connectionToDB = new ConnectionToDB();

                NpgsqlDataAdapter sqlDataAdapter = new NpgsqlDataAdapter
                   ($@"INSERT INTO Назначение_сеанса (id_client, date_session, time_session, id_session_status, id_service_provided) 
                    VALUES ('{clientBox.SelectedValue}', '{dateSession.Text}', '{timeSession.Text}', 
                    '{sessionStatusBox.SelectedValue}', '{serviceProvidedBox.SelectedValue}')", connectionToDB.GetConnection());
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                clearBox();
                databaseLoad();
            }
            else
            {
                MessageBox.Show("Недостаточный уровень доступа");
            }
        }

        private void changeVisibleBox()
        {
            updateButton.Visible = true;
            deleteButton.Visible = true;
            addButton.Visible = false;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (rule == 1 || rule == 2)
            {
                ConnectionToDB connectionToDB = new ConnectionToDB();

                NpgsqlDataAdapter sqlDataAdapter = new NpgsqlDataAdapter
                   ($@"DELETE FROM Назначение_сеанса WHERE id_session_asignment={rowId}", connectionToDB.GetConnection());
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                clearBox();
                databaseLoad();
            }
            else
            {
                MessageBox.Show("Недостаточный уровень доступа");
            }
        }

        private void sessionAssignmentMenuItem_Click(object sender, EventArgs e)
        {
            SessionAssignment sessionAssignment = new SessionAssignment();
            sessionAssignment.Show();
            this.Hide();
        }

        private void clearBox()
        {
            addButton.Visible = true;
            updateButton.Visible = false;
            deleteButton.Visible = false;  
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.Show();
            this.Hide();
        }

        private void toolStripEmployee_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.Show();
            this.Hide();
        }

        private void masterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Artist artist = new Artist();
            artist.Show();
            this.Hide();
        }

        private void typeOfServiceMenuItem_Click(object sender, EventArgs e)
        {
            TypeOfService typeOfService = new TypeOfService();
            typeOfService.Show();
            this.Hide();
        }

        private void positionMenuItem_Click(object sender, EventArgs e)
        {
            Position position = new Position();
            position.Show();
            this.Hide();
        }

        private void serviceProvidedMenuItem_Click(object sender, EventArgs e)
        {
            ServiceProvided serviceProvided = new ServiceProvided();
            serviceProvided.Show();
            this.Hide();
        }

        private void sessionStatusMenuItem_Click(object sender, EventArgs e)
        {
            SesssionStatus sesssionStatus = new SesssionStatus();
            sesssionStatus.Show();
            this.Hide();
        }

        private void serviceTypeMenuItem_Click(object sender, EventArgs e)
        {
            ServiceType type = new ServiceType();
            type.Show();
            this.Hide();
        }

        private void SessionAssignment_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
