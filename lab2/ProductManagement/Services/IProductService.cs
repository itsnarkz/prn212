using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IProductService
    {
        void saveProduct(Product product);
        void deleteProduct(Product product);    
        void updateProduct(Product product);
        List<Product> getAllProducts();
        Product GetProductById(int id);
    }
}
