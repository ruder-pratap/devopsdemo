using System;
using System.Collections.Generic;
using System.Text;

namespace ProductPortal.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int categoryId { get; set; }
        public virtual Category category { get; set; }

    }
}
