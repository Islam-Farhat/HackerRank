using System;
using System.Collections.Generic;
using System.Collections;

namespace Dynamic_Array
{
    class Program
    {
        static List<int> dynamicArray(List<string> queries, int n)
        {
            List<List<int>> arr = new List<List<int>>(new List<int>[n]);
            for (int i = 0; i < n; i++)
            {
                arr[i]= new List<int>();
                //arr.Add(new List<int>()); we can do that and delete -new List<int>[n]- from decleration
            }
            int lastAnswer = 0; int x, index, y;
            List<int> result = new List<int>();
            foreach (var i in queries)
            {
                string[] item = i.Split(' ');
                x = Convert.ToInt32(item[1]);
                y = Convert.ToInt32(item[2]);
                index = ((x ^ lastAnswer) % n);
                switch (item[0])
                {
                    case "1":

                        arr[index].Add(y);
                        break;

                    case "2":
                        int size = arr[index].Count;
                        lastAnswer = arr[index][y % size];
                        result.Add(lastAnswer);
                        break;

                    default:
                        break;
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(input[0]);
            int q = Convert.ToInt32(input[1]);
            List<string> queries = new List<string>();
            for (int i = 0; i < q; i++)
            {
                queries.Add(Console.ReadLine());
            }
            List<int> result = dynamicArray(queries, n);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
