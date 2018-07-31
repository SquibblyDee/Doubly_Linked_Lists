using System;

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
                    Console.WriteLine("EVERY OTHER POS");
                    return true;
                }
                runner = runner.Next;
            }
            ////This handles if the node we want is on the end of the list
            if(runner.Next == null)
            {
                if(runner.Value == value)
                {
                    Console.WriteLine("END POS");
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
}