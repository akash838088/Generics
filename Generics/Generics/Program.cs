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
            FindMaximum integer = new FindMaximum();
            Console.WriteLine("1.Maximum Integer \n2.Maximum Float Number");
            Console.WriteLine("Enter the option");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Finding maximum of three numbers");
                    int maximumNum = integer.MaxInteger(31, 31, 81);
                    Console.WriteLine("Maximum Number is :" + maximumNum);
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Finding maximum of three floating numbers");
                    float maximumFloat = integer.MaxFloat(12.3, 45.6, 8.45);
                    Console.WriteLine("Maximum Floating Number is : " + maximumFloat);
                    Console.ReadLine();
                    break;
            }
        }
    }
}

