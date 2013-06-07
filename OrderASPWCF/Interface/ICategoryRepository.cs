using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderASPWCF.Interface
{
    public interface ICategoryRepository
    {
        Category GetCategoryById(int id);
    }
}
