using System;
using System.Collections.Generic;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Interval> intervals = new List<Interval> { new Interval(1, 2), new Interval(5, 9) };
            var hereIntervals = DigitCounts(intervals, new Interval(2, 5));
            foreach (var item in hereIntervals) { Console.Write(item + ","); }
            //==> [1, 9]
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------");
            hereIntervals = DigitCounts(intervals, new Interval(3, 4));
            foreach (var item in hereIntervals) { Console.Write(item + ","); }
            //==> [1, 2],[3, 4],[5, 9]
            Console.ReadLine();
        }

        static List<Interval> DigitCounts(List<Interval> intervals, Interval newInterval)
        {
            List<Interval> retIntervals = new List<Interval>();
            Interval currentInterval = newInterval;
            foreach (Interval interval in intervals)
            {
                if (!IsCross(interval, currentInterval))
                {
                    if (interval.Start > currentInterval.End)
                    {
                        retIntervals.Add(currentInterval);
                        currentInterval = interval;
                    }
                    else
                    {
                        retIntervals.Add(interval);
                    }
                    continue;
                }
                currentInterval = CrossInterval(interval, currentInterval);
            }
            retIntervals.Add(currentInterval);

            return retIntervals;
        }

        static Interval CrossInterval(Interval a, Interval b)
        {
            int start = a.Start > b.Start ? b.Start : a.Start;
            int end = a.End > b.End ? a.End : b.End;
            return new Interval(start, end);
        }

        static bool IsCross(Interval a, Interval b)
        {
            if (a == null || b == null)
                return false;
            return InInterval(a, b.Start) || InInterval(a, b.End) || InInterval(b, a.Start) || InInterval(b, a.End);
        }

        static bool InInterval(Interval interval, int n)
        {
            if (interval == null)
                return false;
            return interval.Start <= n && interval.End >= n;
        }
    }

    public class Interval
    {
        public int Start { get; set; }
        public int End { get; set; }

        public Interval(int start, int end)
        {
            Start = start;
            End = end;
        }

        public override string ToString()
        {
            return $"[{Start}, {End}]";
        }
    }
}
