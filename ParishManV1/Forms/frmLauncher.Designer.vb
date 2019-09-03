<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLauncher
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLauncher))
		Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.FileToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.LoginHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
		Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuNewUser = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
		Me.mnuNewDiocese = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuNewRegion = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuNewForane = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuNewParish = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuNewSubstation = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuNewBCCUnit = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuNewFamily = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuNewMember = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuNewMinistry = New System.Windows.Forms.ToolStripMenuItem()
		Me.FinanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.FamilyFinanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
		Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.lblUser = New System.Windows.Forms.ToolStripStatusLabel()
		Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.lblLogin = New System.Windows.Forms.ToolStripStatusLabel()
		Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.lblRoleid = New System.Windows.Forms.ToolStripStatusLabel()
		Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.lblSessionToken = New System.Windows.Forms.ToolStripStatusLabel()
		Me.lblDiocese = New System.Windows.Forms.ToolStripStatusLabel()
		Me.lblSubRegion = New System.Windows.Forms.ToolStripStatusLabel()
		Me.lblForane = New System.Windows.Forms.ToolStripStatusLabel()
		Me.lblParish = New System.Windows.Forms.ToolStripStatusLabel()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.btnSubregion = New System.Windows.Forms.Button()
		Me.btnForane = New System.Windows.Forms.Button()
		Me.btnParish = New System.Windows.Forms.Button()
		Me.btnBccunit = New System.Windows.Forms.Button()
		Me.btnFamily = New System.Windows.Forms.Button()
		Me.btnFamilyMember = New System.Windows.Forms.Button()
		Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
		Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
		Me.cboParish = New System.Windows.Forms.ToolStripComboBox()
		Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
		Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
		Me.cboBccunit = New System.Windows.Forms.ToolStripComboBox()
		Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
		Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
		Me.cboFamily = New System.Windows.Forms.ToolStripComboBox()
		Me.LettersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.CertificatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.BaptismToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.MarriageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.MenuStrip1.SuspendLayout()
		Me.StatusStrip1.SuspendLayout()
		Me.Panel1.SuspendLayout()
		Me.ToolStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'MenuStrip1
		'
		Me.MenuStrip1.BackColor = System.Drawing.Color.SlateGray
		Me.MenuStrip1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem1, Me.FileToolStripMenuItem, Me.FinanceToolStripMenuItem, Me.ReportsToolStripMenuItem})
		Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.Size = New System.Drawing.Size(1133, 24)
		Me.MenuStrip1.TabIndex = 1
		Me.MenuStrip1.Text = "MenuStrip1"
		'
		'FileToolStripMenuItem1
		'
		Me.FileToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginHistoryToolStripMenuItem, Me.ToolStripMenuItem2, Me.CloseToolStripMenuItem})
		Me.FileToolStripMenuItem1.Name = "FileToolStripMenuItem1"
		Me.FileToolStripMenuItem1.Size = New System.Drawing.Size(41, 20)
		Me.FileToolStripMenuItem1.Text = "File"
		'
		'LoginHistoryToolStripMenuItem
		'
		Me.LoginHistoryToolStripMenuItem.Name = "LoginHistoryToolStripMenuItem"
		Me.LoginHistoryToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
		Me.LoginHistoryToolStripMenuItem.Text = "Login History"
		'
		'ToolStripMenuItem2
		'
		Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
		Me.ToolStripMenuItem2.Size = New System.Drawing.Size(149, 6)
		'
		'CloseToolStripMenuItem
		'
		Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
		Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
		Me.CloseToolStripMenuItem.Text = "Close"
		'
		'FileToolStripMenuItem
		'
		Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNewUser, Me.ToolStripMenuItem1, Me.mnuNewDiocese, Me.mnuNewRegion, Me.mnuNewForane, Me.mnuNewParish, Me.mnuNewSubstation, Me.mnuNewBCCUnit, Me.mnuNewFamily, Me.mnuNewMember, Me.mnuNewMinistry})
		Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
		Me.FileToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
		Me.FileToolStripMenuItem.Text = "New"
		'
		'mnuNewUser
		'
		Me.mnuNewUser.Name = "mnuNewUser"
		Me.mnuNewUser.Size = New System.Drawing.Size(138, 22)
		Me.mnuNewUser.Text = "User"
		'
		'ToolStripMenuItem1
		'
		Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
		Me.ToolStripMenuItem1.Size = New System.Drawing.Size(135, 6)
		'
		'mnuNewDiocese
		'
		Me.mnuNewDiocese.Name = "mnuNewDiocese"
		Me.mnuNewDiocese.Size = New System.Drawing.Size(138, 22)
		Me.mnuNewDiocese.Text = "Diocese"
		'
		'mnuNewRegion
		'
		Me.mnuNewRegion.Name = "mnuNewRegion"
		Me.mnuNewRegion.Size = New System.Drawing.Size(138, 22)
		Me.mnuNewRegion.Text = "Region"
		'
		'mnuNewForane
		'
		Me.mnuNewForane.Name = "mnuNewForane"
		Me.mnuNewForane.Size = New System.Drawing.Size(138, 22)
		Me.mnuNewForane.Text = "Forane"
		'
		'mnuNewParish
		'
		Me.mnuNewParish.Name = "mnuNewParish"
		Me.mnuNewParish.Size = New System.Drawing.Size(138, 22)
		Me.mnuNewParish.Text = "Parish"
		'
		'mnuNewSubstation
		'
		Me.mnuNewSubstation.Name = "mnuNewSubstation"
		Me.mnuNewSubstation.Size = New System.Drawing.Size(138, 22)
		Me.mnuNewSubstation.Text = "Substation"
		'
		'mnuNewBCCUnit
		'
		Me.mnuNewBCCUnit.Name = "mnuNewBCCUnit"
		Me.mnuNewBCCUnit.Size = New System.Drawing.Size(138, 22)
		Me.mnuNewBCCUnit.Text = "BCC Unit"
		'
		'mnuNewFamily
		'
		Me.mnuNewFamily.Name = "mnuNewFamily"
		Me.mnuNewFamily.Size = New System.Drawing.Size(138, 22)
		Me.mnuNewFamily.Text = "Family"
		'
		'mnuNewMember
		'
		Me.mnuNewMember.Name = "mnuNewMember"
		Me.mnuNewMember.Size = New System.Drawing.Size(138, 22)
		Me.mnuNewMember.Text = "Member"
		'
		'mnuNewMinistry
		'
		Me.mnuNewMinistry.Name = "mnuNewMinistry"
		Me.mnuNewMinistry.Size = New System.Drawing.Size(138, 22)
		Me.mnuNewMinistry.Text = "Ministry"
		'
		'FinanceToolStripMenuItem
		'
		Me.FinanceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FamilyFinanceToolStripMenuItem})
		Me.FinanceToolStripMenuItem.Name = "FinanceToolStripMenuItem"
		Me.FinanceToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
		Me.FinanceToolStripMenuItem.Text = "Finance"
		'
		'FamilyFinanceToolStripMenuItem
		'
		Me.FamilyFinanceToolStripMenuItem.Name = "FamilyFinanceToolStripMenuItem"
		Me.FamilyFinanceToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
		Me.FamilyFinanceToolStripMenuItem.Text = "Family Finance"
		'
		'ReportsToolStripMenuItem
		'
		Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LettersToolStripMenuItem, Me.CertificatesToolStripMenuItem})
		Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
		Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
		Me.ReportsToolStripMenuItem.Text = "Registers"
		'
		'StatusStrip1
		'
		Me.StatusStrip1.BackColor = System.Drawing.Color.SlateGray
		Me.StatusStrip1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lblStatus, Me.ToolStripStatusLabel2, Me.lblUser, Me.ToolStripStatusLabel3, Me.lblLogin, Me.ToolStripStatusLabel4, Me.lblRoleid, Me.ToolStripStatusLabel5, Me.lblSessionToken, Me.lblDiocese, Me.lblSubRegion, Me.lblForane, Me.lblParish})
		Me.StatusStrip1.Location = New System.Drawing.Point(0, 644)
		Me.StatusStrip1.Name = "StatusStrip1"
		Me.StatusStrip1.Size = New System.Drawing.Size(1133, 24)
		Me.StatusStrip1.TabIndex = 3
		Me.StatusStrip1.Text = "StatusStrip1"
		'
		'ToolStripStatusLabel1
		'
		Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
		Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(45, 19)
		Me.ToolStripStatusLabel1.Text = "Status:"
		'
		'lblStatus
		'
		Me.lblStatus.AutoToolTip = True
		Me.lblStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.lblStatus.Name = "lblStatus"
		Me.lblStatus.Size = New System.Drawing.Size(10, 19)
		Me.lblStatus.Text = " "
		'
		'ToolStripStatusLabel2
		'
		Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
		Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(34, 19)
		Me.ToolStripStatusLabel2.Text = "User"
		'
		'lblUser
		'
		Me.lblUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.lblUser.Name = "lblUser"
		Me.lblUser.Size = New System.Drawing.Size(10, 19)
		Me.lblUser.Text = " "
		'
		'ToolStripStatusLabel3
		'
		Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
		Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(38, 19)
		Me.ToolStripStatusLabel3.Text = "Login"
		'
		'lblLogin
		'
		Me.lblLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.lblLogin.Name = "lblLogin"
		Me.lblLogin.Size = New System.Drawing.Size(10, 19)
		Me.lblLogin.Text = " "
		'
		'ToolStripStatusLabel4
		'
		Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
		Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(33, 19)
		Me.ToolStripStatusLabel4.Text = "Role"
		'
		'lblRoleid
		'
		Me.lblRoleid.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.lblRoleid.Name = "lblRoleid"
		Me.lblRoleid.Size = New System.Drawing.Size(10, 19)
		Me.lblRoleid.Text = " "
		'
		'ToolStripStatusLabel5
		'
		Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
		Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(89, 19)
		Me.ToolStripStatusLabel5.Text = "Session Token"
		'
		'lblSessionToken
		'
		Me.lblSessionToken.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom
		Me.lblSessionToken.Name = "lblSessionToken"
		Me.lblSessionToken.Size = New System.Drawing.Size(14, 19)
		Me.lblSessionToken.Text = " "
		'
		'lblDiocese
		'
		Me.lblDiocese.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom
		Me.lblDiocese.Name = "lblDiocese"
		Me.lblDiocese.Size = New System.Drawing.Size(14, 19)
		Me.lblDiocese.Text = " "
		'
		'lblSubRegion
		'
		Me.lblSubRegion.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom
		Me.lblSubRegion.Name = "lblSubRegion"
		Me.lblSubRegion.Size = New System.Drawing.Size(14, 19)
		Me.lblSubRegion.Text = " "
		'
		'lblForane
		'
		Me.lblForane.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom
		Me.lblForane.Name = "lblForane"
		Me.lblForane.Size = New System.Drawing.Size(14, 19)
		Me.lblForane.Text = " "
		'
		'lblParish
		'
		Me.lblParish.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom
		Me.lblParish.Name = "lblParish"
		Me.lblParish.Size = New System.Drawing.Size(14, 19)
		Me.lblParish.Text = " "
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.SlateGray
		Me.Panel1.Controls.Add(Me.btnSubregion)
		Me.Panel1.Controls.Add(Me.btnForane)
		Me.Panel1.Controls.Add(Me.btnParish)
		Me.Panel1.Controls.Add(Me.btnBccunit)
		Me.Panel1.Controls.Add(Me.btnFamily)
		Me.Panel1.Controls.Add(Me.btnFamilyMember)
		Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
		Me.Panel1.Location = New System.Drawing.Point(0, 49)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(184, 595)
		Me.Panel1.TabIndex = 6
		'
		'btnSubregion
		'
		Me.btnSubregion.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.btnSubregion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.btnSubregion.FlatAppearance.BorderSize = 0
		Me.btnSubregion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.btnSubregion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.btnSubregion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnSubregion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSubregion.Location = New System.Drawing.Point(5, 267)
		Me.btnSubregion.Name = "btnSubregion"
		Me.btnSubregion.Size = New System.Drawing.Size(174, 46)
		Me.btnSubregion.TabIndex = 0
		Me.btnSubregion.Text = "Sub Region"
		Me.btnSubregion.UseVisualStyleBackColor = False
		'
		'btnForane
		'
		Me.btnForane.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.btnForane.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.btnForane.FlatAppearance.BorderSize = 0
		Me.btnForane.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.btnForane.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.btnForane.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnForane.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnForane.Location = New System.Drawing.Point(5, 215)
		Me.btnForane.Name = "btnForane"
		Me.btnForane.Size = New System.Drawing.Size(174, 46)
		Me.btnForane.TabIndex = 0
		Me.btnForane.Text = "Forane"
		Me.btnForane.UseVisualStyleBackColor = False
		'
		'btnParish
		'
		Me.btnParish.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.btnParish.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.btnParish.FlatAppearance.BorderSize = 0
		Me.btnParish.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.btnParish.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.btnParish.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnParish.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnParish.Location = New System.Drawing.Point(5, 163)
		Me.btnParish.Name = "btnParish"
		Me.btnParish.Size = New System.Drawing.Size(174, 46)
		Me.btnParish.TabIndex = 0
		Me.btnParish.Text = "Parish"
		Me.btnParish.UseVisualStyleBackColor = False
		'
		'btnBccunit
		'
		Me.btnBccunit.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.btnBccunit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.btnBccunit.FlatAppearance.BorderSize = 0
		Me.btnBccunit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.btnBccunit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.btnBccunit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnBccunit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnBccunit.Location = New System.Drawing.Point(5, 111)
		Me.btnBccunit.Name = "btnBccunit"
		Me.btnBccunit.Size = New System.Drawing.Size(174, 46)
		Me.btnBccunit.TabIndex = 0
		Me.btnBccunit.Text = "BCC Unit"
		Me.btnBccunit.UseVisualStyleBackColor = False
		'
		'btnFamily
		'
		Me.btnFamily.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.btnFamily.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.btnFamily.FlatAppearance.BorderSize = 0
		Me.btnFamily.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.btnFamily.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.btnFamily.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnFamily.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnFamily.Location = New System.Drawing.Point(5, 59)
		Me.btnFamily.Name = "btnFamily"
		Me.btnFamily.Size = New System.Drawing.Size(174, 46)
		Me.btnFamily.TabIndex = 0
		Me.btnFamily.Text = "Family"
		Me.btnFamily.UseVisualStyleBackColor = False
		'
		'btnFamilyMember
		'
		Me.btnFamilyMember.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.btnFamilyMember.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.btnFamilyMember.FlatAppearance.BorderSize = 0
		Me.btnFamilyMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.btnFamilyMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.btnFamilyMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnFamilyMember.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnFamilyMember.Location = New System.Drawing.Point(5, 7)
		Me.btnFamilyMember.Name = "btnFamilyMember"
		Me.btnFamilyMember.Size = New System.Drawing.Size(174, 46)
		Me.btnFamilyMember.TabIndex = 0
		Me.btnFamilyMember.Text = "Family Member"
		Me.btnFamilyMember.UseVisualStyleBackColor = False
		'
		'ToolStrip1
		'
		Me.ToolStrip1.BackColor = System.Drawing.Color.SlateGray
		Me.ToolStrip1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.cboParish, Me.ToolStripSeparator1, Me.ToolStripLabel2, Me.cboBccunit, Me.ToolStripSeparator2, Me.ToolStripLabel3, Me.cboFamily})
		Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
		Me.ToolStrip1.Name = "ToolStrip1"
		Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
		Me.ToolStrip1.Size = New System.Drawing.Size(1133, 25)
		Me.ToolStrip1.TabIndex = 7
		Me.ToolStrip1.Text = "ToolStrip1"
		'
		'ToolStripLabel1
		'
		Me.ToolStripLabel1.Name = "ToolStripLabel1"
		Me.ToolStripLabel1.Size = New System.Drawing.Size(45, 22)
		Me.ToolStripLabel1.Text = "Parish"
		'
		'cboParish
		'
		Me.cboParish.Name = "cboParish"
		Me.cboParish.Size = New System.Drawing.Size(121, 25)
		'
		'ToolStripSeparator1
		'
		Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
		Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
		'
		'ToolStripLabel2
		'
		Me.ToolStripLabel2.Name = "ToolStripLabel2"
		Me.ToolStripLabel2.Size = New System.Drawing.Size(62, 22)
		Me.ToolStripLabel2.Text = "BCC Unit"
		'
		'cboBccunit
		'
		Me.cboBccunit.Name = "cboBccunit"
		Me.cboBccunit.Size = New System.Drawing.Size(121, 25)
		'
		'ToolStripSeparator2
		'
		Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
		Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
		'
		'ToolStripLabel3
		'
		Me.ToolStripLabel3.Name = "ToolStripLabel3"
		Me.ToolStripLabel3.Size = New System.Drawing.Size(47, 22)
		Me.ToolStripLabel3.Text = "Family"
		'
		'cboFamily
		'
		Me.cboFamily.Name = "cboFamily"
		Me.cboFamily.Size = New System.Drawing.Size(121, 25)
		'
		'LettersToolStripMenuItem
		'
		Me.LettersToolStripMenuItem.Name = "LettersToolStripMenuItem"
		Me.LettersToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
		Me.LettersToolStripMenuItem.Text = "Letters"
		'
		'CertificatesToolStripMenuItem
		'
		Me.CertificatesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BaptismToolStripMenuItem, Me.MarriageToolStripMenuItem})
		Me.CertificatesToolStripMenuItem.Name = "CertificatesToolStripMenuItem"
		Me.CertificatesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
		Me.CertificatesToolStripMenuItem.Text = "Certificates"
		'
		'BaptismToolStripMenuItem
		'
		Me.BaptismToolStripMenuItem.Name = "BaptismToolStripMenuItem"
		Me.BaptismToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
		Me.BaptismToolStripMenuItem.Text = "Baptism"
		'
		'MarriageToolStripMenuItem
		'
		Me.MarriageToolStripMenuItem.Name = "MarriageToolStripMenuItem"
		Me.MarriageToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
		Me.MarriageToolStripMenuItem.Text = "Marriage"
		'
		'frmLauncher
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1133, 668)
		Me.Controls.Add(Me.Panel1)
		Me.Controls.Add(Me.ToolStrip1)
		Me.Controls.Add(Me.StatusStrip1)
		Me.Controls.Add(Me.MenuStrip1)
		Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.IsMdiContainer = True
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.Name = "frmLauncher"
		Me.Text = "Parish Manager"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		Me.MenuStrip1.ResumeLayout(False)
		Me.MenuStrip1.PerformLayout()
		Me.StatusStrip1.ResumeLayout(False)
		Me.StatusStrip1.PerformLayout()
		Me.Panel1.ResumeLayout(False)
		Me.ToolStrip1.ResumeLayout(False)
		Me.ToolStrip1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuNewDiocese As ToolStripMenuItem
    Friend WithEvents mnuNewRegion As ToolStripMenuItem
    Friend WithEvents mnuNewForane As ToolStripMenuItem
    Friend WithEvents mnuNewParish As ToolStripMenuItem
    Friend WithEvents mnuNewSubstation As ToolStripMenuItem
    Friend WithEvents mnuNewBCCUnit As ToolStripMenuItem
    Friend WithEvents mnuNewFamily As ToolStripMenuItem
    Friend WithEvents mnuNewMember As ToolStripMenuItem
    Friend WithEvents mnuNewMinistry As ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSubregion As Button
    Friend WithEvents btnForane As Button
    Friend WithEvents btnParish As Button
    Friend WithEvents btnBccunit As Button
    Friend WithEvents btnFamily As Button
    Friend WithEvents btnFamilyMember As Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents cboParish As ToolStripComboBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents cboBccunit As ToolStripComboBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents cboFamily As ToolStripComboBox
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents lblStatus As ToolStripStatusLabel
    Friend WithEvents mnuNewUser As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents lblUser As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents lblLogin As ToolStripStatusLabel
    Friend WithEvents LoginHistoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Friend WithEvents lblRoleid As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As ToolStripStatusLabel
    Friend WithEvents lblSessionToken As ToolStripStatusLabel
    Friend WithEvents FinanceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FamilyFinanceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblDiocese As ToolStripStatusLabel
    Friend WithEvents lblSubRegion As ToolStripStatusLabel
    Friend WithEvents lblForane As ToolStripStatusLabel
    Friend WithEvents lblParish As ToolStripStatusLabel
	Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents LettersToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents CertificatesToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents BaptismToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents MarriageToolStripMenuItem As ToolStripMenuItem
End Class
