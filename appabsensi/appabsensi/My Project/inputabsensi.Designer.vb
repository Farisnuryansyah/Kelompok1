<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inputabsensi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list
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
        components = New ComponentModel.Container()
        Label1 = New Label()
        Label2 = New Label()
        txtnama = New TextBox()
        txtnim = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        cbkelas = New ComboBox()
        cbprodi = New ComboBox()
        DateTimePicker1 = New DateTimePicker()
        Label6 = New Label()
        txtwaktu = New TextBox()
        Label7 = New Label()
        btnsimpan = New Button()
        btnbatal = New Button()
        PictureBox1 = New PictureBox()
        btnupload = New Button()
        OpenFileDialog1 = New OpenFileDialog()
        Timer1 = New Timer(components)
        Label8 = New Label()
        cb_matakuliah = New ComboBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Showcard Gothic", 24.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(396, 32)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(143, 40)
        Label1.TabIndex = 0
        Label1.Text = "ABSENSI"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(200, 110)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(43, 15)
        Label2.TabIndex = 1
        Label2.Text = "NAMA"
        ' 
        ' txtnama
        ' 
        txtnama.Location = New Point(396, 107)
        txtnama.Margin = New Padding(2)
        txtnama.Name = "txtnama"
        txtnama.Size = New Size(338, 23)
        txtnama.TabIndex = 2
        ' 
        ' txtnim
        ' 
        txtnim.Location = New Point(396, 142)
        txtnim.Margin = New Padding(2)
        txtnim.Name = "txtnim"
        txtnim.Size = New Size(338, 23)
        txtnim.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(200, 145)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(30, 15)
        Label3.TabIndex = 3
        Label3.Text = "NIM"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(200, 178)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(41, 15)
        Label4.TabIndex = 7
        Label4.Text = "PRODI"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(197, 211)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(40, 15)
        Label5.TabIndex = 5
        Label5.Text = "KELAS"
        ' 
        ' cbkelas
        ' 
        cbkelas.FormattingEnabled = True
        cbkelas.Items.AddRange(New Object() {"TI.23.C1", "TI.23.C2", "TI.23.C3", "TI.23.C4", "TI.23.C5", "TI.23.C6", "TI.23.C8", "TI.23.C9"})
        cbkelas.Location = New Point(396, 211)
        cbkelas.Margin = New Padding(2)
        cbkelas.Name = "cbkelas"
        cbkelas.Size = New Size(338, 23)
        cbkelas.TabIndex = 8
        cbkelas.Text = " Pilih Kelas"
        ' 
        ' cbprodi
        ' 
        cbprodi.FormattingEnabled = True
        cbprodi.Items.AddRange(New Object() {"Teknik Informatika", "Sistem Informasi"})
        cbprodi.Location = New Point(396, 176)
        cbprodi.Margin = New Padding(2)
        cbprodi.Name = "cbprodi"
        cbprodi.Size = New Size(338, 23)
        cbprodi.TabIndex = 9
        cbprodi.Text = " Pilih Prodi"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(396, 284)
        DateTimePicker1.Margin = New Padding(2)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(338, 23)
        DateTimePicker1.TabIndex = 10
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(195, 284)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(60, 15)
        Label6.TabIndex = 11
        Label6.Text = "TANGGAL"
        ' 
        ' txtwaktu
        ' 
        txtwaktu.Location = New Point(396, 317)
        txtwaktu.Margin = New Padding(2)
        txtwaktu.Name = "txtwaktu"
        txtwaktu.Size = New Size(338, 23)
        txtwaktu.TabIndex = 13
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(195, 317)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(48, 15)
        Label7.TabIndex = 12
        Label7.Text = "WAKTU"
        ' 
        ' btnsimpan
        ' 
        btnsimpan.BackColor = Color.Lime
        btnsimpan.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnsimpan.Location = New Point(396, 482)
        btnsimpan.Margin = New Padding(2)
        btnsimpan.Name = "btnsimpan"
        btnsimpan.Size = New Size(162, 34)
        btnsimpan.TabIndex = 14
        btnsimpan.Text = "SIMPAN"
        btnsimpan.UseVisualStyleBackColor = False
        ' 
        ' btnbatal
        ' 
        btnbatal.BackColor = Color.Red
        btnbatal.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnbatal.Location = New Point(570, 482)
        btnbatal.Margin = New Padding(2)
        btnbatal.Name = "btnbatal"
        btnbatal.Size = New Size(162, 34)
        btnbatal.TabIndex = 15
        btnbatal.Text = "BATAL"
        btnbatal.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Location = New Point(402, 349)
        PictureBox1.Margin = New Padding(2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(150, 105)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 16
        PictureBox1.TabStop = False
        ' 
        ' btnupload
        ' 
        btnupload.BackColor = Color.Blue
        btnupload.Font = New Font("Arial Rounded MT Bold", 8.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnupload.ForeColor = SystemColors.ButtonHighlight
        btnupload.Location = New Point(402, 458)
        btnupload.Margin = New Padding(2)
        btnupload.Name = "btnupload"
        btnupload.Size = New Size(150, 20)
        btnupload.TabIndex = 17
        btnupload.Text = "Upload Foto"
        btnupload.UseVisualStyleBackColor = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 1000
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(195, 249)
        Label8.Margin = New Padding(2, 0, 2, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(80, 15)
        Label8.TabIndex = 18
        Label8.Text = "MATAKULIAH"
        ' 
        ' cb_matakuliah
        ' 
        cb_matakuliah.FormattingEnabled = True
        cb_matakuliah.Items.AddRange(New Object() {"AGAMA ISLAM", "PERANCANGAN SISTEM INFORMASI", "MANAGEMENT BASIS DATA", "SISTEM KEPUTUSAN", "ARTIFICIAL INTELEGENT", "IOT"})
        cb_matakuliah.Location = New Point(396, 244)
        cb_matakuliah.Margin = New Padding(2)
        cb_matakuliah.Name = "cb_matakuliah"
        cb_matakuliah.Size = New Size(338, 23)
        cb_matakuliah.TabIndex = 19
        cb_matakuliah.Text = " Pilih Matakuliah"
        ' 
        ' inputabsensi
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(959, 555)
        Controls.Add(cb_matakuliah)
        Controls.Add(Label8)
        Controls.Add(btnupload)
        Controls.Add(PictureBox1)
        Controls.Add(btnbatal)
        Controls.Add(btnsimpan)
        Controls.Add(txtwaktu)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(DateTimePicker1)
        Controls.Add(cbprodi)
        Controls.Add(cbkelas)
        Controls.Add(Label4)
        Controls.Add(Label5)
        Controls.Add(txtnim)
        Controls.Add(Label3)
        Controls.Add(txtnama)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Margin = New Padding(2)
        Name = "inputabsensi"
        Text = "inputabsensi"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtnama As TextBox
    Friend WithEvents txtnim As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cbkelas As ComboBox
    Friend WithEvents cbprodi As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents txtwaktu As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnsimpan As Button
    Friend WithEvents btnbatal As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnupload As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label8 As Label
    Friend WithEvents cb_matakuliah As ComboBox
End Class
