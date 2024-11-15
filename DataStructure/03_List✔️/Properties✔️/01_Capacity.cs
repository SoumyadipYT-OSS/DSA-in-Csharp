using System;
using System.Collections.Generic;

class Part : IEquatable<Part> {
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



class Example {
    private static void displayTheList(List<Part> list) {
        foreach (Part i in list) {
            Console.Write(i + " ");
        }
    }


    static void Main() {
        List<Part> parts = new List<Part>();

        Console.WriteLine("\nCapacity: {0}", parts.Capacity);

        parts.Add(new Part() { PartName = "crank arm", PartId = 1234 });
        parts.Add(new Part() { PartName = "chain ring", PartId = 1334 });
        parts.Add(new Part() { PartName = "seat", PartId = 1434 });
        parts.Add(new Part() { PartName = "cassette", PartId = 1534 });
        parts.Add(new Part() { PartName = "shift lever", PartId = 1634 });

        Console.WriteLine();
        displayTheList(parts);

        Console.WriteLine("\nCapacity: {0}", parts.Capacity);
        Console.WriteLine("Count: {0}", parts.Count);

        parts.TrimExcess();
        Console.WriteLine("\nTrimExcess()");
        Console.WriteLine("Capacity: {0}", parts.Capacity);
        Console.WriteLine("Count: {0}", parts.Count);

        parts.Clear();
        Console.WriteLine("\nClear()");
        Console.WriteLine("Capacity: {0}", parts.Capacity);
        Console.WriteLine("Count: {0}", parts.Count);
    }
}