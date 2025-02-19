using MecroECcommerce.Product.Models;
using MecroECcommerce.Product.Persistence;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using AutoMapper; // You'll need this for IMapper

namespace MecroECcommerce.Product.Services
{
    public class ProductService : IProductService
    {
        private readonly ProductDBContext _productDBContext;
        private readonly IMapper _mapper;

        public ProductService(ProductDBContext productDBContext, IMapper mapper)
        {
            _productDBContext = productDBContext;
            _mapper = mapper;
        } 

        public List<ProductModel> GetAllProducts()
        {
            return _mapper.Map<List<ProductModel>>(_productDBContext.Products.ToList());
        }

        public ProductModel GetProductById(int id)
        {
            var product = _productDBContext.Products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return null;
            }
            return _mapper.Map<ProductModel>(product);
        }
    }
}