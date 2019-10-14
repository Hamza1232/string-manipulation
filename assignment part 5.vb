Module Module1

    Sub Main()
        Dim str1, str2, nextchar As String
        Dim count As Integer
        str1 = ""
        str2 = ""
        nextchar = ""
        count = 0
        Console.Write("kindly enter the string")
        str1 = Console.ReadLine
        For count = 1 To Len(str1)
            nextchar = Right(str1, count)

            str2 = str2 + nextchar


        Next

        Console.WriteLine("final string is " & str2)

        Console.ReadKey()

    End Sub

End Module

