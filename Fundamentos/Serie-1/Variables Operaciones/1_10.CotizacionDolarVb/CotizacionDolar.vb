Imports System
'1.10. Crea un proyecto llamado “CotizaciónDólar” el cual se ingresa la cantidad de dólares
'que se va a comprar y el tipo de cambio en pesos (costó de un dólar en pesos) Calcular e
'imprimir la cantidad que se debe pagar en pesos por la cantidad de dólares indicada.
Module CotizacionDolar
    Sub Main(args As String())
        Dim compraDolar As Int32 = comprarDolares()
        Dim cambioPeso As Int32 = tipoCambio()
        Console.WriteLine("Por {0} dólares debe pagar {1} pesos", compraDolar, cambioPeso * compraDolar)

    End Sub

    Function comprarDolares() As Int32
        Console.Write("Ingrese la cantidad de dólares a comprar : ")
        Return Console.ReadLine
    End Function

    Function tipoCambio() As Int32
        Console.Write("Ingrese costo de 1 dólar en pesos : ")
        Return Console.ReadLine
    End Function
End Module
