using MyFirstProject.Infrastructre.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Infrastructre.Models
{
    public class Product
    {
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public CategoryType Category { get; set; }
        public int ProductQuantity { get; set; }
        public string ProductCode { get; set; }

    }
}
