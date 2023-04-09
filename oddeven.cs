using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_basics
{
    internal class oddeven
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            OddEvenClassifier(arr);
            calc();

        }

        private static void OddEvenClassifier(int[] arr)
        {
            Console.WriteLine("even elements are");
            foreach (int i in arr)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }
            Console.WriteLine("odd elements are");
            foreach (int j in arr)
            {
                if (j % 2 != 0)
                    Console.WriteLine(j);
            }
        }
        private static void calc()
        {
            while (true)
            {
                Console.WriteLine("enter the first number");
                double dvalue1 = double.Parse(Console.ReadLine());

                Console.WriteLine("enter the second number");
                double dvalue2 = double.Parse(Console.ReadLine());

                Console.WriteLine("enter the operator(+,-,*,/)");
                char op = char.Parse(Console.ReadLine());
                double result = 0;

                switch (op)
                {
                    case '+':
                        result = dvalue1 + dvalue2;
                        break;

                    case '-':
                        result = dvalue1 - dvalue2;
                        break;
                    case '*':
                        result = dvalue1 * dvalue2;
                        break;
                    case '/':
                        result = dvalue1 / dvalue2;
                        break;
                    default:
                        Console.WriteLine("invalid opertor");
                        break;
                }
                Console.WriteLine(result);
                Console.WriteLine("do you want to continue(Y/N)");
                string answer = Console.ReadLine();
                if (answer != "Y")
                {
                    Console.WriteLine("exit");
                    break;
                }


            }

        }


    }
}
