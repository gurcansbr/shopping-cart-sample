using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCartSample.Shared.Models
{
    public class Cart
    {
        public List<CartLine> Products { get; set; }
    }

    public class CartLine
    {
        public int CartLineId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
