using System;
using System.ComponentModel;
using System.Xml.Schema;

public class Program
{
    public static void Main(string[] args)
    {
        int a, b = 0;
        string c ;
        Console.Write("Please input the first number: ");
        a = Int32.Parse(Console.ReadLine());
        Console.Write("Please input the second number: ");
        b = Int32.Parse(Console.ReadLine());
        Console.Write("Please input the operator: ");
        c = Console.ReadLine();

        switch (c)
        {
            case "+":
                Console.WriteLine("Result = " + (a + b));
                break;
            case "-":
                Console.WriteLine("Result = " + (a - b));
                break;
            case "*":
                Console.WriteLine("Result = " + (a * b));
                break;
            case "/":
                if (b != 0)
                {
                    Console.WriteLine("Result = " + (a / b));
                }
                else
                {
                    Console.WriteLine("The divisor cannnot be 0");
                }
                break;
        }
    }
}