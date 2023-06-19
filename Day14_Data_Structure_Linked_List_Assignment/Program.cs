using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_Data_Structure_Linked_List_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to linked list assignment");
            LinkedList linkedList = new LinkedList();

            linkedList.AddNode(56);
            linkedList.AddNode(30);
            linkedList.AddNode(70);

            linkedList.PrintList();
            Console.ReadLine();

            Console.ReadLine();
        }
    }
}
