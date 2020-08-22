Imports CAPA_ENTIDAD
Imports System.Data.SqlClient
Public Class CpD_Cls_MESA
    Public dapprov As New SqlDataAdapter
    Public Function MOSTRAR_MESA(ByVal obj As CAPA_ENTIDAD.CpE_Cls_MESA)
        Dim cn As New SqlConnection(cadena)
        Dim dtprov As New Data.DataTable
        Try
            cn.Open()
            dapprov.SelectCommand = cn.CreateCommand
            dapprov.SelectCommand.CommandText = "PA_ListarMesa"
            dapprov.SelectCommand.CommandType = CommandType.StoredProcedure
            dapprov.SelectCommand.ExecuteNonQuery()
            dapprov.Fill(dtprov)
            Return dtprov
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw New Exception(ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Dispose()
                cn.Close()
            End If
        End Try
    End Function
    Public Function MOSTRAR_ACTIVAS_OCUPADAS(ByVal obj As CAPA_ENTIDAD.CpE_Cls_MESA)
        Dim cn As New SqlConnection(cadena)
        Dim dtprov As New Data.DataTable
        Try
            cn.Open()
            dapprov.SelectCommand = cn.CreateCommand
            dapprov.SelectCommand.CommandText = "PA_ActivarMesasOcupadas"
            dapprov.SelectCommand.CommandType = CommandType.StoredProcedure
            dapprov.SelectCommand.ExecuteNonQuery()
            dapprov.Fill(dtprov)
            Return dtprov
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw New Exception(ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Dispose()
                cn.Close()
            End If
        End Try
    End Function
    Public Sub REGISTRAR_MESA(ByVal obj As CAPA_ENTIDAD.CpE_Cls_MESA)
        Dim cn As New SqlConnection(cadena)
        cn.Open()
        Try
            dapprov.InsertCommand = cn.CreateCommand
            dapprov.InsertCommand.CommandText = "PA_RegistrarMesa"
            dapprov.InsertCommand.CommandType = CommandType.StoredProcedure
            dapprov.InsertCommand.Parameters.AddWithValue("@nom", obj.Nombre)
            dapprov.InsertCommand.Parameters.AddWithValue("@estado", obj.estado)
            dapprov.InsertCommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
            'Throw New Exception(ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
                cn.Dispose()
            End If
        End Try
    End Sub

    Public Sub MODIFICAR_MESA(ByVal obj As CAPA_ENTIDAD.CpE_Cls_MESA)
        Dim cn As New SqlConnection(cadena)
        Try
            cn.Open()
            dapprov.UpdateCommand = cn.CreateCommand
            dapprov.UpdateCommand.CommandText = "PA_EditarMesa"
            dapprov.UpdateCommand.CommandType = CommandType.StoredProcedure
            dapprov.UpdateCommand.Parameters.AddWithValue("@id", obj.idmesa)
            dapprov.UpdateCommand.Parameters.AddWithValue("@nom", obj.Nombre)
            dapprov.UpdateCommand.Parameters.AddWithValue("@estado", obj.estado)
            dapprov.UpdateCommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
            'Throw New Exception(ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Dispose()
                cn.Close()
            End If
        End Try
    End Sub
    Public Function BUSCAR_TIPO_PRODUCTO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_TIPO_PRODUCTO)
        Dim cn As New SqlConnection(cadena)
        Dim dtprov As New Data.DataTable
        Try
            cn.Open()
            dapprov.SelectCommand = cn.CreateCommand
            dapprov.SelectCommand.CommandText = "PA_BuscarTipoProducto"
            dapprov.SelectCommand.CommandType = CommandType.StoredProcedure
            dapprov.SelectCommand.Parameters.AddWithValue("@nom", obj.Nombre)
            dapprov.SelectCommand.ExecuteNonQuery()
            dapprov.Fill(dtprov)
            Return dtprov
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw New Exception(ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Dispose()
                cn.Close()
            End If
        End Try
    End Function
End Class
