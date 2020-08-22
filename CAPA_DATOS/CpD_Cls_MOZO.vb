Imports CAPA_ENTIDAD
Imports System.Data.SqlClient
Public Class CpD_Cls_MOZO
    Public dapprov As New SqlDataAdapter
    Public Function MOSTRAR_mozo(ByVal obj As CAPA_ENTIDAD.CpE_Cls_MOZO)
        Dim cn As New SqlConnection(cadena)
        Dim dtprov As New Data.DataTable
        Try
            cn.Open()
            dapprov.SelectCommand = cn.CreateCommand
            dapprov.SelectCommand.CommandText = "PA_ListarMozo"
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

    Public Sub REGISTRAR_mozo(ByVal obj As CAPA_ENTIDAD.CpE_Cls_MOZO)
        Dim cn As New SqlConnection(cadena)
        cn.Open()
        Try
            dapprov.InsertCommand = cn.CreateCommand
            dapprov.InsertCommand.CommandText = "PA_RegistrarMozo"
            dapprov.InsertCommand.CommandType = CommandType.StoredProcedure
            dapprov.InsertCommand.Parameters.AddWithValue("@rut", obj.ruc)
            dapprov.InsertCommand.Parameters.AddWithValue("@NomApe", obj.NombreCompañia)
            dapprov.InsertCommand.Parameters.AddWithValue("@telefono", obj.telefono)
            dapprov.InsertCommand.Parameters.AddWithValue("@direccion", obj.direccion)
            dapprov.InsertCommand.Parameters.AddWithValue("@observacion", obj.observacion)
            dapprov.InsertCommand.Parameters.AddWithValue("@estado", obj.Estado)
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

    Public Sub MODIFICAR_mozo(ByVal obj As CAPA_ENTIDAD.CpE_Cls_MOZO)
        Dim cn As New SqlConnection(cadena)
        Try
            cn.Open()
            dapprov.UpdateCommand = cn.CreateCommand
            dapprov.UpdateCommand.CommandText = "PA_EditarMozo"
            dapprov.UpdateCommand.CommandType = CommandType.StoredProcedure
            dapprov.UpdateCommand.Parameters.AddWithValue("@id", obj.idmozo)
            dapprov.UpdateCommand.Parameters.AddWithValue("@rut", obj.ruc)
            dapprov.UpdateCommand.Parameters.AddWithValue("@NomApe", obj.NombreCompañia)
            dapprov.UpdateCommand.Parameters.AddWithValue("@telefono", obj.telefono)
            dapprov.UpdateCommand.Parameters.AddWithValue("@direccion", obj.direccion)
            dapprov.UpdateCommand.Parameters.AddWithValue("@observacion", obj.observacion)
            dapprov.UpdateCommand.Parameters.AddWithValue("@estado", obj.Estado)
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
    Public Function BUSCAR_PROVEEDOR(ByVal obj As CAPA_ENTIDAD.CpE_Cls_PROVEEDOR)
        Dim cn As New SqlConnection(cadena)
        Dim dtprov As New Data.DataTable
        Try
            cn.Open()
            dapprov.SelectCommand = cn.CreateCommand
            dapprov.SelectCommand.CommandText = "PA_BuscarMozo"
            dapprov.SelectCommand.CommandType = CommandType.StoredProcedure
            dapprov.SelectCommand.Parameters.AddWithValue("@ruc", obj.ruc)
            dapprov.SelectCommand.Parameters.AddWithValue("@nomcompa", obj.NombreCompañia)
            dapprov.SelectCommand.Parameters.AddWithValue("@opcion", obj.opcion)
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
    Public Function MOSTRAR_mozo_ESTADO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_MOZO)
        Dim cn As New SqlConnection(cadena)
        Dim dtprov As New Data.DataTable
        Try
            cn.Open()
            dapprov.SelectCommand = cn.CreateCommand
            dapprov.SelectCommand.CommandText = "PA_ListarMozoEstado"
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
    Public Function BUSCAR_PROVEEDOR_ACTIVOS(ByVal obj As CAPA_ENTIDAD.CpE_Cls_PROVEEDOR)
        Dim cn As New SqlConnection(cadena)
        Dim dtprov As New Data.DataTable
        Try
            cn.Open()
            dapprov.SelectCommand = cn.CreateCommand
            dapprov.SelectCommand.CommandText = "PA_BuscarProveedorActivo"
            dapprov.SelectCommand.CommandType = CommandType.StoredProcedure
            dapprov.SelectCommand.Parameters.AddWithValue("@ruc", obj.ruc)
            dapprov.SelectCommand.Parameters.AddWithValue("@nomcompa", obj.NombreCompañia)
            dapprov.SelectCommand.Parameters.AddWithValue("@opcion", obj.opcion)
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
