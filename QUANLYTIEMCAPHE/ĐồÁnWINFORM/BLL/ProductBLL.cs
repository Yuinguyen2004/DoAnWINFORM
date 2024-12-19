using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    using System.Collections.Generic;
    using DAL.Model;
    using DAL;

    public class ProductBLL
    {
        private ProductDAL productDAL = new ProductDAL();

        public List<Product> GetAllProducts()
        {
            return productDAL.GetAllProducts();
        }

        public void AddProduct(Product product)
        {
            if (string.IsNullOrEmpty(product.ProductName) || product.Price <= 0)
                throw new System.Exception("Giá sản phẩm phải lớn hơn 0.");
            productDAL.AddProduct(product);
        }

        public void UpdateProduct(Product product)
        {
            if (string.IsNullOrEmpty(product.ProductName) || product.Price <= 0)
                throw new System.Exception("Giá sản phẩm phải lớn hơn 0.");
            productDAL.UpdateProduct(product);
        }

        public void DeleteProduct(string productId)
        {
            // Logic kiểm tra nếu sản phẩm đang có trong OrderDetail, không cho phép xóa.
            productDAL.DeleteProduct(productId);
        }
    }

}
