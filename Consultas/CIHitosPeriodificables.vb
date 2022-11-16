Public Class CIHitosPeriodificables

#Region " Load "

    Protected Overridable Sub CIHitosPeriodificables_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Me.DesignMode Then
            ntxPorcIncrDecrPerido.Value = DBNull.Value
            LoadEnums()
            LoadToolbarActions()
            LoadGridActions()
            LoadParams()
        End If
    End Sub

    Protected Overridable Sub LoadEnums()
        EnumData.PopulateValueList("enumottfCriterioGeneracion", Grid.Columns("CriterioGeneracion"))
        EnumData.PopulateValueList("enumottfCadencia", Grid.Columns("TipoCadencia"))
    End Sub

    Protected Overridable Sub LoadToolbarActions()
        Me.FormActions.Add("Actualizar % Incremento/Decremento", AddressOf AccionActualizarPorcentajeIncrementoDecremento, ExpertisApp.GetIcon("percent.ico"))
        Me.AddSeparator()
        Me.FormActions.Add("Generar Hitos Periodificados", AddressOf AccionGenerarHitosPeriodificables, ExpertisApp.GetIcon("calendar_preferences.ico"))
    End Sub

    Protected Overridable Sub LoadGridActions()
        Grid.Actions.Add("Abrir Proyecto", AddressOf AccionAbrirObra, ExpertisApp.GetIcon("xProyectos.ico"))
    End Sub

    Protected Overridable Sub LoadParams()
        If Not IsNothing(Me.Params) Then
            Dim ht As Hashtable = Me.Params
            advIDObra.Value = ht("IDObra")
            advIDObra.Text = ht("NObra")
            advIDTrabajo.Value = ht("IDTrabajo")
            advIDTrabajo.Text = ht("CodTrabajo")

            Me.Execute()
        End If
    End Sub

#End Region

#Region " Toolbar Actions "

    Protected Overridable Sub AccionGenerarHitosPeriodificables()
        If Grid.CheckedRecordsCount > 0 Then
            Dim Msg As String = ExpertisApp.Traslate("El proceso va a realizar la propuesta de los nuevos Hitos de Facturación. ¿Desea continuar?.")
            Dim dtMarcados As DataTable = Grid.CheckedRecords
            Dim where As String = New IsNullFilterItem("FechaInicio", False).Compose(New AdoFilterComposer)
            Dim dr() As DataRow = dtMarcados.Select(where)
            If dr.Length > 0 Then
                Msg = ExpertisApp.Traslate("Los registros sin Fecha Inicio Cadencia no serán incluidos en el proceso. ¿Desea continuar?")
            End If
            If ExpertisApp.GenerateMessage(Msg, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Me.Cursor = Cursors.WaitCursor

                Dim Lineas(-1) As ObraTrabajoFacturacion.dataPropuestaHitosPeriodificables
                For Each drMarcado As DataRow In Grid.CheckedRecords.Select(where)
                    ReDim Preserve Lineas(UBound(Lineas) + 1)
                    Lineas(UBound(Lineas)) = New ObraTrabajoFacturacion.dataPropuestaHitosPeriodificables(drMarcado("IDTipoVencimiento"), drMarcado("IDObra"), drMarcado("IDTrabajo"), drMarcado("IDArticulo"), drMarcado("IDTrabajo"), drMarcado("DescTrabajo"), enumottfClaseVencimiento.ottfTrabajo, drMarcado("ImporteEfectoA"))
                Next

                Dim r As ObraTrabajoFacturacion.dataResultPropuestaHitosPeriodificables = ExpertisApp.ExecuteTask(Of ObraTrabajoFacturacion.dataPropuestaHitosPeriodificables(), ObraTrabajoFacturacion.dataResultPropuestaHitosPeriodificables)(AddressOf ObraTrabajoFacturacion.GenerarPropuestaHitosPeriodificables, Lineas)
                Me.Cursor = Cursors.Default

                If Not r.dtHitosPropuestos Is Nothing Then
                    Dim frm As New frmHitosPeriodificadosPropuestos
                    frm.grid.AddCheckColumnToDataSource(r.dtHitosPropuestos, Nothing)
                    frm.grid.DataSource = r.dtHitosPropuestos
                    If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                        Me.Cursor = Cursors.WaitCursor

                        Dim dtHitos As DataTable = frm.grid.CheckedRecords
                        For Each drHito As DataRow In dtHitos.Rows
                            drHito.SetAdded()
                        Next
                        Dim dtCadencias As DataTable = r.dtCadencia.Clone
                        For Each drCadencia As DataRow In r.dtCadencia.Rows
                            dr = dtHitos.Select(New NumberFilterItem("IDTrabajo", drCadencia("IDTrabajo")).Compose(New AdoFilterComposer))
                            If dr.Length > 0 Then
                                dtCadencias.Rows.Add(drCadencia.ItemArray)
                            End If
                        Next

                        Dim d As New ObraTrabajoFacturacion.dataResultPropuestaHitosPeriodificables(dtHitos, dtCadencias)
                        ExpertisApp.ExecuteTask(Of ObraTrabajoFacturacion.dataResultPropuestaHitosPeriodificables)(AddressOf ObraTrabajoFacturacion.GuardarHitosFacturacionPeriodificables, d)
                        Me.Cursor = Cursors.Default
                        Grid.UnCheckAllRecords()
                        ExpertisApp.GenerateMessage("Proceso finalizado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Execute()
                    Else
                        ExpertisApp.GenerateMessage("Proceso cancelado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    ExpertisApp.GenerateMessage("El proceso no ha devuelto registros propuestos.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                ExpertisApp.GenerateMessage("Proceso cancelado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            ExpertisApp.GenerateMessage("No hay registros seleccionados.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Protected Overridable Sub AccionActualizarPorcentajeIncrementoDecremento()
        If Grid.CheckedRecordsCount > 0 Then
            Dim frm As New frmGetPorcentaje
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.Cursor = Cursors.WaitCursor

                Dim IDTipoVencimiento(-1) As Object
                For Each drMarcado As DataRow In Grid.CheckedRecords.Select
                    ReDim Preserve IDTipoVencimiento(UBound(IDTipoVencimiento) + 1)
                    IDTipoVencimiento(UBound(IDTipoVencimiento)) = drMarcado("IDTipoVencimiento")
                Next
                Dim data As New ObraTrabajoTipoFacturacion.dataActualizarPorcentajeIncrementoDecrementoPeriodificacion(IDTipoVencimiento, frm.ntxPorcIncrDecrPerido.Value)
                ExpertisApp.ExecuteTask(Of ObraTrabajoTipoFacturacion.dataActualizarPorcentajeIncrementoDecrementoPeriodificacion)(AddressOf ObraTrabajoTipoFacturacion.ActualizarPorcentajeIncrementoDecrementoPeriodificacion, data)

                Me.Cursor = Cursors.Default
                Grid.UnCheckAllRecords()
                ExpertisApp.GenerateMessage("Proceso finalizado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Execute()
            End If
        Else
            ExpertisApp.GenerateMessage("No hay registros seleccionados.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

#End Region

#Region " Grid Actions "

    Protected Overridable Sub AccionAbrirObra()
        ExpertisApp.OpenForm("MGEO", New NumberFilterItem("IDObra", Grid.Value("IDObra")))
    End Sub

#End Region

    Private Sub CIHitosPeriodificables_QueryExecuting(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutingEventArgs) Handles Me.QueryExecuting
        e.Filter.Add("IDObra", FilterOperator.Equal, advIDObra.Value, FilterType.Numeric)
        e.Filter.Add("IDTipoObra", FilterOperator.Equal, advIDTipoObra.Text, FilterType.String)
        e.Filter.Add("IDTrabajo", FilterOperator.Equal, advIDTrabajo.Value, FilterType.Numeric)
        e.Filter.Add("IDCliente", FilterOperator.Equal, advIDCliente.Text, FilterType.String)
        e.Filter.Add("FechaInicio", FilterOperator.LessThanOrEqual, cbxFechaInicioHasta.Value, FilterType.DateTime)
        e.Filter.Add("Periodificable", FilterOperator.Equal, True, FilterType.Boolean)
    End Sub

    Private Sub Grid_EditingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles Grid.EditingCell
        If e.Column.Key <> "Expertis.Check" Then
            If Grid.Value("Expertis.Check") Then
                e.Cancel = True
            Else
                Select Case e.Column.Key
                    Case "CriterioGeneracion"
                        e.Cancel = Not Grid.Value("Periodificable")
                End Select
            End If
        End If
    End Sub

    Private Sub Grid_UpdatingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles Grid.UpdatingCell
        Select Case e.Column.Key
            Case "NumEfectos"
                If Nz(e.Value, 0) = 0 Then
                    e.Value = 1
                End If
        End Select
    End Sub

    Private Sub Grid_CellUpdated(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles Grid.CellUpdated
        Select Case e.Column.Key
            Case "NumEfectos"
                Grid.Value("ImporteEfectoA") = xRound(Grid.Value("ImporteTotalTrabajoA") / Grid.Value(e.Column.Key), 2)
        End Select
    End Sub

    Protected Overridable Sub advIDTrabajo_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles advIDTrabajo.SetPredefinedFilter
        If Length(advIDObra.Value) > 0 Then
            e.Filter.Add(New NumberFilterItem("IDObra", advIDObra.Value))
            e.ForcePredefinedFilter = True
        End If
    End Sub

End Class