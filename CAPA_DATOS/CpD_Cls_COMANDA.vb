Imports CAPA_ENTIDAD
Imports System.Data.SqlClient
Public Class CpD_Cls_COMANDA
    Public dapprov As New SqlDataAdapter
    Public Sub FAC_CAPTURAS(ByVal obj As CAPA_ENTIDAD.CpE_Cls_COMANDA)
        ' Dim cn As New SqlConnection(cadena)
        ' Dim cn As New SqlConnection(ConfigurationManager.ConnectionStrings("Guia_de_Remision.My.MySettings.Admin_ElcerpConnectionString").ToString())
        Dim cn As New SqlConnection(cadena)
        Try
            cn.Open()
            dapprov.SelectCommand = cn.CreateCommand
            dapprov.SelectCommand.CommandText = "CAPTURAR"

            dapprov.SelectCommand.CommandType = CommandType.StoredProcedure
            dapprov.SelectCommand.Parameters.AddWithValue("@ValorIngresado", obj.ValorIngresado)
            dapprov.SelectCommand.Parameters.AddWithValue("@OpcionCapturar", obj.OpcionCapturar)
            dapprov.SelectCommand.ExecuteNonQuery()
            obj.ValorSalida = dapprov.SelectCommand.ExecuteScalar()
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

    Public Sub REGISTRAR_COMANDA(ByVal obj As CAPA_ENTIDAD.CpE_Cls_COMANDA)
        Dim cn As New SqlConnection(cadena)
        cn.Open()
        Try
            dapprov.InsertCommand = cn.CreateCommand
            dapprov.InsertCommand.CommandText = "PA_RegistrarComanda"
            dapprov.InsertCommand.CommandType = CommandType.StoredProcedure
            dapprov.InsertCommand.Parameters.AddWithValue("@fecha", obj.fecha)
            dapprov.InsertCommand.Parameters.AddWithValue("@estado", obj.estado)
            dapprov.InsertCommand.Parameters.AddWithValue("@des", obj.descripcion)
            dapprov.InsertCommand.Parameters.AddWithValue("@descuento", obj.descuento)
            dapprov.InsertCommand.Parameters.AddWithValue("@monto", obj.monto)
            dapprov.InsertCommand.Parameters.AddWithValue("@idmesa", obj.idmesa)
            dapprov.InsertCommand.Parameters.AddWithValue("@idtipoDocumento", obj.idtipoDucu)
            dapprov.InsertCommand.Parameters.AddWithValue("@idcliente", obj.idcliente)
            dapprov.InsertCommand.Parameters.AddWithValue("@idMOZO", obj.idMOZO)
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

    Public Sub REGISTRAR_DETALLE_COMANDA_PRODUCTOS(ByVal obj As CAPA_ENTIDAD.CpE_Cls_COMANDA)
        Dim cn As New SqlConnection(cadena)
        cn.Open()
        Try
            dapprov.InsertCommand = cn.CreateCommand
            dapprov.InsertCommand.CommandText = "PA_RegistrarDetalleComandaProducto"
            dapprov.InsertCommand.CommandType = CommandType.StoredProcedure
            dapprov.InsertCommand.Parameters.AddWithValue("@idcomanda", obj.idcomanda)
            dapprov.InsertCommand.Parameters.AddWithValue("@idproducto", obj.idproducto)
            dapprov.InsertCommand.Parameters.AddWithValue("@canti", obj.cantidad)
            dapprov.InsertCommand.Parameters.AddWithValue("@importe", obj.importe)
            dapprov.InsertCommand.Parameters.AddWithValue("@notas", obj.notas)
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

    Public Sub REGISTRAR_DETALLE_COMANDA_PLATO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_COMANDA)
        Dim cn As New SqlConnection(cadena)
        cn.Open()
        Try
            dapprov.InsertCommand = cn.CreateCommand
            dapprov.InsertCommand.CommandText = "PA_RegistrarDetalleComandaPlato"
            dapprov.InsertCommand.CommandType = CommandType.StoredProcedure
            dapprov.InsertCommand.Parameters.AddWithValue("@idcomanda", obj.idcomanda)
            dapprov.InsertCommand.Parameters.AddWithValue("@idplato", obj.idplato)
            dapprov.InsertCommand.Parameters.AddWithValue("@canti", obj.cantidad)
            dapprov.InsertCommand.Parameters.AddWithValue("@importe", obj.importe)
            dapprov.InsertCommand.Parameters.AddWithValue("@notas", obj.notas)
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

    Public Sub MODIFICAR_COMANDA(ByVal obj As CAPA_ENTIDAD.CpE_Cls_COMANDA)
        Dim cn As New SqlConnection(cadena)
        Try
            cn.Open()
            dapprov.UpdateCommand = cn.CreateCommand
            dapprov.UpdateCommand.CommandText = "PA_EditarComanda"
            dapprov.UpdateCommand.CommandType = CommandType.StoredProcedure
            dapprov.UpdateCommand.Parameters.AddWithValue("@IdComanda", obj.idcomanda)
            dapprov.UpdateCommand.Parameters.AddWithValue("@fecha", obj.fecha)
            dapprov.UpdateCommand.Parameters.AddWithValue("@estado", obj.estado)
            dapprov.UpdateCommand.Parameters.AddWithValue("@DES", obj.descripcion)
            dapprov.UpdateCommand.Parameters.AddWithValue("@descuento", obj.descuento)
            dapprov.UpdateCommand.Parameters.AddWithValue("@MONTO", obj.monto)
            dapprov.UpdateCommand.Parameters.AddWithValue("@idmesa", obj.idmesa)
            dapprov.UpdateCommand.Parameters.AddWithValue("@idtipoDocumento", obj.idtipoDucu)
            dapprov.UpdateCommand.Parameters.AddWithValue("@idcliente", obj.idcliente)

            dapprov.UpdateCommand.Parameters.AddWithValue("@idMOZO", obj.idMOZO)
            dapprov.UpdateCommand.Parameters.AddWithValue("@NUMEROD", obj.NumeroD)
            dapprov.UpdateCommand.Parameters.AddWithValue("@NUMERO", obj.Numero)
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
    Public Sub MODIFICAR_DETALLE_COMANDA_PLATOS(ByVal obj As CAPA_ENTIDAD.CpE_Cls_COMANDA)
        Dim cn As New SqlConnection(cadena)
        Try
            cn.Open()
            dapprov.UpdateCommand = cn.CreateCommand
            dapprov.UpdateCommand.CommandText = "PA_EditarDetalleComandaPlatos"
            dapprov.UpdateCommand.CommandType = CommandType.StoredProcedure
            dapprov.UpdateCommand.Parameters.AddWithValue("@idplato", obj.idPlato)
            dapprov.UpdateCommand.Parameters.AddWithValue("@idcomanda", obj.idcomanda)
            dapprov.UpdateCommand.Parameters.AddWithValue("@cantidad", obj.cantidad)
            dapprov.UpdateCommand.Parameters.AddWithValue("@importe", obj.importe)
            dapprov.UpdateCommand.Parameters.AddWithValue("@notas", obj.notas)
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
    Public Sub MODIFICAR_DETALLE_COMANDA_PRODUCTOS(ByVal obj As CAPA_ENTIDAD.CpE_Cls_COMANDA)
        Dim cn As New SqlConnection(cadena)
        Try
            cn.Open()
            dapprov.UpdateCommand = cn.CreateCommand
            dapprov.UpdateCommand.CommandText = "PA_EditarDetalleComandaProductos"
            dapprov.UpdateCommand.CommandType = CommandType.StoredProcedure
            dapprov.UpdateCommand.Parameters.AddWithValue("@idproducto", obj.idproducto)
            dapprov.UpdateCommand.Parameters.AddWithValue("@idcomanda", obj.idcomanda)
            dapprov.UpdateCommand.Parameters.AddWithValue("@cantidad", obj.cantidad)
            dapprov.UpdateCommand.Parameters.AddWithValue("@importe", obj.importe)
            dapprov.UpdateCommand.Parameters.AddWithValue("@notas", obj.notas)
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

    Public Sub CAPTURA_CODIGO_COMANDA(ByVal obj As CAPA_ENTIDAD.CpE_Cls_COMANDA)
        Dim cn As New SqlConnection(cadena)
        Try
            cn.Open()
            dapprov.SelectCommand = cn.CreateCommand
            dapprov.SelectCommand.CommandText = "PA_CapturarCodigoComanda"
            dapprov.SelectCommand.CommandType = CommandType.StoredProcedure
            dapprov.SelectCommand.ExecuteNonQuery()
            obj.idcomanda = dapprov.SelectCommand.ExecuteScalar()
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
    Public Sub AGREGAR_DETALLE_COMANDA_PLATO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_COMANDA)
        Dim cn As New SqlConnection(cadena)
        cn.Open()
        Try
            dapprov.InsertCommand = cn.CreateCommand
            dapprov.InsertCommand.CommandText = "PA_AgregarDetalleComandaPlatos"
            dapprov.InsertCommand.CommandType = CommandType.StoredProcedure
            dapprov.InsertCommand.Parameters.AddWithValue("@idcomanda", obj.idcomanda)
            dapprov.InsertCommand.Parameters.AddWithValue("@idplato", obj.idplato)
            dapprov.InsertCommand.Parameters.AddWithValue("@cantidad", obj.cantidad)
            dapprov.InsertCommand.Parameters.AddWithValue("@importe", obj.importe)
            dapprov.InsertCommand.Parameters.AddWithValue("@notas", obj.notas)
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
    Public Sub AGREGAR_DETALLE_COMANDA_PRODUCTO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_COMANDA)
        Dim cn As New SqlConnection(cadena)
        cn.Open()
        Try
            dapprov.InsertCommand = cn.CreateCommand
            dapprov.InsertCommand.CommandText = "PA_AgregarDetalleComandaProductos"
            dapprov.InsertCommand.CommandType = CommandType.StoredProcedure
            dapprov.InsertCommand.Parameters.AddWithValue("@idcomanda", obj.idcomanda)
            dapprov.InsertCommand.Parameters.AddWithValue("@idproducto", obj.idproducto)
            dapprov.InsertCommand.Parameters.AddWithValue("@cantidad", obj.cantidad)
            dapprov.InsertCommand.Parameters.AddWithValue("@importe", obj.importe)
            dapprov.InsertCommand.Parameters.AddWithValue("@notas", obj.notas)
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

    Public Sub ELIMINAR_DETALLE_COMANDA_PRODUCTO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_COMANDA)
        Dim cn As New SqlConnection(cadena)
        cn.Open()
        Try
            dapprov.DeleteCommand = cn.CreateCommand
            dapprov.DeleteCommand.CommandText = "PA_EliminarDetalleComandaProducto"
            dapprov.DeleteCommand.CommandType = CommandType.StoredProcedure
            dapprov.DeleteCommand.Parameters.AddWithValue("@idcomanda", obj.idcomanda)
            dapprov.DeleteCommand.Parameters.AddWithValue("@idproducto", obj.idproducto)
            dapprov.DeleteCommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw New Exception(ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
                cn.Dispose()
            End If
        End Try
    End Sub

    Public Sub ELIMINAR_DETALLE_COMANDA_PLATO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_COMANDA)
        Dim cn As New SqlConnection(cadena)
        cn.Open()
        Try
            dapprov.DeleteCommand = cn.CreateCommand
            dapprov.DeleteCommand.CommandText = "PA_EliminarDetalleComandaPlato"
            dapprov.DeleteCommand.CommandType = CommandType.StoredProcedure
            dapprov.DeleteCommand.Parameters.AddWithValue("@idcomanda", obj.idcomanda)
            dapprov.DeleteCommand.Parameters.AddWithValue("@idplato", obj.idplato)
            dapprov.DeleteCommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw New Exception(ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
                cn.Dispose()
            End If
        End Try
    End Sub
End Class
