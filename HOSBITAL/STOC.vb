Public Class STOC
    Dim cmdSUP As New OleDb.OleDbCommand
    Dim adSUP As New OleDb.OleDbDataAdapter
    Dim SUP As New DataTable
    Dim cmdSPEC As New OleDb.OleDbCommand
    Dim adSPEC As New OleDb.OleDbDataAdapter
    Dim SPEC As New DataTable
    Dim cmdBOOK As New OleDb.OleDbCommand
    Dim adBOOK As New OleDb.OleDbDataAdapter
    Dim BOOK As New DataTable
    Dim cmdA As New OleDb.OleDbCommand
    Dim adA As New OleDb.OleDbDataAdapter
    Dim A As New DataTable
    Dim cmdscont As New OleDb.OleDbCommand
    Dim adscont As New OleDb.OleDbDataAdapter
    Dim scont As New DataTable
    Dim cmdascont As New OleDb.OleDbCommand
    Dim adascont As New OleDb.OleDbDataAdapter
    Dim ascont As New DataTable
    Dim cmdITEM As New OleDb.OleDbCommand
    Dim adITEM As New OleDb.OleDbDataAdapter
    Dim ITEM As New DataTable
    Dim cmdFITEM As New OleDb.OleDbCommand
    Dim adFITEM As New OleDb.OleDbDataAdapter
    Dim FITEM As New DataTable
    Dim cmdSTOC As New OleDb.OleDbCommand
    Dim adSTOC As New OleDb.OleDbDataAdapter
    Dim STOC As New DataTable
    Dim cmdSTOC1 As New OleDb.OleDbCommand
    Dim adSTOC1 As New OleDb.OleDbDataAdapter
    Dim STOC1 As New DataTable
    Dim cmdTEST As New OleDb.OleDbCommand
    Dim adTEST As New OleDb.OleDbDataAdapter
    Dim TEST As New DataTable
    Dim cmdMOVET As New OleDb.OleDbCommand
    Dim adMOVET As New OleDb.OleDbDataAdapter
    Dim MOVET As New DataTable
    Dim cmdCUST As New OleDb.OleDbCommand
    Dim adCUST As New OleDb.OleDbDataAdapter
    Dim CUST As New DataTable
    Dim cmdTRAN As New OleDb.OleDbCommand
    Dim adTRAN As New OleDb.OleDbDataAdapter
    Dim TRAN As New DataTable
    Dim cmdgroup As New OleDb.OleDbCommand
    Dim adgroup As New OleDb.OleDbDataAdapter
    Dim group As New DataTable
    Dim cmdcard As New OleDb.OleDbCommand
    Dim adcard As New OleDb.OleDbDataAdapter
    Dim card As New DataTable
    Private Sub STOC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        filla("")
        
        dr.Close()
        ACdr.Close()
        ACcmd.CommandText = "delete * from strans"
        ACcmd.ExecuteNonQuery()
        cmd.CommandText = "select * from Sitem "
        dr = cmd.ExecuteReader
        While dr.Read
            ACcmd.CommandText = "insert into Strans (ITEM_code,ITEM_name,qun,PRICE,tot) values ('" & dr("code") & "' ,'" & dr("name") & "','0','" & nulls(dr("price")) & "','0') "
            ACcmd.ExecuteNonQuery()
        End While
        ACdr.Close() : ACcmd.CommandText = "select * from srv "
        ACdr = ACcmd.ExecuteReader
        ACdr.Read()
        If ACdr.HasRows Then
            PrintDialog1.PrinterSettings.PrinterName = ACdr("prnt")
            PrintDialog1.Document = PrintDocument1
        End If
        FRC = MOVET.Select("code='1'")
        If FRC.Length <= 0 Then
            MOVEname.Text = ""
            MOVECODE.Text = ""
            Exit Sub
        Else
            RC = FRC(0)
            MOVEname.Text = RC("name")
            FLG.Text = RC("FLG")
        End If

    End Sub
    Public Sub FSAVE(ByVal NNAME As String, ByVal TB As String, ByVal PR As Int16)
        Dim N As Int16
        If NNAME = "" Then Exit Sub
        dr.Close()
        cmd.CommandText = "select * from " & TB & " where name='" & NNAME & "'"
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
                dr.Close() : cmd.CommandText = "insert into  " & TB & "  (code,name)  values ('" & N & "','" & NNAME & "')"
                cmd.ExecuteNonQuery()
                filla(TB)
            End If
        Else
            Dim x As String = MsgBox("Â·  —Ìœ «·Õ–› ø", MsgBoxStyle.YesNo)
            If x = vbNo Then Exit Sub
            dr.Close()
            cmd.CommandText = "delete from " & TB & " where name='" & NNAME & "'"
            cmd.ExecuteNonQuery()
            filla(TB)

        End If
    End Sub
    
    Public Sub filla(ByVal tb As String)

        If tb = "SSTOC" Or tb = "" Then
            cmdSTOC.Connection = CN
            cmdSTOC.CommandType = CommandType.Text
            cmdSTOC.CommandText = "select * from SSTOC"
            adSTOC.SelectCommand = cmdSTOC
            adSTOC.Fill(DBS, "STOC")
            STOC = DBS.Tables("STOC")
            DBS.Tables("STOC").Clear()
            adSTOC.Fill(DBS, "STOC")
            STOC = DBS.Tables("STOC")
            STOCNAME.DataSource = STOC
            STOCNAME.DisplayMember = "NAME"
            If STOC.Rows.Count > 0 Then
                STOCNAME.Text = STOC.Rows(STOC.Rows.Count - 1).Item("name")
                STOCCODE.Text = STOC.Rows(STOC.Rows.Count - 1).Item("code")
            End If
            '========================================
        End If

        If tb = "SPEC" Or tb = "" Then
            cmdSPEC.Connection = CN
            cmdSPEC.CommandType = CommandType.Text
            cmdSPEC.CommandText = "select * from SPEC"
            adSPEC.SelectCommand = cmdSPEC
            adSPEC.Fill(DBS, "SPEC")
            SPEC = DBS.Tables("SPEC")
            DBS.Tables("SPEC").Clear()
            adSPEC.Fill(DBS, "SPEC")
            SPEC = DBS.Tables("SPEC")
            SPECNAME.DataSource = SPEC
            SPECNAME.DisplayMember = "NAME"
            If STOC.Rows.Count > 0 Then
                SPECNAME.Text = SPEC.Rows(SPEC.Rows.Count - 1).Item("name")
                SPECCODE.Text = SPEC.Rows(SPEC.Rows.Count - 1).Item("code")
            End If
            '========================================
        End If
        If tb = "scont" Or tb = "" Then
            cmdscont.Connection = CN
            cmdscont.CommandType = CommandType.Text
            cmdscont.CommandText = "select * from Scont"
            adscont.SelectCommand = cmdscont
            adscont.Fill(DBS, "Scont")
            scont = DBS.Tables("Scont")
            DBS.Tables("Scont").Clear()
            adscont.Fill(DBS, "Scont")
            scont = DBS.Tables("Scont")
            scontname.DataSource = scont
            scontname.DisplayMember = "NAME"
            If scont.Rows.Count > 0 Then
                scontname.Text = scont.Rows(scont.Rows.Count - 1).Item("name")
                scontcode.Text = scont.Rows(scont.Rows.Count - 1).Item("code")
            End If
            '========================================
        End If
        'If tb = "Sgroup" Or tb = "" Then
        '    cmdgroup.Connection = CN
        '    cmdgroup.CommandType = CommandType.Text
        '    cmdgroup.CommandText = "select * from Sgroup"
        '    adgroup.SelectCommand = cmdgroup
        '    adgroup.Fill(DBS, "group")
        '    group = DBS.Tables("group")
        '    DBS.Tables("group").Clear()
        '    adgroup.Fill(DBS, "group")
        '    group = DBS.Tables("group")
        '    group_name.DataSource = group
        '    group_name.DisplayMember = "NAME"
        '    If group.Rows.Count > 0 Then
        '        group_name.Text = group.Rows(group.Rows.Count - 1).Item("name")
        '        group_code.Text = group.Rows(group.Rows.Count - 1).Item("code")
        '    End If
        '    '========================================
        'End If
        If tb = "SCUST" Or tb = "" Then
            cmdCUST.Connection = CN
            cmdCUST.CommandType = CommandType.Text
            cmdCUST.CommandText = "select * from SCUST"
            adCUST.SelectCommand = cmdCUST
            adCUST.Fill(DBS, "CUST")
            CUST = DBS.Tables("CUST")
            DBS.Tables("CUST").Clear()
            adCUST.Fill(DBS, "CUST")
            CUST = DBS.Tables("CUST")
            CUSTNAME.DataSource = CUST
            CUSTNAME.DisplayMember = "NAME"
            If CUST.Rows.Count > 0 Then
                CUSTNAME.Text = CUST.Rows(CUST.Rows.Count - 1).Item("name")
                CUSTCODE.Text = CUST.Rows(CUST.Rows.Count - 1).Item("code")
            End If
            '========================================
        End If
        If tb = "SMOVETYPE" Or tb = "" Then
            cmdMOVET.Connection = CN
            cmdMOVET.CommandType = CommandType.Text
            cmdMOVET.CommandText = "select * from SMOVETYPE"
            adMOVET.SelectCommand = cmdMOVET
            adMOVET.Fill(DBS, "MOVET")
            MOVET = DBS.Tables("MOVET")
            DBS.Tables("MOVET").Clear()
            adMOVET.Fill(DBS, "MOVET")
            MOVET = DBS.Tables("MOVET")
            MOVEname.DataSource = MOVET
            MOVEname.DisplayMember = "NAME"
            If MOVET.Rows.Count > 0 Then
                FLG.Text = MOVET.Rows(MOVET.Rows.Count - 1).Item("FLG")
                MOVEname.Text = MOVET.Rows(MOVET.Rows.Count - 1).Item("name")
                MOVECODE.Text = MOVET.Rows(MOVET.Rows.Count - 1).Item("code")
            End If
            '========================================
        End If

        If tb = "SITEM" Or tb = "" Then
            cmdITEM.Connection = CN
            cmdITEM.CommandType = CommandType.Text
            cmdITEM.CommandText = "select * from SITEM"
            adITEM.SelectCommand = cmdITEM
            adITEM.Fill(DBS, "ITEM")
            ITEM = DBS.Tables("ITEM")
            DBS.Tables("ITEM").Clear()
            adITEM.Fill(DBS, "ITEM")
            ITEM = DBS.Tables("ITEM")
            ITEMNAME.DataSource = ITEM
            DataGridView2.DataSource = ITEM
            ITEMNAME.DisplayMember = "NAME"
            DataGridView2.Columns("KY").Visible = False
            DataGridView2.Columns("PRICE").HeaderText = "”⁄— «·’—›"
            DataGridView2.Columns("CODE").HeaderText = "«·ﬂÊœ"
            DataGridView2.Columns("NAME").HeaderText = "«·’‰›"
            DataGridView2.Columns("MINM").HeaderText = "«·Õœ «·«œ‰Ï "
            DataGridView2.Columns("NAME").Width = 200
            If ITEM.Rows.Count > 0 Then
                ITEMNAME.Text = ITEM.Rows(ITEM.Rows.Count - 1).Item("name")
                ITEMCODE.Text = nulls(ITEM.Rows(ITEM.Rows.Count - 1).Item("code"))
            End If
            '========================================
        End If
        If tb = "SSTOC1" Or tb = "" Then
            cmdSTOC1.Connection = CN
            cmdSTOC1.CommandType = CommandType.Text
            cmdSTOC1.CommandText = "select * from SSTOC"
            adSTOC1.SelectCommand = cmdSTOC1
            adSTOC1.Fill(DBS, "STOC1")
            STOC1 = DBS.Tables("STOC1")
            DBS.Tables("STOC1").Clear()
            adSTOC1.Fill(DBS, "STOC1")
            STOC1 = DBS.Tables("STOC1")
            STOC1NAME.DataSource = STOC1
            STOC1NAME.DisplayMember = "NAME"
            If STOC.Rows.Count > 0 Then
                STOC1NAME.Text = STOC1.Rows(STOC1.Rows.Count - 1).Item("name")
                STOC1CODE.Text = STOC1.Rows(STOC1.Rows.Count - 1).Item("code")
            End If
            '========================================
        End If
        If tb = "SSTOC1" Or tb = "" Then
            cmdSTOC1.Connection = CN
            cmdSTOC1.CommandType = CommandType.Text
            cmdSTOC1.CommandText = "select * from SSTOC"
            adSTOC1.SelectCommand = cmdSTOC1
            adSTOC1.Fill(DBS, "STOC1")
            STOC1 = DBS.Tables("STOC1")
            DBS.Tables("STOC1").Clear()
            adSTOC1.Fill(DBS, "STOC1")
            STOC1 = DBS.Tables("STOC1")
            STOC1NAME.DataSource = STOC1
            STOC1NAME.DisplayMember = "NAME"
            If STOC.Rows.Count > 0 Then
                STOC1NAME.Text = STOC1.Rows(STOC1.Rows.Count - 1).Item("name")
                STOC1CODE.Text = STOC1.Rows(STOC1.Rows.Count - 1).Item("code")
            End If
            '========================================
        End If
        If tb = "LTEST" Or tb = "" Then
            cmdTEST.Connection = CN
            cmdTEST.CommandType = CommandType.Text
            cmdTEST.CommandText = "select * from LTEST"
            adTEST.SelectCommand = cmdTEST
            adTEST.Fill(DBS, "TEST")
            TEST = DBS.Tables("TEST")
            DBS.Tables("TEST").Clear()
            adTEST.Fill(DBS, "TEST")
            TEST = DBS.Tables("TEST")
            TESTNAME.DataSource = TEST
            TESTNAME.DisplayMember = "test_NAME"
            If STOC.Rows.Count > 0 Then
                TESTNAME.Text = TEST.Rows(TEST.Rows.Count - 1).Item("TEST_name")
                TESTCODE.Text = TEST.Rows(TEST.Rows.Count - 1).Item("TEST_code")
            End If
            '========================================
        End If
        If tb = "SSUP" Or tb = "" Then
            cmdSUP.Connection = CN
            cmdSUP.CommandType = CommandType.Text
            cmdSUP.CommandText = "select * from SSUP"
            adSUP.SelectCommand = cmdSUP
            adSUP.Fill(DBS, "SUP")
            SUP = DBS.Tables("SUP")
            DBS.Tables("SUP").Clear()
            adSUP.Fill(DBS, "SUP")
            SUP = DBS.Tables("SUP")
            SUPNAME.DataSource = SUP
            SUPNAME.DisplayMember = "NAME"
            If SUP.Rows.Count > 0 Then
                SUPNAME.Text = SUP.Rows(SUP.Rows.Count - 1).Item("name")
                SUPCODE.Text = SUP.Rows(SUP.Rows.Count - 1).Item("code")
            End If
            '========================================
        End If
    End Sub
    Public Sub saveitem()
        Dim n As String
        n = ""
        n = MsgBox(" Â·  —Ìœ «·Õ›Ÿ ø", MsgBoxStyle.YesNo)
        If n = vbNo Then Exit Sub
        dr.Close() : cmd.CommandText = "select MAx(code) from SITEM "
        dr = cmd.ExecuteReader
        dr.Read()
        If IsDBNull(dr(0)) = False Then
            ITEMCODE.Text = 1 + dr(0)
        Else
            ITEMCODE.Text = 1
        End If


        If ITEMNAME.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
        Dim nnn As Double = InputBox("«·—Ã«¡ «œŒ«· «·”⁄—")
        Dim nnM As Double = InputBox("«·—Ã«¡ «œŒ«· «·Õœ «·«œ‰Ï")

        dr.Close()
        cmd.CommandText = "select * from SITEM where    NAME='" & ITEMNAME.Text & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then

            n = ""
            n = MsgBox(" Â·  —Ìœ «· ⁄œÌ· ø", MsgBoxStyle.YesNo)
            If n = vbNo Then Exit Sub
            ITEMCODE.Text = dr("code")
            dr.Close()
            cmd.CommandText = "delete from SITEM where     NAME='" & ITEMNAME.Text & "'"
            cmd.ExecuteNonQuery()
            dr.Close()
        End If
        dr.Close()
        cmd.CommandText = "INSERT INTO [ASILLAB].[dbo].[SITEM]([CODE],[NAME],[PRICE],[MINM])VALUES ('" & ITEMCODE.Text & "','" & ITEMNAME.Text & "','" & nnn & "','" & nnM & "')"
        cmd.ExecuteNonQuery()
        MsgBox("Õ›Ÿ «·’‰›")
    End Sub


    Private Sub ITEMNAME_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ITEMNAME.KeyDown
        Dim n As String
        If e.KeyCode = Keys.Enter Then
            saveitem()

        End If
        If e.KeyCode = Keys.Delete Then

            n = MsgBox(" Â·  —Ìœ «·Õ–› ø", MsgBoxStyle.YesNo)
            If IsNumeric(ITEMCODE.Text) = False Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·ﬂÊœ") : Exit Sub
            If ITEMNAME.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
            dr.Close()
            cmd.CommandText = "select * from SITEM where   NAME='" & ITEMNAME.Text & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                dr.Close()
                cmd.CommandText = "delete from SITEM where    NAME='" & ITEMNAME.Text & "'"
                cmd.ExecuteNonQuery()
            End If

        End If
        If e.KeyCode = Keys.Enter Then
            FRC = ITEM.Select("NAME='" & ITEMNAME.Text & "'")
            If FRC.Length <= 0 Then
                ITEMNAME.Text = ""
                ITEMCODE.Text = ""
                Exit Sub
            Else
                RC = FRC(0)
                ITEMCODE.Text = RC("code")
                price.Text = nulls(RC("price"))
                qun.Focus()
                dr.Close()
                cmd.CommandText = "SELECT SUM (QUN*FLG) FROM STRANSDET WHERE ITEM_CODE='" & ITEMCODE.Text & "'"
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    If IsDBNull(dr(0)) = False Then RSD.Text = dr(0) Else RSD.Text = 0
                End If

            End If
        End If
    End Sub

    Private Sub ITEMNAME_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ITEMNAME.KeyUp
        FITEM.Clear()
        cmdFITEM.Connection = ACcn
        cmdFITEM.CommandType = CommandType.Text
        cmdFITEM.CommandText = "select * FROM Strans where item_name like '%" & ITEMNAME.Text & "%'"
        adFITEM.SelectCommand = cmdFITEM
        adFITEM.Fill(DBS, "fitem")
        FITEM = DBS.Tables("fitem")
        DBS.Tables("fitem").Clear()
        adFITEM.Fill(DBS, "fitem")
        FITEM = DBS.Tables("fitem")
        ditem.DataSource = FITEM
        Dim v As Integer = 0
        While Not v = ditem.Columns.Count
            ditem.Columns(v).Visible = False
            v = v + 1
        End While
        ditem.Columns("ITEM_NAME").Visible = True
        ditem.Columns("ITEM_NAME").HeaderText = "«·’‰›"
        ditem.Columns("ITEM_NAME").Width = 100
        ditem.Columns("PRICE").Visible = True
        ditem.Columns("PRICE").HeaderText = "«·”⁄—"
        ditem.Columns("PRICE").Width = 40
        ditem.Columns("QUN").Visible = True
        ditem.Columns("QUN").HeaderText = "«·ﬂ„Ì…"
        ditem.Columns("QUN").Width = 40
        ditem.Columns("TOT").Visible = True
        ditem.Columns("TOT").HeaderText = "«·«Ã„«·Ï"
        ditem.Columns("TOT").Width = 60

    End Sub

    Private Sub ITEMNAME_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ITEMNAME.SelectedIndexChanged
        If ITEMNAME.Focused = False Then Exit Sub
        If ITEMNAME.Text = "" Then Exit Sub
        FRC = ITEM.Select("NAME='" & ITEMNAME.Text & "'")
        If FRC.Length <= 0 Then
            ITEMNAME.Text = ""
            ITEMCODE.Text = ""
            Exit Sub
        Else
            RC = FRC(0)
            ITEMCODE.Text = RC("code")
            price.Text = nulls(RC("price"))
            qun.Focus()
            dr.Close()
            cmd.CommandText = "SELECT SUM (QUN*FLG) FROM STRANSDET WHERE ITEM_CODE='" & ITEMCODE.Text & "' and specname='" & SPECNAME.Text & "'  "
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                If IsDBNull(dr(0)) = False Then RSD.Text = dr(0) Else RSD.Text = 0
            End If
            dr.Close()
            cmd.CommandText = "SELECT  max(price) FROM STRANSDET WHERE ITEM_CODE='" & ITEMCODE.Text & "' and specname='" & SPECNAME.Text & "' "
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                If IsDBNull(dr(0)) = False Then price.Text = dr(0) * 1.25 Else price.Text = 0
            End If
            scontp()
        End If
    End Sub


    Private Sub STOCNAME_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles STOCNAME.KeyDown
        If e.KeyCode = Keys.Enter Then
            FSAVE(STOCNAME.Text, "SSTOC", 1)
        ElseIf e.KeyCode = Keys.Delete Then
            FSAVE(STOCNAME.Text, "SSTOC", 2)
        End If
        If e.KeyCode = Keys.Enter Then
            FRC = STOC.Select("NAME='" & STOCNAME.Text & "'")
            If FRC.Length <= 0 Then
                STOCNAME.Text = ""
                STOCCODE.Text = ""
                Exit Sub
            Else
                RC = FRC(0)
                STOCCODE.Text = RC("code")
            End If
        End If
    End Sub

    Private Sub STOCNAME_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles STOCNAME.SelectedIndexChanged
        If STOCname.Focused = False Then Exit Sub
        If STOCname.Text = "" Then Exit Sub
        FRC = STOC.Select("NAME='" & STOCNAME.Text & "'")
        If FRC.Length <= 0 Then
            STOCNAME.Text = ""
            STOCCODE.Text = ""
            Exit Sub
        Else
            RC = FRC(0)
            STOCCODE.Text = RC("code")
        End If
    End Sub

    Private Sub MOVEname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MOVEname.KeyDown
        If e.KeyCode = Keys.Enter Then
            FRC = MOVET.Select("NAME='" & MOVEname.Text & "'")
            If FRC.Length <= 0 Then
                MOVEname.Text = ""
                MOVECODE.Text = ""
                Exit Sub
            Else
                RC = FRC(0)
                MOVECODE.Text = RC("code")
                FLG.Text = RC("FLG")
            End If
        End If
    End Sub

    Private Sub MOVEname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MOVEname.SelectedIndexChanged
        If MOVEname.Focused = False Then Exit Sub
        If MOVEname.Text = "" Then Exit Sub
        FRC = MOVET.Select("NAME='" & MOVEname.Text & "'")
        If FRC.Length <= 0 Then
            MOVEname.Text = ""
            MOVECODE.Text = ""
            Exit Sub
        Else
            RC = FRC(0)
            MOVECODE.Text = RC("code")
            FLG.Text = RC("FLG")
        End If
    End Sub

    Private Sub TESTNAME_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TESTNAME.KeyDown
        If e.KeyCode = Keys.Enter Then
            dr.Close()
            ACdr.Close()
            ACcmd.CommandText = "select * from Strans WHERE QUN>0 "
            ACdr = ACcmd.ExecuteReader
            While ACdr.Read
                cmd.CommandText = "insert into sgroup (test_code,test_name,item_code,item_name,qun) values ('" & TESTCODE.Text & "','" & TESTNAME.Text & "','" & ACdr("item_code") & "','" & ACdr("item_name") & "','" & ACdr("qun") & "')"
                cmd.ExecuteNonQuery()
            End While
            MsgBox(" „  ⁄„·Ì…  ⁄œÌ· „ﬂÊ‰«  «· Õ·Ì·", MsgBoxStyle.Information)

        End If

    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TESTNAME.SelectedIndexChanged
        If TESTNAME.Focused = False Then Exit Sub
        If TESTNAME.Text = "" Then Exit Sub
        FRC = TEST.Select("test_NAME='" & TESTNAME.Text & "'")
        If FRC.Length <= 0 Then
            TESTNAME.Text = ""
            TESTCODE.Text = ""
            Exit Sub
        Else
            RC = FRC(0)
            TESTCODE.Text = RC("test_code")
            'ACdr.Close()
            'ACcmd.CommandText = "UPDATE STRANS SET QUN=0,TOT=0"
            'ACcmd.ExecuteNonQuery()
            'ACdr.Close()
            'dr.Close()
            'cmd.CommandText = "select * from sgroup where test_code='" & TESTCODE.Text & "'"
            'dr = cmd.ExecuteReader
            'While dr.Read
            '    ACcmd.CommandText = "update strans set qun=" & dr("qun") & " where item_code=" & dr("item_code")
            '    ACcmd.ExecuteNonQuery()
            'End While
            'FITEM.Clear()
            'cmdFITEM.Connection = ACcn
            'cmdFITEM.CommandType = CommandType.Text
            'cmdFITEM.CommandText = "select * FROM Strans "
            'adFITEM.SelectCommand = cmdFITEM
            'adFITEM.Fill(DBS, "fitem")
            'FITEM = DBS.Tables("fitem")
            'DBS.Tables("fitem").Clear()
            'adFITEM.Fill(DBS, "fitem")
            'FITEM = DBS.Tables("fitem")
            'ditem.DataSource = FITEM
            'Dim v As Integer = 0
            'While Not v = ditem.Columns.Count
            '    ditem.Columns(v).Visible = False
            '    v = v + 1
            'End While
            'ditem.Columns("ITEM_NAME").Visible = True
            'ditem.Columns("ITEM_NAME").HeaderText = "«·’‰›"
            'ditem.Columns("ITEM_NAME").Width = 100
            'ditem.Columns("PRICE").Visible = True
            'ditem.Columns("PRICE").HeaderText = "«·”⁄—"
            'ditem.Columns("PRICE").Width = 40
            'ditem.Columns("QUN").Visible = True
            'ditem.Columns("QUN").HeaderText = "«·ﬂ„Ì…"
            'ditem.Columns("QUN").Width = 40
            'ditem.Columns("TOT").Visible = True
            'ditem.Columns("TOT").HeaderText = "«·«Ã„«·Ï"
            'ditem.Columns("TOT").Width = 60
        End If
    End Sub

    Private Sub STOC1NAME_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles STOC1NAME.KeyDown

    End Sub

    Private Sub STOC1NAME_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles STOC1NAME.SelectedIndexChanged
        If STOC1NAME.Focused = False Then Exit Sub
        If STOC1NAME.Text = "" Then Exit Sub
        FRC = STOC1.Select("NAME='" & STOC1NAME.Text & "'")
        If FRC.Length <= 0 Then
            STOC1NAME.Text = ""
            STOC1CODE.Text = ""
            Exit Sub
        Else
            RC = FRC(0)
            STOC1CODE.Text = RC("code")
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        itemf()
        dr.Close()
        cmd.CommandText = "select max(sn) from Strans "
        dr = cmd.ExecuteReader
        dr.Read()
        If IsDBNull(dr(0)) = False Then
            sn.Text = Val(dr(0)) + 1
        Else
            sn.Text = 1
        End If
        PTOT.Text = 0
        DISSN.Text = 0
        Sdate.Value = Now
    End Sub
    Public Sub itemf()
        Dim ss As Double = 0

        ACdr.Close()
        ACcmd.CommandText = "delete * from scont "
        ACcmd.ExecuteNonQuery()

        ACcmd.CommandText = "UPDATE STRANS SET QUN=0,TOT=0,TQUN=0,TTEST=0,SPECNAME=0,SPECCODE=0"
        ACcmd.ExecuteNonQuery()
        fitem.Clear()
        cmdFITEM.Connection = ACcn
        cmdfitem.CommandType = CommandType.Text
        cmdFITEM.CommandText = "select * FROM Strans "
        adfitem.SelectCommand = cmdfitem
        adfitem.Fill(DBS, "fitem")
        fitem = DBS.Tables("fitem")
        DBS.Tables("fitem").Clear()
        adfitem.Fill(DBS, "fitem")
        fitem = DBS.Tables("fitem")
        ditem.DataSource = fitem
        Dim v As Integer = 0
        While Not v = ditem.Columns.Count
            ditem.Columns(v).Visible = False
            v = v + 1
        End While
        ditem.Columns("ITEM_NAME").Visible = True
        ditem.Columns("ITEM_NAME").HeaderText = "«·’‰›"
        ditem.Columns("ITEM_NAME").Width = 100
        ditem.Columns("PRICE").Visible = True
        ditem.Columns("PRICE").HeaderText = "«·”⁄—"
        ditem.Columns("PRICE").Width = 40
        ditem.Columns("QUN").Visible = True
        ditem.Columns("QUN").HeaderText = "«·ﬂ„Ì…"
        ditem.Columns("QUN").Width = 40
        ditem.Columns("TOT").Visible = True
        ditem.Columns("TOT").HeaderText = "«·«Ã„«·Ï"
        ditem.Columns("TOT").Width = 60
        'ditem.Columns("serl").Visible = True
        'ditem.Columns("serl").HeaderText = "”—Ì«·"
        'ditem.Columns("serl").Width = 60

    End Sub


    Private Sub ditem_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles ditem.CellBeginEdit
        MOST()

    End Sub

    Private Sub ditem_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ditem.CellContentClick


    End Sub
    Public Sub MOST()
        PTOT.Text = 0
        Dim R As Integer = 0
        While Not R = FITEM.Rows.Count
            RC = FITEM.Rows(R)
            RC.BeginEdit()
            RC.Item("tot") = Math.Round(Val(RC.Item("qun")) * Val(RC.Item("price")), 2)
            PTOT.Text = Val(PTOT.Text) + Math.Round(Val(RC.Item("qun")) * Val(RC.Item("price")), 2)

            RC.EndEdit()
            R = R + 1
        End While
        cmdb.DataAdapter = adFITEM
        adFITEM.Update(DBS, "fitem")
    End Sub

    Private Sub ditem_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ditem.CellEndEdit
        MOST()
    End Sub

    Private Sub ditem_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles ditem.CellMouseClick
        On Error Resume Next
        ITEMNAME.Text = ditem(("ITEM_NAME"), e.RowIndex).Value
        ITEMNAME_SelectedIndexChanged(ITEMNAME, e)
        ITEMCODE.Text = ditem(("ITEM_code"), e.RowIndex).Value
        price.Text = ditem(("price"), e.RowIndex).Value
        qun.Text = ditem(("qun"), e.RowIndex).Value
        tqun.Text = ditem(("tqun"), e.RowIndex).Value
        TTEST.Text = ditem(("ttest"), e.RowIndex).Value
        SPECNAME.Text = ditem(("specname"), e.RowIndex).Value
        SPECCODE.Text = ditem(("speccode"), e.RowIndex).Value
        Sdate.Value = ditem(("sdate"), e.RowIndex).Value
    End Sub
    Private Sub ditem_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ditem.MouseClick

        MOST()

    End Sub
    Public Sub TOT1()
        ACdr.Close()
        ACcmd.CommandText = "select sum (tot) from stoc_trans "
        ACdr = ACcmd.ExecuteReader
        ACdr.Read()
        PTOT.Text = ACdr(0)
    End Sub

    Private Sub ITEMCODE_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ITEMCODE.GotFocus
        'ITEMCODE.Text = ""
    End Sub

    Private Sub ITEMCODE_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ITEMCODE.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ITEMCODE.Focused = False Then Exit Sub
            If ITEMCODE.Text = "" Then Exit Sub
            Button8_Click(Button8, e)
            FRC = ITEM.Select("code='" & ITEMCODE.Text & "'")
            If FRC.Length <= 0 Then
                ITEMNAME.Text = ""
                ITEMCODE.Text = ""
                Exit Sub
            Else
                RC = FRC(0)
                ITEMNAME.Text = RC("name")
                price.Text = RC("price")
                dr.Close()
                cmd.CommandText = "SELECT SUM (QUN*FLG) FROM STRANSDET WHERE ITEM_CODE='" & ITEMCODE.Text & "'"
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    If IsDBNull(dr(0)) = False Then RSD.Text = dr(0) Else RSD.Text = 0
                End If
                qun.Focus()
                If MOVECODE.Text = "1" Or MOVECODE.Text = "8" Then
                    qun.Text = 1
                    FRC = FITEM.Select("item_code='" & ITEMCODE.Text & "'")
                    If FRC.Length <= 0 Then
                        Exit Sub
                    Else
                        RC = FRC(0)
                        RC.BeginEdit()
                        RC("qun") = qun.Text
                        RC("price") = price.Text
                        qun.Text = 0
                        ITEMCODE.Text = ""
                        ITEMCODE.Focus()
                        MOST()
                    End If
                    Button7_Click(Button7, e)
                End If


            End If

        End If
    End Sub

    Private Sub ITEMCODE_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ITEMCODE.TextChanged

    End Sub

    Private Sub qun_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles qun.KeyDown
        If e.KeyCode = Keys.Enter Then
            If qun.Focused = False Then Exit Sub
            If qun.Text = "" Then Exit Sub
            ADDTEST()

        End If

    End Sub

    Private Sub qun_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles qun.TextChanged
        RSDA.Text = Val(RSD.Text) + Val(Val(qun.Text) * Val(FLG.Text))
        TTEST.Text = Val(tqun.Text) * Val(qun.Text)
    End Sub

    Private Sub SUPNAME_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles SUPNAME.KeyDown

        If e.KeyCode = Keys.Enter Then
            FSAVE(SUPNAME.Text, "SSUP", 1)
        ElseIf e.KeyCode = Keys.Delete Then
            FSAVE(SUPNAME.Text, "sSUP", 2)
        End If
        If e.KeyCode = Keys.Enter Then
            FRC = SUP.Select("NAME='" & SUPNAME.Text & "'")
            If FRC.Length <= 0 Then
                SUPNAME.Text = ""
                SUPCODE.Text = ""
                Exit Sub
            Else
                RC = FRC(0)
                SUPCODE.Text = RC("code")
            End If
        End If
    End Sub

    Private Sub SUPNAME_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SUPNAME.SelectedIndexChanged
        If SUPNAME.Focused = False Then Exit Sub
        If SUPNAME.Text = "" Then Exit Sub
        FRC = SUP.Select("NAME='" & SUPNAME.Text & "'")
        If FRC.Length <= 0 Then
            SUPNAME.Text = ""
            SUPCODE.Text = ""
            Exit Sub
        Else
            RC = FRC(0)
            SUPCODE.Text = RC("code")
        End If
    End Sub


    Private Sub CUSTNAME_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CUSTNAME.KeyDown
        If e.KeyCode = Keys.Enter Then
            FSAVE(CUSTNAME.Text, "SCUST", 1)
        ElseIf e.KeyCode = Keys.Delete Then
            FSAVE(CUSTNAME.Text, "CUST", 2)
        End If
        If e.KeyCode = Keys.Enter Then
            FRC = CUST.Select("NAME='" & CUSTNAME.Text & "'")
            If FRC.Length <= 0 Then
                CUSTNAME.Text = ""
                CUSTCODE.Text = ""
                Exit Sub
            Else
                RC = FRC(0)
                CUSTCODE.Text = RC("code")
            End If
        End If
    End Sub

    Private Sub CUSTNAME_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CUSTNAME.SelectedIndexChanged
        If CUSTNAME.Focused = False Then Exit Sub
        If CUSTNAME.Text = "" Then Exit Sub
        FRC = CUST.Select("NAME='" & CUSTNAME.Text & "'")
        If FRC.Length <= 0 Then
            CUSTNAME.Text = ""
            CUSTCODE.Text = ""
            Exit Sub
        Else
            RC = FRC(0)
            CUSTCODE.Text = RC("code")
        End If
    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub PTOT_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PTOT.TextChanged
        DISSV.Text = Val(Val(DISSN.Text) * Val(PTOT.Text) * 0.01)
        PAY.Text = Val(PTOT.Text) - Val(DISSV.Text)
    End Sub

    Private Sub DISSN_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DISSN.TextChanged
        DISSV.Text = Val(Val(DISSN.Text) * Val(PTOT.Text) * 0.01)
        PAY.Text = Val(PTOT.Text) - Val(DISSV.Text)

    End Sub

    Private Sub DISSV_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DISSV.TextChanged
        PAY.Text = Val(PTOT.Text) - Val(DISSV.Text)

    End Sub

    Private Sub PAY_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PAY.TextChanged
        REST.Text = Val(PAY.Text) - Val(Val(PTOT.Text) - Val(DISSV.Text))
    End Sub
    Public Sub FTRANS()
        If SN.Text = "" Then MsgBox("«ﬂ » —ﬁ„ «·Õ—ﬂ…") : Exit Sub
        itemf()
        dr.Close()
        cmd.CommandText = "SELECT * FROM STRANS WHERE SN='" & SN.Text & "' "
        dr = cmd.ExecuteReader
        If dr.HasRows = True Then
            dr.Read()
            CUSTNAME.Text = dr("CUST_NAME")
            CUSTCODE.Text = dr("CUST_CODE")
            PAY.Text = dr("PAY")
            REST.Text = dr("REST")
            STOCNAME.Text = dr("STOC_NAME")
            STOCCODE.Text = dr("STOC_CODE")
            NOTE.Text = dr("NOTE")
            MOVEname.Text = dr("MOVE_name")
            MOVECODE.Text = dr("MOVE_CODE")
            SUPNAME.Text = dr("SUP_NAME")
            SUPCODE.Text = dr("SUP_CODE")
            SN.Text = dr("SN")
            Sdate.Value = dr("Sdate")
            PTOT.Text = dr("PTOT")
            DISSN.Text = dr("DISSN")
            DISSV.Text = dr("DISSV")
        Else
            MsgBox("Â–… «·›« Ê—… €Ì— „”Ã·…")
            Exit Sub
        End If
        dr.Close()
        ACdr.Close()
        cmd.CommandText = "select * from STRANSDET WHERE SN='" & SN.Text & "' "
        dr = cmd.ExecuteReader
        While dr.Read
            ACcmd.CommandText = "UPDATE Strans SET  PRICE='" & dr("price") & "',TOT='" & dr("TOT") & "',QUN='" & dr("qun") & "',TQUN='" & dr("Tqun") & "',TTEST='" & dr("TTEST") & "',SPECNAME='" & dr("SPECNAME") & "',SPECCODE='" & dr("SPECCODE") & "' WHERE ITEM_CODE=" & dr("ITEM_CODE")
            ACcmd.ExecuteNonQuery()
        End While

        dr.Close()
        ACdr.Close()
        cmd.CommandText = "select * from STRANscont WHERE SN='" & SN.Text & "' "
        dr = cmd.ExecuteReader
        While dr.Read
            ACcmd.CommandText = "insert into scont(cname,ccode,item_name,item_code,barcode,cont_v,sdate) values ('" & dr("cname") & "','" & dr("ccode") & "','" & dr("ITEM_NAME") & "','" & dr("ITEM_CODE") & "','" & dr("barcode") & "','" & dr("cont_v") & "','" & dr("sdate") & "')"
            ACcmd.ExecuteNonQuery()
        End While

        FITEM.Clear()
        cmdFITEM.Connection = ACcn
        cmdFITEM.CommandType = CommandType.Text
        cmdFITEM.CommandText = "select * FROM Strans "
        adFITEM.SelectCommand = cmdFITEM
        adFITEM.Fill(DBS, "fitem")
        FITEM = DBS.Tables("fitem")
        DBS.Tables("fitem").Clear()
        adFITEM.Fill(DBS, "fitem")
        FITEM = DBS.Tables("fitem")
        ditem.DataSource = FITEM
        Dim v As Integer = 0
        While Not v = ditem.Columns.Count
            ditem.Columns(v).Visible = False
            v = v + 1
        End While
        ditem.Columns("ITEM_NAME").Visible = True
        ditem.Columns("ITEM_NAME").HeaderText = "«·’‰›"
        ditem.Columns("ITEM_NAME").Width = 100
        ditem.Columns("PRICE").Visible = True
        ditem.Columns("PRICE").HeaderText = "«·”⁄—"
        ditem.Columns("PRICE").Width = 40
        ditem.Columns("QUN").Visible = True
        ditem.Columns("QUN").HeaderText = "«·ﬂ„Ì…"
        ditem.Columns("QUN").Width = 40
        ditem.Columns("TOT").Visible = True
        ditem.Columns("TOT").HeaderText = "«·«Ã„«·Ï"
        ditem.Columns("TOT").Width = 60

    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        fillTextBox(Me)
        dr.Close()
        cmd.CommandText = "SELECT * FROM STRANS WHERE SN='" & SN.Text & "' "
        dr = cmd.ExecuteReader
        If dr.HasRows = True Then
            Dim N As String = MsgBox("Â·  —Ìœ «· ⁄œÌ·", MsgBoxStyle.YesNo)
            If N = vbNo Then Exit Sub
            dr.Close()
            cmd.CommandText = "DELETE FROM STRANS WHERE SN='" & SN.Text & "' "
            cmd.ExecuteNonQuery()
            cmd.CommandText = "DELETE FROM STRANSDET WHERE SN='" & SN.Text & "' "
            cmd.ExecuteNonQuery()
            cmd.CommandText = "DELETE FROM stranscont WHERE SN='" & SN.Text & "' "
            cmd.ExecuteNonQuery()
        End If
        FRC = MOVET.Select("NAME='" & MOVEname.Text & "'")
        RC = FRC(0)
        MOVECODE.Text = RC("code")
        FLG.Text = RC("FLG")
        dr.Close()
        cmd.CommandText = "INSERT INTO [ASILLAB].[dbo].[STRANS]([CUST_NAME],[CUST_CODE],[DISSN],[DISSV],[PAY],[REST],[STOC_NAME],[STOC_CODE],[NOTE],[MOVE_NAME],[MOVE_CODE],[SUP_NAME],[SUP_CODE],[SN],[SDATE],[PTOT],USR)VALUES ('" & CUSTNAME.Text & " ','" & CUSTCODE.Text & "','" & DISSN.Text & "','" & DISSV.Text & "','" & PAY.Text & "','" & REST.Text & "','" & STOCNAME.Text & "','" & STOCCODE.Text & "','" & NOTE.Text & "','" & MOVEname.Text & "','" & MOVECODE.Text & "','" & SUPNAME.Text & "','" & SUPCODE.Text & "','" & SN.Text & "','" & ChangeFormat(Sdate.Value) & "','" & PTOT.Text & "','" & USR & "')"
        cmd.ExecuteNonQuery()
        ACdr.Close()
        ACcmd.CommandText = "select * from Strans WHERE QUN>0 "
        ACdr = ACcmd.ExecuteReader
        While ACdr.Read
            cmd.CommandText = "INSERT INTO [ASILLAB].[dbo].[STRANSDET](TQUN,TTEST,SPECNAME,SPECCODE,[SN],[ITEM_NAME],[ITEM_CODE],[PRICE],[TOT],[QUN],[FLG],[SDATE])VALUES ('" & ACdr("TQUN") & " ','" & ACdr("TTEST") & " ','" & ACdr("SPECNAME") & " ','" & ACdr("SPECCODE") & " ','" & SN.Text & " ','" & ACdr("ITEM_NAME") & "','" & ACdr("ITEM_CODE") & "','" & ACdr("price") & "','" & ACdr("TOT") & "','" & ACdr("qun") & "','" & FLG.Text & "','" & ChangeFormat(ACdr("sdate")) & "')"
            cmd.ExecuteNonQuery()
        End While
        '===================Õ›Ÿ «·»«—ﬂÊœ Ê «·„ﬂÊ‰
        dr.Close()
        cmd.CommandText = "select max(barcode) from stranscont where SN='" & SN.Text & "'"
        dr = cmd.ExecuteReader
        dr.Read()

        Dim barc As Integer = 0
        ACdr.Close()
        ACcmd.CommandText = "select * from scont order by barcode desc"
        ACdr = ACcmd.ExecuteReader
        While ACdr.Read
            dr.Close()
            cmd.CommandText = "select max(barcode) from stranscont "
            dr = cmd.ExecuteReader
            dr.Read()
            Dim barcode As Integer = nulls(dr(0))
            If nulls(ACdr("barcode")) = 0 Then
                barc = barcode + 1
            Else
                barc = ACdr("barcode")
            End If
            dr.Close()
            cmd.CommandText = "INSERT INTO [dbo].[stranscont] ([item_name],[item_code],[cname],[ccode],[cont_v],[sdate],[barcode],[sn])VALUES ('" & ACdr("item_name") & "','" & ACdr("item_code") & "','" & ACdr("cname") & "','" & ACdr("ccode") & "','" & ACdr("cont_v") & "','" & ChangeFormat(ACdr("sdate")) & "','" & barc & "','" & SN.Text & "')"
            cmd.ExecuteNonQuery()
        End While
        barc = 0
        '========================»«ﬂÊœ ›«Ì·
        dr.Close()
        cmd.CommandText = "delete from stransspec where SN='" & SN.Text & "'"
        cmd.ExecuteNonQuery()
        ACdr.Close()
        ACcmd.CommandText = "select * from STRANS WHERE QUN>0 order by ITEM_NAME desc"
        ACdr = ACcmd.ExecuteReader
        While ACdr.Read
            Dim N As Integer = 0
            While Not ACdr("QUN") = N
                dr.Close()
                cmd.CommandText = "select max(barcode) from stransspec "
                dr = cmd.ExecuteReader
                dr.Read()
                Dim barcode As Integer = nulls(dr(0))
                If nulls(dr(0)) = 0 Then
                    barc = barcode + 1
                Else
                    barc = dr(0)
                End If

                dr.Close()
                cmd.CommandText = "INSERT INTO [dbo].[stransSPEC] ([item_name],[item_code],[SPECname],[SPECcode],[TQUN],[sdate],[barcode],[sn],price)VALUES ('" & ACdr("item_name") & "','" & ACdr("item_code") & "','" & ACdr("SPECname") & "','" & ACdr("SPECcode") & "','" & ACdr("TQUN") & "','" & ChangeFormat(ACdr("sdate")) & "','" & barc & "','" & SN.Text & "','" & ACdr("price") & "')"
                cmd.ExecuteNonQuery()
                N += 1
            End While
        End While
        MsgBox(" „ ⁄„·Ì… «·Õ›Ÿ", MsgBoxStyle.Information)
    End Sub

    Private Sub FINDCODEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FINDCODEToolStripMenuItem.Click
        Dim N As Integer = InputBox("«·—Ã«¡ ﬂ «»… —ﬁ„ «·Õ—ﬂ…ø")
        SN.Text = N
        FTRANS()

    End Sub

    Private Sub RSD_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RSD.TextChanged

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        dr.Close()
        cmd.CommandText = "SELECT * FROM STRANS WHERE SN='" & SN.Text & "' "
        dr = cmd.ExecuteReader
        If dr.HasRows = True Then
            Dim N As String = MsgBox("Â·  —Ìœ «·Õ–›", MsgBoxStyle.YesNo)
            If N = vbNo Then Exit Sub
            dr.Close()
            cmd.CommandText = "DELETE FROM STRANS WHERE SN='" & SN.Text & "' "
            cmd.ExecuteNonQuery()
            cmd.CommandText = "DELETE FROM STRANSDET WHERE SN='" & SN.Text & "' "
            cmd.ExecuteNonQuery()
            MsgBox(" „  ⁄„·Ì… «·Õ–›", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Dim YY As String = "where sdate between '" & ChangeFormat(d1.Value) & "' and '" & ChangeFormat(d2.Value) & "'"
        If CCUST.Checked = True Then YY = YY & " AND CUST_CODE='" & CUSTCODE.Text & "' AND FLG='-1'"
        If CPAY.Checked = True Then YY = YY & " AND PAY='" & PAY.Text & "'"
        If CREST.Checked = True Then YY = YY & " AND REST='" & REST.Text & "'"
        If CSTOC_CODE.Checked = True Then YY = YY & " AND STOC_NAME='" & STOCNAME.Text & "'"
        If CNOTE.Checked = True Then YY = YY & " AND NOTE='" & NOTE.Text & "'"
        If cMOVEcode.Checked = True Then YY = YY & " AND MOVE_name='" & MOVEname.Text & "'"
        If CSUP.Checked = True Then YY = YY & " AND SUP_NAME='" & SUPNAME.Text & "'"
        If CSN.Checked = True Then YY = YY & " AND SN='" & SN.Text & "'"
        If CSDATE.Checked = True Then YY = YY & " AND SDATE='" & ChangeFormat(Sdate.Value) & "'"
        If CPTOT.Checked = True Then YY = YY & " AND PTOT='" & PTOT.Text & "'"
        If CDISSN.Checked = True Then YY = YY & " AND DISSN='" & DISSN.Text & "'"
        If CDISSV.Checked = True Then YY = YY & " AND DISSV='" & DISSV.Text & "'"
        If CITEM_NAME.Checked = True Then YY = YY & " AND ITEM_NAME='" & ITEMNAME.Text & "'"
        If CQUN.Checked = True Then YY = YY & " AND QUN='" & qun.Text & "'"
        If CPRICE.Checked = True Then YY = YY & " AND PRICE='" & price.Text & "'"

        cmdTRAN.Connection = CN
        cmdTRAN.CommandText = "select stoc_name,pay,rest,note,SDATE,SN,MOVE_name,PTOT,SUP_name,DISSV,CUST_name,CUST_name,flg from VSTOC " & YY & "GROUP BY stoc_name,pay,rest,note,SDATE,SN,MOVE_name,PTOT,SUP_name,DISSV,CUST_name,CUST_name,flg"
        adTRAN.SelectCommand = cmdTRAN
        adTRAN.Fill(DBS, "TRAN")
        TRAN = DBS.Tables("TRAN")
        DBS.Tables("TRAN").Clear()
        adTRAN.Fill(DBS, "TRAN")
        TRAN = DBS.Tables("TRAN")
        DataGridView1.DataSource = TRAN
        Dim v As Integer = 0
        While Not v = DataGridView1.Columns.Count
            DataGridView1.Columns(v).Visible = False
            v = v + 1
        End While
        DataGridView1.Columns("SDATE").Visible = True
        DataGridView1.Columns("SDATE").HeaderText = "«· «—ÌŒ"
        DataGridView1.Columns("SN").Visible = True
        DataGridView1.Columns("SN").HeaderText = "«·ﬂÊœ"
        DataGridView1.Columns("SN").Width = 50
        DataGridView1.Columns("MOVE_name").Visible = True
        DataGridView1.Columns("MOVE_name").HeaderText = "«·Õ—ﬂ…"
        DataGridView1.Columns("PTOT").Visible = True
        DataGridView1.Columns("PTOT").HeaderText = "«·«Ã„«·Ï"
        DataGridView1.Columns("SUP_name").Visible = True
        DataGridView1.Columns("SUP_name").HeaderText = "«·„Ê—œ"
        DataGridView1.Columns("DISSV").Visible = True
        DataGridView1.Columns("DISSV").HeaderText = "«·Œ’„"
        DataGridView1.Columns("DISSV").Width = 50
        DataGridView1.Columns("CUST_name").Visible = True
        DataGridView1.Columns("CUST_name").HeaderText = "«·⁄„Ì·"
        Dim oj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        oj.Load(Application.StartupPath & "\vstoc.rpt")
        oj.Database.Tables(0).SetDataSource(TRAN)
        rp.CrystalReportViewer1.ReportSource = oj
        rp.Show() : rp.Focus()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        SN.Text = DataGridView1(("SN"), e.RowIndex).Value
        FTRANS()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim YY As String = "where sdate between '" & ChangeFormat(d1.Value) & "' and '" & ChangeFormat(d2.Value) & "'"
        If CCUST.Checked = True Then YY = YY & " AND CUST_CODE='" & CUSTCODE.Text & "' AND FLG='-1'"
        If CPAY.Checked = True Then YY = YY & " AND PAY='" & PAY.Text & "'"
        If CREST.Checked = True Then YY = YY & " AND REST='" & REST.Text & "'"
        If CSTOC_CODE.Checked = True Then YY = YY & " AND STOC_NAME='" & STOCNAME.Text & "'"
        If CNOTE.Checked = True Then YY = YY & " AND NOTE='" & NOTE.Text & "'"
        If cMOVEcode.Checked = True Then YY = YY & " AND MOVE_name='" & MOVEname.Text & "'"
        If CSUP.Checked = True Then YY = YY & " AND SUP_NAME='" & SUPNAME.Text & "'"
        If CSN.Checked = True Then YY = YY & " AND SN='" & SN.Text & "'"
        If CSDATE.Checked = True Then YY = YY & " AND SDATE='" & ChangeFormat(Sdate.Value) & "'"
        If CPTOT.Checked = True Then YY = YY & " AND PTOT='" & PTOT.Text & "'"
        If CDISSN.Checked = True Then YY = YY & " AND DISSN='" & DISSN.Text & "'"
        If CDISSV.Checked = True Then YY = YY & " AND DISSV='" & DISSV.Text & "'"
        If CITEM_NAME.Checked = True Then YY = YY & " AND ITEM_NAME='" & ITEMNAME.Text & "'"
        If CQUN.Checked = True Then YY = YY & " AND QUN='" & qun.Text & "'"
        If CPRICE.Checked = True Then YY = YY & " AND PRICE='" & price.Text & "'"

        cmdTRAN.Connection = CN
        cmdTRAN.CommandText = "select * from VSTOC " & YY
        adTRAN.SelectCommand = cmdTRAN
        adTRAN.Fill(DBS, "TRAN")
        TRAN = DBS.Tables("TRAN")
        DBS.Tables("TRAN").Clear()
        adTRAN.Fill(DBS, "TRAN")
        TRAN = DBS.Tables("TRAN")
        DataGridView1.DataSource = TRAN
        Dim v As Integer = 0
        While Not v = DataGridView1.Columns.Count
            DataGridView1.Columns(v).Visible = False
            v = v + 1
        End While
        DataGridView1.Columns("SDATE").Visible = True
        DataGridView1.Columns("SDATE").HeaderText = "«· «—ÌŒ"
        DataGridView1.Columns("SN").Visible = True
        DataGridView1.Columns("SN").HeaderText = "«·ﬂÊœ"
        DataGridView1.Columns("SN").Width = 50
        DataGridView1.Columns("MOVE_name").Visible = True
        DataGridView1.Columns("MOVE_name").HeaderText = "«·Õ—ﬂ…"
        DataGridView1.Columns("PTOT").Visible = True
        DataGridView1.Columns("PTOT").HeaderText = "«·«Ã„«·Ï"
        DataGridView1.Columns("SUP_name").Visible = True
        DataGridView1.Columns("SUP_name").HeaderText = "«·„Ê—œ"
        DataGridView1.Columns("DISSV").Visible = True
        DataGridView1.Columns("DISSV").HeaderText = "«·Œ’„"
        DataGridView1.Columns("DISSV").Width = 50
        DataGridView1.Columns("CUST_name").Visible = True
        DataGridView1.Columns("CUST_name").HeaderText = "«·⁄„Ì·"
        Dim oj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        oj.Load(Application.StartupPath & "\vstocdet.rpt")
        oj.Database.Tables(0).SetDataSource(TRAN)
        rp.CrystalReportViewer1.ReportSource = oj
        rp.Show() : rp.Focus()
    End Sub

    Private Sub group_code_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles group_code.TextChanged

    End Sub

    Private Sub group_name_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles group_name.KeyDown
        If e.KeyCode = Keys.Enter Then
            FSAVE(group_name.Text, "Sgroup", 1)
        ElseIf e.KeyCode = Keys.Delete Then
            FSAVE(group_name.Text, "sgroup", 2)
        End If
        If e.KeyCode = Keys.Enter Then

        End If
    End Sub

    Private Sub group_name_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles group_name.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        fillTextBox(Me)
        dr.Close()
        cmd.CommandText = "SELECT * FROM sgTRANS WHERE cust_code='" & group_code.Text & "' "
        dr = cmd.ExecuteReader
        If dr.HasRows = True Then
            Dim N As String = MsgBox("Â·  —Ìœ «· ⁄œÌ·", MsgBoxStyle.YesNo)
            If N = vbNo Then Exit Sub
            dr.Close()
            cmd.CommandText = "DELETE FROM sgTRANS WHERE cust_code='" & group_code.Text & "' "
            cmd.ExecuteNonQuery()
            cmd.CommandText = "DELETE FROM sgTRANSDET WHERE cust_code='" & group_code.Text & "' "
            cmd.ExecuteNonQuery()
        End If
        FRC = MOVET.Select("NAME='" & MOVEname.Text & "'")
        RC = FRC(0)
        MOVECODE.Text = RC("code")
        FLG.Text = RC("FLG")
        dr.Close()
        cmd.CommandText = "INSERT INTO [ASILLAB].[dbo].[SgTRANS]([CUST_NAME],[CUST_CODE],[DISSN],[DISSV],[PAY],[REST],[STOC_NAME],[STOC_CODE],[NOTE],[MOVE_NAME],[MOVE_CODE],[SUP_NAME],[SUP_CODE],[SN],[SDATE],[PTOT])VALUES ('" & group_name.Text & " ','" & group_code.Text & "','" & DISSN.Text & "','" & DISSV.Text & "','" & PAY.Text & "','" & REST.Text & "','" & STOCNAME.Text & "','" & STOCCODE.Text & "','" & NOTE.Text & "','" & MOVEname.Text & "','" & MOVECODE.Text & "','" & SUPNAME.Text & "','" & SUPCODE.Text & "','" & SN.Text & "','" & ChangeFormat(Sdate.Value) & "','" & PTOT.Text & "')"
        cmd.ExecuteNonQuery()
        ACdr.Close()
        ACcmd.CommandText = "select * from Strans WHERE QUN>0 "
        ACdr = ACcmd.ExecuteReader
        While ACdr.Read
            cmd.CommandText = "INSERT INTO [ASILLAB].[dbo].[sgTRANSDET]([SN],[ITEM_NAME],[ITEM_CODE],[PRICE],[TOT],[QUN],[FLG],[SDATE],cust_name,cust_code)VALUES ('" & SN.Text & " ','" & ACdr("ITEM_NAME") & "','" & ACdr("ITEM_CODE") & "','" & ACdr("price") & "','" & ACdr("TOT") & "','" & ACdr("qun") & "','" & FLG.Text & "','" & ChangeFormat(Sdate.Value) & "','" & group_name.Text & " ','" & group_code.Text & "')"
            cmd.ExecuteNonQuery()
        End While
        MsgBox(" „ ⁄„·Ì… «·Õ›Ÿ", MsgBoxStyle.Information)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim YY As String = "where sdate between '" & ChangeFormat(d1.Value) & "' and '" & ChangeFormat(d2.Value) & "'"
        If CCUST.Checked = True Then YY = YY & " AND CUST_CODE='" & CUSTCODE.Text & "' AND FLG='-1'"
        If CPAY.Checked = True Then YY = YY & " AND PAY='" & PAY.Text & "'"
        If CREST.Checked = True Then YY = YY & " AND REST='" & REST.Text & "'"
        If CSTOC_CODE.Checked = True Then YY = YY & " AND STOC_NAME='" & STOCNAME.Text & "'"
        If CNOTE.Checked = True Then YY = YY & " AND NOTE='" & NOTE.Text & "'"
        YY = YY & " AND MOVE_name='" & MOVEname.Text & "'"
        If CSUP.Checked = True Then YY = YY & " AND SUP_NAME='" & SUPNAME.Text & "'"
        If CSN.Checked = True Then YY = YY & " AND SN='" & SN.Text & "'"
        If CSDATE.Checked = True Then YY = YY & " AND SDATE='" & ChangeFormat(Sdate.Value) & "'"
        If CPTOT.Checked = True Then YY = YY & " AND PTOT='" & PTOT.Text & "'"
        If CDISSN.Checked = True Then YY = YY & " AND DISSN='" & DISSN.Text & "'"
        If CDISSV.Checked = True Then YY = YY & " AND DISSV='" & DISSV.Text & "'"
        If CITEM_NAME.Checked = True Then YY = YY & " AND ITEM_NAME='" & ITEMNAME.Text & "'"
        If CQUN.Checked = True Then YY = YY & " AND QUN='" & qun.Text & "'"
        If CPRICE.Checked = True Then YY = YY & " AND PRICE='" & price.Text & "'"

        cmdTRAN.Connection = CN
        cmdTRAN.CommandText = "select item_name,minm,SUM (QUN) as qun,SUM (tot) as tot from VSTOC " & YY & "GROUP BY item_name,minm"
        adTRAN.SelectCommand = cmdTRAN
        adTRAN.Fill(DBS, "TRAN")
        TRAN = DBS.Tables("TRAN")
        DBS.Tables("TRAN").Clear()
        adTRAN.Fill(DBS, "TRAN")
        TRAN = DBS.Tables("TRAN")

        Dim oj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        oj.Load(Application.StartupPath & "\srsd.rpt")
        oj.Database.Tables(0).SetDataSource(TRAN)
        rp.CrystalReportViewer1.ReportSource = oj
        rp.Show() : rp.Focus()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim YY As String = "where sdate between '" & ChangeFormat(d1.Value) & "' and '" & ChangeFormat(d2.Value) & "'"
        If CCUST.Checked = True Then YY = YY & " AND CUST_CODE='" & CUSTCODE.Text & "' AND FLG='-1'"
        If CPAY.Checked = True Then YY = YY & " AND PAY='" & PAY.Text & "'"
        If CREST.Checked = True Then YY = YY & " AND REST='" & REST.Text & "'"
        If CSTOC_CODE.Checked = True Then YY = YY & " AND STOC_NAME='" & STOCNAME.Text & "'"
        If CNOTE.Checked = True Then YY = YY & " AND NOTE='" & NOTE.Text & "'"
        If cMOVEcode.Checked = True Then YY = YY & " AND MOVE_name='" & MOVEname.Text & "'"
        If CSUP.Checked = True Then YY = YY & " AND SUP_NAME='" & SUPNAME.Text & "'"
        If CSN.Checked = True Then YY = YY & " AND SN='" & SN.Text & "'"
        If CSDATE.Checked = True Then YY = YY & " AND SDATE='" & ChangeFormat(Sdate.Value) & "'"
        If CPTOT.Checked = True Then YY = YY & " AND PTOT='" & PTOT.Text & "'"
        If CDISSN.Checked = True Then YY = YY & " AND DISSN='" & DISSN.Text & "'"
        If CDISSV.Checked = True Then YY = YY & " AND DISSV='" & DISSV.Text & "'"
        If CITEM_NAME.Checked = True Then YY = YY & " AND ITEM_NAME='" & ITEMNAME.Text & "'"
        If CQUN.Checked = True Then YY = YY & " AND QUN='" & qun.Text & "'"
        If CPRICE.Checked = True Then YY = YY & " AND PRICE='" & price.Text & "'"

        cmdcard.Connection = CN
        cmdcard.CommandText = "select * from VSTOC " & YY & " order by item_name,sdate,sn"
        adcard.SelectCommand = cmdcard
        adcard.Fill(DBS, "card")
        card = DBS.Tables("card")
        DBS.Tables("card").Clear()
        adcard.Fill(DBS, "card")
        card = DBS.Tables("card")
        dr.Close()
        Dim xx As Integer = 0
        Dim quns, tots As Double
        Dim xs As String = ""
        Dim xc As String = ""
        While Not xx = card.Rows.Count
            RC = card.Rows(xx)
            If RC("item_name") <> xs And RC("specname") <> xc Then
                quns = 0
                tots = 0
                dr.Close()
                xs = RC("item_name")
                xc = RC("specname")
                cmd.CommandText = "select sum (tot*flg*-1),sum(qun*flg) from VSTOC where item_name='" & xs & "' and sdate <'" & ChangeFormat(d1.Value) & "'"
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows = True Then
                    If IsDBNull(dr(1)) = True Then quns = 0 Else quns = dr(1)
                    If IsDBNull(dr(0)) = True Then tots = 0 Else tots = dr(0)
                End If

            End If
            RC.BeginEdit()
            RC("quns") = quns
            RC("tots") = tots
            RC.EndEdit()
            quns = RC("quns") + (RC("flg") * RC("qun"))
            tots = RC("tots") + (RC("flg") * RC("tot") * -1)
            xx += 1
        End While
        Dim oj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        oj.Load(Application.StartupPath & "\item card.rpt")
        oj.Database.Tables(0).SetDataSource(card)
        rp.CrystalReportViewer1.ReportSource = oj
        rp.Show() : rp.Focus()
    End Sub

    Private Sub NewCustToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewCustToolStripMenuItem.Click
        Dim n1 As Integer
        n1 = InputBox("")
        If n1 <> 5011545 Then Exit Sub
        dr1.Close()
        cmd1.CommandText = "delete from SGRITEM "
        cmd1.ExecuteNonQuery()
        cmd1.CommandText = "delete from sgroup "
        cmd1.ExecuteNonQuery()
        cmd1.CommandText = "delete from sgtrans "
        cmd1.ExecuteNonQuery()
        cmd1.CommandText = "delete from sgtransdet "
        cmd1.ExecuteNonQuery()
        cmd1.CommandText = "delete from SITEM "
        cmd1.ExecuteNonQuery()
        cmd1.CommandText = "delete from SMSTOC "
        cmd1.ExecuteNonQuery()
        cmd1.CommandText = "delete from SSTOC "
        cmd1.ExecuteNonQuery()
        cmd1.CommandText = "delete from SSUP "
        cmd1.ExecuteNonQuery()
        cmd1.CommandText = "delete from STRANS "
        cmd1.ExecuteNonQuery()
        cmd1.CommandText = "delete from STRANSDET "
        cmd1.ExecuteNonQuery()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        'Dim s2 As Integer = 0

        'Dim n As Int16
        'dr.Close()
        'Dim D As Date = Now
        'LBILL.time1.Text = D.TimeOfDay.ToString
        'LBILL.date1.Text = D.Date.ToShortDateString
        ''cash.Text = -1 * Val(REST.Text)
        'LBILL.crd.Text = 0
        'dr.Close()
        'cmd.CommandText = "select * from lsub where sub_code='1'"
        'dr = cmd.ExecuteReader
        'dr.Read()
        'LBILL.sub_name.Text = dr("sub_name")

        'ACdr.Close()
        'ACcmd.CommandText = "select * from srv "
        'ACdr = ACcmd.ExecuteReader
        'ACdr.Read()
        'If ACdr("CASH") > 0 Then
        '    LBILL.id.Text = ACdr("CASH")

        'End If

        'dr.Close()
        'cmd.CommandText = "select * from lsub where sub_code='1'"
        'dr = cmd.ExecuteReader
        'While dr.Read
        '    If dr("flg") = 1 Then LBILL.flg.Checked = True Else LBILL.flg.Checked = False
        '    LBILL.main_code.Text = dr("main_code")
        '    LBILL.sub_name.Text = dr("sub_name")
        'End While
        'dr1.Close()
        'cmd1.CommandText = "select cust_name,ptot,flg,sn from vstoc where sdate='" & ChangeFormat(Now) & "' and flg=-1 group by  cust_name,ptot,flg,sn "
        'dr1 = cmd1.ExecuteReader
        'dr.Close()
        'While dr1.Read
        '    LBILL.FCASH1()
        '    dr.Close()
        '    cmd.CommandText = "insert into lcash ([main_name],[main_code],[sub_code],[sub_name],[flg],[cash],[crd],[time1],[date1],[id],[notse],usr,shift,save_name,save_code) values ('" & LBILL.main_name.Text & " ','" & LBILL.main_code.Text & "','" & LBILL.sub_code.Text & "','" & LBILL.sub_name.Text & "','1','" & dr1("ptot") & "','0','" & LBILL.time1.Text & "','" & ChangeFormat(Sdate.Text) & "','" & LBILL.id.Text & "',' »Ì⁄ „” ·“„«  ··⁄„Ì·  " & dr1("cust_name") & "   —ﬁ„ «·›« Ê—…   " & dr1("sn") & "','" & USR & "','" & SHF & "','" & LBILL.save_name.Text & "','" & LBILL.save_code.Text & "' )"
        '    cmd.ExecuteNonQuery()
        'End While
        'dr.Close()
        'cmd.CommandText = "select * from lsub where sub_code='7'"
        'dr = cmd.ExecuteReader
        'While dr.Read
        '    If dr("flg") = 1 Then LBILL.flg.Checked = True Else LBILL.flg.Checked = False
        '    LBILL.main_code.Text = dr("main_code")
        '    LBILL.sub_name.Text = dr("sub_name")
        'End While
        'dr1.Close()
        'cmd1.CommandText = "select  sup_name,ptot,flg,sn  from vstoc where sdate='" & ChangeFormat(Now) & "' and flg=1 group by  sup_name,ptot,flg,sn "
        'dr1 = cmd1.ExecuteReader
        'dr.Close()
        'While dr1.Read
        '    LBILL.FCASH1()
        '    dr.Close()
        '    cmd.CommandText = "insert into lcash ([main_name],[main_code],[sub_code],[sub_name],[flg],[cash],[crd],[time1],[date1],[id],[notse],usr,shift,save_name,save_code) values ('" & LBILL.main_name.Text & " ','" & LBILL.main_code.Text & "','" & LBILL.sub_code.Text & "','" & LBILL.sub_name.Text & "','-1','" & dr1("ptot") & "','0','" & LBILL.time1.Text & "','" & ChangeFormat(Sdate.Text) & "','" & LBILL.id.Text & "',' ‘—«¡ „” ·“„«  „‰ «·„Ê—œ  " & dr1("sup_name") & "   —ﬁ„ «·›« Ê—…   " & dr1("sn") & "','" & USR & "','" & SHF & "','" & LBILL.save_name.Text & "','" & LBILL.save_code.Text & "' )"
        '    cmd.ExecuteNonQuery()
        'End While
        'dr.Close()
        'If lng = "AR" Then MsgBox(" „  ⁄„·Ì… «·Õ›Ÿ »‰Ã«Õ", MsgBoxStyle.Information) Else MsgBox("IT'S SAVED", MsgBoxStyle.Information)
        Dim YY As String = "where sdate between '" & ChangeFormat(d1.Value) & "' and '" & ChangeFormat(d2.Value) & "'"
        If CCUST.Checked = True Then YY = YY & " AND CUST_CODE='" & CUSTCODE.Text & "' AND FLG='-1'"
        If CPAY.Checked = True Then YY = YY & " AND PAY='" & PAY.Text & "'"
        If CREST.Checked = True Then YY = YY & " AND REST='" & REST.Text & "'"
        If CSTOC_CODE.Checked = True Then YY = YY & " AND STOC_NAME='" & STOCNAME.Text & "'"
        If CNOTE.Checked = True Then YY = YY & " AND NOTE='" & NOTE.Text & "'"
        If CSUP.Checked = True Then YY = YY & " AND SUP_NAME='" & SUPNAME.Text & "'"
        If CSN.Checked = True Then YY = YY & " AND SN='" & SN.Text & "'"
        If CSDATE.Checked = True Then YY = YY & " AND SDATE='" & ChangeFormat(Sdate.Value) & "'"
        If CPTOT.Checked = True Then YY = YY & " AND PTOT='" & PTOT.Text & "'"
        If CDISSN.Checked = True Then YY = YY & " AND DISSN='" & DISSN.Text & "'"
        If CDISSV.Checked = True Then YY = YY & " AND DISSV='" & DISSV.Text & "'"
        If CITEM_NAME.Checked = True Then YY = YY & " AND ITEM_NAME='" & ITEMNAME.Text & "'"
        If CQUN.Checked = True Then YY = YY & " AND QUN='" & qun.Text & "'"
        If CPRICE.Checked = True Then YY = YY & " AND PRICE='" & price.Text & "'"

        cmdTRAN.Connection = CN
        cmdTRAN.CommandText = "select item_name,minm,SUM (QUN*flg) as qun,SUM (tot*flg*-1) as tot,specname from VSTOC " & YY & "GROUP BY item_name,minm,specname"
        adTRAN.SelectCommand = cmdTRAN
        adTRAN.Fill(DBS, "TRAN")
        TRAN = DBS.Tables("TRAN")
        DBS.Tables("TRAN").Clear()
        adTRAN.Fill(DBS, "TRAN")
        TRAN = DBS.Tables("TRAN")

        Dim oj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        oj.Load(Application.StartupPath & "\srsd.rpt")
        oj.Database.Tables(0).SetDataSource(TRAN)
        rp.CrystalReportViewer1.ReportSource = oj
        rp.Show() : rp.Focus()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        saveitem()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FSAVE(SUPNAME.Text, "SSUP", 1)
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FSAVE(CUSTNAME.Text, "SCUST", 1)

    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim W As Integer = Convert.ToInt32("150")
        Dim H As Integer = Convert.ToInt32("37")

        ACdr.Close()
        ACcmd.CommandText = "select * from srv"
        ACdr = ACcmd.ExecuteReader
        ACdr.Read()
        PrintPreviewDialog1.Document = PrintDocument1
        PrintDialog1.PrinterSettings.PrinterName = ACdr("prnt")
        PrintDialog1.Document = PrintDocument1
        Dim na As Integer = 0
        Dim i As Integer = 0
        While Not i = FITEM.Rows.Count
            na = 0
            While Not na = FITEM.Rows(i)("qun")
                ITEMNAME.Text = FITEM.Rows(i)("ITEM_name")
                bar1.Alignment = BarcodeLib.AlignmentPositions.CENTER
                Dim type As BarcodeLib.TYPE = BarcodeLib.TYPE.UNSPECIFIED
                type = BarcodeLib.TYPE.CODE128
                bar1.IncludeLabel = True
                barco.Image = bar1.Encode(type, FITEM.Rows(i)("ITEM_code"), W, H)
                PrintDocument1.Print()
                na += 1
            End While
            i += 1
        End While
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim f As New Font("arial", 6, FontStyle.Regular)
        Dim f1 As New Font("arial", 8, FontStyle.Regular)
        e.Graphics.DrawString("(" & Math.Round(Val(price.Text), 0) & ")", f1, Brushes.Black, 5, 30)
        e.Graphics.DrawString(ITEMNAME.Text, f1, Brushes.Black, 40, 30)
        e.Graphics.DrawString("«·⁄Ê«„Ï ·· Ã«—… Ê «· Ê“Ì⁄", f1, Brushes.Black, 40, 38)
        e.Graphics.DrawImage(barco.Image, 10, 0)


    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Dim n As String = MsgBox("Â·  —Ìœ «· ⁄œÌ· ø", MsgBoxStyle.YesNo)
        If n = vbNo Then Exit Sub
        Dim nnn As Double = InputBox("«·—Ã«¡ «œŒ«· «·”⁄—")
        dr.Close()
        cmd.CommandText = "update SITEM set price='" & nnn & "' where    NAME='" & ITEMNAME.Text & "'"
        cmd.ExecuteNonQuery()
        dr.Close()
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        dr.Close()
        ACdr.Close()
        ACcmd.CommandText = "delete * from strans"
        ACcmd.ExecuteNonQuery()
        cmd.CommandText = "select * from Sitem "
        dr = cmd.ExecuteReader
        While dr.Read
            ACcmd.CommandText = "insert into Strans (ITEM_code,ITEM_name,qun,PRICE,tot) values ('" & dr("code") & "' ,'" & dr("name") & "','0','" & dr("price") & "','0') "
            ACcmd.ExecuteNonQuery()
        End While

        filla("SITEM")
    End Sub

    Private Sub Button10_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Dim n As String = MsgBox("Â·  —Ìœ Õ›Ÿ „ﬂÊ‰«  «· Õ«·Ì·", MsgBoxStyle.YesNo + MsgBoxStyle.Information)
        If n = vbNo Then Exit Sub
        dr.Close()
        ACdr.Close()
        cmd.CommandText = "delete from sgroup where test_code='" & TESTCODE.Text & "'"
        cmd.ExecuteNonQuery()
        ACcmd.CommandText = "select * from Strans WHERE QUN>0 "
        ACdr = ACcmd.ExecuteReader
        While ACdr.Read
            cmd.CommandText = "insert into sgroup (test_code,test_name,item_code,item_name,qun) values ('" & TESTCODE.Text & "','" & TESTNAME.Text & "','" & ACdr("item_code") & "','" & ACdr("item_name") & "','" & ACdr("qun") & "')"
            cmd.ExecuteNonQuery()
        End While
        MsgBox(" „  ⁄„·Ì…  ⁄œÌ· „ﬂÊ‰«  «· Õ·Ì·", MsgBoxStyle.Information)

    End Sub

    Private Sub cont_name_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles scontname.KeyDown
        If e.KeyCode = Keys.Enter Then
            FSAVE(scontname.Text, "scont", 1)
        ElseIf e.KeyCode = Keys.Delete Then
            FSAVE(scontname.Text, "scont", 2)
        End If
        If e.KeyCode = Keys.Enter Then
            FRC = scont.Select("NAME='" & scontname.Text & "'")
            If FRC.Length <= 0 Then
                scontname.Text = ""
                scontcode.Text = ""
                Exit Sub
            Else
                RC = FRC(0)
                scontcode.Text = RC("code")
            End If
        End If
    End Sub

    Private Sub cont_name_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles scontname.SelectedIndexChanged

    End Sub

    Private Sub Button12_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        ACdr.Close()
        Dim n As Integer = 0
        While Not n = cont_v.Text
            ACcmd.CommandText = "insert into scont(cname,ccode,item_name,item_code,barcode,sdate) values ('" & scontname.Text & "','" & scontcode.Text & "','" & ITEMNAME.Text & "','" & ITEMCODE.Text & "','0','" & DateTimePicker1.Value & "')"
            ACcmd.ExecuteNonQuery()
            n += 1
        End While
        scontp()
    End Sub
    Public Sub scontp()
        cmdascont.Connection = ACcn
        cmdascont.CommandType = CommandType.Text
        cmdascont.CommandText = "select * from Scont where item_name='" & ITEMNAME.Text & "'"
        adascont.SelectCommand = cmdascont
        adascont.Fill(DBS, "aScont")
        ascont = DBS.Tables("aScont")
        DBS.Tables("aScont").Clear()
        adascont.Fill(DBS, "aScont")
        ascont = DBS.Tables("aScont")
        contd.DataSource = ascont
        Dim v As Integer = 0
        While Not v = contd.Columns.Count
            contd.Columns(v).Visible = False
            v = v + 1
        End While
        contd.Columns("cont_v").Visible = True
        contd.Columns("cont_v").HeaderText = "«·⁄œœ"
        contd.Columns("sdate").Visible = True
        contd.Columns("sdate").HeaderText = "«·’·«ÕÌ…"
        contd.Columns("barcode").Visible = True
        contd.Columns("barcode").HeaderText = "»«—ﬂÊœ"
        contd.Columns("barcode").ReadOnly = True

    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        cmdb.DataAdapter = adascont
        adascont.Update(DBS, "ascont")
        ADDTEST()

    End Sub
    Public Sub ADDTEST()
        FRC = FITEM.Select("item_code='" & ITEMCODE.Text & "'")
        If FRC.Length <= 0 Then
            Exit Sub
        Else
            RC = FRC(0)
            RC.BeginEdit()
            RC("qun") = qun.Text
            RC("price") = price.Text
            RC.Item("TQUN") = tqun.Text
            RC.Item("TTEST") = TTEST.Text
            RC.Item("SPECNAME") = SPECNAME.Text
            RC.Item("SPECCODE") = SPECCODE.Text
            RC.Item("SDATE") = DateTimePicker1.Value
            qun.Text = 0
            MOST()
            ITEMNAME.Text = ""
            ITEMNAME.Focus()
        End If
    End Sub
    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        Dim W As Integer = Convert.ToInt32("150")
        Dim H As Integer = Convert.ToInt32("37")
        ACdr.Close()
        ACcmd.CommandText = "select * from srv"
        ACdr = ACcmd.ExecuteReader
        ACdr.Read()
        PrintPreviewDialog1.Document = PrintDocument2
        PrintDialog1.PrinterSettings.PrinterName = ACdr("prnt")
        PrintDialog1.Document = PrintDocument2
        Dim na As Integer = 0
        Dim i As Integer = 0
        dr.Close()
        If CITEM_NAME.Checked = False Then
            cmd.CommandText = "select * from stranscont where sn='" & SN.Text & "'"
        Else
            cmd.CommandText = "select * from stranscont where sn='" & SN.Text & "' and item_code='" & ITEMCODE.Text & "'"
        End If
        dr = cmd.ExecuteReader
        While dr.Read
            scontname.Text = dr("ITEM_name")
            DateTimePicker1.Value = dr("sdate")
            bar1.Alignment = BarcodeLib.AlignmentPositions.CENTER
            Dim type As BarcodeLib.TYPE = BarcodeLib.TYPE.UNSPECIFIED
            type = BarcodeLib.TYPE.CODE128
            bar1.IncludeLabel = True
            barco.Image = bar1.Encode(type, dr("barcode"), W, H)
            PrintDocument2.Print()

        End While
    End Sub

    Private Sub PrintDocument2_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument2.PrintPage
        Dim f As New Font("arial", 6, FontStyle.Regular)
        Dim f1 As New Font("arial", 8, FontStyle.Regular)
        'e.Graphics.DrawString(scontname.Text, f1, Brushes.Black, 5, 30)
        e.Graphics.DrawString(scontname.Text, f, Brushes.Black, 10, 60)
        e.Graphics.DrawString(DateTimePicker1.Value.Date, f1, Brushes.Black, 40, 38)
        e.Graphics.DrawImage(barco.Image, 10, 0)

    End Sub

    Private Sub Button13_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        dr.Close()
        ACdr.Close() : ACcmd.CommandText = "delete * from book_price"
        ACcmd.ExecuteNonQuery()
        dr.Close() : cmd.CommandText = "select name,BRAN from BRANCH "
        dr = cmd.ExecuteReader
        While dr.Read = True
            ACdr.Close() : ACcmd.CommandText = "insert into book_price (sr,name,srh,sno,code) values ('0','" & dr("name") & "','0','0','" & dr("BRAN") & "')"
            ACcmd.ExecuteNonQuery()
        End While

        dr.Close()
        cmdA.Connection = CN
        cmdA.CommandType = CommandType.Text
        cmdA.CommandText = "select * FROM srh "
        adA.SelectCommand = cmdA
        adA.Fill(DBS, "a")
        A = DBS.Tables("a")
        DBS.Tables("a").Clear()
        adA.Fill(DBS, "a")
        A = DBS.Tables("a")
        cmdBOOK.Connection = ACcn
        cmdBOOK.CommandType = CommandType.Text
        cmdBOOK.CommandText = "select sr,name,srh,sno,code,ky FROM book_price order by CODE"
        adBOOK.SelectCommand = cmdBOOK
        adBOOK.Fill(DBS, "book")
        BOOK = DBS.Tables("book")
        DBS.Tables("book").Clear()
        adBOOK.Fill(DBS, "book")
        'DataGridView15.DataSource = book
        Dim M As Integer
        Dim YY As String = ""
        M = 0
        TEST.Clear()
        cmdTEST.Connection = CN
        cmdTEST.CommandType = CommandType.Text
        cmdTEST.CommandText = "select TEST_NAME,TEST_CODE from LBILL_TEST WHERE esl_date between '" & ChangeFormat(d1.Value) & "' and '" & ChangeFormat(d2.Value) & "' and t=1 GROUP BY TEST_CODE,TEST_NAME "
        adTEST.SelectCommand = cmdTEST
        adTEST.Fill(DBS, "TEST")
        TEST = DBS.Tables("TEST")
        DBS.Tables("TEST").Clear()
        adTEST.Fill(DBS, "TEST")
        TEST = DBS.Tables("TEST")


        A.Rows.Clear()
        Dim ii As Integer = 0
        Dim ss As Integer = 0
        Dim i As Integer = 0
        Dim aa As Int16 = 0
        Dim o As Integer
        While Not i = TEST.Rows.Count
            ss = 0
            ii = 0
            aa = 0
            o = 0
            While Not ii = BOOK.Rows.Count
                If BOOK.Rows(ii).Item("srh") = 0 Then
                    ss = 0
                    dr.Close() : cmd.CommandText = "sELECT  COUNT(ESL_NO) from LBILL_TEST WHERE test_code='" & TEST.Rows(i).Item("test_code") & "'  and BRAN='" & BOOK.Rows(ii).Item("code") & "' AND esl_date between '" & ChangeFormat(d1.Value) & "' and '" & ChangeFormat(d2.Value) & "'"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    If dr.HasRows = True Then If IsDBNull(dr(0)) = False Then ss = ss + dr(0)
                    '===================================================================
mk:
                    dr.Close()
                    If aa = 0 Then
                        RC = A.NewRow
                        RC("h1") = BOOK.Rows(ii).Item("name")
                        RC("hn1") = ss
                        RC("hn2") = 0
                        RC("hn3") = 0
                        RC("hn4") = 0
                        RC("hn5") = 0
                        RC("hn6") = 0
                        RC("hn7") = 0
                        RC("hn8") = 0
                        RC("hn9") = 0
                        RC("name") = TEST.Rows(i).Item("test_name")
                        RC("code") = TEST.Rows(i).Item("test_code")
                        A.Rows.Add(RC)
                        o = o + ss
                        aa += 1
                    Else
                        RC = A.Rows(A.Rows.Count - 1)
                        RC.BeginEdit()
                        Dim z As Integer = aa + 1
                        RC("h" & z) = BOOK.Rows(ii).Item("name")
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
        While Not ii = BOOK.Rows.Count
            If BOOK.Rows(ii).Item("srh") = 1 Then
                i += 1
            End If
            ii += 1
        End While

        If i <= 4 Then
            oj.Load(Application.StartupPath & "\stoc5.rpt")
        Else
            oj.Load(Application.StartupPath & "\stoc5.rpt")
        End If
        'MsgBox(a.Rows.Count)
        oj.SetDataSource(A)
        oj.SetParameterValue("d1", "")
        oj.SetParameterValue("d2", "")
        rp.CrystalReportViewer1.ReportSource = oj
        rp.CrystalReportViewer1.Refresh()
        rp.Show()
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        dr.Close()
        ACdr.Close() : ACcmd.CommandText = "delete * from book_price"
        ACcmd.ExecuteNonQuery()
        dr.Close() : cmd.CommandText = "select name,BRAN from BRANCH "
        dr = cmd.ExecuteReader
        While dr.Read = True
            ACdr.Close() : ACcmd.CommandText = "insert into book_price (sr,name,srh,sno,code) values ('0','" & dr("name") & "','0','0','" & dr("BRAN") & "')"
            ACcmd.ExecuteNonQuery()
        End While
        TEST.Clear()
        cmdTEST.Connection = CN
        cmdTEST.CommandType = CommandType.Text
        cmdTEST.CommandText = "select TEST_NAME,TEST_CODE from SGROUP  "
        adTEST.SelectCommand = cmdTEST
        adTEST.Fill(DBS, "TEST")
        TEST = DBS.Tables("TEST")
        DBS.Tables("TEST").Clear()
        adTEST.Fill(DBS, "TEST")
        TEST = DBS.Tables("TEST")
        dr.Close()
        cmd.CommandText = "UPDATE sgroup SET sgroup.PRICE = SITEM.PRICE FROM sgroup INNER JOIN SITEM ON sgroup.ITEM_code = SITEM.code  "
        cmd.ExecuteNonQuery()
        dr.Close()
        cmdA.Connection = CN
        cmdA.CommandType = CommandType.Text
        cmdA.CommandText = "select * FROM srh "
        adA.SelectCommand = cmdA
        adA.Fill(DBS, "a")
        A = DBS.Tables("a")
        DBS.Tables("a").Clear()
        adA.Fill(DBS, "a")
        A = DBS.Tables("a")
        cmdBOOK.Connection = ACcn
        cmdBOOK.CommandType = CommandType.Text
        cmdBOOK.CommandText = "select sr,name,srh,sno,code,ky FROM book_price order by CODE"
        adBOOK.SelectCommand = cmdBOOK
        adBOOK.Fill(DBS, "book")
        BOOK = DBS.Tables("book")
        DBS.Tables("book").Clear()
        adBOOK.Fill(DBS, "book")
        'DataGridView15.DataSource = book
        Dim M As Integer
        Dim YY As String = ""
        M = 0
        A.Rows.Clear()
        Dim ii As Integer = 0
        Dim ss As Integer = 0
        Dim i As Integer = 0
        Dim aa As Int16 = 0
        Dim o As Integer
        While Not i = TEST.Rows.Count
            ss = 0
            ii = 0
            aa = 0
            o = 0
            dr.Close() : cmd.CommandText = "sELECT  * from sgroup WHERE test_code='" & TEST.Rows(i).Item("test_code") & "'"
            dr = cmd.ExecuteReader
            While dr.Read
                ss = 0
                '===================================================================
mk:

                If aa = 0 Then
                    RC = A.NewRow
                    RC("h1") = dr("ITEM_name")
                    RC("hn1") = dr("PRICE")
                    RC("hn2") = 0
                    RC("hn3") = 0
                    RC("hn4") = 0
                    RC("hn5") = 0
                    RC("hn6") = 0
                    RC("hn7") = 0
                    RC("hn8") = 0
                    RC("hn9") = 0
                    RC("name") = TEST.Rows(i).Item("test_name")
                    RC("code") = TEST.Rows(i).Item("test_code")
                    A.Rows.Add(RC)
                    o = o + ss
                    aa += 1
                Else
                    RC = A.Rows(A.Rows.Count - 1)
                    RC.BeginEdit()
                    Dim z As Integer = aa + 1
                    RC("h" & z) = dr("ITEM_name")
                    RC("hn" & z) = dr("PRICE")
                    RC.EndEdit()
                    o = ss + o
                    aa += 1
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
        While Not ii = BOOK.Rows.Count
            If BOOK.Rows(ii).Item("srh") = 1 Then
                i += 1
            End If
            ii += 1
        End While

        If i <= 4 Then
            oj.Load(Application.StartupPath & "\stoc54.rpt")
        Else
            oj.Load(Application.StartupPath & "\stoc51.rpt")
        End If
        'MsgBox(a.Rows.Count)
        oj.SetDataSource(A)
        oj.SetParameterValue("d1", "")
        oj.SetParameterValue("d2", "")
        rp.CrystalReportViewer1.ReportSource = oj
        rp.CrystalReportViewer1.Refresh()
        rp.Show()
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        dr.Close()
        ACdr.Close() : ACcmd.CommandText = "delete * from book_price"
        ACcmd.ExecuteNonQuery()
        dr.Close() : cmd.CommandText = "select name,BRAN from BRANCH "
        dr = cmd.ExecuteReader
        While dr.Read = True
            ACdr.Close() : ACcmd.CommandText = "insert into book_price (sr,name,srh,sno,code) values ('0','" & dr("name") & "','0','0','" & dr("BRAN") & "')"
            ACcmd.ExecuteNonQuery()
        End While

        dr.Close()
        cmdA.Connection = CN
        cmdA.CommandType = CommandType.Text
        cmdA.CommandText = "select * FROM srh "
        adA.SelectCommand = cmdA
        adA.Fill(DBS, "a")
        A = DBS.Tables("a")
        DBS.Tables("a").Clear()
        adA.Fill(DBS, "a")
        A = DBS.Tables("a")
        cmdBOOK.Connection = ACcn
        cmdBOOK.CommandType = CommandType.Text
        cmdBOOK.CommandText = "select sr,name,srh,sno,code,ky FROM book_price order by CODE"
        adBOOK.SelectCommand = cmdBOOK
        adBOOK.Fill(DBS, "book")
        BOOK = DBS.Tables("book")
        DBS.Tables("book").Clear()
        adBOOK.Fill(DBS, "book")
        'DataGridView15.DataSource = book
        Dim M As Integer
        Dim YY As String = ""
        M = 0
        Dim MM As Double = 0
        A.Rows.Clear()
        Dim ii As Integer = 0
        Dim ss As Integer = 0
        Dim i As Integer = 0
        Dim aa As Int16 = 0
        Dim o As Integer
        While Not i = ITEM.Rows.Count
            ss = 0
            ii = 0
            aa = 0
            o = 0
            While Not ii = BOOK.Rows.Count
                dr.Close() : cmd.CommandText = "SELECT COUNT(SGROUP.ITEM_CODE) FROM SGROUP INNER JOIN LBILL_TEST ON SGROUP.TEST_CODE=LBILL_TEST.TEST_CODE WHERE LBILL_TEST.esl_date between '" & ChangeFormat(d1.Value) & "' and '" & ChangeFormat(d2.Value) & "' AND SGROUP.ITEM_CODE='" & ITEM.Rows(i).Item("CODE") & "' AND LBILL_TEST.BRAN='" & BOOK.Rows(ii).Item("code") & "'"
                dr = cmd.ExecuteReader
                dr.Read()
                MM = 0
                If BOOK.Rows(ii).Item("srh") = 0 Then
                    ss = 0
                    If dr.HasRows = True Then If IsDBNull(dr(0)) = False Then MM = MM + dr(0)
                    '===================================================================
mk:
                    If aa = 0 Then
                        RC = A.NewRow
                        RC("h1") = BOOK.Rows(ii).Item("name")
                        RC("hn1") = MM
                        RC("hn2") = 0
                        RC("hn3") = 0
                        RC("hn4") = 0
                        RC("hn5") = 0
                        RC("hn6") = 0
                        RC("hn7") = 0
                        RC("hn8") = 0
                        RC("hn9") = 0
                        RC("name") = ITEM.Rows(i).Item("NAME")
                        RC("code") = ITEM.Rows(i).Item("CODE")
                        A.Rows.Add(RC)
                        o = o + ss
                        aa += 1
                    Else
                        RC = A.Rows(A.Rows.Count - 1)
                        RC.BeginEdit()
                        Dim z As Integer = aa + 1
                        RC("h" & z) = BOOK.Rows(ii).Item("name")
                        RC("hn" & z) = MM
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
            dr.Close()
        End While
        Dim oj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        ii = 0
        i = 0
        While Not ii = BOOK.Rows.Count
            If BOOK.Rows(ii).Item("srh") = 1 Then
                i += 1
            End If
            ii += 1
        End While

        If i <= 4 Then
            oj.Load(Application.StartupPath & "\stoc5.rpt")
        Else
            oj.Load(Application.StartupPath & "\stoc5.rpt")
        End If
        oj.SetDataSource(A)
        oj.SetParameterValue("d1", "")
        oj.SetParameterValue("d2", "")
        rp.CrystalReportViewer1.ReportSource = oj
        rp.CrystalReportViewer1.Refresh()
        rp.Show()
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        dr.Close()
        ACdr.Close() : ACcmd.CommandText = "delete * from book_price"
        ACcmd.ExecuteNonQuery()
        dr.Close() : cmd.CommandText = "select name,BRAN from BRANCH "
        dr = cmd.ExecuteReader
        While dr.Read = True
            ACdr.Close() : ACcmd.CommandText = "insert into book_price (sr,name,srh,sno,code) values ('0','" & dr("name") & "','0','0','" & dr("BRAN") & "')"
            ACcmd.ExecuteNonQuery()
        End While

        dr.Close()
        cmdA.Connection = CN
        cmdA.CommandType = CommandType.Text
        cmdA.CommandText = "select * FROM srh "
        adA.SelectCommand = cmdA
        adA.Fill(DBS, "a")
        A = DBS.Tables("a")
        DBS.Tables("a").Clear()
        adA.Fill(DBS, "a")
        A = DBS.Tables("a")
        cmdBOOK.Connection = ACcn
        cmdBOOK.CommandType = CommandType.Text
        cmdBOOK.CommandText = "select sr,name,srh,sno,code,ky FROM book_price order by CODE"
        adBOOK.SelectCommand = cmdBOOK
        adBOOK.Fill(DBS, "book")
        BOOK = DBS.Tables("book")
        DBS.Tables("book").Clear()
        adBOOK.Fill(DBS, "book")
        'DataGridView15.DataSource = book
        Dim M As Integer
        Dim YY As String = ""
        M = 0
        Dim MM As Double = 0
        A.Rows.Clear()
        Dim ii As Integer = 0
        Dim ss As Integer = 0
        Dim i As Integer = 0
        Dim aa As Int16 = 0
        Dim o As Integer
        While Not i = ITEM.Rows.Count
            ss = 0
            ii = 0
            aa = 0
            o = 0
            While Not ii = BOOK.Rows.Count
                dr.Close() : cmd.CommandText = "SELECT COUNT(SGROUP.ITEM_CODE),SGROUP.PRICE FROM SGROUP INNER JOIN LBILL_TEST ON SGROUP.TEST_CODE=LBILL_TEST.TEST_CODE WHERE LBILL_TEST.esl_date between '" & ChangeFormat(d1.Value) & "' and '" & ChangeFormat(d2.Value) & "' AND SGROUP.ITEM_CODE='" & ITEM.Rows(i).Item("CODE") & "' AND LBILL_TEST.BRAN='" & BOOK.Rows(ii).Item("code") & "' GROUP BY SGROUP.PRICE"
                dr = cmd.ExecuteReader
                dr.Read()
                MM = 0
                If BOOK.Rows(ii).Item("srh") = 0 Then
                    ss = 0
                    If dr.HasRows = True Then If IsDBNull(dr(0)) = False Then MM = dr(0) * dr(1)
                    '===================================================================
mk:
                    If aa = 0 Then
                        RC = A.NewRow
                        RC("h1") = BOOK.Rows(ii).Item("name")
                        RC("hn1") = MM
                        RC("hn2") = 0
                        RC("hn3") = 0
                        RC("hn4") = 0
                        RC("hn5") = 0
                        RC("hn6") = 0
                        RC("hn7") = 0
                        RC("hn8") = 0
                        RC("hn9") = 0
                        RC("name") = ITEM.Rows(i).Item("NAME")
                        RC("code") = ITEM.Rows(i).Item("CODE")
                        A.Rows.Add(RC)
                        o = o + ss
                        aa += 1
                    Else
                        RC = A.Rows(A.Rows.Count - 1)
                        RC.BeginEdit()
                        Dim z As Integer = aa + 1
                        RC("h" & z) = BOOK.Rows(ii).Item("name")
                        RC("hn" & z) = MM
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
            dr.Close()
        End While
        Dim oj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        ii = 0
        i = 0
        While Not ii = BOOK.Rows.Count
            If BOOK.Rows(ii).Item("srh") = 1 Then
                i += 1
            End If
            ii += 1
        End While

        If i <= 4 Then
            oj.Load(Application.StartupPath & "\stoc5.rpt")
        Else
            oj.Load(Application.StartupPath & "\stoc5.rpt")
        End If
        oj.SetDataSource(A)
        oj.SetParameterValue("d1", "")
        oj.SetParameterValue("d2", "")
        rp.CrystalReportViewer1.ReportSource = oj
        rp.CrystalReportViewer1.Refresh()
        rp.Show()
    End Sub

    Private Sub Button10_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button10.GotFocus

    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        dr.Close()
        ACdr.Close() : ACcmd.CommandText = "delete * from book_price"
        ACcmd.ExecuteNonQuery()
        dr.Close() : cmd.CommandText = "select name,BRAN from BRANCH "
        dr = cmd.ExecuteReader
        While dr.Read = True
            ACdr.Close() : ACcmd.CommandText = "insert into book_price (sr,name,srh,sno,code) values ('0','" & dr("name") & "','0','0','" & dr("BRAN") & "')"
            ACcmd.ExecuteNonQuery()
        End While

        dr.Close()
        cmdA.Connection = CN
        cmdA.CommandType = CommandType.Text
        cmdA.CommandText = "select * FROM srh "
        adA.SelectCommand = cmdA
        adA.Fill(DBS, "a")
        A = DBS.Tables("a")
        DBS.Tables("a").Clear()
        adA.Fill(DBS, "a")
        A = DBS.Tables("a")
        cmdBOOK.Connection = ACcn
        cmdBOOK.CommandType = CommandType.Text
        cmdBOOK.CommandText = "select sr,name,srh,sno,code,ky FROM book_price order by CODE"
        adBOOK.SelectCommand = cmdBOOK
        adBOOK.Fill(DBS, "book")
        BOOK = DBS.Tables("book")
        DBS.Tables("book").Clear()
        adBOOK.Fill(DBS, "book")
        'DataGridView15.DataSource = book
        Dim M As Integer
        Dim YY As String = ""
        M = 0
        TEST.Clear()
        cmdTEST.Connection = CN
        cmdTEST.CommandType = CommandType.Text
        cmdTEST.CommandText = "select TEST_NAME,TEST_CODE from LBILL_TEST WHERE esl_date between '" & ChangeFormat(d1.Value) & "' and '" & ChangeFormat(d2.Value) & "' GROUP BY TEST_CODE,TEST_NAME "
        adTEST.SelectCommand = cmdTEST
        adTEST.Fill(DBS, "TEST")
        TEST = DBS.Tables("TEST")
        DBS.Tables("TEST").Clear()
        adTEST.Fill(DBS, "TEST")
        TEST = DBS.Tables("TEST")


        A.Rows.Clear()
        Dim ii As Integer = 0
        Dim ss As Integer = 0
        Dim i As Integer = 0
        Dim aa As Int16 = 0
        Dim o As Integer
        While Not i = TEST.Rows.Count
            ss = 0
            ii = 0
            aa = 0
            o = 0
            While Not ii = BOOK.Rows.Count
                If BOOK.Rows(ii).Item("srh") = 0 Then
                    ss = 0
                    dr.Close() : cmd.CommandText = "sELECT  COUNT(ESL_NO) from LBILL_TEST WHERE test_code='" & TEST.Rows(i).Item("test_code") & "'  and BRAN='" & BOOK.Rows(ii).Item("code") & "' AND esl_date between '" & ChangeFormat(d1.Value) & "' and '" & ChangeFormat(d2.Value) & "'"
                    dr = cmd.ExecuteReader
                    dr.Read()
                    If dr.HasRows = True Then If IsDBNull(dr(0)) = False Then ss = ss + dr(0)
                    '===================================================================
mk:
                    dr.Close()
                    If aa = 0 Then
                        RC = A.NewRow
                        RC("h1") = BOOK.Rows(ii).Item("name")
                        RC("hn1") = ss
                        RC("hn2") = 0
                        RC("hn3") = 0
                        RC("hn4") = 0
                        RC("hn5") = 0
                        RC("hn6") = 0
                        RC("hn7") = 0
                        RC("hn8") = 0
                        RC("hn9") = 0
                        RC("name") = TEST.Rows(i).Item("test_name")
                        RC("code") = TEST.Rows(i).Item("test_code")
                        A.Rows.Add(RC)
                        o = o + ss
                        aa += 1
                    Else
                        RC = A.Rows(A.Rows.Count - 1)
                        RC.BeginEdit()
                        Dim z As Integer = aa + 1
                        RC("h" & z) = BOOK.Rows(ii).Item("name")
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
        While Not ii = BOOK.Rows.Count
            If BOOK.Rows(ii).Item("srh") = 1 Then
                i += 1
            End If
            ii += 1
        End While

        If i <= 4 Then
            oj.Load(Application.StartupPath & "\stoc5.rpt")
        Else
            oj.Load(Application.StartupPath & "\stoc5.rpt")
        End If
        'MsgBox(a.Rows.Count)
        oj.SetDataSource(A)
        oj.SetParameterValue("d1", "")
        oj.SetParameterValue("d2", "")
        rp.CrystalReportViewer1.ReportSource = oj
        rp.CrystalReportViewer1.Refresh()
        rp.Show()
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        dr.Close()
        cmd.CommandText = "UPDATE LTEST SET LAB=0"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "UPDATE LTEST SET LAB=1 FROM LTEST INNER JOIN lgroup_test ON LTEST.TEST_CODE=lgroup_test.TEST_CODE WHERE lgroup_test.GNAME='OUTLAB'"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "update lbill_test set t=0 where esl_date between '" & ChangeFormat(d1.Value) & "' and '" & ChangeFormat(d2.Value) & "'"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "UPDATE LBILL_TEST SET T=1 FROM LBILL_TEST INNER JOIN LTEST ON LBILL_TEST.TEST_CODE=LTEST.TEST_CODE WHERE LTEST.LAB=1 AND ESL_DATE  between '" & ChangeFormat(d1.Value) & "' and '" & ChangeFormat(d2.Value) & "'"
        cmd.ExecuteNonQuery()
        Button13_Click_1(Button13, e)

    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        Dim MCODE As Integer = 0
        cmdb.DataAdapter = adITEM
        adITEM.Update(DBS, "ITEM")

        dr.Close()
        cmd.CommandText = "SELECT MAX(CODE) FROM SITEM "
        dr = cmd.ExecuteReader
        dr.Read()
        If nulls(dr(0)) = 0 Then MCODE = 1 Else MCODE = 1 + dr(0)
        dr.Close()
        dr1.Close()
        cmd.CommandText = "SELECT * FROM SITEM WHERE  CODE IS NULL OR CODE=0"
        dr = cmd.ExecuteReader
        While dr.Read = True
            cmd1.CommandText = "UPDATE SITEM SET CODE='" & MCODE & "' WHERE NAME='" & dr("NAME") & "'"
            cmd1.ExecuteNonQuery()
            MCODE += 1
        End While

        GroupBox1.Visible = False
        MsgBox("SAVED ALL DATA")
    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click

        GroupBox1.Visible = Not GroupBox1.Visible
        If GroupBox1.Visible = True Then filla("SITEM")
    End Sub

    Private Sub SQUN_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SQUN.TextChanged
        qun.Text = Val(cont_v.Text) * Val(SQUN.Text)
    End Sub

    Private Sub cont_v_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cont_v.TextChanged
        qun.Text = Val(cont_v.Text) * Val(SQUN.Text)
    End Sub

    Private Sub tqun_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tqun.TextChanged
        TTEST.Text = Val(tqun.Text) * Val(qun.Text)
    End Sub

    Private Sub TTEST_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TTEST.TextChanged
        TTEST.Text = Val(tqun.Text) * Val(qun.Text)
    End Sub

    Private Sub SPECSNAME_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles SPECNAME.KeyDown
        If e.KeyCode = Keys.Enter Then
            FSAVE(SPECNAME.Text, "SPEC", 1)
        ElseIf e.KeyCode = Keys.Delete Then
            FSAVE(SPECNAME.Text, "SPEC", 2)
        End If
        If e.KeyCode = Keys.Enter Then
            FRC = SPEC.Select("NAME='" & SPECNAME.Text & "'")
            If FRC.Length <= 0 Then
                SPECNAME.Text = ""
                SPECCODE.Text = ""
                Exit Sub
            Else
                RC = FRC(0)
                SPECCODE.Text = RC("code")
            End If
        End If
    End Sub

    Private Sub SPECSNAME_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SPECNAME.SelectedIndexChanged
        If SPECNAME.Focused = False Then Exit Sub
        If SPECNAME.Text = "" Then Exit Sub
        FRC = ITEM.Select("NAME='" & ITEMNAME.Text & "'")
        If FRC.Length <= 0 Then
            ITEMNAME.Text = ""
            ITEMCODE.Text = ""
            Exit Sub
        Else
            RC = FRC(0)
            ITEMCODE.Text = RC("code")
            price.Text = nulls(RC("price"))
            qun.Focus()
            dr.Close()
            cmd.CommandText = "SELECT SUM (QUN*FLG) FROM STRANSDET WHERE ITEM_CODE='" & ITEMCODE.Text & "' and specname='" & SPECNAME.Text & "'  "
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                If IsDBNull(dr(0)) = False Then RSD.Text = dr(0) Else RSD.Text = 0
            End If
            dr.Close()
            cmd.CommandText = "SELECT  max(price) FROM STRANSDET WHERE ITEM_CODE='" & ITEMCODE.Text & "' and specname='" & SPECNAME.Text & "' "
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                If IsDBNull(dr(0)) = False Then price.Text = dr(0) * 1.25 Else price.Text = 0
            End If
            scontp()
        End If
    End Sub

    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click
        ADDTEST()
    End Sub
End Class