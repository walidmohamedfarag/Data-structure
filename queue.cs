


public class MyQueue
{
    Node First;
    Node Last;
    public MyQueue()
    {
        First = null;
        Last = null;
    }
    bool Isempty()
    {
        return First == null;
    }

    public int LastItem { get { return Last.Data; } }

    public void Enqueue(int item)
    {
        Node newnode = new(item);
        if (Isempty() == true)
        {
            First = newnode;
            Last = newnode;
            newnode.Next = null;
        }
        else
        {
            Last.Next = newnode;
            Last = newnode;
        }
    }

    public int Dequeue()
    {
        if (Isempty())
            throw new Exception("the queue is empty..");
        int tempvalue = First.Data;
        if (First == Last)
        {
            Console.Write($"this ({First.Data}) is the last item of queue \n");
            First = First.Next;
            return tempvalue;
        }
        Console.Write($"the value ({First.Data}) is deleted \n");
        First = First.Next;
        return tempvalue;
    }


    public void Display()
    {
        if (Isempty())
            throw new Exception("The Queue Is Empty!!!");
        Node temppointer = First;
        while (temppointer != null)
        {
            Console.WriteLine(temppointer.Data);
            temppointer = temppointer.Next;
        }
    }
    private int _countItem()
    {
        if (Isempty())
            return 0;
        int count = 0;
        Node tempointer = First;
        while (tempointer != null)
        {
            tempointer = tempointer.Next;
            count++;
        }
        return count;
    }
    public int Count { get { return _countItem(); } }
    public void Search(int item)
    {
        int elementNumber = 0;
        Node tempointer = First;
        while (tempointer != null)
        {
            elementNumber++;
            if (tempointer.Data == item)
            {
                Console.WriteLine($"the item ({item}) is found in the element number {elementNumber}");
                break;
            }
            tempointer = tempointer.Next;

        }
        throw new Exception("the item not found");
    }
    public int Peek {get { return First.Data; }}
  


}