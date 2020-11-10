using System;
using ComicStore.Core.DomainObjects;

namespace ComicStore.Sales.Domain
{
    public class OrderItem : Entity
    {
        public OrderItem() { }

        public OrderItem(Guid itemId, string itemName, int quantity, decimal unitPrice)
        {
            ItemId = itemId;
            ItemName = ItemName;
            Quantity = quantity;
            UnitPrice = unitPrice;
        }

        public Guid OrderId { get; set; }
        public Order Order { get; set; }
        public Guid ItemId { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

    }
}