Imports CAPA_ENTIDAD
Imports System.Data.SqlClient
Public Class CpD_Cls_CLIENTE
    Public dapprov As New SqlDataAdapter
    Public Function MOSTRAR_CLIENTE_NATURAL(ByVal obj As CAPA_ENTIDAD.CpE_Cls_CLIENTE)
        Dim cn As New SqlConnection(cadena)
        Dim dtprov As New Data.DataTable
        Try
            cn.Open()
            dapprov.SelectCommand = cn.CreateCommand
            dapprov.SelectCommand.CommandText = "PA_ListarClienteNatural"
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
    Public Function MOSTRAR_CLIENTE_JURIDICO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_CLIENTE)
        Dim cn As New SqlConnection(cadena)
        Dim dtprov As New Data.DataTable
        Try
            cn.Open()
            dapprov.SelectCommand = cn.CreateCommand
            dapprov.SelectCommand.CommandText = "PA_ListarClienteJuridico"
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

    Public Sub REGISTRAR_CLIENTE_NATURAL(ByVal obj As CAPA_ENTIDAD.CpE_Cls_CLIENTE)
        Dim cn As New SqlConnection(cadena)
        cn.Open()
        Try
            dapprov.InsertCommand = cn.CreateCommand
            dapprov.InsertCommand.CommandText = "PA_RegistrarClienteNatural"
            dapprov.InsertCommand.CommandType = CommandType.StoredProcedure
            dapprov.InsertCommand.Parameters.AddWithValue("@dni", obj.dni)
            dapprov.InsertCommand.Parameters.AddWithValue("@nom", obj.Nombre)
            dapprov.InsertCommand.Parameters.AddWithValue("@ape", obj.Apellido)
            dapprov.InsertCommand.Parameters.AddWithValue("@tele", obj.telefono)
            dapprov.InsertCommand.Parameters.AddWithValue("@dire", obj.direccion)
            dapprov.InsertCommand.Parameters.AddWithValue("@email", obj.correo)
            dapprov.InsertCommand.Parameters.AddWithValue("@esta", obj.estado)
            dapprov.InsertCommand.Parameters.AddWithValue("@fechanaci", obj.fechaNacimiento)
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
    Public Sub REGISTRAR_CLIENTE_JURIDICO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_CLIENTE)
        Dim cn As New SqlConnection(cadena)
        cn.Open()
        Try
            dapprov.InsertCommand = cn.CreateCommand
            dapprov.InsertCommand.CommandText = "PA_RegistrarClienteJuridico"
            dapprov.InsertCommand.CommandType = CommandType.StoredProcedure
            dapprov.InsertCommand.Parameters.AddWithValue("@ruc", obj.ruc)
            dapprov.InsertCommand.Parameters.AddWithValue("@razonsocial", obj.RazonSocial)
            dapprov.InsertCommand.Parameters.AddWithValue("@nom", obj.Nombre)
            dapprov.InsertCommand.Parameters.AddWithValue("@tele", obj.telefono)
            dapprov.InsertCommand.Parameters.AddWithValue("@dire", obj.direccion)
            dapprov.InsertCommand.Parameters.AddWithValue("@email", obj.correo)
            dapprov.InsertCommand.Parameters.AddWithValue("@esta", obj.estado)
            dapprov.InsertCommand.Parameters.AddWithValue("@fechanaci", obj.fechaNacimiento)
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

    Public Sub MODIFICAR_CLIENTE_NATURAL(ByVal obj As CAPA_ENTIDAD.CpE_Cls_CLIENTE)
        Dim cn As New SqlConnection(cadena)
        Try
            cn.Open()
            dapprov.UpdateCommand = cn.CreateCommand
            dapprov.UpdateCommand.CommandText = "PA_EditarClienteNatura"
            dapprov.UpdateCommand.CommandType = CommandType.StoredProcedure
            dapprov.UpdateCommand.Parameters.AddWithValue("@id", obj.idcliente)
            dapprov.UpdateCommand.Parameters.AddWithValue("@dni", obj.dni)
            dapprov.UpdateCommand.Parameters.AddWithValue("@nom", obj.Nombre)
            dapprov.UpdateCommand.Parameters.AddWithValue("@ape", obj.Apellido)
            dapprov.UpdateCommand.Parameters.AddWithValue("@tele", obj.telefono)
            dapprov.UpdateCommand.Parameters.AddWithValue("@dire", obj.direccion)
            dapprov.UpdateCommand.Parameters.AddWithValue("@email", obj.correo)
            dapprov.UpdateCommand.Parameters.AddWithValue("@esta", obj.estado)
            dapprov.UpdateCommand.Parameters.AddWithValue("@fechanaci", obj.fechaNacimiento)
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

    Public Sub MODIFICAR_CLIENTE_JURIDICO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_CLIENTE)
        Dim cn As New SqlConnection(cadena)
        Try
            cn.Open()
            dapprov.UpdateCommand = cn.CreateCommand
            dapprov.UpdateCommand.CommandText = "PA_EditarClienteJuridico"
            dapprov.UpdateCommand.CommandType = CommandType.StoredProcedure
            dapprov.UpdateCommand.Parameters.AddWithValue("@id", obj.idcliente)
            dapprov.UpdateCommand.Parameters.AddWithValue("@ruc", obj.ruc)
            dapprov.UpdateCommand.Parameters.AddWithValue("@razonSocial", obj.RazonSocial)
            dapprov.UpdateCommand.Parameters.AddWithValue("@nombre", obj.Nombre)
            dapprov.UpdateCommand.Parameters.AddWithValue("@tele", obj.telefono)
            dapprov.UpdateCommand.Parameters.AddWithValue("@dire", obj.direccion)
            dapprov.UpdateCommand.Parameters.AddWithValue("@email", obj.correo)
            dapprov.UpdateCommand.Parameters.AddWithValue("@esta", obj.estado)
            dapprov.UpdateCommand.Parameters.AddWithValue("@fechanaci", obj.fechaNacimiento)
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


    Public Function BUSCAR_CLIENTE_NATURAL(ByVal obj As CAPA_ENTIDAD.CpE_Cls_CLIENTE)
        Dim cn As New SqlConnection(cadena)
        Dim dtprov As New Data.DataTable
        Try
            cn.Open()
            dapprov.SelectCommand = cn.CreateCommand
            dapprov.SelectCommand.CommandText = "PA_BuscarClienteNatural"
            dapprov.SelectCommand.CommandType = CommandType.StoredProcedure
            dapprov.SelectCommand.Parameters.AddWithValue("@dni", obj.dni)
            dapprov.SelectCommand.Parameters.AddWithValue("@ape", obj.Nombre)
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

    Public Function BUSCAR_CLIENTE_JURIDICO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_CLIENTE)
        Dim cn As New SqlConnection(cadena)
        Dim dtprov As New Data.DataTable
        Try
            cn.Open()
            dapprov.SelectCommand = cn.CreateCommand
            dapprov.SelectCommand.CommandText = "PA_BuscarClienteJuridico"
            dapprov.SelectCommand.CommandType = CommandType.StoredProcedure
            dapprov.SelectCommand.Parameters.AddWithValue("@ruc", obj.ruc)
            dapprov.SelectCommand.Parameters.AddWithValue("@razon", obj.RazonSocial)
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
    Public Function MOSTRAR_CLIENTE_ACTIVO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_CLIENTE)
        Dim cn As New SqlConnection(cadena)
        Dim dtprov As New Data.DataTable
        Try
            cn.Open()
            dapprov.SelectCommand = cn.CreateCommand
            dapprov.SelectCommand.CommandText = "PA_ListarClienteActivo"
            dapprov.SelectCommand.CommandType = CommandType.StoredProcedure
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

    Public Function BUSCAR_CLIENTE_NATURAL_ACTIVO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_CLIENTE)
        Dim cn As New SqlConnection(cadena)
        Dim dtprov As New Data.DataTable
        Try
            cn.Open()
            dapprov.SelectCommand = cn.CreateCommand
            dapprov.SelectCommand.CommandText = "PA_BuscarClienteNaturalActivo"
            dapprov.SelectCommand.CommandType = CommandType.StoredProcedure
            dapprov.SelectCommand.Parameters.AddWithValue("@dni", obj.dni)
            dapprov.SelectCommand.Parameters.AddWithValue("@ape", obj.Nombre)
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

    Public Function BUSCAR_CLIENTE_JURIDICO_ACTIVO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_CLIENTE)
        Dim cn As New SqlConnection(cadena)
        Dim dtprov As New Data.DataTable
        Try
            cn.Open()
            dapprov.SelectCommand = cn.CreateCommand
            dapprov.SelectCommand.CommandText = "PA_BuscarClienteJuridicoActivo"
            dapprov.SelectCommand.CommandType = CommandType.StoredProcedure
            dapprov.SelectCommand.Parameters.AddWithValue("@ruc", obj.ruc)
            dapprov.SelectCommand.Parameters.AddWithValue("@nom", obj.RazonSocial)
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
