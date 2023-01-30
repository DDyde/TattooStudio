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
        int rule = AccessLevel.rule;

        public Employee()
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
            comboBox();
            ConnectionToDB connectionToDB = new ConnectionToDB();

            MySqlDataAdapter npgsqlDataAdapter = new MySqlDataAdapter
                    (@"select id_employee, surname as Фамилия, name as Имя, middlename as Отчество, Должность.title as Должность, 
                        work_experience as Опыт, salary as Зарплата
                        from Сотрудник
                        JOIN Должность ON Должность.id_position = Сотрудник.id_position
                        WHERE title NOT LIKE '%_ату%' AND title NOT LIKE '%_ирсинг%' AND title NOT LIKE '%_атуаж%'", connectionToDB.GetConnection());
            DataTable dataTable = new DataTable();
            npgsqlDataAdapter.Fill(dataTable);
            dataGridEmployee.DataSource = dataTable;
            dataGridEmployee.Columns[0].Visible = false;
        }

        private void comboBox()
        {
            ConnectionToDB connectionToDB = new ConnectionToDB();
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(
                $@"SELECT id_position, title
                FROM Должность
                WHERE title NOT LIKE '%_ату%' AND title NOT LIKE '%_ирсинг%' AND title NOT LIKE '%_атуаж%'", connectionToDB.GetConnection());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            positionBox.DataSource = dataTable;
            positionBox.DisplayMember = "title";
            positionBox.ValueMember = "id_position";
        }

        private void dataGridEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                rowId = Convert.ToInt32(dataGridEmployee[0, e.RowIndex].Value);

                comboBox();
                ConnectionToDB connectionToDB = new ConnectionToDB();
                
                NpgsqlDataAdapter sqlDataAdapter = new NpgsqlDataAdapter
                   ($@"SELECT * FROM Сотрудник
                        WHERE id_employee={rowId}", connectionToDB.GetConnection());
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                employeeSurname.Text = dataTable.Rows[0][1].ToString();
                employeeName.Text = dataTable.Rows[0][2].ToString();
                employeeMiddlename.Text = dataTable.Rows[0][3].ToString();
                positionBox.SelectedValue= dataTable.Rows[0][6];
                workExp.Text = dataTable.Rows[0][5].ToString();
                salary.Text = dataTable.Rows[0][7].ToString();
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

                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter
                   ($@"UPDATE Сотрудник SET surname='{employeeSurname.Text}', name='{employeeName.Text}', middlename='{employeeMiddlename.Text}', 
                    id_position='{positionBox.SelectedValue}', work_experience='{workExp.Value.ToString()}', salary='{salary.Value.ToString()}'
                    WHERE id_employee='{rowId}'", connectionToDB.GetConnection());
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
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
                   ($@"INSERT INTO Сотрудник (surname, name, middlename, id_position, work_experience, salary) 
                    VALUES ('{employeeSurname.Text}', '{employeeName.Text}', '{employeeMiddlename.Text}', 
                    '{positionBox.SelectedValue}', '{workExp.Value.ToString()}', '{salary.Value.ToString()}')", connectionToDB.GetConnection());
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                databaseLoad();
            }
            else
            {
                MessageBox.Show("Недостаточный уровень доступа");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (rule == 1 || rule == 2)
            {
                ConnectionToDB connectionToDB = new ConnectionToDB();

                NpgsqlDataAdapter sqlDataAdapter = new NpgsqlDataAdapter
                   ($@"DELETE FROM Сотрудник WHERE id_employee={rowId}", connectionToDB.GetConnection());
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

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
            foreach (TextBox textBox in splitContainer.Panel2.Controls.OfType<TextBox>())
            {
                addButton.Visible = true;
                updateButton.Visible = false;
                deleteButton.Visible = false;
                textBox.Clear();
            }

            foreach (NumericUpDown numeric in splitContainer.Panel2.Controls.OfType<NumericUpDown>())
            {
                addButton.Visible = true;
                updateButton.Visible = false;
                deleteButton.Visible = false;
                numeric.Value = 0;
            }
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

        private void Employee_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
