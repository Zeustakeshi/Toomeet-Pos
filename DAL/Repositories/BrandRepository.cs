using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toomeet_Pos.DAL.Interfaces;
using Toomeet_Pos.Entites.Products;

namespace Toomeet_Pos.DAL.Repositories
{
    public class BrandRepository : IBrandRepository
    {

        private readonly AppDBContext _db;


        public BrandRepository (IDataAccessLayer dataAccess)
        {
            _db = dataAccess.GetContext();
        }

        public Brand GetBrandByNameAndStoreId(string name, long storeId)
        {
            return _db.Brand.FirstOrDefault(b => b.Name.Equals(name) && b.StoreId.Equals(storeId));
        }

        public List<Brand> GetAllBrandByStoreId(long storeId)
        {
            return _db.Brand
                .Where(b => b.StoreId.Equals(storeId))
                .ToList();
        }

        public Brand SaveBrand(Brand brand)
        {
            Brand newBrand = _db.Brand.Add(brand);
            _db.SaveChanges();
            return newBrand;
        }

        public Brand UpdateBrand (Brand brand)
        {

            Brand updatedBrand = _db.Brand.Attach(brand);

            _db.Entry(brand).State = System.Data.Entity.EntityState.Modified;

            _db.SaveChanges();

            return updatedBrand;
        }
    }
}
