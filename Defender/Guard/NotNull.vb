Imports System.Runtime.CompilerServices

Partial Public Module Guard
	''' <summary>
	''' Guard against the argument being <see langword="null"/>.
	''' </summary>
	''' <typeparam name="T">The type of the argument; must be a struct.</typeparam>
	''' <param name="value">The <see cref="Nullable{T}"/> <typeparamref name="T"/> value.</param>
	''' <param name="name">The name of the argument.</param>
	<MethodImpl(MethodImplOptions.AggressiveInlining)>
	Public Sub NotNull(Of T As Structure)(Value As T?, Name As String)
		If Value Is Nothing Then
			Throw New ArgumentNullException(Name)
		End If
	End Sub

	''' <summary>
	''' Guard against the argument being <see langword="null"/>.
	''' </summary>
	''' <typeparam name="T">The type of the argument; must be a class.</typeparam>
	''' <param name="value">The <typeparamref name="T"/> value.</param>
	''' <param name="name">The name of the argument.</param>
	<MethodImpl(MethodImplOptions.AggressiveInlining)>
	Public Sub NotNull(Of T As Class)(Value As T, Name As String)
		If Value Is Nothing Then
			Throw New ArgumentNullException(Name)
		End If
	End Sub
End Module
