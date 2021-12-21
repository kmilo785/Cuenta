Module Module1

    Sub Main()

        Dim cuentas(2) As CuentaAhorros

        For i = 0 To 2

            Dim nom, ce, dir, tel As String
            Dim saldo As Double

            Console.WriteLine("Ingrese los datos para la cuenta " & i + 1)

            Console.Write("Ingrese el nombre del cliente: ")
            nom = Console.ReadLine()

            Console.Write("Ingrese la cedula del cliente: ")
            ce = Console.ReadLine()

            Console.Write("Ingrese la dirección del cliente: ")
            dir = Console.ReadLine()

            Console.Write("Ingrese el telefono del cliente: ")
            tel = Console.ReadLine()

            Console.Write("Ingrese el monto inicial de la cuenta: ")
            saldo = Console.ReadLine()


            Dim cuenta As New CuentaAhorros(New Cliente(nom, ce, dir, tel), saldo)

            cuentas(i) = cuenta


        Next

        For Each c As CuentaAhorros In cuentas
            Console.WriteLine("================")
            Console.WriteLine("Nro. Cuenta: " & c.getNumeroCuentaAhorros)
            Console.WriteLine("Nombre del Cliente: " & c.ClienteCuenta.Nombre1)
            Console.WriteLine("Cedula del Cliente: " & c.ClienteCuenta.Cedula1)
            Console.WriteLine("Dirección del Cliente: " & c.ClienteCuenta.Direccion1)
            Console.WriteLine("Telefono del Cliente: " & c.ClienteCuenta.Telefono1)
            Console.WriteLine("Saldo de la cuenta: " & c.getSaldo)
            Console.WriteLine("")

        Next

    End Sub

End Module
