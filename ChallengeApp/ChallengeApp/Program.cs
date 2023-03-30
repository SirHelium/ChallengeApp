using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        string numberInString = Console.ReadLine();
        var letters = numberInString.ToArray();
        var numbers = new int[10];

        for(int i = 0; i < letters.Length; i++)
        {
            for (int j = 0; j < numbers.Length; j++)
            {
                if (letters[i] - 48 == j)
                {
                    numbers[j]++;
                }

            }
        }

        Console.WriteLine("Wyniki dla liczby " + numberInString + ":");
        for(int i = 0;i < numbers.Length; i++)
        {
            Console.WriteLine($"{i} => {numbers[i]}");
        }
    }
}