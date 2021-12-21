Public Class Persona

    Private nombre As String
    Private cedula As String
    Private direccion As String
    Private telefono As String

    Public Sub New(nom As String, ce As String, dir As String, tel As String)
        nombre = nom
        cedula = ce
        direccion = dir
        telefono = tel
    End Sub

    Public Property Nombre1 As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property Cedula1 As String
        Get
            Return cedula
        End Get
        Set(value As String)
            cedula = value
        End Set
    End Property

    Public Property Direccion1 As String
        Get
            Return direccion
        End Get
        Set(value As String)
            direccion = value
        End Set
    End Property

    Public Property Telefono1 As String
        Get
            Return telefono
        End Get
        Set(value As String)
            telefono = value
        End Set
    End Property


End Class
