using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
        }
    }

    public class MovingAverage
    {
        private Queue<int> InternalQueue { get; set; }
        private int Size { get; set; }
        private long Sum { get; set; }

        /** Initialize your data structure here. */
        public MovingAverage(int size)
        {
            Size = size;
            InternalQueue = new Queue<int>();
            Sum = 0;
        }

        private int CurrentQueueLength { get { return InternalQueue.Count; } }

        public double Next(int val)
        {
            if (CurrentQueueLength >= Size)
                Sum -= InternalQueue.Dequeue();
            InternalQueue.Enqueue(val);
            Sum += val;
            return Sum / CurrentQueueLength;
        }
    }
}
