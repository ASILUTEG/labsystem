Imports System.Data.SqlClient
Imports System.IO
Imports System.Security.Cryptography
Imports iTextSharp
Imports System.Net.WebClient
Imports System.Net
Imports SYSTEM.Web
Public Class Form3

    Private enc As System.Text.UTF8Encoding
    Private encryptor As ICryptoTransform
    Private decryptor As ICryptoTransform



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
       
    End Sub

    Private Sub btnDecrypt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDecrypt.Click
        Using client As New Net.WebClient
            Dim reqparm As New Specialized.NameValueCollection
            reqparm.Add("username", USERNAME.Text)
            'reqparm.Add("title", TxtEncryptResult.Text)
            Dim responsebytes = client.UploadValues("http://misr-labs.ahomran.com/api/analyses", "POST", reqparm)
            Dim responsebody = (New System.Text.UTF8Encoding).GetString(responsebytes)
            TextBox1.Text = responsebody
        End Using

    End Sub

    Private Sub btnEncrypt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEncrypt.Click
        Using client As New Net.WebClient
            Dim reqparm As New Specialized.NameValueCollection
            reqparm.Add("analysis_id", 20)
            Dim responsebytes = client.UploadFile("http://misr-labs.ahomran.com/api/analyses/add-file", "POST", "c:\6.pdf")
            Dim responsebody = (New System.Text.UTF8Encoding).GetString(responsebytes)
            TextBox1.Text = responsebody
        End Using
    End Sub

End Class