using System;

namespace Products
{
    /// <summary>
    /// Creates a base class for products
    /// </summary>

    public class Product
    {
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string? Description { get; set; }
    }
}

