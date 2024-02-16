using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cup1 = "Кофе";
            string cup2 = "Чай";
            
            Console.WriteLine($"У нас в чашке 1 - {cup1}, в чашке 2 - {cup2}.");
            Console.WriteLine("Поменяем содержимое чашек местами");

            string tempCup;
            tempCup = cup1;
            cup1 = cup2;
            cup2 = tempCup;

            Console.WriteLine($"Теперь у нас в чашке 1 - {cup1}, в чашке 2 - {cup2}.");
        }
    }
}
