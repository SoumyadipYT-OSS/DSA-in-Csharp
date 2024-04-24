using System;

namespace DYNAMICTYPE_INITIALIZATION {
    class Solution {
        static void Main(string[] args) {
            dynamic MyDynamicVar = 1;
            Console.WriteLine(MyDynamicVar);
            Console.WriteLine(MyDynamicVar.GetType());
        }
    }
}