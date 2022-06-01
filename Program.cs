//Beni Yaratan Elbet Yolumu Gösterir. Şuara78
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sbyte number1;
            sbyte number2;
            sbyte sum;

            Console.WriteLine("Please enter the first number :");
            number1 = Convert.ToSByte(Console.ReadLine());

            Console.WriteLine("Please enter the second number :");
            number2 = Convert.ToSByte(Console.ReadLine());

            sum = Convert.ToSByte(number1 + number2);

            Console.WriteLine("Sum of entered of two number :" + " " + sum);

            Console.Read();
        }
    }
}
