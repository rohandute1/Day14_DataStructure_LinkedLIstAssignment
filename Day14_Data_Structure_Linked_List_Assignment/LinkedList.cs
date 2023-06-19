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

        public void InsertAfter(int searchData, int insertData)
        {
            Node searchNode = Search(searchData);

            if (searchNode != null)
            {
                Node newNode = new Node(insertData);
                newNode.Next = searchNode.Next;
                searchNode.Next = newNode;
            }
            else
            {
                Console.WriteLine("Node with value {0} not found.", searchData);
            }
        }

        public Node Search(int value)
        {
            Node currentNode = Head;

            while (currentNode != null)
            {
                if (currentNode.Data == value)
                {
                    return currentNode;
                }

                currentNode = currentNode.Next;
            }

            return null;
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
