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
        private readonly  List<Sale> _sales;
        public List<Sale> sales => _sales;

        private readonly List<Product> _products;
        public List<Product> products => _products;

        public MarketableService()
        {
            _products = new List<Product>();
        }

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
            return _sales.Where(s => s.SaleAmount > stratAmount && s.SaleAmount < endAmount).ToList();
        }

        public List<Sale> GetSalesByDate(DateTime Date)
        {
           return _sales.Where(s => s.SaleDate == Date).ToList();
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
           return _products.Where(p => p.ProductName.Contains(productName)).ToList();
        }

        double IMarketable.GetSalesByAmountRange(double stratAmount, double endAmount)
        {
            Product product = new Product();
            Sale sale = new Sale();

            sale.SaleAmount = product.ProductPrice * product.ProductQuantity;
            return _sales.Where(s => s.SaleAmount >= stratAmount && s.SaleAmount <= endAmount).Sum(s=>s.SaleAmount);
        }

        public List<Product> GetProductByAmountRange(double starAmount, double endAmount)
        {
            throw new NotImplementedException();
        }
    }
}
 