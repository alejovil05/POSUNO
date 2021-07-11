using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POSUNO.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public string PriceString => $"{Price:C2}";

        public float Stock { get; set; }

        public string StockString => $"{Stock:N2}";

        public bool IsActive { get; set; }

        public User User { get; set; }
    }
}
