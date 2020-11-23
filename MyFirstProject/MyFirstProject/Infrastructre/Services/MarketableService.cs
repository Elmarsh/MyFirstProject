using System;
using MyFirstProject.Infrastructre.Interfaces;
using System.Collections.Generic;
using System.Text;
using MyFirstProject.Infrastructre.Models;
using MyFirstProject.Infrastructre.Enums;

namespace MyFirstProject.Infrastructre.Services
{
    public class MarketableService : IMarketable
    {
        public List<Sale> sales => throw new NotImplementedException();

        public List<Product> products => throw new NotImplementedException();

        public void AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void AddSale(Sale sale)
        {
            throw new NotImplementedException();
        }

        public void ChangeProduct(string productCode, string productName, int productQuantity, double amount, CategoryType category)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductByAmountRange(double starAmount, double endAmount)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductByCategoryName(CategoryType category)
        {
            throw new NotImplementedException();
        }

        public int GetProductBySale(int saleNumber, string productCode, int productQuantity)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProducts(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Sale> GetSales()
        {
            throw new NotImplementedException();
        }

        public List<Sale> GetSalesByAmountRange(double stratAmount, double endAmount)
        {
            throw new NotImplementedException();
        }

        public List<Sale> GetSalesByDate(DateTime Date)
        {
            throw new NotImplementedException();
        }

        public List<Sale> GetSalesByDateRange(DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }

        public Sale GetSalesBySaleNumber(int saleNumber)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetSearchByProductName(string productName)
        {
            throw new NotImplementedException();
        } 
    }
}
 