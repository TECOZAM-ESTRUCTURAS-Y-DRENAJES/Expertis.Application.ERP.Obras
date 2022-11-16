Public Class frmEstructuraObra
    Inherits Solmicro.Expertis.Engine.UI.FormBase

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
    Friend WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents FraConceptosVer As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents chkVerMediciones As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkVerVarios As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkVerGastos As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkVerCentros As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkVerMOD As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkVerMateriales As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkVerTrabajos As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents cmbVerDatos As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents rbtMinimizarTree As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents rbtMaximizarTree As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents CmbCerrar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents TvwEstructura As System.Windows.Forms.TreeView
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEstructuraObra))
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.CmbCerrar = New Solmicro.Expertis.Engine.UI.Button
        Me.FraConceptosVer = New Solmicro.Expertis.Engine.UI.Frame
        Me.rbtMinimizarTree = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.rbtMaximizarTree = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.cmbVerDatos = New Solmicro.Expertis.Engine.UI.Button
        Me.chkVerMediciones = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkVerVarios = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkVerGastos = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkVerCentros = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkVerMOD = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkVerMateriales = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkVerTrabajos = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.TvwEstructura = New System.Windows.Forms.TreeView
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1.suspendlayout()
        Me.FraConceptosVer.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CmbCerrar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 538)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(675, 42)
        Me.Panel1.TabIndex = 231
        '
        'CmbCerrar
        '
        Me.CmbCerrar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.CmbCerrar.Location = New System.Drawing.Point(290, 7)
        Me.CmbCerrar.Name = "CmbCerrar"
        Me.CmbCerrar.Size = New System.Drawing.Size(94, 29)
        Me.CmbCerrar.TabIndex = 25
        Me.CmbCerrar.Text = "Cerrar"
        '
        'FraConceptosVer
        '
        Me.FraConceptosVer.Controls.Add(Me.rbtMinimizarTree)
        Me.FraConceptosVer.Controls.Add(Me.rbtMaximizarTree)
        Me.FraConceptosVer.Controls.Add(Me.cmbVerDatos)
        Me.FraConceptosVer.Controls.Add(Me.chkVerMediciones)
        Me.FraConceptosVer.Controls.Add(Me.chkVerVarios)
        Me.FraConceptosVer.Controls.Add(Me.chkVerGastos)
        Me.FraConceptosVer.Controls.Add(Me.chkVerCentros)
        Me.FraConceptosVer.Controls.Add(Me.chkVerMOD)
        Me.FraConceptosVer.Controls.Add(Me.chkVerMateriales)
        Me.FraConceptosVer.Controls.Add(Me.chkVerTrabajos)
        Me.FraConceptosVer.Dock = System.Windows.Forms.DockStyle.Top
        Me.FraConceptosVer.Location = New System.Drawing.Point(0, 0)
        Me.FraConceptosVer.Name = "FraConceptosVer"
        Me.FraConceptosVer.Size = New System.Drawing.Size(675, 72)
        Me.FraConceptosVer.TabIndex = 232
        Me.FraConceptosVer.TabStop = False
        Me.FraConceptosVer.Text = "Datos a visualizar"
        '
        'rbtMinimizarTree
        '
        Me.rbtMinimizarTree.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbtMinimizarTree.Location = New System.Drawing.Point(523, 39)
        Me.rbtMinimizarTree.Name = "rbtMinimizarTree"
        Me.rbtMinimizarTree.Size = New System.Drawing.Size(77, 15)
        Me.rbtMinimizarTree.TabIndex = 229
        Me.rbtMinimizarTree.Text = "Contraer"
        '
        'rbtMaximizarTree
        '
        Me.rbtMaximizarTree.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbtMaximizarTree.Location = New System.Drawing.Point(523, 19)
        Me.rbtMaximizarTree.Name = "rbtMaximizarTree"
        Me.rbtMaximizarTree.Size = New System.Drawing.Size(84, 16)
        Me.rbtMaximizarTree.TabIndex = 228
        Me.rbtMaximizarTree.Text = "Expandir"
        '
        'cmbVerDatos
        '
        Me.cmbVerDatos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbVerDatos.Icon = CType(resources.GetObject("cmbVerDatos.Icon"), System.Drawing.Icon)
        Me.cmbVerDatos.Location = New System.Drawing.Point(627, 24)
        Me.cmbVerDatos.Name = "cmbVerDatos"
        Me.cmbVerDatos.Size = New System.Drawing.Size(28, 28)
        Me.cmbVerDatos.TabIndex = 124
        '
        'chkVerMediciones
        '
        Me.chkVerMediciones.Location = New System.Drawing.Point(280, 39)
        Me.chkVerMediciones.Name = "chkVerMediciones"
        Me.chkVerMediciones.Size = New System.Drawing.Size(86, 21)
        Me.chkVerMediciones.TabIndex = 8
        Me.chkVerMediciones.Text = "Mediciones"
        '
        'chkVerVarios
        '
        Me.chkVerVarios.Location = New System.Drawing.Point(205, 39)
        Me.chkVerVarios.Name = "chkVerVarios"
        Me.chkVerVarios.Size = New System.Drawing.Size(58, 21)
        Me.chkVerVarios.TabIndex = 7
        Me.chkVerVarios.Text = "Varios"
        '
        'chkVerGastos
        '
        Me.chkVerGastos.Location = New System.Drawing.Point(111, 39)
        Me.chkVerGastos.Name = "chkVerGastos"
        Me.chkVerGastos.Size = New System.Drawing.Size(63, 21)
        Me.chkVerGastos.TabIndex = 6
        Me.chkVerGastos.Text = "Gastos"
        '
        'chkVerCentros
        '
        Me.chkVerCentros.Location = New System.Drawing.Point(280, 19)
        Me.chkVerCentros.Name = "chkVerCentros"
        Me.chkVerCentros.Size = New System.Drawing.Size(69, 21)
        Me.chkVerCentros.TabIndex = 5
        Me.chkVerCentros.Text = "Centros"
        '
        'chkVerMOD
        '
        Me.chkVerMOD.Location = New System.Drawing.Point(205, 19)
        Me.chkVerMOD.Name = "chkVerMOD"
        Me.chkVerMOD.Size = New System.Drawing.Size(63, 21)
        Me.chkVerMOD.TabIndex = 4
        Me.chkVerMOD.Text = "M.O.D."
        '
        'chkVerMateriales
        '
        Me.chkVerMateriales.Location = New System.Drawing.Point(111, 19)
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
        Me.chkVerTrabajos.Location = New System.Drawing.Point(27, 19)
        Me.chkVerTrabajos.Name = "chkVerTrabajos"
        Me.chkVerTrabajos.Size = New System.Drawing.Size(71, 21)
        Me.chkVerTrabajos.TabIndex = 2
        Me.chkVerTrabajos.TabStop = False
        Me.chkVerTrabajos.Text = "Trabajos"
        '
        'TvwEstructura
        '
        Me.TvwEstructura.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TvwEstructura.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TvwEstructura.ImageIndex = 0
        Me.TvwEstructura.ImageList = Me.ImageList1
        Me.TvwEstructura.Location = New System.Drawing.Point(0, 72)
        Me.TvwEstructura.Name = "TvwEstructura"
        Me.TvwEstructura.SelectedImageIndex = 0
        Me.TvwEstructura.Size = New System.Drawing.Size(675, 466)
        Me.TvwEstructura.TabIndex = 239
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "xProyectos.ico")
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
        '
        'frmEstructuraObra
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(675, 580)
        Me.Controls.Add(Me.TvwEstructura)
        Me.Controls.Add(Me.FraConceptosVer)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmEstructuraObra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estructura de la Obra"
        Me.Panel1.ResumeLayout(False)
        Me.FraConceptosVer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Enum IconIndex
        oObra = 0
        oTrabajos = 1
        oMateriales = 2
        oMod = 3
        oCentros = 4
        oGastos = 5
        oVarios = 6
        oMediciones = 7
        oCapitulos = 8
        oPorcentajes = 9
        oSubcapitulo = 10
    End Enum

    Private mintIDObra As Integer
    Private mstrNObra, mstrDescObra As String
    Private mdtEstructura As DataTable

#Region " Load "

    Public Sub AbrirEstructuraObra(ByVal intIDObra As Integer, ByVal strNObra As String, ByVal strDescObra As String)
        mintIDObra = intIDObra
        mstrNObra = strNObra
        mstrDescObra = strDescObra

        Me.ShowDialog()
    End Sub

    Private Sub FrmEstructuraObra_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rbtMaximizarTree.Checked = True
        mdtEstructura = New BE.DataEngine().Filter("vFrmObraTrabajos", New NumberFilterItem("IDObra", mintIDObra), , "Secuencia")
        VerDatos()
    End Sub

#End Region

    Private Sub VerDatos()
        If mintIDObra > 0 And chkVerTrabajos.Checked Then
            TvwEstructura.Nodes.Clear()
            TvwEstructura.ImageList = ImageList1
            Dim strText As String = mstrNObra
            If Length(mstrDescObra) > 0 Then strText = strText & " -> " & mstrDescObra
            Dim oNode As TreeNode = TvwEstructura.Nodes.Add(strText)
            oNode.ImageIndex = IconIndex.oObra
            oNode.SelectedImageIndex = IconIndex.oObra
            oNode.Expand()

            PintarTrabajos(mdtEstructura, oNode)
        Else
            TvwEstructura.Nodes.Clear()
        End If
    End Sub

    Private Sub cmbVerDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbVerDatos.Click
        VerDatos()
    End Sub

#Region " Pintar Arboles "

#Region " Trabajos "

    Private Sub PintarTrabajos(ByVal dtTrabajos As DataTable, Optional ByVal oNode As TreeNode = Nothing)
        If Not dtTrabajos Is Nothing AndAlso dtTrabajos.Rows.Count > 0 Then
            If Not TvwEstructura.Enabled Then TvwEstructura.Enabled = True
            For Each drTrabajo As DataRow In dtTrabajos.Select
                If IsDBNull(drTrabajo("IDTrabajoPadre")) Then
                    PintarNodoTrabajo(drTrabajo, dtTrabajos, oNode)
                End If
            Next
        End If

        If rbtMaximizarTree.Checked Then TvwEstructura.ExpandAll()
        TvwEstructura.Refresh()

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub PintarNodoTrabajo(ByVal drTrabajo As DataRow, ByVal dtTrabajos As DataTable, _
                                  Optional ByVal oNode As TreeNode = Nothing)

        Const cnTRUNCATE As Integer = 55

        Dim strText As String = drTrabajo("CodTrabajo") & " -> " & drTrabajo("DescTrabajo")
        If Len(strText) > cnTRUNCATE Then
            strText = Strings.Left(strText, cnTRUNCATE)
        Else
            strText = strText + Space(cnTRUNCATE - Len(strText))
        End If

        Dim strImportes As String = Format(drTrabajo("ImpAcumulado"), "#,##0.00") & Space(5) & Format(drTrabajo("ImpAcumuladoVenta"), "#,##0.00")

        strText = strText & Space(5) & strImportes
        If oNode Is Nothing Then
            oNode = TvwEstructura.Nodes.Add(strText)
        Else
            oNode = oNode.Nodes.Add(strText)
        End If

        If drTrabajo("TipoLinea") = enumTipoLineaTrabajo.tltTrabajo Then
            oNode.ImageIndex = IconIndex.oTrabajos
            If Nz(drTrabajo("ImpPrevQTrabajoA"), 0) = 0 Then
                oNode.ImageIndex = IconIndex.oSubcapitulo
            Else
                oNode.ImageIndex = IconIndex.oTrabajos
            End If
        ElseIf drTrabajo("TipoLinea") = enumTipoLineaTrabajo.tltCapitulo Then
            oNode.ImageIndex = IconIndex.oCapitulos
            oNode.BackColor = Color.FromArgb(255, 255, 128) 'Color.Yellow 
        ElseIf drTrabajo("TipoLinea") = enumTipoLineaTrabajo.tltPorcentajeConcepto Then
            oNode.ImageIndex = IconIndex.oPorcentajes
            oNode.BackColor = Color.FromArgb(255, 192, 128) 'Color.Orange
        End If
        oNode.SelectedImageIndex = oNode.ImageIndex

        Dim f As New Filter
        f.Add("IDTrabajo", drTrabajo("IDTrabajo"))

        'pintar materiales
        If chkVerMateriales.Checked Then
            Dim dtMateriales As DataTable = New ObraMaterial().Filter(f)
            PintarMateriales(dtMateriales, oNode)
        End If
        'pintar mod
        If chkVerMOD.Checked Then
            Dim dtMod As DataTable = New ObraMOD().Filter(f)
            PintarMOD(dtMod, oNode)
        End If
        'pintar centros
        If chkVerCentros.Checked Then
            Dim dtC As DataTable = New ObraCentro().Filter(f)
            PintarCentros(dtC, oNode)
        End If
        'pintar gastos
        If chkVerGastos.Checked Then
            Dim dtG As DataTable = New ObraGasto().Filter(f)
            PintarGastos(dtG, oNode)
        End If
        'pintar varios
        If chkVerVarios.Checked Then
            Dim dtV As DataTable = New ObraVarios().Filter(f)
            PintarVarios(dtV, oNode)
        End If
        'pintar mediciones
        If chkVerMediciones.Checked Then
            Dim dtME As DataTable = New ObraMedicion().Filter(f)
            PintarMediciones(dtME, oNode)
        End If

        'pintar sus subtrabajos
        Dim dv As DataView = dtTrabajos.DefaultView
        dv.RowFilter = "IDTrabajoPadre = " & drTrabajo("IdTrabajo")
        For Each drv As DataRowView In dv
            PintarNodoTrabajo(drv.Row, dtTrabajos, oNode)
        Next

        oNode = Nothing
    End Sub

#End Region

#Region " Materiales "
    Private Sub PintarMateriales(ByVal dtMateriales As DataTable, Optional ByVal oNode As TreeNode = Nothing)
        If Not dtMateriales Is Nothing AndAlso dtMateriales.Rows.Count > 0 Then
            oNode = oNode.Nodes.Add(ExpertisApp.Traslate("MATERIALES"))
            oNode.ImageIndex = IconIndex.oMateriales
            oNode.SelectedImageIndex = IconIndex.oMateriales
            For Each drMaterial As DataRow In dtMateriales.Select
                PintarNodoMaterial(drMaterial("IDMaterial") & String.Empty, _
                                   drMaterial("DescMaterial") & String.Empty, drMaterial("QPrev"), oNode)
            Next
        End If

    End Sub

    Private Sub PintarNodoMaterial(ByVal strIDMaterial As String, _
                                   ByVal strDescMaterial As String, ByVal dblQPrev As Double, _
                                   Optional ByVal oNode As TreeNode = Nothing)

        Dim strText As String = "Artículo: " & strIDMaterial & " - " & strDescMaterial & "  Cantidad Total: " & dblQPrev
        If oNode Is Nothing Then
            oNode = TvwEstructura.Nodes.Add(strText)
        Else
            oNode = oNode.Nodes.Add(strText)
        End If
        oNode.ImageIndex = IconIndex.oMateriales
        oNode.SelectedImageIndex = IconIndex.oMateriales

        oNode = Nothing
    End Sub

#End Region

#Region " MOD "
    Private Sub PintarMOD(ByVal dtMOD As DataTable, Optional ByVal oNode As TreeNode = Nothing)
        If Not dtMOD Is Nothing AndAlso dtMOD.Rows.Count > 0 Then
            oNode = oNode.Nodes.Add(ExpertisApp.Traslate("MOD"))
            oNode.ImageIndex = IconIndex.oMod
            oNode.SelectedImageIndex = IconIndex.oMod
            For Each drMOD As DataRow In dtMOD.Select
                PintarNodoMOD(drMOD("IDCategoria") & String.Empty, _
                              drMOD("DescCategoria") & String.Empty, _
                              drMOD("DesHora") & String.Empty, oNode)
            Next
            oNode = Nothing
        End If

    End Sub

    Private Sub PintarNodoMOD(ByVal strIDCategoria As String, _
                              ByVal strDescCategoria As String, ByVal strDescHora As String, _
                              Optional ByVal oNode As TreeNode = Nothing)

        Dim strText As String = "Categoría: " & strIDCategoria & " - " & strDescCategoria & "  Tipo Hora: " & strDescHora
        If oNode Is Nothing Then
            oNode = TvwEstructura.Nodes.Add(strText)
        Else
            oNode = oNode.Nodes.Add(strText)
        End If
        oNode.ImageIndex = IconIndex.oMod
        oNode.SelectedImageIndex = IconIndex.oMod

        oNode = Nothing
    End Sub
#End Region

#Region " Centros "
    Private Sub PintarCentros(ByVal dtCentros As DataTable, Optional ByVal oNode As TreeNode = Nothing)
        If Not dtCentros Is Nothing AndAlso dtCentros.Rows.Count > 0 Then
            oNode = oNode.Nodes.Add(ExpertisApp.Traslate("CENTROS"))
            oNode.ImageIndex = IconIndex.oCentros
            oNode.SelectedImageIndex = IconIndex.oCentros
            For Each drCentros As DataRow In dtCentros.Select
                PintarNodoCentros(drCentros("IDCentro") & String.Empty, _
                                  drCentros("DescCentro") & String.Empty, oNode)
            Next
            oNode = Nothing
        End If
    End Sub

    Private Sub PintarNodoCentros(ByVal strIDCentro As String, ByVal strDescCentro As String, _
                                  Optional ByVal oNode As TreeNode = Nothing)

        Dim strText As String = "Centro: " & strIDCentro & " - " & strDescCentro
        If oNode Is Nothing Then
            oNode = TvwEstructura.Nodes.Add(strText)
        Else
            oNode = oNode.Nodes.Add(strText)
        End If
        oNode.ImageIndex = IconIndex.oCentros
        oNode.SelectedImageIndex = IconIndex.oCentros

        oNode = Nothing
    End Sub
#End Region

#Region " Gastos "
    Private Sub PintarGastos(ByVal dtGastos As DataTable, Optional ByVal oNode As TreeNode = Nothing)
        If Not dtGastos Is Nothing AndAlso dtGastos.Rows.Count > 0 Then
            oNode = oNode.Nodes.Add(ExpertisApp.Traslate("GASTOS"))
            oNode.ImageIndex = IconIndex.oGastos
            oNode.SelectedImageIndex = IconIndex.oGastos
            For Each drGastos As DataRow In dtGastos.Select
                PintarNodoGastos(drGastos("IDGasto") & String.Empty, _
                                 drGastos("DescGasto") & String.Empty, oNode)
            Next
            oNode = Nothing
        End If
    End Sub

    Private Sub PintarNodoGastos(ByVal strIDGasto As String, ByVal strDescGasto As String, _
                                 Optional ByVal oNode As TreeNode = Nothing)

        Dim strText As String = "Gasto: " & strIDGasto & " - " & strDescGasto
        If oNode Is Nothing Then
            oNode = TvwEstructura.Nodes.Add(strText)
        Else
            oNode = oNode.Nodes.Add(strText)
        End If
        oNode.ImageIndex = IconIndex.oGastos
        oNode.SelectedImageIndex = IconIndex.oGastos

        oNode = Nothing
    End Sub
#End Region

#Region " Varios "
    Private Sub PintarVarios(ByVal dtVarios As DataTable, _
                             Optional ByVal oNode As TreeNode = Nothing)

        If Not dtVarios Is Nothing AndAlso dtVarios.Rows.Count > 0 Then
            oNode = oNode.Nodes.Add(ExpertisApp.Traslate("VARIOS"))
            oNode.ImageIndex = IconIndex.oVarios
            oNode.SelectedImageIndex = IconIndex.oVarios
            For Each drVarios As DataRow In dtVarios.Select
                PintarNodoVarios(drVarios("IDVarios") & String.Empty, _
                                 drVarios("DescVarios") & String.Empty, oNode)
            Next
            oNode = Nothing
        End If
    End Sub

    Private Sub PintarNodoVarios(ByVal strIDVarios As String, _
                                 ByVal strDescVarios As String, _
                                 Optional ByVal oNode As TreeNode = Nothing)

        Dim strText As String = "Varios: " & strIDVarios & " - " & strDescVarios
        If oNode Is Nothing Then
            oNode = TvwEstructura.Nodes.Add(strText)
        Else
            oNode = oNode.Nodes.Add(strText)
        End If
        oNode.ImageIndex = IconIndex.oVarios
        oNode.SelectedImageIndex = IconIndex.oVarios

        oNode = Nothing
    End Sub
#End Region

#Region " Mediciones "
    Private Sub PintarMediciones(ByVal dtMedicion As DataTable, _
                                 Optional ByVal oNode As TreeNode = Nothing)

        If Not dtMedicion Is Nothing AndAlso dtMedicion.Rows.Count > 0 Then
            oNode = oNode.Nodes.Add(ExpertisApp.Traslate("MEDICIONES"))
            oNode.ImageIndex = IconIndex.oMediciones
            oNode.SelectedImageIndex = IconIndex.oMediciones
            For Each drMedicion As DataRow In dtMedicion.Select
                PintarNodoMediciones(drMedicion("DescMedicion") & String.Empty, Nz(drMedicion("QPI"), 0), _
                                     Nz(drMedicion("Largo"), 0), Nz(drMedicion("Ancho"), 0), _
                                     Nz(drMedicion("Alto"), 0), Nz(drMedicion("Total"), 0), oNode)
            Next
            oNode = Nothing
        End If
    End Sub

    Private Sub PintarNodoMediciones(ByVal strDescMedicion As String, ByVal dblQPI As Double, _
                                     ByVal dblLargo As Double, ByVal dblAncho As Double, _
                                     ByVal dblAlto As Double, ByVal dblTotal As Double, _
                                     Optional ByVal oNode As TreeNode = Nothing)

        Dim strText As String = "Descripción: " & strDescMedicion & " PI: " & dblQPI & " LARGO: " & dblLargo & " ANCHO: " & dblAncho & " ALTO: " & dblAlto & " TOTAL: " & dblTotal
        If oNode Is Nothing Then
            oNode = TvwEstructura.Nodes.Add(strText)
        Else
            oNode = oNode.Nodes.Add(strText)
        End If
        oNode.ImageIndex = IconIndex.oMediciones
        oNode.SelectedImageIndex = IconIndex.oMediciones

        oNode = Nothing
    End Sub
#End Region

#End Region

End Class
