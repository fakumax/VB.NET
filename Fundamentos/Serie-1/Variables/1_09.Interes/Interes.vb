Imports System
'1.9. Crear un proyecto y un módulo llamado “Interes” que dé como resultado los intereses
'producidos y el capital acumulado de un monto m invertido a un interés anual r durante t días.
'La fórmula utilizada es I= (m*r*t)/(360*100) donde I es el interés producido. 
'Ingresar por teclado el monto, el interés y el tiempo.
Module Interes
    Sub Main(args As String())
        Dim montoInversion As Decimal
        Dim interesAnual As Single
        Dim tiempoDias As UShort
        Console.WriteLine("Ingrese el monto a invertir : ")
        montoInversion = Console.ReadLine
        Console.WriteLine("Ingrese el interés anual: ")
        interesAnual = Console.ReadLine
        Console.WriteLine("Ingrese la cantidad de días : ")
        tiempoDias = Console.ReadLine
        Console.WriteLine(vbLf & "Capital Ingresado : " & montoInversion &
                          vbLf & "Interés Anual en % : " & interesAnual &
                          vbLf & "Tiempo en dias de inversión : " & tiempoDias &
                          vbLf & vbLf & "El Interes Total Producido sería : " &
                          (montoInversion * interesAnual * tiempoDias) / (360 * 100))

    End Sub
End Module
