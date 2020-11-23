using System;
using System.Text;
namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            int selectInt = 0;
            do
            {
                #region First Menu 
                Console.WriteLine("========Satis programi========");
                Console.WriteLine("1. Məhsullar uzərinde əməliyyat aparmaq");
                Console.WriteLine("2. Satislar uzərində əməliyyat aparmaq");
                Console.WriteLine("0. Sistemdən cixmaq");
                Console.WriteLine("Seçiminizi edin");

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
                        break;
                    default:
                        Console.WriteLine("----------------------------");
                        Console.WriteLine("siz yalniş secim etdiniz, 0-2 arasinda secim ede bilərsiniz");
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
                Console.WriteLine("1. Yeni mehsul elave et");
                Console.WriteLine("2.Mehsul uzerinde duzelis et");
                Console.WriteLine("3.Mehsulu sil");
                Console.WriteLine("4.Butun mehsullari goster");
                Console.WriteLine("5.Categoriyasina gore mehsullari goster");
                Console.WriteLine("6.Qiymet araligina gore mehsullari goster");
                Console.WriteLine("7. Mehsullar arasinda ada gore axtaris et");

                string select = Console.ReadLine();
                while (!int.TryParse(select, out selectInt1))
                {
                    Console.WriteLine("rəqəm daxil etməlisiniz");
                    select = Console.ReadLine();
                }
                switch (selectInt1)
                {
                    case 1:
                        continue;
                    case 2:
                        continue;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("----------------------------");
                        Console.WriteLine("siz yalniş secim etdiniz, 1-7 arasinda secim ede bilərsiniz");
                        Console.WriteLine("----------------------------");
                        break;
                }

            } while (selectInt1 != 0);
        }
    }
}
