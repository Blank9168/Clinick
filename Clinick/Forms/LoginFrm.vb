Public Class LoginFrm
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text
        Dim employee As String = "Employee"
        Dim employeePass As String = "Clinick123"
        Dim admin As String = "Admin"
        Dim adminPass As String = "Admin123"

        If username = employee AndAlso password = employeePass Then
            MessageBox.Show("Login successful! Welcome, Employee.")
            Dim employeeFrm As New MainFrm()
            employeeFrm.Show()
            Me.Hide()
        ElseIf username = admin AndAlso password = adminPass Then
            MessageBox.Show("Login successful! Welcome, Admin.")
            Dim adminFrm As New AdminFrm()
            adminFrm.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid username or password. Please try again.")
        End If

    End Sub
End Class
