using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toomeet_Pos.DTOs;
using Toomeet_Pos.Entites.orders;

namespace Toomeet_Pos.BLL.Interfaces
{
    public interface IOrderService
    {
        Order CreateOrder(SaveOrderDto dto);

        List<Order> GetAllOrderByStoreId(long storeId);

        List<Order> GetAllOrderBetweenTime(long storeId, DateTime startTime, DateTime endTime);

        List<OrderDetail> SaveAllOrderDetails(List<OrderDetail> orderDetails);
    }
}
