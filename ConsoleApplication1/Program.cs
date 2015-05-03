using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Display Series
            //var n = 4;
            //for (int i = 0; i <= n; i++)
            //{
            //    DisplayLine(i);
            //}

            //fibinocci series
            var max = 50;
            var first = 0;
            var second = 1;
            while (first + second<=max)
            {
                var t = first + second;
                Console.Write(t+ " ");
                first = second;
                second = t; 
            }
        }

        public static void DisplayLine(int num)
        {
            for (int i = 0; i <= num; i++)
            {
                Console.Write(1 + " ");
            }

            Console.WriteLine();
        }
    }
}
