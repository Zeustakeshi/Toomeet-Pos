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
    public class BrandService : IBrandService
    {
        private readonly IBrandRepository _brandRepository;
        private readonly IRoleService _roleService;

        public BrandService(IBrandRepository brandRepository, IRoleService roleService)
        {
            _brandRepository = brandRepository;
            _roleService = roleService;
        }

        public List<Brand> GetAllBrands(long storeId)
        {
            return _brandRepository.GetAllBrandByStoreId(storeId);
        }

        public Brand CreateBrand(NewBrandDto dto)
        {
            Store store = dto.Store;
            Staff staff = dto.Staff;
            Brand newBrand = dto.Brand;


            if (store == null || staff == null || newBrand == null)
            {
                throw new Exception("Không đủ thông tin để tạo nhãn hiệu mới");
            }

            if (!_roleService.CanCreateProduct(staff))
            {
                throw new Exception("Nhân viên " + staff.Name + " không có quyền tạo nhãn hiệu mới");
            }

            newBrand.Store = store;
            newBrand.StoreId = store.Id;

            return _brandRepository.SaveBrand(newBrand);

        }
    }
}
