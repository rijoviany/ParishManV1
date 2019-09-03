<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParish
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmParish))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtParishId = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboForane = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPlace = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboParentParish = New System.Windows.Forms.ComboBox()
        Me.dgvParish = New System.Windows.Forms.DataGridView()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnAddBcc = New System.Windows.Forms.Button()
        Me.lblMonthly_Vari = New System.Windows.Forms.Label()
        Me.txtMontlyVari = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtFeastVari = New System.Windows.Forms.TextBox()
        CType(Me.dgvParish, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Parish ID"
        '
        'txtParishId
        '
        Me.txtParishId.Location = New System.Drawing.Point(82, 6)
        Me.txtParishId.MaxLength = 11
        Me.txtParishId.Name = "txtParishId"
        Me.txtParishId.ReadOnly = True
        Me.txtParishId.Size = New System.Drawing.Size(170, 22)
        Me.txtParishId.TabIndex = 1
        Me.txtParishId.Tag = "parishid"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Parish"
        '
        'txtName
        '
        Me.txtName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtName.Location = New System.Drawing.Point(82, 31)
        Me.txtName.MaxLength = 45
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(416, 22)
        Me.txtName.TabIndex = 3
        Me.txtName.Tag = "parishname"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Forane"
        '
        'cboForane
        '
        Me.cboForane.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboForane.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboForane.FormattingEnabled = True
        Me.cboForane.Location = New System.Drawing.Point(82, 56)
        Me.cboForane.MaxLength = 11
        Me.cboForane.Name = "cboForane"
        Me.cboForane.Size = New System.Drawing.Size(149, 24)
        Me.cboForane.TabIndex = 5
        Me.cboForane.Tag = "foranename"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(258, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Place"
        '
        'txtPlace
        '
        Me.txtPlace.Location = New System.Drawing.Point(304, 6)
        Me.txtPlace.MaxLength = 45
        Me.txtPlace.Name = "txtPlace"
        Me.txtPlace.Size = New System.Drawing.Size(194, 22)
        Me.txtPlace.TabIndex = 7
        Me.txtPlace.Tag = "place"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(231, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Main Parish"
        '
        'cboParentParish
        '
        Me.cboParentParish.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboParentParish.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboParentParish.FormattingEnabled = True
        Me.cboParentParish.Location = New System.Drawing.Point(314, 56)
        Me.cboParentParish.Name = "cboParentParish"
        Me.cboParentParish.Size = New System.Drawing.Size(184, 24)
        Me.cboParentParish.TabIndex = 9
        Me.cboParentParish.Tag = "mainparish"
        '
        'dgvParish
        '
        Me.dgvParish.AllowUserToAddRows = False
        Me.dgvParish.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvParish.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvParish.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvParish.Location = New System.Drawing.Point(7, 111)
        Me.dgvParish.MultiSelect = False
        Me.dgvParish.Name = "dgvParish"
        Me.dgvParish.ReadOnly = True
        Me.dgvParish.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvParish.Size = New System.Drawing.Size(498, 272)
        Me.dgvParish.TabIndex = 10
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(321, 389)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(87, 24)
        Me.btnDelete.TabIndex = 13
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnNew
        '
        Me.btnNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNew.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(132, 389)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(87, 24)
        Me.btnNew.TabIndex = 11
        Me.btnNew.Text = "&New"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(226, 389)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(87, 24)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(418, 389)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(87, 24)
        Me.btnClose.TabIndex = 14
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnAddBcc
        '
        Me.btnAddBcc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAddBcc.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnAddBcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddBcc.Location = New System.Drawing.Point(11, 390)
        Me.btnAddBcc.Name = "btnAddBcc"
        Me.btnAddBcc.Size = New System.Drawing.Size(85, 23)
        Me.btnAddBcc.TabIndex = 15
        Me.btnAddBcc.Text = "Add BCC Unit"
        Me.btnAddBcc.UseVisualStyleBackColor = False
        '
        'lblMonthly_Vari
        '
        Me.lblMonthly_Vari.AutoSize = True
        Me.lblMonthly_Vari.Location = New System.Drawing.Point(1, 86)
        Me.lblMonthly_Vari.Name = "lblMonthly_Vari"
        Me.lblMonthly_Vari.Size = New System.Drawing.Size(80, 16)
        Me.lblMonthly_Vari.TabIndex = 4
        Me.lblMonthly_Vari.Text = "Monthly Vari"
        '
        'txtMontlyVari
        '
        Me.txtMontlyVari.Location = New System.Drawing.Point(82, 83)
        Me.txtMontlyVari.MaxLength = 45
        Me.txtMontlyVari.Name = "txtMontlyVari"
        Me.txtMontlyVari.Size = New System.Drawing.Size(170, 22)
        Me.txtMontlyVari.TabIndex = 7
        Me.txtMontlyVari.Tag = "place"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(258, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 16)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Feast Vari"
        '
        'txtFeastVari
        '
        Me.txtFeastVari.Location = New System.Drawing.Point(331, 83)
        Me.txtFeastVari.MaxLength = 45
        Me.txtFeastVari.Name = "txtFeastVari"
        Me.txtFeastVari.Size = New System.Drawing.Size(167, 22)
        Me.txtFeastVari.TabIndex = 7
        Me.txtFeastVari.Tag = "place"
        '
        'frmParish
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 418)
        Me.Controls.Add(Me.btnAddBcc)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.dgvParish)
        Me.Controls.Add(Me.cboParentParish)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtFeastVari)
        Me.Controls.Add(Me.txtMontlyVari)
        Me.Controls.Add(Me.txtPlace)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboForane)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblMonthly_Vari)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtParishId)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MinimumSize = New System.Drawing.Size(529, 456)
        Me.Name = "frmParish"
        Me.Text = "Parish"
        CType(Me.dgvParish, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtParishId As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboForane As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPlace As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cboParentParish As ComboBox
    Friend WithEvents dgvParish As DataGridView
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnAddBcc As Button
    Friend WithEvents lblMonthly_Vari As Label
    Friend WithEvents txtMontlyVari As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtFeastVari As TextBox
End Class
