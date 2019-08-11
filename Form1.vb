Public Class Form1
    Private Sub RaceResultToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RaceResultToolStripMenuItem.Click

        'Linking Form 1 to 2

        Form2.Show()

    End Sub

    Private Sub AthleticEventToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AthleticEventToolStripMenuItem.Click

        'Linking Form 1 to 3

        Form3.Show()

    End Sub

    Private Sub AthleteInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AthleteInfoToolStripMenuItem.Click



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        My.Computer.FileSystem.WriteAllText("C:\Users\stemm\Desktop\ICT3611\53951514_A1_S2_2019\TextFile1.txt", "" & txtMemberNumber.Text, True, & txtName.Text, True)

    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged

    End Sub
End Class
