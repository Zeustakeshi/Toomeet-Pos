using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toomeet_Pos.Entites;

namespace Toomeet_Pos.DAL.Interfaces
{
    public interface IStoreRepository
    {
        Store GetStoreById(long storeId);

        Store GetStoreByName(string name);

        Store GetStoreByOwnerId(long ownerId);

        Store SaveStore(Store store);

        Store UpdateStore(Store store);

        bool IsExistedStore(long id);

        void RemoveStore(Store store);
    }
}
