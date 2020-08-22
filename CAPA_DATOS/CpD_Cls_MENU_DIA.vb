Imports CAPA_ENTIDAD
Imports System.Data.SqlClient
Public Class CpD_Cls_MENU_DIA
    Public dapprov As New SqlDataAdapter
    Public Function MOSTRAR_MENU_DIA(ByVal obj As CAPA_ENTIDAD.CpE_Cls_MENU_DIA)
        Dim cn As New SqlConnection(cadena)
        Dim dtprov As New Data.DataTable
        Try
            cn.Open()
            dapprov.SelectCommand = cn.CreateCommand
            dapprov.SelectCommand.CommandText = "PA_ListarMenu"
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

    Public Function MOSTRAR_MENU_DIA_ACTIVO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_MENU_DIA)
        Dim cn As New SqlConnection(cadena)
        Dim dtprov As New Data.DataTable
        Try
            cn.Open()
            dapprov.SelectCommand = cn.CreateCommand
            dapprov.SelectCommand.CommandText = "PA_ListarMenuActivo"
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

    Public Sub REGISTRAR_MENU_DIA(ByVal obj As CAPA_ENTIDAD.CpE_Cls_MENU_DIA)
        Dim cn As New SqlConnection(cadena)
        cn.Open()
        Try
            dapprov.InsertCommand = cn.CreateCommand
            dapprov.InsertCommand.CommandText = "PA_RegistrarMenu"
            dapprov.InsertCommand.CommandType = CommandType.StoredProcedure
            dapprov.InsertCommand.Parameters.AddWithValue("@nom", obj.Nombre)
            dapprov.InsertCommand.Parameters.AddWithValue("@des", obj.descripcion)
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

    Public Sub REGISTRAR_DETALLE_MENU(ByVal obj As CAPA_ENTIDAD.CpE_Cls_MENU_DIA)
        Dim cn As New SqlConnection(cadena)
        cn.Open()
        Try
            dapprov.InsertCommand = cn.CreateCommand
            dapprov.InsertCommand.CommandText = "PA_RegistrarDetalleMenu"
            dapprov.InsertCommand.CommandType = CommandType.StoredProcedure
            dapprov.InsertCommand.Parameters.AddWithValue("@idMENU", obj.idMenu)
            dapprov.InsertCommand.Parameters.AddWithValue("@idplato", obj.idPlato)
            dapprov.InsertCommand.Parameters.AddWithValue("@canti", obj.cantidad)
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

    Public Sub MODIFICAR_MENU(ByVal obj As CAPA_ENTIDAD.CpE_Cls_MENU_DIA)
        Dim cn As New SqlConnection(cadena)
        Try
            cn.Open()
            dapprov.UpdateCommand = cn.CreateCommand
            dapprov.UpdateCommand.CommandText = "PA_EditarMenu"
            dapprov.UpdateCommand.CommandType = CommandType.StoredProcedure
            dapprov.UpdateCommand.Parameters.AddWithValue("@Idmenu", obj.idMenu)
            dapprov.UpdateCommand.Parameters.AddWithValue("@nombre", obj.Nombre)
            dapprov.UpdateCommand.Parameters.AddWithValue("@DES", obj.descripcion)
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

    Public Sub MODIFICAR_DETALLE_MENU(ByVal obj As CAPA_ENTIDAD.CpE_Cls_MENU_DIA)
        Dim cn As New SqlConnection(cadena)
        Try
            cn.Open()
            dapprov.UpdateCommand = cn.CreateCommand
            dapprov.UpdateCommand.CommandText = "PA_EditarDetalleMenu"
            dapprov.UpdateCommand.CommandType = CommandType.StoredProcedure
            dapprov.UpdateCommand.Parameters.AddWithValue("@idplato", obj.idPlato)
            dapprov.UpdateCommand.Parameters.AddWithValue("@idmenu", obj.idMenu)
            dapprov.UpdateCommand.Parameters.AddWithValue("@cantidad", obj.cantidad)
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
    Public Function BUSCAR_MENU(ByVal obj As CAPA_ENTIDAD.CpE_Cls_MENU_DIA)
        Dim cn As New SqlConnection(cadena)
        Dim dtprov As New Data.DataTable
        Try
            cn.Open()
            dapprov.SelectCommand = cn.CreateCommand
            dapprov.SelectCommand.CommandText = "PA_BuscarMenu"
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


    Public Sub CAPTURA_CODIGO_MENU_DIA(ByVal obj As CAPA_ENTIDAD.CpE_Cls_MENU_DIA)
        Dim cn As New SqlConnection(cadena)
        Try
            cn.Open()
            dapprov.SelectCommand = cn.CreateCommand
            dapprov.SelectCommand.CommandText = "PA_CapturarCodigoMenuDia"
            dapprov.SelectCommand.CommandType = CommandType.StoredProcedure
            dapprov.SelectCommand.ExecuteNonQuery()
            obj.idMenu = dapprov.SelectCommand.ExecuteScalar()
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

    Public Sub CAPTURA_CANTIDAD_ESTADO_ACTIVADO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_MENU_DIA)
        Dim cn As New SqlConnection(cadena)
        Try
            cn.Open()
            dapprov.SelectCommand = cn.CreateCommand
            dapprov.SelectCommand.CommandText = "PA_CapturarCantidadEstadoMenu"
            dapprov.SelectCommand.CommandType = CommandType.StoredProcedure
            dapprov.SelectCommand.ExecuteNonQuery()
            obj.CantActivo = dapprov.SelectCommand.ExecuteScalar()
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
    Public Sub MODIFICAR_MENU_CANTDIDAD(ByVal obj As CAPA_ENTIDAD.CpE_Cls_MENU_DIA)
        Dim cn As New SqlConnection(cadena)
        Try
            cn.Open()
            dapprov.UpdateCommand = cn.CreateCommand
            dapprov.UpdateCommand.CommandText = "PA_EditaStockMenuPlato"
            dapprov.UpdateCommand.CommandType = CommandType.StoredProcedure
            dapprov.UpdateCommand.Parameters.AddWithValue("@Id", obj.idPlato)
            dapprov.UpdateCommand.Parameters.AddWithValue("@stocktotal", obj.cantidad)
            dapprov.UpdateCommand.Parameters.AddWithValue("@idmenu", obj.idMenu)
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
