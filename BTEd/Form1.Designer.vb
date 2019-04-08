<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFolder = New System.Windows.Forms.TextBox()
        Me.lstChars = New System.Windows.Forms.ListBox()
        Me.chkDead = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkNuts = New System.Windows.Forms.CheckBox()
        Me.chkPossessed = New System.Windows.Forms.CheckBox()
        Me.chkParalized = New System.Windows.Forms.CheckBox()
        Me.chkStoned = New System.Windows.Forms.CheckBox()
        Me.chkPoisoned = New System.Windows.Forms.CheckBox()
        Me.chkOld = New System.Windows.Forms.CheckBox()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboRace = New System.Windows.Forms.ComboBox()
        Me.cboClass = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.nudCStrength = New System.Windows.Forms.NumericUpDown()
        Me.nudMStrength = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.nudMIQ = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.nudCIQ = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.nudMDEX = New System.Windows.Forms.NumericUpDown()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.nudCDEX = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.nudMCONST = New System.Windows.Forms.NumericUpDown()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.nudCCONST = New System.Windows.Forms.NumericUpDown()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.nudMLUCK = New System.Windows.Forms.NumericUpDown()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.nudCLUCK = New System.Windows.Forms.NumericUpDown()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.nudMHP = New System.Windows.Forms.NumericUpDown()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.nudCHP = New System.Windows.Forms.NumericUpDown()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.nudMSP = New System.Windows.Forms.NumericUpDown()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.nudCSP = New System.Windows.Forms.NumericUpDown()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.nudExp = New System.Windows.Forms.NumericUpDown()
        Me.nudGold = New System.Windows.Forms.NumericUpDown()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.nudLevel = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.nudWizd = New System.Windows.Forms.NumericUpDown()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.nudSorc = New System.Windows.Forms.NumericUpDown()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.nudMagi = New System.Windows.Forms.NumericUpDown()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.nudConj = New System.Windows.Forms.NumericUpDown()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.nudBardSongsRmd = New System.Windows.Forms.NumericUpDown()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnHeal = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnHealAll = New System.Windows.Forms.Button()
        Me.btnDelItem = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.dgvCB = New System.Windows.Forms.DataGridView()
        Me.btnGetItem = New System.Windows.Forms.Button()
        Me.colIdx = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEquip = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAvl = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colItemNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUnID = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colStat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDmg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colItmType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn3 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown3 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown4 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown5 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown6 = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox1.SuspendLayout()
        CType(Me.nudCStrength, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMStrength, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMIQ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCIQ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMDEX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCDEX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMCONST, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCCONST, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMLUCK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCLUCK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMHP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCHP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMSP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCSP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudExp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudGold, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudLevel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.nudWizd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSorc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMagi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudConj, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudBardSongsRmd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dgvCB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(587, 19)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 0
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Bard's Tale Folder"
        '
        'txtFolder
        '
        Me.txtFolder.Location = New System.Drawing.Point(119, 21)
        Me.txtFolder.Name = "txtFolder"
        Me.txtFolder.Size = New System.Drawing.Size(462, 20)
        Me.txtFolder.TabIndex = 2
        Me.txtFolder.Text = "C:\Temp\BT HACK"
        '
        'lstChars
        '
        Me.lstChars.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstChars.FormattingEnabled = True
        Me.lstChars.Location = New System.Drawing.Point(12, 73)
        Me.lstChars.Name = "lstChars"
        Me.lstChars.Size = New System.Drawing.Size(92, 485)
        Me.lstChars.TabIndex = 3
        '
        'chkDead
        '
        Me.chkDead.AutoSize = True
        Me.chkDead.Location = New System.Drawing.Point(13, 19)
        Me.chkDead.Name = "chkDead"
        Me.chkDead.Size = New System.Drawing.Size(52, 17)
        Me.chkDead.TabIndex = 4
        Me.chkDead.Text = "Dead"
        Me.chkDead.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(0, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Name"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(34, 54)
        Me.txtName.MaxLength = 14
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(120, 22)
        Me.txtName.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkNuts)
        Me.GroupBox1.Controls.Add(Me.chkPossessed)
        Me.GroupBox1.Controls.Add(Me.chkParalized)
        Me.GroupBox1.Controls.Add(Me.chkStoned)
        Me.GroupBox1.Controls.Add(Me.chkPoisoned)
        Me.GroupBox1.Controls.Add(Me.chkOld)
        Me.GroupBox1.Controls.Add(Me.chkDead)
        Me.GroupBox1.Location = New System.Drawing.Point(49, 129)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(95, 140)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Status"
        '
        'chkNuts
        '
        Me.chkNuts.AutoSize = True
        Me.chkNuts.Location = New System.Drawing.Point(13, 115)
        Me.chkNuts.Name = "chkNuts"
        Me.chkNuts.Size = New System.Drawing.Size(48, 17)
        Me.chkNuts.TabIndex = 10
        Me.chkNuts.Text = "Nuts"
        Me.chkNuts.UseVisualStyleBackColor = True
        '
        'chkPossessed
        '
        Me.chkPossessed.AutoSize = True
        Me.chkPossessed.Location = New System.Drawing.Point(13, 98)
        Me.chkPossessed.Name = "chkPossessed"
        Me.chkPossessed.Size = New System.Drawing.Size(77, 17)
        Me.chkPossessed.TabIndex = 9
        Me.chkPossessed.Text = "Possessed"
        Me.chkPossessed.UseVisualStyleBackColor = True
        '
        'chkParalized
        '
        Me.chkParalized.AutoSize = True
        Me.chkParalized.Location = New System.Drawing.Point(13, 83)
        Me.chkParalized.Name = "chkParalized"
        Me.chkParalized.Size = New System.Drawing.Size(69, 17)
        Me.chkParalized.TabIndex = 8
        Me.chkParalized.Text = "Paralized"
        Me.chkParalized.UseVisualStyleBackColor = True
        '
        'chkStoned
        '
        Me.chkStoned.AutoSize = True
        Me.chkStoned.Location = New System.Drawing.Point(13, 67)
        Me.chkStoned.Name = "chkStoned"
        Me.chkStoned.Size = New System.Drawing.Size(60, 17)
        Me.chkStoned.TabIndex = 7
        Me.chkStoned.Text = "Stoned"
        Me.chkStoned.UseVisualStyleBackColor = True
        '
        'chkPoisoned
        '
        Me.chkPoisoned.AutoSize = True
        Me.chkPoisoned.Location = New System.Drawing.Point(13, 51)
        Me.chkPoisoned.Name = "chkPoisoned"
        Me.chkPoisoned.Size = New System.Drawing.Size(70, 17)
        Me.chkPoisoned.TabIndex = 6
        Me.chkPoisoned.Text = "Poisoned"
        Me.chkPoisoned.UseVisualStyleBackColor = True
        '
        'chkOld
        '
        Me.chkOld.AutoSize = True
        Me.chkOld.Location = New System.Drawing.Point(13, 35)
        Me.chkOld.Name = "chkOld"
        Me.chkOld.Size = New System.Drawing.Size(42, 17)
        Me.chkOld.TabIndex = 5
        Me.chkOld.Text = "Old"
        Me.chkOld.UseVisualStyleBackColor = True
        '
        'txtFileName
        '
        Me.txtFileName.Location = New System.Drawing.Point(129, 435)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.ReadOnly = True
        Me.txtFileName.Size = New System.Drawing.Size(462, 20)
        Me.txtFileName.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 438)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Filename"
        '
        'cboRace
        '
        Me.cboRace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRace.FormattingEnabled = True
        Me.cboRace.Location = New System.Drawing.Point(55, 80)
        Me.cboRace.Name = "cboRace"
        Me.cboRace.Size = New System.Drawing.Size(89, 21)
        Me.cboRace.TabIndex = 10
        '
        'cboClass
        '
        Me.cboClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboClass.FormattingEnabled = True
        Me.cboClass.Location = New System.Drawing.Point(55, 102)
        Me.cboClass.Name = "cboClass"
        Me.cboClass.Size = New System.Drawing.Size(89, 21)
        Me.cboClass.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 290)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Strength"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Race"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Class"
        '
        'nudCStrength
        '
        Me.nudCStrength.Location = New System.Drawing.Point(64, 286)
        Me.nudCStrength.Name = "nudCStrength"
        Me.nudCStrength.Size = New System.Drawing.Size(47, 20)
        Me.nudCStrength.TabIndex = 14
        '
        'nudMStrength
        '
        Me.nudMStrength.Location = New System.Drawing.Point(129, 286)
        Me.nudMStrength.Name = "nudMStrength"
        Me.nudMStrength.Size = New System.Drawing.Size(47, 20)
        Me.nudMStrength.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(111, 290)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "of"
        '
        'nudMIQ
        '
        Me.nudMIQ.Location = New System.Drawing.Point(129, 311)
        Me.nudMIQ.Name = "nudMIQ"
        Me.nudMIQ.Size = New System.Drawing.Size(47, 20)
        Me.nudMIQ.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(111, 316)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(16, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "of"
        '
        'nudCIQ
        '
        Me.nudCIQ.Location = New System.Drawing.Point(64, 312)
        Me.nudCIQ.Name = "nudCIQ"
        Me.nudCIQ.Size = New System.Drawing.Size(47, 20)
        Me.nudCIQ.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 316)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(18, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "IQ"
        '
        'nudMDEX
        '
        Me.nudMDEX.Location = New System.Drawing.Point(129, 337)
        Me.nudMDEX.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.nudMDEX.Name = "nudMDEX"
        Me.nudMDEX.Size = New System.Drawing.Size(47, 20)
        Me.nudMDEX.TabIndex = 24
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(111, 342)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(16, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "of"
        '
        'nudCDEX
        '
        Me.nudCDEX.Location = New System.Drawing.Point(64, 338)
        Me.nudCDEX.Name = "nudCDEX"
        Me.nudCDEX.Size = New System.Drawing.Size(47, 20)
        Me.nudCDEX.TabIndex = 22
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(17, 342)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Dexterity"
        '
        'nudMCONST
        '
        Me.nudMCONST.Location = New System.Drawing.Point(129, 362)
        Me.nudMCONST.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.nudMCONST.Name = "nudMCONST"
        Me.nudMCONST.Size = New System.Drawing.Size(47, 20)
        Me.nudMCONST.TabIndex = 28
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(111, 367)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(16, 13)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "of"
        '
        'nudCCONST
        '
        Me.nudCCONST.Location = New System.Drawing.Point(64, 363)
        Me.nudCCONST.Name = "nudCCONST"
        Me.nudCCONST.Size = New System.Drawing.Size(47, 20)
        Me.nudCCONST.TabIndex = 26
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(17, 367)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(34, 13)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Const"
        '
        'nudMLUCK
        '
        Me.nudMLUCK.Location = New System.Drawing.Point(129, 388)
        Me.nudMLUCK.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.nudMLUCK.Name = "nudMLUCK"
        Me.nudMLUCK.Size = New System.Drawing.Size(47, 20)
        Me.nudMLUCK.TabIndex = 32
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(111, 393)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(16, 13)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "of"
        '
        'nudCLUCK
        '
        Me.nudCLUCK.Location = New System.Drawing.Point(64, 389)
        Me.nudCLUCK.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.nudCLUCK.Name = "nudCLUCK"
        Me.nudCLUCK.Size = New System.Drawing.Size(47, 20)
        Me.nudCLUCK.TabIndex = 30
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(17, 393)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(31, 13)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "Luck"
        '
        'nudMHP
        '
        Me.nudMHP.Location = New System.Drawing.Point(304, 283)
        Me.nudMHP.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.nudMHP.Name = "nudMHP"
        Me.nudMHP.Size = New System.Drawing.Size(47, 20)
        Me.nudMHP.TabIndex = 36
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(286, 288)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(16, 13)
        Me.Label16.TabIndex = 35
        Me.Label16.Text = "of"
        '
        'nudCHP
        '
        Me.nudCHP.Location = New System.Drawing.Point(239, 284)
        Me.nudCHP.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.nudCHP.Name = "nudCHP"
        Me.nudCHP.Size = New System.Drawing.Size(47, 20)
        Me.nudCHP.TabIndex = 34
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(192, 288)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(44, 13)
        Me.Label17.TabIndex = 33
        Me.Label17.Text = "Hit Pnts"
        '
        'nudMSP
        '
        Me.nudMSP.Location = New System.Drawing.Point(484, 281)
        Me.nudMSP.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.nudMSP.Name = "nudMSP"
        Me.nudMSP.Size = New System.Drawing.Size(47, 20)
        Me.nudMSP.TabIndex = 40
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(466, 286)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(16, 13)
        Me.Label18.TabIndex = 39
        Me.Label18.Text = "of"
        '
        'nudCSP
        '
        Me.nudCSP.Location = New System.Drawing.Point(419, 282)
        Me.nudCSP.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.nudCSP.Name = "nudCSP"
        Me.nudCSP.Size = New System.Drawing.Size(47, 20)
        Me.nudCSP.TabIndex = 38
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(370, 286)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(46, 13)
        Me.Label19.TabIndex = 37
        Me.Label19.Text = "Spl Pnts"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(208, 312)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(25, 13)
        Me.Label20.TabIndex = 41
        Me.Label20.Text = "Exp"
        '
        'nudExp
        '
        Me.nudExp.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.nudExp.Location = New System.Drawing.Point(239, 309)
        Me.nudExp.Maximum = New Decimal(New Integer() {16777215, 0, 0, 0})
        Me.nudExp.Name = "nudExp"
        Me.nudExp.Size = New System.Drawing.Size(83, 20)
        Me.nudExp.TabIndex = 42
        '
        'nudGold
        '
        Me.nudGold.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.nudGold.Location = New System.Drawing.Point(239, 359)
        Me.nudGold.Maximum = New Decimal(New Integer() {16777215, 0, 0, 0})
        Me.nudGold.Name = "nudGold"
        Me.nudGold.Size = New System.Drawing.Size(83, 20)
        Me.nudGold.TabIndex = 44
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(208, 362)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(29, 13)
        Me.Label21.TabIndex = 43
        Me.Label21.Text = "Gold"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(204, 338)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(33, 13)
        Me.Label22.TabIndex = 45
        Me.Label22.Text = "Level"
        '
        'nudLevel
        '
        Me.nudLevel.Location = New System.Drawing.Point(239, 335)
        Me.nudLevel.Name = "nudLevel"
        Me.nudLevel.Size = New System.Drawing.Size(47, 20)
        Me.nudLevel.TabIndex = 46
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.nudWizd)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.nudSorc)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.nudMagi)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.nudConj)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Location = New System.Drawing.Point(367, 312)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(180, 76)
        Me.GroupBox2.TabIndex = 49
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Spell Level"
        '
        'nudWizd
        '
        Me.nudWizd.Location = New System.Drawing.Point(126, 46)
        Me.nudWizd.Name = "nudWizd"
        Me.nudWizd.Size = New System.Drawing.Size(47, 20)
        Me.nudWizd.TabIndex = 56
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(91, 49)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(34, 13)
        Me.Label26.TabIndex = 55
        Me.Label26.Text = "Wizd."
        '
        'nudSorc
        '
        Me.nudSorc.Location = New System.Drawing.Point(126, 19)
        Me.nudSorc.Name = "nudSorc"
        Me.nudSorc.Size = New System.Drawing.Size(47, 20)
        Me.nudSorc.TabIndex = 54
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(91, 22)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(32, 13)
        Me.Label25.TabIndex = 53
        Me.Label25.Text = "Sorc."
        '
        'nudMagi
        '
        Me.nudMagi.Location = New System.Drawing.Point(39, 45)
        Me.nudMagi.Name = "nudMagi"
        Me.nudMagi.Size = New System.Drawing.Size(47, 20)
        Me.nudMagi.TabIndex = 52
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(4, 48)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(33, 13)
        Me.Label24.TabIndex = 51
        Me.Label24.Text = "Magi."
        '
        'nudConj
        '
        Me.nudConj.Location = New System.Drawing.Point(39, 19)
        Me.nudConj.Name = "nudConj"
        Me.nudConj.Size = New System.Drawing.Size(47, 20)
        Me.nudConj.TabIndex = 50
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(4, 22)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(31, 13)
        Me.Label23.TabIndex = 49
        Me.Label23.Text = "Conj."
        '
        'nudBardSongsRmd
        '
        Me.nudBardSongsRmd.Location = New System.Drawing.Point(498, 395)
        Me.nudBardSongsRmd.Name = "nudBardSongsRmd"
        Me.nudBardSongsRmd.Size = New System.Drawing.Size(47, 20)
        Me.nudBardSongsRmd.TabIndex = 54
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(377, 397)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(115, 13)
        Me.Label27.TabIndex = 53
        Me.Label27.Text = "Bard Songs Remaining"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnSave)
        Me.GroupBox3.Controls.Add(Me.btnAddItem)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.btnHeal)
        Me.GroupBox3.Controls.Add(Me.cboRace)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtName)
        Me.GroupBox3.Controls.Add(Me.cboClass)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.NumericUpDown6)
        Me.GroupBox3.Controls.Add(Me.nudCIQ)
        Me.GroupBox3.Controls.Add(Me.GroupBox1)
        Me.GroupBox3.Controls.Add(Me.NumericUpDown5)
        Me.GroupBox3.Controls.Add(Me.nudMStrength)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.NumericUpDown4)
        Me.GroupBox3.Controls.Add(Me.nudCStrength)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.NumericUpDown3)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.nudMIQ)
        Me.GroupBox3.Controls.Add(Me.NumericUpDown2)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.nudCDEX)
        Me.GroupBox3.Controls.Add(Me.nudBardSongsRmd)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label27)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox3.Controls.Add(Me.nudMDEX)
        Me.GroupBox3.Controls.Add(Me.nudCCONST)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.GroupBox2)
        Me.GroupBox3.Controls.Add(Me.nudLevel)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.nudMCONST)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.nudCLUCK)
        Me.GroupBox3.Controls.Add(Me.nudGold)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtFileName)
        Me.GroupBox3.Controls.Add(Me.nudMLUCK)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.nudCHP)
        Me.GroupBox3.Controls.Add(Me.nudExp)
        Me.GroupBox3.Controls.Add(Me.nudMHP)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.nudCSP)
        Me.GroupBox3.Controls.Add(Me.nudMSP)
        Me.GroupBox3.Location = New System.Drawing.Point(110, 48)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(691, 512)
        Me.GroupBox3.TabIndex = 55
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Character"
        '
        'btnHeal
        '
        Me.btnHeal.Location = New System.Drawing.Point(21, 19)
        Me.btnHeal.Name = "btnHeal"
        Me.btnHeal.Size = New System.Drawing.Size(42, 23)
        Me.btnHeal.TabIndex = 56
        Me.btnHeal.Text = "Heal"
        Me.btnHeal.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DataGridView1)
        Me.GroupBox4.Location = New System.Drawing.Point(157, 44)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(526, 225)
        Me.GroupBox4.TabIndex = 11
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Items"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colIdx, Me.colEquip, Me.colItemName, Me.colAC, Me.colAvl, Me.colItemNum, Me.colUnID, Me.colStat, Me.colDmg, Me.colItmType})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 16)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(520, 206)
        Me.DataGridView1.TabIndex = 0
        '
        'btnAddItem
        '
        Me.btnAddItem.Location = New System.Drawing.Point(595, 15)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(83, 23)
        Me.btnAddItem.TabIndex = 57
        Me.btnAddItem.Text = "Add New Item"
        Me.btnAddItem.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(72, 19)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(42, 23)
        Me.btnSave.TabIndex = 58
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnHealAll
        '
        Me.btnHealAll.Location = New System.Drawing.Point(687, 18)
        Me.btnHealAll.Name = "btnHealAll"
        Me.btnHealAll.Size = New System.Drawing.Size(68, 23)
        Me.btnHealAll.TabIndex = 57
        Me.btnHealAll.Text = "Heal All"
        Me.btnHealAll.UseVisualStyleBackColor = True
        '
        'btnDelItem
        '
        Me.btnDelItem.BackgroundImage = CType(resources.GetObject("btnDelItem.BackgroundImage"), System.Drawing.Image)
        Me.btnDelItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDelItem.Location = New System.Drawing.Point(805, 147)
        Me.btnDelItem.Name = "btnDelItem"
        Me.btnDelItem.Size = New System.Drawing.Size(58, 66)
        Me.btnDelItem.TabIndex = 59
        Me.btnDelItem.Text = "Cut Select Item"
        Me.btnDelItem.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.dgvCB)
        Me.GroupBox5.Location = New System.Drawing.Point(868, 12)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(536, 548)
        Me.GroupBox5.TabIndex = 58
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Removed Item Clipboard"
        '
        'dgvCB
        '
        Me.dgvCB.AllowUserToAddRows = False
        Me.dgvCB.AllowUserToDeleteRows = False
        Me.dgvCB.AllowUserToResizeRows = False
        Me.dgvCB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCB.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewCheckBoxColumn2, Me.DataGridViewTextBoxColumn4, Me.DataGridViewCheckBoxColumn3, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.colType})
        Me.dgvCB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCB.Location = New System.Drawing.Point(3, 16)
        Me.dgvCB.Name = "dgvCB"
        Me.dgvCB.RowHeadersVisible = False
        Me.dgvCB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCB.Size = New System.Drawing.Size(530, 529)
        Me.dgvCB.TabIndex = 0
        '
        'btnGetItem
        '
        Me.btnGetItem.BackgroundImage = CType(resources.GetObject("btnGetItem.BackgroundImage"), System.Drawing.Image)
        Me.btnGetItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGetItem.Location = New System.Drawing.Point(803, 230)
        Me.btnGetItem.Name = "btnGetItem"
        Me.btnGetItem.Size = New System.Drawing.Size(63, 65)
        Me.btnGetItem.TabIndex = 60
        Me.btnGetItem.Text = "Paste Select Item"
        Me.btnGetItem.UseVisualStyleBackColor = True
        '
        'colIdx
        '
        Me.colIdx.HeaderText = "#"
        Me.colIdx.Name = "colIdx"
        Me.colIdx.Width = 34
        '
        'colEquip
        '
        Me.colEquip.HeaderText = "Eqp"
        Me.colEquip.Name = "colEquip"
        Me.colEquip.Width = 44
        '
        'colItemName
        '
        Me.colItemName.HeaderText = "Item"
        Me.colItemName.Name = "colItemName"
        Me.colItemName.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colItemName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colAC
        '
        Me.colAC.HeaderText = "AC"
        Me.colAC.Name = "colAC"
        Me.colAC.ReadOnly = True
        Me.colAC.Width = 26
        '
        'colAvl
        '
        Me.colAvl.HeaderText = "Avl"
        Me.colAvl.Name = "colAvl"
        Me.colAvl.ReadOnly = True
        Me.colAvl.Width = 44
        '
        'colItemNum
        '
        Me.colItemNum.HeaderText = "Item#"
        Me.colItemNum.Name = "colItemNum"
        Me.colItemNum.ReadOnly = True
        Me.colItemNum.Width = 44
        '
        'colUnID
        '
        Me.colUnID.HeaderText = "UnID"
        Me.colUnID.Name = "colUnID"
        Me.colUnID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colUnID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colUnID.Width = 44
        '
        'colStat
        '
        Me.colStat.HeaderText = "Status"
        Me.colStat.Name = "colStat"
        Me.colStat.ReadOnly = True
        Me.colStat.Width = 66
        '
        'colDmg
        '
        Me.colDmg.HeaderText = "Dmg"
        Me.colDmg.Name = "colDmg"
        Me.colDmg.ReadOnly = True
        Me.colDmg.Width = 44
        '
        'colItmType
        '
        Me.colItmType.HeaderText = "Type"
        Me.colItmType.Name = "colItmType"
        Me.colItmType.ReadOnly = True
        Me.colItmType.Width = 55
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "#"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 34
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Eqp"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Width = 44
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Item"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "AC"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 26
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.HeaderText = "Avl"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.ReadOnly = True
        Me.DataGridViewCheckBoxColumn2.Width = 44
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Item#"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 44
        '
        'DataGridViewCheckBoxColumn3
        '
        Me.DataGridViewCheckBoxColumn3.HeaderText = "UnID"
        Me.DataGridViewCheckBoxColumn3.Name = "DataGridViewCheckBoxColumn3"
        Me.DataGridViewCheckBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewCheckBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewCheckBoxColumn3.Width = 44
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 66
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Dmg"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 44
        '
        'colType
        '
        Me.colType.HeaderText = "Type"
        Me.colType.Name = "colType"
        Me.colType.ReadOnly = True
        Me.colType.Width = 50
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(64, 367)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(47, 20)
        Me.NumericUpDown1.TabIndex = 26
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(64, 342)
        Me.NumericUpDown2.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(47, 20)
        Me.NumericUpDown2.TabIndex = 22
        '
        'NumericUpDown3
        '
        Me.NumericUpDown3.Location = New System.Drawing.Point(129, 315)
        Me.NumericUpDown3.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.NumericUpDown3.Name = "NumericUpDown3"
        Me.NumericUpDown3.Size = New System.Drawing.Size(47, 20)
        Me.NumericUpDown3.TabIndex = 20
        '
        'NumericUpDown4
        '
        Me.NumericUpDown4.Location = New System.Drawing.Point(64, 290)
        Me.NumericUpDown4.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.NumericUpDown4.Name = "NumericUpDown4"
        Me.NumericUpDown4.Size = New System.Drawing.Size(47, 20)
        Me.NumericUpDown4.TabIndex = 14
        '
        'NumericUpDown5
        '
        Me.NumericUpDown5.Location = New System.Drawing.Point(129, 290)
        Me.NumericUpDown5.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.NumericUpDown5.Name = "NumericUpDown5"
        Me.NumericUpDown5.Size = New System.Drawing.Size(47, 20)
        Me.NumericUpDown5.TabIndex = 16
        '
        'NumericUpDown6
        '
        Me.NumericUpDown6.Location = New System.Drawing.Point(64, 316)
        Me.NumericUpDown6.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.NumericUpDown6.Name = "NumericUpDown6"
        Me.NumericUpDown6.Size = New System.Drawing.Size(47, 20)
        Me.NumericUpDown6.TabIndex = 18
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1404, 572)
        Me.Controls.Add(Me.btnGetItem)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.btnDelItem)
        Me.Controls.Add(Me.btnHealAll)
        Me.Controls.Add(Me.lstChars)
        Me.Controls.Add(Me.txtFolder)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.nudCStrength, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMStrength, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMIQ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCIQ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMDEX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCDEX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMCONST, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCCONST, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMLUCK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCLUCK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMHP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCHP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMSP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCSP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudExp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudGold, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudLevel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.nudWizd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSorc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMagi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudConj, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudBardSongsRmd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.dgvCB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRefresh As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFolder As TextBox
    Friend WithEvents lstChars As ListBox
    Friend WithEvents chkDead As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkNuts As CheckBox
    Friend WithEvents chkPossessed As CheckBox
    Friend WithEvents chkParalized As CheckBox
    Friend WithEvents chkStoned As CheckBox
    Friend WithEvents chkPoisoned As CheckBox
    Friend WithEvents chkOld As CheckBox
    Friend WithEvents txtFileName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboRace As ComboBox
    Friend WithEvents cboClass As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents nudCStrength As NumericUpDown
    Friend WithEvents nudMStrength As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents nudMIQ As NumericUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents nudCIQ As NumericUpDown
    Friend WithEvents Label9 As Label
    Friend WithEvents nudMDEX As NumericUpDown
    Friend WithEvents Label10 As Label
    Friend WithEvents nudCDEX As NumericUpDown
    Friend WithEvents Label11 As Label
    Friend WithEvents nudMCONST As NumericUpDown
    Friend WithEvents Label12 As Label
    Friend WithEvents nudCCONST As NumericUpDown
    Friend WithEvents Label13 As Label
    Friend WithEvents nudMLUCK As NumericUpDown
    Friend WithEvents Label14 As Label
    Friend WithEvents nudCLUCK As NumericUpDown
    Friend WithEvents Label15 As Label
    Friend WithEvents nudMHP As NumericUpDown
    Friend WithEvents Label16 As Label
    Friend WithEvents nudCHP As NumericUpDown
    Friend WithEvents Label17 As Label
    Friend WithEvents nudMSP As NumericUpDown
    Friend WithEvents Label18 As Label
    Friend WithEvents nudCSP As NumericUpDown
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents nudExp As NumericUpDown
    Friend WithEvents nudGold As NumericUpDown
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents nudLevel As NumericUpDown
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents nudWizd As NumericUpDown
    Friend WithEvents Label26 As Label
    Friend WithEvents nudSorc As NumericUpDown
    Friend WithEvents Label25 As Label
    Friend WithEvents nudMagi As NumericUpDown
    Friend WithEvents Label24 As Label
    Friend WithEvents nudConj As NumericUpDown
    Friend WithEvents Label23 As Label
    Friend WithEvents nudBardSongsRmd As NumericUpDown
    Friend WithEvents Label27 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnHeal As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnAddItem As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnHealAll As Button
    Friend WithEvents btnDelItem As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents dgvCB As DataGridView
    Friend WithEvents btnGetItem As Button
    Friend WithEvents colIdx As DataGridViewTextBoxColumn
    Friend WithEvents colEquip As DataGridViewCheckBoxColumn
    Friend WithEvents colItemName As DataGridViewTextBoxColumn
    Friend WithEvents colAC As DataGridViewTextBoxColumn
    Friend WithEvents colAvl As DataGridViewCheckBoxColumn
    Friend WithEvents colItemNum As DataGridViewTextBoxColumn
    Friend WithEvents colUnID As DataGridViewCheckBoxColumn
    Friend WithEvents colStat As DataGridViewTextBoxColumn
    Friend WithEvents colDmg As DataGridViewTextBoxColumn
    Friend WithEvents colItmType As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn3 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents colType As DataGridViewTextBoxColumn
    Friend WithEvents NumericUpDown6 As NumericUpDown
    Friend WithEvents NumericUpDown5 As NumericUpDown
    Friend WithEvents NumericUpDown4 As NumericUpDown
    Friend WithEvents NumericUpDown3 As NumericUpDown
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents NumericUpDown1 As NumericUpDown
End Class
