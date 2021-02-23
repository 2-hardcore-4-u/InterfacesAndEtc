using System;
using System.Collections;

namespace ScaryTask2
{
    class Program
    {
        static void Main()
        {
            foreach (var x in new FibSeq2(56))
            {
                Console.WriteLine(x);
            }
        }
    }
    class FibSeq2 : IEnumerable
    {
        private int RealNumber;

        public FibSeq2(int Number)
        {
            RealNumber = Number;
        }
        public IEnumerator GetEnumerator()
        {
            long cur = 0;
            long prev = 1;
            for (int i = 0; i < RealNumber; i++)
            {
                yield return cur;
                (prev, cur) = (cur, cur + prev);
            }
        }
    }
}