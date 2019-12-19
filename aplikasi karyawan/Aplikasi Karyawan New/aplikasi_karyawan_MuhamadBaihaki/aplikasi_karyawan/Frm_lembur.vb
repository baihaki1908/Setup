Imports System.Data.Odbc
Imports System.Data
Public Class Frm_lembur

    Private Sub Frm_lembur_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call konek()
        da = New Odbc.OdbcDataAdapter("select * from t_lembur", conn)
        'da = New Odbc.OdbcDataAdapter("select nik, nama, jabatan, tgl_masuk, status_kerja from t_karyawan", conn) 'untuk memilih beberapa
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "t_lembur")
        DataGridView1.DataSource = (ds.Tables("t_lembur"))
        Call get_jabat()
        Call get_nik()
    End Sub
    Sub tampil()
        Call konek()
        da = New Odbc.OdbcDataAdapter("select * from t_lembur", conn)
        'da = New Odbc.OdbcDataAdapter("select nik, nama, jabatan, tgl_masuk, status_kerja from t_karyawan", conn) 'untuk memilih beberapa
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "t_lembur")
        DataGridView1.DataSource = (ds.Tables("t_lembur"))
    End Sub
    Sub get_jabat()
        'da = New Odbc.OdbcDataAdapter("select * from t_gaji", conn)
        da = New Odbc.OdbcDataAdapter("select id_jabatan from t_lembur", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "t_lembur")
        cmbij.DataSource = (ds.Tables("t_lembur"))
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
    Private Sub form_l(ByVal x As Integer)
        Try
            txtil.Text = DataGridView1.Rows(x).Cells(0).Value
            cmbnik.Text = DataGridView1.Rows(x).Cells(1).Value
            txtn.Text = DataGridView1.Rows(x).Cells(2).Value
            cmbij.Text = DataGridView1.Rows(x).Cells(3).Value
            tgl.Text = DataGridView1.Rows(x).Cells(4).Value
            txtjjl.Text = DataGridView1.Rows(x).Cells(5).Value
            txtul.Text = DataGridView1.Rows(x).Cells(6).Value
            txttul.Text = DataGridView1.Rows(x).Cells(7).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        form_l(e.RowIndex)
    End Sub

    Private Sub btns_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btns.Click
        Call konek()
        Dim cmd As New Odbc.OdbcCommand
        strcon = "INSERT INTO t_lembur " _
        + "VALUES('" & txtil.Text & "'," _
        + "'" & cmbnik.Text & "'," _
        + "'" & txtn.Text & "'," _
        + "'" & cmbij.Text & "'," _
        + "'" & tgl.Text & "'," _
        + "'" & txtjjl.Text & "'," _
        + "'" & txtul.Text & "'," _
        + "'" & txttul.Text & "')"

        MsgBox(strcon)
        cmd.Connection = conn
        cmd.CommandText = strcon
        cmd.ExecuteNonQuery()
        conn.Close()
        MsgBox("data Berhasil Disimpan", MsgBoxStyle.Information)
        Call tampil()
    End Sub

    Private Sub btnh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnh.Click
        Call konek()
        Try
            If MessageBox.Show("apakah kamu ingin menghapus? '" & DataGridView1.CurrentRow.Cells(1).Value _
            & "' ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                cmd = New OdbcCommand("Delete FROM t_lembur where id_lembur='" & DataGridView1.CurrentRow.Cells(0).Value.ToString & "'", conn)
                'cmd = New Odbc.OdbcCommand("delete from t_karyawan where nik = '", conn)
                With cmd
                    cmd.Parameters.Add("id_lembur", OdbcType.VarChar).Value = DataGridView1.CurrentRow.Cells(0).Value
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
            strcon = "UPDATE t_lembur SET nik = '" & cmbnik.Text & "', nama_karyawan = '" & txtn.Text & "', id_jabatan = '" & cmbij.Text & "', tgl_lembur = '" & tgl.Text & "', jml_jam_lembur = '" & txtjjl.Text & "', uang_lembur = '" & txtul.Text & "' WHERE id_lembur = '" & txtil.Text & "'"
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

    'Private Sub cmbnik_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbnik.KeyPress
    'If (e.KeyChar = Chr(13)) Then
    'Call konek()
    'cmd = New Odbc.OdbcCommand("select nama_karyawan,id_jabatan from t_lembur where nik = '" & cmbnik.Text & "'", conn)
    'rd = cmd.ExecuteReader
    'If rd.Read Then
    'txtn.Text = rd(1).ToString
    'cmbij.Text = rd(12).ToString
    'Else
    'MsgBox("Tidak Ditemukan")
    'cmbnik.Focus()
    'cmbnik.clear()
    'End If
    'conn.Close()
    'End If
    'End Sub

    Private Sub cmbnik_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbnik.SelectedIndexChanged
        Call konek()
        cmd = New Odbc.OdbcCommand("select nama_karyawan,id_jabatan from t_lembur where nik = '" & cmbnik.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            txtn.Text = rd(0).ToString
            cmbij.Text = rd(1).ToString
        End If
        conn.Close()
    End Sub

    Private Sub cmbij_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbij.SelectedIndexChanged

    End Sub

    Private Sub txtn_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtn.TextChanged

    End Sub

    Private Sub txtul_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtul.TextChanged
        'Dim a, b, c As Integer
        'a = txtul.Text
        'b = txtjjl.Text
        'c = a * b
        'txttul.Text = c
        txttul.Text = Val(txtjjl.Text) * Val(txtul.Text)
    End Sub

    Private Sub txtjjl_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtjjl.TextChanged
        txttul.Text = Val(txtjjl.Text) * Val(txtul.Text)
    End Sub
End Class