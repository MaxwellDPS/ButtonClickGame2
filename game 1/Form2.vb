Imports game_1.Form1
Public Class Form2
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim premode As String
        If RadioButton1.Checked = True Then
            premode = "easy"
        ElseIf RadioButton2.Checked = True Then
            premode = "normal"
        ElseIf RadioButton3.Checked = True Then
            premode = "extreme"
        ElseIf RadioButton4.Checked = True Then
            premode = "DANGER"


        End If
        Form1.gamemode(premode)
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged

    End Sub
End Class