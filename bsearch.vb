Imports System.Math
Module Module1

    Sub BSearch()
        Dim Target As Integer
        Console.WriteLine("Input a number to search:")
        Target = Console.ReadLine()
        Dim NumberSet() As Integer = {25, 38, 49, 54, 67, 72, 92, 99}
        Dim Found As Boolean = False
        Dim O As Double = Math.Log(NumberSet.Length, 2) 'worst case time complexity when n = numberset.length
        Dim FailTracker As Integer = 0 'counts how many loops occured
        If NumberSet.Length = 1 Then
            Found = True
        End If
        Dim Mid As Integer = NumberSet.Length
        Dim NotPresent As Boolean = False
        While Found = False And NotPresent = False
            FailTracker += 1
            Mid = Math.Truncate(Mid / 2)
            If Target = NumberSet(Mid) Then
                Found = True
            ElseIf Target < NumberSet(Mid) Then
                Mid = Math.Truncate(Mid / 2)
            ElseIf Target > NumberSet(Mid) Then
                Mid = Math.Truncate(Mid + Math.Truncate(Mid / 2))
            End If
            If FailTracker > O Then 'checks if amount of loops is beyond the worst case time complexity
                NotPresent = True
            End If
            If Found = True Then
                Console.WriteLine("Item found!")
            ElseIf NotPresent = True Then
                Console.WriteLine("Item not found!")
            End If
        End While
        Console.ReadLine()
    End Sub

    Sub Main()
        BSearch()
    End Sub
End Module
