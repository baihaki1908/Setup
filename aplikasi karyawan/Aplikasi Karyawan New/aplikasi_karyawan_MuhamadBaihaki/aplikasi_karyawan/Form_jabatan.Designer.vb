<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_jabatan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_jabatan))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Button1 = New System.Windows.Forms.Button
        Me.txtn = New System.Windows.Forms.TextBox
        Me.txtg = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtnik = New System.Windows.Forms.TextBox
        Me.btnh = New System.Windows.Forms.Button
        Me.btnu = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(92, 237)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(440, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(92, 163)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Simpan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtn
        '
        Me.txtn.Location = New System.Drawing.Point(219, 56)
        Me.txtn.Name = "txtn"
        Me.txtn.Size = New System.Drawing.Size(100, 20)
        Me.txtn.TabIndex = 3
        '
        'txtg
        '
        Me.txtg.Location = New System.Drawing.Point(219, 109)
        Me.txtg.Name = "txtg"
        Me.txtg.Size = New System.Drawing.Size(100, 20)
        Me.txtg.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(82, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nama Jabatan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(82, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Gaji Pokok"
        '
        'txtnik
        '
        Me.txtnik.Location = New System.Drawing.Point(219, 12)
        Me.txtnik.Name = "txtnik"
        Me.txtnik.Size = New System.Drawing.Size(100, 20)
        Me.txtnik.TabIndex = 7
        '
        'btnh
        '
        Me.btnh.Image = CType(resources.GetObject("btnh.Image"), System.Drawing.Image)
        Me.btnh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnh.Location = New System.Drawing.Point(195, 163)
        Me.btnh.Name = "btnh"
        Me.btnh.Size = New System.Drawing.Size(75, 23)
        Me.btnh.TabIndex = 8
        Me.btnh.Text = "Hapus"
        Me.btnh.UseVisualStyleBackColor = True
        '
        'btnu
        '
        Me.btnu.Image = CType(resources.GetObject("btnu.Image"), System.Drawing.Image)
        Me.btnu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnu.Location = New System.Drawing.Point(294, 163)
        Me.btnu.Name = "btnu"
        Me.btnu.Size = New System.Drawing.Size(75, 23)
        Me.btnu.TabIndex = 9
        Me.btnu.Text = "Update"
        Me.btnu.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(397, 163)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Keluar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form_jabatan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(650, 422)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnu)
        Me.Controls.Add(Me.btnh)
        Me.Controls.Add(Me.txtnik)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtg)
        Me.Controls.Add(Me.txtn)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form_jabatan"
        Me.Text = "Form_jabatan"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtn As System.Windows.Forms.TextBox
    Friend WithEvents txtg As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtnik As System.Windows.Forms.TextBox
    Friend WithEvents btnh As System.Windows.Forms.Button
    Friend WithEvents btnu As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
