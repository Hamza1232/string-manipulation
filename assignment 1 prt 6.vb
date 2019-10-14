Module Module1

    Sub Main()
        Dim str1, str2, nextchar As String
        Dim count As Integer
        Dim anagram As Boolean
        str1 = ""
        str2 = ""
        nextchar = ""
        count = 0
        anagram = True

        Console.Write("Kindly input your first string: ")
        str1 = Console.ReadLine
        str1 = LCase(str1)

        Console.Write("Kindly input your second string: ")
        str2 = Console.ReadLine
        str2 = LCase(str2)

        For counter = 1 To Len(str1)
            nextchar = Mid(str1, counter, 1)
            If InStr(str2, nextchar) = 0 Then
                anagram = False
            End If
        Next
        If anagram = True Then
            Console.WriteLine("The two strings are anagram")
        Else

            Console.WriteLine("The two strings are not anagram")
        End If


        Console.ReadKey()
    End Sub

End Module
