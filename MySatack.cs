
namespace Stack_Datastructure
{
    internal class MySatack
    {
        Node First;
        public MySatack()
        {
            First = null;
        }
        bool IsEmpty()
        {
            return First == null;
        }
        public int GetCount { get { return count(); } }
        public void Push(int item)
        {
            Node newnode = new Node(item);
            if(IsEmpty())
            {
                First = newnode;
                newnode.Next = null;
            }
            else
            {
                newnode.Next = First;
                First = newnode;
            }
        }
        public int Pop()
        {
            if(IsEmpty())
                throw new Exception("Stack is empty");
            Node tempointer = First;
            int popitem = tempointer.Data;
            tempointer = tempointer.Next;
            First = tempointer;
            return popitem;
        }
        public void PrintAllItem()
        {
            Node tempointer = First;
            while (tempointer != null)
            {
                Console.WriteLine(tempointer.Data);
                tempointer = tempointer.Next;
            }
        }
        public int Peek()
        {
            if (IsEmpty())
                throw new Exception("Stack is empty");
            return First.Data;
        }
        private int count()
        {
            Node tempointer = First;
            int count = 0;
            while (tempointer != null)
            {
                tempointer = tempointer.Next;
                count++;
            }
            return count;
        }
        public bool Search(int item)
        {
            Node tempointer = First;
            while(tempointer != null)
            {
                if(tempointer.Data == item)
                    return true;
                tempointer = tempointer.Next;
            }
            return false;
        }
    }
}
