using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toomeet_Pos.BLL.Interfaces;
using Toomeet_Pos.DAL.Interfaces;
using Toomeet_Pos.DTOs;
using Toomeet_Pos.Entites;
using static System.Windows.Forms.AxHost;

namespace Toomeet_Pos.BLL
{
    public class StoreService : IStoreService
    {
        private readonly IStoreRepository _storeRepository;
        private readonly IStaffService _staffService;

        public StoreService(
            IStoreRepository storeRepository,
            IStaffService staffService
        )
        {
            _storeRepository = storeRepository;
            _staffService = staffService;
        }

        public Store GetStoreById (long storeId)
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

        public Store UpdateStore (Store updateStore)
        {

            Store store = GetStoreById(updateStore.Id);

            if (store  == null)
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
    }
}
