using BL;
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
    public partial class ReportSaleDay : Form
    {
        public ReportSaleDay()
        {
            InitializeComponent();
        }

        private void ReportSaleDay_Load(object sender, EventArgs e)
        {
            lblNameReports.Text = DateTime.Now.ToShortDateString();
            var temp = new SaleProductManager();
            dtGrSale.DataSource = temp.GetSaleToday(DateTime.Now);
            dtGrSale.Columns["Id"].Visible = false;
            dtGrSale.Columns["LabelName"].HeaderText = "Марка";
            dtGrSale.Columns["Name"].HeaderText = "Название";
            dtGrSale.Columns["Name"].FillWeight = 250;
            dtGrSale.Columns["Price"].HeaderText = "Сумма продажи";
            dtGrSale.Columns["Discount"].HeaderText = "Скидка";
            dtGrSale.Columns["Count"].HeaderText = "Количество";
            dtGrSale.Columns["DateTimeSale"].HeaderText = "Дата продажи";
            txtCountProductGrid.Text = temp.GetAllSaleCount(temp.GetSaleToday(DateTime.Now)).ToString();
            txtAllPriceGrid.Text = temp.GetAllSalePrice(temp.GetSaleToday(DateTime.Now)).ToString();
        }
    }
}
