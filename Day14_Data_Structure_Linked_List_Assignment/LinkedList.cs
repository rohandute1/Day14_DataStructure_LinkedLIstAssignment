﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_Data_Structure_Linked_List_Assignment
{
    internal class LinkedList
    {
        public class Node
        {
            public int Data;
            public Node Next;

            public Node(int data)
            {
                Data = data;
                Next = null;
            }
        }

        public Node Head;

        public LinkedList()
        {
            Head = null;
        }

        public void AppendNode(int data)
        {
            Node newNode = new Node(data);

            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node currentNode = Head;

                while (currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                }

                currentNode.Next = newNode;
            }
        }

        public void PrintList()
        {
            Node currentNode = Head;

            while (currentNode != null)
            {
                Console.Write(currentNode.Data);

                if (currentNode.Next != null)
                {
                    Console.Write("->");
                }

                currentNode = currentNode.Next;
            }

            Console.WriteLine();
        }
        public class SortedLinkedList : LinkedList
        {
            public void Add(int data)
            {
                Node newNode = new Node(data);

                if (Head == null || data < Head.Data)
                {
                    newNode.Next = Head;
                    Head = newNode;
                }
                else
                {
                    Node currentNode = Head;

                    while (currentNode.Next != null && data > currentNode.Next.Data)
                    {
                        currentNode = currentNode.Next;
                    }

                    newNode.Next = currentNode.Next;
                    currentNode.Next = newNode;
                }
            }
        }

    }
}
