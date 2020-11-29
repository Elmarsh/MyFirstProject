using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Infrastructre.Exceptions
{
     public class ProductQuantityExcept: Exception
    {
        public ProductQuantityExcept(string message) : base(message) { }

    }
}
