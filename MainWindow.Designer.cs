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
            this.itemNameText = new System.Windows.Forms.Label();
            this.priceText = new System.Windows.Forms.Label();
            this.salesGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // salesGrid
            // 
            this.salesGrid.AutoScroll = true;
            this.salesGrid.AutoSize = true;
            this.salesGrid.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.salesGrid.ColumnCount = 2;
            this.salesGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.salesGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.salesGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.salesGrid.Controls.Add(this.itemNameText, 0, 0);
            this.salesGrid.Controls.Add(this.priceText, 1, 0);
            this.salesGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salesGrid.Location = new System.Drawing.Point(0, 0);
            this.salesGrid.Name = "salesGrid";
            this.salesGrid.RowCount = 1;
            this.salesGrid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.salesGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.salesGrid.Size = new System.Drawing.Size(788, 479);
            this.salesGrid.TabIndex = 0;
            // 
            // itemNameText
            // 
            this.itemNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNameText.Location = new System.Drawing.Point(3, 0);
            this.itemNameText.Name = "itemNameText";
            this.itemNameText.Size = new System.Drawing.Size(671, 62);
            this.itemNameText.TabIndex = 1;
            this.itemNameText.Text = "label2";
            this.itemNameText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.itemNameText.Click += new System.EventHandler(this.product_Click);
            // 
            // priceText
            // 
            this.priceText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.priceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceText.Location = new System.Drawing.Point(681, 0);
            this.priceText.Name = "priceText";
            this.priceText.Size = new System.Drawing.Size(104, 62);
            this.priceText.TabIndex = 2;
            this.priceText.Text = "100.000.000$";
            this.priceText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.priceText.Click += new System.EventHandler(this.product_Click);
            // 
            // MainWindow
            // 
            this.ClientSize = new System.Drawing.Size(788, 479);
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
    }
}