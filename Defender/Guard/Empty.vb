Imports System.Runtime.CompilerServices

Partial Public Module Guard
    ''' <summary>
    ''' Guard against the string having characters.
    ''' </summary>
    ''' <param name="[String]">The string.</param>
    ''' <param name="Name">The name of the argument.</param>
    <MethodImpl(MethodImplOptions.AggressiveInlining)>
    Public Sub Empty([String] As String, Name As String)
        If [String].Length <> 0 Then
            Throw New ArgumentException($"String '{Name}' must be empty.", Name)
        End If
    End Sub

    ''' <summary>
    ''' Guard against the collection having elements.
    ''' </summary>
    ''' <typeparam name="C">The type of the collection; must be <see cref="ICollection"/>.</typeparam>
    ''' <param name="Collection">The collection.</param>
    ''' <param name="Name">The name of the argument.</param>
    <MethodImpl(MethodImplOptions.AggressiveInlining)>
    Public Sub Empty(Of C As ICollection)(Collection As C, Name As String)
        If Collection.Count <> 0 Then
            Throw New ArgumentException($"Collection '{Name}' must be empty.", Name)
        End If
    End Sub

    ''' <summary>
    ''' Guard against the collection having elements.
    ''' </summary>
    ''' <typeparam name="C">The type of the collection; must be <see cref="ICollection(Of T)"/>.</typeparam>
    ''' <typeparam name="T">The type of the elements in the collection.</typeparam>
    ''' <param name="Collection">The collection.</param>
    ''' <param name="Name">The name of the argument.</param>
    <MethodImpl(MethodImplOptions.AggressiveInlining)>
    Public Sub Empty(Of C As ICollection(Of T), T)(Collection As C, Name As String)
        If Collection.Count <> 0 Then
            Throw New ArgumentException($"Collection '{Name}' must be empty.", Name)
        End If
    End Sub
End Module
