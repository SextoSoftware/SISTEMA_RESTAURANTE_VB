Imports CAPA_NEGOCIO
Imports CAPA_ENTIDAD
Module Datos
    Public objnegocio As New CAPA_NEGOCIO.CpN_Cls_MESA
    Public objentidade As New CAPA_ENTIDAD.CpE_Cls_MESA
    Public usuario As String
    Public contra As String
    Public tipo_usuario As String

    Public nombrebutton As String
    'Guardar datos del producto para pasarlos al formulario orden de compra
    Public tipo As String
    Public descripcion As String

    Public idordencompraImprime, cantidadplato, CodigoMenuDia, codigoNuevaCantidad, CodigoImprimirComanda As Integer

    Public opcionbusqueda As Integer
    Public NombreMesa As String


    Public menu_nombre, menu_descripcon As String
    Public menu_estado As Integer

    Public busqueser As Integer
    Public contar As Integer = 0
    Public lnn As Integer
    Public m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11, m12, m13, m14, m15, m16, m17, m18, m19, m20, m21, m22, m23, m24, m25, m26, m27, m28, m29, m30, m31, m32, m33, m34, m35, m36, m37, m38, m39, m40, m41, m42, m43, m44, m45, m46, m47, m48, m49, m50 As String
    Public e1, e2, e3, e4, e5, e6, e7, e8, e9, e10, e11, e12, e13, e14, e15, e16, e17, e18, e19, e20, e21, e22, e23, e24, e25, e26, e27, e28, e29, e30, e31, e32, e33, e34, e35, e36, e37, e38, e39, e40, e41, e42, e43, e44, e45, e46, e47, e48, e49, e50 As String

    Public Sub recorrer_mesas()

        WFrm_Mesa.Dg_Proveedores.DataSource = objnegocio.MOSTRAR_MESA(objentidade)
        lnn = WFrm_Mesa.Dg_Proveedores.RowCount - 1
        If lnn >= 0 Then
            m1 = WFrm_Mesa.Dg_Proveedores.Rows(0).Cells(1).Value()
            e1 = WFrm_Mesa.Dg_Proveedores.Rows(0).Cells(2).Value()
        End If
        If lnn >= 1 Then
            m2 = WFrm_Mesa.Dg_Proveedores.Rows(1).Cells(1).Value()
            e2 = WFrm_Mesa.Dg_Proveedores.Rows(1).Cells(2).Value()
        End If
        If lnn >= 2 Then
            m3 = WFrm_Mesa.Dg_Proveedores.Rows(2).Cells(1).Value()
            e3 = WFrm_Mesa.Dg_Proveedores.Rows(2).Cells(2).Value()
        End If
        If lnn >= 3 Then
            m4 = WFrm_Mesa.Dg_Proveedores.Rows(3).Cells(1).Value()
            e4 = WFrm_Mesa.Dg_Proveedores.Rows(3).Cells(2).Value()
        End If
        If lnn >= 4 Then
            m5 = WFrm_Mesa.Dg_Proveedores.Rows(4).Cells(1).Value()
            e5 = WFrm_Mesa.Dg_Proveedores.Rows(4).Cells(2).Value()
        End If
        If lnn >= 5 Then
            m6 = WFrm_Mesa.Dg_Proveedores.Rows(5).Cells(1).Value()
            e6 = WFrm_Mesa.Dg_Proveedores.Rows(5).Cells(2).Value()
        End If
        If lnn >= 6 Then
            m7 = WFrm_Mesa.Dg_Proveedores.Rows(6).Cells(1).Value()
            e7 = WFrm_Mesa.Dg_Proveedores.Rows(6).Cells(2).Value()
        End If
        If lnn >= 7 Then
            m8 = WFrm_Mesa.Dg_Proveedores.Rows(7).Cells(1).Value()
            e8 = WFrm_Mesa.Dg_Proveedores.Rows(7).Cells(2).Value()
        End If
        If lnn >= 8 Then
            m9 = WFrm_Mesa.Dg_Proveedores.Rows(8).Cells(1).Value()
            e9 = WFrm_Mesa.Dg_Proveedores.Rows(8).Cells(2).Value()
        End If
        If lnn >= 9 Then
            m10 = WFrm_Mesa.Dg_Proveedores.Rows(9).Cells(1).Value()
            e10 = WFrm_Mesa.Dg_Proveedores.Rows(9).Cells(2).Value()
        End If
        If lnn >= 10 Then
            m11 = WFrm_Mesa.Dg_Proveedores.Rows(10).Cells(1).Value()
            e11 = WFrm_Mesa.Dg_Proveedores.Rows(10).Cells(2).Value()
        End If

        If lnn >= 11 Then
            m12 = WFrm_Mesa.Dg_Proveedores.Rows(11).Cells(1).Value()
            e12 = WFrm_Mesa.Dg_Proveedores.Rows(11).Cells(2).Value()
        End If
        If lnn >= 12 Then
            m13 = WFrm_Mesa.Dg_Proveedores.Rows(12).Cells(1).Value()
            e13 = WFrm_Mesa.Dg_Proveedores.Rows(12).Cells(2).Value()
        End If
        If lnn >= 13 Then
            m14 = WFrm_Mesa.Dg_Proveedores.Rows(13).Cells(1).Value()
            e14 = WFrm_Mesa.Dg_Proveedores.Rows(13).Cells(2).Value()
        End If
        If lnn >= 14 Then
            m15 = WFrm_Mesa.Dg_Proveedores.Rows(14).Cells(1).Value()
            e15 = WFrm_Mesa.Dg_Proveedores.Rows(14).Cells(2).Value()
        End If
        If lnn >= 15 Then
            m16 = WFrm_Mesa.Dg_Proveedores.Rows(15).Cells(1).Value()
            e16 = WFrm_Mesa.Dg_Proveedores.Rows(15).Cells(2).Value()
        End If
        If lnn >= 16 Then
            m17 = WFrm_Mesa.Dg_Proveedores.Rows(16).Cells(1).Value()
            e17 = WFrm_Mesa.Dg_Proveedores.Rows(16).Cells(2).Value()
            contar = contar + 1
        End If
        If lnn >= 17 Then
            m18 = WFrm_Mesa.Dg_Proveedores.Rows(17).Cells(1).Value()
            e18 = WFrm_Mesa.Dg_Proveedores.Rows(17).Cells(2).Value()
        End If
        If lnn >= 18 Then
            m19 = WFrm_Mesa.Dg_Proveedores.Rows(18).Cells(1).Value()
            e19 = WFrm_Mesa.Dg_Proveedores.Rows(18).Cells(2).Value()
        End If
        If lnn >= 19 Then
            m20 = WFrm_Mesa.Dg_Proveedores.Rows(19).Cells(1).Value()
            e20 = WFrm_Mesa.Dg_Proveedores.Rows(19).Cells(2).Value()
        End If

        If lnn >= 20 Then
            m21 = WFrm_Mesa.Dg_Proveedores.Rows(20).Cells(1).Value()
            e21 = WFrm_Mesa.Dg_Proveedores.Rows(20).Cells(2).Value()
        End If
        If lnn >= 21 Then
            m22 = WFrm_Mesa.Dg_Proveedores.Rows(21).Cells(1).Value()
            e22 = WFrm_Mesa.Dg_Proveedores.Rows(21).Cells(2).Value()
        End If
        If lnn >= 22 Then
            m23 = WFrm_Mesa.Dg_Proveedores.Rows(22).Cells(1).Value()
            e23 = WFrm_Mesa.Dg_Proveedores.Rows(22).Cells(2).Value()
        End If
        If lnn >= 23 Then
            m24 = WFrm_Mesa.Dg_Proveedores.Rows(23).Cells(1).Value()
            e24 = WFrm_Mesa.Dg_Proveedores.Rows(23).Cells(2).Value()
        End If
        If lnn >= 24 Then
            m25 = WFrm_Mesa.Dg_Proveedores.Rows(24).Cells(1).Value()
            e25 = WFrm_Mesa.Dg_Proveedores.Rows(24).Cells(2).Value()
        End If
        If lnn >= 25 Then
            m26 = WFrm_Mesa.Dg_Proveedores.Rows(25).Cells(1).Value()
            e26 = WFrm_Mesa.Dg_Proveedores.Rows(25).Cells(2).Value()
        End If
        If lnn >= 26 Then
            m27 = WFrm_Mesa.Dg_Proveedores.Rows(26).Cells(1).Value()
            e27 = WFrm_Mesa.Dg_Proveedores.Rows(26).Cells(2).Value()
        End If
        If lnn >= 27 Then
            m28 = WFrm_Mesa.Dg_Proveedores.Rows(27).Cells(1).Value()
            e28 = WFrm_Mesa.Dg_Proveedores.Rows(27).Cells(2).Value()
        End If
        If lnn >= 28 Then
            m29 = WFrm_Mesa.Dg_Proveedores.Rows(28).Cells(1).Value()
            e29 = WFrm_Mesa.Dg_Proveedores.Rows(28).Cells(2).Value()
        End If
        If lnn >= 29 Then
            e30 = WFrm_Mesa.Dg_Proveedores.Rows(29).Cells(1).Value()
            e30 = WFrm_Mesa.Dg_Proveedores.Rows(29).Cells(2).Value()
        End If
        If lnn >= 30 Then
            m31 = WFrm_Mesa.Dg_Proveedores.Rows(30).Cells(1).Value()
            e31 = WFrm_Mesa.Dg_Proveedores.Rows(30).Cells(2).Value()
        End If
        If lnn >= 31 Then
            m32 = WFrm_Mesa.Dg_Proveedores.Rows(31).Cells(1).Value()
            e32 = WFrm_Mesa.Dg_Proveedores.Rows(31).Cells(2).Value()
        End If
        If lnn >= 32 Then
            m33 = WFrm_Mesa.Dg_Proveedores.Rows(32).Cells(1).Value()
            e33 = WFrm_Mesa.Dg_Proveedores.Rows(32).Cells(2).Value()
        End If
        If lnn >= 33 Then
            m34 = WFrm_Mesa.Dg_Proveedores.Rows(33).Cells(1).Value()
            e34 = WFrm_Mesa.Dg_Proveedores.Rows(33).Cells(2).Value()
        End If
        If lnn >= 34 Then
            m35 = WFrm_Mesa.Dg_Proveedores.Rows(34).Cells(1).Value()
            e35 = WFrm_Mesa.Dg_Proveedores.Rows(34).Cells(2).Value()
        End If
        If lnn >= 35 Then
            m36 = WFrm_Mesa.Dg_Proveedores.Rows(35).Cells(1).Value()
            e36 = WFrm_Mesa.Dg_Proveedores.Rows(35).Cells(2).Value()
        End If
        If lnn >= 36 Then
            m37 = WFrm_Mesa.Dg_Proveedores.Rows(36).Cells(1).Value()
            e37 = WFrm_Mesa.Dg_Proveedores.Rows(36).Cells(2).Value()
        End If
        If lnn >= 37 Then
            m38 = WFrm_Mesa.Dg_Proveedores.Rows(37).Cells(1).Value()
            e38 = WFrm_Mesa.Dg_Proveedores.Rows(37).Cells(2).Value()
        End If
        If lnn >= 38 Then
            m39 = WFrm_Mesa.Dg_Proveedores.Rows(38).Cells(1).Value()
            e39 = WFrm_Mesa.Dg_Proveedores.Rows(38).Cells(2).Value()
        End If
        If lnn >= 39 Then
            m40 = WFrm_Mesa.Dg_Proveedores.Rows(39).Cells(1).Value()
            e40 = WFrm_Mesa.Dg_Proveedores.Rows(39).Cells(2).Value()
        End If
        If lnn >= 40 Then
            m41 = WFrm_Mesa.Dg_Proveedores.Rows(40).Cells(1).Value()
            e41 = WFrm_Mesa.Dg_Proveedores.Rows(40).Cells(2).Value()
        End If
        If lnn >= 41 Then
            m42 = WFrm_Mesa.Dg_Proveedores.Rows(41).Cells(1).Value()
            e42 = WFrm_Mesa.Dg_Proveedores.Rows(41).Cells(2).Value()
        End If
        If lnn >= 42 Then
            m43 = WFrm_Mesa.Dg_Proveedores.Rows(42).Cells(1).Value()
            e43 = WFrm_Mesa.Dg_Proveedores.Rows(42).Cells(2).Value()
        End If
        If lnn >= 43 Then
            m44 = WFrm_Mesa.Dg_Proveedores.Rows(43).Cells(1).Value()
            e44 = WFrm_Mesa.Dg_Proveedores.Rows(43).Cells(2).Value()
        End If
        If lnn >= 44 Then
            m45 = WFrm_Mesa.Dg_Proveedores.Rows(44).Cells(1).Value()
            e45 = WFrm_Mesa.Dg_Proveedores.Rows(44).Cells(2).Value()
        End If
        If lnn >= 45 Then
            m46 = WFrm_Mesa.Dg_Proveedores.Rows(45).Cells(1).Value()
            e46 = WFrm_Mesa.Dg_Proveedores.Rows(45).Cells(2).Value()
        End If
        If lnn >= 46 Then
            m47 = WFrm_Mesa.Dg_Proveedores.Rows(46).Cells(1).Value()
            e47 = WFrm_Mesa.Dg_Proveedores.Rows(46).Cells(2).Value()
        End If
        If lnn >= 47 Then
            m48 = WFrm_Mesa.Dg_Proveedores.Rows(47).Cells(1).Value()
            e48 = WFrm_Mesa.Dg_Proveedores.Rows(47).Cells(2).Value()
        End If
        If lnn >= 48 Then
            m49 = WFrm_Mesa.Dg_Proveedores.Rows(48).Cells(1).Value()
            e49 = WFrm_Mesa.Dg_Proveedores.Rows(48).Cells(2).Value()
        End If
        If lnn >= 49 Then
            m50 = WFrm_Mesa.Dg_Proveedores.Rows(49).Cells(1).Value()
            e50 = WFrm_Mesa.Dg_Proveedores.Rows(49).Cells(2).Value()
        End If
    End Sub




    Public Sub actualiza_panel_mesas()
        recorrer_mesas()
        WFrm_DISEÑO_MESAS.bm1.Text = m1
        WFrm_DISEÑO_MESAS.bm2.Text = m2
        WFrm_DISEÑO_MESAS.bm3.Text = m3
        WFrm_DISEÑO_MESAS.bm4.Text = m4
        WFrm_DISEÑO_MESAS.bm5.Text = m5
        WFrm_DISEÑO_MESAS.bm6.Text = m6
        WFrm_DISEÑO_MESAS.bm7.Text = m7
        WFrm_DISEÑO_MESAS.bm8.Text = m8
        WFrm_DISEÑO_MESAS.bm9.Text = m9
        WFrm_DISEÑO_MESAS.bm10.Text = m10
        WFrm_DISEÑO_MESAS.bm11.Text = m11
        WFrm_DISEÑO_MESAS.bm12.Text = m12
        WFrm_DISEÑO_MESAS.bm13.Text = m13
        WFrm_DISEÑO_MESAS.bm14.Text = m14
        WFrm_DISEÑO_MESAS.bm15.Text = m15
        WFrm_DISEÑO_MESAS.bm16.Text = m16
        WFrm_DISEÑO_MESAS.bm17.Text = m17
        WFrm_DISEÑO_MESAS.bm18.Text = m18
        WFrm_DISEÑO_MESAS.bm19.Text = m19
        WFrm_DISEÑO_MESAS.bm20.Text = m20
        WFrm_DISEÑO_MESAS.bm21.Text = m21
        WFrm_DISEÑO_MESAS.bm22.Text = m22
        WFrm_DISEÑO_MESAS.bm23.Text = m23
        WFrm_DISEÑO_MESAS.bm24.Text = m24
        WFrm_DISEÑO_MESAS.bm25.Text = m25
        WFrm_DISEÑO_MESAS.bm26.Text = m26
        WFrm_DISEÑO_MESAS.bm27.Text = m27
        WFrm_DISEÑO_MESAS.bm28.Text = m28
        WFrm_DISEÑO_MESAS.bm29.Text = m29
        WFrm_DISEÑO_MESAS.bm30.Text = m30
        WFrm_DISEÑO_MESAS.bm31.Text = m31
        WFrm_DISEÑO_MESAS.bm32.Text = m32
        WFrm_DISEÑO_MESAS.bm33.Text = m33
        WFrm_DISEÑO_MESAS.bm34.Text = m34
        WFrm_DISEÑO_MESAS.bm35.Text = m35
        WFrm_DISEÑO_MESAS.bm36.Text = m36
        WFrm_DISEÑO_MESAS.bm37.Text = m37
        WFrm_DISEÑO_MESAS.bm38.Text = m38
        WFrm_DISEÑO_MESAS.bm39.Text = m39
        WFrm_DISEÑO_MESAS.bm40.Text = m40
        WFrm_DISEÑO_MESAS.bm41.Text = m41
        WFrm_DISEÑO_MESAS.bm42.Text = m42
        WFrm_DISEÑO_MESAS.bm43.Text = m43
        WFrm_DISEÑO_MESAS.bm44.Text = m44
        WFrm_DISEÑO_MESAS.bm45.Text = m45
        WFrm_DISEÑO_MESAS.bm46.Text = m46
        WFrm_DISEÑO_MESAS.bm47.Text = m47
        WFrm_DISEÑO_MESAS.bm48.Text = m48
        WFrm_DISEÑO_MESAS.bm49.Text = m49
        WFrm_DISEÑO_MESAS.bm50.Text = m50
        contar = 0
        If e1 = "1" Then
            WFrm_DISEÑO_MESAS.bm1.Enabled = True
            WFrm_DISEÑO_MESAS.bm1.Visible = True
            contar = contar + 1
        Else
            WFrm_DISEÑO_MESAS.bm1.Enabled = False
            WFrm_DISEÑO_MESAS.bm1.Visible = False
        End If
        If e2 = "1" Then
            WFrm_DISEÑO_MESAS.bm2.Enabled = True
            WFrm_DISEÑO_MESAS.bm2.Visible = True
            contar = contar + 1
        Else
            WFrm_DISEÑO_MESAS.bm2.Enabled = False
            WFrm_DISEÑO_MESAS.bm2.Visible = False
        End If
        If e3 = "1" Then
            WFrm_DISEÑO_MESAS.bm3.Enabled = True
            WFrm_DISEÑO_MESAS.bm3.Visible = True
            contar = contar + 1
        Else
            WFrm_DISEÑO_MESAS.bm3.Enabled = False
            WFrm_DISEÑO_MESAS.bm3.Visible = False
        End If
        If e4 = "1" Then
            WFrm_DISEÑO_MESAS.bm4.Enabled = True
            WFrm_DISEÑO_MESAS.bm4.Visible = True
            contar = contar + 1
        Else
            WFrm_DISEÑO_MESAS.bm4.Enabled = False
            WFrm_DISEÑO_MESAS.bm4.Visible = False
        End If
        If e5 = "1" Then
            WFrm_DISEÑO_MESAS.bm5.Enabled = True
            WFrm_DISEÑO_MESAS.bm5.Visible = True
            contar = contar + 1
        Else
            WFrm_DISEÑO_MESAS.bm5.Enabled = False
            WFrm_DISEÑO_MESAS.bm5.Visible = False
        End If
        If e6 = "1" Then
            WFrm_DISEÑO_MESAS.bm6.Enabled = True
            WFrm_DISEÑO_MESAS.bm6.Visible = True
            contar = contar + 1
        Else
            WFrm_DISEÑO_MESAS.bm6.Enabled = False
            WFrm_DISEÑO_MESAS.bm6.Visible = False
        End If
        If e7 = "1" Then
            WFrm_DISEÑO_MESAS.bm7.Enabled = True
            WFrm_DISEÑO_MESAS.bm7.Visible = True
            contar = contar + 1
        Else
            WFrm_DISEÑO_MESAS.bm7.Enabled = False
            WFrm_DISEÑO_MESAS.bm7.Visible = False
        End If

        If e8 = "1" Then
            WFrm_DISEÑO_MESAS.bm8.Enabled = True
            WFrm_DISEÑO_MESAS.bm8.Visible = True
            contar = contar + 1
        Else
            WFrm_DISEÑO_MESAS.bm8.Enabled = False
            WFrm_DISEÑO_MESAS.bm8.Visible = False
        End If
        If e9 = "1" Then
            WFrm_DISEÑO_MESAS.bm9.Enabled = True
            WFrm_DISEÑO_MESAS.bm9.Visible = True
            contar = contar + 1
        Else
            WFrm_DISEÑO_MESAS.bm9.Enabled = False
            WFrm_DISEÑO_MESAS.bm9.Visible = False
        End If
        If e10 = "1" Then
            WFrm_DISEÑO_MESAS.bm10.Enabled = True
            WFrm_DISEÑO_MESAS.bm10.Visible = True
            contar = contar + 1
        Else
            WFrm_DISEÑO_MESAS.bm10.Enabled = False
            WFrm_DISEÑO_MESAS.bm10.Visible = False
        End If
        If e11 = "1" Then
            WFrm_DISEÑO_MESAS.bm11.Enabled = True
            WFrm_DISEÑO_MESAS.bm11.Visible = True
            contar = contar + 1
        Else
            WFrm_DISEÑO_MESAS.bm11.Enabled = False
            WFrm_DISEÑO_MESAS.bm11.Visible = False
        End If
        If e12 = "1" Then
            WFrm_DISEÑO_MESAS.bm12.Enabled = True
            WFrm_DISEÑO_MESAS.bm12.Visible = True
            contar = contar + 1
        Else
            WFrm_DISEÑO_MESAS.bm12.Enabled = False
            WFrm_DISEÑO_MESAS.bm12.Visible = False
        End If
        If e13 = "1" Then
            WFrm_DISEÑO_MESAS.bm13.Enabled = True
            WFrm_DISEÑO_MESAS.bm13.Visible = True
            contar = contar + 1
        Else
            WFrm_DISEÑO_MESAS.bm13.Enabled = False
            WFrm_DISEÑO_MESAS.bm13.Visible = False
        End If
        If e14 = "1" Then
            WFrm_DISEÑO_MESAS.bm14.Enabled = True
            WFrm_DISEÑO_MESAS.bm14.Visible = True
            contar = contar + 1
        Else
            WFrm_DISEÑO_MESAS.bm14.Enabled = False
            WFrm_DISEÑO_MESAS.bm14.Visible = False
        End If
        If e15 = "1" Then
            WFrm_DISEÑO_MESAS.bm15.Enabled = True
            WFrm_DISEÑO_MESAS.bm15.Visible = True
            contar = contar + 1
        Else
            WFrm_DISEÑO_MESAS.bm15.Enabled = False
            WFrm_DISEÑO_MESAS.bm15.Visible = False
        End If
        If e16 = "1" Then
            WFrm_DISEÑO_MESAS.bm16.Enabled = True
            WFrm_DISEÑO_MESAS.bm16.Visible = True
            contar = contar + 1
        Else
            WFrm_DISEÑO_MESAS.bm16.Enabled = False
            WFrm_DISEÑO_MESAS.bm16.Visible = False
        End If
        If e20 = "1" Then
            WFrm_DISEÑO_MESAS.bm20.Enabled = True
            WFrm_DISEÑO_MESAS.bm20.Visible = True
            contar = contar + 1
        Else
            WFrm_DISEÑO_MESAS.bm20.Enabled = False
            WFrm_DISEÑO_MESAS.bm20.Visible = False
        End If
        If e17 = "1" Then
            WFrm_DISEÑO_MESAS.bm17.Enabled = True
            WFrm_DISEÑO_MESAS.bm17.Visible = True
            contar = contar + 1
        Else
            WFrm_DISEÑO_MESAS.bm17.Enabled = False
            WFrm_DISEÑO_MESAS.bm17.Visible = False
        End If
        If e18 = "1" Then
            WFrm_DISEÑO_MESAS.bm18.Enabled = True
            WFrm_DISEÑO_MESAS.bm18.Visible = True
            contar = contar + 1
        Else
            WFrm_DISEÑO_MESAS.bm18.Enabled = False
            WFrm_DISEÑO_MESAS.bm18.Visible = False
        End If
        If e19 = "1" Then
            WFrm_DISEÑO_MESAS.bm19.Enabled = True
            WFrm_DISEÑO_MESAS.bm19.Visible = True
            contar = contar + 1
        Else
            WFrm_DISEÑO_MESAS.bm19.Enabled = False
            WFrm_DISEÑO_MESAS.bm19.Visible = False
        End If


        If e21 = "1" Then
            WFrm_DISEÑO_MESAS.bm21.Enabled = True
            WFrm_DISEÑO_MESAS.bm21.Visible = True
            contar = contar + 1
        Else
            WFrm_DISEÑO_MESAS.bm21.Enabled = False
            WFrm_DISEÑO_MESAS.bm21.Visible = False
        End If
        If e22 = "1" Then
            WFrm_DISEÑO_MESAS.bm22.Enabled = True
            WFrm_DISEÑO_MESAS.bm22.Visible = True
            contar = contar + 1
        Else
            WFrm_DISEÑO_MESAS.bm22.Enabled = False
            WFrm_DISEÑO_MESAS.bm22.Visible = False
        End If
        If e23 = "1" Then
            WFrm_DISEÑO_MESAS.bm23.Enabled = True
            WFrm_DISEÑO_MESAS.bm23.Visible = True
            contar = contar + 1
        Else
            WFrm_DISEÑO_MESAS.bm23.Enabled = False
            WFrm_DISEÑO_MESAS.bm23.Visible = False
        End If
        If e24 = "1" Then
            WFrm_DISEÑO_MESAS.bm24.Enabled = True
            WFrm_DISEÑO_MESAS.bm4.Visible = True
            contar = contar + 1
        Else
            WFrm_DISEÑO_MESAS.bm24.Enabled = False
            WFrm_DISEÑO_MESAS.bm24.Visible = False
        End If
        If e25 = "1" Then
            WFrm_DISEÑO_MESAS.bm25.Enabled = True
            WFrm_DISEÑO_MESAS.bm25.Visible = True
            contar = contar + 1
        Else
            WFrm_DISEÑO_MESAS.bm25.Enabled = False
            WFrm_DISEÑO_MESAS.bm25.Visible = False
        End If
        If e26 = "1" Then
            WFrm_DISEÑO_MESAS.bm26.Enabled = True
            WFrm_DISEÑO_MESAS.bm26.Visible = True
            contar = contar + 1
        Else
            WFrm_DISEÑO_MESAS.bm26.Enabled = False
            WFrm_DISEÑO_MESAS.bm26.Visible = False
        End If
        If e27 = "1" Then
            WFrm_DISEÑO_MESAS.bm27.Enabled = True
            WFrm_DISEÑO_MESAS.bm27.Visible = True
            contar = contar + 1
        Else
            WFrm_DISEÑO_MESAS.bm27.Enabled = False
            WFrm_DISEÑO_MESAS.bm27.Visible = False
        End If
        If e28 = "1" Then
            WFrm_DISEÑO_MESAS.bm28.Enabled = True
            WFrm_DISEÑO_MESAS.bm28.Visible = True
            contar = contar + 1
        Else
            WFrm_DISEÑO_MESAS.bm28.Enabled = False
            WFrm_DISEÑO_MESAS.bm28.Visible = False
        End If
        If e29 = "1" Then
            WFrm_DISEÑO_MESAS.bm29.Enabled = True
            WFrm_DISEÑO_MESAS.bm29.Visible = True
            contar = contar + 1
        Else
            WFrm_DISEÑO_MESAS.bm29.Enabled = False
            WFrm_DISEÑO_MESAS.bm29.Visible = False
        End If
        If e30 = "1" Then
            WFrm_DISEÑO_MESAS.bm30.Enabled = False
            WFrm_DISEÑO_MESAS.bm30.Visible = False
            contar = contar + 1
        Else
            WFrm_DISEÑO_MESAS.bm30.Enabled = False
            WFrm_DISEÑO_MESAS.bm30.Visible = False
        End If
        If e31 = "1" Then
            WFrm_DISEÑO_MESAS.bm31.Enabled = True

            WFrm_DISEÑO_MESAS.bm31.Visible = True
            contar = contar + 1
        Else
            WFrm_DISEÑO_MESAS.bm31.Enabled = False
            WFrm_DISEÑO_MESAS.bm31.Visible = False
        End If
        If e32 = "1" Then
            WFrm_DISEÑO_MESAS.bm32.Enabled = True
            WFrm_DISEÑO_MESAS.bm32.Visible = True
            contar = contar + 1
        Else
            WFrm_DISEÑO_MESAS.bm32.Enabled = False
            WFrm_DISEÑO_MESAS.bm32.Visible = False
        End If
        If e33 = "1" Then
            WFrm_DISEÑO_MESAS.bm33.Enabled = True
            WFrm_DISEÑO_MESAS.bm33.Visible = True
            contar = contar + 1
        Else
            WFrm_DISEÑO_MESAS.bm33.Visible = False
            WFrm_DISEÑO_MESAS.bm33.Enabled = False
        End If
        If e34 = "1" Then
            WFrm_DISEÑO_MESAS.bm34.Enabled = True
            WFrm_DISEÑO_MESAS.bm34.Visible = True
            contar = contar + 1
        Else
            WFrm_DISEÑO_MESAS.bm34.Enabled = False
            WFrm_DISEÑO_MESAS.bm34.Visible = False
        End If
        If e35 = "1" Then
            WFrm_DISEÑO_MESAS.bm35.Enabled = True
            WFrm_DISEÑO_MESAS.bm35.Visible = True
            contar = contar + 1

        Else
            WFrm_DISEÑO_MESAS.bm35.Enabled = False
            WFrm_DISEÑO_MESAS.bm35.Visible = False
        End If
        If e36 = "1" Then
            WFrm_DISEÑO_MESAS.bm36.Enabled = True
            WFrm_DISEÑO_MESAS.bm36.Visible = True
            contar = contar + 1
        Else
            WFrm_DISEÑO_MESAS.bm36.Enabled = False
            WFrm_DISEÑO_MESAS.bm36.Visible = False
        End If
        If e37 = "1" Then
            WFrm_DISEÑO_MESAS.bm37.Enabled = True
            WFrm_DISEÑO_MESAS.bm37.Visible = True
            contar = contar + 1
        Else
            WFrm_DISEÑO_MESAS.bm37.Enabled = False
            WFrm_DISEÑO_MESAS.bm37.Visible = False
        End If
        If e38 = "1" Then
            WFrm_DISEÑO_MESAS.bm38.Enabled = True
            WFrm_DISEÑO_MESAS.bm38.Visible = True
            contar = contar + 1
        Else
            WFrm_DISEÑO_MESAS.bm38.Enabled = False
            WFrm_DISEÑO_MESAS.bm38.Visible = False
        End If
        If e39 = "1" Then
            WFrm_DISEÑO_MESAS.bm39.Enabled = True
            WFrm_DISEÑO_MESAS.bm39.Visible = True
            contar = contar + 1
        Else
            WFrm_DISEÑO_MESAS.bm39.Enabled = False
            WFrm_DISEÑO_MESAS.bm39.Visible = False
        End If
        If e40 = "1" Then
            WFrm_DISEÑO_MESAS.bm40.Enabled = True
            WFrm_DISEÑO_MESAS.bm40.Visible = True
            contar = contar + 1
        Else
            WFrm_DISEÑO_MESAS.bm40.Enabled = False
            WFrm_DISEÑO_MESAS.bm40.Visible = False
        End If
        If e41 = "1" Then
            WFrm_DISEÑO_MESAS.bm41.Enabled = True
            WFrm_DISEÑO_MESAS.bm41.Visible = True
            contar = contar + 1
        Else
            WFrm_DISEÑO_MESAS.bm41.Enabled = False
            WFrm_DISEÑO_MESAS.bm41.Visible = False
        End If
        If e42 = "1" Then
            WFrm_DISEÑO_MESAS.bm42.Enabled = True
            WFrm_DISEÑO_MESAS.bm42.Visible = True
            contar = contar + 1
        Else
            WFrm_DISEÑO_MESAS.bm42.Enabled = False
            WFrm_DISEÑO_MESAS.bm42.Visible = False
        End If
        If e43 = "1" Then
            WFrm_DISEÑO_MESAS.bm43.Enabled = True
            WFrm_DISEÑO_MESAS.bm43.Visible = True
            contar = contar + 1
        Else
            WFrm_DISEÑO_MESAS.bm43.Enabled = False
            WFrm_DISEÑO_MESAS.bm43.Visible = False
        End If
        If e44 = "1" Then
            WFrm_DISEÑO_MESAS.bm44.Enabled = True
            WFrm_DISEÑO_MESAS.bm44.Visible = True
            contar = contar + 1
        Else
            WFrm_DISEÑO_MESAS.bm44.Enabled = False
            WFrm_DISEÑO_MESAS.bm44.Visible = False
        End If
        If e45 = "1" Then
            WFrm_DISEÑO_MESAS.bm45.Enabled = True
            WFrm_DISEÑO_MESAS.bm45.Visible = True
            contar = contar + 1
        Else
            WFrm_DISEÑO_MESAS.bm45.Enabled = False
            WFrm_DISEÑO_MESAS.bm45.Visible = False
        End If
        If e46 = "1" Then
            WFrm_DISEÑO_MESAS.bm46.Enabled = True
            WFrm_DISEÑO_MESAS.bm46.Visible = True
            contar = contar + 1
        Else
            WFrm_DISEÑO_MESAS.bm46.Enabled = False
            WFrm_DISEÑO_MESAS.bm46.Visible = False
        End If
        If e47 = "1" Then
            WFrm_DISEÑO_MESAS.bm47.Enabled = True
            WFrm_DISEÑO_MESAS.bm47.Visible = True
            contar = contar + 1
        Else
            WFrm_DISEÑO_MESAS.bm47.Enabled = False
            WFrm_DISEÑO_MESAS.bm47.Visible = False
        End If
        If e48 = "1" Then
            WFrm_DISEÑO_MESAS.bm48.Enabled = True
            WFrm_DISEÑO_MESAS.bm48.Visible = True
            contar = contar + 1
        Else
            WFrm_DISEÑO_MESAS.bm48.Enabled = False
            WFrm_DISEÑO_MESAS.bm48.Visible = False
        End If
        If e49 = "1" Then
            WFrm_DISEÑO_MESAS.bm49.Enabled = True
            WFrm_DISEÑO_MESAS.bm49.Visible = True
            contar = contar + 1
        Else
            WFrm_DISEÑO_MESAS.bm49.Enabled = False
            WFrm_DISEÑO_MESAS.bm49.Visible = False
        End If
        If e50 = "1" Then
            WFrm_DISEÑO_MESAS.bm50.Enabled = True
            WFrm_DISEÑO_MESAS.bm50.Visible = True
            contar = contar + 1
        Else
            WFrm_DISEÑO_MESAS.bm50.Enabled = False
            WFrm_DISEÑO_MESAS.bm50.Visible = False
        End If


        WFrm_DISEÑO_MESAS.ButtonX20.Text = contar - contaocupado


        '    WFrm_DISEÑO_MESAS.ButtonX23.Text = 24 - contar
    End Sub

    Public contaocupado As Integer
    Public DISPONIBLES As Integer
    Public Sub Ocupado_mesas()
        actualiza_panel_mesas()


            If m1 = NombreMesa Then
                WFrm_DISEÑO_MESAS.bm1.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
            WFrm_DISEÑO_MESAS.bm1.BackColor = Color.Red

            Else
            WFrm_DISEÑO_MESAS.bm1.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb

            End If
            If m2 = NombreMesa Then
                WFrm_DISEÑO_MESAS.bm2.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
            WFrm_DISEÑO_MESAS.bm2.BackColor = Color.Red

            Else
            WFrm_DISEÑO_MESAS.bm2.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb

            End If
            If m3 = NombreMesa Then
                WFrm_DISEÑO_MESAS.bm3.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
            WFrm_DISEÑO_MESAS.bm3.BackColor = Color.Red

            Else
                WFrm_DISEÑO_MESAS.bm3.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
            End If
            If m4 = NombreMesa Then
                WFrm_DISEÑO_MESAS.bm4.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
            WFrm_DISEÑO_MESAS.bm4.BackColor = Color.Red
        Else
            WFrm_DISEÑO_MESAS.bm4.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
            End If
            If m5 = NombreMesa Then
                WFrm_DISEÑO_MESAS.bm5.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
            WFrm_DISEÑO_MESAS.bm5.BackColor = Color.Red
        Else
            WFrm_DISEÑO_MESAS.bm5.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        End If
        If m6 = NombreMesa Then
            WFrm_DISEÑO_MESAS.bm6.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
            WFrm_DISEÑO_MESAS.bm6.BackColor = Color.Red
        Else
            WFrm_DISEÑO_MESAS.bm6.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        End If
        If m7 = NombreMesa Then
            WFrm_DISEÑO_MESAS.bm7.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
            WFrm_DISEÑO_MESAS.bm7.BackColor = Color.Red
        Else
            WFrm_DISEÑO_MESAS.bm7.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        End If
        If m8 = NombreMesa Then
            WFrm_DISEÑO_MESAS.bm8.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
            WFrm_DISEÑO_MESAS.bm8.BackColor = Color.Red
        Else
            WFrm_DISEÑO_MESAS.bm8.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        End If
        If m9 = NombreMesa Then
            WFrm_DISEÑO_MESAS.bm9.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
            WFrm_DISEÑO_MESAS.bm9.BackColor = Color.Red
        Else
            WFrm_DISEÑO_MESAS.bm9.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        End If
        If m10 = NombreMesa Then
            WFrm_DISEÑO_MESAS.bm10.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
            WFrm_DISEÑO_MESAS.bm10.BackColor = Color.Red
        Else
            WFrm_DISEÑO_MESAS.bm10.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        End If

        '-------------------------------------------------

        If m11 = NombreMesa Then
            WFrm_DISEÑO_MESAS.bm11.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
            WFrm_DISEÑO_MESAS.bm11.BackColor = Color.Red
        Else
            WFrm_DISEÑO_MESAS.bm11.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        End If
        If m12 = NombreMesa Then
            WFrm_DISEÑO_MESAS.bm12.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
            WFrm_DISEÑO_MESAS.bm12.BackColor = Color.Red
        Else
            WFrm_DISEÑO_MESAS.bm12.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        End If
        If m13 = NombreMesa Then
            WFrm_DISEÑO_MESAS.bm13.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
            WFrm_DISEÑO_MESAS.bm13.BackColor = Color.Red
        Else
            WFrm_DISEÑO_MESAS.bm13.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        End If
        If m14 = NombreMesa Then
            WFrm_DISEÑO_MESAS.bm14.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
            WFrm_DISEÑO_MESAS.bm14.BackColor = Color.Red
        Else
            WFrm_DISEÑO_MESAS.bm14.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        End If
        If m15 = NombreMesa Then
            WFrm_DISEÑO_MESAS.bm15.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
            WFrm_DISEÑO_MESAS.bm15.BackColor = Color.Red
        Else
            WFrm_DISEÑO_MESAS.bm15.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        End If
        If m16 = NombreMesa Then
            WFrm_DISEÑO_MESAS.bm16.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
            WFrm_DISEÑO_MESAS.bm16.BackColor = Color.Red
        Else
            WFrm_DISEÑO_MESAS.bm16.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        End If
        If m17 = NombreMesa Then
            WFrm_DISEÑO_MESAS.bm17.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
            WFrm_DISEÑO_MESAS.bm17.BackColor = Color.Red
        Else
            WFrm_DISEÑO_MESAS.bm17.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        End If
        If m18 = NombreMesa Then
            WFrm_DISEÑO_MESAS.bm18.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
            WFrm_DISEÑO_MESAS.bm18.BackColor = Color.Red
        Else
            WFrm_DISEÑO_MESAS.bm18.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        End If
        If m19 = NombreMesa Then
            WFrm_DISEÑO_MESAS.bm19.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
            WFrm_DISEÑO_MESAS.bm19.BackColor = Color.Red
        Else
            WFrm_DISEÑO_MESAS.bm19.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        End If
        If m20 = NombreMesa Then
            WFrm_DISEÑO_MESAS.bm20.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
            WFrm_DISEÑO_MESAS.bm20.BackColor = Color.Red
        Else
            WFrm_DISEÑO_MESAS.bm20.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        End If
        If m21 = NombreMesa Then
            WFrm_DISEÑO_MESAS.bm21.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
            WFrm_DISEÑO_MESAS.bm21.BackColor = Color.Red
        Else
            WFrm_DISEÑO_MESAS.bm21.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        End If
        If m22 = NombreMesa Then
            WFrm_DISEÑO_MESAS.bm22.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
            WFrm_DISEÑO_MESAS.bm22.BackColor = Color.Red
        Else
            WFrm_DISEÑO_MESAS.bm22.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        End If
        If m23 = NombreMesa Then
            WFrm_DISEÑO_MESAS.bm23.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
            WFrm_DISEÑO_MESAS.bm23.BackColor = Color.Red
        Else
            WFrm_DISEÑO_MESAS.bm23.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        End If
        If m24 = NombreMesa Then
            WFrm_DISEÑO_MESAS.bm24.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
            WFrm_DISEÑO_MESAS.bm24.BackColor = Color.Red
        Else
            WFrm_DISEÑO_MESAS.bm24.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        End If
        If m25 = NombreMesa Then
            WFrm_DISEÑO_MESAS.bm25.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
            WFrm_DISEÑO_MESAS.bm25.BackColor = Color.Red
        Else
            WFrm_DISEÑO_MESAS.bm25.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        End If
        If m26 = NombreMesa Then
            WFrm_DISEÑO_MESAS.bm26.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
            WFrm_DISEÑO_MESAS.bm26.BackColor = Color.Red
        Else
            WFrm_DISEÑO_MESAS.bm26.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        End If
        If m27 = NombreMesa Then
            WFrm_DISEÑO_MESAS.bm27.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
            WFrm_DISEÑO_MESAS.bm27.BackColor = Color.Red
        Else
            WFrm_DISEÑO_MESAS.bm27.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        End If
        If m28 = NombreMesa Then
            WFrm_DISEÑO_MESAS.bm28.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
            WFrm_DISEÑO_MESAS.bm28.BackColor = Color.Red
        Else
            WFrm_DISEÑO_MESAS.bm28.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        End If
        If m29 = NombreMesa Then
            WFrm_DISEÑO_MESAS.bm29.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
            WFrm_DISEÑO_MESAS.bm29.BackColor = Color.Red
        Else
            WFrm_DISEÑO_MESAS.bm29.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        End If
        If m30 = NombreMesa Then
            WFrm_DISEÑO_MESAS.bm30.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
            WFrm_DISEÑO_MESAS.bm30.BackColor = Color.Red
        Else
            WFrm_DISEÑO_MESAS.bm30.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        End If
        If m31 = NombreMesa Then
            WFrm_DISEÑO_MESAS.bm31.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
            WFrm_DISEÑO_MESAS.bm31.BackColor = Color.Red
        Else
            WFrm_DISEÑO_MESAS.bm31.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        End If
        If m32 = NombreMesa Then
            WFrm_DISEÑO_MESAS.bm32.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
            WFrm_DISEÑO_MESAS.bm32.BackColor = Color.Red
        Else
            WFrm_DISEÑO_MESAS.bm32.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        End If
        If m33 = NombreMesa Then
            WFrm_DISEÑO_MESAS.bm33.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
            WFrm_DISEÑO_MESAS.bm33.BackColor = Color.Red
        Else
            WFrm_DISEÑO_MESAS.bm33.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        End If
        If m34 = NombreMesa Then
            WFrm_DISEÑO_MESAS.bm34.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
            WFrm_DISEÑO_MESAS.bm34.BackColor = Color.Red
        Else
            WFrm_DISEÑO_MESAS.bm34.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        End If
        If m35 = NombreMesa Then
            WFrm_DISEÑO_MESAS.bm35.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
            WFrm_DISEÑO_MESAS.bm35.BackColor = Color.Red
        Else
            WFrm_DISEÑO_MESAS.bm35.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        End If
        If m36 = NombreMesa Then
            WFrm_DISEÑO_MESAS.bm36.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
            WFrm_DISEÑO_MESAS.bm36.BackColor = Color.Red
        Else
            WFrm_DISEÑO_MESAS.bm36.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        End If
        If m37 = NombreMesa Then
            WFrm_DISEÑO_MESAS.bm37.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
            WFrm_DISEÑO_MESAS.bm37.BackColor = Color.Red
        Else
            WFrm_DISEÑO_MESAS.bm37.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        End If
        If m38 = NombreMesa Then
            WFrm_DISEÑO_MESAS.bm38.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
            WFrm_DISEÑO_MESAS.bm38.BackColor = Color.Red
        Else
            WFrm_DISEÑO_MESAS.bm38.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        End If
        If m39 = NombreMesa Then
            WFrm_DISEÑO_MESAS.bm39.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
            WFrm_DISEÑO_MESAS.bm39.BackColor = Color.Red
        Else
            WFrm_DISEÑO_MESAS.bm39.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        End If
        If m40 = NombreMesa Then
            WFrm_DISEÑO_MESAS.bm40.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
            WFrm_DISEÑO_MESAS.bm40.BackColor = Color.Red
        Else
            WFrm_DISEÑO_MESAS.bm40.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        End If
        If m41 = NombreMesa Then
            WFrm_DISEÑO_MESAS.bm41.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
            WFrm_DISEÑO_MESAS.bm41.BackColor = Color.Red
        Else
            WFrm_DISEÑO_MESAS.bm41.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        End If
        If m42 = NombreMesa Then
            WFrm_DISEÑO_MESAS.bm42.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
            WFrm_DISEÑO_MESAS.bm42.BackColor = Color.Red
        Else
            WFrm_DISEÑO_MESAS.bm42.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        End If
        If m43 = NombreMesa Then
            WFrm_DISEÑO_MESAS.bm43.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
            WFrm_DISEÑO_MESAS.bm43.BackColor = Color.Red
        Else
            WFrm_DISEÑO_MESAS.bm43.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        End If
        If m44 = NombreMesa Then
            WFrm_DISEÑO_MESAS.bm44.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
            WFrm_DISEÑO_MESAS.bm44.BackColor = Color.Red
        Else
            WFrm_DISEÑO_MESAS.bm44.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        End If
        If m45 = NombreMesa Then
            WFrm_DISEÑO_MESAS.bm45.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
            WFrm_DISEÑO_MESAS.bm45.BackColor = Color.Red
        Else
            WFrm_DISEÑO_MESAS.bm45.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        End If
        If m46 = NombreMesa Then
            WFrm_DISEÑO_MESAS.bm46.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
            WFrm_DISEÑO_MESAS.bm46.BackColor = Color.Red
        Else
            WFrm_DISEÑO_MESAS.bm46.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        End If
        If m47 = NombreMesa Then
            WFrm_DISEÑO_MESAS.bm47.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
            WFrm_DISEÑO_MESAS.bm47.BackColor = Color.Red
        Else
            WFrm_DISEÑO_MESAS.bm47.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        End If
        If m48 = NombreMesa Then
            WFrm_DISEÑO_MESAS.bm48.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
            WFrm_DISEÑO_MESAS.bm48.BackColor = Color.Red
        Else
            WFrm_DISEÑO_MESAS.bm48.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        End If
        If m49 = NombreMesa Then
            WFrm_DISEÑO_MESAS.bm49.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
            WFrm_DISEÑO_MESAS.bm49.BackColor = Color.Red
        Else
            WFrm_DISEÑO_MESAS.bm49.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        End If
        If m50 = NombreMesa Then
            WFrm_DISEÑO_MESAS.bm50.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
            WFrm_DISEÑO_MESAS.bm50.BackColor = Color.Red
        Else
            WFrm_DISEÑO_MESAS.bm50.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        End If
        Cargar_Mesas_Ocupadas()
    End Sub



    Public Sub Cargar_Mesas_Ocupadas()
        WFrm_DISEÑO_MESAS.DataGridView1.DataSource = objnegocio.MOSTRAR_ACTIVAS_OCUPADAS(objentidade)
        contaocupado = 0
        For z = 0 To WFrm_DISEÑO_MESAS.DataGridView1.RowCount - 2
            NombreMesa = WFrm_DISEÑO_MESAS.DataGridView1.Rows.Item(z).Cells(0).Value


            If m1 = NombreMesa Then
                WFrm_DISEÑO_MESAS.bm1.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
                WFrm_DISEÑO_MESAS.bm1.BackColor = Color.Red
                contaocupado = contaocupado + 1
            End If
            If m2 = NombreMesa Then
                WFrm_DISEÑO_MESAS.bm2.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
                WFrm_DISEÑO_MESAS.bm2.BackColor = Color.Red
                contaocupado = contaocupado + 1
            End If
            If m3 = NombreMesa Then
                WFrm_DISEÑO_MESAS.bm3.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
                WFrm_DISEÑO_MESAS.bm3.BackColor = Color.Red
                contaocupado = contaocupado + 1
            End If
            If m4 = NombreMesa Then
                WFrm_DISEÑO_MESAS.bm4.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
                WFrm_DISEÑO_MESAS.bm4.BackColor = Color.Red
                contaocupado = contaocupado + 1
            End If
            If m5 = NombreMesa Then
                WFrm_DISEÑO_MESAS.bm5.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
                WFrm_DISEÑO_MESAS.bm5.BackColor = Color.Red
                contaocupado = contaocupado + 1
            End If
            If m6 = NombreMesa Then
                WFrm_DISEÑO_MESAS.bm6.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
                WFrm_DISEÑO_MESAS.bm6.BackColor = Color.Red
                contaocupado = contaocupado + 1
            End If
            If m7 = NombreMesa Then
                WFrm_DISEÑO_MESAS.bm7.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
                WFrm_DISEÑO_MESAS.bm7.BackColor = Color.Red
                contaocupado = contaocupado + 1
            End If
            If m8 = NombreMesa Then
                WFrm_DISEÑO_MESAS.bm8.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
                WFrm_DISEÑO_MESAS.bm8.BackColor = Color.Red
                contaocupado = contaocupado + 1
            End If
            If m9 = NombreMesa Then
                WFrm_DISEÑO_MESAS.bm9.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
                WFrm_DISEÑO_MESAS.bm9.BackColor = Color.Red
                contaocupado = contaocupado + 1
            End If
            If m10 = NombreMesa Then
                WFrm_DISEÑO_MESAS.bm10.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
                WFrm_DISEÑO_MESAS.bm10.BackColor = Color.Red
                contaocupado = contaocupado + 1
            End If
            If m11 = NombreMesa Then
                WFrm_DISEÑO_MESAS.bm11.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
                WFrm_DISEÑO_MESAS.bm11.BackColor = Color.Red
                contaocupado = contaocupado + 1
            End If
            If m12 = NombreMesa Then
                WFrm_DISEÑO_MESAS.bm12.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
                WFrm_DISEÑO_MESAS.bm12.BackColor = Color.Red
                contaocupado = contaocupado + 1
            End If
            If m13 = NombreMesa Then
                WFrm_DISEÑO_MESAS.bm13.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
                WFrm_DISEÑO_MESAS.bm13.BackColor = Color.Red
                contaocupado = contaocupado + 1
            End If
            If m14 = NombreMesa Then
                WFrm_DISEÑO_MESAS.bm14.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
                WFrm_DISEÑO_MESAS.bm14.BackColor = Color.Red
                contaocupado = contaocupado + 1
            End If
            If m15 = NombreMesa Then
                WFrm_DISEÑO_MESAS.bm15.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
                WFrm_DISEÑO_MESAS.bm15.BackColor = Color.Red
                contaocupado = contaocupado + 1
            End If
            If m16 = NombreMesa Then
                WFrm_DISEÑO_MESAS.bm16.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
                WFrm_DISEÑO_MESAS.bm16.BackColor = Color.Red
                contaocupado = contaocupado + 1
            End If
            If m17 = NombreMesa Then
                WFrm_DISEÑO_MESAS.bm17.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
                WFrm_DISEÑO_MESAS.bm17.BackColor = Color.Red
                contaocupado = contaocupado + 1
            End If
            If m18 = NombreMesa Then
                WFrm_DISEÑO_MESAS.bm18.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
                WFrm_DISEÑO_MESAS.bm18.BackColor = Color.Red
                contaocupado = contaocupado + 1
            End If
            If m19 = NombreMesa Then
                WFrm_DISEÑO_MESAS.bm19.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
                WFrm_DISEÑO_MESAS.bm19.BackColor = Color.Red
                contaocupado = contaocupado + 1
            End If

            If m20 = NombreMesa Then
                WFrm_DISEÑO_MESAS.bm20.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
                WFrm_DISEÑO_MESAS.bm20.BackColor = Color.Red
                contaocupado = contaocupado + 1
            End If
            If m21 = NombreMesa Then
                WFrm_DISEÑO_MESAS.bm21.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
                WFrm_DISEÑO_MESAS.bm21.BackColor = Color.Red
                contaocupado = contaocupado + 1
            End If
            If m22 = NombreMesa Then
                WFrm_DISEÑO_MESAS.bm22.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
                WFrm_DISEÑO_MESAS.bm22.BackColor = Color.Red
                contaocupado = contaocupado + 1
            End If
            If m23 = NombreMesa Then
                WFrm_DISEÑO_MESAS.bm23.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
                WFrm_DISEÑO_MESAS.bm23.BackColor = Color.Red
                contaocupado = contaocupado + 1
            End If
            If m23 = NombreMesa Then
                WFrm_DISEÑO_MESAS.bm23.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
                WFrm_DISEÑO_MESAS.bm23.BackColor = Color.Red
                contaocupado = contaocupado + 1
            End If
            If m24 = NombreMesa Then
                WFrm_DISEÑO_MESAS.bm24.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
                WFrm_DISEÑO_MESAS.bm24.BackColor = Color.Red
                contaocupado = contaocupado + 1
            End If
            If m25 = NombreMesa Then
                WFrm_DISEÑO_MESAS.bm25.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
                WFrm_DISEÑO_MESAS.bm25.BackColor = Color.Red
                contaocupado = contaocupado + 1
            End If
            If m26 = NombreMesa Then
                WFrm_DISEÑO_MESAS.bm26.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
                WFrm_DISEÑO_MESAS.bm26.BackColor = Color.Red
                contaocupado = contaocupado + 1
            End If
            If m27 = NombreMesa Then
                WFrm_DISEÑO_MESAS.bm27.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
                WFrm_DISEÑO_MESAS.bm27.BackColor = Color.Red
                contaocupado = contaocupado + 1
            End If
            If m28 = NombreMesa Then
                WFrm_DISEÑO_MESAS.bm28.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
                WFrm_DISEÑO_MESAS.bm28.BackColor = Color.Red
                contaocupado = contaocupado + 1
            End If
            If m29 = NombreMesa Then
                WFrm_DISEÑO_MESAS.bm29.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
                WFrm_DISEÑO_MESAS.bm29.BackColor = Color.Red
                contaocupado = contaocupado + 1
            End If
            If m30 = NombreMesa Then
                WFrm_DISEÑO_MESAS.bm30.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
                WFrm_DISEÑO_MESAS.bm30.BackColor = Color.Red
                contaocupado = contaocupado + 1
            End If
            If m31 = NombreMesa Then
                WFrm_DISEÑO_MESAS.bm31.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
                WFrm_DISEÑO_MESAS.bm31.BackColor = Color.Red
                contaocupado = contaocupado + 1
            End If
            If m32 = NombreMesa Then
                WFrm_DISEÑO_MESAS.bm32.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
                WFrm_DISEÑO_MESAS.bm32.BackColor = Color.Red
                contaocupado = contaocupado + 1
            End If
            If m33 = NombreMesa Then
                WFrm_DISEÑO_MESAS.bm33.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
                WFrm_DISEÑO_MESAS.bm33.BackColor = Color.Red
                contaocupado = contaocupado + 1
            End If
            If m34 = NombreMesa Then
                WFrm_DISEÑO_MESAS.bm34.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
                WFrm_DISEÑO_MESAS.bm34.BackColor = Color.Red
                contaocupado = contaocupado + 1
            End If
            If m35 = NombreMesa Then
                WFrm_DISEÑO_MESAS.bm35.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
                WFrm_DISEÑO_MESAS.bm35.BackColor = Color.Red
                contaocupado = contaocupado + 1
            End If
            If m36 = NombreMesa Then
                WFrm_DISEÑO_MESAS.bm36.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
                WFrm_DISEÑO_MESAS.bm36.BackColor = Color.Red
                contaocupado = contaocupado + 1
            End If
            If m37 = NombreMesa Then
                WFrm_DISEÑO_MESAS.bm37.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
                WFrm_DISEÑO_MESAS.bm37.BackColor = Color.Red
                contaocupado = contaocupado + 1
            End If
            If m38 = NombreMesa Then
                WFrm_DISEÑO_MESAS.bm38.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
                WFrm_DISEÑO_MESAS.bm38.BackColor = Color.Red
                contaocupado = contaocupado + 1
            End If
            If m39 = NombreMesa Then
                WFrm_DISEÑO_MESAS.bm39.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
                WFrm_DISEÑO_MESAS.bm39.BackColor = Color.Red
                contaocupado = contaocupado + 1
            End If
            If m40 = NombreMesa Then
                WFrm_DISEÑO_MESAS.bm40.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
                WFrm_DISEÑO_MESAS.bm40.BackColor = Color.Red
                contaocupado = contaocupado + 1
            End If
            If m41 = NombreMesa Then
                WFrm_DISEÑO_MESAS.bm41.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
                WFrm_DISEÑO_MESAS.bm41.BackColor = Color.Red
                contaocupado = contaocupado + 1
            End If
            If m42 = NombreMesa Then
                WFrm_DISEÑO_MESAS.bm42.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
                WFrm_DISEÑO_MESAS.bm42.BackColor = Color.Red
                contaocupado = contaocupado + 1
            End If
            If m43 = NombreMesa Then
                WFrm_DISEÑO_MESAS.bm43.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
                WFrm_DISEÑO_MESAS.bm43.BackColor = Color.Red
                contaocupado = contaocupado + 1
            End If
            If m44 = NombreMesa Then
                WFrm_DISEÑO_MESAS.bm44.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
                WFrm_DISEÑO_MESAS.bm44.BackColor = Color.Red
                contaocupado = contaocupado + 1
            End If
            If m45 = NombreMesa Then
                WFrm_DISEÑO_MESAS.bm45.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
                WFrm_DISEÑO_MESAS.bm45.BackColor = Color.Red
                contaocupado = contaocupado + 1
            End If
            If m46 = NombreMesa Then
                WFrm_DISEÑO_MESAS.bm46.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
                WFrm_DISEÑO_MESAS.bm46.BackColor = Color.Red
                contaocupado = contaocupado + 1
            End If
            If m47 = NombreMesa Then
                WFrm_DISEÑO_MESAS.bm47.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
                WFrm_DISEÑO_MESAS.bm47.BackColor = Color.Red
                contaocupado = contaocupado + 1
            End If
            If m48 = NombreMesa Then
                WFrm_DISEÑO_MESAS.bm48.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
                WFrm_DISEÑO_MESAS.bm48.BackColor = Color.Red
                contaocupado = contaocupado + 1
            End If
            If m49 = NombreMesa Then
                WFrm_DISEÑO_MESAS.bm49.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
                WFrm_DISEÑO_MESAS.bm49.BackColor = Color.Red
                contaocupado = contaocupado + 1
            End If
            If m50 = NombreMesa Then
                WFrm_DISEÑO_MESAS.bm50.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
                WFrm_DISEÑO_MESAS.bm50.BackColor = Color.Red
                contaocupado = contaocupado + 1
            End If
        Next
        WFrm_DISEÑO_MESAS.Label4.Text = contaocupado

        WFrm_DISEÑO_MESAS.ButtonX20.Text = contar - contaocupado
    End Sub

    '*------------------------------------------------------------------------------


    Public Sub HORARIO()
        Dim FECHAS As String
        WFrm_DISEÑO_MESAS.DataGridView1.DataSource = objnegocio.MOSTRAR_ACTIVAS_OCUPADAS(objentidade)

        For z = 0 To WFrm_DISEÑO_MESAS.DataGridView1.RowCount - 2
            NombreMesa = WFrm_DISEÑO_MESAS.DataGridView1.Rows.Item(z).Cells(0).Value
            'NombreMesa = WFrm_DISEÑO_MESAS.DataGridView1.Rows.Item(z).Cells(2).Value

            If m1 = NombreMesa Then

                WFrm_DISEÑO_MESAS.H1.Visible = True
                Dim final As String = Now.ToString("HH:mm:ss")
                Dim inicial As String = WFrm_DISEÑO_MESAS.DataGridView1.Rows.Item(z).Cells(2).Value
                Dim tiempoI As TimeSpan = TimeSpan.Parse(inicial)
                Dim tiempoF As TimeSpan = TimeSpan.Parse(final)
                Dim resta As TimeSpan = tiempoF - tiempoI
                WFrm_DISEÑO_MESAS.H1.Text = resta.ToString
            End If
            If m2 = NombreMesa Then
                WFrm_DISEÑO_MESAS.H2.Visible = True
                Dim final As String = Now.ToString("HH:mm:ss")
                Dim inicial As String = WFrm_DISEÑO_MESAS.DataGridView1.Rows.Item(z).Cells(2).Value
                Dim tiempoI As TimeSpan = TimeSpan.Parse(inicial)
                Dim tiempoF As TimeSpan = TimeSpan.Parse(final)
                Dim resta As TimeSpan = tiempoF - tiempoI
                WFrm_DISEÑO_MESAS.H2.Text = resta.ToString
            End If
            If m3 = NombreMesa Then
                WFrm_DISEÑO_MESAS.H3.Visible = True
                Dim final As String = Now.ToString("HH:mm:ss")
                Dim inicial As String = WFrm_DISEÑO_MESAS.DataGridView1.Rows.Item(z).Cells(2).Value
                Dim tiempoI As TimeSpan = TimeSpan.Parse(inicial)
                Dim tiempoF As TimeSpan = TimeSpan.Parse(final)
                Dim resta As TimeSpan = tiempoF - tiempoI
                WFrm_DISEÑO_MESAS.H3.Text = resta.ToString
            End If
            If m4 = NombreMesa Then
                WFrm_DISEÑO_MESAS.H4.Visible = True
                Dim final As String = Now.ToString("HH:mm:ss")
                Dim inicial As String = WFrm_DISEÑO_MESAS.DataGridView1.Rows.Item(z).Cells(2).Value
                Dim tiempoI As TimeSpan = TimeSpan.Parse(inicial)
                Dim tiempoF As TimeSpan = TimeSpan.Parse(final)
                Dim resta As TimeSpan = tiempoF - tiempoI
                WFrm_DISEÑO_MESAS.H4.Text = resta.ToString
            End If
            If m5 = NombreMesa Then
                WFrm_DISEÑO_MESAS.H5.Visible = True
                Dim final As String = Now.ToString("HH:mm:ss")
                Dim inicial As String = WFrm_DISEÑO_MESAS.DataGridView1.Rows.Item(z).Cells(2).Value
                Dim tiempoI As TimeSpan = TimeSpan.Parse(inicial)
                Dim tiempoF As TimeSpan = TimeSpan.Parse(final)
                Dim resta As TimeSpan = tiempoF - tiempoI
                WFrm_DISEÑO_MESAS.H5.Text = resta.ToString
            End If
            If m6 = NombreMesa Then
                WFrm_DISEÑO_MESAS.H6.Visible = True
                Dim final As String = Now.ToString("HH:mm:ss")
                Dim inicial As String = WFrm_DISEÑO_MESAS.DataGridView1.Rows.Item(z).Cells(2).Value
                Dim tiempoI As TimeSpan = TimeSpan.Parse(inicial)
                Dim tiempoF As TimeSpan = TimeSpan.Parse(final)
                Dim resta As TimeSpan = tiempoF - tiempoI
                WFrm_DISEÑO_MESAS.H6.Text = resta.ToString
            End If
            If m7 = NombreMesa Then
                WFrm_DISEÑO_MESAS.H7.Visible = True
                Dim final As String = Now.ToString("HH:mm:ss")
                Dim inicial As String = WFrm_DISEÑO_MESAS.DataGridView1.Rows.Item(z).Cells(2).Value
                Dim tiempoI As TimeSpan = TimeSpan.Parse(inicial)
                Dim tiempoF As TimeSpan = TimeSpan.Parse(final)
                Dim resta As TimeSpan = tiempoF - tiempoI
                WFrm_DISEÑO_MESAS.H7.Text = resta.ToString
            End If
            If m8 = NombreMesa Then
                WFrm_DISEÑO_MESAS.H8.Visible = True
                Dim final As String = Now.ToString("HH:mm:ss")
                Dim inicial As String = WFrm_DISEÑO_MESAS.DataGridView1.Rows.Item(z).Cells(2).Value
                Dim tiempoI As TimeSpan = TimeSpan.Parse(inicial)
                Dim tiempoF As TimeSpan = TimeSpan.Parse(final)
                Dim resta As TimeSpan = tiempoF - tiempoI
                WFrm_DISEÑO_MESAS.H8.Text = resta.ToString
            End If
            If m9 = NombreMesa Then
                WFrm_DISEÑO_MESAS.H9.Visible = True
                Dim final As String = Now.ToString("HH:mm:ss")
                Dim inicial As String = WFrm_DISEÑO_MESAS.DataGridView1.Rows.Item(z).Cells(2).Value
                Dim tiempoI As TimeSpan = TimeSpan.Parse(inicial)
                Dim tiempoF As TimeSpan = TimeSpan.Parse(final)
                Dim resta As TimeSpan = tiempoF - tiempoI
                WFrm_DISEÑO_MESAS.H9.Text = resta.ToString
            End If
            If m10 = NombreMesa Then
                WFrm_DISEÑO_MESAS.H10.Visible = True
                Dim final As String = Now.ToString("HH:mm:ss")
                Dim inicial As String = WFrm_DISEÑO_MESAS.DataGridView1.Rows.Item(z).Cells(2).Value
                Dim tiempoI As TimeSpan = TimeSpan.Parse(inicial)
                Dim tiempoF As TimeSpan = TimeSpan.Parse(final)
                Dim resta As TimeSpan = tiempoF - tiempoI
                WFrm_DISEÑO_MESAS.H10.Text = resta.ToString
            End If
            If m11 = NombreMesa Then
                WFrm_DISEÑO_MESAS.H11.Visible = True
                Dim final As String = Now.ToString("HH:mm:ss")
                Dim inicial As String = WFrm_DISEÑO_MESAS.DataGridView1.Rows.Item(z).Cells(2).Value
                Dim tiempoI As TimeSpan = TimeSpan.Parse(inicial)
                Dim tiempoF As TimeSpan = TimeSpan.Parse(final)
                Dim resta As TimeSpan = tiempoF - tiempoI
                WFrm_DISEÑO_MESAS.H11.Text = resta.ToString
            End If
            If m12 = NombreMesa Then
                WFrm_DISEÑO_MESAS.H12.Visible = True
                Dim final As String = Now.ToString("HH:mm:ss")
                Dim inicial As String = WFrm_DISEÑO_MESAS.DataGridView1.Rows.Item(z).Cells(2).Value
                Dim tiempoI As TimeSpan = TimeSpan.Parse(inicial)
                Dim tiempoF As TimeSpan = TimeSpan.Parse(final)
                Dim resta As TimeSpan = tiempoF - tiempoI
                WFrm_DISEÑO_MESAS.H12.Text = resta.ToString
            End If
            If m13 = NombreMesa Then
                WFrm_DISEÑO_MESAS.H13.Visible = True
                Dim final As String = Now.ToString("HH:mm:ss")
                Dim inicial As String = WFrm_DISEÑO_MESAS.DataGridView1.Rows.Item(z).Cells(2).Value
                Dim tiempoI As TimeSpan = TimeSpan.Parse(inicial)
                Dim tiempoF As TimeSpan = TimeSpan.Parse(final)
                Dim resta As TimeSpan = tiempoF - tiempoI
                WFrm_DISEÑO_MESAS.H13.Text = resta.ToString
            End If
            If m14 = NombreMesa Then
                WFrm_DISEÑO_MESAS.H14.Visible = True
                Dim final As String = Now.ToString("HH:mm:ss")
                Dim inicial As String = WFrm_DISEÑO_MESAS.DataGridView1.Rows.Item(z).Cells(2).Value
                Dim tiempoI As TimeSpan = TimeSpan.Parse(inicial)
                Dim tiempoF As TimeSpan = TimeSpan.Parse(final)
                Dim resta As TimeSpan = tiempoF - tiempoI
                WFrm_DISEÑO_MESAS.H14.Text = resta.ToString
            End If
            If m15 = NombreMesa Then
                WFrm_DISEÑO_MESAS.H15.Visible = True
                Dim final As String = Now.ToString("HH:mm:ss")
                Dim inicial As String = WFrm_DISEÑO_MESAS.DataGridView1.Rows.Item(z).Cells(2).Value
                Dim tiempoI As TimeSpan = TimeSpan.Parse(inicial)
                Dim tiempoF As TimeSpan = TimeSpan.Parse(final)
                Dim resta As TimeSpan = tiempoF - tiempoI
                WFrm_DISEÑO_MESAS.H15.Text = resta.ToString
            End If
            If m16 = NombreMesa Then
                WFrm_DISEÑO_MESAS.H16.Visible = True
                Dim final As String = Now.ToString("HH:mm:ss")
                Dim inicial As String = WFrm_DISEÑO_MESAS.DataGridView1.Rows.Item(z).Cells(2).Value
                Dim tiempoI As TimeSpan = TimeSpan.Parse(inicial)
                Dim tiempoF As TimeSpan = TimeSpan.Parse(final)
                Dim resta As TimeSpan = tiempoF - tiempoI
                WFrm_DISEÑO_MESAS.H16.Text = resta.ToString
            End If
            If m17 = NombreMesa Then
                WFrm_DISEÑO_MESAS.H17.Visible = True
                Dim final As String = Now.ToString("HH:mm:ss")
                Dim inicial As String = WFrm_DISEÑO_MESAS.DataGridView1.Rows.Item(z).Cells(2).Value
                Dim tiempoI As TimeSpan = TimeSpan.Parse(inicial)
                Dim tiempoF As TimeSpan = TimeSpan.Parse(final)
                Dim resta As TimeSpan = tiempoF - tiempoI
                WFrm_DISEÑO_MESAS.H17.Text = resta.ToString
            End If
            If m18 = NombreMesa Then
                WFrm_DISEÑO_MESAS.H18.Visible = True
                Dim final As String = Now.ToString("HH:mm:ss")
                Dim inicial As String = WFrm_DISEÑO_MESAS.DataGridView1.Rows.Item(z).Cells(2).Value
                Dim tiempoI As TimeSpan = TimeSpan.Parse(inicial)
                Dim tiempoF As TimeSpan = TimeSpan.Parse(final)
                Dim resta As TimeSpan = tiempoF - tiempoI
                WFrm_DISEÑO_MESAS.H18.Text = resta.ToString
            End If
            If m19 = NombreMesa Then
                WFrm_DISEÑO_MESAS.H19.Visible = True
                Dim final As String = Now.ToString("HH:mm:ss")
                Dim inicial As String = WFrm_DISEÑO_MESAS.DataGridView1.Rows.Item(z).Cells(2).Value
                Dim tiempoI As TimeSpan = TimeSpan.Parse(inicial)
                Dim tiempoF As TimeSpan = TimeSpan.Parse(final)
                Dim resta As TimeSpan = tiempoF - tiempoI
                WFrm_DISEÑO_MESAS.H19.Text = resta.ToString
            End If

            If m20 = NombreMesa Then
                WFrm_DISEÑO_MESAS.H20.Visible = True
                Dim final As String = Now.ToString("HH:mm:ss")
                Dim inicial As String = WFrm_DISEÑO_MESAS.DataGridView1.Rows.Item(z).Cells(2).Value
                Dim tiempoI As TimeSpan = TimeSpan.Parse(inicial)
                Dim tiempoF As TimeSpan = TimeSpan.Parse(final)
                Dim resta As TimeSpan = tiempoF - tiempoI
                WFrm_DISEÑO_MESAS.H20.Text = resta.ToString
            End If
            If m21 = NombreMesa Then
                WFrm_DISEÑO_MESAS.H21.Visible = True
                Dim final As String = Now.ToString("HH:mm:ss")
                Dim inicial As String = WFrm_DISEÑO_MESAS.DataGridView1.Rows.Item(z).Cells(2).Value
                Dim tiempoI As TimeSpan = TimeSpan.Parse(inicial)
                Dim tiempoF As TimeSpan = TimeSpan.Parse(final)
                Dim resta As TimeSpan = tiempoF - tiempoI
                WFrm_DISEÑO_MESAS.H21.Text = resta.ToString
            End If
            If m22 = NombreMesa Then
                WFrm_DISEÑO_MESAS.H22.Visible = True
                Dim final As String = Now.ToString("HH:mm:ss")
                Dim inicial As String = WFrm_DISEÑO_MESAS.DataGridView1.Rows.Item(z).Cells(2).Value
                Dim tiempoI As TimeSpan = TimeSpan.Parse(inicial)
                Dim tiempoF As TimeSpan = TimeSpan.Parse(final)
                Dim resta As TimeSpan = tiempoF - tiempoI
                WFrm_DISEÑO_MESAS.H22.Text = resta.ToString
            End If
            If m23 = NombreMesa Then
                WFrm_DISEÑO_MESAS.H23.Visible = True
                Dim final As String = Now.ToString("HH:mm:ss")
                Dim inicial As String = WFrm_DISEÑO_MESAS.DataGridView1.Rows.Item(z).Cells(2).Value
                Dim tiempoI As TimeSpan = TimeSpan.Parse(inicial)
                Dim tiempoF As TimeSpan = TimeSpan.Parse(final)
                Dim resta As TimeSpan = tiempoF - tiempoI
                WFrm_DISEÑO_MESAS.H23.Text = resta.ToString
            End If
            '  If m23 = NombreMesa Then
            'WFrm_DISEÑO_MESAS.bm23.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
            '  WFrm_DISEÑO_MESAS.bm23.BackColor = Color.Red
            '  contaocupado = contaocupado + 1
            '  End If
            If m24 = NombreMesa Then
                WFrm_DISEÑO_MESAS.H24.Visible = True
                Dim final As String = Now.ToString("HH:mm:ss")
                Dim inicial As String = WFrm_DISEÑO_MESAS.DataGridView1.Rows.Item(z).Cells(2).Value
                Dim tiempoI As TimeSpan = TimeSpan.Parse(inicial)
                Dim tiempoF As TimeSpan = TimeSpan.Parse(final)
                Dim resta As TimeSpan = tiempoF - tiempoI
                WFrm_DISEÑO_MESAS.H24.Text = resta.ToString
            End If
            If m25 = NombreMesa Then
                WFrm_DISEÑO_MESAS.H25.Visible = True
                Dim final As String = Now.ToString("HH:mm:ss")
                Dim inicial As String = WFrm_DISEÑO_MESAS.DataGridView1.Rows.Item(z).Cells(2).Value
                Dim tiempoI As TimeSpan = TimeSpan.Parse(inicial)
                Dim tiempoF As TimeSpan = TimeSpan.Parse(final)
                Dim resta As TimeSpan = tiempoF - tiempoI
                WFrm_DISEÑO_MESAS.H25.Text = resta.ToString
            End If
            If m26 = NombreMesa Then
                WFrm_DISEÑO_MESAS.H26.Visible = True
                Dim final As String = Now.ToString("HH:mm:ss")
                Dim inicial As String = WFrm_DISEÑO_MESAS.DataGridView1.Rows.Item(z).Cells(2).Value
                Dim tiempoI As TimeSpan = TimeSpan.Parse(inicial)
                Dim tiempoF As TimeSpan = TimeSpan.Parse(final)
                Dim resta As TimeSpan = tiempoF - tiempoI
                WFrm_DISEÑO_MESAS.H26.Text = resta.ToString
            End If
            If m27 = NombreMesa Then
                WFrm_DISEÑO_MESAS.H27.Visible = True
                Dim final As String = Now.ToString("HH:mm:ss")
                Dim inicial As String = WFrm_DISEÑO_MESAS.DataGridView1.Rows.Item(z).Cells(2).Value
                Dim tiempoI As TimeSpan = TimeSpan.Parse(inicial)
                Dim tiempoF As TimeSpan = TimeSpan.Parse(final)
                Dim resta As TimeSpan = tiempoF - tiempoI
                WFrm_DISEÑO_MESAS.H27.Text = resta.ToString
            End If
            If m28 = NombreMesa Then
                WFrm_DISEÑO_MESAS.H28.Visible = True
                Dim final As String = Now.ToString("HH:mm:ss")
                Dim inicial As String = WFrm_DISEÑO_MESAS.DataGridView1.Rows.Item(z).Cells(2).Value
                Dim tiempoI As TimeSpan = TimeSpan.Parse(inicial)
                Dim tiempoF As TimeSpan = TimeSpan.Parse(final)
                Dim resta As TimeSpan = tiempoF - tiempoI
                WFrm_DISEÑO_MESAS.H28.Text = resta.ToString
            End If
            If m29 = NombreMesa Then
                WFrm_DISEÑO_MESAS.H29.Visible = True
                Dim final As String = Now.ToString("HH:mm:ss")
                Dim inicial As String = WFrm_DISEÑO_MESAS.DataGridView1.Rows.Item(z).Cells(2).Value
                Dim tiempoI As TimeSpan = TimeSpan.Parse(inicial)
                Dim tiempoF As TimeSpan = TimeSpan.Parse(final)
                Dim resta As TimeSpan = tiempoF - tiempoI
                WFrm_DISEÑO_MESAS.H29.Text = resta.ToString
            End If
            If m30 = NombreMesa Then
                WFrm_DISEÑO_MESAS.H30.Visible = True
                Dim final As String = Now.ToString("HH:mm:ss")
                Dim inicial As String = WFrm_DISEÑO_MESAS.DataGridView1.Rows.Item(z).Cells(2).Value
                Dim tiempoI As TimeSpan = TimeSpan.Parse(inicial)
                Dim tiempoF As TimeSpan = TimeSpan.Parse(final)
                Dim resta As TimeSpan = tiempoF - tiempoI
                WFrm_DISEÑO_MESAS.H30.Text = resta.ToString
            End If
            If m31 = NombreMesa Then
                WFrm_DISEÑO_MESAS.H31.Visible = True
                Dim final As String = Now.ToString("HH:mm:ss")
                Dim inicial As String = WFrm_DISEÑO_MESAS.DataGridView1.Rows.Item(z).Cells(2).Value
                Dim tiempoI As TimeSpan = TimeSpan.Parse(inicial)
                Dim tiempoF As TimeSpan = TimeSpan.Parse(final)
                Dim resta As TimeSpan = tiempoF - tiempoI
                WFrm_DISEÑO_MESAS.H31.Text = resta.ToString
            End If
            If m32 = NombreMesa Then
                WFrm_DISEÑO_MESAS.H32.Visible = True
                Dim final As String = Now.ToString("HH:mm:ss")
                Dim inicial As String = WFrm_DISEÑO_MESAS.DataGridView1.Rows.Item(z).Cells(2).Value
                Dim tiempoI As TimeSpan = TimeSpan.Parse(inicial)
                Dim tiempoF As TimeSpan = TimeSpan.Parse(final)
                Dim resta As TimeSpan = tiempoF - tiempoI
                WFrm_DISEÑO_MESAS.H32.Text = resta.ToString
            End If
            If m33 = NombreMesa Then
                WFrm_DISEÑO_MESAS.H33.Visible = True
                Dim final As String = Now.ToString("HH:mm:ss")
                Dim inicial As String = WFrm_DISEÑO_MESAS.DataGridView1.Rows.Item(z).Cells(2).Value
                Dim tiempoI As TimeSpan = TimeSpan.Parse(inicial)
                Dim tiempoF As TimeSpan = TimeSpan.Parse(final)
                Dim resta As TimeSpan = tiempoF - tiempoI
                WFrm_DISEÑO_MESAS.H33.Text = resta.ToString
            End If
            If m34 = NombreMesa Then
                WFrm_DISEÑO_MESAS.H34.Visible = True
                Dim final As String = Now.ToString("HH:mm:ss")
                Dim inicial As String = WFrm_DISEÑO_MESAS.DataGridView1.Rows.Item(z).Cells(2).Value
                Dim tiempoI As TimeSpan = TimeSpan.Parse(inicial)
                Dim tiempoF As TimeSpan = TimeSpan.Parse(final)
                Dim resta As TimeSpan = tiempoF - tiempoI
                WFrm_DISEÑO_MESAS.H34.Text = resta.ToString
            End If
            If m35 = NombreMesa Then
                WFrm_DISEÑO_MESAS.H35.Visible = True
                Dim final As String = Now.ToString("HH:mm:ss")
                Dim inicial As String = WFrm_DISEÑO_MESAS.DataGridView1.Rows.Item(z).Cells(2).Value
                Dim tiempoI As TimeSpan = TimeSpan.Parse(inicial)
                Dim tiempoF As TimeSpan = TimeSpan.Parse(final)
                Dim resta As TimeSpan = tiempoF - tiempoI
                WFrm_DISEÑO_MESAS.H35.Text = resta.ToString
            End If
            If m36 = NombreMesa Then
                WFrm_DISEÑO_MESAS.H36.Visible = True
                Dim final As String = Now.ToString("HH:mm:ss")
                Dim inicial As String = WFrm_DISEÑO_MESAS.DataGridView1.Rows.Item(z).Cells(2).Value
                Dim tiempoI As TimeSpan = TimeSpan.Parse(inicial)
                Dim tiempoF As TimeSpan = TimeSpan.Parse(final)
                Dim resta As TimeSpan = tiempoF - tiempoI
                WFrm_DISEÑO_MESAS.H36.Text = resta.ToString
            End If
            If m37 = NombreMesa Then
                WFrm_DISEÑO_MESAS.H37.Visible = True
                Dim final As String = Now.ToString("HH:mm:ss")
                Dim inicial As String = WFrm_DISEÑO_MESAS.DataGridView1.Rows.Item(z).Cells(2).Value
                Dim tiempoI As TimeSpan = TimeSpan.Parse(inicial)
                Dim tiempoF As TimeSpan = TimeSpan.Parse(final)
                Dim resta As TimeSpan = tiempoF - tiempoI
                WFrm_DISEÑO_MESAS.H37.Text = resta.ToString
            End If
            If m38 = NombreMesa Then
                WFrm_DISEÑO_MESAS.H38.Visible = True
                Dim final As String = Now.ToString("HH:mm:ss")
                Dim inicial As String = WFrm_DISEÑO_MESAS.DataGridView1.Rows.Item(z).Cells(2).Value
                Dim tiempoI As TimeSpan = TimeSpan.Parse(inicial)
                Dim tiempoF As TimeSpan = TimeSpan.Parse(final)
                Dim resta As TimeSpan = tiempoF - tiempoI
                WFrm_DISEÑO_MESAS.H38.Text = resta.ToString
            End If
            If m39 = NombreMesa Then
                WFrm_DISEÑO_MESAS.H39.Visible = True
                Dim final As String = Now.ToString("HH:mm:ss")
                Dim inicial As String = WFrm_DISEÑO_MESAS.DataGridView1.Rows.Item(z).Cells(2).Value
                Dim tiempoI As TimeSpan = TimeSpan.Parse(inicial)
                Dim tiempoF As TimeSpan = TimeSpan.Parse(final)
                Dim resta As TimeSpan = tiempoF - tiempoI
                WFrm_DISEÑO_MESAS.H39.Text = resta.ToString
            End If
            If m40 = NombreMesa Then
                WFrm_DISEÑO_MESAS.H40.Visible = True
                Dim final As String = Now.ToString("HH:mm:ss")
                Dim inicial As String = WFrm_DISEÑO_MESAS.DataGridView1.Rows.Item(z).Cells(2).Value
                Dim tiempoI As TimeSpan = TimeSpan.Parse(inicial)
                Dim tiempoF As TimeSpan = TimeSpan.Parse(final)
                Dim resta As TimeSpan = tiempoF - tiempoI
                WFrm_DISEÑO_MESAS.H40.Text = resta.ToString
            End If
            If m41 = NombreMesa Then
                WFrm_DISEÑO_MESAS.H41.Visible = True
                Dim final As String = Now.ToString("HH:mm:ss")
                Dim inicial As String = WFrm_DISEÑO_MESAS.DataGridView1.Rows.Item(z).Cells(2).Value
                Dim tiempoI As TimeSpan = TimeSpan.Parse(inicial)
                Dim tiempoF As TimeSpan = TimeSpan.Parse(final)
                Dim resta As TimeSpan = tiempoF - tiempoI
                WFrm_DISEÑO_MESAS.H41.Text = resta.ToString
            End If
            If m42 = NombreMesa Then
                WFrm_DISEÑO_MESAS.H42.Visible = True
                Dim final As String = Now.ToString("HH:mm:ss")
                Dim inicial As String = WFrm_DISEÑO_MESAS.DataGridView1.Rows.Item(z).Cells(2).Value
                Dim tiempoI As TimeSpan = TimeSpan.Parse(inicial)
                Dim tiempoF As TimeSpan = TimeSpan.Parse(final)
                Dim resta As TimeSpan = tiempoF - tiempoI
                WFrm_DISEÑO_MESAS.H42.Text = resta.ToString
            End If
            If m43 = NombreMesa Then
                WFrm_DISEÑO_MESAS.H43.Visible = True
                Dim final As String = Now.ToString("HH:mm:ss")
                Dim inicial As String = WFrm_DISEÑO_MESAS.DataGridView1.Rows.Item(z).Cells(2).Value
                Dim tiempoI As TimeSpan = TimeSpan.Parse(inicial)
                Dim tiempoF As TimeSpan = TimeSpan.Parse(final)
                Dim resta As TimeSpan = tiempoF - tiempoI
                WFrm_DISEÑO_MESAS.H43.Text = resta.ToString
            End If
            If m44 = NombreMesa Then
                WFrm_DISEÑO_MESAS.H44.Visible = True
                Dim final As String = Now.ToString("HH:mm:ss")
                Dim inicial As String = WFrm_DISEÑO_MESAS.DataGridView1.Rows.Item(z).Cells(2).Value
                Dim tiempoI As TimeSpan = TimeSpan.Parse(inicial)
                Dim tiempoF As TimeSpan = TimeSpan.Parse(final)
                Dim resta As TimeSpan = tiempoF - tiempoI
                WFrm_DISEÑO_MESAS.H44.Text = resta.ToString
            End If
            If m45 = NombreMesa Then
                WFrm_DISEÑO_MESAS.H45.Visible = True
                Dim final As String = Now.ToString("HH:mm:ss")
                Dim inicial As String = WFrm_DISEÑO_MESAS.DataGridView1.Rows.Item(z).Cells(2).Value
                Dim tiempoI As TimeSpan = TimeSpan.Parse(inicial)
                Dim tiempoF As TimeSpan = TimeSpan.Parse(final)
                Dim resta As TimeSpan = tiempoF - tiempoI
                WFrm_DISEÑO_MESAS.H45.Text = resta.ToString
            End If
            If m46 = NombreMesa Then
                WFrm_DISEÑO_MESAS.H46.Visible = True
                Dim final As String = Now.ToString("HH:mm:ss")
                Dim inicial As String = WFrm_DISEÑO_MESAS.DataGridView1.Rows.Item(z).Cells(2).Value
                Dim tiempoI As TimeSpan = TimeSpan.Parse(inicial)
                Dim tiempoF As TimeSpan = TimeSpan.Parse(final)
                Dim resta As TimeSpan = tiempoF - tiempoI
                WFrm_DISEÑO_MESAS.H46.Text = resta.ToString
            End If
            If m47 = NombreMesa Then
                WFrm_DISEÑO_MESAS.H47.Visible = True
                Dim final As String = Now.ToString("HH:mm:ss")
                Dim inicial As String = WFrm_DISEÑO_MESAS.DataGridView1.Rows.Item(z).Cells(2).Value
                Dim tiempoI As TimeSpan = TimeSpan.Parse(inicial)
                Dim tiempoF As TimeSpan = TimeSpan.Parse(final)
                Dim resta As TimeSpan = tiempoF - tiempoI
                WFrm_DISEÑO_MESAS.H47.Text = resta.ToString
            End If
            If m48 = NombreMesa Then
                WFrm_DISEÑO_MESAS.H48.Visible = True
                Dim final As String = Now.ToString("HH:mm:ss")
                Dim inicial As String = WFrm_DISEÑO_MESAS.DataGridView1.Rows.Item(z).Cells(2).Value
                Dim tiempoI As TimeSpan = TimeSpan.Parse(inicial)
                Dim tiempoF As TimeSpan = TimeSpan.Parse(final)
                Dim resta As TimeSpan = tiempoF - tiempoI
                WFrm_DISEÑO_MESAS.H48.Text = resta.ToString
            End If
            If m49 = NombreMesa Then
                WFrm_DISEÑO_MESAS.H49.Visible = True
                Dim final As String = Now.ToString("HH:mm:ss")
                Dim inicial As String = WFrm_DISEÑO_MESAS.DataGridView1.Rows.Item(z).Cells(2).Value
                Dim tiempoI As TimeSpan = TimeSpan.Parse(inicial)
                Dim tiempoF As TimeSpan = TimeSpan.Parse(final)
                Dim resta As TimeSpan = tiempoF - tiempoI
                WFrm_DISEÑO_MESAS.H49.Text = resta.ToString
            End If
            If m50 = NombreMesa Then
                WFrm_DISEÑO_MESAS.H50.Visible = True
                Dim final As String = Now.ToString("HH:mm:ss")
                Dim inicial As String = WFrm_DISEÑO_MESAS.DataGridView1.Rows.Item(z).Cells(2).Value
                Dim tiempoI As TimeSpan = TimeSpan.Parse(inicial)
                Dim tiempoF As TimeSpan = TimeSpan.Parse(final)
                Dim resta As TimeSpan = tiempoF - tiempoI
                WFrm_DISEÑO_MESAS.H50.Text = resta.ToString
            End If
        Next
       
    End Sub

End Module
