Module Module1

    Sub Main()

        Dim cuenta1 As New CuentaAhorros(New Cliente("Maria", "123", "calle falsa", "333333"), 500)

        Console.WriteLine(cuenta1.getSaldo)

        cuenta1.retirarDinero(600)

        Console.WriteLine(cuenta1.getSaldo())



    End Sub

End Module
