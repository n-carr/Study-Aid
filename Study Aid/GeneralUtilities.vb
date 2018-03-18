''' <summary>
''' A module of public constants and utility functions.
''' </summary>
Module GeneralUtilities

    Public Const vbDubNL As String = vbNewLine & vbNewLine 'A constant representing two NewLines.
    Public Const NEWLINE As String = "^^"

    ''' <summary>
    ''' Returns a random integer in range of low to high (inclusive). All values are equally probable.
    ''' </summary>
    ''' <param name="low">The minimum possible integer value.</param>
    ''' <param name="high">The maximum possible integer value.</param>
    Function RandInt(low As Integer, high As Integer) As Integer
        'If low and high were reversed, swap them.
        If (high < low) Then
            Dim temp As Integer = low
            low = high
            high = temp
        End If

        Return CInt(Rnd() * (high - low)) + low

    End Function

    ''' <summary>
    ''' Returns a random integer in range of 0 to high (inclusive). All values are equally probable.
    ''' </summary>
    ''' <param name="high">The maximum possible integer value.</param>
    Function RandInt(high As Integer) As Integer
        Return CInt(Rnd() * high)

    End Function

    ''' <summary>
    ''' Returns a double constrained to the range of low to high (inclusive).
    ''' </summary>
    ''' <param name="number">The number to contrain.</param>
    ''' <param name="low">The minimum of the range.</param>
    ''' <param name="high">The maximum of the range.</param>
    ''' <returns>The constrained number.</returns>
    Function Constrain(number As Double, low As Double, high As Double) As Double
        'If low and max were reversed, swap them.
        If (high < low) Then
            Dim temp As Integer = low
            low = high
            high = temp
        End If

        Return Math.Min(Math.Max(low, number), high)

    End Function

    ''' <summary>
    ''' Determines whether a number exists in the range of low to max (inclusive).
    ''' </summary>
    ''' <param name="number">The number to check.</param>
    ''' <param name="low">The minimum of the range.</param>
    ''' <param name="high">The maximum of the range.</param>
    ''' <returns>True if the number is in the range, False otherwise.</returns>
    Function InRange(number As Double, low As Double, high As Double) As Boolean
        Return number >= low AndAlso number <= high

    End Function

    ''' <summary>
    ''' Removes and returns a random element from a List.
    ''' </summary>
    ''' <typeparam name="T">The type stored in the list.</typeparam>
    ''' <param name="list">The list from which to remove an element.</param>
    ''' <returns>A random element from the list.</returns>
    Function RandFromList(Of T)(ByRef list As List(Of T)) As T
        Dim retVal As T = Nothing

        If list.Count > 0 Then
            Dim index As Integer = RandInt(0, list.Count - 1)
            retVal = list(index)
            list.RemoveAt(index)
        End If

        Return retVal

    End Function

    ''' <summary>
    ''' Trim a string and replace the NEWLINE constant with a newline character.
    ''' </summary>
    ''' <param name="toFix">The string to fix.</param>
    Sub FixString(ByRef toFix As String)
        'Trim the string.
        toFix.Trim()
        If toFix <> "" Then
            'Split string at newline string, trim the portions, then join them back together with
            'a newline character.
            Dim stringSplits() As String = Split(toFix, NEWLINE)
            For Each promptSplit In stringSplits
                promptSplit.Trim()
            Next
            toFix = Join(stringSplits, Chr(10))
        End If

    End Sub

End Module
