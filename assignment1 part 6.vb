Module Module1

    Sub Main()
        Dim str1, str2, nextchar As String
        Dim count As Integer
        Dim completed As Boolean

        str1 = ""
        str2 = ""
        nextchar = ""
        count = 0
        completed = False

        Console.Write(" input  first string: ")
        str1 = Console.ReadLine

        Console.Write(" input  second string: ")
        str2 = Console.ReadLine

        If Len(str1) = Len(str2) Then
            For counter = 1 To Len(str1)

                nextchar = Mid(str1, count, 1)
                If InStr(str2, nextchar) = 0 Then
                    completed = False
                    End

                    Console.Write("Sorry strings are not anagram")
                Else
                    completed = True
                    Console.Write("both the strings are anagram")
                End If
            Next
        Else
            completed = False
            Console.Write("Sorry  lenght of the strings are not equal")
        End If
        Console.ReadKey()

    End Sub

End Module
