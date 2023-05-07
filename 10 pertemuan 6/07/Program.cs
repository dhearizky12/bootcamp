using System;
public delegate int Calculate(int a, int b);
class Program {
    static void Main(string[] args) {
        // Create a delegate instance and assign a method to it
        Calculate multiplyCalculate = Multiply;
        Calculate addCalculate = Add;

        int result1=multiplyCalculate (5,6);
        int result2 =addCalculate (2,5);
 
       

       Console.Writeline ("Hasil dari perkalian : " + result1);
       Console.Writeline ("Hasil dari penjumlahan : " + result2);
       //Console.Writeline ("Hasil dari penjumlahan : " + result3);
    }

    // A simple method to be assigned to the delegate
    static int Multiply(int a, int b) {
      return a*b;

    }
    static int Add(int a, int b) {
        return a*b;
    }
}