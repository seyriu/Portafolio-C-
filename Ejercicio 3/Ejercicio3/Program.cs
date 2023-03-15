

using System;
class programa
{
    public static void Main(string[] args)
    {
        string texto;
        int edad;
        
        Console.WriteLine("Ingresa tu nombre");
        
        texto = Console.ReadLine();
        
        Console.WriteLine("Ingresa tu edad");
       
        edad = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Te llamas " + texto + " y tienes " + edad + " años.");

        Console.ReadKey();
    }

}

