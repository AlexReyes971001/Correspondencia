Imports System.Data.SqlClient

Module Conexion
    Public Con As New SqlConnection
    Public Dt As New DataTable
    Public Da As New SqlDataAdapter
    Public Ds As New DataSet
    Public Cmd As New SqlCommand
    Public dr As SqlDataReader



    Public strWhere, valorBuscado, listaProveedor

    Public Sub Conectar()
        Try
            Con = New SqlConnection("Data Source=CONTROLPATRIMON\SQLEXPRESS ; Initial Catalog=Correspondencia ; user id=sa ; password=Wow.123qwe")
            Con.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Desconectar()
        Try
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub actualizarInformacion()
        Try
            Conectar()
            Cmd = New SqlCommand
            Cmd.Connection = Con
            Cmd.CommandText = strWhere
            Cmd.ExecuteNonQuery()
            Desconectar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub actualizarInformacionBytes()
        Try
            Conectar()
            Cmd.Connection = Con
            Cmd.CommandText = strWhere
            Cmd.ExecuteNonQuery()
            Desconectar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub ConsultarInformacion()
        Try
            Conectar()
            With Cmd
                .CommandType = CommandType.Text
                .CommandText = strWhere
                .Connection = Con
            End With
            Da.SelectCommand = Cmd
            Dt = New DataTable
            Da.Fill(Dt)
            Desconectar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
   

    
    Public Sub formatoGrid(ByVal GridFormateado As DataGridView)
        With GridFormateado
            .RowsDefaultCellStyle.BackColor = Color.Gray
            .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        End With
    End Sub
    Public Function BuscarValor(ByVal Consulta As String)
        valorBuscado = Nothing
        strWhere = Consulta
        ConsultarInformacion()
        For Each row As DataRow In Dt.Rows
            valorBuscado = row(0).ToString
        Next
        Return valorBuscado
    End Function

    Public Function SqlCommand(ByVal cadenasql As String) As SqlDataReader
        Try
            Conectar()
            Cmd = New SqlCommand
            With Cmd
                .CommandText = cadenasql
                .CommandType = CommandType.Text
                .Connection = Con
            End With
            Return Cmd.ExecuteReader()
            Desconectar()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function


    

End Module
