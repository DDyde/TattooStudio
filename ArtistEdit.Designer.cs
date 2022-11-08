namespace TattooStudio
{
    partial class ArtistEdit
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
            this.artistProfile = new System.Windows.Forms.PictureBox();
            this.artistSurname = new System.Windows.Forms.TextBox();
            this.artistName = new System.Windows.Forms.TextBox();
            this.workExp = new System.Windows.Forms.NumericUpDown();
            this.artistPosition = new System.Windows.Forms.ComboBox();
            this.salary = new System.Windows.Forms.NumericUpDown();
            this.artistMiddlename = new System.Windows.Forms.TextBox();
            this.imageWork = new System.Windows.Forms.PictureBox();
            this.prevImage = new System.Windows.Forms.Button();
            this.nextImage = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.addImageButton = new System.Windows.Forms.Button();
            this.deleteImageButton = new System.Windows.Forms.Button();
            this.updateImageProfile = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.nickNameBox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.reportButton = new System.Windows.Forms.Button();
            this.labelWorkExp = new System.Windows.Forms.Label();
            this.labelSalary = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.artistProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workExp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageWork)).BeginInit();
            this.SuspendLayout();
            // 
            // artistProfile
            // 
            this.artistProfile.ImageLocation = "";
            this.artistProfile.Location = new System.Drawing.Point(12, 12);
            this.artistProfile.Name = "artistProfile";
            this.artistProfile.Size = new System.Drawing.Size(275, 297);
            this.artistProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.artistProfile.TabIndex = 0;
            this.artistProfile.TabStop = false;
            // 
            // artistSurname
            // 
            this.artistSurname.Location = new System.Drawing.Point(12, 344);
            this.artistSurname.Name = "artistSurname";
            this.artistSurname.PlaceholderText = "Фамилия";
            this.artistSurname.Size = new System.Drawing.Size(275, 23);
            this.artistSurname.TabIndex = 1;
            // 
            // artistName
            // 
            this.artistName.Location = new System.Drawing.Point(12, 373);
            this.artistName.Name = "artistName";
            this.artistName.PlaceholderText = "Имя";
            this.artistName.Size = new System.Drawing.Size(275, 23);
            this.artistName.TabIndex = 2;
            // 
            // workExp
            // 
            this.workExp.Location = new System.Drawing.Point(12, 482);
            this.workExp.Name = "workExp";
            this.workExp.Size = new System.Drawing.Size(120, 23);
            this.workExp.TabIndex = 3;
            // 
            // artistPosition
            // 
            this.artistPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.artistPosition.FormattingEnabled = true;
            this.artistPosition.Location = new System.Drawing.Point(12, 431);
            this.artistPosition.Name = "artistPosition";
            this.artistPosition.Size = new System.Drawing.Size(275, 23);
            this.artistPosition.TabIndex = 4;
            // 
            // salary
            // 
            this.salary.Location = new System.Drawing.Point(12, 526);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(120, 23);
            this.salary.TabIndex = 5;
            // 
            // artistMiddlename
            // 
            this.artistMiddlename.Location = new System.Drawing.Point(12, 402);
            this.artistMiddlename.Name = "artistMiddlename";
            this.artistMiddlename.PlaceholderText = "Отчество";
            this.artistMiddlename.Size = new System.Drawing.Size(275, 23);
            this.artistMiddlename.TabIndex = 6;
            // 
            // imageWork
            // 
            this.imageWork.BackColor = System.Drawing.Color.Transparent;
            this.imageWork.Location = new System.Drawing.Point(348, 23);
            this.imageWork.Name = "imageWork";
            this.imageWork.Size = new System.Drawing.Size(632, 402);
            this.imageWork.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageWork.TabIndex = 7;
            this.imageWork.TabStop = false;
            // 
            // prevImage
            // 
            this.prevImage.Location = new System.Drawing.Point(333, 22);
            this.prevImage.Name = "prevImage";
            this.prevImage.Size = new System.Drawing.Size(15, 402);
            this.prevImage.TabIndex = 8;
            this.prevImage.Text = "<";
            this.prevImage.UseVisualStyleBackColor = true;
            this.prevImage.Click += new System.EventHandler(this.prevImage_Click);
            // 
            // nextImage
            // 
            this.nextImage.Location = new System.Drawing.Point(980, 23);
            this.nextImage.Name = "nextImage";
            this.nextImage.Size = new System.Drawing.Size(15, 402);
            this.nextImage.TabIndex = 9;
            this.nextImage.Text = ">";
            this.nextImage.UseVisualStyleBackColor = true;
            this.nextImage.Click += new System.EventHandler(this.nextImage_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(462, 528);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 10;
            this.updateButton.Text = "Изменить";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Visible = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // addImageButton
            // 
            this.addImageButton.Location = new System.Drawing.Point(543, 431);
            this.addImageButton.Name = "addImageButton";
            this.addImageButton.Size = new System.Drawing.Size(75, 23);
            this.addImageButton.TabIndex = 13;
            this.addImageButton.Text = "добавить";
            this.addImageButton.UseVisualStyleBackColor = true;
            this.addImageButton.Click += new System.EventHandler(this.addImageButton_Click);
            // 
            // deleteImageButton
            // 
            this.deleteImageButton.Location = new System.Drawing.Point(624, 431);
            this.deleteImageButton.Name = "deleteImageButton";
            this.deleteImageButton.Size = new System.Drawing.Size(75, 23);
            this.deleteImageButton.TabIndex = 14;
            this.deleteImageButton.Text = "Удалить";
            this.deleteImageButton.UseVisualStyleBackColor = true;
            this.deleteImageButton.Click += new System.EventHandler(this.deleteImageButton_Click);
            // 
            // updateImageProfile
            // 
            this.updateImageProfile.Location = new System.Drawing.Point(100, 315);
            this.updateImageProfile.Name = "updateImageProfile";
            this.updateImageProfile.Size = new System.Drawing.Size(75, 23);
            this.updateImageProfile.TabIndex = 15;
            this.updateImageProfile.Text = "обновить";
            this.updateImageProfile.UseVisualStyleBackColor = true;
            this.updateImageProfile.Click += new System.EventHandler(this.updateImageProfile_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(543, 528);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 16;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Visible = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // nickNameBox
            // 
            this.nickNameBox.Location = new System.Drawing.Point(187, 526);
            this.nickNameBox.Name = "nickNameBox";
            this.nickNameBox.PlaceholderText = "nick";
            this.nickNameBox.Size = new System.Drawing.Size(100, 23);
            this.nickNameBox.TabIndex = 17;
            this.nickNameBox.Visible = false;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(624, 529);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 18;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Visible = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(921, 529);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(75, 23);
            this.reportButton.TabIndex = 19;
            this.reportButton.Text = "Отчет";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // labelWorkExp
            // 
            this.labelWorkExp.AutoSize = true;
            this.labelWorkExp.ForeColor = System.Drawing.Color.White;
            this.labelWorkExp.Location = new System.Drawing.Point(12, 464);
            this.labelWorkExp.Name = "labelWorkExp";
            this.labelWorkExp.Size = new System.Drawing.Size(84, 15);
            this.labelWorkExp.TabIndex = 20;
            this.labelWorkExp.Text = "Опыт работы:";
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.ForeColor = System.Drawing.Color.White;
            this.labelSalary.Location = new System.Drawing.Point(12, 508);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(50, 15);
            this.labelSalary.TabIndex = 21;
            this.labelSalary.Text = "Оплата:";
            // 
            // ArtistEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1019, 566);
            this.Controls.Add(this.labelSalary);
            this.Controls.Add(this.labelWorkExp);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.nickNameBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.updateImageProfile);
            this.Controls.Add(this.deleteImageButton);
            this.Controls.Add(this.addImageButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.nextImage);
            this.Controls.Add(this.prevImage);
            this.Controls.Add(this.imageWork);
            this.Controls.Add(this.artistMiddlename);
            this.Controls.Add(this.salary);
            this.Controls.Add(this.artistPosition);
            this.Controls.Add(this.workExp);
            this.Controls.Add(this.artistName);
            this.Controls.Add(this.artistSurname);
            this.Controls.Add(this.artistProfile);
            this.MinimumSize = new System.Drawing.Size(1035, 605);
            this.Name = "ArtistEdit";
            this.Text = "ArtistEdit";
            ((System.ComponentModel.ISupportInitialize)(this.artistProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workExp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageWork)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox artistProfile;
        private TextBox artistSurname;
        private TextBox artistName;
        private NumericUpDown workExp;
        private ComboBox artistPosition;
        private NumericUpDown salary;
        private TextBox artistMiddlename;
        private PictureBox imageWork;
        private Button prevImage;
        private Button nextImage;
        private Button updateButton;
        private Button addImageButton;
        private Button deleteImageButton;
        private Button updateImageProfile;
        private Button addButton;
        private TextBox nickNameBox;
        private Button deleteButton;
        private Button reportButton;
        private Label labelWorkExp;
        private Label labelSalary;
    }
}