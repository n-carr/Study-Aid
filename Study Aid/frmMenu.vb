''' <summary>
''' The first form opened in the application. Sets up the quiz.
''' </summary>
Public Class frmMenu

    Private Sub frmMenu_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Randomize()

        'Add all questions that have been answered incorrectly to the appropriate lists.
        questions.Clear()
        For Each question In xQuestions
            question.ResetWrong()
            questions.Add(question)
        Next
        xQuestions.Clear()

        'If questions is not empty, show the option to test on previous incorrect questions.
        If questions.Count > 0 Then
            chkAskWrong.Show()
            chkAskWrong.Checked = True
        Else
            chkAskWrong.Hide()
            chkAskWrong.Checked = False
        End If

    End Sub

    Private Sub btnStart_Click(sender As System.Object, e As System.EventArgs) Handles btnStart.Click
        'Get the questions to ask.
        If chkAskWrong.Checked Then
            questions = New List(Of Question)(questions.Concat(MakeQuestions()))
        Else
            questions = MakeQuestions()
        End If

        'Check that there are questions to ask.
        If questions.Count = 0 Then
            If txtPrompts.Lines.Count = 0 AndAlso txtAnswers.Lines.Count = 0 Then
                MsgBox("There are no questions to ask.", vbOKOnly, "No Questions")
            Else
                MsgBox("The number of questions does not match the number of answers.", vbOKOnly + vbCritical, "Mismatched Questions and Answers")
            End If

        Else
            frmQuiz.Show()
            Me.Close()

        End If

    End Sub

    ''' <summary>
    ''' Generate a List of Question from the txtPrompts and txtAnswers TextBoxes.
    ''' </summary>
    ''' <returns>The List of Question.</returns>
    Private Function MakeQuestions() As List(Of Question)
        Dim questions As New List(Of Question)

        Dim prompts() As String = Split(txtPrompts.Text.Trim(), Chr(10))
        Dim answers() As String = Split(txtAnswers.Text.Trim(), Chr(10))

        'Move through the prompts and answers, skipping empty prompts and answers, fixing
        'the strings and using them to make new questions to put into qList.
        Dim iPrompt As Integer = 0
        Dim iAnswer As Integer = 0
        While iPrompt < prompts.Count AndAlso iAnswer < answers.Count
            'Fix the prompt at iPrompt.
            FixString(prompts(iPrompt))
            iPrompt += 1

            If prompts(iPrompt - 1) <> "" Then
                'Get the next valid answer.
                Do
                    'Fix the answer at iAnswer.
                    FixString(answers(iAnswer))
                    iAnswer += 1
                Loop While answers(iAnswer - 1) = "" AndAlso iAnswer < answers.Count

                If answers(iAnswer - 1) <> "" Then
                    'If neither the question nor answer is blank, add the new question to questions.
                    questions.Add(New Question(prompts(iPrompt - 1), answers(iAnswer - 1)))
                End If

            End If

        End While

        'Check for an uneven number of questions and answers.
        If iPrompt < prompts.Count OrElse iAnswer < answers.Count Then
            questions.Clear()
        End If

        Return questions

    End Function

End Class