using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int factorial = 1;
            bool ok = true;

            do
            {
                Console.WriteLine("Введите целое число");
                string buf = Console.ReadLine();
                ok = int.TryParse(buf, out n);
            } while (!ok);

            factorial = Factorial(n);
            Console.WriteLine("factorial = {0}", factorial);
        }

        public static int Factorial(int n)
        {
            int factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
