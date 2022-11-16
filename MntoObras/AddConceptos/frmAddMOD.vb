Public Class frmAddMOD
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
    Public WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents CmbNuevo As Solmicro.Expertis.Engine.UI.Button
    Public WithEvents cmbCancelar As Solmicro.Expertis.Engine.UI.Button
    Public WithEvents CmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Public WithEvents txtSecuencia As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents txtDescTrabajo As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents txtCodTrabajo As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblCodTrabajo As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblSecuencia As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblIDCategoria As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents advIDCategoria As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblIDHora As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents advIDHora As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents chbManual As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents lblHorasUnidad As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents ntbHorasUnidad As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblHorasPrevMod As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents ntbHorasPrevMod As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblTasaPrevModA As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents ntbTasaPrevModA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblImpPrevModA As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents ntbImpPrevModA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblMargenPrev As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents ntbMargenPrev As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblImpPrevModVentaA As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents ntbImpPrevModVentaA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblPrecioVentaA As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents ntbPrecioVentaA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents ulDescCategoria As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents ulDescHora As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents Frame1 As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents cmbTipoFacturacion As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents chbFacturable As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents lblTipoFacturacion As Solmicro.Expertis.Engine.UI.Label

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Public WithEvents FraFecha As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents lblFechaInicio As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents clbFechaInicio As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents lblFechaFin As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents clbFechaFin As Solmicro.Expertis.Engine.UI.CalendarBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.CmbNuevo = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.CmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.txtSecuencia = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtDescTrabajo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtCodTrabajo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblCodTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.lblSecuencia = New Solmicro.Expertis.Engine.UI.Label
        Me.lblIDCategoria = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDCategoria = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblIDHora = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDHora = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.ulDescCategoria = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.ulDescHora = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.chbManual = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.lblHorasUnidad = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbHorasUnidad = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblHorasPrevMod = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbHorasPrevMod = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblTasaPrevModA = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbTasaPrevModA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblImpPrevModA = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbImpPrevModA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblMargenPrev = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbMargenPrev = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblImpPrevModVentaA = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbImpPrevModVentaA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblPrecioVentaA = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbPrecioVentaA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.Frame1 = New Solmicro.Expertis.Engine.UI.Frame
        Me.cmbTipoFacturacion = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.chbFacturable = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.lblTipoFacturacion = New Solmicro.Expertis.Engine.UI.Label
        Me.FraFecha = New Solmicro.Expertis.Engine.UI.Frame
        Me.clbFechaFin = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.clbFechaInicio = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaInicio = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFechaFin = New Solmicro.Expertis.Engine.UI.Label
        Me.Panel1.suspendlayout()
        Me.Frame1.SuspendLayout()
        Me.FraFecha.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CmbNuevo)
        Me.Panel1.Controls.Add(Me.cmbCancelar)
        Me.Panel1.Controls.Add(Me.CmbAceptar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 260)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(541, 42)
        Me.Panel1.TabIndex = 234
        '
        'CmbNuevo
        '
        Me.CmbNuevo.Location = New System.Drawing.Point(123, 7)
        Me.CmbNuevo.Name = "CmbNuevo"
        Me.CmbNuevo.Size = New System.Drawing.Size(94, 29)
        Me.CmbNuevo.TabIndex = 15
        Me.CmbNuevo.Text = "Nuevo"
        '
        'cmbCancelar
        '
        Me.cmbCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmbCancelar.Location = New System.Drawing.Point(323, 7)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(94, 29)
        Me.cmbCancelar.TabIndex = 17
        Me.cmbCancelar.Text = "Cancelar"
        '
        'CmbAceptar
        '
        Me.CmbAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.CmbAceptar.Location = New System.Drawing.Point(223, 7)
        Me.CmbAceptar.Name = "CmbAceptar"
        Me.CmbAceptar.Size = New System.Drawing.Size(94, 29)
        Me.CmbAceptar.TabIndex = 16
        Me.CmbAceptar.Text = "Aceptar"
        '
        'txtSecuencia
        '
        Me.TryDataBinding(txtSecuencia, New System.Windows.Forms.Binding("Text", Me, "Secuencia"))
        Me.txtSecuencia.Location = New System.Drawing.Point(472, 8)
        Me.txtSecuencia.Name = "txtSecuencia"
        Me.txtSecuencia.Size = New System.Drawing.Size(64, 21)
        Me.txtSecuencia.TabIndex = 0
        '
        'txtDescTrabajo
        '
        Me.txtDescTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescTrabajo.Enabled = False
        Me.txtDescTrabajo.Location = New System.Drawing.Point(195, 8)
        Me.txtDescTrabajo.Name = "txtDescTrabajo"
        Me.txtDescTrabajo.Size = New System.Drawing.Size(210, 21)
        Me.txtDescTrabajo.TabIndex = 238
        Me.txtDescTrabajo.TabStop = False
        '
        'txtCodTrabajo
        '
        Me.txtCodTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.txtCodTrabajo.Enabled = False
        Me.txtCodTrabajo.Location = New System.Drawing.Point(71, 8)
        Me.txtCodTrabajo.Name = "txtCodTrabajo"
        Me.txtCodTrabajo.Size = New System.Drawing.Size(119, 21)
        Me.txtCodTrabajo.TabIndex = 237
        '
        'lblCodTrabajo
        '
        Me.lblCodTrabajo.Location = New System.Drawing.Point(4, 10)
        Me.lblCodTrabajo.Name = "lblCodTrabajo"
        Me.lblCodTrabajo.Size = New System.Drawing.Size(50, 13)
        Me.lblCodTrabajo.TabIndex = 235
        Me.lblCodTrabajo.Text = "Trabajo"
        '
        'lblSecuencia
        '
        Me.lblSecuencia.Location = New System.Drawing.Point(409, 10)
        Me.lblSecuencia.Name = "lblSecuencia"
        Me.lblSecuencia.Size = New System.Drawing.Size(65, 13)
        Me.lblSecuencia.TabIndex = 239
        Me.lblSecuencia.Text = "Secuencia"
        '
        'lblIDCategoria
        '
        Me.lblIDCategoria.Location = New System.Drawing.Point(4, 34)
        Me.lblIDCategoria.Name = "lblIDCategoria"
        Me.lblIDCategoria.Size = New System.Drawing.Size(63, 13)
        Me.lblIDCategoria.TabIndex = 240
        Me.lblIDCategoria.Text = "Categoría"
        '
        'advIDCategoria
        '
        Me.TryDataBinding(advIDCategoria, New System.Windows.Forms.Binding("Text", Me, "IDCategoria"))
        Me.advIDCategoria.EntityName = "Categoria"
        Me.advIDCategoria.Location = New System.Drawing.Point(71, 34)
        Me.advIDCategoria.Name = "advIDCategoria"
        Me.advIDCategoria.PrimaryDataFields = "IDCategoria"
        Me.advIDCategoria.SecondaryDataFields = "IDCategoria"
        Me.advIDCategoria.Size = New System.Drawing.Size(119, 23)
        Me.advIDCategoria.TabIndex = 1
        '
        'lblIDHora
        '
        Me.lblIDHora.Location = New System.Drawing.Point(4, 60)
        Me.lblIDHora.Name = "lblIDHora"
        Me.lblIDHora.Size = New System.Drawing.Size(34, 13)
        Me.lblIDHora.TabIndex = 242
        Me.lblIDHora.Text = "Hora"
        '
        'advIDHora
        '
        Me.TryDataBinding(advIDHora, New System.Windows.Forms.Binding("Text", Me, "IDHora"))
        Me.advIDHora.EntityName = "Hora"
        Me.advIDHora.Location = New System.Drawing.Point(71, 60)
        Me.advIDHora.Name = "advIDHora"
        Me.advIDHora.PrimaryDataFields = "IDHora"
        Me.advIDHora.SecondaryDataFields = "IDHora"
        Me.advIDHora.Size = New System.Drawing.Size(119, 23)
        Me.advIDHora.TabIndex = 2
        '
        'ulDescCategoria
        '
        Me.TryDataBinding(ulDescCategoria, New System.Windows.Forms.Binding("Text", Me, "DescCategoria"))
        Me.ulDescCategoria.Location = New System.Drawing.Point(195, 34)
        Me.ulDescCategoria.Name = "ulDescCategoria"
        Me.ulDescCategoria.Size = New System.Drawing.Size(183, 21)
        Me.ulDescCategoria.TabIndex = 245
        '
        'ulDescHora
        '
        Me.TryDataBinding(ulDescHora, New System.Windows.Forms.Binding("Text", Me.advIDHora, "DescHora"))
        Me.ulDescHora.Location = New System.Drawing.Point(195, 60)
        Me.ulDescHora.Name = "ulDescHora"
        Me.ulDescHora.Size = New System.Drawing.Size(183, 21)
        Me.ulDescHora.TabIndex = 246
        '
        'chbManual
        '
        Me.TryDataBinding(chbManual, New System.Windows.Forms.Binding("BindableValue", Me, "Manual"))
        Me.chbManual.Location = New System.Drawing.Point(5, 89)
        Me.chbManual.Name = "chbManual"
        Me.chbManual.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chbManual.Size = New System.Drawing.Size(80, 23)
        Me.chbManual.TabIndex = 6
        Me.chbManual.Text = "Manual"
        Me.chbManual.TextAlignment = Janus.Windows.EditControls.TextAlignment.Far
        '
        'lblHorasUnidad
        '
        Me.lblHorasUnidad.Location = New System.Drawing.Point(111, 92)
        Me.lblHorasUnidad.Name = "lblHorasUnidad"
        Me.lblHorasUnidad.Size = New System.Drawing.Size(83, 13)
        Me.lblHorasUnidad.TabIndex = 249
        Me.lblHorasUnidad.Text = "Horas Unidad"
        '
        'ntbHorasUnidad
        '
        Me.TryDataBinding(ntbHorasUnidad, New System.Windows.Forms.Binding("Value", Me, "HorasUnidad"))
        Me.ntbHorasUnidad.Location = New System.Drawing.Point(199, 90)
        Me.ntbHorasUnidad.Name = "ntbHorasUnidad"
        Me.ntbHorasUnidad.Size = New System.Drawing.Size(79, 21)
        Me.ntbHorasUnidad.TabIndex = 7
        '
        'lblHorasPrevMod
        '
        Me.lblHorasPrevMod.Location = New System.Drawing.Point(111, 118)
        Me.lblHorasPrevMod.Name = "lblHorasPrevMod"
        Me.lblHorasPrevMod.Size = New System.Drawing.Size(73, 13)
        Me.lblHorasPrevMod.TabIndex = 251
        Me.lblHorasPrevMod.Text = "Horas Prev."
        '
        'ntbHorasPrevMod
        '
        Me.TryDataBinding(ntbHorasPrevMod, New System.Windows.Forms.Binding("Value", Me, "HorasPrevMod"))
        Me.ntbHorasPrevMod.Location = New System.Drawing.Point(199, 116)
        Me.ntbHorasPrevMod.Name = "ntbHorasPrevMod"
        Me.ntbHorasPrevMod.Size = New System.Drawing.Size(79, 21)
        Me.ntbHorasPrevMod.TabIndex = 8
        '
        'lblTasaPrevModA
        '
        Me.lblTasaPrevModA.Location = New System.Drawing.Point(4, 146)
        Me.lblTasaPrevModA.Name = "lblTasaPrevModA"
        Me.lblTasaPrevModA.Size = New System.Drawing.Size(66, 13)
        Me.lblTasaPrevModA.TabIndex = 253
        Me.lblTasaPrevModA.Text = "Tasa Prev."
        '
        'ntbTasaPrevModA
        '
        Me.TryDataBinding(ntbTasaPrevModA, New System.Windows.Forms.Binding("Value", Me, "TasaPrevModA"))
        Me.ntbTasaPrevModA.Location = New System.Drawing.Point(98, 146)
        Me.ntbTasaPrevModA.Name = "ntbTasaPrevModA"
        Me.ntbTasaPrevModA.Size = New System.Drawing.Size(121, 21)
        Me.ntbTasaPrevModA.TabIndex = 9
        '
        'lblImpPrevModA
        '
        Me.lblImpPrevModA.Location = New System.Drawing.Point(330, 127)
        Me.lblImpPrevModA.Name = "lblImpPrevModA"
        Me.lblImpPrevModA.Size = New System.Drawing.Size(67, 13)
        Me.lblImpPrevModA.TabIndex = 255
        Me.lblImpPrevModA.Text = "Imp. Prev."
        '
        'ntbImpPrevModA
        '
        Me.TryDataBinding(ntbImpPrevModA, New System.Windows.Forms.Binding("Value", Me, "ImpPrevModA"))
        Me.ntbImpPrevModA.Enabled = False
        Me.ntbImpPrevModA.Location = New System.Drawing.Point(415, 127)
        Me.ntbImpPrevModA.Name = "ntbImpPrevModA"
        Me.ntbImpPrevModA.Size = New System.Drawing.Size(121, 21)
        Me.ntbImpPrevModA.TabIndex = 256
        '
        'lblMargenPrev
        '
        Me.lblMargenPrev.Location = New System.Drawing.Point(330, 153)
        Me.lblMargenPrev.Name = "lblMargenPrev"
        Me.lblMargenPrev.Size = New System.Drawing.Size(49, 13)
        Me.lblMargenPrev.TabIndex = 257
        Me.lblMargenPrev.Text = "Margen"
        '
        'ntbMargenPrev
        '
        Me.TryDataBinding(ntbMargenPrev, New System.Windows.Forms.Binding("Value", Me, "MargenPrev"))
        Me.ntbMargenPrev.Location = New System.Drawing.Point(415, 153)
        Me.ntbMargenPrev.Name = "ntbMargenPrev"
        Me.ntbMargenPrev.Size = New System.Drawing.Size(121, 21)
        Me.ntbMargenPrev.TabIndex = 11
        '
        'lblImpPrevModVentaA
        '
        Me.lblImpPrevModVentaA.Location = New System.Drawing.Point(330, 181)
        Me.lblImpPrevModVentaA.Name = "lblImpPrevModVentaA"
        Me.lblImpPrevModVentaA.Size = New System.Drawing.Size(70, 13)
        Me.lblImpPrevModVentaA.TabIndex = 259
        Me.lblImpPrevModVentaA.Text = "Imp. Venta"
        '
        'ntbImpPrevModVentaA
        '
        Me.TryDataBinding(ntbImpPrevModVentaA, New System.Windows.Forms.Binding("Value", Me, "ImpPrevModVentaA"))
        Me.ntbImpPrevModVentaA.Enabled = False
        Me.ntbImpPrevModVentaA.Location = New System.Drawing.Point(415, 180)
        Me.ntbImpPrevModVentaA.Name = "ntbImpPrevModVentaA"
        Me.ntbImpPrevModVentaA.Size = New System.Drawing.Size(121, 21)
        Me.ntbImpPrevModVentaA.TabIndex = 260
        '
        'lblPrecioVentaA
        '
        Me.lblPrecioVentaA.Location = New System.Drawing.Point(4, 172)
        Me.lblPrecioVentaA.Name = "lblPrecioVentaA"
        Me.lblPrecioVentaA.Size = New System.Drawing.Size(78, 13)
        Me.lblPrecioVentaA.TabIndex = 261
        Me.lblPrecioVentaA.Text = "Precio Venta"
        '
        'ntbPrecioVentaA
        '
        Me.TryDataBinding(ntbPrecioVentaA, New System.Windows.Forms.Binding("Value", Me, "PrecioVentaA"))
        Me.ntbPrecioVentaA.Location = New System.Drawing.Point(98, 172)
        Me.ntbPrecioVentaA.Name = "ntbPrecioVentaA"
        Me.ntbPrecioVentaA.Size = New System.Drawing.Size(121, 21)
        Me.ntbPrecioVentaA.TabIndex = 10
        '
        'Frame1
        '
        Me.Frame1.Controls.Add(Me.cmbTipoFacturacion)
        Me.Frame1.Controls.Add(Me.chbFacturable)
        Me.Frame1.Controls.Add(Me.lblTipoFacturacion)
        Me.Frame1.Location = New System.Drawing.Point(1, 208)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(539, 52)
        Me.Frame1.TabIndex = 12
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Facturación"
        '
        'cmbTipoFacturacion
        '
        Me.TryDataBinding(cmbTipoFacturacion, New System.Windows.Forms.Binding("Value", Me, "TipoFacturacion"))
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><GroupCondition ID="""" /></RootTable><RowWithErrorsFo" & _
        "rmatStyle><PredefinedStyle>RowWithErrorsFormatStyle</PredefinedStyle></RowWithEr" & _
        "rorsFormatStyle><LinkFormatStyle><PredefinedStyle>LinkFormatStyle</PredefinedSty" & _
        "le></LinkFormatStyle><CardCaptionFormatStyle><PredefinedStyle>CardCaptionFormatS" & _
        "tyle</PredefinedStyle></CardCaptionFormatStyle><GroupByBoxInfoFormatStyle><Prede" & _
        "finedStyle>GroupByBoxInfoFormatStyle</PredefinedStyle></GroupByBoxInfoFormatStyl" & _
        "e><GroupRowFormatStyle><PredefinedStyle>GroupRowFormatStyle</PredefinedStyle></G" & _
        "roupRowFormatStyle><HeaderFormatStyle><PredefinedStyle>HeaderFormatStyle</Predef" & _
        "inedStyle></HeaderFormatStyle><PreviewRowFormatStyle><PredefinedStyle>PreviewRow" & _
        "FormatStyle</PredefinedStyle></PreviewRowFormatStyle><RowFormatStyle><Predefined" & _
        "Style>RowFormatStyle</PredefinedStyle></RowFormatStyle><SelectedFormatStyle><Pre" & _
        "definedStyle>SelectedFormatStyle</PredefinedStyle></SelectedFormatStyle><Selecte" & _
        "dInactiveFormatStyle><PredefinedStyle>SelectedInactiveFormatStyle</PredefinedSty" & _
        "le></SelectedInactiveFormatStyle><WatermarkImage /><BorderStyle>Flat</BorderStyl" & _
        "e><FlatBorderColor>125, 159, 190</FlatBorderColor><ControlStyle><ButtonAppearanc" & _
        "e>Flat</ButtonAppearance></ControlStyle><VisualStyle>Standard</VisualStyle><Allo" & _
        "wEdit>False</AllowEdit><ColumnAutoResize>True</ColumnAutoResize><ExpandableGroup" & _
        "s>False</ExpandableGroups><GroupByBoxVisible>False</GroupByBoxVisible><HideSelec" & _
        "tion>Highlight</HideSelection></GridEXLayoutData>"
        Me.cmbTipoFacturacion.DesignTimeLayout = GridEXLayout1
        Me.cmbTipoFacturacion.Location = New System.Drawing.Point(300, 18)
        Me.cmbTipoFacturacion.Name = "cmbTipoFacturacion"
        Me.cmbTipoFacturacion.SelectedIndex = -1
        Me.cmbTipoFacturacion.SelectedItem = Nothing
        Me.cmbTipoFacturacion.Size = New System.Drawing.Size(162, 21)
        Me.cmbTipoFacturacion.TabIndex = 14
        Me.cmbTipoFacturacion.Value = Nothing
        '
        'chbFacturable
        '
        Me.TryDataBinding(chbFacturable, New System.Windows.Forms.Binding("BindableValue", Me, "Facturable"))
        Me.chbFacturable.Location = New System.Drawing.Point(78, 18)
        Me.chbFacturable.Name = "chbFacturable"
        Me.chbFacturable.Size = New System.Drawing.Size(82, 23)
        Me.chbFacturable.TabIndex = 13
        Me.chbFacturable.Text = "Facturable"
        '
        'lblTipoFacturacion
        '
        Me.lblTipoFacturacion.Location = New System.Drawing.Point(195, 21)
        Me.lblTipoFacturacion.Name = "lblTipoFacturacion"
        Me.lblTipoFacturacion.Size = New System.Drawing.Size(99, 13)
        Me.lblTipoFacturacion.TabIndex = 4
        Me.lblTipoFacturacion.Text = "Tipo Facturación"
        '
        'FraFecha
        '
        Me.FraFecha.Controls.Add(Me.clbFechaFin)
        Me.FraFecha.Controls.Add(Me.clbFechaInicio)
        Me.FraFecha.Controls.Add(Me.lblFechaInicio)
        Me.FraFecha.Controls.Add(Me.lblFechaFin)
        Me.FraFecha.Location = New System.Drawing.Point(385, 33)
        Me.FraFecha.Name = "FraFecha"
        Me.FraFecha.Size = New System.Drawing.Size(151, 80)
        Me.FraFecha.TabIndex = 3
        Me.FraFecha.TabStop = False
        Me.FraFecha.Text = "Fechas"
        '
        'clbFechaFin
        '
        Me.TryDataBinding(clbFechaFin, New System.Windows.Forms.Binding("BindableValue", Me, "FechaFin"))
        Me.clbFechaFin.Location = New System.Drawing.Point(50, 47)
        Me.clbFechaFin.Name = "clbFechaFin"
        Me.clbFechaFin.Size = New System.Drawing.Size(93, 21)
        Me.clbFechaFin.TabIndex = 5
        '
        'clbFechaInicio
        '
        Me.TryDataBinding(clbFechaInicio, New System.Windows.Forms.Binding("BindableValue", Me, "FechaInicio"))
        Me.clbFechaInicio.Location = New System.Drawing.Point(50, 20)
        Me.clbFechaInicio.Name = "clbFechaInicio"
        Me.clbFechaInicio.Size = New System.Drawing.Size(93, 21)
        Me.clbFechaInicio.TabIndex = 4
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.Location = New System.Drawing.Point(8, 20)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.Size = New System.Drawing.Size(38, 13)
        Me.lblFechaInicio.TabIndex = 0
        Me.lblFechaInicio.Text = "Inicio"
        '
        'lblFechaFin
        '
        Me.lblFechaFin.Location = New System.Drawing.Point(8, 47)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(23, 13)
        Me.lblFechaFin.TabIndex = 2
        Me.lblFechaFin.Text = "Fin"
        '
        'frmAddMOD
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(541, 302)
        Me.Controls.Add(Me.FraFecha)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.ntbPrecioVentaA)
        Me.Controls.Add(Me.ntbImpPrevModVentaA)
        Me.Controls.Add(Me.ntbMargenPrev)
        Me.Controls.Add(Me.ntbImpPrevModA)
        Me.Controls.Add(Me.ntbTasaPrevModA)
        Me.Controls.Add(Me.ntbHorasPrevMod)
        Me.Controls.Add(Me.ntbHorasUnidad)
        Me.Controls.Add(Me.chbManual)
        Me.Controls.Add(Me.ulDescHora)
        Me.Controls.Add(Me.ulDescCategoria)
        Me.Controls.Add(Me.advIDHora)
        Me.Controls.Add(Me.advIDCategoria)
        Me.Controls.Add(Me.txtSecuencia)
        Me.Controls.Add(Me.txtDescTrabajo)
        Me.Controls.Add(Me.txtCodTrabajo)
        Me.Controls.Add(Me.lblCodTrabajo)
        Me.Controls.Add(Me.lblSecuencia)
        Me.Controls.Add(Me.lblIDCategoria)
        Me.Controls.Add(Me.lblIDHora)
        Me.Controls.Add(Me.lblHorasUnidad)
        Me.Controls.Add(Me.lblHorasPrevMod)
        Me.Controls.Add(Me.lblTasaPrevModA)
        Me.Controls.Add(Me.lblImpPrevModA)
        Me.Controls.Add(Me.lblMargenPrev)
        Me.Controls.Add(Me.lblImpPrevModVentaA)
        Me.Controls.Add(Me.lblPrecioVentaA)
        Me.Controls.Add(Me.Panel1)
        Me.EntityName = "ObraMOD"
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmAddMOD"
        Me.NavigationFields = "IDObra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta de M.O.D."
        Me.ViewName = "VFrmObraMOD"
        Me.WindowState = System.Windows.Forms.FormWindowState.Normal
        Me.Panel1.ResumeLayout(False)
        Me.Frame1.ResumeLayout(False)
        Me.FraFecha.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Protected mdtMod As DataTable
    Protected mintIDObra, mintIDTrabajo As Integer
    Protected mdblQPrevTrabajo As Double
    Protected mblnCancel, mblnFacturable As Boolean
    Protected mstrIDHora, mstrDescHora As String

    Public Overrides ReadOnly Property RequeryRecords() As Engine.RequeryMode
        Get
            Return RequeryMode.ActiveRecord
        End Get
    End Property

#Region " Load "

    Public Function AbrirAltaMOD(ByVal IDObra As Integer, ByVal IDTrabajo As Integer, ByVal CodTrabajo As String, _
                                 ByVal DescTrabajo As String, ByVal QPrevTrabajo As Double, ByVal IDHora As String, _
                                 ByVal DescHora As String, ByVal blnFacturable As Boolean) As DataTable

        txtCodTrabajo.Text = CodTrabajo
        txtDescTrabajo.Text = DescTrabajo
        mintIDObra = IDObra
        mintIDTrabajo = IDTrabajo
        mdblQPrevTrabajo = QPrevTrabajo
        mstrIDHora = IDHora
        mstrDescHora = DescHora
        mblnFacturable = blnFacturable

        Dim frm As New Form
        frm = Me
        frm.ShowDialog() 'Para que no traiga todos los registros

        If Me.DialogResult = DialogResult.OK Then Return mdtMod
        Return Nothing
    End Function

    Protected Overridable Sub frmAddMOD_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadEnums()
        ADDNewMOD()
    End Sub

    Protected Overridable Sub LoadEnums()
        cmbTipoFacturacion.DataSource = New EnumData("enumomodTipoFacturacion")
    End Sub

    Protected Overridable Sub ADDNewMOD()
        Me.AddNew()

        advIDHora.Text = mstrIDHora
        ulDescHora.Text = mstrDescHora
        Me.CurrentData.Rows(0)("IDObra") = mintIDObra
        Me.CurrentData.Rows(0)("IDTrabajo") = mintIDTrabajo
        Me.CurrentData.Rows(0)("CodTrabajo") = txtCodTrabajo.Text
        Me.CurrentData.Rows(0)("IDHora") = advIDHora.Text
        Me.CurrentData.Rows(0)("DesHora") = ulDescHora.Text
        Me.CurrentData.Rows(0)("Manual") = False
        Me.CurrentData.Rows(0)("Facturable") = mblnFacturable

        If IsNothing(mdtMod) Then mdtMod = CurrentData.Clone
    End Sub

#End Region

    Protected Overridable Function ValidaDatosObligatorios() As Boolean
        If Length(txtCodTrabajo.Text) = 0 Then
            mblnCancel = True
            ExpertisApp.GenerateMessage("El Trabajo es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 'El Cod. Trabajo es un dato obligatorio.
        End If
    End Function

    Protected Overridable Sub CmbNuevo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbNuevo.Click
        mblnCancel = ValidaDatosObligatorios()
        If Not mblnCancel Then
            mdtMod.Rows.Add(Me.CurrentData.Rows(0).ItemArray)
            ADDNewMOD()
        End If
    End Sub

    Protected Overridable Sub CmbAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbAceptar.Click
        mblnCancel = ValidaDatosObligatorios()
        If Not mblnCancel Then
            Me.DialogResult = DialogResult.OK
            mdtMod.Rows.Add(Me.CurrentData.Rows(0).ItemArray)
            Me.RecordsState = UI.RecordsState.Saved
            Me.Close()
        End If
    End Sub

    Protected Overridable Sub cmbCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCancelar.Click
        mblnCancel = False
        Me.RecordsState = UI.RecordsState.Saved
        Me.Close()
    End Sub

    Protected Overridable Sub frmAddMOD_BusinessCalling(ByVal sender As Object, ByVal e As Engine.UI.BusinessCallingEventArgs) Handles MyBase.BusinessCalling
        e.Data.Context("QPrevTrabajo") = mdblQPrevTrabajo
    End Sub

    Protected Overridable Sub frmAddMOD_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = mblnCancel
    End Sub

End Class
