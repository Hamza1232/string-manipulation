Module Module1

    Sub Main()
        Dim str1, str2, nextchar, firstword, secondword As String
        Dim SP As Integer

        str1 = ""
        str2 = ""
        nextchar = ""
        firstword = ""
        secondword = ""
        SP = 0

        Console.Write("Kindly enter the first string: ")
        str1 = Console.ReadLine
        Console.Write("Kindly enter the second string: ")
        str2 = Console.ReadLine

        SP = InStr(str1, " ")
        firstword = Left(str1, SP - 1)

        SP = InStr(str2, " ")
        secondword = Right(str2, Len(str2) - SP)

        Console.WriteLine("Final String = " & firstword & " " & secondword)
        Console.ReadKey()
    End Sub

End Module
