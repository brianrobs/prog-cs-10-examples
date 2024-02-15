using GenericTypes; //This namespace is associated with the project, GenericTypes

//void Show<T>(NamedContainer<T> c)
//{
//    Console.WriteLine($"{c.Name}: {c.Item}");
//}

//void ShowMany<T>(IEnumerable<NamedContainer<T>> cs)
//{
//    foreach (NamedContainer<T> c in cs)
//    {
//        Show(c);
//    }
//}
//NamedContainer<int32>//, is the explicit type instead of using the var keyword
//var a = new NamedContainer<int>(42, "The answer");
NamedContainer<Int32,string> a = new NamedContainer<int,string>(42, "The answer");  //You do not have to specify the string type in angle brackets for the second argument
                                                                      //because you have specified string for the parameter in the constructor.
Console.WriteLine($"NamedContainer calls: {a.Counter}"); //should be 1
                                                                      
var b = new NamedContainer<int,string>(99, "Number of red balloons");      //You do not have to specify string in the angle brackets for the second argument.
Console.WriteLine($"NamedContainer calls: {b.Counter}"); //should be 2

var c = new NamedContainer<int,string>(99, "Number of red balloons");
Console.WriteLine($"NamedContainer calls: {c.Counter}"); //this is 3, why and why would it not be? 

var d = new NamedContainer<string,string>("Programming C#", "Book title"); //You do not have to specify int, in the angle brackets for the first argument,
                                                                    //the compiler will assume as much because this example tells the compiler that
                                                                    //the first generic "T" argument is a string, and the constructor takes the generic "T"
                                                                    //and makes the parameter a string. Therefore the generic "T" is where the compiler makes
                                                                    //the assocation and assigns the argument and parameter to a string type.

Console.WriteLine($"NamedContainer calls: {d.Counter}"); //this is 4 now. <explanation>  

// ...where a, and b come from Example 4-3

//var namedInts = new List<NamedContainer<int>>() { a, b }; //Used explicit type instead of "var"; this means that the variable "namedInts" is a list of 
//NamedContainer's with the argument type set to "int". So "a" is an "int" and "b" is a string.

//NamedInts is a List type that contains two already assigned NamedContainer instances                                   
List<NamedContainer<int,string>> namedInts = new List<NamedContainer<int,string>>() { a, b }; //Creates a List object called namedInts with the results of a and b, which have
Console.WriteLine($"NamedContainer calls: {a.Counter}"); //should still be 3    //already been assigned.  a = Item: 42, Name: "The answer", and
                                                                                //b = Item: 99, Name: "Number of red balloons". The constructor is not called
                                                                                //on the NamedContainer, because it does not exist, hence the empty
                                                                                //"()" constructor. This syntax uses object initialization to simply initialize the
                                                                                //already assigned "a" and "b" arguments which are instances of the class
                                                                                //"NamedContainer". If you look at the variable "namedInts" in the debugger you see
                                                                                //it is comprised of the contents of variables "a" and "b", which are instances of
                                                                                //objects with int "Item" and string "Name".  In instance a's case: 42, "The Answer"
                                                                                //and instance b's case: 99, "Number of red balloons". 

var namedNamedItem = new NamedContainer<NamedContainer<int,string>,string>(a, "Wrapped"); //Calls the constructor within the class NamedContainer
Console.WriteLine($"NamedContainer calls: {namedNamedItem.Counter}"); //should be 4

//Show(a);
//Show(b);
//Show(c);

//ShowMany(namedInts);
//Show(namedNamedItem);
