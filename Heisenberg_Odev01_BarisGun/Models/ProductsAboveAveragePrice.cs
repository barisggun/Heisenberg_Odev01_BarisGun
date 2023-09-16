using System;
using System.Collections.Generic;

namespace Heisenberg_Odev01_BarisGun.Models;

public partial class ProductsAboveAveragePrice
{
    public string ProductName { get; set; } = null!;

    public decimal? UnitPrice { get; set; }
}
