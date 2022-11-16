Imports Janus.Windows.GridEX
Public Class CITrabajosOperarioTarea
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
    Friend WithEvents cbxFechaHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxEstado As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblEstado As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvIDTarea As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblTarea As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvIDTrabajo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvIDObra As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblObra As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvOperarioSolicitante As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblOperarioSolicitante As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvOperarioAsignado As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents lblOperarioAsignado As Solmicro.Expertis.Engine.UI.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim Grid_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.ImageList.ImageStream")
        Dim cbxEstado_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CITrabajosOperarioTarea))
        Me.cbxFechaHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxEstado = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblEstado = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDTarea = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblTarea = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDTrabajo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDObra = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblObra = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvOperarioAsignado = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblOperarioAsignado = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvOperarioSolicitante = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblOperarioSolicitante = New Solmicro.Expertis.Engine.UI.Label
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
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
        Me.FilterPanel.Controls.Add(Me.lblFechaHasta)
        Me.FilterPanel.Controls.Add(Me.lblFechaDesde)
        Me.FilterPanel.Controls.Add(Me.lblEstado)
        Me.FilterPanel.Controls.Add(Me.lblTarea)
        Me.FilterPanel.Controls.Add(Me.lblTrabajo)
        Me.FilterPanel.Controls.Add(Me.lblObra)
        Me.FilterPanel.Controls.Add(Me.lblOperarioAsignado)
        Me.FilterPanel.Controls.Add(Me.lblOperarioSolicitante)
        Me.FilterPanel.Controls.Add(Me.cbxFechaHasta)
        Me.FilterPanel.Controls.Add(Me.cbxFechaDesde)
        Me.FilterPanel.Controls.Add(Me.cbxEstado)
        Me.FilterPanel.Controls.Add(Me.AdvIDTarea)
        Me.FilterPanel.Controls.Add(Me.AdvIDTrabajo)
        Me.FilterPanel.Controls.Add(Me.AdvIDObra)
        Me.FilterPanel.Controls.Add(Me.AdvOperarioAsignado)
        Me.FilterPanel.Controls.Add(Me.AdvOperarioSolicitante)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 293)
        Me.FilterPanel.Size = New System.Drawing.Size(720, 80)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(720, 293)
        '
        'Grid
        '
        Grid_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("Grid_DesignTimeLayout_Reference_0.Instance"), Object)
        Grid_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {Grid_DesignTimeLayout_Reference_0})
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.Grid.EntityName = "ObraTarea"
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Grid.ImageList = Me.ImageList1
        Me.Grid.KeyField = "IDTarea"
        Me.Grid.Size = New System.Drawing.Size(720, 293)
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.ViewName = "VCIConsultaTrabajoTareaOperario"
        '
        'CheckAll
        '
        Me.CheckAll.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'UncheckAll
        '
        Me.UncheckAll.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'ShowAllCheckedItems
        '
        Me.ShowAllCheckedItems.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
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
        Me.Toolbar.Size = New System.Drawing.Size(316, 28)
        '
        'Menubar
        '
        Me.Menubar.Location = New System.Drawing.Point(0, 28)
        '
        'MainPanel
        '
        Me.MainPanel.Size = New System.Drawing.Size(720, 373)
        '
        'ExecuteActions
        '
        Me.ExecuteActions.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(720, 373)
        '
        'cbxFechaHasta
        '
        Me.cbxFechaHasta.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaHasta.Location = New System.Drawing.Point(624, 49)
        Me.cbxFechaHasta.Name = "cbxFechaHasta"
        Me.cbxFechaHasta.Size = New System.Drawing.Size(88, 21)
        Me.cbxFechaHasta.TabIndex = 9
        '
        'lblFechaHasta
        '
        Me.lblFechaHasta.Location = New System.Drawing.Point(544, 49)
        Me.lblFechaHasta.Name = "lblFechaHasta"
        Me.lblFechaHasta.Size = New System.Drawing.Size(76, 13)
        Me.lblFechaHasta.TabIndex = 0
        Me.lblFechaHasta.Tag = "IdRec=4633;"
        Me.lblFechaHasta.Text = "Fecha Hasta"
        '
        'cbxFechaDesde
        '
        Me.cbxFechaDesde.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaDesde.Location = New System.Drawing.Point(624, 24)
        Me.cbxFechaDesde.Name = "cbxFechaDesde"
        Me.cbxFechaDesde.Size = New System.Drawing.Size(88, 21)
        Me.cbxFechaDesde.TabIndex = 8
        '
        'lblFechaDesde
        '
        Me.lblFechaDesde.Location = New System.Drawing.Point(544, 24)
        Me.lblFechaDesde.Name = "lblFechaDesde"
        Me.lblFechaDesde.Size = New System.Drawing.Size(80, 13)
        Me.lblFechaDesde.TabIndex = 10
        Me.lblFechaDesde.Tag = "IdRec=4841;"
        Me.lblFechaDesde.Text = "Fecha Desde"
        '
        'cbxEstado
        '
        cbxEstado_DesignTimeLayout.LayoutString = resources.GetString("cbxEstado_DesignTimeLayout.LayoutString")
        Me.cbxEstado.DesignTimeLayout = cbxEstado_DesignTimeLayout
        Me.cbxEstado.DisabledBackColor = System.Drawing.Color.White
        Me.cbxEstado.Location = New System.Drawing.Point(440, 49)
        Me.cbxEstado.Name = "cbxEstado"
        Me.cbxEstado.SelectedIndex = -1
        Me.cbxEstado.SelectedItem = Nothing
        Me.cbxEstado.Size = New System.Drawing.Size(93, 21)
        Me.cbxEstado.TabIndex = 7
        '
        'lblEstado
        '
        Me.lblEstado.Location = New System.Drawing.Point(392, 49)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(45, 13)
        Me.lblEstado.TabIndex = 11
        Me.lblEstado.Tag = "IdRec=4405;"
        Me.lblEstado.Text = "Estado"
        '
        'AdvIDTarea
        '
        Me.AdvIDTarea.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDTarea.DisplayField = "NTarea"
        Me.AdvIDTarea.EntityName = "ObraTarea"
        Me.AdvIDTarea.Location = New System.Drawing.Point(440, 24)
        Me.AdvIDTarea.Name = "AdvIDTarea"
        Me.AdvIDTarea.SecondaryDataFields = "IDTarea"
        Me.AdvIDTarea.Size = New System.Drawing.Size(93, 23)
        Me.AdvIDTarea.TabIndex = 6
        '
        'lblTarea
        '
        Me.lblTarea.Location = New System.Drawing.Point(392, 24)
        Me.lblTarea.Name = "lblTarea"
        Me.lblTarea.Size = New System.Drawing.Size(40, 13)
        Me.lblTarea.TabIndex = 12
        Me.lblTarea.Tag = "IdRec=6104;"
        Me.lblTarea.Text = "Tarea"
        '
        'AdvIDTrabajo
        '
        Me.AdvIDTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDTrabajo.DisplayField = "CodTrabajo"
        Me.AdvIDTrabajo.EntityName = "ObraTrabajo"
        Me.AdvIDTrabajo.Location = New System.Drawing.Point(276, 49)
        Me.AdvIDTrabajo.Name = "AdvIDTrabajo"
        Me.AdvIDTrabajo.SecondaryDataFields = "IDTrabajo"
        Me.AdvIDTrabajo.Size = New System.Drawing.Size(104, 23)
        Me.AdvIDTrabajo.TabIndex = 5
        '
        'lblTrabajo
        '
        Me.lblTrabajo.Location = New System.Drawing.Point(217, 49)
        Me.lblTrabajo.Name = "lblTrabajo"
        Me.lblTrabajo.Size = New System.Drawing.Size(51, 13)
        Me.lblTrabajo.TabIndex = 14
        Me.lblTrabajo.Tag = "IdRec=5280;"
        Me.lblTrabajo.Text = "Trabajo"
        '
        'AdvIDObra
        '
        Me.AdvIDObra.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDObra.DisplayField = "NObra"
        Me.AdvIDObra.EntityName = "ObraCabecera"
        Me.AdvIDObra.Location = New System.Drawing.Point(276, 24)
        Me.AdvIDObra.Name = "AdvIDObra"
        Me.AdvIDObra.SecondaryDataFields = "IDObra"
        Me.AdvIDObra.Size = New System.Drawing.Size(104, 23)
        Me.AdvIDObra.TabIndex = 4
        '
        'lblObra
        '
        Me.lblObra.Location = New System.Drawing.Point(217, 24)
        Me.lblObra.Name = "lblObra"
        Me.lblObra.Size = New System.Drawing.Size(57, 13)
        Me.lblObra.TabIndex = 16
        Me.lblObra.Tag = ""
        Me.lblObra.Text = "Proyecto"
        '
        'AdvOperarioAsignado
        '
        Me.AdvOperarioAsignado.DisabledBackColor = System.Drawing.Color.White
        Me.AdvOperarioAsignado.EntityName = "Operario"
        Me.AdvOperarioAsignado.Location = New System.Drawing.Point(124, 49)
        Me.AdvOperarioAsignado.Name = "AdvOperarioAsignado"
        Me.AdvOperarioAsignado.SecondaryDataFields = "IDOperario"
        Me.AdvOperarioAsignado.Size = New System.Drawing.Size(84, 23)
        Me.AdvOperarioAsignado.TabIndex = 3
        '
        'lblOperarioAsignado
        '
        Me.lblOperarioAsignado.Location = New System.Drawing.Point(3, 49)
        Me.lblOperarioAsignado.Name = "lblOperarioAsignado"
        Me.lblOperarioAsignado.Size = New System.Drawing.Size(113, 13)
        Me.lblOperarioAsignado.TabIndex = 18
        Me.lblOperarioAsignado.Tag = "IdRec=12762;"
        Me.lblOperarioAsignado.Text = "Operario Asignado"
        '
        'AdvOperarioSolicitante
        '
        Me.AdvOperarioSolicitante.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescOperario", lblOperarioSolicitante)})
        Me.AdvOperarioSolicitante.DisabledBackColor = System.Drawing.Color.White
        Me.AdvOperarioSolicitante.EntityName = "Operario"
        Me.AdvOperarioSolicitante.Location = New System.Drawing.Point(124, 24)
        Me.AdvOperarioSolicitante.Name = "AdvOperarioSolicitante"
        Me.AdvOperarioSolicitante.SecondaryDataFields = "IDOperario"
        Me.AdvOperarioSolicitante.Size = New System.Drawing.Size(84, 23)
        Me.AdvOperarioSolicitante.TabIndex = 2
        '
        'lblOperarioSolicitante
        '
        Me.lblOperarioSolicitante.Location = New System.Drawing.Point(3, 24)
        Me.lblOperarioSolicitante.Name = "lblOperarioSolicitante"
        Me.lblOperarioSolicitante.Size = New System.Drawing.Size(120, 13)
        Me.lblOperarioSolicitante.TabIndex = 20
        Me.lblOperarioSolicitante.Tag = "IdRec=12761;"
        Me.lblOperarioSolicitante.Text = "Operario Solicitante"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "xTareas.ico")
        '
        'CITrabajosOperarioTarea
        '
        Me.AllowUpdate = True
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(728, 461)
        Me.EntityName = "ObraTarea"
        Me.KeyField = "IDTarea"
        Me.Name = "CITrabajosOperarioTarea"
        Me.Text = "Consulta de Tareas Obras"
        Me.ViewName = "VCIConsultaTrabajoTareaOperario"
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

    Private Const cnABRIROPERARIO As String = "Abrir Operario"

#Region " Load "

    Private Sub CITrabajosOperarioTarea_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbxEstado.DataSource = New EnumData("enumotaEstado")
        EnumData.PopulateValueList("enumotaEstado", Grid.Columns("Estado"))
        LoadGridActions()
    End Sub

    Private Sub LoadGridActions()
        Grid.Actions.Add("Abrir Tarea", AddressOf AccionAbrirTareas, ExpertisApp.GetIcon("xTareas.ico"))
        Grid.Actions.Add("Abrir Detalle Parte Tarea", AddressOf AccionAbrirDatalleParteTarea, ExpertisApp.GetIcon("document_find.ico"))
        Grid.AddSeparator()
        Grid.Actions.Add("Abrir Proyecto", AddressOf AccionAbrirObra, ExpertisApp.GetIcon("xProyectos.ico"))
        Grid.Actions.Add(cnABRIROPERARIO, AddressOf AccionAbrirOperario, ExpertisApp.GetIcon("xPartesTrabajo.ico"))
    End Sub

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

    Private Sub AccionAbrirObra()
        If ExpertisApp.IsFormOpen("MGEO") Then ExpertisApp.CloseForm("MGEO")
        ExpertisApp.OpenForm("MGEO", New FilterItem("IDObra", FilterOperator.Equal, Grid.GetValue("IDObra")))
    End Sub

    Private Sub AccionAbrirOperario()
        If ExpertisApp.IsFormOpen("MNTOOPER") Then ExpertisApp.CloseForm("MNTOOPER")
        ExpertisApp.OpenForm("MNTOOPER", New FilterItem("IDOperario", FilterOperator.Equal, Grid.GetValue("IDOperario")))
    End Sub

#End Region

#Region " Grid "

    Private Sub Grid_ColumnButtonClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles Grid.ColumnButtonClick
        With Grid
            Select Case e.Column.Key
                Case "DescTarea"
                    Dim frm As New FormularioTexto
                    frm.SoloLectura = True
                    frm.Texto = .Value("DescTarea") & String.Empty
                    frm.ShowDialog()
            End Select
        End With
    End Sub

    Private Sub Grid_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Grid.MouseUp
        If e.Button = MouseButtons.Right Then
            If Not IsNothing(Grid) AndAlso Grid.RowCount > 0 Then
                If Length(Grid.Value("IDOperario")) > 0 Then
                    Grid.UiCommandManager1.Commands(cnABRIROPERARIO).Visible = InheritableBoolean.True
                Else
                    Grid.UiCommandManager1.Commands(cnABRIROPERARIO).Visible = InheritableBoolean.False
                End If
            End If
        End If
    End Sub

#End Region

    Private Sub CITrabajosOperarioTarea_QueryExecuting(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        e.Filter.Add("Estado", FilterOperator.Equal, cbxEstado.Value, FilterType.Numeric)
        e.Filter.Add("IdTarea", FilterOperator.Equal, AdvIDTarea.Value, FilterType.Numeric)
        e.Filter.Add("IdTrabajo", FilterOperator.Equal, AdvIDTrabajo.Value, FilterType.Numeric)
        e.Filter.Add("IdObra", FilterOperator.Equal, AdvIDObra.Value, FilterType.Numeric)
        e.Filter.Add("IDOperario", FilterOperator.Equal, AdvOperarioAsignado.Text, FilterType.String)
        e.Filter.Add("IDOperarioSolicitante", FilterOperator.Equal, AdvOperarioSolicitante.Text, FilterType.String)
        e.Filter.Add("FechaTarea", FilterOperator.GreaterThanOrEqual, cbxFechaDesde.Value, FilterType.DateTime)
        e.Filter.Add("FechaTarea", FilterOperator.LessThanOrEqual, cbxFechaHasta.Value, FilterType.DateTime)
    End Sub

    Private Sub AdvIDTrabajo_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles AdvIDTrabajo.SetPredefinedFilter
        If Length(AdvIDObra.Value) > 0 Then e.Filter.Add("IdObra", AdvIDObra.Value)
    End Sub

    Private Sub AdvIDTarea_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles AdvIDTarea.SetPredefinedFilter
        If Length(AdvIDObra.Value) > 0 Then e.Filter.Add("IdObra", AdvIDObra.Value)
        If Length(AdvIDTrabajo.Value) > 0 Then e.Filter.Add("IdTrabajo", AdvIDTrabajo.Value)
    End Sub

    Private Sub CITrabajosOperarioTarea_FilterCleared(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.FilterCleared
        cbxFechaDesde.TextBox.Clear() : cbxFechaDesde.Value = Nothing
        cbxFechaHasta.TextBox.Clear() : cbxFechaHasta.Value = Nothing
    End Sub

End Class