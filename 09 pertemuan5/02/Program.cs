using System;

class Stack<T>
{
    private T[] _items;
    private int _top;

    public Stack(int capacity)
    {
        _items = new T[capacity];
        _top = -1;
    }

    public void Push(T item)
    {
        if (_top == _items.Length - 1)
        {
            throw new Exception("Stack overflow");
        }

        _top++;
        _items[_top] = item;
    }

    public T Pop()
    {
        if (_top == -1)
        {
            throw new Exception("Stack underflow");
        }

        T item = _items[_top];
        _top--;
        return item;
    }

    public bool IsEmpty()
    {
        return _top == -1;
    }
}

class Program
{
    static void Main()
    {
        Stack<int> intStack = new Stack<int>(5);
        intStack.Push(1);
        intStack.Push(2);
        intStack.Push(3);

        Console.WriteLine("Popped: " + intStack.Pop());
        Console.WriteLine("Popped: " + intStack.Pop());
        Console.WriteLine("Popped: " + intStack.Pop());

        Stack<string> stringStack = new Stack<string>(5);
        stringStack.Push("foo");
        stringStack.Push("bar");
        stringStack.Push("baz");

        Console.WriteLine("Popped: " + stringStack.Pop());
        Console.WriteLine("Popped: " + stringStack.Pop());
        Console.WriteLine("Popped: " + stringStack.Pop());
    }
}