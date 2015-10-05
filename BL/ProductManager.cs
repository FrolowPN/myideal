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
    public class ProductManager
    {
        public List<DataViewProducts> GetAllProduct()
        {
            var ctx = new ShopContext();
            var result = ctx.Product.Select(x => new DataViewProducts()
                                                        {
                                                            Id = x.Id,
                                                            LabelName = x.Label.Name,
                                                            Name = x.Name,
                                                            Volume = x.Volume,
                                                            Price = x.Price,
                                                            Count = x.Count
                                                        }).ToList();
            return result;

        }

        public List<DataViewProducts> GetProductLabel(string label)
        {
            var ctx = new ShopContext();
            var helper = ctx.Label.Where(x => x.Name == label).FirstOrDefault();
            var temp = ctx.Product.Where(m => m.Label.Name == helper.Name).ToList();

            var result = temp.Select(x => new DataViewProducts()
            {
                Id = x.Id,
                LabelName = x.Label.Name,
                Name = x.Name,
                Volume = x.Volume,
                Price = x.Price,
                Count = x.Count
            }).ToList();
            return result;

        }
        public bool SaveProduct(Product product, string label)
        {
            try
            {
                var ctx = new ShopContext();
                var temp = ctx.Label.Where(x => x.Name == label).FirstOrDefault();
                var tempProduct = ctx.Product.Where(x => x.Id == product.Id).FirstOrDefault();
                tempProduct.Label = temp;
                tempProduct.Name = product.Name;
                tempProduct.Volume = product.Volume;
                tempProduct.Price = product.Price;
                tempProduct.Count = product.Count;
                ctx.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
            }

        }
        public bool DeleteProduct(int id)
        {
            try
            {
                var ctx = new ShopContext();
                ctx.Product.Remove(ctx.Product.Where(x => x.Id == id).FirstOrDefault());
                ctx.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
            }

        }
        public bool AddProduct(Product product, string label)
        {
            try
            {
                var ctx = new ShopContext();
                var temp = ctx.Label.Where(x => x.Name == label).SingleOrDefault();
                product.Label = temp;
                ctx.Product.Add(product);
                ctx.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
            }

        }

        public int GetAllProductCount(List<DataViewProducts> list)
        {
            int temp = 0;
            foreach (var item in list)
            {
                temp += item.Count;
            }
            return temp;

        }
        public int GetAllProductPrice(List<DataViewProducts> list)
        {
            int temp = 0;
            foreach (var item in list)
            {
                temp += item.Count * item.Price;
            }
            return temp;

        }
        public bool AddSale(int id, int count)
        {
            try
            {
                var ctx = new ShopContext();
                var temp = ctx.Product.Where(x => x.Id == id).FirstOrDefault();
                temp.Count -= count;
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }
        public bool DelSale(int id, int count)
        {
            try
            {
                var ctx = new ShopContext();
                var temp = ctx.Product.Where(x => x.Id == id).FirstOrDefault();
                temp.Count += count;
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }
        public void ZeroCountProduct()
        {
            var ctx = new ShopContext();
            foreach (var item in ctx.Product)
            {
                item.Count = 0;

            }
            ctx.SaveChanges();

        }

      
        public bool WriteProductsFile(List<DataViewProducts> list, string address)
        {
            try
            {
                string path = address + @"\Products.txt";
                int i = 0;
                foreach (var item in list)
                {
                    if (item.Count != 0)
                    {
                        i++;
                        using (StreamWriter file = new StreamWriter(path, true))
                        {
                            file.WriteLine(i + " " + item.LabelName + " " + item.Name + " " + item.Volume + "ml " + item.Price + "000р. " + item.Count+"шт.");
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

    }
}
