using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using MyFirstProject.Infrastructre.Models;
using MyFirstProject.Infrastructre.Enums;
using MyFirstProject.Infrastructre.Interfaces;
using ConsoleTables;


namespace MyFirstProject.Infrastructre.Services

{

    public class MarketableService : IMarketable  
    {
        private readonly List<Sale> _sales;
        public List<Sale> Sales => _sales;

        private readonly List<Product> _products;
        public List<Product> Products => _products;

        private readonly List<SaleItem> _saleItems;
        public List<SaleItem> SaleItems => _saleItems;

        public MarketableService()
        {
            _products = new List<Product>
            {
                new Product
                {
                    ProductName = "Tissot",
                    ProductQuantity = 2,
                    ProductPrice = 200,
                    ProductCode = "0002",
                    Category = CategoryType.Saat
                },

                new Product
                {
                    ProductName = "SmartTVSamsung",
                    ProductQuantity = 1,
                    ProductPrice = 800,
                    ProductCode = "0003",
                    Category = CategoryType.Televizor

                }
            };


            _saleItems = new List<SaleItem>
            {
                new SaleItem
                {
                    SaleItemNumber = 1,
                    SaleCount = 1,
                    SaleProduct = _products.Find(p => p.ProductCode == "0003")
                },
                 new SaleItem
                {
                    SaleItemNumber = 3,
                    SaleCount = 2,
                    SaleProduct = _products.Find(p => p.ProductCode == "0002")
                }
            };
            _sales = new List<Sale>()
            {
                new Sale
                {
                    SaleAmount=12,
                    SaleDate=new DateTime(2011,05,26),
                    SaleNumber=1,
                    SaleItem=_saleItems.FindAll(s=>s.SaleCount==1)
                },
                                new Sale
                {
                    SaleAmount=24,
                    SaleDate=DateTime.Now,
                    SaleNumber=2,
                    SaleItem=_saleItems.FindAll(s=>s.SaleCount==2)
                }
            };

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


            var table = new ConsoleTable("No", "Kategoriya", "Mehsul", "Sayi", "Qiymeti", "Mehsul kodu");
            int i = 1;
            foreach (var item in list)
            {
                table.AddRow(i, item.Category, item.ProductName, item.ProductQuantity, item.ProductPrice, item.ProductCode);
                i++;
            }
            table.Write();

        }

        public int RemoveProductBySale(int saleNumber, string productCode, int productQuantity)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProducts()
        {
            return _products;
        }

        public List<Sale> GetSales()
        {
            throw new NotImplementedException();
        }
        
        public List<Sale> GetSalesByAmountRange(double startAmount, double endAmount)
        {
            return _sales.FindAll(s => s.SaleAmount > startAmount && s.SaleAmount < endAmount).ToList();
           
        }

        public List<Sale> GetSalesByDate(DateTime Date)
        {
           return _sales.Where(s => s.SaleDate == Date).ToList();
        }

        public List<Sale> GetSalesByDateRange(DateTime startDate, DateTime endDate)
        {
            return _sales.Where(s => s.SaleDate > startDate && s.SaleDate < endDate).ToList();


        }

        public List<Sale> GetSalesBySaleNumber(int saleNumber)
        {
           return _sales.Where(s => s.SaleNumber == saleNumber).ToList();
        }

        public List<Product> GetSearchByProductName(string productName)
        {

             return _products.FindAll(p => p.ProductName.Contains(productName)).ToList();
           
        }

      
        public List<Product> GetProductByAmountRange(double starAmount, double endAmount)
        {
            return _products.FindAll(p => p.ProductPrice > starAmount && p.ProductPrice < endAmount).ToList();
        }

        public void RemoveProduct(string productCode)
        {
            var resultlist = _products.ToList();
            var itemRemove = resultlist.Single(r => r.ProductCode == productCode);
            _products.Remove(itemRemove);
        }

        public void RemoveSale(int saleNumber)
        {
           Sale sale= _sales.Find(s => s.SaleNumber == saleNumber);
            _sales.Remove(sale);
        }

        public List<SaleItem> ShowSaleItem(int saleNumber)
        {
            return _sales.Find(s => s.SaleNumber == saleNumber).SaleItem.ToList();
        }
    }
}
 