<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_absensi
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_absensi))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.txtnik = New System.Windows.Forms.TextBox
        Me.tglsekarang = New System.Windows.Forms.Label
        Me.jamsekarang = New System.Windows.Forms.Label
        Me.nik = New System.Windows.Forms.Label
        Me.info = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(63, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(147, 174)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'txtnik
        '
        Me.txtnik.Location = New System.Drawing.Point(63, 205)
        Me.txtnik.Name = "txtnik"
        Me.txtnik.Size = New System.Drawing.Size(147, 20)
        Me.txtnik.TabIndex = 1
        '
        'tglsekarang
        '
        Me.tglsekarang.AutoSize = True
        Me.tglsekarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tglsekarang.Location = New System.Drawing.Point(291, 25)
        Me.tglsekarang.Name = "tglsekarang"
        Me.tglsekarang.Size = New System.Drawing.Size(72, 24)
        Me.tglsekarang.TabIndex = 2
        Me.tglsekarang.Text = "Label1"
        '
        'jamsekarang
        '
        Me.jamsekarang.AutoSize = True
        Me.jamsekarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jamsekarang.Location = New System.Drawing.Point(290, 51)
        Me.jamsekarang.Name = "jamsekarang"
        Me.jamsekarang.Size = New System.Drawing.Size(72, 24)
        Me.jamsekarang.TabIndex = 3
        Me.jamsekarang.Text = "Label2"
        '
        'nik
        '
        Me.nik.AutoSize = True
        Me.nik.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nik.Location = New System.Drawing.Point(291, 80)
        Me.nik.Name = "nik"
        Me.nik.Size = New System.Drawing.Size(72, 24)
        Me.nik.TabIndex = 4
        Me.nik.Text = "Label3"
        '
        'info
        '
        Me.info.AutoSize = True
        Me.info.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.info.Location = New System.Drawing.Point(291, 104)
        Me.info.Name = "info"
        Me.info.Size = New System.Drawing.Size(72, 24)
        Me.info.TabIndex = 5
        Me.info.Text = "Label4"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'frm_absensi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(887, 514)
        Me.Controls.Add(Me.info)
        Me.Controls.Add(Me.nik)
        Me.Controls.Add(Me.jamsekarang)
        Me.Controls.Add(Me.tglsekarang)
        Me.Controls.Add(Me.txtnik)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frm_absensi"
        Me.Text = "Absensi"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtnik As System.Windows.Forms.TextBox
    Friend WithEvents tglsekarang As System.Windows.Forms.Label
    Friend WithEvents jamsekarang As System.Windows.Forms.Label
    Friend WithEvents nik As System.Windows.Forms.Label
    Friend WithEvents info As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
