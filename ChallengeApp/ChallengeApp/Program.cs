using ChallengeApp;
using System;

Console.WriteLine("Witamy w programie XYZ do oceny pracowników");
Console.WriteLine("===========================================");
Console.WriteLine();

var employee = new Employee("Adam", "Wysocki");

while (true)
{
    Console.WriteLine("Podaj następną ocenę pracownika:");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }

    try
    {
        employee.AddGrade(input);
    }
    catch (Exception exception)
    {
        Console.WriteLine($"Ecxeption catched. {exception.Message}.");
    }
}

var statistics = employee.GetStatistics();

Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"AverageLetter: {statistics.AverageLetter}");

