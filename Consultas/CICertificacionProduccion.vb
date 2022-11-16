Imports Janus.Windows.GridEX
Public Class CICertificacionProduccion
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
    Friend WithEvents TabConceptos As Solmicro.Expertis.Engine.UI.Tab
    Friend WithEvents TabPageMateriales As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents TabPageMOD As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents TabPageCentros As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents TabPageGastos As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents TabPageVarios As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents Splitter2 As System.Windows.Forms.Splitter
    Friend WithEvents GridMateriales As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents GridMOD As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents GridCentros As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents GridGastos As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents GridVarios As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents lblTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvIDTrabajo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents Command0 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents ShowDesviaciones1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents lblObra As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvIDObra As Solmicro.Expertis.Engine.UI.AdvSearch
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridMateriales_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CICertificacionProduccion))
        Dim GridMOD_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridCentros_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridGastos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridVarios_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.TabConceptos = New Solmicro.Expertis.Engine.UI.Tab
        Me.TabPageMateriales = New Janus.Windows.UI.Tab.UITabPage
        Me.GridMateriales = New Solmicro.Expertis.Engine.UI.Grid
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TabPageMOD = New Janus.Windows.UI.Tab.UITabPage
        Me.GridMOD = New Solmicro.Expertis.Engine.UI.Grid
        Me.TabPageCentros = New Janus.Windows.UI.Tab.UITabPage
        Me.GridCentros = New Solmicro.Expertis.Engine.UI.Grid
        Me.TabPageGastos = New Janus.Windows.UI.Tab.UITabPage
        Me.GridGastos = New Solmicro.Expertis.Engine.UI.Grid
        Me.TabPageVarios = New Janus.Windows.UI.Tab.UITabPage
        Me.GridVarios = New Solmicro.Expertis.Engine.UI.Grid
        Me.Splitter2 = New System.Windows.Forms.Splitter
        Me.lblTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDTrabajo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblObra = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDObra = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.Command0 = New Janus.Windows.UI.CommandBars.UICommand("ShowDesviaciones")
        Me.ShowDesviaciones1 = New Janus.Windows.UI.CommandBars.UICommand("ShowDesviaciones")
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        CType(Me.TabConceptos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabConceptos.SuspendLayout()
        Me.TabPageMateriales.SuspendLayout()
        CType(Me.GridMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageMOD.SuspendLayout()
        CType(Me.GridMOD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageCentros.SuspendLayout()
        CType(Me.GridCentros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageGastos.SuspendLayout()
        CType(Me.GridGastos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageVarios.SuspendLayout()
        CType(Me.GridVarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.lblTrabajo)
        Me.FilterPanel.Controls.Add(Me.lblObra)
        Me.FilterPanel.Controls.Add(Me.AdvIDTrabajo)
        Me.FilterPanel.Controls.Add(Me.AdvIDObra)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 334)
        Me.FilterPanel.Size = New System.Drawing.Size(640, 56)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Controls.Add(Me.Splitter2)
        Me.CIMntoGridPanel.Controls.Add(Me.TabConceptos)
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(640, 334)
        Me.CIMntoGridPanel.Controls.SetChildIndex(Me.TabConceptos, 0)
        Me.CIMntoGridPanel.Controls.SetChildIndex(Me.Splitter2, 0)
        Me.CIMntoGridPanel.Controls.SetChildIndex(Me.Grid, 0)
        '
        'Grid
        '
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.Grid.EntityName = "ObraTrabajo"
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Grid.ImageList = Me.ImageList1
        Me.Grid.Size = New System.Drawing.Size(640, 185)
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.ViewName = "vObraDesviacionCertificacionTrabajo"
        '
        'UiCommandManager1
        '
        Me.UiCommandManager1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Command0})
        '
        'CheckAll
        '
        Me.CheckAll.Icon = CType(resources.GetObject("CheckAll.Icon"), System.Drawing.Icon)
        '
        'UncheckAll
        '
        Me.UncheckAll.Icon = CType(resources.GetObject("UncheckAll.Icon"), System.Drawing.Icon)
        '
        'ExecuteQuery
        '
        Me.ExecuteQuery.Icon = CType(resources.GetObject("ExecuteQuery.Icon"), System.Drawing.Icon)
        '
        'ShowAllCheckedItems
        '
        Me.ShowAllCheckedItems.Icon = CType(resources.GetObject("ShowAllCheckedItems.Icon"), System.Drawing.Icon)
        '
        'ClearFilter
        '
        Me.ClearFilter.Icon = CType(resources.GetObject("ClearFilter.Icon"), System.Drawing.Icon)
        '
        'Export
        '
        Me.Export.Icon = CType(resources.GetObject("Export.Icon"), System.Drawing.Icon)
        '
        'Toolbar
        '
        Me.Toolbar.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.ShowDesviaciones1})
        Me.Toolbar.Size = New System.Drawing.Size(245, 28)
        '
        'Menubar
        '
        Me.Menubar.Location = New System.Drawing.Point(0, 28)
        '
        'MainPanel
        '
        Me.MainPanel.Size = New System.Drawing.Size(640, 390)
        '
        'ExecuteActions
        '
        Me.ExecuteActions.Icon = CType(resources.GetObject("ExecuteActions.Icon"), System.Drawing.Icon)
        Me.ExecuteActions.Visible = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(640, 390)
        '
        'TabConceptos
        '
        Me.TabConceptos.BackColor = System.Drawing.Color.White
        Me.TabConceptos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TabConceptos.Location = New System.Drawing.Point(0, 190)
        Me.TabConceptos.Name = "TabConceptos"
        Me.TabConceptos.Size = New System.Drawing.Size(640, 144)
        Me.TabConceptos.TabIndex = 1
        Me.TabConceptos.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.TabPageMateriales, Me.TabPageMOD, Me.TabPageCentros, Me.TabPageGastos, Me.TabPageVarios})
        Me.TabConceptos.UseThemes = True
        '
        'TabPageMateriales
        '
        Me.TabPageMateriales.Controls.Add(Me.GridMateriales)
        Me.TabPageMateriales.Key = "Materiales"
        Me.TabPageMateriales.Location = New System.Drawing.Point(1, 21)
        Me.TabPageMateriales.Name = "TabPageMateriales"
        Me.TabPageMateriales.Size = New System.Drawing.Size(638, 122)
        Me.TabPageMateriales.TabStop = True
        Me.TabPageMateriales.Text = "Materiales"
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
        Me.GridMateriales.EntityName = "ObraMaterial"
        Me.GridMateriales.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridMateriales.ImageList = Me.ImageList1
        Me.GridMateriales.Location = New System.Drawing.Point(0, 0)
        Me.GridMateriales.Name = "GridMateriales"
        Me.GridMateriales.PrimaryDataFields = Nothing
        Me.GridMateriales.RelationMode = Solmicro.Expertis.Engine.RelationMode.NoRelation
        Me.GridMateriales.RequeryManually = True
        Me.GridMateriales.SecondaryDataFields = Nothing
        Me.GridMateriales.Size = New System.Drawing.Size(638, 122)
        Me.GridMateriales.TabIndex = 0
        Me.GridMateriales.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridMateriales.ViewName = "vObraDesviacionCertificacionMaterial"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "nav_up_red.ico")
        Me.ImageList1.Images.SetKeyName(1, "nav_down_green.ico")
        '
        'TabPageMOD
        '
        Me.TabPageMOD.Controls.Add(Me.GridMOD)
        Me.TabPageMOD.Key = "MOD"
        Me.TabPageMOD.Location = New System.Drawing.Point(1, 21)
        Me.TabPageMOD.Name = "TabPageMOD"
        Me.TabPageMOD.Size = New System.Drawing.Size(638, 122)
        Me.TabPageMOD.TabStop = True
        Me.TabPageMOD.Text = "M.O.D."
        '
        'GridMOD
        '
        Me.GridMOD.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridMOD.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridMOD.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridMOD_DesignTimeLayout.LayoutString = resources.GetString("GridMOD_DesignTimeLayout.LayoutString")
        Me.GridMOD.DesignTimeLayout = GridMOD_DesignTimeLayout
        Me.GridMOD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridMOD.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridMOD.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridMOD.EntityName = "ObraMOD"
        Me.GridMOD.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridMOD.ImageList = Me.ImageList1
        Me.GridMOD.Location = New System.Drawing.Point(0, 0)
        Me.GridMOD.Name = "GridMOD"
        Me.GridMOD.PrimaryDataFields = ""
        Me.GridMOD.RelationMode = Solmicro.Expertis.Engine.RelationMode.NoRelation
        Me.GridMOD.RequeryManually = True
        Me.GridMOD.SecondaryDataFields = ""
        Me.GridMOD.Size = New System.Drawing.Size(638, 122)
        Me.GridMOD.TabIndex = 0
        Me.GridMOD.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridMOD.ViewName = "vObraDesviacionCertificacionMOD"
        '
        'TabPageCentros
        '
        Me.TabPageCentros.Controls.Add(Me.GridCentros)
        Me.TabPageCentros.Key = "Centros"
        Me.TabPageCentros.Location = New System.Drawing.Point(1, 21)
        Me.TabPageCentros.Name = "TabPageCentros"
        Me.TabPageCentros.Size = New System.Drawing.Size(638, 122)
        Me.TabPageCentros.TabStop = True
        Me.TabPageCentros.Text = "Centros"
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
        Me.GridCentros.EntityName = "ObraCentro"
        Me.GridCentros.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridCentros.ImageList = Me.ImageList1
        Me.GridCentros.Location = New System.Drawing.Point(0, 0)
        Me.GridCentros.Name = "GridCentros"
        Me.GridCentros.PrimaryDataFields = ""
        Me.GridCentros.RelationMode = Solmicro.Expertis.Engine.RelationMode.NoRelation
        Me.GridCentros.RequeryManually = True
        Me.GridCentros.SecondaryDataFields = ""
        Me.GridCentros.Size = New System.Drawing.Size(638, 122)
        Me.GridCentros.TabIndex = 0
        Me.GridCentros.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridCentros.ViewName = "vObraDesviacionCertificacionCentro"
        '
        'TabPageGastos
        '
        Me.TabPageGastos.Controls.Add(Me.GridGastos)
        Me.TabPageGastos.Key = "Gastos"
        Me.TabPageGastos.Location = New System.Drawing.Point(1, 21)
        Me.TabPageGastos.Name = "TabPageGastos"
        Me.TabPageGastos.Size = New System.Drawing.Size(638, 122)
        Me.TabPageGastos.TabStop = True
        Me.TabPageGastos.Text = "Gastos"
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
        Me.GridGastos.ImageList = Me.ImageList1
        Me.GridGastos.Location = New System.Drawing.Point(0, 0)
        Me.GridGastos.Name = "GridGastos"
        Me.GridGastos.PrimaryDataFields = ""
        Me.GridGastos.RelationMode = Solmicro.Expertis.Engine.RelationMode.NoRelation
        Me.GridGastos.RequeryManually = True
        Me.GridGastos.SecondaryDataFields = ""
        Me.GridGastos.Size = New System.Drawing.Size(638, 122)
        Me.GridGastos.TabIndex = 0
        Me.GridGastos.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridGastos.ViewName = "vObraDesviacionCertificacionGastos"
        '
        'TabPageVarios
        '
        Me.TabPageVarios.Controls.Add(Me.GridVarios)
        Me.TabPageVarios.Key = "Varios"
        Me.TabPageVarios.Location = New System.Drawing.Point(1, 21)
        Me.TabPageVarios.Name = "TabPageVarios"
        Me.TabPageVarios.Size = New System.Drawing.Size(638, 122)
        Me.TabPageVarios.TabStop = True
        Me.TabPageVarios.Text = "Varios"
        '
        'GridVarios
        '
        Me.GridVarios.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridVarios.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridVarios.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridVarios_DesignTimeLayout.LayoutString = resources.GetString("GridVarios_DesignTimeLayout.LayoutString")
        Me.GridVarios.DesignTimeLayout = GridVarios_DesignTimeLayout
        Me.GridVarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridVarios.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridVarios.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridVarios.EntityName = "ObraVarios"
        Me.GridVarios.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridVarios.ImageList = Me.ImageList1
        Me.GridVarios.Location = New System.Drawing.Point(0, 0)
        Me.GridVarios.Name = "GridVarios"
        Me.GridVarios.PrimaryDataFields = ""
        Me.GridVarios.RelationMode = Solmicro.Expertis.Engine.RelationMode.NoRelation
        Me.GridVarios.RequeryManually = True
        Me.GridVarios.SecondaryDataFields = ""
        Me.GridVarios.Size = New System.Drawing.Size(638, 122)
        Me.GridVarios.TabIndex = 0
        Me.GridVarios.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridVarios.ViewName = "vObraDesviacionCertificacionVarios"
        '
        'Splitter2
        '
        Me.Splitter2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Splitter2.Location = New System.Drawing.Point(0, 185)
        Me.Splitter2.Name = "Splitter2"
        Me.Splitter2.Size = New System.Drawing.Size(640, 5)
        Me.Splitter2.TabIndex = 72
        Me.Splitter2.TabStop = False
        '
        'lblTrabajo
        '
        Me.lblTrabajo.Location = New System.Drawing.Point(237, 28)
        Me.lblTrabajo.Name = "lblTrabajo"
        Me.lblTrabajo.Size = New System.Drawing.Size(51, 13)
        Me.lblTrabajo.TabIndex = 107
        Me.lblTrabajo.Tag = "IdRec=5280;"
        Me.lblTrabajo.Text = "Trabajo"
        '
        'AdvIDTrabajo
        '
        Me.AdvIDTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDTrabajo.DisplayField = "CodTrabajo"
        Me.AdvIDTrabajo.EntityName = "ObraTrabajo"
        Me.AdvIDTrabajo.Location = New System.Drawing.Point(293, 23)
        Me.AdvIDTrabajo.Name = "AdvIDTrabajo"
        Me.AdvIDTrabajo.SecondaryDataFields = "IDTrabajo"
        Me.AdvIDTrabajo.Size = New System.Drawing.Size(105, 23)
        Me.AdvIDTrabajo.TabIndex = 104
        Me.AdvIDTrabajo.ViewName = "tbObraTrabajo"
        '
        'lblObra
        '
        Me.lblObra.Location = New System.Drawing.Point(34, 28)
        Me.lblObra.Name = "lblObra"
        Me.lblObra.Size = New System.Drawing.Size(57, 13)
        Me.lblObra.TabIndex = 105
        Me.lblObra.Tag = ""
        Me.lblObra.Text = "Proyecto"
        '
        'AdvIDObra
        '
        Me.AdvIDObra.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDObra.DisplayField = "NObra"
        Me.AdvIDObra.EntityName = "ObraCabecera"
        Me.AdvIDObra.Location = New System.Drawing.Point(96, 23)
        Me.AdvIDObra.Name = "AdvIDObra"
        Me.AdvIDObra.SecondaryDataFields = "IDObra"
        Me.AdvIDObra.Size = New System.Drawing.Size(105, 23)
        Me.AdvIDObra.TabIndex = 102
        Me.AdvIDObra.ViewName = "tbObraCabecera"
        '
        'Command0
        '
        Me.Command0.Icon = CType(resources.GetObject("Command0.Icon"), System.Drawing.Icon)
        Me.Command0.Key = "ShowDesviaciones"
        Me.Command0.Name = "Command0"
        Me.Command0.ToolTipText = "Desviaciones Conceptos"
        '
        'ShowDesviaciones1
        '
        Me.ShowDesviaciones1.Key = "ShowDesviaciones"
        Me.ShowDesviaciones1.Name = "ShowDesviaciones1"
        '
        'CICertificacionProduccion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(648, 478)
        Me.EntityName = "ObraTrabajo"
        Me.Name = "CICertificacionProduccion"
        Me.Text = "CICertificacionProduccion"
        Me.ViewName = "vObraDesviacionCertificacionTrabajo"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        CType(Me.TabConceptos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabConceptos.ResumeLayout(False)
        Me.TabPageMateriales.ResumeLayout(False)
        CType(Me.GridMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageMOD.ResumeLayout(False)
        CType(Me.GridMOD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageCentros.ResumeLayout(False)
        CType(Me.GridCentros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageGastos.ResumeLayout(False)
        CType(Me.GridGastos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageVarios.ResumeLayout(False)
        CType(Me.GridVarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Enum IconoValoracion
        Buena
        Mala
    End Enum

#Region " Load "

    Private Sub CICertificacionProduccion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadGridActions()
        ConfigResize()
        LoadParams()
        LoadCaptions()
    End Sub

    Private Sub LoadCaptions()
        Me.Grid.RootTable.ColumnSets(1).Caption = ExpertisApp.Traslate("Materiales")
        Me.Grid.RootTable.ColumnSets(2).Caption = ExpertisApp.Traslate("M.O.D.")
        Me.Grid.RootTable.ColumnSets(3).Caption = ExpertisApp.Traslate("Centros")
        Me.Grid.RootTable.ColumnSets(4).Caption = ExpertisApp.Traslate("Gastos")
        Me.Grid.RootTable.ColumnSets(5).Caption = ExpertisApp.Traslate("Varios")

        Me.GridMateriales.RootTable.ColumnSets(1).Caption = ExpertisApp.Traslate("Cantidades")
        Me.GridMateriales.RootTable.ColumnSets(2).Caption = ExpertisApp.Traslate("Importes")

        Me.GridMOD.RootTable.ColumnSets(1).Caption = ExpertisApp.Traslate("Horas")
        Me.GridMOD.RootTable.ColumnSets(2).Caption = ExpertisApp.Traslate("Importes")

        Me.GridCentros.RootTable.ColumnSets(1).Caption = ExpertisApp.Traslate("Horas")
        Me.GridCentros.RootTable.ColumnSets(2).Caption = ExpertisApp.Traslate("Importes")

        Me.GridGastos.RootTable.ColumnSets(1).Caption = ExpertisApp.Traslate("Importes")

        Me.GridVarios.RootTable.ColumnSets(1).Caption = ExpertisApp.Traslate("Importes")
    End Sub

    Private Sub LoadGridActions()
        Me.Grid.Actions.Add("Abrir Obra", AddressOf AccionAbrirObra, ExpertisApp.GetIcon("xProyectos.ico"))
    End Sub

    Private Sub ConfigResize()
        TabConceptos.Height = (Me.Height - FilterPanel.Height) / 3
    End Sub

    Private Sub MntoEvaluacionRiesgosOficio_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        ConfigResize()
    End Sub

    Private Sub LoadParams()
        If Not IsNothing(Me.Params) Then
            Dim ht As Hashtable = Me.Params
            AdvIDObra.Value = ht("IDObra")
            AdvIDObra.Text = ht("NObra")
            AdvIDTrabajo.Value = ht("IDTrabajo")
            AdvIDTrabajo.Text = ht("CodTrabajo")

            Me.Execute()
        End If
    End Sub

#End Region

#Region " Toolbar Actions "

    Private Sub ShowDesviaciones1_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles ShowDesviaciones1.Click
        TabConceptos.Visible = Not TabConceptos.Visible
    End Sub

#End Region

#Region " Grid Actions "

    Private Sub AccionAbrirObra()
        ExpertisApp.OpenForm("MGEO", New FilterItem("IDObra", FilterOperator.Equal, Grid.GetValue("IDObra")))
    End Sub

#End Region

#Region " Query Execute "

    Private Sub CIControlCostes_QueryExecuting(ByVal sender As Object, ByRef e As Solmicro.Expertis.Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        If Length(AdvIDObra.Value) > 0 Then
            e.Filter.Add("IDObra", FilterOperator.Equal, AdvIDObra.Value, FilterType.Numeric)
            e.Filter.Add("IDTrabajo", FilterOperator.Equal, AdvIDTrabajo.Value, FilterType.Numeric)
        Else
            e.Cancel = True
            ExpertisApp.GenerateMessage("Debe filtrar por un Proyecto.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, ExpertisApp.Title)
        End If
    End Sub

    Private Sub CICertificacionProduccion_QueryExecuted(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutedEventArgs) Handles MyBase.QueryExecuted
        Grid_Click(Grid, Nothing)
    End Sub

#End Region

    Private Sub Grid_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid.Click
        If Not Grid Is Nothing AndAlso Grid.RowCount > 0 Then
            Dim f As New Filter
            f.Add(New NumberFilterItem("IDTrabajo", Grid.Value("IDTrabajo")))
            GridMateriales.CancelData() : GridMateriales.ReQuery(f)
            GridMOD.CancelData() : GridMOD.ReQuery(f)
            GridCentros.CancelData() : GridCentros.ReQuery(f)
            GridGastos.CancelData() : GridGastos.ReQuery(f)
            GridVarios.CancelData() : GridVarios.ReQuery(f)
        End If
    End Sub

    Private Sub Grid_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles Grid.FormattingRow
        If e.Row.RowType = RowType.Record Then
            If Nz(e.Row.Cells("DesviacionMaterial").Value) > 0 Then
                e.Row.Cells("ValoracionMaterial").ImageIndex = IconoValoracion.Buena
            ElseIf Nz(e.Row.Cells("DesviacionMaterial").Value) < 0 Then
                e.Row.Cells("ValoracionMaterial").ImageIndex = IconoValoracion.Mala
            End If
            If Nz(e.Row.Cells("DesviacionMod").Value) > 0 Then
                e.Row.Cells("ValoracionMod").ImageIndex = IconoValoracion.Buena
            ElseIf Nz(e.Row.Cells("DesviacionMod").Value) < 0 Then
                e.Row.Cells("ValoracionMod").ImageIndex = IconoValoracion.Mala
            End If
            If Nz(e.Row.Cells("DesviacionCentro").Value) > 0 Then
                e.Row.Cells("ValoracionCentro").ImageIndex = IconoValoracion.Buena
            ElseIf Nz(e.Row.Cells("DesviacionCentro").Value) < 0 Then
                e.Row.Cells("ValoracionCentro").ImageIndex = IconoValoracion.Mala
            End If
            If Nz(e.Row.Cells("DesviacionGastos").Value) > 0 Then
                e.Row.Cells("ValoracionGastos").ImageIndex = IconoValoracion.Buena
            ElseIf Nz(e.Row.Cells("DesviacionGastos").Value) < 0 Then
                e.Row.Cells("ValoracionGastos").ImageIndex = IconoValoracion.Mala
            End If
            If Nz(e.Row.Cells("DesviacionVarios").Value) > 0 Then
                e.Row.Cells("ValoracionVarios").ImageIndex = IconoValoracion.Buena
            ElseIf Nz(e.Row.Cells("DesviacionVarios").Value) < 0 Then
                e.Row.Cells("ValoracionVarios").ImageIndex = IconoValoracion.Mala
            End If
        End If
    End Sub

    Private Sub GridMateriales_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles GridMateriales.FormattingRow
        If e.Row.RowType = RowType.Record Then
            If Nz(e.Row.Cells("DesviacionCantidadMaterial").Value) > 0 Then
                e.Row.Cells("ValoracionCantidad").ImageIndex = IconoValoracion.Buena
            ElseIf Nz(e.Row.Cells("DesviacionCantidadMaterial").Value) < 0 Then
                e.Row.Cells("ValoracionCantidad").ImageIndex = IconoValoracion.Mala
            End If
            If Nz(e.Row.Cells("DesviacionImporteMaterial").Value) > 0 Then
                e.Row.Cells("ValoracionImporte").ImageIndex = IconoValoracion.Buena
            ElseIf Nz(e.Row.Cells("DesviacionImporteMaterial").Value) < 0 Then
                e.Row.Cells("ValoracionImporte").ImageIndex = IconoValoracion.Mala
            End If
        End If
    End Sub

    Private Sub GridMOD_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles GridMOD.FormattingRow
        If e.Row.RowType = RowType.Record Then
            If Nz(e.Row.Cells("DesviacionCantidadMOD").Value) > 0 Then
                e.Row.Cells("ValoracionHoras").ImageIndex = IconoValoracion.Buena
            ElseIf Nz(e.Row.Cells("DesviacionCantidadMOD").Value) < 0 Then
                e.Row.Cells("ValoracionHoras").ImageIndex = IconoValoracion.Mala
            End If
            If Nz(e.Row.Cells("DesviacionImporteMOD").Value) > 0 Then
                e.Row.Cells("ValoracionImporte").ImageIndex = IconoValoracion.Buena
            ElseIf Nz(e.Row.Cells("DesviacionImporteMOD").Value) < 0 Then
                e.Row.Cells("ValoracionImporte").ImageIndex = IconoValoracion.Mala
            End If
        End If
    End Sub

    Private Sub GridCentros_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles GridCentros.FormattingRow
        If e.Row.RowType = RowType.Record Then
            If Nz(e.Row.Cells("DesviacionCantidadCentro").Value) > 0 Then
                e.Row.Cells("ValoracionHoras").ImageIndex = IconoValoracion.Buena
            ElseIf Nz(e.Row.Cells("DesviacionCantidadCentro").Value) < 0 Then
                e.Row.Cells("ValoracionHoras").ImageIndex = IconoValoracion.Mala
            End If
            If Nz(e.Row.Cells("DesviacionImporteCentro").Value) > 0 Then
                e.Row.Cells("ValoracionImporte").ImageIndex = IconoValoracion.Buena
            ElseIf Nz(e.Row.Cells("DesviacionImporteCentro").Value) < 0 Then
                e.Row.Cells("ValoracionImporte").ImageIndex = IconoValoracion.Mala
            End If
        End If
    End Sub

    Private Sub GridGastos_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles GridGastos.FormattingRow
        If e.Row.RowType = RowType.Record Then
            If Nz(e.Row.Cells("DesviacionImporteGasto").Value) > 0 Then
                e.Row.Cells("ValoracionImporte").ImageIndex = IconoValoracion.Buena
            ElseIf Nz(e.Row.Cells("DesviacionImporteGasto").Value) < 0 Then
                e.Row.Cells("ValoracionImporte").ImageIndex = IconoValoracion.Mala
            End If
        End If
    End Sub

    Private Sub GridVarios_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles GridVarios.FormattingRow
        If e.Row.RowType = RowType.Record Then
            If Nz(e.Row.Cells("DesviacionImporteVarios").Value) > 0 Then
                e.Row.Cells("ValoracionImporte").ImageIndex = IconoValoracion.Buena
            ElseIf Nz(e.Row.Cells("DesviacionImporteVarios").Value) < 0 Then
                e.Row.Cells("ValoracionImporte").ImageIndex = IconoValoracion.Mala
            End If
        End If
    End Sub

End Class