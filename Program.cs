using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            ConsoleColor prevColor = Console.BackgroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Green;
                DateTime curDate = DateTime.Today;
                Console.WriteLine("Введите ваше имя ");
                string name = Console.ReadLine();
                Console.WriteLine($"Привет {name} сегодня {curDate}");
                Console.Read();
            }
        }
    }


