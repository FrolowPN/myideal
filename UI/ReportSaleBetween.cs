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
    public partial class ReportSaleBetween : Form
    {
        public ReportSaleBetween()
        {
            InitializeComponent();
        }

        private void ReportSaleBetween_Load(object sender, EventArgs e)
        {


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGetSaleBetween_Click(object sender, EventArgs e)
        {
            if (ckBoxMonth.Checked)
            {
                var helper = new SaleProductManager();
                dtGrSaleBetween.DataSource = helper.GetSaleMonth(Convert.ToDateTime(dtMonth.Text));
                dtGrSaleBetween.Columns["Id"].Visible = false;
                dtGrSaleBetween.Columns["LabelName"].HeaderText = "Марка";
                dtGrSaleBetween.Columns["Name"].HeaderText = "Название";
                dtGrSaleBetween.Columns["Name"].FillWeight = 250;
                dtGrSaleBetween.Columns["Price"].HeaderText = "Сумма продажи";
                dtGrSaleBetween.Columns["Discount"].HeaderText = "Скидка";
                dtGrSaleBetween.Columns["Count"].HeaderText = "Количество";
                dtGrSaleBetween.Columns["DateTimeSale"].HeaderText = "Дата продажи";
                txtAllPriceGrid.Text = helper.GetAllSalePrice(helper.GetSaleMonth(Convert.ToDateTime(dtMonth.Text))).ToString();
                txtCountProductGrid.Text = helper.GetAllSaleCount(helper.GetSaleMonth(Convert.ToDateTime(dtMonth.Text))).ToString();
            }
            else
            {
                var helper = new SaleProductManager();
                dtGrSaleBetween.DataSource = helper.GetSaleBetween(Convert.ToDateTime(dtBegin.Text), Convert.ToDateTime(dtEnd.Text));
                dtGrSaleBetween.Columns["Id"].Visible = false;
                dtGrSaleBetween.Columns["LabelName"].HeaderText = "Марка";
                dtGrSaleBetween.Columns["Name"].HeaderText = "Название";
                dtGrSaleBetween.Columns["Name"].FillWeight = 250;
                dtGrSaleBetween.Columns["Price"].HeaderText = "Сумма продажи";
                dtGrSaleBetween.Columns["Discount"].HeaderText = "Скидка";
                dtGrSaleBetween.Columns["Count"].HeaderText = "Количество";
                dtGrSaleBetween.Columns["DateTimeSale"].HeaderText = "Дата продажи";
                txtAllPriceGrid.Text = helper.GetAllSalePrice(helper.GetSaleBetween(Convert.ToDateTime(dtBegin.Text), Convert.ToDateTime(dtEnd.Text))).ToString();
                txtCountProductGrid.Text = helper.GetAllSaleCount(helper.GetSaleBetween(Convert.ToDateTime(dtBegin.Text), Convert.ToDateTime(dtEnd.Text))).ToString();
            }

        }

        private void ckBoxMonth_CheckedChanged(object sender, EventArgs e)
        {
            if (ckBoxMonth.Checked)
            {
                dtEnd.Visible = false;
                dtBegin.Visible = false;
                label2.Visible = false;
                dtMonth.Visible = true;
            }
            else
            {
                dtEnd.Visible = true;
                dtBegin.Visible = true;
                label2.Visible = true;
                dtMonth.Visible = false;
            }
        }
    }
}
