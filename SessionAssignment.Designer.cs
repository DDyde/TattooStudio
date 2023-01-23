namespace TattooStudio
{
    partial class SessionAssignment
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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.dataGridSessionAssignment = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripClient = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.мастераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeOfServiceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.positionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceProvidedMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sessionStatusMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceTypeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sessionAssignmentMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeSession = new System.Windows.Forms.DateTimePicker();
            this.dateSession = new System.Windows.Forms.DateTimePicker();
            this.sessionStatusBox = new System.Windows.Forms.ComboBox();
            this.serviceProvidedBox = new System.Windows.Forms.ComboBox();
            this.clientBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSessionAssignment)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.dataGridSessionAssignment);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.BackColor = System.Drawing.Color.Black;
            this.splitContainer.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer.Panel2.Controls.Add(this.label5);
            this.splitContainer.Panel2.Controls.Add(this.label4);
            this.splitContainer.Panel2.Controls.Add(this.label3);
            this.splitContainer.Panel2.Controls.Add(this.label2);
            this.splitContainer.Panel2.Controls.Add(this.label1);
            this.splitContainer.Panel2.Controls.Add(this.menuStrip);
            this.splitContainer.Panel2.Controls.Add(this.timeSession);
            this.splitContainer.Panel2.Controls.Add(this.dateSession);
            this.splitContainer.Panel2.Controls.Add(this.sessionStatusBox);
            this.splitContainer.Panel2.Controls.Add(this.serviceProvidedBox);
            this.splitContainer.Panel2.Controls.Add(this.clientBox);
            this.splitContainer.Size = new System.Drawing.Size(800, 397);
            this.splitContainer.SplitterDistance = 564;
            this.splitContainer.TabIndex = 0;
            // 
            // dataGridSessionAssignment
            // 
            this.dataGridSessionAssignment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridSessionAssignment.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridSessionAssignment.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridSessionAssignment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSessionAssignment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridSessionAssignment.Location = new System.Drawing.Point(0, 0);
            this.dataGridSessionAssignment.Name = "dataGridSessionAssignment";
            this.dataGridSessionAssignment.RowTemplate.Height = 25;
            this.dataGridSessionAssignment.Size = new System.Drawing.Size(564, 397);
            this.dataGridSessionAssignment.TabIndex = 0;
            this.dataGridSessionAssignment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSessionAssignment_CellClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.01961F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.98039F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel1.Controls.Add(this.addButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.deleteButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.updateButton, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 295);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(226, 40);
            this.tableLayoutPanel1.TabIndex = 36;
            // 
            // addButton
            // 
            this.addButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addButton.Location = new System.Drawing.Point(78, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(72, 34);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteButton.Location = new System.Drawing.Point(156, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(67, 34);
            this.deleteButton.TabIndex = 12;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Visible = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updateButton.Location = new System.Drawing.Point(3, 3);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(69, 34);
            this.updateButton.TabIndex = 9;
            this.updateButton.Text = "Изменить";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Visible = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "Время:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Дата:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Статус сеанса:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Предоставляемая услуга:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Клиенты:";
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(232, 24);
            this.menuStrip.TabIndex = 16;
            this.menuStrip.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripClient,
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
            // toolStripClient
            // 
            this.toolStripClient.Name = "toolStripClient";
            this.toolStripClient.Size = new System.Drawing.Size(215, 22);
            this.toolStripClient.Text = "Клиенты";
            this.toolStripClient.Click += new System.EventHandler(this.clientToolStripMenuItem_Click);
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
            this.мастераToolStripMenuItem.Click += new System.EventHandler(this.masterToolStripMenuItem_Click);
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
            // timeSession
            // 
            this.timeSession.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeSession.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeSession.Location = new System.Drawing.Point(3, 238);
            this.timeSession.Name = "timeSession";
            this.timeSession.ShowUpDown = true;
            this.timeSession.Size = new System.Drawing.Size(226, 23);
            this.timeSession.TabIndex = 4;
            // 
            // dateSession
            // 
            this.dateSession.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateSession.CustomFormat = "yyyy-MM-dd";
            this.dateSession.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateSession.Location = new System.Drawing.Point(3, 194);
            this.dateSession.Name = "dateSession";
            this.dateSession.Size = new System.Drawing.Size(226, 23);
            this.dateSession.TabIndex = 3;
            // 
            // sessionStatusBox
            // 
            this.sessionStatusBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sessionStatusBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sessionStatusBox.FormattingEnabled = true;
            this.sessionStatusBox.Location = new System.Drawing.Point(3, 150);
            this.sessionStatusBox.Name = "sessionStatusBox";
            this.sessionStatusBox.Size = new System.Drawing.Size(226, 23);
            this.sessionStatusBox.TabIndex = 2;
            // 
            // serviceProvidedBox
            // 
            this.serviceProvidedBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serviceProvidedBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serviceProvidedBox.FormattingEnabled = true;
            this.serviceProvidedBox.Location = new System.Drawing.Point(3, 106);
            this.serviceProvidedBox.Name = "serviceProvidedBox";
            this.serviceProvidedBox.Size = new System.Drawing.Size(226, 23);
            this.serviceProvidedBox.TabIndex = 1;
            // 
            // clientBox
            // 
            this.clientBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientBox.FormattingEnabled = true;
            this.clientBox.Location = new System.Drawing.Point(3, 62);
            this.clientBox.Name = "clientBox";
            this.clientBox.Size = new System.Drawing.Size(226, 23);
            this.clientBox.TabIndex = 0;
            // 
            // SessionAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 397);
            this.Controls.Add(this.splitContainer);
            this.MinimumSize = new System.Drawing.Size(816, 436);
            this.Name = "SessionAssignment";
            this.Text = "SessionAssignment";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SessionAssignment_FormClosed);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSessionAssignment)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer;
        private DataGridView dataGridSessionAssignment;
        private DateTimePicker timeSession;
        private DateTimePicker dateSession;
        private ComboBox sessionStatusBox;
        private ComboBox serviceProvidedBox;
        private ComboBox clientBox;
        private MenuStrip menuStrip;
        private ToolStripMenuItem менюToolStripMenuItem;
        private ToolStripMenuItem toolStripClient;
        private ToolStripMenuItem toolStripEmployee;
        private ToolStripMenuItem мастераToolStripMenuItem;
        private ToolStripMenuItem typeOfServiceMenuItem;
        private ToolStripMenuItem positionMenuItem;
        private ToolStripMenuItem serviceProvidedMenuItem;
        private ToolStripMenuItem sessionStatusMenuItem;
        private ToolStripMenuItem serviceTypeMenuItem;
        private ToolStripMenuItem sessionAssignmentMenuItem;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button addButton;
        private Button deleteButton;
        private Button updateButton;
    }
}