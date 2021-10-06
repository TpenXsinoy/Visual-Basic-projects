Public Class Mainpage
    

    Private Sub btnBugatti_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBugatti.Click

        MessageBox.Show("You chose a Bugatti" + vbNewLine + "Your car is waiting outside")
        BugattiChiron.Show()

    End Sub

    Private Sub btnLambo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLambo.Click
        MessageBox.Show("You chose a Lamborghini" + vbNewLine + "Your car is waiting outside")
        LamborghiniVeneno.Show()

    End Sub

    Private Sub btnFerrari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFerrari.Click
        MessageBox.Show("You chose a Ferrari" + vbNewLine + "Your car is waiting outside")
        LaFerrari.Show()

    End Sub

    Private Sub btnMclaren_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMclaren.Click
        MessageBox.Show("You chose a Mclaren" + vbNewLine + "Your car is waiting outside")
        Mclaren.Show()

    End Sub

    Private Sub btnPagani_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagani.Click
        MessageBox.Show("You chose a Pagani Huayra" + vbNewLine + "Your car is waiting outside")
        PaganiHuayra.Show()

    End Sub

    Private Sub btnChevrolet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChevrolet.Click
        MessageBox.Show("You chose a Chevrolet" + vbNewLine + "Your car is waiting outside")
        BumblebeeChevrolet.Show()

    End Sub


    Private Sub btnLeave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLeave.Click
        Application.Exit()
    End Sub

  
    Private Sub SIGINUPFORMToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SIGINUPFORMToolStripMenuItem.Click
        frmSignupform.Show()
        Me.Hide()

    End Sub

    Private Sub lyricsMenustrip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lyricsMenustrip.Click
        Lyrics.Show()
        Me.Hide()

    End Sub

    Private Sub intMenustrip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles intMenustrip.Click
        frmInteger.Show()
        Me.Hide()


    End Sub

    Private Sub minicMenustrip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles minicMenustrip.Click
        frmMinical.Show()
        Me.Hide()


    End Sub

    Private Sub calMenustrip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calMenustrip.Click
        frmCalculator.Show()
        Me.Hide()


    End Sub

End Class
