using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRJ271_Milestone2
{
    internal class Sales
    {
        private DateTime date;
        private string saleNumber;
        private string specialRequest;
        private int quantity;
        private int itemPrice;

        public Sales(DateTime date, string saleNumber, string specialRequest, int quantity, int itemPrice)
        {
            this.Date1 = date;
            this.SaleNumber1 = saleNumber;
            this.SpecialRequest1 = specialRequest;
            this.Quantity1 = quantity;
            this.ItemPrice1 = itemPrice;
        }

        public DateTime Date1 { get => date; set => date = value; }
        public string SaleNumber1 { get => saleNumber; set => saleNumber = value; }
        public string SpecialRequest1 { get => specialRequest; set => specialRequest = value; }
        public int Quantity1 { get => quantity; set => quantity = value; }
        public int ItemPrice1 { get => itemPrice; set => itemPrice = value; }

        public void PlaceOrder() { }

        public void RecordSale() { }

        public void ShowSales() { }
    }
}
