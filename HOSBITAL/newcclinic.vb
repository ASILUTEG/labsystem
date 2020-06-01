Public Class newcclinic
    Public pnamef As String
    '--------------------dataset vist-------------------
    Dim cmdtemp As New OleDb.OleDbCommand
    Dim adtemp As New OleDb.OleDbDataAdapter
    Dim temp As New DataTable
    '--------------------dataset vist-------------------
    Dim cmdvisit_ser As New OleDb.OleDbCommand
    Dim advisit_ser As New OleDb.OleDbDataAdapter
    Dim visit_ser As New DataTable
    '-------------------dataset service price-----------------
    Dim cmdser_price As New OleDb.OleDbCommand
    Dim adser_price As New OleDb.OleDbDataAdapter
    Dim ser_price As New DataTable
    '-------------------dataset patient -----------------
    Dim cmdfpatient As New OleDb.OleDbCommand
    Dim adfpatient As New OleDb.OleDbDataAdapter
    Dim fpatient As New DataTable
    '-------------------dataset report visit -----------------
    Dim cmdvisit As New OleDb.OleDbCommand
    Dim advisit As New OleDb.OleDbDataAdapter
    Dim visit As New DataTable
    '-------------------dataset visit test -----------------
    Dim cmdvisit_test As New OleDb.OleDbCommand
    Dim advisit_test As New OleDb.OleDbDataAdapter
    Dim visit_test As New DataTable
    '-------------------dataset visit test -----------------
    Dim cmdvisit_diag As New OleDb.OleDbCommand
    Dim advisit_diag As New OleDb.OleDbDataAdapter
    Dim visit_diag As New DataTable
    '-------------------dataset visit roshta -----------------
    Dim cmdvisit_roshta As New OleDb.OleDbCommand
    Dim advisit_roshta As New OleDb.OleDbDataAdapter
    Dim visit_roshta As New DataTable

    Public Sub tempfill()
        '==============================test access========================
        cmdvisit_test.Connection = ACcn
        cmdvisit_test.CommandText = "select * from nbill_test "
        advisit_test.SelectCommand = cmdvisit_test
        advisit_test.Fill(DBS, "visit_test")
        visit_test = DBS.Tables("visit_test")
        DBS.Tables("visit_test").Clear()
        advisit_test.Fill(DBS, "visit_test")
        visit_test = DBS.Tables("visit_test")
        dvisit_test.DataSource = visit_test
        dvisit_test.Columns("test_code").Visible = False
        dvisit_test.Columns("id").Visible = False
        dvisit_test.Columns("test_name").HeaderText = "«· Õ·Ì·"
        dvisit_test.Columns("res").HeaderText = "«·‰ ÌÃ…"
        '============================diag access===========================
        cmdvisit_diag.Connection = ACcn
        cmdvisit_diag.CommandText = "select * from nbill_diag "
        advisit_diag.SelectCommand = cmdvisit_diag
        advisit_diag.Fill(DBS, "visit_diag")
        visit_diag = DBS.Tables("visit_diag")
        DBS.Tables("visit_diag").Clear()
        advisit_diag.Fill(DBS, "visit_diag")
        visit_diag = DBS.Tables("visit_diag")
        dvisit_diag.DataSource = visit_diag
        dvisit_diag.Columns("id").Visible = False
        dvisit_diag.Columns("diag_name").HeaderText = "«· ‘ŒÌ’"
        '==============================test access========================
        cmdvisit_roshta.Connection = ACcn
        cmdvisit_roshta.CommandText = "select * from nbill_roshta "
        advisit_roshta.SelectCommand = cmdvisit_roshta
        advisit_roshta.Fill(DBS, "visit_roshta")
        visit_roshta = DBS.Tables("visit_roshta")
        DBS.Tables("visit_roshta").Clear()
        advisit_roshta.Fill(DBS, "visit_roshta")
        visit_roshta = DBS.Tables("visit_roshta")
        dvisit_roshta.DataSource = visit_roshta
        dvisit_roshta.Columns("id").Visible = False
        dvisit_roshta.Columns("medec_name").HeaderText = "«·œÊ«¡"
        dvisit_roshta.Columns("take_name").HeaderText = "«·Ã—⁄…"
    End Sub
    Public Sub fname()
        dr.Close()
        cmd.CommandText = "select * from npatient where pname='" & pname.Text & "'"
        dr = cmd.ExecuteReader
        While dr.Read
            pname.Text = dr("pname")
            pcode.Text = dr("pcode")
            page.Text = dr("page")
            pmobile.Text = dr("pmobile")
            paddress.Text = dr("paddress")
            pemail.Text = dr("pemail")
            pid.Text = dr("pid")
            fyear.Text = dr("fyear")
            lnotes.Text = dr("lnotes")
            market.Text = dr("market")
            pnamef = dr("pname")
            pcomment.Text = dr("pcomment")
            COMPANY_CODE.Text = dr("company_code")
            COMPANY_name.Text = dr("company_name")

        End While
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        clearp()
        newpatientid()

    End Sub
    Public Sub visitg()
        cmdvisit.Connection = CN
        cmdvisit.CommandText = "select * from nbill  where vdate between '" & ChangeFormat(date1.Value) & "' and '" & ChangeFormat(date2.Value) & "'"
        advisit.SelectCommand = cmdvisit
        advisit.Fill(DBS, "visit")
        visit = DBS.Tables("visit")
        DBS.Tables("visit").Clear()
        advisit.Fill(DBS, "visit")
        visit = DBS.Tables("visit")
        dvisit.DataSource = visit
        Dim x As Int16 = 1
        While Not x = visit.Columns.Count
            dvisit.Columns(x).Visible = False
            x += 1
        End While
        dvisit.Columns("vid").Visible = True
        dvisit.Columns("vid").Width = 75
        dvisit.Columns("pname").Visible = True
        dvisit.Columns("pname").Width = 150
        dvisit.Columns("pname").HeaderText = "«·„—Ì÷"
        dvisit.Columns("vdate").HeaderText = "«· «—ÌŒ"
        dvisit.Columns("ser_namet").HeaderText = "«·Œœ„…"
        dvisit.Columns("vid").HeaderText = "«·ﬂÊœ «·“Ì«—…"
        dvisit.Columns("vid").HeaderText = "«·ﬂÊœ «·ﬂ«— "
        dvisit.Columns("vdate").Visible = True
        dvisit.Columns("pid").Visible = True
        dvisit.Columns("ser_namet").Visible = True
        dvisit.Columns("tot").HeaderText = "«·«Ã„«·Ï"
        dvisit.Columns("tot").Visible = True
        dvisit.Columns("tot").Width = 50
        Dim oj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        oj.Load(Application.StartupPath & "\eyada\bill.rpt")
        oj.Database.Tables(0).SetDataSource(visit)
        rp.Close() : rp.CrystalReportViewer1.ReportSource = oj
        rp.Show() : rp.Focus()

    End Sub
    Public Sub fvid()
        clearp()
        dr1.Close()
        cmd1.CommandText = "select * from nbill where vid='" & Val(vid.Text) & "'"
        dr1 = cmd1.ExecuteReader
        If dr1.Read Then
            vid.Text = dr1("vid")
            vdate.Value = dr1("vdate")
            pname.Text = dr1("pname")
            market.Text = dr1("market")
            TOT.Text = dr1("tot")
            PAY.Text = dr1("pay")
            DISS.Text = dr1("diss")
            dissn.Text = dr1("dissn")
            'vtime.Text = dr("vtime")
            ser_namet.Text = dr1("ser_namet")
            pcomment.Text = dr1("pcomment")
            dr1.Close()
            ACdr.Close()
            ACcmd.CommandText = "update nbill set qun=0 "
            ACcmd.ExecuteNonQuery()
            cmd1.CommandText = "select * from nbill_service where vid='" & Val(vid.Text) & "'"
            dr1 = cmd1.ExecuteReader
            While dr1.Read
                ACcmd.CommandText = "update nbill set qun=1 where ser_code=" & dr1("ser_code")
                ACcmd.ExecuteNonQuery()
            End While
            '=====================================test ========================
            visit_test.Rows.Clear()
            dr1.Close()
            cmd1.CommandText = "select * from nbill_test where vid='" & Val(vid.Text) & "'"
            dr1 = cmd1.ExecuteReader
            While dr1.Read
                RC = visit_test.NewRow
                RC("test_name") = dr1("test_name")
                RC("res") = dr1("res")
                visit_test.Rows.Add(RC)
            End While
            '=====================================diag ========================
            visit_diag.Rows.Clear()
            dr1.Close()
            cmd1.CommandText = "select * from nbill_diag where vid='" & Val(vid.Text) & "'"
            dr1 = cmd1.ExecuteReader
            While dr1.Read
                RC = visit_diag.NewRow
                RC("diag_name") = dr1("diag_name")
                visit_diag.Rows.Add(RC)
            End While
            '=====================================roshta ========================
            visit_roshta.Rows.Clear()
            dr1.Close()
            cmd1.CommandText = "select * from nbill_roshta where vid='" & Val(vid.Text) & "'"
            dr1 = cmd1.ExecuteReader
            While dr1.Read
                RC = visit_roshta.NewRow
                RC("medec_name") = dr1("medec_name")
                RC("take_name") = dr1("take_name")
                visit_roshta.Rows.Add(RC)
            End While

            nbillupdate()
            fsershow()
            fname()
        Else
            MsgBox("ﬂÊœ «·“Ì«—… €Ì— ’ÕÌÕ", MsgBoxStyle.Critical)
        End If
    End Sub

    Public Sub nbillupdate()
        
        ACdr.Close()
        ACcmd.CommandText = "SELECT SUM (TOT) FROM nbill WHERE QUN=1 "
        ACdr = ACcmd.ExecuteReader
        ACdr.Read()
        TOT.Text = nulls(ACdr(0))
        If Val(dissn.Text) > 0 Then DISS.Text = Val(TOT.Text) * Val(dissn.Text) * 0.01
        PAY.Text = Val(TOT.Text) - Val(DISS.Text)
        ACdr.Close()
        ACcmd.CommandText = "SELECT ser_name FROM nbill WHERE qun>0 "
        ACdr = ACcmd.ExecuteReader
        ser_namet.Text = ""
        While ACdr.Read
            ser_namet.Text += "  +  " & ACdr(0)
            'If test.Text = "" Then test.Text = ACdr("test_name") Else test.Text = test.Text & "+" & ACdr("test_name")
            'If nulls(ACdr("lab")) = 1 Then ptest.Text = ptest.Text & "+" & ACdr("test_name")
        End While

    End Sub
    Public Sub fvist()
        ACdr.Close()
        ACcmd.CommandText = "delete * from nbill"
        ACcmd.ExecuteNonQuery()
        ACcmd.CommandText = "delete * from nbill_test"
        ACcmd.ExecuteNonQuery()
        dr.Close()
        cmd.CommandText = "select * from nservice_price"
        dr = cmd.ExecuteReader
        While dr.Read
            ACcmd.CommandText = "insert into nbill(ser_name,ser_code,tot) values ('" & dr("ser_name") & "','" & dr("ser_code") & "','" & dr("tot") & "')"
            ACcmd.ExecuteNonQuery()
        End While
        fsershow()
    End Sub
    Public Sub saveprice()
        If Val(ser_tot.Text) = 0 Then MsgBox("«·—Ã«¡ ﬂ «»… ”⁄— «·Œœ„…", MsgBoxStyle.Information) : Exit Sub
        If ser_name.Text = "" Then MsgBox("«·—Ã«¡ ﬂ «»…«”„ «·Œœ„…", MsgBoxStyle.Information) : Exit Sub
        dr.Close()
        cmd.CommandText = "select * from nservice_price where ser_name='" & ser_name.Text & "'"
        dr = cmd.ExecuteReader
        If dr.HasRows = True Then

            Dim x As String = MsgBox("Â·  —Ìœ  ⁄œÌ· ”⁄— Œœ„… " & "........." & ser_name.Text, MsgBoxStyle.YesNo)
            If x = vbNo Then Exit Sub
            dr.Close()
            cmd.CommandText = "delete from nservice_price where ser_name='" & ser_name.Text & "'"
            cmd.ExecuteNonQuery()
        End If
        dr.Close()
        cmd.CommandText = "INSERT INTO [nservice_price] (ser_name,ser_code,tot) VALUES ('" & ser_name.Text & "','" & ser_code.Text & "','" & Val(ser_tot.Text) & "') "
        cmd.ExecuteNonQuery()
        fser_price()
        fvist()
        ser_name.Focus()
        ser_name.Text = ""
        ser_tot.Text = 0

    End Sub
    Public Sub delprice()
        If ser_name.Text = "" Then MsgBox("«·—Ã«¡ ﬂ «»…«”„ «·Œœ„…", MsgBoxStyle.Information) : Exit Sub
        dr.Close()
        cmd.CommandText = "select * from nservice_price where ser_name='" & ser_name.Text & "'"
        dr = cmd.ExecuteReader
        If dr.HasRows = True Then
            Dim x As String = MsgBox("Â·  —Ìœ Õ–› ”⁄— Œœ„… " & "........." & ser_name.Text, MsgBoxStyle.YesNo)
            If x = vbNo Then Exit Sub
            dr.Close()
            cmd.CommandText = "delete from nservice_price where ser_name='" & ser_name.Text & "'"
            cmd.ExecuteNonQuery()
        End If
        fser_price()
        ser_name.Focus()
        ser_name.Text = ""
        ser_tot.Text = 0

    End Sub
    Public Sub savep()
        If Val(pcode.Text) = 0 Then newpatientid()
        If pname.Text.Length < 5 Then MsgBox("«·—Ã«¡ ﬂ «»… «”„ «·„—Ì÷", MsgBoxStyle.Information) : Exit Sub
        If Val(page.Text) = 0 Then MsgBox("«·—Ã«¡ ﬂ «»… «·”‰", MsgBoxStyle.Information) : Exit Sub
        Dim ed As Integer = 0
        dr.Close()
        cmd.CommandText = "select * from npatient where pcode='" & pcode.Text & "'"
        dr = cmd.ExecuteReader
        If dr.HasRows = True Then
            dr.Read()
            pnamef = dr("pname")
            Dim x As String = MsgBox("Â·  —Ìœ  ⁄œÌ· «·„—Ì÷ " & "........." & dr("pname"), MsgBoxStyle.YesNo)
            If x = vbNo Then Exit Sub
            If dr("pname") <> pname.Text Then refill("Npatient", 2)
            dr.Close()
            cmd.CommandText = "delete from npatient where pcode='" & pcode.Text & "'"
            cmd.ExecuteNonQuery()
            ed = 1

        End If
        Dim vtime As String = Now.Hour & ":" & Now.Minute & ":" & Now.Second
        dr.Close()
        cmd.CommandText = "INSERT INTO [Npatient] ([pname],[pcode],[page],[pmobile],[paddress],[pemail],[pid],[company_code],[company_name],[fyear],[lnotes],[market],[adate],pcomment) VALUES ('" & pname.Text & "','" & pcode.Text & "','" & page.Text & "','" & pmobile.Text & "','" & paddress.Text & "','" & pemail.Text & "','" & pid.Text & "','" & COMPANY_CODE.Text & "','" & COMPANY_name.Text & "','" & fyear.Text & "','" & lnotes.Text & "','" & market.Text & "','" & ChangeFormatall(Now) & "','" & pcomment.Text & "') "
        cmd.ExecuteNonQuery()
        refill("Npatient", 1)
    End Sub
    Public Sub clearp()
        pcode.Text = 0
        pname.Text = ""
        page.Text = 30
        pid.Text = 0
        pmobile.Text = 0
        pemail.Text = 0
        paddress.Text = 0
        lnotes.Text = 0
        COMPANY_name.Text = ""
        COMPANY_CODE.Text = 0
        market.Text = 0
        fyear.Text = Now.Year
        pcomment.Text = ""
    End Sub
    Public Sub newpatientid()

        dr.Close() : cmd.CommandText = "select MAx(pcode) from Npatient "
        dr = cmd.ExecuteReader
        dr.Read()
        pcode.Text = 1 + nulls(dr(0))
        pname.Focus()
    End Sub
    Public Sub newvistid()
        If Val(pcode.Text) = 0 Then MsgBox("«·—Ã«¡ ﬂ «»… «”„ «·„—Ì÷", MsgBoxStyle.Information) : Exit Sub
        If pname.Text.Length < 5 Then MsgBox("«·—Ã«¡ ﬂ «»… «”„ «·„—Ì÷", MsgBoxStyle.Information) : Exit Sub
        If Val(page.Text) = 0 Then MsgBox("«·—Ã«¡ ﬂ «»… «·”‰", MsgBoxStyle.Information) : Exit Sub
        dr.Close() : cmd.CommandText = "select MAx(vid) from nbill "
        dr = cmd.ExecuteReader
        dr.Read()
        vid.Text = 1 + nulls(dr(0))
        vid.Focus()
        Dim x As Int16 = 0
        While Not x = visit_ser.Rows.Count
            visit_ser.Rows(x).BeginEdit()
            visit_ser.Rows(x).Item("qun") = 0
            visit_ser.Rows(x).EndEdit()
            x += 1
        End While
        visit_test.Clear()
        visit_diag.Clear()
        visit_roshta.Clear()
        nbillupdate()
        vdate.Value = Now
        DISS.Text = 0
        dissn.Text = 0
    End Sub
    Public Sub FSAVE(ByVal NNAME As String, ByVal TB As String, ByVal PR As Int16)
        Dim N As Int16
        If NNAME = "" Then Exit Sub
        dr.Close()
        cmd.CommandText = "select * from " & TB & " where sname='" & NNAME & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        If PR = 1 Then
            If dr.HasRows = False Then
                dr.Close()
                cmd.CommandText = "select max(code) from  " & TB
                dr = cmd.ExecuteReader
                dr.Read()
                If IsDBNull(dr(0)) = False Then N = 1 + dr(0) Else N = 1
                dr.Close()
                dr.Close() : cmd.CommandText = "insert into  " & TB & "  (code,sname)  values ('" & N & "','" & NNAME & "')"
                cmd.ExecuteNonQuery()
                refill(TB, 1)
            End If
        Else
            Dim x As String = MsgBox("Â·  —Ìœ «·Õ–› ø", MsgBoxStyle.YesNo)
            If x = vbNo Then Exit Sub
            dr.Close()
            cmd.CommandText = "delete from " & TB & " where sname='" & NNAME & "'"
            cmd.ExecuteNonQuery()
            refill(TB, 2)
        End If
    End Sub
    Public Sub fser_price()
        cmdser_price.Connection = CN
        cmdser_price.CommandText = "select * from nservice_price "
        adser_price.SelectCommand = cmdser_price
        adser_price.Fill(DBS, "ser_price")
        ser_price = DBS.Tables("ser_price")
        DBS.Tables("ser_price").Clear()
        adser_price.Fill(DBS, "ser_price")
        ser_price = DBS.Tables("ser_price")
        dser_price.DataSource = ser_price
        Dim x As Int16 = 1
        While Not x = ser_price.Columns.Count
            dser_price.Columns(x).Visible = False
            x += 1
        End While
        dser_price.Columns("ser_name").Visible = True
        dser_price.Columns("ser_name").Width = 200
        dser_price.Columns("ser_name").HeaderText = "«·Œœ„…"
        dser_price.Columns("tot").Visible = True
        dser_price.Columns("tot").HeaderText = "«·”⁄—"

    End Sub
    Public Sub fsershow()
        '===========================test access=========================
        cmdvisit_ser.Connection = ACcn
        cmdvisit_ser.CommandText = "select * from nbill "
        advisit_ser.SelectCommand = cmdvisit_ser
        advisit_ser.Fill(DBS, "visit_ser")
        visit_ser = DBS.Tables("visit_ser")
        DBS.Tables("visit_ser").Clear()
        advisit_ser.Fill(DBS, "visit_ser")
        visit_ser = DBS.Tables("visit_ser")
        dserprice.DataSource = visit_ser
        dserprice.Columns("ser_code").Visible = False
        dserprice.Columns("id").Visible = False
      

    End Sub
    Public Sub fill()

        fvist()
        fser_price()
        dr.Close()
        ser_name.Items.Clear()
        cmd.CommandText = "select * from nservice"
        dr = cmd.ExecuteReader
        While dr.Read
            ser_name.Items.Add(dr("sname"))
        End While
        dr.Close()
        COMPANY_name.Items.Clear()
        cmd.CommandText = "select * from ncompany"
        dr = cmd.ExecuteReader
        While dr.Read
            COMPANY_name.Items.Add(dr("sname"))
        End While
        dr.Close()
        pname.Items.Clear()
        cmd.CommandText = "select * from Npatient"
        dr = cmd.ExecuteReader
        While dr.Read
            pname.Items.Add(dr("pname"))
        End While
        lnotes.Items.Clear()
        dr.Close()
        cmd.CommandText = "select * from nnotes"
        dr = cmd.ExecuteReader
        While dr.Read
            lnotes.Items.Add(dr("sname"))
        End While

        diag_name.Items.Clear()
        dr.Close()
        cmd.CommandText = "select * from ndiagn"
        dr = cmd.ExecuteReader
        While dr.Read
            diag_name.Items.Add(dr("sname"))
        End While
        medec_name.Items.Clear()
        dr.Close()
        cmd.CommandText = "select * from nmedec"
        dr = cmd.ExecuteReader
        While dr.Read
            medec_name.Items.Add(dr("sname"))
        End While
        take_name.Items.Clear()
        dr.Close()
        cmd.CommandText = "select * from ntake"
        dr = cmd.ExecuteReader
        While dr.Read
            take_name.Items.Add(dr("sname"))
        End While
        test_name.Items.Clear()
        dr.Close()
        cmd.CommandText = "select * from ntest"
        dr = cmd.ExecuteReader
        While dr.Read
            test_name.Items.Add(dr("sname"))
        End While
        paddress.Items.Clear()
        dr.Close()
        cmd.CommandText = "select * from naddress"
        dr = cmd.ExecuteReader
        While dr.Read
            paddress.Items.Add(dr("sname"))
        End While
        market.Items.Clear()
        dr.Close()
        cmd.CommandText = "select * from nmarket"
        dr = cmd.ExecuteReader
        While dr.Read
            market.Items.Add(dr("sname"))
        End While
    End Sub
    Public Sub refill(ByVal tb As String, ByVal type As Int16)
        If tb = "nmarket" Then
            If type = 1 Then market.Items.Add(market.Text) Else market.Items.Remove(market.Text)
        End If
        If tb = "nservice" Then
            If type = 1 Then ser_name.Items.Add(ser_name.Text) Else ser_name.Items.Remove(ser_name.Text)
        End If
        If tb = "ncompany" Then
            If type = 1 Then COMPANY_name.Items.Add(COMPANY_name.Text) Else COMPANY_name.Items.Remove(COMPANY_name.Text)
        End If
        If tb = "nnotes" Then
            If type = 1 Then lnotes.Items.Add(lnotes.Text) Else lnotes.Items.Remove(lnotes.Text)
        End If
        If tb = "ndiagn" Then
            If type = 1 Then diag_name.Items.Add(diag_name.Text) Else diag_name.Items.Remove(diag_name.Text)
        End If
        If tb = "nmedec" Then
            If type = 1 Then medec_name.Items.Add(medec_name.Text) Else medec_name.Items.Remove(medec_name.Text)
        End If
        If tb = "ntake" Then
            If type = 1 Then take_name.Items.Add(take_name.Text) Else take_name.Items.Remove(take_name.Text)
        End If
        If tb = "ntest" Then
            If type = 1 Then test_name.Items.Add(test_name.Text) Else test_name.Items.Remove(test_name.Text)
        End If
        If tb = "naddress" Then
            If type = 1 Then paddress.Items.Add(paddress.Text) Else paddress.Items.Remove(paddress.Text)
        End If
        If tb = "Npatient" Then
            If type = 1 Then pname.Items.Add(pname.Text) Else pname.Items.Remove(pnamef)
        End If
    End Sub
    Private Sub asd123_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles asd123.Click
        savep()
    End Sub


    Private Sub asd122_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles asd122.Click
        If Val(pcode.Text) = 0 Then MsgBox("«·—Ã«¡ «Œ Ì«— «”„ «·„—Ì÷", MsgBoxStyle.Information) : Exit Sub
        If pname.Text.Length < 5 Then MsgBox("«·—Ã«¡ «Œ Ì«— «”„ «·„—Ì÷", MsgBoxStyle.Information) : Exit Sub
        If Val(page.Text) = 0 Then MsgBox("«·—Ã«¡ ﬂ «»… «·”‰", MsgBoxStyle.Information) : Exit Sub
        dr.Close()
        cmd.CommandText = "select * from npatient where pcode='" & pcode.Text & "'"
        dr = cmd.ExecuteReader
        If dr.HasRows = True Then
            dr.Read()
            Dim x As String = MsgBox("Â·  —Ìœ Õ–› «·„—Ì÷ " & "........." & dr("pname"), MsgBoxStyle.YesNo)
            If x = vbNo Then Exit Sub
            dr.Close()
            cmd.CommandText = "delete from npatient where pcode='" & pcode.Text & "'"
            cmd.ExecuteNonQuery()
        End If
        refill("Npatient", 2)
    End Sub

    Private Sub pname_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles pname.GotFocus
        flng("AR")
        sender.BackColor = Color.Yellow

    End Sub

    Private Sub pname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles pname.KeyDown
        If e.KeyCode = Keys.Enter Then
            page.Focus()
        End If
    End Sub

    Private Sub pname_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles pname.KeyUp
        If e.KeyCode = Keys.F2 Then

        End If
    End Sub

    Private Sub pname_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles pname.LostFocus
        sender.BackColor = Color.White
    End Sub

    Private Sub pname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pname.SelectedIndexChanged
        fname()

    End Sub

    Private Sub page_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles page.GotFocus
        sender.BackColor = Color.Yellow
    End Sub

    Private Sub page_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles page.KeyDown
        If e.KeyCode = Keys.Enter Then
            pid.Focus()
        End If
    End Sub

    Private Sub page_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles page.LostFocus

        sender.BackColor = Color.White
    End Sub

    Private Sub page_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles page.TextChanged

    End Sub

    Private Sub pid_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles pid.GotFocus

        sender.BackColor = Color.Yellow
    End Sub

    Private Sub pid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles pid.KeyDown
        If e.KeyCode = Keys.Enter Then
            pmobile.Focus()
        End If
    End Sub

    Private Sub pid_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles pid.LostFocus

        sender.BackColor = Color.White
    End Sub


    Private Sub pid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pid.TextChanged

    End Sub

    Private Sub pmobile_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles pmobile.GotFocus
        sender.BackColor = Color.Yellow
    End Sub

    Private Sub pmobile_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles pmobile.KeyDown
        If e.KeyCode = Keys.Enter Then
            fyear.Focus()
        End If
    End Sub

    Private Sub pmobile_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles pmobile.LostFocus
        sender.BackColor = Color.White
    End Sub

    Private Sub pmobile_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pmobile.TextChanged

    End Sub

    Private Sub COMPANY_name_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles COMPANY_name.GotFocus
        flng("AR")
        sender.BackColor = Color.Yellow
    End Sub

    Private Sub COMPANY_name_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles COMPANY_name.KeyDown
        If e.KeyCode = Keys.Enter Then
            FSAVE(COMPANY_name.Text, "ncompany", 1)
            market.Focus()
        ElseIf e.KeyCode = Keys.Delete Then
            FSAVE(COMPANY_name.Text, "ncompany", 2)
        End If
    End Sub

    Private Sub COMPANY_name_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles COMPANY_name.LostFocus
        sender.BackColor = Color.White
    End Sub

    Private Sub COMPANY_name_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COMPANY_name.SelectedIndexChanged
        dr.Close()
        cmd.CommandText = "select * from ncompany where sname='" & COMPANY_name.Text & "'"
        dr = cmd.ExecuteReader
        While dr.Read
            COMPANY_CODE.Text = dr("code")
        End While
    End Sub

    Private Sub newcclinic_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tempfill()
        fill()

    End Sub

    Private Sub lnotes_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles lnotes.GotFocus
        flng("AR")
        sender.BackColor = Color.Yellow
    End Sub

    Private Sub lnotes_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lnotes.KeyDown
        If e.KeyCode = Keys.Enter Then
            FSAVE(lnotes.Text, "nnotes", 1)
            COMPANY_name.Focus()
        ElseIf e.KeyCode = Keys.Delete Then
            FSAVE(lnotes.Text, "nnotes", 2)
        End If
    End Sub

    Private Sub lnotes_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles lnotes.LostFocus

        sender.BackColor = Color.White
    End Sub

    Private Sub lnotes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lnotes.SelectedIndexChanged

    End Sub

    Private Sub paddress_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles paddress.GotFocus
        sender.BackColor = Color.Yellow
    End Sub

    Private Sub paddress_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles paddress.KeyDown
        If e.KeyCode = Keys.Enter Then
            FSAVE(paddress.Text, "naddress", 1)
            lnotes.Focus()
        ElseIf e.KeyCode = Keys.Delete Then
            FSAVE(paddress.Text, "naddress", 2)
        End If
    End Sub

    Private Sub paddress_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles paddress.LostFocus

        sender.BackColor = Color.White
    End Sub

    Private Sub paddress_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles paddress.SelectedIndexChanged

    End Sub

    Private Sub test_name_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles test_name.GotFocus
        flng("EN")
        sender.BackColor = Color.Yellow
    End Sub

    Private Sub test_name_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles test_name.KeyDown
        If e.KeyCode = Keys.Enter Then
            FSAVE(test_name.Text, "ntest", 1)
            FRC = visit_test.Select("test_name='" & test_name.Text & "'")
            If FRC.Length = 0 And test_name.Text.Length > 2 Then
                RC = visit_test.NewRow
                RC("test_name") = test_name.Text
                visit_test.Rows.Add(RC)
            End If

        ElseIf e.KeyCode = Keys.Delete Then
            FSAVE(test_name.Text, "ntest", 2)
        End If
    End Sub

    Private Sub test_name_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles test_name.LostFocus
        sender.BackColor = Color.White
    End Sub

    Private Sub test_name_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles test_name.SelectedIndexChanged

    End Sub

    Private Sub diagn_name_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles diag_name.GotFocus
        flng("EN")
        sender.BackColor = Color.Yellow
    End Sub

    Private Sub diagn_name_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles diag_name.KeyDown
        If e.KeyCode = Keys.Enter Then
            FSAVE(diag_name.Text, "ndiagn", 1)
            FRC = visit_diag.Select("diag_name='" & diag_name.Text & "'")
            If FRC.Length = 0 And diag_name.Text.Length > 2 Then
                RC = visit_diag.NewRow
                RC("diag_name") = diag_name.Text
                visit_diag.Rows.Add(RC)
            End If
        ElseIf e.KeyCode = Keys.Delete Then
            FSAVE(diag_name.Text, "ndiagn", 2)
        End If
    End Sub

    Private Sub diagn_name_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles diag_name.LostFocus

        sender.BackColor = Color.White
    End Sub

    Private Sub diagn_name_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles diag_name.SelectedIndexChanged

    End Sub

    Private Sub medec_name_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles medec_name.GotFocus
        flng("EN")
        sender.BackColor = Color.Yellow
    End Sub

    Private Sub medec_name_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles medec_name.KeyDown
        If e.KeyCode = Keys.Enter Then
            FSAVE(medec_name.Text, "nmedec", 1)
        ElseIf e.KeyCode = Keys.Delete Then
            FSAVE(medec_name.Text, "nmedec", 2)
        End If
    End Sub

    Private Sub medec_name_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles medec_name.LostFocus

        sender.BackColor = Color.White

    End Sub

    Private Sub medec_name_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles medec_name.SelectedIndexChanged

    End Sub

    Private Sub take_name_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles take_name.GotFocus
        flng("AR")
        sender.BackColor = Color.Yellow
    End Sub

    Private Sub take_name_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles take_name.KeyDown
        If e.KeyCode = Keys.Enter Then
            FSAVE(take_name.Text, "ntake", 1)
            FRC = visit_roshta.Select("medec_name='" & medec_name.Text & "'")
            If FRC.Length = 0 And medec_name.Text.Length > 2 Then
                RC = visit_roshta.NewRow
                RC("medec_name") = medec_name.Text
                RC("take_name") = take_name.Text
                visit_roshta.Rows.Add(RC)
            End If
        ElseIf e.KeyCode = Keys.Delete Then
            FSAVE(take_name.Text, "ntake", 2)
        End If
    End Sub

    Private Sub take_name_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles take_name.LostFocus
        sender.BackColor = Color.White
    End Sub

    Private Sub take_name_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles take_name.SelectedIndexChanged

    End Sub

    Private Sub fyear_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles fyear.GotFocus
        sender.BackColor = Color.Yellow
    End Sub

    Private Sub fyear_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles fyear.KeyDown
        If e.KeyCode = Keys.Enter Then
            paddress.Focus()
        End If
    End Sub

    Private Sub fyear_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles fyear.LostFocus
        sender.BackColor = Color.White
    End Sub

    Private Sub fyear_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fyear.TextChanged

    End Sub

    Private Sub market_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles market.GotFocus
        flng("AR")
        sender.BackColor = Color.Yellow
    End Sub

    Private Sub market_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles market.KeyDown
        If e.KeyCode = Keys.Enter Then
            FSAVE(market.Text, "nmarket", 1)
            savep()
        ElseIf e.KeyCode = Keys.Delete Then
            FSAVE(market.Text, "nmarket", 2)
        End If
    End Sub

    Private Sub market_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles market.LostFocus
        sender.BackColor = Color.Yellow
    End Sub


    Private Sub market_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles market.SelectedIndexChanged

    End Sub

    Private Sub pemail_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles pemail.GotFocus
        flng("EN")
        sender.BackColor = Color.Yellow
    End Sub

    Private Sub pemail_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles pemail.LostFocus

        sender.BackColor = Color.White
    End Sub

    Private Sub pemail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pemail.TextChanged

    End Sub

    Private Sub ser_name_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ser_name.GotFocus
        flng("AR")
        sender.BackColor = Color.Yellow
    End Sub

    Private Sub ser_name_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ser_name.KeyDown
        If e.KeyCode = Keys.Enter Then
            FSAVE(sender.Text, "nservice", 1)
            ser_tot.Focus()
            ser_tot.Text = ""
        ElseIf e.KeyCode = Keys.Delete Then
            FSAVE(sender.Text, "nservice", 2)
        End If
    End Sub

    Private Sub ser_name_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ser_name.LostFocus
        sender.BackColor = Color.White
    End Sub

    Private Sub ser_name_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ser_name.SelectedIndexChanged
        dr.Close()
        cmd.CommandText = "select * from nservice where sname='" & ser_name.Text & "'"
        dr = cmd.ExecuteReader
        While dr.Read
            ser_code.Text = dr("code")
        End While
    End Sub

    Private Sub ser_tot_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ser_tot.KeyDown
        If e.KeyCode = Keys.Enter Then
            saveprice()
        ElseIf e.KeyCode = Keys.Delete Then
            delprice()
        End If

    End Sub

    Private Sub ser_tot_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ser_tot.TextChanged

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        gser_price.Visible = Not gser_price.Visible

    End Sub

    Private Sub dser_price_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dser_price.CellContentClick

    End Sub

    Private Sub dser_price_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dser_price.CellMouseClick
        ser_name.Text = dser_price(("ser_name"), e.RowIndex).Value
        ser_code.Text = dser_price(("ser_code"), e.RowIndex).Value
        ser_tot.Text = dser_price(("tot"), e.RowIndex).Value
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        newvistid()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        savep()
        dr.Close()
        cmd.CommandText = "select * from nbill where vid='" & vid.Text & "'"
        dr = cmd.ExecuteReader
        If dr.HasRows = True Then
            dr.Read()
            Dim x As String = MsgBox("Â·  —Ìœ  ⁄œÌ· “Ì«—… «·„—Ì÷ " & "........." & dr("pname"), MsgBoxStyle.YesNo)
            If x = vbNo Then Exit Sub
            dr.Close()
            cmd.CommandText = "delete from nbill where vid='" & vid.Text & "'"
            cmd.ExecuteNonQuery()
            cmd.CommandText = "delete from nbill_service where vid='" & vid.Text & "'"
            cmd.ExecuteNonQuery()
            cmd.CommandText = "delete from nbill_test where vid='" & vid.Text & "'"
            cmd.ExecuteNonQuery()
            cmd.CommandText = "delete from nbill_diag where vid='" & vid.Text & "'"
            cmd.ExecuteNonQuery()
        End If


        Dim vtime As String = Now.Hour & ":" & Now.Minute & ":" & Now.Second
        dr.Close()
        cmd.CommandText = "insert into nbill ([vid],[vdate],[pname],[pcode],[page],[pmobile],[company_name],[company_code],[market],[pemail],[pid],[fyear],[tot],[pay],[diss],[dissn],vtime,ser_namet,pcomment) values ('" & vid.Text & "','" & ChangeFormat(vdate.Value) & "','" & pname.Text & "','" & pcode.Text & "','" & page.Text & "','" & pmobile.Text & "','" & COMPANY_name.Text & "','" & COMPANY_CODE.Text & "','" & market.Text & "','" & pemail.Text & "','" & pid.Text & "','" & fyear.Text & "','" & TOT.Text & "','" & PAY.Text & "','" & DISS.Text & "','" & dissn.Text & "','" & vtime & "','" & ser_namet.Text & "','" & pcomment.Text & "')"
        cmd.ExecuteNonQuery()
        '==============================services============================
        ACdr.Close()
        ACcmd.CommandText = "select * from nbill where qun=1"
        ACdr = ACcmd.ExecuteReader
        While ACdr.Read
            cmd.CommandText = "insert into nbill_service([vid],[ser_name],[ser_code],[tot],[adddate],[addtime],[pid],[pname],[pcode]) values ('" & vid.Text & "','" & ACdr("ser_name") & "','" & ACdr("ser_code") & "','" & TOT.Text & "','" & ChangeFormat(vdate.Value) & "','" & vtime & "','" & pid.Text & "','" & pname.Text & "','" & pcode.Text & "')"
            cmd.ExecuteNonQuery()
        End While

        '===========================test upload====================================
        Dim xn As Integer = 0
        While Not xn = visit_test.Rows.Count
            cmd.CommandText = "insert into nbill_test([vid],[test_name],[res],[adddate],[addtime],[pid],[pname],[pcode]) values ('" & vid.Text & "','" & visit_test.Rows(xn).Item("test_name") & "','" & visit_test.Rows(xn).Item("res") & "','" & ChangeFormat(vdate.Value) & "','" & vtime & "','" & pid.Text & "','" & pname.Text & "','" & pcode.Text & "')"
            cmd.ExecuteNonQuery()
            xn += 1
        End While
        '===========================diag upload====================================
        xn = 0
        While Not xn = visit_diag.Rows.Count
            cmd.CommandText = "insert into nbill_diag([vid],[diag_name],[adddate],[addtime],[pid],[pname],[pcode]) values ('" & vid.Text & "','" & visit_diag.Rows(xn).Item("diag_name") & "','" & ChangeFormat(vdate.Value) & "','" & vtime & "','" & pid.Text & "','" & pname.Text & "','" & pcode.Text & "')"
            cmd.ExecuteNonQuery()
            xn += 1
        End While
        '===========================roshta upload====================================
        xn = 0
        While Not xn = visit_roshta.Rows.Count
            cmd.CommandText = "insert into nbill_roshta([vid],[medec_name],[take_name],[adddate],[addtime],[pid],[pname],[pcode]) values ('" & vid.Text & "','" & visit_roshta.Rows(xn).Item("medec_name") & "','" & visit_roshta.Rows(xn).Item("take_name") & "','" & ChangeFormat(vdate.Value) & "','" & vtime & "','" & pid.Text & "','" & pname.Text & "','" & pcode.Text & "')"
            cmd.ExecuteNonQuery()
            xn += 1
        End While

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

    End Sub

    Private Sub dserprice_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dserprice.CellContentClick

    End Sub

    Private Sub dissn_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dissn.KeyDown
        If e.KeyCode = Keys.Enter Then
            DISS.Text = Val(TOT.Text) * Val(dissn.Text) * 0.01
        End If
    End Sub

    Private Sub dissn_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dissn.TextChanged

    End Sub



    Private Sub DISS_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DISS.TextChanged
        PAY.Text = Val(TOT.Text) - Val(DISS.Text)
    End Sub

    Private Sub dserprice_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dserprice.CellEndEdit
        cmdb.DataAdapter = advisit_ser
        advisit_ser.Update(DBS, "visit_ser")
        nbillupdate()
    End Sub

    Private Sub dvisit_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dvisit.CellContentClick

    End Sub

    Private Sub dvisit_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dvisit.CellMouseClick
        On Error Resume Next
        vid.Text = dvisit("vid", e.RowIndex).Value
        fvid()
    End Sub

    Private Sub TextBox9_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox9.KeyUp
        date1.Value = Now
        date1.Value = date1.Value.AddDays(-1 * Val(TextBox9.Text))
        If e.KeyCode = Keys.Enter Then
            visitg()
        End If
    End Sub

    Private Sub TextBox9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox9.TextChanged

    End Sub

    Private Sub asd125_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles asd125.Click
        visitg()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        cmdtemp.Connection = CN
        cmdtemp.CommandText = "select * from nbill_roshta where vid='" & vid.Text & "'"
        adtemp.SelectCommand = cmdtemp
        adtemp.Fill(DBS, "temp")
        temp = DBS.Tables("temp")
        DBS.Tables("temp").Clear()
        adtemp.Fill(DBS, "temp")
        temp = DBS.Tables("temp")
       
        Dim oj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        oj.Load(Application.StartupPath & "\eyada\roshta.rpt")
        oj.Database.Tables(0).SetDataSource(temp)
        rp.Close() : rp.CrystalReportViewer1.ReportSource = oj
        rp.Show() : rp.Focus()

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        cmdtemp.Connection = CN
        cmdtemp.CommandText = "select * from nbill"
        adtemp.SelectCommand = cmdtemp
        adtemp.Fill(DBS, "temp")
        temp = DBS.Tables("temp")
        DBS.Tables("temp").Clear()
        adtemp.Fill(DBS, "temp")
        temp = DBS.Tables("temp")
        Dim oj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        oj.Load(Application.StartupPath & "\eyada\card.rpt")
        oj.Database.Tables(0).SetDataSource(temp)
        rp.Close() : rp.CrystalReportViewer1.ReportSource = oj
        rp.Show() : rp.Focus()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click

    End Sub
End Class