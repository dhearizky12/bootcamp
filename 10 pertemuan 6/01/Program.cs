using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Enter a number: ");
        int? n = int.Parse(Console.ReadLine());
        for (int i = 0; i <= n; i++) {
          if (i==0){
          Console.Write ("0") ;
          } else if (i % 15 == 0) {
                Console.Write(" "+"foobar");
            } else if (i % 3 == 0) {
                Console.Write("foo" +" ");
            } else if (i % 5 == 0) {
                Console.Write("bar"+ " ");
            } else {
                Console.Write(" " + i +" ");
            }
        }   
    }
}