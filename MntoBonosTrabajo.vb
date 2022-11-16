Public Class MntoBonosTrabajo
    Inherits Solmicro.Expertis.Engine.UI.SimpleMnto

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
    Public WithEvents SplitterV As System.Windows.Forms.Splitter

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Public WithEvents lblObra As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents AdvIDObra As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents cbxFechaControl As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents txtIDOperario As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents cbxFilterOption As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents ulDescOperario As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents lblOperario As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblFechaControl As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents pnlFilterOptions As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents pnlTop As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents pnlArbol As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents pnlTrabajoSeleccionado As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents lblTrabajoControl As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents pnlHoras As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents lblHora As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents SplitterH As System.Windows.Forms.Splitter
    Public WithEvents TabPageMateriales As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents TabPageCentros As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents TabPageGastos As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents Line1 As Janus.Windows.EditControls.UIGroupBox
    Public WithEvents TvwTrabajos As System.Windows.Forms.TreeView
    Public WithEvents GridMaterialControl As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents GridCentroControl As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents GridGastosControl As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents pnlTotalMateriales As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents pnlTotalCentros As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents txtTotalCentros As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents pnlTotalGastos As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents txtTotalGastos As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents txtTotalMateriales As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblTotalCentros As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblTotalGastos As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblTotalMateriales As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents TabPageVarios As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents pnlTotalVarios As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents lblTotalVarios As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtTotalVarios As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents GridVariosControl As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents lblTotalHoras As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtTotalHoras As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents GridMODControl As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents txtDescTrabajo As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents txtTrabajo As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents pnlTotalMOD As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents pnlLabelHoras As System.Windows.Forms.Panel
    Public WithEvents pnlTab As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents cmdTarea As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents mnuArbol As Janus.Windows.UI.CommandBars.UIContextMenu
    Public WithEvents cmdTarea1 As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents cmdAbrirTarea As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents cmdAbrirTarea1 As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents cmdAbrirObra As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents cmdAbrirObra1 As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents pnlLeft As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents Tab As Solmicro.Expertis.Engine.UI.Tab
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim cbxFilterOption_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridMODControl_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridMaterialControl_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridMaterialControl_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column6.ButtonImage")
        Dim GridMaterialControl_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.ImageList.ImageStream")
        Dim GridCentroControl_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridCentroControl_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column5.ButtonImage")
        Dim GridCentroControl_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column12.ButtonImage")
        Dim GridGastosControl_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridGastosControl_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column5.ButtonImage")
        Dim GridGastosControl_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column7.ButtonImage")
        Dim GridGastosControl_DesignTimeLayout_Reference_2 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column16.ButtonImage")
        Dim GridVariosControl_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridVariosControl_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column5.ButtonImage")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MntoBonosTrabajo))
        Me.pnlTop = New Solmicro.Expertis.Engine.UI.Panel
        Me.Line1 = New Janus.Windows.EditControls.UIGroupBox
        Me.lblOperario = New Solmicro.Expertis.Engine.UI.Label
        Me.ulDescOperario = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.txtIDOperario = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblFechaControl = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaControl = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.pnlArbol = New Solmicro.Expertis.Engine.UI.Panel
        Me.TvwTrabajos = New System.Windows.Forms.TreeView
        Me.pnlFilterOptions = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblObra = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDObra = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.cbxFilterOption = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.SplitterV = New System.Windows.Forms.Splitter
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.pnlTrabajoSeleccionado = New Solmicro.Expertis.Engine.UI.Panel
        Me.txtDescTrabajo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblTrabajoControl = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTrabajo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.pnlHoras = New Solmicro.Expertis.Engine.UI.Panel
        Me.GridMODControl = New Solmicro.Expertis.Engine.UI.Grid
        Me.pnlTotalMOD = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblTotalHoras = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTotalHoras = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.pnlLabelHoras = New System.Windows.Forms.Panel
        Me.lblHora = New Solmicro.Expertis.Engine.UI.Label
        Me.SplitterH = New System.Windows.Forms.Splitter
        Me.pnlTab = New Solmicro.Expertis.Engine.UI.Panel
        Me.Tab = New Solmicro.Expertis.Engine.UI.Tab
        Me.TabPageMateriales = New Janus.Windows.UI.Tab.UITabPage
        Me.GridMaterialControl = New Solmicro.Expertis.Engine.UI.Grid
        Me.pnlTotalMateriales = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblTotalMateriales = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTotalMateriales = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.TabPageCentros = New Janus.Windows.UI.Tab.UITabPage
        Me.GridCentroControl = New Solmicro.Expertis.Engine.UI.Grid
        Me.pnlTotalCentros = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblTotalCentros = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTotalCentros = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.TabPageGastos = New Janus.Windows.UI.Tab.UITabPage
        Me.GridGastosControl = New Solmicro.Expertis.Engine.UI.Grid
        Me.pnlTotalGastos = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblTotalGastos = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTotalGastos = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.TabPageVarios = New Janus.Windows.UI.Tab.UITabPage
        Me.GridVariosControl = New Solmicro.Expertis.Engine.UI.Grid
        Me.pnlTotalVarios = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblTotalVarios = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTotalVarios = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.cmdTarea = New Janus.Windows.UI.CommandBars.UICommand("cmdTarea")
        Me.mnuArbol = New Janus.Windows.UI.CommandBars.UIContextMenu
        Me.cmdAbrirObra1 = New Janus.Windows.UI.CommandBars.UICommand("cmdAbrirObra")
        Me.cmdTarea1 = New Janus.Windows.UI.CommandBars.UICommand("cmdTarea")
        Me.cmdAbrirTarea1 = New Janus.Windows.UI.CommandBars.UICommand("cmdAbrirTarea")
        Me.cmdAbrirTarea = New Janus.Windows.UI.CommandBars.UICommand("cmdAbrirTarea")
        Me.cmdAbrirObra = New Janus.Windows.UI.CommandBars.UICommand("cmdAbrirObra")
        Me.pnlLeft = New Solmicro.Expertis.Engine.UI.Panel
        CType(Me.ToolBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.suspendlayout()
        Me.pnlTop.suspendlayout()
        CType(Me.Line1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlArbol.suspendlayout()
        Me.pnlFilterOptions.suspendlayout()
        CType(Me.cbxFilterOption, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTrabajoSeleccionado.suspendlayout()
        Me.pnlHoras.suspendlayout()
        CType(Me.GridMODControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTotalMOD.suspendlayout()
        Me.pnlLabelHoras.SuspendLayout()
        Me.pnlTab.suspendlayout()
        CType(Me.Tab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tab.SuspendLayout()
        Me.TabPageMateriales.SuspendLayout()
        CType(Me.GridMaterialControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTotalMateriales.suspendlayout()
        Me.TabPageCentros.SuspendLayout()
        CType(Me.GridCentroControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTotalCentros.suspendlayout()
        Me.TabPageGastos.SuspendLayout()
        CType(Me.GridGastosControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTotalGastos.suspendlayout()
        Me.TabPageVarios.SuspendLayout()
        CType(Me.GridVariosControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTotalVarios.suspendlayout()
        CType(Me.mnuArbol, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLeft.suspendlayout()
        Me.SuspendLayout()
        '
        'Duplicate
        '
        Me.Duplicate.Visible = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'ToolBar
        '
        Me.ToolBar.Size = New System.Drawing.Size(643, 39)
        '
        'MenuBar
        '
        Me.MenuBar.Location = New System.Drawing.Point(0, 39)
        Me.MenuBar.Size = New System.Drawing.Size(504, 26)
        '
        'UiCommandManager1
        '
        Me.UiCommandManager1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.cmdTarea, Me.cmdAbrirTarea, Me.cmdAbrirObra})
        Me.UiCommandManager1.ContextMenus.AddRange(New Janus.Windows.UI.CommandBars.UIContextMenu() {Me.mnuArbol})
        '
        'GoFirst
        '
        Me.GoFirst.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'GoPrevious
        '
        Me.GoPrevious.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'GoNext
        '
        Me.GoNext.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'Delete
        '
        Me.Delete.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        Me.Delete.Visible = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'Ok
        '
        Me.Ok.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'Cancel
        '
        Me.Cancel.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'Print
        '
        Me.Print.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'Search
        '
        Me.Search.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'GoLast
        '
        Me.GoLast.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'FindText
        '
        Me.FindText.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'Find
        '
        Me.Find.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'NewRow
        '
        Me.NewRow.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        Me.NewRow.Visible = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'Requery
        '
        Me.Requery.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'ExecuteActions
        '
        Me.ExecuteActions.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        Me.ExecuteActions.Visible = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'MainPanel
        '
        Me.MainPanel.Controls.Add(Me.pnlTab)
        Me.MainPanel.Controls.Add(Me.SplitterH)
        Me.MainPanel.Controls.Add(Me.pnlHoras)
        Me.MainPanel.Controls.Add(Me.pnlTrabajoSeleccionado)
        Me.MainPanel.Controls.Add(Me.SplitterV)
        Me.MainPanel.Controls.Add(Me.pnlLeft)
        Me.MainPanel.Controls.Add(Me.pnlTop)
        Me.MainPanel.Size = New System.Drawing.Size(777, 489)
        '
        'pnlTop
        '
        Me.pnlTop.Controls.Add(Me.Line1)
        Me.pnlTop.Controls.Add(Me.lblOperario)
        Me.pnlTop.Controls.Add(Me.ulDescOperario)
        Me.pnlTop.Controls.Add(Me.txtIDOperario)
        Me.pnlTop.Controls.Add(Me.lblFechaControl)
        Me.pnlTop.Controls.Add(Me.cbxFechaControl)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(777, 27)
        Me.pnlTop.TabIndex = 2
        '
        'Line1
        '
        Me.Line1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Line1.Location = New System.Drawing.Point(0, 26)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.Size(793, 2)
        Me.Line1.TabIndex = 24
        '
        'lblOperario
        '
        Me.lblOperario.Location = New System.Drawing.Point(2, 6)
        Me.lblOperario.Name = "lblOperario"
        Me.lblOperario.Size = New System.Drawing.Size(57, 13)
        Me.lblOperario.TabIndex = 0
        Me.lblOperario.Tag = ""
        Me.lblOperario.Text = "Operario"
        '
        'ulDescOperario
        '
        Me.TryDataBinding(ulDescOperario, New System.Windows.Forms.Binding("Text", Me, "DescOperario", True))
        Me.ulDescOperario.Location = New System.Drawing.Point(153, 2)
        Me.ulDescOperario.Name = "ulDescOperario"
        Me.ulDescOperario.Size = New System.Drawing.Size(321, 21)
        Me.ulDescOperario.TabIndex = 1
        '
        'txtIDOperario
        '
        Me.TryDataBinding(txtIDOperario, New System.Windows.Forms.Binding("Text", Me, "IDOperario", True))
        Me.txtIDOperario.DisabledBackColor = System.Drawing.Color.White
        Me.txtIDOperario.Location = New System.Drawing.Point(62, 2)
        Me.txtIDOperario.Name = "txtIDOperario"
        Me.txtIDOperario.Size = New System.Drawing.Size(88, 21)
        Me.txtIDOperario.TabIndex = 22
        '
        'lblFechaControl
        '
        Me.lblFechaControl.Location = New System.Drawing.Point(480, 6)
        Me.lblFechaControl.Name = "lblFechaControl"
        Me.lblFechaControl.Size = New System.Drawing.Size(86, 13)
        Me.lblFechaControl.TabIndex = 23
        Me.lblFechaControl.Tag = ""
        Me.lblFechaControl.Text = "Fecha Control"
        '
        'cbxFechaControl
        '
        Me.cbxFechaControl.DateFormat = Janus.Windows.CalendarCombo.DateFormat.[Long]
        Me.cbxFechaControl.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaControl.HourIncrement = 0
        Me.cbxFechaControl.Location = New System.Drawing.Point(572, 2)
        Me.cbxFechaControl.MinuteIncrement = 0
        Me.cbxFechaControl.Name = "cbxFechaControl"
        Me.cbxFechaControl.SecondIncrement = 0
        Me.cbxFechaControl.ShowUpDown = True
        Me.cbxFechaControl.Size = New System.Drawing.Size(200, 21)
        Me.cbxFechaControl.TabIndex = 2
        Me.cbxFechaControl.YearIncrement = 0
        '
        'pnlArbol
        '
        Me.pnlArbol.Controls.Add(Me.TvwTrabajos)
        Me.pnlArbol.Controls.Add(Me.pnlFilterOptions)
        Me.pnlArbol.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlArbol.Location = New System.Drawing.Point(0, 0)
        Me.pnlArbol.Name = "pnlArbol"
        Me.pnlArbol.Size = New System.Drawing.Size(227, 462)
        Me.pnlArbol.TabIndex = 3
        '
        'TvwTrabajos
        '
        Me.TvwTrabajos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TvwTrabajos.Location = New System.Drawing.Point(0, 52)
        Me.TvwTrabajos.Name = "TvwTrabajos"
        Me.TvwTrabajos.Size = New System.Drawing.Size(227, 410)
        Me.TvwTrabajos.TabIndex = 23
        '
        'pnlFilterOptions
        '
        Me.pnlFilterOptions.Controls.Add(Me.lblObra)
        Me.pnlFilterOptions.Controls.Add(Me.AdvIDObra)
        Me.pnlFilterOptions.Controls.Add(Me.cbxFilterOption)
        Me.pnlFilterOptions.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFilterOptions.Location = New System.Drawing.Point(0, 0)
        Me.pnlFilterOptions.Name = "pnlFilterOptions"
        Me.pnlFilterOptions.Size = New System.Drawing.Size(227, 52)
        Me.pnlFilterOptions.TabIndex = 22
        '
        'lblObra
        '
        Me.lblObra.Location = New System.Drawing.Point(2, 32)
        Me.lblObra.Name = "lblObra"
        Me.lblObra.Size = New System.Drawing.Size(57, 13)
        Me.lblObra.TabIndex = 24
        Me.lblObra.Tag = ""
        Me.lblObra.Text = "Proyecto"
        '
        'AdvIDObra
        '
        Me.AdvIDObra.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDObra.DisplayField = "NObra"
        Me.AdvIDObra.EntityName = "ObraCabecera"
        Me.AdvIDObra.Location = New System.Drawing.Point(62, 28)
        Me.AdvIDObra.Name = "AdvIDObra"
        Me.AdvIDObra.SecondaryDataFields = "IDObra"
        Me.AdvIDObra.Size = New System.Drawing.Size(161, 23)
        Me.AdvIDObra.TabIndex = 3
        Me.AdvIDObra.ViewName = "vSearchObrasOperario"
        '
        'cbxFilterOption
        '
        Me.cbxFilterOption.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        cbxFilterOption_DesignTimeLayout.LayoutString = resources.GetString("cbxFilterOption_DesignTimeLayout.LayoutString")
        Me.cbxFilterOption.DesignTimeLayout = cbxFilterOption_DesignTimeLayout
        Me.cbxFilterOption.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFilterOption.Location = New System.Drawing.Point(5, 4)
        Me.cbxFilterOption.Name = "cbxFilterOption"
        Me.cbxFilterOption.SelectedIndex = -1
        Me.cbxFilterOption.SelectedItem = Nothing
        Me.cbxFilterOption.Size = New System.Drawing.Size(218, 21)
        Me.cbxFilterOption.TabIndex = 4
        '
        'SplitterV
        '
        Me.SplitterV.Location = New System.Drawing.Point(227, 27)
        Me.SplitterV.Name = "SplitterV"
        Me.SplitterV.Size = New System.Drawing.Size(5, 462)
        Me.SplitterV.TabIndex = 8
        Me.SplitterV.TabStop = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        Me.ImageList1.Images.SetKeyName(2, "")
        Me.ImageList1.Images.SetKeyName(3, "")
        Me.ImageList1.Images.SetKeyName(4, "")
        Me.ImageList1.Images.SetKeyName(5, "")
        Me.ImageList1.Images.SetKeyName(6, "cubes_yellow.ico")
        Me.ImageList1.Images.SetKeyName(7, "BarCode.ico")
        '
        'pnlTrabajoSeleccionado
        '
        Me.pnlTrabajoSeleccionado.Controls.Add(Me.txtDescTrabajo)
        Me.pnlTrabajoSeleccionado.Controls.Add(Me.lblTrabajoControl)
        Me.pnlTrabajoSeleccionado.Controls.Add(Me.txtTrabajo)
        Me.pnlTrabajoSeleccionado.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTrabajoSeleccionado.Location = New System.Drawing.Point(232, 27)
        Me.pnlTrabajoSeleccionado.Name = "pnlTrabajoSeleccionado"
        Me.pnlTrabajoSeleccionado.Size = New System.Drawing.Size(545, 29)
        Me.pnlTrabajoSeleccionado.TabIndex = 15
        Me.pnlTrabajoSeleccionado.Visible = False
        '
        'txtDescTrabajo
        '
        Me.txtDescTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescTrabajo.Enabled = False
        Me.txtDescTrabajo.Location = New System.Drawing.Point(188, 4)
        Me.txtDescTrabajo.Name = "txtDescTrabajo"
        Me.txtDescTrabajo.Size = New System.Drawing.Size(356, 21)
        Me.txtDescTrabajo.TabIndex = 201
        Me.txtDescTrabajo.TabStop = False
        '
        'lblTrabajoControl
        '
        Me.lblTrabajoControl.Location = New System.Drawing.Point(5, 7)
        Me.lblTrabajoControl.Name = "lblTrabajoControl"
        Me.lblTrabajoControl.Size = New System.Drawing.Size(50, 13)
        Me.lblTrabajoControl.TabIndex = 200
        Me.lblTrabajoControl.Tag = ""
        Me.lblTrabajoControl.Text = "Trabajo"
        '
        'txtTrabajo
        '
        Me.txtTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.txtTrabajo.Enabled = False
        Me.txtTrabajo.Location = New System.Drawing.Point(60, 4)
        Me.txtTrabajo.Name = "txtTrabajo"
        Me.txtTrabajo.Size = New System.Drawing.Size(124, 21)
        Me.txtTrabajo.TabIndex = 199
        Me.txtTrabajo.TabStop = False
        '
        'pnlHoras
        '
        Me.pnlHoras.Controls.Add(Me.GridMODControl)
        Me.pnlHoras.Controls.Add(Me.pnlTotalMOD)
        Me.pnlHoras.Controls.Add(Me.pnlLabelHoras)
        Me.pnlHoras.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHoras.Location = New System.Drawing.Point(232, 56)
        Me.pnlHoras.Name = "pnlHoras"
        Me.pnlHoras.Size = New System.Drawing.Size(545, 284)
        Me.pnlHoras.TabIndex = 23
        '
        'GridMODControl
        '
        Me.GridMODControl.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("NTarea", "ObraTarea", "NTarea", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDTarea", "IDTarea"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescTarea", "DescTarea"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDTrabajo", "IDTrabajo"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IdObra", "IdObra"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("NObra", "NObra"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("CodTrabajo", "CodTrabajo"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescTrabajo", "DescTrabajo")}), "VTareasOperarioObra"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IdHora", "Hora", "IdHora", "tbmaestrohora"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IdTipoTrabajo", "ObraTrabajo", "IdTipoTrabajo", "tbObraTrabajo"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("CodTrabajo", "ObraTrabajo", "CodTrabajo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDTrabajo", "IDTrabajo"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDObra", "IDObra")}), "vSearchObraTrabajo"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("NObra", "ObraCabecera", "NObra", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDObra", "IDObra"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDCliente", "IDCliente")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDLineaMod", "ObraMOD", "IDLineaMod", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("PrecioVentaA", "PrecioVentaA"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("Facturable", "Facturable")}))})
        GridMODControl_DesignTimeLayout.LayoutString = resources.GetString("GridMODControl_DesignTimeLayout.LayoutString")
        Me.GridMODControl.DesignTimeLayout = GridMODControl_DesignTimeLayout
        Me.GridMODControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridMODControl.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridMODControl.EntityName = "ObraMODControl"
        Me.GridMODControl.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridMODControl.FrozenColumns = 6
        Me.GridMODControl.Location = New System.Drawing.Point(0, 21)
        Me.GridMODControl.Name = "GridMODControl"
        Me.GridMODControl.PrimaryDataFields = "IDOperario"
        Me.GridMODControl.RequeryManually = True
        Me.GridMODControl.SecondaryDataFields = "IDOperario"
        Me.GridMODControl.Size = New System.Drawing.Size(545, 235)
        Me.GridMODControl.TabIndex = 15
        Me.GridMODControl.ViewName = "vFrmObraControlMOD"
        '
        'pnlTotalMOD
        '
        Me.pnlTotalMOD.Controls.Add(Me.lblTotalHoras)
        Me.pnlTotalMOD.Controls.Add(Me.txtTotalHoras)
        Me.pnlTotalMOD.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlTotalMOD.Location = New System.Drawing.Point(0, 256)
        Me.pnlTotalMOD.Name = "pnlTotalMOD"
        Me.pnlTotalMOD.Size = New System.Drawing.Size(545, 28)
        Me.pnlTotalMOD.TabIndex = 14
        '
        'lblTotalHoras
        '
        Me.lblTotalHoras.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalHoras.Location = New System.Drawing.Point(362, 8)
        Me.lblTotalHoras.Name = "lblTotalHoras"
        Me.lblTotalHoras.Size = New System.Drawing.Size(59, 13)
        Me.lblTotalHoras.TabIndex = 103
        Me.lblTotalHoras.Text = "Total hoy"
        '
        'txtTotalHoras
        '
        Me.txtTotalHoras.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalHoras.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotalHoras.Enabled = False
        Me.txtTotalHoras.Location = New System.Drawing.Point(427, 4)
        Me.txtTotalHoras.Name = "txtTotalHoras"
        Me.txtTotalHoras.Size = New System.Drawing.Size(114, 21)
        Me.txtTotalHoras.TabIndex = 102
        Me.txtTotalHoras.TabStop = False
        '
        'pnlLabelHoras
        '
        Me.pnlLabelHoras.Controls.Add(Me.lblHora)
        Me.pnlLabelHoras.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlLabelHoras.Location = New System.Drawing.Point(0, 0)
        Me.pnlLabelHoras.Name = "pnlLabelHoras"
        Me.pnlLabelHoras.Size = New System.Drawing.Size(545, 21)
        Me.pnlLabelHoras.TabIndex = 13
        '
        'lblHora
        '
        Me.lblHora.Location = New System.Drawing.Point(8, 3)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(40, 13)
        Me.lblHora.TabIndex = 15
        Me.lblHora.Text = "Horas"
        '
        'SplitterH
        '
        Me.SplitterH.Cursor = System.Windows.Forms.Cursors.HSplit
        Me.SplitterH.Dock = System.Windows.Forms.DockStyle.Top
        Me.SplitterH.Location = New System.Drawing.Point(232, 340)
        Me.SplitterH.Name = "SplitterH"
        Me.SplitterH.Size = New System.Drawing.Size(545, 3)
        Me.SplitterH.TabIndex = 29
        Me.SplitterH.TabStop = False
        '
        'pnlTab
        '
        Me.pnlTab.Controls.Add(Me.Tab)
        Me.pnlTab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTab.Location = New System.Drawing.Point(232, 343)
        Me.pnlTab.Name = "pnlTab"
        Me.pnlTab.Size = New System.Drawing.Size(545, 146)
        Me.pnlTab.TabIndex = 30
        '
        'Tab
        '
        Me.Tab.BackColor = System.Drawing.Color.White
        Me.Tab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tab.Location = New System.Drawing.Point(0, 0)
        Me.Tab.Name = "Tab"
        Me.Tab.Size = New System.Drawing.Size(545, 146)
        Me.Tab.TabIndex = 7
        Me.Tab.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.TabPageMateriales, Me.TabPageCentros, Me.TabPageGastos, Me.TabPageVarios})
        Me.Tab.Text = "Centros"
        Me.Tab.UseThemes = True
        '
        'TabPageMateriales
        '
        Me.TabPageMateriales.Controls.Add(Me.GridMaterialControl)
        Me.TabPageMateriales.Controls.Add(Me.pnlTotalMateriales)
        Me.TabPageMateriales.Key = "Materiales"
        Me.TabPageMateriales.Location = New System.Drawing.Point(1, 21)
        Me.TabPageMateriales.Name = "TabPageMateriales"
        Me.TabPageMateriales.Size = New System.Drawing.Size(543, 124)
        Me.TabPageMateriales.TabStop = True
        Me.TabPageMateriales.Text = "Materiales"
        '
        'GridMaterialControl
        '
        Me.GridMaterialControl.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("NObra", "ObraCabecera", "NObra", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDObra", "IDObra")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("CodTrabajo", "ObraTrabajo", "CodTrabajo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDTrabajo", "IDTrabajo"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDObra", "IDObra")}), "vSearchObraTrabajo"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDMaterial", "Articulo", "IDArticulo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescArticulo", "DescMaterial"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("UdValoracion", "UdValoracion")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDLineaMaterial", "ObraMaterial", "IDLineaMaterial"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDAlmacen", "Almacen", "IDAlmacen")})
        GridMaterialControl_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("GridMaterialControl_DesignTimeLayout_Reference_0.Instance"), Object)
        GridMaterialControl_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("GridMaterialControl_DesignTimeLayout_Reference_1.Instance"), Object)
        GridMaterialControl_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {GridMaterialControl_DesignTimeLayout_Reference_0, GridMaterialControl_DesignTimeLayout_Reference_1})
        GridMaterialControl_DesignTimeLayout.LayoutString = resources.GetString("GridMaterialControl_DesignTimeLayout.LayoutString")
        Me.GridMaterialControl.DesignTimeLayout = GridMaterialControl_DesignTimeLayout
        Me.GridMaterialControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridMaterialControl.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridMaterialControl.EntityName = "ObraMaterialControl"
        Me.GridMaterialControl.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridMaterialControl.FrozenColumns = 4
        Me.GridMaterialControl.Location = New System.Drawing.Point(0, 0)
        Me.GridMaterialControl.Name = "GridMaterialControl"
        Me.GridMaterialControl.PrimaryDataFields = ""
        Me.GridMaterialControl.RelationMode = Solmicro.Expertis.Engine.RelationMode.NoRelation
        Me.GridMaterialControl.RequeryManually = True
        Me.GridMaterialControl.SecondaryDataFields = ""
        Me.GridMaterialControl.Size = New System.Drawing.Size(543, 96)
        Me.GridMaterialControl.TabIndex = 32
        Me.GridMaterialControl.ViewName = "vFrmObraControlMaterial"
        '
        'pnlTotalMateriales
        '
        Me.pnlTotalMateriales.Controls.Add(Me.lblTotalMateriales)
        Me.pnlTotalMateriales.Controls.Add(Me.txtTotalMateriales)
        Me.pnlTotalMateriales.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlTotalMateriales.Location = New System.Drawing.Point(0, 96)
        Me.pnlTotalMateriales.Name = "pnlTotalMateriales"
        Me.pnlTotalMateriales.Size = New System.Drawing.Size(543, 28)
        Me.pnlTotalMateriales.TabIndex = 0
        '
        'lblTotalMateriales
        '
        Me.lblTotalMateriales.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalMateriales.Location = New System.Drawing.Point(361, 8)
        Me.lblTotalMateriales.Name = "lblTotalMateriales"
        Me.lblTotalMateriales.Size = New System.Drawing.Size(59, 13)
        Me.lblTotalMateriales.TabIndex = 103
        Me.lblTotalMateriales.Text = "Total hoy"
        '
        'txtTotalMateriales
        '
        Me.txtTotalMateriales.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalMateriales.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotalMateriales.Enabled = False
        Me.txtTotalMateriales.Location = New System.Drawing.Point(427, 4)
        Me.txtTotalMateriales.Name = "txtTotalMateriales"
        Me.txtTotalMateriales.Size = New System.Drawing.Size(114, 21)
        Me.txtTotalMateriales.TabIndex = 102
        Me.txtTotalMateriales.TabStop = False
        '
        'TabPageCentros
        '
        Me.TabPageCentros.Controls.Add(Me.GridCentroControl)
        Me.TabPageCentros.Controls.Add(Me.pnlTotalCentros)
        Me.TabPageCentros.Key = "Centros"
        Me.TabPageCentros.Location = New System.Drawing.Point(1, 21)
        Me.TabPageCentros.Name = "TabPageCentros"
        Me.TabPageCentros.Size = New System.Drawing.Size(545, 103)
        Me.TabPageCentros.TabStop = True
        Me.TabPageCentros.Text = "Centros"
        Me.TabPageCentros.Visible = False
        '
        'GridCentroControl
        '
        Me.GridCentroControl.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDIncidencia", "Incidencia", "IDIncidencia"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDCentro", "Centro", "IDCentro", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescCentro", "DescCentro")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("CodTrabajo", "ObraTrabajo", "CodTrabajo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDTrabajo", "IDTrabajo"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDObra", "IDObra")}), "vSearchObraTrabajo"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("NObra", "ObraCabecera", "NObra", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDObra", "IDObra")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDLineaCentro", "ObraCentro", "IDLineaCentro", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDCentro", "IDCentro"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescCentro", "DescCentro")}))})
        GridCentroControl_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("GridCentroControl_DesignTimeLayout_Reference_0.Instance"), Object)
        GridCentroControl_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("GridCentroControl_DesignTimeLayout_Reference_1.Instance"), Object)
        GridCentroControl_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {GridCentroControl_DesignTimeLayout_Reference_0, GridCentroControl_DesignTimeLayout_Reference_1})
        GridCentroControl_DesignTimeLayout.LayoutString = resources.GetString("GridCentroControl_DesignTimeLayout.LayoutString")
        Me.GridCentroControl.DesignTimeLayout = GridCentroControl_DesignTimeLayout
        Me.GridCentroControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridCentroControl.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridCentroControl.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridCentroControl.EntityName = "ObraCentroControl"
        Me.GridCentroControl.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridCentroControl.FrozenColumns = 4
        Me.GridCentroControl.Location = New System.Drawing.Point(0, 0)
        Me.GridCentroControl.Name = "GridCentroControl"
        Me.GridCentroControl.PrimaryDataFields = ""
        Me.GridCentroControl.RelationMode = Solmicro.Expertis.Engine.RelationMode.NoRelation
        Me.GridCentroControl.RequeryManually = True
        Me.GridCentroControl.SecondaryDataFields = ""
        Me.GridCentroControl.Size = New System.Drawing.Size(545, 75)
        Me.GridCentroControl.TabIndex = 29
        Me.GridCentroControl.ViewName = "vFrmObraControlCentro"
        '
        'pnlTotalCentros
        '
        Me.pnlTotalCentros.Controls.Add(Me.lblTotalCentros)
        Me.pnlTotalCentros.Controls.Add(Me.txtTotalCentros)
        Me.pnlTotalCentros.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlTotalCentros.Location = New System.Drawing.Point(0, 75)
        Me.pnlTotalCentros.Name = "pnlTotalCentros"
        Me.pnlTotalCentros.Size = New System.Drawing.Size(545, 28)
        Me.pnlTotalCentros.TabIndex = 0
        '
        'lblTotalCentros
        '
        Me.lblTotalCentros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalCentros.Location = New System.Drawing.Point(363, 8)
        Me.lblTotalCentros.Name = "lblTotalCentros"
        Me.lblTotalCentros.Size = New System.Drawing.Size(59, 13)
        Me.lblTotalCentros.TabIndex = 106
        Me.lblTotalCentros.Text = "Total hoy"
        '
        'txtTotalCentros
        '
        Me.txtTotalCentros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalCentros.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotalCentros.Enabled = False
        Me.txtTotalCentros.Location = New System.Drawing.Point(429, 4)
        Me.txtTotalCentros.Name = "txtTotalCentros"
        Me.txtTotalCentros.Size = New System.Drawing.Size(114, 21)
        Me.txtTotalCentros.TabIndex = 105
        Me.txtTotalCentros.TabStop = False
        '
        'TabPageGastos
        '
        Me.TabPageGastos.Controls.Add(Me.GridGastosControl)
        Me.TabPageGastos.Controls.Add(Me.pnlTotalGastos)
        Me.TabPageGastos.Key = "Gastos"
        Me.TabPageGastos.Location = New System.Drawing.Point(1, 21)
        Me.TabPageGastos.Name = "TabPageGastos"
        Me.TabPageGastos.Size = New System.Drawing.Size(545, 103)
        Me.TabPageGastos.TabStop = True
        Me.TabPageGastos.Text = "Gastos"
        Me.TabPageGastos.Visible = False
        '
        'GridGastosControl
        '
        Me.GridGastosControl.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDEmpresa", "Empresa", "IDEmpresa"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("NObra", "ObraCabecera", "NObra", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDObra", "IDObra"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDCliente", "IDCliente")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("CodTrabajo", "ObraTrabajo", "CodTrabajo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDTrabajo", "IDTrabajo"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDObra", "IDObra")}), "vSearchObraTrabajo"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDGasto", "Gasto", "IDGasto", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescGasto", "DescGasto")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDLineaGasto", "ObraGasto", "IDLineaGasto", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDGasto", "IDGasto"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescGasto", "DescGasto"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("Facturable", "Facturable")}))})
        GridGastosControl_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("GridGastosControl_DesignTimeLayout_Reference_0.Instance"), Object)
        GridGastosControl_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("GridGastosControl_DesignTimeLayout_Reference_1.Instance"), Object)
        GridGastosControl_DesignTimeLayout_Reference_2.Instance = CType(resources.GetObject("GridGastosControl_DesignTimeLayout_Reference_2.Instance"), Object)
        GridGastosControl_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {GridGastosControl_DesignTimeLayout_Reference_0, GridGastosControl_DesignTimeLayout_Reference_1, GridGastosControl_DesignTimeLayout_Reference_2})
        GridGastosControl_DesignTimeLayout.LayoutString = resources.GetString("GridGastosControl_DesignTimeLayout.LayoutString")
        Me.GridGastosControl.DesignTimeLayout = GridGastosControl_DesignTimeLayout
        Me.GridGastosControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridGastosControl.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridGastosControl.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridGastosControl.EntityName = "ObraGastoControl"
        Me.GridGastosControl.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridGastosControl.FrozenColumns = 4
        Me.GridGastosControl.Location = New System.Drawing.Point(0, 0)
        Me.GridGastosControl.Name = "GridGastosControl"
        Me.GridGastosControl.PrimaryDataFields = ""
        Me.GridGastosControl.RelationMode = Solmicro.Expertis.Engine.RelationMode.NoRelation
        Me.GridGastosControl.RequeryManually = True
        Me.GridGastosControl.SecondaryDataFields = ""
        Me.GridGastosControl.Size = New System.Drawing.Size(545, 75)
        Me.GridGastosControl.TabIndex = 23
        Me.GridGastosControl.ViewName = "vFrmObraControlGasto"
        '
        'pnlTotalGastos
        '
        Me.pnlTotalGastos.Controls.Add(Me.lblTotalGastos)
        Me.pnlTotalGastos.Controls.Add(Me.txtTotalGastos)
        Me.pnlTotalGastos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlTotalGastos.Location = New System.Drawing.Point(0, 75)
        Me.pnlTotalGastos.Name = "pnlTotalGastos"
        Me.pnlTotalGastos.Size = New System.Drawing.Size(545, 28)
        Me.pnlTotalGastos.TabIndex = 0
        '
        'lblTotalGastos
        '
        Me.lblTotalGastos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalGastos.Location = New System.Drawing.Point(363, 8)
        Me.lblTotalGastos.Name = "lblTotalGastos"
        Me.lblTotalGastos.Size = New System.Drawing.Size(59, 13)
        Me.lblTotalGastos.TabIndex = 103
        Me.lblTotalGastos.Text = "Total hoy"
        '
        'txtTotalGastos
        '
        Me.txtTotalGastos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalGastos.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotalGastos.Enabled = False
        Me.txtTotalGastos.Location = New System.Drawing.Point(429, 4)
        Me.txtTotalGastos.Name = "txtTotalGastos"
        Me.txtTotalGastos.Size = New System.Drawing.Size(114, 21)
        Me.txtTotalGastos.TabIndex = 102
        Me.txtTotalGastos.TabStop = False
        '
        'TabPageVarios
        '
        Me.TabPageVarios.Controls.Add(Me.GridVariosControl)
        Me.TabPageVarios.Controls.Add(Me.pnlTotalVarios)
        Me.TabPageVarios.Key = "Varios"
        Me.TabPageVarios.Location = New System.Drawing.Point(1, 21)
        Me.TabPageVarios.Name = "TabPageVarios"
        Me.TabPageVarios.Size = New System.Drawing.Size(545, 103)
        Me.TabPageVarios.TabStop = True
        Me.TabPageVarios.Text = "Varios"
        '
        'GridVariosControl
        '
        Me.GridVariosControl.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("NObra", "ObraCabecera", "NObra", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDObra", "IDObra")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("CodTrabajo", "ObraTrabajo", "CodTrabajo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDTrabajo", "IDTrabajo"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDObra", "IDObra")}), "vSearchObraTrabajo"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDVarios", "Varios", "IDVarios", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescVarios", "DescVarios")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDLineaVarios", "ObraVarios", "IDLineaVarios", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDVarios", "IDVarios"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescVarios", "DescVarios")}))})
        GridVariosControl_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("GridVariosControl_DesignTimeLayout_Reference_0.Instance"), Object)
        GridVariosControl_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {GridVariosControl_DesignTimeLayout_Reference_0})
        GridVariosControl_DesignTimeLayout.LayoutString = resources.GetString("GridVariosControl_DesignTimeLayout.LayoutString")
        Me.GridVariosControl.DesignTimeLayout = GridVariosControl_DesignTimeLayout
        Me.GridVariosControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridVariosControl.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridVariosControl.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridVariosControl.EntityName = "ObraVariosControl"
        Me.GridVariosControl.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridVariosControl.FrozenColumns = 4
        Me.GridVariosControl.Location = New System.Drawing.Point(0, 0)
        Me.GridVariosControl.Name = "GridVariosControl"
        Me.GridVariosControl.PrimaryDataFields = ""
        Me.GridVariosControl.RelationMode = Solmicro.Expertis.Engine.RelationMode.NoRelation
        Me.GridVariosControl.RequeryManually = True
        Me.GridVariosControl.SecondaryDataFields = ""
        Me.GridVariosControl.Size = New System.Drawing.Size(545, 75)
        Me.GridVariosControl.TabIndex = 19
        Me.GridVariosControl.ViewName = "vFrmObraControlVarios"
        '
        'pnlTotalVarios
        '
        Me.pnlTotalVarios.Controls.Add(Me.lblTotalVarios)
        Me.pnlTotalVarios.Controls.Add(Me.txtTotalVarios)
        Me.pnlTotalVarios.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlTotalVarios.Location = New System.Drawing.Point(0, 75)
        Me.pnlTotalVarios.Name = "pnlTotalVarios"
        Me.pnlTotalVarios.Size = New System.Drawing.Size(545, 28)
        Me.pnlTotalVarios.TabIndex = 2
        '
        'lblTotalVarios
        '
        Me.lblTotalVarios.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalVarios.Location = New System.Drawing.Point(363, 8)
        Me.lblTotalVarios.Name = "lblTotalVarios"
        Me.lblTotalVarios.Size = New System.Drawing.Size(59, 13)
        Me.lblTotalVarios.TabIndex = 103
        Me.lblTotalVarios.Text = "Total hoy"
        '
        'txtTotalVarios
        '
        Me.txtTotalVarios.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalVarios.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotalVarios.Enabled = False
        Me.txtTotalVarios.Location = New System.Drawing.Point(429, 4)
        Me.txtTotalVarios.Name = "txtTotalVarios"
        Me.txtTotalVarios.Size = New System.Drawing.Size(114, 21)
        Me.txtTotalVarios.TabIndex = 102
        Me.txtTotalVarios.TabStop = False
        '
        'cmdTarea
        '
        Me.cmdTarea.Icon = CType(resources.GetObject("cmdTarea.Icon"), System.Drawing.Icon)
        Me.cmdTarea.Key = "cmdTarea"
        Me.cmdTarea.Name = "cmdTarea"
        Me.cmdTarea.Text = "Nueva Tarea"
        '
        'mnuArbol
        '
        Me.mnuArbol.CommandManager = Me.UiCommandManager1
        Me.mnuArbol.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.cmdAbrirObra1, Me.cmdTarea1, Me.cmdAbrirTarea1})
        Me.mnuArbol.Key = "mnuArbol"
        '
        'cmdAbrirObra1
        '
        Me.cmdAbrirObra1.Key = "cmdAbrirObra"
        Me.cmdAbrirObra1.Name = "cmdAbrirObra1"
        '
        'cmdTarea1
        '
        Me.cmdTarea1.Key = "cmdTarea"
        Me.cmdTarea1.Name = "cmdTarea1"
        '
        'cmdAbrirTarea1
        '
        Me.cmdAbrirTarea1.Key = "cmdAbrirTarea"
        Me.cmdAbrirTarea1.Name = "cmdAbrirTarea1"
        '
        'cmdAbrirTarea
        '
        Me.cmdAbrirTarea.Icon = CType(resources.GetObject("cmdAbrirTarea.Icon"), System.Drawing.Icon)
        Me.cmdAbrirTarea.Key = "cmdAbrirTarea"
        Me.cmdAbrirTarea.Name = "cmdAbrirTarea"
        Me.cmdAbrirTarea.Text = "Abrir Tarea"
        '
        'cmdAbrirObra
        '
        Me.cmdAbrirObra.Icon = CType(resources.GetObject("cmdAbrirObra.Icon"), System.Drawing.Icon)
        Me.cmdAbrirObra.Key = "cmdAbrirObra"
        Me.cmdAbrirObra.Name = "cmdAbrirObra"
        Me.cmdAbrirObra.Text = "Abrir Proyecto"
        '
        'pnlLeft
        '
        Me.pnlLeft.Controls.Add(Me.pnlArbol)
        Me.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLeft.Location = New System.Drawing.Point(0, 27)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Size = New System.Drawing.Size(227, 462)
        Me.pnlLeft.TabIndex = 25
        '
        'MntoBonosTrabajo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(785, 562)
        Me.CreateTransaction = True
        Me.EntityName = "Operario"
        Me.Name = "MntoBonosTrabajo"
        Me.NavigationFields = "IDOperario"
        Me.NoEditableControls = New Solmicro.Expertis.Engine.UI.NoEditableControls(New System.Windows.Forms.Control() {Me.txtIDOperario})
        Me.ViewName = "tbMaestroOperario"
        CType(Me.ToolBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        CType(Me.Line1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlArbol.ResumeLayout(False)
        Me.pnlFilterOptions.ResumeLayout(False)
        Me.pnlFilterOptions.PerformLayout()
        CType(Me.cbxFilterOption, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTrabajoSeleccionado.ResumeLayout(False)
        Me.pnlTrabajoSeleccionado.PerformLayout()
        Me.pnlHoras.ResumeLayout(False)
        CType(Me.GridMODControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTotalMOD.ResumeLayout(False)
        Me.pnlTotalMOD.PerformLayout()
        Me.pnlLabelHoras.ResumeLayout(False)
        Me.pnlLabelHoras.PerformLayout()
        Me.pnlTab.ResumeLayout(False)
        CType(Me.Tab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tab.ResumeLayout(False)
        Me.TabPageMateriales.ResumeLayout(False)
        CType(Me.GridMaterialControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTotalMateriales.ResumeLayout(False)
        Me.pnlTotalMateriales.PerformLayout()
        Me.TabPageCentros.ResumeLayout(False)
        CType(Me.GridCentroControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTotalCentros.ResumeLayout(False)
        Me.pnlTotalCentros.PerformLayout()
        Me.TabPageGastos.ResumeLayout(False)
        CType(Me.GridGastosControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTotalGastos.ResumeLayout(False)
        Me.pnlTotalGastos.PerformLayout()
        Me.TabPageVarios.ResumeLayout(False)
        CType(Me.GridVariosControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTotalVarios.ResumeLayout(False)
        Me.pnlTotalVarios.PerformLayout()
        CType(Me.mnuArbol, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLeft.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Const cnABRIRCATEGORIAS As String = "Abrir Categoría"
    Private Const cnABRIROBRAS As String = "Abrir Proyecto"
    Private Const cnABRIRTAREAS As String = "Abrir Tarea"
    Private Const cnALIASBONOOPERARIO As String = "MBOBRAOPE"

    Public Enum IconIndex
        oObras = 0
        oTrabajos = 1
        oTareas = 2
        oSelected = 3
        oCapitulos = 4
        oSubCapitulos = 5
    End Enum

    Private mintRedondeoA, mintIDObra As Integer
    Private blnLineasMOD, blnLineasMat As Boolean
    Private mstrNObra, mIDCliente, mViewNameTrabajos As String
    Private drTrabajos As DataRow
    Private dtTrabajos As DataTable
    Private mIDOperario As String

    Public WriteOnly Property SetViewNameTrabajos() As String
        Set(ByVal value As String)
            mViewNameTrabajos = value
        End Set
    End Property

    Public WriteOnly Property SetIDObra() As Integer
        Set(ByVal value As Integer)
            mintIDObra = value
        End Set
    End Property

#Region " Load "

    Private Sub MntoBonosTrabajo_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Tab_Click(Tab, New EventArgs)
    End Sub

    Private Sub MntoBonosTrabajo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadERPData()
        LoadEnums()
        LoadGridActions()
        cbxFechaControl.Value = Date.Today
        cbxFilterOption.Value = CInt(enumocFilterOptions.ocMyProjects)
        ConfigBonosOperario()
    End Sub

    Private Sub LoadERPData()
        Dim MonedaA As MonedaInfo = ExpertisApp.ExecuteTask(Of Date, MonedaInfo)(AddressOf Moneda.MonedaA, cnMinDate)
        mintRedondeoA = MonedaA.NDecimalesImporte
    End Sub

    Private Sub LoadEnums()
        cbxFilterOption.DataSource = New EnumData("enumocFilterOptions")
        EnumData.PopulateValueList("enumomcTipoMaterial", GridMaterialControl.Columns("TipoMaterial"))
        EnumData.PopulateValueList("enumomcActualizado", GridMaterialControl.Columns("Actualizado"))
    End Sub

    Private Sub LoadGridActions()
        GridMODControl.AddSeparator()
        GridMODControl.Actions.Add(cnABRIROBRAS, AddressOf AccionAbrirObraMOD, ExpertisApp.GetIcon("xProyectos.ico"))
        GridMODControl.Actions.Add(cnABRIRTAREAS, AddressOf AccionAbrirTarea, ExpertisApp.GetIcon("xTareas.ico"))
        GridMODControl.Actions.Add(cnABRIRCATEGORIAS, AddressOf AccionAbrirCategorias, ExpertisApp.GetIcon("xCargo.ico"))
        GridMaterialControl.AddSeparator()
        GridMaterialControl.Actions.Add(cnABRIROBRAS, AddressOf AccionAbrirObraMaterial, ExpertisApp.GetIcon("xProyectos.ico"))
        GridCentroControl.AddSeparator()
        GridCentroControl.Actions.Add(cnABRIROBRAS, AddressOf AccionAbrirObraCentro, ExpertisApp.GetIcon("xProyectos.ico"))
        GridGastosControl.AddSeparator()
        GridGastosControl.Actions.Add(cnABRIROBRAS, AddressOf AccionAbrirObraGastos, ExpertisApp.GetIcon("xProyectos.ico"))
        GridVariosControl.AddSeparator()
        GridVariosControl.Actions.Add(cnABRIROBRAS, AddressOf AccionAbrirObraVarios, ExpertisApp.GetIcon("xProyectos.ico"))
    End Sub

    Private Sub ConfigBonosOperario()
        If Me.ProgramInfo.Alias = cnALIASBONOOPERARIO Then
            Me.UiCommandManager1.Commands("GoFirst").Visible = Janus.Windows.UI.InheritableBoolean.False
            Me.UiCommandManager1.Commands("GoPrevious").Visible = Janus.Windows.UI.InheritableBoolean.False
            Me.UiCommandManager1.Commands("GoNext").Visible = Janus.Windows.UI.InheritableBoolean.False
            Me.UiCommandManager1.Commands("GoLast").Visible = Janus.Windows.UI.InheritableBoolean.False
            Me.UiCommandManager1.Commands("FindText").Visible = Janus.Windows.UI.InheritableBoolean.False
            Me.UiCommandManager1.Commands("Find").Visible = Janus.Windows.UI.InheritableBoolean.False
            Me.UiCommandManager1.Commands("Search").Visible = Janus.Windows.UI.InheritableBoolean.False

            If mIDOperario Is Nothing Then
                mIDOperario = ExpertisApp.ExecuteTask(Of Object, String)(AddressOf Operario.ObtenerIDOperarioUsuario, Nothing)
            End If
            Me.GotoRecord(DataProviderActions.GoFirst, New StringFilterItem("IDOperario", mIDOperario))
            FiltrarGridMOD()
        End If
    End Sub

#End Region

#Region " Grid Actions "

    Private Sub AbrirMantenimientoObra(ByVal IDObra As Integer)
        ExpertisApp.OpenForm("MGEO", New NumberFilterItem("IDObra", IDObra))
    End Sub

    Private Sub AccionAbrirObraMOD()
        AbrirMantenimientoObra(GridMODControl.Value("IDObra"))
    End Sub

    Private Sub AccionAbrirTarea()
        AbrirMantenimientoTarea(GridMODControl.Value("IDTarea"))
    End Sub

    Private Sub AccionAbrirCategorias()
        AbrirMntoCategoria(GridMODControl.Value("IDCategoria"))
    End Sub

    Private Sub AccionAbrirObraMaterial()
        AbrirMantenimientoObra(GridMaterialControl.Value("IDObra"))
    End Sub

    Private Sub AccionAbrirObraCentro()
        AbrirMantenimientoObra(GridCentroControl.Value("IDObra"))
    End Sub

    Private Sub AccionAbrirObraGastos()
        AbrirMantenimientoObra(GridGastosControl.Value("IDObra"))
    End Sub

    Private Sub AccionAbrirObraVarios()
        AbrirMantenimientoObra(GridVariosControl.Value("IDObra"))
    End Sub

#End Region

    Private Sub MntoBonosTrabajoOperario_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles Me.SetPredefinedFilter
        If Me.ProgramInfo.Alias = cnALIASBONOOPERARIO Then
            If mIDOperario Is Nothing Then
                mIDOperario = ExpertisApp.ExecuteTask(Of Object, String)(AddressOf Operario.ObtenerIDOperarioUsuario, Nothing)
            End If
            e.Filter.Add(New StringFilterItem("IDOperario", mIDOperario))
        End If
    End Sub

    Private Sub MntoBonosTrabajo_Navigated(ByVal sender As Object, ByVal e As Solmicro.Expertis.Engine.UI.NavigatedEventArgs) Handles MyBase.Navigated
        FiltrarGridMOD()
        AdvIDObra.Value = String.Empty : AdvIDObra.Text = String.Empty
        PintarArbol()
        TotalLineasMOD(GridMODControl, New EventArgs)
        SetDefaultValuesMODControl()
        GetHoraCategoriaOperario()

        Tab_Click(Tab, New EventArgs)
        VerTrabajoSeleccionado()
    End Sub

    Private Sub GetHoraCategoriaOperario()
        If Length(Me.CurrentRow("IDCategoria")) > 0 Then
            Dim IDHora As String = ExpertisApp.ExecuteTask(Of String, String)(AddressOf HoraCategoria.GetHoraPredeterminada, Me.CurrentRow("IDCategoria"))
            If Length(IDHora) > 0 Then
                GridMODControl.Columns("IDHora").DefaultValue = IDHora
                Dim dtHora As DataTable = New Hora().SelOnPrimaryKey(IDHora)
                If Not dtHora Is Nothing AndAlso dtHora.Rows.Count > 0 Then
                    GridMODControl.Columns("DesHora").DefaultValue = dtHora.Rows(0)("DescHora")
                End If
            End If
        Else
            GridMODControl.Columns("IDHora").DefaultValue = System.DBNull.Value
            GridMODControl.Columns("DesHora").DefaultValue = System.DBNull.Value
        End If
    End Sub

    Private Sub MntoBonosTrabajo_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.RecordAdded, MyBase.RecordUpdated
        FiltrarGridMOD()
        Tab_Click(Tab, New EventArgs)
    End Sub

    Private Sub VerTrabajoSeleccionado()
        pnlTrabajoSeleccionado.Visible = Not IsNothing(drTrabajos)
    End Sub

    Private Sub cbxFechaControl_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxFechaControl.ValueChanged
        If Me.RecordsState <> RecordsState.Initialize AndAlso Length(cbxFechaControl.Value) > 0 Then
            FiltrarGridMOD()
            Tab_Click(Tab, New EventArgs)
        End If
    End Sub

    Private Sub cbxFilterOption_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbxFilterOption.Validating
        PintarArbol()
    End Sub

#Region " AdvIDObra "

    Private Sub AdvIDObra_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles AdvIDObra.SelectionChanged
        PintarArbol()
    End Sub

    Private Sub AdvIDObra_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles AdvIDObra.Validating
        If Length(AdvIDObra.Value) = 0 Then
            AdvIDObra.Text = String.Empty
            PintarArbol()
        End If
    End Sub

    Private Sub AdvIDObra_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles AdvIDObra.SetPredefinedFilter
        e.Filter.Add(New NumberFilterItem("Estado", FilterOperator.NotEqual, enumocEstado.ocTerminado))
        If Nz(cbxFilterOption.Value, enumocFilterOptions.ocAllProjects) = enumocFilterOptions.ocMyProjects Then
            e.Filter.Add(New StringFilterItem("IDOperario", Me.CurrentRow("IDOperario")))
        End If
    End Sub

    Private Sub AdvIDObra_OpenningAdvSearch(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles AdvIDObra.OpenningAdvSearch
        If Nz(cbxFilterOption.Value, enumocFilterOptions.ocAllProjects) = enumocFilterOptions.ocMyProjects Then
            AdvIDObra.ViewName = "vSearchObrasOperario"
        Else
            AdvIDObra.ViewName = "tbObraCabecera"
        End If
    End Sub

#End Region

    Private Sub Tab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tab.Click
        If Me.RecordsState <> RecordsState.Initialize Then
            Dim oFilter As New Filter
            If Tab.SelectedTab.Key <> "Centros" Then
                oFilter.Add(New DateFilterItem("Fecha", cbxFechaControl.Value))
            End If
            If Not IsNothing(drTrabajos) Then
                oFilter.Add(New NumberFilterItem("IDObra", drTrabajos("IDObra")))
            ElseIf mintIDObra > 0 Then
                oFilter.Add(New NumberFilterItem("IDObra", mintIDObra))
            ElseIf Tab.SelectedTab.Key = "Materiales" Then
                oFilter.Add(New NoRowsFilterItem)
            End If
            Select Case Tab.SelectedTab.Key
                Case "Materiales"
                    If Me.RecordsState = UI.RecordsState.Saved Then GridMaterialControl.CancelData()
                    GridMaterialControl.ReQuery(oFilter)
                    TotalLineasMaterial(GridMaterialControl, New EventArgs)
                    ChangeDefaultViewGrid(GridMaterialControl)
                    SetDefaultValuesGridMaterialControl()
                Case "Centros"
                    If Me.RecordsState = UI.RecordsState.Saved Then GridCentroControl.CancelData()
                    oFilter.Add(New DateFilterItem("FechaInicio", cbxFechaControl.Value))
                    GridCentroControl.ReQuery(oFilter)
                    TotalLineasCentros(GridCentroControl, New EventArgs)
                    ChangeDefaultViewGrid(GridCentroControl)
                    SetDefaultValuesGridCentroControl()
                Case "Gastos"
                    If Me.RecordsState = UI.RecordsState.Saved Then GridGastosControl.CancelData()
                    oFilter.Add(New StringFilterItem("IDOperario", txtIDOperario.Text))
                    GridGastosControl.ReQuery(oFilter)
                    TotalLineasGastos(GridGastosControl, New EventArgs)
                    ChangeDefaultViewGrid(GridGastosControl)
                    SetDefaultValuesGridGastosControl()
                Case "Varios"
                    If Me.RecordsState = UI.RecordsState.Saved Then GridVariosControl.CancelData()
                    GridVariosControl.ReQuery(oFilter)
                    TotalLineasVarios(GridVariosControl, New EventArgs)
                    ChangeDefaultViewGrid(GridVariosControl)
                    SetDefaultValuesGridVariosControl()
            End Select
        End If
    End Sub

#Region " Arbol "

    Protected Overridable Function LoadDatosTreeView() As DataTable
        Dim strViewName As String
        Dim fAnd As New Filter

        If Nz(cbxFilterOption.Value, enumocFilterOptions.ocAllProjects) = enumocFilterOptions.ocMyProjects Then
            fAnd.Add(New StringFilterItem("IDOperario", Me.CurrentRow("IDOperario")))
            strViewName = "vSearchObrasOperario"
            mViewNameTrabajos = "vDatosObraBonosTrabajoOperario"
        Else
            strViewName = "tbObraCabecera"
            mViewNameTrabajos = "vDatosObraBonosTrabajo"
        End If

        fAnd.Add("Estado", FilterOperator.NotEqual, enumocEstado.ocTerminado)

        Return New BE.DataEngine().Filter(strViewName, fAnd, , "NObra")
    End Function

    Public Sub PintarArbol()
        dtTrabajos = LoadDatosTreeView()
        TvwTrabajos.ImageList = ImageList1
        PintarNodoObras(TvwTrabajos, dtTrabajos)
    End Sub

    Private Sub PintarNodoObras(ByRef Tree As System.Windows.Forms.TreeView, ByVal dt As DataTable)
        Tree.Nodes.Clear()

        Dim oNode As TreeNode
        Dim strFilter As String = String.Empty
        If Length(AdvIDObra.Value) > 0 Then strFilter = "IDObra=" & AdvIDObra.Value

        Dim dtr As DataRow() = dt.Select(strFilter, "IDObra")
        If Not dtr Is Nothing Then
            Tree.Visible = False
            Dim intIDObraANT As Integer = -1
            For Each dr As DataRow In dtr
                If dr("IDObra") <> intIDObraANT Then
                    oNode = New TreeNode(dr("NObra") & " -> " & dr("DescObra") & String.Empty)
                    oNode.Tag = New TagObra(dr)
                    oNode.ImageIndex = IconIndex.oObras
                    oNode.SelectedImageIndex = IconIndex.oSelected
                    Tree.Nodes.Add(oNode)

                    oNode.Nodes.Add(String.Empty)

                    intIDObraANT = dr("IDObra")
                End If
            Next
            Tree.Visible = True
        End If

        dt.Select(Nothing)
    End Sub

    Private Sub PintarNodoTrabajos(ByRef dt As DataTable, ByVal drTrabajos As DataRow(), ByRef oNodePadre As TreeNode)
        If drTrabajos.Length > 0 Then
            'Dim intIDTrabajoANT As Integer
            Dim htTrabajoANT As New Hashtable
            Dim oNode As TreeNode
            For Each drTrabajo As DataRow In drTrabajos
                If Length(drTrabajo("IDTrabajo")) > 0 Then
                    If Not htTrabajoANT.ContainsKey(drTrabajo("IDTrabajo")) Then
                        'If drTrabajo("IDTrabajo") <> intIDTrabajoANT Then
                        oNode = New TreeNode(drTrabajo("CodTrabajo") & " -> " & drTrabajo("DescTrabajo") & String.Empty)
                        If TypeOf oNodePadre.Tag Is TagObra Then
                            oNode.Tag = New TagTrabajo(drTrabajo, CType(oNodePadre.Tag, TagObra))
                        Else
                            oNode.Tag = New TagTrabajo(drTrabajo, CType(oNodePadre.Tag, TagTrabajo).Obra)
                        End If
                        oNode.ImageIndex = IconIndex.oTrabajos
                        If drTrabajo("TipoLinea") = enumTipoLineaTrabajo.tltTrabajo Then
                            If Nz(drTrabajo("ImpPrevQTrabajoA"), 0) = 0 Then
                                oNode.ImageIndex = IconIndex.oSubCapitulos
                            Else
                                oNode.ImageIndex = IconIndex.oTrabajos
                            End If
                        ElseIf drTrabajo("TipoLinea") = enumTipoLineaTrabajo.tltCapitulo Then
                            oNode.ImageIndex = IconIndex.oCapitulos
                        End If
                        oNode.SelectedImageIndex = IconIndex.oSelected
                        oNodePadre.Nodes.Add(oNode)

                        If dt.Select("IDObra=" & drTrabajo("IDObra") & " AND IDTrabajoPadre=" & drTrabajo("IDTrabajo")).Length > 0 OrElse _
                        (Length(drTrabajo("IdTarea")) > 0 AndAlso dtTrabajos.Select("IDObra=" & drTrabajo("IDObra") & " AND IDTrabajo=" & drTrabajo("IDTrabajo") & " AND EstadoTarea <> " & enumocEstado.ocTerminado).Length > 0) Then
                            oNode.Nodes.Add(String.Empty)
                        End If
                        htTrabajoANT(drTrabajo("IDTrabajo")) = drTrabajo("IDTrabajo")
                        'intIDTrabajoANT = drTrabajo("IDTrabajo")
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub PintarNodoTareas(ByRef dt As DataTable, ByVal drTareas As DataRow(), ByVal drTrabajos As DataRow(), ByRef oNodePadre As TreeNode)
        Dim oNode As TreeNode
        If drTareas.Length > 0 Then
            For Each drTarea As DataRow In drTareas
                If Not drTarea.IsNull("IDTarea") AndAlso drTarea("EstadoTarea") <> enumocEstado.ocTerminado Then
                    oNode = New TreeNode("Tarea: " & drTarea("NTarea") & " -> " & drTarea.Item("DescTarea") & String.Empty)
                    oNode.Tag = New TagTarea(drTarea, CType(oNodePadre.Tag, TagTrabajo))
                    oNode.ImageIndex = IconIndex.oTareas
                    oNode.SelectedImageIndex = IconIndex.oSelected
                    oNodePadre.Nodes.Add(oNode)
                End If
            Next
        End If
        If drTrabajos.Length > 0 Then
            PintarNodoTrabajos(dt, drTrabajos, oNodePadre)
        End If
    End Sub

    Private Sub TvwTrabajos_BeforeExpand(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TvwTrabajos.BeforeExpand
        Dim fAnd As New Filter
        If TypeOf e.Node.Tag Is TagObra Then
            fAnd.Add(New NumberFilterItem("IDObra", CType(e.Node.Tag, TagObra).IDObra))
        ElseIf TypeOf e.Node.Tag Is TagTrabajo Then
            fAnd.Add(New NumberFilterItem("IDObra", CType(e.Node.Tag, TagTrabajo).Obra.IDObra))
        End If
        If Nz(cbxFilterOption.Value, enumocFilterOptions.ocAllProjects) = enumocFilterOptions.ocMyProjects Then
            fAnd.Add(New StringFilterItem("IDOperario", Me.CurrentRow("IDOperario")))
        End If
        fAnd.Add("Estado", FilterOperator.NotEqual, enumocEstado.ocTerminado)
        Dim Orf As New Filter(FilterUnionOperator.Or)
        Orf.Add("EstadoTarea", FilterOperator.NotEqual, enumocEstado.ocTerminado)
        Orf.Add(New IsNullFilterItem("IDTarea", True))
        Dim fAndTar As New Filter
        fAndTar.Add("EstadoTarea", FilterOperator.Equal, enumocEstado.ocTerminado)
        fAndTar.Add("EstadoTrabajo", FilterOperator.NotEqual, enumocEstado.ocTerminado)
        Orf.Add(fAndTar)
        fAnd.Add(Orf)
        Orf = New Filter(FilterUnionOperator.Or)
        Orf.Clear()
        Orf.Add("EstadoTrabajo", FilterOperator.NotEqual, enumotEstado.otTerminado)
        Orf.Add(New IsNullFilterItem("IDTrabajo", True))
        fAnd.Add(Orf)
        dtTrabajos = New BE.DataEngine().Filter(mViewNameTrabajos, fAnd, , "Secuencia")

        e.Node.Nodes.Clear()
        If dtTrabajos.Rows.Count > 0 Then
            If TypeOf e.Node.Tag Is TagObra Then
                PintarNodoTrabajos(dtTrabajos, dtTrabajos.Select("IDObra=" & CType(e.Node.Tag, TagObra).IDObra & " AND IDTrabajoPadre IS NULL", "Secuencia"), e.Node)
            ElseIf TypeOf e.Node.Tag Is TagTrabajo Then
                PintarNodoTareas(dtTrabajos, dtTrabajos.Select("IDObra=" & CType(e.Node.Tag, TagTrabajo).Obra.IDObra & " AND IDTrabajo = " & CType(e.Node.Tag, TagTrabajo).IDTrabajo, "NTarea"), dtTrabajos.Select("IDObra=" & CType(e.Node.Tag, TagTrabajo).Obra.IDObra & " AND IDTrabajoPadre =" & CType(e.Node.Tag, TagTrabajo).IDTrabajo, "NTarea"), e.Node)
            End If
        End If
    End Sub

    Private Sub TvwTrabajos_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TvwTrabajos.AfterSelect
        e.Node.EnsureVisible()
        If TypeOf e.Node.Tag Is TagTrabajo Or TypeOf e.Node.Tag Is TagTarea Or TypeOf e.Node.Tag Is TagObra Then
            Dim drTareas As DataRow = Nothing
            If TypeOf e.Node.Tag Is TagTrabajo Then
                drTrabajos = CType(e.Node.Tag, TagTrabajo).GetDatarow
            ElseIf TypeOf e.Node.Tag Is TagObra Then
                mintIDObra = CType(e.Node.Tag, TagObra).IDObra
                mstrNObra = CType(e.Node.Tag, TagObra).NObra
                mIDCliente = CType(e.Node.Tag, TagObra).IDCliente
                drTrabajos = Nothing
            Else
                drTrabajos = CType(e.Node.Tag, TagTarea).Trabajo.GetDatarow
                drTareas = CType(e.Node.Tag, TagTarea).GetDatarow
            End If
            If Not IsNothing(drTrabajos) Then
                mIDCliente = drTrabajos("IDCliente") & String.Empty
            End If
            If Not IsNothing(drTareas) Then
                GridMODControl.Columns("IDTarea").DefaultValue = drTareas("IDTarea")
                GridMODControl.Columns("NTarea").DefaultValue = drTareas("NTarea")
                GridMODControl.Columns("DescTarea").DefaultValue = drTareas("DescTarea")
                GridMODControl.Columns("IDObra").DefaultValue = drTareas("IDObra")
                GridMODControl.Columns("NObra").DefaultValue = drTareas("NObra")
                GridMODControl.Columns("IDTrabajo").DefaultValue = drTareas("IDTrabajo")
                GridMODControl.Columns("CodTrabajo").DefaultValue = drTareas("CodTrabajo")
                GridMODControl.Columns("DescTrabajo").DefaultValue = drTareas("DescTrabajo")
                mIDCliente = drTareas("IDCliente") & String.Empty
            Else
                GridMODControl.Columns("IDTarea").DefaultValue = System.DBNull.Value
                GridMODControl.Columns("NTarea").DefaultValue = System.DBNull.Value
                GridMODControl.Columns("DescTarea").DefaultValue = System.DBNull.Value
                ChangeDefaultViewGrid(GridMODControl)
            End If
        Else
            drTrabajos = Nothing
            ChangeDefaultViewGrid(GridMODControl)
        End If

        Tab_Click(Tab, New EventArgs)
        VerTrabajoSeleccionado()

        GridMODControl.Refetch()
        GridMaterialControl.Refetch()
        GridCentroControl.Refetch()
        GridGastosControl.Refetch()

        Dim strTrabajo As String = String.Empty
        Dim strDescTrabajo As String = String.Empty
        If Not IsNothing(drTrabajos) Then
            strTrabajo = drTrabajos("CodTrabajo") & String.Empty
            strDescTrabajo = drTrabajos("DescTrabajo") & String.Empty
        End If
        txtTrabajo.Text = strTrabajo
        txtDescTrabajo.Text = strDescTrabajo
    End Sub

    Private Sub TvwTrabajos_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TvwTrabajos.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Dim n As TreeNode = TvwTrabajos.GetNodeAt(e.X, e.Y)
            If Not IsNothing(n) Then
                TvwTrabajos.SelectedNode = n
                cmdAbrirObra.Visible = Janus.Windows.UI.InheritableBoolean.False
                cmdAbrirTarea.Visible = Janus.Windows.UI.InheritableBoolean.False
                cmdTarea.Visible = Janus.Windows.UI.InheritableBoolean.False
                If TypeOf n.Tag Is TagObra Then
                    cmdAbrirObra.Visible = Janus.Windows.UI.InheritableBoolean.True
                ElseIf TypeOf n.Tag Is TagTrabajo OrElse TypeOf n.Tag Is TagTarea Then
                    If TypeOf n.Tag Is TagTarea AndAlso CType(n.Tag, TagTarea).IDTarea Then
                        cmdAbrirTarea.Visible = Janus.Windows.UI.InheritableBoolean.True
                    Else
                        cmdTarea.Visible = Janus.Windows.UI.InheritableBoolean.True
                    End If
                End If
                mnuArbol.Show()
            End If
        End If
    End Sub

    Private Sub ChangeDefaultViewGrid(ByVal GridAux As Solmicro.Expertis.Engine.UI.Grid)
        If GridAux.Columns.Contains("Facturable") Then GridAux.Columns("Facturable").DefaultValue = DBNull.Value
        If Not IsNothing(drTrabajos) Then
            If Length(drTrabajos("IDObra")) > 0 Then GridAux.Columns("IDObra").DefaultValue = drTrabajos("IDObra")
            If Length(drTrabajos("NObra")) > 0 Then GridAux.Columns("NObra").DefaultValue = drTrabajos("NObra")
            If Length(drTrabajos("IDTrabajo")) > 0 Then GridAux.Columns("IDTrabajo").DefaultValue = drTrabajos("IDTrabajo")
            If Length(drTrabajos("CodTrabajo")) > 0 Then GridAux.Columns("CodTrabajo").DefaultValue = drTrabajos("CodTrabajo")
            If Length(drTrabajos("DescTrabajo")) > 0 Then GridMODControl.Columns("DescTrabajo").DefaultValue = drTrabajos("DescTrabajo")
            If GridAux.Columns.Contains("Facturable") AndAlso Length(drTrabajos("TrabajoFacturable")) > 0 AndAlso drTrabajos("TipoFacturacion") = enumotTipoFacturacion.otfPorConceptos Then
                GridAux.Columns("Facturable").DefaultValue = drTrabajos("TrabajoFacturable")
            End If
        Else
            GridAux.Columns("IDObra").DefaultValue = IIf(mintIDObra > 0, mintIDObra, System.DBNull.Value)
            GridAux.Columns("NObra").DefaultValue = IIf(Length(mstrNObra) > 0, mstrNObra, System.DBNull.Value)
            GridAux.Columns("IDTrabajo").DefaultValue = System.DBNull.Value
            GridAux.Columns("CodTrabajo").DefaultValue = System.DBNull.Value
            GridMODControl.Columns("DescTrabajo").DefaultValue = System.DBNull.Value
        End If
        If GridAux.Columns.Contains("IDCliente") Then
            GridAux.Columns("IDCliente").DefaultValue = IIf(Length(mIDCliente) > 0, mIDCliente, System.DBNull.Value)
        End If
        'If GridAux.Columns.Contains("Facturable") Then
        '    GridAux.Columns("Facturable").DefaultValue = Length(mIDCliente) > 0
        'End If
    End Sub

#End Region

#Region " GRIDS "

#Region " MOD "

    Private Sub FiltrarGridMOD()
        Dim oFilter As New Filter
        If Length(txtIDOperario.Text) > 0 Then
            oFilter.Add(New DateFilterItem("FechaInicio", cbxFechaControl.Value))
            oFilter.Add(New StringFilterItem("IdOperario", txtIDOperario.Text))
        End If
        GridMODControl.ReQuery(oFilter)
        GridMODControl.DataSource = New BE.DataEngine().Filter("vFrmObraControlMOD", oFilter)
        'GridMODControl.Filter.Clear()
        'GridMODControl.Filter.Add(oFilter)
    End Sub

    Private Sub SetDefaultValuesMODControl()
        GridMODControl.Columns("IDOperario").DefaultValue = txtIDOperario.Text
        If Length(Me.CurrentRow("IDOficio")) > 0 Then GridMODControl.Columns("IDOficio").DefaultValue = Me.CurrentRow("IDOficio")
        If Length(Me.CurrentRow("IDCategoria")) > 0 Then GridMODControl.Columns("IDCategoria").DefaultValue = Me.CurrentRow("IDCategoria")
        GridMODControl.Columns("FechaInicio").DefaultValue = cbxFechaControl.Value
        GridMODControl.Columns("FechaFin").DefaultValue = cbxFechaControl.Value
    End Sub

    Protected Overridable Sub GridMODControl_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridMODControl.GotFocus
        With GridMODControl
            If IsNothing(drTrabajos) Then
                .Columns("IDTrabajo").DefaultValue = DBNull.Value
                .Columns("CodTrabajo").DefaultValue = DBNull.Value
                .Columns("IDTarea").DefaultValue = DBNull.Value
                .Columns("NTarea").DefaultValue = DBNull.Value
                .Columns("DescTarea").DefaultValue = DBNull.Value
                .Columns("Facturable").DefaultValue = DBNull.Value
            End If
        End With
        SetDefaultValuesMODControl()
    End Sub

    Private Sub GridMODControl_EditingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles GridMODControl.EditingCell
        With GridMODControl
            Select Case e.Column.Key
                Case "Facturable"
                    e.Cancel = Length(.GetValue("IDCliente")) = 0
                Case "NObra"
                    e.Cancel = Length(.Value("IDLineaMODControl")) > 0
                    If e.Cancel Then
                        .Columns("NObra").ButtonStyle = ButtonStyle.NoButton
                    Else
                        .Columns("NObra").ButtonStyle = ButtonStyle.Image
                    End If
            End Select
        End With
    End Sub

    Private Sub GridMODControl_UpdatingRecord(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GridMODControl.UpdatingRecord
        With GridMODControl
            If Length(.Value("IDObra")) > 0 Then
                If blnLineasMOD And Length(.Value("IDLineaMOD")) = 0 Then
                    ExpertisApp.GenerateMessage("Linea MOD se ha de rellenar.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    e.Cancel = True
                End If
            Else
                e.Cancel = True
                ExpertisApp.GenerateMessage("El Proyecto es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End With
    End Sub

    Private Sub GridMODControl_ColumnButtonClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles GridMODControl.ColumnButtonClick
        With GridMODControl
            Select Case e.Column.Index
                Case .Columns("DescParte").Index
                    Dim frm As New FormularioTexto
                    frm.Text = "Zoom Desc. Parte"
                    frm.Texto = .Value("DescParte") & String.Empty
                    frm.ShowDialog()
                    If .Value(e.Column.Index) & String.Empty <> frm.Texto & String.Empty Then
                        .Value(e.Column.Index) = frm.Texto
                    End If
            End Select
        End With

    End Sub

    Private Sub TotalLineasMOD(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridMODControl.RecordAdded, GridMODControl.RecordUpdated
        Dim t1, t2 As Double
        With GridMODControl
            t1 = .GetTotal(.Columns("HorasRealMod"), AggregateFunction.Sum)
            t2 = .GetTotal(.Columns("HorasViaje"), AggregateFunction.Sum)
        End With
        txtTotalHoras.Value = xRound(t1 + t2, 2)
    End Sub

    Private Sub GridMODControl_RecordsDeleted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridMODControl.RecordsDeleted
        Dim t1, t2 As Double
        With GridMODControl
            t1 = .GetTotal(.Columns("HorasRealMod"), AggregateFunction.Sum)
            t2 = .GetTotal(.Columns("HorasViaje"), AggregateFunction.Sum)
        End With
        txtTotalHoras.Value = xRound(t1 + t2, 2)
        Me.RecordsState = UI.RecordsState.Modified
    End Sub

    Private Sub GridMODControl_AdvSearchSetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.GridAdvSearchFilterEventArgs) Handles GridMODControl.AdvSearchSetPredefinedFilter
        With GridMODControl
            Select Case e.Key
                Case "NObra"
                    e.Filter.Add(New NumberFilterItem("Estado", FilterOperator.NotEqual, enumocEstado.ocTerminado))
                Case "CodTrabajo"
                    Dim eor As New Filter(FilterUnionOperator.Or)
                    If Length(.Value("IDObra")) > 0 Then
                        e.Filter.Add("IdObra", FilterOperator.Equal, .Value("IDObra"), FilterType.Numeric)
                        eor.Add("TipoLinea", FilterOperator.Equal, enumTipoLineaTrabajo.tltTrabajo, FilterType.Numeric)
                        eor.Add("TipoLinea", FilterOperator.Equal, enumTipoLineaTrabajo.tltTrabajoConcepto, FilterType.Numeric)
                        e.Filter.Add(eor)
                        e.ForcePredefinedFilter = True

                    Else
                        e.Filter.Add("TipoLinea", FilterOperator.Equal, enumTipoLineaTrabajo.tltTrabajo, FilterType.Numeric)
                        eor.Add("TipoLinea", FilterOperator.Equal, enumTipoLineaTrabajo.tltTrabajoConcepto, FilterType.Numeric)
                        e.Filter.Add(eor)
                    End If
                Case "IDLineaMod"
                    If Length(.Value("IDTrabajo")) > 0 Then
                        e.Filter.Add("IDTrabajo", FilterOperator.Equal, .Value("IDTrabajo"), FilterType.Numeric)
                    Else
                        e.Filter.Add(New NoRowsFilterItem)
                    End If
                    If Length(Me.CurrentRow("IDCategoria")) > 0 Then
                        e.Filter.Add("IDCategoria", FilterOperator.Equal, Me.CurrentRow("IDCategoria"), FilterType.String)
                    End If
                Case "NTarea"
                    If Length(.Value("IDObra")) > 0 Then e.Filter.Add("IDObra", FilterOperator.Equal, .Value("IDObra"), FilterType.Numeric)
                    If Length(.Value("IDTrabajo")) > 0 Then e.Filter.Add("IDTrabajo", FilterOperator.Equal, .Value("IDTrabajo"), FilterType.Numeric)
            End Select
        End With
    End Sub

    Private Sub GridMODControl_DeletingRecord(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionCancelEventArgs) Handles GridMODControl.DeletingRecord
        If Length(e.Row.DataRow("IDLineaMODControl")) > 0 Then
            Dim objFilter As New Filter
            objFilter.Add(New StringFilterItem("IDOperario", Me.txtIDOperario.Text))
            objFilter.Add(New NumberFilterItem("IDLineaMODControl", e.Row.DataRow("IDLineaMODControl")))
            Dim dt As DataTable = New ObraGastoControl().Filter(objFilter)
            If Not IsNothing(dt) AndAlso dt.Rows.Count > 0 Then
                If ExpertisApp.GenerateMessage("El registro seleccionado tiene Gastos asociados. Estos Gastos también se eliminarán ¿Desea continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub GridMODControl_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridMODControl.MouseUp
        If e.Button = MouseButtons.Right Then
            If Not IsNothing(GridMODControl) AndAlso GridMODControl.RowCount > 0 Then
                If Length(GridMODControl.Value("IDCategoria")) > 0 Then
                    GridMODControl.UiCommandManager1.Commands(cnABRIRCATEGORIAS).Visible = Janus.Windows.UI.InheritableBoolean.True
                Else
                    GridMODControl.UiCommandManager1.Commands(cnABRIRCATEGORIAS).Visible = Janus.Windows.UI.InheritableBoolean.False
                End If
                If Length(GridMODControl.Value("IDTarea")) > 0 Then
                    GridMODControl.UiCommandManager1.Commands(cnABRIRTAREAS).Visible = Janus.Windows.UI.InheritableBoolean.True
                Else
                    GridMODControl.UiCommandManager1.Commands(cnABRIRTAREAS).Visible = Janus.Windows.UI.InheritableBoolean.False
                End If
            End If
        End If
    End Sub


#End Region

#Region " Material "

    Private Sub SetDefaultValuesGridMaterialControl()
        GridMaterialControl.Columns("Fecha").DefaultValue = cbxFechaControl.Value
    End Sub

    Private Sub GridMaterialControl_EditingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles GridMaterialControl.EditingCell
        With GridMaterialControl
            If Me.RecordsState = UI.RecordsState.Saved Then
                If .GetValue("Actualizado") <> enumomcActualizado.omcNoActualizado Then
                    e.Cancel = True
                End If
            End If
        End With
    End Sub

    Private Sub GridMaterialControl_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridMaterialControl.GotFocus
        SetDefaultValuesGridMaterialControl()
        With GridMaterialControl
            If IsNothing(drTrabajos) Then
                .Columns("IDTrabajo").DefaultValue = DBNull.Value
                .Columns("CodTrabajo").DefaultValue = DBNull.Value
            End If
        End With
    End Sub

    Private Sub GridMaterialControl_UpdatingRecord(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GridMaterialControl.UpdatingRecord
        With GridMaterialControl
            If Length(.Value("IDObra")) > 0 Then
                If Length(.Value("IDMaterial")) > 0 Then
                    If blnLineasMat And Length(.Value("IDLineaMaterial")) = 0 Then
                        ExpertisApp.GenerateMessage("Linea Material se ha de rellenar.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        e.Cancel = True
                    End If
                Else
                    e.Cancel = True
                    ExpertisApp.GenerateMessage("El Material es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                e.Cancel = True
                ExpertisApp.GenerateMessage("El Proyecto es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End With
    End Sub

    Private Sub GridMaterialControl_AdvSearchSetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.GridAdvSearchFilterEventArgs) Handles GridMaterialControl.AdvSearchSetPredefinedFilter
        With GridMaterialControl
            Select Case e.Key
                Case "NObra"
                    e.Filter.Add(New NumberFilterItem("Estado", FilterOperator.NotEqual, enumocEstado.ocTerminado))
                Case "CodTrabajo"
                    Dim eor As New Filter(FilterUnionOperator.Or)
                    If Length(.Value("IDObra")) > 0 Then
                        e.Filter.Add("IdObra", FilterOperator.Equal, .Value("IDObra"), FilterType.Numeric)
                        eor.Add("TipoLinea", FilterOperator.Equal, enumTipoLineaTrabajo.tltTrabajo, FilterType.Numeric)
                        eor.Add("TipoLinea", FilterOperator.Equal, enumTipoLineaTrabajo.tltTrabajoConcepto, FilterType.Numeric)
                        e.Filter.Add(eor)
                        e.ForcePredefinedFilter = True

                    Else
                        e.Filter.Add("TipoLinea", FilterOperator.Equal, enumTipoLineaTrabajo.tltTrabajo, FilterType.Numeric)
                        eor.Add("TipoLinea", FilterOperator.Equal, enumTipoLineaTrabajo.tltTrabajoConcepto, FilterType.Numeric)
                        e.Filter.Add(eor)
                    End If
                Case "IDMaterial"
                    e.Filter.Add(New BooleanFilterItem("Activo", FilterOperator.Equal, True))
                Case "IDLineaMaterial"
                    If Length(.Value("IDTrabajo")) > 0 Then
                        e.Filter.Add("IDTrabajo", FilterOperator.Equal, .Value("IDTrabajo"), FilterType.Numeric)
                    Else
                        e.Filter.Add(New NoRowsFilterItem)
                    End If
                    If Length(.Value("IDMaterial")) > 0 Then
                        e.Filter.Add("IDMaterial", FilterOperator.Equal, .Value("IDMaterial"), FilterType.String)
                    End If
            End Select
        End With
    End Sub


    Private Sub TotalLineasMaterial(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridMaterialControl.RecordAdded, GridMaterialControl.RecordsDeleted, GridMaterialControl.RecordUpdated
        With GridMaterialControl
            txtTotalMateriales.Text = xRound(.GetTotal(.Columns("ImpRealMatA"), AggregateFunction.Sum), mintRedondeoA)
        End With
    End Sub

#End Region

#Region " Centros "

    Private Sub SetDefaultValuesGridCentroControl()
        GridCentroControl.Columns("FechaInicio").DefaultValue = cbxFechaControl.Value
    End Sub

    Private Sub GridCentroControl_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridCentroControl.GotFocus
        SetDefaultValuesGridCentroControl()
        With GridCentroControl
            If IsNothing(drTrabajos) Then
                .Columns("IDTrabajo").DefaultValue = DBNull.Value
                .Columns("CodTrabajo").DefaultValue = DBNull.Value
            End If
        End With
    End Sub

    Private Sub GridCentroControl_UpdatingRecord(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GridCentroControl.UpdatingRecord
        With GridCentroControl
            If Length(.Value("IDObra")) > 0 Then
                If Length(.Value("IDCentro")) = 0 Then
                    e.Cancel = True
                    ExpertisApp.GenerateMessage("El Centro es obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                e.Cancel = True
                ExpertisApp.GenerateMessage("El Proyecto es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End With
    End Sub

    Private Sub GridCentroControl_AdvSearchSetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.GridAdvSearchFilterEventArgs) Handles GridCentroControl.AdvSearchSetPredefinedFilter
        With GridCentroControl
            Select Case e.Key
                Case "NObra"
                    e.Filter.Add(New NumberFilterItem("Estado", FilterOperator.NotEqual, enumocEstado.ocTerminado))
                Case "CodTrabajo"
                    Dim eor As New Filter(FilterUnionOperator.Or)
                    If Length(.Value("IDObra")) > 0 Then
                        e.Filter.Add("IdObra", FilterOperator.Equal, .Value("IDObra"), FilterType.Numeric)
                        eor.Add("TipoLinea", FilterOperator.Equal, enumTipoLineaTrabajo.tltTrabajo, FilterType.Numeric)
                        eor.Add("TipoLinea", FilterOperator.Equal, enumTipoLineaTrabajo.tltTrabajoConcepto, FilterType.Numeric)
                        e.Filter.Add(eor)
                        e.ForcePredefinedFilter = True

                    Else
                        e.Filter.Add("TipoLinea", FilterOperator.Equal, enumTipoLineaTrabajo.tltTrabajo, FilterType.Numeric)
                        eor.Add("TipoLinea", FilterOperator.Equal, enumTipoLineaTrabajo.tltTrabajoConcepto, FilterType.Numeric)
                        e.Filter.Add(eor)

                    End If
                Case "IDLineaCentro"
                    If Length(.Value("IDTrabajo")) > 0 Then
                        e.Filter.Add("IDTrabajo", FilterOperator.Equal, .Value("IDTrabajo"), FilterType.Numeric)
                    Else
                        e.Filter.Add(New NoRowsFilterItem)
                    End If
                    If Length(.Value("IDCentro")) > 0 Then
                        e.Filter.Add("IDCentro", FilterOperator.Equal, .Value("IDCentro"), FilterType.String)
                    End If
            End Select
        End With
    End Sub


    Private Sub TotalLineasCentros(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridCentroControl.RecordAdded, GridCentroControl.RecordsDeleted, GridCentroControl.RecordUpdated
        With GridCentroControl
            txtTotalCentros.Text = xRound(.GetTotal(.Columns("ImpRealCentroA"), AggregateFunction.Sum), mintRedondeoA)
        End With
    End Sub

#End Region

#Region " Gastos "

    Private Sub SetDefaultValuesGridGastosControl()
        GridGastosControl.Columns("IDOperario").DefaultValue = txtIDOperario.Text
        GridGastosControl.Columns("Fecha").DefaultValue = cbxFechaControl.Value
    End Sub

    Private Sub GridGastosControl_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridGastosControl.GotFocus
        SetDefaultValuesGridGastosControl()
        With GridGastosControl
            If IsNothing(drTrabajos) Then
                .Columns("IDTrabajo").DefaultValue = DBNull.Value
                .Columns("CodTrabajo").DefaultValue = DBNull.Value
                .Columns("Facturable").DefaultValue = DBNull.Value
            End If
            .Columns("Contabilizado").DefaultValue = False
        End With
    End Sub

    Private Sub GridGastosControl_EditingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles GridGastosControl.EditingCell
        With GridGastosControl
            If Not Nz(.Value("Contabilizado"), False) Then
                Select Case e.Column.Index
                    Case .Columns("Tarjeta").Index
                        .Columns(e.Column.Index).EditType = Janus.Windows.GridEX.EditType.CheckBox
                    Case .Columns("Facturable").Index
                        .Columns(e.Column.Index).EditType = Janus.Windows.GridEX.EditType.CheckBox
                        e.Cancel = Length(.GetValue("IDCliente")) = 0
                    Case .Columns("CodTrabajo").Index, .Columns("IDGasto").Index, .Columns("IdOperario").Index, .Columns("DescGasto").Index, .Columns("ImpRealGastoA").Index
                        .Columns(e.Column.Index).EditType = Janus.Windows.GridEX.EditType.TextBox
                    Case .Columns("Fecha").Index
                        .Columns(e.Column.Index).EditType = Janus.Windows.GridEX.EditType.CalendarCombo
                        'Case Else
                        '    e.Cancel = True
                End Select
            Else
                e.Cancel = True
            End If
        End With
    End Sub

    Private Sub GridGastosControl_UpdatingRecord(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GridGastosControl.UpdatingRecord
        With GridGastosControl
            If Length(.Value("IDObra")) > 0 Then
                If Length(.Value("IDGasto")) = 0 Then
                    e.Cancel = True
                    ExpertisApp.GenerateMessage("El Gasto es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                e.Cancel = True
                ExpertisApp.GenerateMessage("El Proyecto es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End With
    End Sub

    Private Sub GridGastosControl_AdvSearchSetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.GridAdvSearchFilterEventArgs) Handles GridGastosControl.AdvSearchSetPredefinedFilter
        With GridGastosControl
            Select Case e.Key
                Case "NObra"
                    e.Filter.Add(New NumberFilterItem("Estado", FilterOperator.NotEqual, enumocEstado.ocTerminado))
                Case "CodTrabajo"
                    Dim eor As New Filter(FilterUnionOperator.Or)
                    If Length(.Value("IDObra")) > 0 Then
                        e.Filter.Add("IdObra", FilterOperator.Equal, .Value("IDObra"), FilterType.Numeric)
                        eor.Add("TipoLinea", FilterOperator.Equal, enumTipoLineaTrabajo.tltTrabajo, FilterType.Numeric)
                        eor.Add("TipoLinea", FilterOperator.Equal, enumTipoLineaTrabajo.tltTrabajoConcepto, FilterType.Numeric)
                        e.Filter.Add(eor)
                        e.ForcePredefinedFilter = True
                    Else
                        e.Filter.Add("TipoLinea", FilterOperator.Equal, enumTipoLineaTrabajo.tltTrabajo, FilterType.Numeric)
                        eor.Add("TipoLinea", FilterOperator.Equal, enumTipoLineaTrabajo.tltTrabajoConcepto, FilterType.Numeric)
                        e.Filter.Add(eor)
                    End If
                Case "IDLineaGasto"
                    If Length(.Value("IDTrabajo")) > 0 Then
                        e.Filter.Add("IDTrabajo", FilterOperator.Equal, .Value("IDTrabajo"), FilterType.Numeric)
                    Else
                        e.Filter.Add(New NoRowsFilterItem)
                    End If
                    If Length(.Value("IDGasto")) > 0 Then
                        e.Filter.Add("IDGasto", FilterOperator.Equal, .Value("IDGasto"), FilterType.String)
                    End If
            End Select
        End With
    End Sub


    Private Sub TotalLineasGastos(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridGastosControl.RecordAdded, GridGastosControl.RecordsDeleted, GridGastosControl.RecordUpdated
        With GridGastosControl
            txtTotalGastos.Text = xRound(.GetTotal(.Columns("ImpRealGastoA"), AggregateFunction.Sum), mintRedondeoA)
        End With
    End Sub

#End Region

#Region " Varios "

    Private Sub SetDefaultValuesGridVariosControl()
        GridVariosControl.Columns("Fecha").DefaultValue = cbxFechaControl.Value
    End Sub

    Private Sub GridVariosControl_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridVariosControl.GotFocus
        SetDefaultValuesGridVariosControl()
        With GridVariosControl
            If IsNothing(drTrabajos) Then
                .Columns("IDTrabajo").DefaultValue = DBNull.Value
                .Columns("CodTrabajo").DefaultValue = DBNull.Value
            End If
            .Columns("Contabilizado").DefaultValue = False
        End With
    End Sub

    Private Sub GridVariosControl_EditingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles GridVariosControl.EditingCell
        With GridVariosControl
            If Not Nz(.Value("Contabilizado"), False) Then
                Select Case e.Column.Index
                    Case .Columns("NObra").Index, .Columns("CodTrabajo").Index, .Columns("IDVarios").Index, _
                         .Columns("DescVarios").Index, .Columns("ImpRealVariosA").Index
                        .Columns(e.Column.Index).EditType = Janus.Windows.GridEX.EditType.TextBox
                    Case .Columns("Fecha").Index
                        .Columns(e.Column.Index).EditType = EditType.CalendarDropDown
                        'Case Else
                        '    e.Cancel = True
                End Select
            Else
                e.Cancel = True
            End If
        End With
    End Sub

    Private Sub GridVariosControl_UpdatingRecord(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GridVariosControl.UpdatingRecord
        With GridVariosControl
            If Length(.Value("IDObra")) > 0 Then
                If Length(.Value("IDVarios")) = 0 Then
                    e.Cancel = True
                    ExpertisApp.GenerateMessage("Varios es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)  '
                End If
            Else
                e.Cancel = True
                ExpertisApp.GenerateMessage("El Proyecto es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End With
    End Sub

    Private Sub GridVariosControl_AdvSearchSetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.GridAdvSearchFilterEventArgs) Handles GridVariosControl.AdvSearchSetPredefinedFilter
        With GridVariosControl
            Select Case e.Key
                Case "NObra"
                    e.Filter.Add(New NumberFilterItem("Estado", FilterOperator.NotEqual, enumocEstado.ocTerminado))
                Case "CodTrabajo"
                    Dim eor As New Filter(FilterUnionOperator.Or)
                    If Length(.Value("IDObra")) > 0 Then
                        e.Filter.Add("IdObra", FilterOperator.Equal, .Value("IDObra"), FilterType.Numeric)
                        eor.Add("TipoLinea", FilterOperator.Equal, enumTipoLineaTrabajo.tltTrabajo, FilterType.Numeric)
                        eor.Add("TipoLinea", FilterOperator.Equal, enumTipoLineaTrabajo.tltTrabajoConcepto, FilterType.Numeric)
                        e.Filter.Add(eor)
                        e.ForcePredefinedFilter = True
                    Else
                        e.Filter.Add("TipoLinea", FilterOperator.Equal, enumTipoLineaTrabajo.tltTrabajo, FilterType.Numeric)
                        eor.Add("TipoLinea", FilterOperator.Equal, enumTipoLineaTrabajo.tltTrabajoConcepto, FilterType.Numeric)
                        e.Filter.Add(eor)
                    End If
                Case "IDLineaVarios"
                    If Length(.Value("IDTrabajo")) > 0 Then
                        e.Filter.Add("IDTrabajo", FilterOperator.Equal, .Value("IDTrabajo"), FilterType.Numeric)
                    Else
                        e.Filter.Add(New NoRowsFilterItem)
                    End If
                    If Length(.Value("IDVarios")) > 0 Then
                        e.Filter.Add("IDVarios", FilterOperator.Equal, .Value("IDVarios"), FilterType.String)
                    End If
            End Select
        End With
    End Sub




    Private Sub TotalLineasVarios(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridVariosControl.RecordAdded, GridVariosControl.RecordsDeleted, GridVariosControl.RecordUpdated
        With GridVariosControl
            txtTotalVarios.Text = xRound(.GetTotal(.Columns("ImpRealVariosA"), Janus.Windows.GridEX.AggregateFunction.Sum), mintRedondeoA)
        End With
    End Sub

#End Region

#End Region

#Region " TAG "

    Public Class TagObra
        Public IDObra As Integer
        Public NObra, DescObra, IDTipoObra, IDCliente As String

        Public Sub New(ByVal drObra As DataRow)
            IDObra = drObra("IDObra")
            NObra = drObra("NObra")
            DescObra = drObra("DescObra") & String.Empty
            IDTipoObra = drObra("IDTipoObra") & String.Empty
            IDCliente = drObra("IDCliente") & String.Empty
        End Sub
    End Class
    '''''''''''''''''''''''''''''''''''
    Public Class TagTrabajo
        Public GetDatarow As DataRow
        Public IDTrabajo As Integer
        Public CodTrabajo As String
        Public Obra As TagObra

        Public Sub New(ByVal drTrabajo As DataRow, ByVal oTagObra As TagObra)
            GetDatarow = drTrabajo
            IDTrabajo = drTrabajo("IDTrabajo")
            CodTrabajo = drTrabajo("CodTrabajo") & String.Empty
            Obra = oTagObra
        End Sub
    End Class
    '''''''''''''''''''''''''''''''''''
    Public Class TagTarea
        Public IDTarea As Integer
        Public NTarea, DescTarea As String
        Public GetDatarow As DataRow
        Public Trabajo As TagTrabajo

        Public Sub New(ByVal drTarea As DataRow, ByVal oTagTrabajo As TagTrabajo)
            IDTarea = drTarea("IDTarea")
            NTarea = drTarea("NTarea") & String.Empty
            DescTarea = drTarea("DescTarea") & String.Empty
            Trabajo = oTagTrabajo
            GetDatarow = drTarea
        End Sub
    End Class

#End Region

#Region " Acciones Arbol "

    Private Sub UiCommandManager1_CommandClick(ByVal sender As System.Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles UiCommandManager1.CommandClick
        Select Case e.Command.Key
            Case cmdAbrirObra1.Key
                AbrirMantenimientoObra(CType(TvwTrabajos.SelectedNode.Tag, TagObra).IDObra)
            Case cmdTarea1.Key
                AñadirTarea()
            Case cmdAbrirTarea1.Key
                AbrirMantenimientoTarea(CType(TvwTrabajos.SelectedNode.Tag, TagTarea).IDTarea)
        End Select
    End Sub

    Protected Overridable Sub AñadirTarea()
        Dim n As TreeNode = TvwTrabajos.SelectedNode
        Dim IDTrabajo As Integer = CType(n.Tag, TagTrabajo).IDTrabajo
        Dim IDObra As Integer = CType(n.Tag, TagTrabajo).Obra.IDObra
        Dim CodTrabajo As String = CType(n.Tag, TagTrabajo).CodTrabajo
        Dim NObra As String = CType(n.Tag, TagTrabajo).Obra.NObra

        AbrirMantenimientoTarea(, False, IDObra, NObra, IDTrabajo, CodTrabajo)
    End Sub

#End Region

    Private Sub MntoBonosTrabajo_BusinessCalling(ByVal sender As Object, ByVal e As Engine.UI.BusinessCallingEventArgs) Handles Me.BusinessCalling
        Select Case e.EntityName
            Case GridMaterialControl.EntityName
                e.Data.Context.Clear()
                If (Length(mIDCliente) > 0) Then
                    e.Data.Context("IDCliente") = mIDCliente
                End If
        End Select
    End Sub

End Class
