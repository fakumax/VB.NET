using System;
/*1.4. Crear un proyecto llamado “VelocidadDeLaLuz”. Teniendo en cuenta que la velocidad de la
luz 300.000 kilómetros por segundo, elaborar un algoritmo que lea un tiempo en segundos
imprima la distancia que recorre la luz en dicho tiempo.*/
namespace _1_04.VelocidadDeLaLuzCs
{
    class VelocidadDeLaLuz
    {
        static void Main(string[] args)
        {

            UInt32 segundos = ingresoSegundos();
            Console.WriteLine("La distancia recorrida en {0} segundos " +
                              "de la luz es : {1} km/s", segundos, calculoVelocidadLuz(segundos));



            UInt32 ingresoSegundos()
            {
                Console.Write("Ingrese una cantidad de segundos : ");
                return Convert.ToUInt32(Console.ReadLine());
             }

            UInt32 calculoVelocidadLuz(UInt32 segundos  )
            { 
                return segundos *300;
            }
        }
    }
}
