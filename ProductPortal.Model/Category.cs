using System;
using System.Collections.Generic;
using System.Text;

namespace ProductPortal.Model
{
    public class Category
    {
        public Category()
        {
            products = new HashSet<Product>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal PriceRange { get; set; }
        public int DisplayOrder { get; set; }
        public virtual ICollection<Product> products { get; set; }
    }
}
