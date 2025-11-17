Public Class Form1
    Dim TULISAN As Integer
    Dim GERAK As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TTL.Text = Today
        TTL.Enabled = True
        LV.Columns.Add("TGL", 70, HorizontalAlignment.Center)
        LV.Columns.Add("B.MAKAN", 70, HorizontalAlignment.Center)
        LV.Columns.Add("B.MINUM", 70, HorizontalAlignment.Center)
        LV.Columns.Add("TOTAL", 70, HorizontalAlignment.Center)
        LV.Columns.Add("PPN", 70, HorizontalAlignment.Center)
        LV.Columns.Add("DISKON", 70, HorizontalAlignment.Center)
        LV.Columns.Add("PEMBAYARAN", 100, HorizontalAlignment.Center)
        GERAK = NAMA.Text
        LV.View = View.Details
        LV.GridLines = True
        LV.FullRowSelect = True
    End Sub
    Private Sub JUMLAHSOTOAYAM_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles JUMLAHSOTOAYAM.KeyDown
        If e.KeyCode = Keys.Enter Then
            HARGASOTOAYAM.Text = JUMLAHSOTOAYAM.Text * 8000
            JUMLAHBAKSO.Focus()
            BIAYAMAKAN.Text = Val(HARGASOTOAYAM.Text) + Val(HARGABAKSO.Text) + Val(HARGASATEAYAM.Text) + Val(HARGAPECELAYAM.Text)
            TOTALBIAYA.Text = Val(BIAYAMAKAN.Text) + Val(BIAYAMINUM.Text)
            PPN.Text = 0.1 * TOTALBIAYA.Text
            UANGOEMBAYRAN.Text = Val(TOTALBIAYA.Text) + Val(PPN.Text) - Val(DISKON.Text)
        End If
    End Sub
    Private Sub JUMLAHBAKSO_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles JUMLAHBAKSO.KeyDown
        If e.KeyCode = Keys.Enter Then
            HARGABAKSO.Text = JUMLAHBAKSO.Text * 10000
            JUMLAHSATEAYAM.Focus()
            BIAYAMAKAN.Text = Val(HARGASOTOAYAM.Text) + Val(HARGABAKSO.Text) + Val(HARGASATEAYAM.Text) + Val(HARGAPECELAYAM.Text)
            TOTALBIAYA.Text = Val(BIAYAMAKAN.Text) + Val(BIAYAMINUM.Text)
            PPN.Text = 0.1 * TOTALBIAYA.Text
            UANGOEMBAYRAN.Text = Val(TOTALBIAYA.Text) + Val(PPN.Text) - Val(DISKON.Text)
        End If
    End Sub
    Private Sub JUMLAHSATEAYAM_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles JUMLAHSATEAYAM.KeyDown
        If e.KeyCode = Keys.Enter Then
            HARGASATEAYAM.Text = JUMLAHSATEAYAM.Text * 15000
            JUMLAHPECELAYAM.Focus()
            BIAYAMAKAN.Text = Val(HARGASOTOAYAM.Text) + Val(HARGABAKSO.Text) + Val(HARGASATEAYAM.Text) + Val(HARGAPECELAYAM.Text)
            TOTALBIAYA.Text = Val(BIAYAMAKAN.Text) + Val(BIAYAMINUM.Text)
            PPN.Text = 0.1 * TOTALBIAYA.Text
            UANGOEMBAYRAN.Text = Val(TOTALBIAYA.Text) + Val(PPN.Text) - Val(DISKON.Text)
        End If
    End Sub
    Private Sub JUMLAHPECELAYAM_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles JUMLAHPECELAYAM.KeyDown
        If e.KeyCode = Keys.Enter Then
            HARGAPECELAYAM.Text = JUMLAHPECELAYAM.Text * 13000
            JUMLAHAQUA.Focus()
            BIAYAMAKAN.Text = Val(HARGASOTOAYAM.Text) + Val(HARGABAKSO.Text) + Val(HARGASATEAYAM.Text) + Val(HARGAPECELAYAM.Text)
            TOTALBIAYA.Text = Val(BIAYAMAKAN.Text) + Val(BIAYAMINUM.Text)
            PPN.Text = 0.1 * TOTALBIAYA.Text
            UANGOEMBAYRAN.Text = Val(TOTALBIAYA.Text) + Val(PPN.Text) - Val(DISKON.Text)
        End If
    End Sub
    Private Sub JUMLAHAQUA_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles JUMLAHAQUA.KeyDown
        If e.KeyCode = Keys.Enter Then
            HARGAAQUA.Text = JUMLAHAQUA.Text * 1000
            JUMLAHESTEHMANIS.Focus()
            BIAYAMINUM.Text = Val(HARGAAQUA.Text) + Val(HARGAESTEHMANIS.Text) + Val(HARGAESCAMPUR.Text) + Val(HARGAESKELAPA.Text)
            TOTALBIAYA.Text = Val(BIAYAMAKAN.Text) + Val(BIAYAMINUM.Text)
            PPN.Text = 0.1 * TOTALBIAYA.Text
            UANGOEMBAYRAN.Text = Val(TOTALBIAYA.Text) + Val(PPN.Text) - Val(DISKON.Text)
        End If
    End Sub
    Private Sub JUMLAHESTEHMANIS_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles JUMLAHESTEHMANIS.KeyDown
        If e.KeyCode = Keys.Enter Then
            HARGAESTEHMANIS.Text = JUMLAHESTEHMANIS.Text * 5000
            JUMLAHESCAMPUR.Focus()
            BIAYAMINUM.Text = Val(HARGAAQUA.Text) + Val(HARGAESTEHMANIS.Text) + Val(HARGAESCAMPUR.Text) + Val(HARGAESKELAPA.Text)
            TOTALBIAYA.Text = Val(BIAYAMAKAN.Text) + Val(BIAYAMINUM.Text)
            PPN.Text = 0.1 * TOTALBIAYA.Text
            UANGOEMBAYRAN.Text = Val(TOTALBIAYA.Text) + Val(PPN.Text) - Val(DISKON.Text)
        End If
    End Sub
    Private Sub JUMLAHESCAMPUR_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles JUMLAHESCAMPUR.KeyDown
        If e.KeyCode = Keys.Enter Then
            HARGAESCAMPUR.Text = JUMLAHESCAMPUR.Text * 5000
            JUMLAHESKELAPA.Focus()
            BIAYAMINUM.Text = Val(HARGAAQUA.Text) + Val(HARGAESTEHMANIS.Text) + Val(HARGAESCAMPUR.Text) + Val(HARGAESKELAPA.Text)
            TOTALBIAYA.Text = Val(BIAYAMAKAN.Text) + Val(BIAYAMINUM.Text)
            PPN.Text = 0.1 * TOTALBIAYA.Text
            UANGOEMBAYRAN.Text = Val(TOTALBIAYA.Text) + Val(PPN.Text) - Val(DISKON.Text)
        End If
    End Sub
    Private Sub JUMLAHESKELAPA_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles JUMLAHESKELAPA.KeyDown
        If e.KeyCode = Keys.Enter Then
            HARGAESKELAPA.Text = JUMLAHESKELAPA.Text * 10000
            RESET.Focus()
            BIAYAMINUM.Text = Val(HARGAAQUA.Text) + Val(HARGAESTEHMANIS.Text) + Val(HARGAESCAMPUR.Text) + Val(HARGAESKELAPA.Text)
            TOTALBIAYA.Text = Val(BIAYAMAKAN.Text) + Val(BIAYAMINUM.Text)
            PPN.Text = 0.1 * TOTALBIAYA.Text
            UANGOEMBAYRAN.Text = Val(TOTALBIAYA.Text) + Val(PPN.Text) - Val(DISKON.Text)
        End If
    End Sub
    Private Sub TOTALBIAYA_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TOTALBIAYA.TextChanged
        If BIAYAMAKAN.Text >= 50000 Then
            DISKON.Text = 0.2 * BIAYAMAKAN.Text
        End If
    End Sub
    Private Sub RESET_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RESET.Click
        Dim ITEM As New ListViewItem
        ITEM.Text = TTL.Text
        ITEM.SubItems.Add(BIAYAMAKAN.Text)
        ITEM.SubItems.Add(BIAYAMINUM.Text)
        ITEM.SubItems.Add(TOTALBIAYA.Text)
        ITEM.SubItems.Add(PPN.Text)
        ITEM.SubItems.Add(DISKON.Text)
        ITEM.SubItems.Add(UANGOEMBAYRAN.Text)
        LV.Items.Add(ITEM)
        JUMLAHSOTOAYAM.Text = ""
        HARGASOTOAYAM.Text = ""
        JUMLAHBAKSO.Text = ""
        HARGABAKSO.Text = ""
        JUMLAHSATEAYAM.Text = ""
        HARGASATEAYAM.Text = ""
        JUMLAHPECELAYAM.Text = ""
        HARGAPECELAYAM.Text = ""
        JUMLAHAQUA.Text = ""
        HARGAAQUA.Text = ""
        JUMLAHESTEHMANIS.Text = ""
        HARGAESTEHMANIS.Text = ""
        JUMLAHESCAMPUR.Text = ""
        HARGAESCAMPUR.Text = ""
        JUMLAHESKELAPA.Text = ""
        HARGAESKELAPA.Text = ""
        BIAYAMAKAN.Text = ""
        BIAYAMINUM.Text = ""
        PPN.Text = ""
        DISKON.Text = ""
        JUMLAHSOTOAYAM.Focus()
    End Sub
    Private Sub HAPUS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HAPUS.Click
        LV.Items.Clear()
    End Sub
    Private Sub PILIH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PILIH.Click
        LV.Items.Remove(LV.SelectedItems(0))
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim PESAN As String
        PESAN = MsgBox("Yakin Ingin Keluar ?", MsgBoxStyle.Question + vbYesNo, "TERIMA KASIH YA >_<")
        If PESAN = vbYes Then
            End
        End If
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        NAMA.Text = TULISAN
        GERAK = Microsoft.VisualBasic.Right(GERAK, Len(GERAK) - 1) & Microsoft.VisualBasic.Left(GERAK, 1)
        NAMA.Text = GERAK
    End Sub
End Class
