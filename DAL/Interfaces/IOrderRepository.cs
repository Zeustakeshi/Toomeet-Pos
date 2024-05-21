using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toomeet_Pos.Entites.orders;

namespace Toomeet_Pos.DAL.Interfaces
{
    public interface IOrderRepository
    {
        Order SaveOrder(Order order);

        List<Order> GetAllOrderByStoreId(long storeId);


        List<Order> GetAllBetweenTime(long storeId, DateTime startTime, DateTime endTime);


        List<OrderDetail> SaveOrderDetails(List<OrderDetail> orderDetails);
    }
}
