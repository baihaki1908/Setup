<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_lembur
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_lembur))
        Me.txtjjl = New System.Windows.Forms.TextBox
        Me.txttul = New System.Windows.Forms.TextBox
        Me.txtul = New System.Windows.Forms.TextBox
        Me.txtil = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbij = New System.Windows.Forms.ComboBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.tgl = New System.Windows.Forms.DateTimePicker
        Me.Button2 = New System.Windows.Forms.Button
        Me.btnu = New System.Windows.Forms.Button
        Me.btnh = New System.Windows.Forms.Button
        Me.btns = New System.Windows.Forms.Button
        Me.cmbnik = New System.Windows.Forms.ComboBox
        Me.txtn = New System.Windows.Forms.TextBox
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtjjl
        '
        Me.txtjjl.Location = New System.Drawing.Point(197, 279)
        Me.txtjjl.Name = "txtjjl"
        Me.txtjjl.Size = New System.Drawing.Size(100, 20)
        Me.txtjjl.TabIndex = 48
        '
        'txttul
        '
        Me.txttul.Location = New System.Drawing.Point(197, 363)
        Me.txttul.Name = "txttul"
        Me.txttul.Size = New System.Drawing.Size(100, 20)
        Me.txttul.TabIndex = 47
        '
        'txtul
        '
        Me.txtul.Location = New System.Drawing.Point(197, 321)
        Me.txtul.Name = "txtul"
        Me.txtul.Size = New System.Drawing.Size(100, 20)
        Me.txtul.TabIndex = 46
        '
        'txtil
        '
        Me.txtil.Location = New System.Drawing.Point(197, 87)
        Me.txtil.Name = "txtil"
        Me.txtil.Size = New System.Drawing.Size(100, 20)
        Me.txtil.TabIndex = 44
        Me.txtil.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(68, 87)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(76, 16)
        Me.Label16.TabIndex = 40
        Me.Label16.Text = "Id Lembur"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(68, 282)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(112, 16)
        Me.Label14.TabIndex = 39
        Me.Label14.Text = "Jml jam lembur"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(69, 199)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 16)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "id jabatan"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(70, 363)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 16)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Ttl uang lembur"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(70, 129)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 16)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "NIK"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(70, 242)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 16)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "tgl lembur"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(69, 328)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 16)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Uang Lembur"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(70, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 16)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Nama Karyawan"
        '
        'cmbij
        '
        Me.cmbij.FormattingEnabled = True
        Me.cmbij.Location = New System.Drawing.Point(197, 199)
        Me.cmbij.Name = "cmbij"
        Me.cmbij.Size = New System.Drawing.Size(121, 21)
        Me.cmbij.TabIndex = 49
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Highlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(420, 98)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(400, 268)
        Me.DataGridView1.TabIndex = 50
        '
        'tgl
        '
        Me.tgl.CustomFormat = "yyyy-MM-dd"
        Me.tgl.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tgl.Location = New System.Drawing.Point(197, 236)
        Me.tgl.Name = "tgl"
        Me.tgl.Size = New System.Drawing.Size(200, 20)
        Me.tgl.TabIndex = 51
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(732, 392)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 46)
        Me.Button2.TabIndex = 55
        Me.Button2.Text = "Keluar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnu
        '
        Me.btnu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnu.Image = CType(resources.GetObject("btnu.Image"), System.Drawing.Image)
        Me.btnu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnu.Location = New System.Drawing.Point(629, 392)
        Me.btnu.Name = "btnu"
        Me.btnu.Size = New System.Drawing.Size(88, 46)
        Me.btnu.TabIndex = 54
        Me.btnu.Text = "Update"
        Me.btnu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnu.UseVisualStyleBackColor = True
        '
        'btnh
        '
        Me.btnh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnh.Image = CType(resources.GetObject("btnh.Image"), System.Drawing.Image)
        Me.btnh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnh.Location = New System.Drawing.Point(530, 392)
        Me.btnh.Name = "btnh"
        Me.btnh.Size = New System.Drawing.Size(88, 46)
        Me.btnh.TabIndex = 53
        Me.btnh.Text = "Hapus"
        Me.btnh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnh.UseVisualStyleBackColor = True
        '
        'btns
        '
        Me.btns.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btns.Image = CType(resources.GetObject("btns.Image"), System.Drawing.Image)
        Me.btns.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btns.Location = New System.Drawing.Point(427, 392)
        Me.btns.Name = "btns"
        Me.btns.Size = New System.Drawing.Size(88, 46)
        Me.btns.TabIndex = 52
        Me.btns.Text = "Simpan"
        Me.btns.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btns.UseVisualStyleBackColor = True
        '
        'cmbnik
        '
        Me.cmbnik.FormattingEnabled = True
        Me.cmbnik.Location = New System.Drawing.Point(197, 120)
        Me.cmbnik.Name = "cmbnik"
        Me.cmbnik.Size = New System.Drawing.Size(121, 21)
        Me.cmbnik.TabIndex = 56
        '
        'txtn
        '
        Me.txtn.Location = New System.Drawing.Point(197, 160)
        Me.txtn.Name = "txtn"
        Me.txtn.Size = New System.Drawing.Size(100, 20)
        Me.txtn.TabIndex = 57
        '
        'Frm_lembur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(965, 550)
        Me.Controls.Add(Me.txtn)
        Me.Controls.Add(Me.cmbnik)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnu)
        Me.Controls.Add(Me.btnh)
        Me.Controls.Add(Me.btns)
        Me.Controls.Add(Me.tgl)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cmbij)
        Me.Controls.Add(Me.txtjjl)
        Me.Controls.Add(Me.txttul)
        Me.Controls.Add(Me.txtul)
        Me.Controls.Add(Me.txtil)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Frm_lembur"
        Me.Text = "Frm_lembur"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtjjl As System.Windows.Forms.TextBox
    Friend WithEvents txttul As System.Windows.Forms.TextBox
    Friend WithEvents txtul As System.Windows.Forms.TextBox
    Friend WithEvents txtil As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbij As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents tgl As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnu As System.Windows.Forms.Button
    Friend WithEvents btnh As System.Windows.Forms.Button
    Friend WithEvents btns As System.Windows.Forms.Button
    Friend WithEvents cmbnik As System.Windows.Forms.ComboBox
    Friend WithEvents txtn As System.Windows.Forms.TextBox
End Class
