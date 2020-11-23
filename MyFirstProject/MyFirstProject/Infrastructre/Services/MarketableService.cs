using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using MyFirstProject.Infrastructre.Models;
using MyFirstProject.Infrastructre.Enums;
using MyFirstProject.Infrastructre.Interfaces;


namespace MyFirstProject.Infrastructre.Services

{
    public class MarketableService : IMarketable
    {
        private  List<Sale> _sales;
        public List<Sale> sales => _sales;


        private  List<Product> _products;
        public List<Product> products => _products;



        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public void AddSale(Sale sale)
        {
            _sales.Add(sale);
        }

        public void ChangeProduct(string productCode, string productName, int productQuantity, double amount, CategoryType category)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductByAmountRange(double starAmount, double endAmount)
        {
           return _products.Where(p => p.ProductPrice > starAmount && p.ProductPrice < endAmount).ToList();
        }

        public List<Product> GetProductByCategoryName(CategoryType category)
        {
           return _products.Where(p => p.Category == category).ToList();
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
            return _sales.Where(s => s.SaleDate > startDate && s.SaleDate < endDate).ToList();
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
 