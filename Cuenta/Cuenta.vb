Public Class Cuenta

    Protected numeroCuentaAhorros As Integer
    Protected saldo As Double
    Protected cte As Cliente

    Protected Shared id As Integer = 1

    Public Function getNumeroCuentaAhorros() As Integer
        Return numeroCuentaAhorros
    End Function

    Public Function getSaldo() As Integer
        Return saldo
    End Function

    Public Sub New()

        numeroCuentaAhorros = id
        saldo = 0
        cte = Nothing

        id += 1

    End Sub

    Public Sub New(cl As Cliente, sa As Double)

        numeroCuentaAhorros = id
        saldo = sa
        cte = cl

        id += 1

    End Sub

    Public Property ClienteCuenta() As Cliente
        Get
            Return cte
        End Get
        Set(value As Cliente)
            If cte Is Nothing Then

                cte = value
            Else
                Console.WriteLine("El cliente ya esta asignado a la cuenta")
            End If
        End Set
    End Property

    Public Sub depositarDinero(valor As Double)
        saldo = saldo + valor

    End Sub

    Public Sub retirarDinero(valor As Double)

        If saldo >= valor Then
            saldo = saldo - valor
        Else
            Console.WriteLine("El saldo disponible es menor al valor a retirar")
        End If

    End Sub
End Class
