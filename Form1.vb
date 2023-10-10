Imports System.Reflection.Emit

Public Class Form1
    Dim password As Integer
    Dim crackpass As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        generate()
        If crackpass = password Then
            Timer1.Enabled = False
            TextBox1.Text = crackpass
            MsgBox("Password Cracked!Login Successful!")
        Else TextBox1.Text = crackpass
            TextBox2.Text = "Please wait..."
        End If
    End Sub

    Sub generate()
        crackpass = Int(Rnd() * 100) + 100
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        password = 123
    End Sub
End Class
