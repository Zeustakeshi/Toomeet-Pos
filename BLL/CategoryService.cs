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



        public Category CreateCategory(SaveCategoryDto dto)
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

        public Category UpdateCategory(SaveCategoryDto dto)
        {
            Store store = dto.Store;
            Staff staff = dto.Staff;
            Category category = dto.Category;

            if (store == null || staff == null || category == null)
            {
                throw new Exception("Không đủ thông tin để cập nhật loại sản phẩm");
            }

            if (!_roleService.CanEditProduct(staff))
            {
                throw new Exception(staff.Name + " không có quyền cập nhật loại sản phẩm");
            }

            return _categoryRepository.UpdateCategory(dto.Category);
        }


        public void DeleteCategoryById(string categoryId)
        {
            Category category = _categoryRepository.GetCategoryById(categoryId);

            _categoryRepository.DeleteCategoryById(category);
        }

        public Category UpsertCategory (SaveCategoryDto dto)
        {
            Store store = dto.Store;
            Staff staff = dto.Staff;
            Category category = dto.Category;

            if (store == null || staff == null || category == null)
            {
                throw new Exception("Không đủ thông tin để cập nhật loại sản phẩm");
            }

            Category existedCategory = _categoryRepository.GetCategoryById(category.Id);

            if (existedCategory != null) return UpdateCategory(dto);
            else return CreateCategory(dto);
            
        }

    }


}
