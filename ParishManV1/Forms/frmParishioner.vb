Public Class frmParishioner
	Dim err As New ErrorProvider
	Private Sub frmParishioner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim db As New dbOperations
		db.fillCombo("bcc_unit", "bcc_unitid", cboBccUnit)


	End Sub

	Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

		'INSERT INTO `parishdb`.`parishioner` (`parishionerid`, `regno`, `name`, `phone`, `gender`, `qualification`, `occupation`, `address`, `bcc_unit`, `remarks`, `dob`, `baptism_date`, `father`, `mother`, `baptism_godfather`, `baptism_godmother`, `baptism_minister`, `confirmation_date`, `confirmation_minister`, `confirmation_godfather`, `confirmation_godmother`, `confirmation_church`, `firstcommunion_date`, `firstcommunion_minister`, `firstcommunion_church`, `marriage_date`, `Spouse_name`, `marriage_minister`, `marriage_church`, `death_date`, `buriel_date`, `death_place`, `death_minister`, `extra_remarks`, `bcc_unitid`) VALUES (@parishionerid, @regno, @name, @phone, @gender, @qualification, @occupation, @address, @bcc_unit, @remarks, @dob, @baptism_date, @father, @mother, @baptism_godfather, @baptism_godmother, @baptism_minister, @confirmation_date, @confirmation_minister, @confirmation_godfather, @confirmation_godmother, @confirmation_church, @firstcommunion_date, @firstcommunion_minister, @firstcommunion_church, @marriage_date, @Spouse_name, @marriage_minister, @marriage_church, @death_date, @buriel_date, @death_place, @death_minister, @extra_remarks, @bcc_unitid);
		If valid() Then
			Dim db As New dbOperations
			Dim query As New MySql.Data.MySqlClient.MySqlCommand("INSERT INTO `parishdb`.`parishioner` (`parishionerid`, `regno`, `name`, `phone`, `gender`, `qualification`, `occupation`, `address`, `bcc_unit`, `remarks`, `dob`, `baptism_date`, `father`, `mother`, `baptism_godfather`, `baptism_godmother`, `baptism_minister`, `confirmation_date`, `confirmation_minister`, `confirmation_godfather`, `confirmation_godmother`, `confirmation_church`, `firstcommunion_date`, `firstcommunion_minister`, `firstcommunion_church`, `marriage_date`, `Spouse_name`, `marriage_minister`, `marriage_church`, `death_date`, `buriel_date`, `death_place`, `death_minister`, `extra_remarks`, `bcc_unitid`) VALUES (@regno, @name, @phone, @gender, @qualification, @occupation, @address, @bcc_unit, @remarks, @dob, @baptism_date, @father, @mother, @baptism_godfather, @baptism_godmother, @baptism_minister, @confirmation_date, @confirmation_minister, @confirmation_godfather, @confirmation_godmother, @confirmation_church, @firstcommunion_date, @firstcommunion_minister, @firstcommunion_church, @marriage_date, @Spouse_name, @marriage_minister, @marriage_church, @death_date, @buriel_date, @death_place, @death_minister, @extra_remarks, @bcc_unitid);")

			query.Parameters.AddWithValue("@regno", txtRegistrationNumber.Text.Trim)
			query.Parameters.AddWithValue("@name", txtName.Text.Trim)
			query.Parameters.AddWithValue("@phone", txtPhone.Text.Trim)
			query.Parameters.AddWithValue("@gender", IIf(rboMale.Checked, "M", "F"))
			query.Parameters.AddWithValue("@qualification", txtQualification.Text.Trim)
			query.Parameters.AddWithValue("@occupation", txtOccupation.Text.Trim)
			query.Parameters.AddWithValue("@address", txtAddress.Text)
			query.Parameters.AddWithValue("@bcc_unit", cboBccUnit.Text.Trim)
			query.Parameters.AddWithValue("@remarks", txtRemarks.Text)
			query.Parameters.AddWithValue("@dob", dtpDateOfBirth.Value.ToShortDateString)
			query.Parameters.AddWithValue("@baptism_date", dtpBaptism_date.Value.ToShortDateString)
			query.Parameters.AddWithValue("@father", txtFather.Text.ToString)
			query.Parameters.AddWithValue("@mother", txtMother.Text.Trim)
			query.Parameters.AddWithValue("@baptism_godfather", txtBaptism_godfather.Text.Trim)
			query.Parameters.AddWithValue("@baptism_godmother", txtBaptism_godmother.Text.Trim)
			query.Parameters.AddWithValue("@baptism_minister", txtBaptism_minister.Text.Trim)
			query.Parameters.AddWithValue("@confirmation_date", dtpConfirmation_Date.Value.ToShortDateString)
			query.Parameters.AddWithValue("@confirmation_minister", txtConfirmation_Minister.Text.Trim)
			query.Parameters.AddWithValue("@confirmation_godfather", txtConfirmation_godfather.Text.Trim)
			query.Parameters.AddWithValue("@confirmation_godmother", txtConfirmation_godmother.Text.Trim)
			query.Parameters.AddWithValue("@confirmation_church", txtConfirmation_Church.Text.Trim)
			query.Parameters.AddWithValue("@firstcommunion_date", dtpCommunion_Date.Value.ToShortDateString)
			query.Parameters.AddWithValue("@firstcommunion_minister", txtCommunion_Minister.Text.Trim)
			query.Parameters.AddWithValue("@firstcommunion_church", txtCommunion_Church.Text.Trim)
			query.Parameters.AddWithValue("@marriage_date", dtpMarriage_Date.Value.ToShortDateString)
			query.Parameters.AddWithValue("@Spouse_name", txtSpouse.Text.Trim)
			query.Parameters.AddWithValue("@marriage_minister", txtMarriage_Minister.Text.Trim)
			query.Parameters.AddWithValue("@marriage_church", txtMarriage_Church.Text.Trim)
			query.Parameters.AddWithValue("@death_date", dtpDeathDate.Value.ToShortDateString)
			query.Parameters.AddWithValue("@buriel_date", dtpBurial_Date.Value.ToShortDateString)
			query.Parameters.AddWithValue("@death_place", txtDeath_Place.Text.Trim)
			query.Parameters.AddWithValue("@death_minister", txtDeath_Minister.Text.Trim)
			query.Parameters.AddWithValue("@extra_remarks", txtExtraRemarks.Text)
			query.Parameters.AddWithValue("@bcc_unitid", 0)


		End If

	End Sub

	Function valid() As Boolean
		valid = False
		If txtName.Text.Trim.Length < 2 Then
			valid = False
			txtName.Select()
			err.SetError(txtName, "Enter Valid Name")
		Else
			valid = True

		End If

		If txtRegistrationNumber.Text.Trim.Length < 2 Then
			valid = False
			txtRegistrationNumber.Select()
			err.SetError(txtRegistrationNumber, "Enter Registration Number")
		Else
			valid = True

		End If

		If cboBccUnit.Text.Trim.Length < 2 Then
			valid = False
			cboBccUnit.Select()
			err.SetError(cboBccUnit, "Select BCC Unit")
		Else
			valid = True

		End If
	End Function

End Class