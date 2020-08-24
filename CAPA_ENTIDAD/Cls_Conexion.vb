Imports System.Data.SqlClient
Public Class Cls_Conexion
    Public cn As New SqlConnection
    Public Function conectar() As Boolean
        Try
            cn = New SqlConnection("Data Source=ACERPREDATOR;Initial Catalog=SextoSoftware;Integrated Security=True")
            cn.Open()
            Return True

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function desconectar() As Boolean
        Try
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class
