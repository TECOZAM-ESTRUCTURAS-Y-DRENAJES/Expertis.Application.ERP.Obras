Public Class frmAddCentros
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
    Public WithEvents chbManual As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents lblHorasUnidad As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents ntbHorasUnidad As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblHorasPrevMod As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblMargenPrev As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents ntbMargenPrev As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblPrecioVentaA As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents ntbPrecioVentaA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblIDCentro As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents advIDCentro As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents ulDescCentro As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents ntbHorasPrevCentro As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents ntbTasaPrevCentroA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents ntbImpPrevCentroA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents ntbImpPrevCentroVentaA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblTasaPrevCentroA As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblImpPrevCentroA As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblImpPrevCentroVentaA As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents chbFacturable As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents FraFecha As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents clbFechaFin As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents clbFechaInicio As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents lblFechaInicio As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblFechaFin As Solmicro.Expertis.Engine.UI.Label

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.CmbNuevo = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.CmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.txtSecuencia = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtDescTrabajo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtCodTrabajo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblCodTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.lblSecuencia = New Solmicro.Expertis.Engine.UI.Label
        Me.lblIDCentro = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDCentro = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.ulDescCentro = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.chbManual = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.lblHorasUnidad = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbHorasUnidad = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblHorasPrevMod = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbHorasPrevCentro = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblTasaPrevCentroA = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbTasaPrevCentroA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblImpPrevCentroA = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbImpPrevCentroA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblMargenPrev = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbMargenPrev = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblImpPrevCentroVentaA = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbImpPrevCentroVentaA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblPrecioVentaA = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbPrecioVentaA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.chbFacturable = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.FraFecha = New Solmicro.Expertis.Engine.UI.Frame
        Me.clbFechaFin = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.clbFechaInicio = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaInicio = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFechaFin = New Solmicro.Expertis.Engine.UI.Label
        Me.Panel1.suspendlayout()
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
        Me.Panel1.Location = New System.Drawing.Point(0, 196)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(541, 42)
        Me.Panel1.TabIndex = 234
        '
        'CmbNuevo
        '
        Me.CmbNuevo.Location = New System.Drawing.Point(123, 7)
        Me.CmbNuevo.Name = "CmbNuevo"
        Me.CmbNuevo.Size = New System.Drawing.Size(94, 29)
        Me.CmbNuevo.TabIndex = 12
        Me.CmbNuevo.Text = "Nuevo"
        '
        'cmbCancelar
        '
        Me.cmbCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmbCancelar.Location = New System.Drawing.Point(323, 7)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(94, 29)
        Me.cmbCancelar.TabIndex = 14
        Me.cmbCancelar.Text = "Cancelar"
        '
        'CmbAceptar
        '
        Me.CmbAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.CmbAceptar.Location = New System.Drawing.Point(223, 7)
        Me.CmbAceptar.Name = "CmbAceptar"
        Me.CmbAceptar.Size = New System.Drawing.Size(94, 29)
        Me.CmbAceptar.TabIndex = 13
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
        Me.txtDescTrabajo.Enabled = False
        Me.txtDescTrabajo.Location = New System.Drawing.Point(195, 8)
        Me.txtDescTrabajo.Name = "txtDescTrabajo"
        Me.txtDescTrabajo.Size = New System.Drawing.Size(210, 21)
        Me.txtDescTrabajo.TabIndex = 238
        Me.txtDescTrabajo.TabStop = False
        '
        'txtCodTrabajo
        '
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
        'lblIDCentro
        '
        Me.lblIDCentro.Location = New System.Drawing.Point(4, 34)
        Me.lblIDCentro.Name = "lblIDCentro"
        Me.lblIDCentro.Size = New System.Drawing.Size(46, 13)
        Me.lblIDCentro.TabIndex = 240
        Me.lblIDCentro.Text = "Centro"
        '
        'advIDCentro
        '
        Me.TryDataBinding(advIDCentro, New System.Windows.Forms.Binding("Text", Me, "IDCentro"))
        Me.advIDCentro.EntityName = "Centro"
        Me.advIDCentro.Location = New System.Drawing.Point(71, 34)
        Me.advIDCentro.Name = "advIDCentro"
        Me.advIDCentro.PrimaryDataFields = "IDCentro"
        Me.advIDCentro.SecondaryDataFields = "IDCentro"
        Me.advIDCentro.Size = New System.Drawing.Size(119, 23)
        Me.advIDCentro.TabIndex = 1
        '
        'ulDescCentro
        '
        Me.TryDataBinding(ulDescCentro, New System.Windows.Forms.Binding("Text", Me.advIDCentro, "DescCentro"))
        Me.ulDescCentro.Location = New System.Drawing.Point(195, 34)
        Me.ulDescCentro.Name = "ulDescCentro"
        Me.ulDescCentro.Size = New System.Drawing.Size(183, 21)
        Me.ulDescCentro.TabIndex = 245
        '
        'chbManual
        '
        Me.TryDataBinding(chbManual, New System.Windows.Forms.Binding("BindableValue", Me, "Manual"))
        Me.chbManual.Location = New System.Drawing.Point(5, 62)
        Me.chbManual.Name = "chbManual"
        Me.chbManual.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chbManual.Size = New System.Drawing.Size(80, 23)
        Me.chbManual.TabIndex = 5
        Me.chbManual.Text = "Manual"
        Me.chbManual.TextAlignment = Janus.Windows.EditControls.TextAlignment.Far
        '
        'lblHorasUnidad
        '
        Me.lblHorasUnidad.Location = New System.Drawing.Point(111, 66)
        Me.lblHorasUnidad.Name = "lblHorasUnidad"
        Me.lblHorasUnidad.Size = New System.Drawing.Size(83, 13)
        Me.lblHorasUnidad.TabIndex = 249
        Me.lblHorasUnidad.Text = "Horas Unidad"
        '
        'ntbHorasUnidad
        '
        Me.TryDataBinding(ntbHorasUnidad, New System.Windows.Forms.Binding("Value", Me, "HorasUnidad"))
        Me.ntbHorasUnidad.Location = New System.Drawing.Point(199, 64)
        Me.ntbHorasUnidad.Name = "ntbHorasUnidad"
        Me.ntbHorasUnidad.Size = New System.Drawing.Size(79, 21)
        Me.ntbHorasUnidad.TabIndex = 6
        '
        'lblHorasPrevMod
        '
        Me.lblHorasPrevMod.Location = New System.Drawing.Point(111, 92)
        Me.lblHorasPrevMod.Name = "lblHorasPrevMod"
        Me.lblHorasPrevMod.Size = New System.Drawing.Size(73, 13)
        Me.lblHorasPrevMod.TabIndex = 251
        Me.lblHorasPrevMod.Text = "Horas Prev."
        '
        'ntbHorasPrevCentro
        '
        Me.TryDataBinding(ntbHorasPrevCentro, New System.Windows.Forms.Binding("Value", Me, "HorasPrevCentro"))
        Me.ntbHorasPrevCentro.Location = New System.Drawing.Point(199, 90)
        Me.ntbHorasPrevCentro.Name = "ntbHorasPrevCentro"
        Me.ntbHorasPrevCentro.Size = New System.Drawing.Size(79, 21)
        Me.ntbHorasPrevCentro.TabIndex = 7
        '
        'lblTasaPrevCentroA
        '
        Me.lblTasaPrevCentroA.Location = New System.Drawing.Point(4, 116)
        Me.lblTasaPrevCentroA.Name = "lblTasaPrevCentroA"
        Me.lblTasaPrevCentroA.Size = New System.Drawing.Size(66, 13)
        Me.lblTasaPrevCentroA.TabIndex = 253
        Me.lblTasaPrevCentroA.Text = "Tasa Prev."
        '
        'ntbTasaPrevCentroA
        '
        Me.TryDataBinding(ntbTasaPrevCentroA, New System.Windows.Forms.Binding("Value", Me, "TasaPrevCentroA"))
        Me.ntbTasaPrevCentroA.Location = New System.Drawing.Point(98, 116)
        Me.ntbTasaPrevCentroA.Name = "ntbTasaPrevCentroA"
        Me.ntbTasaPrevCentroA.Size = New System.Drawing.Size(121, 21)
        Me.ntbTasaPrevCentroA.TabIndex = 8
        '
        'lblImpPrevCentroA
        '
        Me.lblImpPrevCentroA.Location = New System.Drawing.Point(330, 118)
        Me.lblImpPrevCentroA.Name = "lblImpPrevCentroA"
        Me.lblImpPrevCentroA.Size = New System.Drawing.Size(67, 13)
        Me.lblImpPrevCentroA.TabIndex = 255
        Me.lblImpPrevCentroA.Text = "Imp. Prev."
        '
        'ntbImpPrevCentroA
        '
        Me.TryDataBinding(ntbImpPrevCentroA, New System.Windows.Forms.Binding("Value", Me, "ImpPrevCentroA"))
        Me.ntbImpPrevCentroA.Enabled = False
        Me.ntbImpPrevCentroA.Location = New System.Drawing.Point(415, 118)
        Me.ntbImpPrevCentroA.Name = "ntbImpPrevCentroA"
        Me.ntbImpPrevCentroA.Size = New System.Drawing.Size(121, 21)
        Me.ntbImpPrevCentroA.TabIndex = 256
        '
        'lblMargenPrev
        '
        Me.lblMargenPrev.Location = New System.Drawing.Point(330, 144)
        Me.lblMargenPrev.Name = "lblMargenPrev"
        Me.lblMargenPrev.Size = New System.Drawing.Size(49, 13)
        Me.lblMargenPrev.TabIndex = 257
        Me.lblMargenPrev.Text = "Margen"
        '
        'ntbMargenPrev
        '
        Me.TryDataBinding(ntbMargenPrev, New System.Windows.Forms.Binding("Value", Me, "MargenPrev"))
        Me.ntbMargenPrev.Location = New System.Drawing.Point(415, 144)
        Me.ntbMargenPrev.Name = "ntbMargenPrev"
        Me.ntbMargenPrev.Size = New System.Drawing.Size(121, 21)
        Me.ntbMargenPrev.TabIndex = 10
        '
        'lblImpPrevCentroVentaA
        '
        Me.lblImpPrevCentroVentaA.Location = New System.Drawing.Point(330, 172)
        Me.lblImpPrevCentroVentaA.Name = "lblImpPrevCentroVentaA"
        Me.lblImpPrevCentroVentaA.Size = New System.Drawing.Size(70, 13)
        Me.lblImpPrevCentroVentaA.TabIndex = 259
        Me.lblImpPrevCentroVentaA.Text = "Imp. Venta"
        '
        'ntbImpPrevCentroVentaA
        '
        Me.TryDataBinding(ntbImpPrevCentroVentaA, New System.Windows.Forms.Binding("Value", Me, "ImpPrevCentroVentaA"))
        Me.ntbImpPrevCentroVentaA.Enabled = False
        Me.ntbImpPrevCentroVentaA.Location = New System.Drawing.Point(415, 171)
        Me.ntbImpPrevCentroVentaA.Name = "ntbImpPrevCentroVentaA"
        Me.ntbImpPrevCentroVentaA.Size = New System.Drawing.Size(121, 21)
        Me.ntbImpPrevCentroVentaA.TabIndex = 260
        '
        'lblPrecioVentaA
        '
        Me.lblPrecioVentaA.Location = New System.Drawing.Point(4, 142)
        Me.lblPrecioVentaA.Name = "lblPrecioVentaA"
        Me.lblPrecioVentaA.Size = New System.Drawing.Size(78, 13)
        Me.lblPrecioVentaA.TabIndex = 261
        Me.lblPrecioVentaA.Text = "Precio Venta"
        '
        'ntbPrecioVentaA
        '
        Me.TryDataBinding(ntbPrecioVentaA, New System.Windows.Forms.Binding("Value", Me, "PrecioVentaA"))
        Me.ntbPrecioVentaA.Location = New System.Drawing.Point(98, 142)
        Me.ntbPrecioVentaA.Name = "ntbPrecioVentaA"
        Me.ntbPrecioVentaA.Size = New System.Drawing.Size(121, 21)
        Me.ntbPrecioVentaA.TabIndex = 9
        '
        'chbFacturable
        '
        Me.TryDataBinding(chbFacturable, New System.Windows.Forms.Binding("BindableValue", Me, "Facturable"))
        Me.chbFacturable.Location = New System.Drawing.Point(4, 167)
        Me.chbFacturable.Name = "chbFacturable"
        Me.chbFacturable.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chbFacturable.Size = New System.Drawing.Size(109, 23)
        Me.chbFacturable.TabIndex = 11
        Me.chbFacturable.Text = "Facturable"
        Me.chbFacturable.TextAlignment = Janus.Windows.EditControls.TextAlignment.Far
        '
        'FraFecha
        '
        Me.FraFecha.Controls.Add(Me.clbFechaFin)
        Me.FraFecha.Controls.Add(Me.clbFechaInicio)
        Me.FraFecha.Controls.Add(Me.lblFechaInicio)
        Me.FraFecha.Controls.Add(Me.lblFechaFin)
        Me.FraFecha.Location = New System.Drawing.Point(386, 32)
        Me.FraFecha.Name = "FraFecha"
        Me.FraFecha.Size = New System.Drawing.Size(151, 80)
        Me.FraFecha.TabIndex = 2
        Me.FraFecha.TabStop = False
        Me.FraFecha.Text = "Fechas"
        '
        'clbFechaFin
        '
        Me.TryDataBinding(clbFechaFin, New System.Windows.Forms.Binding("BindableValue", Me, "FechaFin"))
        Me.clbFechaFin.Location = New System.Drawing.Point(50, 47)
        Me.clbFechaFin.Name = "clbFechaFin"
        Me.clbFechaFin.Size = New System.Drawing.Size(93, 21)
        Me.clbFechaFin.TabIndex = 4
        '
        'clbFechaInicio
        '
        Me.TryDataBinding(clbFechaInicio, New System.Windows.Forms.Binding("BindableValue", Me, "FechaInicio"))
        Me.clbFechaInicio.Location = New System.Drawing.Point(50, 20)
        Me.clbFechaInicio.Name = "clbFechaInicio"
        Me.clbFechaInicio.Size = New System.Drawing.Size(93, 21)
        Me.clbFechaInicio.TabIndex = 3
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
        'frmAddCentros
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(541, 238)
        Me.Controls.Add(Me.FraFecha)
        Me.Controls.Add(Me.chbFacturable)
        Me.Controls.Add(Me.ntbPrecioVentaA)
        Me.Controls.Add(Me.ntbImpPrevCentroVentaA)
        Me.Controls.Add(Me.ntbMargenPrev)
        Me.Controls.Add(Me.ntbImpPrevCentroA)
        Me.Controls.Add(Me.ntbTasaPrevCentroA)
        Me.Controls.Add(Me.ntbHorasPrevCentro)
        Me.Controls.Add(Me.ntbHorasUnidad)
        Me.Controls.Add(Me.chbManual)
        Me.Controls.Add(Me.ulDescCentro)
        Me.Controls.Add(Me.advIDCentro)
        Me.Controls.Add(Me.txtSecuencia)
        Me.Controls.Add(Me.txtDescTrabajo)
        Me.Controls.Add(Me.txtCodTrabajo)
        Me.Controls.Add(Me.lblCodTrabajo)
        Me.Controls.Add(Me.lblSecuencia)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblIDCentro)
        Me.Controls.Add(Me.lblHorasUnidad)
        Me.Controls.Add(Me.lblHorasPrevMod)
        Me.Controls.Add(Me.lblTasaPrevCentroA)
        Me.Controls.Add(Me.lblImpPrevCentroA)
        Me.Controls.Add(Me.lblMargenPrev)
        Me.Controls.Add(Me.lblImpPrevCentroVentaA)
        Me.Controls.Add(Me.lblPrecioVentaA)
        Me.EntityName = "ObraCentro"
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmAddCentros"
        Me.NavigationFields = "IDObra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta de Centros"
        Me.ViewName = "vFrmObraCentro"
        Me.Panel1.ResumeLayout(False)
        Me.FraFecha.ResumeLayout(False)
        Me.FraFecha.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Protected mdtCentros As DataTable
    Protected mintIDObra, mintIDTrabajo As Integer
    Protected mdblQPrevTrabajo As Double
    Protected mblnCancel, mblnFacturable As Boolean

    Public Overrides ReadOnly Property RequeryRecords() As Engine.RequeryMode
        Get
            Return RequeryMode.ActiveRecord
        End Get
    End Property

#Region " Load "

    Public Function AbrirAltaCentros(ByVal IDObra As Integer, ByVal IDTrabajo As Integer, ByVal CodTrabajo As String, _
                                     ByVal DescTrabajo As String, ByVal QPrevTrabajo As Double, _
                                     ByVal blnFacturable As Boolean) As DataTable

        txtCodTrabajo.Text = CodTrabajo
        txtDescTrabajo.Text = DescTrabajo
        mintIDObra = IDObra
        mintIDTrabajo = IDTrabajo
        mdblQPrevTrabajo = QPrevTrabajo
        mblnFacturable = blnFacturable

        Dim frm As New Form
        frm = Me
        frm.ShowDialog() 'Para que no traiga todos los registros

        If Me.DialogResult = DialogResult.OK Then Return mdtCentros
        Return Nothing
    End Function

    Protected Overridable Sub frmAddCentros_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ADDNewMOD()
    End Sub

    Protected Overridable Sub ADDNewMOD()
        Me.AddNew()

        Me.CurrentData.Rows(0)("IDObra") = mintIDObra
        Me.CurrentData.Rows(0)("IDTrabajo") = mintIDTrabajo
        Me.CurrentData.Rows(0)("CodTrabajo") = txtCodTrabajo.Text
        Me.CurrentData.Rows(0)("Manual") = False
        Me.CurrentData.Rows(0)("Facturable") = mblnFacturable
        'Me.CurrentData.Rows(0)("HorasUnidad") = 0
        'Me.CurrentData.Rows(0)("HorasPrevCentro") = 0
        'Me.CurrentData.Rows(0)("TasaPrevCentroA") = 0
        'Me.CurrentData.Rows(0)("PrecioVentaA") = 0

        If IsNothing(mdtCentros) Then mdtCentros = CurrentData.Clone
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
            mdtCentros.Rows.Add(Me.CurrentData.Rows(0).ItemArray)
            ADDNewMOD()
        End If
    End Sub

    Protected Overridable Sub CmbAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbAceptar.Click
        mblnCancel = ValidaDatosObligatorios()
        If Not mblnCancel Then
            Me.DialogResult = DialogResult.OK
            mdtCentros.Rows.Add(Me.CurrentData.Rows(0).ItemArray)
            Me.RecordsState = UI.RecordsState.Saved
            Me.Close()
        End If
    End Sub

    Protected Overridable Sub cmbCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCancelar.Click
        mblnCancel = False
        Me.RecordsState = UI.RecordsState.Saved
        Me.Close()
    End Sub

    Protected Overridable Sub frmAddCentros_BusinessCalling(ByVal sender As Object, ByVal e As Engine.UI.BusinessCallingEventArgs) Handles MyBase.BusinessCalling
        e.Data.Context("QPrevTrabajo") = mdblQPrevTrabajo
    End Sub

    Protected Overridable Sub frmAddCentros_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = mblnCancel
    End Sub

End Class

