Public Class CIActualizarStocks
    Inherits Solmicro.Expertis.Engine.UI.CIMnto

    Private mLotes As LoteStockableUserDialog
    Public WithEvents lblFechaInicio As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxFechaInicio As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents lblFechaFin As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxFechaFin As Solmicro.Expertis.Engine.UI.CalendarBox
    Private mSeries As NSerieStockableUserDialog

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        mLotes = New LoteStockableUserDialog
        mLotes.Text = "ACTUALIZACION STOCKS"
        mLotes.ClaseMovimiento = [Shared].ClaseMovimiento.Salida
        mLotes.DataSource = Grid
        mLotes.DataSchema.Cantidad = "CantidadMarca1"
        mLotes.DataSchema.IDArticulo = "IDMaterial"

        txtPendiente.Value = System.DBNull.Value

        mSeries = New NSerieStockableUserDialog
        mSeries.Text = "ACTUALIZACIÓN STOCKS"
        mSeries.ClaseMovimiento = [Shared].ClaseMovimiento.Salida
        mSeries.DataSource = Grid
        mSeries.DataSchema.Cantidad = "CantidadMarca1"
        mSeries.DataSchema.IDArticulo = "IDMaterial"
        mSeries.ValorPorDefectoSeleccionEstado = NSerie.ESTADO_VENDIDO
        mSeries.UsarColumnaSeleccion = True
        mSeries.Filtro.Clear()
        mSeries.Filtro.Add(New BooleanFilterItem("Disponible", True))
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
    Friend WithEvents lblObra As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvIDObra As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblMaterial As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvTrabajo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvMaterial As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents txtPendiente As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblPendiente As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Icons As System.Windows.Forms.ImageList
    Friend WithEvents lblEstado As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxEstado As Solmicro.Expertis.Engine.UI.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxEstado_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIActualizarStocks))
        Me.AdvIDObra = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblObra = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvMaterial = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblMaterial = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvTrabajo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.txtPendiente = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblPendiente = New Solmicro.Expertis.Engine.UI.Label
        Me.Icons = New System.Windows.Forms.ImageList(Me.components)
        Me.lblEstado = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxEstado = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblFechaInicio = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaInicio = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaFin = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaFin = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        CType(Me.cbxEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.lblFechaInicio)
        Me.FilterPanel.Controls.Add(Me.cbxFechaInicio)
        Me.FilterPanel.Controls.Add(Me.lblFechaFin)
        Me.FilterPanel.Controls.Add(Me.cbxFechaFin)
        Me.FilterPanel.Controls.Add(Me.lblEstado)
        Me.FilterPanel.Controls.Add(Me.cbxEstado)
        Me.FilterPanel.Controls.Add(Me.txtPendiente)
        Me.FilterPanel.Controls.Add(Me.lblPendiente)
        Me.FilterPanel.Controls.Add(Me.lblObra)
        Me.FilterPanel.Controls.Add(Me.lblTrabajo)
        Me.FilterPanel.Controls.Add(Me.lblMaterial)
        Me.FilterPanel.Controls.Add(Me.AdvIDObra)
        Me.FilterPanel.Controls.Add(Me.AdvTrabajo)
        Me.FilterPanel.Controls.Add(Me.AdvMaterial)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 245)
        Me.FilterPanel.Size = New System.Drawing.Size(632, 104)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(632, 245)
        '
        'Grid
        '
        Me.Grid.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDAlmacen", "ArticuloAlmacen", "IDAlmacen")})
        Me.Grid.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.Grid.CheckFields = New Solmicro.Expertis.Engine.UI.CheckFields(New Solmicro.Expertis.Engine.UI.CheckField() {New Solmicro.Expertis.Engine.UI.CheckField("CantidadMarca1", "C. Actualizar", Solmicro.Expertis.Engine.UI.CheckFieldType.Numeric, "Pendiente"), New Solmicro.Expertis.Engine.UI.CheckField("CantidadMarcaFecha1", "Fecha Actualización", Solmicro.Expertis.Engine.UI.CheckFieldType.DateTime, "Fecha")})
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EntityName = "ObraMaterialControl"
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Grid.ImageList = Me.Icons
        Me.Grid.KeyField = "IDLineaMaterialControl"
        Me.Grid.Size = New System.Drawing.Size(632, 245)
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.UseCheck = True
        Me.Grid.ViewName = "VCIActualizaStocksObras"
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
        'ExecuteQuery
        '
        Me.ExecuteQuery.Icon = CType(resources.GetObject("ExecuteQuery.Icon"), System.Drawing.Icon)
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
        Me.Toolbar.Location = New System.Drawing.Point(49, 0)
        Me.Toolbar.Size = New System.Drawing.Size(391, 28)
        '
        'Menubar
        '
        Me.Menubar.Location = New System.Drawing.Point(0, 28)
        '
        'MainPanel
        '
        Me.MainPanel.Size = New System.Drawing.Size(632, 349)
        '
        'ExecuteActions
        '
        Me.ExecuteActions.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(632, 349)
        '
        'AdvIDObra
        '
        Me.AdvIDObra.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDObra.DisplayField = "NObra"
        Me.AdvIDObra.EntityName = "ObraCabecera"
        Me.AdvIDObra.Location = New System.Drawing.Point(66, 19)
        Me.AdvIDObra.Name = "AdvIDObra"
        Me.AdvIDObra.SecondaryDataFields = "IDObra"
        Me.AdvIDObra.Size = New System.Drawing.Size(100, 23)
        Me.AdvIDObra.TabIndex = 0
        Me.AdvIDObra.ViewName = "tbObraCabecera"
        '
        'lblObra
        '
        Me.lblObra.Location = New System.Drawing.Point(6, 24)
        Me.lblObra.Name = "lblObra"
        Me.lblObra.Size = New System.Drawing.Size(57, 13)
        Me.lblObra.TabIndex = 0
        Me.lblObra.Tag = ""
        Me.lblObra.Text = "Proyecto"
        '
        'AdvMaterial
        '
        Me.AdvMaterial.DisabledBackColor = System.Drawing.Color.White
        Me.AdvMaterial.EntityName = "Articulo"
        Me.AdvMaterial.Location = New System.Drawing.Point(280, 19)
        Me.AdvMaterial.Name = "AdvMaterial"
        Me.AdvMaterial.SecondaryDataFields = "IDArticulo"
        Me.AdvMaterial.Size = New System.Drawing.Size(100, 23)
        Me.AdvMaterial.TabIndex = 2
        Me.AdvMaterial.ViewName = "tbMaestroArticulo"
        '
        'lblMaterial
        '
        Me.lblMaterial.Location = New System.Drawing.Point(224, 24)
        Me.lblMaterial.Name = "lblMaterial"
        Me.lblMaterial.Size = New System.Drawing.Size(52, 13)
        Me.lblMaterial.TabIndex = 2
        Me.lblMaterial.Tag = "IdRec=5303;"
        Me.lblMaterial.Text = "Material"
        '
        'AdvTrabajo
        '
        Me.AdvTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvTrabajo.DisplayField = "CodTrabajo"
        Me.AdvTrabajo.EntityName = "ObraTrabajo"
        Me.AdvTrabajo.Location = New System.Drawing.Point(66, 45)
        Me.AdvTrabajo.Name = "AdvTrabajo"
        Me.AdvTrabajo.SecondaryDataFields = "IDTrabajo"
        Me.AdvTrabajo.Size = New System.Drawing.Size(100, 23)
        Me.AdvTrabajo.TabIndex = 1
        Me.AdvTrabajo.ViewName = "tbObraTrabajo"
        '
        'lblTrabajo
        '
        Me.lblTrabajo.Location = New System.Drawing.Point(6, 49)
        Me.lblTrabajo.Name = "lblTrabajo"
        Me.lblTrabajo.Size = New System.Drawing.Size(50, 13)
        Me.lblTrabajo.TabIndex = 4
        Me.lblTrabajo.Tag = "IdRec=5280;"
        Me.lblTrabajo.Text = "Trabajo"
        '
        'txtPendiente
        '
        Me.txtPendiente.DisabledBackColor = System.Drawing.Color.White
        Me.txtPendiente.Location = New System.Drawing.Point(520, 21)
        Me.txtPendiente.Name = "txtPendiente"
        Me.txtPendiente.NullBehavior = Janus.Windows.GridEX.NumericEditNullBehavior.AllowNull
        Me.txtPendiente.Size = New System.Drawing.Size(104, 21)
        Me.txtPendiente.TabIndex = 3
        '
        'lblPendiente
        '
        Me.lblPendiente.Location = New System.Drawing.Point(440, 24)
        Me.lblPendiente.Name = "lblPendiente"
        Me.lblPendiente.Size = New System.Drawing.Size(76, 13)
        Me.lblPendiente.TabIndex = 74
        Me.lblPendiente.Tag = "IdRec=5379;"
        Me.lblPendiente.Text = "Pendiente >"
        '
        'Icons
        '
        Me.Icons.ImageStream = CType(resources.GetObject("Icons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Icons.TransparentColor = System.Drawing.Color.Transparent
        Me.Icons.Images.SetKeyName(0, "")
        Me.Icons.Images.SetKeyName(1, "")
        Me.Icons.Images.SetKeyName(2, "")
        Me.Icons.Images.SetKeyName(3, "")
        '
        'lblEstado
        '
        Me.lblEstado.Location = New System.Drawing.Point(440, 49)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(45, 13)
        Me.lblEstado.TabIndex = 76
        Me.lblEstado.Text = "Estado"
        '
        'cbxEstado
        '
        cbxEstado_DesignTimeLayout.LayoutString = resources.GetString("cbxEstado_DesignTimeLayout.LayoutString")
        Me.cbxEstado.DesignTimeLayout = cbxEstado_DesignTimeLayout
        Me.cbxEstado.DisabledBackColor = System.Drawing.Color.White
        Me.cbxEstado.Location = New System.Drawing.Point(520, 45)
        Me.cbxEstado.Name = "cbxEstado"
        Me.cbxEstado.SelectedIndex = -1
        Me.cbxEstado.SelectedItem = Nothing
        Me.cbxEstado.Size = New System.Drawing.Size(104, 21)
        Me.cbxEstado.TabIndex = 4
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.Location = New System.Drawing.Point(8, 75)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.Size = New System.Drawing.Size(75, 13)
        Me.lblFechaInicio.TabIndex = 77
        Me.lblFechaInicio.Text = "Fecha Inicio"
        '
        'cbxFechaInicio
        '
        Me.cbxFechaInicio.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaInicio.Location = New System.Drawing.Point(66, 71)
        Me.cbxFechaInicio.Name = "cbxFechaInicio"
        Me.cbxFechaInicio.Size = New System.Drawing.Size(87, 21)
        Me.cbxFechaInicio.TabIndex = 5
        '
        'lblFechaFin
        '
        Me.lblFechaFin.Location = New System.Drawing.Point(224, 75)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(60, 13)
        Me.lblFechaFin.TabIndex = 80
        Me.lblFechaFin.Text = "Fecha Fin"
        '
        'cbxFechaFin
        '
        Me.cbxFechaFin.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaFin.Location = New System.Drawing.Point(280, 71)
        Me.cbxFechaFin.Name = "cbxFechaFin"
        Me.cbxFechaFin.Size = New System.Drawing.Size(87, 21)
        Me.cbxFechaFin.TabIndex = 6
        '
        'CIActualizarStocks
        '
        Me.AllowUpdate = True
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CheckFields = New Solmicro.Expertis.Engine.UI.CheckFields(New Solmicro.Expertis.Engine.UI.CheckField() {New Solmicro.Expertis.Engine.UI.CheckField("CantidadMarca1", "C. Actualizar", Solmicro.Expertis.Engine.UI.CheckFieldType.Numeric, "Pendiente"), New Solmicro.Expertis.Engine.UI.CheckField("CantidadMarcaFecha1", "Fecha Actualización", Solmicro.Expertis.Engine.UI.CheckFieldType.DateTime, "Fecha")})
        Me.ClientSize = New System.Drawing.Size(640, 437)
        Me.EntityName = "ObraMaterialControl"
        Me.KeyField = "IDLineaMaterialControl"
        Me.Name = "CIActualizarStocks"
        Me.Text = "Actualización de Stocks del Control de Materiales"
        Me.UseCheck = True
        Me.ViewName = "VCIActualizaStocksObras"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        CType(Me.cbxEstado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub CIActualizarStocks_FilterClearing(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.FilterClearing
        Me.cbxFechaInicio.Text = String.Empty
        Me.cbxFechaFin.Text = String.Empty
    End Sub

    Private Sub CIGenerarCompras_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadEnums()
        LoadToolbarActions()
        txtPendiente.Value = 0
    End Sub

    Private Sub LoadEnums()
        cbxEstado.DataSource = New EnumData("enumomcActualizado")
        EnumData.PopulateValueList("enumomcActualizado", Grid.Columns("Actualizado"))
    End Sub

    Private Sub LoadToolbarActions()
        Me.FormActions.Add("Actualizar Stocks", AddressOf AccionActualizarStocks, ExpertisApp.GetIcon("xMovimStock.ico"))
    End Sub

#Region " Toolbar Actions "

    Private Sub AccionActualizarStocks()
        If Grid.CheckedRecordsCount > 0 Then
            If Me.RecordsState <> UI.RecordsState.Saved Then
                Me.UpdateData()
                Me.RecordsState = UI.RecordsState.Saved
                Me.Execute()
            End If

            Dim dtMarcados As DataTable = Me.CheckedRecords

            If Not dtMarcados Is Nothing AndAlso dtMarcados.Rows.Count > 0 Then
                dtMarcados = TratarLineasMarcadas(dtMarcados)
                If ExpertisApp.GenerateMessage("Se actualizará el Stock de las líneas selecciondas. ¿Desea continuar.?.", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    Me.Cursor = Cursors.WaitCursor

                    Dim log() As StockUpdateData = ExpertisApp.ExecuteTask(Of DataTable, StockUpdateData())(AddressOf ActualizacionStocks.ActualizarStocks, dtMarcados)
                    If Not log Is Nothing AndAlso log.Length > 0 Then
                        Dim detalle As New ERP.CommonClasses.DetalleActualizacionStock
                        detalle.DataSource = log
                        detalle.ShowDialog()
                    Else
                        ExpertisApp.GenerateMessage("No hay líneas para actualizar.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

                    Me.UnCheckAllRecords()
                    Me.Execute()

                    Me.Cursor = Cursors.Default
                End If
            End If
        Else
            ExpertisApp.GenerateMessage("Debe seleccionar alguna fila.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Function TratarLineasMarcadas(ByVal dtMarcados As DataTable) As DataTable
        Dim dt As New DataTable
        dt.Columns.Add("IDLineaMaterialControl", GetType(Integer))
        dt.Columns.Add("QStock", GetType(Double))
        dt.Columns.Add("QPendiente", GetType(Double))
        dt.Columns.Add("Lotes", GetType(String))
        dt.Columns.Add("Series", GetType(String))
        dt.Columns.Add("NObra", GetType(String))
        dt.Columns.Add("Fecha", GetType(Date))
        dt.RemotingFormat = SerializationFormat.Binary

        For Each drMarcados As DataRow In dtMarcados.Rows
            If drMarcados("CantidadMarca1") <> 0 Then
                Dim dr As DataRow = dt.NewRow
                dr("IDLineaMaterialControl") = drMarcados("IDLineaMaterialControl")
                dr("QStock") = drMarcados("CantidadMarca1")
                dr("QPendiente") = drMarcados("QReal") - drMarcados("CantidadMarca1") - drMarcados("QActualizado")
                Dim dtLotes As DataTable = mLotes.LoteCollection.GetDataTable(drMarcados("IDLineaMaterialControl"))
                If Not dtLotes Is Nothing AndAlso dtLotes.Rows.Count > 0 Then
                    dr("Lotes") = DataTableToXml(dtLotes)
                End If
                Dim DtSeries As DataTable = mSeries.SerieCollection.GetDataTable(drMarcados("IDLineaMaterialControl"))
                If Not DtSeries Is Nothing AndAlso DtSeries.Rows.Count > 0 Then
                    dr("Series") = DataTableToXml(DtSeries)
                End If
                dr("NObra") = drMarcados("NObra")
                dr("Fecha") = Nz(drMarcados("CantidadMarcaFecha1"), Today)
                dt.Rows.Add(dr)
            End If
        Next
        Return dt
    End Function

#End Region

    Private Sub Grid_AdvSearchSetPredefinedFilter(ByVal sender As Object, ByVal e As Solmicro.Expertis.Engine.UI.GridAdvSearchFilterEventArgs) Handles Grid.AdvSearchSetPredefinedFilter
        e.Filter.Add("IDArticulo", FilterOperator.Equal, Grid.Value("IDMaterial"), FilterType.String)
    End Sub

    Private Sub Grid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Grid.KeyDown
        If e.KeyCode = Keys.F4 And Not e.Shift Then
            If Grid.Col = Grid.Columns("CantidadMarca1").Position Then
                If Grid.GetValue("GestionStockPorLotes") Then
                    mLotes.ShowDialog(Grid.GetValue("IDLineaMaterialControl"))
                ElseIf Grid.GetValue("NSerieObligatorio") Then
                    If Grid.GetValue("CantidadMarca1") < 0 Then
                        mSeries.ValorPorDefectoSeleccionEstado = ERP.CommonClasses.NSerie.ESTADO_DISPONIBLE
                        mSeries.Filtro.Clear()
                        mSeries.Filtro.Add(New BooleanFilterItem("Baja", True))
                        mSeries.ModoRecuentoSalidas = [Shared].ModoRecuentoSalidas.Seleccionados
                        mSeries.UsarColumnaSeleccion = True
                        mSeries.FiltroPorAlmacen = False
                    ElseIf Grid.GetValue("CantidadMarca1") > 0 Then
                        mSeries.ValorPorDefectoSeleccionEstado = ERP.CommonClasses.NSerie.ESTADO_VENDIDO
                        mSeries.Filtro.Clear()
                        mSeries.Filtro.Add(New BooleanFilterItem("Disponible", True))
                        mSeries.ModoRecuentoSalidas = [Shared].ModoRecuentoSalidas.Bajas
                        mSeries.UsarColumnaSeleccion = True
                    End If
                    mSeries.ShowDialog(Grid.GetValue("IDLineaMaterialControl"))
                End If
            End If
        End If
    End Sub

    Private Sub Grid_ColumnButtonClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles Grid.ColumnButtonClick
        If e.Column.Key = "CantidadMarca1" Then
            If Grid.GetValue("GestionStockPorLotes") Then
                mLotes.ShowDialog(Grid.GetValue("IDLineaMaterialControl"))
            ElseIf Grid.GetValue("NSerieObligatorio") Then
                If Grid.GetValue("CantidadMarca1") < 0 Then
                    mSeries.ValorPorDefectoSeleccionEstado = ERP.CommonClasses.NSerie.ESTADO_DISPONIBLE
                    mSeries.Filtro.Clear()
                    mSeries.Filtro.Add(New BooleanFilterItem("Baja", True))
                    mSeries.ModoRecuentoSalidas = [Shared].ModoRecuentoSalidas.Seleccionados
                    mSeries.UsarColumnaSeleccion = True
                    mSeries.FiltroPorAlmacen = False
                ElseIf Grid.GetValue("CantidadMarca1") > 0 Then
                    mSeries.ValorPorDefectoSeleccionEstado = ERP.CommonClasses.NSerie.ESTADO_VENDIDO
                    mSeries.Filtro.Clear()
                    mSeries.Filtro.Add(New BooleanFilterItem("Disponible", True))
                    mSeries.ModoRecuentoSalidas = [Shared].ModoRecuentoSalidas.Bajas
                    mSeries.UsarColumnaSeleccion = True
                End If
                mSeries.ShowDialog(Grid.GetValue("IDLineaMaterialControl"))
            End If
        End If
    End Sub

    Private Sub Grid_EditingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles Grid.EditingCell
        If Nz(Grid.GetValue("GestionStockPorLotes"), False) Then
            Grid.Columns("CantidadMarca1").ButtonDisplayMode = CellButtonDisplayMode.CurrentRow
            Grid.Columns("CantidadMarca1").ButtonStyle = ButtonStyle.Image
            Grid.Columns("CantidadMarca1").ButtonImage = Icons.Images(0)
        ElseIf Nz(Grid.GetValue("NSerieObligatorio"), False) Then
            Grid.Columns("CantidadMarca1").ButtonDisplayMode = CellButtonDisplayMode.CurrentRow
            Grid.Columns("CantidadMarca1").ButtonStyle = ButtonStyle.Image
            Grid.Columns("CantidadMarca1").ButtonImage = Icons.Images(1)
        Else
            Grid.Columns("CantidadMarca1").ButtonStyle = Janus.Windows.GridEX.ButtonStyle.NoButton
        End If

        Select Case e.Column.Key
            Case "IDAlmacen"
                If Length(Grid.GetValue("IDLineaAlbaran")) > 0 OrElse Grid.GetValue("Actualizado") = enumomcActualizado.omcActualizado OrElse Grid.GetValue("Actualizado") = enumomcActualizado.omcParcActualizado Then
                    Grid.Columns("IDAlmacen").ButtonStyle = ButtonStyle.NoButton
                    e.Cancel = True
                Else
                    Grid.Columns("IDAlmacen").ButtonStyle = ButtonStyle.Image
                    e.Cancel = False
                End If
        End Select

    End Sub

    Private Sub Grid_RecordChecked(ByVal sender As Object, ByVal e As Solmicro.Expertis.Engine.UI.CheckedEventArgs) Handles MyBase.RecordChecked
        If e.CheckState = CheckStates.UnChecked Then
            mLotes.LoteCollection.RemoveAt(e.RowData("IDLineaMaterialControl"))
        End If
    End Sub

    Private Sub Grid_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles Grid.FormattingRow
        If e.Row.RowType = RowType.Record Then
            If e.Row.Cells("Actualizado").Value = enumomcActualizado.omcActualizado Or e.Row.Cells("Actualizado").Value = enumomcActualizado.omcParcActualizado Then
                e.Row.Cells("VerStockActualizado").Image = Icons.Images(2)
            ElseIf e.Row.Cells("Actualizado").Value = enumomcActualizado.omcSinGestion Then
                e.Row.Cells("VerStockActualizado").Image = Icons.Images(3)
            End If
        End If
    End Sub

    Private Sub Grid_UpdatingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles Grid.UpdatingCell
        Select Case e.Column.Key
            Case "CantidadMarcaFecha1"
                If Len(e.Value & vbNullString) > 0 Then
                    If Not IsDate(e.Value) Then
                        e.Cancel = True
                        ExpertisApp.GenerateMessage("La Fecha no es válida.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                End If
        End Select
    End Sub

    Private Sub Grid_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid.Click
        With Grid
            If .Row <> -1 Then
                Dim hit As GridArea = .HitTest()
                If hit = GridArea.Cell Or hit = GridArea.NewRowCell Then
                    Dim c As GridEXColumn = .ColumnFromPoint()
                    If Not IsNothing(c) Then
                        Select Case c.Key
                            Case "VerStockActualizado"
                                If .Value("Actualizado") = enumomcActualizado.omcActualizado Or .Value("Actualizado") = enumomcActualizado.omcParcActualizado Then
                                    If Length(.Value("IDLineaMaterialControl")) > 0 Then
                                        Dim frm As New frmStockActualizado
                                        frm.AbrirStockActualizado(.Value("IDLineaMaterialControl"))
                                        Me.Execute()
                                    End If
                                End If
                        End Select
                    End If
                End If
            End If
        End With
    End Sub

#Region " Execute Query "

    Private Sub CIStocksObraMatCtl_QueryExecuting(ByVal sender As Object, ByRef e As Solmicro.Expertis.Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        If (Length(cbxFechaInicio.Text) > 0) Then e.Filter.Add("Fecha", FilterOperator.GreaterThanOrEqual, cbxFechaInicio.Value, FilterType.DateTime)
        If (Length(cbxFechaFin.Text) > 0) Then e.Filter.Add("Fecha", FilterOperator.LessThanOrEqual, cbxFechaFin.Value, FilterType.DateTime)

        e.Filter.Add("IdObra", FilterOperator.Equal, AdvIDObra.Value, FilterType.Numeric)
        e.Filter.Add("IDTrabajo", FilterOperator.Equal, AdvTrabajo.Value, FilterType.Numeric)
        e.Filter.Add("IDMaterial", FilterOperator.Equal, AdvMaterial.Text, FilterType.String)
        If Length(txtPendiente.Value) > 0 Then e.Filter.Add("Pendiente", FilterOperator.GreaterThan, txtPendiente.Value, FilterType.Numeric)
        e.Filter.Add("Actualizado", FilterOperator.Equal, cbxEstado.Value, FilterType.Numeric)
    End Sub

    Protected Overrides Sub OnFilterClearing(ByVal e As System.EventArgs)
        MyBase.OnFilterClearing(e)
        txtPendiente.Value = 0
    End Sub

#End Region

    Private Sub AdvTrabajo_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles AdvTrabajo.SetPredefinedFilter
        If Length(AdvIDObra.Value) > 0 Then
            e.Filter.Add("IdObra", FilterOperator.Equal, AdvIDObra.Value, FilterType.Numeric)
        End If
    End Sub
End Class
