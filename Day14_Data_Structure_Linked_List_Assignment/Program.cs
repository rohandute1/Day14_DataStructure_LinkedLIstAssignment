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

            linkedList.AppendNode(56);
            linkedList.AppendNode(30);
            linkedList.AppendNode(70);

            linkedList.PopLast();

            linkedList.PrintList();

            Console.ReadLine();
        }
    }
}
