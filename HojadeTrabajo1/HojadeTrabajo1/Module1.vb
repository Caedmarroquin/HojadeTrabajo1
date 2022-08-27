Imports System
Module Module1
    Sub Main(args As String())
        Console.WriteLine("*****HOJA DE TRABAJO No.1*****")
        Console.WriteLine("")

    End Sub
    Sub Problema1()
        Dim x, y, z As Integer
        Try
            Console.WriteLine("Problema No.1 - Ordenar Numeros")
            Console.WriteLine("")
            Console.WriteLine("Ingrese los valores")
            Console.WriteLine("")
            Console.Write("Número a:   ")
            x = Console.ReadLine()
            Console.Write("Número b:   ")
            y = Console.ReadLine()
            Console.Write("Número c:   ")
            z = Console.ReadLine()
            Console.WriteLine("-----------------------")
            Console.WriteLine("RESULTADO")
            If x > y And x > z Then
                Console.WriteLine(x)
                If y > z Or y = z Then
                    Console.WriteLine(y)
                    Console.WriteLine(z)
                Else
                    Console.WriteLine(z)
                    Console.WriteLine(y)
                End If
            End If
            If y > z And y > x Then
                Console.WriteLine(y)
                If x > z Or x = z Then
                    Console.WriteLine(x)
                    Console.WriteLine(z)
                Else
                    Console.WriteLine(z)
                    Console.WriteLine(x)
                End If
            End If
            If z > x And z > y Then
                Console.WriteLine(z)
                If x > y Or x = y Then
                    Console.WriteLine(x)
                    Console.WriteLine(y)
                Else
                    Console.WriteLine(y)
                    Console.WriteLine(x)
                End If
            End If
            If x = y And y = z Then
                Console.WriteLine(x)
                Console.WriteLine(x)
                Console.WriteLine(x)
            End If
            If x = y And x > z Then
                Console.WriteLine(x)
                Console.WriteLine(y)
                Console.WriteLine(z)
            End If
            If y = z And y > x Then
                Console.WriteLine(y)
                Console.WriteLine(z)
                Console.WriteLine(x)
            End If
            If x = z And x > y Then
                Console.WriteLine(x)
                Console.WriteLine(z)
                Console.WriteLine(y)
            End If
        Catch ex As Exception
        End Try
        Console.WriteLine("-----------------------")
        Console.WriteLine("Pulse cualquier tecla para salir")
        Console.ReadKey()
    End Sub
    Sub Problema2()
        Dim a, b, c As Double
        Console.WriteLine("Problema No.2 - Tipo de Triangulo")
        Console.WriteLine("")
        Console.Write("Ingresa el valor de a: ")
        a = Double.Parse(Console.ReadLine())
        Console.Write("Ingresa el valor de b: ")
        b = Double.Parse(Console.ReadLine())
        Console.Write("Ingresa el valor de c: ")
        c = Double.Parse(Console.ReadLine())
        Console.WriteLine("-----------------------")
        Console.WriteLine("RESULTADO")
        If a = b And b = c Then
            Console.WriteLine("Equilatero")
        ElseIf a = b Or a = c Or b = c Then
            Console.WriteLine("Isósceles")
        Else
            Console.WriteLine("Escaleno")
        End If
        Console.WriteLine("-----------------------")
        Console.WriteLine("Pulse cualquier tecla para salir")
        Console.ReadKey()
    End Sub
    Sub Problema3()
        Console.WriteLine("Problema No.3")
        Console.WriteLine("")
        Console.Write("ingrese un numero: ")
        Dim numero As Integer = Console.ReadLine()
        Console.WriteLine("-----------------------")
        Console.WriteLine("RESULTADO")
        Dim suma As Integer
        For indice As Integer = 0 To numero
            Console.WriteLine(indice)
            suma = suma + indice
        Next
        Console.WriteLine("Suma de números: " & suma)
        If (suma Mod 2 = 0) Then
            Console.WriteLine("La suma es par")
        Else
            Console.WriteLine("La suma es impar")
        End If
        Console.WriteLine("-----------------------")
        Console.WriteLine("Pulse cualquier tecla para salir")
        Console.ReadKey()
    End Sub
    Sub Problema4()
        Console.WriteLine("Problema No.4")
        Console.WriteLine("")
        Console.Write("ingrese un numero: ")
        Dim numero As Integer = Console.ReadLine()
        Console.WriteLine("-----------------------")
        Console.WriteLine("RESULTADO")
        If numero > 0 Then
            For indice As Integer = 0 To numero Step 2
                Console.WriteLine(indice)
            Next
        ElseIf numero < 0 Then
            For indice As Double = 0 To numero Step -0.5
                Console.WriteLine(indice)
            Next
        End If
        Console.WriteLine("-----------------------")
        Console.WriteLine("Pulse cualquier tecla para salir")
        Console.ReadKey()
    End Sub
    Sub Problema5()
        Dim a, b, c, x As Integer
        Console.WriteLine("Problema No.5")
        Console.WriteLine("")
        Console.WriteLine("ingrese las notas de cada materia: ")
        Console.WriteLine("")
        Console.Write("Matematicas: ")
        a = Double.Parse(Console.ReadLine())
        Console.Write("Fisica: ")
        b = Double.Parse(Console.ReadLine())
        Console.Write("Programación: ")
        c = Double.Parse(Console.ReadLine())
        x = (a + b + c) / 3
        Console.WriteLine("----------------")
        Console.WriteLine("RESULTADO")
        Console.WriteLine("Promedio: " & x)
        If x < 61 Then
            Console.WriteLine("Reprobado")
        End If
        If x >= 61 And x <= 80 Then
            Console.WriteLine("Regular")
        End If
        If x > 80 Then
            Console.WriteLine("Excelente")
        End If
        Console.WriteLine("")
        Console.WriteLine("Pulse cualquier tecla para salir...")
        Console.ReadKey()
    End Sub
End Module
