using System;
class programa
{
    public static void Main(string[] args)
    {
       
        Console.WriteLine("Escriba un numero");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("escribe segundo numero");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Escriba un tercer numero");
        int num3 = Convert.ToInt32(Console.ReadLine());

        int resultadoSuma;
        resultadoSuma = num1 + num2 + num3;

        Console.WriteLine("La suma de las variables es: " + resultadoSuma);

        Console.ReadLine();

    }

}
