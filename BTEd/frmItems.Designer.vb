<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmItems
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.colIdx = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAvl = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colMSRP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDamage = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSpecial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.cboType = New System.Windows.Forms.ComboBox()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        Me.DGV.AllowUserToResizeRows = False
        Me.DGV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colIdx, Me.colItemName, Me.colAC, Me.colAvl, Me.colMSRP, Me.colDice, Me.colDamage, Me.colSpecial, Me.colType})
        Me.DGV.Location = New System.Drawing.Point(12, 42)
        Me.DGV.MultiSelect = False
        Me.DGV.Name = "DGV"
        Me.DGV.RowHeadersVisible = False
        Me.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV.Size = New System.Drawing.Size(939, 353)
        Me.DGV.TabIndex = 1
        '
        'colIdx
        '
        Me.colIdx.HeaderText = "#"
        Me.colIdx.Name = "colIdx"
        Me.colIdx.ReadOnly = True
        Me.colIdx.Width = 44
        '
        'colItemName
        '
        Me.colItemName.HeaderText = "Item"
        Me.colItemName.Name = "colItemName"
        Me.colItemName.ReadOnly = True
        Me.colItemName.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colItemName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colItemName.Width = 200
        '
        'colAC
        '
        Me.colAC.HeaderText = "AC"
        Me.colAC.Name = "colAC"
        Me.colAC.ReadOnly = True
        Me.colAC.Width = 44
        '
        'colAvl
        '
        Me.colAvl.HeaderText = "Avl"
        Me.colAvl.Name = "colAvl"
        Me.colAvl.ReadOnly = True
        Me.colAvl.Width = 44
        '
        'colMSRP
        '
        Me.colMSRP.HeaderText = "MSRP"
        Me.colMSRP.Name = "colMSRP"
        Me.colMSRP.ReadOnly = True
        Me.colMSRP.Width = 66
        '
        'colDice
        '
        Me.colDice.HeaderText = "Dice"
        Me.colDice.Name = "colDice"
        Me.colDice.ReadOnly = True
        '
        'colDamage
        '
        Me.colDamage.HeaderText = "Dmg"
        Me.colDamage.Name = "colDamage"
        Me.colDamage.ReadOnly = True
        Me.colDamage.Width = 66
        '
        'colSpecial
        '
        Me.colSpecial.HeaderText = "Special"
        Me.colSpecial.Name = "colSpecial"
        Me.colSpecial.ReadOnly = True
        Me.colSpecial.Width = 120
        '
        'colType
        '
        Me.colType.HeaderText = "Type"
        Me.colType.Name = "colType"
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOK.Location = New System.Drawing.Point(859, 415)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "Add Item"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'cboType
        '
        Me.cboType.FormattingEnabled = True
        Me.cboType.Location = New System.Drawing.Point(486, 12)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(121, 21)
        Me.cboType.TabIndex = 3
        '
        'frmItems
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 450)
        Me.Controls.Add(Me.cboType)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.DGV)
        Me.Name = "frmItems"
        Me.Text = "Available Items List"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGV As DataGridView
    Friend WithEvents btnOK As Button
    Friend WithEvents cboType As ComboBox
    Friend WithEvents colIdx As DataGridViewTextBoxColumn
    Friend WithEvents colItemName As DataGridViewTextBoxColumn
    Friend WithEvents colAC As DataGridViewTextBoxColumn
    Friend WithEvents colAvl As DataGridViewCheckBoxColumn
    Friend WithEvents colMSRP As DataGridViewTextBoxColumn
    Friend WithEvents colDice As DataGridViewTextBoxColumn
    Friend WithEvents colDamage As DataGridViewTextBoxColumn
    Friend WithEvents colSpecial As DataGridViewTextBoxColumn
    Friend WithEvents colType As DataGridViewTextBoxColumn
End Class
