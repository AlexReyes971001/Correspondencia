Imports System.IO
Imports System.Data.SqlClient

Public Class ListaCorrespondencias


    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim respuesta = MsgBox("¿Desea crear un nuevo folio?", MsgBoxStyle.YesNo, "AVISO")
        If respuesta = MsgBoxResult.No Then Exit Sub
        Dim NewFormC As New nuevaCorrespondencia
        For Each f As Form In Me.MdiChildren
            If f.Name = "Correspondencia" Then
                f.Activate()
                Exit Sub
            End If
        Next
        usoFolios = "NUEVO"
        NewFormC.ShowDialog()
    End Sub

    Private Sub ListaCorrespondencias_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        strWhere = "Select Folio, Asunto, Departamento, TipoCorre, Fecha from Prueba"
        formatoGrid(Lista)
        ConsultarInformacion()
        BindingSource1.DataSource = Dt
        Lista.DataSource = BindingSource1.DataSource
    End Sub
    Private Sub Uso_Filtro()
        If BindingSource1.DataSource Is Nothing Then
            txtFilter.BackColor = Color.White
            Exit Sub
        End If
        Dim filtro As String = String.Empty

        filtro = "[Folio] like '%" & txtFilter.Text.Trim & "%' or [Asunto] like '%" & txtFilter.Text.Trim & "%' or [TipoCorre] like '%" & txtFilter.Text.Trim & "%'"
        BindingSource1.Filter = filtro

        If BindingSource1.Count = 0 Then
            txtFilter.BackColor = Color.Red
        Else
            txtFilter.BackColor = Color.White
        End If
    End Sub

    Private Sub txtFilter_TextChanged(sender As Object, e As EventArgs) Handles txtFilter.TextChanged
        Uso_Filtro()

    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        strWhere = "Select Folio, Asunto, Departamento, TipoCorre, Fecha from Prueba"
        ConsultarInformacion()
        BindingSource1.DataSource = Dt
        Lista.DataSource = BindingSource1.DataSource
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles Visualizar.Click
        Try
            Dim Folio = Lista.CurrentRow.Cells("Folio").Value
            Dim nombreD = BuscarValor("Select Nombre from Prueba where Folio= '" & Folio & "'")
            Dim directorioTemporal As String = "C:\Users\PATRIMONIO\Downloads\" & nombreD

            Dim strWhere As String = "Select * from Prueba where Folio= '" & Folio & "'"
            dr = SqlCommand(strWhere)

            While dr.Read
                If dr("Documento") IsNot DBNull.Value Then
                    Dim bytes() As Byte
                    bytes = dr("Documento")
                    BytesAArchivo(bytes, directorioTemporal)
                    pdfViewer.src = directorioTemporal



                End If
            End While
            My.Computer.FileSystem.DeleteFile(directorioTemporal)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BytesAArchivo(ByVal bytes() As Byte, ByVal Path As String)
        Dim K As Long
        If bytes Is Nothing Then Exit Sub
        Try
            K = UBound(bytes)
            Dim fs As New FileStream(Path, FileMode.OpenOrCreate, FileAccess.Write)
            fs.Write(bytes, 0, K)
            fs.Close()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub ToolStripButton1_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton1.Click

        Dim Respuesta = MsgBox("¿Desea descargar el archivo seleccionado?", MsgBoxStyle.YesNo, "AVISO")
        If Respuesta = MsgBoxResult.No Then
            Exit Sub
        Else
            Try
                Dim Folio = Lista.CurrentRow.Cells("Folio").Value
                Dim nombreD = BuscarValor("Select Nombre from Prueba where Folio= '" & Folio & "'")
                Dim directorioTemporal As String = "C:\Users\PATRIMONIO\Downloads\" & nombreD

                Dim strWhere As String = "Select * from Prueba where Folio= '" & Folio & "'"
                dr = SqlCommand(strWhere)

                While dr.Read
                    If dr("Documento") IsNot DBNull.Value Then
                        Dim bytes() As Byte
                        bytes = dr("Documento")
                        BytesAArchivo(bytes, directorioTemporal)
                    End If
                End While
                    MsgBox("Archivo descargado exitosamente", MsgBoxStyle.Information, "AVISO")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub
End Class
