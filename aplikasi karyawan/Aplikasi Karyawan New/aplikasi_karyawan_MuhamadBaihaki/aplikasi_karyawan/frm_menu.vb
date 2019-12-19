Public Class frm_menu

    Private Sub DataKaryawanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataKaryawanToolStripMenuItem.Click
        Form1.Show()
    End Sub

    Private Sub LemburToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LemburToolStripMenuItem.Click
        Frm_lembur.Show()
    End Sub

    Private Sub JabatanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JabatanToolStripMenuItem.Click
        Form_jabatan.Show()
    End Sub

    Private Sub GajiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GajiToolStripMenuItem.Click
        Frm_gaji.Show()
    End Sub

    Private Sub JabatanToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JabatanToolStripMenuItem1.Click
        frm_cetak_jabatan.Show()
    End Sub

    Private Sub RekapGajiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RekapGajiToolStripMenuItem.Click
        frm_rekap_cetak_gaji.Show()
    End Sub

    Private Sub AbsenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbsenToolStripMenuItem.Click
        frm_absensi.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class