using MyFirstProject.Infrastructre.Models;
using System;
using System.Collections.Generic;
using System.Text;
using MyFirstProject.Infrastructre.Enums;


namespace MyFirstProject.Infrastructre.Interfaces
{
   public interface IMarketable
    {
      List<Sale> Sales { get; }
      List<Product> Products { get; }
      List<SaleItem> SaleItems { get; }
      void AddSale(Sale sale);
      void RemoveSale(int saleNumber);
      int  RemoveProductBySale(int saleNumber, string productCode, int productQuantity);
      List<Sale> GetSales();
      List<Sale> GetSalesByDateRange(DateTime startDate, DateTime endDate);
      List<Sale> GetSalesByDate(DateTime Date);
      List<Sale> GetSalesByAmountRange(double stratAmount, double endAmount);
      List<Sale> GetSalesBySaleNumber(int saleNumber);
      void AddProduct(Product product);
      List<Product> ChangeProduct(string productCode);
      List<Product> GetProducts();
      void GetProductByCategoryName(CategoryType category);
      List<Product> GetProductByAmountRange(double starAmount, double endAmount);
      List<Product> GetSearchByProductName(string productName);
      void RemoveProduct(string ProductCode);
      List<SaleItem> ShowSaleItem(int saleNumber);

    }
}
