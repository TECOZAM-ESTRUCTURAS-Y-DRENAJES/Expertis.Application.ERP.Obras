<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CIHitosPeriodificables
    Inherits Solmicro.Expertis.Engine.UI.CIMnto

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIHitosPeriodificables))
        Me.pnlFecha = New Solmicro.Expertis.Engine.UI.Panel
        Me.ntxPorcIncrDecrPerido = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblPorcIncrDecrPerido = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechafinPeriodificacion = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaFin = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDTrabajo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDObra = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.blIDObra = New Solmicro.Expertis.Engine.UI.Label
        Me.lblTipoObra = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDTipoObra = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.advIDCliente = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblCliente = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaInicioHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaInicioHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        Me.pnlFecha.suspendlayout()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.cbxFechaInicioHasta)
        Me.FilterPanel.Controls.Add(Me.lblFechaInicioHasta)
        Me.FilterPanel.Controls.Add(Me.advIDCliente)
        Me.FilterPanel.Controls.Add(Me.lblCliente)
        Me.FilterPanel.Controls.Add(Me.advIDTrabajo)
        Me.FilterPanel.Controls.Add(Me.lblTrabajo)
        Me.FilterPanel.Controls.Add(Me.advIDTipoObra)
        Me.FilterPanel.Controls.Add(Me.lblTipoObra)
        Me.FilterPanel.Controls.Add(Me.advIDObra)
        Me.FilterPanel.Controls.Add(Me.blIDObra)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 375)
        Me.FilterPanel.Size = New System.Drawing.Size(884, 61)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Controls.Add(Me.pnlFecha)
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(884, 375)
        Me.CIMntoGridPanel.Controls.SetChildIndex(Me.pnlFecha, 0)
        Me.CIMntoGridPanel.Controls.SetChildIndex(Me.Grid, 0)
        '
        'Grid
        '
        Me.Grid.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[True]
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EntityName = "ObraTrabajoTipoFacturacion"
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Grid.KeyField = "IDTipoVencimiento"
        Me.Grid.Location = New System.Drawing.Point(0, 37)
        Me.Grid.Size = New System.Drawing.Size(884, 338)
        Me.Grid.UseCheck = True
        Me.Grid.ViewName = "vCIObraHitosPeriodificables"
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
        Me.Toolbar.Size = New System.Drawing.Size(391, 28)
        '
        'Menubar
        '
        Me.Menubar.Location = New System.Drawing.Point(0, 28)
        '
        'MainPanel
        '
        Me.MainPanel.Size = New System.Drawing.Size(884, 436)
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(884, 436)
        '
        'pnlFecha
        '
        Me.pnlFecha.Controls.Add(Me.ntxPorcIncrDecrPerido)
        Me.pnlFecha.Controls.Add(Me.lblPorcIncrDecrPerido)
        Me.pnlFecha.Controls.Add(Me.cbxFechafinPeriodificacion)
        Me.pnlFecha.Controls.Add(Me.lblFechaFin)
        Me.pnlFecha.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFecha.Location = New System.Drawing.Point(0, 0)
        Me.pnlFecha.Name = "pnlFecha"
        Me.pnlFecha.Size = New System.Drawing.Size(884, 37)
        Me.pnlFecha.TabIndex = 0
        Me.pnlFecha.Visible = False
        '
        'ntxPorcIncrDecrPerido
        '
        Me.ntxPorcIncrDecrPerido.DisabledBackColor = System.Drawing.Color.White
        Me.ntxPorcIncrDecrPerido.Location = New System.Drawing.Point(391, 8)
        Me.ntxPorcIncrDecrPerido.Name = "ntxPorcIncrDecrPerido"
        Me.ntxPorcIncrDecrPerido.NullBehavior = Janus.Windows.GridEX.NumericEditNullBehavior.AllowNull
        Me.ntxPorcIncrDecrPerido.Size = New System.Drawing.Size(49, 21)
        Me.ntxPorcIncrDecrPerido.TabIndex = 1
        '
        'lblPorcIncrDecrPerido
        '
        Me.lblPorcIncrDecrPerido.Location = New System.Drawing.Point(255, 12)
        Me.lblPorcIncrDecrPerido.Name = "lblPorcIncrDecrPerido"
        Me.lblPorcIncrDecrPerido.Size = New System.Drawing.Size(164, 13)
        Me.lblPorcIncrDecrPerido.TabIndex = 348
        Me.lblPorcIncrDecrPerido.Text = "% Incremento/Decremento"
        '
        'cbxFechafinPeriodificacion
        '
        Me.cbxFechafinPeriodificacion.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechafinPeriodificacion.Location = New System.Drawing.Point(140, 8)
        Me.cbxFechafinPeriodificacion.Name = "cbxFechafinPeriodificacion"
        Me.cbxFechafinPeriodificacion.Size = New System.Drawing.Size(101, 21)
        Me.cbxFechafinPeriodificacion.TabIndex = 0
        '
        'lblFechaFin
        '
        Me.lblFechaFin.Location = New System.Drawing.Point(11, 11)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(144, 13)
        Me.lblFechaFin.TabIndex = 2
        Me.lblFechaFin.Text = "Fecha fin periodificación"
        '
        'advIDTrabajo
        '
        Me.advIDTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.advIDTrabajo.DisplayField = "CodTrabajo"
        Me.advIDTrabajo.EntityName = "ObraTrabajo"
        Me.advIDTrabajo.Location = New System.Drawing.Point(246, 25)
        Me.advIDTrabajo.Name = "advIDTrabajo"
        Me.advIDTrabajo.SecondaryDataFields = "IDTrabajo"
        Me.advIDTrabajo.Size = New System.Drawing.Size(100, 23)
        Me.advIDTrabajo.TabIndex = 1
        '
        'lblTrabajo
        '
        Me.lblTrabajo.Location = New System.Drawing.Point(196, 30)
        Me.lblTrabajo.Name = "lblTrabajo"
        Me.lblTrabajo.Size = New System.Drawing.Size(50, 13)
        Me.lblTrabajo.TabIndex = 16
        Me.lblTrabajo.Text = "Trabajo"
        '
        'advIDObra
        '
        Me.advIDObra.DisabledBackColor = System.Drawing.Color.White
        Me.advIDObra.DisplayField = "NObra"
        Me.advIDObra.EntityName = "ObraCabecera"
        Me.advIDObra.Location = New System.Drawing.Point(78, 25)
        Me.advIDObra.Name = "advIDObra"
        Me.advIDObra.SecondaryDataFields = "IDObra"
        Me.advIDObra.Size = New System.Drawing.Size(100, 23)
        Me.advIDObra.TabIndex = 0
        '
        'blIDObra
        '
        Me.blIDObra.Location = New System.Drawing.Point(19, 30)
        Me.blIDObra.Name = "blIDObra"
        Me.blIDObra.Size = New System.Drawing.Size(57, 13)
        Me.blIDObra.TabIndex = 12
        Me.blIDObra.Text = "Proyecto"
        '
        'lblTipoObra
        '
        Me.lblTipoObra.Location = New System.Drawing.Point(366, 30)
        Me.lblTipoObra.Name = "lblTipoObra"
        Me.lblTipoObra.Size = New System.Drawing.Size(31, 13)
        Me.lblTipoObra.TabIndex = 14
        Me.lblTipoObra.Text = "Tipo"
        '
        'advIDTipoObra
        '
        Me.advIDTipoObra.DisabledBackColor = System.Drawing.Color.White
        Me.advIDTipoObra.EntityName = "ObraTipo"
        Me.advIDTipoObra.Location = New System.Drawing.Point(399, 25)
        Me.advIDTipoObra.Name = "advIDTipoObra"
        Me.advIDTipoObra.SecondaryDataFields = "IDTipoObra"
        Me.advIDTipoObra.Size = New System.Drawing.Size(100, 23)
        Me.advIDTipoObra.TabIndex = 2
        '
        'advIDCliente
        '
        Me.advIDCliente.DisabledBackColor = System.Drawing.Color.White
        Me.advIDCliente.EntityName = "Cliente"
        Me.advIDCliente.Location = New System.Drawing.Point(571, 25)
        Me.advIDCliente.Name = "advIDCliente"
        Me.advIDCliente.SecondaryDataFields = "IDCliente"
        Me.advIDCliente.Size = New System.Drawing.Size(100, 23)
        Me.advIDCliente.TabIndex = 3
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(525, 30)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(47, 13)
        Me.lblCliente.TabIndex = 18
        Me.lblCliente.Text = "Cliente"
        '
        'cbxFechaInicioHasta
        '
        Me.cbxFechaInicioHasta.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaInicioHasta.Location = New System.Drawing.Point(766, 26)
        Me.cbxFechaInicioHasta.Name = "cbxFechaInicioHasta"
        Me.cbxFechaInicioHasta.Size = New System.Drawing.Size(100, 21)
        Me.cbxFechaInicioHasta.TabIndex = 4
        '
        'lblFechaInicioHasta
        '
        Me.lblFechaInicioHasta.Location = New System.Drawing.Point(700, 30)
        Me.lblFechaInicioHasta.Name = "lblFechaInicioHasta"
        Me.lblFechaInicioHasta.Size = New System.Drawing.Size(86, 13)
        Me.lblFechaInicioHasta.TabIndex = 20
        Me.lblFechaInicioHasta.Text = "F. Inicio Hasta"
        '
        'CIHitosPeriodificables
        '
        Me.AllowUpdate = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(892, 524)
        Me.EntityName = "ObraTrabajoTipoFacturacion"
        Me.KeyField = "IDTipoVencimiento"
        Me.Name = "CIHitosPeriodificables"
        Me.UseCheck = True
        Me.ViewName = "vCIObraHitosPeriodificables"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        Me.pnlFecha.ResumeLayout(False)
        Me.pnlFecha.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlFecha As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents ntxPorcIncrDecrPerido As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblPorcIncrDecrPerido As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechafinPeriodificacion As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaFin As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDTrabajo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDObra As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents blIDObra As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDTipoObra As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblTipoObra As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDCliente As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblCliente As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaInicioHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaInicioHasta As Solmicro.Expertis.Engine.UI.Label
End Class
