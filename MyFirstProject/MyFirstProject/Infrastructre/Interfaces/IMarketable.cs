using MyFirstProject.Infrastructre.Models;
using System;
using System.Collections.Generic;
using System.Text;
using MyFirstProject.Infrastructre.Enums;


namespace MyFirstProject.Infrastructre.Interfaces
{
   public interface IMarketable
    {
      List<Sale> sales { get; }
      List<Product> products { get; }


      void AddSale(Sale sale);
      void  ItemBack(int SaleNumber , int SaleItemNumber);
      void SaleBack (int SaleNumber);
      void BackSalesByDateRange(DateTime startDate, DateTime endDate);
      void BackSalesByDate(DateTime Date);
      void BackSalesByAmountRange(double stratAmount, double endAmount);
      void BackSalesBySaleNumber(int saleNumber);
      void AddProduct(Product product);
      void ChangeProduct(int productCode);
      void BackItemsByCategoryName(CategoryType category);
      void BackItemsByAmountRange(double starAmount, double endAmount);
      void BackItemsByProductName(int productName); 




        











    }
}
