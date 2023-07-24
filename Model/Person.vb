Public Class Person

	Dim id As Integer
	Dim name,
		lastName,
		identificacion,
		address As String
	Dim favoriteNumber As Integer
	Dim salary As Decimal
	Dim dateBirth As Date

	Public Sub New()
	End Sub

    Public Sub New(id As Integer, name As String, lastName As String, identificacion As String, address As String, favoriteNumber As Integer, salary As Decimal, dateBirth As Date)
        Me.id = id
        Me.name = name
        Me.lastName = lastName
        Me.identificacion = identificacion
        Me.address = address
        Me.favoriteNumber = favoriteNumber
        Me.salary = salary
        Me.dateBirth = dateBirth
    End Sub


    Public Property getId
        Get
            Return id
        End Get
        Set(value)
            id = value
        End Set
    End Property

    Public Property getName
        Get
            Return name
        End Get
        Set(value)
            name = value
        End Set
    End Property

    Public Property getLastName
        Get
            Return lastName
        End Get
        Set(value)
            lastName = value
        End Set
    End Property

    Public Property getIdentificacion
        Get
            Return identificacion
        End Get
        Set(value)
            identificacion = value
        End Set
    End Property

    Public Property getFavoriteNumber
        Get
            Return favoriteNumber
        End Get
        Set(value)
            favoriteNumber = value
        End Set
    End Property

    Public Property getAddress
        Get
            Return address
        End Get
        Set(value)
            address = value
        End Set
    End Property


    Public Property getSalary
        Get
            Return salary
        End Get
        Set(value)
            salary = value
        End Set
    End Property


    Public Property getDateBirth
        Get
            Return dateBirth
        End Get
        Set(value)
            dateBirth = value
        End Set
    End Property
End Class
