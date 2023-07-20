Imports System.Windows
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Xml

Public Class Form1



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Dim bugun As String = "https://www.tcmb.gov.tr/kurlar/today.xml"
        Dim xmloku As New XmlDocument()
        xmloku.Load(bugun)

        Dim USDalis As String = xmloku.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml
        txtdlr_alis.Text = Replace(USDalis, ".", ",")


        Dim USDSatis As String = xmloku.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml
        txtdlr_satis.Text = Replace(USDSatis, ".", ",")


        Dim EurAlis As String = xmloku.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml
        txteuro_alis.Text = Replace(EurAlis, ".", ",")

        Dim EURSATİS As String = xmloku.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml
        txteuro_satis.Text = Replace(EURSATİS, ".", ",")

        Dim sterlinalis As String = xmloku.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/BanknoteSelling").InnerXml
        txt_sterlinalis.Text = Replace(sterlinalis, ".", ",")

        Dim sterlinsatis As String = xmloku.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/BanknoteBuying").InnerXml
        txtsterlin_satis.Text = Replace(sterlinsatis, ".", ",")

        Dim dinaralis As String = xmloku.SelectSingleNode("Tarih_Date/Currency[@Kod='KWD']/BanknoteSelling").InnerXml
        txt_dinaralis.Text = Replace(dinaralis, ".", ",")

        Dim dinarsatis As String = xmloku.SelectSingleNode("Tarih_Date/Currency[@Kod='KWD']/BanknoteBuying").InnerXml
        txt_dinarsatis.Text = Replace(dinarsatis, ".", ",")


        Dim yennalis As String = xmloku.SelectSingleNode("Tarih_Date/Currency[@Kod='JPY']/BanknoteSelling").InnerXml
        txt_yenalis.Text = Replace(yennalis, ".", ",")

        Dim LevaSatis As String = xmloku.SelectSingleNode("Tarih_Date/Currency[@Kod='JPY']/BanknoteBuying").InnerXml
        txt_yensatis.Text = Replace(LevaSatis, ".", ",")

        Dim frangalis As String = xmloku.SelectSingleNode("Tarih_Date/Currency[@Kod='CHF']/BanknoteSelling").InnerXml
        txtfrang_alis.Text = Replace(frangalis, ".", ",")

        Dim frangsatis As String = xmloku.SelectSingleNode("Tarih_Date/Currency[@Kod='CHF']/BanknoteBuying").InnerXml
        txt_frangsatis.Text = Replace(frangsatis, ".", ",")

        Dim suudialis As String = xmloku.SelectSingleNode("Tarih_Date/Currency[@Kod='SAR']/BanknoteSelling").InnerXml
        txt_suudialis.Text = Replace(suudialis, ".", ",")

        Dim suudisatis As String = xmloku.SelectSingleNode("Tarih_Date/Currency[@Kod='SAR']/BanknoteBuying").InnerXml
        txt_suudisatis.Text = Replace(suudisatis, ".", ",")

        Dim kanadaalis As String = xmloku.SelectSingleNode("Tarih_Date/Currency[@Kod='CAD']/BanknoteBuying").InnerXml
        txt_kanadaalis.Text = Replace(kanadaalis, ".", ",")

        Dim kanadasatis As String = xmloku.SelectSingleNode("Tarih_Date/Currency[@Kod='CAD']/BanknoteBuying").InnerXml
        txt_kanadasatis.Text = Replace(kanadasatis, ".", ",")


    End Sub

    Dim kur, kur1, miktar, tutar As Double
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            kur = txtdlr_satis.Text
        ElseIf ComboBox1.SelectedIndex = 1 Then
            kur = txteuro_satis.Text
        ElseIf ComboBox1.SelectedIndex = 2 Then
            kur = txtsterlin_satis.Text
        ElseIf ComboBox1.SelectedIndex = 3 Then
            kur = txt_dinarsatis.Text
        ElseIf ComboBox1.SelectedIndex = 4 Then
            kur = txt_yensatis.Text
        ElseIf ComboBox1.SelectedIndex = 5 Then
            kur = txt_frangsatis.Text
        ElseIf ComboBox1.SelectedIndex = 6 Then
            kur = txt_suudisatis.Text
        ElseIf ComboBox1.SelectedIndex = 7 Then
            kur = txt_kanadasatis.Text
        End If


        If ComboBox1.SelectedIndex = 0 Then
            kur1 = txtdlr_alis.Text
        ElseIf ComboBox1.SelectedIndex = 1 Then
            kur1 = txteuro_alis.Text
        ElseIf ComboBox1.SelectedIndex = 2 Then
            kur1 = txt_sterlinalis.Text
        ElseIf ComboBox1.SelectedIndex = 3 Then
            kur1 = txt_dinaralis.Text
        ElseIf ComboBox1.SelectedIndex = 4 Then
            kur1 = txt_yenalis.Text
        ElseIf ComboBox1.SelectedIndex = 5 Then
            kur1 = txtfrang_alis.Text
        ElseIf ComboBox1.SelectedIndex = 6 Then
            kur1 = txt_suudialis.Text
        ElseIf ComboBox1.SelectedIndex = 7 Then
            kur1 = txt_kanadaalis.Text
        End If



    End Sub







    Private Sub txtmiktar_TextChanged(sender As Object, e As EventArgs) Handles txtmiktar.TextChanged

        If String.IsNullOrEmpty(txtmiktar.Text) Then
            txtalis.Text = 0
            txtsatis.Text = 0
            Return

        End If


        miktar = Convert.ToDouble(txtmiktar.Text)
        tutar = miktar * kur1
        txtalis.Text = tutar.ToString()


        miktar = Convert.ToDouble(txtmiktar.Text)
        tutar = Convert.ToDouble(miktar * kur)
        txtsatis.Text = tutar.ToString()


    End Sub

    Private Sub txtmiktar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtmiktar.KeyPress
        e.Handled = Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar)
    End Sub
End Class
