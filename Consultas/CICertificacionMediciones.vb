Public Class CICertificacionMediciones
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
    Friend WithEvents lblTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblObra As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvIDTrabajo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvIDObra As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblTipoCertificacion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblDescMedicion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtDescMedicion As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblFechaDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFechaHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Label2 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvIDCertificacion As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents cbxTipoCertificacion As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents cbxFechaDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents cbxFechaHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxTipoCertificacion_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CICertificacionMediciones))
        Me.lblTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.lblObra = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDTrabajo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.AdvIDObra = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblTipoCertificacion = New Solmicro.Expertis.Engine.UI.Label
        Me.lblDescMedicion = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxTipoCertificacion = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.txtDescMedicion = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblFechaDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFechaHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.cbxFechaHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.Label2 = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDCertificacion = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        CType(Me.cbxTipoCertificacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.Label2)
        Me.FilterPanel.Controls.Add(Me.AdvIDCertificacion)
        Me.FilterPanel.Controls.Add(Me.lblFechaDesde)
        Me.FilterPanel.Controls.Add(Me.lblFechaHasta)
        Me.FilterPanel.Controls.Add(Me.cbxFechaDesde)
        Me.FilterPanel.Controls.Add(Me.cbxFechaHasta)
        Me.FilterPanel.Controls.Add(Me.lblTipoCertificacion)
        Me.FilterPanel.Controls.Add(Me.lblDescMedicion)
        Me.FilterPanel.Controls.Add(Me.cbxTipoCertificacion)
        Me.FilterPanel.Controls.Add(Me.txtDescMedicion)
        Me.FilterPanel.Controls.Add(Me.lblTrabajo)
        Me.FilterPanel.Controls.Add(Me.lblObra)
        Me.FilterPanel.Controls.Add(Me.AdvIDTrabajo)
        Me.FilterPanel.Controls.Add(Me.AdvIDObra)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 262)
        Me.FilterPanel.Size = New System.Drawing.Size(784, 88)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(784, 262)
        '
        'Grid
        '
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EntityName = "ObraCertificacionMedicion"
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Grid.ImageList = Me.ImageList1
        Me.Grid.Size = New System.Drawing.Size(784, 262)
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.ViewName = "vCICertificacionMediciones"
        '
        'Toolbar
        '
        Me.Toolbar.Size = New System.Drawing.Size(222, 28)
        '
        'Menubar
        '
        Me.Menubar.Location = New System.Drawing.Point(0, 28)
        '
        'MainPanel
        '
        Me.MainPanel.Size = New System.Drawing.Size(784, 350)
        '
        'ExecuteActions
        '
        Me.ExecuteActions.Visible = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(784, 350)
        '
        'lblTrabajo
        '
        Me.lblTrabajo.Location = New System.Drawing.Point(8, 56)
        Me.lblTrabajo.Name = "lblTrabajo"
        Me.lblTrabajo.Size = New System.Drawing.Size(50, 13)
        Me.lblTrabajo.TabIndex = 111
        Me.lblTrabajo.Tag = "IdRec=5280;"
        Me.lblTrabajo.Text = "Trabajo"
        '
        'lblObra
        '
        Me.lblObra.Location = New System.Drawing.Point(8, 29)
        Me.lblObra.Name = "lblObra"
        Me.lblObra.Size = New System.Drawing.Size(57, 13)
        Me.lblObra.TabIndex = 110
        Me.lblObra.Tag = ""
        Me.lblObra.Text = "Proyecto"
        '
        'AdvIDTrabajo
        '
        Me.AdvIDTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDTrabajo.DisplayField = "CodTrabajo"
        Me.AdvIDTrabajo.EntityName = "ObraTrabajo"
        Me.AdvIDTrabajo.Location = New System.Drawing.Point(68, 52)
        Me.AdvIDTrabajo.Name = "AdvIDTrabajo"
        Me.AdvIDTrabajo.SecondaryDataFields = "IDTrabajo"
        Me.AdvIDTrabajo.Size = New System.Drawing.Size(105, 23)
        Me.AdvIDTrabajo.TabIndex = 1
        Me.AdvIDTrabajo.ViewName = "tbObraTrabajo"
        '
        'AdvIDObra
        '
        Me.AdvIDObra.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDObra.DisplayField = "NObra"
        Me.AdvIDObra.EntityName = "ObraCabecera"
        Me.AdvIDObra.Location = New System.Drawing.Point(68, 24)
        Me.AdvIDObra.Name = "AdvIDObra"
        Me.AdvIDObra.SecondaryDataFields = "IDObra"
        Me.AdvIDObra.Size = New System.Drawing.Size(105, 23)
        Me.AdvIDObra.TabIndex = 0
        Me.AdvIDObra.ViewName = "tbObraCabecera"
        '
        'lblTipoCertificacion
        '
        Me.lblTipoCertificacion.Location = New System.Drawing.Point(179, 56)
        Me.lblTipoCertificacion.Name = "lblTipoCertificacion"
        Me.lblTipoCertificacion.Size = New System.Drawing.Size(106, 13)
        Me.lblTipoCertificacion.TabIndex = 246
        Me.lblTipoCertificacion.Text = "Tipo Certificación"
        '
        'lblDescMedicion
        '
        Me.lblDescMedicion.Location = New System.Drawing.Point(421, 56)
        Me.lblDescMedicion.Name = "lblDescMedicion"
        Me.lblDescMedicion.Size = New System.Drawing.Size(92, 13)
        Me.lblDescMedicion.TabIndex = 245
        Me.lblDescMedicion.Text = "Desc. Medición"
        '
        'cbxTipoCertificacion
        '
        cbxTipoCertificacion_DesignTimeLayout.LayoutString = resources.GetString("cbxTipoCertificacion_DesignTimeLayout.LayoutString")
        Me.cbxTipoCertificacion.DesignTimeLayout = cbxTipoCertificacion_DesignTimeLayout
        Me.cbxTipoCertificacion.DisabledBackColor = System.Drawing.Color.White
        Me.cbxTipoCertificacion.Location = New System.Drawing.Point(289, 52)
        Me.cbxTipoCertificacion.Name = "cbxTipoCertificacion"
        Me.cbxTipoCertificacion.SelectedIndex = -1
        Me.cbxTipoCertificacion.SelectedItem = Nothing
        Me.cbxTipoCertificacion.Size = New System.Drawing.Size(130, 21)
        Me.cbxTipoCertificacion.TabIndex = 3
        '
        'txtDescMedicion
        '
        Me.txtDescMedicion.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescMedicion.Location = New System.Drawing.Point(530, 52)
        Me.txtDescMedicion.Name = "txtDescMedicion"
        Me.txtDescMedicion.Size = New System.Drawing.Size(247, 21)
        Me.txtDescMedicion.TabIndex = 6
        '
        'lblFechaDesde
        '
        Me.lblFechaDesde.Location = New System.Drawing.Point(421, 29)
        Me.lblFechaDesde.Name = "lblFechaDesde"
        Me.lblFechaDesde.Size = New System.Drawing.Size(105, 13)
        Me.lblFechaDesde.TabIndex = 247
        Me.lblFechaDesde.Text = "Fecha creación D"
        '
        'lblFechaHasta
        '
        Me.lblFechaHasta.Location = New System.Drawing.Point(629, 29)
        Me.lblFechaHasta.Name = "lblFechaHasta"
        Me.lblFechaHasta.Size = New System.Drawing.Size(48, 13)
        Me.lblFechaHasta.TabIndex = 249
        Me.lblFechaHasta.Text = "- Hasta"
        '
        'cbxFechaDesde
        '
        Me.cbxFechaDesde.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaDesde.Location = New System.Drawing.Point(528, 26)
        Me.cbxFechaDesde.Name = "cbxFechaDesde"
        Me.cbxFechaDesde.Size = New System.Drawing.Size(96, 21)
        Me.cbxFechaDesde.TabIndex = 4
        '
        'cbxFechaHasta
        '
        Me.cbxFechaHasta.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaHasta.Location = New System.Drawing.Point(681, 26)
        Me.cbxFechaHasta.Name = "cbxFechaHasta"
        Me.cbxFechaHasta.Size = New System.Drawing.Size(96, 21)
        Me.cbxFechaHasta.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(179, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 252
        Me.Label2.Text = "Nº. Certificación"
        '
        'AdvIDCertificacion
        '
        Me.AdvIDCertificacion.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDCertificacion.DisplayField = "NCertificacion"
        Me.AdvIDCertificacion.EntityName = "ObraCertificacion"
        Me.AdvIDCertificacion.Location = New System.Drawing.Point(289, 24)
        Me.AdvIDCertificacion.Name = "AdvIDCertificacion"
        Me.AdvIDCertificacion.PrimaryDataFields = "IdCertificacion"
        Me.AdvIDCertificacion.SecondaryDataFields = "IdCertificacion"
        Me.AdvIDCertificacion.Size = New System.Drawing.Size(105, 23)
        Me.AdvIDCertificacion.TabIndex = 2
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        '
        'CICertificacionMediciones
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(792, 438)
        Me.EntityName = "ObraCertificacionMedicion"
        Me.Name = "CICertificacionMediciones"
        Me.ViewName = "vCICertificacionMediciones"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        CType(Me.cbxTipoCertificacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Load "

    Private Sub CICertificacionMediciones_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadEnums()
        LoadGridActions()
    End Sub

    Private Sub LoadEnums()
        EnumData.PopulateValueList("enumEstadoCertificacion", Grid.Columns("Estado"))
        EnumData.PopulateValueList("enumTipoCertificacion", Grid.Columns("TipoCertificacion"))
        cbxTipoCertificacion.DataSource = New EnumData("enumTipoCertificacion")
    End Sub

    Private Sub LoadGridActions()
        Grid.Actions.Add("Abrir Certificación Medición", AddressOf AbrirCertificacionMedicion, ExpertisApp.GetIcon("document_edit.ico"))
        Grid.Actions.Add("Abrir Proyectos", AddressOf AccionAbrirObras, ExpertisApp.GetIcon("xProyectos.ico"))
    End Sub

#End Region

#Region " Grid Actions "

    Private Sub AbrirCertificacionMedicion()
        ExpertisApp.OpenForm("MNTOCERTIFMED", New NumberFilterItem("IDLineaCertificacion", Grid.Value("IDLineaCertificacion")))
    End Sub

    Private Sub AccionAbrirObras()
        ExpertisApp.OpenForm("MGEO", New NumberFilterItem("IDObra", Grid.GetValue("IDObra")))
    End Sub

#End Region

    Private Sub CICertificacionMediciones_QueryExecuting(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        e.Filter.Add("IDObra", FilterOperator.Equal, AdvIDObra.Value, FilterType.Numeric)
        e.Filter.Add("IDTrabajo", FilterOperator.Equal, AdvIDTrabajo.Value, FilterType.Numeric)
        e.Filter.Add("IDCertificacion", FilterOperator.Equal, AdvIDCertificacion.Value, FilterType.Numeric)
        e.Filter.Add("TipoCertificacion", FilterOperator.Equal, cbxTipoCertificacion.Value, FilterType.Numeric)
        e.Filter.Add("FechaCreacion", FilterOperator.GreaterThanOrEqual, cbxFechaDesde.Value, FilterType.DateTime)
        e.Filter.Add("FechaCreacion", FilterOperator.LessThanOrEqual, cbxFechaHasta.Value, FilterType.DateTime)
        e.Filter.Add(New LikeFilterItem("DescMedicion", "%" & txtDescMedicion.Text & "%", True))
    End Sub

    Private Sub CICertificacionMediciones_FilterCleared(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.FilterCleared
        cbxFechaDesde.TextBox.Clear()
        cbxFechaHasta.TextBox.Clear()
    End Sub

    Private Sub Grid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grid.Click
        With Grid
            Dim hit As GridArea = .HitTest()
            If hit = GridArea.Cell Or hit = GridArea.NewRowCell Then
                Dim c As GridEXColumn = .ColumnFromPoint()
                If Not IsNothing(c) Then
                    Select Case c.Key
                        Case "VerObservaciones"
                            Dim frm As New FormularioTexto
                            frm.Texto = .Value("Observaciones") & String.Empty
                            frm.ShowDialog()
                            If .Value("Observaciones") & String.Empty <> frm.Texto Then
                                .SetValue("Observaciones", frm.Texto)
                            End If
                    End Select
                End If
            End If
        End With
    End Sub

    Private Sub AdvIDTrabajo_AdvIDCertificacion_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles AdvIDTrabajo.SetPredefinedFilter, AdvIDCertificacion.SetPredefinedFilter
        If Length(AdvIDObra.Value) > 0 Then
            e.Filter.Add(New NumberFilterItem("IDObra", AdvIDObra.Value))
        Else
            e.Filter.Add(New NoRowsFilterItem)
        End If
    End Sub

End Class
