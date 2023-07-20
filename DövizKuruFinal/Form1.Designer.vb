<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Label3 = New Label()
        Label4 = New Label()
        txteuro_alis = New TextBox()
        txteuro_satis = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        txtsterlin_satis = New TextBox()
        txt_sterlinalis = New TextBox()
        Label12 = New Label()
        Label11 = New Label()
        txtfrang_alis = New TextBox()
        txt_frangsatis = New TextBox()
        GroupBox6 = New GroupBox()
        ComboBox1 = New ComboBox()
        txtsatis = New TextBox()
        txtalis = New TextBox()
        txtmiktar = New TextBox()
        Label16 = New Label()
        Label15 = New Label()
        Label14 = New Label()
        Label13 = New Label()
        usdflag = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        txtdlr_alis = New TextBox()
        txtdlr_satis = New TextBox()
        europaflag = New PictureBox()
        isvicreflag = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        txt_yenalis = New TextBox()
        txt_yensatis = New TextBox()
        PictureBox1 = New PictureBox()
        txt_kanadaalis = New TextBox()
        txt_kanadasatis = New TextBox()
        PictureBox2 = New PictureBox()
        txt_suudialis = New TextBox()
        txt_suudisatis = New TextBox()
        PictureBox3 = New PictureBox()
        txt_dinaralis = New TextBox()
        txt_dinarsatis = New TextBox()
        Timer1 = New Timer(components)
        GroupBox6.SuspendLayout()
        CType(usdflag, ComponentModel.ISupportInitialize).BeginInit()
        CType(europaflag, ComponentModel.ISupportInitialize).BeginInit()
        CType(isvicreflag, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(201, 109)
        Label3.Name = "Label3"
        Label3.Size = New Size(90, 25)
        Label3.TabIndex = 3
        Label3.Text = "Euro Alış:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(417, 120)
        Label4.Name = "Label4"
        Label4.Size = New Size(99, 25)
        Label4.TabIndex = 3
        Label4.Text = "Euro Satış:"
        ' 
        ' txteuro_alis
        ' 
        txteuro_alis.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        txteuro_alis.Location = New Point(201, 148)
        txteuro_alis.Name = "txteuro_alis"
        txteuro_alis.ReadOnly = True
        txteuro_alis.Size = New Size(147, 33)
        txteuro_alis.TabIndex = 4
        ' 
        ' txteuro_satis
        ' 
        txteuro_satis.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        txteuro_satis.Location = New Point(410, 150)
        txteuro_satis.Name = "txteuro_satis"
        txteuro_satis.ReadOnly = True
        txteuro_satis.Size = New Size(148, 33)
        txteuro_satis.TabIndex = 4
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.DarkBlue
        Label5.Location = New Point(426, 230)
        Label5.Name = "Label5"
        Label5.Size = New Size(43, 21)
        Label5.TabIndex = 6
        Label5.Text = "ALIŞ"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.DarkBlue
        Label6.Location = New Point(528, 230)
        Label6.Name = "Label6"
        Label6.Size = New Size(52, 21)
        Label6.TabIndex = 6
        Label6.Text = "SATIŞ"
        ' 
        ' txtsterlin_satis
        ' 
        txtsterlin_satis.Location = New Point(504, 266)
        txtsterlin_satis.Name = "txtsterlin_satis"
        txtsterlin_satis.ReadOnly = True
        txtsterlin_satis.Size = New Size(100, 23)
        txtsterlin_satis.TabIndex = 7
        ' 
        ' txt_sterlinalis
        ' 
        txt_sterlinalis.Location = New Point(397, 266)
        txt_sterlinalis.Name = "txt_sterlinalis"
        txt_sterlinalis.ReadOnly = True
        txt_sterlinalis.Size = New Size(100, 23)
        txt_sterlinalis.TabIndex = 7
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.ForeColor = Color.DarkBlue
        Label12.Location = New Point(217, 230)
        Label12.Name = "Label12"
        Label12.Size = New Size(52, 21)
        Label12.TabIndex = 1
        Label12.Text = "SATIŞ"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.ForeColor = Color.DarkBlue
        Label11.Location = New Point(116, 230)
        Label11.Name = "Label11"
        Label11.Size = New Size(43, 21)
        Label11.TabIndex = 1
        Label11.Text = "ALIŞ"
        ' 
        ' txtfrang_alis
        ' 
        txtfrang_alis.Location = New Point(87, 266)
        txtfrang_alis.Name = "txtfrang_alis"
        txtfrang_alis.ReadOnly = True
        txtfrang_alis.Size = New Size(100, 23)
        txtfrang_alis.TabIndex = 0
        ' 
        ' txt_frangsatis
        ' 
        txt_frangsatis.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        txt_frangsatis.ForeColor = Color.DarkBlue
        txt_frangsatis.Location = New Point(193, 266)
        txt_frangsatis.Name = "txt_frangsatis"
        txt_frangsatis.ReadOnly = True
        txt_frangsatis.Size = New Size(100, 23)
        txt_frangsatis.TabIndex = 0
        ' 
        ' GroupBox6
        ' 
        GroupBox6.BackColor = Color.Transparent
        GroupBox6.Controls.Add(ComboBox1)
        GroupBox6.Controls.Add(txtsatis)
        GroupBox6.Controls.Add(txtalis)
        GroupBox6.Controls.Add(txtmiktar)
        GroupBox6.Controls.Add(Label16)
        GroupBox6.Controls.Add(Label15)
        GroupBox6.Controls.Add(Label14)
        GroupBox6.Controls.Add(Label13)
        GroupBox6.ForeColor = Color.Transparent
        GroupBox6.Location = New Point(640, 29)
        GroupBox6.Name = "GroupBox6"
        GroupBox6.Size = New Size(324, 334)
        GroupBox6.TabIndex = 12
        GroupBox6.TabStop = False
        GroupBox6.Text = "GroupBox6"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = SystemColors.Control
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Dolar", "Euro", "Sterlin", "Dinar", "Yen" & vbTab, "Frang", "Riyal" & vbTab, "Kanada Doları"})
        ComboBox1.Location = New Point(112, 51)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 5
        ' 
        ' txtsatis
        ' 
        txtsatis.Location = New Point(112, 246)
        txtsatis.Name = "txtsatis"
        txtsatis.ReadOnly = True
        txtsatis.Size = New Size(121, 23)
        txtsatis.TabIndex = 3
        ' 
        ' txtalis
        ' 
        txtalis.Location = New Point(112, 184)
        txtalis.Name = "txtalis"
        txtalis.ReadOnly = True
        txtalis.Size = New Size(121, 23)
        txtalis.TabIndex = 3
        ' 
        ' txtmiktar
        ' 
        txtmiktar.BackColor = SystemColors.Control
        txtmiktar.Location = New Point(112, 100)
        txtmiktar.Name = "txtmiktar"
        txtmiktar.Size = New Size(121, 23)
        txtmiktar.TabIndex = 3
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Times New Roman", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label16.ForeColor = Color.Black
        Label16.Location = New Point(30, 254)
        Label16.Name = "Label16"
        Label16.Size = New Size(47, 19)
        Label16.TabIndex = 2
        Label16.Text = "Satış:"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Times New Roman", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label15.ForeColor = Color.Black
        Label15.Location = New Point(22, 187)
        Label15.Name = "Label15"
        Label15.Size = New Size(41, 19)
        Label15.TabIndex = 2
        Label15.Text = "Alış:"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.ForeColor = Color.Black
        Label14.Location = New Point(30, 103)
        Label14.Name = "Label14"
        Label14.Size = New Size(49, 15)
        Label14.TabIndex = 2
        Label14.Text = "Miktar="
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.ForeColor = Color.Black
        Label13.Location = New Point(30, 54)
        Label13.Name = "Label13"
        Label13.Size = New Size(29, 15)
        Label13.TabIndex = 1
        Label13.Text = "KUR"
        ' 
        ' usdflag
        ' 
        usdflag.Image = CType(resources.GetObject("usdflag.Image"), Image)
        usdflag.Location = New Point(27, 12)
        usdflag.Name = "usdflag"
        usdflag.Size = New Size(105, 74)
        usdflag.SizeMode = PictureBoxSizeMode.StretchImage
        usdflag.TabIndex = 2
        usdflag.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(201, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 25)
        Label1.TabIndex = 0
        Label1.Text = "Dolar Alış:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(410, 12)
        Label2.Name = "Label2"
        Label2.Size = New Size(106, 25)
        Label2.TabIndex = 0
        Label2.Text = "Dolar Satış:"
        ' 
        ' txtdlr_alis
        ' 
        txtdlr_alis.BackColor = SystemColors.Control
        txtdlr_alis.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtdlr_alis.Location = New Point(201, 48)
        txtdlr_alis.Name = "txtdlr_alis"
        txtdlr_alis.ReadOnly = True
        txtdlr_alis.Size = New Size(147, 33)
        txtdlr_alis.TabIndex = 1
        ' 
        ' txtdlr_satis
        ' 
        txtdlr_satis.BackColor = SystemColors.Control
        txtdlr_satis.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtdlr_satis.Location = New Point(410, 48)
        txtdlr_satis.Name = "txtdlr_satis"
        txtdlr_satis.ReadOnly = True
        txtdlr_satis.Size = New Size(148, 33)
        txtdlr_satis.TabIndex = 1
        ' 
        ' europaflag
        ' 
        europaflag.Image = CType(resources.GetObject("europaflag.Image"), Image)
        europaflag.Location = New Point(27, 109)
        europaflag.Name = "europaflag"
        europaflag.Size = New Size(105, 74)
        europaflag.SizeMode = PictureBoxSizeMode.StretchImage
        europaflag.TabIndex = 13
        europaflag.TabStop = False
        ' 
        ' isvicreflag
        ' 
        isvicreflag.Image = CType(resources.GetObject("isvicreflag.Image"), Image)
        isvicreflag.Location = New Point(27, 257)
        isvicreflag.Name = "isvicreflag"
        isvicreflag.Size = New Size(50, 40)
        isvicreflag.SizeMode = PictureBoxSizeMode.StretchImage
        isvicreflag.TabIndex = 14
        isvicreflag.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(333, 257)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(50, 40)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 15
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(27, 305)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(50, 40)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 16
        PictureBox5.TabStop = False
        ' 
        ' txt_yenalis
        ' 
        txt_yenalis.Location = New Point(87, 314)
        txt_yenalis.Name = "txt_yenalis"
        txt_yenalis.ReadOnly = True
        txt_yenalis.Size = New Size(100, 23)
        txt_yenalis.TabIndex = 0
        ' 
        ' txt_yensatis
        ' 
        txt_yensatis.Location = New Point(193, 314)
        txt_yensatis.Name = "txt_yensatis"
        txt_yensatis.ReadOnly = True
        txt_yensatis.Size = New Size(100, 23)
        txt_yensatis.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(333, 305)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(50, 40)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 17
        PictureBox1.TabStop = False
        ' 
        ' txt_kanadaalis
        ' 
        txt_kanadaalis.Location = New Point(397, 314)
        txt_kanadaalis.Name = "txt_kanadaalis"
        txt_kanadaalis.ReadOnly = True
        txt_kanadaalis.Size = New Size(100, 23)
        txt_kanadaalis.TabIndex = 0
        ' 
        ' txt_kanadasatis
        ' 
        txt_kanadasatis.Location = New Point(504, 314)
        txt_kanadasatis.Name = "txt_kanadasatis"
        txt_kanadasatis.ReadOnly = True
        txt_kanadasatis.Size = New Size(100, 23)
        txt_kanadasatis.TabIndex = 0
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(27, 353)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(50, 40)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 18
        PictureBox2.TabStop = False
        ' 
        ' txt_suudialis
        ' 
        txt_suudialis.Location = New Point(87, 362)
        txt_suudialis.Name = "txt_suudialis"
        txt_suudialis.ReadOnly = True
        txt_suudialis.Size = New Size(100, 23)
        txt_suudialis.TabIndex = 0
        ' 
        ' txt_suudisatis
        ' 
        txt_suudisatis.Location = New Point(193, 362)
        txt_suudisatis.Name = "txt_suudisatis"
        txt_suudisatis.ReadOnly = True
        txt_suudisatis.Size = New Size(100, 23)
        txt_suudisatis.TabIndex = 0
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(333, 353)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(50, 40)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 19
        PictureBox3.TabStop = False
        ' 
        ' txt_dinaralis
        ' 
        txt_dinaralis.Location = New Point(397, 362)
        txt_dinaralis.Name = "txt_dinaralis"
        txt_dinaralis.ReadOnly = True
        txt_dinaralis.Size = New Size(100, 23)
        txt_dinaralis.TabIndex = 0
        ' 
        ' txt_dinarsatis
        ' 
        txt_dinarsatis.Location = New Point(504, 362)
        txt_dinarsatis.Name = "txt_dinarsatis"
        txt_dinarsatis.ReadOnly = True
        txt_dinarsatis.Size = New Size(100, 23)
        txt_dinarsatis.TabIndex = 0
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        AutoValidate = AutoValidate.Disable
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(981, 418)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(PictureBox5)
        Controls.Add(txtsterlin_satis)
        Controls.Add(PictureBox4)
        Controls.Add(Label6)
        Controls.Add(txt_sterlinalis)
        Controls.Add(Label12)
        Controls.Add(isvicreflag)
        Controls.Add(Label5)
        Controls.Add(txt_dinarsatis)
        Controls.Add(txt_dinaralis)
        Controls.Add(txt_kanadasatis)
        Controls.Add(txt_kanadaalis)
        Controls.Add(txt_suudisatis)
        Controls.Add(txt_suudialis)
        Controls.Add(txt_yensatis)
        Controls.Add(txt_yenalis)
        Controls.Add(txt_frangsatis)
        Controls.Add(txtfrang_alis)
        Controls.Add(Label11)
        Controls.Add(txteuro_satis)
        Controls.Add(europaflag)
        Controls.Add(Label4)
        Controls.Add(txteuro_alis)
        Controls.Add(Label2)
        Controls.Add(txtdlr_alis)
        Controls.Add(Label3)
        Controls.Add(txtdlr_satis)
        Controls.Add(usdflag)
        Controls.Add(GroupBox6)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Name = "Form1"
        Text = "Döviz Kuru İşlemleri"
        GroupBox6.ResumeLayout(False)
        GroupBox6.PerformLayout()
        CType(usdflag, ComponentModel.ISupportInitialize).EndInit()
        CType(europaflag, ComponentModel.ISupportInitialize).EndInit()
        CType(isvicreflag, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txteuro_alis As TextBox
    Friend WithEvents txteuro_satis As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtsterlin_satis As TextBox
    Friend WithEvents txt_sterlinalis As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtfrang_alis As TextBox
    Friend WithEvents txt_frangsatis As TextBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents txtsatis As TextBox
    Friend WithEvents txtalis As TextBox
    Friend WithEvents txtmiktar As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents usdflag As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtdlr_alis As TextBox
    Friend WithEvents txtdlr_satis As TextBox
    Friend WithEvents europaflag As PictureBox
    Friend WithEvents isvicreflag As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents txt_yenalis As TextBox
    Friend WithEvents txt_yensatis As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txt_kanadaalis As TextBox
    Friend WithEvents txt_kanadasatis As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txt_suudialis As TextBox
    Friend WithEvents txt_suudisatis As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents txt_dinaralis As TextBox
    Friend WithEvents txt_dinarsatis As TextBox
    Friend WithEvents Timer1 As Timer
End Class
