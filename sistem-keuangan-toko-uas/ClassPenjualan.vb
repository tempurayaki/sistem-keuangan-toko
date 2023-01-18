Imports MySql.Data.MySqlClient

Public Class ClassPenjualan

    Private barangDataTable As New ArrayList()

    'Database Global Variabel
    Public Shared sqlCommand As New MySqlCommand
    Public Shared myconnection As New ClassBarang
    Public Shared dadapter As MySqlDataAdapter
    Public Shared dTabel As New DataTable
    Private sqlQuery As String


    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "sistem-keuangan-toko"

    'penyingkatan dbConn (MySQLConnection)
    Dim connect As New MySqlConnection("server=localhost;username=root;password='';database='sistem-keuangan-toko';Convert Zero Datetime=True")

    Public Function open() As MySqlConnection
        Try
            connect.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return connect
    End Function

    Public Function close() As MySqlConnection
        Try
            connect.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return connect
    End Function
End Class
