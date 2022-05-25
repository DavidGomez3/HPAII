Imports System.Data
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CrearLaDataTable()
        Dim tablaReservas As New DataTable("Reservas")
        tablaReservas.Columns.Add("Nombre", Type.GetType("System.String"))

        Dim nuevaFila As DataRow
        Dim i As Integer

        For i = 0 To 4
            nuevaFila = tablaReservas.NewRow()
            nuevaFila("Nombre") = "Item " & i
            tablaReservas.Rows.Add(nuevaFila)
        Next

        tablaReservas.AcceptChanges()


        Dim primeraVista As New DataView(tablaReservas)
        Dim SegundaVista As New DataView(tablaReservas)

        tablaReservas.Rows(0)("Nombre") = "Gato"
        tablaReservas.Rows(1)("Nombre") = "Perro"
        printdata
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class
