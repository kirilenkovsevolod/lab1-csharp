using System;

class Program
{
    // Перегрузки вывода
    static void PrintResult(string typeName, float result)
    {
        Console.Write("Тип {0}:", typeName);
        Console.WriteLine("результат = {0}", result);
    }

    static void PrintResult(string typeName, double result)
    {
        Console.Write("Тип {0}:", typeName);
        Console.WriteLine("результат = {0}", result);
    }

    static void Main(string[] args)
    {
        //float
        float floatA = 1000f, floatB = 0.0001f;
        float floatCubeSum = (float)Math.Pow(floatA + floatB, 3);                               // (a+b)^3
        float floatFirstTerms = (float)(Math.Pow(floatA, 3) + 3 * floatA * Math.Pow(floatB, 2)); // a^3 + 3ab^2
        float floatDenominator = (float)(3 * floatA * floatA * floatB + Math.Pow(floatB, 3));    // 3a^2*b + b^3
        float floatNumerator = floatCubeSum - floatFirstTerms;
        float floatResult = floatNumerator / floatDenominator;
        PrintResult("float", floatResult);

        //double
        double doubleA = 1000, doubleB = 0.0001;
        double doubleCubeSum = Math.Pow(doubleA + doubleB, 3);
        double doubleFirstTerms = Math.Pow(doubleA, 3) + 3 * doubleA * Math.Pow(doubleB, 2);
        double doubleDenominator = 3 * doubleA * doubleA * doubleB + Math.Pow(doubleB, 3);
        double doubleNumerator = doubleCubeSum - doubleFirstTerms;
        double doubleResult = doubleNumerator / doubleDenominator;
        PrintResult("double", doubleResult);
    }
}
