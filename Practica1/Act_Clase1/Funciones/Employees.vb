Public Class Employees
    Public Function TotalSalario(ByVal numE As Integer, ByVal nom As String, type As String, ByVal hours As Integer)
        Dim sueldo As Double
        Dim he, hn As Integer
        'he Horas extra
        'ho ayudara a guardar informacion sobre las horas
        Dim msg As String

        If hours < 0 Then
            msg = "Error, cantidad de horas incorrectas"
            Return msg
        ElseIf hours > 40 Then
            he = hours - 40
            hn = 40

        Else
            he = 0
            hn = hours

        End If

        sueldo = CalcularSueldo(he, hn, type)

        msg = "Tu sueldo es " & sueldo.ToString()

        Return msg
    End Function

    Private Function CalcularSueldo(ByVal he As Integer, ByVal hn As Integer, ByVal type As String)

        Dim sueldo As Double
        Dim totalHe As Double
        Dim totalHn As Double
        Dim costoExtra As Double
        Dim costoNormal As Double

        Select Case type
            Case "Directivo"
                costoNormal = 200
                costoExtra = 250

            Case "Administrativo"
                costoNormal = 180
                costoExtra = 200

            Case "Tecnico"
                costoNormal = 160
                costoExtra = 185

            Case "Gerente"
                costoNormal = 190
                costoExtra = 220

            Case "Mantenimiento"
                costoNormal = 140
                costoExtra = 170
            Case "Operador"
                costoNormal = 100
                costoExtra = 120

        End Select

        totalHe = he * costoExtra
        totalHn = hn * costoNormal
        sueldo = totalHe + totalHn

        Return sueldo
    End Function
End Class
