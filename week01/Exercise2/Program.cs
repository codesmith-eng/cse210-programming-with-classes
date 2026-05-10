using System;

class Program
{
    static void Main(string[] args)
    {
        //Displaying the program name and instructions to the user
        Console.WriteLine("-------- Welcome to the grade calculator for the university-------");
        Console.WriteLine("Please enter your score below. The cut off grade to pass this course is 70%");
        Console.WriteLine(" ");

        //using console.write to display questions 
        Console.Write("What was your grade percentage: ");
        //using console.ReadLine(); to get the questions as input and saving it in string variable 
        string percentage = Console.ReadLine();

        //converting the variable to integer
        int grade = int.Parse(percentage);

        //conditions to check grades
        if (grade >= 93 && grade <= 100)
        {
            string letter = "A";
            string sign = "";
            Console.WriteLine($"Congratulations you have passed this course and your score is {letter}{sign}");
        }

        else if (grade <= 92 && grade >= 90)
        {
            string letter = "A";
            string sign = "-";
            Console.WriteLine($"Congratulations you have passed this course and your score is {letter}{sign}");
        }

        else if (grade >= 87 && grade <= 89)
        {
            string letter = "B";
            string sign = "+";
            Console.WriteLine($"Congratulations you have passed this course and your score is {letter}{sign}");
        }

        else if (grade >= 83 && grade <= 86)
        {
            string letter = "B";
            string sign = "";
            Console.WriteLine($"Congratulations you have passed this course and your score is {letter}{sign}");
        }

        else if (grade <= 82 && grade >= 80)
        {
            string letter = "B";
            string sign = "-";
            Console.WriteLine($"Congratulations you have passed this course and your score is {letter}{sign}");
        }

        else if (grade >= 77 && grade <= 79)
        {
            string letter = "C";
            string sign = "+";
            Console.WriteLine($"Congratulations you have passed this course and your score is {letter}{sign}");
        }

        else if (grade >= 73 && grade <= 76)
        {
            string letter = "C";
            string sign = "";
            Console.WriteLine($"Congratulations you have passed this course and your score is {letter}{sign}");
        }

        else if (grade <= 72 && grade >= 70)
        {
            string letter = "C";
            string sign = "-";
            Console.WriteLine($"Congratulations you have passed this course and your score is {letter}{sign}");
        }

        else if (grade >= 67 && grade <= 69)
        {
            string letter = "D";
            Console.WriteLine($"Your score is {letter} You have failed this course, try again next term");
        }

        else if (grade >= 63 && grade <= 66)
        {
            string letter = "D";
            Console.WriteLine($"Your score is {letter} You have failed this course, try again next term");
        }

        else if (grade >= 60 && grade <= 65)
        {
            string letter = "D";
            Console.WriteLine($"Your score is {letter} You have failed this course, try again next term");
        }

        else
        {
            string letter = "F";
            string sign = "";
            Console.WriteLine($"Your score is {letter} You have failed this course, try again next term");
        }
    }
}