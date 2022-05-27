// 03 Object-Oriented Programming

/* Test your knowledge
1. What are the six combinations of access modifier keywords and what do they do?
    1) public: member can be accessed anywhere
    2) proptected: member can be accessed in the current class and its children classes
    3) internal: member can be accessed in the current assembly
    4) private: member can only be accessed in the current class
    5) protected internal: member can be accessed only in the same assembly or in a derived class in other assemblies.
    6) private protected: member can be accessed inside the containing class or in a class that derives from a containing class, but only in the same assembly(project).
    Reference: https://www.tutorialspoint.com/what-are-different-types-of-access-modifiers-available-in-chash

2. What is the difference between the static, const, and readonly keywords when applied to a type member?
    1) The Const keyword can be applied to built-in value types (byte, short, int, long, char, float, double, decimal, bool), enum, a string literal, or a reference type which can be assigned with the value null.
    2) The Readonly keyword can be applied to a value type and reference type (which initialized by using the new keyword) both. Also, the delegate and event could not be readonly.
    3) The Static keyword can be used with classes, fields, methods, properties, operators, events, and constructors, but it cannot be used with indexers, destructors, or types other than classes.
    Reference: https://www.dotnettricks.com/learn/csharp/difference-between-constant-and-readonly-and-static

3. What does a constructor do?
    1) Constructor is a special method which shares the same name of the class and doesn't have any return type, not even void.
    2) Constructor is used to create an object of the class and initialize class members.
    3) If there is no constructor in the class, c# compiler will provide a default constructor.
    4) If we create any constructor ourselves, the default constructor will be replaced.
    5) Constructor can be overloaded.
    6) Constructor cannot be inherited, so a constructor cannot be overriden.
    7) By default, the derived class constructor will make a call the the base class constructor.

4. Why is the partial keyword useful?
    The partial keyword indicates that other parts of the class, struct, or interface can be defined in the namespace.
    Therefore, it can help developers to work on the same project with splitting the files on the same time.
    Reference: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/partial-classes-and-methods
    Reference: https://www.simplilearn.com/tutorials/c-sharp-tutorial/partial-class-in-c-sharp

5. What is a tuple?
    The tuples feature provides concise syntax to group multiple data elements in a lightweight data structure.
    Reference: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/value-tuples

6. What does the C# record keyword do?
    To define a reference type that provides built-in functionality for encapsulating data.
    Reference: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/record

7. What does overloading and overriding mean?
    1) Overloading: Methods in same class share the same method name, but different input parameters.
    2) Overriding: Methods in base class and its subclasses share the same method name and same input parameters.
    Reference: https://www.educative.io/edpresso/overloading-vs-overriding

8. What is the difference between a field and a property?
    1) A field is a variable of any type that is declared directly in a class.
       A property is a member that provides a flexible mechanism to read, write or compute the value of a private field.
    2) Usage: A field can be used to explain the characteristics of an object or a class.
              A property can be used to set and receive values of a field.
    Reference: https://www.differencebetween.com/difference-between-field-and-vs-property-in-c/

9. How do you make a method parameter optional?
    1) Use Parameter arrays
    2) Default parameter
    3) Use OptionalAttribute
    4) Method Overloading
    Reference: https://www.c-sharpcorner.com/article/make-parameter-optional-in-c-sharp/

10. What is an interface and how is it different from abstract class?
    Interface is a collection of methods which are by default abstract and public, and will be implemented by the derived class.

    1) Abstract class provides a base class to its subclasses -- use when we have a clear class hierachy
       Interface defines common behaviors / functionalities that can be implemented by any classes -- work as a contract
    2) One class can only inherit from one parent class, but one class can implement multiple interfaces
    3) Methods in abstract class can be abstract methods or non-abstract methods, but methods in interfaces are by default abstract

11. What accessibility level are members of an interface?
    public.

12. True/False. Polymorphism allows derived classes to provide different implementations of the same method.
    True.

13. True/False. The override keyword is used to indicate that a method in a derived class is providing its own implementation of a method.
    True.

14. True/False. The new keyword is used to indicate that a method in a derived class is providing its own implementation of a method.
    False.

15. True/False. Abstract methods can be used in a normal (non-abstract) class.
    False.

16. True/False. Normal (non-abstract) methods can be used in an abstract class.
    True.

17. True/False. Derived classes can override methods that were virtual in the base class.
    True.

18. True/False. Derived classes can override methods that were abstract in the base class.
    True.

19. True/False. In a derived class, you can override a method that was neither virtual non abstract in the base class.
    False.

20. True/False. A class that implements an interface does not have to provide an implementation for all of the members of the interface.
    False.

21. True/False. A class that implements an interface is allowed to have other members that aren’t defined in the interface.
    True.

22. True/False. A class can have more than one base class.
    False.

23. True/False. A class can implement more than one interface.
    True.
*/



// Working with methods

//Q1: 
//public static class Task1
//{

//    static void Main(string[] args)
//    {
//        //to call methods
//        int[] numbers = GenerateNumbers(10);
//        PrintNumbers(numbers, "10 random integer values: ");
//        Reverse(numbers);
//        PrintNumbers(numbers, "The array after reversing: ");

//    }

//    public static int[] GenerateNumbers(int count)
//    {
//        //to instantiate random number generator
//        var rand = new Random();

//        //to create the array of n numbers between 0 and 100
//        int[] numbers = new int[count];
//        for (int n = 0; n < count; ++n)
//        {
//            numbers[n] = rand.Next(1, 100);
//        }
//        return numbers;
//    }

//    public static void Reverse(int[] numbs)
//    {
//        //to reverse the sort of the values of the array
//        Array.Reverse(numbs);
//    }

//    public static void PrintNumbers(int[] pnumbs, string title)
//    {
//        // to print the array at the end
//        Console.WriteLine(title);
//        foreach (int num in pnumbs)
//        {
//            Console.Write($"{num} ");
//        }
//        Console.WriteLine();

//    }
//}


//Q2: The Fibonacci sequence: 1 1 2 3 5 8 13 21 34 55

//public static class Task2
//{
//    public static void Main(string[] args)
//    {
//        Fibonacci(10);
//    }


//    //to create a method called Fibonacci
//    public static void Fibonacci(int count)
//    {
//        int[] fibonacci = new int[count];
//        int a = 0;
//        int b = 1;
//        int c = 0;
//        Console.Write($"{1} ");
//        for (int n = 1; n <= count-1; n++)
//        {
//            c = a + b;
//            Console.Write($"{c} ");
//            a = b;
//            b = c;

//        }
//    }

//}




// Designing and Building Classes using object-oriented principles

//Q1: use of four basic principles of object-oriented programming
//// Abstract class "House"
//public abstract class House
//{
//    public House()
//    {

//    }
//    public int Id { get; set; }
//    public int RoomNum { get; set; }
//    public int Baths { get; set; }
//    public int Windows { get; set; }

//    // Abstract method & Polymorphism
//    public abstract void HouseType();

//    //Encapsulation
//    private string address;
//    public string Address
//    {
//        get { return address; }
//        set { address = value; }
//    }

//}

//public class Condo : House   //Inheritance
//{

//    public int FloorNumber { get; set; }

//    //Polymorphism
//    public override void HouseType()
//    {
//        Console.WriteLine("Condo");
//    }

//}

//public class TownHouse : House   //Inheritance
//{
//    public int TotalFloors { get; set; }
//    public int Garage { get; set; }
//    public bool Driveway { get; set; }

//    //Polymorphism
//    public override void HouseType()
//    {
//        Console.WriteLine("TownHouse");
//    }
//}



//Q2: Abstraction
////Abstraction class
//public abstract class SchoolPeopleType
//{
//    public int Id { get; set; }
//    public bool Gender { get; set; }
//    private string fullName;
//    private string phone;

//    // Abstraction method
//    public abstract void PeopleType();

//}

//public class Instructors
//{
//    public int Id { get; set; }
//    public bool Gender { get; set; }
//    private string fullName;
//    private string phone;
//    public string Deportment { get; set; }
//    public int TeachClassNum { get; set; }
//    public int TeachTotalhours { get; set; }
//    private decimal salary;

//    public override void PeopleType()
//    {
//        Console.WriteLine("Instructor");
//    }

//}

//public class Students
//{
//    public int Id { get; set; }
//    public bool Gender { get; set; }
//    private string fullName;
//    private string phone;
//    public string Major { get; set; }
//    public int Credits { get; set; }
//    private double gpa;

//    public override void PeopleType()
//    {
//        Console.WriteLine("Student");
//    }
//}



//Q3: Encapsulation
//// Abstraction class
//public abstract class SchoolPeopleType
//{
//    public int Id { get; set; }
//    public bool Gender { get; set; }
//    //Encapsulation
//    //private variables declared these can only be accessed by public methods of class
//    private string fullName;
//    private string phone;

//    //using accessors to get and set the value of studentName
//    public string FullName
//    {
//        get { return fullName; }
//        set { fullName = value; }
//    }

//   public string Phone
//    {
//        get { return phone; }
//        set { phone = value; }
//    }


//    // Abstraction method
//    public abstract void PeopleType();

//}

//public class Instructors
//{
//    public int Id { get; set; }
//    public bool Gender { get; set; }
//    //Encapsulation
//    private string fullName;
//    private string phone;

//    public string FullName
//    {
//        get { return fullName; }
//        set { fullName = value; }
//    }

//    public string Phone
//    {
//        get { return phone; }
//        set { phone = value; }
//    }

//    public string Deportment { get; set; }
//    public int TeachClassNum { get; set; }
//    public int TeachTotalhours { get; set; }

//    //Encapsulation
//    private decimal salary;
//    public decimal Salary
//    {
//        get { return salary; }
//        set { salary = value; }
//    }


//    public override void PeopleType()
//    {
//        Console.WriteLine("Instructor");
//    }

//}

//public class Students
//{
//    public int Id { get; set; }
//    public bool Gender { get; set; }
//    //Encapsulation
//    private string fullName;
//    private string phone;

//    public string FullName
//    {
//        get { return fullName; }
//        set { fullName = value; }
//    }

//    public string Phone
//    {
//        get { return phone; }
//        set { phone = value; }
//    }

//    public string Major { get; set; }
//    public int Credits { get; set; }

//    //Encapsulation
//    private double gpa;
//    public double Gpa
//    {
//        get { return gpa; }
//        set { gpa = value; }
//    }


//    public override void PeopleType()
//    {
//        Console.WriteLine("Student");
//    }
//}



//Q4: Inheritance
//// Abstraction class
//public abstract class SchoolPeopleType
//{
//    public int Id { get; set; }
//    public bool Gender { get; set; }
//    //Encapsulation
//    //private variables declared these can only be accessed by public methods of class
//    private string fullName;
//    private string phone;

//    //using accessors to get and set the value of studentName
//    public string FullName
//    {
//        get { return fullName; }
//        set { fullName = value; }
//    }

//    public string Phone
//    {
//        get { return phone; }
//        set { phone = value; }
//    }


//    // Abstract method
//    public abstract void PeopleType();

//}

//public class Instructors : SchoolPeopleType   //Inheritance
//{
//    public string Deportment { get; set; }
//    public int TeachClassNum { get; set; }
//    public int TeachTotalhours { get; set; }

//    //Encapsulation
//    private decimal salary;
//    public decimal Salary
//    {
//        get { return salary; }
//        set { salary = value; }
//    }


//    public override void PeopleType()
//    {
//        Console.WriteLine("Instructor");
//    }

//}

//public class Students : SchoolPeopleType   //Inheritance
//{
//    public string Major { get; set; }
//    public int Credits { get; set; }
//    //Encapsulation
//    private double gpa;
//    public double Gpa
//    {
//        get { return gpa; }
//        set { gpa = value; }
//    }


//    public override void PeopleType()
//    {
//        Console.WriteLine("Student");
//    }
//}



//Q5: Polymorphism
//// Abstraction class
//public abstract class SchoolPeopleType
//{
//    public int Id { get; set; }
//    public bool Gender { get; set; }
//    //Encapsulation
//    //private variables declared these can only be accessed by public methods of class
//    private string fullName;
//    private string phone;

//    //using accessors to get and set the value of studentName
//    public string FullName
//    {
//        get { return fullName; }
//        set { fullName = value; }
//    }

//    public string Phone
//    {
//        get { return phone; }
//        set { phone = value; }
//    }


//    // Abstract method
//    public abstract void PeopleType();

//    //Polymorphism with virtual methods
//    public virtual void Note()
//    {
//        Console.WriteLine("They are all able to join school's activities.");
//    }

//}

//public class Instructors : SchoolPeopleType   //Inheritance
//{
//    public string Deportment { get; set; }
//    public int TeachClassNum { get; set; }
//    public int TeachTotalhours { get; set; }

//    //Encapsulation
//    private decimal salary;
//    public decimal Salary
//    {
//        get { return salary; }
//        set { salary = value; }
//    }

//    //Polymorphism
//    public override void PeopleType()
//    {
//        Console.WriteLine("Instructor");
//    }

//    //Polymorphism with override methods
//    public override void Note()
//    {
//        Console.WriteLine("Instructors need to attend weekly meetings.");
//    }

//}

//public class Students : SchoolPeopleType   //Inheritance
//{
//    public string Major { get; set; }
//    public int Credits { get; set; }
//    //Encapsulation
//    private double gpa;
//    public double Gpa
//    {
//        get { return gpa; }
//        set { gpa = value; }
//    }

//    //Polymorphism
//    public override void PeopleType()
//    {
//        Console.WriteLine("Student");
//    }

//    //Polymorphism with override methods
//    public override void Note()
//    {
//        Console.WriteLine("Students need to attend classes on time.");
//    }

//}



//Q6: interfaces
//public interface ICourseService
//{
//    int ClassId();
//    string ClassName();
//}

//public class Course : ICourseService
//{
//    int ICourseService.ClassId()
//    {
//        throw new NotImplementedException();
//    }

//    string ICourseService.ClassName()
//    {
//        throw new NotImplementedException();
//    }

//    public string Teacher { get; set; }
//    public string? EnrolledStudents { get; set; }
//}



//Q7: 
//public class Color
//{

//    public int red { get; set; }
//    public int green { get; set; }
//    public int blue { get; set; }
//    public int alpha { get; set; }

//    //Constructor
//    public Color (int redValue, int greenValue, int blueValue, int alphaValue = 255)
//    {
//        red = redValue;
//        green = greenValue;
//        blue = blueValue;
//        alpha = alphaValue;

//    }

//    //Method
//    public int getGrayscale()
//    {
//        int grayscale = (red + green + blue) / 3;

//        return grayscale;
//    }

//}



//public class Ball
//{
//    public int size { get; set; }
//    public int thrown { get; set; }
//    public Color color { get; set; }

//    //Constructor
//    public Ball (int sizeValue, int thrownValue, Color colorValue)
//    {
//        size = sizeValue;
//        thrown = thrownValue;
//        color = colorValue;
//    }

//    //Pop Method
//    public void Pop()
//    {
//        size = 0;
//    }

//    //Throw Method
//    public void Throw()
//    {
//        thrown += 1;

//        if (size == 0)
//        {
//            thrown -= 1;
//        }
//    }

//    //A Method
//    public int Number()
//    {
//        int num = thrown;
//        return num;
//    }


//    public static void Main()
//    {
//        //to call Constructor
//        Color c1 = new Color(0, 10, 5);
//        Color c2 = new Color(1, 21, 5, 100);
//        Console.WriteLine(c1.getGrayscale());
//        Console.WriteLine(c2.getGrayscale());

//        //to call Constructor
//        //create a few balls
//        Ball p1 = new Ball(3, 2, c1);
//        Ball p2 = new Ball(2, 2, c1);
//        Ball p3 = new Ball(1, 2, c2);
//        //throw them around a few times
//        p1.Throw();
//        p1.Throw();
//        p1.Throw();
//        p2.Throw();
//        p2.Throw();
//        p3.Throw();
//        p3.Throw();
//        p3.Throw();
//        p3.Throw();
//        //pop a few
//        p1.Pop();
//        p3.Pop();
//        //try to throw them again
//        p1.Throw();
//        p2.Throw();
//        p2.Throw();
//        p3.Throw();
//        p3.Throw();
//        // print out the number of times that the balls have been thrown
//        Console.WriteLine(p1.Number());
//        Console.WriteLine(p2.Number());
//        Console.WriteLine(p3.Number());
//    }


//}





