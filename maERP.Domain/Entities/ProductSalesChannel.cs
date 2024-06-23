﻿using maERP.Domain.Entities.Common;

namespace maERP.Domain.Entities;

public class ProductSalesChannel : BaseEntity, IBaseEntity
{
    public SalesChannel SalesChannel { get; set; } = new();
    public int SalesChannelId { get; set; }
    public int ProductId { get; set; } = new();
    public Product Product { get; set; } = new();
    public int RemoteProductId { get; set; }
    public decimal Price { get; set; }
}