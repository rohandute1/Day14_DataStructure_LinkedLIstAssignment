using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Day14_Data_Structure_Linked_List_Assignment.LinkedList;

namespace Day14_Data_Structure_Linked_List_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to linked list assignment");

            SortedLinkedList sortedLinkedList = new SortedLinkedList();

            sortedLinkedList.Add(56);
            sortedLinkedList.Add(30);
            sortedLinkedList.Add(40);
            sortedLinkedList.Add(70);

            sortedLinkedList.PrintList();

            Console.ReadLine();
        }
    }
}
