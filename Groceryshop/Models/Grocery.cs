using System;
using System.Collections.Generic;

namespace Groceryshop.Models;

public partial class Grocery
{
    public int Id { get; set; }

    public string? Product { get; set; }

    public int? Price { get; set; }

    public int? Quantity { get; set; }

    public int? Total { get; set; }
}
