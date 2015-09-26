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
    public partial class ReportSale : Form
    {
        public ReportSale()
        {
            InitializeComponent();
        }

        private void ReportSale_Load(object sender, EventArgs e)
        {
            lblNameReports.Text = "за все время!";
            var temp = new SaleProductManager();
            dtGrSale.DataSource = temp.GetAllSale();
            dtGrSale.Columns["Id"].Visible = false;
            dtGrSale.Columns["LabelName"].HeaderText = "Марка";
            dtGrSale.Columns["Name"].HeaderText = "Название";
            dtGrSale.Columns["Name"].FillWeight = 250;
            dtGrSale.Columns["Price"].HeaderText = "Сумма продажи";
            dtGrSale.Columns["Discount"].HeaderText = "Скидка";
            dtGrSale.Columns["Count"].HeaderText = "Количество";
            dtGrSale.Columns["DateTimeSale"].HeaderText = "Дата продажи";

            dtGrSale.Columns["Id"].Visible = false;
            txtCountProductGrid.Text = temp.GetAllSaleCount(temp.GetAllSale()).ToString();
            txtAllPriceGrid.Text = temp.GetAllSalePrice(temp.GetAllSale()).ToString();
        }

        private void dtGrSale_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtHiddenId.Text = dtGrSale.Rows[e.RowIndex].Cells["Id"].Value.ToString();
            var ctx = new ShopContext();
            var temp = dtGrSale.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            txtHiddenIdProduct.Text = ctx.Product.Where(x => x.Name == temp).FirstOrDefault().Id.ToString();
            txtHiddenCount.Text = dtGrSale.Rows[e.RowIndex].Cells["Count"].Value.ToString();
        }

        private void btnCancelSale_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Отменить продажу?", "Отменить", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }
            else
            {
                try
                {
                    var helperSale = new SaleProductManager();

                    var helperProduct = new ProductManager();
                    if (helperProduct.DelSale(Convert.ToInt32(txtHiddenIdProduct.Text), Convert.ToInt32(txtHiddenCount.Text)) &&
                       helperSale.DelSale(Convert.ToInt32(txtHiddenId.Text)))
                    {
                        dtGrSale.DataSource = helperSale.GetAllSale();
                        MessageBox.Show("Продажа успешно отменена!");
                        var products = new ProductManager();
                        Form1 form = new Form1();
                        
                       form.dtGridProducts.DataSource = products.GetAllProduct();
                      
                    }
                    else
                    {
                        
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Упс! Что-то пошло не так!");
                }
               
            }
        }

        private void ReportSale_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
