using NTierNortwindProject.DAL.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierNortwindProject.BLL.Repositories.Service
{
    public class CategoryService
    {
        NORTHWNDEntities db = new NORTHWNDEntities();
        //Ekleme
        public void Add(Category category)
        {
            if (category != null)
            {
                db.Categories.Add(category);
                db.SaveChanges();
            }                       
        }

        public void Delete(int categoryId)
        {
            //var deleted = db.Categories.Find(categoryId);
            var deleted = SelectById(categoryId); // recursive
            if (deleted!=null)
            {
                db.Categories.Remove(deleted);
                db.SaveChanges();
            }
        }

        public void Update(Category category)
        {
            #region I.yol
            //var updated = db.Categories.Find(category.CategoryID);
            //updated.CategoryName = category.CategoryName;
            //updated.Description = category.Description;
            //db.SaveChanges();
            #endregion
            #region II.Yol
            db.Entry(category).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            #endregion
        }

        public List<Category> Lists()
        {
            return db.Categories.ToList();
        }

        public Category SelectById(int id)
        {
            return db.Categories.Find(id);
        }
    }
}
