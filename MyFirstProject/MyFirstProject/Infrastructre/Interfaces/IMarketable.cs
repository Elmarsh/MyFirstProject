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
      int  GetProductBySale(int saleNumber, string productCode, int productQuantity);
      List<Sale> GetSales();
      List<Sale> GetSalesByDateRange(DateTime startDate, DateTime endDate);
      List<Sale> GetSalesByDate(DateTime Date);
      List<Sale> GetSalesByAmountRange(double stratAmount, double endAmount);
      Sale GetSalesBySaleNumber(int saleNumber);
      void AddProduct(Product product);
      void ChangeProduct(string productCode, string productName, int productQuantity, double amount, CategoryType category);
      List<Product> GetProducts(Product product);
      List<Product> GetItemsByCategoryName(CategoryType category);
      List<Product> GetItemsByAmountRange(double starAmount, double endAmount);
      List<Product> GetSearchByProductName(string productName);
        




        











    }
}
