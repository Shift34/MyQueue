using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyQueue;
using System;
using System.Collections.Generic;

namespace UnitTestMyQueue
{
    [TestClass]
    public class UnitTest1
    {
        private MyQueue<int> myQueue;
        //[TestInitialize]
        //public void Init()
        //{
        //    myQueue = new MyQueue<int>();
        //}
        //[TestInitialize]
        //public void Init1()
        //{
        //    myQueue = new MyQueue<int>(47);
        //}
        [TestMethod]
        public void CountEqualsZeroAfterListCreation()
        {
            myQueue = new MyQueue<int>();
            Assert.AreEqual(0, myQueue.Count);
        }
        [TestMethod]
        public void CountShouldIncreaseAfterAdding()
        {
            myQueue = new MyQueue<int>();
            int n = 10;
            for (int i = 0; i < n; i++)
                myQueue.Enqueue(i);
            Assert.AreEqual(n, myQueue.Count);
        }
        [TestMethod]
        public void FindExestingElement()
        {
            myQueue = new MyQueue<int>();
            int n = 10;
            for (int i = 0; i < n; i++)
                myQueue.Enqueue(i);
            Assert.AreEqual(true, myQueue.Contains(1));
        }
        [TestMethod]
        public void FindNoExestingElement()
        {
            myQueue = new MyQueue<int>();
            int n = 10;
            for (int i = 0; i < n; i++)
                myQueue.Enqueue(i);
            Assert.AreEqual(false, myQueue.Contains(11));
        }
        [TestMethod]
        public void PullExistingFirstElement()
        {
            myQueue = new MyQueue<int>();
            int n = 10;
            for (int i = 0; i < n; i++)
                myQueue.Enqueue(i);
            Assert.AreEqual(0, myQueue.Peek());
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void PullNoExistingFirstElement()
        {
            myQueue = new MyQueue<int>();
            int n = 10;
            for (int i = 0; i < n; i++)
                myQueue.Enqueue(i);
            for (int i = 0; i < n; i++)
                myQueue.Dequeue();
            Assert.AreEqual(0, myQueue.Peek());
        }
        [TestMethod]
        public void PullAllValues()
        {
            myQueue = new MyQueue<int>();
            int[] massiv = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int n = 10;
            for (int i = 0; i < n; i++)
                myQueue.Enqueue(i);
            int[] massiv1 = new int[10];
            for (int i = 0; i < n; i++)
                massiv1[i] = myQueue.Dequeue();
            Assert.AreEqual(massiv, massiv1);
        }
    }
}
