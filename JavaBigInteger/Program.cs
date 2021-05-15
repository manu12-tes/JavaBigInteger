using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaBigInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame dos numeros");
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());

            Console.WriteLine((a + b) + "\n"+(a*b));
        }
    }
}
