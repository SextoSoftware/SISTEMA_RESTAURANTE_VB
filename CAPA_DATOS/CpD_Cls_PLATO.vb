Imports CAPA_ENTIDAD
Imports System.Data.SqlClient
Public Class CpD_Cls_PLATO
    Public dapprov As New SqlDataAdapter

    Public Function MOSTRAR_PLATO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_PLATO)
        Dim cn As New SqlConnection(cadena)
        Dim dtprov As New Data.DataTable
        Try
            cn.Open()
            dapprov.SelectCommand = cn.CreateCommand
            dapprov.SelectCommand.CommandText = "PA_ListarPlato"
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
    Public Function MOSTRAR_PLATO_ESTADO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_PLATO)
        Dim cn As New SqlConnection(cadena)
        Dim dtprov As New Data.DataTable
        Try
            cn.Open()
            dapprov.SelectCommand = cn.CreateCommand
            dapprov.SelectCommand.CommandText = "PA_ListarPlatoEstado"
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

    Public Sub REGISTRAR_PLATO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_PLATO)
        Dim cn As New SqlConnection(cadena)
        cn.Open()
        Try
            dapprov.InsertCommand = cn.CreateCommand
            dapprov.InsertCommand.CommandText = "PA_RegistrarPlato"
            dapprov.InsertCommand.CommandType = CommandType.StoredProcedure
            dapprov.InsertCommand.Parameters.AddWithValue("@nom", obj.Nombre)
            dapprov.InsertCommand.Parameters.AddWithValue("@des", obj.descripcion)
            dapprov.InsertCommand.Parameters.AddWithValue("@precio", obj.precio)
            dapprov.InsertCommand.Parameters.AddWithValue("@esta", obj.Estado)
            dapprov.InsertCommand.Parameters.AddWithValue("@idcate", obj.idcate)
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
    Public Sub MODIFICAR_PLATO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_PLATO)
        Dim cn As New SqlConnection(cadena)
        Try
            cn.Open()
            dapprov.UpdateCommand = cn.CreateCommand
            dapprov.UpdateCommand.CommandText = "PA_EditarPlato"
            dapprov.UpdateCommand.CommandType = CommandType.StoredProcedure
            dapprov.UpdateCommand.Parameters.AddWithValue("@id", obj.idplato)
            dapprov.UpdateCommand.Parameters.AddWithValue("@nom", obj.Nombre)
            dapprov.UpdateCommand.Parameters.AddWithValue("@des", obj.descripcion)
            dapprov.UpdateCommand.Parameters.AddWithValue("@precio", obj.precio)
            dapprov.UpdateCommand.Parameters.AddWithValue("@esta", obj.Estado)
            dapprov.UpdateCommand.Parameters.AddWithValue("@idcate", obj.idcate)
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

    Public Function BUSCAR_PLATO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_PLATO)
        Dim cn As New SqlConnection(cadena)
        Dim dtprov As New Data.DataTable
        Try
            cn.Open()
            dapprov.SelectCommand = cn.CreateCommand
            dapprov.SelectCommand.CommandText = "PA_BuscarPlato"
            dapprov.SelectCommand.CommandType = CommandType.StoredProcedure
            dapprov.SelectCommand.Parameters.AddWithValue("@nom", obj.Nombre)
            dapprov.SelectCommand.Parameters.AddWithValue("@cate", obj.Nombre)
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
    Public Function BUSCAR_PLATO_ACTIVOS(ByVal obj As CAPA_ENTIDAD.CpE_Cls_PLATO)
        Dim cn As New SqlConnection(cadena)
        Dim dtprov As New Data.DataTable
        Try
            cn.Open()
            dapprov.SelectCommand = cn.CreateCommand
            dapprov.SelectCommand.CommandText = "PA_BuscarPlatoActivo"
            dapprov.SelectCommand.CommandType = CommandType.StoredProcedure
            dapprov.SelectCommand.Parameters.AddWithValue("@nom", obj.Nombre)
            dapprov.SelectCommand.Parameters.AddWithValue("@cate", obj.Nombre)
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
