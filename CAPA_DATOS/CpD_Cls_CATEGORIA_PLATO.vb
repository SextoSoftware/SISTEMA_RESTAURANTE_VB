﻿Imports CAPA_ENTIDAD
Imports System.Data.SqlClient
Public Class CpD_Cls_CATEGORIA_PLATO
    Public dapprov As New SqlDataAdapter

    Public Function MOSTRAR_CATEGORIA_PLATO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_CATEGORIA_PLATO)
        Dim cn As New SqlConnection(cadena)
        Dim dtprov As New Data.DataTable
        Try
            cn.Open()
            dapprov.SelectCommand = cn.CreateCommand
            dapprov.SelectCommand.CommandText = "PA_ListarCategoriaPlato"
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
    Public Function MOSTRAR_CATEGORIA_PLATO_ACTIVO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_CATEGORIA_PLATO)
        Dim cn As New SqlConnection(cadena)
        Dim dtprov As New Data.DataTable
        Try
            cn.Open()
            dapprov.SelectCommand = cn.CreateCommand
            dapprov.SelectCommand.CommandText = "PA_ListarCategoriaPlatoActivo"
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

    Public Sub REGISTRAR_CATEGORIA_PLATO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_CATEGORIA_PLATO)
        Dim cn As New SqlConnection(cadena)
        cn.Open()
        Try
            dapprov.InsertCommand = cn.CreateCommand
            dapprov.InsertCommand.CommandText = "PA_RegistrarCategoriaPlato"
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

    Public Sub MODIFICAR_CATEGORIA_PLATO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_CATEGORIA_PLATO)
        Dim cn As New SqlConnection(cadena)
        Try
            cn.Open()
            dapprov.UpdateCommand = cn.CreateCommand
            dapprov.UpdateCommand.CommandText = "PA_EditarCategoriaPlato"
            dapprov.UpdateCommand.CommandType = CommandType.StoredProcedure
            dapprov.UpdateCommand.Parameters.AddWithValue("@id", obj.idcate)
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
    Public Function BUSCAR_CATEGORIA_PLATO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_CATEGORIA_PLATO)
        Dim cn As New SqlConnection(cadena)
        Dim dtprov As New Data.DataTable
        Try
            cn.Open()
            dapprov.SelectCommand = cn.CreateCommand
            dapprov.SelectCommand.CommandText = "PA_BuscarCategoriaPlato"
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
