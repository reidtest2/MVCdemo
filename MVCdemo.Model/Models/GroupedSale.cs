using System;
using System.Collections.Generic;

#nullable disable

namespace MVCdemo.Model.Models
{
    public partial class GroupedSale
    {
        public string CategoryName { get; set; }
        public int? SalesYear { get; set; }
        public double? SalesAmount { get; set; }
    }
}
