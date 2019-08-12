Imports System.IO

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

        If txtMemberNumber.Text = "" Then
            MessageBox.Show("You must enter a number")
        ElseIf IsNumeric(txtMemberNumber.Text) Then
            MessageBox.Show("You entered a number")
        Else
            MessageBox.Show("You entered a string")


        End If


        'writing data to txt file

        Dim writer As TextWriter = New StreamWriter("C:\Users\stemm\Desktop\ICT3611\53951514_A1_S2_2019\53951514_A1_S2_2019\Athlete.txt")

        writer.Write((txtMemberNumber.Text & " ") & (txtName.Text & " ") & (txtSurname.Text & " ") & (DateTimePicker1.Text.ToString & " ") & (Male.Text))

        writer.Close()

        MessageBox.Show("Exported")

        'adding data to gridview


        Me.DataGridView1.Rows.Add(txtMemberNumber.Text, txtName.Text, txtSurname.Text, DateTimePicker1.Value.ToString, Male.Name.ToString, Female.Name.ToString)



    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
