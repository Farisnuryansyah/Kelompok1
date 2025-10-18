<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rekapabsensi
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
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        matakuliah = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        txtCariNIM = New TextBox()
        btnCari = New Button()
        btnClear = New Button()
        exportExcel = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.Font = New Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(419, 22)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(298, 40)
        Label1.TabIndex = 0
        Label1.Text = "RIWAYAT ABSENSI"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' DataGridView1
        ' 
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column8, Column2, Column3, Column4, matakuliah, Column5, Column6, Column7})
        DataGridView1.Location = New Point(114, 148)
        DataGridView1.Margin = New Padding(2)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(776, 190)
        DataGridView1.TabIndex = 1
        ' 
        ' Column1
        ' 
        Column1.DataPropertyName = "nama"
        Column1.HeaderText = "NAMA"
        Column1.MinimumWidth = 8
        Column1.Name = "Column1"
        ' 
        ' Column8
        ' 
        Column8.DataPropertyName = "waktu"
        Column8.HeaderText = "WAKTU"
        Column8.MinimumWidth = 8
        Column8.Name = "Column8"
        ' 
        ' Column2
        ' 
        Column2.DataPropertyName = "nim"
        Column2.HeaderText = "NIM"
        Column2.MinimumWidth = 8
        Column2.Name = "Column2"
        ' 
        ' Column3
        ' 
        Column3.DataPropertyName = "kelas"
        Column3.HeaderText = "KELAS"
        Column3.MinimumWidth = 8
        Column3.Name = "Column3"
        ' 
        ' Column4
        ' 
        Column4.DataPropertyName = "prodi"
        Column4.HeaderText = "PRODI"
        Column4.MinimumWidth = 8
        Column4.Name = "Column4"
        ' 
        ' matakuliah
        ' 
        matakuliah.DataPropertyName = "matakuliah"
        matakuliah.HeaderText = "MATA KULIAH"
        matakuliah.Name = "matakuliah"
        ' 
        ' Column5
        ' 
        Column5.DataPropertyName = "jam_masuk"
        Column5.HeaderText = "JAM MASUK"
        Column5.MinimumWidth = 8
        Column5.Name = "Column5"
        ' 
        ' Column6
        ' 
        Column6.DataPropertyName = "jam_keluar"
        Column6.HeaderText = "JAM KELUAR"
        Column6.MinimumWidth = 8
        Column6.Name = "Column6"
        ' 
        ' Column7
        ' 
        Column7.DataPropertyName = "tanggal"
        Column7.HeaderText = "TANGGAL"
        Column7.MinimumWidth = 8
        Column7.Name = "Column7"
        ' 
        ' txtCariNIM
        ' 
        txtCariNIM.Location = New Point(114, 109)
        txtCariNIM.Multiline = True
        txtCariNIM.Name = "txtCariNIM"
        txtCariNIM.Size = New Size(177, 30)
        txtCariNIM.TabIndex = 2
        ' 
        ' btnCari
        ' 
        btnCari.BackgroundImage = My.Resources.Resources.icons8_search_96
        btnCari.BackgroundImageLayout = ImageLayout.Zoom
        btnCari.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCari.Location = New Point(297, 109)
        btnCari.Name = "btnCari"
        btnCari.Size = New Size(33, 30)
        btnCari.TabIndex = 3
        btnCari.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.BackgroundImage = My.Resources.Resources.icons8_delete_96
        btnClear.BackgroundImageLayout = ImageLayout.Zoom
        btnClear.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClear.Location = New Point(336, 109)
        btnClear.Name = "btnClear"
        btnClear.RightToLeft = RightToLeft.No
        btnClear.Size = New Size(31, 30)
        btnClear.TabIndex = 4
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' exportExcel
        ' 
        exportExcel.BackgroundImage = My.Resources.Resources.icons8_microsoft_excel_96
        exportExcel.BackgroundImageLayout = ImageLayout.Zoom
        exportExcel.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        exportExcel.Location = New Point(373, 109)
        exportExcel.Name = "exportExcel"
        exportExcel.RightToLeft = RightToLeft.No
        exportExcel.Size = New Size(31, 30)
        exportExcel.TabIndex = 5
        exportExcel.UseVisualStyleBackColor = True
        ' 
        ' rekapabsensi
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(955, 449)
        Controls.Add(exportExcel)
        Controls.Add(btnClear)
        Controls.Add(btnCari)
        Controls.Add(txtCariNIM)
        Controls.Add(DataGridView1)
        Controls.Add(Label1)
        Margin = New Padding(2)
        Name = "rekapabsensi"
        StartPosition = FormStartPosition.CenterScreen
        Text = "rekapabsensi"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents txtCariNIM As TextBox
    Friend WithEvents btnCari As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents matakuliah As DataGridViewTextBoxColumn
    Friend WithEvents exportExcel As Button
End Class
