using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            Console.WriteLine("Дано выражение y=7x^2-3x+4");
            Console.Write("Введите значение х: ");
            int x = int.Parse(Console.ReadLine());
            var y = (7 * Math.Pow(4, 2)) - (3 * x) + 4;
            Console.WriteLine("Ответ:\n " + "7*" + x + "^2" + "-3*" + x + "+4 = " + y);


            //Задание 2
            Console.Write("Введите радиус окружности: ");



            Console.ReadLine();
           
            
   
            
        }

    }
}
