Imports System.Runtime.CompilerServices

Partial Public Module Guard
	''' <summary>
	''' Guard against the argument being lesser than <paramref name="lower"/> bound.
	''' </summary>
	''' <typeparam name="T">The type of the argument; must be <see cref="IComparable(Of T)"/>.</typeparam>
	''' <param name="value">The value.</param>
	''' <param name="name">The name of the argument.</param>
	''' <param name="lower">The lower bound.</param>
	<MethodImpl(MethodImplOptions.AggressiveInlining)>
	Public Sub GreaterThanOrEqualTo(Of T As IComparable(Of T))(Value As T, Name As String, Lower As T)
		If Value.CompareTo(Lower) < 0 Then
			Throw New ArgumentOutOfRangeException(Name, $"Argument must be greater than or equal to the lower bound '{Lower}'.")
		End If
	End Sub
End Module
