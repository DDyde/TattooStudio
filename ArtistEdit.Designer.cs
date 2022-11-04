﻿namespace TattooStudio
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
            this.addButton = new System.Windows.Forms.Button();
            this.addImageButton = new System.Windows.Forms.Button();
            this.deleteImageButton = new System.Windows.Forms.Button();
            this.updateImageProfile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.artistProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workExp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageWork)).BeginInit();
            this.SuspendLayout();
            // 
            // artistProfile
            // 
            this.artistProfile.ImageLocation = "";
            this.artistProfile.Location = new System.Drawing.Point(14, 16);
            this.artistProfile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.artistProfile.Name = "artistProfile";
            this.artistProfile.Size = new System.Drawing.Size(314, 396);
            this.artistProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.artistProfile.TabIndex = 0;
            this.artistProfile.TabStop = false;
            // 
            // artistSurname
            // 
            this.artistSurname.Location = new System.Drawing.Point(14, 459);
            this.artistSurname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.artistSurname.Name = "artistSurname";
            this.artistSurname.PlaceholderText = "Фамилия";
            this.artistSurname.Size = new System.Drawing.Size(314, 27);
            this.artistSurname.TabIndex = 1;
            // 
            // artistName
            // 
            this.artistName.Location = new System.Drawing.Point(14, 497);
            this.artistName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.artistName.Name = "artistName";
            this.artistName.PlaceholderText = "Имя";
            this.artistName.Size = new System.Drawing.Size(314, 27);
            this.artistName.TabIndex = 2;
            // 
            // workExp
            // 
            this.workExp.Location = new System.Drawing.Point(15, 613);
            this.workExp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.workExp.Name = "workExp";
            this.workExp.Size = new System.Drawing.Size(137, 27);
            this.workExp.TabIndex = 3;
            // 
            // artistPosition
            // 
            this.artistPosition.FormattingEnabled = true;
            this.artistPosition.Location = new System.Drawing.Point(14, 575);
            this.artistPosition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.artistPosition.Name = "artistPosition";
            this.artistPosition.Size = new System.Drawing.Size(314, 28);
            this.artistPosition.TabIndex = 4;
            // 
            // salary
            // 
            this.salary.Location = new System.Drawing.Point(15, 652);
            this.salary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(137, 27);
            this.salary.TabIndex = 5;
            // 
            // artistMiddlename
            // 
            this.artistMiddlename.Location = new System.Drawing.Point(14, 536);
            this.artistMiddlename.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.artistMiddlename.Name = "artistMiddlename";
            this.artistMiddlename.PlaceholderText = "Отчество";
            this.artistMiddlename.Size = new System.Drawing.Size(314, 27);
            this.artistMiddlename.TabIndex = 6;
            // 
            // imageWork
            // 
            this.imageWork.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.imageWork.Location = new System.Drawing.Point(398, 31);
            this.imageWork.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.imageWork.Name = "imageWork";
            this.imageWork.Size = new System.Drawing.Size(722, 536);
            this.imageWork.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageWork.TabIndex = 7;
            this.imageWork.TabStop = false;
            // 
            // prevImage
            // 
            this.prevImage.Location = new System.Drawing.Point(398, 575);
            this.prevImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.prevImage.Name = "prevImage";
            this.prevImage.Size = new System.Drawing.Size(86, 31);
            this.prevImage.TabIndex = 8;
            this.prevImage.Text = "Назад";
            this.prevImage.UseVisualStyleBackColor = true;
            this.prevImage.Click += new System.EventHandler(this.prevImage_Click);
            // 
            // nextImage
            // 
            this.nextImage.Location = new System.Drawing.Point(1034, 575);
            this.nextImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nextImage.Name = "nextImage";
            this.nextImage.Size = new System.Drawing.Size(86, 31);
            this.nextImage.TabIndex = 9;
            this.nextImage.Text = "Далее";
            this.nextImage.UseVisualStyleBackColor = true;
            this.nextImage.Click += new System.EventHandler(this.nextImage_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(435, 655);
            this.updateButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(86, 31);
            this.updateButton.TabIndex = 10;
            this.updateButton.Text = "Изменить";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(528, 655);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(86, 31);
            this.addButton.TabIndex = 11;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // addImageButton
            // 
            this.addImageButton.Location = new System.Drawing.Point(621, 575);
            this.addImageButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addImageButton.Name = "addImageButton";
            this.addImageButton.Size = new System.Drawing.Size(86, 31);
            this.addImageButton.TabIndex = 13;
            this.addImageButton.Text = "добавить";
            this.addImageButton.UseVisualStyleBackColor = true;
            this.addImageButton.Click += new System.EventHandler(this.addImageButton_Click);
            // 
            // deleteImageButton
            // 
            this.deleteImageButton.Location = new System.Drawing.Point(713, 575);
            this.deleteImageButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deleteImageButton.Name = "deleteImageButton";
            this.deleteImageButton.Size = new System.Drawing.Size(86, 31);
            this.deleteImageButton.TabIndex = 14;
            this.deleteImageButton.Text = "Удалить";
            this.deleteImageButton.UseVisualStyleBackColor = true;
            this.deleteImageButton.Click += new System.EventHandler(this.deleteImageButton_Click);
            // 
            // updateImageProfile
            // 
            this.updateImageProfile.Location = new System.Drawing.Point(114, 420);
            this.updateImageProfile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.updateImageProfile.Name = "updateImageProfile";
            this.updateImageProfile.Size = new System.Drawing.Size(86, 31);
            this.updateImageProfile.TabIndex = 15;
            this.updateImageProfile.Text = "обновить";
            this.updateImageProfile.UseVisualStyleBackColor = true;
            this.updateImageProfile.Click += new System.EventHandler(this.updateImageProfile_Click);
            // 
            // ArtistEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 701);
            this.Controls.Add(this.updateImageProfile);
            this.Controls.Add(this.deleteImageButton);
            this.Controls.Add(this.addImageButton);
            this.Controls.Add(this.addButton);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private Button addButton;
        private Button addImageButton;
        private Button deleteImageButton;
        private Button updateImageProfile;
    }
}