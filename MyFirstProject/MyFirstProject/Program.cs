using ConsoleTables;
using MyFirstProject.Infrastructre.Enums;
using MyFirstProject.Infrastructre.Models;
using MyFirstProject.Infrastructre.Services;
using System;
using System.Collections.Generic;
using System.Text;

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
                        ShowProductChange();
                        break;
                    case 3:
                        ShowRemoveProduct();
                        break;
                    case 4:
                        ShowProductList();
                        break;
                    case 5:
                        ShowProductCategoryName();
                        break;
                    case 6:
                        ShowProductAmountRange();
                        break;
                    case 7:
                        ShowSearchProductName();
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
                while (!int.TryParse(select, out selectInt2))
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
                        ShowRemoveSale();
                        break;
                    case 4:
                        ShowListSale();
                        break;
                    case 5:
                        ShowSalesByDataRange();
                        break;
                    case 6:
                        ShowSalesByAmountRange();
                        break;
                    case 7:
                        ShowSalesByDate();
                        break;
                    case 8:
                        ShowSalesBySaleNumber();
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
        #region Product Methods
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
                Console.WriteLine("4. Saat");
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
                    
                    case 4:
                        product.Category = CategoryType.Saat;
                        break;
                    default:
                        Console.WriteLine("------------------------");
                        Console.WriteLine("Siz yalniş secim etdiniz, 1-3 araliğinda seçim etməlisiniz");
                        Console.WriteLine("------------------------");
                        break;
                }



            } while (selectInt == 0);
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
            while (!int.TryParse(productQuantityInput, out ProductQuantity))
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
            while (!double.TryParse(productPriceInput, out ProductPrice))
            {
                Console.WriteLine("Satis meblegi daxil edin");
                productPriceInput = Console.ReadLine();
            }
            product.ProductPrice = ProductPrice;
            #endregion

            #region Product code
            Console.WriteLine("Mehsulun kodu daxil edin");
            product.ProductCode = Console.ReadLine();

            _marketableService.AddProduct(product);
            #endregion  
        }

        static void ShowProductChange()
        {
            Product product = new Product();
            #region Product Change
            Console.WriteLine("~~~~~~~~ Mehsulda uzerinde deyisiklik etmek~~~~~~~~");
            Console.WriteLine("");
            #endregion

            #region Product Code
            Console.WriteLine("Kodu daxil et");
            string code = Console.ReadLine();
            #endregion 

            List<Product> ProductChangeCode = _marketableService.ChangeProduct(code);

            #region Product New Name
            Console.WriteLine("");
            Console.WriteLine("Mehsulun yeni adini daxil edin");
            string productName = Console.ReadLine();
            #endregion

            #region Product New Quantity
            Console.WriteLine("");
            Console.WriteLine("Mehsulun yeni sayini daxil edin");
            int productQuantity = Convert.ToInt32(Console.ReadLine());
            #endregion

            #region Product New Price
            Console.WriteLine("");
            Console.WriteLine("Mehsulun yeni meblegi daxil edin ");
            double productPrice = Convert.ToDouble(Console.ReadLine());
            #endregion


           

            int selectInt;
            do
            {
                #region Product kategory Menu

                Console.WriteLine("~~~~~~~~kategoriya daxil edin~~~~~~~~");

                Console.WriteLine("0. Televizor");
                Console.WriteLine("1. Computer");
                Console.WriteLine("2. Phone");
                Console.WriteLine("3. Saat");
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
                    case 0:
                        product.Category = CategoryType.Televizor;
                        break;
                    case 1:
                        product.Category = CategoryType.Computer;
                        break;
                    case 2:
                        product.Category = CategoryType.Phone;
                        break;
                    case 3:
                        product.Category = CategoryType.Saat;
                        break;
                    default:
                        Console.WriteLine("------------------------");
                        Console.WriteLine("Siz yalniş secim etdiniz, 0-3 araliğinda seçim etməlisiniz");
                        Console.WriteLine("------------------------");
                        break;
                }



            } while (selectInt ==-1);


            #endregion

            foreach (var item in ProductChangeCode)
            {
                item.Category = (CategoryType)selectInt;
                item.ProductName = productName;
                item.ProductQuantity = productQuantity;
                item.ProductPrice = productPrice;
                

                Console.WriteLine("~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("");
                Console.WriteLine("yeni Mehsul uzerinde deyisiklik edildi");
                Console.WriteLine("");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~");
            }

        }

        static void ShowRemoveProduct()
        {
            Console.WriteLine("~~~~~~~~~~~ Məhsulu Leğv Et ~~~~~~~~~~~");
            Console.WriteLine("");

            string Productcode = Console.ReadLine();
            _marketableService.RemoveProduct(Productcode);

            Console.WriteLine("~~~~~~~~~~~~~~~~");
            Console.WriteLine("~~~~~~~~~~~ Məhsulu Leğv Edildi~~~~~~~~~~~");
            Console.WriteLine("~~~~~~~~~~~~~~~~");
        }

        static void ShowProductList()
        {
            Console.WriteLine("~~~~~~~~~~~~  Movcud Mehsullar  ~~~~~~~~~~~~");
            var table = new ConsoleTable("No", "Kategoriya", "Mehsul", "Sayi", "Qiymeti", "Mehsul kodu");
            int i = 1;
           List<Product>products = _marketableService.GetProducts();
            foreach (var item in _marketableService.Products)
            {
                table.AddRow(i, item.Category, item.ProductName, item.ProductQuantity, item.ProductPrice, item.ProductCode);
                i++;
            }
            table.Write();
        }


        static void ShowProductCategoryName()   /* olmasa*/ 
        {
            Console.WriteLine("Kategoriyasina gore mehsulu gostermek");

            Product product = new Product();


            int selectInt;
            do
            {
                #region Product kategory Menu

                Console.WriteLine("~~~~~~~~kategoriya daxil edin~~~~~~~~");

                Console.WriteLine("0. Televizor");
                Console.WriteLine("1. Computer");
                Console.WriteLine("2. Phone");
                Console.WriteLine("3. Saat");
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
                    case 0:
                        product.Category = CategoryType.Televizor;
                        break;
                    case 1:
                        product.Category = CategoryType.Computer;
                        break;
                    case 2:
                        product.Category = CategoryType.Phone;
                        break;
                    case 3:
                        product.Category = CategoryType.Saat;
                        break;
                    default:
                        Console.WriteLine("------------------------");
                        Console.WriteLine("Siz yalniş secim etdiniz, 0-3 araliğinda seçim etməlisiniz");
                        Console.WriteLine("------------------------");
                        break;
                }
            } while (selectInt == -1);

            _marketableService.GetProductByCategoryName((CategoryType)selectInt);
            #endregion

        }


        static void ShowProductAmountRange()    //olmasa
        {
            Console.WriteLine("~~~~~~~~~~ Qiymət araliğinda Mehsullar ~~~~~~~~~~ ");
            Console.WriteLine("");
            #region Start Amount
            Console.WriteLine("Başlanğic qiyməti daxil edin:");
            string startAmountInput = Console.ReadLine();
            double startAmount;

            while(!double.TryParse(startAmountInput, out startAmount))
            {
                Console.WriteLine("Rəqəm daxil edin");
                startAmountInput = Console.ReadLine();
            }
            #endregion

            #region End Amount
            
            Console.WriteLine("Son qiyməti daxil edin");
            string endAmountInput = Console.ReadLine();
            double endAmount;

            while(!double.TryParse(endAmountInput, out endAmount))
            {
                Console.WriteLine("Rəqem daxil edin");
                endAmountInput = Console.ReadLine();
            }
            #endregion

            List<Product> products = _marketableService.GetProductByAmountRange(startAmount, endAmount);


            var table = new ConsoleTable("No", "Kategoriya", "Mehsul", "Sayi", "Qiymeti", "Mehsul kodu");
            int i = 1;
            foreach (var item in products)
            {
                table.AddRow(i, item.Category, item.ProductName, item.ProductQuantity, item.ProductPrice, item.ProductCode);
                i++;
            }
            table.Write();
        }

        static void ShowSearchProductName()      /*olmasa*/
        {
            Console.WriteLine("Məhsulun adina görə göstərilməsi");
            Console.WriteLine("");
            Console.WriteLine("Mehsulun adi daxil edin");
            Console.WriteLine("");
            string productName = Console.ReadLine();

            List<Product> products = _marketableService.GetSearchByProductName(productName);

            var table = new ConsoleTable("No", "Kategoriya", "Mehsul", "Sayi", "Qiymeti", "Mehsul kodu");
            int i = 1;
            foreach (var item in products)
            {
                table.AddRow(i, item.Category, item.ProductName, item.ProductQuantity, item.ProductPrice, item.ProductCode);
                i++;
            }
            table.Write();

            //foreach (var item in products)
            //{
            //    if (products != null)
            //    {
            //        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~");
            //        Console.WriteLine("");
            //        Console.WriteLine("adı: " + item.ProductName);
            //        Console.WriteLine("Kategoriyasi: " + item.Category);
            //        Console.WriteLine("Sayi: " + item.ProductQuantity);
            //        Console.WriteLine("Kodu: " + item.ProductCode);
            //        Console.WriteLine("Qiyməti: " + item.ProductPrice);
            //        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~");
            //    }
            //}

        }

        #endregion


        static void ShowRemoveSale()  /* olmasa*/
        {
            Console.WriteLine("~~~~~~~~~ Ləğv etmək üçün satiş nömrəsi daxil edin ~~~~~~~~~");

            Console.WriteLine("");
            string saleNumberInput = Console.ReadLine();
            int SaleNumber;
            while(!int.TryParse(saleNumberInput, out SaleNumber))
            {
                Console.WriteLine("Rəqəm daxil edin");
                saleNumberInput = Console.ReadLine();
            }

            _marketableService.RemoveSale(SaleNumber);
            Console.WriteLine("");
            Console.WriteLine("~~~~~~~~~ Satiş ləğv olundu ~~~~~~~~~");
        }      

        static void ShowListSale()
        {
            Console.WriteLine("~~~~~~~~~~~~  Movcud Satishlar  ~~~~~~~~~~~~");
            var table = new ConsoleTable("No", "Nomresi", "Qiymeti", "Mehsul Sayi", "Tarixi");
            int i = 1;
            foreach (var item in _marketableService.Sales)
            {
                table.AddRow(i, item.SaleNumber, item.SaleAmount, item.SaleItem.Count, item.SaleDate.ToString("dd.MM.yyyy"));
                i++;
            }
            table.Write();
        }

        static void ShowSalesByDataRange()  /* olmasa*/
        {

            Console.WriteLine("~~~~~~~~~~ Tarix Aralığinda Satişlar ~~~~~~~~~~ ");
            Console.WriteLine("");

            #region Start Date
            Console.WriteLine("Başlanğic tarixi daxil edin: (gun.ay.il):");
            Console.WriteLine("");
            string startDateInput = Console.ReadLine();
            DateTime startDate;

            while (!DateTime.TryParse(startDateInput, out startDate))
            {
                Console.WriteLine("Tarix daxil etməlisiniz!");
                startDateInput = Console.ReadLine();
            }
            #endregion

            #region End Date
            Console.WriteLine("Sonuncu tarixi daxil edin(gun.ay.il):");
            Console.WriteLine("");

            string endDateInput = Console.ReadLine();
            DateTime endDate;
            while (!DateTime.TryParse(endDateInput, out endDate))
            {
                Console.WriteLine("Tarix daxil etməlisiniz!");
                endDateInput = Console.ReadLine();
            }

            List<Sale> result = _marketableService.GetSalesByDateRange(startDate, endDate);

            var table = new ConsoleTable("No", "Satişin Nömrəsi", "Satişin Qiymeti", "Satişin Sayi", "Satişin tarixi");
            int i = 1;
            foreach (var item in result)
            {
                table.AddRow(i, item.SaleNumber, item.SaleAmount, item.SaleItem.Count, item.SaleDate.ToString("dd.MM.yyyy"));
                i++;
            }
            table.Write();

            //foreach (var item in result)
            //{

            //    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            //    Console.WriteLine("Satişin Nömrəsi: " + item.SaleNumber);
            //    Console.WriteLine("Satişin Qiyməti: " + item.SaleAmount);
            //    Console.WriteLine("Satişin Sayı: " + item.SaleItem.Count);
            //    Console.WriteLine("Satişin Tarixi: " + item.SaleDate.ToString("dd.MM.yyyy"));
            //    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            //}
            #endregion
        }

        static void ShowSalesByAmountRange() /* olmasa*/
        {
            Console.WriteLine("~~~~~~~~~~ Qiymət Aralığinda Satişlar ~~~~~~~~~~ ");
            Console.WriteLine("");

            #region Start Amount
            Console.WriteLine("Başlanğic qiyməti daxil edin:");
            Console.WriteLine("");
            string startAmountInput = Console.ReadLine();
            double startAmount;

            while (!double.TryParse(startAmountInput, out startAmount))
            {
                Console.WriteLine("Rəqəm daxil edin");
                startAmountInput = Console.ReadLine();
            }
            #endregion

            #region End Amount
            Console.WriteLine("Son qiyməti daxil edin");
            Console.WriteLine("");
            string endAmountInput = Console.ReadLine();
            double endAmount;

            while (!double.TryParse(endAmountInput, out endAmount))
            {
                Console.WriteLine("Rəqəm daxil edin");
                endAmountInput = Console.ReadLine();
            }

            List<Sale> result = _marketableService.GetSalesByAmountRange(startAmount, endAmount);
            var table = new ConsoleTable("No", "Satişin Nömrəsi", "Satişin Qiymeti", "Satişin Sayi", "Satişin tarixi");
            int i = 1;
            foreach (var item in result)
            {
                table.AddRow(i, item.SaleNumber, item.SaleAmount, item.SaleItem.Count, item.SaleDate.ToString("dd.MM.yyyy"));
                i++;
            }
            table.Write();

            //foreach (var item in result)
            //{
            //    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            //    Console.WriteLine("Satişin Nömrəsi: " + item.SaleNumber);
            //    Console.WriteLine("Satişin Qiyməti: " + item.SaleAmount);
            //    Console.WriteLine("Satişin Sayı: " + item.SaleItem.Count);
            //    Console.WriteLine("Satişin Tarixi: " + item.SaleDate.ToString("dd.MM.yyyy"));
            //    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            //}
            #endregion
        }

        static void ShowSalesByDate()    /*olmasa*/
        {
            Console.WriteLine("~~~~~~~~~~ Tarixə Göre Satiş ~~~~~~~~~~");
            Console.WriteLine("");

            Console.WriteLine("Satiş tarixi daxil edin: (gun.ay.il):");
            string dateInput = Console.ReadLine();
            DateTime Date;

            while(!DateTime.TryParse(dateInput, out Date))
            {
                Console.WriteLine("Tarix daxil etmlisiniz!");
                dateInput = Console.ReadLine();
            }

            List<Sale> data = _marketableService.GetSalesByDate(Date);

            foreach (var item in data)
            {
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("Satişin Nömrəsi: " + item.SaleNumber);
                Console.WriteLine("Satişin Qiyməti: " + item.SaleAmount);
                Console.WriteLine("Satişin Sayı: " + item.SaleItem.Count);
                Console.WriteLine("Satişin Tarixi: " + item.SaleDate.ToString("dd.MM.yyyy"));
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            }

        }

        static void ShowSalesBySaleNumber()
        {
            Console.WriteLine("~~~~~~~~~~ Satiş nömreəsine göre satişi görmek ~~~~~~~~~~ ");
            Console.WriteLine("");

            Console.WriteLine("");
            Console.Write("Görmək istədiyiniz satışın nömrəsini daxil edin: ");

            string saleNumberInput = Console.ReadLine();
            int saleNumber;

            while (!int.TryParse(saleNumberInput, out saleNumber))
            {
                Console.WriteLine("");
                Console.Write("Rəqəm daxil etməlisiniz!:");
                saleNumberInput = Console.ReadLine();
            }

            Console.WriteLine("");
            List<Sale> sales = _marketableService.GetSalesBySaleNumber(saleNumber);

            foreach (var item in sales)
            {
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("Satişin Nömresi: " + item.SaleNumber + " " + "Satişin qiyməti: " + item.SaleAmount + " " + "Mehsul sayı: " + item.SaleItem.Count + "tarixi: " + item.SaleDate.ToString("dd.MM.yyyy"));
                Console.WriteLine("");
            }

            var list = _marketableService.ShowSaleItem(saleNumber);

            foreach (var item in list)
            {
                Console.WriteLine("Sayi: " + item.SaleCount + " " + "İtem Nömrəsi: " + item.SaleItemNumber + " " + "Məhsulun Adı: " + item.SaleProduct.ProductName);
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~");
            }
        }




    }
}
