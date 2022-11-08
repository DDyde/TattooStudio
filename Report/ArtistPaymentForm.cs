using Microsoft.Reporting.WinForms;
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

namespace TattooStudio.Report
{
    public partial class ArtistPaymentForm : Form
    {
        int rowId = 0;
        

        public ArtistPaymentForm(int _rowId)
        {
            InitializeComponent();
            rowId = _rowId;
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            string dateBegin = datePickerBegin.Value.ToString("dd-MM-yyyy");
            string dateEnd = datePickerEnd.Value.ToString("dd-MM-yyyy");

            ConnectionToDB connectionToDB = new ConnectionToDB();

            NpgsqlCommand command = new NpgsqlCommand($@"SELECT * FROM paymentbymonth
                                                        WHERE id_employee={rowId}
                                                        AND date_session BETWEEN '{dateBegin}' AND '{dateEnd}'", connectionToDB.GetConnection());
            NpgsqlDataAdapter sqlDataAdapter = new NpgsqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            reportArtist.LocalReport.DataSources.Clear();
            ReportDataSource source = new ReportDataSource("TattooStudio", dataTable);
            reportArtist.LocalReport.ReportPath = "Report/ArtistPayment.rdlc";
            reportArtist.LocalReport.DataSources.Add(source);
            reportArtist.LocalReport.Refresh();


            ReportParameter sumPrice = new ReportParameter("sumPrice", getSumPrice(dateBegin, dateEnd).Rows[0][0].ToString());
            this.reportArtist.LocalReport.SetParameters(sumPrice);

            ReportParameter salary = new ReportParameter("salary", getSalary().Rows[0][0].ToString());
            this.reportArtist.LocalReport.SetParameters(salary);

            reportArtist.RefreshReport();
        }

        private DataTable getSumPrice(string dateBegin, string dateEnd)
        {
            ConnectionToDB connectionToDB = new ConnectionToDB();

            NpgsqlCommand command = new NpgsqlCommand($@"SELECT (SUM(price) + Сотрудник.salary) FROM paymentbymonth
                                                        JOIN Сотрудник ON Сотрудник.id_employee = paymentbymonth.id_employee
                                                        WHERE paymentbymonth.id_employee={rowId}
                                                        AND date_session BETWEEN '{dateBegin}' AND '{dateEnd}'
                                                        Group by Сотрудник.id_employee", connectionToDB.GetConnection());
            NpgsqlDataAdapter sqlDataAdapter = new NpgsqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            return dataTable;
        }

        private DataTable getSalary()
        {
            ConnectionToDB connectionToDB = new ConnectionToDB();

            NpgsqlCommand command = new NpgsqlCommand($@"SELECT Сотрудник.salary FROM paymentbymonth
                                                        JOIN Сотрудник ON Сотрудник.id_employee = paymentbymonth.id_employee
                                                        WHERE paymentbymonth.id_employee={rowId}", connectionToDB.GetConnection());
            NpgsqlDataAdapter sqlDataAdapter = new NpgsqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            return dataTable;
        }
    }
}
