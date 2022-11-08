namespace TattooStudio
{
    partial class ServiceProvided
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
            this.dataGridServiceProvided = new System.Windows.Forms.DataGridView();
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
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.employeeBox = new System.Windows.Forms.ComboBox();
            this.typeOfServiceBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridServiceProvided)).BeginInit();
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
            this.splitContainer.Panel1.Controls.Add(this.dataGridServiceProvided);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.splitContainer.Panel2.Controls.Add(this.label2);
            this.splitContainer.Panel2.Controls.Add(this.label1);
            this.splitContainer.Panel2.Controls.Add(this.menuStrip);
            this.splitContainer.Panel2.Controls.Add(this.updateButton);
            this.splitContainer.Panel2.Controls.Add(this.deleteButton);
            this.splitContainer.Panel2.Controls.Add(this.addButton);
            this.splitContainer.Panel2.Controls.Add(this.employeeBox);
            this.splitContainer.Panel2.Controls.Add(this.typeOfServiceBox);
            this.splitContainer.Size = new System.Drawing.Size(800, 450);
            this.splitContainer.SplitterDistance = 612;
            this.splitContainer.TabIndex = 0;
            // 
            // dataGridServiceProvided
            // 
            this.dataGridServiceProvided.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridServiceProvided.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridServiceProvided.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridServiceProvided.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridServiceProvided.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridServiceProvided.Location = new System.Drawing.Point(0, 0);
            this.dataGridServiceProvided.Name = "dataGridServiceProvided";
            this.dataGridServiceProvided.RowTemplate.Height = 25;
            this.dataGridServiceProvided.Size = new System.Drawing.Size(612, 450);
            this.dataGridServiceProvided.TabIndex = 0;
            this.dataGridServiceProvided.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridServiceProvided_CellClick);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(184, 24);
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
            // updateButton
            // 
            this.updateButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.updateButton.Location = new System.Drawing.Point(9, 215);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(74, 23);
            this.updateButton.TabIndex = 28;
            this.updateButton.Text = "Изменить";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Visible = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Location = new System.Drawing.Point(100, 215);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(74, 25);
            this.deleteButton.TabIndex = 30;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Visible = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Location = new System.Drawing.Point(50, 214);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(74, 25);
            this.addButton.TabIndex = 29;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // employeeBox
            // 
            this.employeeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employeeBox.FormattingEnabled = true;
            this.employeeBox.Location = new System.Drawing.Point(2, 107);
            this.employeeBox.Name = "employeeBox";
            this.employeeBox.Size = new System.Drawing.Size(179, 23);
            this.employeeBox.TabIndex = 1;
            // 
            // typeOfServiceBox
            // 
            this.typeOfServiceBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeOfServiceBox.FormattingEnabled = true;
            this.typeOfServiceBox.Location = new System.Drawing.Point(2, 63);
            this.typeOfServiceBox.Name = "typeOfServiceBox";
            this.typeOfServiceBox.Size = new System.Drawing.Size(179, 23);
            this.typeOfServiceBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 32;
            this.label1.Text = "Вид услуги:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 33;
            this.label2.Text = "Сотрудник:";
            // 
            // ServiceProvided
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer);
            this.Name = "ServiceProvided";
            this.Text = "ServiceProvided";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridServiceProvided)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer;
        private DataGridView dataGridServiceProvided;
        private ComboBox employeeBox;
        private ComboBox typeOfServiceBox;
        private Button updateButton;
        private Button deleteButton;
        private Button addButton;
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
        private Label label2;
        private Label label1;
    }
}