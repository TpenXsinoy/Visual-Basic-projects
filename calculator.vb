Public Class frmCalculator
    Dim Firstnum As Decimal
    Dim Secondnum As Decimal
    Dim answer As Decimal
    Dim calc0perator As String
    Dim numClick As String
    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        numClick = "1"
        checkNum()
    End Sub

    Private Sub button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button2.Click
        numClick = "2"
        checkNum()
    End Sub

    Private Sub button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button3.Click
        numClick = "3"
        checkNum()
    End Sub

    Private Sub button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button4.Click
        numClick = "4"
        checkNum()
    End Sub

    Private Sub button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button5.Click
        numClick = "5"
        checkNum()
    End Sub

    Private Sub button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button6.Click
        numClick = "6"
        checkNum()
    End Sub

    Private Sub button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button7.Click
        numClick = "7"
        checkNum()
    End Sub

    Private Sub button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button8.Click
        numClick = "8"
        checkNum()
    End Sub

    Private Sub button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button9.Click
        numClick = "9"
        checkNum()
    End Sub

    Private Sub btn0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn0.Click
        If Not (txtDisplay.Text = "0") Then
            If txtDisplay.Text = "0" Then
                txtDisplay.Text = "0"
            Else
                txtDisplay.Text = txtDisplay.Text & "0"
            End If
        End If
    End Sub

    Private Sub Btnpoint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnpoint.Click
        If Not (txtDisplay.Text.Contains(".")) Then
            txtDisplay.Text = txtDisplay.Text & "."
        End If
    End Sub

    Private Sub btnEquals_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEquals.Click
        If calc0perator = "+" Then
            Secondnum = Firstnum + txtDisplay.Text
            txtDisplay.Text = Secondnum
        ElseIf calc0perator = "-" Then
            Secondnum = Firstnum - txtDisplay.Text
            txtDisplay.Text = Secondnum
        ElseIf calc0perator = "*" Then
            Secondnum = Firstnum * txtDisplay.Text
            txtDisplay.Text = Secondnum
        ElseIf calc0perator = "/" Then
            Secondnum = Firstnum / txtDisplay.Text
            txtDisplay.Text = Secondnum

        End If
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        Firstnum = txtDisplay.Text
        lblDisplay.Text = Firstnum & "+"
        txtDisplay.Text = " "
        calc0perator = "+"

    End Sub

    Private Sub btnsub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsub.Click
        Firstnum = txtDisplay.Text
        lblDisplay.Text = Firstnum & "-"
        txtDisplay.Text = " "
        calc0perator = "-"
    End Sub

    Private Sub btnmultiply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmultiply.Click
        Firstnum = txtDisplay.Text
        lblDisplay.Text = Firstnum & "*"
        txtDisplay.Text = " "
        calc0perator = "*"
    End Sub

    Private Sub btndivide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndivide.Click
        Firstnum = txtDisplay.Text
        lblDisplay.Text = Firstnum & "/"
        txtDisplay.Text = " "
        calc0perator = "/"
    End Sub

    Private Sub btnC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnC.Click
        txtDisplay.Clear()
        lblDisplay.Text = txtDisplay.Text

    End Sub

    Private Sub btnCE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCE.Click
        txtDisplay.Clear()
    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        Try
            If txtDisplay.Text = " " Then
                lblDisplay.Text = lblDisplay.Text.Substring("", lblDisplay.Text.Length - 1)
            Else
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1)
            End If
        Catch
            txtDisplay.Text = "0"
        End Try
    End Sub

  
    Public Function checkNum() As String
        If txtDisplay.Text = "0" Then
            txtDisplay.Text = numClick
        Else
            txtDisplay.Text = txtDisplay.Text & numClick

        End If
        Return numClick
    End Function


    Private Sub lblExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblExit.Click
        Me.Close()
        Mainpage.Show()

    End Sub
End Class