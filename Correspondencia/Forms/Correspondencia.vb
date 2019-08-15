Imports System.IO
Imports System.Data.SqlClient

Public Class nuevaCorrespondencia

    Public folioTemporal, cambiosRegistro

    Private Sub nuevaCorrespondencia_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If cambiosRegistro = 1 Then
            If MessageBox.Show("No se guardaran los cambios, ¿Desea continuar?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub nuevaCorrespondencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If usoFolios = "NUEVO" Then
            cambiosRegistro = 1
            asegurarFolio()

        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim faltantes = 0
        If txtTipo.Text = "" Then
            faltantes += 1 : txtTipo.BackColor = Color.Red
        Else
            txtTipo.BackColor = Color.White
        End If
        If txtAsunto.Text = "" Then
            faltantes += 1 : txtAsunto.BackColor = Color.Red
        Else
            txtAsunto.BackColor = Color.White
        End If
        If txtDepto.Text = "" Then
            faltantes += 1 : txtDepto.BackColor = Color.Red
        Else
            txtDepto.BackColor = Color.White
        End If
        If txtDoc.Text = "" Then
            faltantes += 1 : txtDoc.BackColor = Color.Red
        Else

        End If
        If faltantes > 0 Then
            MsgBox("Por favor llene todos los campos", MsgBoxStyle.Exclamation)
            Exit Sub
        End If


        'Convertir archivo a binario
        Dim strpath As String 'Declaramos la variable 
        strpath = txtDoc.Text 'Guardamos contenido del txtDoc(Ruta) en la variable strpath
        Dim ruta As New FileStream(strpath, FileMode.Open, FileAccess.Read)

        Dim archivoBinario(ruta.Length) As Byte
        ruta.Read(archivoBinario, 0, ruta.Length)
        ruta.Close()

        Dim fecha As String = "'" & dtFecha.Value.Year & " -" & dtFecha.Value.Month & "-" & dtFecha.Value.Day & " '"

        Cmd = New SqlCommand
        strWhere = "Update Prueba set TipoCorre='" & txtTipo.Text & "', Asunto='" & txtAsunto.Text & "', Departamento='" & txtDepto.Text & "', Fecha=" & fecha & " , Documento= @Documento, Nombre='" & TextBox1.Text & "'  Where Folio='" & txtFolio.Text & "'"
        Cmd.Parameters.AddWithValue("@Documento", archivoBinario)
        Try
            actualizarInformacionBytes()
            MsgBox("Correspondencia creada con exito", MsgBoxStyle.Information, "AVISO")
            Dim NFolio = MsgBox("Desea generar nuevo folio?", MsgBoxStyle.YesNo, "AVISO")
            If NFolio = MsgBoxResult.Yes Then
                clean()
                asegurarFolio()
            Else
                btnGuardar.Enabled = False
                cambiosRegistro = 0
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub asegurarFolio()
        'Obtener Ultimo Folio
        folioTemporal = BuscarValor("Select ultimoAsignado from controlFolios")
        txtFolio.Text = "CCV-" & folioTemporal
        ' Actualizar el folio en la base de datos
        strWhere = "Update controlFolios set ultimoAsignado=" & folioTemporal + 1 & " where Folio='CCV'"
        Try
            actualizarInformacion()
        Catch ex As Exception
            MsgBox("No se pudo asignar folio, se interrumpira la accion")
            Exit Sub
        End Try



        ' Insertar folio asignado en la base de datos
        Dim fecha As String = "'" & dtFecha.Value.Year & " -" & dtFecha.Value.Month & "-" & dtFecha.Value.Day & " '"
        strWhere = "Insert into Prueba (Folio, TipoCorre,  Asunto, Departamento, Fecha, Nombre) " &
                    "VALUES ('" & txtFolio.Text & "','" & txtTipo.Text & "', '" & txtAsunto.Text & "','" & txtDepto.Text & "', " & fecha & ",'" & TextBox1.Text & "')"


        Try
            actualizarInformacion()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub clean()
        txtAsunto.Clear()
        txtTipo.Clear()
        txtDepto.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim openFile As New OpenFileDialog
        With openFile
            .Title = "Seleccionar Archivos"
            .Filter = "Archivos PDF(*.pdf)|*.pdf|ZIP(*.zip)|*.zip|Docx(*.docx)|*.docx"
            .Multiselect = False
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                txtDoc.Text = openFile.FileName
                TextBox1.Text = openFile.SafeFileName

            End If
        End With


    End Sub
End Class