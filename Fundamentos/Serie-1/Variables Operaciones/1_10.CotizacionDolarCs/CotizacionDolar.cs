using System;
/*1.10. Crea un proyecto llamado “CotizaciónDólar” el cual se ingresa la cantidad de dólares
que se va a comprar y el tipo de cambio en pesos(costó de un dólar en pesos) Calcular e
imprimir la cantidad que se debe pagar en pesos por la cantidad de dólares indicada.*/
namespace _1_10.CotizacionDolarCs
{
    class CotizacionDolar
    {
        static void Main(string[] args)
        {
            int compraDolar = comprarDolares();
            int cambioPeso = tipoCambio();
            Console.WriteLine("Por {0} dólares debe pagar {1} pesos", compraDolar, cambioPeso * compraDolar);
                  
        int comprarDolares()
        {
            Console.Write("Ingrese la cantidad de dólares a comprar : ");
            return Convert.ToInt32(Console.ReadLine());
        }
        int tipoCambio()
        {
            Console.Write("Ingrese costo de 1 dólar en pesos : ");
            return Convert.ToInt32(Console.ReadLine());
        }
        }
    }
}
