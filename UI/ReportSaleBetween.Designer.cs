namespace UI
{
    partial class ReportSaleBetween
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtBegin = new System.Windows.Forms.DateTimePicker();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGetSaleBetween = new System.Windows.Forms.Button();
            this.dtGrSaleBetween = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAllPriceGrid = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCountProductGrid = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrSaleBetween)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtAllPriceGrid);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtCountProductGrid);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dtGrSaleBetween);
            this.groupBox1.Controls.Add(this.btnGetSaleBetween);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtEnd);
            this.groupBox1.Controls.Add(this.dtBegin);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(772, 474);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Продажи";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите период: от";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtBegin
            // 
            this.dtBegin.Location = new System.Drawing.Point(129, 18);
            this.dtBegin.Name = "dtBegin";
            this.dtBegin.Size = new System.Drawing.Size(200, 20);
            this.dtBegin.TabIndex = 1;
            this.dtBegin.Value = new System.DateTime(2015, 9, 1, 0, 0, 0, 0);
            // 
            // dtEnd
            // 
            this.dtEnd.Location = new System.Drawing.Point(371, 17);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(200, 20);
            this.dtEnd.TabIndex = 2;
            this.dtEnd.Value = new System.DateTime(2015, 9, 23, 23, 59, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "до";
            // 
            // btnGetSaleBetween
            // 
            this.btnGetSaleBetween.Location = new System.Drawing.Point(580, 15);
            this.btnGetSaleBetween.Name = "btnGetSaleBetween";
            this.btnGetSaleBetween.Size = new System.Drawing.Size(75, 23);
            this.btnGetSaleBetween.TabIndex = 4;
            this.btnGetSaleBetween.Text = "Показать";
            this.btnGetSaleBetween.UseVisualStyleBackColor = true;
            this.btnGetSaleBetween.Click += new System.EventHandler(this.btnGetSaleBetween_Click);
            // 
            // dtGrSaleBetween
            // 
            this.dtGrSaleBetween.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrSaleBetween.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrSaleBetween.Location = new System.Drawing.Point(16, 46);
            this.dtGrSaleBetween.Name = "dtGrSaleBetween";
            this.dtGrSaleBetween.Size = new System.Drawing.Size(744, 389);
            this.dtGrSaleBetween.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(355, 444);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "тыс. рублей";
            // 
            // txtAllPriceGrid
            // 
            this.txtAllPriceGrid.Location = new System.Drawing.Point(227, 442);
            this.txtAllPriceGrid.Name = "txtAllPriceGrid";
            this.txtAllPriceGrid.Size = new System.Drawing.Size(122, 20);
            this.txtAllPriceGrid.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(163, 445);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "на сумму ";
            // 
            // txtCountProductGrid
            // 
            this.txtCountProductGrid.Location = new System.Drawing.Point(111, 441);
            this.txtCountProductGrid.Name = "txtCountProductGrid";
            this.txtCountProductGrid.Size = new System.Drawing.Size(45, 20);
            this.txtCountProductGrid.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 445);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Итого: товаров ";
            // 
            // ReportSaleBetween
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(772, 474);
            this.Controls.Add(this.groupBox1);
            this.Name = "ReportSaleBetween";
            this.Text = "Продажи за период";
            this.Load += new System.EventHandler(this.ReportSaleBetween_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrSaleBetween)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtGrSaleBetween;
        private System.Windows.Forms.Button btnGetSaleBetween;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.DateTimePicker dtBegin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAllPriceGrid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCountProductGrid;
        private System.Windows.Forms.Label label9;
    }
}