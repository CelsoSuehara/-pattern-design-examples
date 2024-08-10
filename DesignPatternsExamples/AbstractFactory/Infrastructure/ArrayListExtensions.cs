using System.Collections;
using System;

namespace AbstractFactory.Infrastructure;

public static class ArrayListExtensions
{
    public static void WriteLines(this ArrayList arrayList)
    {
        foreach (var item in arrayList)
        {
            Console.WriteLine(item);
        }
    }
}