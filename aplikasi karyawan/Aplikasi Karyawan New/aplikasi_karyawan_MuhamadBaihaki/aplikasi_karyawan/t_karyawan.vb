Public Class t_karyawan

    Private Sub btns_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btns.Click
        Call konek()
        Dim cmd As New Odbc.OdbcCommand
        strcon = "INSERT INTO t_karyawan " _
        + "VALUES ('" & txtnik.Text & "'," _
        + "'" & txtnama.Text & "'," _
        + "'" & txtempattlahir.Text & "'," _
        + "'" & dttanggallahhir.Text & "'," _
        + "'" & cmbagama.Text & "'," _
        + "'" & cmbstatus.Text & "'," _
        + "'" & cmbkewarganegaraan.Text & "'," _
        + "'" & txtnohp.Text & "'," _
        + "'" & txtemail.Text & "'," _
        + "'" & txtalamat.Text & "'," _
        + "'" & txtpendidikanterakhir.Text & "'," _
        + "'" & ptterakhir.Text & "'," _
        + "'" & txtjabatan.Text & "'," _
        + "'" & dttanggalmasuk.Text & "'," _
        + "'" & txtbagian.Text & "'," _
        + "'" & txtgaji.Text & "'," _
        + "'" & cmbstatuskaryawan.Text & "'," _
        + "'" & cmbstatuskerja.Text & "'," _
        + "'" & txtng.Text & "')"

        MsgBox(strcon)
        cmd.Connection = conn
        cmd.CommandText = strcon
        cmd.ExecuteNonQuery()
        conn.Close()
        MsgBox("data Berhasil Disimpan", MsgBoxStyle.Information)
        Call konek()
    End Sub

    Private Sub txtupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtupdate.Click
        Call updatekaryawan()
    End Sub
    Sub updatekaryawan()
        Try
            Call konek()
            Dim cmd As New Odbc.OdbcCommand
            strcon = "UPDATE t_karyawan SET nama = '" & txtnama.Text & "', tempat_lahir = '" & txtempattlahir.Text & "', tgl_lahir = '" & dttanggallahhir.Text & "', agama = '" & cmbagama.Text & "', status = '" & cmbstatus.Text & "', kewarganegaraan = '" & cmbkewarganegaraan.Text & "', no_hp = '" & txtnohp.Text & "', email = '" & txtemail.Text & "', alamat = '" & txtalamat.Text & "', pendidikan_terakhir = '" & txtpendidikanterakhir.Text & "', pt_terakhir = '" & ptterakhir.Text & "', jabatan = '" & txtjabatan.Text & "', tgl_masuk = '" & dttanggalmasuk.Text & "', bagian = '" & txtbagian.Text & "', gaji = '" & txtgaji.Text & "', status_karyawan = '" & cmbstatuskaryawan.Text & "', status_kerja = '" & cmbstatuskerja.Text & "', nama_gambar = '" & txtng.Text & "' WHERE nik = '" & txtnik.Text & "'"
            cmd.Connection = conn
            cmd.CommandText = strcon
            cmd.ExecuteNonQuery()
            MessageBox.Show("Update Data Siswa Berhasil Dilakukan.")
        Catch ex As Exception
            MessageBox.Show("Update data siswa gagal dilakukan")
        End Try
    End Sub
End Class