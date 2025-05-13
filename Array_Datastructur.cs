using System;
public class MyArray
{
    int Size;
    int Length;
    int[] arrayitems;
    public MyArray(int size)
    {
        Size=size;
        arrayitems=new int[size];
        Length=0;
    }
    public int GetSize { get {return Size; } }
    public int GetLength { get {return Length; } }

    private void OutOfTheRange(int index)
    {
        if(index > Size)
        throw new IndexOutOfRangeException();
    }

    public void Fill(int length)
    {
        if(length>Size)
        {
            Console.WriteLine("the length is greater than size");
            return;
        }
        else
        {
            for(int index=0; index<length; index++)
            {
                Console.Write($"enter the item number ({index+1}) : ");
                int enteritem=int.Parse(Console.ReadLine());
                arrayitems[index]=enteritem;
                Length++;
                
            }
        }
    }
    public void Dispaly()
    {
        for(int index=0; index<Length; index++)
        {
        Console.WriteLine($"the item number ({index+1}) : {arrayitems[index]}");
        }
    }
    
    public int Search(int index)
    {
        OutOfTheRange(index);
        int itemfound = -1;
        for(int iteration = 0; iteration < Length; iteration++)
        {
            if(arrayitems[index] == arrayitems[iteration])
            return arrayitems[ iteration];

        }
        return itemfound;
    }

    public void Add(int item)
    {
        if(item < 0)
        throw new Exception("item must be equl or graeter than 0");
        arrayitems[Length]=item;
        Length++;

    }
    public void Append(int index,int item)
    {
        if(index>Size)
        throw new Exception("index out of the range");

        for(int iteration = Length-1; iteration >= index; iteration--)
            arrayitems[iteration+1]=arrayitems[iteration];
        arrayitems[index]=item;
        Length++;
        
    }
    public int Delete(int index)
    {
        if(index > Size)
        throw new Exception("index out of the range");
        int itemdelete = arrayitems[index];
        for(int iteration = index; iteration < Length; iteration++)
           arrayitems[iteration]=arrayitems[iteration + 1];
        Length--; 
        return itemdelete; 
        
    }
    public void EnLarge(int newSize)
    {
        int[] _oldArray=new int[newSize];
        Size=newSize;
        for(int index = 0; index < Length; index++)
        _oldArray[index]=arrayitems[index];
    }
    public void Marge(MyArray arraytomarge)
    {
        int newsize = Size + arraytomarge.Size;
        Size = newsize;
        int[] olditemarray=arrayitems;
        arrayitems = new int[newsize];
        int index;
        for(index = 0; index < Length; index++)
            arrayitems[index]=olditemarray[index];
        for(int _index = 0; _index < arraytomarge.Length; _index++)
        {
            arrayitems[index++]=arraytomarge.arrayitems[_index];
            Length++;
        }

    }
}