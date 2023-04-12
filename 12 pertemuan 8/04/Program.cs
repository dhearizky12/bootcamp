//Operator Overloading


using System;

public class MyClass
{
    public int value;

    public MyClass (int value){
        this.value=value;
    }

public static string operator + (MyClass a, MyClass b)
{
    return (a.value + b.value).ToString();
}
public static string operator - (MyClass a, MyClass b)
{
    return (a.value - b.value).ToString();
}
public static int operator * (MyClass a, MyClass b)
{
    return (a.value * b.value);
}
public static int operator / (MyClass a, MyClass b)
{
    return (a.value / b.value);
}

public static MyClass Subtract (MyClass a, MyClass b, MyClass c)
{
  return new MyClass(a.value - b.value - c.value);
}

public static MyClass add (MyClass a, MyClass b, MyClass c)
{
  return new MyClass(a.value + b.value + c.value);
}

}


class Program
{

    static void Main ()
    {
    MyClass x = new MyClass (10);
    MyClass y = new MyClass (20);
    string result = x+y;
    Console.WriteLine ("ini hasil dari penjumlahan tipe data string = " + result);
    MyClass min1 = new MyClass (10);
    MyClass min2 = new MyClass (20);
    string result2 = min1-min2;
    Console.WriteLine ("ini hasil dari pengurangan tipe data string = " + result2);
    
    MyClass minInt = new MyClass (10);
    MyClass minInt1 = new MyClass (20);
    int resultInt = minInt*minInt1;
    Console.WriteLine ("ini hasil dari perkalian dgn tipe data int = " + resultInt);

    MyClass bagi1 = new MyClass (20);
    MyClass bagi2 = new MyClass (10);
    int resultbagi= bagi1/bagi2;
    Console.WriteLine ("ini hasil dari pembagian = " + resultbagi);

    MyClass minmin1 = new MyClass (10);
    MyClass minmin2 = new MyClass (20);
    MyClass minmin3 = new MyClass (20);
    MyClass result3 = MyClass.Subtract(minmin1, minmin2, minmin3);
    Console.WriteLine ("ini hasil dari pengurangan 3 variabel = "+result3.value);

    MyClass plusplus1 = new MyClass (10);
    MyClass plusplus2 = new MyClass (20);
    MyClass plusplus3 = new MyClass (20);
    MyClass result4 = MyClass.add(plusplus1, plusplus2, plusplus3);
    Console.WriteLine ("ini hasil dari penjumlahan 3 variabel = " + result4.value);
}

}
