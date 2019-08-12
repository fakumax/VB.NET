Imports System
Imports System.Math
'2.4. Crear un proyecto y un módulo llamado “VolumenCilindro” que implemente una función
'que lea el radio de la base y la altura de un cilindro y que calcule y devuelva el volumen. El
'volumen de un cilindro se calcula multiplicando la constante Pi (pi=3.14159265) por el
'cuadrado del radio de la base(r) por la altura(h) de lo que se da la siguiente fórmula: v =
'pi*radio^2*h. Ingresar los valores por teclado y mostrar el resultado en consola.
Module VolumenCilindro
    Sub Main(args As String())
        Dim radio, altura As Integer
        Console.Write("Ingrese el radio : ")
        radio = Console.ReadLine
        Console.Write("Ingrese la altura : ")
        altura = Console.ReadLine
        Console.WriteLine("El resultado es  : " & devuelveVolumen(radio, altura))

    End Sub
    Function devuelveVolumen(radio As Integer, altura As Integer) As Decimal
        Return PI * radio ^ 2 * altura
    End Function

End Module
