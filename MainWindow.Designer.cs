namespace WindowsFormsApp2
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
            this.salesGrid = new System.Windows.Forms.TableLayoutPanel();
            this.priceText = new System.Windows.Forms.Label();
            this.itemNameText = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(236, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 26);
            this.button1.TabIndex = 1;
            this.button1.Text = "My Info";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(705, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 26);
            this.button2.TabIndex = 2;
            this.button2.Text = "Log Out";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(628, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 26);
            this.button3.TabIndex = 3;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = true;
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
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(151, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(79, 26);
            this.button4.TabIndex = 6;
            this.button4.Text = "Create Listing";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.ClientSize = new System.Drawing.Size(788, 479);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.salesGrid);
            this.Name = "MainWindow";
            this.salesGrid.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel salesGrid;
        private System.Windows.Forms.Label itemNameText;
        private System.Windows.Forms.Label priceText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button4;
    }
}