using BusinessObjects;

namespace DataAccessLayer
{
    public class ProductDAO
    {
        private static List<Product> listProducts;
        public ProductDAO()
        {
      
        }
        public List<Product> GetProducts()
        {
            using var db = new MyStoreContext();
            return db.Products.ToList();
        }
        public void SaveProduct(Product product)
        {
            using var db = new MyStoreContext();
            db.Products.Add(product);
            db.SaveChanges();
        }
        public void DeleteProduct(Product product)
        {
            using var db = new MyStoreContext();
            Product p = db.Products.FirstOrDefault(x => x.ProductId == product.ProductId);
            db.Products.Remove(p);
            db.SaveChanges();
            return;
        }
        public void UpdateProduct(Product product)
        {
            using var db = new MyStoreContext();
            db.Entry<Product>(product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }
        public Product? GetProductById(int id)
        {
            using var db = new MyStoreContext();
            return db.Products.FirstOrDefault(c => c.ProductId == id);
        }
    }
}