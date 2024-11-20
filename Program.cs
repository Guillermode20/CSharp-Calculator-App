// See https://aka.ms/new-console-template for more information

namespace Calculator_App;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Calculator App!");
        Console.WriteLine("Please enter the first number:");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Please enter the second number:");
        double num2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Please enter the operation (+, -, *, /) or enter Exit to exit the calculator:");
        string? operation = Console.ReadLine();

        if (operation == "+")
        {
            Program.Add(num1, num2);
        }
        
        else if (operation == "-")
        {
            Program.Subtract(num1, num2);
        }
        
        else if (operation == "*")
        {
            Program.Multiply(num1, num2);
        }
        
        else if (operation == "/")
        {
            Program.Divide(num1, num2);
            
        }
        
        else if (operation == "Exit")
        {
            Console.WriteLine("Goodbye!");
        }
        
        else
        {
            Console.WriteLine("Invalid operation");
        }
    }
    
    public static void Add(double num1, double num2)
    {
        Console.WriteLine("Result: " + (num1 + num2));
    }
    
    public static void Subtract(double num1, double num2)
    {
        Console.WriteLine("Result: " + (num1 - num2));
    }
    
    public static void Multiply(double num1, double num2)
    {
        Console.WriteLine("Result: " + (num1 * num2));
    }
    
    public static void Divide(double num1, double num2)
    {
        if (num2 == 0)
        {
            Console.WriteLine("Cannot divide by zero");
        }
        else
        {
            Console.WriteLine("Result: " + (num1 / num2));
        }
    }
}