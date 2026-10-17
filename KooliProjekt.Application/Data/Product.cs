using System;
using System.Collections.Generic;
using System.Text;

namespace KooliProjekt.Application.Data
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Photo { get; set; } = string.Empty;
        public decimal BasePrice { get; set; }
        public decimal DiscountPercentage { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;

        public IList<OrderLine> OrderLines { get; set; } = new List<OrderLine>();
    }
}
