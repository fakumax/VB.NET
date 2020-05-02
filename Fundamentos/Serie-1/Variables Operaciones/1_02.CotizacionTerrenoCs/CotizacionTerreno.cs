using System;

/*1.2. Crear un proyecto llamado “CotizaciónTerreno” qué calcule e imprima el costo un terreno
cuadrado o rectangular, teniendo como datos el ancho y la longitud en metros y el costo del
metro cuadrado.*/

namespace _1_02.CotizacionTerrenoCs
{
    class CotizacionTerreno
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cotización de terreno");
            Console.WriteLine(calculaprecio(tipoterreno()));
       
        int tipoterreno() {
            int opcion;
            do{ 
                Console.WriteLine("Ingrese el tipo de terreno : \n" +
                             "1 - Cuadrado\n" +
                             "2 - Rectangular\n");
                    opcion = Convert.ToInt32(Console.ReadLine());
                } while(opcion < 1 | opcion > 2);
            return opcion;
        }

        string calculaprecio(int tipoterreno) {

            Single ancho, longitud, costocuadrado;
            Console.Write("Ingrese el ancho del terreno en metros : ");
            ancho = Convert.ToSingle(Console.ReadLine());
            Console.Write("Ingrese la longitud del terreno en metros : ");
            longitud = Convert.ToSingle(Console.ReadLine());
            Console.Write("Ingrese el costo de metro cuadrado : ");
            costocuadrado = Convert.ToSingle(Console.ReadLine());

            switch (tipoterreno)
            {
                case 1:
                    return "El costo del terreno es : ${0}" + Convert.ToString(ancho * 4 * costocuadrado);
                case 2:
                    return $"El costo del terreno es : $" + Convert.ToString(ancho * longitud * costocuadrado) ;
                default:
                    return "Tipo de terreno erroneo";
            }
          }
        }
    }
}



