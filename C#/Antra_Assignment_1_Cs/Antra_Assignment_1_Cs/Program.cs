// Understanding Data Types

/* Test your Knowledge
1. What type would you choose for the following “numbers”?
    A person’s telephone number: int, char
    A person’s height: double
    A person’s age: int, uint, char
    A person’s gender (Male, Female, Prefer Not To Answer): Enum, string
    A person’s salary: decimal
    A book’s ISBN: string
    A book’s price: deciml
    A book’s shipping weight: double
    A country’s population: int, uint, long
    The number of stars in the universe: ulong
    The number of employees in each of the small or medium businesses in the United Kingdom (up to about 50,000 employees per business): ushort

2. What are the difference between value type and reference type variables? What is boxing and unboxing?
    1) Value types will directly hold the value, while Reference types will hold the memory address or reference for this value
    2) Value types are stored in stack memory, while Reference types will be stored in heap memory
    3) Value types will not be collected by garbage collector, while Reference types will be collected by garbage collector
    4) Value types can by created by Struct or Enum, but Reference types can be created by class, interface, delegate, or array
    5) Value types cannot accept null values, but Reference types can accept null values

    bosing: convert a value type to a reference type
    unboxing: convert the reference type to a value type

3. What is meant by the terms managed resource and unmanaged resource in .NET
    1) The "managed resources" are somthing that can be directly under the control of the garbage collector.
    2) The "unmanaged resources" are objects that wrap operating system resources, such as files, windows, network connections, or database connections.

4. Whats the purpose of Garbage Collector in .NET?
    The purpose of Garbage Collector in .NET is an automatic memory manager to manage the allocation and release of memory for an application.
*/


//Playing with Console App
//Console.WriteLine("What is your favorite color?");
//string a = Console.ReadLine();
//Console.WriteLine("What is your astrology sign?");
//string b = Console.ReadLine();
//Console.WriteLine("What is your street address number?");
//string c = Console.ReadLine();
//Console.WriteLine($"Your hacker name is {a}{b}{c}.");


//Practice number sizes and ranges
//Q1: Please see Project named "02UnderstandingTypes"

//Q2:
//public class Centuries
//{
//    public static void Main()
//    {
//        Console.Write("Input: ");

//        int i = int.Parse(Console.ReadLine());
//        int centuries = i * 100;
//        int years = i * 36524;
//        int days = i * 876576;
//        int hours = i * 52594560;
//        ulong minutes = (ulong)(i * 3155673600);
//        ulong seconds = (ulong)(i * 3155673600000);
//        ulong milliseconds = (ulong)(i * 3155673600000000);
//        ulong microseconds = (ulong)(i * 3155673600000000000);

//        Console.WriteLine($"Output: {i} centuries = {centuries} " +
//            $"years = {years} days = {days} hours = {hours} minutes = {minutes} " +
//            $"seconds = {seconds} milliseconds = {milliseconds} " +
//            $"microseconds = {microseconds} nanoseconds");

//    }
//}






// Controlling Flow and Converting Types
/* Test your Knowledge
1. What happens when you divide an int variable by 0?
    It will show a pop-up window of "System.DivideByZeroException has been thrown" with a message "Attempted to divide by zero."

2. What happens when you divide a double variable by 0?
    It will display a finity symbol ∞ in the output.

3. What happens when you overflow an int variable, that is, set it to a value beyond its range?
    1) It will show a error with "Cannot implicitly convert type 'type1' to 'type2'."
    2) It will show a pop-up window of "System.OverflowException has been thrown" with a message "Value was either too large or too small for an Int32."
    3) It will cause unexpect results.

4. What is the difference between x = y++; and x = ++y;?
    1) x = y++; = When our code is executing, it will first read value y and then do the calaulation y = y + 1 after it has been read.
                  Therefore, if x = y++, the variable y will be incremented after assigning its value to x.
    2) x = ++y; = When our code is executing, it will first do the calaulation y = y + 1 and then read it.
                  Therefore, if x = ++y, the variable y will be incremented before assigning its value to x.

5. What is the difference between break, continue, and return when used inside a loop statement?
    1) break: will TERMINATE a loop statement in which it present.
    2) continue: will SKIP over the execution part of a loop statement on a certain condition.
    3) return: will TERMINATE execution of a loop statement in which it present and then RETURN the control to the calling method.

6. What are the three parts of a for statement and which of them are required?
    The syntax of a "for" statement is as the following, and three parts of a for statement are initializer, condition, and iterator. All of them are optional.
    for ([initializer]; [condition]; [iterator])
    {
        // Statement(s) to repeatedly execute
    }
    1) initializer: to declare and initialize a local loop variable
    2) condition: to determine if it should execute the next iteration in the loop
    3) iterator: to define what happens after each execution of the body of the loop
    
7. What is the difference between the = and == operators?
    1) =: is the assignment operator for assigning the value on the right to the variable on the left (e.g. int a = 10;)
    2) ==: the equality check operator for checking if the two givn values are equal (True or False) (e.g. 10 == 10; //Output: True)

8. Does the following statement compile? for ( ; true; ) ;
    Yes. All of these three parts of a for statement are optional.
    If "for ( ; ; )" (for statement execute the empty), it will be the an infinite loop.

9. What does the underscore _ represent in a switch expression?
    The "underscore _" represents the "default" keyword that statements will execute when a match expression doesn't match any other case pattern.

10. What interface must an object implement to be enumerated over by using the foreach statement?
    IEnumerable and IEnumerator interface.
*/


//Practice loops and operators
//Q1:
//1) FizzBuzz
//public class FizzBuzz
//{
//    public static void Main()
//    {
//        int i = 1;

//        for (i = 1; i <= 100; i++)
//        {
//            if (i % 3 == 0)
//            {
//                Console.Write("/fizz/, ");
//            }
//            else if (i % 5 == 0)
//            {
//                Console.Write("/buzz/, ");
//            }
//            else if (i % 3 == 0 && i % 5 == 0)
//            {
//                Console.Write("/fizzbuzz/, ");
//            }
//            else
//            {
//                Console.Write($"{i}, ");
//            }
//        }
//    }
//}

//2) What will happen if this code executes?
/*
 * Create a console application and enter the preceding code. Run the console application and view the output. What happens?
    This code will display an error because "WriteLine(i)" doesn't exist.

 * What code could you add (don’t change any of the preceding code) to warn us about the problem?
    Add the try-catch statement as the following.
    int max = 500;
        for (byte i = 0; i < max; i++)
    {
        try
        {
            WriteLine(i);
        }
        catch { }
    }
*/

//3) Your program can create a random number between 1 and 3 with the following code:
//public class Guess
//{
//    public static void Main()
//    {
//        int correctNumber = new Random().Next(3) + 1;

//        Console.WriteLine("Please guess a number:");
//        int guessedNumber = int.Parse(Console.ReadLine());

//        if (guessedNumber == correctNumber)
//        {
//            Console.WriteLine("You get the correct answer!");
//        }
//        else if (guessedNumber > 3)
//        {
//            Console.WriteLine("You guess high and answer is outside of the range of numbers.");
//        }
//        else if (guessedNumber < 1)
//        {
//            Console.WriteLine("You guess low and answer is outside of the range of numbers.");
//        }
//        else if (guessedNumber >= 1 && guessedNumber <= 3)
//        {
//            if (guessedNumber > correctNumber)
//            {
//                Console.WriteLine("You guess high.");
//            }
//            else if (guessedNumber < correctNumber)
//            {
//                Console.WriteLine("You guess low.");
//            }
//        }

//        //Console.WriteLine(correctNumber);
//    }
//}


//Q2: Print-a-Pyramid
/*
line 1: 5 space, 0 start |1
line 2: 4 space, 1 start |----*2
line 3: 3 space, 3 start |---***3
line 4: 2 space, 5 start |--*****4
line 5: 1 space, 7 start |-*******5
line 6: 0 space, 9 start |*********6
*/
//public class Pyramid
//{
//    public static void Main()
//    {
//        int line;
//        int space;
//        int start;
//        for (line = 1 ; line < 6; line++)
//        {
//            Console.WriteLine(" ");

//            for (space = 0; space < 6 - line; space++)
//            {
//                Console.Write(" ");
//            }

//            for (start = 0; start < (line * 2)-1; start++)
//            {
//                Console.Write("*");
//            }

//        }
//    }
//}


//Q3: This question is the samw with Q1-3, so please see the Q1-3 to check the answer.


//Q4: defines a variable representing a birth date and calculates how many days old the person with that birth date is currently
//public class Birthdate
//{
//    public static void Main()
//    {
//        Console.WriteLine("When is your birthday?");
//        DateTime birthdate = DateTime.Parse(Console.ReadLine());

//        DateTime today = DateTime.Today;
//        int days = (today - birthdate).Days;
//        int ages = today.Year - birthdate.Year;
//        int daysToNextAnniversary = 10000 - (days % 10000);

//        Console.WriteLine($"You're {ages} years old.");
//        Console.WriteLine($"There are still {daysToNextAnniversary} to the date of your next 10,000 day (about 27 years) anniversary!");
//    }
//}


//Q5: greets the user using the appropriate greeting for the time of day
//public class Greets
//{
//    public static void Main()
//    {
//        //Console.WriteLine("Please tell us the time now using 24-hours clock from 0 to 23");
//        //int time = int.Parse(Console.ReadLine());

//        int time = (DateTime.Now).Hour;
//        int morning = 6;
//        int noon = 12;
//        int night = 18;

//        if (time >= morning && time < noon)
//        {
//            Console.WriteLine("Good Morning!");
//        }
//        else if (time >= noon && time < night)
//        {
//            Console.WriteLine("Good Afternoon!");
//        }
//        else if (time >= night)
//        {
//            Console.WriteLine("Good Evening");
//        }
//        else if (time < morning)
//        {
//            Console.WriteLine("Good Night");
//        }
//    }
//}

//Q6: counting up to 24 using four different increments
//public class Increments
//{
//    public static void Main()
//    {
//        int line;
//        int num;

//        for (line = 1; line < 5; line++)
//        {
//            Console.WriteLine();

//            for (num = 0; num <= 24; num += line)
//            {
//                if (num < 24)
//                {
//                    Console.Write($"{num}, ");
//                }
//                else
//                {
//                    Console.Write($"{num} ");
//                }
//            }
//        }
//    }
//}




