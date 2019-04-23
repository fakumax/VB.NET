Imports System

'1.8. Crear un proyecto y un programa que muestre las tablas de verdad booleanas (And, Or, Not y
'Xor)
Module Ej_1_08
    Sub Main(args As String())

        Console.WriteLine("TABLAS DE VERDAD" & vbLf & "AND :")
        Console.WriteLine("| P | Q |  P ^ Q  |")
        Console.WriteLine("| V | V |  " & (True And True) & "   |")
        Console.WriteLine("| V | F |  " & (True And False) & "  |")
        Console.WriteLine("| F | V |  " & (False And True) & "  |")
        Console.WriteLine("| F | F |  " & (False And False) & "  |")

        Console.WriteLine("OR :")
        Console.WriteLine("| P | Q |  P v Q  |")
        Console.WriteLine("| V | V |  " & (True Or True) & "   |")
        Console.WriteLine("| V | F |  " & (True Or False) & "   |")
        Console.WriteLine("| F | V |  " & (False Or True) & "   |")
        Console.WriteLine("| F | F |  " & (False Or False) & "  |")

        Console.WriteLine("NOT ^ :")
        Console.WriteLine("| P | Q |~(P ^ Q) |")
        Console.WriteLine("| V | V |  " & ((Not True) And (Not True)) & "  |")
        Console.WriteLine("| V | F |  " & ((Not True) And (Not False)) & "  |")
        Console.WriteLine("| F | V |  " & ((Not False) And (Not True)) & "  |")
        Console.WriteLine("| F | F |  " & ((Not False) And (Not False)) & "   |")

        Console.WriteLine("NOT v :")
        Console.WriteLine("| P | Q |~(P v Q) |")
        Console.WriteLine("| V | V |  " & ((Not True) Or (Not True)) & "  |")
        Console.WriteLine("| V | F |  " & ((Not True) Or (Not False)) & "   |")
        Console.WriteLine("| F | V |  " & ((Not False) Or (Not True)) & "   |")
        Console.WriteLine("| F | F |  " & ((Not False) Or (Not False)) & "   |")

        Console.WriteLine("XOR :")
        Console.WriteLine("| P | Q |  P v Q  |")
        Console.WriteLine("| V | V |  " & (True Xor True) & "  |")
        Console.WriteLine("| V | F |  " & (True Xor False) & "   |")
        Console.WriteLine("| F | V |  " & (False Xor True) & "   |")
        Console.WriteLine("| F | F |  " & (False Xor False) & "  |")

    End Sub
End Module
