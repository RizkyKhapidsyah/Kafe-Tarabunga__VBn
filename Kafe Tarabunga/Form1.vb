Public Class FormKafe
    'Deklarasi-deklarasi level-kelas
    Const decLAJU_PAJAK As Decimal = 0.06D      'Persen Pajak
    Const decBAGEL_PUTIH As Decimal = 12500D    'Biaya dari bagel putih
    Const decBAGEL_GANDUM As Decimal = 15000D   'Biaya dari bagel gandum
    Const decKEJU_KRIM As Decimal = 5000D       'Biaya dari topping keju krim
    Const decMENTEGA As Decimal = 2500D         'Biaya dari topping mentega
    Const decBLUEBERRY As Decimal = 7500D       'Biaya dari topping blueberry 
    Const decRASPBERRY As Decimal = 7500D       'Biaya dari topping raspberry 
    Const decPEACH As Decimal = 7500D           'Biaya dari topping peach
    Const decKOPI_BIASA As Decimal = 12500D     'Biaya dari kopi biasa
    Const decCAPPUCCINO As Decimal = 20000D     'Biaya dari cappuccino
    Const decCAFE_AU_LAIT As Decimal = 17500D   'Biaya dari Cafe au lait

    Private Sub tombolHitung_Click(sender As Object, e As EventArgs) Handles tombolHitung.Click
        'Prosedur ini menghitung biaya total dari pesanan
        Dim decSubtotal As Decimal      'Menampung biaya subtotal
        Dim decPajak As Decimal         'Menampung biaya pajak
        Dim decTotal As Decimal         'Menampung biaya total pesanan
        decSubtotal = HitungBiayaBagel() + HitungBiayaTopping() + HitungBiayaKopi()
        decPajak = HitungPajak(decSubtotal)
        decTotal = decSubtotal + decPajak
        lblSubtotal.Text = "Rp. " & decSubtotal.ToString()
        lblPajak.Text = "Rp. " & decPajak.ToString()
        lblTotal.Text = "Rp. " & decTotal.ToString()
    End Sub

    Private Sub tombolReset_Click(sender As Object, e As EventArgs) Handles tombolReset.Click
        'Prosedur ini mengatur-ulang setiap kontrol menjadi nilai defaultnya
        ResetBagel()
        ResetTopping()
        ResetKopi()
        ResetHarga()
    End Sub

    Private Sub tombolKeluar_Click(sender As Object, e As EventArgs) Handles tombolKeluar.Click
        'Menutup form
        Me.Close()
    End Sub

    Function HitungBiayaBagel() As Decimal
        'Fungsi ini menghasilkan biaya dari bagel terseleksi
        Dim decBagel As Decimal
        If radPutih.Checked = True Then
            decBagel = decBAGEL_PUTIH
        Else
            decBagel = decBAGEL_GANDUM
        End If
        Return decBagel
    End Function

    Function HitungBiayaTopping() As Decimal
        'Fungsi ini menghasilkan biaya dari topping
        Dim decBiayaTopping As Decimal = 0D
        If chkKejuKrim.Checked = True Then
            decBiayaTopping += decKEJU_KRIM
        End If
        If chkMentega.Checked = True Then
            decBiayaTopping += decMENTEGA
        End If
        If chkBlueberry.Checked = True Then
            decBiayaTopping += decBLUEBERRY
        End If
        If chkRaspberry.Checked = True Then
            decBiayaTopping += decRASPBERRY
        End If
        If chkPeach.Checked = True Then
            decBiayaTopping += decPEACH
        End If
        Return decBiayaTopping
    End Function

    Function HitungBiayaKopi() As Decimal
        'Fungsi ini menghasilkan biaya dari kopi terseleksi
        Dim decKopi As Decimal
        If radTidakKopi.Checked Then
            decKopi = 0D
        ElseIf radKopiBiasa.Checked = True Then
            decKopi = decKOPI_BIASA
        ElseIf radCappuccino.Checked = True Then
            decKopi = decCAPPUCCINO
        ElseIf radCafeAuLait.Checked = True Then
            decKopi = decCAFE_AU_LAIT
        End If
        Return decKopi
    End Function

    Function HitungPajak(ByVal decJumlah As Decimal) As Decimal
        'Fungsi ini menerima jumlah penjualan dan 
        'menghasilkan jumlah pajak
        Return decJumlah * decLAJU_PAJAK
    End Function

    Sub ResetBagel()
        'Prosedur ini mengatur-ulang seleksi bagel
        radPutih.Checked = True
    End Sub

    Sub ResetTopping()
        'Prosedur ini mengatur-ulang seleksi topping
        chkKejuKrim.Checked = False
        chkMentega.Checked = False
        chkBlueBerry.Checked = False
        chkRaspberry.Checked = False
        chkPeach.Checked = False
    End Sub

    Sub ResetKopi()
        'Prosedur ini mengatur-ulang seleksi kopi
        radKopiBiasa.Checked = True
    End Sub

    Sub ResetHarga()
        'Prosedur ini mengatur-ulang harga
        lblSubtotal.Text = String.Empty
        lblPajak.Text = String.Empty
        lblTotal.Text = String.Empty
    End Sub
End Class
