''' <summary>
''' The form that hosts the quiz.
''' </summary>
Public Class frmQuiz

    Private lstQuestions As New RandList(Of Question)
    Private lstWrong As New RandList(Of Question)
    Private qstCurrent As Question
    Private stsStatus As Status = Status.Prompt

    ''' <summary>
    ''' An enumerated type that tracks what state the form is currently in.
    ''' </summary>
    Private Enum Status
        Prompt 'A question is being asked.
        Answer 'An answer is being shown.
        OverWrong 'The quiz has finished (some questions were answered wrong).
        OverNoWrong 'The quiz has finished (no questions were answered wrong).
    End Enum

    ''' <summary>
    ''' A custom constructor for frmQuiz that takes a RandList of Questions as an argument.
    ''' </summary>
    ''' <param name="lstQuestions">A RandList of Questions.</param>
    Sub New(lstQuestions As RandList(Of Question))
        'Argument is being passed in -- cannot use default constructor.

        MyBase.New()
        InitializeComponent()

        'The random element begins in the quiz portion.
        Randomize()

        Me.lstQuestions = lstQuestions

        FixButtons()

        'Get the first question (no replacement) and display the prompt.
        GetQuestion(False)
        DisplayPrompt()

    End Sub

    ''' <summary>
    ''' Gets a single Question from lstQuestions. May or may not return the previous Question to the RandList.
    ''' </summary>
    ''' <param name="replace">Whether or not the previous Question should be returned to the RandList.</param>
    Private Sub GetQuestion(replace As Boolean)

        If replace Then
            lstQuestions.Add(qstCurrent)
        End If

        'Update number of questions remaining.
        lblRemaining.Text = "Questions Remaining: " & lstQuestions.GetCount()

        qstCurrent = lstQuestions.Remove()

    End Sub

    ''' <summary>
    ''' Displays the prompt from qstCurrent.
    ''' </summary>
    Private Sub DisplayPrompt()

        stsStatus = Status.Prompt
        txtMain.Text = "Question: " & Strings.StrDup(2, vbNewLine) & qstCurrent.GetPrompt()

        FixButtons()

    End Sub

    ''' <summary>
    ''' Displays the answer from qstCurrent.
    ''' </summary>
    Private Sub DisplayAnswer()

        stsStatus = Status.Answer
        txtMain.Text = "Answer: " & Strings.StrDup(2, vbNewLine) & qstCurrent.GetAnswer() & _
            Strings.StrDup(2, vbNewLine) & "Did you answer correctly?"

        FixButtons()

    End Sub

    ''' <summary>
    ''' Displays the quiz completion message and allows the user to choose to retake the test.
    ''' </summary>
    Private Sub DisplayOver()

        txtMain.Text = "Congratulations! You have completed the quiz!"

        If lstWrong.IsEmpty() Then
            stsStatus = Status.OverNoWrong
        Else
            stsStatus = Status.OverWrong
            txtMain.Text &= Strings.StrDup(2, vbNewLine) & _
                "You answered some questions incorrectly during this quiz. " & _
                "Would you like to take another quiz containing only the ones you answered incorrectly?"
        End If

        'Update number of questions remaining.
        lblRemaining.Text = "Questions Remaining: 0"

        FixButtons()

    End Sub

    ''' <summary>
    ''' Ensures the correct buttons are being displayed for the form's current status.
    ''' </summary>
    Private Sub FixButtons()

        Select Case stsStatus
            Case Status.Prompt
                btnYes.Hide()
                btnNo.Hide()
                btnCont.Show()

            Case Status.Answer
                btnYes.Show()
                btnNo.Show()
                btnCont.Hide()

            Case Status.OverWrong
                btnYes.Show()
                btnNo.Show()
                btnCont.Hide()

            Case Status.OverNoWrong
                btnYes.Hide()
                btnNo.Hide()
                btnCont.Text = "End Quiz"
                btnCont.Show()

        End Select

    End Sub

    ''' <summary>
    ''' Display the answer if in Prompt status or end the application if in OverNoWrong status.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnCont_Click(sender As System.Object, e As System.EventArgs) Handles btnCont.Click

        'This button should only be active in the Prompt or OverNoWrong status.
        If stsStatus = Status.Prompt Then

            DisplayAnswer()

        ElseIf stsStatus = Status.OverNoWrong Then

            'End the application.
            Me.Close()

        End If

    End Sub

    ''' <summary>
    ''' Display a new Question or the over message if in Answer status or open a new quiz if in OverWrong
    ''' status.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnYes_Click(sender As System.Object, e As System.EventArgs) Handles btnYes.Click

        'This button should be active only in the Answer or OverWrong status.
        If stsStatus = Status.Answer Then

            If lstQuestions.IsEmpty() Then
                DisplayOver()
            Else
                'Get and display prompt for next question.
                GetQuestion(False)
                DisplayPrompt()
            End If

        ElseIf stsStatus = Status.OverWrong Then

            'Open a new frmQuiz whose answers consist of the incorrectly-answered questions from this quiz.
            Dim frm As New frmQuiz(lstWrong)
            frm.Show()

            'Close this frmQuiz.
            Me.Close()

        End If

    End Sub

    ''' <summary>
    ''' Display a new Question if in Answer status or close the application if in OverWrong status.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnNo_Click(sender As System.Object, e As System.EventArgs) Handles btnNo.Click

        'This button should be active only in the Answer or OverWrong status.
        If stsStatus = Status.Answer Then

            'Add a copy of qstCurrent to lstWrong if this question has never been answered incorrectly before.
            If Not qstCurrent.HasBeenWrong() Then
                lstWrong.Add(Question.Copy(qstCurrent))
            End If

            'Mark this question as having been wrong.
            qstCurrent.MarkWrong()

            'Get and display prompt for next question (replace old question).
            GetQuestion(True)
            DisplayPrompt()

        ElseIf stsStatus = Status.OverWrong Then

            'End the application
            Me.Close()

        End If

    End Sub

End Class