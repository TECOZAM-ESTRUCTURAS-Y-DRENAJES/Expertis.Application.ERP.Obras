Public Class MntoCopiaObra
    Inherits Solmicro.Expertis.Engine.UI.SimpleMnto

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
    Friend WithEvents PnlCabecera As System.Windows.Forms.Panel
    Friend WithEvents lblObra As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtDescObra As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents txtNObra As Solmicro.Expertis.Engine.UI.CounterTextBox
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents TvwTrabajos As System.Windows.Forms.TreeView
    Friend WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents lblObraOrigen As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvObra As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents FraConceptosVer As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents TvwTrabajosOrigen As System.Windows.Forms.TreeView
    Friend WithEvents chkVerTrabajos As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkVerMateriales As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkVerCentros As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkVerMOD As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents chkVerTareas As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkVerVarios As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkVerGastos As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkVerMediciones As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents rbtMinimizarTree As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents rbtMaximizarTree As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents cmbVerDatos As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents chkVerTodos As Solmicro.Expertis.Engine.UI.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MntoCopiaObra))
        Me.PnlCabecera = New System.Windows.Forms.Panel
        Me.lblObra = New Solmicro.Expertis.Engine.UI.Label
        Me.txtDescObra = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtNObra = New Solmicro.Expertis.Engine.UI.CounterTextBox
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.TvwTrabajos = New System.Windows.Forms.TreeView
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblObraOrigen = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvObra = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.FraConceptosVer = New Solmicro.Expertis.Engine.UI.Frame
        Me.chkVerTodos = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.rbtMinimizarTree = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.rbtMaximizarTree = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.cmbVerDatos = New Solmicro.Expertis.Engine.UI.Button
        Me.chkVerTareas = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkVerMediciones = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkVerVarios = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkVerGastos = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkVerCentros = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkVerMOD = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkVerMateriales = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkVerTrabajos = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.TvwTrabajosOrigen = New System.Windows.Forms.TreeView
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.ToolBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.suspendlayout()
        Me.PnlCabecera.SuspendLayout()
        Me.Panel1.suspendlayout()
        Me.FraConceptosVer.SuspendLayout()
        Me.SuspendLayout()
        '
        'Duplicate
        '
        Me.Duplicate.Visible = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'ToolBar
        '
        Me.ToolBar.Size = New System.Drawing.Size(617, 39)
        '
        'MenuBar
        '
        Me.MenuBar.Location = New System.Drawing.Point(0, 42)
        Me.MenuBar.Size = New System.Drawing.Size(504, 26)
        '
        'Delete
        '
        Me.Delete.Visible = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'Ok
        '
        Me.Ok.Visible = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'Cancel
        '
        Me.Cancel.Visible = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'NewRow
        '
        Me.NewRow.Visible = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'MainPanel
        '
        Me.MainPanel.Controls.Add(Me.TvwTrabajosOrigen)
        Me.MainPanel.Controls.Add(Me.FraConceptosVer)
        Me.MainPanel.Controls.Add(Me.Panel1)
        Me.MainPanel.Controls.Add(Me.Splitter1)
        Me.MainPanel.Controls.Add(Me.TvwTrabajos)
        Me.MainPanel.Controls.Add(Me.PnlCabecera)
        Me.MainPanel.Size = New System.Drawing.Size(784, 366)
        '
        'PnlCabecera
        '
        Me.PnlCabecera.Controls.Add(Me.lblObra)
        Me.PnlCabecera.Controls.Add(Me.txtDescObra)
        Me.PnlCabecera.Controls.Add(Me.txtNObra)
        Me.PnlCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlCabecera.Location = New System.Drawing.Point(0, 0)
        Me.PnlCabecera.Name = "PnlCabecera"
        Me.PnlCabecera.Size = New System.Drawing.Size(784, 32)
        Me.PnlCabecera.TabIndex = 44
        '
        'lblObra
        '
        Me.lblObra.Location = New System.Drawing.Point(6, 9)
        Me.lblObra.Name = "lblObra"
        Me.lblObra.Size = New System.Drawing.Size(75, 13)
        Me.lblObra.TabIndex = 8
        Me.lblObra.Tag = ""
        Me.lblObra.Text = "Nº Proyecto"
        '
        'txtDescObra
        '
        Me.txtDescObra.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TryDataBinding(txtDescObra, New System.Windows.Forms.Binding("Text", Me, "DescObra", True))
        Me.txtDescObra.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescObra.Enabled = False
        Me.txtDescObra.Location = New System.Drawing.Point(224, 5)
        Me.txtDescObra.Name = "txtDescObra"
        Me.txtDescObra.Size = New System.Drawing.Size(556, 21)
        Me.txtDescObra.TabIndex = 1
        Me.txtDescObra.TabStop = False
        '
        'txtNObra
        '
        Me.TryDataBinding(txtNObra, New System.Windows.Forms.Binding("Text", Me, "NObra", True))
        Me.txtNObra.DisabledBackColor = System.Drawing.Color.White
        Me.txtNObra.Enabled = False
        Me.txtNObra.Location = New System.Drawing.Point(84, 5)
        Me.txtNObra.Name = "txtNObra"
        Me.txtNObra.Size = New System.Drawing.Size(137, 23)
        Me.txtNObra.TabIndex = 0
        Me.txtNObra.TabStop = False
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(221, 32)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(5, 334)
        Me.Splitter1.TabIndex = 46
        Me.Splitter1.TabStop = False
        '
        'TvwTrabajos
        '
        Me.TvwTrabajos.AllowDrop = True
        Me.TvwTrabajos.Dock = System.Windows.Forms.DockStyle.Left
        Me.TvwTrabajos.Location = New System.Drawing.Point(0, 32)
        Me.TvwTrabajos.Name = "TvwTrabajos"
        Me.TvwTrabajos.Size = New System.Drawing.Size(221, 334)
        Me.TvwTrabajos.TabIndex = 45
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblObraOrigen)
        Me.Panel1.Controls.Add(Me.AdvObra)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(226, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(558, 32)
        Me.Panel1.TabIndex = 86
        '
        'lblObraOrigen
        '
        Me.lblObraOrigen.Location = New System.Drawing.Point(5, 9)
        Me.lblObraOrigen.Name = "lblObraOrigen"
        Me.lblObraOrigen.Size = New System.Drawing.Size(97, 13)
        Me.lblObraOrigen.TabIndex = 87
        Me.lblObraOrigen.Tag = ""
        Me.lblObraOrigen.Text = "Proyecto origen"
        '
        'AdvObra
        '
        Me.AdvObra.DisabledBackColor = System.Drawing.Color.White
        Me.AdvObra.DisplayField = "NObra"
        Me.AdvObra.EntityName = "ObraCabecera"
        Me.AdvObra.Location = New System.Drawing.Point(104, 5)
        Me.AdvObra.Name = "AdvObra"
        Me.AdvObra.SecondaryDataFields = "IDObra"
        Me.AdvObra.Size = New System.Drawing.Size(106, 23)
        Me.AdvObra.TabIndex = 86
        Me.AdvObra.ViewName = "tbObraCabecera"
        '
        'FraConceptosVer
        '
        Me.FraConceptosVer.Controls.Add(Me.chkVerTodos)
        Me.FraConceptosVer.Controls.Add(Me.rbtMinimizarTree)
        Me.FraConceptosVer.Controls.Add(Me.rbtMaximizarTree)
        Me.FraConceptosVer.Controls.Add(Me.cmbVerDatos)
        Me.FraConceptosVer.Controls.Add(Me.chkVerTareas)
        Me.FraConceptosVer.Controls.Add(Me.chkVerMediciones)
        Me.FraConceptosVer.Controls.Add(Me.chkVerVarios)
        Me.FraConceptosVer.Controls.Add(Me.chkVerGastos)
        Me.FraConceptosVer.Controls.Add(Me.chkVerCentros)
        Me.FraConceptosVer.Controls.Add(Me.chkVerMOD)
        Me.FraConceptosVer.Controls.Add(Me.chkVerMateriales)
        Me.FraConceptosVer.Controls.Add(Me.chkVerTrabajos)
        Me.FraConceptosVer.Dock = System.Windows.Forms.DockStyle.Top
        Me.FraConceptosVer.Location = New System.Drawing.Point(226, 64)
        Me.FraConceptosVer.Name = "FraConceptosVer"
        Me.FraConceptosVer.Size = New System.Drawing.Size(558, 71)
        Me.FraConceptosVer.TabIndex = 90
        Me.FraConceptosVer.TabStop = False
        Me.FraConceptosVer.Text = "Datos a visualizar"
        '
        'chkVerTodos
        '
        Me.chkVerTodos.Location = New System.Drawing.Point(348, 41)
        Me.chkVerTodos.Name = "chkVerTodos"
        Me.chkVerTodos.Size = New System.Drawing.Size(63, 21)
        Me.chkVerTodos.TabIndex = 235
        Me.chkVerTodos.Text = "Todos"
        '
        'rbtMinimizarTree
        '
        Me.rbtMinimizarTree.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbtMinimizarTree.Location = New System.Drawing.Point(420, 41)
        Me.rbtMinimizarTree.Name = "rbtMinimizarTree"
        Me.rbtMinimizarTree.Size = New System.Drawing.Size(77, 15)
        Me.rbtMinimizarTree.TabIndex = 234
        Me.rbtMinimizarTree.Text = "Minimizar"
        '
        'rbtMaximizarTree
        '
        Me.rbtMaximizarTree.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbtMaximizarTree.Location = New System.Drawing.Point(420, 21)
        Me.rbtMaximizarTree.Name = "rbtMaximizarTree"
        Me.rbtMaximizarTree.Size = New System.Drawing.Size(84, 16)
        Me.rbtMaximizarTree.TabIndex = 233
        Me.rbtMaximizarTree.Text = "Maximizar"
        '
        'cmbVerDatos
        '
        Me.cmbVerDatos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbVerDatos.Icon = CType(resources.GetObject("cmbVerDatos.Icon"), System.Drawing.Icon)
        Me.cmbVerDatos.Location = New System.Drawing.Point(515, 25)
        Me.cmbVerDatos.Name = "cmbVerDatos"
        Me.cmbVerDatos.Size = New System.Drawing.Size(28, 28)
        Me.cmbVerDatos.TabIndex = 232
        '
        'chkVerTareas
        '
        Me.chkVerTareas.Location = New System.Drawing.Point(273, 41)
        Me.chkVerTareas.Name = "chkVerTareas"
        Me.chkVerTareas.Size = New System.Drawing.Size(68, 21)
        Me.chkVerTareas.TabIndex = 8
        Me.chkVerTareas.Text = "Tareas"
        '
        'chkVerMediciones
        '
        Me.chkVerMediciones.Location = New System.Drawing.Point(186, 41)
        Me.chkVerMediciones.Name = "chkVerMediciones"
        Me.chkVerMediciones.Size = New System.Drawing.Size(81, 21)
        Me.chkVerMediciones.TabIndex = 9
        Me.chkVerMediciones.Text = "Mediciones"
        '
        'chkVerVarios
        '
        Me.chkVerVarios.Location = New System.Drawing.Point(99, 41)
        Me.chkVerVarios.Name = "chkVerVarios"
        Me.chkVerVarios.Size = New System.Drawing.Size(81, 21)
        Me.chkVerVarios.TabIndex = 7
        Me.chkVerVarios.Text = "Varios"
        '
        'chkVerGastos
        '
        Me.chkVerGastos.Location = New System.Drawing.Point(17, 41)
        Me.chkVerGastos.Name = "chkVerGastos"
        Me.chkVerGastos.Size = New System.Drawing.Size(75, 21)
        Me.chkVerGastos.TabIndex = 6
        Me.chkVerGastos.Text = "Gastos"
        '
        'chkVerCentros
        '
        Me.chkVerCentros.Location = New System.Drawing.Point(273, 18)
        Me.chkVerCentros.Name = "chkVerCentros"
        Me.chkVerCentros.Size = New System.Drawing.Size(68, 21)
        Me.chkVerCentros.TabIndex = 5
        Me.chkVerCentros.Text = "Centros"
        '
        'chkVerMOD
        '
        Me.chkVerMOD.Location = New System.Drawing.Point(186, 18)
        Me.chkVerMOD.Name = "chkVerMOD"
        Me.chkVerMOD.Size = New System.Drawing.Size(81, 21)
        Me.chkVerMOD.TabIndex = 4
        Me.chkVerMOD.Text = "M.O.D."
        '
        'chkVerMateriales
        '
        Me.chkVerMateriales.Location = New System.Drawing.Point(99, 18)
        Me.chkVerMateriales.Name = "chkVerMateriales"
        Me.chkVerMateriales.Size = New System.Drawing.Size(81, 21)
        Me.chkVerMateriales.TabIndex = 3
        Me.chkVerMateriales.Text = "Materiales"
        '
        'chkVerTrabajos
        '
        Me.chkVerTrabajos.Checked = True
        Me.chkVerTrabajos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkVerTrabajos.Enabled = False
        Me.chkVerTrabajos.Location = New System.Drawing.Point(17, 18)
        Me.chkVerTrabajos.Name = "chkVerTrabajos"
        Me.chkVerTrabajos.Size = New System.Drawing.Size(75, 21)
        Me.chkVerTrabajos.TabIndex = 2
        Me.chkVerTrabajos.TabStop = False
        Me.chkVerTrabajos.Text = "Trabajos"
        '
        'TvwTrabajosOrigen
        '
        Me.TvwTrabajosOrigen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TvwTrabajosOrigen.Location = New System.Drawing.Point(226, 135)
        Me.TvwTrabajosOrigen.Name = "TvwTrabajosOrigen"
        Me.TvwTrabajosOrigen.Size = New System.Drawing.Size(558, 231)
        Me.TvwTrabajosOrigen.TabIndex = 91
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        Me.ImageList1.Images.SetKeyName(2, "")
        Me.ImageList1.Images.SetKeyName(3, "")
        Me.ImageList1.Images.SetKeyName(4, "")
        Me.ImageList1.Images.SetKeyName(5, "")
        Me.ImageList1.Images.SetKeyName(6, "")
        Me.ImageList1.Images.SetKeyName(7, "")
        Me.ImageList1.Images.SetKeyName(8, "")
        Me.ImageList1.Images.SetKeyName(9, "")
        Me.ImageList1.Images.SetKeyName(10, "")
        Me.ImageList1.Images.SetKeyName(11, "")
        '
        'MntoCopiaObra
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(792, 439)
        Me.EntityName = "ObraCabecera"
        Me.Name = "MntoCopiaObra"
        Me.NavigationFields = "NObra"
        Me.ViewName = "frmMntoObras"
        CType(Me.ToolBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.PnlCabecera.ResumeLayout(False)
        Me.PnlCabecera.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.FraConceptosVer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Enum IconIndex
        oObras = 0
        oTrabajos = 1
        oMateriales = 2
        oMod = 3
        oCentros = 4
        oGastos = 5
        oVarios = 6
        oMediciones = 7
        oTareas = 8
        oCapitulos = 9
        oSubTrabajos = 11
    End Enum

    Private mblnGestionConstructoras, blnMarcoAll As Boolean

#Region " Load "

    Private Sub MntoCopiaObra_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        If Me.RecordsState = RecordsState.Saved Then
            Me.GotoRecord(DataProviderActions.GoFirst, New NumberFilterItem("IDObra", Me.CurrentRow("IDObra")))
        End If
    End Sub

    Private Sub MntoCopiaObra_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadNedeedData()
        LoadToolBarActions()
        LoadFormParams()
        LoadERPData()
        rbtMaximizarTree.Checked = True
        Configure()
    End Sub

    Private Sub LoadNedeedData()
        Dim nd As New NeededData
        nd.Name = "Trabajos"
        nd.EntityName = "ObraTrabajo"
        Dim s(0) As String
        s(0) = "IDObra"
        nd.PrimaryDataFields = s
        nd.SecondaryDataFields = s
        nd.RelationMode = RelationMode.ChildMode
        nd.ViewName = "vFrmObraTrabajos"

        Me.AddDataItem(nd)
    End Sub

    Private Sub LoadToolBarActions()
        Me.FormActions.Add("Abrir Proyecto", AddressOf AccionAbrirObra, ExpertisApp.GetIcon("xProyectos.ico"))
    End Sub

    Private Sub AccionAbrirObra()
        ExpertisApp.OpenForm("MGEO", New NumberFilterItem("IDObra", Me.CurrentRow("IDObra")))
    End Sub

    Private Sub LoadFormParams()
        If Not IsNothing(Me.Params) Then
            Dim ht As Hashtable = Me.Params
            Dim intIDObra As Integer = Nz(ht("IDObra"), 0)

            If intIDObra <> 0 Then
                Dim objFilterCriteria As New Filter
                objFilterCriteria.Add("IDObra", FilterOperator.Equal, intIDObra)
                GotoRecord(DataProviderActions.GoFirst, objFilterCriteria, Me.CurrentData)
            End If
        End If
    End Sub

    Private Sub LoadERPData()
        mblnGestionConstructoras = New Parametro().GestionConstructoras
    End Sub

    Private Sub Configure()
        chkVerMediciones.Visible = mblnGestionConstructoras
        If Not chkVerMediciones.Visible Then
            chkVerTareas.Left = chkVerMOD.Left
            chkVerTodos.Left = chkVerCentros.Left
        End If
    End Sub

#End Region

    Private Sub MntoObras_Navigated(ByVal sender As Object, ByVal e As Solmicro.Expertis.Engine.UI.NavigatedEventArgs) Handles MyBase.Navigated
        If Not Me.CurrentRow Is Nothing Then
            Dim dtTrabajos As DataTable = Me.LastRetriveData.Tables("Trabajos")

            TvwTrabajos.Nodes.Clear()
            Dim strText As String = Me.CurrentRow("NObra") & " -> " & Me.CurrentRow("DescObra")
            Dim oNode As TreeNode = TvwTrabajos.Nodes.Add(strText)
            oNode.Tag = New NodoTag(Me.CurrentRow("IDObra"), 0, 0, IconIndex.oObras)
            oNode.ImageIndex = IconIndex.oObras
            oNode.SelectedImageIndex = IconIndex.oObras
            oNode.Expand()

            PintarTrabajos(TvwTrabajos, dtTrabajos, oNode, True)
        End If
    End Sub

#Region " Pintar Arboles "

#Region " Trabajos "

    Private Sub PintarTrabajos(ByVal tvwTreeViewObj As TreeView, ByVal dtTrabajos As DataTable, _
                               Optional ByVal oNode As TreeNode = Nothing, _
                               Optional ByVal blnSoloTrabajos As Boolean = False)

        If Not dtTrabajos Is Nothing AndAlso dtTrabajos.Rows.Count > 0 Then
            If Not tvwTreeViewObj.Enabled Then tvwTreeViewObj.Enabled = True
            tvwTreeViewObj.ImageList = ImageList1
            For Each drTrabajo As DataRow In dtTrabajos.Select
                If IsDBNull(drTrabajo("IDTrabajoPadre")) AndAlso drTrabajo("TipoLinea") <> enumTipoLineaTrabajo.tltPorcentajeConcepto Then
                    PintarNodoTrabajo(tvwTreeViewObj, drTrabajo, dtTrabajos, oNode, blnSoloTrabajos)
                End If
            Next
        End If

        If blnSoloTrabajos Then
            tvwTreeViewObj.ExpandAll()
        ElseIf rbtMaximizarTree.Checked Then
            tvwTreeViewObj.ExpandAll()
        End If
        tvwTreeViewObj.Refresh()
    End Sub

    Private Sub PintarNodoTrabajo(ByVal tvwTreeViewObj As TreeView, ByVal drTrabajo As DataRow, _
                                  ByVal dtTrabajos As DataTable, _
                                  Optional ByVal oNode As TreeNode = Nothing, _
                                  Optional ByVal blnSoloTrabajos As Boolean = False)

        Dim strText As String = drTrabajo("CodTrabajo") & " -> " & drTrabajo("DescTrabajo")
        If oNode Is Nothing Then
            oNode = tvwTreeViewObj.Nodes.Add(strText)
        Else
            oNode = oNode.Nodes.Add(strText)
        End If
        oNode.Tag = New NodoTag(drTrabajo("IdObra"), drTrabajo("IdTrabajo"), drTrabajo("IdTrabajo"), IconIndex.oTrabajos, drTrabajo("Estado"))
        If drTrabajo("TipoLinea") = enumTipoLineaTrabajo.tltTrabajo Then
            'oNode.ImageIndex = IconIndex.oTrabajos
            If Nz(drTrabajo("ImpPrevQTrabajoA"), 0) = 0 Then
                oNode.ImageIndex = IconIndex.oSubTrabajos
            Else
                oNode.ImageIndex = IconIndex.oTrabajos
            End If
        ElseIf drTrabajo("TipoLinea") = enumTipoLineaTrabajo.tltCapitulo Then
            oNode.ImageIndex = IconIndex.oCapitulos
        End If
        oNode.SelectedImageIndex = oNode.ImageIndex
        oNode.Expand()

        If Not blnSoloTrabajos Then
            Dim f As New Filter
            f.Add("IDTrabajo", drTrabajo("IdTrabajo"))

            'pintar materiales
            If chkVerMateriales.Checked Then
                Dim OM As New ObraMaterial
                Dim dtMateriales As DataTable = OM.Filter(f)
                PintarMateriales(tvwTreeViewObj, dtMateriales, oNode)
            End If
            'pintar mod
            If chkVerMOD.Checked Then
                Dim OMod As New ObraMOD
                Dim dtMod As DataTable = OMod.Filter(f)
                PintarMOD(tvwTreeViewObj, dtMod, oNode)
            End If
            'pintar centros
            If chkVerCentros.Checked Then
                Dim OC As New ObraCentro
                Dim dtC As DataTable = OC.Filter(f)
                PintarCentros(tvwTreeViewObj, dtC, oNode)
            End If
            'pintar gastos
            If chkVerGastos.Checked Then
                Dim OG As New ObraGasto
                Dim dtG As DataTable = OG.Filter(f)
                PintarGastos(tvwTreeViewObj, dtG, oNode)
            End If
            'pintar varios
            If chkVerVarios.Checked Then
                Dim OV As New ObraVarios
                Dim dtV As DataTable = OV.Filter(f)
                PintarVarios(tvwTreeViewObj, dtV, oNode)
            End If
            'pintar tareas
            If chkVerTareas.Checked Then
                Dim OT As New ObraTarea
                Dim dtT As DataTable = OT.Filter(f)
                PintarTareas(tvwTreeViewObj, dtT, oNode)
            End If
            'pintar mediciones
            If chkVerMediciones.Checked Then
                Dim OME As New ObraMedicion
                Dim dtME As DataTable = OME.Filter(f)
                PintarMediciones(tvwTreeViewObj, dtME, oNode)
            End If
        End If

        'pintar sus subtrabajos
        Dim dv As DataView = dtTrabajos.DefaultView
        dv.RowFilter = "IDTrabajoPadre = " & drTrabajo("IdTrabajo")
        For Each drv As DataRowView In dv
            PintarNodoTrabajo(tvwTreeViewObj, drv.Row, dtTrabajos, oNode, blnSoloTrabajos)
        Next

        oNode = Nothing
    End Sub

#End Region

#Region " Materiales "
    Private Sub PintarMateriales(ByVal tvwTreeViewObj As TreeView, ByVal dtMateriales As DataTable, _
                                 Optional ByVal oNode As TreeNode = Nothing)

        If Not dtMateriales Is Nothing AndAlso dtMateriales.Rows.Count > 0 Then
            oNode = oNode.Nodes.Add("MATERIALES")
            oNode.Tag = New NodoTag(dtMateriales.Rows(0)("IDObra"), dtMateriales.Rows(0)("IDTrabajo"), 0, IconIndex.oMateriales)
            oNode.ImageIndex = IconIndex.oMateriales
            oNode.SelectedImageIndex = IconIndex.oMateriales
            For Each drMaterial As DataRow In dtMateriales.Select
                If IsDBNull(drMaterial("IDLineaMaterialPadre")) Then
                    PintarNodoMaterial(tvwTreeViewObj, drMaterial("IDMaterial") & String.Empty, _
                                       drMaterial("DescMaterial") & String.Empty, drMaterial("QPrev"), _
                                       drMaterial("IdLineaMaterial"), drMaterial("IdTrabajo"), _
                                       drMaterial("IdObra"), dtMateriales, oNode)
                End If
            Next
        End If

    End Sub

    Private Sub PintarNodoMaterial(ByVal tvwTreeViewObj As TreeView, ByVal strIDMaterial As String, _
                                   ByVal strDescMaterial As String, ByVal dblQPrev As Double, _
                                   ByVal intIdLineaMaterial As Integer, ByVal intIdTrabajo As Integer, _
                                   ByVal intIdObra As Integer, ByVal dtMateriales As DataTable, _
                                   Optional ByVal oNode As TreeNode = Nothing)

        Dim strText As String = "Artículo: " & strIDMaterial & " - " & strDescMaterial & "  Cantidad Prev. Total: " & dblQPrev
        If oNode Is Nothing Then
            oNode = tvwTreeViewObj.Nodes.Add(strText)
        Else
            oNode = oNode.Nodes.Add(strText)
        End If
        oNode.Tag = New NodoTag(intIdObra, intIdTrabajo, intIdLineaMaterial, IconIndex.oMateriales)
        oNode.ImageIndex = IconIndex.oMateriales
        oNode.SelectedImageIndex = IconIndex.oMateriales

        'pintar sus materiales
        Dim dv As DataView = dtMateriales.DefaultView
        dv.RowFilter = "IDLineaMaterialPadre = " & intIdLineaMaterial
        For Each drv As DataRowView In dv
            PintarNodoMaterial(tvwTreeViewObj, drv.Row("IDMaterial") & String.Empty, _
                               drv.Row("DescMaterial") & String.Empty, drv.Row("QPrev"), _
                               drv.Row("IdLineaMaterial"), drv.Row("IdTrabajo"), intIdObra, _
                               dtMateriales, oNode)
        Next

        oNode = Nothing
    End Sub

#End Region

#Region " MOD "
    Private Sub PintarMOD(ByVal tvwTreeViewObj As TreeView, ByVal dtMOD As DataTable, _
                          Optional ByVal oNode As TreeNode = Nothing)

        If Not dtMOD Is Nothing AndAlso dtMOD.Rows.Count > 0 Then
            oNode = oNode.Nodes.Add("MOD")
            oNode.Tag = New NodoTag(dtMOD.Rows(0)("IDObra"), dtMOD.Rows(0)("IDTrabajo"), 0, IconIndex.oMod)
            oNode.ImageIndex = IconIndex.oMod
            oNode.SelectedImageIndex = IconIndex.oMod
            For Each drMOD As DataRow In dtMOD.Select
                PintarNodoMOD(tvwTreeViewObj, drMOD("IDCategoria") & String.Empty, _
                              drMOD("DescCategoria") & String.Empty, drMOD("DesHora") & String.Empty, _
                              drMOD("IdLineaMOD"), drMOD("IDTrabajo"), drMOD("IDObra"), oNode)
            Next
            oNode = Nothing
        End If

    End Sub

    Private Sub PintarNodoMOD(ByVal tvwTreeViewObj As TreeView, ByVal strIDCategoria As String, _
                              ByVal strDescCategoria As String, ByVal strDescHora As String, _
                              ByVal intIdLineaMOD As Integer, ByVal intIdTrabajo As Integer, _
                              ByVal intIdObra As Integer, Optional ByVal oNode As TreeNode = Nothing)

        Dim strText As String = "Categoría: " & strIDCategoria & " - " & strDescCategoria & "  Tipo Hora: " & strDescHora
        If oNode Is Nothing Then
            oNode = tvwTreeViewObj.Nodes.Add(strText)
        Else
            oNode = oNode.Nodes.Add(strText)
        End If
        oNode.Tag = New NodoTag(intIdObra, intIdTrabajo, intIdLineaMOD, IconIndex.oMod)
        oNode.ImageIndex = IconIndex.oMod
        oNode.SelectedImageIndex = IconIndex.oMod

        oNode = Nothing
    End Sub
#End Region

#Region " Centros "
    Private Sub PintarCentros(ByVal tvwTreeViewObj As TreeView, ByVal dtCentros As DataTable, _
                              Optional ByVal oNode As TreeNode = Nothing)

        If Not dtCentros Is Nothing AndAlso dtCentros.Rows.Count > 0 Then
            oNode = oNode.Nodes.Add("CENTROS")
            oNode.Tag = New NodoTag(dtCentros.Rows(0)("IDObra"), dtCentros.Rows(0)("IDTrabajo"), 0, IconIndex.oCentros)
            oNode.ImageIndex = IconIndex.oCentros
            oNode.SelectedImageIndex = IconIndex.oCentros
            For Each drCentros As DataRow In dtCentros.Select
                PintarNodoCentros(tvwTreeViewObj, drCentros("IDCentro") & String.Empty, _
                                  drCentros("DescCentro") & String.Empty, drCentros("IDLineaCentro"), _
                                  drCentros("IDTrabajo"), drCentros("IDObra"), oNode)
            Next
            oNode = Nothing
        End If
    End Sub

    Private Sub PintarNodoCentros(ByVal tvwTreeViewObj As TreeView, ByVal strIDCentro As String, _
                                  ByVal strDescCentro As String, ByVal intIDLineaCentro As Integer, _
                                  ByVal intIdTrabajo As Integer, ByVal intIdObra As Integer, _
                                  Optional ByVal oNode As TreeNode = Nothing)

        Dim strText As String = "Centro: " & strIDCentro & " - " & strDescCentro
        If oNode Is Nothing Then
            oNode = tvwTreeViewObj.Nodes.Add(strText)
        Else
            oNode = oNode.Nodes.Add(strText)
        End If
        oNode.Tag = New NodoTag(intIdObra, intIdTrabajo, intIDLineaCentro, IconIndex.oCentros)
        oNode.ImageIndex = IconIndex.oCentros
        oNode.SelectedImageIndex = IconIndex.oCentros

        oNode = Nothing
    End Sub
#End Region

#Region " Gastos "
    Private Sub PintarGastos(ByVal tvwTreeViewObj As TreeView, ByVal dtGastos As DataTable, _
                              Optional ByVal oNode As TreeNode = Nothing)

        If Not dtGastos Is Nothing AndAlso dtGastos.Rows.Count > 0 Then
            oNode = oNode.Nodes.Add("GASTOS")
            oNode.Tag = New NodoTag(dtGastos.Rows(0)("IDObra"), dtGastos.Rows(0)("IDTrabajo"), 0, IconIndex.oGastos)
            oNode.ImageIndex = IconIndex.oGastos
            oNode.SelectedImageIndex = IconIndex.oGastos
            For Each drGastos As DataRow In dtGastos.Select
                PintarNodoGastos(tvwTreeViewObj, drGastos("IDGasto") & String.Empty, _
                                 drGastos("DescGasto") & String.Empty, drGastos("IDLineaGasto"), _
                                 drGastos("IDTrabajo"), drGastos("IDObra"), oNode)
            Next
            oNode = Nothing
        End If
    End Sub

    Private Sub PintarNodoGastos(ByVal tvwTreeViewObj As TreeView, ByVal strIDGasto As String, _
                                 ByVal strDescGasto As String, ByVal intIDLineaGasto As Integer, _
                                 ByVal intIdTrabajo As Integer, ByVal intIdObra As Integer, _
                                 Optional ByVal oNode As TreeNode = Nothing)

        Dim strText As String = "Gasto: " & strIDGasto & " - " & strDescGasto
        If oNode Is Nothing Then
            oNode = tvwTreeViewObj.Nodes.Add(strText)
        Else
            oNode = oNode.Nodes.Add(strText)
        End If
        oNode.Tag = New NodoTag(intIdObra, intIdTrabajo, intIDLineaGasto, IconIndex.oGastos)
        oNode.ImageIndex = IconIndex.oGastos
        oNode.SelectedImageIndex = IconIndex.oGastos
        'oNode.Expand()

        oNode = Nothing
    End Sub
#End Region

#Region " Varios "
    Private Sub PintarVarios(ByVal tvwTreeViewObj As TreeView, ByVal dtVarios As DataTable, _
                             Optional ByVal oNode As TreeNode = Nothing)

        If Not dtVarios Is Nothing AndAlso dtVarios.Rows.Count > 0 Then
            oNode = oNode.Nodes.Add("VARIOS")
            oNode.Tag = New NodoTag(dtVarios.Rows(0)("IDObra"), dtVarios.Rows(0)("IDTrabajo"), 0, IconIndex.oVarios)
            oNode.ImageIndex = IconIndex.oVarios
            oNode.SelectedImageIndex = IconIndex.oVarios
            For Each drVarios As DataRow In dtVarios.Select
                PintarNodoVarios(tvwTreeViewObj, drVarios("IDVarios") & String.Empty, _
                                 drVarios("DescVarios") & String.Empty, drVarios("IDLineaVarios"), _
                                 drVarios("IDTrabajo"), drVarios("IDObra"), oNode)
            Next
            oNode = Nothing
        End If
    End Sub

    Private Sub PintarNodoVarios(ByVal tvwTreeViewObj As TreeView, ByVal strIDVarios As String, _
                                 ByVal strDescVarios As String, ByVal intIDLineaVarios As Integer, _
                                 ByVal intIdTrabajo As Integer, ByVal intIdObra As Integer, _
                                 Optional ByVal oNode As TreeNode = Nothing)

        Dim strText As String = "Varios: " & strIDVarios & " - " & strDescVarios
        If oNode Is Nothing Then
            oNode = tvwTreeViewObj.Nodes.Add(strText)
        Else
            oNode = oNode.Nodes.Add(strText)
        End If
        oNode.Tag = New NodoTag(intIdObra, intIdTrabajo, intIDLineaVarios, IconIndex.oVarios)
        oNode.ImageIndex = IconIndex.oVarios
        oNode.SelectedImageIndex = IconIndex.oVarios
        'oNode.Expand()

        oNode = Nothing
    End Sub
#End Region

#Region " Mediciones "
    Private Sub PintarMediciones(ByVal tvwTreeViewObj As TreeView, ByVal dtMedicion As DataTable, _
                             Optional ByVal oNode As TreeNode = Nothing)

        If Not dtMedicion Is Nothing AndAlso dtMedicion.Rows.Count > 0 Then
            oNode = oNode.Nodes.Add("MEDICIONES")
            oNode.Tag = New NodoTag(dtMedicion.Rows(0)("IDObra"), dtMedicion.Rows(0)("IDTrabajo"), 0, IconIndex.oMediciones)
            oNode.ImageIndex = IconIndex.oMediciones
            oNode.SelectedImageIndex = IconIndex.oMediciones
            For Each drMedicion As DataRow In dtMedicion.Select
                PintarNodoMediciones(tvwTreeViewObj, drMedicion("DescMedicion") & String.Empty, Nz(drMedicion("QPI"), 0), Nz(drMedicion("Largo"), 0), _
                                     Nz(drMedicion("Ancho"), 0), Nz(drMedicion("Alto"), 0), _
                                     Nz(drMedicion("Total"), 0), drMedicion("IdLineaMedicion"), _
                                     drMedicion("IDTrabajo"), drMedicion("IDObra"), oNode)
            Next
            oNode = Nothing
        End If
    End Sub

    Private Sub PintarNodoMediciones(ByVal tvwTreeViewObj As TreeView, ByVal strDescMedicion As String, _
                                     ByVal dblQPI As Double, ByVal dblLargo As Double, _
                                     ByVal dblAncho As Double, ByVal dblAlto As Double, _
                                     ByVal dblTotal As Double, ByVal intIDLineaMedicion As Integer, _
                                     ByVal intIdTrabajo As Integer, ByVal intIDObra As Integer, _
                                     Optional ByVal oNode As TreeNode = Nothing)

        Dim strText As String = "Descripción: " & strDescMedicion & " PI: " & dblQPI & " LARGO: " & dblLargo & " ANCHO: " & dblAncho & " ALTO: " & dblAlto & " TOTAL: " & dblTotal
        If oNode Is Nothing Then
            oNode = tvwTreeViewObj.Nodes.Add(strText)
        Else
            oNode = oNode.Nodes.Add(strText)
        End If
        oNode.Tag = New NodoTag(intIDObra, intIdTrabajo, intIDLineaMedicion, IconIndex.oMediciones)
        oNode.ImageIndex = IconIndex.oMediciones
        oNode.SelectedImageIndex = IconIndex.oMediciones
        'oNode.Expand()

        oNode = Nothing
    End Sub
#End Region

#Region " Tareas "
    Private Sub PintarTareas(ByVal tvwTreeViewObj As TreeView, ByVal dtTareas As DataTable, _
                             Optional ByVal oNode As TreeNode = Nothing)

        If Not dtTareas Is Nothing AndAlso dtTareas.Rows.Count > 0 Then
            oNode = oNode.Nodes.Add("TAREAS")
            oNode.Tag = New NodoTag(dtTareas.Rows(0)("IDObra"), dtTareas.Rows(0)("IDTrabajo"), 0, IconIndex.oTareas)
            oNode.ImageIndex = IconIndex.oTareas
            oNode.SelectedImageIndex = IconIndex.oTareas
            For Each drTareas As DataRow In dtTareas.Select
                PintarNodoTareas(tvwTreeViewObj, drTareas("IDTarea") & String.Empty, _
                                 drTareas("DescTarea") & String.Empty, drTareas("NTarea") & String.Empty, _
                                 drTareas("IDTrabajo"), drTareas("IDObra"), oNode)
            Next
            oNode = Nothing
        End If
    End Sub

    Private Sub PintarNodoTareas(ByVal tvwTreeViewObj As TreeView, ByVal intIDTarea As Integer, _
                                 ByVal strDescTarea As String, ByVal strNTarea As String, _
                                 ByVal intIdTrabajo As Integer, ByVal intIdObra As Integer, _
                                 Optional ByVal oNode As TreeNode = Nothing)

        Dim strText As String = "Tarea: " & strNTarea & " - " & strDescTarea
        If oNode Is Nothing Then
            oNode = tvwTreeViewObj.Nodes.Add(strText)
        Else
            oNode = oNode.Nodes.Add(strText)
        End If
        oNode.Tag = New NodoTag(intIdObra, intIdTrabajo, intIDTarea, IconIndex.oTareas)
        oNode.ImageIndex = IconIndex.oTareas
        oNode.SelectedImageIndex = IconIndex.oTareas
        'oNode.Expand()

        oNode = Nothing
    End Sub
#End Region

#End Region

    Private Sub AdvObra_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles AdvObra.SetPredefinedFilter
        e.Filter.Add(New StringFilterItem("IDTipoObra", Me.CurrentRow("IDTipoObra")))
        e.Filter.Add(New NumberFilterItem("IDObra", FilterOperator.NotEqual, Me.CurrentRow("IDObra")))
    End Sub

    Private Sub cmbVerDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbVerDatos.Click
        If length(AdvObra.Value) > 0 And chkVerTrabajos.Checked Then
            Dim dt As DataTable = New ObraTrabajo().Filter(New FilterItem("IDObra", FilterOperator.Equal, AdvObra.Value))
            TvwTrabajosOrigen.Nodes.Clear()
            Dim strText As String = AdvObra.Text
            Dim oNode As TreeNode = TvwTrabajosOrigen.Nodes.Add(strText)
            oNode.Tag = New NodoTag(AdvObra.Value, 0, 0, IconIndex.oObras)
            oNode.ImageIndex = IconIndex.oObras
            oNode.SelectedImageIndex = IconIndex.oObras
            oNode.Expand()

            PintarTrabajos(TvwTrabajosOrigen, dt, oNode)
        Else
            TvwTrabajosOrigen.Nodes.Clear()
        End If
    End Sub

#Region " Tratamiento Checks "

    Private Sub TodosMarcados()
        Dim blnMediciones As Boolean = True
        If chkVerMediciones.Visible Then blnMediciones = chkVerMediciones.Checked

        If chkVerMateriales.Checked And chkVerMOD.Checked And chkVerCentros.Checked And chkVerGastos.Checked And chkVerVarios.Checked And blnMediciones And chkVerTareas.Checked Then
            chkVerTodos.Checked = True
        Else
            chkVerTodos.Checked = False
        End If
    End Sub

    Private Sub Conceptos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkVerMateriales.CheckedChanged, chkVerMOD.CheckedChanged, chkVerCentros.CheckedChanged, chkVerGastos.CheckedChanged, chkVerVarios.CheckedChanged, chkVerMediciones.CheckedChanged, chkVerTareas.CheckedChanged
        If Not blnMarcoAll Then TodosMarcados()
    End Sub

    Private Sub chkAddTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkVerTodos.CheckedChanged
        blnMarcoAll = True
        If chkVerTodos.Checked Then
            chkVerMateriales.Checked = chkVerTodos.Checked
            chkVerMOD.Checked = chkVerTodos.Checked
            chkVerCentros.Checked = chkVerTodos.Checked
            chkVerGastos.Checked = chkVerTodos.Checked
            chkVerVarios.Checked = chkVerTodos.Checked
            chkVerMediciones.Checked = chkVerTodos.Checked
            chkVerTareas.Checked = chkVerTodos.Checked
        End If
        chkVerTodos.Enabled = Not chkVerTodos.Checked
        blnMarcoAll = False
    End Sub

#End Region

#Region " TAGs "
    Private Class NodoTag
        Public IDTrabajo, IDObra, ID, EstadoTrabajo, oType As Integer

        Public Sub New(ByVal IDObra As Integer, ByVal IDTrabajo As Integer, ByVal ID As Integer, _
                       ByVal oType As IconIndex, Optional ByVal EstadoTrabajo As Integer = -1)
            Me.IDObra = IDObra
            Me.IDTrabajo = IDTrabajo
            Me.ID = ID
            Me.oType = oType
            Me.EstadoTrabajo = EstadoTrabajo
        End Sub
    End Class

#End Region

#Region " DragDrop "

#Region " Origen "

    Private Sub TvwTrabajosOrigen_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TvwTrabajosOrigen.MouseDown
        If e.Button = MouseButtons.Left Then
            Dim node As TreeNode = TvwTrabajosOrigen.GetNodeAt(New System.Drawing.Point(e.X, e.Y))
            If Not IsNothing(node) Then
                TvwTrabajosOrigen.SelectedNode = node
                TvwTrabajosOrigen.AllowDrop = True
                TvwTrabajosOrigen.DoDragDrop(node.Tag, DragDropEffects.All)
            End If
        End If
    End Sub

    Private Sub TvwTrabajosOrigen_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TvwTrabajosOrigen.DragOver
        e.Effect = DragDropEffects.Move
    End Sub

#End Region

#Region " Destino "

    'Nodo sobre el que se encuentra el mouse.
    Private Sub TvwTrabajos_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TvwTrabajos.DragOver
        If e.Data.GetDataPresent(GetType(NodoTag)) Then
            Dim node As TreeNode = TvwTrabajos.GetNodeAt(TvwTrabajos.PointToClient(New System.Drawing.Point(e.X, e.Y)))
            If Not node Is Nothing Then
                If CType(node.Tag, NodoTag).oType = IconIndex.oObras OrElse CType(node.Tag, NodoTag).EstadoTrabajo <> enumotEstado.otTerminado Then
                    TvwTrabajos.SelectedNode = node
                End If
            End If
        End If
    End Sub

    'Cambiar el icono al entrar en el objeto sobre el que vamos a copiar.
    Private Sub TvwTrabajos_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TvwTrabajos.DragEnter
        If e.Data.GetDataPresent(GetType(NodoTag)) Then
            If Me.CurrentRow("Estado") <> enumocEstado.ocTerminado AndAlso length(Me.CurrentRow("IDTipoObra")) > 0 Then
                e.Effect = DragDropEffects.Copy
            End If
        End If
    End Sub

    'Copiamos
    Private Sub TvwTrabajos_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TvwTrabajos.DragDrop
        If e.Data.GetDataPresent(GetType(NodoTag)) Then
            Dim node As TreeNode = TvwTrabajos.GetNodeAt(TvwTrabajos.PointToClient(New System.Drawing.Point(e.X, e.Y)))
            Dim n As NodoTag = e.Data.GetData(GetType(NodoTag))

            Dim intTypeOrigen As Integer = n.oType
            Dim intIDObraOrigen As Integer = n.IDObra
            Dim intIDTrabajoOrigen As Integer = n.IDTrabajo
            Dim intIDOrigen As Integer = n.ID
            Dim intTrabajoDestino As Integer = CType(node.Tag, NodoTag).IDTrabajo
            Dim blnFacturable As Boolean
            If Me.CurrentRow("IDClase") = CInt(enumClaseObra.Control) Then
                blnFacturable = False
            Else
                Dim DtTrab As DataTable = New ObraTrabajo().SelOnPrimaryKey(n.ID)
                If Not DtTrab Is Nothing AndAlso DtTrab.Rows.Count > 0 Then
                    blnFacturable = DtTrab.Rows(0)("Facturable")
                Else
                    blnFacturable = True
                End If
            End If

            Dim datosCopia As New dataCopiaConceptoObra(Me.CurrentRow("IDObra"), intIDTrabajoOrigen, intTrabajoDestino, intIDOrigen, True, blnFacturable)

            Select Case intTypeOrigen
                Case IconIndex.oObras
                    CopiaObra()
                Case IconIndex.oTrabajos, IconIndex.oCapitulos, IconIndex.oSubTrabajos
                    CopiaTrabajos(intIDObraOrigen, intTrabajoDestino, intIDTrabajoOrigen, blnFacturable)
                Case IconIndex.oMateriales
                    ExpertisApp.ExecuteTask(Of dataCopiaConceptoObra)(AddressOf ObraCabecera.CopiarMateriales, datosCopia)
                Case IconIndex.oMod
                    ExpertisApp.ExecuteTask(Of dataCopiaConceptoObra)(AddressOf ObraCabecera.CopiarMod, datosCopia)
                Case IconIndex.oCentros
                    ExpertisApp.ExecuteTask(Of dataCopiaConceptoObra)(AddressOf ObraCabecera.CopiarCentro, datosCopia)
                Case IconIndex.oGastos
                    ExpertisApp.ExecuteTask(Of dataCopiaConceptoObra)(AddressOf ObraCabecera.CopiarGasto, datosCopia)
                Case IconIndex.oVarios
                    ExpertisApp.ExecuteTask(Of dataCopiaConceptoObra)(AddressOf ObraCabecera.CopiarVarios, datosCopia)
                Case IconIndex.oTareas
                    datosCopia.IDTarea = intIDOrigen
                    ExpertisApp.ExecuteTask(Of dataCopiaConceptoObra)(AddressOf ObraCabecera.CopiarTareas, datosCopia)
                Case IconIndex.oMediciones
                    ExpertisApp.ExecuteTask(Of dataCopiaConceptoObra)(AddressOf ObraCabecera.CopiarMediciones, datosCopia)
            End Select

            Dim oFilter As New Filter
            oFilter.Add(New NumberFilterItem("IDObra", Me.CurrentRow("IDObra")))
            Me.GotoRecord(DataProviderActions.GoFirst, oFilter)

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub CopiaObra()
        Dim frm As New FrmCopiaObra
        frm.VerContador = False
        frm.VerClaseObra = False
        frm.VerMediciones = chkVerMediciones.Visible

        If frm.ShowDialog = DialogResult.OK Then
            Me.Cursor = Cursors.WaitCursor

            Dim infoCopia As New dataCopiaObra(AdvObra.Value)
            infoCopia.IDDestino = Me.CurrentRow("IDObra")
            infoCopia.ConfiguracionCopia = frm.ConfiguracionCopia
            infoCopia.Recalcular = True
            infoCopia.Facturable = True
            If Length(infoCopia.ConfiguracionCopia.IDContador) = 0 AndAlso Length(Me.CurrentRow("IDContador")) > 0 Then
                infoCopia.ConfiguracionCopia.IDContador = Me.CurrentRow("IDContador")
            End If
            infoCopia.GenerarCabecera = False
            ExpertisApp.ExecuteTask(Of dataCopiaObra, ResultadoCopiaObra)(AddressOf ObraCabecera.CopiarObra, infoCopia)

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub CopiaTrabajos(ByVal IDObraOrigen As Integer, ByVal IDTrabajoDestino As Integer, ByVal IDTrabajoOrigen As Integer, ByVal Facturable As Boolean)
        Dim frm As New FrmCopiaObra
        frm.VerContador = False
        frm.VerClaseObra = False
        If frm.ShowDialog = DialogResult.OK Then
            Me.Cursor = Cursors.WaitCursor

            Dim infoCopiaobra As New dataCopiaObra(IDObraOrigen)
            infoCopiaobra.IDDestino = Me.CurrentRow("IDObra")
            infoCopiaobra.IDTrabajoDestino = IDTrabajoDestino
            infoCopiaobra.IDTrabajoOrigen = IDTrabajoOrigen
            infoCopiaobra.ConfiguracionCopia = frm.ConfiguracionCopia
            infoCopiaobra.Recalcular = True
            infoCopiaobra.CopiarPorcentajes = False
            infoCopiaobra.Facturable = Facturable
            If Length(infoCopiaobra.ConfiguracionCopia.IDContador) = 0 AndAlso Length(Me.CurrentRow("IDContador")) > 0 Then
                infoCopiaobra.ConfiguracionCopia.IDContador = Me.CurrentRow("IDContador")
            End If

            ExpertisApp.ExecuteTask(Of dataCopiaObra)(AddressOf ObraCabecera.CopiarTrabajo, infoCopiaobra)

            Me.Cursor = Cursors.Default
        End If
    End Sub

#End Region

#End Region

End Class
