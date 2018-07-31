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


}