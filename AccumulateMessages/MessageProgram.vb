
Imports System
Imports System.Net.Security

Module MessageProgram
    Sub Main(args As String())
        'uncomment to test interactively
        'Test.Manual()
        Test.Auto()
    End Sub

    Function UserMessages(ByVal newMessage As String, ByVal clear As Boolean) As String
        'your code here
        Dim messages As String = ""

        If clear Then
            messages = ""
        ElseIf newMessage = "" Then
            If messages = "" Then
                messages = ""
            Else
                messages = newMessage
            End If
        Else
            messages = CStr($"{messages}" & vbCrLf _
                & $"{newMessage}")
        End If

        Return messages
    End Function


End Module
