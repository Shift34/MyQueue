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
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            MyQueue<int> myqueue = new MyQueue<int>();
            for(int i = 0; i < 100000; i++)
            {
                myqueue.Enqueue(i);
            }
            for(int i = 0; i < 50000; i++)
            {
                myqueue.Dequeue();
            }
            for(int i = 0; i < myqueue.Count; i++)
            {
                myqueue.Contains(i);
                //Console.WriteLine(myqueue.Dequeue());
            }
            stopwatch.Stop();
            Console.WriteLine();

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
                queue.Contains(i);
                //Console.WriteLine(queue.Dequeue());
            }
            stopwatch1.Stop();
            Console.WriteLine();

            //MyQueue<int> myQueue = new MyQueue<int>(0) { };
            //myQueue.Enqueue(1);
            //myQueue.Dequeue();

            Console.WriteLine(stopwatch.ElapsedMilliseconds);
            Console.WriteLine(stopwatch1.ElapsedMilliseconds);
            Console.WriteLine();

            //MyQueue <int> myQueue = new MyQueue<int>();
            //int[] massiv = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int n = 10;
            //for (int i = 0; i < n; i++)
            //    myQueue.Enqueue(i);
            //int[] massiv1 = new int[10];
            //for (int i = 0; i < n; i++)
            //    massiv1[i] = myQueue.Dequeue();

            //foreach(int i in massiv1)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine();
            //foreach (int i in massiv)
            //{
            //    Console.WriteLine(i);
            //}

            Console.ReadLine();
        }
    }
}
