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

            LinkedList linkedList = new LinkedList();

            linkedList.AppendNode(56);
            linkedList.AppendNode(30);
            linkedList.AppendNode(70);

            Node searchNode = linkedList.Search(30);

            if (searchNode != null)
            {
                Console.WriteLine("Found node with value 30");
            }
            else
            {
                Console.WriteLine("Node with value 30 not found");
            }

            linkedList.PrintList();

            Console.ReadLine();
        }
    }
}
