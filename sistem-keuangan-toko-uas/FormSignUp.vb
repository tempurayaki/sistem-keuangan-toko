Public Class FormSignUp
    Private Sub BtnSignUp_Click(sender As Object, e As EventArgs) Handles BtnSignUp.Click
        Dim registeredUsername As String = Txt_Username.Text
        Dim registeredPassword As String = Txt_Password.Text
        Dim registeredEmail As String = Txt_Email.Text


        Dim regist = FormSignIn.User.RegisteredUser(registeredUsername, registeredPassword, registeredEmail)

        If regist And Txt_Username.Text.Length > 0 And Txt_Password.Text.Length > 0 Then
            ''LB_Akun.Items.Add(Txt_Username.Text)
            FormSignIn.User.AddUserDataBase(Txt_Username.Text, Txt_Password.Text, Txt_Email.Text)
            MessageBox.Show("Berhasil Ditambahkan")
            Me.Hide()
        ElseIf Txt_Username.Text IsNot Nothing And Txt_Password.Text IsNot Nothing Then
            MessageBox.Show("Lengkapi data")
        Else
            MessageBox.Show("Username telah terdaftar")
            Txt_Username.Clear()
            Txt_Password.Clear()
            Txt_Email.Clear()
        End If

        'If Txt_Username.Text.Length > 0 And Txt_Password.Text.Length > 0 Then
        '    FormSignIn.User.AddUserDataBase(Txt_Username.Text, Txt_Password.Text, Txt_Email.Text)
        '    Me.Close()
        'Else
        '    MessageBox.Show("Lengkapi data")
        'End If
    End Sub

    Private Sub FormSignUp_Load(sender As Object, e As EventArgs) Handles Me.Load
        Txt_Password.UseSystemPasswordChar = True
    End Sub

End Class
