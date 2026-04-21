Day30_Programs291-300 (FINAL)
Program291_BasicBankSystem.cs
using System;

class Program291_BasicBankSystem
{
    static void Main()
    {
        int balance = 1000;

        Console.WriteLine("1.Deposit  2.Withdraw");
        int choice = int.Parse(Console.ReadLine());

        if(choice == 1)
        {
            Console.Write("Enter amount: ");
            int amt = int.Parse(Console.ReadLine());
            balance += amt;
        }
        else if(choice == 2)
        {
            Console.Write("Enter amount: ");
            int amt = int.Parse(Console.ReadLine());
            balance -= amt;
        }

        Console.WriteLine("Balance = " + balance);
    }
}
Program292_StudentManagementSystem.cs
using System;
using System.Collections.Generic;

class Program292_StudentManagementSystem
{
    static void Main()
    {
        List<string> students = new List<string>();

        students.Add("Yash");
        students.Add("Aarti");
        students.Add("Ravi");

        foreach(string s in students)
            Console.WriteLine(s);
    }
}
Program293_EmployeeManagementSystem.cs
using System;

class Employee
{
    public int id;
    public string name;

    public Employee(int id, string name)
    {
        this.id = id;
        this.name = name;
    }
}

class Program293_EmployeeManagementSystem
{
    static void Main()
    {
        Employee e1 = new Employee(1, "Yash");
        Employee e2 = new Employee(2, "Aarti");

        Console.WriteLine(e1.id + " " + e1.name);
        Console.WriteLine(e2.id + " " + e2.name);
    }
}
Program294_LibraryManagementSystem.cs
using System;
using System.Collections.Generic;

class Program294_LibraryManagementSystem
{
    static void Main()
    {
        List<string> books = new List<string>();

        books.Add("C# Basics");
        books.Add("DSA Guide");
        books.Add("SQL Master");

        foreach(string b in books)
            Console.WriteLine(b);
    }
}
Program295_TodoConsoleApp.cs
using System;
using System.Collections.Generic;

class Program295_TodoConsoleApp
{
    static void Main()
    {
        List<string> tasks = new List<string>();

        tasks.Add("Study C#");
        tasks.Add("Practice DSA");
        tasks.Add("Build Project");

        foreach(string t in tasks)
            Console.WriteLine(t);
    }
}
Program296_CalculatorWithMenu.cs
using System;

class Program296_CalculatorWithMenu
{
    static void Main()
    {
        Console.WriteLine("1.Add 2.Sub 3.Mul 4.Div");
        int choice = int.Parse(Console.ReadLine());

        int a = 10, b = 5;

        switch(choice)
        {
            case 1: Console.WriteLine(a + b); break;
            case 2: Console.WriteLine(a - b); break;
            case 3: Console.WriteLine(a * b); break;
            case 4: Console.WriteLine(a / b); break;
        }
    }
}
Program297_LoginSystemWithAttempts.cs
using System;

class Program297_LoginSystemWithAttempts
{
    static void Main()
    {
        string user = "admin";
        string pass = "1234";

        int attempts = 3;

        while(attempts > 0)
        {
            Console.Write("Username: ");
            string u = Console.ReadLine();

            Console.Write("Password: ");
            string p = Console.ReadLine();

            if(u == user && p == pass)
            {
                Console.WriteLine("Login Success");
                return;
            }

            attempts--;
            Console.WriteLine("Wrong! Attempts left: " + attempts);
        }

        Console.WriteLine("Account Locked");
    }
}
Program298_InventorySystem.cs
using System;
using System.Collections.Generic;

class Program298_InventorySystem
{
    static void Main()
    {
        Dictionary<string,int> inventory = new Dictionary<string,int>();

        inventory["Pen"] = 10;
        inventory["Book"] = 5;

        foreach(var item in inventory)
            Console.WriteLine(item.Key + " = " + item.Value);
    }
}
Program299_MiniATMProject.cs
using System;

class Program299_MiniATMProject
{
    static void Main()
    {
        int balance = 5000;

        Console.WriteLine("ATM Menu");
        Console.WriteLine("1.Check Balance 2.Withdraw");

        int choice = int.Parse(Console.ReadLine());

        if(choice == 1)
        {
            Console.WriteLine("Balance = " + balance);
        }
        else if(choice == 2)
        {
            Console.Write("Enter amount: ");
            int amt = int.Parse(Console.ReadLine());
            balance -= amt;
            Console.WriteLine("Remaining = " + balance);
        }
    }
}
Program300_FinalCapstoneConsoleApp.cs ⭐
using System;
using System.Collections.Generic;

class Program300_FinalCapstoneConsoleApp
{
    static void Main()
    {
        List<string> menu = new List<string>()
        {
            "1. Add Task",
            "2. View Tasks",
            "3. Exit"
        };

        List<string> tasks = new List<string>();

        while(true)
        {
            foreach(string m in menu)
                Console.WriteLine(m);

            int choice = int.Parse(Console.ReadLine());

            if(choice == 1)
            {
                Console.Write("Enter task: ");
                tasks.Add(Console.ReadLine());
            }
            else if(choice == 2)
            {
                foreach(string t in tasks)
                    Console.WriteLine(t);
            }
            else
            {
                break;
            }
        }
    }
}