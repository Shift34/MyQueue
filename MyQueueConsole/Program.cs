using MyQueue;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQueueConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch1 = new Stopwatch();
            stopwatch1.Start();
            Queue<int> queue = new Queue<int>();
            for (int i = 0; i < 100000; i++)
            {
                queue.Enqueue(i);
            }
            for (int i = 0; i < 50000; i++)
            {
                queue.Dequeue();
            }
            for (int i = 0; i < queue.Count; i++)
            {
                queue.Contains(i + 50000);
                //Console.WriteLine(queue.Dequeue());
            }
            stopwatch1.Stop();
            Console.WriteLine(stopwatch1.ElapsedMilliseconds);

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            MyQueue<int> myqueue = new MyQueue<int>();
            for (int i = 0; i < 100000; i++)
            {
                myqueue.Enqueue(i);
            }
            for (int i = 0; i < 50000; i++)
            {
                myqueue.Dequeue();
            }
            for (int i = 0; i < myqueue.Count; i++)
            {
                myqueue.Contains(i + 50000);
                //Console.WriteLine(myqueue.Dequeue());
            }
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
