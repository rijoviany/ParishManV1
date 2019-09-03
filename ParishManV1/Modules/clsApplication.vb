Public Class clsApplication
    Public user As String = ""
    Public roleid As Integer

    Public Sub SetApp(user As String, roleid As Integer)
        Me.user = user
        Me.roleid = roleid
    End Sub

    Public Function getUser() As String
        Return Me.user
    End Function

    Public Function getRole() As Integer
        Return Me.roleid
    End Function


End Class
