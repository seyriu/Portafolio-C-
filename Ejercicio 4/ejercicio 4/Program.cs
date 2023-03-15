
class program
{
    public static void Main(string[] args)
    {
        int a;
        int b;
        int mayor;

        Console.Write("Ingresa el valor del primer numero: ");
            a = int.Parse(Console.ReadLine());

        Console.Write("Ingresa el valor del segundo numero: ");
            b = int.Parse(Console.ReadLine());

         if (a > b) {
             mayor = a;
         }

         else {
             mayor = b;
         }
         
        Console.WriteLine("El numero mayor es: " + mayor);
        Console.ReadKey();
    }
}
