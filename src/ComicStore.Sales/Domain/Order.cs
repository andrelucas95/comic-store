using System;
using System.Collections.Generic;
using ComicStore.Core.DomainObjects;

namespace ComicStore.Sales.Domain
{
    public class Order : Entity, IAggregateRoot
    {
        public Order() { }

        public Order(string userId)
        {
            UserId = userId;
            CreatedAt = DateTime.Now;
            _items = new List<OrderItem>();
            Status = OrderStatus.Pending;
        }

        public string UserId { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreatedAt { get; set; }
        public OrderStatus Status { get; set; }

        private readonly List<OrderItem> _items;
        public IReadOnlyCollection<OrderItem> Items => _items;
    }
}