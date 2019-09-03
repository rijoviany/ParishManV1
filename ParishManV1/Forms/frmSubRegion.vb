Public Class frmSubRegion
    Dim err As New ErrorProvider
    Dim dioceseid As String
    Private Sub frmSubRegion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnNew.PerformClick()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        txtId.Clear()
        txtName.Clear()
        btnSave.Text = "&Save"
        Dim db As New dbOperations
        db.fillCombo("diocese", "diocesename", cboDiocese)
        dgvSubRegion.DataSource = db.fillData("sub_region", "sub_regionid,sub_regionname ,diocesename  ", " join parishdb.diocese on diocese.dioceseid=sub_region.sub_regionid").Tables(0)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If validat() Then
            If btnSave.Text.Equals("&Save") Then
                Dim db As New dbOperations
                Dim query As New MySql.Data.MySqlClient.MySqlCommand("INSERT INTO `parishdb`.`sub_region` ( `sub_regionname`, `dioceseid`,`createdby` ,`createddate`,`modifiedby`,`modifieddate`,`status`) VALUES (@sub_regionname, @dioceseid,@createdby ,@createddate,@modifiedby,@modifieddate,@status);")
                query.Parameters.AddWithValue(txtName.Tag, txtName.Text.Trim)
                query.Parameters.AddWithValue("@dioceseid", dioceseid)
                query.Parameters.AddWithValue("@createdby", frmLauncher.lblUser.Text)
                query.Parameters.AddWithValue("@createddate", Now())
                query.Parameters.AddWithValue("@modifiedby", frmLauncher.lblUser.Text)
                query.Parameters.AddWithValue("@modifieddate", Now())
                query.Parameters.AddWithValue("@status", True)
                If db.instertToDB(query) Then
                    MsgBox("Saved")
                    btnNew.PerformClick()
                Else
                    MsgBox("Error! not saved")
                End If
            Else

                End If
        End If
    End Sub

    Function validat() As Boolean
        'validate = False
        If txtName.Text.Trim.Length < 3 Then
            err.SetError(txtName, "Enter valid name")
            txtName.Select()
            validat = False
        Else
            err.Clear()
            validat = True
        End If

        If cboDiocese.Text.Trim.Length < 3 Then
            err.SetError(cboDiocese, "Enter valid diocese")
            cboDiocese.Focus()
            validat = False
        Else
            err.Clear()
            validat = True
        End If
        Return validat()

    End Function

    Private Sub dgvSubRegion_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSubRegion.CellContentClick
        If dgvSubRegion.SelectedCells.Count.Equals(0) Then
            btnSave.Text = "&Save"
        Else
            Dim i As Integer
            i = dgvSubRegion.CurrentRow.Index
            txtId.Text = dgvSubRegion.Item(txtId.Tag, i).Value
            txtName.Text = dgvSubRegion.Item(txtName.Tag, i).Value
            cboDiocese.Text = dgvSubRegion.Item(cboDiocese.Tag, i).Value
        End If

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtId.Text.Equals("") Then

        Else
            Dim db As New dbOperations
            db.deleteFromDB(txtId.Text, "sub_region")
            btnNew.PerformClick()
        End If
    End Sub

    Private Sub cboDiocese_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDiocese.SelectedIndexChanged
        Dim db As New dbOperations
        dioceseid = db.getStringFromDB("diocese", "dioceseid", " diocesename like '%" & cboDiocese.Text.Trim & "%'")
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmForane.ShowDialog()
    End Sub
End Class