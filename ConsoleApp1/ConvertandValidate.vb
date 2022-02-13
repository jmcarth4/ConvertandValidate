'Jessica McArthur
'RCET0265
'Fall 2020
'Convert and Validate
'https://github.com/jmcarth4/ConvertandValidate

Option Explicit On
Option Strict On
Module ConvertandValidate
    'function converts a string to 32 bit integer
    Function ConversionValid(ByVal convertThisString As String, ByRef toThisInteger As Integer) As Boolean
        Dim status As Boolean
        Try
            toThisInteger = CInt(convertThisString)
            status = True
        Catch ex As Exception
            status = False
        End Try
        Return status
    End Function

    Sub Main()
        'for testing the function
        Dim aValidNumber As Integer
        Dim userResponse As String
        Dim numberConverted As Boolean = False
        Do Until numberConverted = True
            Console.WriteLine($"Enter a number:")
            userResponse = Console.ReadLine()
            If ConversionValid(userResponse, aValidNumber) = True Then
                Console.WriteLine($"{userResponse} converted successfully to {aValidNumber}!")
                numberConverted = True
            Else
                Console.WriteLine($"Oops, {userResponse} does not seem to be a number")
                numberConverted = False
            End If
        Loop
        Console.ReadLine()
    End Sub
End Module
