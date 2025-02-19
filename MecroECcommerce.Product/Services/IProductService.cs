using MecroECcommerce.Product.Models;

namespace MecroECcommerce.Product.Services
{
    public interface IProductService
    {
        List<ProductModel> GetAllProducts();
        ProductModel GetProductById(int id);
    }
}
