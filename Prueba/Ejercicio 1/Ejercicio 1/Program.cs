namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcular promedio");
             float calificacion,
                suma = 0;


            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine("Introduce Calificacion:" + i);
                calificacion = float.Parse(Console.ReadLine());
                suma = suma + calificacion;

            }
            float promedio;
            promedio = suma / 4;
            Console.WriteLine("el promedio es :" + promedio);


            if (promedio >= 4.0)
            {
                Console.WriteLine("aprobado");
            }

            else
            {
                Console.WriteLine("reprobado");

            }

        }

    }
}