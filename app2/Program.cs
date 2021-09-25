using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app2
{
    class Program
    {
        public static void Second()
        {
            int a, second;
            Console.WriteLine("Enter the minutes");
            a = Convert.ToInt32(Console.ReadLine());
            second = a * 60;
            Console.WriteLine("Second is {0}", second);
        }

        public static void Sum()
        {
            int a, b, result;
            Console.WriteLine("Enter the first Number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second Number");
            b = Convert.ToInt32(Console.ReadLine());
            result = a + b;
            Console.WriteLine("sum is {0}", result);
        }
        public static void Days()
        {
            int a, days;
            Console.WriteLine("Enter the ages");
            a = Convert.ToInt32(Console.ReadLine());
            days = a * 365;
            Console.WriteLine("DAYS is {0}", days);
        }
        public static void Isequal()
        {
            int a, b;
            Console.WriteLine("enter the number");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            if (a == b)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

        }
        public static void Increment()
        {
            int a, b;
            Console.WriteLine("Enter the number");
            a = Convert.ToInt32(Console.ReadLine());
            b = a + 1;
            Console.WriteLine("increment number is {0}", b);
        }
        public static void Function(bool )
            {
            }

        public static void Main(string[] args)
        {
            Sum();
            Second();
            Days();
            Isequal();
            Increment();
            Console.ReadLine();
        }
    }
}
