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
    public partial class Employee : Form
    {
        int rowId = 0;

        public Employee()
        {
            InitializeComponent();
            databaseLoad();
        }

        private void databaseLoad()
        {
            ConnectionToDB connectionToDB = new ConnectionToDB();

            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter
                    (@"select surname, name, middlename, Должность.title, work_experience, salary
                        from Сотрудник
                        JOIN Должность ON Должность.id_position = Сотрудник.id_position", connectionToDB.GetConnection());
            DataTable dataTable = new DataTable();
            npgsqlDataAdapter.Fill(dataTable);
            dataGridEmployee.DataSource = dataTable;
            dataGridEmployee.Columns[0].Visible = false;

        }

        private void dataGridEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                rowId = Convert.ToInt32(dataGridEmployee[0, e.RowIndex].Value);

                if (dataGridEmployee[3,rowId].Value == "Тату мастер")
                {
                    Artist artist = new Artist(rowId);
                    artist.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
