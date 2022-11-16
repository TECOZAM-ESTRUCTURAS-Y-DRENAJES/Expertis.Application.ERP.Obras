Public Class CISeleccionCapitulos
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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(CISeleccionCapitulos))
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Name = "CIMntoGridPanel"
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(536, 193)
        '
        'FilterPanel
        '
        Me.FilterPanel.Location = New System.Drawing.Point(0, 193)
        Me.FilterPanel.Name = "FilterPanel"
        Me.FilterPanel.Visible = False
        '
        'Grid
        '
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""IDTrabajo""><" & _
        "Caption>IDTrabajo</Caption><DataMember>IDTrabajo</DataMember><EditType>NoEdit</E" & _
        "ditType><Key>IDTrabajo</Key><Position>0</Position><Visible>False</Visible></Colu" & _
        "mn0><Column1 ID=""IDObra""><Caption>IDObra</Caption><DataMember>IDObra</DataMember" & _
        "><EditType>NoEdit</EditType><Key>IDObra</Key><Position>1</Position><Visible>Fals" & _
        "e</Visible></Column1><Column2 ID=""IDTipoTrabajo""><Caption>IDTipoTrabajo</Caption" & _
        "><DataMember>IDTipoTrabajo</DataMember><Key>IDTipoTrabajo</Key><Position>2</Posi" & _
        "tion><Visible>False</Visible></Column2><Column3 ID=""CodTrabajo""><Caption>Capítul" & _
        "o</Caption><DataMember>CodTrabajo</DataMember><Key>CodTrabajo</Key><Position>3</" & _
        "Position><Width>90</Width></Column3><Column4 ID=""DescTrabajo""><Caption>Desc. Cap" & _
        "ítulo</Caption><DataMember>DescTrabajo</DataMember><Key>DescTrabajo</Key><Positi" & _
        "on>4</Position><Width>245</Width></Column4><Column5 ID=""IdProcess""><Caption>IdPr" & _
        "ocess</Caption><DataMember>IdProcess</DataMember><Key>IdProcess</Key><Position>5" & _
        "</Position><Visible>False</Visible></Column5><Column6 ID=""CantidadMarca1""><Capti" & _
        "on>CantidadMarca1</Caption><DataMember>CantidadMarca1</DataMember><Key>CantidadM" & _
        "arca1</Key><Position>6</Position><TextAlignment>Far</TextAlignment><Visible>Fals" & _
        "e</Visible></Column6><Column7 ID=""TipoLinea""><Caption>TipoLinea</Caption><DataMe" & _
        "mber>TipoLinea</DataMember><Key>TipoLinea</Key><Position>7</Position><Visible>Fa" & _
        "lse</Visible></Column7></Columns><GroupCondition ID="""" /></RootTable></GridEXLay" & _
        "outData>"
        Me.Grid.DesignTimeLayout = GridEXLayout1
        Me.Grid.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.Grid.EntityName = "ObraTrabajo"
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Grid.KeyField = "IDTipoTrabajo"
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(536, 193)
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.UseCheck = True
        Me.Grid.ViewName = "vfrmCISeleccionCapitulosInformeParcialObra"
        '
        'MainPanel
        '
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(536, 273)
        '
        'ExecuteActions
        '
        Me.ExecuteActions.Icon = CType(resources.GetObject("ExecuteActions.Icon"), System.Drawing.Icon)
        '
        'Menubar
        '
        Me.Menubar.Name = "Menubar"
        '
        'Toolbar
        '
        Me.Toolbar.Name = "Toolbar"
        Me.Toolbar.Size = New System.Drawing.Size(296, 26)
        '
        'Export
        '
        Me.Export.Icon = CType(resources.GetObject("Export.Icon"), System.Drawing.Icon)
        '
        'ClearFilter
        '
        Me.ClearFilter.Icon = CType(resources.GetObject("ClearFilter.Icon"), System.Drawing.Icon)
        '
        'ShowAllCheckedItems
        '
        Me.ShowAllCheckedItems.Icon = CType(resources.GetObject("ShowAllCheckedItems.Icon"), System.Drawing.Icon)
        Me.ShowAllCheckedItems.Visible = Janus.Windows.UI.InheritableBoolean.True
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Name = "MainPanelCIMntoContainer"
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(536, 273)
        '
        'ExecuteQuery
        '
        Me.ExecuteQuery.Icon = CType(resources.GetObject("ExecuteQuery.Icon"), System.Drawing.Icon)
        '
        'UncheckAll
        '
        Me.UncheckAll.Icon = CType(resources.GetObject("UncheckAll.Icon"), System.Drawing.Icon)
        Me.UncheckAll.Visible = Janus.Windows.UI.InheritableBoolean.True
        '
        'CheckAll
        '
        Me.CheckAll.Icon = CType(resources.GetObject("CheckAll.Icon"), System.Drawing.Icon)
        Me.CheckAll.Visible = Janus.Windows.UI.InheritableBoolean.True
        '
        'CISeleccionCapitulos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(544, 357)
        Me.EntityName = "ObraTrabajo"
        Me.KeyField = "IDTipoTrabajo"
        Me.Name = "CISeleccionCapitulos"
        Me.Text = "CISeleccionCapitulos"
        Me.UseCheck = True
        Me.ViewName = "vfrmCISeleccionCapitulosInformeParcialObra"
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region

    Dim MIntIDPresup As Integer

    Private Sub LoadParams()
        Me.UiCommandManager1.CommandBars(0).Commands("ShowFilterPanel").Visible = Janus.Windows.UI.InheritableBoolean.False
        Me.UiCommandManager1.CommandBars(0).Commands("ShowFilterPanel").Enabled = Janus.Windows.UI.InheritableBoolean.False
        Me.FilterPanel.Visible = False
        If Not Me.Params Is Nothing Then
            Dim HtParam As Hashtable
            HtParam = Me.Params
            MIntIDPresup = HtParam("IDObra")
            Me.Execute()
        End If
    End Sub

    Private Sub CISeleccionCapitulos_QueryExecuting(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        If Length(MIntIDPresup) > 0 Then
            e.Filter.Add("IDObra", FilterOperator.Equal, MIntIDPresup)
            e.Filter.Add("TipoLinea", FilterOperator.Equal, enumTipoLineaTrabajo.tltCapitulo)
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub CISeleccionCapitulos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadParams()
    End Sub

    Private Sub CISeleccionCapitulos_SetReportExportOptions(ByVal sender As Object, ByVal e As Engine.UI.ReportExportOptionsEventArgs) Handles MyBase.SetReportExportOptions
        e.Options.PromptUser = True
        Me.Close()
    End Sub

    Private Sub CISeleccionCapitulos_SetReportSelectionCriteria(ByVal sender As Object, ByVal e As Engine.UI.ReportSelectionCriteriaEventArgs) Handles MyBase.SetReportSelectionCriteria
        Dim DtGrid As DataTable = Grid.CheckedRecords
        Dim StrListTipo(DtGrid.Rows.Count - 1) As String
        Dim i As Integer = 0
        For Each Dr As DataRow In DtGrid.Select
            StrListTipo(i) = Dr("IDTipoTrabajo")
            i += 1
        Next
        e.Filter.Add("IDObra", FilterOperator.Equal, MIntIDPresup, FilterType.Numeric)
        e.Filter.Add(New InListFilterItem("IDTipoTrabajo", StrListTipo, FilterType.String))
    End Sub
End Class