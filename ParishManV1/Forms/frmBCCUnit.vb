Public Class frmBccUnit
    Dim err As New ErrorProvider

    Private Sub FrmBCC_Unit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnNew.PerformClick()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        txtUnitId.Clear()
        txtName.Clear()
        txtPlace.Clear()
        cboLocalityType.Text = ""
        txtName.Focus()

        Dim db As New dbOperations
        db.fillCombo("parish", "concat(parishname,' ; ',place) as parish", cboParish)
        For i As Integer = 0 To db.fillData("bcc_unit", "place").Tables(0).Rows.Count - 1
            txtPlace.AutoCompleteCustomSource.Add(db.fillData("bcc_unit", "place").Tables(0).Rows.Item(i).Item(0).ToString)
        Next

        dgvBccUnit.DataSource = db.fillData("vw_bcc_unit", "*").Tables(0)

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtUnitId.Text.Trim.Length > 0 Then
            Dim db As New dbOperations
            db.deleteFromDB(txtUnitId.Text, "bcc_unit")
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If valid() Then
            If btnSave.Text = "&Save" Then
                Dim parish As String = cboParish.Text.Trim.Replace(" ; ", "$")
                Dim parishname As String = parish.Split("$").GetValue(0)
                Dim place As String = parish.Split("$").GetValue(1)
                Dim db As New dbOperations
                Dim parishid As String = db.getStringFromDB("parish", "parishid", " parishname like '%" & parishname & "%' and place like '%" & place & "%'")
                Dim query As New MySql.Data.MySqlClient.MySqlCommand("INSERT INTO `parishdb`.`bcc_unit` ( `bcc_unitname`, `place`, `parishid`, `locality_type`,`createdby` ,`createddate`,`modifiedby`,`modifieddate`,`status`,`ward_no`) VALUES ( @bcc_unitname, @place,  @parishid, @locality_type,@createdby ,@createddate,@modifiedby,@modifieddate,@status,@ward_no);")
                query.Parameters.AddWithValue("@" & txtName.Tag, txtName.Text)
                query.Parameters.AddWithValue("@" & txtPlace.Tag, txtPlace.Text)
                query.Parameters.AddWithValue("@" & cboLocalityType.Tag, cboLocalityType.Text)
                query.Parameters.AddWithValue("@parishid", parishid)

                query.Parameters.AddWithValue("@createdby", frmLauncher.lblUser.Text)
                query.Parameters.AddWithValue("@createddate", Now())
                query.Parameters.AddWithValue("@modifiedby", frmLauncher.lblUser.Text)
                query.Parameters.AddWithValue("@modifieddate", Now())
                query.Parameters.AddWithValue("@status", True)
                query.Parameters.AddWithValue("@ward_no", txtWardNo.Text.Trim)
                If db.instertToDB(query) Then
                    btnNew.PerformClick()
                End If
            End If
        End If
    End Sub

    Function valid() As Boolean
        If txtName.Text.Trim.Length < 3 Then
            err.SetError(txtName, "Invalid BCC name")
            txtName.Select()
            valid = False
        Else
            err.Clear()
            valid = True
        End If

        If txtPlace.Text.Trim.Length < 3 Then
            err.SetError(txtPlace, "Invalid place")
            txtPlace.Select()
            valid = False
        Else
            err.Clear()
            valid = True
        End If

        If cboParish.Text.Trim.Length < 3 Then
            err.SetError(cboParish, "Select parish")
            cboParish.Select()
            valid = False
        Else
            err.Clear()
            valid = True
        End If

        If txtWardNo.Text.Trim.Length = 0 Then
            err.SetError(txtWardNo, "Ward number cannot be blank")
            txtWardNo.Select()
            valid = False
        Else
            err.Clear()
            valid = True
        End If

    End Function

    Private Sub dgvBccUnit_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBccUnit.CellContentClick
        If dgvBccUnit.SelectedCells.Count.Equals(0) Then
            btnSave.Text = "&Save"
        Else
            Dim i As Integer
            i = dgvBccUnit.CurrentRow.Index
            txtUnitId.Text = dgvBccUnit.Item(txtUnitId.Tag, i).Value
            txtName.Text = dgvBccUnit.Item(txtName.Tag, i).Value
            cboLocalityType.Text = dgvBccUnit.Item(cboLocalityType.Tag, i).Value
            txtPlace.Text = dgvBccUnit.Item("unitplace", i).Value
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmFamily.ShowDialog()
    End Sub
End Class