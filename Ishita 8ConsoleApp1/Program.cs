using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ishita_8ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n Recursin : count the number of digits in a number : \n");
            Console.WriteLine("..........................................................\n");
            Console.WriteLine("Input any number :");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n the number {0} contains number of digit : {1}", num,getDigits(num, 0));
            Console.ReadLine();
        }
        public static int getDigits(int num1, int nodigits)
        {
            if (num1 == 0)
                return nodigits;
            return getDigits(num1 / 10, ++nodigits);
        }
                
    }
}
