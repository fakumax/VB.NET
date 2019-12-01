Imports System

Module prueba

    Const cantidad As UShort = 10
    Private valor As New Random()
    Sub Main(args As String())
        Dim ticket(6) As Char
        ticket = elegirTicket(ticket)
        '-----------------------------------------------------
        Console.WriteLine("Sus 10 tickets para el sorteo son : ")
        Console.WriteLine()
        For x = 1 To cantidad
            Console.WriteLine(vbCrLf & "Cantidad de aciertos : " & compararTickets(ticket, GetOneTicket()))
            Console.WriteLine()
        Next
    End Sub
    Function compararTickets(ticket() As Char, tickets() As Char) As Byte
        Dim concuerdan As Byte
        For x = 0 To ticket.Length - 1
            For r = 0 To tickets.Length - 1
                If ticket(x) = tickets(r) Then
                    concuerdan += 1
                End If
            Next
        Next
        Return concuerdan
    End Function
    Private Function elegirTicket(ticket() As Char) As Char()
        For x = 0 To ticket.Length - 1
            If x < 4 Then
                ticket(x) = validaNumero(x, ticket)
            Else
                ticket(x) = validaLetra(x, ticket)
            End If
        Next
        ordena(ticket)
        impresionTicket(ticket)
        Return ticket
    End Function

    Sub impresionTicket(ticket() As Char)
        Console.Clear()
        Console.Write("Su ticket es : ")

        For x = 0 To ticket.Length - 1
            Console.Write(ticket(x) & " ")
        Next
        Console.WriteLine()
        Console.WriteLine()

    End Sub

    Function validaRepetido(numero As Char, ticket() As Char) As Boolean
        For Each m In ticket
            If numero = m Then
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
    Function GetOneTicket() As Char()
        Dim ticket(6) As Char
        For x = 0 To 3
            ticket(x) = GetNumero(ticket)
        Next
        For x = 4 To 6
            ticket(x) = GetLetra(ticket)
        Next
        ordena(ticket)
        For Each r In ticket
            Console.Write(r & " ")
        Next

        Return ticket
    End Function
    Function GetNumero(ticket() As Char) As Char
        Dim verifica As Char
        Do
            verifica = ChrW(valor.Next(49, 57))

        Loop Until validaRepetido(verifica, ticket)
        Return verifica

    End Function
    Function GetLetra(ticket() As Char) As Char
        Dim verifica As Char
        Do
            verifica = ChrW(valor.Next(65, 70))

        Loop Until validaRepetido(verifica, ticket)
        Return verifica


    End Function
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

End Module
