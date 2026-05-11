Public Class LoginFrm
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text


        If username = "Employee" AndAlso password = "Clinick123" Then
            CurrentUser = "Employee"
            MessageBox.Show("Login successful! Welcome, Employee.")
            MainFrm.Show()
            Me.Hide()
        ElseIf username = "Admin" AndAlso password = "Admin123" Then
            CurrentUser = "Admin"
            MessageBox.Show("Login successful! Welcome, Admin.")
            MainFrm.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid username or password.")
        End If

    End Sub

    Private Sub cbShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles cbShowPass.CheckedChanged
        If cbShowPass.Checked Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub
End Class
