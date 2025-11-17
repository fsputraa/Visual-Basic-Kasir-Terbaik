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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.JUMLAHSOTOAYAM = New System.Windows.Forms.TextBox()
        Me.HARGASOTOAYAM = New System.Windows.Forms.TextBox()
        Me.HARGABAKSO = New System.Windows.Forms.TextBox()
        Me.JUMLAHBAKSO = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.HARGASATEAYAM = New System.Windows.Forms.TextBox()
        Me.JUMLAHSATEAYAM = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.HARGAPECELAYAM = New System.Windows.Forms.TextBox()
        Me.JUMLAHPECELAYAM = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.HARGAESKELAPA = New System.Windows.Forms.TextBox()
        Me.JUMLAHESKELAPA = New System.Windows.Forms.TextBox()
        Me.HARGAESCAMPUR = New System.Windows.Forms.TextBox()
        Me.JUMLAHESCAMPUR = New System.Windows.Forms.TextBox()
        Me.HARGAESTEHMANIS = New System.Windows.Forms.TextBox()
        Me.JUMLAHESTEHMANIS = New System.Windows.Forms.TextBox()
        Me.HARGAAQUA = New System.Windows.Forms.TextBox()
        Me.JUMLAHAQUA = New System.Windows.Forms.TextBox()
        Me.BIAYAMINUM = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.BIAYAMAKAN = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.DISKON = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PPN = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.UANGOEMBAYRAN = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TOTALBIAYA = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.RESET = New System.Windows.Forms.Button()
        Me.TTL = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.LV = New System.Windows.Forms.ListView()
        Me.HAPUS = New System.Windows.Forms.Button()
        Me.PILIH = New System.Windows.Forms.Button()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.NAMA = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.NAMA)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(-6, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(697, 125)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DAFTAR MENU MAKANAN DAN MINUMAN DI WARUNG KAMI"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(307, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "MINUMAN"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(106, 28)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(60, 13)
        Me.Label29.TabIndex = 62
        Me.Label29.Text = "MAKANAN"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(402, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 60)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = ": Rp. 1.000" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & ": Rp. 5.000" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & ": Rp. 5.000" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & ": Rp. 10.000"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(188, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 60)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = ": Rp. 8.000" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & ": Rp. 10.000" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & ": Rp. 15.000" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & ": Rp. 13.000"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(296, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 52)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "1. AQUA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2. ES TEH MANIS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3. ES CAMPUR" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "4. ES KELAPA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(96, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 52)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "1. SOTO AYAM " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2. BAKSO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3. SATE AYAM" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "4. PECEL AYAM"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(12, 132)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 22)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "PEMBAYARAN"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(8, 187)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 15)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "1. SOTO AYAM "
        '
        'JUMLAHSOTOAYAM
        '
        Me.JUMLAHSOTOAYAM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.JUMLAHSOTOAYAM.Location = New System.Drawing.Point(119, 180)
        Me.JUMLAHSOTOAYAM.Name = "JUMLAHSOTOAYAM"
        Me.JUMLAHSOTOAYAM.Size = New System.Drawing.Size(28, 20)
        Me.JUMLAHSOTOAYAM.TabIndex = 7
        Me.JUMLAHSOTOAYAM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'HARGASOTOAYAM
        '
        Me.HARGASOTOAYAM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HARGASOTOAYAM.Location = New System.Drawing.Point(154, 180)
        Me.HARGASOTOAYAM.Name = "HARGASOTOAYAM"
        Me.HARGASOTOAYAM.Size = New System.Drawing.Size(59, 20)
        Me.HARGASOTOAYAM.TabIndex = 8
        Me.HARGASOTOAYAM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'HARGABAKSO
        '
        Me.HARGABAKSO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HARGABAKSO.Location = New System.Drawing.Point(154, 206)
        Me.HARGABAKSO.Name = "HARGABAKSO"
        Me.HARGABAKSO.Size = New System.Drawing.Size(59, 20)
        Me.HARGABAKSO.TabIndex = 11
        Me.HARGABAKSO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'JUMLAHBAKSO
        '
        Me.JUMLAHBAKSO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.JUMLAHBAKSO.Location = New System.Drawing.Point(119, 206)
        Me.JUMLAHBAKSO.Name = "JUMLAHBAKSO"
        Me.JUMLAHBAKSO.Size = New System.Drawing.Size(28, 20)
        Me.JUMLAHBAKSO.TabIndex = 10
        Me.JUMLAHBAKSO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(8, 213)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 15)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "2. BAKSO"
        '
        'HARGASATEAYAM
        '
        Me.HARGASATEAYAM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HARGASATEAYAM.Location = New System.Drawing.Point(154, 232)
        Me.HARGASATEAYAM.Name = "HARGASATEAYAM"
        Me.HARGASATEAYAM.Size = New System.Drawing.Size(59, 20)
        Me.HARGASATEAYAM.TabIndex = 14
        Me.HARGASATEAYAM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'JUMLAHSATEAYAM
        '
        Me.JUMLAHSATEAYAM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.JUMLAHSATEAYAM.Location = New System.Drawing.Point(119, 232)
        Me.JUMLAHSATEAYAM.Name = "JUMLAHSATEAYAM"
        Me.JUMLAHSATEAYAM.Size = New System.Drawing.Size(28, 20)
        Me.JUMLAHSATEAYAM.TabIndex = 13
        Me.JUMLAHSATEAYAM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(8, 239)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 15)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "3. SATE AYAM"
        '
        'HARGAPECELAYAM
        '
        Me.HARGAPECELAYAM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HARGAPECELAYAM.Location = New System.Drawing.Point(154, 258)
        Me.HARGAPECELAYAM.Name = "HARGAPECELAYAM"
        Me.HARGAPECELAYAM.Size = New System.Drawing.Size(59, 20)
        Me.HARGAPECELAYAM.TabIndex = 17
        Me.HARGAPECELAYAM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'JUMLAHPECELAYAM
        '
        Me.JUMLAHPECELAYAM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.JUMLAHPECELAYAM.Location = New System.Drawing.Point(119, 258)
        Me.JUMLAHPECELAYAM.Name = "JUMLAHPECELAYAM"
        Me.JUMLAHPECELAYAM.Size = New System.Drawing.Size(28, 20)
        Me.JUMLAHPECELAYAM.TabIndex = 16
        Me.JUMLAHPECELAYAM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(8, 265)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 15)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "4. PECEL AYAM"
        '
        'HARGAESKELAPA
        '
        Me.HARGAESKELAPA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HARGAESKELAPA.Location = New System.Drawing.Point(154, 388)
        Me.HARGAESKELAPA.Name = "HARGAESKELAPA"
        Me.HARGAESKELAPA.Size = New System.Drawing.Size(59, 20)
        Me.HARGAESKELAPA.TabIndex = 29
        Me.HARGAESKELAPA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'JUMLAHESKELAPA
        '
        Me.JUMLAHESKELAPA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.JUMLAHESKELAPA.Location = New System.Drawing.Point(119, 388)
        Me.JUMLAHESKELAPA.Name = "JUMLAHESKELAPA"
        Me.JUMLAHESKELAPA.Size = New System.Drawing.Size(27, 20)
        Me.JUMLAHESKELAPA.TabIndex = 28
        Me.JUMLAHESKELAPA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'HARGAESCAMPUR
        '
        Me.HARGAESCAMPUR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HARGAESCAMPUR.Location = New System.Drawing.Point(154, 362)
        Me.HARGAESCAMPUR.Name = "HARGAESCAMPUR"
        Me.HARGAESCAMPUR.Size = New System.Drawing.Size(59, 20)
        Me.HARGAESCAMPUR.TabIndex = 26
        Me.HARGAESCAMPUR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'JUMLAHESCAMPUR
        '
        Me.JUMLAHESCAMPUR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.JUMLAHESCAMPUR.Location = New System.Drawing.Point(119, 362)
        Me.JUMLAHESCAMPUR.Name = "JUMLAHESCAMPUR"
        Me.JUMLAHESCAMPUR.Size = New System.Drawing.Size(27, 20)
        Me.JUMLAHESCAMPUR.TabIndex = 25
        Me.JUMLAHESCAMPUR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'HARGAESTEHMANIS
        '
        Me.HARGAESTEHMANIS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HARGAESTEHMANIS.Location = New System.Drawing.Point(154, 336)
        Me.HARGAESTEHMANIS.Name = "HARGAESTEHMANIS"
        Me.HARGAESTEHMANIS.Size = New System.Drawing.Size(59, 20)
        Me.HARGAESTEHMANIS.TabIndex = 23
        Me.HARGAESTEHMANIS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'JUMLAHESTEHMANIS
        '
        Me.JUMLAHESTEHMANIS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.JUMLAHESTEHMANIS.Location = New System.Drawing.Point(119, 336)
        Me.JUMLAHESTEHMANIS.Name = "JUMLAHESTEHMANIS"
        Me.JUMLAHESTEHMANIS.Size = New System.Drawing.Size(27, 20)
        Me.JUMLAHESTEHMANIS.TabIndex = 22
        Me.JUMLAHESTEHMANIS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'HARGAAQUA
        '
        Me.HARGAAQUA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HARGAAQUA.Location = New System.Drawing.Point(154, 310)
        Me.HARGAAQUA.Name = "HARGAAQUA"
        Me.HARGAAQUA.Size = New System.Drawing.Size(59, 20)
        Me.HARGAAQUA.TabIndex = 20
        Me.HARGAAQUA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'JUMLAHAQUA
        '
        Me.JUMLAHAQUA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.JUMLAHAQUA.Location = New System.Drawing.Point(119, 310)
        Me.JUMLAHAQUA.Name = "JUMLAHAQUA"
        Me.JUMLAHAQUA.Size = New System.Drawing.Size(27, 20)
        Me.JUMLAHAQUA.TabIndex = 19
        Me.JUMLAHAQUA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BIAYAMINUM
        '
        Me.BIAYAMINUM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BIAYAMINUM.Location = New System.Drawing.Point(403, 232)
        Me.BIAYAMINUM.Name = "BIAYAMINUM"
        Me.BIAYAMINUM.Size = New System.Drawing.Size(65, 20)
        Me.BIAYAMINUM.TabIndex = 35
        Me.BIAYAMINUM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label18.Location = New System.Drawing.Point(265, 235)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(80, 15)
        Me.Label18.TabIndex = 33
        Me.Label18.Text = "BIAYA MINUM"
        '
        'BIAYAMAKAN
        '
        Me.BIAYAMAKAN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BIAYAMAKAN.Location = New System.Drawing.Point(403, 206)
        Me.BIAYAMAKAN.Name = "BIAYAMAKAN"
        Me.BIAYAMAKAN.Size = New System.Drawing.Size(65, 20)
        Me.BIAYAMAKAN.TabIndex = 32
        Me.BIAYAMAKAN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label19.Location = New System.Drawing.Point(265, 209)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(81, 15)
        Me.Label19.TabIndex = 30
        Me.Label19.Text = "BIAYA MAKAN"
        '
        'DISKON
        '
        Me.DISKON.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DISKON.Location = New System.Drawing.Point(403, 310)
        Me.DISKON.Name = "DISKON"
        Me.DISKON.Size = New System.Drawing.Size(65, 20)
        Me.DISKON.TabIndex = 39
        Me.DISKON.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label16.Location = New System.Drawing.Point(264, 313)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(135, 41)
        Me.Label16.TabIndex = 38
        Me.Label16.Text = "DISKON 20%" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "setiap pembelian makanan" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "diatas Rp.50.000"
        '
        'PPN
        '
        Me.PPN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PPN.Location = New System.Drawing.Point(403, 284)
        Me.PPN.Name = "PPN"
        Me.PPN.Size = New System.Drawing.Size(65, 20)
        Me.PPN.TabIndex = 37
        Me.PPN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label17.Location = New System.Drawing.Point(265, 287)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(54, 15)
        Me.Label17.TabIndex = 36
        Me.Label17.Text = "PPN 10%"
        '
        'UANGOEMBAYRAN
        '
        Me.UANGOEMBAYRAN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UANGOEMBAYRAN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UANGOEMBAYRAN.Location = New System.Drawing.Point(403, 369)
        Me.UANGOEMBAYRAN.Name = "UANGOEMBAYRAN"
        Me.UANGOEMBAYRAN.Size = New System.Drawing.Size(65, 20)
        Me.UANGOEMBAYRAN.TabIndex = 43
        Me.UANGOEMBAYRAN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label20.Location = New System.Drawing.Point(264, 369)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(117, 15)
        Me.Label20.TabIndex = 42
        Me.Label20.Text = "UANG PEMBAYARAN"
        '
        'TOTALBIAYA
        '
        Me.TOTALBIAYA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TOTALBIAYA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TOTALBIAYA.Location = New System.Drawing.Point(403, 258)
        Me.TOTALBIAYA.Name = "TOTALBIAYA"
        Me.TOTALBIAYA.Size = New System.Drawing.Size(65, 20)
        Me.TOTALBIAYA.TabIndex = 41
        Me.TOTALBIAYA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label21.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label21.Location = New System.Drawing.Point(265, 261)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(78, 15)
        Me.Label21.TabIndex = 40
        Me.Label21.Text = "TOTAL BIAYA"
        '
        'RESET
        '
        Me.RESET.BackColor = System.Drawing.Color.White
        Me.RESET.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.RESET.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RESET.Image = Global.UJIAN_PRAKTEK_dan_UAS.My.Resources.Resources._42a
        Me.RESET.Location = New System.Drawing.Point(241, 399)
        Me.RESET.Name = "RESET"
        Me.RESET.Size = New System.Drawing.Size(79, 40)
        Me.RESET.TabIndex = 44
        Me.RESET.Text = "RESET"
        Me.RESET.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.RESET.UseVisualStyleBackColor = False
        '
        'TTL
        '
        Me.TTL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TTL.Location = New System.Drawing.Point(403, 180)
        Me.TTL.Name = "TTL"
        Me.TTL.Size = New System.Drawing.Size(65, 20)
        Me.TTL.TabIndex = 47
        Me.TTL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label22.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label22.Location = New System.Drawing.Point(264, 186)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(94, 15)
        Me.Label22.TabIndex = 46
        Me.Label22.Text = "TGL TRANSAKSI"
        '
        'LV
        '
        Me.LV.BackColor = System.Drawing.Color.White
        Me.LV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LV.GridLines = True
        Me.LV.Location = New System.Drawing.Point(11, 444)
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(525, 151)
        Me.LV.TabIndex = 48
        Me.LV.UseCompatibleStateImageBehavior = False
        '
        'HAPUS
        '
        Me.HAPUS.BackColor = System.Drawing.Color.White
        Me.HAPUS.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.HAPUS.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HAPUS.Image = Global.UJIAN_PRAKTEK_dan_UAS.My.Resources.Resources._58
        Me.HAPUS.Location = New System.Drawing.Point(326, 399)
        Me.HAPUS.Name = "HAPUS"
        Me.HAPUS.Size = New System.Drawing.Size(79, 40)
        Me.HAPUS.TabIndex = 49
        Me.HAPUS.Text = "CLEAR"
        Me.HAPUS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.HAPUS.UseVisualStyleBackColor = False
        '
        'PILIH
        '
        Me.PILIH.BackColor = System.Drawing.Color.White
        Me.PILIH.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.PILIH.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PILIH.Image = Global.UJIAN_PRAKTEK_dan_UAS.My.Resources.Resources._38
        Me.PILIH.Location = New System.Drawing.Point(411, 399)
        Me.PILIH.Name = "PILIH"
        Me.PILIH.Size = New System.Drawing.Size(87, 39)
        Me.PILIH.TabIndex = 50
        Me.PILIH.Text = "HAPUS PILIHAN"
        Me.PILIH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.PILIH.UseVisualStyleBackColor = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.White
        Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label23.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(13, 164)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(62, 15)
        Me.Label23.TabIndex = 51
        Me.Label23.Text = "MAKANAN"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label24.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label24.Location = New System.Drawing.Point(117, 164)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(31, 15)
        Me.Label24.TabIndex = 52
        Me.Label24.Text = "QTY"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label25.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label25.Location = New System.Drawing.Point(159, 164)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(47, 15)
        Me.Label25.TabIndex = 53
        Me.Label25.Text = "HARGA"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label26.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label26.Location = New System.Drawing.Point(159, 294)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(47, 15)
        Me.Label26.TabIndex = 56
        Me.Label26.Text = "HARGA"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label27.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label27.Location = New System.Drawing.Point(117, 294)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(31, 15)
        Me.Label27.TabIndex = 55
        Me.Label27.Text = "QTY"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.White
        Me.Label28.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label28.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(13, 294)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(61, 15)
        Me.Label28.TabIndex = 54
        Me.Label28.Text = "MINUMAN"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(8, 395)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 15)
        Me.Label12.TabIndex = 60
        Me.Label12.Text = "4. ES KELAPA"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(8, 369)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 15)
        Me.Label13.TabIndex = 59
        Me.Label13.Text = "3. ES CAMPUR"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(8, 343)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(97, 15)
        Me.Label14.TabIndex = 58
        Me.Label14.Text = "2. ES TEH MANIS"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(8, 317)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(51, 15)
        Me.Label15.TabIndex = 57
        Me.Label15.Text = "1. AQUA"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Image = Global.UJIAN_PRAKTEK_dan_UAS.My.Resources.Resources._57
        Me.Button1.Location = New System.Drawing.Point(490, 125)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(69, 39)
        Me.Button1.TabIndex = 61
        Me.Button1.UseVisualStyleBackColor = False
        '
        'NAMA
        '
        Me.NAMA.AutoSize = True
        Me.NAMA.Font = New System.Drawing.Font("Arial Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NAMA.Location = New System.Drawing.Point(345, 0)
        Me.NAMA.Name = "NAMA"
        Me.NAMA.Size = New System.Drawing.Size(339, 17)
        Me.NAMA.TabIndex = 63
        Me.NAMA.Text = "NAMA : FERNANDO SAPUTRA  NIM : 2021210069   "
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 250
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.UJIAN_PRAKTEK_dan_UAS.My.Resources.Resources.RUMAH_JOGLO_SOKO_30
        Me.ClientSize = New System.Drawing.Size(559, 628)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.PILIH)
        Me.Controls.Add(Me.HAPUS)
        Me.Controls.Add(Me.LV)
        Me.Controls.Add(Me.TTL)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.RESET)
        Me.Controls.Add(Me.UANGOEMBAYRAN)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.TOTALBIAYA)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.DISKON)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.PPN)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.BIAYAMINUM)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.BIAYAMAKAN)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.HARGAESKELAPA)
        Me.Controls.Add(Me.JUMLAHESKELAPA)
        Me.Controls.Add(Me.HARGAESCAMPUR)
        Me.Controls.Add(Me.JUMLAHESCAMPUR)
        Me.Controls.Add(Me.HARGAESTEHMANIS)
        Me.Controls.Add(Me.JUMLAHESTEHMANIS)
        Me.Controls.Add(Me.HARGAAQUA)
        Me.Controls.Add(Me.JUMLAHAQUA)
        Me.Controls.Add(Me.HARGAPECELAYAM)
        Me.Controls.Add(Me.JUMLAHPECELAYAM)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.HARGASATEAYAM)
        Me.Controls.Add(Me.JUMLAHSATEAYAM)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.HARGABAKSO)
        Me.Controls.Add(Me.JUMLAHBAKSO)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.HARGASOTOAYAM)
        Me.Controls.Add(Me.JUMLAHSOTOAYAM)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WARUNG MAKAN KAMI"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents JUMLAHSOTOAYAM As System.Windows.Forms.TextBox
    Friend WithEvents HARGASOTOAYAM As System.Windows.Forms.TextBox
    Friend WithEvents HARGABAKSO As System.Windows.Forms.TextBox
    Friend WithEvents JUMLAHBAKSO As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents HARGASATEAYAM As System.Windows.Forms.TextBox
    Friend WithEvents JUMLAHSATEAYAM As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents HARGAPECELAYAM As System.Windows.Forms.TextBox
    Friend WithEvents JUMLAHPECELAYAM As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents HARGAESKELAPA As System.Windows.Forms.TextBox
    Friend WithEvents JUMLAHESKELAPA As System.Windows.Forms.TextBox
    Friend WithEvents HARGAESCAMPUR As System.Windows.Forms.TextBox
    Friend WithEvents JUMLAHESCAMPUR As System.Windows.Forms.TextBox
    Friend WithEvents HARGAESTEHMANIS As System.Windows.Forms.TextBox
    Friend WithEvents JUMLAHESTEHMANIS As System.Windows.Forms.TextBox
    Friend WithEvents HARGAAQUA As System.Windows.Forms.TextBox
    Friend WithEvents JUMLAHAQUA As System.Windows.Forms.TextBox
    Friend WithEvents BIAYAMINUM As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents BIAYAMAKAN As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents DISKON As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents PPN As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents UANGOEMBAYRAN As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents TOTALBIAYA As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents RESET As System.Windows.Forms.Button
    Friend WithEvents TTL As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents LV As System.Windows.Forms.ListView
    Friend WithEvents HAPUS As System.Windows.Forms.Button
    Friend WithEvents PILIH As System.Windows.Forms.Button
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents NAMA As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
