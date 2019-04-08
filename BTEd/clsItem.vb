Public Class clsItem

    Public ItemNumber As Integer
    Public Equipped As Boolean = False
    Public UnIdentified As Boolean = False
    Public RefItem As clsRefItem = Nothing
    Public ItemName As String = ""

    Public Status As Byte

    Public Sub New()

    End Sub

    Public Sub New(Code As Integer, status As Integer)
        ItemNumber = Code
        Me.Status = status
        Equipped = (status And &H80) > 0
        UnIdentified = (status And &H40) > 0

        status = status And &H3F

        RefItem = gRefItems(ItemNumber)
        ItemName = RefItem.Name
        If status <> 0 Then
            'Throw New Exception("Unknown Item status" & Status)
            Dim ii As Integer = 0
        End If

    End Sub

    Public Sub New(Code As Integer, itemStatus As Byte, Equipped As Boolean, UnId As Boolean)
        ItemNumber = Code
        Me.Equipped = Equipped
        Me.UnIdentified = UnId
        Me.Status = itemStatus
        If Me.Equipped Then
            Status = Status Or &H80
        Else
            Status = Status And &H7F
        End If
        If Me.UnIdentified Then
            Status = Status Or &H40
        Else
            Status = Status And &HBF
        End If


        RefItem = gRefItems(ItemNumber)

        ItemName = RefItem.Name

    End Sub


End Class
