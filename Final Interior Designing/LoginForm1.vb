Imports System.Data.SqlClient
Imports System.Net.Mail
Imports System.Drawing.Drawing2D

Public Class LoginForm1

    Dim Str As String
    Dim email, password As String
    Dim Mail As New MailMessage

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.


    Private Sub OK_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd0 As New SqlCommand("select*from Login where username='" & UsernameTextBox.Text & "' and password='" & PasswordTextBox.Text & "'", conn)
        Dim d1 As SqlDataReader = cmd0.ExecuteReader()

        If d1.HasRows Then
            MsgBox("login success")
            MDIParent1.Show()
            Me.Hide()
        Else
            MsgBox("invalid login")

        End If
        If conn.State = ConnectionState.Open Then conn.Close()

    End Sub

    Private Sub Cancel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub


    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd0 As New SqlCommand("select * from  Login where username='" & UsernameTextBox.Text & "'", conn)
        Dim d1 As SqlDataReader = cmd0.ExecuteReader()
        If d1.HasRows Then
            d1.Read()
            email = d1(2).ToString
            password = d1(1).ToString
            Mail.Subject = "Interior Designing"
            Mail.To.Add(email)
            Mail.From = New MailAddress("harshatr11@gmail.com")
            Mail.Body = ("Your Forgotten Password is: " + password + vbNewLine)
            Dim SMTP As New SmtpClient("smtp.gmail.com")
            SMTP.EnableSsl = True
            SMTP.Credentials = New System.Net.NetworkCredential("harshatr11@gmail.com", "tetuihvdhtgqdtkf")
            SMTP.Port = "587"
            SMTP.Send(mail)
            MsgBox("send")
        Else
            MsgBox("invalid login")
        End If
        If conn.State = ConnectionState.Open Then conn.Close()
    End Sub
End Class
