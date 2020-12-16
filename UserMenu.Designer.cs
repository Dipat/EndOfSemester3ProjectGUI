namespace WindowsFormsApp2
{
    partial class UserMenu
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
            this.PersonName = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.Password2 = new System.Windows.Forms.Label();
            this.Rating = new System.Windows.Forms.Label();
            this.NumberOfSales = new System.Windows.Forms.Label();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.cPasswordText = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.emailText = new System.Windows.Forms.TextBox();
            this.addressText = new System.Windows.Forms.TextBox();
            this.ratingText = new System.Windows.Forms.TextBox();
            this.nSalesText = new System.Windows.Forms.TextBox();
            this.ownSalesGrid = new System.Windows.Forms.TableLayoutPanel();
            this.priceText = new System.Windows.Forms.Label();
            this.itemNameText = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.saveUpdates = new System.Windows.Forms.Button();
            this.ownSalesGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // PersonName
            // 
            this.PersonName.AutoSize = true;
            this.PersonName.BackColor = System.Drawing.Color.Transparent;
            this.PersonName.Location = new System.Drawing.Point(69, 109);
            this.PersonName.Name = "PersonName";
            this.PersonName.Size = new System.Drawing.Size(38, 13);
            this.PersonName.TabIndex = 0;
            this.PersonName.Text = "Name:";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.BackColor = System.Drawing.Color.Transparent;
            this.Email.Location = new System.Drawing.Point(72, 135);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(35, 13);
            this.Email.TabIndex = 1;
            this.Email.Text = "Email:";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.BackColor = System.Drawing.Color.Transparent;
            this.Address.Location = new System.Drawing.Point(64, 161);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(48, 13);
            this.Address.TabIndex = 2;
            this.Address.Text = "Address:";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.BackColor = System.Drawing.Color.Transparent;
            this.Username.Location = new System.Drawing.Point(54, 36);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(58, 13);
            this.Username.TabIndex = 3;
            this.Username.Text = "Username:";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.BackColor = System.Drawing.Color.Transparent;
            this.Password.Location = new System.Drawing.Point(54, 60);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(56, 13);
            this.Password.TabIndex = 4;
            this.Password.Text = "Password:";
            // 
            // Password2
            // 
            this.Password2.AutoSize = true;
            this.Password2.BackColor = System.Drawing.Color.Transparent;
            this.Password2.Location = new System.Drawing.Point(15, 80);
            this.Password2.Name = "Password2";
            this.Password2.Size = new System.Drawing.Size(97, 13);
            this.Password2.TabIndex = 5;
            this.Password2.Text = "Confirm Password: ";
            // 
            // Rating
            // 
            this.Rating.AutoSize = true;
            this.Rating.BackColor = System.Drawing.Color.Transparent;
            this.Rating.Location = new System.Drawing.Point(609, 24);
            this.Rating.Name = "Rating";
            this.Rating.Size = new System.Drawing.Size(41, 13);
            this.Rating.TabIndex = 6;
            this.Rating.Text = "Rating:";
            // 
            // NumberOfSales
            // 
            this.NumberOfSales.AutoSize = true;
            this.NumberOfSales.BackColor = System.Drawing.Color.Transparent;
            this.NumberOfSales.Location = new System.Drawing.Point(562, 50);
            this.NumberOfSales.Name = "NumberOfSales";
            this.NumberOfSales.Size = new System.Drawing.Size(88, 13);
            this.NumberOfSales.TabIndex = 7;
            this.NumberOfSales.Text = "Number of Sales:";
            // 
            // usernameText
            // 
            this.usernameText.Location = new System.Drawing.Point(118, 33);
            this.usernameText.Name = "usernameText";
            this.usernameText.ReadOnly = true;
            this.usernameText.Size = new System.Drawing.Size(100, 20);
            this.usernameText.TabIndex = 8;
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(118, 57);
            this.passwordText.Name = "passwordText";
            this.passwordText.PasswordChar = '*';
            this.passwordText.Size = new System.Drawing.Size(100, 20);
            this.passwordText.TabIndex = 9;
            // 
            // cPasswordText
            // 
            this.cPasswordText.Location = new System.Drawing.Point(118, 80);
            this.cPasswordText.Name = "cPasswordText";
            this.cPasswordText.PasswordChar = '*';
            this.cPasswordText.Size = new System.Drawing.Size(100, 20);
            this.cPasswordText.TabIndex = 10;
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(118, 106);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(100, 20);
            this.nameText.TabIndex = 11;
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(118, 132);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(100, 20);
            this.emailText.TabIndex = 12;
            // 
            // addressText
            // 
            this.addressText.Location = new System.Drawing.Point(118, 158);
            this.addressText.Name = "addressText";
            this.addressText.Size = new System.Drawing.Size(100, 20);
            this.addressText.TabIndex = 13;
            // 
            // ratingText
            // 
            this.ratingText.Location = new System.Drawing.Point(656, 21);
            this.ratingText.Name = "ratingText";
            this.ratingText.ReadOnly = true;
            this.ratingText.Size = new System.Drawing.Size(100, 20);
            this.ratingText.TabIndex = 14;
            // 
            // nSalesText
            // 
            this.nSalesText.Location = new System.Drawing.Point(656, 47);
            this.nSalesText.Name = "nSalesText";
            this.nSalesText.ReadOnly = true;
            this.nSalesText.Size = new System.Drawing.Size(100, 20);
            this.nSalesText.TabIndex = 15;
            // 
            // ownSalesGrid
            // 
            this.ownSalesGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ownSalesGrid.AutoScroll = true;
            this.ownSalesGrid.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ownSalesGrid.BackColor = System.Drawing.Color.LightGray;
            this.ownSalesGrid.ColumnCount = 2;
            this.ownSalesGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ownSalesGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ownSalesGrid.Controls.Add(this.priceText, 0, 0);
            this.ownSalesGrid.Controls.Add(this.itemNameText, 0, 0);
            this.ownSalesGrid.Location = new System.Drawing.Point(565, 109);
            this.ownSalesGrid.Name = "ownSalesGrid";
            this.ownSalesGrid.RowCount = 1;
            this.ownSalesGrid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ownSalesGrid.Size = new System.Drawing.Size(223, 302);
            this.ownSalesGrid.TabIndex = 16;
            // 
            // priceText
            // 
            this.priceText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.priceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceText.Location = new System.Drawing.Point(122, 0);
            this.priceText.Name = "priceText";
            this.priceText.Size = new System.Drawing.Size(98, 62);
            this.priceText.TabIndex = 3;
            this.priceText.Text = "100.000.000$";
            this.priceText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.priceText.Click += new System.EventHandler(this.product_Click);
            // 
            // itemNameText
            // 
            this.itemNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNameText.Location = new System.Drawing.Point(3, 0);
            this.itemNameText.Name = "itemNameText";
            this.itemNameText.Size = new System.Drawing.Size(104, 62);
            this.itemNameText.TabIndex = 2;
            this.itemNameText.Text = "label2";
            this.itemNameText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.itemNameText.Click += new System.EventHandler(this.product_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(667, 417);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(121, 23);
            this.backButton.TabIndex = 32;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // saveUpdates
            // 
            this.saveUpdates.Location = new System.Drawing.Point(106, 184);
            this.saveUpdates.Name = "saveUpdates";
            this.saveUpdates.Size = new System.Drawing.Size(121, 23);
            this.saveUpdates.TabIndex = 33;
            this.saveUpdates.Text = "Save Updates";
            this.saveUpdates.UseVisualStyleBackColor = true;
            this.saveUpdates.Click += new System.EventHandler(this.saveUpdates_Click);
            // 
            // UserMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.WindowBackground;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveUpdates);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.ownSalesGrid);
            this.Controls.Add(this.nSalesText);
            this.Controls.Add(this.ratingText);
            this.Controls.Add(this.addressText);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.cPasswordText);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.NumberOfSales);
            this.Controls.Add(this.Rating);
            this.Controls.Add(this.Password2);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.PersonName);
            this.Name = "UserMenu";
            this.Text = "User Menu";
            this.ownSalesGrid.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PersonName;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label Password2;
        private System.Windows.Forms.Label Rating;
        private System.Windows.Forms.Label NumberOfSales;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.TextBox cPasswordText;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.TextBox addressText;
        private System.Windows.Forms.TextBox ratingText;
        private System.Windows.Forms.TextBox nSalesText;
        private System.Windows.Forms.TableLayoutPanel ownSalesGrid;
        private System.Windows.Forms.Label itemNameText;
        private System.Windows.Forms.Label priceText;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button saveUpdates;
    }
}