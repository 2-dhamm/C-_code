using System;

class Program
{
    static void Main()
    {
        // ==================================================
        // Question 1
        // Write a program that allows the user to enter a
        // number then print it.
        // ==================================================

        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Your number is: " + number);


        // ==================================================
        // Question 2
        // Convert a string to an integer, but the string
        // contains non-numeric characters.
        // And mention what will happen.
        // ==================================================

        string text = "ABC";

        try
        {
            int value = Convert.ToInt32(text);
            Console.WriteLine(value);
        }
        catch
        {
            // The program will throw a FormatException
            Console.WriteLine("Cannot convert string to integer.");
        }


        // ==================================================
        // Question 3
        // Perform a simple arithmetic operation with
        // floating-point numbers and mention what will happen.
        // ==================================================

        double num1 = 10.5;
        double num2 = 2.5;

        double result = num1 + num2;

        Console.WriteLine("Result = " + result);

        // The result will be 13.0


        // ==================================================
        // Question 4
        // Extract a substring from a given string.
        // ==================================================

        string word = "Computer";

        string sub = word.Substring(0, 4);

        Console.WriteLine("Substring = " + sub);

        // Output: Comp


        // ==================================================
        // Question 5
        // Assigning one value type variable to another and
        // modifying the value of one variable.
        // Mention what will happen.
        // ==================================================

        int x = 10;
        int y = x;

        y = 20;

        Console.WriteLine("x = " + x);
        Console.WriteLine("y = " + y);

        // x = 10
        // y = 20
        // Because int is a Value Type.


        // ==================================================
        // Question 6
        // Assigning one reference type variable to another
        // and modifying the object through one variable.
        // Mention what will happen.
        // ==================================================

        int[] arr1 = { 10, 20, 30 };

        int[] arr2 = arr1;

        arr2[0] = 100;

        Console.WriteLine("arr1[0] = " + arr1[0]);
        Console.WriteLine("arr2[0] = " + arr2[0]);

        // arr1[0] = 100
        // arr2[0] = 100
        // Because arrays are Reference Types.


        // ==================================================
        // Question 7
        // Take two string variables and print them as one
        // variable.
        // ==================================================

        string firstName = "Adham";
        string lastName = "Mohamed";

        string fullName = firstName + " " + lastName;

        Console.WriteLine(fullName);


        // ==================================================
        // Question 8
        // Which of the following statements is correct?

        // Answer: b) A value 1 will be assigned to d.


        // ==================================================
        // Question 9
        // Which of the following is the correct output?
        //
        // Console.WriteLine(13 / 2 + " " + 13 % 2);
        // ==================================================

        Console.WriteLine(13 / 2 + " " + 13 % 2);

        // Answer: d) 6 1


        // ==================================================
        // Question 10
        // What will be the output of the C# code?
        // ==================================================

        int num = 1;
        int z = 5;

        if (!(num <= 0))
        {
            Console.WriteLine(++num + z++ + " " + ++z);
        }
        else
        {
            Console.WriteLine(--num + z-- + " " + --z);
        }

        // Answer: d) 7 7
    }
}