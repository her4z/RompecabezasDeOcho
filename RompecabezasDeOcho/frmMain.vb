Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Populatting 4x4 position's jagged array.
        positions4x4(0) = New Integer() {107, 108}
        positions4x4(1) = New Integer() {188, 108}
        positions4x4(2) = New Integer() {269, 108}
        positions4x4(3) = New Integer() {350, 108}
        positions4x4(4) = New Integer() {107, 198}
        positions4x4(5) = New Integer() {188, 198}
        positions4x4(6) = New Integer() {269, 198}
        positions4x4(7) = New Integer() {350, 198}
        positions4x4(8) = New Integer() {107, 279}
        positions4x4(9) = New Integer() {188, 279}
        positions4x4(10) = New Integer() {269, 279}
        positions4x4(11) = New Integer() {350, 279}
        positions4x4(12) = New Integer() {107, 360}
        positions4x4(13) = New Integer() {188, 360}
        positions4x4(14) = New Integer() {269, 360}
        positions4x4(15) = New Integer() {350, 360}

        ' Populating 3x3 position's jagged array.
        positions3x3(0) = New Integer() {147, 108}
        positions3x3(1) = New Integer() {228, 108}
        positions3x3(2) = New Integer() {309, 108}
        positions3x3(3) = New Integer() {147, 198}
        positions3x3(4) = New Integer() {228, 198}
        positions3x3(5) = New Integer() {309, 198}
        positions3x3(6) = New Integer() {147, 279}
        positions3x3(7) = New Integer() {228, 279}
        positions3x3(8) = New Integer() {309, 279}
    End Sub
    Private Sub frmMain_Activated(sender As Object, e As EventArgs) Handles MyBase.Load
        If (mode = False) Then
            lbMode.Text = "Rompecabezas 3x3"
            btNine.Text = ""
            ' 4x4 Buttons get hide.
            btTen.Hide()
            btEleven.Hide()
            btTwelve.Hide()
            btThirteen.Hide()
            btFourteen.Hide()
            btFiveteen.Hide()
            btSixteen.Hide()
            PositionsRandomizer(positions3x3)
        Else
            lbMode.Text = "Rompecabezas 4x4"
            btSixteen.Text = ""
            PositionsRandomizer(positions4x4)


        End If

    End Sub
    Private Function PositionsRandomizer(ByVal array As Integer()())
        Dim rnd As New Random
        Dim arrayCount As Integer = array.Length - 1
        For i As Integer = 0 To arrayCount
            Dim newIndex As Integer = rnd.Next(i, arrayCount + 1)
            Dim auxItem As Integer() = array(i)
            array(i) = array(newIndex)
            array(newIndex) = auxItem
        Next i
        If mode = False Then
            btOne.Location = New Point(array(0)(0), array(0)(1))
            btTwo.Location = New Point(array(1)(0), array(1)(1))
            btThree.Location = New Point(array(2)(0), array(2)(1))
            btFour.Location = New Point(array(3)(0), array(3)(1))
            btFive.Location = New Point(array(4)(0), array(4)(1))
            btSix.Location = New Point(array(5)(0), array(5)(1))
            btSeven.Location = New Point(array(6)(0), array(6)(1))
            btEight.Location = New Point(array(7)(0), array(7)(1))
            btNine.Location = New Point(array(8)(0), array(8)(1))
        Else
            btOne.Location = New Point(array(0)(0), array(0)(1))
            btTwo.Location = New Point(array(1)(0), array(1)(1))
            btThree.Location = New Point(array(2)(0), array(2)(1))
            btFour.Location = New Point(array(3)(0), array(3)(1))
            btFive.Location = New Point(array(4)(0), array(4)(1))
            btSix.Location = New Point(array(5)(0), array(5)(1))
            btSeven.Location = New Point(array(6)(0), array(6)(1))
            btEight.Location = New Point(array(7)(0), array(7)(1))
            btNine.Location = New Point(array(8)(0), array(8)(1))
            btTen.Location = New Point(array(9)(0), array(9)(1))
            btEleven.Location = New Point(array(10)(0), array(10)(1))
            btTwelve.Location = New Point(array(11)(0), array(11)(1))
            btThirteen.Location = New Point(array(12)(0), array(12)(1))
            btFourteen.Location = New Point(array(13)(0), array(13)(1))
            btFiveteen.Location = New Point(array(14)(0), array(14)(1))
            btSixteen.Location = New Point(array(15)(0), array(15)(1))

        End If
        Return array

    End Function
    Private Function MoveButton(ByVal position As Point)
        If mode = False Then
            If position.X = btNine.Location.X And (position.Y = btNine.Location.Y + 90 Or position.Y = btNine.Location.Y - 81 Or position.Y = btNine.Location.Y + 81 Or position.Y = btNine.Location.Y - 90) Then
                Return True
            ElseIf position.Y = btNine.Location.Y And (position.X = btNine.Location.X + 90 Or position.X = btNine.Location.X - 81 Or position.X = btNine.Location.X + 81 Or position.X = btNine.Location.X - 90) Then
                Return True
            End If
        Else
            If position.X = btSixteen.Location.X And (position.Y = btSixteen.Location.Y + 90 Or position.Y = btSixteen.Location.Y - 81 Or position.Y = btSixteen.Location.Y + 81 Or position.Y = btSixteen.Location.Y - 90) Then
                Return True
            ElseIf position.Y = btSixteen.Location.Y And (position.X = btSixteen.Location.X + 90 Or position.X = btSixteen.Location.X - 81 Or position.X = btSixteen.Location.X + 81 Or position.X = btSixteen.Location.X - 90) Then
                Return True
            End If

        End If
        Return False

    End Function
    Private Function Won()
        ' This could be made prettier with a Dictionary or iterating positions list and comparing each list value with each controller Location value.
        If mode = False Then
            If btOne.Location.X = positions3x3(0)(0) AndAlso
                btOne.Location.Y = positions3x3(0)(1) AndAlso
                btTwo.Location.X = positions3x3(1)(0) AndAlso
                btTwo.Location.Y = positions3x3(1)(1) AndAlso
                btThree.Location.X = positions3x3(2)(0) AndAlso
                btThree.Location.Y = positions3x3(2)(1) AndAlso
                btFour.Location.X = positions3x3(3)(0) AndAlso
                btFour.Location.Y = positions3x3(3)(1) AndAlso
                btFive.Location.X = positions3x3(4)(0) AndAlso
                btFive.Location.Y = positions3x3(4)(1) AndAlso
                btSix.Location.X = positions3x3(5)(0) AndAlso
                btSix.Location.Y = positions3x3(5)(1) AndAlso
                btSeven.Location.X = positions3x3(6)(0) AndAlso
                btSeven.Location.Y = positions3x3(6)(1) AndAlso
                btEight.Location.X = positions3x3(7)(0) AndAlso
                btEight.Location.Y = positions3x3(7)(1) AndAlso
                btNine.Location.X = positions3x3(8)(0) AndAlso
                btNine.Location.Y = positions3x3(8)(1) Then
                MsgBox("Ganaste!")
                PositionsRandomizer(positions3x3)
                Return True
            End If
        Else
            If btOne.Location.X = positions4x4(0)(0) AndAlso
                btOne.Location.Y = positions4x4(0)(1) AndAlso
                btTwo.Location.X = positions4x4(1)(0) AndAlso
                btTwo.Location.Y = positions4x4(1)(1) AndAlso
                btThree.Location.X = positions4x4(2)(0) AndAlso
                btThree.Location.Y = positions4x4(2)(1) AndAlso
                btFour.Location.X = positions4x4(3)(0) AndAlso
                btFour.Location.Y = positions4x4(3)(1) AndAlso
                btFive.Location.X = positions4x4(4)(0) AndAlso
                btFive.Location.Y = positions4x4(4)(1) AndAlso
                btSix.Location.X = positions4x4(5)(0) AndAlso
                btSix.Location.Y = positions4x4(5)(1) AndAlso
                btSeven.Location.X = positions4x4(6)(0) AndAlso
                btSeven.Location.Y = positions4x4(6)(1) AndAlso
                btEight.Location.X = positions4x4(7)(0) AndAlso
                btEight.Location.Y = positions4x4(7)(1) AndAlso
                btNine.Location.X = positions4x4(8)(0) AndAlso
                btNine.Location.Y = positions4x4(8)(1) AndAlso
                btTen.Location.X = positions4x4(9)(0) AndAlso
                btTen.Location.Y = positions4x4(9)(1) AndAlso
                btEleven.Location.X = positions4x4(10)(0) AndAlso
                btEleven.Location.Y = positions4x4(10)(1) AndAlso
                btTwelve.Location.X = positions4x4(11)(0) AndAlso
                btTwelve.Location.Y = positions4x4(11)(1) AndAlso
                btThirteen.Location.X = positions4x4(12)(0) AndAlso
                btThirteen.Location.Y = positions4x4(12)(1) AndAlso
                btFourteen.Location.X = positions4x4(13)(0) AndAlso
                btFourteen.Location.Y = positions4x4(13)(1) AndAlso
                btFiveteen.Location.X = positions4x4(14)(0) AndAlso
                btFiveteen.Location.Y = positions4x4(14)(1) AndAlso
                btSixteen.Location.X = positions4x4(15)(0) AndAlso
                btSixteen.Location.Y = positions4x4(15)(1) Then
                MsgBox("Ganaste!")
                PositionsRandomizer(positions4x4)
                Return True
            End If
        End If
        Return False
    End Function

    Private Sub lbMode_Click(sender As Object, e As EventArgs) Handles lbMode.Click

    End Sub

    Private Sub btOne_Click(sender As Object, e As EventArgs) Handles btOne.Click
        If MoveButton(btOne.Location) = True Then
            Dim auxPos As Point = btOne.Location
            If mode = False Then
                btOne.Location = btNine.Location
                btNine.Location = auxPos
            Else
                btOne.Location = btSixteen.Location
                btSixteen.Location = auxPos
            End If
            Won()
        End If
    End Sub

    Private Sub btTwo_Click(sender As Object, e As EventArgs) Handles btTwo.Click
        If MoveButton(btTwo.Location) = True Then
            Dim auxPos As Point = btTwo.Location
            If mode = False Then
                btTwo.Location = btNine.Location
                btNine.Location = auxPos
            Else
                btTwo.Location = btSixteen.Location
                btSixteen.Location = auxPos
            End If
            Won()
        End If
    End Sub

    Private Sub btThree_Click(sender As Object, e As EventArgs) Handles btThree.Click
        If MoveButton(btThree.Location) = True Then
            Dim auxPos As Point = btThree.Location
            If mode = False Then
                btThree.Location = btNine.Location
                btNine.Location = auxPos
            Else
                btThree.Location = btSixteen.Location
                btSixteen.Location = auxPos
            End If
            Won()
        End If
    End Sub

    Private Sub btFour_Click(sender As Object, e As EventArgs) Handles btFour.Click
        If MoveButton(btFour.Location) = True Then
            Dim auxPos As Point = btFour.Location
            If mode = False Then
                btFour.Location = btNine.Location
                btNine.Location = auxPos
            Else
                btFour.Location = btSixteen.Location
                btSixteen.Location = auxPos
            End If
            Won()
        End If
    End Sub

    Private Sub btFive_Click(sender As Object, e As EventArgs) Handles btFive.Click
        If MoveButton(btFive.Location) = True Then
            Dim auxPos As Point = btFive.Location
            If mode = False Then
                btFive.Location = btNine.Location
                btNine.Location = auxPos
            Else
                btFive.Location = btSixteen.Location
                btSixteen.Location = auxPos
            End If
            Won()
        End If
    End Sub

    Private Sub btSix_Click(sender As Object, e As EventArgs) Handles btSix.Click
        If MoveButton(btSix.Location) = True Then
            Dim auxPos As Point = btSix.Location
            If mode = False Then
                btSix.Location = btNine.Location
                btNine.Location = auxPos
            Else
                btSix.Location = btSixteen.Location
                btSixteen.Location = auxPos
            End If
            Won()
        End If
    End Sub

    Private Sub btSeven_Click(sender As Object, e As EventArgs) Handles btSeven.Click
        If MoveButton(btSeven.Location) = True Then
            Dim auxPos As Point = btSeven.Location
            If mode = False Then
                btSeven.Location = btNine.Location
                btNine.Location = auxPos
            Else
                btSeven.Location = btSixteen.Location
                btSixteen.Location = auxPos
            End If
            Won()
        End If
    End Sub

    Private Sub btEight_Click(sender As Object, e As EventArgs) Handles btEight.Click
        If MoveButton(btEight.Location) = True Then
            Dim auxPos As Point = btEight.Location
            If mode = False Then
                btEight.Location = btNine.Location
                btNine.Location = auxPos
            Else
                btEight.Location = btSixteen.Location
                btSixteen.Location = auxPos
            End If
            Won()
        End If
    End Sub

    Private Sub btTwelve_Click(sender As Object, e As EventArgs) Handles btTwelve.Click
        If MoveButton(btTwelve.Location) = True Then
            Dim auxPos As Point = btTwelve.Location
            If mode = False Then
                btTwelve.Location = btNine.Location
                btNine.Location = auxPos
            Else
                btTwelve.Location = btSixteen.Location
                btSixteen.Location = auxPos
            End If
        End If
    End Sub

    Private Sub btEleven_Click(sender As Object, e As EventArgs) Handles btEleven.Click
        If MoveButton(btEleven.Location) = True Then
            Dim auxPos As Point = btEleven.Location
            If mode = False Then
                btEleven.Location = btNine.Location
                btNine.Location = auxPos
            Else
                btEleven.Location = btSixteen.Location
                btSixteen.Location = auxPos
            End If
            Won()
        End If
    End Sub

    Private Sub btTen_Click(sender As Object, e As EventArgs) Handles btTen.Click
        If MoveButton(btTen.Location) = True Then
            Dim auxPos As Point = btTen.Location
            If mode = False Then
                btTen.Location = btNine.Location
                btNine.Location = auxPos
            Else
                btTen.Location = btSixteen.Location
                btSixteen.Location = auxPos
            End If
            Won()
        End If
    End Sub

    Private Sub btNine_Click(sender As Object, e As EventArgs) Handles btNine.Click
        If MoveButton(btNine.Location) = True Then
            Dim auxPos As Point = btNine.Location
            If mode = False Then
                btNine.Location = btNine.Location
                btNine.Location = auxPos
            Else
                btNine.Location = btSixteen.Location
                btSixteen.Location = auxPos
            End If
            Won()
        End If
    End Sub

    Private Sub btThirteen_Click(sender As Object, e As EventArgs) Handles btThirteen.Click
        If MoveButton(btThirteen.Location) = True Then
            Dim auxPos As Point = btThirteen.Location
            If mode = False Then
                btThirteen.Location = btNine.Location
                btNine.Location = auxPos
            Else
                btThirteen.Location = btSixteen.Location
                btSixteen.Location = auxPos
            End If
            Won()
        End If
    End Sub

    Private Sub btFourteen_Click(sender As Object, e As EventArgs) Handles btFourteen.Click
        If MoveButton(btFourteen.Location) = True Then
            Dim auxPos As Point = btFourteen.Location
            If mode = False Then
                btFourteen.Location = btNine.Location
                btNine.Location = auxPos
            Else
                btFourteen.Location = btSixteen.Location
                btSixteen.Location = auxPos
            End If
            Won()
        End If
    End Sub

    Private Sub btFiveteen_Click(sender As Object, e As EventArgs) Handles btFiveteen.Click
        If MoveButton(btFiveteen.Location) = True Then
            Dim auxPos As Point = btFiveteen.Location
            If mode = False Then
                btFiveteen.Location = btNine.Location
                btNine.Location = auxPos
            Else
                btFiveteen.Location = btSixteen.Location
                btSixteen.Location = auxPos
            End If
            Won()
        End If
    End Sub

    Private Sub btSixteen_Click(sender As Object, e As EventArgs) Handles btSixteen.Click

    End Sub

    Private Sub btBackToMenu_Click(sender As Object, e As EventArgs) Handles btBackToMenu.Click
        frmMenu.Show()
        Me.Close()
    End Sub

    Private Sub btReset_Click(sender As Object, e As EventArgs) Handles btReset.Click
        If (mode = False) Then
            PositionsRandomizer(positions3x3)
        Else
            PositionsRandomizer(positions4x4)
        End If
    End Sub

End Class