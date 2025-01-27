﻿using MediatR;

namespace BelezaWeb.Domain.Models
{
    public class Product : IRequest<string>
    {
        public int Sku { get; set; }
        public string Name { get; set; }
        public Inventory Inventory { get; set; }
        public bool IsMarketable { get; set; }
    }
}
