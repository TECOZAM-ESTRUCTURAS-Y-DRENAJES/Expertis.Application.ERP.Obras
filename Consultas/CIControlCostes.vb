Public Class CIControlCostes
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
    Friend WithEvents lblObraDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblTipoTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblSubTipoTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvIDTipoTrabajo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvIDSubTipoTrabajo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvIDTrabajo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents Frame1 As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents rbtCapitulo As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents rbtTrabajo As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents pnlTop As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents lblObraVincular As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvObraVincular As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvIDObra As Solmicro.Expertis.Engine.UI.AdvSearch
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIControlCostes))
        Me.lblObraDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.lblTipoTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.lblSubTipoTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDObra = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.AdvIDTipoTrabajo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.AdvIDSubTipoTrabajo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDTrabajo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.Frame1 = New Solmicro.Expertis.Engine.UI.Frame
        Me.rbtTrabajo = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.rbtCapitulo = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.pnlTop = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblObraVincular = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvObraVincular = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        Me.Frame1.SuspendLayout()
        Me.pnlTop.suspendlayout()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.Frame1)
        Me.FilterPanel.Controls.Add(Me.lblTrabajo)
        Me.FilterPanel.Controls.Add(Me.AdvIDTrabajo)
        Me.FilterPanel.Controls.Add(Me.lblObraDesde)
        Me.FilterPanel.Controls.Add(Me.lblTipoTrabajo)
        Me.FilterPanel.Controls.Add(Me.lblSubTipoTrabajo)
        Me.FilterPanel.Controls.Add(Me.AdvIDObra)
        Me.FilterPanel.Controls.Add(Me.AdvIDTipoTrabajo)
        Me.FilterPanel.Controls.Add(Me.AdvIDSubTipoTrabajo)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 286)
        Me.FilterPanel.Size = New System.Drawing.Size(616, 80)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Controls.Add(Me.pnlTop)
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(616, 286)
        Me.CIMntoGridPanel.Controls.SetChildIndex(Me.pnlTop, 0)
        Me.CIMntoGridPanel.Controls.SetChildIndex(Me.Grid, 0)
        '
        'Grid
        '
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.Grid.EntityName = "ObraTrabajo"
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Grid.FrozenColumns = 2
        Me.Grid.KeyField = "IDTrabajo"
        Me.Grid.Location = New System.Drawing.Point(0, 32)
        Me.Grid.PrimaryDataFields = "IDTrabajo"
        Me.Grid.SecondaryDataFields = "IDTrabajoPadre"
        Me.Grid.Size = New System.Drawing.Size(616, 254)
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.UseCheck = True
        Me.Grid.ViewName = "vCIObrasControlCostes"
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
        Me.MainPanel.Size = New System.Drawing.Size(616, 366)
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(616, 366)
        '
        'lblObraDesde
        '
        Me.lblObraDesde.Location = New System.Drawing.Point(19, 24)
        Me.lblObraDesde.Name = "lblObraDesde"
        Me.lblObraDesde.Size = New System.Drawing.Size(57, 13)
        Me.lblObraDesde.TabIndex = 98
        Me.lblObraDesde.Tag = ""
        Me.lblObraDesde.Text = "Proyecto"
        '
        'lblTipoTrabajo
        '
        Me.lblTipoTrabajo.Location = New System.Drawing.Point(200, 24)
        Me.lblTipoTrabajo.Name = "lblTipoTrabajo"
        Me.lblTipoTrabajo.Size = New System.Drawing.Size(79, 13)
        Me.lblTipoTrabajo.TabIndex = 96
        Me.lblTipoTrabajo.Tag = "IdRec=5702;"
        Me.lblTipoTrabajo.Text = "Tipo Trabajo"
        '
        'lblSubTipoTrabajo
        '
        Me.lblSubTipoTrabajo.Location = New System.Drawing.Point(200, 50)
        Me.lblSubTipoTrabajo.Name = "lblSubTipoTrabajo"
        Me.lblSubTipoTrabajo.Size = New System.Drawing.Size(101, 13)
        Me.lblSubTipoTrabajo.TabIndex = 97
        Me.lblSubTipoTrabajo.Tag = "IdRec=5703;"
        Me.lblSubTipoTrabajo.Text = "SubTipo Trabajo"
        '
        'AdvIDObra
        '
        Me.AdvIDObra.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDObra.DisplayField = "NObra"
        Me.AdvIDObra.EntityName = "ObraCabecera"
        Me.AdvIDObra.Location = New System.Drawing.Point(80, 20)
        Me.AdvIDObra.Name = "AdvIDObra"
        Me.AdvIDObra.SecondaryDataFields = "IDObra"
        Me.AdvIDObra.Size = New System.Drawing.Size(105, 23)
        Me.AdvIDObra.TabIndex = 0
        Me.AdvIDObra.ViewName = "tbObraCabecera"
        '
        'AdvIDTipoTrabajo
        '
        Me.AdvIDTipoTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDTipoTrabajo.EntityName = "ObraTipoTrabajo"
        Me.AdvIDTipoTrabajo.Location = New System.Drawing.Point(304, 20)
        Me.AdvIDTipoTrabajo.Name = "AdvIDTipoTrabajo"
        Me.AdvIDTipoTrabajo.SecondaryDataFields = "IDTipoTrabajo"
        Me.AdvIDTipoTrabajo.Size = New System.Drawing.Size(92, 23)
        Me.AdvIDTipoTrabajo.TabIndex = 2
        Me.AdvIDTipoTrabajo.ViewName = "tbObraTipoTrabajo"
        '
        'AdvIDSubTipoTrabajo
        '
        Me.AdvIDSubTipoTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDSubTipoTrabajo.EntityName = "ObraSubtipoTrabajo"
        Me.AdvIDSubTipoTrabajo.Location = New System.Drawing.Point(304, 47)
        Me.AdvIDSubTipoTrabajo.Name = "AdvIDSubTipoTrabajo"
        Me.AdvIDSubTipoTrabajo.SecondaryDataFields = "IDSubtipoTrabajo"
        Me.AdvIDSubTipoTrabajo.Size = New System.Drawing.Size(92, 23)
        Me.AdvIDSubTipoTrabajo.TabIndex = 3
        Me.AdvIDSubTipoTrabajo.ViewName = "tbObraSubtipoTrabajo"
        '
        'lblTrabajo
        '
        Me.lblTrabajo.Location = New System.Drawing.Point(19, 50)
        Me.lblTrabajo.Name = "lblTrabajo"
        Me.lblTrabajo.Size = New System.Drawing.Size(51, 13)
        Me.lblTrabajo.TabIndex = 101
        Me.lblTrabajo.Tag = "IdRec=5280;"
        Me.lblTrabajo.Text = "Trabajo"
        '
        'AdvIDTrabajo
        '
        Me.AdvIDTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDTrabajo.DisplayField = "CodTrabajo"
        Me.AdvIDTrabajo.EntityName = "ObraTrabajo"
        Me.AdvIDTrabajo.Location = New System.Drawing.Point(80, 47)
        Me.AdvIDTrabajo.Name = "AdvIDTrabajo"
        Me.AdvIDTrabajo.SecondaryDataFields = "IDTrabajo"
        Me.AdvIDTrabajo.Size = New System.Drawing.Size(105, 23)
        Me.AdvIDTrabajo.TabIndex = 1
        Me.AdvIDTrabajo.ViewName = "tbObraTrabajo"
        '
        'Frame1
        '
        Me.Frame1.Controls.Add(Me.rbtTrabajo)
        Me.Frame1.Controls.Add(Me.rbtCapitulo)
        Me.Frame1.Location = New System.Drawing.Point(424, 19)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(176, 48)
        Me.Frame1.TabIndex = 4
        Me.Frame1.TabStop = False
        '
        'rbtTrabajo
        '
        Me.rbtTrabajo.Location = New System.Drawing.Point(96, 16)
        Me.rbtTrabajo.Name = "rbtTrabajo"
        Me.rbtTrabajo.Size = New System.Drawing.Size(72, 23)
        Me.rbtTrabajo.TabIndex = 1
        Me.rbtTrabajo.Text = "Trabajo"
        '
        'rbtCapitulo
        '
        Me.rbtCapitulo.Checked = True
        Me.rbtCapitulo.Location = New System.Drawing.Point(8, 16)
        Me.rbtCapitulo.Name = "rbtCapitulo"
        Me.rbtCapitulo.Size = New System.Drawing.Size(72, 23)
        Me.rbtCapitulo.TabIndex = 0
        Me.rbtCapitulo.TabStop = True
        Me.rbtCapitulo.Text = "Capítulo"
        '
        'pnlTop
        '
        Me.pnlTop.Controls.Add(Me.lblObraVincular)
        Me.pnlTop.Controls.Add(Me.AdvObraVincular)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(616, 32)
        Me.pnlTop.TabIndex = 1
        '
        'lblObraVincular
        '
        Me.lblObraVincular.Location = New System.Drawing.Point(10, 10)
        Me.lblObraVincular.Name = "lblObraVincular"
        Me.lblObraVincular.Size = New System.Drawing.Size(117, 13)
        Me.lblObraVincular.TabIndex = 101
        Me.lblObraVincular.Tag = ""
        Me.lblObraVincular.Text = "Proyecto a vincular"
        '
        'AdvObraVincular
        '
        Me.AdvObraVincular.DisabledBackColor = System.Drawing.Color.White
        Me.AdvObraVincular.DisplayField = "NObra"
        Me.AdvObraVincular.EntityName = "ObraCabecera"
        Me.AdvObraVincular.Location = New System.Drawing.Point(132, 5)
        Me.AdvObraVincular.Name = "AdvObraVincular"
        Me.AdvObraVincular.SecondaryDataFields = "IDObra"
        Me.AdvObraVincular.Size = New System.Drawing.Size(105, 23)
        Me.AdvObraVincular.TabIndex = 100
        Me.AdvObraVincular.ViewName = "tbObraCabecera"
        '
        'CIControlCostes
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(624, 454)
        Me.EntityName = "ObraTrabajo"
        Me.KeyField = "IDTrabajo"
        Me.Name = "CIControlCostes"
        Me.Text = "CIControlCostes"
        Me.UseCheck = True
        Me.ViewName = "vCIObrasControlCostes"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        Me.Frame1.ResumeLayout(False)
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Load "

    Private Sub CIControlCostes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadEnums()
        LoadToolbarActions()
    End Sub

    Private Sub LoadEnums()
        EnumData.PopulateValueList("enumTipoLineaTrabajo", Grid.Columns("TipoLinea"))
    End Sub

    Private Sub LoadToolbarActions()
        Me.FormActions.Add("Vincular Trabajos", AddressOf AccionAsignarAgrupacion, ExpertisApp.GetIcon("folder_add.ico"))
        Me.FormActions.Add("Desvincular Trabajos", AddressOf AccionBorrarAgrupacion, ExpertisApp.GetIcon("folder_delete.ico"))
    End Sub

#End Region

#Region " Toolbar Actions "

    Private Sub AccionAsignarAgrupacion()
        If Grid.CheckedRecordsCount > 0 Then
            If Length(AdvObraVincular.Value) > 0 Then
                Dim frm As New frmVincularTrabajo
                frm.IDObraVincular = AdvObraVincular.Value
                If frm.ShowDialog = DialogResult.OK Then
                    Dim datos As New ObraTrabajo.DatosTrabajosCliente(GetTrabajosMarcados, frm.infoConfig)
                    ExpertisApp.ExecuteTask(Of ObraTrabajo.DatosTrabajosCliente)(AddressOf ObraTrabajo.VincularTrabajoControlRelacionado, datos)

                    ExpertisApp.GenerateMessage("Proceso finalizado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.UnCheckAllRecords()
                    Me.Execute()
                End If
            Else
                ExpertisApp.GenerateMessage("Debe indicar la Obra a vincular.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            ExpertisApp.GenerateMessage("Debe seleccionar alguna fila.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Function GetTrabajosMarcados() As String()
        Dim dtMarcados As DataTable = Me.CheckedRecords
        Dim strIDTrabajos() As String : ReDim strIDTrabajos(-1)
        For Each dr As DataRow In dtMarcados.Rows
            ReDim Preserve strIDTrabajos(UBound(strIDTrabajos) + 1)
            strIDTrabajos(UBound(strIDTrabajos)) = dr("IDTrabajo")
        Next

        Return strIDTrabajos
    End Function

    Private Function GetTrabajosVinculados() As String()
        Dim dvMarcados As New DataView(Me.CheckedRecords.Copy)
        dvMarcados.RowFilter = New IsNullFilterItem("IDTrabajoControlRelacionado", False).Compose(New AdoFilterComposer)
        Dim strIDTrabajos() As String : ReDim strIDTrabajos(-1)
        If dvMarcados.Count > 0 Then
            For Each dr As DataRowView In dvMarcados
                ReDim Preserve strIDTrabajos(UBound(strIDTrabajos) + 1)
                strIDTrabajos(UBound(strIDTrabajos)) = dr("IDTrabajo")
            Next
        End If

        Return strIDTrabajos
    End Function

    Private Sub AccionBorrarAgrupacion()
        If Grid.CheckedRecordsCount > 0 Then
            Dim frm As New frmVincularTrabajo
            frm.DesVincular = True
            If frm.ShowDialog = DialogResult.OK Then
                Dim datos As New ObraTrabajo.DatosTrabajosCliente(GetTrabajosMarcados, frm.infoConfig)
                ExpertisApp.ExecuteTask(Of ObraTrabajo.DatosTrabajosCliente)(AddressOf ObraTrabajo.DesvincularTrabajoControlRelacionado, datos)

                ExpertisApp.GenerateMessage("Proceso finalizado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.UnCheckAllRecords()
                Me.Execute()
            End If
        Else
            ExpertisApp.GenerateMessage("Debe seleccionar alguna fila.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

#End Region

#Region " Execute Query "

    Private Sub CIControlCostes_QueryExecuting(ByVal sender As Object, ByRef e As Solmicro.Expertis.Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        If Length(AdvIDObra.Value) > 0 Then
            e.Filter.Add("IDObra", FilterOperator.Equal, AdvIDObra.Value, FilterType.Numeric)
            e.Filter.Add("IDTipoTrabajo", FilterOperator.Equal, AdvIDTipoTrabajo.Value, FilterType.String)
            e.Filter.Add("IDSubTipoTrabajo", FilterOperator.Equal, AdvIDSubTipoTrabajo.Value, FilterType.String)
            e.Filter.Add("IDTrabajo", FilterOperator.Equal, AdvIDTrabajo.Value, FilterType.Numeric)
            If rbtCapitulo.Checked Then
                e.Filter.Add("TipoLinea", FilterOperator.Equal, enumTipoLineaTrabajo.tltCapitulo, FilterType.Numeric)
            Else
                e.Filter.Add("TipoLinea", FilterOperator.Equal, enumTipoLineaTrabajo.tltTrabajo, FilterType.Numeric)
            End If
        Else
            e.Cancel = True
            ExpertisApp.GenerateMessage("Debe filtrar por un Proyecto.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

#End Region

    Private Sub Grid_EditingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles Grid.EditingCell
        If e.Column.Key = "TipoLinea" Then e.Cancel = True
    End Sub

    Private Sub AdvObraVincular_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles AdvObraVincular.SetPredefinedFilter
        e.Filter.Add(New NumberFilterItem("IDClase", enumClaseObra.Control))
    End Sub
    
End Class
