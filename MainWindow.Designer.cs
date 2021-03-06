﻿namespace WindowsFormsApp2
{
    partial class MainWindow
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
            this.salesGrid = new System.Windows.Forms.TableLayoutPanel();
            this.priceText = new System.Windows.Forms.Label();
            this.itemNameText = new System.Windows.Forms.Label();
            this.idText = new System.Windows.Forms.Label();
            this.myInfo = new System.Windows.Forms.Button();
            this.logOut = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.createListing = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.productTypeBox = new System.Windows.Forms.ComboBox();
            this.typeSortText = new System.Windows.Forms.Label();
            this.priceSortText = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.salesGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // salesGrid
            // 
            this.salesGrid.AutoScroll = true;
            this.salesGrid.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.salesGrid.ColumnCount = 3;
            this.salesGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.salesGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.salesGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.salesGrid.Controls.Add(this.priceText, 1, 0);
            this.salesGrid.Controls.Add(this.itemNameText, 0, 0);
            this.salesGrid.Controls.Add(this.idText, 2, 0);
            this.salesGrid.Location = new System.Drawing.Point(12, 109);
            this.salesGrid.Name = "salesGrid";
            this.salesGrid.RowCount = 1;
            this.salesGrid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.salesGrid.Size = new System.Drawing.Size(764, 370);
            this.salesGrid.TabIndex = 0;
            // 
            // priceText
            // 
            this.priceText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.priceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceText.Location = new System.Drawing.Point(641, 0);
            this.priceText.Name = "priceText";
            this.priceText.Size = new System.Drawing.Size(100, 62);
            this.priceText.TabIndex = 2;
            this.priceText.Text = "100.000.000$";
            this.priceText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.priceText.Click += new System.EventHandler(this.product_Click);
            // 
            // itemNameText
            // 
            this.itemNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNameText.Location = new System.Drawing.Point(3, 0);
            this.itemNameText.Name = "itemNameText";
            this.itemNameText.Size = new System.Drawing.Size(632, 62);
            this.itemNameText.TabIndex = 1;
            this.itemNameText.Text = "label2";
            this.itemNameText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.itemNameText.Click += new System.EventHandler(this.product_Click);
            // 
            // idText
            // 
            this.idText.AutoSize = true;
            this.idText.Location = new System.Drawing.Point(747, 0);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(13, 13);
            this.idText.TabIndex = 3;
            this.idText.Text = "1";
            this.idText.Visible = false;
            // 
            // myInfo
            // 
            this.myInfo.Location = new System.Drawing.Point(236, 12);
            this.myInfo.Name = "myInfo";
            this.myInfo.Size = new System.Drawing.Size(79, 26);
            this.myInfo.TabIndex = 1;
            this.myInfo.Text = "My Info";
            this.myInfo.UseVisualStyleBackColor = true;
            // 
            // logOut
            // 
            this.logOut.Location = new System.Drawing.Point(705, 12);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(71, 26);
            this.logOut.TabIndex = 2;
            this.logOut.Text = "Log Out";
            this.logOut.UseVisualStyleBackColor = true;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(628, 12);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(71, 26);
            this.search.TabIndex = 3;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(321, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(301, 26);
            this.textBox1.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ascending",
            "descending"});
            this.comboBox1.Location = new System.Drawing.Point(667, 82);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(109, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // createListing
            // 
            this.createListing.Location = new System.Drawing.Point(151, 12);
            this.createListing.Name = "createListing";
            this.createListing.Size = new System.Drawing.Size(79, 26);
            this.createListing.TabIndex = 6;
            this.createListing.Text = "Create Listing";
            this.createListing.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // productTypeBox
            // 
            this.productTypeBox.FormattingEnabled = true;
            this.productTypeBox.Location = new System.Drawing.Point(667, 55);
            this.productTypeBox.Name = "productTypeBox";
            this.productTypeBox.Size = new System.Drawing.Size(110, 21);
            this.productTypeBox.TabIndex = 27;
            this.productTypeBox.SelectedIndexChanged += new System.EventHandler(this.productTypeBox_SelectedIndexChanged);
            // 
            // typeSortText
            // 
            this.typeSortText.BackColor = System.Drawing.Color.Transparent;
            this.typeSortText.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.typeSortText.Location = new System.Drawing.Point(588, 55);
            this.typeSortText.Name = "typeSortText";
            this.typeSortText.Size = new System.Drawing.Size(73, 23);
            this.typeSortText.TabIndex = 28;
            this.typeSortText.Text = "Sort by Type:";
            this.typeSortText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // priceSortText
            // 
            this.priceSortText.BackColor = System.Drawing.Color.Transparent;
            this.priceSortText.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.priceSortText.Location = new System.Drawing.Point(588, 78);
            this.priceSortText.Name = "priceSortText";
            this.priceSortText.Size = new System.Drawing.Size(73, 23);
            this.priceSortText.TabIndex = 29;
            this.priceSortText.Text = "Sort by Price:";
            this.priceSortText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // MainWindow
            // 
            this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.WindowBackground;
            this.ClientSize = new System.Drawing.Size(788, 479);
            this.Controls.Add(this.priceSortText);
            this.Controls.Add(this.typeSortText);
            this.Controls.Add(this.productTypeBox);
            this.Controls.Add(this.createListing);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.logOut);
            this.Controls.Add(this.myInfo);
            this.Controls.Add(this.salesGrid);
            this.Name = "MainWindow";
            this.salesGrid.ResumeLayout(false);
            this.salesGrid.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel salesGrid;
        private System.Windows.Forms.Label itemNameText;
        private System.Windows.Forms.Label priceText;
        private System.Windows.Forms.Button myInfo;
        private System.Windows.Forms.Button logOut;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button createListing;
        private System.Windows.Forms.Label idText;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox productTypeBox;
        private System.Windows.Forms.Label typeSortText;
        private System.Windows.Forms.Label priceSortText;
        private System.Windows.Forms.Timer timer2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}