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
    public partial class TypeOfService : Form
    {
        int rowId = 0;
        int rule = AccessLevel.rule;

        public TypeOfService()
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
                    (@"SELECT id_type_of_service, Вид_услуги.title as Название, Тип_услуги.title as Тип_услуги,
                        Вид_услуги.price as Цена
                        FROM Вид_услуги
                        JOIN Тип_услуги ON Тип_услуги.id_service_type = Вид_услуги.id_service_type", connectionToDB.GetConnection());
            DataTable dataTable = new DataTable();
            npgsqlDataAdapter.Fill(dataTable);
            dataGridTypeOfService.DataSource = dataTable;
            dataGridTypeOfService.Columns[0].Visible = false;

            comboBox();
            
        }

        private void dataGridTypeOfService_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                comboBox();

                rowId = Convert.ToInt32(dataGridTypeOfService[0, e.RowIndex].Value);

                ConnectionToDB connectionToDB = new ConnectionToDB();

                NpgsqlDataAdapter sqlDataAdapter = new NpgsqlDataAdapter
                   ($@"SELECT * FROM Вид_услуги
                        WHERE id_type_of_service={rowId}", connectionToDB.GetConnection());
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                typeServiceBox.Text = dataTable.Rows[0][1].ToString();
                typeServiceComboBox.SelectedValue = dataTable.Rows[0][3];
                priceBox.Text = dataTable.Rows[0][2].ToString();

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
                $@"SELECT id_service_type, title
                FROM Тип_услуги", connectionToDB.GetConnection());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            typeServiceComboBox.DataSource = dataTable;
            typeServiceComboBox.DisplayMember = "title";
            typeServiceComboBox.ValueMember = "id_service_type";
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (rule == 1 || rule == 2)
            {
                changeVisibleBox();
                ConnectionToDB connectionToDB = new ConnectionToDB();

                NpgsqlDataAdapter sqlDataAdapter = new NpgsqlDataAdapter
                   ($@"UPDATE Вид_услуги SET title='{typeServiceBox.Text}', price='{priceBox.Text}', id_service_type='{typeServiceComboBox.SelectedValue}'
                    WHERE id_type_of_service='{rowId}'", connectionToDB.GetConnection());
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                dataGridTypeOfService.Refresh();
                clearBox();
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
                   ($@"INSERT INTO Вид_услуги (title, price, id_service_type) 
                    VALUES ('{typeServiceBox.Text}', '{priceBox.Text}', '{typeServiceComboBox.SelectedValue}')", connectionToDB.GetConnection());
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                clearBox();
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
            foreach (TextBox textBox in splitContainer.Panel2.Controls.OfType<TextBox>())
            {
                addButton.Visible = true;
                updateButton.Visible = false;
                deleteButton.Visible = false;
                textBox.Clear();
            }

            priceBox.Value = 0;

            databaseLoad();
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
                   ($@"DELETE FROM Вид_услуги WHERE id_type_of_service={rowId}", connectionToDB.GetConnection());
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                clearBox();
            }
            else
            {
                MessageBox.Show("Недостаточный уровень доступа");
            }
        }

        private void TypeOfService_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
