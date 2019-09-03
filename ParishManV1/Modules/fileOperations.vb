Imports System.Configuration
Imports System.IO

Public Class fileOperations

    Dim path As String = My.Settings.logpath.ToString



    Function read(file As String) As String
        Dim line As String
        Using reader As New StreamReader(path & "\" & file)
            line = reader.ReadLine()
        End Using
        Return line
    End Function


    Sub write(file As String, text As String)
        Using writer As New StreamWriter(path & "\" & file, True)
            writer.Write(text)
        End Using
    End Sub
End Class
