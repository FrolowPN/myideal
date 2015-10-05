using BL.DataView;
using MyIdeal;
using System;
using System.Collections.Generic;
using System.IO;
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

        public List<DataViewSaleProduct> GetSaleMonth(DateTime date)
        {
            var ctx = new ShopContext();
            var temp = ctx.SaleProduct.Where(x => x.DateTimeSale.Month == date.Month).ToList();
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

        public bool WriteSaleInFile(List<DataViewSaleProduct > list, string address)
        {
            try
            {
                string path = address + @"\ProductsSale.txt";
                int i = 0;
                foreach (var item in list)
                {
                    if (item.Count != 0)
                    {
                        i++;
                        using (StreamWriter file = new StreamWriter(path, true))
                        {
                            file.WriteLine(i + " " + item.LabelName + " " + item.Name + " " + item.Price + "000р. " + item.Count + "шт. Скидка - "+item.Discount + " " + item.DateTimeSale);
                            //file.WriteLine("    -= " + i + " =-");
                            //file.WriteLine(item.LabelName);
                            //file.WriteLine(item.Name);
                            //file.WriteLine(item.Volume + "ml");
                            //file.WriteLine(item.Price + "000р. ");
                            //file.WriteLine(item.Count + "шт.");
                            file.WriteLine("");

                        }
                    }
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool WriteStringInFile(string text, string address)
        {
            try
            {
                string path = address + @"\ProductsSale.txt";
                
                        using (StreamWriter file = new StreamWriter(path, true))
                        {
                            file.WriteLine(text);
                        }
                    
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
