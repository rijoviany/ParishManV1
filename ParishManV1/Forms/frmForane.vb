Public Class frmForane
    Dim subregionid As String
    Dim err As New ErrorProvider
    Private Sub frmForane_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New dbOperations
        db.fillCombo("sub_region", "sub_regionname", cboSubRegion)
        dgvForane.DataSource = db.fillData("vw_Forane", " * ").Tables(0)

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        txtId.Clear()
        txtName.Clear()
        cboSubRegion.Text = ""
        btnSave.Text = "&Save"
        Dim db As New dbOperations
        dgvForane.DataSource = db.fillData("vw_Forane", " * ").Tables(0)


    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If valid() Then
            If btnSave.Text = "&Save" Then
                Dim db As New dbOperations
                'db.instertToDB("INSERT INTO `parishdb`.`forane` (`name`, `sub_regionid`) VALUES ( '" & txtName.Text.Trim.Replace("'", "''") & "'," & IIf(cboSubRegion.Text.Length < 3, "'-1'", subregionid & ");"))
                Dim query As New MySql.Data.MySqlClient.MySqlCommand("INSERT INTO `parishdb`.`forane` ( `foranename`, `sub_regionid`,`createdby` ,`createddate`,`modifiedby`,`modifieddate`,`status`) VALUES (@foranename, @sub_regionid,@createdby ,@createddate,@modifiedby,@modifieddate,@status);")
                query.Parameters.AddWithValue(txtName.Tag, txtName.Text.Trim)
                query.Parameters.AddWithValue("@sub_regionid", subregionid)
				query.Parameters.AddWithValue("@createdby", frmLauncher.lblUser.Text)
				query.Parameters.AddWithValue("@createddate", Now())
				query.Parameters.AddWithValue("@modifiedby", frmLauncher.lblUser.Text)
				query.Parameters.AddWithValue("@modifieddate", Now())
				query.Parameters.AddWithValue("@status", True)
				If db.instertToDB(query) Then
                    MsgBox("success")
                    btnNew.PerformClick()
                End If
            End If
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub cboSubRegion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSubRegion.SelectedIndexChanged
        Dim db As New dbOperations
        subregionid = db.getStringFromDB("sub_region", "sub_regionid", " sub_regionname like '%" & cboSubRegion.Text.Trim & "%'")
    End Sub

    Function valid() As Boolean
        If txtName.Text.Trim.Length < 3 Then
            err.SetError(txtName, "Invalid Forane name")
            valid = False
        Else
            valid = True
            err.Clear()
        End If

        If cboSubRegion.Text.Trim.Length < 3 Then
            err.SetError(cboSubRegion, "Select Sub Region")
            valid = False
        Else
            err.Clear()
            valid = True
        End If

    End Function

    Private Sub dgvForane_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvForane.CellContentClick
        If dgvForane.SelectedCells.Count.Equals(0) Then
            btnSave.Text = "&Save"
        Else
            Dim i As Integer
            i = dgvForane.CurrentRow.Index
            txtId.Text = dgvForane.Item(txtId.Tag, i).Value
            txtName.Text = dgvForane.Item(txtName.Tag, i).Value
            cboSubRegion.Text = dgvForane.Item(cboSubRegion.Tag, i).Value
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtId.Text.Trim.Length > 0 Then
            Dim db As New dbOperations
            db.deleteFromDB(txtId.Text, "Forane")
        End If

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmParish.ShowDialog()
    End Sub
End Class