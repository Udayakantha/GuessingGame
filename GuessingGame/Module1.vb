Module Module1

    Sub Main()
        Dim ChkValid = True

        While ChkValid

            Dim GN As String = Console.ReadLine()

            If IsNumeric(GN) Then

                If GN <= 100 And GN > 0 Then
                    If GN = 42 Then
                        ChkValid = False
                        Console.WriteLine("Correct")
                    Else
                        ChkValid = True
                        Console.WriteLine("Incorrect")
                    End If
                Else
                    ChkValid = True
                    Console.WriteLine("Wrong Input")
                End If
            Else
                ChkValid = True
                Console.WriteLine("Wrong Input")
            End If

            'If Not ChkValid Then
            '    Console.WriteLine("Correct")
            'Else
            '    Console.WriteLine("Incorrect")
            'End If

        End While


    End Sub

End Module
