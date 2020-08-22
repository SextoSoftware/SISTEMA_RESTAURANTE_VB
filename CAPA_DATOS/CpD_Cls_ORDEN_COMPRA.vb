Imports CAPA_ENTIDAD
Imports System.Data.SqlClient
Public Class CpD_Cls_ORDEN_COMPRA
    Public dapprov As New SqlDataAdapter
    Public Sub REGISTRAR_ORDEN_COMPRA(ByVal obj As CAPA_ENTIDAD.CpE_Cls_ORDEN_COMPRA)
        Dim cn As New SqlConnection(cadena)
        cn.Open()
        Try
            dapprov.InsertCommand = cn.CreateCommand
            dapprov.InsertCommand.CommandText = "PA_RegistrarOrdenCompra"
            dapprov.InsertCommand.CommandType = CommandType.StoredProcedure
            ' dapprov.InsertCommand.Parameters.AddWithValue("@fecha", obj.fecha)
            dapprov.InsertCommand.Parameters.AddWithValue("@estado", obj.Estado)
            dapprov.InsertCommand.Parameters.AddWithValue("@idprove", obj.idproveedor)
            dapprov.InsertCommand.Parameters.AddWithValue("@des", obj.descripcion)
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

    Public Sub REGISTRAR_DETALLE_ORDEN_COMPRA(ByVal obj As CAPA_ENTIDAD.CpE_Cls_ORDEN_COMPRA)
        Dim cn As New SqlConnection(cadena)
        cn.Open()
        Try
            dapprov.InsertCommand = cn.CreateCommand
            dapprov.InsertCommand.CommandText = "PA_RegistrarDetalleOrdenCompra"
            dapprov.InsertCommand.CommandType = CommandType.StoredProcedure
            dapprov.InsertCommand.Parameters.AddWithValue("@idorden", obj.idOrdenCompra)
            dapprov.InsertCommand.Parameters.AddWithValue("@cantidad", obj.cantidad)
            dapprov.InsertCommand.Parameters.AddWithValue("@estado", obj.estadoPro)
            dapprov.InsertCommand.Parameters.AddWithValue("@idpro", obj.idproducto)
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

    Public Sub CAPTURA_CODIGO_ORDEN_COMPRA(ByVal obj As CAPA_ENTIDAD.CpE_Cls_ORDEN_COMPRA)
        Dim cn As New SqlConnection(cadena)
        Try
            cn.Open()
            dapprov.SelectCommand = cn.CreateCommand
            dapprov.SelectCommand.CommandText = "PA_CapturarCodigoOrdenCompra"
            dapprov.SelectCommand.CommandType = CommandType.StoredProcedure
            dapprov.SelectCommand.ExecuteNonQuery()
            obj.idOrdenCompra = dapprov.SelectCommand.ExecuteScalar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Question)
            ' Throw New Exception(ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Dispose()
                cn.Close()
            End If
        End Try
    End Sub
End Class
