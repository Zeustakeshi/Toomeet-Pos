using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toomeet_Pos.DAL;
using Toomeet_Pos.DAL.Interfaces;
using Toomeet_Pos.Entites.orders;

namespace Toomeet_Pos.BLL
{
    public interface IOrderRepository
    {

        Order SaveOrder(Order order);

        List<Order> GetAllOrderByStoreId(long storeId);

    }


    public class OrderRepository : IOrderRepository
    {

        private readonly AppDBContext _db;

        public OrderRepository (IDataAccessLayer dataAccess)
        {
            _db = dataAccess.GetContext();
        }


        public List<Order> GetAllOrderByStoreId(long storeId)
        {
            return _db.Order
                .Include(o => o.Staff)
                .Include(o => o.Store)
                .Where(o => o.Store.Id.Equals(storeId))
                .ToList();

        }

        public Order SaveOrder(Order order)
        {
            Order newOrder =  _db.Order.Add(order);
            _db.Entry(order).State = System.Data.Entity.EntityState.Added;
            _db.SaveChanges();
            return newOrder;
        }
    }
}
