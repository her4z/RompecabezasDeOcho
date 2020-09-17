Public Class frmMenu
    Private Sub btMode3x3_Click(sender As Object, e As EventArgs) Handles btMode3x3.Click
        mode = False
        frmMain.Show()
        Me.Hide()
    End Sub

    Private Sub btMode4x4_Click(sender As Object, e As EventArgs) Handles btMode4x4.Click
        mode = True
        frmMain.Show()
        Me.Hide()
    End Sub

    Private Sub btExit_Click(sender As Object, e As EventArgs) Handles btExit.Click
        Dim response As DialogResult = MessageBox.Show("¿Estas seguro que deseas salir del juego?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = 6 Then
            Application.Exit()
        End If
    End Sub

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
