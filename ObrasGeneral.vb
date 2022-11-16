Public Module ObrasGeneral

    Public Class infoConceptosImprimir
        Public Material, ManoObra, Centro, Gasto, Varios As Integer
        Public Cancel As Boolean
    End Class

    Public Enum enumTipoLiquidacion
        enumTlGasto = 0
        enumTlVarios = 1
    End Enum

    Public Sub AbrirMantenimientoTarea(Optional ByVal IDTarea As Integer = 0, _
                                       Optional ByVal blnConsulta As Boolean = True, _
                                       Optional ByVal IDObra As Integer = 0, Optional ByVal NObra As String = "", _
                                       Optional ByVal IDTrabajo As Integer = 0, Optional ByVal CodTrabajo As String = "", _
                                       Optional ByVal IDActivo As String = "")

        If ExpertisApp.IsFormOpen("MGOTAREA") Then ExpertisApp.CloseForm("MGOTAREA")
        If IDTarea = 0 Then
            Dim HT As New Hashtable
            If IDTarea = 0 Then
                HT("IDObra") = IDObra
                HT("NObra") = NObra
                HT("IDTrabajo") = IDTrabajo
                HT("CodTrabajo") = CodTrabajo
                HT("Consulta") = blnConsulta
                HT("IDActivo") = IDActivo
            End If
            ExpertisApp.OpenForm("MGOTAREA", , HT)
        Else
            ExpertisApp.OpenForm("MGOTAREA", New NumberFilterItem("IDTarea", FilterOperator.Equal, IDTarea))
        End If

    End Sub

    Public Sub AbrirPlanificacionActivo(ByVal IDActivo As String, ByVal IDObra As Integer, ByVal IDTrabajo As Integer, ByVal IDCliente As String, ByVal Facturable As Boolean)
        If Len(IDActivo) > 0 Then

            If ExpertisApp.IsFormOpen("PREVLAN") Then ExpertisApp.CloseForm("PREVLAN")

            Dim HT As New Hashtable

            HT("IDObra") = IDObra
            HT("IDTrabajo") = IDTrabajo
            HT("IDActivo") = IDActivo
            HT("IDCliente") = IDCliente
            HT("Facturable") = Facturable
            ExpertisApp.OpenForm("PREVLAN", , HT)

        End If
    End Sub

    Public Sub AbrirResumenOT(ByVal IDActivo As String, ByVal IDObra As Integer, ByVal IDTrabajo As Integer)
        If Len(IDActivo) > 0 Then

            If ExpertisApp.IsFormOpen("MNTOESTPRE") Then ExpertisApp.CloseForm("MNTOESTPRE")

            Dim HT As New Hashtable

            HT("IDObra") = IDObra
            HT("IDTrabajo") = IDTrabajo
            HT("IDActivo") = IDActivo
            HT("IDActivo") = IDActivo
            ExpertisApp.OpenForm("MNTOESTPRE", , HT)

        End If
    End Sub


    Public Sub AbrirMantenimientoActivo(ByVal IDActivo As String)
        If Len(IDActivo) > 0 Then
            ExpertisApp.OpenForm("MACT", New StringFilterItem("IDActivo", IDActivo))
        End If
    End Sub

    Public Sub AbrirMntoFacturaVenta(ByVal IDFactura As Integer)
        If IDFactura = 0 Then
            ExpertisApp.GenerateMessage("No se puede abrir la factura. No tiene un factura asociada.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If ExpertisApp.IsFormOpen("MFACTV") Then ExpertisApp.CloseForm("MFACTV")
            ExpertisApp.OpenForm("MFACTV", New NumberFilterItem("IdFactura", FilterOperator.Equal, IDFactura))
        End If
    End Sub

    Public Sub AbrirMntoFacturaCompra(ByVal IDFactura As Integer)
        ExpertisApp.OpenForm("MFACC", New NumberFilterItem("IDFactura", FilterOperator.Equal, IDFactura))
    End Sub

    Public Sub AbrirMntoAlbaranCompra(ByVal IDAlbaran As Integer)
        ExpertisApp.OpenForm("MALBC", New NumberFilterItem("IDAlbaran", IDAlbaran))
    End Sub

    Public Sub AbrirMntoCategoria(ByVal IDCategoria As String)
        ExpertisApp.OpenForm("MCA", New StringFilterItem("IDCategoria", IDCategoria))
    End Sub

    Public Sub AbrirMntoArticulo(ByVal IDMaterial As String)
        ExpertisApp.OpenForm("MARTICULO", New StringFilterItem("IDArticulo", IDMaterial))
    End Sub

    Private MargenBruto As Boolean?
    Public Function CalcularMargen(ByVal Venta As Double, ByVal Coste As Double) As Double
        Dim Margen As Double = 0
        If MargenBruto Is Nothing Then MargenBruto = New Parametro().MargenBruto

        If MargenBruto Then
            If Venta <> 0 Then
                Margen = ((Venta - Coste) / Venta) * 100
            End If
        ElseIf Coste <> 0 Then
            Margen = ((Venta - Coste) / Coste) * 100
        End If

        'If Margen = -100 Then
        '    Return 0
        'Else
        Return xRound(Margen, 2)
        'End If
    End Function

    Public Function GuardarFichero(ByVal Ruta As String, ByVal dtFichero As DataTable) As Boolean
        If Length(Ruta) > 0 Then
            'Detecta si existe el camino completo de directorios
            Dim intPosicion As Integer = 1
            Dim Pos As Integer = InStr(intPosicion, Ruta, "\")
            While Pos <> 0
                intPosicion = Pos + 1
                Pos = InStr(intPosicion, Ruta, "\")
            End While
            Dim strDirectorio As String = Left(Ruta, intPosicion - 2)
            Dim strNombreDirectorio As String = Dir(strDirectorio, vbDirectory)

            'Si existe el archivo en la ruta lo elimina
            Dim varNombreFichero As String = Dir(Ruta)
            If Length(varNombreFichero) > 0 Then
                Kill(Ruta)
            End If
            If Length(strNombreDirectorio) > 0 Then
                'Abrimos el fichero
                Dim intFile As Integer = FreeFile()
                FileOpen(intFile, Ruta, OpenMode.Output, OpenAccess.Write, OpenShare.LockReadWrite)

                For Each drFichero As DataRow In dtFichero.Rows
                    Print(intFile, drFichero("Linea"))
                    Print(intFile, vbNewLine)
                Next

                FileClose(intFile)
                Return True
            Else
                ExpertisApp.GenerateMessage("La ruta | no existe. Debe crear la ruta para generar el fichero.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 'La ruta no existe
            End If
        Else
            ExpertisApp.GenerateMessage("La ruta | no existe. Debe crear la ruta para generar el fichero.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 'La ruta no existe
        End If

        Return False
    End Function

    Public Function GetObrasPadre(ByVal IDObraPadre As Integer) As CIMntoFilter
        If IDObraPadre > 0 Then
            Dim f As New CIMntoFilter
            f.InnerFilter.UnionOperator = FilterUnionOperator.Or

            Dim dt As DataTable = New ObraCabecera().Filter(New NumberFilterItem("IDObraPadre", IDObraPadre))
            If Not dt Is Nothing AndAlso dt.Rows.Count > 0 Then
                For Each dr As DataRow In dt.Rows
                    Dim fAux As CIMntoFilter = GetObrasPadre(dr("IDObra"))
                    f.Add(fAux.InnerFilter)
                Next
            End If

            Return f
        End If
        Return Nothing
    End Function

End Module
