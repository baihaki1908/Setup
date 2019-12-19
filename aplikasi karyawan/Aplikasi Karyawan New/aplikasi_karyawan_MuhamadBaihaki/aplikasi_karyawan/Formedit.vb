Public Class Formedit

    Private Sub Formedit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'untuk menampilkan data di textbox
        txtnik.Enabled = False
        konek()
        cmd = New Odbc.OdbcCommand("select * from t_karyawan WHERE nik='" & txtnik.Text & "'", conn)
        rd = cmd.ExecuteReader
        If rd.Read Then
            txtnama.Text = rd(1).ToString
            txtempattlahir.Text = rd(2).ToString
            dttanggallahhir.Text = rd(3).ToString
            cmbagama.Text = rd(4).ToString
            cmbstatus.Text = rd(5).ToString
            cmbkewarganegaraan.Text = rd(6).ToString
            txtnohp.Text = rd(7).ToString
            txtemail.Text = rd(8).ToString
            txtalamat.Text = rd(9).ToString
            txtpendidikanterakhir.Text = rd(10).ToString
            ptterakhir.Text = rd(11).ToString
            txtjabatan.Text = rd(12).ToString
            dttanggalmasuk.Text = rd(13).ToString
            txtbagian.Text = rd(14).ToString
            txtgaji.Text = rd(15).ToString
            cmbstatuskaryawan.Text = rd(16).ToString
            cmbstatuskerja.Text = rd(17).ToString
        Else
            Exit Sub
            MsgBox("Tidak Ditemukan")
        End If
        conn.Close()
    End Sub

    Private Sub txtnik_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnik.TextChanged
 
    End Sub

    Private Sub txtupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtupdate.Click
        Call updatekaryawan()
    End Sub
    Sub updatekaryawan()
        Try
            Call konek()
            Dim cmd As New Odbc.OdbcCommand
            strcon = "UPDATE t_karyawan SET nama = '" & txtnama.Text & "', tempat_lahir = '" & txtempattlahir.Text & "', tgl_lahir = '" & dttanggallahhir.Text & "', agama = '" & cmbagama.Text & "', status = '" & cmbstatus.Text & "', kewarganegaraan = '" & cmbkewarganegaraan.Text & "', no_hp = '" & txtnohp.Text & "', email = '" & txtemail.Text & "', alamat = '" & txtalamat.Text & "', pendidikan_terakhir = '" & txtpendidikanterakhir.Text & "', pt_terakhir = '" & ptterakhir.Text & "', jabatan = '" & txtjabatan.Text & "', tgl_masuk = '" & dttanggalmasuk.Text & "', bagian = '" & txtbagian.Text & "', gaji = '" & txtgaji.Text & "', status_karyawan = '" & cmbstatuskaryawan.Text & "', status_kerja = '" & cmbstatuskerja.Text & "' WHERE nik = '" & txtnik.Text & "'"
            cmd.Connection = conn
            cmd.CommandText = strcon
            cmd.ExecuteNonQuery()
            MessageBox.Show("Update Berhasil Dilakukan.")
        Catch ex As Exception
            MessageBox.Show("Update data gagal dilakukan")
        End Try
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Call hapuskaryawan()
    End Sub
    Sub hapuskaryawan()
        Try
            Call konek()
            Dim cmd As New Odbc.OdbcCommand
            strcon = "delete from t_karyawan where nik = '" & txtnik.Text & "'"
            cmd.Connection = conn
            cmd.CommandText = strcon
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil Dihapus.")
        Catch ex As Exception
            MessageBox.Show("Data Gagal Dihapus.")
        End Try
    End Sub

    Private Sub btnt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnt.Click
        Form1.Show()
    End Sub

    Private Sub HapusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class