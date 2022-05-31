using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    public static void implementQueue(List<string> operations)
    {
        Queue<string> queue = new Queue<string>();
        foreach (var item in operations)
        {
            string[] S = item.Split(' ');
            switch (S[0])
            {
                case "1":
                    queue.Enqueue(S[1]);
                    break;

                case "2":
                    queue.Dequeue();
                    break;

                case "3":
                    Console.WriteLine(queue.Peek());
                    break;
                default:
                    break;
            }

        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        List<string> operations = new List<string>();
        for (int i = 0; i < n; i++)
        {
            string opsItem = Console.ReadLine();
            operations.Add(opsItem);
        }

        Result.implementQueue(operations);


    }
}


//*********************************************************************************************************\\


//using System;
//using System.Collections.Generic;
//using System.IO;
//class Solution
//{
//    static void Main(string[] args)
//    {
//        int q = int.Parse(Console.ReadLine());
//        Stack<int> s1 = new Stack<int>();
//        Stack<int> s2 = new Stack<int>();

//        while (q-- > 0)
//        {
//            string[] input = Console.ReadLine().Split(' ');

//            if (input[0] == "1")
//            {
//                s1.Push(int.Parse(input[1]));

//            }
//            else if (input[0] == "2")
//            {
//                if (s2.Count > 0) s2.Pop();
//                else if (s1.Count > 0)
//                {
//                    while (s1.Count > 0)
//                        s2.Push(s1.Pop());
//                    s2.Pop();
//                }
//            }
//            else // "3"
//            {
//                if (s2.Count == 0)
//                {
//                    while (s1.Count > 0)
//                        s2.Push(s1.Pop());
//                }
//                Console.WriteLine(s2.Peek());
//            }
//        }
//    }
//}

