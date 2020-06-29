
Public Class LBLD
    Dim apd As Int16 = 0
    Dim cmda As New OleDb.OleDbCommand
    Dim ada As New OleDb.OleDbDataAdapter
    Dim a As New DataTable
    Dim cmdsotr As New OleDb.OleDbCommand
    Dim adsotr As New OleDb.OleDbDataAdapter
    Dim sotr As New DataTable
    Dim cmdpvw As New OleDb.OleDbCommand
    Dim adpvw As New OleDb.OleDbDataAdapter
    Dim pvw As New DataTable
    Dim cmdpack As New OleDb.OleDbCommand
    Dim adpack As New OleDb.OleDbDataAdapter
    Dim pack As New DataTable
    Dim cmda1 As New OleDb.OleDbCommand
    Dim ada1 As New OleDb.OleDbDataAdapter
    Dim a1 As New DataTable
    Dim cmdresc As New OleDb.OleDbCommand
    Dim adresc As New OleDb.OleDbDataAdapter
    Dim resc As New DataTable
    Dim cmdgr As New OleDb.OleDbCommand
    Dim adgr As New OleDb.OleDbDataAdapter
    Dim gr As New DataTable
    Dim cmdasm As New OleDb.OleDbCommand
    Dim adasm As New OleDb.OleDbDataAdapter
    Dim asm As New DataTable
    Dim cmdbook As New OleDb.OleDbCommand
    Dim adbook As New OleDb.OleDbDataAdapter
    Dim book As New DataTable
    Dim cmdLGTEST As New OleDb.OleDbCommand
    Dim adLGTEST As New OleDb.OleDbDataAdapter
    Dim LGTEST As New DataTable
    Dim cmdLcult As New OleDb.OleDbCommand
    Dim adLcult As New OleDb.OleDbDataAdapter
    Dim lcult As New DataTable
    Dim cmdLreg As New OleDb.OleDbCommand
    Dim adLreg As New OleDb.OleDbDataAdapter
    Dim lreg As New DataTable
    Dim cmdLdoc As New OleDb.OleDbCommand
    Dim adLdoc As New OleDb.OleDbDataAdapter
    Dim ldoc As New DataTable
    Dim cmdlshift As New OleDb.OleDbCommand
    Dim adlshift As New OleDb.OleDbDataAdapter
    Dim lshift As New DataTable
    Dim cmdgg As New OleDb.OleDbCommand
    Dim adgg As New OleDb.OleDbDataAdapter
    Dim gg As New DataTable
    Dim cmdLgroup_price As New OleDb.OleDbCommand
    Dim adLgroup_price As New OleDb.OleDbDataAdapter
    Dim Lgroup_price As New DataTable
    Dim cmdbook_price As New OleDb.OleDbCommand
    Dim adbook_price As New OleDb.OleDbDataAdapter
    Dim book_price As New DataTable
    Dim cmdbook_price2 As New OleDb.OleDbCommand
    Dim adbook_price2 As New OleDb.OleDbDataAdapter
    Dim book_price2 As New DataTable
    Dim cmdLnsTEST As New OleDb.OleDbCommand
    Dim adLnsTEST As New OleDb.OleDbDataAdapter
    Dim LnsTEST As New DataTable
    Dim cmdLTEST As New OleDb.OleDbCommand
    Dim adLTEST As New OleDb.OleDbDataAdapter
    Dim LTEST As New DataTable
    Dim cmdLSUBTEST As New OleDb.OleDbCommand
    Dim adLSUBTEST As New OleDb.OleDbDataAdapter
    Dim LSUBTEST As New DataTable
    Dim cmdLTEST1 As New OleDb.OleDbCommand
    Dim adLTEST1 As New OleDb.OleDbDataAdapter
    Dim LTEST1 As New DataTable
    Dim cmdLNTEST As New OleDb.OleDbCommand
    Dim adLNTEST As New OleDb.OleDbDataAdapter
    Dim LNTEST As New DataTable
    Dim cmdcompany As New OleDb.OleDbCommand
    Dim adcompany As New OleDb.OleDbDataAdapter
    Dim company As New DataTable
    Dim cmdtest_price As New OleDb.OleDbCommand
    Dim adtest_price As New OleDb.OleDbDataAdapter
    Dim test_price As New DataTable
    Dim cmdgroup As New OleDb.OleDbCommand
    Dim adgroup As New OleDb.OleDbDataAdapter
    Dim group As New DataTable
    Dim cmdusers As New OleDb.OleDbCommand
    Dim adusers As New OleDb.OleDbDataAdapter
    Dim users As New DataTable
    Dim r, EX, tr, SR, co, re, DE, cultr, mng As Integer

    Private Sub GlassButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TabPage2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage2.Click

    End Sub

    Public Sub grf()
        cmdgr.Connection = CN
        cmdgr.CommandType = CommandType.Text
        cmdgr.CommandText = "select * from lgr"
        adgr.SelectCommand = cmdgr
        adgr.Fill(DBS, "gr")
        gr = DBS.Tables("gr")
        DBS.Tables("gr").Clear()
        adgr.Fill(DBS, "gr")
        gr = DBS.Tables("gr")
        gr_name.DataSource = gr
        gr_name.DisplayMember = "NAME"
    End Sub
    Public Sub groupf()
        cmdgroup.Connection = CN
        cmdgroup.CommandType = CommandType.Text
        cmdgroup.CommandText = "select * from lgroup order by name"
        adgroup.SelectCommand = cmdgroup
        adgroup.Fill(DBS, "group")
        group = DBS.Tables("group")
        DBS.Tables("group").Clear()
        adgroup.Fill(DBS, "group")
        group = DBS.Tables("group")
        group_name.DataSource = group
        group_name.DisplayMember = "NAME"
    End Sub
    Public Sub bookf()
        cmdbook_price.Connection = CN
        cmdbook_price.CommandType = CommandType.Text
        cmdbook_price.CommandText = "select * from lbook_price"
        adbook_price.SelectCommand = cmdbook_price
        adbook_price.Fill(DBS, "book_price")
        book_price = DBS.Tables("book_price")
        DBS.Tables("book_price").Clear()
        adbook_price.Fill(DBS, "book_price")
        book_price = DBS.Tables("book_price")
        book_price_name.DataSource = book_price
        book_price_name.DisplayMember = "NAME"
        pbook_price_name.DataSource = book_price
        pbook_price_name.DisplayMember = "NAME"
        dbook_price_name.DataSource = book_price
        dbook_price_name.DisplayMember = "NAME"
        cmdbook_price2.Connection = CN
        cmdbook_price2.CommandType = CommandType.Text
        cmdbook_price2.CommandText = "select * from lbook_price"
        adbook_price2.SelectCommand = cmdbook_price2
        adbook_price2.Fill(DBS, "book_price2")
        book_price2 = DBS.Tables("book_price2")
        DBS.Tables("book_price2").Clear()
        adbook_price2.Fill(DBS, "book_price2")
        book_price2 = DBS.Tables("book_price2")
        cbook_price_name.DataSource = book_price2
        cbook_price_name.DisplayMember = "NAME"
        gbook_price_name.DataSource = book_price2
        gbook_price_name.DisplayMember = "NAME"
    End Sub

    Private Sub LBLD_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If apd = 1 Then
            dr.Close()
            cmd.CommandText = "update device set flg=1"
            cmd.ExecuteNonQuery()
        End If
       
    End Sub
    Private Sub LBLD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        If mluser = 0 Then TabControl1.TabPages.Remove(TabPage12)
        dr.Close()
        dr.Close()
        KID_TYPE.Items.Clear()
        cmd.CommandText = "select * from lshift "
        dr = cmd.ExecuteReader
        While dr.Read
            ComboBox1.Items.Add(dr("name"))
        End While

        colu(Me, bColor.Text, fcolor.Text)
        dr.Close() : cmd.CommandText = "select * from USERS where NAME='" & USR & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            mng = dr("admin")
        End If
        dr.Close()
        KID_TYPE.Items.Clear()
        cmd.CommandText = "select * from lkid_type "
        dr = cmd.ExecuteReader
        While dr.Read
            KID_TYPE.Items.Add(dr("name"))
            KID_TYPE.Text = dr("name")
        End While

        dr.Close()
        cmd.CommandText = "select * from lunits "
        dr = cmd.ExecuteReader
        While dr.Read
            nunit.Items.Add(dr("name"))
            nsunit.Items.Add(dr("name"))
        End While
        dr.Close()
        KID_TYPE.Items.Clear()
        cmd.CommandText = "select * from branch "
        dr = cmd.ExecuteReader
        While dr.Read
            branch_name.Items.Add(dr("name"))
        End While
        cmdsotr.Connection = CN
        cmdsotr.CommandType = CommandType.Text
        cmdsotr.CommandText = "select * from iface where sorting>=1"
        adsotr.SelectCommand = cmdsotr
        adsotr.Fill(DBS, "sotr")
        sotr = DBS.Tables("sotr")
        DBS.Tables("sotr").Clear()
        adsotr.Fill(DBS, "sotr")
        sotr = DBS.Tables("sotr")
        dataso.DataSource = sotr

        cmdpack.Connection = CN
        cmdpack.CommandType = CommandType.Text
        cmdpack.CommandText = "select * from lpack"
        adpack.SelectCommand = cmdpack
        adpack.Fill(DBS, "pack")
        pack = DBS.Tables("pack")
        DBS.Tables("pack").Clear()
        adpack.Fill(DBS, "pack")
        pack = DBS.Tables("pack")
        pack_name.DataSource = pack
        pack_name.DisplayMember = "pack_NAME"
        dr.Close()
        ask1.Items.Clear()
        cmd.CommandText = "select ask from lask group by ask "
        dr = cmd.ExecuteReader
        While dr.Read
            ask1.Items.Add(dr("ask"))
        End While
        dr.Close()
        PRNT.Items.Clear()
        cmd.CommandText = "select * from LPRNT "
        dr = cmd.ExecuteReader
        While dr.Read
            PRNT.Items.Add(dr("NAME"))
        End While
        cmdasm.Connection = CN
        cmdasm.CommandType = CommandType.Text
        cmdasm.CommandText = "select * from iface where flg=1"
        adasm.SelectCommand = cmdasm
        adasm.Fill(DBS, "asm")
        asm = DBS.Tables("asm")
        DBS.Tables("asm").Clear()
        adasm.Fill(DBS, "asm")
        asm = DBS.Tables("asm")
        asmdb.DataSource = asm

        Dim n As Integer = 0
        While Not n = asmdb.ColumnCount
            asmdb.Columns(n).Visible = False
            n = n + 1
        End While
        asmdb.Columns("ar").Visible = True
        asmdb.Columns("ar").HeaderText = "⁄—»Ï"
        asmdb.Columns("ar").Width = 300
        asmdb.Columns("en").Visible = True
        asmdb.Columns("en").HeaderText = "english"
        asmdb.Columns("en").Width = 300
        asmdb.Columns("Column2").Visible = True
        bookf()
        groupf()
        grf()
        GlassButton26_Click(GlassButton26, e)
        GlassButton27_Click(GlassButton27, e)
        GlassButton25_Click(GlassButton25, e)
        GlassButton36_Click(GlassButton36, e)
        GlassButton45_Click(GlassButton45, e)
        DataGridView1.Columns("code").HeaderText = "«·ﬂÊœ"
        DataGridView1.Columns("Name").Width = 200
        DataGridView1.Columns("Name").HeaderText = "en «”„ «·„Ã„Ê⁄… "
        DataGridView1.Columns("ar").Width = 200
        DataGridView2.Columns("KID_TYPE").HeaderText = "«·⁄Ì‰… "
        DataGridView2.Columns("KID_TYPE").Width = 50
        DataGridView1.Columns("ar").HeaderText = "ar «”„ «·„Ã„Ê⁄… "
        DataGridView2.Columns("gName").Width = 200
        DataGridView2.Columns("gName").HeaderText = "en «”„ «·„Ã„Ê⁄… "
        DataGridView2.Columns("ar").Width = 50
        DataGridView2.Columns("ar").HeaderText = "ar «”„ «· Õ·Ì· "
        DataGridView2.Columns("test_name").Width = 200
        DataGridView2.Columns("test_name").HeaderText = "en «”„ «· Õ·Ì· "
        DataGridView2.Columns("test_code").Visible = False
        DataGridView2.Columns("gcode").Visible = False
        DataGridView2.Columns("nor").HeaderText = "normal"
        DataGridView2.Columns("sub").HeaderText = " Õ·Ì· ›—⁄Ï"
        DataGridView2.Columns("ky").Visible = False
        DataGridView3.Columns("test_NAME").Width = 200
        DataGridView3.Columns("test_NAME").HeaderText = "  «· Õ·Ì· "
        DataGridView3.Columns("Mtest_name").Width = 200
        DataGridView3.Columns("Mtest_name").HeaderText = " Õ·Ì· ›—⁄Ï "
        DataGridView2.Columns("Rso").HeaderText = " — Ì» «· ”ÃÌ· "
        DataGridView2.Columns("so").HeaderText = " — Ì» «·ÿ»«⁄…"
        DataGridView2.Columns("so").Width = 50
        DataGridView2.Columns("Rso").Width = 50
        DataGridView2.Columns("LAB").Width = 50
        DataGridView2.Columns("ResultAfter").Width = 50
        DataGridView2.Columns("LAB").HeaderText = "OUT LAB"
        DataGridView3.Columns("Rso").HeaderText = " — Ì» «· ”ÃÌ· "
        DataGridView2.Columns("LCK").Width = 50
        DataGridView2.Columns("LCK").HeaderText = "FREEZ"
        DataGridView3.Columns("so").HeaderText = " — Ì» «·ÿ»«⁄…"
        DataGridView3.Columns("RES").HeaderText = "«·‰ ÌÃ…"

        DataGridView3.Columns("MTEST_NAME").Visible = False
        DataGridView3.Columns("MTEST_CODE").Visible = False
        DataGridView5.Columns("TEST_NAME").Visible = False
        DataGridView5.Columns("TEST_CODE").Visible = False
        DataGridView4.Columns("MTEST_NAME").Visible = False
        DataGridView4.Columns("MTEST_CODE").Visible = False
        DataGridView4.Columns("TEST_NAME").Visible = False
        DataGridView4.Columns("TEST_CODE").Visible = False
        DataGridView2.Columns("CollectionNote").Visible = False
        DataGridView2.Columns("KID_N").Visible = False
        DataGridView2.Columns("NormalRange").Visible = False
        DataGridView2.Columns("color").Visible = False
        DataGridView2.Columns("ST").Visible = False
        DataGridView2.Columns("mm").Visible = False
        DataGridView2.Columns("GR_CODE").Visible = False
        DataGridView2.Columns("W").Visible = False
        DataGridView2.Columns("QUN").Visible = False
        DataGridView2.Columns("NORMAL").Visible = False

        dr.Close()
        cmd.CommandText = "select * from users"
        dr = cmd.ExecuteReader
        suser.Items.Clear()
        While dr.Read = True
            suser.Items.Add(dr("name"))
        End While
        dr.Close()
        cmd.CommandText = "select * from LRCV"
        dr = cmd.ExecuteReader
        RCV_N.Items.Clear()
        While dr.Read = True
            RCV_N.Items.Add(dr("name"))
        End While
        dr.Close()
        cmd.CommandText = "select * from lshift"
        dr = cmd.ExecuteReader
        sshift.Items.Clear()
        While dr.Read = True
            sshift.Items.Add(dr("name"))
        End While
        dr.Close()
        cmd.CommandText = "select * from ltest"
        dr = cmd.ExecuteReader
        While dr.Read
            ttest_name.AutoCompleteCustomSource.Add(dr("test_name"))
            Ntest_NAME.AutoCompleteCustomSource.Add(dr("test_name"))
            ptest_name.AutoCompleteCustomSource.Add(dr("test_name"))
            test_name11.AutoCompleteCustomSource.Add(dr("test_name"))
            gtest_name.AutoCompleteCustomSource.Add(dr("test_name"))
        End While
        dr.Close()
        cmd.CommandText = "select * from lcompany"
        dr = cmd.ExecuteReader
        While dr.Read
            cname.AutoCompleteCustomSource.Add(dr("name"))
        End While
        '=====================LOAD EMP DATA===============================================
        dr.Close()
        cmd.CommandText = "select * from eemp"
        dr = cmd.ExecuteReader
        name1.AutoCompleteCustomSource.Clear()
        name2.AutoCompleteCustomSource.Clear()
        name3.AutoCompleteCustomSource.Clear()
        While dr.Read
            name1.AutoCompleteCustomSource.Add(dr("name"))
            name2.AutoCompleteCustomSource.Add(dr("name"))
            name3.AutoCompleteCustomSource.Add(dr("name"))
        End While
        '=====================================================================================
    End Sub

    Private Sub GlassButton25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton25.Click
        dr.Close() : cmd.CommandText = "select MAx(code) from LGTEST "
        dr = cmd.ExecuteReader
        dr.Read()
        If IsDBNull(dr(0)) = False Then
            gcode.Text = 1 + dr(0)
        Else
            gcode.Text = 1
        End If
        cmdLGTEST.Connection = CN
        cmdLGTEST.CommandType = CommandType.Text
        cmdLGTEST.CommandText = "select * FROM LGTEST"
        adLGTEST.SelectCommand = cmdLGTEST
        adLGTEST.Fill(DBS, "LGTEST")
        LGTEST = DBS.Tables("LGTEST")
        DBS.Tables("LGTEST").Clear()
        adLGTEST.Fill(DBS, "LGTEST")
        LGTEST = DBS.Tables("LGTEST")
        DataGridView1.DataSource = LGTEST
        grname.DataSource = LGTEST
        grname.DisplayMember = "NAME"
        gname.Text = ""
        gar.Text = ""
        gname.Focus()
    End Sub

    Private Sub GlassButton16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton16.Click
        If IsNumeric(gcode.Text) = False Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·ﬂÊœ") : Exit Sub
        If grname.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
        If IsNumeric(ttest_code.Text) = False Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·ﬂÊœ") : Exit Sub
        If ttest_name.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
        If IsNumeric(so.Text) = False Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·ﬂÊœ") : Exit Sub

        dr.Close()
        cmd.CommandText = "select * from LTEST where   test_code='" & ttest_code.Text & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Dim n As String
            n = MsgBox(" Â·  —Ìœ «· ⁄œÌ· ø", MsgBoxStyle.YesNo)
            If n = vbNo Then Exit Sub
            dr.Close()
            cmd.CommandText = "delete from LTEST where    test_code='" & ttest_code.Text & "'"
            cmd.ExecuteNonQuery()

        End If
        dr.Close() : cmd.CommandText = "insert into LTEST (test_code,test_name,AR,Gcode,Gname,SO,SUB,NOR,CULT,[CollectionNote],[KID_N],[KID_TYPE],[ResultAfter],[NormalRange],short,gr_name,gr_code,cal)  values ('" & ttest_code.Text & "','" & Trim(ttest_name.Text) & "','" & Trim(tar.Text) & "','" & grcode.Text & "','" & grname.Text & "','" & so.Text & "','" & Val(tsub.CheckState) & "','" & Val(nor.CheckState) & "','" & Val(cult.CheckState) & "','" & CollectionNote.Text & "','" & KID_N.Text & "','" & KID_TYPE.Text & "','" & ResultAfter.Text & "','" & NormalRange.Text & "' ,'" & Trim(lshort.Text) & "','" & gr_name.Text & "','" & gr_code.Text & "','" & Val(cal.CheckState) & "')"
        cmd.ExecuteNonQuery()
        ttest_name.AutoCompleteCustomSource.Add(Trim(ttest_name.Text))
        Ntest_NAME.AutoCompleteCustomSource.Add(Trim(ttest_name.Text))
        ptest_name.AutoCompleteCustomSource.Add(Trim(ttest_name.Text))
        test_name11.AutoCompleteCustomSource.Add(Trim(ttest_name.Text))
        gtest_name.AutoCompleteCustomSource.Add(Trim(ttest_name.Text))
        apd = 1
        LLOG("Õ›Ÿ ÃœÌœ", 0, "Õ›Ÿ  Õ·Ì· " & ttest_name.Text, 1, BRAN.Text)

        GlassButton26_Click(GlassButton26, e)
    End Sub

    Private Sub GlassButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton8.Click
        If IsNumeric(gcode.Text) = False Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·ﬂÊœ") : Exit Sub
        If gname.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
        dr.Close()
        cmd.CommandText = "select * from LGTEST where   code='" & gcode.Text & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Dim n As String
            n = MsgBox(" Â·  —Ìœ «· ⁄œÌ· ø", MsgBoxStyle.YesNo)
            If n = vbNo Then Exit Sub
            dr.Close()
            cmd.CommandText = "delete from LGTEST where    code='" & gcode.Text & "'"
            cmd.ExecuteNonQuery()
        End If
        dr.Close()
        cmd.CommandText = "select * from LGTEST where   name='" & gname.Text & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Dim n As String
            n = MsgBox(" Â·  —Ìœ «· ⁄œÌ· ø", MsgBoxStyle.YesNo)
            If n = vbNo Then Exit Sub
            dr.Close()
            cmd.CommandText = "delete from LGTEST where name='" & gname.Text & "'"
            cmd.ExecuteNonQuery()
        End If
        dr.Close() : cmd.CommandText = "insert into LGTEST (code,name,AR)  values ('" & gcode.Text & "','" & Trim(gname.Text) & "','" & gar.Text & "')"
        cmd.ExecuteNonQuery()

        GlassButton25_Click(GlassButton25, e)
    End Sub

    Private Sub GlassButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton7.Click
        If IsNumeric(gcode.Text) = False Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·ﬂÊœ") : Exit Sub
        If gcode.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
        dr.Close()
        cmd.CommandText = "select * from LGTEST where   code='" & gcode.Text & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Dim n As String
            n = MsgBox(" Â·  —Ìœ «·Õ–› ø", MsgBoxStyle.YesNo)
            If n = vbNo Then Exit Sub
            dr.Close()
            cmd.CommandText = "delete from LGTEST where    code='" & gcode.Text & "'"
            cmd.ExecuteNonQuery()

        End If
        GlassButton25_Click(GlassButton25, e)
    End Sub

    Private Sub GlassButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton5.Click
        If LGTEST.Rows.Count <= 0 Then MsgBox("·«  ÊÃœ »Ì«‰« ") : Exit Sub
        r = 0
        gcode.Text = LGTEST.Rows(r).Item("code")
        gar.Text = LGTEST.Rows(r).Item("AR")
        gname.Text = LGTEST.Rows(r).Item("name")
    End Sub

    Private Sub GlassButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton4.Click
        If LGTEST.Rows.Count <= 0 Then MsgBox("·«  ÊÃœ »Ì«‰« ") : Exit Sub
        r = r - 1
        If r < 0 Then r = 0
        gcode.Text = LGTEST.Rows(r).Item("code")
        gar.Text = LGTEST.Rows(r).Item("AR")
        gname.Text = LGTEST.Rows(r).Item("name")
    End Sub

    Private Sub GlassButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton3.Click
        If LGTEST.Rows.Count <= 0 Then MsgBox("·«  ÊÃœ »Ì«‰« ") : Exit Sub
        r = r + 1
        If r >= LGTEST.Rows.Count Then r = LGTEST.Rows.Count - 1

        gcode.Text = LGTEST.Rows(r).Item("code")
        gar.Text = LGTEST.Rows(r).Item("AR")
        gname.Text = LGTEST.Rows(r).Item("name")

    End Sub

    Private Sub GlassButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton2.Click
        If LGTEST.Rows.Count <= 0 Then MsgBox("·«  ÊÃœ »Ì«‰« ") : Exit Sub
        r = LGTEST.Rows.Count - 1
        gcode.Text = LGTEST.Rows(r).Item("code")
        gar.Text = LGTEST.Rows(r).Item("AR")
        gname.Text = LGTEST.Rows(r).Item("name")
    End Sub

    Private Sub gname_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles gname.GotFocus
        flng("EN")
    End Sub

    Private Sub gname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gname.KeyDown
        If e.KeyCode = Keys.Enter Then
            gar.Focus()
        End If
    End Sub

    Private Sub gname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gname.TextChanged

    End Sub

    Private Sub gar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles gar.GotFocus
        flng("EN")

    End Sub

    Private Sub gar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gar.KeyDown
        If e.KeyCode = Keys.Enter Then
            GlassButton8_Click(GlassButton8, e)
        End If
    End Sub

    Private Sub gar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gar.TextChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        On Error Resume Next
        gcode.Text = DataGridView1(("CODE"), e.RowIndex).Value
        gname.Text = DataGridView1(("NAME"), e.RowIndex).Value
        gar.Text = DataGridView1(("AR"), e.RowIndex).Value
    End Sub

    Private Sub GlassButton26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton26.Click
        dr.Close() : cmd.CommandText = "select MAx(test_code),MAX(SO) from LTEST "
        dr = cmd.ExecuteReader
        dr.Read()
        If IsDBNull(dr(0)) = False Then
            ttest_code.Text = 1 + dr(0)
        Else
            ttest_code.Text = 1
        End If
        If IsDBNull(dr(1)) = False Then
            so.Text = 1 + dr(1)
        Else
            so.Text = 1
        End If
        cmdLTEST.Connection = CN
        cmdLTEST.CommandType = CommandType.Text
        cmdLTEST.CommandText = "select * FROM LTEST"
        adLTEST.SelectCommand = cmdLTEST
        adLTEST.Fill(DBS, "LTEST")
        LTEST = DBS.Tables("LTEST")
        DBS.Tables("LTEST").Clear()
        adLTEST.Fill(DBS, "LTEST")
        LTEST = DBS.Tables("LTEST")
        DataGridView2.DataSource = LTEST
        cmdLTEST1.Connection = CN
        cmdLTEST1.CommandType = CommandType.Text
        cmdLTEST1.CommandText = "select * FROM LTEST WHERE SUB=1"
        adLTEST1.SelectCommand = cmdLTEST1
        adLTEST1.Fill(DBS, "LTEST1")
        LTEST1 = DBS.Tables("LTEST1")
        DBS.Tables("LTEST1").Clear()
        adLTEST1.Fill(DBS, "LTEST1")
        LTEST1 = DBS.Tables("LTEST1")
        mtest_name.DataSource = LTEST1
        mtest_name.DisplayMember = "test_NAME"
        nmtest_name.DataSource = LTEST1
        nmtest_name.DisplayMember = "test_NAME"
        ttest_name.Text = ""

        tar.Text = ""
        gname.Focus()

        cmdresc.Connection = CN
        cmdresc.CommandType = CommandType.Text
        cmdresc.CommandText = "select * FROM Lres "
        adresc.SelectCommand = cmdresc
        adresc.Fill(DBS, "resc")
        resc = DBS.Tables("resc")
        DBS.Tables("resc").Clear()
        adresc.Fill(DBS, "resc")
        resc = DBS.Tables("resc")
        ltestres.DataSource = resc
        ltestres.DisplayMember = "NAME"
        ComboBox3.DataSource = resc
        ComboBox3.DisplayMember = "NAME"

    End Sub

    Private Sub grname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grname.SelectedIndexChanged
        If grname.Focused = False Then Exit Sub
        If grname.Text = "" Then Exit Sub
        If EX = 1 Then Exit Sub
        FRC = LGTEST.Select("NAME='" & grname.Text & "'")
        If FRC.Length <= 0 Then
            grname.Text = ""
            grcode.Text = ""
            Exit Sub
        Else
            RC = FRC(0)
            grcode.Text = RC("code")
            If EX = 1 Then Exit Sub
            If cgrname.Checked = False Then Exit Sub
            cmdLTEST.Connection = CN
            cmdLTEST.CommandType = CommandType.Text
            cmdLTEST.CommandText = "select * FROM LTEST where gname ='" & grname.Text & "'"
            adLTEST.SelectCommand = cmdLTEST
            adLTEST.Fill(DBS, "LTEST")
            LTEST = DBS.Tables("LTEST")
            DBS.Tables("LTEST").Clear()
            adLTEST.Fill(DBS, "LTEST")
            LTEST = DBS.Tables("LTEST")
            DataGridView2.DataSource = LTEST
        End If

    End Sub

    Private Sub ttest_name_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ttest_name.GotFocus
      flng("EN")
    End Sub

    Private Sub ttest_name_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ttest_name.KeyUp
        On Error Resume Next
        If e.KeyCode = Keys.Enter Then
            If ttest_name.Text = "" Then Exit Sub
            dr.Close()
            cmd.CommandText = "select * from ltest where test_name='" & ttest_name.Text & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then
                gr_code.Text = dr("gr_code")
                gr_name.Text = dr("gr_name")
                ttest_code.Text = dr("test_CODE")
                ttest_name.Text = dr("test_NAME")
                Ntest_CODE.Text = dr("test_CODE")
                Ntest_NAME.Text = dr("test_CODE")
                tar.Text = dr("AR")
                grcode.Text = dr("GCODE")
                grname.Text = dr("GNAME")
                so.Text = dr("SO")
                nor.Checked = dr("NOR")
                tsub.Checked = dr("SUB")
                cult.Checked = dr("CULT")
                CollectionNote.Text = dr("CollectionNote")
                KID_N.Text = dr("KID_N")
                KID_TYPE.Text = dr("KID_TYPE")
                ResultAfter.Text = dr("ResultAfter")
                NormalRange.Text = dr("NormalRange")
                lshort.Text = dr("short")
            End If
        Else
            If ttest_name.Text = "" Then Exit Sub
            cmdLTEST.Connection = CN
            cmdLTEST.CommandType = CommandType.Text
            cmdLTEST.CommandText = "select * FROM LTEST where test_name like '%" & ttest_name.Text & "%'"
            adLTEST.SelectCommand = cmdLTEST
            adLTEST.Fill(DBS, "LTEST")
            LTEST = DBS.Tables("LTEST")
            DBS.Tables("LTEST").Clear()
            adLTEST.Fill(DBS, "LTEST")
            LTEST = DBS.Tables("LTEST")
            DataGridView2.DataSource = LTEST

        End If

    End Sub

    Private Sub ttest_name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ttest_name.TextChanged

    End Sub

    Private Sub tar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tar.GotFocus
        For Each Lng As InputLanguage In InputLanguage.InstalledInputLanguages
            If Lng.Culture.DisplayName.ToUpper.StartsWith("AR") Then
                InputLanguage.CurrentInputLanguage = Lng
                Exit For
            End If
        Next

    End Sub

    Private Sub tar_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tar.KeyUp
        cmdLTEST.Connection = CN
        cmdLTEST.CommandType = CommandType.Text
        cmdLTEST.CommandText = "select * FROM LTEST where ar like '%" & tar.Text & "%'"
        adLTEST.SelectCommand = cmdLTEST
        adLTEST.Fill(DBS, "LTEST")
        LTEST = DBS.Tables("LTEST")
        DBS.Tables("LTEST").Clear()
        adLTEST.Fill(DBS, "LTEST")
        LTEST = DBS.Tables("LTEST")
        DataGridView2.DataSource = LTEST
    End Sub

    Private Sub tar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tar.TextChanged

    End Sub

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub DataGridView2_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellEndEdit
        'DataGridView2("BRAN", e.RowIndex).Value = sbran

        'DataGridView2("BRAN", e.RowIndex).Value = sbran
        cmdb.DataAdapter = adLTEST
        adLTEST.Update(DBS, "LTEST")

        apd = 1
    End Sub

    Private Sub DataGridView2_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellLeave

    End Sub

    Private Sub DataGridView2_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView2.CellMouseClick
        On Error Resume Next
        gr_code.Text = DataGridView2(("gr_code"), e.RowIndex).Value
        gr_name.Text = DataGridView2(("gr_name"), e.RowIndex).Value
        ttest_code.Text = DataGridView2(("test_CODE"), e.RowIndex).Value
        ttest_name.Text = DataGridView2(("test_NAME"), e.RowIndex).Value
        Ntest_CODE.Text = DataGridView2(("CODE"), e.RowIndex).Value
        Ntest_NAME.Text = DataGridView2(("NAME"), e.RowIndex).Value
        tar.Text = DataGridView2(("AR"), e.RowIndex).Value
        grcode.Text = DataGridView2(("GCODE"), e.RowIndex).Value
        grname.Text = DataGridView2(("GNAME"), e.RowIndex).Value
        so.Text = DataGridView2(("SO"), e.RowIndex).Value
        nor.Checked = DataGridView2(("NOR"), e.RowIndex).Value
        tsub.Checked = DataGridView2(("SUB"), e.RowIndex).Value
        cult.Checked = DataGridView2(("CULT"), e.RowIndex).Value
        cal.Checked = DataGridView2(("cal"), e.RowIndex).Value
        CollectionNote.Text = DataGridView2(("CollectionNote"), e.RowIndex).Value
        KID_N.Text = DataGridView2(("KID_N"), e.RowIndex).Value
        KID_TYPE.Text = DataGridView2(("KID_TYPE"), e.RowIndex).Value
        ResultAfter.Text = DataGridView2(("ResultAfter"), e.RowIndex).Value
        NormalRange.Text = DataGridView2(("NormalRange"), e.RowIndex).Value
        lshort.Text = DataGridView2(("short"), e.RowIndex).Value
    End Sub

    Private Sub DataGridView2_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView2.CellMouseDoubleClick
        'dr.Close()
        'cmd.CommandText = "update ltest set gname='" & grname.Text & "',gcode='" & grcode.Text & "',gr_code='" & gr_code.Text & "' ,gr_name='" & gr_name.Text & "' where test_code='" & ttest_code.Text & "'"
        'cmd.ExecuteNonQuery()
        'MsgBox(" „«„ Ì« „«‰")

    End Sub

    Private Sub DataGridView2_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView2.CellMouseDown

    End Sub

    Private Sub DataGridView2_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridView2.MouseClick

    End Sub

    Private Sub GlassButton15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If IsNumeric(gcode.Text) = False Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·ﬂÊœ") : Exit Sub
        If grname.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
        If IsNumeric(ttest_code.Text) = False Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·ﬂÊœ") : Exit Sub
        If ttest_name.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
        If IsNumeric(so.Text) = False Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·ﬂÊœ") : Exit Sub

        dr.Close()
        cmd.CommandText = "select * from LTEST where   test_code='" & ttest_code.Text & "'"

        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Dim n As String
            n = MsgBox(" Â·  —Ìœ «·Õ–› ø", MsgBoxStyle.YesNo)
            If n = vbNo Then Exit Sub
            dr.Close()
            cmd.CommandText = "delete from LTEST where    test_code='" & ttest_code.Text & "'"
            cmd.ExecuteNonQuery()
            apd = 1
        End If

    End Sub

    Private Sub GlassButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim st As String = ""
        Dim st1 As String = ""
        Dim sty As String = ""
        Dim sty1 As String = ""

        If cgrname.Checked = True Then
            st = grname.Text
            st1 = "gName"
            sty = grcode.Text
            sty1 = "gcode"
        End If
        If ctsub.Checked = True Then
            st = Val(tsub.CheckState)
            st1 = "sub"
        End If
        If ctnor.Checked = True Then
            st = Val(nor.CheckState)
            st1 = "nor"
        End If

        If ctcult.Checked = True Then
            st = Val(cult.CheckState)
            st1 = "cult"
        End If

        If Cgr_name.Checked = True Then
            st = gr_name.Text
            st1 = "gr_name"
            sty = gr_code.Text
            sty1 = "gr_code"
        End If
        If CCollectionNote.Checked = True Then
            st = CollectionNote.Text
            st1 = "CollectionNote"
        End If
        If CKID_TYPE.Checked = True Then
            st = KID_TYPE.Text
            st1 = "KID_TYPE"
        End If
        If CKID_N.Checked = True Then
            st = KID_N.Text
            st1 = "KID_N"
        End If
        If CLshort.Checked = True Then
            st = lshort.Text
            st1 = "short"
        End If
        If CResultAfter.Checked = True Then
            st = ResultAfter.Text
            st1 = "ResultAfter"
        End If


        Dim n As Integer = 0
        While Not n = LTEST.Rows.Count
            RC = LTEST.Rows(n)
            RC.BeginEdit()
            RC(st1) = st
            If sty1 <> "" Then RC(sty1) = sty
            RC.EndEdit()
            n = n + 1
        End While
        cmdb.DataAdapter = adLTEST
        adLTEST.Update(DBS, "LTEST")
    End Sub

    Private Sub GlassButton13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton13.Click
        If LTEST.Rows.Count <= 0 Then MsgBox("·«  ÊÃœ »Ì«‰« ") : Exit Sub
        tr = 0
        trc()
    End Sub
    Public Sub trc()
        On Error Resume Next
        gr_code.Text = LTEST.Rows(tr).Item("test_CODE")
        gr_name.Text = LTEST.Rows(tr).Item("test_NAME")
        ttest_code.Text = LTEST.Rows(tr).Item("test_CODE")
        ttest_name.Text = LTEST.Rows(tr).Item("test_NAME")
        Ntest_CODE.Text = LTEST.Rows(tr).Item("test_CODE")
        Ntest_NAME.Text = LTEST.Rows(tr).Item("test_NAME")
        tar.Text = LTEST.Rows(tr).Item("AR")
        ptest_code.Text = LTEST.Rows(tr).Item("test_CODE")
        ptest_name.Text = LTEST.Rows(tr).Item("test_NAME")
        par.Text = LTEST.Rows(tr).Item("AR")
        grcode.Text = LTEST.Rows(tr).Item("GCODE")
        grname.Text = LTEST.Rows(tr).Item("GNAME")
        so.Text = LTEST.Rows(tr).Item("SO")
        nor.Checked = LTEST.Rows(tr).Item("NOR")
        tsub.Checked = LTEST.Rows(tr).Item("SUB")
        cult.Checked = LTEST.Rows(tr).Item("cult")
        CollectionNote.Text = LTEST.Rows(tr).Item("CollectionNote")
        KID_N.Text = LTEST.Rows(tr).Item("KID_N")
        KID_TYPE.Text = LTEST.Rows(tr).Item("KID_TYPE")
        ResultAfter.Text = LTEST.Rows(tr).Item("ResultAfter")
        NormalRange.Text = LTEST.Rows(tr).Item("NormalRange")
        lshort.Text = LTEST.Rows(tr).Item("short")
    End Sub

    Private Sub GlassButton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton12.Click
        If LTEST.Rows.Count <= 0 Then MsgBox("·«  ÊÃœ »Ì«‰« ") : Exit Sub
        tr = tr - 1
        If tr < 0 Then tr = 0
        trc()

    End Sub

    Private Sub GlassButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton11.Click
        If LTEST.Rows.Count <= 0 Then MsgBox("·«  ÊÃœ »Ì«‰« ") : Exit Sub
        tr = tr + 1
        If tr >= LTEST.Rows.Count Then tr = LTEST.Rows.Count - 1
        trc()

    End Sub

    Private Sub GlassButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton10.Click
        If LTEST.Rows.Count <= 0 Then MsgBox("·«  ÊÃœ »Ì«‰« ") : Exit Sub
        tr = LTEST.Rows.Count - 1
        trc()
    End Sub

    Private Sub GlassButton27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton27.Click
        dr.Close() : cmd.CommandText = "select MAx(test_code) from LSUBTEST "
        dr = cmd.ExecuteReader
        dr.Read()
        If IsDBNull(dr(0)) = False Then
            stest_code.Text = 1 + dr(0)
        Else
            stest_code.Text = 1
        End If
        TextBox4.Text = 0
        cmdLSUBTEST.Connection = CN
        cmdLSUBTEST.CommandType = CommandType.Text
        cmdLSUBTEST.CommandText = "select * FROM LSUBTEST WHERE MTEST_NAME='" & mtest_name.Text & "' order by q "
        adLSUBTEST.SelectCommand = cmdLSUBTEST
        adLSUBTEST.Fill(DBS, "LSUBTEST")
        LSUBTEST = DBS.Tables("LSUBTEST")
        DBS.Tables("LSUBTEST").Clear()
        adLSUBTEST.Fill(DBS, "LSUBTEST")
        LSUBTEST = DBS.Tables("LSUBTEST")
        DataGridView3.DataSource = LSUBTEST
        stest_name.Text = ""
        stest_name.Focus()
        TextBox4.Text = 0
        CheckBox21.Checked = False
        dr.Close()
        cmd.CommandText = "update device set flg=1"
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub GlassButton24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton24.Click
        If IsNumeric(stest_code.Text) = False Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·ﬂÊœ") : Exit Sub
        If stest_name.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
        If mtest_name.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub

        dr.Close()
        cmd.CommandText = "select * from LSUBTEST where test_NAME='" & stest_name.Text & "' AND Mtest_NAME='" & mtest_name.Text & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Dim n As String
            n = MsgBox(" Â·  —Ìœ «· ⁄œÌ· ø", MsgBoxStyle.YesNo)
            If n = vbNo Then Exit Sub
            dr.Close()
            cmd.CommandText = "delete from LSUBTEST where test_NAME='" & stest_name.Text & "' AND Mtest_NAME='" & mtest_name.Text & "'"
            cmd.ExecuteNonQuery()
            dr.Close()
            apd = 1
        End If
        Dim x As Integer = 0
        If CheckBox21.Checked = True Then x = 0 Else x = 1

        dr.Close() : cmd.CommandText = "insert into LSUBTEST (test_code,test_name,Mtest_code,Mtest_name,p)  values ('" & stest_code.Text & "','" & stest_name.Text & "','" & mtest_code.Text & "','" & mtest_name.Text & "','" & x & "')"
        cmd.ExecuteNonQuery()
        dr.Close()
        cmd.CommandText = "update device set flg=1"
        cmd.ExecuteNonQuery()
        GlassButton27_Click(GlassButton27, e)
    End Sub

    Private Sub GlassButton23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton23.Click
        If IsNumeric(stest_code.Text) = False Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·ﬂÊœ") : Exit Sub
        If stest_name.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
        If mtest_name.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
        If TextBox4.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «Œ Ì«— «· Õ·Ì·") : Exit Sub
        dr.Close()
        cmd.CommandText = "select * from LSUBTEST where test_NAME='" & stest_name.Text & "' AND Mtest_NAME='" & mtest_name.Text & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Dim n As String
            n = MsgBox(" Â·  —Ìœ Õ–› ø", MsgBoxStyle.YesNo)
            If n = vbNo Then Exit Sub
            dr.Close()
            cmd.CommandText = "delete from LSUBTEST where ky='" & TextBox4.Text & "'"
            cmd.ExecuteNonQuery()
            apd = 1
        End If
        GlassButton26_Click(GlassButton26, e)

    End Sub

    Private Sub GlassButton17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cmdb.DataAdapter = adLSUBTEST
        adLSUBTEST.Update(DBS, "LSUBTEST")

    End Sub

    Private Sub GlassButton21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton21.Click
        If LSUBTEST.Rows.Count <= 0 Then MsgBox("·«  ÊÃœ »Ì«‰« ") : Exit Sub
        SR = 0
        stest_code.Text = LSUBTEST.Rows(SR).Item("test_CODE")
        stest_name.Text = LSUBTEST.Rows(SR).Item("test_NAME")
        mtest_code.Text = LSUBTEST.Rows(SR).Item("Mtest_CODE")
        mtest_name.Text = LSUBTEST.Rows(SR).Item("Mtest_NAME")

    End Sub

    Private Sub GlassButton20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton20.Click
        If LSUBTEST.Rows.Count <= 0 Then MsgBox("·«  ÊÃœ »Ì«‰« ") : Exit Sub
        SR = SR - 1
        If SR < 0 Then SR = 0
        stest_code.Text = LSUBTEST.Rows(SR).Item("test_CODE")
        stest_name.Text = LSUBTEST.Rows(SR).Item("test_NAME")
        mtest_code.Text = LSUBTEST.Rows(SR).Item("Mtest_CODE")
        mtest_name.Text = LSUBTEST.Rows(SR).Item("Mtest_NAME")

    End Sub

    Private Sub GlassButton19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton19.Click
        If LSUBTEST.Rows.Count <= 0 Then MsgBox("·«  ÊÃœ »Ì«‰« ") : Exit Sub
        SR = SR + 1
        If SR >= LSUBTEST.Rows.Count Then SR = LSUBTEST.Rows.Count - 1
        stest_code.Text = LSUBTEST.Rows(SR).Item("test_CODE")
        stest_name.Text = LSUBTEST.Rows(SR).Item("test_NAME")
        mtest_code.Text = LSUBTEST.Rows(SR).Item("Mtest_CODE")
        mtest_name.Text = LSUBTEST.Rows(SR).Item("Mtest_NAME")

    End Sub

    Private Sub GlassButton18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton18.Click
        If LSUBTEST.Rows.Count <= 0 Then MsgBox("·«  ÊÃœ »Ì«‰« ") : Exit Sub
        SR = LSUBTEST.Rows.Count - 1
        stest_code.Text = LSUBTEST.Rows(SR).Item("test_CODE")
        stest_name.Text = LSUBTEST.Rows(SR).Item("test_NAME")
        mtest_code.Text = LSUBTEST.Rows(SR).Item("Mtest_CODE")
        mtest_name.Text = LSUBTEST.Rows(SR).Item("Mtest_NAME")

    End Sub

    Private Sub mtest_name_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mtest_name.SelectedIndexChanged
        If mtest_name.Focused = False Then Exit Sub
        If mtest_name.Text = "" Then Exit Sub
        If EX = 1 Then Exit Sub
        FRC = LTEST1.Select("TEST_NAME='" & mtest_name.Text & "'")
        If FRC.Length <= 0 Then
            mtest_name.Text = ""
            mtest_code.Text = ""
            Exit Sub
        Else
            RC = FRC(0)
            mtest_code.Text = RC("TEST_code")

            cmdLSUBTEST.Connection = CN
            cmdLSUBTEST.CommandType = CommandType.Text
            cmdLSUBTEST.CommandText = "select * FROM LSUBTEST WHERE MTEST_NAME='" & mtest_name.Text & "'"
            adLSUBTEST.SelectCommand = cmdLSUBTEST
            adLSUBTEST.Fill(DBS, "LSUBTEST")
            LSUBTEST = DBS.Tables("LSUBTEST")
            DBS.Tables("LSUBTEST").Clear()
            adLSUBTEST.Fill(DBS, "LSUBTEST")
            LSUBTEST = DBS.Tables("LSUBTEST")
            DataGridView3.DataSource = LSUBTEST
        End If



    End Sub

    Private Sub DataGridView3_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick

    End Sub

    Private Sub DataGridView3_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView3.CellEndEdit
        On Error Resume Next
        cmdb.DataAdapter = adLSUBTEST
        adLSUBTEST.Update(DBS, "LSUBTEST")
        apd = 1
    End Sub

    Private Sub DataGridView3_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView3.CellMouseClick
        On Error Resume Next
        stest_code.Text = DataGridView3(("test_CODE"), e.RowIndex).Value
        stest_name.Text = DataGridView3(("test_NAME"), e.RowIndex).Value
        mtest_code.Text = DataGridView3(("Mtest_CODE"), e.RowIndex).Value
        mtest_name.Text = DataGridView3(("Mtest_NAME"), e.RowIndex).Value
        sso.Text = DataGridView3(("so"), e.RowIndex).Value
        TextBox4.Text = DataGridView3(("ky"), e.RowIndex).Value
        If DataGridView3(("p"), e.RowIndex).Value = 1 Then
            CheckBox21.Checked = False
        Else
            CheckBox21.Checked = True
        End If
    End Sub

    Private Sub GlassButton36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton36.Click
        cmdLNTEST.Connection = CN
        cmdLNTEST.CommandType = CommandType.Text
        cmdLNTEST.CommandText = "select * FROM LNTEST WHERE test_NAME='" & Ntest_NAME.Text & "'"
        adLNTEST.SelectCommand = cmdLNTEST
        adLNTEST.Fill(DBS, "LNTEST")
        LNTEST = DBS.Tables("LNTEST")
        DBS.Tables("LNTEST").Clear()
        adLNTEST.Fill(DBS, "LNTEST")
        LNTEST = DBS.Tables("LNTEST")
        DataGridView5.DataSource = LNTEST
        nky.Text = 0
    End Sub

    Private Sub GlassButton35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton35.Click
        If IsNumeric(Ntest_CODE.Text) = False Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·ﬂÊœ") : Exit Sub
        If Ntest_NAME.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
        dr.Close()
        cmd.CommandText = "select * from LnTEST where ky='" & Val(nky.Text) & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Dim n As String
            n = MsgBox(" Â·  —Ìœ «· ⁄œÌ· ø", MsgBoxStyle.YesNo)
            If n = vbNo Then Exit Sub
            dr.Close()
            cmd.CommandText = "delete from LNTEST where ky='" & Val(nky.Text) & "'"
            cmd.ExecuteNonQuery()

        End If
        dr.Close() : cmd.CommandText = "INSERT INTO LNTEST([test_code],[test_name],[ref],[type] ,[ageb],[agee],[NORB],[NORE],[unit],year,SRES) VALUES ('" & Ntest_CODE.Text & "','" & Ntest_NAME.Text & "','" & NREF.Text & "','" & NTYPE.Text & "','" & NAGEB.Text & "','" & NAGEE.Text & "','" & NNORB.Text & "','" & NNORE.Text & "','" & nunit.Text & "','" & PYEAR.Text & "','" & Val(sres.CheckState) & "')"
        cmd.ExecuteNonQuery()
        GlassButton36_Click(GlassButton36, e)

    End Sub

    Private Sub GlassButton34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton34.Click
        If IsNumeric(Ntest_CODE.Text) = False Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·ﬂÊœ") : Exit Sub
        If Ntest_NAME.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
        If Val(Ntest_CODE.Text) <= 0 Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «· Õ·Ì·") : Exit Sub
        dr.Close()
        cmd.CommandText = "select * from LnTEST where ky='" & nky.Text & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Dim n As String
            n = MsgBox(" Â·  —Ìœ «·Õ–› ø", MsgBoxStyle.YesNo)
            If n = vbNo Then Exit Sub
            dr.Close()
            cmd.CommandText = "delete from LNTEST where ky='" & nky.Text & "'"
            cmd.ExecuteNonQuery()
            GlassButton36_Click(GlassButton36, e)
        End If

    End Sub

    Private Sub GlassButton28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cmdb.DataAdapter = adLNTEST
        adLNTEST.Update(DBS, "LNTEST")
    End Sub

    Private Sub GlassButton32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton32.Click
        If LTEST.Rows.Count <= 0 Then MsgBox("·«  ÊÃœ »Ì«‰« ") : Exit Sub
        tr = 0
        trc()
        GlassButton36_Click(GlassButton36, e)
    End Sub

    Private Sub GlassButton31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton31.Click
        If LTEST.Rows.Count <= 0 Then MsgBox("·«  ÊÃœ »Ì«‰« ") : Exit Sub
        tr = tr - 1
        If tr < 0 Then tr = 0
        trc()
        GlassButton36_Click(GlassButton36, e)
    End Sub

    Private Sub GlassButton30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton30.Click
        If LTEST.Rows.Count <= 0 Then MsgBox("·«  ÊÃœ »Ì«‰« ") : Exit Sub
        tr = tr + 1
        If tr >= LTEST.Rows.Count Then tr = LTEST.Rows.Count - 1
        trc()
        GlassButton36_Click(GlassButton36, e)
    End Sub

    Private Sub GlassButton29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton29.Click
        If LTEST.Rows.Count <= 0 Then MsgBox("·«  ÊÃœ »Ì«‰« ") : Exit Sub
        tr = LTEST.Rows.Count - 1
        trc()
        GlassButton36_Click(GlassButton36, e)
    End Sub

    Private Sub DataGridView5_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView5.CellContentClick


    End Sub

    Private Sub DataGridView5_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView5.CellEndEdit
        'DataGridView5("BRAN", e.RowIndex).Value = sbran
        'LNTEST.Columns("st").Expression = "1"
        ''LNTEST.Columns("BRAN").Expression = sbran.ToString

        cmdb.DataAdapter = adLNTEST
        adLNTEST.Update(DBS, "LNTEST")
    End Sub

    Private Sub DataGridView5_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView5.CellMouseClick
        On Error Resume Next
        Ntest_CODE.Text = DataGridView5(("CODE"), e.RowIndex).Value
        Ntest_NAME.Text = DataGridView5(("NAME"), e.RowIndex).Value
        NREF.Text = DataGridView5(("ref"), e.RowIndex).Value
        NTYPE.Text = DataGridView5(("Type"), e.RowIndex).Value
        NAGEB.Text = DataGridView5(("ageb"), e.RowIndex).Value
        NAGEE.Text = DataGridView5(("agee"), e.RowIndex).Value
        NNORB.Text = DataGridView5(("NORB"), e.RowIndex).Value
        NNORE.Text = DataGridView5(("NORE"), e.RowIndex).Value
        nunit.Text = DataGridView5(("unit"), e.RowIndex).Value
        PYEAR.Text = DataGridView5(("year"), e.RowIndex).Value
        sres.CheckState = Val(DataGridView5(("SRES"), e.RowIndex).Value)
        nky.Text = DataGridView5(("KY"), e.RowIndex).Value
    End Sub

    Private Sub GlassButton45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton45.Click
        cmdLnsTEST.Connection = CN
        cmdLnsTEST.CommandType = CommandType.Text
        cmdLnsTEST.CommandText = "select * FROM lnstest WHERE test_code='" & Val(nstest_code.Text) & "' and mtest_code='" & Val(nMtest_CODE.Text) & "'"
        adLnsTEST.SelectCommand = cmdLnsTEST
        adLnsTEST.Fill(DBS, "lnstest")
        LnsTEST = DBS.Tables("lnstest")
        DBS.Tables("lnstest").Clear()
        adLnsTEST.Fill(DBS, "lnstest")
        LnsTEST = DBS.Tables("lnstest")
        DataGridView4.DataSource = LnsTEST
        NSKY.Text = 0
    End Sub

    Private Sub GlassButton14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton14.Click
        Dim st As String = "where so>-1"

        If ctname.Checked = True Then
            st = st & "  " & " and test_Name='" & ttest_name.Text & "'"
        End If
        If ctar.Checked = True Then
            st = st & "  " & " and ar='" & tar.Text & "'"
        End If
        If ctso.Checked = True Then
            st = st & "  " & " and so='" & so.Text & "'"
        End If
        If cgrname.Checked = True Then
            st = st & "  " & " and gName='" & grname.Text & "'"
        End If
        If ctsub.Checked = True Then
            st = st & "  " & " and sub='" & Val(tsub.CheckState) & "'"
        End If
        If ctnor.Checked = True Then
            st = st & "  " & " and nor='" & Val(nor.CheckState) & "'"
        End If

        If ctcult.Checked = True Then
            st = st & "  " & " and cult='" & Val(cult.CheckState) & "'"
        End If

        If Cgr_name.Checked = True Then
            st = st & "  " & " and gr_name='" & gr_name.Text & "'"
        End If
        If CCollectionNote.Checked = True Then
            st = st & "  " & " and CollectionNote LIKE '%" & CollectionNote.Text & "%'"
        End If
        If CKID_TYPE.Checked = True Then
            st = st & "  " & " and KID_TYPE='" & KID_TYPE.Text & "'"
        End If
        If CKID_N.Checked = True Then
            st = st & "  " & " and KID_N='" & KID_N.Text & "'"
        End If
        If CLshort.Checked = True Then
            st = st & "  " & " and short='" & lshort.Text & "'"
        End If
        If CResultAfter.Checked = True Then
            st = st & "  " & " and ResultAfter='" & ResultAfter.Text & "'"
        End If


        cmdLTEST.Connection = CN
        cmdLTEST.CommandType = CommandType.Text
        cmdLTEST.CommandText = "select * FROM LTEST " & st
        adLTEST.SelectCommand = cmdLTEST
        adLTEST.Fill(DBS, "LTEST")
        LTEST = DBS.Tables("LTEST")
        DBS.Tables("LTEST").Clear()
        adLTEST.Fill(DBS, "LTEST")
        LTEST = DBS.Tables("LTEST")
        DataGridView2.DataSource = LTEST
        dr.Close()
        Dim oj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        oj.Load(Application.StartupPath & "\test name.rpt")
        oj.Database.Tables(0).SetDataSource(LTEST)

        rp.CrystalReportViewer1.ReportSource = oj

        rp.Show() : rp.Focus()
    End Sub

    Private Sub GlassButton44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton44.Click
        If IsNumeric(nstest_code.Text) = False Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·ﬂÊœ") : Exit Sub
        If nstest_name.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
        dr.Close()
        cmd.CommandText = "select * from LnSTEST where ky='" & Val(NSKY.Text) & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Dim n As String
            n = MsgBox(" Â·  —Ìœ «· ⁄œÌ· ø", MsgBoxStyle.YesNo)
            If n = vbNo Then Exit Sub
            dr.Close()
            cmd.CommandText = "delete from LNSTEST where ky='" & Val(NSKY.Text) & "'"
            cmd.ExecuteNonQuery()

        End If
        dr.Close() : cmd.CommandText = "INSERT INTO LNSTEST([Mtest_code],[Mtest_name],[test_code],[test_name],[ref],[type] ,[ageb],[agee],[NORB],[NORE],[unit],year) VALUES ('" & nMtest_CODE.Text & "','" & nmtest_name.Text & "','" & nstest_code.Text & "','" & nstest_name.Text & "','" & nsref.Text & "','" & nstype.Text & "','" & nsageb.Text & "','" & nsagee.Text & "','" & nsnorb.Text & "','" & nsnore.Text & "','" & nsunit.Text & "','" & syear.Text & "')"
        cmd.ExecuteNonQuery()
        GlassButton45_Click(GlassButton45, e)

    End Sub

    Private Sub TabPage3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage3.Click

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged

    End Sub

    Private Sub nmtest_name_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nmtest_name.SelectedIndexChanged
        If nmtest_name.Focused = False Then Exit Sub
        If nmtest_name.Text = "" Then Exit Sub
        If EX = 1 Then Exit Sub
        FRC = LTEST1.Select("TEST_NAME='" & nmtest_name.Text & "'")
        If FRC.Length <= 0 Then
            mtest_name.Text = ""
            mtest_code.Text = ""
            Exit Sub
        Else
            RC = FRC(0)
            nMtest_CODE.Text = RC("TEST_code")
            cmdLSUBTEST.Connection = CN
            cmdLSUBTEST.CommandType = CommandType.Text
            cmdLSUBTEST.CommandText = "select * FROM LSUBTEST WHERE MTEST_NAME='" & nmtest_name.Text & "'"
            adLSUBTEST.SelectCommand = cmdLSUBTEST
            adLSUBTEST.Fill(DBS, "LSUBTEST")
            LSUBTEST = DBS.Tables("LSUBTEST")
            DBS.Tables("LSUBTEST").Clear()
            adLSUBTEST.Fill(DBS, "LSUBTEST")
            LSUBTEST = DBS.Tables("LSUBTEST")
            nstest_name.DataSource = LSUBTEST
            nstest_name.DisplayMember = "TEST_NAME"
        End If


    End Sub

    Private Sub GlassButton46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton46.Click
        NREF.Text = NNORB.Text & " - " & NNORE.Text & "       " & nunit.Text

    End Sub

    Private Sub nstest_name_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles nstest_name.GotFocus
        flng("EN")
    End Sub

    Private Sub nstest_name_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nstest_name.SelectedIndexChanged
        If nstest_name.Focused = False Then Exit Sub
        If nstest_name.Text = "" Then Exit Sub
        If EX = 1 Then Exit Sub
        FRC = LSUBTEST.Select("TEST_NAME='" & nstest_name.Text & "'")
        If FRC.Length <= 0 Then
            mtest_name.Text = ""
            mtest_code.Text = ""
            Exit Sub
        Else
            RC = FRC(0)
            nstest_code.Text = RC("TEST_code")
            GlassButton45_Click(GlassButton45, e)
        End If
    End Sub

    Private Sub GlassButton43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton43.Click
        If IsNumeric(nstest_code.Text) = False Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·ﬂÊœ") : Exit Sub
        If nstest_name.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
        If Val(nstest_code.Text) <= 0 Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «· Õ·Ì·") : Exit Sub
        dr.Close()
        cmd.CommandText = "select * from LnSTEST where ky='" & NSKY.Text & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Dim n As String
            n = MsgBox(" Â·  —Ìœ «·Õ–› ø", MsgBoxStyle.YesNo)
            If n = vbNo Then Exit Sub
            dr.Close()
            cmd.CommandText = "delete from LNSTEST where ky='" & NSKY.Text & "'"
            cmd.ExecuteNonQuery()
            GlassButton45_Click(GlassButton45, e)
        End If

    End Sub

    Private Sub GlassButton37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cmdb.DataAdapter = adLnsTEST
        adLnsTEST.Update(DBS, "LNSTEST")
    End Sub

    Private Sub GlassButton41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton41.Click

    End Sub

    Private Sub DataGridView4_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView4.CellContentClick

    End Sub

    Private Sub DataGridView4_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView4.CellEndEdit
        cmdb.DataAdapter = adLnsTEST
        adLnsTEST.Update(DBS, "LNSTEST")
    End Sub

    Private Sub DataGridView4_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView4.CellMouseClick
        On Error Resume Next
        nstest_code.Text = DataGridView4(("TEST_CODE"), e.RowIndex).Value
        nstest_name.Text = DataGridView4(("TEST_NAME"), e.RowIndex).Value
        nMtest_CODE.Text = DataGridView4(("MTEST_CODE"), e.RowIndex).Value
        nmtest_name.Text = DataGridView4(("MTEST_NAME"), e.RowIndex).Value
        nsref.Text = DataGridView4(("ref"), e.RowIndex).Value
        nstype.Text = DataGridView4(("Type"), e.RowIndex).Value
        nsageb.Text = DataGridView4(("ageb"), e.RowIndex).Value
        nsagee.Text = DataGridView4(("agee"), e.RowIndex).Value
        nsnorb.Text = DataGridView4(("NORB"), e.RowIndex).Value
        nsnore.Text = DataGridView4(("NORE"), e.RowIndex).Value
        nsunit.Text = DataGridView4(("unit"), e.RowIndex).Value
        syear.Text = DataGridView4(("year"), e.RowIndex).Value
        NSKY.Text = DataGridView4(("KY"), e.RowIndex).Value
    End Sub

    Private Sub GlassButton47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton47.Click
        nsref.Text = nsnorb.Text & " - " & nsnore.Text & "       " & nsunit.Text

    End Sub

    Private Sub ph_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ph.KeyDown
        If e.KeyCode = Keys.Enter Then
            ch.Text = 100 - Val(ph.Text)
            pp.Focus()

        End If
    End Sub

    Private Sub ph_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ph.TextChanged

    End Sub

    Private Sub pp_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles pp.KeyDown
        If e.KeyCode = Keys.Enter Then
            cp.Text = 100 - Val(pp.Text)
            ps.Focus()

        End If
    End Sub

    Private Sub pp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pp.TextChanged

    End Sub

    Private Sub ps_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ps.KeyDown
        If e.KeyCode = Keys.Enter Then
            cs.Text = 100 - Val(ps.Text)
            pw.Focus()
        End If
    End Sub

    Private Sub ps_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ps.TextChanged

    End Sub

    Private Sub GlassButton55_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton55.Click
        If IsNumeric(ccode.Text) = False Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·ﬂÊœ") : Exit Sub
        If cname.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
        dr.Close()
        cmd.CommandText = "select * from lcompany where   code='" & ccode.Text & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Dim n As String
            n = MsgBox(" Â·  —Ìœ «· ⁄œÌ· ø", MsgBoxStyle.YesNo)
            If n = vbNo Then Exit Sub
            dr.Close()
            cmd.CommandText = "delete from lcompany where    code='" & ccode.Text & "'"
            cmd.ExecuteNonQuery()

        End If
        dr.Close()
        cmd.CommandText = "select * from lcompany where   name='" & cname.Text & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Dim n As String
            n = MsgBox(" Â·  —Ìœ «· ⁄œÌ· ø", MsgBoxStyle.YesNo)
            If n = vbNo Then Exit Sub
            dr.Close()
            cmd.CommandText = "delete from lcompany where name='" & cname.Text & "'"
            cmd.ExecuteNonQuery()

        End If
        dr.Close() : cmd.CommandText = "insert into Lcompany (code,name,[book_price_code],[book_price_name],[ph],[ch] ,[pp],[cp],[ps],[cs],[pw],[cw],diss,[add1],email,tel,DOC,lab,inc,crd,canc,BRAN,name1,name2,name3,tel1,tel2,tel3,email1,email2,email3,test,cond,web,RESULT,[address],[price_name],[oprice_name],[price_diss],[oprice_diss],[tah_form],[tah_exp],[tah_date],[emp_cash],[fam_cash],[HC],[out_date],labin,COMS)  values ('" & ccode.Text & "','" & cname.Text & "','" & book_price_code.Text & " ','" & book_price_name.Text & "','" & ph.Text & "','" & ch.Text & "' ,'" & pp.Text & "','" & cp.Text & "','" & ps.Text & "','" & cs.Text & "','" & pw.Text & "','" & cw.Text & "','" & cdiss.Text & "','" & cadd.Text & "','" & cemail.Text & "','" & ctel.Text & "','" & Val(CheckBox18.CheckState) & "','" & Val(lab.CheckState) & "','" & Val(inc.CheckState) & "','" & Val(crd.CheckState) & "','" & Val(canc.CheckState) & "','" & RRVV & "','" & name1.Text & "','" & name2.Text & "','" & name3.Text & "','" & tel1.Text & "','" & tel2.Text & "','" & tel3.Text & "','" & email1.Text & "','" & email2.Text & "','" & email3.Text & "','" & tests.Text & "','" & cond.Text & "','" & web.Text & "','" & RESULT.Text & "','" & addres.Text & "','" & price_name.Text & "','" & oprice_name.Text & "','" & price_diss.Text & "','" & oprice_diss.Text & "','" & tah_form.Text & "','" & tah_exp.Text & "','" & tah_date.Text & "','" & emp_cash.Text & "','" & fam_cash.Text & "','" & hc.Text & "','" & out_date.Text & "','" & Val(labin.CheckState) & "','" & Val(COMS.CheckState) & "')"
        cmd.ExecuteNonQuery()
        apd = 1
        GlassButton56_Click(GlassButton56, e)
    End Sub

    Private Sub pw_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles pw.KeyDown
        If e.KeyCode = Keys.Enter Then
            cw.Text = 100 - Val(pw.Text)
            GlassButton55_Click(GlassButton55, e)
        End If

    End Sub

    Private Sub pw_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pw.TextChanged

    End Sub

    Private Sub book_price_name_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles book_price_name.KeyDown
        Dim n As String
        If e.KeyCode = Keys.Enter Then
            n = ""
            n = MsgBox(" Â·  —Ìœ «·Õ›Ÿ ø", MsgBoxStyle.YesNo)
            If n = vbNo Then Exit Sub
            dr.Close() : cmd.CommandText = "select MAx(code) from lbook_price "
            dr = cmd.ExecuteReader
            dr.Read()
            If IsDBNull(dr(0)) = False Then
                book_price_code.Text = 1 + dr(0)
            Else
                book_price_code.Text = 1
            End If

            If book_price_name.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
            dr.Close()
            cmd.CommandText = "select * from lbook_price where   code='" & book_price_code.Text & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                n = ""
                n = MsgBox(" Â·  —Ìœ «· ⁄œÌ· ø", MsgBoxStyle.YesNo)
                If n = vbNo Then Exit Sub
                dr.Close()
                cmd.CommandText = "delete from lbook_price where    code='" & book_price_code.Text & "'"
                cmd.ExecuteNonQuery()

            End If

            dr.Close() : cmd.CommandText = "insert into lbook_price (code,name,EMAIL)  values ('" & book_price_code.Text & "','" & book_price_name.Text & "','" & EML.Text & "')"
            cmd.ExecuteNonQuery()

            bookf()
        End If
        If e.KeyCode = Keys.Delete Then
            n = MsgBox(" Â·  —Ìœ «·Õ–› ø", MsgBoxStyle.YesNo)
            If IsNumeric(book_price_code.Text) = False Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·ﬂÊœ") : Exit Sub
            If book_price_name.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
            dr.Close()
            cmd.CommandText = "select * from lbook_price where   code='" & book_price_code.Text & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                dr.Close()
                cmd.CommandText = "delete from lbook_price where    code='" & book_price_code.Text & "'"
                cmd.ExecuteNonQuery()

            End If
            bookf()
        End If

    End Sub

    Private Sub book_price_name_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles book_price_name.SelectedIndexChanged
        On Error Resume Next
        If book_price_name.Focused = False Then Exit Sub
        If book_price_name.Text = "" Then Exit Sub
        If EX = 1 Then Exit Sub
        FRC = book_price.Select("NAME='" & book_price_name.Text & "'")
        If FRC.Length <= 0 Then
            book_price_name.Text = ""
            book_price_code.Text = ""
            Exit Sub
        Else
            RC = FRC(0)
            book_price_code.Text = RC("code")
            EML.Text = RC("EMAIL")
            btell.Text = RC("tell")
            ck.Text = RC("k")
        End If
    End Sub

    Private Sub GlassButton56_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton56.Click
        dr.Close() : cmd.CommandText = "select MAx(code) from lcompany "
        dr = cmd.ExecuteReader
        dr.Read()
        If IsDBNull(dr(0)) = False Then
            ccode.Text = 1 + dr(0)
        Else
            ccode.Text = 1
        End If
        cmdcompany.Connection = CN
        cmdcompany.CommandType = CommandType.Text
        cmdcompany.CommandText = "select * from lcompany order by code"
        adcompany.SelectCommand = cmdcompany
        adcompany.Fill(DBS, "company")
        company = DBS.Tables("company")
        DBS.Tables("company").Clear()
        adcompany.Fill(DBS, "company")
        company = DBS.Tables("company")
        DataGridView6.DataSource = company
        If ck.Text = "100" Then
            ph.Text = 100
            pp.Text = 100
            ps.Text = 100
            pw.Text = 100
            ch.Text = 0
            cp.Text = 0
            cs.Text = 0
            cw.Text = 0
            cdiss.Text = 0
            cadd.Text = 0
        Else
            ph.Text = 0
            pp.Text = 0
            ps.Text = 0
            pw.Text = 0
            ch.Text = 100
            cp.Text = 100
            cs.Text = 100
            cw.Text = 100
            cdiss.Text = 0
            cadd.Text = 0
        End If
        lab.Checked = False
        cemail.Text = ""
        ctel.Text = ""
        cname.Text = ""
        cname.Focus()
    End Sub

    Private Sub GlassButton54_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton54.Click
        If IsNumeric(ccode.Text) = False Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·ﬂÊœ") : Exit Sub
        If cname.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
        dr.Close()
        cmd.CommandText = "select * from lcompany where   code='" & ccode.Text & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Dim n As String
            n = MsgBox(" Â·  —Ìœ «·Õ–› ø", MsgBoxStyle.YesNo)
            If n = vbNo Then Exit Sub
            dr.Close()
            cmd.CommandText = "delete from lcompany where    code='" & ccode.Text & "'"
            cmd.ExecuteNonQuery()
            apd = 1
        End If
        MsgBox(" „  ⁄„·Ì… Õ–› «·‘—ﬂÂ", MsgBoxStyle.Information)
        GlassButton56_Click(GlassButton56, e)
    End Sub

    Private Sub GlassButton48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim n As Integer = 0
        While Not n = company.Rows.Count
            RC = LTEST.Rows(n)
            RC.BeginEdit()
            RC("ph") = ph.Text
            RC("ch") = ch.Text
            RC("pp") = pp.Text
            RC("cp") = cp.Text
            RC("ps") = ps.Text
            RC("cs") = cs.Text
            RC("pw") = pw.Text
            RC("cw") = cw.Text
            RC.EndEdit()
            n = n + 1
        End While

        cmdb.DataAdapter = adcompany
        adcompany.Update(DBS, "company")
    End Sub
    Public Sub cob()
        On Error Resume Next

        ccode.Text = DataGridView6("code", co).Value
        cname.Text = DataGridView6("name", co).Value
        book_price_code.Text = DataGridView6("book_price_code", co).Value
        book_price_name.Text = DataGridView6("book_price_name", co).Value
        ph.Text = DataGridView6("ph", co).Value
        ch.Text = DataGridView6("ch", co).Value
        pp.Text = DataGridView6("pp", co).Value
        cp.Text = DataGridView6("cp", co).Value
        ps.Text = DataGridView6("ps", co).Value
        cs.Text = DataGridView6("cs", co).Value
        pw.Text = DataGridView6("pw", co).Value
        cw.Text = DataGridView6("cw", co).Value
        cdiss.Text = DataGridView6("diss", co).Value
        cadd.Text = DataGridView6("add1", co).Value
        cemail.Text = DataGridView6("email", co).Value
        ctel.Text = DataGridView6("tel", co).Value
        CheckBox18.CheckState = DataGridView6("DOC", co).Value
        labin.CheckState = DataGridView6("labin", co).Value
        inc.CheckState = DataGridView6("inc", co).Value
        crd.CheckState = DataGridView6("crd", co).Value
        canc.CheckState = DataGridView6("canc", co).Value
        lab.CheckState = DataGridView6("lab", co).Value
        COMS.CheckState = DataGridView6("COMS", co).Value
        name1.Text = nulls(DataGridView6("name1", co).Value)
        name2.Text = nulls(DataGridView6("name2", co).Value)
        name3.Text = nulls(DataGridView6("name3", co).Value)
        tel1.Text = nulls(DataGridView6("tel1", co).Value)
        tel2.Text = nulls(DataGridView6("tel2", co).Value)
        tel3.Text = nulls(DataGridView6("tel3", co).Value)
        email1.Text = nulls(DataGridView6("email1", co).Value)
        email2.Text = nulls(DataGridView6("email2", co).Value)
        email3.Text = nulls(DataGridView6("email3", co).Value)
        cond.Text = nulls(DataGridView6("cond", co).Value)
        tests.Text = nulls(DataGridView6("test", co).Value)
        web.Text = nulls(DataGridView6("web", co).Value)
        RESULT.Text = nulls(DataGridView6("RESULT", co).Value)
        addres.Text = nulls(DataGridView6("address", co).Value)
        price_name.Text = nulls(DataGridView6("price_name", co).Value)
        oprice_name.Text = nulls(DataGridView6("oprice_name", co).Value)
        price_diss.Text = nulls(DataGridView6("price_diss", co).Value)
        oprice_diss.Text = nulls(DataGridView6("oprice_diss", co).Value)
        tah_form.Text = nulls(DataGridView6("tah_form", co).Value)
        tah_exp.Text = nulls(DataGridView6("tah_exp", co).Value)
        tah_date.Text = nulls(DataGridView6("tah_date", co).Value)
        emp_cash.Text = nulls(DataGridView6("emp_cash", co).Value)
        fam_cash.Text = nulls(DataGridView6("fam_cash", co).Value)
        hc.Text = nulls(DataGridView6("hc", co).Value)
        out_date.Text = nulls(DataGridView6("out_date", co).Value)
    End Sub
    Private Sub GlassButton52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton52.Click
        If company.Rows.Count <= 0 Then MsgBox("·«  ÊÃœ »Ì«‰« ") : Exit Sub
        co = 0
        cob()
    End Sub

    Private Sub GlassButton51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton51.Click
        If company.Rows.Count <= 0 Then MsgBox("·«  ÊÃœ »Ì«‰« ") : Exit Sub
        co = co - 1
        If co < 0 Then co = 0
        cob()
    End Sub

    Private Sub GlassButton50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton50.Click
        If company.Rows.Count <= 0 Then MsgBox("·«  ÊÃœ »Ì«‰« ") : Exit Sub
        co = co + 1
        If co >= company.Rows.Count Then co = company.Rows.Count - 1
        cob()
    End Sub

    Private Sub GlassButton49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton49.Click
        If company.Rows.Count <= 0 Then MsgBox("·«  ÊÃœ »Ì«‰« ") : Exit Sub
        co = company.Rows.Count - 1
        cob()
    End Sub

    Private Sub DataGridView6_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView6.CellContentClick

    End Sub

    Private Sub DataGridView6_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView6.CellEndEdit
        DataGridView6("BRAN", e.RowIndex).Value = RRVV
        cmdb.DataAdapter = adcompany
        adcompany.Update(DBS, "company")
        apd = 1
    End Sub

    Private Sub DataGridView6_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView6.CellLeave

    End Sub

    Private Sub DataGridView6_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView6.CellMouseClick
        co = e.RowIndex
        cob()
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ctot.CheckedChanged

    End Sub

    Private Sub GlassButton66_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton66.Click
        cmdtest_price.Connection = CN
        cmdtest_price.CommandType = CommandType.Text
        cmdtest_price.CommandText = "select * from ltest_price where book_price_name='" & pbook_price_name.Text & "' "
        adtest_price.SelectCommand = cmdtest_price
        adtest_price.Fill(DBS, "test_price")
        test_price = DBS.Tables("test_price")
        DBS.Tables("test_price").Clear()
        adtest_price.Fill(DBS, "test_price")
        test_price = DBS.Tables("test_price")
        DataGridView7.DataSource = test_price
        Label49.Text = test_price.Rows.Count
        ptot.Text = 0
        dr.Close()
        cmd.CommandText = "update device set flg=1"
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub GlassButton65_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton65.Click
        tsave()
        apd = 1
        GlassButton66_Click(GlassButton66, e)
    End Sub
    Public Sub tsave()
        If IsNumeric(ptest_code.Text) = False Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·ﬂÊœ") : Exit Sub
        If ptest_name.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
        If IsNumeric(pbook_price_code.Text) = False Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·ﬂÊœ") : Exit Sub
        If pbook_price_name.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
        dr.Close()
        cmd.CommandText = "select * from ltest_price where   test_name='" & ptest_name.Text & "' and book_price_name='" & pbook_price_name.Text & "' "
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Dim n As String
            n = MsgBox(" Â·  —Ìœ «· ⁄œÌ· ø", MsgBoxStyle.YesNo)
            If n = vbNo Then Exit Sub
            dr.Close()
            cmd.CommandText = "delete from ltest_price where    test_name='" & ptest_name.Text & "' and book_price_name='" & pbook_price_name.Text & "' "
            cmd.ExecuteNonQuery()

        End If
        apd = 1
        dr.Close()
        If COMP.Checked = True Then
            Dim P1 As Integer = InputBox("«·—Ã«¡ «œŒ«· «·—ﬁ„ «·«Ê·")
            Dim P2 As Integer = InputBox("«·—Ã«¡ «œŒ«· «·—ﬁ„ «·À«‰Ï ")
            Dim P3 As Integer = InputBox("«·—Ã«¡ «œŒ«· «·—ﬁ„ «·À«·À")
            Dim P4 As Integer = InputBox("«·—Ã«¡ «œŒ«· «·—ﬁ„ «·—«»⁄")
            cmd.CommandText = "insert into ltest_price (test_code,test_name,[book_price_code],[book_price_name],tot,ar,P1,P2,P3,P4)  values ('" & ptest_code.Text & "','" & ptest_name.Text & "','" & pbook_price_code.Text & " ','" & pbook_price_name.Text & "','" & ptot.Text & "','" & par.Text & "','" & P1 & "','" & P2 & "','" & P3 & "','" & P4 & "')"

        Else
            cmd.CommandText = "insert into ltest_price (test_code,test_name,[book_price_code],[book_price_name],tot,ar)  values ('" & ptest_code.Text & "','" & ptest_name.Text & "','" & pbook_price_code.Text & " ','" & pbook_price_name.Text & "','" & ptot.Text & "','" & par.Text & "')"

        End If
        cmd.ExecuteNonQuery()
        ptest_name.Text = ""
        ptest_name.Focus()
    End Sub
    Private Sub GlassButton64_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton64.Click
        If IsNumeric(ptest_code.Text) = False Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·ﬂÊœ") : Exit Sub
        If ptest_name.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
        If IsNumeric(pbook_price_code.Text) = False Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·ﬂÊœ") : Exit Sub
        If pbook_price_name.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
        dr.Close()
        cmd.CommandText = "select * from ltest_price where   test_name='" & ptest_name.Text & "' and book_price_name='" & pbook_price_name.Text & "' "
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Dim n As String
            n = MsgBox(" Â·  —Ìœ «·Õ–› ø", MsgBoxStyle.YesNo)
            If n = vbNo Then Exit Sub
            dr.Close()
            cmd.CommandText = "delete from ltest_price where    test_name='" & ptest_name.Text & "' and book_price_name='" & pbook_price_name.Text & "' "
            cmd.ExecuteNonQuery()
            apd = 1
        End If
        GlassButton66_Click(GlassButton66, e)
       

        'Dim x As Integer = 2 Mod 12
        'MsgBox(x)
    End Sub

    Private Sub GlassButton67_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton67.Click
        Dim S As Integer = InputBox("ENTER PASWORD")
        If S <> 205 Then Exit Sub
        If LTEST.Rows.Count <= 0 Then MsgBox("·«  ÊÃœ »Ì«‰« ") : Exit Sub
        If IsNumeric(pbook_price_code.Text) = False Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·ﬂÊœ") : Exit Sub
        If pbook_price_name.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
        tr = 0
        FRC = book_price.Select("NAME='" & dbook_price_name.Text & "'")
        If FRC.Length <= 0 Then
            pbook_price_name.Text = ""
            pbook_price_code.Text = ""
            Exit Sub
        Else
            RC = FRC(0)
            pbook_price_code.Text = RC("code")
        End If
        GlassButton66_Click(GlassButton66, e)
        dr.Close()
        cmd.CommandText = "delete from ltest_price where book_price_name='" & dbook_price_name.Text & "'"
        cmd.ExecuteNonQuery()
        While Not tr = LTEST.Rows.Count
            trc()
            tsave()
            ptest_name.Text = ""
            ptest_name.Focus()
            tr = tr + 1
        End While
        apd = 1
        GlassButton66_Click(GlassButton66, e)
    End Sub

    Private Sub GlassButton58_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cmdb.DataAdapter = adtest_price
        adtest_price.Update(DBS, "test_price")
    End Sub

    Private Sub GlassButton62_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton62.Click
        Dim S As Integer = InputBox("ENTER PASWORD")
        If S <> 205 Then Exit Sub
        If IsNumeric(pbook_price_code.Text) = False Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·ﬂÊœ") : Exit Sub
        If pbook_price_name.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
        dr.Close()
        cmd.CommandText = "delete from ltest_price where book_price_name='" & pbook_price_name.Text & "'"
        cmd.ExecuteNonQuery()
        
    End Sub

    Private Sub GlassButton61_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton61.Click
        If LTEST.Rows.Count <= 0 Then MsgBox("·«  ÊÃœ »Ì«‰« ") : Exit Sub
        tr = tr - 1
        If tr < 0 Then tr = 0
        trc()
    End Sub

    Private Sub GlassButton60_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton60.Click
        If LTEST.Rows.Count <= 0 Then MsgBox("·«  ÊÃœ »Ì«‰« ") : Exit Sub
        tr = tr + 1
        If tr >= LTEST.Rows.Count Then tr = LTEST.Rows.Count - 1
        trc()
    End Sub

    Private Sub GlassButton59_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton59.Click
        If LTEST.Rows.Count <= 0 Then MsgBox("·«  ÊÃœ »Ì«‰« ") : Exit Sub
        tr = LTEST.Rows.Count - 1
        trc()
    End Sub

    Private Sub DataGridView7_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView7.CellContentClick

    End Sub

    Private Sub DataGridView7_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView7.CellEndEdit

        cmdb.DataAdapter = adtest_price
        adtest_price.Update(DBS, "test_price")
        apd = 1
    End Sub

    Private Sub DataGridView7_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView7.CellMouseClick
        On Error Resume Next
        ptest_code.Text = DataGridView7(("test_code"), e.RowIndex).Value
        ptest_name.Text = DataGridView7(("test_name"), e.RowIndex).Value
        pbook_price_code.Text = DataGridView7(("book_price_code"), e.RowIndex).Value
        pbook_price_name.Text = DataGridView7(("book_price_name"), e.RowIndex).Value
        ptot.Text = DataGridView7(("tot"), e.RowIndex).Value
    End Sub

    Private Sub pbook_price_name_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbook_price_name.GotFocus
        flng("EN")
    End Sub

    Private Sub pbook_price_name_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbook_price_name.SelectedIndexChanged
        If pbook_price_name.Focused = False Then Exit Sub
        If pbook_price_name.Text = "" Then Exit Sub
        If EX = 1 Then Exit Sub
        FRC = book_price.Select("NAME='" & pbook_price_name.Text & "'")
        If FRC.Length <= 0 Then
            pbook_price_name.Text = ""
            pbook_price_code.Text = ""
            Exit Sub
        Else
            RC = FRC(0)
            pbook_price_code.Text = RC("code")
        End If
        GlassButton66_Click(GlassButton66, e)
    End Sub

    Private Sub cbook_price_name_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbook_price_name.SelectedIndexChanged
        If cbook_price_name.Focused = False Then Exit Sub
        If cbook_price_name.Text = "" Then Exit Sub
        If EX = 1 Then Exit Sub
        FRC = book_price.Select("NAME='" & cbook_price_name.Text & "'")
        If FRC.Length <= 0 Then
            cbook_price_name.Text = ""
            cbook_price_code.Text = ""
            Exit Sub
        Else
            RC = FRC(0)
            cbook_price_code.Text = RC("code")
        End If
    End Sub

    Private Sub GlassButton68_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton68.Click

        dr.Close()
        cmd.CommandText = "DELETE FROM ltest_price WHERE book_price_code='" & cbook_price_code.Text & "'"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "insert into ltest_price (test_code,test_name,tot,ar,p1,p2,p3,p4)  select test_code,test_name,tot,ar,p1,p2,p3,p4 from  ltest_price where book_price_code='" & pbook_price_code.Text & "'"
        MsgBox(cmd.ExecuteNonQuery())
        cmd.CommandText = "update ltest_price set book_price_name='" & cbook_price_name.Text & "',book_price_code='" & cbook_price_code.Text & "',tot=tot*'" & per.Text * 0.01 & "' where book_price_code IS NULL "
        cmd.ExecuteNonQuery()
        cmd.CommandText = "UPDATE ltest_price SET TOT=CAST(TOT AS INT) where book_price_name='" & pbook_price_name.Text & "'"
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub gtest_name_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles gtest_name.GotFocus
        flng("EN")
    End Sub

    Private Sub TextBox4_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gtest_name.KeyUp

        cmdLTEST.Connection = CN
        cmdLTEST.CommandType = CommandType.Text
        cmdLTEST.CommandText = "select * FROM LTEST where test_name like '%" & gtest_name.Text & "%'"
        adLTEST.SelectCommand = cmdLTEST
        adLTEST.Fill(DBS, "LTEST")
        LTEST = DBS.Tables("LTEST")
        DBS.Tables("LTEST").Clear()
        adLTEST.Fill(DBS, "LTEST")
        LTEST = DBS.Tables("LTEST")
        DataGridView9.DataSource = LTEST
        DataGridView9.Columns("test_code").Visible = False
        If e.KeyCode = Keys.Enter Then

            If gtest_name.Text = "" Then Exit Sub
            dr.Close()
            cmd.CommandText = "select * from ltest where test_name='" & gtest_name.Text & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then
                dr1.Close()
                cmd1.CommandText = "DELETE from lgroup_test where test_name='" & gtest_name.Text & "'"
                cmd1.ExecuteNonQuery()
                cmd1.CommandText = "insert into lgroup_test (test_code,test_name,gcode,gname)  values ('" & dr("test_code") & "','" & dr("test_name") & "','" & group_code.Text & " ','" & group_name.Text & "')"
                cmd1.ExecuteNonQuery()
            End If
            gtest_name.Text = ""
            apd = 1
        End If
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gtest_name.TextChanged

    End Sub

    Private Sub GlassButton70_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton70.Click
        If IsNumeric(group_code.Text) = False Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·ﬂÊœ") : Exit Sub
        If gbook_price_name.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub

        dr.Close()
        cmd.CommandText = "select * from lgroup_price where   gname='" & group_name.Text & "' and book_price_name='" & gbook_price_name.Text & "' "
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Dim n As String
            n = MsgBox(" Â·  —Ìœ «· ⁄œÌ· ø", MsgBoxStyle.YesNo)
            If n = vbNo Then Exit Sub
            dr.Close()
            cmd.CommandText = "delete from lgroup_price where    gname='" & group_name.Text & "' and book_price_name='" & gbook_price_name.Text & "' "
            cmd.ExecuteNonQuery()

        End If

        dr.Close() : cmd.CommandText = "insert into lgroup_price (gcode,gname,[book_price_code],[book_price_name],tot)  values ('" & group_code.Text & "','" & group_name.Text & "','" & gbook_price_code.Text & " ','" & gbook_price_name.Text & "','" & gtot.Text & "')"
        cmd.ExecuteNonQuery()

    End Sub

    Private Sub group_name_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles group_name.GotFocus
        flng("EN")
    End Sub

    Private Sub ComboBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles group_name.KeyDown
        Dim n As String
        If e.KeyCode = Keys.Enter Then
            n = ""
            n = MsgBox(" Â·  —Ìœ «·Õ›Ÿ ø", MsgBoxStyle.YesNo)
            If n = vbNo Then Exit Sub
            dr.Close() : cmd.CommandText = "select MAx(code) from lgroup "
            dr = cmd.ExecuteReader
            dr.Read()
            If IsDBNull(dr(0)) = False Then
                group_code.Text = 1 + dr(0)
            Else
                group_code.Text = 1
            End If

            If group_name.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
            dr.Close()
            cmd.CommandText = "select * from lgroup where   code='" & group_code.Text & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                n = ""
                n = MsgBox(" Â·  —Ìœ «· ⁄œÌ· ø", MsgBoxStyle.YesNo)
                If n = vbNo Then Exit Sub
                dr.Close()
                cmd.CommandText = "delete from lgroup where    code='" & group_code.Text & "'"
                cmd.ExecuteNonQuery()

            End If

            dr.Close() : cmd.CommandText = "insert into lgroup (code,name)  values ('" & group_code.Text & "','" & group_name.Text & "')"
            cmd.ExecuteNonQuery()

            groupf()
        End If
        If e.KeyCode = Keys.Delete Then
            n = MsgBox(" Â·  —Ìœ «·Õ–› ø", MsgBoxStyle.YesNo)
            If IsNumeric(group_code.Text) = False Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·ﬂÊœ") : Exit Sub
            If group_name.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
            dr.Close()
            cmd.CommandText = "select * from lgroup where   code='" & group_code.Text & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                dr.Close()
                cmd.CommandText = "delete from lgroup where    code='" & group_code.Text & "'"
                cmd.ExecuteNonQuery()

            End If
            groupf()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles group_name.SelectedIndexChanged
        If group_name.Focused = False Then Exit Sub
        If group_name.Text = "" Then Exit Sub
        If EX = 1 Then Exit Sub
        FRC = group.Select("NAME='" & group_name.Text & "'")
        If FRC.Length <= 0 Then
            group_name.Text = ""
            group_code.Text = ""
            Exit Sub
        Else
            RC = FRC(0)
            group_code.Text = RC("code")
        End If
        cmdLgroup_price.Connection = CN
        cmdLgroup_price.CommandType = CommandType.Text
        cmdLgroup_price.CommandText = "select * FROM lgroup_test where gname='" & group_name.Text & "'"
        adLgroup_price.SelectCommand = cmdLgroup_price
        adLgroup_price.Fill(DBS, "lgroup_price")
        Lgroup_price = DBS.Tables("lgroup_price")
        DBS.Tables("lgroup_price").Clear()
        adLgroup_price.Fill(DBS, "lgroup_price")
        Lgroup_price = DBS.Tables("lgroup_price")
        DataGridView8.DataSource = Lgroup_price

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbook_price_name.SelectedIndexChanged
        If gbook_price_name.Focused = False Then Exit Sub
        If gbook_price_name.Text = "" Then Exit Sub
        If EX = 1 Then Exit Sub
        FRC = book_price.Select("NAME='" & gbook_price_name.Text & "'")
        If FRC.Length <= 0 Then
            gbook_price_name.Text = ""
            gbook_price_code.Text = ""
            Exit Sub
        Else
            RC = FRC(0)
            gbook_price_code.Text = RC("code")
        End If
    End Sub

    Private Sub GlassButton74_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton74.Click
        cmdLTEST.Connection = CN
        cmdLTEST.CommandType = CommandType.Text
        cmdLTEST.CommandText = "select * FROM LTEST "
        adLTEST.SelectCommand = cmdLTEST
        adLTEST.Fill(DBS, "LTEST")
        LTEST = DBS.Tables("LTEST")
        DBS.Tables("LTEST").Clear()
        adLTEST.Fill(DBS, "LTEST")
        LTEST = DBS.Tables("LTEST")
        DataGridView9.DataSource = LTEST
        DataGridView9.Columns("test_code").Visible = False

        dr.Close()
        cmd.CommandText = "select * from lgroup_test where gname='" & group_name.Text & "'"
        dr = cmd.ExecuteReader
        While dr.Read
            FRC = LTEST.Select("test_NAME='" & dr("test_name") & "'")
            If FRC.Length > 0 Then
                RC = FRC(0)
                RC.BeginEdit()
                RC("qun") = 1
                RC.EndEdit()
            End If
        End While

    End Sub

    Private Sub GlassButton69_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton69.Click
        If IsNumeric(group_code.Text) = False Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·ﬂÊœ") : Exit Sub
        Dim aw As String
        aw = MsgBox("Â·  —Ìœ Õ›Ÿ ﬂ· «· Õ«·Ì· «· Ï  „ «Œ Ì«—Â«", MsgBoxStyle.YesNo)
        If aw = vbNo Then Exit Sub

        dr.Close()
        cmd.CommandText = "delete from lgroup_test where    gname='" & group_name.Text & "'"
        cmd.ExecuteNonQuery()

        Dim n As Integer = 0
        While Not n = LTEST.Rows.Count
            RC = LTEST.Rows(n)
            If IsDBNull(RC("qun")) = False Then
                If RC("qun") = 1 Then
                    dr.Close()
                    cmd.CommandText = "insert into lgroup_test (test_code,test_name,gcode,gname)  values ('" & RC("test_code") & "','" & RC("test_name") & "','" & group_code.Text & " ','" & group_name.Text & "')"
                    cmd.ExecuteNonQuery()
                End If
            End If
            n = n + 1
        End While
    End Sub

    Private Sub GlassButton77_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton77.Click
        cmdLTEST.Connection = CN
        cmdLTEST.CommandType = CommandType.Text
        cmdLTEST.CommandText = "select * FROM LTEST "
        adLTEST.SelectCommand = cmdLTEST
        adLTEST.Fill(DBS, "LTEST")
        LTEST = DBS.Tables("LTEST")
        DBS.Tables("LTEST").Clear()
        adLTEST.Fill(DBS, "LTEST")
        LTEST = DBS.Tables("LTEST")
        DataGridView9.DataSource = LTEST
        DataGridView9.Columns("test_code").Visible = False
        'cmdLgroup_price.Connection = CN
        'cmdLgroup_price.CommandType = CommandType.Text
        'cmdLgroup_price.CommandText = "select * FROM lgroup_price "
        'adLgroup_price.SelectCommand = cmdLgroup_price
        'adLgroup_price.Fill(DBS, "lgroup_price")
        'Lgroup_price = DBS.Tables("lgroup_price")
        'DBS.Tables("lgroup_price").Clear()
        'adLgroup_price.Fill(DBS, "lgroup_price")
        'Lgroup_price = DBS.Tables("lgroup_price")
        'DataGridView8.DataSource = Lgroup_price

    End Sub

    Private Sub GlassButton76_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton76.Click

    End Sub

    Private Sub GlassButton83_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton83.Click
        dr.Close() : cmd.CommandText = "select MAx(code) from lreg "
        dr = cmd.ExecuteReader
        dr.Read()
        If IsDBNull(dr(0)) = False Then
            rcode.Text = 1 + dr(0)
        Else
            rcode.Text = 1
        End If
        cmdLreg.Connection = CN
        cmdLreg.CommandType = CommandType.Text
        cmdLreg.CommandText = "select * FROM lreg"
        adLreg.SelectCommand = cmdLreg
        adLreg.Fill(DBS, "lreg")
        lreg = DBS.Tables("lreg")
        DBS.Tables("lreg").Clear()
        adLreg.Fill(DBS, "lreg")
        lreg = DBS.Tables("lreg")
        DataGridView10.DataSource = lreg
        rname.Text = ""
        rper.Text = 0
        rname.Focus()
    End Sub

    Private Sub GlassButton82_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton82.Click
        If IsNumeric(rcode.Text) = False Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·ﬂÊœ") : Exit Sub
        If rname.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
        If IsNumeric(rper.Text) = False Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·‰”»…") : Exit Sub
        dr.Close()
        cmd.CommandText = "select * from lreg where   code='" & rcode.Text & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Dim n As String
            n = MsgBox(" Â·  —Ìœ «· ⁄œÌ· ø", MsgBoxStyle.YesNo)
            If n = vbNo Then Exit Sub
            dr.Close()
            cmd.CommandText = "delete from lreg where    code='" & rcode.Text & "'"
            cmd.ExecuteNonQuery()

        End If
        dr.Close()
        cmd.CommandText = "select * from lreg where   name='" & rname.Text & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Dim n As String
            n = MsgBox(" Â·  —Ìœ «· ⁄œÌ· ø", MsgBoxStyle.YesNo)
            If n = vbNo Then Exit Sub
            dr.Close()
            cmd.CommandText = "delete from lreg where name='" & rname.Text & "'"
            cmd.ExecuteNonQuery()

        End If
        dr.Close() : cmd.CommandText = "insert into lreg (code,name,per)  values ('" & rcode.Text & "','" & Trim(rname.Text) & "','" & rper.Text & "')"
        cmd.ExecuteNonQuery()
        GlassButton83_Click(GlassButton83, e)
    End Sub

    Private Sub GlassButton81_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton81.Click
        If IsNumeric(rcode.Text) = False Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·ﬂÊœ") : Exit Sub
        If rname.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
        If IsNumeric(rper.Text) = False Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·‰”»…") : Exit Sub
        dr.Close()
        cmd.CommandText = "select * from lreg where   code='" & rcode.Text & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Dim n As String
            n = MsgBox(" Â·  —Ìœ «·Õ–› ø", MsgBoxStyle.YesNo)
            If n = vbNo Then Exit Sub
            dr.Close()
            cmd.CommandText = "delete from lreg where    code='" & rcode.Text & "'"
            cmd.ExecuteNonQuery()

        End If

        GlassButton83_Click(GlassButton83, e)
    End Sub

    Private Sub GlassButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GlassButton71_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton71.Click
        cmdb.DataAdapter = adLreg
        adLreg.Update(DBS, "lreg")

    End Sub

    Private Sub GlassButton79_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton79.Click
        If lreg.Rows.Count <= 0 Then MsgBox("·«  ÊÃœ »Ì«‰« ") : Exit Sub
        re = 0
        rcode.Text = lreg.Rows(re).Item("code")
        rper.Text = lreg.Rows(re).Item("per")
        rname.Text = lreg.Rows(re).Item("name")

    End Sub

    Private Sub GlassButton78_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton78.Click
        If lreg.Rows.Count <= 0 Then MsgBox("·«  ÊÃœ »Ì«‰« ") : Exit Sub
        re = re - 1
        If re < 0 Then re = 0
        rcode.Text = lreg.Rows(re).Item("code")
        rper.Text = lreg.Rows(re).Item("per")
        rname.Text = lreg.Rows(re).Item("name")
    End Sub

    Private Sub GlassButton73_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton73.Click
        If lreg.Rows.Count <= 0 Then MsgBox("·«  ÊÃœ »Ì«‰« ") : Exit Sub
        re = re + 1
        If re >= lreg.Rows.Count Then r = lreg.Rows.Count - 1

        rcode.Text = lreg.Rows(re).Item("code")
        rper.Text = lreg.Rows(re).Item("per")
        rname.Text = lreg.Rows(re).Item("name")

    End Sub

    Private Sub GlassButton72_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton72.Click
        If lreg.Rows.Count <= 0 Then MsgBox("·«  ÊÃœ »Ì«‰« ") : Exit Sub
        re = lreg.Rows.Count - 1
        rcode.Text = lreg.Rows(re).Item("code")
        rper.Text = lreg.Rows(re).Item("per")
        rname.Text = lreg.Rows(re).Item("name")

    End Sub

    Private Sub DataGridView10_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView10.CellContentClick

    End Sub

    Private Sub DataGridView10_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView10.CellEndEdit
        cmdb.DataAdapter = adLreg
        adLreg.Update(DBS, "lreg")

    End Sub

    Private Sub DataGridView10_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView10.CellMouseClick
        On Error Resume Next
        rcode.Text = DataGridView10(("CODE"), e.RowIndex).Value
        rname.Text = DataGridView10(("NAME"), e.RowIndex).Value
        rper.Text = DataGridView10(("per"), e.RowIndex).Value
    End Sub

    Private Sub TabPage9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage9.Click

    End Sub

    Private Sub GlassButton92_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton92.Click
        dr.Close() : cmd.CommandText = "select MAx(code) from ldoc "
        dr = cmd.ExecuteReader
        dr.Read()
        If IsDBNull(dr(0)) = False Then
            dcode.Text = 1 + dr(0)
        Else
            dcode.Text = 1
        End If
        cmdLdoc.Connection = CN
        cmdLdoc.CommandType = CommandType.Text
        cmdLdoc.CommandText = "select * FROM ldoc"
        adLdoc.SelectCommand = cmdLdoc
        adLdoc.Fill(DBS, "ldoc")
        ldoc = DBS.Tables("ldoc")
        DBS.Tables("ldoc").Clear()
        adLdoc.Fill(DBS, "ldoc")
        ldoc = DBS.Tables("ldoc")
        DataGridView11.DataSource = ldoc
        dname.Text = ""
        tell.Text = ""
        demail.Text = ""
        adress.Text = ""
        dname.Text = ""
        dname.Focus()

    End Sub

    Private Sub GlassButton91_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton91.Click
        If IsNumeric(dcode.Text) = False Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·ﬂÊœ") : Exit Sub
        If dname.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
        'If IsNumeric(rper.Text) = False Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·‰”»…") : Exit Sub
        dr.Close()
        cmd.CommandText = "select * from ldoc where   code='" & dcode.Text & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Dim n As String
            n = MsgBox(" Â·  —Ìœ «· ⁄œÌ· ø", MsgBoxStyle.YesNo)
            If n = vbNo Then Exit Sub
            dr.Close()
            cmd.CommandText = "delete from ldoc where    code='" & dcode.Text & "'"
            cmd.ExecuteNonQuery()

        End If
        dr.Close()
        cmd.CommandText = "select * from ldoc where   name='" & dname.Text & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Dim n As String
            n = MsgBox(" Â·  —Ìœ «· ⁄œÌ· ø", MsgBoxStyle.YesNo)
            If n = vbNo Then Exit Sub
            dr.Close()
            cmd.CommandText = "delete from ldoc where name='" & dname.Text & "'"
            cmd.ExecuteNonQuery()

        End If
        dr.Close() : cmd.CommandText = "insert into ldoc (code,name,tell,adress,email)  values ('" & dcode.Text & "','" & Trim(dname.Text) & "','" & tell.Text & "','" & adress.Text & "','" & demail.Text & "')"
        cmd.ExecuteNonQuery()
        GlassButton92_Click(GlassButton92, e)

    End Sub

    Private Sub GlassButton90_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton90.Click
        If IsNumeric(dcode.Text) = False Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·ﬂÊœ") : Exit Sub
        If dname.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
        'If IsNumeric(rper.Text) = False Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·‰”»…") : Exit Sub
        dr.Close()
        cmd.CommandText = "select * from ldoc where   code='" & dcode.Text & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Dim n As String
            n = MsgBox(" Â·  —Ìœ «·Õ–› ø", MsgBoxStyle.YesNo)
            If n = vbNo Then Exit Sub
            dr.Close()
            cmd.CommandText = "delete from ldoc where    code='" & dcode.Text & "'"
            cmd.ExecuteNonQuery()

        End If
        GlassButton92_Click(GlassButton92, e)

    End Sub

    Private Sub GlassButton84_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton84.Click
        cmdb.DataAdapter = adLreg
        adLreg.Update(DBS, "lreg")

    End Sub

    Private Sub GlassButton88_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton88.Click
        If ldoc.Rows.Count <= 0 Then MsgBox("·«  ÊÃœ »Ì«‰« ") : Exit Sub
        DE = 0
        dcode.Text = ldoc.Rows(DE).Item("code")
        dname.Text = ldoc.Rows(DE).Item("name")

    End Sub

    Private Sub GlassButton87_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton87.Click
        If ldoc.Rows.Count <= 0 Then MsgBox("·«  ÊÃœ »Ì«‰« ") : Exit Sub
        DE = DE - 1
        If DE < 0 Then DE = 0
        dcode.Text = ldoc.Rows(DE).Item("code")
        dname.Text = ldoc.Rows(DE).Item("name")
    End Sub

    Private Sub GlassButton86_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton86.Click
        If ldoc.Rows.Count <= 0 Then MsgBox("·«  ÊÃœ »Ì«‰« ") : Exit Sub
        DE = DE + 1
        If DE >= ldoc.Rows.Count Then DE = ldoc.Rows.Count - 1
        dcode.Text = ldoc.Rows(DE).Item("code")
        dname.Text = ldoc.Rows(DE).Item("name")
    End Sub

    Private Sub GlassButton85_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton85.Click
        If ldoc.Rows.Count <= 0 Then MsgBox("·«  ÊÃœ »Ì«‰« ") : Exit Sub
        DE = ldoc.Rows.Count - 1
        dcode.Text = ldoc.Rows(DE).Item("code")
        dname.Text = ldoc.Rows(DE).Item("name")
    End Sub

    Private Sub DataGridView11_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView11.CellContentClick

    End Sub

    Private Sub DataGridView11_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView11.CellEndEdit
        cmdb.DataAdapter = adLdoc
        adLdoc.Update(DBS, "Ldoc")
    End Sub

    Private Sub DataGridView11_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView11.CellMouseClick
        On Error Resume Next
        dcode.Text = DataGridView11(("CODE"), e.RowIndex).Value
        dname.Text = DataGridView11(("NAME"), e.RowIndex).Value
        tell.Text = DataGridView11(("tell"), e.RowIndex).Value
        adress.Text = DataGridView11(("adress"), e.RowIndex).Value
        demail.Text = DataGridView11(("email"), e.RowIndex).Value
    End Sub

    Private Sub GlassButton101_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton101.Click
        dr.Close() : cmd.CommandText = "select MAx(code) from lshift "
        dr = cmd.ExecuteReader
        dr.Read()
        If IsDBNull(dr(0)) = False Then
            fcode.Text = 1 + dr(0)
        Else
            fcode.Text = 1
        End If
        cmdlshift.Connection = CN
        cmdlshift.CommandType = CommandType.Text
        cmdlshift.CommandText = "select * FROM lshift"
        adlshift.SelectCommand = cmdlshift
        adlshift.Fill(DBS, "lshift")
        lshift = DBS.Tables("lshift")
        DBS.Tables("lshift").Clear()
        adlshift.Fill(DBS, "lshift")
        lshift = DBS.Tables("lshift")
        DataGridView12.DataSource = lshift
        fname.Text = ""
        fname.Focus()

    End Sub

    Private Sub GlassButton100_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton100.Click
        If IsNumeric(fcode.Text) = False Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·ﬂÊœ") : Exit Sub
        If fname.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
        'If IsNumeric(rper.Text) = False Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·‰”»…") : Exit Sub
        dr.Close()
        cmd.CommandText = "select * from lshift where   code='" & fcode.Text & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Dim n As String
            n = MsgBox(" Â·  —Ìœ «· ⁄œÌ· ø", MsgBoxStyle.YesNo)
            If n = vbNo Then Exit Sub
            dr.Close()
            cmd.CommandText = "delete from lshift where    code='" & fcode.Text & "'"
            cmd.ExecuteNonQuery()

        End If
        dr.Close()
        cmd.CommandText = "select * from lshift where   name='" & fname.Text & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Dim n As String
            n = MsgBox(" Â·  —Ìœ «· ⁄œÌ· ø", MsgBoxStyle.YesNo)
            If n = vbNo Then Exit Sub
            dr.Close()
            cmd.CommandText = "delete from lshift where name='" & fname.Text & "'"
            cmd.ExecuteNonQuery()

        End If
        dr.Close() : cmd.CommandText = "insert into lshift (code,name)  values ('" & fcode.Text & "','" & Trim(fname.Text) & "')"
        cmd.ExecuteNonQuery()
        GlassButton101_Click(GlassButton101, e)

    End Sub

    Private Sub GlassButton99_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton99.Click
        If IsNumeric(fcode.Text) = False Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·ﬂÊœ") : Exit Sub
        If fname.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
        'If IsNumeric(rper.Text) = False Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·‰”»…") : Exit Sub
        dr.Close()
        cmd.CommandText = "select * from lshift where   code='" & fcode.Text & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Dim n As String
            n = MsgBox(" Â·  —Ìœ «·Õ–› ø", MsgBoxStyle.YesNo)
            If n = vbNo Then Exit Sub
            dr.Close()
            cmd.CommandText = "delete from lshift where    code='" & fcode.Text & "'"
            cmd.ExecuteNonQuery()

        End If
        GlassButton101_Click(GlassButton101, e)

    End Sub

    Private Sub GlassButton97_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton97.Click

    End Sub

    Private Sub DataGridView12_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView12.CellContentClick

    End Sub

    Private Sub DataGridView12_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView12.CellMouseClick
        On Error Resume Next
        fcode.Text = DataGridView12(("CODE"), e.RowIndex).Value
        fname.Text = DataGridView12(("NAME"), e.RowIndex).Value

    End Sub

    Private Sub GlassButton22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton22.Click
        Dim st As String = ""

        If cstest_name.Checked = True Then
            st = st & "  " & " where mtest_Name='" & mtest_name.Text & "'"
        End If

        cmdLSUBTEST.Connection = CN
        cmdLSUBTEST.CommandType = CommandType.Text
        cmdLSUBTEST.CommandText = "select * FROM LSUBTEST " & st
        adLSUBTEST.SelectCommand = cmdLSUBTEST
        adLSUBTEST.Fill(DBS, "LSUBTEST")
        LSUBTEST = DBS.Tables("LSUBTEST")
        DBS.Tables("LSUBTEST").Clear()
        adLSUBTEST.Fill(DBS, "LSUBTEST")
        LSUBTEST = DBS.Tables("LSUBTEST")
        DataGridView3.DataSource = LSUBTEST
        dr.Close()
        Dim oj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        oj.Load(Application.StartupPath & "\test sub.rpt")
        oj.Database.Tables(0).SetDataSource(LSUBTEST)

        rp.CrystalReportViewer1.ReportSource = oj

        rp.Show() : rp.Focus()
    End Sub

    Private Sub GlassButton33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton33.Click
        Dim st As String = "where ky>-1"

        If ctest.Checked = True Then
            st = st & "  " & " and test_Name='" & Ntest_NAME.Text & "'"
        End If
        If type.Checked = True Then
            st = st & "  " & " and type='" & NTYPE.Text & "'"
        End If
        If cunit.Checked = True Then
            st = st & "  " & " and unit='" & nunit.Text & "'"
        End If


        cmdLNTEST.Connection = CN
        cmdLNTEST.CommandType = CommandType.Text
        cmdLNTEST.CommandText = "select * FROM LNTEST " & st
        adLNTEST.SelectCommand = cmdLNTEST
        adLNTEST.Fill(DBS, "LNTEST")
        LNTEST = DBS.Tables("LNTEST")
        DBS.Tables("LNTEST").Clear()
        adLNTEST.Fill(DBS, "LNTEST")
        LNTEST = DBS.Tables("LNTEST")
        DataGridView5.DataSource = LNTEST
        dr.Close()
        Dim oj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        oj.Load(Application.StartupPath & "\test nor.rpt")
        oj.Database.Tables(0).SetDataSource(LNTEST)

        rp.CrystalReportViewer1.ReportSource = oj

        rp.Show() : rp.Focus()
    End Sub

    Private Sub GlassButton42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton42.Click
        Dim st As String = "where ky>-1"

        If cstest.Checked = True Then
            st = st & "  " & " and test_Name='" & nstest_name.Text & "'"
        End If
        If cmtest.Checked = True Then
            st = st & "  " & " and mtest_Name='" & mtest_name.Text & "'"
        End If
        If cntype.Checked = True Then
            st = st & "  " & " and type='" & nstype.Text & "'"
        End If
        If cnunit.Checked = True Then
            st = st & "  " & " and unit='" & nsunit.Text & "'"
        End If


        cmdLnsTEST.Connection = CN
        cmdLnsTEST.CommandType = CommandType.Text
        cmdLnsTEST.CommandText = "select * FROM lnstest " & st
        adLnsTEST.SelectCommand = cmdLnsTEST
        adLnsTEST.Fill(DBS, "lnstest")
        LnsTEST = DBS.Tables("lnstest")
        DBS.Tables("lnstest").Clear()
        adLnsTEST.Fill(DBS, "lnstest")
        LnsTEST = DBS.Tables("lnstest")
        DataGridView4.DataSource = LnsTEST
        dr.Close()
        Dim oj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        oj.Load(Application.StartupPath & "\sub nor.rpt")
        oj.Database.Tables(0).SetDataSource(LnsTEST)

        rp.CrystalReportViewer1.ReportSource = oj

        rp.Show() : rp.Focus()
    End Sub

    Private Sub GlassButton63_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton63.Click
        Dim st As String = "where tot>0"

        If cbtestname.Checked = True Then
            st = st & "  " & " and test_Name='" & ptest_name.Text & "'"
        End If
        If cbar.Checked = True Then
            st = st & "  " & " and ar='" & par.Text & "'"
        End If
        If ctot.Checked = True Then
            st = st & "  " & " and tot='" & ptot.Text & "'"
        End If
        If cbook.Checked = True Then
            st = st & "  " & " and book_price_name='" & pbook_price_name.Text & "'"
        End If
        dr.Close()
        cmd.CommandText = "UPDATE ltest_price SET TOT=CAST(TOT AS INT) where book_price_name='" & pbook_price_name.Text & "'"
        cmd.ExecuteNonQuery()

        cmdtest_price.Connection = CN
        cmdtest_price.CommandType = CommandType.Text
        cmdtest_price.CommandText = "select * FROM ltest_price " & st
        adtest_price.SelectCommand = cmdtest_price
        adtest_price.Fill(DBS, "test_price")
        test_price = DBS.Tables("test_price")
        DBS.Tables("test_price").Clear()
        adtest_price.Fill(DBS, "test_price")
        test_price = DBS.Tables("test_price")
        DataGridView4.DataSource = test_price
        dr.Close()
        Dim oj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        oj.Load(Application.StartupPath & "\test price.rpt")
        oj.Database.Tables(0).SetDataSource(test_price)
        rp.CrystalReportViewer1.ReportSource = oj
        rp.Show() : rp.Focus()
    End Sub

    Private Sub GlassButton102_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton102.Click
        cmdgg.Connection = CN
        cmdgg.CommandType = CommandType.Text
        cmdgg.CommandText = "select * FROM lgroup_test "
        adgg.SelectCommand = cmdgg
        adgg.Fill(DBS, "gg")
        gg = DBS.Tables("gg")
        DBS.Tables("gg").Clear()
        adgg.Fill(DBS, "gg")
        gg = DBS.Tables("gg")
        DataGridView4.DataSource = gg
        dr.Close()
        Dim oj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        oj.Load(Application.StartupPath & "\group test.rpt")
        oj.Database.Tables(0).SetDataSource(gg)
        rp.CrystalReportViewer1.ReportSource = oj
        rp.Show() : rp.Focus()
    End Sub


    Private Sub gcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gcode.TextChanged

    End Sub

    Private Sub GlassButton111_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton111.Click
        If mng = 0 Then
            MsgBox("·Ì”  ·œÌﬂﬂ «·’·«ÕÌ…")
            LLOG("Õ›Ÿ ÃœÌœ", 0, "Õ›Ÿ „” Œœ„ ÃœÌœ", 0, BRAN.Text)
            Exit Sub
        End If
        dr.Close() : cmd.CommandText = "select MAx(code) from users "
        dr = cmd.ExecuteReader
        dr.Read()
        If IsDBNull(dr(0)) = False Then
            ucode.Text = 1 + dr(0)
        Else
            ucode.Text = 1
        End If
        cmdusers.Connection = CN
        cmdusers.CommandType = CommandType.Text
        cmdusers.CommandText = "select * FROM users"
        adusers.SelectCommand = cmdusers
        adusers.Fill(DBS, "users")
        users = DBS.Tables("users")
        DBS.Tables("users").Clear()
        adusers.Fill(DBS, "users")
        users = DBS.Tables("users")
        DataGridView13.DataSource = users
        upass.Text = ""
        uname.Text = ""
        uname.Focus()
    End Sub

    Private Sub GlassButton110_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton110.Click

        If IsNumeric(ucode.Text) = False Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·ﬂÊœ") : Exit Sub
        If uname.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
        If upass.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
        'If IsNumeric(rper.Text) = False Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·‰”»…") : Exit Sub
        If mng = 0 Then
            MsgBox("·Ì”  ·œÌﬂ «·’·«ÕÌ…")
            LLOG("Õ›Ÿ ÃœÌœ", 0, "Õ›Ÿ „” Œœ„ ÃœÌœ", 0, BRAN.Text)
            Exit Sub
        End If
        dr.Close()
        cmd.CommandText = "select * from users where   pass='" & upass.Text & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Dim n As String
            n = MsgBox(" Â·  —Ìœ «· ⁄œÌ· ø", MsgBoxStyle.YesNo)
            If n = vbNo Then Exit Sub
            dr.Close()
            cmd.CommandText = "delete from users where    pass='" & upass.Text & "'"
            cmd.ExecuteNonQuery()

        End If
        dr.Close()
        cmd.CommandText = "select * from users where   name='" & uname.Text & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Dim n As String
            n = MsgBox(" Â·  —Ìœ «· ⁄œÌ· ø", MsgBoxStyle.YesNo)
            If n = vbNo Then Exit Sub
            dr.Close()
            cmd.CommandText = "delete from users where name='" & uname.Text & "'"
            cmd.ExecuteNonQuery()

        End If
        LLOG("Õ›Ÿ ÃœÌœ", 0, "Õ›Ÿ „” Œœ„ ÃœÌœ" & uname.Text, 1, BRAN.Text)

        dr.Close()
        cmd.CommandText = "INSERT INTO users ([CODE],[NAME],[PASS],[LENTER],[LSAVE],[LEDIT],[LDEL],[LESLRP],[LPRNT],[Lcome],[center],[csave],[cedit],[cdel],[crp],[cbalance],[ctotal],[eenter],[esave],[eedit],[edel],[erp],[esal],[esalsave],[lbld],[ebld],[cbld],admin,lres,[rcv] ,[pa],[tv],[tc],[dc],[pah],[ls],[lp],[lmach],[email],[lng],fcolor,bcolor,doc,lmtp,prntn,rest_prnt,update_test,lemail,lref,ldelg,ldis,luser,pack_name,pack_code,backcolor,ltblg,[lcult],[ldref],[ldelgat],[lpromz],[ltestp],[lpnum],shift,final) VALUES  ('" & ucode.Text & "' ,'" & uname.Text & "' ,'" & upass.Text & "','" & Val(lenter.CheckState) & "','" & Val(lsave.CheckState) & "','" & Val(ledit.CheckState) & "','" & Val(ldel.CheckState) & "','" & Val(leslrp.CheckState) & "','" & Val(lprnt.CheckState) & "','" & Val(pah.CheckState) & "','" & Val(center.CheckState) & "','" & Val(csave.CheckState) & "','" & Val(cedit.CheckState) & "','" & Val(cdel.CheckState) & "','" & Val(crp.CheckState) & "','" & Val(cbalance.CheckState) & "','" & Val(ctotal.CheckState) & "','" & Val(eenter.CheckState) & "','" & Val(esave.CheckState) & "','" & Val(eedit.CheckState) & "','" & Val(edel.CheckState) & "','" & Val(erp.CheckState) & "','" & Val(esal.CheckState) & "','" & Val(esalsave.CheckState) & "','" & Val(lbld1.CheckState) & "','" & Val(ebld.CheckState) & "','" & Val(cbld.CheckState) & "','" & Val(admin.CheckState) & "','" & Val(lres.CheckState) & "','" & Val(rcv.CheckState) & "','" & Val(pa.CheckState) & "','" & Val(tv.CheckState) & "','" & Val(tc.CheckState) & "','" & Val(dc.CheckState) & "','" & Val(pah.CheckState) & "','" & Val(ls.CheckState) & "','" & Val(lp.CheckState) & "','" & Val(lmach.CheckState) & "','" & email.Text & "','" & lng.Text & "','" & fcolor.Text & "','" & bColor.Text & "','" & Val(lmtp.CheckState) & "','" & Val(ldoc1.CheckState) & "','" & Val(prntn.CheckState) & "','" & Val(rest_prnt.CheckState) & "','" & Val(update_test.CheckState) & "','" & Val(lemail.CheckState) & "','" & Val(lref.CheckState) & "','" & Val(ldelg.CheckState) & "','" & Val(ldis.CheckState) & "','" & Val(luser.CheckState) & "','" & pack_name.Text & "','" & pack_code.Text & "','" & backcolor1.Text & "','" & Val(ltblg.Checked) & "','" & Val(lcult1.CheckState) & "','" & Val(ldref.CheckState) & "','" & Val(ldelgat.CheckState) & "','" & Val(lpromz.CheckState) & "','" & Val(ltestp.CheckState) & "','" & Val(lpnum.CheckState) & "','" & TextBox7.Text & "','" & Val(final.CheckState) & "') "
        cmd.ExecuteNonQuery()
        GlassButton111_Click(GlassButton111, e)

    End Sub

    Private Sub GlassButton109_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton109.Click
        If IsNumeric(ucode.Text) = False Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·ﬂÊœ") : Exit Sub
        If uname.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
        If upass.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
        'If IsNumeric(rper.Text) = False Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·‰”»…") : Exit Sub
        If mng = 0 Then
            MsgBox("·Ì”  ·œÌﬂﬂ «·’·«ÕÌ…")
            LLOG("Õ–›", 0, "Õ–› „” Œœ„ " & uname.Text, 0, BRAN.Text)
            Exit Sub
        End If
        dr.Close()
        cmd.CommandText = "select * from users where   pass='" & upass.Text & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Dim n As String
            n = MsgBox(" Â·  —Ìœ «·Õ–› ø", MsgBoxStyle.YesNo)
            If n = vbNo Then Exit Sub
            dr.Close()
            cmd.CommandText = "delete from users where    pass='" & upass.Text & "'"
            cmd.ExecuteNonQuery()
            LLOG("Õ–›", 0, "Õ–› „” Œœ„ " & uname.Text, 1, BRAN.Text)

            GlassButton111_Click(GlassButton111, e)
        End If
    End Sub

    Private Sub DataGridView13_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView13.CellContentClick

    End Sub

    Private Sub DataGridView13_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView13.CellEndEdit
        On Error Resume Next
        cmdb.DataAdapter = adusers
        adusers.Update(DBS, "users")
    End Sub

    Private Sub DataGridView13_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView13.CellMouseClick
        On Error Resume Next
        lenter.CheckState = DataGridView13(("lenter"), e.RowIndex).Value
        lsave.CheckState = DataGridView13(("lsave"), e.RowIndex).Value
        ledit.CheckState = DataGridView13(("ledit"), e.RowIndex).Value
        ldel.CheckState = DataGridView13(("ldel"), e.RowIndex).Value
        leslrp.CheckState = DataGridView13(("leslrp"), e.RowIndex).Value
        lprnt.CheckState = DataGridView13(("lprnt"), e.RowIndex).Value
        pah.CheckState = DataGridView13(("lcome"), e.RowIndex).Value
        center.CheckState = DataGridView13(("center"), e.RowIndex).Value
        csave.CheckState = DataGridView13(("csave"), e.RowIndex).Value
        cedit.CheckState = DataGridView13(("cedit"), e.RowIndex).Value
        cdel.CheckState = DataGridView13(("cdel"), e.RowIndex).Value
        crp.CheckState = DataGridView13(("crp"), e.RowIndex).Value
        cbalance.CheckState = DataGridView13(("cbalance"), e.RowIndex).Value
        ctotal.CheckState = DataGridView13(("ctotal"), e.RowIndex).Value
        eenter.CheckState = DataGridView13(("eenter"), e.RowIndex).Value
        esave.CheckState = DataGridView13(("esave"), e.RowIndex).Value
        eedit.CheckState = DataGridView13(("eedit"), e.RowIndex).Value
        edel.CheckState = DataGridView13(("edel"), e.RowIndex).Value
        erp.CheckState = DataGridView13(("erp"), e.RowIndex).Value
        esal.CheckState = DataGridView13(("esal"), e.RowIndex).Value
        esalsave.CheckState = DataGridView13(("esalsave"), e.RowIndex).Value
        lbld1.CheckState = DataGridView13(("lbld"), e.RowIndex).Value
        ebld.CheckState = DataGridView13(("ebld"), e.RowIndex).Value
        cbld.CheckState = DataGridView13(("cbld"), e.RowIndex).Value
        ucode.Text = DataGridView13(("CODE"), e.RowIndex).Value
        uname.Text = DataGridView13(("NAME"), e.RowIndex).Value
        upass.Text = DataGridView13(("pass"), e.RowIndex).Value
        admin.CheckState = DataGridView13(("admin"), e.RowIndex).Value
        lres.CheckState = DataGridView13(("lres"), e.RowIndex).Value
        lmtp.CheckState = DataGridView13(("lmtp"), e.RowIndex).Value
        ldoc1.CheckState = DataGridView13(("doc"), e.RowIndex).Value
        rcv.CheckState = DataGridView13(("rcv"), e.RowIndex).Value
        pa.CheckState = DataGridView13(("pa"), e.RowIndex).Value
        tv.CheckState = DataGridView13(("tv"), e.RowIndex).Value
        tc.CheckState = DataGridView13(("tc"), e.RowIndex).Value
        dc.CheckState = DataGridView13(("dc"), e.RowIndex).Value
        ls.CheckState = DataGridView13(("ls"), e.RowIndex).Value
        lp.CheckState = DataGridView13(("lp"), e.RowIndex).Value
        lp.CheckState = DataGridView13(("lp"), e.RowIndex).Value
        lmach.CheckState = DataGridView13(("lmach"), e.RowIndex).Value
        email.Text = DataGridView13(("email"), e.RowIndex).Value
        lng.Text = DataGridView13(("lng"), e.RowIndex).Value
        fcolor.Text = DataGridView13(("fcolor"), e.RowIndex).Value
        bColor.Text = DataGridView13(("bcolor"), e.RowIndex).Value
        prntn.CheckState = DataGridView13(("prntn"), e.RowIndex).Value
        rest_prnt.CheckState = DataGridView13(("rest_prnt"), e.RowIndex).Value
        update_test.CheckState = DataGridView13(("update_test"), e.RowIndex).Value
        lemail.CheckState = DataGridView13(("lemail"), e.RowIndex).Value
        lref.CheckState = DataGridView13(("lref"), e.RowIndex).Value
        ldelg.CheckState = DataGridView13(("ldelg"), e.RowIndex).Value
        ldis.CheckState = DataGridView13(("ldis"), e.RowIndex).Value
        luser.CheckState = DataGridView13(("luser"), e.RowIndex).Value
        pack_name.Text = DataGridView13(("pack_name"), e.RowIndex).Value
        pack_code.Text = DataGridView13(("pack_code"), e.RowIndex).Value
        backcolor1.Text = DataGridView13(("backcolor"), e.RowIndex).Value
        ltblg.Checked = DataGridView13(("ltblg"), e.RowIndex).Value
        lcult1.Checked = DataGridView13(("lcult"), e.RowIndex).Value
        ldref.Checked = DataGridView13(("ldref"), e.RowIndex).Value
        ldelgat.Checked = DataGridView13(("ldelgat"), e.RowIndex).Value
        lpromz.Checked = DataGridView13(("lpromz"), e.RowIndex).Value
        ltestp.Checked = DataGridView13(("ltestp"), e.RowIndex).Value
        lpnum.Checked = DataGridView13(("lpnum"), e.RowIndex).Value
        TextBox7.Text = DataGridView13(("shift"), e.RowIndex).Value
        final.Checked = DataGridView13(("final"), e.RowIndex).Value
    End Sub

    Private Sub GlassButton120_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton120.Click
        'dr.Close() : cmd.CommandText = "select MAx(code) from lcult "
        'dr = cmd.ExecuteReader
        'dr.Read()
        'If IsDBNull(dr(0)) = False Then
        '    cultcode.Text = 1 + dr(0)
        'Else
        '    cultcode.Text = 1
        'End If
        cmdLcult.Connection = CN
        cmdLcult.CommandType = CommandType.Text
        cmdLcult.CommandText = "select * FROM lcult"
        adLcult.SelectCommand = cmdLcult
        adLcult.Fill(DBS, "lcult")
        lcult = DBS.Tables("lcult")
        DBS.Tables("lcult").Clear()
        adLcult.Fill(DBS, "lcult")
        lcult = DBS.Tables("lcult")
        DataGridView14.DataSource = lcult
        cultname.Text = ""
        cultname.Focus()
    End Sub

    Private Sub GlassButton119_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton119.Click
        If IsNumeric(cultcode.Text) = False Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·ﬂÊœ") : Exit Sub
        If cultname.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
        If cultshr.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·«Œ ’«—") : Exit Sub
        dr.Close()
        cmd.CommandText = "select * from lcult where   shr='" & cultshr.Text & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Dim n As String
            n = MsgBox(" Â·  —Ìœ «· ⁄œÌ· ø", MsgBoxStyle.YesNo)
            If n = vbNo Then Exit Sub
            dr.Close()
            cmd.CommandText = "delete from lcult where    code='" & cultshr.Text & "'"
            cmd.ExecuteNonQuery()

        End If
        dr.Close()
        cmd.CommandText = "select * from lcult where   name='" & cultname.Text & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Dim n As String
            n = MsgBox(" Â·  —Ìœ «· ⁄œÌ· ø", MsgBoxStyle.YesNo)
            If n = vbNo Then Exit Sub
            dr.Close()
            cmd.CommandText = "delete from lcult where name='" & cultname.Text & "'"
            cmd.ExecuteNonQuery()

        End If
        dr.Close() : cmd.CommandText = "insert into lcult (name,shr)  values ('" & cultcode.Text & "','" & Trim(cultname.Text) & "','" & cultshr.Text & "')"
        cmd.ExecuteNonQuery()
        GlassButton120_Click(GlassButton120, e)
    End Sub

    Private Sub GlassButton118_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton118.Click
        If IsNumeric(cultcode.Text) = False Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·ﬂÊœ") : Exit Sub
        If cultname.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
        If cultshr.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·«Œ ’«—") : Exit Sub
        dr.Close()
        cmd.CommandText = "select * from lcult where   code='" & cultcode.Text & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Dim n As String
            n = MsgBox(" Â·  —Ìœ «·Õ–› ø", MsgBoxStyle.YesNo)
            If n = vbNo Then Exit Sub
            dr.Close()
            cmd.CommandText = "delete from lcult where    code='" & cultcode.Text & "'"
            cmd.ExecuteNonQuery()
            GlassButton120_Click(GlassButton120, e)
        End If

    End Sub

    Private Sub GlassButton98_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton98.Click

    End Sub

    Private Sub GlassButton80_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton80.Click
        cmdLreg.Connection = CN
        cmdLreg.CommandType = CommandType.Text
        cmdLreg.CommandText = "select * FROM lreg "
        adLreg.SelectCommand = cmdLreg
        adLreg.Fill(DBS, "lreg")
        lreg = DBS.Tables("lreg")
        DBS.Tables("lreg").Clear()
        adLreg.Fill(DBS, "lreg")
        lreg = DBS.Tables("lreg")
        DataGridView4.DataSource = lreg
        dr.Close()
        Dim oj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        oj.Load(Application.StartupPath & "\reg.rpt")
        oj.Database.Tables(0).SetDataSource(lreg)
        rp.CrystalReportViewer1.ReportSource = oj
        rp.Show() : rp.Focus()
    End Sub

    Private Sub GlassButton53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton53.Click
        Dim X As String = ""
        If CCODER.Checked = True Then X = " WHERE BOOK_PRICE_CODE='" & book_price_code.Text & "'"
        cmdcompany.Connection = CN
        cmdcompany.CommandType = CommandType.Text
        cmdcompany.CommandText = "select * from lcompany" & X
        adcompany.SelectCommand = cmdcompany
        adcompany.Fill(DBS, "company")
        company = DBS.Tables("company")
        DBS.Tables("company").Clear()
        adcompany.Fill(DBS, "company")
        company = DBS.Tables("company")
        DataGridView6.DataSource = company
        dr.Close()
        Dim oj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        oj.Load(Application.StartupPath & "\COMPANYS.rpt")
        oj.Database.Tables(0).SetDataSource(company)
        rp.CrystalReportViewer1.ReportSource = oj
        rp.Show() : rp.Focus()
    End Sub

    Private Sub GlassButton117_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton117.Click
        cmdLcult.Connection = CN
        cmdLcult.CommandType = CommandType.Text
        cmdLcult.CommandText = "select * FROM lcult "
        adLcult.SelectCommand = cmdLcult
        adLcult.Fill(DBS, "lcult")
        lcult = DBS.Tables("lcult")
        DBS.Tables("lcult").Clear()
        adLcult.Fill(DBS, "lcult")
        lcult = DBS.Tables("lcult")
        DataGridView4.DataSource = lcult
        dr.Close()
        Dim oj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        oj.Load(Application.StartupPath & "\med.rpt")
        oj.Database.Tables(0).SetDataSource(lcult)
        rp.CrystalReportViewer1.ReportSource = oj
        rp.Show() : rp.Focus()
    End Sub

    Private Sub GlassButton112_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton112.Click
        cmdb.DataAdapter = adLcult
        adLcult.Update(DBS, "lcult")
    End Sub

    Private Sub GlassButton116_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton116.Click
        If lcult.Rows.Count <= 0 Then MsgBox("·«  ÊÃœ »Ì«‰« ") : Exit Sub
        cultr = 0
        cultcode.Text = lcult.Rows(cultr).Item("code")
        cultname.Text = lcult.Rows(cultr).Item("name")
        cultshr.Text = lcult.Rows(cultr).Item("shr")

    End Sub

    Private Sub GlassButton115_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton115.Click
        If lcult.Rows.Count <= 0 Then MsgBox("·«  ÊÃœ »Ì«‰« ") : Exit Sub
        cultr = cultr - 1
        If cultr < 0 Then cultr = 0
        cultcode.Text = lcult.Rows(cultr).Item("code")
        cultname.Text = lcult.Rows(cultr).Item("name")
        cultshr.Text = lcult.Rows(cultr).Item("shr")
    End Sub

    Private Sub GlassButton114_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton114.Click
        If lcult.Rows.Count <= 0 Then MsgBox("·«  ÊÃœ »Ì«‰« ") : Exit Sub
        cultr = cultr + 1
        If cultr >= lcult.Rows.Count Then cultr = lcult.Rows.Count - 1
        cultcode.Text = lcult.Rows(cultr).Item("code")
        cultname.Text = lcult.Rows(cultr).Item("name")
        cultshr.Text = lcult.Rows(cultr).Item("shr")
    End Sub

    Private Sub GlassButton113_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton113.Click
        If lcult.Rows.Count <= 0 Then MsgBox("·«  ÊÃœ »Ì«‰« ") : Exit Sub
        cultr = lcult.Rows.Count - 1
        cultcode.Text = lcult.Rows(cultr).Item("code")
        cultname.Text = lcult.Rows(cultr).Item("name")
        cultshr.Text = lcult.Rows(cultr).Item("shr")
    End Sub

    Private Sub DataGridView14_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView14.CellContentClick

    End Sub

    Private Sub DataGridView14_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView14.CellMouseClick

        cultname.Text = DataGridView14(("name"), e.RowIndex).Value
        cultshr.Text = DataGridView14(("shr"), e.RowIndex).Value
        cmdb.DataAdapter = adLcult
        adLcult.Update(DBS, "lcult")
    End Sub

    Private Sub stest_name_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles stest_name.GotFocus
        flng("EN")
    End Sub

    Private Sub stest_name_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles stest_name.KeyDown
        If e.KeyCode = Keys.Enter Then
            GlassButton24_Click(GlassButton24, e)
        End If
    End Sub

    Private Sub stest_name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stest_name.TextChanged

    End Sub

    Private Sub Label22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label22.Click
        ''dr.Close()
        ''cmd.CommandText = "select * from ltest where test_name like '%(%'"
        ''dr = cmd.ExecuteReader
        ''While dr.Read
        ''    dr1.Close()
        ''    '' '' '' ''cmd1.CommandText = "INSERT INTO LNTEST ([TEST_CODE],[TEST_NAME],[REF],[TYPE],[AGEB],[AGEE],[NORB],[NORE],[UNIT]) VALUES ('" & dr("TEST_CODE") & "','" & dr("TEST_NAME") & "', '','male','0','120','0','0','')"
        ''    '' '' '' ''cmd1.ExecuteNonQuery()
        ''    '' '' '' ''cmd1.CommandText = "INSERT INTO LNTEST ([TEST_CODE],[TEST_NAME],[REF],[TYPE],[AGEB],[AGEE],[NORB],[NORE],[UNIT]) VALUES ('" & dr("TEST_CODE") & "','" & dr("TEST_NAME") & "', '','female','0','120','0','0','')"
        ''    '' '' '' ''cmd1.ExecuteNonQuery()
        ''    Dim sBig As String = dr("test_name")
        ''    Dim substring As String = sBig.Substring(sBig.IndexOf("(", 1) + 1, sBig.Length - sBig.IndexOf("(", 1) - 2)
        ''    dr1.Close()
        ''    cmd1.CommandText = "update ltest set short='" & substring & "' where test_name='" & dr("test_name") & "'"
        ''    cmd1.ExecuteNonQuery()
        ''    ' ''Dim i, w As Integer
        ''    ' ''i = 0
        ''    ' ''w = 0
        ''    ' ''While Not i + 1 >= sBig.Length
        ''    ' ''    If i > 1 Then w = sBig.IndexOf("(", i) - i Else w = sBig.IndexOf("<BR>", i)
        ''    ' ''    If w < 0 Then w = w * -1
        ''    ' ''    Dim substring As String = sBig.Substring(i, w)
        ''    ' ''    MsgBox(substring)
        ''    ' ''    NAGEB.Text = substring.Substring(substring.IndexOf("From") + 5, 4)
        ''    ' ''    ''NAGEE.Text = 120
        ''    ' ''    ''NNORB.Text = substring.Substring(substring.IndexOf(":-") + 4, 4)
        ''    ' ''    ''NNORE.Text = substring.Substring(substring.IndexOf(":-") + 11, 4)
        ''    ' ''    ''NUNIT.Text = substring.Substring(substring.IndexOf(":-") + 11, 5)
        ''    ' ''    ''NREF.Text = substring.Substring(substring.IndexOf(":-") + 4, 17)
        ''    ' ''    dr1.Close()
        ''    ' ''    ''Dim xx As String = ""
        ''    ' ''    ''xx = MsgBox(substring, MsgBoxStyle.YesNoCancel)
        ''    ' ''    ''If xx = vbYes Then
        ''    ' ''    ''    cmd1.CommandText = "INSERT INTO LNTEST ([TEST_CODE],[TEST_NAME],[REF],[TYPE],[AGEB],[AGEE],[NORB],[NORE],[UNIT]) VALUES ('" & dr("TEST_CODE") & "','" & dr("TEST_NAME") & "', '" & NREF.Text & "','male','" & NAGEB.Text & "','" & NAGEE.Text & "','" & NNORB.Text & "','" & NNORE.Text & "','" & NUNIT.Text & "')"
        ''    ' ''    ''    cmd1.ExecuteNonQuery()
        ''    ' ''    ''ElseIf xx = vbNo Then
        ''    ' ''    ''    cmd1.CommandText = "INSERT INTO LNTEST ([TEST_CODE],[TEST_NAME],[REF],[TYPE],[AGEB],[AGEE],[NORB],[NORE],[UNIT]) VALUES ('" & dr("TEST_CODE") & "','" & dr("TEST_NAME") & "', '" & NREF.Text & "','female','" & NAGEB.Text & "','" & NAGEE.Text & "','" & NNORB.Text & "','" & NNORE.Text & "','" & NUNIT.Text & "')"
        ''    ' ''    ''    cmd1.ExecuteNonQuery()
        ''    ' ''    ''Else
        ''    ' ''    ''    cmd1.CommandText = "INSERT INTO LNTEST ([TEST_CODE],[TEST_NAME],[REF],[TYPE],[AGEB],[AGEE],[NORB],[NORE],[UNIT]) VALUES ('" & dr("TEST_CODE") & "','" & dr("TEST_NAME") & "', '" & NREF.Text & "','male','" & NAGEB.Text & "','" & NAGEE.Text & "','" & NNORB.Text & "','" & NNORE.Text & "','" & NUNIT.Text & "')"
        ''    ' ''    ''    cmd1.ExecuteNonQuery()
        ''    ' ''    ''    cmd1.CommandText = "INSERT INTO LNTEST ([TEST_CODE],[TEST_NAME],[REF],[TYPE],[AGEB],[AGEE],[NORB],[NORE],[UNIT]) VALUES ('" & dr("TEST_CODE") & "','" & dr("TEST_NAME") & "', '" & NREF.Text & "','female','" & NAGEB.Text & "','" & NAGEE.Text & "','" & NNORB.Text & "','" & NNORE.Text & "','" & NUNIT.Text & "')"
        ''    ' ''    ''    cmd1.ExecuteNonQuery()
        ''    ' ''    ''End If

        ''    ' ''    i = w + i + 1
        ''    ' ''End While
        ''End While
        ''MsgBox("ok")
    End Sub

    Private Sub GlassButton121_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton121.Click
        ColorDialog1.ShowDialog()
        bColor.Text = ColorDialog1.Color.ToArgb
        colu(Me, Val(bColor.Text), Val(fcolor.Text))
    End Sub

    Private Sub GlassButton122_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton122.Click
        ColorDialog1.ShowDialog()
        fcolor.Text = ColorDialog1.Color.ToArgb
        colu(Me, bColor.Text, fcolor.Text)
    End Sub

    Private Sub GlassButton123_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton123.Click
        cmdb.DataAdapter = adasm
        adasm.Update(DBS, "asm")
        dr.Close()
        cmd.CommandText = "select * from iface where flg=1 "
        dr = cmd.ExecuteReader
        dr1.Close()
        While dr.Read
            cmd1.CommandText = "update iface set hide='" & dr("hide") & "' where mn=" & dr("mn")
            cmd1.ExecuteNonQuery()
        End While
        'accmd1.CommandText = "update iface set hid='1' "
        'accmd1.ExecuteNonQuery()

        MsgBox(" „  ⁄„·Ì… «· ⁄œÌ·")
    End Sub

    Private Sub GlassButton103_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cmdb.DataAdapter = adusers
        adusers.Update(DBS, "users")
    End Sub

    Private Sub GlassButton124_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton124.Click
        Dim M As Integer
        Dim YY As String = ""
        M = 0

        a.Rows.Clear()
        Dim ii As Integer = 0
        Dim ss As Integer = 0
        Dim i As Integer = 0
        Dim aa As Int16 = 0
        Dim o As Integer
        While Not i = LTEST.Rows.Count
            ss = 0
            ii = 0
            aa = 0
            o = 0


            While Not ii = book.Rows.Count
                If book.Rows(ii).Item("srh") = 1 Then
                    ss = 0
                    dr.Close()
                    cmd.CommandText = "delete from ltest where test_code is NULL"
                    cmd.ExecuteNonQuery()
                    dr.Close() : cmd.CommandText = "sELECT  tot from ltest_price WHERE test_code='" & LTEST.Rows(i).Item("test_code") & "'  and book_price_code='" & book.Rows(ii).Item("code") & "' "
                    dr = cmd.ExecuteReader
                    dr.Read()
                    If dr.HasRows = True Then If IsDBNull(dr(0)) = False Then ss = ss + dr(0)
                    '===================================================================
mk:
                    dr.Close()
                    If aa = 0 Then
                        RC = a.NewRow
                        RC("h1") = book.Rows(ii).Item("name")
                        RC("hn1") = ss
                        RC("hn2") = 0
                        RC("hn3") = 0
                        RC("hn4") = 0
                        RC("hn5") = 0
                        RC("hn6") = 0
                        RC("hn7") = 0
                        RC("hn8") = 0
                        RC("hn9") = 0
                        RC("name") = LTEST.Rows(i).Item("test_name")
                        RC("code") = LTEST.Rows(i).Item("test_code")
                        a.Rows.Add(RC)
                        o = o + ss
                        aa += 1
                    Else
                        RC = a.Rows(a.Rows.Count - 1)
                        RC.BeginEdit()
                        Dim z As Integer = aa + 1
                        RC("h" & z) = book.Rows(ii).Item("name")
                        RC("hn" & z) = ss
                        RC.EndEdit()
                        o = ss + o
                        aa += 1
                    End If

                End If
                ii += 1
            End While
mv:
            ss = 0
            i += 1
        End While

        dr.Close()
        Dim oj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        ii = 0
        i = 0
        While Not ii = book.Rows.Count
            If book.Rows(ii).Item("srh") = 1 Then
                i += 1
            End If
            ii += 1
        End While

        If i <= 4 Then
            oj.Load(Application.StartupPath & "\stoc.rpt")
        Else
            oj.Load(Application.StartupPath & "\stoc.rpt")
        End If
        'MsgBox(a.Rows.Count)
        DataGridView7.DataSource = a
        oj.SetDataSource(a)
        oj.SetParameterValue("d1", "")
        oj.SetParameterValue("d2", "")
        rp.CrystalReportViewer1.ReportSource = oj
        rp.CrystalReportViewer1.Refresh()
        rp.Show()
        Exit Sub

    End Sub

    Private Sub cname_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cname.GotFocus
        flng("AR")

    End Sub

    Private Sub cname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cname.KeyDown
        If e.KeyCode = Keys.Enter Then
            dr.Close()
            cmd.CommandText = "select * from lcompany where name='" & cname.Text & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then
                ccode.Text = DR("code")
                cname.Text = DR("name")
                book_price_code.Text = DR("book_price_code")
                book_price_name.Text = DR("book_price_name")
                ph.Text = DR("ph")
                ch.Text = DR("ch")
                pp.Text = DR("pp")
                cp.Text = DR("cp")
                ps.Text = DR("ps")
                cs.Text = DR("cs")
                pw.Text = DR("pw")
                cw.Text = DR("cw")
                cdiss.Text = DR("diss")
                cadd.Text = DR("add1")
                cemail.Text = DR("email")
                ctel.Text = DR("tel")
                CheckBox18.CheckState = DR("DOC")
                labin.CheckState = nulls(dr("labin"))
                inc.CheckState = DR("inc")
                crd.CheckState = DR("crd")
                canc.CheckState = DR("canc")
                lab.CheckState = DR("lab")
                COMS.CheckState = DR("COMS")
                name1.Text = nulls(DR("name1"))
                name2.Text = nulls(DR("name2"))
                name3.Text = nulls(DR("name3"))
                tel1.Text = nulls(DR("tel1"))
                tel2.Text = nulls(DR("tel2"))
                tel3.Text = nulls(DR("tel3"))
                email1.Text = nulls(DR("email1"))
                email2.Text = nulls(DR("email2"))
                email3.Text = nulls(DR("email3"))
                cond.Text = nulls(DR("cond"))
                tests.Text = nulls(DR("test"))
                web.Text = nulls(DR("web"))
                RESULT.Text = nulls(DR("RESULT"))
                addres.Text = nulls(DR("address"))
                price_name.Text = nulls(DR("price_name"))
                oprice_name.Text = nulls(DR("oprice_name"))
                price_diss.Text = nulls(DR("price_diss"))
                oprice_diss.Text = nulls(DR("oprice_diss"))
                tah_form.Text = nulls(DR("tah_form"))
                tah_exp.Text = nulls(DR("tah_exp"))
                tah_date.Text = nulls(DR("tah_date"))
                emp_cash.Text = nulls(DR("emp_cash"))
                fam_cash.Text = nulls(DR("fam_cash"))
                hc.Text = nulls(dr("hc"))
                out_date.Text = nulls(dr("out_date"))
            End If
        End If
    End Sub

    Private Sub cname_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cname.KeyUp
        'cmdcompany.Connection = CN
        'cmdcompany.CommandType = CommandType.Text
        'cmdcompany.CommandText = "select * from lcompany WHERE NAME LIKE '%" & cname.Text & "%'"
        'adcompany.SelectCommand = cmdcompany
        'adcompany.Fill(DBS, "company")
        'company = DBS.Tables("company")
        'DBS.Tables("company").Clear()
        'adcompany.Fill(DBS, "company")
        'company = DBS.Tables("company")
        'DataGridView6.DataSource = company
        cmdcompany.Connection = CN
        cmdcompany.CommandType = CommandType.Text
        cmdcompany.CommandText = "select * from lcompany where name like '%" & cname.Text & "%'"
        adcompany.SelectCommand = cmdcompany
        adcompany.Fill(DBS, "company")
        company = DBS.Tables("company")
        DBS.Tables("company").Clear()
        adcompany.Fill(DBS, "company")
        company = DBS.Tables("company")
        DataGridView6.DataSource = company
    End Sub

    Private Sub cname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cname.TextChanged

    End Sub

    Private Sub cemail_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cemail.GotFocus
        flng("EN")
    End Sub

    Private Sub cemail_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cemail.KeyDown
        If e.KeyCode = Keys.Enter Then
            ctel.Focus()
        End If
    End Sub

    Private Sub cemail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cemail.TextChanged

    End Sub

    Private Sub ctel_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ctel.KeyDown
        If e.KeyCode = Keys.Enter Then
            GlassButton55_Click(GlassButton55, e)
        End If

    End Sub

    Private Sub ctel_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ctel.TextChanged

    End Sub

    Private Sub gr_name_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles gr_name.GotFocus
        flng("EN")
    End Sub

    Private Sub gr_name_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gr_name.KeyDown
        Dim n As String
        If e.KeyCode = Keys.Enter Then
            n = ""
            n = MsgBox(" Â·  —Ìœ «·Õ›Ÿ ø", MsgBoxStyle.YesNo)
            If n = vbNo Then Exit Sub
            dr.Close() : cmd.CommandText = "select MAx(code) from lgr "
            dr = cmd.ExecuteReader
            dr.Read()
            If IsDBNull(dr(0)) = False Then
                gr_code.Text = 1 + dr(0)
            Else
                gr_code.Text = 1
            End If

            If gr_name.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
            dr.Close()
            cmd.CommandText = "select * from lgr where   code='" & gr_code.Text & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                n = ""
                n = MsgBox(" Â·  —Ìœ «· ⁄œÌ· ø", MsgBoxStyle.YesNo)
                If n = vbNo Then Exit Sub
                dr.Close()
                cmd.CommandText = "delete from lgr where    code='" & gr_code.Text & "'"
                cmd.ExecuteNonQuery()

            End If

            dr.Close() : cmd.CommandText = "insert into lgr (code,name)  values ('" & gr_code.Text & "','" & gr_name.Text & "')"
            cmd.ExecuteNonQuery()

            grf()
        End If
        If e.KeyCode = Keys.Delete Then
            n = MsgBox(" Â·  —Ìœ «·Õ–› ø", MsgBoxStyle.YesNo)
            If IsNumeric(gr_code.Text) = False Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·ﬂÊœ") : Exit Sub
            If gr_name.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
            dr.Close()
            cmd.CommandText = "select * from lgr where   code='" & gr_code.Text & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                dr.Close()
                cmd.CommandText = "delete from lgr where    code='" & gr_code.Text & "'"
                cmd.ExecuteNonQuery()

            End If
            grf()
        End If
    End Sub

    Private Sub gr_name_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gr_name.SelectedIndexChanged
        If gr_name.Focused = False Then Exit Sub
        If gr_name.Text = "" Then Exit Sub
        If EX = 1 Then Exit Sub
        FRC = gr.Select("NAME='" & gr_name.Text & "'")
        If FRC.Length <= 0 Then
            gr_name.Text = ""
            gr_code.Text = ""
            Exit Sub
        Else
            RC = FRC(0)
            gr_code.Text = RC("code")
            If Cgr_name.Checked = False Then Exit Sub
            cmdLTEST.Connection = CN
            cmdLTEST.CommandType = CommandType.Text
            cmdLTEST.CommandText = "select * FROM LTEST where gr_name ='" & gr_name.Text & "'"
            adLTEST.SelectCommand = cmdLTEST
            adLTEST.Fill(DBS, "LTEST")
            LTEST = DBS.Tables("LTEST")
            DBS.Tables("LTEST").Clear()
            adLTEST.Fill(DBS, "LTEST")
            LTEST = DBS.Tables("LTEST")
            DataGridView2.DataSource = LTEST
        End If
    End Sub

    Private Sub asmdb_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles asmdb.CellContentClick

    End Sub

    Private Sub asmdb_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles asmdb.CellEndEdit
        cmdb.DataAdapter = adasm
        adasm.Update(DBS, "asm")
    End Sub

    Private Sub KID_TYPE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KID_TYPE.SelectedIndexChanged
        If CKID_TYPE.Checked = False Then Exit Sub

        If KID_TYPE.Focused = False Then Exit Sub
        cmdLTEST.CommandText = "select * FROM LTEST where KID_TYPE ='" & KID_TYPE.Text & "'"
        adLTEST.SelectCommand = cmdLTEST
        adLTEST.Fill(DBS, "LTEST")
        LTEST = DBS.Tables("LTEST")
        DBS.Tables("LTEST").Clear()
        adLTEST.Fill(DBS, "LTEST")
        LTEST = DBS.Tables("LTEST")
        DataGridView2.DataSource = LTEST
    End Sub

    Private Sub GlassButton89_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton89.Click
        cmdLdoc.Connection = CN
        cmdLdoc.CommandType = CommandType.Text
        cmdLdoc.CommandText = "select * FROM ldoc "
        adLdoc.SelectCommand = cmdLdoc
        adLdoc.Fill(DBS, "ldoc")
        ldoc = DBS.Tables("ldoc")
        DBS.Tables("ldoc").Clear()
        adLdoc.Fill(DBS, "ldoc")
        ldoc = DBS.Tables("ldoc")
        DataGridView4.DataSource = ldoc
        dr.Close()
        Dim oj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        oj.Load(Application.StartupPath & "\delgat.rpt")
        oj.Database.Tables(0).SetDataSource(ldoc)
        rp.CrystalReportViewer1.ReportSource = oj
        rp.Show() : rp.Focus()
    End Sub

    Private Sub ltestres_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ltestres.GotFocus
        flng("EN")
    End Sub

    Private Sub ComboBox3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ltestres.KeyDown
        Dim n As String
        If e.KeyCode = Keys.Enter Then
            n = ""
            n = MsgBox(" Â·  —Ìœ «·Õ›Ÿ ø", MsgBoxStyle.YesNo)
            If n = vbNo Then Exit Sub
            If ltestres.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
            dr.Close()
            cmd.CommandText = "select * from lres where   name='" & ltestres.Text & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                n = ""
                n = MsgBox(" Â·  —Ìœ «· ⁄œÌ· ø", MsgBoxStyle.YesNo)
                If n = vbNo Then Exit Sub
                dr.Close()
                cmd.CommandText = "delete from lres where    name='" & ltestres.Text & "'"
                cmd.ExecuteNonQuery()

            End If

            dr.Close() : cmd.CommandText = "insert into lres (name)  values ('" & ltestres.Text & "')"
            cmd.ExecuteNonQuery()

            cmdresc.Connection = CN
            cmdresc.CommandType = CommandType.Text
            cmdresc.CommandText = "select * FROM Lres "
            adresc.SelectCommand = cmdresc
            adresc.Fill(DBS, "resc")
            resc = DBS.Tables("resc")
            DBS.Tables("resc").Clear()
            adresc.Fill(DBS, "resc")
            resc = DBS.Tables("resc")
            ltestres.DataSource = resc
            ltestres.DisplayMember = "NAME"
        End If
        If e.KeyCode = Keys.Delete Then
            n = MsgBox(" Â·  —Ìœ «·Õ–› ø", MsgBoxStyle.YesNo)
            If ltestres.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
            dr.Close()
            cmd.CommandText = "select * from lres where   name='" & ltestres.Text & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                dr.Close()
                cmd.CommandText = "delete from lres where    name='" & ltestres.Text & "'"
                cmd.ExecuteNonQuery()

            End If
            cmdresc.Connection = CN
            cmdresc.CommandType = CommandType.Text
            cmdresc.CommandText = "select * FROM Lres "
            adresc.SelectCommand = cmdresc
            adresc.Fill(DBS, "resc")
            resc = DBS.Tables("resc")
            DBS.Tables("resc").Clear()
            adresc.Fill(DBS, "resc")
            resc = DBS.Tables("resc")
            ltestres.DataSource = resc
            ltestres.DisplayMember = "NAME"
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ltestres.SelectedIndexChanged

    End Sub

    Private Sub GlassButton126_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton126.Click

        Dim n As String

        If ltestres.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
        If ttest_name.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
        If ttest_code.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
        dr.Close()

        If ctname.Checked = True Then
            cmd.CommandText = "select * from ltestres where   res='" & ltestres.Text & "' and test_name='" & ttest_name.Text & "' "
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                MsgBox("Â–… «·‰ ÌÃ… „”Ã·… „‰ ﬁ»· ·· Õ·Ì·")
                Exit Sub
            End If
            n = ""
            n = MsgBox(" Â·  —Ìœ «·Õ›Ÿ ø", MsgBoxStyle.YesNo)
            If n = vbNo Then Exit Sub
            dr.Close() : cmd.CommandText = "insert into ltestres (test_name,test_code,res)  values ('" & ttest_name.Text & "','" & ttest_code.Text & "','" & ltestres.Text & "')"
            cmd.ExecuteNonQuery()
        Else
            n = MsgBox(" Â·  —Ìœ «·Õ›Ÿ  ﬂ· «· Õ«·Ì· «·„Œ «—… ø", MsgBoxStyle.YesNo)
            If n = vbNo Then Exit Sub
            Dim m As Integer = 0
            While Not m = LTEST.Rows.Count
                RC = LTEST.Rows(m)
                cmd.CommandText = "delete from ltestres where   res='" & ltestres.Text & "' and test_name='" & RC("test_name") & "' "
                cmd.ExecuteNonQuery()

                dr.Close() : cmd.CommandText = "insert into ltestres (test_name,test_code,res)  values ('" & RC("test_name") & "','" & RC("test_code") & "','" & ltestres.Text & "')"
                cmd.ExecuteNonQuery()
                m = m + 1
            End While
        End If


    End Sub

    Private Sub GlassButton128_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton128.Click
        Dim n As String
        n = ""
        If ltestres.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
        If ttest_name.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
        If ttest_code.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub

        If ctname.Checked = True Then
            dr.Close()
            cmd.CommandText = "select * from ltestres where   res='" & ltestres.Text & "' and test_name='" & ttest_name.Text & "' "
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                n = MsgBox(" Â·  —Ìœ «·Õ–› ø", MsgBoxStyle.YesNo)
                If n = vbNo Then Exit Sub
                cmd.CommandText = "delete  from ltestres where   res='" & ltestres.Text & "' and test_name='" & ttest_name.Text & "' "
                cmd.ExecuteNonQuery()
            End If
        Else
            Dim m As Integer = 0
            While Not m = LTEST.Rows.Count
                RC = LTEST.Rows(m)
                cmd.CommandText = "delete from ltestres where   res='" & ltestres.Text & "' and test_name='" & RC("test_name") & "' "
                cmd.ExecuteNonQuery()
                m = m + 1
            End While
        End If
    End Sub

    Private Sub GlassButton129_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton129.Click
        Dim n As String

        If ComboBox3.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
        If stest_name.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
        If stest_code.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
        dr.Close()

        If cssr.Checked = True Then
            cmd.CommandText = "select * from ltestres where   res='" & ComboBox3.Text & "' and test_name='" & stest_name.Text & "' "
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                MsgBox("Â–… «·‰ ÌÃ… „”Ã·… „‰ ﬁ»· ·· Õ·Ì·")
                Exit Sub
            End If
            n = ""
            n = MsgBox(" Â·  —Ìœ «·Õ›Ÿ ø", MsgBoxStyle.YesNo)
            If n = vbNo Then Exit Sub
            dr.Close() : cmd.CommandText = "insert into ltestres (test_name,test_code,res)  values ('" & stest_name.Text & "','" & stest_code.Text & "','" & ComboBox3.Text & "')"
            cmd.ExecuteNonQuery()
        Else
            n = MsgBox(" Â·  —Ìœ «·Õ›Ÿ  ﬂ· «· Õ«·Ì· «·„Œ «—… ø", MsgBoxStyle.YesNo)
            If n = vbNo Then Exit Sub
            Dim m As Integer = 0
            While Not m = LSUBTEST.Rows.Count
                RC = LSUBTEST.Rows(m)
                cmd.CommandText = "delete from ltestres where   res='" & ComboBox3.Text & "' and test_name='" & RC("test_name") & "' "
                cmd.ExecuteNonQuery()
                dr.Close() : cmd.CommandText = "insert into ltestres (test_name,test_code,res)  values ('" & RC("test_name") & "','" & RC("test_code") & "','" & ComboBox3.Text & "')"
                cmd.ExecuteNonQuery()
                m = m + 1
            End While
        End If
    End Sub

    Private Sub GlassButton127_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton127.Click
        Dim n As String
        n = ""
        If ComboBox3.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
        If stest_name.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
        If stest_code.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub

        If cssr.Checked = True Then
            dr.Close()
            cmd.CommandText = "select * from ltestres where   res='" & ComboBox3.Text & "' and test_name='" & stest_name.Text & "' "
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                n = MsgBox(" Â·  —Ìœ «·Õ–› ø", MsgBoxStyle.YesNo)
                If n = vbNo Then Exit Sub
                dr.Close()
                cmd.CommandText = "delete from ltestres where   res='" & ComboBox3.Text & "' and test_name='" & stest_name.Text & "' "
                cmd.ExecuteNonQuery()
            End If
        Else
            Dim m As Integer = 0
            While Not m = LSUBTEST.Rows.Count
                RC = LSUBTEST.Rows(m)
                cmd.CommandText = "delete from ltestres where   res='" & ComboBox3.Text & "' and test_name='" & RC("test_name") & "' "
                cmd.ExecuteNonQuery()
                m = m + 1
            End While
        End If
    End Sub

    Private Sub ComboBox3_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBox3.KeyDown
        Dim n As String
        If e.KeyCode = Keys.Enter Then
            n = ""
            n = MsgBox(" Â·  —Ìœ «·Õ›Ÿ ø", MsgBoxStyle.YesNo)
            If n = vbNo Then Exit Sub
            If ComboBox3.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
            dr.Close()
            cmd.CommandText = "select * from lres where   name='" & ComboBox3.Text & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                n = ""
                n = MsgBox(" Â·  —Ìœ «· ⁄œÌ· ø", MsgBoxStyle.YesNo)
                If n = vbNo Then Exit Sub
                dr.Close()
                cmd.CommandText = "delete from lres where    name='" & ComboBox3.Text & "'"
                cmd.ExecuteNonQuery()

            End If

            dr.Close() : cmd.CommandText = "insert into lres (name)  values ('" & ComboBox3.Text & "')"
            cmd.ExecuteNonQuery()

            cmdresc.Connection = CN
            cmdresc.CommandType = CommandType.Text
            cmdresc.CommandText = "select * FROM Lres "
            adresc.SelectCommand = cmdresc
            adresc.Fill(DBS, "resc")
            resc = DBS.Tables("resc")
            DBS.Tables("resc").Clear()
            adresc.Fill(DBS, "resc")
            resc = DBS.Tables("resc")
            ComboBox3.DataSource = resc
            ComboBox3.DisplayMember = "NAME"
            ltestres.DataSource = resc
            ltestres.DisplayMember = "NAME"
        End If
        If e.KeyCode = Keys.Delete Then
            n = MsgBox(" Â·  —Ìœ «·Õ–› ø", MsgBoxStyle.YesNo)
            If ComboBox3.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
            dr.Close()
            cmd.CommandText = "select * from lres where   name='" & ComboBox3.Text & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                dr.Close()
                cmd.CommandText = "delete from lres where    name='" & ComboBox3.Text & "'"
                cmd.ExecuteNonQuery()

            End If
            cmdresc.Connection = CN
            cmdresc.CommandType = CommandType.Text
            cmdresc.CommandText = "select * FROM Lres "
            adresc.SelectCommand = cmdresc
            adresc.Fill(DBS, "resc")
            resc = DBS.Tables("resc")
            DBS.Tables("resc").Clear()
            adresc.Fill(DBS, "resc")
            resc = DBS.Tables("resc")
            ComboBox3.DataSource = resc
            ComboBox3.DisplayMember = "NAME"
            ltestres.DataSource = resc
            ltestres.DisplayMember = "NAME"
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged

    End Sub

    Private Sub GlassButton125_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton125.Click
        Dim S As Integer = InputBox("ENTER PASWORD")
        If S <> 5011545 Then Exit Sub
        'If CheckBox6.Checked = True Then
        '    Dim yy As String
        '    yy = "where pcode>0"
        '    Dim x As String = ""
        '    x = MsgBox("Â·  —Ìœ Õ–› »Ì«‰«  «·Õ—ﬂ… ø", MsgBoxStyle.YesNo)
        '    If x = vbNo Then Exit Sub
        '    If CheckBox3.Checked = True Then
        '        yy = yy & " and esl_date between '" & ChangeFormat(d1.Value) & "' and '" & ChangeFormat(d2.Value) & "' "
        '    End If
        '    If CheckBox1.Checked = True Then
        '        yy = yy & " and usr ='" & suser.Text & "'"
        '    End If
        '    If CheckBox2.Checked = True Then
        '        yy = yy & " and shift ='" & sshift.Text & "'"
        '    End If

        '    If CheckBox7.Checked = True Then
        '        yy = yy & " and esl_no >='" & TextBox2.Text & "' and  esl_no <='" & TextBox1.Text & "' "
        '    End If
        '    dr.Close()
        '    cmd.CommandText = "select * from lbill " & yy
        '    dr = cmd.ExecuteReader
        '    dr1.Close()
        '    While dr.Read = True
        dr1.Close()
        cmd1.CommandText = "delete from lbill "
        cmd1.ExecuteNonQuery()
        cmd1.CommandText = "delete from lbill_test "
        cmd1.ExecuteNonQuery()
        cmd1.CommandText = "delete from lbill_testsub "
        cmd1.ExecuteNonQuery()
        cmd1.CommandText = "delete from LBILL_CULT_DET "
        cmd1.ExecuteNonQuery()
        cmd1.CommandText = "delete from LBILL_CULT "
        cmd1.ExecuteNonQuery()
        cmd1.CommandText = "delete from LBILL_esl "
        cmd1.ExecuteNonQuery()
        cmd1.CommandText = "delete from lbillimage "
        cmd1.ExecuteNonQuery()
        cmd1.CommandText = "delete from LPATIEN "
        cmd1.ExecuteNonQuery()
        '    End While
        'End If

    End Sub

    Private Sub Ntest_NAME_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Ntest_NAME.GotFocus
        flng("EN")
    End Sub

    Private Sub Ntest_NAME_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Ntest_NAME.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Ntest_NAME.Text = "" Then Exit Sub
            dr.Close()
            cmd.CommandText = "select * from ltest where test_name='" & Ntest_NAME.Text & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then
                Ntest_CODE.Text = dr("test_CODE")
                Ntest_NAME.Text = dr("test_name")
                GlassButton36_Click(GlassButton36, e)

            End If

        End If

    End Sub

    Private Sub Ntest_NAME_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ntest_NAME.TextChanged

    End Sub

    Private Sub ptest_name_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ptest_name.GotFocus
        flng("EN")
    End Sub

    Private Sub ptest_name_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ptest_name.KeyDown
        On Error Resume Next
        If e.KeyCode = Keys.Enter Then
            If ptest_name.Text = "" Then Exit Sub
            dr.Close()
            cmd.CommandText = "select * from ltest where test_name='" & ptest_name.Text & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then
                ptest_code.Text = dr("test_CODE")
                ptest_name.Text = dr("test_name")
                par.Text = dr("ar")
                ptot.Focus()
            End If

            dr.Close()
            cmd.CommandText = "select * from  ltest_price where book_price_name='" & pbook_price_name.Text & "' and test_name='" & ptest_name.Text & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then COMP.Text = dr("tot")

        ElseIf e.KeyCode = Keys.F3 Then
            dr1.Close()
            cmd1.CommandText = "select TEST_NAME from lTEST where  TEST_NAME LIKE '%" & ptest_name.Text & "%'"
            dr1 = cmd1.ExecuteReader
            If dr1.HasRows Then
                Dim xxaa As String = ""
                xxaa = xxaa & Environment.NewLine
                While dr1.Read
                    xxaa = xxaa & Environment.NewLine & dr1(0)
                End While
                MsgBox(xxaa, MsgBoxStyle.Information)
            End If
        End If
    End Sub

    Private Sub ptest_name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ptest_name.TextChanged

    End Sub

    Private Sub test_name11_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles test_name11.KeyDown
        Dim n As String
        Dim ss As Integer = 0
        Dim nn As Double = 0
        If e.KeyCode = Keys.Enter Then
            If cname.Text = "" Or ccode.Text = "" Then MsgBox("«·—Ã«¡ «Œ «— «·‘—ﬂ…") : Exit Sub
            If test_name11.Text = "" Then MsgBox("«·—Ã«¡ «Œ «— «· Õ·Ì·") : Exit Sub

            n = ""
            n = MsgBox(" Â·  —Ìœ «·Õ›Ÿ ø", MsgBoxStyle.YesNo)
            If n = vbNo Then Exit Sub
            dr.Close() : cmd.CommandText = "select * from ltest where test_name='" & test_name11.Text & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then
                ss = dr("test_code")
            End If

            dr.Close()
            cmd.CommandText = "select * from ldiss where   test_code='" & ss & "' and company_code='" & ccode.Text & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                n = ""
                n = MsgBox(" Â·  —Ìœ «· ⁄œÌ· ø", MsgBoxStyle.YesNo)
                If n = vbNo Then Exit Sub
                dr.Close()
                cmd.CommandText = "delete from ldiss where   test_code='" & ss & "' and company_code='" & ccode.Text & "'"
                cmd.ExecuteNonQuery()

            End If
            nn = InputBox("«·—Ã«¡ ﬂ «»… «·Œ’„")

            dr.Close() : cmd.CommandText = "insert into ldiss (test_code,test_name,company_code,company_name,price)  values ('" & ss & "','" & test_name11.Text & "','" & ccode.Text & "','" & cname.Text & "','" & nn & "')"
            cmd.ExecuteNonQuery()


        End If
        If e.KeyCode = Keys.Delete Then

            If cname.Text = "" Or ccode.Text = "" Then MsgBox("«·—Ã«¡ «Œ «— «·‘—ﬂ…") : Exit Sub
            If test_name11.Text = "" Then MsgBox("«·—Ã«¡ «Œ «— «· Õ·Ì·") : Exit Sub

            n = ""
            n = MsgBox(" Â·  —Ìœ «·Õ–› ø", MsgBoxStyle.YesNo)
            If n = vbNo Then Exit Sub
            dr.Close() : cmd.CommandText = "select * from ltest where test_name='" & test_name11.Text & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then
                ss = dr("test_code")
            End If

            dr.Close()
            cmd.CommandText = "select * from ldiss where   test_code='" & ss & "' and company_code='" & ccode.Text & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                n = ""
                dr.Close()
                cmd.CommandText = "delete from ldiss where   test_code='" & ss & "' and company_code='" & ccode.Text & "'"
                cmd.ExecuteNonQuery()

            End If

        End If
    End Sub

    Private Sub test_name11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles test_name11.TextChanged

    End Sub

    Private Sub GlassButton130_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton130.Click
        cmda1.Connection = CN
        cmda1.CommandType = CommandType.Text
        cmda1.CommandText = "select * from ldiss"
        ada1.SelectCommand = cmda1
        ada1.Fill(DBS, "a1")
        a1 = DBS.Tables("a1")
        DBS.Tables("a1").Clear()
        ada1.Fill(DBS, "a1")
        a1 = DBS.Tables("a1")

        dr.Close()
        Dim oj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        oj.Load(Application.StartupPath & "\ldis.rpt")
        oj.Database.Tables(0).SetDataSource(a1)
        rp.CrystalReportViewer1.ReportSource = oj
        rp.Show() : rp.Focus()
    End Sub

    Private Sub GlassButton40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton40.Click

    End Sub

    Private Sub GlassButton132_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton132.Click
        Dim n As String

        n = ""
        n = MsgBox(" Â·  —Ìœ «·Õ›Ÿ ø", MsgBoxStyle.YesNo)
        If n = vbNo Then Exit Sub
        dr.Close() : cmd.CommandText = "select MAx(code) from lbook_price "
        dr = cmd.ExecuteReader
        dr.Read()
        If IsDBNull(dr(0)) = False Then
            book_price_code.Text = 1 + dr(0)
        Else
            book_price_code.Text = 1
        End If

        If book_price_name.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
        dr.Close()
        cmd.CommandText = "select * from lbook_price where   code='" & book_price_code.Text & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            n = ""
            n = MsgBox(" Â·  —Ìœ «· ⁄œÌ· ø", MsgBoxStyle.YesNo)
            If n = vbNo Then Exit Sub
            dr.Close()
            cmd.CommandText = "delete from lbook_price where    code='" & book_price_code.Text & "'"
            cmd.ExecuteNonQuery()

        End If

        dr.Close() : cmd.CommandText = "insert into lbook_price (code,name,EMAIL,tell)  values ('" & book_price_code.Text & "','" & book_price_name.Text & "','" & EML.Text & "','" & btell.Text & "')"
        cmd.ExecuteNonQuery()

        bookf()

    End Sub

    Private Sub GlassButton131_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton131.Click
        Dim N As String
        N = MsgBox(" Â·  —Ìœ «·Õ–› ø", MsgBoxStyle.YesNo)
        If IsNumeric(book_price_code.Text) = False Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·ﬂÊœ") : Exit Sub
        If book_price_name.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
        dr.Close()
        cmd.CommandText = "select * from lbook_price where   code='" & book_price_code.Text & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            dr.Close()
            cmd.CommandText = "delete from lbook_price where    code='" & book_price_code.Text & "'"
            cmd.ExecuteNonQuery()

        End If
        bookf()
    End Sub

    Private Sub GlassButton134_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton134.Click
        Dim n As String
        Dim ss As Integer = 0
        Dim nn As Double = 0

        If cname.Text = "" Or ccode.Text = "" Then MsgBox("«·—Ã«¡ «Œ «— «·‘—ﬂ…") : Exit Sub
        If test_name11.Text = "" Then MsgBox("«·—Ã«¡ «Œ «— «· Õ·Ì·") : Exit Sub

        n = ""
        n = MsgBox(" Â·  —Ìœ «·Õ›Ÿ ø", MsgBoxStyle.YesNo)
        If n = vbNo Then Exit Sub
        dr.Close() : cmd.CommandText = "select * from ltest where test_name='" & test_name11.Text & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            ss = dr("test_code")
        End If

        dr.Close()
        cmd.CommandText = "select * from ldiss where   test_code='" & ss & "' and company_code='" & ccode.Text & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            n = ""
            n = MsgBox(" Â·  —Ìœ «· ⁄œÌ· ø", MsgBoxStyle.YesNo)
            If n = vbNo Then Exit Sub
            dr.Close()
            cmd.CommandText = "delete from ldiss where   test_code='" & ss & "' and company_code='" & ccode.Text & "'"
            cmd.ExecuteNonQuery()

        End If
        nn = InputBox("«·—Ã«¡ ﬂ «»… «·Œ’„")

        dr.Close() : cmd.CommandText = "insert into ldiss (test_code,test_name,company_code,company_name,price)  values ('" & ss & "','" & test_name11.Text & "','" & ccode.Text & "','" & cname.Text & "','" & nn & "')"
        cmd.ExecuteNonQuery()



    End Sub

    Private Sub GlassButton133_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton133.Click
        If cname.Text = "" Or ccode.Text = "" Then MsgBox("«·—Ã«¡ «Œ «— «·‘—ﬂ…") : Exit Sub
        If test_name11.Text = "" Then MsgBox("«·—Ã«¡ «Œ «— «· Õ·Ì·") : Exit Sub
        Dim n As String
        Dim ss As Integer
        n = ""
        n = MsgBox(" Â·  —Ìœ «·Õ–› ø", MsgBoxStyle.YesNo)
        If n = vbNo Then Exit Sub
        dr.Close() : cmd.CommandText = "select * from ltest where test_name='" & test_name11.Text & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            ss = dr("test_code")
        End If

        dr.Close()
        cmd.CommandText = "select * from ldiss where   test_code='" & ss & "' and company_code='" & ccode.Text & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            n = ""
            dr.Close()
            cmd.CommandText = "delete from ldiss where   test_code='" & ss & "' and company_code='" & ccode.Text & "'"
            cmd.ExecuteNonQuery()

        End If
    End Sub

    Private Sub btell_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btell.TextChanged

    End Sub

    Private Sub ask1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ask1.SelectedIndexChanged

    End Sub

    Private Sub GlassButton136_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton136.Click
        Dim n As String

        If ask1.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
        If ttest_name.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
        If ttest_code.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
        dr.Close()

        If ctname.Checked = True Then
            cmd.CommandText = "select * from lask where   ask='" & ask1.Text & "' and test_name='" & ttest_name.Text & "' "
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                MsgBox("Â–… «·‰ ÌÃ… „”Ã·… „‰ ﬁ»· ·· Õ·Ì·")
                Exit Sub
            End If
            n = ""
            n = MsgBox(" Â·  —Ìœ «·Õ›Ÿ ø", MsgBoxStyle.YesNo)
            If n = vbNo Then Exit Sub
            dr.Close() : cmd.CommandText = "insert into lask (test_name,test_code,ask)  values ('" & ttest_name.Text & "','" & ttest_code.Text & "','" & ask1.Text & "')"
            cmd.ExecuteNonQuery()
        Else
            n = MsgBox(" Â·  —Ìœ «·Õ›Ÿ  ﬂ· «· Õ«·Ì· «·„Œ «—… ø", MsgBoxStyle.YesNo)
            If n = vbNo Then Exit Sub
            Dim m As Integer = 0
            While Not m = LTEST.Rows.Count
                RC = LTEST.Rows(m)
                cmd.CommandText = "delete from lask where   ask='" & ask1.Text & "' and test_name='" & RC("test_name") & "' "
                cmd.ExecuteNonQuery()
                dr.Close() : cmd.CommandText = "insert into lask (test_name,test_code,ask)  values ('" & RC("test_name") & "','" & RC("test_code") & "','" & ask1.Text & "')"
                cmd.ExecuteNonQuery()
                m = m + 1
            End While
        End If

    End Sub

    Private Sub GlassButton135_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton135.Click
        Dim n As String
        n = ""
        If ask1.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
        If ttest_name.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
        If ttest_code.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub

        If ctname.Checked = True Then
            dr.Close()
            cmd.CommandText = "select * from lask where   ask='" & ask1.Text & "' and test_name='" & ttest_name.Text & "' "
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                n = MsgBox(" Â·  —Ìœ «·Õ–› ø", MsgBoxStyle.YesNo)
                If n = vbNo Then Exit Sub
                cmd.CommandText = "delete  from lask where   ask='" & ask1.Text & "' and test_name='" & ttest_name.Text & "' "
                cmd.ExecuteNonQuery()
            End If
        Else
            Dim m As Integer = 0
            While Not m = LTEST.Rows.Count
                RC = LTEST.Rows(m)
                cmd.CommandText = "delete from lask where   ask='" & ask1.Text & "' and test_name='" & RC("test_name") & "' "
                cmd.ExecuteNonQuery()
                m = m + 1
            End While
        End If

    End Sub

    Private Sub dname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dname.KeyDown
        If e.KeyCode = Keys.Enter Then
            tell.Focus()
        End If
    End Sub

    Private Sub dname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dname.KeyPress

    End Sub

    Private Sub dname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dname.TextChanged

    End Sub

    Private Sub tell_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tell.KeyDown
        If e.KeyCode = Keys.Enter Then
            demail.Focus()
        End If
    End Sub

    Private Sub tell_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tell.TextChanged

    End Sub

    Private Sub demail_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles demail.KeyDown
        If e.KeyCode = Keys.Enter Then
            adress.Focus()
        End If
    End Sub

    Private Sub demail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles demail.TextChanged

    End Sub

    Private Sub tell1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles adress.KeyDown

        If e.KeyCode = Keys.Enter Then
            GlassButton91_Click(GlassButton91, e)
        End If
    End Sub

    Private Sub tell1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles adress.TextChanged

    End Sub

    Private Sub ptot_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ptot.KeyDown
        If e.KeyCode = Keys.Enter Then
            GlassButton65_Click(GlassButton65, e)
        End If
    End Sub

    Private Sub ptot_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ptot.TextChanged

    End Sub

    Private Sub GlassButton137_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton137.Click
        Dim N As String = ""


        If PRNT.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub

        N = MsgBox(" Â·  —Ìœ «· ⁄œÌ· ø", MsgBoxStyle.YesNo)
        If N = vbNo Then Exit Sub
        dr.Close()
        cmd.CommandText = "delete from SETTING where    NAME='PRNT ALL'"
        cmd.ExecuteNonQuery()

        dr.Close() : cmd.CommandText = "insert into SETTING (name,OPT)  values ('PRNT ALL','" & PRNT.Text & "')"
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub GlassButton138_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton138.Click
        Dim N As String = ""


        If PRNT.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub

        N = MsgBox(" Â·  —Ìœ «· ⁄œÌ· ø", MsgBoxStyle.YesNo)
        If N = vbNo Then Exit Sub
        dr.Close()
        cmd.CommandText = "delete from SETTING where    NAME='PRNT EMAIL'"
        cmd.ExecuteNonQuery()

        dr.Close() : cmd.CommandText = "insert into SETTING (name,OPT)  values ('PRNT EMAIL','" & PRNT.Text & "')"
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub PRNT_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PRNT.SelectedIndexChanged
        dr.Close()
        cmd.CommandText = "SELECT * FROM LPRNT WHERE NAME='" & PRNT.Text & "'"
        dr = cmd.ExecuteReader
        While dr.Read
            IMAGE_SHOW.PictureBox1.ImageLocation = Application.StartupPath & "\IMAGE\" & dr("PATH")
            IMAGE_SHOW.Show()
            IMAGE_SHOW.Focus()
        End While
    End Sub

    Private Sub RCV_N_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RCV_N.SelectedIndexChanged
        dr.Close()
        cmd.CommandText = "select * from lrcv  where name='" & RCV_N.Text & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        RCV_TOT.Text = dr("tot")
    End Sub

    Private Sub GlassButton139_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton139.Click
        dr.Close()
        cmd.CommandText = "UPDATE  lrcv SET TOT='" & RCV_TOT.Text & "' where name='" & RCV_N.Text & "'"
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub GlassButton140_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton140.Click
        dr.Close()
        cmd.CommandText = "UPDATE  SETTING SET OPT='" & TextBox6.Text & "' where name='SH'"
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub DataGridView9_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView9.CellContentClick

    End Sub

    Private Sub DataGridView8_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView8.CellContentClick

    End Sub

    Private Sub DataGridView8_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView8.CellMouseClick
        cmdb.DataAdapter = adLgroup_price
        adLgroup_price.Update(DBS, "Lgroup_price")
        apd = 1
    End Sub

    Private Sub DataGridView8_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView8.CellMouseDoubleClick
        cmdb.DataAdapter = adLgroup_price
        adLgroup_price.Update(DBS, "Lgroup_price")
        apd = 1
    End Sub

    Private Sub GlassButton141_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton141.Click
        Dim NN As Integer
        NN = InputBox("«œŒ· ﬂÊœ «·»—‰«„Ã", , "1")
        ACdr.Close()
        acdr1.Close()
        ACcmd.CommandText = "SELECT * FROM IFACE2 WHERE PRG=" & NN
        ACdr = ACcmd.ExecuteReader
        While ACdr.Read
            accmd1.CommandText = "DELETE * FROM IFACE WHERE NAME='" & ACdr("NAME") & "'"
            accmd1.ExecuteNonQuery()
            accmd1.CommandText = "INSERT INTO IFACE SELECT * FROM IFACE2 WHERE NAME='" & ACdr("NAME") & "' AND PRG=" & NN
            accmd1.ExecuteNonQuery()

        End While
    End Sub

    Private Sub GlassButton142_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton142.Click
        Dim NN As String
        Dim SS As String
        NN = InputBox("ENTER EMAIL ")
        SS = InputBox("ENTER PASSWORD")
        dr.Close()
        cmd.CommandText = "UPDATE BRANCH SET EMAILB='" & NN & "',PASSB='" & SS & "'"
        cmd.ExecuteNonQuery()

    End Sub

    Private Sub TabPage14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage14.Click

    End Sub

    Private Sub GlassButton143_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton143.Click
        ColorDialog1.ShowDialog()
        backcolor1.Text = ColorDialog1.Color.ToArgb

    End Sub

    Private Sub back_name_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles pack_name.KeyDown
        Dim nNSSS As String
        If e.KeyCode = Keys.Enter Then
            nNSSS = ""
            dr.Close() : cmd.CommandText = "select MAx(pack_code) from lpack "
            dr = cmd.ExecuteReader
            dr.Read()
            If IsDBNull(dr(0)) = False Then
                pack_code.Text = 1 + dr(0)
            Else
                pack_code.Text = 1
            End If

            If pack_name.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
            dr.Close()
            cmd.CommandText = "select * from lpack where   pack_name='" & pack_name.Text & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                nNSSS = ""
                nNSSS = MsgBox("Â·  —Ìœ «· ⁄œÌ· ø", MsgBoxStyle.YesNo)
                If nNSSS = vbNo Then Exit Sub
                dr.Close()
                cmd.CommandText = "delete from lpack where    pack_name='" & pack_name.Text & "'"
                cmd.ExecuteNonQuery()
                LLOG(" ⁄œÌ·", 0, " ⁄œÌ· „Ã„Ê⁄… " & pack_name.Text, 1, BRAN.Text)
            Else
                LLOG("Õ›Ÿ ÃœÌœ", 0, "Õ›Ÿ  „Ã„Ê⁄… " & pack_name.Text, 1, BRAN.Text)

            End If

            dr.Close() : cmd.CommandText = "insert into lpack (pack_code,pack_name)  values ('" & pack_code.Text & "','" & pack_name.Text & "')"
            cmd.ExecuteNonQuery()
            cmdpack.Connection = CN
            cmdpack.CommandType = CommandType.Text
            cmdpack.CommandText = "select * from lpack"
            adpack.SelectCommand = cmdpack
            adpack.Fill(DBS, "pack")
            pack = DBS.Tables("pack")
            DBS.Tables("pack").Clear()
            adpack.Fill(DBS, "pack")
            pack = DBS.Tables("pack")
            pack_name.DataSource = pack
            pack_name.DisplayMember = "pack_NAME"

        End If
        If e.KeyCode = Keys.Delete Then
            nNSSS = MsgBox("Â·  —Ìœ «·Õ–› ø", MsgBoxStyle.YesNo)
            If nNSSS = vbNo Then Exit Sub
            If IsNumeric(pack_code.Text) = False Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·ﬂÊœ") : Exit Sub
            If pack_name.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
            dr.Close()
            cmd.CommandText = "select * from lpack where   pack_name='" & pack_name.Text & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                dr.Close()
                cmd.CommandText = "delete from lpack where    pack_name='" & pack_name.Text & "'"
                cmd.ExecuteNonQuery()
            End If
            cmdpack.Connection = CN
            cmdpack.CommandType = CommandType.Text
            cmdpack.CommandText = "select * from lpack"
            adpack.SelectCommand = cmdpack
            adpack.Fill(DBS, "pack")
            pack = DBS.Tables("pack")
            DBS.Tables("pack").Clear()
            adpack.Fill(DBS, "pack")
            pack = DBS.Tables("pack")
            pack_name.DataSource = pack
            pack_name.DisplayMember = "pack_NAME"
            dr.Close()
        End If

    End Sub

    Private Sub back_name_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pack_name.SelectedIndexChanged
        If pack_name.Focused = False Then Exit Sub
        If pack_name.Text = "" Then Exit Sub
        If EX = 1 Then Exit Sub
        FRC = pack.Select("PACK_NAME='" & pack_name.Text & "'")
        If FRC.Length <= 0 Then
            pack_name.Text = ""
            pack_code.Text = ""
            Exit Sub
        Else
            RC = FRC(0)
            pack_code.Text = RC("pack_code")

            dr.Close()
            CHEK(Me)
            cmd.CommandText = "SELECT * FROM LPERM WHERE PACK_CODE='" & pack_code.Text & "'"
            dr = cmd.ExecuteReader
            While dr.Read

                lenter.CheckState = dr("lenter")
                lsave.CheckState = dr("lsave")
                ledit.CheckState = dr("ledit")
                ldel.CheckState = dr("ldel")
                leslrp.CheckState = dr("leslrp")
                lprnt.CheckState = dr("lprnt")
                pah.CheckState = dr("lcome")
                center.CheckState = dr("center")
                csave.CheckState = dr("csave")
                cedit.CheckState = dr("cedit")
                cdel.CheckState = dr("cdel")
                crp.CheckState = dr("crp")
                cbalance.CheckState = dr("cbalance")
                eenter.CheckState = dr("eenter")
                esave.CheckState = dr("esave")
                eedit.CheckState = dr("eedit")
                edel.CheckState = dr("edel")
                erp.CheckState = dr("erp")
                esal.CheckState = dr("esal")
                esalsave.CheckState = dr("esalsave")
                lbld1.CheckState = dr("lbld")
                ebld.CheckState = dr("ebld")
                cbld.CheckState = dr("cbld")
                admin.CheckState = dr("admin")
                lres.CheckState = dr("lres")
                lmtp.CheckState = dr("lmtp")
                ldoc1.CheckState = dr("doc")
                rcv.CheckState = dr("rcv")
                pa.CheckState = dr("pa")
                tv.CheckState = dr("tv")
                tc.CheckState = dr("tc")
                dc.CheckState = dr("dc")
                ls.CheckState = dr("pah")
                lp.CheckState = dr("ls")
                lmach.CheckState = dr("lp")
                lmach.CheckState = dr("lmach")
                prntn.CheckState = dr("prntn")
                rest_prnt.CheckState = dr("rest_prnt")
                update_test.CheckState = dr("update_test")
                lemail.CheckState = dr("lemail")
                lref.CheckState = dr("lref")
                ldelg.CheckState = dr("ldelg")
                ldis.CheckState = dr("ldis")
                luser.CheckState = dr("luser")
                pack_name.Text = dr("pack_name")
                pack_code.Text = dr("pack_code")
                backcolor1.Text = dr("backcolor")
                ltblg.Checked = dr("ltblg")
                lcult1.Checked = dr("lcult")
                ldref.Checked = dr("ldref")
                ldelgat.Checked = dr("ldelgat")
                lpromz.Checked = dr("lpromz")
                ltestp.Checked = dr("ltestp")
                lpnum.Checked = dr("lpnum")
            End While
        End If
    End Sub

    Private Sub GlassButton144_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton144.Click
        If pack_code.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
        If pack_name.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
        If mng = 0 Then
            MsgBox("·Ì”  ·œÌﬂ «·’·«ÕÌ…")
            LLOG("Õ›Ÿ ÃœÌœ", 0, "Õ›Ÿ „Ã„Ê⁄… " & pack_name.Text, 1, BRAN.Text)
            Exit Sub
        End If
        dr.Close()
        cmd.CommandText = "select * from LPERM where   PACK_CODE='" & pack_code.Text & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Dim n As String
            n = MsgBox(" Â·  —Ìœ «· ⁄œÌ· ø", MsgBoxStyle.YesNo)
            If n = vbNo Then Exit Sub
            dr.Close()
            cmd.CommandText = "delete from LPERM where    PACK_CODE='" & pack_code.Text & "'"
            cmd.ExecuteNonQuery()
        End If
        dr.Close()
        cmd.CommandText = "INSERT INTO LPERM ([LENTER],[LSAVE],[LEDIT],[LDEL],[LESLRP],[LPRNT],[Lcome],[center],[csave],[cedit],[cdel],[crp],[cbalance],[ctotal],[eenter],[esave],[eedit],[edel],[erp],[esal],[esalsave],[lbld],[ebld],[cbld],admin,lres,[rcv] ,[pa],[tv],[tc],[dc],[pah],[ls],[lp],[lmach],doc,lmtp,prntn,rest_prnt,update_test,lemail,lref,ldelg,ldis,luser,pack_name,pack_code,ltblg,[lcult],[ldref],[ldelgat],[lpromz],[ltestp],[lpnum]) VALUES  ('" & Val(lenter.CheckState) & "','" & Val(lsave.CheckState) & "','" & Val(ledit.CheckState) & "','" & Val(ldel.CheckState) & "','" & Val(leslrp.CheckState) & "','" & Val(lprnt.CheckState) & "','" & Val(pah.CheckState) & "','" & Val(center.CheckState) & "','" & Val(csave.CheckState) & "','" & Val(cedit.CheckState) & "','" & Val(cdel.CheckState) & "','" & Val(crp.CheckState) & "','" & Val(cbalance.CheckState) & "','" & Val(ctotal.CheckState) & "','" & Val(eenter.CheckState) & "','" & Val(esave.CheckState) & "','" & Val(eedit.CheckState) & "','" & Val(edel.CheckState) & "','" & Val(erp.CheckState) & "','" & Val(esal.CheckState) & "','" & Val(esalsave.CheckState) & "','" & Val(lbld1.CheckState) & "','" & Val(ebld.CheckState) & "','" & Val(cbld.CheckState) & "','" & Val(admin.CheckState) & "','" & Val(lres.CheckState) & "','" & Val(rcv.CheckState) & "','" & Val(pa.CheckState) & "','" & Val(tv.CheckState) & "','" & Val(tc.CheckState) & "','" & Val(dc.CheckState) & "','" & Val(pah.CheckState) & "','" & Val(ls.CheckState) & "','" & Val(lp.CheckState) & "','" & Val(lmach.CheckState) & "','" & Val(lmtp.CheckState) & "','" & Val(ldoc1.CheckState) & "','" & Val(prntn.CheckState) & "','" & Val(rest_prnt.CheckState) & "','" & Val(update_test.CheckState) & "','" & Val(lemail.CheckState) & "','" & Val(lref.CheckState) & "','" & Val(ldelg.CheckState) & "','" & Val(ldis.CheckState) & "','" & Val(luser.CheckState) & "','" & pack_name.Text & "','" & pack_code.Text & "','" & Val(ltblg.Checked) & "','" & Val(lcult1.CheckState) & "','" & Val(ldref.CheckState) & "','" & Val(ldelgat.CheckState) & "','" & Val(lpromz.CheckState) & "','" & Val(ltestp.CheckState) & "','" & Val(lpnum.CheckState) & "') "
        cmd.ExecuteNonQuery()
        MsgBox("SAVED")

    End Sub

    Private Sub dataso_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataso.CellContentClick

    End Sub

    Private Sub dataso_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dataso.CellMouseClick
        cmdb.DataAdapter = adsotr
        adsotr.Update(DBS, "sotr")
    End Sub

    Private Sub GlassButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton6.Click

    End Sub

    Private Sub GlassButton1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton1.Click
        Dim M As String = ""
        M = InputBox("ENTER DEVICE NAME")

        ACdr.Close()
        ACcmd.CommandText = "UPDATE SRV SET SNAME ='" & M & "'"
        ACcmd.ExecuteNonQuery()
        dr.Close()
        cmd.CommandText = "DELETE  FROM DEVICE WHERE NAME='" & M & "'"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "INSERT INTO DEVICE  (NAME) VALUES ('" & M & "')"
        cmd.ExecuteNonQuery()

    End Sub

    Private Sub GlassButton9_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton9.Click
        Dim M As String = ""
        M = InputBox("ENTER TEMP PATH")
        ACdr.Close()
        ACcmd.CommandText = "SELECT * FROM SRV "
        ACdr = ACcmd.ExecuteReader
        ACdr.Read()
        If ACdr.HasRows = True Then
            dr.Close()
            cmd.CommandText = "UPDATE  DEVICE SET TEMP='" & M & "' WHERE NAME='" & ACdr("SNAME") & "'"
            cmd.ExecuteNonQuery()
        End If
    End Sub

    Private Sub GlassButton17_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton17.Click
        Dim S As Integer = InputBox("ENTER PASWORD")
        If S <> 205 Then Exit Sub
        dr1.Close()
        cmd1.CommandText = "truncate table  LLOG "
        cmd1.ExecuteNonQuery()
        cmd1.CommandText = "truncate table  lbill "
        cmd1.ExecuteNonQuery()
        cmd1.CommandText = "truncate table  lbill_test "
        cmd1.ExecuteNonQuery()
        cmd1.CommandText = "truncate table  lbill_testsub "
        cmd1.ExecuteNonQuery()
        cmd1.CommandText = "truncate table  LBILL_CULT_DET "
        cmd1.ExecuteNonQuery()
        cmd1.CommandText = "truncate table  LBILL_CULT "
        cmd1.ExecuteNonQuery()
        'cmd1.CommandText = "DELETE FROM  lcompany WHERE CODE<>1 "
        'cmd1.ExecuteNonQuery()
        'cmd1.CommandText = "DELETE FROM  lbook_price WHERE CODE<>1 "
        'cmd1.ExecuteNonQuery()
        cmd1.CommandText = "truncate table  ldiss "
        cmd1.ExecuteNonQuery()
        'cmd1.CommandText = "truncate table  lgroup "
        'cmd1.ExecuteNonQuery()
        'cmd1.CommandText = "truncate table  lgroup_price "
        'cmd1.ExecuteNonQuery()
        'cmd1.CommandText = "truncate table  lgroup_test "
        'cmd1.ExecuteNonQuery()
        cmd1.CommandText = "truncate table  LPATIEN "
        cmd1.ExecuteNonQuery()
        'cmd1.CommandText = "truncate table  lgroup_test "
        'cmd1.ExecuteNonQuery()
        'cmd1.CommandText = "truncate table  lgroup_test "
        'cmd1.ExecuteNonQuery()
        dr.Close()
        ACdr.Close()
        ACcmd.CommandText = "update srv set esl='0' "
        ACcmd.ExecuteNonQuery()
        cmd.CommandText = " update Branch set NAME='" & branch_name.Text & "', BRAN='" & BRAN.Text & "',STOC='0',EMP='0',esl='0',PA='0',CASH='0' "
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub GlassButton28_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton28.Click
        dr1.Close()
        cmd1.CommandText = "update iface set hide='0' "

        cmd1.ExecuteNonQuery()
    End Sub


    Private Sub GlassButton37_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton37.Click
        dr.Close()
        cmd.CommandText = " update Branch set EMAIL='" & AEMAIL.Text & "',SUBRES='" & Val(SUBRES.CheckState) & "',ESLN='" & Val(ESLN.CheckState) & "',ONLINE='" & Val(ONLINE.CheckState) & "',com='" & Val(com.CheckState) & "',FESLT='" & Val(FESLT.CheckState) & "',pay='" & Val(pay.CheckState) & "',stoc='" & Val(stoc.CheckState) & "',emp='" & Val(emp.CheckState) & "',lab='" & Val(lab.CheckState) & "',ref='" & REF.Text & "',msga='" & Val(msga.CheckState) & "',companal='" & Val(companal.CheckState) & "',resta='" & Val(resta.CheckState) & "',pv='" & pv.Text & "',panal='" & panal.Text & "',printn='" & Val(printn.CheckState) & "',print1='" & Val(print1.CheckState) & "',network='" & Val(network.CheckState) & "',pas='" & Val(pas.CheckState) & "',test_name='" & Val(test_name.CheckState) & "',test_ar='" & Val(test_ar.CheckState) & "',pack_name='" & Val(pack_name1.CheckState) & "',profile='" & Val(profile.CheckState) & "',labtolab='" & Val(labtolab.CheckState) & "',DOC='" & Val(FDOC.CheckState) & "',RCV='" & Val(FRCV.CheckState) & "',PAP='" & Val(PAP.CheckState) & "',DELT='" & Val(DELT.CheckState) & "',FINAL='" & Val(FFINAL.CheckState) & "',SLIST='" & Val(slist.CheckState) & "',SBILL='" & Val(sbill.CheckState) & "',sscan='" & Val(sscan.CheckState) & "',SBAR='" & Val(sbar.CheckState) & "',DIS='" & DIS.Text & "',BRAN='" & BRAN.Text & "' where code='" & branch_code.Text & "'"
        cmd.ExecuteNonQuery()
        MsgBox("it's saved")
    End Sub

    Private Sub GlassButton48_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton48.Click
        If IsNumeric(Ntest_CODE.Text) = False Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·ﬂÊœ") : Exit Sub
        If Ntest_NAME.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
        dr.Close()
        cmd.CommandText = "delete from LNTEST where test_code='" & Ntest_CODE.Text & "'"
        cmd.ExecuteNonQuery()
        dr.Close() : cmd.CommandText = "INSERT INTO LNTEST([test_code],[test_name],[ref],[type] ,[ageb],[agee],[NORB],[NORE],[unit],year,SRES) VALUES ('" & Ntest_CODE.Text & "','" & Ntest_NAME.Text & "','" & NREF.Text & "','MALE','0','120','" & NNORB.Text & "','" & NNORE.Text & "','" & nunit.Text & "','YEAR','" & Val(sres.CheckState) & "')"
        cmd.ExecuteNonQuery()
        dr.Close() : cmd.CommandText = "INSERT INTO LNTEST([test_code],[test_name],[ref],[type] ,[ageb],[agee],[NORB],[NORE],[unit],year,SRES) VALUES ('" & Ntest_CODE.Text & "','" & Ntest_NAME.Text & "','" & NREF.Text & "','FEMALE','0','120','" & NNORB.Text & "','" & NNORE.Text & "','" & nunit.Text & "','YEAR','" & Val(sres.CheckState) & "')"
        cmd.ExecuteNonQuery()
        dr.Close() : cmd.CommandText = "INSERT INTO LNTEST([test_code],[test_name],[ref],[type] ,[ageb],[agee],[NORB],[NORE],[unit],year,SRES) VALUES ('" & Ntest_CODE.Text & "','" & Ntest_NAME.Text & "','" & NREF.Text & "','MALE','0','120','" & NNORB.Text & "','" & NNORE.Text & "','" & nunit.Text & "','MONTH','" & Val(sres.CheckState) & "')"
        cmd.ExecuteNonQuery()
        dr.Close() : cmd.CommandText = "INSERT INTO LNTEST([test_code],[test_name],[ref],[type] ,[ageb],[agee],[NORB],[NORE],[unit],year,SRES) VALUES ('" & Ntest_CODE.Text & "','" & Ntest_NAME.Text & "','" & NREF.Text & "','FEMALE','0','120','" & NNORB.Text & "','" & NNORE.Text & "','" & nunit.Text & "','MONTH','" & Val(sres.CheckState) & "')"
        cmd.ExecuteNonQuery()
        dr.Close() : cmd.CommandText = "INSERT INTO LNTEST([test_code],[test_name],[ref],[type] ,[ageb],[agee],[NORB],[NORE],[unit],year,SRES) VALUES ('" & Ntest_CODE.Text & "','" & Ntest_NAME.Text & "','" & NREF.Text & "','MALE','0','120','" & NNORB.Text & "','" & NNORE.Text & "','" & nunit.Text & "','DAY','" & Val(sres.CheckState) & "')"
        cmd.ExecuteNonQuery()
        dr.Close() : cmd.CommandText = "INSERT INTO LNTEST([test_code],[test_name],[ref],[type] ,[ageb],[agee],[NORB],[NORE],[unit],year,SRES) VALUES ('" & Ntest_CODE.Text & "','" & Ntest_NAME.Text & "','" & NREF.Text & "','FEMALE','0','120','" & NNORB.Text & "','" & NNORE.Text & "','" & nunit.Text & "','DAY','" & Val(sres.CheckState) & "')"
        cmd.ExecuteNonQuery()
        GlassButton36_Click(GlassButton36, e)

    End Sub

    Private Sub GlassButton58_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton58.Click
        dr.Close()

    End Sub

    Private Sub Ntest_CODE_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ntest_CODE.TextChanged

    End Sub

    Private Sub GlassButton145_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton145.Click
        'If IsNumeric(Ntest_CODE.Text) = False Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·ﬂÊœ") : Exit Sub
        'If Ntest_NAME.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
        dr.Close()
        cmd.CommandText = "delete from LNSTEST where test_code='" & nstest_code.Text & "'"
        cmd.ExecuteNonQuery()

        dr.Close() : cmd.CommandText = "INSERT INTO LNSTEST([Mtest_code],[Mtest_name],[test_code],[test_name],[ref],[type] ,[ageb],[agee],[NORB],[NORE],[unit],year) VALUES ('" & nMtest_CODE.Text & "','" & nmtest_name.Text & "','" & nstest_code.Text & "','" & nstest_name.Text & "','" & nsref.Text & "','MALE','0','120','" & nsnorb.Text & "','" & nsnore.Text & "','" & nsunit.Text & "','YEAR')"
        cmd.ExecuteNonQuery()
        dr.Close() : cmd.CommandText = "INSERT INTO LNSTEST([Mtest_code],[Mtest_name],[test_code],[test_name],[ref],[type] ,[ageb],[agee],[NORB],[NORE],[unit],year) VALUES ('" & nMtest_CODE.Text & "','" & nmtest_name.Text & "','" & nstest_code.Text & "','" & nstest_name.Text & "','" & nsref.Text & "','FEMALE','0','120','" & nsnorb.Text & "','" & nsnore.Text & "','" & nsunit.Text & "','YEAR')"
        cmd.ExecuteNonQuery()
        dr.Close() : cmd.CommandText = "INSERT INTO LNSTEST([Mtest_code],[Mtest_name],[test_code],[test_name],[ref],[type] ,[ageb],[agee],[NORB],[NORE],[unit],year) VALUES ('" & nMtest_CODE.Text & "','" & nmtest_name.Text & "','" & nstest_code.Text & "','" & nstest_name.Text & "','" & nsref.Text & "','MALE','0','120','" & nsnorb.Text & "','" & nsnore.Text & "','" & nsunit.Text & "','MONTH')"
        cmd.ExecuteNonQuery()
        dr.Close() : cmd.CommandText = "INSERT INTO LNSTEST([Mtest_code],[Mtest_name],[test_code],[test_name],[ref],[type] ,[ageb],[agee],[NORB],[NORE],[unit],year) VALUES ('" & nMtest_CODE.Text & "','" & nmtest_name.Text & "','" & nstest_code.Text & "','" & nstest_name.Text & "','" & nsref.Text & "','FEMALE','0','120','" & nsnorb.Text & "','" & nsnore.Text & "','" & nsunit.Text & "','MONTH')"
        cmd.ExecuteNonQuery()
        dr.Close() : cmd.CommandText = "INSERT INTO LNSTEST([Mtest_code],[Mtest_name],[test_code],[test_name],[ref],[type] ,[ageb],[agee],[NORB],[NORE],[unit],year) VALUES ('" & nMtest_CODE.Text & "','" & nmtest_name.Text & "','" & nstest_code.Text & "','" & nstest_name.Text & "','" & nsref.Text & "','MALE','0','120','" & nsnorb.Text & "','" & nsnore.Text & "','" & nsunit.Text & "','DAY')"
        cmd.ExecuteNonQuery()
        dr.Close() : cmd.CommandText = "INSERT INTO LNSTEST([Mtest_code],[Mtest_name],[test_code],[test_name],[ref],[type] ,[ageb],[agee],[NORB],[NORE],[unit],year) VALUES ('" & nMtest_CODE.Text & "','" & nmtest_name.Text & "','" & nstest_code.Text & "','" & nstest_name.Text & "','" & nsref.Text & "','FEMALE','0','120','" & nsnorb.Text & "','" & nsnore.Text & "','" & nsunit.Text & "','DAY')"
        cmd.ExecuteNonQuery()

        GlassButton45_Click(GlassButton45, e)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        dr.Close()
        If ComboBox1.Text = "" Then Exit Sub
        cmd.CommandText = "select * from lshift where name='" & ComboBox1.Text & "'"
        dr = cmd.ExecuteReader
        While dr.Read
            TextBox7.Text = dr("code")
        End While
    End Sub


    Private Sub branch_name_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles branch_name.SelectedIndexChanged

        dr.Close()
        cmd.CommandText = "SELECT * FROM BRANCH WHERE NAME='" & branch_name.Text & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        FESLT.CheckState = dr("FESLT")
        pay.CheckState = dr("pay")
        clinic.CheckState = dr("clinic")
        com.CheckState = dr("com")
        stoc.CheckState = dr("stoc")
        emp.CheckState = dr("emp")
        lab.CheckState = dr("lab")
        REF.Text = dr("ref")
        msga.CheckState = dr("msga")
        companal.CheckState = dr("companal")
        resta.CheckState = dr("resta")
        pv.Text = dr("pv")
        panal.Text = dr("panal")
        printn.CheckState = dr("printn")
        print1.CheckState = dr("print1")
        network.CheckState = dr("network")
        pas.CheckState = dr("pas")
        test_name.CheckState = dr("test_name")
        test_ar.CheckState = dr("test_ar")
        pack_name1.CheckState = dr("pack_namE")
        profile.CheckState = dr("profile")
        branch_code.Text = dr("code")
        labtolab.CheckState = dr("labtolab")
        FDOC.CheckState = dr("DOC")
        FRCV.CheckState = dr("rcv")
        PAP.CheckState = dr("PAP")
        DELT.CheckState = dr("DELT")
        FFINAL.CheckState = dr("final")
        slist.CheckState = dr("slist")
        sbill.CheckState = dr("sbill")
        sscan.CheckState = dr("sscan")
        sbar.CheckState = dr("SBAR")
        'ADDRESS.Text = nulls(dr("ADDRESS"))
        DIS.Text = dr("DIS")
        BRAN.Text = nulls(dr("BRAN"))
        FESLT.Text = dr("FESLT")
        ONLINE.CheckState = dr("ONLINE")
        AEMAIL.Text = dr("EMAIL")
        SUBRES.CheckState = dr("SUBRES")
        ESLN.CheckState = dr("ESLN")
    End Sub



    Private Sub GlassButton146_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton146.Click
        'dr.Close()
        'cmd.CommandText = "update lTEST_PRICE set lTEST_PRICE.test_CODE=lTEST.test_CODE fROM lTEST_PRICE INNER JOIN LTEST ON lTEST_PRICE.test_NAME=LTEST.test_NAME "
        'cmd.ExecuteNonQuery()
        Dim n As Integer = 0
        While Not n = test_price.Rows.Count
            RC = test_price.Rows(n)
            dr.Close()
            cmd.CommandText = "select * from ltest_price where book_price_code='" & cbook_price_code.Text & "' and test_code='" & RC("test_code") & "'"
            dr = cmd.ExecuteReader
            If dr.HasRows = False Then
                dr.Close()
                cmd.CommandText = "insert into ltest_price (test_code,test_name,tot,ar,p1,p2,p3,p4,book_price_code,book_price_name) values   ('" & RC("test_code") & "','" & RC("test_name") & "','" & Math.Round(RC("tot") * per.Text * 0.01, 0) & "','" & RC("ar") & "','" & RC("p1") & "','" & RC("p2") & "','" & RC("p3") & "','" & RC("p4") & "','" & cbook_price_code.Text & "','" & cbook_price_name.Text & "')"
                cmd.ExecuteNonQuery()
            End If

            n += 1
        End While
    End Sub

    Private Sub GlassButton147_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton147.Click
        dr.Close()
        cmd.CommandText = "UPDATE LCOMPANY SET BRAN='" & RRVV & "'"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "UPDATE ltest_price SET BRAN='" & RRVV & "'"
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub GlassButton148_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton148.Click
        dr.Close()
        ACdr.Close()
        ACcmd.CommandText = "select * from srv "
        ACdr = ACcmd.ExecuteReader
        ACdr.Read()
        Dim FileNames = TwainLib.ScanImages(ccode.Text, True, ACdr("scan"))
        PictureBox1.ImageLocation = FileNames(0)
        Dim oer As System.IO.FileStream
        Dim rer As IO.StreamReader
        oer = New IO.FileStream(FileNames(0), IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.Read)
        rer = New IO.StreamReader(oer)
        Dim FileByteArrayr(oer.Length - 1) As Byte
        oer.Read(FileByteArrayr, 0, oer.Length)
        dr.Close()
        cmd.CommandText = "select max(code) from lcompany_image WHERE  company_code='" & Val(ccode.Text) & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        IMAGE_CODE.Text = nulls(dr(0)) + 1
        dr.Close()
        cmd.CommandText = "update lcompany set bran='" & RRVV & "' where company_code='" & Val(ccode.Text) & "'"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "insert into lcompany_image (CODE,company_name,company_code,bran ) values ('" & IMAGE_CODE.Text & "','" & cname.Text & "','" & ccode.Text & "','" & RRVV & "')"
        cmd.ExecuteNonQuery()
        Dim Sql As String = "update  lcompany_image set image = ? , no = ? where   CODE='" & IMAGE_CODE.Text & "' and company_code='" & Val(ccode.Text) & "'"
        cmd.CommandText = Sql
        cmd.Parameters.Clear()
        cmd.Parameters.Add("@image", System.Data.OleDb.OleDbType.Binary, oer.Length).Value = FileByteArrayr
        cmd.Parameters.Add("@no", System.Data.OleDb.OleDbType.VarChar, 100).Value = oer.Length
        cmd.ExecuteNonQuery()
        dr.Close()
        MsgBox(" „  ⁄„·Ì… «·Õ›Ÿ")
    End Sub

    Private Sub GlassButton149_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton149.Click
        dr.Close() : cmd.CommandText = "SELECT  * from lcompany_image where company_code='" & ccode.Text & "'"
        adPVW.SelectCommand = cmd
        adPVW.Fill(DBS, "PVW")
        PVW = DBS.Tables("PVW")
        DBS.Tables("PVW").Clear()
        adPVW.Fill(DBS, "PVW")
        pvw = DBS.Tables("PVW")
        Dim oj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        oj.Load(Application.StartupPath & "\limages.rpt")
        oj.Database.Tables(0).SetDataSource(PVW)
        rp.Close() : rp.CrystalReportViewer1.ReportSource = oj
        rp.Show() : rp.Focus()
    End Sub

    Private Sub GL1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GL1.Click
        dr.Close()
        cmd.CommandText = "INSERT INTO LCOMARKET(COMPANY_NAME,COMPANY_CODE,EMP_NAME,EMP_CODE) VALUES ('" & cname.Text & "','" & ccode.Text & "','" & name1.Text & "','" & CODE1.Text & "')"
        cmd.ExecuteNonQuery()
        MsgBox(" „  ⁄„·Ì… «·Õ›Ÿ", MsgBoxStyle.Information)
    End Sub

    Private Sub name1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles name1.GotFocus
        flng("AR")

    End Sub

    Private Sub name1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles name1.KeyUp
        If e.KeyCode = Keys.Enter Then
            dr.Close()
            cmd.CommandText = "SELECT * FROM  EEMP WHERE NAME='" & name1.Text & "'"
            dr = cmd.ExecuteReader
            While dr.Read
                CODE1.Text = dr("CODE")
                tel1.Text = dr("MOBILE")
                email1.Text = dr("EMAIL")
            End While

        End If
    End Sub


    Private Sub name1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles name1.TextChanged

    End Sub

    Private Sub TextBox9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CODE2.TextChanged

    End Sub

    Private Sub name2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles name2.GotFocus
        flng("AR")

    End Sub

    Private Sub name2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles name2.KeyDown
        If e.KeyCode = Keys.Enter Then
            dr.Close()
            cmd.CommandText = "SELECT * FROM  EEMP WHERE NAME='" & name2.Text & "'"
            dr = cmd.ExecuteReader
            While dr.Read
                CODE2.Text = dr("CODE")
                tel2.Text = dr("MOBILE")
                email2.Text = dr("EMAIL")
            End While
        End If
    End Sub

    Private Sub name2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles name2.TextChanged

    End Sub

    Private Sub name3_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles name3.GotFocus
        flng("AR")

    End Sub

    Private Sub name3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles name3.KeyDown
        If e.KeyCode = Keys.Enter Then
            dr.Close()
            cmd.CommandText = "SELECT * FROM  EEMP WHERE NAME='" & name3.Text & "'"
            dr = cmd.ExecuteReader
            While dr.Read
                CODE3.Text = dr("CODE")
                tel3.Text = dr("MOBILE")
                email3.Text = dr("EMAIL")
            End While

        End If
    End Sub

    Private Sub name3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles name3.TextChanged

    End Sub

    Private Sub GlassButton150_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton150.Click
        If IsNumeric(ccode.Text) = False Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·ﬂÊœ") : Exit Sub
        If name1.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «”„ «· ”ÊÌﬁ") : Exit Sub
        dr.Close()
        cmd.CommandText = "select * from LCOMARKET where   COMPANY_code='" & ccode.Text & "' AND EMP_CODE='" & CODE1.Text & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Dim n As String
            n = MsgBox(" Â·  —Ìœ «·Õ–› ø", MsgBoxStyle.YesNo)
            If n = vbNo Then Exit Sub
            dr.Close()
            cmd.CommandText = "delete from LCOMARKET where    COMPANY_code='" & ccode.Text & "'  AND EMP_CODE='" & CODE1.Text & "'"
            cmd.ExecuteNonQuery()
        End If
        MsgBox(" „  ⁄„·Ì… Õ–› «·—»ÿ »Ì‰ «·‘—ﬂ… Ê «·ÿ»Ì»", MsgBoxStyle.Information)
    End Sub

    Private Sub GlassButton151_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton151.Click
        OpenFileDialog1.ShowDialog()
        PictureBox1.ImageLocation = OpenFileDialog1.FileName
        Dim oer As System.IO.FileStream
        Dim rer As IO.StreamReader
        oer = New IO.FileStream(OpenFileDialog1.FileName, IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.Read)
        rer = New IO.StreamReader(oer)
        Dim FileByteArrayr(oer.Length - 1) As Byte
        oer.Read(FileByteArrayr, 0, oer.Length)
        dr.Close()
        cmd.CommandText = "select max(code) from lcompany_image WHERE  code='" & Val(ccode.Text) & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        IMAGE_CODE.Text = nulls(dr(0)) + 1
        dr.Close()
        cmd.CommandText = "update lcompany set bran='" & RRVV & "' where code='" & Val(ccode.Text) & "'"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "insert into lcompany_image (CODE,company_name,company_code,bran ) values ('" & IMAGE_CODE.Text & "','" & cname.Text & "','" & ccode.Text & "','" & RRVV & "')"
        cmd.ExecuteNonQuery()
        Dim Sql As String = "update  lcompany_image set image = ? , no = ? where   CODE='" & IMAGE_CODE.Text & "' and company_code='" & Val(ccode.Text) & "'"
        cmd.CommandText = Sql
        cmd.Parameters.Clear()
        cmd.Parameters.Add("@image", System.Data.OleDb.OleDbType.Binary, oer.Length).Value = FileByteArrayr
        cmd.Parameters.Add("@no", System.Data.OleDb.OleDbType.VarChar, 100).Value = oer.Length
        cmd.ExecuteNonQuery()
        dr.Close()
        MsgBox(" „  ⁄„·Ì… «·Õ›Ÿ")
    End Sub

    Private Sub NREF_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles NREF.GotFocus
        flng("EN")
    End Sub

    Private Sub NREF_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NREF.TextChanged

    End Sub

    Private Sub nunit_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles nunit.GotFocus

    End Sub

    Private Sub nunit_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nunit.SelectedIndexChanged

    End Sub

    Private Sub nsunit_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles nsunit.GotFocus
        flng("EN")
    End Sub

    Private Sub nsunit_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nsunit.SelectedIndexChanged

    End Sub

    Private Sub nsref_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles nsref.GotFocus
        flng("EN")
    End Sub

    Private Sub nsref_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nsref.TextChanged

    End Sub

    Private Sub GlassButton152_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton152.Click
        Dim I, II As String
        I = ""
        II = ""
        dr1.Close()
        dr.Close()
        cmd.CommandText = "SELECT * FROM LCOMPANY ORDER BY CODE,NAME "
        dr = cmd.ExecuteReader
        While dr.Read
            If dr("CODE") = Val(I) And dr("NAME") = II Then
                cmd1.CommandText = "DELETE LCOMPANY WHERE KY='" & dr("KY") & "'"
                cmd1.ExecuteNonQuery()
            End If
            I = dr("CODE")
            II = dr("NAME")

        End While
    End Sub

    Private Sub GlassButton153_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton153.Click
        ACdr.Close()
        dr.Close()
        ACcmd.CommandText = "SELECT *  FROM TEST "
        ACdr = ACcmd.ExecuteReader
        While ACdr.Read
            cmd.CommandText = "INSERT INTO LTEST_PRICE (TEST_CODE,TEST_NAME,TOT,BOOK_PRICE_CODE,BOOK_PRICE_NAME) VALUES ('" & nulls(ACdr("TEST_CODE")) & "','" & ACdr("TEST_NAME") & "', '" & ACdr("PRICE") * per.Text * 0.01 & "','" & cbook_price_code.Text & "','" & cbook_price_name.Text & "')"
            cmd.ExecuteNonQuery()
        End While

        'dr.Close()
        'cmd.CommandText = "update lTEST_PRICE set lTEST_PRICE.test_CODE=lTEST.test_CODE fROM lTEST_PRICE INNER JOIN LTEST ON lTEST_PRICE.test_NAME=LTEST.test_NAME "
        'cmd.ExecuteNonQuery()

        MsgBox("it's done ", MsgBoxStyle.Information)
    End Sub

    Private Sub GlassButton154_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton154.Click
        ACdr.Close()
        dr.Close()
        ACcmd.CommandText = "SELECT *  FROM TEST "
        ACdr = ACcmd.ExecuteReader
        While ACdr.Read
            cmd.CommandText = "update ltest set ar='" & ACdr("test_code") & "' where test_name='" & ACdr("test_name") & "'"
            cmd.ExecuteNonQuery()
        End While
        MsgBox("done")
    End Sub

    Private Sub GlassButton155_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        dr.Close()
        ACdr.Close()
        ACcmd.CommandText = "select * from testp ORDER BY TEST_AR"
        ACdr = ACcmd.ExecuteReader
        While ACdr.Read
            'GlassButton26_Click(GlassButton26, e)
            ttest_name.Text = ACdr("test_ar")
            ptest_name.Text = ACdr("test_ar")
            par.Text = ACdr("test_name")
            tar.Text = ACdr("test_name")
            gr_name.Text = ACdr("gr")
            ptest_code.Text = ttest_code.Text
            'GlassButton16_Click(GlassButton16, e)
            'tsave()
            cmd.CommandText = "UPDATE LTEST_PRICE SET TOT=" & Val(ACdr("PRICE")) & "*.9 WHERE TEST_NAME='" & ACdr("test_ar") & "'"
            cmd.ExecuteNonQuery()
        End While

    End Sub

    Private Sub GlassButton156_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)




    End Sub

    Private Sub GlassButton157_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton157.Click
        Dim n As Integer = 0
        While Not n = test_price.Rows.Count
            RC = test_price.Rows(n)
            dr.Close()
            If RC("tot") > 0 Then
                Dim x As Integer = (RC("tot") * per.Text * 0.01) + RC("tot")
                Dim nn As Integer = x Mod 5
                x = (5 - nn) + x
                cmd.CommandText = "update ltest_price set tot='" & x & "' where test_code='" & RC("test_code") & "' and book_price_code='" & RC("book_price_code") & "'"
                cmd.ExecuteNonQuery()
            End If

            n += 1
        End While
    End Sub

    Private Sub GlassButton158_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton158.Click
        dr.Close()
        ACdr.Close() : ACcmd.CommandText = "delete * from book_price"
        ACcmd.ExecuteNonQuery()
        dr.Close() : cmd.CommandText = "select name,code from lbook_price "
        dr = cmd.ExecuteReader
        While dr.Read = True
            ACdr.Close() : ACcmd.CommandText = "insert into book_price (sr,name,srh,sno,code) values ('0','" & dr("name") & "','0','0','" & dr("code") & "')"
            ACcmd.ExecuteNonQuery()

        End While
        dr.Close()
        cmda.Connection = CN
        cmda.CommandType = CommandType.Text
        cmda.CommandText = "select * FROM srh "
        ada.SelectCommand = cmda
        ada.Fill(DBS, "a")
        a = DBS.Tables("a")
        DBS.Tables("a").Clear()
        ada.Fill(DBS, "a")
        a = DBS.Tables("a")
        cmdbook.Connection = ACcn
        cmdbook.CommandType = CommandType.Text
        cmdbook.CommandText = "select srh,sr,name,sno,code,ky FROM book_price order by CODE"
        adbook.SelectCommand = cmdbook
        adbook.Fill(DBS, "book")
        book = DBS.Tables("book")
        DBS.Tables("book").Clear()
        adbook.Fill(DBS, "book")
        DataGridView15.DataSource = book
        Dim v As Integer = 0
        While Not v = DataGridView15.Columns.Count
            DataGridView15.Columns(v).Visible = False
            v = v + 1
        End While
        DataGridView15.Columns("NAME").Visible = True
        DataGridView15.Columns("srh").Visible = True

    End Sub

    Private Sub Label133_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label133.Click

    End Sub

    Private Sub GlassButton159_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton159.Click
        Dim S As Integer = InputBox("ENTER PASWORD")
        If S <> 205 Then Exit Sub
        dr.Close()
        cmd.CommandText = "update  ltest_price set p1=tot*" & per.Text * 0.01 & ",v1=tot*" & Val(100 - per.Text) * 0.01 & " where   book_price_name='" & cbook_price_name.Text & "' "
        cmd.ExecuteNonQuery()

    End Sub

    Private Sub GlassButton160_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton160.Click
        Dim S As Integer = InputBox("ENTER PASWORD")
        If S <> 205 Then Exit Sub
        dr.Close()
        cmd.CommandText = "update  ltest_price set p1=tot*" & per.Text * 0.01 & ", v1=tot*" & Val(100 - per.Text) * 0.01 & " where   book_price_name='" & cbook_price_name.Text & "' and p1<1 and V1<1"
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub ddd10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddd10.Click
        dr.Close()
        cmd.CommandText = "select max(CODE) from eemp "
        dr = cmd.ExecuteReader
        dr.Read()
        If IsDBNull(dr(0)) = False Then PCODE.Text = dr(0) + 1 Else PCODE.Text = 1
        dr.Close()
        cmd.CommandText = "INSERT INTO eemp(NAME,CODE,mobile,email,ADDRESS) values ('" & name1.Text & "','" & PCODE.Text & "','" & tel1.Text & "','" & email1.Text & "'," & addres.Text & ")"
        cmd.ExecuteNonQuery()
        name1.AutoCompleteCustomSource.Add(name1.Text)
        name2.AutoCompleteCustomSource.Add(name1.Text)
        name3.AutoCompleteCustomSource.Add(name1.Text)
    End Sub

    Private Sub ddd11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddd11.Click
        If name1.Text = "" Then MsgBox("«·—Ã«¡ ﬂ «»… «”„ «·Õ«·…") : Exit Sub
        dr.Close()
        cmd.CommandText = "select * from eemp where  name='" & name1.Text & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            Dim x As String
            x = MsgBox("Â·  —Ìœ Õ–› «·„‰œÊ» ø", MsgBoxStyle.YesNo)
            If x = vbNo Then Exit Sub
            dr.Close()
            cmd.CommandText = "delete from eemp where name='" & name1.Text & "'"
            cmd.ExecuteNonQuery()
            name1.AutoCompleteCustomSource.Remove(name1.Text)
            name2.AutoCompleteCustomSource.Remove(name1.Text)
            name2.AutoCompleteCustomSource.Remove(name1.Text)

        Else
            MsgBox("Â–« «·«Ì’«· €Ì— „”Ã·")

        End If
    End Sub

    Private Sub GlassButton161_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton161.Click
        Dim X As String = ""
        If cname1.Checked = True Then X = " WHERE name1='" & name1.Text & "'"
        cmdcompany.Connection = CN
        cmdcompany.CommandType = CommandType.Text
        cmdcompany.CommandText = "select * from lcompany" & X
        adcompany.SelectCommand = cmdcompany
        adcompany.Fill(DBS, "company")
        company = DBS.Tables("company")
        DBS.Tables("company").Clear()
        adcompany.Fill(DBS, "company")
        company = DBS.Tables("company")
        DataGridView6.DataSource = company
        dr.Close()
        Dim oj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        oj.Load(Application.StartupPath & "\COMPANYmn.rpt")
        oj.Database.Tables(0).SetDataSource(company)
        rp.CrystalReportViewer1.ReportSource = oj
        rp.Show() : rp.Focus()
    End Sub

    Private Sub GlassButton164_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton164.Click
        dr.Close() : cmd.CommandText = "INSERT INTO LNTEST([test_code],[test_name],[ref],[type] ,[ageb],[agee],[NORB],[NORE],[unit],year,SRES) VALUES ('" & Ntest_CODE.Text & "','" & Ntest_NAME.Text & "','" & NREF.Text & "','FEMALE','" & NAGEB.Text & "','" & NAGEE.Text & "','" & NNORB.Text & "','" & NNORE.Text & "','" & nunit.Text & "','" & PYEAR.Text & "','" & Val(sres.CheckState) & "')"
        cmd.ExecuteNonQuery()
        dr.Close() : cmd.CommandText = "INSERT INTO LNTEST([test_code],[test_name],[ref],[type] ,[ageb],[agee],[NORB],[NORE],[unit],year,SRES) VALUES ('" & Ntest_CODE.Text & "','" & Ntest_NAME.Text & "','" & NREF.Text & "','MALE','" & NAGEB.Text & "','" & NAGEE.Text & "','" & NNORB.Text & "','" & NNORE.Text & "','" & nunit.Text & "','" & PYEAR.Text & "','" & Val(sres.CheckState) & "')"
        cmd.ExecuteNonQuery()
        GlassButton36_Click(GlassButton36, e)
    End Sub

    Private Sub GlassButton162_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton162.Click
        dr.Close()
        dr.Close()
        cmd.CommandText = "DELETE from LNTEST where test_name='" & Ntest_NAME.Text & "' AND  type='FEMALE'"
        cmd.ExecuteNonQuery()

        cmd.CommandText = "INSERT INTO LNTEST([test_code],[test_name],[ref],[type] ,[ageb],[agee],[NORB],[NORE],[unit],year,SRES) VALUES ('" & Ntest_CODE.Text & "','" & Ntest_NAME.Text & "','" & NREF.Text & "','FEMALE','0','120','" & NNORB.Text & "','" & NNORE.Text & "','" & nunit.Text & "','YEAR','" & Val(sres.CheckState) & "')"
        cmd.ExecuteNonQuery()
        dr.Close() : cmd.CommandText = "INSERT INTO LNTEST([test_code],[test_name],[ref],[type] ,[ageb],[agee],[NORB],[NORE],[unit],year,SRES) VALUES ('" & Ntest_CODE.Text & "','" & Ntest_NAME.Text & "','" & NREF.Text & "','FEMALE','0','120','" & NNORB.Text & "','" & NNORE.Text & "','" & nunit.Text & "','MONTH','" & Val(sres.CheckState) & "')"
        cmd.ExecuteNonQuery()
        dr.Close() : cmd.CommandText = "INSERT INTO LNTEST([test_code],[test_name],[ref],[type] ,[ageb],[agee],[NORB],[NORE],[unit],year,SRES) VALUES ('" & Ntest_CODE.Text & "','" & Ntest_NAME.Text & "','" & NREF.Text & "','FEMALE','0','120','" & NNORB.Text & "','" & NNORE.Text & "','" & nunit.Text & "','DAY','" & Val(sres.CheckState) & "')"
        cmd.ExecuteNonQuery()
        GlassButton36_Click(GlassButton36, e)

    End Sub

    Private Sub GlassButton163_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton163.Click

        dr.Close()
        cmd.CommandText = "DELETE from LNTEST where test_name='" & Ntest_NAME.Text & "' AND  type='MALE'"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "INSERT INTO LNTEST([test_code],[test_name],[ref],[type] ,[ageb],[agee],[NORB],[NORE],[unit],year,SRES) VALUES ('" & Ntest_CODE.Text & "','" & Ntest_NAME.Text & "','" & NREF.Text & "','MALE','0','120','" & NNORB.Text & "','" & NNORE.Text & "','" & nunit.Text & "','YEAR','" & Val(sres.CheckState) & "')"
        cmd.ExecuteNonQuery()
        dr.Close() : cmd.CommandText = "INSERT INTO LNTEST([test_code],[test_name],[ref],[type] ,[ageb],[agee],[NORB],[NORE],[unit],year,SRES) VALUES ('" & Ntest_CODE.Text & "','" & Ntest_NAME.Text & "','" & NREF.Text & "','MALE','0','120','" & NNORB.Text & "','" & NNORE.Text & "','" & nunit.Text & "','MONTH','" & Val(sres.CheckState) & "')"
        cmd.ExecuteNonQuery()
        dr.Close() : cmd.CommandText = "INSERT INTO LNTEST([test_code],[test_name],[ref],[type] ,[ageb],[agee],[NORB],[NORE],[unit],year,SRES) VALUES ('" & Ntest_CODE.Text & "','" & Ntest_NAME.Text & "','" & NREF.Text & "','MALE','0','120','" & NNORB.Text & "','" & NNORE.Text & "','" & nunit.Text & "','DAY','" & Val(sres.CheckState) & "')"
        cmd.ExecuteNonQuery()
        GlassButton36_Click(GlassButton36, e)

    End Sub

    Private Sub GlassButton165_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton165.Click
        dr.Close() : cmd.CommandText = "INSERT INTO LNSTEST([Mtest_code],[Mtest_name],[test_code],[test_name],[ref],[type] ,[ageb],[agee],[NORB],[NORE],[unit],year) VALUES ('" & nMtest_CODE.Text & "','" & nmtest_name.Text & "','" & nstest_code.Text & "','" & nstest_name.Text & "','" & nsref.Text & "','FEMALE','" & nsageb.Text & "','" & nsagee.Text & "','" & nsnorb.Text & "','" & nsnore.Text & "','" & nsunit.Text & "','" & syear.Text & "')"
        cmd.ExecuteNonQuery()
        dr.Close() : cmd.CommandText = "INSERT INTO LNSTEST([Mtest_code],[Mtest_name],[test_code],[test_name],[ref],[type] ,[ageb],[agee],[NORB],[NORE],[unit],year) VALUES ('" & nMtest_CODE.Text & "','" & nmtest_name.Text & "','" & nstest_code.Text & "','" & nstest_name.Text & "','" & nsref.Text & "','MALE','" & nsageb.Text & "','" & nsagee.Text & "','" & nsnorb.Text & "','" & nsnore.Text & "','" & nsunit.Text & "','" & syear.Text & "')"
        cmd.ExecuteNonQuery()
        GlassButton45_Click(GlassButton45, e)
    End Sub

    Private Sub GlassButton166_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton166.Click
        dr.Close()
        cmd.CommandText = "DELETE from LNSTEST where test_code='" & nstest_code.Text & "' AND  type='MALE'"
        cmd.ExecuteNonQuery()
        dr.Close() : cmd.CommandText = "INSERT INTO LNSTEST([Mtest_code],[Mtest_name],[test_code],[test_name],[ref],[type] ,[ageb],[agee],[NORB],[NORE],[unit],year) VALUES ('" & nMtest_CODE.Text & "','" & nmtest_name.Text & "','" & nstest_code.Text & "','" & nstest_name.Text & "','" & nsref.Text & "','MALE','0','120','" & nsnorb.Text & "','" & nsnore.Text & "','" & nsunit.Text & "','YEAR')"
        cmd.ExecuteNonQuery()
        dr.Close() : cmd.CommandText = "INSERT INTO LNSTEST([Mtest_code],[Mtest_name],[test_code],[test_name],[ref],[type] ,[ageb],[agee],[NORB],[NORE],[unit],year) VALUES ('" & nMtest_CODE.Text & "','" & nmtest_name.Text & "','" & nstest_code.Text & "','" & nstest_name.Text & "','" & nsref.Text & "','MALE','0','120','" & nsnorb.Text & "','" & nsnore.Text & "','" & nsunit.Text & "','MONTH')"
        cmd.ExecuteNonQuery()
        dr.Close() : cmd.CommandText = "INSERT INTO LNSTEST([Mtest_code],[Mtest_name],[test_code],[test_name],[ref],[type] ,[ageb],[agee],[NORB],[NORE],[unit],year) VALUES ('" & nMtest_CODE.Text & "','" & nmtest_name.Text & "','" & nstest_code.Text & "','" & nstest_name.Text & "','" & nsref.Text & "','MALE','0','120','" & nsnorb.Text & "','" & nsnore.Text & "','" & nsunit.Text & "','DAY')"
        cmd.ExecuteNonQuery()
        GlassButton45_Click(GlassButton45, e)
    End Sub

    Private Sub GlassButton167_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton167.Click
        dr.Close()
        cmd.CommandText = "DELETE from LNSTEST where test_code='" & nstest_code.Text & "' AND  type='FEMALE'"
        cmd.ExecuteNonQuery()
        dr.Close() : cmd.CommandText = "INSERT INTO LNSTEST([Mtest_code],[Mtest_name],[test_code],[test_name],[ref],[type] ,[ageb],[agee],[NORB],[NORE],[unit],year) VALUES ('" & nMtest_CODE.Text & "','" & nmtest_name.Text & "','" & nstest_code.Text & "','" & nstest_name.Text & "','" & nsref.Text & "','FEMALE','0','120','" & nsnorb.Text & "','" & nsnore.Text & "','" & nsunit.Text & "','YEAR')"
        cmd.ExecuteNonQuery()
        dr.Close() : cmd.CommandText = "INSERT INTO LNSTEST([Mtest_code],[Mtest_name],[test_code],[test_name],[ref],[type] ,[ageb],[agee],[NORB],[NORE],[unit],year) VALUES ('" & nMtest_CODE.Text & "','" & nmtest_name.Text & "','" & nstest_code.Text & "','" & nstest_name.Text & "','" & nsref.Text & "','FEMALE','0','120','" & nsnorb.Text & "','" & nsnore.Text & "','" & nsunit.Text & "','MONTH')"
        cmd.ExecuteNonQuery()
        dr.Close() : cmd.CommandText = "INSERT INTO LNSTEST([Mtest_code],[Mtest_name],[test_code],[test_name],[ref],[type] ,[ageb],[agee],[NORB],[NORE],[unit],year) VALUES ('" & nMtest_CODE.Text & "','" & nmtest_name.Text & "','" & nstest_code.Text & "','" & nstest_name.Text & "','" & nsref.Text & "','FEMALE','0','120','" & nsnorb.Text & "','" & nsnore.Text & "','" & nsunit.Text & "','DAY')"
        cmd.ExecuteNonQuery()
        GlassButton45_Click(GlassButton45, e)

    End Sub

    Private Sub TabPage19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage19.Click

    End Sub

    Private Sub GlassButton168_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton168.Click
        dr.Close()
        cmd.CommandText = "delete from LNSTEST where test_code='" & nstest_code.Text & "'"
        cmd.ExecuteNonQuery()
        Dim N As Integer = 0
        While Not N = LNTEST.Rows.Count
            RC = LNTEST.Rows(N)
            nsref.Text = RC("ref")
            nstype.Text = RC("Type")
            nsageb.Text = RC("ageb")
            nsagee.Text = RC("agee")
            nsnorb.Text = RC("NORB")
            nsnore.Text = RC("NORE")
            nsunit.Text = RC("unit")
            syear.Text = RC("year")
            sres.CheckState = Val(("SRES"))
            GlassButton44_Click(GlassButton44, e)
            N += 1
        End While


    End Sub

    Private Sub Label46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label46.Click
        dr1.Close()
        cmd1.CommandText = "select TEST_NAME from lTEST where  TEST_NAME LIKE '%" & ptest_name.Text & "%'"
        dr1 = cmd1.ExecuteReader
        If dr1.HasRows Then
            Dim xxaa As String = ""
            xxaa = xxaa & Environment.NewLine
            While dr1.Read
                xxaa = xxaa & Environment.NewLine & dr1(0)
            End While
            MsgBox(xxaa, MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub dbook_price_name_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dbook_price_name.SelectedIndexChanged
        If dbook_price_name.Focused = False Then Exit Sub
        If dbook_price_name.Text = "" Then Exit Sub
        If EX = 1 Then Exit Sub
        FRC = book_price.Select("NAME='" & dbook_price_name.Text & "'")
        If FRC.Length <= 0 Then
            pbook_price_name.Text = ""
            pbook_price_code.Text = ""
            Exit Sub
        Else
            RC = FRC(0)
            pbook_price_code.Text = RC("code")
            dbook_price_code.Text = RC("code")
            pbook_price_name.Text = dbook_price_name.Text
        End If
        GlassButton66_Click(GlassButton66, e)
    End Sub

    Private Sub canc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles canc.CheckedChanged

    End Sub

    Private Sub GlassButton103_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton103.Click
        Dim S As Integer = InputBox("ENTER PASWORD")
        If S <> 205 Then Exit Sub
        dr.Close()
        dr1.Close()
        cmd1.CommandText = "update lntest set lntest.test_name=lTEST.test_name fROM lntest INNER JOIN LTEST ON lntest.test_CODE=LTEST.test_CODE "
        cmd1.ExecuteNonQuery()
        cmd1.CommandText = "update lnStest set lnStest.Mtest_name=lTEST.test_name FROM lnStest INNER JOIN LTEST ON lnStest.Mtest_CODE=LTEST.test_CODE "
        cmd1.ExecuteNonQuery()
        cmd1.CommandText = "update LSUBTEST set LSUBTEST.Mtest_name=lTEST.test_name FROM LSUBTEST INNER JOIN LTEST ON LSUBTEST.Mtest_CODE=LTEST.test_CODE "
        cmd1.ExecuteNonQuery()
        cmd1.CommandText = "update lbill_testSUB set lbill_testSUB.Mtest_name=lTEST.test_name FROM lbill_testSUB INNER JOIN LTEST ON lbill_testSUB.Mtest_CODE=LTEST.test_CODE "
        cmd1.ExecuteNonQuery()
        cmd1.CommandText = "update lgroup_test set lgroup_test.test_name=lTEST.test_name FROM lgroup_test INNER JOIN LTEST ON lgroup_test.test_CODE=LTEST.test_CODE "
        cmd1.ExecuteNonQuery()
        cmd1.CommandText = "update ltest_price set ltest_price.test_name=lTEST.test_name FROM ltest_price INNER JOIN LTEST ON ltest_price.test_CODE=LTEST.test_CODE "
        cmd1.ExecuteNonQuery()
        cmd1.CommandText = "update lbill_test set lbill_test.test_name=lTEST.test_name FROM lbill_test INNER JOIN LTEST ON lbill_test.test_CODE=LTEST.test_CODE "
        cmd1.ExecuteNonQuery()
        MsgBox("OK")
    End Sub

    Private Sub GlassButton105_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton105.Click

        dr.Close()
        cmd.CommandText = "update ltest_price set bran=0 where book_price_code = '" & dbook_price_code.Text & "'"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "select * from ltest_price where book_price_code = '" & cbook_price_code.Text & "'"
        dr = cmd.ExecuteReader
        dr1.Close()
        While dr.Read
            cmd1.CommandText = "update ltest_price set bran=1 where book_price_code = '" & dbook_price_code.Text & "' and test_code='" & dr("test_code") & "'"
            cmd1.ExecuteNonQuery()
        End While
        dr1.Close()
        dr.Close()
        cmd.CommandText = "select * from ltest_price where book_price_code = '" & dbook_price_code.Text & "' and bran=0"
        dr = cmd.ExecuteReader
        dr1.Close()
        While dr.Read
            cmd1.CommandText = "update ltest_price set tot=" & (dr("tot") * per.Text * 0.01) & " where book_price_code = '" & dbook_price_code.Text & "' and test_code='" & dr("test_code") & "'"
            cmd1.ExecuteNonQuery()
        End While
        dr1.Close()

    End Sub

    Private Sub GlassButton104_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton104.Click

        dr.Close()
        cmd.CommandText = "update ltest_price set bran=0 where book_price_code = '" & dbook_price_code.Text & "'"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "select * from ltest_price where book_price_code = '" & cbook_price_code.Text & "'"
        dr = cmd.ExecuteReader
        dr1.Close()
        While dr.Read
            cmd1.CommandText = "update ltest_price set bran=1 where book_price_code = '" & dbook_price_code.Text & "' and test_code='" & dr("test_code") & "'"
            cmd1.ExecuteNonQuery()
        End While
        cmdtest_price.Connection = CN
        cmdtest_price.CommandType = CommandType.Text
        cmdtest_price.CommandText = "select * from ltest_price where book_price_code = '" & dbook_price_code.Text & "' and bran=0"
        adtest_price.SelectCommand = cmdtest_price
        adtest_price.Fill(DBS, "test_price")
        test_price = DBS.Tables("test_price")
        DBS.Tables("test_price").Clear()
        adtest_price.Fill(DBS, "test_price")
        test_price = DBS.Tables("test_price")
        DataGridView4.DataSource = test_price
        MsgBox(test_price.Rows.Count)
        dr.Close()
        Dim oj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        oj.Load(Application.StartupPath & "\test price.rpt")
        oj.Database.Tables(0).SetDataSource(test_price)
        rp.CrystalReportViewer1.ReportSource = oj
        rp.Show() : rp.Focus()
    End Sub

    Private Sub GlassButton38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton38.Click

    End Sub

    Private Sub GlassButton106_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton106.Click
        dr.Close()
        cmd.CommandText = "delete from LNSTEST where test_code='" & nstest_code.Text & "'"
        cmd.ExecuteNonQuery()
        Dim N As Integer = 0
        ACdr.Close()
        ACcmd.CommandText = "select * from nor "
        ACdr = ACcmd.ExecuteReader

        While ACdr.Read
            nsref.Text = ACdr("ref")
            nstype.Text = ACdr("Type")
            nsageb.Text = ACdr("ageb")
            nsagee.Text = ACdr("agee")
            nsnorb.Text = ACdr("NORB")
            nsnore.Text = ACdr("NORE")
            nsunit.Text = ACdr("unit")
            syear.Text = ACdr("year")
            syear.Text = ACdr("year")
            sres.CheckState = 0
            dr.Close()
            cmd.CommandText = "INSERT INTO LNSTEST([Mtest_code],[Mtest_name],[test_code],[test_name],[ref],[type] ,[ageb],[agee],[NORB],[NORE],[unit],year,ref1) VALUES ('" & nMtest_CODE.Text & "','" & nmtest_name.Text & "','" & nstest_code.Text & "','" & nstest_name.Text & "','" & nsref.Text & "','" & nstype.Text & "','" & nsageb.Text & "','" & nsagee.Text & "','" & nsnorb.Text & "','" & nsnore.Text & "','" & nsunit.Text & "','" & syear.Text & "','" & ACdr("sres") & "')"
            cmd.ExecuteNonQuery()
        End While
    End Sub

    Private Sub GlassButton107_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton107.Click
        dr.Close()
        cmd.CommandText = "UPDATE ltest_price SET book_price_CODE='" & dbook_price_code.Text & "'  where book_price_name='" & dbook_price_name.Text & "'"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "UPDATE lbill SET book_CODE='" & dbook_price_code.Text & "'  where book_name='" & dbook_price_name.Text & "'"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "UPDATE lgroup_price SET book_price_CODE='" & dbook_price_code.Text & "'  where book_price_name='" & dbook_price_name.Text & "'"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "UPDATE LPATIEN SET book_CODE='" & dbook_price_code.Text & "'  where book_name='" & dbook_price_name.Text & "'"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "UPDATE lcompany SET book_price_CODE='" & dbook_price_code.Text & "'  where book_price_name='" & dbook_price_name.Text & "'"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "UPDATE lbook_price SET CODE='" & dbook_price_code.Text & "'  where name='" & dbook_price_name.Text & "'"
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub GlassButton155_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton155.Click
        dr.Close()
        cmd.CommandText = "delete from LNTEST where test_code='" & Ntest_CODE.Text & "'"
        cmd.ExecuteNonQuery()
        Dim N As Integer = 0
        While Not N = LnsTEST.Rows.Count
            RC = LnsTEST.Rows(N)
            NREF.Text = RC("ref")
            NTYPE.Text = RC("Type")
            NAGEB.Text = RC("ageb")
            NAGEE.Text = RC("agee")
            NNORB.Text = RC("NORB")
            NNORE.Text = RC("NORE")
            nunit.Text = RC("unit")
            PYEAR.Text = RC("year")
            GlassButton35_Click(GlassButton44, e)
            N += 1
        End While

    End Sub
End Class