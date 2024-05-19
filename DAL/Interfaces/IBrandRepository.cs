using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toomeet_Pos.Entites.Products;

namespace Toomeet_Pos.DAL.Interfaces
{
    public interface IBrandRepository
    {
        List<Brand> GetAllBrandByStoreId (long storeId);

        Brand SaveBrand(Brand brand);

        Brand GetBrandByNameAndStoreId(string name, long storeId);

        Brand UpdateBrand (Brand brand);
    }
}
