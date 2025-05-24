using System;
using KataLibrary;

class TestRunner
{
    static void Main()
    {
        Console.WriteLine("Test 1: 2 + 3 = 5 → " + (Kata.Add(2, 3) == 5 ? "Passed" : "Failed"));
        Console.WriteLine("Test 2: 1 + 1 = 2 → " + (Kata.Add(1, 1) == 2 ? "Passed" : "Failed"));
    }
}
