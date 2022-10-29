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
            this.typeServiceBox = new System.Windows.Forms.TextBox();
            this.priceBox = new System.Windows.Forms.NumericUpDown();
            this.typeServiceComboBox = new System.Windows.Forms.ComboBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTypeOfService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceBox)).BeginInit();
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
            this.splitContainer.Panel1.Controls.Add(this.dataGridTypeOfService);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.updateButton);
            this.splitContainer.Panel2.Controls.Add(this.deleteButton);
            this.splitContainer.Panel2.Controls.Add(this.addButton);
            this.splitContainer.Panel2.Controls.Add(this.typeServiceComboBox);
            this.splitContainer.Panel2.Controls.Add(this.priceBox);
            this.splitContainer.Panel2.Controls.Add(this.typeServiceBox);
            this.splitContainer.Size = new System.Drawing.Size(914, 600);
            this.splitContainer.SplitterDistance = 700;
            this.splitContainer.TabIndex = 0;
            // 
            // dataGridTypeOfService
            // 
            this.dataGridTypeOfService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTypeOfService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridTypeOfService.Location = new System.Drawing.Point(0, 0);
            this.dataGridTypeOfService.Name = "dataGridTypeOfService";
            this.dataGridTypeOfService.RowHeadersWidth = 51;
            this.dataGridTypeOfService.RowTemplate.Height = 29;
            this.dataGridTypeOfService.Size = new System.Drawing.Size(700, 600);
            this.dataGridTypeOfService.TabIndex = 0;
            // 
            // typeServiceBox
            // 
            this.typeServiceBox.Location = new System.Drawing.Point(3, 58);
            this.typeServiceBox.Name = "typeServiceBox";
            this.typeServiceBox.Size = new System.Drawing.Size(204, 27);
            this.typeServiceBox.TabIndex = 0;
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(2, 174);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(204, 27);
            this.priceBox.TabIndex = 1;
            // 
            // typeServiceComboBox
            // 
            this.typeServiceComboBox.FormattingEnabled = true;
            this.typeServiceComboBox.Location = new System.Drawing.Point(3, 114);
            this.typeServiceComboBox.Name = "typeServiceComboBox";
            this.typeServiceComboBox.Size = new System.Drawing.Size(203, 28);
            this.typeServiceComboBox.TabIndex = 2;
            // 
            // updateButton
            // 
            this.updateButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.updateButton.Location = new System.Drawing.Point(11, 276);
            this.updateButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(85, 31);
            this.updateButton.TabIndex = 28;
            this.updateButton.Text = "Изменить";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Visible = false;
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Location = new System.Drawing.Point(121, 274);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(85, 33);
            this.deleteButton.TabIndex = 30;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Visible = false;
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Location = new System.Drawing.Point(69, 274);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(85, 33);
            this.addButton.TabIndex = 29;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // TypeOfService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.splitContainer);
            this.Name = "TypeOfService";
            this.Text = "TypeOfService";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTypeOfService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer;
        private DataGridView dataGridTypeOfService;
        private ComboBox typeServiceComboBox;
        private NumericUpDown priceBox;
        private TextBox typeServiceBox;
        private Button updateButton;
        private Button deleteButton;
        private Button addButton;
    }
}