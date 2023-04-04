using ChallengeApp;

var employee = new Employee("Adam", "Kamizelich");
employee.AddGrade(200);
employee.AddGrade(17436396796963246233);
employee.AddGrade(5);
employee.AddGrade("Adam");
var statistics = employee.GetStatistics();
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Average: {statistics.Average:N2}");


