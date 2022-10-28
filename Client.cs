using Npgsql;
using System.Data;

namespace TattooStudio
{
    public partial class Client : Form
    {
        int rowId = 0;

        public Client()
        {
            InitializeComponent();
            databaseLoad();
        }

        private void databaseLoad()
        {
            ConnectionToDB connectionToDB = new ConnectionToDB();
            
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter
                    (@"select * from  ÎËÂÌÚ", connectionToDB.GetConnection());
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
                
                NpgsqlDataAdapter sqlDataAdapter = new NpgsqlDataAdapter
                   ($@"SELECT * FROM  ÎËÂÌÚ
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
                throw;
            }
            
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            changeVisibleBox();
            ConnectionToDB connectionToDB = new ConnectionToDB();
            
            NpgsqlDataAdapter sqlDataAdapter = new NpgsqlDataAdapter
               ($@"UPDATE  ÎËÂÌÚ SET surname='{clientSurname.Text}', name='{clientName.Text}', middlename='{clientMiddlename.Text}', 
                    date_of_birth='{dateBirthBox.Value.ToString("yyyy-MM-dd")}'
                    WHERE id_client='{rowId}'", connectionToDB.GetConnection());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            
            dataGridClient.Refresh();
            clearBox();
            databaseLoad();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ConnectionToDB connectionToDB = new ConnectionToDB();
            
            NpgsqlDataAdapter sqlDataAdapter = new NpgsqlDataAdapter
               ($@"INSERT INTO  ÎËÂÌÚ (surname, name, middlename, date_of_birth) 
                    VALUES ('{clientSurname.Text}', '{clientName.Text}', '{clientMiddlename.Text}', 
                    '{dateBirthBox.Value.ToString("yyyy-MM-dd")}')", connectionToDB.GetConnection());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            
            clearBox();
            databaseLoad();
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

        private void Û‰‡ÎËÚ¸ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectionToDB connectionToDB = new ConnectionToDB();
            
            NpgsqlDataAdapter sqlDataAdapter = new NpgsqlDataAdapter
               ($@"DELETE FROM  ÎËÂÌÚ WHRE id_client='{rowId}')", connectionToDB.GetConnection());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            
            databaseLoad();
        }
    }
}