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
    public partial class ServiceType : Form
    {
        int rowId = 0;

        public ServiceType()
        {
            InitializeComponent();
            databaseLoad();
        }

        private void databaseLoad()
        {
            ConnectionToDB connectionToDB = new ConnectionToDB();

            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter
                    (@"select * from Тип_услуги", connectionToDB.GetConnection());
            DataTable dataTable = new DataTable();
            npgsqlDataAdapter.Fill(dataTable);
            dataGridServiceStatus.DataSource = dataTable;
            dataGridServiceStatus.Columns[0].Visible = false;

        }

        private void dataGridServiceStatus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                rowId = Convert.ToInt32(dataGridServiceStatus[0, e.RowIndex].Value);

                ConnectionToDB connectionToDB = new ConnectionToDB();

                NpgsqlDataAdapter sqlDataAdapter = new NpgsqlDataAdapter
                   ($@"SELECT * FROM Тип_услуги
                        WHERE id_service_type={rowId}", connectionToDB.GetConnection());
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                serviceStatusBox.Text = dataTable.Rows[0][1].ToString();

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
               ($@"UPDATE Тип_услуги SET title='{serviceStatusBox.Text}'
                    WHERE id_service_type='{rowId}'", connectionToDB.GetConnection());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            dataGridServiceStatus.Refresh();
            clearBox();
            databaseLoad();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ConnectionToDB connectionToDB = new ConnectionToDB();

            NpgsqlDataAdapter sqlDataAdapter = new NpgsqlDataAdapter
               ($@"INSERT INTO Тип_услуги (title) 
                    VALUES ('{serviceStatusBox.Text}'", connectionToDB.GetConnection());
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
            foreach (TextBox textBox in splitContainer.Panel2.Controls.OfType<TextBox>())
            {
                addButton.Visible = true;
                updateButton.Visible = false;
                deleteButton.Visible = false;
                textBox.Clear();
            }
        }
    }
}
