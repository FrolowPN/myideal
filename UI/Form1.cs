using BL;
using MyIdeal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var products = new ProductManager();
            dtGridProducts.DataSource = products.GetAllProduct();
            dtGridProducts.Columns["Id"].Visible = false;
            dtGridProducts.Columns["LabelName"].HeaderText = "Марка";
            dtGridProducts.Columns["Name"].HeaderText = "Название";
            dtGridProducts.Columns["Name"].FillWeight = 250;
            dtGridProducts.Columns["Volume"].HeaderText = "Объем";
            dtGridProducts.Columns["Price"].HeaderText = "Цена";
            dtGridProducts.Columns["Count"].HeaderText = "Количество";

            txtCountProductGrid.Text = products.GetAllProductCount(products.GetAllProduct()).ToString();
            txtAllPriceGrid.Text = products.GetAllProductPrice(products.GetAllProduct()).ToString();

            var temp = new LabelManager();
            cmbLabel.DataSource = temp.GetAllLabel();
            cmbLabel.ValueMember = "Id";
            cmbLabel.DisplayMember = "NameLabel";
            cmbLabelGrid.DataSource = temp.GetAllLabel();
            cmbLabelGrid.ValueMember = "Id";
            cmbLabelGrid.DisplayMember = "NameLabel";
            txtDiscount.Text = "0";


        }

        private void btnViewAllProduct_Click(object sender, EventArgs e)
        {
            var products = new ProductManager();
            dtGridProducts.DataSource = products.GetAllProduct();
            txtCountProductGrid.Text = products.GetAllProductCount(products.GetAllProduct()).ToString();
            txtAllPriceGrid.Text = products.GetAllProductPrice(products.GetAllProduct()).ToString();
        }

        private void btnAddLabel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Добавить марку?", "Добавить", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }
            else
            {
                var helper = new LabelManager();
                helper.AddLabel(cmbLabel.Text.ToString());
                cmbLabel.DataSource = helper.GetAllLabel();
                cmbLabelGrid.DataSource = helper.GetAllLabel();
                MessageBox.Show("Марка успешно добавлена!");
            }
        }

        private void butnViewWithLabel_Click(object sender, EventArgs e)
        {
            var helper = new ProductManager();
            dtGridProducts.DataSource = helper.GetProductLabel(cmbLabelGrid.Text.ToString());
            txtCountProductGrid.Text = helper.GetAllProductCount(helper.GetProductLabel(cmbLabelGrid.Text.ToString())).ToString();
            txtAllPriceGrid.Text = helper.GetAllProductPrice(helper.GetProductLabel(cmbLabelGrid.Text.ToString())).ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                if (MessageBox.Show("Добавить этот товар?", "Добавить",
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {

                    return;
                }
                else
                {
                    var ctx = new ShopContext();
                    var helper = new Product()
                    {
                        Name = txtNameProduct.Text.ToString(),
                        Volume = Convert.ToInt32(txtVolumeProduct.Text),
                        Price = Convert.ToInt32(txtPriceProduct.Text),
                        Count = Convert.ToInt32(txtСountProduct.Text)
                    };
                    var temp = new ProductManager();
                    if (temp.AddProduct(helper, cmbLabel.Text.ToString()))
                    {
                        dtGridProducts.DataSource = temp.GetAllProduct();
                        txtCountProductGrid.Text = temp.GetAllProductCount(temp.GetAllProduct()).ToString();
                        txtAllPriceGrid.Text = temp.GetAllProductPrice(temp.GetAllProduct()).ToString();
                        MessageBox.Show("Товар добавлен!");
                    }
                    else
                    {
                        MessageBox.Show("Упс! Что-то пошло не так!");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Упс! Что-то пошло не так!");

            }

        }

        private void dtGridProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
 txtHiddenId.Text = dtGridProducts.Rows[e.RowIndex].Cells["Id"].Value.ToString();
            txtNameProduct.Text = dtGridProducts.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            txtVolumeProduct.Text = dtGridProducts.Rows[e.RowIndex].Cells["Volume"].Value.ToString();
            txtPriceProduct.Text = dtGridProducts.Rows[e.RowIndex].Cells["Price"].Value.ToString();
            txtСountProduct.Text = dtGridProducts.Rows[e.RowIndex].Cells["Count"].Value.ToString();
            var tempNameLabel = dtGridProducts.Rows[e.RowIndex].Cells["LabelName"].Value.ToString();
            var ctx = new ShopContext();
            cmbLabel.SelectedValue = ctx.Label.Where(x => x.Name == tempNameLabel).FirstOrDefault().Id;
            txtDiscount.Text = "0";
            txtHiddenIndex.Text = dtGridProducts.CurrentRow.Index.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Но-но-но!!");
            }
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Изменить этот товар?", "Изменить",
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {

                    return;
                }
                else
                {
                    var ctx = new ShopContext();
                    var helper = new Product()
                    {
                        Id = Convert.ToInt32(txtHiddenId.Text),
                        Name = txtNameProduct.Text.ToString(),
                        Volume = Convert.ToInt32(txtVolumeProduct.Text),
                        Price = Convert.ToInt32(txtPriceProduct.Text),
                        Count = Convert.ToInt32(txtСountProduct.Text)
                    };
                    var temp = new ProductManager();
                    if (temp.SaveProduct(helper, cmbLabel.Text.ToString()))
                    {
                        dtGridProducts.DataSource = temp.GetAllProduct();
                        if (Convert.ToInt32(txtHiddenIndex.Text) < dtGridProducts.RowCount)
                        {
                            dtGridProducts.ClearSelection();
                            dtGridProducts.Rows[Convert.ToInt32(txtHiddenIndex.Text)].Selected = true;
                            dtGridProducts.FirstDisplayedScrollingRowIndex = Convert.ToInt32(txtHiddenIndex.Text);
                            dtGridProducts.Update();
                        } 
                        txtCountProductGrid.Text = temp.GetAllProductCount(temp.GetAllProduct()).ToString();
                        txtAllPriceGrid.Text = temp.GetAllProductPrice(temp.GetAllProduct()).ToString();
                        MessageBox.Show("Товар изменен");
                    }
                    else
                    {
                        MessageBox.Show("Упс! Что-то пошло не так!");
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Упс! Что-то пошло не так!");
            }


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Удалить товар?", "Удалить",
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {

                    return;
                }
                else
                {
                    var temp = new ProductManager();
                    if (temp.DeleteProduct(Convert.ToInt32(txtHiddenId.Text)))
                    {
                        dtGridProducts.DataSource = temp.GetAllProduct();
                        txtCountProductGrid.Text = temp.GetAllProductCount(temp.GetAllProduct()).ToString();
                        txtAllPriceGrid.Text = temp.GetAllProductPrice(temp.GetAllProduct()).ToString();
                        MessageBox.Show("Товар удален");
                    }
                    else
                    {
                        MessageBox.Show("Упс! Что-то пошло не так!");
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Упс! Что-то пошло не так!");
            }


        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Продать этот товар?", "Продать",
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {

                    return;
                }
                else
                {
                    var prod = new ProductManager();
                    prod.AddSale(Convert.ToInt32(txtHiddenId.Text), Convert.ToInt32(txtСountProduct.Text));
                    var temp = new SaleProductManager();

                    var sale = new SaleProduct()
                    {

                        Name = txtNameProduct.Text.ToString(),
                        Count = Convert.ToInt32(txtСountProduct.Text),
                        Price = Convert.ToInt32(txtPriceProduct.Text),
                        Discount = Convert.ToInt32(txtDiscount.Text),
                        DateTimeSale = DateTime.Now
                    };
                    temp.AddSale(sale, cmbLabel.Text.ToString());
                    dtGridProducts.DataSource = prod.GetAllProduct();
                    if (Convert.ToInt32(txtHiddenIndex.Text) < dtGridProducts.RowCount )
                    {
                        dtGridProducts.ClearSelection();
                        dtGridProducts.Rows[Convert.ToInt32(txtHiddenIndex.Text)].Selected = true;
                        dtGridProducts.FirstDisplayedScrollingRowIndex = Convert.ToInt32(txtHiddenIndex.Text);
                        dtGridProducts.Update();
                    } 
                    txtCountProductGrid.Text = prod.GetAllProductCount(prod.GetAllProduct()).ToString();
                    txtAllPriceGrid.Text = prod.GetAllProductPrice(prod.GetAllProduct()).ToString();
                    MessageBox.Show("Товар продан");
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Упс! Что-то пошло не так!");
            }

        }

        private void btnViewSaleToDay_Click(object sender, EventArgs e)
        {
            var reportForm = new ReportSaleDay();
            reportForm.Show();
        }

        private void btnSaleMonth_Click(object sender, EventArgs e)
        {
            var reportForm = new ReportSale();
            reportForm.Show();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Закрыть программу?", this.Text,
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                e.Cancel = true;
                return;
            }
        }

        private void bетDelLabel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Изменить марку?", "Изменить", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }
            else
            {
                var helper = new LabelManager();

                helper.DelLabel(Convert.ToInt32(txtHiddenIdLabel.Text), cmbLabel.Text.ToString());
                cmbLabel.DataSource = helper.GetAllLabel();
                cmbLabelGrid.DataSource = helper.GetAllLabel();
                var prod = new ProductManager();
                dtGridProducts.DataSource = prod.GetAllProduct();
                MessageBox.Show("Марка успешно изменена!");
            }

        }

        private void cmbLabel_Click(object sender, EventArgs e)
        {
            try
            {
                var ctx = new ShopContext();
                txtHiddenIdLabel.Text = ctx.Label.Where(x => x.Name == cmbLabel.Text).FirstOrDefault().Id.ToString();

            }
            catch (Exception)
            {

                //throw;
            }


        }

        private void dtGridProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtGridProducts_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            DataGridView grid = sender as DataGridView;
            if (grid != null)
            {
                if (Convert.ToInt32(dtGridProducts["Count", e.RowIndex].Value.ToString()) <= 0)
                    grid.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            //var temp = new ProductManager();
            //dtGridProducts.DataSource = temp.GetAllProduct();
        }

        private void btnZeroCount_Click(object sender, EventArgs e)
        {
            var temp = new ProductManager();
            temp.ZeroCountProduct();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var report = new ReportSaleBetween();
            report.Show();
        }
    }
}
