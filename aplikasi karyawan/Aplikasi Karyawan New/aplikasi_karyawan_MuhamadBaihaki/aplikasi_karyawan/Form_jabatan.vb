Imports System.Data.Odbc
Imports System.Data
Public Class Form_jabatan

    Private Sub Form_jabatan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call konek()
        da = New Odbc.OdbcDataAdapter("select * from t_jabatan", conn)
        'da = New Odbc.OdbcDataAdapter("select nik, nama, jabatan, tgl_masuk, status_kerja from t_karyawan", conn) 'untuk memilih beberapa
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "t_jabatan")
        DataGridView1.DataSource = (ds.Tables("t_jabatan"))
    End Sub
    Sub tampil()
        Call konek()
        da = New Odbc.OdbcDataAdapter("select * from t_jabatan", conn)
        'da = New Odbc.OdbcDataAdapter("select nik, nama, jabatan, tgl_masuk, status_kerja from t_karyawan", conn) 'untuk memilih beberapa
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "t_jabatan")
        DataGridView1.DataSource = (ds.Tables("t_jabatan"))
    End Sub
    Private Sub form_j(ByVal x As Integer)
        Try
            txtnik.Text = DataGridView1.Rows(x).Cells(0).Value
            txtn.Text = DataGridView1.Rows(x).Cells(1).Value
            txtg.Text = DataGridView1.Rows(x).Cells(2).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        form_j(e.RowIndex)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        
        If txtn.Text = "" Or txtg.Text = "" Then
            MsgBox("Data belum lengkap")
            Exit Sub
        Else
            Call konek()
            cmd = New OdbcCommand("Select * from t_jabatan where nama_jabatan='" & txtn.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then
                Call konek()
                Dim cmd As New Odbc.OdbcCommand
                strcon = "INSERT INTO t_jabatan " _
                + "VALUES ('" & txtnik.Text & "'," _
                + "'" & txtn.Text & "'," _
                + "'" & txtg.Text & "')"
                MsgBox(strcon)
                cmd.Connection = conn
                cmd.CommandText = strcon
                cmd.ExecuteNonQuery()
                conn.Close()
                MsgBox("data Berhasil Disimpan", MsgBoxStyle.Information)
                Call tampil()
            Else
                MsgBox("Nama Jabatan Sudah Ada")
            End If
        End If
    End Sub

    Private Sub btnh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnh.Click
        Call konek()
        Try
            If MessageBox.Show("apakah kamu ingin menghapus? '" & DataGridView1.CurrentRow.Cells(1).Value _
            & "' ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                cmd = New OdbcCommand("Delete FROM t_jabatan where id_jabatan='" & DataGridView1.CurrentRow.Cells(0).Value.ToString & "'", conn)
                'cmd = New Odbc.OdbcCommand("delete from t_karyawan where nik = '", conn)
                With cmd
                    cmd.Parameters.Add("id_jabatan", OdbcType.VarChar).Value = DataGridView1.CurrentRow.Cells(0).Value
                    cmd.ExecuteNonQuery()
                End With

                conn.Close()
                tampil()
                MessageBox.Show("Hapus!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Return
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnu.Click
        Try
            Call konek()
            Dim cmd As New Odbc.OdbcCommand
            strcon = "UPDATE t_jabatan SET nama_jabatan = '" & txtn.Text & "', gaji_pokok = '" & txtg.Text & "' WHERE id_jabatan = '" & txtnik.Text & "'"
            cmd.Connection = conn
            cmd.CommandText = strcon
            cmd.ExecuteNonQuery()
            Call tampil()
            MessageBox.Show("Update Berhasil Dilakukan.")
        Catch ex As Exception
            MessageBox.Show("Update data gagal dilakukan")
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class