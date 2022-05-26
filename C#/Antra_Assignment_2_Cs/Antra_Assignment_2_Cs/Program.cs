// 02 Arrays and Strings

/* Test your Knowledge
1. When to use String vs. StringBuilder in C# ?
    1) Since the string is immutable, so it is good to use when we will not change a string throughout the program. E.g., username, password...
    2) Since StringBuilder is mutable, so it is good to use when we may change a string throughout the program.

2. What is the base class for all arrays in C#?
    The "Array class" is the base class for all arrays in C#.
    Reference: https://www.tutorialspoint.com/csharp/csharp_array_class.htm

3. How do you sort an array in C#?
    We can sort a one-dimensional array in two ways, using Array.Sort() method and using LINQ query.
    Reference: https://www.tutorialsteacher.com/articles/sort-array-in-csharp

4. What property of an array object can be used to get the total number of elements in an array?
    Array.Length Property
    Reference: https://docs.microsoft.com/en-us/dotnet/api/system.array.length?view=net-6.0

5. Can you store multiple data types in System.Array?
    No, we cannot store multiple data types in an Array
    Reference: http://net-informations.com/faq/netfaq/multipledata.htm

6. What’s the difference between the System.Array.CopyTo() and System.Array.Clone()?
    1) The System.Array.Clone() creates a new array (a shallow copy) object containing all the elements in the original array.
    2) The System.Array.CopyTo() copies all the elements of the current one-dimensional array to the specified one-dimensional array.
    Reference: https://docs.microsoft.com/en-us/dotnet/api/system.array.clone?view=net-6.0
    Reference: https://docs.microsoft.com/en-us/dotnet/api/system.array.copyto?view=net-6.0
*/






// Practice Arrays

//Q1: Copying an Array
using System;
using System.Text;

//public class Array
//{
//    public static void Main()
//    {
//        //create an initial array with 10 items
//        string[] arryTypes = { "sbyte", "byte", "short", "ushort", "int", "uint", "long", "ulong", "float", "double" };

//        //create a second array variable with the same length as the first
//        string[] arrycopy = new string[arryTypes.Length];

//        //Use a loop to read values from the original array and place them in the new array
//        int i;
//        for (i = 0; i < arryTypes.Length; i++)
//        {
//            arrycopy[i] = arryTypes[i];
//        }

//        Console.WriteLine($"Length of Array for dataTypes: {arryTypes.Length}");
//        Console.Write($"dataTypes: ");
//        foreach (string arr in arryTypes)
//        {
//            Console.Write($"{arr} ");
//        }
//        Console.WriteLine();

//        Console.WriteLine($"Length of Array for copyArry: {arrycopy.Length}");
//        Console.Write($"copyArry: ");
//        foreach (string arr in arrycopy)
//        {
//            Console.Write($"{arr} ");
//        }
//    }
//}


//Q2: manage a list of elements.
//List<string> AddList = new List<string>();
//while (true)
//{
//    Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
//    String input = Console.ReadLine();

//    Console.WriteLine($"List:");
//    if (input.Substring(0,2) == "+ ")
//    {
//        AddList.Add(input.Substring(2));  
//    }
//    else if (input.Substring(0,2) == "- ")
//    {
//        AddList.Remove(input.Substring(2));    
//    }
//    else if (input.Substring(0, 2) == "--")
//    {
//        AddList.Clear();
//    }

//    foreach (string arr in AddList)
//    {
//        Console.WriteLine($"{arr} ");
//    }

//}


//Q3: prime numbers
//public class PrimeNumbers
//{
//    public static void Main()
//    {
//        Console.WriteLine("Please enter a start number: ");
//        int start = int.Parse(Console.ReadLine());
//        Console.WriteLine("Please enter an end number: ");
//        int end = int.Parse(Console.ReadLine());
//        int[] primes = FindPrimesInRange(start, end);

//        Console.WriteLine("Prime numbers: ");
//        foreach (int num in primes)
//        {
//            Console.Write($"{num} ");
//        }

//    }

//    //function of prime numbers
//    static int[] FindPrimesInRange(int startNum, int endNum)
//    {
//        List<int> AddList = new List<int>();
//        for (int i = startNum; i <= endNum; i++)
//        {
//            int j;
//            for (j = 2; j <= i - 1; j++)
//            {
//                if (i % j == 0)
//                {
//                    break;
//                }
//            }

//            if (j == i)
//            {
//                AddList.Add(j);
//            }
//        }
//        return AddList.ToArray();
//    }

//}


//Q4:
//Console.WriteLine("Please enter an array of n integers separated by a space: ");
//string input = Console.ReadLine();
//string[] list = input.Split(" ");   //Split a string to an string array
//int[] nums = Array.ConvertAll(list, n => int.Parse(n));   //Convert a string array to an int array

//Console.WriteLine("Please enter an integer: ");
//int rotate = int.Parse(Console.ReadLine());

//int[] rotated = new int[nums.Length];   //create a new array
//int[] sum = new int[nums.Length];   //create a new array
//for (int r = 1; r <= rotate; r++)   //for checking k times
//{
//    for (int l = 0; l <= nums.Length - 1; l++)   //for checking position l
//    {
//        int newl = (l + r) % nums.Length;
//        rotated[newl] = nums[l];   //convert num to a new array with at new position
//        sum[newl] = sum[newl] + rotated[newl];
//    }   
//}

//Console.WriteLine("Output");
//foreach (int ans in sum)
//{
//    Console.Write($"{ans} ");
//}


//Q5: the longest sequence of equal elements
//Console.WriteLine("Please enter an array of n positive integers separated by a space: ");
//string input = Console.ReadLine();
//string[] list = input.Split(" ");

//int[] nums = Array.ConvertAll(list, n => int.Parse(n));

//int longest = 1;
//int longest_num = nums[0];
//int loop_longest = 1;
////int loop_longest_num = nums[0];

//for (int l = 1; l <= nums.Length - 1; l++)
//{
//    if (nums[l] == nums[l-1])
//    {
//        loop_longest++;
//    }
//    else
//    {
//        loop_longest = 1;
//    }

//    if (loop_longest > longest)
//    {
//        longest = loop_longest;
//        longest_num = nums[l];
//    }
//}

//Console.WriteLine("Output: ");
//for (int r = 1; r <= longest; r++)   //check longest timw to print output
//{
//    Console.Write($"{longest_num} ");
//}


//Q7: the most frequent number in a given sequence of numbers
//Console.WriteLine("Please enter an array of n positive integers separated by a space: ");
//string input = Console.ReadLine();
//string[] list = input.Split(" ");
//int[] nums = Array.ConvertAll(list, n => int.Parse(n));

//int freNum = nums[0];
//int freTimes = 0;
//int maxFreNum = nums[0];
//int maxFreTimes = 0;

//for (int l = 0; l <= nums.Length - 1; l++)
//{
//    freTimes = 0;
//    for (int n = 0; n <= nums.Length - 1; n++)
//    {
//        if (nums[n] == nums[l])
//        {
//            freTimes++;
//        }

//        if (freTimes > maxFreTimes)
//        {
//            maxFreTimes = freTimes;
//            maxFreNum = nums[l];
//        }
//    }
//}

//Console.WriteLine("Output: ");
//Console.WriteLine($"The most frequent number is {maxFreNum} (occurs {maxFreTimes} times).");






// Practice Strings

//Q1:
//Way 1:
//Console.WriteLine("Please enter a string: ");
//string input = Console.ReadLine();
//char[] characters = input.ToCharArray();   //Convert the string to char array
//Array.Reverse(characters);   //reverse it
//string convertedString = new string(characters);   //convert it to string again
//Console.WriteLine("Output: ");
//Console.WriteLine(convertedString);

//Way 2:
//Console.WriteLine("Please enter a string: ");
//string input = Console.ReadLine();
//for (int i = input.Length - 1; i >= 0; i--)
//{
//    Console.Write(input[i]);
//}


//Q2:
//Console.WriteLine("Please enter a string: ");
//string input = Console.ReadLine();
//string[] inputs = input.Split(" ");
//string ans = "";
//for (int i = inputs.Length - 1; i >=0; i--)
//{
//    ans += inputs[i] + " ";
//}
//Console.Write("Reversed String:\n");
//Console.Write(ans.Substring(0, ans.Length - 1));


//Q3:
//Console.WriteLine("Please enter a string: ");
//string input = Console.ReadLine();
//string[] inputs = input.Split(new char[] {' ', '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '"', '\'', '\\', '/', '!', '?'});
//List<string> palindromes = new List<string>();
//foreach (string inp in inputs)
//{
//    char[] ch = inp.ToCharArray();
//    Array.Reverse(ch);
//    string rev = new string(ch);
//    if (inp != "" && inp == rev)
//    {
//        palindromes.Add(inp);
//    }
//}
//palindromes.Sort();
//var unique = palindromes.Distinct();
//Console.WriteLine(String.Join(", ", unique));


//Q4:
Console.WriteLine("Please enter a string: ");
string input = Console.ReadLine();
string newinput = input.Replace("://", " ");
string[] inputs;
string protocol = "";
string server = "";
string resource = "";
if (input.Contains("://"))
{
    inputs = newinput.Split(" ");
    protocol = inputs[0];
    newinput = inputs[1];
}
if (newinput.Contains("/"))
{
    inputs = newinput.Split("/");
    resource = inputs.Last();
    newinput = inputs[0];
}
inputs = newinput.Split(" ");
server = inputs[0];

Console.WriteLine($"[protocol] = \"{protocol}\"");
Console.WriteLine($"[server] = \"{server}\"");
Console.WriteLine($"[resource] = \"{resource}\"");





