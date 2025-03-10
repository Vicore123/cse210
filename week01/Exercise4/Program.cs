using System;
using System.Collections.Generic;
using System.Security;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userNumber = -1;
        int sum = 0;
        int largestNumber = 0;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (userNumber != 0) {

            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());
            if (userNumber != 0) {
                numbers.Add(userNumber);
            }
        }

        foreach (int number in numbers) {
            sum += number;
            if (number > largestNumber) {
                largestNumber = number;
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {numbers.Average()}");
        Console.WriteLine($"The largest number is: {largestNumber}");

    }
}