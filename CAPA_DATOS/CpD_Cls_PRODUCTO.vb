Imports CAPA_ENTIDAD
Imports System.Data.SqlClient
Public Class CpD_Cls_PRODUCTO
    Public dapprov As New SqlDataAdapter

    Public Function MOSTRAR_PRODCUTO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_PRODUCTO)
        Dim cn As New SqlConnection(cadena)
        Dim dtprov As New Data.DataTable
        Try
            cn.Open()
            dapprov.SelectCommand = cn.CreateCommand
            dapprov.SelectCommand.CommandText = "PA_ListarProducto"
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
    Public Function MOSTRAR_PRODUCTO_ESTADO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_PRODUCTO)
        Dim cn As New SqlConnection(cadena)
        Dim dtprov As New Data.DataTable
        Try
            cn.Open()
            dapprov.SelectCommand = cn.CreateCommand
            dapprov.SelectCommand.CommandText = "PA_ListarProductoEstado"
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

    Public Sub REGISTRAR_PRODUCTO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_PRODUCTO)
        Dim cn As New SqlConnection(cadena)
        cn.Open()
        Try
            dapprov.InsertCommand = cn.CreateCommand
            dapprov.InsertCommand.CommandText = "PA_RegistrarProducto"
            dapprov.InsertCommand.CommandType = CommandType.StoredProcedure
            dapprov.InsertCommand.Parameters.AddWithValue("@nom", obj.Nombre)
            dapprov.InsertCommand.Parameters.AddWithValue("@des", obj.descripcion)
            dapprov.InsertCommand.Parameters.AddWithValue("@precio", obj.precio)
            dapprov.InsertCommand.Parameters.AddWithValue("@medida", obj.medida)
            dapprov.InsertCommand.Parameters.AddWithValue("@cantunidad", obj.cantiunidad)
            dapprov.InsertCommand.Parameters.AddWithValue("@stock", obj.stock)
            dapprov.InsertCommand.Parameters.AddWithValue("@esta", obj.Estado)
            dapprov.InsertCommand.Parameters.AddWithValue("@idtipo", obj.idtipo)
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
    Public Sub MODIFICAR_PRODUCTO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_PRODUCTO)
        Dim cn As New SqlConnection(cadena)
        Try
            cn.Open()
            dapprov.UpdateCommand = cn.CreateCommand
            dapprov.UpdateCommand.CommandText = "PA_EditarProducto"
            dapprov.UpdateCommand.CommandType = CommandType.StoredProcedure
            dapprov.UpdateCommand.Parameters.AddWithValue("@id", obj.idproducto)
            dapprov.UpdateCommand.Parameters.AddWithValue("@nom", obj.Nombre)
            dapprov.UpdateCommand.Parameters.AddWithValue("@des", obj.descripcion)
            dapprov.UpdateCommand.Parameters.AddWithValue("@precio", obj.precio)
            dapprov.UpdateCommand.Parameters.AddWithValue("@medida", obj.medida)
            dapprov.UpdateCommand.Parameters.AddWithValue("@cantunidad", obj.cantiunidad)
            dapprov.UpdateCommand.Parameters.AddWithValue("@stock", obj.stock)
            dapprov.UpdateCommand.Parameters.AddWithValue("@esta", obj.Estado)
            dapprov.UpdateCommand.Parameters.AddWithValue("@idtipo", obj.idtipo)
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

    Public Function BUSCAR_PRODUCTO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_PRODUCTO)
        Dim cn As New SqlConnection(cadena)
        Dim dtprov As New Data.DataTable
        Try
            cn.Open()
            dapprov.SelectCommand = cn.CreateCommand
            dapprov.SelectCommand.CommandText = "PA_BuscarProducto"
            dapprov.SelectCommand.CommandType = CommandType.StoredProcedure
            dapprov.SelectCommand.Parameters.AddWithValue("@nom", obj.Nombre)
            dapprov.SelectCommand.Parameters.AddWithValue("@tipo", obj.Nombre)
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
    Public Function BUSCAR_PRODUCTOS_ACTIVOS(ByVal obj As CAPA_ENTIDAD.CpE_Cls_PRODUCTO)
        Dim cn As New SqlConnection(cadena)
        Dim dtprov As New Data.DataTable
        Try
            cn.Open()
            dapprov.SelectCommand = cn.CreateCommand
            dapprov.SelectCommand.CommandText = "PA_BuscarProductoActivo"
            dapprov.SelectCommand.CommandType = CommandType.StoredProcedure
            dapprov.SelectCommand.Parameters.AddWithValue("@nom", obj.Nombre)
            dapprov.SelectCommand.Parameters.AddWithValue("@tipo", obj.Nombre)
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

    Public Sub MODIFICAR_STOCK_PRODUCTO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_PRODUCTO)
        Dim cn As New SqlConnection(cadena)
        Try
            cn.Open()
            dapprov.UpdateCommand = cn.CreateCommand
            dapprov.UpdateCommand.CommandText = "PA_EditaStockProducto"
            dapprov.UpdateCommand.CommandType = CommandType.StoredProcedure
            dapprov.UpdateCommand.Parameters.AddWithValue("@id", obj.idproducto)
            dapprov.UpdateCommand.Parameters.AddWithValue("@stocktotal", obj.stock)
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
End Class
