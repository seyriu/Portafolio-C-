using System;
class programa
{
    public static void Main(string[] args)
    {
        Console.WriteLine("escribe tu nombre");
        string nombre = Convert.ToString(Console.ReadLine());

        Console.WriteLine("escribe tu ciudad");
        string ciudad = Convert.ToString(Console.ReadLine());

        Console.WriteLine(" Tu nombre es: " + nombre + " y tu ciudad es: " + ciudad );

        Console.ReadLine();

    }

}