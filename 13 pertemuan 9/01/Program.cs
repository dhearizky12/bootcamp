
//TimeSpan

TimeSpan ts1 = new TimeSpan(5, 45, 0);
TimeSpan ts2 = TimeSpan.FromHours(2);

// Add the two TimeSpan instances together
TimeSpan ts3 = ts1.Add(ts2);

// Calculate the total number of hours represented by the TimeSpan
double totalHours = ts3.TotalHours;
double hoursOnly = ts3.Hours;
// Print the result to the console
Console.WriteLine(totalHours);  // Output: 3.5
Console.WriteLine(hoursOnly);  // Output: 3