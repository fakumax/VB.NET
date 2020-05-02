using System;
/*
1.9. Crea un proyecto llamado “ÁreaCirculo” donde se ingresa el radio del círculo imprime el
área. Area = pi*r^2
 */

namespace _1_09.AreaCirculoCs
{
    class AreaCirculo
    {
        static void Main(string[] args)
        {
            Single radio = radioCirculo();
            Console.WriteLine("El Área es : {0}", Math.PI * (Math.Pow(radio, 2)));


        Single radioCirculo(){
            Console.Write("Ingrese radio del círculo : ");
            return Convert.ToSingle(Console.ReadLine());
        }
        }
    }
}
