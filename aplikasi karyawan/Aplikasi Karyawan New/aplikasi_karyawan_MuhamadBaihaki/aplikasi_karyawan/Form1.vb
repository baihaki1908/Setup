Public Class Form1
    Dim index As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call konek()
        da = New Odbc.OdbcDataAdapter("select * from t_karyawan", conn)
        'da = New Odbc.OdbcDataAdapter("select nik, nama, jabatan, tgl_masuk, status_kerja from t_karyawan", conn) 'untuk memilih beberapa
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "t_karyawan")
        DataGridView1.DataSource = (ds.Tables("t_karyawan"))
        Me.ContextMenuStrip = ContextMenuStrip1
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub
    Private Sub form_edit(ByVal x As Integer)
        Try
            Formedit.txtnik.Text = DataGridView1.Rows(x).Cells(0).Value
            Formedit.txtnama.Text = DataGridView1.Rows(x).Cells(1).Value
            Formedit.txtempattlahir.Text = DataGridView1.Rows(x).Cells(2).Value
            Formedit.dttanggallahhir.Text = DataGridView1.Rows(x).Cells(3).Value
            Formedit.cmbagama.Text = DataGridView1.Rows(x).Cells(4).Value
            Formedit.cmbstatus.Text = DataGridView1.Rows(x).Cells(5).Value
            Formedit.cmbkewarganegaraan.Text = DataGridView1.Rows(x).Cells(6).Value
            Formedit.txtnohp.Text = DataGridView1.Rows(x).Cells(7).Value
            Formedit.txtemail.Text = DataGridView1.Rows(x).Cells(8).Value
            Formedit.txtalamat.Text = DataGridView1.Rows(x).Cells(9).Value
            Formedit.txtpendidikanterakhir.Text = DataGridView1.Rows(x).Cells(10).Value
            Formedit.ptterakhir.Text = DataGridView1.Rows(x).Cells(11).Value
            Formedit.txtjabatan.Text = DataGridView1.Rows(x).Cells(12).Value
            Formedit.dttanggalmasuk.Text = DataGridView1.Rows(x).Cells(13).Value
            Formedit.txtbagian.Text = DataGridView1.Rows(x).Cells(14).Value
            Formedit.txtgaji.Text = DataGridView1.Rows(x).Cells(15).Value
            Formedit.cmbstatuskaryawan.Text = DataGridView1.Rows(x).Cells(16).Value
            Formedit.cmbstatuskerja.Text = DataGridView1.Rows(x).Cells(17).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        form_edit(e.RowIndex)
        Me.Visible = False
        Formedit.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btnkembali_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnk.Click
        Me.Close()
    End Sub

    Private Sub HapusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HapusToolStripMenuItem.Click
        If Not DataGridView1.Rows(index).IsNewRow Then
            DataGridView1.Rows.RemoveAt(index)
            MessageBox.Show("hapus Berhasil Dilakukan.")
        End If
    End Sub
End Class
