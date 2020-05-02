using System;
/*1.8. Crea un proyecto llamado “Facturación” en el cual se ingresa el nombre de un artículo y su
costo. La utilidad es del 150 por ciento y el impuesto es el 21 por ciento. Calcular e imprimir
artículo, utilidad, impuesto y precio de venta.*/
namespace _1_08.FacturacionCs
{
    class Facturacion
    {
        static void Main(string[] args)
        {
            String articulo = nombreArticulo();
            Single precio = costoArticulo();
            Single precioUtilidad = precio * 150 / 100;
            Single iva  = (precio + precioUtilidad) * 21 /100;
            Console.WriteLine("Artículo : {0}" +
                          "Precio: {1}" +
                          "Utilidad: {2}" +
                          "Impuesto : {3}" +
                          "PRECIO VENTA: {4}", articulo, precio, precioUtilidad, iva, precio + precioUtilidad + iva);

            string nombreArticulo() {
                Console.Write("Ingrese nombre de un producto : ");
                return Console.ReadLine();
            }
            Single costoArticulo() {
                Console.Write("Ingrese costo del articulo : ");
                return Convert.ToSingle(Console.ReadLine());
            }
        }
    }
}
