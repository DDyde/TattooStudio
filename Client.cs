using System.Data;

namespace TattooStudio
{
    public partial class Client : Form
    {
        int rowId = 0;
        int rule = AccessLevel.rule;

        public Client()
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
                sessionAssignmentToolStripMenuItem.Visible = false;
            }
        }

        private void databaseLoad()
        {
            ConnectionToDB connectionToDB = new ConnectionToDB();
            
            MySqlDataAdapter npgsqlDataAdapter = new MySqlDataAdapter
                    (@"select id_client, surname as Фамилия, name as Имя, middlename as Отчество, date_of_birth as Дата_рождения
                      from Клиент", connectionToDB.GetConnection());
            DataTable dataTable = new DataTable();
            npgsqlDataAdapter.Fill(dataTable);
            dataGridClient.DataSource = dataTable;
            dataGridClient.Columns[0].Visible = false;
            
        }

        private void dataGridClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                rowId = Convert.ToInt32(dataGridClient[0, e.RowIndex].Value);

                ConnectionToDB connectionToDB = new ConnectionToDB();

                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter
                   ($@"SELECT * FROM Клиент
                        WHERE id_client={rowId}", connectionToDB.GetConnection());
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                clientSurname.Text = dataTable.Rows[0][1].ToString();
                clientName.Text = dataTable.Rows[0][2].ToString();
                clientMiddlename.Text = dataTable.Rows[0][3].ToString();
                dateBirthBox.Text = dataTable.Rows[0][4].ToString();

                changeVisibleBox();
            }
            catch (Exception)
            {
                clearBox();
            }

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (rule == 1 || rule == 2)
            {
                changeVisibleBox();
                ConnectionToDB connectionToDB = new ConnectionToDB();

                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter
                   ($@"UPDATE Клиент SET surname='{clientSurname.Text}', name='{clientName.Text}', middlename='{clientMiddlename.Text}', 
                    date_of_birth='{dateBirthBox.Value.ToString("yyyy-MM-dd")}'
                    WHERE id_client='{rowId}'", connectionToDB.GetConnection());
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                dataGridClient.Refresh();
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

                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter
                   ($@"INSERT INTO Клиент (surname, name, middlename, date_of_birth) 
                    VALUES ('{clientSurname.Text}', '{clientName.Text}', '{clientMiddlename.Text}', 
                    '{dateBirthBox.Value.ToString("yyyy-MM-dd")}')", connectionToDB.GetConnection());
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
            foreach (TextBox textBox in splitClientContainer.Panel2.Controls.OfType<TextBox>())
            {
                addButton.Visible = true;
                updateButton.Visible = false;
                deleteButton.Visible = false;
                textBox.Clear();
            }
        }

        private void toolStripEmployee_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.Show();
            this.Hide();
        }

        private void мастераToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void sessionAssignmentMenuItem_Click(object sender, EventArgs e)
        {
            SessionAssignment sessionAssignment = new SessionAssignment();
            sessionAssignment.Show();
            this.Hide();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (rule == 1 || rule == 2)
            {
                ConnectionToDB connectionToDB = new ConnectionToDB();

                NpgsqlDataAdapter sqlDataAdapter = new NpgsqlDataAdapter
                   ($@"DELETE FROM Клиент
                       WHERE id_client={rowId})", connectionToDB.GetConnection());
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

        private void Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}