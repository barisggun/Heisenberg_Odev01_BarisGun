using System;
using System.Collections.Generic;

namespace Heisenberg_Odev01_BarisGun.Models;

public partial class SummaryOfSalesByQuarter
{
    public DateTime? ShippedDate { get; set; }

    public int OrderId { get; set; }

    public decimal? Subtotal { get; set; }
}
