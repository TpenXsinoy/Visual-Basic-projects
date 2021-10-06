Public Class frmMinical
    Dim x As Decimal
    Dim y As Decimal
    Dim answer As Decimal
   


    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        x = Val(txbX.Text)
        y = Val(txbY.Text)
        answer = Val(lblAns.Text)

        lblAns.Text = x + y
    End Sub

    Private Sub btnSub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSub.Click
        x = Val(txbX.Text)
        y = Val(txbY.Text)
        answer = Val(lblAns.Text)

        lblAns.Text = x - y
    End Sub

    Private Sub btnMul_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMul.Click
        x = Val(txbX.Text)
        y = Val(txbY.Text)
        answer = Val(lblAns.Text)

        lblAns.Text = x * y
    End Sub

    Private Sub btnDiv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDiv.Click
        x = Val(txbX.Text)
        y = Val(txbY.Text)
        answer = Val(lblAns.Text)

        lblAns.Text = x / y
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
        Mainpage.Show()

    End Sub
End Class