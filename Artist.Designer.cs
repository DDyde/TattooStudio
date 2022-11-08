namespace TattooStudio
{
    partial class Artist
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
            this.dataGridArtist = new System.Windows.Forms.DataGridView();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.мастераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeOfServiceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.positionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceProvidedMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sessionStatusMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceTypeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sessionAssignmentMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAccess = new System.Windows.Forms.Button();
            this.labelPosition = new System.Windows.Forms.Label();
            this.comboBoxPosition = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridArtist)).BeginInit();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridArtist
            // 
            this.dataGridArtist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridArtist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridArtist.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridArtist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridArtist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridArtist.Location = new System.Drawing.Point(0, 0);
            this.dataGridArtist.Name = "dataGridArtist";
            this.dataGridArtist.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridArtist.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataGridArtist.RowTemplate.Height = 25;
            this.dataGridArtist.Size = new System.Drawing.Size(522, 388);
            this.dataGridArtist.TabIndex = 0;
            this.dataGridArtist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridArtist_CellClick);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.отчетToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(698, 24);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.toolStripEmployee,
            this.мастераToolStripMenuItem,
            this.typeOfServiceMenuItem,
            this.positionMenuItem,
            this.serviceProvidedMenuItem,
            this.sessionStatusMenuItem,
            this.serviceTypeMenuItem,
            this.sessionAssignmentMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(215, 22);
            this.toolStripTextBox1.Text = "Клиенты";
            this.toolStripTextBox1.Click += new System.EventHandler(this.toolStripClient_Click);
            // 
            // toolStripEmployee
            // 
            this.toolStripEmployee.Name = "toolStripEmployee";
            this.toolStripEmployee.Size = new System.Drawing.Size(215, 22);
            this.toolStripEmployee.Text = "Сотрудники";
            this.toolStripEmployee.Click += new System.EventHandler(this.toolStripEmployee_Click);
            // 
            // мастераToolStripMenuItem
            // 
            this.мастераToolStripMenuItem.Name = "мастераToolStripMenuItem";
            this.мастераToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.мастераToolStripMenuItem.Text = "Мастера";
            // 
            // typeOfServiceMenuItem
            // 
            this.typeOfServiceMenuItem.Name = "typeOfServiceMenuItem";
            this.typeOfServiceMenuItem.Size = new System.Drawing.Size(215, 22);
            this.typeOfServiceMenuItem.Text = "Виды услуг";
            this.typeOfServiceMenuItem.Click += new System.EventHandler(this.typeOfServiceMenuItem_Click);
            // 
            // positionMenuItem
            // 
            this.positionMenuItem.Name = "positionMenuItem";
            this.positionMenuItem.Size = new System.Drawing.Size(215, 22);
            this.positionMenuItem.Text = "Должности";
            this.positionMenuItem.Click += new System.EventHandler(this.positionMenuItem_Click);
            // 
            // serviceProvidedMenuItem
            // 
            this.serviceProvidedMenuItem.Name = "serviceProvidedMenuItem";
            this.serviceProvidedMenuItem.Size = new System.Drawing.Size(215, 22);
            this.serviceProvidedMenuItem.Text = "Предоставляемые услуги";
            this.serviceProvidedMenuItem.Click += new System.EventHandler(this.serviceProvidedMenuItem_Click);
            // 
            // sessionStatusMenuItem
            // 
            this.sessionStatusMenuItem.Name = "sessionStatusMenuItem";
            this.sessionStatusMenuItem.Size = new System.Drawing.Size(215, 22);
            this.sessionStatusMenuItem.Text = "Статус сеанса";
            this.sessionStatusMenuItem.Click += new System.EventHandler(this.sessionStatusMenuItem_Click);
            // 
            // serviceTypeMenuItem
            // 
            this.serviceTypeMenuItem.Name = "serviceTypeMenuItem";
            this.serviceTypeMenuItem.Size = new System.Drawing.Size(215, 22);
            this.serviceTypeMenuItem.Text = "Тип услуг";
            this.serviceTypeMenuItem.Click += new System.EventHandler(this.serviceTypeMenuItem_Click);
            // 
            // sessionAssignmentMenuItem
            // 
            this.sessionAssignmentMenuItem.Name = "sessionAssignmentMenuItem";
            this.sessionAssignmentMenuItem.Size = new System.Drawing.Size(215, 22);
            this.sessionAssignmentMenuItem.Text = "Назначение сеанса";
            this.sessionAssignmentMenuItem.Click += new System.EventHandler(this.sessionAssignmentMenuItem_Click);
            // 
            // отчетToolStripMenuItem
            // 
            this.отчетToolStripMenuItem.Name = "отчетToolStripMenuItem";
            this.отчетToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.отчетToolStripMenuItem.Text = "Отчет";
            this.отчетToolStripMenuItem.Click += new System.EventHandler(this.отчетToolStripMenuItem_Click);
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 24);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.dataGridArtist);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.BackColor = System.Drawing.Color.Black;
            this.splitContainer.Panel2.Controls.Add(this.buttonCancel);
            this.splitContainer.Panel2.Controls.Add(this.buttonAccess);
            this.splitContainer.Panel2.Controls.Add(this.labelPosition);
            this.splitContainer.Panel2.Controls.Add(this.comboBoxPosition);
            this.splitContainer.Size = new System.Drawing.Size(698, 388);
            this.splitContainer.SplitterDistance = 522;
            this.splitContainer.TabIndex = 5;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(45, 247);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Сброс";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAccess
            // 
            this.buttonAccess.Location = new System.Drawing.Point(45, 218);
            this.buttonAccess.Name = "buttonAccess";
            this.buttonAccess.Size = new System.Drawing.Size(75, 23);
            this.buttonAccess.TabIndex = 2;
            this.buttonAccess.Text = "Принять";
            this.buttonAccess.UseVisualStyleBackColor = true;
            this.buttonAccess.Click += new System.EventHandler(this.buttonAccess_Click);
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.BackColor = System.Drawing.Color.Black;
            this.labelPosition.ForeColor = System.Drawing.Color.White;
            this.labelPosition.Location = new System.Drawing.Point(3, 60);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(72, 15);
            this.labelPosition.TabIndex = 1;
            this.labelPosition.Text = "Должность:";
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPosition.FormattingEnabled = true;
            this.comboBoxPosition.Location = new System.Drawing.Point(3, 78);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(166, 23);
            this.comboBoxPosition.TabIndex = 0;
            // 
            // Artist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 412);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.menuStrip);
            this.Name = "Artist";
            this.Text = "Artist";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridArtist)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridArtist;
        private MenuStrip menuStrip;
        private ToolStripMenuItem менюToolStripMenuItem;
        private ToolStripMenuItem toolStripTextBox1;
        private ToolStripMenuItem toolStripEmployee;
        private ToolStripMenuItem мастераToolStripMenuItem;
        private ToolStripMenuItem typeOfServiceMenuItem;
        private ToolStripMenuItem positionMenuItem;
        private ToolStripMenuItem serviceProvidedMenuItem;
        private ToolStripMenuItem sessionStatusMenuItem;
        private ToolStripMenuItem serviceTypeMenuItem;
        private ToolStripMenuItem sessionAssignmentMenuItem;
        private ToolStripMenuItem отчетToolStripMenuItem;
        private SplitContainer splitContainer;
        private Label labelPosition;
        private ComboBox comboBoxPosition;
        private Button buttonCancel;
        private Button buttonAccess;
    }
}