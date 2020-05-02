using System;

namespace _1_01.CostosCs

/*1.1. Crear un proyecto llamado “Costos” qué calcula imprima el costo de producción de un
artículo, teniendo como datos la descripción y el número de unidades producidas. El costo se
calcula multiplicando el número de unidades producidas por un factor de costo de materiales
de 3. 5 y sumándole el producto un costo fijo de 10.700. Informar todos los datos ingresados
junto a los resultados calculados.*/
{
    class Costos
    {
        static void Main()
        {
            string articulo;
            int unidades;
            Console.Write("Ingrese descripción del artículo : ");
            articulo = Console.ReadLine();
            Console.Write("Ingrese el número de unidades producidas : ");

            unidades = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("El artículo es : {0} \n" +
                                "Las unidades producidas son : {1} \n" +
                                "Costo Fijo : 10.700 \n" +
                                "El resultado de costos es : {2} ", articulo, unidades, costo(unidades));

            Double costo(int unidades)
            {
                return unidades * 3.5 + 10700;
            }
        }

       
    }
}
