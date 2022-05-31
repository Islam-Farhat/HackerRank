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

class Solution
{

    class SinglyLinkedListNode
    {
        public int data;
        public SinglyLinkedListNode next;

        public SinglyLinkedListNode(int nodeData)
        {
            this.data = nodeData;
            this.next = null;
        }
    }

    class SinglyLinkedList
    {
        public SinglyLinkedListNode head;
        public SinglyLinkedListNode tail;

        public SinglyLinkedList()
        {
            this.head = null;
            this.tail = null;
        }

        public void InsertNode(int nodeData)
        {
            SinglyLinkedListNode node = new SinglyLinkedListNode(nodeData);

            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                this.tail.next = node;
            }

            this.tail = node;
        }
    }

    static void PrintSinglyLinkedList(SinglyLinkedListNode node, string sep, TextWriter textWriter)
    {
        while (node != null)
        {
            textWriter.Write(node.data);

            node = node.next;

            if (node != null)
            {
                textWriter.Write(sep);
            }
        }
    }

    static SinglyLinkedListNode FindPrevious(SinglyLinkedListNode head, int value)
    {
        SinglyLinkedListNode temp = head;
        for (int i = 1; i < value; i++)
        {
            temp = temp.next;
        }
        return temp;
    }

    static SinglyLinkedListNode deleteNode(SinglyLinkedListNode llist, int position)
    {

        SinglyLinkedListNode previouse = FindPrevious(llist, position);
        // if (previouse == null)
        // {
        //     return llist;
        // }
        if (position == 0)
        {

            llist = llist.next;
            return llist;
        }
        else
        {
            SinglyLinkedListNode target = previouse.next;
            previouse.next = target.next;
            target.next = null;
            return llist;
        }
    }


    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        SinglyLinkedList llist = new SinglyLinkedList();

        int llistCount = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < llistCount; i++)
        {
            int llistItem = Convert.ToInt32(Console.ReadLine());
            llist.InsertNode(llistItem);
        }

        int position = Convert.ToInt32(Console.ReadLine());

        SinglyLinkedListNode llist1 = deleteNode(llist.head, position);

        PrintSinglyLinkedList(llist1, " ", textWriter);
        textWriter.WriteLine();

        textWriter.Flush();
        textWriter.Close();
    }
}
