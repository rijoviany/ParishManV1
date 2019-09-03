Public Class frmFamily
    Dim err As New ErrorProvider
    Public bccid As String = ""
    Public familyid As String = ""

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click

        'text boxes
        txtAddress.Clear()
        txtConstructionYear.Clear()
        txtDining.Clear()
        txtFamilyId.Clear()
        txtHouseName.Clear()
        txtHouseNumber.Clear()
        txtinRs.Clear()
        txtJob.Clear()
        txtLand.Clear()
        txtLandphone.Clear()
        txtMigrantFrom.Clear()
        txtMigrantReason.Clear()
        txtOthersIncome.Clear()
        txtOwnershipValue.Clear()
        txtPincode.Clear()
        txtTotalIncome.Clear()
        txtEducation.Clear()
        txtMobile.Clear()
        txtMedicine.Clear()
        txtNewsPaperNames.Clear()
        txtMortgageReason.Clear()
        txtSubscriptionNo.Clear()
        txtMonthlyVari.Clear()

        'number up down
        txtNumberOfRooms.ResetText()
        txtNewspaperCount.ResetText()
        txtCountOfMobile.ResetText()
        txtAcre.ResetText()
        txtCent.ResetText()

        'combo boxes
        cboHouseOwnership.Text = ""
        cboHouseType.Text = ""
        cboRationCard.Text = ""
        cboBCCUnit.Text = ""


        'check boxes
        cbIsMigrant.Checked = False
        cbInternet.Checked = False
        cbKidsMagazine.Checked = False
        cbMagazine.Checked = False
        cbMobile.Checked = False
        cbMortgage.Checked = False
        cbNewspaper.Checked = False
        cbTv.Checked = False

        'check box list
        For item = 0 To clbBusiness.Items.Count - 1
            clbBusiness.SetItemChecked(item, False)
        Next
        For item = 0 To clbCatholicPublications.Items.Count - 1
            clbCatholicPublications.SetItemChecked(item, False)
        Next
        For item = 0 To clbFarming.Items.Count - 1
            clbFarming.SetItemChecked(item, False)
        Next
        For item = 0 To clbHomeAppliances.Items.Count - 1
            clbHomeAppliances.SetItemChecked(item, False)
        Next
        For item = 0 To clbOthefacilities.Items.Count - 1
            clbOthefacilities.SetItemChecked(item, False)
        Next
        For item = 0 To clbSocialSecurity.Items.Count - 1
            clbSocialSecurity.SetItemChecked(item, False)
        Next
        For item = 0 To clbVehicles.Items.Count - 1
            clbVehicles.SetItemChecked(item, False)
        Next
        For item = 0 To clbMorgageSource.Items.Count - 1
            clbMorgageSource.SetItemChecked(item, False)
        Next


        'load combo boxes

        Dim db As New dbOperations

        db.fillCombo("bcc_unit", "concat(bcc_unitname,' ; ',place) as bcc_unit", cboBCCUnit)
        Try
            'load datagrid
            If bccid.Trim.Length > 0 Then

                dgvFamilies.DataSource = db.fillData("vw_family_list", "*", "where bcc_unitid=" & bccid).Tables(0)
            Else
                dgvFamilies.DataSource = db.fillData("vw_family_list", "*").Tables(0)
                dgvFamilies.Refresh()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



        dgvFamilies.Refresh()
        If txtFamilyId.Text.Trim.Length > 0 Then
            dgvFamilyMembers.DataSource = db.fillData("member", "memberid,membername,dob,gender,relationship,mobile_number", " where  familyid=" & Val(txtFamilyId.Text))
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If valid() Then
            If btnSave.Text = "&Save" Then
                Dim db As New dbOperations
                Dim query As New MySql.Data.MySqlClient.MySqlCommand("INSERT INTO `parishdb`.`family` (`familyid`, `housename`, `housenumber`, `bcc_unitid`,
                                                                `address`, `pincode`, `landphone_number`, `ownership`, `ownership_value`, 
                                                                `house_type`, `number_rooms`, `year_construction`, `rationcard_type`, `area_ownland`, 
                                                                `have_ownland`, `is_migrant`, `migrant_from`, `migrant_reason`, `farming`, `business`, 
                                                                `monthly_income_land`, `monthly_income_job`, `monthly_income_other`, `mothly_expense_dining`,
                                                                `monthly_expense_medicine`, `monthly_expense_mobile`, `monthly_expense_others`, `vehicles`, 
                                                                `home_appliances`, `other_facilities`, `newspaper_name`, `have_magazine`, `have_kids_magazine`,
                                                                `have_tv`, `have_internet`, `number_mobiles`, `catholic_publications`, `have_mortgage`, 
                                                                `mortgage_source`, `mortgage_reason`, `social_security`, `monthly_expense_education`,`createdby` ,
                                                                `createddate`,`modifiedby`,`modifieddate`,`status`,`subscriptionno`,`monthly_vari`) VALUES (@familyid, @housename,
                                                                @housenumber, @bcc_unitid, @address , @pincode, @landphone_number, @ownership,
                                                                @ownership_value, @house_type, @number_rooms, @year_construction, @rationcard_type, @area_ownland, 
                                                                @have_ownland, @is_migrant, @migrant_from, @migrant_reason, @farming, @business, @monthly_income_land,
                                                                @monthly_income_job, @monthly_income_other, @mothly_expense_dining, @monthly_expense_medicine,
                                                                @monthly_expense_mobile, @monthly_expense_others, @vehicles, @home_appliances, @other_facilities,
                                                                @newspaper_name, @have_magazine, @have_kids_magazine, @have_tv, @have_internet, @number_mobiles, 
                                                                @catholic_publications, @have_mortgage, @mortgage_source, @mortgage_reason, @social_security,
                                                                @monthly_expense_education,@createdby ,@createddate,@modifiedby,@modifieddate,@status,@subscriptionno,@monthly_vari);")

                query.Parameters.AddWithValue("@familyid", Val(txtFamilyId.Text))
                query.Parameters.AddWithValue("@housename", txtHouseName.Text.Trim)
                query.Parameters.AddWithValue("@housenumber", txtHouseNumber.Text.Trim)

                Dim bcc As String = cboBCCUnit.Text.Trim.Replace(" ; ", "$")
                Dim bccname As String = bcc.Split("$").GetValue(0)
                Dim place As String = bcc.Split("$").GetValue(1)
                Dim bcc_unitid As String = db.getStringFromDB("bcc_unit", "bcc_unitid", " bcc_unitname like '%" & bccname.Replace("'", "''") & "%' and place like '%" & place & "%'")
                query.Parameters.AddWithValue("@bcc_unitid", bcc_unitid)

                query.Parameters.AddWithValue("@address", txtAddress.Text.Trim)
                query.Parameters.AddWithValue("@pincode", txtPincode.Text.Trim)
                query.Parameters.AddWithValue("@landphone_number", txtLandphone.Text.Trim)
                query.Parameters.AddWithValue("@ownership", cboHouseOwnership.Text.Trim)
                query.Parameters.AddWithValue("@ownership_value", Val(txtOwnershipValue.Text.Trim))
                query.Parameters.AddWithValue("@house_type", cboHouseType.Text.Trim)
                query.Parameters.AddWithValue("@number_rooms", Val(txtNumberOfRooms.Value))
                query.Parameters.AddWithValue("@year_construction", Val(txtConstructionYear.Text.Trim))
                query.Parameters.AddWithValue("@rationcard_type", cboRationCard.Text)
                query.Parameters.AddWithValue("@area_ownland", ((txtAcre.Value * 100) + txtCent.Value))
                query.Parameters.AddWithValue("@have_ownland", txtAcre.Value > 0 Or txtCent.Value > 0)
                query.Parameters.AddWithValue("@is_migrant", cbIsMigrant.Checked)
                query.Parameters.AddWithValue("@migrant_from", txtMigrantFrom.Text.Trim)
                query.Parameters.AddWithValue("@migrant_reason", txtMigrantReason.Text.Trim)
                'farming
                Dim farming As String = ""
                For Each farm In clbFarming.CheckedItems
                    farming += farm.ToString & "; "
                Next
                query.Parameters.AddWithValue("@farming", farming)
                'business
                Dim business As String = ""
                For Each busi In clbBusiness.CheckedItems
                    business += busi.ToString & "; "
                Next
                query.Parameters.AddWithValue("@business", business)
                query.Parameters.AddWithValue("@monthly_income_land", Val(txtLand.Text.Trim))
                query.Parameters.AddWithValue("@monthly_income_job", Val(txtJob.Text.Trim))
                query.Parameters.AddWithValue("@monthly_income_other", Val(txtOthersIncome.Text.Trim))
                query.Parameters.AddWithValue("@mothly_expense_dining", Val(txtDining.Text.Trim))
                query.Parameters.AddWithValue("@monthly_expense_medicine", Val(txtMedicine.Text.Trim))
                query.Parameters.AddWithValue("@monthly_expense_mobile", Val(txtMobile.Text.Trim))
                query.Parameters.AddWithValue("@monthly_expense_education", Val(txtEducation.Text.Trim))
                query.Parameters.AddWithValue("@monthly_expense_others", Val(txtOtherExpense.Text.Trim))
                'vehicles
                Dim vehicles As String = ""
                For Each vehicle In clbVehicles.CheckedItems
                    vehicles += vehicle.ToString & "; "
                Next
                query.Parameters.AddWithValue("@vehicles", vehicles)
                'home_appliances
                Dim home_appliances As String = ""
                For Each home_appliance In clbHomeAppliances.CheckedItems
                    home_appliances += home_appliance.ToString & "; "
                Next
                query.Parameters.AddWithValue("@home_appliances", home_appliances)
                'other_facilities
                Dim other_facilities As String = ""
                For Each other_fac In clbOthefacilities.CheckedItems
                    other_facilities += other_fac.ToString & "; "
                Next
                query.Parameters.AddWithValue("@other_facilities", other_facilities)
                query.Parameters.AddWithValue("@newspaper_name", txtNewsPaperNames.Text.Trim)
                query.Parameters.AddWithValue("@have_magazine", cbMagazine.Checked)
                query.Parameters.AddWithValue("@have_kids_magazine", cbKidsMagazine.Checked)
                query.Parameters.AddWithValue("@have_tv", cbTv.Checked)
                query.Parameters.AddWithValue("@have_internet", cbInternet.Checked)
                query.Parameters.AddWithValue("@number_mobiles", Val(txtCountOfMobile.Value))
                'catholic_publications
                Dim catholic_publications As String = ""
                For Each item In clbCatholicPublications.CheckedItems
                    catholic_publications += item.ToString & "; "
                Next
                query.Parameters.AddWithValue("@catholic_publications", catholic_publications)
                query.Parameters.AddWithValue("@have_mortgage", cbMortgage.Checked)
                'morgage_sources
                Dim morgage_sources As String = ""
                For Each item In clbMorgageSource.CheckedItems
                    morgage_sources += item.ToString & "; "
                Next
                query.Parameters.AddWithValue("@mortgage_source", morgage_sources)
                query.Parameters.AddWithValue("@mortgage_reason", txtMortgageReason.Text.Trim)
                'social_security
                Dim social_security As String = ""
                For Each item In clbSocialSecurity.CheckedItems
                    social_security += item.ToString & "; "
                Next
                query.Parameters.AddWithValue("@social_security", social_security)


                query.Parameters.AddWithValue("@createdby", frmLauncher.lblUser.Text)
                query.Parameters.AddWithValue("@createddate", Now())
                query.Parameters.AddWithValue("@modifiedby", frmLauncher.lblUser.Text)
                query.Parameters.AddWithValue("@modifieddate", Now())
                query.Parameters.AddWithValue("@status", True)
                query.Parameters.AddWithValue("@subscriptionno", txtSubscriptionNo.Text)
                query.Parameters.AddWithValue("@monthly_vari", IIf(Val(txtMonthlyVari.Text.Trim) = 0, DBNull.Value, Val(txtMonthlyVari.Text.Trim)))
                Dim familyid As String
                If db.instertToDB(query) Then
                    tcFamily.SelectedIndex() = 1
                    familyid = db.getStringFromDB("family", "max(familyid)", "1=1")
                    If MessageBox.Show("Do you want to add family member?", "Family Member", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.No Then
                        btnNew.PerformClick()
                    ElseIf DialogResult.Yes Then
                        'MsgBox(familyid)
                        frmFamilyMember.familyid = familyid
                        If frmFamilyMember.ShowDialog() = DialogResult.OK Then
                            dgvFamilyMembers.DataSource = db.fillData("member", "memberid,membername,dob,gender,relationship,mobile_number", " where  familyid=" & Val(familyid))
                            dgvFamilies.Refresh()
                        Else
                            dgvFamilyMembers.DataSource = db.fillData("member", "memberid,membername,dob,gender,relationship,mobile_number", " where  familyid=" & Val(familyid))
                            dgvFamilies.Refresh()
                        End If
                    End If

                End If
            End If
        End If
    End Sub

    Function valid() As Boolean
        If txtHouseName.Text.Trim.Length < 3 Then
            err.SetError(txtHouseName, "invalid housen name")
            txtHouseName.Select()
            valid = False
        Else
            err.Clear()
            valid = True
        End If

        If cboBCCUnit.Text.Trim.Length < 3 Then
            err.SetError(cboBCCUnit, "select BCC Unit")
            cboBCCUnit.Focus()
            valid = False
        Else
            valid = True
            err.Clear()
        End If

        If txtAddress.Text.Trim.Length < 3 Then
            err.SetError(txtAddress, "invalid address")
            txtAddress.Select()
            valid = False
        Else
            valid = True
            err.Clear()
        End If

        If txtSubscriptionNo.Text.Trim.Length = 0 Then
            err.SetError(txtSubscriptionNo, "Subscription number cannot be blank")
        End If


    End Function

    Private Sub txtLand_TextChanged(sender As Object, e As EventArgs) Handles txtLand.TextChanged, txtJob.TextChanged, txtOthersIncome.TextChanged
        txtTotalIncome.Text = (Val(txtLand.Text) + Val(txtJob.Text) + Val(txtOthersIncome.Text))
    End Sub

    Private Sub txtDining_TextChanged(sender As Object, e As EventArgs) Handles txtDining.TextChanged, txtMobile.TextChanged, txtMedicine.TextChanged, txtOtherExpense.TextChanged, txtEducation.TextChanged
        txtTotalExpense.Text = (Val(txtDining.Text) + Val(txtEducation.Text) + Val(txtMobile.Text) + Val(txtMedicine.Text) + Val(txtOtherExpense.Text))
    End Sub

    Private Sub frmFamily_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnNew.PerformClick()
    End Sub



    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtFamilyId.Text.Trim.Length > 0 Then
            Dim db As New dbOperations
            db.deleteFromDB(Val(txtFamilyId.Text.Trim), "family")
            btnNew.PerformClick()
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If familyid.Length > 0 Then
            frmFamilyMember.familyid = Me.familyid
            If frmFamilyMember.Visible = True Then
            Else
                frmFamilyMember.Show()
            End If
        End If
    End Sub

    Private Sub dgvFamilies_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFamilies.CellContentClick
        Dim db As New dbOperations
        Dim i As Integer
        i = dgvFamilies.CurrentRow.Index
        btnAdd.Visible = True
        familyid = dgvFamilies.Item("familyid", i).Value
        cboBCCUnit.Text = dgvFamilies.Item("bcc_unit", i).Value.ToString.Split(",").GetValue(1)
        btnAdd.AutoSize = True
        dgvFamilyMembers.DataSource = db.fillData("vw_alltable", "familyid,housename,memberid,membername,dob,relationship,marital_status", " where familyid=" & familyid & " and memberid > 0").Tables(0)

    End Sub

    Private Sub dgvFamilyMembers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFamilyMembers.CellContentClick
        Dim i As Integer
        i = dgvFamilyMembers.CurrentRow.Index
        If dgvFamilyMembers.Item("memberid", i).Value > 0 Then

        End If
        txtHouseName.Text = dgvFamilyMembers.Item("memberid", i).Value
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

    End Sub
End Class