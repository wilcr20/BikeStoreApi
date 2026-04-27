using System;
using System.Collections.Generic;
using BikeStoreApi.Entities.Sales;

namespace BikeStoreApi.Entities.Production;

public partial class Stock
{
    public int StoreId { get; set; }

    public int ProductId { get; set; }

    public int? Quantity { get; set; }

    public virtual Product Product { get; set; } = null!;

    public virtual Store Store { get; set; } = null!;
}
