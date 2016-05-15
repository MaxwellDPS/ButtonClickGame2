Public Class Form1
    Dim intchange As Int32
    Dim level As Int32 = 1
    Dim gametime As Int32 = 0
    Dim btnsr As Boolean
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Timer1.Enabled = True Then
            Try
                Timer1.Interval = Timer1.Interval - intchange
                MsgBox("good job you caught me now lets go faster!:0")
                level = level + 1
            Catch
                Form3.Show()
                Me.Close()
            End Try
        Else
            Button1.Text = "click me"
            Timer1.Enabled = True
            Timer2.Start()
        End If
    End Sub
    Sub gamemode(mode As String)
        If mode = "easy" Then
            Timer1.Interval = 2000
            intchange = 50
            btnsr = False
            btnreset()
        ElseIf mode = "normal" Then
            Timer1.Interval = 1500
            intchange = 100
            btnsr = False
            btnreset()
        ElseIf mode = "extreme" Then
            Timer1.Interval = 1000
            intchange = 150
            btnsr = False
            btnreset()
        ElseIf mode = "DANGER" Then
            Timer1.Interval = 1000
            intchange = 250
            btnsr = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
        Me.Close()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        rocknroll(1080, 700, btnsr)
    End Sub
    Public Sub rocknroll(xvalue As Int32, yvalue As Int32, rdm As Boolean)
        Randomize()
        Dim btnx As Int32
        Dim btny As Int32
        Dim btnw As Int32
        Dim btnh As Int32
        btnx = CInt(Int((xvalue * Rnd()) + 1))
        btny = CInt(Int((yvalue * Rnd()) + 1))
        btnw = CInt(Int((500 * Rnd()) + 1))
        btnh = CInt(Int((500 * Rnd()) + 1))
        Button1.Location = New Point(btnx, btny)
        If rdm = True Then
            Button1.Width = btnw
            Button1.Height = btnh
        End If
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        gametime = gametime + 1
    End Sub
    Sub btnreset()
        Button1.Width = 122
        Button1.Height = 57
    End Sub
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        ToolStripStatusLabel2.Text = gametime.ToString
        ToolStripStatusLabel4.Text = level.ToString
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
