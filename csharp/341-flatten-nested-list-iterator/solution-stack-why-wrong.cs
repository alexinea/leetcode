using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
        }
    }


    // This is the interface that allows for creating nested lists.
    // You should not implement it, or speculate about its implementation
    interface NestedInteger
    {

        // @return true if this NestedInteger holds a single integer, rather than a nested list.
        bool IsInteger();

        // @return the single integer that this NestedInteger holds, if it holds a single integer
        // Return null if this NestedInteger holds a nested list
        int GetInteger();

        // @return the nested list that this NestedInteger holds, if it holds a nested list
        // Return null if this NestedInteger holds a single integer
        IList<NestedInteger> GetList();
    }

    class NestedIterator
    {
        private Stack<NestedInteger> InternalStack { get; set; }
        public NestedIterator(IList<NestedInteger> nestedList)
        {
            InternalStack = new Stack<NestedInteger>();
            for (int i = nestedList.Count - 1; i > -1; i--)
                InternalStack.Push(nestedList[i]);
        }

        public bool HasNext()
        {
            if (InternalStack.Count == 0)
                return false;

            var cur = InternalStack.Peek();
            if (cur == null)
                return false;

            while (InternalStack.Count > 0 && !cur.IsInteger())
            {
                var top = InternalStack.Pop();

                IList<NestedInteger> list = top.GetList();
                if (list == null || !list.Any())
                    break;

                for (int i = list.Count - 1; i > -1; i--)
                    InternalStack.Push(list[i]);
                cur = InternalStack.Peek();
            }

            return true;
        }

        public int Next()
        {
            if (InternalStack.Count == 0)
                return default(int);
            var top = InternalStack.Pop();
            return top == null ? default(int) : top.GetInteger();
        }
    }

}
