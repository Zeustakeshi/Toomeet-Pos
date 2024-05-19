using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toomeet_Pos.DTOs;
using Toomeet_Pos.Entites.Products;

namespace Toomeet_Pos.BLL.Interfaces
{
    public interface ICategoryService
    {
        List<Category> GetAllCategories(long storeId);


        Category GetCategoryByCodeAndStoreId(string code, long storeId);

        Category UpsertCategory(SaveCategoryDto dto);

        void DeleteCategoryByCodeAndStoreId (string code, long storeId);
    }
}
