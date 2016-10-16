Public Class KshellForm
    Public abgebrochen As Boolean = True

    Private Sub KshellForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        abgebrochen = True
        TextBox1.Text = ""
        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 0
        ComboBox3.SelectedIndex = 1
        TextBox1.Select()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.SelectedIndex
            Case 0
                ComboBox2.Enabled = True
            Case 1
                ComboBox2.Enabled = False
            Case 2
                ComboBox2.Enabled = True
            Case 3
                ComboBox2.Enabled = False
        End Select
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        abgebrochen = False
        Me.Close()
    End Sub
End Class