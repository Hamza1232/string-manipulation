Module Module1

    Sub Main()
        Dim alphabet, specialchar, str1, nextchar, numbers As String
        Dim count As Integer

        alphabet = ""
        numbers = ""
        specialchar = ""
        str1 = ""
        count = 0
        nextchar = ""

        Console.Write("plz enter your string: ")
        str1 = Console.ReadLine

        For count = 1 To Len(str1)
            nextchar = Mid(str1, count, 1)

            If UCase(nextchar >= "a" And nextchar <= "z") Then
                alphabet = alphabet + nextchar


            ElseIf nextchar >= "0" And nextchar <= "9" Then
                numbers = numbers + nextchar
            Else
                specialchar = specialchar + nextchar
            End If

        Next

        Console.WriteLine("specialchar: " & specialchar)
        Console.WriteLine("numbers: " & numbers)
        Console.WriteLine("alphabet: " & alphabet)
        Console.ReadKey()
    End Sub

End Module
