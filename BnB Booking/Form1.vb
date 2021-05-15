Public Class Form1
    Private Sub FontColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontColorToolStripMenuItem.Click
        Me.Dispose()
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rdDouble.Checked = True
        rdSingle.Checked = False
        rdSuite.Checked = False
        chkBed.Checked = False

        txtTotexcVat.ReadOnly = True
        txtVat.ReadOnly = True
        txtTotDue.ReadOnly = True

    End Sub



    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim name, surname, cell As String
        Dim totalBefore, vat, totalAfter, price, extra As Double
        Dim days As Integer

        name = txtName.Text
        surname = txtSurname.Text
        cell = mskCell.Text



        If txtName.Text.Trim <> "" Then
            name = txtName.Text.Trim.ToUpper
            For i As Integer = 0 To name.Length - 1
                Select Case name.Substring(0, 1)
                    Case "A" To "Z"
                    Case Else

                        MsgBox("Your name must only consist of alphabets")
                        Exit Sub
                End Select


            Next
        Else
            MsgBox("You have not input your name")
            Exit Sub
        End If

        If txtSurname.Text.Trim <> "" Then
            surname = txtSurname.Text.Trim.ToUpper
            For i As Integer = 0 To surname.Length - 1
                Select Case surname.Substring(0, 1)
                    Case "A" To "Z"
                    Case Else

                        MsgBox("Your surname must only consist of alphabets")
                        Exit Sub
                End Select


            Next
        Else
            MsgBox("You have not input your surname")
            Exit Sub
        End If


        If IsNumeric(txtDays.Text) = False Then
            MsgBox("Number of days must be numeric")
            Exit Sub
        End If

        days = txtDays.Text

        If rdSingle.Checked = True Then
            price = 500
        End If

        If rdDouble.Checked = True Then
            price = 800
        End If

        If rdSuite.Checked = True Then
            price = 1000
        End If
        If chkBed.Checked = True Then
            extra = 250
        End If

        totalBefore = (price * days) + extra
        vat = totalBefore * 0.15
        totalAfter = vat + totalBefore

        txtTotexcVat.Text = CStr("R" & totalBefore)
        txtVat.Text = CStr("R" & vat)
        txtTotDue.Text = CStr("R" & totalAfter)

        txtTotDue.ReadOnly = True
        txtTotexcVat.ReadOnly = True
        txtVat.ReadOnly = True
    End Sub

    Private Sub mnuFileColorBackBlack_Click(sender As Object, e As EventArgs) Handles mnuFileColorBackBlack.Click
        mnuFileColorBackRed.Checked = False
        mnuFileColorBackBlue.Checked = False
        mnuFileColorBackWhite.Checked = False
        grpBooking.BackColor = Color.Black
        grpBedroomType.BackColor = Color.Black
    End Sub

    Private Sub mnuFileColorBackRed_Click(sender As Object, e As EventArgs) Handles mnuFileColorBackRed.Click
        grpBooking.BackColor = Color.Red
        grpBedroomType.BackColor = Color.Red
        mnuFileColorBackBlue.Checked = False
        mnuFileColorBackWhite.Checked = False
        mnuFileColorBackBlack.Checked = False
    End Sub

    Private Sub mnuFileColorBackWhite_Click(sender As Object, e As EventArgs) Handles mnuFileColorBackWhite.Click
        mnuFileColorBackBlack.Checked = False
        mnuFileColorBackBlue.Checked = False
        mnuFileColorBackRed.Checked = False
        grpBooking.BackColor = Color.White
        grpBedroomType.BackColor = Color.White
    End Sub

    Private Sub mnuFileColorBackBlue_Click(sender As Object, e As EventArgs) Handles mnuFileColorBackBlue.Click
        mnuFileColorBackBlack.Checked = False
        grpBooking.BackColor = Color.Blue
        grpBedroomType.BackColor = Color.Blue
        mnuFileColorBackRed.Checked = False
        mnuFileColorBackWhite.Checked = False
    End Sub

    Private Sub mnuFileColorFontBlack_Click(sender As Object, e As EventArgs) Handles mnuFileColorFontBlack.Click
        grpBooking.ForeColor = Color.Black
        grpBedroomType.ForeColor = Color.Black
        mnuFileColorFontRed.Checked = False
        mnuFileColorFontWhite.Checked = False
    End Sub

    Private Sub mnuFileColorBack_Click(sender As Object, e As EventArgs) Handles mnuFileColorBack.Click

    End Sub

    Private Sub mnuFileColorFontWhite_Click(sender As Object, e As EventArgs) Handles mnuFileColorFontWhite.Click
        mnuFileColorFontBlack.Checked = False
        mnuFileColorFontRed.Checked = False
        grpBooking.ForeColor = Color.White
        grpBedroomType.ForeColor = Color.White
    End Sub

    Private Sub mnuFileColorFontRed_Click(sender As Object, e As EventArgs) Handles mnuFileColorFontRed.Click
        mnuFileColorFontBlack.Checked = False
        grpBooking.ForeColor = Color.Red
        grpBedroomType.ForeColor = Color.Red
        mnuFileColorFontWhite.Checked = False
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim msgStr As String
        msgStr = MsgBox("Are you sure you want to exit?", MsgBoxStyle.YesNo)
        If msgStr = vbYes Then
            Me.Dispose()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearInput()
    End Sub

    Sub ClearInput()
        txtName.Clear()
        txtSurname.Clear()
        mskCell.Clear()
        txtDays.Clear()
        txtTotexcVat.Clear()
        txtVat.Clear()
        txtTotDue.Clear()
        rdDouble.Checked = True
        chkBed.Checked = False

    End Sub

    Private Sub rdSuite_CheckedChanged(sender As Object, e As EventArgs) Handles rdSuite.CheckedChanged

    End Sub
End Class
