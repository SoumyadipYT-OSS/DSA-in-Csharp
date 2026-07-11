using System;
using static System.Console;
using System.Collections;


class HTExample 
{
    static void Main() 
    {
        Hashtable table = new Hashtable();

        table["Motherboard"] = "Gigabyte";
        table["Model"] = "B450";
        table[1] = 'v';
        table["SubId"] = "123XYZ";
        table["Price"] = 6599.99;

        foreach (DictionaryEntry entry in table)
            WriteLine($"{entry.Key} => {entry.Value}");
    }
}