using System;
using System.Collections.Generic; //This line of code is mandatory if List is been used

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        Console.WriteLine(" ");

        //variable for adding total 
        int sum = 0;

        int maxNum = int.MinValue;

        int number = -1;

        int closest = 9999999;

        //declaring a list in C#, myNumbers is the variable
        List<int> myNumbers = new List<int>();

        while (number != 0)
        {
            //Requesting input from user
            Console.Write("Enter Number: ");
            string num = Console.ReadLine();

            //Converting input to integer
            number = int.Parse(num);

            //removing 0 from the list
            if (number != 0)
            {
                myNumbers.Add(number);
            }
        }

        //sorting the list
        myNumbers.Sort();

        int count = myNumbers.Count;

        //looping through the numbers
        foreach (int ite in myNumbers)
        {
            //Adding up the numbers
            sum += ite;

            //condition for getting the highest number in the list
            if (ite > maxNum)
            {
                maxNum = ite;
            }

            //Conditions for finding the lowest positive number in the list
            if (ite > 0 && ite < closest)
            {
                closest = ite;
            }
        }


        //Calculating the average
        double average = (double)sum / count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The Largest Number is: {maxNum}");
        Console.WriteLine($"The Lowest positive number: {closest}");
        Console.WriteLine("The Sorted List is:");

        //looping through the numbers to display the sorted list
        foreach (int mySort in myNumbers)
        {
            Console.WriteLine(mySort);
        }
    }
}