Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n1 As Integer
        Dim n2 As Integer
        Dim n3 As Integer
        Dim Menor As Integer

        n1 = CInt(TextBox1.Text())
        n2 = CInt(TextBox2.Text())
        n3 = CInt(TextBox3.Text())
        If (n1 < n2) And n1 < n3 Then
            Menor = n1
        ElseIf n2 < n1 And n2 < n3 Then
            Menor = n2
        Else
            Menor = n3

        End If

        Label1.Text = Menor.ToString()

    End Sub

    Private Sub TextBox3_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class
