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
    public partial class ServiceProvided : Form
    {
        int rowId = 0;
        int rule = AccessLevel.rule;

        public ServiceProvided()
        {
            InitializeComponent();
            databaseLoad();
        }

        private void databaseLoad()
        {
            ConnectionToDB connectionToDB = new ConnectionToDB();

            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter
                    (@"SELECT id_service_provided, Вид_услуги.title as Вид_услуги, CONCAT_WS(' ', Сотрудник.surname, Сотрудник.name, Сотрудник.middlename) as ФИО
                        FROM Предоставляемая_услуга
                        JOIN Вид_услуги ON Вид_услуги.id_type_of_service = Предоставляемая_услуга.id_type_of_service
                        JOIN Сотрудник ON Сотрудник.id_employee = Предоставляемая_услуга.id_employee", connectionToDB.GetConnection());
            DataTable dataTable = new DataTable();
            npgsqlDataAdapter.Fill(dataTable);
            dataGridServiceProvided.DataSource = dataTable;
            dataGridServiceProvided.Columns[0].Visible = false;
            comboBox();
        }

        private void dataGridServiceProvided_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                comboBox();

                rowId = Convert.ToInt32(dataGridServiceProvided[0, e.RowIndex].Value);

                ConnectionToDB connectionToDB = new ConnectionToDB();

                NpgsqlDataAdapter sqlDataAdapter = new NpgsqlDataAdapter
                   ($@"SELECT id_service_provided, Вид_услуги.id_type_of_service, CONCAT_WS(' ', Сотрудник.surname, Сотрудник.name, Сотрудник.middlename)
                        FROM Предоставляемая_услуга
                        JOIN Вид_услуги ON Вид_услуги.id_type_of_service = Предоставляемая_услуга.id_type_of_service
                        JOIN Сотрудник ON Сотрудник.id_employee = Предоставляемая_услуга.id_employee
                        WHERE Предоставляемая_услуга.id_service_provided={rowId}", connectionToDB.GetConnection());
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                typeOfServiceBox.SelectedValue = dataTable.Rows[0][1];
                employeeBox.Text = dataTable.Rows[0][2].ToString();

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
                $@"SELECT id_type_of_service, title
                FROM Вид_услуги", connectionToDB.GetConnection());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            typeOfServiceBox.DataSource = dataTable;
            typeOfServiceBox.DisplayMember = "title";
            typeOfServiceBox.ValueMember = "id_type_of_service";

            NpgsqlDataAdapter sqlDataAdapterB = new NpgsqlDataAdapter(
                $@"SELECT id_employee, CONCAT_WS(' ', surname, name, middlename) as ФИО
                FROM Сотрудник", connectionToDB.GetConnection());
            DataTable dataTableB = new DataTable();
            sqlDataAdapterB.Fill(dataTableB);
            employeeBox.DataSource = dataTableB;
            employeeBox.DisplayMember = "ФИО";
            employeeBox.ValueMember = "id_employee";
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (rule == 1 || rule == 2)
            {
                changeVisibleBox();
                ConnectionToDB connectionToDB = new ConnectionToDB();

                NpgsqlDataAdapter sqlDataAdapter = new NpgsqlDataAdapter
                   ($@"UPDATE Предоставляемая_услуга SET id_type_of_service='{typeOfServiceBox.SelectedValue}', id_employee='{employeeBox.SelectedValue}'
                    WHERE id_session_assignment='{rowId}'", connectionToDB.GetConnection());
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                dataGridServiceProvided.Refresh();
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
                   ($@"INSERT INTO Предоставляемая_услуга (id_type_of_service, id_employee) 
                    VALUES ('{typeOfServiceBox.SelectedValue}', '{employeeBox.SelectedValue}')", connectionToDB.GetConnection());
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

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (rule == 1 || rule == 2)
            {
                ConnectionToDB connectionToDB = new ConnectionToDB();

                NpgsqlDataAdapter sqlDataAdapter = new NpgsqlDataAdapter
                   ($@"DELETE FROM Предоставляемая_услуга WHERE id_service_provided={rowId}", connectionToDB.GetConnection());
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
    }
}
