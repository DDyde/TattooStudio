namespace TattooStudio.Report
{
    partial class ArtistPaymentForm
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
            this.reportArtist = new Microsoft.Reporting.WinForms.ReportViewer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonReport = new System.Windows.Forms.Button();
            this.labelDateEnd = new System.Windows.Forms.Label();
            this.labelDateBegin = new System.Windows.Forms.Label();
            this.datePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.datePickerBegin = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportArtist
            // 
            this.reportArtist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportArtist.Location = new System.Drawing.Point(0, 0);
            this.reportArtist.Name = "ReportViewer";
            this.reportArtist.ServerReport.BearerToken = null;
            this.reportArtist.Size = new System.Drawing.Size(754, 450);
            this.reportArtist.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.reportArtist);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.buttonReport);
            this.splitContainer1.Panel2.Controls.Add(this.labelDateEnd);
            this.splitContainer1.Panel2.Controls.Add(this.labelDateBegin);
            this.splitContainer1.Panel2.Controls.Add(this.datePickerEnd);
            this.splitContainer1.Panel2.Controls.Add(this.datePickerBegin);
            this.splitContainer1.Size = new System.Drawing.Size(889, 450);
            this.splitContainer1.SplitterDistance = 754;
            this.splitContainer1.TabIndex = 1;
            // 
            // buttonReport
            // 
            this.buttonReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReport.Location = new System.Drawing.Point(3, 237);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(124, 39);
            this.buttonReport.TabIndex = 4;
            this.buttonReport.Text = "Cформировать отчет";
            this.buttonReport.UseVisualStyleBackColor = true;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // labelDateEnd
            // 
            this.labelDateEnd.AutoSize = true;
            this.labelDateEnd.Location = new System.Drawing.Point(3, 155);
            this.labelDateEnd.Name = "labelDateEnd";
            this.labelDateEnd.Size = new System.Drawing.Size(93, 15);
            this.labelDateEnd.TabIndex = 3;
            this.labelDateEnd.Text = "Конец периода:";
            // 
            // labelDateBegin
            // 
            this.labelDateBegin.AutoSize = true;
            this.labelDateBegin.Location = new System.Drawing.Point(3, 67);
            this.labelDateBegin.Name = "labelDateBegin";
            this.labelDateBegin.Size = new System.Drawing.Size(101, 15);
            this.labelDateBegin.TabIndex = 2;
            this.labelDateBegin.Text = "Начало периода:";
            // 
            // datePickerEnd
            // 
            this.datePickerEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datePickerEnd.Location = new System.Drawing.Point(3, 173);
            this.datePickerEnd.Name = "datePickerEnd";
            this.datePickerEnd.Size = new System.Drawing.Size(124, 23);
            this.datePickerEnd.TabIndex = 1;
            // 
            // datePickerBegin
            // 
            this.datePickerBegin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datePickerBegin.Location = new System.Drawing.Point(3, 85);
            this.datePickerBegin.Name = "datePickerBegin";
            this.datePickerBegin.Size = new System.Drawing.Size(124, 23);
            this.datePickerBegin.TabIndex = 0;
            // 
            // ArtistPaymentForm
            // 
            this.ClientSize = new System.Drawing.Size(889, 450);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(905, 330);
            this.Name = "ArtistPaymentForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportArtist;
        private SplitContainer splitContainer1;
        private Button buttonReport;
        private Label labelDateEnd;
        private Label labelDateBegin;
        private DateTimePicker datePickerEnd;
        private DateTimePicker datePickerBegin;
    }
}