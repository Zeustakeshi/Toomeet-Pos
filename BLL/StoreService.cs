using DocumentFormat.OpenXml.Bibliography;
using System;
using System.Collections.Generic;
using System.Linq;
using Toomeet_Pos.BLL.Interfaces;
using Toomeet_Pos.DAL.Interfaces;
using Toomeet_Pos.DTOs;
using Toomeet_Pos.Entites;
using Toomeet_Pos.Entites.orders;
using Toomeet_Pos.Uitls;


namespace Toomeet_Pos.BLL
{
    public class StoreService : IStoreService
    {
        private readonly IStoreRepository _storeRepository;
        private readonly IStaffService _staffService;
        private readonly IOrderService _orderService;

        public StoreService(
            IStoreRepository storeRepository,
            IStaffService staffService
            ,
            IOrderService orderService

        )
        {
            _storeRepository = storeRepository;
            _staffService = staffService;
            _orderService = orderService;
        }

        public Store GetStoreById(long storeId)
        {
            return _storeRepository.GetStoreById(storeId);
        }

        public Store GetStoreByOwnerId(long ownerId)
        {
            return _storeRepository.GetStoreByOwnerId(ownerId);
        }

        public Store RegisterStore(NewStoreDto dto)
        {

            if (_storeRepository.GetStoreByName(dto.StoreName) != null)
            {
                throw new Exception("Tên cửa hành đã tồn tại");
            }

            if (
                _staffService.IsExistedStaffByPhone(dto.OwnerPhone)
            )
            {
                throw new Exception("Thông tin chủ cửu hàng đã tồn tại");
            }


            /// Logic Create Store 
            Store newStore = _storeRepository.SaveStore(new Store()
            {
                Name = dto.StoreName,
            });

            try
            {
                Staff owner = _staffService.RegisterStoreOwner(dto, newStore);
                newStore.Owner = owner;
                return _storeRepository.UpdateStore(newStore);
            }
            catch (Exception ex)
            {
                _storeRepository.RemoveStore(newStore);
                throw new Exception("Tạo cửa hàng thất bại");
            }

        }

        public Store UpdateStore(Store updateStore)
        {

            Store store = GetStoreById(updateStore.Id);

            if (store == null)
            {
                throw new Exception("Không tìm thấy cửa hàng.");
            }

            if (
                 store.Owner.Phone != null &&
                updateStore.Owner.Phone != null &&
                !store.Owner.Phone.Trim().Equals(updateStore.Owner.Phone.Trim()) &&
                _staffService.IsExistedStaffByPhone(updateStore.Owner.Phone.Trim())
            )
            {
                throw new Exception("Số điện thoại đã được sử dụng");

            }

            if (

              store.Owner.Email != null &&
                updateStore.Owner.Email != null &&
                store.Owner.Email.Trim().Length > 0 &&
                !store.Owner.Email.Trim().Equals(updateStore.Owner.Email.Trim()) &&
             _staffService.IsExistedStaffByEmail(updateStore.Owner.Email.Trim())
            )
            {
                throw new Exception("Địa chỉ email đã được sử dụng");

            }


            return _storeRepository.UpdateStore(updateStore);
        }

        public double GetRevenue(List<Order> orders)
        {
            return orders.Sum(o => o?.OrderDetails?.Sum(od => od.Total) ?? 0);
        }

        public double GetCost(List<Order> orders)
        {
            double cost = 0;

            foreach (Order order in orders)
            {
                cost += order?.OrderDetails?.Sum(od => od?.Product?.PurchasePrice * od?.Quantity ?? 0) ?? 0;
            }

            return cost;
        }
    }
}
