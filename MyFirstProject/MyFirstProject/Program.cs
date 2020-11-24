using System;
using System.Text;
namespace MyFirstProject
{
    class Program
    {
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
                        Console.WriteLine("Add Product");
                        break;
                    case 2:
                        Console.WriteLine("Edit Product");
                        break;
                    case 3:
                        Console.WriteLine("Remove Product");
                        break;
                    case 4:
                        Console.WriteLine("List Product");
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

        public void ShowAddProduct()
        {
             
        } 
    }
}
