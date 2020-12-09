namespace WindowsFormsApp2
{
    partial class ProductWindow
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
            this.components = new System.ComponentModel.Container();
            this.createListing = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.logOut = new System.Windows.Forms.Button();
            this.myInfo = new System.Windows.Forms.Button();
            this.nameText = new System.Windows.Forms.Label();
            this.cPriceText = new System.Windows.Forms.Label();
            this.pTypeText = new System.Windows.Forms.Label();
            this.descriptionText = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timeText = new System.Windows.Forms.Label();
            this.placeBid = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.errorText = new System.Windows.Forms.Label();
            this.bidValue = new System.Windows.Forms.NumericUpDown();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bidValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // createListing
            // 
            this.createListing.Location = new System.Drawing.Point(164, 12);
            this.createListing.Name = "createListing";
            this.createListing.Size = new System.Drawing.Size(79, 26);
            this.createListing.TabIndex = 11;
            this.createListing.Text = "Create Listing";
            this.createListing.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(334, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(301, 26);
            this.textBox1.TabIndex = 10;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(641, 12);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(71, 26);
            this.search.TabIndex = 9;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            // 
            // logOut
            // 
            this.logOut.Location = new System.Drawing.Point(718, 12);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(71, 26);
            this.logOut.TabIndex = 8;
            this.logOut.Text = "Log Out";
            this.logOut.UseVisualStyleBackColor = true;
            // 
            // myInfo
            // 
            this.myInfo.Location = new System.Drawing.Point(249, 12);
            this.myInfo.Name = "myInfo";
            this.myInfo.Size = new System.Drawing.Size(79, 26);
            this.myInfo.TabIndex = 7;
            this.myInfo.Text = "My Info";
            this.myInfo.UseVisualStyleBackColor = true;
            // 
            // nameText
            // 
            this.nameText.AutoSize = true;
            this.nameText.BackColor = System.Drawing.Color.Transparent;
            this.nameText.Location = new System.Drawing.Point(321, 83);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(75, 13);
            this.nameText.TabIndex = 14;
            this.nameText.Text = "Product Name";
            // 
            // cPriceText
            // 
            this.cPriceText.AutoSize = true;
            this.cPriceText.BackColor = System.Drawing.Color.Transparent;
            this.cPriceText.Location = new System.Drawing.Point(321, 181);
            this.cPriceText.Name = "cPriceText";
            this.cPriceText.Size = new System.Drawing.Size(68, 13);
            this.cPriceText.TabIndex = 15;
            this.cPriceText.Text = "Current Price";
            // 
            // pTypeText
            // 
            this.pTypeText.AutoSize = true;
            this.pTypeText.BackColor = System.Drawing.Color.Transparent;
            this.pTypeText.Location = new System.Drawing.Point(321, 130);
            this.pTypeText.Name = "pTypeText";
            this.pTypeText.Size = new System.Drawing.Size(31, 13);
            this.pTypeText.TabIndex = 16;
            this.pTypeText.Text = "Type";
            // 
            // descriptionText
            // 
            this.descriptionText.BackColor = System.Drawing.Color.Transparent;
            this.descriptionText.Location = new System.Drawing.Point(12, 257);
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.Size = new System.Drawing.Size(540, 136);
            this.descriptionText.TabIndex = 17;
            this.descriptionText.Text = "Description";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timeText
            // 
            this.timeText.AutoSize = true;
            this.timeText.BackColor = System.Drawing.Color.Transparent;
            this.timeText.Location = new System.Drawing.Point(667, 244);
            this.timeText.Name = "timeText";
            this.timeText.Size = new System.Drawing.Size(26, 13);
            this.timeText.TabIndex = 18;
            this.timeText.Text = "time";
            // 
            // placeBid
            // 
            this.placeBid.Location = new System.Drawing.Point(603, 294);
            this.placeBid.Name = "placeBid";
            this.placeBid.Size = new System.Drawing.Size(134, 42);
            this.placeBid.TabIndex = 19;
            this.placeBid.Text = "Place Bid";
            this.placeBid.UseVisualStyleBackColor = true;
            this.placeBid.Click += new System.EventHandler(this.placeBid_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(603, 378);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(134, 42);
            this.backButton.TabIndex = 20;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(246, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Product Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(284, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(250, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Current Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(575, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Time Remaining:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(12, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Description:";
            // 
            // errorText
            // 
            this.errorText.BackColor = System.Drawing.Color.Transparent;
            this.errorText.Location = new System.Drawing.Point(603, 349);
            this.errorText.Name = "errorText";
            this.errorText.Size = new System.Drawing.Size(134, 13);
            this.errorText.TabIndex = 26;
            this.errorText.Text = "Couldn\'t Place Bid!";
            this.errorText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.errorText.Visible = false;
            // 
            // bidValue
            // 
            this.bidValue.Location = new System.Drawing.Point(604, 268);
            this.bidValue.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.bidValue.Name = "bidValue";
            this.bidValue.Size = new System.Drawing.Size(133, 20);
            this.bidValue.TabIndex = 28;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(12, 62);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(183, 158);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // ProductWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.WindowBackground;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bidValue);
            this.Controls.Add(this.errorText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.placeBid);
            this.Controls.Add(this.timeText);
            this.Controls.Add(this.descriptionText);
            this.Controls.Add(this.pTypeText);
            this.Controls.Add(this.cPriceText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.createListing);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.logOut);
            this.Controls.Add(this.myInfo);
            this.Name = "ProductWindow";
            this.Text = "ProductWindow";
            ((System.ComponentModel.ISupportInitialize)(this.bidValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createListing;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button logOut;
        private System.Windows.Forms.Button myInfo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label nameText;
        private System.Windows.Forms.Label cPriceText;
        private System.Windows.Forms.Label pTypeText;
        private System.Windows.Forms.Label descriptionText;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timeText;
        private System.Windows.Forms.Button placeBid;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label errorText;
        private System.Windows.Forms.NumericUpDown bidValue;
    }
}