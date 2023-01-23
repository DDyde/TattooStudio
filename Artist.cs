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
using TattooStudio.Report;

namespace TattooStudio
{
    public partial class Artist : Form
    {
        int rowId=0;
        int rule = AccessLevel.rule;

        public Artist()
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
                    (@"select id_employee, surname as Фамилия, name as Имя, middlename as Отчество, Должность.title as Должность,work_experience as Опыт, salary as Зарплата
                    from employeemaster
                    join Должность ON Должность.id_position = employeemaster.id_position", connectionToDB.GetConnection());
            DataTable dataTable = new DataTable();
            npgsqlDataAdapter.Fill(dataTable);
            dataGridArtist.DataSource = dataTable;
            dataGridArtist.Columns[0].Visible = false;
            getComboBox();
        }

        private void getComboBox()
        {
            ConnectionToDB connectionToDB = new ConnectionToDB();

            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter
                    (@"select id_position, title
                    from Должность
                    where title like '%_ату%' or title like '%_ирсинг%' or title like '%_атуаж%'", connectionToDB.GetConnection());
            DataTable dataTable = new DataTable();
            npgsqlDataAdapter.Fill(dataTable);
            comboBoxPosition.DataSource = dataTable;
            comboBoxPosition.DisplayMember = "title";
            comboBoxPosition.ValueMember = "id_position";
        }

        private void dataGridArtist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                rowId = Convert.ToInt32(dataGridArtist[0, e.RowIndex].Value);
                ArtistEdit artistEdit = new ArtistEdit(rowId);
                artistEdit.ShowDialog();
                databaseLoad();
            }
            catch (Exception) 
            {
                ArtistEdit artistEdit = new ArtistEdit();
                artistEdit.ShowDialog();
                databaseLoad();
            }

        }

        private void toolStripEmployee_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.Show();
            this.Hide();
        }

        private void toolStripClient_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.Show();
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

        private void отчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EveryPaymentForm everyPaymentForm = new EveryPaymentForm();
            everyPaymentForm.ShowDialog();
        }

        private void buttonAccess_Click(object sender, EventArgs e)
        {
            DataTable dataTable = dataGridArtist.DataSource as DataTable;

            string searchValue = comboBoxPosition.Text;
            try
            {
                dataTable.DefaultView.RowFilter = $@"Должность = '{searchValue}'";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            databaseLoad();
        }

        private void Artist_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
