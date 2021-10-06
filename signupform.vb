Public Class frmSignupform
    Public disName As String
    Public disAge As String
    Public disGender As String
    Public disBirthdate As String
    Public disEmail As String
    Public disPassword As String
    Public disVerCode As String
    Public disUsername As String
    Public disFav As String
    Public Favlist As String
 
    Private Sub radioMale_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioMale.CheckedChanged
        disGender = "Male"
    End Sub

    Private Sub radioFemale_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioFemale.CheckedChanged
        disGender = "Female"
    End Sub

    Private Sub cmbFavourites_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFavourites.SelectedIndexChanged
        If cmbFavourites.Text = "Foods" Then

            Dim favFoods() As String = New String() {"Siomai", "Pizza", "Sisig", "Calamares"}



            Dim foodList As String = ""
            For value = LBound(favFoods) To UBound(favFoods)
                foodList = foodList & favFoods(value) & ","

            Next
            lblFav.Text = foodList

        ElseIf cmbFavourites.Text = "Sports" Then
            Dim favSports() As String = New String() {"Basketball", "Football", "Takyan"}



            Dim sportsList As String = ""
            For value = LBound(favSports) To UBound(favSports)
                sportsList = sportsList & favSports(value) & ","

            Next
            lblFav.Text = sportsList


        ElseIf cmbFavourites.Text = "Movies" Then
            Dim favMovies() As String = New String() {"Logan", "Fifty Shades", "Barbie Series"}


            Dim movieList As String = ""
            For value = LBound(favMovies) To UBound(favMovies)
                movieList = movieList & favMovies(value) & ","

            Next
            lblFav.Text = movieList


        ElseIf cmbFavourites.Text = "Cars" Then
            Dim favCars() As String = New String() {"Lamborghini", "Ferrari", "Audi", "Bugatti"}

            Dim carList As String = ""
            For value = LBound(favCars) To UBound(favCars)
                carList = carList & favCars(value) & ","

            Next
            lblFav.Text = carList

        ElseIf cmbFavourites.Text = "Games" Then
            Dim favGames() As String = New String() {"Dota2", "Crossfire", "Y8", "Y3"}

            Dim Gamelist As String = ""
            For value = LBound(favGames) To UBound(favGames)
                Gamelist = Gamelist & favGames(value) & ","
            Next
            lblFav.Text = Gamelist


        End If
    End Sub


    
    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        disName = txtName.Text
        disAge = numUpdownage.Value
        disBirthdate = cmbMonth.Text & ". " & NumUpdowndays.Value & " ," & cmbYear.Text
        disEmail = txtEmail.Text
        disPassword = txtPassword.Text
        disVerCode = txtVerCode.Text
        disUsername = txtUsername.Text
        disFav = cmbFavourites.Text
        Favlist = lblFav.Text



        If txtVerCode.Text = "Da7p6" Then
            txtDisplay.AppendText("Hello  " + disName + "!" + vbNewLine + "You're a  " + disGender + "," + vbNewLine + disAge + " years old and your date of birth is " + disBirthdate + "." + vbNewLine + vbNewLine + "Your email address is " + disEmail + vbNewLine + vbNewLine + "Your favourite " + disFav + " are: " + Favlist + vbNewLine + vbNewLine + "Your username is " + disUsername + ".")
            txtDisplay.AppendText(vbNewLine + vbNewLine + "Welcome to the world of programming!")
            btnOK.Visible = True
            btnStart.Enabled = False

            txtName.Clear()
            txtEmail.Clear()
            txtPassword.Clear()
            txtUsername.Clear()
            cmbFavourites.Text = ""
            cmbMonth.Text = ""
            cmbYear.Text = ""
            numUpdownage.Value = 0
            NumUpdowndays.Value = 0
            lblFav.Text = ""



        Else
            MessageBox.Show(" Verification code does not match ")
            txtVerCode.Clear()


        End If
    End Sub


    Private Sub btnOk_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Dim Msgboxtest As Integer
        Msgboxtest = MsgBox("Are you sure you want to join the race?", MsgBoxStyle.YesNoCancel + MsgBoxStyle.Question, "START ENGINE")

        If Msgboxtest = 6 Then
            Mainpage.Show()
            Mainpage.lblDisplayname.Text = disName + "!"
            Me.Hide()

        ElseIf Msgboxtest = 7 Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnCAncel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCAncel.Click
        Application.Exit()

    End Sub

    Private Sub frmSignupform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class