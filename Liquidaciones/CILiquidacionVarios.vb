Public Class CILiquidacionVarios
    Inherits Solmicro.Expertis.Engine.UI.CIMnto

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        txtImporte.Value = System.DBNull.Value
    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents lblfwiCContable As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents fwiEstado As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblfwiEstado As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiTotalMarcado As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents PicTotal As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents AdvObra As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents cbxContabilizado As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents AdvTrabajo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblObra As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblContabilizado As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblTotalMarcado As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblTotal As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtTotalMarcado As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtTotal As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents txtImporte As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblImporte As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblVarios As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents AdvVarios As Solmicro.Expertis.Engine.UI.AdvSearch
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim Grid_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.ImageList.ImageStream")
        Dim cbxContabilizado_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CILiquidacionVarios))
        Me.lblfwiCContable = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiEstado = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblfwiEstado = New Solmicro.Expertis.Engine.UI.Label
        Me.PicTotal = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblTotalMarcado = New Solmicro.Expertis.Engine.UI.Label
        Me.lblTotal = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTotalMarcado = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtTotal = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblVarios = New Solmicro.Expertis.Engine.UI.Label
        Me.lblTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.lblObra = New Solmicro.Expertis.Engine.UI.Label
        Me.lblContabilizado = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvVarios = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.AdvObra = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.cbxContabilizado = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.AdvTrabajo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.txtImporte = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblImporte = New Solmicro.Expertis.Engine.UI.Label
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        Me.PicTotal.suspendlayout()
        CType(Me.cbxContabilizado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.txtImporte)
        Me.FilterPanel.Controls.Add(Me.lblImporte)
        Me.FilterPanel.Controls.Add(Me.AdvTrabajo)
        Me.FilterPanel.Controls.Add(Me.lblVarios)
        Me.FilterPanel.Controls.Add(Me.lblTrabajo)
        Me.FilterPanel.Controls.Add(Me.lblObra)
        Me.FilterPanel.Controls.Add(Me.lblContabilizado)
        Me.FilterPanel.Controls.Add(Me.AdvVarios)
        Me.FilterPanel.Controls.Add(Me.AdvObra)
        Me.FilterPanel.Controls.Add(Me.cbxContabilizado)
        Me.FilterPanel.Controls.Add(Me.lblfwiEstado)
        Me.FilterPanel.Controls.Add(Me.lblfwiCContable)
        Me.FilterPanel.Controls.Add(Me.fwiEstado)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 308)
        Me.FilterPanel.Size = New System.Drawing.Size(688, 79)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Controls.Add(Me.PicTotal)
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(688, 308)
        Me.CIMntoGridPanel.Controls.SetChildIndex(Me.PicTotal, 0)
        Me.CIMntoGridPanel.Controls.SetChildIndex(Me.Grid, 0)
        '
        'Grid
        '
        Grid_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("Grid_DesignTimeLayout_Reference_0.Instance"), Object)
        Grid_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {Grid_DesignTimeLayout_Reference_0})
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EntityName = "ObraVariosControl"
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Grid.FrozenColumns = 4
        Me.Grid.ImageList = Me.ImageList1
        Me.Grid.KeyField = "IDLineaVariosControl"
        Me.Grid.Size = New System.Drawing.Size(688, 276)
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.UseCheck = True
        Me.Grid.ViewName = "frmLiquidacionVarios"
        '
        'CheckAll
        '
        Me.CheckAll.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        Me.CheckAll.Visible = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'UncheckAll
        '
        Me.UncheckAll.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        Me.UncheckAll.Visible = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'ShowAllCheckedItems
        '
        Me.ShowAllCheckedItems.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        Me.ShowAllCheckedItems.Visible = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'ClearFilter
        '
        Me.ClearFilter.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'Export
        '
        Me.Export.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'Toolbar
        '
        Me.Toolbar.Size = New System.Drawing.Size(320, 28)
        '
        'Menubar
        '
        Me.Menubar.Location = New System.Drawing.Point(0, 28)
        '
        'MainPanel
        '
        Me.MainPanel.Size = New System.Drawing.Size(688, 387)
        '
        'ExecuteActions
        '
        Me.ExecuteActions.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(688, 387)
        '
        'lblfwiCContable
        '
        Me.lblfwiCContable.Location = New System.Drawing.Point(5, 35)
        Me.lblfwiCContable.Name = "lblfwiCContable"
        Me.lblfwiCContable.Size = New System.Drawing.Size(0, 13)
        Me.lblfwiCContable.TabIndex = 46
        Me.lblfwiCContable.Tag = "IdRec=0;"
        '
        'fwiEstado
        '
        Me.fwiEstado.DisabledBackColor = System.Drawing.Color.White
        Me.fwiEstado.Location = New System.Drawing.Point(567, 348)
        Me.fwiEstado.Name = "fwiEstado"
        Me.fwiEstado.Size = New System.Drawing.Size(26, 21)
        Me.fwiEstado.TabIndex = 26
        Me.fwiEstado.Visible = False
        '
        'lblfwiEstado
        '
        Me.lblfwiEstado.Location = New System.Drawing.Point(496, 348)
        Me.lblfwiEstado.Name = "lblfwiEstado"
        Me.lblfwiEstado.Size = New System.Drawing.Size(45, 13)
        Me.lblfwiEstado.TabIndex = 65
        Me.lblfwiEstado.Tag = "IdRec=4405;"
        Me.lblfwiEstado.Text = "Estado"
        '
        'PicTotal
        '
        Me.PicTotal.Controls.Add(Me.lblTotalMarcado)
        Me.PicTotal.Controls.Add(Me.lblTotal)
        Me.PicTotal.Controls.Add(Me.txtTotalMarcado)
        Me.PicTotal.Controls.Add(Me.txtTotal)
        Me.PicTotal.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PicTotal.Location = New System.Drawing.Point(0, 276)
        Me.PicTotal.Name = "PicTotal"
        Me.PicTotal.Size = New System.Drawing.Size(688, 32)
        Me.PicTotal.TabIndex = 6
        '
        'lblTotalMarcado
        '
        Me.lblTotalMarcado.Location = New System.Drawing.Point(244, 9)
        Me.lblTotalMarcado.Name = "lblTotalMarcado"
        Me.lblTotalMarcado.Size = New System.Drawing.Size(126, 13)
        Me.lblTotalMarcado.TabIndex = 71
        Me.lblTotalMarcado.Text = "Total A Seleccionado"
        '
        'lblTotal
        '
        Me.lblTotal.Location = New System.Drawing.Point(506, 9)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(56, 13)
        Me.lblTotal.TabIndex = 70
        Me.lblTotal.Tag = "IdRec=6574;"
        Me.lblTotal.Text = "TOTAL A"
        '
        'txtTotalMarcado
        '
        Me.txtTotalMarcado.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotalMarcado.Enabled = False
        Me.txtTotalMarcado.Location = New System.Drawing.Point(373, 9)
        Me.txtTotalMarcado.Name = "txtTotalMarcado"
        Me.txtTotalMarcado.Size = New System.Drawing.Size(122, 21)
        Me.txtTotalMarcado.TabIndex = 69
        Me.txtTotalMarcado.TabStop = False
        '
        'txtTotal
        '
        Me.txtTotal.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(564, 9)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(122, 21)
        Me.txtTotal.TabIndex = 68
        Me.txtTotal.TabStop = False
        '
        'lblVarios
        '
        Me.lblVarios.Location = New System.Drawing.Point(525, 53)
        Me.lblVarios.Name = "lblVarios"
        Me.lblVarios.Size = New System.Drawing.Size(43, 13)
        Me.lblVarios.TabIndex = 76
        Me.lblVarios.Tag = ""
        Me.lblVarios.Text = "Varios"
        '
        'lblTrabajo
        '
        Me.lblTrabajo.Location = New System.Drawing.Point(10, 53)
        Me.lblTrabajo.Name = "lblTrabajo"
        Me.lblTrabajo.Size = New System.Drawing.Size(51, 13)
        Me.lblTrabajo.TabIndex = 81
        Me.lblTrabajo.Tag = "IdRec=5695;"
        Me.lblTrabajo.Text = "Trabajo"
        '
        'lblObra
        '
        Me.lblObra.Location = New System.Drawing.Point(10, 27)
        Me.lblObra.Name = "lblObra"
        Me.lblObra.Size = New System.Drawing.Size(57, 13)
        Me.lblObra.TabIndex = 82
        Me.lblObra.Tag = ""
        Me.lblObra.Text = "Proyecto"
        '
        'lblContabilizado
        '
        Me.lblContabilizado.Location = New System.Drawing.Point(251, 25)
        Me.lblContabilizado.Name = "lblContabilizado"
        Me.lblContabilizado.Size = New System.Drawing.Size(84, 13)
        Me.lblContabilizado.TabIndex = 83
        Me.lblContabilizado.Tag = "IdRec=4725;"
        Me.lblContabilizado.Text = "Contabilizado"
        '
        'AdvVarios
        '
        Me.AdvVarios.DisabledBackColor = System.Drawing.Color.White
        Me.AdvVarios.EntityName = "Varios"
        Me.AdvVarios.Location = New System.Drawing.Point(591, 48)
        Me.AdvVarios.Name = "AdvVarios"
        Me.AdvVarios.SecondaryDataFields = "IDVarios"
        Me.AdvVarios.Size = New System.Drawing.Size(90, 23)
        Me.AdvVarios.TabIndex = 8
        Me.AdvVarios.ViewName = "tbMaestroVarios"
        '
        'AdvObra
        '
        Me.AdvObra.DisabledBackColor = System.Drawing.Color.White
        Me.AdvObra.DisplayField = "NObra"
        Me.AdvObra.EntityName = "ObraCabecera"
        Me.AdvObra.Location = New System.Drawing.Point(70, 22)
        Me.AdvObra.Name = "AdvObra"
        Me.AdvObra.SecondaryDataFields = "IDObra"
        Me.AdvObra.Size = New System.Drawing.Size(106, 23)
        Me.AdvObra.TabIndex = 1
        Me.AdvObra.ViewName = "tbObraCabecera"
        '
        'cbxContabilizado
        '
        cbxContabilizado_DesignTimeLayout.LayoutString = resources.GetString("cbxContabilizado_DesignTimeLayout.LayoutString")
        Me.cbxContabilizado.DesignTimeLayout = cbxContabilizado_DesignTimeLayout
        Me.cbxContabilizado.DisabledBackColor = System.Drawing.Color.White
        Me.cbxContabilizado.Location = New System.Drawing.Point(339, 22)
        Me.cbxContabilizado.Name = "cbxContabilizado"
        Me.cbxContabilizado.SelectedIndex = -1
        Me.cbxContabilizado.SelectedItem = Nothing
        Me.cbxContabilizado.Size = New System.Drawing.Size(102, 21)
        Me.cbxContabilizado.TabIndex = 6
        '
        'AdvTrabajo
        '
        Me.AdvTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvTrabajo.DisplayField = "CodTrabajo"
        Me.AdvTrabajo.EntityName = "ObraTrabajo"
        Me.AdvTrabajo.Location = New System.Drawing.Point(70, 48)
        Me.AdvTrabajo.Name = "AdvTrabajo"
        Me.AdvTrabajo.SecondaryDataFields = "IDTrabajo"
        Me.AdvTrabajo.Size = New System.Drawing.Size(106, 23)
        Me.AdvTrabajo.TabIndex = 2
        Me.AdvTrabajo.ViewName = "tbObraTrabajo"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.RestoreDirectory = True
        '
        'txtImporte
        '
        Me.txtImporte.DisabledBackColor = System.Drawing.Color.White
        Me.txtImporte.Location = New System.Drawing.Point(591, 24)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.NullBehavior = Janus.Windows.GridEX.NumericEditNullBehavior.AllowNull
        Me.txtImporte.Size = New System.Drawing.Size(90, 21)
        Me.txtImporte.TabIndex = 7
        '
        'lblImporte
        '
        Me.lblImporte.Location = New System.Drawing.Point(525, 28)
        Me.lblImporte.Name = "lblImporte"
        Me.lblImporte.Size = New System.Drawing.Size(66, 13)
        Me.lblImporte.TabIndex = 86
        Me.lblImporte.Tag = ""
        Me.lblImporte.Text = "Importe >"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "add2.ico")
        Me.ImageList1.Images.SetKeyName(1, "delete2.ico")
        '
        'CILiquidacionVarios
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(696, 475)
        Me.EntityName = "ObraVariosControl"
        Me.KeyField = "IDLineaVariosControl"
        Me.Name = "CILiquidacionVarios"
        Me.UseCheck = True
        Me.ViewName = "frmLiquidacionVarios"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        Me.PicTotal.ResumeLayout(False)
        Me.PicTotal.PerformLayout()
        CType(Me.cbxContabilizado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Enum IconIndex
        NoContabilizado = 0
        Contabilizado = 1
    End Enum

    Private mblnContabilidadMultiple As Boolean

#Region " Load "

    Private Sub CILiquidacionVarios_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            LoadERPData()
            LoadEnums()
            LoadToolBarActions()
            InitFilterCriteria()
        End If
    End Sub

    Private Sub LoadERPData()
        mblnContabilidadMultiple = New Parametro().ContabilidadMultiple
    End Sub

    Private Sub LoadEnums()
        cbxContabilizado.DataSource = New EnumData("enumContabilizadoTodos")
        If Not mblnContabilidadMultiple Then
            If Not cbxContabilizado.DataSource Is Nothing Then
                CType(cbxContabilizado.DataSource, DataView).RowFilter = "Name = 'enumContabilizadoTodos' AND Value <> " & enumContabilizadoTodos.ContabilizadoNIIF & " AND Value <> " & enumContabilizadoTodos.ContabilizadoTributario
            End If
        End If
    End Sub

    Private Sub LoadToolBarActions()
        Me.FormActions.Add("Contabilización", AddressOf AccionContabilizar)
        Me.FormActions.Add("Descontabilización", AddressOf AccionDescontabilizar)
    End Sub

    Private Sub InitFilterCriteria()
        cbxContabilizado.Value = CInt(enumContabilizadoTodos.Todos)
        txtImporte.Value = 0
    End Sub

#End Region

#Region " Toolbar Actions "

    Private Sub AccionContabilizar()
        If Grid.CheckedRecordsCount > 0 Then
            Dim dtMarcados As DataTable = Grid.CheckedRecords
            If Not dtMarcados Is Nothing Then
                Dim blnAgruparBanco As Boolean
                Dim strDescApunte As String = String.Empty
                Dim strEjercicio As String = String.Empty
                Dim strIdBancoPropio As String = String.Empty
                Dim dtmFechaApunte As Date
                Dim intNuevaSituacion As Integer

                Dim mIDProcess As System.Guid = Grid.SaveServerChecks()

                Dim frm As New frmContabilizar
                Dim r As DialogResult = frm.AbrirContabilizacion(dtmFechaApunte, strIdBancoPropio, intNuevaSituacion, _
                                                                 strEjercicio, blnAgruparBanco, strDescApunte, _
                                                                 ObrasGeneral.enumTipoLiquidacion.enumTlVarios)
                If r = DialogResult.OK Then
                    Dim data As New DataSimulacionContableInfo
                    data.IDEjercicio = strEjercicio
                    data.GuidSimulacion = mIDProcess
                    data.FechaApunte = dtmFechaApunte
                    data.AgruparPorBanco = blnAgruparBanco
                    data.NuevaSituacion = intNuevaSituacion
                    data.IDBancoPropio = strIdBancoPropio
                    data.DescApunte = strDescApunte
                    data.Caption = "Simulación Contable - VARIOS -"
                    data.TipoContabilizacion = enumTipoContabilizacion.tcVarios

                    Dim oFrm As Form = ExpertisApp.OpenForm("CISIMUCONT", , data, Me)
                    AddHandler oFrm.Closed, AddressOf FrmActionClosed
                End If
            End If
        Else
            ExpertisApp.GenerateMessage("Debe seleccionar alguna fila.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub AccionDescontabilizar()
        If Grid.CheckedRecordsCount > 0 Then
            Dim dtMarcados As DataTable = Me.CheckedRecords
            'Comprobamos si los pagos marcados se pueden descontabilizar
            Dim dv As DataView = dtMarcados.DefaultView
            dv.RowFilter = "Contabilizado<>0"
            If dv.Count = 0 Then
                ExpertisApp.GenerateMessage("No se pueden descontabilizar los pagos seleccionados.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Dim mIDProcess As System.Guid = Grid.SaveServerChecks()
                Dim frm As New frmDescontabilizar
                frm.AbrirFormulario(ObrasGeneral.enumTipoLiquidacion.enumTlVarios, mIDProcess)
            End If
            Me.UnCheckAllRecords()
            Me.DeleteServerChecks()
            Me.Execute()
        Else
            ExpertisApp.GenerateMessage("Debe seleccionar alguna fila.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

#End Region

#Region " QueryExecute "

    Private Sub CILiquidacionVarios_QueryExecuting(ByVal sender As Object, ByRef e As Solmicro.Expertis.Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        e.Filter.Add("IDObra", FilterOperator.Equal, AdvObra.Value, FilterType.Numeric)
        e.Filter.Add("IDTrabajo", FilterOperator.Equal, AdvTrabajo.Value, FilterType.Numeric)
        e.Filter.Add("IDVarios", FilterOperator.Equal, AdvVarios.Text, FilterType.String)
        e.Filter.Add("ImpRealVariosA", FilterOperator.GreaterThan, txtImporte.Value, FilterType.Numeric)

        If cbxContabilizado.Value <> enumContabilizadoTodos.Todos Then
            e.Filter.Add("Contabilizado", FilterOperator.Equal, cbxContabilizado.Value, FilterType.Numeric)
        End If
    End Sub

    Private Sub CILiquidacionVarios_QueryExecuted(ByVal sender As Object, ByRef e As Solmicro.Expertis.Engine.UI.QueryExecutedEventArgs) Handles MyBase.QueryExecuted
        txtTotal.Value = Grid.GetTotal(Grid.Columns("ImpRealVariosA"), AggregateFunction.Sum)
    End Sub

    Protected Overrides Sub OnFilterClearing(ByVal e As System.EventArgs)
        MyBase.OnFilterClearing(e)

        InitFilterCriteria()
    End Sub
#End Region

    Private Sub CILiquidacionVarios_RecordChecked(ByVal sender As Object, ByVal e As Engine.UI.CheckedEventArgs) Handles MyBase.RecordChecked
        If e.CheckState = CheckStates.Checked Then
            txtTotalMarcado.Value = txtTotalMarcado.Value + e.Row.Cells("ImpRealVariosA").Value
        Else
            txtTotalMarcado.Value = txtTotalMarcado.Value - e.Row.Cells("ImpRealVariosA").Value
        End If
    End Sub

    Private Sub Grid_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles Grid.FormattingRow
        If e.Row.RowType = RowType.Record Then
            If e.Row.Cells("Contabilizado").Value <> enumContabilizado.NoContabilizado Then
                e.Row.RowStyle = Grid.FormatStyles("ContabilizadoFormatStyle")
                e.Row.Cells("Contabilizado").ImageIndex = IconIndex.Contabilizado
            Else
                e.Row.Cells("Contabilizado").ImageIndex = IconIndex.NoContabilizado
            End If
        End If
    End Sub

    Private Sub FrmActionClosed(ByVal sender As Object, ByVal e As System.EventArgs)
        RemoveHandler CType(sender, Form).Closed, AddressOf FrmActionClosed

        Me.UnCheckAllRecords()
        Me.DeleteServerChecks()
        Me.Execute()
    End Sub
End Class
