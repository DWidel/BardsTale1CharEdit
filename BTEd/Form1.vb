Public Class Form1


    Dim mSelectedChar As clsChar

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If My.Settings.BardsFolder.Trim = "" Then
        Else
            txtFolder.Text = My.Settings.BardsFolder.Trim
        End If

        If My.Settings.BackupFolder.Trim <> "" Then
            If Not IO.Directory.Exists(My.Settings.BackupFolder) Then
                IO.Directory.CreateDirectory(My.Settings.BackupFolder)
            End If
        End If



        LoadRefItems()

        For Each i In [Enum].GetValues(GetType(clsChar.enRace))
            cboRace.Items.Add(i)
        Next
        For Each i In [Enum].GetValues(GetType(clsChar.enClass))
            cboClass.Items.Add(i)
        Next

        For i As Integer = 0 To 7
            Dim arr(6) As Object
            arr(0) = i
            arr(1) = False
            arr(2) = ""
            arr(3) = ""
            arr(4) = False
            arr(5) = 0
            DataGridView1.Rows.Add(arr)
        Next

        Reload()

        If lstChars.Items.Count > 0 Then
            lstChars.SelectedIndex = 0
        End If
    End Sub
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click

        Try
            If txtFolder.Text.Trim = "" Then
                'nothing
            Else
                If IO.Directory.Exists(txtFolder.Text.Trim) Then
                    My.Settings.BardsFolder = txtFolder.Text.Trim
                    Reload()
                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub LoadRefItems()
        gRefItems.Clear()

        Dim lines() As String = IO.File.ReadAllLines(".\ItemData.txt")

        Dim idx As Integer = 0
        For Each line As String In lines
            If line.StartsWith("'") Then Continue For
            Dim x As New clsRefItem(idx, line)
            gRefItems.Add(idx, x)


            idx += 1
        Next

    End Sub

    Private Sub Reload()
        Dim files() As String = IO.Directory.GetFiles(txtFolder.Text, "*.TPW")

        Dim lst As New List(Of clsChar)

        lstChars.Items.Clear()
        For Each file As String In files
            Dim x As New clsChar(file)
            If x.IsChar Then
                lst.Add(x)
                lstChars.Items.Add(x)
            End If

        Next


    End Sub


    Public Sub DisplayChar(C As clsChar)
        mSelectedChar = C

        txtName.Text = C.Name
        chkDead.Checked = C.Dead
        chkNuts.Checked = C.Nuts
        chkOld.Checked = C.Old
        chkParalized.Checked = C.Paralized
        chkPoisoned.Checked = C.Poisened
        chkPossessed.Checked = C.Possessed
        chkStoned.Checked = C.Stoned
        txtFileName.Text = C.FileName

        cboRace.SelectedIndex = C.Race
        cboClass.SelectedIndex = C.Clss
        nudCStrength.Value = C.cStrength
        nudMStrength.Value = C.mStrength
        nudCIQ.Value = C.cIQ
        nudMIQ.Value = C.mIQ
        nudCDEX.Value = C.cDexterity
        nudMDEX.Value = C.mDexterity
        nudCCONST.Value = C.cConstitution
        nudMCONST.Value = C.mConstitution
        nudCLUCK.Value = C.cLuck
        nudMLUCK.Value = C.mLuck
        SetNud(nudCHP, C.Condition)
        SetNud(nudMHP, C.HP)
        SetNud(nudCSP, C.cSpellPt)
        SetNud(nudMSP, C.mSpellPt)

        SetNud(nudExp, C.Experience)
        SetNud(nudGold, C.Gold)
        SetNud(nudLevel, C.Level)
        SetNud(nudConj, C.ConjLevel)
        SetNud(nudMagi, C.MagiLevel)
        SetNud(nudSorc, C.SorcLevel)
        SetNud(nudWizd, C.WizdLevel)
        SetNud(nudBardSongsRmd, C.BardSongsRmd)

        DataGridView1.Rows.Clear()

        For i As Integer = 0 To 7


            Dim x As clsItem = C.Items(i)
            PutItemInRow(DataGridView1, x, i)

            'Dim arr(8) As Object

            ''If C.Items.Count < i Then
            'Dim x As clsItem = C.Items(i)
            'arr(0) = i
            'arr(1) = x.Equipped
            'arr(2) = x.ItemName
            'arr(3) = x.RefItem.AC
            'arr(4) = True
            'arr(5) = x.RefItem.Index
            'arr(6) = x.UnIdentified
            'arr(7) = Hex(x.Status)
            ''Else
            ''    arr(0) = i
            ''    arr(1) = False
            ''    arr(2) = ""
            ''    arr(3) = False

            ''End If


            'DataGridView1.Rows.Add(arr)
        Next

    End Sub


    Private Sub SetNud(nud As NumericUpDown, Value As Integer)
        If Value > nud.Maximum Then
            Value = nud.Maximum
        End If
        If Value < nud.Minimum Then
            Value = nud.Minimum
        End If

        nud.Value = Value

    End Sub

    Private Sub lstChars_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstChars.SelectedIndexChanged
        Try
            DisplayChar(lstChars.SelectedItem)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnHeal_Click(sender As Object, e As EventArgs) Handles btnHeal.Click
        Try
            chkDead.Checked = False
            chkNuts.Checked = False
            chkOld.Checked = False
            chkParalized.Checked = False
            chkPoisoned.Checked = False
            chkPossessed.Checked = False
            chkStoned.Checked = False
            chkNuts.Checked = False
            nudCHP.Value = nudMHP.Value
            nudCCONST.Value = nudMCONST.Value
            nudCStrength.Value = nudMStrength.Value
            nudCDEX.Value = nudMDEX.Value
            nudCLUCK.Value = nudMLUCK.Value
            nudCIQ.Value = nudMIQ.Value

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        Try
            Using f As New frmItems(cboClass.SelectedItem)
                If f.ShowDialog = DialogResult.OK Then
                    Dim itm As clsRefItem = f.SelectedItem
                    If itm.Index > 0 Then
                        For i As Integer = 0 To 7
                            Dim itmnumber As Integer = DataGridView1.Rows(i).Cells(5).Value
                            If itmnumber = 0 Then
                                'DataGridView1.Rows(i).Cells(0).Value = itm.Index
                                DataGridView1.Rows(i).Cells(1).Value = False
                                DataGridView1.Rows(i).Cells(2).Value = itm.Name
                                DataGridView1.Rows(i).Cells(3).Value = itm.AC
                                DataGridView1.Rows(i).Cells(4).Value = True
                                DataGridView1.Rows(i).Cells(5).Value = itm.Index
                                Exit For
                            End If


                        Next

                    End If

                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btmSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            WriteIntoChar(mSelectedChar)
            mSelectedChar.WriteData()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Public Sub WriteIntoChar(C As clsChar)
        C.Name = txtName.Text
        C.Dead = chkDead.Checked
        C.Nuts = chkNuts.Checked
        C.Old = chkOld.Checked
        C.Paralized = chkParalized.Checked
        C.Poisened = chkPoisoned.Checked
        C.Possessed = chkPossessed.Checked
        C.Stoned = chkStoned.Checked
        C.FileName = txtFileName.Text


        C.Race = cboRace.SelectedIndex
        C.Clss = cboClass.SelectedIndex
        C.cStrength = nudCStrength.Value
        C.mStrength = nudMStrength.Value
        C.cIQ = nudCIQ.Value
        C.mIQ = nudMIQ.Value
        C.cDexterity = nudCDEX.Value
        C.mDexterity = nudMDEX.Value
        C.cConstitution = nudCCONST.Value
        C.mConstitution = nudMCONST.Value
        C.cLuck = nudCLUCK.Value
        C.mLuck = nudMLUCK.Value
        C.Condition = nudCHP.Value
        C.HP = nudMHP.Value
        C.cSpellPt = nudCSP.Value
        C.mSpellPt = nudMSP.Value


        C.Experience = nudExp.Value
        C.Gold = nudGold.Value
        C.Level = nudLevel.Value
        C.ConjLevel = nudConj.Value
        C.MagiLevel = nudMagi.Value
        C.SorcLevel = nudSorc.Value
        C.WizdLevel = nudWizd.Value
        C.BardSongsRmd = nudBardSongsRmd.Value






        For i As Integer = 0 To 7

            Dim x As clsItem = GetItemFromRow(DataGridView1.Rows(i))
            C.Items(i) = x

        Next



    End Sub

    Private Sub PutItemInRow(DGV As DataGridView, x As clsItem, rowidx As Integer)
        Dim arr(10) As Object

        Dim OvrW As Boolean = DGV.Name = DataGridView1.Name


        If rowidx = -1 And OvrW Then
            'need to find a row
            For Each R As DataGridViewRow In DGV.Rows
                If R.Cells(5).Value = 0 Then
                    rowidx = R.Cells(0).Value
                    Exit For
                End If
            Next
            If rowidx = -1 Then
                Throw New Exception("Inventory Full.")
            End If
        End If


        If rowidx = -1 OrElse DGV.RowCount <= rowidx Then

            '-1 then add at end
            arr(0) = rowidx
                arr(1) = x.Equipped
                arr(2) = x.ItemName
                arr(3) = x.RefItem.AC
                arr(4) = True
                arr(5) = x.RefItem.Index
                arr(6) = x.UnIdentified
                arr(7) = Hex(x.Status)
            arr(8) = x.RefItem.Damage
            arr(9) = x.RefItem.TypeDesc
            rowidx = DGV.Rows.Add(arr)
                DGV.Rows(rowidx).Cells(0).Value = rowidx

        Else
            DGV.Rows(rowidx).Cells(0).Value = rowidx
            DGV.Rows(rowidx).Cells(1).Value = x.Equipped
            DGV.Rows(rowidx).Cells(2).Value = x.ItemName
            DGV.Rows(rowidx).Cells(3).Value = x.RefItem.AC
            DGV.Rows(rowidx).Cells(4).Value = True
            DGV.Rows(rowidx).Cells(5).Value = x.RefItem.Index
            DGV.Rows(rowidx).Cells(6).Value = x.UnIdentified
            DGV.Rows(rowidx).Cells(7).Value = Hex(x.Status)
            DGV.Rows(rowidx).Cells(8).Value = x.RefItem.Damage
            DGV.Rows(rowidx).Cells(9).Value = x.RefItem.TypeDesc



        End If
        'Else
        '    arr(0) = i
        '    arr(1) = False
        '    arr(2) = ""
        '    arr(3) = False

        'End If



    End Sub

    Private Function GetItemFromRow(R As DataGridViewRow) As clsItem
        Dim itmNum As Integer = R.Cells(5).Value
        Dim Equipped As Boolean = R.Cells(1).Value
        Dim UniD As Boolean = R.Cells(6).Value
        Dim Status As Byte = "&H" & R.Cells(7).Value.ToString

        Dim x As New clsItem(itmNum, Status, Equipped, UniD)
        Return x

    End Function


    Private Sub btnHealAll_Click(sender As Object, e As EventArgs) Handles btnHealAll.Click
        Try
            For i As Integer = 0 To lstChars.Items.Count - 1
                lstChars.SelectedIndex = i
                lstChars.SelectedIndex = i
                btnHeal.PerformClick()
                btnSave.PerformClick()
                Application.DoEvents()

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnDelItem_Click(sender As Object, e As EventArgs) Handles btnDelItem.Click
        Try

            For Each R As DataGridViewRow In DataGridView1.SelectedRows
            'DataGridView1.Rows(i).Cells(0).Value = itm.Index
            Dim x As clsItem = GetItemFromRow(R)
            If x.ItemNumber = 0 Then Continue For
            PutItemInRow(dgvCB, x, -1)
            R.Cells(1).Value = False
            R.Cells(2).Value = ""
            R.Cells(3).Value = 0
            R.Cells(4).Value = True
            R.Cells(5).Value = 0
        Next

            CompressDGV(DataGridView1)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnGetItem_Click(sender As Object, e As EventArgs) Handles btnGetItem.Click
        Try

            For Each R As DataGridViewRow In dgvCB.SelectedRows
            'DataGridView1.Rows(i).Cells(0).Value = itm.Index
            Dim x As clsItem = GetItemFromRow(R)
            If x.ItemNumber = 0 Then Continue For
            PutItemInRow(DataGridView1, x, -1)

            dgvCB.Rows.Remove(R)
            For i As Integer = 0 To dgvCB.RowCount - 1
                Dim R2 As DataGridViewRow = dgvCB.Rows(i)
                R2.Cells(0).Value = i

            Next


        Next

        Catch ex As Exception
        MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub CompressDGV(DGV As DataGridView)
        For i As Integer = 0 To DGV.RowCount - 2
            Dim R As DataGridViewRow = DGV.Rows(i)
            If R.Cells(5).Value = 0 Then
                'blank
                For j As Integer = i To DGV.RowCount - 2
                    Dim x As clsItem = GetItemFromRow(DGV.Rows(j + 1))
                    PutItemInRow(DGV, x, j)
                Next

            End If

        Next

    End Sub


End Class
