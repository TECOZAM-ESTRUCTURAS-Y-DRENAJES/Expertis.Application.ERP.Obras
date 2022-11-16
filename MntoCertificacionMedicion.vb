Public Class MntoCertificacionMedicion
    Inherits Solmicro.Expertis.Engine.UI.SimpleMnto

#Region " C�digo generado por el Dise�ador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Dise�ador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicializaci�n despu�s de la llamada a InitializeComponent()

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

    'Requerido por el Dise�ador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Dise�ador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Dise�ador de Windows Forms. 
    'No lo modifique con el editor de c�digo.
    Friend WithEvents pnlFichaMedicion As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents ulbDescObra As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents ulbDescTrabajo As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents ulbDescCertificacion As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents advIDCertificacion As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblFechaCreacion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblEstado As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblDescMedicion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtDescMedicion As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblQPI As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblPIPorc As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblPIOrigen As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblPIPorcOrigen As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblLargo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblAncho As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblAlto As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblTotal As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents pnlObservaciones As System.Windows.Forms.Panel
    Friend WithEvents txtObservaciones As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblObservaciones As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtTotal As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtAlto As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtAncho As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtLargo As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtPIPorcOrigen As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtPIOrigen As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtPIPorc As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtQPI As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtQPrev As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents cbxEstado As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents cbxFechaCreacion As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblCertificacion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDTrabajo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents advIDObra As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblObra As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblCantidad As Solmicro.Expertis.Engine.UI.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MntoCertificacionMedicion))
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.pnlFichaMedicion = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblObservaciones = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTotal = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtAlto = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtAncho = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtLargo = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtPIPorcOrigen = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtPIOrigen = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtPIPorc = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtQPI = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtQPrev = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtDescMedicion = New Solmicro.Expertis.Engine.UI.TextBox
        Me.cbxEstado = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.cbxFechaCreacion = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.ulbDescCertificacion = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.advIDCertificacion = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblCertificacion = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFechaCreacion = New Solmicro.Expertis.Engine.UI.Label
        Me.lblEstado = New Solmicro.Expertis.Engine.UI.Label
        Me.ulbDescTrabajo = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.advIDTrabajo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.ulbDescObra = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.advIDObra = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblObra = New Solmicro.Expertis.Engine.UI.Label
        Me.lblTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.lblDescMedicion = New Solmicro.Expertis.Engine.UI.Label
        Me.lblCantidad = New Solmicro.Expertis.Engine.UI.Label
        Me.lblQPI = New Solmicro.Expertis.Engine.UI.Label
        Me.lblPIPorc = New Solmicro.Expertis.Engine.UI.Label
        Me.lblPIOrigen = New Solmicro.Expertis.Engine.UI.Label
        Me.lblPIPorcOrigen = New Solmicro.Expertis.Engine.UI.Label
        Me.lblLargo = New Solmicro.Expertis.Engine.UI.Label
        Me.lblAncho = New Solmicro.Expertis.Engine.UI.Label
        Me.lblAlto = New Solmicro.Expertis.Engine.UI.Label
        Me.lblTotal = New Solmicro.Expertis.Engine.UI.Label
        Me.pnlObservaciones = New System.Windows.Forms.Panel
        Me.txtObservaciones = New Solmicro.Expertis.Engine.UI.TextBox
        CType(Me.ToolBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.suspendlayout()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFichaMedicion.suspendlayout()
        Me.pnlObservaciones.SuspendLayout()
        '
        'Find
        '
        Me.Find.Icon = CType(resources.GetObject("Find.Icon"), System.Drawing.Icon)
        Me.Find.Text = ""
        '
        'Search
        '
        Me.Search.Icon = CType(resources.GetObject("Search.Icon"), System.Drawing.Icon)
        Me.Search.Text = ""
        '
        'Requery
        '
        Me.Requery.Icon = CType(resources.GetObject("Requery.Icon"), System.Drawing.Icon)
        Me.Requery.Text = ""
        '
        'ToolBar
        '
        Me.ToolBar.Name = "ToolBar"
        Me.ToolBar.Size = New System.Drawing.Size(629, 42)
        '
        'MenuBar
        '
        Me.MenuBar.Location = New System.Drawing.Point(0, 42)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(792, 24)
        '
        'MainPanel
        '
        Me.MainPanel.Controls.Add(Me.pnlObservaciones)
        Me.MainPanel.Controls.Add(Me.pnlFichaMedicion)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(784, 442)
        '
        'GoFirst
        '
        Me.GoFirst.Icon = CType(resources.GetObject("GoFirst.Icon"), System.Drawing.Icon)
        '
        'GoPrevious
        '
        Me.GoPrevious.Icon = CType(resources.GetObject("GoPrevious.Icon"), System.Drawing.Icon)
        '
        'GoNext
        '
        Me.GoNext.Icon = CType(resources.GetObject("GoNext.Icon"), System.Drawing.Icon)
        '
        'ExecuteActions
        '
        Me.ExecuteActions.Icon = CType(resources.GetObject("ExecuteActions.Icon"), System.Drawing.Icon)
        Me.ExecuteActions.Text = ""
        '
        'Delete
        '
        Me.Delete.Icon = CType(resources.GetObject("Delete.Icon"), System.Drawing.Icon)
        Me.Delete.Text = ""
        '
        'Ok
        '
        Me.Ok.Icon = CType(resources.GetObject("Ok.Icon"), System.Drawing.Icon)
        Me.Ok.Text = ""
        '
        'Cancel
        '
        Me.Cancel.Icon = CType(resources.GetObject("Cancel.Icon"), System.Drawing.Icon)
        Me.Cancel.Text = ""
        '
        'GoLast
        '
        Me.GoLast.Icon = CType(resources.GetObject("GoLast.Icon"), System.Drawing.Icon)
        '
        'NewRow
        '
        Me.NewRow.Icon = CType(resources.GetObject("NewRow.Icon"), System.Drawing.Icon)
        Me.NewRow.Text = ""
        Me.NewRow.Visible = Janus.Windows.UI.InheritableBoolean.False
        '
        'Print
        '
        Me.Print.Icon = CType(resources.GetObject("Print.Icon"), System.Drawing.Icon)
        Me.Print.Text = ""
        '
        'pnlFichaMedicion
        '
        Me.pnlFichaMedicion.Controls.Add(Me.lblObservaciones)
        Me.pnlFichaMedicion.Controls.Add(Me.txtTotal)
        Me.pnlFichaMedicion.Controls.Add(Me.txtAlto)
        Me.pnlFichaMedicion.Controls.Add(Me.txtAncho)
        Me.pnlFichaMedicion.Controls.Add(Me.txtLargo)
        Me.pnlFichaMedicion.Controls.Add(Me.txtPIPorcOrigen)
        Me.pnlFichaMedicion.Controls.Add(Me.txtPIOrigen)
        Me.pnlFichaMedicion.Controls.Add(Me.txtPIPorc)
        Me.pnlFichaMedicion.Controls.Add(Me.txtQPI)
        Me.pnlFichaMedicion.Controls.Add(Me.txtQPrev)
        Me.pnlFichaMedicion.Controls.Add(Me.txtDescMedicion)
        Me.pnlFichaMedicion.Controls.Add(Me.cbxEstado)
        Me.pnlFichaMedicion.Controls.Add(Me.cbxFechaCreacion)
        Me.pnlFichaMedicion.Controls.Add(Me.ulbDescCertificacion)
        Me.pnlFichaMedicion.Controls.Add(Me.advIDCertificacion)
        Me.pnlFichaMedicion.Controls.Add(Me.lblCertificacion)
        Me.pnlFichaMedicion.Controls.Add(Me.lblFechaCreacion)
        Me.pnlFichaMedicion.Controls.Add(Me.lblEstado)
        Me.pnlFichaMedicion.Controls.Add(Me.ulbDescTrabajo)
        Me.pnlFichaMedicion.Controls.Add(Me.advIDTrabajo)
        Me.pnlFichaMedicion.Controls.Add(Me.ulbDescObra)
        Me.pnlFichaMedicion.Controls.Add(Me.advIDObra)
        Me.pnlFichaMedicion.Controls.Add(Me.lblObra)
        Me.pnlFichaMedicion.Controls.Add(Me.lblTrabajo)
        Me.pnlFichaMedicion.Controls.Add(Me.lblDescMedicion)
        Me.pnlFichaMedicion.Controls.Add(Me.lblCantidad)
        Me.pnlFichaMedicion.Controls.Add(Me.lblQPI)
        Me.pnlFichaMedicion.Controls.Add(Me.lblPIPorc)
        Me.pnlFichaMedicion.Controls.Add(Me.lblPIOrigen)
        Me.pnlFichaMedicion.Controls.Add(Me.lblPIPorcOrigen)
        Me.pnlFichaMedicion.Controls.Add(Me.lblLargo)
        Me.pnlFichaMedicion.Controls.Add(Me.lblAncho)
        Me.pnlFichaMedicion.Controls.Add(Me.lblAlto)
        Me.pnlFichaMedicion.Controls.Add(Me.lblTotal)
        Me.pnlFichaMedicion.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFichaMedicion.Location = New System.Drawing.Point(0, 0)
        Me.pnlFichaMedicion.Name = "pnlFichaMedicion"
        Me.pnlFichaMedicion.Size = New System.Drawing.Size(784, 240)
        Me.pnlFichaMedicion.TabIndex = 0
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Location = New System.Drawing.Point(8, 216)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(87, 17)
        Me.lblObservaciones.TabIndex = 47
        Me.lblObservaciones.Text = "Observaciones"
        '
        'txtTotal
        '
        Me.TryDataBinding(txtTotal, New System.Windows.Forms.Binding("Value", Me, "Total"))
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(691, 185)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTotal.Size = New System.Drawing.Size(80, 21)
        Me.txtTotal.TabIndex = 46
        '
        'txtAlto
        '
        Me.TryDataBinding(txtAlto, New System.Windows.Forms.Binding("Value", Me, "Alto"))
        Me.txtAlto.Location = New System.Drawing.Point(607, 185)
        Me.txtAlto.Name = "txtAlto"
        Me.txtAlto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAlto.Size = New System.Drawing.Size(80, 21)
        Me.txtAlto.TabIndex = 44
        '
        'txtAncho
        '
        Me.TryDataBinding(txtAncho, New System.Windows.Forms.Binding("Value", Me, "Ancho"))
        Me.txtAncho.Location = New System.Drawing.Point(523, 185)
        Me.txtAncho.Name = "txtAncho"
        Me.txtAncho.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAncho.Size = New System.Drawing.Size(80, 21)
        Me.txtAncho.TabIndex = 42
        '
        'txtLargo
        '
        Me.TryDataBinding(txtLargo, New System.Windows.Forms.Binding("Value", Me, "Largo"))
        Me.txtLargo.Location = New System.Drawing.Point(439, 185)
        Me.txtLargo.Name = "txtLargo"
        Me.txtLargo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLargo.Size = New System.Drawing.Size(80, 21)
        Me.txtLargo.TabIndex = 40
        '
        'txtPIPorcOrigen
        '
        Me.TryDataBinding(txtPIPorcOrigen, New System.Windows.Forms.Binding("Value", Me, "PIPorcOrigen"))
        Me.txtPIPorcOrigen.Location = New System.Drawing.Point(355, 185)
        Me.txtPIPorcOrigen.Name = "txtPIPorcOrigen"
        Me.txtPIPorcOrigen.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPIPorcOrigen.Size = New System.Drawing.Size(80, 21)
        Me.txtPIPorcOrigen.TabIndex = 38
        '
        'txtPIOrigen
        '
        Me.TryDataBinding(txtPIOrigen, New System.Windows.Forms.Binding("Value", Me, "PIOrigen"))
        Me.txtPIOrigen.Location = New System.Drawing.Point(271, 185)
        Me.txtPIOrigen.Name = "txtPIOrigen"
        Me.txtPIOrigen.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPIOrigen.Size = New System.Drawing.Size(80, 21)
        Me.txtPIOrigen.TabIndex = 36
        '
        'txtPIPorc
        '
        Me.TryDataBinding(txtPIPorc, New System.Windows.Forms.Binding("Value", Me, "PIPorc"))
        Me.txtPIPorc.Location = New System.Drawing.Point(187, 185)
        Me.txtPIPorc.Name = "txtPIPorc"
        Me.txtPIPorc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPIPorc.Size = New System.Drawing.Size(80, 21)
        Me.txtPIPorc.TabIndex = 34
        '
        'txtQPI
        '
        Me.TryDataBinding(txtQPI, New System.Windows.Forms.Binding("Value", Me, "QPI"))
        Me.txtQPI.Location = New System.Drawing.Point(103, 185)
        Me.txtQPI.Name = "txtQPI"
        Me.txtQPI.Size = New System.Drawing.Size(80, 21)
        Me.txtQPI.TabIndex = 32
        '
        'txtQPrev
        '
        Me.TryDataBinding(txtQPrev, New System.Windows.Forms.Binding("Value", Me, "QPrev"))
        Me.txtQPrev.Enabled = False
        Me.txtQPrev.Location = New System.Drawing.Point(12, 185)
        Me.txtQPrev.Name = "txtQPrev"
        Me.txtQPrev.Size = New System.Drawing.Size(87, 21)
        Me.txtQPrev.TabIndex = 30
        '
        'txtDescMedicion
        '
        Me.TryDataBinding(txtDescMedicion, New System.Windows.Forms.Binding("Text", Me, "DescMedicion"))
        Me.txtDescMedicion.Enabled = False
        Me.txtDescMedicion.Location = New System.Drawing.Point(8, 112)
        Me.txtDescMedicion.Multiline = True
        Me.txtDescMedicion.Name = "txtDescMedicion"
        Me.txtDescMedicion.Size = New System.Drawing.Size(769, 42)
        Me.txtDescMedicion.TabIndex = 28
        '
        'cbxEstado
        '
        Me.TryDataBinding(cbxEstado, New System.Windows.Forms.Binding("Value", Me.advIDCertificacion, "Estado"))
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><GroupCondition ID="""" /></RootTable><RowWithErrorsFo" & _
        "rmatStyle><PredefinedStyle>RowWithErrorsFormatStyle</PredefinedStyle></RowWithEr" & _
        "rorsFormatStyle><LinkFormatStyle><PredefinedStyle>LinkFormatStyle</PredefinedSty" & _
        "le></LinkFormatStyle><CardCaptionFormatStyle><PredefinedStyle>CardCaptionFormatS" & _
        "tyle</PredefinedStyle></CardCaptionFormatStyle><GroupByBoxFormatStyle><Predefine" & _
        "dStyle>GroupByBoxFormatStyle</PredefinedStyle></GroupByBoxFormatStyle><GroupByBo" & _
        "xInfoFormatStyle><PredefinedStyle>GroupByBoxInfoFormatStyle</PredefinedStyle></G" & _
        "roupByBoxInfoFormatStyle><GroupRowFormatStyle><PredefinedStyle>GroupRowFormatSty" & _
        "le</PredefinedStyle></GroupRowFormatStyle><HeaderFormatStyle><PredefinedStyle>He" & _
        "aderFormatStyle</PredefinedStyle></HeaderFormatStyle><PreviewRowFormatStyle><Pre" & _
        "definedStyle>PreviewRowFormatStyle</PredefinedStyle></PreviewRowFormatStyle><Row" & _
        "FormatStyle><PredefinedStyle>RowFormatStyle</PredefinedStyle></RowFormatStyle><S" & _
        "electedFormatStyle><PredefinedStyle>SelectedFormatStyle</PredefinedStyle></Selec" & _
        "tedFormatStyle><SelectedInactiveFormatStyle><PredefinedStyle>SelectedInactiveFor" & _
        "matStyle</PredefinedStyle></SelectedInactiveFormatStyle><WatermarkImage /><Borde" & _
        "rStyle>Flat</BorderStyle><FlatBorderColor>125, 159, 190</FlatBorderColor><Contro" & _
        "lStyle><ButtonAppearance>Flat</ButtonAppearance></ControlStyle><VisualStyle>Stan" & _
        "dard</VisualStyle><AllowEdit>False</AllowEdit><ExpandableGroups>False</Expandabl" & _
        "eGroups><GroupByBoxVisible>False</GroupByBoxVisible><HideSelection>Highlight</Hi" & _
        "deSelection></GridEXLayoutData>"
        Me.cbxEstado.DesignTimeLayout = GridEXLayout1
        Me.cbxEstado.Enabled = False
        Me.cbxEstado.Location = New System.Drawing.Point(656, 88)
        Me.cbxEstado.Name = "cbxEstado"
        Me.cbxEstado.SelectedIndex = -1
        Me.cbxEstado.SelectedItem = Nothing
        Me.cbxEstado.Size = New System.Drawing.Size(121, 21)
        Me.cbxEstado.TabIndex = 26
        Me.cbxEstado.Value = Nothing
        '
        'cbxFechaCreacion
        '
        Me.TryDataBinding(cbxFechaCreacion, New System.Windows.Forms.Binding("BindableValue", Me.advIDCertificacion, "FechaCreacion"))
        Me.cbxFechaCreacion.Enabled = False
        Me.cbxFechaCreacion.Location = New System.Drawing.Point(656, 64)
        Me.cbxFechaCreacion.Name = "cbxFechaCreacion"
        Me.cbxFechaCreacion.Size = New System.Drawing.Size(121, 21)
        Me.cbxFechaCreacion.TabIndex = 24
        '
        'ulbDescCertificacion
        '
        Me.TryDataBinding(ulbDescCertificacion, New System.Windows.Forms.Binding("Text", Me.advIDCertificacion, "DescCertificacion"))
        Me.ulbDescCertificacion.Location = New System.Drawing.Point(216, 62)
        Me.ulbDescCertificacion.Name = "ulbDescCertificacion"
        Me.ulbDescCertificacion.Size = New System.Drawing.Size(312, 23)
        Me.ulbDescCertificacion.TabIndex = 22
        '
        'advIDCertificacion
        '
        Me.TryDataBinding(advIDCertificacion, New System.Windows.Forms.Binding("Value", Me, "IDCertificacion"))
        Me.advIDCertificacion.DisplayField = "NCertificacion"
        Me.advIDCertificacion.Enabled = False
        Me.advIDCertificacion.EntityName = "ObraCertificacion"
        Me.advIDCertificacion.Location = New System.Drawing.Point(90, 62)
        Me.advIDCertificacion.Name = "advIDCertificacion"
        Me.advIDCertificacion.PrimaryDataFields = "IDCertificacion"
        Me.advIDCertificacion.SecondaryDataFields = "IdCertificacion"
        Me.advIDCertificacion.Size = New System.Drawing.Size(121, 23)
        Me.advIDCertificacion.TabIndex = 21
        '
        'lblCertificacion
        '
        Me.lblCertificacion.Location = New System.Drawing.Point(8, 62)
        Me.lblCertificacion.Name = "lblCertificacion"
        Me.lblCertificacion.Size = New System.Drawing.Size(74, 17)
        Me.lblCertificacion.TabIndex = 20
        Me.lblCertificacion.Text = "Certificaci�n"
        '
        'lblFechaCreacion
        '
        Me.lblFechaCreacion.Location = New System.Drawing.Point(535, 67)
        Me.lblFechaCreacion.Name = "lblFechaCreacion"
        Me.lblFechaCreacion.Size = New System.Drawing.Size(89, 17)
        Me.lblFechaCreacion.TabIndex = 23
        Me.lblFechaCreacion.Text = "Fecha creaci�n"
        '
        'lblEstado
        '
        Me.lblEstado.Location = New System.Drawing.Point(535, 90)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(114, 17)
        Me.lblEstado.TabIndex = 25
        Me.lblEstado.Text = "Estado certificaci�n"
        '
        'ulbDescTrabajo
        '
        Me.TryDataBinding(ulbDescTrabajo, New System.Windows.Forms.Binding("Text", Me.advIDTrabajo, "DescTrabajo"))
        Me.ulbDescTrabajo.Location = New System.Drawing.Point(216, 35)
        Me.ulbDescTrabajo.Name = "ulbDescTrabajo"
        Me.ulbDescTrabajo.Size = New System.Drawing.Size(559, 23)
        Me.ulbDescTrabajo.TabIndex = 5
        '
        'advIDTrabajo
        '
        Me.TryDataBinding(advIDTrabajo, New System.Windows.Forms.Binding("Value", Me, "IdTrabajo"))
        Me.advIDTrabajo.DisplayField = "CodTrabajo"
        Me.advIDTrabajo.Enabled = False
        Me.advIDTrabajo.EntityName = "ObraTrabajo"
        Me.advIDTrabajo.Location = New System.Drawing.Point(90, 35)
        Me.advIDTrabajo.Name = "advIDTrabajo"
        Me.advIDTrabajo.PrimaryDataFields = "IdTrabajo"
        Me.advIDTrabajo.SecondaryDataFields = "IDTrabajo"
        Me.advIDTrabajo.Size = New System.Drawing.Size(121, 23)
        Me.advIDTrabajo.TabIndex = 4
        '
        'ulbDescObra
        '
        Me.TryDataBinding(ulbDescObra, New System.Windows.Forms.Binding("Text", Me.advIDObra, "DescObra"))
        Me.ulbDescObra.Location = New System.Drawing.Point(216, 8)
        Me.ulbDescObra.Name = "ulbDescObra"
        Me.ulbDescObra.Size = New System.Drawing.Size(559, 23)
        Me.ulbDescObra.TabIndex = 2
        '
        'advIDObra
        '
        Me.TryDataBinding(advIDObra, New System.Windows.Forms.Binding("Value", Me, "IdObra"))
        Me.advIDObra.DisplayField = "NObra"
        Me.advIDObra.Enabled = False
        Me.advIDObra.EntityName = "ObraCabecera"
        Me.advIDObra.Location = New System.Drawing.Point(90, 8)
        Me.advIDObra.Name = "advIDObra"
        Me.advIDObra.PrimaryDataFields = "IdObra"
        Me.advIDObra.SecondaryDataFields = "IDObra"
        Me.advIDObra.Size = New System.Drawing.Size(121, 23)
        Me.advIDObra.TabIndex = 1
        '
        'lblObra
        '
        Me.lblObra.Location = New System.Drawing.Point(8, 9)
        Me.lblObra.Name = "lblObra"
        Me.lblObra.Size = New System.Drawing.Size(53, 17)
        Me.lblObra.TabIndex = 0
        Me.lblObra.Text = "Proyecto"
        '
        'lblTrabajo
        '
        Me.lblTrabajo.Location = New System.Drawing.Point(8, 36)
        Me.lblTrabajo.Name = "lblTrabajo"
        Me.lblTrabajo.Size = New System.Drawing.Size(47, 17)
        Me.lblTrabajo.TabIndex = 3
        Me.lblTrabajo.Text = "Trabajo"
        '
        'lblDescMedicion
        '
        Me.lblDescMedicion.Location = New System.Drawing.Point(8, 89)
        Me.lblDescMedicion.Name = "lblDescMedicion"
        Me.lblDescMedicion.Size = New System.Drawing.Size(89, 17)
        Me.lblDescMedicion.TabIndex = 27
        Me.lblDescMedicion.Text = "Desc. Medici�n"
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = False
        Me.lblCantidad.Location = New System.Drawing.Point(12, 161)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(87, 21)
        Me.lblCantidad.TabIndex = 29
        Me.lblCantidad.Text = "Cantidad"
        Me.lblCantidad.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblQPI
        '
        Me.lblQPI.AutoSize = False
        Me.lblQPI.Location = New System.Drawing.Point(103, 161)
        Me.lblQPI.Name = "lblQPI"
        Me.lblQPI.Size = New System.Drawing.Size(80, 21)
        Me.lblQPI.TabIndex = 31
        Me.lblQPI.Text = "PI"
        Me.lblQPI.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblPIPorc
        '
        Me.lblPIPorc.AutoSize = False
        Me.lblPIPorc.Location = New System.Drawing.Point(187, 161)
        Me.lblPIPorc.Name = "lblPIPorc"
        Me.lblPIPorc.Size = New System.Drawing.Size(80, 21)
        Me.lblPIPorc.TabIndex = 33
        Me.lblPIPorc.Text = "% PI"
        Me.lblPIPorc.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblPIOrigen
        '
        Me.lblPIOrigen.AutoSize = False
        Me.lblPIOrigen.Location = New System.Drawing.Point(271, 161)
        Me.lblPIOrigen.Name = "lblPIOrigen"
        Me.lblPIOrigen.Size = New System.Drawing.Size(80, 21)
        Me.lblPIOrigen.TabIndex = 35
        Me.lblPIOrigen.Text = "PI Origen"
        Me.lblPIOrigen.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblPIPorcOrigen
        '
        Me.lblPIPorcOrigen.AutoSize = False
        Me.lblPIPorcOrigen.Location = New System.Drawing.Point(355, 161)
        Me.lblPIPorcOrigen.Name = "lblPIPorcOrigen"
        Me.lblPIPorcOrigen.Size = New System.Drawing.Size(80, 21)
        Me.lblPIPorcOrigen.TabIndex = 37
        Me.lblPIPorcOrigen.Text = "PI % Origen"
        Me.lblPIPorcOrigen.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblLargo
        '
        Me.lblLargo.AutoSize = False
        Me.lblLargo.Location = New System.Drawing.Point(439, 161)
        Me.lblLargo.Name = "lblLargo"
        Me.lblLargo.Size = New System.Drawing.Size(80, 21)
        Me.lblLargo.TabIndex = 39
        Me.lblLargo.Text = "Largo"
        Me.lblLargo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblAncho
        '
        Me.lblAncho.AutoSize = False
        Me.lblAncho.Location = New System.Drawing.Point(523, 161)
        Me.lblAncho.Name = "lblAncho"
        Me.lblAncho.Size = New System.Drawing.Size(80, 21)
        Me.lblAncho.TabIndex = 41
        Me.lblAncho.Text = "Ancho"
        Me.lblAncho.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblAlto
        '
        Me.lblAlto.AutoSize = False
        Me.lblAlto.Location = New System.Drawing.Point(607, 161)
        Me.lblAlto.Name = "lblAlto"
        Me.lblAlto.Size = New System.Drawing.Size(80, 21)
        Me.lblAlto.TabIndex = 43
        Me.lblAlto.Text = "Alto"
        Me.lblAlto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = False
        Me.lblTotal.Location = New System.Drawing.Point(691, 161)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(80, 21)
        Me.lblTotal.TabIndex = 45
        Me.lblTotal.Text = "Total"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'pnlObservaciones
        '
        Me.pnlObservaciones.Controls.Add(Me.txtObservaciones)
        Me.pnlObservaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlObservaciones.DockPadding.Bottom = 8
        Me.pnlObservaciones.DockPadding.Left = 8
        Me.pnlObservaciones.DockPadding.Right = 8
        Me.pnlObservaciones.Location = New System.Drawing.Point(0, 240)
        Me.pnlObservaciones.Name = "pnlObservaciones"
        Me.pnlObservaciones.Size = New System.Drawing.Size(784, 202)
        Me.pnlObservaciones.TabIndex = 1
        '
        'txtObservaciones
        '
        Me.TryDataBinding(txtObservaciones, New System.Windows.Forms.Binding("Text", Me, "Observaciones"))
        Me.txtObservaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtObservaciones.Location = New System.Drawing.Point(8, 0)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservaciones.Size = New System.Drawing.Size(768, 194)
        Me.txtObservaciones.TabIndex = 1
        '
        'MntoCertificacionMedicion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(792, 542)
        Me.EntityName = "ObraCertificacionMedicion"
        Me.Name = "MntoCertificacionMedicion"
        Me.NavigationFields = "IdLineaCertificacion"
        Me.ViewName = "vMntoCertificacionMedicion"
        CType(Me.ToolBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFichaMedicion.ResumeLayout(False)
        Me.pnlObservaciones.ResumeLayout(False)

    End Sub

#End Region

    Private Sub MntoCertificacionMedicion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.NewRow.Visible = Janus.Windows.UI.InheritableBoolean.False
        cbxEstado.DataSource = New EnumData("enumEstadoCertificacion")
    End Sub

    Private Sub MntoCertificacionMedicion_Navigated(ByVal sender As Object, ByVal e As Engine.UI.NavigatedEventArgs) Handles MyBase.Navigated
        Dim Enabled As Boolean = (Length(Me.CurrentRow("IDLineaMedicion")) > 0)
        Me.txtPIPorc.Enabled = Enabled
        Me.txtPIOrigen.Enabled = Enabled
        Me.txtPIPorcOrigen.Enabled = Enabled
    End Sub

    Private Sub MntoCertificacionMedicion_BusinessCalling(ByVal sender As Object, ByVal e As Engine.UI.BusinessCallingEventArgs) Handles MyBase.BusinessCalling
        e.Data.Context.Clear()
        e.Data.Context("PIMedicion") = Me.CurrentRow("PIMedicion")
        e.Data.Context("IDTipoCertificacion") = Me.CurrentRow("TipoCertificacion")
    End Sub

End Class
