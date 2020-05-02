using System;
/*1.7. Crear un proyecto llamado “EquivalenciasPies”. Se debe ingresar una distancia medidas en
pies y calcular su equivalente en pulgadas, yarda, cms y metros. Utilizar únicamente las
equivalencias conocidas: 1 pie = 12 pulgadas, 1 yarda = 3 pies, 1 pulgada = 2.54 cm, 1 metro
= 100 cm.*/
namespace _1_07.EquivalenciasPiesCs
{
    class EquivalenciasPies
    {
        static void Main(string[] args)
        {
            int datos = ingresoDatos();
            Console.WriteLine(equivalencias(datos));

            int ingresoDatos()
            {
                Console.Write("Ingrese un valor en pies : ");
                return Convert.ToInt32(Console.ReadLine());
            }

            String equivalencias(int datos) 
            {
                Byte opcion;
                Console.WriteLine("Ingrese el valor a convertir");
                Console.WriteLine("1 - Pulgada");
                Console.WriteLine("2 - Yarda");
                Console.WriteLine("3 - Centimetros ");
                Console.WriteLine("4 - Metro ");
                Console.Write("Seleccione una opción : ");
                opcion = Convert.ToByte(Console.ReadLine());
                switch (opcion) 
                {
                    case 1:
                        return "Pulgadas : " + datos * 12;
                    case 2:
                        return "Yarda : " + datos / 3;
                    case 3:
                      return "Centimetros : " + datos * 12 * 2.54;
                    case 4:
                      return "Metro : " + (datos * 12 * 2.54) / 100;
                    default:
                      return "Error en la elección";

                 }
            }
        }
    }
}
