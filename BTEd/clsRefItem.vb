Public Class clsRefItem

    Public Type As String
    Public Index As Integer
    Public Name As String
    Public Price As Integer
    Public AC As Integer = 0

    Public Wa As Boolean = False
    Public Pa As Boolean = False
    Public Ro As Boolean = False
    Public Ba As Boolean = False
    Public Hu As Boolean = False
    Public Mo As Boolean = False
    Public Co As Boolean = False
    Public Ma As Boolean = False
    Public So As Boolean = False
    Public Wi As Boolean = False

    Public Tohit As String
    Public Damage As Integer = 0
    Public Special As String

    Public Line As String = ""

    Public ReadOnly Property TypeDesc As String
        Get
            Select Case Type.ToUpper
                Case "S" : Return "Shield"
                Case "A" : Return "Armor"
                Case "M" : Return "Wand"
                Case "X" : Return "Misc"
                Case "F" : Return "FGN"
                Case "G" : Return "Glove"
                Case "H" : Return "Helm"
                Case "W" : Return "Wpn"
                Case "I" : Return "Inst"
                Case "R" : Return "Ring"
                Case "0" : Return ""
                Case Else
                    Throw New Exception("Bad Item Type: " & Type)
            End Select
        End Get
    End Property

    Public Function IsAvail(cls As clsChar.enClass) As Boolean
        Select Case cls
            Case clsChar.enClass.Bard
                Return Me.Ba
            Case clsChar.enClass.Conjurer
                Return Me.Co
            Case clsChar.enClass.Hunter
                Return Me.Hu
            Case clsChar.enClass.Magician
                Return Me.Ma
            Case clsChar.enClass.Monk
                Return Me.Mo
            Case clsChar.enClass.Paladin
                Return Me.Pa
            Case clsChar.enClass.Rogue
                Return Me.Ro
            Case clsChar.enClass.Sorceror
                Return Me.So
            Case clsChar.enClass.Warrior
                Return Me.Wa
            Case Else
                Throw New Exception("Bad Class: " & cls)

        End Select

    End Function

    Public Sub New(idx As Integer, line As String)
        Me.Line = line
        Index = idx
        Dim ss() As String = line.Split(",")
        Type = ss(0)
        Name = ss(1).Trim
        AC = ss(2)
        Wa = GetValue(ss(3))
        Pa = GetValue(ss(4))
        Ro = GetValue(ss(5))
        Ba = GetValue(ss(6))
        Hu = GetValue(ss(7))
        Mo = GetValue(ss(8))
        Co = GetValue(ss(9))
        Ma = GetValue(ss(10))
        So = GetValue(ss(11))
        Wi = GetValue(ss(12))
        Price = ss(13)

        If ss.Count > 14 Then
            Tohit = ss(14)
        End If
        If ss.Count > 15 Then
            If ss(15).Trim <> "" Then Damage = ss(15)
        End If
        If ss.Count > 16 Then
            Special = ss(16)
        End If

    End Sub

    Private Function GetValue(val) As Boolean
        If val.trim = "" Then Return False
        If val.trim = "1" Then Return True
        Throw New Exception("Invalid Value line " & Index)

    End Function

End Class
