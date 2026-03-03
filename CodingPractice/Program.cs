using System;

// 1.
{
    object obj1 = 42;
    object obj2 = 3.14;
    object obj3 = "Hello";
    object obj4 = true;

    Console.WriteLine(obj1);
    Console.WriteLine(obj2);
    Console.WriteLine(obj3);
    Console.WriteLine(obj4);
}
Console.WriteLine();

// 2.
{
    Stack stack = new Stack();

    stack.Push("sausage");
    string str = (string)stack.Pop();
    Console.WriteLine(str);

    stack.Push(3);
    int num = (int)stack.Pop();
    Console.WriteLine(num);
}
Console.WriteLine();

// 3-1.
{
    int i = 1234;
    object o = i;

    Console.WriteLine(o);
}
Console.WriteLine();

// 3-2.
{
    object o = 1234;
    int i = (int)o;

    Console.WriteLine(i);
}
Console.WriteLine();

// 4-1.
{
    int i = 42;
    object o = i;

    Console.WriteLine(o);
}
Console.WriteLine();

// 4-2.
{
    Point p = new Point { X = 10, Y = 20 };
    IDisplayable d = p;
    Console.WriteLine(d.GetType().Name);
}
Console.WriteLine();

// 5.
{
    int i = 3;
    object o = i;
    i = 5;

    Console.WriteLine($"원본: {i}\n박싱된 값: {o}");
}
Console.WriteLine();

// 6.
{
    int i = 42;
    object o = i;

    int a = (int)o;
    Console.WriteLine($"언박싱 성공: {a}");

    try
    {
        long l = (long) o;
    }
    catch (InvalidCastException)
    {
        Console.WriteLine("잘못된 타입으로 언박싱 시도");
    }

    int j = (int) o;
    Console.WriteLine($"올바른 변환: {(long)j}");
}
Console.WriteLine();

// 7-1.
{
    int sum1 = 0;
    for (int i = 0; i <= 999; i++)
    {
        object boxed = i;
        sum1 += (int) boxed;
    }

    Console.WriteLine($"박싱 사용: {sum1}");

    int sum2 = 0;
    for (int i = 0; i <= 999; i++)
    {
        sum2 += i;
    }

    Console.WriteLine($"직접 처리: {sum2}");
}
Console.WriteLine();

// 7-2.
{
    GenericStack<int> intStack = new GenericStack<int>();

    intStack.Push(42);
    int value = intStack.Pop();

    Console.WriteLine(value);
}
Console.WriteLine();

// 8-1.
{
    int i = 1;
    string s = " ";
    char c = ' ';
    double d = 1.0;
    object o = new object();

    Console.WriteLine(i.GetType());
    Console.WriteLine(s.GetType());
    Console.WriteLine(c.GetType());
    Console.WriteLine(d.GetType());
    Console.WriteLine(o.GetType());
}
Console.WriteLine();

// 8-2.
{
    Console.WriteLine(typeof(int));
    Console.WriteLine(typeof(string));
    Console.WriteLine(typeof(double));
}
Console.WriteLine();

// 8-3.
{
    Point8 p = new Point8();

    Console.WriteLine(p.GetType().Name);
    Console.WriteLine(typeof(Point8).Name);
    Console.WriteLine(p.GetType() == typeof(Point8));

    Console.WriteLine(typeof(int).Name);
    Console.WriteLine(p.X.GetType());
}
Console.WriteLine();

// 9-1.
{
    int i = 42;
    double d = 3.14;
    bool b = true;

    Console.WriteLine(i.ToString());
    Console.WriteLine(d.ToString());
    Console.WriteLine(b.ToString());
}
Console.WriteLine();

// 9-2.
{
    Panda p = new Panda();
    Console.WriteLine(p);
}
Console.WriteLine();

// 9-3.
{
    Player p = new Player();
    Console.WriteLine(p);
}
Console.WriteLine();

// 10.
{
    string s1 = "Hello";
    string s2 = "Hello";
    string s3 = s1;
    Console.WriteLine($"s1.Equals(s2): {s1.Equals(s2)}");
    Console.WriteLine($"ReferenceEquals(s1, s2): {ReferenceEquals(s1, s2)}");
    Console.WriteLine($"ReferenceEquals(s1, s3): {ReferenceEquals(s1, s3)}");

    object obj1 = new object();
    object obj2 = new object();
    object obj3 = obj1;
    Console.WriteLine($"obj1.Equals(obj2): {obj1.Equals(obj2)}");
    Console.WriteLine($"ReferenceEquals(obj1, obj2): {ReferenceEquals(obj1, obj2)}");
    Console.WriteLine($"ReferenceEquals(obj1, obj3): {ReferenceEquals(obj1, obj3)}");
}

// 9-3.
class Player
{
    public string Name = "Hero";
    int Level = 10;
    int Health = 100;

    public override string ToString() => $"Player {{ Name = {Name}, Level = {Level}, Health = {Health} }}";

}

// 9-2.
class Panda
{
    public string Name = "Petey";

    public override string ToString() => Name;
}

// 8-3.
class Point8
{
    public int X, Y;
}

// 7-2.
class GenericStack<T>
{
    private T[] _items = new T[100];
    private int _top = 0;

    public void Push(T item)
    {
        _items[_top++] = item;
    }

    public T Pop()
    {
        return _items[--_top];
    }
}

// 4.
interface IDisplayable
{

}

struct Point : IDisplayable
{
    public int X;
    public int Y;
}

// 2.
class Stack
{
    object[] objects = new object[3];
    int index = 0;

    public void Push(object obj)
    {
        objects[index++] = obj;
    }

    public object Pop()
    {
        return objects[--index];
    }
}