Public Class CIObraControlAlbaranCompra
    Inherits Solmicro.Expertis.Engine.UI.CIMnto

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

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
    Friend WithEvents advAlbaranHasta As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblFechaDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFechaHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblProveedor As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblArticulo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblAlbaranDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblAlbaranHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblAlmacen As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents cbxFechaHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents advIDProveedor As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents advIDArticulo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents advAlbaranDesde As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents advIDAlmacen As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblObra As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDObra As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents advIDTrabajo As Solmicro.Expertis.Engine.UI.AdvSearch
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIObraControlAlbaranCompra))
        Me.advAlbaranHasta = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblFechaDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFechaHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.lblProveedor = New Solmicro.Expertis.Engine.UI.Label
        Me.lblArticulo = New Solmicro.Expertis.Engine.UI.Label
        Me.lblAlbaranDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.lblAlbaranHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.lblAlmacen = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.cbxFechaHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.advIDProveedor = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.advIDArticulo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.advAlbaranDesde = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.advIDAlmacen = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblObra = New Solmicro.Expertis.Engine.UI.Label
        Me.lblTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDObra = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.advIDTrabajo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.advIDTrabajo)
        Me.FilterPanel.Controls.Add(Me.advIDObra)
        Me.FilterPanel.Controls.Add(Me.lblTrabajo)
        Me.FilterPanel.Controls.Add(Me.lblObra)
        Me.FilterPanel.Controls.Add(Me.advAlbaranHasta)
        Me.FilterPanel.Controls.Add(Me.lblFechaDesde)
        Me.FilterPanel.Controls.Add(Me.lblFechaHasta)
        Me.FilterPanel.Controls.Add(Me.lblProveedor)
        Me.FilterPanel.Controls.Add(Me.lblArticulo)
        Me.FilterPanel.Controls.Add(Me.lblAlbaranDesde)
        Me.FilterPanel.Controls.Add(Me.lblAlbaranHasta)
        Me.FilterPanel.Controls.Add(Me.lblAlmacen)
        Me.FilterPanel.Controls.Add(Me.cbxFechaDesde)
        Me.FilterPanel.Controls.Add(Me.cbxFechaHasta)
        Me.FilterPanel.Controls.Add(Me.advIDProveedor)
        Me.FilterPanel.Controls.Add(Me.advIDArticulo)
        Me.FilterPanel.Controls.Add(Me.advAlbaranDesde)
        Me.FilterPanel.Controls.Add(Me.advIDAlmacen)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 360)
        Me.FilterPanel.Size = New System.Drawing.Size(701, 110)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(701, 360)
        '
        'Grid
        '
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EntityName = "AlbaranCompraLinea"
        Me.Grid.KeyField = "IDLineaAlbaran"
        Me.Grid.Size = New System.Drawing.Size(701, 360)
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.UseCheck = True
        Me.Grid.ViewName = "vFrmActualizacionObraAlbaranCompraLinea"
        '
        'CheckAll
        '
        Me.CheckAll.Visible = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'UncheckAll
        '
        Me.UncheckAll.Visible = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'ShowAllCheckedItems
        '
        Me.ShowAllCheckedItems.Visible = Janus.Windows.UI.InheritableBoolean.[True]
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
        Me.MainPanel.Size = New System.Drawing.Size(701, 470)
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(701, 470)
        '
        'advAlbaranHasta
        '
        Me.advAlbaranHasta.DisabledBackColor = System.Drawing.Color.White
        Me.advAlbaranHasta.DisplayField = "NAlbaran"
        Me.advAlbaranHasta.EntityName = "AlbaranCompraCabecera"
        Me.advAlbaranHasta.Location = New System.Drawing.Point(111, 50)
        Me.advAlbaranHasta.Name = "advAlbaranHasta"
        Me.advAlbaranHasta.PrimaryDataFields = "IDAlbaran"
        Me.advAlbaranHasta.SecondaryDataFields = "IDAlbaran"
        Me.advAlbaranHasta.Size = New System.Drawing.Size(108, 23)
        Me.advAlbaranHasta.TabIndex = 1
        '
        'lblFechaDesde
        '
        Me.lblFechaDesde.Location = New System.Drawing.Point(266, 28)
        Me.lblFechaDesde.Name = "lblFechaDesde"
        Me.lblFechaDesde.Size = New System.Drawing.Size(80, 13)
        Me.lblFechaDesde.TabIndex = 20
        Me.lblFechaDesde.Tag = "IdRec=4841;"
        Me.lblFechaDesde.Text = "Fecha Desde"
        '
        'lblFechaHasta
        '
        Me.lblFechaHasta.Location = New System.Drawing.Point(266, 55)
        Me.lblFechaHasta.Name = "lblFechaHasta"
        Me.lblFechaHasta.Size = New System.Drawing.Size(76, 13)
        Me.lblFechaHasta.TabIndex = 22
        Me.lblFechaHasta.Text = "Fecha Hasta"
        '
        'lblProveedor
        '
        Me.lblProveedor.Location = New System.Drawing.Point(16, 83)
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Size = New System.Drawing.Size(66, 13)
        Me.lblProveedor.TabIndex = 28
        Me.lblProveedor.Tag = "IdRec=4365;"
        Me.lblProveedor.Text = "Proveedor"
        '
        'lblArticulo
        '
        Me.lblArticulo.Location = New System.Drawing.Point(524, 83)
        Me.lblArticulo.Name = "lblArticulo"
        Me.lblArticulo.Size = New System.Drawing.Size(50, 13)
        Me.lblArticulo.TabIndex = 24
        Me.lblArticulo.Tag = "IdRec=4377;"
        Me.lblArticulo.Text = "Artículo"
        '
        'lblAlbaranDesde
        '
        Me.lblAlbaranDesde.Location = New System.Drawing.Point(16, 26)
        Me.lblAlbaranDesde.Name = "lblAlbaranDesde"
        Me.lblAlbaranDesde.Size = New System.Drawing.Size(91, 13)
        Me.lblAlbaranDesde.TabIndex = 16
        Me.lblAlbaranDesde.Tag = ""
        Me.lblAlbaranDesde.Text = "Albarán Desde"
        '
        'lblAlbaranHasta
        '
        Me.lblAlbaranHasta.Location = New System.Drawing.Point(16, 55)
        Me.lblAlbaranHasta.Name = "lblAlbaranHasta"
        Me.lblAlbaranHasta.Size = New System.Drawing.Size(87, 13)
        Me.lblAlbaranHasta.TabIndex = 18
        Me.lblAlbaranHasta.Text = "Albarán Hasta"
        '
        'lblAlmacen
        '
        Me.lblAlmacen.Location = New System.Drawing.Point(266, 84)
        Me.lblAlmacen.Name = "lblAlmacen"
        Me.lblAlmacen.Size = New System.Drawing.Size(56, 13)
        Me.lblAlmacen.TabIndex = 26
        Me.lblAlmacen.Tag = "IdRec=4390;"
        Me.lblAlmacen.Text = "Almacén"
        '
        'cbxFechaDesde
        '
        Me.cbxFechaDesde.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaDesde.Location = New System.Drawing.Point(353, 25)
        Me.cbxFechaDesde.Name = "cbxFechaDesde"
        Me.cbxFechaDesde.Size = New System.Drawing.Size(108, 21)
        Me.cbxFechaDesde.TabIndex = 3
        '
        'cbxFechaHasta
        '
        Me.cbxFechaHasta.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaHasta.Location = New System.Drawing.Point(353, 52)
        Me.cbxFechaHasta.Name = "cbxFechaHasta"
        Me.cbxFechaHasta.Size = New System.Drawing.Size(108, 21)
        Me.cbxFechaHasta.TabIndex = 4
        '
        'advIDProveedor
        '
        Me.advIDProveedor.DisabledBackColor = System.Drawing.Color.White
        Me.advIDProveedor.EntityName = "Proveedor"
        Me.advIDProveedor.Location = New System.Drawing.Point(111, 78)
        Me.advIDProveedor.Name = "advIDProveedor"
        Me.advIDProveedor.PrimaryDataFields = "IDProveedor"
        Me.advIDProveedor.SecondaryDataFields = "IDProveedor"
        Me.advIDProveedor.Size = New System.Drawing.Size(108, 23)
        Me.advIDProveedor.TabIndex = 2
        Me.advIDProveedor.ViewName = "tbMaestroProveedor"
        '
        'advIDArticulo
        '
        Me.advIDArticulo.DisabledBackColor = System.Drawing.Color.White
        Me.advIDArticulo.EntityName = "Articulo"
        Me.advIDArticulo.Location = New System.Drawing.Point(585, 78)
        Me.advIDArticulo.Name = "advIDArticulo"
        Me.advIDArticulo.PrimaryDataFields = "IDArticulo"
        Me.advIDArticulo.SecondaryDataFields = "IDArticulo"
        Me.advIDArticulo.Size = New System.Drawing.Size(108, 23)
        Me.advIDArticulo.TabIndex = 8
        Me.advIDArticulo.ViewName = "tbMaestroArticulo"
        '
        'advAlbaranDesde
        '
        Me.advAlbaranDesde.DisabledBackColor = System.Drawing.Color.White
        Me.advAlbaranDesde.DisplayField = "NAlbaran"
        Me.advAlbaranDesde.EntityName = "AlbaranCompraCabecera"
        Me.advAlbaranDesde.Location = New System.Drawing.Point(111, 23)
        Me.advAlbaranDesde.Name = "advAlbaranDesde"
        Me.advAlbaranDesde.PrimaryDataFields = "IDAlbaran"
        Me.advAlbaranDesde.SecondaryDataFields = "IDAlbaran"
        Me.advAlbaranDesde.Size = New System.Drawing.Size(108, 23)
        Me.advAlbaranDesde.TabIndex = 0
        '
        'advIDAlmacen
        '
        Me.advIDAlmacen.DisabledBackColor = System.Drawing.Color.White
        Me.advIDAlmacen.EntityName = "Almacen"
        Me.advIDAlmacen.Location = New System.Drawing.Point(353, 78)
        Me.advIDAlmacen.Name = "advIDAlmacen"
        Me.advIDAlmacen.PrimaryDataFields = "IDAlmacen"
        Me.advIDAlmacen.SecondaryDataFields = "IDAlmacen"
        Me.advIDAlmacen.Size = New System.Drawing.Size(108, 23)
        Me.advIDAlmacen.TabIndex = 5
        Me.advIDAlmacen.ViewName = "tbMaestroAlmacen"
        '
        'lblObra
        '
        Me.lblObra.Location = New System.Drawing.Point(524, 28)
        Me.lblObra.Name = "lblObra"
        Me.lblObra.Size = New System.Drawing.Size(57, 13)
        Me.lblObra.TabIndex = 30
        Me.lblObra.Text = "Proyecto"
        '
        'lblTrabajo
        '
        Me.lblTrabajo.Location = New System.Drawing.Point(524, 55)
        Me.lblTrabajo.Name = "lblTrabajo"
        Me.lblTrabajo.Size = New System.Drawing.Size(51, 13)
        Me.lblTrabajo.TabIndex = 31
        Me.lblTrabajo.Text = "Trabajo"
        '
        'advIDObra
        '
        Me.advIDObra.DisabledBackColor = System.Drawing.Color.White
        Me.advIDObra.DisplayField = "NObra"
        Me.advIDObra.EntityName = "ObraCabecera"
        Me.advIDObra.Location = New System.Drawing.Point(585, 23)
        Me.advIDObra.Name = "advIDObra"
        Me.advIDObra.PrimaryDataFields = "IDObra"
        Me.advIDObra.SecondaryDataFields = "IDObra"
        Me.advIDObra.Size = New System.Drawing.Size(108, 23)
        Me.advIDObra.TabIndex = 6
        '
        'advIDTrabajo
        '
        Me.advIDTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.advIDTrabajo.DisplayField = "CodTrabajo"
        Me.advIDTrabajo.EntityName = "ObraTrabajo"
        Me.advIDTrabajo.Location = New System.Drawing.Point(585, 50)
        Me.advIDTrabajo.Name = "advIDTrabajo"
        Me.advIDTrabajo.PrimaryDataFields = "IDTrabajo"
        Me.advIDTrabajo.SecondaryDataFields = "IDTrabajo"
        Me.advIDTrabajo.Size = New System.Drawing.Size(108, 23)
        Me.advIDTrabajo.TabIndex = 7
        '
        'CIObraControlAlbaranCompra
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(709, 558)
        Me.EntityName = "AlbaranCompraLinea"
        Me.KeyField = "IDLineaAlbaran"
        Me.Name = "CIObraControlAlbaranCompra"
        Me.Text = "CIObraControlAlbaranCompra"
        Me.UseCheck = True
        Me.ViewName = "vFrmActualizacionObraAlbaranCompraLinea"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Load "

    Private Sub CIObraControlAlbaranCompra_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadToolbarActions()
        LoadGridActions()
        LoadEnums()
    End Sub

    Private Sub LoadToolbarActions()
        Me.FormActions.Add("Generar Control en Proyecto", AddressOf ControlAlbaran, ExpertisApp.GetIcon("gear_run.ico"))
    End Sub

    Private Sub LoadGridActions()
        Grid.Actions.Add("Abrir Albarán Compra", AddressOf AccionAbrirAlbaranCompra, ExpertisApp.GetIcon("xAlbaranCompra.ico"))
        Grid.Actions.Add("Abrir Proyecto", AddressOf AccionAbrirObra, ExpertisApp.GetIcon("xProyectos.ico"))
    End Sub

    Private Sub LoadEnums()
        EnumData.PopulateValueList("enumfclTipoGastoObra", Grid.Columns("TipoGastoObra"))
    End Sub

#End Region

#Region " Toobar Actions "

    Private Sub ControlAlbaran()
        If Grid.CheckedRecordsCount > 0 Then
            If ExpertisApp.GenerateMessage("Se generarán líneas de Control en Proyectos para las líneas de Albarán seleccionadas.{0}¿Desea continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, vbNewLine) = Windows.Forms.DialogResult.Yes Then
                Dim dtMarcadas As DataTable = Grid.CheckedRecords
                ExpertisApp.ExecuteTask(Of DataTable)(AddressOf GenerarControlObras.GenerarControl, dtMarcadas)
                ExpertisApp.GenerateMessage("Proceso Finalizado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.UnCheckAllRecords()
                Me.Execute()
            End If
        Else
            ExpertisApp.GenerateMessage("No hay lineas seleccionadas.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

#End Region

#Region " Grid Actions "

    Private Sub AccionAbrirAlbaranCompra()
        If Length(Grid.Value("IDAlbaran")) > 0 Then
            ExpertisApp.OpenForm("MALBC", New NumberFilterItem("IDAlbaran", Grid.Value("IDAlbaran")))
        End If
    End Sub

    Private Sub AccionAbrirObra()
        If Length(Grid.Value("IDObra")) > 0 Then
            ExpertisApp.OpenForm("MGEO", New NumberFilterItem("IDObra", Grid.Value("IDObra")))
        End If
    End Sub

#End Region

    Private Sub CIObraControlAlbaranCompra_QueryExecuting(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        e.Filter.Add("IDAlbaran", FilterOperator.GreaterThanOrEqual, advAlbaranDesde.Value, FilterType.Numeric)
        e.Filter.Add("IDAlbaran", FilterOperator.LessThanOrEqual, advAlbaranHasta.Text, FilterType.Numeric)
        e.Filter.Add("FechaAlbaran", FilterOperator.GreaterThanOrEqual, cbxFechaDesde.Value, FilterType.DateTime)
        e.Filter.Add("FechaAlbaran", FilterOperator.LessThanOrEqual, cbxFechaHasta.Value, FilterType.DateTime)
        e.Filter.Add("IDArticulo", FilterOperator.Equal, advIDArticulo.Text, FilterType.String)
        e.Filter.Add("IDProveedor", FilterOperator.Equal, advIDProveedor.Text, FilterType.String)
        e.Filter.Add("IDAlmacen", FilterOperator.Equal, advIDAlmacen.Text, FilterType.String)
        e.Filter.Add("IDObra", FilterOperator.Equal, advIDObra.Value, FilterType.Numeric)
        e.Filter.Add("IDTrabajo", FilterOperator.Equal, advIDTrabajo.Value, FilterType.Numeric)
    End Sub

    Private Sub advTrabajo_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles advIDTrabajo.SetPredefinedFilter
        If Length(advIDObra.Value) > 0 Then
            e.Filter.Add("IDObra", FilterOperator.Equal, advIDObra.Value)
        End If
    End Sub

End Class
