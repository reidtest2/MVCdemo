using System;
using System.Collections.Generic;

#nullable disable

namespace MVCdemo.Model.Models
{
    public partial class ProductsAboveAveragePrice
    {
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
    }
}
