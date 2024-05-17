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

            Category existedCategoryByCode = GetCategoryByCodeAndStoreId(category.Code, category.StoreId);
           
            if (existedCategoryByCode != null)
            {
                throw new Exception("Mã Loại sản phẩm đã tồn tại");
            }

            Category existedCategoryByName = _categoryRepository.GetCategoryByNameAndStoreId(category.Name, category.StoreId);

            if (existedCategoryByName != null)
            {
                throw new Exception("Tên Loại sản phẩm đã tồn tại");
            }

            return _categoryRepository.SaveCategory(new Category()
           {
               Name = category.Name,
               Code = category.Code,
               StoreId = store.Id,
               Store = store
           });


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

            Category existedCategory = GetCategoryByCodeAndStoreId(category.Code, category.StoreId);

            if (existedCategory == null)
            {
                throw new Exception("Loại sản phẩm không tồn tại");
            }

            existedCategory.Name = category.Name;
            existedCategory.Description = category.Description;

            return _categoryRepository.UpdateCategory(existedCategory);
        }


        public void DeleteCategoryByCodeAndStoreId(string code, long storeId)
        {
            Category category = _categoryRepository.GetCategoryByCodeAndStoreId(code, storeId);

            _categoryRepository.DeleteCategoryById(category);
        }

        public Category UpsertCategory (SaveCategoryDto dto)
        {
            Store store = dto.Store;
            Staff staff = dto.Staff;
            Category category = dto.Category;

            category.Store = store;
            category.StoreId = store.Id;

            if (store == null || staff == null || category == null)
            {
                throw new Exception("Không đủ thông tin để cập nhật loại sản phẩm");
            }


            Category existedCategory = _categoryRepository.GetCategoryByCodeAndStoreId(category.Code, category.StoreId);

            if (existedCategory != null)
            {
                return UpdateCategory(dto);
            }
            else
            {
                return CreateCategory(dto);
            }
            
        }

        public Category GetCategoryByCodeAndStoreId(string code, long storeId)
        {
            return _categoryRepository.GetCategoryByCodeAndStoreId(code, storeId);
        }

    }


}
