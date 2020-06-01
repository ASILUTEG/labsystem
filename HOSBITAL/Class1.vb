Imports Microsoft.VisualBasic
Imports System.net.Mail

Public Class SendEmail
    Public Sub SendEmailMessage(ByVal strFrom As String, ByVal strTo() _
    As String, ByVal strSubject _
    As String, ByVal strMessage _
    As String, ByVal fileList() As String)
        'This procedure takes string array parameters for multiple recipients and files
        Try
            For Each item As String In strTo
                'For each to address create a mail message
                Dim MailMsg As New MailMessage(New MailAddress(strFrom.Trim()), _
                               New MailAddress(item))
                'MailMsg.BodyEncoding = Encoding.Default
                MailMsg.Subject = strSubject.Trim()
                MailMsg.Body = strMessage.Trim() & vbCrLf
                MailMsg.Priority = MailPriority.High
                MailMsg.IsBodyHtml = True

                'attach each file attachment
                For Each strfile As String In fileList
                    If Not strfile = "" Then
                        Dim MsgAttach As New Attachment(strfile)
                        MailMsg.Attachments.Add(MsgAttach)
                    End If
                Next

                'Smtpclient to send the mail message
                Dim SmtpMail As New SmtpClient
                SmtpMail.Host = "10.10.10.10"
                SmtpMail.Send(MailMsg)
            Next
            'Message Successful
        Catch ex As Exception
            'Message Error
        End Try
    End Sub

    Public Sub SendEmailMessage(ByVal strFrom As String, ByVal strTo _
    As String, ByVal strSubject _
    As String, ByVal strMessage _
    As String, ByVal file As String)
        'This procedure overrides the first procedure and accepts a single
        'string for the recipient and file attachement 
        Try
            Dim MailMsg As New MailMessage(New MailAddress(strFrom.Trim()), _
                           New MailAddress(strTo))
            'MailMsg.BodyEncoding = Encoding.Default
            MailMsg.Subject = strSubject.Trim()
            MailMsg.Body = strMessage.Trim() & vbCrLf
            MailMsg.Priority = MailPriority.High
            MailMsg.IsBodyHtml = True

            If Not file = "" Then
                Dim MsgAttach As New Attachment(file)
                MailMsg.Attachments.Add(MsgAttach)
            End If

            'Smtpclient to send the mail message
            Dim SmtpMail As New SmtpClient
            SmtpMail.Host = "10.10.10.10"
            SmtpMail.Send(MailMsg)
        Catch ex As Exception
            'Message Error
        End Try
    End Sub
End Class
