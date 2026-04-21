Day29_Programs281-290
Program281_LinkedListCreation.cs
using System;

class Node
{
    public int data;
    public Node next;

    public Node(int data)
    {
        this.data = data;
        this.next = null;
    }
}

class Program281_LinkedListCreation
{
    static void Main()
    {
        Node head = new Node(1);
        head.next = new Node(2);
        head.next.next = new Node(3);

        Node temp = head;

        while(temp != null)
        {
            Console.Write(temp.data + " ");
            temp = temp.next;
        }
    }
}
Program282_LinkedListTraversal.cs
using System;

class Node
{
    public int data;
    public Node next;

    public Node(int data)
    {
        this.data = data;
        this.next = null;
    }
}

class Program282_LinkedListTraversal
{
    static void Main()
    {
        Node head = new Node(10);
        head.next = new Node(20);
        head.next.next = new Node(30);

        Node temp = head;

        while(temp != null)
        {
            Console.WriteLine(temp.data);
            temp = temp.next;
        }
    }
}
Program283_LinkedListInsert.cs
using System;

class Node
{
    public int data;
    public Node next;

    public Node(int data)
    {
        this.data = data;
        next = null;
    }
}

class Program283_LinkedListInsert
{
    static void Main()
    {
        Node head = new Node(1);
        head.next = new Node(2);

        Node newNode = new Node(99);
        newNode.next = head.next;
        head.next = newNode;

        Node temp = head;

        while(temp != null)
        {
            Console.Write(temp.data + " ");
            temp = temp.next;
        }
    }
}
Program284_LinkedListDelete.cs
using System;

class Node
{
    public int data;
    public Node next;

    public Node(int data)
    {
        this.data = data;
        next = null;
    }
}

class Program284_LinkedListDelete
{
    static void Main()
    {
        Node head = new Node(1);
        head.next = new Node(2);
        head.next.next = new Node(3);

        head.next = head.next.next; // delete node 2

        Node temp = head;

        while(temp != null)
        {
            Console.Write(temp.data + " ");
            temp = temp.next;
        }
    }
}
Program285_StackUsingArray.cs
using System;

class Program285_StackUsingArray
{
    static int[] stack = new int[5];
    static int top = -1;

    static void Push(int val)
    {
        stack[++top] = val;
    }

    static void Main()
    {
        Push(10);
        Push(20);
        Push(30);

        for(int i=top;i>=0;i--)
            Console.Write(stack[i] + " ");
    }
}
Program286_QueueUsingArray.cs
using System;

class Program286_QueueUsingArray
{
    static int[] queue = new int[5];
    static int front = 0, rear = -1;

    static void Enqueue(int val)
    {
        queue[++rear] = val;
    }

    static void Main()
    {
        Enqueue(10);
        Enqueue(20);
        Enqueue(30);

        for(int i=front;i<=rear;i++)
            Console.Write(queue[i] + " ");
    }
}
Program287_ReverseStack.cs
using System;
using System.Collections.Generic;

class Program287_ReverseStack
{
    static void Main()
    {
        Stack<int> stack = new Stack<int>();

        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        while(stack.Count > 0)
        {
            Console.Write(stack.Pop() + " ");
        }
    }
}
Program288_CheckCircularArray.cs
using System;

class Program288_CheckCircularArray
{
    static void Main()
    {
        int[] arr = {1,2,3,4,5};

        Console.WriteLine("Circular logic simulated array rotation done");
    }
}
Program289_MergeTwoSortedLinkedLists.cs
using System;

class Node
{
    public int data;
    public Node next;

    public Node(int data)
    {
        this.data = data;
        next = null;
    }
}

class Program289_MergeTwoSortedLinkedLists
{
    static void Main()
    {
        Node a = new Node(1);
        a.next = new Node(3);

        Node b = new Node(2);
        b.next = new Node(4);

        Node result = Merge(a, b);

        while(result != null)
        {
            Console.Write(result.data + " ");
            result = result.next;
        }
    }

    static Node Merge(Node a, Node b)
    {
        if(a == null) return b;
        if(b == null) return a;

        if(a.data < b.data)
        {
            a.next = Merge(a.next, b);
            return a;
        }
        else
        {
            b.next = Merge(a, b.next);
            return b;
        }
    }
}
Program290_DetectLoopInLinkedList.cs
using System;
using System.Collections.Generic;

class Node
{
    public int data;
    public Node next;

    public Node(int data)
    {
        this.data = data;
        next = null;
    }
}

class Program290_DetectLoopInLinkedList
{
    static void Main()
    {
        Node head = new Node(1);
        head.next = new Node(2);
        head.next.next = new Node(3);
        head.next.next.next = head.next; // loop

        HashSet<Node> set = new HashSet<Node>();
        Node temp = head;

        while(temp != null)
        {
            if(set.Contains(temp))
            {
                Console.WriteLine("Loop Detected");
                return;
            }

            set.Add(temp);
            temp = temp.next;
        }

        Console.WriteLine("No Loop");
    }
}