using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un número");

        while (true)
        {
            int num = Convert.ToInt32(Console.ReadLine());

            if (num == 0)
            {
               break;
            }
              
            if (num % 2 == 0)
            {   
               Console.WriteLine("Par");
               Environment.Exit(0);
            }
               
            else
            {
               Console.WriteLine("Impar");
            }
                
        }

    }
}