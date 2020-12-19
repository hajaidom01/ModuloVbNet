Imports System.Data.SqlClient
Public Class FactoryHelper

    Public Function CreateAdapater(query As String, cnnString As String) As SqlDataAdapter
        Return New SqlDataAdapter(query, cnnString)
    End Function

End Class
