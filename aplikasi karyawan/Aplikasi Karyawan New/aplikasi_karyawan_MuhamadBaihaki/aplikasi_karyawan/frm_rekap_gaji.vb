Imports CrystalDecisions.CrystalReports.Engine
Public Class frm_rekap_gaji

   

    Private Sub btnc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnc.Click
        Dim report_detail As New ReportDocument
        report_detail.Load("..\..\cr_rekap_gaji.rpt")

        report_detail.SetParameterValue("dari", dtpdari.Text)
        report_detail.SetParameterValue("sampai", dtpsampai.Text)

        frm_rekap_cetak_gaji.CrystalReportViewer1.ReportSource = report_detail
        frm_rekap_cetak_gaji.CrystalReportViewer1.Refresh()
        frm_rekap_cetak_gaji.Show()
    End Sub
End Class