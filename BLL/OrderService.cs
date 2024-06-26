﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toomeet_Pos.BLL.Interfaces;
using Toomeet_Pos.DAL.Interfaces;
using Toomeet_Pos.DTOs;
using Toomeet_Pos.Entites.orders;

namespace Toomeet_Pos.BLL
{

   
    public class OrderService : IOrderService
    {

        private readonly IOrderRepository _orderRepository;
        private readonly IRoleService _roleService;

        public OrderService (IOrderRepository orderRepository, IRoleService roleService)
        {
            _orderRepository = orderRepository;
            _roleService = roleService;
        }

        public Order CreateOrder (SaveOrderDto dto)
        {
            if (!_roleService.CanCreateOrder(dto.Staff))
            {
                throw new Exception("Nhân viên " + dto.Staff.Name + " không có quyền tạo đơn hàng");
            }

            dto.Order.Staff = dto.Staff;
            dto.Order.Store = dto.Store;

            return _orderRepository.SaveOrder(dto.Order);
        }

        public List<Order> GetAllOrderByStoreId(long storeId)
        {
            return _orderRepository.GetAllOrderByStoreId(storeId);
        }

        public List<Order> GetAllOrderBetweenTime(long storeId, DateTime startTime, DateTime endTime)
        {
            return _orderRepository.GetAllBetweenTime(storeId, startTime, endTime);
        }

        public List<OrderDetail> SaveAllOrderDetails (List<OrderDetail> orderDetails)
        {
            return _orderRepository.SaveOrderDetails(orderDetails);
        }
    }
}
