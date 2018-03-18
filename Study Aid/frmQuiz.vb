''' <summary>
''' The form that hosts the quiz.
''' </summary>
Public Class frmQuiz

    Public curQuestion As Question
    Private sts As Status = Status.Prompt

    ''' <summary>
    ''' An enumerated type that tracks what state the form is currently in.
    ''' </summary>
    Private Enum Status
        Prompt 'A question is being asked.
        Answer 'An answer is being shown.
        Over 'The quiz has finished.
    End Enum

    Private Sub frmQuiz_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Main()

    End Sub

    ''' <summary>
    ''' This sub determines which actions to take with each form status.
    ''' </summary>
    Private Sub Main()

        If sts = Status.Prompt Then
            'Get new question. Discard old question.
            curQuestion = RandFromList(questions)

            'Update lblRemaining.
            lblRemaining.Text = "Questions Remaining: " & CStr(questions.Count + If(Not curQuestion Is Nothing, 1, 0))

        End If

        'If no current question exists, the quiz is over.
        If curQuestion Is Nothing Then
            sts = Status.Over
          
        End If

        UpdateText()
        UpdateButtons()
        ButtonFocus()

    End Sub

    ''' <summary>
    ''' Place a prompt or answer into txtMain based on the form's current status. Update lblRemaining.
    ''' </summary>
    Private Sub UpdateText()
        Select Case sts
            Case Is = Status.Prompt
                txtMain.Text = "Question:" & vbNewLine & curQuestion.Prompt

            Case Is = Status.Answer
                txtMain.Text = "Answer:" & vbNewLine & curQuestion.Answer & vbDubNL & "Did you answer correctly?"

            Case Is = Status.Over
                txtMain.Text = "Congratulations! The quiz is now over." & vbDubNL &
                    "Would you like to take another quiz? Any questions you answered incorrectly have been tracked and can be asked again."

        End Select

    End Sub

    ''' <summary>
    ''' Enable or disable the form's buttons based on the current state.
    ''' </summary>
    Private Sub UpdateButtons()
        btnYes.Enabled = sts = Status.Answer OrElse sts = Status.Over
        btnNo.Enabled = btnYes.Enabled
        btnCont.Enabled = sts = Status.Prompt

    End Sub

    ''' <summary>
    ''' Set focus to btnYes or btnCont.
    ''' </summary>
    Private Sub ButtonFocus()
        If btnYes.Enabled Then
            btnYes.Focus()
        ElseIf btnCont.Enabled Then
            btnCont.Focus()
        End If

    End Sub

    Private Sub btnCont_Click(sender As System.Object, e As System.EventArgs) Handles btnCont.Click
        sts = Status.Answer
        Main()

    End Sub

    Private Sub btnYesNo_Click(sender As System.Object, e As System.EventArgs) Handles btnYes.Click, btnNo.Click
        If sts = Status.Answer Then
            'Place current Question into the xQuestions list if it has not been answered incorrectly previously
            'and it was answered incorrectly this time.
            If sender Is btnNo Then
                If Not curQuestion.Wrong Then
                    curQuestion.SetWrong()
                    xQuestions.Add(curQuestion)
                End If

                questions.Add(curQuestion)

            End If

            sts = Status.Prompt
            Main()

        ElseIf sts = Status.Over Then
            If sender Is btnYes Then
                frmMenu.Show()
            End If

            Me.Close()

        End If

    End Sub
End Class