using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toomeet_Pos.DTOs;
using Toomeet_Pos.Entites.Products;

namespace Toomeet_Pos.BLL.Interfaces
{
    public interface IBrandService
    {
        List<Brand> GetAllBrands (long storeId);

        Brand CreateBrand(SaveBrandDto dto);

        Brand GetBrandByNameAndStoreId(string name, long storeId);


        Brand UpsertBrand (SaveBrandDto dto);

        Brand UpdateBrand (SaveBrandDto dto);
    }
}
