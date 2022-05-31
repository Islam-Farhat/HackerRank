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

    static int Count(SinglyLinkedListNode head)
    {
        int count = 0;
        SinglyLinkedListNode temp = head;
        if (head == null)
        {
            return 0;
        }
        else
        {
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            return count;
        }
    }
    static SinglyLinkedListNode mergeLists(SinglyLinkedListNode head1, SinglyLinkedListNode head2)
    {
        if (head1 == null)
        {
            return head2;
        }

        if (head2 == null)
        {
            return head1;
        }

        SinglyLinkedListNode newhead; ;
        SinglyLinkedListNode s;

        if (head1.data <= head2.data)
        {
            s = head1;
            head1 = s.next;

        }
        else
        {
            s = head2;
            head2 = s.next;
        }
        newhead = s;

        while (head1!=null && head2!=null)
        {
            if (head1.data <= head2.data)
            {
                s.next = head1;
                s = head1;
                head1 = head1.next;

            }
            else
            {
                s.next = head2;
                s = head2;
                head2 = head2.next;
            }
        }
        if (head1 == null) s.next = head2;
        if (head2 == null) s.next = head1;
        return newhead;










        //SinglyLinkedList obj = new SinglyLinkedList();
        //SinglyLinkedListNode newsortedlist;
        //for (int i = 0; i < Count(head1); i++)
        //{
        //    obj.InsertNode(head1.data);
        //}
        //for (int i = 0; i < Count(head2); i++)
        //{
        //    obj.InsertNode(head2.data);
        //}
        //newsortedlist = obj.head;


    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int tests = Convert.ToInt32(Console.ReadLine());

        for (int testsItr = 0; testsItr < tests; testsItr++)
        {
            SinglyLinkedList llist1 = new SinglyLinkedList();

            int llist1Count = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < llist1Count; i++)
            {
                int llist1Item = Convert.ToInt32(Console.ReadLine());
                llist1.InsertNode(llist1Item);
            }

            SinglyLinkedList llist2 = new SinglyLinkedList();

            int llist2Count = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < llist2Count; i++)
            {
                int llist2Item = Convert.ToInt32(Console.ReadLine());
                llist2.InsertNode(llist2Item);
            }

            SinglyLinkedListNode llist3 = mergeLists(llist1.head, llist2.head);

            PrintSinglyLinkedList(llist3, " ", textWriter);
            textWriter.WriteLine();
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
