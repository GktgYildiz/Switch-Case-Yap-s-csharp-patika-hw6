using System;

namespace Switch_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int month =DateTime.Now.Month;
            
            //expression
            switch (month)
            {
                case 1:
                    Console.WriteLine("Ocak ayındasınız");
                    break;

                case 2:
                    Console.WriteLine("Şubat ayındasınız");
                    break;

                case 4:
                    Console.WriteLine("Nisan ayındasınız");
                    break;

                case 3:
                    Console.WriteLine("mart ayındasınız");
                    break;
                
                default:
                    Console.WriteLine("yanlış veri girişi");
                break; 
            }
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("kış ayındasınız");
                    break;

                case 3:
                case 4:
                case 5:
                    Console.WriteLine("ilkbahar ayındasınız");
                    break;

                case 6:
                case 7:
                case 8:
                    Console.WriteLine("yaz ayındasınız");
                    break;

                case 9:
                case 10:
                case 11:
                    Console.WriteLine("sonbahar ayındasınız");
                    break;
               
                default:
                    break;
            }
        }
    }
}
