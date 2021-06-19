using System;

namespace UD4E17
{
    class Program
    {
        static void Main(string[] args)
        {
            String texto = "Introduce el número de ventas";

            int numVentas = Convert.ToInt32(texto);

            int sumaVentas = 0;
            for (int i = 0; i < numVentas; i++)
            {
                texto = ("Introduce el número de ventas" + (i + 1));
                int venta = Convert.ToInt32(texto);

                sumaVentas = sumaVentas + venta;
            }

            Console.WriteLine(sumaVentas);
        }
    }
}
