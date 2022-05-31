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

    class DoublyLinkedListNode
    {
        public int data;
        public DoublyLinkedListNode next;
        public DoublyLinkedListNode prev;

        public DoublyLinkedListNode(int nodeData)
        {
            this.data = nodeData;
            this.next = null;
            this.prev = null;
        }
    }

    class DoublyLinkedList
    {
        public DoublyLinkedListNode head;
        public DoublyLinkedListNode tail;

        public DoublyLinkedList()
        {
            this.head = null;
            this.tail = null;
        }

        public void InsertNode(int nodeData)
        {
            DoublyLinkedListNode node = new DoublyLinkedListNode(nodeData);

            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                this.tail.next = node;
                node.prev = this.tail;
            }

            this.tail = node;
        }
    }

    static void PrintDoublyLinkedList(DoublyLinkedListNode node, string sep, TextWriter textWriter)
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

    static DoublyLinkedListNode sortedInsert(DoublyLinkedListNode head, int data)
    {
        if (head==null)  //test if head equal null or not
        {
            DoublyLinkedList obj = new DoublyLinkedList();
            obj.InsertNode(data);
            return obj.head;
        }
        DoublyLinkedListNode newNode = new DoublyLinkedListNode(data);
        //linked list has one node
        if (head.next == null)
        {
            //testing to put new node befor or after

            //before
            if (data>=head.data)
            {
                head.next = newNode;
                newNode.prev = head;
                return head;
            }
            //after
            else
            {
                newNode.next = head;
                head.prev = newNode;
                head = newNode;
                return newNode;
            }
        }

        DoublyLinkedListNode temp = head;
        //get position of my node
        while (temp!=null)
        {

            if (data<=temp.data)
            {
                // multiple nodes => put node first
                // 2 - 3 -4    1
                //solution  1-2-3-4

                if (data<=head.data)
                {
                    newNode.next = head;
                    head.prev = newNode;
                    head = newNode;
                    return newNode;
                }

                // multiple nodes => put node between two nodes
                // 1 - 3 -4    2
                //solution  1-2-3-4
                newNode.next = temp.prev.next;
                temp.prev.next = newNode;
                newNode.prev = temp.prev;
                temp.prev = newNode;
                return head;
            }
            // multiple nodes => put node at end
            // 2 - 3 -4    5
            //solution  2-3-4-5
            if (temp.next==null)
            {
                temp.next = newNode;
                newNode.prev = temp;
                return head;
            }
            temp = temp.next;
        }

        return head;

    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++)
        {
            DoublyLinkedList llist = new DoublyLinkedList();

            int llistCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < llistCount; i++)
            {
                int llistItem = Convert.ToInt32(Console.ReadLine());
                llist.InsertNode(llistItem);
            }

            int data = Convert.ToInt32(Console.ReadLine());

            DoublyLinkedListNode llist1 = sortedInsert(llist.head, data);

            PrintDoublyLinkedList(llist1, " ", textWriter);
            textWriter.WriteLine();
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
