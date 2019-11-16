Imports System

Module Program
    Sub Main(args As String())
        Dim ticket(6) As Char
        For x = 0 To ticket.Length - 1
            If x < 4 Then
                ticket(x) = validaNumero(x, ticket)
            Else
                ticket(x) = validaLetra(x, ticket)
            End If
        Next
        ordena(ticket)
        impresionTicket(ticket)
    End Sub
    Function validaLetra(L As Byte, ticket() As Char) As Char
        Dim letra As Char
        Do
            Console.Write("Ingrese letra ({0}):", L - 3)
            letra = Console.ReadLine
        Loop Until verificaRango("Letra", AscW(letra), AscW("A"), AscW("F"), "a") And validaRepetido(letra, ticket)
        Return letra
    End Function
    Function validaNumero(n As Byte, ticket() As Char) As Char
        Dim numero As Byte
        Do
            Console.Write("Ingrese número ({0}): ", n + 1)
            numero = Console.ReadLine
        Loop Until verificaRango("Número", numero, 0, 9, "o") And validaRepetido(Convert.ToChar(numero), ticket)
        Return Convert.ToString(numero)
    End Function
    Function verificaRango(texto As String, numero As Byte, valor1 As Byte, valor2 As Byte, caracter As Char) As Boolean
        If numero >= valor1 And numero <= valor2 Then
            Return True
        Else
            Console.WriteLine(texto & " inválid" & caracter)
            Return False
        End If
    End Function
    Function validaRepetido(numero As Char, ticket() As Char) As Boolean
        For Each m In ticket
            If numero = m Then
                Console.WriteLine("valor repetido, reintente.")
                Return False
            End If
        Next
        Return True
    End Function
    Sub ordena(ByRef ticket() As Char)
        Dim aux As Char
        For i = 0 To ticket.Length - 1
            For j = i + 1 To ticket.Length - 1
                If AscW(ticket(i)) > AscW(ticket(j)) Then
                    aux = ticket(j)
                    ticket(j) = ticket(i)
                    ticket(i) = aux
                End If
            Next
        Next
    End Sub
    Sub impresionTicket(ticket() As Char)
        Console.Clear()
        Console.Write("Su ticket es : ")
        For Each valor In ticket
            Console.Write(valor & " ")
        Next
    End Sub
End Module
