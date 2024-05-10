using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toomeet_Pos.DAL.Interfaces;
using Toomeet_Pos.Entites;

namespace Toomeet_Pos.DAL.Repositories
{
    public class StoreRepository : IStoreRepository
    {

        private readonly AppDBContext _db;

        public StoreRepository(IDataAccessLayer dbAccessLayer)
        {
            _db = dbAccessLayer.GetContext();
        }

        public Store GetStoreById(long storeId)
        {
            return _db.Store
                .Include(s => s.Owner)
                .FirstOrDefault(s => s.Id.Equals(storeId));
        }

        public Store GetStoreByName(string name)
        {
            return _db.Store.FirstOrDefault(s => s.Name.Equals(name));
        }

        public Store SaveStore(Store store)
        {
            Store newStore = _db.Store.Add(store);
            _db.SaveChanges();
            return newStore;
        }

        public Store UpdateStore(Store store)
        {
            if (!IsExistedStore(store.Id))
            {
                throw new Exception("Không tìm thấy cửa hàng " + store.Id + " ");
            }
            Store updatedStore = _db.Store.Attach(store);

            _db.Entry(store).State = EntityState.Modified;

            _db.SaveChanges();
            return updatedStore;
        }

        public bool IsExistedStore(long id)
        {
            return GetStoreById(id) != null;
        }

        public Store GetStoreByOwnerId(long ownerId)
        {
            return _db.Store
                .Include(s => s.Owner)
                .FirstOrDefault(s => s.Owner.Id == ownerId);

        }

        public void RemoveStore(Store store)
        {
            Store existedStore = GetStoreById(store.Id);
            _db.Store.Remove(existedStore);
            _db.SaveChanges();
        }

    }
}
