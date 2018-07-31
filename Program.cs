using System;

namespace Doubly_Linked_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Doubly Linked Lists:");
            DoublyLinkedList list1 = new DoublyLinkedList();
            list1.Add(7);
            list1.Add(12);
            list1.Add(15);
            list1.Add(20);
            list1.Add(25);
            list1.PrintValues();
            Console.WriteLine(list1.Remove(2));
            Console.WriteLine(list1.Remove(7));
            list1.PrintValues();
            Console.WriteLine(list1.Remove(20));
            list1.PrintValues();
            Console.WriteLine(list1.Remove(25));
            list1.PrintValues();
            Console.WriteLine(list1.Remove(30));
            list1.PrintValues();
        }
    }
}
