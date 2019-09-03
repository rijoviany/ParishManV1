Public Class frmLoginHistory
    Private Sub frmLoginHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New dbOperations
        dgvLoginHistory.DataSource = db.fillData("login_history", "*", "order by 1 desc").Tables(0)
    End Sub

    Private Sub dtpTo_ValueChanged(sender As Object, e As EventArgs) Handles dtpTo.ValueChanged, dtpFrom.ValueChanged

        Dim db As New dbOperations
        db.fillData("login_history", "*", "where username like '%" & txtSearch.Text.Replace("'", "%") & "%' and login_date between '" & dtpFrom.Value.ToShortDateString & "' and '" & dtpTo.Value.ToShortDateString & "' order by 1 desc ")
    End Sub

    Private Sub llblClear_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblClear.LinkClicked
        Dim db As New dbOperations
        dgvLoginHistory.DataSource = db.fillData("login_history", "*", "order by 1 desc").Tables(0)
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim db As New dbOperations
        db.fillData("login_history", "*", "where username like '%" & txtSearch.Text.Replace("'", "%") & "%' and  login_date between '" & dtpFrom.Value.ToShortDateString & "' and '" & dtpTo.Value.ToShortDateString & "' order by 1 desc")

    End Sub
End Class