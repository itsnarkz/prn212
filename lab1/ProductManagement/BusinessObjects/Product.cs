using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public partial class Product
    {
        public Product() { }
        public Product(int id, string name, int catId, short units, decimal price) {
            this.id = id;
            this.name = name;
            this.categoryId = catId;
            this.unitsInStock = units;
            this.unitPrice = price;
        }

        public int id { get; set; }
        public string name { get; set; }
        public int? categoryId { get; set; }
        public short? unitsInStock { get; set; }
        public decimal? unitPrice { get; set;}
        public virtual Category Category { get; set; }
    }
}
