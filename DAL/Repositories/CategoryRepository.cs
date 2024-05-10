using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toomeet_Pos.DAL.Interfaces;
using Toomeet_Pos.Entites.Products;

namespace Toomeet_Pos.DAL.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDBContext _db;

        public CategoryRepository (IDataAccessLayer dataAccess)
        {
            _db = dataAccess.GetContext();
        }

        public List<Category> GetAllCategoriesByStoreId(long storeId)
        {
            return _db.Category
                .Where(c => c.StoreId.Equals(storeId))
                .ToList();
        }

        public Category SaveCategory(Category category)
        {
            Category newCategory = _db.Category.Add(category);
            _db.SaveChanges();
            return newCategory;
        }
    }

  
}
