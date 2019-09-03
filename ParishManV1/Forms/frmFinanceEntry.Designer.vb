<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFinanceEntry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFinanceEntry))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.dgvFamilies = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblDue = New System.Windows.Forms.Label()
        Me.txtSubscriptionNo = New System.Windows.Forms.TextBox()
        Me.txtMonthlyVari = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtHousename = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtSep = New System.Windows.Forms.TextBox()
        Me.txtOct = New System.Windows.Forms.TextBox()
        Me.txtDec = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtNov = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtAug = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtJul = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtJun = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtMay = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtApr = New System.Windows.Forms.TextBox()
        Me.txtFeb = New System.Windows.Forms.TextBox()
        Me.txtMar = New System.Windows.Forms.TextBox()
        Me.txtJan = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtOthers = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtDonationDiocese = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtDonationForane = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtDonationSeminary = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtFeastVari = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtChristmasCarol = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtChristmasAuction = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtMissionSunday = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtReceiptNo = New System.Windows.Forms.TextBox()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboPaymentTemplate = New System.Windows.Forms.ComboBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtOpeningBalance = New System.Windows.Forms.TextBox()
        CType(Me.dgvFamilies, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search"
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtSearch.Location = New System.Drawing.Point(67, 5)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(377, 22)
        Me.txtSearch.TabIndex = 5
        '
        'dgvFamilies
        '
        Me.dgvFamilies.AllowUserToAddRows = False
        Me.dgvFamilies.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvFamilies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvFamilies.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvFamilies.Location = New System.Drawing.Point(12, 34)
        Me.dgvFamilies.MultiSelect = False
        Me.dgvFamilies.Name = "dgvFamilies"
        Me.dgvFamilies.ReadOnly = True
        Me.dgvFamilies.RowHeadersVisible = False
        Me.dgvFamilies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFamilies.Size = New System.Drawing.Size(456, 203)
        Me.dgvFamilies.TabIndex = 23
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.lblDue)
        Me.GroupBox1.Controls.Add(Me.txtSubscriptionNo)
        Me.GroupBox1.Controls.Add(Me.txtOpeningBalance)
        Me.GroupBox1.Controls.Add(Me.txtMonthlyVari)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label31)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtHousename)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 238)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(456, 92)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'lblDue
        '
        Me.lblDue.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblDue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblDue.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDue.Location = New System.Drawing.Point(284, 64)
        Me.lblDue.Name = "lblDue"
        Me.lblDue.Size = New System.Drawing.Size(82, 21)
        Me.lblDue.TabIndex = 5
        Me.lblDue.Text = "0"
        '
        'txtSubscriptionNo
        '
        Me.txtSubscriptionNo.Enabled = False
        Me.txtSubscriptionNo.Location = New System.Drawing.Point(119, 39)
        Me.txtSubscriptionNo.Name = "txtSubscriptionNo"
        Me.txtSubscriptionNo.Size = New System.Drawing.Size(82, 22)
        Me.txtSubscriptionNo.TabIndex = 4
        Me.txtSubscriptionNo.TabStop = False
        '
        'txtMonthlyVari
        '
        Me.txtMonthlyVari.Enabled = False
        Me.txtMonthlyVari.Location = New System.Drawing.Point(285, 39)
        Me.txtMonthlyVari.Name = "txtMonthlyVari"
        Me.txtMonthlyVari.Size = New System.Drawing.Size(82, 22)
        Me.txtMonthlyVari.TabIndex = 4
        Me.txtMonthlyVari.TabStop = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 42)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(104, 16)
        Me.Label18.TabIndex = 3
        Me.Label18.Text = "Subscription No."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(203, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Monthly Vari"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(221, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Total Due"
        '
        'txtHousename
        '
        Me.txtHousename.Enabled = False
        Me.txtHousename.Location = New System.Drawing.Point(119, 15)
        Me.txtHousename.Name = "txtHousename"
        Me.txtHousename.Size = New System.Drawing.Size(248, 22)
        Me.txtHousename.TabIndex = 1
        Me.txtHousename.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "House Name"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Controls.Add(Me.Label30)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.txtSep)
        Me.GroupBox2.Controls.Add(Me.txtOct)
        Me.GroupBox2.Controls.Add(Me.txtDec)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.txtNov)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.txtAug)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.txtJul)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.txtJun)
        Me.GroupBox2.Controls.Add(Me.Label29)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.txtMay)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.txtApr)
        Me.GroupBox2.Controls.Add(Me.txtFeb)
        Me.GroupBox2.Controls.Add(Me.txtMar)
        Me.GroupBox2.Controls.Add(Me.txtJan)
        Me.GroupBox2.Location = New System.Drawing.Point(474, 49)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(148, 253)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(12, 173)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(71, 16)
        Me.Label27.TabIndex = 1
        Me.Label27.Text = "September"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(29, 193)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(54, 16)
        Me.Label28.TabIndex = 1
        Me.Label28.Text = "October"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(16, 233)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(67, 16)
        Me.Label30.TabIndex = 1
        Me.Label30.Text = "December"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(18, 213)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(65, 16)
        Me.Label26.TabIndex = 1
        Me.Label26.Text = "November"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(34, 153)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(49, 16)
        Me.Label25.TabIndex = 1
        Me.Label25.Text = "August"
        '
        'txtSep
        '
        Me.txtSep.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSep.Location = New System.Drawing.Point(89, 171)
        Me.txtSep.Name = "txtSep"
        Me.txtSep.Size = New System.Drawing.Size(50, 20)
        Me.txtSep.TabIndex = 1
        '
        'txtOct
        '
        Me.txtOct.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOct.Location = New System.Drawing.Point(89, 191)
        Me.txtOct.Name = "txtOct"
        Me.txtOct.Size = New System.Drawing.Size(50, 20)
        Me.txtOct.TabIndex = 1
        '
        'txtDec
        '
        Me.txtDec.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDec.Location = New System.Drawing.Point(89, 231)
        Me.txtDec.Name = "txtDec"
        Me.txtDec.Size = New System.Drawing.Size(50, 20)
        Me.txtDec.TabIndex = 1
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(52, 133)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(31, 16)
        Me.Label24.TabIndex = 1
        Me.Label24.Text = "July"
        '
        'txtNov
        '
        Me.txtNov.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNov.Location = New System.Drawing.Point(89, 211)
        Me.txtNov.Name = "txtNov"
        Me.txtNov.Size = New System.Drawing.Size(50, 20)
        Me.txtNov.TabIndex = 1
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(48, 113)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(35, 16)
        Me.Label23.TabIndex = 1
        Me.Label23.Text = "June"
        '
        'txtAug
        '
        Me.txtAug.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAug.Location = New System.Drawing.Point(89, 151)
        Me.txtAug.Name = "txtAug"
        Me.txtAug.Size = New System.Drawing.Size(50, 20)
        Me.txtAug.TabIndex = 1
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(50, 93)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(33, 16)
        Me.Label22.TabIndex = 1
        Me.Label22.Text = "May"
        '
        'txtJul
        '
        Me.txtJul.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJul.Location = New System.Drawing.Point(89, 131)
        Me.txtJul.Name = "txtJul"
        Me.txtJul.Size = New System.Drawing.Size(50, 20)
        Me.txtJul.TabIndex = 1
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(49, 73)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(34, 16)
        Me.Label21.TabIndex = 1
        Me.Label21.Text = "April"
        '
        'txtJun
        '
        Me.txtJun.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJun.Location = New System.Drawing.Point(89, 111)
        Me.txtJun.Name = "txtJun"
        Me.txtJun.Size = New System.Drawing.Size(50, 20)
        Me.txtJun.TabIndex = 1
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(24, 33)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(59, 16)
        Me.Label29.TabIndex = 1
        Me.Label29.Text = "February"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(39, 53)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(44, 16)
        Me.Label20.TabIndex = 1
        Me.Label20.Text = "March"
        '
        'txtMay
        '
        Me.txtMay.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMay.Location = New System.Drawing.Point(89, 91)
        Me.txtMay.Name = "txtMay"
        Me.txtMay.Size = New System.Drawing.Size(50, 20)
        Me.txtMay.TabIndex = 1
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(30, 13)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(53, 16)
        Me.Label19.TabIndex = 1
        Me.Label19.Text = "January"
        '
        'txtApr
        '
        Me.txtApr.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApr.Location = New System.Drawing.Point(89, 71)
        Me.txtApr.Name = "txtApr"
        Me.txtApr.Size = New System.Drawing.Size(50, 20)
        Me.txtApr.TabIndex = 1
        '
        'txtFeb
        '
        Me.txtFeb.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFeb.Location = New System.Drawing.Point(89, 31)
        Me.txtFeb.Name = "txtFeb"
        Me.txtFeb.Size = New System.Drawing.Size(50, 20)
        Me.txtFeb.TabIndex = 1
        '
        'txtMar
        '
        Me.txtMar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMar.Location = New System.Drawing.Point(89, 51)
        Me.txtMar.Name = "txtMar"
        Me.txtMar.Size = New System.Drawing.Size(50, 20)
        Me.txtMar.TabIndex = 1
        '
        'txtJan
        '
        Me.txtJan.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJan.Location = New System.Drawing.Point(89, 11)
        Me.txtJan.Name = "txtJan"
        Me.txtJan.Size = New System.Drawing.Size(50, 20)
        Me.txtJan.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.lblTotal)
        Me.GroupBox3.Controls.Add(Me.txtOthers)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.txtDonationDiocese)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.txtDonationForane)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.txtDonationSeminary)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.txtFeastVari)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.txtChristmasCarol)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txtChristmasAuction)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txtMissionSunday)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Location = New System.Drawing.Point(633, 33)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(205, 269)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTotal.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(70, 238)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(119, 21)
        Me.lblTotal.TabIndex = 17
        Me.lblTotal.Text = "0"
        '
        'txtOthers
        '
        Me.txtOthers.Location = New System.Drawing.Point(145, 163)
        Me.txtOthers.Name = "txtOthers"
        Me.txtOthers.Size = New System.Drawing.Size(43, 22)
        Me.txtOthers.TabIndex = 8
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(25, 241)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(39, 16)
        Me.Label16.TabIndex = 14
        Me.Label16.Text = "Total"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(92, 166)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(47, 16)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Others"
        '
        'txtDonationDiocese
        '
        Me.txtDonationDiocese.Location = New System.Drawing.Point(145, 141)
        Me.txtDonationDiocese.Name = "txtDonationDiocese"
        Me.txtDonationDiocese.Size = New System.Drawing.Size(43, 22)
        Me.txtDonationDiocese.TabIndex = 7
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(14, 144)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(125, 16)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Donation to Diocese"
        '
        'txtDonationForane
        '
        Me.txtDonationForane.Location = New System.Drawing.Point(145, 119)
        Me.txtDonationForane.Name = "txtDonationForane"
        Me.txtDonationForane.Size = New System.Drawing.Size(43, 22)
        Me.txtDonationForane.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(21, 122)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(118, 16)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Donation to Forane"
        '
        'txtDonationSeminary
        '
        Me.txtDonationSeminary.Location = New System.Drawing.Point(145, 97)
        Me.txtDonationSeminary.Name = "txtDonationSeminary"
        Me.txtDonationSeminary.Size = New System.Drawing.Size(43, 22)
        Me.txtDonationSeminary.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 100)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(133, 16)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Donation to Seminary"
        '
        'txtFeastVari
        '
        Me.txtFeastVari.Location = New System.Drawing.Point(145, 75)
        Me.txtFeastVari.Name = "txtFeastVari"
        Me.txtFeastVari.Size = New System.Drawing.Size(43, 22)
        Me.txtFeastVari.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(72, 78)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 16)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Feast Vari"
        '
        'txtChristmasCarol
        '
        Me.txtChristmasCarol.Location = New System.Drawing.Point(145, 53)
        Me.txtChristmasCarol.Name = "txtChristmasCarol"
        Me.txtChristmasCarol.Size = New System.Drawing.Size(43, 22)
        Me.txtChristmasCarol.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(38, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 16)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Christmas Carol"
        '
        'txtChristmasAuction
        '
        Me.txtChristmasAuction.Location = New System.Drawing.Point(145, 31)
        Me.txtChristmasAuction.Name = "txtChristmasAuction"
        Me.txtChristmasAuction.Size = New System.Drawing.Size(43, 22)
        Me.txtChristmasAuction.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 16)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Christmas Auction"
        '
        'txtMissionSunday
        '
        Me.txtMissionSunday.Location = New System.Drawing.Point(145, 9)
        Me.txtMissionSunday.Name = "txtMissionSunday"
        Me.txtMissionSunday.Size = New System.Drawing.Size(43, 22)
        Me.txtMissionSunday.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(38, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Mission Sunday"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label17.Location = New System.Drawing.Point(-9, 215)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(281, 16)
        Me.Label17.TabIndex = 18
        Me.Label17.Text = "_______________________________________"
        '
        'dtpDate
        '
        Me.dtpDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpDate.CustomFormat = "dd/mm/yyyy"
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(722, 5)
        Me.dtpDate.MaxDate = New Date(2508, 12, 31, 0, 0, 0, 0)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(100, 22)
        Me.dtpDate.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(687, 8)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(35, 16)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Date"
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Location = New System.Drawing.Point(678, 311)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Location = New System.Drawing.Point(761, 311)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(533, 8)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 16)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Receipt No"
        '
        'txtReceiptNo
        '
        Me.txtReceiptNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtReceiptNo.Location = New System.Drawing.Point(605, 5)
        Me.txtReceiptNo.MaxLength = 4
        Me.txtReceiptNo.Name = "txtReceiptNo"
        Me.txtReceiptNo.Size = New System.Drawing.Size(82, 22)
        Me.txtReceiptNo.TabIndex = 0
        '
        'btnNew
        '
        Me.btnNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNew.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNew.Location = New System.Drawing.Point(595, 311)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 23)
        Me.btnNew.TabIndex = 3
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'txtYear
        '
        Me.txtYear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtYear.Location = New System.Drawing.Point(484, 5)
        Me.txtYear.MaxLength = 4
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(49, 22)
        Me.txtYear.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(450, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Year"
        '
        'cboPaymentTemplate
        '
        Me.cboPaymentTemplate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboPaymentTemplate.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboPaymentTemplate.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboPaymentTemplate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPaymentTemplate.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPaymentTemplate.FormattingEnabled = True
        Me.cboPaymentTemplate.Items.AddRange(New Object() {"None", "Full  Year", "1st  Half Year", "2nd Half Year", "3   Months till date for current year", "All Months till date for current year"})
        Me.cboPaymentTemplate.Location = New System.Drawing.Point(474, 30)
        Me.cboPaymentTemplate.Name = "cboPaymentTemplate"
        Me.cboPaymentTemplate.Size = New System.Drawing.Size(148, 22)
        Me.cboPaymentTemplate.TabIndex = 24
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(27, 66)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(83, 16)
        Me.Label31.TabIndex = 3
        Me.Label31.Text = "Opening Bal."
        '
        'txtOpeningBalance
        '
        Me.txtOpeningBalance.Enabled = False
        Me.txtOpeningBalance.Location = New System.Drawing.Point(119, 63)
        Me.txtOpeningBalance.Name = "txtOpeningBalance"
        Me.txtOpeningBalance.Size = New System.Drawing.Size(82, 22)
        Me.txtOpeningBalance.TabIndex = 4
        Me.txtOpeningBalance.TabStop = False
        '
        'frmFinanceEntry
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(845, 340)
        Me.Controls.Add(Me.cboPaymentTemplate)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.txtReceiptNo)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.dgvFamilies)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label14)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MinimumSize = New System.Drawing.Size(778, 378)
        Me.Name = "frmFinanceEntry"
        Me.Text = "Finance Entry"
        CType(Me.dgvFamilies, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents dgvFamilies As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtHousename As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblDue As Label
    Friend WithEvents txtMonthlyVari As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtMissionSunday As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtFeastVari As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtChristmasCarol As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtChristmasAuction As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDonationSeminary As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtOthers As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtDonationDiocese As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtDonationForane As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents Label14 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txtReceiptNo As TextBox
    Friend WithEvents txtSubscriptionNo As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents btnNew As Button
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents txtSep As TextBox
    Friend WithEvents txtOct As TextBox
    Friend WithEvents txtDec As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txtNov As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txtAug As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txtJul As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtJun As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents txtMay As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtApr As TextBox
    Friend WithEvents txtFeb As TextBox
    Friend WithEvents txtMar As TextBox
    Friend WithEvents txtJan As TextBox
    Friend WithEvents txtYear As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cboPaymentTemplate As ComboBox
    Friend WithEvents txtOpeningBalance As TextBox
    Friend WithEvents Label31 As Label
End Class
