''' <summary>
''' A class containing a prompt String, answer String, and Boolean value of whether or not the question has
''' been answered incorrectly.
''' </summary>
Public Class Question

    Private _prompt As String
    Private _answer As String
    Private _wrong As Boolean = False

    ''' <summary>
    ''' A constructor that takes a prompt and answer as String.
    ''' </summary>
    ''' <param name="prompt">The prompt.</param>
    ''' <param name="answer">The answer.</param>
    Sub New(prompt As String, answer As String)
        Me._prompt = prompt
        Me._answer = answer

    End Sub

    ''' <summary>
    ''' Gets the prompt string of the question.
    ''' </summary>
    ''' <returns>The prompt string.</returns>
    ReadOnly Property Prompt As String
        Get
            Return Me._prompt
        End Get

    End Property

    ''' <summary>
    ''' Gets the answer string of the question.
    ''' </summary>
    ''' <returns>The answer string.</returns>
    ReadOnly Property Answer As String
        Get
            Return Me._answer
        End Get

    End Property

    ''' <summary>
    ''' Gets or sets a value representing whether the question has been incorrectly answered.
    ''' </summary>
    ''' <returns>True if the question has been incorrectly answered, False otherwise.</returns>
    Property Wrong As Boolean
        Get
            Return Me._wrong
        End Get

        Set(wrong As Boolean)
            Me._wrong = wrong
        End Set

    End Property

    ''' <summary>
    ''' Set the question as having been answered incorrectly.
    ''' </summary>
    Sub SetWrong()
        Me._wrong = True

    End Sub

    ''' <summary>
    ''' Set the question as having not been answered incorrectly.
    ''' </summary>
    Sub ResetWrong()
        Me._wrong = False

    End Sub

End Class
