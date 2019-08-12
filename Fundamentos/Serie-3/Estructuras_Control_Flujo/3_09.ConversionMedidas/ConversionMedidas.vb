Imports System
'3.9. Crear un proyecto y un módulo “ConversionMedidas”, para resolver con CASE: Elabore un
'algoritmo que permita hacer conversiones de equivalencias entre metros, centímetros,
'yardas, pies y pulgadas: 
'• Presentar un menú y preguntar que unidad de medida desea convertir (pie, pulgadas,
'yarda, pulgada, cms y metros), el valor a convertir y después mostrar las equivalencias.
'• Utilizar únicamente las equivalencias conocidas: 1 pie = 12 pulgadas, 1 yarda = 3 pies, 1
'pulgada = 2.54 cm, 1 metro = 100 cm.
'• Ejemplo: si escogió metros, debe solicitar y leer el número de metros a convertir, luego
'imprimir la equivalencia en centímetros, pies, yardas y pulgadas.
Module ConversionMedidas
    Sub Main(args As String())
        Dim valor As Integer
        Dim opcion As Byte
        Do While True
            opcion = menu()
            If opcion = 6 Then
                Exit Do
            ElseIf opcion > 1 Or opcion < 6 Then
                Console.Write("Ingrese el valor : ")
                valor = Console.ReadLine
                'Console.Clear()
                'Console.WriteLine()
                Select Case opcion
                    Case 1
                        pie(valor)
                    Case 2
                        pulgada(valor)
                    Case 3
                        yarda(valor)
                    Case 4
                        centimetro(valor)
                    Case 5
                        metro(valor)
                End Select
            Else
                Console.WriteLine("Numero Erroneo, reintente")
            End If
        Loop
    End Sub
    Function menu() As Byte
        Console.WriteLine(vbTab & "MENU")
        Console.WriteLine("Ingrese unidad a convertir.")
        Console.WriteLine("1) Pie")
        Console.WriteLine("2) Pulgadas")
        Console.WriteLine("3) Yarda")
        Console.WriteLine("4) Centimetros")
        Console.WriteLine("5) Metros")
        Console.WriteLine("6) SALIR")
        Console.Write(vbLf & "Opción : ")
        Return Console.ReadLine
    End Function
    Sub pie(valor As Integer)
        Console.WriteLine(vbTab & "Conversión PIE")
        Console.WriteLine("> Pulgadas: " & valor * 12)
        Console.WriteLine("> Yardas: " & valor / 3)
        Console.WriteLine("> Centímetros: " & valor * 12 * 2.54)
        Console.WriteLine("> Metros: " & (valor * 12 * 2.54) / 100)
    End Sub
    Sub yarda(valor As Integer)
        Console.WriteLine(vbTab & "Conversión YARDA")
        Console.WriteLine("> Pulgadas: " & valor * 3 * 12)
        Console.WriteLine("> Pie : " & valor * 3)
        Console.WriteLine("> Centímetros: " & valor * 3 * 12 * 2.54)
        Console.WriteLine("> Metros: " & valor * 3 * 12 * 2.54 * 100)
    End Sub
    Sub pulgada(valor As Integer)
        Console.WriteLine(vbTab & "Conversión PULGADAS")
        Console.WriteLine("> Pie: " & valor / 12)
        Console.WriteLine("> Yardas: " & (valor / 12) / 3)
        Console.WriteLine("> Centímetros: " & valor * 2.54)
        Console.WriteLine("> Metros: " & (valor * 2.54 * 100))
    End Sub
    Sub metro(valor As Integer)
        Console.WriteLine(vbTab & "Conversión METRO")
        Console.WriteLine("> Pie: " & (valor * 2.54 * 100) / 12)
        Console.WriteLine("> Pulgadas: " & valor * 2.54 * 100)
        Console.WriteLine("> Yardas: " & ((valor * 100 * 2.54) / 12) / 3)
        Console.WriteLine("> Centímetros: " & valor * 100)
    End Sub
    Sub centimetro(valor As Integer)
        Console.WriteLine(vbTab & "Conversión CENTIMETROS")
        Console.WriteLine("> Pie: " & (valor * 2.54) / 12)
        Console.WriteLine("> Pulgadas: " & valor * 2.54)
        Console.WriteLine("> Yardas: " & ((valor * 100 * 2.54) / 12) / 3)
        Console.WriteLine("> Metros: " & valor / 100)
    End Sub
End Module
