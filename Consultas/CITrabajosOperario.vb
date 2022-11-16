Imports Janus.Windows.GridEX
Public Class CITrabajosOperario
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
    Friend WithEvents lblNObra As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblNObra1 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblIDOperario As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblIDOperario1 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblIDCategoria As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDCategoria As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblIDHora As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDHora As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblFechaInicio1 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFechaFin1 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advNObraD As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents advNObraH As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents advIDOperarioD As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents advIDOperarioH As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblFechaInicioD As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents clbFechaInicioH As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaFinD As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents clbFechaFinH As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents clbFechaInicioD As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents clbFechaFinD As Solmicro.Expertis.Engine.UI.CalendarBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim Grid_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.ImageList.ImageStream")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CITrabajosOperario))
        Me.lblNObra = New Solmicro.Expertis.Engine.UI.Label
        Me.advNObraD = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblNObra1 = New Solmicro.Expertis.Engine.UI.Label
        Me.advNObraH = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblIDOperario = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDOperarioD = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblIDOperario1 = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDOperarioH = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblIDCategoria = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDCategoria = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblIDHora = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDHora = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblFechaInicioD = New Solmicro.Expertis.Engine.UI.Label
        Me.clbFechaInicioD = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaInicio1 = New Solmicro.Expertis.Engine.UI.Label
        Me.clbFechaInicioH = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaFinD = New Solmicro.Expertis.Engine.UI.Label
        Me.clbFechaFinD = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaFin1 = New Solmicro.Expertis.Engine.UI.Label
        Me.clbFechaFinH = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
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
        Me.FilterPanel.Controls.Add(Me.lblNObra)
        Me.FilterPanel.Controls.Add(Me.lblNObra1)
        Me.FilterPanel.Controls.Add(Me.lblIDOperario)
        Me.FilterPanel.Controls.Add(Me.lblIDOperario1)
        Me.FilterPanel.Controls.Add(Me.lblIDCategoria)
        Me.FilterPanel.Controls.Add(Me.lblIDHora)
        Me.FilterPanel.Controls.Add(Me.lblFechaInicioD)
        Me.FilterPanel.Controls.Add(Me.lblFechaInicio1)
        Me.FilterPanel.Controls.Add(Me.lblFechaFinD)
        Me.FilterPanel.Controls.Add(Me.lblFechaFin1)
        Me.FilterPanel.Controls.Add(Me.advNObraD)
        Me.FilterPanel.Controls.Add(Me.advNObraH)
        Me.FilterPanel.Controls.Add(Me.advIDOperarioD)
        Me.FilterPanel.Controls.Add(Me.advIDOperarioH)
        Me.FilterPanel.Controls.Add(Me.advIDCategoria)
        Me.FilterPanel.Controls.Add(Me.advIDHora)
        Me.FilterPanel.Controls.Add(Me.clbFechaInicioD)
        Me.FilterPanel.Controls.Add(Me.clbFechaInicioH)
        Me.FilterPanel.Controls.Add(Me.clbFechaFinD)
        Me.FilterPanel.Controls.Add(Me.clbFechaFinH)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 205)
        Me.FilterPanel.Size = New System.Drawing.Size(640, 128)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(640, 205)
        '
        'Grid
        '
        Grid_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("Grid_DesignTimeLayout_Reference_0.Instance"), Object)
        Grid_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {Grid_DesignTimeLayout_Reference_0})
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EntityName = "ObraMODControl"
        Me.Grid.ImageList = Me.ImageList1
        Me.Grid.Size = New System.Drawing.Size(640, 205)
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.ViewName = "VFrmMntoConsultaTrabOperario"
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
        Me.MainPanel.Size = New System.Drawing.Size(640, 333)
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(640, 333)
        '
        'lblNObra
        '
        Me.lblNObra.Location = New System.Drawing.Point(16, 30)
        Me.lblNObra.Name = "lblNObra"
        Me.lblNObra.Size = New System.Drawing.Size(97, 13)
        Me.lblNObra.TabIndex = 0
        Me.lblNObra.Text = "Proyecto Desde"
        '
        'advNObraD
        '
        Me.TryDataBinding(advNObraD, New System.Windows.Forms.Binding("Text", Me, "NObra", True))
        Me.advNObraD.DisabledBackColor = System.Drawing.Color.White
        Me.advNObraD.DisplayField = "NObra"
        Me.advNObraD.EntityName = "ObraCabecera"
        Me.advNObraD.Location = New System.Drawing.Point(118, 25)
        Me.advNObraD.Name = "advNObraD"
        Me.advNObraD.SecondaryDataFields = "IDObra"
        Me.advNObraD.Size = New System.Drawing.Size(104, 23)
        Me.advNObraD.TabIndex = 1
        '
        'lblNObra1
        '
        Me.lblNObra1.Location = New System.Drawing.Point(16, 54)
        Me.lblNObra1.Name = "lblNObra1"
        Me.lblNObra1.Size = New System.Drawing.Size(93, 13)
        Me.lblNObra1.TabIndex = 2
        Me.lblNObra1.Text = "Proyecto Hasta"
        '
        'advNObraH
        '
        Me.TryDataBinding(advNObraH, New System.Windows.Forms.Binding("Text", Me, "NObra", True))
        Me.advNObraH.DisabledBackColor = System.Drawing.Color.White
        Me.advNObraH.DisplayField = "NObra"
        Me.advNObraH.EntityName = "ObraCabecera"
        Me.advNObraH.Location = New System.Drawing.Point(118, 49)
        Me.advNObraH.Name = "advNObraH"
        Me.advNObraH.SecondaryDataFields = "IDObra"
        Me.advNObraH.Size = New System.Drawing.Size(104, 23)
        Me.advNObraH.TabIndex = 3
        '
        'lblIDOperario
        '
        Me.lblIDOperario.Location = New System.Drawing.Point(16, 78)
        Me.lblIDOperario.Name = "lblIDOperario"
        Me.lblIDOperario.Size = New System.Drawing.Size(97, 13)
        Me.lblIDOperario.TabIndex = 4
        Me.lblIDOperario.Text = "Operario Desde"
        '
        'advIDOperarioD
        '
        Me.TryDataBinding(advIDOperarioD, New System.Windows.Forms.Binding("Text", Me, "IDOperario", True))
        Me.advIDOperarioD.DisabledBackColor = System.Drawing.Color.White
        Me.advIDOperarioD.EntityName = "Operario"
        Me.advIDOperarioD.Location = New System.Drawing.Point(118, 73)
        Me.advIDOperarioD.Name = "advIDOperarioD"
        Me.advIDOperarioD.SecondaryDataFields = "IDOperario"
        Me.advIDOperarioD.Size = New System.Drawing.Size(104, 23)
        Me.advIDOperarioD.TabIndex = 5
        '
        'lblIDOperario1
        '
        Me.lblIDOperario1.Location = New System.Drawing.Point(16, 102)
        Me.lblIDOperario1.Name = "lblIDOperario1"
        Me.lblIDOperario1.Size = New System.Drawing.Size(93, 13)
        Me.lblIDOperario1.TabIndex = 6
        Me.lblIDOperario1.Text = "Operario Hasta"
        '
        'advIDOperarioH
        '
        Me.TryDataBinding(advIDOperarioH, New System.Windows.Forms.Binding("Text", Me, "IDOperario", True))
        Me.advIDOperarioH.DisabledBackColor = System.Drawing.Color.White
        Me.advIDOperarioH.EntityName = "Operario"
        Me.advIDOperarioH.Location = New System.Drawing.Point(118, 97)
        Me.advIDOperarioH.Name = "advIDOperarioH"
        Me.advIDOperarioH.SecondaryDataFields = "IDOperario"
        Me.advIDOperarioH.Size = New System.Drawing.Size(104, 23)
        Me.advIDOperarioH.TabIndex = 7
        '
        'lblIDCategoria
        '
        Me.lblIDCategoria.Location = New System.Drawing.Point(312, 30)
        Me.lblIDCategoria.Name = "lblIDCategoria"
        Me.lblIDCategoria.Size = New System.Drawing.Size(63, 13)
        Me.lblIDCategoria.TabIndex = 8
        Me.lblIDCategoria.Text = "Categoría"
        '
        'advIDCategoria
        '
        Me.TryDataBinding(advIDCategoria, New System.Windows.Forms.Binding("Text", Me, "IDCategoria", True))
        Me.advIDCategoria.DisabledBackColor = System.Drawing.Color.White
        Me.advIDCategoria.EntityName = "Categoria"
        Me.advIDCategoria.Location = New System.Drawing.Point(408, 25)
        Me.advIDCategoria.Name = "advIDCategoria"
        Me.advIDCategoria.SecondaryDataFields = "IDCategoria"
        Me.advIDCategoria.Size = New System.Drawing.Size(96, 23)
        Me.advIDCategoria.TabIndex = 9
        '
        'lblIDHora
        '
        Me.lblIDHora.Location = New System.Drawing.Point(312, 54)
        Me.lblIDHora.Name = "lblIDHora"
        Me.lblIDHora.Size = New System.Drawing.Size(62, 13)
        Me.lblIDHora.TabIndex = 10
        Me.lblIDHora.Text = "Tipo Hora"
        '
        'advIDHora
        '
        Me.TryDataBinding(advIDHora, New System.Windows.Forms.Binding("Text", Me, "IDHora", True))
        Me.advIDHora.DisabledBackColor = System.Drawing.Color.White
        Me.advIDHora.EntityName = "Hora"
        Me.advIDHora.Location = New System.Drawing.Point(408, 49)
        Me.advIDHora.Name = "advIDHora"
        Me.advIDHora.SecondaryDataFields = "IDHora"
        Me.advIDHora.Size = New System.Drawing.Size(96, 23)
        Me.advIDHora.TabIndex = 11
        '
        'lblFechaInicioD
        '
        Me.lblFechaInicioD.Location = New System.Drawing.Point(312, 77)
        Me.lblFechaInicioD.Name = "lblFechaInicioD"
        Me.lblFechaInicioD.Size = New System.Drawing.Size(92, 13)
        Me.lblFechaInicioD.TabIndex = 12
        Me.lblFechaInicioD.Text = "Fecha Inicio D."
        '
        'clbFechaInicioD
        '
        Me.TryDataBinding(clbFechaInicioD, New System.Windows.Forms.Binding("BindableValue", Me, "FechaInicio", True))
        Me.clbFechaInicioD.DisabledBackColor = System.Drawing.Color.White
        Me.clbFechaInicioD.Location = New System.Drawing.Point(408, 73)
        Me.clbFechaInicioD.Name = "clbFechaInicioD"
        Me.clbFechaInicioD.Size = New System.Drawing.Size(96, 21)
        Me.clbFechaInicioD.TabIndex = 13
        '
        'lblFechaInicio1
        '
        Me.lblFechaInicio1.Location = New System.Drawing.Point(510, 77)
        Me.lblFechaInicio1.Name = "lblFechaInicio1"
        Me.lblFechaInicio1.Size = New System.Drawing.Size(12, 13)
        Me.lblFechaInicio1.TabIndex = 14
        Me.lblFechaInicio1.Text = "-"
        '
        'clbFechaInicioH
        '
        Me.TryDataBinding(clbFechaInicioH, New System.Windows.Forms.Binding("BindableValue", Me, "FechaInicio", True))
        Me.clbFechaInicioH.DisabledBackColor = System.Drawing.Color.White
        Me.clbFechaInicioH.Location = New System.Drawing.Point(528, 73)
        Me.clbFechaInicioH.Name = "clbFechaInicioH"
        Me.clbFechaInicioH.Size = New System.Drawing.Size(96, 21)
        Me.clbFechaInicioH.TabIndex = 15
        '
        'lblFechaFinD
        '
        Me.lblFechaFinD.Location = New System.Drawing.Point(312, 101)
        Me.lblFechaFinD.Name = "lblFechaFinD"
        Me.lblFechaFinD.Size = New System.Drawing.Size(77, 13)
        Me.lblFechaFinD.TabIndex = 16
        Me.lblFechaFinD.Text = "Fecha Fin D."
        '
        'clbFechaFinD
        '
        Me.TryDataBinding(clbFechaFinD, New System.Windows.Forms.Binding("BindableValue", Me, "FechaFin", True))
        Me.clbFechaFinD.DisabledBackColor = System.Drawing.Color.White
        Me.clbFechaFinD.Location = New System.Drawing.Point(408, 97)
        Me.clbFechaFinD.Name = "clbFechaFinD"
        Me.clbFechaFinD.Size = New System.Drawing.Size(96, 21)
        Me.clbFechaFinD.TabIndex = 17
        '
        'lblFechaFin1
        '
        Me.lblFechaFin1.Location = New System.Drawing.Point(510, 100)
        Me.lblFechaFin1.Name = "lblFechaFin1"
        Me.lblFechaFin1.Size = New System.Drawing.Size(12, 13)
        Me.lblFechaFin1.TabIndex = 18
        Me.lblFechaFin1.Text = "-"
        '
        'clbFechaFinH
        '
        Me.TryDataBinding(clbFechaFinH, New System.Windows.Forms.Binding("BindableValue", Me, "FechaFin", True))
        Me.clbFechaFinH.DisabledBackColor = System.Drawing.Color.White
        Me.clbFechaFinH.Location = New System.Drawing.Point(528, 97)
        Me.clbFechaFinH.Name = "clbFechaFinH"
        Me.clbFechaFinH.Size = New System.Drawing.Size(96, 21)
        Me.clbFechaFinH.TabIndex = 19
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "folder_edit.ico")
        '
        'CITrabajosOperario
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(648, 421)
        Me.EntityName = "ObraMODControl"
        Me.Name = "CITrabajosOperario"
        Me.Text = "CITrabajosOperario"
        Me.ViewName = "VFrmMntoConsultaTrabOperario"
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

    Private Const cnABRIROPERARIO As String = "Abrir Operario"

#Region " Load "

    Private Sub CITrabajosOperario_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadGridActions()
    End Sub

    Private Sub LoadGridActions()
        Me.Grid.Actions.Add("Abrir Proyecto", AddressOf AccionAbrirObra, ExpertisApp.GetIcon("xProyectos.ico"))
        Me.Grid.Actions.Add(cnABRIROPERARIO, AddressOf AccionAbrirOperario, ExpertisApp.GetIcon("xPartesTrabajo.ico"))
    End Sub

#End Region

#Region " Grid Actions "

    Private Sub AccionAbrirObra()
        If ExpertisApp.IsFormOpen("MGEO") Then ExpertisApp.CloseForm("MGEO")
        ExpertisApp.OpenForm("MGEO", New FilterItem("IDObra", FilterOperator.Equal, Grid.GetValue("IDObra")))
    End Sub

    Private Sub AccionAbrirOperario()
        If ExpertisApp.IsFormOpen("MNTOOPER") Then ExpertisApp.CloseForm("MNTOOPER")
        ExpertisApp.OpenForm("MNTOOPER", New FilterItem("IDOperario", FilterOperator.Equal, Grid.GetValue("IDOperario")))
    End Sub

#End Region

#Region " Grid "

    Private Sub Grid_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid.Click
        Dim Hit As Janus.Windows.GridEX.GridArea = Grid.HitTest()
        If Hit = Janus.Windows.GridEX.GridArea.Cell Then
            Dim c As Janus.Windows.GridEX.GridEXColumn = Grid.ColumnFromPoint()
            If Not IsNothing(c) Then
                Select Case c.Key
                    Case "BtnParte"
                        Dim FrmObv As New FormularioTexto
                        FrmObv.Texto = Grid.GetValue("DescParte") & String.Empty
                        FrmObv.SoloLectura = True
                        FrmObv.ShowDialog()
                End Select
            End If
        End If
    End Sub

    Private Sub Grid_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Grid.MouseUp
        If e.Button = MouseButtons.Right Then
            If Not IsNothing(Grid) AndAlso Grid.RowCount > 0 Then
                If Length(Grid.Value("IDOperario")) > 0 Then
                    Grid.UiCommandManager1.Commands(cnABRIROPERARIO).Visible = InheritableBoolean.True
                Else
                    Grid.UiCommandManager1.Commands(cnABRIROPERARIO).Visible = InheritableBoolean.False
                End If
            End If
        End If
    End Sub

#End Region

    Private Sub CITrabajosOperario_QueryExecuting(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        e.Filter.Add("IdObra", FilterOperator.GreaterThanOrEqual, advNObraD.Value, FilterType.Numeric)
        e.Filter.Add("IdObra", FilterOperator.LessThanOrEqual, advNObraH.Value, FilterType.Numeric)
        e.Filter.Add("IdOperario", FilterOperator.GreaterThanOrEqual, advIDOperarioD.Text, FilterType.String)
        e.Filter.Add("IdOperario", FilterOperator.LessThanOrEqual, advIDOperarioH.Text, FilterType.String)
        e.Filter.Add("IdCategoria", FilterOperator.Equal, advIDCategoria.Text, FilterType.String)
        e.Filter.Add("IdHora", FilterOperator.Equal, advIDHora.Text, FilterType.String)
        e.Filter.Add("FechaInicio", FilterOperator.GreaterThanOrEqual, clbFechaInicioD.Value, FilterType.DateTime)
        e.Filter.Add("FechaInicio", FilterOperator.LessThanOrEqual, clbFechaInicioH.Value, FilterType.DateTime)
        e.Filter.Add("FechaFin", FilterOperator.GreaterThanOrEqual, clbFechaFinD.Value, FilterType.DateTime)
        e.Filter.Add("FechaFin", FilterOperator.LessThanOrEqual, clbFechaFinH.Value, FilterType.DateTime)
    End Sub

    Private Sub CITrabajosOperario_FilterCleared(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.FilterCleared
        Me.clbFechaFinD.TextBox.Clear() : Me.clbFechaFinD.Value = Nothing
        Me.clbFechaFinH.TextBox.Clear() : Me.clbFechaFinH.Value = Nothing
        Me.clbFechaInicioD.TextBox.Clear() : Me.clbFechaInicioD.Value = Nothing
        Me.clbFechaInicioH.TextBox.Clear() : Me.clbFechaInicioH.Value = Nothing
    End Sub

End Class