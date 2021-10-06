Public Class frmInteger
    Dim x As Integer
    

   
    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        x = Val(txtDisplay.Text)
        If x > 0 Then
            MessageBox.Show("Positive")
        ElseIf x = 0 Then
            MessageBox.Show("Neautral")
        Else
            MessageBox.Show("Negative")

        End If
    End Sub

    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        Me.Close()
        Mainpage.Show()


    End Sub
End Class