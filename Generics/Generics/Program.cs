using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Generics.FindMaximum;

namespace Generics
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Maximum Integer");
            Console.WriteLine("Enter the option");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Finding maximum of three numbers");
                    MaxOfNumbers integer = new MaxOfNumbers();
                    int maximumNum = integer.MaxInteger(22, 55, 99);
                    Console.WriteLine("Maximum Number is :" + maximumNum);
                    Console.ReadLine();
                    break;
            }

        }
    }
}