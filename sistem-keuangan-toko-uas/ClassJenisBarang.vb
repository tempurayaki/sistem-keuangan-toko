
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class ClassJenisBarang


    ''Deklrasi variable''
    Private namaJenisBarang As String

    ''Deklrasi untuk MYSQl di class jenis barang''
    Private jenisBarangTable As New ArrayList()

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "sistem-keuangan-toko"

    ''Untuk Read data di database''
    Public Function GetDataJenisBarangDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
                + "password =" + password + ";" + "database =" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_jenis_barang AS 'ID',
                                         jenis_barang AS 'Jenis Barang'
                                            FROM jenis_barang"
        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    ''Untuk menambahkan database
    Public Function AddDataJenisBarangDatabase(jenis_barang As String)
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
                + "password=" + password + ";" + "database =" + database
        dbConn.Open()
        Try
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO JENIS_BARANG(jenis_barang)
                    VALUE ('" _
                        & jenis_barang & "')"

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            'formjenisbarang.sqlDt.load(sqlread)'
            sqlRead.Close()
            dbConn.Close()

        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
        Return ""
    End Function

    ''Untuk membaca data berdasarkan ID jenis barang''
    Public Function GetdataJenisBarangByIDDatabase(ID As Integer) As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
                + "password=" + password + ";" + "database =" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_jenis_barang,
                                            jenis_barang
                                            FROM jenis_barang
                                            WHERE id_jenis_barang='" & ID & "'"
        sqlRead = sqlCommand.ExecuteReader

        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
            result.Add(sqlRead.GetString(1).ToString())
        End While

        sqlRead.Close()
        dbConn.Close()
        Return result

    End Function

    ''Fungsi untuk update table''
    Public Function UpdateDataJenisBarangByIDDatabase(ID As Integer,
                                                            jenis_barang As String)
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
               + "password=" + password + ";" + "database =" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "UPDATE jenis_barang SET " &
                            "jenis_barang ='" & jenis_barang & "' " &
                            "WHERE id_jenis_barang ='" & ID & "'"


            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader

            dbConn.Close()
            sqlRead.Close()
            dbConn.Close()

        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try

        Return ""

    End Function

    Public Function DeleteDataJenisBarangByIDDatabase(ID As Integer)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
               + "password=" + password + ";" + "database =" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "DELETE FROM jenis_barang " &
                            "WHERE id_jenis_barang='" & ID & "'"

            Debug.WriteLine(sqlQuery)

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            'Perpustakaan.sqlDt.Load(sqlread)
            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try

    End Function


    ''getter and setter untuk nama jenis barang''
    Public Property namaJenisBarangProperty() As String
        Get
            Return namaJenisBarang
        End Get
        Set(ByVal value As String)
            namaJenisBarang = value
        End Set
    End Property

End Class
