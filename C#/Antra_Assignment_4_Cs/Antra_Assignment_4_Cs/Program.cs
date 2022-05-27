// 04 Generics

/* Test your Knowledge
1. Describe the problem generics address.
    Type safety without creating many similar types.

2. How would you create a list of strings, using the generic List class?
    List<string> strs = new List<string>();

3. How many generic type parameters does the Dictionary class have?
    The Dictionary class has two generic type parameters.
    The key type and the value type.

4. True/False. When a generic class has multiple type parameters, they must all match.
    False.

5. What method is used to add items to a List object?
    Add.

6. Name two methods that cause items to be removed from a List.
    RemoveAt(): will allow us to remove items from the list.
    Clear(): will allow us to remove everything from the list.

7. How do you indicate that a class has a generic type parameter?
    In angle brackets by the class name: public class ClassName<T> {}

8. True/False. Generic classes can only have one generic type parameter.
    False.

9. True/False. Generic type constraints limit what can be used for the generic type.
    True.

10. True/False. Constraints let you use the methods of the thing you are constraining to.
    True.
 */






// Practice working with Generics
//Q1: Create a custom Stack class MyStack<T> that can be used with any data type which has following methods
//1. int Count(): to return the total count of elements in the Stack.
//2. T Pop(): to return the last element and removes it from a stack.
//3. Void Push(): to inserts an item at the top of the stack.


//Stack<int> MyStack = new Stack<int>();
//MyStack.Push(1); 
//MyStack.Push(5);   
//MyStack.Push(2);   
//MyStack.Push(7);   

//Console.WriteLine($"Now the number of in the MyStack: {MyStack.Count()}"); 
//Console.Write("Each number of in the MyStack: ");
//foreach (int var1 in MyStack)
//{
//    Console.Write($"{var1} ");
//}
//Console.WriteLine();

//if (MyStack.Count > 0)
//{
//    Console.WriteLine($"If count > 0, the last number is: {MyStack.Pop()}");
//    Console.WriteLine($"See the number of in the MyStack again: {MyStack.Count()}");
//    Console.Write("Each number of in the MyStack after remving last number: ");
//    foreach (int var2 in MyStack)
//    {
//        Console.Write($"{var2} ");
//    }
//}






//Q2: Create a Generic List data structure MyList<T> that can store any data type. Implement the following methods.
//1. void Add(T element) : to add elements using add() method
//2. T Remove(int index) : Use the Remove() method to remove the first occurrence of the specified element in the List<T> collection. (bool Remove(T item))
//3. bool Contains(T element) : to determine whether an element is in the List<T> or not.
//4. void Clear() : to remove all the elements from a List<T>.
//5. void InsertAt(T element, int index) : inserts an element into the List<T> collection at the specified index. (void Insert(int index, T item);)
//6. void DeleteAt(int index): Use the RemoveAt() method to remove an element from the specified index. (void RemoveAt(int index))
//7.T Find(int index): to find the first element based on the specified predicate function.


//List<string> MyList = new List<string>();
//MyList.Add("Dog");
//MyList.Add("Cat");
//MyList.Add("Bird");
//MyList.Add("Fish");
//MyList.Add("Bear");
//Console.WriteLine("Print all items in this List: ");
//foreach (string var1 in MyList)
//{
//    Console.Write($"{var1} ");
//}
//Console.WriteLine();

//MyList.Insert(2, "Dolphin");   //to add "Dolphin" at the 3st index
//Console.WriteLine("Print all items in this List after adding Dolphin at the 3st index: ");
//foreach (string var2 in MyList)
//{
//    Console.Write($"{var2} ");
//}
//Console.WriteLine();

//MyList.RemoveAt(0);   //to remove the 1st element
//MyList.Remove("Fish");   //to remove "Fish"
//Console.WriteLine("Print all items in this List after removing the 1st index and Fish: ");
//foreach (string var3 in MyList)
//{
//    Console.Write($"{var3} ");
//}
//Console.WriteLine();

////to determine if following animals are still in the list.
//Console.WriteLine($"Is it Dog still in the list? {MyList.Contains("Dog")}");
//Console.WriteLine($"Is it Dolphin still in the list? {MyList.Contains("Dolphin")}");
//Console.WriteLine($"Is it Cat still in the list? {MyList.Contains("Cat")}");
//Console.WriteLine($"Is it Fish still in the list? {MyList.Contains("Fish")}");

////to find items where name contains "Bear".
//Console.WriteLine($"Where does a name contain Bear? {MyList.Find(x => x == "Bear")}");

//MyList.Clear();   //to remove all the elements from a list
//Console.WriteLine("Print all items in this List after clearing: ");
//foreach (string var4 in MyList)
//{
//    Console.Write($"{var4} ");
//}
//Console.WriteLine();






//Q3: Implement a GenericRepository<T> class
//1. void Add(T item)
//2. void Remove(T item)
//3. Void Save()
//4. IEnumerable < T > GetAll()
//5. T GetById(int id)


using Antra_Assignment_4_Cs.Presentation;

ProductManage manageProduct = new ProductManage();
manageProduct.Run();

