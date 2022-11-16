Public Class CIVencimiento
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
    Friend WithEvents PPFilterCriterios As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents PTotal As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents FFiltros As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents FTotal As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents Grid As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents lblFwiIdResponsable As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblcFwiIdResponsable As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents FwiIdResponsable As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblFwiFechaDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents FwiFechaDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFwiFechaHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents FwiFechaHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFwiEstado As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents FwiEstado As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblFwiIDObra As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents FwiIDObra As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblFwiImporteTotal As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents FwiImporteTotal As Solmicro.Expertis.Engine.UI.NumericTextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim FwiIdResponsable_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim FwiEstado_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIVencimiento))
        Me.PFiltros = New Solmicro.Expertis.Engine.UI.Panel
        Me.PTotal = New Solmicro.Expertis.Engine.UI.Panel
        Me.FTotal = New Solmicro.Expertis.Engine.UI.Frame
        Me.FwiImporteTotal = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblFwiImporteTotal = New Solmicro.Expertis.Engine.UI.Label
        Me.PPFilterCriterios = New Solmicro.Expertis.Engine.UI.Panel
        Me.FFiltros = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblFwiIdResponsable = New Solmicro.Expertis.Engine.UI.Label
        Me.lblcFwiIdResponsable = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.FwiIdResponsable = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblFwiFechaDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.FwiFechaDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFwiFechaHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.FwiFechaHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFwiEstado = New Solmicro.Expertis.Engine.UI.Label
        Me.FwiEstado = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblFwiIDObra = New Solmicro.Expertis.Engine.UI.Label
        Me.FwiIDObra = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.Grid = New Solmicro.Expertis.Engine.UI.Grid
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        Me.PFiltros.suspendlayout()
        Me.PTotal.suspendlayout()
        Me.FTotal.SuspendLayout()
        Me.PPFilterCriterios.suspendlayout()
        Me.FFiltros.SuspendLayout()
        CType(Me.FwiIdResponsable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FwiEstado, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.MainPanel.Size = New System.Drawing.Size(704, 349)
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(704, 349)
        '
        'PFiltros
        '
        Me.PFiltros.Controls.Add(Me.PTotal)
        Me.PFiltros.Controls.Add(Me.PPFilterCriterios)
        Me.PFiltros.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PFiltros.Location = New System.Drawing.Point(0, 269)
        Me.PFiltros.Name = "PFiltros"
        Me.PFiltros.Size = New System.Drawing.Size(704, 80)
        Me.PFiltros.TabIndex = 0
        '
        'PTotal
        '
        Me.PTotal.Controls.Add(Me.FTotal)
        Me.PTotal.Dock = System.Windows.Forms.DockStyle.Right
        Me.PTotal.Location = New System.Drawing.Point(536, 0)
        Me.PTotal.Name = "PTotal"
        Me.PTotal.Size = New System.Drawing.Size(168, 80)
        Me.PTotal.TabIndex = 1
        '
        'FTotal
        '
        Me.FTotal.Controls.Add(Me.FwiImporteTotal)
        Me.FTotal.Controls.Add(Me.lblFwiImporteTotal)
        Me.FTotal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FTotal.Location = New System.Drawing.Point(0, 0)
        Me.FTotal.Name = "FTotal"
        Me.FTotal.Size = New System.Drawing.Size(168, 80)
        Me.FTotal.TabIndex = 0
        Me.FTotal.TabStop = False
        '
        'FwiImporteTotal
        '
        Me.FwiImporteTotal.DisabledBackColor = System.Drawing.Color.White
        Me.FwiImporteTotal.Enabled = False
        Me.FwiImporteTotal.Location = New System.Drawing.Point(32, 45)
        Me.FwiImporteTotal.Name = "FwiImporteTotal"
        Me.FwiImporteTotal.Size = New System.Drawing.Size(107, 21)
        Me.FwiImporteTotal.TabIndex = 21
        '
        'lblFwiImporteTotal
        '
        Me.lblFwiImporteTotal.Location = New System.Drawing.Point(40, 26)
        Me.lblFwiImporteTotal.Name = "lblFwiImporteTotal"
        Me.lblFwiImporteTotal.Size = New System.Drawing.Size(97, 13)
        Me.lblFwiImporteTotal.TabIndex = 22
        Me.lblFwiImporteTotal.Text = "Importe Total A"
        '
        'PPFilterCriterios
        '
        Me.PPFilterCriterios.Controls.Add(Me.FFiltros)
        Me.PPFilterCriterios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PPFilterCriterios.Location = New System.Drawing.Point(0, 0)
        Me.PPFilterCriterios.Name = "PPFilterCriterios"
        Me.PPFilterCriterios.Size = New System.Drawing.Size(704, 80)
        Me.PPFilterCriterios.TabIndex = 0
        '
        'FFiltros
        '
        Me.FFiltros.Controls.Add(Me.lblFwiIdResponsable)
        Me.FFiltros.Controls.Add(Me.lblcFwiIdResponsable)
        Me.FFiltros.Controls.Add(Me.FwiIdResponsable)
        Me.FFiltros.Controls.Add(Me.lblFwiFechaDesde)
        Me.FFiltros.Controls.Add(Me.FwiFechaDesde)
        Me.FFiltros.Controls.Add(Me.lblFwiFechaHasta)
        Me.FFiltros.Controls.Add(Me.FwiFechaHasta)
        Me.FFiltros.Controls.Add(Me.lblFwiEstado)
        Me.FFiltros.Controls.Add(Me.FwiEstado)
        Me.FFiltros.Controls.Add(Me.lblFwiIDObra)
        Me.FFiltros.Controls.Add(Me.FwiIDObra)
        Me.FFiltros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FFiltros.Location = New System.Drawing.Point(0, 0)
        Me.FFiltros.Name = "FFiltros"
        Me.FFiltros.Size = New System.Drawing.Size(704, 80)
        Me.FFiltros.TabIndex = 0
        Me.FFiltros.TabStop = False
        Me.FFiltros.Text = "Criterios de selección"
        '
        'lblFwiIdResponsable
        '
        Me.lblFwiIdResponsable.Location = New System.Drawing.Point(8, 27)
        Me.lblFwiIdResponsable.Name = "lblFwiIdResponsable"
        Me.lblFwiIdResponsable.Size = New System.Drawing.Size(79, 13)
        Me.lblFwiIdResponsable.TabIndex = 10
        Me.lblFwiIdResponsable.Text = "Responsable"
        '
        'lblcFwiIdResponsable
        '
        Me.TryDataBinding(lblcFwiIdResponsable, New System.Windows.Forms.Binding("Text", Me.FwiIdResponsable, "DescOperario", True))
        Me.lblcFwiIdResponsable.Location = New System.Drawing.Point(176, 24)
        Me.lblcFwiIdResponsable.Name = "lblcFwiIdResponsable"
        Me.lblcFwiIdResponsable.Size = New System.Drawing.Size(176, 21)
        Me.lblcFwiIdResponsable.TabIndex = 12
        '
        'FwiIdResponsable
        '
        FwiIdResponsable_DesignTimeLayout.LayoutString = resources.GetString("FwiIdResponsable_DesignTimeLayout.LayoutString")
        Me.FwiIdResponsable.DesignTimeLayout = FwiIdResponsable_DesignTimeLayout
        Me.FwiIdResponsable.DisabledBackColor = System.Drawing.Color.White
        Me.FwiIdResponsable.EntityName = "Operario"
        Me.FwiIdResponsable.Location = New System.Drawing.Point(88, 24)
        Me.FwiIdResponsable.Name = "FwiIdResponsable"
        Me.FwiIdResponsable.PrimaryDataFields = "IDOperario"
        Me.FwiIdResponsable.SecondaryDataFields = "IDOperario"
        Me.FwiIdResponsable.SelectedIndex = -1
        Me.FwiIdResponsable.SelectedItem = Nothing
        Me.FwiIdResponsable.Size = New System.Drawing.Size(80, 21)
        Me.FwiIdResponsable.TabIndex = 9
        Me.FwiIdResponsable.ViewName = "tbMaestroOperario"
        '
        'lblFwiFechaDesde
        '
        Me.lblFwiFechaDesde.Location = New System.Drawing.Point(366, 28)
        Me.lblFwiFechaDesde.Name = "lblFwiFechaDesde"
        Me.lblFwiFechaDesde.Size = New System.Drawing.Size(80, 13)
        Me.lblFwiFechaDesde.TabIndex = 14
        Me.lblFwiFechaDesde.Text = "Fecha Desde"
        '
        'FwiFechaDesde
        '
        Me.FwiFechaDesde.DisabledBackColor = System.Drawing.Color.White
        Me.FwiFechaDesde.Location = New System.Drawing.Point(448, 24)
        Me.FwiFechaDesde.Name = "FwiFechaDesde"
        Me.FwiFechaDesde.Size = New System.Drawing.Size(80, 21)
        Me.FwiFechaDesde.TabIndex = 15
        '
        'lblFwiFechaHasta
        '
        Me.lblFwiFechaHasta.Location = New System.Drawing.Point(368, 48)
        Me.lblFwiFechaHasta.Name = "lblFwiFechaHasta"
        Me.lblFwiFechaHasta.Size = New System.Drawing.Size(76, 13)
        Me.lblFwiFechaHasta.TabIndex = 16
        Me.lblFwiFechaHasta.Tag = "IdRec=4633;"
        Me.lblFwiFechaHasta.Text = "Fecha Hasta"
        '
        'FwiFechaHasta
        '
        Me.FwiFechaHasta.DisabledBackColor = System.Drawing.Color.White
        Me.FwiFechaHasta.Location = New System.Drawing.Point(448, 48)
        Me.FwiFechaHasta.Name = "FwiFechaHasta"
        Me.FwiFechaHasta.Size = New System.Drawing.Size(80, 21)
        Me.FwiFechaHasta.TabIndex = 17
        '
        'lblFwiEstado
        '
        Me.lblFwiEstado.Location = New System.Drawing.Point(8, 50)
        Me.lblFwiEstado.Name = "lblFwiEstado"
        Me.lblFwiEstado.Size = New System.Drawing.Size(45, 13)
        Me.lblFwiEstado.TabIndex = 18
        Me.lblFwiEstado.Tag = "IdRec=4405;"
        Me.lblFwiEstado.Text = "Estado"
        '
        'FwiEstado
        '
        FwiEstado_DesignTimeLayout.LayoutString = resources.GetString("FwiEstado_DesignTimeLayout.LayoutString")
        Me.FwiEstado.DesignTimeLayout = FwiEstado_DesignTimeLayout
        Me.FwiEstado.DisabledBackColor = System.Drawing.Color.White
        Me.FwiEstado.Location = New System.Drawing.Point(88, 48)
        Me.FwiEstado.Name = "FwiEstado"
        Me.FwiEstado.SelectedIndex = -1
        Me.FwiEstado.SelectedItem = Nothing
        Me.FwiEstado.Size = New System.Drawing.Size(80, 21)
        Me.FwiEstado.TabIndex = 11
        '
        'lblFwiIDObra
        '
        Me.lblFwiIDObra.Location = New System.Drawing.Point(195, 52)
        Me.lblFwiIDObra.Name = "lblFwiIDObra"
        Me.lblFwiIDObra.Size = New System.Drawing.Size(57, 13)
        Me.lblFwiIDObra.TabIndex = 19
        Me.lblFwiIDObra.Text = "Proyecto"
        '
        'FwiIDObra
        '
        Me.FwiIDObra.DisabledBackColor = System.Drawing.Color.White
        Me.FwiIDObra.DisplayField = "NObra"
        Me.FwiIDObra.EntityName = "ObraCabecera"
        Me.FwiIDObra.Location = New System.Drawing.Point(256, 48)
        Me.FwiIDObra.Name = "FwiIDObra"
        Me.FwiIDObra.SecondaryDataFields = "IDObra"
        Me.FwiIDObra.Size = New System.Drawing.Size(96, 23)
        Me.FwiIDObra.TabIndex = 13
        Me.FwiIDObra.ViewName = "tbObraCabecera"
        '
        'Grid
        '
        Me.Grid.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.Grid.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.Grid.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.Grid.EntityName = "ObraTrabajoFacturacion"
        Me.Grid.Location = New System.Drawing.Point(0, 0)
        Me.Grid.Name = "Grid"
        Me.Grid.PrimaryDataFields = Nothing
        Me.Grid.SecondaryDataFields = Nothing
        Me.Grid.Size = New System.Drawing.Size(704, 269)
        Me.Grid.TabIndex = 1
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.ViewName = "vRptObraConsultaVencimientos"
        '
        'CIVencimiento
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(712, 437)
        Me.Name = "CIVencimiento"
        Me.Text = "CIVencimiento"
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        Me.PFiltros.ResumeLayout(False)
        Me.PTotal.ResumeLayout(False)
        Me.FTotal.ResumeLayout(False)
        Me.FTotal.PerformLayout()
        Me.PPFilterCriterios.ResumeLayout(False)
        Me.FFiltros.ResumeLayout(False)
        Me.FFiltros.PerformLayout()
        CType(Me.FwiIdResponsable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FwiEstado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Const cnABRIRCLIENTE As String = "Abrir Cliente"

    Private Sub CIVencimiento_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FwiEstado.DataSource = New EnumData("enumotfEstadoCIVtos")
        FwiEstado.Value = CInt(enumotfEstadoCIVtos.otfvTodos)
        LoadGridActions()
        Me.CIPrimaryObject = Grid
    End Sub

    Private Sub LoadGridActions()
        Me.Grid.Actions.Add("Abrir Proyecto", AddressOf AccionAbrirObra, ExpertisApp.GetIcon("xProyectos.ico"))
        Me.Grid.Actions.Add(cnABRIRCLIENTE, AddressOf AccionAbrirCliente, ExpertisApp.GetIcon("xClientes.ico"))
    End Sub

#Region " Grid Actions "

    Private Sub AccionAbrirObra()
        ExpertisApp.OpenForm("MGEO", New FilterItem("IDObra", FilterOperator.Equal, Grid.GetValue("IDObra")))
    End Sub

    Private Sub AccionAbrirCliente()
        ExpertisApp.OpenForm("MCLIENTE", New FilterItem("IDCliente", FilterOperator.Equal, Grid.GetValue("IDCliente")))
    End Sub

#End Region

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

    Private Sub CIVencimiento_QueryExecuted(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutedEventArgs) Handles MyBase.QueryExecuted
        FwiImporteTotal.Value = Grid.GetTotal(Grid.Columns("ImpTotalA"), AggregateFunction.Sum)
    End Sub

    Private Sub CIVencimiento_QueryExecuting(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        e.Filter.Add("IDObra", FilterOperator.Equal, FwiIDObra.Value)
        e.Filter.Add("IdOperario", FilterOperator.Equal, FwiIdResponsable.Value)
        e.Filter.Add("FechaVencimiento", FilterOperator.GreaterThanOrEqual, FwiFechaDesde.Value)
        e.Filter.Add("FechaVencimiento", FilterOperator.LessThanOrEqual, FwiFechaHasta.Value)
        Select Case CInt(FwiEstado.Value)
            Case enumotfEstadoCIVtos.otfvFacturado
                e.Filter.Add("Facturado", FilterOperator.Equal, True)
            Case enumotfEstadoCIVtos.otfvNoFacturado
                e.Filter.Add("Facturado", FilterOperator.Equal, False)
        End Select
    End Sub

    Private Sub CIVencimiento_FilterCleared(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.FilterCleared
        Me.FwiIDObra.Text = String.Empty : Me.FwiIDObra.Value = Nothing
        Me.FwiIdResponsable.Text = String.Empty : Me.FwiIdResponsable.Value = Nothing
        Me.FwiFechaDesde.TextBox.Clear() : Me.FwiFechaDesde.Value = Nothing
        Me.FwiFechaHasta.TextBox.Clear() : Me.FwiFechaHasta.Value = Nothing
    End Sub

End Class