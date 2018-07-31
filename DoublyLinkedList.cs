using System;
using System.Collections.Generic;

public class DoublyLinkedList
{
    public DllNode Head;
    // Place your methods here.
    public DoublyLinkedList()
    {
        this.Head = null;
    }
    public void Add(int value)
    {
        DllNode newNode = new DllNode(value);
        if(Head == null)
        {
            Head = newNode;
        }
        else{
            DllNode runner = Head;
            while(runner.Next != null)
            {
                runner = runner.Next;
            }
            runner.Next = newNode;
            newNode.Prev = runner;
        }
    }

    public bool Remove(int value)
    {
        DllNode runner = Head;
        ///Edge case for if our list is empty
        if(this.Head == null)
        {
            return false;
        }
        ////If a list with a single node contains our value
        if(runner.Next == null)
        {
            if(runner.Value == value)
            {
                ////Only have to repoint the list's head here
                this.Head = null;
                return true;
            }
            else
            {
                return false;
            }
            
        }
        ////If the list has > 1 nodes begin running through the list's nodes
        else
        {
            while(runner.Next != null)
            {
                ////This handles every other possible node position.
                if(runner.Value == value)
                {
                    ////Change all them pointers
                    ////If... reroute the next node's Prev to the previous Node.
                    if(runner.Next != null)
                    {
                        runner.Next.Prev = runner.Prev;
                    }
                    ///This is used to reroute our head past the first node if it contains our value.
                    if(runner.Prev == null)
                    {
                        this.Head = runner.Next;
                    }
                    ////If... reroute the next node's Prev to the previous Node.
                    if(runner.Prev != null)
                    {
                        runner.Prev.Next = runner.Next;
                    }
                    return true;
                }
                runner = runner.Next;
            }

            ////This handles if the node we want is on the end of the list
            if(runner.Next == null)
            {
                if(runner.Value == value)
                {
                    if(runner.Next != null)
                    {
                        runner.Next.Prev = runner.Prev;
                    }
                    if(runner.Prev != null)
                    {
                        runner.Prev.Next = runner.Next;
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
    public void PrintValues()
    {
        var runner = this.Head;
        Console.WriteLine("\nList Contents:");
        while(runner != null)
        {
            Console.WriteLine($"Node Value: {runner.Value}");
            runner = runner.Next;
        }
        Console.WriteLine("");
    }

    ////There is a better solution that only iterates through the list once
    ////If we declare some additional pointers to go along with the runner
    ////We need 3 unqiue pointers including runner from what I remember...
    public void Reverse()
    {
        var runner = this.Head;
        List<int> tempList = new List<int>();
        while(runner != null)
        {
            tempList.Add(runner.Value);
            runner = runner.Next;
        }
        runner = this.Head;
        while(runner != null)
        {
            runner.Value = tempList[tempList.Count-1];
            tempList.RemoveAt(tempList.Count-1);
            runner = runner.Next;
        }
    }
}