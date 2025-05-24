using System;

namespace KataLibrary
{
    public class Kata
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
}

public class Program
{
    public static void Main()
    {
        // "Тест 1": 2 + 3 = 5
        int result = KataLibrary.Kata.Add(2, 3);
        Console.WriteLine("Test 1: 2 + 3 = 5 → " + (result == 5 ? "Passed" : "Failed"));

        // "Тест 2": 1 + 1 = 2
        Console.WriteLine("Test 2: 1 + 1 = 2 → " + (KataLibrary.Kata.Add(1,1) == 2 ? "Passed" : "Failed"));
    }
}
