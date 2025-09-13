using System;
namespace MyShop.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        // initialiering til tom streng for å unngå null
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        // spørsmålstegn gjør at den kan være null
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
    }
}