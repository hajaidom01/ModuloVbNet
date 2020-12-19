Imports System.Data.SqlClient
Public Class ControlBD

    ReadOnly cnnString As String = My.Settings.PropertyValues("ConexionDB").Property.DefaultValue
    ReadOnly cnn = New SqlConnection(cnnString)

    Public Function TestConnection() As String
        Dim status As String

        Try
            cnn.Open()
            status = "Conexion exitosa."
            cnn.Close()
        Catch ex As Exception
            status = "Conexion fallida" & ex.Message
        End Try

        Return status
    End Function

    Public Function Conectar() As Boolean
        Dim response As Boolean
        Try
            cnn.Open()
            response = True
        Catch ex As Exception
            Return response
        End Try

        Return response
    End Function

    Public Function Desconectar() As Boolean
        Dim response As Boolean
        Try
            cnn.Close()
            response = True
        Catch ex As Exception
            Return response
        End Try

        Return response
    End Function

    Public Function EjecutarSql(ByVal query As String) As Boolean
        Dim procesado As Boolean

        If (Conectar()) Then
            Try
                Dim command As SqlCommand
                command = New SqlCommand(query, cnn)
                command.ExecuteNonQuery()
                procesado = True
            Catch ex As Exception
                Return procesado
            End Try
            Desconectar()
        End If
        Return procesado
    End Function

    Public Function LlenarVista(ByVal query As String, ByVal ddList As Object, ByVal codigo As String, ByVal valor As String) As Boolean
        Dim procesado As Boolean
        If (Conectar()) Then
            Try
                Dim adapter As New SqlDataAdapter(query, cnnString)
                Dim datos As New DataTable
                adapter.Fill(datos)
                ddList.DataSource = datos
                ddList.DataMember = codigo
                ddList.DataValueField = valor
                ddList.DataBind()
                procesado = True
            Catch ex As Exception
                Return procesado
            End Try
            Desconectar()
        End If
        Return procesado
    End Function

    Public Function ObtenerUnDato(ByVal query As String, ByVal txtb As Object, ByVal tablas As String, ByVal valor As String)
        If Conectar() Then
            Try
                Dim ad As SqlDataAdapter
                ad = New SqlDataAdapter(query, cnnString)
                Dim ds As New DataSet
                ad.Fill(ds, tablas)
                If ds.Tables(0).Rows.Count = 1 Then
                    Dim dr As DataRow
                    dr = ds.Tables(0).Rows(0)
                    txtb.Text = dr(valor).ToString()
                End If
            Catch ex As Exception
            End Try
            Desconectar()
        End If
    End Function

    Public Function SeleccionarUnDato(ByVal query As String, ByVal myDropDown As Object, ByVal tabla As String, ByVal valor As String)
        If Conectar() Then
            Try
                Dim ad As SqlDataAdapter
                ad = New SqlDataAdapter(query, cnnString)
                Dim ds As New DataSet
                ad.Fill(ds, tabla)
                If ds.Tables(0).Rows.Count = 1 Then
                    Dim dr As DataRow
                    dr = ds.Tables(0).Rows(0)
                    myDropDown.SelectedIndex = Convert.ToInt32(dr(valor)) - 1
                End If
            Catch ex As Exception
            End Try
            Desconectar()
        End If
    End Function

End Class
