
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
        Static messages As String = ""

        If clear Then
            messages = ""
        ElseIf newMessage = "" Then
            If messages = "" Then
                messages = ""
            Else
            End If
        ElseIf messages = "" Then
            messages = newmessage
        Else
            messages = messages & vbCrLf _
                & newMessage
        End If

        Return messages
    End Function


End Module
