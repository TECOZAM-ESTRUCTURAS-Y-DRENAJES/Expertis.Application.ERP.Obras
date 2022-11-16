Public Class frmImpEstructura
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
    Friend WithEvents Frame1 As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents lblFwiArticulo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiIdEstructura As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents Grid As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents cmbCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents AdvIDEstructura As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents txtDescArticulo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents txtIDArticulo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents ulDescEstructura As Solmicro.Expertis.Engine.UI.UnderLineLabel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImpEstructura))
        Me.Frame1 = New Solmicro.Expertis.Engine.UI.Frame
        Me.AdvIDEstructura = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.txtDescArticulo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblFwiArticulo = New Solmicro.Expertis.Engine.UI.Label
        Me.txtIDArticulo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblfwiIdEstructura = New Solmicro.Expertis.Engine.UI.Label
        Me.ulDescEstructura = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.Grid = New Solmicro.Expertis.Engine.UI.Grid
        Me.Frame1.SuspendLayout()
        Me.Panel1.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.Controls.Add(Me.AdvIDEstructura)
        Me.Frame1.Controls.Add(Me.txtDescArticulo)
        Me.Frame1.Controls.Add(Me.lblFwiArticulo)
        Me.Frame1.Controls.Add(Me.txtIDArticulo)
        Me.Frame1.Controls.Add(Me.lblfwiIdEstructura)
        Me.Frame1.Controls.Add(Me.ulDescEstructura)
        Me.Frame1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Frame1.Location = New System.Drawing.Point(0, 0)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(736, 72)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        '
        'AdvIDEstructura
        '
        Me.AdvIDEstructura.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDEstructura.EntityName = "ArticuloEstructura"
        Me.AdvIDEstructura.Location = New System.Drawing.Point(75, 16)
        Me.AdvIDEstructura.Name = "AdvIDEstructura"
        Me.AdvIDEstructura.SecondaryDataFields = "IDEstructura"
        Me.AdvIDEstructura.Size = New System.Drawing.Size(118, 23)
        Me.AdvIDEstructura.TabIndex = 10
        Me.AdvIDEstructura.ViewName = "tbArticuloEstructura"
        '
        'txtDescArticulo
        '
        Me.txtDescArticulo.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescArticulo.Enabled = False
        Me.txtDescArticulo.Location = New System.Drawing.Point(196, 42)
        Me.txtDescArticulo.Name = "txtDescArticulo"
        Me.txtDescArticulo.Size = New System.Drawing.Size(528, 21)
        Me.txtDescArticulo.TabIndex = 4
        '
        'lblFwiArticulo
        '
        Me.lblFwiArticulo.Location = New System.Drawing.Point(7, 42)
        Me.lblFwiArticulo.Name = "lblFwiArticulo"
        Me.lblFwiArticulo.Size = New System.Drawing.Size(50, 13)
        Me.lblFwiArticulo.TabIndex = 7
        Me.lblFwiArticulo.Text = "Artículo"
        '
        'txtIDArticulo
        '
        Me.txtIDArticulo.DisabledBackColor = System.Drawing.Color.White
        Me.txtIDArticulo.Enabled = False
        Me.txtIDArticulo.Location = New System.Drawing.Point(74, 42)
        Me.txtIDArticulo.Name = "txtIDArticulo"
        Me.txtIDArticulo.Size = New System.Drawing.Size(118, 21)
        Me.txtIDArticulo.TabIndex = 3
        '
        'lblfwiIdEstructura
        '
        Me.lblfwiIdEstructura.Location = New System.Drawing.Point(7, 15)
        Me.lblfwiIdEstructura.Name = "lblfwiIdEstructura"
        Me.lblfwiIdEstructura.Size = New System.Drawing.Size(65, 13)
        Me.lblfwiIdEstructura.TabIndex = 8
        Me.lblfwiIdEstructura.Text = "Estructura"
        '
        'ulDescEstructura
        '
        Me.ulDescEstructura.Location = New System.Drawing.Point(196, 19)
        Me.ulDescEstructura.Name = "ulDescEstructura"
        Me.ulDescEstructura.Size = New System.Drawing.Size(528, 17)
        Me.ulDescEstructura.TabIndex = 9
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbCancelar)
        Me.Panel1.Controls.Add(Me.cmbAceptar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 293)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(736, 48)
        Me.Panel1.TabIndex = 9
        '
        'cmbCancelar
        '
        Me.cmbCancelar.Location = New System.Drawing.Point(372, 8)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(120, 32)
        Me.cmbCancelar.TabIndex = 9
        Me.cmbCancelar.Text = "Cancelar"
        '
        'cmbAceptar
        '
        Me.cmbAceptar.Location = New System.Drawing.Point(244, 8)
        Me.cmbAceptar.Name = "cmbAceptar"
        Me.cmbAceptar.Size = New System.Drawing.Size(120, 32)
        Me.cmbAceptar.TabIndex = 8
        Me.cmbAceptar.Text = "Aceptar"
        '
        'Grid
        '
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.Grid.EntityName = Nothing
        Me.Grid.Location = New System.Drawing.Point(0, 72)
        Me.Grid.Name = "Grid"
        Me.Grid.PrimaryDataFields = Nothing
        Me.Grid.RelationMode = Solmicro.Expertis.Engine.RelationMode.NoRelation
        Me.Grid.RequeryManually = True
        Me.Grid.SecondaryDataFields = Nothing
        Me.Grid.Size = New System.Drawing.Size(736, 221)
        Me.Grid.TabIndex = 10
        Me.Grid.Tag = ""
        Me.Grid.ViewName = Nothing
        '
        'frmImpEstructura
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(736, 341)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Frame1)
        Me.MaximizeBox = False
        Me.Name = "frmImpEstructura"
        Me.Text = "Importar Estructura"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mIDArticulo, mstrDescArticulo As String
    Private mIDObra, mIDTrabajo, mTipoFacturacion, mIDLineaMaterial As Integer
    Private mblnExpedible, mblnFacturable As Boolean
    Private mFechaInicioTrabajo As Date
    Private mQPrevTrabajo, mQUnidad As Double

#Region " Propertys "

    Public Property IDArticulo() As String
        Get
            Return mIDArticulo
        End Get
        Set(ByVal Value As String)
            mIDArticulo = Value
        End Set
    End Property

    Public Property DescArticulo() As String
        Get
            Return mstrDescArticulo
        End Get
        Set(ByVal Value As String)
            mstrDescArticulo = Value
        End Set
    End Property

    Public Property IDObra() As Integer
        Get
            Return mIDObra
        End Get
        Set(ByVal Value As Integer)
            mIDObra = Value
        End Set
    End Property

    Public Property IDTrabajo() As Integer
        Get
            Return mIDTrabajo
        End Get
        Set(ByVal Value As Integer)
            mIDTrabajo = Value
        End Set
    End Property

    Public Property FechaInicioTrabajo() As Date
        Get
            Return mFechaInicioTrabajo
        End Get
        Set(ByVal Value As Date)
            mFechaInicioTrabajo = Value
        End Set
    End Property

    Public Property Expedible() As Boolean
        Get
            Return mblnExpedible
        End Get
        Set(ByVal Value As Boolean)
            mblnExpedible = Value
        End Set
    End Property

    Public Property Facturable() As Boolean
        Get
            Return mblnFacturable
        End Get
        Set(ByVal Value As Boolean)
            mblnFacturable = Value
        End Set
    End Property

    Public Property IDLineaMaterial() As Integer
        Get
            Return mIDLineaMaterial
        End Get
        Set(ByVal Value As Integer)
            mIDLineaMaterial = Value
        End Set
    End Property

    Public Property TipoFacturacion() As enumomATipoFacturacionAlquiler
        Get
            Return mTipoFacturacion
        End Get
        Set(ByVal Value As enumomATipoFacturacionAlquiler)
            mTipoFacturacion = CInt(Value)
        End Set
    End Property

    Public Property QPrevTrabajo() As Double
        Get
            Return mQPrevTrabajo
        End Get
        Set(ByVal Value As Double)
            mQPrevTrabajo = Value
        End Set
    End Property

    Public Property QUnidad() As Double
        Get
            Return mQUnidad
        End Get
        Set(ByVal Value As Double)
            mQUnidad = Value
        End Set
    End Property

#End Region

#Region " Load "

    Private Sub frmImpEstructura_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtIDArticulo.Text = mIDArticulo
        txtDescArticulo.Text = mstrDescArticulo

        EnumData.PopulateValueList("enumomATipoFacturacionAlquiler", Grid.Columns("TipoFacturacion"))

        Dim strEstructurappal As String = ExpertisApp.ExecuteTask(Of String, String)(AddressOf ArticuloEstructura.EstructuraPpal, mIDArticulo)

        If AdvIDEstructura.Text <> strEstructurappal Then
            AdvIDEstructura.Text = strEstructurappal
        End If

        If Length(AdvIDEstructura.Text) > 0 Then
            Dim [of] As New Filter
            [of].Add(New StringFilterItem("IDArticulo", mIDArticulo))
            [of].Add(New StringFilterItem("IDEstructura", AdvIDEstructura.Text))

            Dim oDE As New Engine.BE.DataEngine
            Dim dtt As DataTable = oDE.Filter("vfrmArticuloEstructuraDatos", [of])
            If Not IsNothing(dtt) AndAlso dtt.Rows.Count > 0 Then
                For Each dr As DataRow In dtt.Select
                    dr("CantidadMarca6") = True
                    dr("Expedible") = mblnExpedible
                    dr("Facturable") = mblnFacturable
                    If Nz(dr("TipoFacturacion"), 0) = 0 Then
                        dr("TipoFacturacion") = enumomATipoFacturacionAlquiler.omAPorExpedicion
                    Else
                        dr("TipoFacturacion") = enumomATipoFacturacionAlquiler.omAPorAlquiler
                    End If
                Next
            End If
            Grid.EntityName = "Estructura"
            If Not IsNothing(dtt) AndAlso dtt.Rows.Count > 0 Then
                Grid.DataSource = dtt
            End If
        End If
    End Sub

#End Region

    Private Sub AdvIDEstructura_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles AdvIDEstructura.SetPredefinedFilter
        If Length(mIDArticulo) > 0 Then
            e.Filter.Add(New StringFilterItem("IDArticulo", mIDArticulo))
        End If
    End Sub

    Private Sub AdvIDEstructura_SelectionChanged(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchSelectionChangedEventArgs) Handles AdvIDEstructura.SelectionChanged
        With Grid
            If (Length(e.Selected.Rows(0)("IDEstructura")) > 0 And Length(mIDArticulo) > 0) And (Not IsNothing(.DataSource) AndAlso .RowCount > 0) Then
                Dim f As New Filter
                f.Add(New StringFilterItem("IDArticulo", mIDArticulo))
                f.Add(New StringFilterItem("IDEstructura", e.Selected.Rows(0)("IDEstructura")))

                CType(.DataSource, DataTable).DefaultView.RowFilter = f.Compose(New AdoFilterComposer)
            End If
        End With
    End Sub

#Region " Grid "

    Private Sub Grid_UpdatingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles Grid.UpdatingCell
        With Grid
            Select Case e.Column.Index
                Case .Columns("Cantidad").Index
                    If .Value(e.Column.Index) > 0 Then
                        .Value("CantidadMarca6") = True
                    End If
            End Select
        End With
    End Sub

    Private Sub Grid_FormattingColumns() Handles Grid.FormattingColumns
        With Grid
            .Columns("Expedible").DefaultValue = False
            .Columns("Facturable").DefaultValue = False
            .Columns("TipoFacturacion").DefaultValue = mTipoFacturacion
        End With
    End Sub

#End Region

    Private Sub cmdCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCancelar.Click
        Me.Close()
    End Sub

    Private Sub cmbAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbAceptar.Click
        If Not Grid Is Nothing AndAlso Grid.RowCount > 0 Then
            If ExpertisApp.GenerateMessage("¿Desea Importar los componentes auxiliares asociados al material?.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                If mIDLineaMaterial > 0 Then
                    Dim dtImportacion As DataTable = Grid.DataSource

                    Dim data As New datosImportacionEstructuraMaterial(mIDObra, mIDTrabajo, mFechaInicioTrabajo, mIDLineaMaterial, mQUnidad, mQPrevTrabajo, dtImportacion)
                    ExpertisApp.ExecuteTask(Of datosImportacionEstructuraMaterial)(AddressOf ImportacionEstructuraMaterial.ImportarEstructuraMateriales, data)

                    ExpertisApp.GenerateMessage("Importación finalizada correctamente.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                End If
            End If
        End If
    End Sub

End Class
