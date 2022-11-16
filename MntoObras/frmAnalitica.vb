Imports Janus.Windows.GridEX
Public Class frmAnalitica
    Inherits Solmicro.Expertis.Engine.UI.FormBase
    Private GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout

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
    Public WithEvents TopFrame As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents BottomPanel As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents TotalFrame As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents PorcentajeAsignado As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents UnderLineLabel3 As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents ButtonCancel As Solmicro.Expertis.Engine.UI.Button
    Public WithEvents ButtonOK As Solmicro.Expertis.Engine.UI.Button
    Public WithEvents Grid As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents SubGrid As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents TxtOrigen As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents DescOrigen As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents LblOrigen As Solmicro.Expertis.Engine.UI.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.TopFrame = New Solmicro.Expertis.Engine.UI.Frame
        Me.TxtOrigen = New Solmicro.Expertis.Engine.UI.TextBox
        Me.DescOrigen = New Solmicro.Expertis.Engine.UI.TextBox
        Me.LblOrigen = New Solmicro.Expertis.Engine.UI.Label
        Me.BottomPanel = New Solmicro.Expertis.Engine.UI.Panel
        Me.ButtonCancel = New Solmicro.Expertis.Engine.UI.Button
        Me.ButtonOK = New Solmicro.Expertis.Engine.UI.Button
        Me.TotalFrame = New Solmicro.Expertis.Engine.UI.Frame
        Me.SubGrid = New Solmicro.Expertis.Engine.UI.Grid
        Me.PorcentajeAsignado = New Solmicro.Expertis.Engine.UI.Label
        Me.UnderLineLabel3 = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.Grid = New Solmicro.Expertis.Engine.UI.Grid
        Me.TopFrame.SuspendLayout()
        Me.BottomPanel.suspendlayout()
        Me.TotalFrame.SuspendLayout()
        CType(Me.SubGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TopFrame
        '
        Me.TopFrame.Controls.Add(Me.TxtOrigen)
        Me.TopFrame.Controls.Add(Me.DescOrigen)
        Me.TopFrame.Controls.Add(Me.LblOrigen)
        Me.TopFrame.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopFrame.Location = New System.Drawing.Point(0, 0)
        Me.TopFrame.Name = "TopFrame"
        Me.TopFrame.Size = New System.Drawing.Size(589, 44)
        Me.TopFrame.TabIndex = 8
        Me.TopFrame.TabStop = False
        Me.TopFrame.Tag = ""
        '
        'TxtOrigen
        '
        Me.TxtOrigen.Enabled = False
        Me.TxtOrigen.Location = New System.Drawing.Point(61, 14)
        Me.TxtOrigen.Name = "TxtOrigen"
        Me.TxtOrigen.Size = New System.Drawing.Size(117, 21)
        Me.TxtOrigen.TabIndex = 9
        '
        'DescOrigen
        '
        Me.DescOrigen.Enabled = False
        Me.DescOrigen.Location = New System.Drawing.Point(183, 14)
        Me.DescOrigen.Name = "DescOrigen"
        Me.DescOrigen.Size = New System.Drawing.Size(399, 21)
        Me.DescOrigen.TabIndex = 19
        '
        'LblOrigen
        '
        Me.LblOrigen.Location = New System.Drawing.Point(8, 16)
        Me.LblOrigen.Name = "LblOrigen"
        Me.LblOrigen.Size = New System.Drawing.Size(47, 17)
        Me.LblOrigen.TabIndex = 10
        Me.LblOrigen.Tag = ""
        Me.LblOrigen.Text = "Trabajo"
        '
        'BottomPanel
        '
        Me.BottomPanel.Controls.Add(Me.ButtonCancel)
        Me.BottomPanel.Controls.Add(Me.ButtonOK)
        Me.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BottomPanel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BottomPanel.Location = New System.Drawing.Point(0, 309)
        Me.BottomPanel.Name = "BottomPanel"
        Me.BottomPanel.Size = New System.Drawing.Size(589, 53)
        Me.BottomPanel.TabIndex = 6
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(302, 10)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(102, 33)
        Me.ButtonCancel.TabIndex = 5
        Me.ButtonCancel.Text = "Cancelar"
        '
        'ButtonOK
        '
        Me.ButtonOK.Location = New System.Drawing.Point(184, 10)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(102, 33)
        Me.ButtonOK.TabIndex = 4
        Me.ButtonOK.Text = "Aceptar"
        '
        'TotalFrame
        '
        Me.TotalFrame.Controls.Add(Me.SubGrid)
        Me.TotalFrame.Controls.Add(Me.PorcentajeAsignado)
        Me.TotalFrame.Controls.Add(Me.UnderLineLabel3)
        Me.TotalFrame.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TotalFrame.Location = New System.Drawing.Point(0, 265)
        Me.TotalFrame.Name = "TotalFrame"
        Me.TotalFrame.Size = New System.Drawing.Size(589, 44)
        Me.TotalFrame.TabIndex = 10
        Me.TotalFrame.TabStop = False
        '
        'SubGrid
        '
        Me.SubGrid.CellSelectionMode = Janus.Windows.GridEX.CellSelectionMode.SingleCell
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><ColumnHeaders>False</ColumnHeaders><Columns Collect" & _
        "ion=""true""><Column0 ID=""IDAnalitica1""><ButtonStyle>Image</ButtonStyle><Caption>I" & _
        "DAnalitica1</Caption><DataMember>IDAnalitica1</DataMember><Key>IDAnalitica1</Key" & _
        "><Position>0</Position><Width>80</Width></Column0><Column1 ID=""IDAnalitica2""><Bu" & _
        "ttonStyle>Image</ButtonStyle><Caption>IDAnalitica2</Caption><DataMember>IDAnalit" & _
        "ica2</DataMember><Key>IDAnalitica2</Key><Position>1</Position><Width>80</Width><" & _
        "/Column1><Column2 ID=""IDAnalitica3""><ButtonStyle>Image</ButtonStyle><Caption>IDA" & _
        "nalitica3</Caption><DataMember>IDAnalitica3</DataMember><Key>IDAnalitica3</Key><" & _
        "Position>2</Position><Width>80</Width></Column2><Column3 ID=""IDAnalitica4""><Butt" & _
        "onStyle>Image</ButtonStyle><Caption>IDAnalitica4</Caption><DataMember>IDAnalitic" & _
        "a4</DataMember><Key>IDAnalitica4</Key><Position>3</Position><Width>80</Width></C" & _
        "olumn3><Column4 ID=""IDAnalitica5""><ButtonStyle>Image</ButtonStyle><Caption>IDAna" & _
        "litica5</Caption><DataMember>IDAnalitica5</DataMember><Key>IDAnalitica5</Key><Po" & _
        "sition>4</Position><Width>80</Width></Column4></Columns><GroupCondition ID="""" />" & _
        "<RowHeaders>False</RowHeaders><SortKeys Collection=""true""><SortKey0 ID=""SortKey0" & _
        """><ColIndex>0</ColIndex></SortKey0></SortKeys></RootTable></GridEXLayoutData>"
        Me.SubGrid.DesignTimeLayout = GridEXLayout1
        Me.SubGrid.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.SubGrid.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.SubGrid.EntityName = Nothing
        Me.SubGrid.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.SubGrid.Location = New System.Drawing.Point(10, 14)
        Me.SubGrid.Name = "SubGrid"
        Me.SubGrid.PrimaryDataFields = Nothing
        Me.SubGrid.ScrollBars = Janus.Windows.GridEX.ScrollBars.None
        Me.SubGrid.SecondaryDataFields = Nothing
        Me.SubGrid.Size = New System.Drawing.Size(165, 21)
        Me.SubGrid.TabIndex = 10
        Me.SubGrid.ViewName = Nothing
        Me.SubGrid.Visible = False
        '
        'PorcentajeAsignado
        '
        Me.PorcentajeAsignado.Location = New System.Drawing.Point(534, 16)
        Me.PorcentajeAsignado.Name = "PorcentajeAsignado"
        Me.PorcentajeAsignado.Size = New System.Drawing.Size(46, 17)
        Me.PorcentajeAsignado.TabIndex = 8
        Me.PorcentajeAsignado.Text = "85,5 %"
        '
        'UnderLineLabel3
        '
        Me.UnderLineLabel3.Location = New System.Drawing.Point(389, 15)
        Me.UnderLineLabel3.Name = "UnderLineLabel3"
        Me.UnderLineLabel3.Size = New System.Drawing.Size(129, 14)
        Me.UnderLineLabel3.TabIndex = 5
        Me.UnderLineLabel3.Text = "Porcentaje asignado"
        Me.UnderLineLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Grid
        '
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.Grid.EntityName = ""
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Grid.Location = New System.Drawing.Point(0, 44)
        Me.Grid.Name = "Grid"
        Me.Grid.PrimaryDataFields = ""
        Me.Grid.SecondaryDataFields = ""
        Me.Grid.Size = New System.Drawing.Size(589, 221)
        Me.Grid.TabIndex = 11
        Me.Grid.Tag = ""
        Me.Grid.ViewName = ""
        '
        'frmAnalitica
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(589, 362)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.TotalFrame)
        Me.Controls.Add(Me.TopFrame)
        Me.Controls.Add(Me.BottomPanel)
        Me.CreateTransaction = True
        Me.HelpButton = False
        Me.Name = "frmAnalitica"
        Me.NavigationFields = ""
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Analítica"
        Me.WindowState = System.Windows.Forms.FormWindowState.Normal
        Me.TopFrame.ResumeLayout(False)
        Me.BottomPanel.ResumeLayout(False)
        Me.TotalFrame.ResumeLayout(False)
        CType(Me.SubGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


#Region "Variables Privadas"

    Private Const NumericFormatString As String = "#,0.0###"
    Private mQueryOnclose, mPendingUpdate, mReadOnly As Boolean
    Private mIDMoneda As String
    Private mFecha As Date
    Private mMoneda As MonedaInfo
    Private MIntNiveles As Integer
    Private MBlnOrigenObra As Boolean = False
    Private MIntOrigen As Integer

    Private WithEvents sctIDAnalitica1 As AdvancedSearch
    Private WithEvents sctIDAnalitica2 As AdvancedSearch
    Private WithEvents sctIDAnalitica3 As AdvancedSearch
    Private WithEvents sctIDAnalitica4 As AdvancedSearch
    Private WithEvents sctIDAnalitica5 As AdvancedSearch

#End Region

#Region "Propiedades Publicas"

    Public WriteOnly Property IDMoneda() As String
        Set(ByVal Value As String)
            mIDMoneda = Value
            If Len(mIDMoneda) Then
               
                Dim StDatos As New Moneda.DatosObtenerMoneda
                StDatos.IDMoneda = mIDMoneda
                mMoneda = ExpertisApp.ExecuteTask(Of Moneda.DatosObtenerMoneda, MonedaInfo)(AddressOf Business.General.Moneda.ObtenerMoneda, StDatos)

            End If
        End Set
    End Property

    Public WriteOnly Property Moneda() As MonedaInfo
        Set(ByVal Value As MonedaInfo)
            mMoneda = Value
        End Set
    End Property

    Public WriteOnly Property Fecha() As Date
        Set(ByVal Value As Date)
            mFecha = Value
        End Set
    End Property

    Public WriteOnly Property SoloLectura() As Boolean
        Set(ByVal Value As Boolean)
            mReadOnly = Value
        End Set
    End Property

    Public WriteOnly Property OrigenObra() As Boolean
        Set(ByVal Value As Boolean)
            MBlnOrigenObra = Value
        End Set
    End Property

    Public WriteOnly Property IDOrigen() As Integer
        Set(ByVal Value As Integer)
            MIntOrigen = Value
        End Set
    End Property

#End Region

#Region "Funciones Privadas"

    Private Sub CalcularAcumulados()
        With Grid
            PorcentajeAsignado.Text = xRound(.GetTotal(Nz(.Columns("Porcentaje"), 0), Janus.Windows.GridEX.AggregateFunction.Sum), 3)
        End With
    End Sub
    Private Sub Totales()

        CalcularAcumulados()
        '//Cálculo de los restantes
        With Grid
            .Columns("Porcentaje").DefaultValue = (100 - Nz(PorcentajeAsignado.Text, 0))
        End With
    End Sub

    Public Sub LoadForm()
        PorcentajeAsignado.Text = String.Empty
        mFecha = Today
        Me.NavigationFields = Grid.PrimaryDataFields
        If mReadOnly Then
            Grid.RowHeaders = InheritableBoolean.False
            Grid.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False
            Grid.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False
            Grid.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        End If
        LoadLayOuts()
        LoadColumns()
        LoadAdvSearchSettings()
        Totales()
        Me.ShowDialog()
    End Sub

    Private Sub LoadLayOuts()
        If MBlnOrigenObra Then
            GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><AllowAddNew>True</AllowAddNew><AllowDelete>True</Al" & _
            "lowDelete><AllowEdit>True</AllowEdit><Columns Collection=""true""><Column0 ID=""IDC" & _
            "entroCoste""><Caption>Centro Coste</Caption><DataMember>IDCentroCoste</DataMember" & _
            "><EditType>Custom</EditType><Key>IDCentroCoste</Key><Position>0</Position><Width" & _
            ">400</Width></Column0><Column1 ID=""DescCentroCoste""><Caption>Descripción</Captio" & _
            "n><DataMember>DescCentroCoste</DataMember><EditType>NoEdit</EditType><Key>DescCe" & _
            "ntroCoste</Key><Position>1</Position><Width>235</Width></Column1><Column2 ID=""Po" & _
            "rcentaje""><AggregateFunction>Sum</AggregateFunction><Caption>Porcentaje</Caption" & _
            "><DataMember>Porcentaje</DataMember><FormatString>#,0.0###</FormatString><Key>Po" & _
            "rcentaje</Key><Position>2</Position><Width>74</Width><TotalFormatString>#,0.0###" & _
            "</TotalFormatString></Column2><Column3 ID=""IDObra""><Caption>IDObra</Captio" & _
            "n><DataMember>IDObra</DataMember><Key>IDObra</Key><Position>3</Position><V" & _
            "isible>False</Visible></Column3><Column4 ID=""IDAnalitica1""><Caption>IDAnalitica1" & _
            "</Caption><DataMember>IDAnalitica1</DataMember><EditType>NoEdit</EditType><Key>I" & _
            "DAnalitica1</Key><Position>4</Position><Visible>False</Visible></Column4><Column" & _
            "5 ID=""IDAnalitica2""><Caption>IDAnalitica2</Caption><DataMember>IDAnalitica2</Dat" & _
            "aMember><EditType>NoEdit</EditType><Key>IDAnalitica2</Key><Position>5</Position>" & _
            "<Visible>False</Visible></Column5><Column6 ID=""IDAnalitica3""><Caption>IDAnalitic" & _
            "a3</Caption><DataMember>IDAnalitica3</DataMember><EditType>NoEdit</EditType><Key" & _
            ">IDAnalitica3</Key><Position>6</Position><Visible>False</Visible></Column6><Colu" & _
            "mn7 ID=""IDAnalitica4""><Caption>IDAnalitica4</Caption><DataMember>IDAnalitica4</D" & _
            "ataMember><EditType>NoEdit</EditType><Key>IDAnalitica4</Key><Position>7</Positio" & _
            "n><Visible>False</Visible></Column7><Column8 ID=""IDAnalitica5""><Caption>IDAnalit" & _
            "ica5</Caption><DataMember>IDAnalitica5</DataMember><EditType>NoEdit</EditType><K" & _
            "ey>IDAnalitica5</Key><Position>8</Position><Visible>False</Visible></Column8></C" & _
            "olumns><GroupCondition ID="""" /></RootTable></GridEXLayoutData>"
            LblOrigen.Text = "Obra"
            Grid.DesignTimeLayout = GridEXLayout1
            Grid.Columns("IDObra").DefaultValue = MIntOrigen
            Grid.Columns("Porcentaje").DefaultValue = 0
        Else
            GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><AllowAddNew>True</AllowAddNew><AllowDelete>True</Al" & _
            "lowDelete><AllowEdit>True</AllowEdit><Columns Collection=""true""><Column0 ID=""IDC" & _
            "entroCoste""><Caption>Centro Coste</Caption><DataMember>IDCentroCoste</DataMember" & _
            "><EditType>Custom</EditType><Key>IDCentroCoste</Key><Position>0</Position><Width" & _
            ">400</Width></Column0><Column1 ID=""DescCentroCoste""><Caption>Descripción</Captio" & _
            "n><DataMember>DescCentroCoste</DataMember><EditType>NoEdit</EditType><Key>DescCe" & _
            "ntroCoste</Key><Position>1</Position><Width>239</Width></Column1><Column2 ID=""Po" & _
            "rcentaje""><AggregateFunction>Sum</AggregateFunction><Caption>Porcentaje</Caption" & _
            "><DataMember>Porcentaje</DataMember><FormatString>#,0.0###</FormatString><Key>Po" & _
            "rcentaje</Key><Position>2</Position><Width>74</Width><TotalFormatString>#,0.0###" & _
            "</TotalFormatString></Column2><Column3 ID=""IDTrabajo""><Caption>IDTrabajo</Captio" & _
            "n><DataMember>IDTrabajo</DataMember><Key>IDTrabajo</Key><Position>3</Position><V" & _
            "isible>False</Visible></Column3><Column4 ID=""IDAnalitica1""><Caption>IDAnalitica1" & _
            "</Caption><DataMember>IDAnalitica1</DataMember><EditType>NoEdit</EditType><Key>I" & _
            "DAnalitica1</Key><Position>4</Position><Visible>False</Visible></Column4><Column" & _
            "5 ID=""IDAnalitica2""><Caption>IDAnalitica2</Caption><DataMember>IDAnalitica2</Dat" & _
            "aMember><EditType>NoEdit</EditType><Key>IDAnalitica2</Key><Position>5</Position>" & _
            "<Visible>False</Visible></Column5><Column6 ID=""IDAnalitica3""><Caption>IDAnalitic" & _
            "a3</Caption><DataMember>IDAnalitica3</DataMember><EditType>NoEdit</EditType><Key" & _
            ">IDAnalitica3</Key><Position>6</Position><Visible>False</Visible></Column6><Colu" & _
            "mn7 ID=""IDAnalitica4""><Caption>IDAnalitica4</Caption><DataMember>IDAnalitica4</D" & _
            "ataMember><EditType>NoEdit</EditType><Key>IDAnalitica4</Key><Position>7</Positio" & _
            "n><Visible>False</Visible></Column7><Column8 ID=""IDAnalitica5""><Caption>IDAnalit" & _
            "ica5</Caption><DataMember>IDAnalitica5</DataMember><EditType>NoEdit</EditType><K" & _
            "ey>IDAnalitica5</Key><Position>8</Position><Visible>False</Visible></Column8></C" & _
            "olumns><GroupCondition ID="""" /></RootTable></GridEXLayoutData>"
            LblOrigen.Text = "Trabajo"
            Grid.DesignTimeLayout = GridEXLayout1
            Grid.Columns("IDTrabajo").DefaultValue = MIntOrigen
            Grid.Columns("Porcentaje").DefaultValue = 0
        End If
    End Sub

    Private Sub LoadColumns()
        MIntNiveles = New Parametro().NivelesDeAnalitica
        If MIntNiveles <> EnumNivelesAnalitica.Nivel0 Then
            Dim ClsBE As New BE.DataEngine
            Dim DtAnalit1 As DataTable = ClsBE.GetPrimaryKey("AnaliticaNivel1")
            Dim DtAnalit2 As DataTable = ClsBE.GetPrimaryKey("AnaliticaNivel2")
            Dim DtAnalit3 As DataTable = ClsBE.GetPrimaryKey("AnaliticaNivel3")
            Dim DtAnalit4 As DataTable = ClsBE.GetPrimaryKey("AnaliticaNivel4")
            Dim DtAnalit5 As DataTable = ClsBE.GetPrimaryKey("AnaliticaNivel5")

            If Not DtAnalit1 Is Nothing AndAlso DtAnalit1.Rows.Count > 0 Then
                SubGrid.Columns("IDAnalitica1").MaxLength = DtAnalit1.Columns(0).MaxLength
                SubGrid.Columns("IDAnalitica1").InputMask = New String("A", DtAnalit1.Columns(0).MaxLength)
            End If
            If Not DtAnalit2 Is Nothing AndAlso DtAnalit2.Rows.Count > 0 Then
                SubGrid.Columns("IDAnalitica2").MaxLength = DtAnalit2.Columns(0).MaxLength
                SubGrid.Columns("IDAnalitica2").InputMask = New String("A", DtAnalit2.Columns(0).MaxLength)
            End If
            If Not DtAnalit3 Is Nothing AndAlso DtAnalit3.Rows.Count > 0 Then
                SubGrid.Columns("IDAnalitica3").MaxLength = DtAnalit3.Columns(0).MaxLength
                SubGrid.Columns("IDAnalitica3").InputMask = New String("A", DtAnalit3.Columns(0).MaxLength)
            End If
            If Not DtAnalit4 Is Nothing AndAlso DtAnalit4.Rows.Count > 0 Then
                SubGrid.Columns("IDAnalitica4").MaxLength = DtAnalit4.Columns(0).MaxLength
                SubGrid.Columns("IDAnalitica4").InputMask = New String("A", DtAnalit4.Columns(0).MaxLength)
            End If
            If Not DtAnalit5 Is Nothing AndAlso DtAnalit5.Rows.Count > 0 Then
                SubGrid.Columns("IDAnalitica5").MaxLength = DtAnalit5.Columns(0).MaxLength
                SubGrid.Columns("IDAnalitica5").InputMask = New String("A", DtAnalit5.Columns(0).MaxLength)
            End If

            Select Case MIntNiveles
                Case 1
                    SubGrid.Columns("IDAnalitica2").Visible = False : SubGrid.Columns("IDAnalitica2").EditType = EditType.NoEdit : SubGrid.Columns("IDAnalitica2").ButtonStyle = ButtonStyle.NoButton
                    SubGrid.Columns("IDAnalitica3").Visible = False : SubGrid.Columns("IDAnalitica3").EditType = EditType.NoEdit : SubGrid.Columns("IDAnalitica3").ButtonStyle = ButtonStyle.NoButton
                    SubGrid.Columns("IDAnalitica4").Visible = False : SubGrid.Columns("IDAnalitica4").EditType = EditType.NoEdit : SubGrid.Columns("IDAnalitica4").ButtonStyle = ButtonStyle.NoButton
                    SubGrid.Columns("IDAnalitica5").Visible = False : SubGrid.Columns("IDAnalitica5").EditType = EditType.NoEdit : SubGrid.Columns("IDAnalitica5").ButtonStyle = ButtonStyle.NoButton
                Case 2
                    SubGrid.Columns("IDAnalitica3").Visible = False : SubGrid.Columns("IDAnalitica3").EditType = EditType.NoEdit : SubGrid.Columns("IDAnalitica3").ButtonStyle = ButtonStyle.NoButton
                    SubGrid.Columns("IDAnalitica4").Visible = False : SubGrid.Columns("IDAnalitica4").EditType = EditType.NoEdit : SubGrid.Columns("IDAnalitica4").ButtonStyle = ButtonStyle.NoButton
                    SubGrid.Columns("IDAnalitica5").Visible = False : SubGrid.Columns("IDAnalitica5").EditType = EditType.NoEdit : SubGrid.Columns("IDAnalitica5").ButtonStyle = ButtonStyle.NoButton
                Case 3
                    SubGrid.Columns("IDAnalitica4").Visible = False : SubGrid.Columns("IDAnalitica4").EditType = EditType.NoEdit : SubGrid.Columns("IDAnalitica4").ButtonStyle = ButtonStyle.NoButton
                    SubGrid.Columns("IDAnalitica5").Visible = False : SubGrid.Columns("IDAnalitica5").EditType = EditType.NoEdit : SubGrid.Columns("IDAnalitica5").ButtonStyle = ButtonStyle.NoButton
                Case 4
                    SubGrid.Columns("IDAnalitica5").Visible = False : SubGrid.Columns("IDAnalitica5").EditType = EditType.NoEdit : SubGrid.Columns("IDAnalitica5").ButtonStyle = ButtonStyle.NoButton
            End Select

            Grid.Columns("IDCentroCoste").Width = MIntNiveles * 80
        Else
            Grid.AdvSearchColumns.Add("CentroCosteAnalitica", "IDCentroCoste", "IDCentroCoste")
            Dim AdvIcon As New Icon(Engine.UI.Resources.AdvSearchIcon, 16, 16)
            Grid.Columns("IDCentroCoste").ButtonImage = AdvIcon.ToBitmap
            Grid.Columns("IDCentroCoste").Width = 100
        End If
    End Sub

    Private Function CalcularIDCoste() As String
        Dim StrIDCoste As String = String.Empty
        Dim IntCuenta As Integer = 0
        For i As Integer = 1 To MIntNiveles
            If Length(SubGrid.GetValue("IDAnalitica" & i)) = 0 Then
                IntCuenta += 1
            End If
        Next
        If IntCuenta <> MIntNiveles Then
            For j As Integer = 1 To MIntNiveles
                If Length(SubGrid.GetValue("IDAnalitica" & j)) = 0 Then
                    SubGrid.SetValue("IDAnalitica" & j, New String("@", MIntNiveles))
                End If
                Grid.SetValue("IDAnalitica" & j, SubGrid.GetValue("IDAnalitica" & j))
                StrIDCoste &= SubGrid.GetValue("IDAnalitica" & j)
            Next
        End If
        Return StrIDCoste
    End Function

    Private Sub LoadAdvSearchSettings()
        Dim AdvIcon As New Icon(Engine.UI.Resources.AdvSearchIcon, 16, 16)
        sctIDAnalitica1 = New AdvancedSearch
        sctIDAnalitica1.EntityName = "AnaliticaNivel1"
        SubGrid.Columns("IDAnalitica1").ButtonImage = AdvIcon.ToBitmap

        Dim f As Filter
        sctIDAnalitica2 = New AdvancedSearch
        Dim dtR12 As DataTable = New AnaliticaR12().Filter(f, , "TOP 1 *")
        If Not dtR12 Is Nothing AndAlso dtR12.Rows.Count > 0 Then
            sctIDAnalitica2.EntityName = "AnaliticaR12"
            sctIDAnalitica2.ViewName = "vFrmAnaliticaR12"
        Else
            sctIDAnalitica2.EntityName = "AnaliticaNivel2"
        End If
        SubGrid.Columns("IDAnalitica2").ButtonImage = AdvIcon.ToBitmap

        sctIDAnalitica3 = New AdvancedSearch
        Dim dtR23 As DataTable = New AnaliticaR23().Filter(f, , "TOP 1 *")
        If Not dtR23 Is Nothing AndAlso dtR23.Rows.Count > 0 Then
            sctIDAnalitica3.EntityName = "AnaliticaR23"
            sctIDAnalitica3.ViewName = "vFrmAnaliticaR23"
        Else
            sctIDAnalitica3.EntityName = "AnaliticaNivel3"
        End If
        SubGrid.Columns("IDAnalitica3").ButtonImage = AdvIcon.ToBitmap

        sctIDAnalitica4 = New AdvancedSearch
        Dim dtR34 As DataTable = New AnaliticaR34().Filter(f, , "TOP 1 *")
        If Not dtR34 Is Nothing AndAlso dtR34.Rows.Count > 0 Then
            sctIDAnalitica4.EntityName = "AnaliticaR34"
            sctIDAnalitica4.ViewName = "vFrmAnaliticaR34"
        Else
            sctIDAnalitica4.EntityName = "AnaliticaNivel4"
        End If
        SubGrid.Columns("IDAnalitica4").ButtonImage = AdvIcon.ToBitmap

        sctIDAnalitica5 = New AdvancedSearch
        Dim dtR45 As DataTable = New AnaliticaR45().Filter(f, , "TOP 1 *")
        If Not dtR45 Is Nothing AndAlso dtR45.Rows.Count > 0 Then
            sctIDAnalitica5.EntityName = "AnaliticaR45"
            sctIDAnalitica5.ViewName = "vFrmAnaliticaR45"
        Else
            sctIDAnalitica5.EntityName = "AnaliticaNivel5"
        End If
        SubGrid.Columns("IDAnalitica5").ButtonImage = AdvIcon.ToBitmap
    End Sub

    Private Sub ComprobarIDCoste()
        Dim ClsCoste As New CentroCosteAnalitica
        Dim DtCoste As DataTable
        Dim DtCosteFinal As DataTable = ClsCoste.AddNew
        Dim DtGrid As DataTable = Grid.DataSource

        Dim IntLenAnalit1 As Integer = DtCosteFinal.Columns("IDAnalitica1").MaxLength
        Dim IntLenAnalit2 As Integer = DtCosteFinal.Columns("IDAnalitica2").MaxLength
        Dim IntLenAnalit3 As Integer = DtCosteFinal.Columns("IDAnalitica3").MaxLength
        Dim IntLenAnalit4 As Integer = DtCosteFinal.Columns("IDAnalitica4").MaxLength
        Dim IntLenAnalit5 As Integer = DtCosteFinal.Columns("IDAnalitica5").MaxLength

        For Each Dr As DataRow In DtGrid.Select
            DtCoste = ClsCoste.SelOnPrimaryKey(Dr("IDCentroCoste"))
            If DtCoste Is Nothing OrElse DtCoste.Rows.Count = 0 Then
                Dim DrNew As DataRow = DtCosteFinal.NewRow
                DrNew("IDCentroCoste") = Dr("IDCentroCoste")
                DrNew("DescCentroCoste") = "Desc. Centro: " & Dr("IDCentroCoste")
                If MIntNiveles >= 1 Then
                    DrNew("IDAnalitica1") = DrNew("IDCentroCoste").Substring(0, IntLenAnalit1)
                End If
                If MIntNiveles >= 2 Then
                    DrNew("IDAnalitica2") = DrNew("IDCentroCoste").Substring(IntLenAnalit1, IntLenAnalit2)
                End If
                If MIntNiveles >= 3 Then
                    DrNew("IDAnalitica3") = DrNew("IDCentroCoste").Substring((IntLenAnalit1 + IntLenAnalit2), IntLenAnalit3)
                End If
                If MIntNiveles >= 4 Then
                    DrNew("IDAnalitica4") = DrNew("IDCentroCoste").Substring((IntLenAnalit1 + IntLenAnalit2 + IntLenAnalit3), IntLenAnalit4)
                End If
                If MIntNiveles >= 5 Then
                    DrNew("IDAnalitica5") = DrNew("IDCentroCoste").Substring((IntLenAnalit1 + IntLenAnalit2 + IntLenAnalit3 + IntLenAnalit4), IntLenAnalit5)
                End If
                DtCosteFinal.Rows.Add(DrNew)
            End If
        Next
        If DtCosteFinal.Rows.Count > 0 Then ClsCoste.Update(DtCosteFinal)
    End Sub

    Private Function ComprobarIDAnalitica(ByVal IntLevel As Integer) As Boolean
        Dim ClsObj As BE.BusinessHelper
        Select Case IntLevel
            Case 1
                ClsObj = New AnaliticaNivel1
            Case 2
                ClsObj = New AnaliticaNivel2
            Case 3
                ClsObj = New AnaliticaNivel3
            Case 4
                ClsObj = New AnaliticaNivel4
            Case 5
                ClsObj = New AnaliticaNivel5
        End Select
        Dim DtAnalit As DataTable = ClsObj.SelOnPrimaryKey(SubGrid.GetValue("IDAnalitica" & IntLevel))
        If DtAnalit Is Nothing OrElse DtAnalit.Rows.Count = 0 Then
            ExpertisApp.GenerateMessage("El Código introducido no existe.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            SubGrid.SetValue("IDAnalitica" & IntLevel, String.Empty)
            Return False
        Else
            Dim FilBE As New Filter
            Dim DtBE As DataTable
            Dim ClsBE As New BE.DataEngine
            Select Case IntLevel
                Case 2
                    FilBE.Add("IDAnalitica1", FilterOperator.Equal, SubGrid.GetValue("IDAnalitica1"))
                    FilBE.Add("IDAnalitica2", FilterOperator.Equal, SubGrid.GetValue("IDAnalitica2"))
                    DtBE = ClsBE.Filter("vFrmAnaliticaR12", FilBE)
                    If DtBE Is Nothing OrElse DtBE.Rows.Count = 0 Then
                        DtBE = ClsBE.Filter("vFrmAnaliticaR12", "", "")
                        If Not DtBE Is Nothing AndAlso DtBE.Rows.Count > 0 Then
                            ExpertisApp.GenerateMessage("El Código introducido no existe.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            SubGrid.SetValue("IDAnalitica" & IntLevel, String.Empty)
                            Return False
                        End If
                    End If
                Case 3
                    FilBE.Add("IDAnalitica2", FilterOperator.Equal, SubGrid.GetValue("IDAnalitica2"))
                    FilBE.Add("IDAnalitica3", FilterOperator.Equal, SubGrid.GetValue("IDAnalitica3"))
                    DtBE = ClsBE.Filter("vFrmAnaliticaR23", FilBE)
                    If DtBE Is Nothing OrElse DtBE.Rows.Count = 0 Then
                        DtBE = ClsBE.Filter("vFrmAnaliticaR23", "", "")
                        If Not DtBE Is Nothing AndAlso DtBE.Rows.Count > 0 Then
                            ExpertisApp.GenerateMessage("El Código introducido no existe.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            SubGrid.SetValue("IDAnalitica" & IntLevel, String.Empty)
                            Return False
                        End If
                    End If
                Case 4
                    FilBE.Add("IDAnalitica3", FilterOperator.Equal, SubGrid.GetValue("IDAnalitica3"))
                    FilBE.Add("IDAnalitica4", FilterOperator.Equal, SubGrid.GetValue("IDAnalitica4"))
                    DtBE = ClsBE.Filter("vFrmAnaliticaR34", FilBE)
                    If DtBE Is Nothing OrElse DtBE.Rows.Count = 0 Then
                        DtBE = ClsBE.Filter("vFrmAnaliticaR34", "", "")
                        If Not DtBE Is Nothing AndAlso DtBE.Rows.Count > 0 Then
                            ExpertisApp.GenerateMessage("El Código introducido no existe.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            SubGrid.SetValue("IDAnalitica" & IntLevel, String.Empty)
                            Return False
                        End If
                    End If
                Case 5
                    FilBE.Add("IDAnalitica4", FilterOperator.Equal, SubGrid.GetValue("IDAnalitica4"))
                    FilBE.Add("IDAnalitica5", FilterOperator.Equal, SubGrid.GetValue("IDAnalitica5"))
                    DtBE = ClsBE.Filter("vFrmAnaliticaR45", FilBE)
                    If DtBE Is Nothing OrElse DtBE.Rows.Count = 0 Then
                        DtBE = ClsBE.Filter("vFrmAnaliticaR45", "", "")
                        If Not DtBE Is Nothing AndAlso DtBE.Rows.Count > 0 Then
                            ExpertisApp.GenerateMessage("El Código introducido no existe.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            SubGrid.SetValue("IDAnalitica" & IntLevel, String.Empty)
                            Return False
                        End If
                    End If
            End Select
        End If
        Return True
    End Function

    Private Sub BuscarDescripcion(ByVal StrIDCentro As String)
        Dim DtCentro As DataTable = New CentroCosteAnalitica().SelOnPrimaryKey(StrIDCentro)
        If Not DtCentro Is Nothing AndAlso DtCentro.Rows.Count > 0 Then
            Grid.SetValue("DescCentroCoste", DtCentro.Rows(0)("DescCentroCoste"))
        End If
    End Sub

    Private Sub CrearIDCoste(ByVal StrIDCoste As String)
        Dim ClsCoste As New CentroCosteAnalitica
        Dim DtCoste As DataTable = ClsCoste.SelOnPrimaryKey(StrIDCoste)
        If DtCoste Is Nothing OrElse DtCoste.Rows.Count = 0 Then
            Dim DtNew As DataTable = DtCoste.Clone
            Dim DrNew As DataRow = DtNew.NewRow
            DrNew("IDCentroCoste") = StrIDCoste
            DrNew("DescCentroCoste") = "Centro Coste Analitico"
            DrNew("IDAnalitica1") = SubGrid.GetValue("IDAnalitica1")
            DrNew("IDAnalitica2") = SubGrid.GetValue("IDAnalitica2")
            DrNew("IDAnalitica3") = SubGrid.GetValue("IDAnalitica3")
            DrNew("IDAnalitica4") = SubGrid.GetValue("IDAnalitica4")
            DrNew("IDAnalitica5") = SubGrid.GetValue("IDAnalitica5")
            DtNew.Rows.Add(DrNew)
            ClsCoste.Update(DtNew)
        End If
    End Sub

    Private Sub LimpiarIDAnaliticas(ByVal IntLevelDesde As Integer)
        For i As Integer = IntLevelDesde To MIntNiveles
            SubGrid.SetValue("IDAnalitica" & i, String.Empty)
        Next
    End Sub

#End Region

#Region "Eventos FrmAnalitica"

#Region "Eventos Formulario"

    Private Sub frmAnalitica_BusinessCalling(ByVal sender As Object, ByVal e As Engine.UI.BusinessCallingEventArgs) Handles MyBase.BusinessCalling
        e.Data.Context.Clear()
        Select Case e.EntityName
            Case Grid.EntityName
                e.Data.Context("IDMoneda") = mMoneda.ID
                e.Data.Context("Fecha") = mFecha
        End Select
    End Sub

    Private Sub frmAnalitica_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If mQueryOnclose Then
            e.Cancel = (ExpertisApp.GenerateMessage("¿Desea realmente perder el desglose realizado?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.No)
        End If
    End Sub

#End Region

#Region "Eventos DataGrid"

    Private Sub grid_EditingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles Grid.EditingCell
        If Not mReadOnly Then
            With Grid
                Select Case e.Column.Key
                    Case "IDCentroCoste"
                        If .Row = Grid.newTopRowPosition Then
                            If MIntNiveles = EnumNivelesAnalitica.Nivel0 Then
                                e.Column.EditType = EditType.TextBox
                                e.Column.ButtonStyle = ButtonStyle.Image
                            Else
                                e.Column.EditType = EditType.Custom
                            End If
                        Else
                            e.Cancel = True
                        End If
                End Select
            End With
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub grid_CellUpdated(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles Grid.CellUpdated
        If e.Column.Key = "Porcentaje" Then
            Totales()
        End If
    End Sub

    Private Sub grid_RecordUpdated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grid.RecordUpdated
        Totales()
    End Sub

    'Private Sub grid_AddingRecord(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Grid.AddingRecord
    '    Totales()
    'End Sub


    Private Sub grid_RecordsDeleted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grid.RecordsDeleted
        Totales()
        mPendingUpdate = True
    End Sub

    Private Sub Grid_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid.RecordAdded
        Totales()
    End Sub

    Private Sub grid_RowEditCanceled(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles Grid.RowEditCanceled
        Totales()
    End Sub

    Private Sub grid_CellValueChanged(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles Grid.CellValueChanged
        mQueryOnclose = True
        mPendingUpdate = True
    End Sub

    Private Sub Grid_InitCustomEdit(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.InitCustomEditEventArgs) Handles Grid.InitCustomEdit
        Dim DtNew As New DataTable
        DtNew.Columns.Add("IDAnalitica1", GetType(String))
        DtNew.Columns.Add("IDAnalitica2", GetType(String))
        DtNew.Columns.Add("IDAnalitica3", GetType(String))
        DtNew.Columns.Add("IDAnalitica4", GetType(String))
        DtNew.Columns.Add("IDAnalitica5", GetType(String))

        SubGrid.DataSource = DtNew
        e.EditControl = SubGrid
        SubGrid.Row = Grid.newTopRowPosition

        Dim StrCoste As String = Nz(e.Value, String.Empty)
        If Length(StrCoste) > 0 Then
            Dim IntLenAnalit1 As Integer = SubGrid.Columns("IDAnalitica1").MaxLength
            Dim IntLenAnalit2 As Integer = SubGrid.Columns("IDAnalitica2").MaxLength
            Dim IntLenAnalit3 As Integer = SubGrid.Columns("IDAnalitica3").MaxLength
            Dim IntLenAnalit4 As Integer = SubGrid.Columns("IDAnalitica4").MaxLength
            Dim IntLenAnalit5 As Integer = SubGrid.Columns("IDAnalitica5").MaxLength

            Dim IntLenTotal As Integer = 0
            If MIntNiveles >= 1 Then IntLenTotal += IntLenAnalit1
            If MIntNiveles >= 2 Then IntLenTotal += IntLenAnalit2
            If MIntNiveles >= 3 Then IntLenTotal += IntLenAnalit3
            If MIntNiveles >= 4 Then IntLenTotal += IntLenAnalit4
            If MIntNiveles = 5 Then IntLenTotal += IntLenAnalit5

            If Len(StrCoste) = IntLenTotal Then
                If MIntNiveles >= 1 Then
                    SubGrid.SetValue("IDAnalitica1", StrCoste.Substring(0, IntLenAnalit1))
                End If
                If MIntNiveles >= 2 Then
                    SubGrid.SetValue("IDAnalitica2", StrCoste.Substring(IntLenAnalit1, IntLenAnalit2))
                End If
                If MIntNiveles >= 3 Then
                    SubGrid.SetValue("IDAnalitica3", StrCoste.Substring((IntLenAnalit1 + IntLenAnalit2), IntLenAnalit3))
                End If
                If MIntNiveles >= 4 Then
                    SubGrid.SetValue("IDAnalitica4", StrCoste.Substring((IntLenAnalit1 + IntLenAnalit2 + IntLenAnalit3), IntLenAnalit4))
                End If
                If MIntNiveles >= 5 Then
                    SubGrid.SetValue("IDAnalitica5", StrCoste.Substring((IntLenAnalit1 + IntLenAnalit2 + IntLenAnalit3 + IntLenAnalit4), IntLenAnalit5))
                End If
            End If
        End If
    End Sub

    Private Sub Grid_EndCustomEdit(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EndCustomEditEventArgs) Handles Grid.EndCustomEdit
        Dim StrIDCoste As String = CalcularIDCoste()
        If Len(StrIDCoste) > 0 Then
            e.Value = StrIDCoste
            'BuscarDescripcion(e.Value)
            CrearIDCoste(e.Value)
        End If
    End Sub

    Private Sub SubGrid_CellValueChanged(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles SubGrid.CellValueChanged
        If (e.Column.Index + 1) >= 0 AndAlso (e.Column.Index + 1) <= 4 Then
            If Len(CStr(SubGrid.GetValue("IDAnalitica" & (e.Column.Index + 1)))) = SubGrid.Columns("IDAnalitica" & (e.Column.Index + 1)).MaxLength Then
                If ComprobarIDAnalitica(e.Column.Index + 1) Then
                    LimpiarIDAnaliticas(e.Column.Index + 2)
                    If e.Column.Index + 1 = MIntNiveles Then
                        Grid.Col = 1
                    Else : SubGrid.Col += 1
                    End If
                Else
                    LimpiarIDAnaliticas(e.Column.Index + 2)
                End If
            End If
        Else
            If Len(CStr(SubGrid.GetValue("IDAnalitica5"))) = SubGrid.Columns("IDAnalitica5").MaxLength Then
                ComprobarIDAnalitica(e.Column.Index + 1)
                Grid.Col = 1
            End If
        End If
    End Sub

    Private Sub SubGrid_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SubGrid.Click
        Dim hit As GridArea
        With SubGrid
            hit = .HitTest()
            If hit = GridArea.CellButton Then
                Dim c As GridEXColumn = .ColumnFromPoint()
                If Not IsNothing(c) Then
                    Select Case c.Key
                        Case "IDAnalitica1"
                            sctIDAnalitica1.Open()
                        Case "IDAnalitica2"
                            sctIDAnalitica2.Open()
                        Case "IDAnalitica3"
                            sctIDAnalitica3.Open()
                        Case "IDAnalitica4"
                            sctIDAnalitica4.Open()
                        Case "IDAnalitica5"
                            sctIDAnalitica5.Open()
                    End Select
                End If
            End If
        End With
    End Sub

    Private Sub SubGrid_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles SubGrid.KeyUp
        If e.KeyCode = Keys.F4 Then
            Select Case SubGrid.Col
                Case SubGrid.Columns("IDAnalitica1").Index
                    sctIDAnalitica1.Open()
                Case SubGrid.Columns("IDAnalitica2").Index
                    sctIDAnalitica2.Open()
                Case SubGrid.Columns("IDAnalitica3").Index
                    sctIDAnalitica3.Open()
                Case SubGrid.Columns("IDAnalitica4").Index
                    sctIDAnalitica4.Open()
                Case SubGrid.Columns("IDAnalitica5").Index
                    sctIDAnalitica5.Open()
            End Select
        End If
    End Sub

    Private Sub SubGrid_AddingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SubGrid.AddingRecord
        e.Cancel = True
    End Sub

#End Region

#Region "Eventos Buttons"

    Private Sub ButtonOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonOK.Click
        mQueryOnclose = False
        If Not mReadOnly Then
            If mPendingUpdate Then
                ComprobarIDCoste()
                Me.UpdateData()
                Me.Close()
            End If
        End If
        Me.Close()
    End Sub

    Private Sub ButtonCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancel.Click
        Me.Close()
    End Sub

#End Region

#Region "Eventos AdvSearch"

    Private Sub sctIDAnalitica1_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles sctIDAnalitica1.SelectionChanged
        SubGrid.SetValue("IDAnalitica1", e.Selected.Rows(0)("IDAnalitica1"))
    End Sub

    Private Sub sctIDAnalitica2_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles sctIDAnalitica2.SelectionChanged
        SubGrid.SetValue("IDAnalitica2", e.Selected.Rows(0)("IDAnalitica2"))
    End Sub

    Private Sub sctIDAnalitica3_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles sctIDAnalitica3.SelectionChanged
        SubGrid.SetValue("IDAnalitica3", e.Selected.Rows(0)("IDAnalitica3"))
    End Sub

    Private Sub sctIDAnalitica4_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles sctIDAnalitica4.SelectionChanged
        SubGrid.SetValue("IDAnalitica4", e.Selected.Rows(0)("IDAnalitica4"))
    End Sub

    Private Sub sctIDAnalitica5_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles sctIDAnalitica5.SelectionChanged
        SubGrid.SetValue("IDAnalitica5", e.Selected.Rows(0)("IDAnalitica5"))
    End Sub

    Private Sub sctIDAnalitica2_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles sctIDAnalitica2.SetPredefinedFilter
        If sctIDAnalitica2.EntityName = GetType(AnaliticaR12).Name Then
            If Length(SubGrid.GetValue("IDAnalitica1")) > 0 Then
                e.Filter.Add("IDAnalitica1", FilterOperator.Equal, SubGrid.GetValue("IDAnalitica1"))
            End If
        End If
    End Sub

    Private Sub sctIDAnalitica3_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles sctIDAnalitica3.SetPredefinedFilter
        If sctIDAnalitica3.EntityName = GetType(AnaliticaR23).Name Then
            If Length(SubGrid.GetValue("IDAnalitica2")) > 0 Then
                e.Filter.Add("IDAnalitica2", FilterOperator.Equal, SubGrid.GetValue("IDAnalitica2"))
            End If
        End If
    End Sub

    Private Sub sctIDAnalitica4_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles sctIDAnalitica4.SetPredefinedFilter
        If sctIDAnalitica4.EntityName = GetType(AnaliticaR34).Name Then
            If Length(SubGrid.GetValue("IDAnalitica3")) > 0 Then
                e.Filter.Add("IDAnalitica3", FilterOperator.Equal, SubGrid.GetValue("IDAnalitica3"))
            End If
        End If
    End Sub

    Private Sub sctIDAnalitica5_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles sctIDAnalitica5.SetPredefinedFilter
        If sctIDAnalitica5.EntityName = GetType(AnaliticaR45).Name Then
            If Length(SubGrid.GetValue("IDAnalitica4")) > 0 Then
                e.Filter.Add("IDAnalitica4", FilterOperator.Equal, SubGrid.GetValue("IDAnalitica4"))
            End If
        End If
    End Sub

#End Region

#End Region

   
End Class