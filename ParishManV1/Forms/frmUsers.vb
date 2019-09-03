Public Class frmUsers
    Dim err As New ErrorProvider
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        txtUsername.Clear()
        txtPassword.Clear()
        txtRepeatPassword.Clear()
        cboBccUnit.Text = ""
        cboDiocese.Text = ""
        cboForane.Text = ""
        cboParish.Text = ""
        cboSubregion.Text = ""
        txtUsername.Focus()
        btnSave.Text = "&Save"
        Dim db As New dbOperations
        db.fillCombo("vw_alltable", "diocesename", cboDiocese, True)
        dgvUsers.DataSource = db.fillData("users", "*").Tables(0)
    End Sub

    Private Sub frmUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnNew.PerformClick()
        '1. Admin
        '2. Parish Priest
        '3. Data Entry
        '4. Finance
        '5. Education
    End Sub

    Private Sub cboDiocese_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDiocese.SelectedIndexChanged
        Dim db As New dbOperations
        db.fillCombo("vw_alltable", "sub_regionname", cboSubregion, True)
        cboSubregion.Text = ""
        cboForane.Text = ""
        cboParish.Text = ""
        cboBccUnit.Text = ""

    End Sub

    Private Sub cboSubregion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSubregion.SelectedIndexChanged
        Dim db As New dbOperations
        db.fillCombo("vw_alltable", "foranename", cboForane, True)
        cboForane.Text = ""
        cboParish.Text = ""
        cboBccUnit.Text = ""

    End Sub

    Private Sub cboForane_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboForane.SelectedIndexChanged
        Dim db As New dbOperations
        db.fillCombo("vw_alltable", "parishname", cboParish, True)
        cboParish.Text = ""
        cboBccUnit.Text = ""

    End Sub

    Private Sub cboParish_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboParish.SelectedIndexChanged
        Dim db As New dbOperations
        db.fillCombo("vw_alltable", "bcc_unitname", cboBccUnit, True)
        cboParish.Text = ""
        cboBccUnit.Text = ""

    End Sub

    Private Sub txtRepeatPassword_TextChanged(sender As Object, e As EventArgs) Handles txtRepeatPassword.Leave

        If Not txtPassword.Text.Equals(txtRepeatPassword.Text) And txtPassword.Text.Length > 0 Then
            err.SetError(txtRepeatPassword, "Password not matching")
            txtRepeatPassword.Select()
        Else
            err.Clear()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If btnSave.Text = "&Save" Then
            If valid() Then
                Dim db As New dbOperations
                Dim query As New MySql.Data.MySqlClient.MySqlCommand("INSERT INTO `parishdb`.`users` ( `username`, `password`, `roleid`,  `bcc_unitid`, `parishid`, `foraneid`, `sub_regionid`, `dioceseid`) VALUES (@username, md5(@password), @roleid, @bcc_unitid, @parishid, @foraneid, @sub_regionid, @dioceseid); ")
                query.Parameters.AddWithValue("@username", txtUsername.Text.Trim)
                query.Parameters.AddWithValue("@password", txtPassword.Text)
				query.Parameters.AddWithValue("@roleid", Val(cboRole.Text.Split(".").GetValue(0)))
				query.Parameters.AddWithValue("@bcc_unitid", Val(cboBccUnit.Text.Split(".").GetValue(0)))
                query.Parameters.AddWithValue("@parishid", Val(cboParish.Text.Split(".").GetValue(0)))
                query.Parameters.AddWithValue("@foraneid", Val(cboForane.Text.Split(".").GetValue(0)))
                query.Parameters.AddWithValue("@sub_regionid", Val(cboSubregion.Text.Split(".").GetValue(0)))
                query.Parameters.AddWithValue("@dioceseid", Val(cboDiocese.Text.Split(".").GetValue(0)))
                If db.instertToDB(query) Then
                    btnNew.PerformClick()
                Else
                    MsgBox("could not save!")
                End If
            End If
        End If

    End Sub

    Function valid() As Boolean
        valid = True
        If txtUsername.Text.Trim.Length = 0 Then
            err.SetError(txtUsername, "User Name cannot be blank")
            valid = False
            Dim exists As String
            Dim db As New dbOperations
            exists = db.getStringFromDB("users", "count(username)", " where username like '" & txtUsername.Text.Trim & "'")
            If Not exists.Equals(0) Then
                err.SetError(txtUsername, "user name already exists")
            End If
        End If
        If txtPassword.Text.Length < 5 Then
            err.SetError(txtPassword, "Password should have atleast 4 letters")
            valid = False
        End If
        If cboRole.Text.Equals("1. Admin") And cboDiocese.Text.Trim.Length = 0 Then

        End If

    End Function

	Private Sub dgvUsers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsers.CellContentClick
		Dim i As Integer
		i = dgvUsers.CurrentRow.Index
		txtUsername.Text = dgvUsers.Item(txtUsername.Tag.ToString, i).Value
		txtPassword.Clear()
		txtRepeatPassword.Clear()
		cboRole.Text = dgvUsers.Item("roleid", i).Value
		'Dim db As New dbOperations
		'cboDiocese.Text = db.getStringFromDB("Diocese", "DioceseName", "  dioceseid=" & dgvUsers.Item("dioceseid", i).Value)
		'cboSubregion.Text = db.getStringFromDB("Sub_Region", "Sub_RegionName", "  sub_regionid=" & dgvUsers.Item("sub_regionid", i).Value)
		'cboForane.Text = db.getStringFromDB("Forane", "ForaneName", "  Foraneid=" & dgvUsers.Item("Foraneid", i).Value)
		'cboParish.Text = db.getStringFromDB("Parish", "ParishName", "  Parishid=" & dgvUsers.Item("Parishid", i).Value)
		'cboBccUnit.Text = db.getStringFromDB("Bcc_unit", "Bcc_unitName", "  Bcc_unitid=" & dgvUsers.Item("Bcc_unitid", i).Value)

		btnSave.Text = "&Update"
	End Sub
End Class