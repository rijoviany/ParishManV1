<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDiocese
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDiocese))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDioceseName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBishop = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboRite = New System.Windows.Forms.ComboBox()
        Me.dgvDiocese = New System.Windows.Forms.DataGridView()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtDioceseId = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        CType(Me.dgvDiocese, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(254, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Diocese Name"
        '
        'txtDioceseName
        '
        Me.txtDioceseName.BackColor = System.Drawing.Color.Bisque
        Me.txtDioceseName.Location = New System.Drawing.Point(362, 12)
        Me.txtDioceseName.MaxLength = 45
        Me.txtDioceseName.Name = "txtDioceseName"
        Me.txtDioceseName.Size = New System.Drawing.Size(262, 21)
        Me.txtDioceseName.TabIndex = 3
        Me.txtDioceseName.Tag = "diocesename"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(298, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Bishop"
        '
        'txtBishop
        '
        Me.txtBishop.BackColor = System.Drawing.Color.Bisque
        Me.txtBishop.Location = New System.Drawing.Point(362, 39)
        Me.txtBishop.MaxLength = 45
        Me.txtBishop.Name = "txtBishop"
        Me.txtBishop.Size = New System.Drawing.Size(262, 21)
        Me.txtBishop.TabIndex = 6
        Me.txtBishop.Tag = "bishop"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Rite"
        '
        'cboRite
        '
        Me.cboRite.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboRite.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboRite.BackColor = System.Drawing.Color.Bisque
        Me.cboRite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRite.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboRite.FormattingEnabled = True
        Me.cboRite.Items.AddRange(New Object() {"Latin", "Sero Malabar", "Malankara"})
        Me.cboRite.Location = New System.Drawing.Point(85, 38)
        Me.cboRite.Name = "cboRite"
        Me.cboRite.Size = New System.Drawing.Size(164, 23)
        Me.cboRite.TabIndex = 5
        Me.cboRite.Tag = "rite"
        '
        'dgvDiocese
        '
        Me.dgvDiocese.AllowUserToAddRows = False
        Me.dgvDiocese.AllowUserToDeleteRows = False
        Me.dgvDiocese.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDiocese.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgvDiocese.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDiocese.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvDiocese.Location = New System.Drawing.Point(13, 66)
        Me.dgvDiocese.MultiSelect = False
        Me.dgvDiocese.Name = "dgvDiocese"
        Me.dgvDiocese.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDiocese.Size = New System.Drawing.Size(611, 201)
        Me.dgvDiocese.TabIndex = 7
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Location = New System.Drawing.Point(387, 277)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Location = New System.Drawing.Point(549, 277)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Close"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Diocese Id"
        '
        'btnNew
        '
        Me.btnNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNew.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNew.Location = New System.Drawing.Point(306, 277)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 23)
        Me.btnNew.TabIndex = 8
        Me.btnNew.Text = "&New"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDelete.Location = New System.Drawing.Point(468, 277)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'txtDioceseId
        '
        Me.txtDioceseId.Location = New System.Drawing.Point(85, 9)
        Me.txtDioceseId.Name = "txtDioceseId"
        Me.txtDioceseId.ReadOnly = True
        Me.txtDioceseId.Size = New System.Drawing.Size(160, 21)
        Me.txtDioceseId.TabIndex = 10
        Me.txtDioceseId.Tag = "dioceseid"
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.Location = New System.Drawing.Point(12, 277)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(112, 23)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "&Add Sub Region"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'frmDiocese
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 312)
        Me.Controls.Add(Me.txtDioceseId)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.dgvDiocese)
        Me.Controls.Add(Me.cboRite)
        Me.Controls.Add(Me.txtBishop)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDioceseName)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(655, 336)
        Me.Name = "frmDiocese"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "diocese"
        Me.Text = "Diocese"
        CType(Me.dgvDiocese, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtDioceseName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBishop As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboRite As ComboBox
    Friend WithEvents dgvDiocese As DataGridView
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btnNew As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtDioceseId As TextBox
    Friend WithEvents btnAdd As Button
End Class
