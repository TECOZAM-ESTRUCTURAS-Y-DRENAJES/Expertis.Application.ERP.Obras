Imports Solmicro.Expertis.Business.Compra
Imports Janus.Windows.UI
Public Class CIGenerarCompras
    Inherits Solmicro.Expertis.Engine.UI.CIMntoBase

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        txtPendiente.Value = System.DBNull.Value
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
    Friend WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents lblfwiIDCentroGestion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblContador As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvContador As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblFwiIdOperario As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvOperario As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents FilterPanel As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents lblEstado As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFechaDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblProveedor As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFechaHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblMaterial As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblObra As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblPendiente As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents AdvProveedor As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents cbxFechaDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents AdvMaterial As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents cbxEstadoObra As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents AdvObra As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents TabGeneracionCompras As Solmicro.Expertis.Engine.UI.Tab
    Friend WithEvents TabPageMateriales As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents TabPageTrabajos As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents GridMateriales As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents GridTrabajos As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents txtPendiente As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents AdvCentroGestion As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvTrabajo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblTipo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFamilia As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvTipo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvFamilia As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblFechaEntrega As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaEntrega As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaTopeResp As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaTopeResp As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents ShowFilterPanel As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents ShowFilterPanel1 As Janus.Windows.UI.CommandBars.UICommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim cbxEstadoObra_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridTrabajos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridMateriales_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIGenerarCompras))
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblFechaTopeResp = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaTopeResp = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaEntrega = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaEntrega = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.AdvCentroGestion = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblfwiIDCentroGestion = New Solmicro.Expertis.Engine.UI.Label
        Me.lblContador = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvContador = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblFwiIdOperario = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvOperario = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.FilterPanel = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblTipo = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFamilia = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvTipo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.AdvFamilia = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.AdvTrabajo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.txtPendiente = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblEstado = New Solmicro.Expertis.Engine.UI.Label
        Me.lblTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFechaDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.lblProveedor = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFechaHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.lblMaterial = New Solmicro.Expertis.Engine.UI.Label
        Me.lblObra = New Solmicro.Expertis.Engine.UI.Label
        Me.lblPendiente = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.AdvProveedor = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.cbxFechaDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.AdvMaterial = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.cbxEstadoObra = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.AdvObra = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.TabGeneracionCompras = New Solmicro.Expertis.Engine.UI.Tab
        Me.TabPageTrabajos = New Janus.Windows.UI.Tab.UITabPage
        Me.GridTrabajos = New Solmicro.Expertis.Engine.UI.Grid
        Me.TabPageMateriales = New Janus.Windows.UI.Tab.UITabPage
        Me.GridMateriales = New Solmicro.Expertis.Engine.UI.Grid
        Me.ShowFilterPanel = New Janus.Windows.UI.CommandBars.UICommand("ShowFilterPanel")
        Me.ShowFilterPanel1 = New Janus.Windows.UI.CommandBars.UICommand("ShowFilterPanel")
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        Me.Panel1.suspendlayout()
        Me.FilterPanel.SuspendLayout()
        CType(Me.cbxEstadoObra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabGeneracionCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabGeneracionCompras.SuspendLayout()
        Me.TabPageTrabajos.SuspendLayout()
        CType(Me.GridTrabajos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageMateriales.SuspendLayout()
        CType(Me.GridMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Toolbar.Location = New System.Drawing.Point(49, 0)
        Me.Toolbar.Size = New System.Drawing.Size(316, 28)
        '
        'Menubar
        '
        Me.Menubar.Location = New System.Drawing.Point(0, 28)
        '
        'MainPanel
        '
        Me.MainPanel.Controls.Add(Me.TabGeneracionCompras)
        Me.MainPanel.Controls.Add(Me.FilterPanel)
        Me.MainPanel.Controls.Add(Me.Panel1)
        Me.MainPanel.Size = New System.Drawing.Size(671, 351)
        '
        'ExecuteActions
        '
        Me.ExecuteActions.Icon = CType(resources.GetObject("ExecuteActions.Icon"), System.Drawing.Icon)
        Me.ExecuteActions.Text = ""
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(671, 351)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblFechaTopeResp)
        Me.Panel1.Controls.Add(Me.cbxFechaTopeResp)
        Me.Panel1.Controls.Add(Me.lblFechaEntrega)
        Me.Panel1.Controls.Add(Me.cbxFechaEntrega)
        Me.Panel1.Controls.Add(Me.AdvCentroGestion)
        Me.Panel1.Controls.Add(Me.lblfwiIDCentroGestion)
        Me.Panel1.Controls.Add(Me.lblContador)
        Me.Panel1.Controls.Add(Me.AdvContador)
        Me.Panel1.Controls.Add(Me.lblFwiIdOperario)
        Me.Panel1.Controls.Add(Me.AdvOperario)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(671, 62)
        Me.Panel1.TabIndex = 3
        '
        'lblFechaTopeResp
        '
        Me.lblFechaTopeResp.Location = New System.Drawing.Point(208, 39)
        Me.lblFechaTopeResp.Name = "lblFechaTopeResp"
        Me.lblFechaTopeResp.Size = New System.Drawing.Size(134, 13)
        Me.lblFechaTopeResp.TabIndex = 60
        Me.lblFechaTopeResp.Text = "Fecha Tope Respuesta"
        '
        'cbxFechaTopeResp
        '
        Me.cbxFechaTopeResp.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaTopeResp.Location = New System.Drawing.Point(314, 35)
        Me.cbxFechaTopeResp.Name = "cbxFechaTopeResp"
        Me.cbxFechaTopeResp.Size = New System.Drawing.Size(100, 21)
        Me.cbxFechaTopeResp.TabIndex = 13
        '
        'lblFechaEntrega
        '
        Me.lblFechaEntrega.Location = New System.Drawing.Point(6, 39)
        Me.lblFechaEntrega.Name = "lblFechaEntrega"
        Me.lblFechaEntrega.Size = New System.Drawing.Size(88, 13)
        Me.lblFechaEntrega.TabIndex = 58
        Me.lblFechaEntrega.Text = "Fecha Entrega"
        '
        'cbxFechaEntrega
        '
        Me.cbxFechaEntrega.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaEntrega.Location = New System.Drawing.Point(72, 35)
        Me.cbxFechaEntrega.Name = "cbxFechaEntrega"
        Me.cbxFechaEntrega.Size = New System.Drawing.Size(100, 21)
        Me.cbxFechaEntrega.TabIndex = 12
        '
        'AdvCentroGestion
        '
        Me.AdvCentroGestion.DisabledBackColor = System.Drawing.Color.White
        Me.AdvCentroGestion.EntityName = "CentroGestion"
        Me.AdvCentroGestion.Location = New System.Drawing.Point(521, 6)
        Me.AdvCentroGestion.Name = "AdvCentroGestion"
        Me.AdvCentroGestion.SecondaryDataFields = "IDCentroGestion"
        Me.AdvCentroGestion.Size = New System.Drawing.Size(100, 23)
        Me.AdvCentroGestion.TabIndex = 11
        '
        'lblfwiIDCentroGestion
        '
        Me.lblfwiIDCentroGestion.Location = New System.Drawing.Point(448, 11)
        Me.lblfwiIDCentroGestion.Name = "lblfwiIDCentroGestion"
        Me.lblfwiIDCentroGestion.Size = New System.Drawing.Size(67, 13)
        Me.lblfwiIDCentroGestion.TabIndex = 45
        Me.lblfwiIDCentroGestion.Text = "C. Gestión"
        '
        'lblContador
        '
        Me.lblContador.Location = New System.Drawing.Point(6, 11)
        Me.lblContador.Name = "lblContador"
        Me.lblContador.Size = New System.Drawing.Size(60, 13)
        Me.lblContador.TabIndex = 43
        Me.lblContador.Tag = "IdRec=4809;"
        Me.lblContador.Text = "Contador"
        '
        'AdvContador
        '
        Me.AdvContador.DisabledBackColor = System.Drawing.Color.White
        Me.AdvContador.EntityName = "EntidadContador"
        Me.AdvContador.Location = New System.Drawing.Point(72, 6)
        Me.AdvContador.Name = "AdvContador"
        Me.AdvContador.SecondaryDataFields = "IDContador"
        Me.AdvContador.Size = New System.Drawing.Size(100, 23)
        Me.AdvContador.TabIndex = 9
        '
        'lblFwiIdOperario
        '
        Me.lblFwiIdOperario.Location = New System.Drawing.Point(208, 11)
        Me.lblFwiIdOperario.Name = "lblFwiIdOperario"
        Me.lblFwiIdOperario.Size = New System.Drawing.Size(57, 13)
        Me.lblFwiIdOperario.TabIndex = 22
        Me.lblFwiIdOperario.Tag = "IdRec=5860;"
        Me.lblFwiIdOperario.Text = "Operario"
        '
        'AdvOperario
        '
        Me.AdvOperario.DisabledBackColor = System.Drawing.Color.White
        Me.AdvOperario.EntityName = "Operario"
        Me.AdvOperario.Location = New System.Drawing.Point(314, 6)
        Me.AdvOperario.Name = "AdvOperario"
        Me.AdvOperario.SecondaryDataFields = "IDOperario"
        Me.AdvOperario.Size = New System.Drawing.Size(100, 23)
        Me.AdvOperario.TabIndex = 10
        Me.AdvOperario.ViewName = "tbMaestroOperario"
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.lblTipo)
        Me.FilterPanel.Controls.Add(Me.lblFamilia)
        Me.FilterPanel.Controls.Add(Me.AdvTipo)
        Me.FilterPanel.Controls.Add(Me.AdvFamilia)
        Me.FilterPanel.Controls.Add(Me.AdvTrabajo)
        Me.FilterPanel.Controls.Add(Me.txtPendiente)
        Me.FilterPanel.Controls.Add(Me.lblEstado)
        Me.FilterPanel.Controls.Add(Me.lblTrabajo)
        Me.FilterPanel.Controls.Add(Me.lblFechaDesde)
        Me.FilterPanel.Controls.Add(Me.lblProveedor)
        Me.FilterPanel.Controls.Add(Me.lblFechaHasta)
        Me.FilterPanel.Controls.Add(Me.lblMaterial)
        Me.FilterPanel.Controls.Add(Me.lblObra)
        Me.FilterPanel.Controls.Add(Me.lblPendiente)
        Me.FilterPanel.Controls.Add(Me.cbxFechaHasta)
        Me.FilterPanel.Controls.Add(Me.AdvProveedor)
        Me.FilterPanel.Controls.Add(Me.cbxFechaDesde)
        Me.FilterPanel.Controls.Add(Me.AdvMaterial)
        Me.FilterPanel.Controls.Add(Me.cbxEstadoObra)
        Me.FilterPanel.Controls.Add(Me.AdvObra)
        Me.FilterPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FilterPanel.Location = New System.Drawing.Point(0, 250)
        Me.FilterPanel.Name = "FilterPanel"
        Me.FilterPanel.Size = New System.Drawing.Size(671, 101)
        Me.FilterPanel.TabIndex = 4
        Me.FilterPanel.TabStop = False
        Me.FilterPanel.Text = "Criterios de Busqueda"
        '
        'lblTipo
        '
        Me.lblTipo.Location = New System.Drawing.Point(362, 28)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(31, 13)
        Me.lblTipo.TabIndex = 131
        Me.lblTipo.Tag = "IdRec=4456;"
        Me.lblTipo.Text = "Tipo"
        '
        'lblFamilia
        '
        Me.lblFamilia.Location = New System.Drawing.Point(362, 53)
        Me.lblFamilia.Name = "lblFamilia"
        Me.lblFamilia.Size = New System.Drawing.Size(46, 13)
        Me.lblFamilia.TabIndex = 132
        Me.lblFamilia.Tag = "IdRec=4454;"
        Me.lblFamilia.Text = "Familia"
        '
        'AdvTipo
        '
        Me.AdvTipo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvTipo.EntityName = "TipoArticulo"
        Me.AdvTipo.Location = New System.Drawing.Point(414, 23)
        Me.AdvTipo.Name = "AdvTipo"
        Me.AdvTipo.PrimaryDataFields = "IDTipo"
        Me.AdvTipo.SecondaryDataFields = "IDTipo"
        Me.AdvTipo.Size = New System.Drawing.Size(75, 23)
        Me.AdvTipo.TabIndex = 5
        Me.AdvTipo.ViewName = "tbMaestroTipoArticulo"
        '
        'AdvFamilia
        '
        Me.AdvFamilia.DisabledBackColor = System.Drawing.Color.White
        Me.AdvFamilia.EntityName = "Familia"
        Me.AdvFamilia.Location = New System.Drawing.Point(414, 48)
        Me.AdvFamilia.Name = "AdvFamilia"
        Me.AdvFamilia.PrimaryDataFields = "IDFamilia"
        Me.AdvFamilia.SecondaryDataFields = "IDFamilia"
        Me.AdvFamilia.Size = New System.Drawing.Size(75, 23)
        Me.AdvFamilia.TabIndex = 6
        Me.AdvFamilia.ViewName = "tbMaestroFamilia"
        '
        'AdvTrabajo
        '
        Me.AdvTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvTrabajo.DisplayField = "CodTrabajo"
        Me.AdvTrabajo.EntityName = "ObraTrabajo"
        Me.AdvTrabajo.Location = New System.Drawing.Point(64, 48)
        Me.AdvTrabajo.Name = "AdvTrabajo"
        Me.AdvTrabajo.SecondaryDataFields = "IDTrabajo"
        Me.AdvTrabajo.Size = New System.Drawing.Size(105, 23)
        Me.AdvTrabajo.TabIndex = 1
        Me.AdvTrabajo.ViewName = "tbObraTrabajo"
        '
        'txtPendiente
        '
        Me.txtPendiente.DisabledBackColor = System.Drawing.Color.White
        Me.txtPendiente.Location = New System.Drawing.Point(584, 73)
        Me.txtPendiente.Name = "txtPendiente"
        Me.txtPendiente.NullBehavior = Janus.Windows.GridEX.NumericEditNullBehavior.AllowNull
        Me.txtPendiente.Size = New System.Drawing.Size(80, 21)
        Me.txtPendiente.TabIndex = 9
        '
        'lblEstado
        '
        Me.lblEstado.Location = New System.Drawing.Point(6, 76)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(45, 13)
        Me.lblEstado.TabIndex = 126
        Me.lblEstado.Text = "Estado"
        '
        'lblTrabajo
        '
        Me.lblTrabajo.Location = New System.Drawing.Point(6, 53)
        Me.lblTrabajo.Name = "lblTrabajo"
        Me.lblTrabajo.Size = New System.Drawing.Size(50, 13)
        Me.lblTrabajo.TabIndex = 125
        Me.lblTrabajo.Tag = "IdRec=5695;"
        Me.lblTrabajo.Text = "Trabajo"
        '
        'lblFechaDesde
        '
        Me.lblFechaDesde.Location = New System.Drawing.Point(501, 28)
        Me.lblFechaDesde.Name = "lblFechaDesde"
        Me.lblFechaDesde.Size = New System.Drawing.Size(80, 13)
        Me.lblFechaDesde.TabIndex = 124
        Me.lblFechaDesde.Tag = "IdRec=4633;"
        Me.lblFechaDesde.Text = "Fecha Desde"
        '
        'lblProveedor
        '
        Me.lblProveedor.Location = New System.Drawing.Point(179, 28)
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Size = New System.Drawing.Size(66, 13)
        Me.lblProveedor.TabIndex = 121
        Me.lblProveedor.Tag = "IdRec=4352;"
        Me.lblProveedor.Text = "Proveedor"
        '
        'lblFechaHasta
        '
        Me.lblFechaHasta.Location = New System.Drawing.Point(501, 52)
        Me.lblFechaHasta.Name = "lblFechaHasta"
        Me.lblFechaHasta.Size = New System.Drawing.Size(76, 13)
        Me.lblFechaHasta.TabIndex = 122
        Me.lblFechaHasta.Tag = "IdRec=4633;"
        Me.lblFechaHasta.Text = "Fecha Hasta"
        '
        'lblMaterial
        '
        Me.lblMaterial.Location = New System.Drawing.Point(179, 53)
        Me.lblMaterial.Name = "lblMaterial"
        Me.lblMaterial.Size = New System.Drawing.Size(52, 13)
        Me.lblMaterial.TabIndex = 123
        Me.lblMaterial.Tag = "IdRec=5696;"
        Me.lblMaterial.Text = "Material"
        '
        'lblObra
        '
        Me.lblObra.Location = New System.Drawing.Point(6, 28)
        Me.lblObra.Name = "lblObra"
        Me.lblObra.Size = New System.Drawing.Size(57, 13)
        Me.lblObra.TabIndex = 120
        Me.lblObra.Tag = ""
        Me.lblObra.Text = "Proyecto"
        '
        'lblPendiente
        '
        Me.lblPendiente.Location = New System.Drawing.Point(501, 76)
        Me.lblPendiente.Name = "lblPendiente"
        Me.lblPendiente.Size = New System.Drawing.Size(76, 13)
        Me.lblPendiente.TabIndex = 119
        Me.lblPendiente.Tag = "IdRec=5379;"
        Me.lblPendiente.Text = "Pendiente >"
        '
        'cbxFechaHasta
        '
        Me.cbxFechaHasta.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaHasta.Location = New System.Drawing.Point(584, 48)
        Me.cbxFechaHasta.Name = "cbxFechaHasta"
        Me.cbxFechaHasta.Size = New System.Drawing.Size(80, 21)
        Me.cbxFechaHasta.TabIndex = 8
        '
        'AdvProveedor
        '
        Me.AdvProveedor.DisabledBackColor = System.Drawing.Color.White
        Me.AdvProveedor.EntityName = "Proveedor"
        Me.AdvProveedor.Location = New System.Drawing.Point(247, 23)
        Me.AdvProveedor.Name = "AdvProveedor"
        Me.AdvProveedor.SecondaryDataFields = "IDProveedor"
        Me.AdvProveedor.Size = New System.Drawing.Size(105, 23)
        Me.AdvProveedor.TabIndex = 3
        Me.AdvProveedor.ViewName = "tbMaestroProveedor"
        '
        'cbxFechaDesde
        '
        Me.cbxFechaDesde.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaDesde.Location = New System.Drawing.Point(584, 23)
        Me.cbxFechaDesde.Name = "cbxFechaDesde"
        Me.cbxFechaDesde.Size = New System.Drawing.Size(80, 21)
        Me.cbxFechaDesde.TabIndex = 7
        '
        'AdvMaterial
        '
        Me.AdvMaterial.DisabledBackColor = System.Drawing.Color.White
        Me.AdvMaterial.EntityName = "Articulo"
        Me.AdvMaterial.Location = New System.Drawing.Point(247, 48)
        Me.AdvMaterial.Name = "AdvMaterial"
        Me.AdvMaterial.SecondaryDataFields = "IDArticulo"
        Me.AdvMaterial.Size = New System.Drawing.Size(105, 23)
        Me.AdvMaterial.TabIndex = 4
        Me.AdvMaterial.ViewName = "tbMaestroArticulo"
        '
        'cbxEstadoObra
        '
        cbxEstadoObra_DesignTimeLayout.LayoutString = resources.GetString("cbxEstadoObra_DesignTimeLayout.LayoutString")
        Me.cbxEstadoObra.DesignTimeLayout = cbxEstadoObra_DesignTimeLayout
        Me.cbxEstadoObra.DisabledBackColor = System.Drawing.Color.White
        Me.cbxEstadoObra.Location = New System.Drawing.Point(64, 73)
        Me.cbxEstadoObra.Name = "cbxEstadoObra"
        Me.cbxEstadoObra.SecondaryDataFields = "CodTrabajo"
        Me.cbxEstadoObra.SelectedIndex = -1
        Me.cbxEstadoObra.SelectedItem = Nothing
        Me.cbxEstadoObra.Size = New System.Drawing.Size(105, 21)
        Me.cbxEstadoObra.TabIndex = 2
        '
        'AdvObra
        '
        Me.AdvObra.DisabledBackColor = System.Drawing.Color.White
        Me.AdvObra.DisplayField = "NObra"
        Me.AdvObra.EntityName = "ObraCabecera"
        Me.AdvObra.Location = New System.Drawing.Point(64, 23)
        Me.AdvObra.Name = "AdvObra"
        Me.AdvObra.SecondaryDataFields = "IDObra"
        Me.AdvObra.Size = New System.Drawing.Size(105, 23)
        Me.AdvObra.TabIndex = 0
        Me.AdvObra.ViewName = "tbObraCabecera"
        '
        'TabGeneracionCompras
        '
        Me.TabGeneracionCompras.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.TabGeneracionCompras.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabGeneracionCompras.Location = New System.Drawing.Point(0, 62)
        Me.TabGeneracionCompras.Name = "TabGeneracionCompras"
        Me.TabGeneracionCompras.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TabGeneracionCompras.Size = New System.Drawing.Size(671, 188)
        Me.TabGeneracionCompras.TabIndex = 5
        Me.TabGeneracionCompras.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.TabPageMateriales, Me.TabPageTrabajos})
        Me.TabGeneracionCompras.TabStripAlignment = Janus.Windows.UI.Tab.TabStripAlignment.Right
        Me.TabGeneracionCompras.TextOrientation = Janus.Windows.UI.Tab.TextOrientation.Vertical
        Me.TabGeneracionCompras.UseThemes = True
        '
        'TabPageTrabajos
        '
        Me.TabPageTrabajos.Controls.Add(Me.GridTrabajos)
        Me.TabPageTrabajos.Key = "TabPageTrabajos"
        Me.TabPageTrabajos.Location = New System.Drawing.Point(1, 1)
        Me.TabPageTrabajos.Name = "TabPageTrabajos"
        Me.TabPageTrabajos.Size = New System.Drawing.Size(648, 186)
        Me.TabPageTrabajos.TabStop = True
        Me.TabPageTrabajos.Text = "Trabajos"
        '
        'GridTrabajos
        '
        Me.GridTrabajos.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IdProveedor", "Proveedor", "IdProveedor")})
        Me.GridTrabajos.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridTrabajos.CheckFields = New Solmicro.Expertis.Engine.UI.CheckFields(New Solmicro.Expertis.Engine.UI.CheckField() {New Solmicro.Expertis.Engine.UI.CheckField("CantidadMarca1", "Cantidad", Solmicro.Expertis.Engine.UI.CheckFieldType.Numeric, "Pendiente"), New Solmicro.Expertis.Engine.UI.CheckField("FechaTopeResp", "Fecha Tope Resp.", Solmicro.Expertis.Engine.UI.CheckFieldType.DateTime, "")})
        GridTrabajos_DesignTimeLayout.LayoutString = resources.GetString("GridTrabajos_DesignTimeLayout.LayoutString")
        Me.GridTrabajos.DesignTimeLayout = GridTrabajos_DesignTimeLayout
        Me.GridTrabajos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridTrabajos.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridTrabajos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridTrabajos.EntityName = "ObraTrabajo"
        Me.GridTrabajos.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridTrabajos.KeyField = "IDTrabajo"
        Me.GridTrabajos.Location = New System.Drawing.Point(0, 0)
        Me.GridTrabajos.Name = "GridTrabajos"
        Me.GridTrabajos.PrimaryDataFields = Nothing
        Me.GridTrabajos.SecondaryDataFields = ""
        Me.GridTrabajos.Size = New System.Drawing.Size(648, 186)
        Me.GridTrabajos.TabIndex = 0
        Me.GridTrabajos.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridTrabajos.UseCheck = True
        Me.GridTrabajos.ViewName = "VFrmMntoObraGeneraCompraTrabajo"
        '
        'TabPageMateriales
        '
        Me.TabPageMateriales.Controls.Add(Me.GridMateriales)
        Me.TabPageMateriales.Key = "TabPageMateriales"
        Me.TabPageMateriales.Location = New System.Drawing.Point(1, 1)
        Me.TabPageMateriales.Name = "TabPageMateriales"
        Me.TabPageMateriales.Size = New System.Drawing.Size(648, 186)
        Me.TabPageMateriales.TabStop = True
        Me.TabPageMateriales.Text = "Materiales"
        '
        'GridMateriales
        '
        Me.GridMateriales.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IdProveedor", "Proveedor", "IdProveedor")})
        Me.GridMateriales.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridMateriales.CheckFields = New Solmicro.Expertis.Engine.UI.CheckFields(New Solmicro.Expertis.Engine.UI.CheckField() {New Solmicro.Expertis.Engine.UI.CheckField("CantidadMarca1", "Cantidad", Solmicro.Expertis.Engine.UI.CheckFieldType.Numeric, "Pendiente"), New Solmicro.Expertis.Engine.UI.CheckField("FechaTopeResp", "Fecha Tope Resp.", Solmicro.Expertis.Engine.UI.CheckFieldType.DateTime, "")})
        GridMateriales_DesignTimeLayout.LayoutString = resources.GetString("GridMateriales_DesignTimeLayout.LayoutString")
        Me.GridMateriales.DesignTimeLayout = GridMateriales_DesignTimeLayout
        Me.GridMateriales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridMateriales.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridMateriales.EntityName = "ObraMaterial"
        Me.GridMateriales.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridMateriales.KeyField = "IDLineaMaterial"
        Me.GridMateriales.Location = New System.Drawing.Point(0, 0)
        Me.GridMateriales.Name = "GridMateriales"
        Me.GridMateriales.PrimaryDataFields = Nothing
        Me.GridMateriales.SecondaryDataFields = ""
        Me.GridMateriales.Size = New System.Drawing.Size(648, 186)
        Me.GridMateriales.TabIndex = 0
        Me.GridMateriales.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridMateriales.UseCheck = True
        Me.GridMateriales.ViewName = "VFrmMntoObraGeneraCompra"
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
        'CIGenerarCompras
        '
        Me.AllowUpdate = True
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(679, 439)
        Me.Name = "CIGenerarCompras"
        Me.Text = "Generación de Compras"
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        CType(Me.cbxEstadoObra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabGeneracionCompras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabGeneracionCompras.ResumeLayout(False)
        Me.TabPageTrabajos.ResumeLayout(False)
        CType(Me.GridTrabajos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageMateriales.ResumeLayout(False)
        CType(Me.GridMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Const cnREASIGNAPROVEEDOR As String = "Reasignación de Proveedores"
    Private Const cnPROGRAMAS As String = "Generación de Programa Compra"
    Private Const cnSOLICITUDES As String = "Generación de Solicitud Compra"
    Private Const cnPEDIDOS As String = "Generación de Pedido Compra"
    Private Const cnOFERTAS As String = "Generación de Ofertas de Compra"

    Private BlnCambio As Boolean = False

    Private Enum enumAccion
        ReasignaProveedores
        PedidoCompra
        SolicitudCompra
        ProgramaCompra
        OfertaCompra
    End Enum

#Region " Load "

    Private Sub CIGenerarCompras_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TabGeneracionCompras.TabPages("TabPageMateriales").Selected = True
        LoadToolbarActions()
        LoadGridActions()
        LoadEnums()
        InitFilterCriteria()
        LoadParams()
    End Sub

    Private Sub LoadToolbarActions()
        Me.FormActions.Add(cnREASIGNAPROVEEDOR, AddressOf AccionAsignaProveedor, ExpertisApp.GetIcon("xProveedores.ico"))
        Me.AddSeparator()
        Me.FormActions.Add(cnPROGRAMAS, AddressOf AccionProcesoProgramaCompra, ExpertisApp.GetIcon("xProgramasComer.ico"))
        Me.FormActions.Add(cnSOLICITUDES, AddressOf AccionSolicitudCompra, ExpertisApp.GetIcon("xSolicitudes.ico"))
        Me.FormActions.Add(cnOFERTAS, AddressOf AccionOfertasCompra, ExpertisApp.GetIcon("xConceptos.ico"))
        Me.FormActions.Add(cnPEDIDOS, AddressOf AccionProcesoPedidoCompra, ExpertisApp.GetIcon("xPedidoCompra.ico"))
    End Sub

    Private Sub LoadEnums()
        Me.cbxEstadoObra.DataSource = New EnumData("enumocEstado")
    End Sub

    Private Sub LoadParams()
        If Not IsNothing(Me.Params) Then
            Dim ht As Hashtable = Me.Params
            AdvObra.Value = ht("IDObra")
            AdvObra.Text = ht("NObra")
            AdvTrabajo.Value = ht("IDTrabajo")
            AdvTrabajo.Text = ht("CodTrabajo")

            Me.Execute()
        End If
    End Sub

    Private Sub InitFilterCriteria()
        Me.AdvObra.Value = Nothing
        Me.AdvTrabajo.Value = Nothing
        Me.cbxEstadoObra.Value = Nothing
        Me.AdvProveedor.Value = Nothing
        Me.AdvMaterial.Value = Nothing
        Me.AdvTipo.Value = Nothing
        Me.AdvFamilia.Value = Nothing
        Me.cbxFechaDesde.Value = Nothing
        Me.cbxFechaHasta.Value = Nothing
        txtPendiente.Value = 0
    End Sub

#End Region

#Region " Toolbar Actions "

    Private Function ComprobarGrid(ByVal DgDatos As Solmicro.Expertis.Engine.UI.Grid) As Boolean
        If Me.RecordsState <> RecordsState.Saved Then
            If ExpertisApp.GenerateMessage("Los datos en pantalla no han sido guardados. ¿Desea guardar los datos para poder continuar.?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim Grid As Solmicro.Expertis.Engine.UI.Grid = GridActivo()
                Me.UiCommandManager1.CommandBars(0).Commands("OK").InvokeOnClick()
                Me.RecordsState = RecordsState.Saved
                Return True
            Else
                Return False
            End If
        Else
            Return True
        End If
    End Function

    Private Sub AccionAsignaProveedor()
        Dim Grid As Solmicro.Expertis.Engine.UI.Grid = GridActivo()
        If Grid.CheckedRecordsCount > 0 Then
            Dim dtMarcados As DataTable = Me.CheckedRecords
            If ComprobarGrid(Grid) Then
                If Not dtMarcados Is Nothing AndAlso dtMarcados.Rows.Count > 0 Then
                    dtMarcados = TratarLineasMarcadas(dtMarcados, enumAccion.ReasignaProveedores)
                    If Not dtMarcados Is Nothing AndAlso dtMarcados.Rows.Count > 0 Then
                        Me.Cursor = Cursors.WaitCursor
                        Dim strSinProv As String = ExpertisApp.ExecuteTask(Of DataTable, String)(AddressOf ArticuloProveedor.ProveedorPredeterminadoArticuloDt, dtMarcados)
                        If Length(strSinProv) > 0 Then
                            ExpertisApp.GenerateMessage("Los Artículos '|' no tienen un proveedor predeterminado. Rellene el Proveedor en la consulta.", MessageBoxButtons.OK, MessageBoxIcon.Information, strSinProv)
                        Else
                            ExpertisApp.GenerateMessage("Asignación de Proveedores finalizada correctamente.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                        Me.UnCheckAllRecords()
                        Me.Execute()

                        Me.Cursor = Cursors.Default
                    Else
                        ExpertisApp.GenerateMessage("Todas las líneas tienen un Proveedor asignado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            End If
        Else
            ExpertisApp.GenerateMessage("Debe seleccionar alguna fila.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Function TratarLineasMarcadas(ByVal dtMarcados As DataTable, ByVal intAccion As enumAccion, _
                                          Optional ByRef blnQNegativa As Boolean = False, _
                                          Optional ByRef blnFechaVacia As Boolean = False) As DataTable

        Dim Grid As Solmicro.Expertis.Engine.UI.Grid = GridActivo()
        Dim dvGrid As New DataView(CType(Grid.DataSource, DataTable).Copy)
        For Each dr As DataRow In dtMarcados.Select
            If Grid.EntityName = "ObraMaterial" Then
                dvGrid.RowFilter = "IDLineaMaterial=" & dr("IDLineaMaterial")
            Else
                dvGrid.RowFilter = "IDTrabajo=" & dr("IDTrabajo")
            End If
            If Length(dr("IDProveedor")) = 0 Then
                dr("IDProveedor") = dvGrid(0).Row("IDProveedor")
                dr("IDFormaPago") = dvGrid(0).Row("IDFormaPago")
                dr("IDCondicionPago") = dvGrid(0).Row("IDCondicionPago")
                dr("IDDiaPago") = dvGrid(0).Row("IDDiaPago")
                dr("IDMoneda") = dvGrid(0).Row("IDMoneda")
                dr("IDTipoIva") = dvGrid(0).Row("IDTipoIva")
            End If
            Select Case intAccion
                Case enumAccion.ReasignaProveedores
                    If Length(dr("IDProveedor")) > 0 Then dtMarcados.Rows.Remove(dr)
                Case enumAccion.PedidoCompra
                    If Nz(dr("CantidadMarca1")) = 0 Or Length(dr("IDProveedor")) = 0 Then
                        dtMarcados.Rows.Remove(dr)
                    ElseIf dr("CantidadMarca1") < 0 Then
                        blnQNegativa = True
                    End If
                Case enumAccion.ProgramaCompra
                    If Length(dr("FechaEntrega")) = 0 Then dr("FechaEntrega") = dvGrid(0).Row("FechaEntrega")
                    If Length(dr("FechaEntrega")) = 0 Then dr("FechaEntrega") = cbxFechaEntrega.Value
                    blnFechaVacia = Length(dr("FechaEntrega")) = 0
                    If Nz(dr("CantidadMarca1")) = 0 Or Length(dr("IDProveedor")) = 0 Or blnFechaVacia Then
                        dtMarcados.Rows.Remove(dr)
                    ElseIf dr("CantidadMarca1") < 0 Then
                        blnQNegativa = True
                    End If
                Case enumAccion.SolicitudCompra, enumAccion.OfertaCompra
                    If Length(dr("FechaEntrega")) = 0 Then dr("FechaEntrega") = dvGrid(0).Row("FechaEntrega")
                    If Length(dr("FechaEntrega")) = 0 Then dr("FechaEntrega") = cbxFechaEntrega.Value
                    If Length(dr("FechaTopeResp")) = 0 Then dr("FechaTopeResp") = dvGrid(0).Row("FechaTopeResp")
                    If Length(dr("FechaTopeResp")) = 0 Then dr("FechaTopeResp") = cbxFechaTopeResp.Value
                    blnFechaVacia = (Length(dr("FechaTopeResp")) = 0 Or Length(dr("FechaEntrega")) = 0)
                    If Nz(dr("CantidadMarca1")) = 0 Or blnFechaVacia Or (Length(dr("IDProveedor")) = 0 AndAlso intAccion = enumAccion.OfertaCompra) Then
                        dtMarcados.Rows.Remove(dr)
                    ElseIf dr("CantidadMarca1") < 0 Then
                        blnQNegativa = True
                    End If
            End Select
        Next
        Return dtMarcados
    End Function

    Private Sub AccionProcesoProgramaCompra()
        Dim Grid As Solmicro.Expertis.Engine.UI.Grid = GridActivo()
        If Grid.CheckedRecordsCount > 0 Then
            Dim dtMarcados As DataTable = Grid.CheckedRecords.Copy
            If Length(AdvOperario.Text) > 0 And Length(AdvCentroGestion.Value) > 0 Then
                If ComprobarGrid(Grid) Then
                    If Not dtMarcados Is Nothing AndAlso dtMarcados.Rows.Count > 0 Then
                        Dim intContMarcados As Integer = dtMarcados.Rows.Count
                        Dim blnQNegativa, blnFechaVacia As Boolean

                        dtMarcados = TratarLineasMarcadas(dtMarcados, enumAccion.ProgramaCompra, blnQNegativa, blnFechaVacia)
                        If Not dtMarcados Is Nothing AndAlso dtMarcados.Rows.Count > 0 Then
                            Dim diagResul As DialogResult
                            If intContMarcados <> dtMarcados.Rows.Count Then
                                diagResul = ExpertisApp.GenerateMessage("Se va a proceder a la Generación de Programas de Compra de las líneas seleccionadas. Las líneas sin Proveedor, con Fecha Entrega vacía, con cantidades vacías o con cero no se incluirán en el proceso. ¿Desea continuar?.", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                            Else
                                diagResul = ExpertisApp.GenerateMessage("Se va a proceder a la Generación de Programas de Compra de las líneas seleccionadas. ¿Desea continuar?.", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                            End If
                            If diagResul = DialogResult.Yes Then
                                Me.Cursor = Cursors.WaitCursor

                                Dim DatosCompra As New ProgramaCompraCabecera.DatosProgCompra
                                DatosCompra.Data = dtMarcados
                                DatosCompra.IDOperario = AdvOperario.Text
                                DatosCompra.IDCentroGestion = AdvCentroGestion.Value
                                DatosCompra.IDContador = AdvContador.Text

                                Dim dt As DataTable = ExpertisApp.ExecuteTask(Of ProgramaCompraCabecera.DatosProgCompra, DataTable)(AddressOf ProgramaCompraCabecera.CrearProgramaCompra, DatosCompra)

                                TratarResultado(dt, enumAccion.ProgramaCompra)
                                Me.UnCheckAllRecords()
                                Me.Execute()

                                Me.Cursor = Cursors.Default
                            End If
                        Else
                            ExpertisApp.GenerateMessage("Las líneas seleccionadas no tienen Proveedor, tienen las Fecha Entrega vacía o las cantidades están vacías o con 0.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) ' Las líneas sin Proveedor o con cantidades vacías o 0
                        End If
                    End If
                End If
            Else
                ExpertisApp.GenerateMessage("El Operario y el Centro Gestión son datos obligatorios.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            ExpertisApp.GenerateMessage("Debe seleccionar alguna fila.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub AccionSolicitudCompra()
        Dim Grid As Solmicro.Expertis.Engine.UI.Grid = GridActivo()
        If Grid.CheckedRecordsCount > 0 Then
            Dim dtMarcados As DataTable = Grid.CheckedRecords.Copy
            If Length(AdvOperario.Text) > 0 And Length(AdvCentroGestion.Value) > 0 Then
                If ComprobarGrid(Grid) Then
                    If Not dtMarcados Is Nothing AndAlso dtMarcados.Rows.Count > 0 Then
                        Dim intContMarcados As Integer = dtMarcados.Rows.Count
                        Dim blnQNegativa, blnFechaVacia As Boolean

                        dtMarcados = TratarLineasMarcadas(dtMarcados, enumAccion.SolicitudCompra, blnQNegativa, blnFechaVacia)
                        If Not dtMarcados Is Nothing AndAlso dtMarcados.Rows.Count > 0 Then
                            Dim diagResul As DialogResult
                            If intContMarcados <> dtMarcados.Rows.Count Then
                                diagResul = ExpertisApp.GenerateMessage("Se va a proceder a la Generación de Solicitudes de Compra de las líneas seleccionadas. Las líneas con la Fecha Tope Respuesta o de Entrega vacías o con cantidades vacías o con 0 no se incluirán en el proceso. ¿Desea continuar?.", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                            Else
                                diagResul = ExpertisApp.GenerateMessage("Se va a proceder a la Generación de Solicitudes de Compra de las líneas seleccionadas. ¿Desea continuar?.", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                            End If

                            If diagResul = DialogResult.Yes Then
                                Me.Cursor = Cursors.WaitCursor


                                Dim stData As New SolicitudCompraCabecera.DataCrearSolicitudCompra(dtMarcados, AdvOperario.Text, AdvCentroGestion.Text, AdvContador.Text)
                                Dim dt As DataTable = ExpertisApp.ExecuteTask(Of SolicitudCompraCabecera.DataCrearSolicitudCompra, DataTable)(AddressOf SolicitudCompraCabecera.CrearSolicitudCompra, stData)

                                TratarResultado(dt, enumAccion.SolicitudCompra)
                                Me.UnCheckAllRecords()
                                Me.Execute()

                                Me.Cursor = Cursors.Default
                            End If
                        Else
                            ExpertisApp.GenerateMessage("Las líneas seleccionadas no tienen Fecha Tope Respuesta o Fecha Entrega o las cantidades están vacías o con 0.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) ' Las líneas sin Proveedor o con cantidades vacías o 0
                        End If
                    End If
                End If
            Else
                ExpertisApp.GenerateMessage("El Operario y el Centro Gestión son datos obligatorios.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)  'El Operario y el Centro Gestión son datos obligatorios.
            End If
        Else
            ExpertisApp.GenerateMessage("Debe seleccionar alguna fila.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)  'Debe seleccionar alguna fila.
        End If
    End Sub

    Private Sub AccionOfertasCompra()
        Dim Grid As Solmicro.Expertis.Engine.UI.Grid = GridActivo()
        If Grid.CheckedRecordsCount > 0 Then
            Dim dtMarcados As DataTable = Grid.CheckedRecords.Copy
            If Length(AdvOperario.Text) > 0 And Length(AdvCentroGestion.Value) > 0 Then
                If ComprobarGrid(Grid) Then
                    If Not dtMarcados Is Nothing AndAlso dtMarcados.Rows.Count > 0 Then
                        Dim intContMarcados As Integer = dtMarcados.Rows.Count
                        Dim blnQNegativa, blnFechaVacia As Boolean

                        dtMarcados = TratarLineasMarcadas(dtMarcados, enumAccion.SolicitudCompra, blnQNegativa, blnFechaVacia)
                        If Not dtMarcados Is Nothing AndAlso dtMarcados.Rows.Count > 0 Then
                            Dim diagResul As DialogResult
                            If intContMarcados <> dtMarcados.Rows.Count Then
                                diagResul = ExpertisApp.GenerateMessage("Se va a proceder a la Generación de Ofertas de Compra de las líneas seleccionadas. Las líneas sin Proveedor, con la Fecha Tope Respuesta o de Entrega vacías o con cantidades vacías o con 0 no se incluirán en el proceso. ¿Desea continuar?.", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                            Else
                                diagResul = ExpertisApp.GenerateMessage("Se va a proceder a la Generación de Ofertas de Compra de las líneas seleccionadas. ¿Desea continuar?.", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                            End If
                            If diagResul = DialogResult.Yes Then
                                Me.Cursor = Cursors.WaitCursor

                                Dim OrigenOC(-1) As DataProy
                                For Each dr As DataRow In dtMarcados.Rows
                                    Dim origen As DataProy
                                    If TabGeneracionCompras.SelectedTab.Key = "TabPageMateriales" Then
                                        origen = New DataProy(dr("IDTrabajo"), dr("IDLineaMaterial"), dr("CantidadMarca1"), dr("FechaTopeResp"))
                                    Else
                                        origen = New DataProy(dr("IDTrabajo"), dr("CantidadMarca1"), CDate(dr("FechaTopeResp")))
                                    End If

                                    ReDim Preserve OrigenOC(OrigenOC.Length)
                                    OrigenOC(OrigenOC.Length - 1) = origen
                                Next

                                Dim datosOC As New DataPrcCreacionOfertaCompraProy(OrigenOC, AdvContador.Text, AdvOperario.Text, AdvCentroGestion.Value, IIf(Length(Me.cbxFechaEntrega.Value) > 0, Me.cbxFechaEntrega.Value, cnMinDate))
                                Dim log As LogProcess = New BE.DataEngine().RunProcess(GetType(PrcCrearOfertaProy), datosOC)
                                TratarLog(log, enumTipoDocumentoCreado.OfertaCompra, True, True)

                                Me.UnCheckAllRecords()
                                Me.Execute()

                                Me.Cursor = Cursors.Default
                            End If
                        Else
                            ExpertisApp.GenerateMessage("Las líneas seleccionadas no tienen Fecha Tope Respuesta o Fecha Entrega o las cantidades están vacías o con 0.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) ' Las líneas sin Proveedor o con cantidades vacías o 0
                        End If
                    End If
                End If
            Else
                ExpertisApp.GenerateMessage("El Operario y el Centro Gestión son datos obligatorios.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)  'El Operario y el Centro Gestión son datos obligatorios.
            End If
        Else
            ExpertisApp.GenerateMessage("Debe seleccionar alguna fila.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)  'Debe seleccionar alguna fila.
        End If
    End Sub

    Private Sub AccionProcesoPedidoCompra()
        Dim Grid As Solmicro.Expertis.Engine.UI.Grid = GridActivo()
        If Grid.CheckedRecordsCount > 0 Then
            Dim dtMarcados As DataTable = Grid.CheckedRecords.Copy
            If ComprobarGrid(Grid) Then
                If Not dtMarcados Is Nothing AndAlso dtMarcados.Rows.Count > 0 Then
                    Dim intContMarcados As Integer = dtMarcados.Rows.Count
                    Dim blnQNegativa As Boolean

                    dtMarcados = TratarLineasMarcadas(dtMarcados, enumAccion.PedidoCompra, blnQNegativa)
                    If Not dtMarcados Is Nothing AndAlso dtMarcados.Rows.Count > 0 Then
                        Dim diagResul As DialogResult
                        If intContMarcados <> dtMarcados.Rows.Count Then
                            diagResul = ExpertisApp.GenerateMessage("Se va a proceder a la Generación de Pedidos de Compra de las líneas seleccionadas. Las líneas sin Proveedor o con cantidades vacías o 0 no se incluirán en el proceso. ¿Desea continuar?.", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        Else
                            diagResul = ExpertisApp.GenerateMessage("Se va a proceder a la Generación de Pedidos de Compra de las líneas seleccionadas. ¿Desea continuar?.", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        End If
                        If diagResul = DialogResult.Yes Then
                            Me.Cursor = Cursors.WaitCursor
                            Dim OrigenPC(-1) As DataOrigenPC
                            For Each dr As DataRow In dtMarcados.Rows
                                Dim origen As New DataOrigenPC(dr(Grid.KeyField), dr("CantidadMarca1"))
                                ReDim Preserve OrigenPC(OrigenPC.Length)
                                OrigenPC(OrigenPC.Length - 1) = origen
                            Next
                            Dim datosPC As New DataPrcCrearPedidoCompraObras(OrigenPC, AdvContador.Text, AdvOperario.Text, (Grid Is GridTrabajos), (Grid Is GridMateriales), Nz(cbxFechaEntrega.Value, Today))
                            Dim log As LogProcess = New BE.DataEngine().RunProcess(GetType(PrcCrearPedidoCompraObras), datosPC)
                            TratarLog(log, enumTipoDocumentoCreado.PedidoCompra, True, True)

                            Me.UnCheckAllRecords()
                            Me.Execute()

                            Me.Cursor = Cursors.Default
                        End If
                    Else
                        ExpertisApp.GenerateMessage("Las líneas seleccionadas no tienen Proveedor o las cantidades están vacías o 0.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) ' Las líneas sin Proveedor o con cantidades vacías o 0
                    End If
                End If
            End If
        Else
            ExpertisApp.GenerateMessage("Debe seleccionar alguna fila.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)  'Debe seleccionar alguna fila.
        End If
    End Sub

    Private Sub TratarResultado(ByVal dt As DataTable, ByVal intAccion As enumAccion)
        Dim strMensaje As String = String.Empty
        Dim strMensajeNinguno As String = String.Empty
        Dim strID As String = String.Empty
        Dim strN As String = String.Empty
        Dim strCampoID As String = String.Empty
        Dim strCampoN As String = String.Empty
        Dim strPrograma As String = String.Empty

        Select Case intAccion
            Case enumAccion.ProgramaCompra
                strCampoID = "IDPrograma" : strCampoN = "IDPrograma" : strPrograma = "MNTPROGCOMP"

                If Not IsNothing(dt) AndAlso dt.Rows.Count > 0 Then
                    If dt.Rows.Count = 1 Then
                        strMensaje = "Se ha generado el Programa Nº |. ¿Desea cargar el mantenimiento?"
                    Else
                        strMensaje = "Se han generado los Programas Nº |. ¿Desea cargar el mantenimiento?"
                    End If
                Else
                    strMensajeNinguno = "No se ha generado ningún Programa."
                End If
            Case enumAccion.SolicitudCompra
                strCampoID = "IDSolicitud" : strCampoN = "IDSolicitud" : strPrograma = "MNTOSOLICI"

                If Not IsNothing(dt) AndAlso dt.Rows.Count > 0 Then
                    If dt.Rows.Count = 1 Then
                        strMensaje = "Se ha generado la Solicitud de Compra Nº |. ¿Desea cargar el mantenimiento?"
                    Else
                        strMensaje = "Se han generado las Solicitudes de Compra Nº |. ¿Desea cargar el mantenimiento?"
                    End If
                Else
                    strMensajeNinguno = "No se ha generado ninguna Solicitud de Compra."
                End If
            Case enumAccion.OfertaCompra
                strCampoID = "IDOferta" : strCampoN = "IDOferta" : strPrograma = "MNTOOFCOMP"
                If Not IsNothing(dt) AndAlso dt.Rows.Count > 0 Then
                    If dt.Rows.Count = 1 Then
                        strMensaje = "Se ha generado la Oferta de Compra Nº |. ¿Desea cargar el mantenimiento?"
                    Else
                        strMensaje = "Se han generado las Ofertas de Compra Nº |. ¿Desea cargar el mantenimiento?"
                    End If
                Else
                    strMensajeNinguno = "No se ha generado ninguna Oferta de Compra."
                End If
        End Select

        If Length(strMensajeNinguno) = 0 Then
            For Each dr As DataRow In dt.Select
                If Length(strID) = 0 Then strID = dr(strCampoID)
                If Length(strN) > 0 Then strN = strN & ","
                strN = strN & dr(strCampoN)
            Next

            If ExpertisApp.GenerateMessage(strMensaje, MessageBoxButtons.YesNo, MessageBoxIcon.Information, strN) = DialogResult.Yes Then
                ExpertisApp.OpenForm(strPrograma, New FilterItem(strCampoID, strID))
            End If
        Else
            ExpertisApp.GenerateMessage(strMensajeNinguno, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

#End Region

#Region " Grid Actions "

    Private Sub LoadGridActions()
        GridMateriales.Actions.Add("Abrir Proyecto", AddressOf AccionAbrirObra, ExpertisApp.GetIcon("xProyectos.ico"))
        GridTrabajos.Actions.Add("Abrir Proyecto", AddressOf AccionAbrirObra, ExpertisApp.GetIcon("xProyectos.ico"))
    End Sub

    Private Sub AccionAbrirObra()
        ExpertisApp.OpenForm("MGEO", New FilterItem("IDObra", FilterOperator.Equal, GridActivo.GetValue("IDObra")))
    End Sub

#End Region

#Region " QueryExecute "

    Private Sub CIGenerarCompras_FilterClearing(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.FilterClearing
        InitFilterCriteria()
    End Sub

    Private Sub CIGenerarCompras_QueryExecuting(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        If IsNothing(Me.CIPrimaryObject) Then
            Me.CIPrimaryObject = GridActivo()
        End If

        e.Filter.Add("IDObra", FilterOperator.Equal, AdvObra.Value, FilterType.Numeric)
        e.Filter.Add("IDTrabajo", FilterOperator.Equal, AdvTrabajo.Value, FilterType.Numeric)
        e.Filter.Add("IDProveedor", FilterOperator.Equal, AdvProveedor.Text, FilterType.String)
        e.Filter.Add("IDArticulo", FilterOperator.Equal, AdvMaterial.Text, FilterType.String)
        e.Filter.Add("IDTipo", FilterOperator.Equal, AdvTipo.Text, FilterType.String)
        e.Filter.Add("IDFamilia", FilterOperator.Equal, AdvFamilia.Text, FilterType.String)
        e.Filter.Add("FechaObra", FilterOperator.GreaterThanOrEqual, cbxFechaDesde.Value, FilterType.DateTime)
        e.Filter.Add("FechaObra", FilterOperator.LessThanOrEqual, cbxFechaHasta.Value, FilterType.DateTime)
        e.Filter.Add("Pendiente", FilterOperator.GreaterThan, txtPendiente.Value, FilterType.Numeric)
        e.Filter.Add("Estado", FilterOperator.Equal, cbxEstadoObra.Value, FilterType.Numeric)
    End Sub

#End Region

    Private Sub TabGeneracionCompras_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabGeneracionCompras.Click
        Me.CIPrimaryObject = GridActivo()
    End Sub

    Private Function GridActivo() As Solmicro.Expertis.Engine.UI.Grid
        Dim Grid As Solmicro.Expertis.Engine.UI.Grid
        Select Case TabGeneracionCompras.SelectedTab.Key
            Case "TabPageMateriales"
                Grid = GridMateriales
            Case "TabPageTrabajos"
                Grid = GridTrabajos
        End Select
        Return Grid
    End Function

    Private Sub AdvTrabajo_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles AdvTrabajo.SetPredefinedFilter
        If Length(AdvObra.Value) > 0 Then
            e.Filter.Add("IDObra", FilterOperator.Equal, AdvObra.Value, FilterType.Numeric)
        End If
    End Sub

    Private Sub AdvFamilia_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles AdvFamilia.SetPredefinedFilter
        If AdvTipo.TextLength > 0 Then
            e.Filter.Add(New StringFilterItem("IdTipo", AdvTipo.Text))
        End If
    End Sub

    Private Sub ShowFilterPanel1_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles ShowFilterPanel1.Click
        FilterPanel.Visible = Not FilterPanel.Visible
    End Sub

    Private Sub GridMateriales_CellUpdated(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles GridMateriales.CellUpdated, GridTrabajos.CellUpdated
        Select Case e.Column.Key
            Case "CantidadMarca1", "FechaTopeResp"
                If BlnCambio Then
                    Me.UiCommandManager1.CommandBars(0).Commands("OK").IsEnabled = False
                    Me.UiCommandManager1.CommandBars(0).Commands("Cancel").IsEnabled = False
                    BlnCambio = False
                End If
            Case Else
                Me.UiCommandManager1.CommandBars(0).Commands("OK").IsEnabled = True
                Me.UiCommandManager1.CommandBars(0).Commands("Cancel").IsEnabled = True
        End Select
    End Sub

    Private Sub GridMateriales_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles GridMateriales.FormattingRow
        If Length(e.Row.Cells("EstadoOferProgSol").Value) > 0 Then
            e.Row.RowStyle = GridMateriales.FormatStyles(0)
        End If
    End Sub

    Private Sub GridMateriales_UpdatingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles GridMateriales.UpdatingCell, GridTrabajos.UpdatingCell
        Select Case e.Column.Key
            Case "CantidadMarca1", "FechaTopeResp"
                If Me.RecordsState = RecordsState.Saved Then BlnCambio = True
        End Select
    End Sub

    Private Sub CIGenerarCompras_RecordStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.RecordStateChanged
        If Me.RecordsState = RecordsState.Saved Then
            Me.UiCommandManager1.CommandBars(0).Commands("OK").IsEnabled = False
            Me.UiCommandManager1.CommandBars(0).Commands("Cancel").IsEnabled = False
        End If
    End Sub

    Private Sub AdvContador_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles AdvContador.SetPredefinedFilter
        Dim f As New Filter(FilterUnionOperator.Or)
        f.Add("Entidad", FilterOperator.Equal, GetType(PedidoCompraCabecera).Name, FilterType.String)
        f.Add("Entidad", FilterOperator.Equal, GetType(ProgramaCompraCabecera).Name, FilterType.String)
        f.Add("Entidad", FilterOperator.Equal, GetType(SolicitudCompraCabecera).Name, FilterType.String)
        f.Add("Entidad", FilterOperator.Equal, GetType(OfertaCabecera).Name, FilterType.String)
        e.Filter.Add(f)
    End Sub

End Class