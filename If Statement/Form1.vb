Public Class Form1
    Private Sub btnGreeting_Click(sender As Object, e As EventArgs) Handles btnGreeting.Click
        Dim Country As String

        Country = txtCountry.Text.ToLower

        If Country = "south africa" Then
            MsgBox("Thobela")

        ElseIf Country = "france" Then
            MsgBox("bonjou")

        ElseIf Country = "china" Then
            MsgBox("hongcheahong")

        ElseIf Country = "india" Then
            MsgBox("Habibi")

        Else
            MsgBox("Hello")

        End If
    End Sub
End Class
