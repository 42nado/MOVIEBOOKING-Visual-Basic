Public Class Form4
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Pbar.Value = Pbar.Value + 1
        If Pbar.Value >= 100 Then
            Timer1.Stop()
            Form1.Show()
            Me.Hide()

        End If
    End Sub

    Private Sub Pbar_Click(sender As Object, e As EventArgs) Handles Pbar.Click

    End Sub
End Class