using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderASPWCF.Interface;

namespace OrderASPWCF.Repository
{
    class CategoryRepository : ICategoryRepository
    {
         private OSMDBContainer context;

        public CategoryRepository() 
        {
            this.context = new OSMDBContainer();
        }

        public Category GetCategoryById(int id)
         {
             Category category;

             try
             {
                 category = context.Category.First(c => c.Id == id);
             }
             catch (Exception e)
             {
                 category = new Category() { Name = "Not found!!!" };
             }

             return category;
         }
    }
}
