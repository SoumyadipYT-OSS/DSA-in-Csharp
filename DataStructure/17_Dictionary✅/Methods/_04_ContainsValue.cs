using System;
using static System.Console;
using System.Collections.Generic;


class _04_ContainsValue 
{
    static void Main() 
    {
        Dictionary<int, string> orders = new Dictionary<int, string>();

        orders.Add(1001, "Manufactured");
        orders.Add(1002, "Delivered");
        orders.Add(1003, "Processing");
        orders.Add(1004, "Shipped");

        string statusToCheck = "Processing";

        if (orders.ContainsValue(statusToCheck))
            WriteLine($"Alert: Yes; There is value present {statusToCheck}");
        else
            WriteLine($"No orders are currently '{statusToCheck}'");

        statusToCheck = "Return order";

        if (orders.ContainsValue(statusToCheck))
            WriteLine($"Alert: Yes; There is value present {statusToCheck}");
        else
            WriteLine($"No orders are currently in dictionary named '{statusToCheck}'");
    }
}