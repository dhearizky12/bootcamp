class Question1 {
    static void Main () {

        string userInputName = Console.ReadLine();
        string userInputAge = Console.ReadLine();
        

       // Console.WriteLine("Hello, "+ userInputName + " ! " + "You are " + userInputAge + " year");
        for ( int i = userInputName.Length-1; i>=0; i--)
        {
        Console.Write(userInputName[i]);
        }
    }
}