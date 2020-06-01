Public Class tquery
    Dim cmdF32 As New OleDb.OleDbCommand
    Dim ADF32 As New OleDb.OleDbDataAdapter
    Dim F32 As New DataTable
    Dim cmdBILLT As New OleDb.OleDbCommand
    Dim ADBILLT As New OleDb.OleDbDataAdapter
    Dim BILLT As New DataTable
    Dim cmdTESL As New OleDb.OleDbCommand
    Dim ADTESL As New OleDb.OleDbDataAdapter
    Dim TESL As New DataTable
    Dim cmdtprof As New OleDb.OleDbCommand
    Dim Adtprof As New OleDb.OleDbDataAdapter
    Dim tprof As New DataTable
    Dim cmdtcult As New OleDb.OleDbCommand
    Dim Adtcult As New OleDb.OleDbDataAdapter
    Dim tcult As New DataTable
    Dim TOJ As Integer

    Private Sub tquery_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmdBILLT.Connection = ACcn
        pname.Text = ""
        COMPANY_name.Text = ""
        REG_name.Text = ""
        ACdr.Close()
        ACcmd.CommandText = "DELETE * FROM TEST_PRICET"
        ACcmd.ExecuteNonQuery()
        ACcmd.CommandText = "INSERT INTO TEST_PRICET SELECT * FROM TEST_PRICE "
        ACcmd.ExecuteNonQuery()
    End Sub

    Private Sub pname_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles pname.GotFocus
        TOJ = 1
        flng("AR")
    End Sub

    Private Sub pname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pname.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        dr.Close() : cmd.Connection = CN
        If TOJ = 1 Then
            cmd.CommandText = "select * from lbill where pname like'%" & pname.Text & "%' and bdel=0 and esl_date between '" & ChangeFormat(d1.Value) & "' and '" & ChangeFormat(d2.Value) & "'"
        ElseIf TOJ = 2 Then
            cmd.CommandText = "select * from lbill where pmobile like'%" & pmobile.Text & "%' and bdel=0 and esl_date between '" & ChangeFormat(d1.Value) & "' and '" & ChangeFormat(d2.Value) & "'"
        ElseIf TOJ = 3 Then
            cmd.CommandText = "select * from lbill where COMPANY_NAME like'%" & COMPANY_name.Text & "%' and bdel=0 and esl_date between '" & ChangeFormat(d1.Value) & "' and '" & ChangeFormat(d2.Value) & "'"
        ElseIf TOJ = 4 Then
            cmd.CommandText = "select * from lbill where REG_NAME like'%" & REG_name.Text & "%' and bdel=0 and esl_date between '" & ChangeFormat(d1.Value) & "' and '" & ChangeFormat(d2.Value) & "'"
        Else
            cmd.CommandText = "select * from lbill where COMPANY_NAME like'%" & COMPANY_name.Text & "%' and bdel=0 and esl_date between '" & ChangeFormat(d1.Value) & "' and '" & ChangeFormat(d2.Value) & "'"

        End If


        ADF32.SelectCommand = cmd
        adF32.Fill(DBS, "F32")
        F32 = DBS.Tables("F32")
        DBS.Tables("F32").Clear()
        adF32.Fill(DBS, "F32")
        F32 = DBS.Tables("F32")
        Label6.Text = "( " & F32.Rows.Count & " )"
        TQF32.DataSource = F32
        Dim v As Integer = 0
        While Not v = TQF32.Columns.Count
            TQF32.Columns(v).Visible = False
            v = v + 1
        End While
        TQF32.Columns("branch_name").DisplayIndex = 1
        TQF32.Columns("branch_name").Width = 70
        TQF32.Columns("branch_name").HeaderText = "branch"
        TQF32.Columns("branch_name").Visible = True
        'TQF32.Columns("choice").Visible = True
        TQF32.Columns("esl_date").Visible = True
        TQF32.Columns("esl_date").Width = 70
        If lng = "AR" Then TQF32.Columns("esl_date").HeaderText = "ÇáÊÇÑíÎ" Else TQF32.Columns("esl_date").HeaderText = "DATE"
        TQF32.Columns("esl_no").Visible = True
        If lng = "AR" Then TQF32.Columns("esl_no").HeaderText = "ÇáÇíÕÇá" Else TQF32.Columns("esl_no").HeaderText = "BILL NO"
        TQF32.Columns("esl_no").Width = 50
        TQF32.Columns("COMPANY_NAME").Visible = True
        TQF32.Columns("COMPANY_NAME").HeaderText = "REF DOC"
        TQF32.Columns("COMPANY_NAME").Width = 50
        TQF32.Columns("pname").Visible = True
        If lng = "AR" Then TQF32.Columns("pname").HeaderText = "ÇáÍÇáÉ" Else TQF32.Columns("pname").HeaderText = "Patient"
        TQF32.Columns("tot").Visible = True
        If lng = "AR" Then TQF32.Columns("tot").HeaderText = "ÇáÇÌãÇáì" Else TQF32.Columns("tot").HeaderText = "TOTAL"
        TQF32.Columns("test").Visible = True
        If lng = "AR" Then TQF32.Columns("test").HeaderText = "ÇáÊÍáíá" Else TQF32.Columns("test").HeaderText = "TEST"
        Dim N As Integer = 0
        While Not n = TQF32.RowCount
            If nulls(TQF32(("sprnt"), N).Value) > 0 Then
                TQF32.Rows(N).DefaultCellStyle.BackColor = Color.Red
            ElseIf nulls(TQF32(("FINAL"), N).Value) > 0 Then
                TQF32.Rows(N).DefaultCellStyle.BackColor = Color.LightGreen
            ElseIf nulls(TQF32(("FS"), N).Value) > 0 Then
                TQF32.Rows(N).DefaultCellStyle.BackColor = Color.Gray
            Else
                TQF32.Rows(N).DefaultCellStyle.BackColor = Color.White
            End If
            n = n + 1
        End While
    End Sub

    Private Sub pmobile_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles pmobile.KeyDown
        TOJ = 2
        flng("AR")
    End Sub

    Private Sub pmobile_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pmobile.TextChanged

    End Sub

    Private Sub COMPANY_name_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles COMPANY_name.GotFocus
        TOJ = 3
        flng("AR")
    End Sub

    Private Sub COMPANY_name_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles COMPANY_name.KeyUp
        dr.Close()
        cmd.CommandText = "select * from Lcompany where name='" & COMPANY_name.Text & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            COMPANY_name.Text = dr("name")
            COMPANY_CODE.Text = dr("code")
            BOOK_name.Text = dr("BOOK_PRICE_NAME")
            BOOK_CODE.Text = dr("BOOK_PRICE_CODE")
            dissn.Text = dr("diss")
            PCRD.Text = dr("CRD")
            PCRD.Text = dr("CRD")
            CRD_PER.Text = dr("ch")
            cash_per.Text = dr("ph")
            TPRICET()
            SUMT()
            Tfprice(1)
        End If
    End Sub

    Private Sub COMPANY_name_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COMPANY_name.SelectedIndexChanged

    End Sub

    Private Sub REG_name_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles REG_name.GotFocus
        TOJ = 4
        flng("AR")
    End Sub

    Private Sub REG_name_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REG_name.SelectedIndexChanged

    End Sub

    Private Sub TQF32_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TQF32.CellContentClick
        res(TQF32(("esl_no"), e.RowIndex).Value, TQF32(("yearn"), e.RowIndex).Value, TQF32(("bran"), e.RowIndex).Value)

    End Sub

    Private Sub TQF32_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TQF32.CellDoubleClick

    End Sub
    Public Sub res(ByVal esl_no As Integer, ByVal yearn As Integer, ByVal bran As String)
        If vi.Checked = True Then
            Dim n As Int16 = 0
            cmdTESL.Connection = CN
            dr.Close()
            DBS.Tables("esl").Clear()
            cmdTESL.Parameters.Clear()
            cmdTESL.CommandText = "pesl"
            cmdTESL.CommandType = CommandType.StoredProcedure
            cmdTESL.Parameters.AddWithValue("esl_no", esl_no)
            cmdTESL.Parameters.AddWithValue("yearn", yearn)
            cmdTESL.Parameters.AddWithValue("bran", bran)
            ADTESL.SelectCommand = cmdTESL
            ADTESL.Fill(DBS, "Tesl")
            Dim oj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            oj.Load(Application.StartupPath & rrpt & "\esl.rpt")
            oj.Database.Tables(0).SetDataSource(DBS.Tables("Tesl"))
            oj.SetParameterValue("a", 0)
            rp.Close() : rp.CrystalReportViewer1.ReportSource = oj
            rp.Show() : rp.Focus()
        Else
            Dim oj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            dr.Close()
            cmdTESL.Connection = CN
            DBS.Tables("esl").Clear()
            cmdTESL.Parameters.Clear()
            cmdTESL.CommandText = "pres"
            cmdTESL.CommandType = CommandType.StoredProcedure
            cmdTESL.Parameters.AddWithValue("esl_no", esl_no)
            cmdTESL.Parameters.AddWithValue("yearn", yearn)
            cmdTESL.Parameters.AddWithValue("bran", bran)
            ADTESL.SelectCommand = cmdTESL
            ADTESL.Fill(DBS, "esl")
            '====================HISTORY===========================
           
            Dim NB As Integer = 0
            While Not NB = DBS.Tables("esl").Rows.Count
                If nulls(DBS.Tables("esl").Rows(NB).Item("PTHN")) = 1 Then
                    dr.Close()
                    cmd.CommandText = "SELECT * FROM LBILL_TEST WHERE ESL_NO<>'" & DBS.Tables("esl").Rows(0).Item("ESL_NO") & "' " & " and TDEL=0 AND " & "yearn='" & yearn & "' and bran='" & bran & "'" & " AND TEST_CODE='" & DBS.Tables("esl").Rows(NB).Item("TEST_CODE") & "' AND PCODE='" & DBS.Tables("esl").Rows(NB).Item("PCODE") & "' ORDER BY  ESL_DATE DESC"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    If dr.HasRows = True Then
                        DBS.Tables("esl").Rows(NB).BeginEdit()
                        DBS.Tables("esl").Rows(NB).Item("PTH") = dr("ESL_DATE") & "              ( " & dr("RES") & " )"
                        DBS.Tables("esl").Rows(NB).EndEdit()
                    End If
                End If
                NB = NB + 1
            End While
            '====================END===============================
            If DBS.Tables("esl").Rows.Count > 0 Then
                Dim qqqq As String = ""
                oj.Load(Application.StartupPath & rrpt & qqqq & "\resg.rpt")
                oj.Database.Tables(0).SetDataSource(DBS.Tables("esl"))
                oj.SetParameterValue("REF", 1)
                oj.SetParameterValue("11", 0)
                rp.Close() : rp.CrystalReportViewer1.ReportSource = oj
                rp.CrystalReportViewer1.ShowPrintButton = False
                rp.CrystalReportViewer1.ShowExportButton = False
                rp.ShowDialog()
            End If
            Dim X As String
            dr.Close()
            cmd.CommandText = "select * from lbill where ESL_NO='" & Val(esl_no) & "' " & " and " & "yearn='" & Val(yearn) & "' and bran='" & bran & "'"
            dr = cmd.ExecuteReader
            If dr.HasRows = True Then
                dr.Read()
                If dr("rcv") > 0 Then X = "received - " Else X = "not received - "
                If dr("sprnt") > 0 Then
                    STATUToolStripMenuItem.BackColor = Color.Red
                    X = X & "printed " & "( " & dr("sprnt") & " )"
                Else
                    STATUToolStripMenuItem.BackColor = Color.Green
                    X = X & " NOT printed"
                End If
                STATUToolStripMenuItem.Text = X
            End If
            '==========================================cbc====================
            cmdtprof.Connection = CN
            cmdtprof.Parameters.Clear()
            cmdtprof.CommandText = "psub"
            cmdtprof.CommandType = CommandType.StoredProcedure
            cmdtprof.Parameters.AddWithValue("esl_no", esl_no)
            cmdtprof.Parameters.AddWithValue("yearn", yearn)
            cmdtprof.Parameters.AddWithValue("bran", bran)
            Adtprof.SelectCommand = cmdtprof
            Adtprof.Fill(DBS, "tprof")
            DBS.Tables("tprof").Clear()
            Adtprof.Fill(DBS, "tprof")
            '====================END===============================
            If DBS.Tables("tprof").Rows.Count > 0 Then
                oj.Load(Application.StartupPath & rrpt & "\res_sub.rpt")
                oj.Database.Tables(0).SetDataSource(DBS.Tables("tprof"))
                oj.SetParameterValue("REF", 1)
                oj.SetParameterValue("11", 0)
                rp.CrystalReportViewer1.ReportSource = oj
                rp.CrystalReportViewer1.ShowPrintButton = False
                rp.CrystalReportViewer1.ShowExportButton = False
                rp.ShowDialog()
            End If
            '======================================cult================
            cmdtcult.Connection = CN
            cmdtcult.Parameters.Clear()
            cmdtcult.CommandText = "pcult"
            cmdtcult.CommandType = CommandType.StoredProcedure
            cmdtcult.Parameters.AddWithValue("esl_no", esl_no)
            cmdtcult.Parameters.AddWithValue("yearn", yearn)
            cmdtcult.Parameters.AddWithValue("bran", bran)
            Adtcult.SelectCommand = cmdtcult
            Adtcult.Fill(DBS, "tcult")
            DBS.Tables("tcult").Clear()
            Adtcult.Fill(DBS, "tcult")
            If DBS.Tables("tcult").Rows.Count > 0 Then
                oj.Load(Application.StartupPath & rrpt & "\res cult.rpt")
                oj.Database.Tables(0).SetDataSource(DBS.Tables("tcult"))
                oj.SetParameterValue("REF", 1)
                oj.SetParameterValue("11", 0)
                rp.CrystalReportViewer1.ReportSource = oj
                rp.CrystalReportViewer1.ShowPrintButton = False
                rp.CrystalReportViewer1.ShowExportButton = False
                'oj.PrintToPrinter(1, False, 0, 0)
                rp.ShowDialog()
            End If
        End If
    End Sub

    Private Sub FINDBYCODEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FINDBYCODEToolStripMenuItem.Click
        Dim aa As String
        aa = InputBox("ÇÏÎá ÑÞã ÇáÇíÕÇá ¿")
        Dim n As Int16 = 0
        res(aa, LBILL.YEARN.Text, LBILL.bran.Text)

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub
    Public Sub GRDT()
        Dim aaaa As Integer = 0
        group_name.Text = TextBox3.Text
        dr.Close()
        cmd.CommandText = "SELECT * FROM lgroup_price WHERE Gname='" & group_name.Text & "' and  book_price_CODE='" & BOOK_CODE.Text & "' "
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = False Then
            TOT1.Text = 0
            aaaa = 1
        Else
            TOT1.Text = dr("tot")
        End If
        ACdr.Close()
        dr.Close()
        cmd.CommandText = "select * from lgroup_test where gname='" & group_name.Text & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            ACcmd.CommandText = "update test_pricet set qun=1,TOT1='" & Val(TOT1.Text) & "',bar='" & group_name.Text & "',TOT2='1'  where test_code=" & dr("test_code")
            ACcmd.ExecuteNonQuery()
        End If
        While dr.Read
            ACcmd.CommandText = "update test_pricet set qun=1,TOT1='" & Val(TOT1.Text) & "',bar='" & group_name.Text & "',TOT2='2'  where test_code=" & dr("test_code")
            ACcmd.ExecuteNonQuery()
        End While
        If aaaa = 1 Then
            ACdr.Close()
            ACcmd.CommandText = "select sum(tot) from test_pricet where bar='" & group_name.Text & "'"
            ACdr = ACcmd.ExecuteReader
            ACdr.Read()
            Dim ssum As Integer = ACdr(0)
            ACdr.Close()
            ACcmd.CommandText = "update test_pricet set TOT1='" & Val(ssum) & "'  where  bar='" & group_name.Text & "'"
            ACcmd.ExecuteNonQuery()

        End If
        If IsNumeric(TextBox3.Text) = True Then
            ACdr.Close()
            ACcmd.CommandText = "update test_pricet set bar=test_name  where bar='" & TextBox3.Text & "'"
            ACcmd.ExecuteNonQuery()
        End If
        Tfprice(1)
        SUMT()
    End Sub
    Public Sub Tfprice(ByVal s As Integer)
        Dim yy As String = ""
        If s = 1 Then yy = "where qun=1"
        cmdBILLT.CommandText = "select * from TEST_PRICET " & yy & "  order by so"
        adBILLT.SelectCommand = cmdBILLT
        adBILLT.Fill(DBS, "BILLT")
        BILLT = DBS.Tables("BILLT")
        DBS.Tables("BILLT").Clear()
        adBILLT.Fill(DBS, "BILLT")
        BILLT = DBS.Tables("BILLT")
        btestd.DataSource = BILLT

    End Sub

    Private Sub TextBox3_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.GotFocus
        flng("EN")
    End Sub

    Private Sub TextBox3_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox3.KeyUp
        Dim yys As String
        If e.KeyCode = Keys.Enter Then
            FRC = gen.Select("NAME1='" & TextBox3.Text & "'")
            YYS = "shortname='" & TextBox3.Text & "'"
            Dim yyn As String = "shortname"
            Dim nna As Int16 = 0
            If FRC.Length > 0 Then
                RC = FRC(0)
                nna = RC("f")
                If nna = 1 Then yys = "shortname"
                If nna = 2 Then yys = "test_name"
                If nna = 4 Then yys = "test_ar"
                If nna = 5 Then yys = "gr_name" : yyn = yys
                If nna = 6 Then
                    GRDT()
                End If
            End If
            If nna <> 6 Then
                ACdr.Close()
                ACcmd.CommandText = "update TEST_PRICET set qun=1,bar=" & yyn & " ,TOT2='0' where " & yys & "='" & TextBox3.Text & "'"
                ACcmd.ExecuteNonQuery()
            End If
            If IsNumeric(TextBox3.Text) = True Then
                ACdr.Close()
                ACcmd.CommandText = "update TEST_PRICET set bar=test_name  where bar='" & TextBox3.Text & "'"
                ACcmd.ExecuteNonQuery()
            End If
            TextBox3.Text = ""
            TextBox3.Focus()
            If Val(dissn.Text) > 0 Then
                ACdr.Close()
                ACcmd.CommandText = "update TEST_PRICET set dis_n='" & Val(dissn.Text) & "'"
                ACcmd.ExecuteNonQuery()
            End If
            Tfprice(1)
            SUMT()
            TextBox3.Text = ""

        Else
            FRC = gen.Select("NAME1='" & TextBox3.Text & "'")
            yys = "shortname"
            If FRC.Length > 0 Then
                RC = FRC(0)
                If RC("f") = 1 Then yys = "shortname"
                If RC("f") = 2 Then yys = "test_name"
                If RC("f") = 3 Then yys = "test_code"
                If RC("f") = 4 Then yys = "test_ar"
                If RC("f") = 5 Then yys = "gr_name"
                If RC("f") = 6 Then
                    yys = "bar"
                    ACdr.Close()
                    dr.Close()
                    group_name.Text = TextBox3.Text
                    cmd.CommandText = "select * from lgroup_test where gname='" & group_name.Text & "'"
                    dr = cmd.ExecuteReader
                    While dr.Read
                        ACcmd.CommandText = "update TEST_PRICET set bar='" & group_name.Text & "'  where test_code=" & dr("test_code")
                        ACcmd.ExecuteNonQuery()
                    End While
                    cmdBILLT.CommandText = "select * from TEST_PRICET WHERE " & yys & " ='" & TextBox3.Text & "'"
                    ADBILLT.SelectCommand = cmdBILLT
                    ADBILLT.Fill(DBS, "BILLT")
                    BILLT = DBS.Tables("BILLT")
                    DBS.Tables("BILLT").Clear()
                    ADBILLT.Fill(DBS, "BILLT")
                    BILLT = DBS.Tables("BILLT")
                    btestd.DataSource = BILLT
                Else
                    cmdBILLT.CommandText = "select * from TEST_PRICET WHERE " & yys & " LIKE '%" & TextBox3.Text & "%'"
                    ADBILLT.SelectCommand = cmdBILLT
                    ADBILLT.Fill(DBS, "BILLT")
                    BILLT = DBS.Tables("BILLT")
                    DBS.Tables("BILLT").Clear()
                    ADBILLT.Fill(DBS, "BILLT")
                    BILLT = DBS.Tables("BILLT")
                    btestd.DataSource = BILLT
                End If
            End If
            Tfprice(1)
        End If

    End Sub
    Public Sub SUMT()
        If val(dissn.Text) > 0 Then DISS.Text = 0
        Dim ss As Integer = 0
        'ACdr.Close()
        'ACcmd.CommandText = "update TEST_PRICET set dis_n='" & Val(dissn.Text) & "'"
        'ACcmd.ExecuteNonQuery()
        'fprice(1)
        ACdr.Close()
        ACcmd.CommandText = "update TEST_PRICET set dis=0"
        ACcmd.ExecuteNonQuery()
        ACdr.Close()
        ACcmd.CommandText = "update TEST_PRICET set dis=dis_n*tot*.01 where tot2=0"
        ACcmd.ExecuteNonQuery()
        ACdr.Close()
        ACcmd.CommandText = "update TEST_PRICET set dis=dis_n*tot1*.01 where tot2=1"
        ACcmd.ExecuteNonQuery()
        ACcmd.CommandText = "SELECT SUM (TOT),max(ResultAfter),sum(dis),SUM(qun),sum(pricep),sum(priceV) FROM TEST_PRICET WHERE QUN=1 and tot1=0"
        ACdr = ACcmd.ExecuteReader
        ACdr.Read()
        If nulls(ACdr(4)) > 0 Then
            bon.Text = nulls(ACdr(5))
            TOT.Text = nulls(ACdr(0))
            DISS.Text = TOT.Text - nulls(ACdr(4)) - nulls(ACdr(5))
        Else
            TOT.Text = nulls(ACdr(0))
            If nulls(ACdr(2)) > 0 Then DISS.Text = nulls(ACdr(2))

        End If
        ss = nulls(ACdr(1))
        ACdr.Close()
        ACcmd.CommandText = "SELECT sum(TOT1) FROM TEST_PRICET WHERE tot2=1 and qun>0 "
        ACdr = ACcmd.ExecuteReader
        While ACdr.Read
            TOT.Text = ACdr(0) + TOT.Text
        End While
        Dim eee As Int16 = 0
        REST.Text = 0
        'DISS.Text = Val(dissn.Text) * Val(TOT.Text) * 0.01
        ACdr.Close()
        ACdr.Close()
        ACcmd.CommandText = "SELECT sum(dis) FROM TEST_PRICET WHERE QUN=1 and tot2=1"
        ACdr = ACcmd.ExecuteReader
        ACdr.Read()
        DISS.Text = Math.Round(Val(DISS.Text) + nulls(ACdr(0)), 0)
        ' ccc.Text = Val(TOT.Text) - Val(bon.Text)
        FUNDT()

    End Sub
    Public Sub FUNDT()
        CASH_V.Text = Val(TOT.Text) * Val(cash_per.Text) * 0.01

        CRD_V.Text = Val(TOT.Text) * Val(CRD_PER.Text) * 0.01
        PAY.Text = Val(CASH_V.Text) - Val(DISS.Text) - Val(bon.Text)
    End Sub
    Private Sub TextBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        dr.Close()
        cmd.CommandText = "select * from lbook_price where   name='" & BOOK_name.Text & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        BOOK_CODE.Text = dr("code")
        TPRICET()
        Tfprice(1)
        SUMT()
        MsgBox("Êã ÊÛííÑ ßÊíÈ ÇáÇÓÚÇÑ")
    End Sub
    Public Sub TPRICET()
        ACdr.Close()

        ACcmd.CommandText = "update test_priceT set  tot=price" & BOOK_CODE.Text & ""
        ACcmd.ExecuteNonQuery()
        ACdr.Close()
        ACcmd.CommandText = "update test_price set  tot=0, labprice=0 where tot is null"
        ACcmd.ExecuteNonQuery()
        TextBox3.Text = ""
        If Val(PCRD.Text) = 1 Then
            ACdr.Close()
            dr.Close()
            cmd.CommandText = "select * from ltest_price where book_price_code='" & BOOK_CODE.Text & "'"
            dr = cmd.ExecuteReader
            While dr.Read
                ACcmd.CommandText = "update test_price set pricep='" & nulls(dr("p1")) & "',priceV='" & nulls(dr("V1")) & "' where test_code=" & dr("test_code")
                ACcmd.ExecuteNonQuery()
            End While
        End If

    End Sub
    Private Sub GlassButton93_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton93.Click
        Try
            cmdb.DataAdapter = ADBILLT
            ADBILLT.Update(DBS, "BILLT")
            SUMT()
            Tfprice(1)
        Catch ex As Exception
            Tfprice(1)
        End Try

    End Sub

    Private Sub dissn_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dissn.KeyUp
        If e.KeyCode = Keys.Enter Then
            DISS.Text = 0
            ACdr.Close()
            ACcmd.CommandText = "update test_priceT set dis_n='" & Val(dissn.Text) & "'"
            ACcmd.ExecuteNonQuery()
            Tfprice(1)
            SUMT()
        End If
    End Sub

    Private Sub dissn_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dissn.TextChanged

    End Sub

    Private Sub DISS_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DISS.TextChanged
        If Val(DISS.Text) > Val(TOT.Text) Then DISS.Text = 0

        FUNDT()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        dissn.Text = 0
        DISS.Text = 0
        bon.Text = 0
        ACdr.Close()
        ACcmd.CommandText = "update test_priceT set dis_n='" & Val(dissn.Text) & "',QUN=0"
        ACcmd.ExecuteNonQuery()
        Tfprice(1)
        SUMT()
    End Sub
End Class