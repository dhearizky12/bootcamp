public delegate T MyDelegate<T,T1>(T a ,T1 b);

class Program {
    static void Main(string[] args) {
       MyDelegate <double, int> addDelegate = new MyDelegate <double, int> (Kalkulator.Add);
        MyDelegate <double, int> MultiplyDelegate = new MyDelegate <double, int> (Kalkulator.Multiply);

        var result1 = addDelegate(2.5, 3);
       
        var result2 = MultiplyDelegate(3.5, 2); 
       
        Console.WriteLine("Result of addDelegate: " + result1);
        Console.WriteLine("Result of multiplyDelegate: " + result2);


        MyDelegate <int, double> addDelegate2 = new MyDelegate <int, double> (Kalkulator.Add);
        MyDelegate <int, double> MultiplyDelegate2 = new MyDelegate <int, double> (Kalkulator.Multiply);

        //double result3 = addDelegate2(3, 2.5);
        double result4 = MultiplyDelegate2(2, 3.5); 
       
        //Console.WriteLine("Result of addDelegate2: " + result3);
        Console.WriteLine("Result of multiplyDelegate1: " + result4);
    }


class Kalkulator {
    public static T? Add <T,T1>(T a, T1 b) {

        if (a is int x && b is int y){
            return (T) (object)(x+y);
        }
        //return (dynamic) a + (dynamic) b;
        else if (a is string e && b is string f){
            return (T) (object)(e+f);
        }
        else if (a is double g && b is double h){
            return (T)(object)(g+h);
        }
        else if (a is int i && b is double j){
            return (T)(object)(i+j);
        }
          else if (a is double k && b is int l){
            return (T)(object)(k+l);
        }
        else {
            throw new NotSupportedException("Operation not supported for this data type");
        }
    }

    public static T? Multiply<T,T1> (T a,T1 b) {
           if (a is int x && b is int y){
            return (T) (object)(x*y);
        }
        //return (dynamic) a + (dynamic) b;

        else if (a is double g && b is double h){
            return (T)(object)(g*h);
        }
        else if (a is int i && b is double j){
            return (T)(object)(i*j);
        }
          else if (a is double k && b is int l){
            return (T)(object)(k*l);
        }
        else {
            throw new NotSupportedException("Operation not supported for this data type");
        }
    }
}
}