<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formedit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formedit))
        Me.txtupdate = New System.Windows.Forms.Button
        Me.ptterakhir = New System.Windows.Forms.ComboBox
        Me.cmbstatuskerja = New System.Windows.Forms.ComboBox
        Me.cmbstatuskaryawan = New System.Windows.Forms.ComboBox
        Me.cmbstatus = New System.Windows.Forms.ComboBox
        Me.cmbagama = New System.Windows.Forms.ComboBox
        Me.cmbkewarganegaraan = New System.Windows.Forms.ComboBox
        Me.dttanggalmasuk = New System.Windows.Forms.DateTimePicker
        Me.dttanggallahhir = New System.Windows.Forms.DateTimePicker
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtgaji = New System.Windows.Forms.TextBox
        Me.txtbagian = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtjabatan = New System.Windows.Forms.TextBox
        Me.txtpendidikanterakhir = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtalamat = New System.Windows.Forms.TextBox
        Me.txtemail = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtnohp = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtempattlahir = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtnama = New System.Windows.Forms.TextBox
        Me.txtnik = New System.Windows.Forms.TextBox
        Me.btndelete = New System.Windows.Forms.Button
        Me.btnt = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txtupdate
        '
        Me.txtupdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtupdate.Image = CType(resources.GetObject("txtupdate.Image"), System.Drawing.Image)
        Me.txtupdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.txtupdate.Location = New System.Drawing.Point(636, 435)
        Me.txtupdate.Name = "txtupdate"
        Me.txtupdate.Size = New System.Drawing.Size(121, 40)
        Me.txtupdate.TabIndex = 83
        Me.txtupdate.Text = "Update"
        Me.txtupdate.UseVisualStyleBackColor = True
        '
        'ptterakhir
        '
        Me.ptterakhir.FormattingEnabled = True
        Me.ptterakhir.Items.AddRange(New Object() {"TK", "SD", "SMP", "SMA", "S1", "S2", "S3"})
        Me.ptterakhir.Location = New System.Drawing.Point(636, 54)
        Me.ptterakhir.Name = "ptterakhir"
        Me.ptterakhir.Size = New System.Drawing.Size(121, 21)
        Me.ptterakhir.TabIndex = 81
        '
        'cmbstatuskerja
        '
        Me.cmbstatuskerja.FormattingEnabled = True
        Me.cmbstatuskerja.Items.AddRange(New Object() {"Aktif", "Tidak Aktif"})
        Me.cmbstatuskerja.Location = New System.Drawing.Point(636, 363)
        Me.cmbstatuskerja.Name = "cmbstatuskerja"
        Me.cmbstatuskerja.Size = New System.Drawing.Size(121, 21)
        Me.cmbstatuskerja.TabIndex = 80
        '
        'cmbstatuskaryawan
        '
        Me.cmbstatuskaryawan.FormattingEnabled = True
        Me.cmbstatuskaryawan.Items.AddRange(New Object() {"Tetap", "Kontrak"})
        Me.cmbstatuskaryawan.Location = New System.Drawing.Point(636, 311)
        Me.cmbstatuskaryawan.Name = "cmbstatuskaryawan"
        Me.cmbstatuskaryawan.Size = New System.Drawing.Size(121, 21)
        Me.cmbstatuskaryawan.TabIndex = 79
        '
        'cmbstatus
        '
        Me.cmbstatus.FormattingEnabled = True
        Me.cmbstatus.Items.AddRange(New Object() {"Kawin", "Belum Kawin"})
        Me.cmbstatus.Location = New System.Drawing.Point(218, 263)
        Me.cmbstatus.Name = "cmbstatus"
        Me.cmbstatus.Size = New System.Drawing.Size(121, 21)
        Me.cmbstatus.TabIndex = 78
        '
        'cmbagama
        '
        Me.cmbagama.FormattingEnabled = True
        Me.cmbagama.Items.AddRange(New Object() {"Islam", "Kristen", "Katholik", "Budha", "Hindhu"})
        Me.cmbagama.Location = New System.Drawing.Point(218, 205)
        Me.cmbagama.Name = "cmbagama"
        Me.cmbagama.Size = New System.Drawing.Size(121, 21)
        Me.cmbagama.TabIndex = 77
        '
        'cmbkewarganegaraan
        '
        Me.cmbkewarganegaraan.FormattingEnabled = True
        Me.cmbkewarganegaraan.Items.AddRange(New Object() {"WNI", "WNA"})
        Me.cmbkewarganegaraan.Location = New System.Drawing.Point(218, 312)
        Me.cmbkewarganegaraan.Name = "cmbkewarganegaraan"
        Me.cmbkewarganegaraan.Size = New System.Drawing.Size(121, 21)
        Me.cmbkewarganegaraan.TabIndex = 76
        '
        'dttanggalmasuk
        '
        Me.dttanggalmasuk.CustomFormat = "yyyy/MM/dd"
        Me.dttanggalmasuk.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dttanggalmasuk.Location = New System.Drawing.Point(636, 168)
        Me.dttanggalmasuk.Name = "dttanggalmasuk"
        Me.dttanggalmasuk.Size = New System.Drawing.Size(200, 20)
        Me.dttanggalmasuk.TabIndex = 75
        '
        'dttanggallahhir
        '
        Me.dttanggallahhir.CustomFormat = "yyyy/MM/dd"
        Me.dttanggallahhir.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dttanggallahhir.Location = New System.Drawing.Point(218, 152)
        Me.dttanggallahhir.Name = "dttanggallahhir"
        Me.dttanggallahhir.Size = New System.Drawing.Size(200, 20)
        Me.dttanggallahhir.TabIndex = 74
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(476, 372)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 13)
        Me.Label11.TabIndex = 73
        Me.Label11.Text = "STATUS KERJA"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(476, 315)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(115, 13)
        Me.Label12.TabIndex = 72
        Me.Label12.Text = "STATUS KARYAWAN"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(476, 271)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(30, 13)
        Me.Label13.TabIndex = 71
        Me.Label13.Text = "GAJI"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(476, 214)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(47, 13)
        Me.Label14.TabIndex = 70
        Me.Label14.Text = "BAGIAN"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(476, 158)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(99, 13)
        Me.Label15.TabIndex = 69
        Me.Label15.Text = "TANGGAL MASUK"
        '
        'txtgaji
        '
        Me.txtgaji.Location = New System.Drawing.Point(636, 268)
        Me.txtgaji.Name = "txtgaji"
        Me.txtgaji.Size = New System.Drawing.Size(100, 20)
        Me.txtgaji.TabIndex = 68
        '
        'txtbagian
        '
        Me.txtbagian.Location = New System.Drawing.Point(636, 211)
        Me.txtbagian.Name = "txtbagian"
        Me.txtbagian.Size = New System.Drawing.Size(100, 20)
        Me.txtbagian.TabIndex = 67
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(476, 114)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(55, 13)
        Me.Label16.TabIndex = 66
        Me.Label16.Text = "JABATAN"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(476, 57)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(79, 13)
        Me.Label17.TabIndex = 65
        Me.Label17.Text = "PT TERAKHIR"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(476, 1)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(131, 13)
        Me.Label18.TabIndex = 64
        Me.Label18.Text = "PENDIDIKAN TERAKHIR"
        '
        'txtjabatan
        '
        Me.txtjabatan.Location = New System.Drawing.Point(636, 111)
        Me.txtjabatan.Name = "txtjabatan"
        Me.txtjabatan.Size = New System.Drawing.Size(100, 20)
        Me.txtjabatan.TabIndex = 63
        '
        'txtpendidikanterakhir
        '
        Me.txtpendidikanterakhir.Location = New System.Drawing.Point(636, 1)
        Me.txtpendidikanterakhir.Name = "txtpendidikanterakhir"
        Me.txtpendidikanterakhir.Size = New System.Drawing.Size(100, 20)
        Me.txtpendidikanterakhir.TabIndex = 62
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(90, 480)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 13)
        Me.Label9.TabIndex = 61
        Me.Label9.Text = "ALAMAT"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(90, 423)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 13)
        Me.Label10.TabIndex = 60
        Me.Label10.Text = "EMAIL"
        '
        'txtalamat
        '
        Me.txtalamat.Location = New System.Drawing.Point(218, 464)
        Me.txtalamat.Multiline = True
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtalamat.Size = New System.Drawing.Size(100, 39)
        Me.txtalamat.TabIndex = 59
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(218, 420)
        Me.txtemail.Multiline = True
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(100, 20)
        Me.txtemail.TabIndex = 58
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(90, 375)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "NO HP"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(90, 315)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 13)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "KEWARGANEGARAAN"
        '
        'txtnohp
        '
        Me.txtnohp.Location = New System.Drawing.Point(218, 372)
        Me.txtnohp.Name = "txtnohp"
        Me.txtnohp.Size = New System.Drawing.Size(100, 20)
        Me.txtnohp.TabIndex = 55
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(95, 271)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "STATUS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(95, 214)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "AGAMA"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(95, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 13)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "TANGGAL LAHIR"
        '
        'txtempattlahir
        '
        Me.txtempattlahir.Location = New System.Drawing.Point(218, 114)
        Me.txtempattlahir.Name = "txtempattlahir"
        Me.txtempattlahir.Size = New System.Drawing.Size(100, 20)
        Me.txtempattlahir.TabIndex = 51
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(95, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "TEMPAT LAHIR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(95, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "NAMA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(95, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "NIK"
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(218, 57)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(100, 20)
        Me.txtnama.TabIndex = 47
        '
        'txtnik
        '
        Me.txtnik.Location = New System.Drawing.Point(218, 1)
        Me.txtnik.Name = "txtnik"
        Me.txtnik.Size = New System.Drawing.Size(100, 20)
        Me.txtnik.TabIndex = 46
        '
        'btndelete
        '
        Me.btndelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Image = CType(resources.GetObject("btndelete.Image"), System.Drawing.Image)
        Me.btndelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndelete.Location = New System.Drawing.Point(782, 435)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(121, 40)
        Me.btndelete.TabIndex = 84
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnt
        '
        Me.btnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnt.Image = CType(resources.GetObject("btnt.Image"), System.Drawing.Image)
        Me.btnt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnt.Location = New System.Drawing.Point(479, 435)
        Me.btnt.Name = "btnt"
        Me.btnt.Size = New System.Drawing.Size(121, 40)
        Me.btnt.TabIndex = 85
        Me.btnt.Text = "Tampil"
        Me.btnt.UseVisualStyleBackColor = True
        '
        'Formedit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1018, 522)
        Me.Controls.Add(Me.btnt)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.txtupdate)
        Me.Controls.Add(Me.ptterakhir)
        Me.Controls.Add(Me.cmbstatuskerja)
        Me.Controls.Add(Me.cmbstatuskaryawan)
        Me.Controls.Add(Me.cmbstatus)
        Me.Controls.Add(Me.cmbagama)
        Me.Controls.Add(Me.cmbkewarganegaraan)
        Me.Controls.Add(Me.dttanggalmasuk)
        Me.Controls.Add(Me.dttanggallahhir)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtgaji)
        Me.Controls.Add(Me.txtbagian)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtjabatan)
        Me.Controls.Add(Me.txtpendidikanterakhir)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtalamat)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtnohp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtempattlahir)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.txtnik)
        Me.Name = "Formedit"
        Me.Text = "Formedit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtupdate As System.Windows.Forms.Button
    Friend WithEvents ptterakhir As System.Windows.Forms.ComboBox
    Friend WithEvents cmbstatuskerja As System.Windows.Forms.ComboBox
    Friend WithEvents cmbstatuskaryawan As System.Windows.Forms.ComboBox
    Friend WithEvents cmbstatus As System.Windows.Forms.ComboBox
    Friend WithEvents cmbagama As System.Windows.Forms.ComboBox
    Friend WithEvents cmbkewarganegaraan As System.Windows.Forms.ComboBox
    Friend WithEvents dttanggalmasuk As System.Windows.Forms.DateTimePicker
    Friend WithEvents dttanggallahhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtgaji As System.Windows.Forms.TextBox
    Friend WithEvents txtbagian As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtjabatan As System.Windows.Forms.TextBox
    Friend WithEvents txtpendidikanterakhir As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtalamat As System.Windows.Forms.TextBox
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtnohp As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtempattlahir As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents txtnik As System.Windows.Forms.TextBox
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnt As System.Windows.Forms.Button
End Class
