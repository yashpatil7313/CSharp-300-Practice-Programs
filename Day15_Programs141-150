📁 Day15_Programs141-150

---

Program141_ClassStudent.cs

```csharp
using System;

class Student
{
    public string name;
    public int age;

    public void Display()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }
}

class Program141_ClassStudent
{
    static void Main()
    {
        Student s = new Student();
        s.name = "Yash";
        s.age = 20;
        s.Display();
    }
}
```

---

Program142_ClassRectangle.cs

```csharp
using System;

class Rectangle
{
    public int length, width;

    public int Area()
    {
        return length * width;
    }
}

class Program142_ClassRectangle
{
    static void Main()
    {
        Rectangle r = new Rectangle();
        r.length = 5;
        r.width = 3;

        Console.WriteLine("Area = " + r.Area());
    }
}
```

---

Program143_ClassBankAccount.cs

```csharp
using System;

class BankAccount
{
    public double balance;

    public void Deposit(double amount)
    {
        balance += amount;
    }

    public void Display()
    {
        Console.WriteLine("Balance: " + balance);
    }
}

class Program143_ClassBankAccount
{
    static void Main()
    {
        BankAccount acc = new BankAccount();
        acc.Deposit(1000);
        acc.Display();
    }
}
```

---

Program144_ClassEmployee.cs

```csharp
using System;

class Employee
{
    public string name;
    public double salary;

    public void Display()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Salary: " + salary);
    }
}

class Program144_ClassEmployee
{
    static void Main()
    {
        Employee e = new Employee();
        e.name = "Aarti";
        e.salary = 50000;
        e.Display();
    }
}
```

---

Program145_ConstructorExample.cs

```csharp
using System;

class Student
{
    public string name;

    public Student(string n)
    {
        name = n;
    }

    public void Display()
    {
        Console.WriteLine("Name: " + name);
    }
}

class Program145_ConstructorExample
{
    static void Main()
    {
        Student s = new Student("Yash");
        s.Display();
    }
}
```

---

Program146_MethodOverloading.cs

```csharp
using System;

class MathOperation
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }
}

class Program146_MethodOverloading
{
    static void Main()
    {
        MathOperation obj = new MathOperation();

        Console.WriteLine(obj.Add(2, 3));
        Console.WriteLine(obj.Add(2, 3, 4));
    }
}
```

---

Program147_EncapsulationExample.cs

```csharp
using System;

class Person
{
    private string name;

    public void SetName(string n)
    {
        name = n;
    }

    public string GetName()
    {
        return name;
    }
}

class Program147_EncapsulationExample
{
    static void Main()
    {
        Person p = new Person();
        p.SetName("Yash");

        Console.WriteLine(p.GetName());
    }
}
```

---

Program148_InheritanceExample.cs

```csharp
using System;

class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating");
    }
}

class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking");
    }
}

class Program148_InheritanceExample
{
    static void Main()
    {
        Dog d = new Dog();
        d.Eat();
        d.Bark();
    }
}
```

---

Program149_PolymorphismExample.cs

```csharp
using System;

class Animal
{
    public virtual void Sound()
    {
        Console.WriteLine("Animal sound");
    }
}

class Dog : Animal
{
    public override void Sound()
    {
        Console.WriteLine("Dog barks");
    }
}

class Program149_PolymorphismExample
{
    static void Main()
    {
        Animal a = new Dog();
        a.Sound();
    }
}
```

---

Program150_AbstractionExample.cs

```csharp
using System;

abstract class Shape
{
    public abstract void Draw();
}

class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing Circle");
    }
}

class Program150_AbstractionExample
{
    static void Main()
    {
        Shape s = new Circle();
        s.Draw();
    }
}
```

---
