// These are the using statements - they let you use things like List, Console.WriteLine. I don't think you need to actually know about these for the exam,
// it would be REALLY nasty if they asked you to do something and missed these out D:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Single line comments are done like this

/*
    Multiline comments can be done like this
    I tend not to use these :/
*/

namespace Example
{
    // Anything within a class (between it's braces) is a function
    class Program
    {
        // Example header declaration - this always needs to be in your programs
        static void Main(string[] args)
        {
            // There are these neat things called regions - you don't need to use them, you won't be asked about them etc, I'm just using them here to make the code clearer.
            // To expand/collapse a region, click the "+" on the left hand side next to it. I recommend you collapse them all the start with, then open them while you read
            // the code inside so it doesn't look overwhelming :P
            #region Declaring (and initialising sometimes) variables
            // Variable names should be nouns, they're used to hold info about something
            int Age = 16;
            string Name = "Keith";
            string OtherName;
            float Pi = 3.14159f; // The "f" tells the program that you're entering a float.
            decimal Cost = 4.50M; // decimals are used to hold things with 2dp, ususally the cost of something. Have to use "M" for the same reason as you have to use "f" above.
            #endregion

            #region Printing things
            Console.WriteLine("My name is " + Name); // The "+" puts the variables together as a string, then we print the resultant string
            Console.Write("My age is "); // Console.Write lets us print without jumping to a new line. This is useful for nicely formatted output :)
            Console.WriteLine(Age);
            #endregion

            #region Reading input
            string UserName = Console.ReadLine(); // Reads in a line (until they press enter) from the user
            Console.ReadKey(true); // Waits for the user to press a key. The "true" indicates that the character pressed should NOT be printed to the screen. This makes it look neater
            #endregion

            #region Conversions
            Age = Convert.ToInt32("17"); // Converting to an int from a string - any string could be used, but if the string doesn't contain a number it'll throw an exception :O
            Pi = Convert.ToSingle("3.141592"); // Converting to a float isn't quite what you'd expect - it's "single" not "float" :/
            long BigNumber = Convert.ToInt64("23723475384657"); // "long"s can hold bigger numbers than ints and are Int64s. "short"s hold smaller numbers and are Int16s.
            #endregion

            #region Arrays
            int[] Ages = new int[6]; // Arrays can be of any type but you need to specify how big they are in advance. Once created, just refer to them by name, eg Ages
            Ages[0] = 16; // the [] operator gives you acces to a single element in the array (starting at 0). Treat this EXACTLY like any other variable - it's not special :P
            string[] Names = new string[] { "Keith", "Dan", "Laura", "Max", "Peter", "Sam", "Lawrencium" }; // You can also define arrays like this, and it automatically sizes itself to fit all the elements.
            Console.WriteLine(Names.Length); // .Length gives you the number of elements in an array - this is useful for "for" loops
            #endregion

            #region Lists
            List<long> LotsOfBigNumbers = new List<long>(); // Lists are like arrays but they dno't have a fixed size. This is NOT a good name foer the list - identifiers should be short and sweet
            LotsOfBigNumbers.Add(108794872358); // "Add"ing elements is what makes Lists awesome - just keep adding all you like :D
            Console.WriteLine(LotsOfBigNumbers.Count); // Lists have .Count instaed of .Length - it returns how many things have been added.
            LotsOfBigNumbers = new List<long>() { 15058, 57546 }; // Lists can be declared like this too :O
            #endregion

            #region Loops
            bool Exit = false; // This is a flag to limit when the loop should run
            while (!Exit) // A "while" loop will keep looping until a condition is met - you can put "true" in here and it'll loop forever. the ! (NOT) operator inverts a boolean
            {
                Console.WriteLine("Can I exit yet? ");
                string Input = Console.ReadLine();
                if (Input == "yes" || Input == "y") // == is the comparison operator - it returns true if the things are equal. || means OR, like in logic gates; if Input== either "yes" OR "y".
                {
                    Exit = true; // Set the flag so that the loop will end
                }
            }

            while (false) // This loop will never run, it's just here for show
            {
                break; // The break statement will immediately exit the loop - it's easier than using a flag :P
            }

            for (int x = 0; x < 10; x++) // For loops repeat a SET number of time (although you can "break" out of them like above). This goes from 0-9 inclusive.
            {
                Console.WriteLine("Current number is: " + x);
            }

            int Sum = 0; // This is a counter variable (or something like that) - we'll use it to find the sum of all numbers from 100 to 0;
            for (int x = 100; x >= 0; x--) // Loops can also go down! This will print 100-0 inclusive. It doens't matter that we use "x" here, the other variable "x" was in a different scope
            {
                Sum += x; // Add x to Sum - this is shorthand for "Sum = Sum + x;"
            }

            int Counter = 0;
            do // A do-while loop will always run at least once. Personally, I never actually use these! A well structured while loop renders these obsolete :P
            {
                Counter++; // Increase before printing, so it'll go "1, 2, 3, 4..." rather than "0, 1, 2, 3..."
                Console.WriteLine("Counter is " + Counter);
            }
            while (Counter < 10); // Here's the condition - just like in a normal while loop
            #endregion

            #region Functions/Procedures

            // When typing this up, I wrote the functions FIRST below, then wrote code to call them SECOND - there's no point trying to call the functions before you've written them :P
            // If you see a function used like this and you don't know what it does, look around in the code to find it and work out what it does, then come back.
            // You can right click a function call and hit "go to definition" to jump straight to where it's defined
            PrintMessage("Hello", ConsoleColor.Red); // ConsoleColor.Red is a special type of variable we'll learn about later

            int a = 5, b = 105; // Variables can be DECLARED like this (b is assumed to be of type "int"), but it's frowned upon to do so. You can't use this notation anywhere else ie in function headers
            Swap(ref a, ref b); // When calling, speerate the parameters with commas. You need to include the ref but you never include the type (never "Swap(int a, int b);")
            // Now a=105, b=5;
            Console.WriteLine(a + " " + b);

            Name = Prompt("What is your name?"); // I've already defined "Name" higher up the program, so I don't put "string Name".
            string Address = Prompt("What is your address?"); // One use for functions is to take a task that needs to be repeated and make it shorter to code
            string Town = Prompt("Where do you live?"); // It's quite obvious what this means, and it saves a lot of typing of "Console.WriteLine, Console.ReadLine"
            string FavFood = Prompt("What is your favourite food?");

            int Factorial7 = Factorial(7);
            int Factorial15 = Factorial(15);
            #endregion

        } // Declare functions after this brace

        // Functions/Procedures should still have meaningful names, and should use verbs - they're used to perform actions, unlike variables.

        // Notice the header - static, void signifies it's a procedure, then the Identifier or Name, then finally the parameter list
        // This procedure will print a message in a given colour :O
        static void PrintMessage(string Message, ConsoleColor Colour) // Seperate multiple parameters with commas
        {
            ConsoleColor Original = Console.ForegroundColor; // Store the current colour in a temporary variable
            Console.ForegroundColor = Colour; // Set the new colour

            Console.WriteLine(Message); // Print the message

            Console.ForegroundColor = Original; // Set the colour back to what it was originally (otherwise all the text will be the same colour)
        }

        // Remember this function?
        // static void Identifer (Paramaters). The "ref" keyword makes the changes made to the "x" and "y" placeholders affect the variables the function was called with
        static void Swap(ref int x, ref int y)
        {
            int Temp = x;
            x = y;
            y = Temp;
        }

        // This is a function - it returns a value (string not void). It takes a single string as well which it prints to ask the user
        static string Prompt(string Message)
        {
            Console.WriteLine(Message); // Ask for input
            return Console.ReadLine(); // "return" the input - give it back to the programmer who called the function.
        }

        // This function takes an int and returns an int. It computes the factorial of a number (written "n!") eg. 6! = 6*5*4*3*2*1 = 720, 4! = 4*3*2*1 = 24
        static int Factorial(int n)
        {
            int Counter = 1; // Create a variable to hold our current product

            for (int x = n; x > 0; x--) // Start at whatever number we've been asked to find the factorial of and loop down to 1
            {
                Counter *= x; // Each iteration, find multiply by the next number down (x).
            }
            return Counter; // Return this value back to the programmer
        }
    }
}
