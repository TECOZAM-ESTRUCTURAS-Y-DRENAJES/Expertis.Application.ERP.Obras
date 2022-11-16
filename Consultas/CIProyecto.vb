Public Class CIProyecto
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
    Friend WithEvents PFiltros As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents PFCriterios As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents PFTotal As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents FCriterios As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents Grid As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents lblAño As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFacturado As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFacturado As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblObraHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advObraHasta As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblObraDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advObraDesde As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblCliente As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvIDCliente As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents txtTotalLineas As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents Ftotales As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents lblTotalLineas As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxAño As Solmicro.Expertis.Engine.UI.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim cbxAño_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxFacturado_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIProyecto))
        Me.PFiltros = New Solmicro.Expertis.Engine.UI.Panel
        Me.PFTotal = New Solmicro.Expertis.Engine.UI.Panel
        Me.Ftotales = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblTotalLineas = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTotalLineas = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.PFCriterios = New Solmicro.Expertis.Engine.UI.Panel
        Me.FCriterios = New Solmicro.Expertis.Engine.UI.Frame
        Me.cbxAño = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblFacturado = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFacturado = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblObraHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.advObraHasta = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblObraDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.advObraDesde = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblCliente = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDCliente = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblAño = New Solmicro.Expertis.Engine.UI.Label
        Me.Grid = New Solmicro.Expertis.Engine.UI.Grid
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        Me.PFiltros.suspendlayout()
        Me.PFTotal.suspendlayout()
        Me.Ftotales.SuspendLayout()
        Me.PFCriterios.suspendlayout()
        Me.FCriterios.SuspendLayout()
        CType(Me.cbxAño, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxFacturado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Toolbar
        '
        Me.Toolbar.Size = New System.Drawing.Size(298, 28)
        '
        'Menubar
        '
        Me.Menubar.Location = New System.Drawing.Point(0, 28)
        '
        'MainPanel
        '
        Me.MainPanel.Controls.Add(Me.Grid)
        Me.MainPanel.Controls.Add(Me.PFiltros)
        Me.MainPanel.Size = New System.Drawing.Size(736, 333)
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(736, 333)
        '
        'PFiltros
        '
        Me.PFiltros.Controls.Add(Me.PFTotal)
        Me.PFiltros.Controls.Add(Me.PFCriterios)
        Me.PFiltros.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PFiltros.Location = New System.Drawing.Point(0, 253)
        Me.PFiltros.Name = "PFiltros"
        Me.PFiltros.Size = New System.Drawing.Size(736, 80)
        Me.PFiltros.TabIndex = 0
        '
        'PFTotal
        '
        Me.PFTotal.Controls.Add(Me.Ftotales)
        Me.PFTotal.Dock = System.Windows.Forms.DockStyle.Right
        Me.PFTotal.Location = New System.Drawing.Point(576, 0)
        Me.PFTotal.Name = "PFTotal"
        Me.PFTotal.Size = New System.Drawing.Size(160, 80)
        Me.PFTotal.TabIndex = 1
        '
        'Ftotales
        '
        Me.Ftotales.Controls.Add(Me.lblTotalLineas)
        Me.Ftotales.Controls.Add(Me.txtTotalLineas)
        Me.Ftotales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Ftotales.Location = New System.Drawing.Point(0, 0)
        Me.Ftotales.Name = "Ftotales"
        Me.Ftotales.Size = New System.Drawing.Size(160, 80)
        Me.Ftotales.TabIndex = 0
        Me.Ftotales.TabStop = False
        '
        'lblTotalLineas
        '
        Me.lblTotalLineas.AutoSize = False
        Me.lblTotalLineas.Location = New System.Drawing.Point(16, 25)
        Me.lblTotalLineas.Name = "lblTotalLineas"
        Me.lblTotalLineas.Size = New System.Drawing.Size(128, 13)
        Me.lblTotalLineas.TabIndex = 23
        Me.lblTotalLineas.Text = "Imp. Total Proyectos"
        Me.lblTotalLineas.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtTotalLineas
        '
        Me.txtTotalLineas.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotalLineas.Enabled = False
        Me.txtTotalLineas.Location = New System.Drawing.Point(16, 43)
        Me.txtTotalLineas.Name = "txtTotalLineas"
        Me.txtTotalLineas.Size = New System.Drawing.Size(128, 21)
        Me.txtTotalLineas.TabIndex = 0
        '
        'PFCriterios
        '
        Me.PFCriterios.Controls.Add(Me.FCriterios)
        Me.PFCriterios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PFCriterios.Location = New System.Drawing.Point(0, 0)
        Me.PFCriterios.Name = "PFCriterios"
        Me.PFCriterios.Size = New System.Drawing.Size(736, 80)
        Me.PFCriterios.TabIndex = 0
        '
        'FCriterios
        '
        Me.FCriterios.Controls.Add(Me.cbxAño)
        Me.FCriterios.Controls.Add(Me.lblFacturado)
        Me.FCriterios.Controls.Add(Me.cbxFacturado)
        Me.FCriterios.Controls.Add(Me.lblObraHasta)
        Me.FCriterios.Controls.Add(Me.advObraHasta)
        Me.FCriterios.Controls.Add(Me.lblObraDesde)
        Me.FCriterios.Controls.Add(Me.advObraDesde)
        Me.FCriterios.Controls.Add(Me.lblCliente)
        Me.FCriterios.Controls.Add(Me.AdvIDCliente)
        Me.FCriterios.Controls.Add(Me.lblAño)
        Me.FCriterios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FCriterios.Location = New System.Drawing.Point(0, 0)
        Me.FCriterios.Name = "FCriterios"
        Me.FCriterios.Size = New System.Drawing.Size(736, 80)
        Me.FCriterios.TabIndex = 0
        Me.FCriterios.TabStop = False
        Me.FCriterios.Text = "Criterios de Selección"
        '
        'cbxAño
        '
        cbxAño_DesignTimeLayout.LayoutString = resources.GetString("cbxAño_DesignTimeLayout.LayoutString")
        Me.cbxAño.DesignTimeLayout = cbxAño_DesignTimeLayout
        Me.cbxAño.DisabledBackColor = System.Drawing.Color.White
        Me.cbxAño.DisplayMember = "Año"
        Me.cbxAño.Location = New System.Drawing.Point(488, 24)
        Me.cbxAño.MaxLength = 4
        Me.cbxAño.Name = "cbxAño"
        Me.cbxAño.SelectedIndex = -1
        Me.cbxAño.SelectedItem = Nothing
        Me.cbxAño.Size = New System.Drawing.Size(80, 21)
        Me.cbxAño.TabIndex = 28
        Me.cbxAño.ValueMember = "Año"
        '
        'lblFacturado
        '
        Me.lblFacturado.Location = New System.Drawing.Point(424, 51)
        Me.lblFacturado.Name = "lblFacturado"
        Me.lblFacturado.Size = New System.Drawing.Size(63, 13)
        Me.lblFacturado.TabIndex = 16
        Me.lblFacturado.Text = "Facturado"
        '
        'cbxFacturado
        '
        cbxFacturado_DesignTimeLayout.LayoutString = resources.GetString("cbxFacturado_DesignTimeLayout.LayoutString")
        Me.cbxFacturado.DesignTimeLayout = cbxFacturado_DesignTimeLayout
        Me.cbxFacturado.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFacturado.Location = New System.Drawing.Point(488, 51)
        Me.cbxFacturado.Name = "cbxFacturado"
        Me.cbxFacturado.SelectedIndex = -1
        Me.cbxFacturado.SelectedItem = Nothing
        Me.cbxFacturado.Size = New System.Drawing.Size(80, 21)
        Me.cbxFacturado.TabIndex = 21
        '
        'lblObraHasta
        '
        Me.lblObraHasta.Location = New System.Drawing.Point(222, 56)
        Me.lblObraHasta.Name = "lblObraHasta"
        Me.lblObraHasta.Size = New System.Drawing.Size(48, 13)
        Me.lblObraHasta.TabIndex = 24
        Me.lblObraHasta.Tag = ""
        Me.lblObraHasta.Text = "- Hasta"
        '
        'advObraHasta
        '
        Me.advObraHasta.DisabledBackColor = System.Drawing.Color.White
        Me.advObraHasta.DisplayField = "NObra"
        Me.advObraHasta.EntityName = "ObraCabecera"
        Me.advObraHasta.Location = New System.Drawing.Point(275, 51)
        Me.advObraHasta.Name = "advObraHasta"
        Me.advObraHasta.SecondaryDataFields = "IDObra"
        Me.advObraHasta.Size = New System.Drawing.Size(112, 23)
        Me.advObraHasta.TabIndex = 20
        '
        'lblObraDesde
        '
        Me.lblObraDesde.Location = New System.Drawing.Point(6, 56)
        Me.lblObraDesde.Name = "lblObraDesde"
        Me.lblObraDesde.Size = New System.Drawing.Size(97, 13)
        Me.lblObraDesde.TabIndex = 25
        Me.lblObraDesde.Tag = ""
        Me.lblObraDesde.Text = "Proyecto Desde"
        '
        'advObraDesde
        '
        Me.advObraDesde.DisabledBackColor = System.Drawing.Color.White
        Me.advObraDesde.DisplayField = "NObra"
        Me.advObraDesde.EntityName = "ObraCabecera"
        Me.advObraDesde.Location = New System.Drawing.Point(105, 51)
        Me.advObraDesde.Name = "advObraDesde"
        Me.advObraDesde.SecondaryDataFields = "IDObra"
        Me.advObraDesde.Size = New System.Drawing.Size(112, 23)
        Me.advObraDesde.TabIndex = 19
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(6, 28)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(47, 13)
        Me.lblCliente.TabIndex = 26
        Me.lblCliente.Tag = ""
        Me.lblCliente.Text = "Cliente"
        '
        'AdvIDCliente
        '
        Me.AdvIDCliente.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDCliente.EntityName = "Cliente"
        Me.AdvIDCliente.Location = New System.Drawing.Point(105, 24)
        Me.AdvIDCliente.Name = "AdvIDCliente"
        Me.AdvIDCliente.SecondaryDataFields = "IDCliente"
        Me.AdvIDCliente.Size = New System.Drawing.Size(112, 23)
        Me.AdvIDCliente.TabIndex = 15
        '
        'lblAño
        '
        Me.lblAño.Location = New System.Drawing.Point(424, 28)
        Me.lblAño.Name = "lblAño"
        Me.lblAño.Size = New System.Drawing.Size(29, 13)
        Me.lblAño.TabIndex = 1
        Me.lblAño.Text = "Año"
        '
        'Grid
        '
        Me.Grid.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.Grid.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.Grid.EntityName = "ObraTrabajoFacturacion"
        Me.Grid.FrozenColumns = 5
        Me.Grid.Location = New System.Drawing.Point(0, 0)
        Me.Grid.Name = "Grid"
        Me.Grid.PrimaryDataFields = Nothing
        Me.Grid.SecondaryDataFields = Nothing
        Me.Grid.Size = New System.Drawing.Size(736, 253)
        Me.Grid.TabIndex = 1
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.ViewName = "vRptObraFacturacionPorEjercicio"
        '
        'CIProyecto
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(744, 421)
        Me.Name = "CIProyecto"
        Me.Text = "CIProyecto"
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        Me.PFiltros.ResumeLayout(False)
        Me.PFTotal.ResumeLayout(False)
        Me.Ftotales.ResumeLayout(False)
        Me.Ftotales.PerformLayout()
        Me.PFCriterios.ResumeLayout(False)
        Me.FCriterios.ResumeLayout(False)
        Me.FCriterios.PerformLayout()
        CType(Me.cbxAño, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxFacturado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Const cnABRIRCLIENTE As String = "Abrir Cliente"

    Private Sub CIProyecto_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RellenarComboAños(cbxAño)
        cbxAño.Text = Year(Date.Today)
        cbxFacturado.DataSource = New EnumData("enumBoolean")
        cbxFacturado.Value = enumBoolean.Todos
        Me.CIPrimaryObject = Grid
        Me.Grid.Actions.Add(cnABRIRCLIENTE, AddressOf AccionAbrirCliente, ExpertisApp.GetIcon("xClientes.ico"))
    End Sub

    Private Sub AccionAbrirCliente()
        ExpertisApp.OpenForm("MCLIENTE", New FilterItem("IDCliente", FilterOperator.Equal, Grid.GetValue("IDCliente")))
    End Sub

    Private Sub Grid_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Grid.MouseUp
        If e.Button = MouseButtons.Right Then
            If Not IsNothing(Grid) AndAlso Grid.RowCount > 0 Then
                If Length(Grid.Value("IDCliente")) > 0 Then
                    Grid.UiCommandManager1.Commands(cnABRIRCLIENTE).Visible = Janus.Windows.UI.InheritableBoolean.True
                Else
                    Grid.UiCommandManager1.Commands(cnABRIRCLIENTE).Visible = Janus.Windows.UI.InheritableBoolean.False
                End If
            End If
        End If
    End Sub


    Private Sub CIProyecto_QueryExecuted(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutedEventArgs) Handles MyBase.QueryExecuted
        txtTotalLineas.Value = Grid.GetTotal(Grid.Columns("Saldo"), AggregateFunction.Sum)
    End Sub

    Private Sub CIProyecto_QueryExecuting(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        e.Filter.Add("IdCliente", FilterOperator.Equal, AdvIDCliente.Value)
        e.Filter.Add("IdObra", FilterOperator.GreaterThanOrEqual, advObraDesde.Value)
        e.Filter.Add("IdObra", FilterOperator.LessThanOrEqual, advObraHasta.Value)
        e.Filter.Add("Año", FilterOperator.Equal, cbxAño.Text)
        Select Case CInt(cbxFacturado.Value)
            Case enumBoolean.Si
                e.Filter.Add("Facturado", FilterOperator.Equal, True)
            Case enumBoolean.No
                e.Filter.Add("Facturado", FilterOperator.Equal, False)
        End Select
    End Sub

    Private Sub CIProyecto_FilterCleared(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.FilterCleared
        Me.AdvIDCliente.Text = String.Empty : Me.AdvIDCliente.Value = Nothing
        Me.advObraDesde.Text = String.Empty : Me.advObraDesde.Value = Nothing
        Me.advObraHasta.Text = String.Empty : Me.advObraHasta.Value = Nothing
    End Sub


    Private Sub CIProyecto_SetReportSelectionCriteria(ByVal sender As Object, ByVal e As Engine.UI.ReportSelectionCriteriaEventArgs) Handles MyBase.SetReportSelectionCriteria
        If Length(advObraDesde.Value) > 0 Then
            e.Filter.Add("IDObra", FilterOperator.GreaterThanOrEqual, advObraDesde.Value)
        End If
        If Length(advObraHasta.Value) > 0 Then
            e.Filter.Add("IDObra", FilterOperator.LessThanOrEqual, advObraHasta.Value)
        End If
        If Length(AdvIDCliente.Value) > 0 Then
            e.Filter.Add("IDCliente", FilterOperator.Equal, AdvIDCliente.Value)
        End If
        If Length(cbxAño.Value) > 0 Then
            e.Filter.Add("Año", FilterOperator.Equal, cbxAño.Value)
        End If
    End Sub
End Class