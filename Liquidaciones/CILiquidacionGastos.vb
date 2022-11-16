Public Class CILiquidacionGastos
    Inherits Solmicro.Expertis.Engine.UI.CIMnto

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        txtImporte.Value = System.DBNull.Value
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
    Friend WithEvents lblfwiCContable As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents fwiEstado As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblfwiEstado As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiTotalMarcado As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents PicTotal As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents AdvFormaPago As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvGasto As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents cbxPagado As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents AdvOperario As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents cbxFechaDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents cbxFechaHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents AdvObra As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents cbxContabilizado As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents AdvTrabajo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblFormaPago As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblGasto As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblPagado As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblOperario As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFechaDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFechaHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblObra As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblContabilizado As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblTotalMarcado As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblTotal As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtTotalMarcado As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtTotal As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents ulDescOperario As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents txtImporte As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents lblImporte As Solmicro.Expertis.Engine.UI.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim Grid_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.ImageList.ImageStream")
        Dim cbxPagado_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CILiquidacionGastos))
        Dim cbxContabilizado_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.lblfwiCContable = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiEstado = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblfwiEstado = New Solmicro.Expertis.Engine.UI.Label
        Me.PicTotal = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblTotalMarcado = New Solmicro.Expertis.Engine.UI.Label
        Me.lblTotal = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTotalMarcado = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtTotal = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblFormaPago = New Solmicro.Expertis.Engine.UI.Label
        Me.lblGasto = New Solmicro.Expertis.Engine.UI.Label
        Me.lblPagado = New Solmicro.Expertis.Engine.UI.Label
        Me.lblOperario = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFechaDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFechaHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.lblTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.lblObra = New Solmicro.Expertis.Engine.UI.Label
        Me.lblContabilizado = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvFormaPago = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.AdvGasto = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.cbxPagado = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.AdvOperario = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.cbxFechaDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.cbxFechaHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.AdvObra = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.cbxContabilizado = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.ulDescOperario = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.AdvTrabajo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.txtImporte = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblImporte = New Solmicro.Expertis.Engine.UI.Label
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        Me.PicTotal.suspendlayout()
        CType(Me.cbxPagado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxContabilizado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.txtImporte)
        Me.FilterPanel.Controls.Add(Me.lblImporte)
        Me.FilterPanel.Controls.Add(Me.AdvTrabajo)
        Me.FilterPanel.Controls.Add(Me.ulDescOperario)
        Me.FilterPanel.Controls.Add(Me.lblFormaPago)
        Me.FilterPanel.Controls.Add(Me.lblGasto)
        Me.FilterPanel.Controls.Add(Me.lblPagado)
        Me.FilterPanel.Controls.Add(Me.lblOperario)
        Me.FilterPanel.Controls.Add(Me.lblFechaDesde)
        Me.FilterPanel.Controls.Add(Me.lblFechaHasta)
        Me.FilterPanel.Controls.Add(Me.lblTrabajo)
        Me.FilterPanel.Controls.Add(Me.lblObra)
        Me.FilterPanel.Controls.Add(Me.lblContabilizado)
        Me.FilterPanel.Controls.Add(Me.AdvFormaPago)
        Me.FilterPanel.Controls.Add(Me.AdvGasto)
        Me.FilterPanel.Controls.Add(Me.cbxPagado)
        Me.FilterPanel.Controls.Add(Me.AdvOperario)
        Me.FilterPanel.Controls.Add(Me.cbxFechaDesde)
        Me.FilterPanel.Controls.Add(Me.cbxFechaHasta)
        Me.FilterPanel.Controls.Add(Me.AdvObra)
        Me.FilterPanel.Controls.Add(Me.cbxContabilizado)
        Me.FilterPanel.Controls.Add(Me.lblfwiEstado)
        Me.FilterPanel.Controls.Add(Me.lblfwiCContable)
        Me.FilterPanel.Controls.Add(Me.fwiEstado)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 280)
        Me.FilterPanel.Size = New System.Drawing.Size(688, 102)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Controls.Add(Me.PicTotal)
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(688, 280)
        Me.CIMntoGridPanel.Controls.SetChildIndex(Me.PicTotal, 0)
        Me.CIMntoGridPanel.Controls.SetChildIndex(Me.Grid, 0)
        '
        'Grid
        '
        Grid_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("Grid_DesignTimeLayout_Reference_0.Instance"), Object)
        Grid_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {Grid_DesignTimeLayout_Reference_0})
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.Grid.EntityName = "ObraGastoControl"
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid.FrozenColumns = 4
        Me.Grid.ImageList = Me.ImageList1
        Me.Grid.KeyField = "IDLineaGastoControl"
        Me.Grid.Size = New System.Drawing.Size(688, 248)
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.UseCheck = True
        Me.Grid.ViewName = "frmLiquidacionGastos"
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
        Me.MainPanel.Size = New System.Drawing.Size(688, 382)
        '
        'ExecuteActions
        '
        Me.ExecuteActions.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(688, 382)
        '
        'lblfwiCContable
        '
        Me.lblfwiCContable.Location = New System.Drawing.Point(5, 35)
        Me.lblfwiCContable.Name = "lblfwiCContable"
        Me.lblfwiCContable.Size = New System.Drawing.Size(0, 13)
        Me.lblfwiCContable.TabIndex = 46
        Me.lblfwiCContable.Tag = "IdRec=0;"
        '
        'fwiEstado
        '
        Me.fwiEstado.DisabledBackColor = System.Drawing.Color.White
        Me.fwiEstado.Location = New System.Drawing.Point(567, 348)
        Me.fwiEstado.Name = "fwiEstado"
        Me.fwiEstado.Size = New System.Drawing.Size(26, 21)
        Me.fwiEstado.TabIndex = 26
        Me.fwiEstado.Visible = False
        '
        'lblfwiEstado
        '
        Me.lblfwiEstado.Location = New System.Drawing.Point(496, 348)
        Me.lblfwiEstado.Name = "lblfwiEstado"
        Me.lblfwiEstado.Size = New System.Drawing.Size(45, 13)
        Me.lblfwiEstado.TabIndex = 65
        Me.lblfwiEstado.Tag = "IdRec=4405;"
        Me.lblfwiEstado.Text = "Estado"
        '
        'PicTotal
        '
        Me.PicTotal.Controls.Add(Me.lblTotalMarcado)
        Me.PicTotal.Controls.Add(Me.lblTotal)
        Me.PicTotal.Controls.Add(Me.txtTotalMarcado)
        Me.PicTotal.Controls.Add(Me.txtTotal)
        Me.PicTotal.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PicTotal.Location = New System.Drawing.Point(0, 248)
        Me.PicTotal.Name = "PicTotal"
        Me.PicTotal.Size = New System.Drawing.Size(688, 32)
        Me.PicTotal.TabIndex = 6
        '
        'lblTotalMarcado
        '
        Me.lblTotalMarcado.Location = New System.Drawing.Point(244, 9)
        Me.lblTotalMarcado.Name = "lblTotalMarcado"
        Me.lblTotalMarcado.Size = New System.Drawing.Size(126, 13)
        Me.lblTotalMarcado.TabIndex = 71
        Me.lblTotalMarcado.Text = "Total A Seleccionado"
        '
        'lblTotal
        '
        Me.lblTotal.Location = New System.Drawing.Point(506, 9)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(56, 13)
        Me.lblTotal.TabIndex = 70
        Me.lblTotal.Tag = "IdRec=6574;"
        Me.lblTotal.Text = "TOTAL A"
        '
        'txtTotalMarcado
        '
        Me.txtTotalMarcado.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotalMarcado.Enabled = False
        Me.txtTotalMarcado.Location = New System.Drawing.Point(373, 9)
        Me.txtTotalMarcado.Name = "txtTotalMarcado"
        Me.txtTotalMarcado.Size = New System.Drawing.Size(122, 21)
        Me.txtTotalMarcado.TabIndex = 69
        Me.txtTotalMarcado.TabStop = False
        '
        'txtTotal
        '
        Me.txtTotal.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(564, 9)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(122, 21)
        Me.txtTotal.TabIndex = 68
        Me.txtTotal.TabStop = False
        '
        'lblFormaPago
        '
        Me.lblFormaPago.Location = New System.Drawing.Point(539, 71)
        Me.lblFormaPago.Name = "lblFormaPago"
        Me.lblFormaPago.Size = New System.Drawing.Size(49, 13)
        Me.lblFormaPago.TabIndex = 67
        Me.lblFormaPago.Tag = "IdRec=4394;"
        Me.lblFormaPago.Text = "F. Pago"
        '
        'lblGasto
        '
        Me.lblGasto.Location = New System.Drawing.Point(539, 47)
        Me.lblGasto.Name = "lblGasto"
        Me.lblGasto.Size = New System.Drawing.Size(40, 13)
        Me.lblGasto.TabIndex = 76
        Me.lblGasto.Tag = "IdRec=5234;"
        Me.lblGasto.Text = "Gasto"
        '
        'lblPagado
        '
        Me.lblPagado.Location = New System.Drawing.Point(363, 47)
        Me.lblPagado.Name = "lblPagado"
        Me.lblPagado.Size = New System.Drawing.Size(49, 13)
        Me.lblPagado.TabIndex = 77
        Me.lblPagado.Text = "Pagado"
        '
        'lblOperario
        '
        Me.lblOperario.Location = New System.Drawing.Point(10, 23)
        Me.lblOperario.Name = "lblOperario"
        Me.lblOperario.Size = New System.Drawing.Size(57, 13)
        Me.lblOperario.TabIndex = 78
        Me.lblOperario.Tag = "IdRec=5860;"
        Me.lblOperario.Text = "Operario"
        '
        'lblFechaDesde
        '
        Me.lblFechaDesde.Location = New System.Drawing.Point(181, 47)
        Me.lblFechaDesde.Name = "lblFechaDesde"
        Me.lblFechaDesde.Size = New System.Drawing.Size(80, 13)
        Me.lblFechaDesde.TabIndex = 79
        Me.lblFechaDesde.Tag = ""
        Me.lblFechaDesde.Text = "Fecha Desde"
        '
        'lblFechaHasta
        '
        Me.lblFechaHasta.Location = New System.Drawing.Point(181, 71)
        Me.lblFechaHasta.Name = "lblFechaHasta"
        Me.lblFechaHasta.Size = New System.Drawing.Size(76, 13)
        Me.lblFechaHasta.TabIndex = 80
        Me.lblFechaHasta.Text = "Fecha Hasta"
        '
        'lblTrabajo
        '
        Me.lblTrabajo.Location = New System.Drawing.Point(10, 71)
        Me.lblTrabajo.Name = "lblTrabajo"
        Me.lblTrabajo.Size = New System.Drawing.Size(51, 13)
        Me.lblTrabajo.TabIndex = 81
        Me.lblTrabajo.Tag = "IdRec=5695;"
        Me.lblTrabajo.Text = "Trabajo"
        '
        'lblObra
        '
        Me.lblObra.Location = New System.Drawing.Point(10, 47)
        Me.lblObra.Name = "lblObra"
        Me.lblObra.Size = New System.Drawing.Size(57, 13)
        Me.lblObra.TabIndex = 82
        Me.lblObra.Tag = ""
        Me.lblObra.Text = "Proyecto"
        '
        'lblContabilizado
        '
        Me.lblContabilizado.Location = New System.Drawing.Point(362, 71)
        Me.lblContabilizado.Name = "lblContabilizado"
        Me.lblContabilizado.Size = New System.Drawing.Size(84, 13)
        Me.lblContabilizado.TabIndex = 83
        Me.lblContabilizado.Tag = "IdRec=4725;"
        Me.lblContabilizado.Text = "Contabilizado"
        '
        'AdvFormaPago
        '
        Me.AdvFormaPago.DisabledBackColor = System.Drawing.Color.White
        Me.AdvFormaPago.EntityName = "FormaPago"
        Me.AdvFormaPago.Location = New System.Drawing.Point(605, 71)
        Me.AdvFormaPago.Name = "AdvFormaPago"
        Me.AdvFormaPago.SecondaryDataFields = "IDFormaPago"
        Me.AdvFormaPago.Size = New System.Drawing.Size(75, 23)
        Me.AdvFormaPago.TabIndex = 9
        Me.AdvFormaPago.ViewName = "tbMaestroFormaPago"
        '
        'AdvGasto
        '
        Me.AdvGasto.DisabledBackColor = System.Drawing.Color.White
        Me.AdvGasto.EntityName = "Gasto"
        Me.AdvGasto.Location = New System.Drawing.Point(605, 47)
        Me.AdvGasto.Name = "AdvGasto"
        Me.AdvGasto.SecondaryDataFields = "IDGasto"
        Me.AdvGasto.Size = New System.Drawing.Size(75, 23)
        Me.AdvGasto.TabIndex = 8
        Me.AdvGasto.ViewName = "tbMaestroGasto"
        '
        'cbxPagado
        '
        cbxPagado_DesignTimeLayout.LayoutString = resources.GetString("cbxPagado_DesignTimeLayout.LayoutString")
        Me.cbxPagado.DesignTimeLayout = cbxPagado_DesignTimeLayout
        Me.cbxPagado.DisabledBackColor = System.Drawing.Color.White
        Me.cbxPagado.Location = New System.Drawing.Point(450, 47)
        Me.cbxPagado.Name = "cbxPagado"
        Me.cbxPagado.SelectedIndex = -1
        Me.cbxPagado.SelectedItem = Nothing
        Me.cbxPagado.Size = New System.Drawing.Size(80, 21)
        Me.cbxPagado.TabIndex = 5
        '
        'AdvOperario
        '
        Me.AdvOperario.DisabledBackColor = System.Drawing.Color.White
        Me.AdvOperario.EntityName = "Operario"
        Me.AdvOperario.Location = New System.Drawing.Point(70, 23)
        Me.AdvOperario.Name = "AdvOperario"
        Me.AdvOperario.SecondaryDataFields = "IDOperario"
        Me.AdvOperario.Size = New System.Drawing.Size(106, 23)
        Me.AdvOperario.TabIndex = 0
        Me.AdvOperario.ViewName = "tbMaestroOperario"
        '
        'cbxFechaDesde
        '
        Me.cbxFechaDesde.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaDesde.Location = New System.Drawing.Point(264, 47)
        Me.cbxFechaDesde.Name = "cbxFechaDesde"
        Me.cbxFechaDesde.Size = New System.Drawing.Size(93, 21)
        Me.cbxFechaDesde.TabIndex = 3
        '
        'cbxFechaHasta
        '
        Me.cbxFechaHasta.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaHasta.Location = New System.Drawing.Point(264, 71)
        Me.cbxFechaHasta.Name = "cbxFechaHasta"
        Me.cbxFechaHasta.Size = New System.Drawing.Size(93, 21)
        Me.cbxFechaHasta.TabIndex = 4
        '
        'AdvObra
        '
        Me.AdvObra.DisabledBackColor = System.Drawing.Color.White
        Me.AdvObra.DisplayField = "NObra"
        Me.AdvObra.EntityName = "ObraCabecera"
        Me.AdvObra.Location = New System.Drawing.Point(70, 47)
        Me.AdvObra.Name = "AdvObra"
        Me.AdvObra.SecondaryDataFields = "IDObra"
        Me.AdvObra.Size = New System.Drawing.Size(106, 23)
        Me.AdvObra.TabIndex = 1
        Me.AdvObra.ViewName = "tbObraCabecera"
        '
        'cbxContabilizado
        '
        cbxContabilizado_DesignTimeLayout.LayoutString = resources.GetString("cbxContabilizado_DesignTimeLayout.LayoutString")
        Me.cbxContabilizado.DesignTimeLayout = cbxContabilizado_DesignTimeLayout
        Me.cbxContabilizado.DisabledBackColor = System.Drawing.Color.White
        Me.cbxContabilizado.Location = New System.Drawing.Point(450, 71)
        Me.cbxContabilizado.Name = "cbxContabilizado"
        Me.cbxContabilizado.SelectedIndex = -1
        Me.cbxContabilizado.SelectedItem = Nothing
        Me.cbxContabilizado.Size = New System.Drawing.Size(80, 21)
        Me.cbxContabilizado.TabIndex = 6
        '
        'ulDescOperario
        '
        Me.TryDataBinding(ulDescOperario, New System.Windows.Forms.Binding("Text", Me.AdvOperario, "DescOperario", True))
        Me.ulDescOperario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ulDescOperario.Location = New System.Drawing.Point(179, 23)
        Me.ulDescOperario.Name = "ulDescOperario"
        Me.ulDescOperario.Size = New System.Drawing.Size(351, 21)
        Me.ulDescOperario.TabIndex = 84
        '
        'AdvTrabajo
        '
        Me.AdvTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvTrabajo.DisplayField = "CodTrabajo"
        Me.AdvTrabajo.EntityName = "ObraTrabajo"
        Me.AdvTrabajo.Location = New System.Drawing.Point(70, 71)
        Me.AdvTrabajo.Name = "AdvTrabajo"
        Me.AdvTrabajo.SecondaryDataFields = "IDTrabajo"
        Me.AdvTrabajo.Size = New System.Drawing.Size(106, 23)
        Me.AdvTrabajo.TabIndex = 2
        Me.AdvTrabajo.ViewName = "tbObraTrabajo"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.RestoreDirectory = True
        '
        'txtImporte
        '
        Me.txtImporte.DisabledBackColor = System.Drawing.Color.White
        Me.txtImporte.Location = New System.Drawing.Point(605, 24)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.NullBehavior = Janus.Windows.GridEX.NumericEditNullBehavior.AllowNull
        Me.txtImporte.Size = New System.Drawing.Size(75, 21)
        Me.txtImporte.TabIndex = 7
        '
        'lblImporte
        '
        Me.lblImporte.Location = New System.Drawing.Point(539, 23)
        Me.lblImporte.Name = "lblImporte"
        Me.lblImporte.Size = New System.Drawing.Size(66, 13)
        Me.lblImporte.TabIndex = 86
        Me.lblImporte.Tag = ""
        Me.lblImporte.Text = "Importe >"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "add2.ico")
        Me.ImageList1.Images.SetKeyName(1, "delete2.ico")
        '
        'CILiquidacionGastos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(696, 470)
        Me.EntityName = "ObraGastoControl"
        Me.KeyField = "IDLineaGastoControl"
        Me.Name = "CILiquidacionGastos"
        Me.UseCheck = True
        Me.ViewName = "frmLiquidacionGastos"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        Me.PicTotal.ResumeLayout(False)
        Me.PicTotal.PerformLayout()
        CType(Me.cbxPagado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxContabilizado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private blnGenerarFichero As Boolean
    Private strIDBancoPropio As String
    Private mblnContabilidadMultiple As Boolean

    Private Enum IconIndex
        NoContabilizado = 0
        Contabilizado = 1
    End Enum

#Region " Load "

    Private Sub CILiquidacionGastos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            LoadERPData()
            LoadEnums()
            LoadToolBarActions()
            InitFilterCriteria()
        End If
    End Sub

    Private Sub LoadERPData()
        mblnContabilidadMultiple = New Parametro().ContabilidadMultiple
    End Sub

    Private Sub LoadEnums()
        cbxContabilizado.DataSource = New EnumData("enumContabilizadoTodos")
        If Not mblnContabilidadMultiple Then
            If Not cbxContabilizado.DataSource Is Nothing Then
                CType(cbxContabilizado.DataSource, DataView).RowFilter = "Name = 'enumContabilizadoTodos' AND Value <> " & enumContabilizadoTodos.ContabilizadoNIIF & " AND Value <> " & enumContabilizadoTodos.ContabilizadoTributario
            End If

        End If
        'cbxContabilizado.DataSource = New EnumData("enumContabilizadoTodos")
        cbxPagado.DataSource = New EnumData("enumBoolean")
    End Sub

    Private Sub LoadToolBarActions()
        Me.FormActions.Add("Cambiar Estado", AddressOf AccionCambiarEstado)
        Me.FormActions.Add("Contabilización", AddressOf AccionContabilizar)
        Me.FormActions.Add("Descontabilización", AddressOf AccionDescontabilizar)
        Me.FormActions.Add("Generar Fichero Transferencia", AddressOf AccionFicheroTransferencia)
        Me.FormActions.Add("Generar Fichero Transferencia SEPA", AddressOf AccionFicheroTransferenciaSEPA)
    End Sub

    Private Sub InitFilterCriteria()
        cbxContabilizado.Value = CInt(enumContabilizadoTodos.Todos)
        cbxPagado.Value = CInt(enumBoolean.Todos)
        txtImporte.Value = 0
    End Sub

#End Region

#Region " Toolbar Actions "

    Private Sub AccionCambiarEstado()
        If Grid.CheckedRecordsCount > 0 Then
            Dim dtMarcados As DataTable = Me.CheckedRecords
            If Not dtMarcados Is Nothing AndAlso dtMarcados.Rows.Count > 0 Then
                If ExpertisApp.GenerateMessage("Se cambiará el estado de las líneas seleccionadas. ¿Desea continuar?.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    ExpertisApp.ExecuteTask(Of DataTable)(AddressOf ObraGastoControl.CambiarEstadoPagado, dtMarcados)
                    ExpertisApp.GenerateMessage("Proceso finalizado correctamente.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim dv As DataView = dtMarcados.DefaultView
                    dv.RowFilter = "Contabilizado<>1"
                    If dv.Count > 0 Then
                        If ExpertisApp.GenerateMessage("Hay líneas seleccionadas que no estan contabilizadas. ¿Desea contabilizarlas ahora?.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                            AccionContabilizar()
                        End If
                    End If

                    Me.UnCheckAllRecords()
                    Me.Execute()
                End If
            End If
        Else
            ExpertisApp.GenerateMessage("Debe seleccionar alguna fila.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub AccionContabilizar()
        If Grid.CheckedRecordsCount > 0 Then
            Dim dtMarcados As DataTable = Grid.CheckedRecords
            If Not dtMarcados Is Nothing Then
                Dim blnAgruparBanco As Boolean
                Dim strDescApunte As String = String.Empty
                Dim strEjercicio As String = String.Empty
                Dim dtmFechaApunte As Date
                Dim intNuevaSituacion As Integer

                Dim IDProcess As System.Guid = Grid.SaveServerChecks()

                Dim frm As New frmContabilizar
                Dim r As DialogResult = frm.AbrirContabilizacion(dtmFechaApunte, strIDBancoPropio, intNuevaSituacion, _
                                                                 strEjercicio, blnAgruparBanco, strDescApunte, _
                                                                 ObrasGeneral.enumTipoLiquidacion.enumTlGasto)
                If r = DialogResult.OK Then
                    blnGenerarFichero = frm.chkGenerarFichero.Checked
                    Dim data As New DataSimulacionContableInfo
                    data.IDEjercicio = strEjercicio
                    data.GuidSimulacion = IDProcess
                    data.FechaApunte = dtmFechaApunte
                    data.AgruparPorBanco = blnAgruparBanco
                    data.NuevaSituacion = intNuevaSituacion
                    data.IDBancoPropio = strIDBancoPropio
                    data.DescApunte = strDescApunte
                    data.Caption = "Simulación Contable - GASTOS -"
                    data.TipoContabilizacion = enumTipoContabilizacion.tcGasto

                    Dim oFrm As Form = ExpertisApp.OpenForm("CISIMUCONT", , data, Me)
                    AddHandler oFrm.Closed, AddressOf FrmActionClosed
                End If
            End If
        Else
            ExpertisApp.GenerateMessage("Debe seleccionar alguna fila.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub FrmActionClosed(ByVal sender As Object, ByVal e As System.EventArgs)
        RemoveHandler CType(sender, Form).Closed, AddressOf FrmActionClosed
        If blnGenerarFichero Then
            GenerarFicheroTransferencia()
        End If
        Me.UnCheckAllRecords()
        Me.DeleteServerChecks()
        Me.Execute()
    End Sub

    Private Sub AccionDescontabilizar()
        If Grid.CheckedRecordsCount > 0 Then
            Dim dtMarcados As DataTable = Me.CheckedRecords
            'Comprobamos si los pagos marcados se pueden descontabilizar
            Dim dv As DataView = dtMarcados.DefaultView
            dv.RowFilter = "Contabilizado<>0"
            If dv.Count = 0 Then
                ExpertisApp.GenerateMessage("No se pueden descontabilizar los pagos seleccionados.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)  'No se pueden descontabilizar los pagos seleccionados.
            Else
                Dim mIDProcess As System.Guid = Grid.SaveServerChecks()
                Dim frm As New frmDescontabilizar
                frm.AbrirFormulario(ObrasGeneral.enumTipoLiquidacion.enumTlGasto, mIDProcess)
            End If
            Me.UnCheckAllRecords()
            Me.DeleteServerChecks()
            Me.Execute()
        Else
            ExpertisApp.GenerateMessage("Debe seleccionar alguna fila.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)  'Debe seleccionar alguna fila.
        End If
    End Sub

    Private Sub AccionFicheroTransferencia()
        strIDBancoPropio = String.Empty

        GenerarFicheroTransferencia()

        Me.UnCheckAllRecords()
        Me.DeleteServerChecks()
        Me.Execute()
    End Sub

    Private Sub GenerarFicheroTransferencia()
        If Grid.CheckedRecordsCount > 0 Then
            Dim dtMarcados As DataTable = Me.CheckedRecords
            Dim intMarcados As Integer = dtMarcados.Rows.Count
            dtMarcados = TratarDatos(dtMarcados)
            Dim blnCancel As Boolean
            If intMarcados <> dtMarcados.Rows.Count Then
                If ExpertisApp.GenerateMessage("Sólo se generará el Fichero de Transferencia de aquellos registros no Pagados y que tengan un operario asignado. ¿Desea continuar?.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                    blnCancel = True
                End If
            End If
            If Not blnCancel Then
                If Not dtMarcados Is Nothing AndAlso dtMarcados.Rows.Count > 0 Then
                    If ExpertisApp.GenerateMessage("Se va a proceder a la generación del Fichero de Transferencia. ¿Desea continuar?.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        Dim IDProcess As System.Guid = Grid.SaveServerChecks()
                        If Length(strIDBancoPropio) = 0 Then
                            Dim frm As New frmBancoPropio
                            If frm.ShowDialog = DialogResult.OK Then
                                strIDBancoPropio = frm.cbxBancoPropio.Value
                            End If
                        End If

                        If Length(strIDBancoPropio) > 0 Then
                            SaveFileDialog1.ShowDialog()
                            Dim strRuta As String = SaveFileDialog1.FileName
                            Dim f As New GenerarFicheros
                            Dim StData As New GenerarFicheros.DataFicheros
                            StData.IDProcess = IDProcess : StData.IDBancoPropio = strIDBancoPropio
                            StData.TipoFichero = enumTipoFicheroTrans.tftGasto
                            Dim DtFichero As DataTable = ExpertisApp.ExecuteTask(Of GenerarFicheros.DataFicheros, DataTable)(AddressOf GenerarFicheros.GenerarFicheroTransferencia, StData)
                            If Not IsNothing(DtFichero) Then
                                If GuardarFichero(strRuta, DtFichero) Then
                                    ExpertisApp.GenerateMessage("Generado con éxito el fichero de Transferencias.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                End If
                            End If
                        End If
                    Else
                        ExpertisApp.GenerateMessage("Proceso cancelado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    ExpertisApp.GenerateMessage("No hay líneas que cumplan las condiciones para poder generar el Fichero de Transferencia.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                ExpertisApp.GenerateMessage("Proceso cancelado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            ExpertisApp.GenerateMessage("Debe seleccionar alguna fila.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub


    Private Sub AccionFicheroTransferenciaSEPA()
        strIDBancoPropio = String.Empty

        GenerarFicheroTransferenciaSEPA()

        Me.UnCheckAllRecords()
        Me.DeleteServerChecks()
        Me.Execute()
    End Sub

    Private Sub GenerarFicheroTransferenciaSEPA()
        If Grid.CheckedRecordsCount > 0 Then
            Dim dtMarcados As DataTable = Me.CheckedRecords
            Dim intMarcados As Integer = dtMarcados.Rows.Count
            dtMarcados = TratarDatos(dtMarcados)
            Dim blnCancel As Boolean
            If intMarcados <> dtMarcados.Rows.Count Then
                If ExpertisApp.GenerateMessage("Sólo se generará el Fichero de Transferencia SEPA de aquellos registros no Pagados y que tengan un operario asignado. ¿Desea continuar?.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                    blnCancel = True
                End If
            End If
            If Not blnCancel Then
                If Not dtMarcados Is Nothing AndAlso dtMarcados.Rows.Count > 0 Then
                    If ExpertisApp.GenerateMessage("Se va a proceder a la generación del Fichero de Transferencia SEPA. ¿Desea continuar?.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        Dim IDProcess As System.Guid = Grid.SaveServerChecks()
                        If Length(strIDBancoPropio) = 0 Then
                            Dim frm As New frmBancoPropio
                            If frm.ShowDialog = DialogResult.OK Then
                                strIDBancoPropio = frm.cbxBancoPropio.Value
                            End If
                        End If

                        If Length(strIDBancoPropio) > 0 Then
                            SaveFileDialog1.ShowDialog()
                            Dim strRuta As String = SaveFileDialog1.FileName
                            Dim dtFichero As New DataTable
                            dtFichero.Columns.Add("Linea", GetType(String))
                            Dim datFich As New DataGenerarFichero
                            datFich.IDProcess = IDProcess
                            datFich.IDBancoPropio = strIDBancoPropio
                            datFich.FechaEmision = Today
                            datFich.LiquidacionGastosObras = True
                            Dim lstRegsFich As List(Of String) = ExpertisApp.ExecuteTask(Of DataGenerarFichero, List(Of String))(AddressOf FicheroCSB34_14.GenerarFichero, datFich)
                            For Each Registro As String In lstRegsFich
                                Dim drNew As DataRow = dtFichero.NewRow
                                drNew("Linea") = Registro
                                dtFichero.Rows.Add(drNew)
                            Next

                            If dtFichero.Rows.Count > 0 Then
                                If GuardarFichero(strRuta, dtFichero) Then
                                    ExpertisApp.GenerateMessage("Generado con éxito el fichero de Transferencias.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                End If
                            End If
                        End If
                    Else
                        ExpertisApp.GenerateMessage("Proceso cancelado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    ExpertisApp.GenerateMessage("No hay líneas que cumplan las condiciones para poder generar el Fichero de Transferencia.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                ExpertisApp.GenerateMessage("Proceso cancelado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            ExpertisApp.GenerateMessage("Debe seleccionar alguna fila.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub


    Private Function TratarDatos(ByVal dtMarcados As DataTable) As DataTable
        For Each dr As DataRow In dtMarcados.Select
            If dr("Pagado") OrElse Length(dr("IDOperario")) = 0 Then
                dtMarcados.Rows.Remove(dr)
            End If
        Next
        Return dtMarcados
    End Function

#End Region

#Region " QueryExecute "

    Private Sub CILiquidacionGastos_QueryExecuting(ByVal sender As Object, ByRef e As Solmicro.Expertis.Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        e.Filter.Add("IDOperario", FilterOperator.Equal, AdvOperario.Text, FilterType.String)
        e.Filter.Add("IDObra", FilterOperator.Equal, AdvObra.Value, FilterType.Numeric)
        e.Filter.Add("IDTrabajo", FilterOperator.Equal, AdvTrabajo.Value, FilterType.Numeric)
        e.Filter.Add("Fecha", FilterOperator.GreaterThanOrEqual, cbxFechaDesde.Value, FilterType.DateTime)
        e.Filter.Add("Fecha", FilterOperator.LessThanOrEqual, cbxFechaHasta.Value, FilterType.DateTime)
        e.Filter.Add("IDGasto", FilterOperator.Equal, AdvGasto.Text, FilterType.String)
        e.Filter.Add("IDFormaPago", FilterOperator.Equal, AdvFormaPago.Text, FilterType.String)
        e.Filter.Add("ImpRealGastoA", FilterOperator.GreaterThan, txtImporte.Value, FilterType.Numeric)

        If cbxContabilizado.Value <> enumContabilizadoTodos.Todos Then
            e.Filter.Add("Contabilizado", FilterOperator.Equal, cbxContabilizado.Value, FilterType.Numeric)
        End If
        If cbxPagado.Value <> enumBoolean.Todos Then
            e.Filter.Add("Pagado", FilterOperator.Equal, cbxPagado.Value, FilterType.Numeric)
        End If
    End Sub

    Private Sub CILiquidacionGastos_QueryExecuted(ByVal sender As Object, ByRef e As Solmicro.Expertis.Engine.UI.QueryExecutedEventArgs) Handles MyBase.QueryExecuted
        txtTotal.Value = Grid.GetTotal(Grid.Columns("ImpRealGastoA"), AggregateFunction.Sum)
    End Sub

    Protected Overrides Sub OnFilterClearing(ByVal e As System.EventArgs)
        MyBase.OnFilterClearing(e)
        cbxFechaDesde.TextBox.Clear()
        cbxFechaHasta.TextBox.Clear()
        InitFilterCriteria()
    End Sub

#End Region

    Private Sub CILiquidacionGastos_RecordChecked(ByVal sender As Object, ByVal e As Engine.UI.CheckedEventArgs) Handles MyBase.RecordChecked
        If e.CheckState = CheckStates.Checked Then
            txtTotalMarcado.Value = txtTotalMarcado.Value + e.Row.Cells("ImpRealGastoA").Value
        Else
            txtTotalMarcado.Value = txtTotalMarcado.Value - e.Row.Cells("ImpRealGastoA").Value
        End If
    End Sub

    Private Sub Grid_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles Grid.FormattingRow
        If e.Row.RowType = RowType.Record Then
            If e.Row.Cells("Contabilizado").Value <> enumContabilizado.NoContabilizado Then
                e.Row.RowStyle = Grid.FormatStyles("ContabilizadoFormatStyle")
                e.Row.Cells("Contabilizado").ImageIndex = IconIndex.Contabilizado
            Else
                e.Row.Cells("Contabilizado").ImageIndex = IconIndex.NoContabilizado
            End If
        End If
    End Sub

    

End Class
