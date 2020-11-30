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
                    ProductCode = "AAA",
                    Category = CategoryType.Saat
                },

                new Product
                {
                    ProductName = "SmartTVSamsung",
                    ProductQuantity = 1,
                    ProductPrice = 800,
                    ProductCode = "BBB",
                    Category = CategoryType.Televizor

                },

            };


            _saleItems = new List<SaleItem>
            {
                new SaleItem
                {
                    SaleItemNumber = 1,
                    SaleCount = 1,
                    SaleProduct = _products.Find(p => p.ProductCode == "AAA")
                },
                 new SaleItem
                {
                    SaleItemNumber = 2,
                    SaleCount = 2,
                    SaleProduct = _products.Find(p => p.ProductCode == "BBB")
                }
            };
            _sales = new List<Sale>()
            {
                new Sale
                {
                    SaleAmount=46.50,
                    SaleDate=new DateTime(2011,05,26),
                    SaleNumber=1,
                    SaleItem=_saleItems.FindAll(si=>si.SaleCount==1)
                },
                new Sale
                {
                    SaleAmount=74.30,
                    SaleDate=DateTime.Now,
                    SaleNumber=2,
                    SaleItem=_saleItems.FindAll(si=>si.SaleCount==2)
                }
            };

        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public void AddSale(string productCode, int productQuantity)
        {
            List<SaleItem> saleItems = new List<SaleItem>();
            double amount = 0;
            var product = _products.Where(p => p.ProductCode == productCode).FirstOrDefault();
            var saleItem = new SaleItem();
            var code = productCode;

            bool check = _products.Exists(p => p.ProductCode == productCode);
            if (check == false)
            {
                Console.WriteLine("");
                Console.WriteLine("_____________ Daxil etdiyiniz koda görə məhsul tapılmadı _____________");
                Console.WriteLine("");
            }
            else
            {
                saleItem.SaleCount = productQuantity;
                if (product.ProductQuantity < productQuantity)
                {
                    Console.WriteLine("");
                    Console.WriteLine("_____________ Daxil etdiyiniz miqdarda məhsul yoxdur _____________");
                    Console.WriteLine("");
                }
                else
                {
                    product.ProductQuantity -= productQuantity;
                    saleItem.SaleProduct = product;
                    saleItem.SaleItemNumber = saleItems.Count + 1;
                    saleItems.Add(saleItem);
                    amount += productQuantity * saleItem.SaleProduct.ProductPrice;

                    var saleNumber = _sales.Count + 1;
                    var saleDate = DateTime.Now;
                    var sale = new Sale();

                    sale.SaleNumber = saleNumber;
                    sale.SaleAmount = amount;
                    sale.SaleDate = saleDate;

                    _sales.Add(sale);

                    Console.WriteLine("");
                    Console.WriteLine("-------------- Yeni Satış əlavə edildi --------------");
                    Console.WriteLine("");
                }
            } 

        }

        public List<Product> ChangeProduct(string productCode)
        {
            return _products.FindAll(p => p.ProductCode == productCode).ToList();
        }
            
      

        public void GetProductByCategoryName(CategoryType category)
        {

            List<Product> list = _products.FindAll(p => p.Category ==category).ToList();
            if (list.Count == 0)
            {
                Console.WriteLine("");
                Console.WriteLine("____________Bu kategoriyada məhsul yoxdur____________ ");
                Console.WriteLine("");
            }
            else
            {

                var table = new ConsoleTable("No", "Kategoriya", "Mehsul", "Sayi", "Qiymeti", "Mehsul kodu");
                int i = 1;
                foreach (var item in list)
                {
                    table.AddRow(i, item.Category, item.ProductName, item.ProductQuantity, item.ProductPrice, item.ProductCode);
                    i++;
                }
                table.Write();
            }

            //var table = new ConsoleTable("No", "Kategoriya", "Mehsul", "Sayi", "Qiymeti", "Mehsul kodu");
            //int i = 1;
            //foreach (var item in list)
            //{
            //    table.AddRow(i, item.Category, item.ProductName, item.ProductQuantity, item.ProductPrice, item.ProductCode);
            //    i++;
            //}
            //table.Write();

        }

        // satilan mehsulun geri qaytarilmasi
        public double RemoveProductBySale(int saleNumber, string productCode, int quantity) 
        {
            double amount = 0;
            var prolist = _products.ToList();
            var salelist = _sales.ToList();


            var sale = salelist.Find(r => r.SaleNumber == saleNumber);
             

            bool findproduct = prolist.Exists(r => r.ProductCode == productCode);
            if (findproduct == true)
            {
                var list = prolist.Find(r => r.ProductCode == productCode);
                if (sale.SaleAmount > list.ProductPrice * quantity)
                {
                    sale.SaleAmount -= list.ProductPrice * quantity;

                }
                else if ((sale.SaleAmount == list.ProductPrice * quantity))
                {
                    _sales.Remove(sale);
                }
            }
            return amount;

        }

        public List<Product> GetProducts()
        {
            return _products;
        }

        public List<Sale> GetSales()
        {
            return _sales;
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
 