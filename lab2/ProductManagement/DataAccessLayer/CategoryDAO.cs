using BusinessObjects;
namespace DataAccessLayer
{
    public class CategoryDAO
    {

        public static List<Category> GetCategories()
        {
            using var db = new MyStoreContext();

            return db.Categories.ToList();
        }
    }
}
