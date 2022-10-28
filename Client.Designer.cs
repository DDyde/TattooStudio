﻿namespace TattooStudio
{
    partial class Client
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitClientContainer = new System.Windows.Forms.SplitContainer();
            this.dataGridClient = new System.Windows.Forms.DataGridView();
            this.deleteButton = new System.Windows.Forms.Button();
            this.dateBirthBox = new System.Windows.Forms.DateTimePicker();
            this.addButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.middlenameClientLabel = new System.Windows.Forms.Label();
            this.nameClientLabel = new System.Windows.Forms.Label();
            this.surnameClientLabel = new System.Windows.Forms.Label();
            this.clientMiddlename = new System.Windows.Forms.TextBox();
            this.clientName = new System.Windows.Forms.TextBox();
            this.clientSurname = new System.Windows.Forms.TextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitClientContainer)).BeginInit();
            this.splitClientContainer.Panel1.SuspendLayout();
            this.splitClientContainer.Panel2.SuspendLayout();
            this.splitClientContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClient)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitClientContainer
            // 
            this.splitClientContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitClientContainer.Location = new System.Drawing.Point(0, 0);
            this.splitClientContainer.Name = "splitClientContainer";
            // 
            // splitClientContainer.Panel1
            // 
            this.splitClientContainer.Panel1.Controls.Add(this.dataGridClient);
            // 
            // splitClientContainer.Panel2
            // 
            this.splitClientContainer.Panel2.Controls.Add(this.deleteButton);
            this.splitClientContainer.Panel2.Controls.Add(this.dateBirthBox);
            this.splitClientContainer.Panel2.Controls.Add(this.addButton);
            this.splitClientContainer.Panel2.Controls.Add(this.updateButton);
            this.splitClientContainer.Panel2.Controls.Add(this.label1);
            this.splitClientContainer.Panel2.Controls.Add(this.middlenameClientLabel);
            this.splitClientContainer.Panel2.Controls.Add(this.nameClientLabel);
            this.splitClientContainer.Panel2.Controls.Add(this.surnameClientLabel);
            this.splitClientContainer.Panel2.Controls.Add(this.clientMiddlename);
            this.splitClientContainer.Panel2.Controls.Add(this.clientName);
            this.splitClientContainer.Panel2.Controls.Add(this.clientSurname);
            this.splitClientContainer.Panel2.Controls.Add(this.menuStrip);
            this.splitClientContainer.Size = new System.Drawing.Size(800, 450);
            this.splitClientContainer.SplitterDistance = 612;
            this.splitClientContainer.TabIndex = 0;
            // 
            // dataGridClient
            // 
            this.dataGridClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridClient.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridClient.Location = new System.Drawing.Point(0, 0);
            this.dataGridClient.Name = "dataGridClient";
            this.dataGridClient.ReadOnly = true;
            this.dataGridClient.RowTemplate.Height = 25;
            this.dataGridClient.Size = new System.Drawing.Size(612, 450);
            this.dataGridClient.TabIndex = 0;
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Location = new System.Drawing.Point(97, 321);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 25);
            this.deleteButton.TabIndex = 12;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Visible = false;
            // 
            // dateBirthBox
            // 
            this.dateBirthBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateBirthBox.Location = new System.Drawing.Point(6, 245);
            this.dateBirthBox.Name = "dateBirthBox";
            this.dateBirthBox.Size = new System.Drawing.Size(174, 23);
            this.dateBirthBox.TabIndex = 11;
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Location = new System.Drawing.Point(52, 321);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 25);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.updateButton.Location = new System.Drawing.Point(6, 321);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 9;
            this.updateButton.Text = "Изменить";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Visible = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Дата рождения";
            // 
            // middlenameClientLabel
            // 
            this.middlenameClientLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.middlenameClientLabel.AutoSize = true;
            this.middlenameClientLabel.Location = new System.Drawing.Point(6, 173);
            this.middlenameClientLabel.Name = "middlenameClientLabel";
            this.middlenameClientLabel.Size = new System.Drawing.Size(58, 15);
            this.middlenameClientLabel.TabIndex = 6;
            this.middlenameClientLabel.Text = "Отчество";
            // 
            // nameClientLabel
            // 
            this.nameClientLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameClientLabel.AutoSize = true;
            this.nameClientLabel.Location = new System.Drawing.Point(6, 111);
            this.nameClientLabel.Name = "nameClientLabel";
            this.nameClientLabel.Size = new System.Drawing.Size(31, 15);
            this.nameClientLabel.TabIndex = 5;
            this.nameClientLabel.Text = "Имя";
            // 
            // surnameClientLabel
            // 
            this.surnameClientLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.surnameClientLabel.AutoSize = true;
            this.surnameClientLabel.Location = new System.Drawing.Point(6, 54);
            this.surnameClientLabel.Name = "surnameClientLabel";
            this.surnameClientLabel.Size = new System.Drawing.Size(58, 15);
            this.surnameClientLabel.TabIndex = 4;
            this.surnameClientLabel.Text = "Фамилия";
            // 
            // clientMiddlename
            // 
            this.clientMiddlename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientMiddlename.Location = new System.Drawing.Point(2, 191);
            this.clientMiddlename.Name = "clientMiddlename";
            this.clientMiddlename.Size = new System.Drawing.Size(178, 23);
            this.clientMiddlename.TabIndex = 2;
            // 
            // clientName
            // 
            this.clientName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientName.Location = new System.Drawing.Point(3, 129);
            this.clientName.Name = "clientName";
            this.clientName.Size = new System.Drawing.Size(178, 23);
            this.clientName.TabIndex = 1;
            // 
            // clientSurname
            // 
            this.clientSurname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientSurname.Location = new System.Drawing.Point(3, 72);
            this.clientSurname.Name = "clientSurname";
            this.clientSurname.Size = new System.Drawing.Size(179, 23);
            this.clientSurname.TabIndex = 0;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(184, 24);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.toolStripTextBox2});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(140, 22);
            this.toolStripTextBox1.Text = "Клиенты";
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(140, 22);
            this.toolStripTextBox2.Text = "Сотрудники";
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitClientContainer);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Client";
            this.Text = "Form1";
            this.splitClientContainer.Panel1.ResumeLayout(false);
            this.splitClientContainer.Panel2.ResumeLayout(false);
            this.splitClientContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitClientContainer)).EndInit();
            this.splitClientContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClient)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitClientContainer;
        private DataGridView dataGridClient;
        private Label label1;
        private Label middlenameClientLabel;
        private Label nameClientLabel;
        private Label surnameClientLabel;
        private TextBox clientMiddlename;
        private TextBox clientName;
        private TextBox clientSurname;
        private MenuStrip menuStrip;
        private ToolStripMenuItem менюToolStripMenuItem;
        private Button updateButton;
        private ToolStripMenuItem toolStripTextBox1;
        private ToolStripMenuItem toolStripTextBox2;
        private Button addButton;
        private DateTimePicker dateBirthBox;
        private Button deleteButton;
    }
}