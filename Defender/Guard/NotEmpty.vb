Imports System.Runtime.CompilerServices

Partial Public Module Guard
	''' <summary>
	''' Guard against the collection being empty.
	''' </summary>
	''' <typeparam name="C">The type of the collection; must be <see cref="ICollection"/>.</typeparam>
	''' <param name="collection">The collection.</param>
	''' <param name="name">The name of the argument.</param>
	<MethodImpl(MethodImplOptions.AggressiveInlining)>
	Public Sub NotEmpty(Of C As ICollection)(Collection As C, Name As String)
		If Collection.Count = 0 Then
			Throw New ArgumentException($"Collection '{Name}' must not be empty.", Name)
		End If
	End Sub

	''' <summary>
	''' Guard against the collection being empty.
	''' </summary>
	''' <typeparam name="C">The type of the collection; must be <see cref="ICollection(Of T)"/>.</typeparam>
	''' <typeparam name="T">The type of the elements in the collection.</typeparam>
	''' <param name="collection">The collection.</param>
	''' <param name="name">The name of the argument.</param>
	<MethodImpl(MethodImplOptions.AggressiveInlining)>
	Public Sub NotEmpty(Of C As ICollection(Of T), T)(Collection As C, Name As String)
		If Collection.Count = 0 Then
			Throw New ArgumentException($"Collection '{Name}' must not be empty.", Name)
		End If
	End Sub
End Module
