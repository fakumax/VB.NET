Imports System
Imports System.Math
'3.15. Crear un proyecto y un módulo “Deposito” para resolver el siguiente planteo: se
'deposita un capital a un plazo de n meses, con una tasa de interés de 36% anual (es una
'constante), capitalizable cada mes, es decir, se suman los intereses ganados al capital.
'Elaborar un algoritmo que ingrese el capital inicial, la cantidad de meses y luego imprima el
'siguiente reporte:
'MES CAPITAL INTERES SALDO
'1 99,999.99 99,999.99 99,999.99
'2 99,999.99 99,999.99 99,999.99
'x xx, xxx.xx xx,xxx.xx xx,xxx.xx
'n 99, 999.99 99, 999.99 99, 999.99
'TOTAL INTERES GANADO: 99,999.99
'Donde:
'MES: es el número de mes.
'CAPITAL: en el primer mes es el capital inicial y en los meses siguientes es el saldo
'acumulado anterior. Por ejemplo, en el mes 1, el capital es el ingresado, para el mes 2,
'deberá tener incrementado el interés que ganó en el mes 1, y así sucesivamente.
'INTERES: es el capital por la tasa mensual de interés (tasa anual / 12), osea es el valor
'que gana en el mes correspondiente.
'SALDO: es el el capital sumado el interés.
'TOTAL INTERES GANADO: es la sumatoria de los intereses mensuales.
Module Deposito
    'Interes Anual=36%   Mensual 36/12=3
    Private Const interesMensual As Byte = 3
    Sub Main(args As String())
        Dim capital As Single
        Dim cantidadMeses As UShort
        depositoDatos(capital, cantidadMeses)
        Console.WriteLine("TOTAL INTERES GANADO : " & Reporte(capital, cantidadMeses))
    End Sub
    Sub depositoDatos(ByRef capital As Single, ByRef cantidadMeses As UShort)
        Console.Write("Ingrese el capital inicial : ")
        capital = Console.ReadLine
        Console.Write("Ingrese cantidad de meses : ")
        cantidadMeses = Console.ReadLine
    End Sub
    Function Reporte(capital As Single, cantidadMeses As UShort) As String
        Dim interesGanado As Decimal
        Dim total As Decimal
        Dim interesTotal As Decimal
        Console.WriteLine("MES" & vbTab & "CAPITAL" & vbTab & "INTERES" & vbTab & "  SALDO")
        For mes = 1 To cantidadMeses
            interesGanado = capital / 100 * interesMensual
            interesTotal += interesGanado
            total = interesGanado + capital
            Console.Write("{0}" & vbTab, mes)
            Console.Write("{0}" & vbTab, Math.Round(capital, 2))
            Console.Write("{0}" & vbTab, Math.Round(interesGanado, 2))
            Console.WriteLine("{0}" & vbTab, Math.Round(total, 2))
            capital += interesGanado
        Next
        Return Math.Round(interesTotal, 2)
    End Function
End Module
