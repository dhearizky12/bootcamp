//ENUM

enum DaysOfWeek
{
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
}

class Program
{
    static void Main()
    {
        if (DateTime.Now.DayOfWeek == DayOfWeek.Tuesday)
        {
            Console.WriteLine("Today is Tuesday.");
        }
        else
        {
            Console.WriteLine("Today is not Tuesday");
            Console.WriteLine($"Today is {DateTime.Now.DayOfWeek}.");
            Console.WriteLine($"Today is the {(int)DayOfWeek.Tuesday}nd day of the week.");
        }
        // Use the enum in a foreach loop
        Console.WriteLine("thea array is : ");
        foreach (DaysOfWeek day in Enum.GetValues(typeof(DaysOfWeek)))
        {
            Console.WriteLine(day);
        }
    }
}