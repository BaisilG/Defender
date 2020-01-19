Imports System.Runtime.CompilerServices

Partial Public Module Guard
	''' <summary>
	''' Guard against the argument Not being of type <typeparamref name="T"/>.
	''' </summary>
	''' <typeparam name="T">The type the <paramref name="value"/> must be of.</typeparam>
	''' <param name="value">The value.</param>
	''' <param name="name">The name of the argument.</param>
	<MethodImpl(MethodImplOptions.AggressiveInlining)>
	Public Sub OfType(Of T)(Value As Object, Name As String)
		If TypeOf Value IsNot T Then
			Throw New ArgumentTypeException(Name, GetType(T))
		End If
	End Sub
End Module
