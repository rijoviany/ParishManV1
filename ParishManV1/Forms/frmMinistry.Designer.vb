<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMinistry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMinistry))
        Me.lblMinistryId = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.lblDiocesName = New System.Windows.Forms.Label()
        Me.txtDiocesName = New System.Windows.Forms.TextBox()
        Me.lblSubRegionName = New System.Windows.Forms.Label()
        Me.txtSubRegionName = New System.Windows.Forms.TextBox()
        Me.lblForaneName = New System.Windows.Forms.Label()
        Me.txtForaneName = New System.Windows.Forms.TextBox()
        Me.lblParishName = New System.Windows.Forms.Label()
        Me.txtParishName = New System.Windows.Forms.TextBox()
        Me.lblAnimator = New System.Windows.Forms.Label()
        Me.txtAnimator = New System.Windows.Forms.TextBox()
        Me.lblLeader = New System.Windows.Forms.Label()
        Me.txtLeader = New System.Windows.Forms.TextBox()
        Me.dgvMinistry = New System.Windows.Forms.DataGridView()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        CType(Me.dgvMinistry, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMinistryId
        '
        Me.lblMinistryId.AutoSize = True
        Me.lblMinistryId.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinistryId.Location = New System.Drawing.Point(48, 9)
        Me.lblMinistryId.Name = "lblMinistryId"
        Me.lblMinistryId.Size = New System.Drawing.Size(68, 16)
        Me.lblMinistryId.TabIndex = 0
        Me.lblMinistryId.Text = "Ministry Id"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(122, 8)
        Me.txtId.MaxLength = 11
        Me.txtId.Name = "txtId"
        Me.txtId.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(142, 20)
        Me.txtId.TabIndex = 1
        Me.txtId.Tag = "ministry_id"
        '
        'lblDiocesName
        '
        Me.lblDiocesName.AutoSize = True
        Me.lblDiocesName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiocesName.Location = New System.Drawing.Point(30, 34)
        Me.lblDiocesName.Name = "lblDiocesName"
        Me.lblDiocesName.Size = New System.Drawing.Size(86, 16)
        Me.lblDiocesName.TabIndex = 2
        Me.lblDiocesName.Text = "Dioces Name"
        '
        'txtDiocesName
        '
        Me.txtDiocesName.Location = New System.Drawing.Point(122, 34)
        Me.txtDiocesName.MaxLength = 11
        Me.txtDiocesName.Name = "txtDiocesName"
        Me.txtDiocesName.Size = New System.Drawing.Size(142, 20)
        Me.txtDiocesName.TabIndex = 3
        Me.txtDiocesName.Tag = "ministry_diocesname"
        '
        'lblSubRegionName
        '
        Me.lblSubRegionName.AutoSize = True
        Me.lblSubRegionName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubRegionName.Location = New System.Drawing.Point(3, 60)
        Me.lblSubRegionName.Name = "lblSubRegionName"
        Me.lblSubRegionName.Size = New System.Drawing.Size(113, 16)
        Me.lblSubRegionName.TabIndex = 4
        Me.lblSubRegionName.Text = "Sub Region Name"
        '
        'txtSubRegionName
        '
        Me.txtSubRegionName.Location = New System.Drawing.Point(122, 60)
        Me.txtSubRegionName.MaxLength = 11
        Me.txtSubRegionName.Name = "txtSubRegionName"
        Me.txtSubRegionName.Size = New System.Drawing.Size(142, 20)
        Me.txtSubRegionName.TabIndex = 5
        Me.txtSubRegionName.Tag = "ministry_subregionname"
        '
        'lblForaneName
        '
        Me.lblForaneName.AutoSize = True
        Me.lblForaneName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForaneName.Location = New System.Drawing.Point(30, 89)
        Me.lblForaneName.Name = "lblForaneName"
        Me.lblForaneName.Size = New System.Drawing.Size(86, 16)
        Me.lblForaneName.TabIndex = 6
        Me.lblForaneName.Text = "Forane Name"
        '
        'txtForaneName
        '
        Me.txtForaneName.Location = New System.Drawing.Point(122, 85)
        Me.txtForaneName.MaxLength = 11
        Me.txtForaneName.Name = "txtForaneName"
        Me.txtForaneName.Size = New System.Drawing.Size(142, 20)
        Me.txtForaneName.TabIndex = 7
        Me.txtForaneName.Tag = "ministry_foranename"
        '
        'lblParishName
        '
        Me.lblParishName.AutoSize = True
        Me.lblParishName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParishName.Location = New System.Drawing.Point(289, 9)
        Me.lblParishName.Name = "lblParishName"
        Me.lblParishName.Size = New System.Drawing.Size(83, 16)
        Me.lblParishName.TabIndex = 8
        Me.lblParishName.Text = "Parish Name"
        '
        'txtParishName
        '
        Me.txtParishName.Location = New System.Drawing.Point(378, 5)
        Me.txtParishName.MaxLength = 11
        Me.txtParishName.Name = "txtParishName"
        Me.txtParishName.Size = New System.Drawing.Size(142, 20)
        Me.txtParishName.TabIndex = 9
        Me.txtParishName.Tag = "ministry_parishname"
        '
        'lblAnimator
        '
        Me.lblAnimator.AutoSize = True
        Me.lblAnimator.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnimator.Location = New System.Drawing.Point(312, 35)
        Me.lblAnimator.Name = "lblAnimator"
        Me.lblAnimator.Size = New System.Drawing.Size(60, 16)
        Me.lblAnimator.TabIndex = 10
        Me.lblAnimator.Text = "Animator"
        '
        'txtAnimator
        '
        Me.txtAnimator.Location = New System.Drawing.Point(378, 31)
        Me.txtAnimator.MaxLength = 45
        Me.txtAnimator.Name = "txtAnimator"
        Me.txtAnimator.Size = New System.Drawing.Size(142, 20)
        Me.txtAnimator.TabIndex = 11
        Me.txtAnimator.Tag = "ministry_animator"
        '
        'lblLeader
        '
        Me.lblLeader.AutoSize = True
        Me.lblLeader.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLeader.Location = New System.Drawing.Point(320, 60)
        Me.lblLeader.Name = "lblLeader"
        Me.lblLeader.Size = New System.Drawing.Size(47, 16)
        Me.lblLeader.TabIndex = 12
        Me.lblLeader.Text = "Leader"
        '
        'txtLeader
        '
        Me.txtLeader.Location = New System.Drawing.Point(378, 57)
        Me.txtLeader.MaxLength = 45
        Me.txtLeader.Name = "txtLeader"
        Me.txtLeader.Size = New System.Drawing.Size(142, 20)
        Me.txtLeader.TabIndex = 13
        Me.txtLeader.Tag = "ministry_leader"
        '
        'dgvMinistry
        '
        Me.dgvMinistry.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvMinistry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMinistry.Location = New System.Drawing.Point(6, 111)
        Me.dgvMinistry.Name = "dgvMinistry"
        Me.dgvMinistry.ReadOnly = True
        Me.dgvMinistry.Size = New System.Drawing.Size(526, 233)
        Me.dgvMinistry.TabIndex = 14
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(352, 350)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(87, 24)
        Me.btnDelete.TabIndex = 24
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNew.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(166, 350)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(87, 24)
        Me.btnNew.TabIndex = 25
        Me.btnNew.Text = "&New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(259, 350)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(87, 24)
        Me.btnSave.TabIndex = 26
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(445, 350)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(87, 24)
        Me.btnClose.TabIndex = 27
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmMinistry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 386)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.dgvMinistry)
        Me.Controls.Add(Me.txtLeader)
        Me.Controls.Add(Me.lblLeader)
        Me.Controls.Add(Me.txtAnimator)
        Me.Controls.Add(Me.lblAnimator)
        Me.Controls.Add(Me.txtParishName)
        Me.Controls.Add(Me.lblParishName)
        Me.Controls.Add(Me.txtForaneName)
        Me.Controls.Add(Me.lblForaneName)
        Me.Controls.Add(Me.txtSubRegionName)
        Me.Controls.Add(Me.lblSubRegionName)
        Me.Controls.Add(Me.txtDiocesName)
        Me.Controls.Add(Me.lblDiocesName)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.lblMinistryId)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMinistry"
        Me.Text = "Ministry"
        CType(Me.dgvMinistry, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMinistryId As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents lblDiocesName As Label
    Friend WithEvents txtDiocesName As TextBox
    Friend WithEvents lblSubRegionName As Label
    Friend WithEvents txtSubRegionName As TextBox
    Friend WithEvents lblForaneName As Label
    Friend WithEvents txtForaneName As TextBox
    Friend WithEvents lblParishName As Label
    Friend WithEvents txtParishName As TextBox
    Friend WithEvents lblAnimator As Label
    Friend WithEvents txtAnimator As TextBox
    Friend WithEvents lblLeader As Label
    Friend WithEvents txtLeader As TextBox
    Friend WithEvents dgvMinistry As DataGridView
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClose As Button
End Class
