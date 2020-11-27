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
      void RemoveSale(int saleNumber);
      int  GetProductBySale(int saleNumber, string productCode, int productQuantity);
      List<Sale> GetSales();
      List<Sale> GetSalesByDateRange(DateTime startDate, DateTime endDate);
      List<Sale> GetSalesByDate(DateTime Date);
      List<Sale> GetSalesByAmountRange(double stratAmount, double endAmount);
      Sale GetSalesBySaleNumber(int saleNumber);
      void AddProduct(Product product);
      List<Product> ChangeProduct(string productCode);
      List<Product> GetProducts(Product product);
      void GetProductByCategoryName(CategoryType category);
      List<Product> GetProductByAmountRange(double starAmount, double endAmount);
      List<Product> GetSearchByProductName(string productName);
      void RemoveProduct(string ProductCode);

    }
}
