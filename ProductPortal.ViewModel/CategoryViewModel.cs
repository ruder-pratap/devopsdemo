using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProductPortal.ViewModel
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal PriceRange { get; set; }
        public int DisplayOrder { get; set; }
        public int CategoryId { get; set; }
        public  ICollection<ProductViewModel> products { get; set; }
    }
}
