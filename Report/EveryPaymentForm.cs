using Microsoft.Reporting.WinForms;
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

namespace TattooStudio.Report
{
    public partial class EveryPaymentForm : Form
    {
        public EveryPaymentForm()
        {
            InitializeComponent();
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            string dateBegin = datePickerBegin.Value.ToString("dd-MM-yyyy");
            string dateEnd = datePickerEnd.Value.ToString("dd-MM-yyyy");

            ConnectionToDB connectionToDB = new ConnectionToDB();

            NpgsqlCommand command = new NpgsqlCommand($@"SELECT * FROM paymentbymonth
                                                         WHERE date_session BETWEEN '{dateBegin}' AND '{dateEnd}'", connectionToDB.GetConnection());
            NpgsqlDataAdapter sqlDataAdapter = new NpgsqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            reportEveryPayment.LocalReport.DataSources.Clear();
            ReportDataSource source = new ReportDataSource("TattooStudio", dataTable);
            reportEveryPayment.LocalReport.ReportPath = "Report/EveryPayment.rdlc";
            reportEveryPayment.LocalReport.DataSources.Add(source);
            reportEveryPayment.LocalReport.Refresh();

            ReportParameter result = new ReportParameter("result", getResult(dateBegin, dateEnd).Rows[0][0].ToString());
            this.reportEveryPayment.LocalReport.SetParameters(result);

            reportEveryPayment.RefreshReport();
        }

        private DataTable getResult(string dateBegin, string dateEnd)
        {
            ConnectionToDB connectionToDB = new ConnectionToDB();

            NpgsqlCommand command = new NpgsqlCommand($@"SELECT SUM(price) 
                                                        FROM paymentbymonth
                                                        WHERE date_session BETWEEN '{dateBegin}' AND '{dateEnd}'", connectionToDB.GetConnection());
            NpgsqlDataAdapter sqlDataAdapter = new NpgsqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            return dataTable;
        }
    }
}
