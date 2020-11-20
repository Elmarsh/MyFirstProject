using MyFirstProject.Infrastructre.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace MyFirstProject.Infrastructre.Interfaces
{
   public interface IMarketable
    {
      List<Sale> sales { get; }
      List<Product> products { get; }
        

    }
}
