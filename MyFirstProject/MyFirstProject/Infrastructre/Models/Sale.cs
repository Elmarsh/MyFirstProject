﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Infrastructre.Models
{
   public class Sale
    {
        public int SaleNumber { get; set; }
        public double SaleAmount { get; set; }
        public List<SaleItem>  SaleItem { get; set; }
        public DateTime SaleDate { get; set; }

    }
}
