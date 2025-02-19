using MecroECcommerce.Product.Models;
using MecroECcommerce.Product.Persistence;
    public class ProductMapper:AutoMapper.Profile
    {
        public ProductMapper()
        {
            CreateMap<Product, ProductModel>();
        }
    }

