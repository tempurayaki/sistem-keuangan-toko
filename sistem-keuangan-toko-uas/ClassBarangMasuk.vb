Imports System.Text
Imports MySql.Data.MySqlClient

Public Class ClassBarangMasuk

        Private idBarangMasuk As String
        Private jumlahBarangMasuk As String
        Private tanggalBarangMasuk As String
        Private barangDataTable As New ArrayList()

        'Database Global Variabel

        Public Shared sqlCommand As New MySqlCommand
        Public Shared myconnection As New ClassBarang
        Public Shared dadapter As MySqlDataAdapter
        Public Shared dTabel As New DataTable
        Private sqlQuery As String


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

        Public Property GSidBarangMasukProperty() As String
            Get
                Return idBarangMasuk
            End Get
            Set(ByVal value As String)
                idBarangMasuk = value
            End Set
        End Property

        Public Property GSjumlahBarangMasukProperty() As String
            Get
                Return jumlahBarangMasuk
            End Get
            Set(ByVal value As String)
                jumlahBarangMasuk = value
            End Set
        End Property

        Public Property GStanggalMasukBarangProperty() As String
            Get
                Return tanggalBarangMasuk
            End Get
            Set(ByVal value As String)
                tanggalBarangMasuk = value
            End Set
        End Property

        'Public Function GetDataKoleksiByIDDatabase(ID As Integer) As List(Of String)
        '    Dim result As New List(Of String)

        '    dbConn.ConnectionString = “server =" + server + ";" + “user id=" + username + ";" _
        '    + “password=" + password + ";" + “database =" + database
        '    dbConn.Open()
        '    sqlCommand.Connection = dbConn
        '    sqlCommand.CommandText = "SELECT id_barang_masuk, id_barang, jumlah_barang_masuk,
        '                            tanggal_barang_masuk
        '                                        FROM barang_masuk
        '                                        WHERE id_barang_masuk='" & ID & "'"

        '    sqlRead = sqlCommand.ExecuteReader

        '    While sqlRead.Read
        '        result.Add(sqlRead.GetString(0).ToString())
        '        result.Add(sqlRead.GetString(1).ToString())
        '        result.Add(sqlRead.GetString(2).ToString())
        '        result.Add(sqlRead.GetString(3).ToString())
        '    End While

        '    sqlRead.Close()
        '    dbConn.Close()
        '    Return result

        'End Function

        'Public Function UpdateDataBarangByIODatabase(ID As Integer,
        '                                              id_barang As String,
        '                                              jumlah_barang_masuk As Integer,
        '                                              tanggal_barang_masuk As String)

        '    dbConn.ConnectionString = “server =" + server + ";" + “user id=" + username + ";" _
        '        + “password=" + password + ";" + “database =" + database

        '    Try
        '        dbConn.Open()
        '        sqlCommand.Connection = dbConn
        '        sqlQuery = "UPDATE barang SET " &
        '                    “id_barang='" & id_barang & "', " &
        '                    “jumlah_barang_masuk='" & jumlah_barang_masuk & "', " &
        '                    “tanggal_barang_masuk='" & tanggal_barang_masuk & "' " &
        '                    “WHERE id_barang_masuk='" & ID & "'"
        '        Debug.WriteLine(sqlQuery)

        '        sqlCommand = New MySqlCommand(sqlQuery, dbConn)
        '        sqlRead = sqlCommand.ExecuteReader
        '        dbConn.Close()

        '        sqlRead.Close()
        '        dbConn.Close()

        '    Catch ex As Exception
        '        Return ex.Message
        '    Finally
        '        dbConn.Dispose()
        '    End Try

        '    Return ""

        'End Function

        Public Function ConvertBarangToString(vals As List(Of String))
            Dim builder As StringBuilder = New StringBuilder
            For Each val As String In vals
                builder.Append(val).Append("|")
            Next

            'Convert to String
            Dim res = builder.ToString()
            Return res
        End Function
        Public Function ConvertStringtoBarang(value As String)
            Dim arr() As String = value.Split("|")

            'Convert to List
            Dim vals As List(Of String) = arr.ToList()
            Return vals
        End Function

        'Public Function getdatabarangbyiddatabase(id As Integer) As List(Of String)
        '    Dim result As New List(Of String)

        '    dbConn.ConnectionString = “server =" + server + ";" + “user id=" + username + ";" _
        '    + “password=" + password + ";" + “database =" + database
        '    dbConn.Open()
        '    sqlCommand.Connection = dbConn
        '    sqlCommand.CommandText = "select id_barang_masuk,
        '                                            id_barang,
        '                                            jumlah_barang_masuk,
        '                                            tanggal_barang_masuk,
        '                                            from barang_masuk
        '                                            where id_barang_masuk='" & id & "'"

        '    sqlRead = sqlCommand.ExecuteReader

        '    While sqlRead.Read
        '        result.Add(sqlRead.GetString(0).ToString())
        '        result.Add(sqlRead.GetString(1).ToString())
        '        result.Add(sqlRead.GetString(2).ToString())
        '        result.Add(sqlRead.GetString(3).ToString())
        '    End While

        '    sqlRead.Close()
        '    dbConn.Close()
        '    Return result

        'End Function

    End Class

