using System;

namespace Doubly_Linked_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Doubly Linked Lists:");
            DoublyLinkedList list1 = new DoublyLinkedList();
            ////Add a pile of nodes to our list
            list1.Add(7);
            list1.Add(12);
            list1.Add(15);
            list1.Add(20);
            list1.Add(21);
            list1.Add(22);
            list1.Add(23);
            list1.Add(24);
            list1.Add(25);
            list1.PrintValues();
            ////Test deleting a non existent node
            Console.WriteLine($"Did we remove a node? {list1.Remove(2)}");
            ////Test deleting the first node
            Console.WriteLine($"Did we remove a node? {list1.Remove(7)}");
            ////Test deleting a middle node
            Console.WriteLine($"Did we remove a node? {list1.Remove(20)}");
            ////Test deleting the end node
            Console.WriteLine($"Did we remove a node? {list1.Remove(25)}");
            list1.PrintValues();
            list1.Reverse();
            list1.PrintValues();
        }
    }
}
