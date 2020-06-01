Public Class prgn

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        fillTextBox(Me)
        dr.Close()
        cmd.CommandText = "INSERT INTO [ASILLAB].[dbo].[pr_pa] ([pname],[pcode],[page],[pmobile],[resi],[notse],[hasband],[hdate],[nchild],[past_d],[past_h],[past_o],[past_dr],[past_ot],[fam_d],[fam_h],[fam_t],[fam_ot],[mens_r],[mens_p],[mens_ot],[obs_ab],[obs_dev],[obs_li],[obs_ot],[vip_lmp],[vip_edd],[vip_past],[vip_rela],[vip_last],[vip_expec],[vip_hi],[vip_brea],[vip_he],[vip_pel],[vip_pv],[vip_lo],[vip_abo],[vip_rh],[vip_cbc],[vip_hb],[vip_toxo],[vip_ot]) VALUES ('" & pname.Text & "' ,'" & pcode.Text & "' ,'" & page.Text & "' ,'" & pmobile.Text & "' ,'" & resi.Text & "' ,'" & notse.Text & "' ,'" & hasband.Text & "' ,'" & ChangeFormat(hdate.Value) & "' ,'" & nchild.Text & "' ,'" & past_d.Text & "' ,'" & past_h.Text & "' ,'" & past_o.Text & "' ,'" & past_dr.Text & "' ,'" & past_ot.Text & "' ,'" & fam_d.Text & "' ,'" & fam_h.Text & "' ,'" & fam_t.Text & "' ,'" & fam_ot.Text & "' ,'" & mens_r.Text & "' ,'" & mens_p.Text & "' ,'" & mens_ot.Text & "' ,'" & obs_ab.Text & "' ,'" & obs_dev.Text & "' ,'" & obs_li.Text & "' ,'" & obs_ot.Text & "' ,'" & vip_lmp.Text & "' ,'" & vip_edd.Text & "' ,'" & vip_past.Text & "' ,'" & vip_rela.Text & "' ,'" & ChangeFormat(vip_last.Value) & "' ,'" & ChangeFormat(vip_expec.Value) & "' ,'" & vip_hi.Text & "' ,'" & vip_brea.Text & "' ,'" & vip_he.Text & "' ,'" & vip_pel.Text & "' ,'" & vip_pv.Text & "' ,'" & vip_lo.Text & "' ,'" & vip_abo.Text & "' ,'" & vip_rh.Text & "' ,'" & vip_cbc.Text & "' ,'" & vip_hb.Text & "' ,'" & vip_toxo.Text & "' ,'" & vip_ot.Text & "' )  "
        cmd.ExecuteNonQuery()
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
                dr.Close() : cmd.CommandText = "insert into  " & TB & "  (name)  values ('" & NNAME & "')"
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
        If tb = "prnresi" Or tb = "" Then
            resi.Items.Clear()
            dr.Close()
            cmd.CommandText = "select * from prnresi"
            dr = cmd.ExecuteReader
            While dr.Read
                resi.Items.Add(dr("name"))
            End While
        End If
        If tb = "prnnotse" Or tb = "" Then
            notse.Items.Clear()
            dr.Close()
            cmd.CommandText = "select * from prnnotse"
            dr = cmd.ExecuteReader
            While dr.Read
                notse.Items.Add(dr("name"))
            End While
        End If
        If tb = "prndi" Or tb = "" Then
            past_d.Items.Clear()
            dr.Close()
            cmd.CommandText = "select * from prndi"
            dr = cmd.ExecuteReader
            While dr.Read
                past_d.Items.Add(dr("name"))
            End While
        End If
        If tb = "prnhy" Or tb = "" Then
            past_h.Items.Clear()
            dr.Close()
            cmd.CommandText = "select * from prnhy"
            dr = cmd.ExecuteReader
            While dr.Read
                past_h.Items.Add(dr("name"))
            End While
        End If
        If tb = "prnoper" Or tb = "" Then
            past_o.Items.Clear()
            dr.Close()
            cmd.CommandText = "select * from prnoper"
            dr = cmd.ExecuteReader
            While dr.Read
                past_o.Items.Add(dr("name"))
            End While
        End If
        If tb = "prnreg" Or tb = "" Then
            mens_r.Items.Clear()
            dr.Close()
            cmd.CommandText = "select * from prnreg"
            dr = cmd.ExecuteReader
            While dr.Read
                mens_r.Items.Add(dr("name"))
            End While
        End If
        If tb = "prnpain" Or tb = "" Then
            mens_p.Items.Clear()
            dr.Close()
            cmd.CommandText = "select * from prnpain"
            dr = cmd.ExecuteReader
            While dr.Read
                mens_p.Items.Add(dr("name"))
            End While
        End If
        If tb = "PRNLMP" Or tb = "" Then
            vip_lmp.Items.Clear()
            dr.Close()
            cmd.CommandText = "select * from PRNLMP"
            dr = cmd.ExecuteReader
            While dr.Read
                vip_lmp.Items.Add(dr("name"))
            End While
        End If
        If tb = "PRNEDD" Or tb = "" Then
            vip_edd.Items.Clear()
            dr.Close()
            cmd.CommandText = "select * from PRNEDD"
            dr = cmd.ExecuteReader
            While dr.Read
                vip_edd.Items.Add(dr("name"))
            End While
        End If
        If tb = "PRNPAST" Or tb = "" Then
            vip_past.Items.Clear()
            dr.Close()
            cmd.CommandText = "select * from PRNPAST"
            dr = cmd.ExecuteReader
            While dr.Read
                vip_past.Items.Add(dr("name"))
            End While
        End If
        If tb = "PRNREL" Or tb = "" Then
            vip_rela.Items.Clear()
            dr.Close()
            cmd.CommandText = "select * from PRNREL"
            dr = cmd.ExecuteReader
            While dr.Read
                vip_rela.Items.Add(dr("name"))
            End While
        End If
    End Sub

    Private Sub prgn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        filla("")
    End Sub

    Private Sub resi_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles resi.KeyUp
        If e.KeyCode = Keys.F2 Then
            FSAVE(resi.Text, "prnresi", 1)
        End If
        If e.KeyCode = Keys.F3 Then
            FSAVE(resi.Text, "prnresi", 2)
        End If

    End Sub

    Private Sub resi_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles resi.SelectedIndexChanged

    End Sub

    Private Sub notse_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles notse.KeyDown

    End Sub

    Private Sub notse_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles notse.KeyUp
        If e.KeyCode = Keys.F2 Then
            FSAVE(notse.Text, "prnnotse", 1)
        End If
        If e.KeyCode = Keys.F3 Then
            FSAVE(notse.Text, "prnnotse", 2)
        End If
    End Sub

    Private Sub notse_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles notse.SelectedIndexChanged

    End Sub

    Private Sub past_d_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles past_d.KeyDown

    End Sub

    Private Sub past_d_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles past_d.KeyUp
        If e.KeyCode = Keys.F2 Then
            FSAVE(past_d.Text, "prndi", 1)
        End If
        If e.KeyCode = Keys.F3 Then
            FSAVE(past_d.Text, "prndi", 2)
        End If
    End Sub

    Private Sub past_d_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles past_d.SelectedIndexChanged

    End Sub

    Private Sub past_h_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles past_h.KeyUp
        If e.KeyCode = Keys.F2 Then
            FSAVE(past_h.Text, "prnhy", 1)
        End If
        If e.KeyCode = Keys.F3 Then
            FSAVE(past_h.Text, "prnhy", 2)
        End If
    End Sub

    Private Sub past_h_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles past_h.SelectedIndexChanged

    End Sub

    Private Sub past_o_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles past_o.KeyUp
        If e.KeyCode = Keys.F2 Then
            FSAVE(past_o.Text, "prnoper", 1)
        End If
        If e.KeyCode = Keys.F3 Then
            FSAVE(past_o.Text, "prnoper", 2)
        End If
    End Sub

    Private Sub past_o_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles past_o.SelectedIndexChanged

    End Sub

    Private Sub mens_r_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mens_r.KeyUp
        If e.KeyCode = Keys.F2 Then
            FSAVE(mens_r.Text, "prnreg", 1)
        End If
        If e.KeyCode = Keys.F3 Then
            FSAVE(mens_r.Text, "prnreg", 2)
        End If
    End Sub

    Private Sub mens_r_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mens_r.SelectedIndexChanged

    End Sub

    Private Sub mens_p_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mens_p.KeyUp
        If e.KeyCode = Keys.F2 Then
            FSAVE(mens_p.Text, "prnpain", 1)
        End If
        If e.KeyCode = Keys.F3 Then
            FSAVE(mens_p.Text, "prnpain", 2)
        End If
    End Sub

    Private Sub mens_p_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mens_p.SelectedIndexChanged

    End Sub

    Private Sub vip_lmp_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles vip_lmp.KeyUp
        If e.KeyCode = Keys.F2 Then
            FSAVE(vip_lmp.Text, "PRNLMP", 1)
        End If
        If e.KeyCode = Keys.F3 Then
            FSAVE(vip_lmp.Text, "PRNLMP", 2)
        End If
    End Sub

    Private Sub vip_lmp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vip_lmp.SelectedIndexChanged

    End Sub

    Private Sub vip_edd_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles vip_edd.KeyUp
        If e.KeyCode = Keys.F2 Then
            FSAVE(vip_edd.Text, "PRNEDD", 1)
        End If
        If e.KeyCode = Keys.F3 Then
            FSAVE(vip_edd.Text, "PRNEDD", 2)
        End If
    End Sub

    Private Sub vip_edd_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vip_edd.SelectedIndexChanged

    End Sub

    Private Sub vip_past_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles vip_past.KeyUp
        If e.KeyCode = Keys.F2 Then
            FSAVE(vip_past.Text, "PRNPAST", 1)
        End If
        If e.KeyCode = Keys.F3 Then
            FSAVE(vip_past.Text, "PRNPAST", 2)
        End If
    End Sub

    Private Sub vip_past_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vip_past.SelectedIndexChanged

    End Sub

    Private Sub vip_rela_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles vip_rela.KeyUp
        If e.KeyCode = Keys.F2 Then
            FSAVE(vip_rela.Text, "PRNREL", 1)
        End If
        If e.KeyCode = Keys.F3 Then
            FSAVE(vip_rela.Text, "PRNREL", 2)
        End If
    End Sub

    Private Sub vip_rela_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vip_rela.SelectedIndexChanged

    End Sub
End Class