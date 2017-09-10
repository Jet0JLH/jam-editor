Public Class IfWindow
    Public abgebrochen As Boolean = True
    Private Sub IfWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clear()
    End Sub
    Private Sub clear()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 0
        abgebrochen = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" Then
            abgebrochen = False
            Me.Close()
        Else
            MsgBox("Die benötigten Felder sind nicht ausgefüllt!")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        abgebrochen = True
        Me.Close()
    End Sub
    Public Function getOperator() As String
        Select Case ComboBox1.SelectedIndex
            Case 0
                Return "<"
            Case 1
                Return ">"
            Case 2
                Return "<="
            Case 3
                Return ">="
            Case 4
                Return "="
            Case 5
                Return "!="
            Case 6
                Return "contains"
            Case 7
                Return "startswith"
            Case 8
                Return "endswith"
        End Select
        Return "?"
    End Function
End Class