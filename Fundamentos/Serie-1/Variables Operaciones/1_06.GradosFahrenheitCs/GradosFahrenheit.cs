using System;

/*1.6. Crea un proyecto llamado “GradosFahrenheit” donde se ingresa la temperatura en Celsius y
se muestra su equivalente en fahrenheit. Investigar la fórmula necesaria para realizar el
cálculo.*/
namespace _1_06.GradosFahrenheitCs
{
    class GradosFahrenheit
    {
        static void Main(string[] args)
        {

            UInt32 celsius = celsiusAdd();
            Console.WriteLine("El resultado de {0}° Celsius a Fahrenheit es : {1}", celsius, celsiusConvertidor(celsius));


            UInt32 celsiusAdd() 
            {
                Console.Write("Ingrese un valor en celsius : ");
                return Convert.ToUInt32(Console.ReadLine());
            }

            Single celsiusConvertidor(UInt32 celsius )
            {
                return (celsius * 9/5) + 32;
            }
        }
    }
}
