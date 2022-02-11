﻿using MediatR;
using BelezaWeb.Domain.Models;

namespace BelezaWeb.Domain.Requests
{
    public class UpdateProductRequest : IRequest<Response>
    {
        public int Sku { get; set; }
        public string Name { get; set; }
        public InventoryInput Inventory { get; set; }
    }
}