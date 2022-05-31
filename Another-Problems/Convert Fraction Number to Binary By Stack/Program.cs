using System;
using System.Collections.Generic;

namespace Convert_Fraction_Number_to_Binary_By_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = .74; int rem; int counter = 0;
            Stack<int> stacknumber = new Stack<int>();
            while (number != 0)
            {
                number = number * 2;
                rem = (int)number;
                stacknumber.Push(rem);
                number = number - rem;
                if (counter++ == 5)
                    break;
            }

            foreach (var item in stacknumber)
            {
                Console.Write(item);
            }

            #region Solution 2 Normal
            //double number = .75; int rem; int counter = 0;
            //string a = "";
            //while (number != 0)
            //{
            //    number = number * 2;
            //    rem = (int)number;
            //    a += rem;
            //    number = number - rem;
            //    if (counter++ == 5)
            //        break;
            //}
            //for (int i = a.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(a[i]);
            //}
            #endregion


        }
    }
}
