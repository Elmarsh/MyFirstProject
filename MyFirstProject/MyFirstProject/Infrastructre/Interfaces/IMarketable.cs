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
      void  GetProductBySale(string Name , int Count);
      List<Sale> GetSales();
      void GetSalesByDateRange(DateTime startDate, DateTime endDate);
      void GetSalesByDate(DateTime Date);
      void GetSalesByAmountRange(double stratAmount, double endAmount);
      void GetSalesBySaleNumber(int saleNumber);
      void AddProduct(Product product);
      void ChangeProduct(int productCode);
      void GetItemsByCategoryName(CategoryType category);
      void GetItemsByAmountRange(double starAmount, double endAmount);
      void GetItemsByProductName(int productName);  




        











    }
}
