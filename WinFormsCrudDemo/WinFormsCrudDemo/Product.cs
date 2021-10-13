using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsCrudDemo
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }


        public override string ToString() => $"{Id:00000} - {Name}";


        public static List<Product> GetDemoData() => Enumerable.Range(1, 10)
            .Select(p => new Product { Id = p, Name = $"Ürün {p}", Description = $"Açıklama {p}", Price = p +10 })
            .ToList();
    }
}
