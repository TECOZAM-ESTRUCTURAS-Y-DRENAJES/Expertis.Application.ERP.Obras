Public Class CITareasObra
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
    Friend WithEvents lblTarea As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvIDOperarioSolicitante As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblOperarioSolicitante As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxPrioridad As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblPrioridad As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvIDObra As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lbObra As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvIDTrabajo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxEstado As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblEstado As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvIDOperario As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblIDOperario As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents AdvTarea As Solmicro.Expertis.Engine.UI.AdvSearch
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim Grid_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.ImageList.ImageStream")
        Dim cbxPrioridad_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CITareasObra))
        Dim cbxEstado_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.AdvTarea = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblTarea = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDOperarioSolicitante = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblOperarioSolicitante = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxPrioridad = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblPrioridad = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDObra = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lbObra = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDTrabajo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxEstado = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblEstado = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDOperario = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblIDOperario = New Solmicro.Expertis.Engine.UI.Label
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        CType(Me.cbxPrioridad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.lblTarea)
        Me.FilterPanel.Controls.Add(Me.lblOperarioSolicitante)
        Me.FilterPanel.Controls.Add(Me.lblPrioridad)
        Me.FilterPanel.Controls.Add(Me.lbObra)
        Me.FilterPanel.Controls.Add(Me.lblTrabajo)
        Me.FilterPanel.Controls.Add(Me.lblFechaHasta)
        Me.FilterPanel.Controls.Add(Me.lblFechaDesde)
        Me.FilterPanel.Controls.Add(Me.lblEstado)
        Me.FilterPanel.Controls.Add(Me.lblIDOperario)
        Me.FilterPanel.Controls.Add(Me.AdvTarea)
        Me.FilterPanel.Controls.Add(Me.AdvIDOperarioSolicitante)
        Me.FilterPanel.Controls.Add(Me.cbxPrioridad)
        Me.FilterPanel.Controls.Add(Me.AdvIDObra)
        Me.FilterPanel.Controls.Add(Me.AdvIDTrabajo)
        Me.FilterPanel.Controls.Add(Me.cbxFechaHasta)
        Me.FilterPanel.Controls.Add(Me.cbxFechaDesde)
        Me.FilterPanel.Controls.Add(Me.cbxEstado)
        Me.FilterPanel.Controls.Add(Me.AdvIDOperario)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 261)
        Me.FilterPanel.Size = New System.Drawing.Size(592, 96)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(592, 261)
        '
        'Grid
        '
        Me.Grid.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDIncidencia", "Incidencia", "IDIncidencia", "tbMaestroIncidencia"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDTipoTarea", "TipoTarea", "IDTipoTarea", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescTipoTarea", "")}), "tbMaestroTipoTarea"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDOperario", "Operario", "IDOperario", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescOperario", "DescOperario")}), "tbMaestroOperario"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDOperarioSolicitante", "Operario", "IDOperario", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescOperario", "DescOperarioSolicitante")}), "tbMaestroOperario")})
        Me.Grid.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[True]
        Grid_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("Grid_DesignTimeLayout_Reference_0.Instance"), Object)
        Grid_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {Grid_DesignTimeLayout_Reference_0})
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EntityName = "ObraTarea"
        Me.Grid.ImageList = Me.ImageList1
        Me.Grid.Size = New System.Drawing.Size(592, 261)
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.ViewName = "vCITareasObra"
        '
        'CheckAll
        '
        Me.CheckAll.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        Me.CheckAll.Icon = CType(resources.GetObject("CheckAll.Icon"), System.Drawing.Icon)
        '
        'UncheckAll
        '
        Me.UncheckAll.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        Me.UncheckAll.Icon = CType(resources.GetObject("UncheckAll.Icon"), System.Drawing.Icon)
        '
        'ExecuteQuery
        '
        Me.ExecuteQuery.Icon = CType(resources.GetObject("ExecuteQuery.Icon"), System.Drawing.Icon)
        '
        'ShowAllCheckedItems
        '
        Me.ShowAllCheckedItems.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        Me.ShowAllCheckedItems.Icon = CType(resources.GetObject("ShowAllCheckedItems.Icon"), System.Drawing.Icon)
        '
        'ClearFilter
        '
        Me.ClearFilter.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        Me.ClearFilter.Icon = CType(resources.GetObject("ClearFilter.Icon"), System.Drawing.Icon)
        '
        'Export
        '
        Me.Export.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        Me.Export.Icon = CType(resources.GetObject("Export.Icon"), System.Drawing.Icon)
        '
        'Toolbar
        '
        Me.Toolbar.Size = New System.Drawing.Size(316, 28)
        '
        'Menubar
        '
        Me.Menubar.Location = New System.Drawing.Point(0, 28)
        '
        'MainPanel
        '
        Me.MainPanel.Size = New System.Drawing.Size(592, 357)
        '
        'ExecuteActions
        '
        Me.ExecuteActions.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        Me.ExecuteActions.Icon = CType(resources.GetObject("ExecuteActions.Icon"), System.Drawing.Icon)
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(592, 357)
        '
        'AdvTarea
        '
        Me.AdvTarea.DisabledBackColor = System.Drawing.Color.White
        Me.AdvTarea.DisplayField = "NTarea"
        Me.AdvTarea.EntityName = "ObraTarea"
        Me.AdvTarea.Location = New System.Drawing.Point(68, 69)
        Me.AdvTarea.Name = "AdvTarea"
        Me.AdvTarea.SecondaryDataFields = "IDTarea"
        Me.AdvTarea.Size = New System.Drawing.Size(106, 23)
        Me.AdvTarea.TabIndex = 2
        '
        'lblTarea
        '
        Me.lblTarea.Location = New System.Drawing.Point(8, 69)
        Me.lblTarea.Name = "lblTarea"
        Me.lblTarea.Size = New System.Drawing.Size(40, 13)
        Me.lblTarea.TabIndex = 0
        Me.lblTarea.Tag = "IdRec=6104;"
        Me.lblTarea.Text = "Tarea"
        '
        'AdvIDOperarioSolicitante
        '
        Me.AdvIDOperarioSolicitante.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDOperarioSolicitante.EntityName = "Operario"
        Me.AdvIDOperarioSolicitante.Location = New System.Drawing.Point(317, 21)
        Me.AdvIDOperarioSolicitante.Name = "AdvIDOperarioSolicitante"
        Me.AdvIDOperarioSolicitante.SecondaryDataFields = "IDOperario"
        Me.AdvIDOperarioSolicitante.Size = New System.Drawing.Size(80, 23)
        Me.AdvIDOperarioSolicitante.TabIndex = 3
        '
        'lblOperarioSolicitante
        '
        Me.lblOperarioSolicitante.Location = New System.Drawing.Point(197, 21)
        Me.lblOperarioSolicitante.Name = "lblOperarioSolicitante"
        Me.lblOperarioSolicitante.Size = New System.Drawing.Size(120, 13)
        Me.lblOperarioSolicitante.TabIndex = 5
        Me.lblOperarioSolicitante.Tag = "IdRec=12761;"
        Me.lblOperarioSolicitante.Text = "Operario Solicitante"
        '
        'cbxPrioridad
        '
        Me.TryDataBinding(cbxPrioridad, New System.Windows.Forms.Binding("Value", Me, "Prioridad", True))
        cbxPrioridad_DesignTimeLayout.LayoutString = resources.GetString("cbxPrioridad_DesignTimeLayout.LayoutString")
        Me.cbxPrioridad.DesignTimeLayout = cbxPrioridad_DesignTimeLayout
        Me.cbxPrioridad.DisabledBackColor = System.Drawing.Color.White
        Me.cbxPrioridad.Location = New System.Drawing.Point(317, 69)
        Me.cbxPrioridad.Name = "cbxPrioridad"
        Me.cbxPrioridad.SelectedIndex = -1
        Me.cbxPrioridad.SelectedItem = Nothing
        Me.cbxPrioridad.Size = New System.Drawing.Size(80, 21)
        Me.cbxPrioridad.TabIndex = 5
        '
        'lblPrioridad
        '
        Me.lblPrioridad.Location = New System.Drawing.Point(197, 69)
        Me.lblPrioridad.Name = "lblPrioridad"
        Me.lblPrioridad.Size = New System.Drawing.Size(58, 13)
        Me.lblPrioridad.TabIndex = 7
        Me.lblPrioridad.Tag = "IdRec=4705;"
        Me.lblPrioridad.Text = "Prioridad"
        '
        'AdvIDObra
        '
        Me.AdvIDObra.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDObra.DisplayField = "NObra"
        Me.AdvIDObra.EntityName = "ObraCabecera"
        Me.AdvIDObra.Location = New System.Drawing.Point(68, 21)
        Me.AdvIDObra.Name = "AdvIDObra"
        Me.AdvIDObra.SecondaryDataFields = "IDObra"
        Me.AdvIDObra.Size = New System.Drawing.Size(106, 23)
        Me.AdvIDObra.TabIndex = 0
        '
        'lbObra
        '
        Me.lbObra.Location = New System.Drawing.Point(8, 21)
        Me.lbObra.Name = "lbObra"
        Me.lbObra.Size = New System.Drawing.Size(57, 13)
        Me.lbObra.TabIndex = 8
        Me.lbObra.Tag = ""
        Me.lbObra.Text = "Proyecto"
        '
        'AdvIDTrabajo
        '
        Me.AdvIDTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDTrabajo.DisplayField = "CodTrabajo"
        Me.AdvIDTrabajo.EntityName = "ObraTrabajo"
        Me.AdvIDTrabajo.Location = New System.Drawing.Point(68, 45)
        Me.AdvIDTrabajo.Name = "AdvIDTrabajo"
        Me.AdvIDTrabajo.SecondaryDataFields = "IDTrabajo"
        Me.AdvIDTrabajo.Size = New System.Drawing.Size(106, 23)
        Me.AdvIDTrabajo.TabIndex = 1
        '
        'lblTrabajo
        '
        Me.lblTrabajo.Location = New System.Drawing.Point(8, 45)
        Me.lblTrabajo.Name = "lblTrabajo"
        Me.lblTrabajo.Size = New System.Drawing.Size(51, 13)
        Me.lblTrabajo.TabIndex = 10
        Me.lblTrabajo.Tag = ""
        Me.lblTrabajo.Text = "Trabajo"
        '
        'cbxFechaHasta
        '
        Me.cbxFechaHasta.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaHasta.Location = New System.Drawing.Point(496, 69)
        Me.cbxFechaHasta.Name = "cbxFechaHasta"
        Me.cbxFechaHasta.Size = New System.Drawing.Size(87, 21)
        Me.cbxFechaHasta.TabIndex = 8
        '
        'lblFechaHasta
        '
        Me.lblFechaHasta.Location = New System.Drawing.Point(416, 69)
        Me.lblFechaHasta.Name = "lblFechaHasta"
        Me.lblFechaHasta.Size = New System.Drawing.Size(76, 13)
        Me.lblFechaHasta.TabIndex = 12
        Me.lblFechaHasta.Tag = "IdRec=4633;"
        Me.lblFechaHasta.Text = "Fecha Hasta"
        '
        'cbxFechaDesde
        '
        Me.cbxFechaDesde.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaDesde.Location = New System.Drawing.Point(496, 45)
        Me.cbxFechaDesde.Name = "cbxFechaDesde"
        Me.cbxFechaDesde.Size = New System.Drawing.Size(87, 21)
        Me.cbxFechaDesde.TabIndex = 7
        '
        'lblFechaDesde
        '
        Me.lblFechaDesde.Location = New System.Drawing.Point(416, 45)
        Me.lblFechaDesde.Name = "lblFechaDesde"
        Me.lblFechaDesde.Size = New System.Drawing.Size(80, 13)
        Me.lblFechaDesde.TabIndex = 13
        Me.lblFechaDesde.Tag = "IdRec=4841;"
        Me.lblFechaDesde.Text = "Fecha Desde"
        '
        'cbxEstado
        '
        cbxEstado_DesignTimeLayout.LayoutString = resources.GetString("cbxEstado_DesignTimeLayout.LayoutString")
        Me.cbxEstado.DesignTimeLayout = cbxEstado_DesignTimeLayout
        Me.cbxEstado.DisabledBackColor = System.Drawing.Color.White
        Me.cbxEstado.Location = New System.Drawing.Point(496, 21)
        Me.cbxEstado.Name = "cbxEstado"
        Me.cbxEstado.SelectedIndex = -1
        Me.cbxEstado.SelectedItem = Nothing
        Me.cbxEstado.Size = New System.Drawing.Size(87, 21)
        Me.cbxEstado.TabIndex = 6
        '
        'lblEstado
        '
        Me.lblEstado.Location = New System.Drawing.Point(416, 21)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(45, 13)
        Me.lblEstado.TabIndex = 14
        Me.lblEstado.Tag = "IdRec=4405;"
        Me.lblEstado.Text = "Estado"
        '
        'AdvIDOperario
        '
        Me.AdvIDOperario.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDOperario.EntityName = "Operario"
        Me.AdvIDOperario.Location = New System.Drawing.Point(317, 45)
        Me.AdvIDOperario.Name = "AdvIDOperario"
        Me.AdvIDOperario.SecondaryDataFields = "IDOperario"
        Me.AdvIDOperario.Size = New System.Drawing.Size(80, 23)
        Me.AdvIDOperario.TabIndex = 4
        '
        'lblIDOperario
        '
        Me.lblIDOperario.Location = New System.Drawing.Point(197, 45)
        Me.lblIDOperario.Name = "lblIDOperario"
        Me.lblIDOperario.Size = New System.Drawing.Size(113, 13)
        Me.lblIDOperario.TabIndex = 15
        Me.lblIDOperario.Tag = "IdRec=12762;"
        Me.lblIDOperario.Text = "Operario Asignado"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "folder_edit.ico")
        '
        'CITareasObra
        '
        Me.AllowUpdate = True
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(600, 445)
        Me.EntityName = "ObraTarea"
        Me.Name = "CITareasObra"
        Me.ViewName = "vCITareasObra"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        CType(Me.cbxPrioridad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxEstado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Load "

    Private Sub CITareasObra_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'LoadToolbarActions()
        LoadEnum()
        LoadGridActions()
    End Sub

    Private Sub LoadEnum()
        cbxEstado.DataSource = New EnumData("enumotaEstado")
        cbxPrioridad.DataSource = New EnumData("enumotaPrioridad")
        EnumData.PopulateValueList("enumotaEstado", Grid.Columns("Estado"))
        EnumData.PopulateValueList("enumotaPrioridad", Grid.Columns("Prioridad"))
    End Sub

    Private Sub LoadGridActions()
        Grid.Actions.Add("Abrir Tarea", AddressOf AccionAbrirTareas, ExpertisApp.GetIcon("xTareas.ico"))
        Grid.Actions.Add("Abrir Detalle Parte Tarea", AddressOf AccionAbrirDatalleParteTarea, ExpertisApp.GetIcon("document_find.ico"))
    End Sub

    Private Sub LoadToolbarActions()
        Me.FormActions.Add("Ordenar Secuencias", AddressOf OrdenarSecuencias, ExpertisApp.GetIcon("sort_ascending.ico"))
    End Sub

#End Region

#Region " Acciones ToolBar "

    Private Sub OrdenarSecuencias()
        If Length(AdvIDOperario.Value) = 0 And Not EvaluarEstado() Then
            ExpertisApp.GenerateMessage("Debe establecer un filtro para el Operario Asignado y Estado: 'Planificada'.")
        ElseIf Length(AdvIDOperario.Value) <> 0 And Not EvaluarEstado() Then
            ExpertisApp.GenerateMessage("Debe filtrar por Estado: 'Planificada'. ")
        ElseIf Length(AdvIDOperario.Value) = 0 And EvaluarEstado() Then
            ExpertisApp.GenerateMessage("Debe establecer un filtro para el Operario Asignado.")
        Else
            ExpertisApp.ExecuteTask(Of String)(AddressOf ObraTarea.SecuenciarTareas, AdvIDOperario.Value)
        End If
    End Sub

    Private Function EvaluarEstado() As Boolean
        Dim blnEvaluar As Boolean = False
        If Length(cbxEstado.Text) = 0 Then
            blnEvaluar = False
        ElseIf (cbxEstado.Value = enumotaEstado.otaPlanificada) Then
            blnEvaluar = True
        End If

        Return blnEvaluar
    End Function

#End Region

#Region " Grid Actions "

    Private Sub AccionAbrirTareas()
        AbrirMantenimientoTarea(Grid.GetValue("IDTarea"))
    End Sub

    Private Sub AccionAbrirDatalleParteTarea()
        With Grid
            Dim frm As New FrmDetalleParteTarea
            frm.AbrirDetalleParteTarea(.GetValue("IDTarea"), .GetValue("NTarea"), _
                                       .GetValue("DescTarea") & String.Empty, Me)
        End With
    End Sub

#End Region

    Private Sub Grid_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid.Click
        Dim hit As Janus.Windows.GridEX.GridArea
        With Grid
            hit = .HitTest()
            If hit = Janus.Windows.GridEX.GridArea.Cell Or hit = Janus.Windows.GridEX.GridArea.NewRowCell Then
                Dim c As Janus.Windows.GridEX.GridEXColumn = .ColumnFromPoint()
                If Not IsNothing(c) Then
                    Select Case c.Key
                        Case "Texto"
                            Dim frm As New FormularioTexto
                            frm.Texto = .Value("Texto") & String.Empty
                            frm.ShowDialog()
                            If .Value("Texto") & String.Empty <> frm.Texto Then
                                .SetValue("Texto", frm.Texto)
                            End If
                    End Select
                End If
            End If
        End With
    End Sub

    Private Sub CITareasObra_QueryExecuting(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        e.Filter.Add("IdObra", FilterOperator.Equal, AdvIDObra.Value, FilterType.Numeric)
        e.Filter.Add("IdTarea", FilterOperator.Equal, AdvTarea.Value, FilterType.Numeric)
        e.Filter.Add("IDTrabajo", FilterOperator.Equal, AdvIDTrabajo.Value, FilterType.Numeric)
        e.Filter.Add("IDOperario", FilterOperator.Equal, AdvIDOperario.Value, FilterType.String)
        e.Filter.Add("IDOperarioSolicitante", FilterOperator.Equal, AdvIDOperarioSolicitante.Value, FilterType.String)
        e.Filter.Add("FechaTarea", FilterOperator.GreaterThanOrEqual, cbxFechaDesde.Value, FilterType.DateTime)
        e.Filter.Add("FechaTarea", FilterOperator.LessThanOrEqual, cbxFechaHasta.Value, FilterType.DateTime)
        If Length(cbxPrioridad.Value) > 0 Then
            e.Filter.Add("Prioridad", FilterOperator.Equal, cbxPrioridad.Value, FilterType.Numeric)
        End If
        If Length(cbxEstado.Value) > 0 Then
            e.Filter.Add("Estado", FilterOperator.Equal, cbxEstado.Value, FilterType.Numeric)
        End If
    End Sub

    Private Sub AdvIDTrabajo_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles AdvIDTrabajo.SetPredefinedFilter
        If Length(AdvIDObra.Value) > 0 Then
            e.Filter.Add("IdObra", AdvIDObra.Value)
        End If
    End Sub

    Private Sub AdvTarea_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles AdvTarea.SetPredefinedFilter
        If Length(AdvIDObra.Value) > 0 Then
            e.Filter.Add("IdObra", AdvIDObra.Value)
        End If
        If Length(AdvIDTrabajo.Value) > 0 Then
            e.Filter.Add("IdTrabajo", AdvIDTrabajo.Value)
        End If
    End Sub

    Private Sub CITareasObra_FilterCleared(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.FilterCleared
        Me.cbxFechaDesde.TextBox.Clear() : Me.cbxFechaDesde.Value = Nothing
        Me.cbxFechaHasta.TextBox.Clear() : Me.cbxFechaHasta.Value = Nothing
    End Sub

    Private Sub CITareasObra_SetReportDesignObjects(ByVal sender As Object, ByVal e As Engine.UI.ReportDesignObjectsEventArgs) Handles MyBase.SetReportDesignObjects
        Select Case e.Alias
            Case "TAREASTRAT"
                If Length(cbxFechaDesde.Value) > 0 Then e.Formulas("FechaDesde").Text = cbxFechaDesde.Value
                If Length(cbxFechaHasta.Value) > 0 Then e.Formulas("FechaHasta").Text = cbxFechaHasta.Value
        End Select
    End Sub

End Class