using System.Net.Http.Headers;
using Пр3_ИСРПО_;

namespace pr
{
   internal class Program
   {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите А:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите B:");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите операцию:");
            char c = Convert.ToChar(Console.ReadLine());
            Class clas = new Class();
            switch (c)
            {
                case '+':
                    Console.WriteLine($"a + b = {clas.Plus(a,b)}");
                    break;
                case '-':
                    Console.WriteLine($"a - b = {clas.Minus(a, b)}");
                    break;
            }
            Console.ReadKey(); 
        }
   }
}