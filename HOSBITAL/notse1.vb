Public Class notse1
    Dim cmdN31 As New OleDb.OleDbCommand
    Dim adN31 As New OleDb.OleDbDataAdapter
    Dim N31 As New DataTable
    Dim cmdnt1 As New OleDb.OleDbCommand
    Dim adNt1 As New OleDb.OleDbDataAdapter
    Dim Nt1 As New DataTable
    Dim cmdu31 As New OleDb.OleDbCommand
    Dim adu31 As New OleDb.OleDbDataAdapter
    Dim u31 As New DataTable
    Private Sub notse1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'dr.Close()
        'cmd.CommandText = "select * from LCOMPANY"
        'dr = cmd.ExecuteReader
        'While dr.Read
        '    comments.AutoCompleteCustomSource.Add(dr("name"))
        'End While
        DateTimePicker2.Value = Now

        cmdN31.Connection = CN
        cmdN31.CommandType = CommandType.Text
        cmdN31.CommandText = "select * from lwall WHERE nDATE='" & ChangeFormat(Now.Date) & "'"
        adN31.SelectCommand = cmdN31
        adN31.Fill(DBS, "N31")
        N31 = DBS.Tables("N31")
        DBS.Tables("N31").Clear()
        adN31.Fill(DBS, "N31")
        N31 = DBS.Tables("N31")
        brpd.DataSource = N31

        cmdu31.Connection = CN
        cmdu31.CommandType = CommandType.Text
        cmdu31.CommandText = "select * from users "
        adu31.SelectCommand = cmdu31
        adu31.Fill(DBS, "u31")
        u31 = DBS.Tables("u31")
        DBS.Tables("u31").Clear()
        adu31.Fill(DBS, "u31")
        u31 = DBS.Tables("u31")
        uusers.DataSource = u31

        Dim v As Integer = 0
        While Not v = uusers.Columns.Count
            uusers.Columns(v).Visible = False
            v = v + 1
        End While
        uusers.Columns("qun").Visible = True
        uusers.Columns("users").Visible = True

        dr.Close()

    End Sub

    Private Sub GlassButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton2.Click
        uf()
        Dim qwe As String = ""
        Dim N As Integer = 0
        While Not N = u31.Rows.Count
            If IsDBNull(u31.Rows(N).Item("QUN")) = False Then
                If u31.Rows(N).Item("QUN") = 1 Then
                    qwe = " and usr ='" & u31.Rows(N).Item("NAME") & "'"
                End If
            End If
            N = N + 1
        End While
        If cnot.Checked = True Then qwe = qwe & " and notse like'%" & comments.Text & "%'"
        If ccode.Checked = True Then qwe = qwe & " and code ='" & code.Text & "'"
        cmdnt1.Connection = CN
        cmdnt1.CommandType = CommandType.Text
        cmdnt1.CommandText = "select * from v_wall where usra='" & USR & "' and Ndate between '" & ChangeFormat(DateTimePicker1.Value) & "' and '" & ChangeFormat(DateTimePicker2.Value) & "'" & qwe
        adNt1.SelectCommand = cmdnt1
        adNt1.Fill(DBS, "nt1")
        Nt1 = DBS.Tables("nt1")
        DBS.Tables("nt1").Clear()
        adNt1.Fill(DBS, "nt1")
        Nt1 = DBS.Tables("nt1")
        Dim oj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        oj.Load(Application.StartupPath & "\wall.rpt")
        oj.Database.Tables(0).SetDataSource(Nt1)
        rp.CrystalReportViewer1.ReportSource = oj
        rp.Show()
        rp.Focus()

    End Sub

    Private Sub GlassButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton1.Click
        If comments.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
        dr.Close()
        cmd.CommandText = "select * from LWALL where   code='" & Val(code.Text) & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Dim nN As String
            nN = MsgBox(" Â·  —Ìœ «· ⁄œÌ· ø", MsgBoxStyle.YesNo)
            If nN = vbNo Then Exit Sub
            dr.Close()
            cmd.CommandText = "delete from LWALL where    code='" & Val(code.Text) & "'"
            cmd.ExecuteNonQuery()
            cmd.CommandText = "delete from LWALL_USR where    code='" & Val(code.Text) & "'"
            cmd.ExecuteNonQuery()
        End If
        
        dr.Close() : cmd.CommandText = "insert into LWALL (usra,notse,ndate,ntime,CODE)  values ('" & USR & "','" & comments.Text & "','" & ChangeFormat(d1.Value) & "','" & Now.Hour & " : " & Now.Minute & "','" & code.Text & "')"
        cmd.ExecuteNonQuery()
        Dim N As Integer = 0
        While Not N = u31.Rows.Count
            If IsDBNull(u31.Rows(N).Item("QUN")) = False Then
                If u31.Rows(N).Item("QUN") = 1 Then
                    cmd.CommandText = "INSERT INTO LWALL_USR (USR,CODE) VALUES ('" & u31.Rows(N).Item("NAME") & "','" & code.Text & "' ) "
                    cmd.ExecuteNonQuery()
                End If
            End If
            N = N + 1
        End While
        MsgBox("SAVED", MsgBoxStyle.Information)
    End Sub

    Private Sub GlassButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim yy As String = ""



    End Sub

    Private Sub GlassButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton4.Click
        uf()
        dr.Close()
        cmd.CommandText = "SELECT MAX(CODE) FROM LWALL  "
        dr = cmd.ExecuteReader
        dr.Read()
        If IsDBNull(dr(0)) = False Then code.Text = dr(0) + 1 Else code.Text = 1
        comments.Text = ""
        d1.Value = Now
        comments.Focus()

    End Sub
    Public Sub uf()
        Dim n As Integer = 0
        While Not n = u31.Rows.Count
            RC = u31.Rows(n)
            RC.BeginEdit()
            RC("qun") = 0
            RC.EndEdit()
            n = n + 1
        End While
    End Sub
    Private Sub brpd_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles brpd.CellContentClick

    End Sub

    Private Sub code_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles code.KeyDown
        
    End Sub

    Private Sub code_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles code.TextChanged

    End Sub
End Class