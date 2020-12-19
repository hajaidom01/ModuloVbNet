Public Class Actividad4
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnAceptar_Click(sender As Object, e As EventArgs)
        Dim empleado As New Employees()
        Dim msg As String

        msg = empleado.TotalSalario(txtNoEmpl.Text, txtNombre.Text, DropDownList1.SelectedValue, txtHoras.Text)

        MsgBox(msg)
    End Sub
End Class