using GenericTypes; //This namespace is associated with the project, GenericTypes

void Show<T>(NamedContainer<T> c)
{
    Console.WriteLine($"{c.Name}: {c.Item}");
}

void ShowMany<T>(IEnumerable<NamedContainer<T>> cs)
{
    foreach (NamedContainer<T> c in cs)
    {
        Show(c);
    }
}
//NamedContainer<int32>//, is the explicit type instead of using the var keyword
//var a = new NamedContainer<int>(42, "The answer");
NamedContainer<Int32> a = new NamedContainer<int>(42, "The answer");  //You do not have to specify the string type in angle brackets for the second argument
                                                                      //because you have specified string for the parameter in the constructor.
Console.WriteLine($"NamedContainer calls: {a.Counter}"); //1 because the generic type is int

var b = new NamedContainer<int>(99, "Number of red balloons");      //You do not have to specify string in the angle brackets for the second argument.

Console.WriteLine($"NamedContainer calls: {b.Counter}"); //2 because the generic type is int

var c = new NamedContainer<int>(99, "Number of red balloons");
Console.WriteLine($"NamedContainer calls: {c.Counter}"); //this is 3 because the generic type is int

var d = new NamedContainer<string>("Programming C#", "Book title"); //Because you changed the generic "T" from int to string, 
                                                                    //the _counter variable resets to 1 to reflect the new type.  
                                                                    

Console.WriteLine($"NamedContainer calls: {d.Counter}"); //this resets to 1 because the generic type changed from int to string.   


// ...where a, and b come from Example 4-3

//var namedInts = new List<NamedContainer<int>>() { a, b }; //Used explicit type instead of "var"; this means that the variable "namedInts" is a list of 
//NamedContainer objects with the argument type set to "int". So "a" is an "int" and "b" is a string.

//NamedInts is a List type that contains two already assigned NamedContainer instances                                   
    List<NamedContainer<int>> namedInts = new List<NamedContainer<int>>() { a, b }; //Creates a List object called namedInts with the results of a and b, which have
    Console.WriteLine($"NamedContainer calls: {a.Counter}"); //should still be 3    //already been assigned.  a = Item: 42, Name: "The answer", and
                                                                                    //b = Item: 99, Name: "Number of red balloons". A blank constructor is called
                                                                                 //on the NamedContainer because of the new keyword and the "()".
                                                                                 //This syntax uses object initialization to simply initialize the
                                                                                 //already assigned "a" and "b" arguments which are instances of the class
                                                                                 //"NamedContainer". If you look at the variable "namedInts" in the debugger you see
                                                                                 //it is comprised of the contents of variables "a" and "b", which are instances of
                                                                                 //objects with int "Item" and string "Name".  In instance a's case: 42, "The Answer"
                                                                                 //and instance b's case: 99, "Number of red balloons". 

var namedNamedItem = new NamedContainer<NamedContainer<int>>(a, "Wrapped"); //because you are passing an object: "NamedContainer" 
                                                                            //it can't be dereferenced to it's contents, 
                                                                            //so this writes the object name to the screen. 
Console.WriteLine($"NamedContainer calls: {namedNamedItem.Counter}"); //should be 1

Show(a);
Show(b);
Show(c);

ShowMany(namedInts);
Show(namedNamedItem);
