''' <summary>
''' A class containing a prompt String, answer String, and Boolean value of whether or not the question has
''' been answered incorrectly.
''' </summary>
Public Class Question

    Private prompt As String
    Private answer As String
    Private wrongStatus As Boolean = False

    ''' <summary>
    ''' A static/shared function that returns a copy of the input Question.
    ''' </summary>
    ''' <param name="qstOriginal">The Question to be copied.</param>
    ''' <returns>A copy of the original Question.</returns>
    Shared Function Copy(qstOriginal As Question) As Question

        Return New Question(qstOriginal.GetPrompt(), qstOriginal.GetAnswer())

    End Function

    ''' <summary>
    ''' A constructor that takes a prompt and answer as String.
    ''' </summary>
    ''' <param name="prompt">The prompt.</param>
    ''' <param name="answer">The answer.</param>
    Sub New(prompt As String, answer As String)

        Me.prompt = prompt
        Me.answer = answer

    End Sub

    ''' <summary>
    ''' Returns the prompt String.
    ''' </summary>
    ''' <returns>The prompt String.</returns>
    Function GetPrompt() As String

        Return prompt

    End Function

    ''' <summary>
    ''' Returns the answer String.
    ''' </summary>
    ''' <returns>The answer String.</returns>
    Function GetAnswer() As String

        Return answer

    End Function

    ''' <summary>
    ''' Returns whether or not the Question has been answered incorrectly.
    ''' </summary>
    ''' <returns>True if the Question has been answered incorrectly, False otherwise.</returns>
    ''' <remarks></remarks>
    Function HasBeenWrong() As Integer

        Return wrongStatus

    End Function

    ''' <summary>
    ''' Sets the Question as having been answered incorrectly.
    ''' </summary>
    Sub MarkWrong()

        wrongStatus = True

    End Sub

End Class
