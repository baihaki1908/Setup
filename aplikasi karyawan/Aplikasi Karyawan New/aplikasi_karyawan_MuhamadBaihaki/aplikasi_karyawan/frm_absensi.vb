Imports System.Data.Odbc
Public Class frm_absensi

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        tglsekarang.Text = Format(Now, "yyyy-MM-dd")
        jamsekarang.Text = Format(Now, "HH:mm:ss")

    End Sub


    Private Sub txtnik_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnik.KeyPress
        Dim jammasuk, jamkerja As DateTime
        Dim jampulang As String
        Dim tgl As String
        If (e.KeyChar = Chr(13)) Then
            Dim a, b As String

            Call konek()
            strcon = "select * from t_karyawan where nik='" & txtnik.Text & "'"
            cmd = New OdbcCommand(strcon, conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                nik.Text = rd.Item("nik")
                PictureBox1.ImageLocation = rd.Item("lokasi_gambar")
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage

                jammasuk = Format(Now, "HH:mm:ss")
                jamkerja = "07:00:00"
                jampulang = Format(Now, "HH:mm:ss")
                tgl = Format(Now, "yyyy-MM-dd")

                a = Format(Now, "HH:mm:ss")
                b = "07:00:00"

                Dim selisih As TimeSpan = New TimeSpan
                selisih = jammasuk - jamkerja
                info.Text = selisih.ToString

                strcon = "insert into t_absensi(id_absen,nik,jam_masuk,jam_kerja,tgl_kerja,jam_pulang,telat_masuk,jam_lembur)values(?,?,?,?,?,?,?,?)"
                Dim mycomm As OdbcCommand = New OdbcCommand(strcon, conn)
                With mycomm.Parameters
                    .Add("?", OdbcType.VarChar, 20).Value = Microsoft.VisualBasic.Left(txtnik.Text, 3) & Format(Now, "yyMMdd-HHmmss")
                    .Add("?", OdbcType.VarChar, 20).Value = txtnik.Text.Trim
                    .Add("?", OdbcType.VarChar, 15).Value = a
                    .Add("?", OdbcType.VarChar, 15).Value = b
                    .Add("?", OdbcType.Date).Value = tgl
                    .Add("?", OdbcType.VarChar, 15).Value = jampulang
                    .Add("?", OdbcType.VarChar, 10).Value = selisih.ToString
                    .Add("?", OdbcType.VarChar, 15).Value = selisih.ToString
                End With
                mycomm.ExecuteNonQuery()
                mycomm = Nothing
                MsgBox("Menyimpan", MsgBoxStyle.MsgBoxSetForeground, "Save")
            Else
                txtnik.Clear()
                PictureBox1.Hide()
            End If
            PictureBox1.Visible = True
        End If
    End Sub
End Class