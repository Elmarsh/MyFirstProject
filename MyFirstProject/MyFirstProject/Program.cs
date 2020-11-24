﻿using System;
using System.Text;
using ConsoleTables;
using MyFirstProject.Infrastructre.Models;
using MyFirstProject.Infrastructre.Services;
using MyFirstProject.Infrastructre.Enums;
namespace MyFirstProject
{
    class Program
    {
        private static MarketableService _marketableService = new MarketableService();
        static void Main(string[] args)
        {
            
            Console.OutputEncoding = Encoding.UTF8;
            
            int selectInt;
            do
            {
                #region First Menu 
                Console.WriteLine("========Marketing programi========");
                Console.WriteLine("1. Məhsullar uzərində əməliyyat aparmaq");
                Console.WriteLine("2. Satislar uzərində əməliyyat aparmaq");
                Console.WriteLine("0. Sistemdən cixmaq");
                Console.WriteLine("Seçiminizi edin!");

                #endregion

                #region First Menu Selection

                string select = Console.ReadLine();
                while (!int.TryParse(select, out selectInt))
                {
                    Console.WriteLine("rəqəm daxil etməlisiniz");
                    select = Console.ReadLine();
                }
                #endregion

                #region First Menu Switch
                switch (selectInt)
                {
                    case 0:
                        continue;
                    case 1:
                        ShowProductsMenu();
                        break;
                    case 2:
                        ShowSalesMenu();
                        break;
                    default:
                        Console.WriteLine("----------------------------");
                        Console.WriteLine("siz yalniş secim etdiniz, 0-2 arasinda secim edə bilərsiniz");
                        Console.WriteLine("----------------------------");
                        break;
                }
                #endregion

            } while (selectInt != 0);
        }

        static void ShowProductsMenu()
        {
            int selectInt1;
            do
            {
                #region Second Menu 
               
                Console.WriteLine("1. Yeni məhsul əlavə et");
                Console.WriteLine("2. Məhsul uzərinde duzəliş et");
                Console.WriteLine("3. Məhsulu sil");
                Console.WriteLine("4. Butun məhsullari göstər");
                Console.WriteLine("5. Categoriyasina gorə məhsullari gostər");
                Console.WriteLine("6. Qiymət araligina gorə məhsullari gostər");
                Console.WriteLine("7. Mehsullar arasinda ada gorə axtaris et");
                Console.WriteLine("0. Əsas səhifə");

                Console.WriteLine("-------------------------------");
                #endregion

                #region Second Menu Selections
                string select = Console.ReadLine();
                while (!int.TryParse(select, out selectInt1))
                {
                    Console.WriteLine("rəqəm daxil etməlisiniz");
                    select = Console.ReadLine();
                }
                #endregion

                #region Second Menu Switch
                switch (selectInt1)
                {
                    case 0:
                        continue;
                    case 1:
                        ShowProductAdd();
                        break;
                    case 2:
                        Console.WriteLine("Edit Product");
                        break;
                    case 3:
                        Console.WriteLine("Remove Product");
                        break;
                    case 4:
                        ShowProductList();
                        break;
                    case 5:
                        Console.WriteLine("List  product By Catogory Name");
                        break;
                    case 6:
                        Console.WriteLine("List Product By Amount Range");
                        break;
                    case 7:
                        Console.WriteLine("Search By Product Name");
                        break;
                    default:

                        Console.WriteLine("----------------------------");
                        Console.WriteLine("siz yalniş secim etdiniz, 0-7 arasinda secim edə bilərsiniz");
                        Console.WriteLine("----------------------------");
                        break;

                       
                }
                #endregion

            } while (selectInt1 != 0);

        }

        static void ShowSalesMenu()
        {
            int selectInt2;
            do
            {
                #region Three Menu 
               
                Console.WriteLine("1. Yeni satis əlavə etmək");
                Console.WriteLine("2. Satisdaki hansisa mehsulun geri qaytarilmasi( satisdan cixarilmasi)");
                Console.WriteLine("3. Satisin silinməsi");
                Console.WriteLine("4. Butun satislarin ekrana cixarilmasi");
                Console.WriteLine("5. Verilən tarix araligina görə satişlarin göstərilməsi");
                Console.WriteLine("6. Verilən məbləğ araligina görə satişlarin göstərilməsi");
                Console.WriteLine("7. Verilmiş bir tarixdə olan satişlarin gosterilmesi");
                Console.WriteLine("8. Verilmiş nomrəyə əsasən həmin nomrəli satişin məlumatlarinin gostərilməsi");
                Console.WriteLine("0. Əsas Səhifə");
                #endregion

                #region Three Menu Selection
                string select = Console.ReadLine();
                while(!int.TryParse(select, out selectInt2))
                {
                    Console.WriteLine("Rəqəm daxil etmlisiniz");
                    select = Console.ReadLine();
                }
                #endregion

                #region Three Menu Switch
                switch (selectInt2)
                {
                    case 0:
                        continue;
                    case 1:
                        Console.WriteLine("Add Sale");
                        break;
                    case 2:
                        Console.WriteLine("Get Product By Sale");
                        break;
                    case 3:
                        Console.WriteLine("Remove Sale");
                        break;
                    case 4:
                        Console.WriteLine("List Sale");
                        break;
                    case 5:
                        Console.WriteLine("Sale By Date Range");
                        break;
                    case 6:
                        Console.WriteLine("Sale By Amount Range");
                        break;
                    case 7:
                        Console.WriteLine("Sale By Date");
                        break;
                    case 8:
                        Console.WriteLine("Search By Produc Name");
                        break;
                    default:
                        Console.WriteLine("----------------------------");
                        Console.WriteLine("siz yalniş seçim etdiniz, 0-8 arasinda seçim edə bilərsiniz");
                        Console.WriteLine("----------------------------");
                        break;
                }
                #endregion

            } while (selectInt2 != 0);
        } 

        static void ShowProductAdd()
        {
            Console.WriteLine("~~~~~~~~~~~~  Yeni Mehsul elave et  ~~~~~~~~~~~~");
            Product product = new Product();

            #region Product Category

            int selectInt;
            do
            {
                #region Product kategory Menu

                Console.WriteLine("~~~~~~~~kategoriya daxil edin~~~~~~~~");

                Console.WriteLine("1. Televizor");
                Console.WriteLine("2. Computer");
                Console.WriteLine("3. Phone");
                #endregion

                #region Product kategory Selection
                Console.WriteLine("");

                Console.WriteLine("Seçiminizi Edin:");

                string select = Console.ReadLine();
                while (!int.TryParse(select, out selectInt))
                {
                    Console.WriteLine("Reqem daxil etmelisiniz!");
                    select = Console.ReadLine();
                }
                #endregion

                #region Product kategory Switch

                switch (selectInt)
                {
                    case 1:
                        product.Category = CategoryType.Televizor;
                        break;
                    case 2:
                        product.Category = CategoryType.Computer;
                        break;
                    case 3:
                        product.Category = CategoryType.Phone;
                        break;
                    default:
                        Console.WriteLine("------------------------");
                        Console.WriteLine("Siz yalniş secim etdiniz, 1-3 araliğinda seçim etməlisiniz");
                        Console.WriteLine("------------------------");
                        break;
                }



            } while (selectInt==0);
            #endregion

            #endregion

            #region Product Name
            Console.WriteLine("Mehsul adi daxil edin");
            product.ProductName = Console.ReadLine();
            #endregion

            

            #region product Quantity
            Console.WriteLine("Mehsulun sayi daxil edin");
            string productQuantityInput = Console.ReadLine();
            
            int ProductQuantity;
            while(!int.TryParse(productQuantityInput, out ProductQuantity)) 
                {
                Console.WriteLine("Reqem daxil edin");
                productQuantityInput = Console.ReadLine();
            }
            product.ProductQuantity = ProductQuantity;
            #endregion

            #region Price
            Console.WriteLine("Mehsulun meblegi daxil edin");
            string productPriceInput = Console.ReadLine();

            double ProductPrice;
            while(!double.TryParse(productPriceInput, out ProductPrice))
            {
                Console.WriteLine("Satis meblegi daxil edin");
                productPriceInput = Console.ReadLine();
            }
            product.ProductPrice = ProductPrice;
            #endregion

            #region Product code
            Console.WriteLine("Mehsulun kodu daxil edin");
            product.ProductCode = Console.ReadLine();
           
            #endregion
        }



        static void ShowProductList()
        {
            Console.WriteLine("~~~~~~~~~~~~  Movcud Mehsullar  ~~~~~~~~~~~~");
            var table = new ConsoleTable("No", "Kategoriya", "Mehsul", "Sayi", "Qiymeti", "Mehsul kodu");
            int i = 1;
            foreach (var item in _marketableService.products)
            {
                table.AddRow(i, item.Category, item.ProductName, item.ProductQuantity, item.ProductPrice, item.ProductCode);
            }
            table.Write();
        }
    }
}
