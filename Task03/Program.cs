using System;
public class Answer {
    static void biggest(int Number)
    {
        int firstNumber = Number % 10;
        int secondNumber = Number /10;
        if (firstNumber > secondNumber)
        {
            Console.WriteLine($"{firstNumber}");
        }
        else if (firstNumber < secondNumber)
        {
            Console.WriteLine($"{secondNumber}");
        }
        else 
        {
            Console.WriteLine($"Числа равны");
        }
    }

 
    static public void Main() 
    {
        Console.WriteLine("Введите число из отрезка [10, 99]");
        int Number = Convert.ToInt32(Console.ReadLine());
        
        biggest(Number);
    }
}