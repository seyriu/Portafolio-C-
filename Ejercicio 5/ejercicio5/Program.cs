﻿class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("escribe el precio del producto");
        double precio = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("escribe la forma de pago: tarjeta o efectivo");
        string forma = (Console.ReadLine()).ToLower();
        while (false)
        {
              if (forma.Equals("tarjeta"))
        {
            Console.WriteLine("Introduce el numero de tarjeta");
            int numero_cuenta = Convert.ToInt32(Console.ReadLine());   

            Console.WriteLine("El producto con precio " + precio + " se ha pagado " + "con el numero de cuenta " + numero_cuenta);

        }
        else if (forma.Equals("efectivo"))
        {
            Console.WriteLine("El producto con precio " + precio + " se ha pagado");
        }
        else
        {
            Console.WriteLine("La forma de pago no es correcta");
        }
        Console.ReadLine();
        }
      
    }
}