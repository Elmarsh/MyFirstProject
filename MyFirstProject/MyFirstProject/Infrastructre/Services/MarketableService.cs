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
            _products.Add(new Product
            {
                ProductName = "Tissot",
                ProductQuantity = 2,
                ProductPrice = 200,
                ProductCode = "0002",
                Category = CategoryType.Saat
            });

            _products.Add(new Product
            {
                ProductName = "SmartTVSamsung",
                ProductQuantity = 1,
                ProductPrice = 800,
                ProductCode = "0003",
                Category = CategoryType.Televizor

            });


            _sales = new List<Sale>();
            _sales.Add(new Sale
            {
                SaleNumber = 1,
                SaleAmount = 12.5,
                SaleDate = new DateTime(2020,09,25),
                SaleItem=new List<SaleItem>()
                {
                    new SaleItem
                    {
                       SaleItemNumber = 1,
                       SaleCount=2,
                       SaleProduct=new Product
                       {
                            ProductName = "LenovoIdeaPadS150",
                            ProductQuantity = 1,
                            ProductPrice = 1500,
                            ProductCode = "0077",
                            Category = CategoryType.Computer
                       }
                    }
                }
                
            });

            _sales.Add(new Sale
            {
                SaleNumber = 2,
                SaleAmount = 24.5,
                SaleDate = new DateTime(2020, 11, 25),
                SaleItem = new List<SaleItem>()
                {
                    new SaleItem
                    {
                       SaleItemNumber =4 ,
                       SaleCount=5,
                       SaleProduct=new Product
                       {
                            ProductName = "Samsung Galaxy S20 FE 5G",
                            ProductQuantity = 1,
                            ProductPrice = 700,
                            ProductCode = "0088",
                            Category = CategoryType.Phone
                       }
                    }
                }
            });

        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public void AddSale(Sale sale)
        {
            _sales.Add(sale);
        }

        public List<Product> ChangeProduct(string productCode)
        {
            return _products.FindAll(p => p.ProductCode == productCode).ToList();
        }

      

        public void GetProductByCategoryName(CategoryType category)
        {

            List<Product> list = _products.FindAll(p => p.Category ==category).ToList();

            foreach (var item in list)
            {
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("adı: " + item.ProductName);
                Console.WriteLine("Kategoriyasi: " + item.Category);
                Console.WriteLine("Sayi: " + item.ProductQuantity);
                Console.WriteLine("Kodu: " + item.ProductCode);
                Console.WriteLine("Qiyməti: " + item.ProductPrice);
            }
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

             return _products.FindAll(p => p.ProductName.Contains(productName)).ToList();
           
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
            return _products.Where(p => p.ProductPrice > starAmount && p.ProductPrice < endAmount).ToList();
        }

        public void RemoveProduct(string productCode)
        {
            var resultlist = _products.ToList();
            var itemRemove = resultlist.Single(r => r.ProductCode == productCode);
            _products.Remove(itemRemove);
        }
    }
}
 