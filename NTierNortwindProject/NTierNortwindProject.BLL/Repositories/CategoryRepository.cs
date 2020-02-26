using NTierNortwindProject.DAL.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierNortwindProject.BLL.Repositories
{
    public class CategoryRepository : IRepository<Category>
    {
        NORTHWNDEntities db = new NORTHWNDEntities();
        public void Add(Category item)
        {
            db.Categories.Add(item);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            db.Categories.Remove(db.Categories.Find(id));
            db.SaveChanges();
        }

        public List<Category> SelectAll()
        {
            return db.Categories.ToList();
        }

        public Category SelectbyId(int id)
        {
            return db.Categories.Find(id);
        }

        public void Update(Category item)
        {
            db.Entry(item).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
