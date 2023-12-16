﻿using System;

public class Calculator<T>
{
   
    public delegate T AddDelegate(T num1, T num2);

  
    public delegate T SubtractDelegate(T num1, T num2);

 
    public delegate T MultiplyDelegate(T num1, T num2);

  
    public delegate T DivideDelegate(T num1, T num2);


    public AddDelegate Add;
    public SubtractDelegate Subtract;
    public MultiplyDelegate Multiply;
    public DivideDelegate Divide;


    public Calculator()
    {
        Add = (a, b) => (dynamic)a + b;
        Subtract = (a, b) => (dynamic)a - b;
        Multiply = (a, b) => (dynamic)a * b;
        Divide = (a, b) => (dynamic)a / b;
    }

   
    public void PerformOperations(T num1, T num2)
    {
        Console.WriteLine($"Додавання: {Add(num1, num2)}");
        Console.WriteLine($"Віднімання: {Subtract(num1, num2)}");
        Console.WriteLine($"Множення: {Multiply(num1, num2)}");
        Console.WriteLine($"Ділення: {Divide(num1, num2)}");
    }
}
