Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient
Public Class ClassBarang

    Private idBarang As String
    Private idjenisbarang As String
    Private namaBarang As String
    Private tanggalkadaluarsaBarang As String
    Private tanggalMasukBarang As String
    Private stock As Integer
    Private hargaBarang As Integer

    Private barangDataTable As New ArrayList()

    'Database Global Variabel
    Public Shared sqlCommand As New MySqlCommand
    Public Shared myconnection As New ClassBarang
    Public Shared dadapter As MySqlDataAdapter
    Public Shared dTabel As New DataTable
    Private sqlQuery As String

    'Public dt As New DataTable
    'Dim myconnection As New ClassBarang
    'Dim dadapter As MySqlDataAdapter
    'Dim dTabel As New DataTable

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

    'Public Function GetDataBarangDatabase() As DataTable
    '    Dim result As New DataTable

    '    dbConn.ConnectionString = "SERVER =" + server + ";" + "user id= " + username + ";" + "password= " + password + ";" + "database = " + database
    '    dbConn.Open()
    '    sqlCommand.Connection = dbConn
    '    sqlCommand.CommandText = "SELECT id_barang AS 'ID',
    '                              nama_barang AS 'Nama Barang',
    '                              stock AS 'Stock',
    '                              harga AS 'Harga',
    '                              tanggal_masuk AS 'Tanggal Masuk',
    '                              tanggal_kadaluarsa AS 'Tanggal Kadaluarsa'
    '                              FROM barang"

    '    sqlRead = sqlCommand.ExecuteReader

    '    result.Load(sqlRead)
    '    sqlRead.Close()
    '    dbConn.Close()
    '    Return result
    'End Function

    'Public Function GetDataKoleksiByIDDatabase(ID As Integer) As List(Of String)
    '    Dim result As New List(Of String)

    '    dbConn.ConnectionString = “server =" + server + ";" + “user id=" + username + ";" _
    '    + “password=" + password + ";" + “database =" + database
    '    dbConn.Open()
    '    sqlCommand.Connection = dbConn
    '    sqlCommand.CommandText = "SELECT id_barang, nama_barang, stock,harga,
    '                            tanggal_masuk, tanggal_kadaluarsa
    '                                        FROM sistem-keuangan-toko
    '                                        WHERE id_barang='" & ID & "'"

    '    sqlRead = sqlCommand.ExecuteReader

    '    While sqlRead.Read
    '        result.Add(sqlRead.GetString(0).ToString())
    '        result.Add(sqlRead.GetString(1).ToString())
    '        result.Add(sqlRead.GetString(2).ToString())
    '        result.Add(sqlRead.GetString(3).ToString())
    '        result.Add(sqlRead.GetString(4).ToString())
    '        result.Add(sqlRead.GetString(5).ToString())
    '    End While

    '    sqlRead.Close()
    '    dbConn.Close()
    '    Return result

    'End Function

    'Public Function UpdateDataBarangByIODatabase(ID As Integer,
    '                                              nama_barang As String,
    '                                              stock As Integer,
    '                                              harga As Integer,
    '                                              tanggal_masuk As String,
    '                                              tanggal_kadaluarsa As String)

    '    'tanggal_masuk = tanggal_masuk.ToString()
    '    'tanggal_kadaluarsa = tanggal_kadaluarsa.ToString()

    '    dbConn.ConnectionString = “server =" + server + ";" + “user id=" + username + ";" _
    '        + “password=" + password + ";" + “database =" + database

    '    Try
    '        dbConn.Open()
    '        sqlCommand.Connection = dbConn
    '        sqlQuery = "UPDATE sistem-keuangan-toko SET " &
    '                    “nama_barang='" & nama_barang & "', " &
    '                    “stock='" & stock & "', " &
    '                    “harga='" & harga & "', " &
    '                    “tanggal_masuk='" & tanggal_masuk & "', " &
    '                    “tanggal_kadaluarsa='" & tanggal_kadaluarsa & "' " &
    '                    “WHERE id_barang='" & ID & "'"
    '        Debug.WriteLine(sqlQuery)

    '        sqlCommand = New MySqlCommand(sqlQuery, dbConn)
    '        sqlRead = sqlCommand.ExecuteReader
    '        dbConn.Close()

    '        'Perpustakaan Closed
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

    '    Public Function ConvertBarangToString(vals As List(Of String))
    '        Dim builder As StringBuilder = New StringBuilder
    '        For Each val As String In vals
    '            builder.Append(val).Append("|")
    '        Next

    '        'Convert to String
    '        Dim res = builder.ToString()
    '        Return res
    '    End Function

    '    Public Function RemoveBarangDataTable(index As Integer)
    '        barangDataTable.RemoveAt(index)
    '    End Function

    '    Public Function RemoveKoleksiDataTable(index As Integer)
    '        barangDataTable.RemoveAt(index)
    '    End Function
    '    Public ReadOnly Property getBarangDataTable() As ArrayList
    '        Get
    '            Return barangDataTable
    '        End Get
    '    End Property

    'Public Function getDataBarangByIDDatabase(id As Integer) As List(Of String)
    '    Dim result As New List(Of String)

    '    dbConn.ConnectionString = “server =" + server + ";" + “user id=" + username + ";" _
    '    + “password=" + password + ";" + “database =" + database
    '    dbConn.Open()
    '    sqlCommand.Connection = dbConn
    '    sqlCommand.CommandText = "select id_barang,
    '                                            nama_barang,
    '                                            stock,
    '                                            harga,
    '                                            tanggal_masuk,
    '                                            tanggal_kadaluarsa,
    '                                            from barang
    '                                            where id_barang='" & id & "'"

    '    sqlRead = sqlCommand.ExecuteReader

    '    While sqlRead.Read
    '        result.Add(sqlRead.GetString(0).ToString())
    '        result.Add(sqlRead.GetString(1).ToString())
    '        result.Add(sqlRead.GetString(2).ToString())
    '        result.Add(sqlRead.GetString(3).ToString())
    '        result.Add(sqlRead.GetString(4).ToString())
    '        result.Add(sqlRead.GetString(5).ToString())

    '    End While

    '    sqlRead.Close()
    '    dbConn.Close()
    '    Return result

    'End Function



    'Public Function addDataKoleksiDatabase(nama_barang As String,
    '                                              stock_barang As Integer,
    '                                              harga_barang As Integer,
    '                                              tanggal_masuk_barang As String,
    '                                              tanggal_kadaluarsa_barang As String)

    '    dbConn.ConnectionString = "SERVER =" + server + ";" + "user id= " + username + ";" _
    '        + "password= " + password + ";" + "database = " + database

    '    Try
    '        dbConn.Open()
    '        sqlCommand.Connection = dbConn
    '        sqlQuery = "INSERT INTO KOLEKSI(nama_barang, stock_gambar,
    '                        harga_barang, tanggal_masuk_barang, tanggal_kadaluarsa_barang) 
    '                        VALUE('" _
    '                    & nama_barang & "', '" _
    '                    & stock_barang & "', '" _
    '                    & harga_barang & "', '" _
    '                    & tanggal_masuk_barang.ToString("yyyy/MM/dd") & "', '" _
    '                    & tanggal_kadaluarsa_barang.ToString("yyyy/MM/dd") & "')"

    '        Debug.WriteLine(sqlQuery)

    '        sqlCommand = New MySqlCommand(sqlQuery, dbConn)
    '        sqlRead = sqlCommand.ExecuteReader

    '        sqlRead.Close()
    '        dbConn.Close()

    '    Catch ex As Exception
    '        Return ex.Message
    '    Finally
    '        dbConn.Dispose()
    '    End Try

    'End Function

    'Public Function UpdateDataKoleksiByIODatabase(id_barang As Integer,
    '                                              nama_barang As String,
    '                                              stock_barang As Integer,
    '                                              harga_barang As Integer,
    '                                              tanggal_masuk_barang As String,
    '                                              tanggal_kadaluarsa_barang As String)

    '    tanggal_masuk_barang = tanggal_masuk_barang.ToString()
    '    tanggal_kadaluarsa_barang = tanggal_kadaluarsa_barang.ToString()

    '    dbConn.ConnectionString = “server =" + server + ";" + “user id=" + username + "5" _
    '        + “password=" + password + ";" + “database =" + database

    '    Try
    '        dbConn.Open()
    '        sqlCommand.Connection = dbConn
    '        sqlQuery = "UPDATE barang SET " &
    '                    “nama_barang='" & nama_barang & "', " &
    '                    “stock='" & "IFNULL((SELECT SUM(jumlah_barang_masuk) FROM barang_masuk WHERE id_barang='" & id_barang & "'),0)+'" & stock_barang & "', " &
    '                    “harga='" & harga_barang & "', " &
    '                    “tanggal_masuk='" & tanggal_masuk_barang.ToString("yyyy/MM/dd") & "', " &
    '                    “tanggal_kadaluarsa='" & tanggal_kadaluarsa_barang.ToString("yyyy/MM/dd") & "', " &
    '                    “WHERE id_barang='" & id_barang & "'"

    '        '"UPDATE barang " &
    '        '            “SET nama_barang='" & Txt_NamaBarang.Text & "', " &
    '        '            "stock= IFNULL((SELECT SUM(jumlah_barang_masuk) FROM barang_masuk WHERE id_barang='" & id_barang & "'),0)+'" & Txt_stock.Text & "', " &
    '        '            "harga= IFNULL('" & Txt_harga.Text & "',0), " &
    '        '            “tanggal_masuk='" & Date_Masuk.Value.ToString("yyyy/MM/dd") & "', " &
    '        '            “tanggal_kadaluarsa='" & Date_Kadaluarsa.Value.ToString("yyyy/MM/dd") & "' " &
    '        '            "WHERE id_barang ='" & id_barang & "' "

    '        sqlCommand = New MySqlCommand(sqlQuery, dbConn)
    '        sqlRead = sqlCommand.ExecuteReader
    '        dbConn.Close()

    '        'Barang Closed
    '        sqlRead.Close()
    '        dbConn.Close()

    '    Catch ex As Exception
    '        Return ex.Message
    '    Finally
    '        dbConn.Dispose()
    '    End Try

    '    Return ""

    'End Function

    'Public Function DeleteDataKoleksiByIDDatabase(ID As Integer)
    '    dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
    '       + "password=" + password + ";" + "database =" + database

    '    Try
    '        dbConn.Open()
    '        sqlCommand.Connection = dbConn
    '        sqlQuery = “DELETE FROM barang “ &
    '                   “WHERE id_barang='" & ID & "'"

    '        Debug.WriteLine(sqlQuery)

    '        'sqlCommand = New MySqlCommand(sqlQuery, dbConn)
    '        sqlRead = sqlCommand.ExecuteReader
    '        dbConn.Close()

    '        'Perpustakaan.sqlDt.Load(sqlRead)
    '        sqlRead.Close()
    '        dbConn.Close()
    '    Catch ex As Exception
    '        Return ex.Message
    '    Finally
    '        dbConn.Dispose()
    '    End Try

    'End Function


    Public Property NamaBarangProperty() As String
        Get
            Return namaBarang
        End Get
        Set(ByVal value As String)
            namaBarang = value
        End Set
    End Property

    Public Property idBarangProperty() As String
        Get
            Return idBarang
        End Get
        Set(ByVal value As String)
            idBarang = value
        End Set
    End Property

    Public Property idJenisBarangProperty() As String
        Get
            Return idjenisbarang
        End Get
        Set(ByVal value As String)
            idjenisbarang = value
        End Set
    End Property

    Public Property tanggalkadaluarsaBarangProperty() As String
        Get
            Return tanggalkadaluarsaBarang
        End Get
        Set(ByVal value As String)
            tanggalkadaluarsaBarang = value
        End Set
    End Property

    Public Property tanggalMasukBarangProperty() As String
        Get
            Return tanggalMasukBarang
        End Get
        Set(ByVal value As String)
            tanggalMasukBarang = value
        End Set
    End Property

    Public Property StockProperty() As Integer
        Get
            Return stock
        End Get
        Set(ByVal value As Integer)
            stock = value
        End Set
    End Property

    Public Property hargaBarangProperty() As String
        Get
            Return hargaBarang
        End Get
        Set(ByVal value As String)
            hargaBarang = value
        End Set
    End Property


End Class