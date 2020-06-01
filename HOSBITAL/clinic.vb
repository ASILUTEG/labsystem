Public Class clinic
    Dim cmdcompl As New OleDb.OleDbCommand
    Dim adcompl As New OleDb.OleDbDataAdapter
    Dim compl As New DataTable
    Dim cmdid As New OleDb.OleDbCommand
    Dim adid As New OleDb.OleDbDataAdapter
    Dim id As New DataTable
    Dim cmdbed As New OleDb.OleDbCommand
    Dim adbed As New OleDb.OleDbDataAdapter
    Dim bed As New DataTable
    Dim cmdgroup As New OleDb.OleDbCommand
    Dim adgroup As New OleDb.OleDbDataAdapter
    Dim group As New DataTable
    Dim cmdminut As New OleDb.OleDbCommand
    Dim adminut As New OleDb.OleDbDataAdapter
    Dim minut As New DataTable
    Dim cmdhour As New OleDb.OleDbCommand
    Dim adhour As New OleDb.OleDbDataAdapter
    Dim hour As New DataTable
    Dim cmDTM As New OleDb.OleDbCommand
    Dim adTM As New OleDb.OleDbDataAdapter
    Dim TM As New DataTable
    Dim cmdHPT As New OleDb.OleDbCommand
    Dim adHPT As New OleDb.OleDbDataAdapter
    Dim HPT As New DataTable
    Dim cmdcr As New OleDb.OleDbCommand
    Dim adcr As New OleDb.OleDbDataAdapter
    Dim cr As New DataTable
    Dim cmdctest1 As New OleDb.OleDbCommand
    Dim adctest1 As New OleDb.OleDbDataAdapter
    Dim ctest1 As New DataTable
    Dim cmdtestn As New OleDb.OleDbCommand
    Dim adtestn As New OleDb.OleDbDataAdapter
    Dim testn As New DataTable
    Dim cmdmedcn As New OleDb.OleDbCommand
    Dim admedcn As New OleDb.OleDbDataAdapter
    Dim medcn As New DataTable
    Dim cmdclin As New OleDb.OleDbCommand
    Dim adclin As New OleDb.OleDbDataAdapter
    Dim clin As New DataTable
    Dim cmdayada As New OleDb.OleDbCommand
    Dim adayada As New OleDb.OleDbDataAdapter
    Dim ayada As New DataTable
    Dim cmdPAS As New OleDb.OleDbCommand
    Dim adPAS As New OleDb.OleDbDataAdapter
    Dim PAS As New DataTable
    Dim cmdTYPE As New OleDb.OleDbCommand
    Dim adTYPE As New OleDb.OleDbDataAdapter
    Dim TYPE As New DataTable
    Dim cmdcompany As New OleDb.OleDbCommand
    Dim adcompany As New OleDb.OleDbDataAdapter
    Dim company As New DataTable
    Dim cmdbook_price As New OleDb.OleDbCommand
    Dim adbook_price As New OleDb.OleDbDataAdapter
    Dim book_price As New DataTable
    Dim cmdadress As New OleDb.OleDbCommand
    Dim adadress As New OleDb.OleDbDataAdapter
    Dim adress As New DataTable
    Dim cmdblood As New OleDb.OleDbCommand
    Dim adblood As New OleDb.OleDbDataAdapter
    Dim blood As New DataTable
    Dim cmdsen As New OleDb.OleDbCommand
    Dim adsen As New OleDb.OleDbDataAdapter
    Dim sen As New DataTable
    Dim cmdsht As New OleDb.OleDbCommand
    Dim adsht As New OleDb.OleDbDataAdapter
    Dim sht As New DataTable
    Dim cmdPT As New OleDb.OleDbCommand
    Dim adPT As New OleDb.OleDbDataAdapter
    Dim PT As New DataTable
    Dim cmdPT1 As New OleDb.OleDbCommand
    Dim adPT1 As New OleDb.OleDbDataAdapter
    Dim PT1 As New DataTable
    Dim SOT, tst, mdc As Int16

    Private Sub pbrith_date_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles pbrith_date.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim dt As Double
            dt = DateDiff(DateInterval.Year, pbrith_date.Value, Now)
            page.Text = dt
        End If
    End Sub

    Private Sub pbrith_date_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbrith_date.ValueChanged

    End Sub

    Private Sub page_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles page.KeyDown
        If e.KeyCode = Keys.Enter Then
            pbrith_date.Value = Now
            pbrith_date.Value = pbrith_date.Value.AddYears(-Val(page.Text))
            pemail.Focus()
        End If
        If e.KeyCode = Keys.F3 Then PAFIND(page.Text, "page")

    End Sub

    Private Sub page_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles page.TextChanged

    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sen_code.TextChanged

    End Sub
    Public Sub PAFIND(ByVal X As String, ByVal FLD As String)
        On Error Resume Next
        If FLD = "PCODE" Then
            dr.Close()
            cmd.CommandText = "SELECT * FROM LPATIEN WHERE PCODE='" & pcode.Text & "' and yEAr='" & year.Text & "'"
            dr = cmd.ExecuteReader
            While dr.Read
                pcode.Text = dr("YEAR")
                pcode.Text = dr("pcode")
                pname.Text = dr("pname")
                ptype.Text = dr("ptype")
                pbrith_date.Value = dr("pbrith_date")
                page.Text = dr("page")
                pmobile.Text = dr("pmobile")
                pemail.Text = dr("pemail")
                pid.Text = dr("pid")
                COMPANY_CODE.Text = dr("COMPANY_CODE")
                COMPANY_name.Text = dr("COMPANY_name")
                PNIK.Text = dr("PNIK")
                compl_code.Text = dr("compl_code")
                compl_name.Text = dr("compl_name")
                sen_code.Text = dr("sen_code")
                sen_name.Text = dr("sen_name")
                blood_code.Text = dr("blood_code")
                blood_name.Text = dr("blood_name")
                adress_code.Text = dr("adress_code")
                adress_name.Text = dr("adress_name")
            End While
        Else
            cmdPAS.Connection = CN
            cmdPAS.CommandType = CommandType.Text
            cmdPAS.CommandText = "select * from LPATIEN WHERE  " & FLD & " LIKE '%" & X & "%'"
            adPAS.SelectCommand = cmdPAS
            adPAS.Fill(DBS, "PAS")
            PAS = DBS.Tables("PAS")
            DBS.Tables("PAS").Clear()
            adPAS.Fill(DBS, "PAS")
            PAS = DBS.Tables("PAS")
            DataGridView6.DataSource = PAS
            Dim v As Integer = 0
            While Not v = DataGridView6.Columns.Count
                DataGridView6.Columns(v).Visible = False
                v = v + 1
            End While
            DataGridView6.Columns("PNAME").Visible = True
            DataGridView6.Columns("PNAME").HeaderText = "«·„—Ì÷"
            DataGridView6.Columns("PAGE").Visible = True
            DataGridView6.Columns("PAGE").HeaderText = "«·”‰"
            DataGridView6.Columns("PAGE").Width = 40
            DataGridView6.Columns("COMPANY_NAME").Visible = True
            DataGridView6.Columns("COMPANY_NAME").HeaderText = "«·ÃÂ…"
            DataGridView6.Columns("PCODE").Visible = True
            DataGridView6.Columns("PCODE").HeaderText = "«·ﬂÊœ"
            DataGridView6.Columns("PCODE").Width = 40
            DataGridView6.Columns("YEAR").Visible = True
            DataGridView6.Columns("YEAR").HeaderText = "«·”‰…"
            DataGridView6.Columns("YEAR").Width = 40

            SOT = 1
        End If

    End Sub

    Private Sub clinic_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'ACdr.Close()
        'Dim aaa As String
        'aaa = TwainLib.TwainOperations.GetScanSource
        'ACcmd.CommandText = "update srv set scan='" & aaa & "'"
        'ACcmd.ExecuteNonQuery()
        filla("")
        Timer1.Enabled = True
        dr.Close()
        cmd.CommandText = "select * from CTEST "
        dr = cmd.ExecuteReader
        While dr.Read
            TEST_NAME.AutoCompleteCustomSource.Add(dr("NAME"))
        End While
        dr.Close()
        cmd.CommandText = "select * from CMEDC "
        dr = cmd.ExecuteReader
        While dr.Read
            MEDC_NAME.AutoCompleteCustomSource.Add(dr("NAME"))
        End While
      
    End Sub
    Public Sub filla(ByVal tb As String)
        If tb = "cid" Or tb = "" Then
            cmdid.Connection = CN
            cmdid.CommandType = CommandType.Text
            cmdid.CommandText = "select * from cid "
            adid.SelectCommand = cmdid
            adid.Fill(DBS, "id")
            id = DBS.Tables("id")
            DBS.Tables("id").Clear()
            adid.Fill(DBS, "id")
            id = DBS.Tables("id")
            id_name.DataSource = id
            id_name.DisplayMember = "name"
            If id.Rows.Count > 0 Then
                id_name.Text = id.Rows(id.Rows.Count - 1).Item("name")
                'id_code.Text = id.Rows(id.Rows.Count - 1).Item("code")
            End If
            '========================================
        End If
        If tb = "ccompl" Or tb = "" Then
            cmdcompl.Connection = CN
            cmdcompl.CommandType = CommandType.Text
            cmdcompl.CommandText = "select * from ccompl "
            adcompl.SelectCommand = cmdcompl
            adcompl.Fill(DBS, "compl")
            compl = DBS.Tables("compl")
            DBS.Tables("compl").Clear()
            adcompl.Fill(DBS, "compl")
            compl = DBS.Tables("compl")
            compl_name.DataSource = compl
            compl_name.DisplayMember = "name"
            If compl.Rows.Count > 0 Then
                compl_name.Text = compl.Rows(compl.Rows.Count - 1).Item("name")
                compl_code.Text = compl.Rows(compl.Rows.Count - 1).Item("code")
            End If
            '========================================
        End If
        If tb = "cbed" Or tb = "" Then
            cmdbed.Connection = CN
            cmdbed.CommandType = CommandType.Text
            cmdbed.CommandText = "select * from cbed "
            adbed.SelectCommand = cmdbed
            adbed.Fill(DBS, "bed")
            bed = DBS.Tables("bed")
            DBS.Tables("bed").Clear()
            adbed.Fill(DBS, "bed")
            bed = DBS.Tables("bed")
            bed_name.DataSource = bed
            bed_name.DisplayMember = "name"
            If bed.Rows.Count > 0 Then
                bed_name.Text = bed.Rows(bed.Rows.Count - 1).Item("name")
                bed_code.Text = bed.Rows(bed.Rows.Count - 1).Item("code")
            End If
            '========================================
        End If
        If tb = "cgroup" Or tb = "" Then
            cmdgroup.Connection = CN
            cmdgroup.CommandType = CommandType.Text
            cmdgroup.CommandText = "select * from cgroup "
            adgroup.SelectCommand = cmdgroup
            adgroup.Fill(DBS, "group")
            group = DBS.Tables("group")
            DBS.Tables("group").Clear()
            adgroup.Fill(DBS, "group")
            group = DBS.Tables("group")
            group_name.DataSource = group
            group_name.DisplayMember = "name"
            If group.Rows.Count > 0 Then
                group_name.Text = group.Rows(group.Rows.Count - 1).Item("name")
                group_code.Text = group.Rows(group.Rows.Count - 1).Item("code")
            End If
            '========================================
        End If
        If tb = "cminut" Or tb = "" Then
            cmdminut.Connection = CN
            cmdminut.CommandType = CommandType.Text
            cmdminut.CommandText = "select * from cminut "
            adminut.SelectCommand = cmdminut
            adminut.Fill(DBS, "minut")
            minut = DBS.Tables("minut")
            DBS.Tables("minut").Clear()
            adminut.Fill(DBS, "minut")
            minut = DBS.Tables("minut")
            minut_name.DataSource = minut
            minut_name.DisplayMember = "name"
            If minut.Rows.Count > 0 Then
                minut_name.Text = minut.Rows(minut.Rows.Count - 1).Item("name")
                minut_code.Text = minut.Rows(minut.Rows.Count - 1).Item("code")
            End If
            '========================================
        End If
        If tb = "chour" Or tb = "" Then
            cmdhour.Connection = CN
            cmdhour.CommandType = CommandType.Text
            cmdhour.CommandText = "select * from chour "
            adhour.SelectCommand = cmdhour
            adhour.Fill(DBS, "hour")
            hour = DBS.Tables("hour")
            DBS.Tables("hour").Clear()
            adhour.Fill(DBS, "hour")
            hour = DBS.Tables("hour")
            hour_name.DataSource = hour
            hour_name.DisplayMember = "name"
            If hour.Rows.Count > 0 Then
                hour_name.Text = hour.Rows(hour.Rows.Count - 1).Item("name")
                hour_code.Text = hour.Rows(hour.Rows.Count - 1).Item("code")
            End If
            '========================================
        End If
        If tb = "cayada" Or tb = "" Then
            cmdayada.Connection = CN
            cmdayada.CommandType = CommandType.Text
            cmdayada.CommandText = "select * from cayada "
            adayada.SelectCommand = cmdayada
            adayada.Fill(DBS, "ayada")
            ayada = DBS.Tables("ayada")
            DBS.Tables("ayada").Clear()
            adayada.Fill(DBS, "ayada")
            ayada = DBS.Tables("ayada")
            AYADA_NAME.DataSource = ayada
            AYADA_NAME.DisplayMember = "name"
            If ayada.Rows.Count > 0 Then
                AYADA_NAME.Text = ayada.Rows(ayada.Rows.Count - 1).Item("name")
                AYADA_CODE.Text = ayada.Rows(ayada.Rows.Count - 1).Item("code")
            End If
            '========================================
        End If
        If tb = "HPT" Or tb = "" Then
            cmdHPT.Connection = CN
            cmdHPT.CommandType = CommandType.Text
            cmdHPT.CommandText = "select * from HPT "
            adHPT.SelectCommand = cmdHPT
            adHPT.Fill(DBS, "HPT")
            HPT = DBS.Tables("HPT")
            DBS.Tables("HPT").Clear()
            adHPT.Fill(DBS, "HPT")
            HPT = DBS.Tables("HPT")
            HPT_NAME.DataSource = HPT
            HPT_NAME.DisplayMember = "name"
            If HPT.Rows.Count > 0 Then
                HPT_NAME.Text = HPT.Rows(HPT.Rows.Count - 1).Item("name")
                HPT_CODE.Text = HPT.Rows(HPT.Rows.Count - 1).Item("code")
            End If
            '========================================
        End If
        If tb = "csen" Or tb = "" Then
            cmdsen.Connection = CN
            cmdsen.CommandType = CommandType.Text
            cmdsen.CommandText = "select * from csen "
            adsen.SelectCommand = cmdsen
            adsen.Fill(DBS, "sen")
            sen = DBS.Tables("sen")
            DBS.Tables("sen").Clear()
            adsen.Fill(DBS, "sen")
            sen = DBS.Tables("sen")
            sen_name.DataSource = sen
            sen_name.DisplayMember = "name"
            If sen.Rows.Count > 0 Then
                sen_name.Text = sen.Rows(sen.Rows.Count - 1).Item("name")
                sen_code.Text = sen.Rows(sen.Rows.Count - 1).Item("code")
            End If
        End If
        '========================================
        If tb = "LTYPE" Or tb = "" Then
            cmdTYPE.Connection = CN
            cmdTYPE.CommandType = CommandType.Text
            cmdTYPE.CommandText = "select * from LTYPE "
            adTYPE.SelectCommand = cmdTYPE
            adTYPE.Fill(DBS, "TYPE")
            TYPE = DBS.Tables("TYPE")
            DBS.Tables("TYPE").Clear()
            adTYPE.Fill(DBS, "TYPE")
            TYPE = DBS.Tables("TYPE")
            PNIK.DataSource = TYPE
            PNIK.DisplayMember = "Sname"
            If TYPE.Rows.Count > 0 Then
                PNIK.Text = TYPE.Rows(TYPE.Rows.Count - 1).Item("Sname")
                ptype.Text = TYPE.Rows(TYPE.Rows.Count - 1).Item("NAME")
            End If
        End If
        '========================================
        If tb = "cblood" Or tb = "" Then
            cmdblood.Connection = CN
            cmdblood.CommandType = CommandType.Text
            cmdblood.CommandText = "select * from cblood "
            adblood.SelectCommand = cmdblood
            adblood.Fill(DBS, "blood")
            blood = DBS.Tables("blood")
            DBS.Tables("blood").Clear()
            adblood.Fill(DBS, "blood")
            blood = DBS.Tables("blood")
            blood_name.DataSource = blood
            blood_name.DisplayMember = "name"
            If blood.Rows.Count > 0 Then
                blood_name.Text = blood.Rows(blood.Rows.Count - 1).Item("name")
                blood_code.Text = blood.Rows(blood.Rows.Count - 1).Item("code")
            End If
        End If
        If tb = "cadress" Or tb = "" Then
            '========================================
            cmdadress.Connection = CN
            cmdadress.CommandType = CommandType.Text
            cmdadress.CommandText = "select * from cadress "
            adadress.SelectCommand = cmdadress
            adadress.Fill(DBS, "adress")
            adress = DBS.Tables("adress")
            DBS.Tables("adress").Clear()
            adadress.Fill(DBS, "adress")
            adress = DBS.Tables("adress")
            adress_name.DataSource = adress
            adress_name.DisplayMember = "name"
            If adress.Rows.Count > 0 Then
                adress_name.Text = adress.Rows(adress.Rows.Count - 1).Item("name")
                adress_code.Text = adress.Rows(adress.Rows.Count - 1).Item("code")
            End If
        End If
        If tb = "LCOMPANY" Or tb = "" Then
            '========================================
            cmdcompany.Connection = CN
            cmdcompany.CommandType = CommandType.Text
            cmdcompany.CommandText = "select * from lcompany "
            adcompany.SelectCommand = cmdcompany
            adcompany.Fill(DBS, "company")
            company = DBS.Tables("company")
            DBS.Tables("company").Clear()
            adcompany.Fill(DBS, "company")
            company = DBS.Tables("company")
            COMPANY_name.DataSource = company
            COMPANY_name.DisplayMember = "name"
            If company.Rows.Count > 0 Then
                COMPANY_name.Text = company.Rows(company.Rows.Count - 1).Item("name")
                COMPANY_CODE.Text = company.Rows(company.Rows.Count - 1).Item("code")
            End If
        End If

    End Sub
    Private Sub SAVEToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub adress_name_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles adress_name.KeyDown
        If e.KeyCode = Keys.ControlKey Then
            FSAVE(adress_name.Text, "cadress", 1)
        ElseIf e.KeyCode = Keys.Enter Then
            blood_name.Focus()
        ElseIf e.KeyCode = Keys.Delete Then
            FSAVE(adress_name.Text, "cadress", 2)
        End If
        If e.KeyCode = Keys.F3 Then PAFIND(adress_name.Text, "adress_name")

    End Sub
    Public Sub fpa()
mmm:
        dr.Close()
        cmd.CommandText = "select * from LPATIEN where pcode='" & pcode.Text & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Or pcode.Text = 0 Then
            dr.Close()
            cmd.CommandText = "select * from Branch "
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then
                pcode.Text = dr("pa")
                dr.Close()
                cmd.CommandText = "update Branch set pa='" & Val(pcode.Text) + 1 & "'"
                cmd.ExecuteNonQuery()
                ACdr.Close()
                ACcmd.CommandText = "update srv set pa='" & Val(pcode.Text) & "' "
                ACcmd.ExecuteNonQuery()
                GoTo mmm
            End If
        End If
    End Sub
    Private Sub adress_name_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles adress_name.SelectedIndexChanged
        If adress_name.Focused = False Then Exit Sub
        If adress_name.Text = "" Then Exit Sub
        FRC = adress.Select("NAME='" & adress_name.Text & "'")
        If FRC.Length <= 0 Then
            adress_name.Text = ""
            adress_code.Text = ""
            Exit Sub
        Else
            RC = FRC(0)
            adress_code.Text = RC("code")
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

    Private Sub blood_name_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles blood_name.KeyDown
        If e.KeyCode = Keys.ControlKey Then
            FSAVE(blood_name.Text, "cblood", 1)
        ElseIf e.KeyCode = Keys.Enter Then
            sen_name.Focus()
        ElseIf e.KeyCode = Keys.Delete Then
            FSAVE(blood_name.Text, "cblood", 2)
        End If
        If e.KeyCode = Keys.F3 Then PAFIND(blood_name.Text, "blood_name")

    End Sub

    Private Sub blood_name_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles blood_name.SelectedIndexChanged
        If blood_name.Focused = False Then Exit Sub
        If blood_name.Text = "" Then Exit Sub
        FRC = blood.Select("NAME='" & blood_name.Text & "'")
        If FRC.Length <= 0 Then
            blood_name.Text = ""
            blood_code.Text = ""
            Exit Sub
        Else
            RC = FRC(0)
            blood_code.Text = RC("code")
        End If

    End Sub

    Private Sub sen_name_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles sen_name.KeyDown
        If e.KeyCode = Keys.ControlKey Then
            FSAVE(sen_name.Text, "csen", 1)
        ElseIf e.KeyCode = Keys.Enter Then
            pid.Focus()
        ElseIf e.KeyCode = Keys.Delete Then
            FSAVE(sen_name.Text, "csen", 2)
        End If
        If e.KeyCode = Keys.F3 Then PAFIND(sen_name.Text, "sen_name")

    End Sub

    Private Sub sen_name_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sen_name.SelectedIndexChanged
        If sen_name.Focused = False Then Exit Sub
        If sen_name.Text = "" Then Exit Sub
        FRC = sen.Select("NAME='" & sen_name.Text & "'")
        If FRC.Length <= 0 Then
            sen_name.Text = ""
            sen_code.Text = ""
            Exit Sub
        Else
            RC = FRC(0)
            sen_code.Text = RC("code")
        End If
    End Sub

    Private Sub compl_name_KeyDown(ByVal complder As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles compl_name.KeyDown
        If e.KeyCode = Keys.ControlKey Then
            FSAVE(compl_name.Text, "ccompl", 1)
        ElseIf e.KeyCode = Keys.Enter Then
            GlassButton35_Click(GlassButton35, e)
        ElseIf e.KeyCode = Keys.Delete Then
            FSAVE(compl_name.Text, "ccompl", 2)
        End If
        If e.KeyCode = Keys.F3 Then PAFIND(compl_name.Text, "compl_name")

    End Sub

    Private Sub compl_name_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles compl_name.SelectedIndexChanged
        If compl_name.Focused = False Then Exit Sub
        If compl_name.Text = "" Then Exit Sub
        FRC = compl.Select("NAME='" & compl_name.Text & "'")
        If FRC.Length <= 0 Then
            compl_name.Text = ""
            compl_code.Text = ""
            Exit Sub
        Else
            RC = FRC(0)
            compl_code.Text = RC("code")
        End If
    End Sub

    Private Sub PNIK_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles PNIK.GotFocus
        flng("AR")

    End Sub

    Private Sub PNIK_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles PNIK.KeyDown
        If e.KeyCode = Keys.Enter Then
            pname.Text = ""
            pname.Focus()
        End If
    End Sub

    Private Sub PNIK_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles PNIK.LostFocus
        dr.Close()
        cmd.CommandText = "SELECT * FROM ltype where    sname='" & PNIK.Text & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            PNIK.Text = dr("SNAME")
            ptype.Text = dr("NAME")
        End If
        pname.Focus()

    End Sub

    Private Sub PNIK_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PNIK.SelectedIndexChanged

    End Sub

    Private Sub GlassButton36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton36.Click
        pcode.Text = ""
        ACdr.Close()
        ACcmd.CommandText = "select * from srv "
        ACdr = ACcmd.ExecuteReader
        ACdr.Read()
        If ACdr("esl") > 0 Then
            pcode.Text = ACdr("pa")
            fpa()
        End If
        page.Text = ""
        pemail.Text = ""
        pmobile.Text = ""
        pid.Text = ""
        strg.Text = "new patien data"

    End Sub

    Private Sub GlassButton35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton35.Click
        If pname.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «”„ «·„—Ì÷") : Exit Sub

        dr.Close()
        cmd.CommandText = "select * from lpatien where PCODE='" & pcode.Text & "' "
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            dr.Close()
            cmd.CommandText = "delete from lpatien where PCODE='" & pcode.Text & "' "
            cmd.ExecuteNonQuery()
            GoTo mm
        Else
            fpa()
mm:
            dr.Close()
            cmd.CommandText = "INSERT INTO LPATIEN([pcode],[pname],[ptype],[pbrith_date],[page],[pmobile],[pemail] ,[pid],[company_code],[company_name] ,[Pnik],[compl_code],[compl_name],[sen_code],[sen_name],[blood_code],[blood_name],[adress_code],[adress_name],year) VALUES ('" & pcode.Text & " ','" & pname.Text & "','" & ptype.Text & "','" & ChangeFormat(pbrith_date.Value) & "','" & page.Text & "','" & pmobile.Text & "','" & pemail.Text & "','" & pid.Text & "','" & COMPANY_CODE.Text & "','" & COMPANY_name.Text & "','" & PNIK.Text & "','" & compl_code.Text & "','" & compl_name.Text & "','" & sen_code.Text & "','" & sen_name.Text & "','" & blood_code.Text & "','" & blood_name.Text & "','" & adress_code.Text & "','" & adress_name.Text & "','" & year.Text & "')"
            cmd.ExecuteNonQuery()
        End If
        dr.Close()
        PNIK.Focus()
        strg.Text = "Saved successfully "
    End Sub

    Private Sub COMPANY_name_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles COMPANY_name.KeyDown
        If e.KeyCode = Keys.ControlKey Then
            FSAVE(COMPANY_name.Text, "LCOMPANY", 1)
        ElseIf e.KeyCode = Keys.Delete Then
            FSAVE(COMPANY_name.Text, "LCOMPANY", 2)
        End If
        If e.KeyCode = Keys.Enter Then pmobile.Focus()
        If e.KeyCode = Keys.F3 Then PAFIND(COMPANY_name.Text, "COMPANY_name")

    End Sub

    Private Sub COMPANY_name_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COMPANY_name.SelectedIndexChanged
        If COMPANY_name.Focused = False Then Exit Sub
        If COMPANY_name.Text = "" Then Exit Sub
        FRC = company.Select("NAME='" & COMPANY_name.Text & "'")
        If FRC.Length <= 0 Then
            COMPANY_name.Text = ""
            COMPANY_CODE.Text = ""
            Exit Sub
        Else
            RC = FRC(0)
            COMPANY_CODE.Text = RC("code")
        End If
    End Sub

    Private Sub pname_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles pname.GotFocus
        flng("AR")

    End Sub

    Private Sub pname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles pname.KeyDown
        pcode.Text = 0
        If e.KeyCode = Keys.Enter Then GlassButton36_Click(GlassButton36, e) : page.Focus()
        If e.KeyCode = Keys.F3 Then PAFIND(pname.Text, "PNAME")

    End Sub

    Private Sub pname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pname.TextChanged

    End Sub

    Private Sub pemail_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles pemail.GotFocus
        flng("EN")

    End Sub

    Private Sub pemail_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles pemail.KeyDown
        If e.KeyCode = Keys.Enter Then adress_name.Focus()
        If e.KeyCode = Keys.F3 Then PAFIND(pemail.Text, "pemail")

    End Sub

    Private Sub pemail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pemail.TextChanged

    End Sub

    Private Sub pid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles pid.KeyDown
        If e.KeyCode = Keys.Enter Then COMPANY_name.Focus()
        If e.KeyCode = Keys.F3 Then PAFIND(pid.Text, "pid")

    End Sub

    Private Sub pid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pid.TextChanged

    End Sub

    Private Sub pmobile_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles pmobile.KeyDown
        If e.KeyCode = Keys.Enter Then compl_name.Focus()
        If e.KeyCode = Keys.F3 Then PAFIND(pmobile.Text, "pmobile")

    End Sub

    Private Sub pmobile_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pmobile.TextChanged

    End Sub

    Private Sub pcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pcode.TextChanged

    End Sub

    Private Sub BYCODEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BYCODEToolStripMenuItem.Click
        Dim X As String = InputBox("«œŒ· ﬂÊœ «·„—Ì÷ ø ")
        PAFIND(X, "PCODE")
    End Sub

    Private Sub BYNAMEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BYNAMEToolStripMenuItem.Click
        Dim X As String = InputBox("«œŒ· «”„ «·„—Ì÷ ø ")
        PAFIND(X, "PNAME")
    End Sub

    Private Sub BYMOBILEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BYMOBILEToolStripMenuItem.Click
        Dim X As String = InputBox("«œŒ· «· ·Ì›Ê‰  ø ")
        PAFIND(X, "pmobile")
    End Sub

    Private Sub BYIDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BYIDToolStripMenuItem.Click
        Dim X As String = InputBox("«œŒ· —ﬁ„ «·⁄÷ÊÌ…  ø ")
        PAFIND(X, "pid")
    End Sub

    Private Sub DataGridView6_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView6.CellContentClick

    End Sub

    Private Sub DataGridView6_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView6.CellMouseDoubleClick
        If SOT = 1 Then
            pcode.Text = DataGridView6("PCODE", e.RowIndex).Value
            year.Text = DataGridView6("YEAR", e.RowIndex).Value
            PAFIND(DataGridView6("PCODE", e.RowIndex).Value, "PCODE")
        ElseIf SOT = 2 Then
            esl_no.Text = DataGridView6("esl_no", e.RowIndex).Value
            esl_date.Value = DataGridView6("esl_date", e.RowIndex).Value
            AYADA_NAME.Text = DataGridView6("AYADA_NAME", e.RowIndex).Value
            AYADA_CODE.Text = DataGridView6("AYADA_CODE", e.RowIndex).Value
            note.Text = DataGridView6("note", e.RowIndex).Value
            pname.Text = DataGridView6("pname", e.RowIndex).Value
            pcode.Text = DataGridView6("pcode", e.RowIndex).Value
            year.Text = DataGridView6("year", e.RowIndex).Value
            dr.Close()
            dr1.Close()
            cmd.CommandText = "select * from cbilltest where esl_no='" & esl_no.Text & "'"
            dr = cmd.ExecuteReader
            While dr.Read
                cmd1.CommandText = "update [ctest] set res='" & dr("res") & "' where code='" & dr("code") & "'"
                cmd1.ExecuteNonQuery()
            End While
            dr.Close()
            cmd.CommandText = "select * from cbillmedc where esl_no='" & esl_no.Text & "'"
            dr = cmd.ExecuteReader
            While dr.Read
                cmd1.CommandText = "update [cmedc] set res='1' where code='" & dr("code") & "'"
                cmd1.ExecuteNonQuery()
            End While
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Static rand As New Random()
        strg.ForeColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256))

    End Sub

    Private Sub SAVEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SAVEToolStripMenuItem.Click
        GlassButton35_Click(GlassButton35, e)
    End Sub

    Private Sub GlassButton34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton34.Click
        dr.Close()
        cmd.CommandText = "select * from lpatien where pcode='" & pcode.Text & "'  "
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            Dim n As String = MsgBox("Â·  —Ìœ «·Õ–› ø", MsgBoxStyle.YesNo)
            If n = vbNo Then Exit Sub
            dr.Close()
            cmd.CommandText = "delete from lpatien where pcode='" & pcode.Text & "'  "
            cmd.ExecuteNonQuery()
        End If
    End Sub

    Private Sub DELETEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DELETEToolStripMenuItem.Click
        GlassButton34_Click(GlassButton34, e)
    End Sub

    Private Sub NEWToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NEWToolStripMenuItem.Click
        GlassButton36_Click(GlassButton36, e)
    End Sub

    Private Sub TEST_NAME_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TEST_NAME.GotFocus
        flng("EN")
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TEST_NAME.KeyDown

    End Sub

    Private Sub TextBox1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TEST_NAME.KeyUp
        If e.KeyCode = Keys.ControlKey Then
            FSAVE(TEST_NAME.Text, "CTEST", 1)
        ElseIf e.KeyCode = Keys.Delete Then
            FSAVE(TEST_NAME.Text, "CTEST", 2)
        End If
        If e.KeyCode = Keys.Enter And tst = 0 Then
            If note.Text <> "" Then note.Text = note.Text & System.Environment.NewLine & " test required" : tst = 1
            If note.Text = "" Then note.Text = " test required" : tst = 1
        End If
        If e.KeyCode = Keys.Enter Then note.Text = note.Text & "  " & TEST_NAME.Text
    End Sub

    Private Sub TextBox1_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TEST_NAME.TextChanged

    End Sub

    Private Sub MEDC_NAME_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MEDC_NAME.GotFocus
        flng("EN")
    End Sub

    Private Sub MEDC_NAME_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MEDC_NAME.KeyUp
        If e.KeyCode = Keys.ControlKey Then
            FSAVE(MEDC_NAME.Text, "CMEDC", 1)
        ElseIf e.KeyCode = Keys.Delete Then
            FSAVE(MEDC_NAME.Text, "CMEDC", 2)
        End If
        If e.KeyCode = Keys.Enter And mdc = 0 Then
            If note.Text <> "" Then note.Text = note.Text & System.Environment.NewLine & " medication required" : mdc = 1
            If note.Text = "" Then note.Text = " test required" : tst = 1
        End If

        If e.KeyCode = Keys.Enter Then note.Text = note.Text & "  " & MEDC_NAME.Text

    End Sub

    Private Sub MEDC_NAME_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MEDC_NAME.TextChanged

    End Sub

    Private Sub AYADA_NAME_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles AYADA_NAME.KeyDown
        If e.KeyCode = Keys.ControlKey Then
            FSAVE(AYADA_NAME.Text, "cayada", 1)

        ElseIf e.KeyCode = Keys.Delete Then
            FSAVE(AYADA_NAME.Text, "cayada", 2)
        ElseIf e.KeyCode = Keys.Enter Then
            sen_name.Focus()
        End If
    End Sub

    Private Sub AYADA_NAME_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AYADA_NAME.SelectedIndexChanged
        If AYADA_NAME.Focused = False Then Exit Sub
        If AYADA_NAME.Text = "" Then Exit Sub
        FRC = ayada.Select("NAME='" & AYADA_NAME.Text & "'")
        If FRC.Length <= 0 Then
            AYADA_NAME.Text = ""
            AYADA_CODE.Text = ""
            Exit Sub
        Else
            RC = FRC(0)
            AYADA_CODE.Text = RC("code")
        End If

    End Sub

    Private Sub GlassButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton1.Click
        If pname.Text = "" Or pcode.Text = "" Then MsgBox("«·—Ã«¡ «Œ Ì«— «·„—Ì÷") : Exit Sub
        dr.Close()
        cmd.CommandText = "select max(esl_no)  from cbill "
        dr = cmd.ExecuteReader
        dr.Read()
        If IsDBNull(dr(0)) = True Then esl_no.Text = 1 Else esl_no.Text = 1 + Val(dr(0))
        TEST_NAME.Text = ""
        MEDC_NAME.Text = ""
        note.Text = ""
        tst = 0
        mdc = 0
        dr.Close()
        cmd.CommandText = "update ctest set res='-'"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "update cmedc set res='-'"
        cmd.ExecuteNonQuery()
        GlassButton9_Click(GlassButton9, e)
    End Sub

    Private Sub GlassButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton3.Click
        If pname.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «”„ «·„—Ì÷") : Exit Sub

        dr.Close()
        cmd.CommandText = "select * from cbill where ESL_NO='" & esl_no.Text & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            dr.Close()
            cmd.CommandText = "delete from cbill where ESL_NO='" & esl_no.Text & "'"
            cmd.ExecuteNonQuery()
            cmd.CommandText = "delete from [cbilltest] where ESL_NO='" & esl_no.Text & "'"
            cmd.ExecuteNonQuery()
            cmd.CommandText = "delete from [cbillmedc] where ESL_NO='" & esl_no.Text & "'"
            cmd.ExecuteNonQuery()
            GoTo mm
        Else
            fpa()
mm:
            dr1.Close()
            dr.Close()
            cmd.CommandText = "INSERT INTO [ASILLAB].[dbo].[cbill]([esl_no],[esl_date],[ayada_name],[ayada_code],[note],[ktype],[pname],[pcode])VALUES ('" & esl_no.Text & " ', '" & ChangeFormat(esl_date.Value) & "', '" & AYADA_NAME.Text & "', '" & AYADA_CODE.Text & "', '" & note.Text & "', 'ﬂ‘›', '" & pname.Text & "', '" & pcode.Text & "')"
            cmd.ExecuteNonQuery()
            cmd.CommandText = "select * from ctest where res<>'-'"
            dr = cmd.ExecuteReader
            While dr.Read
                cmd1.CommandText = "insert into [cbilltest]([name],[code],[res] ,[ref],[esl_no],[esl_date]) VALUES ('" & dr("name") & "' , '" & dr("code") & "' , '" & dr("res") & "' , '" & dr("ref") & "' , '" & esl_no.Text & "' , '" & ChangeFormat(esl_date.Value) & "')"
                cmd1.ExecuteNonQuery()
            End While
            dr.Close()
            cmd.CommandText = "select * from cmedc where res<>'-'"
            dr = cmd.ExecuteReader
            While dr.Read
                cmd1.CommandText = "insert into [cbillmedc]([name],[code],[res] ,[esl_no],[esl_date]) VALUES ('" & dr("name") & "' , '" & dr("code") & "' , '" & dr("res") & "' , '" & esl_no.Text & "' , '" & ChangeFormat(esl_date.Value) & "')"
                cmd1.ExecuteNonQuery()
            End While

        End If
        dr.Close()
        PNIK.Focus()
        strg.Text = "Saved successfully "
       

    End Sub

    Private Sub GlassButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton4.Click
        dr.Close()
        cmd.CommandText = "select * from cbill where ESL_NO='" & esl_no.Text & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            dr.Close()
            cmd.CommandText = "delete from cbill where ESL_NO='" & esl_no.Text & "'"
            cmd.ExecuteNonQuery()
            cmd.CommandText = "delete from [cbilltest] where ESL_NO='" & esl_no.Text & "'"
            cmd.ExecuteNonQuery()
            cmd.CommandText = "delete from [cbillmedc] where ESL_NO='" & esl_no.Text & "'"
            cmd.ExecuteNonQuery()
            GoTo mm
        Else
            fpa()
mm:
            dr.Close()
            cmd.CommandText = "INSERT INTO [ASILLAB].[dbo].[cbill]([esl_no],[esl_date],[ayada_name],[ayada_code],[note],[ktype],[pname],[pcode])VALUES ('" & esl_no.Text & " ', '" & ChangeFormat(esl_date.Value) & "', '" & AYADA_NAME.Text & "', '" & AYADA_CODE.Text & "', '" & note.Text & "', '«” ‘«—…', '" & pname.Text & "', '" & pcode.Text & "')"
            cmd.ExecuteNonQuery()
            cmd.CommandText = "select * from ctest where res<>'-'"
            dr = cmd.ExecuteReader
            While dr.Read
                cmd1.CommandText = "insert into [cbilltest]([name],[code],[res] ,[ref],[esl_no],[esl_date]) VALUES ('" & dr("name") & "' , '" & dr("code") & "' , '" & dr("res") & "' , '" & dr("ref") & "' , '" & esl_no.Text & "' , '" & ChangeFormat(esl_date.Value) & "')"
                cmd1.ExecuteNonQuery()
            End While
            dr.Close()
            cmd.CommandText = "select * from cmedc where res<>'-'"
            dr = cmd.ExecuteReader
            While dr.Read
                cmd1.CommandText = "insert into [cbillmedc]([name],[code],[res] ,[esl_no],[esl_date]) VALUES ('" & dr("name") & "' , '" & dr("code") & "' , '" & dr("res") & "' , '" & esl_no.Text & "' , '" & ChangeFormat(esl_date.Value) & "')"
                cmd1.ExecuteNonQuery()
            End While
        End If
        dr.Close()
        PNIK.Focus()
        strg.Text = "Saved successfully "

        
    End Sub

    Private Sub GlassButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton2.Click
        dr.Close()
        cmd.CommandText = "select * from cbill where ESL_NO='" & esl_no.Text & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            Dim n As String = MsgBox("Â·  —Ìœ «·Õ–› ø", MsgBoxStyle.YesNo)
            If n = vbNo Then Exit Sub
            dr.Close()
            cmd.CommandText = "delete from cbill where ESL_NO='" & esl_no.Text & "'"
            cmd.ExecuteNonQuery()
        End If
    End Sub

    Private Sub GlassButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton5.Click
        FKTYPE()
        
        Dim oj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        oj.Load(Application.StartupPath & "\clinic.rpt")
        oj.Database.Tables(0).SetDataSource(clin)

        rp.CrystalReportViewer1.ReportSource = oj
        rp.Show() : rp.Focus()

    End Sub
    Public Sub FKTYPE()
        Dim yy As String = "  where esl_no>0"
        If cesl_date.Checked = True Then yy = yy & " and esl_date='" & ChangeFormat(esl_date.Value) & "'"
        If cpnik.Checked = True Then yy = yy & " and pnik='" & PNIK.Text & "'"
        If cpnik.Checked = True Then yy = yy & " and pnik='" & PNIK.Text & "'"
        If cpcode.Checked = True Then yy = yy & " and pcode='" & pcode.Text & "' and YEAR='" & year.Text & "'"
        If cptype.Checked = True Then yy = yy & " and ptype='" & ptype.Text & "'"
        If cpbrith_date.Checked = True Then yy = yy & " and pbrith_date='" & ChangeFormat(pbrith_date.Value) & "'"
        If cpage.Checked = True Then yy = yy & " and page='" & page.Text & "'"
        If cpmobile.Checked = True Then yy = yy & " and pmobile='" & pmobile.Text & "'"
        If cpemail.Checked = True Then yy = yy & " and pemail='" & pemail.Text & "'"
        If cpid.Checked = True Then yy = yy & " and pid='" & pid.Text & "'"
        If cCOMPANY_CODE.Checked = True Then yy = yy & " and COMPANY_CODE='" & COMPANY_CODE.Text & "'"
        If cblood_name.Checked = True Then yy = yy & " and blood_name='" & blood_name.Text & "'"
        If csen_name.Checked = True Then yy = yy & " and sen_name='" & sen_name.Text & "'"
        If ccompl_name.Checked = True Then yy = yy & " and compl_name='" & compl_name.Text & "'"
        If ctest.Checked = True Then yy = yy & " and note like '%" & TEST_NAME.Text & "%'"
        If cayada_name.Checked = True Then yy = yy & " and ayada_name='" & AYADA_NAME.Text & "'"
        If cmedc.Checked = True Then yy = yy & " and note like '%" & MEDC_NAME.Text & "%'"
        If CHPT.Checked = True Then yy = yy & " and HPT like '%" & HPT_NAME.Text & "%'"

        cmdclin.Connection = CN
        cmdclin.CommandType = CommandType.Text
        cmdclin.CommandText = "SELECT  * from v_clinic " & yy
        adclin.SelectCommand = cmdclin
        adclin.Fill(DBS, "clin")
        clin = DBS.Tables("clin")
        DBS.Tables("clin").Clear()
        adclin.Fill(DBS, "clin")
        clin = DBS.Tables("clin")
        DataGridView6.DataSource = clin
        Dim v As Integer = 0
        While Not v = DataGridView6.Columns.Count
            DataGridView6.Columns(v).Visible = False
            v = v + 1
        End While
        DataGridView6.Columns("PNAME").Visible = True
        DataGridView6.Columns("PNAME").HeaderText = "«·„—Ì÷"
        DataGridView6.Columns("ESL_DATE").Visible = True
        DataGridView6.Columns("ESL_DATE").HeaderText = "«· «—ÌŒ"
        DataGridView6.Columns("PCODE").Visible = True
        DataGridView6.Columns("PCODE").HeaderText = "«·ﬂÊœ"
        DataGridView6.Columns("PCODE").Width = 40
        DataGridView6.Columns("YEAR").Visible = True
        DataGridView6.Columns("YEAR").HeaderText = "«·”‰…"
        DataGridView6.Columns("YEAR").Width = 40
        SOT = 2
    End Sub

    Private Sub GlassButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton6.Click
        FKTYPE()

        Dim oj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        oj.Load(Application.StartupPath & "\KTYPE.rpt")
        oj.Database.Tables(0).SetDataSource(clin)
        rp.CrystalReportViewer1.ReportSource = oj
        rp.Show() : rp.Focus()

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged

    End Sub

  
    Private Sub GlassButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton7.Click
        cmdsht.Connection = CN
        cmdsht.CommandType = CommandType.Text
        cmdsht.CommandText = "select * from LPATIEN "
        adsht.SelectCommand = cmdsht
        adsht.Fill(DBS, "sht")
        sht = DBS.Tables("sht")
        DBS.Tables("sht").Clear()
        adsht.Fill(DBS, "sht")
        sht = DBS.Tables("sht")
        DataGridView1.DataSource = sht
        Dim v As Integer = 0
        While Not v = DataGridView1.Columns.Count
            DataGridView1.Columns(v).Visible = False
            v = v + 1
        End While
        DataGridView1.Columns("PNAME").Visible = True
        DataGridView1.Columns("PNAME").HeaderText = "«·„—Ì÷"
        DataGridView1.Columns("PAGE").Visible = True
        DataGridView1.Columns("PAGE").HeaderText = "«·”‰"
        DataGridView1.Columns("PAGE").Width = 40
        DataGridView1.Columns("COMPANY_NAME").Visible = True
        DataGridView1.Columns("COMPANY_NAME").HeaderText = "«·ÃÂ…"
        DataGridView1.Columns("PCODE").Visible = True
        DataGridView1.Columns("PCODE").HeaderText = "«·ﬂÊœ"
        DataGridView1.Columns("PCODE").Width = 40
        DataGridView1.Columns("YEAR").Visible = True
        DataGridView1.Columns("YEAR").HeaderText = "«·”‰…"
        DataGridView1.Columns("YEAR").Width = 40

    End Sub

    Private Sub GlassButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton8.Click
        cmdb.DataAdapter = adsht
        adsht.Update(DBS, "sht")
    End Sub

    Private Sub GlassButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton9.Click
        dr.Close()
      
        cmdtestn.Connection = CN
        cmdtestn.CommandType = CommandType.Text
        cmdtestn.CommandText = "select * from ctest order by code "
        adtestn.SelectCommand = cmdtestn
        adtestn.Fill(DBS, "testn")
        testn = DBS.Tables("testn")
        DBS.Tables("testn").Clear()
        adtestn.Fill(DBS, "testn")
        testn = DBS.Tables("testn")
        DataGridView6.DataSource = testn
        SOT = 3
    End Sub

    Private Sub GlassButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton11.Click
        If SOT = 3 Then
            note.Text = ""
            cmdb.DataAdapter = adtestn
            adtestn.Update(DBS, "testn")
            dr.Close()
            If note.Text = "" Then note.Text = " test required" : tst = 1
            cmd.CommandText = "select * from ctest where res<>'-'"
            dr = cmd.ExecuteReader
            While dr.Read
                note.Text = note.Text & "  " & dr("short") & " (" & dr("res") & ") "
            End While

        ElseIf SOT = 4 Then
            cmdb.DataAdapter = admedcn
            admedcn.Update(DBS, "medcn")
            dr.Close()
            If note.Text <> "" Then note.Text = note.Text & System.Environment.NewLine & " medication required" : mdc = 1
            cmd.CommandText = "select * from cmedc where res<>'-'"
            dr = cmd.ExecuteReader
            While dr.Read
                note.Text = note.Text & "  " & dr("name")
            End While

        End If
    End Sub

    Private Sub GlassButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton10.Click
        dr.Close()
       
        cmdmedcn.Connection = CN
        cmdmedcn.CommandType = CommandType.Text
        cmdmedcn.CommandText = "select * from cmedc order by code "
        admedcn.SelectCommand = cmdmedcn
        admedcn.Fill(DBS, "medcn")
        medcn = DBS.Tables("medcn")
        DBS.Tables("medcn").Clear()
        admedcn.Fill(DBS, "medcn")
        medcn = DBS.Tables("medcn")
        DataGridView6.DataSource = medcn
        SOT = 4

    End Sub

    Private Sub GlassButton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton12.Click
        cmdctest1.Connection = CN
        cmdctest1.CommandType = CommandType.Text
        cmdctest1.CommandText = "SELECT  * from v_test where esl_no='" & esl_no.Text & "'"
        adctest1.SelectCommand = cmdctest1
        adctest1.Fill(DBS, "ctest1")
        ctest1 = DBS.Tables("ctest1")
        DBS.Tables("ctest1").Clear()
        adctest1.Fill(DBS, "ctest1")
        ctest1 = DBS.Tables("ctest1")

        Dim oj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        oj.Load(Application.StartupPath & "\ctest.rpt")
        oj.Database.Tables(0).SetDataSource(ctest1)

        rp.CrystalReportViewer1.ReportSource = oj
        rp.Show() : rp.Focus()
    End Sub

    Private Sub HPT_NAME_KeyDown(ByVal HPTder As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles HPT_NAME.KeyDown
        If e.KeyCode = Keys.ControlKey Then
            FSAVE(HPT_name.Text, "HPT", 1)
        
        ElseIf e.KeyCode = Keys.Delete Then
            FSAVE(HPT_name.Text, "HPT", 2)
        End If
        If e.KeyCode = Keys.F3 Then
            
        End If
    End Sub
    Public Sub HPTFIND(ByVal AA As Int16)
        Dim YY As String = ""
        If AA = 1 Then YY = " AND PCODE ='" & pcode.Text & "'"
        If AA = 2 Then YY = " AND HPT ='" & HPT_NAME.Text & "'"

        cmDTM.Connection = CN
        cmDTM.CommandType = CommandType.Text
        cmDTM.CommandText = "select * from PTH WHERE KY>0  " & YY
        adTM.SelectCommand = cmDTM
        adTM.Fill(DBS, "TM")
        TM = DBS.Tables("TM")
        DBS.Tables("TM").Clear()
        adTM.Fill(DBS, "TM")
        TM = DBS.Tables("TM")
        DataGridView6.DataSource = TM
    End Sub
    Private Sub HPT_NAME_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HPT_NAME.SelectedIndexChanged
        If hpt_name.Focused = False Then Exit Sub
        If hpt_name.Text = "" Then Exit Sub
        FRC = hpt.Select("NAME='" & hpt_name.Text & "'")
        If FRC.Length <= 0 Then
            hpt_name.Text = ""
            HPT_CODE.Text = ""
            Exit Sub
        Else
            RC = FRC(0)
            HPT_CODE.Text = RC("code")
        End If
    End Sub

    Private Sub GlassButton13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton13.Click
        If pname.Text = "" Then MsgBox("«·—Ã«¡ «Œ Ì«— «·„—Ì÷", MsgBoxStyle.Information) : Exit Sub
        If HPT_NAME.Text = "" Then MsgBox("«·—Ã«¡ «Œ Ì«— «· «—ÌŒ «·„—÷Ï", MsgBoxStyle.Information) : Exit Sub
        dr.Close()
        cmd.CommandText = "select * from PTH where HPT='" & HPT_NAME.Text & "' AND PCODE='" & pcode.Text & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = False Then
            dr.Close() : cmd.CommandText = "insert into  PTH  (Pcode,Pname,HPT)  values ('" & pcode.Text & "','" & pname.Text & "','" & HPT_NAME.Text & "')"
            cmd.ExecuteNonQuery()
            MsgBox(" „ «·Õ›Ÿ", MsgBoxStyle.Information)
        End If
        Dim N As String = ""
        dr.Close()
        cmd.CommandText = "select * from PTH where  PCODE='" & pcode.Text & "'"
        dr = cmd.ExecuteReader
        While dr.Read
            If N = "" Then N = dr("HPT") Else N = N & " - " & dr("HPT")
        End While
        dr.Close()
        cmd.CommandText = "UPDATE LPATIEN SET HPT='" & N & "' where  PCODE='" & pcode.Text & "'"
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub GlassButton14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton14.Click
        If pname.Text = "" Then MsgBox("«·—Ã«¡ «Œ Ì«— «·„—Ì÷", MsgBoxStyle.Information) : Exit Sub
        If HPT_NAME.Text = "" Then MsgBox("«·—Ã«¡ «Œ Ì«— «· «—ÌŒ «·„—÷Ï", MsgBoxStyle.Information) : Exit Sub
        Dim AA As String = MsgBox("Â·  —Ìœ «·Õ–› ø ", MsgBoxStyle.YesNo)
        If AA = vbNo Then Exit Sub

        dr.Close()
        cmd.CommandText = "select * from PTH where HPT='" & HPT_NAME.Text & "' AND PCODE='" & pcode.Text & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            dr.Close() : cmd.CommandText = "DELETE from PTH where HPT='" & HPT_NAME.Text & "' AND PCODE='" & pcode.Text & "'"
            cmd.ExecuteNonQuery()
            MsgBox(" „ «·Õ–›", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub BYPATIENToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BYPATIENToolStripMenuItem.Click
        HPTFIND(1)
    End Sub

    Private Sub BYVIRUSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BYVIRUSToolStripMenuItem.Click
        HPTFIND(2)
    End Sub

    Private Sub hour_name_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles hour_name.KeyDown
        If e.KeyCode = Keys.ControlKey Then
            FSAVE(hour_name.Text, "chour", 1)
        ElseIf e.KeyCode = Keys.Delete Then
            FSAVE(hour_name.Text, "chour", 2)
        End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hour_name.SelectedIndexChanged
        If hour_name.Focus = False Then Exit Sub
        If hour_name.Text = "" Then Exit Sub
        pdate.Value = New DateTime(pdate.Value.Year, pdate.Value.Month, pdate.Value.Day, hour_name.Text, pdate.Value.Minute, 0)

    End Sub

    Private Sub minut_name_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles minut_name.KeyDown
        If e.KeyCode = Keys.ControlKey Then
            FSAVE(minut_name.Text, "cminut", 1)
        ElseIf e.KeyCode = Keys.Delete Then
            FSAVE(minut_name.Text, "cminut", 2)
        End If
    End Sub

    Private Sub minut_name_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles minut_name.SelectedIndexChanged
        If minut_name.Focus = False Then Exit Sub
        If minut_name.Text = "" Then Exit Sub
        pdate.Value = New DateTime(pdate.Value.Year, pdate.Value.Month, pdate.Value.Day, pdate.Value.Hour, minut_name.Text, 0)
    End Sub

    Private Sub GlassButton15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton15.Click
        If pname.Text = "" Then MsgBox("«·—Ã«¡ «Œ Ì«— «·„—Ì÷", MsgBoxStyle.Information) : Exit Sub
        If HPT_NAME.Text = "" Then MsgBox("«·—Ã«¡ «Œ Ì«— «· «—ÌŒ «·„—÷Ï", MsgBoxStyle.Information) : Exit Sub
        dr.Close()
        cmd.CommandText = "select * from csetpt where sdate='" & ChangeFormat(pdate.Value) & "' AND PCODE='" & pcode.Text & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = False Then
            dr.Close() : cmd.CommandText = "insert into  csetpt  (Pcode,Pname,gdate,gday,ghour,gminut,sdate)  values ('" & pcode.Text & "','" & pname.Text & "','" & ChangeFormatall(pdate.Value) & "','" & DWEEK.Text & "','" & hour_name.Text & "','" & minut_name.Text & "','" & ChangeFormat(pdate.Value) & "')"
            cmd.ExecuteNonQuery()
        End If

    End Sub

    Private Sub GlassButton16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton16.Click

    End Sub

    Private Sub DWEEK_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DWEEK.SelectedIndexChanged
        If DWEEK.Focus = False Then Exit Sub
        If DWEEK.Text = "" Then Exit Sub

    End Sub

    Private Sub GlassButton17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton17.Click
        Dim x As Date = pdate.Value

        GlassButton15_Click(GlassButton15, e)
        While Not pdate.Value >= DateTimePicker1.Value
            pdate.Value = pdate.Value.AddDays(7)
            GlassButton15_Click(GlassButton15, e)
        End While
        pdate.Value = x
    End Sub

    Private Sub group_name_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles group_name.KeyDown
        If e.KeyCode = Keys.ControlKey Then
            FSAVE(group_name.Text, "cgroup", 1)
        ElseIf e.KeyCode = Keys.Delete Then
            FSAVE(group_name.Text, "cgroup", 2)
        End If
    End Sub

   

    Private Sub group_name_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles group_name.SelectedIndexChanged
        If group_name.Focused = False Then Exit Sub
        If group_name.Text = "" Then Exit Sub
        FRC = group.Select("NAME='" & group_name.Text & "'")
        If FRC.Length <= 0 Then
            group_name.Text = ""
            group_code.Text = ""
            Exit Sub
        Else
            RC = FRC(0)
            group_code.Text = RC("code")
        End If
    End Sub

    Private Sub GlassButton18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton18.Click
        
        Dim x As Date = pdate.Value

        savegroup()
        While Not pdate.Value >= DateTimePicker2.Value
            pdate.Value = pdate.Value.AddDays(7)
            savegroup()
        End While
        pdate.Value = x
    End Sub
    Public Sub savegroup()
        If group_name.Text = "" Then MsgBox("«·—Ã«¡ «Œ Ì«— «·„Ã„Ê⁄…", MsgBoxStyle.Information) : Exit Sub
        dr.Close()
        cmd.CommandText = "select * from csetgp where sdate='" & ChangeFormat(pdate.Value) & "' AND gCODE='" & group_code.Text & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = False Then
            dr.Close() : cmd.CommandText = "insert into  csetgp  (gcode,gname,gdate,gday,ghour,gminut,sdate)  values ('" & group_code.Text & "','" & group_name.Text & "','" & ChangeFormatall(pdate.Value) & "','" & DWEEK.Text & "','" & hour_name.Text & "','" & minut_name.Text & "','" & ChangeFormat(pdate.Value) & "')"
            cmd.ExecuteNonQuery()
        End If

    End Sub

    Private Sub GlassButton19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton19.Click
        If pname.Text = "" Then MsgBox("«·—Ã«¡ «Œ Ì«— «·„—Ì÷", MsgBoxStyle.Information) : Exit Sub
        If group_name.Text = "" Then MsgBox("«·—Ã«¡ «Œ Ì«— «·„Ã„Ê⁄…", MsgBoxStyle.Information) : Exit Sub
        Dim AA As String = MsgBox("Â·  —Ìœ Õ›Ÿ Ã·”«  «·„Ã„Ê⁄… ··„—Ì÷ ø ", MsgBoxStyle.YesNo)
        If AA = vbNo Then Exit Sub
        dr.Close()
        cmd.CommandText = "delete from csetpt where PCODE='" & pcode.Text & "'"
        cmd.ExecuteNonQuery()
        dr.Close()
        cmd.CommandText = "select * from csetgp where gcode='" & group_code.Text & "'"
        dr = cmd.ExecuteReader
        dr1.Close()
        While dr.Read
            cmd1.CommandText = "insert into  csetpt  (Pcode,Pname,gdate,gday,ghour,gminut,sdate)  values ('" & pcode.Text & "','" & pname.Text & "','" & ChangeFormatall(dr("gdate")) & "','" & dr("gday") & "','" & dr("ghour") & "','" & dr("gminut") & "','" & ChangeFormat(dr("sdate")) & "')"
            cmd1.ExecuteNonQuery()
        End While
        MsgBox(" „ «·Õ›Ÿ")
    End Sub

    Private Sub bed_name_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles bed_name.KeyDown
        If e.KeyCode = Keys.ControlKey Then
            FSAVE(bed_name.Text, "cbed", 1)
        ElseIf e.KeyCode = Keys.Delete Then
            FSAVE(bed_name.Text, "cbed", 2)
        End If

    End Sub

    Private Sub bed_name_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bed_name.SelectedIndexChanged
        If bed_name.Focused = False Then Exit Sub
        If bed_name.Text = "" Then Exit Sub
        FRC = bed.Select("NAME='" & bed_name.Text & "'")
        If FRC.Length <= 0 Then
            bed_name.Text = ""
            bed_code.Text = ""
            Exit Sub
        Else
            RC = FRC(0)
            bed_code.Text = RC("code")
        End If
    End Sub

    Private Sub GlassButton20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton20.Click
        If pname.Text = "" Then MsgBox("«·—Ã«¡ «Œ Ì«— «·„—Ì÷", MsgBoxStyle.Information) : Exit Sub
        If bed_name.Text = "" Then MsgBox("«·—Ã«¡ «Œ Ì«— «· «—ÌŒ «·„—÷Ï", MsgBoxStyle.Information) : Exit Sub
        dr.Close()
        cmd.CommandText = "update sgtransdet set qun='1'"
        cmd.ExecuteNonQuery()
        Dim sn As Integer = 0
        cmd.CommandText = "select * from csetpt  where sdate='" & ChangeFormat(pdate.Value) & "' AND PCODE='" & pcode.Text & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        If dr("sn") = 0 Then
            dr.Close()
            cmd.CommandText = "select max(sn) from Strans "
            dr = cmd.ExecuteReader
            dr.Read()
            If IsDBNull(dr(0)) = False Then sn = Val(dr(0)) + 1 Else sn = 1
           
        Else
            sn = dr("sn")
        End If
        dr.Close()
        dr.Close()
        cmd.CommandText = "update sgtransdet set qun='" & Val(hip.Text) & "' where item_code=1"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "update sgtransdet set qun='" & Val(na.Text) & "' where item_code=2"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "update sgtransdet set qun='" & Val(glyco.Text) & "' where item_code=3"
        cmd.ExecuteNonQuery()
        dr.Close()

        cmd.CommandText = "delete from STRANS where sn='" & sn & "'"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "delete from STRANSdet where sn='" & sn & "'"
        cmd.ExecuteNonQuery()
        dr.Close()
        dr1.Close()
        cmd.CommandText = "select * from sgtrans "
        dr = cmd.ExecuteReader
        While dr.Read
            cmd1.CommandText = "INSERT INTO [ASILLAB].[dbo].[STRANS]([CUST_NAME],[CUST_CODE],[DISSN],[DISSV],[PAY],[REST],[STOC_NAME],[STOC_CODE],[NOTE],[MOVE_NAME],[MOVE_CODE],[SUP_NAME],[SUP_CODE],[SN],[SDATE],[PTOT])VALUES ('" & pname.Text & " ','" & pcode.Text & "','" & dr("DISSN") & "','" & dr("DISSV") & "','" & dr("PAY") & "','" & dr("REST") & "','" & dr("STOC_NAME") & "','" & dr("STOC_CODE") & "','" & dr("NOTE") & "','" & dr("MOVE_NAME") & "','" & dr("MOVE_CODE") & "','" & dr("SUP_NAME") & "','" & dr("SUP_CODE") & "','" & sn & "','" & ChangeFormat(Now) & "','" & dr("PTOT") & "')"
            cmd1.ExecuteNonQuery()
        End While
        dr.Close()
        cmd.CommandText = "select * from sgtransdet  "
        dr = cmd.ExecuteReader
        While dr.Read
            cmd1.CommandText = "INSERT INTO [ASILLAB].[dbo].[STRANSDET]([SN],[ITEM_NAME],[ITEM_CODE],[PRICE],[TOT],[QUN],[FLG],[SDATE])VALUES ('" & sn & " ','" & dr("ITEM_NAME") & "','" & dr("ITEM_CODE") & "','" & dr("price") & "','" & dr("TOT") & "','" & dr("qun") & "','" & dr("FLG") & "','" & ChangeFormat(Now) & "')"
            cmd1.ExecuteNonQuery()
        End While
        dr.Close()
        cmd.CommandText = "update csetpt set bed='" & bed_name.Text & "',chour='" & hour_name.Text & "',cminut='" & minut_name.Text & "',wib='" & wib.Text & "',wia='" & wia.Text & "',pusrb='" & pusrb.Text & "',pusra='" & pusra.Text & "',hip='" & hip.Text & "',na='" & na.Text & "',glyco='" & glyco.Text & "',medc='" & medc1.Text & "',note='" & note.Text & "',sn='" & sn & "',come='1' where sdate='" & ChangeFormat(pdate.Value) & "' AND PCODE='" & pcode.Text & "'"
        cmd.ExecuteNonQuery()
        MsgBox(" „  ”ÃÌ· «·Ã·”…")
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub ccompl_name_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ccompl_name.CheckedChanged

    End Sub

    Private Sub compl_code_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles compl_code.TextChanged

    End Sub

    Private Sub AYADA_CODE_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AYADA_CODE.TextChanged

    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHPT.CheckedChanged

    End Sub

    Private Sub GlassButton21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton21.Click
        Dim yy As String = "  where KY>0"
        If cpnik.Checked = True Then yy = yy & " and pnik='" & PNIK.Text & "'"
        If cpcode.Checked = True Then yy = yy & " and pcode='" & pcode.Text & "' and YEAR='" & year.Text & "'"
        If cptype.Checked = True Then yy = yy & " and ptype='" & ptype.Text & "'"
        If cpbrith_date.Checked = True Then yy = yy & " and pbrith_date='" & ChangeFormat(pbrith_date.Value) & "'"
        If cpage.Checked = True Then yy = yy & " and page='" & page.Text & "'"
        If cpmobile.Checked = True Then yy = yy & " and pmobile='" & pmobile.Text & "'"
        If cpemail.Checked = True Then yy = yy & " and pemail='" & pemail.Text & "'"
        If cpid.Checked = True Then yy = yy & " and pid='" & pid.Text & "'"
        If cCOMPANY_CODE.Checked = True Then yy = yy & " and COMPANY_CODE='" & COMPANY_CODE.Text & "'"
        If cblood_name.Checked = True Then yy = yy & " and blood_name='" & blood_name.Text & "'"
        If csen_name.Checked = True Then yy = yy & " and sen_name='" & sen_name.Text & "'"
        If ccompl_name.Checked = True Then yy = yy & " and compl_name='" & compl_name.Text & "'"
        If CHPT.Checked = True Then yy = yy & " and HPT like '%" & HPT_NAME.Text & "%'"
        SOT = 1
        cmdPT.Connection = CN
        cmdPT.CommandType = CommandType.Text
        cmdPT.CommandText = "select * from LPATIEN " & yy
        adPT.SelectCommand = cmdPT
        adPT.Fill(DBS, "PT")
        PT = DBS.Tables("PT")
        DBS.Tables("PT").Clear()
        adPT.Fill(DBS, "PT")
        PT = DBS.Tables("PT")
        DataGridView6.DataSource = PT
        Dim oj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        oj.Load(Application.StartupPath & "\PATIENC.rpt")
        oj.Database.Tables(0).SetDataSource(PT)
        rp.CrystalReportViewer1.ReportSource = oj
        rp.Show() : rp.Focus()
    End Sub

    Private Sub GlassButton22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton22.Click
        Dim yy As String = "  where  sdate between '" & ChangeFormat(d2.Value) & "' and '" & ChangeFormat(d2.Value) & "'"
        If cpnik.Checked = True Then yy = yy & " and pnik='" & PNIK.Text & "'"
        If cpcode.Checked = True Then yy = yy & " and pcode='" & pcode.Text & "' and YEAR='" & year.Text & "'"
        If cptype.Checked = True Then yy = yy & " and ptype='" & ptype.Text & "'"
        If cpbrith_date.Checked = True Then yy = yy & " and pbrith_date='" & ChangeFormat(pbrith_date.Value) & "'"
        If cpage.Checked = True Then yy = yy & " and page='" & page.Text & "'"
        If cpmobile.Checked = True Then yy = yy & " and pmobile='" & pmobile.Text & "'"
        If cpemail.Checked = True Then yy = yy & " and pemail='" & pemail.Text & "'"
        If cpid.Checked = True Then yy = yy & " and pid='" & pid.Text & "'"
        If cCOMPANY_CODE.Checked = True Then yy = yy & " and COMPANY_CODE='" & COMPANY_CODE.Text & "'"
        If cblood_name.Checked = True Then yy = yy & " and blood_name='" & blood_name.Text & "'"
        If csen_name.Checked = True Then yy = yy & " and sen_name='" & sen_name.Text & "'"
        If ccompl_name.Checked = True Then yy = yy & " and compl_name='" & compl_name.Text & "'"
        If CHPT.Checked = True Then yy = yy & " and HPT like '%" & HPT_NAME.Text & "%'"
        SOT = 1
        cmdPT.Connection = CN
        cmdPT.CommandType = CommandType.Text
        cmdPT.CommandText = "select * from vclinic " & yy & " order by gdate"
        adPT.SelectCommand = cmdPT
        adPT.Fill(DBS, "PT")
        PT = DBS.Tables("PT")
        DBS.Tables("PT").Clear()
        adPT.Fill(DBS, "PT")
        PT = DBS.Tables("PT")
        DataGridView6.DataSource = PT
        Dim oj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        oj.Load(Application.StartupPath & "\glasa.rpt")
        oj.Database.Tables(0).SetDataSource(PT)
        rp.CrystalReportViewer1.ReportSource = oj
        rp.Show() : rp.Focus()
    End Sub

    Private Sub GlassButton23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton23.Click
        Dim yy As String = "  where come>0 and sdate between '" & ChangeFormat(d2.Value) & "' and '" & ChangeFormat(d2.Value) & "'"
        If chip.Checked = True Then yy = yy & " and hip='" & hip.Text & "'"
        If cna.Checked = True Then yy = yy & " and na='" & na.Text & "'"
        If cglyco.Checked = True Then yy = yy & " and glyco='" & glyco.Text & "'"
        If cwib.Checked = True Then yy = yy & " and wib='" & wib.Text & "'"
        If cwia.Checked = True Then yy = yy & " and wia='" & wia.Text & "'"
        If cpusrb.Checked = True Then yy = yy & " and pusrb='" & pusrb.Text & "'"
        If cpusra.Checked = True Then yy = yy & " and pusra='" & pusra.Text & "'"
        If cnote.Checked = True Then yy = yy & " and note='" & note.Text & "'"
        If cmedc1.Checked = True Then yy = yy & " and medc='" & medc1.Text & "'"
        If cpcode.Checked = True Then yy = yy & " and pcode='" & pcode.Text & "'"
        SOT = 1
        cmdcr.Connection = CN
        cmdcr.CommandType = CommandType.Text
        cmdcr.CommandText = "select * from csetpt " & yy
        adcr.SelectCommand = cmdcr
        adcr.Fill(DBS, "cr")
        cr = DBS.Tables("cr")
        DBS.Tables("cr").Clear()
        adcr.Fill(DBS, "cr")
        cr = DBS.Tables("cr")
        Dim oj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        oj.Load(Application.StartupPath & "\cstoc.rpt")
        oj.Database.Tables(0).SetDataSource(cr)
        rp.CrystalReportViewer1.ReportSource = oj
        rp.Show() : rp.Focus()
    End Sub

    Private Sub GlassButton24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton24.Click
        cmdPT1.Connection = CN
        cmdPT1.CommandText = "select item_name,minm,SUM (QUN*FLG) as qun from VSTOC GROUP BY item_name,minm"
        adPT1.SelectCommand = cmdPT1
        adPT1.Fill(DBS, "pt1")
        PT1 = DBS.Tables("pt1")
        DBS.Tables("pt1").Clear()
        adPT1.Fill(DBS, "pt1")
        PT1 = DBS.Tables("pt1")

        Dim oj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        oj.Load(Application.StartupPath & "\srsd.rpt")
        oj.Database.Tables(0).SetDataSource(PT1)
        rp.CrystalReportViewer1.ReportSource = oj
        rp.Show() : rp.Focus()
    End Sub

    Private Sub GlassButton25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton25.Click
       
        wib.Text = 0
        wia.Text = 0
        pusrb.Text = 0
        pusra.Text = 0
        hip.Text = 0
        na.Text = 0
        glyco.Text = 0
        medc1.Text = 0
        note.Text = 0
        dr.Close()
        cmd.CommandText = "select * from csetpt where sdate ='" & ChangeFormat(pdate.Value) & "' AND PCODE='" & pcode.Text & "'"
        dr = cmd.ExecuteReader
        While dr.Read
            bed_name.Text = dr("bed")
            hour_name.Text = dr("chour")
            minut_name.Text = dr("cminut")
            wib.Text = dr("wib")
            wia.Text = dr("wia")
            pusrb.Text = dr("pusrb")
            pusra.Text = dr("pusra")
            hip.Text = dr("hip")
            na.Text = dr("na")
            glyco.Text = dr("glyco")
            medc1.Text = dr("medc")
            note.Text = dr("note")
        End While
    End Sub

    Private Sub id_name_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles id_name.SelectedIndexChanged

    End Sub

    Private Sub GlassButton26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton26.Click
        Dim n As String = MsgBox("Â·  —Ìœ «·«”ﬂ«‰— ", MsgBoxStyle.YesNo)
        If n = vbNo Then Exit Sub
        ACdr.Close()
        ACcmd.CommandText = "select * from srv "
        ACdr = ACcmd.ExecuteReader
        ACdr.Read()
        Dim FileNames = TwainLib.ScanImages(id_name.Text & pcode.Text, True, ACdr("scan"))
        'NREF.Text = TwainLib.TwainOperations.GetScanSource
        PictureBox1.ImageLocation = FileNames(0)
        Dim oer As System.IO.FileStream
        Dim rer As IO.StreamReader
        oer = New IO.FileStream(FileNames(0), IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.Read)
        rer = New IO.StreamReader(oer)
        Dim FileByteArrayr(oer.Length - 1) As Byte
        oer.Read(FileByteArrayr, 0, oer.Length)
        dr.Close()
        If IO.Directory.Exists("d:\images\" & pname.Text) = False Then IO.Directory.CreateDirectory("d:\images\" & pname.Text)
        IO.File.Copy(FileNames(0), "d:\images\" & pname.Text & "\" & id_name.Text & ".jpg")
        If id_name.Text = "" Then MsgBox("«·—Ã«¡ «Œ Ì«—  ‰Ê⁄ Ê—ﬁ… ") : Exit Sub
        dr.Close() : dr.Close() : cmd.CommandText = "select * from cimage where   id_name='" & Val(id_name.Text) & "' AND pcode='" & pcode.Text & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            Dim x As String
            dr.Close()
            x = MsgBox("Â·  —Ìœ «· ⁄œÌ· ø", MsgBoxStyle.YesNo)
            If x = vbNo Then Exit Sub
            dr.Close() : dr.Close() : cmd.CommandText = "delete from cimage where  where  id_name='" & id_name.Text & "' AND pcode='" & pcode.Text & "'"
            cmd.ExecuteNonQuery()
        End If
        dr.Close()
        cmd.CommandText = "insert into cimage (id_name,pCODE,pname) values ('" & id_name.Text & "','" & pcode.Text & "','" & pname.Text & "')"
        cmd.ExecuteNonQuery()
        Dim Sql As String = "update  cimage set image = ? , no = ? where  id_name='" & id_name.Text & "' AND pcode='" & pcode.Text & "'"
        cmd.CommandText = Sql
        cmd.Parameters.Clear()
        cmd.Parameters.Add("@image", System.Data.OleDb.OleDbType.Binary, oer.Length).Value = FileByteArrayr
        cmd.Parameters.Add("@no", System.Data.OleDb.OleDbType.VarChar, 100).Value = oer.Length
        cmd.ExecuteNonQuery()
        MsgBox(" „  ⁄„·Ì… «·Õ›Ÿ")
    End Sub
End Class
