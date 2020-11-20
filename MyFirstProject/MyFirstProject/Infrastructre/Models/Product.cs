using MyFirstProject.Infrastructre.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Infrastructre.Models
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public CategoryType Category { get; set; }
        public int Count { get; set; }
        public string Code { get; set; }

    }
}
