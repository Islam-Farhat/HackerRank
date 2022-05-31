using System;
using System.Collections;
using System.Linq;
namespace Convert_Fraction_Number_to_Binary_Stack_Like_14._56_
{
    class Program
    {
        public static Stack IntegerPart(int number)
        {
            Stack stackInteger = new Stack();
            stackInteger.Push(".");
            while (number > 0)
            {
                stackInteger.Push(number % 2);
                number /= 2;
            }
            return stackInteger;
        }
        public static Stack FractionPart(double number)
        {
            int rem; int counter = 0;
            //string a = "";
            Stack stackFraction = new Stack();
            while (number != 0)
            {
                number = number * 2;
                rem = (int)number;
                stackFraction.Push(rem);
                number = number - rem;
                if (counter++ == 5)
                    break;
            }
            return stackFraction;
        }
        static void Main(string[] args)
        {
            double Number = double.Parse(Console.ReadLine());

            Stack stackInteger = new Stack();

            stackInteger = IntegerPart((int)Number);

            Number = Number - (int)Number;
            Stack stackFraction = new Stack();
            stackFraction = FractionPart(Number);

            foreach (var item in stackInteger)
            {
                Console.Write(item);
            }
            foreach (var item in stackFraction)
            {
                Console.Write(item);
            }
        }
    }
}
