using BL.DataView;
using MyIdeal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class LabelManager
    {
        public void AddLabel (string label)
        {
            var ctx = new ShopContext();
            var temp = new Label();
            temp.Name = label;
            ctx.Label.Add(temp);
            ctx.SaveChanges();
        }
        public void DelLabel(int id, string label)
        {
            var ctx = new ShopContext();
            var temp = ctx.Label.Where(x => x.Id == id).FirstOrDefault();
            temp.Name = label;
            ctx.SaveChanges();
        }
        public List<DataViewLabel> GetAllLabel()
        {
            var ctx = new ShopContext();
            var result = ctx.Label.Select(x => new DataViewLabel()
                                                    {
                                                        Id = x.Id,
                                                        NameLabel = x.Name

                                                    }).ToList();
            return result;
        
        }
       

    }
}
