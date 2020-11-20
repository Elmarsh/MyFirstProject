using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Infrastructre.Models
{
    public class SaleItem
    {
        public int SaleItemNumber { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
