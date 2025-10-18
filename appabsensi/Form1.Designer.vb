<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnAbsensi = New Button()
        btnRiwayat = New Button()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnAbsensi
        ' 
        btnAbsensi.Anchor = AnchorStyles.Top
        btnAbsensi.Font = New Font("Showcard Gothic", 14.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAbsensi.Location = New Point(322, 335)
        btnAbsensi.Margin = New Padding(2)
        btnAbsensi.Name = "btnAbsensi"
        btnAbsensi.Size = New Size(361, 54)
        btnAbsensi.TabIndex = 0
        btnAbsensi.Text = "ABSENSI"
        btnAbsensi.UseVisualStyleBackColor = True
        ' 
        ' btnRiwayat
        ' 
        btnRiwayat.Anchor = AnchorStyles.Top
        btnRiwayat.Font = New Font("Showcard Gothic", 14.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRiwayat.Location = New Point(322, 427)
        btnRiwayat.Margin = New Padding(2)
        btnRiwayat.Name = "btnRiwayat"
        btnRiwayat.Size = New Size(361, 54)
        btnRiwayat.TabIndex = 1
        btnRiwayat.Text = "RIWAYAT ABSENSI"
        btnRiwayat.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top
        PictureBox1.BackgroundImage = My.Resources.Resources.PFP
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(420, 84)
        PictureBox1.Margin = New Padding(2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(157, 146)
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ButtonHighlight
        Label1.Font = New Font("Showcard Gothic", 24.0F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(342, 266)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(288, 40)
        Label1.TabIndex = 3
        Label1.Text = "SELAMAT DATANG"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        BackgroundImage = My.Resources.Resources.WB
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(959, 490)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(btnRiwayat)
        Controls.Add(btnAbsensi)
        Margin = New Padding(2)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnAbsensi As Button
    Friend WithEvents btnRiwayat As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label

End Class
