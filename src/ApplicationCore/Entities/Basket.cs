using System;
using System.Collections.Generic;
using System.Linq;

namespace ApplicationCore.Entities
{
    class Basket : BaseEntify
    {
        public string BuyerId { get; set; }
        private readonly List<BasketItem> _items = new List<BasketItem>();
        public IEnumerable<BasketItem> Items => _items;

        public void AddItem(int catalogItemId, decimal unitPrice, int quantity = 1)
        {
            if(!Items.Any(i => i.CatalogItemId == catalogItemId))
            {
                _items.Add(new BasketItem()
                {
                    CatalogItemId = catalogItemId,
                    Quantify = quantity,
                    UnitPrice = unitPrice
                });
                return;
            }
            var existingItem = Items.FirstOrDefault(i => i.CatalogItemId == catalogItemId);
            existingItem.Quantify += quantity;
        }
    }
}
