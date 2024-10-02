using System;

/*
    1. FindLastIndex<T>(T[], Predicate<T>) 
    Searches for an element that matches the conditions defined by the 
    specified predicate, and returns the zero-based index of the last 
    occurrence within the entire Array.

    2. FindLastIndex<T>(T[], Int32, Predicate<T>)
    Searches for an element that matches the conditions defined by the 
    specified predicate, and returns the zero-based index of the last 
    occurrence within the range of elements in the Array that extends 
    from the first element to the specified index.

    3. FindLastIndex<T>(T[], Int32, Int32, Predicate<T>)
    Searches for an element that matches the conditions defined by the 
    specified predicate, and returns the zero-based index of the last 
    occurrence within the range of elements in the Array that contains 
    the specified number of elements and ends at the specified index.
*/


class Example {
    private static bool EndsWithSaurus(string s) {
        if ((s.Length > 5) && (s.Substring(s.Length - 6).ToLower() == "saurus")) {
            return true;
        } else {
            return false;
        }
    }
}