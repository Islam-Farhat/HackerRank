using System;


namespace Decimal_To_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Convert.ToInt32("1001101", 2).ToString());

            int number = 11;
            string a = "";
            while (number > 0)
            {
                a += (number % 2);
                number /= 2;
            }
            for (int i = a.Length - 1; i >= 0; i--)
            {
                Console.Write(a[i]);
            }

        }
    }
}
