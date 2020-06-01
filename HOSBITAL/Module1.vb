Imports System.Data.OleDb
Imports System.Globalization
Imports System.Threading
Imports System.Math
Imports System
Imports System.IO
Imports System.Data
Imports System.Drawing
Imports System.Collections
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports BarcodeLib
Imports iTextSharp
Module Module1

    Public adgen As New OleDb.OleDbDataAdapter
    Public gen As New DataTable
    Public sbran As String
    Public result As String
    Public bar1 As New BarcodeLib.Barcode()
    Public message As System.Net.Mail.MailMessage
    Public smtp As New System.Net.Mail.SmtpClient("smtp.gmail.com", 587)
    Public attach As System.Net.Mail.Attachment
    Public cmdb As New OleDb.OleDbCommandBuilder
    Public CN, ACcn, SCN, accnlis As New OleDbConnection
    Public SCMD, scmd1, cmd, ACcmdlis, ACcmd, cmd1, accmd1, cmd2 As New OleDbCommand
    Public SDR, sdr1, dr, ACdr, acdrlis, dr1, acdr1, dr2 As OleDbDataReader
    Public emlprg, prg, code, SUB1, cbcf, cbcd, manger, mluser, empa As Integer
    Public DBS As New DataSet
    Public RC, RC1 As DataRow
    Public FRC() As DataRow
    Public RRVV, USR, SHF, emaile, pemaile, lng, pvemail, prov1, rrpt, INPUTX, suser As String
    Public cmdifc As New OleDb.OleDbCommand
    Public adifc As New OleDb.OleDbDataAdapter
    Public ifc As New DataTable
    Public Sub LLOG(ByVal TYPE1 As String, ByVal ESL1 As Integer, ByVal NOTE1 As String, ByVal GR As Integer, ByVal BRAN As String)
        dr.Close()
        cmd.CommandText = "insert into llog (usr,note,date1,time1,gr,ESL,TYPE,bran) values ('" & suser & "','" & NOTE1 & " ','" & ChangeFormat(Now.Date) & "','" & Now.Hour & ":" & Now.Minute & ":" & Now.Second & "','" & GR & "','" & ESL1 & "','" & TYPE1 & "','" & BRAN & "')"
        cmd.ExecuteNonQuery()

    End Sub

    Public Function MergePdfFiles(ByVal pdfFiles() As String, ByVal outputPath As String) As Boolean
        Dim result As Boolean = False
        Dim pdfCount As Integer = 0     'total input pdf file count
        Dim f As Integer = 0    'pointer to current input pdf file
        Dim fileName As String
        Dim reader As iTextSharp.text.pdf.PdfReader = Nothing
        Dim pageCount As Integer = 0
        Dim pdfDoc As iTextSharp.text.Document = Nothing    'the output pdf document
        Dim writer As iTextSharp.text.pdf.PdfWriter = Nothing
        Dim cb As iTextSharp.text.pdf.PdfContentByte = Nothing
        Dim page As iTextSharp.text.pdf.PdfImportedPage = Nothing
        Dim rotation As Integer = 0
        Try
            pdfCount = pdfFiles.Length
            If pdfCount > 1 Then
                'Open the 1st item in the array PDFFiles
                fileName = pdfFiles(f)
                reader = New iTextSharp.text.pdf.PdfReader(fileName)
                'Get page count
                pageCount = reader.NumberOfPages
                pdfDoc = New iTextSharp.text.Document(reader.GetPageSizeWithRotation(1), 18, 18, 18, 18)
                writer = iTextSharp.text.pdf.PdfWriter.GetInstance(pdfDoc, New FileStream(outputPath, FileMode.OpenOrCreate))
                With pdfDoc
                    .Open()
                End With
                'Instantiate a PdfContentByte object
                cb = writer.DirectContent
                'Now loop thru the input pdfs
                While f < pdfCount
                    'Declare a page counter variable
                    Dim i As Integer = 0
                    'Loop thru the current input pdf's pages starting at page 1
                    While i < pageCount
                        i += 1
                        'Get the input page size
                        pdfDoc.SetPageSize(reader.GetPageSizeWithRotation(i))
                        'Create a new page on the output document
                        pdfDoc.NewPage()
                        'If it is the 1st page, we add bookmarks to the page
                        'Now we get the imported page
                        page = writer.GetImportedPage(reader, i)
                        'Read the imported page's rotation
                        rotation = reader.GetPageRotation(i)
                        'Then add the imported page to the PdfContentByte object as a template based on the page's rotation
                        If rotation = 90 Then
                            cb.AddTemplate(page, 0, -1.0F, 1.0F, 0, 0, reader.GetPageSizeWithRotation(i).Height)
                        ElseIf rotation = 270 Then
                            cb.AddTemplate(page, 0, 1.0F, -1.0F, 0, reader.GetPageSizeWithRotation(i).Width + 60, -30)
                        Else
                            cb.AddTemplate(page, 1.0F, 0, 0, 1.0F, 0, 0)
                        End If
                    End While
                    'Increment f and read the next input pdf file
                    f += 1
                    If f < pdfCount Then
                        fileName = pdfFiles(f)
                        reader = New iTextSharp.text.pdf.PdfReader(fileName)
                        pageCount = reader.NumberOfPages
                    End If
                End While
                'When all done, we close the document so that the pdfwriter object can write it to the output file
                pdfDoc.Close()
                result = True
            End If
        Catch ex As Exception
            Return False
        End Try
        Return result
    End Function

    Public Function SearchForChar(ByVal str1, ByVal str2) As Integer
        'Dim c As Integer
        'For c = 1 To Len(str1)
        '    If Mid(str1, c, str2) Then
        '        result += result
        '    End If
        'Next
        'SearchForChar = result
    End Function
    Public Sub flng(ByVal s As String)
        For Each Lng As InputLanguage In InputLanguage.InstalledInputLanguages
            If Lng.Culture.DisplayName.ToUpper.StartsWith(s) Then
                InputLanguage.CurrentInputLanguage = Lng
                Exit For
            End If
        Next
    End Sub
    Public Sub semail(ByVal txtTo As String, ByVal txtSubject As String, ByVal txtMessage As String, ByVal asd As Integer, ByVal assss As Integer)
        message = New System.Net.Mail.MailMessage(emaile, txtTo, txtSubject, txtMessage)
        If asd = 1 Then
            ACdr.Close()
            ACcmd.CommandText = "select * from email"
            ACdr = ACcmd.ExecuteReader
            While ACdr.Read
                attach = New System.Net.Mail.Attachment(ACdr("name"))
                message.Attachments.Add(attach)
            End While
        End If
        smtp.EnableSsl = True
        smtp.Credentials = New System.Net.NetworkCredential(emaile, pemaile)
        Try
            smtp.Send(message)
        Catch exc As Net.Mail.SmtpException
            MessageBox.Show(exc.StatusCode.ToString, "  Something Happened?", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub myemail(ByVal txtTo As String, ByVal txtSubject As String, ByVal txtMessage As String, ByVal asd As Integer, ByVal assss As Integer)
        message = New System.Net.Mail.MailMessage(emaile, txtTo, txtSubject, txtMessage)
        attach = New System.Net.Mail.Attachment("C:\Ali Hassan.pdf")
        message.Attachments.Add(attach)
        smtp.EnableSsl = True
        smtp.Credentials = New System.Net.NetworkCredential(emaile, pemaile)
        Try
            smtp.Send(message)
        Catch exc As Net.Mail.SmtpException
            MessageBox.Show(exc.StatusCode.ToString, "  Something Happened?", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub uchk(ByVal root As Control)
        For Each ctrl As Control In root.Controls
            uchk(ctrl)
            If TypeOf ctrl Is CheckBox Then
                If ctrl.Name = "CSUB" Or ctrl.Name = "CRES" Or ctrl.Name = "csave" Or ctrl.Name = "cesl_date" Or ctrl.Name = "cshift" Or ctrl.Name = "CBRAN" Or ctrl.Name = "CheckBox11" Or ctrl.Name = "RP1" Then
                Else
                    CType(ctrl, CheckBox).Checked = False
                End If
            End If
        Next ctrl
    End Sub
    Public Sub ClearTextBox(ByVal root As Control)


        For Each ctrl As Control In root.Controls

            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Text = String.Empty
            End If
        Next ctrl
    End Sub
    Public Sub colu(ByVal root As Control, ByVal bcol As Integer, ByVal fcol As Integer)
        root.BackColor = Color.FromArgb(bcol)
        For Each ctrl As Control In root.Controls
            colu(ctrl, bcol, fcol)

            If TypeOf ctrl Is TextBox Or TypeOf ctrl Is ComboBox Then
                ctrl.BackColor = Color.White
            ElseIf TypeOf ctrl Is TabPage Then
                ctrl.BackColor = Color.FromArgb(bcol)
            ElseIf TypeOf ctrl Is Label Or TypeOf ctrl Is CheckBox Or TypeOf ctrl Is TextBox Or TypeOf ctrl Is ComboBox Or TypeOf ctrl Is RadioButton Then
                ctrl.ForeColor = Color.FromArgb(fcol)
            ElseIf TypeOf ctrl Is Glass.GlassButton Then
                ctrl.ForeColor = Color.Black


            End If
        Next ctrl
        If LBILL.utc.CheckState = CheckState.Checked Or LBILL.utn.CheckState = CheckState.Checked Then
            LBILL.bon.BackColor = Color.Red
            LBILL.REST.BackColor = Color.Red
        End If

    End Sub

    Public Sub iface(ByVal root As Control)
        For Each ctrl As Control In root.Controls
            iface(ctrl)
            dr.Close()
            If TypeOf ctrl Is DateTimePicker Or TypeOf ctrl Is ComboBox Or TypeOf ctrl Is RadioButton Or TypeOf ctrl Is TextBox Or TypeOf ctrl Is Label Or TypeOf ctrl Is Glass.GlassButton Or TypeOf ctrl Is TabPage Or TypeOf ctrl Is CheckBox Then
                cmd.CommandText = "select * from iface where name='" & ctrl.Name & "'"
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows = False Then
                    dr.Close()
                    cmd.CommandText = "insert into iface (name,ar,en) values ('" & ctrl.Name & "','" & ctrl.Text & "','" & ctrl.Text & "')"
                    cmd.ExecuteNonQuery()
                End If
            End If
        Next ctrl
    End Sub
    Public Sub ifac(ByVal root As Control)

        For Each ctrl As Control In root.Controls
            ifac(ctrl)
            ACdr.Close()
            If TypeOf ctrl Is DateTimePicker Or TypeOf ctrl Is Button Or TypeOf ctrl Is DataGridView Or TypeOf ctrl Is ComboBox Or TypeOf ctrl Is RadioButton Or TypeOf ctrl Is TextBox Or TypeOf ctrl Is Label Or TypeOf ctrl Is Glass.GlassButton Or TypeOf ctrl Is TabPage Or TypeOf ctrl Is CheckBox Then

                ctrl.Visible = True
            End If

        Next ctrl
    End Sub
    Public Sub ifaceb(ByVal root As Control)

        For Each ctrl As Control In root.Controls
            ifaceb(ctrl)
            ACdr.Close()
            If TypeOf ctrl Is DateTimePicker Or TypeOf ctrl Is ComboBox Or TypeOf ctrl Is RadioButton Or TypeOf ctrl Is TextBox Or TypeOf ctrl Is Label Or TypeOf ctrl Is Glass.GlassButton Or TypeOf ctrl Is TabPage Or TypeOf ctrl Is CheckBox Then
                FRC = ifc.Select("NAME='" & ctrl.Name & "'")
                If FRC.Length > 0 Then
                    RC = FRC(0)
                    If RC("flg") = 1 Then
                        If IsDBNull(RC(lng)) = False Then ctrl.Text = RC(lng)
                    End If
                    If nulls(RC("hide")) = 1 Then
                        ctrl.Visible = False
                    End If
                End If
            End If
        Next ctrl

        FRC = ifc.Select("NAME='»‰«¡«·‰Ÿ«„ToolStripMenuItem'") : If FRC.Length > 0 Then LBILL.»‰«¡«·‰Ÿ«„ToolStripMenuItem.Text = FRC(0)(lng)
        If FRC.Length > 0 Then If FRC(0)("hide") = 1 Then LBILL.»‰«¡«·‰Ÿ«„ToolStripMenuItem.Visible = False
        FRC = ifc.Select("NAME='CustomizeToolStripMenuItem'") : If FRC.Length > 0 Then LBILL.CustomizeToolStripMenuItem.Text = FRC(0)(lng)
        If FRC.Length > 0 Then If FRC(0)("hide") = 1 Then LBILL.CustomizeToolStripMenuItem.Visible = False
        FRC = ifc.Select("NAME='OptionsToolStripMenuItem'") : If FRC.Length > 0 Then LBILL.OptionsToolStripMenuItem.Text = FRC(0)(lng)
        If FRC.Length > 0 Then If FRC(0)("hide") = 1 Then LBILL.OptionsToolStripMenuItem.Visible = False
        FRC = ifc.Select("NAME='ToolsToolStripMenuItem'") : If FRC.Length > 0 Then LBILL.ToolsToolStripMenuItem.Text = FRC(0)(lng)
        If FRC.Length > 0 Then If FRC(0)("hide") = 1 Then LBILL.ToolsToolStripMenuItem.Visible = False
        If FRC.Length > 0 Then If FRC(0)("hide") = 1 Then LBILL.FindToolStripMenuItem.Visible = False
        FRC = ifc.Select("NAME='FindNameToolStripMenuItem'") : If FRC.Length > 0 Then LBILL.FindNameToolStripMenuItem.Text = FRC(0)(lng)
        If FRC.Length > 0 Then If FRC(0)("hide") = 1 Then LBILL.FindNameToolStripMenuItem.Visible = False
        FRC = ifc.Select("NAME='FindIdToolStripMenuItem'") : If FRC.Length > 0 Then LBILL.FindIdToolStripMenuItem.Text = FRC(0)(lng)
        If FRC.Length > 0 Then If FRC(0)("hide") = 1 Then LBILL.FindIdToolStripMenuItem.Visible = False
        FRC = ifc.Select("NAME='FindMobileToolStripMenuItem'") : If FRC.Length > 0 Then LBILL.FindMobileToolStripMenuItem.Text = FRC(0)(lng)
        If FRC.Length > 0 Then If FRC(0)("hide") = 1 Then LBILL.FindMobileToolStripMenuItem.Visible = False
        FRC = ifc.Select("NAME='PervToolStripMenuItem'") : If FRC.Length > 0 Then LBILL.PervToolStripMenuItem.Text = FRC(0)(lng)
        If FRC.Length > 0 Then If FRC(0)("hide") = 1 Then LBILL.PervToolStripMenuItem.Visible = False
        FRC = ifc.Select("NAME='NextToolStripMenuItem'") : If FRC.Length > 0 Then LBILL.NextToolStripMenuItem.Text = FRC(0)(lng)
        If FRC.Length > 0 Then If FRC(0)("hide") = 1 Then LBILL.NextToolStripMenuItem.Visible = False
        FRC = ifc.Select("NAME='RefindToolStripMenuItem'") : If FRC.Length > 0 Then LBILL.RefindToolStripMenuItem.Text = FRC(0)(lng)
        If FRC.Length > 0 Then If FRC(0)("hide") = 1 Then LBILL.RefindToolStripMenuItem.Visible = False
        FRC = ifc.Select("NAME='NOTSEToolStripMenuItem'") : If FRC.Length > 0 Then LBILL.NOTSEToolStripMenuItem.Text = FRC(0)(lng)
        If FRC.Length > 0 Then If FRC(0)("hide") = 1 Then LBILL.NOTSEToolStripMenuItem.Visible = False
        FRC = ifc.Select("NAME='TestpriceToolStripMenuItem1'") : If FRC.Length > 0 Then LBILL.TestpriceToolStripMenuItem1.Text = FRC(0)(lng)
        If FRC.Length > 0 Then If FRC(0)("hide") = 1 Then LBILL.TestpriceToolStripMenuItem1.Visible = False
        FRC = ifc.Select("NAME='FUNCTIONToolStripMenuItem'") : If FRC.Length > 0 Then LBILL.FUNCTIONToolStripMenuItem.Text = FRC(0)(lng)
        If FRC.Length > 0 Then If FRC(0)("hide") = 1 Then LBILL.FUNCTIONToolStripMenuItem.Visible = False
        '================= CULT ================================================
        FRC = ifc.Select("NAME='Column11'") : If FRC.Length > 0 Then LBILL.Column11.HeaderText = "" : LBILL.Column11.Width = FRC(0)("Size")
        If FRC.Length > 0 Then If FRC(0)("hide") = 1 Then LBILL.Column11.Visible = False
        FRC = ifc.Select("NAME='Column12'") : If FRC.Length > 0 Then LBILL.Column12.HeaderText = "" : LBILL.Column12.Width = FRC(0)("Size")
        If FRC.Length > 0 Then If FRC(0)("hide") = 1 Then LBILL.Column12.Visible = False
        FRC = ifc.Select("NAME='Column13'") : If FRC.Length > 0 Then LBILL.Column13.HeaderText = "" : LBILL.Column13.Width = FRC(0)("Size")
        If FRC.Length > 0 Then If FRC(0)("hide") = 1 Then LBILL.Column13.Visible = False
        FRC = ifc.Select("NAME='Column23'") : If FRC.Length > 0 Then LBILL.Column23.HeaderText = "" : LBILL.Column23.Width = FRC(0)("Size")
        If FRC.Length > 0 Then If FRC(0)("hide") = 1 Then LBILL.Column23.Visible = False

        '===================END CULT============================================
        If lng = "AR" Then LBILL.btestd.Columns("Column1").HeaderText = "«·«Œ Ì«—" Else LBILL.btestd.Columns("Column1").HeaderText = "Choice"
        If lng = "AR" Then LBILL.btestd.Columns("Column8").HeaderText = "«· Õ·Ì·" Else LBILL.btestd.Columns("Column8").HeaderText = "TEST"
        If lng = "AR" Then LBILL.btestd.Columns("Column7").HeaderText = "«·”⁄—" Else LBILL.btestd.Columns("Column7").HeaderText = "PRICE"
        If lng = "AR" Then LBILL.btestd.Columns("Column6").HeaderText = "«·«” ·«„" Else LBILL.btestd.Columns("Column6").HeaderText = "Receiving"
        If lng = "AR" Then LBILL.btestd.Columns("Column18").HeaderText = "”Õ» «·⁄Ì‰…" Else LBILL.btestd.Columns("Column18").HeaderText = "Sampling"
    End Sub
    Public Sub fillTextBox(ByVal root As Control)
        For Each ctrl As Control In root.Controls
            fillTextBox(ctrl)
            If TypeOf ctrl Is TextBox And ctrl.Text = "" Then
                CType(ctrl, TextBox).Text = 0
            ElseIf TypeOf ctrl Is ComboBox And ctrl.Text = "" Then
                If CType(ctrl, ComboBox).Name <> "pname" Then CType(ctrl, ComboBox).Text = 0
            End If
        Next ctrl
    End Sub
    Public Sub CHEK(ByVal root As Control)
        For Each ctrl As Control In root.Controls
            CHEK(ctrl)
            If TypeOf ctrl Is CheckBox Then
                CType(ctrl, CheckBox).Checked = False
            End If
        Next ctrl
    End Sub
    Public Sub open_sql()

        ACcmd.CommandText = "select * from srv"
        ACdr = ACcmd.ExecuteReader
        ACdr.Read()
        cbcf = ACdr("cbcf")
        cbcd = ACdr("cbcd")
        If CN.State = ConnectionState.Connecting Then
            CN.Close()
        End If

        If CN.State = ConnectionState.Closed Then
            Try
                CN.ConnectionString = ACdr("PRO")
                CN.Open()
                cmd.Connection = CN
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "select * from users"
                dr = cmd.ExecuteReader
                dr.Read()
                dr.Close()
                cmd1.Connection = CN
                cmd1.CommandType = CommandType.Text
                cmd1.CommandType = CommandType.Text
                cmd1.CommandText = "select * from BRANCH"
                dr1 = cmd1.ExecuteReader
                dr1.Read()
                emaile = nulls(dr1("EMAILB"))
                pemaile = nulls(dr1("PASSB"))
                pvemail = nulls(dr1("email"))
                prov1 = nulls(dr1("prov"))
                cmd2.Connection = CN
                cmd2.CommandType = CommandType.Text
                cmd2.CommandText = "select * from users"
                dr2 = cmd2.ExecuteReader
                dr1.Read()
                dr.Close()
                ACdr.Close()
            Catch ex As OleDb.OleDbException
                MsgBox(" ⁄›Ê¬ ÌÊÃœ Œÿ√ ›Ï «·« ’«· »ﬁ«⁄œ… «·»Ì«‰« ", MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight)
                'Dim x As String
                'x = InputBox("«œŒ· «”„ «·ÃÂ«“")
                'ACDR.Close()
                'ACDR.close() : cmd1.CommandText = "update srv set srv='" & x & "'"
                'cmd1.ExecuteNonQuery()
                End
                Exit Try
            End Try
        End If
        ACdr.Close()
    End Sub
    Public Sub open_acc()
        If ACcn.State = ConnectionState.Closed Then
            Try
                ACcn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=TEMP.mdb;Persist Security Info=False"
                ACcn.Open()
                ACcmd.Connection = ACcn
                accmd1.CommandType = CommandType.Text
                accmd1.Connection = ACcn
                accmd1.CommandType = CommandType.Text
                accmd1.CommandText = "select * from EXP"
                acdr1 = accmd1.ExecuteReader
                acdr1.Close()
            Catch ex As OleDb.OleDbException
                MsgBox("⁄›Ê¬ ÌÊÃœ Œÿ√ ›Ï «·« ’«· »ﬁ«⁄œ… «·»Ì«‰« ", MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight)
                Exit Try
            End Try

        End If
    End Sub
    Public Function ChangeFormat(ByVal dtm As DateTime) As String
        Return dtm.ToString("M/d/yyyy")
    End Function
    Public Function nulls(ByVal n) As String
        If IsDBNull(n) = True Then Return 0 Else Return n
    End Function
    Public Function ChangeFormatall(ByVal dtm As DateTime) As String
        Return dtm.ToString("M/d/yyyy H:m:s")
    End Function

    Public Function CpuId() As String
        Dim computer As String = "."
        Dim wmi As Object = GetObject("winmgmts:" & _
            "{impersonationLevel=impersonate}!\\" & _
            computer & "\root\cimv2")
        Dim processors As Object = wmi.ExecQuery("Select * from Win32_Processor")

        Dim cpu_ids As String = ""
        For Each cpu As Object In processors
            cpu_ids = cpu_ids & ", " & cpu.ProcessorId
        Next cpu
        If cpu_ids.Length > 0 Then cpu_ids = cpu_ids.Substring(2)

        Return cpu_ids
    End Function
    Function ShowDriveInfo(ByVal drvpath)
        Dim fso, d, s, t
        fso = CreateObject("Scripting.FileSystemObject")
        d = fso.GetDrive(fso.GetDriveName(fso.GetAbsolutePathName("c:\")))
        Select Case d.DriveType
            Case 0 : t = "Unknown"
            Case 1 : t = "Removable"
            Case 2 : t = "Fixed"
            Case 3 : t = "Network"
            Case 4 : t = "CD-ROM"
            Case 5 : t = "RAM Disk"
        End Select

        d = fso.GetDrive(fso.GetDriveName(fso.GetAbsolutePathName("d:\")))
        s = " dSN: " & d.SerialNumber
        s = s & "cpu:" & CpuId()
        ShowDriveInfo = s
    End Function
End Module
