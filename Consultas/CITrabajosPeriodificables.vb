Public Class CITrabajosPeriodificables

#Region " Load "

    Protected Overridable Sub CITrabajosPeriodificables_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Me.DesignMode Then
            ntxPorcIncrDecrPerido.Value = DBNull.Value
            LoadEnums()
            LoadToolbarActions()
            LoadGridActions()
            LoadParams()
        End If
    End Sub

    Protected Overridable Sub LoadEnums()
        EnumData.PopulateValueList("enumcpPeriodo", Grid.Columns("TipoPeriodo"))
    End Sub

    Protected Overridable Sub LoadToolbarActions()
        Me.FormActions.Add("Generar Trabajos Periodificados", AddressOf AccionGenerarTrabajosPeriodificables, ExpertisApp.GetIcon("gears_run.ico"))
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

    Protected Overridable Sub AccionGenerarTrabajosPeriodificables()
        If Grid.CheckedRecordsCount > 0 Then
            If Length(cbxFechafinPeriodificacion.Value) > 0 Then
                Dim IDTrabajo(-1) As Object
                For Each drMarcado As DataRow In Grid.CheckedRecords.Rows
                    ReDim Preserve IDTrabajo(UBound(IDTrabajo) + 1)
                    IDTrabajo(UBound(IDTrabajo)) = drMarcado("IDTrabajo")
                Next
                Me.Cursor = Cursors.WaitCursor
                Dim data As New ObraTrabajo.dataGenerarPropuestaTrabajosPeriodificables(IDTrabajo, cbxFechafinPeriodificacion.Value)
                If Length(ntxPorcIncrDecrPerido.Value) > 0 Then data.PorcentajeIncrDecr = ntxPorcIncrDecrPerido.Value
                Dim dtTrabajosPropuestos As DataTable = ExpertisApp.ExecuteTask(Of ObraTrabajo.dataGenerarPropuestaTrabajosPeriodificables, DataTable)(AddressOf ObraTrabajo.GenerarPropuestaTrabajosPeriodificables, data)
                Me.Cursor = Cursors.Default

                Dim frm As New frmTrabajosPeriodificadosPropuestos
                frm.Grid.AddCheckColumnToDataSource(dtTrabajosPropuestos, Nothing)
                frm.Grid.DataSource = dtTrabajosPropuestos
                If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Me.Cursor = Cursors.WaitCursor
                    ExpertisApp.ExecuteTask(Of DataTable)(AddressOf ObraTrabajo.GuardarPropuestaTrabajosPeriodificables, frm.Grid.CheckedRecords)
                    Me.Cursor = Cursors.Default
                    Grid.UnCheckAllRecords()
                    ExpertisApp.GenerateMessage("Proceso finalizado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Execute()
                Else
                    ExpertisApp.GenerateMessage("Proceso cancelado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                ExpertisApp.GenerateMessage("Ha de indicar una Fecha fin periodificación.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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

    Protected Overridable Sub CITrabajosPeriodificables_QueryExecuting(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutingEventArgs) Handles Me.QueryExecuting
        e.Filter.Add("IDObra", FilterOperator.Equal, advIDObra.Value, FilterType.Numeric)
        e.Filter.Add("IDTrabajo", FilterOperator.Equal, advIDTrabajo.Value, FilterType.Numeric)
        e.Filter.Add("IDCliente", FilterOperator.Equal, advIDCliente.Text, FilterType.String)
    End Sub

    Protected Overridable Sub advIDTrabajo_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles advIDTrabajo.SetPredefinedFilter
        If Length(advIDObra.Value) > 0 Then
            e.Filter.Add(New NumberFilterItem("IDObra", advIDObra.Value))
            e.ForcePredefinedFilter = True
        End If
    End Sub

End Class