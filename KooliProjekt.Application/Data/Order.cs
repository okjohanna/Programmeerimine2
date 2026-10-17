using System;
using System.Collections.Generic;
using System.Text;

namespace KooliProjekt.Application.Data
{
    internal class Order
    {
        public int Id { get; set; }
        public string Status { get; set; } = string.Empty;

        public IList<OrderLine> OrderLines { get; set; } = new List<OrderLine>();
    }
}
