using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Infrastructre.Models
{
   public class Sale
    {
        public int SaleNumber { get; set; }
        public double Price { get; set; }
        public List<SaleItem>  SaleItem { get; set; }

        public DateTime Date { get; set; }
    }
}
