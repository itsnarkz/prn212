using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public partial class Category
    {
        public Category() {
            products = new HashSet<Product>();
        }

        public Category(int id, string name)
        {
            this.categoryId = id;
            this.categoryName = name;
        }

        public int categoryId { get; set; }
        public string categoryName { get; set; }
        public virtual ICollection<Product> products { get; set; }
    } 
}
