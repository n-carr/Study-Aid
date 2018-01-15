''' <summary>
''' A list data type that returns a random one of its values with the Remove function.
''' </summary>
''' <typeparam name="T">A generic data type.</typeparam>
Public Class RandList(Of T)

    Private contents() As T
    Private count As Integer = 0

    ''' <summary>
    ''' Adds an item of generic type T to the contents of the RandList.
    ''' </summary>
    ''' <param name="item">The item to be added.</param>
    Sub Add(item As T)

        'Redim contents to extend by one.
        ReDim Preserve contents(count + 1)
        count += 1

        'Insert new item.
        contents(count - 1) = item

    End Sub

    ''' <summary>
    ''' Removes and returns a random item from the contents of the RandList.
    ''' </summary>
    ''' <returns>A random item of type T.</returns>
    Function Remove() As T

        'Get random valid index.
        Dim randIndex As Integer = CInt(Rnd() * (count - 1))

        'Remove item at index.
        Dim item As T = contents(randIndex)

        'Move last item in RandList to removed index.
        contents(randIndex) = contents(count - 1)

        'Redim contents to remove last item.
        ReDim Preserve contents(count - 1)
        count -= 1

        Return item

    End Function

    ''' <summary>
    ''' Removes all items from the contents of the RandList.
    ''' </summary>
    Sub Clear()

        ReDim contents(0)
        count = 0

    End Sub

    ''' <summary>
    ''' Determine whether or not the contents of the RandList are empty.
    ''' </summary>
    ''' <returns>True if empty, False if not.</returns>
    Function IsEmpty() As Boolean

        Return count = 0

    End Function

    ''' <summary>
    ''' Returns the number of items in the RandList.
    ''' </summary>
    ''' <returns>The count of the RandList.</returns>
    Function GetCount() As Integer

        Return count

    End Function

End Class
