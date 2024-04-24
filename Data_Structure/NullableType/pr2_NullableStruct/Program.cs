using System;

namespace NullableStructExample {
    [Serializable]
    public struct Nullable<T> where T : struct {
        private readonly T? _value; // Use T? instead of T

        public bool HasValue => _value.HasValue;
        public T Value => _value.GetValueOrDefault();

        public Nullable(T? value) {
            _value = value;
        }
    }

    class Solution {
        static void Main(string[] args) {
            
        }
    }
}