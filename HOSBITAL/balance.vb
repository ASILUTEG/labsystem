Public Class balance
    Dim cmdcom_main As New OleDb.OleDbCommand
    Dim adcom_main As New OleDb.OleDbDataAdapter
    Dim com_main As New DataTable
    Dim cmdcom_sub As New OleDb.OleDbCommand
    Dim adcom_sub As New OleDb.OleDbDataAdapter
    Dim com_sub As New DataTable

    Dim cmdtempr As New OleDb.OleDbCommand
    Dim adtempr As New OleDb.OleDbDataAdapter
    Dim tempr As New DataTable
    Dim cmdtempCASH As New OleDb.OleDbCommand
    Dim adtempCASH As New OleDb.OleDbDataAdapter
    Dim tempCASH As New DataTable
    Dim cmdtemp2 As New OleDb.OleDbCommand
    Dim adtemp2 As New OleDb.OleDbDataAdapter
    Dim temp2 As New DataTable
    Dim cmdEMP As New OleDb.OleDbCommand
    Dim adEMP As New OleDb.OleDbDataAdapter
    Dim EMP As New DataTable
    Dim ex As Int16
    Dim b1 As Int16

    Private Sub room_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox17.Text = "1/1/" & Now.Date.Year
        TextBox18.Text = Now.Date

        com_main.Clear()
        cmdcom_main.Connection = CN
        cmdcom_main.CommandType = CommandType.Text
        cmdcom_main.CommandText = "select * FROM com_main "
        adcom_main.SelectCommand = cmdcom_main
        adcom_main.Fill(DBS, "com_main")
        com_main = DBS.Tables("com_main")
        DBS.Tables("com_main").Clear()
        adcom_main.Fill(DBS, "com_main")
        com_main = DBS.Tables("com_main")
        com_main_name.DataSource = com_main
        com_main_name.DisplayMember = ("name")
        '===================================================
        EMP.Clear()
        cmdEMP.Connection = CN
        cmdEMP.CommandType = CommandType.Text
        cmdEMP.CommandText = "select * FROM EEMP "
        adEMP.SelectCommand = cmdEMP
        adEMP.Fill(DBS, "EMP")
        EMP = DBS.Tables("EMP")
        DBS.Tables("EMP").Clear()
        adEMP.Fill(DBS, "EMP")
        EMP = DBS.Tables("EMP")
        EMP_name.DataSource = EMP
        EMP_name.DisplayMember = ("name")
        '===================================================
        com_sub.Clear()
        cmdcom_sub.Connection = CN
        cmdcom_sub.CommandType = CommandType.Text
        cmdcom_sub.CommandText = "select * FROM com_sub "
        adcom_sub.SelectCommand = cmdcom_sub
        adcom_sub.Fill(DBS, "com_sub")
        com_sub = DBS.Tables("com_sub")
        DBS.Tables("com_sub").Clear()
        adcom_sub.Fill(DBS, "com_sub")
        com_sub = DBS.Tables("com_sub")
        com_sub_name.DataSource = com_sub
        com_sub_name.DisplayMember = ("name")
        '===================================================
        tempCASH.Clear()
        cmdtempCASH.Connection = CN
        cmdtempCASH.CommandType = CommandType.Text
        cmdtempCASH.CommandText = "select * FROM cash  where r=1 "
        adtempCASH.SelectCommand = cmdtempCASH
        adtempCASH.Fill(DBS, "tempCASH")
        tempCASH = DBS.Tables("tempCASH")
        DBS.Tables("tempCASH").Clear()
        adtempCASH.Fill(DBS, "tempCASH")
        tempCASH = DBS.Tables("tempCASH")
        DataGridView1.DataSource = tempCASH

        DataGridView1.Columns("com_sub_no").Visible = False
        DataGridView1.Columns("com_sub_code").Visible = False
        DataGridView1.Columns("com_sub_name").HeaderText = "‰Ê⁄ «·⁄„·Ì…"
        DataGridView1.Columns("com_sub_name").Width = 200
        DataGridView1.Columns("com_main_no").Visible = False
        DataGridView1.Columns("com_main_code").Visible = False
        DataGridView1.Columns("com_main_name").HeaderText = "«·⁄Ì«œ…"
        DataGridView1.Columns("com_main_name").Width = 200
        '===================================================


    End Sub



    Private Sub com_main_name_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles com_main_name.SelectedIndexChanged
        If com_main_name.Focused = False Then Exit Sub
        If com_main_name.Text = "" Then Exit Sub
        If ex = 1 Then Exit Sub
        FRC = com_main.Select("name='" & com_main_name.Text & "'")
        com_main_name.Text = ""
        com_main_code.Text = ""
        com_main_no.Text = ""
        If FRC.Length <= 0 Then
            MsgBox("«·—Ã«¡ «·«œŒ«·", MsgBoxStyle.Information)
            Exit Sub
        Else
            ex = 1
            RC = FRC(0)
            com_main_no.Text = RC(0)
            com_main_code.Text = RC(1)
            com_main_name.Text = RC(2)

            com_sub.Clear()
            cmdcom_sub.Connection = CN
            cmdcom_sub.CommandType = CommandType.Text
            cmdcom_sub.CommandText = "select * FROM com_sub WHERE M_CODE='" & com_main_code.Text & "'"
            adcom_sub.SelectCommand = cmdcom_sub
            adcom_sub.Fill(DBS, "com_sub")
            com_sub = DBS.Tables("com_sub")
            DBS.Tables("com_sub").Clear()
            adcom_sub.Fill(DBS, "com_sub")
            com_sub = DBS.Tables("com_sub")
            com_sub_name.DataSource = com_sub
            com_sub_name.DisplayMember = ("name")
            '===================================================
            ex = 0
        End If

    End Sub

    Private Sub com_main_no_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles com_main_no.KeyDown
        If e.KeyCode = Keys.Enter Then
            If com_main_no.Focused = False Then Exit Sub
            If com_main_no.Text = "" Then Exit Sub
            If ex = 1 Then Exit Sub
            FRC = com_main.Select("no='" & com_main_no.Text & "'")
            com_main_name.Text = ""
            com_main_code.Text = ""
            com_main_no.Text = ""
            If FRC.Length <= 0 Then
                MsgBox("«·—Ã«¡ «·«œŒ«·", MsgBoxStyle.Information)
                Exit Sub
            Else
                ex = 1
                RC = FRC(0)
                com_main_no.Text = RC(0)
                com_main_code.Text = RC(1)
                com_main_name.Text = RC(2)
                ex = 0
            End If

        End If
    End Sub






    Private Sub com_sub_name_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles com_sub_name.SelectedIndexChanged
        If com_sub_name.Focused = False Then Exit Sub
        If com_sub_name.Text = "" Then Exit Sub
        If ex = 1 Then Exit Sub
        FRC = com_sub.Select("name='" & com_sub_name.Text & "'")
        com_sub_name.Text = ""
        com_sub_code.Text = ""
        com_sub_no.Text = ""
        If FRC.Length <= 0 Then
            MsgBox("«·—Ã«¡ «·«œŒ«·", MsgBoxStyle.Information)
            Exit Sub
        Else
            ex = 1
            RC = FRC(0)
            com_sub_no.Text = RC(0)
            com_sub_code.Text = RC(1)
            com_sub_name.Text = RC(2)
            flg.Text = RC("flg")
            ex = 0
        End If
    End Sub

    Private Sub com_sub_no_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles com_sub_no.KeyDown
        If e.KeyCode = Keys.Enter Then
            If com_sub_no.Focused = False Then Exit Sub
            If com_sub_no.Text = "" Then Exit Sub
            If ex = 1 Then Exit Sub
            FRC = com_sub.Select("no='" & com_sub_no.Text & "'")
            com_sub_name.Text = ""
            com_sub_code.Text = ""
            com_sub_no.Text = ""
            If FRC.Length <= 0 Then
                MsgBox("«·—Ã«¡ «·«œŒ«·", MsgBoxStyle.Information)
                Exit Sub
            Else
                ex = 1
                RC = FRC(0)
                com_sub_no.Text = RC(0)
                com_sub_code.Text = RC(1)
                com_sub_name.Text = RC(2)
                ex = 0
            End If
        End If
    End Sub

    Private Sub com_sub_no_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles com_sub_no.TextChanged

    End Sub



    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        '==============================================================
        dr.Close() : cmd.CommandText = "SELECT MAX(ID) FROM cash "
        dr = cmd.ExecuteReader
        dr.Read()
        If IsDBNull(dr(0)) = True Then
            ID.Text = 1
        Else
            ID.Text = dr(0) + 1
        End If

        dr.Close()
        Dim D As Date = Now
        TIME1.Text = D.TimeOfDay.ToString
        DATE1.Text = D.Date.ToShortDateString
        tempCASH.Clear()
        cmdtempCASH.Connection = CN
        cmdtempCASH.CommandType = CommandType.Text
        cmdtempCASH.CommandText = "select * FROM cash where r=1"
        adtempCASH.SelectCommand = cmdtempCASH
        adtempCASH.Fill(DBS, "tempCASH")
        tempCASH = DBS.Tables("tempCASH")
        DBS.Tables("tempCASH").Clear()
        adtempCASH.Fill(DBS, "tempCASH")
        tempCASH = DBS.Tables("tempCASH")
        DataGridView1.DataSource = ""
        DataGridView1.DataSource = tempCASH

        DataGridView1.Columns("com_sub_no").Visible = False
        DataGridView1.Columns("com_sub_code").Visible = False
        DataGridView1.Columns("com_sub_name").HeaderText = "«·»‰œ «·—∆”Ï"
        DataGridView1.Columns("com_sub_name").Width = 200
        DataGridView1.Columns("com_main_no").Visible = False
        DataGridView1.Columns("com_main_code").Visible = False
        DataGridView1.Columns("com_main_name").HeaderText = "«·»‰œ"
        DataGridView1.Columns("com_main_name").Width = 200
        '===================================================
        crd.Text = 0
        dr.Close()
        tot.Focus()

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If Trim(com_sub_name.Text) = "" Or Trim(com_sub_code.Text) = "" Or IsNumeric(com_sub_no.Text) = False Then MsgBox("«·—Ã«¡ «· √ﬂœ ‰Ê⁄  «·⁄„·Ì…") : Exit Sub
        If Trim(com_main_name.Text) = "" Or Trim(com_main_code.Text) = "" Or IsNumeric(com_main_no.Text) = False Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·⁄Ì«œ…") : Exit Sub
        If Trim(EMP_name.Text) = "" Or Trim(EMP_CODE.Text) = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·„ÊŸ›") : Exit Sub

        If IsNumeric(tot.Text) = False Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·”⁄—") : Exit Sub
        : dr.Close() : cmd.CommandText = "select * from cash  where ID=" & ID.Text
        dr = cmd.ExecuteReader
        If dr.HasRows = True Then
            Dim x As String
            x = MsgBox("Â·  —Ìœ  ⁄œÌ·  ", MsgBoxStyle.YesNo)
            If x = vbNo Then dr.Close() : Exit Sub
            dr.Close() : dr.Close() : cmd.CommandText = "delete  from cash where ID=" & ID.Text
            cmd.ExecuteNonQuery()
        Else

        End If
        dr.Close() : dr.Close() : cmd.CommandText = "insert into cash (com_sub_name,com_sub_code,com_sub_no,com_main_name,com_main_code,com_main_no,ID,TOT,FLG,TIME1,DATE1,USR,SHIFT,NOTE1,cash,crd,EMP_CODE,EMP_NAME) values ('" & com_sub_name.Text & "','" & com_sub_code.Text & "','" & com_sub_no.Text & "','" & com_main_name.Text & "','" & com_main_code.Text & "','" & com_main_no.Text & "','" & ID.Text & "','" & tot.Text & "','" & flg.Text & "','" & TIME1.Text & "','" & ChangeFormat(DATE1.Text) & "','" & USR & "','" & SHF & "','" & NOTE.Text & "','" & CASH.Text & "','" & crd.Text & "','" & EMP_CODE.Text & "','" & EMP_name.Text & "' )"
        cmd.ExecuteNonQuery()
        Button8_Click(Button8, e)
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Dim yy As String = ""
        If RadioButton1.Checked = True Then

            yy = " where r=0 and date1 BETWEEN '" & ChangeFormat(TextBox17.Text) & "' AND '" & ChangeFormat(TextBox18.Text) & "' "
            If Not IsDate(TextBox17.Text) Or Not IsDate(TextBox18.Text) Then MsgBox("’Ì€… Œÿ√ ·· «—ÌŒ") : Exit Sub

        Else

            yy = " where r=1"
        End If

        If CheckBox1.Checked = True Then
            If com_main_code.Text = "" Then MsgBox("ÌÃ» «Œ Ì«— «·»‰œ") : Exit Sub
            If yy = "" Then yy = yy & " where com_main_code='" & com_main_code.Text & "'" Else yy = yy & " and com_main_code ='" & com_main_code.Text & "'"
        End If
        If CheckBox2.Checked = True Then
            If com_sub_code.Text = "" Then MsgBox("ÌÃ» «Œ Ì«— «·»‰œ") : Exit Sub
            If yy = "" Then yy = yy & " where com_sub_code='" & com_sub_code.Text & "'" Else yy = yy & " and com_sub_code ='" & com_sub_code.Text & "'"
        End If
        temp2.Clear()
        cmdtemp2.Connection = CN
        cmdtemp2.CommandType = CommandType.Text
        cmdtemp2.CommandText = "select * FROM cash " & yy
        adtemp2.SelectCommand = cmdtemp2
        adtemp2.Fill(DBS, "temp2")
        temp2 = DBS.Tables("temp2")
        DBS.Tables("temp2").Clear()
        adtemp2.Fill(DBS, "temp2")
        temp2 = DBS.Tables("temp2")
        '===================================================
        DataGridView1.DataSource = temp2
        Dim xx As Integer
        xx = MsgBox("Â·  —Ìœ ÿ»«⁄… «· ﬁ—Ì—", 1)
        If xx = 1 Then
            Dim oj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            oj.Load(Application.StartupPath & "\com pond.rpt")
            oj.SetDataSource(temp2)
            'oj.SetParameterValue("1", TextBox17.Text)
            'oj.SetParameterValue("2", TextBox18.Text)
            rp.CrystalReportViewer1.ReportSource = oj
            rp.CrystalReportViewer1.Refresh()
            rp.Show()
            Exit Sub
        End If

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If Trim(com_sub_name.Text) = "" Or Trim(com_sub_code.Text) = "" Or IsNumeric(com_sub_no.Text) = False Then MsgBox("«·—Ã«¡ «· √ﬂœ ‰Ê⁄  «·⁄„·Ì…") : Exit Sub
        If Trim(com_main_name.Text) = "" Or Trim(com_main_code.Text) = "" Or IsNumeric(com_main_no.Text) = False Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·⁄Ì«œ…") : Exit Sub
        dr.Close() : dr.Close() : cmd.CommandText = "select * from cash  where  ID='" & ID.Text & "' "
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            dr.Close()
            Dim x As String
            x = MsgBox("Â·  —Ìœ «·Õ–›", MsgBoxStyle.YesNo)
            If x = vbNo Then dr.Close() : Exit Sub
            dr.Close()
            dr.Close() : dr.Close() : cmd.CommandText = "delete from cash  where  ID='" & ID.Text & "' "
            cmd.ExecuteNonQuery()

            Button8_Click(Button8, e)
            MsgBox(" „  ⁄„·Ì… «·Õ–›")
        Else
            dr.Close()
        End If

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        On Error Resume Next
        EMP_name.Text = DataGridView1(("EMP_NAME"), e.RowIndex).Value
        EMP_CODE.Text = DataGridView1(("EMP_CODE"), e.RowIndex).Value
        com_main_no.Text = DataGridView1(("com_main_no"), e.RowIndex).Value
        com_main_code.Text = DataGridView1(("com_main_code"), e.RowIndex).Value
        com_main_name.Text = DataGridView1(("com_main_name"), e.RowIndex).Value
        com_sub_no.Text = DataGridView1(("com_sub_no"), e.RowIndex).Value
        com_sub_code.Text = DataGridView1(("com_sub_code"), e.RowIndex).Value
        com_sub_name.Text = DataGridView1(("com_sub_name"), e.RowIndex).Value
        ID.Text = DataGridView1(("ID"), e.RowIndex).Value
        tot.Text = DataGridView1(("tot"), e.RowIndex).Value
        CASH.Text = DataGridView1(("CASH"), e.RowIndex).Value
        TIME1.Text = DataGridView1(("TIME1"), e.RowIndex).Value
        DATE1.Text = DataGridView1(("DATE1"), e.RowIndex).Value
        NOTE.Text = DataGridView1(("NOTE1"), e.RowIndex).Value
        flg.Text = DataGridView1(("flg"), e.RowIndex).Value
        crd.Text = DataGridView1(("crd"), e.RowIndex).Value
    End Sub

    Private Sub emp_name_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Button7_Click(Button7, e)
        End If
    End Sub


    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Dim yy As String = ""
        If RadioButton1.Checked = True Then

            yy = " where r=0 and date1 BETWEEN '" & ChangeFormat(TextBox17.Text) & "' AND '" & ChangeFormat(TextBox18.Text) & "' "
            If Not IsDate(TextBox17.Text) Or Not IsDate(TextBox18.Text) Then MsgBox("’Ì€… Œÿ√ ·· «—ÌŒ") : Exit Sub

        Else

            yy = " where r=1"
        End If

        If CheckBox1.Checked = True Then
            If com_main_code.Text = "" Then MsgBox("ÌÃ» «Œ Ì«— «·»‰œ") : Exit Sub
            If yy = "" Then yy = yy & " where com_main_code='" & com_main_code.Text & "'" Else yy = yy & " and com_main_code ='" & com_main_code.Text & "'"
        End If
        If CheckBox2.Checked = True Then
            If com_sub_code.Text = "" Then MsgBox("ÌÃ» «Œ Ì«— «·»‰œ") : Exit Sub
            If yy = "" Then yy = yy & " where com_sub_code='" & com_sub_code.Text & "'" Else yy = yy & " and com_sub_code ='" & com_sub_code.Text & "'"
        End If
        temp2.Clear()
        cmdtemp2.Connection = CN
        cmdtemp2.CommandType = CommandType.Text
        cmdtemp2.CommandText = "select * FROM cash " & yy
        adtemp2.SelectCommand = cmdtemp2
        adtemp2.Fill(DBS, "temp2")
        temp2 = DBS.Tables("temp2")
        DBS.Tables("temp2").Clear()
        adtemp2.Fill(DBS, "temp2")
        temp2 = DBS.Tables("temp2")
        '===================================================
        DataGridView1.DataSource = temp2
        Dim xx As Integer
        xx = MsgBox("Â·  —Ìœ ÿ»«⁄… «· ﬁ—Ì—", 1)
        If xx = 1 Then
            Dim oj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            oj.Load(Application.StartupPath & "\cash.rpt")
            oj.SetDataSource(temp2)
            oj.SetParameterValue("1", TextBox17.Text)
            oj.SetParameterValue("2", TextBox18.Text)
            rp.CrystalReportViewer1.ReportSource = oj
            rp.CrystalReportViewer1.Refresh()
            rp.Show()
        End If
    End Sub


    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub pack_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pack.CheckedChanged
        If pack.Checked = False Then
            CASH.Text = 0
        Else
            CASH.Text = 1
        End If
    End Sub

    Private Sub pack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pack.Click
        If pack.Checked = False Then
            CASH.Text = 0
        Else
            CASH.Text = 1
        End If
    End Sub

    Private Sub norm_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles norm.CheckedChanged
        If pack.Checked = False Then
            CASH.Text = 0
        Else
            CASH.Text = 1
        End If
    End Sub

    Private Sub norm_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles norm.Click
        If pack.Checked = False Then
            CASH.Text = 0
        Else
            CASH.Text = 1
        End If
    End Sub

    Private Sub NOTE_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles NOTE.GotFocus
        NOTE.Text = ""
        For Each Lng As InputLanguage In InputLanguage.InstalledInputLanguages
            If Lng.Culture.DisplayName.ToUpper.StartsWith("AR") Then
                InputLanguage.CurrentInputLanguage = Lng
                Exit For
            End If
        Next
    End Sub

    Private Sub NOTE_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles NOTE.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button7_Click(Button7, e)
        End If
    End Sub

    Private Sub NOTE_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NOTE.TextChanged

    End Sub

    Private Sub tot_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tot.GotFocus
        tot.Text = ""
    End Sub

    Private Sub tot_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tot.KeyDown
        If e.KeyCode = Keys.Enter Then
            NOTE.Focus()
        End If
    End Sub

    Private Sub tot_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tot.TextChanged

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim yy As String = ""


        yy = " where r=0 and date1 BETWEEN '" & ChangeFormat(TextBox17.Text) & "' AND '" & ChangeFormat(TextBox18.Text) & "' "
        If Not IsDate(TextBox17.Text) Or Not IsDate(TextBox18.Text) Then MsgBox("’Ì€… Œÿ√ ·· «—ÌŒ") : Exit Sub


        If CheckBox1.Checked = True Then
            If com_main_code.Text = "" Then MsgBox("ÌÃ» «Œ Ì«— «·»‰œ") : Exit Sub
            If yy = "" Then yy = yy & " where com_main_code='" & com_main_code.Text & "'" Else yy = yy & " and com_main_code ='" & com_main_code.Text & "'"
        End If
        If CheckBox2.Checked = True Then
            If com_sub_code.Text = "" Then MsgBox("ÌÃ» «Œ Ì«— «·»‰œ") : Exit Sub
            If yy = "" Then yy = yy & " where com_sub_code='" & com_sub_code.Text & "'" Else yy = yy & " and com_sub_code ='" & com_sub_code.Text & "'"
        End If
        temp2.Clear()
        cmdtemp2.Connection = CN
        cmdtemp2.CommandType = CommandType.Text
        cmdtemp2.CommandText = "select com_main_name,com_sub_name,shift,sum(tot)as tot,sum(crd)as crd,flg FROM cash " & yy & " group by  com_main_name,com_sub_name,shift,flg"
        adtemp2.SelectCommand = cmdtemp2
        adtemp2.Fill(DBS, "temp2")
        temp2 = DBS.Tables("temp2")
        DBS.Tables("temp2").Clear()
        adtemp2.Fill(DBS, "temp2")
        temp2 = DBS.Tables("temp2")
        '===================================================

        Dim xx As Integer
        xx = MsgBox("Â·  —Ìœ ÿ»«⁄… «· ﬁ—Ì—", 1)
        If xx = 1 Then
            Dim oj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            oj.Load(Application.StartupPath & "\cashg.rpt")
            oj.SetDataSource(temp2)
            oj.SetParameterValue("1", TextBox17.Text)
            oj.SetParameterValue("2", TextBox18.Text)
            rp.CrystalReportViewer1.ReportSource = oj
            rp.CrystalReportViewer1.Refresh()
            rp.Show()
        End If
    End Sub

    Private Sub  ﬁ—Ì—«·‘› ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles  ﬁ—Ì—«·‘› ToolStripMenuItem.Click
        Dim yy As String = ""
        TextBox17.Text = TextBox18.Text

        yy = " where r=1"

        If CheckBox1.Checked = True Then
            If com_main_code.Text = "" Then MsgBox("ÌÃ» «Œ Ì«— «·»‰œ") : Exit Sub
            If yy = "" Then yy = yy & " where com_main_code='" & com_main_code.Text & "'" Else yy = yy & " and com_main_code ='" & com_main_code.Text & "'"
        End If
        If CheckBox2.Checked = True Then
            If com_sub_code.Text = "" Then MsgBox("ÌÃ» «Œ Ì«— «·»‰œ") : Exit Sub
            If yy = "" Then yy = yy & " where com_sub_code='" & com_sub_code.Text & "'" Else yy = yy & " and com_sub_code ='" & com_sub_code.Text & "'"
        End If
        temp2.Clear()
        cmdtemp2.Connection = CN
        cmdtemp2.CommandType = CommandType.Text
        cmdtemp2.CommandText = "select * FROM cash " & yy
        adtemp2.SelectCommand = cmdtemp2
        adtemp2.Fill(DBS, "temp2")
        temp2 = DBS.Tables("temp2")
        DBS.Tables("temp2").Clear()
        adtemp2.Fill(DBS, "temp2")
        temp2 = DBS.Tables("temp2")
        '===================================================



        Dim oj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        oj.Load(Application.StartupPath & "\cash.rpt")
        oj.SetDataSource(temp2)
        oj.SetParameterValue("1", TextBox17.Text)
        oj.SetParameterValue("2", TextBox18.Text)
        rp.CrystalReportViewer1.ReportSource = oj
        rp.CrystalReportViewer1.Refresh()
        rp.Show()

    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click



    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Dim yy As String = ""


        yy = " where r=0 and date1 BETWEEN '" & ChangeFormat(TextBox17.Text) & "' AND '" & ChangeFormat(TextBox18.Text) & "' "
        If Not IsDate(TextBox17.Text) Or Not IsDate(TextBox18.Text) Then MsgBox("’Ì€… Œÿ√ ·· «—ÌŒ") : Exit Sub


        If CheckBox1.Checked = True Then
            If com_main_code.Text = "" Then MsgBox("ÌÃ» «Œ Ì«— «·»‰œ") : Exit Sub
            If yy = "" Then yy = yy & " where com_main_code='" & com_main_code.Text & "'" Else yy = yy & " and com_main_code ='" & com_main_code.Text & "'"
        End If
        If CheckBox2.Checked = True Then
            If com_sub_code.Text = "" Then MsgBox("ÌÃ» «Œ Ì«— «·»‰œ") : Exit Sub
            If yy = "" Then yy = yy & " where com_sub_code='" & com_sub_code.Text & "'" Else yy = yy & " and com_sub_code ='" & com_sub_code.Text & "'"
        End If
        temp2.Clear()
        cmdtemp2.Connection = CN
        cmdtemp2.CommandType = CommandType.Text
        cmdtemp2.CommandText = "select com_main_name,com_sub_name,sum(tot)as tot,sum(crd)as crd,flg FROM cash " & yy & " group by  com_main_name,com_sub_name,flg"
        adtemp2.SelectCommand = cmdtemp2
        adtemp2.Fill(DBS, "temp2")
        temp2 = DBS.Tables("temp2")
        DBS.Tables("temp2").Clear()
        adtemp2.Fill(DBS, "temp2")
        temp2 = DBS.Tables("temp2")
        '===================================================

        Dim xx As Integer
        xx = MsgBox("Â·  —Ìœ ÿ»«⁄… «· ﬁ—Ì—", 1)
        If xx = 1 Then
            Dim oj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            oj.Load(Application.StartupPath & "\casha.rpt")
            oj.SetDataSource(temp2)
            oj.SetParameterValue("1", TextBox17.Text)
            oj.SetParameterValue("2", TextBox18.Text)
            rp.CrystalReportViewer1.ReportSource = oj
            rp.CrystalReportViewer1.Refresh()
            rp.Show()
        End If
    End Sub

    Private Sub EMP_name_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles EMP_name.KeyUp

        Dim n As String
        If e.KeyCode = Keys.Enter Then
            ''If SV = 0 Then
            ''    MsgBox("·Ì”  ·œÌﬂ «·’·«ÕÌ…")
            ''    dr.Close()
            ''    cmd.CommandText = "insert into llog (usr,note,date1,time1,gr) values ('" & USR & "','„Õ«Ê·…  Œ“Ì‰ ÿ»Ì» „⁄ ⁄œ„ «„ ·«ﬂ ’·«ÕÌ…','" & ChangeFormat(Now.Date) & "','" & Now.Hour & "-" & Now.Minute & "-" & Now.Second & "','„Õ«Ê·… «Œ —«ﬁ')"
            ''    cmd.ExecuteNonQuery()
            ''    Exit Sub
            ''End If
            n = ""
            n = MsgBox(" Â·  —Ìœ «·Õ›Ÿ ø", MsgBoxStyle.YesNo)
            If n = vbNo Then Exit Sub
            dr.Close() : cmd.CommandText = "select MAx(code) from eemp "
            dr = cmd.ExecuteReader
            dr.Read()
            If IsDBNull(dr(0)) = False Then
                EMP_CODE.Text = 1 + dr(0)
            Else
                EMP_CODE.Text = 1
            End If

            If EMP_name.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
            dr.Close()
            cmd.CommandText = "select * from eemp where   name='" & EMP_name.Text & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                'If ED = 0 Then
                '    MsgBox("·Ì”  ·œÌﬂ «·’·«ÕÌ…")
                '    dr.Close()
                '    cmd.CommandText = "insert into llog (usr,note,date1,time1,gr) values ('" & USR & "','„Õ«Ê·…  ⁄œÌ· «·ÿ»Ì» „⁄ ⁄œ„ «„ ·«ﬂ ’·«ÕÌ…','" & ChangeFormat(Now.Date) & "','" & Now.Hour & "-" & Now.Minute & "-" & Now.Second & "','„Õ«Ê·… «Œ —«ﬁ')"
                '    cmd.ExecuteNonQuery()
                '    Exit Sub
                'End If
                n = ""
                n = MsgBox(" Â·  —Ìœ «· ⁄œÌ· ø", MsgBoxStyle.YesNo)
                If n = vbNo Then Exit Sub
                dr.Close()
                cmd.CommandText = "delete from eemp where    name='" & EMP_name.Text & "'"
                cmd.ExecuteNonQuery()
                dr.Close()
                'cmd.CommandText = "insert into llog (usr,note,date1,time1,gr) values ('" & USR & "',' „  ⁄„·Ì…   ⁄œÌ· «·ÿ»Ì» »‰Ã«Õ','" & ChangeFormat(Now.Date) & "','" & Now.Hour & "-" & Now.Minute & "-" & Now.Second & "','⁄„·Ì… ‰«ÃÕ…')"
                'cmd.ExecuteNonQuery()
            Else
                'dr.Close()
                'cmd.CommandText = "insert into llog (usr,note,date1,time1,gr) values ('" & USR & "',' „  ⁄„·Ì…   Œ“Ì‰ «·ÿ»Ì» »‰Ã«Õ','" & ChangeFormat(Now.Date) & "','" & Now.Hour & "-" & Now.Minute & "-" & Now.Second & "','⁄„·Ì… ‰«ÃÕ…')"
                'cmd.ExecuteNonQuery()
            End If

            dr.Close() : cmd.CommandText = "insert into eemp (code,name)  values ('" & EMP_CODE.Text & "','" & EMP_name.Text & "')"
            cmd.ExecuteNonQuery()
            cmdEMP.Connection = CN
            cmdEMP.CommandType = CommandType.Text
            cmdEMP.CommandText = "select * from eemp"
            adEMP.SelectCommand = cmdEMP
            adEMP.Fill(DBS, "emp")
            EMP = DBS.Tables("emp")
            DBS.Tables("emp").Clear()
            adEMP.Fill(DBS, "emp")
            EMP = DBS.Tables("emp")
            EMP_name.DataSource = EMP
            EMP_name.DisplayMember = "NAME"
            Exit Sub
        End If
        If e.KeyCode = Keys.Delete Then
            ''If DEL = 0 Then
            ''    MsgBox("·Ì”  ·œÌﬂ «·’·«ÕÌ…")
            ''    dr.Close()
            ''    cmd.CommandText = "insert into llog (usr,note,date1,time1,gr) values ('" & USR & "','„Õ«Ê·… Õ–›  «·ÿ»Ì» " & emp_name.Text & " „⁄ ⁄œ„ «„ ·«ﬂ ’·«ÕÌ…','" & ChangeFormat(Now.Date) & "','" & Now.Hour & "-" & Now.Minute & "-" & Now.Second & "','„Õ«Ê·… «Œ —«ﬁ')"
            ''    cmd.ExecuteNonQuery()
            ''    Exit Sub
            ''End If

            n = MsgBox(" Â·  —Ìœ «·Õ–› ø", MsgBoxStyle.YesNo)
            If IsNumeric(EMP_CODE.Text) = False Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·ﬂÊœ") : Exit Sub
            If EMP_name.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
            dr.Close()
            cmd.CommandText = "select * from eemp where   name='" & EMP_name.Text & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                dr.Close()
                cmd.CommandText = "delete from eemp where    name='" & EMP_name.Text & "'"
                cmd.ExecuteNonQuery()

            End If
            cmdEMP.Connection = CN
            cmdEMP.CommandType = CommandType.Text
            cmdEMP.CommandText = "select * from eemp"
            adEMP.SelectCommand = cmdEMP
            adEMP.Fill(DBS, "emp")
            EMP = DBS.Tables("emp")
            DBS.Tables("emp").Clear()
            adEMP.Fill(DBS, "emp")
            EMP = DBS.Tables("emp")
            EMP_name.DataSource = EMP
            EMP_name.DisplayMember = "NAME"
            dr.Close()
            ''cmd.CommandText = "insert into llog (usr,note,date1,time1,gr) values ('" & USR & "','   „  ⁄„·Ì…  Õ–› «·ÿ»Ì» " & EMP_name.Text & " »‰Ã«Õ','" & ChangeFormat(Now.Date) & "','" & Now.Hour & "-" & Now.Minute & "-" & Now.Second & "','⁄„·Ì… ‰«ÃÕ…')"
            ''cmd.ExecuteNonQuery()
            Exit Sub
        End If



        tempr.Clear()
        cmdtempr.Connection = CN
        cmdtempr.CommandType = CommandType.Text
        cmdtempr.CommandText = "select * FROM EEMP where name like '%" & EMP_name.Text & "%'"
        adtempr.SelectCommand = cmdtempr
        adtempr.Fill(DBS, "tempr")
        tempr = DBS.Tables("tempr")
        DBS.Tables("tempr").Clear()
        adtempr.Fill(DBS, "tempr")
        tempr = DBS.Tables("tempr")
        DataGridView2.DataSource = tempr
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EMP_name.SelectedIndexChanged

    End Sub

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub DataGridView2_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView2.CellMouseDoubleClick
        EMP_name.Text = DataGridView2(("name"), e.RowIndex).Value
        EMP_CODE.Text = DataGridView2(("CODE"), e.RowIndex).Value
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        dr1.Close()
        dr.Close()
        dr1.Close() : cmd1.CommandText = "select *   FROM   t_esl "
        dr1 = cmd1.ExecuteReader
        'If dr1.HasRows = False Then MsgBox("·« ÌÊÃœ »Ì«‰«  ") : dr1.Close() : Exit Sub
        While dr1.Read = True
            dr.Close() : cmd.CommandText = "insert into esl (usr,tim,esl_no,esl_gr,sick_c,sick_n,sick_no,sup_n,reg_n,dur_n,plac_n,spec_c,spec_n,doc_c,doc_n,eada_c,eada_n,pay,tot,lag,box,e_date,rm,gr_n,MACH,sex,qun,cah,crd,p_dis,p_add,req,cah_req,crd_req,sup_c,gr_c,dur_c,plac_c,esl_go,reg_c,doc_dis,esl_no_rm,rm_tot,rm_time ,rm_user ,rm_note ,rm_date,DIS1,ADD1,t_doc,m_sub,n_id,bon,tel,doc_type)  values ('" & dr1("usr") & "' , '" & dr1("tim") & "' , '" & dr1("esl_no") & "' , '" & Trim(dr1("esl_gr")) & "' ,'" & dr1("sick_c") & "' , '" & dr1("sick_n") & "' , '" & dr1("sick_no") & "' , '" & dr1("sup_n") & "' , '" & dr1("reg_n") & "' , '" & dr1("dur_n") & "' , '" & dr1("plac_n") & "' , '" & dr1("spec_c") & "' , '" & dr1("spec_n") & "' , '" & dr1("doc_c") & "' , '" & dr1("doc_n") & "' , '" & dr1("eada_c") & "' , '" & dr1("eada_n") & "' , '" & dr1("pay") & "' , '" & dr1("tot") & "' , '" & dr1("lag") & "' , '" & dr1("box") & "' , '" & ChangeFormat(dr1("e_date")) & "' , '" & dr1("rm") & "' , '" & dr1("gr_n") & "' , '" & dr1("mach") & "' , '" & dr1("sex") & "' , '" & dr1("qun") & "' , '" & dr1("cah") & "' , '" & dr1("crd") & "' , '" & dr1("p_dis") & "' , '" & dr1("p_add") & "' , '" & dr1("req") & "' , '" & dr1("cah_req") & "' , '" & dr1("crd_req") & "' , '" & dr1("sup_c") & "' , '" & dr1("gr_c") & "' , '" & dr1("dur_c") & "' , '" & dr1("plac_c") & "' , '" & Trim(dr1("esl_go")) & "' , '" & dr1("reg_c") & "' , '" & dr1("doc_dis") & "' , '" & dr1("esl_no_rm") & "' , '" & dr1("rm_tot") & "' , '" & dr1("rm_time") & "' , '" & dr1("rm_user") & "' , '" & dr1("rm_note") & "' , '" & dr1("rm_date") & "', '" & dr1("DIS1") & "', '" & dr1("ADD1") & "', '" & dr1("t_doc") & "', '" & dr1("m_sub") & "', '" & dr1("n_id") & "', '" & dr1("bon") & "', '" & dr1("tel") & "', '" & dr1("doc_type") & "')"
            cmd.ExecuteNonQuery()
        End While
        dr1.Close()


        dr1.Close() : cmd1.CommandText = "select *   FROM   t_esl_price "
        dr1 = cmd1.ExecuteReader
        While dr1.Read = True
            dr.Close() : cmd.CommandText = "insert into esl_price (usr,tim,esl_gr,sick_c,sick_n,sick_no,pay,lag,box,e_date,cah_req,esl_go,doc_dis)  values ('" & dr1("usr") & "' , '" & dr1("tim") & "' , '" & Trim(dr1("esl_gr")) & "' ,'" & dr1("sick_c") & "' , '" & dr1("sick_n") & "' , '" & dr1("sick_no") & "' , '" & dr1("pay") & "' , '" & dr1("lag") & "' , '" & dr1("box") & "' , '" & ChangeFormat(dr1("e_date")) & "' , '" & dr1("cah_req") & "' , '" & Trim(dr1("esl_go")) & "' , " & dr1("doc_dis") & ")"
            cmd.ExecuteNonQuery()
        End While
        dr1.Close()

        dr1.Close() : cmd1.CommandText = "select *   FROM   t_esl_dis "
        dr1 = cmd1.ExecuteReader
        While dr1.Read = True
            dr.Close() : cmd.CommandText = "insert into esl_dis (usr,tim,esl_no,esl_gr,esl_go,sick_c,sick_n,sick_no,sup_n,reg_n,dur_n,plac_n,spec_c,spec_n,doc_c,doc_n,eada_c,eada_n,pay,tot,lag,box,e_date,rm,gr_n,MACH,sex,reg_c,sup_c,gr_c,dur_c,plac_c,qun,cah,crd,p_dis,p_add,req,cah_req,crd_req,per,doc_dis,min_,t_doc,m_sub,n_id,bon,dis1)  values ('" & dr1("usr") & "' , '" & dr1("tim") & "' , '" & dr1("esl_no") & "' , '" & Trim(dr1("esl_gr")) & "' , '" & Trim(dr1("esl_go")) & "' , '" & dr1("sick_c") & "' , '" & dr1("sick_n") & "' , '" & dr1("sick_no") & "' , '" & dr1("sup_n") & "' , '" & dr1("reg_n") & "' , '" & dr1("dur_n") & "' , '" & dr1("plac_n") & "' , '" & dr1("spec_c") & "' , '" & dr1("spec_n") & "' , '" & dr1("doc_c") & "' , '" & dr1("doc_n") & "' , '" & dr1("eada_c") & "' , '" & dr1("eada_n") & "' , '" & dr1("pay") & "' , '" & dr1("tot") & "' , '" & dr1("lag") & "' , '" & dr1("box") & "' , '" & ChangeFormat(dr1("e_date")) & "' , '" & dr1("rm") & "' , '" & dr1("gr_n") & "' , '" & dr1("mach") & "' , '" & dr1("sex") & "' , '" & dr1("reg_c") & "' , '" & dr1("sup_c") & "' , '" & dr1("gr_c") & "' , '" & dr1("dur_c") & "' , '" & dr1("plac_c") & "' , '" & dr1("qun") & "' , '" & dr1("cah") & "' , '" & dr1("crd") & "' , '" & dr1("p_dis") & "' , '" & dr1("p_add") & "' , '" & dr1("req") & "' , '" & dr1("cah_req") & "' , '" & dr1("crd_req") & "' , '" & dr1("per") & "' , " & dr1("doc_dis") & " , " & dr1("min_") & ", '" & dr1("t_doc") & "', '" & dr1("m_sub") & "', '" & dr1("n_id") & "', '" & dr1("bon") & "', '" & dr1("dis1") & "')"
            cmd.ExecuteNonQuery()
        End While
        dr1.Close()
        cmd.CommandText = "update lab_esl_tot set r=0"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "update cash set r=0"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "update stoc_trans2012 set r=0"
        cmd.ExecuteNonQuery()

        'dr1.close() : cmd1.CommandText = "select *   FROM   esl_dis_del "
        'dr1 = cmd1.ExecuteReader
        'While dr1.Read = True
        '    dr.Close() : cmd.CommandText = "insert into esl_dis_del (pers,pers_date,usr,tim,esl_no,esl_gr,esl_go,sick_c,sick_n,sick_no,sup_n,reg_n,dur_n,plac_n,spec_c,spec_n,doc_c,doc_n,eada_c,eada_n,pay,tot,lag,box,e_date,rm,gr_n,MACH,sex,reg_c,sup_c,gr_c,dur_c,plac_c,qun,cah,crd,p_dis,p_add,req,cah_req,crd_req,per,doc_dis,min_)  values (  '" & dr1("pers") & "', '" & ChangeFormat(dr1("pers_date")) & "','" & dr1("usr") & "' , '" & dr1("tim") & "' , '" & dr1("esl_no") & "' , '" & Trim(dr1("esl_gr")) & "' , '" & Trim(dr1("esl_go")) & "' , '" & dr1("sick_c") & "' , '" & dr1("sick_n") & "' , '" & dr1("sick_no") & "' , '" & dr1("sup_n") & "' , '" & dr1("reg_n") & "' , '" & dr1("dur_n") & "' , '" & dr1("plac_n") & "' , '" & dr1("spec_c") & "' , '" & dr1("spec_n") & "' , '" & dr1("doc_c") & "' , '" & dr1("doc_n") & "' , '" & dr1("eada_c") & "' , '" & dr1("eada_n") & "' , '" & dr1("pay") & "' , '" & dr1("tot") & "' , '" & dr1("lag") & "' , '" & dr1("box") & "' , '" & ChangeFormat(dr1("e_date")) & "' , '" & dr1("rm") & "' , '" & dr1("gr_n") & "' , '" & dr1("mach") & "' , '" & dr1("sex") & "' , '" & dr1("reg_c") & "' , '" & dr1("sup_c") & "' , '" & dr1("gr_c") & "' , '" & dr1("dur_c") & "' , '" & dr1("plac_c") & "' , '" & dr1("qun") & "' , '" & dr1("cah") & "' , '" & dr1("crd") & "' , '" & dr1("p_dis") & "' , '" & dr1("p_add") & "' , '" & dr1("req") & "' , '" & dr1("cah_req") & "' , '" & dr1("crd_req") & "' , '" & dr1("per") & "' , " & dr1("doc_dis") & " , " & dr1("min_") & ")"
        '    cmd.ExecuteNonQuery()
        'End While
        'dr1.Close()
        'dr1.close() : cmd1.CommandText = "select *   FROM   esl_dis_edit " 
        'dr1 = cmd1.ExecuteReader
        'While dr1.Read = True
        '    dr.Close() : cmd.CommandText = "insert into els_dis_edit (typ,pers,pers_date,usr,tim,esl_no,esl_gr,esl_go,sick_c,sick_n,sick_no,sup_n,reg_n,dur_n,plac_n,spec_c,spec_n,doc_c,doc_n,eada_c,eada_n,pay,tot,lag,box,e_date,rm,gr_n,MACH,sex,reg_c,sup_c,gr_c,dur_c,plac_c,qun,cah,crd,p_dis,p_add,req,cah_req,crd_req,per,doc_dis,min_,t_doc,m_sub,n_id)  values ( '" & dr1("typ") & "', '" & dr1("pers") & "', '" & ChangeFormat(dr1("pers_date")) & "','" & dr1("usr") & "' , '" & dr1("tim") & "' , '" & dr1("esl_no") & "' , '" & Trim(dr1("esl_gr")) & "' , '" & Trim(dr1("esl_go")) & "' , '" & dr1("sick_c") & "' , '" & dr1("sick_n") & "' , '" & dr1("sick_no") & "' , '" & dr1("sup_n") & "' , '" & dr1("reg_n") & "' , '" & dr1("dur_n") & "' , '" & dr1("plac_n") & "' , '" & dr1("spec_c") & "' , '" & dr1("spec_n") & "' , '" & dr1("doc_c") & "' , '" & dr1("doc_n") & "' , '" & dr1("eada_c") & "' , '" & dr1("eada_n") & "' , '" & dr1("pay") & "' , '" & dr1("tot") & "' , '" & dr1("lag") & "' , '" & dr1("box") & "' , '" & ChangeFormat(dr1("e_date")) & "' , '" & dr1("rm") & "' , '" & dr1("gr_n") & "' , '" & dr1("mach") & "' , '" & dr1("sex") & "' , '" & dr1("reg_c") & "' , '" & dr1("sup_c") & "' , '" & dr1("gr_c") & "' , '" & dr1("dur_c") & "' , '" & dr1("plac_c") & "' , '" & dr1("qun") & "' , '" & dr1("cah") & "' , '" & dr1("crd") & "' , '" & dr1("p_dis") & "' , '" & dr1("p_add") & "' , '" & dr1("req") & "' , '" & dr1("cah_req") & "' , '" & dr1("crd_req") & "' , '" & dr1("per") & "' , " & dr1("doc_dis") & " , " & dr1("min_") & ", '" & dr1("t_doc") & "', '" & dr1("m_sub") & "', '" & dr1("n_id") & "')"
        '    cmd.ExecuteNonQuery()
        'End While
        'dr1.Close()
        'dr1.close() : cmd1.CommandText = "select *   FROM   esl_dis_rd "
        'dr1 = cmd1.ExecuteReader
        'While dr1.Read = True
        '    dr.close() : cmd.CommandText = "insert into esl_dis_rd (typ,pers,pers_date,usr,tim,esl_no,esl_gr,esl_go,sick_c,sick_n,sick_no,sup_n,reg_n,dur_n,plac_n,spec_c,spec_n,doc_c,doc_n,eada_c,eada_n,pay,tot,lag,box,e_date,rm,gr_n,MACH,sex,reg_c,sup_c,gr_c,dur_c,plac_c,qun,cah,crd,p_dis,p_add,req,cah_req,crd_req,per,doc_dis,min_)  values ( '" & dr1("typ") & "', '" & dr1("pers") & "', '" & ChangeFormat(dr1("pers_date")) & "','" & dr1("usr") & "' , '" & dr1("tim") & "' , '" & dr1("esl_no") & "' , '" & Trim(dr1("esl_gr")) & "' , '" & Trim(dr1("esl_go")) & "' , '" & dr1("sick_c") & "' , '" & dr1("sick_n") & "' , '" & dr1("sick_no") & "' , '" & dr1("sup_n") & "' , '" & dr1("reg_n") & "' , '" & dr1("dur_n") & "' , '" & dr1("plac_n") & "' , '" & dr1("spec_c") & "' , '" & dr1("spec_n") & "' , '" & dr1("doc_c") & "' , '" & dr1("doc_n") & "' , '" & dr1("eada_c") & "' , '" & dr1("eada_n") & "' , '" & dr1("pay") & "' , '" & dr1("tot") & "' , '" & dr1("lag") & "' , '" & dr1("box") & "' , '" & ChangeFormat(dr1("e_date")) & "' , '" & dr1("rm") & "' , '" & dr1("gr_n") & "' , '" & dr1("mach") & "' , '" & dr1("sex") & "' , '" & dr1("reg_c") & "' , '" & dr1("sup_c") & "' , '" & dr1("gr_c") & "' , '" & dr1("dur_c") & "' , '" & dr1("plac_c") & "' , '" & dr1("qun") & "' , '" & dr1("cah") & "' , '" & dr1("crd") & "' , '" & dr1("p_dis") & "' , '" & dr1("p_add") & "' , '" & dr1("req") & "' , '" & dr1("cah_req") & "' , '" & dr1("crd_req") & "' , '" & dr1("per") & "' , " & dr1("doc_dis") & " , " & dr1("min_") & ")"
        '    cmd.ExecuteNonQuery()
        'End While
        'dr1.Close()
        'dr1.close() : cmd1.CommandText = "select *   FROM   esl_edit "
        'dr1 = cmd1.ExecuteReader
        'While dr1.Read = True
        '    dr.Close() : cmd.CommandText = "insert into esl_edit (usr,tim,esl_no,esl_gr,sick_c,sick_n,sick_no,sup_n,reg_n,dur_n,plac_n,spec_c,spec_n,doc_c,doc_n,eada_c,eada_n,pay,tot,lag,box,e_date,rm,gr_n,MACH,sex,qun,cah,crd,p_dis,p_add,req,cah_req,crd_req,sup_c,gr_c,dur_c,plac_c,esl_go,reg_c,doc_dis,esl_no_rm,rm_tot,rm_time ,rm_user ,rm_note ,rm_date,DIS1,ADD1,t_doc,m_sub,n_id,bon)  values ('" & dr1("usr") & "' , '" & dr1("tim") & "' , '" & dr1("esl_no") & "' , '" & Trim(dr1("esl_gr")) & "' ,'" & dr1("sick_c") & "' , '" & dr1("sick_n") & "' , '" & dr1("sick_no") & "' , '" & dr1("sup_n") & "' , '" & dr1("reg_n") & "' , '" & dr1("dur_n") & "' , '" & dr1("plac_n") & "' , '" & dr1("spec_c") & "' , '" & dr1("spec_n") & "' , '" & dr1("doc_c") & "' , '" & dr1("doc_n") & "' , '" & dr1("eada_c") & "' , '" & dr1("eada_n") & "' , '" & dr1("pay") & "' , '" & dr1("tot") & "' , '" & dr1("lag") & "' , '" & dr1("box") & "' , '" & ChangeFormat(dr1("e_date")) & "' , '" & dr1("rm") & "' , '" & dr1("gr_n") & "' , '" & dr1("mach") & "' , '" & dr1("sex") & "' , '" & dr1("qun") & "' , '" & dr1("cah") & "' , '" & dr1("crd") & "' , '" & dr1("p_dis") & "' , '" & dr1("p_add") & "' , '" & dr1("req") & "' , '" & dr1("cah_req") & "' , '" & dr1("crd_req") & "' , '" & dr1("sup_c") & "' , '" & dr1("gr_c") & "' , '" & dr1("dur_c") & "' , '" & dr1("plac_c") & "' , '" & Trim(dr1("esl_go")) & "' , '" & dr1("reg_c") & "' , '" & dr1("doc_dis") & "' , '" & dr1("esl_no_rm") & "' , '" & dr1("rm_tot") & "' , '" & dr1("rm_time") & "' , '" & dr1("rm_user") & "' , '" & dr1("rm_note") & "' , '" & dr1("rm_date") & "', '" & dr1("DIS1") & "', '" & dr1("ADD1") & "', '" & dr1("t_doc") & "', '" & dr1("m_sub") & "', '" & dr1("n_id") & "', '" & dr1("bon") & "')"
        '    cmd.ExecuteNonQuery()
        'End While
        'dr1.Close()
        'dr1.close() : cmd1.CommandText = "select *   FROM   esl_del "
        'dr1 = cmd1.ExecuteReader
        'While dr1.Read = True
        '    dr.close() : cmd.CommandText = "insert into esl_del (usr,tim,esl_no,esl_gr,sick_c,sick_n,sick_no,sup_n,reg_n,dur_n,plac_n,spec_c,spec_n,doc_c,doc_n,eada_c,eada_n,pay,tot,lag,box,e_date,rm,gr_n,MACH,sex,qun,cah,crd,p_dis,p_add,req,cah_req,crd_req,sup_c,gr_c,dur_c,plac_c,esl_go,reg_c,doc_dis,esl_no_rm,rm_tot,rm_time ,rm_user ,rm_note ,rm_date,DIS1,ADD1)  values ('" & dr1("usr") & "' , '" & dr1("tim") & "' , '" & dr1("esl_no") & "' , '" & Trim(dr1("esl_gr")) & "' ,'" & dr1("sick_c") & "' , '" & dr1("sick_n") & "' , '" & dr1("sick_no") & "' , '" & dr1("sup_n") & "' , '" & dr1("reg_n") & "' , '" & dr1("dur_n") & "' , '" & dr1("plac_n") & "' , '" & dr1("spec_c") & "' , '" & dr1("spec_n") & "' , '" & dr1("doc_c") & "' , '" & dr1("doc_n") & "' , '" & dr1("eada_c") & "' , '" & dr1("eada_n") & "' , '" & dr1("pay") & "' , '" & dr1("tot") & "' , '" & dr1("lag") & "' , '" & dr1("box") & "' , '" & ChangeFormat(dr1("e_date")) & "' , '" & dr1("rm") & "' , '" & dr1("gr_n") & "' , '" & dr1("mach") & "' , '" & dr1("sex") & "' , '" & dr1("qun") & "' , '" & dr1("cah") & "' , '" & dr1("crd") & "' , '" & dr1("p_dis") & "' , '" & dr1("p_add") & "' , '" & dr1("req") & "' , '" & dr1("cah_req") & "' , '" & dr1("crd_req") & "' , '" & dr1("sup_c") & "' , '" & dr1("gr_c") & "' , '" & dr1("dur_c") & "' , '" & dr1("plac_c") & "' , '" & Trim(dr1("esl_go")) & "' , '" & dr1("reg_c") & "' , '" & dr1("doc_dis") & "' , '" & dr1("esl_no_rm") & "' , '" & dr1("rm_tot") & "' , '" & dr1("rm_time") & "' , '" & dr1("rm_user") & "' , '" & dr1("rm_note") & "' , '" & dr1("rm_date") & "', '" & dr1("DIS1") & "', '" & dr1("ADD1") & "')"
        '    cmd.ExecuteNonQuery()
        'End While
        'dr1.Close()
        'dr1.close() : cmd1.CommandText = "select *   FROM   esl_rd "
        'dr1 = cmd1.ExecuteReader
        'While dr1.Read = True
        '    dr.close() : cmd.CommandText = "insert into esl_rd (usr,tim,esl_no,esl_gr,sick_c,sick_n,sick_no,sup_n,reg_n,dur_n,plac_n,spec_c,spec_n,doc_c,doc_n,eada_c,eada_n,pay,tot,lag,box,e_date,rm,gr_n,MACH,sex,qun,cah,crd,p_dis,p_add,req,cah_req,crd_req,sup_c,gr_c,dur_c,plac_c,esl_go,reg_c,doc_dis,esl_no_rm,rm_tot,rm_time ,rm_user ,rm_note ,rm_date,DIS1,ADD1)  values ('" & dr1("usr") & "' , '" & dr1("tim") & "' , '" & dr1("esl_no") & "' , '" & Trim(dr1("esl_gr")) & "' ,'" & dr1("sick_c") & "' , '" & dr1("sick_n") & "' , '" & dr1("sick_no") & "' , '" & dr1("sup_n") & "' , '" & dr1("reg_n") & "' , '" & dr1("dur_n") & "' , '" & dr1("plac_n") & "' , '" & dr1("spec_c") & "' , '" & dr1("spec_n") & "' , '" & dr1("doc_c") & "' , '" & dr1("doc_n") & "' , '" & dr1("eada_c") & "' , '" & dr1("eada_n") & "' , '" & dr1("pay") & "' , '" & dr1("tot") & "' , '" & dr1("lag") & "' , '" & dr1("box") & "' , '" & ChangeFormat(dr1("e_date")) & "' , '" & dr1("rm") & "' , '" & dr1("gr_n") & "' , '" & dr1("mach") & "' , '" & dr1("sex") & "' , '" & dr1("qun") & "' , '" & dr1("cah") & "' , '" & dr1("crd") & "' , '" & dr1("p_dis") & "' , '" & dr1("p_add") & "' , '" & dr1("req") & "' , '" & dr1("cah_req") & "' , '" & dr1("crd_req") & "' , '" & dr1("sup_c") & "' , '" & dr1("gr_c") & "' , '" & dr1("dur_c") & "' , '" & dr1("plac_c") & "' , '" & Trim(dr1("esl_go")) & "' , '" & dr1("reg_c") & "' , '" & dr1("doc_dis") & "' , '" & dr1("esl_no_rm") & "' , '" & dr1("rm_tot") & "' , '" & dr1("rm_time") & "' , '" & dr1("rm_user") & "' , '" & dr1("rm_note") & "' , '" & dr1("rm_date") & "', '" & dr1("DIS1") & "', '" & dr1("ADD1") & "')"
        '    cmd.ExecuteNonQuery()
        'End While
        dr1.Close()
        dr1.Close() : cmd1.CommandText = "delete * from t_esl  "
        cmd1.ExecuteNonQuery()
        dr1.Close() : cmd1.CommandText = "delete * from esl_del  "
        cmd1.ExecuteNonQuery()
        dr1.Close() : cmd1.CommandText = "delete * from esl_edit  "
        cmd1.ExecuteNonQuery()
        dr1.Close() : cmd1.CommandText = "delete * from esl_rd  "
        cmd1.ExecuteNonQuery()
        dr1.Close() : cmd1.CommandText = "delete * from esl_dis_del  "
        cmd1.ExecuteNonQuery()
        dr1.Close() : cmd1.CommandText = "delete * from esl_dis_edit  "
        cmd1.ExecuteNonQuery()
        dr1.Close() : cmd1.CommandText = "delete * from esl_dis_rd  "
        cmd1.ExecuteNonQuery()
        dr1.Close() : cmd1.CommandText = "delete * from t_esl_dis  "
        cmd1.ExecuteNonQuery()
        dr1.Close() : cmd1.CommandText = "delete * from t_esl_price  "
        cmd1.ExecuteNonQuery()

        MsgBox(" „ «· —ÕÌ·")

    End Sub

    Private Sub Button31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button31.Click

    End Sub

   
    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub
End Class