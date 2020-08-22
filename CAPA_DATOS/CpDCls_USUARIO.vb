Imports System.Data.SqlClient
Imports CAPA_ENTIDAD
Public Class CpDCls_USUARIO
    Public dapprov As New SqlDataAdapter
    Public Sub CapturarNombreTipo(ByVal obj As CAPA_ENTIDAD.CpECls_USUARIO)

        Dim cn As New SqlConnection(cadena)
        Dim dausuario As New SqlDataAdapter
        cn.Open()
        Try
            dausuario.SelectCommand = cn.CreateCommand
            dausuario.SelectCommand.CommandText = "PA_Capturar_TipoUsuario"
            dausuario.SelectCommand.CommandType = CommandType.StoredProcedure
            dausuario.SelectCommand.Parameters.AddWithValue("@nom", obj.usu)
            dausuario.SelectCommand.ExecuteNonQuery()
            obj.NomTipo = dausuario.SelectCommand.ExecuteScalar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Question)
            Throw New Exception(ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Dispose()
                cn.Close()
            End If
        End Try
    End Sub
    Public Function logeo(ByVal n As String, ByVal cl As String, ByVal obj As CAPA_ENTIDAD.CpECls_USUARIO) As Boolean
        Dim cn As New SqlConnection("Data Source=ACERPREDATOR;Initial Catalog=BARRICA2;Integrated Security=True")
        '0Dim cn As New SqlConnection("Data Source=.;Initial Catalog=RESTAURANTE_SAMARITANA;Integrated Security=True")
        Dim comando As New SqlCommand
        Dim parnombre As New SqlParameter
        Dim parclave As New SqlParameter
        Dim parvalidar As New SqlParameter
        n = obj.usu
        cl = obj.cla
        Try
            cn.Open()
            comando = cn.CreateCommand
            comando.CommandText = "PA_LOGIN"
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = cn

            parnombre.ParameterName = "@nombre"
            parclave.ParameterName = "@clave"
            parvalidar.ParameterName = "@validar"

            parnombre.Value = n
            parclave.Value = cl

            parvalidar.Direction = ParameterDirection.Output
            parvalidar.SqlDbType = SqlDbType.Bit
            parvalidar.Size = 1
            comando.Parameters.Add(parnombre)
            comando.Parameters.Add(parclave)
            comando.Parameters.Add(parvalidar)
            comando.ExecuteNonQuery()

        Catch ex As Exception
            Throw ex

        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
                cn.Dispose()
            End If
        End Try

        Return parvalidar.Value
    End Function

    Public Function MOSTRAR_USUARIO(ByVal obj As CAPA_ENTIDAD.CpECls_USUARIO)
        Dim cn As New SqlConnection(cadena)
        Dim dtprov As New Data.DataTable
        Try
            cn.Open()
            dapprov.SelectCommand = cn.CreateCommand
            dapprov.SelectCommand.CommandText = "PA_ListarUsuario"
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
    Public Function MOSTRAR_TIPO_USUARIO(ByVal obj As CAPA_ENTIDAD.CpECls_USUARIO)
        Dim cn As New SqlConnection(cadena)
        Dim dtprov As New Data.DataTable
        Try
            cn.Open()
            dapprov.SelectCommand = cn.CreateCommand
            dapprov.SelectCommand.CommandText = "PA_ListarTipoUsuario"
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


    Public Sub REGISTRAR_USUARIO(ByVal obj As CAPA_ENTIDAD.CpECls_USUARIO)
        Dim cn As New SqlConnection(cadena)
        cn.Open()
        Try
            dapprov.InsertCommand = cn.CreateCommand
            dapprov.InsertCommand.CommandText = "PA_RegistraUsuario"
            dapprov.InsertCommand.CommandType = CommandType.StoredProcedure
            dapprov.InsertCommand.Parameters.AddWithValue("@nom", obj.usu)
            dapprov.InsertCommand.Parameters.AddWithValue("@PASS", obj.cla)
            dapprov.InsertCommand.Parameters.AddWithValue("@idtipo", obj.Idtipo)
            dapprov.InsertCommand.Parameters.AddWithValue("@NomApe", obj.NomApe)
            dapprov.InsertCommand.Parameters.AddWithValue("@Rut", obj.dni)
            dapprov.InsertCommand.Parameters.AddWithValue("@telefono", obj.tele)
            dapprov.InsertCommand.Parameters.AddWithValue("@direccion", obj.direcion)
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

    Public Sub MODIFICAR_USUARIO(ByVal obj As CAPA_ENTIDAD.CpECls_USUARIO)
        Dim cn As New SqlConnection(cadena)
        Try
            cn.Open()
            dapprov.UpdateCommand = cn.CreateCommand
            dapprov.UpdateCommand.CommandText = "PA_EditarUsuario"
            dapprov.UpdateCommand.CommandType = CommandType.StoredProcedure
            dapprov.UpdateCommand.Parameters.AddWithValue("@id", obj.Idusuario)
            dapprov.UpdateCommand.Parameters.AddWithValue("@nom", obj.usu)
            dapprov.UpdateCommand.Parameters.AddWithValue("@PASS", obj.cla)
            dapprov.UpdateCommand.Parameters.AddWithValue("@idtipo", obj.Idtipo)
            dapprov.UpdateCommand.Parameters.AddWithValue("@NomApe", obj.NomApe)
            dapprov.UpdateCommand.Parameters.AddWithValue("@rut", obj.dni)
            dapprov.UpdateCommand.Parameters.AddWithValue("@telefono", obj.tele)
            dapprov.UpdateCommand.Parameters.AddWithValue("@direccion", obj.direcion)
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
End Class
