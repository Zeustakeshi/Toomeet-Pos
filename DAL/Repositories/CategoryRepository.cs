using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
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


        public Category GetCategoryByNameAndStoreId(string name, long storeId)
        {
            return _db.Category.FirstOrDefault(c => c.Name.Equals(name) && c.StoreId.Equals(storeId));
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


        public Category GetCategoryByCodeAndStoreId (string code, long storeId)
        {
            return _db.Category.FirstOrDefault(c => c.Code.Equals(code) && c.StoreId.Equals(storeId));
        }

        public bool IsExistedCategoryByCodeAndStoreId (string code, long storeId)
        {
            return GetCategoryByCodeAndStoreId(code, storeId) != null;
        }


        public Category UpdateCategory (Category category)
        {

            if (!IsExistedCategoryByCodeAndStoreId(category.Code, category.StoreId))
            {
                throw new Exception("Không tìm thấy loại sản phẩm với mã: " + category.Code + " ");
            }

            Category updatedCategory = _db.Category.Attach(category);

            _db.Entry(category).State = System.Data.Entity.EntityState.Modified;

            _db.SaveChanges();

            return updatedCategory;
        }

        public void DeleteCategoryById (Category category)
        {
            if (!IsExistedCategoryByCodeAndStoreId(category.Code, category.StoreId))
            {
                throw new Exception("Không tìm thấy loại sản phẩm với mã: " + category.Code + " ");
            }

            Category deletedCategory = _db.Category.Remove(category);

            _db.Entry(deletedCategory).State = System.Data.Entity.EntityState.Deleted;

            _db.SaveChanges();
        }

    }

  
}
