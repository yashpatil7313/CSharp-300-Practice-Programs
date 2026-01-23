using System;

class Program
{
    static void Main()
    {
        int a = 10, b = 5;
        char op = '+';

        switch (op)
        {
            case '+':
                Console.WriteLine(a + b);
                break;
            case '-':
                Console.WriteLine(a - b);
                break;
            case '*':
                Console.WriteLine(a * b);
                break;
            case '/':
                Console.WriteLine(a / b);
                break;
            default:
                Console.WriteLine("Invalid Operator");
                break;
        }
    }
}
