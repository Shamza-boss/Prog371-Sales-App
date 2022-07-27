using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT
{
    public partial class SalesForm : Form
    {
        
        public SalesForm()
        {
            InitializeComponent();
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Sales sale = new Sales(dtp_Date.Value, txt_SaleNumber.Text,txt_SpecialRequest.Text,int.Parse(txt_Quantity.Text),int.Parse(txt_ItemPrice.Text));
            sale.UpdateSale();
        }

        private void btn_ShowAll_Click(object sender, EventArgs e)
        {
            Sales sale = new Sales(dtp_Date.Value, txt_SaleNumber.Text, txt_SpecialRequest.Text, int.Parse(txt_Quantity.Text), int.Parse(txt_ItemPrice.Text));
            sale.ShowSales();
        }   

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            Sales sale = new Sales(dtp_Date.Value, txt_SaleNumber.Text, txt_SpecialRequest.Text, int.Parse(txt_Quantity.Text), int.Parse(txt_ItemPrice.Text));
            sale.DeleteSales();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Sales sale = new Sales(dtp_Date.Value, txt_SaleNumber.Text, txt_SpecialRequest.Text, int.Parse(txt_Quantity.Text), int.Parse(txt_ItemPrice.Text));
            sale.RecordSale();
        }
    }
}
