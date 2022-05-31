using System;
using System.Linq;



namespace IsSymmetrical
{
    class Program
    {
        public static bool IsSymmetrical(int num)
        {
            //Solution 1
            string numberasstring = num.ToString();

            int lenght = numberasstring.Length - 1;
            for (int i = 0; i < numberasstring.Length; i++)
            {
                if (numberasstring[i] != numberasstring[lenght--])
                {
                    return false;
                }
            }
            return true;


            //Solution 2
           // return num.ToString() == string.Concat(num.ToString().Reverse());
        }
        static void Main(string[] args)
        {

            Console.WriteLine(IsSymmetrical(1221));

        }
    }
}
