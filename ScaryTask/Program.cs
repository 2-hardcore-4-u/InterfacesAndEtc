using System;
using System.Collections;

namespace ScaryTask
{
    class Program
    {
        static void Main()
        {
            foreach(var x in new FibSeq())
            {
                Console.WriteLine(x);
            }
        }
    }
    class FibIterator : IEnumerator
    {
        private int RealNumber;
        private int i;
        private long cur = 0;
        private long prev = 1;
        public FibIterator(int Number)
        {
            RealNumber = Number;
        }
        public bool MoveNext()
        {
            if (i >= RealNumber)
                return false;
            (prev, cur) = (cur, prev + cur);
            i++;
            return true;
        }
        public void Reset()
        {
            cur = 0;
            prev = 1;
        }
        public object Current
        {
            get
            {
                return cur;
            }
        }
    }
    class FibSeq : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            return new FibIterator(56);
        }
    }
}