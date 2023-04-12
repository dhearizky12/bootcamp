//ArrayList 1 Modif

using System;
using System.Collections;
namespace Csharp8Features

{
	public class ArrayListDemo
	{
		public static void Main()
		{

            ArrayList objectArrayList = new ArrayList ();
            objectArrayList.Add("Dhea");
            objectArrayList.Add("Fiky");
            objectArrayList.Add("A");
            objectArrayList.Add(15);
            objectArrayList.Add(true); //bool
            objectArrayList.Add(false); //false
            objectArrayList.Add(3.14M); //decimal
            objectArrayList.Add(4.8); //double
            objectArrayList.Add(4.5f); //float
            objectArrayList.Add(null);

        foreach (var myItem in objectArrayList)
        {
            Console.WriteLine (myItem);
        }
        object Element1 = objectArrayList[0]; //returns Dhea
		int? Element4 = (int?)objectArrayList[3]; //returns
		Console.WriteLine("ini adalah elemen pertama = "+Element1);
		Console.WriteLine(Element4 +" ini adalah elemen ke = " + 4 );
            
		}
	}
}