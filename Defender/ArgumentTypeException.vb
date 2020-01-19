''' <summary>
''' The exception that Is thrown when an object Is passed to a method that expects a specific type, but Is Not of that type.
''' </summary>
Public Class ArgumentTypeException
    Inherits ArgumentException
    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(Message As String)
        MyBase.New(Message)
    End Sub

    Public Sub New(Message As String, Inner As Exception)
        MyBase.New(Message, Inner)
    End Sub

    Public Sub New(ParamName As String, Message As String)
        MyBase.New(Message, ParamName)
    End Sub

    Public Sub New(ParamName As String, Message As String, Inner As Exception)
        MyBase.New(Message, ParamName, Inner)
    End Sub

    Public Sub New(ParamName As String, ParamType As Type)
        MyBase.New(ParamName, $"Argument not of type {ParamType}.")
    End Sub

    Public Sub New(ParamName As String, ParamType As Type, Message As String)
        Me.New(ParamName, $"Argument not of type {ParamType}. {Message}")
    End Sub

    Public Sub New(ParamName As String, ParamType As Type, Inner As Exception)
        Me.New(ParamName, $"Argument not of type {ParamType}.", Inner)
    End Sub

    Public Sub New(ParamName As String, ParamType As Type, Message As String, Inner As Exception)
        Me.New(ParamName, $"Argument not of type {ParamType}. {Message}", Inner)
    End Sub
End Class
