using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toomeet_Pos.Entites.Products;

namespace Toomeet_Pos.DAL.Interfaces
{
    public interface ICategoryRepository
    {
        List<Category> GetAllCategoriesByStoreId(long storeId);

        Category SaveCategory(Category category);
    }
}
