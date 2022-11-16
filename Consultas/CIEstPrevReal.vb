Public Class CIEstPrevReal
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
    Friend WithEvents FilterPanel As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents CmbEstadoObra As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblEstadoObra As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents pnlMateriales As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents AdvIDFamilia As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvIDProveedor As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvIDTipo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvIDSubFamilia As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblMaterial As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvIDMaterial As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblProveedor As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents pnlTrabajos As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents txtImpReal As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblImpReal As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents pnlGastos As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents lblObraPadreGasto As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvIDObraPadreGasto As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblGasto As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvIDGasto As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents pnlMod As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents lblOperario As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvIDOperario As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblCategoria As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvIDCategoria As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents pnlCentros As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents lblCentro As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvIDCentro As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents pnlVarios As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents lblVarios As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvIDVarios As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvSubTipoTrabajo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvTrabajo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblObraHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblObraDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblSubTipoTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblTipoObra As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblTipoTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvObraHasta As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvObraDesde As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvIDTipoObra As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvTipoTrabajo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents pnlTotales As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents lblTotalReal As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblTotalPrevisto As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtTotalReal As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtTotalPrev As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents TabObras As Solmicro.Expertis.Engine.UI.Tab
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
    Friend WithEvents GridVarios As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents AdvFactura As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblFactura As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFechaControlHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFechaControlDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaControlHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents cbxFechaControlDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents cbxFechaFactDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents cbxFechaFactHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents ShowFilterPanel As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents ShowFilterPanel1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents lblFechaFactHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LblObraPadreVarios As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvIDObraPadreVarios As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblObraPadreTrabajos As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvIDObraPadreTrabajos As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblObraPadreCentro As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvIDObraPadreCentro As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents LblObraPadreMOD As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvIDObraPadreMOD As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents LblObraPadreMaterial As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvIDObraPadreMaterial As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblFechaFactDesde As Solmicro.Expertis.Engine.UI.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim CmbEstadoObra_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridTrabajos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridMateriales_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridMod_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridCentros_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridGastos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridVarios_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIEstPrevReal))
        Me.FilterPanel = New Solmicro.Expertis.Engine.UI.Frame
        Me.pnlTrabajos = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblObraPadreTrabajos = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDObraPadreTrabajos = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.txtImpReal = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblImpReal = New Solmicro.Expertis.Engine.UI.Label
        Me.pnlVarios = New Solmicro.Expertis.Engine.UI.Panel
        Me.LblObraPadreVarios = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDObraPadreVarios = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblVarios = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDVarios = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.pnlCentros = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblObraPadreCentro = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDObraPadreCentro = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblCentro = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDCentro = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.pnlMod = New Solmicro.Expertis.Engine.UI.Panel
        Me.LblObraPadreMOD = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDObraPadreMOD = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblOperario = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDOperario = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblCategoria = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDCategoria = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.pnlGastos = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblObraPadreGasto = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDObraPadreGasto = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblGasto = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDGasto = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.pnlMateriales = New Solmicro.Expertis.Engine.UI.Panel
        Me.LblObraPadreMaterial = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDObraPadreMaterial = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.AdvIDFamilia = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.AdvIDTipo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.AdvIDSubFamilia = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblMaterial = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDMaterial = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblProveedor = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDProveedor = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblFechaControlHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFechaControlDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaControlHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.cbxFechaControlDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.AdvFactura = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblFactura = New Solmicro.Expertis.Engine.UI.Label
        Me.CmbEstadoObra = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblEstadoObra = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvSubTipoTrabajo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.AdvTrabajo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblFechaFactHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFechaFactDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.lblObraHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.lblObraDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.lblTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.lblSubTipoTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.lblTipoObra = New Solmicro.Expertis.Engine.UI.Label
        Me.lblTipoTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaFactHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.cbxFechaFactDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.AdvObraHasta = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.AdvObraDesde = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.AdvIDTipoObra = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.AdvTipoTrabajo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.pnlTotales = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblTotalReal = New Solmicro.Expertis.Engine.UI.Label
        Me.lblTotalPrevisto = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTotalReal = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtTotalPrev = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.TabObras = New Solmicro.Expertis.Engine.UI.Tab
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
        Me.ShowFilterPanel = New Janus.Windows.UI.CommandBars.UICommand("ShowFilterPanel")
        Me.ShowFilterPanel1 = New Janus.Windows.UI.CommandBars.UICommand("ShowFilterPanel")
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        Me.FilterPanel.SuspendLayout()
        Me.pnlTrabajos.suspendlayout()
        Me.pnlVarios.suspendlayout()
        Me.pnlCentros.suspendlayout()
        Me.pnlMod.suspendlayout()
        Me.pnlGastos.suspendlayout()
        Me.pnlMateriales.suspendlayout()
        CType(Me.CmbEstadoObra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTotales.suspendlayout()
        CType(Me.TabObras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabObras.SuspendLayout()
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
        Me.UiCommandManager1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.ShowFilterPanel})
        '
        'Toolbar
        '
        Me.Toolbar.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.ShowFilterPanel1})
        Me.Toolbar.Size = New System.Drawing.Size(321, 28)
        '
        'Menubar
        '
        Me.Menubar.Location = New System.Drawing.Point(0, 28)
        '
        'MainPanel
        '
        Me.MainPanel.Controls.Add(Me.TabObras)
        Me.MainPanel.Controls.Add(Me.pnlTotales)
        Me.MainPanel.Controls.Add(Me.FilterPanel)
        Me.MainPanel.Size = New System.Drawing.Size(594, 443)
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(594, 443)
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.pnlGastos)
        Me.FilterPanel.Controls.Add(Me.pnlMateriales)
        Me.FilterPanel.Controls.Add(Me.pnlTrabajos)
        Me.FilterPanel.Controls.Add(Me.pnlVarios)
        Me.FilterPanel.Controls.Add(Me.pnlCentros)
        Me.FilterPanel.Controls.Add(Me.pnlMod)
        Me.FilterPanel.Controls.Add(Me.lblFechaControlHasta)
        Me.FilterPanel.Controls.Add(Me.lblFechaControlDesde)
        Me.FilterPanel.Controls.Add(Me.cbxFechaControlHasta)
        Me.FilterPanel.Controls.Add(Me.cbxFechaControlDesde)
        Me.FilterPanel.Controls.Add(Me.AdvFactura)
        Me.FilterPanel.Controls.Add(Me.lblFactura)
        Me.FilterPanel.Controls.Add(Me.CmbEstadoObra)
        Me.FilterPanel.Controls.Add(Me.lblEstadoObra)
        Me.FilterPanel.Controls.Add(Me.AdvSubTipoTrabajo)
        Me.FilterPanel.Controls.Add(Me.AdvTrabajo)
        Me.FilterPanel.Controls.Add(Me.lblFechaFactHasta)
        Me.FilterPanel.Controls.Add(Me.lblFechaFactDesde)
        Me.FilterPanel.Controls.Add(Me.lblObraHasta)
        Me.FilterPanel.Controls.Add(Me.lblObraDesde)
        Me.FilterPanel.Controls.Add(Me.lblTrabajo)
        Me.FilterPanel.Controls.Add(Me.lblSubTipoTrabajo)
        Me.FilterPanel.Controls.Add(Me.lblTipoObra)
        Me.FilterPanel.Controls.Add(Me.lblTipoTrabajo)
        Me.FilterPanel.Controls.Add(Me.cbxFechaFactHasta)
        Me.FilterPanel.Controls.Add(Me.cbxFechaFactDesde)
        Me.FilterPanel.Controls.Add(Me.AdvObraHasta)
        Me.FilterPanel.Controls.Add(Me.AdvObraDesde)
        Me.FilterPanel.Controls.Add(Me.AdvIDTipoObra)
        Me.FilterPanel.Controls.Add(Me.AdvTipoTrabajo)
        Me.FilterPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FilterPanel.Location = New System.Drawing.Point(0, 262)
        Me.FilterPanel.Name = "FilterPanel"
        Me.FilterPanel.Size = New System.Drawing.Size(594, 181)
        Me.FilterPanel.TabIndex = 23
        Me.FilterPanel.TabStop = False
        Me.FilterPanel.Text = " Criterios de Selección  "
        '
        'pnlTrabajos
        '
        Me.pnlTrabajos.Controls.Add(Me.lblObraPadreTrabajos)
        Me.pnlTrabajos.Controls.Add(Me.AdvIDObraPadreTrabajos)
        Me.pnlTrabajos.Controls.Add(Me.txtImpReal)
        Me.pnlTrabajos.Controls.Add(Me.lblImpReal)
        Me.pnlTrabajos.Location = New System.Drawing.Point(0, 121)
        Me.pnlTrabajos.Name = "pnlTrabajos"
        Me.pnlTrabajos.Size = New System.Drawing.Size(593, 26)
        Me.pnlTrabajos.TabIndex = 13
        Me.pnlTrabajos.TabStop = True
        '
        'lblObraPadreTrabajos
        '
        Me.lblObraPadreTrabajos.Location = New System.Drawing.Point(213, 6)
        Me.lblObraPadreTrabajos.Name = "lblObraPadreTrabajos"
        Me.lblObraPadreTrabajos.Size = New System.Drawing.Size(72, 13)
        Me.lblObraPadreTrabajos.TabIndex = 77
        Me.lblObraPadreTrabajos.Text = "Obra Padre"
        '
        'AdvIDObraPadreTrabajos
        '
        Me.AdvIDObraPadreTrabajos.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDObraPadreTrabajos.DisplayField = "NObra"
        Me.AdvIDObraPadreTrabajos.EntityName = "ObraCabecera"
        Me.AdvIDObraPadreTrabajos.Location = New System.Drawing.Point(286, 2)
        Me.AdvIDObraPadreTrabajos.Name = "AdvIDObraPadreTrabajos"
        Me.AdvIDObraPadreTrabajos.SecondaryDataFields = "IDObra"
        Me.AdvIDObraPadreTrabajos.Size = New System.Drawing.Size(100, 23)
        Me.AdvIDObraPadreTrabajos.TabIndex = 4
        '
        'txtImpReal
        '
        Me.txtImpReal.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpReal.Location = New System.Drawing.Point(110, 2)
        Me.txtImpReal.Name = "txtImpReal"
        Me.txtImpReal.NullBehavior = Janus.Windows.GridEX.NumericEditNullBehavior.AllowNull
        Me.txtImpReal.Size = New System.Drawing.Size(100, 21)
        Me.txtImpReal.TabIndex = 3
        '
        'lblImpReal
        '
        Me.lblImpReal.Location = New System.Drawing.Point(7, 7)
        Me.lblImpReal.Name = "lblImpReal"
        Me.lblImpReal.Size = New System.Drawing.Size(76, 13)
        Me.lblImpReal.TabIndex = 41
        Me.lblImpReal.Text = "Imp. Real >"
        '
        'pnlVarios
        '
        Me.pnlVarios.Controls.Add(Me.LblObraPadreVarios)
        Me.pnlVarios.Controls.Add(Me.AdvIDObraPadreVarios)
        Me.pnlVarios.Controls.Add(Me.lblVarios)
        Me.pnlVarios.Controls.Add(Me.AdvIDVarios)
        Me.pnlVarios.Location = New System.Drawing.Point(0, 121)
        Me.pnlVarios.Name = "pnlVarios"
        Me.pnlVarios.Size = New System.Drawing.Size(593, 26)
        Me.pnlVarios.TabIndex = 32
        Me.pnlVarios.TabStop = True
        Me.pnlVarios.Visible = False
        '
        'LblObraPadreVarios
        '
        Me.LblObraPadreVarios.Location = New System.Drawing.Point(213, 7)
        Me.LblObraPadreVarios.Name = "LblObraPadreVarios"
        Me.LblObraPadreVarios.Size = New System.Drawing.Size(72, 13)
        Me.LblObraPadreVarios.TabIndex = 77
        Me.LblObraPadreVarios.Text = "Obra Padre"
        '
        'AdvIDObraPadreVarios
        '
        Me.AdvIDObraPadreVarios.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDObraPadreVarios.DisplayField = "NObra"
        Me.AdvIDObraPadreVarios.EntityName = "ObraCabecera"
        Me.AdvIDObraPadreVarios.Location = New System.Drawing.Point(286, 2)
        Me.AdvIDObraPadreVarios.Name = "AdvIDObraPadreVarios"
        Me.AdvIDObraPadreVarios.SecondaryDataFields = "IDObra"
        Me.AdvIDObraPadreVarios.Size = New System.Drawing.Size(100, 23)
        Me.AdvIDObraPadreVarios.TabIndex = 9
        '
        'lblVarios
        '
        Me.lblVarios.Location = New System.Drawing.Point(7, 8)
        Me.lblVarios.Name = "lblVarios"
        Me.lblVarios.Size = New System.Drawing.Size(43, 13)
        Me.lblVarios.TabIndex = 75
        Me.lblVarios.Text = "Varios"
        '
        'AdvIDVarios
        '
        Me.AdvIDVarios.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDVarios.EntityName = "Varios"
        Me.AdvIDVarios.Location = New System.Drawing.Point(110, 2)
        Me.AdvIDVarios.Name = "AdvIDVarios"
        Me.AdvIDVarios.PrimaryDataFields = "IDVarios"
        Me.AdvIDVarios.SecondaryDataFields = "IDVarios"
        Me.AdvIDVarios.Size = New System.Drawing.Size(100, 23)
        Me.AdvIDVarios.TabIndex = 8
        Me.AdvIDVarios.ViewName = "tbMaestroVarios"
        '
        'pnlCentros
        '
        Me.pnlCentros.Controls.Add(Me.lblObraPadreCentro)
        Me.pnlCentros.Controls.Add(Me.AdvIDObraPadreCentro)
        Me.pnlCentros.Controls.Add(Me.lblCentro)
        Me.pnlCentros.Controls.Add(Me.AdvIDCentro)
        Me.pnlCentros.Location = New System.Drawing.Point(0, 121)
        Me.pnlCentros.Name = "pnlCentros"
        Me.pnlCentros.Size = New System.Drawing.Size(593, 26)
        Me.pnlCentros.TabIndex = 30
        Me.pnlCentros.TabStop = True
        Me.pnlCentros.Visible = False
        '
        'lblObraPadreCentro
        '
        Me.lblObraPadreCentro.Location = New System.Drawing.Point(213, 6)
        Me.lblObraPadreCentro.Name = "lblObraPadreCentro"
        Me.lblObraPadreCentro.Size = New System.Drawing.Size(72, 13)
        Me.lblObraPadreCentro.TabIndex = 77
        Me.lblObraPadreCentro.Text = "Obra Padre"
        '
        'AdvIDObraPadreCentro
        '
        Me.AdvIDObraPadreCentro.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDObraPadreCentro.DisplayField = "NObra"
        Me.AdvIDObraPadreCentro.EntityName = "ObraCabecera"
        Me.AdvIDObraPadreCentro.Location = New System.Drawing.Point(286, 2)
        Me.AdvIDObraPadreCentro.Name = "AdvIDObraPadreCentro"
        Me.AdvIDObraPadreCentro.SecondaryDataFields = "IDObra"
        Me.AdvIDObraPadreCentro.Size = New System.Drawing.Size(100, 23)
        Me.AdvIDObraPadreCentro.TabIndex = 7
        '
        'lblCentro
        '
        Me.lblCentro.Location = New System.Drawing.Point(7, 8)
        Me.lblCentro.Name = "lblCentro"
        Me.lblCentro.Size = New System.Drawing.Size(46, 13)
        Me.lblCentro.TabIndex = 71
        Me.lblCentro.Text = "Centro"
        '
        'AdvIDCentro
        '
        Me.AdvIDCentro.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDCentro.EntityName = "Centro"
        Me.AdvIDCentro.Location = New System.Drawing.Point(110, 2)
        Me.AdvIDCentro.Name = "AdvIDCentro"
        Me.AdvIDCentro.PrimaryDataFields = "IDCentro"
        Me.AdvIDCentro.SecondaryDataFields = "IDCentro"
        Me.AdvIDCentro.Size = New System.Drawing.Size(100, 23)
        Me.AdvIDCentro.TabIndex = 6
        Me.AdvIDCentro.ViewName = "tbMaestroCentro"
        '
        'pnlMod
        '
        Me.pnlMod.Controls.Add(Me.LblObraPadreMOD)
        Me.pnlMod.Controls.Add(Me.AdvIDObraPadreMOD)
        Me.pnlMod.Controls.Add(Me.lblOperario)
        Me.pnlMod.Controls.Add(Me.AdvIDOperario)
        Me.pnlMod.Controls.Add(Me.lblCategoria)
        Me.pnlMod.Controls.Add(Me.AdvIDCategoria)
        Me.pnlMod.Location = New System.Drawing.Point(0, 121)
        Me.pnlMod.Name = "pnlMod"
        Me.pnlMod.Size = New System.Drawing.Size(593, 26)
        Me.pnlMod.TabIndex = 29
        Me.pnlMod.TabStop = True
        Me.pnlMod.Visible = False
        '
        'LblObraPadreMOD
        '
        Me.LblObraPadreMOD.Location = New System.Drawing.Point(395, 8)
        Me.LblObraPadreMOD.Name = "LblObraPadreMOD"
        Me.LblObraPadreMOD.Size = New System.Drawing.Size(72, 13)
        Me.LblObraPadreMOD.TabIndex = 79
        Me.LblObraPadreMOD.Text = "Obra Padre"
        '
        'AdvIDObraPadreMOD
        '
        Me.AdvIDObraPadreMOD.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDObraPadreMOD.DisplayField = "NObra"
        Me.AdvIDObraPadreMOD.EntityName = "ObraCabecera"
        Me.AdvIDObraPadreMOD.Location = New System.Drawing.Point(486, 2)
        Me.AdvIDObraPadreMOD.Name = "AdvIDObraPadreMOD"
        Me.AdvIDObraPadreMOD.SecondaryDataFields = "IDObra"
        Me.AdvIDObraPadreMOD.Size = New System.Drawing.Size(100, 23)
        Me.AdvIDObraPadreMOD.TabIndex = 16
        '
        'lblOperario
        '
        Me.lblOperario.Location = New System.Drawing.Point(7, 9)
        Me.lblOperario.Name = "lblOperario"
        Me.lblOperario.Size = New System.Drawing.Size(57, 13)
        Me.lblOperario.TabIndex = 70
        Me.lblOperario.Text = "Operario"
        '
        'AdvIDOperario
        '
        Me.AdvIDOperario.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDOperario.EntityName = "Operario"
        Me.AdvIDOperario.Location = New System.Drawing.Point(110, 2)
        Me.AdvIDOperario.Name = "AdvIDOperario"
        Me.AdvIDOperario.PrimaryDataFields = "IDOperario"
        Me.AdvIDOperario.SecondaryDataFields = "IDOperario"
        Me.AdvIDOperario.Size = New System.Drawing.Size(100, 23)
        Me.AdvIDOperario.TabIndex = 5
        Me.AdvIDOperario.ViewName = "tbMaestroOperario"
        '
        'lblCategoria
        '
        Me.lblCategoria.Location = New System.Drawing.Point(213, 7)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(63, 13)
        Me.lblCategoria.TabIndex = 72
        Me.lblCategoria.Text = "Categoría"
        '
        'AdvIDCategoria
        '
        Me.AdvIDCategoria.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDCategoria.EntityName = "Categoria"
        Me.AdvIDCategoria.Location = New System.Drawing.Point(286, 2)
        Me.AdvIDCategoria.Name = "AdvIDCategoria"
        Me.AdvIDCategoria.PrimaryDataFields = "IDCategoria"
        Me.AdvIDCategoria.SecondaryDataFields = "IDCategoria"
        Me.AdvIDCategoria.Size = New System.Drawing.Size(100, 23)
        Me.AdvIDCategoria.TabIndex = 15
        Me.AdvIDCategoria.ViewName = "tbMaestroCategoria"
        '
        'pnlGastos
        '
        Me.pnlGastos.Controls.Add(Me.lblObraPadreGasto)
        Me.pnlGastos.Controls.Add(Me.AdvIDObraPadreGasto)
        Me.pnlGastos.Controls.Add(Me.lblGasto)
        Me.pnlGastos.Controls.Add(Me.AdvIDGasto)
        Me.pnlGastos.Location = New System.Drawing.Point(0, 121)
        Me.pnlGastos.Name = "pnlGastos"
        Me.pnlGastos.Size = New System.Drawing.Size(593, 26)
        Me.pnlGastos.TabIndex = 31
        Me.pnlGastos.TabStop = True
        Me.pnlGastos.Visible = False
        '
        'lblObraPadreGasto
        '
        Me.lblObraPadreGasto.Location = New System.Drawing.Point(213, 7)
        Me.lblObraPadreGasto.Name = "lblObraPadreGasto"
        Me.lblObraPadreGasto.Size = New System.Drawing.Size(72, 13)
        Me.lblObraPadreGasto.TabIndex = 75
        Me.lblObraPadreGasto.Text = "Obra Padre"
        '
        'AdvIDObraPadreGasto
        '
        Me.AdvIDObraPadreGasto.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDObraPadreGasto.DisplayField = "NObra"
        Me.AdvIDObraPadreGasto.EntityName = "ObraCabecera"
        Me.AdvIDObraPadreGasto.Location = New System.Drawing.Point(286, 2)
        Me.AdvIDObraPadreGasto.Name = "AdvIDObraPadreGasto"
        Me.AdvIDObraPadreGasto.SecondaryDataFields = "IDObra"
        Me.AdvIDObraPadreGasto.Size = New System.Drawing.Size(100, 23)
        Me.AdvIDObraPadreGasto.TabIndex = 8
        '
        'lblGasto
        '
        Me.lblGasto.Location = New System.Drawing.Point(7, 7)
        Me.lblGasto.Name = "lblGasto"
        Me.lblGasto.Size = New System.Drawing.Size(40, 13)
        Me.lblGasto.TabIndex = 73
        Me.lblGasto.Text = "Gasto"
        '
        'AdvIDGasto
        '
        Me.AdvIDGasto.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDGasto.EntityName = "Gasto"
        Me.AdvIDGasto.Location = New System.Drawing.Point(110, 2)
        Me.AdvIDGasto.Name = "AdvIDGasto"
        Me.AdvIDGasto.PrimaryDataFields = "IDGasto"
        Me.AdvIDGasto.SecondaryDataFields = "IDGasto"
        Me.AdvIDGasto.Size = New System.Drawing.Size(100, 23)
        Me.AdvIDGasto.TabIndex = 7
        Me.AdvIDGasto.ViewName = "tbMaestroGasto"
        '
        'pnlMateriales
        '
        Me.pnlMateriales.Controls.Add(Me.LblObraPadreMaterial)
        Me.pnlMateriales.Controls.Add(Me.AdvIDObraPadreMaterial)
        Me.pnlMateriales.Controls.Add(Me.AdvIDFamilia)
        Me.pnlMateriales.Controls.Add(Me.AdvIDTipo)
        Me.pnlMateriales.Controls.Add(Me.AdvIDSubFamilia)
        Me.pnlMateriales.Controls.Add(Me.lblMaterial)
        Me.pnlMateriales.Controls.Add(Me.AdvIDMaterial)
        Me.pnlMateriales.Controls.Add(Me.lblProveedor)
        Me.pnlMateriales.Controls.Add(Me.AdvIDProveedor)
        Me.pnlMateriales.Location = New System.Drawing.Point(0, 121)
        Me.pnlMateriales.Name = "pnlMateriales"
        Me.pnlMateriales.Size = New System.Drawing.Size(593, 58)
        Me.pnlMateriales.TabIndex = 12
        Me.pnlMateriales.TabStop = True
        Me.pnlMateriales.Visible = False
        '
        'LblObraPadreMaterial
        '
        Me.LblObraPadreMaterial.Location = New System.Drawing.Point(7, 32)
        Me.LblObraPadreMaterial.Name = "LblObraPadreMaterial"
        Me.LblObraPadreMaterial.Size = New System.Drawing.Size(72, 13)
        Me.LblObraPadreMaterial.TabIndex = 91
        Me.LblObraPadreMaterial.Text = "Obra Padre"
        '
        'AdvIDObraPadreMaterial
        '
        Me.AdvIDObraPadreMaterial.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDObraPadreMaterial.DisplayField = "NObra"
        Me.AdvIDObraPadreMaterial.EntityName = "ObraCabecera"
        Me.AdvIDObraPadreMaterial.Location = New System.Drawing.Point(110, 27)
        Me.AdvIDObraPadreMaterial.Name = "AdvIDObraPadreMaterial"
        Me.AdvIDObraPadreMaterial.SecondaryDataFields = "IDObra"
        Me.AdvIDObraPadreMaterial.Size = New System.Drawing.Size(100, 23)
        Me.AdvIDObraPadreMaterial.TabIndex = 21
        '
        'AdvIDFamilia
        '
        Me.AdvIDFamilia.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDFamilia.EntityName = "Familia"
        Me.AdvIDFamilia.Location = New System.Drawing.Point(272, 2)
        Me.AdvIDFamilia.Name = "AdvIDFamilia"
        Me.AdvIDFamilia.PrimaryDataFields = "IDFamilia"
        Me.AdvIDFamilia.SecondaryDataFields = "IDFamilia"
        Me.AdvIDFamilia.Size = New System.Drawing.Size(56, 23)
        Me.AdvIDFamilia.TabIndex = 13
        Me.AdvIDFamilia.ViewName = "tbMaestroFamilia"
        '
        'AdvIDTipo
        '
        Me.AdvIDTipo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDTipo.EntityName = "TipoArticulo"
        Me.AdvIDTipo.Location = New System.Drawing.Point(212, 2)
        Me.AdvIDTipo.Name = "AdvIDTipo"
        Me.AdvIDTipo.PrimaryDataFields = "IDCategoria"
        Me.AdvIDTipo.SecondaryDataFields = "IDTipo"
        Me.AdvIDTipo.Size = New System.Drawing.Size(58, 23)
        Me.AdvIDTipo.TabIndex = 12
        Me.AdvIDTipo.ViewName = "tbMaestroTipoArticulo"
        '
        'AdvIDSubFamilia
        '
        Me.AdvIDSubFamilia.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDSubFamilia.EntityName = "Subfamilia"
        Me.AdvIDSubFamilia.Location = New System.Drawing.Point(330, 2)
        Me.AdvIDSubFamilia.Name = "AdvIDSubFamilia"
        Me.AdvIDSubFamilia.PrimaryDataFields = "IDSubfamilia"
        Me.AdvIDSubFamilia.SecondaryDataFields = "IDSubfamilia"
        Me.AdvIDSubFamilia.Size = New System.Drawing.Size(56, 23)
        Me.AdvIDSubFamilia.TabIndex = 14
        Me.AdvIDSubFamilia.ViewName = "tbMaestroSubfamilia"
        '
        'lblMaterial
        '
        Me.lblMaterial.Location = New System.Drawing.Point(7, 7)
        Me.lblMaterial.Name = "lblMaterial"
        Me.lblMaterial.Size = New System.Drawing.Size(52, 13)
        Me.lblMaterial.TabIndex = 87
        Me.lblMaterial.Text = "Material"
        '
        'AdvIDMaterial
        '
        Me.AdvIDMaterial.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDMaterial.EntityName = "Articulo"
        Me.AdvIDMaterial.Location = New System.Drawing.Point(110, 2)
        Me.AdvIDMaterial.Name = "AdvIDMaterial"
        Me.AdvIDMaterial.PrimaryDataFields = "IDArticulo"
        Me.AdvIDMaterial.SecondaryDataFields = "IDArticulo"
        Me.AdvIDMaterial.Size = New System.Drawing.Size(100, 23)
        Me.AdvIDMaterial.TabIndex = 4
        Me.AdvIDMaterial.ViewName = "tbMaestroArticulo"
        '
        'lblProveedor
        '
        Me.lblProveedor.Location = New System.Drawing.Point(395, 7)
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Size = New System.Drawing.Size(66, 13)
        Me.lblProveedor.TabIndex = 89
        Me.lblProveedor.Text = "Proveedor"
        '
        'AdvIDProveedor
        '
        Me.AdvIDProveedor.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDProveedor.EntityName = "Proveedor"
        Me.AdvIDProveedor.Location = New System.Drawing.Point(486, 2)
        Me.AdvIDProveedor.Name = "AdvIDProveedor"
        Me.AdvIDProveedor.PrimaryDataFields = "IDProveedor"
        Me.AdvIDProveedor.SecondaryDataFields = "IDProveedor"
        Me.AdvIDProveedor.Size = New System.Drawing.Size(100, 23)
        Me.AdvIDProveedor.TabIndex = 20
        Me.AdvIDProveedor.ViewName = "tbMaestroProveedor"
        '
        'lblFechaControlHasta
        '
        Me.lblFechaControlHasta.Location = New System.Drawing.Point(395, 103)
        Me.lblFechaControlHasta.Name = "lblFechaControlHasta"
        Me.lblFechaControlHasta.Size = New System.Drawing.Size(76, 13)
        Me.lblFechaControlHasta.TabIndex = 132
        Me.lblFechaControlHasta.Tag = ""
        Me.lblFechaControlHasta.Text = "Fecha Hasta"
        '
        'lblFechaControlDesde
        '
        Me.lblFechaControlDesde.Location = New System.Drawing.Point(395, 79)
        Me.lblFechaControlDesde.Name = "lblFechaControlDesde"
        Me.lblFechaControlDesde.Size = New System.Drawing.Size(80, 13)
        Me.lblFechaControlDesde.TabIndex = 133
        Me.lblFechaControlDesde.Tag = ""
        Me.lblFechaControlDesde.Text = "Fecha Desde"
        '
        'cbxFechaControlHasta
        '
        Me.cbxFechaControlHasta.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaControlHasta.Location = New System.Drawing.Point(486, 98)
        Me.cbxFechaControlHasta.Name = "cbxFechaControlHasta"
        Me.cbxFechaControlHasta.Size = New System.Drawing.Size(100, 21)
        Me.cbxFechaControlHasta.TabIndex = 131
        '
        'cbxFechaControlDesde
        '
        Me.cbxFechaControlDesde.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaControlDesde.Location = New System.Drawing.Point(486, 74)
        Me.cbxFechaControlDesde.Name = "cbxFechaControlDesde"
        Me.cbxFechaControlDesde.Size = New System.Drawing.Size(100, 21)
        Me.cbxFechaControlDesde.TabIndex = 130
        '
        'AdvFactura
        '
        Me.AdvFactura.DisabledBackColor = System.Drawing.Color.White
        Me.AdvFactura.DisplayField = "NFactura"
        Me.AdvFactura.EntityName = "FacturaVentaCabecera"
        Me.AdvFactura.Location = New System.Drawing.Point(286, 98)
        Me.AdvFactura.Name = "AdvFactura"
        Me.AdvFactura.SecondaryDataFields = "IDFactura"
        Me.AdvFactura.Size = New System.Drawing.Size(100, 23)
        Me.AdvFactura.TabIndex = 125
        Me.AdvFactura.ViewName = "tbFacturaVentaCabecera"
        '
        'lblFactura
        '
        Me.lblFactura.Location = New System.Drawing.Point(213, 103)
        Me.lblFactura.Name = "lblFactura"
        Me.lblFactura.Size = New System.Drawing.Size(49, 13)
        Me.lblFactura.TabIndex = 126
        Me.lblFactura.Text = "Factura"
        '
        'CmbEstadoObra
        '
        CmbEstadoObra_DesignTimeLayout.LayoutString = resources.GetString("CmbEstadoObra_DesignTimeLayout.LayoutString")
        Me.CmbEstadoObra.DesignTimeLayout = CmbEstadoObra_DesignTimeLayout
        Me.CmbEstadoObra.DisabledBackColor = System.Drawing.Color.White
        Me.CmbEstadoObra.DisplayMember = "Text"
        Me.CmbEstadoObra.Location = New System.Drawing.Point(110, 100)
        Me.CmbEstadoObra.Name = "CmbEstadoObra"
        Me.CmbEstadoObra.SelectedIndex = -1
        Me.CmbEstadoObra.SelectedItem = Nothing
        Me.CmbEstadoObra.Size = New System.Drawing.Size(100, 21)
        Me.CmbEstadoObra.TabIndex = 124
        Me.CmbEstadoObra.ValueMember = "Value"
        '
        'lblEstadoObra
        '
        Me.lblEstadoObra.Location = New System.Drawing.Point(7, 104)
        Me.lblEstadoObra.Name = "lblEstadoObra"
        Me.lblEstadoObra.Size = New System.Drawing.Size(99, 13)
        Me.lblEstadoObra.TabIndex = 123
        Me.lblEstadoObra.Text = "Estado Proyecto"
        '
        'AdvSubTipoTrabajo
        '
        Me.AdvSubTipoTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvSubTipoTrabajo.EntityName = "ObraSubtipoTrabajo"
        Me.AdvSubTipoTrabajo.Location = New System.Drawing.Point(286, 74)
        Me.AdvSubTipoTrabajo.Name = "AdvSubTipoTrabajo"
        Me.AdvSubTipoTrabajo.PrimaryDataFields = "IDSubtipoTrabajo"
        Me.AdvSubTipoTrabajo.SecondaryDataFields = "IDSubtipoTrabajo"
        Me.AdvSubTipoTrabajo.Size = New System.Drawing.Size(100, 23)
        Me.AdvSubTipoTrabajo.TabIndex = 11
        Me.AdvSubTipoTrabajo.ViewName = "tbObraSubtipoTrabajo"
        '
        'AdvTrabajo
        '
        Me.AdvTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvTrabajo.DisplayField = "CodTrabajo"
        Me.AdvTrabajo.EntityName = "ObraTrabajo"
        Me.AdvTrabajo.Location = New System.Drawing.Point(286, 26)
        Me.AdvTrabajo.Name = "AdvTrabajo"
        Me.AdvTrabajo.PrimaryDataFields = "IDTrabajo"
        Me.AdvTrabajo.SecondaryDataFields = "IDTrabajo"
        Me.AdvTrabajo.Size = New System.Drawing.Size(100, 23)
        Me.AdvTrabajo.TabIndex = 9
        Me.AdvTrabajo.ViewName = "tbObraTrabajo"
        '
        'lblFechaFactHasta
        '
        Me.lblFechaFactHasta.Location = New System.Drawing.Point(395, 55)
        Me.lblFechaFactHasta.Name = "lblFechaFactHasta"
        Me.lblFechaFactHasta.Size = New System.Drawing.Size(84, 13)
        Me.lblFechaFactHasta.TabIndex = 108
        Me.lblFechaFactHasta.Tag = ""
        Me.lblFechaFactHasta.Text = "F. Fact. Hasta"
        '
        'lblFechaFactDesde
        '
        Me.lblFechaFactDesde.Location = New System.Drawing.Point(395, 31)
        Me.lblFechaFactDesde.Name = "lblFechaFactDesde"
        Me.lblFechaFactDesde.Size = New System.Drawing.Size(88, 13)
        Me.lblFechaFactDesde.TabIndex = 109
        Me.lblFechaFactDesde.Tag = ""
        Me.lblFechaFactDesde.Text = "F. Fact. Desde"
        '
        'lblObraHasta
        '
        Me.lblObraHasta.Location = New System.Drawing.Point(7, 57)
        Me.lblObraHasta.Name = "lblObraHasta"
        Me.lblObraHasta.Size = New System.Drawing.Size(93, 13)
        Me.lblObraHasta.TabIndex = 110
        Me.lblObraHasta.Tag = ""
        Me.lblObraHasta.Text = "Proyecto Hasta"
        '
        'lblObraDesde
        '
        Me.lblObraDesde.Location = New System.Drawing.Point(7, 33)
        Me.lblObraDesde.Name = "lblObraDesde"
        Me.lblObraDesde.Size = New System.Drawing.Size(97, 13)
        Me.lblObraDesde.TabIndex = 112
        Me.lblObraDesde.Tag = ""
        Me.lblObraDesde.Text = "Proyecto Desde"
        '
        'lblTrabajo
        '
        Me.lblTrabajo.Location = New System.Drawing.Point(213, 31)
        Me.lblTrabajo.Name = "lblTrabajo"
        Me.lblTrabajo.Size = New System.Drawing.Size(51, 13)
        Me.lblTrabajo.TabIndex = 113
        Me.lblTrabajo.Text = "Trabajo"
        '
        'lblSubTipoTrabajo
        '
        Me.lblSubTipoTrabajo.Location = New System.Drawing.Point(213, 79)
        Me.lblSubTipoTrabajo.Name = "lblSubTipoTrabajo"
        Me.lblSubTipoTrabajo.Size = New System.Drawing.Size(50, 13)
        Me.lblSubTipoTrabajo.TabIndex = 114
        Me.lblSubTipoTrabajo.Text = "Subtipo"
        '
        'lblTipoObra
        '
        Me.lblTipoObra.Location = New System.Drawing.Point(7, 81)
        Me.lblTipoObra.Name = "lblTipoObra"
        Me.lblTipoObra.Size = New System.Drawing.Size(85, 13)
        Me.lblTipoObra.TabIndex = 115
        Me.lblTipoObra.Text = "Tipo Proyecto"
        '
        'lblTipoTrabajo
        '
        Me.lblTipoTrabajo.Location = New System.Drawing.Point(213, 55)
        Me.lblTipoTrabajo.Name = "lblTipoTrabajo"
        Me.lblTipoTrabajo.Size = New System.Drawing.Size(35, 13)
        Me.lblTipoTrabajo.TabIndex = 116
        Me.lblTipoTrabajo.Text = "Tipo "
        '
        'cbxFechaFactHasta
        '
        Me.cbxFechaFactHasta.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaFactHasta.Location = New System.Drawing.Point(486, 50)
        Me.cbxFechaFactHasta.Name = "cbxFechaFactHasta"
        Me.cbxFechaFactHasta.Size = New System.Drawing.Size(100, 21)
        Me.cbxFechaFactHasta.TabIndex = 18
        '
        'cbxFechaFactDesde
        '
        Me.cbxFechaFactDesde.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaFactDesde.Location = New System.Drawing.Point(486, 26)
        Me.cbxFechaFactDesde.Name = "cbxFechaFactDesde"
        Me.cbxFechaFactDesde.Size = New System.Drawing.Size(100, 21)
        Me.cbxFechaFactDesde.TabIndex = 17
        '
        'AdvObraHasta
        '
        Me.AdvObraHasta.DisabledBackColor = System.Drawing.Color.White
        Me.AdvObraHasta.DisplayField = "NObra"
        Me.AdvObraHasta.EntityName = "ObraCabecera"
        Me.AdvObraHasta.Location = New System.Drawing.Point(110, 52)
        Me.AdvObraHasta.Name = "AdvObraHasta"
        Me.AdvObraHasta.PrimaryDataFields = "IDObra"
        Me.AdvObraHasta.SecondaryDataFields = "IDObra"
        Me.AdvObraHasta.Size = New System.Drawing.Size(100, 23)
        Me.AdvObraHasta.TabIndex = 1
        Me.AdvObraHasta.ViewName = "tbObraCabecera"
        '
        'AdvObraDesde
        '
        Me.AdvObraDesde.DisabledBackColor = System.Drawing.Color.White
        Me.AdvObraDesde.DisplayField = "NObra"
        Me.AdvObraDesde.EntityName = "ObraCabecera"
        Me.AdvObraDesde.Location = New System.Drawing.Point(110, 28)
        Me.AdvObraDesde.Name = "AdvObraDesde"
        Me.AdvObraDesde.PrimaryDataFields = "IDObra"
        Me.AdvObraDesde.SecondaryDataFields = "IDObra"
        Me.AdvObraDesde.Size = New System.Drawing.Size(100, 23)
        Me.AdvObraDesde.TabIndex = 0
        Me.AdvObraDesde.ViewName = "tbObraCabecera"
        '
        'AdvIDTipoObra
        '
        Me.AdvIDTipoObra.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDTipoObra.EntityName = "ObraTipo"
        Me.AdvIDTipoObra.Location = New System.Drawing.Point(110, 76)
        Me.AdvIDTipoObra.Name = "AdvIDTipoObra"
        Me.AdvIDTipoObra.PrimaryDataFields = "IDTipoObra"
        Me.AdvIDTipoObra.SecondaryDataFields = "IDTipoObra"
        Me.AdvIDTipoObra.Size = New System.Drawing.Size(100, 23)
        Me.AdvIDTipoObra.TabIndex = 2
        Me.AdvIDTipoObra.ViewName = "tbObraTipo"
        '
        'AdvTipoTrabajo
        '
        Me.AdvTipoTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvTipoTrabajo.EntityName = "ObraTipoTrabajo"
        Me.AdvTipoTrabajo.Location = New System.Drawing.Point(286, 50)
        Me.AdvTipoTrabajo.Name = "AdvTipoTrabajo"
        Me.AdvTipoTrabajo.PrimaryDataFields = "IDTipoTrabajo"
        Me.AdvTipoTrabajo.SecondaryDataFields = "IDTipoTrabajo"
        Me.AdvTipoTrabajo.Size = New System.Drawing.Size(100, 23)
        Me.AdvTipoTrabajo.TabIndex = 10
        Me.AdvTipoTrabajo.ViewName = "tbObraTipoTrabajo"
        '
        'pnlTotales
        '
        Me.pnlTotales.Controls.Add(Me.lblTotalReal)
        Me.pnlTotales.Controls.Add(Me.lblTotalPrevisto)
        Me.pnlTotales.Controls.Add(Me.txtTotalReal)
        Me.pnlTotales.Controls.Add(Me.txtTotalPrev)
        Me.pnlTotales.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlTotales.Location = New System.Drawing.Point(0, 231)
        Me.pnlTotales.Name = "pnlTotales"
        Me.pnlTotales.Size = New System.Drawing.Size(594, 31)
        Me.pnlTotales.TabIndex = 24
        '
        'lblTotalReal
        '
        Me.lblTotalReal.AutoSize = False
        Me.lblTotalReal.Location = New System.Drawing.Point(418, 7)
        Me.lblTotalReal.Name = "lblTotalReal"
        Me.lblTotalReal.Size = New System.Drawing.Size(61, 17)
        Me.lblTotalReal.TabIndex = 103
        Me.lblTotalReal.Text = "Total Real"
        Me.lblTotalReal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalPrevisto
        '
        Me.lblTotalPrevisto.AutoSize = False
        Me.lblTotalPrevisto.Location = New System.Drawing.Point(209, 7)
        Me.lblTotalPrevisto.Name = "lblTotalPrevisto"
        Me.lblTotalPrevisto.Size = New System.Drawing.Size(98, 17)
        Me.lblTotalPrevisto.TabIndex = 102
        Me.lblTotalPrevisto.Text = "Total Previsto"
        Me.lblTotalPrevisto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTotalReal
        '
        Me.txtTotalReal.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotalReal.Enabled = False
        Me.txtTotalReal.Location = New System.Drawing.Point(483, 5)
        Me.txtTotalReal.Name = "txtTotalReal"
        Me.txtTotalReal.Size = New System.Drawing.Size(103, 21)
        Me.txtTotalReal.TabIndex = 53
        Me.txtTotalReal.TabStop = False
        '
        'txtTotalPrev
        '
        Me.txtTotalPrev.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotalPrev.Enabled = False
        Me.txtTotalPrev.Location = New System.Drawing.Point(311, 5)
        Me.txtTotalPrev.Name = "txtTotalPrev"
        Me.txtTotalPrev.Size = New System.Drawing.Size(103, 21)
        Me.txtTotalPrev.TabIndex = 52
        Me.txtTotalPrev.TabStop = False
        '
        'TabObras
        '
        Me.TabObras.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.TabObras.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabObras.Location = New System.Drawing.Point(0, 0)
        Me.TabObras.Name = "TabObras"
        Me.TabObras.Size = New System.Drawing.Size(594, 231)
        Me.TabObras.TabIndex = 25
        Me.TabObras.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.TabPageTrabajos, Me.TabPageMateriales, Me.TabPageMOD, Me.TabPageCentros, Me.TabPageGastos, Me.TabPageVarios})
        Me.TabObras.TabStripAlignment = Janus.Windows.UI.Tab.TabStripAlignment.Right
        Me.TabObras.Text = "Varios"
        Me.TabObras.TextOrientation = Janus.Windows.UI.Tab.TextOrientation.Vertical
        Me.TabObras.UseThemes = True
        '
        'TabPageTrabajos
        '
        Me.TabPageTrabajos.Controls.Add(Me.GridTrabajos)
        Me.TabPageTrabajos.Key = "Trabajos"
        Me.TabPageTrabajos.Location = New System.Drawing.Point(1, 1)
        Me.TabPageTrabajos.Name = "TabPageTrabajos"
        Me.TabPageTrabajos.Size = New System.Drawing.Size(571, 229)
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
        Me.GridTrabajos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridTrabajos.EntityName = "ObraCabecera"
        Me.GridTrabajos.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridTrabajos.Location = New System.Drawing.Point(0, 0)
        Me.GridTrabajos.Name = "GridTrabajos"
        Me.GridTrabajos.PrimaryDataFields = Nothing
        Me.GridTrabajos.SecondaryDataFields = Nothing
        Me.GridTrabajos.Size = New System.Drawing.Size(571, 229)
        Me.GridTrabajos.TabIndex = 24
        Me.GridTrabajos.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridTrabajos.ViewName = "vEstaditicasObrasPrevistoReal"
        '
        'TabPageMateriales
        '
        Me.TabPageMateriales.Controls.Add(Me.GridMateriales)
        Me.TabPageMateriales.Key = "Materiales"
        Me.TabPageMateriales.Location = New System.Drawing.Point(1, 1)
        Me.TabPageMateriales.Name = "TabPageMateriales"
        Me.TabPageMateriales.Size = New System.Drawing.Size(571, 229)
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
        Me.GridMateriales.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridMateriales.EntityName = "ObraMaterialControl"
        Me.GridMateriales.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridMateriales.Location = New System.Drawing.Point(0, 0)
        Me.GridMateriales.Name = "GridMateriales"
        Me.GridMateriales.PrimaryDataFields = Nothing
        Me.GridMateriales.SecondaryDataFields = Nothing
        Me.GridMateriales.Size = New System.Drawing.Size(571, 229)
        Me.GridMateriales.TabIndex = 30
        Me.GridMateriales.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridMateriales.ViewName = "vEstaditicasObrasRealMaterial"
        '
        'TabPageMOD
        '
        Me.TabPageMOD.Controls.Add(Me.GridMod)
        Me.TabPageMOD.Key = "MOD"
        Me.TabPageMOD.Location = New System.Drawing.Point(1, 1)
        Me.TabPageMOD.Name = "TabPageMOD"
        Me.TabPageMOD.Size = New System.Drawing.Size(571, 229)
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
        Me.GridMod.EntityName = "ObraModControl"
        Me.GridMod.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridMod.Location = New System.Drawing.Point(0, 0)
        Me.GridMod.Name = "GridMod"
        Me.GridMod.PrimaryDataFields = Nothing
        Me.GridMod.SecondaryDataFields = Nothing
        Me.GridMod.Size = New System.Drawing.Size(571, 229)
        Me.GridMod.TabIndex = 31
        Me.GridMod.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridMod.ViewName = "vEstaditicasObrasRealMod"
        '
        'TabPageCentros
        '
        Me.TabPageCentros.Controls.Add(Me.GridCentros)
        Me.TabPageCentros.Key = "Centros"
        Me.TabPageCentros.Location = New System.Drawing.Point(1, 1)
        Me.TabPageCentros.Name = "TabPageCentros"
        Me.TabPageCentros.Size = New System.Drawing.Size(571, 229)
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
        Me.GridCentros.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridCentros.EntityName = "ObraCentroControl"
        Me.GridCentros.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridCentros.Location = New System.Drawing.Point(0, 0)
        Me.GridCentros.Name = "GridCentros"
        Me.GridCentros.PrimaryDataFields = Nothing
        Me.GridCentros.SecondaryDataFields = Nothing
        Me.GridCentros.Size = New System.Drawing.Size(571, 229)
        Me.GridCentros.TabIndex = 32
        Me.GridCentros.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridCentros.ViewName = "vEstaditicasObrasRealCentros"
        '
        'TabPageGastos
        '
        Me.TabPageGastos.Controls.Add(Me.GridGastos)
        Me.TabPageGastos.Key = "Gastos"
        Me.TabPageGastos.Location = New System.Drawing.Point(1, 1)
        Me.TabPageGastos.Name = "TabPageGastos"
        Me.TabPageGastos.Size = New System.Drawing.Size(571, 229)
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
        Me.GridGastos.EntityName = "ObraGastoControl"
        Me.GridGastos.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridGastos.Location = New System.Drawing.Point(0, 0)
        Me.GridGastos.Name = "GridGastos"
        Me.GridGastos.PrimaryDataFields = Nothing
        Me.GridGastos.SecondaryDataFields = Nothing
        Me.GridGastos.Size = New System.Drawing.Size(571, 229)
        Me.GridGastos.TabIndex = 2
        Me.GridGastos.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridGastos.ViewName = "vEstaditicasObrasRealGastos"
        '
        'TabPageVarios
        '
        Me.TabPageVarios.Controls.Add(Me.GridVarios)
        Me.TabPageVarios.Key = "Varios"
        Me.TabPageVarios.Location = New System.Drawing.Point(1, 1)
        Me.TabPageVarios.Name = "TabPageVarios"
        Me.TabPageVarios.Size = New System.Drawing.Size(571, 229)
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
        Me.GridVarios.EntityName = "ObraVariosControl"
        Me.GridVarios.Location = New System.Drawing.Point(0, 0)
        Me.GridVarios.Name = "GridVarios"
        Me.GridVarios.PrimaryDataFields = Nothing
        Me.GridVarios.SecondaryDataFields = Nothing
        Me.GridVarios.Size = New System.Drawing.Size(571, 229)
        Me.GridVarios.TabIndex = 34
        Me.GridVarios.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridVarios.ViewName = "vEstaditicasObrasRealVarios"
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
        'CIEstPrevReal
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(602, 531)
        Me.Name = "CIEstPrevReal"
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.pnlTrabajos.ResumeLayout(False)
        Me.pnlTrabajos.PerformLayout()
        Me.pnlVarios.ResumeLayout(False)
        Me.pnlVarios.PerformLayout()
        Me.pnlCentros.ResumeLayout(False)
        Me.pnlCentros.PerformLayout()
        Me.pnlMod.ResumeLayout(False)
        Me.pnlMod.PerformLayout()
        Me.pnlGastos.ResumeLayout(False)
        Me.pnlGastos.PerformLayout()
        Me.pnlMateriales.ResumeLayout(False)
        Me.pnlMateriales.PerformLayout()
        CType(Me.CmbEstadoObra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTotales.ResumeLayout(False)
        Me.pnlTotales.PerformLayout()
        CType(Me.TabObras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabObras.ResumeLayout(False)
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

    Private Const cnPORCONCEPTOS As String = "OPESTTRACO"
    Private Const cnPORCONCEPTOSPORTIPO As String = "LOCPOTIPO"
    Private Const cnPORCONCEPTOSPORTIPOSUBTIPO As String = "LOBPORSUB"
    Private Const cnPORTRABAJOS As String = "OPESTTRAB"
    Private Const cnPORTRABAJOSTIPO As String = "LESTOBTIPO"

#Region " Load "

    Private Sub CIEstPrevReal_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        ActivateControls()
    End Sub

    Private Sub CIEstPrevReal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadGridActions()
        ActivateControls()
        txtImpReal.Value = 0
        CmbEstadoObra.DataSource = EnumData.EnumView("enumocEstado")
    End Sub

    Private Sub LoadGridActions()
        LoadGridTrabajos()
        LoadGridMateriales()
        LoadGridMod()
        LoadGridCentros()
        LoadGridGastos()
        LoadGridVarios()
    End Sub

#Region " Grid Actions "

    Private Sub LoadGridTrabajos()
        GridTrabajos.Actions.Add("Abrir Proyecto", AddressOf VerObras, ExpertisApp.GetIcon("xProyectos.ico"))
    End Sub

    Private Sub LoadGridMateriales()
        GridMateriales.Actions.Add("Abrir Factura Compra", AddressOf VerFacturasCompra, ExpertisApp.GetIcon("xFacturaCompra.ico"))
        GridMateriales.Actions.Add("Abrir Proyecto", AddressOf VerObras, ExpertisApp.GetIcon("xProyectos.ico"))
    End Sub

    Private Sub LoadGridMod()
        GridMod.Actions.Add("Abrir Factura Venta", AddressOf VerFacturasVenta, ExpertisApp.GetIcon("xFacturaVenta.ico"))
        GridMod.Actions.Add("Abrir Proyecto", AddressOf VerObras, ExpertisApp.GetIcon("xProyectos.ico"))
    End Sub

    Private Sub LoadGridCentros()
        GridCentros.Actions.Add("Abrir Proyecto", AddressOf VerObras, ExpertisApp.GetIcon("xProyectos.ico"))
    End Sub

    Private Sub LoadGridGastos()
        GridGastos.Actions.Add("Abrir Factura Compra", AddressOf VerFacturasCompra, ExpertisApp.GetIcon("xFacturaCompra.ico"))
        GridGastos.Actions.Add("Abrir Proyecto", AddressOf VerObras, ExpertisApp.GetIcon("xProyectos.ico"))
    End Sub

    Private Sub LoadGridVarios()
        GridVarios.Actions.Add("Abrir Factura Compra", AddressOf VerFacturasCompra, ExpertisApp.GetIcon("xFacturaCompra.ico"))
        GridVarios.Actions.Add("Abrir Proyecto", AddressOf VerObras, ExpertisApp.GetIcon("xProyectos.ico"))
    End Sub

#End Region

#End Region

#Region " Acciones Grids "

    Private Sub VerFacturasVenta()
        AbrirMntoFacturaVenta(GridMod.Value("IDFactura"))
    End Sub

    Private Sub VerFacturasCompra()
        Dim Grid As Solmicro.Expertis.Engine.UI.Grid = GridActivo()
        AbrirMntoFacturaCompra(Grid.Value("IDFactura"))
    End Sub

    Private Sub VerObras()
        Dim Grid As Solmicro.Expertis.Engine.UI.Grid = GridActivo()
        ExpertisApp.OpenForm("MGEO", New NumberFilterItem("IDObra", Grid.Value("IDObra")))
    End Sub

#End Region

    Private Function GridActivo() As Solmicro.Expertis.Engine.UI.Grid
        Dim Grid As Solmicro.Expertis.Engine.UI.Grid = Nothing
        Dim blnConceptos As Boolean = True
        Select Case TabObras.SelectedTab.Key
            Case TabPageTrabajos.Key
                Grid = GridTrabajos
                blnConceptos = False
            Case TabPageMateriales.Key
                Grid = GridMateriales
            Case TabPageMOD.Key
                Grid = GridMod
            Case TabPageCentros.Key
                Grid = GridCentros
            Case TabPageGastos.Key
                Grid = GridGastos
            Case TabPageVarios.Key
                Grid = GridVarios
        End Select

        Dim c As Janus.Windows.UI.CommandBars.UICommandCollection = Me.Toolbar.Commands("Print").Commands
        For Each f As Janus.Windows.UI.CommandBars.UICommand In c
            Select Case CType(f.Tag, ReportInfo).Alias
                Case cnPORCONCEPTOS, cnPORCONCEPTOSPORTIPO, cnPORCONCEPTOSPORTIPOSUBTIPO
                    If blnConceptos Then
                        f.Enabled = Janus.Windows.UI.InheritableBoolean.True
                    Else
                        f.Enabled = Janus.Windows.UI.InheritableBoolean.False
                    End If
                Case Else
                    If blnConceptos Then
                        f.Enabled = Janus.Windows.UI.InheritableBoolean.False
                    Else
                        f.Enabled = Janus.Windows.UI.InheritableBoolean.True
                    End If
            End Select
        Next

        Return Grid
    End Function

    Private Sub TabObras_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabObras.Click
        ActivateControls()

        CIPrimaryObject = GridActivo()

        'Me.Execute()
    End Sub

    Private Sub ActivateControls()
        With TabObras
            'Activación Criterios de Consulta
            lblFactura.Visible = (.SelectedTab.Key = TabPageMateriales.Key Or .SelectedTab.Key = TabPageMOD.Key Or .SelectedTab.Key = TabPageGastos.Key Or .SelectedTab.Key = TabPageVarios.Key)
            AdvFactura.Visible = lblFactura.Visible
            If .SelectedTab.Key = TabPageMateriales.Key Or .SelectedTab.Key = TabPageGastos.Key Or .SelectedTab.Key = TabPageVarios.Key Then
                AdvFactura.EntityName = "FacturaCompraCabecera"
                AdvFactura.ViewName = "tbFacturaCompraCabecera"
            Else
                AdvFactura.EntityName = "FacturaVentaCabecera"
                AdvFactura.ViewName = "tbFacturaVentaCabecera"
            End If

            pnlTrabajos.Visible = (.SelectedTab.Key = TabPageTrabajos.Key)
            pnlMateriales.Visible = (.SelectedTab.Key = TabPageMateriales.Key)
            pnlMod.Visible = (.SelectedTab.Key = TabPageMOD.Key)
            pnlCentros.Visible = (.SelectedTab.Key = TabPageCentros.Key)
            pnlGastos.Visible = (.SelectedTab.Key = TabPageGastos.Key)
            pnlVarios.Visible = (.SelectedTab.Key = TabPageVarios.Key)

            lblFechaFactDesde.Visible = .SelectedTab.Key <> TabPageCentros.Key
            cbxFechaFactDesde.Visible = lblFechaFactDesde.Visible
            lblFechaFactHasta.Visible = lblFechaFactDesde.Visible
            cbxFechaFactHasta.Visible = lblFechaFactDesde.Visible

            lblFechaControlDesde.Visible = .SelectedTab.Key <> TabPageTrabajos.Key
            cbxFechaControlDesde.Visible = lblFechaControlDesde.Visible
            lblFechaControlHasta.Visible = lblFechaControlDesde.Visible
            cbxFechaControlHasta.Visible = lblFechaControlDesde.Visible

            ''Activación Totales
            'txtTotalPrev.Visible = .SelectedTab.Key = TabPageTrabajos.Key
            'lblTotalPrevisto.Visible = txtTotalPrev.Visible
        End With
    End Sub

#Region " QueryExecute "

    Private Sub CIEstPrevReal_FilterClearing(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.FilterClearing
        AdvObraDesde.Value = System.DBNull.Value : AdvObraDesde.Text = String.Empty
        AdvObraHasta.Value = System.DBNull.Value : AdvObraHasta.Text = String.Empty
        AdvIDTipoObra.Value = System.DBNull.Value : AdvIDTipoObra.Text = String.Empty
        AdvTrabajo.Value = System.DBNull.Value : AdvTrabajo.Text = String.Empty
        AdvTipoTrabajo.Value = System.DBNull.Value : AdvTipoTrabajo.Text = String.Empty
        AdvSubTipoTrabajo.Value = System.DBNull.Value : AdvSubTipoTrabajo.Text = String.Empty
        cbxFechaFactDesde.TextBox.Clear() : cbxFechaFactHasta.TextBox.Clear()
        cbxFechaControlDesde.TextBox.Clear() : cbxFechaControlHasta.TextBox.Clear()
        AdvFactura.Value = System.DBNull.Value : AdvFactura.Text = String.Empty
        txtImpReal.Value = 0
        AdvIDMaterial.Value = System.DBNull.Value : AdvIDMaterial.Text = String.Empty
        AdvIDTipo.Value = System.DBNull.Value : AdvIDTipo.Text = String.Empty
        AdvIDFamilia.Value = System.DBNull.Value : AdvIDFamilia.Text = String.Empty
        AdvIDSubFamilia.Value = System.DBNull.Value : AdvIDSubFamilia.Text = String.Empty
        AdvIDProveedor.Value = System.DBNull.Value : AdvIDProveedor.Text = String.Empty
        AdvIDOperario.Value = System.DBNull.Value : AdvIDOperario.Text = String.Empty
        AdvIDCategoria.Value = System.DBNull.Value : AdvIDCategoria.Text = String.Empty
        AdvIDCentro.Value = System.DBNull.Value : AdvIDCentro.Text = String.Empty
        AdvIDGasto.Value = System.DBNull.Value : AdvIDGasto.Text = String.Empty
        AdvIDObraPadreGasto.Value = System.DBNull.Value : AdvIDObraPadreGasto.Text = String.Empty
        AdvIDVarios.Value = System.DBNull.Value : AdvIDVarios.Text = String.Empty
        CmbEstadoObra.Value = System.DBNull.Value
    End Sub

    Private Sub CIEstPrevReal_QueryExecuted(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutedEventArgs) Handles MyBase.QueryExecuted
        Dim Grid As Solmicro.Expertis.Engine.UI.Grid = GridActivo()
        'If TabObras.SelectedTab.Key = TabPageTrabajos.Key Then
        txtTotalPrev.Value = Grid.GetTotal(Grid.Columns("ImpQPrevA"), AggregateFunction.Sum)
        'End If
        txtTotalReal.Value = Grid.GetTotal(Grid.Columns("ImpRealA"), AggregateFunction.Sum)
    End Sub

    Private Sub CIEstPrevReal_QueryExecuting(ByVal sender As Object, ByRef e As Solmicro.Expertis.Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        If IsNothing(Me.CIPrimaryObject) Then
            Me.CIPrimaryObject = GridTrabajos
        End If
        e.Filter.Add("IDObra", FilterOperator.GreaterThanOrEqual, AdvObraDesde.Value, FilterType.Numeric)
        e.Filter.Add("IDObra", FilterOperator.LessThanOrEqual, AdvObraHasta.Value, FilterType.Numeric)
        e.Filter.Add("IDTrabajo", FilterOperator.Equal, AdvTrabajo.Value, FilterType.Numeric)
        e.Filter.Add("IDTipoObra", FilterOperator.Equal, AdvIDTipoObra.Value, FilterType.String)
        e.Filter.Add("IDTipoTrabajo", FilterOperator.Equal, AdvTipoTrabajo.Value, FilterType.String)
        e.Filter.Add("IDSubTipoTrabajo", FilterOperator.Equal, AdvSubTipoTrabajo.Value, FilterType.String)
        e.Filter.Add("Estado", FilterOperator.Equal, CmbEstadoObra.Value, FilterType.Numeric)
        Select Case TabObras.SelectedTab.Key
            Case TabPageTrabajos.Key ' "Trabajos"
                e.Filter.Add("ImpRealA", FilterOperator.GreaterThan, txtImpReal.Value, FilterType.Numeric)
                e.Filter.Add("FechaInicio", FilterOperator.GreaterThanOrEqual, cbxFechaFactDesde.Value, FilterType.DateTime)
                e.Filter.Add("FechaFin", FilterOperator.LessThanOrEqual, cbxFechaFactHasta.Value, FilterType.DateTime)
                If Length(AdvIDObraPadreTrabajos.Text) > 0 Then
                    Dim f2 As New CIMntoFilter
                    f2.InnerFilter.UnionOperator = FilterUnionOperator.Or
                    f2.Add("IDObraPadre", FilterOperator.Equal, AdvIDObraPadreTrabajos.Value, FilterType.Numeric)
                    f2.Add("IDObra", FilterOperator.Equal, AdvIDObraPadreTrabajos.Value, FilterType.Numeric)
                    Dim fAux As CIMntoFilter = GetObrasPadre(AdvIDObraPadreTrabajos.Value)
                    f2.Add(fAux.InnerFilter)
                    e.Filter.Add(f2.InnerFilter)
                End If
            Case TabPageMateriales.Key '"Materiales"
                e.Filter.Add("FechaFactura", FilterOperator.GreaterThanOrEqual, cbxFechaFactDesde.Value, FilterType.DateTime)
                e.Filter.Add("FechaFactura", FilterOperator.LessThanOrEqual, cbxFechaFactHasta.Value, FilterType.DateTime)
                e.Filter.Add("IDFactura", FilterOperator.Equal, AdvFactura.Value, FilterType.Numeric)
                e.Filter.Add("IDMaterial", FilterOperator.Equal, AdvIDMaterial.Text, FilterType.String)
                e.Filter.Add("IDTipo", FilterOperator.Equal, AdvIDTipo.Text, FilterType.String)
                e.Filter.Add("IDFamilia", FilterOperator.Equal, AdvIDFamilia.Text, FilterType.String)
                e.Filter.Add("IDSubFamilia", FilterOperator.Equal, AdvIDSubFamilia.Text, FilterType.String)
                e.Filter.Add("IDProveedor", FilterOperator.Equal, AdvIDProveedor.Text, FilterType.String)
                e.Filter.Add("Fecha", FilterOperator.GreaterThanOrEqual, cbxFechaControlDesde.Value, FilterType.DateTime)
                e.Filter.Add("Fecha", FilterOperator.LessThanOrEqual, cbxFechaControlHasta.Value, FilterType.DateTime)
                If Length(AdvIDObraPadreTrabajos.Text) > 0 Then
                    Dim f2 As New CIMntoFilter
                    f2.InnerFilter.UnionOperator = FilterUnionOperator.Or
                    f2.Add("IDObraPadre", FilterOperator.Equal, AdvIDObraPadreTrabajos.Value, FilterType.Numeric)
                    f2.Add("IDObra", FilterOperator.Equal, AdvIDObraPadreTrabajos.Value, FilterType.Numeric)
                    Dim fAux As CIMntoFilter = GetObrasPadre(AdvIDObraPadreTrabajos.Value)
                    f2.Add(fAux.InnerFilter)
                    e.Filter.Add(f2.InnerFilter)
                End If
            Case TabPageMOD.Key ' "Mod"
                e.Filter.Add("FechaFactura", FilterOperator.GreaterThanOrEqual, cbxFechaFactDesde.Value, FilterType.DateTime)
                e.Filter.Add("FechaFactura", FilterOperator.LessThanOrEqual, cbxFechaFactHasta.Value, FilterType.DateTime)
                e.Filter.Add("IDFactura", FilterOperator.Equal, AdvFactura.Value, FilterType.Numeric)
                e.Filter.Add("IDOperario", FilterOperator.Equal, AdvIDOperario.Text, FilterType.String)
                e.Filter.Add("IDCategoria", FilterOperator.Equal, AdvIDCategoria.Text, FilterType.String)
                e.Filter.Add("Fecha", FilterOperator.GreaterThanOrEqual, cbxFechaControlDesde.Value, FilterType.DateTime)
                e.Filter.Add("Fecha", FilterOperator.LessThanOrEqual, cbxFechaControlHasta.Value, FilterType.DateTime)
                If Length(AdvIDObraPadreMOD.Text) > 0 Then
                    Dim f2 As New CIMntoFilter
                    f2.InnerFilter.UnionOperator = FilterUnionOperator.Or
                    f2.Add("IDObraPadre", FilterOperator.Equal, AdvIDObraPadreMOD.Value, FilterType.Numeric)
                    f2.Add("IDObra", FilterOperator.Equal, AdvIDObraPadreMOD.Value, FilterType.Numeric)
                    Dim fAux As CIMntoFilter = GetObrasPadre(AdvIDObraPadreMOD.Value)
                    f2.Add(fAux.InnerFilter)
                    e.Filter.Add(f2.InnerFilter)
                End If
            Case TabPageCentros.Key ' "Centros"
                e.Filter.Add("IdCentro", FilterOperator.Equal, AdvIDCentro.Text, FilterType.String)
                e.Filter.Add("Fecha", FilterOperator.GreaterThanOrEqual, cbxFechaControlDesde.Value, FilterType.DateTime)
                e.Filter.Add("Fecha", FilterOperator.LessThanOrEqual, cbxFechaControlHasta.Value, FilterType.DateTime)
                If Length(AdvIDObraPadreCentro.Text) > 0 Then
                    Dim f2 As New CIMntoFilter
                    f2.InnerFilter.UnionOperator = FilterUnionOperator.Or
                    f2.Add("IDObraPadre", FilterOperator.Equal, AdvIDObraPadreCentro.Value, FilterType.Numeric)
                    f2.Add("IDObra", FilterOperator.Equal, AdvIDObraPadreCentro.Value, FilterType.Numeric)
                    Dim fAux As CIMntoFilter = GetObrasPadre(AdvIDObraPadreCentro.Value)
                    f2.Add(fAux.InnerFilter)
                    e.Filter.Add(f2.InnerFilter)
                End If
            Case TabPageGastos.Key ' "Gastos"
                e.Filter.Add("IdGasto", FilterOperator.Equal, AdvIDGasto.Text, FilterType.String)
                e.Filter.Add("Fecha", FilterOperator.GreaterThanOrEqual, cbxFechaControlDesde.Value, FilterType.DateTime)
                e.Filter.Add("Fecha", FilterOperator.LessThanOrEqual, cbxFechaControlHasta.Value, FilterType.DateTime)
                e.Filter.Add("FechaFactura", FilterOperator.GreaterThanOrEqual, cbxFechaFactDesde.Value, FilterType.DateTime)
                e.Filter.Add("FechaFactura", FilterOperator.LessThanOrEqual, cbxFechaFactHasta.Value, FilterType.DateTime)
                e.Filter.Add("IDFactura", FilterOperator.Equal, AdvFactura.Value, FilterType.Numeric)

                If Length(AdvIDObraPadreGasto.Text) > 0 Then
                    Dim f2 As New CIMntoFilter
                    f2.InnerFilter.UnionOperator = FilterUnionOperator.Or
                    f2.Add("IDObraPadre", FilterOperator.Equal, AdvIDObraPadreGasto.Value, FilterType.Numeric)
                    f2.Add("IDObra", FilterOperator.Equal, AdvIDObraPadreGasto.Value, FilterType.Numeric)
                    Dim fAux As CIMntoFilter = GetObrasPadre(AdvIDObraPadreGasto.Value)
                    f2.Add(fAux.InnerFilter)
                    e.Filter.Add(f2.InnerFilter)
                End If
            Case TabPageVarios.Key ' "Varios"
                e.Filter.Add("Fecha", FilterOperator.GreaterThanOrEqual, cbxFechaControlDesde.Value, FilterType.DateTime)
                e.Filter.Add("Fecha", FilterOperator.LessThanOrEqual, cbxFechaControlHasta.Value, FilterType.DateTime)
                e.Filter.Add("FechaFactura", FilterOperator.GreaterThanOrEqual, cbxFechaFactDesde.Value, FilterType.DateTime)
                e.Filter.Add("FechaFactura", FilterOperator.LessThanOrEqual, cbxFechaFactHasta.Value, FilterType.DateTime)
                e.Filter.Add("IDFactura", FilterOperator.Equal, AdvFactura.Value, FilterType.Numeric)
                e.Filter.Add("IdVarios", FilterOperator.Equal, AdvIDVarios.Text, FilterType.String)

                If Length(AdvIDObraPadreVarios.Text) > 0 Then
                    Dim f2 As New CIMntoFilter
                    f2.InnerFilter.UnionOperator = FilterUnionOperator.Or
                    f2.Add("IDObraPadre", FilterOperator.Equal, AdvIDObraPadreVarios.Value, FilterType.Numeric)
                    f2.Add("IDObra", FilterOperator.Equal, AdvIDObraPadreVarios.Value, FilterType.Numeric)
                    Dim fAux As CIMntoFilter = GetObrasPadre(AdvIDObraPadreVarios.Value)
                    f2.Add(fAux.InnerFilter)
                    e.Filter.Add(f2.InnerFilter)
                End If
        End Select
    End Sub

    Private Function GetObrasPadre(ByVal idObraPadre As Integer) As CIMntoFilter
        If idObraPadre > 0 Then
            Dim f As New CIMntoFilter
            f.InnerFilter.UnionOperator = FilterUnionOperator.Or

            Dim OC As New ObraCabecera
            Dim dt As DataTable = OC.Filter(New NumberFilterItem("IDObraPadre", idObraPadre), "", "IDObra")
            If Not dt Is Nothing AndAlso dt.Rows.Count > 0 Then
                For Each dr As DataRow In dt.Rows
                    Dim fAux As CIMntoFilter = GetObrasPadre(dr("IDObra"))
                    f.Add(fAux.InnerFilter)
                Next
            End If

            Return f
        End If
    End Function

#End Region

#Region " Predefined Filter "

    Private Sub AdvIDFamilia_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles AdvIDFamilia.SetPredefinedFilter
        If Length(AdvIDTipo.Text) > 0 Then
            e.Filter.Add(New StringFilterItem("IDTipo", FilterOperator.Equal, AdvIDTipo.Text))
        End If
    End Sub

    Private Sub AdvIDSubFamilia_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles AdvIDSubFamilia.SetPredefinedFilter
        If Length(AdvIDTipo.Text) > 0 Then
            e.Filter.Add(New StringFilterItem("IDTipo", FilterOperator.Equal, AdvIDTipo.Text))
        End If
        If Length(AdvIDFamilia.Text) > 0 Then
            e.Filter.Add(New StringFilterItem("IdFamilia", FilterOperator.Equal, AdvIDFamilia.Text))
        End If
    End Sub

    Private Sub AdvIDMaterial_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles AdvIDMaterial.SetPredefinedFilter
        If Length(AdvIDTipo.Text) > 0 Then
            e.Filter.Add(New StringFilterItem("IDTipo", FilterOperator.Equal, AdvIDTipo.Text))
        End If
        If Length(AdvIDFamilia.Text) > 0 Then
            e.Filter.Add(New StringFilterItem("IdFamilia", FilterOperator.Equal, AdvIDFamilia.Text))
        End If
        If Length(AdvIDSubFamilia.Text) > 0 Then
            e.Filter.Add(New StringFilterItem("IdSubfamilia", FilterOperator.Equal, AdvIDSubFamilia.Text))
        End If
    End Sub

    Private Sub AdvTipoTrabajo_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles AdvTipoTrabajo.SetPredefinedFilter
        If Length(AdvIDTipoObra.Text) > 0 Then
            e.Filter.Add(New StringFilterItem("IDTipoObra", FilterOperator.Equal, AdvIDTipoObra.Text))
        End If
    End Sub

    Private Sub AdvSubTipoTrabajo_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles AdvSubTipoTrabajo.SetPredefinedFilter
        If Length(AdvIDTipoObra.Text) > 0 Then
            e.Filter.Add(New StringFilterItem("IDTipoObra", FilterOperator.Equal, AdvIDTipoObra.Text))
        End If
        If Length(AdvTipoTrabajo.Text) > 0 Then
            e.Filter.Add(New StringFilterItem("IDTipoTrabajo", FilterOperator.Equal, AdvTipoTrabajo.Text))
        End If
    End Sub

    Private Sub AdvTrabajo_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles AdvTrabajo.SetPredefinedFilter
        If Length(AdvIDTipoObra.Text) > 0 Then
            e.Filter.Add(New StringFilterItem("IDTipoObra", FilterOperator.Equal, AdvIDTipoObra.Text))
        End If
        If Length(AdvTipoTrabajo.Text) > 0 Then
            e.Filter.Add(New StringFilterItem("IDTipoTrabajo", FilterOperator.Equal, AdvTipoTrabajo.Text))
        End If
        If Length(AdvSubTipoTrabajo.Text) > 0 Then
            e.Filter.Add(New StringFilterItem("IDSubTipoTrabajo", FilterOperator.Equal, AdvSubTipoTrabajo.Text))
        End If
    End Sub

#End Region

    Private Sub Grid_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridMateriales.MouseUp, GridMod.MouseUp, GridGastos.MouseUp, GridVarios.MouseUp
        If e.Button = MouseButtons.Right Then
            Dim blnVerFactura As Janus.Windows.UI.InheritableBoolean = Janus.Windows.UI.InheritableBoolean.False
            Dim Grid As Solmicro.Expertis.Engine.UI.Grid = GridActivo()
            If Grid.RowCount > 0 Then
                If Length(Grid.Value("IDFactura")) > 0 Then blnVerFactura = Janus.Windows.UI.InheritableBoolean.True
                Select Case TabObras.SelectedTab.Key
                    Case "Materiales", "Gastos", "Varios"
                        Grid.UiCommandManager1.Commands("Abrir Factura Compra").Visible = blnVerFactura
                    Case "Mod"
                        Grid.UiCommandManager1.Commands("Abrir Factura Venta").Visible = blnVerFactura
                End Select
            End If
        End If
    End Sub

#Region " Informes "

    Private Sub CIEstPrevReal_SetReportSelectionCriteria(ByVal sender As Object, ByVal e As Engine.UI.ReportSelectionCriteriaEventArgs) Handles MyBase.SetReportSelectionCriteria
        If Length(AdvObraDesde.Value) > 0 Then e.Filter.Add(New NumberFilterItem("IDObra", FilterOperator.GreaterThanOrEqual, AdvObraDesde.Value))
        If Length(AdvObraHasta.Value) > 0 Then e.Filter.Add(New NumberFilterItem("IDObra", FilterOperator.LessThanOrEqual, AdvObraHasta.Value))
    End Sub

    Private Sub CIEstPrevReal_SetReportDesignObjects(ByVal sender As Object, ByVal e As Engine.UI.ReportDesignObjectsEventArgs) Handles MyBase.SetReportDesignObjects
        Select Case e.Alias
            Case cnPORCONCEPTOS, cnPORCONCEPTOSPORTIPO, cnPORCONCEPTOSPORTIPOSUBTIPO
                Dim frm As New frmConfiguraInforme
                Dim info As infoConceptosImprimir = frm.AbrirConfiguracion(TabObras.SelectedTab.Key)
                If Not info.Cancel Then
                    Select Case TabObras.SelectedTab.Key
                        Case "Materiales"
                            e.Subreports("Materiales").DataSource = GridMateriales.DataSource
                        Case "MOD"
                            e.Subreports("MOD").DataSource = GridMod.DataSource
                        Case "Centros"
                            e.Subreports("Centros").DataSource = GridCentros.DataSource
                        Case "Gastos"
                            e.Subreports("Gastos").DataSource = GridGastos.DataSource
                        Case "Varios"
                            e.Subreports("Varios").DataSource = GridVarios.DataSource
                    End Select
                    e.Formulas("Materiales").Text = info.Material
                    e.Formulas("Mod").Text = info.ManoObra
                    e.Formulas("Centros").Text = info.Centro
                    e.Formulas("Gastos").Text = info.Gasto
                    e.Formulas("Varios").Text = info.Varios
                Else
                    e.Cancel = True
                End If
        End Select
    End Sub

#End Region

    Private Sub ShowFilterPanel1_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles ShowFilterPanel1.Click
        FilterPanel.Visible = Not FilterPanel.Visible
    End Sub

    Private Sub AdvObraDesde_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles AdvObraDesde.LostFocus
        AdvObraHasta.Value = AdvObraDesde.Value()
        AdvObraHasta.Text = AdvObraDesde.Text
    End Sub

End Class