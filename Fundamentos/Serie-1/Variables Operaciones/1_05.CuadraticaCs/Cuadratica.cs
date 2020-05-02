using System;
/*1.5. Crear un proyecto y un módulo llamado “Cuadratica” que resuelva la siguiente ecuación 
x = ((b^2)-(4*a*c))/(2*a) donde a = 1, b = 5 y c=2. Mostrar el resultado obtenido.*/
namespace _1_05.CuadraticaCs
{
    class Cuadratica
    {
        static void Main(string[] args)
        {
            Console.WriteLine("El resultado es : " , resuelveCuadratica(1, 5, 2));


            Single resuelveCuadratica(UInt32 a   , UInt32 b  , UInt32 c )
            {
                return (b ^ 2 - 4 * a * c) / (2 * a);
            }
        
        }
    }
}
