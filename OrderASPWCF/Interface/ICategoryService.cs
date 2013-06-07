using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using OrderASPWCF.Entity;

namespace OrderASPWCF.Interface
{
    [ServiceContract]
    public interface ICategoryService
    {
        /// <summary>
        /// Get category name by Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>string</returns>
        [OperationContract]
        string GetCategoryNameById(int id);
        /// <summary>
        /// Get product list
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>List</returns>
        [OperationContract]
        List<ProductEntity> GetProducts(int id);
    }
}
