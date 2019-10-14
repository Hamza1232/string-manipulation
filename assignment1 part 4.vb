Module Module1

    Sub Main()
        Dim str1, nextchar, str2 As String
        Dim count As Integer
        str1 = ""
        nextchar = ""
        str2 = ""
        count = 0

        Console.Write("Kindly enter the string: ")
        str1 = Console.ReadLine
        For count = 1 To Len(str1)
            nextchar = Mid(str1, count, 1)
            If nextchar >= LCase("A") And nextchar <= LCase("Z") Then
                str2 = str2 + nextchar
            Else

                str2 = str2 + "*"
            End If
        Next
        Console.WriteLine("The final output is: " & str2)
        Console.ReadKey()
    End Sub

End Module
