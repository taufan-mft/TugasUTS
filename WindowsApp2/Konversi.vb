Imports MaterialSkin
Public Class Konversi
    Dim duit1 As Double
    Dim duit2 As String
    Dim duitak, idr, usd, eur, gbp As Double

    Partial Class Form1
        Inherits MaterialSkin.Controls.MaterialForm

    End Class

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE)
        idr = 1
        usd = 14093
        eur = 15976
        gbp = 18461
        kursIDR.Text = idr
        kursIDR2.Text = "1"
        kursUSD.Text = usd
        kursUSD2.Text = "14077"
        kursGBP.Text = gbp
        kursGBP2.Text = "18361"
        kursEUR.Text = eur
        kursEUR2.Text = "15876"
        tidrawal.Text = ""
        takhir.Text = ""
        tduit2.Text = ""

    End Sub

    Private Sub MaterialRadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialRadioButton8.CheckedChanged
        duit2 = "IDR"
        tduit2.Text = "IDR"
    End Sub

    Private Sub MaterialRadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialRadioButton7.CheckedChanged
        duit2 = "USD"
        tduit2.Text = "USD"
    End Sub

    Private Sub MaterialRadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialRadioButton6.CheckedChanged
        duit2 = "GBP"
        tduit2.Text = "GBP"
    End Sub

    Private Sub MaterialRadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialRadioButton5.CheckedChanged
        duit2 = "EUR"
        tduit2.Text = "EUR"
    End Sub

    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton1.Click
        duit1 = tjumlah.Text
        If duit2 = "IDR" Then
            duitak = duit1 * idr
            takhir.Text = duitak
            tidrawal.Text = duit1
        ElseIf duit2 = "USD" Then
            duitak = duit1 / usd
            takhir.Text = duitak
            tidrawal.Text = duit1
        ElseIf duit2 = "GBP" Then
            duitak = duit1 / gbp
            takhir.Text = duitak
            tidrawal.Text = duit1
        End If
    End Sub
End Class
