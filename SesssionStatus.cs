using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TattooStudio
{
    public partial class SesssionStatus : Form
    {
        int rowId = 0;
        int rule = AccessLevel.rule;

        public SesssionStatus()
        {
            InitializeComponent();
            databaseLoad();
        }

        private void databaseLoad()
        {
            ConnectionToDB connectionToDB = new ConnectionToDB();

            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter
                    (@"select id_session_status, title as Название
                    from Статус_сеанса", connectionToDB.GetConnection());
            DataTable dataTable = new DataTable();
            npgsqlDataAdapter.Fill(dataTable);
            dataGridSessionStatus.DataSource = dataTable;
            dataGridSessionStatus.Columns[0].Visible = false;

        }

        private void dataGridSessionStatus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                rowId = Convert.ToInt32(dataGridSessionStatus[0, e.RowIndex].Value);

                ConnectionToDB connectionToDB = new ConnectionToDB();

                NpgsqlDataAdapter sqlDataAdapter = new NpgsqlDataAdapter
                   ($@"SELECT * FROM Статус_сеанса
                        WHERE id_session_status={rowId}", connectionToDB.GetConnection());
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                sessionStatusBox.Text = dataTable.Rows[0][1].ToString();

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

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (rule == 1 || rule == 2)
            {
                changeVisibleBox();
                ConnectionToDB connectionToDB = new ConnectionToDB();

                NpgsqlDataAdapter sqlDataAdapter = new NpgsqlDataAdapter
                   ($@"UPDATE Статус_сеанса SET title='{sessionStatusBox.Text}'
                    WHERE id_session_status='{rowId}'", connectionToDB.GetConnection());
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                dataGridSessionStatus.Refresh();
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
                   ($@"INSERT INTO Статус_сеанса (title) 
                    VALUES ('{sessionStatusBox.Text}')", connectionToDB.GetConnection());
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

        private void clearBox()
        {
            foreach (TextBox textBox in splitContainer.Panel2.Controls.OfType<TextBox>())
            {
                addButton.Visible = true;
                updateButton.Visible = false;
                deleteButton.Visible = false;
                textBox.Clear();
            }
        }

        private void sessionAssignmentMenuItem_Click(object sender, EventArgs e)
        {
            SessionAssignment sessionAssignment = new SessionAssignment();
            sessionAssignment.Show();
            this.Hide();
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
                   ($@"DELETE FROM Статус_сеанса WHERE id_session_status={rowId}", connectionToDB.GetConnection());
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
