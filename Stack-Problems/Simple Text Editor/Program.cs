using System;
using System.Collections.Generic;

namespace Simple_Text_Editor
{


    //8
    //1 abc
    //3 3
    //2 3
    //1 xy
    //3 2
    //4
    //4
    //3 1
    class Program
    {
        static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());

            List<string> operations = new List<string>();
            string myString = ""; int lenght = 0;
            Stack<string> lastOperation = new Stack<string>();int count = 0;
            for (int i = 0; i < q; i++)
            {
                string opsItem = Console.ReadLine();
                operations.Add(opsItem);
            }
            
            foreach (var item in operations)
            {
                string[] S = item.Split(' '); int k;
                switch (S[0])
                {
                    case "1":       // append(w) - Append string w to the end of S.

                        lastOperation.Push(myString);count++;
                        myString = myString + S[1];
                        break;

                    case "2":      // delete(k) - Delete the last k characters of S.

                        lastOperation.Push(myString);count++;
                        lenght = myString.Length;
                        k = Convert.ToInt32(S[1]);
                        if (k == lenght)
                        {
                            myString = "";
                            break;
                        }
                        myString = myString.Substring(0, lenght - k);                      
                        
                        break;

                    case "3":       // print(k) - Print the k character of S .
                        k = Convert.ToInt32(S[1]);
                        if (k>myString.Length)
                        {
                            break;
                        }   
                        Console.WriteLine(myString[k - 1]);
                        break;

                    case "4":       // undo() - Undo the last (not previously undone) operation of type 1 or 2,
                                    // reverting  to the state it was in prior to that operation.
 
                        if (count!=0)
                        {
                            myString = lastOperation.Peek();
                            lastOperation.Pop();
                        }
                        
                        break;
                    default:
                        break;
                }

            }
        }
    }
}
