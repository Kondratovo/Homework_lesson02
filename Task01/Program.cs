using System;
public class Answer {
    static void multiples(int Number)
    {
        if (Number % 7 == 0 && Number % 23 == 0)
        {
            Console.WriteLine($"Число {Number} кратно 7 и 23");
        }
        else if (Number % 23 == 0)
        {
            Console.WriteLine($"Число {Number} кратно только 23");
        }
        else if (Number % 7 == 0)
        {
            Console.WriteLine($"Число {Number} кратно только 7");
        }
         else
        {
            Console.WriteLine($"Число {Number} не кратно 7 и 23");
        }
    }

 
    static public void Main() 
    {
        int Number = Convert.ToInt32(Console.ReadLine());

        multiples(Number);
    }
}