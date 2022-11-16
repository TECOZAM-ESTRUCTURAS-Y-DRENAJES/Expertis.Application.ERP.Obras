Imports Janus.Windows.GridEX
Public Class CIExpedicion
    Inherits Solmicro.Expertis.Engine.UI.CIMnto

    Private mLotes As LoteStockableUserDialog
    Private mSeries As NSerieStockableUserDialog

    Private Const cnABRIRCLIENTE As String = "Abrir Cliente"

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        mLotes = New LoteStockableUserDialog
        mLotes.Text = "EXPEDICIONES"
        mLotes.ClaseMovimiento = [Shared].ClaseMovimiento.Salida
        mLotes.DataSource = Grid
        mLotes.DataSchema.Cantidad = "CantidadMarca1"
        mLotes.DataSchema.IDArticulo = "IDMaterial"

        mSeries = New NSerieStockableUserDialog
        mSeries.Text = "EXPEDICIONES"
        mSeries.ClaseMovimiento = [Shared].ClaseMovimiento.Salida
        mSeries.DataSource = Grid
        mSeries.DataSchema.Cantidad = "CantidadMarca1"
        mSeries.UsarColumnaSeleccion = True
        mSeries.ValorPorDefectoSeleccionEstado = NSerie.ESTADO_VENDIDO
        mSeries.Filtro.Add(New BooleanFilterItem("Disponible", True))
        mSeries.ModoRecuentoSalidas = [Shared].ModoRecuentoSalidas.Bajas
        mSeries.DataSchema.IDArticulo = "IDMaterial"

        txtPendiente.Value = System.DBNull.Value
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
    Friend WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents lblObraDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblNSerie As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblLotes As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblCliente As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblAlmacen As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblPendiente As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblEstado As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxNSerie As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents cbxLotes As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents AdvIDCliente As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvIDArticulo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvIDAlmacen As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents cbxEstado As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents txtPendiente As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents AdvContador As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblContador As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblMaterial As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Icons As System.Windows.Forms.ImageList
    Friend WithEvents lblTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvObra As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvTrabajo As Solmicro.Expertis.Engine.UI.AdvSearch
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxNSerie_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIExpedicion))
        Dim cbxLotes_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxEstado_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.AdvContador = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblContador = New Solmicro.Expertis.Engine.UI.Label
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblNSerie = New Solmicro.Expertis.Engine.UI.Label
        Me.lblLotes = New Solmicro.Expertis.Engine.UI.Label
        Me.lblCliente = New Solmicro.Expertis.Engine.UI.Label
        Me.lblMaterial = New Solmicro.Expertis.Engine.UI.Label
        Me.lblAlmacen = New Solmicro.Expertis.Engine.UI.Label
        Me.lblPendiente = New Solmicro.Expertis.Engine.UI.Label
        Me.lblEstado = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxNSerie = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.cbxLotes = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.AdvIDCliente = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.AdvIDArticulo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.AdvIDAlmacen = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.cbxEstado = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblObraDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.lblTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvObra = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.AdvTrabajo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.txtPendiente = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.Icons = New System.Windows.Forms.ImageList(Me.components)
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        Me.Panel1.suspendlayout()
        CType(Me.cbxNSerie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxLotes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.txtPendiente)
        Me.FilterPanel.Controls.Add(Me.lblObraDesde)
        Me.FilterPanel.Controls.Add(Me.lblTrabajo)
        Me.FilterPanel.Controls.Add(Me.AdvObra)
        Me.FilterPanel.Controls.Add(Me.AdvTrabajo)
        Me.FilterPanel.Controls.Add(Me.lblNSerie)
        Me.FilterPanel.Controls.Add(Me.lblLotes)
        Me.FilterPanel.Controls.Add(Me.lblCliente)
        Me.FilterPanel.Controls.Add(Me.lblMaterial)
        Me.FilterPanel.Controls.Add(Me.lblAlmacen)
        Me.FilterPanel.Controls.Add(Me.lblPendiente)
        Me.FilterPanel.Controls.Add(Me.lblEstado)
        Me.FilterPanel.Controls.Add(Me.cbxNSerie)
        Me.FilterPanel.Controls.Add(Me.cbxLotes)
        Me.FilterPanel.Controls.Add(Me.AdvIDCliente)
        Me.FilterPanel.Controls.Add(Me.AdvIDArticulo)
        Me.FilterPanel.Controls.Add(Me.AdvIDAlmacen)
        Me.FilterPanel.Controls.Add(Me.cbxEstado)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 319)
        Me.FilterPanel.Size = New System.Drawing.Size(688, 102)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Location = New System.Drawing.Point(0, 32)
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(688, 287)
        '
        'Grid
        '
        Me.Grid.CheckFields = New Solmicro.Expertis.Engine.UI.CheckFields(New Solmicro.Expertis.Engine.UI.CheckField() {New Solmicro.Expertis.Engine.UI.CheckField("CantidadMarca1", "Cantidad", 0, "Pendiente")})
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EntityName = "ObraMaterial"
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Grid.FrozenColumns = 5
        Me.Grid.KeyField = "IDLineaMaterial"
        Me.Grid.Size = New System.Drawing.Size(688, 287)
        Me.Grid.TabIndex = 10
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.UseCheck = True
        Me.Grid.ViewName = "VFrmMntoExpedicionObras"
        '
        'CheckAll
        '
        Me.CheckAll.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        Me.CheckAll.Visible = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'UncheckAll
        '
        Me.UncheckAll.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        Me.UncheckAll.Visible = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'ShowAllCheckedItems
        '
        Me.ShowAllCheckedItems.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        Me.ShowAllCheckedItems.Visible = Janus.Windows.UI.InheritableBoolean.[True]
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
        Me.Toolbar.Size = New System.Drawing.Size(320, 28)
        '
        'Menubar
        '
        Me.Menubar.Location = New System.Drawing.Point(0, 28)
        '
        'MainPanel
        '
        Me.MainPanel.Controls.Add(Me.Panel1)
        Me.MainPanel.Size = New System.Drawing.Size(688, 421)
        Me.MainPanel.Controls.SetChildIndex(Me.Panel1, 0)
        Me.MainPanel.Controls.SetChildIndex(Me.FilterPanel, 0)
        Me.MainPanel.Controls.SetChildIndex(Me.CIMntoGridPanel, 0)
        '
        'ExecuteActions
        '
        Me.ExecuteActions.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(688, 421)
        '
        'AdvContador
        '
        Me.AdvContador.DisabledBackColor = System.Drawing.Color.White
        Me.AdvContador.EntityName = "EntidadContador"
        Me.AdvContador.Location = New System.Drawing.Point(75, 6)
        Me.AdvContador.Name = "AdvContador"
        Me.AdvContador.SecondaryDataFields = "IDContador"
        Me.AdvContador.Size = New System.Drawing.Size(94, 23)
        Me.AdvContador.TabIndex = 9
        Me.AdvContador.ViewName = "tbEntidadContador"
        '
        'lblContador
        '
        Me.lblContador.Location = New System.Drawing.Point(11, 6)
        Me.lblContador.Name = "lblContador"
        Me.lblContador.Size = New System.Drawing.Size(60, 13)
        Me.lblContador.TabIndex = 41
        Me.lblContador.Tag = "IdRec=4809;"
        Me.lblContador.Text = "Contador"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblContador)
        Me.Panel1.Controls.Add(Me.AdvContador)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(688, 32)
        Me.Panel1.TabIndex = 2
        '
        'lblNSerie
        '
        Me.lblNSerie.Location = New System.Drawing.Point(513, 78)
        Me.lblNSerie.Name = "lblNSerie"
        Me.lblNSerie.Size = New System.Drawing.Size(55, 13)
        Me.lblNSerie.TabIndex = 62
        Me.lblNSerie.Text = "Nº Serie"
        '
        'lblLotes
        '
        Me.lblLotes.Location = New System.Drawing.Point(513, 51)
        Me.lblLotes.Name = "lblLotes"
        Me.lblLotes.Size = New System.Drawing.Size(37, 13)
        Me.lblLotes.TabIndex = 63
        Me.lblLotes.Text = "Lotes"
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(254, 27)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(47, 13)
        Me.lblCliente.TabIndex = 66
        Me.lblCliente.Tag = "IdRec=4365;"
        Me.lblCliente.Text = "Cliente"
        '
        'lblMaterial
        '
        Me.lblMaterial.Location = New System.Drawing.Point(254, 52)
        Me.lblMaterial.Name = "lblMaterial"
        Me.lblMaterial.Size = New System.Drawing.Size(52, 13)
        Me.lblMaterial.TabIndex = 67
        Me.lblMaterial.Tag = ""
        Me.lblMaterial.Text = "Material"
        '
        'lblAlmacen
        '
        Me.lblAlmacen.Location = New System.Drawing.Point(254, 78)
        Me.lblAlmacen.Name = "lblAlmacen"
        Me.lblAlmacen.Size = New System.Drawing.Size(56, 13)
        Me.lblAlmacen.TabIndex = 71
        Me.lblAlmacen.Tag = "IdRec=4390;"
        Me.lblAlmacen.Text = "Almacén"
        '
        'lblPendiente
        '
        Me.lblPendiente.Location = New System.Drawing.Point(513, 26)
        Me.lblPendiente.Name = "lblPendiente"
        Me.lblPendiente.Size = New System.Drawing.Size(76, 13)
        Me.lblPendiente.TabIndex = 72
        Me.lblPendiente.Tag = "IdRec=5379;"
        Me.lblPendiente.Text = "Pendiente >"
        '
        'lblEstado
        '
        Me.lblEstado.Location = New System.Drawing.Point(8, 77)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(45, 13)
        Me.lblEstado.TabIndex = 73
        Me.lblEstado.Tag = "IdRec=4405;"
        Me.lblEstado.Text = "Estado"
        '
        'cbxNSerie
        '
        cbxNSerie_DesignTimeLayout.LayoutString = resources.GetString("cbxNSerie_DesignTimeLayout.LayoutString")
        Me.cbxNSerie.DesignTimeLayout = cbxNSerie_DesignTimeLayout
        Me.cbxNSerie.DisabledBackColor = System.Drawing.Color.White
        Me.cbxNSerie.Location = New System.Drawing.Point(593, 74)
        Me.cbxNSerie.Name = "cbxNSerie"
        Me.cbxNSerie.SelectedIndex = -1
        Me.cbxNSerie.SelectedItem = Nothing
        Me.cbxNSerie.Size = New System.Drawing.Size(90, 21)
        Me.cbxNSerie.TabIndex = 8
        '
        'cbxLotes
        '
        cbxLotes_DesignTimeLayout.LayoutString = resources.GetString("cbxLotes_DesignTimeLayout.LayoutString")
        Me.cbxLotes.DesignTimeLayout = cbxLotes_DesignTimeLayout
        Me.cbxLotes.DisabledBackColor = System.Drawing.Color.White
        Me.cbxLotes.Location = New System.Drawing.Point(593, 48)
        Me.cbxLotes.Name = "cbxLotes"
        Me.cbxLotes.SelectedIndex = -1
        Me.cbxLotes.SelectedItem = Nothing
        Me.cbxLotes.Size = New System.Drawing.Size(90, 21)
        Me.cbxLotes.TabIndex = 7
        '
        'AdvIDCliente
        '
        Me.AdvIDCliente.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDCliente.EntityName = "Cliente"
        Me.AdvIDCliente.Location = New System.Drawing.Point(316, 22)
        Me.AdvIDCliente.Name = "AdvIDCliente"
        Me.AdvIDCliente.SecondaryDataFields = "IDCliente"
        Me.AdvIDCliente.Size = New System.Drawing.Size(117, 23)
        Me.AdvIDCliente.TabIndex = 3
        Me.AdvIDCliente.ViewName = "tbMaestroCliente"
        '
        'AdvIDArticulo
        '
        Me.AdvIDArticulo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDArticulo.EntityName = "Articulo"
        Me.AdvIDArticulo.Location = New System.Drawing.Point(316, 48)
        Me.AdvIDArticulo.Name = "AdvIDArticulo"
        Me.AdvIDArticulo.SecondaryDataFields = "IDArticulo"
        Me.AdvIDArticulo.Size = New System.Drawing.Size(117, 23)
        Me.AdvIDArticulo.TabIndex = 4
        Me.AdvIDArticulo.ViewName = "tbMaestroArticulo"
        '
        'AdvIDAlmacen
        '
        Me.AdvIDAlmacen.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDAlmacen.EntityName = "Almacen"
        Me.AdvIDAlmacen.Location = New System.Drawing.Point(316, 74)
        Me.AdvIDAlmacen.Name = "AdvIDAlmacen"
        Me.AdvIDAlmacen.PrimaryDataFields = "IDAlmacen"
        Me.AdvIDAlmacen.SecondaryDataFields = "IDAlmacen"
        Me.AdvIDAlmacen.Size = New System.Drawing.Size(117, 23)
        Me.AdvIDAlmacen.TabIndex = 5
        Me.AdvIDAlmacen.ViewName = "tbMaestroAlmacen"
        '
        'cbxEstado
        '
        cbxEstado_DesignTimeLayout.LayoutString = resources.GetString("cbxEstado_DesignTimeLayout.LayoutString")
        Me.cbxEstado.DesignTimeLayout = cbxEstado_DesignTimeLayout
        Me.cbxEstado.DisabledBackColor = System.Drawing.Color.White
        Me.cbxEstado.Location = New System.Drawing.Point(70, 74)
        Me.cbxEstado.Name = "cbxEstado"
        Me.cbxEstado.SelectedIndex = -1
        Me.cbxEstado.SelectedItem = Nothing
        Me.cbxEstado.Size = New System.Drawing.Size(120, 21)
        Me.cbxEstado.TabIndex = 2
        '
        'lblObraDesde
        '
        Me.lblObraDesde.Location = New System.Drawing.Point(8, 26)
        Me.lblObraDesde.Name = "lblObraDesde"
        Me.lblObraDesde.Size = New System.Drawing.Size(57, 13)
        Me.lblObraDesde.TabIndex = 94
        Me.lblObraDesde.Tag = ""
        Me.lblObraDesde.Text = "Proyecto"
        '
        'lblTrabajo
        '
        Me.lblTrabajo.Location = New System.Drawing.Point(8, 52)
        Me.lblTrabajo.Name = "lblTrabajo"
        Me.lblTrabajo.Size = New System.Drawing.Size(51, 13)
        Me.lblTrabajo.TabIndex = 95
        Me.lblTrabajo.Tag = ""
        Me.lblTrabajo.Text = "Trabajo"
        '
        'AdvObra
        '
        Me.AdvObra.DisabledBackColor = System.Drawing.Color.White
        Me.AdvObra.DisplayField = "NObra"
        Me.AdvObra.EntityName = "ObraCabecera"
        Me.AdvObra.Location = New System.Drawing.Point(70, 22)
        Me.AdvObra.Name = "AdvObra"
        Me.AdvObra.SecondaryDataFields = "IDObra"
        Me.AdvObra.Size = New System.Drawing.Size(120, 23)
        Me.AdvObra.TabIndex = 0
        Me.AdvObra.ViewName = "tbObraCabecera"
        '
        'AdvTrabajo
        '
        Me.AdvTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvTrabajo.DisplayField = "CodTrabajo"
        Me.AdvTrabajo.EntityName = "ObraTrabajo"
        Me.AdvTrabajo.Location = New System.Drawing.Point(70, 48)
        Me.AdvTrabajo.Name = "AdvTrabajo"
        Me.AdvTrabajo.SecondaryDataFields = "IDTrabajo"
        Me.AdvTrabajo.Size = New System.Drawing.Size(120, 23)
        Me.AdvTrabajo.TabIndex = 1
        Me.AdvTrabajo.ViewName = "tbObraTrabajo"
        '
        'txtPendiente
        '
        Me.txtPendiente.DisabledBackColor = System.Drawing.Color.White
        Me.txtPendiente.Location = New System.Drawing.Point(593, 22)
        Me.txtPendiente.Name = "txtPendiente"
        Me.txtPendiente.NullBehavior = Janus.Windows.GridEX.NumericEditNullBehavior.AllowNull
        Me.txtPendiente.Size = New System.Drawing.Size(90, 21)
        Me.txtPendiente.TabIndex = 6
        '
        'Icons
        '
        Me.Icons.ImageStream = CType(resources.GetObject("Icons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Icons.TransparentColor = System.Drawing.Color.Transparent
        Me.Icons.Images.SetKeyName(0, "")
        Me.Icons.Images.SetKeyName(1, "")
        '
        'CIExpedicion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CheckFields = New Solmicro.Expertis.Engine.UI.CheckFields(New Solmicro.Expertis.Engine.UI.CheckField() {New Solmicro.Expertis.Engine.UI.CheckField("CantidadMarca1", "Cantidad", 0, "Pendiente")})
        Me.ClientSize = New System.Drawing.Size(696, 509)
        Me.EntityName = "ObraMaterial"
        Me.KeyField = "IDLineaMaterial"
        Me.Name = "CIExpedicion"
        Me.UseCheck = True
        Me.ViewName = "VFrmMntoExpedicionObras"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.cbxNSerie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxLotes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxEstado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Load "

    Private Sub CIExpedicion_CheckingRecord(ByVal sender As Object, ByVal e As Engine.UI.CheckingEventArgs) Handles Me.CheckingRecord
        If e.CheckState = CheckStates.UnChecked Then
            e.Cancel = Not ValidaBloqueos(e)
        End If
    End Sub

    Private Sub CIExpedicion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadEnums()
        LoadToolbarActions()
        InitFilterCriteria()
        LoadGridActions()
        LoadParams()
    End Sub

    Private Sub LoadEnums()
        cbxEstado.DataSource = New EnumData("enumomEstado")
        cbxNSerie.DataSource = New EnumData("enumBoolean")
        cbxLotes.DataSource = New EnumData("enumBoolean")
        EnumData.PopulateValueList("enumomEstado", Grid.Columns("Estado"))
        EnumData.PopulateValueList("enumomATipoFacturacionAlquiler", Grid.Columns("TipoFacturacion"))
        Grid.Columns("Estado").EditType = EditType.NoEdit
        Grid.Columns("TipoFacturacion").EditType = EditType.NoEdit
    End Sub

    Private Sub LoadToolbarActions()
        Me.FormActions.Add("Generar Albaranes", AddressOf Expedir, ExpertisApp.GetIcon("xAlbaranesVenta.ico"))
    End Sub

    Private Sub LoadGridActions()
        Me.Grid.Actions.Add("Abrir Proyecto", AddressOf AccionAbrirObra, ExpertisApp.GetIcon("xProyectos.ico"))
        Me.Grid.Actions.Add(cnABRIRCLIENTE, AddressOf AccionAbrirCliente, ExpertisApp.GetIcon("xClientes.ico"))
    End Sub

    Private Sub LoadParams()
        If Not IsNothing(Me.Params) Then
            Dim ht As Hashtable = Me.Params
            AdvObra.Value = ht("IDObra")
            AdvObra.Text = ht("NObra")
            AdvTrabajo.Value = ht("IDTrabajo")
            AdvTrabajo.Text = ht("CodTrabajo")

            Me.Execute()
        End If
    End Sub

    Private Sub AccionAbrirObra()
        ExpertisApp.OpenForm("MGEO", New FilterItem("IDObra", FilterOperator.Equal, Grid.GetValue("IDObra")))
    End Sub

    Private Sub AccionAbrirCliente()
        ExpertisApp.OpenForm("MCLIENTE", New FilterItem("IDCliente", FilterOperator.Equal, Grid.GetValue("IDCliente")))
    End Sub

    Private Sub InitFilterCriteria()
        txtPendiente.Value = 0
        cbxNSerie.Value = CInt(enumBoolean.Todos)
        cbxLotes.Value = CInt(enumBoolean.Todos)
    End Sub

#End Region

#Region " Toolbar Actions "

    Private Sub Expedir()
        If Grid.RowCount > 0 Then
            Dim selectedRows As DataTable = Me.CheckedRecords
            If selectedRows Is Nothing OrElse selectedRows.Rows.Count = 0 Then
                ExpertisApp.GenerateMessage("No hay líneas para actualizar.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim aExpedir(-1) As CrearAlbaranVentaInfo
                For Each selectedRow As DataRow In selectedRows.Rows

                    Dim datosExp As New CrearAlbaranVentaInfo
                    datosExp.IDLineaMaterial = selectedRow("IDLineaMaterial")
                    datosExp.Cantidad = selectedRow("CantidadMarca1")
                    datosExp.IDCliente = selectedRow("IDCliente")
                    If selectedRow("GestionStockPorLotes") Then
                        datosExp.Lotes = mLotes.LoteCollection.GetDataTable(selectedRow("IDLineaMaterial"))
                    ElseIf selectedRow("NSerieObligatorio") Then
                        datosExp.Series = mSeries.SerieCollection.GetDataTable(selectedRow("IDLineaMaterial"))
                    End If

                    ReDim Preserve aExpedir(UBound(aExpedir) + 1)
                    aExpedir(UBound(aExpedir)) = datosExp
                Next

                If ExpertisApp.GenerateMessage("Se va a proceder a la Generación de Albaranes de las líneas seleccionadas. ¿Desea continuar?.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Me.Cursor = Cursors.WaitCursor

                    Dim data As New DataPrcAlbaranar(aExpedir, AdvContador.Text, , , enumTipoExpedicion.teObra)
                    Dim log As AlbaranLogProcess = New BE.DataEngine().RunProcess(GetType(PrcAlbaranarObras), data)

                    Me.Cursor = Cursors.Default
                    TratarLog(log, enumTipoDocumentoCreado.AlbaranVenta, True, True)
                    Me.UnCheckAllRecords()
                    Me.RetrieveData()
                End If
                mLotes.LoteCollection.Clear()
                mSeries.SerieCollection.Clear()
            End If
        End If
    End Sub

#End Region

#Region " Grid "

    Private Sub Grid_EditingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles Grid.EditingCell
        Try
            If Grid.GetValue("GestionStockPorLotes") Then
                Grid.Columns("CantidadMarca1").ButtonDisplayMode = CellButtonDisplayMode.CurrentRow
                Grid.Columns("CantidadMarca1").ButtonStyle = ButtonStyle.Image
                Grid.Columns("CantidadMarca1").ButtonImage = Icons.Images(0)
            ElseIf Grid.GetValue("NSerieObligatorio") Then
                Grid.Columns("CantidadMarca1").ButtonDisplayMode = CellButtonDisplayMode.CurrentRow
                Grid.Columns("CantidadMarca1").ButtonStyle = ButtonStyle.Image
                Grid.Columns("CantidadMarca1").ButtonImage = Icons.Images(1)
            Else
                Grid.Columns("CantidadMarca1").ButtonStyle = Janus.Windows.GridEX.ButtonStyle.NoButton
            End If
            'If Grid.GetValue("EnvioCompleto") And e.Column.Key = "CantidadMarca1" Then
            '    e.Cancel = Grid.GetValue("EnvioCompleto")
            'End If
        Catch ex As Exception
            e.Cancel = True
        End Try
    End Sub

    Private Sub Grid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Grid.KeyDown
        If e.KeyCode = Keys.F4 And Not e.Shift Then
            If Grid.Col = Grid.Columns("CantidadMarca1").Position Then
                If Grid.GetValue("GestionStockPorLotes") Then
                    mLotes.ShowDialog(Grid.GetValue("IDLineaMaterial"))
                ElseIf Grid.GetValue("NSerieObligatorio") Then
                    If Length(Grid.GetValue("CantidadMarca1")) > 0 Then
                        If Grid.GetValue("CantidadMarca1") < 0 Then
                            mSeries.ValorPorDefectoSeleccionEstado = ERP.CommonClasses.NSerie.ESTADO_DISPONIBLE
                            mSeries.Filtro.Clear()
                            mSeries.Filtro.Add(New BooleanFilterItem("Baja", True))
                            mSeries.ModoRecuentoSalidas = [Shared].ModoRecuentoSalidas.Seleccionados
                            mSeries.UsarColumnaSeleccion = True
                            mSeries.FiltroPorAlmacen = False
                        ElseIf Grid.GetValue("CantidadMarca1") > 0 Then
                            mSeries.ValorPorDefectoSeleccionEstado = ERP.CommonClasses.NSerie.ESTADO_VENDIDO
                            mSeries.Filtro.Clear()
                            mSeries.Filtro.Add(New BooleanFilterItem("Disponible", True))
                            mSeries.ModoRecuentoSalidas = [Shared].ModoRecuentoSalidas.Bajas
                            mSeries.UsarColumnaSeleccion = True
                        End If
                        mSeries.ShowDialog(Grid.GetValue("IDLineaMaterial"))
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Grid_ColumnButtonClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles Grid.ColumnButtonClick
        If e.Column.Key = "CantidadMarca1" Then
            If Grid.GetValue("GestionStockPorLotes") Then
                mLotes.ShowDialog(Grid.GetValue("IDLineaMaterial"))
            ElseIf Grid.GetValue("NSerieObligatorio") Then
                If Length(Grid.GetValue("CantidadMarca1")) > 0 Then
                    If Grid.GetValue("CantidadMarca1") < 0 Then
                        mSeries.ValorPorDefectoSeleccionEstado = ERP.CommonClasses.NSerie.ESTADO_DISPONIBLE
                        mSeries.Filtro.Clear()
                        mSeries.Filtro.Add(New BooleanFilterItem("Baja", True))
                        mSeries.ModoRecuentoSalidas = [Shared].ModoRecuentoSalidas.Seleccionados
                        mSeries.UsarColumnaSeleccion = True
                        mSeries.FiltroPorAlmacen = False
                    ElseIf Grid.GetValue("CantidadMarca1") > 0 Then
                        mSeries.ValorPorDefectoSeleccionEstado = ERP.CommonClasses.NSerie.ESTADO_VENDIDO
                        mSeries.Filtro.Clear()
                        mSeries.Filtro.Add(New BooleanFilterItem("Disponible", True))
                        mSeries.ModoRecuentoSalidas = [Shared].ModoRecuentoSalidas.Bajas
                        mSeries.UsarColumnaSeleccion = True
                    End If
                    mSeries.ShowDialog(Grid.GetValue("IDLineaMaterial"))
                End If
            End If
        End If
    End Sub

    Private Sub Grid_UpdatingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles Grid.UpdatingCell
        Select Case e.Column.Key
            Case "CantidadMarca1"
                If Length(e.Value) = 0 Then e.Value = e.InitialValue
                Dim Cantidad As Double = e.Value
                Dim Pendiente As Double = Nz(Grid.GetValue("Pendiente"), 0)
                Dim StockFisico As Double = Nz(Grid.GetValue("StockFisico"), 0)

                If Grid.GetValue("GestionStockPorLotes") Then
                    If Cantidad > StockFisico Then
                        e.Cancel = True
                        ExpertisApp.GenerateMessage("No hay suficiente stock físico.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                Else
                    'pend: reparto de cantidades

                    'rcsAux = .DataSource.Clone
                    'strIDArticulo = .Value(.Columns("IDArticulo").Index)
                    'strIDCliente = .Value(.Columns("IDCliente").Index)
                    'strIDAlmacen = .Value(.Columns("IDAlmacen").Index)

                    'rcsAux.Filter = "(IDCliente='" & strIDCliente & "' AND IDArticulo='" & strIDArticulo & "' AND IDAlmacen='" & strIDAlmacen & "') OR (IDArticulo='" & strIDArticulo & "' AND IDAlmacen='" & strIDAlmacen & "' )"
                    'If rcsAux.RecordCount > 1 Then
                    '    If dblCantidad > dblPendiente Then
                    '        If MsgBox("La cantidad introducida excede la cantidad pendiente.", vbInformation Or vbYesNo) = vbYes Then  '12347
                    '            RepartirCantidadesExpedicion(dblCantidad)
                    '        End If
                    '    End If
                    'End If

                End If
        End Select
    End Sub

    Private Sub Grid_RecordChecked(ByVal sender As Object, ByVal e As Solmicro.Expertis.Engine.UI.CheckedEventArgs) Handles MyBase.RecordChecked
      If e.CheckState = CheckStates.UnChecked Then
            If e.Row.Cells("GestionStockPorLotes").Value Then
                mLotes.LoteCollection.RemoveAt(Grid.Value("IDLineaMaterial"))
            ElseIf e.Row.Cells("NSerieObligatorio").Value Then
                mSeries.SerieCollection.RemoveAt(Grid.Value("IDLineaMaterial"))
            End If
        End If
    End Sub

    Private Function ValidaBloqueos(ByVal e As Engine.UI.CheckingEventArgs) As Boolean
        Dim blnOK As Boolean = True
        If e.Row.Cells("ClienteBloqueado").Value Then
            blnOK = False
            ExpertisApp.GenerateMessage("El cliente | está Bloqueado para las Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, Quoted(e.Row.Cells("IDCliente").Value)) 'Cliente bloqueado para ventas
        End If
        If e.Row.Cells("ArtClieBloqueado").Value Then
            blnOK = False
            ExpertisApp.GenerateMessage("El artículo | está bloqueado para las Ventas para este Cliente.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, Quoted(e.Row.Cells("IDArticulo").Value)) 'Artículo bloqueado para ventas
        End If
        If e.Row.Cells("AlmacenBloqueado").Value Then
            blnOK = False
            ExpertisApp.GenerateMessage("El almacén | está Bloqueado para las Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, Quoted(e.Row.Cells("IDAlmacen").Value)) 'Almacén bloqueado para ventas
        End If
        Return blnOK
    End Function

    Private Sub Grid_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Grid.MouseUp
        If e.Button = MouseButtons.Right Then
            If Not IsNothing(Grid) AndAlso Grid.RowCount > 0 Then
                If Length(Grid.Value("IDCliente")) > 0 Then
                    Grid.UiCommandManager1.Commands(cnABRIRCLIENTE).Visible = InheritableBoolean.True
                Else
                    Grid.UiCommandManager1.Commands(cnABRIRCLIENTE).Visible = InheritableBoolean.False
                End If
            End If
        End If
    End Sub

#End Region

#Region " Execute Query "

    Private Sub CIExpedicion_QueryExecuting(ByVal sender As Object, ByRef e As Solmicro.Expertis.Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        e.Filter.Add("IDCliente", FilterOperator.Equal, AdvIDCliente.Text, FilterType.String)
        e.Filter.Add("IDMaterial", FilterOperator.Equal, AdvIDArticulo.Text, FilterType.String)
        e.Filter.Add("IDAlmacen", FilterOperator.Equal, AdvIDAlmacen.Text, FilterType.String)
        e.Filter.Add("IDObra", FilterOperator.Equal, AdvObra.Value, FilterType.Numeric)
        e.Filter.Add("IDTrabajo", FilterOperator.Equal, AdvTrabajo.Value, FilterType.Numeric)
        e.Filter.Add("Estado", FilterOperator.Equal, cbxEstado.Value, FilterType.Numeric)
        e.Filter.Add("Pendiente", FilterOperator.GreaterThan, txtPendiente.Value, FilterType.Numeric)
        If cbxLotes.Value <> enumBoolean.Todos Then
            e.Filter.Add("GestionStockPorLotes", FilterOperator.Equal, cbxLotes.Value, FilterType.Numeric)
        End If
        If cbxNSerie.Value <> enumBoolean.Todos Then
            e.Filter.Add("NSerieObligatorio", FilterOperator.Equal, cbxNSerie.Value, FilterType.Numeric)
        End If
    End Sub

    Protected Overrides Sub OnFilterClearing(ByVal e As System.EventArgs)
        MyBase.OnFilterClearing(e)
        InitFilterCriteria()
    End Sub
#End Region

    Private Sub AdvContador_SetPredefinedFilter(ByVal sender As Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles AdvContador.SetPredefinedFilter
        e.Filter.Add(New StringFilterItem("Entidad", GetType(AlbaranVentaCabecera).Name))
    End Sub

    Private Sub AdvIdAlmacen_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles AdvIDAlmacen.SetPredefinedFilter
        e.Filter.Add(New BooleanFilterItem("Activo", FilterOperator.Equal, True))
    End Sub

End Class
