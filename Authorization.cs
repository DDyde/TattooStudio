using MySql.Data.MySqlClient;
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
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void accountLoginButton_Click(object sender, EventArgs e)
        {
            ConnectionToDB connectionToDB = new ConnectionToDB();

            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter
                    (@$"select *
                       from Пользователь
                       where login = '{loginBox.Text}' and password = '{passwordBox.Text}'", connectionToDB.GetConnection());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            
            if (dataTable.Rows.Count == 1)
            {
                AccessLevel.rule = Int16.Parse(dataTable.Rows[0][4].ToString());
                SessionAssignment sessionAssignment = new SessionAssignment();
                sessionAssignment.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Не верный логин или пароль");
            }
        }
    }
}
