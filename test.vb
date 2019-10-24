Module Module1

    Sub Main()
        Dim bstring, dstring, nextchar, nextch As String
        Dim count As Integer
        Dim validbinarystring As Boolean
        Dim multiplyingno As Integer
        nextch = ""
        count = 0
        bstring = ""
        dstring = ""
        nextchar = ""
        validbinarystring = False
        multiplyingno = 1


        Console.Write("Input your binary number: ")
        bstring = Console.ReadLine

        If Len(bstring) <= "8" Then
            validbinarystring = True
        Else
            validbinarystring = False
        End If

        For count = 1 To Len(bstring)
            nextchar = Mid(bstring, count, 1)
            If nextchar = "1" Or nextchar = "0" Then
                validbinarystring = True
            Else
                validbinarystring = False
            End If
        Next
        If validbinarystring = False Then
            Console.Write("Not a valid binary number.....")
        Else
            Console.Write("Valid binary number.....")
        End If
        For count = len(bstring) To 1 Step -1

            nextchar = mid(bstring, counter, 1)

            nextchar = nextchar * multiplyingno
            dstring = dstring + nextchar
            multiplyingno = multiplyingno * 2
        Next
        Console.WriteLine(bstring & "dstring")

        Console.ReadKey()

    End Sub

End Module
