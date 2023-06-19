using System;
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

        public void InsertNode(int data, int position)
        {
            Node newNode = new Node(data);

            if (position == 0)
            {
                newNode.Next = Head;
                Head = newNode;
            }
            else
            {
                Node currentNode = Head;
                int currentPosition = 0;

                while (currentPosition < position - 1 && currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                    currentPosition++;
                }

                newNode.Next = currentNode.Next;
                currentNode.Next = newNode;
            }
        }

        public void Pop()
        {
            if (Head != null)
            {
                Head = Head.Next;
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
    }
}
