using System;

namespace XCOEM.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Composition { get; set; }
        public string Description { get; set; }
        public string Size { get; set; }
    }
}