using System.ComponentModel.DataAnnotations;
namespace UI
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtHiddenIndex = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtHiddenIdLabel = new System.Windows.Forms.TextBox();
            this.bетDelLabel = new System.Windows.Forms.Button();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtHiddenId = new System.Windows.Forms.TextBox();
            this.btnAddLabel = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbLabel = new System.Windows.Forms.ComboBox();
            this.txtСountProduct = new System.Windows.Forms.TextBox();
            this.txtPriceProduct = new System.Windows.Forms.TextBox();
            this.txtVolumeProduct = new System.Windows.Forms.TextBox();
            this.txtNameProduct = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSale = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSaleBetween = new System.Windows.Forms.Button();
            this.btnSaleMonth = new System.Windows.Forms.Button();
            this.btnViewSaleToDay = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtAllPriceGrid = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCountProductGrid = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtGridProducts = new System.Windows.Forms.DataGridView();
            this.butnViewWithLabel = new System.Windows.Forms.Button();
            this.cmbLabelGrid = new System.Windows.Forms.ComboBox();
            this.btnViewAllProduct = new System.Windows.Forms.Button();
            this.btnZeroCount = new System.Windows.Forms.Button();
            this.gp5 = new System.Windows.Forms.GroupBox();
            this.btnSaveInFile = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridProducts)).BeginInit();
            this.gp5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtHiddenIndex);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtHiddenIdLabel);
            this.groupBox1.Controls.Add(this.bетDelLabel);
            this.groupBox1.Controls.Add(this.txtDiscount);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtHiddenId);
            this.groupBox1.Controls.Add(this.btnAddLabel);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbLabel);
            this.groupBox1.Controls.Add(this.txtСountProduct);
            this.groupBox1.Controls.Add(this.txtPriceProduct);
            this.groupBox1.Controls.Add(this.txtVolumeProduct);
            this.groupBox1.Controls.Add(this.txtNameProduct);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(31, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 180);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Товар";
            // 
            // txtHiddenIndex
            // 
            this.txtHiddenIndex.Location = new System.Drawing.Point(272, 75);
            this.txtHiddenIndex.Name = "txtHiddenIndex";
            this.txtHiddenIndex.Size = new System.Drawing.Size(31, 20);
            this.txtHiddenIndex.TabIndex = 21;
            this.txtHiddenIndex.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(178, 154);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "тыс. рублей";
            // 
            // txtHiddenIdLabel
            // 
            this.txtHiddenIdLabel.Location = new System.Drawing.Point(226, 75);
            this.txtHiddenIdLabel.Name = "txtHiddenIdLabel";
            this.txtHiddenIdLabel.Size = new System.Drawing.Size(39, 20);
            this.txtHiddenIdLabel.TabIndex = 19;
            this.txtHiddenIdLabel.Visible = false;
            // 
            // bетDelLabel
            // 
            this.bетDelLabel.Location = new System.Drawing.Point(294, 20);
            this.bетDelLabel.Name = "bетDelLabel";
            this.bетDelLabel.Size = new System.Drawing.Size(18, 22);
            this.bетDelLabel.TabIndex = 18;
            this.bетDelLabel.Text = "/";
            this.bетDelLabel.UseVisualStyleBackColor = true;
            this.bетDelLabel.Click += new System.EventHandler(this.bетDelLabel_Click);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(71, 151);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(100, 20);
            this.txtDiscount.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Скидка";
            // 
            // txtHiddenId
            // 
            this.txtHiddenId.Location = new System.Drawing.Point(181, 75);
            this.txtHiddenId.Name = "txtHiddenId";
            this.txtHiddenId.Size = new System.Drawing.Size(39, 20);
            this.txtHiddenId.TabIndex = 15;
            this.txtHiddenId.Visible = false;
            this.txtHiddenId.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnAddLabel
            // 
            this.btnAddLabel.Location = new System.Drawing.Point(272, 20);
            this.btnAddLabel.Name = "btnAddLabel";
            this.btnAddLabel.Size = new System.Drawing.Size(18, 22);
            this.btnAddLabel.TabIndex = 14;
            this.btnAddLabel.Text = "+";
            this.btnAddLabel.UseVisualStyleBackColor = true;
            this.btnAddLabel.Click += new System.EventHandler(this.btnAddLabel_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(178, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(178, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "тыс. рублей";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(135, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "ml";
            // 
            // cmbLabel
            // 
            this.cmbLabel.FormattingEnabled = true;
            this.cmbLabel.Location = new System.Drawing.Point(71, 20);
            this.cmbLabel.Name = "cmbLabel";
            this.cmbLabel.Size = new System.Drawing.Size(193, 21);
            this.cmbLabel.TabIndex = 10;
            this.cmbLabel.Click += new System.EventHandler(this.cmbLabel_Click);
            // 
            // txtСountProduct
            // 
            this.txtСountProduct.Location = new System.Drawing.Point(71, 124);
            this.txtСountProduct.Name = "txtСountProduct";
            this.txtСountProduct.Size = new System.Drawing.Size(100, 20);
            this.txtСountProduct.TabIndex = 9;
            this.txtСountProduct.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtPriceProduct
            // 
            this.txtPriceProduct.Location = new System.Drawing.Point(71, 98);
            this.txtPriceProduct.Name = "txtPriceProduct";
            this.txtPriceProduct.Size = new System.Drawing.Size(100, 20);
            this.txtPriceProduct.TabIndex = 8;
            // 
            // txtVolumeProduct
            // 
            this.txtVolumeProduct.Location = new System.Drawing.Point(71, 72);
            this.txtVolumeProduct.Name = "txtVolumeProduct";
            this.txtVolumeProduct.Size = new System.Drawing.Size(57, 20);
            this.txtVolumeProduct.TabIndex = 7;
            // 
            // txtNameProduct
            // 
            this.txtNameProduct.Location = new System.Drawing.Point(71, 46);
            this.txtNameProduct.Name = "txtNameProduct";
            this.txtNameProduct.Size = new System.Drawing.Size(192, 20);
            this.txtNameProduct.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Количество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Цена";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Объем";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Название";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Марка";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnSale);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Location = new System.Drawing.Point(356, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(93, 161);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Операции";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(7, 127);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(7, 92);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Изменить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSale
            // 
            this.btnSale.Location = new System.Drawing.Point(7, 55);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(75, 23);
            this.btnSale.TabIndex = 1;
            this.btnSale.Text = "Продать";
            this.btnSale.UseVisualStyleBackColor = true;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(7, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Создать";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSaleBetween);
            this.groupBox3.Controls.Add(this.btnSaleMonth);
            this.groupBox3.Controls.Add(this.btnViewSaleToDay);
            this.groupBox3.Location = new System.Drawing.Point(454, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(131, 161);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Отчеты";
            // 
            // btnSaleBetween
            // 
            this.btnSaleBetween.Location = new System.Drawing.Point(6, 46);
            this.btnSaleBetween.Name = "btnSaleBetween";
            this.btnSaleBetween.Size = new System.Drawing.Size(115, 23);
            this.btnSaleBetween.TabIndex = 2;
            this.btnSaleBetween.Text = "Продажи за период";
            this.btnSaleBetween.UseVisualStyleBackColor = true;
            this.btnSaleBetween.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSaleMonth
            // 
            this.btnSaleMonth.Location = new System.Drawing.Point(7, 75);
            this.btnSaleMonth.Name = "btnSaleMonth";
            this.btnSaleMonth.Size = new System.Drawing.Size(115, 23);
            this.btnSaleMonth.TabIndex = 1;
            this.btnSaleMonth.Text = "Продано всего";
            this.btnSaleMonth.UseVisualStyleBackColor = true;
            this.btnSaleMonth.Click += new System.EventHandler(this.btnSaleMonth_Click);
            // 
            // btnViewSaleToDay
            // 
            this.btnViewSaleToDay.Location = new System.Drawing.Point(7, 19);
            this.btnViewSaleToDay.Name = "btnViewSaleToDay";
            this.btnViewSaleToDay.Size = new System.Drawing.Size(115, 23);
            this.btnViewSaleToDay.TabIndex = 0;
            this.btnViewSaleToDay.Text = "Продано сегодня";
            this.btnViewSaleToDay.UseVisualStyleBackColor = true;
            this.btnViewSaleToDay.Click += new System.EventHandler(this.btnViewSaleToDay_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.txtAllPriceGrid);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txtCountProductGrid);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.dtGridProducts);
            this.groupBox4.Controls.Add(this.butnViewWithLabel);
            this.groupBox4.Controls.Add(this.cmbLabelGrid);
            this.groupBox4.Controls.Add(this.btnViewAllProduct);
            this.groupBox4.Location = new System.Drawing.Point(31, 211);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(852, 567);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Товары";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(351, 530);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "тыс. рублей";
            // 
            // txtAllPriceGrid
            // 
            this.txtAllPriceGrid.Location = new System.Drawing.Point(223, 528);
            this.txtAllPriceGrid.Name = "txtAllPriceGrid";
            this.txtAllPriceGrid.Size = new System.Drawing.Size(122, 20);
            this.txtAllPriceGrid.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(159, 531);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "на сумму ";
            // 
            // txtCountProductGrid
            // 
            this.txtCountProductGrid.Location = new System.Drawing.Point(107, 527);
            this.txtCountProductGrid.Name = "txtCountProductGrid";
            this.txtCountProductGrid.Size = new System.Drawing.Size(45, 20);
            this.txtCountProductGrid.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 531);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Итого: товаров ";
            // 
            // dtGridProducts
            // 
            this.dtGridProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridProducts.Location = new System.Drawing.Point(11, 50);
            this.dtGridProducts.Name = "dtGridProducts";
            this.dtGridProducts.Size = new System.Drawing.Size(826, 466);
            this.dtGridProducts.TabIndex = 3;
            this.dtGridProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridProducts_CellClick);
            this.dtGridProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridProducts_CellContentClick);
            this.dtGridProducts.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dtGridProducts_RowPrePaint);
            // 
            // butnViewWithLabel
            // 
            this.butnViewWithLabel.Location = new System.Drawing.Point(297, 18);
            this.butnViewWithLabel.Name = "butnViewWithLabel";
            this.butnViewWithLabel.Size = new System.Drawing.Size(75, 23);
            this.butnViewWithLabel.TabIndex = 2;
            this.butnViewWithLabel.Text = "Показать";
            this.butnViewWithLabel.UseVisualStyleBackColor = true;
            this.butnViewWithLabel.Click += new System.EventHandler(this.butnViewWithLabel_Click);
            // 
            // cmbLabelGrid
            // 
            this.cmbLabelGrid.FormattingEnabled = true;
            this.cmbLabelGrid.Location = new System.Drawing.Point(95, 21);
            this.cmbLabelGrid.Name = "cmbLabelGrid";
            this.cmbLabelGrid.Size = new System.Drawing.Size(195, 21);
            this.cmbLabelGrid.TabIndex = 1;
            // 
            // btnViewAllProduct
            // 
            this.btnViewAllProduct.Location = new System.Drawing.Point(13, 20);
            this.btnViewAllProduct.Name = "btnViewAllProduct";
            this.btnViewAllProduct.Size = new System.Drawing.Size(75, 23);
            this.btnViewAllProduct.TabIndex = 0;
            this.btnViewAllProduct.Text = "Все";
            this.btnViewAllProduct.UseVisualStyleBackColor = true;
            this.btnViewAllProduct.Click += new System.EventHandler(this.btnViewAllProduct_Click);
            // 
            // btnZeroCount
            // 
            this.btnZeroCount.Location = new System.Drawing.Point(747, 35);
            this.btnZeroCount.Name = "btnZeroCount";
            this.btnZeroCount.Size = new System.Drawing.Size(124, 23);
            this.btnZeroCount.TabIndex = 4;
            this.btnZeroCount.Text = "Обнулить количество";
            this.btnZeroCount.UseVisualStyleBackColor = true;
            this.btnZeroCount.Visible = false;
            this.btnZeroCount.Click += new System.EventHandler(this.btnZeroCount_Click);
            // 
            // gp5
            // 
            this.gp5.Controls.Add(this.btnSaveInFile);
            this.gp5.Location = new System.Drawing.Point(592, 25);
            this.gp5.Name = "gp5";
            this.gp5.Size = new System.Drawing.Size(96, 161);
            this.gp5.TabIndex = 5;
            this.gp5.TabStop = false;
            this.gp5.Text = "Экспорт";
            // 
            // btnSaveInFile
            // 
            this.btnSaveInFile.Location = new System.Drawing.Point(6, 19);
            this.btnSaveInFile.Name = "btnSaveInFile";
            this.btnSaveInFile.Size = new System.Drawing.Size(84, 43);
            this.btnSaveInFile.TabIndex = 0;
            this.btnSaveInFile.Text = "Сохранить в файл";
            this.btnSaveInFile.UseVisualStyleBackColor = true;
            this.btnSaveInFile.Click += new System.EventHandler(this.btnSaveInFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(888, 790);
            this.Controls.Add(this.gp5);
            this.Controls.Add(this.btnZeroCount);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Мой IDEAL";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridProducts)).EndInit();
            this.gp5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtСountProduct;
        private System.Windows.Forms.TextBox txtPriceProduct;
        private System.Windows.Forms.TextBox txtVolumeProduct;
        [Required]
        private System.Windows.Forms.TextBox txtNameProduct;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbLabel;
        private System.Windows.Forms.Button btnAddLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSaleMonth;
        private System.Windows.Forms.Button btnViewSaleToDay;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmbLabelGrid;
        private System.Windows.Forms.Button btnViewAllProduct;
        private System.Windows.Forms.TextBox txtAllPriceGrid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCountProductGrid;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.DataGridView dtGridProducts;
        private System.Windows.Forms.Button butnViewWithLabel;
        private System.Windows.Forms.TextBox txtHiddenId;
        [Required]
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button bетDelLabel;
        private System.Windows.Forms.TextBox txtHiddenIdLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnZeroCount;
        private System.Windows.Forms.Button btnSaleBetween;
        private System.Windows.Forms.TextBox txtHiddenIndex;
        private System.Windows.Forms.GroupBox gp5;
        private System.Windows.Forms.Button btnSaveInFile;
    }
}

