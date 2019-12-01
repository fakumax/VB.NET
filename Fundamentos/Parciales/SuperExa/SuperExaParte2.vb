Imports System

Module testing

    Const cantidad As UShort = 10
    Private valor As New Random()
    Sub Main(args As String())
        Console.WriteLine("Sus 10 tickets para el sorteo son : ")

        For x = 1 To cantidad
            GetOneTicket()
            Console.WriteLine()
        Next

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
End Module
