using System;

namespace ejercico2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("escribe primer numero");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("escribe segundo numero");
            int num2 = Convert.ToInt32(Console.ReadLine());



            while (true)
            {
                if (num1 % 2 == 0 && num2 % 2 == 0)
                {
                    int resultadoSuma;
                    resultadoSuma = num1 + num2;
                    Console.WriteLine("El resultado de la suma es: " + resultadoSuma);
                    Environment.Exit(0);
                }

                else
                {
                    int resultadoResta;
                    resultadoResta = num1 - num2;
                    Console.WriteLine("El resultado de la resta es: " + resultadoResta);
                    Environment.Exit(0);
                }
            }
        }
    }
}