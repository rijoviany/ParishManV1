Public Class frmFinanceEntry
    Dim parishid As Integer
    Dim familyid As Integer
    Private Sub frmFinanceEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If frmLauncher.lblRoleid.Text = 1 Or frmLauncher.lblRoleid.Text = 2 Or frmLauncher.lblRoleid.Text = 5 Then
            btnNew.PerformClick()
        End If




    End Sub

    Private Sub txt_change(sender As Object, e As EventArgs) Handles txtOthers.TextChanged, txtMissionSunday.TextChanged, txtFeastVari.TextChanged, txtDonationSeminary.TextChanged, txtDonationForane.TextChanged, txtDonationDiocese.TextChanged, txtChristmasCarol.TextChanged, txtChristmasAuction.TextChanged, txtSep.TextChanged, txtNov.TextChanged, txtAug.TextChanged, txtJul.TextChanged, txtJun.TextChanged, txtMay.TextChanged, txtApr.TextChanged, txtMar.TextChanged, txtDec.TextChanged, txtFeb.TextChanged, txtOct.TextChanged, txtJan.TextChanged
        lblTotal.Text = Val(txtChristmasAuction.Text) + Val(txtChristmasCarol.Text) + Val(txtDonationDiocese.Text) + Val(txtDonationForane.Text) + Val(txtDonationSeminary.Text) + Val(txtFeastVari.Text) + Val(txtMissionSunday.Text) + Val(txtOthers.Text) + Val(txtJan.Text) + Val(txtFeb.Text) + Val(txtMar.Text) + Val(txtApr.Text) + Val(txtMay.Text) + Val(txtJun.Text) + Val(txtJul.Text) + Val(txtAug.Text) + Val(txtSep.Text) + Val(txtOct.Text) + Val(txtNov.Text) + Val(txtDec.Text)
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        txtYear.Text = Year(Now)
        dtpDate.Value = Now.ToShortDateString

        txtChristmasAuction.Clear()
        txtChristmasCarol.Clear()
        txtDonationDiocese.Clear()
        txtDonationForane.Clear()
        txtDonationSeminary.Clear()
        txtFeastVari.Clear()
        txtMissionSunday.Clear()
        txtOthers.Clear()
        txtReceiptNo.Clear()
        txtJan.Clear()
        txtFeb.Clear()
        txtMar.Clear()
        txtApr.Clear()
        txtMay.Clear()
        txtJun.Clear()
        txtJul.Clear()
        txtAug.Clear()
        txtSep.Clear()
        txtOct.Clear()
        txtNov.Clear()
        txtDec.Clear()

        lblTotal.Text = 0

        Dim db As New dbOperations
        dgvFamilies.DataSource = db.fillData("vw_family_finance_txn", "familyid,bcc_unitname,place,subscriptionno,housename,last_payment,last_payment_year,monthly_vari", IIf(frmLauncher.lblParish.Text > 0 Or frmLauncher.lblForane.Text > 0 Or frmLauncher.lblSubRegion.Text > 0 Or frmLauncher.lblDiocese.Text > 0, " where (dioceseid=" & frmLauncher.lblDiocese.Text & " or sub_regionid=" & frmLauncher.lblSubRegion.Text & " or foraneid=" & frmLauncher.lblForane.Text & " or parishid=" & frmLauncher.lblParish.Text & ")", "")).Tables(0)

        txtSearch.Select()

    End Sub

    Private Sub cboPaymentTemplate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPaymentTemplate.SelectedIndexChanged
        txtJan.Clear()
        txtFeb.Clear()
        txtMar.Clear()
        txtApr.Clear()
        txtMay.Clear()
        txtJun.Clear()
        txtJul.Clear()
        txtAug.Clear()
        txtSep.Clear()
        txtOct.Clear()
        txtNov.Clear()
        txtDec.Clear()
        Select Case cboPaymentTemplate.Text
            Case "None"
                txtJan.Clear()
                txtFeb.Clear()
                txtMar.Clear()
                txtApr.Clear()
                txtMay.Clear()
                txtJun.Clear()
                txtJul.Clear()
                txtAug.Clear()
                txtSep.Clear()
                txtOct.Clear()
                txtNov.Clear()
                txtDec.Clear()
            Case "Full  Year"
                txtJan.Text = txtMonthlyVari.Text
                txtFeb.Text = txtMonthlyVari.Text
                txtMar.Text = txtMonthlyVari.Text
                txtApr.Text = txtMonthlyVari.Text
                txtMay.Text = txtMonthlyVari.Text
                txtJun.Text = txtMonthlyVari.Text
                txtJul.Text = txtMonthlyVari.Text
                txtAug.Text = txtMonthlyVari.Text
                txtSep.Text = txtMonthlyVari.Text
                txtOct.Text = txtMonthlyVari.Text
                txtNov.Text = txtMonthlyVari.Text
                txtDec.Text = txtMonthlyVari.Text
            Case "1st  Half Year"
                txtJan.Text = txtMonthlyVari.Text
                txtFeb.Text = txtMonthlyVari.Text
                txtMar.Text = txtMonthlyVari.Text
                txtApr.Text = txtMonthlyVari.Text
                txtMay.Text = txtMonthlyVari.Text
                txtJun.Text = txtMonthlyVari.Text
            Case "2nd Half Year"
                txtJul.Text = txtMonthlyVari.Text
                txtAug.Text = txtMonthlyVari.Text
                txtSep.Text = txtMonthlyVari.Text
                txtOct.Text = txtMonthlyVari.Text
                txtNov.Text = txtMonthlyVari.Text
                txtDec.Text = txtMonthlyVari.Text
            Case "3   Months till date for current year"
                If Month(Now) = 1 Then
                    txtJan.Text = txtMonthlyVari.Text
                ElseIf Month(Now) = 2 Then
                    txtJan.Text = txtMonthlyVari.Text
                    txtFeb.Text = txtMonthlyVari.Text
                ElseIf Month(Now) = 3 Then
                    txtJan.Text = txtMonthlyVari.Text
                    txtFeb.Text = txtMonthlyVari.Text
                    txtMar.Text = txtMonthlyVari.Text
                ElseIf Month(Now) = 4 Then
                    txtFeb.Text = txtMonthlyVari.Text
                    txtMar.Text = txtMonthlyVari.Text
                    txtApr.Text = txtMonthlyVari.Text
                ElseIf Month(Now) = 5 Then
                    txtMar.Text = txtMonthlyVari.Text
                    txtApr.Text = txtMonthlyVari.Text
                    txtMay.Text = txtMonthlyVari.Text
                ElseIf Month(Now) = 6 Then
                    txtApr.Text = txtMonthlyVari.Text
                    txtMay.Text = txtMonthlyVari.Text
                    txtJun.Text = txtMonthlyVari.Text
                ElseIf Month(Now) = 7 Then
                    txtJul.Text = txtMonthlyVari.Text
                    txtAug.Text = txtMonthlyVari.Text
                    txtSep.Text = txtMonthlyVari.Text
                ElseIf Month(Now) = 8 Then
                    txtAug.Text = txtMonthlyVari.Text
                    txtSep.Text = txtMonthlyVari.Text
                    txtOct.Text = txtMonthlyVari.Text
                ElseIf Month(Now) = 9 Then
                    txtSep.Text = txtMonthlyVari.Text
                    txtOct.Text = txtMonthlyVari.Text
                    txtNov.Text = txtMonthlyVari.Text
                ElseIf Month(Now) >= 10 Then
                    txtOct.Text = txtMonthlyVari.Text
                    txtNov.Text = txtMonthlyVari.Text
                    txtDec.Text = txtMonthlyVari.Text
                End If
            Case "All Months till date for current year"
                If Month(Now) = 1 Then
                    txtJan.Text = txtMonthlyVari.Text
                ElseIf Month(Now) = 2 Then
                    txtJan.Text = txtMonthlyVari.Text
                    txtFeb.Text = txtMonthlyVari.Text
                ElseIf Month(Now) = 3 Then
                    txtJan.Text = txtMonthlyVari.Text
                    txtFeb.Text = txtMonthlyVari.Text
                    txtMar.Text = txtMonthlyVari.Text
                ElseIf Month(Now) = 4 Then
                    txtJan.Text = txtMonthlyVari.Text
                    txtFeb.Text = txtMonthlyVari.Text
                    txtMar.Text = txtMonthlyVari.Text
                    txtApr.Text = txtMonthlyVari.Text
                ElseIf Month(Now) = 5 Then
                    txtJan.Text = txtMonthlyVari.Text
                    txtFeb.Text = txtMonthlyVari.Text
                    txtMar.Text = txtMonthlyVari.Text
                    txtApr.Text = txtMonthlyVari.Text
                    txtMay.Text = txtMonthlyVari.Text
                ElseIf Month(Now) = 6 Then
                    txtJan.Text = txtMonthlyVari.Text
                    txtFeb.Text = txtMonthlyVari.Text
                    txtMar.Text = txtMonthlyVari.Text
                    txtApr.Text = txtMonthlyVari.Text
                    txtMay.Text = txtMonthlyVari.Text
                    txtJun.Text = txtMonthlyVari.Text
                ElseIf Month(Now) = 7 Then
                    txtJan.Text = txtMonthlyVari.Text
                    txtFeb.Text = txtMonthlyVari.Text
                    txtMar.Text = txtMonthlyVari.Text
                    txtApr.Text = txtMonthlyVari.Text
                    txtMay.Text = txtMonthlyVari.Text
                    txtJun.Text = txtMonthlyVari.Text
                    txtJul.Text = txtMonthlyVari.Text
                ElseIf Month(Now) = 8 Then
                    txtJan.Text = txtMonthlyVari.Text
                    txtFeb.Text = txtMonthlyVari.Text
                    txtMar.Text = txtMonthlyVari.Text
                    txtApr.Text = txtMonthlyVari.Text
                    txtMay.Text = txtMonthlyVari.Text
                    txtJun.Text = txtMonthlyVari.Text
                    txtJul.Text = txtMonthlyVari.Text
                    txtAug.Text = txtMonthlyVari.Text
                ElseIf Month(Now) = 9 Then
                    txtJan.Text = txtMonthlyVari.Text
                    txtFeb.Text = txtMonthlyVari.Text
                    txtMar.Text = txtMonthlyVari.Text
                    txtApr.Text = txtMonthlyVari.Text
                    txtMay.Text = txtMonthlyVari.Text
                    txtJun.Text = txtMonthlyVari.Text
                    txtJul.Text = txtMonthlyVari.Text
                    txtAug.Text = txtMonthlyVari.Text
                    txtSep.Text = txtMonthlyVari.Text
                ElseIf Month(Now) = 10 Then
                    txtJan.Text = txtMonthlyVari.Text
                    txtFeb.Text = txtMonthlyVari.Text
                    txtMar.Text = txtMonthlyVari.Text
                    txtApr.Text = txtMonthlyVari.Text
                    txtMay.Text = txtMonthlyVari.Text
                    txtJun.Text = txtMonthlyVari.Text
                    txtJul.Text = txtMonthlyVari.Text
                    txtAug.Text = txtMonthlyVari.Text
                    txtSep.Text = txtMonthlyVari.Text
                    txtOct.Text = txtMonthlyVari.Text
                ElseIf Month(Now) = 11 Then
                    txtJan.Text = txtMonthlyVari.Text
                    txtFeb.Text = txtMonthlyVari.Text
                    txtMar.Text = txtMonthlyVari.Text
                    txtApr.Text = txtMonthlyVari.Text
                    txtMay.Text = txtMonthlyVari.Text
                    txtJun.Text = txtMonthlyVari.Text
                    txtJul.Text = txtMonthlyVari.Text
                    txtAug.Text = txtMonthlyVari.Text
                    txtSep.Text = txtMonthlyVari.Text
                    txtOct.Text = txtMonthlyVari.Text
                    txtNov.Text = txtMonthlyVari.Text
                ElseIf Month(Now) = 12 Then
                    txtJan.Text = txtMonthlyVari.Text
                    txtFeb.Text = txtMonthlyVari.Text
                    txtMar.Text = txtMonthlyVari.Text
                    txtApr.Text = txtMonthlyVari.Text
                    txtMay.Text = txtMonthlyVari.Text
                    txtJun.Text = txtMonthlyVari.Text
                    txtJul.Text = txtMonthlyVari.Text
                    txtAug.Text = txtMonthlyVari.Text
                    txtSep.Text = txtMonthlyVari.Text
                    txtOct.Text = txtMonthlyVari.Text
                    txtNov.Text = txtMonthlyVari.Text
                    txtDec.Text = txtMonthlyVari.Text
                End If
        End Select


    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim db As New dbOperations
        Dim query As New MySql.Data.MySqlClient.MySqlCommand("INSERT INTO `parishdb`.`family_finance_txn` (`familyid`, `date`, `year`, `january`, `february`, `march`, `april`, `may`, `june`, `july`, `august`, `september`, `november`, `december`, `mission_sunday`, `christmas_auction`, `receipt_number`,`feast_vari`,`donation_forane`,`donation_diocese`,`donation_seminary`,`others`,`opening_balance`) VALUES ( @familyid, @date, @year, @january, @february, @march, @april, @may, @june, @july, @august, @september, @november, @december, @mission_sunday, @christmas_auction, @receipt_number, @feast_vari, @donation_forane, @donation_diocese, @donation_seminary, @others,@opening_balance);")

        query.Parameters.AddWithValue("@familyid", Me.familyid)
        query.Parameters.AddWithValue("@date", dtpDate.Value)
        query.Parameters.AddWithValue("@year", txtYear.Text)
        query.Parameters.AddWithValue("@january", Val(txtJan.Text))
        query.Parameters.AddWithValue("@february", Val(txtFeb.Text))
        query.Parameters.AddWithValue("@march", Val(txtMar.Text))
        query.Parameters.AddWithValue("@april", Val(txtApr.Text))
        query.Parameters.AddWithValue("@may", Val(txtMay.Text))
        query.Parameters.AddWithValue("@june", Val(txtJun.Text))
        query.Parameters.AddWithValue("@july", Val(txtJul.Text))
        query.Parameters.AddWithValue("@august", Val(txtAug.Text))
        query.Parameters.AddWithValue("@september", Val(txtSep.Text))
        query.Parameters.AddWithValue("@november", Val(txtNov.Text))
        query.Parameters.AddWithValue("@december", Val(txtDec.Text))
        query.Parameters.AddWithValue("@mission_sunday", Val(txtMissionSunday.Text))
        query.Parameters.AddWithValue("@christmas_auction", Val(txtChristmasAuction.Text))
        query.Parameters.AddWithValue("@receipt_number", txtReceiptNo.Text)
        query.Parameters.AddWithValue("feast_vari", Val(txtFeastVari.Text))
        query.Parameters.AddWithValue("donation_forane", Val(txtDonationForane.Text))
        query.Parameters.AddWithValue("donation_diocese", Val(txtDonationDiocese.Text))
        query.Parameters.AddWithValue("donation_seminary", Val(txtDonationSeminary.Text))
        query.Parameters.AddWithValue("others", Val(txtOthers.Text))
        query.Parameters.AddWithValue("opening_balance", Val(txtOpeningBalance.Text))
        If db.instertToDB(query) Then
            MsgBox("saved")
            btnNew.PerformClick()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub dgvFamilies_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFamilies.CellContentClick
        Dim i As Integer
        i = dgvFamilies.CurrentRow.Index
        txtHousename.Text = dgvFamilies.Item("housename", i).Value
        txtMonthlyVari.Text = dgvFamilies.Item("monthly_vari", i).Value
        txtSubscriptionNo.Text = IIf(IsDBNull(dgvFamilies.Item("subscriptionno", i).Value), "", "")
        familyid = dgvFamilies.Item("familyid", i).Value
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text.Trim.Length > 0 Then
            Dim db As New dbOperations
            Dim dv As New DataView
            dv.Table = db.fillData("vw_family_finance_txn", "familyid,bcc_unitname,place,subscriptionno,housename,last_payment,last_payment_year,paid,monthly_vari", IIf(frmLauncher.lblParish.Text > 0, " where parishid like '" & frmLauncher.lblParish.Text & "'", "")).Tables(0)
            dv.RowFilter = "[housename] Like '%" & txtSearch.Text.Trim & "%' or [bcc_unitname] Like '%" & txtSearch.Text.Trim & "%' Or [subscriptionno] Like '%" & txtSearch.Text.Trim & "%'"
            dgvFamilies.DataSource = dv
        Else
            Dim db As New dbOperations
            dgvFamilies.DataSource = db.fillData("vw_family_finance_txn", "familyid,bcc_unitname,place,subscriptionno,housename,last_payment,last_payment_year,paid,monthly_vari", IIf(frmLauncher.lblParish.Text > 0, " where parishid like '" & frmLauncher.lblParish.Text & "'", "")).Tables(0)
        End If
    End Sub
End Class