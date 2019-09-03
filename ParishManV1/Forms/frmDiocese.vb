Public Class frmDiocese
    Dim err As New ErrorProvider()
    Private Sub frmDiocese_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnNew.PerformClick()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If validateForm() Then
            If btnSave.Text.Equals("&Save") Then
                Dim query As New MySql.Data.MySqlClient.MySqlCommand("INSERT INTO `parishdb`.`diocese` ( `diocesename`, `bishop`, `rite`,`createdby` ,`createddate`,`modifiedby`,`modifieddate`,`status`) VALUES (@diocesename, @bishop, @rite,@createdby ,@createddate,@modifiedby,@modifieddate,@status);")
                query.Parameters.AddWithValue("@" & txtBishop.Tag, txtBishop.Text.Trim)
                query.Parameters.AddWithValue("@" & txtDioceseName.Tag, txtDioceseName.Text.Trim)
                query.Parameters.AddWithValue("@" & cboRite.Tag, cboRite.Text)

                query.Parameters.AddWithValue("@createdby", frmLauncher.lblUser.Text)
                query.Parameters.AddWithValue("@createddate", Now())
                query.Parameters.AddWithValue("@modifiedby", frmLauncher.lblUser.Text)
                query.Parameters.AddWithValue("@modifieddate", Now())
                query.Parameters.AddWithValue("@status", True)
                Dim db As New dbOperations
                If db.instertToDB(query) Then
                    'VALUES ( '" & Trim(txtDioceseName.Text.Replace("'", "''")) & "', '" & txtBishop.Text.Trim.Replace("'", "''") & "', '" & cboRite.Text.Trim.Replace("'", "''") & "');") Then
                    MsgBox("Saved")
                    btnNew.PerformClick()
                End If
            End If
        End If
    End Sub

    Function validateForm() As Boolean
        validateForm = False
        If txtBishop.Text.Length < 3 Then
            txtBishop.Focus()
            err.SetError(txtBishop, "Enter valid name")
            validateForm = False
        Else
            err.Clear()
            validateForm = True
        End If
        If Trim(txtDioceseName.Text.Length) < 3 Then
            txtDioceseName.Focus()
            err.SetError(txtDioceseName, "Enter valid name")
            validateForm = False
        Else
            err.Clear()
            validateForm = True
        End If

    End Function

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub dgvDiocese_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDiocese.CellContentClick
        Dim i As Integer
        i = dgvDiocese.CurrentRow.Index
        txtBishop.Text = dgvDiocese.Item(txtBishop.Tag.ToString, i).Value
        txtDioceseName.Text = dgvDiocese.Item(txtDioceseName.Tag.ToString, i).Value
        txtDioceseId.Text = dgvDiocese.Item(txtDioceseId.Tag.ToString, i).Value
        cboRite.Text = dgvDiocese.Item(cboRite.Tag.ToString, i).Value
        btnSave.Text = "&Update"
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        txtDioceseName.Clear()
        txtBishop.Clear()
        cboRite.Text = ""
        txtDioceseId.Clear()
        Dim db As New dbOperations

        dgvDiocese.DataSource = db.fillData("diocese", "*").Tables(0)
        btnSave.Text = "&Save"
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtDioceseId.Text.Equals("") Then

        Else
            Dim db As New dbOperations
            db.deleteFromDB(txtDioceseId.Text, "diocese")
            btnNew.PerformClick()
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmSubRegion.ShowDialog()
    End Sub
End Class