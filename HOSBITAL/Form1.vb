Public Class Form1

    Private Sub »‰«¡«·‰Ÿ«„ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Form1_ControlAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.ControlEventArgs) Handles Me.ControlAdded

    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Dim ad As String
        ad = MsgBox("Â·  —Ìœ €·ﬁ «·»—‰«„Ã ø", MsgBoxStyle.YesNo)
        If ad = vbNo Then
            e.Cancel = True
        Else
            End
        End If


       
    End Sub

    Private Sub Form1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        If IO.Directory.Exists(Application.StartupPath & "\images") = False Then IO.Directory.CreateDirectory(Application.StartupPath & "\images")
        For Each foundFile As String In My.Computer.FileSystem.GetFiles(Application.StartupPath & "\images\", FileIO.SearchOption.SearchAllSubDirectories, "*.*")
            IO.File.Delete(foundFile)
        Next

        If IO.Directory.Exists("C:\ASIL") = False Then IO.Directory.CreateDirectory("C:\ASIL")
        For Each foundFile As String In My.Computer.FileSystem.GetFiles("C:\ASIL", FileIO.SearchOption.SearchAllSubDirectories, "*.*")
            IO.File.Delete(foundFile)
        Next
        If IO.Directory.Exists(Application.StartupPath & "\esl") = False Then IO.Directory.CreateDirectory(Application.StartupPath & "\esl")
        For Each foundFile As String In My.Computer.FileSystem.GetFiles(Application.StartupPath & "\esl\", FileIO.SearchOption.SearchAllSubDirectories, "*.*")
            IO.File.Delete(foundFile)
        Next
        Dim strDirectory As String = IO.Path.GetTempPath()
        

        For Each foundFile As String In My.Computer.FileSystem.GetFiles(strDirectory, FileIO.SearchOption.SearchAllSubDirectories, "*.rpt")
            IO.File.Delete(foundFile)
        Next
       
        'ACdr.Close()
        'ACcmd.CommandText = "select * from iface where flg=1 "
        'ACdr = ACcmd.ExecuteReader
        'acdr1.Close()
        'While ACdr.Read
        '    accmd1.CommandText = "update iface set hid='" & ACdr("hid") & "' where mn=" & ACdr("mn")
        '    accmd1.ExecuteNonQuery()
        'End While
        'MsgBox(" „  ⁄„·Ì… «· ⁄œÌ·")
        'dr.Close()
        'cmd.CommandText = "select * from ltest  "
        'dr = cmd.ExecuteReader
        'dr1.Close()
        'While dr.Read
        '    cmd1.CommandText = "update ltest set SHORT='" & Trim(dr("SHORT")) & "' where TEST_CODE='" & dr("TEST_CODE") & "'"
        '    cmd1.ExecuteNonQuery()
        'End While
    End Sub

    Private Sub «·Õ—ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles «·Õ—ToolStripMenuItem.Click
        PictureBox1.Visible = False
        LBILL.MdiParent = Me
        LBILL.Show()
    End Sub

    Private Sub ASIL_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ASIL.MouseClick
        Me.Visible = True
        Me.WindowState = FormWindowState.Maximized
        Me.ASIL.Visible = False
    End Sub

    Private Sub ASIL_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ASIL.MouseDoubleClick

    End Sub

    Private Sub Form1_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
        If Me.WindowState = FormWindowState.Minimized Then
            Me.WindowState = FormWindowState.Minimized
            Me.ASIL.Visible = True
        End If
    End Sub

    Private Sub ‘ƒÊ‰«·⁄«„·Ì‰ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ‘ƒÊ‰«·⁄«„·Ì‰ToolStripMenuItem.Click

        If prov1.Length > 5 Then
            CN.Close()
            dr.Close()
            dr1.Close()
            dr2.Close()
            ACdr.Close()
            acdr1.Close()
            CN.ConnectionString = prov1
            CN.Open()
            cmd.Connection = CN
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from users"
            dr = cmd.ExecuteReader
            dr.Read()
            dr.Close()
        End If
        INPU.ShowDialog()
        empa = Val(INPUTX)
        PictureBox1.Visible = False
        LEMP.MdiParent = Me
        LEMP.Show()
    End Sub

    Private Sub «·«Ì—«œÊ«·„’—Ê›ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
       
    End Sub

    Private Sub «·Õ÷Ê—Ê«·‰’—«›ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        PictureBox1.Visible = False
       
    End Sub

    Private Sub «·„Œ«“‰ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles «·„Œ«“‰ToolStripMenuItem.Click
        PictureBox1.Visible = False
        INPU.ShowDialog()
        If Val(INPUTX) <> 205 Then End
        STOC.MdiParent = Me
        STOC.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        dr.Close()
        cmd.CommandText = "update ss set kid_type='stool' where CollectionNote like '%stool%'"
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub ToolStripMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub ‰›–ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '' ''On Error Resume Next
        '' ''dr.Close()
        '' ''ACdr.Close()
        '' ''Dim N As Integer = 11
        '' ''ACcmd.CommandText = "select * from ID1 "
        '' ''ACdr = ACcmd.ExecuteReader
        '' ''Dim XXX As String = "Lab to Lab"
        '' ''While ACdr.Read
        '' ''    Dim D As Date = Now
        '' ''    If ACdr("agT") = "Years" Then
        '' ''        D = "1-1-" & Now.Year - ACdr("age")
        '' ''    End If
        '' ''    dr1.Close()
        '' ''    cmd1.CommandText = "SELECT * FROM LCOMPANY WHERE NAME='" & ACdr("COMPANY_NAME") & "'"
        '' ''    dr1 = cmd1.ExecuteReader
        '' ''    dr1.Read()
        '' ''    If dr1.HasRows = True Then
        '' ''        cmd.CommandText = "INSERT INTO  LPATIEN([pname],[pcode],[ptype],[pbrith_date],[page],[pphone],[pmobile],[pgover],[pcity],[pstreet],[pemail],[pid],[book_code],[book_name],[company_code],[company_name],[Pnik]) VALUES ('" & ACdr("name") & "','" & N & "','" & ACdr("type") & "','" & ChangeFormat(d) & "','0','" & ACdr("Telphon") & "','0','0','0','0','0','0','" & dr1("BOOK_PRICE_CODE") & "','" & dr1("BOOK_PRICE_NAME") & "','" & dr1("CODE") & "','" & ACdr("TitilE") & "  " & dr1("NAME") & "','" & ACdr("nik") & "')"
        '' ''        cmd.ExecuteNonQuery()
        '' ''    End If
        '' ''    N = N + 1
        '' ''End While

        'ACdr.Close()
        'dr.Close()
        'ACcmd.CommandText = "SELECT * FROM iface "
        'ACdr = ACcmd.ExecuteReader
        'While ACdr.Read
        '    cmd.CommandText = "update iface set mn='" & ACdr("mn") & "',hide=0 where name='" & ACdr("name") & "'"
        '    cmd.ExecuteNonQuery()
        'End While


        '' '' ''dr.Close()
        '' '' ''ACdr.Close()
        '' '' ''ACcmd.CommandText = "select * from intibiotic1 "
        '' '' ''ACdr = ACcmd.ExecuteReader
        '' '' ''While ACdr.Read
        '' '' ''    cmd.CommandText = "INSERT INTO   lCULT  (NAME,SHR,CODE) VALUES ('" & ACdr("NAME") & "','" & ACdr("SRH") & "','" & ACdr("ID") & "')"
        '' '' ''    cmd.ExecuteNonQuery()
        '' '' ''End While
        '' '' ''Dim xx As String = ""
        '' '' ''dr.Close()
        '' '' ''dr1.Close()
        '' '' ''cmd1.CommandText = "SELECT * FROM LPATIEN order by pname "
        '' '' ''dr1 = cmd1.ExecuteReader
        '' '' ''While dr1.Read
        '' '' ''    If xx = dr1("pname") Then
        '' '' ''        cmd.CommandText = "delete from LPATIEN where ky='" & dr1("ky") & "'"
        '' '' ''        cmd.ExecuteNonQuery()
        '' '' ''    End If
        '' '' ''    xx = dr1("pname")
        '' '' ''End While
        MsgBox("«\ „«„")
    End Sub

    Private Sub «·⁄Ì«œ…ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles «·⁄Ì«œ…ToolStripMenuItem.Click
        PictureBox1.Visible = False
        clinic.MdiParent = Me
        clinic.Show()
    End Sub

    Private Sub ‰›–ToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        dr.Close()
        cmd.CommandText = "select * from lntest  "
        dr = cmd.ExecuteReader
        dr1.Close()
        While dr.Read
            cmd1.CommandText = "update lntest set unit='" & Trim(dr("unit")) & "' where ky='" & dr("ky") & "'"
            cmd1.ExecuteNonQuery()
        End While
    End Sub

    Private Sub ⁄Ì«œ…«·ﬂ·ÏToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub «·‘»ﬂ…ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles «·‘»ﬂ…ToolStripMenuItem.Click
        PictureBox1.Visible = False
        netcust.MdiParent = Me
        netcust.Show()
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        dr1.Close()
        dr.Close()
        cmd.CommandText = "select * from ltest1"
        dr = cmd.ExecuteReader
        While dr.Read
            cmd1.CommandText = "update ltest set kid_type='" & dr("kid_type") & "',short='" & dr("short") & "'  where test_code='" & dr("test_code") & "'"
            cmd1.ExecuteNonQuery()
        End While
    End Sub

    Private Sub ImageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImageToolStripMenuItem.Click
        'dr.Close()
        'dr1.Close()
        'cmd1.CommandText = ""
        'dr1 = cmd1.ExecuteReader
        'While dr1.Read
        '    cmd.CommandText = "update lbill set brans='" & dr1("bran") & dr1("esl_no") & "'"
        '    cmd.ExecuteNonQuery()

        'End While
        images.Show()
    End Sub

    Private Sub MMToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MMToolStripMenuItem.Click
        dr1.Close()
        dr.Close()
        cmd.CommandText = "SELECT * FROM LTTT "
        dr = cmd.ExecuteReader
        While dr.Read
            cmd1.CommandText = "update LTEST set KID_TYPE='" & dr("KID_TYPE") & "' where TEST_CODE='" & dr("TEST_CODE") & "'"
            cmd1.ExecuteNonQuery()
        End While
        'dr.Close()
        'cmd.CommandText = "UPDATE lbill_test  SET RES='-' where ESL_NO>='1' AND ESL_NO<='156' AND yearn='2015'"
        'cmd.ExecuteNonQuery()
        'dr.Close()
        'cmd.CommandText = "UPDATE lbill_testsub SET RES='-' where ESL_NO>='1' AND ESL_NO<='156' AND yearn='2015'"
        'cmd.ExecuteNonQuery()
    End Sub

  
    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        Dim S As Integer = InputBox("ENTER PASWORD")
        If S <> 205 Then Exit Sub
        On Error Resume Next
        dr.Close()
        ACdr.Close()
        ACcmd.CommandText = "ALTER TABLE TEST_PRICE ADD price11  Number,price12  Number,price13  Number,price14  Number,price15  Number,price16  Number,price17  Number,price18  Number,price19  Number,price20  Number,price21  Number,price22  Number,price23  Number,price24  Number,price25  Number,price26  Number,price27  Number,price28  Number,price29  Number,price30  Number,price31  Number,price32  Number,price33  Number,price34  Number,price35  Number,price36  Number,price37  Number,price38  Number,price39  Number,price40  Number,pricep  Number"
        ACcmd.ExecuteNonQuery()

        

    End Sub

    Private Sub »—‰«„Ã«·⁄Ì«œ…ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles »—‰«„Ã«·⁄Ì«œ…ToolStripMenuItem.Click
        PictureBox1.Visible = False
        newcclinic.MdiParent = Me
        newcclinic.Show()
    End Sub
End Class
