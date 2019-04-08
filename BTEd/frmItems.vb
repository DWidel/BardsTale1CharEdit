Public Class frmItems

    Private mClass As clsChar.enClass

    Public Sub New(clss As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        mClass = clss
    End Sub

    Public ReadOnly Property SelectedItem As clsRefItem
        Get
            If DGV.SelectedRows.Count = 1 Then
                Return gRefItems(DGV.SelectedRows(0).Cells(0).Value)
            Else
                Return gRefItems(0)
            End If

        End Get
    End Property
    Private Sub frmItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim lstType As New Generic.List(Of String)


        For Each x As clsRefItem In gRefItems.Values
            If x.Index = 0 Then Continue For
            Dim arr(9) As Object
            arr(0) = x.Index
            arr(1) = x.Name
            arr(2) = x.AC
            arr(3) = x.IsAvail(mClass)
            arr(4) = x.Price
            arr(5) = x.Tohit
            arr(6) = x.Damage
            arr(7) = x.Special
            arr(8) = x.TypeDesc
            If Not lstType.Contains(x.TypeDesc) Then lstType.Add(x.TypeDesc)


            DGV.Rows.Add(arr)


        Next


        cboType.Items.Clear()
        cboType.Items.Add("<ALL>")
        For Each type As String In lstType
            cboType.Items.Add(type)
        Next
        cboType.SelectedIndex = 0



    End Sub

    Private Sub cboType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboType.SelectedIndexChanged
        Dim key As String = cboType.SelectedItem
        For Each R As DataGridViewRow In DGV.Rows
            If key = "<ALL>" OrElse key = R.Cells(8).Value.ToString Then
                R.Visible = True
            Else
                R.Visible = False
            End If
        Next

    End Sub

End Class