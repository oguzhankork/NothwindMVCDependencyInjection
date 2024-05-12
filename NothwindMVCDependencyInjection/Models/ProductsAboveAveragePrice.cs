using System;
using System.Collections.Generic;

namespace NothwindMVCDependencyInjection.Models;

public partial class ProductsAboveAveragePrice
{
    public string ProductName { get; set; } = null!;

    public decimal? UnitPrice { get; set; }
}
