namespace TattooStudio.Report
{
    partial class EveryPaymentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.reportEveryPayment = new Microsoft.Reporting.WinForms.ReportViewer();
            this.buttonReport = new System.Windows.Forms.Button();
            this.datePickerBegin = new System.Windows.Forms.DateTimePicker();
            this.labelDateBegin = new System.Windows.Forms.Label();
            this.labelDateEnd = new System.Windows.Forms.Label();
            this.datePickerEnd = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.reportEveryPayment);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.datePickerEnd);
            this.splitContainer1.Panel2.Controls.Add(this.labelDateEnd);
            this.splitContainer1.Panel2.Controls.Add(this.labelDateBegin);
            this.splitContainer1.Panel2.Controls.Add(this.datePickerBegin);
            this.splitContainer1.Panel2.Controls.Add(this.buttonReport);
            this.splitContainer1.Size = new System.Drawing.Size(825, 446);
            this.splitContainer1.SplitterDistance = 668;
            this.splitContainer1.TabIndex = 0;
            // 
            // reportEveryPayment
            // 
            this.reportEveryPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportEveryPayment.Location = new System.Drawing.Point(0, 0);
            this.reportEveryPayment.Name = "ReportViewer";
            this.reportEveryPayment.ServerReport.BearerToken = null;
            this.reportEveryPayment.Size = new System.Drawing.Size(668, 446);
            this.reportEveryPayment.TabIndex = 0;
            // 
            // buttonReport
            // 
            this.buttonReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReport.Location = new System.Drawing.Point(23, 241);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(103, 43);
            this.buttonReport.TabIndex = 0;
            this.buttonReport.Text = "Сформировать отчет";
            this.buttonReport.UseVisualStyleBackColor = true;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // datePickerBegin
            // 
            this.datePickerBegin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datePickerBegin.Location = new System.Drawing.Point(3, 65);
            this.datePickerBegin.Name = "datePickerBegin";
            this.datePickerBegin.Size = new System.Drawing.Size(144, 23);
            this.datePickerBegin.TabIndex = 1;
            // 
            // labelDateBegin
            // 
            this.labelDateBegin.AutoSize = true;
            this.labelDateBegin.Location = new System.Drawing.Point(3, 47);
            this.labelDateBegin.Name = "labelDateBegin";
            this.labelDateBegin.Size = new System.Drawing.Size(101, 15);
            this.labelDateBegin.TabIndex = 2;
            this.labelDateBegin.Text = "Начало периода:";
            // 
            // labelDateEnd
            // 
            this.labelDateEnd.AutoSize = true;
            this.labelDateEnd.Location = new System.Drawing.Point(3, 110);
            this.labelDateEnd.Name = "labelDateEnd";
            this.labelDateEnd.Size = new System.Drawing.Size(87, 15);
            this.labelDateEnd.TabIndex = 3;
            this.labelDateEnd.Text = "Конец период:";
            // 
            // datePickerEnd
            // 
            this.datePickerEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datePickerEnd.Location = new System.Drawing.Point(3, 128);
            this.datePickerEnd.Name = "datePickerEnd";
            this.datePickerEnd.Size = new System.Drawing.Size(144, 23);
            this.datePickerEnd.TabIndex = 4;
            // 
            // EveryPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 446);
            this.Controls.Add(this.splitContainer1);
            this.Name = "EveryPaymentForm";
            this.Text = "EveryPaymentForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportEveryPayment;
        private DateTimePicker datePickerEnd;
        private Label labelDateEnd;
        private Label labelDateBegin;
        private DateTimePicker datePickerBegin;
        private Button buttonReport;
    }
}