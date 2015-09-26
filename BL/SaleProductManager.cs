using BL.DataView;
using MyIdeal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class SaleProductManager
    {
        public List<DataViewSaleProduct> GetAllSale()
        {
            var ctx = new ShopContext();
            var result = ctx.SaleProduct.Select(x => new DataViewSaleProduct()
                                                            {
                                                                Id = x.Id,
                                                                LabelName = x.Label.Name,
                                                                Name = x.Name,
                                                                Count = x.Count,
                                                                Price = x.Price,
                                                                Discount = x.Discount,
                                                                DateTimeSale = x.DateTimeSale
                                                            }).ToList();
            return result;
        }

        public bool AddSale(SaleProduct sale, string label)
        {
            try
            {
                var ctx = new ShopContext();
                var temp = ctx.Label.Where(x => x.Name == label).FirstOrDefault();
                sale.Label = temp;
                sale.Price = (sale.Price * sale.Count) - sale.Discount;
                ctx.SaleProduct.Add(sale);
                ctx.SaveChanges();
                return true;

            }
            catch (Exception)
            {

                return false;
            }

        }
        public List<DataViewSaleProduct> GetSaleToday(DateTime date)
        {
            var ctx = new ShopContext();
            var temp = ctx.SaleProduct.Where(x => x.DateTimeSale > date.Date).ToList();
            var result = temp.Select(x => new DataViewSaleProduct()
                                                    {
                                                        Id = x.Id,
                                                        LabelName = x.Label.Name,
                                                        Name = x.Name,
                                                        Price = x.Price,
                                                        Discount = x.Discount,
                                                        Count = x.Count,
                                                        DateTimeSale = x.DateTimeSale
                                                    }).ToList();

            return result;

        }

        public int GetAllSaleCount(List<DataViewSaleProduct> list)
        {
            int temp = 0;
            foreach (var item in list)
            {
                temp += item.Count;
            }
            return temp;

        }
        public int GetAllSalePrice(List<DataViewSaleProduct> list)
        {
            int temp = 0;
            foreach (var item in list)
            {
                temp += item.Price;
            }
            return temp;
        }
        public bool DelSale(int id)
        {
            try
            {
                var ctx = new ShopContext();
                var temp = ctx.SaleProduct.Where(x => x.Id == id).FirstOrDefault();
                ctx.SaleProduct.Remove(temp);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public List<DataViewSaleProduct> GetSaleBetween(DateTime dateBegin, DateTime dateEnd)
        {
            var ctx = new ShopContext();
            var tempSale = ctx.SaleProduct.Where(x => (x.DateTimeSale >= dateBegin.Date)).ToList();
            var tempResult = tempSale.Where(x => x.DateTimeSale < dateEnd.Date.AddDays(1).Date).ToList();
            var result = tempResult.Select(x => new DataViewSaleProduct()
                                                        {
                                                            Id = x.Id,
                                                            LabelName = x.Label.Name,
                                                            Name = x.Name,
                                                            Price = x.Price,
                                                            Discount = x.Discount,
                                                            Count = x.Count,
                                                            DateTimeSale = x.DateTimeSale
                                                        }).ToList();
            return result;
        }
    }
}
