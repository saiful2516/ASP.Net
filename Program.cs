using System.Collections.Generic;
namespace StackExample;
using System;
using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {   
        
        //Stack Last in first out. Lifo. variable type fixed and not fixed both operation possible 
        Stack aStack = new Stack();
        aStack.Push(121);
        aStack.Push("Hello");
        aStack.Push(125.4);
        foreach(var value in aStack)
        {
            Console.WriteLine(value);
        }
        aStack.Pop();
        foreach (var value in aStack)
        {
            Console.WriteLine(value);
        }

        Stack<int> numbers = new Stack<int>();
        numbers.Push(1);
        numbers.Push(2);
        numbers.Push(3);
        numbers.Push(4);

        foreach (var item in numbers)
        {
            Console.WriteLine(item + ",");

        }

        numbers.Pop();
        foreach (var item in numbers)
        {
            Console.WriteLine(item + ",");

        }

        Console.WriteLine("Queue First come fist out ");
        Queue<int> anQueue = new Queue<int>();
        anQueue.Enqueue(10);
        anQueue.Enqueue(20);
        anQueue.Enqueue(30);
        anQueue.Enqueue(65);
        foreach (var data in anQueue)
        {
            Console.WriteLine(data);
        }

        anQueue.Dequeue();
        foreach (var data in anQueue) 
        {
            Console.WriteLine(data);
        }

        Console.ReadKey();
    }
}