using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeInterv
{
    /*
     Given a list of intevals, merge all overlapping intervals.
         */

    class Program
    {
        public class Interval
        {
            public int start;
            public int end;
            public Interval()
            {
                start = 0;
                end = 0;
            }

            public Interval(int s, int e)
            {
                start = s;
                end = e;
            }
        }

        static public IList<Interval> Merge(IList<Interval> intervals)
        {
            if (intervals == null || intervals.Count <= 1)
                return intervals;

            intervals = intervals.OrderBy(a => a.start).ToList();

            //list of interval to return
            List<Interval> output = new List<Interval>();

            // initialize an object of interal with first element of inout list.
            Interval match = intervals[0];

            //loop through end
            for (int i = 1; i < intervals.Count; i++)
            {
                // if the matching interval ending before the next interval begin
                if (match.end < intervals[i].start)
                {
                    // add this matching interval in the list 
                    output.Add(match);
                    // get the next interval to match further.
                    match = intervals[i];
                }
                // if the end of the matching interval falls between
                // the begin and end of the interval in the list
                else if (match.end >= intervals[i].start && match.end < intervals[i].end)
                {
                    match.end = intervals[i].end;
                }
            }
            // add the last matching interval in the list
            output.Add(match);
            output.ForEach(i => Console.Write("{0}\t","["+ i.start + ", "+ i.end + "]"));
         
            return output;
        }

        static void Main(string[] args)
        {
            List<Interval> lst = new List<Interval>();
            lst.Add(new Interval(1, 4));
            lst.Add(new Interval(3, 6));
            lst.Add(new Interval(8, 10));
            
            IList<Interval> output = Merge(lst);
          
        }

       
    }
}
