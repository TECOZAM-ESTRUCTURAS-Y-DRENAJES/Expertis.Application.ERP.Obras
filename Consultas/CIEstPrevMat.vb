Public Class CIEstPrevMat
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
    Friend WithEvents AdvFactura As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblFactura As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents CmbEstadoObra As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents LblEstadoObra As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvSubTipoTrabajo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblFechaFactHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFechaFactDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblObraHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblObraDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblSubTipoTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblTipoTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaFactHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents cbxFechaFactDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents AdvObraHasta As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvObraDesde As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvTipoTrabajo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvIDFamilia As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvIDProveedor As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvIDTipo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvIDSubFamilia As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblMaterial As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvIDMaterial As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents pnlTotal As System.Windows.Forms.Panel
    Friend WithEvents lblTotalReal As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtTotalReal As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblProveedor As Solmicro.Expertis.Engine.UI.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim CmbEstadoObra_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIEstPrevMat))
        Me.AdvFactura = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblFactura = New Solmicro.Expertis.Engine.UI.Label
        Me.CmbEstadoObra = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.LblEstadoObra = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvSubTipoTrabajo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblFechaFactHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFechaFactDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.lblObraHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.lblObraDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.lblSubTipoTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.lblTipoTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaFactHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.cbxFechaFactDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.AdvObraHasta = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.AdvObraDesde = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.AdvTipoTrabajo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.AdvIDFamilia = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.AdvIDProveedor = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.AdvIDTipo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.AdvIDSubFamilia = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblMaterial = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDMaterial = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblProveedor = New Solmicro.Expertis.Engine.UI.Label
        Me.pnlTotal = New System.Windows.Forms.Panel
        Me.lblTotalReal = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTotalReal = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        CType(Me.CmbEstadoObra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTotal.SuspendLayout()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.AdvIDFamilia)
        Me.FilterPanel.Controls.Add(Me.AdvIDProveedor)
        Me.FilterPanel.Controls.Add(Me.AdvIDTipo)
        Me.FilterPanel.Controls.Add(Me.AdvIDSubFamilia)
        Me.FilterPanel.Controls.Add(Me.lblMaterial)
        Me.FilterPanel.Controls.Add(Me.AdvIDMaterial)
        Me.FilterPanel.Controls.Add(Me.lblProveedor)
        Me.FilterPanel.Controls.Add(Me.AdvFactura)
        Me.FilterPanel.Controls.Add(Me.lblFactura)
        Me.FilterPanel.Controls.Add(Me.CmbEstadoObra)
        Me.FilterPanel.Controls.Add(Me.LblEstadoObra)
        Me.FilterPanel.Controls.Add(Me.AdvSubTipoTrabajo)
        Me.FilterPanel.Controls.Add(Me.lblFechaFactHasta)
        Me.FilterPanel.Controls.Add(Me.lblFechaFactDesde)
        Me.FilterPanel.Controls.Add(Me.lblObraHasta)
        Me.FilterPanel.Controls.Add(Me.lblObraDesde)
        Me.FilterPanel.Controls.Add(Me.lblSubTipoTrabajo)
        Me.FilterPanel.Controls.Add(Me.lblTipoTrabajo)
        Me.FilterPanel.Controls.Add(Me.cbxFechaFactHasta)
        Me.FilterPanel.Controls.Add(Me.cbxFechaFactDesde)
        Me.FilterPanel.Controls.Add(Me.AdvObraHasta)
        Me.FilterPanel.Controls.Add(Me.AdvObraDesde)
        Me.FilterPanel.Controls.Add(Me.AdvTipoTrabajo)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 237)
        Me.FilterPanel.Size = New System.Drawing.Size(613, 128)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(613, 203)
        '
        'Grid
        '
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EntityName = "ObraMaterialControl"
        Me.Grid.Size = New System.Drawing.Size(613, 203)
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.ViewName = "vEstaditicasObrasPrevistoRealMaterial"
        '
        'Toolbar
        '
        Me.Toolbar.Size = New System.Drawing.Size(245, 28)
        '
        'Menubar
        '
        Me.Menubar.Location = New System.Drawing.Point(0, 28)
        '
        'MainPanel
        '
        Me.MainPanel.Controls.Add(Me.pnlTotal)
        Me.MainPanel.Size = New System.Drawing.Size(613, 365)
        Me.MainPanel.Controls.SetChildIndex(Me.FilterPanel, 0)
        Me.MainPanel.Controls.SetChildIndex(Me.pnlTotal, 0)
        Me.MainPanel.Controls.SetChildIndex(Me.CIMntoGridPanel, 0)
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(613, 365)
        '
        'AdvFactura
        '
        Me.AdvFactura.DisabledBackColor = System.Drawing.Color.White
        Me.AdvFactura.DisplayField = "NFactura"
        Me.AdvFactura.EntityName = "FacturaCompraCabecera"
        Me.AdvFactura.Location = New System.Drawing.Point(294, 77)
        Me.AdvFactura.Name = "AdvFactura"
        Me.AdvFactura.SecondaryDataFields = "IDFactura"
        Me.AdvFactura.Size = New System.Drawing.Size(100, 23)
        Me.AdvFactura.TabIndex = 155
        Me.AdvFactura.ViewName = "tbFacturaCompraCabecera"
        '
        'lblFactura
        '
        Me.lblFactura.Location = New System.Drawing.Point(234, 82)
        Me.lblFactura.Name = "lblFactura"
        Me.lblFactura.Size = New System.Drawing.Size(49, 13)
        Me.lblFactura.TabIndex = 156
        Me.lblFactura.Text = "Factura"
        '
        'CmbEstadoObra
        '
        CmbEstadoObra_DesignTimeLayout.LayoutString = resources.GetString("CmbEstadoObra_DesignTimeLayout.LayoutString")
        Me.CmbEstadoObra.DesignTimeLayout = CmbEstadoObra_DesignTimeLayout
        Me.CmbEstadoObra.DisabledBackColor = System.Drawing.Color.White
        Me.CmbEstadoObra.DisplayMember = "Text"
        Me.CmbEstadoObra.Location = New System.Drawing.Point(106, 77)
        Me.CmbEstadoObra.Name = "CmbEstadoObra"
        Me.CmbEstadoObra.SelectedIndex = -1
        Me.CmbEstadoObra.SelectedItem = Nothing
        Me.CmbEstadoObra.Size = New System.Drawing.Size(100, 21)
        Me.CmbEstadoObra.TabIndex = 135
        Me.CmbEstadoObra.ValueMember = "Value"
        '
        'LblEstadoObra
        '
        Me.LblEstadoObra.Location = New System.Drawing.Point(8, 81)
        Me.LblEstadoObra.Name = "LblEstadoObra"
        Me.LblEstadoObra.Size = New System.Drawing.Size(99, 13)
        Me.LblEstadoObra.TabIndex = 150
        Me.LblEstadoObra.Text = "Estado Proyecto"
        Me.LblEstadoObra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AdvSubTipoTrabajo
        '
        Me.AdvSubTipoTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvSubTipoTrabajo.EntityName = "ObraSubtipoTrabajo"
        Me.AdvSubTipoTrabajo.Location = New System.Drawing.Point(294, 50)
        Me.AdvSubTipoTrabajo.Name = "AdvSubTipoTrabajo"
        Me.AdvSubTipoTrabajo.PrimaryDataFields = "IDSubtipoTrabajo"
        Me.AdvSubTipoTrabajo.SecondaryDataFields = "IDSubtipoTrabajo"
        Me.AdvSubTipoTrabajo.Size = New System.Drawing.Size(100, 23)
        Me.AdvSubTipoTrabajo.TabIndex = 138
        Me.AdvSubTipoTrabajo.ViewName = "tbObraSubtipoTrabajo"
        '
        'lblFechaFactHasta
        '
        Me.lblFechaFactHasta.Location = New System.Drawing.Point(417, 53)
        Me.lblFechaFactHasta.Name = "lblFechaFactHasta"
        Me.lblFechaFactHasta.Size = New System.Drawing.Size(84, 13)
        Me.lblFechaFactHasta.TabIndex = 141
        Me.lblFechaFactHasta.Tag = ""
        Me.lblFechaFactHasta.Text = "F. Fact. Hasta"
        '
        'lblFechaFactDesde
        '
        Me.lblFechaFactDesde.Location = New System.Drawing.Point(417, 29)
        Me.lblFechaFactDesde.Name = "lblFechaFactDesde"
        Me.lblFechaFactDesde.Size = New System.Drawing.Size(88, 13)
        Me.lblFechaFactDesde.TabIndex = 142
        Me.lblFechaFactDesde.Tag = ""
        Me.lblFechaFactDesde.Text = "F. Fact. Desde"
        '
        'lblObraHasta
        '
        Me.lblObraHasta.Location = New System.Drawing.Point(8, 55)
        Me.lblObraHasta.Name = "lblObraHasta"
        Me.lblObraHasta.Size = New System.Drawing.Size(93, 13)
        Me.lblObraHasta.TabIndex = 143
        Me.lblObraHasta.Tag = ""
        Me.lblObraHasta.Text = "Proyecto Hasta"
        '
        'lblObraDesde
        '
        Me.lblObraDesde.Location = New System.Drawing.Point(8, 28)
        Me.lblObraDesde.Name = "lblObraDesde"
        Me.lblObraDesde.Size = New System.Drawing.Size(97, 13)
        Me.lblObraDesde.TabIndex = 144
        Me.lblObraDesde.Tag = ""
        Me.lblObraDesde.Text = "Proyecto Desde"
        '
        'lblSubTipoTrabajo
        '
        Me.lblSubTipoTrabajo.Location = New System.Drawing.Point(234, 55)
        Me.lblSubTipoTrabajo.Name = "lblSubTipoTrabajo"
        Me.lblSubTipoTrabajo.Size = New System.Drawing.Size(50, 13)
        Me.lblSubTipoTrabajo.TabIndex = 146
        Me.lblSubTipoTrabajo.Text = "Subtipo"
        '
        'lblTipoTrabajo
        '
        Me.lblTipoTrabajo.Location = New System.Drawing.Point(234, 29)
        Me.lblTipoTrabajo.Name = "lblTipoTrabajo"
        Me.lblTipoTrabajo.Size = New System.Drawing.Size(35, 13)
        Me.lblTipoTrabajo.TabIndex = 148
        Me.lblTipoTrabajo.Text = "Tipo "
        '
        'cbxFechaFactHasta
        '
        Me.cbxFechaFactHasta.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaFactHasta.Location = New System.Drawing.Point(505, 50)
        Me.cbxFechaFactHasta.Name = "cbxFechaFactHasta"
        Me.cbxFechaFactHasta.Size = New System.Drawing.Size(100, 21)
        Me.cbxFechaFactHasta.TabIndex = 140
        '
        'cbxFechaFactDesde
        '
        Me.cbxFechaFactDesde.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaFactDesde.Location = New System.Drawing.Point(505, 25)
        Me.cbxFechaFactDesde.Name = "cbxFechaFactDesde"
        Me.cbxFechaFactDesde.Size = New System.Drawing.Size(100, 21)
        Me.cbxFechaFactDesde.TabIndex = 139
        '
        'AdvObraHasta
        '
        Me.AdvObraHasta.DisabledBackColor = System.Drawing.Color.White
        Me.AdvObraHasta.DisplayField = "NObra"
        Me.AdvObraHasta.EntityName = "ObraCabecera"
        Me.AdvObraHasta.Location = New System.Drawing.Point(106, 50)
        Me.AdvObraHasta.Name = "AdvObraHasta"
        Me.AdvObraHasta.PrimaryDataFields = "IDObra"
        Me.AdvObraHasta.SecondaryDataFields = "IDObra"
        Me.AdvObraHasta.Size = New System.Drawing.Size(100, 23)
        Me.AdvObraHasta.TabIndex = 133
        Me.AdvObraHasta.ViewName = "tbObraCabecera"
        '
        'AdvObraDesde
        '
        Me.AdvObraDesde.DisabledBackColor = System.Drawing.Color.White
        Me.AdvObraDesde.DisplayField = "NObra"
        Me.AdvObraDesde.EntityName = "ObraCabecera"
        Me.AdvObraDesde.Location = New System.Drawing.Point(106, 23)
        Me.AdvObraDesde.Name = "AdvObraDesde"
        Me.AdvObraDesde.PrimaryDataFields = "IDObra"
        Me.AdvObraDesde.SecondaryDataFields = "IDObra"
        Me.AdvObraDesde.Size = New System.Drawing.Size(100, 23)
        Me.AdvObraDesde.TabIndex = 132
        Me.AdvObraDesde.ViewName = "tbObraCabecera"
        '
        'AdvTipoTrabajo
        '
        Me.AdvTipoTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvTipoTrabajo.EntityName = "ObraTipoTrabajo"
        Me.AdvTipoTrabajo.Location = New System.Drawing.Point(294, 23)
        Me.AdvTipoTrabajo.Name = "AdvTipoTrabajo"
        Me.AdvTipoTrabajo.PrimaryDataFields = "IDTipoTrabajo"
        Me.AdvTipoTrabajo.SecondaryDataFields = "IDTipoTrabajo"
        Me.AdvTipoTrabajo.Size = New System.Drawing.Size(100, 23)
        Me.AdvTipoTrabajo.TabIndex = 137
        Me.AdvTipoTrabajo.ViewName = "tbObraTipoTrabajo"
        '
        'AdvIDFamilia
        '
        Me.AdvIDFamilia.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDFamilia.EntityName = "Familia"
        Me.AdvIDFamilia.Location = New System.Drawing.Point(273, 102)
        Me.AdvIDFamilia.Name = "AdvIDFamilia"
        Me.AdvIDFamilia.PrimaryDataFields = "IDFamilia"
        Me.AdvIDFamilia.SecondaryDataFields = "IDFamilia"
        Me.AdvIDFamilia.Size = New System.Drawing.Size(59, 23)
        Me.AdvIDFamilia.TabIndex = 160
        Me.AdvIDFamilia.ViewName = "tbMaestroFamilia"
        '
        'AdvIDProveedor
        '
        Me.AdvIDProveedor.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDProveedor.EntityName = "Proveedor"
        Me.AdvIDProveedor.Location = New System.Drawing.Point(505, 102)
        Me.AdvIDProveedor.Name = "AdvIDProveedor"
        Me.AdvIDProveedor.PrimaryDataFields = "IDProveedor"
        Me.AdvIDProveedor.SecondaryDataFields = "IDProveedor"
        Me.AdvIDProveedor.Size = New System.Drawing.Size(100, 23)
        Me.AdvIDProveedor.TabIndex = 162
        Me.AdvIDProveedor.ViewName = "tbMaestroProveedor"
        '
        'AdvIDTipo
        '
        Me.AdvIDTipo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDTipo.EntityName = "TipoArticulo"
        Me.AdvIDTipo.Location = New System.Drawing.Point(209, 102)
        Me.AdvIDTipo.Name = "AdvIDTipo"
        Me.AdvIDTipo.PrimaryDataFields = "IDCategoria"
        Me.AdvIDTipo.SecondaryDataFields = "IDTipo"
        Me.AdvIDTipo.Size = New System.Drawing.Size(61, 23)
        Me.AdvIDTipo.TabIndex = 159
        Me.AdvIDTipo.ViewName = "tbMaestroTipoArticulo"
        '
        'AdvIDSubFamilia
        '
        Me.AdvIDSubFamilia.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDSubFamilia.EntityName = "Subfamilia"
        Me.AdvIDSubFamilia.Location = New System.Drawing.Point(335, 102)
        Me.AdvIDSubFamilia.Name = "AdvIDSubFamilia"
        Me.AdvIDSubFamilia.PrimaryDataFields = "IDSubfamilia"
        Me.AdvIDSubFamilia.SecondaryDataFields = "IDSubfamilia"
        Me.AdvIDSubFamilia.Size = New System.Drawing.Size(59, 23)
        Me.AdvIDSubFamilia.TabIndex = 161
        Me.AdvIDSubFamilia.ViewName = "tbMaestroSubfamilia"
        '
        'lblMaterial
        '
        Me.lblMaterial.Location = New System.Drawing.Point(8, 107)
        Me.lblMaterial.Name = "lblMaterial"
        Me.lblMaterial.Size = New System.Drawing.Size(52, 13)
        Me.lblMaterial.TabIndex = 163
        Me.lblMaterial.Text = "Material"
        '
        'AdvIDMaterial
        '
        Me.AdvIDMaterial.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDMaterial.EntityName = "Articulo"
        Me.AdvIDMaterial.Location = New System.Drawing.Point(106, 102)
        Me.AdvIDMaterial.Name = "AdvIDMaterial"
        Me.AdvIDMaterial.PrimaryDataFields = "IDArticulo"
        Me.AdvIDMaterial.SecondaryDataFields = "IDArticulo"
        Me.AdvIDMaterial.Size = New System.Drawing.Size(100, 23)
        Me.AdvIDMaterial.TabIndex = 158
        Me.AdvIDMaterial.ViewName = "tbMaestroArticulo"
        '
        'lblProveedor
        '
        Me.lblProveedor.Location = New System.Drawing.Point(417, 107)
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Size = New System.Drawing.Size(66, 13)
        Me.lblProveedor.TabIndex = 164
        Me.lblProveedor.Text = "Proveedor"
        '
        'pnlTotal
        '
        Me.pnlTotal.Controls.Add(Me.lblTotalReal)
        Me.pnlTotal.Controls.Add(Me.txtTotalReal)
        Me.pnlTotal.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlTotal.Location = New System.Drawing.Point(0, 203)
        Me.pnlTotal.Name = "pnlTotal"
        Me.pnlTotal.Size = New System.Drawing.Size(613, 34)
        Me.pnlTotal.TabIndex = 161
        '
        'lblTotalReal
        '
        Me.lblTotalReal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalReal.AutoSize = False
        Me.lblTotalReal.Location = New System.Drawing.Point(340, 9)
        Me.lblTotalReal.Name = "lblTotalReal"
        Me.lblTotalReal.Size = New System.Drawing.Size(98, 17)
        Me.lblTotalReal.TabIndex = 105
        Me.lblTotalReal.Text = "Total Real"
        Me.lblTotalReal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTotalReal
        '
        Me.txtTotalReal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalReal.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotalReal.Enabled = False
        Me.txtTotalReal.Location = New System.Drawing.Point(441, 7)
        Me.txtTotalReal.Name = "txtTotalReal"
        Me.txtTotalReal.Size = New System.Drawing.Size(163, 21)
        Me.txtTotalReal.TabIndex = 104
        Me.txtTotalReal.TabStop = False
        '
        'CIEstPrevMat
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(621, 453)
        Me.EntityName = "ObraMaterialControl"
        Me.Name = "CIEstPrevMat"
        Me.Text = "CIEstPrevMat"
        Me.ViewName = "vEstaditicasObrasPrevistoRealMaterial"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        CType(Me.CmbEstadoObra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTotal.ResumeLayout(False)
        Me.pnlTotal.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Load "

    Private Sub CIEstPrevMat_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadEnums()
        LoadGridActions()
    End Sub

    Private Sub LoadEnums()
        CmbEstadoObra.DataSource = EnumData.EnumView("enumocEstado")
    End Sub

    Private Sub LoadGridActions()
        Grid.Actions.Add("Abrir Factura Compra", AddressOf VerFacturasCompra, ExpertisApp.GetIcon("xFacturaCompra.ico"))
    End Sub

#End Region

#Region " Grid Actions "

    Private Sub VerFacturasCompra()
        AbrirMntoFacturaCompra(Grid.Value("IDFactura"))
    End Sub

#End Region

#Region " Query Execute "

    Private Sub CIEstPrevMat_QueryExecuting(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        e.Filter.Add("IDObra", FilterOperator.GreaterThanOrEqual, AdvObraDesde.Value, FilterType.Numeric)
        e.Filter.Add("IDObra", FilterOperator.LessThanOrEqual, AdvObraHasta.Value, FilterType.Numeric)
        e.Filter.Add("IDTipoTrabajo", FilterOperator.Equal, AdvTipoTrabajo.Value, FilterType.String)
        e.Filter.Add("IDSubTipoTrabajo", FilterOperator.Equal, AdvSubTipoTrabajo.Value, FilterType.String)
        e.Filter.Add("Estado", FilterOperator.Equal, CmbEstadoObra.Value, FilterType.Numeric)
        e.Filter.Add("FechaFactura", FilterOperator.GreaterThanOrEqual, cbxFechaFactDesde.Value, FilterType.DateTime)
        e.Filter.Add("FechaFactura", FilterOperator.LessThanOrEqual, cbxFechaFactHasta.Value, FilterType.DateTime)
        e.Filter.Add("IDFactura", FilterOperator.Equal, AdvFactura.Value, FilterType.Numeric)
        e.Filter.Add("IDMaterial", FilterOperator.Equal, AdvIDMaterial.Text, FilterType.String)
        e.Filter.Add("IDTipo", FilterOperator.Equal, AdvIDTipo.Text, FilterType.String)
        e.Filter.Add("IDFamilia", FilterOperator.Equal, AdvIDFamilia.Text, FilterType.String)
        e.Filter.Add("IDSubFamilia", FilterOperator.Equal, AdvIDSubFamilia.Text, FilterType.String)
        e.Filter.Add("IDProveedor", FilterOperator.Equal, AdvIDProveedor.Text, FilterType.String)
    End Sub

    Private Sub CIEstPrevMat_QueryExecuted(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutedEventArgs) Handles MyBase.QueryExecuted
        txtTotalReal.Value = Grid.GetTotal(Grid.Columns("ImpRealA"), AggregateFunction.Sum)
    End Sub

    Private Sub CIEstPrevMat_FilterClearing(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.FilterClearing
        AdvObraDesde.Value = System.DBNull.Value : AdvObraDesde.Text = String.Empty
        AdvObraHasta.Value = System.DBNull.Value : AdvObraHasta.Text = String.Empty
        AdvTipoTrabajo.Value = System.DBNull.Value : AdvTipoTrabajo.Text = String.Empty
        AdvSubTipoTrabajo.Value = System.DBNull.Value : AdvSubTipoTrabajo.Text = String.Empty
        cbxFechaFactDesde.Value = System.DBNull.Value : cbxFechaFactHasta.Text = String.Empty
        AdvFactura.Value = System.DBNull.Value : AdvFactura.Text = String.Empty
        AdvIDMaterial.Value = System.DBNull.Value : AdvIDMaterial.Text = String.Empty
        AdvIDTipo.Value = System.DBNull.Value : AdvIDTipo.Text = String.Empty
        AdvIDFamilia.Value = System.DBNull.Value : AdvIDFamilia.Text = String.Empty
        AdvIDSubFamilia.Value = System.DBNull.Value : AdvIDSubFamilia.Text = String.Empty
        AdvIDProveedor.Value = System.DBNull.Value : AdvIDProveedor.Text = String.Empty
        CmbEstadoObra.Value = System.DBNull.Value
    End Sub

#End Region

    Private Sub AdvIDFamilia_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs)
        If Length(AdvIDTipo.Text) > 0 Then
            e.Filter.Add(New StringFilterItem("IDTipo", FilterOperator.Equal, AdvIDTipo.Text))
        End If
    End Sub

    Private Sub AdvIDSubFamilia_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs)
        If Length(AdvIDTipo.Text) > 0 Then
            e.Filter.Add(New StringFilterItem("IDTipo", FilterOperator.Equal, AdvIDTipo.Text))
        End If
        If Length(AdvIDFamilia.Text) > 0 Then
            e.Filter.Add(New StringFilterItem("IdFamilia", FilterOperator.Equal, AdvIDFamilia.Text))
        End If
    End Sub

    Private Sub AdvIDMaterial_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs)
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

    Private Sub AdvSubTipoTrabajo_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles AdvSubTipoTrabajo.SetPredefinedFilter
        If Length(AdvTipoTrabajo.Text) > 0 Then
            e.Filter.Add(New StringFilterItem("IDTipoTrabajo", FilterOperator.Equal, AdvTipoTrabajo.Text))
        End If
    End Sub

    Private Sub Grid_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Grid.MouseUp
        If e.Button = MouseButtons.Right Then
            If Grid.RowCount > 0 Then
                If Length(Grid.Value("IDFactura")) > 0 Then
                    Grid.UiCommandManager1.Commands("Abrir Factura Compra").Visible = Janus.Windows.UI.InheritableBoolean.True
                Else
                    Grid.UiCommandManager1.Commands("Abrir Factura Compra").Visible = Janus.Windows.UI.InheritableBoolean.False
                End If
            End If
        End If
    End Sub

    Private Sub CIEstPrevMat_SetReportSelectionCriteria(ByVal sender As Object, ByVal e As Engine.UI.ReportSelectionCriteriaEventArgs) Handles MyBase.SetReportSelectionCriteria
        Select Case e.Alias
            Case "LCO"
                If Length(AdvObraDesde.Value) > 0 Then
                    e.Filter.Add("IDObra", FilterOperator.GreaterThanOrEqual, AdvObraDesde.Value)
                End If
                If Length(AdvObraHasta.Value) > 0 Then
                    e.Filter.Add("IDObra", FilterOperator.LessThanOrEqual, AdvObraHasta.Value)
                End If
                If Length(CmbEstadoObra.Value) > 0 Then
                    e.Filter.Add("Estado", FilterOperator.Equal, CmbEstadoObra.Value)
                End If

            Case "LCOD", "LCOTB", "LCOR", "LFCO", "LFCOTT"
                If Length(AdvObraDesde.Value) > 0 Then
                    e.Filter.Add("IDObra", FilterOperator.GreaterThanOrEqual, AdvObraDesde.Value)
                End If
                If Length(AdvObraHasta.Value) > 0 Then
                    e.Filter.Add("IDObra", FilterOperator.LessThanOrEqual, AdvObraHasta.Value)
                End If
                If Length(CmbEstadoObra.Value) > 0 Then
                    e.Filter.Add("Estado", FilterOperator.Equal, CmbEstadoObra.Value)
                End If
                If Length(cbxFechaFactDesde.Value) > 0 Then
                    e.Filter.Add("FechaFactura", FilterOperator.GreaterThanOrEqual, cbxFechaFactDesde.Value)
                End If
                If Length(cbxFechaFactHasta.Value) > 0 Then
                    e.Filter.Add("FechaFactura", FilterOperator.LessThanOrEqual, cbxFechaFactHasta.Value)
                End If
                If Length(Me.AdvTipoTrabajo.Value) > 0 Then
                    e.Filter.Add("IDTipoTrabajo", FilterOperator.Equal, AdvTipoTrabajo.Value)
                End If
                If Length(Me.AdvSubTipoTrabajo.Value) > 0 Then
                    e.Filter.Add("IDSubTipoTrabajo", FilterOperator.Equal, AdvSubTipoTrabajo.Value)
                End If
                If Length(Me.AdvIDProveedor.Value) > 0 Then
                    e.Filter.Add("IDProveedor", FilterOperator.Equal, AdvIDProveedor.Value)
                End If
                If Length(Me.AdvIDMaterial.Value) > 0 Then
                    e.Filter.Add("IDArticulo", FilterOperator.Equal, AdvIDMaterial.Value)
                End If
                If Length(Me.AdvIDTipo.Value) > 0 Then
                    e.Filter.Add("IDTipo", FilterOperator.Equal, AdvIDTipo.Value)
                End If
                If Length(Me.AdvIDFamilia.Value) > 0 Then
                    e.Filter.Add("IDFamilia", FilterOperator.Equal, AdvIDFamilia.Value)
                End If
                If Length(Me.AdvIDSubFamilia.Value) > 0 Then
                    e.Filter.Add("IDSubFamilia", FilterOperator.Equal, AdvIDSubFamilia.Value)
                End If
        End Select
    End Sub

End Class
