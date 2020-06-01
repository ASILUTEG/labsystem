Imports System
Imports System.Threading
Imports System.IO.Ports
Imports System.ComponentModel

Public Class Form4

    '------------------------------------------------
    Dim myPort As Array
    Delegate Sub SetTextCallback(ByVal [text] As String) 'Added to prevent threading errors during receiveing of data
    '------------------------------------------------
    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        myPort = IO.Ports.SerialPort.GetPortNames()
        ComboBox1.Items.AddRange(myPort)

        Button2.Enabled = False

    End Sub
    '------------------------------------------------
    Private Sub ComboBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.Click
    End Sub
    '------------------------------------------------
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        SerialPort1.PortName = ComboBox1.Text
        SerialPort1.BaudRate = ComboBox2.Text
        SerialPort1.Open()
        Button1.Enabled = False
        Button2.Enabled = True
        Button4.Enabled = True

    End Sub
    '------------------------------------------------
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        SerialPort1.Write(RichTextBox1.Text & vbCr) 'concatenate with \n
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        SerialPort1.Close()
        Button1.Enabled = True
        Button2.Enabled = False
        Button4.Enabled = False
    End Sub

    Private Sub SerialPort1_DataReceived(ByVal sender As System.Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        ReceivedText(SerialPort1.ReadExisting())
    End Sub

    Private Sub ReceivedText(ByVal [text] As String) 'input from ReadExisting
        
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If Me.RichTextBox2.InvokeRequired Then
            Dim x As New SetTextCallback(AddressOf ReceivedText)
            Me.Invoke(x, New Object() {(Text)})
        Else
            Me.RichTextBox2.Text &= [Text] 'append text
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        'Dim oldMS As New System.IO.MemoryStream
        'PictureBox1.Image.Save(oldMS, System.Drawing.Imaging.ImageFormat.Jpeg)
        'Dim strData As String = Convert.ToBase64String(TextBox1.Text)

        'Debug.Print(strData)

        Dim bytes() As Byte = Convert.FromBase64String(TextBox1.Text) ' strData would come from your CSV file
        Dim MS As New System.IO.MemoryStream(bytes)
        Dim bmp As Image = Image.FromStream(MS)
        PictureBox1.Image = bmp
    End Sub
End Class