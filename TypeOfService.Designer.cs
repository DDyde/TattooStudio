namespace TattooStudio
{
    partial class TypeOfService
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
            this.dataGridTypeOfService = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.typeServiceComboBox = new System.Windows.Forms.ComboBox();
            this.priceBox = new System.Windows.Forms.NumericUpDown();
            this.typeServiceBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTypeOfService)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceBox)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.dataGridTypeOfService);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.splitContainer.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer.Panel2.Controls.Add(this.label3);
            this.splitContainer.Panel2.Controls.Add(this.label2);
            this.splitContainer.Panel2.Controls.Add(this.label1);
            this.splitContainer.Panel2.Controls.Add(this.menuStrip);
            this.splitContainer.Panel2.Controls.Add(this.typeServiceComboBox);
            this.splitContainer.Panel2.Controls.Add(this.priceBox);
            this.splitContainer.Panel2.Controls.Add(this.typeServiceBox);
            this.splitContainer.Size = new System.Drawing.Size(800, 365);
            this.splitContainer.SplitterDistance = 570;
            this.splitContainer.TabIndex = 0;
            // 
            // dataGridTypeOfService
            // 
            this.dataGridTypeOfService.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridTypeOfService.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridTypeOfService.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridTypeOfService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTypeOfService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridTypeOfService.Location = new System.Drawing.Point(0, 0);
            this.dataGridTypeOfService.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridTypeOfService.Name = "dataGridTypeOfService";
            this.dataGridTypeOfService.RowHeadersWidth = 51;
            this.dataGridTypeOfService.RowTemplate.Height = 29;
            this.dataGridTypeOfService.Size = new System.Drawing.Size(570, 365);
            this.dataGridTypeOfService.TabIndex = 0;
            this.dataGridTypeOfService.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridTypeOfService_CellClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.66887F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.33113F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.Controls.Add(this.addButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.deleteButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.updateButton, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 275);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(220, 40);
            this.tableLayoutPanel1.TabIndex = 38;
            // 
            // addButton
            // 
            this.addButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addButton.Location = new System.Drawing.Point(79, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(72, 34);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteButton.Location = new System.Drawing.Point(157, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(60, 34);
            this.deleteButton.TabIndex = 12;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Visible = false;
            // 
            // updateButton
            // 
            this.updateButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updateButton.Location = new System.Drawing.Point(3, 3);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(70, 34);
            this.updateButton.TabIndex = 9;
            this.updateButton.Text = "Изменить";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 34;
            this.label3.Text = "Цена:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 33;
            this.label2.Text = "Тип услуги:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 32;
            this.label1.Text = "Название услуги:";
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(226, 24);
            this.menuStrip.TabIndex = 31;
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
            this.toolStripTextBox1.Click += new System.EventHandler(this.clientToolStripMenuItem_Click);
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
            // typeServiceComboBox
            // 
            this.typeServiceComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.typeServiceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeServiceComboBox.FormattingEnabled = true;
            this.typeServiceComboBox.Location = new System.Drawing.Point(4, 141);
            this.typeServiceComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.typeServiceComboBox.Name = "typeServiceComboBox";
            this.typeServiceComboBox.Size = new System.Drawing.Size(217, 23);
            this.typeServiceComboBox.TabIndex = 2;
            // 
            // priceBox
            // 
            this.priceBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.priceBox.DecimalPlaces = 2;
            this.priceBox.Location = new System.Drawing.Point(4, 198);
            this.priceBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.priceBox.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(217, 23);
            this.priceBox.TabIndex = 1;
            // 
            // typeServiceBox
            // 
            this.typeServiceBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.typeServiceBox.Location = new System.Drawing.Point(4, 83);
            this.typeServiceBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.typeServiceBox.Name = "typeServiceBox";
            this.typeServiceBox.Size = new System.Drawing.Size(217, 23);
            this.typeServiceBox.TabIndex = 0;
            // 
            // TypeOfService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 365);
            this.Controls.Add(this.splitContainer);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(816, 404);
            this.Name = "TypeOfService";
            this.Text = "TypeOfService";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TypeOfService_FormClosed);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTypeOfService)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer;
        private DataGridView dataGridTypeOfService;
        private ComboBox typeServiceComboBox;
        private NumericUpDown priceBox;
        private TextBox typeServiceBox;
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
        private Label label1;
        private Label label3;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private Button addButton;
        private Button deleteButton;
        private Button updateButton;
    }
}