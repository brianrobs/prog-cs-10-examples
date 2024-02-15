using GenericTypes.Records;
using System.Reflection;

namespace GenericTypes;

public class NamedContainer<T> //The T is the type at the class level, and
                               //can be used anywhere in the class definition.    

{
    static private int _counter;
    public NamedContainer(T item, string name) //The constructor for this Class
    {
        _counter++;
        Item = item;
        Name = name;
    }

    public T Item { get; }
    public string Name { get; }
    public int Counter { get => _counter; }
}

//public class NamedContainer //The T is the type at the class level, and
//                               //can be used anywhere in the class definition.    
//{
//    static private int _counter;
//    private int _t;

//    public NamedContainer() { }
//    public void CalculateNamedContainer(T item, string name) //The constructor for this Class
//    {
//        _counter++;
//        Item = item;
//        Name = name;
//    }

//    public T Item { get => _t; }
//    public string Name { set; get; }
//    public int Counter { get => _counter; }
//}
//public class NamedContainer
//{
//    static private int _counter;
//    public NamedContainer() //The constructor for this base class which is invoked from the inheriting class first.
//    {
//        _counter++;
//    }
//    public int Counter { get => _counter; }
//}

//public class NamedContainer<T> : NamedContainer
//{
//    public NamedContainer(T item, string name) //The constructor for the generic class, first calls the inherited base class
//    {
//        Item = item;
//        Name = name;
//    }

//    public T Item { get; }
//    public string Name { get; }
//}