
using System;
using System.Collections.Generic;
using System.Text;

namespace KooliProjekt.Application.Data
{
    internal class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public IList<Product> Products { get; set; } = new List<Product>();
    }
}
