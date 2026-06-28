using System;
using System.Collections.Generic;
using static System.Console;


#region MyString class it contais string join 
class MyString 
{
    public static string ConcatJoin(string seperator, IEnumerable<string> values) 
    {
        if (values == null)
            return string.Empty;

        bool first = true;
        var result = "";

        foreach (var v in values) 
        {
            if (!first)
                result += seperator;
            result += v;
            first = false;
        }

        return result;
    }

    public static string ConcatJoin(string seperator, IEnumerable<float> values) 
    {
        if (values == null)
            return string.Empty;

        bool first = true;
        var result = "";

        foreach (var v in values)
        {
            if (!first)
                result += seperator;
            result += v;
            first = false;
        }

        return result;
    }
}
#endregion


class _01_Add 
{
    #region Integer List
    protected static void IntegerList() 
    {
        List<int> intList = new List<int>();

        intList.Add(101);
        intList.Add(102);

        WriteLine($"Integer List: {string.Join(", ", intList)}");
    }
    #endregion

    #region Float List
    protected static void FloatList() 
    {
        List<float> floatList = new List<float>();

        floatList.Add(3.14f);
        floatList.Add(2.71f);

        WriteLine($"Float List: {MyString.ConcatJoin(", ", floatList)}");
    }
    #endregion

    #region String List
    protected static void StringList() 
    {
        List<string> stringList = new List<string>();

        stringList.Add("C#");
        stringList.Add("ASP .NET Core");

        WriteLine($"String List: {MyString.ConcatJoin(", ", stringList)}");
    }
    #endregion


    static void Main() 
    {
        List<object> list = new List<object>();

        list.Add(10);
        list.Add(3.14f);
        list.Add("C#");

        foreach (var l in list)
            Write(l + ", ");

        WriteLine();

        IntegerList();
        FloatList();
        StringList();
    }
}