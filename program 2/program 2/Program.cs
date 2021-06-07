using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_2
{
    public class calculator
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int result = calculator.Add(2, 5);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
