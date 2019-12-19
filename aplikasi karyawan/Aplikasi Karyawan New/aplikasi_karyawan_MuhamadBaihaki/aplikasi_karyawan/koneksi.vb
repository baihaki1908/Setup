Imports System.Data.Odbc
Imports System.Data
'Imports System.Data.OleDb
Module koneksi
    Public conn As OdbcConnection
    Public da As OdbcDataAdapter
    Public ds As DataSet
    Public rd As OdbcDataReader
    Public cmd As Odbc.OdbcCommand
    Public dt As DataTable
    Public strcon As String
    '======================================


    Public Sub konek()
        strcon = "Driver={MySQL ODBC 3.51 Driver};database=db_karyawan;server=localhost;uid=root;"
        conn = New OdbcConnection(strcon)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
            'MsgBox("koneksi Berhasil")
        End If
    End Sub
    '======================================
    'M. ACCESS
    'Public conn As OleDbConnection
    'Public da As OleDbDataAdapter
    'Public ds As DataSet
    'Public rd As OleDbDataReader
    'Public cmd As OleDbCommand
    'Public str As String

    'Public Sub connect()
    'Str = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\mahasiswa.accdb"
    'conn = New OleDbConnection(Str)
    'If conn.State = ConnectionState.Closed Then
    ' conn.Open()
    ' MsgBox("Koneksi Berhasil")
    'End If
    'End Sub
End Module
