

using Ufar.Homework;

Console.WriteLine("Hello, World!");

EasyStack<int> easyStack = new EasyStack<int>();
easyStack.Push(1);
easyStack.Push(2);
easyStack.Push(3);
easyStack.Push(4);


easyStack.Pop();

ArrayStack<string> arrayStack = new ArrayStack<string>();

arrayStack.Push("Hello");
arrayStack.Push("World");
arrayStack.Push("!");
arrayStack.Push("!");
arrayStack.Push("!");

arrayStack.Pop();
arrayStack.Pop();
arrayStack.Pop(); 

Console.WriteLine(arrayStack.Peek());

int[] array = { 64, 34, 25, 12, 22, 11, 90 };
SortingAlgorithms.BubbleSortRecursive(array);
foreach (var item in array)
{
    Console.WriteLine(item);
}

SortingAlgorithms.InsertionSortRecursive(array);
foreach (var item in array)
{
    Console.WriteLine(item);
}

CustomQueue<string> queue = new CustomQueue<string>();

queue.Enqueue("First");
queue.Enqueue("Second");
queue.Enqueue("Third");

Console.WriteLine("\n\nCustom Queue Operations:");
Console.WriteLine($"Peek: {queue.Peek()}"); 
Console.WriteLine($"Dequeue: {queue.Dequeue()}"); 
Console.WriteLine($"Peek after Dequeue: {queue.Peek()}");
Console.WriteLine($"Queue Count: {queue.Count}"); 

queue.Enqueue("Fourth");
Console.WriteLine($"Peek after Enqueue: {queue.Peek()}");
