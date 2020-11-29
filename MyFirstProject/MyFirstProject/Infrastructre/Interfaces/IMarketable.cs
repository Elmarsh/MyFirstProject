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

        #region Sale Methods
      void AddSale(string productCode, int productQuantity);
      void RemoveSale(int saleNumber);
      double  RemoveProductBySale(int saleNumber, string productCode , int quantity);
      List<Sale> GetSales();
      List<Sale> GetSalesByDateRange(DateTime startDate, DateTime endDate);
      List<Sale> GetSalesByDate(DateTime Date);
      List<Sale> GetSalesByAmountRange(double stratAmount, double endAmount);
      List<Sale> GetSalesBySaleNumber(int saleNumber);
        #endregion

      #region Product Methods
      void AddProduct(Product product);
      List<Product> ChangeProduct(string productCode);
      List<Product> GetProducts();
      void GetProductByCategoryName(CategoryType category);
      List<Product> GetProductByAmountRange(double starAmount, double endAmount);
      List<Product> GetSearchByProductName(string productName);
      void RemoveProduct(string ProductCode);
      List<SaleItem> ShowSaleItem(int saleNumber);
        #endregion
    }
}
