Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient

Public Class ClassUser

    ''Sql Login
    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username_db As String = "root"
    Private password_db As String = ""
    Private database As String = "sistem-keuangan-toko"

    Private UserName As String
    Private Password As String
    Private Email As String
    Private KoleksiUsers As New ArrayList()

    Dim listofAkun As New ArrayList()

    Private TripleDes As New TripleDESCryptoServiceProvider
    'Dim connect As New MySqlConnection("server=localhost;username=root;password='';database='sistem-keuangan-toko';Convert Zero Datetime=True")

    Public Property GSUserName() As String
        Get
            Return UserName
        End Get
        Set(ByVal value As String)
            UserName = value
        End Set
    End Property

    Public Property GSPassword() As String
        Get
            Return Password
        End Get
        Set(ByVal value As String)
            Password = value
        End Set
    End Property

    Public Property GSEmail() As String
        Get
            Return Email
        End Get
        Set(ByVal value As String)
            Email = value
        End Set
    End Property

    Public Sub New()
        listofAkun.Add({"admin", EncryptData("admin"), "admin"})
    End Sub


    'Fungsi menambahkan User Database
    Public Function AddUserDataBase(username_regist As String, password_regist As String, email_regist As String)
        Try
            Dim today = Date.Now()

            dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username_db + ";" _
                                       + "password=" + password_db + ";" + "database =" + database

            dbConn.Open()

            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO USERS (username, password, email) VALUE('" _
                        & username_regist & "', '" _
                        & EncryptMD5(password_regist) & "', '" _
                        & email_regist & "')"

            Debug.WriteLine(sqlQuery)

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex.Message

            'Catch SQLEX As SqlException
            '    MessageBox.Show(SQLEX)

        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function RegisteredUser(registeredUsername As String, registeredPassword As String, registeredEmail As String) As Boolean

        For Each akun In listofAkun
            If String.Compare(registeredUsername, akun(0)) = 0 Then
                Return False
            Else
                listofAkun.Add({registeredUsername, EncryptData(registeredPassword), registeredEmail})
                Return True
            End If
        Next

    End Function

    'fungsi enskripsi data
    Public Function EncryptData(ByVal plaintext As String) As String

        'Convert the plaintext string to byte array
        Dim plaintextBytes() As Byte =
            System.Text.Encoding.Unicode.GetBytes(plaintext)

        'Create the stream
        Dim ms As New System.IO.MemoryStream
        'Create the encoder towrite to stream
        Dim encStream As New CryptoStream(ms,
        TripleDes.CreateEncryptor(),
        System.Security.Cryptography.CryptoStreamMode.Write)

        'Use the crypto stream to write the vyte array to the stream
        encStream.Write(plaintextBytes, 0, plaintextBytes.Length)
        encStream.FlushFinalBlock()

        'Convert the encrypted stream to a printable string
        Return Convert.ToBase64String(ms.ToArray)
    End Function

    'fungsi pengecekan autentikasi akun
    Public Function checkauth(plainusername As String, ByVal plainpassword As String, plainemail As String) As String
        Dim returnvalue = 0

        For Each akun In listofAkun
            If String.Compare(plainusername, akun(0)) = 0 Then
                If String.Compare(EncryptData(plainpassword), akun(1)) = 0 Then
                    If String.Compare(plainemail, akun(2)) = 0 Then
                        returnvalue = 3
                        Exit For
                    Else
                        returnvalue = 2
                        Exit For
                    End If
                    returnvalue = 1
                    Exit For
                End If
            Else
                returnvalue = 0
            End If
        Next

        Return returnvalue
    End Function

    Public Function EncryptMD5(ByVal password As String)
        Dim x As New System.Security.Cryptography.MD5CryptoServiceProvider()
        Dim bs As Byte() = System.Text.Encoding.UTF8.GetBytes(password)
        bs = x.ComputeHash(bs)
        Dim s As New System.Text.StringBuilder()
        For Each b As Byte In bs
            s.Append(b.ToString("x2").ToLower())
        Next
        Return s.ToString()
    End Function

    Public Function CheckAuthdatabase(username_login As String, password_login As String, email_login As String)
        Try
            Dim result As New List(Of String)

            dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username_db + ";" _
                                       + "password=" + password_db + ";" + "database =" + database
            dbConn.Open()
            sqlCommand.Connection = dbConn

            Dim queryAuth = "SELECT id_user, username FROM users
                             WHERE username='" & username_login & "'AND password='" & EncryptMD5(password_login) & "'AND email='" & email_login & "'"

            sqlCommand.CommandText = queryAuth
            Debug.WriteLine(queryAuth)
            sqlRead = sqlCommand.ExecuteReader

            If sqlRead.HasRows Then
                While sqlRead.Read

                    result.Add(sqlRead.GetString(0).ToString())
                    result.Add(sqlRead.GetString(1).ToString())

                End While
            End If

            sqlRead.Close()
            dbConn.Close()
            Return result

        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        Finally
            dbConn.Dispose()
        End Try
    End Function

End Class
