Public Class netcust
    Dim cmdpiont As New OleDb.OleDbCommand
    Dim adpiont As New OleDb.OleDbDataAdapter
    Dim piont As New DataTable
    Dim cmdpart As New OleDb.OleDbCommand
    Dim adpart As New OleDb.OleDbDataAdapter
    Dim part As New DataTable
    Dim cmdaddress As New OleDb.OleDbCommand
    Dim adaddress As New OleDb.OleDbDataAdapter
    Dim address As New DataTable
    Dim cmdspeed As New OleDb.OleDbCommand
    Dim adspeed As New OleDb.OleDbDataAdapter
    Dim speed As New DataTable
    Dim cmdstat As New OleDb.OleDbCommand
    Dim adstat As New OleDb.OleDbDataAdapter
    Dim stat As New DataTable
    Dim cmdTCUST As New OleDb.OleDbCommand
    Dim adTCUST As New OleDb.OleDbDataAdapter
    Dim TCUST As New DataTable
    Dim cmdsCUST As New OleDb.OleDbCommand
    Dim adsCUST As New OleDb.OleDbDataAdapter
    Dim sCUST As New DataTable
    Dim cmdeng As New OleDb.OleDbCommand
    Dim adeng As New OleDb.OleDbDataAdapter
    Dim eng As New DataTable
    Dim cmdprolm As New OleDb.OleDbCommand
    Dim adprolm As New OleDb.OleDbDataAdapter
    Dim prolm As New DataTable
    Dim cmdpos As New OleDb.OleDbCommand
    Dim adpos As New OleDb.OleDbDataAdapter
    Dim pos As New DataTable
    Dim cmdevent1 As New OleDb.OleDbCommand
    Dim adevent1 As New OleDb.OleDbDataAdapter
    Dim event1 As New DataTable
    Dim cmdcash1 As New OleDb.OleDbCommand
    Dim adcash1 As New OleDb.OleDbDataAdapter
    Dim cash1 As New DataTable
    Dim N As String = ""
    Dim n1, gt As Integer
   
   
    Public Sub FSAVE(ByVal NNAME As String, ByVal TB As String, ByVal PR As Int16, ByVal f As String, ByVal v As String)
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
            Else
                dr.Close()
                cmd.CommandText = "delete from " & TB & " where name='" & NNAME & "'"
                cmd.ExecuteNonQuery()
            End If
            dr.Close() : cmd.CommandText = "insert into  " & TB & "  (code,name" & f & ")  values ('" & N & "','" & NNAME & "'" & v & ")"
            cmd.ExecuteNonQuery()
            filla(TB)

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
        If tb = "npiont" Or tb = "" Then
            cmdpiont.Connection = CN
            cmdpiont.CommandType = CommandType.Text
            cmdpiont.CommandText = "select * from npiont where part_name='" & part_name.Text & "'"
            adpiont.SelectCommand = cmdpiont
            adpiont.Fill(DBS, "piont")
            piont = DBS.Tables("piont")
            DBS.Tables("piont").Clear()
            adpiont.Fill(DBS, "piont")
            piont = DBS.Tables("piont")
            piont_name.DataSource = piont
            piont_name.DisplayMember = "name"
            If piont.Rows.Count > 0 Then
                piont_name.Text = piont.Rows(piont.Rows.Count - 1).Item("name")
                piont_code.Text = piont.Rows(piont.Rows.Count - 1).Item("code")
            End If
            '========================================
        End If
        If tb = "npos" Or tb = "" Then
            cmdpos.Connection = CN
            cmdpos.CommandType = CommandType.Text
            cmdpos.CommandText = "select * from npos "
            adpos.SelectCommand = cmdpos
            adpos.Fill(DBS, "pos")
            pos = DBS.Tables("pos")
            DBS.Tables("pos").Clear()
            adpos.Fill(DBS, "pos")
            pos = DBS.Tables("pos")
            pos_name.DataSource = pos
            pos_name.DisplayMember = "name"
            If pos.Rows.Count > 0 Then
                pos_name.Text = pos.Rows(pos.Rows.Count - 1).Item("name")
                pos_code.Text = pos.Rows(pos.Rows.Count - 1).Item("code")
            End If
            '========================================
        End If
        If tb = "nprolm" Or tb = "" Then
            cmdprolm.Connection = CN
            cmdprolm.CommandType = CommandType.Text
            cmdprolm.CommandText = "select * from nprolm "
            adprolm.SelectCommand = cmdprolm
            adprolm.Fill(DBS, "prolm")
            prolm = DBS.Tables("prolm")
            DBS.Tables("prolm").Clear()
            adprolm.Fill(DBS, "prolm")
            prolm = DBS.Tables("prolm")
            prolm_name.DataSource = prolm
            prolm_name.DisplayMember = "name"
            If prolm.Rows.Count > 0 Then
                prolm_name.Text = prolm.Rows(prolm.Rows.Count - 1).Item("name")
                prolm_code.Text = prolm.Rows(prolm.Rows.Count - 1).Item("code")
            End If
            '========================================
        End If
        If tb = "neng" Or tb = "" Then
            cmdeng.Connection = CN
            cmdeng.CommandType = CommandType.Text
            cmdeng.CommandText = "select * from neng "
            adeng.SelectCommand = cmdeng
            adeng.Fill(DBS, "eng")
            eng = DBS.Tables("eng")
            DBS.Tables("eng").Clear()
            adeng.Fill(DBS, "eng")
            eng = DBS.Tables("eng")
            eng_name.DataSource = eng
            eng_name.DisplayMember = "name"
            If eng.Rows.Count > 0 Then
                eng_name.Text = eng.Rows(eng.Rows.Count - 1).Item("name")
                eng_code.Text = eng.Rows(eng.Rows.Count - 1).Item("code")
            End If
            '========================================
        End If
        If tb = "npart" Or tb = "" Then
            cmdpart.Connection = CN
            cmdpart.CommandType = CommandType.Text
            cmdpart.CommandText = "select * from npart "
            adpart.SelectCommand = cmdpart
            adpart.Fill(DBS, "part")
            part = DBS.Tables("part")
            DBS.Tables("part").Clear()
            adpart.Fill(DBS, "part")
            part = DBS.Tables("part")
            part_name.DataSource = part
            part_name.DisplayMember = "name"
            If part.Rows.Count > 0 Then
                part_name.Text = part.Rows(part.Rows.Count - 1).Item("name")
                part_code.Text = part.Rows(part.Rows.Count - 1).Item("code")
            End If
            '========================================
        End If
        If tb = "naddress" Or tb = "" Then
            cmdaddress.Connection = CN
            cmdaddress.CommandType = CommandType.Text
            cmdaddress.CommandText = "select * from naddress "
            adaddress.SelectCommand = cmdaddress
            adaddress.Fill(DBS, "address")
            address = DBS.Tables("address")
            DBS.Tables("address").Clear()
            adaddress.Fill(DBS, "address")
            address = DBS.Tables("address")
            address_name.DataSource = address
            address_name.DisplayMember = "name"
            If address.Rows.Count > 0 Then
                address_name.Text = address.Rows(address.Rows.Count - 1).Item("name")
                address_code.Text = address.Rows(address.Rows.Count - 1).Item("code")
            End If
            '========================================
        End If
        If tb = "nspeed" Or tb = "" Then
            cmdspeed.Connection = CN
            cmdspeed.CommandType = CommandType.Text
            cmdspeed.CommandText = "select * from nspeed "
            adspeed.SelectCommand = cmdspeed
            adspeed.Fill(DBS, "speed")
            speed = DBS.Tables("speed")
            DBS.Tables("speed").Clear()
            adspeed.Fill(DBS, "speed")
            speed = DBS.Tables("speed")
            speed_name.DataSource = speed
            speed_name.DisplayMember = "name"
            If speed.Rows.Count > 0 Then
                speed_name.Text = speed.Rows(speed.Rows.Count - 1).Item("name")
                speed_code.Text = speed.Rows(speed.Rows.Count - 1).Item("code")
                price.Text = speed.Rows(speed.Rows.Count - 1).Item("price")

            End If
            '========================================
        End If
        If tb = "nstat" Or tb = "" Then
            cmdstat.Connection = CN
            cmdstat.CommandType = CommandType.Text
            cmdstat.CommandText = "select * from nstat "
            adstat.SelectCommand = cmdstat
            adstat.Fill(DBS, "stat")
            stat = DBS.Tables("stat")
            DBS.Tables("stat").Clear()
            adstat.Fill(DBS, "stat")
            stat = DBS.Tables("stat")
            stat_name.DataSource = stat
            stat_name.DisplayMember = "name"
            If stat.Rows.Count > 0 Then
                stat_name.Text = stat.Rows(stat.Rows.Count - 1).Item("name")
                stat_code.Text = stat.Rows(stat.Rows.Count - 1).Item("code")
            End If
            '========================================
        End If
    End Sub

    Private Sub stat_name_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles stat_name.GotFocus
        flng("EN")

    End Sub

    Private Sub stat_name_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles stat_name.KeyDown
        If e.KeyCode = Keys.ControlKey Then
            FSAVE(stat_name.Text, "nstat", 1, "", "")
        ElseIf e.KeyCode = Keys.Enter Then
            part_name.Focus()
        ElseIf e.KeyCode = Keys.Delete Then
            FSAVE(stat_name.Text, "nstat", 2, "", "")
        End If
    End Sub
    Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stat_name.SelectedIndexChanged
        If stat_name.Focused = False Then Exit Sub
        If stat_name.Text = "" Then Exit Sub
        FRC = stat.Select("NAME='" & stat_name.Text & "'")
        If FRC.Length <= 0 Then
            stat_name.Text = ""
            stat_code.Text = ""
            Exit Sub
        Else
            RC = FRC(0)
            stat_code.Text = RC("code")
        End If
    End Sub

    Private Sub netcust_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        filla("")
        dr.Close()
        main_name.Items.Clear()
        cmd.CommandText = "select * from lmain "
        dr = cmd.ExecuteReader
        While dr.Read
            main_name.Items.Add(dr("name"))
        End While
        dr.Close()
        sub_name.Items.Clear()
        cmd.CommandText = "select * from lsub "
        dr = cmd.ExecuteReader
        While dr.Read
            sub_name.Items.Add(dr("sub_name"))
        End While
        ACdr.Close() : ACcmd.CommandText = "select * from srv "
        ACdr = ACcmd.ExecuteReader
        ACdr.Read()
        If ACdr.HasRows Then
           
            branch_code.Text = ACdr("BRANCH")
        End If
    End Sub

    Private Sub address_name_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles address_name.GotFocus
        flng("AR")

    End Sub

    Private Sub address_name_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles address_name.KeyDown
        If e.KeyCode = Keys.ControlKey Then
            FSAVE(address_name.Text, "naddress", 1, "", "")
        ElseIf e.KeyCode = Keys.Enter Then
            start_date.Focus()
        ElseIf e.KeyCode = Keys.Delete Then
            FSAVE(address_name.Text, "naddress", 2, "", "")
        End If
    End Sub

    Private Sub address_name_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles address_name.SelectedIndexChanged
        If address_name.Focused = False Then Exit Sub
        If address_name.Text = "" Then Exit Sub
        FRC = address.Select("NAME='" & address_name.Text & "'")
        If FRC.Length <= 0 Then
            address_name.Text = ""
            address_code.Text = ""
            Exit Sub
        Else
            RC = FRC(0)
            address_code.Text = RC("code")
        End If
    End Sub

    Private Sub start_date_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles start_date.KeyDown
        If e.KeyCode = Keys.Enter Then
            speed_name.Focus()
        End If
    End Sub

    Private Sub start_date_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles start_date.ValueChanged

    End Sub

    Private Sub speed_name_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles speed_name.KeyDown
        If e.KeyCode = Keys.ControlKey Then
            n1 = InputBox("«œŒ· ”⁄— «·”—⁄…")

            FSAVE(speed_name.Text, "nspeed", 1, ",price", ",'" & n1 & "'")
        ElseIf e.KeyCode = Keys.Enter Then
            stat_name.Focus()
        ElseIf e.KeyCode = Keys.Delete Then
            FSAVE(speed_name.Text, "nspeed", 2, ",price", ",'" & n1 & "'")
        End If
    End Sub

    Private Sub speed_name_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles speed_name.SelectedIndexChanged
        If speed_name.Focused = False Then Exit Sub
        If speed_name.Text = "" Then Exit Sub
        FRC = speed.Select("NAME='" & speed_name.Text & "'")
        If FRC.Length <= 0 Then
            speed_name.Text = ""
            speed_code.Text = ""
            Exit Sub
        Else
            RC = FRC(0)
            speed_code.Text = RC("code")
            price.Text = RC("price")

        End If
    End Sub

    Private Sub part_name_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles part_name.KeyDown
        If e.KeyCode = Keys.ControlKey Then
            FSAVE(part_name.Text, "npart", 1, "", "")
        ElseIf e.KeyCode = Keys.Enter Then
            piont_name.Focus()
        ElseIf e.KeyCode = Keys.Delete Then
            FSAVE(part_name.Text, "npart", 2, "", "")
        End If
    End Sub

    Private Sub part_name_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles part_name.SelectedIndexChanged
        If part_name.Focused = False Then Exit Sub
        If part_name.Text = "" Then Exit Sub
        FRC = part.Select("NAME='" & part_name.Text & "'")
        If FRC.Length <= 0 Then
            part_name.Text = ""
            part_code.Text = ""
            Exit Sub
        Else
            RC = FRC(0)
            part_code.Text = RC("code")
            dr.Close()
            user_name.Items.Clear()
            cmd.CommandText = "select * from ncust where part_code='" & part_code.Text & "'"
            dr = cmd.ExecuteReader
            While dr.Read
                user_name.Items.Add(dr("user_name"))
            End While
            cmdpiont.Connection = CN
            cmdpiont.CommandType = CommandType.Text
            cmdpiont.CommandText = "select * from npiont where part_name='" & part_name.Text & "'"
            adpiont.SelectCommand = cmdpiont
            adpiont.Fill(DBS, "piont")
            piont = DBS.Tables("piont")
            DBS.Tables("piont").Clear()
            adpiont.Fill(DBS, "piont")
            piont = DBS.Tables("piont")
            piont_name.DataSource = piont
            piont_name.DisplayMember = "name"
        End If
    End Sub

    Private Sub piont_name_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles piont_name.KeyDown
        If e.KeyCode = Keys.ControlKey Then
            FSAVE(piont_name.Text, "npiont", 1, ",part_code,part_name", ",'" & part_code.Text & "','" & part_name.Text & "'")
        ElseIf e.KeyCode = Keys.Enter Then
            user_name.Focus()
        ElseIf e.KeyCode = Keys.Delete Then
            FSAVE(piont_name.Text, "npiont", 2, "", "")
        End If
    End Sub

    Private Sub piont_name_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles piont_name.SelectedIndexChanged
        If piont_name.Focused = False Then Exit Sub
        If piont_name.Text = "" Then Exit Sub
        FRC = piont.Select("NAME='" & piont_name.Text & "'")
        If FRC.Length <= 0 Then
            piont_name.Text = ""
            piont_code.Text = ""
            Exit Sub
        Else
            RC = FRC(0)
            piont_code.Text = RC("code")
        End If
    End Sub

    Private Sub user_name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub notse_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles notse.KeyDown
        If e.KeyCode = Keys.Enter Then
            GlassButton35_Click(GlassButton35, e)
        End If
    End Sub


    Private Sub notse_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles notse.TextChanged

    End Sub

    Private Sub user_name_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles user_name.GotFocus
        flng("EN")

    End Sub

    Private Sub user_name_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles user_name.KeyDown
        If e.KeyCode = Keys.Enter Then
            notse.Focus()
        End If
    End Sub

    Private Sub user_name_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles user_name.SelectedIndexChanged

    End Sub

    Private Sub GlassButton35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton35.Click
        If nname.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «”„ «·„—Ì÷") : Exit Sub
        If Val(ncode.Text) = 0 Then
            dr.Close()
            cmd.CommandText = "select max(code) from  ncust"
            dr = cmd.ExecuteReader
            dr.Read()
            If IsDBNull(dr(0)) = False Then ncode.Text = 1 + dr(0) Else ncode.Text = 1
        End If
        dr.Close()
        cmd.CommandText = "select * from ncust where CODE='" & ncode.Text & "' "
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            N = MsgBox(" Â·  —Ìœ  ⁄œÌ· »Ì«‰«  «·⁄„Ì·  " & nname.Text, MsgBoxStyle.YesNo + MsgBoxStyle.Question)
            If N = vbNo Then Exit Sub
            dr.Close()
            cmd.CommandText = "delete from ncust where CODE='" & ncode.Text & "' "
            cmd.ExecuteNonQuery()
        Else
            
        End If
        If UCase(stat_name.Text) <> "NOT" Then

            dr.Close()
            cmd.CommandText = "select * from NPAID where CODE='" & ncode.Text & "'"
            dr = cmd.ExecuteReader
            If dr.HasRows = False Then
                dr.Close()
                Dim s As Integer = 1
                While Not s = 13
                    cmd.CommandText = "INSERT INTO [ASILLAB].[dbo].[npaid]([name],[code],mon,yearn) values ('" & nname.Text & "','" & ncode.Text & "','" & s & "','" & yearn.Text & "')"
                    cmd.ExecuteNonQuery()
                    s += 1
                End While
            End If

        End If
        dr.Close()
        cmd.CommandText = "INSERT INTO [ASILLAB].[dbo].[ncust]([name],[code],[mobile],[address_name],[piont_name],[piont_code],[part_name],[part_code],[start_date],[speed_name],[speed_code],[stat_name],[stat_code],[user_name],[notse],[address_code],[eng_name],[eng_code],email,on1)  VALUES ('" & nname.Text & "','" & ncode.Text & "','" & mobile.Text & "','" & address_name.Text & "','" & piont_name.Text & "','" & piont_code.Text & "','" & part_name.Text & "','" & part_code.Text & "','" & ChangeFormat(start_date.Value) & "','" & speed_name.Text & "','" & speed_code.Text & "','" & stat_name.Text & "','" & stat_code.Text & "','" & user_name.Text & "','" & notse.Text & "','" & address_code.Text & "','" & eng_name.Text & "','" & eng_code.Text & "','" & email.Text & "','" & on1.Text & "')"
        cmd.ExecuteNonQuery()
        MsgBox("   „ ⁄„·Ì… Õ›Ÿ «·⁄„Ì·  " & nname.Text, MsgBoxStyle.Information)
        nname.Focus()

    End Sub

    Private Sub GlassButton36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton36.Click
        dr.Close()
        cmd.CommandText = "select max(code) from  ncust"
        dr = cmd.ExecuteReader
        dr.Read()
        If IsDBNull(dr(0)) = False Then ncode.Text = 1 + dr(0) Else ncode.Text = 1
        mobile.Focus()
    End Sub

    Private Sub mobile_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles mobile.GotFocus
        flng("AR")

    End Sub

    Private Sub mobile_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mobile.KeyDown
        If e.KeyCode = Keys.Enter Then
            address_name.Focus()
        End If
    End Sub

    Private Sub mobile_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mobile.TextChanged

    End Sub

    Private Sub nname_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles nname.GotFocus
        flng("AR")

    End Sub

    Private Sub nname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles nname.KeyDown
        If e.KeyCode = Keys.Enter Then
            GlassButton36_Click(GlassButton36, e)

        End If
        If e.KeyCode = Keys.Delete Then
            nname.Text = ""
        End If
    End Sub

    Private Sub nname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nname.TextChanged

    End Sub

    Private Sub SAVECUSTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SAVECUSTToolStripMenuItem.Click
        GlassButton35_Click(GlassButton35, e)
    End Sub

    Private Sub GlassButton34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton34.Click
        If nname.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «”„ «·„—Ì÷") : Exit Sub
        dr.Close()
        cmd.CommandText = "select * from ncust where CODE='" & ncode.Text & "' "
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            N = MsgBox(" Â·  —Ìœ Õ–› »Ì«‰«  «·⁄„Ì·  " & nname.Text, MsgBoxStyle.YesNo + MsgBoxStyle.Question)
            If N = vbNo Then Exit Sub
            dr.Close()
            cmd.CommandText = "delete from ncust where CODE='" & ncode.Text & "' "
            cmd.ExecuteNonQuery()
            cmd.CommandText = "delete from npaid where CODE='" & ncode.Text & "' "
            cmd.ExecuteNonQuery()

        End If
    End Sub

    Private Sub DELETECUSTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DELETECUSTToolStripMenuItem.Click
        GlassButton34_Click(GlassButton34, e)
    End Sub

    Private Sub CODEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CODEToolStripMenuItem.Click
        Dim S As Integer = InputBox("«œŒ· ﬂÊœ «·⁄„Ì·", , "0")
        ncode.Text = S
        FINDCUST()
    End Sub
    Public Sub FINDCUST()

        If Val(ncode.Text) = 0 Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·ﬂÊœ") : Exit Sub

        dr.Close()
        cmd.CommandText = "select * from ncust where CODE='" & ncode.Text & "' "
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            nname.Text = dr("name")
            ncode.Text = dr("code")
            mobile.Text = dr("mobile")
            address_name.Text = dr("address_name")
            piont_name.Text = dr("piont_name")
            piont_code.Text = dr("piont_code")
            part_name.Text = dr("part_name")
            part_code.Text = dr("part_code")
            start_date.Value = dr("start_date")
            speed_name.Focus()
            speed_name.Text = dr("speed_name")
            speed_code.Text = dr("speed_code")
            stat_name.Text = dr("stat_name")
            stat_code.Text = dr("stat_code")
            eng_name.Text = dr("eng_name")
            eng_code.Text = dr("eng_code")
            user_name.Text = dr("user_name")
            notse.Text = dr("notse")
            address_code.Text = dr("address_code")
            email.Text = dr("email")
            on1.Text = dr("on1")

        Else
            MsgBox("Â–« «·ﬂÊœ €Ì— „”Ã·", MsgBoxStyle.Information)
        End If
    End Sub
    Public Sub FINdevent()
        If Val(sn.Text) = 0 Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·ﬂÊœ") : Exit Sub
        dr.Close()
        cmd.CommandText = "select * from nevent where sn='" & sn.Text & "' "
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            nname.Text = dr("name")
            prolm_name.Text = dr("prolm_name")
            prolm_code.Text = dr("prolm_code")
            pos_name.Text = dr("pos_name")
            pos_code.Text = dr("pos_code")
            sdate.Value = dr("ndate")
            nname.Text = dr("name")
            ncode.Text = dr("code")
            notse1.Text = dr("notse")
            sn.Text = dr("sn")
            FINDCUST()
        Else
            MsgBox("Â–« «·ﬂÊœ €Ì— „”Ã·", MsgBoxStyle.Information)
        End If
    End Sub
    Private Sub NAMEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NAMEToolStripMenuItem.Click
        Dim S As String = InputBox("«œŒ· «”„  «·⁄„Ì·")
        ecust("name LIKE '%" & S & "%'")
    End Sub
    Public Sub ecust(ByVal s As String)
        cmdTCUST.Connection = CN
        cmdTCUST.CommandType = CommandType.Text
        cmdTCUST.CommandText = "select * from NCUST WHERE  " & s
        adTCUST.SelectCommand = cmdTCUST
        adTCUST.Fill(DBS, "TCUST")
        TCUST = DBS.Tables("TCUST")
        DBS.Tables("TCUST").Clear()
        adTCUST.Fill(DBS, "TCUST")
        TCUST = DBS.Tables("TCUST")
        DataGridView1.DataSource = TCUST
        gt = 1
        If TCUST.Rows.Count = 1 Then
            ncode.Text = TCUST.Rows(0).Item("code")
            FINDCUST()
        End If
    End Sub
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        If gt = 1 Then
            ncode.Text = DataGridView1(("CODE"), e.RowIndex).Value
            FINDCUST()
        ElseIf gt = 2 Then
            sn.Text = DataGridView1(("sn"), e.RowIndex).Value
            FINdevent()
        ElseIf gt = 3 Then
            main_name.Text = DataGridView1(("main_name"), e.RowIndex).Value
            main_code.Text = DataGridView1(("main_code"), e.RowIndex).Value
            sub_code.Text = DataGridView1(("sub_code"), e.RowIndex).Value
            sub_name.Text = DataGridView1(("sub_name"), e.RowIndex).Value
            cash.Text = DataGridView1(("cash"), e.RowIndex).Value
            crd.Text = DataGridView1(("crd"), e.RowIndex).Value
            time1.Text = DataGridView1(("time1"), e.RowIndex).Value
            date1.Text = DataGridView1(("date1"), e.RowIndex).Value
            id.Text = DataGridView1(("id"), e.RowIndex).Value
            notse2.Text = DataGridView1(("notse"), e.RowIndex).Value
        End If
    End Sub

    Private Sub USERNAMEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles USERNAMEToolStripMenuItem.Click
        Dim S As String = InputBox("«œŒ· «”„  «·„” Œœ„")
        ecust("user_name LIKE '%" & S & "%'")
    End Sub

    Private Sub MOBILToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MOBILToolStripMenuItem.Click
        Dim S As String = InputBox("«œŒ· „Ê»Ì·  «·⁄„Ì·")
        ecust("mobile LIKE '%" & S & "%'")
    End Sub

    Private Sub REPORTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REPORTToolStripMenuItem.Click
        N = " KY>0"
        If cname.Checked = True Then N = N & " and NAME LIKE '%" & nname.Text & "%'"
        If cmobile.Checked = True Then N = N & " and MOBILE LIKE '%" & mobile.Text & "%'"
        If caddress.Checked = True Then N = N & " and ADDRESS_NAME LIKE '%" & address_name.Text & "%'"
        If cpiont.Checked = True Then N = N & " and PIONT_NAME='" & piont_name.Text & "'"
        If cpart.Checked = True Then N = N & " and PART_NAME ='" & part_name.Text & "'"
        If cstart_date.Checked = True Then N = N & " and start_date ='" & ChangeFormat(start_date.Value) & "'"
        If cspeed.Checked = True Then N = N & " and SPEED_NAME  ='" & speed_name.Text & "'"
        If cstat.Checked = True Then N = N & " and STAT_NAME  ='" & stat_name.Text & "'"
        If cuser_name.Checked = True Then N = N & " and USER_NAME  ='" & user_name.Text & "'"
        If cnotse.Checked = True Then N = N & " and NOTSE LIKE '%" & notse.Text & "%'"
        If cemail.Checked = True Then N = N & " and email LIKE '%" & email.Text & "%'"
        If con1.Checked = True Then N = N & " and on1  ='" & on1.Text & "'"
        If crest.Checked = True Then N = N & " and rest  ='" & rest.Text & "'"

        ecust(N)
        Dim oj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        oj.Load(Application.StartupPath & "\NCUST.rpt")
        oj.Database.Tables(0).SetDataSource(TCUST)
        rp.CrystalReportViewer1.ReportSource = oj
        rp.Show() : rp.Focus()
    End Sub

    Private Sub GlassButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton1.Click
        N = " KY>0"
        If cname.Checked = True Then N = N & " and NAME LIKE '%" & nname.Text & "%'"

        If cmobile.Checked = True Then N = N & " and MOBILE LIKE '%" & mobile.Text & "%'"
        If caddress.Checked = True Then N = N & " and ADDRESS_NAME LIKE '%" & address_name.Text & "%'"
        If ceng.Checked = True Then N = N & " and eng_NAME='" & eng_name.Text & "'"
        If cpiont.Checked = True Then N = N & " and PIONT_NAME='" & piont_name.Text & "'"
        If cpart.Checked = True Then N = N & " and PART_NAME ='" & part_name.Text & "'"
        If cstart_date.Checked = True Then N = N & " and start_date ='" & ChangeFormat(start_date.Value) & "'"
        If cspeed.Checked = True Then N = N & " and SPEED_NAME  ='" & speed_name.Text & "'"
        If cstat.Checked = True Then N = N & " and STAT_NAME  ='" & stat_name.Text & "'"
        If cuser_name.Checked = True Then N = N & " and USER_NAME  ='" & user_name.Text & "'"
        If cnotse.Checked = True Then N = N & " and NOTSE LIKE '%" & notse.Text & "%'"
        If cmon.Checked = True Then N = N & " and mon ='" & mon.Text & "'"
        If cprice.Checked = True Then N = N & " and price ='" & price.Text & "'"
        If ccome.Checked = True Then If come.Text = "œ›⁄" Then N = N & " and come =1" Else N = N & " and come =0"
        If cemail.Checked = True Then N = N & " and email LIKE '%" & email.Text & "%'"
        If con1.Checked = True Then N = N & " and on1  ='" & on1.Text & "'"
        If crest.Checked = True Then N = N & " and rest  >0"
        If cyearn.Checked = True Then N = N & " and yearn='" & yearn.Text & "'"
        cmdsCUST.Connection = CN
        cmdsCUST.CommandType = CommandType.Text
        cmdsCUST.CommandText = "select * from v_cust WHERE  " & N
        adsCUST.SelectCommand = cmdsCUST
        adsCUST.Fill(DBS, "scust")
        sCUST = DBS.Tables("scust")
        DBS.Tables("scust").Clear()
        adsCUST.Fill(DBS, "scust")
        sCUST = DBS.Tables("scust")
        Dim oj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        oj.Load(Application.StartupPath & "\ashtrark.rpt")
        oj.Database.Tables(0).SetDataSource(sCUST)
        rp.CrystalReportViewer1.ReportSource = oj
        rp.Show() : rp.Focus()
    End Sub

    Private Sub GlassButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton2.Click
        If nname.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «”„ «·„—Ì÷") : Exit Sub
        dr.Close()
        cmd.CommandText = "select * from npaid where CODE='" & ncode.Text & "' and mon='" & Now.Month & "' and come=0"
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            N = MsgBox(" Â·  —Ìœ  ”ÃÌ·  «‘ —«ﬂ «·⁄„Ì·  " & nname.Text, MsgBoxStyle.YesNo + MsgBoxStyle.Question)
            If N = vbNo Then Exit Sub
            dr.Close()
            dr1.Close()
            cmd.CommandText = "update npaid set come=1 ,sdate='" & ChangeFormat(Now) & "',ndate='" & ChangeFormatall(Now) & "',user_name='" & USR & "',price='" & price.Text & "' where code='" & ncode.Text & "' and mon='" & mon.Text & "' and yearn='" & yearn.Text & "'"
            cmd.ExecuteNonQuery()
            cmd1.CommandText = "UPDATE NCUST SET STAT_NAME='Connect',Stat_code='1' where code='" & ncode.Text & "'"
            cmd1.ExecuteNonQuery()
            MsgBox("   „   ”ÃÌ· «‘ —«ﬂ «·⁄„Ì·  " & nname.Text, MsgBoxStyle.Information)
        Else
            MsgBox(" „ œ›⁄ «·«‘ —«ﬂ „‰ ﬁ»· ")

        End If

    End Sub

    Private Sub GlassButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton3.Click
        If nname.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «”„ «·„—Ì÷") : Exit Sub
        dr.Close()
        cmd.CommandText = "select * from npaid where CODE='" & ncode.Text & "' and mon='" & mon.Text & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            N = MsgBox(" Â·  —Ìœ Õ–›  «‘ —«ﬂ «·⁄„Ì·  " & nname.Text, MsgBoxStyle.YesNo + MsgBoxStyle.Question)
            If N = vbNo Then Exit Sub
            dr.Close()
            cmd.CommandText = "update npaid set come=0 ,sdate='',ndate='',user_name='" & USR & "',price='0' where code='" & ncode.Text & "' and mon='" & mon.Text & "'"
            cmd.ExecuteNonQuery()
            MsgBox("   „   ”ÃÌ· «‘ —«ﬂ «·⁄„Ì·  " & nname.Text, MsgBoxStyle.Information)

        End If
    End Sub

    Private Sub eng_name_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles eng_name.KeyDown
        If e.KeyCode = Keys.ControlKey Then
            FSAVE(eng_name.Text, "neng", 1, "", "")
        ElseIf e.KeyCode = Keys.Delete Then
            FSAVE(eng_name.Text, "neng", 2, "", "")
        End If
    End Sub

    Private Sub eng_name_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles eng_name.SelectedIndexChanged
        If eng_name.Focused = False Then Exit Sub
        If eng_name.Text = "" Then Exit Sub
        FRC = eng.Select("NAME='" & eng_name.Text & "'")
        If FRC.Length <= 0 Then
            eng_name.Text = ""
            eng_code.Text = ""
            Exit Sub
        Else
            RC = FRC(0)
            eng_code.Text = RC("code")
        End If
    End Sub

    Private Sub prolm_name_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles prolm_name.KeyDown
        If e.KeyCode = Keys.ControlKey Then
            FSAVE(prolm_name.Text, "nprolm", 1, "", "")
        ElseIf e.KeyCode = Keys.Delete Then
            FSAVE(prolm_name.Text, "nprolm", 2, "", "")
        End If
    End Sub

    Private Sub prolm_name_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles prolm_name.SelectedIndexChanged
        If prolm_name.Focused = False Then Exit Sub
        If prolm_name.Text = "" Then Exit Sub
        FRC = prolm.Select("NAME='" & prolm_name.Text & "'")
        If FRC.Length <= 0 Then
            prolm_name.Text = ""
            prolm_code.Text = ""
            Exit Sub
        Else
            RC = FRC(0)
            prolm_code.Text = RC("code")
        End If
    End Sub

    Private Sub pos_name_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles pos_name.KeyDown
        If e.KeyCode = Keys.ControlKey Then
            FSAVE(pos_name.Text, "npos", 1, "", "")
        ElseIf e.KeyCode = Keys.Delete Then
            FSAVE(pos_name.Text, "npos", 2, "", "")
        End If
    End Sub

    Private Sub pos_name_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pos_name.SelectedIndexChanged
        If pos_name.Focused = False Then Exit Sub
        If pos_name.Text = "" Then Exit Sub
        FRC = pos.Select("NAME='" & pos_name.Text & "'")
        If FRC.Length <= 0 Then
            pos_name.Text = ""
            pos_code.Text = ""
            Exit Sub
        Else
            RC = FRC(0)
            pos_code.Text = RC("code")
        End If
    End Sub

    Private Sub GlassButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton5.Click
        If nname.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «”„ «·„—Ì÷") : Exit Sub
        If Val(sn.Text) = 0 Then
            dr.Close()
            cmd.CommandText = "select max(sn) from  nevent"
            dr = cmd.ExecuteReader
            dr.Read()
            If IsDBNull(dr(0)) = False Then sn.Text = 1 + dr(0) Else sn.Text = 1
        End If
        dr.Close()
        cmd.CommandText = "select * from nevent where sn='" & sn.Text & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            N = MsgBox(" Â·  —Ìœ  ”ÃÌ·  «⁄ÿ«· «·⁄„Ì·  " & nname.Text, MsgBoxStyle.YesNo + MsgBoxStyle.Question)
            If N = vbNo Then Exit Sub
            dr.Close()
            cmd.CommandText = "delete from nevent where sn='" & sn.Text & "'"
            cmd.ExecuteNonQuery()
        End If
        dr.Close()
        cmd.CommandText = "INSERT INTO [ASILLAB].[dbo].[nevent]([prolm_name],[prolm_code],[pos_name],[pos_code],[sdate],[ndate],[name],[code],[notse],[usr],sn) VALUES ('" & prolm_name.Text & " ','" & prolm_code.Text & "','" & pos_name.Text & "','" & pos_code.Text & "','" & ChangeFormat(sdate.Value) & "','" & ChangeFormatall(sdate.Value) & "','" & nname.Text & "','" & ncode.Text & "','" & notse1.Text & "','" & USR & "','" & sn.Text & "') "
        cmd.ExecuteNonQuery()
        MsgBox("   „   ”ÃÌ· «⁄ÿ«· «·⁄„Ì·  " & nname.Text, MsgBoxStyle.Information)

    End Sub

    Private Sub GlassButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton4.Click
        N = "ky>0"
        If cname.Checked = True Then N = N & " and NAME LIKE '%" & nname.Text & "%'"
        If cmobile.Checked = True Then N = N & " and MOBILE LIKE '%" & mobile.Text & "%'"
        If caddress.Checked = True Then N = N & " and ADDRESS_NAME LIKE '%" & address_name.Text & "%'"
        If ceng.Checked = True Then N = N & " and eng_NAME='" & eng_name.Text & "'"
        If cpiont.Checked = True Then N = N & " and PIONT_NAME='" & piont_name.Text & "'"
        If cpart.Checked = True Then N = N & " and PART_NAME ='" & part_name.Text & "'"
        If cstart_date.Checked = True Then N = N & " and start_date ='" & ChangeFormat(start_date.Value) & "'"
        If cspeed.Checked = True Then N = N & " and SPEED_NAME  ='" & speed_name.Text & "'"
        If cstat.Checked = True Then N = N & " and STAT_NAME  ='" & stat_name.Text & "'"
        If cuser_name.Checked = True Then N = N & " and USER_NAME  ='" & user_name.Text & "'"
        If cnotse1.Checked = True Then N = N & " and NOTSE LIKE '%" & notse1.Text & "%'"
        If csn.Checked = True Then N = N & " and sn ='" & sn.Text & "'"
        If cprolm.Checked = True Then N = N & " and prolm_name ='" & prolm_name.Text & "'"
        If cpos.Checked = True Then N = N & " and pos_name ='" & pos_name.Text & "'"
        If csdate.Checked = True Then N = N & " and sdate ='" & ChangeFormat(sdate.Value) & "'"
        If cemail.Checked = True Then N = N & " and email LIKE '%" & email.Text & "%'"

        gt = 2
        cmdevent1.Connection = CN
        cmdevent1.CommandType = CommandType.Text
        cmdevent1.CommandText = "select * from v_event WHERE  " & N
        adevent1.SelectCommand = cmdevent1
        adevent1.Fill(DBS, "event1")
        event1 = DBS.Tables("event1")
        DBS.Tables("event1").Clear()
        adevent1.Fill(DBS, "event1")
        event1 = DBS.Tables("event1")
        DataGridView1.DataSource = event1
        Dim oj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        oj.Load(Application.StartupPath & "\nevent.rpt")
        oj.Database.Tables(0).SetDataSource(event1)
        rp.CrystalReportViewer1.ReportSource = oj
        rp.Show() : rp.Focus()

    End Sub

    Private Sub GlassButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton7.Click
        dr.Close()
        cmd.CommandText = "select max(sn) from  nevent"
        dr = cmd.ExecuteReader
        dr.Read()
        If IsDBNull(dr(0)) = False Then sn.Text = 1 + dr(0) Else sn.Text = 1
        notse1.Text = ""
    End Sub
    Public Sub FCASH1()
mmm:
        dr.Close()
        cmd.CommandText = "select * from lCASH where ID='" & id.Text & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Or id.Text = 0 Then
            dr.Close()
            cmd.CommandText = "select * from Branch where code='" & branch_code.Text & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then
                id.Text = dr("CASH")
                dr.Close()
                cmd.CommandText = "update Branch set CASH='" & Val(id.Text) + 1 & "' where code='" & branch_code.Text & "'"
                cmd.ExecuteNonQuery()
                ACdr.Close()
                ACcmd.CommandText = "update srv set CASH='" & Val(id.Text) & "' "
                ACcmd.ExecuteNonQuery()
                GoTo mmm
            End If
        End If
    End Sub
    Private Sub GlassButton33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton33.Click
        gt = 3
        ACdr.Close()
        ACcmd.CommandText = "select * from srv "
        ACdr = ACcmd.ExecuteReader
        ACdr.Read()
        If ACdr("CASH") > 0 Then
            id.Text = ACdr("CASH")
            FCASH1()
        End If

        dr.Close()
        Dim D As Date = Now
        time1.Text = D.TimeOfDay.ToString
        date1.Text = D.Date.ToShortDateString
        cash1.Clear()
        cmdcash1.Connection = CN
        cmdcash1.CommandType = CommandType.Text
        cmdcash1.CommandText = "select * FROM lCASH WHERE DATE1='" & ChangeFormat(Now.Date) & "'"
        adcash1.SelectCommand = cmdcash1
        adcash1.Fill(DBS, "cash1")
        cash1 = DBS.Tables("cash1")
        DBS.Tables("cash1").Clear()
        adcash1.Fill(DBS, "cash1")
        cash1 = DBS.Tables("cash1")

        DataGridView1.DataSource = ""
        DataGridView1.DataSource = cash1
        DataGridView1.Columns("flg").Visible = False
        DataGridView1.Columns("TIME1").Visible = False
        DataGridView1.Columns("sub_code").Visible = False
        DataGridView1.Columns("sub_name").HeaderText = "‰Ê⁄ «·⁄„·Ì…"
        DataGridView1.Columns("sub_name").Width = 70
        DataGridView1.Columns("main_code").Visible = False
        DataGridView1.Columns("main_name").HeaderText = "ﬂ Ì» «·«”⁄«—"
        DataGridView1.Columns("main_name").Width = 70
        '===================================================

        cash.Text = 0
        crd.Text = 0
        dr.Close()
        sub_name.Focus()

    End Sub

    Private Sub GlassButton32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton32.Click
        If Trim(sub_name.Text) = "" Or Trim(sub_code.Text) = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ ‰Ê⁄  «·⁄„·Ì…") : Exit Sub
        If Trim(main_name.Text) = "" Or Trim(main_code.Text) = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·⁄Ì«œ…") : Exit Sub
        If IsNumeric(cash.Text) = False Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·”⁄—") : Exit Sub
        dr.Close() : cmd.CommandText = "select * from lcash  where ID=" & id.Text
        dr = cmd.ExecuteReader
        If dr.HasRows = True Then
            Dim x As String
            x = MsgBox("Â·  —Ìœ  ⁄œÌ·  ", MsgBoxStyle.YesNo)
            If x = vbNo Then dr.Close() : Exit Sub
            dr.Close() : dr.Close() : cmd.CommandText = "delete  from lcash where ID=" & id.Text
            cmd.ExecuteNonQuery()
        Else

        End If
        Dim n As Integer = 0
        If flg.Checked = True Then n = 1 Else n = -1
        dr.Close() : cmd.CommandText = "insert into lcash ([main_name],[main_code],[sub_code],[sub_name],[flg],[cash],[crd],[time1],[date1],[id],[notse],usr,shift) values ('" & main_name.Text & " ','" & main_code.Text & "','" & sub_code.Text & "','" & sub_name.Text & "','" & n & "','" & cash.Text & "','" & crd.Text & "','" & time1.Text & "','" & ChangeFormat(date1.Text) & "','" & id.Text & "','" & notse2.Text & "','" & USR & "','" & SHF & "' )"
        cmd.ExecuteNonQuery()

        GlassButton33_Click(GlassButton33, e)
    End Sub

    Private Sub GlassButton31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton31.Click
        If IsNumeric(id.Text) = False Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·ﬂÊœ") : Exit Sub
        dr.Close() : cmd.CommandText = "select * from lcash  where ID=" & id.Text
        dr = cmd.ExecuteReader
        If dr.HasRows = True Then
            Dim x As String
            x = MsgBox("Â·  —Ìœ «·Õ–›  ", MsgBoxStyle.YesNo)
            If x = vbNo Then dr.Close() : Exit Sub
            dr.Close() : dr.Close() : cmd.CommandText = "delete  from lcash where ID=" & id.Text
            cmd.ExecuteNonQuery()
        End If
    End Sub

    Private Sub GlassButton39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton39.Click
        Dim YY As String = ""
        YY = "where date1 between '" & ChangeFormat(d1.Value) & "' and '" & ChangeFormat(d2.Value) & "'"
        If CMNAME.Checked = True Then YY = YY & " AND  MAIN_NAME='" & main_name.Text & "'"
        If CSNAME.Checked = True Then YY = YY & " AND  SUB_NAME='" & sub_name.Text & "'"
        If CCASH.Checked = True Then YY = YY & " AND  CASH" & FCASH.Text & "'" & cash.Text & "'"
        If CCRD.Checked = True Then YY = YY & " AND  CRD" & FCRD.Text & "'" & crd.Text & "'"
        If CSNAME.Checked = True Then YY = YY & " AND  SUB_NAME='" & sub_name.Text & "'"
        If cnotse2.Checked = True Then YY = YY & " AND NOTSE LIKE '%" & notse2.Text & "%'"
        gt = 3
        cmdcash1.Connection = CN
        cmdcash1.CommandType = CommandType.Text
        cmdcash1.CommandText = "select * FROM lCASH " & YY
        adcash1.SelectCommand = cmdcash1
        adcash1.Fill(DBS, "cash1")
        cash1 = DBS.Tables("cash1")
        DBS.Tables("cash1").Clear()
        adcash1.Fill(DBS, "cash1")
        cash1 = DBS.Tables("cash1")
        DataGridView1.DataSource = ""
        DataGridView1.DataSource = cash1
        DataGridView1.Columns("flg").Visible = False
        DataGridView1.Columns("TIME1").Visible = False
        DataGridView1.Columns("sub_code").Visible = False
        DataGridView1.Columns("sub_name").HeaderText = "‰Ê⁄ «·⁄„·Ì…"
        DataGridView1.Columns("sub_name").Width = 70
        DataGridView1.Columns("main_code").Visible = False
        DataGridView1.Columns("main_name").HeaderText = "ﬂ Ì» «·«”⁄«—"
        DataGridView1.Columns("main_name").Width = 70
        Dim oj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        oj.Load(Application.StartupPath & "\cash.rpt")
        oj.Database.Tables(0).SetDataSource(cash1)
        oj.SetParameterValue("1", d1.Value)
        oj.SetParameterValue("2", d2.Value)
        rp.CrystalReportViewer1.ReportSource = oj
        rp.Show()
        rp.Focus()
        ''dr.Close()
        ''Dim nn As Integer = 0
        ''While Not nn = TCUST.Rows.Count
        ''    RC = TCUST.Rows(nn)
        ''    Dim s As Integer = 1
        ''    While Not s = 13
        ''        cmd.CommandText = "INSERT INTO [ASILLAB].[dbo].[npaid]([name],[code],mon,yearn) values ('" & RC("name") & "','" & RC("name") & "','" & s & "',2015)"
        ''        cmd.ExecuteNonQuery()
        ''        s += 1
        ''    End While
        ''    nn = nn + 1
        ''End While

    End Sub

    Private Sub GlassButton38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton38.Click
        Dim YY As String = ""
        YY = "where date1 between '" & ChangeFormat(d1.Value) & "' and '" & ChangeFormat(d2.Value) & "'"
        If CMNAME.Checked = True Then YY = YY & " AND  MAIN_NAME='" & main_name.Text & "'"
        If CSNAME.Checked = True Then YY = YY & " AND  SUB_NAME='" & sub_name.Text & "'"
        If CCASH.Checked = True Then YY = YY & " AND  CASH" & FCASH.Text & "'" & cash.Text & "'"
        If CCRD.Checked = True Then YY = YY & " AND  CRD" & FCRD.Text & "'" & crd.Text & "'"
        If CSNAME.Checked = True Then YY = YY & " AND  SUB_NAME='" & sub_name.Text & "'"
        If cnotse2.Checked = True Then YY = YY & " AND NOTSE LIKE '%" & notse2.Text & "%'"

        cmdcash1.Connection = CN
        cmdcash1.CommandType = CommandType.Text
        cmdcash1.CommandText = "select main_name,sub_name,sum(CASH)as CASH,sum(crd)as crd,flg FROM lCASH " & YY & " GROUP BY main_name,sub_name,flg"
        adcash1.SelectCommand = cmdcash1
        adcash1.Fill(DBS, "cash1")
        cash1 = DBS.Tables("cash1")
        DBS.Tables("cash1").Clear()
        adcash1.Fill(DBS, "cash1")
        cash1 = DBS.Tables("cash1")
        DataGridView1.DataSource = ""
        DataGridView1.DataSource = cash1
        Dim oj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        oj.Load(Application.StartupPath & "\cashA.rpt")
        oj.Database.Tables(0).SetDataSource(cash1)
        oj.SetParameterValue("1", d1.Value)
        oj.SetParameterValue("2", d2.Value)
        rp.CrystalReportViewer1.ReportSource = oj
        rp.Show()
        rp.Focus()
    End Sub

    Private Sub GlassButton37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton37.Click
        Dim YY As String = ""
        YY = "where date1 between '" & ChangeFormat(d1.Value) & "' and '" & ChangeFormat(d2.Value) & "'"
        If CMNAME.Checked = True Then YY = YY & " AND  MAIN_NAME='" & main_name.Text & "'"
        If CSNAME.Checked = True Then YY = YY & " AND  SUB_NAME='" & sub_name.Text & "'"
        If CCASH.Checked = True Then YY = YY & " AND  CASH" & FCASH.Text & "'" & cash.Text & "'"
        If CCRD.Checked = True Then YY = YY & " AND  CRD" & FCRD.Text & "'" & crd.Text & "'"
        If CSNAME.Checked = True Then YY = YY & " AND  SUB_NAME='" & sub_name.Text & "'"
        If cnotse2.Checked = True Then YY = YY & " AND NOTSE LIKE '%" & notse2.Text & "%'"

        cmdcash1.Connection = CN
        cmdcash1.CommandType = CommandType.Text
        cmdcash1.CommandText = "select main_name,sub_name,SHIFT,sum(CASH)as CASH,sum(crd)as crd,flg FROM lCASH " & YY & " GROUP BY main_name,sub_name,flg,SHIFT"
        adcash1.SelectCommand = cmdcash1
        adcash1.Fill(DBS, "cash1")
        cash1 = DBS.Tables("cash1")
        DBS.Tables("cash1").Clear()
        adcash1.Fill(DBS, "cash1")
        cash1 = DBS.Tables("cash1")
        DataGridView1.DataSource = ""
        DataGridView1.DataSource = cash1
        Dim oj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        oj.Load(Application.StartupPath & "\cashG.rpt")
        oj.Database.Tables(0).SetDataSource(cash1)
        oj.SetParameterValue("1", d1.Value)
        oj.SetParameterValue("2", d2.Value)
        rp.CrystalReportViewer1.ReportSource = oj
        rp.Show()
        rp.Focus()
    End Sub

    Private Sub GlassButton43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton43.Click
        Dim s2 As Integer = 0

        Dim n As Int16
        dr.Close()
        Dim D As Date = Now
        time1.Text = D.TimeOfDay.ToString
        date1.Text = D.Date.ToShortDateString
        'cash.Text = -1 * Val(REST.Text)
        crd.Text = 0
        dr.Close()
        cmd.CommandText = "select * from lsub where sub_code='1'"
        dr = cmd.ExecuteReader
        dr.Read()
        If dr("flg") = 1 Then flg.Checked = True Else flg.Checked = False
        main_code.Text = dr("main_code")
        main_name.Text = dr("main_name")
        dr.Close()
        cmd.CommandText = "select * from lsub where sub_code='1'"
        dr = cmd.ExecuteReader
        dr.Read()
        sub_name.Text = dr("sub_name")

        ACdr.Close()
        ACcmd.CommandText = "select * from srv "
        ACdr = ACcmd.ExecuteReader
        ACdr.Read()
        If ACdr("CASH") > 0 Then
            id.Text = ACdr("CASH")

        End If

        If flg.Checked = True Then n = 1 Else n = -1
        dr1.Close()
        cmd1.CommandText = "select * from npaid where sdate='" & ChangeFormat(Now) & "'"
        dr1 = cmd1.ExecuteReader
        dr.Close()
        While dr1.Read
            FCASH1()
            dr.Close()
            cmd.CommandText = "SELECT * FROM LCASH WHERE NOTSE=' œ›⁄ «‘ —«ﬂ ··⁄„Ì·  " & dr1("name") & "   ⁄‰ ‘Â—   " & dr1("mon") & "'"
            dr = cmd.ExecuteReader
            If dr.HasRows = False Then
                If dr1("price") <> 0 Then
                    dr.Close()
                    cmd.CommandText = "insert into lcash ([main_name],[main_code],[sub_code],[sub_name],[flg],[cash],[crd],[time1],[date1],[id],[notse],usr,shift) values ('" & main_name.Text & " ','" & main_code.Text & "','" & sub_code.Text & "','" & sub_name.Text & "','" & n & "','" & dr1("price") & "','0','" & time1.Text & "','" & ChangeFormat(sdate.Text) & "','" & id.Text & "',' œ›⁄ «‘ —«ﬂ ··⁄„Ì·  " & dr1("name") & "   ⁄‰ ‘Â—   " & dr1("mon") & "','" & USR & "','" & SHF & "' )"
                    cmd.ExecuteNonQuery()
                End If
            End If
        End While
        dr.Close()

        dr.Close()
        cmd.CommandText = "select * from lsub where sub_code='2'"
        dr = cmd.ExecuteReader
        While dr.Read
            If dr("flg") = 1 Then flg.Checked = True Else flg.Checked = False
            main_code.Text = dr("main_code")

            sub_name.Text = dr("sub_name")
        End While
        dr1.Close()
        cmd1.CommandText = "select cust_name,ptot,flg,sn from vstoc where sdate='" & ChangeFormat(Now) & "' and flg=-1 group by  cust_name,ptot,flg,sn "
        dr1 = cmd1.ExecuteReader
        dr.Close()
        While dr1.Read
            FCASH1()
            dr.Close()
            cmd.CommandText = "insert into lcash ([main_name],[main_code],[sub_code],[sub_name],[flg],[cash],[crd],[time1],[date1],[id],[notse],usr,shift) values ('" & main_name.Text & " ','" & main_code.Text & "','" & sub_code.Text & "','" & sub_name.Text & "','" & n & "','" & dr1("ptot") & "','0','" & time1.Text & "','" & ChangeFormat(sdate.Text) & "','" & id.Text & "',' »Ì⁄ „” ·“„«  ··⁄„Ì·  " & dr1("cust_name") & "   —ﬁ„ «·›« Ê—…   " & dr1("sn") & "','" & USR & "','" & SHF & "' )"
            cmd.ExecuteNonQuery()
        End While
        dr.Close()
        cmd.CommandText = "select * from lsub where sub_code='3'"
        dr = cmd.ExecuteReader
        While dr.Read
            If dr("flg") = 1 Then flg.Checked = True Else flg.Checked = False
            main_code.Text = dr("main_code")

            sub_name.Text = dr("sub_name")
        End While
        dr1.Close()
        cmd1.CommandText = "select  sup_name,ptot,flg,sn  from vstoc where sdate='" & ChangeFormat(Now) & "' and flg=1 group by  sup_name,ptot,flg,sn "
        dr1 = cmd1.ExecuteReader
        dr.Close()
        While dr1.Read
            FCASH1()
            dr.Close()
            cmd.CommandText = "insert into lcash ([main_name],[main_code],[sub_code],[sub_name],[flg],[cash],[crd],[time1],[date1],[id],[notse],usr,shift) values ('" & main_name.Text & " ','" & main_code.Text & "','" & sub_code.Text & "','" & sub_name.Text & "','" & n & "','" & dr1("ptot") & "','0','" & time1.Text & "','" & ChangeFormat(sdate.Text) & "','" & id.Text & "',' ‘—«¡ „” ·“„«  „‰ «·„Ê—œ  " & dr1("sup_name") & "   —ﬁ„ «·›« Ê—…   " & dr1("sn") & "','" & USR & "','" & SHF & "' )"
            cmd.ExecuteNonQuery()
        End While
        dr.Close()
        If lng = "AR" Then MsgBox(" „  ⁄„·Ì… «·Õ›Ÿ »‰Ã«Õ", MsgBoxStyle.Information) Else MsgBox("IT'S SAVED", MsgBoxStyle.Information)

    End Sub

    Private Sub main_name_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles main_name.KeyDown

        If e.KeyCode = Keys.ControlKey Then
            If main_name.Text = "" Then Exit Sub
            dr.Close()
            cmd.CommandText = "select * from lmain where name='" & main_name.Text & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = False Then
                dr.Close()
                cmd.CommandText = "select max(code) from lmain "
                dr = cmd.ExecuteReader
                dr.Read()
                If IsDBNull(dr(0)) = False Then main_code.Text = 1 + dr(0) Else main_code.Text = 1
                dr.Close() : cmd.CommandText = "insert into lmain (code,name)  values ('" & main_code.Text & "','" & main_name.Text & "')"
                cmd.ExecuteNonQuery()
                dr.Close()
                main_name.Items.Clear()
                cmd.CommandText = "select * from lmain "
                dr = cmd.ExecuteReader
                While dr.Read
                    main_name.Items.Add(dr("name"))
                End While
            End If

        End If

        '===============================
        If e.KeyCode = Keys.Delete Then
            If main_name.Text = "" Then Exit Sub
            dr.Close()
            cmd.CommandText = "select * from lmain where name='" & main_name.Text & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then
                N = MsgBox(" Â·  —Ìœ Õ–› «·»‰œ  ", MsgBoxStyle.YesNo + MsgBoxStyle.Question)
                If N = vbNo Then Exit Sub

                dr.Close()
                cmd.CommandText = "delete from lmain where name='" & main_name.Text & "'"
                cmd.ExecuteNonQuery()
                dr.Close()
                main_name.Items.Clear()
                cmd.CommandText = "select * from lmain "
                dr = cmd.ExecuteReader
                While dr.Read
                    main_name.Items.Add(dr("name"))
                End While
            End If

        End If
    End Sub

    Private Sub main_name_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles main_name.SelectedIndexChanged
        dr.Close()
        cmd.CommandText = "select * from lmain where name='" & main_name.Text & "'"
        dr = cmd.ExecuteReader
        While dr.Read
            main_code.Text = dr("code")
        End While
    End Sub

    Private Sub sub_name_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles sub_name.KeyDown
       
        If e.KeyCode = Keys.ControlKey Then
            If main_name.Text = "" Then Exit Sub
            If sub_name.Text = "" Then Exit Sub
            dr.Close()
            cmd.CommandText = "select * from lsub where main_name='" & main_name.Text & "' and sub_name='" & sub_name.Text & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = False Then
               
               
            Else
                cash.Focus()
                dr.Close()
                cmd.CommandText = "delete from lsub where main_name='" & main_name.Text & "' and sub_name='" & sub_name.Text & "'"
                cmd.ExecuteNonQuery()
            End If
            dr.Close()
            cmd.CommandText = "select max(sub_code) from lsub "
            dr = cmd.ExecuteReader
            dr.Read()
            Dim n As Integer = 0
            If IsDBNull(dr(0)) = False Then sub_code.Text = 1 + dr(0) Else main_code.Text = 1
            If flg.Checked = True Then n = 1 Else n = -1

            dr.Close() : cmd.CommandText = "insert into lsub (main_code,main_name,sub_code,sub_name,flg)  values ('" & main_code.Text & "','" & main_name.Text & "','" & sub_code.Text & "','" & sub_name.Text & "','" & N & "')"
            cmd.ExecuteNonQuery()
            dr.Close()
            sub_name.Items.Clear()
            cmd.CommandText = "select * from lsub "
            dr = cmd.ExecuteReader
            While dr.Read
                sub_name.Items.Add(dr("sub_name"))
            End While
        End If
        '=============================================
        If e.KeyCode = Keys.Delete Then
            If main_name.Text = "" Then Exit Sub
            If sub_name.Text = "" Then Exit Sub
            dr.Close()
            cmd.CommandText = "select * from lsub where main_name='" & main_name.Text & "' and sub_name='" & sub_name.Text & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then
                N = MsgBox(" Â·  —Ìœ Õ–› «·»‰œ  ", MsgBoxStyle.YesNo + MsgBoxStyle.Question)
                If N = vbNo Then Exit Sub
                dr.Close()
                cmd.CommandText = "delete from lsub where main_name='" & main_name.Text & "' and sub_name='" & sub_name.Text & "'"
                cmd.ExecuteNonQuery()
                dr.Close()
                sub_name.Items.Clear()
                cmd.CommandText = "select * from lsub "
                dr = cmd.ExecuteReader
                While dr.Read
                    sub_name.Items.Add(dr("sub_name"))
                End While
            Else
                cash.Focus()
            End If
        End If
    End Sub

    Private Sub sub_name_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sub_name.SelectedIndexChanged
        dr.Close()
        cmd.CommandText = "select * from lsub where sub_name='" & sub_name.Text & "'"
        dr = cmd.ExecuteReader
        While dr.Read
            If dr("flg") = 1 Then flg.Checked = True Else flg.Checked = False
            sub_code.Text = dr("sub_code")
            main_code.Text = dr("main_code")
            main_name.Text = dr("main_name")

        End While
    End Sub

    Private Sub NewCustToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewCustToolStripMenuItem.Click
        n1 = InputBox("")
        If n1 <> 5011545 Then Exit Sub
        dr1.Close()
        cmd1.CommandText = "delete from ncust "
        cmd1.ExecuteNonQuery()
        cmd1.CommandText = "delete from neng "
        cmd1.ExecuteNonQuery()
        cmd1.CommandText = "delete from nevent "
        cmd1.ExecuteNonQuery()
        cmd1.CommandText = "delete from NPAID "
        cmd1.ExecuteNonQuery()
        cmd1.CommandText = "delete from npart "
        cmd1.ExecuteNonQuery()
        cmd1.CommandText = "delete from npiont "
        cmd1.ExecuteNonQuery()
        cmd1.CommandText = "delete from npos "
        cmd1.ExecuteNonQuery()
        cmd1.CommandText = "delete from nprolm "
        cmd1.ExecuteNonQuery()
        cmd1.CommandText = "delete from nspeed "
        cmd1.ExecuteNonQuery()
        cmd1.CommandText = "delete from nstat "
        cmd1.ExecuteNonQuery()
        cmd1.CommandText = "delete from naddress "
        cmd1.ExecuteNonQuery()
        cmd1.CommandText = "delete from lcash "
        cmd1.ExecuteNonQuery()



    End Sub

    Private Sub GlassButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        ACdr.Close()
        ACcmd.CommandText = "select * from shorafa"
        ACdr = ACcmd.ExecuteReader
        dr.Close()
        Dim n As Integer = 111
        While ACdr.Read
            cmd.CommandText = "INSERT INTO [ASILLAB].[dbo].[ncust]([name],[code],[mobile],[address_name],[piont_name],[piont_code],[part_name],[part_code],[start_date],[speed_name],[speed_code],[stat_name],[stat_code],[user_name],address_code)  VALUES ('" & ACdr("nname") & "','" & n & "','" & ACdr("mobile") & "','" & ACdr("address_name") & "','" & ACdr("piont_name") & "','0','«·‘—›«','0','" & ChangeFormat("1/1/2012") & "','" & ACdr("speed_name") & "','0','" & ACdr("stat_name") & "','0','" & ACdr("user_name") & "','0')"
            cmd.ExecuteNonQuery()
            Dim s As Integer = Now.Month
            While Not s = 13
                cmd.CommandText = "INSERT INTO [ASILLAB].[dbo].[npaid]([name],[code],mon) values ('" & ACdr("nname") & "','" & n & "','" & s & "')"
                cmd.ExecuteNonQuery()
                s += 1
            End While
            n += 1
        End While
    End Sub

    Private Sub GlassButton8_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        dr.Close()
        cmd.CommandText = "select stat_name from ncust group by stat_name"
        dr = cmd.ExecuteReader
        Dim n As Integer = 1
        dr1.Close()
        While dr.Read
            dr1.Close()
            cmd1.CommandText = "insert into nstat  (code,name)  values ('" & n & "','" & dr(0) & "')"
            cmd1.ExecuteNonQuery()
            cmd1.CommandText = "update  ncust set stat_code='" & n & "' where  stat_name='" & dr(0) & "'"
            cmd1.ExecuteReader()
            n += 1
        End While

    End Sub

    Private Sub DISCONNECTCUSTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DISCONNECTCUSTToolStripMenuItem.Click
        N = MsgBox("Â·  —Ìœ «Ìﬁ«› ﬂ· «·⁄„·«¡ «· Ï ·„  œ›⁄ ø", MsgBoxStyle.YesNo + MsgBoxStyle.Question)
        If N = vbNo Then Exit Sub
        dr.Close()
        dr1.Close()
        cmd.CommandText = "select * from NPAID where COME=0 AND MON='" & Now.Month & "'"
        dr = cmd.ExecuteReader
        While dr.Read
            cmd1.CommandText = "UPDATE NCUST SET STAT_NAME='Dissconnect',Stat_code='2' where code='" & dr("code") & "'"
            cmd1.ExecuteNonQuery()
        End While
    End Sub

    Private Sub mon_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mon.KeyDown
        If e.KeyCode = Keys.Enter Then
            dr.Close()
            dr1.Close()
            cmd.CommandText = "update npaid set come=1 ,sdate='" & ChangeFormat(Now) & "',ndate='" & ChangeFormatall(Now) & "',user_name='" & USR & "',price='" & price.Text & "',rest='" & Val(rest.Text) & "' where code='" & ncode.Text & "' and mon='" & mon.Text & "' and yearn='" & yearn.Text & "'"
            cmd.ExecuteNonQuery()
            cmd1.CommandText = "UPDATE NCUST SET STAT_NAME='Connect',Stat_code='1' where code='" & ncode.Text & "'"
            cmd1.ExecuteNonQuery()
            rest.Text = 0
        End If
    End Sub

    Private Sub mon_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mon.SelectedIndexChanged

    End Sub
End Class