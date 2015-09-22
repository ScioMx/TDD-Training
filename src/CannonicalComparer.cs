using System;
using System.Collections.Generic;

namespace CSharp.Training
{
    public class CannonicalComparer<T> : IComparer<T> where T : IComparable
    {
        public int Compare(T x, T y)
        {
            return x.CompareTo(y);
        }
    }
}