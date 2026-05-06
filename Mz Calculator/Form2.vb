Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub

    'Bar
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Visible = False
        Form1.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Visible = False
        Form3.Visible = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Visible = False
        Form4.Visible = True
    End Sub
    'Bar

    Dim Firstnum As Decimal
    Dim Secondnum As Decimal
    Dim Operations As Integer
    Dim Operator_Selector As Boolean = False
    Dim total As Decimal

    Private Sub DoAction()

    End Sub
    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.NumPad0 Then
            DoAction()
        End If
    End Sub

    Private Sub zero_Click(sender As Object, e As EventArgs) Handles zero.Click
        If Screen.Text <> "0" Then
            Screen.Text += "0"
        End If
    End Sub

    Private Sub one_Click(sender As Object, e As EventArgs) Handles one.Click
        If Screen.Text <> "0" Then
            Screen.Text += "1"
        Else
            Screen.Text = "1"
        End If
    End Sub

    Private Sub two_Click(sender As Object, e As EventArgs) Handles two.Click
        If Screen.Text <> "0" Then
            Screen.Text += "2"
        Else
            Screen.Text = "2"
        End If
    End Sub

    Private Sub three_Click(sender As Object, e As EventArgs) Handles three.Click
        If Screen.Text <> "0" Then
            Screen.Text += "3"
        Else
            Screen.Text = "3"
        End If
    End Sub

    Private Sub four_Click(sender As Object, e As EventArgs) Handles four.Click
        If Screen.Text <> "0" Then
            Screen.Text += "4"
        Else
            Screen.Text = "4"
        End If
    End Sub

    Private Sub five_Click(sender As Object, e As EventArgs) Handles five.Click
        If Screen.Text <> "0" Then
            Screen.Text += "5"
        Else
            Screen.Text = "5"
        End If
    End Sub

    Private Sub six_Click(sender As Object, e As EventArgs) Handles six.Click
        If Screen.Text <> "0" Then
            Screen.Text += "6"
        Else
            Screen.Text = "6"
        End If
    End Sub

    Private Sub seven_Click(sender As Object, e As EventArgs) Handles seven.Click
        If Screen.Text <> "0" Then
            Screen.Text += "7"
        Else
            Screen.Text = "7"
        End If
    End Sub

    Private Sub eight_Click(sender As Object, e As EventArgs) Handles eight.Click
        If Screen.Text <> "0" Then
            Screen.Text += "8"
        Else
            Screen.Text = "8"
        End If
    End Sub

    Private Sub nine_Click(sender As Object, e As EventArgs) Handles nine.Click
        If Screen.Text <> "0" Then
            Screen.Text += "9"
        Else
            Screen.Text = "9"
        End If
    End Sub

    Private Sub deci_Click(sender As Object, e As EventArgs) Handles deci.Click
        If Not (Screen.Text.Contains(".")) Then
            Screen.Text += "."
        End If
    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        Screen.Text = "0"

        addi.Enabled = True
        subst.Enabled = True
        div.Enabled = True
        sqrt.Enabled = True
        multi.Enabled = True
    End Sub

    Private Sub addi_Click(sender As Object, e As EventArgs) Handles addi.Click
        Firstnum = Screen.Text
        Screen.Text = "0"
        Operator_Selector = True
        Operations = 1 '+
    End Sub

    Private Sub subst_Click(sender As Object, e As EventArgs) Handles subst.Click
        Firstnum = Screen.Text
        Screen.Text = "0"
        Operator_Selector = True
        Operations = 2 '-
    End Sub

    Private Sub multi_Click(sender As Object, e As EventArgs) Handles multi.Click
        Firstnum = Screen.Text
        Screen.Text = "0"
        Operator_Selector = True
        Operations = 3 '*
    End Sub

    Private Sub div_Click(sender As Object, e As EventArgs) Handles div.Click
        Firstnum = Screen.Text
        Screen.Text = "0"
        Operator_Selector = True
        Operations = 4 '/
    End Sub

    Private Sub sqrt_Click(sender As Object, e As EventArgs) Handles sqrt.Click
        Firstnum = Screen.Text
        Screen.Text = Math.Sqrt(Firstnum)
        Operator_Selector = True
        Operations = 5 '√
    End Sub

    Private Sub equal_Click(sender As Object, e As EventArgs) Handles equal.Click

        addi.Enabled = True
        subst.Enabled = True
        div.Enabled = True
        sqrt.Enabled = True
        multi.Enabled = True
        Screen.MaxLength = 17

        If Operator_Selector = True Then
            Secondnum = Screen.Text

            If Operations = 1 Then
                Screen.MaxLength = 17
                total = Firstnum + Secondnum

                If total.ToString().Length > 20 Then
                    total = total.ToString().Substring(0, 18)
                End If
                Screen.Text = total

            ElseIf Operations = 2 Then
                Screen.MaxLength = 17
                total = Firstnum - Secondnum


                If total.ToString().Length > 20 Then
                    total = total.ToString().Substring(0, 18)
                End If
                Screen.Text = total


            ElseIf Operations = 3 Then
                Screen.MaxLength = 17
                total = Firstnum * Secondnum


                If total.ToString().Length > 20 Then
                    total = total.ToString().Substring(0, 18)
                End If
                Screen.Text = total


            Else

                If Secondnum = "0" Then
                    Screen.Text = "Error !!"

                    addi.Enabled = False
                    subst.Enabled = False
                    div.Enabled = False
                    sqrt.Enabled = False
                    multi.Enabled = False

                Else Operations = 4
                    Screen.MaxLength = 17
                    total = Firstnum / Secondnum


                    If total.ToString().Length > 20 Then
                        total = total.ToString().Substring(0, 18)
                    End If
                    Screen.Text = total

                End If

            End If

            Operator_Selector = False

        End If
    End Sub

End Class