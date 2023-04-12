using System;

public class GenericData<T>
{
    private T[] data;
    private int capacity;
    private int count;

    public GenericData(int capacity) // constructor
    {
        this.capacity = capacity;
        this.data = new T[capacity];
        this.count = 0;
    }

    public int Capacity
    {
        get { return this.capacity; }
    }

    public T[] Data
    {
        get { return this.data; }
    }

    public int Count
    {
        get { return this.count; }
    }

    public void AddData(T item)
    {
        if (this.count < this.capacity)
        {
            this.data[this.count] = item;
            this.count++;
        }
        else
        {
            throw new InvalidOperationException("Data array is full");
        }
    }

    public void RemoveData(int index)
    {
        if (index >= 0 && index < this.count)
        {
            for (int i = index; i < this.count - 1; i++)
            {
                this.data[i] = this.data[i + 1];
            }
            this.data[this.count - 1] = default(T);
            this.count--;
        }
        else
        {
            throw new IndexOutOfRangeException("Index out of range");
        }
    }

    public T[] GetData()
    {
        T[] result = new T[this.count];
        Array.Copy(this.data, result, this.count);
        return result;
    }
}

public class StringData
{
    private GenericData<string> genericData;

    public StringData(int capacity) // constructor
    {
        this.genericData = new GenericData<string>(capacity);
    }

    public int Capacity
    {
        get { return this.genericData.Capacity; }
    }

    public string[] StringDataArray
    {
        get { return this.genericData.Data; }
    }

    public int Count
    {
        get { return this.genericData.Count; }
    }

    public void AddString(string item)
    {
        this.genericData.AddData(item);
    }

    public void RemoveString(int index)
    {
        this.genericData.RemoveData(index);
    }

    public string[] GetStringData()
    {
        return this.genericData.GetData();
    }
}

public class Program
{
    public static void Main()
    {
        // Create an instance of StringData with capacity of 5
        StringData stringData = new StringData(5);

        // Add several strings to the StringData array
        stringData.AddString("hy");
        stringData.AddString("nama");
        stringData.AddString("saya");
        stringData.AddString("dhea");
        stringData.AddString("salam kenal");

        // Display the entire StringData array
        Console.WriteLine("StringData:");
        foreach (string str in stringData.GetStringData())
        {
            Console.WriteLine(str);
        }

        // Remove one of the strings from the StringData array
        stringData.RemoveString(1);

        // Display the updated StringData array
        Console.WriteLine("StringData after removing one string:");
        foreach (string str in stringData.GetStringData())
        {
            Console.WriteLine(str);
        }
    }
}