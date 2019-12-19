Imports System.Data.Odbc
Public Class tambah_karyawan
    Private PathFile As String = Nothing
    Private Sub btns_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btns.Click
        konek()
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
        + "'" & cmbstatuskaryawan.Text & "'," _
        + "'" & cmbstatuskerja.Text & "'," _
        + "'" & txtgaji.Text & "'," _
        + "'" & txtng.Text & "'," _
        + "'" & lblpath.Text & "')"

        'MsgBox(strcon)
        Dim cmd As New Odbc.OdbcCommand
        cmd.Connection = conn
        cmd.CommandText = strcon
        cmd.ExecuteNonQuery()
        conn.Close()
        MsgBox("Data Berhasil Disimpan", MsgBoxStyle.Information)

        Try
            strcon = "Insert into t_karyawan(nik,nama,tempat_lahir,tgl_lahir,agama,status,kewarganegaraan,no_hp,email,alamat,pendidikan_terakhir,pt_terakhir,jabatan,tgl_masuk,bagian,status_karyawan,status_kerja,gaji,nama_gambar,lokasi_gambar)values(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)"
            Dim mycomm As OdbcCommand = New OdbcCommand(strcon, conn)
            With mycomm.Parameters
                .Add("?", OdbcType.VarChar, 15).Value = txtnik.Text.Trim
                .Add("?", OdbcType.VarChar, 30).Value = txtNama.Text.Trim
                .Add("?", OdbcType.VarChar, 20).Value = txtempattlahir.Text.Trim
                .Add("?", OdbcType.Date).Value = dttanggallahhir.Text.Trim
                .Add("?", OdbcType.VarChar, 15).Value = cmbagama.Text.Trim
                .Add("?", OdbcType.VarChar, 15).Value = cmbstatus.Text.Trim
                .Add("?", OdbcType.VarChar, 3).Value = cmbkewarganegaraan.Text.Trim
                .Add("?", OdbcType.VarChar, 13).Value = txtnohp.Text.Trim
                .Add("?", OdbcType.VarChar, 25).Value = txtemail.Text.Trim
                .Add("?", OdbcType.VarChar, 35).Value = txtalamat.Text.Trim
                .Add("?", OdbcType.VarChar, 4).Value = txtpendidikanterakhir.Text.Trim
                .Add("?", OdbcType.VarChar, 40).Value = ptterakhir.Text.Trim
                .Add("?", OdbcType.VarChar, 20).Value = txtjabatan.Text.Trim
                .Add("?", OdbcType.Date).Value = ptterakhir.Text.Trim
                .Add("?", OdbcType.VarChar, 20).Value = txtbagian.Text.Trim
                .Add("?", OdbcType.VarChar, 15).Value = cmbstatuskaryawan.Text.Trim
                .Add("?", OdbcType.VarChar, 15).Value = cmbstatuskerja.Text.Trim
                .Add("?", OdbcType.VarChar, 10).Value = txtgaji.Text.Trim
                .Add("?", OdbcType.VarChar, 200).Value = txtng.Text.Trim
                .Add("?", OdbcType.VarChar, 200).Value = lblpath.Text.Trim
            End With

            mycomm.ExecuteNonQuery()
            mycomm = Nothing
            MsgBox("Menyimpan", MsgBoxStyle.MsgBoxSetForeground, "Save")

        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnp.Click
        On Error Resume Next
        OpenFileDialog1.Filter = "JPG Files(*.jpg)|*.jpg| JPEG Files(*.jpeg)|*.jpeg| GIF Files(*.gif)|*.gif| PNG Files(*.png)|*.png|BMP Files(*.bmp)|*.bmp"
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            pctgbr.SizeMode = PictureBoxSizeMode.StretchImage
            pctgbr.Image = New Bitmap(OpenFileDialog1.FileName)
            btnp.Enabled = True
            PathFile = OpenFileDialog1.FileName
            txtng.Text = PathFile.Substring(PathFile.LastIndexOf("\") + 1)
            lblpath.Text = OpenFileDialog1.FileName
            pctgbr.Image = Image.FromFile(lblpath.Text)
        End If
        pctgbr.Visible = True
    End Sub

    Private Sub pctgbr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pctgbr.Click

    End Sub
End Class