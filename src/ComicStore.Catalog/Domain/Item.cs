using System;
using ComicStore.Core.DomainObjects;

namespace ComicStore.Catalog.Domain
{
    public class Item : Entity, IAggregateRoot
    {
        protected Item() { }

        public Item(string name, string description, decimal price, int stockQuantity, Guid categoryId)
        {
            Name = name;
            Description = description;
            Price = price;
            StockQuantity = stockQuantity;
            Active = true;
            CreatedAt = DateTime.Now;
            CategoryId = categoryId;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public string ImageUrl { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
    }
}