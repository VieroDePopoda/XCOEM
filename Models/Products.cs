using System;

namespace XCOEM.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public string Composition { get; set; }
        public string Description { get; set; }
        public string Size { get; set; }
        public string Image { get; set; }
        public string Category { get; set; }

        public Products(int Id, string Title, int Price, string Composition, string Description, string Size, string Image, string Category)
        {
            this.Id = Id;
            this.Title = Title;
            this.Price = Price;
            this.Composition = Composition;
            this.Description = Description;
            this.Size = Size;
            this.Image = Image;
            this.Category = Category;
        }
    }
}