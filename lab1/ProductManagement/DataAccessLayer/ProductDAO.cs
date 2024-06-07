using BusinessObjects;

namespace DataAccessLayer
{
    public class ProductDAO
    {
        private static List<Product> listProducts;
        public ProductDAO()
        {
            Product chai = new Product(1, "Chai", 3, 12, 18);
            Product chang = new Product(2, "Chang", 1, 23, 19);
            Product aniseed = new Product(3, "Aniseed syrup", 2, 23, 10);
            listProducts = new List<Product> { chai, chang, aniseed };
        }
        public List<Product> GetProducts()
        {
            return listProducts;
        }
        public void SaveProduct(Product product)
        {
            listProducts.Add(product);
        }
        public void DeleteProduct(Product product)
        {
            foreach (var item in listProducts)
            {
                if (item.id == product.id)
                {

                    listProducts.Remove(item);
                    return;

                }
            }
        }
        public void UpdateProduct(Product product)
        {
            foreach (var item in listProducts)
            {
                if (item.id == product.id)
                {
                    item.id = product.id;
                    item.name = product.name;
                    item.unitPrice = product.unitPrice;
                    item.unitsInStock = product.unitsInStock;
                    item.categoryId = product.categoryId;
                }
            }
        }
        public Product? GetProductById(int id)
        {
            foreach (Product product in listProducts)
            {
                if (product.id == id)
                    return product;
            }
            return null;
        }
    }
}