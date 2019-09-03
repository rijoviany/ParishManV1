Public Class frmFamilyMember
    Public familyid As String = ""
    Dim err As New ErrorProvider

    Private Sub CheckBox15_CheckedChanged(sender As Object, e As EventArgs) Handles cbOtherDisbilities.CheckedChanged
        If txtOtherDisease.Text.Trim.Length < 1 Then
            txtOtherDisease.Visible = False
            cbOtherDisbilities.Visible = True
        Else
            txtOtherDisease.Visible = True
            cbOtherDisbilities.Visible = False
        End If
    End Sub

    Private Sub txt_Leave(sender As Object, e As EventArgs) Handles txtOtherDisease.Leave
        If txtOtherDisease.Text.Trim.Length = 0 Then
            txtOtherDisease.Visible = False
            cbOtherDisbilities.Visible = True
            cbOtherDisbilities.Checked = False
        End If
    End Sub

    Private Sub cboMonthlyIncome_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMonthlyIncome.GotFocus
        If cboMonthlyIncome.Text.Trim.Length = 0 Then
            Label18.Visible = True
        Else
            Label18.Visible = False
        End If
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        tpMember.Show()
    End Sub

    Private Sub frmFamilyMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnNew.PerformClick()
        MsgBox(familyid)
        If familyid.Length > 0 Then
            Dim db As New dbOperations
            txtHouseName.Text = db.getStringFromDB("family", "housename", " familyid=" & familyid)
        Else
            MsgBox("Please choose family to add")
            LinkLabel4_LinkClicked(sender, e)
        End If
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click

        'text box
        txtAwards.Clear()
        txtBaptisamName.Clear()
        txtBaptismAddress.Clear()
        txtBaptismMinister.Clear()
        txtBaptismSlNo.Clear()
        txtBaptismPageNo.Clear()
        txtAltMobile.Clear()
        txtMobile.Clear()
        txtBaptismVolume.Clear()
        txtCommunionIfOtherChurch.Clear()
        txtCommunionMinister.Clear()
        txtCommunionPageNo.Clear()
        txtCommunionParishPriest.Clear()
        txtCommunionSlNo.Clear()
        txtCommunionVolume.Clear()
        txtConfirmationAddress.Clear()
        txtConfirmationMinister.Clear()
        txtConfirmationPageNo.Clear()
        txtConfirmationParishPriest.Clear()
        txtConfirmationSlNo.Clear()
        txtConfirmationVolume.Clear()
        txtCountry.Clear()
        txtFirstWitness.Clear()
        txtGodfather.Clear()
        txtGodmother.Clear()
        'txtHouseName.Clear()
        txtInstitute.Clear()
        txtJob.Clear()
        txtJobDisease.Clear()
        txtMarriageAddressOther.Clear()
        txtMarriagePageNo.Clear()
        txtMarriageSlNo.Clear()
        txtMarriageVolume.Clear()
        txtMarrigeMinister.Clear()
        txtMemberID.Clear()
        txtName.Clear()
        txtNameOfBride.Clear()
        txtNameOfBrideGrooms.Clear()
        txtOtherDisease.Clear()
        txtOtherIncurableDisease.Clear()
        txtOtherInstitute.Clear()
        txtSearch.Clear()
        txtSecondWitness.Clear()
        txtTalents.Clear()



        'combo box
        cbo1stHQ.Text = ""
        cbo2ndHQ.Text = ""
        cbo3rdHQ.Text = ""
        cboBloodGroup.Text = ""
        cboMaritalStatus.Text = ""
        cboMonthlyIncome.Text = ""
        cboRelationship.Text = ""


        'radio button
        rb2ndHqfail.Checked = False
        rb2ndHQna.Checked = False
        rb2ndHQpass.Checked = False
        rb2ndHqstudent.Checked = False
        rb3rdHQfail.Checked = False
        rb3rdHQna.Checked = False
        rb3rdHqpass.Checked = False
        rb3rdHQstudent.Checked = False
        rbFemale.Checked = False
        rbHQFail.Checked = False
        rbHQNA.Checked = False
        rbHQPass.Checked = False
        rbHQStudent.Checked = False
        rbmale.Checked = False

        'checkbox
        cbAadhar.Checked = False
        cbAlcoholic.Checked = False
        cbBankac.Checked = False
        cbBlind.Checked = False
        cbBloodPreasure.Checked = False
        cbCancer.Checked = False
        cbDeaf.Checked = False
        cbDiabetics.Checked = False
        cbDrivingLicence.Checked = False
        cbDumb.Checked = False
        cbESI.Checked = False
        cbHeartDisease.Checked = False
        cbInsurance.Checked = False
        cbIsAbroad.Checked = False
        cbIsGovt.Checked = False
        cbIsPrivate.Checked = False
        cbIsSelfEmployment.Checked = False
        cbIsSemiGovt.Checked = False
        cbLearningDisability.Checked = False
        cbMentalDisability.Checked = False
        cbOtherDisbilities.Checked = False
        cbPassport.Checked = False
        cbPension.Checked = False
        cbPF.Checked = False
        cbSmoking.Checked = False
        cbSocialWelfare.Checked = False



        'checked list box
        For item = 0 To clbMinistriesActive.Items.Count - 1
            clbMinistriesActive.SetItemChecked(item, False)
        Next

        'date
        dtpDOB.Value = "1/1/1900"
        dtpBaptisamDate.Value = "1/1/1900"
        dtpCommunionDate.Value = "1/1/1900"
        dtpConfirmationDate.Value = "1/1/1900"
        dtpMarriageDate.Value = "1/1/1900"

        'dgv
        Dim db As New dbOperations
        dgvFamilies.DataSource = db.fillData("vw_alltable", "familyid,housename,memberid,membername,dob,relationship,marital_status", " where familyid=" & familyid & " ;").Tables(0)

    End Sub

    Private Sub txtCountry_TextChanged_1(sender As Object, e As EventArgs) Handles txtCountry.TextChanged
        If txtCountry.Text.Trim.Length = 0 Then
            Label26.Visible = True
        Else
            Label26.Visible = False
        End If
    End Sub

    Private Sub llblSearch_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblSearch.LinkClicked
        tpFamilyMember.SelectTab(0)
    End Sub

    Private Sub llblSacraments_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblSacraments.LinkClicked
        tpFamilyMember.SelectTab(2)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        tpFamilyMember.SelectTab(1)
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        tpFamilyMember.SelectTab(3)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If valid() Then
            If btnSave.Text = "&Save" Then
                Dim db As New dbOperations
                Dim query As New MySql.Data.MySqlClient.MySqlCommand("INSERT INTO `parishdb`.`member` ( `familyid`, `membername`, `dob`, `gender`, `marital_status`, 
`relationship`, `mobile_number`, `alt_mobile_number`, `have_passport`, `have_bankac`, `have_drivinglic`, `have_aadhar`, `blood_group`, 
`highest1_qualification`, `highest2_qualification`, `highest3_qualification`, `highest1_qualification_status`, `highest2_qualification_status`, 
`highest3_qualification_status`, `talents`, `awards`, `have_blindness`, `have_deaf`, `have_dumb`, `have_other_disability`, `have_learning_disability`,
`have_mental_disability`, `have_heartdisease`, `have_diabetics`, `have_cancer`, `have_bp`, `other_disease`, `job_disease`, `is_alcoholic`, `other_incurabledisease`,
`is_smoking`, `job`, `institute`, `is_govt`, `is_private`, `is_semigovt`, `is_selfemployment`, `is_abroad`, `country`, `have_pension`, `have_insurance`, `have_social_welfare`,
`have_esi`, `have_pf`, `monthly_income`, `baptismname`, `god_father`, `god_mother`, `baptism_date`, `baptism_pgno`, `baptism_slno`, `baptism_volume`, `baptism_minister`, 
`confirmation_minister`, `confirmation_date`, `confirmation_parishpriest`, `confirmation_ifotherchurch`, `communion_minister`, `communion_date`, `communion_parishpriest`,
`communion_ifotherchurch`, `marriage_date`, `marriage_minister`, `marriage_ifotherchurch`, `active_ministries`,`createdby` ,`createddate`,`modifiedby`,`modifieddate`,`status`) VALUES ( @familyid, @membername, @dob, @gender, @marital_status,
@relationship, @mobile_number, @alt_mobile_number, @have_passport, @have_bankac, @have_drivinglic, @have_aadhar, @blood_group, @highest1_qualification, 
@highest2_qualification, @highest3_qualification, @highest1_qualification_status, @highest2_qualification_status, @highest3_qualification_status, @talents, @awards, 
@have_blindness, @have_deaf, @have_dumb, @have_other_disability, @have_learning_disability, @have_mental_disability, @have_heartdisease, @have_diabetics, @have_cancer,
@have_bp, @other_disease, @job_disease, @is_alcoholic, @other_incurabledisease, @is_smoking, @job, @institute, @is_govt, @is_private, @is_semigovt, @is_selfemployment,
@is_abroad, @country, @have_pension, @have_insurance, @have_social_welfare, @have_esi, @have_pf, @monthly_income, @baptismname, @god_father, @god_mother, @baptism_date, 
@baptism_pgno, @baptism_slno, @baptism_volume, @baptism_minister, @confirmation_minister, @confirmation_date,
@confirmation_parishpriest, @confirmation_ifotherchurch, @communion_minister, @communion_date, @communion_parishpriest, @communion_ifotherchurch, @marriage_date,
@marriage_minister, @marriage_ifotherchurch, @active_ministries,@createdby ,@createddate,@modifiedby,@modifieddate,@status);")

                'query.Parameters.AddWithValue("@memberid",)
                query.Parameters.AddWithValue("@familyid", Me.familyid)
                query.Parameters.AddWithValue("@membername", txtName.Text.Trim)
                query.Parameters.AddWithValue("@dob", dtpDOB.Value)
                query.Parameters.AddWithValue("@gender", IIf(rbmale.Checked = True, "M", "F"))
                query.Parameters.AddWithValue("@marital_status", cboMaritalStatus.Text.Trim)
                query.Parameters.AddWithValue("@relationship", cboRelationship.Text.Trim)
                query.Parameters.AddWithValue("@mobile_number", txtMobile.Text.Trim)
                query.Parameters.AddWithValue("@alt_mobile_number", txtAltMobile.Text.Trim)
                query.Parameters.AddWithValue("@have_passport", cbPassport.Checked)
                query.Parameters.AddWithValue("@have_bankac", cbBankac.Checked)
                query.Parameters.AddWithValue("@have_drivinglic", cbDrivingLicence.Checked)
                query.Parameters.AddWithValue("@have_aadhar", cbAadhar.Checked)
                query.Parameters.AddWithValue("@blood_group", cboBloodGroup.Text.Trim)
                query.Parameters.AddWithValue("@highest1_qualification", cbo1stHQ.Text.Trim)
                query.Parameters.AddWithValue("@highest2_qualification", cbo2ndHQ.Text.Trim)
                query.Parameters.AddWithValue("@highest3_qualification", cbo3rdHQ.Text.Trim)
                Dim status As String = ""
                If rbHQNA.Checked Then
                    status = "NA"
                ElseIf rbHQPass.Checked Then
                    status = "Pass"
                ElseIf rbHQFail.Checked Then
                    status = "Fail"
                ElseIf rbHQStudent.Checked Then
                    status = "Student"
                End If
                query.Parameters.AddWithValue("@highest1_qualification_status", status)
                status = ""
                If rb2ndHQna.Checked Then
                    status = "NA"
                ElseIf rb2ndHQpass.Checked Then
                    status = "Pass"
                ElseIf rb2ndHqfail.Checked Then
                    status = "Fail"
                ElseIf rb2ndHqstudent.Checked Then
                    status = "Student"
                End If
                query.Parameters.AddWithValue("@highest2_qualification_status", status)
                status = ""
                If rb3rdHQna.Checked Then
                    status = "NA"
                ElseIf rb3rdHQpass.Checked Then
                    status = "Pass"
                ElseIf rb3rdHqfail.Checked Then
                    status = "Fail"
                ElseIf rb3rdHqstudent.Checked Then
                    status = "Student"
                End If
                query.Parameters.AddWithValue("@highest3_qualification_status", status)
                query.Parameters.AddWithValue("@talents", txtAwards.Text.Trim)
                query.Parameters.AddWithValue("@awards", txtAwards.Text.Trim)
                query.Parameters.AddWithValue("@have_blindness", cbBlind.Checked)
                query.Parameters.AddWithValue("@have_deaf", cbDeaf.Checked)
                query.Parameters.AddWithValue("@have_dumb", cbDumb.Checked)
                query.Parameters.AddWithValue("@have_other_disability", cbOtherDisbilities.Checked)
                query.Parameters.AddWithValue("@have_learning_disability", cbLearningDisability.Checked)
                query.Parameters.AddWithValue("@have_mental_disability", cbMentalDisability.Checked)
                query.Parameters.AddWithValue("@have_heartdisease", cbHeartDisease.Checked)
                query.Parameters.AddWithValue("@have_diabetics", cbDiabetics.Checked)
                query.Parameters.AddWithValue("@have_cancer", cbCancer.Checked)
                query.Parameters.AddWithValue("@have_bp", cbBloodPreasure.Checked)
                query.Parameters.AddWithValue("@other_disease", txtOtherDisease.Text.Trim)
                query.Parameters.AddWithValue("@job_disease", txtJobDisease.Text.Trim)
                query.Parameters.AddWithValue("@is_alcoholic", cbAlcoholic.Checked)
                query.Parameters.AddWithValue("@other_incurabledisease", txtOtherIncurableDisease.Text.Trim)
                query.Parameters.AddWithValue("@is_smoking", cbSmoking.Checked)
                query.Parameters.AddWithValue("@job", txtJob.Text.Trim)
                query.Parameters.AddWithValue("@institute", txtInstitute.Text.Trim)
                query.Parameters.AddWithValue("@is_govt", cbIsGovt.Checked)
                query.Parameters.AddWithValue("@is_private", cbIsPrivate.Checked)
                query.Parameters.AddWithValue("@is_semigovt", cbIsSemiGovt.Checked)
                query.Parameters.AddWithValue("@is_selfemployment", cbIsSelfEmployment.Checked)
                query.Parameters.AddWithValue("@is_abroad", cbIsAbroad.Checked)
                query.Parameters.AddWithValue("@country", txtCountry.Text.Trim)
                query.Parameters.AddWithValue("@have_pension", cbPension.Checked)
                query.Parameters.AddWithValue("@have_insurance", cbInsurance.Checked)
                query.Parameters.AddWithValue("@have_social_welfare", cbSocialWelfare.Checked)
                query.Parameters.AddWithValue("@have_esi", cbESI.Checked)
                query.Parameters.AddWithValue("@have_pf", cbPF.Checked)
                query.Parameters.AddWithValue("@monthly_income", cboMonthlyIncome.Text.Trim)
                query.Parameters.AddWithValue("@baptismname", txtBaptisamName.Text.Trim)
                query.Parameters.AddWithValue("@god_father", txtGodfather.Text.Trim)
                query.Parameters.AddWithValue("@god_mother", txtGodmother.Text.Trim)
                query.Parameters.AddWithValue("@baptism_date", dtpBaptisamDate.Value)
                query.Parameters.AddWithValue("@baptism_pgno", Val(txtBaptismPageNo.Text.Trim))
                query.Parameters.AddWithValue("@baptism_slno", Val(txtBaptismSlNo.Text.Trim))
                query.Parameters.AddWithValue("@baptism_volume", txtBaptismVolume.Text.Trim)
                query.Parameters.AddWithValue("@baptism_minister", txtBaptismMinister.Text.Trim)
                query.Parameters.AddWithValue("@baptism_address", txtBaptismAddress.Text.Trim)
                query.Parameters.AddWithValue("@confirmation_minister", txtConfirmationMinister.Text.Trim)
                query.Parameters.AddWithValue("@confirmation_date", dtpConfirmationDate.Value)
                query.Parameters.AddWithValue("@confirmation_parishpriest", txtConfirmationParishPriest.Text.Trim)
                query.Parameters.AddWithValue("@confirmation_ifotherchurch", txtConfirmationAddress.Text.Trim)
                query.Parameters.AddWithValue("@confirmation_pgno", Val(txtConfirmationPageNo.Text.Trim))
                query.Parameters.AddWithValue("@confirmation_slno", Val(txtConfirmationSlNo.Text.Trim))
                query.Parameters.AddWithValue("@confirmation_volume", txtConfirmationVolume.Text.Trim)
                query.Parameters.AddWithValue("@communion_minister", txtCommunionMinister.Text.Trim)
                query.Parameters.AddWithValue("@communion_date", dtpCommunionDate.Value)
                query.Parameters.AddWithValue("@communion_parishpriest", txtCommunionParishPriest.Text.Trim)
                query.Parameters.AddWithValue("@communion_ifotherchurch", txtConfirmationAddress.Text.Trim)
                query.Parameters.AddWithValue("@communion_pgno", Val(txtCommunionPageNo.Text.Trim))
                query.Parameters.AddWithValue("@communion_slno", Val(txtCommunionSlNo.Text.Trim))
                query.Parameters.AddWithValue("@communion_volume", txtCommunionVolume.Text.Trim)
                query.Parameters.AddWithValue("@marriage_date", dtpMarriageDate.Value)
                query.Parameters.AddWithValue("@marriage_minister", txtMarrigeMinister.Text)
                query.Parameters.AddWithValue("@marriage_ifotherchurch", txtMarriageAddressOther.Text.Trim)
                query.Parameters.AddWithValue("@marriage_pgno", Val(txtMarriagePageNo.Text.Trim))
                query.Parameters.AddWithValue("@marriage_slno", Val(txtMarriageSlNo.Text.Trim))
                query.Parameters.AddWithValue("@marriage_volume", txtMarriageVolume.Text.Trim)
                Dim ministries As String = ""
                For Each ministry In clbMinistriesActive.CheckedItems
                    ministries += ministry.ToString & "; "
                Next
                query.Parameters.AddWithValue("@active_ministries", ministries)
                query.Parameters.AddWithValue("@createdby", frmLauncher.lblUser.Text)
                query.Parameters.AddWithValue("@createddate", Now())
                query.Parameters.AddWithValue("@modifiedby", frmLauncher.lblUser.Text)
                query.Parameters.AddWithValue("@modifieddate", Now())
                query.Parameters.AddWithValue("@status", True)
                db.instertToDB(query)
                If MessageBox.Show("Saved successfully. Do you want to close?", "Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    frmFamily.dgvFamilyMembers.DataSource = db.fillData("member", "memberid,membername,dob,gender,relationship,mobile_number", " where  familyid=" & Val(familyid))
                    frmFamily.dgvFamilies.Refresh()


                Else
                    frmFamily.dgvFamilyMembers.DataSource = db.fillData("member", "memberid,membername,dob,gender,relationship,mobile_number", " where  familyid=" & Val(familyid))
                    frmFamily.dgvFamilies.Refresh()
                    btnNew.PerformClick()
                End If
            End If
            End If
    End Sub

    Private Function valid() As Boolean
        valid = True
        If familyid.Length = 0 Then
            valid = False
            err.SetError(txtHouseName, "family not selected")
        End If
        If txtName.Text.Trim.Length < 2 Then
            err.SetError(txtName, "Name cannot be blank")
            txtName.Select()
            valid = False
        End If
        If rbmale.Checked = False And rbFemale.Checked = False Then
            err.SetError(rbFemale, "select gender")
            'rbmale.Focus()
            valid = False
        End If
        If dtpDOB.Value.ToShortDateString.Equals("1/1/1900") Then
            dtpDOB.Focus()
            err.SetError(dtpDOB, "Date of birth cannot be blank")
            valid = False
        End If
        If cboRelationship.Text.Trim.Length < 2 Then
            cboRelationship.Focus()
            err.SetError(cboRelationship, "select relationship")
            valid = False
        End If
        If cboMaritalStatus.Text.Trim.Length < 2 Then
            cboMaritalStatus.Focus()
            err.SetError(cboMaritalStatus, "select marital status")
            valid = False
        End If
        If valid Then

            err.Clear()
        End If

    End Function

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        If familyid.Length < 1 Then
            frmFamily.Show()
            frmFamily.txtSearch.Focus()

        End If
    End Sub

    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        tpFamilyMember.SelectTab(2)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.familyid = ""
        Me.Close()
    End Sub
End Class
