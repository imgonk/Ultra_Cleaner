Public Class Form2

    Private Sub ProgressBar1_Click(sender As System.Object, e As System.EventArgs) Handles ProgressBar1.Click
        
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        MsgBox("The cleaning will start", MsgBoxStyle.Information, "Info")
        Timer1.Start()
        My.Computer.FileSystem.DeleteDirectory("C:\WINDOWS\Temp",
FileIO.DeleteDirectoryOption.DeleteAllContents)
        MsgBox("Cleaning Stoped", MsgBoxStyle.Information, "Info")
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            MsgBox("Cleaning Stoped", MsgBoxStyle.Information, "Info")
        End If
    End Sub
End Class