Day22_Programs211-220

---

Program211_ClassWithConstructor.cs

```csharp
using System;

class Person
{
    public string Name;

    public Person(string name)
    {
        Name = name;
    }

    public void Display()
    {
        Console.WriteLine("Name: " + Name);
    }
}

class Program211_ClassWithConstructor
{
    static void Main()
    {
        Person p = new Person("Yash");
        p.Display();
    }
}
```

---

Program212_StaticClassExample.cs

```csharp
using System;

static class Utility
{
    public static int Square(int x)
    {
        return x * x;
    }
}

class Program212_StaticClassExample
{
    static void Main()
    {
        Console.WriteLine(Utility.Square(5));
    }
}
```

---

Program213_InterfaceExample.cs

```csharp
using System;

interface IShape
{
    void Draw();
}

class Circle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing Circle");
    }
}

class Program213_InterfaceExample
{
    static void Main()
    {
        IShape shape = new Circle();
        shape.Draw();
    }
}
```

---

Program214_MultipleInterface.cs

```csharp
using System;

interface IPrint
{
    void Print();
}

interface IScan
{
    void Scan();
}

class Machine : IPrint, IScan
{
    public void Print()
    {
        Console.WriteLine("Printing...");
    }

    public void Scan()
    {
        Console.WriteLine("Scanning...");
    }
}

class Program214_MultipleInterface
{
    static void Main()
    {
        Machine m = new Machine();
        m.Print();
        m.Scan();
    }
}
```

---

Program215_AbstractClassExample.cs

```csharp
using System;

abstract class Vehicle
{
    public abstract void Start();
}

class Car : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("Car Starting...");
    }
}

class Program215_AbstractClassExample
{
    static void Main()
    {
        Vehicle v = new Car();
        v.Start();
    }
}
```

---

Program216_FileWriteRead.cs

```csharp
using System;
using System.IO;

class Program216_FileWriteRead
{
    static void Main()
    {
        File.WriteAllText("data.txt", "Hello File");

        string data = File.ReadAllText("data.txt");

        Console.WriteLine(data);
    }
}
```

---

Program217_ExceptionHandlingDivision.cs

```csharp
using System;

class Program217_ExceptionHandlingDivision
{
    static void Main()
    {
        try
        {
            int a = 10, b = 0;
            Console.WriteLine(a / b);
        }
        catch(DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
        }
    }
}
```

---

Program218_ListSearch.cs

```csharp
using System;
using System.Collections.Generic;

class Program218_ListSearch
{
    static void Main()
    {
        List<int> list = new List<int> {10,20,30,40};

        int target = 30;

        if(list.Contains(target))
            Console.WriteLine("Found");
        else
            Console.WriteLine("Not Found");
    }
}
```

---

Program219_DictionarySearch.cs

```csharp
using System;
using System.Collections.Generic;

class Program219_DictionarySearch
{
    static void Main()
    {
        Dictionary<int, string> dict = new Dictionary<int, string>();

        dict.Add(1, "Aarti");
        dict.Add(2, "Yash");

        if(dict.ContainsKey(1))
            Console.WriteLine(dict[1]);
    }
}
```

---

Program220_SimpleFileLogger.cs

```csharp
using System;
using System.IO;

class Program220_SimpleFileLogger
{
    static void Main()
    {
        string message = "Log at " + DateTime.Now;

        File.AppendAllText("log.txt", message + "\n");

        Console.WriteLine("Log Saved");
    }
}
```

---
