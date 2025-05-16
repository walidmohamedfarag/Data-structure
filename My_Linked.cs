
namespace linked_list
{
    internal class My_Linked
    {
        Node First;
        public My_Linked()
        {
            First = null;
        }
        bool IsEmpty()
        {
            return First == null;
        }
        public int GetCounter { get { return Counter(); } }
        int Counter()
        {
            Node tempPointer = First;
            int counter = 0;
            while (tempPointer != null)
            {
                counter++;
                tempPointer = tempPointer.Next;
            }
            return counter;
        }
        public void Add(int item)
        {
            Node newnode = new Node(item);
            if (IsEmpty())
                First = newnode;
            else
            {
                newnode.Next = First;
                First = newnode;
            }
        }
        public void Print()
        {
            Node tempPointer = First;
            while (tempPointer != null)
            {
                Console.WriteLine(tempPointer.Data);
                tempPointer = tempPointer.Next;
            }
        }
        public void AddBefore(int item, int newitem)
        {
            Node temppointer = First;
            while (temppointer != null && temppointer.Next.Data != item)
            {
                temppointer = temppointer.Next;
            }
            Node newnode = new Node(newitem);
            newnode.Next = temppointer.Next;
            temppointer.Next = newnode;
        }
        public void AddLast(int item)
        {
            Node temppointer = First;
            while (temppointer.Next != null)
            {
                temppointer = temppointer.Next;
            }
            Node newnode = new Node(item);
            newnode.Next = null;
            temppointer.Next = newnode;
        }

        public void Delete(int item)
        {
            Node temppointer = null;
            Node delpointer = First;
            while(delpointer != null && delpointer.Data != item)
            {
                temppointer = delpointer;
                delpointer = delpointer.Next;
            }
            temppointer.Next = delpointer.Next;

        }


    }
}
