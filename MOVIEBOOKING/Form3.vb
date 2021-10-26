Public Class Form3
    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        select1.Visible = True
        select2.Visible = False
        select3.Visible = False
        select4.Visible = False
        select5.Visible = False
        homepanel.Visible = True
        addmovie.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        select1.Visible = False
        select2.Visible = True
        select3.Visible = False
        select4.Visible = False
        select5.Visible = False
        addmovie.Visible = True
        homepanel.Visible = False



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        select1.Visible = False
        select2.Visible = False
        select3.Visible = True
        select4.Visible = False
        select5.Visible = False
        homepanel.Visible = False
        addmovie.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        select1.Visible = False
        select2.Visible = False
        select3.Visible = False
        select4.Visible = True
        select5.Visible = False
        homepanel.Visible = False
        addmovie.Visible = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        select1.Visible = False
        select2.Visible = False
        select3.Visible = False
        select4.Visible = False
        select5.Visible = True
        homepanel.Visible = False
        addmovie.Visible = False
    End Sub

    Private Sub addpic_Click(sender As Object, e As EventArgs) Handles addpic.Click

        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles actionc.CheckedChanged

        Dim Value As String

        Value = "Action,"
        If actionc.Checked = True Then
            TextBoxgenre.Text += Value
        Else actionc.Checked = False
            TextBoxgenre.Text = ""
        End If





    End Sub

    Private Sub comedyc_CheckedChanged(sender As Object, e As EventArgs) Handles comedyc.CheckedChanged
        Dim Value As String

        Value = "Comedy,"
        If comedyc.Checked = True Then
            TextBoxgenre.Text += Value
        Else comedyc.Checked = False
            TextBoxgenre.Text = ""
        End If
    End Sub

    Private Sub horrorc_CheckedChanged(sender As Object, e As EventArgs) Handles horrorc.CheckedChanged
        Dim Value As String

        Value = "HORROR,"
        If horrorc.Checked = True Then
            TextBoxgenre.Text += Value
        Else horrorc.Checked = False
            TextBoxgenre.Text = ""
        End If
    End Sub

    Private Sub dramac_CheckedChanged(sender As Object, e As EventArgs) Handles dramac.CheckedChanged
        Dim Value As String

        Value = "Drama,"
        If dramac.Checked = True Then
            TextBoxgenre.Text += Value
        Else dramac.Checked = False
            TextBoxgenre.Text = ""
        End If
    End Sub

    Private Sub adventurec_CheckedChanged(sender As Object, e As EventArgs) Handles adventurec.CheckedChanged
        Dim Value As String

        Value = "Adventure,"
        If adventurec.Checked = True Then
            TextBoxgenre.Text += Value
        Else adventurec.Checked = False
            TextBoxgenre.Text = ""
        End If
    End Sub

    Private Sub scific_CheckedChanged(sender As Object, e As EventArgs) Handles scific.CheckedChanged
        Dim Value As String

        Value = "Sci-fi,"
        If scific.Checked = True Then
            TextBoxgenre.Text += Value
        Else scific.Checked = False
            TextBoxgenre.Text = ""
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged


    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub addmovie_Paint(sender As Object, e As PaintEventArgs) Handles addmovie.Paint

    End Sub
End Class