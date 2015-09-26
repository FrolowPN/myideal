using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.DataView
{
    public class DataViewSaleProduct
    {
        public int Id { get; set; }
        public string LabelName { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Discount { get; set; }
        public int Count { get; set; }
       
        public DateTime DateTimeSale { get; set; }
    }
}
