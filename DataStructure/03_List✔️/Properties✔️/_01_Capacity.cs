using System;
using System.Collections.Generic;
using static System.Console;


class Part : IEquatable<Part> 
{
    public string PartName { get; set; }
    public int PartId { get; set; }
    public override string ToString() {
        return "ID: " + PartId + "\tName: " + PartName;
    }
    public override bool Equals(object obj) {
        if (obj == null) return false;
        Part objAsPart = obj as Part;
        if (objAsPart == null) return false;
        else return Equals(objAsPart);
    }
    public override int GetHashCode() {
        return base.GetHashCode();
    }
    public bool Equals(Part other) {
        if (other == null) return false;
        return (this.PartId.Equals(other.PartId));
    }
}



class _01_Capacity 
{
    private static void displayTheList(List<Part> list) 
    {
        foreach (Part i in list) 
        {
            WriteLine(i);
        }
    }


    static void Main() 
    {
        List<Part> parts = new List<Part>();

        WriteLine("\nCapacity: {0}", parts.Capacity);

        parts.Add(new Part() { PartName = "crank arm", PartId = 1234 });
        parts.Add(new Part() { PartName = "chain ring", PartId = 1334 });
        parts.Add(new Part() { PartName = "seat", PartId = 1434 });
        parts.Add(new Part() { PartName = "cassette", PartId = 1534 });
        parts.Add(new Part() { PartName = "shift lever", PartId = 1634 });

        WriteLine();
        displayTheList(parts);

        WriteLine("\nCapacity: {0}", parts.Capacity);
        WriteLine("Count: {0}", parts.Count);

        parts.TrimExcess();
        WriteLine("\nTrimExcess()");
        WriteLine("Capacity: {0}", parts.Capacity);
        WriteLine("Count: {0}", parts.Count);

        parts.Clear();
        WriteLine("\nClear()");
        WriteLine("Capacity: {0}", parts.Capacity);
        WriteLine("Count: {0}", parts.Count);
    }
}