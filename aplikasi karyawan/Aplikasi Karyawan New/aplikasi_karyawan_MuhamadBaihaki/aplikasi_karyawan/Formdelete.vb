Imports System.Data.Odbc
Imports System.Data
Public Class Formdelete
    Sub tampil()
        Call konek()
        da = New Odbc.OdbcDataAdapter("select * from t_karyawan", conn)
        'da = New Odbc.OdbcDataAdapter("select nik, nama, jabatan, tgl_masuk, status_kerja from t_karyawan", conn) 'untuk memilih beberapa
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "t_karyawan")
        DataGridView1.DataSource = (ds.Tables("t_karyawan"))
        Me.ContextMenuStrip = ContextMenuStrip1

    End Sub
    Sub delete()
        Call konek()
        Try
            If MessageBox.Show("apakah kamu ingin menghapus? '" & DataGridView1.CurrentRow.Cells(1).Value _
            & "' ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                cmd = New OdbcCommand("Delete FROM t_karyawan where nik='" & DataGridView1.CurrentRow.Cells(0).Value.ToString & "'", conn)
                'cmd = New Odbc.OdbcCommand("delete from t_karyawan where nik = '", conn)
                With cmd
                    cmd.Parameters.Add("nik", OdbcType.VarChar).Value = DataGridView1.CurrentRow.Cells(0).Value
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
    Private Sub Formdelete_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampil()
    End Sub

    Private Sub HapusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HapusToolStripMenuItem.Click
        delete()
    End Sub

    Private Sub HapusToolStripMenuItem_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles HapusToolStripMenuItem.MouseUp

    End Sub
End Class