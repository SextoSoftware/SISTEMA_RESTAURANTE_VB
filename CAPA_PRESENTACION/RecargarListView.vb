Imports CAPA_NEGOCIO
Imports CAPA_ENTIDAD
Imports System.Text
Imports System.Data.SqlClient
Module RecargarListView
    Function MostrarListviewComandaPlatos() As List(Of CAPA_ENTIDAD.CpE_Cls_COMANDA)
        Dim dapprov As New SqlDataAdapter
        Dim c As New CAPA_ENTIDAD.Cls_Conexion
        c.conectar()
        Try
            Dim comando As New SqlCommand
            Dim lector As SqlDataReader
            Dim entidadmenu As New List(Of CAPA_ENTIDAD.CpE_Cls_COMANDA)
            Dim objentidadmenu As CAPA_ENTIDAD.CpE_Cls_COMANDA
            dapprov.SelectCommand = c.cn.CreateCommand
            dapprov.SelectCommand.CommandText = "PA_ListarComandaListviewPlato"
            dapprov.SelectCommand.CommandType = CommandType.StoredProcedure
            dapprov.SelectCommand.Parameters.AddWithValue("@idcomanda", WFrm_COMANDA.TextBox1.Text)
            dapprov.SelectCommand.ExecuteNonQuery()
            lector = dapprov.SelectCommand.ExecuteReader
            If lector.HasRows = True Then
                While lector.Read
                    objentidadmenu = New CAPA_ENTIDAD.CpE_Cls_COMANDA
                    objentidadmenu.idPlato = lector.Item(0)
                    objentidadmenu.nombre = lector.Item(1)
                    objentidadmenu.cantidad = lector.Item(2)
                    objentidadmenu.precio = lector.Item(3)
                    objentidadmenu.importe = lector.Item(4)
                    objentidadmenu.notas = lector.Item(5)
                    entidadmenu.Add(objentidadmenu)
                End While
            End If
            Return entidadmenu
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            c.desconectar()
        End Try
    End Function
    Function MostrarListviewComandaProductos() As List(Of CAPA_ENTIDAD.CpE_Cls_COMANDA)
        Dim dapprov As New SqlDataAdapter
        Dim c As New CAPA_ENTIDAD.Cls_Conexion
        c.conectar()
        Try
            Dim comando As New SqlCommand
            Dim lector As SqlDataReader
            Dim entidadmenu As New List(Of CAPA_ENTIDAD.CpE_Cls_COMANDA)
            Dim objentidadmenu As CAPA_ENTIDAD.CpE_Cls_COMANDA
            dapprov.SelectCommand = c.cn.CreateCommand
            dapprov.SelectCommand.CommandText = "PA_ListarComandaListviewProducto"
            dapprov.SelectCommand.CommandType = CommandType.StoredProcedure
            dapprov.SelectCommand.Parameters.AddWithValue("@idcomanda", WFrm_COMANDA.TextBox1.Text)
            dapprov.SelectCommand.ExecuteNonQuery()
            lector = dapprov.SelectCommand.ExecuteReader
            If lector.HasRows = True Then
                While lector.Read
                    objentidadmenu = New CAPA_ENTIDAD.CpE_Cls_COMANDA
                    objentidadmenu.idproducto = lector.Item(0)
                    objentidadmenu.nombre = lector.Item(1)
                    objentidadmenu.cantidad = lector.Item(2)
                    objentidadmenu.precio = lector.Item(3)
                    objentidadmenu.importe = lector.Item(4)
                    objentidadmenu.notas = lector.Item(5)
                    entidadmenu.Add(objentidadmenu)
                End While
            End If
            Return entidadmenu
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            c.desconectar()
        End Try
    End Function
End Module
