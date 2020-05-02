Imports System
'1.9. Crea un proyecto llamado “ÁreaCirculo” donde se ingresa el radio del círculo imprime el
'área. Area = pi*(r^2)
Module AreaCirculo
    Sub Main(args As String())
        Dim radio As Single = radioCirculo()
        Console.WriteLine("El Área es : {0}", Math.PI * (radio ^ 2))
    End Sub


    Function radioCirculo() As Single
        Console.Write("Ingrese radio del círculo : ")
        Return Console.ReadLine()
    End Function
End Module
