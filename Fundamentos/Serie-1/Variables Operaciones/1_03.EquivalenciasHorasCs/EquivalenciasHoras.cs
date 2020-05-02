using System;
/*1.3. Crea un proyecto llamado “EquivalenciasHoras” que lea una cantidad de horas e imprima su
equivalente en minutos, segundos y días.*/
namespace _1_03.EquivalenciasHorasCs
{
    class EquivalenciasHoras
    {
        static void Main(string[] args)
        {

            ushort horas = ingresoHora();
            Console.WriteLine("El total de Horas ingresadas es : {0} \n" +
                              "El total de minutos son : {1}\n" +
                              "El total de segundos son : {2}\n" +
                              "El total de días son : {3}",
                              horas, Math.Floor(Convert.ToSingle(horas * 60)), Math.Floor(Convert.ToSingle(horas * 60) * 60), Math.Floor(Convert.ToSingle(horas / 24)));


           ushort ingresoHora()
           {
                Console.Write("Ingrese horas para ser devuelta en minutos,segundos y días : ");
                return Convert.ToUInt16(Console.ReadLine());
            }
        }
    }
}
