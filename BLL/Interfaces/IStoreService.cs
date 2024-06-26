﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toomeet_Pos.DTOs;
using Toomeet_Pos.Entites;
using Toomeet_Pos.Entites.orders;

namespace Toomeet_Pos.BLL.Interfaces
{
    public interface IStoreService
    {
        Store RegisterStore(NewStoreDto dto);
        Store GetStoreByOwnerId (long ownerId);
        Store GetStoreById(long storeId);
        Store UpdateStore(Store updateStore);

        double GetRevenue(List<Order> orders);
        double GetCost(List<Order> orders);

    }
}
