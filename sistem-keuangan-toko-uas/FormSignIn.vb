Public Class FormSignIn
    Public Shared User As New ClassUser()
    Public Shared Barang As FormBarang

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        User = New ClassUser()
        Barang = New FormBarang()

    End Sub

    Private Sub BtnSignIn_Click(sender As Object, e As EventArgs) Handles BtnSignIn.Click
        Dim plainUsername As String = Txt_Username.Text
        Dim plainPassword As String = Txt_Password.Text
        Dim plainEmail As String = Txt_Email.Text
        'Dim Encrypted As String = ClassUsers.EncryptData(plainPassword)
        Dim data_user As List(Of String) = User.CheckAuthdatabase(plainUsername, plainPassword, plainEmail)

        If data_user.Count > 0 Then
            User.GSUserName = data_user(1)
            'User.GSPassword = data_user(1)
            FormBarang.Show()
            Me.Hide()
        Else
            MessageBox.Show("Salah username atau password")
        End If
    End Sub

    Private Sub BtnSignUp_Click(sender As Object, e As EventArgs) Handles BtnSignUp.Click
        FormSignUp.Show()
    End Sub

    Private Sub FormSignIn_Load(sender As Object, e As EventArgs) Handles Me.Load
        Txt_Password.UseSystemPasswordChar = True
    End Sub

End Class