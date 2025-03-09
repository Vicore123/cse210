using System;

class Program
{
    static void Main(string[] args)
    {   
        Console.Write("what is your grade (in numbers)? ");
        string grade = Console.ReadLine();
        int gradeNumber = int.Parse(grade);
        string gradeLetter = "";

        if (gradeNumber >= 90) {
            gradeLetter = "A";
        }
        else if (gradeNumber >= 80) {
            gradeLetter = "B";
        }
        else if (gradeNumber >= 70) {
            gradeLetter = "C";
        }
        else if (gradeNumber >= 60) {
            gradeLetter = "D";
        }
        else {
            gradeLetter = "F";
        }

        Console.WriteLine($"Your grade is {gradeLetter}");

        if (gradeNumber >= 70) {
            Console.WriteLine("You passed on this course");
        }
        else {
            Console.WriteLine("You did not pass on this course");
        }
    }
}