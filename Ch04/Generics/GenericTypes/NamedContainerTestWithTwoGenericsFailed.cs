namespace GenericTypes;
public class NamedContainer<T,E> //The T is the type at the class level, and
                               //can be used anywhere in the class definition.    

{
    static private int _counter;
    public NamedContainer(T item, E name) //The constructor for this Class
    {
        _counter++;
        Item = item;
        Name = name;
    }

    public T Item { get; }
    public E Name { get; }
    public int Counter { get => _counter; }
}

//public class NamedContainer
//{
//    static private int _counter;
//    public NamedContainer()
//    {
//        _counter++;
//    }
//    public int Counter { get => _counter; }
//}

//public class NamedContainer<T> : NamedContainer
//{
//    public NamedContainer(T item, string name) //The constructor for this Class
//    {
//        Item = item;
//        Name = name;
//    }

//    public T Item { get; }
//    public string Name { get; }
//}

