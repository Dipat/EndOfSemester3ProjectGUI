﻿namespace WindowsFormsApp2
{
    partial class SalesMenu
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
            this.nameText = new System.Windows.Forms.TextBox();
            this.locationText = new System.Windows.Forms.TextBox();
            this.startingPriceText = new System.Windows.Forms.TextBox();
            this.location = new System.Windows.Forms.Label();
            this.StartingPrice = new System.Windows.Forms.Label();
            this.RemainingTime = new System.Windows.Forms.Label();
            this.ProductType = new System.Windows.Forms.Label();
            this.PersonName = new System.Windows.Forms.Label();
            this.productTypeBox = new System.Windows.Forms.ComboBox();
            this.Description = new System.Windows.Forms.Label();
            this.DescriptionText = new System.Windows.Forms.TextBox();
            this.createSaleButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(117, 51);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(100, 20);
            this.nameText.TabIndex = 23;
            // 
            // locationText
            // 
            this.locationText.Location = new System.Drawing.Point(117, 100);
            this.locationText.Name = "locationText";
            this.locationText.Size = new System.Drawing.Size(100, 20);
            this.locationText.TabIndex = 22;
            // 
            // startingPriceText
            // 
            this.startingPriceText.Location = new System.Drawing.Point(117, 77);
            this.startingPriceText.Name = "startingPriceText";
            this.startingPriceText.Size = new System.Drawing.Size(100, 20);
            this.startingPriceText.TabIndex = 21;
            // 
            // location
            // 
            this.location.AutoSize = true;
            this.location.BackColor = System.Drawing.Color.Transparent;
            this.location.Location = new System.Drawing.Point(60, 100);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(51, 13);
            this.location.TabIndex = 19;
            this.location.Text = "Location:";
            // 
            // StartingPrice
            // 
            this.StartingPrice.AutoSize = true;
            this.StartingPrice.BackColor = System.Drawing.Color.Transparent;
            this.StartingPrice.Location = new System.Drawing.Point(41, 77);
            this.StartingPrice.Name = "StartingPrice";
            this.StartingPrice.Size = new System.Drawing.Size(70, 13);
            this.StartingPrice.TabIndex = 18;
            this.StartingPrice.Text = "StartingPrice:";
            // 
            // RemainingTime
            // 
            this.RemainingTime.AutoSize = true;
            this.RemainingTime.BackColor = System.Drawing.Color.Transparent;
            this.RemainingTime.Location = new System.Drawing.Point(51, 159);
            this.RemainingTime.Name = "RemainingTime";
            this.RemainingTime.Size = new System.Drawing.Size(55, 13);
            this.RemainingTime.TabIndex = 16;
            this.RemainingTime.Text = "End Time:";
            // 
            // ProductType
            // 
            this.ProductType.AutoSize = true;
            this.ProductType.BackColor = System.Drawing.Color.Transparent;
            this.ProductType.Location = new System.Drawing.Point(40, 129);
            this.ProductType.Name = "ProductType";
            this.ProductType.Size = new System.Drawing.Size(71, 13);
            this.ProductType.TabIndex = 15;
            this.ProductType.Text = "ProductType:";
            // 
            // PersonName
            // 
            this.PersonName.AutoSize = true;
            this.PersonName.BackColor = System.Drawing.Color.Transparent;
            this.PersonName.Location = new System.Drawing.Point(68, 54);
            this.PersonName.Name = "PersonName";
            this.PersonName.Size = new System.Drawing.Size(38, 13);
            this.PersonName.TabIndex = 14;
            this.PersonName.Text = "Name:";
            // 
            // productTypeBox
            // 
            this.productTypeBox.FormattingEnabled = true;
            this.productTypeBox.Location = new System.Drawing.Point(117, 126);
            this.productTypeBox.Name = "productTypeBox";
            this.productTypeBox.Size = new System.Drawing.Size(121, 21);
            this.productTypeBox.TabIndex = 26;
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.BackColor = System.Drawing.Color.Transparent;
            this.Description.Location = new System.Drawing.Point(48, 193);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(63, 13);
            this.Description.TabIndex = 28;
            this.Description.Text = "Description:";
            // 
            // DescriptionText
            // 
            this.DescriptionText.Location = new System.Drawing.Point(117, 190);
            this.DescriptionText.Multiline = true;
            this.DescriptionText.Name = "DescriptionText";
            this.DescriptionText.Size = new System.Drawing.Size(302, 153);
            this.DescriptionText.TabIndex = 29;
            // 
            // createSaleButton
            // 
            this.createSaleButton.Location = new System.Drawing.Point(117, 415);
            this.createSaleButton.Name = "createSaleButton";
            this.createSaleButton.Size = new System.Drawing.Size(121, 23);
            this.createSaleButton.TabIndex = 30;
            this.createSaleButton.Text = "Create Listing";
            this.createSaleButton.UseVisualStyleBackColor = true;
            this.createSaleButton.Click += new System.EventHandler(this.createSaleButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(667, 415);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(121, 23);
            this.backButton.TabIndex = 31;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(117, 153);
            this.dateTimePicker1.MinDate = System.DateTime.Now.AddDays(1);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 35;
            this.dateTimePicker1.Value = this.dateTimePicker1.MinDate;
            // 
            // SalesMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.WindowBackground;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.createSaleButton);
            this.Controls.Add(this.DescriptionText);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.productTypeBox);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.locationText);
            this.Controls.Add(this.startingPriceText);
            this.Controls.Add(this.location);
            this.Controls.Add(this.StartingPrice);
            this.Controls.Add(this.RemainingTime);
            this.Controls.Add(this.ProductType);
            this.Controls.Add(this.PersonName);
            this.Name = "SalesMenu";
            this.Text = "SalesMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox locationText;
        private System.Windows.Forms.TextBox startingPriceText;
        private System.Windows.Forms.Label location;
        private System.Windows.Forms.Label StartingPrice;
        private System.Windows.Forms.Label RemainingTime;
        private System.Windows.Forms.Label ProductType;
        private System.Windows.Forms.Label PersonName;
        private System.Windows.Forms.ComboBox productTypeBox;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.TextBox DescriptionText;
        private System.Windows.Forms.Button createSaleButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}