using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCartSample.Shared.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public double Price { get; set; }
    }
}
