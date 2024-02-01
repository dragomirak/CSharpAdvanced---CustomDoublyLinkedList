using System;

namespace P01.DoublyLinkedList;

public class StartUp
{
    static void Main()
    {
        var linkedList = new DoublyLinkedList();

        for (int i = 1; i <= 4; i++)
        {
            linkedList.AddHead(i);
            Console.WriteLine($"Head: {linkedList.Head?.Value}");
            Console.WriteLine($"Tail: {linkedList.Tail?.Value}");
            Console.WriteLine($"Next to Head: {linkedList.Head?.Next?.Value}");
            Console.WriteLine($"Previous to Tail: {linkedList.Tail?.Previous?.Value}");
            Console.WriteLine();
        }

    }
}