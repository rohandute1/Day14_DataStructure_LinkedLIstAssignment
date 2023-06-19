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
            linkedList.AppendNode(40);
            linkedList.AppendNode(70);

            linkedList.DeleteNode(40);
            Console.WriteLine("LinkedList size is: " + linkedList.Size);

            linkedList.PrintList();

            Console.ReadLine();
        }
    }
}
