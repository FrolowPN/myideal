using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyIdeal
{
    public class SaleProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
        public int Discount { get; set; }
        public DateTime DateTimeSale { get; set; }
        public virtual Label Label { get; set; }

    }
}
