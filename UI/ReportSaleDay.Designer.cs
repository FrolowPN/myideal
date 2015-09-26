namespace UI
{
    partial class ReportSaleDay
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAllPriceGrid = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCountProductGrid = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtGrSale = new System.Windows.Forms.DataGridView();
            this.lblNameReports = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrSale)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Продажи за";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtAllPriceGrid);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtCountProductGrid);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dtGrSale);
            this.groupBox1.Controls.Add(this.lblNameReports);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(809, 509);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Продажи";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(349, 479);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "тыс. рублей";
            // 
            // txtAllPriceGrid
            // 
            this.txtAllPriceGrid.Location = new System.Drawing.Point(221, 476);
            this.txtAllPriceGrid.Name = "txtAllPriceGrid";
            this.txtAllPriceGrid.Size = new System.Drawing.Size(122, 20);
            this.txtAllPriceGrid.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(157, 479);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "на сумму ";
            // 
            // txtCountProductGrid
            // 
            this.txtCountProductGrid.Location = new System.Drawing.Point(105, 475);
            this.txtCountProductGrid.Name = "txtCountProductGrid";
            this.txtCountProductGrid.Size = new System.Drawing.Size(45, 20);
            this.txtCountProductGrid.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 479);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Итого: товаров ";
            // 
            // dtGrSale
            // 
            this.dtGrSale.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrSale.Location = new System.Drawing.Point(10, 49);
            this.dtGrSale.Name = "dtGrSale";
            this.dtGrSale.Size = new System.Drawing.Size(793, 414);
            this.dtGrSale.TabIndex = 2;
            // 
            // lblNameReports
            // 
            this.lblNameReports.AutoSize = true;
            this.lblNameReports.Location = new System.Drawing.Point(82, 20);
            this.lblNameReports.Name = "lblNameReports";
            this.lblNameReports.Size = new System.Drawing.Size(35, 13);
            this.lblNameReports.TabIndex = 1;
            this.lblNameReports.Text = "label2";
            // 
            // ReportSaleDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(868, 534);
            this.Controls.Add(this.groupBox1);
            this.Name = "ReportSaleDay";
            this.Text = "Продажи за сегодня";
            this.Load += new System.EventHandler(this.ReportSaleDay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrSale)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtGrSale;
        private System.Windows.Forms.Label lblNameReports;
        private System.Windows.Forms.TextBox txtAllPriceGrid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCountProductGrid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
    }
}