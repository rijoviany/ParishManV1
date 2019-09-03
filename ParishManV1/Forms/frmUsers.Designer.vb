<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsers
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsers))
		Me.groupbox1 = New System.Windows.Forms.GroupBox()
		Me.cboRole = New System.Windows.Forms.ComboBox()
		Me.btnClose = New System.Windows.Forms.Button()
		Me.btnDelete = New System.Windows.Forms.Button()
		Me.btnSave = New System.Windows.Forms.Button()
		Me.btnNew = New System.Windows.Forms.Button()
		Me.cboBccUnit = New System.Windows.Forms.ComboBox()
		Me.cboParish = New System.Windows.Forms.ComboBox()
		Me.cboForane = New System.Windows.Forms.ComboBox()
		Me.cboSubregion = New System.Windows.Forms.ComboBox()
		Me.cboDiocese = New System.Windows.Forms.ComboBox()
		Me.txtRepeatPassword = New System.Windows.Forms.TextBox()
		Me.txtPassword = New System.Windows.Forms.TextBox()
		Me.txtUsername = New System.Windows.Forms.TextBox()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.dgvUsers = New System.Windows.Forms.DataGridView()
		Me.groupbox1.SuspendLayout()
		CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'groupbox1
		'
		Me.groupbox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.groupbox1.Controls.Add(Me.cboRole)
		Me.groupbox1.Controls.Add(Me.btnClose)
		Me.groupbox1.Controls.Add(Me.btnDelete)
		Me.groupbox1.Controls.Add(Me.btnSave)
		Me.groupbox1.Controls.Add(Me.btnNew)
		Me.groupbox1.Controls.Add(Me.cboBccUnit)
		Me.groupbox1.Controls.Add(Me.cboParish)
		Me.groupbox1.Controls.Add(Me.cboForane)
		Me.groupbox1.Controls.Add(Me.cboSubregion)
		Me.groupbox1.Controls.Add(Me.cboDiocese)
		Me.groupbox1.Controls.Add(Me.txtRepeatPassword)
		Me.groupbox1.Controls.Add(Me.txtPassword)
		Me.groupbox1.Controls.Add(Me.txtUsername)
		Me.groupbox1.Controls.Add(Me.Label8)
		Me.groupbox1.Controls.Add(Me.Label7)
		Me.groupbox1.Controls.Add(Me.Label6)
		Me.groupbox1.Controls.Add(Me.Label5)
		Me.groupbox1.Controls.Add(Me.Label4)
		Me.groupbox1.Controls.Add(Me.Label9)
		Me.groupbox1.Controls.Add(Me.Label3)
		Me.groupbox1.Controls.Add(Me.Label2)
		Me.groupbox1.Controls.Add(Me.Label1)
		Me.groupbox1.Location = New System.Drawing.Point(334, 2)
		Me.groupbox1.Name = "groupbox1"
		Me.groupbox1.Size = New System.Drawing.Size(329, 290)
		Me.groupbox1.TabIndex = 0
		Me.groupbox1.TabStop = False
		Me.groupbox1.Text = "Details"
		'
		'cboRole
		'
		Me.cboRole.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
		Me.cboRole.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
		Me.cboRole.BackColor = System.Drawing.Color.Bisque
		Me.cboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cboRole.FormattingEnabled = True
		Me.cboRole.Items.AddRange(New Object() {"1. Admin", "2. Parish Priest", "3. Data Entry", "4. Finance", "5. Education"})
		Me.cboRole.Location = New System.Drawing.Point(128, 91)
		Me.cboRole.Name = "cboRole"
		Me.cboRole.Size = New System.Drawing.Size(181, 24)
		Me.cboRole.TabIndex = 3
		'
		'btnClose
		'
		Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnClose.BackColor = System.Drawing.Color.DarkGray
		Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.btnClose.Location = New System.Drawing.Point(243, 258)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.Size = New System.Drawing.Size(75, 23)
		Me.btnClose.TabIndex = 12
		Me.btnClose.Text = "Close"
		Me.btnClose.UseVisualStyleBackColor = False
		'
		'btnDelete
		'
		Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnDelete.BackColor = System.Drawing.Color.DarkGray
		Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.btnDelete.Location = New System.Drawing.Point(164, 258)
		Me.btnDelete.Name = "btnDelete"
		Me.btnDelete.Size = New System.Drawing.Size(75, 23)
		Me.btnDelete.TabIndex = 11
		Me.btnDelete.Text = "Delete"
		Me.btnDelete.UseVisualStyleBackColor = False
		'
		'btnSave
		'
		Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnSave.BackColor = System.Drawing.Color.DarkGray
		Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.btnSave.Location = New System.Drawing.Point(85, 258)
		Me.btnSave.Name = "btnSave"
		Me.btnSave.Size = New System.Drawing.Size(75, 23)
		Me.btnSave.TabIndex = 10
		Me.btnSave.Text = "&Save"
		Me.btnSave.UseVisualStyleBackColor = False
		'
		'btnNew
		'
		Me.btnNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnNew.BackColor = System.Drawing.Color.DarkGray
		Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.btnNew.Location = New System.Drawing.Point(6, 258)
		Me.btnNew.Name = "btnNew"
		Me.btnNew.Size = New System.Drawing.Size(75, 23)
		Me.btnNew.TabIndex = 9
		Me.btnNew.Text = "New"
		Me.btnNew.UseVisualStyleBackColor = False
		'
		'cboBccUnit
		'
		Me.cboBccUnit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
		Me.cboBccUnit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
		Me.cboBccUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cboBccUnit.FormattingEnabled = True
		Me.cboBccUnit.Location = New System.Drawing.Point(128, 221)
		Me.cboBccUnit.Name = "cboBccUnit"
		Me.cboBccUnit.Size = New System.Drawing.Size(181, 24)
		Me.cboBccUnit.TabIndex = 8
		'
		'cboParish
		'
		Me.cboParish.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
		Me.cboParish.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
		Me.cboParish.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cboParish.FormattingEnabled = True
		Me.cboParish.Location = New System.Drawing.Point(128, 195)
		Me.cboParish.Name = "cboParish"
		Me.cboParish.Size = New System.Drawing.Size(181, 24)
		Me.cboParish.TabIndex = 7
		'
		'cboForane
		'
		Me.cboForane.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
		Me.cboForane.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
		Me.cboForane.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cboForane.FormattingEnabled = True
		Me.cboForane.Location = New System.Drawing.Point(128, 169)
		Me.cboForane.Name = "cboForane"
		Me.cboForane.Size = New System.Drawing.Size(181, 24)
		Me.cboForane.TabIndex = 6
		'
		'cboSubregion
		'
		Me.cboSubregion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
		Me.cboSubregion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
		Me.cboSubregion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cboSubregion.FormattingEnabled = True
		Me.cboSubregion.Location = New System.Drawing.Point(128, 143)
		Me.cboSubregion.Name = "cboSubregion"
		Me.cboSubregion.Size = New System.Drawing.Size(181, 24)
		Me.cboSubregion.TabIndex = 5
		'
		'cboDiocese
		'
		Me.cboDiocese.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
		Me.cboDiocese.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
		Me.cboDiocese.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cboDiocese.FormattingEnabled = True
		Me.cboDiocese.Location = New System.Drawing.Point(128, 117)
		Me.cboDiocese.Name = "cboDiocese"
		Me.cboDiocese.Size = New System.Drawing.Size(181, 24)
		Me.cboDiocese.TabIndex = 4
		'
		'txtRepeatPassword
		'
		Me.txtRepeatPassword.BackColor = System.Drawing.Color.Bisque
		Me.txtRepeatPassword.Location = New System.Drawing.Point(128, 67)
		Me.txtRepeatPassword.MaxLength = 12
		Me.txtRepeatPassword.Name = "txtRepeatPassword"
		Me.txtRepeatPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.txtRepeatPassword.Size = New System.Drawing.Size(181, 22)
		Me.txtRepeatPassword.TabIndex = 2
		'
		'txtPassword
		'
		Me.txtPassword.BackColor = System.Drawing.Color.Bisque
		Me.txtPassword.Location = New System.Drawing.Point(128, 43)
		Me.txtPassword.MaxLength = 12
		Me.txtPassword.Name = "txtPassword"
		Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.txtPassword.Size = New System.Drawing.Size(181, 22)
		Me.txtPassword.TabIndex = 1
		'
		'txtUsername
		'
		Me.txtUsername.BackColor = System.Drawing.Color.Bisque
		Me.txtUsername.Location = New System.Drawing.Point(128, 19)
		Me.txtUsername.MaxLength = 45
		Me.txtUsername.Name = "txtUsername"
		Me.txtUsername.Size = New System.Drawing.Size(181, 22)
		Me.txtUsername.TabIndex = 0
		Me.txtUsername.Tag = "username"
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Location = New System.Drawing.Point(64, 221)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(58, 16)
		Me.Label8.TabIndex = 0
		Me.Label8.Text = "Bcc Unit"
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(81, 197)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(45, 16)
		Me.Label7.TabIndex = 0
		Me.Label7.Text = "Parish"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(78, 172)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(48, 16)
		Me.Label6.TabIndex = 0
		Me.Label6.Text = "Forane"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(60, 147)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(66, 16)
		Me.Label5.TabIndex = 0
		Me.Label5.Text = "Subregion"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(71, 122)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(55, 16)
		Me.Label4.TabIndex = 0
		Me.Label4.Text = "Diocese"
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Location = New System.Drawing.Point(87, 97)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(39, 16)
		Me.Label9.TabIndex = 0
		Me.Label9.Text = "*Role"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(9, 72)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(117, 16)
		Me.Label3.TabIndex = 0
		Me.Label3.Text = "*Reenter password"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(56, 47)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(70, 16)
		Me.Label2.TabIndex = 0
		Me.Label2.Text = "*Password"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(48, 22)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(78, 16)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "*User Name"
		'
		'dgvUsers
		'
		Me.dgvUsers.AllowUserToAddRows = False
		Me.dgvUsers.AllowUserToDeleteRows = False
		Me.dgvUsers.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvUsers.Location = New System.Drawing.Point(3, 3)
		Me.dgvUsers.Name = "dgvUsers"
		Me.dgvUsers.ReadOnly = True
		Me.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgvUsers.Size = New System.Drawing.Size(328, 288)
		Me.dgvUsers.TabIndex = 1
		'
		'frmUsers
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(666, 295)
		Me.Controls.Add(Me.dgvUsers)
		Me.Controls.Add(Me.groupbox1)
		Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.MinimumSize = New System.Drawing.Size(682, 333)
		Me.Name = "frmUsers"
		Me.Text = "Users"
		Me.groupbox1.ResumeLayout(False)
		Me.groupbox1.PerformLayout()
		CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents groupbox1 As GroupBox
    Friend WithEvents dgvUsers As DataGridView
    Friend WithEvents cboBccUnit As ComboBox
    Friend WithEvents cboParish As ComboBox
    Friend WithEvents cboForane As ComboBox
    Friend WithEvents cboSubregion As ComboBox
    Friend WithEvents cboDiocese As ComboBox
    Friend WithEvents txtRepeatPassword As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents cboRole As ComboBox
    Friend WithEvents Label9 As Label
End Class
