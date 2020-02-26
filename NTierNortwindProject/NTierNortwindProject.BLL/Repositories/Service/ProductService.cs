using NTierNortwindProject.DAL.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierNortwindProject.BLL.Repositories.Service
{
    public class ProductService
    {
        NORTHWNDEntities db = new NORTHWNDEntities();
        public void AddProduct(Product product, int categoryId)
        {            
            if (product != null)
            {
                product.CategoryID = categoryId;
                db.Products.Add(product);
                db.SaveChanges();
                
            }
        }
        //public void AddCategoryForProduct(int categoryId)
        //{
        //    var category = SelectById(categoryId);
        //    db.Products.Add(category);
        //}


        public Category SelectById(int id)
        {
            return db.Categories.Find(id);
        }
    }
}
