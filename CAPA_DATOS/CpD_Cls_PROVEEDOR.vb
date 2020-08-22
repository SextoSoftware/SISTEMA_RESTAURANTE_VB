Imports CAPA_ENTIDAD
Imports System.Data.SqlClient
Public Class CpD_Cls_PROVEEDOR
    Public dapprov As New SqlDataAdapter
    Public Function MOSTRAR_PROVEEDORES(ByVal obj As CAPA_ENTIDAD.CpE_Cls_PROVEEDOR)
        Dim cn As New SqlConnection(cadena)
        Dim dtprov As New Data.DataTable
        Try
            cn.Open()
            dapprov.SelectCommand = cn.CreateCommand
            dapprov.SelectCommand.CommandText = "PA_ListarProveedor"
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

    Public Sub REGISTRAR_PROVEEDOR(ByVal obj As CAPA_ENTIDAD.CpE_Cls_PROVEEDOR)
        Dim cn As New SqlConnection(cadena)
        cn.Open()
        Try
            dapprov.InsertCommand = cn.CreateCommand
            dapprov.InsertCommand.CommandText = "PA_RegistrarProveedor"
            dapprov.InsertCommand.CommandType = CommandType.StoredProcedure
            dapprov.InsertCommand.Parameters.AddWithValue("@nomcompa", obj.NombreCompañia)
            dapprov.InsertCommand.Parameters.AddWithValue("@nomcomtac", obj.NombreContacto)
            dapprov.InsertCommand.Parameters.AddWithValue("@ruc", obj.ruc)
            dapprov.InsertCommand.Parameters.AddWithValue("@tele", obj.telefono)
            dapprov.InsertCommand.Parameters.AddWithValue("@dire", obj.direccion)
            dapprov.InsertCommand.Parameters.AddWithValue("@email", obj.Email)
            dapprov.InsertCommand.Parameters.AddWithValue("@esta", obj.Estado)
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

    Public Sub MODIFICAR_PROVEEDOR(ByVal obj As CAPA_ENTIDAD.CpE_Cls_PROVEEDOR)
        Dim cn As New SqlConnection(cadena)
        Try
            cn.Open()
            dapprov.UpdateCommand = cn.CreateCommand
            dapprov.UpdateCommand.CommandText = "PA_EditarProveedor"
            dapprov.UpdateCommand.CommandType = CommandType.StoredProcedure
            dapprov.UpdateCommand.Parameters.AddWithValue("@id", obj.idproveedor)
            dapprov.UpdateCommand.Parameters.AddWithValue("@nomcompa", obj.NombreCompañia)
            dapprov.UpdateCommand.Parameters.AddWithValue("@nomcontac", obj.NombreContacto)
            dapprov.UpdateCommand.Parameters.AddWithValue("@ruc", obj.ruc)
            dapprov.UpdateCommand.Parameters.AddWithValue("@tele", obj.telefono)
            dapprov.UpdateCommand.Parameters.AddWithValue("@dire", obj.direccion)
            dapprov.UpdateCommand.Parameters.AddWithValue("@email", obj.Email)
            dapprov.UpdateCommand.Parameters.AddWithValue("@esta", obj.Estado)
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
            dapprov.SelectCommand.CommandText = "PA_BuscarProveedor"
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
    Public Function MOSTRAR_PROVEEDORES_ESTADO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_PROVEEDOR)
        Dim cn As New SqlConnection(cadena)
        Dim dtprov As New Data.DataTable
        Try
            cn.Open()
            dapprov.SelectCommand = cn.CreateCommand
            dapprov.SelectCommand.CommandText = "PA_ListarProveedorEstado"
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
