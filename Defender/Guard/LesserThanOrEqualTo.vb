Imports System.Runtime.CompilerServices

Partial Public Module Guard
	''' <summary>
	''' Guard against the argument being greater than <paramref name="upper"/> bound.
	''' </summary>
	''' <typeparam name="T">The type of the argument; must be <see cref="IComparable(Of T)"/>.</typeparam>
	''' <param name="value">The value.</param>
	''' <param name="name">The name of the argument.</param>
	''' <param name="upper">The lower bound.</param>
	<MethodImpl(MethodImplOptions.AggressiveInlining)>
	Public Sub LesserThanOrEqualTo(Of T As IComparable(Of T))(Value As T, Name As String, Upper As T)
		If Value.CompareTo(Upper) > 0 Then
			Throw New ArgumentOutOfRangeException(Name, $"Argument must be lesser than or equal to the lower bound '{Upper}'.")
		End If
	End Sub
End Module
