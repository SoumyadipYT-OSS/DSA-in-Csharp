using System;
using System.Text;

namespace NULLABLE_STRUCT {
    [Serializable]
    public struct Nullable<T> where T : struct {
        public bool HasValue { get; }
        public T value { get;  }

        // other implementation
    }

    class Solution {
        static void Main(string[] args) {
            Nullable<int> i = null;

            if (i.HasValue)
                Console.WriteLine(i.value);
            else
                Console.WriteLine("Null");
        }
    }
}