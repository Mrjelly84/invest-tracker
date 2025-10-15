Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'InvestTrackDataSet.Investments' table. You can move, or remove it, as needed.
        Me.InvestmentsTableAdapter.Fill(Me.InvestTrackDataSet.Investments)
        dtpPurchDate.Value = Today
        Investment.LoadPrices()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub TextChanged(sender As Object, e As EventArgs) Handles txtTicker.TextChanged
        Dim price As Double = Investment.GetCurrentPrice(txtTicker.Text)
        If price > 0 Then
            lblPricePerShare.Text = price.ToString("n")
        Else
            lblPricePerShare.Text = String.Empty
        End If
    End Sub

    Private Sub KeyPressForShares(sender As Object, e As KeyPressEventArgs) Handles txtShares.KeyPress
        If Not IsNumeric(e.KeyChar) And Not e.KeyChar = ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim invest As New Investment
        If coboInvestmentType.SelectedIndex = 1 Or txtShares.Text = "" Then
            MessageBox.Show("Please enter correct input")
            Exit Sub
        End If

        With invest
            .Type = CType(coboInvestmentType.SelectedIndex, Investment.InvestmentType)
            .PurchaseDate = dtpPurchDate.Value.Date
            .Ticker = txtTicker.Text
            .PricePerShare = CDbl(lblPricePerShare.Text)
            .NumOfShares = CInt(txtShares.Text)
        End With
        lblTotal.Text = invest.PurchaseAmount.ToString("c")
        Investment.Insert(invest)
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Form2.ShowDialog()
    End Sub
End Class
