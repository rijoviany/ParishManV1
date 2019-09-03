Public Class frmLogin

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim db As New dbOperations
        Dim userid As String
        Dim logid As Integer

        Dim query As New MySql.Data.MySqlClient.MySqlCommand("select userid from parishdb.users where username=@username and password=md5(@password);")
        query.Parameters.AddWithValue("@username", txtUsername.Text)
        query.Parameters.AddWithValue("@password", txtPassword.Text)
        userid = db.getStringFromDB("users", "userid", "  username='" & txtUsername.Text.Replace("'", "''") & "' and password=md5('" & txtPassword.Text.Replace("'", "''") & "')")
        Dim log As New MySql.Data.MySqlClient.MySqlCommand("INSERT INTO `parishdb`.`login_history` ( `userid`, `login_date`, `macname`, `username`, `isSuccess`) VALUES ( @userid, @login_date, @macname, @username, @isSuccess);")
        log.Parameters.AddWithValue("@userid", Val(userid))
        log.Parameters.AddWithValue("@login_date", Now())
        log.Parameters.AddWithValue("@macname", Environment.MachineName)
        log.Parameters.AddWithValue("@username", txtUsername.Text)
        log.Parameters.AddWithValue("@isSuccess", Val(userid) > 0)
        db.instertToDB(log)
        logid = Val(db.getStringFromDB("login_history", "max(login_historyid)", "1=1"))
        If Val(userid) > 0 Then
            'frmLauncher.roleid = roleid
            Me.Hide()
            Dim dt As New DataTable
            dt = db.fillData("users", "*", "where userid=" & userid).Tables(0)
            With frmLauncher
                .lblUser.Text = txtUsername.Text
                .lblStatus.Text = "Welcome"
                .lblLogin.Text = Now()
                .lblSessionToken.Text = logid
                .lblRoleid.Text = Val(dt.Rows(0).Item("roleid").ToString)
                .lblDiocese.Text = Val(dt.Rows(0).Item("dioceseid").ToString)
                .lblSubRegion.Text = Val(dt.Rows(0).Item("sub_regionid").ToString)
                .lblForane.Text = Val(dt.Rows(0).Item("foraneid").ToString)
                .lblParish.Text = Val(dt.Rows(0).Item("parishid").ToString)
                .Show()
            End With
            Me.Close()
        Else
            MessageBox.Show("Invalid username or password!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        'frmUsers.Show()
    End Sub


End Class