using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using OrderASPWCF.Interface;
using OrderASPWCF.Repository;
using OrderASPWCF.Entity;

namespace OrderASPWCF.Service
{
    [ServiceBehavior(InstanceContextMode=InstanceContextMode.Single)]
    class CategoryService : ICategoryService
    {
        private CategoryRepository repository;

        public CategoryService() 
        {
            repository = new CategoryRepository();
        }

        public string GetCategoryNameById(int id)
        {
            Category category = repository.GetCategoryById(id);

            return category.Name;
        }

        public List<ProductEntity> GetProducts(int id) 
        {
            Category category = repository.GetCategoryById(id);
            List<ProductEntity> products = new List<ProductEntity>();

            foreach (Product p in category.Product.ToList()) 
            {
                products.Add(new ProductEntity() { Id = p.Id, Name = p.Name});
            }

            return products;
        }
    }
}
