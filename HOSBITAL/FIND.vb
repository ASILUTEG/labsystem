Public Class FIND
    Dim cmdFFFND As New OleDb.OleDbCommand
    Dim adFFFND As New OleDb.OleDbDataAdapter
    Dim FFFND As New DataTable
    Dim cmdFF31 As New OleDb.OleDbCommand
    Dim adFF31 As New OleDb.OleDbDataAdapter
    Dim FF31 As New DataTable

    Private Sub FIND_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
       
    End Sub

    Private Sub SNAME_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SNAME.TextChanged
        dr.Close()
        cmdFFFND.Connection = CN
        cmdFFFND.CommandType = CommandType.Text
        cmdFFFND.CommandText = "select * from LPATIEN WHERE " & NFLD.Text & " LIKE '%" & SNAME.Text & "%' ORDER BY PNAME"
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
        FDG.Columns("PAGE").Visible = True
        FDG.Columns("PAGE").HeaderText = "«·”‰"
        FDG.Columns("pmobile").Visible = True
        FDG.Columns("pmobile").HeaderText = "«· ·Ì›Ê‰"
    End Sub

    Private Sub FDG_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles FDG.CellContentClick

    End Sub

    Private Sub FDG_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles FDG.CellMouseDoubleClick
        dr.Close()
        cmdFF31.Connection = CN
        cmdFF31.CommandType = CommandType.Text
        cmdFF31.CommandText = "select * from LBILL WHERE PCODE='" & FDG("PCODE", e.RowIndex).Value & "'"
        adFF31.SelectCommand = cmdFF31
        adFF31.Fill(DBS, "FF31")
        FF31 = DBS.Tables("FF31")
        DBS.Tables("FF31").Clear()
        adFF31.Fill(DBS, "FF31")
        FF31 = DBS.Tables("FF31")
        Dim oj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        oj.Load(Application.StartupPath & "\BILL.rpt")
        oj.Database.Tables(0).SetDataSource(FF31)
        oj.SetParameterValue("1", " ﬁ—Ì— «· ›’Ì·Ï Œ·«· › —… „‰ ")
        oj.SetParameterValue("2", LBILL.d1.Value)
        oj.SetParameterValue("3", LBILL.d2.Value)
        oj.SetParameterValue("5", "0")
        oj.SetParameterValue("118", 0)

        rp.Close() : rp.CrystalReportViewer1.ReportSource = oj
        rp.Show() : rp.Focus()
    End Sub
End Class