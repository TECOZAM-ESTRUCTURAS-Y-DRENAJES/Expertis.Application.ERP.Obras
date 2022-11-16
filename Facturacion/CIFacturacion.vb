Imports Microsoft.VisualBasic
Imports Janus.Windows.GridEX
Public Class CIFacturacion
    Inherits Solmicro.Expertis.Engine.UI.CIMntoBase

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
    Public WithEvents FilterPanel As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents lblTipoTrabajo As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblSubTipoTrabajo As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblObraDesde As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblObraHasta As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents AdvObraHasta As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents AdvTipoTrabajo As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents AdvSubTipoTrabajo As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents AdvTrabajo As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents AdvObraDesde As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblClienteHasta As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblClienteDesde As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblCentroGestion As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblArticulo As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblFechaHasta As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents AdvIDCentroGestion As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents AdvIDArticulo As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblFechaDesde As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxFechaDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents cbxFechaHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents lblAgrupFactura As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxAgrupFactura As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents cbxEstado As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents lblEstado As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents pnlTipoFactura As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents lblTipoFactura As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxTipoFactura As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents pnlEstadoCertificacion As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents cbxEstadoCertificacion As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents lblEstadoCertificacion As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents pnlOperario As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents lblOperario As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents AdvIDOperario As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents pnlEstado As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents pnlCriteriosSeleccion As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents AdvClienteHasta As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents AdvClienteDesde As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblCodTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ShowFilterPanel As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents ShowFilterPanel1 As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents lblContador As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents TabFacturacion As Solmicro.Expertis.Engine.UI.Tab
    Public WithEvents TabPageHitos As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents GridVtos As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents TabPageHoras As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents GridMod As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents TabPageGastos As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents GridGastos As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents TabPageCertificacion As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents GridCertificacion As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents txtTotalMarcado As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents txtTotal As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblTotalReal As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblTotalMarcado As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxFechaVto As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents lblTipoAgrupacion As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxTipoAgrupacion As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents chkCondicionesCliente As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents AdvContador As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblFechaVto As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxAño As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents lblAño As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents pnlFechaVto As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents pnlConfigFacturacion As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Public WithEvents TabPageMateriales As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents GridMateriales As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents TabPageTaller As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents GridTaller As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents lblAlqOVen As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents AdvAlqVen As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents pnlTotales As Solmicro.Expertis.Engine.UI.Panel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim cbxEstadoCertificacion_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxTipoFactura_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxEstado_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxAgrupFactura_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIFacturacion))
        Dim cbxTipoAgrupacion_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxAño_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridVtos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridMod_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridGastos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridMateriales_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridCertificacion_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridTaller_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.pnlCriteriosSeleccion = New Solmicro.Expertis.Engine.UI.Panel
        Me.FilterPanel = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblAlqOVen = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvAlqVen = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblTipoFactura = New Solmicro.Expertis.Engine.UI.Label
        Me.lblCodTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDArticulo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblArticulo = New Solmicro.Expertis.Engine.UI.Label
        Me.pnlOperario = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblOperario = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDOperario = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.pnlEstadoCertificacion = New Solmicro.Expertis.Engine.UI.Panel
        Me.cbxEstadoCertificacion = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblEstadoCertificacion = New Solmicro.Expertis.Engine.UI.Label
        Me.pnlTipoFactura = New Solmicro.Expertis.Engine.UI.Panel
        Me.cbxTipoFactura = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.pnlEstado = New Solmicro.Expertis.Engine.UI.Panel
        Me.cbxEstado = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblEstado = New Solmicro.Expertis.Engine.UI.Label
        Me.lblAgrupFactura = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxAgrupFactura = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblFechaDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblCentroGestion = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDCentroGestion = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblClienteHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvClienteHasta = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblClienteDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvClienteDesde = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.AdvObraHasta = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblTipoTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvTipoTrabajo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblSubTipoTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvSubTipoTrabajo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.AdvTrabajo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblObraDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvObraDesde = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblObraHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.ShowFilterPanel = New Janus.Windows.UI.CommandBars.UICommand("ShowFilterPanel")
        Me.ShowFilterPanel1 = New Janus.Windows.UI.CommandBars.UICommand("ShowFilterPanel")
        Me.pnlTotales = New Solmicro.Expertis.Engine.UI.Panel
        Me.txtTotalMarcado = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtTotal = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblTotalReal = New Solmicro.Expertis.Engine.UI.Label
        Me.lblTotalMarcado = New Solmicro.Expertis.Engine.UI.Label
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.pnlConfigFacturacion = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblTipoAgrupacion = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxTipoAgrupacion = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.chkCondicionesCliente = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.lblContador = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvContador = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.pnlFechaVto = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblFechaVto = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaVto = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.cbxAño = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblAño = New Solmicro.Expertis.Engine.UI.Label
        Me.TabFacturacion = New Solmicro.Expertis.Engine.UI.Tab
        Me.TabPageHitos = New Janus.Windows.UI.Tab.UITabPage
        Me.GridVtos = New Solmicro.Expertis.Engine.UI.Grid
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TabPageHoras = New Janus.Windows.UI.Tab.UITabPage
        Me.GridMod = New Solmicro.Expertis.Engine.UI.Grid
        Me.TabPageGastos = New Janus.Windows.UI.Tab.UITabPage
        Me.GridGastos = New Solmicro.Expertis.Engine.UI.Grid
        Me.TabPageMateriales = New Janus.Windows.UI.Tab.UITabPage
        Me.GridMateriales = New Solmicro.Expertis.Engine.UI.Grid
        Me.TabPageCertificacion = New Janus.Windows.UI.Tab.UITabPage
        Me.GridCertificacion = New Solmicro.Expertis.Engine.UI.Grid
        Me.TabPageTaller = New Janus.Windows.UI.Tab.UITabPage
        Me.GridTaller = New Solmicro.Expertis.Engine.UI.Grid
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        Me.pnlCriteriosSeleccion.suspendlayout()
        Me.FilterPanel.SuspendLayout()
        Me.pnlOperario.suspendlayout()
        Me.pnlEstadoCertificacion.suspendlayout()
        CType(Me.cbxEstadoCertificacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTipoFactura.suspendlayout()
        CType(Me.cbxTipoFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlEstado.suspendlayout()
        CType(Me.cbxEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxAgrupFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTotales.suspendlayout()
        Me.Panel1.suspendlayout()
        Me.pnlConfigFacturacion.suspendlayout()
        CType(Me.cbxTipoAgrupacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFechaVto.suspendlayout()
        CType(Me.cbxAño, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabFacturacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabFacturacion.SuspendLayout()
        Me.TabPageHitos.SuspendLayout()
        CType(Me.GridVtos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageHoras.SuspendLayout()
        CType(Me.GridMod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageGastos.SuspendLayout()
        CType(Me.GridGastos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageMateriales.SuspendLayout()
        CType(Me.GridMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageCertificacion.SuspendLayout()
        CType(Me.GridCertificacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageTaller.SuspendLayout()
        CType(Me.GridTaller, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UiCommandManager1
        '
        Me.UiCommandManager1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.ShowFilterPanel})
        '
        'CheckAll
        '
        Me.CheckAll.Icon = CType(resources.GetObject("CheckAll.Icon"), System.Drawing.Icon)
        Me.CheckAll.Text = ""
        '
        'UncheckAll
        '
        Me.UncheckAll.Icon = CType(resources.GetObject("UncheckAll.Icon"), System.Drawing.Icon)
        Me.UncheckAll.Text = ""
        '
        'ExecuteQuery
        '
        Me.ExecuteQuery.Icon = CType(resources.GetObject("ExecuteQuery.Icon"), System.Drawing.Icon)
        Me.ExecuteQuery.Text = ""
        '
        'ShowAllCheckedItems
        '
        Me.ShowAllCheckedItems.Icon = CType(resources.GetObject("ShowAllCheckedItems.Icon"), System.Drawing.Icon)
        Me.ShowAllCheckedItems.Text = ""
        '
        'ClearFilter
        '
        Me.ClearFilter.Icon = CType(resources.GetObject("ClearFilter.Icon"), System.Drawing.Icon)
        Me.ClearFilter.Text = ""
        '
        'Export
        '
        Me.Export.Icon = CType(resources.GetObject("Export.Icon"), System.Drawing.Icon)
        Me.Export.Text = ""
        '
        'Toolbar
        '
        Me.Toolbar.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.ShowFilterPanel1})
        Me.Toolbar.Size = New System.Drawing.Size(316, 28)
        '
        'Menubar
        '
        Me.Menubar.Location = New System.Drawing.Point(0, 28)
        '
        'MainPanel
        '
        Me.MainPanel.Controls.Add(Me.TabFacturacion)
        Me.MainPanel.Controls.Add(Me.Panel1)
        Me.MainPanel.Controls.Add(Me.pnlTotales)
        Me.MainPanel.Controls.Add(Me.pnlCriteriosSeleccion)
        Me.MainPanel.Size = New System.Drawing.Size(775, 489)
        '
        'ExecuteActions
        '
        Me.ExecuteActions.Icon = CType(resources.GetObject("ExecuteActions.Icon"), System.Drawing.Icon)
        Me.ExecuteActions.Text = ""
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(775, 489)
        '
        'pnlCriteriosSeleccion
        '
        Me.pnlCriteriosSeleccion.Controls.Add(Me.FilterPanel)
        Me.pnlCriteriosSeleccion.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlCriteriosSeleccion.Location = New System.Drawing.Point(0, 360)
        Me.pnlCriteriosSeleccion.Name = "pnlCriteriosSeleccion"
        Me.pnlCriteriosSeleccion.Size = New System.Drawing.Size(775, 129)
        Me.pnlCriteriosSeleccion.TabIndex = 7
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.lblAlqOVen)
        Me.FilterPanel.Controls.Add(Me.AdvAlqVen)
        Me.FilterPanel.Controls.Add(Me.lblTipoFactura)
        Me.FilterPanel.Controls.Add(Me.lblCodTrabajo)
        Me.FilterPanel.Controls.Add(Me.AdvIDArticulo)
        Me.FilterPanel.Controls.Add(Me.lblArticulo)
        Me.FilterPanel.Controls.Add(Me.pnlOperario)
        Me.FilterPanel.Controls.Add(Me.pnlEstadoCertificacion)
        Me.FilterPanel.Controls.Add(Me.pnlTipoFactura)
        Me.FilterPanel.Controls.Add(Me.pnlEstado)
        Me.FilterPanel.Controls.Add(Me.lblAgrupFactura)
        Me.FilterPanel.Controls.Add(Me.cbxAgrupFactura)
        Me.FilterPanel.Controls.Add(Me.lblFechaDesde)
        Me.FilterPanel.Controls.Add(Me.cbxFechaDesde)
        Me.FilterPanel.Controls.Add(Me.lblFechaHasta)
        Me.FilterPanel.Controls.Add(Me.cbxFechaHasta)
        Me.FilterPanel.Controls.Add(Me.lblCentroGestion)
        Me.FilterPanel.Controls.Add(Me.AdvIDCentroGestion)
        Me.FilterPanel.Controls.Add(Me.lblClienteHasta)
        Me.FilterPanel.Controls.Add(Me.AdvClienteHasta)
        Me.FilterPanel.Controls.Add(Me.lblClienteDesde)
        Me.FilterPanel.Controls.Add(Me.AdvClienteDesde)
        Me.FilterPanel.Controls.Add(Me.AdvObraHasta)
        Me.FilterPanel.Controls.Add(Me.lblTipoTrabajo)
        Me.FilterPanel.Controls.Add(Me.AdvTipoTrabajo)
        Me.FilterPanel.Controls.Add(Me.lblSubTipoTrabajo)
        Me.FilterPanel.Controls.Add(Me.AdvSubTipoTrabajo)
        Me.FilterPanel.Controls.Add(Me.AdvTrabajo)
        Me.FilterPanel.Controls.Add(Me.lblObraDesde)
        Me.FilterPanel.Controls.Add(Me.AdvObraDesde)
        Me.FilterPanel.Controls.Add(Me.lblObraHasta)
        Me.FilterPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FilterPanel.Location = New System.Drawing.Point(0, 0)
        Me.FilterPanel.Name = "FilterPanel"
        Me.FilterPanel.Size = New System.Drawing.Size(775, 129)
        Me.FilterPanel.TabIndex = 8
        Me.FilterPanel.TabStop = False
        Me.FilterPanel.Text = " Criterios de Selección  "
        '
        'lblAlqOVen
        '
        Me.lblAlqOVen.Location = New System.Drawing.Point(390, 107)
        Me.lblAlqOVen.Name = "lblAlqOVen"
        Me.lblAlqOVen.Size = New System.Drawing.Size(58, 13)
        Me.lblAlqOVen.TabIndex = 123
        Me.lblAlqOVen.Text = "Alq/Vend"
        Me.lblAlqOVen.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'AdvAlqVen
        '
        Me.AdvAlqVen.DisabledBackColor = System.Drawing.Color.White
        Me.AdvAlqVen.EntityName = "FacturacionAuxiliar"
        Me.AdvAlqVen.Location = New System.Drawing.Point(464, 100)
        Me.AdvAlqVen.Name = "AdvAlqVen"
        Me.AdvAlqVen.SecondaryDataFields = "DescFacturacion"
        Me.AdvAlqVen.Size = New System.Drawing.Size(101, 23)
        Me.AdvAlqVen.TabIndex = 109
        Me.AdvAlqVen.ViewName = "tbFacturacionAux"
        '
        'lblTipoFactura
        '
        Me.lblTipoFactura.Location = New System.Drawing.Point(586, 78)
        Me.lblTipoFactura.Name = "lblTipoFactura"
        Me.lblTipoFactura.Size = New System.Drawing.Size(76, 13)
        Me.lblTipoFactura.TabIndex = 113
        Me.lblTipoFactura.Tag = "IdRec=5774;"
        Me.lblTipoFactura.Text = "Tipo Factura"
        Me.lblTipoFactura.Visible = False
        '
        'lblCodTrabajo
        '
        Me.lblCodTrabajo.Location = New System.Drawing.Point(208, 28)
        Me.lblCodTrabajo.Name = "lblCodTrabajo"
        Me.lblCodTrabajo.Size = New System.Drawing.Size(50, 13)
        Me.lblCodTrabajo.TabIndex = 122
        Me.lblCodTrabajo.Tag = ""
        Me.lblCodTrabajo.Text = "Trabajo"
        '
        'AdvIDArticulo
        '
        Me.AdvIDArticulo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDArticulo.EntityName = "Articulo"
        Me.AdvIDArticulo.Location = New System.Drawing.Point(665, 101)
        Me.AdvIDArticulo.Name = "AdvIDArticulo"
        Me.AdvIDArticulo.PrimaryDataFields = "IDArticulo"
        Me.AdvIDArticulo.SecondaryDataFields = "IDArticulo"
        Me.AdvIDArticulo.Size = New System.Drawing.Size(99, 23)
        Me.AdvIDArticulo.TabIndex = 10
        Me.AdvIDArticulo.ViewName = "tbMaestroArticulo"
        '
        'lblArticulo
        '
        Me.lblArticulo.Location = New System.Drawing.Point(586, 105)
        Me.lblArticulo.Name = "lblArticulo"
        Me.lblArticulo.Size = New System.Drawing.Size(50, 13)
        Me.lblArticulo.TabIndex = 94
        Me.lblArticulo.Tag = "IdRec=4377;"
        Me.lblArticulo.Text = "Artículo"
        '
        'pnlOperario
        '
        Me.pnlOperario.Controls.Add(Me.lblOperario)
        Me.pnlOperario.Controls.Add(Me.AdvIDOperario)
        Me.pnlOperario.Location = New System.Drawing.Point(584, 73)
        Me.pnlOperario.Name = "pnlOperario"
        Me.pnlOperario.Size = New System.Drawing.Size(185, 25)
        Me.pnlOperario.TabIndex = 121
        Me.pnlOperario.Visible = False
        '
        'lblOperario
        '
        Me.lblOperario.Location = New System.Drawing.Point(2, 7)
        Me.lblOperario.Name = "lblOperario"
        Me.lblOperario.Size = New System.Drawing.Size(57, 13)
        Me.lblOperario.TabIndex = 108
        Me.lblOperario.Tag = "IdRec=5860;"
        Me.lblOperario.Text = "Operario"
        Me.lblOperario.Visible = False
        '
        'AdvIDOperario
        '
        Me.AdvIDOperario.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDOperario.EntityName = "Operario"
        Me.AdvIDOperario.Location = New System.Drawing.Point(77, 2)
        Me.AdvIDOperario.Name = "AdvIDOperario"
        Me.AdvIDOperario.PrimaryDataFields = "IDOperario"
        Me.AdvIDOperario.SecondaryDataFields = "IDOperario"
        Me.AdvIDOperario.Size = New System.Drawing.Size(99, 23)
        Me.AdvIDOperario.TabIndex = 14
        Me.AdvIDOperario.ViewName = "tbMaestroOperario"
        Me.AdvIDOperario.Visible = False
        '
        'pnlEstadoCertificacion
        '
        Me.pnlEstadoCertificacion.Controls.Add(Me.cbxEstadoCertificacion)
        Me.pnlEstadoCertificacion.Controls.Add(Me.lblEstadoCertificacion)
        Me.pnlEstadoCertificacion.Location = New System.Drawing.Point(393, 75)
        Me.pnlEstadoCertificacion.Name = "pnlEstadoCertificacion"
        Me.pnlEstadoCertificacion.Size = New System.Drawing.Size(170, 25)
        Me.pnlEstadoCertificacion.TabIndex = 118
        Me.pnlEstadoCertificacion.Visible = False
        '
        'cbxEstadoCertificacion
        '
        cbxEstadoCertificacion_DesignTimeLayout.LayoutString = resources.GetString("cbxEstadoCertificacion_DesignTimeLayout.LayoutString")
        Me.cbxEstadoCertificacion.DesignTimeLayout = cbxEstadoCertificacion_DesignTimeLayout
        Me.cbxEstadoCertificacion.DisabledBackColor = System.Drawing.Color.White
        Me.cbxEstadoCertificacion.Location = New System.Drawing.Point(58, 1)
        Me.cbxEstadoCertificacion.Name = "cbxEstadoCertificacion"
        Me.cbxEstadoCertificacion.SelectedIndex = -1
        Me.cbxEstadoCertificacion.SelectedItem = Nothing
        Me.cbxEstadoCertificacion.Size = New System.Drawing.Size(96, 21)
        Me.cbxEstadoCertificacion.TabIndex = 12
        Me.cbxEstadoCertificacion.Visible = False
        '
        'lblEstadoCertificacion
        '
        Me.lblEstadoCertificacion.Location = New System.Drawing.Point(-3, 3)
        Me.lblEstadoCertificacion.Name = "lblEstadoCertificacion"
        Me.lblEstadoCertificacion.Size = New System.Drawing.Size(45, 13)
        Me.lblEstadoCertificacion.TabIndex = 116
        Me.lblEstadoCertificacion.Tag = "IdRec=4405;"
        Me.lblEstadoCertificacion.Text = "Estado"
        Me.lblEstadoCertificacion.Visible = False
        '
        'pnlTipoFactura
        '
        Me.pnlTipoFactura.Controls.Add(Me.cbxTipoFactura)
        Me.pnlTipoFactura.Location = New System.Drawing.Point(584, 73)
        Me.pnlTipoFactura.Name = "pnlTipoFactura"
        Me.pnlTipoFactura.Size = New System.Drawing.Size(188, 25)
        Me.pnlTipoFactura.TabIndex = 117
        Me.pnlTipoFactura.Visible = False
        '
        'cbxTipoFactura
        '
        cbxTipoFactura_DesignTimeLayout.LayoutString = resources.GetString("cbxTipoFactura_DesignTimeLayout.LayoutString")
        Me.cbxTipoFactura.DesignTimeLayout = cbxTipoFactura_DesignTimeLayout
        Me.cbxTipoFactura.DisabledBackColor = System.Drawing.Color.White
        Me.cbxTipoFactura.Location = New System.Drawing.Point(81, 3)
        Me.cbxTipoFactura.Name = "cbxTipoFactura"
        Me.cbxTipoFactura.SelectedIndex = -1
        Me.cbxTipoFactura.SelectedItem = Nothing
        Me.cbxTipoFactura.Size = New System.Drawing.Size(99, 21)
        Me.cbxTipoFactura.TabIndex = 13
        Me.cbxTipoFactura.Visible = False
        '
        'pnlEstado
        '
        Me.pnlEstado.Controls.Add(Me.cbxEstado)
        Me.pnlEstado.Controls.Add(Me.lblEstado)
        Me.pnlEstado.Location = New System.Drawing.Point(588, 21)
        Me.pnlEstado.Name = "pnlEstado"
        Me.pnlEstado.Size = New System.Drawing.Size(178, 25)
        Me.pnlEstado.TabIndex = 11
        '
        'cbxEstado
        '
        cbxEstado_DesignTimeLayout.LayoutString = resources.GetString("cbxEstado_DesignTimeLayout.LayoutString")
        Me.cbxEstado.DesignTimeLayout = cbxEstado_DesignTimeLayout
        Me.cbxEstado.DisabledBackColor = System.Drawing.Color.White
        Me.cbxEstado.Location = New System.Drawing.Point(77, 2)
        Me.cbxEstado.Name = "cbxEstado"
        Me.cbxEstado.SelectedIndex = -1
        Me.cbxEstado.SelectedItem = Nothing
        Me.cbxEstado.Size = New System.Drawing.Size(99, 21)
        Me.cbxEstado.TabIndex = 0
        '
        'lblEstado
        '
        Me.lblEstado.Location = New System.Drawing.Point(2, 6)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(45, 13)
        Me.lblEstado.TabIndex = 116
        Me.lblEstado.Tag = "IdRec=4405;"
        Me.lblEstado.Text = "Estado"
        '
        'lblAgrupFactura
        '
        Me.lblAgrupFactura.Location = New System.Drawing.Point(585, 53)
        Me.lblAgrupFactura.Name = "lblAgrupFactura"
        Me.lblAgrupFactura.Size = New System.Drawing.Size(71, 13)
        Me.lblAgrupFactura.TabIndex = 113
        Me.lblAgrupFactura.Tag = "IdRec=13034;"
        Me.lblAgrupFactura.Text = "Agrup Fact."
        '
        'cbxAgrupFactura
        '
        cbxAgrupFactura_DesignTimeLayout.LayoutString = resources.GetString("cbxAgrupFactura_DesignTimeLayout.LayoutString")
        Me.cbxAgrupFactura.DesignTimeLayout = cbxAgrupFactura_DesignTimeLayout
        Me.cbxAgrupFactura.DisabledBackColor = System.Drawing.Color.White
        Me.cbxAgrupFactura.Location = New System.Drawing.Point(665, 49)
        Me.cbxAgrupFactura.Name = "cbxAgrupFactura"
        Me.cbxAgrupFactura.SelectedIndex = -1
        Me.cbxAgrupFactura.SelectedItem = Nothing
        Me.cbxAgrupFactura.Size = New System.Drawing.Size(99, 21)
        Me.cbxAgrupFactura.TabIndex = 12
        '
        'lblFechaDesde
        '
        Me.lblFechaDesde.Location = New System.Drawing.Point(403, 31)
        Me.lblFechaDesde.Name = "lblFechaDesde"
        Me.lblFechaDesde.Size = New System.Drawing.Size(57, 13)
        Me.lblFechaDesde.TabIndex = 97
        Me.lblFechaDesde.Tag = "IdRec=13037;"
        Me.lblFechaDesde.Text = "Fecha D."
        '
        'cbxFechaDesde
        '
        Me.cbxFechaDesde.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaDesde.Location = New System.Drawing.Point(464, 25)
        Me.cbxFechaDesde.Name = "cbxFechaDesde"
        Me.cbxFechaDesde.Size = New System.Drawing.Size(99, 21)
        Me.cbxFechaDesde.TabIndex = 8
        '
        'lblFechaHasta
        '
        Me.lblFechaHasta.Location = New System.Drawing.Point(403, 54)
        Me.lblFechaHasta.Name = "lblFechaHasta"
        Me.lblFechaHasta.Size = New System.Drawing.Size(56, 13)
        Me.lblFechaHasta.TabIndex = 98
        Me.lblFechaHasta.Tag = ""
        Me.lblFechaHasta.Text = "Fecha H."
        '
        'cbxFechaHasta
        '
        Me.cbxFechaHasta.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaHasta.Location = New System.Drawing.Point(464, 49)
        Me.cbxFechaHasta.Name = "cbxFechaHasta"
        Me.cbxFechaHasta.Size = New System.Drawing.Size(99, 21)
        Me.cbxFechaHasta.TabIndex = 9
        '
        'lblCentroGestion
        '
        Me.lblCentroGestion.Location = New System.Drawing.Point(208, 107)
        Me.lblCentroGestion.Name = "lblCentroGestion"
        Me.lblCentroGestion.Size = New System.Drawing.Size(63, 13)
        Me.lblCentroGestion.TabIndex = 92
        Me.lblCentroGestion.Tag = "IdRec=9959;"
        Me.lblCentroGestion.Text = "C.Gestión"
        '
        'AdvIDCentroGestion
        '
        Me.AdvIDCentroGestion.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDCentroGestion.EntityName = "CentroGestion"
        Me.AdvIDCentroGestion.Location = New System.Drawing.Point(275, 101)
        Me.AdvIDCentroGestion.Name = "AdvIDCentroGestion"
        Me.AdvIDCentroGestion.PrimaryDataFields = "IDCentroGestion"
        Me.AdvIDCentroGestion.SecondaryDataFields = "IDCentroGestion"
        Me.AdvIDCentroGestion.Size = New System.Drawing.Size(99, 23)
        Me.AdvIDCentroGestion.TabIndex = 7
        Me.AdvIDCentroGestion.ViewName = "tbMaestroCentroGestion"
        '
        'lblClienteHasta
        '
        Me.lblClienteHasta.Location = New System.Drawing.Point(6, 107)
        Me.lblClienteHasta.Name = "lblClienteHasta"
        Me.lblClienteHasta.Size = New System.Drawing.Size(63, 13)
        Me.lblClienteHasta.TabIndex = 85
        Me.lblClienteHasta.Tag = ""
        Me.lblClienteHasta.Text = "Cliente H."
        '
        'AdvClienteHasta
        '
        Me.AdvClienteHasta.DisabledBackColor = System.Drawing.Color.White
        Me.AdvClienteHasta.EntityName = "Cliente"
        Me.AdvClienteHasta.Location = New System.Drawing.Point(82, 101)
        Me.AdvClienteHasta.Name = "AdvClienteHasta"
        Me.AdvClienteHasta.PrimaryDataFields = "IDCliente"
        Me.AdvClienteHasta.SecondaryDataFields = "IDCliente"
        Me.AdvClienteHasta.Size = New System.Drawing.Size(99, 23)
        Me.AdvClienteHasta.TabIndex = 3
        Me.AdvClienteHasta.ViewName = "tbMaestroCliente"
        '
        'lblClienteDesde
        '
        Me.lblClienteDesde.Location = New System.Drawing.Point(6, 78)
        Me.lblClienteDesde.Name = "lblClienteDesde"
        Me.lblClienteDesde.Size = New System.Drawing.Size(64, 13)
        Me.lblClienteDesde.TabIndex = 88
        Me.lblClienteDesde.Tag = ""
        Me.lblClienteDesde.Text = "Cliente D."
        '
        'AdvClienteDesde
        '
        Me.AdvClienteDesde.DisabledBackColor = System.Drawing.Color.White
        Me.AdvClienteDesde.EntityName = "Cliente"
        Me.AdvClienteDesde.Location = New System.Drawing.Point(82, 75)
        Me.AdvClienteDesde.Name = "AdvClienteDesde"
        Me.AdvClienteDesde.PrimaryDataFields = "IDCliente"
        Me.AdvClienteDesde.SecondaryDataFields = "IDCliente"
        Me.AdvClienteDesde.Size = New System.Drawing.Size(99, 23)
        Me.AdvClienteDesde.TabIndex = 2
        Me.AdvClienteDesde.ViewName = "tbMaestroCliente"
        '
        'AdvObraHasta
        '
        Me.AdvObraHasta.DisabledBackColor = System.Drawing.Color.White
        Me.AdvObraHasta.DisplayField = "NObra"
        Me.AdvObraHasta.EntityName = "ObraCabecera"
        Me.AdvObraHasta.Location = New System.Drawing.Point(82, 49)
        Me.AdvObraHasta.Name = "AdvObraHasta"
        Me.AdvObraHasta.SecondaryDataFields = "IDObra"
        Me.AdvObraHasta.Size = New System.Drawing.Size(100, 23)
        Me.AdvObraHasta.TabIndex = 1
        Me.AdvObraHasta.ViewName = "tbObraCabecera"
        '
        'lblTipoTrabajo
        '
        Me.lblTipoTrabajo.Location = New System.Drawing.Point(208, 53)
        Me.lblTipoTrabajo.Name = "lblTipoTrabajo"
        Me.lblTipoTrabajo.Size = New System.Drawing.Size(31, 13)
        Me.lblTipoTrabajo.TabIndex = 79
        Me.lblTipoTrabajo.Tag = ""
        Me.lblTipoTrabajo.Text = "Tipo"
        '
        'AdvTipoTrabajo
        '
        Me.AdvTipoTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvTipoTrabajo.EntityName = "ObraTipoTrabajo"
        Me.AdvTipoTrabajo.Location = New System.Drawing.Point(275, 49)
        Me.AdvTipoTrabajo.Name = "AdvTipoTrabajo"
        Me.AdvTipoTrabajo.SecondaryDataFields = "IDTipoTrabajo"
        Me.AdvTipoTrabajo.Size = New System.Drawing.Size(99, 23)
        Me.AdvTipoTrabajo.TabIndex = 5
        Me.AdvTipoTrabajo.ViewName = "tbObraTipoTrabajo"
        '
        'lblSubTipoTrabajo
        '
        Me.lblSubTipoTrabajo.Location = New System.Drawing.Point(208, 79)
        Me.lblSubTipoTrabajo.Name = "lblSubTipoTrabajo"
        Me.lblSubTipoTrabajo.Size = New System.Drawing.Size(53, 13)
        Me.lblSubTipoTrabajo.TabIndex = 81
        Me.lblSubTipoTrabajo.Tag = ""
        Me.lblSubTipoTrabajo.Text = "SubTipo"
        '
        'AdvSubTipoTrabajo
        '
        Me.AdvSubTipoTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvSubTipoTrabajo.EntityName = "ObraSubtipoTrabajo"
        Me.AdvSubTipoTrabajo.Location = New System.Drawing.Point(275, 75)
        Me.AdvSubTipoTrabajo.Name = "AdvSubTipoTrabajo"
        Me.AdvSubTipoTrabajo.SecondaryDataFields = "IDSubtipoTrabajo"
        Me.AdvSubTipoTrabajo.Size = New System.Drawing.Size(99, 23)
        Me.AdvSubTipoTrabajo.TabIndex = 6
        Me.AdvSubTipoTrabajo.ViewName = "tbObraSubtipoTrabajo"
        '
        'AdvTrabajo
        '
        Me.AdvTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvTrabajo.DisplayField = "CodTrabajo"
        Me.AdvTrabajo.EntityName = "ObraTrabajo"
        Me.AdvTrabajo.Location = New System.Drawing.Point(275, 23)
        Me.AdvTrabajo.Name = "AdvTrabajo"
        Me.AdvTrabajo.SecondaryDataFields = "IDTrabajo"
        Me.AdvTrabajo.Size = New System.Drawing.Size(99, 23)
        Me.AdvTrabajo.TabIndex = 4
        Me.AdvTrabajo.ViewName = "tbObraTrabajo"
        '
        'lblObraDesde
        '
        Me.lblObraDesde.Location = New System.Drawing.Point(6, 28)
        Me.lblObraDesde.Name = "lblObraDesde"
        Me.lblObraDesde.Size = New System.Drawing.Size(74, 13)
        Me.lblObraDesde.TabIndex = 83
        Me.lblObraDesde.Tag = ""
        Me.lblObraDesde.Text = "Proyecto D."
        '
        'AdvObraDesde
        '
        Me.AdvObraDesde.DisabledBackColor = System.Drawing.Color.White
        Me.AdvObraDesde.DisplayField = "NObra"
        Me.AdvObraDesde.EntityName = "ObraCabecera"
        Me.AdvObraDesde.Location = New System.Drawing.Point(82, 23)
        Me.AdvObraDesde.Name = "AdvObraDesde"
        Me.AdvObraDesde.SecondaryDataFields = "IDObra"
        Me.AdvObraDesde.Size = New System.Drawing.Size(99, 23)
        Me.AdvObraDesde.TabIndex = 0
        Me.AdvObraDesde.ViewName = "tbObraCabecera"
        '
        'lblObraHasta
        '
        Me.lblObraHasta.Location = New System.Drawing.Point(6, 54)
        Me.lblObraHasta.Name = "lblObraHasta"
        Me.lblObraHasta.Size = New System.Drawing.Size(73, 13)
        Me.lblObraHasta.TabIndex = 84
        Me.lblObraHasta.Tag = ""
        Me.lblObraHasta.Text = "Proyecto H."
        '
        'ShowFilterPanel
        '
        Me.ShowFilterPanel.Icon = CType(resources.GetObject("ShowFilterPanel.Icon"), System.Drawing.Icon)
        Me.ShowFilterPanel.Key = "ShowFilterPanel"
        Me.ShowFilterPanel.Name = "ShowFilterPanel"
        Me.ShowFilterPanel.Text = "Ver Criterios"
        '
        'ShowFilterPanel1
        '
        Me.ShowFilterPanel1.Key = "ShowFilterPanel"
        Me.ShowFilterPanel1.Name = "ShowFilterPanel1"
        '
        'pnlTotales
        '
        Me.pnlTotales.Controls.Add(Me.txtTotalMarcado)
        Me.pnlTotales.Controls.Add(Me.txtTotal)
        Me.pnlTotales.Controls.Add(Me.lblTotalReal)
        Me.pnlTotales.Controls.Add(Me.lblTotalMarcado)
        Me.pnlTotales.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlTotales.Location = New System.Drawing.Point(0, 331)
        Me.pnlTotales.Name = "pnlTotales"
        Me.pnlTotales.Size = New System.Drawing.Size(775, 29)
        Me.pnlTotales.TabIndex = 24
        '
        'txtTotalMarcado
        '
        Me.txtTotalMarcado.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotalMarcado.Enabled = False
        Me.txtTotalMarcado.Location = New System.Drawing.Point(525, 6)
        Me.txtTotalMarcado.Name = "txtTotalMarcado"
        Me.txtTotalMarcado.Size = New System.Drawing.Size(98, 21)
        Me.txtTotalMarcado.TabIndex = 105
        '
        'txtTotal
        '
        Me.txtTotal.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(670, 6)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(98, 21)
        Me.txtTotal.TabIndex = 104
        '
        'lblTotalReal
        '
        Me.lblTotalReal.AutoSize = False
        Me.lblTotalReal.Location = New System.Drawing.Point(626, 8)
        Me.lblTotalReal.Name = "lblTotalReal"
        Me.lblTotalReal.Size = New System.Drawing.Size(39, 17)
        Me.lblTotalReal.TabIndex = 103
        Me.lblTotalReal.Text = "Total"
        Me.lblTotalReal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalMarcado
        '
        Me.lblTotalMarcado.AutoSize = False
        Me.lblTotalMarcado.Location = New System.Drawing.Point(421, 8)
        Me.lblTotalMarcado.Name = "lblTotalMarcado"
        Me.lblTotalMarcado.Size = New System.Drawing.Size(98, 17)
        Me.lblTotalMarcado.TabIndex = 102
        Me.lblTotalMarcado.Text = "Total Marcado"
        Me.lblTotalMarcado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.pnlConfigFacturacion)
        Me.Panel1.Controls.Add(Me.pnlFechaVto)
        Me.Panel1.Controls.Add(Me.cbxAño)
        Me.Panel1.Controls.Add(Me.lblAño)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(775, 37)
        Me.Panel1.TabIndex = 26
        '
        'pnlConfigFacturacion
        '
        Me.pnlConfigFacturacion.Controls.Add(Me.lblTipoAgrupacion)
        Me.pnlConfigFacturacion.Controls.Add(Me.cbxTipoAgrupacion)
        Me.pnlConfigFacturacion.Controls.Add(Me.chkCondicionesCliente)
        Me.pnlConfigFacturacion.Controls.Add(Me.lblContador)
        Me.pnlConfigFacturacion.Controls.Add(Me.AdvContador)
        Me.pnlConfigFacturacion.Location = New System.Drawing.Point(0, 0)
        Me.pnlConfigFacturacion.Name = "pnlConfigFacturacion"
        Me.pnlConfigFacturacion.Size = New System.Drawing.Size(633, 36)
        Me.pnlConfigFacturacion.TabIndex = 129
        '
        'lblTipoAgrupacion
        '
        Me.lblTipoAgrupacion.Location = New System.Drawing.Point(299, 12)
        Me.lblTipoAgrupacion.Name = "lblTipoAgrupacion"
        Me.lblTipoAgrupacion.Size = New System.Drawing.Size(71, 13)
        Me.lblTipoAgrupacion.TabIndex = 114
        Me.lblTipoAgrupacion.Tag = ""
        Me.lblTipoAgrupacion.Text = "Agrupación"
        '
        'cbxTipoAgrupacion
        '
        Me.TryDataBinding(cbxTipoAgrupacion, New System.Windows.Forms.Binding("Value", Me, "AgrupFacturaObra", True))
        cbxTipoAgrupacion_DesignTimeLayout.LayoutString = resources.GetString("cbxTipoAgrupacion_DesignTimeLayout.LayoutString")
        Me.cbxTipoAgrupacion.DesignTimeLayout = cbxTipoAgrupacion_DesignTimeLayout
        Me.cbxTipoAgrupacion.DisabledBackColor = System.Drawing.Color.White
        Me.cbxTipoAgrupacion.Enabled = False
        Me.cbxTipoAgrupacion.Location = New System.Drawing.Point(372, 8)
        Me.cbxTipoAgrupacion.Name = "cbxTipoAgrupacion"
        Me.cbxTipoAgrupacion.SelectedIndex = -1
        Me.cbxTipoAgrupacion.SelectedItem = Nothing
        Me.cbxTipoAgrupacion.Size = New System.Drawing.Size(148, 21)
        Me.cbxTipoAgrupacion.TabIndex = 2
        '
        'chkCondicionesCliente
        '
        Me.chkCondicionesCliente.AutoSize = True
        Me.chkCondicionesCliente.Location = New System.Drawing.Point(159, 10)
        Me.chkCondicionesCliente.Name = "chkCondicionesCliente"
        Me.chkCondicionesCliente.Size = New System.Drawing.Size(134, 18)
        Me.chkCondicionesCliente.TabIndex = 1
        Me.chkCondicionesCliente.Text = "Condiciones Cliente"
        '
        'lblContador
        '
        Me.lblContador.Location = New System.Drawing.Point(8, 12)
        Me.lblContador.Name = "lblContador"
        Me.lblContador.Size = New System.Drawing.Size(60, 13)
        Me.lblContador.TabIndex = 107
        Me.lblContador.Tag = "IdRec=4809;"
        Me.lblContador.Text = "Contador"
        '
        'AdvContador
        '
        Me.AdvContador.DisabledBackColor = System.Drawing.Color.White
        Me.AdvContador.EntityName = "EntidadContador"
        Me.AdvContador.Location = New System.Drawing.Point(72, 8)
        Me.AdvContador.Name = "AdvContador"
        Me.AdvContador.PrimaryDataFields = "IDContador"
        Me.AdvContador.SecondaryDataFields = "IDContador"
        Me.AdvContador.Size = New System.Drawing.Size(81, 23)
        Me.AdvContador.TabIndex = 0
        Me.AdvContador.ViewName = "tbEntidadContador"
        '
        'pnlFechaVto
        '
        Me.pnlFechaVto.AccessibleDescription = ""
        Me.pnlFechaVto.Controls.Add(Me.lblFechaVto)
        Me.pnlFechaVto.Controls.Add(Me.cbxFechaVto)
        Me.pnlFechaVto.Location = New System.Drawing.Point(0, 0)
        Me.pnlFechaVto.Name = "pnlFechaVto"
        Me.pnlFechaVto.Size = New System.Drawing.Size(182, 40)
        Me.pnlFechaVto.TabIndex = 126
        '
        'lblFechaVto
        '
        Me.lblFechaVto.Location = New System.Drawing.Point(8, 8)
        Me.lblFechaVto.Name = "lblFechaVto"
        Me.lblFechaVto.Size = New System.Drawing.Size(67, 13)
        Me.lblFechaVto.TabIndex = 130
        Me.lblFechaVto.Tag = "IdRec=4803;"
        Me.lblFechaVto.Text = "Fecha Vto."
        '
        'cbxFechaVto
        '
        Me.cbxFechaVto.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaVto.Location = New System.Drawing.Point(72, 8)
        Me.cbxFechaVto.Name = "cbxFechaVto"
        Me.cbxFechaVto.Size = New System.Drawing.Size(100, 21)
        Me.cbxFechaVto.TabIndex = 129
        '
        'cbxAño
        '
        Me.cbxAño.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList
        cbxAño_DesignTimeLayout.LayoutString = resources.GetString("cbxAño_DesignTimeLayout.LayoutString")
        Me.cbxAño.DesignTimeLayout = cbxAño_DesignTimeLayout
        Me.cbxAño.DisabledBackColor = System.Drawing.Color.White
        Me.cbxAño.DisplayMember = "Año"
        Me.cbxAño.Location = New System.Drawing.Point(675, 10)
        Me.cbxAño.MaxLength = 4
        Me.cbxAño.Name = "cbxAño"
        Me.cbxAño.SelectedIndex = -1
        Me.cbxAño.SelectedItem = Nothing
        Me.cbxAño.Size = New System.Drawing.Size(87, 21)
        Me.cbxAño.TabIndex = 9
        Me.cbxAño.ValueMember = "Año"
        '
        'lblAño
        '
        Me.lblAño.Location = New System.Drawing.Point(638, 12)
        Me.lblAño.Name = "lblAño"
        Me.lblAño.Size = New System.Drawing.Size(29, 13)
        Me.lblAño.TabIndex = 102
        Me.lblAño.Tag = ""
        Me.lblAño.Text = "Año"
        '
        'TabFacturacion
        '
        Me.TabFacturacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.TabFacturacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabFacturacion.Location = New System.Drawing.Point(0, 37)
        Me.TabFacturacion.Name = "TabFacturacion"
        Me.TabFacturacion.Size = New System.Drawing.Size(775, 294)
        Me.TabFacturacion.TabIndex = 27
        Me.TabFacturacion.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.TabPageHitos, Me.TabPageHoras, Me.TabPageGastos, Me.TabPageMateriales, Me.TabPageCertificacion, Me.TabPageTaller})
        Me.TabFacturacion.Text = "Varios"
        Me.TabFacturacion.TextOrientation = Janus.Windows.UI.Tab.TextOrientation.Horizontal
        Me.TabFacturacion.UseThemes = True
        '
        'TabPageHitos
        '
        Me.TabPageHitos.Controls.Add(Me.GridVtos)
        Me.TabPageHitos.Key = "Hitos"
        Me.TabPageHitos.Location = New System.Drawing.Point(1, 21)
        Me.TabPageHitos.Name = "TabPageHitos"
        Me.TabPageHitos.Size = New System.Drawing.Size(773, 272)
        Me.TabPageHitos.TabStop = True
        Me.TabPageHitos.Text = "Hitos"
        '
        'GridVtos
        '
        Me.GridVtos.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridVtos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridVtos_DesignTimeLayout.LayoutString = resources.GetString("GridVtos_DesignTimeLayout.LayoutString")
        Me.GridVtos.DesignTimeLayout = GridVtos_DesignTimeLayout
        Me.GridVtos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridVtos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridVtos.EntityName = "ObraTrabajoFacturacion"
        Me.GridVtos.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridVtos.FrozenColumns = 5
        Me.GridVtos.ImageList = Me.ImageList1
        Me.GridVtos.KeyField = "IDVencimiento"
        Me.GridVtos.Location = New System.Drawing.Point(0, 0)
        Me.GridVtos.Name = "GridVtos"
        Me.GridVtos.PrimaryDataFields = Nothing
        Me.GridVtos.RequeryManually = True
        Me.GridVtos.SecondaryDataFields = Nothing
        Me.GridVtos.Size = New System.Drawing.Size(773, 272)
        Me.GridVtos.TabIndex = 0
        Me.GridVtos.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridVtos.UseCheck = True
        Me.GridVtos.ViewName = "VFrmCIObraFacturacion"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "folder_edit.ico")
        '
        'TabPageHoras
        '
        Me.TabPageHoras.Controls.Add(Me.GridMod)
        Me.TabPageHoras.Key = "Horas"
        Me.TabPageHoras.Location = New System.Drawing.Point(1, 21)
        Me.TabPageHoras.Name = "TabPageHoras"
        Me.TabPageHoras.Size = New System.Drawing.Size(773, 272)
        Me.TabPageHoras.TabStop = True
        Me.TabPageHoras.Text = "Horas"
        Me.TabPageHoras.Visible = False
        '
        'GridMod
        '
        Me.GridMod.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDCliente", "Cliente", "IDCliente", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescCliente", "DescCliente")}))})
        Me.GridMod.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridMod.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridMod_DesignTimeLayout.LayoutString = resources.GetString("GridMod_DesignTimeLayout.LayoutString")
        Me.GridMod.DesignTimeLayout = GridMod_DesignTimeLayout
        Me.GridMod.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridMod.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridMod.EntityName = "ObraMODControl"
        Me.GridMod.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridMod.KeyField = "IDLineaModControl"
        Me.GridMod.Location = New System.Drawing.Point(0, 0)
        Me.GridMod.Name = "GridMod"
        Me.GridMod.PrimaryDataFields = Nothing
        Me.GridMod.RequeryManually = True
        Me.GridMod.SecondaryDataFields = Nothing
        Me.GridMod.Size = New System.Drawing.Size(773, 272)
        Me.GridMod.TabIndex = 2
        Me.GridMod.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridMod.UseCheck = True
        Me.GridMod.ViewName = "VFrmCIObraFacturacionMODControl"
        '
        'TabPageGastos
        '
        Me.TabPageGastos.Controls.Add(Me.GridGastos)
        Me.TabPageGastos.Key = "Gastos"
        Me.TabPageGastos.Location = New System.Drawing.Point(1, 21)
        Me.TabPageGastos.Name = "TabPageGastos"
        Me.TabPageGastos.Size = New System.Drawing.Size(773, 272)
        Me.TabPageGastos.TabStop = True
        Me.TabPageGastos.Text = "Gastos"
        Me.TabPageGastos.Visible = False
        '
        'GridGastos
        '
        Me.GridGastos.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDCliente", "Cliente", "IDCliente", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescCliente", "DescCliente")}))})
        Me.GridGastos.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridGastos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridGastos_DesignTimeLayout.LayoutString = resources.GetString("GridGastos_DesignTimeLayout.LayoutString")
        Me.GridGastos.DesignTimeLayout = GridGastos_DesignTimeLayout
        Me.GridGastos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridGastos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridGastos.EntityName = "ObraGastoControl"
        Me.GridGastos.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridGastos.KeyField = "IDLineaGastoControl"
        Me.GridGastos.Location = New System.Drawing.Point(0, 0)
        Me.GridGastos.Name = "GridGastos"
        Me.GridGastos.PrimaryDataFields = Nothing
        Me.GridGastos.RequeryManually = True
        Me.GridGastos.SecondaryDataFields = Nothing
        Me.GridGastos.Size = New System.Drawing.Size(773, 272)
        Me.GridGastos.TabIndex = 2
        Me.GridGastos.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridGastos.UseCheck = True
        Me.GridGastos.ViewName = "VFrmCIObraFacturacionGastoControl"
        '
        'TabPageMateriales
        '
        Me.TabPageMateriales.Controls.Add(Me.GridMateriales)
        Me.TabPageMateriales.Key = "Materiales"
        Me.TabPageMateriales.Location = New System.Drawing.Point(1, 21)
        Me.TabPageMateriales.Name = "TabPageMateriales"
        Me.TabPageMateriales.Size = New System.Drawing.Size(773, 272)
        Me.TabPageMateriales.TabStop = True
        Me.TabPageMateriales.Text = "Materiales"
        '
        'GridMateriales
        '
        Me.GridMateriales.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridMateriales.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridMateriales_DesignTimeLayout.LayoutString = resources.GetString("GridMateriales_DesignTimeLayout.LayoutString")
        Me.GridMateriales.DesignTimeLayout = GridMateriales_DesignTimeLayout
        Me.GridMateriales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridMateriales.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridMateriales.EntityName = "ObraMaterialControl"
        Me.GridMateriales.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridMateriales.KeyField = "IDLineaMaterialControl"
        Me.GridMateriales.Location = New System.Drawing.Point(0, 0)
        Me.GridMateriales.Name = "GridMateriales"
        Me.GridMateriales.PrimaryDataFields = Nothing
        Me.GridMateriales.RequeryManually = True
        Me.GridMateriales.SecondaryDataFields = Nothing
        Me.GridMateriales.Size = New System.Drawing.Size(773, 272)
        Me.GridMateriales.TabIndex = 0
        Me.GridMateriales.UseCheck = True
        Me.GridMateriales.ViewName = "VFrmCIObraFacturacionMaterialControl"
        '
        'TabPageCertificacion
        '
        Me.TabPageCertificacion.Controls.Add(Me.GridCertificacion)
        Me.TabPageCertificacion.Key = "Certificacion"
        Me.TabPageCertificacion.Location = New System.Drawing.Point(1, 21)
        Me.TabPageCertificacion.Name = "TabPageCertificacion"
        Me.TabPageCertificacion.Size = New System.Drawing.Size(773, 272)
        Me.TabPageCertificacion.TabStop = True
        Me.TabPageCertificacion.Text = "Certificación"
        Me.TabPageCertificacion.Visible = False
        '
        'GridCertificacion
        '
        Me.GridCertificacion.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridCertificacion.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridCertificacion.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridCertificacion_DesignTimeLayout.LayoutString = resources.GetString("GridCertificacion_DesignTimeLayout.LayoutString")
        Me.GridCertificacion.DesignTimeLayout = GridCertificacion_DesignTimeLayout
        Me.GridCertificacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridCertificacion.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridCertificacion.EntityName = "ObraTrabajo"
        Me.GridCertificacion.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridCertificacion.KeyField = "IDTrabajo;IDCertificacion"
        Me.GridCertificacion.Location = New System.Drawing.Point(0, 0)
        Me.GridCertificacion.Name = "GridCertificacion"
        Me.GridCertificacion.PrimaryDataFields = Nothing
        Me.GridCertificacion.RequeryManually = True
        Me.GridCertificacion.SecondaryDataFields = ""
        Me.GridCertificacion.Size = New System.Drawing.Size(773, 272)
        Me.GridCertificacion.TabIndex = 2
        Me.GridCertificacion.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridCertificacion.UseCheck = True
        Me.GridCertificacion.ViewName = "VFrmCIObraFacturacionCertificacion"
        '
        'TabPageTaller
        '
        Me.TabPageTaller.Controls.Add(Me.GridTaller)
        Me.TabPageTaller.Key = "Taller"
        Me.TabPageTaller.Location = New System.Drawing.Point(1, 21)
        Me.TabPageTaller.Name = "TabPageTaller"
        Me.TabPageTaller.Size = New System.Drawing.Size(773, 272)
        Me.TabPageTaller.TabStop = True
        Me.TabPageTaller.Text = "Taller"
        '
        'GridTaller
        '
        Me.GridTaller.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridTaller.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridTaller.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridTaller_DesignTimeLayout.LayoutString = resources.GetString("GridTaller_DesignTimeLayout.LayoutString")
        Me.GridTaller.DesignTimeLayout = GridTaller_DesignTimeLayout
        Me.GridTaller.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridTaller.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridTaller.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridTaller.EntityName = "MntoOTControlLinea"
        Me.GridTaller.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridTaller.KeyField = "IDMntoOTControl"
        Me.GridTaller.Location = New System.Drawing.Point(0, 0)
        Me.GridTaller.Name = "GridTaller"
        Me.GridTaller.PrimaryDataFields = Nothing
        Me.GridTaller.RequeryManually = True
        Me.GridTaller.SecondaryDataFields = Nothing
        Me.GridTaller.Size = New System.Drawing.Size(773, 272)
        Me.GridTaller.TabIndex = 2
        Me.GridTaller.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridTaller.UseCheck = True
        Me.GridTaller.ViewName = "vAlquilerCIObraFacturacionOT"
        '
        'CIFacturacion
        '
        Me.AllowUpdate = True
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(783, 577)
        Me.EntityName = "ObraMODControl"
        Me.Name = "CIFacturacion"
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        Me.pnlCriteriosSeleccion.ResumeLayout(False)
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.pnlOperario.ResumeLayout(False)
        Me.pnlOperario.PerformLayout()
        Me.pnlEstadoCertificacion.ResumeLayout(False)
        Me.pnlEstadoCertificacion.PerformLayout()
        CType(Me.cbxEstadoCertificacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTipoFactura.ResumeLayout(False)
        Me.pnlTipoFactura.PerformLayout()
        CType(Me.cbxTipoFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlEstado.ResumeLayout(False)
        Me.pnlEstado.PerformLayout()
        CType(Me.cbxEstado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxAgrupFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTotales.ResumeLayout(False)
        Me.pnlTotales.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlConfigFacturacion.ResumeLayout(False)
        Me.pnlConfigFacturacion.PerformLayout()
        CType(Me.cbxTipoAgrupacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFechaVto.ResumeLayout(False)
        Me.pnlFechaVto.PerformLayout()
        CType(Me.cbxAño, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabFacturacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabFacturacion.ResumeLayout(False)
        Me.TabPageHitos.ResumeLayout(False)
        CType(Me.GridVtos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageHoras.ResumeLayout(False)
        CType(Me.GridMod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageGastos.ResumeLayout(False)
        CType(Me.GridGastos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageMateriales.ResumeLayout(False)
        CType(Me.GridMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageCertificacion.ResumeLayout(False)
        CType(Me.GridCertificacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageTaller.ResumeLayout(False)
        CType(Me.GridTaller, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Const cnFACTURACION As String = "Facturación"
    Public Const cnFACTURACIONRESPONSABLE As String = "Consulta de Facturación por Responsable"
    Public Const cnGENERARVTOS As String = "Generar Vencimientos"
    Public Const cnDELETEVTOS As String = "Borrar Vencimientos"

    Private Const cnABRIRFACTURA As String = "Abrir Factura Venta"
    Private Const cnFACTURASGENERADAS As String = "Ver Facturas Generadas"
    Private Const cnDELETEMOD As String = "Borrar Vencimiento Horas MOD"
    Private Const cnDELETEGASTO As String = "Borrar Vencimiento Gasto"
    Private Const cnDELETEMATERIAL As String = "Borrar Vencimiento Material"

    Private mblnGestionConstructoras, mblnTienePermisosFacturacion As Boolean
    Private mIDMaterial, mIDOT, mIDOTHitos, mIDVencimiento As Integer
    Private mintIDTrabajo As Integer

#Region " Load "

    Private Sub CIFacturacion_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        ConfigureLocationControls()
    End Sub

    Private Sub CIFacturacion_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        ConfigureLocationControls()
    End Sub

    Private Sub CIFacturacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            LoadERPData()
            LoadEnums()
            LoadToolBarActions()
            LoadGridActions()
            LoadDefaultQueryExecuting()
            ConfigureLocationControls()
            If mblnGestionConstructoras Then
                TabFacturacion.TabPages("Certificacion").Selected = True
                ActivateControls()
            End If
            LoadParams()
        End If
    End Sub

    Private Sub LoadParams()
        If Not IsNothing(Me.Params) Then
            If Me.ProgramInfo.Alias = "FACTOBRAS" Then
                Dim ht As Hashtable = Me.Params
                AdvClienteDesde.Text = ht("IDCliente")
                AdvClienteHasta.Text = ht("IDCliente")
                AdvObraDesde.Value = ht("IDObra")
                AdvObraDesde.Text = ht("NObra")
                AdvObraHasta.Value = ht("IDObra")
                AdvObraHasta.Text = ht("NObra")
                AdvTrabajo.Value = ht("IDTrabajo")
                AdvTrabajo.Text = ht("CodTrabajo")

                Me.Execute()
            End If
        End If
    End Sub

    Private Sub LoadERPData()
        mblnGestionConstructoras = New Parametro().GestionConstructoras
        PermisoFacturacionUsuario()
        'AdvContador.Text = LoadContadorPorDefecto()

        RellenarComboAños(cbxAño)
    End Sub

    'Public Function LoadContadorPorDefecto() As String
    '    Dim StDatos As Contador.DefaultCounter = ExpertisApp.ExecuteTask(Of String, Contador.DefaultCounter)(AddressOf Contador.GetDefaultCounterValue, "FacturaVentaCabecera")
    '    Return StDatos.CounterID
    'End Function

    Private Sub LoadEnums()
        cbxEstado.DataSource = New EnumData("enumotfEstadoCIVtos")
        cbxEstadoCertificacion.DataSource = New EnumData("enumEstadoCertificacion")
        cbxTipoFactura.DataSource = New EnumData("enumotfTipoFactura")
        cbxAgrupFactura.DataSource = New EnumData("enummcAgrupFacturaObra")
        cbxTipoAgrupacion.DataSource = New EnumData("enummcAgrupFacturaObra")

        EnumData.PopulateValueList("enumotfTipoFactura", GridVtos.Columns("TipoFactura"))
        EnumData.PopulateValueList("enumEstadoCertificacion", GridCertificacion.Columns("Estado"))
    End Sub

    Private Sub LoadToolBarActions()
        Me.FormActions.Add(cnFACTURACION, AddressOf Facturacion, ExpertisApp.GetIcon("xFacturacionProyectos.ico"))
        Me.FormActions.Add(cnFACTURACIONRESPONSABLE, AddressOf VerFacturacionResponsable, ExpertisApp.GetIcon("xEstadistica.ico"))
        Me.AddSeparator()
        Me.FormActions.Add(cnGENERARVTOS, AddressOf GeneraHitosFacturacion, ExpertisApp.GetIcon("clock_run.ico"))
        Me.AddSeparator()
        Me.FormActions.Add(cnDELETEVTOS, AddressOf DeleteHitosFacturacion, ExpertisApp.GetIcon("garbage.ico"))
    End Sub

    Private Sub LoadGridActions()
        LoadGridVtosActions1()
        LoadGridVtosActions2()
        LoadGridCertificacionActions()
    End Sub

    Protected Overridable Sub LoadGridVtosActions1()
        GridVtos.Actions.Add("Abrir Proyecto", AddressOf VerObras, ExpertisApp.GetIcon("xProyectos.ico"))
    End Sub

    Private Sub LoadGridVtosActions2()
        GridVtos.Actions.Add(cnABRIRFACTURA, AddressOf VerFacturasVta, ExpertisApp.GetIcon("xFacturaVenta.ico"))
        GridVtos.Actions.Add(cnDELETEMOD, AddressOf BorrarVtosMODGastoMaterial, ExpertisApp.GetIcon("garbage.ico"))
        GridVtos.Actions.Add(cnDELETEGASTO, AddressOf BorrarVtosMODGastoMaterial, ExpertisApp.GetIcon("garbage.ico"))
        GridVtos.Actions.Add(cnDELETEMATERIAL, AddressOf BorrarVtosMODGastoMaterial, ExpertisApp.GetIcon("garbage.ico"))
    End Sub

    Private Sub LoadGridCertificacionActions()
        GridCertificacion.Actions.Add("Abrir Proyecto", AddressOf VerObras, ExpertisApp.GetIcon("xProyectos.ico"))
        GridCertificacion.Actions.Add(cnFACTURASGENERADAS, AddressOf VerFacturasGeneradas, ExpertisApp.GetIcon("xFacturaVenta.ico"))
    End Sub

    Private Sub ConfigureLocationControls()
        chkCondicionesCliente.Checked = True
        pnlEstadoCertificacion.Location = pnlEstado.Location
        pnlOperario.Location = pnlTipoFactura.Location
        lblCodTrabajo.Top = AdvTrabajo.Top
    End Sub

    Private Sub LoadDefaultQueryExecuting()
        cbxEstado.Value = CInt(enumotfEstadoCIVtos.otfvNoFacturado)
        cbxEstadoCertificacion.Value = CInt(enumEstadoCertificacion.ecAceptada)
    End Sub

    Private Sub PermisoFacturacionUsuario()
        Dim o As Operario.DatosOperario = ExpertisApp.ExecuteTask(Of Object, Operario.DatosOperario)(AddressOf Operario.ObtenerOperarioUsuario, New Object)
        mblnTienePermisosFacturacion = o.FacturacionObras
    End Sub

#End Region

#Region " Acciones ToolBar "

#Region " Facturacion "

    Protected Overridable Sub Facturacion()
        Dim tf As enumTipoFactura
        Dim Grid As Solmicro.Expertis.Engine.UI.Grid = Nothing
        Dim strMsg As String = ExpertisApp.Traslate("El Cliente y el Artículo son datos necesarios para el proceso de Facturación. Aquellas líneas que no tengan estos datos, estén facturadas o no tengan Fecha Vencimiento no serán incluidos en dicho proceso.")

        If TabFacturacion.SelectedTab.Key = "Hitos" Then
            tf = enumTipoFactura.tfObra
            Grid = GridVtos
        ElseIf TabFacturacion.SelectedTab.Key = "Certificacion" Then
            tf = enumTipoFactura.tfCertificacion
            Grid = GridCertificacion
            strMsg = ExpertisApp.Traslate("El Cliente y el Artículo son datos necesarios para el proceso de Facturación. Aquellas líneas que no tengan estos datos, estén pendientes o facturadas o no tengan Fecha Vencimiento no serán incluidos en dicho proceso.")
        End If

        If Not Grid Is Nothing AndAlso Grid.CheckedRecordsCount > 0 Then
            If Not chkCondicionesCliente.Checked And Length(cbxTipoAgrupacion.Value) = 0 Then
                ExpertisApp.GenerateMessage("Para poder facturar hay que seleccionar las Condiciones del Cliente o un tipo de agrupación.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            Else
                Dim dtMarcados As DataTable = Grid.CheckedRecords
                If Not IsNothing(dtMarcados) AndAlso dtMarcados.Rows.Count > 0 Then
                    If ExpertisApp.GenerateMessage(strMsg, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                        dtMarcados = TratarLineaAFacturar(dtMarcados)
                        If Not IsNothing(dtMarcados) AndAlso dtMarcados.Rows.Count > 0 Then
                            Dim intTipoAgrupacion As Integer = IIf(Length(cbxTipoAgrupacion.Value) > 0, cbxTipoAgrupacion.Value, -1)

                            Dim DE As New BE.DataEngine
                            Dim IDVencimientos() As Object = VencimientosAFacturar(dtMarcados)
                            Dim datos As New DataPrcFacturacionObras(IDVencimientos, AdvContador.Text, intTipoAgrupacion, tf)
                            Dim Propuesta As ResultFacturacion = DE.RunProcess(GetType(PrcFacturacionObras), datos)
                            If Not IsNothing(Propuesta) Then
                                If Not Propuesta.PropuestaFacturas Is Nothing AndAlso Propuesta.PropuestaFacturas.Rows.Count > 0 Then
                                    Dim frm As New frmFacturacionProvisional
                                    Dim d As DialogResult = frm.AbrirFormulario(Propuesta.PropuestaFacturas)
                                    If d = DialogResult.OK Then
                                        Me.Cursor = Cursors.WaitCursor

                                        Dim datosAct As New DataPrcActualizarFactura(Propuesta, tf)
                                        Dim rslt As ResultFacturacion = DE.RunProcess(GetType(PrcActualizarFactura), datosAct)
                                        TratarLog(rslt.Log, enumTipoDocumentoCreado.FacturaVenta, True, True)

                                        Me.Cursor = Cursors.Default
                                    Else
                                        ExpertisApp.GenerateMessage("Proceso cancelado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    End If
                                Else
                                    TratarLog(Propuesta.Log, enumTipoDocumentoCreado.FacturaVenta, True, True)
                                End If
                                Grid.UnCheckAllRecords()
                                Me.Execute()
                            Else
                                ExpertisApp.GenerateMessage("No se ha podido generar la Factura.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            End If
                        End If
                    End If
                End If
            End If
        Else
            ExpertisApp.GenerateMessage("No se han seleccionado líneas.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Public Function VencimientosAFacturar(ByVal dtMarcados As DataTable) As Object()
        If Not dtMarcados Is Nothing AndAlso dtMarcados.Rows.Count > 0 Then
            Dim IDVenc(-1) As Object
            Dim StrField As String = String.Empty
            If TabFacturacion.SelectedTab.Key = "Hitos" Then
                StrField = "IDVencimiento"
            ElseIf TabFacturacion.SelectedTab.Key = "Certificacion" Then
                StrField = "IDCertificacion"
            End If
            For Each drMarcados As DataRow In dtMarcados.Select
                ReDim Preserve IDVenc(UBound(IDVenc) + 1)
                IDVenc(UBound(IDVenc)) = drMarcados(StrField)
            Next
            Return IDVenc
        End If
        Return Nothing
    End Function

    Public Function TratarLineaAFacturar(ByVal dtMarcados As DataTable) As DataTable
        For Each dr As DataRow In dtMarcados.Select
            If dr("Facturado") OrElse Length(dr("FechaVencimiento")) = 0 OrElse Length(dr("IDArticulo")) = 0 OrElse Length(dr("IDCliente")) = 0 OrElse (TabFacturacion.SelectedTab.Key = "Certificacion" AndAlso dr("Estado") <> enumEstadoCertificacion.ecAceptada) Then
                dtMarcados.Rows.Remove(dr)
            End If
        Next
        Return dtMarcados
    End Function

#End Region

    Private Sub VerFacturacionResponsable()
        ExpertisApp.OpenForm("CIFACPORRE")
    End Sub

#Region " Generación Hitos "

    Protected Overridable Sub GeneraHitosFacturacion()
        Select Case TabFacturacion.SelectedTab.Key
            Case TabPageHoras.Key
                AddHitosHoras()
            Case TabPageGastos.Key
                AddHitosGastos()
            Case TabPageMateriales.Key
                AddHitosMateriales()
            Case TabPageTaller.Key
                AddHitosTaller()
        End Select
        Me.Execute()
    End Sub
    Private Sub AddHitosTaller()
        If GridTaller.CheckedRecordsCount > 0 Then
            Dim dtMarcados As DataTable = GridTaller.CheckedRecords
            Dim data As New ObraTrabajoFacturacion.DatosGenerarVencimientos(dtMarcados, Nz(cbxFechaVto.Value, Date.Today))
            ExpertisApp.ExecuteTask(Of ObraTrabajoFacturacion.DatosGenerarVencimientos)(AddressOf ObraTrabajoFacturacion.GenerarVencimientosTaller, data)
            GridTaller.UnCheckAllRecords()
            Me.Execute()
            ExpertisApp.GenerateMessage("Proceso finalizado correctamente.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            ExpertisApp.GenerateMessage("No se han seleccionado líneas.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub AddHitosHoras()
        If GridMod.CheckedRecordsCount > 0 Then
            Dim fFacturados As New Filter
            fFacturados.Add(New BooleanFilterItem("Facturado", True))
            Dim WhereFacturados As String = fFacturados.Compose(New AdoFilterComposer)
            Dim adrFacturados() As DataRow = GridMod.CheckedRecords.Select(WhereFacturados)
            If Not adrFacturados Is Nothing AndAlso adrFacturados.Length > 0 Then
                ExpertisApp.GenerateMessage("Ha seleccionado Horas ya facturadas. Estas Horas no entrarán en el proceso.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If adrFacturados.Length = GridMod.CheckedRecordsCount Then Exit Sub
            End If
            If ExpertisApp.GenerateMessage("Se generarán Vencimientos de Horas. ¿Desea continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim fNoFacturados As New Filter
                fNoFacturados.Add(New BooleanFilterItem("Facturado", False))
                Dim WhereNoFacturados As String = fNoFacturados.Compose(New AdoFilterComposer)
                Dim dtMarcados As DataTable = GridMod.CheckedRecords.Clone
                For Each dr As DataRow In GridMod.CheckedRecords.Select(WhereNoFacturados)
                    dtMarcados.ImportRow(dr)
                Next
                Dim data As New ObraTrabajoFacturacion.DatosGenerarVencimientos(dtMarcados, Nz(cbxFechaVto.Value, Date.Today))
                ExpertisApp.ExecuteTask(Of ObraTrabajoFacturacion.DatosGenerarVencimientos)(AddressOf ObraTrabajoFacturacion.GenerarVencimientosMOD, data)
                GridMod.UnCheckAllRecords()
                ExpertisApp.GenerateMessage("Proceso finalizado correctamente.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            ExpertisApp.GenerateMessage("No se han seleccionado líneas.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub AddHitosGastos()
        If GridGastos.CheckedRecordsCount > 0 Then
            Dim fFacturados As New Filter
            fFacturados.Add(New BooleanFilterItem("Facturado", True))
            Dim WhereFacturados As String = fFacturados.Compose(New AdoFilterComposer)
            Dim adrFacturados() As DataRow = GridGastos.CheckedRecords.Select(WhereFacturados)
            If Not adrFacturados Is Nothing AndAlso adrFacturados.Length > 0 Then
                ExpertisApp.GenerateMessage("Ha seleccionado Gastos ya facturados. Estos Gastos no entrarán en el proceso.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If adrFacturados.Length = GridGastos.CheckedRecordsCount Then Exit Sub
            End If
            If ExpertisApp.GenerateMessage("Se generarán Vencimientos de Gastos. ¿Desea continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim fNoFacturados As New Filter
                fNoFacturados.Add(New BooleanFilterItem("Facturado", False))
                Dim WhereNoFacturados As String = fNoFacturados.Compose(New AdoFilterComposer)
                Dim dtMarcados As DataTable = GridGastos.CheckedRecords.Clone
                For Each dr As DataRow In GridGastos.CheckedRecords.Select(WhereNoFacturados)
                    dtMarcados.ImportRow(dr)
                Next
                Dim data As New ObraTrabajoFacturacion.DatosGenerarVencimientos(dtMarcados, Nz(cbxFechaVto.Value, Date.Today))
                ExpertisApp.ExecuteTask(Of ObraTrabajoFacturacion.DatosGenerarVencimientos)(AddressOf ObraTrabajoFacturacion.GenerarVencimientosGastos, data)
                GridGastos.UnCheckAllRecords()
                ExpertisApp.GenerateMessage("Proceso finalizado correctamente.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            ExpertisApp.GenerateMessage("No se han seleccionado líneas.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub AddHitosMateriales()
        If GridMateriales.CheckedRecordsCount > 0 Then
            Dim fFacturados As New Filter
            fFacturados.Add(New BooleanFilterItem("Facturado", True))
            Dim WhereFacturados As String = fFacturados.Compose(New AdoFilterComposer)
            Dim adrFacturados() As DataRow = GridMateriales.CheckedRecords.Select(WhereFacturados)
            If Not adrFacturados Is Nothing AndAlso adrFacturados.Length > 0 Then
                ExpertisApp.GenerateMessage("Ha seleccionado Materiales ya facturados. Estos Materiales no entrarán en el proceso.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If adrFacturados.Length = GridMateriales.CheckedRecordsCount Then Exit Sub
            End If
            If ExpertisApp.GenerateMessage("Se generarán Vencimientos de Materiales. ¿Desea continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim fNoFacturados As New Filter
                fNoFacturados.Add(New BooleanFilterItem("Facturado", False))
                Dim WhereNoFacturados As String = fNoFacturados.Compose(New AdoFilterComposer)
                Dim dtMarcados As DataTable = GridMateriales.CheckedRecords.Clone
                For Each dr As DataRow In GridMateriales.CheckedRecords.Select(WhereNoFacturados)
                    dtMarcados.ImportRow(dr)
                Next
                Dim data As New ObraTrabajoFacturacion.DatosGenerarVencimientos(dtMarcados, Nz(cbxFechaVto.Value, Date.Today))
                ExpertisApp.ExecuteTask(Of ObraTrabajoFacturacion.DatosGenerarVencimientos)(AddressOf ObraTrabajoFacturacion.GenerarVencimientosMaterial, data)
                GridMateriales.UnCheckAllRecords()
                ExpertisApp.GenerateMessage("Proceso finalizado correctamente.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            ExpertisApp.GenerateMessage("No se han seleccionado líneas.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

#End Region

    Protected Overridable Sub DeleteHitosFacturacion()
        If GridVtos.CheckedRecordsCount > 0 Then
            Dim dtMarcados As DataTable = GridVtos.CheckedRecords
            If Not IsNothing(dtMarcados) AndAlso dtMarcados.Rows.Count > 0 Then
                Me.Cursor = Cursors.WaitCursor
                Dim OTF As New ObraTrabajoFacturacion
                OTF.Delete(dtMarcados)
                GridVtos.UnCheckAllRecords()
                Me.Execute()
                Me.Cursor = Cursors.Default
                ExpertisApp.GenerateMessage("Proceso finalizado correctamente.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            ExpertisApp.GenerateMessage("No hay vencimientos a borrar.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

#End Region

#Region " Acciones Grids "

    Private Sub VerFacturasGeneradas()
        If GridCertificacion.Value("Estado") = enumEstadoCertificacion.ecFacturado AndAlso Length(GridCertificacion.Value("IDCertificacion")) > 0 Then
            Dim frm As New frmFacturasGeneradas
            Dim intIDFactura As Integer
            frm.AbrirFacturasGeneradas(GridCertificacion.Value("IDTrabajo"), intIDFactura, GridCertificacion.Value("IDCertificacion"))
            If intIDFactura > 0 Then AbrirMntoFacturaVenta(intIDFactura)
        Else
            ExpertisApp.GenerateMessage("No hay facturas asociadas a la línea seleccionada.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub VerFacturasVta()
        If Length(GridVtos.Value("IDFactura")) > 0 Then
            AbrirMntoFacturaVenta(GridVtos.Value("IDFactura"))
        End If
    End Sub

    Private Sub VerObras()
        Select Case TabFacturacion.SelectedTab.Key
            Case "Hitos"
                AbrirObra(Nz(GridVtos.Value("IDObra"), 0))
            Case "Certificacion"
                AbrirObra(Nz(GridCertificacion.Value("IDObra"), 0))
        End Select

    End Sub

    Protected Overridable Sub AbrirObra(ByVal IDObra As Integer)
        If Length(IDObra) > 0 Then
            ExpertisApp.OpenForm("MGEO", New NumberFilterItem("IDObra", IDObra))
        End If
    End Sub

    Private Sub BorrarVtosMODGastoMaterial()
        If ExpertisApp.GenerateMessage("Se borrará el Hito seleccionado. ¿Desea continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If GridVtos.Value("Facturado") Then
                ExpertisApp.GenerateMessage("No se puede borrar esta línea. Está Facturada.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                ExpertisApp.ExecuteTask(Of Integer)(AddressOf ObraTrabajoFacturacion.DeleteHito, GridVtos.Value("IDVencimiento"))
                Me.Execute()
            End If
        End If
    End Sub

#End Region

#Region " Hitos / Mod / Gastos "

    Protected Overridable Sub GridVtos_FormattingRow(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles GridVtos.FormattingRow
        If e.Row.RowType = RowType.Record Then
            Select Case CInt(e.Row.Cells("TipoFactura").Value)
                Case enumotfTipoFactura.otfHorasMOD
                    e.Row.RowStyle = GridVtos.FormatStyles("MODFormatStyle")
                Case enumotfTipoFactura.otfGastos
                    e.Row.RowStyle = GridVtos.FormatStyles("GastoFormatStyle")
                Case enumotfTipoFactura.otfMateriales
                    e.Row.RowStyle = GridVtos.FormatStyles("MaterialFormatStyle")
                Case enumotfTipoFactura.otfOrdenesTrabajo
                    '          e.Row.RowStyle = GridVtos.FormatStyles("TallerFormatStyle")
            End Select
        End If
    End Sub

    Private Sub GridVtos_UpdatingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles GridVtos.UpdatingCell
        With GridVtos
            Select Case e.Column.Index
                Case .Columns("QTiempo").Index
                    .Value("ImpVencimientoA") = .Value("ImpVencimientoA") * e.Value / e.InitialValue
            End Select
        End With
    End Sub

    Private Sub GridVtos_EditingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles GridVtos.EditingCell
        With GridVtos
            Select Case e.Column.Key
                Case "TipoFactura"
                    e.Cancel = True
            End Select
        End With
    End Sub

    Private Sub GridVtos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridVtos.Click
        With GridVtos
            Dim c As GridEXColumn = .ColumnFromPoint()
            If Not IsNothing(c) Then
                Dim hit As GridArea
                hit = .HitTest()
                If hit = GridArea.Cell Or hit = GridArea.NewRowCell Then
                    Select Case c.Key
                        Case "Seguimiento"
                            Dim frm As New FormularioTexto
                            frm.SoloLectura = True
                            frm.Text = .Columns(c.Key).Caption
                            frm.Texto = .Value("Seguimiento") & String.Empty
                            frm.ShowDialog()
                    End Select
                End If
            End If
        End With
    End Sub

    Private Sub GridVtos_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridVtos.MouseUp
        If e.Button = MouseButtons.Right Then
            If Not IsNothing(GridVtos) AndAlso GridVtos.RowCount > 0 Then
                With GridVtos
                    If Length(.Value("IDFactura")) > 0 Then
                        .UiCommandManager1.Commands(cnABRIRFACTURA).Visible = InheritableBoolean.True
                    Else
                        .UiCommandManager1.Commands(cnABRIRFACTURA).Visible = InheritableBoolean.False
                    End If
                    If Length(.Value("IDVencimiento")) > 0 Then
                        .UiCommandManager1.Commands(cnDELETEMOD).Visible = InheritableBoolean.False
                        .UiCommandManager1.Commands(cnDELETEGASTO).Visible = InheritableBoolean.False
                        .UiCommandManager1.Commands(cnDELETEMATERIAL).Visible = InheritableBoolean.False
                        If Length(.Value("TipoFactura")) > 0 Then
                            If .Value("TipoFactura") = enumotfTipoFactura.otfHorasMOD Then
                                .UiCommandManager1.Commands(cnDELETEMOD).Visible = InheritableBoolean.True
                            End If
                            If .Value("TipoFactura") = enumotfTipoFactura.otfGastos Then
                                .UiCommandManager1.Commands(cnDELETEGASTO).Visible = InheritableBoolean.True
                            End If
                            If .Value("TipoFactura") = enumotfTipoFactura.otfMateriales Then
                                .UiCommandManager1.Commands(cnDELETEMATERIAL).Visible = InheritableBoolean.True
                            End If
                        End If
                    End If
                End With
            End If
        End If
    End Sub

    Private Sub GridMod_UpdatingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles GridMod.UpdatingCell
        With GridMod
            Select Case e.Column.Key
                Case "HorasFactMod"
                    .SetValue("TasaRealModA", .GetValue("TasaRealMod"))
                    .Value("ImpFactModA") = e.Value * .Value("TasaRealMod")
                    .Value("ImpFactMod") = e.Value * .Value("TasaRealMod")
            End Select
        End With
    End Sub

    Private Sub GridGastos_UpdatingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles GridGastos.UpdatingCell
        With GridGastos
            Select Case e.Column.Index
                Case .Columns("ImpVencimientoA").Index
                    .Value("ImpFactGastoA") = e.Value
            End Select
        End With
    End Sub

    Protected Overridable Sub GridVtosModGastosMateriales_RecordChecked(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.CheckedEventArgs) Handles GridVtos.RecordChecked, GridMod.RecordChecked, GridGastos.RecordChecked, GridMateriales.RecordChecked
        If e.CheckState = CheckStates.Checked Then
            txtTotalMarcado.Value = txtTotalMarcado.Value + e.Row.Cells("ImpVencimientoA").Value()
        Else
            txtTotalMarcado.Value = txtTotalMarcado.Value - e.Row.Cells("ImpVencimientoA").Value()
        End If
    End Sub
    Private Sub GridTaller_RecordChecked(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.CheckedEventArgs) Handles GridTaller.RecordChecked
        If mIDOT = e.Row.DataRow("IDOT") Then
            Dim jFilter As New Janus.Windows.GridEX.GridEXFilterCondition
            jFilter.Clear()

            jFilter.AddCondition()
            jFilter.Conditions(0).Column = GridTaller.Columns("IDOT")
            jFilter.Conditions(0).ConditionOperator = Janus.Windows.GridEX.ConditionOperator.Equal
            jFilter.Conditions(0).Value1 = e.Row.DataRow("IDOT")

            mIDOT = 0
            GridTaller.FindAll(jFilter)
            If e.CheckState = CheckStates.Checked Then
                GridTaller.CheckRecord()
            Else
                GridTaller.UnCheckRecord()
            End If

            GridTaller.SelectedItems.Clear()
        End If
    End Sub

    Private Sub GridTaller_EditingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles GridTaller.EditingCell
        Select Case GridTaller.Columns(e.Column.Index).Key
            Case "Expertis.Check"
                mIDOT = GridTaller.Value(GridTaller.Columns("IDOT").Index)
        End Select
    End Sub
#End Region

#Region " Certificacion "

    Private Sub GridCertificacion_RecordChecked(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.CheckedEventArgs) Handles GridCertificacion.RecordChecked
        If mintIDTrabajo = e.Row.DataRow("IDTrabajo") Then
            Dim jFilter As New Janus.Windows.GridEX.GridEXFilterCondition
            jFilter.Clear()
            jFilter.AddCondition()
            jFilter.Conditions(0).Column = GridCertificacion.Columns("IDCertificacion")
            jFilter.Conditions(0).ConditionOperator = Janus.Windows.GridEX.ConditionOperator.Equal
            jFilter.Conditions(0).Value1 = e.Row.DataRow("IDCertificacion")

            jFilter.AddCondition()
            jFilter.Conditions(1).Column = GridCertificacion.Columns("IDTrabajo")
            jFilter.Conditions(1).ConditionOperator = Janus.Windows.GridEX.ConditionOperator.NotEqual
            jFilter.Conditions(1).Value1 = e.Row.DataRow("IDTrabajo")

            GridCertificacion.FindAll(jFilter)
            If e.CheckState = CheckStates.Checked Then
                GridCertificacion.CheckRecord()
            Else
                GridCertificacion.UnCheckRecord()
            End If

            mintIDTrabajo = 0
            GridCertificacion.SelectedItems.Clear()
        End If
    End Sub

    Private Sub GridCertificacion_EditingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles GridCertificacion.EditingCell
        Select Case GridCertificacion.Columns(e.Column.Index).Key
            Case "Expertis.Check"
                mintIDTrabajo = GridCertificacion.Value(GridCertificacion.Columns("IDTrabajo").Index)
            Case "EstadoFactura", "Estado"
                e.Cancel = True
        End Select
    End Sub

    'Private Sub GridCertificacion_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridCertificacion.MouseUp
    '    If e.Button = MouseButtons.Right Then
    '        If Not IsNothing(GridCertificacion) AndAlso GridCertificacion.RowCount > 0 Then
    '            With GridCertificacion
    '                If .Value("QTotalCertificada") > 0 AndAlso Length(.Value("IDTrabajo")) > 0 Then
    '                    .UiCommandManager1.Commands(cnFACTURASGENERADAS).Visible = InheritableBoolean.True
    '                Else
    '                    .UiCommandManager1.Commands(cnFACTURASGENERADAS).Visible = InheritableBoolean.False
    '                End If
    '            End With
    '        End If
    '    End If
    'End Sub

#End Region

#Region " QueryExecute "

    Private Sub CIFacturacion_FilterClearing(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.FilterClearing
        AdvObraDesde.Value = String.Empty : AdvObraHasta.Value = String.Empty
        AdvObraDesde.Text = String.Empty : AdvObraHasta.Text = String.Empty
        AdvClienteDesde.Value = String.Empty : AdvClienteHasta.Value = String.Empty
        AdvTrabajo.Value = String.Empty : AdvTrabajo.Text = String.Empty

        AdvTipoTrabajo.Value = String.Empty
        AdvSubTipoTrabajo.Value = String.Empty
        AdvIDArticulo.Value = String.Empty
        AdvIDCentroGestion.Value = String.Empty
        cbxAgrupFactura.Value = String.Empty
        cbxTipoFactura.Value = String.Empty
        cbxEstado.Value = String.Empty
        cbxFechaDesde.Value = String.Empty : cbxFechaHasta.Value = String.Empty
        AdvIDOperario.Value = String.Empty

        LoadDefaultQueryExecuting()
    End Sub

    Private Sub CIFacturacion_QueryExecuted(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutedEventArgs) Handles MyBase.QueryExecuted
        Select Case TabFacturacion.SelectedTab.Key
            Case "Hitos"
                txtTotal.Value = GridVtos.GetTotal(GridVtos.Columns("ImpVencimientoA"), AggregateFunction.Sum)
            Case "Horas"
                txtTotal.Value = GridMod.GetTotal(GridMod.Columns("ImpVencimientoA"), AggregateFunction.Sum)
            Case "Gastos"
                txtTotal.Value = GridGastos.GetTotal(GridGastos.Columns("ImpVencimientoA"), AggregateFunction.Sum)
            Case "Materiales"
                txtTotal.Value = GridMateriales.GetTotal(GridMateriales.Columns("ImpVencimientoA"), AggregateFunction.Sum)
            Case "Certificacion"
                txtTotal.Value = GridCertificacion.GetTotal(GridCertificacion.Columns("ImpTotal"), AggregateFunction.Sum)
        End Select
    End Sub

    Private Sub CIFacturacion_QueryExecuting(ByVal sender As Object, ByRef e As Solmicro.Expertis.Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        If IsNothing(Me.CIPrimaryObject) Then
            Select Case TabFacturacion.SelectedTab.Key
                Case "Hitos"
                    Me.CIPrimaryObject = GridVtos
                Case "Horas"
                    Me.CIPrimaryObject = GridMod
                Case "Gastos"
                    Me.CIPrimaryObject = GridGastos
                Case "Materiales"
                    Me.CIPrimaryObject = GridMateriales
                Case "Certificacion"
                    Me.CIPrimaryObject = GridCertificacion
                Case "Taller"
                    Me.CIPrimaryObject = GridTaller
            End Select
            ActiveExecuteActions()
        End If

        e.Filter.Add("DescFacturacion", FilterOperator.Equal, AdvAlqVen.Text, FilterType.String)
        e.Filter.Add("NObra", FilterOperator.GreaterThanOrEqual, AdvObraDesde.Text, FilterType.String)
        e.Filter.Add("NObra", FilterOperator.LessThanOrEqual, AdvObraHasta.Text, FilterType.String)
        e.Filter.Add("IDCliente", FilterOperator.GreaterThanOrEqual, AdvClienteDesde.Value, FilterType.String)
        e.Filter.Add("IDCliente", FilterOperator.LessThanOrEqual, AdvClienteHasta.Value, FilterType.String)
        e.Filter.Add("IDTrabajo", FilterOperator.Equal, AdvTrabajo.Value, FilterType.Numeric)
        e.Filter.Add("IDTipoTrabajo", FilterOperator.Equal, AdvTipoTrabajo.Value, FilterType.String)
        e.Filter.Add("IDSubTipoTrabajo", FilterOperator.Equal, AdvSubTipoTrabajo.Value, FilterType.String)
        e.Filter.Add("IDCentroGestion", FilterOperator.Equal, AdvIDCentroGestion.Value, FilterType.String)
        Select Case TabFacturacion.SelectedTab.Key
            Case "Hitos", "Horas", "Gastos", "Materiales"
                e.Filter.Add("AgrupFacturaObra", FilterOperator.Equal, cbxAgrupFactura.Value, FilterType.Numeric)

                If cbxEstado.Value <> enumotfEstadoCIVtos.otfvTodos Then
                    Select Case CType(cbxEstado.Value, enumotfEstadoCIVtos)
                        Case enumotfEstadoCIVtos.otfvFacturado
                            e.Filter.Add(New BooleanFilterItem("Facturado", True))
                        Case enumotfEstadoCIVtos.otfvNoFacturado
                            e.Filter.Add(New BooleanFilterItem("Facturado", False))
                    End Select
                End If
                e.Filter.Add("FechaVencimiento", FilterOperator.GreaterThanOrEqual, cbxFechaDesde.Value, FilterType.DateTime)
                e.Filter.Add("FechaVencimiento", FilterOperator.LessThanOrEqual, cbxFechaHasta.Value, FilterType.DateTime)
                If TabFacturacion.SelectedTab.Key = "Hitos" Then
                    e.Filter.Add("TipoFactura", FilterOperator.Equal, cbxTipoFactura.Value, FilterType.Numeric)
                    e.Filter.Add("IDArticulo", FilterOperator.Equal, AdvIDArticulo.Value, FilterType.String)
                ElseIf TabFacturacion.SelectedTab.Key = "Materiales" Then
                    e.Filter.Add("IDMaterial", FilterOperator.Equal, AdvIDArticulo.Value, FilterType.String)
                ElseIf TabFacturacion.SelectedTab.Key = "Horas" Or TabFacturacion.SelectedTab.Key = "Gastos" Then
                    e.Filter.Add("IDOperario", FilterOperator.Equal, AdvIDOperario.Value, FilterType.String)
                End If
            Case "Certificacion"
                e.Filter.Add("Estado", FilterOperator.Equal, cbxEstadoCertificacion.Value, FilterType.Numeric)
                e.Filter.Add("FechaInicio", FilterOperator.GreaterThanOrEqual, cbxFechaDesde.Value, FilterType.DateTime)
                e.Filter.Add("FechaInicio", FilterOperator.LessThanOrEqual, cbxFechaHasta.Value, FilterType.DateTime)
                e.Filter.Add("IDArticulo", FilterOperator.Equal, AdvIDArticulo.Value, FilterType.String)

            Case TabPageTaller.Key
                ' e.Filter.Add("IDOT", FilterOperator.GreaterThanOrEqual, AdvOTDesde.Value, FilterType.Numeric)
                ' e.Filter.Add("IDOT", FilterOperator.LessThanOrEqual, AdvOTHasta.Value, FilterType.Numeric)
                ' e.Filter.Add("IDArticulo", FilterOperator.Equal, AdvIDArticulo.Value, FilterType.String)
                ' e.Filter.Add("EstadoFactura", FilterOperator.Equal, cbxEstadoOT.Value, FilterType.Numeric)
                ' e.Filter.Add("Tipo", FilterOperator.Equal, cbxTipoOT.Value, FilterType.Numeric)
                ' e.Filter.Add("FechaCierre", FilterOperator.GreaterThanOrEqual, cbxFechaDesde.Value, FilterType.DateTime)
                ' e.Filter.Add("FechaCierre", FilterOperator.LessThanOrEqual, cbxFechaHasta.Value, FilterType.DateTime)
            Case Else
                e.Cancel = True
        End Select
    End Sub

#End Region

    Private Sub TabFacturacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabFacturacion.Click
        ActiveExecuteActions()
        ActivateControls()

        Select Case TabFacturacion.SelectedTab.Key
            Case TabPageHitos.Key
                Me.CIPrimaryObject = GridVtos
                'David 04/11
                lblAlqOVen.Visible = True
                AdvAlqVen.Visible = True
                lblFechaDesde.Visible = True
                lblFechaHasta.Visible = True
                cbxFechaDesde.Visible = True
                cbxFechaHasta.Visible = True
                'David
            Case TabPageHoras.Key
                Me.CIPrimaryObject = GridMod
            Case TabPageGastos.Key
                Me.CIPrimaryObject = GridGastos
            Case TabPageMateriales.Key
                Me.CIPrimaryObject = GridMateriales
            Case TabPageCertificacion.Key
                Me.CIPrimaryObject = GridCertificacion
            Case TabPageTaller.Key
                Me.CIPrimaryObject = GridTaller
        End Select
    End Sub

    Protected Overridable Sub ActiveExecuteActions()
        Me.ExecuteActions.Commands(cnFACTURACION).Enabled = Janus.Windows.UI.InheritableBoolean.False
        Me.ExecuteActions.Commands(cnFACTURACIONRESPONSABLE).Enabled = Janus.Windows.UI.InheritableBoolean.False
        Me.ExecuteActions.Commands(cnGENERARVTOS).Enabled = Janus.Windows.UI.InheritableBoolean.False
        Me.ExecuteActions.Commands(cnDELETEVTOS).Enabled = Janus.Windows.UI.InheritableBoolean.False
        Select Case TabFacturacion.SelectedTab.Key
            Case "Hitos"
                If mblnTienePermisosFacturacion Then
                    Me.ExecuteActions.Commands(cnFACTURACION).Enabled = Janus.Windows.UI.InheritableBoolean.True
                End If
                Me.ExecuteActions.Commands(cnFACTURACIONRESPONSABLE).Enabled = Janus.Windows.UI.InheritableBoolean.True
                Me.ExecuteActions.Commands(cnDELETEVTOS).Enabled = Janus.Windows.UI.InheritableBoolean.True
            Case "Horas", "Gastos", "Materiales"
                Me.ExecuteActions.Commands(cnFACTURACIONRESPONSABLE).Enabled = Janus.Windows.UI.InheritableBoolean.True
                Me.ExecuteActions.Commands(cnGENERARVTOS).Enabled = Janus.Windows.UI.InheritableBoolean.True
            Case "Certificacion"
                Me.ExecuteActions.Commands(cnFACTURACION).Enabled = Janus.Windows.UI.InheritableBoolean.True
                Me.ExecuteActions.Commands(cnFACTURACIONRESPONSABLE).Enabled = Janus.Windows.UI.InheritableBoolean.True
            Case "Taller"
                Me.ExecuteActions.Commands(cnFACTURACIONRESPONSABLE).Enabled = Janus.Windows.UI.InheritableBoolean.True
                Me.ExecuteActions.Commands(cnGENERARVTOS).Enabled = Janus.Windows.UI.InheritableBoolean.True
        End Select
    End Sub

    Private Sub ActivateControls()
        With TabFacturacion
            'Activación de guardar y cancelar de la toolbar.
            Me.AllowUpdate = (.SelectedTab.Key = "Hitos" Or .SelectedTab.Key = "Horas" Or .SelectedTab.Key = "Gastos" Or .SelectedTab.Key = "Materiales")

            'Activación Criterios de Consulta
            pnlTipoFactura.Visible = (.SelectedTab.Key = "Hitos")
            pnlOperario.Visible = (.SelectedTab.Key = "Horas" Or .SelectedTab.Key = "Gastos" Or .SelectedTab.Key = "Certificacion")
            cbxAgrupFactura.Visible = (.SelectedTab.Key = "Hitos" Or .SelectedTab.Key = "Horas" Or .SelectedTab.Key = "Gastos" Or .SelectedTab.Key = "Materiales")
            lblAgrupFactura.Visible = cbxAgrupFactura.Visible
            pnlEstadoCertificacion.Visible = .SelectedTab.Key = "Certificacion"
            pnlEstado.Visible = .SelectedTab.Key <> "Certificacion"
            AdvIDArticulo.Visible = (.SelectedTab.Key = "Hitos" Or .SelectedTab.Key = "Certificacion" Or .SelectedTab.Key = "Materiales")

            If .SelectedTab.Key = "Materiales" Then
                lblArticulo.Text = "Material"
            Else
                lblArticulo.Text = "Artículo"
                'David 04/11
                lblAlqOVen.Visible = False
                AdvAlqVen.Visible = False
                lblFechaDesde.Visible = True
                lblFechaHasta.Visible = True
                cbxFechaDesde.Visible = True
                cbxFechaHasta.Visible = True
                'David
            End If
            lblArticulo.Visible = AdvIDArticulo.Visible

            'Activación Parámetros
            pnlFechaVto.Visible = (.SelectedTab.Key = "Horas" Or .SelectedTab.Key = "Gastos" Or .SelectedTab.Key = "Materiales")
            pnlConfigFacturacion.Visible = Not pnlFechaVto.Visible
            txtTotalMarcado.Visible = .SelectedTab.Key <> "Certificacion"
            lblTotalMarcado.Visible = txtTotalMarcado.Visible
        End With

        If pnlFechaVto.Visible And Length(cbxFechaVto.Value) = 0 Then cbxFechaVto.Value = Date.Today

        pnlEstadoCertificacion.Location = pnlEstado.Location
        pnlOperario.Location = pnlTipoFactura.Location
    End Sub

    Private Sub AdvContador_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles AdvContador.SetPredefinedFilter
        e.Filter.Add(New StringFilterItem("Entidad", GetType(FacturaVentaCabecera).Name))
    End Sub

    Private Sub AdvTrabajo_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles AdvTrabajo.SetPredefinedFilter
        If Length(AdvTipoTrabajo.Value) > 0 Then e.Filter.Add(New StringFilterItem("IDTipoTrabajo", AdvTipoTrabajo.Value))
        If Length(AdvSubTipoTrabajo.Value) > 0 Then e.Filter.Add(New StringFilterItem("IDSubTipoTrabajo", AdvSubTipoTrabajo.Value))
    End Sub

    Private Sub AdvSubTipoTrabajo_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles AdvSubTipoTrabajo.SetPredefinedFilter
        If Length(AdvTipoTrabajo.Value) > 0 Then e.Filter.Add(New StringFilterItem("IDTipoTrabajo", AdvTipoTrabajo.Value))
    End Sub

    Private Sub chkCondicionesCliente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCondicionesCliente.CheckedChanged
        cbxTipoAgrupacion.Value = System.DBNull.Value
        cbxTipoAgrupacion.Enabled = Not chkCondicionesCliente.Checked
    End Sub

    Private Sub ShowFilterPanel1_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles ShowFilterPanel1.Click
        pnlCriteriosSeleccion.Visible = Not pnlCriteriosSeleccion.Visible
    End Sub

    Private Sub CIFacturacion_SetReportExportOptions(ByVal sender As Object, ByVal e As Engine.UI.ReportExportOptionsEventArgs) Handles MyBase.SetReportExportOptions
        If TabFacturacion.SelectedTab.Key <> "Hitos" Then
            If e.Alias = "LOFAC" Then
                ExpertisApp.GenerateMessage("El Informe de Hitos de facturación solo es accesible desde la pestaña de Hitos.|Por favor, seleccione esa pestaña.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, vbNewLine)
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub cbxAño_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxAño.ValueChanged
        If Length(cbxAño.Value) > 0 Then
            Dim f As New Filter
            f.Add("YEAR(FechaInicio)", cbxAño.Value)
            AdvObraDesde.PredefinedFilter = f
            AdvObraHasta.PredefinedFilter = f
        Else
            AdvObraDesde.PredefinedFilter = Nothing
            AdvObraHasta.PredefinedFilter = Nothing
        End If

    End Sub

    Private Sub AdvObraDesde_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdvObraDesde.Leave
        AdvObraHasta.Text = AdvObraDesde.Text
    End Sub

    Private Sub AdvClienteDesde_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdvClienteDesde.Leave
        AdvClienteHasta.Text = AdvClienteDesde.Text
    End Sub
End Class