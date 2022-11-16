'Imports Solmicro.Expertis.Engine
Public Class CIResumenEconomicoTrabajo
    Inherits Solmicro.Expertis.Engine.UI.CIMnto

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        Me.Toolbar.Commands("ExecuteActions").Visible = Janus.Windows.UI.InheritableBoolean.False
        Me.Toolbar.Commands("ShowFilterPanel").Visible = Janus.Windows.UI.InheritableBoolean.False

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
    Friend WithEvents Frame1 As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents advObra As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblObra As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblTesoreria As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblActual As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtTesoreria As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtActual As Solmicro.Expertis.Engine.UI.NumericTextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIResumenEconomicoTrabajo))
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.Frame1 = New Solmicro.Expertis.Engine.UI.Frame
        Me.txtActual = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtTesoreria = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblActual = New Solmicro.Expertis.Engine.UI.Label
        Me.lblTesoreria = New Solmicro.Expertis.Engine.UI.Label
        Me.advObra = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblObra = New Solmicro.Expertis.Engine.UI.Label
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        Me.Panel1.suspendlayout()
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.lblObra)
        Me.FilterPanel.Controls.Add(Me.advObra)
        Me.FilterPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FilterPanel.Location = New System.Drawing.Point(0, 0)
        Me.FilterPanel.Size = New System.Drawing.Size(484, 80)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Controls.Add(Me.Panel1)
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(736, 437)
        Me.CIMntoGridPanel.Controls.SetChildIndex(Me.Panel1, 0)
        Me.CIMntoGridPanel.Controls.SetChildIndex(Me.Grid, 0)
        '
        'Grid
        '
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EntityName = "ObraTrabajo"
        Me.Grid.Size = New System.Drawing.Size(736, 357)
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.ViewName = "vObraResumenEconomicoTrabajos"
        '
        'CheckAll
        '
        Me.CheckAll.Icon = CType(resources.GetObject("CheckAll.Icon"), System.Drawing.Icon)
        '
        'UncheckAll
        '
        Me.UncheckAll.Icon = CType(resources.GetObject("UncheckAll.Icon"), System.Drawing.Icon)
        '
        'ExecuteQuery
        '
        Me.ExecuteQuery.Icon = CType(resources.GetObject("ExecuteQuery.Icon"), System.Drawing.Icon)
        '
        'ShowAllCheckedItems
        '
        Me.ShowAllCheckedItems.Icon = CType(resources.GetObject("ShowAllCheckedItems.Icon"), System.Drawing.Icon)
        '
        'ClearFilter
        '
        Me.ClearFilter.Icon = CType(resources.GetObject("ClearFilter.Icon"), System.Drawing.Icon)
        '
        'Export
        '
        Me.Export.Icon = CType(resources.GetObject("Export.Icon"), System.Drawing.Icon)
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
        Me.MainPanel.Size = New System.Drawing.Size(736, 437)
        '
        'ExecuteActions
        '
        Me.ExecuteActions.Icon = CType(resources.GetObject("ExecuteActions.Icon"), System.Drawing.Icon)
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(736, 437)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.FilterPanel)
        Me.Panel1.Controls.Add(Me.Frame1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 357)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(736, 80)
        Me.Panel1.TabIndex = 1
        Me.Panel1.Controls.SetChildIndex(Me.Frame1, 0)
        Me.Panel1.Controls.SetChildIndex(Me.FilterPanel, 0)
        '
        'Frame1
        '
        Me.Frame1.Controls.Add(Me.txtActual)
        Me.Frame1.Controls.Add(Me.txtTesoreria)
        Me.Frame1.Controls.Add(Me.lblActual)
        Me.Frame1.Controls.Add(Me.lblTesoreria)
        Me.Frame1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Frame1.Location = New System.Drawing.Point(484, 0)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(252, 80)
        Me.Frame1.TabIndex = 1
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Resumen Beneficio"
        '
        'txtActual
        '
        Me.txtActual.DisabledBackColor = System.Drawing.Color.White
        Me.txtActual.Enabled = False
        Me.txtActual.Location = New System.Drawing.Point(88, 48)
        Me.txtActual.Name = "txtActual"
        Me.txtActual.Size = New System.Drawing.Size(150, 21)
        Me.txtActual.TabIndex = 7
        '
        'txtTesoreria
        '
        Me.txtTesoreria.DisabledBackColor = System.Drawing.Color.White
        Me.txtTesoreria.Enabled = False
        Me.txtTesoreria.Location = New System.Drawing.Point(88, 24)
        Me.txtTesoreria.Name = "txtTesoreria"
        Me.txtTesoreria.Size = New System.Drawing.Size(150, 21)
        Me.txtTesoreria.TabIndex = 4
        '
        'lblActual
        '
        Me.lblActual.Location = New System.Drawing.Point(24, 48)
        Me.lblActual.Name = "lblActual"
        Me.lblActual.Size = New System.Drawing.Size(42, 13)
        Me.lblActual.TabIndex = 3
        Me.lblActual.Text = "Actual"
        '
        'lblTesoreria
        '
        Me.lblTesoreria.Location = New System.Drawing.Point(24, 24)
        Me.lblTesoreria.Name = "lblTesoreria"
        Me.lblTesoreria.Size = New System.Drawing.Size(61, 13)
        Me.lblTesoreria.TabIndex = 0
        Me.lblTesoreria.Text = "Tesoreria"
        '
        'advObra
        '
        Me.advObra.DisabledBackColor = System.Drawing.Color.White
        Me.advObra.DisplayField = "NObra"
        Me.advObra.EntityName = "ObraCabecera"
        Me.advObra.Location = New System.Drawing.Point(80, 24)
        Me.advObra.Name = "advObra"
        Me.advObra.SecondaryDataFields = "IDObra"
        Me.advObra.Size = New System.Drawing.Size(100, 23)
        Me.advObra.TabIndex = 0
        Me.advObra.ViewName = "tbobracabecera"
        '
        'lblObra
        '
        Me.lblObra.Location = New System.Drawing.Point(18, 28)
        Me.lblObra.Name = "lblObra"
        Me.lblObra.Size = New System.Drawing.Size(57, 13)
        Me.lblObra.TabIndex = 1
        Me.lblObra.Text = "Proyecto"
        '
        'CIResumenEconomicoTrabajo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(744, 525)
        Me.EntityName = "ObraTrabajo"
        Me.Name = "CIResumenEconomicoTrabajo"
        Me.Text = "CIResumenEconomicoTrabajo"
        Me.ViewName = "vObraResumenEconomicoTrabajos"
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
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Respuesta a eventos"

    Private Sub CIResumenEconomicoTrabajo_QueryExecuting(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        FiltrarDatos(e)
        LoadResumen()
    End Sub

#End Region

#Region "Procedimientos y funciones de ayuda"

    Private Sub FiltrarDatos(ByVal e As Engine.UI.QueryExecutingEventArgs)
        e.Filter.Add("IDObra", FilterOperator.Equal, advObra.Value, FilterType.Numeric)
    End Sub

    Private Sub LoadResumen()
        Dim dt As DataTable
        Dim _resumenObraTotal As New BE.DataEngine
        Dim _filter As New Filter
        _filter.Add("IDobra", FilterOperator.Equal, advObra.Value, FilterType.Numeric)
        dt = _resumenObraTotal.Filter("vObraResumenEconomicoTotal", _filter)
        If Not dt Is Nothing AndAlso dt.Rows.Count > 0 Then
            txtTesoreria.Text = dt.Rows(0)("BeneficioTesoreria")
            txtActual.Text = dt.Rows(0)("BeneficioActual")
        Else
            txtTesoreria.Text = 0
            txtActual.Text = 0
        End If
    End Sub

#End Region

End Class
