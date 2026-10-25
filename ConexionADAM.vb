Imports System.IO.Ports

Public Class ConexionADAM 'comunicarse con el módulo ADAM-4019 y recuperar las lecturas de sus ocho canales analógicos.'
    Private puertoCOM As String
    Private direccion As String

    ' Constructor
    Public Sub New(com As String, id As String) 'creamos constructor'

        puertoCOM = com
        direccion = id

    End Sub

    'Lee los 8 canales analógicos del ADAM-4019
    Public Function LeerAnalogicas() As String

        Using puerto As New SerialPort(     'Utilizamos using prque queremos que se cierre cuando termine de ejecutarse la funcion'
            puertoCOM, 9600, Parity.None, 8, StopBits.One)

            puerto.ReadTimeout = 20000 'Es el tiempo que le dejamos para que nos responda el modulo, si no responde en ese tiempo, nos dara error'

            puerto.Open() 'Abrimos puerto'

            ' Solicitar lectura de todos los canales
            puerto.Write("#" & direccion & vbCr)

            ' Recibir respuesta del módulo
            Dim Respuesta As String = puerto.ReadTo(vbCr)

            Return Respuesta


        End Using 'cerramos conexion'

    End Function

End Class