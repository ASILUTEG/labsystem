Public Class PATHO

    Private Sub c_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c.Click
        dr1.Close()
        cmd1.CommandText = "update LBILL_TESTSUB set RES='" & tar.Text & "' where ESL_NO='" & LBILL.esl_no.Text & "' " & " and " & "yearn='" & Val(LBILL.YEARN.Text) & "' and bran='" & LBILL.bran.Text & "'" & " and   TEST_CODE='" & LBILL.Ntest_CODE.Text & "'"
        cmd1.ExecuteNonQuery()
        Me.Visible = False
    End Sub

    Private Sub PATHO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class