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

        public SesssionStatus()
        {
            InitializeComponent();
            databaseLoad();
        }

        private void databaseLoad()
        {
            ConnectionToDB connectionToDB = new ConnectionToDB();

            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter
                    (@"select * from Статус_сеанса", connectionToDB.GetConnection());
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
               ($@"UPDATE Статус_сеанса SET title='{sessionStatusBox.Text}'
                    WHERE id_session_status='{rowId}'", connectionToDB.GetConnection());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            dataGridSessionStatus.Refresh();
            clearBox();
            databaseLoad();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ConnectionToDB connectionToDB = new ConnectionToDB();

            NpgsqlDataAdapter sqlDataAdapter = new NpgsqlDataAdapter
               ($@"INSERT INTO Статус_сеанса (title) 
                    VALUES ('{sessionStatusBox.Text}'", connectionToDB.GetConnection());
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
