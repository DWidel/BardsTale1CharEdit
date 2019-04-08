Public Class clsChar

    'Information about a character as stored in the character file.

    Private Data(95) As Byte

    Public Sub New()

    End Sub

    Public FileName As String
    Public Sub New(filename As String)
        Me.FileName = filename
        Data = IO.File.ReadAllBytes(filename)
        Unpack()


    End Sub

    Public Sub New(arr() As Byte)
        Data = arr
        Unpack()
    End Sub

    Public IsChar As Boolean

    Public Name As String = "" '14
    Public Dead As Boolean = False
    Public Old As Boolean = False
    Public Poisened As Boolean = False
    Public Stoned As Boolean = False
    Public Paralized As Boolean = False
    Public Possessed As Boolean = False
    Public Nuts As Boolean = False
    Public Race As enRace = enRace.Human
    Public Clss As enClass = enClass.Warrior
    Public cStrength As Integer
    Public mStrength As Integer
    Public cIQ As Integer
    Public mIQ As Integer
    Public cDexterity As Integer
    Public mDexterity As Integer
    Public cConstitution As Integer
    Public mConstitution As Integer
    Public cLuck As Integer
    Public mLuck As Integer
    Public HP As Integer
    Public Condition As Integer
    Public mSpellPt As Integer
    Public cSpellPt As Integer
    Public Items(8) As clsItem
    Public Experience As Integer
    Public Gold As Integer
    Public Level As Integer
    Public ConjLevel As Integer
    Public MagiLevel As Integer
    Public SorcLevel As Integer
    Public WizdLevel As Integer
    Public BardSongsRmd As Integer


    <Flags()>
    Public Enum enStatus
        Alive = 0
        Dead = &H2
        Old = &H4
        Pois = &H8
        Ston = &H10
        Para = &H20
        Poss = &H40
        Nuts = &H80

    End Enum

    Public Enum enRace
        Human = 0
        Elf = 1
        Dwarf = 2
        Hobbit = 3
        HalfElf = 4
        HalfOrc = 5
        Gnome = 6
    End Enum

    Public Enum enClass
        Warrior = 0
        Paladin = 1
        Rogue = 2
        Bard = 3
        Hunter = 4
        Monk = 5
        Conjurer = 6
        Magician = 7
        Sorceror = 8
    End Enum

    Public Sub Unpack()

        IsChar = (Data(16) = 1)

        Name = ""
        For i = 0 To 13
            If Data(i) = 0 Then Exit For
            name &= Chr(Data(i))
        Next
        Dim Status As Byte = Data(17)
        Dead = Status And enStatus.Dead
        Old = Status And enStatus.Old
        Poisened = Status And enStatus.Pois
        Stoned = Status And enStatus.Ston
        Paralized = Status And enStatus.Para
        Possessed = Status And enStatus.Poss
        Nuts = Status And enStatus.Nuts
        Race = Data(19)
        Clss = Data(21)
        cStrength = Load(23, 2)
        cIQ = Load(25, 2)
        cDexterity = Load(27, 2)
        cConstitution = Load(29, 2)
        cLuck = Load(31, 2)
        mStrength = Load(33, 2)
        mIQ = Load(35, 2)
        mDexterity = Load(37, 2)
        mConstitution = Load(39, 2)
        mLuck = Load(41, 2)
        HP = Load(45, 2)
        Condition = Load(47, 2)
        mSpellPt = Load(49, 2)
        cSpellPt = Load(51, 2)
        For i As Integer = 0 To 7
            Dim x As New clsItem(Data(53 + i * 2), Data(54 + i * 2))
            Me.Items(i) = x
        Next
        Me.Experience = Load(69, 3)
        Me.Gold = Load(73, 3)

        Me.Level = Load(77, 2)


        ConjLevel = Data(82)
        MagiLevel = Data(83)
        SorcLevel = Data(84)
        WizdLevel = Data(85)
        BardSongsRmd = Data(93)


    End Sub

    Public Sub WriteData()



        For i = 0 To 13
            If i < Name.Length Then
                Data(i) = Asc(Name.Substring(i, 1))
            Else
                Data(i) = 0
            End If
        Next

        Dim Status As Byte = 0
        If Dead Then Status = Status Or enStatus.Dead
        If Old Then Status = Status Or enStatus.Old
        If Poisened Then Status = Status Or enStatus.Pois
        If Stoned Then Status = Status Or enStatus.Ston
        If Paralized Then Status = Status Or enStatus.Para
        If Possessed Then Status = Status Or enStatus.Poss
        If Nuts Then Status = Status Or enStatus.Nuts

        Data(17) = Status

        Data(19) = Race
        Data(21) = Clss

        Store(23, 2, cStrength)
        Store(25, 2, cIQ)
        Store(27, 2, cDexterity)
        Store(29, 2, cConstitution)
        Store(31, 2, cLuck)
        Store(33, 2, mStrength)
        Store(35, 2, mIQ)
        Store(37, 2, mDexterity)
        Store(39, 2, mConstitution)
        Store(41, 2, mLuck)
        Store(45, 2, HP)
        Store(47, 2, Condition)
        Store(49, 2, mSpellPt)
        Store(51, 2, cSpellPt)


        Store(69, 3, Me.Experience)
        Store(73, 3, Me.Gold)


        Store(77, 2, Me.Level)




        Data(82) = ConjLevel
        Data(83) = MagiLevel
        Data(84) = SorcLevel
        Data(85) = WizdLevel
        Data(93) = BardSongsRmd



        For i As Integer = 0 To 7
            Dim x As clsItem = Items(i)

            Data(53 + i * 2) = x.ItemNumber
            Data(54 + i * 2) = x.Status
            'If x.Equipped Then
            '    Data(54 + i * 2) = &H80
            'Else
            '    Data(54 + i * 2) = &H0
            'End If

        Next


        SaveBackup


        IO.File.WriteAllBytes(Me.FileName, Data)


    End Sub

    Private Sub SaveBackup()
        Dim Shortfilename As String = IO.Path.GetFileNameWithoutExtension(Me.FileName)
        Dim NewFIlename As String = IO.Path.Combine(My.Settings.BackupFolder, Shortfilename & "-" & Format(Now, "yyMMdd-HHmmss.fff") & ".btbu")
        IO.File.Copy(FileName, NewFIlename)


    End Sub

    Private Function Load(idx, len) As Integer

        Dim val As Integer = Data(idx)
        If len > 1 Then
            val += Data(idx + 1) * 2 ^ 8
        End If
        If len > 3 Then
            val += Data(idx + 2) * 2 ^ 16
        End If

        Return val
    End Function

    Private Sub Store(idx, len, Value)

        Dim tVal As Integer = Value Mod 2 ^ 8


        Data(idx) = tVal

        If len > 1 Then
            Value = (Value - tVal) / 2 ^ 8
            tVal = Value Mod 2 ^ 8
            Data(idx + 1) = tVal
        End If


        If len > 2 Then
            Value = (Value - tVal) / 2 ^ 8
            tVal = Value Mod 2 ^ 8
            Data(idx + 2) = tVal
        End If


    End Sub

    Public Overrides Function ToString() As String
        Return Name.ToString
    End Function

End Class
