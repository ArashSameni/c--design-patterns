namespace DesignPatterns.Iterator;

[PatternName("Iterator")]
public class Runner : IRunnable
{
    public void Run()
    {
        var queue = new Queue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Dequeue();
        queue.Enqueue(4);
        queue.Enqueue(5);
        queue.Enqueue(6);
        
        Console.WriteLine("Cap: {0}", queue.Capacity);
        foreach (var num in queue)
        {
            Console.WriteLine(num);
        }
    }
}