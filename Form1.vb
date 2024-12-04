Public Class Form1
    ' Method that specifies the layout of the datagridview as:
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' The datagridview has 4 columns
        MarkList.ColumnCount = 4
        MarkList.Columns(0).Name = "Registration Number"
        MarkList.Columns(1).Name = "Full Name"
        MarkList.Columns(2).Name = "Unit Mark"
        MarkList.Columns(3).Name = "Grade"

        ' The widths of the columns are as:
        MarkList.Columns(0).Width = 160
        MarkList.Columns(1).Width = 200
        MarkList.Columns(2).Width = 120
        MarkList.Columns(3).Width = 100

    End Sub

    ' Method that specifies what happens when the "Clear" button is clicked: it clears all the TextBoxes
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TxtReg.Clear()
        TxtName.Clear()
        TxtCAT1.Clear()
        TxtCAT2.Clear()
        TxtExam.Clear()
    End Sub

    ' Method that specifies what happens when the "CAT1" TextBox gains the keyboard's focus: a Hint shows on the "LblExamHints" Label as:
    Private Sub TxtCAT1_FocusGained(sender As Object, e As EventArgs) Handles TxtCAT1.GotFocus
        LblExamHints.Text = "Out of 20. Both CATs Make Up 40% Of The Overall Mark"
    End Sub
    ' Method that specifies what happens when the "CAT1" TextBox loses the keyboard's focus: the Hint is cleared
    Private Sub TxtCAT1_FocusLost(sender As Object, e As EventArgs) Handles TxtCAT1.LostFocus
        LblExamHints.Text = ""
    End Sub

    ' Method that specifies what happens when the "CAT2" TextBox gains the keyboard's focus: a Hint shows on the "LblExamHints" Label as:
    Private Sub TxtCAT2_FocusGained(sender As Object, e As EventArgs) Handles TxtCAT2.GotFocus
        LblExamHints.Text = "Out of 20. Both CATs Make Up 40% Of The Overall Mark"
    End Sub

    Private Sub TxtCAT2_FocusLost(sender As Object, e As EventArgs) Handles TxtCAT2.LostFocus
        ' Method that specifies what happens when the "CAT2" TextBox loses the keyboard's focus: the Hint is cleared
        LblExamHints.Text = ""
    End Sub

    ' Method that specifies what happens when the "Main Exam" TextBox gains the keyboard's focus: a Hint shows on the "LblExamHints" Label as:
    Private Sub TxtExam_FocusGained(sender As Object, e As EventArgs) Handles TxtExam.GotFocus
        LblExamHints.Text = "Out of 60. This Makes Up 60% Of The Overall Mark"
    End Sub

    ' Method that specifies what happens when the "Main Exam" TextBox loses the keyboard's focus: the Hint is cleared
    Private Sub TxtExam_FocusLost(sender As Object, e As EventArgs) Handles TxtExam.LostFocus
        LblExamHints.Text = ""
    End Sub

    ' Method that restricts the input into the "CAT1" TextBox as:
    Private Sub TxtCAT1_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TxtCAT1.KeyPress

        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> "." And e.KeyChar <> ControlChars.Back Then
            ' If clause that ensures that the program flows only when the keyboard key pressed is a digit or a period(.)

            ' Display the Error Message:
            LblErrors.Text = "Only numbers or a Period (.) are Allowed"
            ' Beep
            System.Media.SystemSounds.Beep.Play()
            ' Reject the input
            e.Handled = True

        ElseIf e.KeyChar = "." And TxtCAT1.Text.Contains(".") Then
            ' If clause that ensures that the program flows only when the keyboard key pressed is the first period, if the period key (.) is pressed

            ' Display the Error Message:
            LblErrors.Text = "Only one Period (.) is Allowed"
            ' Beep
            System.Media.SystemSounds.Beep.Play()
            ' Reject the input
            e.Handled = True

        Else
            ' If clause that ensures that the program flows only when the keyboard key pressed is represents a valid character

        End If
    End Sub

    ' Method that restricts the input into the "CAT2" TextBox as:
    Private Sub TxtCAT2_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TxtCAT2.KeyPress

        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> "." And e.KeyChar <> ControlChars.Back Then
            ' If clause that ensures that the program flows only when the keyboard key pressed is a digit or a period(.)

            ' Display the Error Message:
            LblErrors.Text = "Only numbers or a Period (.) Allowed"
            ' Beep
            System.Media.SystemSounds.Beep.Play()
            ' Reject the input
            e.Handled = True

        ElseIf e.KeyChar = "." And TxtCAT2.Text.Contains(".") Then
            ' If clause that ensures that the program flows only when the keyboard key pressed is the first period, if the period key (.) is pressed

            ' Display the Error Message:
            LblErrors.Text = "Only one Period (.) is Allowed"
            ' Beep
            System.Media.SystemSounds.Beep.Play()
            ' Reject the Input
            e.Handled = True

        Else
            ' If clause that ensures that the program flows only when the keyboard key pressed is represents a valid character
            LblErrors.Text = ""

        End If
    End Sub

    ' Method that restricts the input into the "Main Exam" TextBox as:
    Private Sub TxtExam_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TxtExam.KeyPress

        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> "." And e.KeyChar <> ControlChars.Back Then
            ' If clause that ensures that the program flows only when the keyboard key pressed is a digit or a period(.)

            ' Display the Error Message:
            LblErrors.Text = "Only numbers or a Period (.) Allowed"
            ' Beep
            System.Media.SystemSounds.Beep.Play()
            ' Reject the input
            e.Handled = True

        ElseIf e.KeyChar = "." And TxtExam.Text.Contains(".") Then
            ' If clause that ensures that the program flows only when the keyboard key pressed is the first period, if the period key (.) is pressed

            'Display the Error Message:
            LblErrors.Text = "Only one Period (.) is Allowed"
            'Beep
            System.Media.SystemSounds.Beep.Play()
            'Reject the input
            e.Handled = True

        Else
            ' If clause that ensures that the program flows only when the keyboard key pressed is represents a valid character
            LblErrors.Text = ""

        End If
    End Sub

    ' Method that computes the grade of each student then displays it, together with the student's details and total mark, in a table  
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Variables to store what is typed in

        'String variables to store the each student's details (Name and Registation Nmber)
        Dim regNum As String = TxtReg.Text
        Dim stdName As String = TxtName.Text

        'Double variables to store the each student's CAT marks and Main Exam mark
        Dim cat1 As Double = Val(TxtCAT1.Text)
        Dim cat2 As Double = Val(TxtCAT2.Text)
        Dim mainExam As Double = Val(TxtExam.Text)

        ' If clause that ensures that the program flows only when all the fields are filled
        If ((TxtReg.Text = "") = False) AndAlso ((TxtName.Text = "") = False) AndAlso
            ((TxtCAT1.Text = "") = False) AndAlso ((TxtCAT2.Text = "") = False) AndAlso
            ((TxtExam.Text = "") = False) Then

            ' If clause that ensures that the program flows only when the marks provided for each assessement (CATs and Main Exam) are each in the required range as:

            'The mark for CAT1 should be less than or equal to 20,
            'The mark for CAT2 should also be less than or equal to 20,
            'The mark for the main exam should be less than or equal to 60,
            If (cat1 <= 20) And (cat2 <= 20) And (mainExam <= 60) Then

                'The sum of the two CAT Marks is evaluated as: CAT1 + CAT2
                Dim catOverall As Double = cat1 + cat2
                ' A Double variable is declared to store the value of the overall mark (CATS + Main Exam)
                Dim finalMark As Double
                'The Overall Mark is calculated and its value assigned to the "finalmark" variable
                finalMark = catOverall + mainExam

                ' A character variable is declared to store the value of each student's grade
                Dim grade As Char

                ' The Grades are determined as:
                '0-39 = "E", 40-49 = "D", 50-59 = "C", 60-69 = "B", 70-100 = "A",

                'Consider the value stored in the "grade variable": 
                Select Case finalMark

                    ' If it is greater than or equal to 70
                    Case >= 70
                        ' Let the student's grade be "A" and assign it to the "grade" variable 
                        grade = "A"
                    ' If it is greater than or equal to 60
                    Case >= 60
                        ' Let the student's grade be "B" and assign it to the "grade" variable
                        grade = "B"
                    ' If it is greater than or equal to 50
                    Case >= 50
                        ' Let the student's grade be "C" and assign it to the "grade" variable
                        grade = "C"
                    ' If it is greater than or equal to 40
                    Case >= 40
                        ' Let the student's grade be "D" and assign it to the "grade" variable
                        grade = "D"
                        ' If it less than 40
                    Case Else
                        ' Let the student's grade be "E" and assign it to the "grade" variable
                        grade = "E"

                End Select

                ' A record is added to the datagridview (Table) containing:
                ' The Registration Number, Name, Overall Mark and Grade of the Student as:

                'A String Array named as "row" is initialised and assigned the values: Registration Number, Name, Overall Mark and Grade of the Student 
                Dim row As String() = New String() {regNum.ToString, stdName.ToString, finalMark.ToString, grade.ToString}

                ' The "row" array is added to the datagridview as a record where each value in the array is placed on its own row and column
                MarkList.Rows.Add(row)

            Else
                ' If the mark entered for either a CATs or the Main Exam is outside the required range

                'Beep
                System.Media.SystemSounds.Beep.Play()
                ' Display the Error message
                LblErrors.Text = "Invalid Marks. Please Re-enter Them"
            End If
        Else
            ' If the there is a field that has not been filled

            'Beep
            System.Media.SystemSounds.Beep.Play()
            ' Display the Error message
            LblErrors.Text = "Please Fill In All The Details"
        End If
    End Sub
End Class
