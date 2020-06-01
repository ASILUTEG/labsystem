Public Class LEMP
    Dim dttt As Date = Now
    Dim b As New BarcodeLib.Barcode()
    Dim cmdedu As New OleDb.OleDbCommand
    Dim adedu As New OleDb.OleDbDataAdapter
    Dim edu As New DataTable

    Dim cmdTQ As New OleDb.OleDbCommand
    Dim adTQ As New OleDb.OleDbDataAdapter
    Dim TQ As New DataTable

    Dim cmdETD As New OleDb.OleDbCommand
    Dim adETD As New OleDb.OleDbDataAdapter
    Dim ETD As New DataTable
    Dim cmdTD As New OleDb.OleDbCommand
    Dim adTD As New OleDb.OleDbDataAdapter
    Dim TD As New DataTable

    Dim cmdETQ As New OleDb.OleDbCommand
    Dim adETQ As New OleDb.OleDbDataAdapter
    Dim ETQ As New DataTable

    Dim cmdESHIFT As New OleDb.OleDbCommand
    Dim adESHIFT As New OleDb.OleDbDataAdapter
    Dim ESHIFT As New DataTable
    Dim cmdeems As New OleDb.OleDbCommand
    Dim adeems As New OleDb.OleDbDataAdapter
    Dim eems As New DataTable
    Dim cmdEMS As New OleDb.OleDbCommand
    Dim adEMS As New OleDb.OleDbDataAdapter
    Dim EMS As New DataTable
    Dim cmdA As New OleDb.OleDbCommand
    Dim adA As New OleDb.OleDbDataAdapter
    Dim REH As New DataTable
    Dim cmDREH As New OleDb.OleDbCommand
    Dim adREH As New OleDb.OleDbDataAdapter
    Dim A As New DataTable
    Dim cmdBOOK As New OleDb.OleDbCommand
    Dim adBOOK As New OleDb.OleDbDataAdapter
    Dim BOOK As New DataTable
    Dim cmdog As New OleDb.OleDbCommand
    Dim adog As New OleDb.OleDbDataAdapter
    Dim og As New DataTable
    Dim cmdagz As New OleDb.OleDbCommand
    Dim adagz As New OleDb.OleDbDataAdapter
    Dim agz As New DataTable
    Dim cmdav_type1 As New OleDb.OleDbCommand
    Dim adav_type1 As New OleDb.OleDbDataAdapter
    Dim av_type1 As New DataTable
    Dim cmdap_type1 As New OleDb.OleDbCommand
    Dim adap_type1 As New OleDb.OleDbDataAdapter
    Dim ap_type1 As New DataTable
    Dim cmdtn As New OleDb.OleDbCommand
    Dim adtn As New OleDb.OleDbDataAdapter
    Dim tn As New DataTable
    Dim cmdbranch As New OleDb.OleDbCommand
    Dim adbranch As New OleDb.OleDbDataAdapter
    Dim branch As New DataTable
    Dim cmdstat As New OleDb.OleDbCommand
    Dim adstat As New OleDb.OleDbDataAdapter
    Dim stat As New DataTable
    Dim cmdmang As New OleDb.OleDbCommand
    Dim admang As New OleDb.OleDbDataAdapter
    Dim mang As New DataTable
    Dim cmdtm As New OleDb.OleDbCommand
    Dim adtm As New OleDb.OleDbDataAdapter
    Dim tm As New DataTable
    Dim cmdedutype As New OleDb.OleDbCommand
    Dim adedutype As New OleDb.OleDbDataAdapter
    Dim edutype As New DataTable
    Dim cmdTEMP2 As New OleDb.OleDbCommand
    Dim adTEMP2 As New OleDb.OleDbDataAdapter
    Dim TEMP2 As New DataTable
    Dim cmdTEMP1 As New OleDb.OleDbCommand
    Dim adTEMP1 As New OleDb.OleDbDataAdapter
    Dim TEMP1 As New DataTable
    Dim cmdeemp As New OleDb.OleDbCommand
    Dim adeemp As New OleDb.OleDbDataAdapter
    Dim eemp As New DataTable
    Dim cmdjop As New OleDb.OleDbCommand
    Dim adjop As New OleDb.OleDbDataAdapter
    Dim jop As New DataTable
    Dim cmdinsr As New OleDb.OleDbCommand
    Dim adinsr As New OleDb.OleDbDataAdapter
    Dim insr As New DataTable
    Dim cmdgroup As New OleDb.OleDbCommand
    Dim adgroup As New OleDb.OleDbDataAdapter
    Dim group As New DataTable
    Dim cmdpe As New OleDb.OleDbCommand
    Dim adpe As New OleDb.OleDbDataAdapter
    Dim pe As New DataTable
    Dim cmdmon As New OleDb.OleDbCommand
    Dim admon As New OleDb.OleDbDataAdapter
    Dim course As New DataTable
    Dim cmdcourse As New OleDb.OleDbCommand
    Dim adcourse As New OleDb.OleDbDataAdapter
    Dim mon As New DataTable
    Dim cmdWORK As New OleDb.OleDbCommand
    Dim adWORK As New OleDb.OleDbDataAdapter
    Dim WORK As New DataTable
    Dim d1, SV, ED, DEL, fast, hrcv, prnt, rpt, hs, lres, mng, su As Integer
    Dim wee As Integer = 1
    Dim sname, yy As String
    Dim egz As TimeSpan

    Public Sub sum(ByVal s As Integer)
        If s = 1 Then
            net_1.Text = (Val(c1_1.Text) + Val(c2_1.Text) + Val(c3_1.Text) + Val(c4_1.Text) - Val(o1_1.Text) - Val(o2_1.Text) - Val(o3_1.Text) - Val(o4_1.Text) - Val(insr_1.Text) - Val(drb_1.Text)) * Val(st_1.Text)
        ElseIf s = 2 Then
            net_2.Text = (Val(c1_2.Text) + Val(c2_2.Text) + Val(c3_2.Text) + Val(c4_2.Text) - Val(o1_2.Text) - Val(o2_2.Text) - Val(o3_2.Text) - Val(o4_2.Text) - Val(insr_2.Text) - Val(drb_2.Text)) * Val(st_2.Text)
        ElseIf s = 3 Then
            net_3.Text = (Val(c1_3.Text) + Val(c2_3.Text) + Val(c3_3.Text) + Val(c4_3.Text) - Val(o1_3.Text) - Val(o2_3.Text) - Val(o3_3.Text) - Val(o4_3.Text) - Val(insr_3.Text) - Val(drb_3.Text)) * Val(st_3.Text)
        ElseIf s = 4 Then
            net_4.Text = (Val(c1_4.Text) + Val(c2_4.Text) + Val(c3_4.Text) + Val(c4_4.Text) - Val(o1_4.Text) - Val(o2_4.Text) - Val(o3_4.Text) - Val(o4_4.Text) - Val(insr_4.Text) - Val(drb_4.Text)) * Val(st_4.Text)
        ElseIf s = 5 Then
            net_5.Text = (Val(c1_5.Text) + Val(c2_5.Text) + Val(c3_5.Text) + Val(c4_5.Text) - Val(o1_5.Text) - Val(o2_5.Text) - Val(o3_5.Text) - Val(o4_5.Text) - Val(insr_5.Text) - Val(drb_5.Text)) * Val(st_5.Text)
        ElseIf s = 6 Then
            net_6.Text = (Val(c1_6.Text) + Val(c2_6.Text) + Val(c3_6.Text) + Val(c4_6.Text) - Val(o1_6.Text) - Val(o2_6.Text) - Val(o3_6.Text) - Val(o4_6.Text) - Val(insr_6.Text) - Val(drb_6.Text)) * Val(st_6.Text)
        ElseIf s = 7 Then
            net_7.Text = (Val(c1_7.Text) + Val(c2_7.Text) + Val(c3_7.Text) + Val(c4_7.Text) - Val(o1_7.Text) - Val(o2_7.Text) - Val(o3_7.Text) - Val(o4_7.Text) - Val(insr_7.Text) - Val(drb_7.Text)) * Val(st_7.Text)
        ElseIf s = 8 Then
            net_8.Text = (Val(c1_8.Text) + Val(c2_8.Text) + Val(c3_8.Text) + Val(c4_8.Text) - Val(o1_8.Text) - Val(o2_8.Text) - Val(o3_8.Text) - Val(o4_8.Text) - Val(insr_8.Text) - Val(drb_8.Text)) * Val(st_8.Text)
        ElseIf s = 9 Then
            net_9.Text = (Val(c1_9.Text) + Val(c2_9.Text) + Val(c3_9.Text) + Val(c4_9.Text) - Val(o1_9.Text) - Val(o2_9.Text) - Val(o3_9.Text) - Val(o4_9.Text) - Val(insr_9.Text) - Val(drb_9.Text)) * Val(st_9.Text)
        ElseIf s = 10 Then
            net_10.Text = (Val(c1_10.Text) + Val(c2_10.Text) + Val(c3_10.Text) + Val(c4_10.Text) - Val(o1_10.Text) - Val(o2_10.Text) - Val(o3_10.Text) - Val(o4_10.Text) - Val(insr_10.Text) - Val(drb_10.Text)) * Val(st_10.Text)
        ElseIf s = 11 Then
            net_11.Text = (Val(c1_11.Text) + Val(c2_11.Text) + Val(c3_11.Text) + Val(c4_11.Text) - Val(o1_11.Text) - Val(o2_11.Text) - Val(o3_11.Text) - Val(o4_11.Text) - Val(insr_11.Text) - Val(drb_11.Text)) * Val(st_11.Text)
        ElseIf s = 12 Then
            net_12.Text = (Val(c1_12.Text) + Val(c2_12.Text) + Val(c3_12.Text) + Val(c4_12.Text) - Val(o1_12.Text) - Val(o2_12.Text) - Val(o3_12.Text) - Val(o4_12.Text) - Val(insr_12.Text) - Val(drb_12.Text)) * Val(st_12.Text)
        ElseIf s = 0 Then
            net_1.Text = (Val(c1_1.Text) + Val(c2_1.Text) + Val(c3_1.Text) + Val(c4_1.Text) - Val(o1_1.Text) - Val(o2_1.Text) - Val(o3_1.Text) - Val(o4_1.Text) - Val(insr_1.Text) - Val(drb_1.Text)) * Val(st_1.Text)
            net_2.Text = (Val(c1_2.Text) + Val(c2_2.Text) + Val(c3_2.Text) + Val(c4_2.Text) - Val(o1_2.Text) - Val(o2_2.Text) - Val(o3_2.Text) - Val(o4_2.Text) - Val(insr_2.Text) - Val(drb_2.Text)) * Val(st_2.Text)
            net_3.Text = (Val(c1_3.Text) + Val(c2_3.Text) + Val(c3_3.Text) + Val(c4_3.Text) - Val(o1_3.Text) - Val(o2_3.Text) - Val(o3_3.Text) - Val(o4_3.Text) - Val(insr_3.Text) - Val(drb_3.Text)) * Val(st_3.Text)
            net_4.Text = (Val(c1_4.Text) + Val(c2_4.Text) + Val(c3_4.Text) + Val(c4_4.Text) - Val(o1_4.Text) - Val(o2_4.Text) - Val(o3_4.Text) - Val(o4_4.Text) - Val(insr_4.Text) - Val(drb_4.Text)) * Val(st_4.Text)
            net_5.Text = (Val(c1_5.Text) + Val(c2_5.Text) + Val(c3_5.Text) + Val(c4_5.Text) - Val(o1_5.Text) - Val(o2_5.Text) - Val(o3_5.Text) - Val(o4_5.Text) - Val(insr_5.Text) - Val(drb_5.Text)) * Val(st_5.Text)
            net_6.Text = (Val(c1_6.Text) + Val(c2_6.Text) + Val(c3_6.Text) + Val(c4_6.Text) - Val(o1_6.Text) - Val(o2_6.Text) - Val(o3_6.Text) - Val(o4_6.Text) - Val(insr_6.Text) - Val(drb_6.Text)) * Val(st_6.Text)
            net_7.Text = (Val(c1_7.Text) + Val(c2_7.Text) + Val(c3_7.Text) + Val(c4_7.Text) - Val(o1_7.Text) - Val(o2_7.Text) - Val(o3_7.Text) - Val(o4_7.Text) - Val(insr_7.Text) - Val(drb_7.Text)) * Val(st_7.Text)
            net_8.Text = (Val(c1_8.Text) + Val(c2_8.Text) + Val(c3_8.Text) + Val(c4_8.Text) - Val(o1_8.Text) - Val(o2_8.Text) - Val(o3_8.Text) - Val(o4_8.Text) - Val(insr_8.Text) - Val(drb_8.Text)) * Val(st_8.Text)
            net_9.Text = (Val(c1_9.Text) + Val(c2_9.Text) + Val(c3_9.Text) + Val(c4_9.Text) - Val(o1_9.Text) - Val(o2_9.Text) - Val(o3_9.Text) - Val(o4_9.Text) - Val(insr_9.Text) - Val(drb_9.Text)) * Val(st_9.Text)
            net_10.Text = (Val(c1_10.Text) + Val(c2_10.Text) + Val(c3_10.Text) + Val(c4_10.Text) - Val(o1_10.Text) - Val(o2_10.Text) - Val(o3_10.Text) - Val(o4_10.Text) - Val(insr_10.Text) - Val(drb_10.Text)) * Val(st_10.Text)
            net_11.Text = (Val(c1_11.Text) + Val(c2_11.Text) + Val(c3_11.Text) + Val(c4_11.Text) - Val(o1_11.Text) - Val(o2_11.Text) - Val(o3_11.Text) - Val(o4_11.Text) - Val(insr_11.Text) - Val(drb_11.Text)) * Val(st_11.Text)
            net_12.Text = (Val(c1_12.Text) + Val(c2_12.Text) + Val(c3_12.Text) + Val(c4_12.Text) - Val(o1_12.Text) - Val(o2_12.Text) - Val(o3_12.Text) - Val(o4_12.Text) - Val(insr_12.Text) - Val(drb_12.Text)) * Val(st_12.Text)
        End If
    End Sub
    Public Sub alls(ByVal t As String, ByVal a As Integer, ByVal tt As String)
        If t = "c1" Or t = "0" Then
            If a < 12 Then c1_12.Text = tt
            If a < 11 Then c1_11.Text = tt
            If a < 10 Then c1_10.Text = tt
            If a < 9 Then c1_9.Text = tt
            If a < 8 Then c1_8.Text = tt
            If a < 7 Then c1_7.Text = tt
            If a < 6 Then c1_6.Text = tt
            If a < 5 Then c1_5.Text = tt
            If a < 4 Then c1_4.Text = tt
            If a < 3 Then c1_3.Text = tt
            If a < 2 Then c1_2.Text = tt
            If a < 1 Then c1_1.Text = tt
        End If
        If t = "c2" Or t = "0" Then
            If a < 12 Then c2_12.Text = tt
            If a < 11 Then c2_11.Text = tt
            If a < 10 Then c2_10.Text = tt
            If a < 9 Then c2_9.Text = tt
            If a < 8 Then c2_8.Text = tt
            If a < 7 Then c2_7.Text = tt
            If a < 6 Then c2_6.Text = tt
            If a < 5 Then c2_5.Text = tt
            If a < 4 Then c2_4.Text = tt
            If a < 3 Then c2_3.Text = tt
            If a < 2 Then c2_2.Text = tt
            If a < 1 Then c2_1.Text = tt
        End If
        If t = "c3" Or t = "0" Then
            If a < 12 Then c3_12.Text = tt
            If a < 11 Then c3_11.Text = tt
            If a < 10 Then c3_10.Text = tt
            If a < 9 Then c3_9.Text = tt
            If a < 8 Then c3_8.Text = tt
            If a < 7 Then c3_7.Text = tt
            If a < 6 Then c3_6.Text = tt
            If a < 5 Then c3_5.Text = tt
            If a < 4 Then c3_4.Text = tt
            If a < 3 Then c3_3.Text = tt
            If a < 2 Then c3_2.Text = tt
            If a < 1 Then c3_1.Text = tt
        End If
        If t = "c4" Or t = "0" Then
            If a < 12 Then c4_12.Text = tt
            If a < 11 Then c4_11.Text = tt
            If a < 10 Then c4_10.Text = tt
            If a < 9 Then c4_9.Text = tt
            If a < 8 Then c4_8.Text = tt
            If a < 7 Then c4_7.Text = tt
            If a < 6 Then c4_6.Text = tt
            If a < 5 Then c4_5.Text = tt
            If a < 4 Then c4_4.Text = tt
            If a < 3 Then c4_3.Text = tt
            If a < 2 Then c4_2.Text = tt
            If a < 1 Then c4_1.Text = tt
        End If
        If t = "o1" Or t = "0" Then
            If a < 12 Then o1_12.Text = tt
            If a < 11 Then o1_11.Text = tt
            If a < 10 Then o1_10.Text = tt
            If a < 9 Then o1_9.Text = tt
            If a < 8 Then o1_8.Text = tt
            If a < 7 Then o1_7.Text = tt
            If a < 6 Then o1_6.Text = tt
            If a < 5 Then o1_5.Text = tt
            If a < 4 Then o1_4.Text = tt
            If a < 3 Then o1_3.Text = tt
            If a < 2 Then o1_2.Text = tt
            If a < 1 Then o1_1.Text = tt
        End If
        If t = "o2" Or t = "0" Then
            If a < 12 Then o2_12.Text = tt
            If a < 11 Then o2_11.Text = tt
            If a < 10 Then o2_10.Text = tt
            If a < 9 Then o2_9.Text = tt
            If a < 8 Then o2_8.Text = tt
            If a < 7 Then o2_7.Text = tt
            If a < 6 Then o2_6.Text = tt
            If a < 5 Then o2_5.Text = tt
            If a < 4 Then o2_4.Text = tt
            If a < 3 Then o2_3.Text = tt
            If a < 2 Then o2_2.Text = tt
            If a < 1 Then o2_1.Text = tt
        End If
        If t = "o3" Or t = "0" Then
            If a < 12 Then o3_12.Text = tt
            If a < 11 Then o3_11.Text = tt
            If a < 10 Then o3_10.Text = tt
            If a < 9 Then o3_9.Text = tt
            If a < 8 Then o3_8.Text = tt
            If a < 7 Then o3_7.Text = tt
            If a < 6 Then o3_6.Text = tt
            If a < 5 Then o3_5.Text = tt
            If a < 4 Then o3_4.Text = tt
            If a < 3 Then o3_3.Text = tt
            If a < 2 Then o3_2.Text = tt
            If a < 1 Then o3_1.Text = tt
        End If
        If t = "o4" Or t = "0" Then
            If a < 12 Then o4_12.Text = tt
            If a < 11 Then o4_11.Text = tt
            If a < 10 Then o4_10.Text = tt
            If a < 9 Then o4_9.Text = tt
            If a < 8 Then o4_8.Text = tt
            If a < 7 Then o4_7.Text = tt
            If a < 6 Then o4_6.Text = tt
            If a < 5 Then o4_5.Text = tt
            If a < 4 Then o4_4.Text = tt
            If a < 3 Then o4_3.Text = tt
            If a < 2 Then o4_2.Text = tt
            If a < 1 Then o4_1.Text = tt
        End If
        If t = "insr" Or t = "0" Then
            If a < 12 Then insr_12.Text = tt
            If a < 11 Then insr_11.Text = tt
            If a < 10 Then insr_10.Text = tt
            If a < 9 Then insr_9.Text = tt
            If a < 8 Then insr_8.Text = tt
            If a < 7 Then insr_7.Text = tt
            If a < 6 Then insr_6.Text = tt
            If a < 5 Then insr_5.Text = tt
            If a < 4 Then insr_4.Text = tt
            If a < 3 Then insr_3.Text = tt
            If a < 2 Then insr_2.Text = tt
            If a < 1 Then insr_1.Text = tt
        End If
        If t = "drb" Or t = "0" Then
            If a < 12 Then drb_12.Text = tt
            If a < 11 Then drb_11.Text = tt
            If a < 10 Then drb_10.Text = tt
            If a < 9 Then drb_9.Text = tt
            If a < 8 Then drb_8.Text = tt
            If a < 7 Then drb_7.Text = tt
            If a < 6 Then drb_6.Text = tt
            If a < 5 Then drb_5.Text = tt
            If a < 4 Then drb_4.Text = tt
            If a < 3 Then drb_3.Text = tt
            If a < 2 Then drb_2.Text = tt
            If a < 1 Then drb_1.Text = tt
        End If
        If t = "net" Or t = "0" Then
            If a < 12 Then net_12.Text = tt
            If a < 11 Then net_11.Text = tt
            If a < 10 Then net_10.Text = tt
            If a < 9 Then net_9.Text = tt
            If a < 8 Then net_8.Text = tt
            If a < 7 Then net_7.Text = tt
            If a < 6 Then net_6.Text = tt
            If a < 5 Then net_5.Text = tt
            If a < 4 Then net_4.Text = tt
            If a < 3 Then net_3.Text = tt
            If a < 2 Then net_2.Text = tt
            If a < 1 Then net_1.Text = tt
        End If
        If t = "st" Or t = "0" Then
            If a < 12 Then st_12.Text = tt
            If a < 11 Then st_11.Text = tt
            If a < 10 Then st_10.Text = tt
            If a < 9 Then st_9.Text = tt
            If a < 8 Then st_8.Text = tt
            If a < 7 Then st_7.Text = tt
            If a < 6 Then st_6.Text = tt
            If a < 5 Then st_5.Text = tt
            If a < 4 Then st_4.Text = tt
            If a < 3 Then st_3.Text = tt
            If a < 2 Then st_2.Text = tt
            If a < 1 Then st_1.Text = tt
        End If
        sum(0)
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
        MsgBox("it's saved", MsgBoxStyle.Information)
    End Sub
    Public Sub filla(ByVal tb As String)
        If tb = "eedu" Or tb = "" Then
            cmdedu.Connection = CN
            cmdedu.CommandType = CommandType.Text
            cmdedu.CommandText = "select * from eedu"
            adedu.SelectCommand = cmdedu
            adedu.Fill(DBS, "edu")
            edu = DBS.Tables("edu")
            DBS.Tables("edu").Clear()
            adedu.Fill(DBS, "edu")
            edu = DBS.Tables("edu")
            edu_name.DataSource = edu
            edu_name.DisplayMember = "NAME"
            edu_name.Text = ""
        End If
        If tb = "ETD" Or tb = "" Then
            cmdETD.Connection = CN
            cmdETD.CommandType = CommandType.Text
            cmdETD.CommandText = "select * from ETD"
            adETD.SelectCommand = cmdETD
            adETD.Fill(DBS, "ETD")
            ETD = DBS.Tables("ETD")
            DBS.Tables("ETD").Clear()
            adETD.Fill(DBS, "ETD")
            ETD = DBS.Tables("ETD")
            ETD_name.DataSource = ETD
            ETD_name.DisplayMember = "NAME"
            ETD_name.Text = ""
        End If
        If tb = "ETQ" Or tb = "" Then
            cmdTQ.Connection = CN
            cmdTQ.CommandType = CommandType.Text
            cmdTQ.CommandText = "select * from eTQ"
            adTQ.SelectCommand = cmdTQ
            adTQ.Fill(DBS, "TQ")
            TQ = DBS.Tables("TQ")
            DBS.Tables("TQ").Clear()
            adTQ.Fill(DBS, "TQ")
            TQ = DBS.Tables("TQ")
            TQ_NAME.DataSource = TQ
            TQ_NAME.DisplayMember = "NAME"
        End If
        If tb = "ESHIFT" Or tb = "" Then
            cmdESHIFT.Connection = CN
            cmdESHIFT.CommandType = CommandType.Text
            cmdESHIFT.CommandText = "select * from ESHIFT"
            adESHIFT.SelectCommand = cmdESHIFT
            adESHIFT.Fill(DBS, "ESHIFT")
            ESHIFT = DBS.Tables("ESHIFT")
            DBS.Tables("ESHIFT").Clear()
            adESHIFT.Fill(DBS, "ESHIFT")
            ESHIFT = DBS.Tables("ESHIFT")
            SHIFT_NAME.DataSource = ESHIFT
            SHIFT_NAME.DisplayMember = "NAME"

        End If
        If tb = "EMS" Or tb = "" Then
            cmdEMS.Connection = CN
            cmdEMS.CommandType = CommandType.Text
            cmdEMS.CommandText = "select * from EMS"
            adEMS.SelectCommand = cmdEMS
            adEMS.Fill(DBS, "EMS")
            EMS = DBS.Tables("EMS")
            DBS.Tables("EMS").Clear()
            adEMS.Fill(DBS, "EMS")
            EMS = DBS.Tables("EMS")
            MS_NAME.DataSource = EMS
            MS_NAME.DisplayMember = "NAME"
            MS_NAME.Text = ""
        End If
        If tb = "av_type" Or tb = "" Then
            cmdav_type1.Connection = CN
            cmdav_type1.CommandType = CommandType.Text
            If empa = 1 Then cmdav_type1.CommandText = "select * from av_type" Else cmdav_type1.CommandText = "select * from av_type WHERE ADMIN='0'"
            adav_type1.SelectCommand = cmdav_type1
            adav_type1.Fill(DBS, "av_type1")
            av_type1 = DBS.Tables("av_type1")
            DBS.Tables("av_type1").Clear()
            adav_type1.Fill(DBS, "av_type1")
            av_type1 = DBS.Tables("av_type1")
            av_type.DataSource = av_type1
            av_type.DisplayMember = "NAME"
            av_type.Text = ""
        End If
        If tb = "ap_type" Or tb = "" Then
            cmdap_type1.Connection = CN
            cmdap_type1.CommandType = CommandType.Text
            cmdap_type1.CommandText = "select * from ap_type"
            adap_type1.SelectCommand = cmdap_type1
            adap_type1.Fill(DBS, "ap_type1")
            ap_type1 = DBS.Tables("ap_type1")
            DBS.Tables("ap_type1").Clear()
            adap_type1.Fill(DBS, "ap_type1")
            ap_type1 = DBS.Tables("ap_type1")
            ap_type.DataSource = ap_type1
            ap_type.DisplayMember = "NAME"
            ap_type.Text = ""
        End If
        If tb = "ebranch" Or tb = "" Then
            cmdbranch.Connection = CN
            cmdbranch.CommandType = CommandType.Text
            cmdbranch.CommandText = "select * from ebranch"
            adbranch.SelectCommand = cmdbranch
            adbranch.Fill(DBS, "branch")
            branch = DBS.Tables("branch")
            DBS.Tables("branch").Clear()
            adbranch.Fill(DBS, "branch")
            branch = DBS.Tables("branch")
            branch_name.DataSource = branch
            branch_name.DisplayMember = "NAME"
            branch_name.Text = ""
        End If
        If tb = "estat" Or tb = "" Then
            cmdstat.Connection = CN
            cmdstat.CommandType = CommandType.Text
            cmdstat.CommandText = "select * from estat"
            adstat.SelectCommand = cmdstat
            adstat.Fill(DBS, "stat")
            stat = DBS.Tables("stat")
            DBS.Tables("stat").Clear()
            adstat.Fill(DBS, "stat")
            stat = DBS.Tables("stat")
            stat_name.DataSource = stat
            stat_name.DisplayMember = "NAME"
            stat_name.Text = ""
        End If
        If tb = "emang" Or tb = "" Then
            cmdmang.Connection = CN
            cmdmang.CommandType = CommandType.Text
            cmdmang.CommandText = "select * from emang"
            admang.SelectCommand = cmdmang
            admang.Fill(DBS, "mang")
            mang = DBS.Tables("mang")
            DBS.Tables("mang").Clear()
            admang.Fill(DBS, "mang")
            mang = DBS.Tables("mang")
            mang_name.DataSource = mang
            mang_name.DisplayMember = "NAME"
            mang_name.Text = ""
        End If
        If tb = "etm" Or tb = "" Then
            cmdtm.Connection = CN
            cmdtm.CommandType = CommandType.Text
            cmdtm.CommandText = "select * from eTM"
            adtm.SelectCommand = cmdtm
            adtm.Fill(DBS, "TM")
            tm = DBS.Tables("TM")
            DBS.Tables("TM").Clear()
            adtm.Fill(DBS, "TM")
            tm = DBS.Tables("TM")
            TM_NAME.DataSource = tm
            TM_NAME.DisplayMember = "NAME"
            TM_NAME.Text = ""
        End If
        If tb = "eedutype" Or tb = "" Then
            cmdedutype.Connection = CN
            cmdedutype.CommandType = CommandType.Text
            cmdedutype.CommandText = "select * from eedutype"
            adedutype.SelectCommand = cmdedutype
            adedutype.Fill(DBS, "edutype")
            edutype = DBS.Tables("edutype")
            DBS.Tables("edutype").Clear()
            adedutype.Fill(DBS, "edutype")
            edutype = DBS.Tables("edutype")
            edutype_name.DataSource = edutype
            edutype_name.DisplayMember = "NAME"
            edutype_name.Text = ""
        End If
        If tb = "emang" Or tb = "" Then
            cmdmang.Connection = CN
            cmdmang.CommandType = CommandType.Text
            cmdmang.CommandText = "select * from eMANG"
            admang.SelectCommand = cmdmang
            admang.Fill(DBS, "MANG")
            mang = DBS.Tables("MANG")
            DBS.Tables("MANG").Clear()
            admang.Fill(DBS, "MANG")
            mang = DBS.Tables("MANG")
            mang_name.DataSource = mang
            mang_name.DisplayMember = "NAME"
            mang_name.Text = ""
        End If
        If tb = "emonth" Or tb = "" Then
            cmdmon.Connection = CN
            cmdmon.CommandType = CommandType.Text
            cmdmon.CommandText = "select * from lmonth"
            admon.SelectCommand = cmdmon
            admon.Fill(DBS, "mon")
            mon = DBS.Tables("mon")
            DBS.Tables("mon").Clear()
            admon.Fill(DBS, "mon")
            mon = DBS.Tables("mon")
            mon_name.DataSource = mon
            mon_name.DisplayMember = "NAME"
            mon_name.Text = ""
        End If
        If tb = "ejop" Or tb = "" Then
            cmdjop.Connection = CN
            cmdjop.CommandType = CommandType.Text
            cmdjop.CommandText = "select * from ejop"
            adjop.SelectCommand = cmdjop
            adjop.Fill(DBS, "jop")
            jop = DBS.Tables("jop")
            DBS.Tables("jop").Clear()
            adjop.Fill(DBS, "jop")
            jop = DBS.Tables("jop")
            jop_name.DataSource = jop
            jop_name.DisplayMember = "NAME"
            jop_name.Text = ""
        End If
        If tb = "egroup" Or tb = "" Then
            cmdgroup.Connection = CN
            cmdgroup.CommandType = CommandType.Text
            cmdgroup.CommandText = "select * from egroup"
            adgroup.SelectCommand = cmdgroup
            adgroup.Fill(DBS, "group")
            group = DBS.Tables("group")
            DBS.Tables("group").Clear()
            adgroup.Fill(DBS, "group")
            group = DBS.Tables("group")
            group_name.DataSource = group
            group_name.DisplayMember = "NAME"
            group_name.Text = ""
        End If
        If tb = "epe" Or tb = "" Then
            cmdpe.Connection = CN
            cmdpe.CommandType = CommandType.Text
            cmdpe.CommandText = "select * from epe"
            adpe.SelectCommand = cmdpe
            adpe.Fill(DBS, "pe")
            pe = DBS.Tables("pe")
            DBS.Tables("pe").Clear()
            adpe.Fill(DBS, "pe")
            pe = DBS.Tables("pe")
            pe_name.DataSource = pe
            pe_name.DisplayMember = "NAME"
            pe_name.Text = ""
        End If
    End Sub

    Private Sub LEMP_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave
        End
    End Sub
    Public Sub SaveFile()

        'Dim fd As OpenFileDialog = New OpenFileDialog()
        'fd.Filter = "pdf file|*.pdf"
        'If fd.ShowDialog = System.Windows.Forms.DialogResult.OK Then
        '    dr.Close()
        '    Dim filebyte As Byte() = Nothing
        '    filebyte = System.IO.File.ReadAllBytes(fd.FileName)
        '    Dim oer As System.IO.FileStream
        '    Dim rer As IO.StreamReader
        '    oer = New IO.FileStream(fd.FileName, IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.Read)
        '    rer = New IO.StreamReader(oer)
        '    Dim FileByteArrayr(oer.Length - 1) As Byte
        '    oer.Read(FileByteArrayr, 0, oer.Length)
        '    cmd.CommandText = "update eemp_ms set la=@la"
        '    cmd.Parameters.Clear()
        '    cmd.Parameters.Add("@la", System.Data.OleDb.OleDbType.VarBinary, oer.Length).Value = FileByteArrayr
        '    cmd.ExecuteNonQuery()
        '    Interaction.MsgBox("File saved into database", MsgBoxStyle.Information)
        'End If

    End Sub
    Private Sub LEMP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If empa = 5011 Then
            empa = 1
            ifac(Me)
        Else
            empa = 0
            GlassButton35.Visible = False
        End If
        dr.Close()
        cmd.CommandText = "select * from eemp"
        dr = cmd.ExecuteReader
        PNAME1.AutoCompleteCustomSource.Clear()
        aeworker.Items.Clear()
        pname.AutoCompleteCustomSource.Clear()
        While dr.Read
            pname.AutoCompleteCustomSource.Add(dr("name"))
            PNAME1.AutoCompleteCustomSource.Add(dr("name"))
            aeworker.Items.Add(dr("name"))
        End While
        su = 0
        dr.Close() : cmd.CommandText = "select * from USERS where NAME='" & USR & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            SV = dr("eSAVE")
            DEL = dr("eDEL")
            ED = dr("eEDIT")
            rpt = dr("LESLRP")
            rpt = dr("LPRNT")
            hs = dr("Lcome")
            lres = dr("lres")
            mng = dr("admin")
        End If
        filla("")
       
        dr.Close()
        save_name.Items.Clear()
        cmd.CommandText = "select * from lsave "
        dr = cmd.ExecuteReader
        While dr.Read
            save_name.Items.Add(nulls(dr("name")))
        End While
        If mng = 0 Then
            TabControl1.TabPages.Remove(TabPage2)
            TabControl1.TabPages.Remove(TabPage3)
        Else
            TabControl1.Visible = True
        End If
    End Sub

    Private Sub edu_name_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles edu_name.GotFocus
        flng("AR")
    End Sub
    Private Sub edu_name_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles edu_name.KeyDown
        If e.KeyCode = Keys.ControlKey Then
            FSAVE(edu_name.Text, "eedu", 1)
        ElseIf e.KeyCode = Keys.Delete Then
            FSAVE(edu_name.Text, "eedu", 2)
        End If

    End Sub

    Private Sub edu_name_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edu_name.SelectedIndexChanged
        If edu_name.Focused = False Then Exit Sub
        If edu_name.Text = "" Then Exit Sub

        FRC = edu.Select("NAME='" & edu_name.Text & "'")
        If FRC.Length <= 0 Then
            edu_name.Text = ""
            edu_code.Text = ""
            Exit Sub
        Else
            RC = FRC(0)
            edu_code.Text = RC("code")
        End If
    End Sub

    Private Sub jop_name_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles jop_name.GotFocus
        flng("AR")
    End Sub

    Private Sub jop_name_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles jop_name.KeyDown
        If e.KeyCode = Keys.ControlKey Then
            FSAVE(jop_name.Text, "ejop", 1)
        ElseIf e.KeyCode = Keys.Delete Then
            FSAVE(jop_name.Text, "ejop", 2)
        End If
    End Sub

    Private Sub jop_name_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles jop_name.SelectedIndexChanged
        If jop_name.Focused = False Then Exit Sub
        If jop_name.Text = "" Then Exit Sub

        FRC = jop.Select("NAME='" & jop_name.Text & "'")
        If FRC.Length <= 0 Then
            jop_name.Text = ""
            jop_code.Text = ""
            Exit Sub
        Else
            RC = FRC(0)
            jop_code.Text = RC("code")
        End If
    End Sub

    Private Sub group_name_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles group_name.GotFocus
        flng("AR")
    End Sub


    Private Sub group_name_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles group_name.KeyDown
        If e.KeyCode = Keys.ControlKey Then
            FSAVE(group_name.Text, "egroup", 1)
        ElseIf e.KeyCode = Keys.Delete Then
            FSAVE(group_name.Text, "egroup", 2)
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

    Private Sub pe_name_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles pe_name.KeyDown
        Dim n As String
        If e.KeyCode = Keys.Enter Then
            If SV = 0 Then
                MsgBox("·Ì”  ·œÌﬂ «·’·«ÕÌ…")
                dr.Close()
                cmd.CommandText = "insert into llog (usr,note,date1,time1,gr) values ('" & suser & "','„Õ«Ê·…  Œ“Ì‰ ÿ»Ì» „⁄ ⁄œ„ «„ ·«ﬂ ’·«ÕÌ…','" & ChangeFormat(Now.Date) & "','" & Now.Hour & ":" & Now.Minute & ":" & Now.Second & "','„Õ«Ê·… «Œ —«ﬁ')"
                cmd.ExecuteNonQuery()
                Exit Sub
            End If
            n = ""
            n = MsgBox(" Â·  —Ìœ «·Õ›Ÿ ø", MsgBoxStyle.YesNo)
            If n = vbNo Then Exit Sub
            dr.Close() : cmd.CommandText = "select MAx(code) from epe "
            dr = cmd.ExecuteReader
            dr.Read()
            If IsDBNull(dr(0)) = False Then
                pe_code.Text = 1 + dr(0)
            Else
                pe_code.Text = 1
            End If

            If pe_name.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
            dr.Close()
            cmd.CommandText = "select * from epe where   code='" & pe_code.Text & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                If ED = 0 Then
                    MsgBox("·Ì”  ·œÌﬂ «·’·«ÕÌ…")
                    dr.Close()
                    cmd.CommandText = "insert into llog (usr,note,date1,time1,gr) values ('" & suser & "','„Õ«Ê·…  ⁄œÌ· «Ê—«ﬁ «· ⁄Ì‰ „⁄ ⁄œ„ «„ ·«ﬂ ’·«ÕÌ…','" & ChangeFormat(Now.Date) & "','" & Now.Hour & ":" & Now.Minute & ":" & Now.Second & "','„Õ«Ê·… «Œ —«ﬁ')"
                    cmd.ExecuteNonQuery()
                    Exit Sub
                End If
                n = ""
                n = MsgBox(" Â·  —Ìœ «· ⁄œÌ· ø", MsgBoxStyle.YesNo)
                If n = vbNo Then Exit Sub
                dr.Close()
                cmd.CommandText = "delete from epe where    code='" & pe_code.Text & "'"
                cmd.ExecuteNonQuery()
                dr.Close()
                cmd.CommandText = "insert into llog (usr,note,date1,time1,gr) values ('" & suser & "',' „  ⁄„·Ì…   ⁄œÌ· «Ê—«ﬁ «· ⁄Ì‰ »‰Ã«Õ','" & ChangeFormat(Now.Date) & "','" & Now.Hour & ":" & Now.Minute & ":" & Now.Second & "','⁄„·Ì… ‰«ÃÕ…')"
                cmd.ExecuteNonQuery()
            Else
                dr.Close()
                cmd.CommandText = "insert into llog (usr,note,date1,time1,gr) values ('" & suser & "',' „  ⁄„·Ì…   Œ“Ì‰ «Ê—«ﬁ «· ⁄Ì‰ »‰Ã«Õ','" & ChangeFormat(Now.Date) & "','" & Now.Hour & ":" & Now.Minute & ":" & Now.Second & "','⁄„·Ì… ‰«ÃÕ…')"
                cmd.ExecuteNonQuery()
            End If

            dr.Close() : cmd.CommandText = "insert into epe (code,name)  values ('" & pe_code.Text & "','" & pe_name.Text & "')"
            cmd.ExecuteNonQuery()
            cmdpe.Connection = CN
            cmdpe.CommandType = CommandType.Text
            cmdpe.CommandText = "select * from epe"
            adpe.SelectCommand = cmdpe
            adpe.Fill(DBS, "pe")
            pe = DBS.Tables("pe")
            DBS.Tables("pe").Clear()
            adpe.Fill(DBS, "pe")
            pe = DBS.Tables("pe")
            pe_name.DataSource = pe
            pe_name.DisplayMember = "NAME"

        End If
        If e.KeyCode = Keys.Delete Then
            If DEL = 0 Then
                MsgBox("·Ì”  ·œÌﬂ «·’·«ÕÌ…")
                dr.Close()
                cmd.CommandText = "insert into llog (usr,note,date1,time1,gr) values ('" & suser & "','„Õ«Ê·… Õ–›  «Ê—«ﬁ «· ⁄Ì‰ " & pe_name.Text & " „⁄ ⁄œ„ «„ ·«ﬂ ’·«ÕÌ…','" & ChangeFormat(Now.Date) & "','" & Now.Hour & ":" & Now.Minute & ":" & Now.Second & "','„Õ«Ê·… «Œ —«ﬁ')"
                cmd.ExecuteNonQuery()
                Exit Sub
            End If

            n = MsgBox(" Â·  —Ìœ «·Õ–› ø", MsgBoxStyle.YesNo)
            If IsNumeric(pe_code.Text) = False Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·ﬂÊœ") : Exit Sub
            If pe_name.Text = "" Then MsgBox("«·—Ã«¡ «· √ﬂœ „‰ «·»Ì«‰") : Exit Sub
            dr.Close()
            cmd.CommandText = "select * from epe where   code='" & pe_code.Text & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                dr.Close()
                cmd.CommandText = "delete from epe where    code='" & pe_code.Text & "'"
                cmd.ExecuteNonQuery()

            End If
            cmdpe.Connection = CN
            cmdpe.CommandType = CommandType.Text
            cmdpe.CommandText = "select * from epe"
            adpe.SelectCommand = cmdpe
            adpe.Fill(DBS, "pe")
            pe = DBS.Tables("pe")
            DBS.Tables("pe").Clear()
            adpe.Fill(DBS, "pe")
            pe = DBS.Tables("pe")
            pe_name.DataSource = pe
            pe_name.DisplayMember = "NAME"
            dr.Close()
            cmd.CommandText = "insert into llog (usr,note,date1,time1,gr) values ('" & suser & "','   „  ⁄„·Ì…  Õ–› «Ê—«ﬁ «· ⁄Ì‰ " & pe_name.Text & " »‰Ã«Õ','" & ChangeFormat(Now.Date) & "','" & Now.Hour & ":" & Now.Minute & ":" & Now.Second & "','⁄„·Ì… ‰«ÃÕ…')"
            cmd.ExecuteNonQuery()
        End If
    End Sub

    Private Sub pe_name_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pe_name.SelectedIndexChanged
        If pe_name.Focused = False Then Exit Sub
        If pe_name.Text = "" Then Exit Sub

        FRC = pe.Select("NAME='" & pe_name.Text & "'")
        If FRC.Length <= 0 Then
            pe_name.Text = ""
            pe_code.Text = ""
            Exit Sub
        Else
            RC = FRC(0)
            pe_code.Text = RC("code")
            dr.Close() : dr.Close() : cmd.CommandText = "select * from eimage where code='" & Val(pcode.Text) & "' and  pecode='" & pe_code.Text & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then
                Dim newMstream As New System.IO.MemoryStream(CType(dr.Item("image"), Byte()))
                Dim ImageFromDB As New Bitmap(newMstream)
                PictureBox1.Image = ImageFromDB
            End If

        End If
    End Sub

    Private Sub TabPage2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub c1_3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c1_3.KeyDown
        If e.KeyCode = Keys.F4 Then
            alls("c1", 3, c1_3.Text)
        End If
    End Sub

    Private Sub c1_3_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c1_3.KeyUp
        sum(3)
    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c1_3.TextChanged

    End Sub

    Private Sub c3_2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c3_2.KeyDown
        If e.KeyCode = Keys.F4 Then
            alls("c3", 2, c3_2.Text)
        End If
    End Sub

    Private Sub c3_2_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c3_2.KeyUp
        sum(2)
    End Sub

    Private Sub TextBox50_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c3_2.TextChanged

    End Sub

    Private Sub c3_9_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c3_9.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("c3", 9, c3_9.Text)
        End If
        sum(9)
    End Sub

    Private Sub TextBox43_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c3_9.TextChanged

    End Sub

    Private Sub o2_8_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o2_8.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("o2", 8, o2_8.Text)
        End If
        sum(8)
    End Sub

    Private Sub TextBox83_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o2_8.TextChanged

    End Sub

    Private Sub o3_6_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o3_6.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("o2", 6, o2_6.Text)
        End If
        sum(6)
    End Sub

    Private Sub o3_7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o3_6.TextChanged

    End Sub

    Private Sub TextBox117_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles net_n.TextChanged

    End Sub

    Private Sub c1_1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c1_1.KeyDown
        If e.KeyCode = Keys.F4 Then
            alls("c1", 1, c1_1.Text)
        End If
    End Sub

    Private Sub c1_1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c1_1.KeyUp
        sum(1)
    End Sub

    Private Sub c1_1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c1_1.TextChanged

    End Sub

    Private Sub c2_1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c2_1.KeyDown
        If e.KeyCode = Keys.F4 Then
            alls("c2", 1, c2_1.Text)
        End If

    End Sub

    Private Sub c2_1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c2_1.KeyUp
        sum(1)
    End Sub

    Private Sub c2_1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c2_1.TextChanged

    End Sub

    Private Sub c3_1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c3_1.KeyDown
        If e.KeyCode = Keys.F4 Then
            alls("c3", 1, c3_1.Text)
        End If
    End Sub

    Private Sub c3_1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c3_1.KeyUp
        sum(1)
    End Sub

    Private Sub c3_1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c3_1.TextChanged

    End Sub

    Private Sub c4_1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c4_1.KeyUp

        If e.KeyCode = Keys.F4 Then
            alls("c4", 1, c4_1.Text)
        End If
        sum(1)
    End Sub

    Private Sub c4_1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c4_1.TextChanged

    End Sub

    Private Sub o1_1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o1_1.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("o1", 1, o1_1.Text)
        End If
        sum(1)
    End Sub

    Private Sub o1_1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o1_1.TextChanged

    End Sub

    Private Sub o2_1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o2_1.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("o2", 1, o2_1.Text)
        End If
        sum(1)
    End Sub

    Private Sub o2_1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o2_1.TextChanged

    End Sub

    Private Sub o3_1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o3_1.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("o3", 1, o3_1.Text)
        End If
        sum(1)
    End Sub

    Private Sub o3_1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o3_1.TextChanged

    End Sub

    Private Sub o4_1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o4_1.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("o4", 1, o4_1.Text)
        End If
        sum(1)
    End Sub

    Private Sub o4_1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o4_1.TextChanged

    End Sub

    Private Sub insr_1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles insr_1.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("insr", 1, insr_1.Text)
        End If
        sum(1)
    End Sub

    Private Sub insr_1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles insr_1.TextChanged

    End Sub

    Private Sub drb_1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles drb_1.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("drb", 1, drb_1.Text)
        End If
        sum(1)
    End Sub

    Private Sub drb_1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles drb_1.TextChanged

    End Sub

    Private Sub st_1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles st_1.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("st", 1, st_1.Text)
        End If
        sum(1)
    End Sub

    Private Sub st_1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_1.TextChanged

    End Sub

    Private Sub c1_2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c1_2.KeyDown
        If e.KeyCode = Keys.F4 Then
            alls("c1", 2, c1_2.Text)
        End If
    End Sub

    Private Sub c1_2_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c1_2.KeyUp
        sum(2)
    End Sub

    Private Sub c1_2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c1_2.TextChanged

    End Sub

    Private Sub c1_6_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c1_6.KeyDown
        If e.KeyCode = Keys.F4 Then
            alls("c1", 6, c1_6.Text)
        End If

    End Sub

    Private Sub c1_6_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c1_6.KeyUp
        sum(6)
    End Sub

    Private Sub c1_6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c1_6.TextChanged

    End Sub

    Private Sub c1_11_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c1_11.KeyDown
        If e.KeyCode = Keys.F4 Then
            alls("c1", 11, c1_11.Text)
        End If

    End Sub

    Private Sub c1_11_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c1_11.KeyUp
        sum(11)
    End Sub

    Private Sub c1_11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c1_11.TextChanged

    End Sub

    Private Sub c1_4_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c1_4.KeyDown
        If e.KeyCode = Keys.F4 Then
            alls("c1", 4, c1_4.Text)
        End If

    End Sub

    Private Sub c1_4_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c1_4.KeyUp
        sum(4)
    End Sub

    Private Sub c1_4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c1_4.TextChanged

    End Sub

    Private Sub c1_5_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c1_5.KeyDown
        If e.KeyCode = Keys.F4 Then
            alls("c1", 5, c1_5.Text)
        End If

    End Sub

    Private Sub c1_5_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c1_5.KeyUp
        sum(5)
    End Sub

    Private Sub c1_5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c1_5.TextChanged

    End Sub

    Private Sub c1_7_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c1_7.KeyDown
        If e.KeyCode = Keys.F4 Then
            alls("c1", 7, c1_7.Text)
        End If

    End Sub

    Private Sub c1_7_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c1_7.KeyUp
        sum(7)
    End Sub

    Private Sub c1_7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c1_7.TextChanged

    End Sub

    Private Sub c1_8_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c1_8.KeyDown
        If e.KeyCode = Keys.F4 Then
            alls("c1", 8, c1_8.Text)
        End If

    End Sub

    Private Sub c1_8_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c1_8.KeyUp
        sum(8)
    End Sub

    Private Sub c1_8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c1_8.TextChanged

    End Sub

    Private Sub c1_9_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c1_9.KeyDown
        If e.KeyCode = Keys.F4 Then
            alls("c1", 9, c1_9.Text)
        End If

    End Sub

    Private Sub c1_9_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c1_9.KeyUp
        sum(9)
    End Sub

    Private Sub c1_9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c1_9.TextChanged

    End Sub

    Private Sub c1_10_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c1_10.KeyDown
        If e.KeyCode = Keys.F4 Then
            alls("c1", 10, c1_10.Text)
        End If

    End Sub

    Private Sub c1_10_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c1_10.KeyUp
        sum(10)
    End Sub

    Private Sub c1_10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c1_10.TextChanged

    End Sub

    Private Sub c1_12_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c1_12.KeyUp
        sum(12)
    End Sub

    Private Sub c1_12_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c1_12.TextChanged

    End Sub

    Private Sub c2_2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c2_2.KeyDown
        If e.KeyCode = Keys.F4 Then
            alls("c2", 2, c2_2.Text)
        End If
    End Sub

    Private Sub c2_2_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c2_2.KeyUp
        sum(2)
    End Sub

    Private Sub c2_2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c2_2.TextChanged

    End Sub

    Private Sub c2_3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c2_3.KeyDown
        If e.KeyCode = Keys.F4 Then
            alls("c2", 3, c2_3.Text)
        End If
    End Sub

    Private Sub c2_3_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c2_3.KeyUp
        sum(3)
    End Sub

    Private Sub c2_3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c2_3.TextChanged

    End Sub

    Private Sub c2_4_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c2_4.KeyDown
        If e.KeyCode = Keys.F4 Then
            alls("c2", 4, c2_4.Text)
        End If
    End Sub

    Private Sub c2_4_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c2_4.KeyUp
        sum(4)
    End Sub

    Private Sub c2_4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c2_4.TextChanged

    End Sub

    Private Sub c2_5_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c2_5.KeyDown
        If e.KeyCode = Keys.F4 Then
            alls("c2", 5, c2_5.Text)
        End If
    End Sub

    Private Sub c2_5_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c2_5.KeyUp
        sum(5)
    End Sub

    Private Sub c2_5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c2_5.TextChanged

    End Sub

    Private Sub c2_6_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c2_6.KeyDown
        If e.KeyCode = Keys.F4 Then
            alls("c2", 6, c2_6.Text)
        End If
    End Sub

    Private Sub c2_6_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c2_6.KeyUp
        sum(6)
    End Sub

    Private Sub c2_6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c2_6.TextChanged

    End Sub

    Private Sub c2_7_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c2_7.KeyDown
        If e.KeyCode = Keys.F4 Then
            alls("c2", 7, c2_7.Text)
        End If
    End Sub

    Private Sub c2_7_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c2_7.KeyUp
        sum(7)
    End Sub

    Private Sub c2_7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c2_7.TextChanged

    End Sub

    Private Sub c2_8_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c2_8.KeyDown
        If e.KeyCode = Keys.F4 Then
            alls("c2", 8, c2_8.Text)
        End If
    End Sub

    Private Sub c2_8_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c2_8.KeyUp
        sum(8)
    End Sub

    Private Sub c2_8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c2_8.TextChanged

    End Sub

    Private Sub c2_9_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c2_9.KeyDown
        If e.KeyCode = Keys.F4 Then
            alls("c2", 9, c2_9.Text)
        End If
    End Sub

    Private Sub c2_9_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c2_9.KeyUp
        sum(9)
    End Sub

    Private Sub c2_9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c2_9.TextChanged

    End Sub

    Private Sub c2_10_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c2_10.KeyDown
        If e.KeyCode = Keys.F4 Then
            alls("c2", 10, c2_10.Text)
        End If
    End Sub

    Private Sub c2_10_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c2_10.KeyUp
        sum(10)
    End Sub

    Private Sub c2_10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c2_10.TextChanged

    End Sub

    Private Sub c2_11_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c2_11.KeyDown
        If e.KeyCode = Keys.F4 Then
            alls("c2", 11, c2_11.Text)
        End If
    End Sub

    Private Sub c2_11_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c2_11.KeyUp
        sum(11)
    End Sub

    Private Sub c2_11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c2_11.TextChanged

    End Sub

    Private Sub c2_12_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c2_12.KeyDown
        If e.KeyCode = Keys.F4 Then
            alls("c2", 12, c2_12.Text)
        End If
    End Sub

    Private Sub c2_12_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c2_12.KeyUp
        sum(12)
    End Sub

    Private Sub c2_12_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c2_12.TextChanged

    End Sub

    Private Sub c3_3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c3_3.KeyDown
        If e.KeyCode = Keys.F4 Then
            alls("c3", 3, c3_3.Text)
        End If
    End Sub

    Private Sub c3_3_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c3_3.KeyUp
        sum(3)
    End Sub

    Private Sub c3_3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c3_3.TextChanged

    End Sub

    Private Sub c3_4_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c3_4.KeyDown
        If e.KeyCode = Keys.F4 Then
            alls("c3", 4, c3_4.Text)
        End If
    End Sub

    Private Sub c3_4_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c3_4.KeyUp
        sum(4)
    End Sub

    Private Sub c3_4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c3_4.TextChanged

    End Sub

    Private Sub c3_5_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c3_5.KeyDown
        If e.KeyCode = Keys.F4 Then
            alls("c3", 5, c3_5.Text)
        End If
    End Sub

    Private Sub c3_5_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c3_5.KeyUp
        sum(5)
    End Sub

    Private Sub c3_5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c3_5.TextChanged

    End Sub

    Private Sub c3_6_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c3_6.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("c3", 6, c3_6.Text)
        End If
        sum(6)
    End Sub

    Private Sub c3_6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c3_6.TextChanged

    End Sub

    Private Sub c3_7_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c3_7.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("c3", 7, c3_7.Text)
        End If
        sum(7)
    End Sub

    Private Sub c3_7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c3_7.TextChanged

    End Sub

    Private Sub c3_8_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c3_8.KeyDown

    End Sub

    Private Sub c3_8_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c3_8.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("c3", 8, c3_8.Text)
        End If
        sum(8)
    End Sub

    Private Sub c3_8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c3_8.TextChanged

    End Sub

    Private Sub c3_10_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c3_10.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("c3", 10, c3_10.Text)
        End If
        sum(10)
    End Sub

    Private Sub c3_10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c3_10.TextChanged

    End Sub

    Private Sub c3_11_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c3_11.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("c3", 11, c3_11.Text)
        End If
        sum(11)
    End Sub

    Private Sub c3_11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c3_11.TextChanged

    End Sub

    Private Sub c3_12_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c3_12.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("c3", 12, c3_12.Text)
        End If
        sum(12)
    End Sub

    Private Sub c3_12_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c3_12.TextChanged

    End Sub

    Private Sub c4_2_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c4_2.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("c4", 2, c4_2.Text)
        End If
        sum(2)
    End Sub

    Private Sub c4_2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c4_2.TextChanged

    End Sub

    Private Sub c4_3_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c4_3.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("c4", 3, c4_3.Text)
        End If
        sum(3)
    End Sub

    Private Sub c4_3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c4_3.TextChanged

    End Sub

    Private Sub c4_4_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c4_4.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("c4", 4, c4_4.Text)
        End If
        sum(4)
    End Sub

    Private Sub c4_4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c4_4.TextChanged

    End Sub

    Private Sub c4_5_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c4_5.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("c4", 5, c4_5.Text)
        End If
        sum(5)
    End Sub

    Private Sub c4_5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c4_5.TextChanged

    End Sub

    Private Sub c4_6_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c4_6.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("c4", 6, c4_6.Text)
        End If
        sum(1)
    End Sub

    Private Sub c4_6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c4_6.TextChanged

    End Sub

    Private Sub c4_7_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c4_7.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("c4", 7, c4_7.Text)
        End If
        sum(7)
    End Sub

    Private Sub c4_7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c4_7.TextChanged

    End Sub

    Private Sub c4_8_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c4_8.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("c4", 8, c4_8.Text)
        End If
        sum(8)
    End Sub

    Private Sub c4_8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c4_8.TextChanged

    End Sub

    Private Sub c4_9_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c4_9.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("c4", 9, c4_9.Text)
        End If
        sum(9)
    End Sub

    Private Sub c4_9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c4_9.TextChanged

    End Sub

    Private Sub c4_10_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c4_10.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("c4", 10, c4_10.Text)
        End If
        sum(10)
    End Sub

    Private Sub c4_10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c4_10.TextChanged

    End Sub

    Private Sub c4_11_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c4_11.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("c4", 11, c4_11.Text)
        End If
        sum(11)
    End Sub

    Private Sub c4_11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c4_11.TextChanged

    End Sub

    Private Sub c4_12_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c4_12.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("c4", 12, c4_12.Text)
        End If
        sum(12)
    End Sub

    Private Sub c4_12_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c4_12.TextChanged

    End Sub

    Private Sub o1_2_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o1_2.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("o1", 2, o1_2.Text)
        End If
        sum(2)
    End Sub

    Private Sub o1_2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o1_2.TextChanged

    End Sub

    Private Sub o1_3_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o1_3.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("o1", 3, o1_3.Text)
        End If
        sum(3)
    End Sub

    Private Sub o1_3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o1_3.TextChanged

    End Sub

    Private Sub o1_4_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o1_4.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("o1", 5, o1_5.Text)
        End If
        sum(5)
    End Sub

    Private Sub o1_4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o1_4.TextChanged

    End Sub

    Private Sub o1_5_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o1_5.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("o1", 5, o1_5.Text)
        End If
        sum(5)
    End Sub

    Private Sub o1_5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o1_5.TextChanged

    End Sub

    Private Sub o1_6_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o1_6.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("o1", 6, o1_6.Text)
        End If
        sum(6)
    End Sub

    Private Sub o1_6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o1_6.TextChanged

    End Sub

    Private Sub o1_7_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o1_7.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("o1", 7, o1_7.Text)
        End If
        sum(7)
    End Sub

    Private Sub o1_7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o1_7.TextChanged

    End Sub

    Private Sub o1_8_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o1_8.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("o1", 8, o1_8.Text)
        End If
        sum(8)
    End Sub

    Private Sub o1_8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o1_8.TextChanged

    End Sub

    Private Sub o1_9_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o1_9.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("o1", 9, o1_9.Text)
        End If
        sum(9)
    End Sub

    Private Sub o1_9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o1_9.TextChanged

    End Sub

    Private Sub o1_10_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o1_10.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("o1", 10, o1_10.Text)
        End If
        sum(10)
    End Sub

    Private Sub o1_10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o1_10.TextChanged

    End Sub

    Private Sub o1_11_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o1_11.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("o1", 11, o1_11.Text)
        End If
        sum(11)
    End Sub

    Private Sub o1_11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o1_11.TextChanged

    End Sub

    Private Sub o1_12_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o1_12.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("o1", 12, o1_12.Text)
        End If
        sum(12)
    End Sub

    Private Sub o1_12_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o1_12.TextChanged

    End Sub

    Private Sub o2_2_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o2_2.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("o2", 2, o2_2.Text)
        End If
        sum(2)
    End Sub

    Private Sub o2_2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o2_2.TextChanged

    End Sub

    Private Sub o2_3_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o2_3.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("o2", 3, o2_3.Text)
        End If
        sum(3)
    End Sub

    Private Sub o2_3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o2_3.TextChanged

    End Sub

    Private Sub o2_4_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o2_4.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("o2", 4, o2_4.Text)
        End If
        sum(4)
    End Sub

    Private Sub o2_4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o2_4.TextChanged

    End Sub

    Private Sub o2_5_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o2_5.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("o2", 5, o2_5.Text)
        End If
        sum(5)
    End Sub

    Private Sub o2_5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o2_5.TextChanged

    End Sub

    Private Sub o2_6_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o2_6.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("o2", 6, o2_6.Text)
        End If
        sum(6)
    End Sub

    Private Sub o2_6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o2_6.TextChanged

    End Sub

    Private Sub o2_7_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o2_7.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("o2", 7, o2_7.Text)
        End If
        sum(7)
    End Sub

    Private Sub o2_7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o2_7.TextChanged

    End Sub

    Private Sub o2_9_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o2_9.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("o2", 9, o2_9.Text)
        End If
        sum(9)
    End Sub

    Private Sub o2_9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o2_9.TextChanged

    End Sub

    Private Sub o2_10_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o2_10.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("o2", 10, o2_10.Text)
        End If
        sum(10)
    End Sub

    Private Sub o2_10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o2_10.TextChanged

    End Sub

    Private Sub o2_11_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o2_11.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("o2", 11, o2_11.Text)
        End If
        sum(11)
    End Sub

    Private Sub o2_11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o2_11.TextChanged

    End Sub

    Private Sub o2_12_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o2_12.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("o2", 12, o2_12.Text)
        End If
        sum(12)
    End Sub

    Private Sub o2_12_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o2_12.TextChanged

    End Sub

    Private Sub o3_2_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o3_2.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("o3", 2, o3_2.Text)
        End If
        sum(2)
    End Sub

    Private Sub o3_2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o3_2.TextChanged

    End Sub

    Private Sub o3_3_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o3_3.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("o3", 3, o3_3.Text)
        End If
        sum(3)
    End Sub

    Private Sub o3_3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o3_3.TextChanged

    End Sub

    Private Sub o3_4_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o3_4.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("o3", 4, o3_4.Text)
        End If
        sum(4)
    End Sub

    Private Sub o3_4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o3_4.TextChanged

    End Sub

    Private Sub o3_5_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o3_5.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("o3", 5, o3_5.Text)
        End If
        sum(5)
    End Sub

    Private Sub o3_5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o3_5.TextChanged

    End Sub

    Private Sub o3_7_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o3_7.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("o3", 7, o3_7.Text)
        End If
        sum(7)
    End Sub

    Private Sub o3_7_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o3_7.TextChanged

    End Sub

    Private Sub o3_9_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o3_9.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("o3", 9, o3_9.Text)
        End If
        sum(9)
    End Sub

    Private Sub o3_9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o3_9.TextChanged

    End Sub

    Private Sub o3_8_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o3_8.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("o3", 8, o3_8.Text)
        End If
        sum(8)
    End Sub

    Private Sub o3_8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o3_8.TextChanged

    End Sub

    Private Sub o3_10_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o3_10.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("o3", 10, o3_10.Text)
        End If
        sum(10)
    End Sub

    Private Sub o3_10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o3_10.TextChanged

    End Sub

    Private Sub o3_11_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o3_11.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("o3", 11, o3_11.Text)
        End If
        sum(11)
    End Sub

    Private Sub o3_11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o3_11.TextChanged

    End Sub

    Private Sub o3_12_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o3_12.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("o3", 12, o3_12.Text)
        End If
        sum(12)
    End Sub

    Private Sub o3_12_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o3_12.TextChanged

    End Sub

    Private Sub o4_2_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o4_2.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("o4", 2, o4_2.Text)
        End If
        sum(2)
    End Sub

    Private Sub o4_2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o4_2.TextChanged

    End Sub

    Private Sub o4_3_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o4_3.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("o4", 3, o4_3.Text)
        End If
        sum(3)
    End Sub

    Private Sub o4_3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o4_3.TextChanged

    End Sub

    Private Sub o4_4_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o4_4.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("o4", 4, o4_4.Text)
        End If
        sum(4)
    End Sub

    Private Sub o4_4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o4_4.TextChanged

    End Sub

    Private Sub o4_5_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o4_5.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("o4", 5, o4_5.Text)
        End If
        sum(5)
    End Sub

    Private Sub o4_5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o4_5.TextChanged

    End Sub

    Private Sub o4_6_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o4_6.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("o4", 6, o4_6.Text)
        End If
        sum(6)
    End Sub

    Private Sub o4_6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o4_6.TextChanged

    End Sub

    Private Sub o4_7_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o4_7.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("o4", 7, o4_7.Text)
        End If
        sum(7)
    End Sub

    Private Sub o4_7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o4_7.TextChanged

    End Sub

    Private Sub o4_8_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o4_8.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("o4", 8, o4_8.Text)
        End If
        sum(8)
    End Sub

    Private Sub o4_8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o4_8.TextChanged

    End Sub

    Private Sub o4_9_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o4_9.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("o4", 9, o4_9.Text)
        End If
        sum(9)
    End Sub

    Private Sub o4_9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o4_9.TextChanged

    End Sub

    Private Sub o4_10_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o4_10.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("o4", 10, o4_10.Text)
        End If
        sum(10)
    End Sub

    Private Sub o4_10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o4_10.TextChanged

    End Sub

    Private Sub o4_11_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o4_11.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("o4", 11, o4_11.Text)
        End If
        sum(11)
    End Sub

    Private Sub o4_11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o4_11.TextChanged

    End Sub

    Private Sub o4_12_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o4_12.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("o4", 12, o4_12.Text)
        End If
        sum(12)
    End Sub

    Private Sub o4_12_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o4_12.TextChanged

    End Sub

    Private Sub insr_2_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles insr_2.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("insr", 2, insr_2.Text)
        End If
        sum(2)
    End Sub

    Private Sub insr_2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles insr_2.TextChanged

    End Sub

    Private Sub insr_3_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles insr_3.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("insr", 3, insr_3.Text)
        End If
        sum(3)
    End Sub

    Private Sub insr_3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles insr_3.TextChanged

    End Sub

    Private Sub insr_4_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles insr_4.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("insr", 4, insr_4.Text)
        End If
        sum(4)
    End Sub

    Private Sub insr_4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles insr_4.TextChanged

    End Sub

    Private Sub insr_5_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles insr_5.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("insr", 5, insr_5.Text)
        End If
        sum(5)
    End Sub

    Private Sub insr_5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles insr_5.TextChanged

    End Sub

    Private Sub insr_6_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles insr_6.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("insr", 6, insr_6.Text)
        End If
        sum(6)
    End Sub

    Private Sub insr_6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles insr_6.TextChanged

    End Sub

    Private Sub insr_7_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles insr_7.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("insr", 7, insr_7.Text)
        End If
        sum(7)
    End Sub

    Private Sub insr_7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles insr_7.TextChanged

    End Sub

    Private Sub insr_8_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles insr_8.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("insr", 8, insr_8.Text)
        End If
        sum(8)
    End Sub

    Private Sub insr_8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles insr_8.TextChanged

    End Sub

    Private Sub insr_9_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles insr_9.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("insr", 9, insr_9.Text)
        End If
        sum(9)
    End Sub

    Private Sub insr_9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles insr_9.TextChanged

    End Sub

    Private Sub insr_10_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles insr_10.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("insr", 10, insr_10.Text)
        End If
        sum(10)
    End Sub

    Private Sub insr_10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles insr_10.TextChanged

    End Sub

    Private Sub insr_11_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles insr_11.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("insr", 11, insr_11.Text)
        End If
        sum(11)
    End Sub

    Private Sub insr_11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles insr_11.TextChanged

    End Sub

    Private Sub insr_12_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles insr_12.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("insr", 12, insr_12.Text)
        End If
        sum(12)
    End Sub

    Private Sub insr_12_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles insr_12.TextChanged

    End Sub

    Private Sub drb_2_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles drb_2.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("drb", 2, drb_2.Text)
        End If
        sum(2)
    End Sub

    Private Sub drb_2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles drb_2.TextChanged

    End Sub

    Private Sub drb_3_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles drb_3.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("drb", 3, drb_3.Text)
        End If
        sum(3)
    End Sub

    Private Sub drb_3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles drb_3.TextChanged

    End Sub

    Private Sub drb_4_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles drb_4.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("drb", 4, drb_4.Text)
        End If
        sum(4)
    End Sub

    Private Sub drb_4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles drb_4.TextChanged

    End Sub

    Private Sub drb_5_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles drb_5.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("drb", 5, drb_5.Text)
        End If
        sum(5)
    End Sub

    Private Sub drb_5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles drb_5.TextChanged

    End Sub

    Private Sub drb_6_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles drb_6.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("drb", 6, drb_6.Text)
        End If
        sum(6)
    End Sub

    Private Sub drb_6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles drb_6.TextChanged

    End Sub

    Private Sub drb_7_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles drb_7.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("drb", 7, drb_7.Text)
        End If
        sum(7)
    End Sub

    Private Sub drb_7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles drb_7.TextChanged

    End Sub

    Private Sub drb_8_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles drb_8.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("drb", 8, drb_8.Text)
        End If
        sum(8)
    End Sub

    Private Sub drb_8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles drb_8.TextChanged

    End Sub

    Private Sub drb_9_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles drb_9.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("drb", 9, drb_9.Text)
        End If
        sum(9)
    End Sub

    Private Sub drb_9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles drb_9.TextChanged

    End Sub

    Private Sub drb_10_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles drb_10.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("drb", 10, drb_10.Text)
        End If
        sum(10)
    End Sub

    Private Sub drb_10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles drb_10.TextChanged

    End Sub

    Private Sub drb_11_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles drb_11.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("drb", 11, drb_11.Text)
        End If
        sum(11)
    End Sub

    Private Sub drb_11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles drb_11.TextChanged

    End Sub

    Private Sub drb_12_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles drb_12.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("drb", 12, drb_12.Text)
        End If
        sum(12)
    End Sub

    Private Sub drb_12_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles drb_12.TextChanged

    End Sub

    Private Sub st_2_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles st_2.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("st", 2, st_2.Text)
        End If
        sum(2)
    End Sub

    Private Sub st_2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_2.TextChanged

    End Sub

    Private Sub st_3_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles st_3.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("st", 3, st_3.Text)
        End If
        sum(3)
    End Sub

    Private Sub st_3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_3.TextChanged

    End Sub

    Private Sub st_4_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles st_4.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("st", 4, st_4.Text)
        End If
        sum(4)
    End Sub

    Private Sub st_4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_4.TextChanged

    End Sub

    Private Sub st_5_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles st_5.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("st", 5, st_5.Text)
        End If
        sum(5)
    End Sub

    Private Sub st_5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_5.TextChanged

    End Sub

    Private Sub st_6_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles st_6.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("st", 6, st_6.Text)
        End If
        sum(6)
    End Sub

    Private Sub st_6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_6.TextChanged

    End Sub

    Private Sub st_7_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles st_7.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("st", 7, st_7.Text)
        End If
        sum(7)
    End Sub

    Private Sub st_7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_7.TextChanged

    End Sub

    Private Sub st_8_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles st_8.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("st", 8, st_8.Text)
        End If
        sum(1)
    End Sub

    Private Sub st_8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_8.TextChanged

    End Sub

    Private Sub st_9_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles st_9.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("st", 9, st_9.Text)
        End If
        sum(9)
    End Sub

    Private Sub st_9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_9.TextChanged

    End Sub

    Private Sub st_10_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles st_10.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("st", 10, st_10.Text)
        End If
        sum(10)
    End Sub

    Private Sub st_10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_10.TextChanged

    End Sub

    Private Sub st_11_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles st_11.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("st", 11, st_11.Text)
        End If
        sum(11)
    End Sub

    Private Sub st_11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_11.TextChanged

    End Sub

    Private Sub st_12_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles st_12.KeyUp
        If e.KeyCode = Keys.F4 Then
            alls("st", 12, st_12.Text)
        End If
        sum(12)
    End Sub

    Private Sub st_12_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_12.TextChanged

    End Sub

    Private Sub net_1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles net_1.TextChanged

    End Sub

    Private Sub GlassButton36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton36.Click
        dr.Close()
        cmd.CommandText = "select max(CODE) from eemp "
        dr = cmd.ExecuteReader
        dr.Read()
        If IsDBNull(dr(0)) = False Then pcode.Text = dr(0) + 1 Else pcode.Text = 1
        fcode.Text = 0
        pname.Text = ""
        alls("0", 0, "0")
    End Sub

    Private Sub GlassButton35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton35.Click
        'If SV = 0 Then
        '    MsgBox("·Ì”  ·œÌﬂ «·’·«ÕÌ…")
        '    dr.Close()
        '    cmd.CommandText = "insert into llog (usr,note,date1,time1,gr) values ('" & suser & "','„Õ«Ê·…  Œ“Ì‰ »Ì«‰«  „” Œœ„ „⁄ ⁄œ„ «„ ·«ﬂ ’·«ÕÌ…','" & ChangeFormat(Now.Date) & "','" & Now.Hour & ":" & Now.Minute & ":" & Now.Second & "','„Õ«Ê·… «Œ —«ﬁ')"
        '    cmd.ExecuteNonQuery()
        '    Exit Sub
        'End If
        'If edu_name.Text = "" Or IsNumeric(edu_code.Text) = False Then MsgBox("«·—Ã«¡ «Œ Ì«— «·„” ÊÏ «· ⁄·Ì„Ï") : Exit Sub
        'If jop_name.Text = "" Or IsNumeric(jop_code.Text) = False Then MsgBox("«·—Ã«¡ «Œ Ì«— «·ÊŸÌ›…") : Exit Sub
        'If weekend.Text = "" Or IsNumeric(insr_code.Text) = False Then MsgBox("«·—Ã«¡ «Œ Ì«— ‰Ê⁄ «· √„Ì‰") : Exit Sub
        'If group_name.Text = "" Or IsNumeric(group_code.Text) = False Then MsgBox("«·—Ã«¡ «Œ Ì«— «·„Ã„Ê⁄…") : Exit Sub
        '******************************************************************************************************
        '*******************************************save patien data************************************************
        If pname.Text = "" Or IsNumeric(pcode.Text) = False Then MsgBox("«·—Ã«¡ ﬂ «»… «”„ «·Õ«·…") : Exit Sub
        dr.Close()
        cmd.CommandText = "select * from eemp where code='" & pcode.Text & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            Dim x As String
            'If ED = 0 Then
            '    MsgBox("·Ì”  ·œÌﬂ «·’·«ÕÌ…")
            '    dr.Close()
            '    cmd.CommandText = "insert into llog (usr,note,date1,time1,gr) values ('" & suser & "','„Õ«Ê·…  ⁄œÌ· «Ì’«· „⁄ ⁄œ„ «„ ·«ﬂ ’·«ÕÌ…','" & ChangeFormat(Now.Date) & "','" & Now.Hour & ":" & Now.Minute & ":" & Now.Second & "','„Õ«Ê·… «Œ —«ﬁ')"
            '    cmd.ExecuteNonQuery()
            '    Exit Sub
            'End If
            x = MsgBox("Â·  —Ìœ  ⁄œÌ· »Ì«‰«  «·„” Œœ„ ø", MsgBoxStyle.YesNo)
            dr.Close()
            cmd.CommandText = "delete from eemp where code='" & pcode.Text & "'"
            cmd.ExecuteNonQuery()
        Else
            pname.AutoCompleteCustomSource.Add(pname.Text)
            PNAME1.AutoCompleteCustomSource.Add(pname.Text)
            dr.Close()
            dr1.Close()

            cmd1.CommandText = "INSERT INTO [dbo].[eemp_ms]  ([ms_name] ,[ms_code],emp_code,mk) select name,code,99999,0 from ems"
            cmd1.ExecuteNonQuery()
            cmd1.CommandText = "update eemp_ms set emp_code='" & pcode.Text & "',emp_name='" & pname.Text & "' where emp_code=99999"
            cmd1.ExecuteNonQuery()

        End If
        dr.Close()
        cmd.CommandText = "SELECT * FROM EEIMAGE WHERE CODE='" & pcode.Text & "'"
        dr = cmd.ExecuteReader
        If dr.HasRows = False Then
            dr.Close()
            cmd.CommandText = "insert into EEIMAGE (code) values ('" & pcode.Text & "')"
            cmd.ExecuteNonQuery()
        End If

        dr.Close()

        cmd.CommandText = "INSERT INTO eemp ([code],[name],[inh],[outm],[outh],[inm],[emp_date],[id],[mobile],[jop_name],[insr_name],[shift],[mon_day],[birth_day],[c1_n],[c1_1],[c1_2],[c1_3],[c1_4],[c1_5],[c1_6],[c1_7],[c1_8],[c1_9],[c1_10],[c1_11],[c1_12],[c2_n],[c2_1],[c2_2],[c2_3],[c2_4],[c2_5],[c2_6],[c2_7],[c2_8],[c2_9],[c2_10],[c2_11],[c2_12],[c3_n],[c3_1],[c3_2],[c3_3],[c3_4],[c3_5],[c3_6],[c3_7],[c3_8],[c3_9],[c3_10],[c3_11],[c3_12],[c4_n],[c4_1],[c4_2],[c4_3],[c4_4],[c4_5],[c4_6],[c4_7],[c4_8],[c4_9],[c4_10],[c4_11],[c4_12],[o1_n],[o1_1],[o1_2],[o1_3],[o1_4],[o1_5],[o1_6],[o1_7],[o1_8],[o1_9],[o1_10],[o1_11],[o1_12],[o2_n],[o2_1],[o2_2],[o2_3],[o2_4],[o2_5],[o2_6],[o2_7],[o2_8],[o2_9],[o2_10],[o2_11],[o2_12],[o3_n],[o3_1],[o3_2],[o3_3],[o3_4],[o3_5],[o3_6],[o3_7],[o3_8],[o3_9],[o3_10],[o3_11],[o3_12],[o4_n],[o4_1],[o4_2],[o4_3],[o4_4],[o4_5],[o4_6],[o4_7],[o4_8],[o4_9],[o4_10],[o4_11],[o4_12],[insr_n],[insr_1],[insr_2],[insr_3],[insr_4],[insr_5],[insr_6],[insr_7],[insr_8],[insr_9],[insr_10],[insr_11],[insr_12],[drb_n],[drb_1],[drb_2],[drb_3],[drb_4],[drb_5],[drb_6],[drb_7],[drb_8],[drb_9],[drb_10],[drb_11],[drb_12],[net_n],[net_1],[net_2],[net_3],[net_4],[net_5],[net_6],[net_7],[net_8],[net_9],[net_10],[net_11],[net_12],[edu_name],[gr_name],[st_n],[st_1],[st_2],[st_3],[st_4],[st_5],[st_6],[st_7],[st_8],[st_9],[st_10],[st_11],[st_12],[email],[regl],[address],[arm],[mstatu],[stat_name],[sal],[tabs],[rabs],[rabsu],[weekend],[branch_name],[TM_NAME],[mang_name],[fcode],[edutype_name],[esal],[jdate],[mdate],[es],[ew],[er],[cp],[ce],[cw],[cc],[cs],[ct],page,sday,shour,emp1,emp2,pasw,srun,OBOY,DOC,DEMAIL,bran,[o1_1S],[o1_2S],[o1_3S],[o1_4S],[o1_5S],[o1_6S],[o1_7S],[o1_8S],[o1_9S],[o1_10S],[o1_11S],[o1_12S],[o3_1S],[o3_2S],[o3_3S],[o3_4S],[o3_5S],[o3_6S],[o3_7S],[o3_8S],[o3_9S],[o3_10S],[o3_11S],[o3_12S]) VALUES  ('" & pcode.Text & "' ,'" & pname.Text & "','" & Val(inh.Text) & "','" & Val(outm.Text) & "','" & Val(outh.Text) & "','" & Val(inm.Text) & "','" & ChangeFormat(emp_date.Value) & "' ,'" & id.Text & "','" & mobile.Text & "'  ,'" & jop_name.Text & "' ,'" & weekend.Text & "' ,'" & Val(shift.Text) & "','" & Val(mon_day.Text) & "' ,'" & ChangeFormat(birth_day.Value) & "','" & c1_n.Text & "','" & Val(c1_1.Text) & "','" & Val(c1_2.Text) & "','" & Val(c1_3.Text) & "','" & Val(c1_4.Text) & "','" & Val(c1_5.Text) & "','" & Val(c1_6.Text) & "','" & Val(c1_7.Text) & "','" & Val(c1_8.Text) & "','" & Val(c1_9.Text) & "','" & Val(c1_10.Text) & "','" & Val(c1_11.Text) & "','" & Val(c1_12.Text) & "','" & c2_n.Text & "','" & Val(c2_1.Text) & "','" & Val(c2_2.Text) & "','" & Val(c2_3.Text) & "','" & Val(c2_4.Text) & "','" & Val(c2_5.Text) & "','" & Val(c2_6.Text) & "','" & Val(c2_7.Text) & "','" & Val(c2_8.Text) & "','" & Val(c2_9.Text) & "','" & Val(c2_10.Text) & "','" & Val(c2_11.Text) & "','" & Val(c2_12.Text) & "','" & c3_n.Text & "','" & Val(c3_1.Text) & "','" & Val(c3_2.Text) & "','" & Val(c3_3.Text) & "','" & Val(c3_4.Text) & "','" & Val(c3_5.Text) & "','" & Val(c3_6.Text) & "','" & Val(c3_7.Text) & "','" & Val(c3_8.Text) & "','" & Val(c3_9.Text) & "','" & Val(c3_10.Text) & "','" & Val(c3_11.Text) & "','" & Val(c3_12.Text) & "','" & c4_n.Text & "','" & Val(c4_1.Text) & "','" & Val(c4_2.Text) & "','" & Val(c4_3.Text) & "','" & Val(c4_4.Text) & "','" & Val(c4_5.Text) & "','" & Val(c4_6.Text) & "','" & Val(c4_7.Text) & "','" & Val(c4_8.Text) & "','" & Val(c4_9.Text) & "','" & Val(c4_10.Text) & "','" & Val(c4_11.Text) & "','" & Val(c4_12.Text) & "','" & o1_n.Text & "','" & Val(o1_1.Text) & "','" & Val(o1_2.Text) & "','" & Val(o1_3.Text) & "','" & Val(o1_4.Text) & "','" & Val(o1_5.Text) & "','" & Val(o1_6.Text) & "','" & Val(o1_7.Text) & "','" & Val(o1_8.Text) & "','" & Val(o1_9.Text) & "','" & Val(o1_10.Text) & "','" & Val(o1_11.Text) & "','" & Val(o1_12.Text) & "','" & o2_n.Text & "','" & Val(o2_1.Text) & "','" & Val(o2_2.Text) & "','" & Val(o2_3.Text) & "','" & Val(o2_4.Text) & "','" & Val(o2_5.Text) & "','" & Val(o2_6.Text) & "','" & Val(o2_7.Text) & "','" & Val(o2_8.Text) & "','" & Val(o2_9.Text) & "','" & Val(o2_10.Text) & "','" & Val(o2_11.Text) & "','" & Val(o2_12.Text) & "','" & o3_n.Text & "','" & Val(o3_1.Text) & "','" & Val(o3_2.Text) & "','" & Val(o3_3.Text) & "','" & Val(o3_4.Text) & "','" & Val(o3_5.Text) & "','" & Val(o3_6.Text) & "','" & Val(o3_7.Text) & "','" & Val(o3_8.Text) & "','" & Val(o3_9.Text) & "','" & Val(o3_10.Text) & "','" & Val(o3_11.Text) & "','" & Val(o3_12.Text) & "','" & o4_n.Text & "','" & Val(o4_1.Text) & "','" & Val(o4_2.Text) & "','" & Val(o4_3.Text) & "','" & Val(o4_4.Text) & "','" & Val(o4_5.Text) & "','" & Val(o4_6.Text) & "','" & Val(o4_7.Text) & "','" & Val(o4_8.Text) & "','" & Val(o4_9.Text) & "','" & Val(o4_10.Text) & "','" & Val(o4_11.Text) & "','" & Val(o4_12.Text) & "','" & insr_n.Text & "','" & Val(insr_1.Text) & "','" & Val(insr_2.Text) & "','" & Val(insr_3.Text) & "','" & Val(insr_4.Text) & "','" & Val(insr_5.Text) & "','" & Val(insr_6.Text) & "','" & Val(insr_7.Text) & "','" & Val(insr_8.Text) & "','" & Val(insr_9.Text) & "','" & Val(insr_10.Text) & "','" & Val(insr_11.Text) & "','" & Val(insr_12.Text) & "','" & drb_n.Text & "','" & Val(drb_1.Text) & "','" & Val(drb_2.Text) & "','" & Val(drb_3.Text) & "','" & Val(drb_4.Text) & "','" & Val(drb_5.Text) & "','" & Val(drb_6.Text) & "','" & Val(drb_7.Text) & "','" & Val(drb_8.Text) & "','" & Val(drb_9.Text) & "','" & Val(drb_10.Text) & "','" & Val(drb_11.Text) & "','" & Val(drb_12.Text) & "','" & net_n.Text & "','" & Val(net_1.Text) & "','" & Val(net_2.Text) & "','" & Val(net_3.Text) & "','" & Val(net_4.Text) & "','" & Val(net_5.Text) & "','" & Val(net_6.Text) & "','" & Val(net_7.Text) & "','" & Val(net_8.Text) & "','" & Val(net_9.Text) & "','" & Val(net_10.Text) & "','" & Val(net_11.Text) & "','" & Val(net_12.Text) & "','" & edu_name.Text & "','" & group_name.Text & "' ,'" & st_n.Text & "','" & Val(st_1.Text) & "','" & Val(st_2.Text) & "','" & Val(st_3.Text) & "','" & Val(st_4.Text) & "','" & Val(st_5.Text) & "','" & Val(st_6.Text) & "','" & Val(st_7.Text) & "','" & Val(st_8.Text) & "','" & Val(st_9.Text) & "','" & Val(st_10.Text) & "','" & Val(st_11.Text) & "','" & Val(st_12.Text) & "','" & email.Text & "','" & regl.Text & "','" & address.Text & "','" & arm.Text & "','" & mstatu.Text & "','" & stat_name.Text & "','" & sal.Text & "','" & tabs.Text & "','" & rabs.Text & "','" & rabsu.Text & "','" & weekend.Text & "','" & branch_name.Text & "','" & TM_NAME.Text & "','" & mang_name.Text & "','" & fcode.Text & "','" & edutype_name.Text & "','" & esal.Text & "','" & jdate.Value & "','" & mdate.Value & "','" & Val(es.CheckState) & "','" & Val(ew.CheckState) & "','" & Val(er.CheckState) & "','" & Val(cp.CheckState) & "','" & Val(ce.CheckState) & "','" & Val(cw.CheckState) & "','" & Val(cc.CheckState) & "','" & Val(cs.CheckState) & "','" & Val(ct.CheckState) & "','" & Val(page.Text) & "','" & Val(sday.Text) & "','" & Val(shour.Text) & "','" & Val(emp1.Text) & "','" & Val(emp2.Text) & "','" & TextBox12.Text & "','" & Val(RUN.CheckState) & "','" & Val(OBOY.CheckState) & "','" & Val(DOCTOR.CheckState) & "','" & DEMAIL.Text & "','" & RRVV & "','" & Val(o1_1s.Text) & "','" & Val(o1_2s.Text) & "','" & Val(o1_3s.Text) & "','" & Val(o1_4s.Text) & "','" & Val(o1_5s.Text) & "','" & Val(o1_6s.Text) & "','" & Val(O1_7s.Text) & "','" & Val(o1_8s.Text) & "','" & Val(o1_9s.Text) & "','" & Val(o1_10s.Text) & "','" & Val(o1_11s.Text) & "','" & Val(o1_12s.Text) & "','" & Val(o3_1s.Text) & "','" & Val(o3_2s.Text) & "','" & Val(o3_3s.Text) & "','" & Val(o3_4s.Text) & "','" & Val(o3_5s.Text) & "','" & Val(o3_6s.Text) & "','" & Val(o3_7s.Text) & "','" & Val(o3_8s.Text) & "','" & Val(o3_9s.Text) & "','" & Val(o3_10s.Text) & "','" & Val(o3_11s.Text) & "','" & Val(o3_12s.Text) & "')"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "update ein  set shour='" & Val(shour.Text) & "',sday='" & Val(sday.Text) & "',fcode='" & Val(fcode.Text) & "' where code='" & Val(pcode.Text) & "'"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "INSERT INTO [dbo].[emp_TD]  ([TD_name] ,[TD_code],emp_code) select name,code,99999 from eTD"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "update emp_TD set emp_code='" & pcode.Text & "',emp_name='" & pname.Text & "' where emp_code=99999"
        cmd.ExecuteNonQuery()
        MsgBox(" „  «·⁄„·Ì… »‰Ã«Õ", MsgBoxStyle.Information)
        'GlassButton36_Click(GlassButton36, e)

    End Sub

    Private Sub brith_date_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles birth_day.ValueChanged
        If birth_day.Focused = False Then Exit Sub
        Dim d As Date = Now
        page.Text = d.Year - birth_day.Value.Year
    End Sub

    Private Sub GlassButton34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton34.Click
        'If DEL = 0 Then
        '    MsgBox("·Ì”  ·œÌﬂ «·’·«ÕÌ…")
        '    dr.Close()
        '    cmd.CommandText = "insert into llog (usr,note,date1,time1,gr) values ('" & suser & "','„Õ«Ê·… Õ–›  «·„” Œœ„ " & pname.Text & " „⁄ ⁄œ„ «„ ·«ﬂ ’·«ÕÌ…','" & ChangeFormat(Now.Date) & "','" & Now.Hour & ":" & Now.Minute & ":" & Now.Second & "','„Õ«Ê·… «Œ —«ﬁ')"
        '    cmd.ExecuteNonQuery()
        '    Exit Sub
        'End If

        If pname.Text = "" Then MsgBox("«·—Ã«¡ ﬂ «»… «”„ «·Õ«·…") : Exit Sub
        dr.Close()
        cmd.CommandText = "select * from eemp where  name='" & pname.Text & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            Dim x As String
            x = MsgBox("Â·  —Ìœ Õ–›  «·«Ì’«· ø", MsgBoxStyle.YesNo)
            If x = vbNo Then Exit Sub
            dr.Close()
            cmd.CommandText = "delete from eemp where name='" & pname.Text & "'"
            cmd.ExecuteNonQuery()
            'cmd.CommandText = "insert into llog (usr,note,date1,time1,gr) values ('" & suser & "','   „  ⁄„·Ì… Õ–› «·„” Œœ„ " & pname.Text & " »‰Ã«Õ','" & ChangeFormat(Now.Date) & "','" & Now.Hour & ":" & Now.Minute & ":" & Now.Second & "','⁄„·Ì… ‰«ÃÕ…')"
            'cmd.ExecuteNonQuery()

            GlassButton36_Click(GlassButton36, e)
        Else
            MsgBox("Â–« «·«Ì’«· €Ì— „”Ã·")

        End If
    End Sub

    Private Sub pname_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles pname.GotFocus
        flng("AR")
    End Sub


    Private Sub pname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles pname.KeyDown
        On Error Resume Next
        yy = ""
        If e.KeyCode = Keys.Enter Then
            '' ''If empa = 0 Then
            '' ''    Dim x As String = InputBox("«—Ã«¡ «œŒ«· ﬂ·„… «·„—Ê—")
            '' ''    yy = " and pasw='" & x & "'"
            '' ''End If
            dr.Close()
            cmd.CommandText = "select * from eemp where name='" & pname.Text & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then
                pcode.Text = nulls(dr("code"))

                FEMP()
            End If
        Else
            If pname.Text = "" Then Exit Sub
            cmdeemp.Connection = CN
            cmdeemp.CommandType = CommandType.Text
            cmdeemp.CommandText = "select * from eemp WHERE name LIKE '%" & pname.Text & "%'"
            adeemp.SelectCommand = cmdeemp
            adeemp.Fill(DBS, "eemp")
            eemp = DBS.Tables("eemp")
            DBS.Tables("eemp").Clear()
            adeemp.Fill(DBS, "eemp")
            eemp = DBS.Tables("eemp")
            brpd.DataSource = eemp
            d1 = 1
            Dim v As Integer = 0
            While Not v = brpd.Columns.Count
                brpd.Columns(v).Visible = False
                v = v + 1
            End While
            brpd.Columns("NAME").Visible = True
            brpd.Columns("NAME").HeaderText = "«·„ÊŸ›"
            brpd.Columns("NAME").Width = 300
        End If
    End Sub
    Public Sub FEMP()
        On Error Resume Next
        IPX.Image = Nothing
        dr.Close()
        cmd.CommandText = "select * from eemp where CODE='" & pcode.Text & "'" & yy
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            PNAME1.Text = dr("NAME")
            CODE1.Text = dr("CODE")
            TextBox12.Text = nulls(dr("pasw"))
            emp2.Text = nulls(dr("emp2"))
            emp1.Text = nulls(dr("emp1"))
            page.Text = nulls(dr("page"))
            pcode.Text = nulls(dr("code"))
            sday.Text = nulls(dr("sday"))
            sday1.Text = nulls(dr("sday"))
            shour.Text = nulls(dr("shour"))
            shour1.Text = nulls(dr("shour"))
            pname.Text = nulls(dr("name"))
            inh.Text = nulls(dr("inh"))
            outm.Text = nulls(dr("outm"))
            outh.Text = nulls(dr("outh"))
            inm.Text = nulls(dr("inm"))
            emp_date.Value = nulls(dr("emp_date"))
            id.Text = nulls(dr("id"))
            mobile.Text = nulls(dr("mobile"))
            jop_name.Text = nulls(dr("jop_name"))
            weekend.Text = nulls(dr("insr_name"))
            shift.Text = nulls(dr("shift"))
            mon_day.Text = nulls(dr("mon_day"))
            birth_day.Text = nulls(dr("birth_day"))
            'c1_n.Text = nulls(dr("c1_n"))
            c1_1.Text = nulls(dr("c1_1"))
            c1_2.Text = nulls(dr("c1_2"))
            c1_3.Text = nulls(dr("c1_3"))
            c1_4.Text = nulls(dr("c1_4"))
            c1_5.Text = nulls(dr("c1_5"))
            c1_6.Text = nulls(dr("c1_6"))
            c1_7.Text = nulls(dr("c1_7"))
            c1_8.Text = nulls(dr("c1_8"))
            c1_9.Text = nulls(dr("c1_9"))
            c1_10.Text = nulls(dr("c1_10"))
            c1_11.Text = nulls(dr("c1_11"))
            c1_12.Text = nulls(dr("c1_12"))
            'c2_n.Text = nulls(dr("c2_n"))
            c2_1.Text = nulls(dr("c2_1"))
            c2_2.Text = nulls(dr("c2_2"))
            c2_3.Text = nulls(dr("c2_3"))
            c2_4.Text = nulls(dr("c2_4"))
            c2_5.Text = nulls(dr("c2_5"))
            c2_6.Text = nulls(dr("c2_6"))
            c2_7.Text = nulls(dr("c2_7"))
            c2_8.Text = nulls(dr("c2_8"))
            c2_9.Text = nulls(dr("c2_9"))
            c2_10.Text = nulls(dr("c2_10"))
            c2_11.Text = nulls(dr("c2_11"))
            c2_12.Text = nulls(dr("c2_12"))
            'c3_n.Text = nulls(dr("c3_n"))
            c3_1.Text = nulls(dr("c3_1"))
            c3_2.Text = nulls(dr("c3_2"))
            c3_3.Text = nulls(dr("c3_3"))
            c3_4.Text = nulls(dr("c3_4"))
            c3_5.Text = nulls(dr("c3_5"))
            c3_6.Text = nulls(dr("c3_6"))
            c3_7.Text = nulls(dr("c3_7"))
            c3_8.Text = nulls(dr("c3_8"))
            c3_9.Text = nulls(dr("c3_9"))
            c3_10.Text = nulls(dr("c3_10"))
            c3_11.Text = nulls(dr("c3_11"))
            c3_12.Text = nulls(dr("c3_12"))
            'c4_n.Text = nulls(dr("c4_n"))
            c4_1.Text = nulls(dr("c4_1"))
            c4_2.Text = nulls(dr("c4_2"))
            c4_3.Text = nulls(dr("c4_3"))
            c4_4.Text = nulls(dr("c4_4"))
            c4_5.Text = nulls(dr("c4_5"))
            c4_6.Text = nulls(dr("c4_6"))
            c4_7.Text = nulls(dr("c4_7"))
            c4_8.Text = nulls(dr("c4_8"))
            c4_9.Text = nulls(dr("c4_9"))
            c4_10.Text = nulls(dr("c4_10"))
            c4_11.Text = nulls(dr("c4_11"))
            c4_12.Text = nulls(dr("c4_12"))
            'o1_n.Text = nulls(dr("o1_n"))
            o1_1.Text = nulls(dr("o1_1"))
            o1_2.Text = nulls(dr("o1_2"))
            o1_3.Text = nulls(dr("o1_3"))
            o1_4.Text = nulls(dr("o1_4"))
            o1_5.Text = nulls(dr("o1_5"))
            o1_6.Text = nulls(dr("o1_6"))
            o1_7.Text = nulls(dr("o1_7"))
            o1_8.Text = nulls(dr("o1_8"))
            o1_9.Text = nulls(dr("o1_9"))
            o1_10.Text = nulls(dr("o1_10"))
            o1_11.Text = nulls(dr("o1_11"))
            o1_12.Text = nulls(dr("o1_12"))
            o1_1s.Text = nulls(dr("o1_1S"))
            o1_2s.Text = nulls(dr("o1_2S"))
            o1_3s.Text = nulls(dr("o1_3S"))
            o1_4s.Text = nulls(dr("o1_4S"))
            o1_5s.Text = nulls(dr("o1_5"))
            o1_6s.Text = nulls(dr("o1_6S"))
            O1_7s.Text = nulls(dr("o1_7S"))
            o1_8s.Text = nulls(dr("o1_8S"))
            o1_9s.Text = nulls(dr("o1_9S"))
            o1_10s.Text = nulls(dr("o1_10S"))
            o1_11s.Text = nulls(dr("o1_11S"))
            o1_12s.Text = nulls(dr("o1_12S"))
            'o2_n.Text = nulls(dr("o2_n"))
            o2_1.Text = nulls(dr("o2_1"))
            o2_2.Text = nulls(dr("o2_2"))
            o2_3.Text = nulls(dr("o2_3"))
            o2_4.Text = nulls(dr("o2_4"))
            o2_5.Text = nulls(dr("o2_5"))
            o2_6.Text = nulls(dr("o2_6"))
            o2_7.Text = nulls(dr("o2_7"))
            o2_8.Text = nulls(dr("o2_8"))
            o2_9.Text = nulls(dr("o2_9"))
            o2_10.Text = nulls(dr("o2_10"))
            o2_11.Text = nulls(dr("o2_11"))
            o2_12.Text = nulls(dr("o2_12"))
            'o3_n.Text = nulls(dr("o3_n"))
            o3_1.Text = nulls(dr("o3_1"))
            o3_2.Text = nulls(dr("o3_2"))
            o3_3.Text = nulls(dr("o3_3"))
            o3_4.Text = nulls(dr("o3_4"))
            o3_5.Text = nulls(dr("o3_5"))
            o3_6.Text = nulls(dr("o3_6"))
            o3_7.Text = nulls(dr("o3_7"))
            o3_8.Text = nulls(dr("o3_8"))
            o3_9.Text = nulls(dr("o3_9"))
            o3_10.Text = nulls(dr("o3_10"))
            o3_11.Text = nulls(dr("o3_11"))
            o3_12.Text = nulls(dr("o3_12"))
            o3_1s.Text = nulls(dr("o3_1S"))
            o3_2s.Text = nulls(dr("o3_2S"))
            o3_3s.Text = nulls(dr("o3_3S"))
            o3_4s.Text = nulls(dr("o3_4S"))
            o3_5s.Text = nulls(dr("o3_5S"))
            o3_6s.Text = nulls(dr("o3_6S"))
            o3_7s.Text = nulls(dr("o3_7S"))
            o3_8s.Text = nulls(dr("o3_8S"))
            o3_9s.Text = nulls(dr("o3_9S"))
            o3_10s.Text = nulls(dr("o3_10S"))
            o3_11s.Text = nulls(dr("o3_11S"))
            o3_12s.Text = nulls(dr("o3_12S"))
            'o4_n.Text = nulls(dr("o4_n"))
            o4_1.Text = nulls(dr("o4_1"))
            o4_2.Text = nulls(dr("o4_2"))
            o4_3.Text = nulls(dr("o4_3"))
            o4_4.Text = nulls(dr("o4_4"))
            o4_5.Text = nulls(dr("o4_5"))
            o4_6.Text = nulls(dr("o4_6"))
            o4_7.Text = nulls(dr("o4_7"))
            o4_8.Text = nulls(dr("o4_8"))
            o4_9.Text = nulls(dr("o4_9"))
            o4_10.Text = nulls(dr("o4_10"))
            o4_11.Text = nulls(dr("o4_11"))
            o4_12.Text = nulls(dr("o4_12"))
            ' insr_n.Text = nulls(dr("insr_n"))
            insr_1.Text = nulls(dr("insr_1"))
            insr_2.Text = nulls(dr("insr_2"))
            insr_3.Text = nulls(dr("insr_3"))
            insr_4.Text = nulls(dr("insr_4"))
            insr_5.Text = nulls(dr("insr_5"))
            insr_6.Text = nulls(dr("insr_6"))
            insr_7.Text = nulls(dr("insr_7"))
            insr_8.Text = nulls(dr("insr_8"))
            insr_9.Text = nulls(dr("insr_9"))
            insr_10.Text = nulls(dr("insr_10"))
            insr_11.Text = nulls(dr("insr_11"))
            insr_12.Text = nulls(dr("insr_12"))
            'drb_n.Text = nulls(dr("drb_n"))
            drb_1.Text = nulls(dr("drb_1"))
            drb_2.Text = nulls(dr("drb_2"))
            drb_3.Text = nulls(dr("drb_3"))
            drb_4.Text = nulls(dr("drb_4"))
            drb_5.Text = nulls(dr("drb_5"))
            drb_6.Text = nulls(dr("drb_6"))
            drb_7.Text = nulls(dr("drb_7"))
            drb_8.Text = nulls(dr("drb_8"))
            drb_9.Text = nulls(dr("drb_9"))
            drb_10.Text = nulls(dr("drb_10"))
            drb_11.Text = nulls(dr("drb_11"))
            drb_12.Text = nulls(dr("drb_12"))
            ' net_n.Text = nulls(dr("net_n"))
            net_1.Text = nulls(dr("net_1"))
            net_2.Text = nulls(dr("net_2"))
            net_3.Text = nulls(dr("net_3"))
            net_4.Text = nulls(dr("net_4"))
            net_5.Text = nulls(dr("net_5"))
            net_6.Text = nulls(dr("net_6"))
            net_7.Text = nulls(dr("net_7"))
            net_8.Text = nulls(dr("net_8"))
            net_9.Text = nulls(dr("net_9"))
            net_10.Text = nulls(dr("net_10"))
            net_11.Text = nulls(dr("net_11"))
            net_12.Text = nulls(dr("net_12"))
            edu_name.Text = nulls(dr("edu_name"))
            group_name.Text = nulls(dr("gr_name"))
            group_code.Text = nulls(dr("gr_code"))
            'st_n.Text = nulls(dr("st_n"))
            st_1.Text = nulls(dr("st_1"))
            st_2.Text = nulls(dr("st_2"))
            st_3.Text = nulls(dr("st_3"))
            st_4.Text = nulls(dr("st_4"))
            st_5.Text = nulls(dr("st_5"))
            st_6.Text = nulls(dr("st_6"))
            st_7.Text = nulls(dr("st_7"))
            st_8.Text = nulls(dr("st_8"))
            st_9.Text = nulls(dr("st_9"))
            st_10.Text = nulls(dr("st_10"))
            st_11.Text = nulls(dr("st_11"))
            st_12.Text = nulls(dr("st_12"))
            email.Text = nulls(dr("email"))
            regl.Text = nulls(dr("regl"))
            address.Text = nulls(dr("address"))
            arm.Text = nulls(dr("arm"))
            mstatu.Text = nulls(dr("mstatu"))
            stat_name.Text = nulls(dr("stat_name"))
            sal.Text = nulls(dr("sal"))
            tabs.Text = nulls(dr("tabs"))
            rabs.Text = nulls(dr("rabs"))
            rabsu.Text = nulls(dr("rabsu"))
            weekend.Text = nulls(dr("weekend"))
            branch_name.Text = nulls(dr("branch_name"))
            TM_NAME.Text = nulls(dr("TM_NAME"))
            mang_name.Text = nulls(dr("mang_name"))
            fcode.Text = nulls(dr("fcode"))
            edutype_name.Text = nulls(dr("edutype_name"))
            esal.Text = nulls(dr("esal"))
            jdate.Value = dr("jdate")
            mdate.Value = dr("mdate")
            es.CheckState = nulls(dr("es"))
            ew.CheckState = nulls(dr("ew"))
            er.CheckState = nulls(dr("er"))
            cp.CheckState = nulls(dr("cp"))
            ce.CheckState = nulls(dr("ce"))
            cw.CheckState = nulls(dr("cw"))
            cc.CheckState = nulls(dr("cc"))
            cs.CheckState = nulls(dr("cs"))
            ct.CheckState = nulls(dr("ct"))
            RUN.CheckState = nulls(dr("srun"))
            OBOY.CheckState = nulls(dr("OBOY"))
            DOCTOR.CheckState = nulls(dr("DOC"))
            DEMAIL.Text = nulls(dr("DEMAIL"))
            cmdcourse.Connection = CN
            cmdcourse.CommandType = CommandType.Text
            cmdcourse.CommandText = "select * from ecourse where code='" & pcode.Text & "'"
            adcourse.SelectCommand = cmdcourse
            adcourse.Fill(DBS, "course")
            course = DBS.Tables("course")
            DBS.Tables("course").Clear()
            adcourse.Fill(DBS, "course")
            course = DBS.Tables("course")
            dcourse.DataSource = course
            cmdWORK.Connection = CN
            cmdWORK.CommandType = CommandType.Text
            cmdWORK.CommandText = "select * from eWORK where code='" & pcode.Text & "'"
            adWORK.SelectCommand = cmdWORK
            adWORK.Fill(DBS, "WORK")
            WORK = DBS.Tables("WORK")
            DBS.Tables("WORK").Clear()
            adWORK.Fill(DBS, "WORK")
            WORK = DBS.Tables("WORK")
            dWORK.DataSource = WORK
            cmdeems.Connection = CN
            cmdeems.CommandType = CommandType.Text
            cmdeems.CommandText = "select * from eemp_ms where emp_code='" & pcode.Text & "' "
            adeems.SelectCommand = cmdeems
            adeems.Fill(DBS, "eems")
            eems = DBS.Tables("eems")
            DBS.Tables("eems").Clear()
            adeems.Fill(DBS, "eems")
            eems = DBS.Tables("eems")
            DataGridView6.DataSource = eems
            DataGridView6.Columns("qun").HeaderText = "√Õ÷—"
            DataGridView6.Columns("ms_name").HeaderText = "«·»Ì«‰"
            DataGridView6.Columns("ms_name").Width = 300
            DataGridView6.Columns("note").HeaderText = "„·«ÕŸÂ"
            DataGridView6.Columns("note").Width = 200
            DataGridView6.Columns("mk").HeaderText = "‰Ê⁄ «·„” ‰œ"
            DataGridView6.Columns("emp_code").Visible = False
            DataGridView6.Columns("emp_name").Visible = False
            DataGridView6.Columns("ms_code").Visible = False
            DataGridView6.Columns("pdf").Visible = False
            DataGridView6.Columns("ky").Visible = False
            cmdTD.Connection = CN
            cmdTD.CommandType = CommandType.Text
            cmdTD.CommandText = "select * from emp_TD where emp_code='" & pcode.Text & "' "
            adTD.SelectCommand = cmdTD
            adTD.Fill(DBS, "TD")
            TD = DBS.Tables("TD")
            DBS.Tables("TD").Clear()
            adTD.Fill(DBS, "TD")
            TD = DBS.Tables("TD")
            DataGridView3.DataSource = TD
            DataGridView3.Columns("qun").HeaderText = "√Õ÷—"
            DataGridView3.Columns("TD_name").HeaderText = "«·»Ì«‰"
            DataGridView3.Columns("TD_name").Width = 300
            DataGridView3.Columns("note").HeaderText = "„·«ÕŸÂ"
            DataGridView3.Columns("note").Width = 200
            DataGridView3.Columns("mk").HeaderText = "‰Ê⁄ «·„” ‰œ"
            DataGridView3.Columns("emp_code").Visible = False
            DataGridView3.Columns("emp_name").Visible = False
            DataGridView3.Columns("TD_code").Visible = False
            DataGridView3.Columns("ky").Visible = False
            dr.Close() : dr.Close() : cmd.CommandText = "select * from Eeimage where code='" & Val(pcode.Text) & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then
                Dim newMstream As New System.IO.MemoryStream(CType(dr.Item("image"), Byte()))
                Dim ImageFromDB As New Bitmap(newMstream)
                IPX.Image = ImageFromDB
            End If

        End If
    End Sub
    Private Sub pname_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles pname.KeyUp

    End Sub

    Private Sub pname_Layout(ByVal sender As Object, ByVal e As System.Windows.Forms.LayoutEventArgs) Handles pname.Layout

    End Sub

    Private Sub pname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pname.TextChanged

    End Sub

    Private Sub brpd_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles brpd.CellContentClick

    End Sub

    Private Sub brpd_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles brpd.CellMouseClick
        On Error Resume Next
        If d1 = 1 Then
            yy = ""
            '' ''If empa = 0 Then
            '' ''    Dim x As String = InputBox("«—Ã«¡ «œŒ«· ﬂ·„… «·„—Ê—")
            '' ''    yy = " and pasw='" & x & "'"
            '' ''End If
            pcode.Text = brpd(("code"), e.RowIndex).Value
            FEMP()
        ElseIf d1 = 2 Then
            asdate.Value = brpd(("asdate"), e.RowIndex).Value
            aeworker.Text = brpd(("aeworker"), e.RowIndex).Value
            av_type.Text = brpd(("av_type"), e.RowIndex).Value
            ap_type.Text = brpd(("ap_type"), e.RowIndex).Value
            adate1.Value = brpd(("adate1"), e.RowIndex).Value
            adate2.Value = brpd(("adate2"), e.RowIndex).Value
            along.Text = brpd(("along"), e.RowIndex).Value
            anotse.Text = brpd(("anotse"), e.RowIndex).Value
            awrite.Text = brpd(("awrite"), e.RowIndex).Value
            agm.Text = brpd(("agm"), e.RowIndex).Value
            adm.Text = brpd(("adm"), e.RowIndex).Value
            acode.Text = brpd(("acode"), e.RowIndex).Value
            pcode.Text = brpd(("emp_code"), e.RowIndex).Value
            pname.Text = brpd(("emp_name"), e.RowIndex).Value
        End If

    End Sub

    Private Sub GlassButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton2.Click
        Dim b As String = ""
        'If rpt = 0 Then
        '    MsgBox("·Ì”  ·œÌﬂ «·’·«ÕÌ…")
        '    dr.Close()
        '    cmd.CommandText = "insert into llog (usr,note,date1,time1,gr) values ('" & suser & "','„Õ«Ê·… ⁄—÷  ﬁ—Ì— ⁄‰ «·„” Œœ„Ì‰ „⁄ ⁄œ„ «„ ·«ﬂ ’·«ÕÌ…','" & ChangeFormat(Now.Date) & "','" & Now.Hour & ":" & Now.Minute & ":" & Now.Second & "','„Õ«Ê·… «Œ —«ﬁ')"
        '    cmd.ExecuteNonQuery()
        '    Exit Sub
        'End If
        Dim yy As String = "where code<>0"

        If cpcode.Checked = True Then
            yy = yy & "  " & " and code='" & pcode.Text & "'"
        End If

        If cmobile.Checked = True Then
            yy = yy & "  " & " and mobile='" & mobile.Text & "'"
        End If
        If cinh.Checked = True Then
            yy = yy & "  " & " and inh='" & inh.Text & "'"
        End If
        If couth.Checked = True Then
            yy = yy & "  " & " and outh='" & outh.Text & "'"
        End If
        If cemp_date.Checked = True Then
            yy = yy & "  " & " and emp_date='" & ChangeFormat(emp_date.Value) & "'"
        End If
        If cmobile.Checked = True Then
            yy = yy & "  " & " and mobile='" & mobile.Text & "'"
        End If
        If cid.Checked = True Then
            yy = yy & "  " & " and id='" & id.Text & "'"
        End If

        If cgroup_code.Checked = True Then
            yy = yy & "  " & " and gr_code='" & group_code.Text & "'"
        End If
        If cjop_code.Checked = True Then
            yy = yy & "  " & " and jop_code='" & jop_code.Text & "'"
        End If
        If cinsr_code.Checked = True Then
            yy = yy & "  " & " and insr_code='" & insr_code.Text & "'"
        End If
        If cmon_day.Checked = True Then
            yy = yy & "  " & " and mon_day='" & mon_day.Text & "'"
        End If
        If cshift.Checked = True Then
            yy = yy & "  " & " and shift='" & shift.Text & "'"
        End If
        If cbranch.Checked = True Then
            yy = yy & "  " & " and branch_name='" & branch_name.Text & "'"
        End If
        cmdeemp.Connection = CN
        cmdeemp.CommandType = CommandType.Text
        cmdeemp.CommandText = "select * from eemp " & yy & " order by code"
        adeemp.SelectCommand = cmdeemp
        adeemp.Fill(DBS, "eemp")
        eemp = DBS.Tables("eemp")
        DBS.Tables("eemp").Clear()

        adeemp.Fill(DBS, "eemp")
        eemp = DBS.Tables("eemp")
        brpd.DataSource = eemp
        d1 = 1
        Dim v As Integer = 0
        While Not v = brpd.Columns.Count
            brpd.Columns(v).Visible = False
            v = v + 1
        End While
        brpd.Columns("NAME").Visible = True
        brpd.Columns("NAME").HeaderText = "«·„ÊŸ›"
        brpd.Columns("NAME").Width = 300
        Dim oj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        oj.Load(Application.StartupPath & "\emp.rpt")
        oj.Database.Tables(0).SetDataSource(eemp)
        rp.CrystalReportViewer1.ReportSource = oj

        rp.Show() : rp.Focus()
    End Sub

    Private Sub mon_name_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mon_name.SelectedIndexChanged
        If mon_name.Focused = False Then Exit Sub
        If mon_name.Text = "" Then Exit Sub

        FRC = mon.Select("NAME='" & mon_name.Text & "'")
        If FRC.Length <= 0 Then
            mon_name.Text = ""
            mon_code.Text = ""
            Exit Sub
        Else
            RC = FRC(0)
            mon_code.Text = RC("code")
            date2.Text = RC("date2")
            date1.Text = RC("date1")

        End If
    End Sub

    Private Sub GlassButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton8.Click
        Dim n As Integer
        n = mon_code.Text
        Dim b As String = ""
        If rpt = 0 Then
            MsgBox("·Ì”  ·œÌﬂ «·’·«ÕÌ…")
            dr.Close()
            cmd.CommandText = "insert into llog (usr,note,date1,time1,gr) values ('" & suser & "','„Õ«Ê·… ⁄—÷  ﬁ—Ì— ⁄‰ «·„” Œœ„Ì‰ „⁄ ⁄œ„ «„ ·«ﬂ ’·«ÕÌ…','" & ChangeFormat(Now.Date) & "','" & Now.Hour & ":" & Now.Minute & ":" & Now.Second & "','„Õ«Ê·… «Œ —«ﬁ')"
            cmd.ExecuteNonQuery()
            Exit Sub
        End If
        Dim yy As String = "where code<>0"

        If cpcode.Checked = True Then
            yy = yy & "  " & " and code='" & pcode.Text & "'"
        End If
        If STO.Checked = True Then
            yy = yy & "  " & " and ST_" & n & "='0'"
        End If
        If RUN.Checked = True Then
            yy = yy & "  " & " and ST_" & n & "='1'"
        End If

        If cmobile.Checked = True Then
            yy = yy & "  " & " and mobile='" & mobile.Text & "'"
        End If
        If cinh.Checked = True Then
            yy = yy & "  " & " and inh='" & inh.Text & "'"
        End If
        If couth.Checked = True Then
            yy = yy & "  " & " and outh='" & outh.Text & "'"
        End If
        If cemp_date.Checked = True Then
            yy = yy & "  " & " and emp_date='" & ChangeFormat(emp_date.Value) & "'"
        End If
        If cmobile.Checked = True Then
            yy = yy & "  " & " and mobile='" & mobile.Text & "'"
        End If
        If cid.Checked = True Then
            yy = yy & "  " & " and id='" & id.Text & "'"
        End If

        If cgroup_code.Checked = True Then
            yy = yy & "  " & " and gr_code='" & group_code.Text & "'"
        End If
        If cjop_code.Checked = True Then
            yy = yy & "  " & " and jop_code='" & jop_code.Text & "'"
        End If
        If cinsr_code.Checked = True Then
            yy = yy & "  " & " and insr_code='" & insr_code.Text & "'"
        End If
        If cmon_day.Checked = True Then
            yy = yy & "  " & " and mon_day='" & mon_day.Text & "'"
        End If
        If cshift.Checked = True Then
            yy = yy & "  " & " and shift='" & shift.Text & "'"
        End If
        cmdeemp.Connection = CN
        cmdeemp.CommandType = CommandType.Text
        cmdeemp.CommandText = "select name,c1_n,c1_" & n & " as c1_1 ,c2_n,c2_" & n & " as c2_1 ,c3_n,c3_" & n & " as c3_1 ,c4_n,c4_" & n & " as c4_1,o1_n,o1_" & n & " as o1_1 ,o2_n,o2_" & n & " as o2_1,o3_n,o3_" & n & " as o3_1,o4_n,o4_" & n & " as o4_1,insr_n,insr_" & n & " as insr_1,drb_n ,drb_" & n & " as drb_1 ,net_n ,net_" & n & " as net_1,gr_name from eemp " & yy
        adeemp.SelectCommand = cmdeemp
        adeemp.Fill(DBS, "eemp")
        eemp = DBS.Tables("eemp")
        DBS.Tables("eemp").Clear()
        adeemp.Fill(DBS, "eemp")
        eemp = DBS.Tables("eemp")
        Dim oj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        oj.Load(Application.StartupPath & "\sal list.rpt")
        oj.Database.Tables(0).SetDataSource(eemp)
        oj.SetParameterValue("1", " ﬁ—Ì— «·„— »«  ·‘Â— " & mon_name.Text)
        rp.CrystalReportViewer1.ReportSource = oj

        rp.Show() : rp.Focus()
    End Sub

    Private Sub GlassButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton9.Click
        Dim n As Integer
        n = mon_code.Text
        Dim b As String = ""
        If rpt = 0 Then
            MsgBox("·Ì”  ·œÌﬂ «·’·«ÕÌ…")
            dr.Close()
            cmd.CommandText = "insert into llog (usr,note,date1,time1,gr) values ('" & suser & "','„Õ«Ê·… ⁄—÷  ﬁ—Ì— ⁄‰ «·„” Œœ„Ì‰ „⁄ ⁄œ„ «„ ·«ﬂ ’·«ÕÌ…','" & ChangeFormat(Now.Date) & "','" & Now.Hour & ":" & Now.Minute & ":" & Now.Second & "','„Õ«Ê·… «Œ —«ﬁ')"
            cmd.ExecuteNonQuery()
            Exit Sub
        End If
        Dim yy As String = "where code<>0"

        If cpcode.Checked = True Then
            yy = yy & "  " & " and code='" & pcode.Text & "'"
        End If
        If STO.Checked = True Then
            yy = yy & "  " & " and ST_" & n & "='0'"
        End If
        If RUN.Checked = True Then
            yy = yy & "  " & " and ST_" & n & "='1'"
        End If

        If cmobile.Checked = True Then
            yy = yy & "  " & " and mobile='" & mobile.Text & "'"
        End If
        If cinh.Checked = True Then
            yy = yy & "  " & " and inh='" & inh.Text & "'"
        End If
        If couth.Checked = True Then
            yy = yy & "  " & " and outh='" & outh.Text & "'"
        End If
        If cemp_date.Checked = True Then
            yy = yy & "  " & " and emp_date='" & ChangeFormat(emp_date.Value) & "'"
        End If
        If cmobile.Checked = True Then
            yy = yy & "  " & " and mobile='" & mobile.Text & "'"
        End If
        If cid.Checked = True Then
            yy = yy & "  " & " and id='" & id.Text & "'"
        End If

        If cgroup_code.Checked = True Then
            yy = yy & "  " & " and gr_code='" & group_code.Text & "'"
        End If
        If cjop_code.Checked = True Then
            yy = yy & "  " & " and jop_code='" & jop_code.Text & "'"
        End If
        If cinsr_code.Checked = True Then
            yy = yy & "  " & " and insr_code='" & insr_code.Text & "'"
        End If
        If cmon_day.Checked = True Then
            yy = yy & "  " & " and mon_day='" & mon_day.Text & "'"
        End If
        If cshift.Checked = True Then
            yy = yy & "  " & " and shift='" & shift.Text & "'"
        End If
        cmdeemp.Connection = CN
        cmdeemp.CommandType = CommandType.Text
        cmdeemp.CommandText = "select name,c1_n,c1_" & n & " as c1_1 ,c2_n,c2_" & n & " as c2_1 ,c3_n,c3_" & n & " as c3_1 ,c4_n,c4_" & n & " as c4_1,o1_n,o1_" & n & " as o1_1 ,o2_n,o2_" & n & " as o2_1,o3_n,o3_" & n & " as o3_1,o4_n,o4_" & n & " as o4_1,insr_n,insr_" & n & " as insr_1,drb_n ,drb_" & n & " as drb_1 ,net_n ,net_" & n & " as net_1,JOP_NAME from eemp " & yy
        adeemp.SelectCommand = cmdeemp
        adeemp.Fill(DBS, "eemp")
        eemp = DBS.Tables("eemp")
        DBS.Tables("eemp").Clear()
        adeemp.Fill(DBS, "eemp")
        eemp = DBS.Tables("eemp")
        Dim oj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        oj.Load(Application.StartupPath & "\sal CARD.rpt")
        oj.Database.Tables(0).SetDataSource(eemp)
        oj.SetParameterValue("1", mon_name.Text)
        rp.CrystalReportViewer1.ReportSource = oj

        rp.Show() : rp.Focus()
    End Sub

    Private Sub GlassButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton10.Click
        Dim n As Integer
        Dim SS As String = ""

        n = mon_code.Text
        Dim b As String = ""
        If rpt = 0 Then
            MsgBox("·Ì”  ·œÌﬂ «·’·«ÕÌ…")
            dr.Close()
            cmd.CommandText = "insert into llog (usr,note,date1,time1,gr) values ('" & suser & "','„Õ«Ê·… ⁄—÷  ﬁ—Ì— ⁄‰ «·„” Œœ„Ì‰ „⁄ ⁄œ„ «„ ·«ﬂ ’·«ÕÌ…','" & ChangeFormat(Now.Date) & "','" & Now.Hour & ":" & Now.Minute & ":" & Now.Second & "','„Õ«Ê·… «Œ —«ﬁ')"
            cmd.ExecuteNonQuery()
            Exit Sub
        End If
        Dim yy As String = "where code<>0"
        If CC1.Checked = True Then
            SS = "C1"
        End If
        If CC2.Checked = True Then
            SS = "C2"
        End If
        If CC4.Checked = True Then
            SS = "C4"
        End If
        If CC3.Checked = True Then
            SS = "C3"
        End If
        If CO1.Checked = True Then
            SS = "O1"
        End If
        If CO2.Checked = True Then
            SS = "O2"
        End If
        If CO3.Checked = True Then
            SS = "O3"
        End If
        If CO4.Checked = True Then
            SS = "O4"
        End If
        If CINSR.Checked = True Then
            SS = "INSR"
        End If
        If CDRB.Checked = True Then
            SS = "DRB"
        End If
        If CNET.Checked = True Then
            SS = "NET"
        End If
        If cpcode.Checked = True Then
            yy = yy & "  " & " and code='" & pcode.Text & "'"
        End If
        If STO.Checked = True Then
            yy = yy & "  " & " and ST_" & n & "='0'"
        End If
        If RUN.Checked = True Then
            yy = yy & "  " & " and ST_" & n & "='1'"
        End If

        If cmobile.Checked = True Then
            yy = yy & "  " & " and mobile='" & mobile.Text & "'"
        End If
        If cinh.Checked = True Then
            yy = yy & "  " & " and inh='" & inh.Text & "'"
        End If
        If couth.Checked = True Then
            yy = yy & "  " & " and outh='" & outh.Text & "'"
        End If
        If cemp_date.Checked = True Then
            yy = yy & "  " & " and emp_date='" & ChangeFormat(emp_date.Value) & "'"
        End If
        If cmobile.Checked = True Then
            yy = yy & "  " & " and mobile='" & mobile.Text & "'"
        End If
        If cid.Checked = True Then
            yy = yy & "  " & " and id='" & id.Text & "'"
        End If

        If cgroup_code.Checked = True Then
            yy = yy & "  " & " and gr_code='" & group_code.Text & "'"
        End If
        If cjop_code.Checked = True Then
            yy = yy & "  " & " and jop_code='" & jop_code.Text & "'"
        End If
        If cinsr_code.Checked = True Then
            yy = yy & "  " & " and insr_code='" & insr_code.Text & "'"
        End If
        If cmon_day.Checked = True Then
            yy = yy & "  " & " and mon_day='" & mon_day.Text & "'"
        End If
        If cshift.Checked = True Then
            yy = yy & "  " & " and shift='" & shift.Text & "'"
        End If
        cmdeemp.Connection = CN
        cmdeemp.CommandType = CommandType.Text
        cmdeemp.CommandText = "select name," & SS & "_" & n & " as c1_1 ," & SS & "_N AS C1_N from eemp " & yy
        adeemp.SelectCommand = cmdeemp
        adeemp.Fill(DBS, "eemp")
        eemp = DBS.Tables("eemp")
        DBS.Tables("eemp").Clear()
        adeemp.Fill(DBS, "eemp")
        eemp = DBS.Tables("eemp")
        Dim oj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        oj.Load(Application.StartupPath & "\sal G.rpt")
        oj.Database.Tables(0).SetDataSource(eemp)

        rp.CrystalReportViewer1.ReportSource = oj
        rp.Show() : rp.Focus()
    End Sub

    Private Sub GlassButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton11.Click

        Dim SS As String = ""


        Dim b As String = ""
        If rpt = 0 Then
            MsgBox("·Ì”  ·œÌﬂ «·’·«ÕÌ…")
            dr.Close()
            cmd.CommandText = "insert into llog (usr,note,date1,time1,gr) values ('" & suser & "','„Õ«Ê·… ⁄—÷  ﬁ—Ì— ⁄‰ «·„” Œœ„Ì‰ „⁄ ⁄œ„ «„ ·«ﬂ ’·«ÕÌ…','" & ChangeFormat(Now.Date) & "','" & Now.Hour & ":" & Now.Minute & ":" & Now.Second & "','„Õ«Ê·… «Œ —«ﬁ')"
            cmd.ExecuteNonQuery()
            Exit Sub
        End If
        Dim yy As String = "where code<>0"
        If CC1.Checked = True Then
            SS = "C1"
        ElseIf CC2.Checked = True Then
            SS = "C2"
        ElseIf CC4.Checked = True Then
            SS = "C4"
        ElseIf CC3.Checked = True Then
            SS = "C3"
        ElseIf CO1.Checked = True Then
            SS = "O1"
        ElseIf CO2.Checked = True Then
            SS = "O2"
        ElseIf CO3.Checked = True Then
            SS = "O3"
        ElseIf CO4.Checked = True Then
            SS = "O4"
        ElseIf CINSR.Checked = True Then
            SS = "INSR"
        ElseIf CDRB.Checked = True Then
            SS = "DRB"
        ElseIf CNET.Checked = True Then
            SS = "NET"
        Else
            MsgBox("«·—Ã«¡ «Œ Ì«— «·»‰œ", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        dr.Close()
        cmd.CommandText = "select * from eemp WHERE code='" & pcode.Text & "' "
        dr = cmd.ExecuteReader
        dr.Read()
        ACdr.Close()
        ACcmd.CommandText = "DELETE * FROM EMP_POND"
        ACcmd.ExecuteNonQuery()
        Dim X As Integer = 1
        While Not X = 13
            FRC = mon.Select("CODE='" & X & "'")
            RC = FRC(0)
            mon_name.Text = RC("NAME")
            ACcmd.CommandText = "INSERT INTO EMP_POND(MON,TOT,NAME) VALUES ('" & mon_name.Text & "','" & dr(SS & "_" & X) & "','" & dr(SS & "_N") & "')"
            ACcmd.ExecuteNonQuery()
            X = X + 1
        End While
        cmdeemp.Connection = ACcn
        cmdeemp.CommandType = CommandType.Text
        cmdeemp.CommandText = "select * from emp_POND "
        adeemp.SelectCommand = cmdeemp
        adeemp.Fill(DBS, "eemp")
        eemp = DBS.Tables("eemp")
        DBS.Tables("eemp").Clear()
        adeemp.Fill(DBS, "eemp")
        eemp = DBS.Tables("eemp")

        Dim oj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        oj.Load(Application.StartupPath & "\EMP POND.rpt")
        oj.Database.Tables(0).SetDataSource(eemp)
        rp.CrystalReportViewer1.ReportSource = oj
        rp.Show() : rp.Focus()
    End Sub

    Private Sub GlassButton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton12.Click
        Dim n As Integer
        n = mon_code.Text
        Dim b As String = ""
        'If rpt = 0 Then
        '    MsgBox("·Ì”  ·œÌﬂ «·’·«ÕÌ…")
        '    dr.Close()
        '    cmd.CommandText = "insert into llog (usr,note,date1,time1,gr) values ('" & suser & "','„Õ«Ê·… ⁄—÷  ﬁ—Ì— ⁄‰ «·„” Œœ„Ì‰ „⁄ ⁄œ„ «„ ·«ﬂ ’·«ÕÌ…','" & ChangeFormat(Now.Date) & "','" & Now.Hour & ":" & Now.Minute & ":" & Now.Second & "','„Õ«Ê·… «Œ —«ﬁ')"
        '    cmd.ExecuteNonQuery()
        '    Exit Sub
        'End If
        Dim yy As String = "where code<>0"

        If cpcode.Checked = True Then
            yy = yy & "  " & " and code='" & pcode.Text & "'"
        End If
        If STO.Checked = True Then
            yy = yy & "  " & " and ST_" & n & "='0'"
        End If
        If RUN.Checked = True Then
            yy = yy & "  " & " and ST_" & n & "='1'"
        End If

        If cmobile.Checked = True Then
            yy = yy & "  " & " and mobile='" & mobile.Text & "'"
        End If
        If cinh.Checked = True Then
            yy = yy & "  " & " and inh='" & inh.Text & "'"
        End If
        If couth.Checked = True Then
            yy = yy & "  " & " and outh='" & outh.Text & "'"
        End If
        If cemp_date.Checked = True Then
            yy = yy & "  " & " and emp_date='" & ChangeFormat(emp_date.Value) & "'"
        End If
        If cmobile.Checked = True Then
            yy = yy & "  " & " and mobile='" & mobile.Text & "'"
        End If


        If cgroup_code.Checked = True Then
            yy = yy & "  " & " and gr_code='" & group_code.Text & "'"
        End If
        If cjop_code.Checked = True Then
            yy = yy & "  " & " and jop_code='" & jop_code.Text & "'"
        End If
        If cinsr_code.Checked = True Then
            yy = yy & "  " & " and insr_code='" & insr_code.Text & "'"
        End If
        If cmon_day.Checked = True Then
            yy = yy & "  " & " and mon_day='" & mon_day.Text & "'"
        End If
        If cshift.Checked = True Then
            yy = yy & "  " & " and shift='" & shift.Text & "'"
        End If
        Dim ID As Integer
        dr1.Close()
        dr.Close() : cmd.CommandText = "SELECT max(id) FROM lcash "
        dr = cmd.ExecuteReader
        dr.Read()
        ID = dr(0)
        dr.Close()
        Dim D As Date = Now
        dr.Close()
        cmd.CommandText = "select * FROM lsub WHERE sub_code='5'"
        dr = cmd.ExecuteReader
        dr.Read()
        Dim hos_sub_no, hos_sub_code, hos_sub_name, hos_main_no, HOS_MAIN_code, hos_main_name As String
        hos_sub_no = 0
        hos_sub_code = dr("sub_CODE")
        hos_sub_name = dr("sub_NAME")
        hos_main_no = 0
        HOS_MAIN_code = dr("Main_CODE")
        hos_main_name = dr("Main_NAME")
        dr.Close()
        cmd.CommandText = " SELECT name,code,net_" & mon_code.Text & " as net FROM eemp " & yy
        dr = cmd.ExecuteReader
        While dr.Read
            cmd1.CommandText = "insert into LCASH (sub_name,sub_code,main_name,main_code,ID,FLG,TIME1,DATE1,USR,cash,crd,notse,save_name,save_code) values ('" & hos_sub_name & "','" & hos_sub_code & "','" & hos_main_name & "','" & HOS_MAIN_code & "','" & ID & "','-1','" & D.TimeOfDay.ToString & "','" & ChangeFormat(Now) & "','" & USR & "','" & dr("net") & "','0',' ’«›Ï „— » «·ÿ»Ì»  " & dr("name") & " ‘Â—  " & mon_name.Text & "','" & save_name.Text & "','" & save_code.Text & "')"
            cmd1.ExecuteNonQuery()
            ID = ID + 1
        End While
    End Sub

    Private Sub GlassButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub picCapture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub GlassButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton3.Click
        ACdr.Close()
        ACcmd.CommandText = "select * from srv "
        ACdr = ACcmd.ExecuteReader
        ACdr.Read()

        Dim FileNames = TwainLib.ScanImages("QQQ", True, )
        PictureBox1.ImageLocation = FileNames(0)
        Dim oer As System.IO.FileStream
        Dim rer As IO.StreamReader
        oer = New IO.FileStream(FileNames(0), IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.Read)
        rer = New IO.StreamReader(oer)
        Dim FileByteArrayr(oer.Length - 1) As Byte
        oer.Read(FileByteArrayr, 0, oer.Length)
        dr.Close()
        If IsNumeric(pe_code.Text) = False Then MsgBox("«·—Ã«¡ «Œ Ì«— Ê—ﬁ… «· ⁄Ì‰") : Exit Sub
        If IsNumeric(pcode.Text) = False Then MsgBox("«·—Ã«¡«Œ Ì«— «·„ÊŸ›") : Exit Sub
        dr.Close() : dr.Close() : cmd.CommandText = "select * from eimage where pecode='" & Val(pe_code.Text) & "' and  code='" & pcode.Text & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            Dim x As String
            dr.Close()
            x = MsgBox("Â·  —Ìœ «· ⁄œÌ· ø", MsgBoxStyle.YesNo)
            If x = vbNo Then Exit Sub
            dr.Close() : dr.Close() : cmd.CommandText = "delete from eimage where  pecode='" & Val(pe_code.Text) & "' and  code='" & pcode.Text & "'"
            cmd.ExecuteNonQuery()
        End If
        dr.Close()
        cmd.CommandText = "insert into eimage (code,name,pecode,pename) values ('" & pcode.Text & "','" & pname.Text & "','" & pe_code.Text & "','" & pe_name.Text & "')"
        cmd.ExecuteNonQuery()
        Dim Sql As String = "update  eimage set image = ? , no = ? where  pecode='" & Val(pe_code.Text) & "' and  code='" & pcode.Text & "'"
        cmd.CommandText = Sql
        cmd.Parameters.Clear()
        cmd.Parameters.Add("@image", System.Data.OleDb.OleDbType.Binary, oer.Length).Value = FileByteArrayr
        cmd.Parameters.Add("@no", System.Data.OleDb.OleDbType.VarChar, 100).Value = oer.Length
        cmd.ExecuteNonQuery()
        MsgBox(" „  ⁄„·Ì… «·Õ›Ÿ", MsgBoxStyle.Information)

    End Sub

    Private Sub GlassButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton7.Click
        OpenFileDialog1.ShowDialog()
        PictureBox2.ImageLocation = OpenFileDialog1.FileName
        Dim oer As System.IO.FileStream
        Dim rer As IO.StreamReader
        oer = New IO.FileStream(OpenFileDialog1.FileName, IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.Read)
        rer = New IO.StreamReader(oer)
        Dim FileByteArrayr(oer.Length - 1) As Byte
        oer.Read(FileByteArrayr, 0, oer.Length)
        dr.Close()
        If IsNumeric(pe_code.Text) = False Then MsgBox("«·—Ã«¡ «Œ Ì«— Ê—ﬁ… «· ⁄Ì‰") : Exit Sub
        If IsNumeric(pcode.Text) = False Then MsgBox("«·—Ã«¡«Œ Ì«— «·„ÊŸ›") : Exit Sub
        dr.Close() : dr.Close() : cmd.CommandText = "select * from eimage where pecode='" & Val(pe_code.Text) & "' and  code='" & pcode.Text & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            Dim x As String
            dr.Close()
            x = MsgBox("Â·  —Ìœ «· ⁄œÌ· ø", MsgBoxStyle.YesNo)
            If x = vbNo Then Exit Sub
            dr.Close() : dr.Close() : cmd.CommandText = "delete from eimage where  pecode='" & Val(pe_code.Text) & "' and  code='" & pcode.Text & "'"
            cmd.ExecuteNonQuery()
        End If
        dr.Close()
        cmd.CommandText = "insert into eimage (code,name,pecode,pename) values ('" & pcode.Text & "','" & pname.Text & "','" & pe_code.Text & "','" & pe_name.Text & "')"
        cmd.ExecuteNonQuery()
        Dim Sql As String = "update  eimage set image = ? , no = ? where  pecode='" & Val(pe_code.Text) & "' and  code='" & pcode.Text & "'"
        cmd.CommandText = Sql
        cmd.Parameters.Clear()
        cmd.Parameters.Add("@image", System.Data.OleDb.OleDbType.Binary, oer.Length).Value = FileByteArrayr
        cmd.Parameters.Add("@no", System.Data.OleDb.OleDbType.VarChar, 100).Value = oer.Length
        cmd.ExecuteNonQuery()
        MsgBox(" „  ⁄„·Ì… «·Õ›Ÿ", MsgBoxStyle.Information)

    End Sub

    Private Sub GlassButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GlassButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton1.Click
        Dim b As String = ""
        If rpt = 0 Then
            MsgBox("·Ì”  ·œÌﬂ «·’·«ÕÌ…")
            dr.Close()
            cmd.CommandText = "insert into llog (usr,note,date1,time1,gr) values ('" & suser & "','„Õ«Ê·… ⁄—÷  ﬁ—Ì— ⁄‰ «·„” Œœ„Ì‰ „⁄ ⁄œ„ «„ ·«ﬂ ’·«ÕÌ…','" & ChangeFormat(Now.Date) & "','" & Now.Hour & ":" & Now.Minute & ":" & Now.Second & "','„Õ«Ê·… «Œ —«ﬁ')"
            cmd.ExecuteNonQuery()
            Exit Sub
        End If
        Dim yy As String = "where code<>0"

        If cpcode.Checked = True Then
            yy = yy & "  " & " and code='" & pcode.Text & "'"
        End If

        If cmobile.Checked = True Then
            yy = yy & "  " & " and mobile='" & mobile.Text & "'"
        End If
        If cinh.Checked = True Then
            yy = yy & "  " & " and inh='" & inh.Text & "'"
        End If
        If couth.Checked = True Then
            yy = yy & "  " & " and outh='" & outh.Text & "'"
        End If
        If cemp_date.Checked = True Then
            yy = yy & "  " & " and emp_date='" & ChangeFormat(emp_date.Value) & "'"
        End If
        If cmobile.Checked = True Then
            yy = yy & "  " & " and mobile='" & mobile.Text & "'"
        End If
        If cid.Checked = True Then
            yy = yy & "  " & " and id='" & id.Text & "'"
        End If

        If cgroup_code.Checked = True Then
            yy = yy & "  " & " and gr_code='" & group_code.Text & "'"
        End If
        If cjop_code.Checked = True Then
            yy = yy & "  " & " and jop_code='" & jop_code.Text & "'"
        End If
        If cinsr_code.Checked = True Then
            yy = yy & "  " & " and insr_code='" & insr_code.Text & "'"
        End If
        If cmon_day.Checked = True Then
            yy = yy & "  " & " and mon_day='" & mon_day.Text & "'"
        End If
        If cshift.Checked = True Then
            yy = yy & "  " & " and shift='" & shift.Text & "'"
        End If
        If pec.Checked = True Then
            yy = yy & "  " & " and pecode='" & pe_code.Text & "'"
        End If
        cmdeemp.Connection = CN
        cmdeemp.CommandType = CommandType.Text
        cmdeemp.CommandText = "select * from v_image " & yy & " order by code"
        adeemp.SelectCommand = cmdeemp
        adeemp.Fill(DBS, "eemp")
        eemp = DBS.Tables("eemp")
        DBS.Tables("eemp").Clear()

        adeemp.Fill(DBS, "eemp")
        eemp = DBS.Tables("eemp")
        brpd.DataSource = eemp
        d1 = 1
        Dim v As Integer = 0
        While Not v = brpd.Columns.Count
            brpd.Columns(v).Visible = False
            v = v + 1
        End While
        brpd.Columns("NAME").Visible = True
        brpd.Columns("NAME").HeaderText = "«·„ÊŸ›"
        brpd.Columns("NAME").Width = 300
        Dim oj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        oj.Load(Application.StartupPath & "\emp image.rpt")
        oj.Database.Tables(0).SetDataSource(eemp)
        rp.CrystalReportViewer1.ReportSource = oj

        rp.Show() : rp.Focus()
    End Sub

    Private Sub cin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cin.Click
        Dim nn As Integer
        nn = TextBox11.Text
        dr.Close()
        cmd.CommandText = "select * from eemp where code='" & nn & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = False Then MsgBox("«·„” Œœ„ €Ì— „”Ã·") : Exit Sub
        pcode.Text = dr("code")
        pname.Text = dr("name")
        inh.Text = dr("inh")
        outm.Text = dr("outm")
        outh.Text = dr("outh")
        inm.Text = dr("inm")
        emp_date.Value = dr("emp_date")
        id.Text = dr("id")
        mobile.Text = dr("mobile")
        edu_code.Text = dr("edu_code")
        jop_code.Text = dr("jop_code")
        jop_name.Text = dr("jop_name")
        insr_code.Text = dr("insr_code")
        weekend.Text = dr("insr_name")
        shift.Text = dr("shift")
        mon_day.Text = dr("mon_day")
        birth_day.Text = dr("birth_day")
        If IsNumeric(pe_code.Text) = False Then MsgBox("«·—Ã«¡ «Œ Ì«— Ê—ﬁ… «· ⁄Ì‰") : Exit Sub
        If IsNumeric(pcode.Text) = False Then MsgBox("«·—Ã«¡«Œ Ì«— «·„ÊŸ›") : Exit Sub
        dr.Close() : cmd.CommandText = "select * from ein where edate='" & ChangeFormat(Now) & "' and  code='" & pcode.Text & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then MsgBox(" „  ”ÃÌ· «·Õ÷Ê—") : Exit Sub
        dr.Close()
        cmd.CommandText = "select * from sdate "
        dr = cmd.ExecuteReader
        dr.Read()
        Dim anow As Date = dr("sdate")
        Dim xxxx As Date = anow.Date + TimeSpan.FromHours(inh.Text) + TimeSpan.FromMinutes(inm.Text)
        'Dim data As IDataObject
        'Dim bmap As Image
        'SendMessage(hHwnd, WM_CAP_EDIT_COPY, 0, 0)
        'data = Clipboard.GetDataObject()
        'If data.GetDataPresent(GetType(System.Drawing.Bitmap)) Then
        '    bmap = CType(data.GetData(GetType(System.Drawing.Bitmap)), Image)
        '    IO.File.Delete(Application.StartupPath & "\" & wee)
        '    bmap.Save(Application.StartupPath & "\" & wee, Imaging.ImageFormat.Bmp)
        '    pb3.ImageLocation = Application.StartupPath & "\" & wee
        'End If
        '=============================================================================
        'Dim oer As System.IO.FileStream
        'Dim rer As IO.StreamReader
        'oer = New IO.FileStream(Application.StartupPath & "\" & wee, IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.Read)
        'rer = New IO.StreamReader(oer)
        'Dim FileByteArrayr(oer.Length - 1) As Byte
        'oer.Read(FileByteArrayr, 0, oer.Length)
        dr.Close()
        Dim asx As TimeSpan
        asx = anow - xxxx
        dr.Close()
        cmd.CommandText = "insert into ein ([name],[code],[come_date],[come_diff],[edate],comh,comm) VALUES ('" & pname.Text & "','" & pcode.Text & "','" & ChangeFormatall(anow) & "','" & Math.Round(asx.TotalMinutes, 0) & "','" & ChangeFormat(anow) & "','" & asx.Hours & "','" & asx.Minutes & "')"
        cmd.ExecuteNonQuery()
        'Dim Sql As String = "update  ein set come_pic = ? , come_picn = ? where  edate='" & ChangeFormat(Now) & "' and  code='" & pcode.Text & "'"
        'cmd.CommandText = Sql
        'cmd.Parameters.Clear()
        'cmd.Parameters.Add("@come_pic", System.Data.OleDb.OleDbType.Binary, oer.Length).Value = FileByteArrayr
        'cmd.Parameters.Add("@come_picn", System.Data.OleDb.OleDbType.VarChar, 100).Value = oer.Length
        'cmd.ExecuteNonQuery()
        MsgBox(" „  ⁄„·Ì… «·Õ›Ÿ", MsgBoxStyle.Information)
        wee = wee + 1
    End Sub

    Private Sub cout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cout.Click
        Dim nn As Integer = TextBox11.Text
        dr.Close()
        cmd.CommandText = "select * from eemp where code='" & nn & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = False Then MsgBox("«·„” Œœ„ €Ì— „”Ã·") : Exit Sub
        pcode.Text = dr("code")
        pname.Text = dr("name")
        inh.Text = dr("inh")
        outm.Text = dr("outm")
        outh.Text = dr("outh")
        inm.Text = dr("inm")
        If IsNumeric(pe_code.Text) = False Then MsgBox("«·—Ã«¡ «Œ Ì«— Ê—ﬁ… «· ⁄Ì‰") : Exit Sub
        If IsNumeric(pcode.Text) = False Then MsgBox("«·—Ã«¡«Œ Ì«— «·„ÊŸ›") : Exit Sub
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

        Dim xxxx As Date = anow.Date + TimeSpan.FromHours(outh.Text) + TimeSpan.FromMinutes(outm.Text)

        asx = anow - xxxx

        'Dim data As IDataObject
        'Dim bmap As Image
        'SendMessage(hHwnd, WM_CAP_EDIT_COPY, 0, 0)
        'data = Clipboard.GetDataObject()
        'If data.GetDataPresent(GetType(System.Drawing.Bitmap)) Then
        '    bmap = CType(data.GetData(GetType(System.Drawing.Bitmap)), Image)
        '    IO.File.Delete(Application.StartupPath & "\" & wee)
        '    bmap.Save(Application.StartupPath & "\" & wee, Imaging.ImageFormat.Bmp)
        '    pb3.ImageLocation = Application.StartupPath & "\" & wee
        'End If
        '=============================================================================
        'Dim oer As System.IO.FileStream
        'Dim rer As IO.StreamReader
        'oer = New IO.FileStream(Application.StartupPath & "\" & wee, IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.Read)
        'rer = New IO.StreamReader(oer)
        'Dim FileByteArrayr(oer.Length - 1) As Byte
        'oer.Read(FileByteArrayr, 0, oer.Length)
        dr.Close()
        'Dim Sql As String = "update  ein set out_pic = ? , out_picn = ?,out_date='" & ChangeFormatall(Now) & "',ovr=1,out_diff='" & Math.Round(asx.TotalMinutes, 0) & "',ework='" & asxx & "',outh='" & asx.Hours & "',outm='" & asx.Minutes & "' where  ovr=0 and  code='" & nn & "'"
        'cmd.CommandText = Sql
        'cmd.Parameters.Clear()
        'cmd.Parameters.Add("@out_pic", System.Data.OleDb.OleDbType.Binary, oer.Length).Value = FileByteArrayr
        'cmd.Parameters.Add("@out_picn", System.Data.OleDb.OleDbType.VarChar, 100).Value = oer.Length
        cmd.CommandText = "update  ein set out_date=,ovr=1,out_diff=,ework=,outh=,outm='" & asx.Minutes & "' where  ovr=0 and  code='" & nn & "'"
        cmd.ExecuteNonQuery()

        cmd.CommandText = "insert into ein ([name],[code],[come_date],[come_diff],[edate],comh,comm,out_date,out_diff,ework,outh,outm) VALUES ('" & pname.Text & "','" & pcode.Text & "','" & ChangeFormatall(anow) & "','" & Math.Round(asx.TotalMinutes, 0) & "','" & ChangeFormat(anow) & "','" & asx.Hours & "','" & asx.Minutes & "''" & ChangeFormatall(anow) & "','" & Math.Round(asx.TotalMinutes, 0) & "','" & asxx & "','" & asx.Hours & "','" & asx.Minutes & "')"
        cmd.ExecuteNonQuery()
        MsgBox(" „  ⁄„·Ì… «·Õ›Ÿ", MsgBoxStyle.Information)
        wee = wee + 1
    End Sub

    Private Sub GlassButton4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton4.Click
        Dim YY As String = ""

        If cpcode.Checked = True Then
            YY = " and code='" & pcode.Text & "'"
        End If
        cmdTEMP2.Connection = CN
        cmdTEMP2.CommandType = CommandType.Text
        cmdTEMP2.CommandText = "select * from EIN WHERE  EDATE between '" & ChangeFormat(DD1.Value) & "' and '" & ChangeFormat(DD2.Value) & "' " & YY
        adTEMP2.SelectCommand = cmdTEMP2
        adTEMP2.Fill(DBS, "TEMP2")
        TEMP2 = DBS.Tables("TEMP2")
        DBS.Tables("TEMP2").Clear()
        adTEMP2.Fill(DBS, "TEMP2")
        TEMP2 = DBS.Tables("TEMP2")
        Dim oj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        oj.Load(Application.StartupPath & "\IN.rpt")
        oj.Database.Tables(0).SetDataSource(TEMP2)
        rp.CrystalReportViewer1.ReportSource = oj
        rp.Show() : rp.Focus()

    End Sub

    Private Sub GlassButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton5.Click
        Dim YY As String = ""
        If cpcode.Checked = True Then
            YY = " and code='" & pcode.Text & "'"
        End If
        cmdTEMP1.Connection = CN
        cmdTEMP1.CommandType = CommandType.Text
        cmdTEMP1.CommandText = "select NAME,SUM(OUT_DIFF) AS OUT_DIFF ,SUM(COME_DIFF) AS COME_DIFF,COUNT(OUT_PICN) AS OUT_PICN ,SUM (EWORK) AS EWORK,code from EIN WHERE   EDATE between '" & ChangeFormat(DD1.Value) & "' and '" & ChangeFormat(DD2.Value) & "' " & YY & " GROUP BY NAME,code"
        adTEMP1.SelectCommand = cmdTEMP1
        adTEMP1.Fill(DBS, "TEMP1")
        TEMP1 = DBS.Tables("TEMP1")
        DBS.Tables("TEMP1").Clear()
        adTEMP1.Fill(DBS, "TEMP1")
        TEMP1 = DBS.Tables("TEMP1")
        Dim coms As Integer = 0
        While Not coms = TEMP1.Rows.Count
            RC = TEMP1.Rows(0)
            RC.BeginEdit()
            RC("OUT_DIFF") = 0
            RC("COME_DIFF") = 0
            RC.EndEdit()
            coms += 1
        End While
        dr.Close()
        cmd.CommandText = "select NAME,SUM(COME_DIFF) AS COME_DIFF from EIN WHERE COME_DIFF>0 and  EDATE between '" & ChangeFormat(DD1.Value) & "' and '" & ChangeFormat(DD2.Value) & "' " & YY & " GROUP BY NAME"
        dr = cmd.ExecuteReader
        While dr.Read
            FRC = TEMP1.Select("NAME='" & dr("name") & "'")
            RC = FRC(0)
            RC.BeginEdit()
            RC("COME_DIFF") = nulls(dr(1)) / 60
            RC.EndEdit()
            coms += 1
        End While
        dr.Close()
        cmd.CommandText = "select NAME,SUM(OUT_DIFF) AS COME_DIFF from EIN WHERE OUT_DIFF<0 and EDATE between '" & ChangeFormat(DD1.Value) & "' and '" & ChangeFormat(DD2.Value) & "' " & YY & " GROUP BY NAME"
        dr = cmd.ExecuteReader
        While dr.Read
            FRC = TEMP1.Select("NAME='" & dr("name") & "'")
            RC = FRC(0)
            RC.BeginEdit()
            RC("COME_DIFF") = RC("COME_DIFF") + Math.Abs(Val(nulls(dr(1)))) / 60
            RC.EndEdit()
            coms += 1
        End While
        dr.Close()
        cmd.CommandText = "select NAME,SUM(COME_DIFF) AS COME_DIFF from EIN WHERE COME_DIFF<0 and EDATE between '" & ChangeFormat(DD1.Value) & "' and '" & ChangeFormat(DD2.Value) & "' " & YY & " GROUP BY NAME"
        dr = cmd.ExecuteReader
        While dr.Read
            FRC = TEMP1.Select("NAME='" & dr("name") & "'")
            RC = FRC(0)
            RC.BeginEdit()
            RC("OUT_DIFF") = nulls(dr(1)) / 60
            RC.EndEdit()
            coms += 1
        End While
        dr.Close()
        cmd.CommandText = "select NAME,SUM(OUT_DIFF) AS COME_DIFF from EIN WHERE OUT_DIFF>0 and EDATE between '" & ChangeFormat(DD1.Value) & "' and '" & ChangeFormat(DD2.Value) & "' " & YY & " GROUP BY NAME"
        dr = cmd.ExecuteReader
        While dr.Read
            FRC = TEMP1.Select("NAME='" & dr("name") & "'")
            RC = FRC(0)
            RC.BeginEdit()
            RC("OUT_DIFF") = RC("COME_DIFF") + Math.Abs(Val(nulls(dr(1)))) / 60
            RC.EndEdit()
            coms += 1
        End While
        coms = 0
        While Not coms = TEMP1.Rows.Count
            RC = TEMP1.Rows(0)
            dr.Close()
            cmd.CommandText = "select * from eemp where code='" & RC("code") & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            dr1.Close()
            cmd1.CommandText = "update eemp set c3_" & DD2.Value.Month & "='" & RC("OUT_DIFF") * dr("mon_day") & "',o1_" & DD2.Value.Month & "='" & RC("COME_DIFF") * dr("shift") & "' where code='" & RC("code") & "' "
            cmd1.ExecuteNonQuery()
            dr.Close()
            coms += 1
        End While
        Dim oj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        oj.Load(Application.StartupPath & "\TOTAL IN.rpt")
        oj.Database.Tables(0).SetDataSource(TEMP1)
        rp.CrystalReportViewer1.ReportSource = oj
        rp.Show() : rp.Focus()

    End Sub

    Private Sub c1_n_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c1_n.TextChanged

    End Sub

    Private Sub TextBox11_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox11.KeyPress

    End Sub

    Private Sub TextBox11_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox11.KeyUp
        'If e.KeyCode = Keys.Enter Then
        '    dr.Close() : cmd.CommandText = "select * from ein where  code='" & TextBox11.Text & "' and ovr=0"
        '    dr = cmd.ExecuteReader
        '    dr.Read()
        '    If dr.HasRows = True Then
        '        cout_Click(cout, e)
        '    Else
        '        cin_Click(cin, e)

        '    End If

        'End If
    End Sub

    Private Sub TextBox11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox11.TextChanged

    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click
    End Sub

    Private Sub GlassButton6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton6.Click
        Dim W As Integer = Convert.ToInt32("200")
        Dim H As Integer = Convert.ToInt32("50")
        b.Alignment = BarcodeLib.AlignmentPositions.CENTER

        Dim type As BarcodeLib.TYPE = BarcodeLib.TYPE.UNSPECIFIED

        type = BarcodeLib.TYPE.CODE128

        b.IncludeLabel = True

        barco.Image = b.Encode(type, Me.pcode.Text.Trim(), W, H)
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
        PrintDialog1.Document = PrintDocument1
        'PrintDocument1.Print()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim n As Integer = 0
        Dim h As Integer = 0
        Dim ha As Integer = 0
        Dim f As New Font("arial", 16, FontStyle.Bold)


        h = 5
        ha = 30
        While Not n = 13
            e.Graphics.DrawString("aly hassan", f, Brushes.Black, 20, h)
            e.Graphics.DrawImage(barco.Image, 0, ha)
            e.Graphics.DrawString("aly hassan", f, Brushes.Black, 170, h)
            e.Graphics.DrawImage(barco.Image, 175, ha)
            e.Graphics.DrawString("aly hassan", f, Brushes.Black, 320, h)
            e.Graphics.DrawImage(barco.Image, 350, ha)
            e.Graphics.DrawString("aly hassan", f, Brushes.Black, 470, h)
            e.Graphics.DrawImage(barco.Image, 525, ha)
            e.Graphics.DrawString("aly hassan", f, Brushes.Black, 620, h)
            e.Graphics.DrawImage(barco.Image, 700, ha)
            h = h + 80
            ha = ha + 80
            n = n + 1
        End While
    End Sub

    Private Sub TabPage3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub save_name_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save_name.SelectedIndexChanged
        dr.Close()
        cmd.CommandText = "select * from lsave where name='" & save_name.Text & "'"
        dr = cmd.ExecuteReader
        While dr.Read
            save_code.Text = dr("code")
        End While
    End Sub

    Private Sub CheckBox16_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles er.CheckedChanged

    End Sub

    Private Sub Label16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label16.Click

        dr.Close()
        cmd.CommandText = "CREATE TABLE [dbo].[ebranch]([code] [numeric](18, 0) NULL,	[name] [varchar](50))"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "CREATE TABLE [dbo].[estat]([code] [numeric](18, 0) NULL,	[name] [varchar](50))"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "CREATE TABLE [dbo].[emang]([code] [numeric](18, 0) NULL,	[name] [varchar](50))"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "CREATE TABLE [dbo].[etm]([code] [numeric](18, 0) NULL,	[name] [varchar](50))"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "CREATE TABLE [dbo].[eedutype]([code] [numeric](18, 0) NULL,	[name] [varchar](50))"
        cmd.ExecuteNonQuery()
        MsgBox("ok")
    End Sub

    Private Sub stat_name_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles stat_name.KeyDown
        If e.KeyCode = Keys.ControlKey Then
            FSAVE(stat_name.Text, "estat", 1)
        ElseIf e.KeyCode = Keys.Delete Then
            FSAVE(stat_name.Text, "estat", 2)
        End If
        'If e.KeyCode = Keys.Enter Then pmobile.Focus()
        'If e.KeyCode = Keys.F3 Then PAFIND(stat_name.Text, "COMPANY_name")

    End Sub

    Private Sub stat_name_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stat_name.SelectedIndexChanged
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

    Private Sub branch_name_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles branch_name.GotFocus
        flng("AR")
    End Sub

    Private Sub branch_name_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles branch_name.KeyDown

        If e.KeyCode = Keys.ControlKey Then
            FSAVE(branch_name.Text, "ebranch", 1)
        ElseIf e.KeyCode = Keys.Delete Then
            FSAVE(branch_name.Text, "ebranch", 2)
        End If
    End Sub

    Private Sub branch_name_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles branch_name.SelectedIndexChanged
        If branch_name.Focused = False Then Exit Sub
        If branch_name.Text = "" Then Exit Sub
        FRC = branch.Select("NAME='" & branch_name.Text & "'")
        If FRC.Length <= 0 Then
            branch_name.Text = ""
            branch_code.Text = ""
            Exit Sub
        Else
            RC = FRC(0)
            branch_code.Text = RC("code")
            fp.Text = nulls(RC("fp"))
        End If
    End Sub

    Private Sub edutype_name_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles edutype_name.GotFocus
        flng("AR")
    End Sub

    Private Sub edutype_name_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles edutype_name.KeyDown
        If e.KeyCode = Keys.ControlKey Then
            FSAVE(edutype_name.Text, "eedutype", 1)
        ElseIf e.KeyCode = Keys.Delete Then
            FSAVE(edutype_name.Text, "eedutype", 2)
        End If
    End Sub

    Private Sub edutype_name_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edutype_name.SelectedIndexChanged
        If edutype_name.Focused = False Then Exit Sub
        If edutype_name.Text = "" Then Exit Sub
        FRC = edutype.Select("NAME='" & edutype_name.Text & "'")
        If FRC.Length <= 0 Then
            edutype_name.Text = ""
            edutype_code.Text = ""
            Exit Sub
        Else
            RC = FRC(0)
            edutype_code.Text = RC("code")
        End If
    End Sub

    Private Sub TM_NAME_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TM_NAME.GotFocus
        flng("AR")
    End Sub

    Private Sub TM_NAME_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TM_NAME.KeyDown
        If e.KeyCode = Keys.ControlKey Then
            FSAVE(tm_name.Text, "etm", 1)
        ElseIf e.KeyCode = Keys.Delete Then
            FSAVE(TM_NAME.Text, "etm", 2)
        End If
    End Sub

    Private Sub TM_NAME_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TM_NAME.SelectedIndexChanged
        If TM_NAME.Focused = False Then Exit Sub
        If TM_NAME.Text = "" Then Exit Sub
        FRC = tm.Select("NAME='" & TM_NAME.Text & "'")
        If FRC.Length <= 0 Then
            TM_NAME.Text = ""
            TM_code.Text = ""
            Exit Sub
        Else
            RC = FRC(0)
            TM_code.Text = RC("code")
        End If
    End Sub

    Private Sub mang_name_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles mang_name.GotFocus
        flng("AR")
    End Sub

    Private Sub mang_name_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mang_name.KeyDown
        If e.KeyCode = Keys.ControlKey Then
            FSAVE(mang_NAME.Text, "emang", 1)
        ElseIf e.KeyCode = Keys.Delete Then
            FSAVE(mang_name.Text, "emang", 2)
        End If
    End Sub

    Private Sub mang_name_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mang_name.SelectedIndexChanged
        If mang_name.Focused = False Then Exit Sub
        If mang_name.Text = "" Then Exit Sub
        FRC = mang.Select("NAME='" & mang_name.Text & "'")
        If FRC.Length <= 0 Then
            mang_name.Text = ""
            mang_code.Text = ""
            Exit Sub
        Else
            RC = FRC(0)
            mang_code.Text = RC("code")
        End If
    End Sub

    Private Sub GlassButton13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton13.Click
        Dim n As String = MsgBox("Â·  —Ìœ Õ›Ÿ ø", MsgBoxStyle.YesNo)
        If n = vbNo Then Exit Sub
        dr.Close()
        cmd.CommandText = "delete from ecourse where code='" & pcode.Text & "'"
        cmd.ExecuteNonQuery()
        Dim x As Integer = 0
        While Not x = course.Rows.Count
            RC = course.Rows(x)
            If RC.RowState = DataRowState.Deleted = False Then
                cmd.CommandText = " INSERT INTO [ASILLAB].[dbo].[ecourse]([course],[sdate],[place],[code]) VALUES  ('" & RC("course") & "','" & RC("sdate") & "','" & RC("place") & "','" & pcode.Text & "')"
                cmd.ExecuteNonQuery()
            End If
            x += 1
        End While
        MsgBox(" „  ⁄„·Ì… «·Õ›Ÿ ")
    End Sub

    Private Sub dcourse_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dcourse.CellContentClick

    End Sub

    Private Sub GlassButton14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton14.Click
        Dim n As String = MsgBox("Â·  —Ìœ Õ›Ÿ ø", MsgBoxStyle.YesNo)
        If n = vbNo Then Exit Sub
        dr.Close()
        cmd.CommandText = "delete from eWORK where code='" & pcode.Text & "'"
        cmd.ExecuteNonQuery()
        Dim x As Integer = 0
        While Not x = WORK.Rows.Count
            RC = WORK.Rows(x)
            If RC.RowState = DataRowState.Deleted = False Then
                cmd.CommandText = " INSERT INTO [ework]([code],[cname],[jdate],[ldate],[position],[sal],[rleaving]) VALUES  ('" & pcode.Text & "','" & RC("cname") & "','" & RC("jdate") & "','" & RC("ldate") & "','" & RC("position") & "','" & RC("sal") & "','" & RC("rleaving") & "')"
                cmd.ExecuteNonQuery()
            End If
            x += 1
        End While
        MsgBox(" „  ⁄„·Ì… «·Õ›Ÿ ")
    End Sub

    Private Sub GlassButton15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton15.Click
        OpenFileDialog1.ShowDialog()
        IPX.ImageLocation = OpenFileDialog1.FileName
        Dim oer As System.IO.FileStream
        Dim rer As IO.StreamReader
        oer = New IO.FileStream(OpenFileDialog1.FileName, IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.Read)
        rer = New IO.StreamReader(oer)
        Dim FileByteArrayr(oer.Length - 1) As Byte
        oer.Read(FileByteArrayr, 0, oer.Length)
        dr.Close()
        If IsNumeric(pcode.Text) = False Then MsgBox("«·—Ã«¡«Œ Ì«— «·„ÊŸ›") : Exit Sub
        dr.Close() : dr.Close() : cmd.CommandText = "select * from EEIMAGE where CODE='" & Val(pcode.Text) & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = False Then
            dr.Close()
            cmd.CommandText = "insert into EEIMAGE (code) values ('" & pcode.Text & "')"
            cmd.ExecuteNonQuery()
        End If
        dr.Close()
        Dim Sql As String = "update  EEIMAGE set image = ? , no = ? where  CODE='" & Val(pcode.Text) & "'"
        cmd.CommandText = Sql
        cmd.Parameters.Clear()
        cmd.Parameters.Add("@image", System.Data.OleDb.OleDbType.Binary, oer.Length).Value = FileByteArrayr
        cmd.Parameters.Add("@no", System.Data.OleDb.OleDbType.VarChar, 100).Value = oer.Length
        cmd.ExecuteNonQuery()
        MsgBox(" „  ⁄„·Ì… «·Õ›Ÿ", MsgBoxStyle.Information)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If branch_name.Text = "" Then MsgBox("«·—Ã«¡ «Œ Ì«— «·›—⁄") : Exit Sub
        Dim ss As Integer = InputBox("pass")
        If ss <> 5011545 Then Exit Sub
        dr.Close()
        cmdTEMP2.Connection = ACcn
        cmdTEMP2.CommandType = CommandType.Text
        cmdTEMP2.CommandText = "select * from qq  "
        adTEMP2.SelectCommand = cmdTEMP2
        adTEMP2.Fill(DBS, "TEMP2")
        TEMP2 = DBS.Tables("TEMP2")
        DBS.Tables("TEMP2").Clear()
        adTEMP2.Fill(DBS, "TEMP2")
        TEMP2 = DBS.Tables("TEMP2")
        ds1.DataSource = TEMP2
        Dim nn As Integer
        nn = TextBox11.Text
        Dim n As Integer
        While Not n = TEMP2.Rows.Count
            RC = TEMP2.Rows(n)
            dr.Close()
            cmd.CommandText = "select * from eemp where fcode='" & RC("id") & "' "
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = False Then GoTo mm
            pcode.Text = dr("code")
            pname.Text = dr("name")
            inh.Text = dr("inh")
            outm.Text = dr("outm")
            outh.Text = dr("outh")
            inm.Text = dr("inm")
            id.Text = dr("id")
            fcode.Text = RC("ID")
            Dim edate As Date = RC("sdate")
            Dim edate1 As Date = edate.Date + TimeSpan.FromHours(inh.Text) + TimeSpan.FromMinutes(inm.Text)
            Dim odate1 As Date = edate.Date + TimeSpan.FromHours(outh.Text) + TimeSpan.FromMinutes(outm.Text)
            Dim et As TimeSpan
            et = edate1 - edate
            dr.Close()
            Dim ot As TimeSpan = Now - Now
            Dim odate As Date
            If n + 1 < TEMP2.Rows.Count Then
                odate = TEMP2.Rows(n + 1)("sdate")
                If edate.Date = odate.Date Then
                    odate1 = odate.Date + TimeSpan.FromHours(outh.Text) + TimeSpan.FromMinutes(outm.Text)
                    n = n + 1
                    ot = odate - odate1
                Else
                    odate1 = edate.Date + TimeSpan.FromHours(outh.Text) + TimeSpan.FromMinutes(outm.Text)
                    odate = edate.Date
                End If
            Else
                odate1 = edate.Date + TimeSpan.FromHours(outh.Text) + TimeSpan.FromMinutes(outm.Text)
                odate = edate.Date
            End If
            Dim to1 As TimeSpan
            Dim s As Integer = 0
            to1 = odate - edate
            cmd.CommandText = "insert into ein ([name],[code],edate,em,eh,et,om,oh,ot,edate1,odate,odate1,sdate,ework,sal,branch_name) VALUES ('" & pname.Text & "','" & pcode.Text & "','" & ChangeFormatall(edate) & "','" & et.Minutes & "','" & et.Hours & "','" & et.TotalMinutes & "','" & ot.Minutes & "','" & ot.Hours & "','" & ot.TotalMinutes & "','" & ChangeFormatall(edate1) & "','" & ChangeFormatall(odate) & "','" & ChangeFormatall(odate1) & "','" & ChangeFormat(edate) & "','" & to1.TotalMinutes & "','" & s & "','" & branch_name.Text & "')"
            cmd.ExecuteNonQuery()
mm:
            fcode.Text = RC("id")
            n = n + 1
        End While
        Button2_Click(Button2, e)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        dr.Close()
        'cmd.CommandText = "UPDATE ein SET odate1 = sdate,edate1 = sdate FROM ein   "
        'cmd.ExecuteNonQuery()

        dr.Close()
        cmd.CommandText = "UPDATE ein SET ein.name = eemp.name, ein.sday = eemp.sday,ein.shour = eemp.shour FROM ein INNER JOIN eemp ON ein.code = eemp.code where  ein.sdate between '" & ChangeFormat(DD1.Value) & "'  and '" & ChangeFormat(DD2.Value) & "' "
        cmd.ExecuteNonQuery()

        Dim x As String = ""
        If cpcode.CheckState = CheckState.Checked Then x = " and code='" & pcode.Text & "'"

        cmdtn.Connection = CN
        cmdtn.CommandType = CommandType.Text
        cmdtn.CommandText = "select * from ein WHERE   sdate between '" & ChangeFormat(DD1.Value) & "'  and '" & ChangeFormat(DD2.Value) & "' and branch_name='" & branch_name.Text & "' " & x & " order by code , sdate "
        adtn.SelectCommand = cmdtn
        adtn.Fill(DBS, "tn")
        tn = DBS.Tables("tn")
        DBS.Tables("tn").Clear()
        adtn.Fill(DBS, "tn")
        tn = DBS.Tables("tn")
        ds1.DataSource = tn
        Dim v As Integer = 0
        While Not v = ds1.Columns.Count
            ds1.Columns(v).Visible = False
            v = v + 1
        End While
        ds1.Columns("name").Visible = True
        ds1.Columns("edate").Visible = True
        ds1.Columns("edate").HeaderText = " «—ÌŒ «·œŒÊ·"
        ds1.Columns("et").Visible = True
        ds1.Columns("et").Width = 50
        ds1.Columns("et").HeaderText = "Êﬁ  «·œŒÊ·"
        ds1.Columns("ot").Visible = True
        ds1.Columns("ot").Width = 50
        ds1.Columns("ot").HeaderText = "Êﬁ  «·Œ—ÊÃ"
        ds1.Columns("odate").Visible = True
        ds1.Columns("odate").HeaderText = " «—ÌŒ «·Œ—ÊÃ"
        ds1.Columns("ot").Visible = True
        ds1.Columns("sal").HeaderText = "«÷«›Ï "
        ds1.Columns("sal").Width = 50
        ds1.Columns("sal").Visible = True
        ds1.Columns("sal1").HeaderText = "Œ’„"
        ds1.Columns("sal1").Width = 50
        ds1.Columns("sal1").Visible = True
        ds1.Columns("notse").HeaderText = "„·«ÕŸ« "
        ds1.Columns("notse").Visible = True
        ds1.Columns("ov").Visible = True
        ds1.Columns("ov").HeaderText = "overtime"
        ds1.Columns("ov").Width = 50
        Dim n As Integer = 0
        While Not n = ds1.RowCount
            If ds1(("st"), n).Value = 5 Or ds1(("st"), n).Value = 6 Then
                ds1.Rows(n).DefaultCellStyle.BackColor = Color.LightGreen
            ElseIf nulls(ds1(("notse"), n).Value) = " OFF " Then
                ds1.Rows(n).DefaultCellStyle.BackColor = Color.DarkGreen
            ElseIf ds1(("st"), n).Value = 1 Or ds1(("st"), n).Value = 2 Then
                ds1.Rows(n).DefaultCellStyle.BackColor = Color.LightSkyBlue
            ElseIf ds1(("st"), n).Value = 7 Then
                ds1.Rows(n).DefaultCellStyle.BackColor = Color.Silver
            End If
            n = n + 1
        End While
        Dim oj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        oj.Load(Application.StartupPath & "\TOTAL IN.rpt")
        oj.Database.Tables(0).SetDataSource(tn)
        rp.CrystalReportViewer1.ReportSource = oj
        rp.Show() : rp.Focus()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        cmdb.DataAdapter = adtn
        adtn.Update(DBS, "tn")
        MsgBox(" „ «·Õ›Ÿ")

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If branch_name.Text = "" Then MsgBox("«·—Ã«¡ «Œ Ì«— «·›—⁄") : Exit Sub
        Dim ss As Integer = InputBox("pass")
        If ss <> 5011545 Then Exit Sub
        Dim n As Integer
        n = 0
        While Not n = tn.Rows.Count
            RC = tn.Rows(n)
            dr.Close()
            cmd.CommandText = "select * from eemp where code='" & RC("code") & "'  and branch_name='" & branch_name.Text & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = False Then GoTo mm
            pcode.Text = dr("code")
            pname.Text = dr("name")
            inh.Text = dr("inh")
            outm.Text = dr("outm")
            outh.Text = dr("outh")
            inm.Text = dr("inm")
            id.Text = dr("id")
            emp1.Text = dr("emp1")
            emp2.Text = dr("emp2")
            Dim odate1 As Date = RC("odate1")
            Dim edate1 As Date = RC("odate")
            RC("odate1") = odate1.Date + TimeSpan.FromHours(outh.Text) + TimeSpan.FromMinutes(outm.Text)
            RC("edate1") = odate1.Date + TimeSpan.FromHours(inh.Text) + TimeSpan.FromMinutes(inm.Text)
            RC.EndEdit()

mm:
            n = n + 1
        End While
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If branch_name.Text = "" Then MsgBox("«·—Ã«¡ «Œ Ì«— «·›—⁄") : Exit Sub
        Dim ss As Integer = InputBox("pass")
        If ss <> 5011545 Then Exit Sub

        'ACdr.Close()
        'ACcmd.CommandText = "SELECT * FROM QQ where e=2"
        'ACdr = ACcmd.ExecuteReader
        'While ACdr.Read
        '    fcode.Text = ACdr("ID") + 300
        '    Dim edate As Date = ACdr("SDATE") & "  " & ACdr("TIME1")

        '    acdr1.Close()
        '    accmd1.CommandText = "insert into qq(id,sdate) values ('" & fcode.Text & "','" & edate & "') "
        '    accmd1.ExecuteNonQuery()
        '    If ACdr("time2") <> "1" Then
        '        Dim odate As Date = ACdr("SDATE") & "  " & ACdr("TIME2")
        '        accmd1.CommandText = "insert into qq(id,sdate) values ('" & fcode.Text & "','" & odate & "') "
        '        accmd1.ExecuteNonQuery()
        '    End If
        'End While
        ACdr.Close()
        ACcmd.CommandText = "update qq set id=id+300"
        ACcmd.ExecuteNonQuery()
        Button10_Click(Button10, e)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ss1 As Integer = InputBox("pass")
        If ss1 <> 5011545 Then Exit Sub
        Dim n As Integer
        n = 0
        While Not n = tn.Rows.Count
            RC = tn.Rows(n)
            dr.Close()
            cmd.CommandText = "select * from eemp where code='" & RC("code") & "'  and branch_name='" & branch_name.Text & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = False Then GoTo mm
            pcode.Text = dr("code")
            pname.Text = dr("name")
            inh.Text = dr("inh")
            outm.Text = dr("outm")
            outh.Text = dr("outh")
            inm.Text = dr("inm")
            id.Text = dr("id")
            emp1.Text = dr("emp1")
            emp2.Text = dr("emp2")
            Dim odate1 As Date = RC("odate1")
            Dim edate As Date = RC("edate")
            Dim edate1 As Date = RC("edate1")
            Dim odate As Date = RC("odate")
            Dim s As Double = 0
            Dim sal1 As Double = 0
            Dim ss As Double = 0
            Dim notss As String = ""
            Dim et As TimeSpan = edate1 - edate
            Dim ot As TimeSpan = odate - odate1
            Dim ttt As Integer = 0
            ss = 0
            Dim ett As Integer = 0
            Dim ett1 As Double = 0
            If Math.Abs(et.TotalMinutes) > 15 + emp1.Text Then
                ett = et.TotalMinutes + 15 + emp1.Text
                If ett < -1 Then ett1 = 0.25 : notss = "late ??"
                If ett < -15 And ett > -30 Then ett1 = 0.25 : notss = "late ??"
                If ett <= -30 And ett > -60 Then ett1 = 0.5 : notss = "late ??"
                If ett <= -60 Then ett1 = 1 : notss = "late ??"
            End If

            If emp1.Text = 0 Or emp2.Text = 0 Then
                If ot.TotalMinutes < 0 Then
                    notss = notss & " leave early ??? "
                    ett1 = ett1 + 0.25
                ElseIf ot.TotalMinutes - 15 > 0 Then
                    notss = notss & " over itme ! "
                    ss = ss + ot.TotalMinutes - 15
                End If
            ElseIf emp2.Text > 0 Then
                If Math.Abs(et.TotalMinutes) <= 15 Then
                    If ot.TotalMinutes < 0 Then
                        notss = notss & " leave early ??? "
                        ett1 = ett1 + 0.25
                    ElseIf ot.TotalMinutes - 15 > 0 Then
                        notss = notss & " over itme ! "
                        ss = ss + ot.TotalMinutes - 15
                    End If
                ElseIf Math.Abs(et.TotalMinutes) >= 15 Then
                    If Math.Abs(et.TotalMinutes) <= emp1.Text + 15 Then ttt = 0 Else ttt = emp1.Text
                    If ot.TotalMinutes - Math.Abs(et.TotalMinutes) < ttt Then
                        notss = notss & " leave early ??? "
                        ett1 = ett1 + 0.25
                    ElseIf ot.TotalMinutes - Math.Abs(et.TotalMinutes) > ttt Then
                        notss = notss & " over itme ! "
                        ss = ss + Math.Abs(ot.TotalMinutes) - Math.Abs(et.TotalMinutes)
                    End If
                End If
            End If
            '            RC("em") =
            'RC("eh") =
            'RC("om") =
            'RC("oh") =
            RC("sal1") = ett1
            RC("sal") = ss * 2
            RC("notse") = RC("notse") & notss
            RC.EndEdit()

mm:
            n = n + 1
        End While

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles qqa111.Click
        dr.Close()
        'cmd.CommandText = "UPDATE ein SET odate1 = sdate,edate1 = sdate FROM ein   "
        'cmd.ExecuteNonQuery()

        Dim x As String = ""
        If cpcode.CheckState = CheckState.Checked Then x = " and code='" & pcode.Text & "'"

        cmdtn.Connection = CN
        cmdtn.CommandType = CommandType.Text
        cmdtn.CommandText = "select * from ein WHERE   sdate between '" & ChangeFormat(DD1.Value) & "'  and '" & ChangeFormat(DD2.Value) & "' order by code , sdate "
        adtn.SelectCommand = cmdtn
        adtn.Fill(DBS, "tn")
        tn = DBS.Tables("tn")
        DBS.Tables("tn").Clear()
        adtn.Fill(DBS, "tn")
        tn = DBS.Tables("tn")


        Dim oj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        oj.Load(Application.StartupPath & "\TOTAL INs.rpt")
        oj.Database.Tables(0).SetDataSource(tn)
        rp.CrystalReportViewer1.ReportSource = oj
        rp.Show() : rp.Focus()
    End Sub

    Private Sub GlassButton17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton17.Click
        If pcode.Text = "" Or pname.Text = "" Then MsgBox("«·—Ã«¡ «Œ Ì«— «·„ÊŸ› ", MsgBoxStyle.Exclamation) : Exit Sub
        If acode.Text = "" Then MsgBox("«·—Ã«¡ ÷€ÿ ÃœÌœ ", MsgBoxStyle.Exclamation) : Exit Sub
        'If ChangeFormat(adate1.Value) <= ChangeFormat(adate2.Value) Then MsgBox("«·—Ã«¡ «· √ﬂœ  «—ÌŒ «·«Ã«“…", MsgBoxStyle.Information) : Exit Sub
        If av_type.Text <> "-" Then
            dr.Close()
            cmd.CommandText = "SELECT SUM(ALONG) FROM eagaza WHERE ADATE1 between '" & ChangeFormat("1/1/" & DD1.Value.Year) & "'  and '" & ChangeFormat(Now) & "' AND AV_TYPE='" & av_type.Text & "' AND EMP_CODE='" & CODE1.Text & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            dr1.Close()
            cmd1.CommandText = "SELECT * FROM EAVQ WHERE  AV_NAME='" & av_type.Text & "' AND EMP_CODE='" & CODE1.Text & "' "
            dr1 = cmd1.ExecuteReader
            dr1.Read()
            If dr.HasRows = False Or dr1.HasRows = False Then GoTo SS
            MsgBox("⁄œœ «Ì«„ " & av_type.Text & " «· Ï  „ «” Œœ„Â«:- " & dr(0) & " >>>>>> „‰ ⁄œœ " & dr1("QUN"))
            MsgBox("⁄œœ «·«Ì«„ «·»«ﬁ… „‰ " & av_type.Text & ">>>>>>>>>>>>>>>>>>     " & nulls(dr1("QUN")) - nulls(dr(0)))
            If nulls(dr1("QUN")) - nulls(dr(0)) - along.Text < 0 Then MsgBox("·Ì” ·œÌﬂ —’Ìœ ﬂ«›Ï") : Exit Sub

        End If
SS:
        dr.Close()
        cmd.CommandText = "select * from eagaza where acode='" & acode.Text & "'"
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            dr.Close()
            Dim n As String
            n = ""
            If empa = 0 Then MsgBox("·Ì” ·œÌﬂ ’·«ÕÌ… «· ⁄œÌ·") : Exit Sub
            n = MsgBox("Â·  —Ìœ  ⁄œÌ· «·«Ã«“… ø", MsgBoxStyle.YesNo)
            If n = vbNo Then Exit Sub
            cmd.CommandText = "delete from eagaza where acode='" & acode.Text & "'"
            cmd.ExecuteNonQuery()
            cmd.CommandText = "delete from egzd where code='" & acode.Text & "'"
            cmd.ExecuteNonQuery()
        Else
            Dim D As String = ""
            If av_type.Text = "-" Then D = ap_type.Text Else D = av_type.Text
            Dim x1 As String = ""
            x1 = "«”„ «·„ÊŸ›  :  " & pname.Text
            x1 = x1 & Environment.NewLine & "«·ﬁ«∆„ »«·⁄„·   :  " & aeworker.Text
            x1 = x1 & Environment.NewLine & "‰Ê⁄ «·ÿ·»    :  " & D
            x1 = x1 & Environment.NewLine & "«·„·«ÕŸ«     :  " & anotse.Text
            x1 = x1 & Environment.NewLine & "«· «—ÌŒ    :  " & adate1.Value.Date
            Dim x2 As String = ""
            If DEMAIL.Text.Length > 4 Then x2 = "," & DEMAIL.Text
            semail(pvemail & x2, pname.Text & "  :- " & D & " :-" & adate1.Value.Date, x1, 0, 0)
        End If
        dr.Close()
        cmd.CommandText = "INSERT INTO [dbo].[eagaza](SHIFT_NAME,[asdate],[aeworker],[av_type],[ap_type],[adate1],[adate2],[along],[anotse],[awrite],[agm],[adm],[acode],emp_code,emp_name)VALUES ('" & SHIFT_NAME.Text & "','" & ChangeFormat(asdate.Value) & "','" & aeworker.Text & "','" & av_type.Text & "','" & ap_type.Text & "','" & ChangeFormat(adate1.Value) & "','" & ChangeFormat(adate2.Value) & "','" & along.Text & "','" & anotse.Text & "','" & Val(awrite.CheckState) & "','" & Val(agm.CheckState) & "','" & Val(adm.CheckState) & "','" & acode.Text & "','" & pcode.Text & "','" & pname.Text & "')"
        cmd.ExecuteNonQuery()
        Dim dd As Date = adate1.Value
        Dim x As Integer = 0
        While Not x = Val(along.Text)
            cmd.CommandText = "INSERT INTO [dbo].[egzd] ([code],[emp_code],[sdate],[av_type],[ap_type]) VALUES ('" & acode.Text & "','" & pcode.Text & "','" & ChangeFormat(dd.AddDays(x)) & "','" & av_type.Text & "','" & ap_type.Text & "')"
            cmd.ExecuteNonQuery()
            x = x + 1
        End While
        GlassButton16_Click(GlassButton16, e)
        MsgBox("saved ok", MsgBoxStyle.Information)
    End Sub

    Private Sub arm_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles arm.SelectedIndexChanged

    End Sub

    Private Sub av_type_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles av_type.KeyDown
        If e.KeyCode = Keys.ControlKey Then
            FSAVE(av_type.Text, "av_type", 1)
        ElseIf e.KeyCode = Keys.Delete Then
            FSAVE(av_type.Text, "av_type", 2)
        End If
    End Sub


    Private Sub av_type_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles av_type.SelectedIndexChanged
        If av_type.Text.Length > 2 Then ap_type.Text = "-"
        If av_type.Focused = True Then
            dr.Close()
            cmd.CommandText = "SELECT * FROM av_type WHERE NAME='" & av_type.Text & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            EMP.Text = dr("EMP")

        End If
    End Sub

    Private Sub weekend_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles weekend.SelectedIndexChanged

    End Sub

    Private Sub regl_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles regl.SelectedIndexChanged

    End Sub

    Private Sub ap_type_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ap_type.GotFocus
        flng("AR")
    End Sub

    Private Sub ap_type_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ap_type.KeyDown
        If e.KeyCode = Keys.ControlKey Then
            FSAVE(ap_type.Text, "ap_type", 1)
        ElseIf e.KeyCode = Keys.Delete Then
            FSAVE(ap_type.Text, "ap_type", 2)
        End If
    End Sub

    Private Sub ap_type_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ap_type.SelectedIndexChanged
        If ap_type.Text.Length > 2 Then av_type.Text = "-"
    End Sub

    Private Sub aeworker_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles aeworker.GotFocus
        flng("AR")
    End Sub

    Private Sub eworker_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles aeworker.SelectedIndexChanged
        If av_type.Text.Length > 2 Then ap_type.Text = "-"
    End Sub

    Private Sub GlassButton16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton16.Click
        If pcode.Text = "" Or pname.Text = "" Then MsgBox("«·—Ã«¡ «Œ Ì«— «·„ÊŸ› ", MsgBoxStyle.Exclamation) : Exit Sub
        dr.Close()
        along.Text = 1
        'cmd.CommandText = "CREATE TABLE egzd([code] [numeric](18, 0) NULL,[emp_code] [int] NULL,[sdate] [date] NULL) "
        'cmd.ExecuteNonQuery()
        dr.Close()
        cmd.CommandText = "select max(acode) from eagaza  "
        dr = cmd.ExecuteReader
        dr.Read()
        If IsDBNull(dr(0)) = False Then acode.Text = 1 + dr(0) Else acode.Text = 1
        ListBox1.Items.Clear()
        If empa = 1 Then
            dr.Close()
            cmd.CommandText = "select av_type,sum(along) from eagaza where ap_type='-' and emp_code='" & pcode.Text & "' group by av_type"
            dr = cmd.ExecuteReader
            While dr.Read
                ListBox1.Items.Add(dr(0) & "   - " & dr(1))
            End While
            dr.Close()
            cmd.CommandText = "select ap_type,count(along) from eagaza where av_type='-' and emp_code='" & pcode.Text & "' group by ap_type"
            dr = cmd.ExecuteReader
            While dr.Read
                ListBox1.Items.Add(dr(0) & "  - " & dr(1))
            End While
            cmdagz.Connection = CN
            cmdagz.CommandType = CommandType.Text
            cmdagz.CommandText = "select * from eagaza  WHERE  emp_code='" & pcode.Text & "' order by acode"
            adagz.SelectCommand = cmdagz
            adagz.Fill(DBS, "agz")
            agz = DBS.Tables("agz")
            DBS.Tables("agz").Clear()
            adagz.Fill(DBS, "agz")
            agz = DBS.Tables("agz")
            brpd.DataSource = agz
            d1 = 2
        End If
        dr.Close()
        cmd.CommandText = "SELECT SUM(ALONG) FROM eagaza WHERE ADATE1 between '" & ChangeFormat("1/1/" & DD1.Value.Year) & "'  and '" & ChangeFormat(Now) & "' AND AV_TYPE='" & av_type.Text & "' AND EMP_CODE='" & CODE1.Text & "'"
        dr = cmd.ExecuteReader
        dr.Read()
        dr1.Close()
        cmd1.CommandText = "SELECT * FROM EAVQ WHERE  AV_NAME='" & av_type.Text & "' AND EMP_CODE='" & CODE1.Text & "' "
        dr1 = cmd1.ExecuteReader
        dr1.Read()
        If dr1.HasRows = True And Val(EMP.Text) = 1 Then
            MsgBox("⁄œœ «Ì«„ " & av_type.Text & " «· Ï  „ «” Œœ„Â«:- " & nulls(dr(0)) & " >>>>>> „‰ ⁄œœ " & nulls(dr1("QUN")))
            MsgBox("⁄œœ «·«Ì«„ «·»«ﬁ… „‰ " & av_type.Text & ">>>>>>>>>>>>>>>>>>     " & nulls(dr1("QUN") - nulls(dr(0))))

        End If
    End Sub

    Private Sub adate1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles adate1.Leave
        egz = adate2.Value - adate1.Value
        along.Text = Math.Round(egz.TotalDays, 0) + 1
    End Sub

    Private Sub adate1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles adate1.ValueChanged
        egz = adate2.Value - adate1.Value
        along.Text = Math.Round(egz.TotalDays, 0) + 1

    End Sub

    Private Sub adate2_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles adate2.Leave
        egz = adate2.Value - adate1.Value
        along.Text = Math.Round(egz.TotalDays, 0) + 1
    End Sub

    Private Sub adate2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles adate2.ValueChanged
        egz = adate2.Value - adate1.Value
        along.Text = Math.Round(egz.TotalDays, 0) + 1

    End Sub

    Private Sub address_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles address.GotFocus
        flng("AR")
    End Sub

    Private Sub address_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles address.TextChanged

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If sname = pname.Text Then
            If pname.Text = "" Then Exit Sub
            cmdeemp.Connection = CN
            cmdeemp.CommandType = CommandType.Text
            cmdeemp.CommandText = "select * from eemp WHERE name LIKE '%" & pname.Text & "%'"
            adeemp.SelectCommand = cmdeemp
            adeemp.Fill(DBS, "eemp")
            eemp = DBS.Tables("eemp")
            DBS.Tables("eemp").Clear()
            adeemp.Fill(DBS, "eemp")
            eemp = DBS.Tables("eemp")
            brpd.DataSource = eemp
            Dim v As Integer = 0
            While Not v = brpd.Columns.Count
                brpd.Columns(v).Visible = False
                v = v + 1
            End While
            brpd.Columns("NAME").Visible = True
            brpd.Columns("NAME").HeaderText = "«·„ÊŸ›"
            brpd.Columns("NAME").Width = 300
        End If

    End Sub

    Private Sub Button7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If branch_name.Text = "" Then MsgBox("«·—Ã«¡ «Œ Ì«— «·›—⁄") : Exit Sub
        Dim ss As Integer = InputBox("pass")
        If ss <> 5011545 Then Exit Sub
        dr.Close()
        'cmd.CommandText = "delete from ein where sdate between '" & ChangeFormat(DD1.Value) & "' and '" & ChangeFormat(DD2.Value) & "'"
        'cmd.ExecuteNonQuery()
        ACdr.Close()
        ACcmd.CommandText = "update qq set id=id+200"
        ACcmd.ExecuteNonQuery()
        Button10_Click(Button10, e)
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If branch_name.Text = "" Then MsgBox("«·—Ã«¡ «Œ Ì«— «·›—⁄") : Exit Sub
        Dim ss As Integer = InputBox("pass")
        If ss <> 5011545 Then Exit Sub
        ''ACdr.Close()
        ''ACcmd.CommandText = "SELECT * FROM QQ where e=2"
        ''ACdr = ACcmd.ExecuteReader
        ''While ACdr.Read5
        ''    fcode.Text = ACdr("ID") + 400
        ''    Dim edate As Date = ACdr("SDATE") & "  " & ACdr("TIME1")
        ''    acdr1.Close()
        ''    accmd1.CommandText = "insert into qq(id,sdate) values ('" & fcode.Text & "','" & edate & "') "
        ''    accmd1.ExecuteNonQuery()
        ''    If ACdr("time2") <> "1" Then
        ''        Dim odate As Date = ACdr("SDATE") & "  " & ACdr("TIME2")
        ''        accmd1.CommandText = "insert into qq(id,sdate) values ('" & fcode.Text & "','" & odate & "') "
        ''        accmd1.ExecuteNonQuery()
        ''    End If
        ''End While
        ''ACdr.Close()
        ''ACcmd.CommandText = "delete * from qq where e=2"
        ''ACcmd.ExecuteNonQuery()
        ACdr.Close()
        ACcmd.CommandText = "update qq set id=id+400"
        ACcmd.ExecuteNonQuery()
        Button10_Click(Button10, e)
    End Sub

    Private Sub asdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles asdate.ValueChanged
        adate2.Value = asdate.Value
        adate1.Value = asdate.Value
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        dr.Close()
        cmd.CommandText = "select * from eemp where srun =1"
        dr = cmd.ExecuteReader
        Dim n As Integer
        Dim ndate As Date = DD1.Value
        While dr.Read
            pcode.Text = dr("code")
            pname.Text = dr("name")
            inh.Text = dr("inh")
            outm.Text = dr("outm")
            outh.Text = dr("outh")
            inm.Text = dr("inm")
            id.Text = dr("id")
            fcode.Text = RC("ID")
            Dim edate As Date = RC("sdate")
            Dim edate1 As Date = edate.Date + TimeSpan.FromHours(inh.Text) + TimeSpan.FromMinutes(inm.Text)
            Dim odate1 As Date = edate.Date + TimeSpan.FromHours(outh.Text) + TimeSpan.FromMinutes(outm.Text)
            Dim et As TimeSpan
            et = edate1 - edate
            dr.Close()
            Dim ot As TimeSpan = Now - Now
            Dim odate As Date
            If n + 1 < TEMP2.Rows.Count Then
                odate = TEMP2.Rows(n + 1)("sdate")
                If edate.Date = odate.Date Then
                    odate1 = odate.Date + TimeSpan.FromHours(outh.Text) + TimeSpan.FromMinutes(outm.Text)
                    n = n + 1
                    ot = odate - odate1
                Else
                    odate1 = edate.Date + TimeSpan.FromHours(outh.Text) + TimeSpan.FromMinutes(outm.Text)
                    odate = edate.Date
                End If
            Else
                odate1 = edate.Date + TimeSpan.FromHours(outh.Text) + TimeSpan.FromMinutes(outm.Text)
                odate = edate.Date
            End If
            Dim to1 As TimeSpan
            Dim s As Integer = 0
            to1 = odate - edate
            cmd.CommandText = "insert into ein ([name],[code],edate,em,eh,et,om,oh,ot,edate1,odate,odate1,sdate,ework,sal,branch_name) VALUES ('" & pname.Text & "','" & pcode.Text & "','" & ChangeFormatall(edate) & "','" & et.Minutes & "','" & et.Hours & "','" & et.TotalMinutes & "','" & ot.Minutes & "','" & ot.Hours & "','" & ot.TotalMinutes & "','" & ChangeFormatall(edate1) & "','" & ChangeFormatall(odate) & "','" & ChangeFormatall(odate1) & "','" & ChangeFormat(edate) & "','" & to1.TotalMinutes & "','" & s & "','" & branch_name.Text & "')"
            cmd.ExecuteNonQuery()
mm:
            fcode.Text = RC("id")
            n = n + 1
        End While
    End Sub

    Private Sub GlassButton18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton18.Click
        If empa = 0 Then MsgBox("·Ì” ·œÌﬂ ’·«ÕÌ… «· ⁄œÌ·") : Exit Sub

        If pcode.Text = "" Or pname.Text = "" Then MsgBox("«·—Ã«¡ «Œ Ì«— «·„ÊŸ› ", MsgBoxStyle.Exclamation) : Exit Sub
        If acode.Text = "" Then MsgBox("«·—Ã«¡ ÷€ÿ ÃœÌœ ", MsgBoxStyle.Exclamation) : Exit Sub
        If ChangeFormat(adate1.Value) > ChangeFormat(adate2.Value) Then MsgBox("«·—Ã«¡ «· √ﬂœ  «—ÌŒ «·«Ã«“…", MsgBoxStyle.Information) : Exit Sub
        dr.Close()
        cmd.CommandText = "select * from eagaza where acode='" & acode.Text & "'"
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            dr.Close()
            Dim n As String
            n = ""
            n = MsgBox("Â·  —Ìœ «·Õ–› «·«Ã«“… ø", MsgBoxStyle.YesNo)
            If n = vbNo Then Exit Sub
            cmd.CommandText = "delete from eagaza where acode='" & acode.Text & "'"
            cmd.ExecuteNonQuery()
            cmd.CommandText = "delete from egzd where code='" & acode.Text & "'"
            cmd.ExecuteNonQuery()
        End If
        MsgBox(" „  ⁄„·Ì… «·Õ–›", MsgBoxStyle.Information)
    End Sub

    Private Sub qqqqqqq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles qqqqqqq.Click
        If branch_name.Text = "" Then MsgBox("«·—Ã«¡ «Œ Ì«— «·›—⁄") : Exit Sub
        Dim ss As Integer = InputBox("pass")
        If ss <> 5011545 Then Exit Sub
        ffp()
    End Sub
    Public Sub ffp()
        Dim x As String = ""
        If cpcode.CheckState = CheckState.Checked Then x = " and code='" & pcode.Text & "'"
        dr.Close()
        dr1.Close()
        cmd.CommandText = "SELECT * FROM EEMP WHERE SRUN=1 and branch_name='" & branch_name.Text & "' " & x
        dr = cmd.ExecuteReader
        While dr.Read
            pcode.Text = dr("code")
            pname.Text = dr("name")
            inh.Text = dr("inh")
            outm.Text = dr("outm")
            outh.Text = dr("outh")
            inm.Text = dr("inm")
            id.Text = dr("id")
            fcode.Text = dr("FCODE")
            fcode.Text = dr("FCODE")
            branch_name.Text = dr("branch_name")
            shour.Text = dr("shour")
            sday.Text = dr("sday")
            Dim NX As Date = ChangeFormat(DD1.Value)
            While Not ChangeFormat(NX) = ChangeFormat(DD2.Value.AddDays(1))
                Dim edate As Date = NX
                Dim edate1 As Date = edate.Date + TimeSpan.FromHours(inh.Text) + TimeSpan.FromMinutes(inm.Text)
                Dim odate1 As Date = edate.Date + TimeSpan.FromHours(outh.Text) + TimeSpan.FromMinutes(outm.Text)
                Dim et As TimeSpan
                et = edate1 - edate
                dr1.Close()
                Dim ot As TimeSpan = Now - Now
                Dim odate As Date = NX
                odate1 = edate.Date + TimeSpan.FromHours(outh.Text) + TimeSpan.FromMinutes(outm.Text)
                odate = edate.Date
                Dim to1 As TimeSpan
                Dim s As Integer = 0
                to1 = odate - edate
                Dim xx As String = ""
                If NX.DayOfWeek = DayOfWeek.Friday Then xx = " OFF "
                cmd1.CommandText = "insert into ein ([name],[code],edate,em,eh,et,om,oh,ot,edate1,odate,odate1,sdate,ework,sal,branch_name,shour,sday,notse,fcode) VALUES ('" & pname.Text & "','" & pcode.Text & "','" & ChangeFormatall(edate) & "','0','0','0','0','0','0','" & ChangeFormatall(edate1) & "','" & ChangeFormatall(odate) & "','" & ChangeFormatall(odate1) & "','" & ChangeFormat(edate) & "','" & to1.TotalMinutes & "','0','" & branch_name.Text & "','" & shour.Text & "','" & sday.Text & "','" & xx & "','" & fcode.Text & "')"
                cmd1.ExecuteNonQuery()
                NX = NX.AddDays(1)
            End While
        End While
    End Sub
    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        If branch_name.Text = "" Then MsgBox("«·—Ã«¡ «Œ Ì«— «·›—⁄") : Exit Sub
        Dim ss As Integer = InputBox("pass")
        If ss <> 5011545 Then Exit Sub
        ffp()
        Dim x As String = ""
        If cpcode.CheckState = CheckState.Checked Then x = " and code='" & pcode.Text & "'"
        ACdr.Close()
        ACcmd.CommandText = "update qq set id=id+" & Val(fp.Text)
        ACcmd.ExecuteNonQuery()
        dr.Close()
        ACdr.Close()
        cmdog.Connection = ACcn
        cmdTEMP2.Connection = CN
        cmdTEMP2.CommandType = CommandType.Text
        cmdTEMP2.CommandText = "select * from ein where  sdate between '" & ChangeFormat(DD1.Value) & "' and '" & ChangeFormat(DD2.Value) & "'  " & x & "  and branch_name='" & branch_name.Text & "' order by name,sdate "
        adTEMP2.SelectCommand = cmdTEMP2
        adTEMP2.Fill(DBS, "TEMP2")
        TEMP2 = DBS.Tables("TEMP2")
        DBS.Tables("TEMP2").Clear()
        adTEMP2.Fill(DBS, "TEMP2")
        TEMP2 = DBS.Tables("TEMP2")
        ds1.DataSource = TEMP2
        Dim nn As Integer
        nn = TextBox11.Text
        Dim n As Integer
        While Not n = TEMP2.Rows.Count
            RC = TEMP2.Rows(n)
            ACdr.Close()
            ACcmd.CommandText = "select count(sdate) from qq where id=" & RC("fcode") & " and int([sdate])=#" & ChangeFormat(RC("sdate")) & "#"
            ACdr = ACcmd.ExecuteReader
            ACdr.Read()
            If nulls(ACdr(0)) = 2 Then
                ACdr.Close()
                ACcmd.CommandText = "select * from qq where id=" & RC("fcode") & " and int([sdate])=#" & ChangeFormat(RC("sdate")) & "# order by sdate"
                ACdr = ACcmd.ExecuteReader
                ACdr.Read()
                Dim edate As Date = ACdr("sdate")
                Dim edate1 As Date = RC("edate1")
                Dim odate1 As Date = RC("odate1")
                Dim et As TimeSpan
                et = edate1 - edate
                ACdr.Read()
                Dim ot As TimeSpan = Now - Now
                Dim odate As Date
                odate = ACdr("sdate")
                ot = odate - odate1
                Dim to1 As TimeSpan
                Dim s As Integer = 0
                to1 = odate - edate
                RC.BeginEdit()
                RC("em") = et.Minutes
                RC("eh") = et.Hours
                RC("et") = et.TotalMinutes
                RC("om") = ot.Minutes
                RC("oh") = ot.Hours
                RC("ot") = ot.TotalMinutes
                RC("odate") = odate
                RC("edate") = edate
                RC("ework") = to1.TotalMinutes
                RC.EndEdit()
            ElseIf nulls(ACdr(0)) = 1 Then
                ACdr.Close()
                ACcmd.CommandText = "select * from qq where id=" & RC("fcode") & " and int([sdate])=#" & ChangeFormat(RC("sdate")) & "# order by sdate"
                ACdr = ACcmd.ExecuteReader
                ACdr.Read()
                Dim edate As Date = ACdr("sdate")
                Dim edate1 As Date = RC("edate1")
                Dim odate1 As Date = RC("odate1")
                Dim et As TimeSpan
                et = edate1 - edate
                Dim ot As TimeSpan
                Dim odate As Date
                odate = ACdr("sdate")
                ot = odate - odate1
                Dim to1 As TimeSpan
                Dim s As Integer = 0
                to1 = odate - edate
                If Math.Abs(ot.TotalMinutes) > Math.Abs(et.TotalMinutes) Then
                    RC.BeginEdit()
                    RC("em") = et.Minutes
                    RC("eh") = et.Hours
                    RC("et") = et.TotalMinutes
                    RC("edate") = edate
                    RC("notse") = " FP (OUT) "
                    RC("st") = 1
                    RC.EndEdit()
                Else
                    RC.BeginEdit()
                    RC("om") = ot.Minutes
                    RC("oh") = ot.Hours
                    RC("ot") = ot.TotalMinutes
                    RC("odate") = odate
                    RC("notse") = " FP (IN) "
                    RC("st") = 2
                    RC.EndEdit()
                End If
            ElseIf nulls(ACdr(0)) > 2 Then
                cmdog.CommandText = "select * from qq where id=" & RC("fcode") & " and int([sdate])=#" & ChangeFormat(RC("sdate")) & "# order by sdate "
                adog.SelectCommand = cmdog
                adog.Fill(DBS, "og")
                og = DBS.Tables("og")
                DBS.Tables("og").Clear()
                adog.Fill(DBS, "og")
                og = DBS.Tables("og")
                Dim edate As Date = og.Rows(0).Item("sdate")
                Dim edate1 As Date = RC("edate1")
                Dim odate1 As Date = RC("odate1")
                Dim et As TimeSpan
                et = edate1 - edate
                ACdr.Read()
                Dim ot As TimeSpan = Now - Now
                Dim odate As Date
                odate = og.Rows(og.Rows.Count - 1).Item("sdate")
                ot = odate - odate1
                Dim to1 As TimeSpan
                Dim s As Integer = 0
                to1 = odate - edate
                Dim xa As Integer = 1
                Dim xt As String = ""
                Dim xd As Date
                While Not xa = og.Rows.Count - 1
                    xd = og.Rows(xa).Item("sdate")
                    xt = xt & " :> " & xd.Hour & ":" & xd.Minute
                    xa = xa + 1
                End While
                RC.BeginEdit()
                RC("em") = et.Minutes
                RC("eh") = et.Hours
                RC("et") = et.TotalMinutes
                RC("om") = ot.Minutes
                RC("oh") = ot.Hours
                RC("ot") = ot.TotalMinutes
                RC("odate") = odate
                RC("edate") = edate
                RC("ework") = to1.TotalMinutes
                RC("notse") = xt
                RC("st") = 4
                RC.EndEdit()
            Else
                Dim od As Date = RC("sdate")
                If od.DayOfWeek <> DayOfWeek.Friday Then
                    dr.Close()
                    cmd.CommandText = "select * from v_egzv where  sdate ='" & ChangeFormat(RC("sdate")) & "' and emp_code='" & RC("code") & "'"
                    dr = cmd.ExecuteReader
                    If dr.HasRows = True Then
                        dr.Read()
                        RC.BeginEdit()
                        RC("notse") = dr("nen") & " > ( " & RC("sdate") & " ) "
                        RC("st") = 5
                        RC.EndEdit()
                    Else
                        RC.BeginEdit()
                        RC("notse") = "Absent"
                        RC("st") = 6
                        RC.EndEdit()
                    End If
                End If
            End If
            If RC("st") <> 5 And RC("st") <> 6 And RC("notse") <> " OFF " Then
                dr.Close()
                dr.Close()
                cmd.CommandText = "select * from eemp where code='" & RC("code") & "'  and branch_name='" & branch_name.Text & "'"
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows = True Then
                    pcode.Text = dr("code")
                    pname.Text = dr("name")
                    inh.Text = dr("inh")
                    outm.Text = dr("outm")
                    outh.Text = dr("outh")
                    inm.Text = dr("inm")
                    id.Text = dr("id")
                    emp1.Text = dr("emp1")
                    emp2.Text = dr("emp2")
                    Dim odate1 As Date = RC("odate1")
                    Dim edate As Date = RC("edate")
                    Dim edate1 As Date = RC("edate1")
                    Dim odate As Date = RC("odate")
                    Dim s As Double = 0
                    Dim sal1 As Double = 0
                    ss = 0
                    Dim notss As String = ""
                    Dim et As TimeSpan = edate1 - edate
                    Dim ot As TimeSpan = odate - odate1
                    Dim ttt As Integer = 0
                    ss = 0
                    Dim ett As Integer = 0
                    Dim ett1 As Double = 0
                    If Math.Abs(et.TotalMinutes) > 15 + emp1.Text Then
                        ett = et.TotalMinutes + 15 + emp1.Text
                        If ett < -1 Then ett1 = 0.25 : notss = "late ??"
                        If ett < -15 And ett > -30 Then ett1 = 0.25 : notss = "late ??"
                        If ett <= -30 And ett > -60 Then ett1 = 0.5 : notss = "late ??"
                        If ett <= -60 Then ett1 = 1 : notss = "late ??"
                    End If
                    If emp1.Text = 0 Or emp2.Text = 0 Then
                        If ot.TotalMinutes < 0 Then
                            notss = notss & " leave early ??? "
                            ett1 = ett1 + 0.25
                        ElseIf ot.TotalMinutes - 15 > 0 Then
                            notss = notss & " over itme ! "
                            ss = ss + ot.TotalMinutes - 15
                        End If
                    ElseIf emp2.Text > 0 Then
                        If Math.Abs(et.TotalMinutes) <= 15 Then
                            If ot.TotalMinutes < 0 Then
                                notss = notss & " leave early ??? "
                                ett1 = ett1 + 0.25
                            ElseIf ot.TotalMinutes - 15 > 0 Then
                                notss = notss & " over itme ! "
                                ss = ss + ot.TotalMinutes - 15
                            End If
                        ElseIf Math.Abs(et.TotalMinutes) >= 15 Then
                            If Math.Abs(et.TotalMinutes) <= emp1.Text + 15 Then ttt = 0 Else ttt = emp1.Text
                            If ot.TotalMinutes - Math.Abs(et.TotalMinutes) < ttt Then
                                notss = notss & " leave early ??? "
                                ett1 = ett1 + 0.25
                            ElseIf ot.TotalMinutes - Math.Abs(et.TotalMinutes) > ttt Then
                                notss = notss & " over itme ! "
                                ss = ss + Math.Abs(ot.TotalMinutes) - Math.Abs(et.TotalMinutes)
                            End If
                        End If
                    End If
                    RC("sal1") = ett1
                    RC("sal") = ss * 2
                    RC("notse") = RC("notse") & notss
                    RC.EndEdit()
                End If

                dr.Close()
                cmd.CommandText = "select * from v_egzp where  sdate ='" & ChangeFormat(RC("sdate")) & "' and emp_code='" & RC("code") & "'"
                dr = cmd.ExecuteReader
                If dr.HasRows = True And RC("st") <> 7 Then
                    dr.Read()
                    RC.BeginEdit()
                    RC("notse") = RC("notse") & "  " & dr("nen")
                    RC("st") = 7
                    RC.EndEdit()
                End If
            End If
            n = n + 1

        End While
        cmdb.DataAdapter = adTEMP2
        adTEMP2.Update(DBS, "temp2")
        MsgBox(" „ «·Õ›Ÿ")
        ACdr.Close()
        ACcmd.CommandText = "update qq set id=id-" & Val(fp.Text)
        ACcmd.ExecuteNonQuery()
    End Sub

    Private Sub PNAME1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles PNAME1.KeyDown
        If e.KeyCode = Keys.Enter Then
            dr.Close()
            cmd.CommandText = "select * from eemp where name='" & PNAME1.Text & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then
                pcode.Text = nulls(dr("code"))
                CODE1.Text = nulls(dr("code"))
                FEMP()
                cmdREH.Connection = CN
                cmdREH.CommandType = CommandType.Text
                cmdREH.CommandText = "select * from EAVQ WHERE   EMP_CODE='" & CODE1.Text & "' "
                adREH.SelectCommand = cmdREH
                adREH.Fill(DBS, "REH")
                REH = DBS.Tables("REH")
                DBS.Tables("REH").Clear()
                adREH.Fill(DBS, "REH")
                REH = DBS.Tables("REH")
                DataGridView1.DataSource = REH
                Dim v As Integer = 0
                While Not v = DataGridView1.Columns.Count
                    DataGridView1.Columns(v).Visible = False
                    v = v + 1
                End While
                DataGridView1.Columns("AV_NAME").Visible = True
                DataGridView1.Columns("AV_NAME").HeaderText = "‰Ê⁄ «·«Ã«“…"
                DataGridView1.Columns("QUN").Visible = True
                DataGridView1.Columns("QUN").Width = 50
                DataGridView1.Columns("QUN").HeaderText = "«·—’Ìœ"
               
                
            End If
        End If
    End Sub

    Private Sub PNAME1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PNAME1.TextChanged

    End Sub

    Private Sub GlassButton21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton21.Click
        Dim ss As Integer = InputBox("pass")
        If ss <> 5011545 Then Exit Sub
        dr1.Close()
        dr.Close()
        cmd.CommandText = "DELETE FROM EAVQ "
        cmd.ExecuteNonQuery()
        cmd1.CommandText = "INSERT INTO EAVQ (EMP_CODE,EMP_NAME,AV_CODE,AV_NAME,QUN) SELECT AV_CODE,AV_NAME,CODE,NAME,QUN FROM V_AV "
        cmd1.ExecuteNonQuery()

    End Sub

    Private Sub GlassButton22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton22.Click

        dr.Close()
        dr.Close()
        cmd.CommandText = "UPDATE eagaza SET eagaza.acc = av_type.acc FROM eagaza INNER JOIN av_type ON eagaza.av_type = av_type.name "
        cmd.ExecuteNonQuery()


        ''cmdeemp.Connection = CN
        ''cmdeemp.CommandType = CommandType.Text
        ''cmdeemp.CommandText = "select sum(along) as along , emp_name from eagaza where adate1 between '" & ChangeFormat(DD1.Value) & "'  and '" & ChangeFormat(DD2.Value) & "' and acc=1 group by emp_name"
        ''adeemp.SelectCommand = cmdeemp
        ''adeemp.Fill(DBS, "eemp")
        ''eemp = DBS.Tables("eemp")
        ''DBS.Tables("eemp").Clear()
        ''adeemp.Fill(DBS, "eemp")
        ''eemp = DBS.Tables("eemp")
        ''brpd.DataSource = eemp
        ''d1 = 1
        ''Dim v As Integer = 0
        ''While Not v = brpd.Columns.Count
        ''    brpd.Columns(v).Visible = False
        ''    v = v + 1
        ''End While
        ' ''brpd.Columns("NAME").Visible = True
        ' ''brpd.Columns("NAME").HeaderText = "«·„ÊŸ›"
        ' ''brpd.Columns("NAME").Width = 300
        ''Dim oj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        ''oj.Load(Application.StartupPath & "\EMPTOTAL.rpt")
        ''oj.Database.Tables(0).SetDataSource(eemp)
        ''rp.CrystalReportViewer1.ReportSource = oj
        ''rp.Show() : rp.Focus()
        cmdeemp.Connection = CN
        cmdeemp.CommandType = CommandType.Text
        cmdeemp.CommandText = "select * from eemp  order by NAME"
        adeemp.SelectCommand = cmdeemp
        adeemp.Fill(DBS, "eemp")
        eemp = DBS.Tables("eemp")
        DBS.Tables("eemp").Clear()
        adeemp.Fill(DBS, "eemp")
        eemp = DBS.Tables("eemp")
        dr.Close()
        ACdr.Close() : ACcmd.CommandText = "delete * from book_price"
        ACcmd.ExecuteNonQuery()
        dr.Close() : cmd.CommandText = "select name,code from av_type where  acc='1'"
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
        cmdBOOK.Connection = ACcn
        cmdbook.CommandType = CommandType.Text
        cmdBOOK.CommandText = "select sr,name,srh,sno,code,ky FROM book_price order by CODE"
        adbook.SelectCommand = cmdbook
        adbook.Fill(DBS, "book")
        book = DBS.Tables("book")
        DBS.Tables("book").Clear()
        adbook.Fill(DBS, "book")
        Dim M As Integer
        Dim YY As String = ""
        M = 0

        a.Rows.Clear()
        Dim ii As Integer = 0
        Dim ss As Integer = 0
        Dim i As Integer = 0
        Dim aa As Int16 = 0
        Dim o As Integer
        While Not i = eemp.Rows.Count
            ss = 0
            ii = 0
            aa = 0
            o = 0


            While Not ii = book.Rows.Count
                If book.Rows(ii).Item("srh") = 0 Then
                    ss = 0
                    dr.Close()
                    'cmd.CommandText = "delete from eemp where test_code is NULL"
                    'cmd.ExecuteNonQuery()
                    dr.Close() : cmd.CommandText = "sELECT  SUM(ALONG) AS TOT from eagaza WHERE EMP_code='" & eemp.Rows(i).Item("code") & "'  and AV_TYPE='" & BOOK.Rows(ii).Item("NAME") & "' "
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
                        RC("name") = eemp.Rows(i).Item("name")
                        RC("code") = eemp.Rows(i).Item("code")
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
            oj.Load(Application.StartupPath & "\stoc1.rpt")
        Else
            oj.Load(Application.StartupPath & "\stoc1.rpt")
        End If
        'MsgBox(a.Rows.Count)
        oj.SetDataSource(a)
        oj.SetParameterValue("d1", "")
        oj.SetParameterValue("d2", "")
        rp.CrystalReportViewer1.ReportSource = oj
        rp.CrystalReportViewer1.Refresh()
        rp.Show()
        Exit Sub



    End Sub

    Private Sub GlassButton19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton19.Click
        Dim yy As String = ""

        If cpcode.Checked = True Then
            yy = " and emp_code='" & pcode.Text & "'"
        End If
        cmdagz.Connection = CN
        cmdagz.CommandType = CommandType.Text
        cmdagz.CommandText = "select * from eagaza  WHERE adate1 between '" & ChangeFormat(DD1.Value) & "'  and '" & ChangeFormat(DD2.Value) & "' " & yy & "  order by acode"
        adagz.SelectCommand = cmdagz
        adagz.Fill(DBS, "agz")
        agz = DBS.Tables("agz")
        DBS.Tables("agz").Clear()
        adagz.Fill(DBS, "agz")
        agz = DBS.Tables("agz")
        brpd.DataSource = agz
        d1 = 1
        Dim oj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        oj.Load(Application.StartupPath & "\EMPAGZA.rpt")
        oj.Database.Tables(0).SetDataSource(agz)
        rp.CrystalReportViewer1.ReportSource = oj

        rp.Show() : rp.Focus()
    End Sub

    Private Sub GlassButton20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton20.Click
        cmdb.DataAdapter = adREH
        adREH.Update(DBS, "REH")
        MsgBox(" „ «·Õ›Ÿ")
    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ACdr.Close()

        ACdr.Close()
        acdr1.Close()
        ACcmd.CommandText = "select name1,id from qq group by name1,id"
        ACdr = ACcmd.ExecuteReader
        While ACdr.Read
            Dim NX As Date = ChangeFormat(DD1.Value)
            While Not ChangeFormat(NX) = ChangeFormat(DD2.Value)
                Dim edate As Date = NX
                Dim n As Integer = 0

                Dim d1 As Date = "1-1-1900"
                Dim d2 As Date = "1-1-1900"
                acdr1.Close()
                accmd1.CommandText = "select * from qq where id=" & ACdr("id") & " and sdate >=#" & ChangeFormat(NX) & "# and sdate <#" & ChangeFormat(NX.AddDays(1)) & "# order by sdate"
                acdr1 = accmd1.ExecuteReader
                If acdr1.HasRows Then
                    acdr1.Read()
                    d1 = acdr1("sdate")
                End If
               
                While acdr1.Read
                    d2 = acdr1("sdate")
                    n = 1
                End While
                Dim sse As String = ""
                Select Case edate.DayOfWeek
                    Case DayOfWeek.Friday
                        sse = "«·Ã„⁄…"
                    Case DayOfWeek.Saturday
                        sse = "«·”» "
                    Case DayOfWeek.Sunday
                        sse = "«·«Õœ"
                    Case DayOfWeek.Monday
                        sse = "«·«À‰Ì‰"
                    Case DayOfWeek.Tuesday
                        sse = "«·À·«À«¡"
                    Case DayOfWeek.Wednesday
                        sse = "«·«—»⁄«¡"
                    Case DayOfWeek.Thursday
                        sse = "«·Œ„Ì”"
                End Select
                acdr1.Close()
                accmd1.CommandText = "insert into mosta ([name1],[id],dater,date1,date2,SDAY) VALUES ('" & ACdr(0) & "','" & ACdr(1) & "','" & ChangeFormat(edate) & "','" & ChangeFormatall(d1) & "','" & ChangeFormatall(d2) & "','" & sse & "')"
                accmd1.ExecuteNonQuery()
                NX = NX.AddDays(1)
            End While
        End While



    End Sub

    Private Sub GlassButton23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ss As Integer = InputBox("pass")
        If ss <> 5011545 Then Exit Sub
        dr1.Close()
        dr.Close()
        cmd.CommandText = "DELETE FROM EAVQ WHERE EMP_CODE='" & CODE1.Text & "'"
        cmd.ExecuteNonQuery()

        cmd1.CommandText = "INSERT INTO EAVQ (EMP_CODE,EMP_NAME,AV_CODE,AV_NAME,QUN) SELECT AV_CODE,AV_NAME,CODE,NAME,QUN FROM V_AV WHERE AV_CODE='" & CODE1.Text & "'"
        cmd1.ExecuteNonQuery()

    End Sub

    Private Sub qq22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles qq22.Click
        On Error Resume Next
        dr.Close()
        cmd.CommandText = "BACKUP DATABASE [ASILLAB] TO  DISK = N'E:\techno\asil" & Now.DayOfYear & "' WITH NOFORMAT, INIT,  NAME = N'ASILLAB-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "BACKUP DATABASE [ASILLAB] TO  DISK = N'D:\asil" & Now.DayOfYear & "' WITH NOFORMAT, INIT,  NAME = N'ASILLAB-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10"
        cmd.ExecuteNonQuery()
        MsgBox("backup done ")
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cmdb.DataAdapter = adeems
        adeems.Update(DBS, "eems")
        MsgBox(" „ «·Õ›Ÿ")
    End Sub

    Private Sub MS_NAME_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MS_NAME.KeyUp
        If e.KeyCode = Keys.ControlKey Then
            FSAVE(MS_NAME.Text, "EMS", 1)
        ElseIf e.KeyCode = Keys.Delete Then
            FSAVE(jop_name.Text, "EMS", 2)
        End If
    End Sub

    Private Sub MS_NAME_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MS_NAME.SelectedIndexChanged
        If MS_NAME.Focused = False Then Exit Sub
        If MS_NAME.Text = "" Then Exit Sub

        FRC = EMS.Select("NAME='" & MS_NAME.Text & "'")
        If FRC.Length <= 0 Then
            MS_NAME.Text = ""
            MS_CODE.Text = ""
            Exit Sub
        Else
            RC = FRC(0)
            MS_CODE.Text = RC("code")
        End If
    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim ss As Integer = InputBox("pass")
        If ss <> 5011545 Then Exit Sub
        dr1.Close()
        dr.Close()
        cmd.CommandText = "select * from eemp"
        dr = cmd.ExecuteReader
        While dr.Read
            cmd1.CommandText = "INSERT INTO [dbo].[eemp_ms]  ([ms_name] ,[ms_code],emp_code,mk) select name,code,99999,0 from ems"
            cmd1.ExecuteNonQuery()
            cmd1.CommandText = "update eemp_ms set emp_code='" & dr("code") & "',emp_name='" & dr("name") & "' where emp_code=99999"
            cmd1.ExecuteNonQuery()
        End While
        
    End Sub

    Private Sub SHIFT_NAME_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles SHIFT_NAME.KeyUp
        If e.KeyCode = Keys.ControlKey Then
            FSAVE(SHIFT_NAME.Text, "ESHIFT", 1)
        ElseIf e.KeyCode = Keys.Delete Then
            FSAVE(SHIFT_NAME.Text, "ESHIFT", 2)
        End If
    End Sub

    Private Sub SHIFT_NAME_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SHIFT_NAME.SelectedIndexChanged
        If SHIFT_NAME.Focused = False Then Exit Sub
        If SHIFT_NAME.Text = "" Then Exit Sub

        FRC = ESHIFT.Select("NAME='" & SHIFT_NAME.Text & "'")
        If FRC.Length <= 0 Then
            SHIFT_NAME.Text = ""
            SHIFT_CODE.Text = ""
            Exit Sub
        Else
            RC = FRC(0)
            SHIFT_CODE.Text = RC("code")
        End If
    End Sub

    Private Sub Button7_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TQ_NAME_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TQ_NAME.KeyUp
        If e.KeyCode = Keys.ControlKey Then
            FSAVE(TQ_NAME.Text, "ETQ", 1)
        ElseIf e.KeyCode = Keys.Delete Then
            FSAVE(TQ_NAME.Text, "ETQ", 2)
        End If
    End Sub

    Private Sub TQ_NAME_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TQ_NAME.SelectedIndexChanged
        If TQ_NAME.Focused = False Then Exit Sub
        If TQ_NAME.Text = "" Then Exit Sub
        FRC = TQ.Select("NAME='" & TQ_NAME.Text & "'")
        If FRC.Length <= 0 Then
            TQ_NAME.Text = ""
            TQ_CODE.Text = ""
            Exit Sub
        Else
            RC = FRC(0)
            TQ_CODE.Text = RC("code")
        End If
    End Sub

    Private Sub Button8_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        cmdb.DataAdapter = adeems
        adeems.Update(DBS, "eems")
        MsgBox(" „ «·Õ›Ÿ")

    End Sub

    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        TQ_DATE.Value = Now
        dr1.Close()
        cmd1.CommandText = "INSERT INTO [dbo].[emp_TQ]  ([TQ_name] ,[TQ_code],emp_code,PR) select name,code,99999,0 from eTQ"
        cmd1.ExecuteNonQuery()
        cmd1.CommandText = "update EMP_TQ set emp_code='" & pcode.Text & "',emp_name='" & pname.Text & "',TQ_DATE='" & ChangeFormat(TQ_DATE.Value) & "' where emp_code=99999"
        cmd1.ExecuteNonQuery()
        cmdETQ.Connection = CN
        cmdETQ.CommandType = CommandType.Text
        cmdETQ.CommandText = "select * from emp_TQ where emp_code='" & pcode.Text & "' "
        adETQ.SelectCommand = cmdETQ
        adETQ.Fill(DBS, "eTQ")
        ETQ = DBS.Tables("eTQ")
        DBS.Tables("eTQ").Clear()
        adETQ.Fill(DBS, "eTQ")
        ETQ = DBS.Tables("eTQ")
        DataGridView2.DataSource = ETQ
        DataGridView2.Columns("TQ_name").HeaderText = "«·»Ì«‰"
        DataGridView2.Columns("TQ_name").Width = 300
        DataGridView2.Columns("note").HeaderText = "„·«ÕŸÂ"
        DataGridView2.Columns("note").Width = 200
        DataGridView2.Columns("PR").HeaderText = "«·‰”»…"
        DataGridView2.Columns("emp_code").Visible = False
        DataGridView2.Columns("emp_name").Visible = False
        DataGridView2.Columns("TQ_code").Visible = False
        DataGridView2.Columns("pdf").Visible = False
        DataGridView2.Columns("ky").Visible = False
    End Sub

    Private Sub Button7_Click_3(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        cmdb.DataAdapter = adETQ
        adETQ.Update(DBS, "eTQ")
        MsgBox(" „ «·Õ›Ÿ")
    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cmdETQ.Connection = CN
        cmdETQ.CommandType = CommandType.Text
        cmdETQ.CommandText = "select * from emp_TQ where emp_code='" & pcode.Text & "' "
        adETQ.SelectCommand = cmdETQ
        adETQ.Fill(DBS, "eTQ")
        ETQ = DBS.Tables("eTQ")
        DBS.Tables("eTQ").Clear()
        adETQ.Fill(DBS, "eTQ")
        ETQ = DBS.Tables("eTQ")
        DataGridView2.DataSource = ETQ
        DataGridView2.Columns("TQ_name").HeaderText = "«·»Ì«‰"
        DataGridView2.Columns("TQ_name").Width = 300
        DataGridView2.Columns("note").HeaderText = "„·«ÕŸÂ"
        DataGridView2.Columns("note").Width = 200
        DataGridView2.Columns("PR").HeaderText = "«·‰”»…"
        DataGridView2.Columns("emp_code").Visible = False
        DataGridView2.Columns("emp_name").Visible = False
        DataGridView2.Columns("TQ_code").Visible = False
        DataGridView2.Columns("pdf").Visible = False
        DataGridView2.Columns("ky").Visible = False
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Dim yy As String = ""

        If cpcode.Checked = True Then
            yy = " where emp_code='" & pcode.Text & "'"
        End If
        cmdETQ.Connection = CN
        cmdETQ.CommandType = CommandType.Text
        cmdETQ.CommandText = "select * from emp_TQ  " & yy
        adETQ.SelectCommand = cmdETQ
        adETQ.Fill(DBS, "eTQ")
        ETQ = DBS.Tables("eTQ")
        DBS.Tables("eTQ").Clear()
        adETQ.Fill(DBS, "eTQ")
        ETQ = DBS.Tables("eTQ")
        DataGridView2.DataSource = ETQ
        Dim oj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        oj.Load(Application.StartupPath & "\tq.rpt")
        oj.Database.Tables(0).SetDataSource(ETQ)
        rp.CrystalReportViewer1.ReportSource = oj
        rp.Show() : rp.Focus()
        DataGridView2.Columns("TQ_name").HeaderText = "«·»Ì«‰"
        DataGridView2.Columns("TQ_name").Width = 300
        DataGridView2.Columns("note").HeaderText = "„·«ÕŸÂ"
        DataGridView2.Columns("note").Width = 200
        DataGridView2.Columns("PR").HeaderText = "«·‰”»…"
        DataGridView2.Columns("emp_code").Visible = False
        DataGridView2.Columns("emp_name").Visible = False
        DataGridView2.Columns("TQ_code").Visible = False
        DataGridView2.Columns("pdf").Visible = False
        DataGridView2.Columns("ky").Visible = False
    End Sub

    Private Sub TabPage7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage7.Click

    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Dim yy As String = ""
        If cpcode.Checked = True Then
            yy = " where emp_code='" & pcode.Text & "'"
        End If
        cmdeems.Connection = CN
        cmdeems.CommandType = CommandType.Text
        cmdeems.CommandText = "select * from eemp_ms " & yy
        adeems.SelectCommand = cmdeems
        adeems.Fill(DBS, "eems")
        eems = DBS.Tables("eems")
        DBS.Tables("eems").Clear()
        adeems.Fill(DBS, "eems")
        eems = DBS.Tables("eems")
        DataGridView6.DataSource = eems
        '  DataGridView6.Columns("qun").HeaderText = "√Õ÷—"
        DataGridView6.Columns("ms_name").HeaderText = "«·»Ì«‰"
        DataGridView6.Columns("ms_name").Width = 300
        DataGridView6.Columns("note").HeaderText = "„·«ÕŸÂ"
        DataGridView6.Columns("note").Width = 200
        DataGridView6.Columns("mk").HeaderText = "‰Ê⁄ «·„” ‰œ"
        DataGridView6.Columns("emp_code").Visible = False
        DataGridView6.Columns("emp_name").Visible = False
        DataGridView6.Columns("ms_code").Visible = False
        DataGridView6.Columns("pdf").Visible = False
        DataGridView6.Columns("ky").Visible = False
        Dim oj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        oj.Load(Application.StartupPath & "\ms.rpt")
        oj.Database.Tables(0).SetDataSource(eems)
        rp.CrystalReportViewer1.ReportSource = oj
        rp.Show() : rp.Focus()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Dim yy As String = ""
        If cpcode.Checked = True Then
            yy = " where emp_code='" & pcode.Text & "'"
        End If
        cmdTD.Connection = CN
        cmdTD.CommandType = CommandType.Text
        cmdTD.CommandText = "select * from emp_td " & yy
        adTD.SelectCommand = cmdTD
        adTD.Fill(DBS, "TD")
        TD = DBS.Tables("TD")
        DBS.Tables("TD").Clear()
        adTD.Fill(DBS, "TD")
        TD = DBS.Tables("TD")
        DataGridView3.DataSource = TD
        '  DataGridView3.Columns("qun").HeaderText = "√Õ÷—"
        DataGridView3.Columns("td_name").HeaderText = "«·»Ì«‰"
        DataGridView3.Columns("td_name").Width = 300
        DataGridView3.Columns("note").HeaderText = "„·«ÕŸÂ"
        DataGridView3.Columns("note").Width = 200
        DataGridView3.Columns("emp_code").Visible = False
        DataGridView3.Columns("emp_name").Visible = False
        DataGridView3.Columns("td_code").Visible = False
        DataGridView3.Columns("ky").Visible = False
        Dim oj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        oj.Load(Application.StartupPath & "\td.rpt")
        oj.Database.Tables(0).SetDataSource(TD)
        rp.CrystalReportViewer1.ReportSource = oj
        rp.Show() : rp.Focus()
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        cmdb.DataAdapter = adTD
        adTD.Update(DBS, "TD")
        MsgBox(" „ «·Õ›Ÿ")
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Dim ss As Integer = InputBox("pass")
        If ss <> 5011545 Then Exit Sub
        dr1.Close()
        dr.Close()
        cmd.CommandText = "select * from eemp"
        dr = cmd.ExecuteReader
        While dr.Read
            cmd1.CommandText = "INSERT INTO [dbo].[emp_TD]  ([TD_name] ,[TD_code],emp_code) select name,code,99999 from eTD"
            cmd1.ExecuteNonQuery()
            cmd1.CommandText = "update emp_TD set emp_code='" & dr("code") & "',emp_name='" & dr("name") & "' where emp_code=99999"
            cmd1.ExecuteNonQuery()
        End While
    End Sub

    Private Sub ETD_name_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ETD_name.KeyUp
        If e.KeyCode = Keys.ControlKey Then
            FSAVE(ETD_name.Text, "ETD", 1)
        ElseIf e.KeyCode = Keys.Delete Then
            FSAVE(ETD_name.Text, "ETD", 2)
        End If
    End Sub

    Private Sub ETD_name_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ETD_name.SelectedIndexChanged
        If ETD_NAME.Focused = False Then Exit Sub
        If ETD_NAME.Text = "" Then Exit Sub
        FRC = ETD.Select("NAME='" & ETD_name.Text & "'")
        If FRC.Length <= 0 Then
            ETD_NAME.Text = ""
            ETD_CODE.Text = ""
            Exit Sub
        Else
            RC = FRC(0)
            ETD_CODE.Text = RC("code")
        End If
    End Sub

    Private Sub o1_1s_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o1_1s.KeyDown
    End Sub

    Private Sub o1_1s_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o1_1s.KeyUp
        o1_1.Text = Val(o1_1s.Text) * Val(sday1.Text)
        sum(1)
    End Sub

    Private Sub o1_1s_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o1_1s.TextChanged

    End Sub

    Private Sub o1_2s_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o1_2s.KeyUp
        o1_2.Text = Val(o1_2s.Text) * Val(sday1.Text)
        sum(2)
    End Sub

    Private Sub o1_2s_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o1_2s.TextChanged

    End Sub

    Private Sub o1_3s_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o1_3s.KeyUp
        o1_3.Text = Val(o1_3s.Text) * Val(sday1.Text)
        sum(3)
    End Sub

    Private Sub o1_3s_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o1_3s.TextChanged

    End Sub

    Private Sub o1_4s_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o1_4s.KeyUp
        o1_4.Text = Val(o1_4s.Text) * Val(sday1.Text)
        sum(4)
    End Sub

    Private Sub o1_4s_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o1_4s.TextChanged

    End Sub

    Private Sub o1_5s_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o1_5s.KeyUp
        o1_5.Text = Val(o1_5s.Text) * Val(sday1.Text)
        sum(5)
    End Sub

    Private Sub o1_5s_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o1_5s.TextChanged

    End Sub

    Private Sub o1_6s_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o1_6s.KeyUp
        o1_6.Text = Val(o1_6s.Text) * Val(sday1.Text)
        sum(6)
    End Sub

    Private Sub o1_6s_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o1_6s.TextChanged

    End Sub

    Private Sub O1_7s_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles O1_7s.KeyUp
        o1_7.Text = Val(O1_7s.Text) * Val(sday1.Text)
        sum(7)
    End Sub

    Private Sub O1_7s_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles O1_7s.TextChanged

    End Sub

    Private Sub o1_8s_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o1_8s.KeyUp
        o1_8.Text = Val(o1_8s.Text) * Val(sday1.Text)
        sum(8)
    End Sub

    Private Sub o1_8s_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o1_8s.TextChanged

    End Sub

    Private Sub o1_9s_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o1_9s.KeyUp
        o1_9.Text = Val(o1_9s.Text) * Val(sday1.Text)
        sum(9)
    End Sub

    Private Sub o1_9s_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o1_9s.TextChanged

    End Sub

    Private Sub o1_10s_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o1_10s.KeyUp
        o1_10.Text = Val(o1_10s.Text) * Val(sday1.Text)
        sum(10)
    End Sub

    Private Sub o1_10s_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o1_10s.TextChanged

    End Sub

    Private Sub o1_11s_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o1_11s.KeyUp
        o1_11.Text = Val(o1_11s.Text) * Val(sday1.Text)
        sum(11)
    End Sub

    Private Sub o1_11s_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o1_11s.TextChanged

    End Sub

    Private Sub o1_12s_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o1_12s.KeyUp
        o1_12.Text = Val(o1_12s.Text) * Val(sday1.Text)
        sum(12)
    End Sub

    Private Sub o1_12s_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o1_12s.TextChanged

    End Sub

    Private Sub o3_1s_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o3_1s.KeyDown
    End Sub

    Private Sub o3_1s_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o3_1s.KeyUp
        o3_1.Text = Val(o3_1s.Text) * Val(sday1.Text)
        sum(1)
    End Sub

    Private Sub o3_1s_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o3_1s.TextChanged

    End Sub

    Private Sub o3_2s_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o3_2s.KeyUp
        o3_2.Text = Val(o3_2s.Text) * Val(sday1.Text)
        sum(2)
    End Sub

    Private Sub o3_2s_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o3_2s.TextChanged

    End Sub

    Private Sub o3_3s_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o3_3s.KeyUp
        o3_3.Text = Val(o3_3s.Text) * Val(sday1.Text)
        sum(3)
    End Sub

    Private Sub o3_3s_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o3_3s.TextChanged

    End Sub

    Private Sub o3_4s_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o3_4s.KeyUp
        o3_4.Text = Val(o3_4s.Text) * Val(sday1.Text)
        sum(4)
    End Sub

    Private Sub o3_4s_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o3_4s.TextChanged

    End Sub

    Private Sub o3_5s_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o3_5s.KeyUp
        o3_5.Text = Val(o3_5s.Text) * Val(sday1.Text)
        sum(5)
    End Sub

    Private Sub o3_5s_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o3_5s.TextChanged

    End Sub

    Private Sub o3_6s_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o3_6s.KeyUp
        o3_6.Text = Val(o3_6s.Text) * Val(sday1.Text)
        sum(6)
    End Sub

    Private Sub o3_6s_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o3_6s.TextChanged

    End Sub

    Private Sub o3_7s_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o3_7s.KeyUp
        o3_7.Text = Val(o3_7s.Text) * Val(sday1.Text)
        sum(7)
    End Sub

    Private Sub o3_7s_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o3_7s.TextChanged

    End Sub

    Private Sub o3_8s_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o3_8s.KeyUp
        o3_8.Text = Val(o3_8s.Text) * Val(sday1.Text)
        sum(8)
    End Sub

    Private Sub o3_8s_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o3_8s.TextChanged

    End Sub

    Private Sub o3_9s_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o3_9s.KeyUp
        o3_9.Text = Val(o3_9s.Text) * Val(sday1.Text)
        sum(9)
    End Sub

    Private Sub o3_9s_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o3_9s.TextChanged

    End Sub

    Private Sub o3_10s_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o3_10s.KeyUp
        o3_10.Text = Val(o3_10s.Text) * Val(sday1.Text)
        sum(10)
    End Sub

    Private Sub o3_10s_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o3_10s.TextChanged
       
    End Sub

    Private Sub o3_11s_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o3_11s.KeyUp
        o3_11.Text = Val(o3_11s.Text) * Val(sday1.Text)
        sum(11)
    End Sub

    Private Sub o3_11s_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o3_11s.TextChanged

    End Sub

    Private Sub o3_12s_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles o3_12s.KeyUp
        o3_12.Text = Val(o3_12s.Text) * Val(sday1.Text)
        sum(12)
    End Sub

    Private Sub o3_12s_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o3_12s.TextChanged

    End Sub
End Class