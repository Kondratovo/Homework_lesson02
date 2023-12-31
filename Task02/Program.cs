using System;
public class Answer {
    static void quarter(int x, int y)
    {
        if (x > 0 && y > 0)
        {
            Console.WriteLine($"Точка ({x},{y}) находится в I четверти");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine($"Точка ({x},{y}) находится в II четверти");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine($"Точка ({x},{y}) находится в III четверти");
        }
         else if (x > 0 && y < 0)
        {
            Console.WriteLine($"Точка ({x},{y}) находится в IV четверти");
        }
         else 
        {
            Console.WriteLine($"Точка ({x},{y}) на оси координат");
        }
    }

 
    static public void Main() 
    {
        Console.WriteLine("Введите X");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите Y");
        int y = Convert.ToInt32(Console.ReadLine());

        quarter(x, y);
    }
}