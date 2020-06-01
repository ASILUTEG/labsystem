Public Class images
    Const WM_CAP As Short = &H400S
    Const WM_CAP_DRIVER_CONNECT As Integer = WM_CAP + 10
    Const WM_CAP_DRIVER_DISCONNECT As Integer = WM_CAP + 11
    Const WM_CAP_EDIT_COPY As Integer = WM_CAP + 30
    Const WM_CAP_SET_PREVIEW As Integer = WM_CAP + 50
    Const WM_CAP_SET_PREVIEWRATE As Integer = WM_CAP + 52
    Const WM_CAP_SET_SCALE As Integer = WM_CAP + 53
    Const WS_CHILD As Integer = &H40000000
    Const WS_VISIBLE As Integer = &H10000000
    Const SWP_NOMOVE As Short = &H2S
    Const SWP_NOSIZE As Short = 1
    Const SWP_NOZORDER As Short = &H4S
    Const HWND_BOTTOM As Short = 1
    Dim iDevice As Integer = 0 ' Current device ID
    Dim hHwnd As Integer ' Handle to preview window
    Declare Function SendMessage Lib "user32" Alias "SendMessageA" _
        (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, _
        <Runtime.InteropServices.MarshalAs(Runtime.InteropServices.UnmanagedType.AsAny)> ByVal lParam As Object) As Integer
    Declare Function SetWindowPos Lib "user32" Alias "SetWindowPos" (ByVal hwnd As Integer, _
        ByVal hWndInsertAfter As Integer, ByVal x As Integer, ByVal y As Integer, _
        ByVal cx As Integer, ByVal cy As Integer, ByVal wFlags As Integer) As Integer
    Declare Function DestroyWindow Lib "user32" (ByVal hndw As Integer) As Boolean
    Declare Function capCreateCaptureWindowA Lib "avicap32.dll" _
        (ByVal lpszWindowName As String, ByVal dwStyle As Integer, _
        ByVal x As Integer, ByVal y As Integer, ByVal nWidth As Integer, _
        ByVal nHeight As Short, ByVal hWndParent As Integer, _
        ByVal nID As Integer) As Integer
    Declare Function capGetDriverDescriptionA Lib "avicap32.dll" (ByVal wDriver As Short, _
        ByVal lpszName As String, ByVal cbName As Integer, ByVal lpszVer As String, _
        ByVal cbVer As Integer) As Boolean
    '==========================================================cam
    Private Sub images_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadDeviceList()
        If lstDevices.Items.Count > 0 Then
            lstDevices.SelectedIndex = 0
        Else
            lstDevices.Items.Add("No Capture Device")
        End If
        btnStart_Click(btnStart, e)
    End Sub
    Public imagesn As Integer = 0
    Private Sub LoadDeviceList()
        Dim strName As String = Space(100)
        Dim strVer As String = Space(100)
        Dim bReturn As Boolean
        Dim x As Integer = 0
        Do
            bReturn = capGetDriverDescriptionA(x, strName, 100, strVer, 100)
            If bReturn Then lstDevices.Items.Add(strName.Trim)
            x += 1
        Loop Until bReturn = False
    End Sub
    Private Sub OpenPreviewWindow()
        Dim iHeight As Integer = picCapture.Height
        Dim iWidth As Integer = picCapture.Width

        '
        ' Open Preview window in picturebox
        '
        hHwnd = capCreateCaptureWindowA(iDevice, WS_VISIBLE Or WS_CHILD, 0, 0, 329, _
            244, picCapture.Handle.ToInt32, 0)

        '
        ' Connect to device
        '
        If SendMessage(hHwnd, WM_CAP_DRIVER_CONNECT, iDevice, 0) Then
            '
            'Set the preview scale
            '
            SendMessage(hHwnd, WM_CAP_SET_SCALE, True, 0)

            '
            'Set the preview rate in milliseconds
            '
            SendMessage(hHwnd, WM_CAP_SET_PREVIEWRATE, 66, 0)

            '
            'Start previewing the image from the camera
            '
            SendMessage(hHwnd, WM_CAP_SET_PREVIEW, True, 0)

            '
            ' Resize window to fit in picturebox
            '
            SetWindowPos(hHwnd, HWND_BOTTOM, 0, 0, picCapture.Width, picCapture.Height, _
                    SWP_NOMOVE Or SWP_NOZORDER)

        Else
            '
            ' Error connecting to device close window
            ' 
            DestroyWindow(hHwnd)

        End If
    End Sub
    Private Sub ClosePreviewWindow()
        '
        ' Disconnect from device
        '
        SendMessage(hHwnd, WM_CAP_DRIVER_DISCONNECT, iDevice, 0)

        '
        ' close window
        '

        DestroyWindow(hHwnd)
    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        iDevice = lstDevices.SelectedIndex
        OpenPreviewWindow()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        imagesn += 1
        Dim data As IDataObject
        Dim bmap As Image
        SendMessage(hHwnd, WM_CAP_EDIT_COPY, 0, 0)
        data = Clipboard.GetDataObject()
        If data.GetDataPresent(GetType(System.Drawing.Bitmap)) Then
            bmap = CType(data.GetData(GetType(System.Drawing.Bitmap)), Image)
            bmap.Save(Application.StartupPath & "\images\" & imagesn, Imaging.ImageFormat.Bmp)
            pb3.ImageLocation = Application.StartupPath & "\images\" & imagesn
        End If
        '=============================================================================
        Dim oer As System.IO.FileStream
        Dim rer As IO.StreamReader
        oer = New IO.FileStream(Application.StartupPath & "\images\" & imagesn, IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.Read)
        rer = New IO.StreamReader(oer)
        Dim FileByteArrayr(oer.Length - 1) As Byte
        oer.Read(FileByteArrayr, 0, oer.Length)
        dr.Close()
        cmd.CommandText = "select * from lbillimage where ESL_NO='" & Val(LBILL.esl_no.Text) & "' "
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            Dim x As String
            dr.Close()
            x = MsgBox("Â·  —Ìœ «· ⁄œÌ· ø", MsgBoxStyle.YesNo)
            If x = vbNo Then Exit Sub
            dr.Close() : dr.Close() : cmd.CommandText = "delete from lbillimage where  ESL_NO='" & Val(LBILL.esl_no.Text) & "'"
            cmd.ExecuteNonQuery()
        End If
        dr.Close()
        dr.Close()
        cmd.CommandText = "select max(code) from lbillimage WHERE ESL_NO='" & LBILL.esl_no.Text & "' "
        dr = cmd.ExecuteReader
        dr.Read()
        LBILL.IMAGE_CODE.Text = nulls(dr(0)) + 1
        dr.Close()
        cmd.CommandText = "insert into lbillimage (ESL_NO,CODE,IIMAGE) values ('" & LBILL.esl_no.Text & "','" & LBILL.IMAGE_CODE.Text & "','" & LBILL.IIMAGE.Text & "')"
        cmd.ExecuteNonQuery()
        Dim Sql As String = "update  lbillimage set image = ? , no = ? where  ESL_NO='" & Val(LBILL.esl_no.Text) & "' AND CODE='" & LBILL.IMAGE_CODE.Text & "'"
        cmd.CommandText = Sql
        cmd.Parameters.Clear()
        cmd.Parameters.Add("@image", System.Data.OleDb.OleDbType.Binary, oer.Length).Value = FileByteArrayr
        cmd.Parameters.Add("@no", System.Data.OleDb.OleDbType.VarChar, 100).Value = oer.Length
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        ClosePreviewWindow()
    End Sub

    Private Sub cin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cin.Click
        imagesn += 1
        Dim nn As Integer = InputBox("«œŒ· ﬂÊœ  «·„” Œœ„")
        LEMP.TextBox11.Text = nn
        dr.Close()
        cmd.CommandText = "select * from eemp where code='" & nn & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = False Then MsgBox("«·„” Œœ„ €Ì— „”Ã·") : Exit Sub
        LEMP.pcode.Text = dr("code")
        LEMP.pname.Text = dr("name")
        LEMP.inh.Text = dr("inh")
        LEMP.outm.Text = dr("outm")
        LEMP.outh.Text = dr("outh")
        LEMP.inm.Text = dr("inm")
        LEMP.emp_date.Value = dr("emp_date")
        LEMP.id.Text = dr("id")
        LEMP.mobile.Text = dr("mobile")
        LEMP.edu_code.Text = dr("edu_code")
        LEMP.jop_code.Text = dr("jop_code")
        LEMP.jop_name.Text = dr("jop_name")
        LEMP.insr_code.Text = dr("insr_code")
        LEMP.weekend.Text = dr("insr_name")
        LEMP.shift.Text = dr("shift")
        LEMP.mon_day.Text = dr("mon_day")
        LEMP.birth_day.Text = dr("birth_day")
        If IsNumeric(LEMP.pe_code.Text) = False Then MsgBox("«·—Ã«¡ «Œ Ì«— Ê—ﬁ… «· ⁄Ì‰") : Exit Sub
        If IsNumeric(LEMP.pcode.Text) = False Then MsgBox("«·—Ã«¡«Œ Ì«— «·„ÊŸ›") : Exit Sub
        dr.Close() : cmd.CommandText = "select * from ein where edate='" & ChangeFormat(Now) & "' and  code='" & LEMP.pcode.Text & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then MsgBox(" „  ”ÃÌ· «·Õ÷Ê—") : Exit Sub
        dr.Close()
        cmd.CommandText = "select * from sdate "
        dr = cmd.ExecuteReader
        dr.Read()
        Dim anow As Date = dr("sdate")
        Dim xxxx As Date = anow.Date + TimeSpan.FromHours(LEMP.inh.Text) + TimeSpan.FromMinutes(LEMP.inm.Text)
        Dim data As IDataObject
        Dim bmap As Image
        SendMessage(hHwnd, WM_CAP_EDIT_COPY, 0, 0)
        data = Clipboard.GetDataObject()
        If data.GetDataPresent(GetType(System.Drawing.Bitmap)) Then
            bmap = CType(data.GetData(GetType(System.Drawing.Bitmap)), Image)
            bmap.Save(Application.StartupPath & "\images\" & imagesn, Imaging.ImageFormat.Bmp)
            pb3.ImageLocation = Application.StartupPath & "\images\" & imagesn
        End If
        '=============================================================================
        Dim oer As System.IO.FileStream
        Dim rer As IO.StreamReader
        oer = New IO.FileStream(Application.StartupPath & "\images\" & imagesn, IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.Read)
        rer = New IO.StreamReader(oer)
        Dim FileByteArrayr(oer.Length - 1) As Byte
        oer.Read(FileByteArrayr, 0, oer.Length)
        dr.Close()
        Dim asx As TimeSpan
        asx = anow - xxxx
        dr.Close()
        cmd.CommandText = "insert into ein ([name],[code],[come_date],[come_diff],[edate],comh,comm) VALUES ('" & LEMP.pname.Text & "','" & LEMP.pcode.Text & "','" & ChangeFormatall(anow) & "','" & Math.Round(asx.TotalMinutes, 0) & "','" & ChangeFormat(anow) & "','" & asx.Hours & "','" & asx.Minutes & "')"
        cmd.ExecuteNonQuery()
        Dim Sql As String = "update  ein set come_pic = ? , come_picn = ? where  edate='" & ChangeFormat(anow) & "' and  code='" & LEMP.pcode.Text & "'"
        cmd.CommandText = Sql
        cmd.Parameters.Clear()
        cmd.Parameters.Add("@come_pic", System.Data.OleDb.OleDbType.Binary, oer.Length).Value = FileByteArrayr
        cmd.Parameters.Add("@come_picn", System.Data.OleDb.OleDbType.VarChar, 100).Value = oer.Length
        cmd.ExecuteNonQuery()
        MsgBox(" „  ⁄„·Ì… «·Õ›Ÿ", MsgBoxStyle.Information)
    End Sub

    Private Sub GlassButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton1.Click
        Dim nn As Integer = InputBox("«œŒ· ﬂÊœ  «·„” Œœ„")
        LEMP.TextBox11.Text = nn
        dr.Close()
        cmd.CommandText = "select * from eemp where code='" & nn & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = False Then MsgBox("«·„” Œœ„ €Ì— „”Ã·") : Exit Sub
        LEMP.pcode.Text = dr("code")
        LEMP.pname.Text = dr("name")
        LEMP.inh.Text = dr("inh")
        LEMP.outm.Text = dr("outm")
        LEMP.outh.Text = dr("outh")
        LEMP.inm.Text = dr("inm")
        If IsNumeric(LEMP.pe_code.Text) = False Then MsgBox("«·—Ã«¡ «Œ Ì«— Ê—ﬁ… «· ⁄Ì‰") : Exit Sub
        If IsNumeric(LEMP.pcode.Text) = False Then MsgBox("«·—Ã«¡«Œ Ì«— «·„ÊŸ›") : Exit Sub
        dr.Close() : cmd.CommandText = "select * from ein where   code='" & nn & "' and ovr=0"
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = False Then MsgBox("·„ Ì „  ”ÃÌ· «·Õ÷Ê—") : Exit Sub
        Dim aaa As Date = dr("come_date")
        dr.Close()
        cmd.CommandText = "select * from sdate "
        dr = cmd.ExecuteReader
        dr.Read()
        Dim anow As Date = dr("sdate")
        Dim asx As TimeSpan
        asx = anow - aaa
        Dim asxx As Double
        asxx = Math.Round(asx.TotalHours, 2)
        Dim data As IDataObject
        Dim bmap As Image
        SendMessage(hHwnd, WM_CAP_EDIT_COPY, 0, 0)
        data = Clipboard.GetDataObject()
        If data.GetDataPresent(GetType(System.Drawing.Bitmap)) Then
            bmap = CType(data.GetData(GetType(System.Drawing.Bitmap)), Image)
            bmap.Save(Application.StartupPath & "\images\" & imagesn, Imaging.ImageFormat.Bmp)
            pb3.ImageLocation = Application.StartupPath & "\images\" & imagesn
        End If
        '=============================================================================
        Dim oer As System.IO.FileStream
        Dim rer As IO.StreamReader
        oer = New IO.FileStream(Application.StartupPath & "\images\" & imagesn, IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.Read)
        rer = New IO.StreamReader(oer)
        Dim FileByteArrayr(oer.Length - 1) As Byte
        oer.Read(FileByteArrayr, 0, oer.Length)
        Dim xxxx As Date = anow.Date + TimeSpan.FromHours(LEMP.outh.Text) + TimeSpan.FromMinutes(LEMP.outm.Text)
        asx = anow - xxxx
        '=============================================================================
        dr.Close()
        Dim Sql As String = "update  ein set out_pic = ? , out_picn = ?,out_date='" & ChangeFormatall(Now) & "',ovr=1,out_diff='" & Math.Round(asx.TotalMinutes, 0) & "',ework='" & asxx & "',outh='" & asx.Hours & "',outm='" & asx.Minutes & "' where  ovr=0 and  code='" & nn & "'"
        cmd.CommandText = Sql
        cmd.Parameters.Clear()
        cmd.Parameters.Add("@out_pic", System.Data.OleDb.OleDbType.Binary, oer.Length).Value = FileByteArrayr
        cmd.Parameters.Add("@out_picn", System.Data.OleDb.OleDbType.VarChar, 100).Value = oer.Length
        cmd.CommandText = "update  ein set out_date='" & ChangeFormatall(anow) & "',ovr=1,out_diff='" & Math.Round(asx.TotalMinutes, 0) & "',ework='" & asxx & "',outh='" & asx.Hours & "',outm='" & asx.Minutes & "' where  ovr=0 and  code='" & nn & "'"
        cmd.ExecuteNonQuery()
    End Sub
End Class