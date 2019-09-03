Public Class frmParish
    Dim err As New ErrorProvider

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        txtParishId.Clear()
        txtName.Clear()
        txtParishId.Clear()
        txtPlace.Clear()
        txtMontlyVari.Clear()
        txtFeastVari.Clear()

        cboForane.Text = ""
        cboParentParish.Text = ""
        btnSave.Text = "&Save"
        Dim db As New dbOperations
        db.fillCombo("forane", "foranename", cboForane)
        db.fillCombo("parish", "parishname", cboParentParish, " where  parent_parishid < 0")
        dgvParish.DataSource = db.fillData("vw_parish", "*").Tables(0)
        err.Clear()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnAddBcc_Click(sender As Object, e As EventArgs) Handles btnAddBcc.Click
        frmBccUnit.ShowDialog()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtParishId.Text.Trim.Length = 0 Then
        Else
            Dim db As New dbOperations
            Dim substation_count As Integer = Val(db.getStringFromDB("parish", "count(1)", " parent_parishid='" & txtParishId.Text & "' "))
            If substation_count = 0 Then
                db.deleteFromDB(Val(txtParishId.Text), "parish")
                btnNew.PerformClick()
            Else
                err.SetError(txtName, "remove substation parish before deleting main parish")
            End If
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If validat() Then
            If btnSave.Text = "&Save" Then
                Dim db As New dbOperations
                Dim foraneid As String = db.getStringFromDB("forane", "foraneid", " foranename like '%" & cboForane.Text.Trim & "%'")
                Dim pparishid As String
                If cboParentParish.Text.Trim.Length > 3 Then
                    pparishid = db.getStringFromDB("parish", "parishid", "parishname like '%" & cboParentParish.Text.Trim & "%' and parent_parishid < 0 ")
                Else
                    pparishid = "-1"
                End If
                Dim query As New MySql.Data.MySqlClient.MySqlCommand("INSERT INTO `parishdb`.`parish` (`parishname`, `foraneid`, `place`, `parent_parishid`,`createdby` ,`createddate`,`modifiedby`,`modifieddate`,`status`,`monthly_vari`,`feast_vari`) VALUES ( @parishname, @foraneid, @place, @parent_parishid,@createdby ,@createddate,@modifiedby,@modifieddate,@status,@monthly_vari,@feast_vari);")
                'db.instertToDB("INSERT INTO `parishdb`.`parish` ( `parishname`, `foraneid`, `place`, `parent_parishid`) VALUES ( '" & txtName.Text.Trim.Replace("'", "''") & "', " & Val(foraneid) & " , '" & txtPlace.Text.Trim.Replace("'", "''") & "'," & pparishid & ");")
                query.Parameters.AddWithValue("@" & txtName.Tag, txtName.Text.Trim)
                query.Parameters.AddWithValue("@" & txtPlace.Tag, txtPlace.Text.Trim)
                query.Parameters.AddWithValue("@foraneid", foraneid)
                query.Parameters.AddWithValue("@parent_parishid", pparishid)
                query.Parameters.AddWithValue("@createdby", frmLauncher.lblUser.Text)
                query.Parameters.AddWithValue("@createddate", Now())
                query.Parameters.AddWithValue("@modifiedby", frmLauncher.lblUser.Text)
                query.Parameters.AddWithValue("@modifieddate", Now())
                query.Parameters.AddWithValue("@status", True)
                query.Parameters.AddWithValue("@monthly_vari", Val(txtMontlyVari.Text))
                query.Parameters.AddWithValue("@feast_vari", Val(txtFeastVari.Text))
                db.instertToDB(query)
                btnNew.PerformClick()
            End If
        End If
    End Sub

    Function validat() As Boolean
        If txtName.Text.Trim.Length < 3 Then
            validat = False
            err.SetError(txtName, "enter valid parish name")
        Else
            err.Clear()
            validat = True
        End If

        If cboForane.Text.Trim.Length < 3 Then
            validat = False
            err.SetError(cboForane, "Select forane")
        Else
            err.Clear()
            validat = True
        End If
    End Function

    Private Sub dgvParish_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvParish.CellContentClick
        Dim i As Integer
        i = dgvParish.CurrentRow.Index
        Try
            txtParishId.Text = dgvParish.Item(txtParishId.Tag, i).Value
            txtPlace.Text = dgvParish.Item(txtPlace.Tag, i).Value
            txtName.Text = dgvParish.Item(txtName.Tag, i).Value

            cboForane.Text = dgvParish.Item(cboForane.Tag, i).Value
            cboParentParish.Text = dgvParish.Item(cboParentParish.Tag, i).Value
        Catch ex As Exception
            Console.Write(ex.Message)
        End Try
        'txtBishop.Text = dgvDiocese.Item("bishop", i).Value

    End Sub

    Private Sub frmParish_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnNew.PerformClick()
    End Sub
End Class