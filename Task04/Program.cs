using System;
public class Answer {
    static void consistently(int Number)
    {
        while (Number > 0) {
            int n = Number % 10;
            Console.Write($"{n}");
            Number /= 10;
            if (Number > 0) 
            { 
                Console.Write(","); 
            }
        }
    }

 
    static public void Main() 
    {
        Console.WriteLine("Введите натуральное число:");
        int Number = Convert.ToInt32(Console.ReadLine());
        
        consistently(Number);
    }
}