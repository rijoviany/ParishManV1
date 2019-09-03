Public Class frmLauncher
    Friend Shared user As String
    Friend Shared roleid As Integer
    Dim err As New ErrorProvider
    Dim app As clsApplication
    Private Sub frmLauncher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If lblRoleid.Text = 1 Then
            btnSubregion.Visible = True
            btnForane.Visible = True
            btnParish.Visible = True

            mnuNewDiocese.Visible = True
            mnuNewForane.Visible = True
            mnuNewParish.Visible = True
            mnuNewSubstation.Visible = True
            mnuNewUser.Visible = True
        Else
            btnSubregion.Visible = False
            btnForane.Visible = False
            btnParish.Visible = False

            mnuNewDiocese.Visible = False
            mnuNewForane.Visible = False
            mnuNewParish.Visible = False
            mnuNewSubstation.Visible = False
            mnuNewUser.Visible = False
        End If

        Dim db As New dbOperations
            If lblDiocese.Text > 0 Then
                db.fillCombo("vw_alltable", "parishname", cboParish, "where dioceseid=" & lblDiocese.Text)
            End If
            If lblSubRegion.Text > 0 Then
                db.fillCombo("vw_alltable", "parishname", cboParish, "where sub_regionid=" & lblSubRegion.Text)
            End If
            If lblForane.Text > 0 Then
                db.fillCombo("vw_alltable", "parishname", cboParish, "where foraneid=" & lblForane.Text)
            End If
            If lblParish.Text > 0 Then
                db.fillCombo("vw_alltable", "parishname", cboParish, "where parishid=" & lblParish.Text)
            End If

            If lblDiocese.Text > 0 Or lblSubRegion.Text > 0 Or lblForane.Text > 0 Or lblParish.Text > 0 Then
            Else
                db.fillCombo("vw_alltable", "parishname", cboParish)
            End If

    End Sub

    Private Sub mnuNewDiocese_Click(sender As Object, e As EventArgs) Handles mnuNewDiocese.Click
        frmDiocese.ShowDialog()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub mnuNewRegion_Click(sender As Object, e As EventArgs) Handles mnuNewRegion.Click
        frmSubRegion.ShowDialog()
    End Sub

    Private Sub mnuNewForane_Click(sender As Object, e As EventArgs) Handles mnuNewForane.Click
        frmForane.ShowDialog()
    End Sub

    Private Sub mnuNewParish_Click(sender As Object, e As EventArgs) Handles mnuNewParish.Click
        frmParish.ShowDialog()
    End Sub

    Private Sub mnuNewBCCUnit_Click(sender As Object, e As EventArgs) Handles mnuNewBCCUnit.Click
        frmBccUnit.Show()
        'frmBccUnit.Parent = Me
    End Sub

    Private Sub mnuNewFamily_Click(sender As Object, e As EventArgs) Handles mnuNewFamily.Click
        frmFamily.Show()
    End Sub

    Private Sub mnuNewMember_Click(sender As Object, e As EventArgs) Handles mnuNewMember.Click
        frmFamilyMember.Show()
    End Sub

    Private Sub btnFamilyMember_Click(sender As Object, e As EventArgs) Handles btnFamilyMember.Click

        If cboFamily.Text.Trim.Length = 0 Then
            cboFamily.BackColor = Color.OrangeRed
            cboFamily.Focus()
            cboFamily.ToolTipText = "Choose Family"

        Else
            cboFamily.BackColor = Color.White
            cboFamily.ToolTipText = ""
            Dim db As New dbOperations
			Dim form As New frmParishioner
			form.MdiParent = Me
			'form.familyid = db.getStringFromDB("vw_alltable", "familyid", "  housename like '" & cboFamily.Text.Trim.Replace("'", "%") & "'")
			form.Show()
        End If
    End Sub

    Private Sub cboFamily_Click(sender As Object, e As EventArgs) Handles cboFamily.Click
        cboFamily.BackColor = Color.White
    End Sub

    Private Sub btnFamily_Click(sender As Object, e As EventArgs) Handles btnFamily.Click
        If cboBccunit.Text.Trim.Length = 0 Then
            cboBccunit.BackColor = Color.OrangeRed
            cboBccunit.Focus()
            cboBccunit.ToolTipText = "Choose Family"

        Else
            cboBccunit.BackColor = Color.White
            cboBccunit.ToolTipText = ""
            Dim db As New dbOperations
            Dim form As New frmFamily
            form.MdiParent = Me
            form.bccid = db.getId("bcc_unit", cboBccunit.Text, True)
            form.Show()
        End If
    End Sub

    Private Sub btnBccunit_Click(sender As Object, e As EventArgs) Handles btnBccunit.Click

    End Sub

    Private Sub cboParish_Click(sender As Object, e As EventArgs) Handles cboParish.SelectedIndexChanged
        cboBccunit.Text = ""
        cboFamily.Text = ""
        cboBccunit.Items.Clear()
        cboFamily.Items.Clear()
        If cboParish.Text.Trim.Length > 0 Then
            Dim db As New dbOperations
            db.fillCombo("vw_alltable", "bcc_unit", cboBccunit, " where parishname like '" & cboParish.Text.ToString & "'")
            cboBccunit.BackColor = Color.White
        End If
    End Sub

    Private Sub cboBccunit_Click(sender As Object, e As EventArgs) Handles cboBccunit.SelectedIndexChanged
        cboFamily.Text = ""
        cboFamily.Items.Clear()
        If cboBccunit.Text.Trim.Length > 0 Then
            Dim db As New dbOperations
            Dim bcc As String = cboBccunit.Text.Trim.Split(";").GetValue(0).ToString.Replace("'", "%").Trim
            Dim place As String = cboBccunit.Text.Trim.Split(";").GetValue(1).ToString.Trim
            db.fillCombo("vw_alltable", "housename", cboFamily, " where bcc_unitname like '" & bcc & "' and place like '" & place & "'")
        End If
    End Sub

    Private Sub UserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuNewUser.Click
        frmUsers.Show()
    End Sub

    Private Sub LoginHistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginHistoryToolStripMenuItem.Click
        frmLoginHistory.ShowDialog()
    End Sub

    Private Sub FamilyFinanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FamilyFinanceToolStripMenuItem.Click
        frmFinanceEntry.Show()
    End Sub


End Class

