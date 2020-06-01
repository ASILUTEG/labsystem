Public Class bblocck
    Dim cmdFFFND As New OleDb.OleDbCommand
    Dim adFFFND As New OleDb.OleDbDataAdapter
    Dim FFFND As New DataTable
    Private Sub bblocck_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub tname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tname.TextChanged
        dr.Close()
        cmdFFFND.Connection = CN
        cmdFFFND.CommandType = CommandType.Text
        cmdFFFND.CommandText = "select * from lblock WHERE pname LIKE '%" & tname.Text & "%' ORDER BY PNAME"
        adFFFND.SelectCommand = cmdFFFND
        adFFFND.Fill(DBS, "FFFND")
        FFFND = DBS.Tables("FFFND")
        DBS.Tables("FFFND").Clear()
        adFFFND.Fill(DBS, "FFFND")
        FFFND = DBS.Tables("FFFND")
        FDG.DataSource = FFFND
        Dim v As Integer = 0
        While Not v = FDG.Columns.Count
            FDG.Columns(v).Visible = False
            v = v + 1
        End While
        FDG.Columns("Pname").HeaderText = "«·«”„"
        FDG.Columns("Pname").Visible = True
        FDG.Columns("Pname").Width = 150
        FDG.Columns("pmobile").Visible = True
        FDG.Columns("pmobile").HeaderText = "«· ·Ì›Ê‰"
    End Sub

    Private Sub FDG_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles FDG.CellContentClick

    End Sub

    Private Sub FDG_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles FDG.CellMouseClick
        On Error Resume Next
        MsgBox(FDG(("COMMENT"), e.RowIndex).Value)
    End Sub

    Private Sub FDG_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles FDG.MouseClick

    End Sub
End Class