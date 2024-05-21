using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Toomeet_Pos.UI.Validations
{

    public interface IProductValidate
    {
        ValidateResult IsValidName(string name);
        ValidateResult IsValidSkuCode (string skuCode);
        ValidateResult IsValidBarcode (string barcode);

        ValidateResult IsValidUnitOfMeasure(string  unitOfMeasure); 

        ValidateResult IsValidWeight (double weight);

        ValidateResult IsValidPrice(double price);

        ValidateResult IsValidInventoryQuantity(int quantity);

        ValidateResult IsValidDescription (string description);
    }
    public class ProductValidate : BaseValidation, IProductValidate
    {
        public ValidateResult IsValidBarcode(string barcode)
        {
            if (IsEmptyString(barcode)) return ValidateResult.Error("Barcode không được bỏ trống");

            if (barcode.Length != 13) return ValidateResult.Error("Barcode không hợp lệ");

            if (barcode.StartsWith("0")) return ValidateResult.Error("Barcode không được bắt đầu bằng kí tự 0");

            return ValidateResult.Success();
        }

        public ValidateResult IsValidDescription(string description)
        {
            if (description.Length <= 0) return ValidateResult.Success();
            if (description.Length <= 5) return ValidateResult.Error("mô tả quả ngắn");
            return ValidateResult.Success();
        }

        public ValidateResult IsValidInventoryQuantity(int quantity)
        {
            if (quantity < 0) return ValidateResult.Error("Số lượng kho không được âm");
            return ValidateResult.Success();
        }

        public ValidateResult IsValidName(string name)
        {
            if (IsEmptyString(name)) return ValidateResult.Error("Tên sản phẩm không được bỏ trống");

            if (name.Length < 8) ValidateResult.Error("Tên sản phẩm quá ngắn");

            if (name.Length > 500) ValidateResult.Error("Tên sản phẩm quá dài");

            return ValidateResult.Success();
        }

        public ValidateResult IsValidPrice(double price)
        {
            if (price < 0) return ValidateResult.Error("Giá không được âm");
            if (price > 1000000000) return ValidateResult.Error("Hệ thống không xử lý sản phẩm giá quá cao");

            return ValidateResult.Success();
        }

        public ValidateResult IsValidSkuCode(string skuCode)
        {
            if (IsEmptyString(skuCode)) return ValidateResult.Error("Skucode không được bỏ trống");

            if (skuCode.Length < 8) ValidateResult.Error("Skucode quá ngắn");

            if (skuCode.Length > 500) ValidateResult.Error("Skucode phẩm quá dài");

            return ValidateResult.Success();
        }

        public ValidateResult IsValidUnitOfMeasure(string unitOfMeasure)
        {
            if (IsEmptyString(unitOfMeasure)) return ValidateResult.Error("Đơn vị tính không được bỏ trống");
            return ValidateResult.Success();
        }

        public ValidateResult IsValidWeight(double weight)
        {
            if (weight < 10) return ValidateResult.Error("Cân năng phải trên 10g");

            return ValidateResult.Success();
        }
    }
}
