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
        positions4x4(14) = New Integer() {264, 360}
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
        positions = array
        Return array

    End Function
    Private Function MoveButton(ByVal position As Point)
        If mode = False Then
            If position.X = btNine.Location.X And (position.Y = btNine.Location.Y + 90 Or position.Y = btNine.Location.Y - 81 Or position.Y = btNine.Location.Y + 81 Or position.Y = btNine.Location.Y - 90) Then
                MsgBox("Apto para moverse")
            ElseIf position.Y = btNine.Location.Y And (position.X = btNine.Location.X + 90 Or position.X = btNine.Location.X - 81 Or position.X = btNine.Location.X + 81 Or position.X = btNine.Location.X - 90) Then
                MsgBox("Apto para moverse")
            End If
        Else
            If position.X = btSixteen.Location.X And (position.Y = btSixteen.Location.Y + 90 Or position.Y = btSixteen.Location.Y - 81 Or position.Y = btSixteen.Location.Y + 81 Or position.Y = btSixteen.Location.Y - 90) Then
                MsgBox("Apto para moverse")
            ElseIf position.Y = btSixteen.Location.Y And (position.X = btSixteen.Location.X + 90 Or position.X = btSixteen.Location.X - 81 Or position.X = btSixteen.Location.X + 81 Or position.X = btSixteen.Location.X - 90) Then
                MsgBox("Apto para moverse")
            End If

        End If
        Return True

    End Function

    Private Sub lbMode_Click(sender As Object, e As EventArgs) Handles lbMode.Click

    End Sub

    Private Sub btOne_Click(sender As Object, e As EventArgs) Handles btOne.Click
        MoveButton(btOne.Location)
    End Sub

    Private Sub btTwo_Click(sender As Object, e As EventArgs) Handles btTwo.Click
        MoveButton(btTwo.Location)
    End Sub

    Private Sub btThree_Click(sender As Object, e As EventArgs) Handles btThree.Click
        MoveButton(btThree.Location)
    End Sub

    Private Sub btFour_Click(sender As Object, e As EventArgs) Handles btFour.Click
        MoveButton(btFour.Location)
    End Sub

    Private Sub btFive_Click(sender As Object, e As EventArgs) Handles btFive.Click
        MoveButton(btFive.Location)
    End Sub

    Private Sub btSix_Click(sender As Object, e As EventArgs) Handles btSix.Click
        MoveButton(btSix.Location)
    End Sub

    Private Sub btSeven_Click(sender As Object, e As EventArgs) Handles btSeven.Click
        MoveButton(btSeven.Location)
    End Sub

    Private Sub btEight_Click(sender As Object, e As EventArgs) Handles btEight.Click
        MoveButton(btEight.Location)
    End Sub

    Private Sub btTwelve_Click(sender As Object, e As EventArgs) Handles btTwelve.Click
        MoveButton(btTwelve.Location)
    End Sub

    Private Sub btEleven_Click(sender As Object, e As EventArgs) Handles btEleven.Click
        MoveButton(btEleven.Location)
    End Sub

    Private Sub btTen_Click(sender As Object, e As EventArgs) Handles btTen.Click
        MoveButton(btTen.Location)
    End Sub

    Private Sub btNine_Click(sender As Object, e As EventArgs) Handles btNine.Click
        MoveButton(btNine.Location)
    End Sub

    Private Sub btThirteen_Click(sender As Object, e As EventArgs) Handles btThirteen.Click
        MoveButton(btThirteen.Location)
    End Sub

    Private Sub btFourteen_Click(sender As Object, e As EventArgs) Handles btFourteen.Click
        MoveButton(btFourteen.Location)
    End Sub

    Private Sub btFiveteen_Click(sender As Object, e As EventArgs) Handles btFiveteen.Click
        MoveButton(btFiveteen.Location)
    End Sub

    Private Sub btSixteen_Click(sender As Object, e As EventArgs) Handles btSixteen.Click
        MoveButton(btSixteen.Location)
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