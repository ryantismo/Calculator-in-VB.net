Public Class Form1
    'Variable Declarations
    Dim stNumber1 As String
    Dim dNumber1 As Decimal
    Dim dNumber2 As Decimal
    Dim dAnswer As Decimal
    Dim cOperation As Char

    'Clear all inputs
    Private Sub btnAllClear_Click(sender As Object, e As EventArgs) Handles btnAllClear.Click
        txtbAnswer.Text = String.Empty
        dNumber1 = 0
        dNumber2 = 0
        dAnswer = 0
        cOperation = ""
    End Sub

    'Clear the last Character
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        If txtbAnswer.Text.Length > 0 Then
            txtbAnswer.Text = txtbAnswer.Text.Substring(0, txtbAnswer.Text.Length - 1)
        End If
    End Sub

    'Input Dot
    Private Sub btnDot_Click(sender As Object, e As EventArgs) Handles btnDot.Click
        stNumber1 = btnDot.Text
        If Not txtbAnswer.Text.Contains(stNumber1) Then
            txtbAnswer.Text &= stNumber1
        End If
    End Sub

    'Input One
    Private Sub btnOne_Click(sender As Object, e As EventArgs) Handles btnOne.Click
        stNumber1 = btnOne.Text
        txtbAnswer.Text &= stNumber1
    End Sub

    'Input Two
    Private Sub btnTwo_Click(sender As Object, e As EventArgs) Handles btnTwo.Click
        stNumber1 = btnTwo.Text
        txtbAnswer.Text &= stNumber1
    End Sub

    'Input Three
    Private Sub btnThree_Click(sender As Object, e As EventArgs) Handles btnThree.Click
        stNumber1 = btnThree.Text
        txtbAnswer.Text &= stNumber1
    End Sub

    'Input Four
    Private Sub btnFour_Click(sender As Object, e As EventArgs) Handles btnFour.Click
        stNumber1 = btnFour.Text
        txtbAnswer.Text &= stNumber1
    End Sub

    'Input Five
    Private Sub btnFive_Click(sender As Object, e As EventArgs) Handles btnFive.Click
        stNumber1 = btnFive.Text
        txtbAnswer.Text &= stNumber1
    End Sub

    'Input Six
    Private Sub btnSix_Click(sender As Object, e As EventArgs) Handles btnSix.Click
        stNumber1 = btnSix.Text
        txtbAnswer.Text &= stNumber1
    End Sub

    'Input Seven
    Private Sub btnSeven_Click(sender As Object, e As EventArgs) Handles btnSeven.Click
        stNumber1 = btnSeven.Text
        txtbAnswer.Text &= stNumber1
    End Sub

    'Input Eight
    Private Sub btnEight_Click(sender As Object, e As EventArgs) Handles btnEight.Click
        stNumber1 = btnEight.Text
        txtbAnswer.Text &= stNumber1
    End Sub

    'Input Nine
    Private Sub btnNine_Click(sender As Object, e As EventArgs) Handles btnNine.Click
        stNumber1 = btnNine.Text
        txtbAnswer.Text &= stNumber1
    End Sub

    'Input zero
    Private Sub btnZero_Click(sender As Object, e As EventArgs) Handles btnZero.Click
        stNumber1 = btnZero.Text
        txtbAnswer.Text &= stNumber1
    End Sub

    'Capture Multiply Operator as character
    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        If Not txtbAnswer.Text = "" Then
            cOperation = "*"
            dNumber1 = txtbAnswer.Text
            txtbAnswer.Text = String.Empty
        Else
            cOperation = ""
        End If
    End Sub

    'Capture Modulo Operator as character
    Private Sub btnModulo_Click(sender As Object, e As EventArgs) Handles btnModulo.Click
        If Not txtbAnswer.Text = "" Then
            cOperation = "%"
            dNumber1 = txtbAnswer.Text
            txtbAnswer.Text = String.Empty
        Else
            cOperation = ""
        End If
    End Sub

    'Capture Minus Operator as character
    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        If Not txtbAnswer.Text = "" Then
            cOperation = "-"
            dNumber1 = txtbAnswer.Text
            txtbAnswer.Text = String.Empty
        Else
            cOperation = ""
        End If
    End Sub

    'Capture Division Operator as character
    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        If Not txtbAnswer.Text = "" Then
            cOperation = "/"
            dNumber1 = txtbAnswer.Text
            txtbAnswer.Text = String.Empty
        Else
            cOperation = ""
        End If
    End Sub

    'Capture Addition Operator as character
    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        If Not txtbAnswer.Text = "" Then
            cOperation = "+"
            dNumber1 = txtbAnswer.Text
            txtbAnswer.Text = String.Empty
        Else
            cOperation = ""
        End If
    End Sub

    'Calculate Inputs
    Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
        If cOperation = "*" And txtbAnswer.Text = "" Then
            txtbAnswer.Text = dNumber1
        ElseIf cOperation = "-" And txtbAnswer.Text = "" Then
            txtbAnswer.Text = dNumber1
        ElseIf cOperation = "/" And txtbAnswer.Text = "" Then
            txtbAnswer.Text = dNumber1
        ElseIf cOperation = "+" And txtbAnswer.Text = "" Then
            txtbAnswer.Text = dNumber1
        ElseIf cOperation = "%" And txtbAnswer.Text = "" Then
            txtbAnswer.Text = dNumber1
        ElseIf cOperation = "*" And txtbAnswer.Text <> "" Then
            dNumber2 = txtbAnswer.Text
            dAnswer = dNumber1 * dNumber2
            txtbAnswer.Text = String.Empty
            txtbAnswer.Text = dAnswer
            dNumber1 = 1
        ElseIf cOperation = "/" And txtbAnswer.Text <> "" Then
            dNumber2 = txtbAnswer.Text
            dAnswer = dNumber1 / dNumber2
            txtbAnswer.Text = String.Empty
            txtbAnswer.Text = dAnswer
            dNumber1 = dAnswer * dAnswer
        ElseIf cOperation = "+" And txtbAnswer.Text <> "" Then
            dNumber2 = txtbAnswer.Text
            dAnswer = dNumber1 + dNumber2
            txtbAnswer.Text = String.Empty
            txtbAnswer.Text = dAnswer
            dNumber1 = 0
        ElseIf cOperation = "-" And txtbAnswer.Text <> "" Then
            dNumber2 = txtbAnswer.Text
            dAnswer = dNumber1 - dNumber2
            txtbAnswer.Text = String.Empty
            txtbAnswer.Text = dAnswer
            dNumber1 = dAnswer + dAnswer
        ElseIf cOperation = "%" And txtbAnswer.Text <> "" Then
            dNumber2 = txtbAnswer.Text
            If Not dNumber2 = 0 Then
                dAnswer = dNumber1 Mod dNumber2
                txtbAnswer.Text = String.Empty
                txtbAnswer.Text = dAnswer
                dNumber1 = dAnswer + dAnswer
            End If
        End If
    End Sub
End Class
