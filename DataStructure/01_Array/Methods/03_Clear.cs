using System;

public struct TimeZoneTime {
    private DateTimeOffset dt;
    private TimeZoneInfo tz;

    public TimeZoneTime(DateTimeOffset dateTime, TimeZoneInfo timeZone) {
        dt = dateTime;
        tz = timeZone;
    }

    public DateTimeOffset DateTime { get { return dt; } }

    public TimeZoneInfo TimeZone { get { return tz; } }
}


class Program {
    protected static void Array_Clear_Method() {
        Console.WriteLine("One dimension (Rank=1):");
        int[] numbers1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        for (int i = 0; i < 9; i++) {
            Console.Write("{0} ", numbers1[i]);
        }
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Array.Clear(numbers1, 2, 5)");
        Array.Clear(numbers1, 2, 5);

        for (int i = 0; i < 9; i++) {
            Console.Write("{0} ", numbers1[i]);
        }
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Two dimensions (Rank=2):");
        int[,] numbers2 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

        for (int i = 0; i < 3; i++) {
            for (int j = 0; j < 3; j++) {
                Console.Write("{0} ", numbers2[i, j]);
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("Array.Clear(numbers2, 2, 5)");
        Array.Clear(numbers2, 2, 5);

        for (int i = 0; i < 3; i++) {
            for (int j = 0; j < 3; j++) {
                Console.Write("{0} ", numbers2[i, j]);
            }
            Console.WriteLine();
        }

        Console.WriteLine("Three dimensions (Rank=3):");
        int[,,] numbers3 = {{{1, 2}, {3, 4}},
                             {{5, 6}, {7, 8}},
                             {{9, 10}, {11, 12}}};

        for (int i = 0; i < 2; i++) {
            for (int j = 0; j < 2; j++) {
                for (int k = 0; k < 2; k++) {
                    Console.Write("{0} ", numbers3[i, j, k]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        Console.WriteLine("Array.Clear(numbers3, 2, 5)");
        Array.Clear(numbers3, 2, 5);

        for (int i = 0; i < 2; i++) {
            for (int j = 0; j < 2; j++) {
                for (int k = 0; k < 2; k++) {
                    Console.Write("{0} ", numbers3[i, j, k]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }

    protected static void Example2_TimeZoneTime() {
        // Declare an array with two elements.
        TimeZoneTime[] timeZoneTimes = { new TimeZoneTime(DateTime.Now, TimeZoneInfo.Local),
                                       new TimeZoneTime(DateTime.Now, TimeZoneInfo.Utc) };
        foreach (var timeZoneTime in timeZoneTimes)
            Console.WriteLine("{0}: {1:G}",
                              timeZoneTime.TimeZone == null ? "<null>" : timeZoneTime.TimeZone.ToString(),
                              timeZoneTime.DateTime);
        Console.WriteLine();

        Array.Clear(timeZoneTimes, 1, 1);
        foreach (var timeZoneTime in timeZoneTimes)
            Console.WriteLine("{0}: {1:G}",
                              timeZoneTime.TimeZone == null ? "<null>" : timeZoneTime.TimeZone.ToString(),
                              timeZoneTime.DateTime);
    }


    // Main method
    static void Main() {
        Console.WriteLine("--- Clear Method ---");
        Array_Clear_Method();
        Console.WriteLine("--- Example2: TimeZoneTime ---");
        Example2_TimeZoneTime();
    }
}