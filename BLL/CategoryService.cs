using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toomeet_Pos.BLL.Interfaces;
using Toomeet_Pos.DAL.Interfaces;
using Toomeet_Pos.DTOs;
using Toomeet_Pos.Entites;
using Toomeet_Pos.Entites.Products;

namespace Toomeet_Pos.BLL
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IRoleService _roleService;

        public CategoryService (ICategoryRepository categoryRepository, IRoleService roleService)
        {
            _categoryRepository = categoryRepository;
            _roleService = roleService;
        }

        public List<Category> GetAllCategories(long storeId)
        {
            return _categoryRepository.GetAllCategoriesByStoreId(storeId);
        }



        public Category CreateCategory(NewCategoryDto dto)
        {
            Store store = dto.Store;
            Staff staff = dto.Staff;
            Category category = dto.Category;

            if (store == null || staff == null || category == null)
            {
                throw new Exception("Không đủ thông tin để tạo loại sản phẩm");
            }

            if (!_roleService.CanCreateProduct(staff))
            {
                throw new Exception(staff.Name + " không có quyền tạo loại sản phẩm");
            }

            category.Store = store;
            category.StoreId = store.Id;

            return _categoryRepository.SaveCategory(category);


        }

      
    }


}
