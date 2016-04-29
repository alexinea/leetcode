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
        private IEnumerator<NestedInteger> Enumerator;

        private IEnumerable<NestedInteger> Do(NestedInteger nestedInteger)
        {
            if (nestedInteger.IsInteger())
                yield return nestedInteger;
            else
                foreach (var item in Do(nestedInteger.GetList()))
                    yield return item;
        }

        private IEnumerable<NestedInteger> Do(IList<NestedInteger> nestedList)
        {
            foreach (var item in nestedList.Select(x => Do(x)).SelectMany(x => x))
                yield return item;
        }


        public NestedIterator(IList<NestedInteger> nestedList)
        {
            Enumerator = Do(nestedList).GetEnumerator();
        }

        public bool HasNext()
        {
            return Enumerator.MoveNext();
        }

        public int Next()
        {
            return Enumerator.Current.GetInteger();
        }
    }
}
