using System;
using System.Collections.Generic;

namespace ProductEf.Models
{
    public partial class Products
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Image { get; set; }
    }
}
