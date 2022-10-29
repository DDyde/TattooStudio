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

        public TypeOfService()
        {
            InitializeComponent();
            databaseLoad();
        }

        private void databaseLoad()
        {
            ConnectionToDB connectionToDB = new ConnectionToDB();

            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter
                    (@"SELECT Вид_услуги.title as Название, Тип_услуги.title as Тип_услуги,
                        Вид_услуги.price as Цена
                        FROM Вид_услуги
                        JOIN Тип_услуги ON Тип_услуги.id_service_type = Вид_услуги.id_service_type", connectionToDB.GetConnection());
            DataTable dataTable = new DataTable();
            npgsqlDataAdapter.Fill(dataTable);
            dataGridTypeOfService.DataSource = dataTable;
            dataGridTypeOfService.Columns[0].Visible = false;

        }

        private void dataGridTypeOfService_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                rowId = Convert.ToInt32(dataGridTypeOfService[0, e.RowIndex].Value);

                ConnectionToDB connectionToDB = new ConnectionToDB();

                NpgsqlDataAdapter sqlDataAdapter = new NpgsqlDataAdapter
                   ($@"SELECT * FROM Вид_услуги
                        WHERE id_type_of_service={rowId}", connectionToDB.GetConnection());
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                typeServiceBox.Text = dataTable.Rows[0][1].ToString();
                typeServiceComboBox.SelectedValue = dataTable.Rows[0][2].ToString();
                priceBox.Text = dataTable.Rows[0][3].ToString();

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
               ($@"UPDATE Вид_услуги SET title='{typeServiceBox.Text}', price='{priceBox.Text}', id_service_type='{typeServiceComboBox.Text}'
                    WHERE id_type_of_service='{rowId}'", connectionToDB.GetConnection());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            dataGridTypeOfService.Refresh();
            clearBox();
            databaseLoad();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ConnectionToDB connectionToDB = new ConnectionToDB();

            NpgsqlDataAdapter sqlDataAdapter = new NpgsqlDataAdapter
               ($@"INSERT INTO Вид_услуги (title, price, id_service_type) 
                    VALUES ('{typeServiceBox.Text}', '{priceBox.Text}', '{typeServiceComboBox.SelectedValue}')", connectionToDB.GetConnection());
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
