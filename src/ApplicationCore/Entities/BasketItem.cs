using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities
{
    public class BasketItem : BaseEntify
    {
        public decimal UnitPrice { get; set; }
        public int Quantify { get; set; }
        public int CatalogItemId { get; set; }
    }
}
