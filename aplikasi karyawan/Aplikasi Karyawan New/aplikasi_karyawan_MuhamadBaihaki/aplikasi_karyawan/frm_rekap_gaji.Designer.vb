<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_rekap_gaji
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnc = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtpdari = New System.Windows.Forms.DateTimePicker
        Me.dtpsampai = New System.Windows.Forms.DateTimePicker
        Me.SuspendLayout()
        '
        'btnc
        '
        Me.btnc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnc.Location = New System.Drawing.Point(112, 202)
        Me.btnc.Name = "btnc"
        Me.btnc.Size = New System.Drawing.Size(68, 31)
        Me.btnc.TabIndex = 0
        Me.btnc.Text = "Cetak"
        Me.btnc.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(72, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Dari"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(72, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Sampai"
        '
        'dtpdari
        '
        Me.dtpdari.CustomFormat = "yyyy-MM-dd"
        Me.dtpdari.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpdari.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpdari.Location = New System.Drawing.Point(75, 72)
        Me.dtpdari.Name = "dtpdari"
        Me.dtpdari.Size = New System.Drawing.Size(115, 26)
        Me.dtpdari.TabIndex = 5
        '
        'dtpsampai
        '
        Me.dtpsampai.CustomFormat = "yyyy-MM-dd"
        Me.dtpsampai.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpsampai.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpsampai.Location = New System.Drawing.Point(75, 137)
        Me.dtpsampai.Name = "dtpsampai"
        Me.dtpsampai.Size = New System.Drawing.Size(115, 26)
        Me.dtpsampai.TabIndex = 6
        '
        'frm_rekap_gaji
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(273, 272)
        Me.Controls.Add(Me.dtpsampai)
        Me.Controls.Add(Me.dtpdari)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnc)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_rekap_gaji"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cetak Rekap Gaji"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnc As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpdari As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpsampai As System.Windows.Forms.DateTimePicker
End Class
