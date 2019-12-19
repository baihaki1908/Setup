Imports System.Data.Odbc
Imports System.Data
Public Class Frm_gaji

    Private Sub Frm_gaji_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call konek()
        da = New Odbc.OdbcDataAdapter("select * from t_gaji", conn)
        'da = New Odbc.OdbcDataAdapter("select nik, nama, jabatan, tgl_masuk, status_kerja from t_karyawan", conn) 'untuk memilih beberapa
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "t_gaji")
        DataGridView1.DataSource = (ds.Tables("t_gaji"))
        Call get_jabat()
        Call get_nik()
        Call auto_slip()
    End Sub
    Sub auto_slip()
        Dim ns As String = "SL" + Format(Now, "yyMMdd-hhmmss")
        txtns.Text = ns
        txtns.Enabled = False
    End Sub

    Sub tampil()
        Call konek()
        da = New Odbc.OdbcDataAdapter("select * from t_gaji", conn)
        'da = New Odbc.OdbcDataAdapter("select nik, nama, jabatan, tgl_masuk, status_kerja from t_karyawan", conn) 'untuk memilih beberapa
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "t_gaji")
        DataGridView1.DataSource = (ds.Tables("t_gaji"))
    End Sub
    Sub get_jabat()
        'da = New Odbc.OdbcDataAdapter("select * from t_gaji", conn)
        da = New Odbc.OdbcDataAdapter("select id_jabatan from t_jabatan", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "t_jabatan")
        cmbij.DataSource = (ds.Tables("t_jabatan"))
        cmbij.ValueMember = "id_jabatan"
        cmbij.DisplayMember = "id_jabatan"
    End Sub
    Sub get_nik()
        'da = New Odbc.OdbcDataAdapter("select * from t_gaji", conn)
        da = New Odbc.OdbcDataAdapter("select nik from t_karyawan", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "t_karyawan")
        cmbnik.DataSource = (ds.Tables("t_karyawan"))
        cmbnik.ValueMember = "nik"
        cmbnik.DisplayMember = "nik"
    End Sub
    Private Sub form_t(ByVal x As Integer)
        Try
            txtig.Text = DataGridView1.Rows(x).Cells(0).Value
            txtns.Text = DataGridView1.Rows(x).Cells(1).Value
            cmbnik.Text = DataGridView1.Rows(x).Cells(2).Value
            txttg.Text = DataGridView1.Rows(x).Cells(3).Value
            cmbij.Text = DataGridView1.Rows(x).Cells(4).Value
            txtnj.Text = DataGridView1.Rows(x).Cells(5).Value
            txtgp.Text = DataGridView1.Rows(x).Cells(6).Value
            txtt.Text = DataGridView1.Rows(x).Cells(7).Value
            txtul.Text = DataGridView1.Rows(x).Cells(8).Value
            txtpbkes.Text = DataGridView1.Rows(x).Cells(9).Value
            txtpbket.Text = DataGridView1.Rows(x).Cells(10).Value
            txtpl.Text = DataGridView1.Rows(x).Cells(11).Value
            txtnor.Text = DataGridView1.Rows(x).Cells(12).Value
            txtnamar.Text = DataGridView1.Rows(x).Cells(13).Value
            txtnb.Text = DataGridView1.Rows(x).Cells(14).Value
            txttg.Text = DataGridView1.Rows(x).Cells(15).Value

        Catch ex As Exception

        End Try
    End Sub

    

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        form_t(e.RowIndex)
    End Sub

    Private Sub cmbij_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbij.SelectedIndexChanged
        Call konek()
        cmd = New Odbc.OdbcCommand("select nama_jabatan,gaji_pokok from t_jabatan where id_jabatan = '" & cmbij.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            txtnj.Text = rd(0).ToString
            txtgp.Text = rd(1).ToString
        End If
        conn.Close()
    End Sub

    Private Sub btns_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btns.Click
        Call konek()
        Dim cmd As New Odbc.OdbcCommand
        strcon = "INSERT INTO t_gaji " _
        + "VALUES('" & txtig.Text & "'," _
        + "'" & txtns.Text & "'," _
        + "'" & cmbij.Text & "'," _
        + "'" & tgl.Text & "'," _
        + "'" & cmbij.Text & "'," _
        + "'" & txtnj.Text & "'," _
        + "'" & txtgp.Text & "'," _
        + "'" & txtt.Text & "'," _
        + "'" & txtul.Text & "'," _
        + "'" & txtpbkes.Text & "'," _
        + "'" & txtpbket.Text & "'," _
        + "'" & txtpl.Text & "'," _
        + "'" & txtnor.Text & "'," _
        + "'" & txtnamar.Text & "'," _
        + "'" & txtnb.Text & "'," _
        + "'" & txttg.Text & "')"

        MsgBox(strcon)
        cmd.Connection = conn
        cmd.CommandText = strcon
        cmd.ExecuteNonQuery()
        conn.Close()
        MsgBox("Data Berhasil Disimpan", MsgBoxStyle.Information)
        Call tampil()

        Dim pesan As Integer
        pesan = MsgBox("Data Berhasil Disimpan," + "Apakah Anda Ingin Mencetak Transaksi..? " _
                       + txtns.Text, vbExclamation + vbYesNo, "Cetak Transaksi")
        If pesan = vbNo Then
            Exit Sub
        Else
            Call cetak_slipgaji()
        End If

    End Sub
    Private Sub cetak_slipgaji()
        Frm_cetak_gaji.CrystalReportViewer1.SelectionFormula = "{t_gaji.no_slip} = '" & txtns.Text & "'"
        Frm_cetak_gaji.Show()
    End Sub

    Private Sub btnh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnh.Click
        Call konek()
        Try
            If MessageBox.Show("apakah kamu ingin menghapus? '" & DataGridView1.CurrentRow.Cells(1).Value _
            & "' ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                cmd = New OdbcCommand("Delete FROM t_gaji where id_gaji='" & DataGridView1.CurrentRow.Cells(0).Value.ToString & "'", conn)
                'cmd = New Odbc.OdbcCommand("delete from t_karyawan where nik = '", conn)
                With cmd
                    cmd.Parameters.Add("id_gaji", OdbcType.VarChar).Value = DataGridView1.CurrentRow.Cells(0).Value
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
            strcon = "UPDATE t_gaji SET no_slip = '" & txtns.Text & "', nik = '" & cmbij.Text & "', tgl_gaji = '" & tgl.Text & "', id_jabatan = '" & cmbij.Text & "', nama_jabatan = '" & txtnj.Text & "', gaji_pokok = '" & txtgp.Text & "', tunjangan = '" & txtt.Text & "', uang_lembur = '" & txtul.Text & "', pot_bpjs_kes = '" & txtpbkes.Text & "', pot_bpjs_ket = '" & txtpbket.Text & "', pot_lain2 = '" & txtpl.Text & "', no_rekening = '" & txtnor.Text & "', nama_rekening = '" & txtnamar.Text & "', nama_bank = '" & txtnb.Text & "', ttl_gaji = '" & cmbij.Text & "' WHERE id_gaji = '" & txtig.Text & "'"
            cmd.Connection = conn
            cmd.CommandText = strcon
            cmd.ExecuteNonQuery()
            Call tampil()
            MessageBox.Show("Update Berhasil Dilakukan.")
        Catch ex As Exception
            MessageBox.Show("Update data gagal dilakukan")
        End Try
    End Sub

    Private Sub btnk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnk.Click
        Me.Close()
    End Sub

    Private Sub cmbnik_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbnik.SelectedIndexChanged

    End Sub

    Private Sub txtnj_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnj.TextChanged

    End Sub

    Private Sub txtgp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtgp.TextChanged
        hitung()
    End Sub
    Sub hitung()
        Dim jum As Integer
        Dim pot As Integer
        jum = Val(txtgp.Text) + Val(txtt.Text) + Val(txtul.Text)
        pot = Val(txtpbkes.Text) + Val(txtpbket.Text) + Val(txtpl.Text)
        txttg.Text = jum - pot
    End Sub

    Private Sub txtt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtt.TextChanged
        hitung()
    End Sub

    Private Sub txtul_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtul.TextChanged
        hitung()
    End Sub

    Private Sub txtpbkes_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpbkes.TextChanged
        hitung()
    End Sub

    Private Sub txtpbket_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpbket.TextChanged
        hitung()
    End Sub

    Private Sub txtpl_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpl.TextChanged
        hitung()
    End Sub
End Class
