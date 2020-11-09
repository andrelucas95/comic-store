using System;
using System.Collections.Generic;
using ComicStore.Core.DomainObjects;

namespace ComicStore.Catalog.Domain
{
    public class Category : Entity
    {
        protected Category() { }

        public Category(string name)
        {
            Name = name;
            Active = true;
            CreatedAt = DateTime.Now;
        }

        public string Name { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedAt { get; set; }
        public ICollection<Item> Items { get; set; }
    }
}