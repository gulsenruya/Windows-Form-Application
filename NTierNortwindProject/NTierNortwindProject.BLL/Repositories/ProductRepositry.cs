using NTierNortwindProject.DAL.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierNortwindProject.BLL.Repositories
{
    public class ProductRepositry : IRepository<Product>
    {
        NORTHWNDEntities db = new NORTHWNDEntities();
        public void Add(Product item)
        {
            db.Products.Add(item);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            db.Products.Remove(db.Products.Find(id));
            db.SaveChanges();
        }

        public List<Product> SelectAll()
        {
            return db.Products.ToList();
        }

        public Product SelectbyId(int id)
        {
            return db.Products.Find(id);
        }

        public void Update(Product item)
        {
            db.Entry(item).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
