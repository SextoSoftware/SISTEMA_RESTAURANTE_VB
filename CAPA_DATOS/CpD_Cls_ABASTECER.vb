Imports CAPA_ENTIDAD
Imports System.Data.SqlClient
Public Class CpD_Cls_ABASTECER
    Public dapprov As New SqlDataAdapter
    Public Sub REGISTRAR_ABASTECER(ByVal obj As CAPA_ENTIDAD.CpE_Cls_ABASTECER)
        Dim cn As New SqlConnection(cadena)
        cn.Open()
        Try
            dapprov.InsertCommand = cn.CreateCommand
            dapprov.InsertCommand.CommandText = "PA_RegistrarAbastece"
            dapprov.InsertCommand.CommandType = CommandType.StoredProcedure
            dapprov.InsertCommand.Parameters.AddWithValue("@idproveedor", obj.idproveedor)
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

    Public Sub REGISTRAR_DETALLE_ABASTECER(ByVal obj As CAPA_ENTIDAD.CpE_Cls_ABASTECER)
        Dim cn As New SqlConnection(cadena)
        cn.Open()
        Try
            dapprov.InsertCommand = cn.CreateCommand
            dapprov.InsertCommand.CommandText = "PA_RegistrarDetalleAbastecer"
            dapprov.InsertCommand.CommandType = CommandType.StoredProcedure
            dapprov.InsertCommand.Parameters.AddWithValue("@Idabastecer", obj.idAbastece)
            dapprov.InsertCommand.Parameters.AddWithValue("@idproducto", obj.idProducto)
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
    Public Sub CAPTURA_CODIGO_ABASTECER(ByVal obj As CAPA_ENTIDAD.CpE_Cls_ABASTECER)
        Dim cn As New SqlConnection(cadena)
        Try
            cn.Open()
            dapprov.SelectCommand = cn.CreateCommand
            dapprov.SelectCommand.CommandText = "PA_CapturarCodigoAbastecer"
            dapprov.SelectCommand.CommandType = CommandType.StoredProcedure
            dapprov.SelectCommand.ExecuteNonQuery()
            obj.idAbastece = dapprov.SelectCommand.ExecuteScalar()
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
    Public Function MOSTRAR_PRODUCTO_ABASTECE_PROVEEDOR(ByVal obj As CAPA_ENTIDAD.CpE_Cls_ABASTECER)
        Dim cn As New SqlConnection(cadena)
        Dim dtprov As New Data.DataTable
        Try
            cn.Open()
            dapprov.SelectCommand = cn.CreateCommand
            dapprov.SelectCommand.CommandText = "PA_ListarAbasteceProveedor"
            dapprov.SelectCommand.CommandType = CommandType.StoredProcedure
            dapprov.SelectCommand.Parameters.AddWithValue("@idproveedor", obj.idproveedor)
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
