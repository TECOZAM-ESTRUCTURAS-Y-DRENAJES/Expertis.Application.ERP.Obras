Public Class CIActualizarPrecios
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
    Friend WithEvents ShowFilterCritria As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents ShowFilterCritria1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents FilterPanel As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents pnlArticulo As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents lblFamilia As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvTipo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvFamilia As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvArticulo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblArticulo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblTipo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents pnlObra As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents lblIDObra As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvIDObra As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents pnlTrabajo As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents lblIDTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvTrabajo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents pnlFecha As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents cFechaInicioHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cFechaInicioDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents TabActualizacionPrecios As Solmicro.Expertis.Engine.UI.Tab
    Friend WithEvents TabPageTrabajos As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents GridTrabajos As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents TabPageMateriales As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents GridMateriales As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents TabPageMOD As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents GridMod As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents TabPageCentros As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents GridCentros As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents TabPageGastos As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents GridGastos As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents TabPageVarios As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents lblIDCliente As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvIDCliente As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents GridVarios As Solmicro.Expertis.Engine.UI.Grid

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIActualizarPrecios))
        Dim GridTrabajos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridMateriales_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridMod_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridCentros_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridGastos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridVarios_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.ShowFilterCritria = New Janus.Windows.UI.CommandBars.UICommand("ShowFilterCritria")
        Me.ShowFilterCritria1 = New Janus.Windows.UI.CommandBars.UICommand("ShowFilterCritria")
        Me.FilterPanel = New Solmicro.Expertis.Engine.UI.Frame
        Me.pnlObra = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblIDObra = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDObra = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.pnlTrabajo = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblIDTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvTrabajo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.pnlFecha = New Solmicro.Expertis.Engine.UI.Panel
        Me.cFechaInicioHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.cFechaInicioDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.pnlArticulo = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblFamilia = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvTipo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.AdvFamilia = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.AdvArticulo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblArticulo = New Solmicro.Expertis.Engine.UI.Label
        Me.lblTipo = New Solmicro.Expertis.Engine.UI.Label
        Me.TabActualizacionPrecios = New Solmicro.Expertis.Engine.UI.Tab
        Me.TabPageTrabajos = New Janus.Windows.UI.Tab.UITabPage
        Me.GridTrabajos = New Solmicro.Expertis.Engine.UI.Grid
        Me.TabPageMateriales = New Janus.Windows.UI.Tab.UITabPage
        Me.GridMateriales = New Solmicro.Expertis.Engine.UI.Grid
        Me.TabPageMOD = New Janus.Windows.UI.Tab.UITabPage
        Me.GridMod = New Solmicro.Expertis.Engine.UI.Grid
        Me.TabPageCentros = New Janus.Windows.UI.Tab.UITabPage
        Me.GridCentros = New Solmicro.Expertis.Engine.UI.Grid
        Me.TabPageGastos = New Janus.Windows.UI.Tab.UITabPage
        Me.GridGastos = New Solmicro.Expertis.Engine.UI.Grid
        Me.TabPageVarios = New Janus.Windows.UI.Tab.UITabPage
        Me.GridVarios = New Solmicro.Expertis.Engine.UI.Grid
        Me.lblIDCliente = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDCliente = New Solmicro.Expertis.Engine.UI.AdvSearch
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        Me.FilterPanel.SuspendLayout()
        Me.pnlObra.suspendlayout()
        Me.pnlTrabajo.suspendlayout()
        Me.pnlFecha.suspendlayout()
        Me.pnlArticulo.suspendlayout()
        CType(Me.TabActualizacionPrecios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabActualizacionPrecios.SuspendLayout()
        Me.TabPageTrabajos.SuspendLayout()
        CType(Me.GridTrabajos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageMateriales.SuspendLayout()
        CType(Me.GridMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageMOD.SuspendLayout()
        CType(Me.GridMod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageCentros.SuspendLayout()
        CType(Me.GridCentros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageGastos.SuspendLayout()
        CType(Me.GridGastos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageVarios.SuspendLayout()
        CType(Me.GridVarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UiCommandManager1
        '
        Me.UiCommandManager1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.ShowFilterCritria})
        '
        'Toolbar
        '
        Me.Toolbar.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.ShowFilterCritria1})
        Me.Toolbar.Size = New System.Drawing.Size(321, 28)
        '
        'Menubar
        '
        Me.Menubar.Location = New System.Drawing.Point(0, 28)
        '
        'MainPanel
        '
        Me.MainPanel.Controls.Add(Me.TabActualizacionPrecios)
        Me.MainPanel.Controls.Add(Me.FilterPanel)
        Me.MainPanel.Size = New System.Drawing.Size(764, 365)
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(764, 365)
        '
        'ShowFilterCritria
        '
        Me.ShowFilterCritria.Image = CType(resources.GetObject("ShowFilterCritria.Image"), System.Drawing.Image)
        Me.ShowFilterCritria.Key = "ShowFilterCritria"
        Me.ShowFilterCritria.Name = "ShowFilterCritria"
        Me.ShowFilterCritria.Text = "Ver Criterios"
        '
        'ShowFilterCritria1
        '
        Me.ShowFilterCritria1.Key = "ShowFilterCritria"
        Me.ShowFilterCritria1.Name = "ShowFilterCritria1"
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.pnlObra)
        Me.FilterPanel.Controls.Add(Me.pnlFecha)
        Me.FilterPanel.Controls.Add(Me.pnlArticulo)
        Me.FilterPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FilterPanel.Location = New System.Drawing.Point(0, 261)
        Me.FilterPanel.Name = "FilterPanel"
        Me.FilterPanel.Size = New System.Drawing.Size(764, 104)
        Me.FilterPanel.TabIndex = 22
        Me.FilterPanel.TabStop = False
        Me.FilterPanel.Text = " Criterios de Selección  "
        '
        'pnlObra
        '
        Me.pnlObra.Controls.Add(Me.lblIDCliente)
        Me.pnlObra.Controls.Add(Me.AdvIDCliente)
        Me.pnlObra.Controls.Add(Me.lblIDObra)
        Me.pnlObra.Controls.Add(Me.AdvIDObra)
        Me.pnlObra.Controls.Add(Me.pnlTrabajo)
        Me.pnlObra.Location = New System.Drawing.Point(32, 16)
        Me.pnlObra.Name = "pnlObra"
        Me.pnlObra.Size = New System.Drawing.Size(178, 79)
        Me.pnlObra.TabIndex = 11
        '
        'lblIDObra
        '
        Me.lblIDObra.Location = New System.Drawing.Point(8, 8)
        Me.lblIDObra.Name = "lblIDObra"
        Me.lblIDObra.Size = New System.Drawing.Size(57, 13)
        Me.lblIDObra.TabIndex = 0
        Me.lblIDObra.Text = "Proyecto"
        '
        'AdvIDObra
        '
        Me.AdvIDObra.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDObra.DisplayField = "NObra"
        Me.AdvIDObra.EntityName = "Obracabecera"
        Me.AdvIDObra.Location = New System.Drawing.Point(71, 3)
        Me.AdvIDObra.Name = "AdvIDObra"
        Me.AdvIDObra.SecondaryDataFields = "IDObra"
        Me.AdvIDObra.Size = New System.Drawing.Size(90, 23)
        Me.AdvIDObra.TabIndex = 0
        '
        'pnlTrabajo
        '
        Me.pnlTrabajo.AccessibleName = "5"
        Me.pnlTrabajo.Controls.Add(Me.lblIDTrabajo)
        Me.pnlTrabajo.Controls.Add(Me.AdvTrabajo)
        Me.pnlTrabajo.Location = New System.Drawing.Point(0, 24)
        Me.pnlTrabajo.Name = "pnlTrabajo"
        Me.pnlTrabajo.Size = New System.Drawing.Size(178, 28)
        Me.pnlTrabajo.TabIndex = 18
        '
        'lblIDTrabajo
        '
        Me.lblIDTrabajo.Location = New System.Drawing.Point(8, 8)
        Me.lblIDTrabajo.Name = "lblIDTrabajo"
        Me.lblIDTrabajo.Size = New System.Drawing.Size(50, 13)
        Me.lblIDTrabajo.TabIndex = 3
        Me.lblIDTrabajo.Text = "Trabajo"
        '
        'AdvTrabajo
        '
        Me.AdvTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvTrabajo.DisplayField = "CodTrabajo"
        Me.AdvTrabajo.EntityName = "ObraTrabajo"
        Me.AdvTrabajo.Location = New System.Drawing.Point(71, 3)
        Me.AdvTrabajo.Name = "AdvTrabajo"
        Me.AdvTrabajo.SecondaryDataFields = "IDTrabajo"
        Me.AdvTrabajo.Size = New System.Drawing.Size(90, 23)
        Me.AdvTrabajo.TabIndex = 1
        '
        'pnlFecha
        '
        Me.pnlFecha.Controls.Add(Me.cFechaInicioHasta)
        Me.pnlFecha.Controls.Add(Me.lblFechaDesde)
        Me.pnlFecha.Controls.Add(Me.cFechaInicioDesde)
        Me.pnlFecha.Controls.Add(Me.lblFechaHasta)
        Me.pnlFecha.Location = New System.Drawing.Point(219, 16)
        Me.pnlFecha.Name = "pnlFecha"
        Me.pnlFecha.Size = New System.Drawing.Size(221, 64)
        Me.pnlFecha.TabIndex = 17
        '
        'cFechaInicioHasta
        '
        Me.cFechaInicioHasta.CustomFormat = "dd/MM/yy"
        Me.cFechaInicioHasta.DisabledBackColor = System.Drawing.Color.White
        Me.cFechaInicioHasta.Location = New System.Drawing.Point(124, 29)
        Me.cFechaInicioHasta.Name = "cFechaInicioHasta"
        Me.cFechaInicioHasta.Size = New System.Drawing.Size(88, 21)
        Me.cFechaInicioHasta.TabIndex = 13
        '
        'lblFechaDesde
        '
        Me.lblFechaDesde.Location = New System.Drawing.Point(7, 8)
        Me.lblFechaDesde.Name = "lblFechaDesde"
        Me.lblFechaDesde.Size = New System.Drawing.Size(115, 13)
        Me.lblFechaDesde.TabIndex = 14
        Me.lblFechaDesde.Text = "Fecha Inicio Desde"
        '
        'cFechaInicioDesde
        '
        Me.cFechaInicioDesde.CustomFormat = "dd/MM/yy"
        Me.cFechaInicioDesde.DisabledBackColor = System.Drawing.Color.White
        Me.cFechaInicioDesde.Location = New System.Drawing.Point(124, 5)
        Me.cFechaInicioDesde.Name = "cFechaInicioDesde"
        Me.cFechaInicioDesde.Size = New System.Drawing.Size(88, 21)
        Me.cFechaInicioDesde.TabIndex = 12
        '
        'lblFechaHasta
        '
        Me.lblFechaHasta.Location = New System.Drawing.Point(7, 32)
        Me.lblFechaHasta.Name = "lblFechaHasta"
        Me.lblFechaHasta.Size = New System.Drawing.Size(111, 13)
        Me.lblFechaHasta.TabIndex = 15
        Me.lblFechaHasta.Text = "Fecha Inicio Hasta"
        '
        'pnlArticulo
        '
        Me.pnlArticulo.Controls.Add(Me.lblFamilia)
        Me.pnlArticulo.Controls.Add(Me.AdvTipo)
        Me.pnlArticulo.Controls.Add(Me.AdvFamilia)
        Me.pnlArticulo.Controls.Add(Me.AdvArticulo)
        Me.pnlArticulo.Controls.Add(Me.lblArticulo)
        Me.pnlArticulo.Controls.Add(Me.lblTipo)
        Me.pnlArticulo.Location = New System.Drawing.Point(448, 16)
        Me.pnlArticulo.Name = "pnlArticulo"
        Me.pnlArticulo.Size = New System.Drawing.Size(216, 80)
        Me.pnlArticulo.TabIndex = 12
        '
        'lblFamilia
        '
        Me.lblFamilia.Location = New System.Drawing.Point(16, 56)
        Me.lblFamilia.Name = "lblFamilia"
        Me.lblFamilia.Size = New System.Drawing.Size(95, 13)
        Me.lblFamilia.TabIndex = 9
        Me.lblFamilia.Text = "Familia Material"
        '
        'AdvTipo
        '
        Me.AdvTipo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvTipo.EntityName = "TipoArticulo"
        Me.AdvTipo.Location = New System.Drawing.Point(120, 27)
        Me.AdvTipo.Name = "AdvTipo"
        Me.AdvTipo.SecondaryDataFields = "IDTipo"
        Me.AdvTipo.Size = New System.Drawing.Size(90, 23)
        Me.AdvTipo.TabIndex = 3
        '
        'AdvFamilia
        '
        Me.AdvFamilia.DisabledBackColor = System.Drawing.Color.White
        Me.AdvFamilia.EntityName = "Familia"
        Me.AdvFamilia.Location = New System.Drawing.Point(120, 51)
        Me.AdvFamilia.Name = "AdvFamilia"
        Me.AdvFamilia.SecondaryDataFields = "IDFamilia"
        Me.AdvFamilia.Size = New System.Drawing.Size(90, 23)
        Me.AdvFamilia.TabIndex = 4
        '
        'AdvArticulo
        '
        Me.AdvArticulo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvArticulo.EntityName = "Articulo"
        Me.AdvArticulo.Location = New System.Drawing.Point(120, 3)
        Me.AdvArticulo.Name = "AdvArticulo"
        Me.AdvArticulo.SecondaryDataFields = "IDArticulo"
        Me.AdvArticulo.Size = New System.Drawing.Size(90, 23)
        Me.AdvArticulo.TabIndex = 2
        '
        'lblArticulo
        '
        Me.lblArticulo.Location = New System.Drawing.Point(16, 8)
        Me.lblArticulo.Name = "lblArticulo"
        Me.lblArticulo.Size = New System.Drawing.Size(52, 13)
        Me.lblArticulo.TabIndex = 7
        Me.lblArticulo.Text = "Material"
        '
        'lblTipo
        '
        Me.lblTipo.Location = New System.Drawing.Point(16, 32)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(80, 13)
        Me.lblTipo.TabIndex = 8
        Me.lblTipo.Text = "Tipo Material"
        '
        'TabActualizacionPrecios
        '
        Me.TabActualizacionPrecios.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.TabActualizacionPrecios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabActualizacionPrecios.Location = New System.Drawing.Point(0, 0)
        Me.TabActualizacionPrecios.Name = "TabActualizacionPrecios"
        Me.TabActualizacionPrecios.Size = New System.Drawing.Size(764, 261)
        Me.TabActualizacionPrecios.TabIndex = 23
        Me.TabActualizacionPrecios.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.TabPageTrabajos, Me.TabPageMateriales, Me.TabPageMOD, Me.TabPageCentros, Me.TabPageGastos, Me.TabPageVarios})
        Me.TabActualizacionPrecios.TabStripAlignment = Janus.Windows.UI.Tab.TabStripAlignment.Right
        Me.TabActualizacionPrecios.Text = "Varios"
        Me.TabActualizacionPrecios.TextOrientation = Janus.Windows.UI.Tab.TextOrientation.Vertical
        Me.TabActualizacionPrecios.UseThemes = True
        '
        'TabPageTrabajos
        '
        Me.TabPageTrabajos.Controls.Add(Me.GridTrabajos)
        Me.TabPageTrabajos.Key = "Trabajos"
        Me.TabPageTrabajos.Location = New System.Drawing.Point(1, 1)
        Me.TabPageTrabajos.Name = "TabPageTrabajos"
        Me.TabPageTrabajos.Size = New System.Drawing.Size(741, 259)
        Me.TabPageTrabajos.TabStop = True
        Me.TabPageTrabajos.Text = "Trabajos"
        '
        'GridTrabajos
        '
        Me.GridTrabajos.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridTrabajos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridTrabajos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
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
        Me.GridTrabajos.PrimaryDataFields = ""
        Me.GridTrabajos.SecondaryDataFields = ""
        Me.GridTrabajos.Size = New System.Drawing.Size(741, 259)
        Me.GridTrabajos.TabIndex = 0
        Me.GridTrabajos.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridTrabajos.UseCheck = True
        Me.GridTrabajos.ViewName = "vCTLCIActualizarPreciosObraTrabajos"
        '
        'TabPageMateriales
        '
        Me.TabPageMateriales.Controls.Add(Me.GridMateriales)
        Me.TabPageMateriales.Key = "Materiales"
        Me.TabPageMateriales.Location = New System.Drawing.Point(1, 1)
        Me.TabPageMateriales.Name = "TabPageMateriales"
        Me.TabPageMateriales.Size = New System.Drawing.Size(741, 259)
        Me.TabPageMateriales.TabStop = True
        Me.TabPageMateriales.Text = "Materiales"
        Me.TabPageMateriales.Visible = False
        '
        'GridMateriales
        '
        Me.GridMateriales.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridMateriales.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridMateriales.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridMateriales_DesignTimeLayout.LayoutString = resources.GetString("GridMateriales_DesignTimeLayout.LayoutString")
        Me.GridMateriales.DesignTimeLayout = GridMateriales_DesignTimeLayout
        Me.GridMateriales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridMateriales.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridMateriales.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridMateriales.EntityName = "ObraMaterial"
        Me.GridMateriales.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridMateriales.KeyField = "IDLineaMaterial"
        Me.GridMateriales.Location = New System.Drawing.Point(0, 0)
        Me.GridMateriales.Name = "GridMateriales"
        Me.GridMateriales.PrimaryDataFields = Nothing
        Me.GridMateriales.SecondaryDataFields = Nothing
        Me.GridMateriales.Size = New System.Drawing.Size(741, 259)
        Me.GridMateriales.TabIndex = 0
        Me.GridMateriales.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridMateriales.UseCheck = True
        Me.GridMateriales.ViewName = "vCTLCIActualizarPreciosObraMateriales"
        '
        'TabPageMOD
        '
        Me.TabPageMOD.Controls.Add(Me.GridMod)
        Me.TabPageMOD.Key = "MOD"
        Me.TabPageMOD.Location = New System.Drawing.Point(1, 1)
        Me.TabPageMOD.Name = "TabPageMOD"
        Me.TabPageMOD.Size = New System.Drawing.Size(741, 259)
        Me.TabPageMOD.TabStop = True
        Me.TabPageMOD.Text = "MOD"
        Me.TabPageMOD.Visible = False
        '
        'GridMod
        '
        Me.GridMod.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridMod.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridMod.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridMod_DesignTimeLayout.LayoutString = resources.GetString("GridMod_DesignTimeLayout.LayoutString")
        Me.GridMod.DesignTimeLayout = GridMod_DesignTimeLayout
        Me.GridMod.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridMod.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridMod.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridMod.EntityName = "ObraMOD"
        Me.GridMod.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridMod.KeyField = "IDLineaMOD"
        Me.GridMod.Location = New System.Drawing.Point(0, 0)
        Me.GridMod.Name = "GridMod"
        Me.GridMod.PrimaryDataFields = Nothing
        Me.GridMod.SecondaryDataFields = Nothing
        Me.GridMod.Size = New System.Drawing.Size(741, 259)
        Me.GridMod.TabIndex = 31
        Me.GridMod.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridMod.UseCheck = True
        Me.GridMod.ViewName = "vCTLCIActualizarPreciosObraMOD"
        '
        'TabPageCentros
        '
        Me.TabPageCentros.Controls.Add(Me.GridCentros)
        Me.TabPageCentros.Key = "Centros"
        Me.TabPageCentros.Location = New System.Drawing.Point(1, 1)
        Me.TabPageCentros.Name = "TabPageCentros"
        Me.TabPageCentros.Size = New System.Drawing.Size(741, 259)
        Me.TabPageCentros.TabStop = True
        Me.TabPageCentros.Text = "Centros"
        Me.TabPageCentros.Visible = False
        '
        'GridCentros
        '
        Me.GridCentros.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridCentros.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridCentros.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridCentros_DesignTimeLayout.LayoutString = resources.GetString("GridCentros_DesignTimeLayout.LayoutString")
        Me.GridCentros.DesignTimeLayout = GridCentros_DesignTimeLayout
        Me.GridCentros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridCentros.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridCentros.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridCentros.EntityName = "ObraCentro"
        Me.GridCentros.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridCentros.KeyField = "IDLineaCentro"
        Me.GridCentros.Location = New System.Drawing.Point(0, 0)
        Me.GridCentros.Name = "GridCentros"
        Me.GridCentros.PrimaryDataFields = Nothing
        Me.GridCentros.SecondaryDataFields = Nothing
        Me.GridCentros.Size = New System.Drawing.Size(741, 259)
        Me.GridCentros.TabIndex = 32
        Me.GridCentros.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridCentros.UseCheck = True
        Me.GridCentros.ViewName = "vCTLCIActualizarPreciosObraCentros"
        '
        'TabPageGastos
        '
        Me.TabPageGastos.Controls.Add(Me.GridGastos)
        Me.TabPageGastos.Key = "Gastos"
        Me.TabPageGastos.Location = New System.Drawing.Point(1, 1)
        Me.TabPageGastos.Name = "TabPageGastos"
        Me.TabPageGastos.Size = New System.Drawing.Size(741, 259)
        Me.TabPageGastos.TabStop = True
        Me.TabPageGastos.Text = "Gastos"
        Me.TabPageGastos.Visible = False
        '
        'GridGastos
        '
        Me.GridGastos.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridGastos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridGastos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridGastos_DesignTimeLayout.LayoutString = resources.GetString("GridGastos_DesignTimeLayout.LayoutString")
        Me.GridGastos.DesignTimeLayout = GridGastos_DesignTimeLayout
        Me.GridGastos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridGastos.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridGastos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridGastos.EntityName = "ObraGasto"
        Me.GridGastos.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridGastos.KeyField = "IDLineaGasto"
        Me.GridGastos.Location = New System.Drawing.Point(0, 0)
        Me.GridGastos.Name = "GridGastos"
        Me.GridGastos.PrimaryDataFields = Nothing
        Me.GridGastos.SecondaryDataFields = Nothing
        Me.GridGastos.Size = New System.Drawing.Size(741, 259)
        Me.GridGastos.TabIndex = 2
        Me.GridGastos.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridGastos.UseCheck = True
        Me.GridGastos.ViewName = "vCTLCIActualizarPreciosObraGastos"
        '
        'TabPageVarios
        '
        Me.TabPageVarios.Controls.Add(Me.GridVarios)
        Me.TabPageVarios.Key = "Varios"
        Me.TabPageVarios.Location = New System.Drawing.Point(1, 1)
        Me.TabPageVarios.Name = "TabPageVarios"
        Me.TabPageVarios.Size = New System.Drawing.Size(741, 259)
        Me.TabPageVarios.TabStop = True
        Me.TabPageVarios.Text = "Varios"
        Me.TabPageVarios.Visible = False
        '
        'GridVarios
        '
        Me.GridVarios.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridVarios.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridVarios.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridVarios_DesignTimeLayout.LayoutString = resources.GetString("GridVarios_DesignTimeLayout.LayoutString")
        Me.GridVarios.DesignTimeLayout = GridVarios_DesignTimeLayout
        Me.GridVarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridVarios.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridVarios.EntityName = "ObraVarios"
        Me.GridVarios.KeyField = "IDLineaVarios"
        Me.GridVarios.Location = New System.Drawing.Point(0, 0)
        Me.GridVarios.Name = "GridVarios"
        Me.GridVarios.PrimaryDataFields = Nothing
        Me.GridVarios.SecondaryDataFields = Nothing
        Me.GridVarios.Size = New System.Drawing.Size(741, 259)
        Me.GridVarios.TabIndex = 34
        Me.GridVarios.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridVarios.UseCheck = True
        Me.GridVarios.ViewName = "vCTLCIActualizarPreciosObraVarios"
        '
        'lblIDCliente
        '
        Me.lblIDCliente.Location = New System.Drawing.Point(8, 57)
        Me.lblIDCliente.Name = "lblIDCliente"
        Me.lblIDCliente.Size = New System.Drawing.Size(47, 13)
        Me.lblIDCliente.TabIndex = 20
        Me.lblIDCliente.Text = "Cliente"
        '
        'AdvIDCliente
        '
        Me.AdvIDCliente.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDCliente.DisplayField = "IDCliente"
        Me.AdvIDCliente.EntityName = "Cliente"
        Me.AdvIDCliente.Location = New System.Drawing.Point(71, 52)
        Me.AdvIDCliente.Name = "AdvIDCliente"
        Me.AdvIDCliente.SecondaryDataFields = "IDCliente"
        Me.AdvIDCliente.Size = New System.Drawing.Size(90, 23)
        Me.AdvIDCliente.TabIndex = 19
        '
        'CIActualizarPrecios
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(772, 453)
        Me.EntityName = "ObraTrabajo"
        Me.Name = "CIActualizarPrecios"
        Me.ViewName = "tbObraTrabajo"
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        Me.FilterPanel.ResumeLayout(False)
        Me.pnlObra.ResumeLayout(False)
        Me.pnlObra.PerformLayout()
        Me.pnlTrabajo.ResumeLayout(False)
        Me.pnlTrabajo.PerformLayout()
        Me.pnlFecha.ResumeLayout(False)
        Me.pnlFecha.PerformLayout()
        Me.pnlArticulo.ResumeLayout(False)
        Me.pnlArticulo.PerformLayout()
        CType(Me.TabActualizacionPrecios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabActualizacionPrecios.ResumeLayout(False)
        Me.TabPageTrabajos.ResumeLayout(False)
        CType(Me.GridTrabajos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageMateriales.ResumeLayout(False)
        CType(Me.GridMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageMOD.ResumeLayout(False)
        CType(Me.GridMod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageCentros.ResumeLayout(False)
        CType(Me.GridCentros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageGastos.ResumeLayout(False)
        CType(Me.GridGastos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageVarios.ResumeLayout(False)
        CType(Me.GridVarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Load "

    Private Sub CIActualizarPrecios_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            LoadToolbarActions()
            LoadGridActions()
        End If
    End Sub

    Private Sub LoadToolbarActions()
        Me.FormActions.Add("Actualizar Precios", AddressOf AccionActualizarPrecios, ExpertisApp.GetIcon("calculator.ico"))
    End Sub

    Private Sub LoadGridActions()
        Me.GridTrabajos.Actions.Add("Abrir Proyecto", AddressOf LoadObra, ExpertisApp.GetIcon("xProyectos.ico"))
        Me.GridTrabajos.Actions.Add("Abrir Cliente", AddressOf AccionAbrirCliente, ExpertisApp.GetIcon("xClientes.ico"))

        Me.GridMateriales.Actions.Add("Abrir Proyecto", AddressOf LoadObra, ExpertisApp.GetIcon("xProyectos.ico"))
        Me.GridMateriales.Actions.Add("Abrir Cliente", AddressOf AccionAbrirCliente, ExpertisApp.GetIcon("xClientes.ico"))

        Me.GridMod.Actions.Add("Abrir Proyecto", AddressOf LoadObra, ExpertisApp.GetIcon("xProyectos.ico"))
        Me.GridMod.Actions.Add("Abrir Cliente", AddressOf AccionAbrirCliente, ExpertisApp.GetIcon("xClientes.ico"))

        Me.GridCentros.Actions.Add("Abrir Proyecto", AddressOf LoadObra, ExpertisApp.GetIcon("xProyectos.ico"))
        Me.GridCentros.Actions.Add("Abrir Cliente", AddressOf AccionAbrirCliente, ExpertisApp.GetIcon("xClientes.ico"))

        Me.GridGastos.Actions.Add("Abrir Proyecto", AddressOf LoadObra, ExpertisApp.GetIcon("xProyectos.ico"))
        Me.GridGastos.Actions.Add("Abrir Cliente", AddressOf AccionAbrirCliente, ExpertisApp.GetIcon("xClientes.ico"))

        Me.GridVarios.Actions.Add("Abrir Proyecto", AddressOf LoadObra, ExpertisApp.GetIcon("xProyectos.ico"))
        Me.GridVarios.Actions.Add("Abrir Cliente", AddressOf AccionAbrirCliente, ExpertisApp.GetIcon("xClientes.ico"))
    End Sub

#End Region

#Region " Acciones Toolbar "

    Protected Overridable Sub AccionActualizarPrecios()
        Dim Grid As Solmicro.Expertis.Engine.UI.Grid = GridActivo()
        If Grid.CheckedRecordsCount > 0 Then
            Dim dtMarcados As DataTable = Me.CheckedRecords
            If Not dtMarcados Is Nothing AndAlso dtMarcados.Rows.Count > 0 Then
                Dim infoActualizacionPrecios As ActualizarPrecios.datosActualizacionPrecios
                Dim Campo As String = String.Empty
                Select Case Grid.Name
                    Case "GridMateriales"
                        Campo = "IDLineaMaterial"
                        Dim frm As New frmActualizarPreciosEspecifico
                        infoActualizacionPrecios = frm.AbrirActualizarPrecios()
                    Case Else
                        If TabActualizacionPrecios.SelectedTab.Key = "Trabajos" Then
                            Campo = "IDTrabajo"
                        ElseIf TabActualizacionPrecios.SelectedTab.Key = "MOD" Then
                            Campo = "IDLineaMOD"
                        ElseIf TabActualizacionPrecios.SelectedTab.Key = "Centros" Then
                            Campo = "IDLineaCentro"
                        ElseIf TabActualizacionPrecios.SelectedTab.Key = "Gastos" Then
                            Campo = "IDLineaGasto"
                        ElseIf TabActualizacionPrecios.SelectedTab.Key = "Varios" Then
                            Campo = "IDLineaVarios"
                        End If

                        Dim frm As New frmActualizarPreciosGeneral
                        infoActualizacionPrecios = frm.AbrirActualizarPrecios()
                End Select
                If Not infoActualizacionPrecios Is Nothing Then
                    Dim ID(-1) As Object
                    For Each dr As DataRow In dtMarcados.Rows
                        ReDim Preserve ID(UBound(ID) + 1)
                        ID(UBound(ID)) = dr(Campo)
                    Next
                    infoActualizacionPrecios.IDRegistrosActualizacion = ID
                    infoActualizacionPrecios.EntityName = dtMarcados.TableName
                    ExpertisApp.ExecuteTask(Of ActualizarPrecios.datosActualizacionPrecios)(AddressOf ActualizarPrecios.ActualizaPrecios, infoActualizacionPrecios)

                    ExpertisApp.GenerateMessage("Proceso finalizado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.UnCheckAllRecords()
                    Me.Execute()
                End If
            End If
        Else
            ExpertisApp.GenerateMessage("Debe seleccionar alguna fila.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

#End Region

#Region " Grid Actions "
    Private Sub LoadObra()
        If ExpertisApp.IsFormOpen("MGEO") Then ExpertisApp.CloseForm("MGEO")
        ExpertisApp.OpenForm("MGEO", New NumberFilterItem("IDObra", GridActivo().GetValue("IDObra")))
    End Sub

    Private Sub AccionAbrirCliente()
        If ExpertisApp.IsFormOpen("MCLIENTE") Then ExpertisApp.CloseForm("MCLIENTE")
        ExpertisApp.OpenForm("MCLIENTE", New FilterItem("IDCliente", GridActivo().GetValue("IDCliente")))
    End Sub
#End Region

#Region " QueryExecuting "

    Private Sub CIActualizarPrecios_QueryExecuting(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        If IsNothing(Me.CIPrimaryObject) Then
            Me.SetCIPrimaryObject(GridActivo(), False)
        End If
        e.Filter.Add("IDObra", FilterOperator.Equal, AdvIDObra.Value, FilterType.Numeric)
        e.Filter.Add("IDTrabajo", FilterOperator.Equal, AdvTrabajo.Value, FilterType.Numeric)
        e.Filter.Add("IDCliente", FilterOperator.Equal, AdvIDCliente.Value, FilterType.String)
        Select Case TabActualizacionPrecios.SelectedTab.Key
            Case "Materiales"
                e.Filter.Add("IDMaterial", FilterOperator.Equal, AdvArticulo.Text, FilterType.String)
                e.Filter.Add("IDTipo", FilterOperator.Equal, AdvTipo.Text, FilterType.String)
                e.Filter.Add("IDFamilia", FilterOperator.Equal, AdvFamilia.Text, FilterType.String)
            Case "Mod", "Centros", "Trabajos"
                e.Filter.Add("FechaInicio", FilterOperator.GreaterThanOrEqual, cFechaInicioDesde.Value, FilterType.DateTime)
                e.Filter.Add("FechaInicio", FilterOperator.LessThanOrEqual, cFechaInicioHasta.Value, FilterType.DateTime)
        End Select
    End Sub

    Private Sub CIActualizarPrecios_FilterClearing(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.FilterClearing
        If pnlObra.Visible Then
            AdvIDObra.TextBox.Clear()
            AdvIDObra.Value = Nothing
            If pnlTrabajo.Visible Then
                AdvTrabajo.TextBox.Clear()
                AdvTrabajo.Value = Nothing
            End If
            AdvIDCliente.TextBox.Clear()
            AdvIDCliente.Value = Nothing
        End If
        If pnlArticulo.Visible Then
            AdvArticulo.TextBox.Clear()
            AdvArticulo.Value = Nothing
            AdvTipo.TextBox.Clear()
            AdvTipo.Value = Nothing
            AdvFamilia.TextBox.Clear()
            AdvFamilia.Value = Nothing
        End If
        If pnlFecha.Visible Then
            cFechaInicioDesde.TextBox.Clear()
            cFechaInicioHasta.TextBox.Clear()
        End If
    End Sub

#End Region

    Private Sub AdvTrabajo_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles AdvTrabajo.SetPredefinedFilter
        If Length(AdvIDObra.Value) > 0 Then
            e.Filter.Add("IDObra", FilterOperator.Equal, AdvIDObra.Value, FilterType.Numeric)
        End If
    End Sub

    Private Sub AdvFamilia_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles AdvFamilia.SetPredefinedFilter
        If Length(AdvTipo.Text) > 0 Then
            e.Filter.Add("IDTipo", FilterOperator.Equal, AdvTipo.Text, FilterType.String)
        End If
    End Sub

#Region " Tab "

    Private Sub TabActualizacionPrecios_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Janus.Windows.UI.Tab.TabEventArgs) Handles TabActualizacionPrecios.SelectedTabChanged
        pnlObra.Visible = True
        pnlTrabajo.Visible = True
        Select Case e.Page.Key
            Case "Trabajos", "MOD", "Centros"
                pnlArticulo.Visible = False
                pnlFecha.Visible = True
            Case "Materiales"
                pnlArticulo.Visible = True
                pnlFecha.Visible = False
            Case "Varios", "Gastos"
                pnlArticulo.Visible = False
                pnlFecha.Visible = False
        End Select
    End Sub

    Private Sub TabActualizacionPrecios_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabActualizacionPrecios.Click
        If Not Me.CIPrimaryObject Is Nothing Then Me.UnCheckAllRecords()
        Me.SetCIPrimaryObject(GridActivo(), True)
    End Sub

#End Region

    Private Function GridActivo() As Solmicro.Expertis.Engine.UI.Grid
        Select Case TabActualizacionPrecios.SelectedTab.Key
            Case "Materiales"
                Return GridMateriales
            Case "MOD"
                Return GridMod
            Case "Centros"
                Return GridCentros
            Case "Gastos"
                Return GridGastos
            Case "Varios"
                Return GridVarios
            Case "Trabajos"
                Return GridTrabajos
        End Select
    End Function

    Private Sub ShowFilterCritria1_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles ShowFilterCritria1.Click
        FilterPanel.Visible = Not FilterPanel.Visible
    End Sub

End Class
