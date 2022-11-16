Public Class CICopiaTipoTrabajo
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
    Friend WithEvents lblTipoTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvIDTipoTrabajo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblTipoObra As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvIDTipoObra As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblSubTipoTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvIDSubTipoTrabajo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblObraDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblObraHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvObraDesde As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvIDSubSubTipoTrabajo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvObraHasta As Solmicro.Expertis.Engine.UI.AdvSearch
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CICopiaTipoTrabajo))
        Me.lblTipoTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDTipoTrabajo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblTipoObra = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDTipoObra = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblSubTipoTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDSubTipoTrabajo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblObraDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvObraDesde = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblObraHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvObraHasta = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDSubSubTipoTrabajo = New Solmicro.Expertis.Engine.UI.AdvSearch
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
        Me.FilterPanel.Controls.Add(Me.Label1)
        Me.FilterPanel.Controls.Add(Me.AdvIDSubSubTipoTrabajo)
        Me.FilterPanel.Controls.Add(Me.lblObraDesde)
        Me.FilterPanel.Controls.Add(Me.lblObraHasta)
        Me.FilterPanel.Controls.Add(Me.lblTipoTrabajo)
        Me.FilterPanel.Controls.Add(Me.lblTipoObra)
        Me.FilterPanel.Controls.Add(Me.lblSubTipoTrabajo)
        Me.FilterPanel.Controls.Add(Me.AdvObraDesde)
        Me.FilterPanel.Controls.Add(Me.AdvObraHasta)
        Me.FilterPanel.Controls.Add(Me.AdvIDTipoTrabajo)
        Me.FilterPanel.Controls.Add(Me.AdvIDTipoObra)
        Me.FilterPanel.Controls.Add(Me.AdvIDSubTipoTrabajo)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 167)
        Me.FilterPanel.Size = New System.Drawing.Size(638, 102)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(638, 167)
        '
        'Grid
        '
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EntityName = "ObraCabecera"
        Me.Grid.KeyField = "IDObra;IDTipoObra;IDTipoTrabajo;CodTrabajo"
        Me.Grid.Size = New System.Drawing.Size(638, 167)
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.UseCheck = True
        Me.Grid.ViewName = "vCICopiaTiposTrabajoSinEstablecer"
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
        Me.MainPanel.Size = New System.Drawing.Size(638, 269)
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(638, 269)
        '
        'lblTipoTrabajo
        '
        Me.lblTipoTrabajo.Location = New System.Drawing.Point(392, 27)
        Me.lblTipoTrabajo.Name = "lblTipoTrabajo"
        Me.lblTipoTrabajo.Size = New System.Drawing.Size(79, 13)
        Me.lblTipoTrabajo.TabIndex = 85
        Me.lblTipoTrabajo.Tag = "IdRec=5702;"
        Me.lblTipoTrabajo.Text = "Tipo Trabajo"
        '
        'AdvIDTipoTrabajo
        '
        Me.AdvIDTipoTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDTipoTrabajo.EntityName = "ObraTipoTrabajo"
        Me.AdvIDTipoTrabajo.Location = New System.Drawing.Point(526, 22)
        Me.AdvIDTipoTrabajo.Name = "AdvIDTipoTrabajo"
        Me.AdvIDTipoTrabajo.SecondaryDataFields = "IDTipoTrabajo"
        Me.AdvIDTipoTrabajo.Size = New System.Drawing.Size(92, 23)
        Me.AdvIDTipoTrabajo.TabIndex = 3
        Me.AdvIDTipoTrabajo.ViewName = "tbObraTipoTrabajo"
        '
        'lblTipoObra
        '
        Me.lblTipoObra.Location = New System.Drawing.Point(15, 79)
        Me.lblTipoObra.Name = "lblTipoObra"
        Me.lblTipoObra.Size = New System.Drawing.Size(85, 13)
        Me.lblTipoObra.TabIndex = 86
        Me.lblTipoObra.Tag = ""
        Me.lblTipoObra.Text = "Tipo Proyecto"
        '
        'AdvIDTipoObra
        '
        Me.AdvIDTipoObra.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDTipoObra.EntityName = "ObraTipo"
        Me.AdvIDTipoObra.Location = New System.Drawing.Point(114, 74)
        Me.AdvIDTipoObra.Name = "AdvIDTipoObra"
        Me.AdvIDTipoObra.SecondaryDataFields = "IDTipoObra"
        Me.AdvIDTipoObra.Size = New System.Drawing.Size(105, 23)
        Me.AdvIDTipoObra.TabIndex = 2
        Me.AdvIDTipoObra.ViewName = "tbObraTipo"
        '
        'lblSubTipoTrabajo
        '
        Me.lblSubTipoTrabajo.Location = New System.Drawing.Point(392, 53)
        Me.lblSubTipoTrabajo.Name = "lblSubTipoTrabajo"
        Me.lblSubTipoTrabajo.Size = New System.Drawing.Size(101, 13)
        Me.lblSubTipoTrabajo.TabIndex = 87
        Me.lblSubTipoTrabajo.Tag = "IdRec=5703;"
        Me.lblSubTipoTrabajo.Text = "SubTipo Trabajo"
        '
        'AdvIDSubTipoTrabajo
        '
        Me.AdvIDSubTipoTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDSubTipoTrabajo.EntityName = "ObraSubtipoTrabajo"
        Me.AdvIDSubTipoTrabajo.Location = New System.Drawing.Point(526, 48)
        Me.AdvIDSubTipoTrabajo.Name = "AdvIDSubTipoTrabajo"
        Me.AdvIDSubTipoTrabajo.SecondaryDataFields = "IDSubtipoTrabajo"
        Me.AdvIDSubTipoTrabajo.Size = New System.Drawing.Size(92, 23)
        Me.AdvIDSubTipoTrabajo.TabIndex = 4
        Me.AdvIDSubTipoTrabajo.ViewName = "tbObraSubtipoTrabajo"
        '
        'lblObraDesde
        '
        Me.lblObraDesde.Location = New System.Drawing.Point(15, 27)
        Me.lblObraDesde.Name = "lblObraDesde"
        Me.lblObraDesde.Size = New System.Drawing.Size(97, 13)
        Me.lblObraDesde.TabIndex = 90
        Me.lblObraDesde.Tag = ""
        Me.lblObraDesde.Text = "Proyecto Desde"
        '
        'AdvObraDesde
        '
        Me.AdvObraDesde.DisabledBackColor = System.Drawing.Color.White
        Me.AdvObraDesde.DisplayField = "NObra"
        Me.AdvObraDesde.EntityName = "ObraCabecera"
        Me.AdvObraDesde.Location = New System.Drawing.Point(114, 22)
        Me.AdvObraDesde.Name = "AdvObraDesde"
        Me.AdvObraDesde.SecondaryDataFields = "IDObra"
        Me.AdvObraDesde.Size = New System.Drawing.Size(105, 23)
        Me.AdvObraDesde.TabIndex = 0
        Me.AdvObraDesde.ViewName = "tbObraCabecera"
        '
        'lblObraHasta
        '
        Me.lblObraHasta.Location = New System.Drawing.Point(15, 53)
        Me.lblObraHasta.Name = "lblObraHasta"
        Me.lblObraHasta.Size = New System.Drawing.Size(93, 13)
        Me.lblObraHasta.TabIndex = 91
        Me.lblObraHasta.Tag = ""
        Me.lblObraHasta.Text = "Proyecto Hasta"
        '
        'AdvObraHasta
        '
        Me.AdvObraHasta.DisabledBackColor = System.Drawing.Color.White
        Me.AdvObraHasta.DisplayField = "NObra"
        Me.AdvObraHasta.EntityName = "ObraCabecera"
        Me.AdvObraHasta.Location = New System.Drawing.Point(114, 48)
        Me.AdvObraHasta.Name = "AdvObraHasta"
        Me.AdvObraHasta.SecondaryDataFields = "IDObra"
        Me.AdvObraHasta.Size = New System.Drawing.Size(105, 23)
        Me.AdvObraHasta.TabIndex = 1
        Me.AdvObraHasta.ViewName = "tbObraCabecera"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(392, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 13)
        Me.Label1.TabIndex = 93
        Me.Label1.Tag = "IdRec=5703;"
        Me.Label1.Text = "SubSubTipo Trabajo"
        '
        'AdvIDSubSubTipoTrabajo
        '
        Me.AdvIDSubSubTipoTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDSubSubTipoTrabajo.EntityName = "ObraSubSubtipoTrabajo"
        Me.AdvIDSubSubTipoTrabajo.Location = New System.Drawing.Point(526, 74)
        Me.AdvIDSubSubTipoTrabajo.Name = "AdvIDSubSubTipoTrabajo"
        Me.AdvIDSubSubTipoTrabajo.SecondaryDataFields = "IDSubSubtipoTrabajo"
        Me.AdvIDSubSubTipoTrabajo.Size = New System.Drawing.Size(92, 23)
        Me.AdvIDSubSubTipoTrabajo.TabIndex = 5
        '
        'CICopiaTipoTrabajo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(646, 357)
        Me.EntityName = "ObraCabecera"
        Me.KeyField = "IDObra;IDTipoObra;IDTipoTrabajo;CodTrabajo"
        Me.Name = "CICopiaTipoTrabajo"
        Me.UseCheck = True
        Me.ViewName = "vCICopiaTiposTrabajoSinEstablecer"
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

    Private Sub CICopiaTipoTrabajo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadParams()
        LoadToolBarActions()
        LoadGridActions()
    End Sub

    Private Sub LoadParams()
        If Not IsNothing(Me.Params) Then
            Dim HT As Hashtable = Me.Params
            AdvObraDesde.Value = HT("IDObra")
            AdvObraDesde.Text = HT("NObra")
            AdvObraHasta.Value = HT("IDObra")
            AdvObraHasta.Text = HT("NObra")

            Me.Execute()
        End If
    End Sub

    Private Sub LoadToolBarActions()
        Me.FormActions.Add("Generar Trabajos", AddressOf CopiaTiposTrabajo, ExpertisApp.GetIcon("xPrepExpediciones.ico"))
    End Sub

    Private Sub LoadGridActions()
        Me.Grid.Actions.Add("Abrir Proyecto", AddressOf AccionAbrirObra, ExpertisApp.GetIcon("xProyectos.ico"))
    End Sub

    Private Sub AccionAbrirObra()
        ExpertisApp.OpenForm("MGEO", New FilterItem("IDObra", FilterOperator.Equal, Grid.GetValue("IDObra")))
    End Sub

    Private Sub CopiaTiposTrabajo()
        If Grid.CheckedRecordsCount > 0 Then
            Dim dtMarcados As DataTable = Grid.CheckedRecords
            If Not IsNothing(dtMarcados) AndAlso dtMarcados.Rows.Count > 0 Then
                ExpertisApp.ExecuteTask(Of DataTable)(AddressOf ObraTrabajo.GenerarTrabajos, dtMarcados)
                If dtMarcados.Rows.Count > 1 Then
                    ExpertisApp.GenerateMessage("Se han generado | Trabajos.", MessageBoxButtons.OK, MessageBoxIcon.Information, dtMarcados.Rows.Count)
                Else
                    ExpertisApp.GenerateMessage("Se ha generado | Trabajo.", MessageBoxButtons.OK, MessageBoxIcon.Information, dtMarcados.Rows.Count)
                End If
                Grid.UnCheckAllRecords()
                Me.Execute()
            End If
        Else
            ExpertisApp.GenerateMessage("No se han seleccionado líneas.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub CICopiaTipoTrabajo_QueryExecuting(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        e.Filter.Add("IdObra", FilterOperator.GreaterThanOrEqual, AdvObraDesde.Value, FilterType.Numeric)
        e.Filter.Add("IdObra", FilterOperator.LessThanOrEqual, AdvObraHasta.Value, FilterType.Numeric)
        e.Filter.Add("IDTipoObra", FilterOperator.Equal, AdvIDTipoObra.Value, FilterType.String)
        e.Filter.Add("IDTipoTrabajo", FilterOperator.Equal, AdvIDTipoTrabajo.Value, FilterType.String)
        e.Filter.Add("IDSubTipoTrabajo", FilterOperator.Equal, AdvIDSubTipoTrabajo.Value, FilterType.String)
        e.Filter.Add("IDSubSubTipoTrabajo", FilterOperator.Equal, AdvIDSubSubTipoTrabajo.Value, FilterType.String)
    End Sub

End Class
