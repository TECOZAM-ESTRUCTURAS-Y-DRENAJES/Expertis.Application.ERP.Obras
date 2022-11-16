Public Class frmAddMateriales
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
    Public WithEvents lblCodTrabajo As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtCodTrabajo As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblSecuencia As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtSecuencia As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents txtDescMaterial As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblIDMaterial As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents advIDMaterial As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblIDProveedor As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents advIDProveedor As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents chbManual As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents lblQUnidad As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents ntbQUnidad As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblQPrev As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents ntbQPrev As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblPrecioPrevMatA As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents ntbPrecioPrevMatA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblDto1 As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents ntbDto1 As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblDto2 As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents ntbDto2 As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblDto3 As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents ntbDto3 As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblImpPrevMatA As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents ntbImpPrevMatA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblMargenPrev As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents ntbMargenPrev As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblImpPrevMatVentaA As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents ntbImpPrevMatVentaA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblPrecioVentaA As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents ntbPrecioVentaA As Solmicro.Expertis.Engine.UI.NumericTextBox

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents CmbNuevo As Solmicro.Expertis.Engine.UI.Button
    Public WithEvents cmbCancelar As Solmicro.Expertis.Engine.UI.Button
    Public WithEvents CmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Public WithEvents txtDescTrabajo As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents ulDescProveedor As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents lblIDAlmacen As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents advIDAlmacen As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents FraCContables As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents lblCCCompra As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents advCCCompra As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblCCVenta As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents advCCVenta As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents FraUnidades As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents lblIDUdInterna As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents advIDUdInterna As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblIDUdCompra As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents advIDUdCompra As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblIDUdVenta As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents advIDUdVenta As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents Frame1 As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents lblUdValoracion As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents ntbUdValoracion As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents chbFacturable As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents chbExpedible As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents lblTipoFacturacion As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cmbTipoFacturacion As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents lblFechaEntrega As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents clbFechaEntrega As Solmicro.Expertis.Engine.UI.CalendarBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.lblCodTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.txtCodTrabajo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtDescTrabajo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblSecuencia = New Solmicro.Expertis.Engine.UI.Label
        Me.txtSecuencia = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtDescMaterial = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblIDMaterial = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDMaterial = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblIDProveedor = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDProveedor = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.chbManual = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.lblQUnidad = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbQUnidad = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblQPrev = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbQPrev = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblPrecioPrevMatA = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbPrecioPrevMatA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblDto1 = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbDto1 = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblDto2 = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbDto2 = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblDto3 = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbDto3 = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblImpPrevMatA = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbImpPrevMatA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblMargenPrev = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbMargenPrev = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblImpPrevMatVentaA = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbImpPrevMatVentaA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblPrecioVentaA = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbPrecioVentaA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.CmbNuevo = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.CmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.ulDescProveedor = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.lblIDAlmacen = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDAlmacen = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.FraCContables = New Solmicro.Expertis.Engine.UI.Frame
        Me.advCCVenta = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.advCCCompra = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblCCCompra = New Solmicro.Expertis.Engine.UI.Label
        Me.lblCCVenta = New Solmicro.Expertis.Engine.UI.Label
        Me.FraUnidades = New Solmicro.Expertis.Engine.UI.Frame
        Me.ntbUdValoracion = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.advIDUdVenta = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.advIDUdCompra = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.advIDUdInterna = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblIDUdInterna = New Solmicro.Expertis.Engine.UI.Label
        Me.lblIDUdCompra = New Solmicro.Expertis.Engine.UI.Label
        Me.lblIDUdVenta = New Solmicro.Expertis.Engine.UI.Label
        Me.lblUdValoracion = New Solmicro.Expertis.Engine.UI.Label
        Me.Frame1 = New Solmicro.Expertis.Engine.UI.Frame
        Me.cmbTipoFacturacion = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.chbExpedible = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chbFacturable = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.lblTipoFacturacion = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFechaEntrega = New Solmicro.Expertis.Engine.UI.Label
        Me.clbFechaEntrega = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.Panel1.suspendlayout()
        Me.FraCContables.SuspendLayout()
        Me.FraUnidades.SuspendLayout()
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCodTrabajo
        '
        Me.lblCodTrabajo.Location = New System.Drawing.Point(4, 10)
        Me.lblCodTrabajo.Name = "lblCodTrabajo"
        Me.lblCodTrabajo.Size = New System.Drawing.Size(50, 13)
        Me.lblCodTrabajo.TabIndex = 0
        Me.lblCodTrabajo.Text = "Trabajo"
        '
        'txtCodTrabajo
        '
        Me.txtCodTrabajo.Enabled = False
        Me.txtCodTrabajo.Location = New System.Drawing.Point(71, 8)
        Me.txtCodTrabajo.Name = "txtCodTrabajo"
        Me.txtCodTrabajo.Size = New System.Drawing.Size(119, 21)
        Me.txtCodTrabajo.TabIndex = 0
        '
        'txtDescTrabajo
        '
        Me.txtDescTrabajo.Enabled = False
        Me.txtDescTrabajo.Location = New System.Drawing.Point(195, 8)
        Me.txtDescTrabajo.Name = "txtDescTrabajo"
        Me.txtDescTrabajo.Size = New System.Drawing.Size(210, 21)
        Me.txtDescTrabajo.TabIndex = 1
        Me.txtDescTrabajo.TabStop = False
        '
        'lblSecuencia
        '
        Me.lblSecuencia.Location = New System.Drawing.Point(409, 10)
        Me.lblSecuencia.Name = "lblSecuencia"
        Me.lblSecuencia.Size = New System.Drawing.Size(65, 13)
        Me.lblSecuencia.TabIndex = 203
        Me.lblSecuencia.Text = "Secuencia"
        '
        'txtSecuencia
        '
        Me.TryDataBinding(txtSecuencia, New System.Windows.Forms.Binding("Text", Me, "Secuencia"))
        Me.txtSecuencia.Location = New System.Drawing.Point(472, 8)
        Me.txtSecuencia.Name = "txtSecuencia"
        Me.txtSecuencia.Size = New System.Drawing.Size(64, 21)
        Me.txtSecuencia.TabIndex = 0
        '
        'txtDescMaterial
        '
        Me.TryDataBinding(txtDescMaterial, New System.Windows.Forms.Binding("Text", Me, "DescMaterial"))
        Me.txtDescMaterial.Location = New System.Drawing.Point(195, 34)
        Me.txtDescMaterial.Name = "txtDescMaterial"
        Me.txtDescMaterial.Size = New System.Drawing.Size(210, 21)
        Me.txtDescMaterial.TabIndex = 2
        '
        'lblIDMaterial
        '
        Me.lblIDMaterial.Location = New System.Drawing.Point(4, 36)
        Me.lblIDMaterial.Name = "lblIDMaterial"
        Me.lblIDMaterial.Size = New System.Drawing.Size(52, 13)
        Me.lblIDMaterial.TabIndex = 207
        Me.lblIDMaterial.Text = "Material"
        '
        'advIDMaterial
        '
        Me.TryDataBinding(advIDMaterial, New System.Windows.Forms.Binding("Text", Me, "IDMaterial"))
        Me.advIDMaterial.EntityName = "Articulo"
        Me.advIDMaterial.Location = New System.Drawing.Point(71, 34)
        Me.advIDMaterial.Name = "advIDMaterial"
        Me.advIDMaterial.PrimaryDataFields = "IDMaterial"
        Me.advIDMaterial.SecondaryDataFields = "IDArticulo"
        Me.advIDMaterial.Size = New System.Drawing.Size(119, 23)
        Me.advIDMaterial.TabIndex = 1
        '
        'lblIDProveedor
        '
        Me.lblIDProveedor.Location = New System.Drawing.Point(4, 62)
        Me.lblIDProveedor.Name = "lblIDProveedor"
        Me.lblIDProveedor.Size = New System.Drawing.Size(66, 13)
        Me.lblIDProveedor.TabIndex = 209
        Me.lblIDProveedor.Text = "Proveedor"
        '
        'advIDProveedor
        '
        Me.TryDataBinding(advIDProveedor, New System.Windows.Forms.Binding("Text", Me, "IDProveedor"))
        Me.advIDProveedor.EntityName = "Proveedor"
        Me.advIDProveedor.Location = New System.Drawing.Point(71, 60)
        Me.advIDProveedor.Name = "advIDProveedor"
        Me.advIDProveedor.PrimaryDataFields = "IDProveedor"
        Me.advIDProveedor.SecondaryDataFields = "IDProveedor"
        Me.advIDProveedor.Size = New System.Drawing.Size(119, 23)
        Me.advIDProveedor.TabIndex = 4
        '
        'chbManual
        '
        Me.TryDataBinding(chbManual, New System.Windows.Forms.Binding("BindableValue", Me, "Manual"))
        Me.chbManual.Location = New System.Drawing.Point(49, 175)
        Me.chbManual.Name = "chbManual"
        Me.chbManual.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chbManual.Size = New System.Drawing.Size(83, 23)
        Me.chbManual.TabIndex = 13
        Me.chbManual.Text = "Manual"
        Me.chbManual.TextAlignment = Janus.Windows.EditControls.TextAlignment.Far
        '
        'lblQUnidad
        '
        Me.lblQUnidad.Location = New System.Drawing.Point(156, 178)
        Me.lblQUnidad.Name = "lblQUnidad"
        Me.lblQUnidad.Size = New System.Drawing.Size(63, 13)
        Me.lblQUnidad.TabIndex = 213
        Me.lblQUnidad.Text = "C. Unidad"
        '
        'ntbQUnidad
        '
        Me.TryDataBinding(ntbQUnidad, New System.Windows.Forms.Binding("Value", Me, "QUnidad"))
        Me.ntbQUnidad.Location = New System.Drawing.Point(223, 176)
        Me.ntbQUnidad.Name = "ntbQUnidad"
        Me.ntbQUnidad.Size = New System.Drawing.Size(79, 21)
        Me.ntbQUnidad.TabIndex = 14
        '
        'lblQPrev
        '
        Me.lblQPrev.Location = New System.Drawing.Point(326, 178)
        Me.lblQPrev.Name = "lblQPrev"
        Me.lblQPrev.Size = New System.Drawing.Size(53, 13)
        Me.lblQPrev.TabIndex = 215
        Me.lblQPrev.Text = "C. Prev."
        '
        'ntbQPrev
        '
        Me.TryDataBinding(ntbQPrev, New System.Windows.Forms.Binding("Value", Me, "QPrev"))
        Me.ntbQPrev.Location = New System.Drawing.Point(396, 176)
        Me.ntbQPrev.Name = "ntbQPrev"
        Me.ntbQPrev.Size = New System.Drawing.Size(81, 21)
        Me.ntbQPrev.TabIndex = 15
        '
        'lblPrecioPrevMatA
        '
        Me.lblPrecioPrevMatA.Location = New System.Drawing.Point(4, 218)
        Me.lblPrecioPrevMatA.Name = "lblPrecioPrevMatA"
        Me.lblPrecioPrevMatA.Size = New System.Drawing.Size(75, 13)
        Me.lblPrecioPrevMatA.TabIndex = 217
        Me.lblPrecioPrevMatA.Text = "Precio Prev."
        '
        'ntbPrecioPrevMatA
        '
        Me.TryDataBinding(ntbPrecioPrevMatA, New System.Windows.Forms.Binding("Value", Me, "PrecioPrevMatA"))
        Me.ntbPrecioPrevMatA.Location = New System.Drawing.Point(92, 218)
        Me.ntbPrecioPrevMatA.Name = "ntbPrecioPrevMatA"
        Me.ntbPrecioPrevMatA.Size = New System.Drawing.Size(112, 21)
        Me.ntbPrecioPrevMatA.TabIndex = 16
        '
        'lblDto1
        '
        Me.lblDto1.Location = New System.Drawing.Point(220, 208)
        Me.lblDto1.Name = "lblDto1"
        Me.lblDto1.Size = New System.Drawing.Size(42, 13)
        Me.lblDto1.TabIndex = 219
        Me.lblDto1.Text = "Dto. 1"
        '
        'ntbDto1
        '
        Me.TryDataBinding(ntbDto1, New System.Windows.Forms.Binding("Value", Me, "Dto1"))
        Me.ntbDto1.Location = New System.Drawing.Point(268, 208)
        Me.ntbDto1.Name = "ntbDto1"
        Me.ntbDto1.Size = New System.Drawing.Size(49, 21)
        Me.ntbDto1.TabIndex = 18
        '
        'lblDto2
        '
        Me.lblDto2.Location = New System.Drawing.Point(220, 234)
        Me.lblDto2.Name = "lblDto2"
        Me.lblDto2.Size = New System.Drawing.Size(42, 13)
        Me.lblDto2.TabIndex = 221
        Me.lblDto2.Text = "Dto. 2"
        '
        'ntbDto2
        '
        Me.TryDataBinding(ntbDto2, New System.Windows.Forms.Binding("Value", Me, "Dto2"))
        Me.ntbDto2.Location = New System.Drawing.Point(268, 234)
        Me.ntbDto2.Name = "ntbDto2"
        Me.ntbDto2.Size = New System.Drawing.Size(49, 21)
        Me.ntbDto2.TabIndex = 19
        '
        'lblDto3
        '
        Me.lblDto3.Location = New System.Drawing.Point(220, 260)
        Me.lblDto3.Name = "lblDto3"
        Me.lblDto3.Size = New System.Drawing.Size(42, 13)
        Me.lblDto3.TabIndex = 223
        Me.lblDto3.Text = "Dto. 3"
        '
        'ntbDto3
        '
        Me.TryDataBinding(ntbDto3, New System.Windows.Forms.Binding("Value", Me, "Dto3"))
        Me.ntbDto3.Location = New System.Drawing.Point(268, 260)
        Me.ntbDto3.Name = "ntbDto3"
        Me.ntbDto3.Size = New System.Drawing.Size(49, 21)
        Me.ntbDto3.TabIndex = 20
        '
        'lblImpPrevMatA
        '
        Me.lblImpPrevMatA.Location = New System.Drawing.Point(330, 208)
        Me.lblImpPrevMatA.Name = "lblImpPrevMatA"
        Me.lblImpPrevMatA.Size = New System.Drawing.Size(67, 13)
        Me.lblImpPrevMatA.TabIndex = 225
        Me.lblImpPrevMatA.Text = "Imp. Prev."
        '
        'ntbImpPrevMatA
        '
        Me.TryDataBinding(ntbImpPrevMatA, New System.Windows.Forms.Binding("Value", Me, "ImpPrevMatA"))
        Me.ntbImpPrevMatA.Enabled = False
        Me.ntbImpPrevMatA.Location = New System.Drawing.Point(415, 208)
        Me.ntbImpPrevMatA.Name = "ntbImpPrevMatA"
        Me.ntbImpPrevMatA.Size = New System.Drawing.Size(121, 21)
        Me.ntbImpPrevMatA.TabIndex = 226
        '
        'lblMargenPrev
        '
        Me.lblMargenPrev.Location = New System.Drawing.Point(330, 234)
        Me.lblMargenPrev.Name = "lblMargenPrev"
        Me.lblMargenPrev.Size = New System.Drawing.Size(49, 13)
        Me.lblMargenPrev.TabIndex = 227
        Me.lblMargenPrev.Text = "Margen"
        '
        'ntbMargenPrev
        '
        Me.TryDataBinding(ntbMargenPrev, New System.Windows.Forms.Binding("Value", Me, "MargenPrev"))
        Me.ntbMargenPrev.Location = New System.Drawing.Point(415, 234)
        Me.ntbMargenPrev.Name = "ntbMargenPrev"
        Me.ntbMargenPrev.Size = New System.Drawing.Size(121, 21)
        Me.ntbMargenPrev.TabIndex = 21
        '
        'lblImpPrevMatVentaA
        '
        Me.lblImpPrevMatVentaA.Location = New System.Drawing.Point(330, 260)
        Me.lblImpPrevMatVentaA.Name = "lblImpPrevMatVentaA"
        Me.lblImpPrevMatVentaA.Size = New System.Drawing.Size(70, 13)
        Me.lblImpPrevMatVentaA.TabIndex = 229
        Me.lblImpPrevMatVentaA.Text = "Imp. Venta"
        '
        'ntbImpPrevMatVentaA
        '
        Me.TryDataBinding(ntbImpPrevMatVentaA, New System.Windows.Forms.Binding("Value", Me, "ImpPrevMatVentaA"))
        Me.ntbImpPrevMatVentaA.Enabled = False
        Me.ntbImpPrevMatVentaA.Location = New System.Drawing.Point(415, 260)
        Me.ntbImpPrevMatVentaA.Name = "ntbImpPrevMatVentaA"
        Me.ntbImpPrevMatVentaA.Size = New System.Drawing.Size(121, 21)
        Me.ntbImpPrevMatVentaA.TabIndex = 230
        '
        'lblPrecioVentaA
        '
        Me.lblPrecioVentaA.Location = New System.Drawing.Point(4, 244)
        Me.lblPrecioVentaA.Name = "lblPrecioVentaA"
        Me.lblPrecioVentaA.Size = New System.Drawing.Size(78, 13)
        Me.lblPrecioVentaA.TabIndex = 231
        Me.lblPrecioVentaA.Text = "Precio Venta"
        '
        'ntbPrecioVentaA
        '
        Me.TryDataBinding(ntbPrecioVentaA, New System.Windows.Forms.Binding("Value", Me, "PrecioVentaA"))
        Me.ntbPrecioVentaA.Location = New System.Drawing.Point(92, 244)
        Me.ntbPrecioVentaA.Name = "ntbPrecioVentaA"
        Me.ntbPrecioVentaA.Size = New System.Drawing.Size(112, 21)
        Me.ntbPrecioVentaA.TabIndex = 17
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CmbNuevo)
        Me.Panel1.Controls.Add(Me.cmbCancelar)
        Me.Panel1.Controls.Add(Me.CmbAceptar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 335)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(541, 42)
        Me.Panel1.TabIndex = 233
        '
        'CmbNuevo
        '
        Me.CmbNuevo.Location = New System.Drawing.Point(123, 7)
        Me.CmbNuevo.Name = "CmbNuevo"
        Me.CmbNuevo.Size = New System.Drawing.Size(94, 29)
        Me.CmbNuevo.TabIndex = 25
        Me.CmbNuevo.Text = "Nuevo"
        '
        'cmbCancelar
        '
        Me.cmbCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmbCancelar.Location = New System.Drawing.Point(323, 7)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(94, 29)
        Me.cmbCancelar.TabIndex = 27
        Me.cmbCancelar.Text = "Cancelar"
        '
        'CmbAceptar
        '
        Me.CmbAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.CmbAceptar.Location = New System.Drawing.Point(223, 7)
        Me.CmbAceptar.Name = "CmbAceptar"
        Me.CmbAceptar.Size = New System.Drawing.Size(94, 29)
        Me.CmbAceptar.TabIndex = 26
        Me.CmbAceptar.Text = "Aceptar"
        '
        'ulDescProveedor
        '
        Me.TryDataBinding(ulDescProveedor, New System.Windows.Forms.Binding("Text", Me.advIDProveedor, "DescProveedor"))
        Me.ulDescProveedor.Location = New System.Drawing.Point(195, 60)
        Me.ulDescProveedor.Name = "ulDescProveedor"
        Me.ulDescProveedor.Size = New System.Drawing.Size(136, 21)
        Me.ulDescProveedor.TabIndex = 234
        '
        'lblIDAlmacen
        '
        Me.lblIDAlmacen.Location = New System.Drawing.Point(409, 36)
        Me.lblIDAlmacen.Name = "lblIDAlmacen"
        Me.lblIDAlmacen.Size = New System.Drawing.Size(56, 13)
        Me.lblIDAlmacen.TabIndex = 235
        Me.lblIDAlmacen.Text = "Almacén"
        '
        'advIDAlmacen
        '
        Me.TryDataBinding(advIDAlmacen, New System.Windows.Forms.Binding("Text", Me, "IDAlmacen"))
        Me.advIDAlmacen.Location = New System.Drawing.Point(472, 34)
        Me.advIDAlmacen.Name = "advIDAlmacen"
        Me.advIDAlmacen.PrimaryDataFields = "IDAlmacen"
        Me.advIDAlmacen.Size = New System.Drawing.Size(64, 23)
        Me.advIDAlmacen.TabIndex = 3
        '
        'FraCContables
        '
        Me.FraCContables.Controls.Add(Me.advCCVenta)
        Me.FraCContables.Controls.Add(Me.advCCCompra)
        Me.FraCContables.Controls.Add(Me.lblCCCompra)
        Me.FraCContables.Controls.Add(Me.lblCCVenta)
        Me.FraCContables.Location = New System.Drawing.Point(2, 90)
        Me.FraCContables.Name = "FraCContables"
        Me.FraCContables.Size = New System.Drawing.Size(213, 78)
        Me.FraCContables.TabIndex = 5
        Me.FraCContables.TabStop = False
        Me.FraCContables.Text = "Cuentas Contables"
        '
        'advCCVenta
        '
        Me.TryDataBinding(advCCVenta, New System.Windows.Forms.Binding("Text", Me, "CCVenta"))
        Me.advCCVenta.Location = New System.Drawing.Point(91, 47)
        Me.advCCVenta.Name = "advCCVenta"
        Me.advCCVenta.PrimaryDataFields = "CCVenta"
        Me.advCCVenta.Size = New System.Drawing.Size(113, 23)
        Me.advCCVenta.TabIndex = 7
        '
        'advCCCompra
        '
        Me.TryDataBinding(advCCCompra, New System.Windows.Forms.Binding("Text", Me, "CCCompra"))
        Me.advCCCompra.Location = New System.Drawing.Point(91, 21)
        Me.advCCCompra.Name = "advCCCompra"
        Me.advCCCompra.PrimaryDataFields = "CCCompra"
        Me.advCCCompra.Size = New System.Drawing.Size(113, 23)
        Me.advCCCompra.TabIndex = 6
        '
        'lblCCCompra
        '
        Me.lblCCCompra.Location = New System.Drawing.Point(6, 21)
        Me.lblCCCompra.Name = "lblCCCompra"
        Me.lblCCCompra.Size = New System.Drawing.Size(87, 13)
        Me.lblCCCompra.TabIndex = 0
        Me.lblCCCompra.Text = "C. C. Compra"
        '
        'lblCCVenta
        '
        Me.lblCCVenta.Location = New System.Drawing.Point(6, 47)
        Me.lblCCVenta.Name = "lblCCVenta"
        Me.lblCCVenta.Size = New System.Drawing.Size(73, 13)
        Me.lblCCVenta.TabIndex = 2
        Me.lblCCVenta.Text = "C. C. Venta"
        '
        'FraUnidades
        '
        Me.FraUnidades.Controls.Add(Me.ntbUdValoracion)
        Me.FraUnidades.Controls.Add(Me.advIDUdVenta)
        Me.FraUnidades.Controls.Add(Me.advIDUdCompra)
        Me.FraUnidades.Controls.Add(Me.advIDUdInterna)
        Me.FraUnidades.Controls.Add(Me.lblIDUdInterna)
        Me.FraUnidades.Controls.Add(Me.lblIDUdCompra)
        Me.FraUnidades.Controls.Add(Me.lblIDUdVenta)
        Me.FraUnidades.Controls.Add(Me.lblUdValoracion)
        Me.FraUnidades.Location = New System.Drawing.Point(220, 90)
        Me.FraUnidades.Name = "FraUnidades"
        Me.FraUnidades.Size = New System.Drawing.Size(318, 78)
        Me.FraUnidades.TabIndex = 8
        Me.FraUnidades.TabStop = False
        Me.FraUnidades.Text = "Unidades"
        '
        'ntbUdValoracion
        '
        Me.TryDataBinding(ntbUdValoracion, New System.Windows.Forms.Binding("Value", Me, "UdValoracion"))
        Me.ntbUdValoracion.DecimalDigits = 0
        Me.ntbUdValoracion.DisabledBackColor = System.Drawing.Color.White
        Me.ntbUdValoracion.Location = New System.Drawing.Point(245, 47)
        Me.ntbUdValoracion.Name = "ntbUdValoracion"
        Me.ntbUdValoracion.Size = New System.Drawing.Size(66, 21)
        Me.ntbUdValoracion.TabIndex = 12
        '
        'advIDUdVenta
        '
        Me.TryDataBinding(advIDUdVenta, New System.Windows.Forms.Binding("Text", Me, "IDUdVenta"))
        Me.advIDUdVenta.EntityName = "UdMedida"
        Me.advIDUdVenta.Location = New System.Drawing.Point(82, 47)
        Me.advIDUdVenta.Name = "advIDUdVenta"
        Me.advIDUdVenta.PrimaryDataFields = "IDUdVenta"
        Me.advIDUdVenta.SecondaryDataFields = "IDUdMedida"
        Me.advIDUdVenta.Size = New System.Drawing.Size(66, 23)
        Me.advIDUdVenta.TabIndex = 10
        '
        'advIDUdCompra
        '
        Me.TryDataBinding(advIDUdCompra, New System.Windows.Forms.Binding("Text", Me, "IDUdCompra"))
        Me.advIDUdCompra.EntityName = "UdMedida"
        Me.advIDUdCompra.Location = New System.Drawing.Point(82, 21)
        Me.advIDUdCompra.Name = "advIDUdCompra"
        Me.advIDUdCompra.PrimaryDataFields = "IDUdCompra"
        Me.advIDUdCompra.SecondaryDataFields = "IDUdMedida"
        Me.advIDUdCompra.Size = New System.Drawing.Size(66, 23)
        Me.advIDUdCompra.TabIndex = 9
        '
        'advIDUdInterna
        '
        Me.TryDataBinding(advIDUdInterna, New System.Windows.Forms.Binding("Text", Me, "IDUdInterna"))
        Me.advIDUdInterna.EntityName = "UdMedida"
        Me.advIDUdInterna.Location = New System.Drawing.Point(245, 21)
        Me.advIDUdInterna.Name = "advIDUdInterna"
        Me.advIDUdInterna.PrimaryDataFields = "IDUdInterna"
        Me.advIDUdInterna.SecondaryDataFields = "IDUdMedida"
        Me.advIDUdInterna.Size = New System.Drawing.Size(66, 23)
        Me.advIDUdInterna.TabIndex = 11
        '
        'lblIDUdInterna
        '
        Me.lblIDUdInterna.Location = New System.Drawing.Point(156, 21)
        Me.lblIDUdInterna.Name = "lblIDUdInterna"
        Me.lblIDUdInterna.Size = New System.Drawing.Size(72, 13)
        Me.lblIDUdInterna.TabIndex = 0
        Me.lblIDUdInterna.Text = "Ud. Interna"
        '
        'lblIDUdCompra
        '
        Me.lblIDUdCompra.Location = New System.Drawing.Point(5, 23)
        Me.lblIDUdCompra.Name = "lblIDUdCompra"
        Me.lblIDUdCompra.Size = New System.Drawing.Size(76, 13)
        Me.lblIDUdCompra.TabIndex = 2
        Me.lblIDUdCompra.Text = "Ud. Compra"
        '
        'lblIDUdVenta
        '
        Me.lblIDUdVenta.Location = New System.Drawing.Point(5, 47)
        Me.lblIDUdVenta.Name = "lblIDUdVenta"
        Me.lblIDUdVenta.Size = New System.Drawing.Size(62, 13)
        Me.lblIDUdVenta.TabIndex = 4
        Me.lblIDUdVenta.Text = "Ud. Venta"
        '
        'lblUdValoracion
        '
        Me.lblUdValoracion.Location = New System.Drawing.Point(156, 47)
        Me.lblUdValoracion.Name = "lblUdValoracion"
        Me.lblUdValoracion.Size = New System.Drawing.Size(89, 13)
        Me.lblUdValoracion.TabIndex = 6
        Me.lblUdValoracion.Text = "Ud. Valoración"
        '
        'Frame1
        '
        Me.Frame1.Controls.Add(Me.cmbTipoFacturacion)
        Me.Frame1.Controls.Add(Me.chbExpedible)
        Me.Frame1.Controls.Add(Me.chbFacturable)
        Me.Frame1.Controls.Add(Me.lblTipoFacturacion)
        Me.Frame1.Location = New System.Drawing.Point(2, 283)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(536, 52)
        Me.Frame1.TabIndex = 239
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
        Me.cmbTipoFacturacion.Location = New System.Drawing.Point(365, 18)
        Me.cmbTipoFacturacion.Name = "cmbTipoFacturacion"
        Me.cmbTipoFacturacion.SelectedIndex = -1
        Me.cmbTipoFacturacion.SelectedItem = Nothing
        Me.cmbTipoFacturacion.Size = New System.Drawing.Size(162, 21)
        Me.cmbTipoFacturacion.TabIndex = 24
        Me.cmbTipoFacturacion.Value = Nothing
        '
        'chbExpedible
        '
        Me.TryDataBinding(chbExpedible, New System.Windows.Forms.Binding("BindableValue", Me, "Expedible"))
        Me.chbExpedible.Location = New System.Drawing.Point(34, 18)
        Me.chbExpedible.Name = "chbExpedible"
        Me.chbExpedible.Size = New System.Drawing.Size(88, 23)
        Me.chbExpedible.TabIndex = 22
        Me.chbExpedible.Text = "Expedible"
        '
        'chbFacturable
        '
        Me.TryDataBinding(chbFacturable, New System.Windows.Forms.Binding("BindableValue", Me, "Facturable"))
        Me.chbFacturable.Location = New System.Drawing.Point(143, 18)
        Me.chbFacturable.Name = "chbFacturable"
        Me.chbFacturable.Size = New System.Drawing.Size(93, 23)
        Me.chbFacturable.TabIndex = 23
        Me.chbFacturable.Text = "Facturable"
        '
        'lblTipoFacturacion
        '
        Me.lblTipoFacturacion.Location = New System.Drawing.Point(260, 21)
        Me.lblTipoFacturacion.Name = "lblTipoFacturacion"
        Me.lblTipoFacturacion.Size = New System.Drawing.Size(99, 13)
        Me.lblTipoFacturacion.TabIndex = 4
        Me.lblTipoFacturacion.Text = "Tipo Facturación"
        '
        'lblFechaEntrega
        '
        Me.lblFechaEntrega.Location = New System.Drawing.Point(335, 62)
        Me.lblFechaEntrega.Name = "lblFechaEntrega"
        Me.lblFechaEntrega.Size = New System.Drawing.Size(84, 13)
        Me.lblFechaEntrega.TabIndex = 240
        Me.lblFechaEntrega.Text = "FechaEntrega"
        '
        'clbFechaEntrega
        '
        Me.TryDataBinding(clbFechaEntrega, New System.Windows.Forms.Binding("BindableValue", Me, "FechaEntrega"))
        Me.clbFechaEntrega.Location = New System.Drawing.Point(424, 60)
        Me.clbFechaEntrega.Name = "clbFechaEntrega"
        Me.clbFechaEntrega.Size = New System.Drawing.Size(112, 21)
        Me.clbFechaEntrega.TabIndex = 241
        '
        'frmAddMateriales
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(541, 377)
        Me.Controls.Add(Me.clbFechaEntrega)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.FraUnidades)
        Me.Controls.Add(Me.FraCContables)
        Me.Controls.Add(Me.advIDAlmacen)
        Me.Controls.Add(Me.ulDescProveedor)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ntbPrecioVentaA)
        Me.Controls.Add(Me.ntbImpPrevMatVentaA)
        Me.Controls.Add(Me.ntbMargenPrev)
        Me.Controls.Add(Me.ntbImpPrevMatA)
        Me.Controls.Add(Me.ntbDto3)
        Me.Controls.Add(Me.ntbDto2)
        Me.Controls.Add(Me.ntbDto1)
        Me.Controls.Add(Me.ntbPrecioPrevMatA)
        Me.Controls.Add(Me.ntbQPrev)
        Me.Controls.Add(Me.ntbQUnidad)
        Me.Controls.Add(Me.chbManual)
        Me.Controls.Add(Me.advIDProveedor)
        Me.Controls.Add(Me.advIDMaterial)
        Me.Controls.Add(Me.txtDescMaterial)
        Me.Controls.Add(Me.txtSecuencia)
        Me.Controls.Add(Me.txtDescTrabajo)
        Me.Controls.Add(Me.txtCodTrabajo)
        Me.Controls.Add(Me.lblCodTrabajo)
        Me.Controls.Add(Me.lblSecuencia)
        Me.Controls.Add(Me.lblIDMaterial)
        Me.Controls.Add(Me.lblIDProveedor)
        Me.Controls.Add(Me.lblQUnidad)
        Me.Controls.Add(Me.lblQPrev)
        Me.Controls.Add(Me.lblPrecioPrevMatA)
        Me.Controls.Add(Me.lblDto1)
        Me.Controls.Add(Me.lblDto2)
        Me.Controls.Add(Me.lblDto3)
        Me.Controls.Add(Me.lblImpPrevMatA)
        Me.Controls.Add(Me.lblMargenPrev)
        Me.Controls.Add(Me.lblImpPrevMatVentaA)
        Me.Controls.Add(Me.lblPrecioVentaA)
        Me.Controls.Add(Me.lblIDAlmacen)
        Me.Controls.Add(Me.lblFechaEntrega)
        Me.EntityName = "ObraMaterial"
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmAddMateriales"
        Me.NavigationFields = "IDObra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta de Materiales"
        Me.ViewName = "vFrmObraMateriales"
        Me.WindowState = System.Windows.Forms.FormWindowState.Normal
        Me.Panel1.ResumeLayout(False)
        Me.FraCContables.ResumeLayout(False)
        Me.FraUnidades.ResumeLayout(False)
        Me.Frame1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Protected mdtMateriales As DataTable
    Protected mintIDObra, mintIDTrabajo As Integer
    Protected mdblQPrevTrabajo As Double
    Protected mblnCancel, mblnFacturable As Boolean
    Protected mFechaInicio As Date
    Protected mIDCliente, mstrEjercicioActual As String

    Public Overrides ReadOnly Property RequeryRecords() As Engine.RequeryMode
        Get
            Return RequeryMode.ActiveRecord
        End Get
    End Property

#Region " Load "

    Public Function AbrirAltaMateriales(ByVal IDObra As Integer, ByVal IDTrabajo As Integer, ByVal CodTrabajo As String, _
                                        ByVal DescTrabajo As String, ByVal QPrevTrabajo As Double, _
                                        ByVal FechaInicio As Date, ByVal IDCliente As String, _
                                        ByVal strEjercicio As String, ByVal blnFacturable As Boolean) As DataTable

        txtCodTrabajo.Text = CodTrabajo
        txtDescTrabajo.Text = DescTrabajo
        mintIDObra = IDObra
        mintIDTrabajo = IDTrabajo
        mdblQPrevTrabajo = QPrevTrabajo
        mFechaInicio = FechaInicio
        mIDCliente = IDCliente
        mstrEjercicioActual = strEjercicio
        mblnFacturable = blnFacturable

        Dim frm As New Form
        frm = Me
        frm.ShowDialog() 'Para que no traiga todos los registros

        If Me.DialogResult = DialogResult.OK Then Return mdtMateriales
        Return Nothing
    End Function

    Protected Overridable Sub frmAddMateriales_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadEnums()
        ADDNewMaterial()
    End Sub

    Protected Overridable Sub LoadEnums()
        cmbTipoFacturacion.DataSource = New EnumData("enumomTipoFacturacion")
    End Sub

    Protected Overridable Sub ADDNewMaterial()
        Me.AddNew()

        Me.CurrentData.Rows(0)("IDObra") = mintIDObra
        Me.CurrentData.Rows(0)("IDTrabajo") = mintIDTrabajo
        Me.CurrentData.Rows(0)("CodTrabajo") = txtCodTrabajo.Text
        Me.CurrentData.Rows(0)("Manual") = False
        Me.CurrentData.Rows(0)("EstadoFactura") = CInt(enumomEstadoFactura.omNoFacturado)
        Me.CurrentData.Rows(0)("Estado") = CInt(enumomEstado.omPendiente)
        Me.CurrentData.Rows(0)("UDValoracion") = 1
        Me.CurrentData.Rows(0)("Expedible") = False
        Me.CurrentData.Rows(0)("Facturable") = mblnFacturable

        If IsNothing(mdtMateriales) Then mdtMateriales = CurrentData.Clone
    End Sub

#End Region

    Protected Overridable Sub advCCCompra_advCCVenta_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles advCCCompra.SetPredefinedFilter
        e.Filter.Add("IDEjercicio", FilterOperator.Equal, mstrEjercicioActual, FilterType.String)
    End Sub

    Protected Overridable Function ValidaDatos() As Boolean
        Dim CC As New AltaPlanContable
        If Length(advCCVenta.Value) > 0 Then
            mblnCancel = Not CC.ValidaCuentaContable(advCCVenta.Value, mstrEjercicioActual)
        End If
        If Length(advCCCompra.Value) > 0 Then
            mblnCancel = Not CC.ValidaCuentaContable(advCCCompra.Value, mstrEjercicioActual)
        End If
        If Not mblnCancel Then
            If Length(txtCodTrabajo.Text) = 0 Then
                mblnCancel = True
                ExpertisApp.GenerateMessage("El Trabajo es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 'El Cod. Trabajo es un dato obligatorio.
            End If
        End If
    End Function

    Protected Overridable Sub CmbNuevo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbNuevo.Click
        mblnCancel = ValidaDatos()
        If Not mblnCancel Then
            mdtMateriales.Rows.Add(Me.CurrentData.Rows(0).ItemArray)
            ADDNewMaterial()
        End If
    End Sub

    Protected Overridable Sub CmbAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbAceptar.Click
        mblnCancel = ValidaDatos()
        If Not mblnCancel Then
            Me.DialogResult = DialogResult.OK
            mdtMateriales.Rows.Add(Me.CurrentData.Rows(0).ItemArray)
            Me.RecordsState = UI.RecordsState.Saved
            Me.Close()
        End If
    End Sub

    Protected Overridable Sub cmbCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCancelar.Click
        mblnCancel = False
        Me.RecordsState = UI.RecordsState.Saved
        Me.Close()
    End Sub

    Protected Overridable Sub frmAddMateriales_BusinessCalling(ByVal sender As Object, ByVal e As Engine.UI.BusinessCallingEventArgs) Handles MyBase.BusinessCalling
        e.Data.Context("IDEjercicio") = mstrEjercicioActual
        e.Data.Context("Fecha") = mFechaInicio
        e.Data.Context("IDCliente") = mIDCliente
        e.Data.Context("QPrevTrabajo") = mdblQPrevTrabajo
    End Sub

    Protected Overridable Sub frmAddMateriales_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = mblnCancel
    End Sub

End Class
