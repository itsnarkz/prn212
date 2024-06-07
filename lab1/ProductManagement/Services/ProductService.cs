using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;

        public ProductService()
        {
            productRepository = new ProductRepository();
        }

        public void deleteProduct(Product product)
        {
            productRepository.DeleteProduct(product);
        }

        public List<Product> getAllProducts()
        {
            return productRepository.GetProducts();
        }

        public Product GetProductById(int id)
        {
            return productRepository.GetProductById(id);
        }

        public void saveProduct(Product product)
        {
            productRepository.SaveProduct(product);
        }

        public void updateProduct(Product product)
        {
            productRepository.UpdateProduct(product);
        }
    }
}
