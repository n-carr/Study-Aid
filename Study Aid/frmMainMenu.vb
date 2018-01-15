''' <summary>
''' The first form opened in the application. Sets up the quiz.
''' </summary>
Public Class frmMainMenu

    Const DELIM As String = "&&"
    Const NEWLINE As String = "^^"

    ''' <summary>
    ''' Create a RandList of Questions using the manually-input prompts and answers, then start the quiz.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnStart_Click(sender As System.Object, e As System.EventArgs) Handles btnStart.Click

        'Must use Chr(10) because a new line in a multi-line textbox is not defined by vbNewLine
        Dim strPrompts() As String = Split(txtPrompts.Text, Chr(10))
        Dim strAnswers() As String = Split(txtAnswers.Text, Chr(10))

        If strPrompts.GetUpperBound(0) = strAnswers.GetUpperBound(0) And strPrompts.GetUpperBound(0) > 0 Then

            Dim lstQuestions As New RandList(Of Question)

            For i = 0 To strPrompts.GetUpperBound(0)

                'Skip any blank prompts.
                If strPrompts(i).Trim() <> "" Then

                    'Split prompt at newline string.
                    Dim strPromptSplit() As String = Split(strPrompts(i), NEWLINE)

                    'Trim each line of prompt.
                    For j = 0 To strPromptSplit.GetUpperBound(0)
                        strPromptSplit(j) = strPromptSplit(j).Trim()
                    Next

                    'Rejoin all lines of prompt into one string.
                    strPrompts(i) = Join(strPromptSplit, vbNewLine)

                    'Split answer at newline string.
                    Dim strAnswerSplit() As String = Split(strAnswers(i), NEWLINE)

                    'Trim each line of answer.
                    For j = 0 To strAnswerSplit.GetUpperBound(0)
                        strAnswerSplit(j) = strAnswerSplit(j).Trim()
                    Next

                    'Rejoin all lines of prompt into one string.
                    strAnswers(i) = Join(strAnswerSplit, vbNewLine)

                    'Add new question defined by prompt and answer to lstQuestions.
                    lstQuestions.Add(New Question(strPrompts(i), strAnswers(i)))

                End If

            Next

            'Open frmQuiz.
            Dim frm As New frmQuiz(lstQuestions)
            frm.Show()

            'Close this form.
            Me.Close()

        ElseIf strPrompts.GetUpperBound(0) <= 0 Or strAnswers.GetUpperBound(0) <= 0 Then

            MsgBox("There must be at least one question.", vbOKOnly, "No Questions")

        Else

            MsgBox("The number of answers does not match the number of questions.", _
                   vbCritical + vbOKOnly, "Question - Answer Count Mismatch")

        End If

    End Sub

    ''' <summary>
    ''' Create a RandList of Questions using a user-selected file, then start the quiz.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnFile_Click(sender As System.Object, e As System.EventArgs) Handles btnFile.Click

        'Get a file from the user.
        Dim strFile As String = PromptFile()

        If strFile <> "" Then

            'Create a RandList of Questions from the file.
            Dim lstQuestions As RandList(Of Question) = FormQuestions(strFile)

            If Not lstQuestions.IsEmpty() Then

                'Open frmQuiz.
                Dim frm As New frmQuiz(lstQuestions)
                frm.Show()

                'Close this form.
                Me.Close()

            End If

        End If

    End Sub

    ''' <summary>
    ''' Prompts the user for a .txt quiz file.
    ''' </summary>
    ''' <returns>The selected file as a String.</returns>
    Function PromptFile() As String

        Dim ofd As New OpenFileDialog
        ofd.Multiselect = False
        ofd.Title = "Select a quiz file..."
        ofd.Filter = "Text files (*.txt)|*.txt"
        ofd.InitialDirectory = Application.StartupPath.ToLower.Replace("\bin\debug", "").Replace("\bin\release", "")

        Dim strFile As String = ""

        'Only attempt to get ofd's FileName if a file was selected.
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
            strFile = ofd.FileName
        End If

        Return strFile

    End Function

    ''' <summary>
    ''' Creates a RandList of Questions from a file address.
    ''' </summary>
    ''' <param name="strFile">A file address.</param>
    ''' <returns>A RandList of Questions.</returns>
    Function FormQuestions(strFile As String) As RandList(Of Question)

        Dim lstQuestions As New RandList(Of Question)

        Try

            Dim intLineIndex As Integer = 0

            'Create a Question from each line in the selected file and add it to lstQuestions.
            For Each strLine As String In IO.File.ReadAllLines(strFile)

                'Increment index.
                intLineIndex += 1

                Dim strQuestion() As String = Split(strLine, DELIM)

                'If a line is missing the split line delimiter, tell the user which one.
                Try
                    'Trim prompt
                    Dim strPrompt() As String = Split(strQuestion(0), NEWLINE)
                    For i = 0 To strPrompt.GetUpperBound(0)
                        strPrompt(i) = strPrompt(i).Trim()
                    Next

                    'Trim answer.
                    Dim strAnswer() As String = Split(strQuestion(1), NEWLINE)
                    For i = 0 To strAnswer.GetUpperBound(0)
                        strAnswer(i) = strAnswer(i).Trim()
                    Next

                    lstQuestions.Add(New Question(Join(strPrompt, vbNewLine), Join(strAnswer, vbNewLine)))

                Catch
                    Dim mbr As MsgBoxResult = _
                        MsgBox("Line " & intLineIndex & " is missing a delimiter string. " & _
                           "The question cannot be distinguished from the answer. " & _
                           "The following question will not be asked:" & _
                           Strings.StrDup(2, vbNewLine) & strLine & _
                           Strings.StrDup(2, vbNewLine) & "Press Cancel to change the quiz or options.",
                           vbCritical + vbOKCancel, "Question not Added.")

                    'Leave the sub (cancel quiz) if the user does not want to continue without the question.
                    If mbr = vbCancel Then
                        Return New RandList(Of Question)
                        Exit Function
                    End If

                End Try

            Next strLine

        Catch
            MsgBox("File could not be read.", vbCritical + vbOKOnly, "File not Read")

        End Try

        Return lstQuestions

    End Function

End Class