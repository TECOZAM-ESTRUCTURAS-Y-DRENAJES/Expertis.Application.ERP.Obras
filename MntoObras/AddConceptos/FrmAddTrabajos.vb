Public Class FrmAddTrabajos
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
    Public WithEvents chkNoAcumular As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents lblTipoFacturacion As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtTextoTrabajo As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents chkFacturable As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents cbxTipoFacturacion As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents lblUDMedida As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblQPrev As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblCodTrabajo As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxIDUDMedida As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents txtQPrev As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents txtDescTrabajo As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblTipoTrabajo As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblSubTipoTrabajo As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtCodTrabajo As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblTextoTrabajo As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents cmbCancelar As Solmicro.Expertis.Engine.UI.Button
    Public WithEvents CmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Public WithEvents AdvTipoTrabajo As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents AdvSubTipoTrabajo As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents cbxTipoCoste As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents FraFechasTrabajo As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents lblFechaFinTrabajo As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxFechaFinTrabajo As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents lblFechaInicioTrabajo As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxFechaInicioTrabajo As Solmicro.Expertis.Engine.UI.CalendarBox

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Public WithEvents lblNumPedido As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtNumPedido As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblQPrevResponsable As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtQPrevResponsable As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblTipoLinea As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxTipoLinea As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents AdvSubSubTipoTrabajo As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblSubSubTipoTrabajo As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents FraImportes As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents txtMargenTrabajo As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents txtImpTotalVtaA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents txtImpUnitarioVta As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents txtImpUnitario As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents txtImpTotalA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblTipoCoste As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblMargenTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblImpTotalVtaA As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblImpUnitarioVta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblImpTotalA As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtQUnidad As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblImpUnitario As Solmicro.Expertis.Engine.UI.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim cbxTipoFacturacion_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxIDUDMedida_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxTipoCoste_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxTipoLinea_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAddTrabajos))
        Me.chkNoAcumular = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.lblTipoFacturacion = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTextoTrabajo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.chkFacturable = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.cbxTipoFacturacion = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblUDMedida = New Solmicro.Expertis.Engine.UI.Label
        Me.lblQPrev = New Solmicro.Expertis.Engine.UI.Label
        Me.lblCodTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxIDUDMedida = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.txtQPrev = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtDescTrabajo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblTipoTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.lblSubTipoTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.txtCodTrabajo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblTextoTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.CmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.AdvTipoTrabajo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.AdvSubTipoTrabajo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblTipoCoste = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxTipoCoste = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.FraFechasTrabajo = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblFechaFinTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaFinTrabajo = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaInicioTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaInicioTrabajo = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblNumPedido = New Solmicro.Expertis.Engine.UI.Label
        Me.txtNumPedido = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblQPrevResponsable = New Solmicro.Expertis.Engine.UI.Label
        Me.txtQPrevResponsable = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblTipoLinea = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxTipoLinea = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.AdvSubSubTipoTrabajo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblSubSubTipoTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.FraImportes = New Solmicro.Expertis.Engine.UI.Frame
        Me.txtImpTotalA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImpUnitario = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblMargenTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.txtMargenTrabajo = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblImpTotalVtaA = New Solmicro.Expertis.Engine.UI.Label
        Me.lblImpUnitarioVta = New Solmicro.Expertis.Engine.UI.Label
        Me.txtImpTotalVtaA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImpUnitarioVta = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblImpTotalA = New Solmicro.Expertis.Engine.UI.Label
        Me.lblImpUnitario = New Solmicro.Expertis.Engine.UI.Label
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.txtQUnidad = New Solmicro.Expertis.Engine.UI.NumericTextBox
        CType(Me.cbxTipoFacturacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxIDUDMedida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.suspendlayout()
        CType(Me.cbxTipoCoste, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FraFechasTrabajo.SuspendLayout()
        CType(Me.cbxTipoLinea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FraImportes.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkNoAcumular
        '
        Me.chkNoAcumular.AutoSize = True
        Me.chkNoAcumular.Checked = True
        Me.chkNoAcumular.CheckState = System.Windows.Forms.CheckState.Checked
        Me.TryDataBinding(chkNoAcumular, New System.Windows.Forms.Binding("BindableValue", Me, "NoAcumular", True))
        Me.chkNoAcumular.Location = New System.Drawing.Point(480, 112)
        Me.chkNoAcumular.Name = "chkNoAcumular"
        Me.chkNoAcumular.Size = New System.Drawing.Size(94, 18)
        Me.chkNoAcumular.TabIndex = 10
        Me.chkNoAcumular.Text = "No Acumular"
        '
        'lblTipoFacturacion
        '
        Me.lblTipoFacturacion.AutoSize = False
        Me.lblTipoFacturacion.Location = New System.Drawing.Point(9, 183)
        Me.lblTipoFacturacion.Name = "lblTipoFacturacion"
        Me.lblTipoFacturacion.Size = New System.Drawing.Size(100, 24)
        Me.lblTipoFacturacion.TabIndex = 228
        Me.lblTipoFacturacion.Tag = "IdRec=4682;"
        Me.lblTipoFacturacion.Text = "Tipo Facturación"
        '
        'txtTextoTrabajo
        '
        Me.TryDataBinding(txtTextoTrabajo, New System.Windows.Forms.Binding("Text", Me, "Texto", True))
        Me.txtTextoTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.txtTextoTrabajo.Location = New System.Drawing.Point(110, 284)
        Me.txtTextoTrabajo.Multiline = True
        Me.txtTextoTrabajo.Name = "txtTextoTrabajo"
        Me.txtTextoTrabajo.Size = New System.Drawing.Size(464, 61)
        Me.txtTextoTrabajo.TabIndex = 17
        '
        'chkFacturable
        '
        Me.chkFacturable.Checked = True
        Me.chkFacturable.CheckState = System.Windows.Forms.CheckState.Checked
        Me.TryDataBinding(chkFacturable, New System.Windows.Forms.Binding("BindableValue", Me, "Facturable", True))
        Me.chkFacturable.Location = New System.Drawing.Point(480, 184)
        Me.chkFacturable.Name = "chkFacturable"
        Me.chkFacturable.Size = New System.Drawing.Size(95, 20)
        Me.chkFacturable.TabIndex = 15
        Me.chkFacturable.Text = "Facturable"
        '
        'cbxTipoFacturacion
        '
        Me.TryDataBinding(cbxTipoFacturacion, New System.Windows.Forms.Binding("Value", Me, "TipoFacturacion", True))
        cbxTipoFacturacion_DesignTimeLayout.LayoutString = resources.GetString("cbxTipoFacturacion_DesignTimeLayout.LayoutString")
        Me.cbxTipoFacturacion.DesignTimeLayout = cbxTipoFacturacion_DesignTimeLayout
        Me.cbxTipoFacturacion.DisabledBackColor = System.Drawing.Color.White
        Me.cbxTipoFacturacion.DisplayMember = "Value"
        Me.cbxTipoFacturacion.Location = New System.Drawing.Point(110, 183)
        Me.cbxTipoFacturacion.Name = "cbxTipoFacturacion"
        Me.cbxTipoFacturacion.PrimaryDataFields = "TipoFacturacion"
        Me.cbxTipoFacturacion.SecondaryDataFields = "Value"
        Me.cbxTipoFacturacion.SelectedIndex = -1
        Me.cbxTipoFacturacion.SelectedItem = Nothing
        Me.cbxTipoFacturacion.Size = New System.Drawing.Size(158, 21)
        Me.cbxTipoFacturacion.TabIndex = 14
        '
        'lblUDMedida
        '
        Me.lblUDMedida.Location = New System.Drawing.Point(9, 64)
        Me.lblUDMedida.Name = "lblUDMedida"
        Me.lblUDMedida.Size = New System.Drawing.Size(70, 13)
        Me.lblUDMedida.TabIndex = 224
        Me.lblUDMedida.Tag = "IdRec=4382;"
        Me.lblUDMedida.Text = "Ud. Medida"
        '
        'lblQPrev
        '
        Me.lblQPrev.Location = New System.Drawing.Point(169, 112)
        Me.lblQPrev.Name = "lblQPrev"
        Me.lblQPrev.Size = New System.Drawing.Size(53, 13)
        Me.lblQPrev.TabIndex = 225
        Me.lblQPrev.Tag = "IdRec=11154;"
        Me.lblQPrev.Text = "C. Prev."
        '
        'lblCodTrabajo
        '
        Me.lblCodTrabajo.Location = New System.Drawing.Point(9, 40)
        Me.lblCodTrabajo.Name = "lblCodTrabajo"
        Me.lblCodTrabajo.Size = New System.Drawing.Size(50, 13)
        Me.lblCodTrabajo.TabIndex = 227
        Me.lblCodTrabajo.Tag = ""
        Me.lblCodTrabajo.Text = "Trabajo"
        '
        'cbxIDUDMedida
        '
        Me.TryDataBinding(cbxIDUDMedida, New System.Windows.Forms.Binding("Text", Me, "IDUDMedida", True))
        cbxIDUDMedida_DesignTimeLayout.LayoutString = resources.GetString("cbxIDUDMedida_DesignTimeLayout.LayoutString")
        Me.cbxIDUDMedida.DesignTimeLayout = cbxIDUDMedida_DesignTimeLayout
        Me.cbxIDUDMedida.DisabledBackColor = System.Drawing.Color.White
        Me.cbxIDUDMedida.DisplayMember = "IDUdMedida"
        Me.cbxIDUDMedida.EntityName = "UdMedida"
        Me.cbxIDUDMedida.Location = New System.Drawing.Point(110, 60)
        Me.cbxIDUDMedida.Name = "cbxIDUDMedida"
        Me.cbxIDUDMedida.PrimaryDataFields = "IDUdMedida"
        Me.cbxIDUDMedida.SecondaryDataFields = "IDUdMedida"
        Me.cbxIDUDMedida.SelectedIndex = -1
        Me.cbxIDUDMedida.SelectedItem = Nothing
        Me.cbxIDUDMedida.Size = New System.Drawing.Size(124, 21)
        Me.cbxIDUDMedida.TabIndex = 5
        Me.cbxIDUDMedida.ValueMember = "IDUdMedida"
        Me.cbxIDUDMedida.ViewName = "tbMaestroUdMedida"
        '
        'txtQPrev
        '
        Me.TryDataBinding(txtQPrev, New System.Windows.Forms.Binding("Value", Me, "QPrev", True))
        Me.txtQPrev.DisabledBackColor = System.Drawing.Color.White
        Me.txtQPrev.Location = New System.Drawing.Point(227, 108)
        Me.txtQPrev.Name = "txtQPrev"
        Me.txtQPrev.Size = New System.Drawing.Size(55, 21)
        Me.txtQPrev.TabIndex = 8
        '
        'txtDescTrabajo
        '
        Me.TryDataBinding(txtDescTrabajo, New System.Windows.Forms.Binding("Text", Me, "DescTrabajo", True))
        Me.txtDescTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescTrabajo.Location = New System.Drawing.Point(237, 36)
        Me.txtDescTrabajo.Multiline = True
        Me.txtDescTrabajo.Name = "txtDescTrabajo"
        Me.txtDescTrabajo.Size = New System.Drawing.Size(337, 69)
        Me.txtDescTrabajo.TabIndex = 4
        '
        'lblTipoTrabajo
        '
        Me.lblTipoTrabajo.Location = New System.Drawing.Point(9, 15)
        Me.lblTipoTrabajo.Name = "lblTipoTrabajo"
        Me.lblTipoTrabajo.Size = New System.Drawing.Size(78, 13)
        Me.lblTipoTrabajo.TabIndex = 222
        Me.lblTipoTrabajo.Tag = "IdRec=5279;"
        Me.lblTipoTrabajo.Text = "Tipo Trabajo"
        '
        'lblSubTipoTrabajo
        '
        Me.lblSubTipoTrabajo.Location = New System.Drawing.Point(237, 15)
        Me.lblSubTipoTrabajo.Name = "lblSubTipoTrabajo"
        Me.lblSubTipoTrabajo.Size = New System.Drawing.Size(53, 13)
        Me.lblSubTipoTrabajo.TabIndex = 223
        Me.lblSubTipoTrabajo.Tag = "IdRec=5402;"
        Me.lblSubTipoTrabajo.Text = "SubTipo"
        '
        'txtCodTrabajo
        '
        Me.TryDataBinding(txtCodTrabajo, New System.Windows.Forms.Binding("Text", Me, "CodTrabajo", True))
        Me.txtCodTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.txtCodTrabajo.Location = New System.Drawing.Point(110, 36)
        Me.txtCodTrabajo.Name = "txtCodTrabajo"
        Me.txtCodTrabajo.Size = New System.Drawing.Size(124, 21)
        Me.txtCodTrabajo.TabIndex = 3
        '
        'lblTextoTrabajo
        '
        Me.lblTextoTrabajo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTextoTrabajo.Location = New System.Drawing.Point(9, 284)
        Me.lblTextoTrabajo.Name = "lblTextoTrabajo"
        Me.lblTextoTrabajo.Size = New System.Drawing.Size(91, 13)
        Me.lblTextoTrabajo.TabIndex = 205
        Me.lblTextoTrabajo.Text = "Observaciones"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbCancelar)
        Me.Panel1.Controls.Add(Me.CmbAceptar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 345)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(580, 42)
        Me.Panel1.TabIndex = 18
        '
        'cmbCancelar
        '
        Me.cmbCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmbCancelar.Location = New System.Drawing.Point(296, 7)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(94, 29)
        Me.cmbCancelar.TabIndex = 21
        Me.cmbCancelar.Text = "Cancelar"
        '
        'CmbAceptar
        '
        Me.CmbAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.CmbAceptar.Location = New System.Drawing.Point(196, 7)
        Me.CmbAceptar.Name = "CmbAceptar"
        Me.CmbAceptar.Size = New System.Drawing.Size(94, 29)
        Me.CmbAceptar.TabIndex = 20
        Me.CmbAceptar.Text = "Aceptar"
        '
        'AdvTipoTrabajo
        '
        Me.TryDataBinding(AdvTipoTrabajo, New System.Windows.Forms.Binding("Text", Me, "IDTipoTrabajo", True))
        Me.AdvTipoTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvTipoTrabajo.EntityName = "ObraTipoTrabajo"
        Me.AdvTipoTrabajo.Location = New System.Drawing.Point(110, 10)
        Me.AdvTipoTrabajo.Name = "AdvTipoTrabajo"
        Me.AdvTipoTrabajo.SecondaryDataFields = "IDTipoTrabajo"
        Me.AdvTipoTrabajo.Size = New System.Drawing.Size(76, 23)
        Me.AdvTipoTrabajo.TabIndex = 0
        '
        'AdvSubTipoTrabajo
        '
        Me.TryDataBinding(AdvSubTipoTrabajo, New System.Windows.Forms.Binding("Text", Me, "IDSubTipoTrabajo", True))
        Me.AdvSubTipoTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvSubTipoTrabajo.EntityName = "ObraSubtipoTrabajo"
        Me.AdvSubTipoTrabajo.Location = New System.Drawing.Point(294, 10)
        Me.AdvSubTipoTrabajo.Name = "AdvSubTipoTrabajo"
        Me.AdvSubTipoTrabajo.SecondaryDataFields = "IDSubtipoTrabajo"
        Me.AdvSubTipoTrabajo.Size = New System.Drawing.Size(76, 23)
        Me.AdvSubTipoTrabajo.TabIndex = 1
        '
        'lblTipoCoste
        '
        Me.lblTipoCoste.Location = New System.Drawing.Point(9, 137)
        Me.lblTipoCoste.Name = "lblTipoCoste"
        Me.lblTipoCoste.Size = New System.Drawing.Size(68, 13)
        Me.lblTipoCoste.TabIndex = 240
        Me.lblTipoCoste.Tag = ""
        Me.lblTipoCoste.Text = "Tipo Coste"
        '
        'cbxTipoCoste
        '
        Me.TryDataBinding(cbxTipoCoste, New System.Windows.Forms.Binding("Value", Me, "TipoCosteDI", True))
        cbxTipoCoste_DesignTimeLayout.LayoutString = resources.GetString("cbxTipoCoste_DesignTimeLayout.LayoutString")
        Me.cbxTipoCoste.DesignTimeLayout = cbxTipoCoste_DesignTimeLayout
        Me.cbxTipoCoste.DisabledBackColor = System.Drawing.Color.White
        Me.cbxTipoCoste.DisplayMember = "Value"
        Me.cbxTipoCoste.Location = New System.Drawing.Point(110, 133)
        Me.cbxTipoCoste.Name = "cbxTipoCoste"
        Me.cbxTipoCoste.PrimaryDataFields = "Estado"
        Me.cbxTipoCoste.SecondaryDataFields = "Value"
        Me.cbxTipoCoste.SelectedIndex = -1
        Me.cbxTipoCoste.SelectedItem = Nothing
        Me.cbxTipoCoste.Size = New System.Drawing.Size(103, 21)
        Me.cbxTipoCoste.TabIndex = 11
        '
        'FraFechasTrabajo
        '
        Me.FraFechasTrabajo.Controls.Add(Me.lblFechaFinTrabajo)
        Me.FraFechasTrabajo.Controls.Add(Me.cbxFechaFinTrabajo)
        Me.FraFechasTrabajo.Controls.Add(Me.lblFechaInicioTrabajo)
        Me.FraFechasTrabajo.Controls.Add(Me.cbxFechaInicioTrabajo)
        Me.FraFechasTrabajo.Location = New System.Drawing.Point(220, 130)
        Me.FraFechasTrabajo.Name = "FraFechasTrabajo"
        Me.FraFechasTrabajo.Size = New System.Drawing.Size(354, 51)
        Me.FraFechasTrabajo.TabIndex = 13
        Me.FraFechasTrabajo.TabStop = False
        Me.FraFechasTrabajo.Text = "Fechas"
        '
        'lblFechaFinTrabajo
        '
        Me.lblFechaFinTrabajo.Location = New System.Drawing.Point(201, 22)
        Me.lblFechaFinTrabajo.Name = "lblFechaFinTrabajo"
        Me.lblFechaFinTrabajo.Size = New System.Drawing.Size(23, 13)
        Me.lblFechaFinTrabajo.TabIndex = 183
        Me.lblFechaFinTrabajo.Tag = ""
        Me.lblFechaFinTrabajo.Text = "Fin"
        '
        'cbxFechaFinTrabajo
        '
        Me.TryDataBinding(cbxFechaFinTrabajo, New System.Windows.Forms.Binding("BindableValue", Me, "FechaFin", True))
        Me.cbxFechaFinTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaFinTrabajo.Location = New System.Drawing.Point(229, 18)
        Me.cbxFechaFinTrabajo.Name = "cbxFechaFinTrabajo"
        Me.cbxFechaFinTrabajo.Size = New System.Drawing.Size(95, 21)
        Me.cbxFechaFinTrabajo.TabIndex = 13
        '
        'lblFechaInicioTrabajo
        '
        Me.lblFechaInicioTrabajo.Location = New System.Drawing.Point(31, 22)
        Me.lblFechaInicioTrabajo.Name = "lblFechaInicioTrabajo"
        Me.lblFechaInicioTrabajo.Size = New System.Drawing.Size(38, 13)
        Me.lblFechaInicioTrabajo.TabIndex = 184
        Me.lblFechaInicioTrabajo.Tag = ""
        Me.lblFechaInicioTrabajo.Text = "Inicio"
        '
        'cbxFechaInicioTrabajo
        '
        Me.TryDataBinding(cbxFechaInicioTrabajo, New System.Windows.Forms.Binding("BindableValue", Me, "FechaInicio", True))
        Me.cbxFechaInicioTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaInicioTrabajo.Location = New System.Drawing.Point(74, 18)
        Me.cbxFechaInicioTrabajo.Name = "cbxFechaInicioTrabajo"
        Me.cbxFechaInicioTrabajo.Size = New System.Drawing.Size(95, 21)
        Me.cbxFechaInicioTrabajo.TabIndex = 12
        '
        'lblNumPedido
        '
        Me.lblNumPedido.Location = New System.Drawing.Point(9, 162)
        Me.lblNumPedido.Name = "lblNumPedido"
        Me.lblNumPedido.Size = New System.Drawing.Size(45, 13)
        Me.lblNumPedido.TabIndex = 238
        Me.lblNumPedido.Tag = ""
        Me.lblNumPedido.Text = "Pedido"
        '
        'txtNumPedido
        '
        Me.TryDataBinding(txtNumPedido, New System.Windows.Forms.Binding("Text", Me, "NumeroPedido", True))
        Me.txtNumPedido.DisabledBackColor = System.Drawing.Color.White
        Me.txtNumPedido.Location = New System.Drawing.Point(110, 158)
        Me.txtNumPedido.Name = "txtNumPedido"
        Me.txtNumPedido.Size = New System.Drawing.Size(103, 21)
        Me.txtNumPedido.TabIndex = 12
        '
        'lblQPrevResponsable
        '
        Me.lblQPrevResponsable.Location = New System.Drawing.Point(287, 112)
        Me.lblQPrevResponsable.Name = "lblQPrevResponsable"
        Me.lblQPrevResponsable.Size = New System.Drawing.Size(129, 13)
        Me.lblQPrevResponsable.TabIndex = 242
        Me.lblQPrevResponsable.Tag = ""
        Me.lblQPrevResponsable.Text = "C. Prev. Responsable"
        '
        'txtQPrevResponsable
        '
        Me.TryDataBinding(txtQPrevResponsable, New System.Windows.Forms.Binding("Value", Me, "QPrevResponsable", True))
        Me.txtQPrevResponsable.DisabledBackColor = System.Drawing.Color.White
        Me.txtQPrevResponsable.Location = New System.Drawing.Point(419, 108)
        Me.txtQPrevResponsable.Name = "txtQPrevResponsable"
        Me.txtQPrevResponsable.Size = New System.Drawing.Size(55, 21)
        Me.txtQPrevResponsable.TabIndex = 9
        '
        'lblTipoLinea
        '
        Me.lblTipoLinea.Location = New System.Drawing.Point(9, 88)
        Me.lblTipoLinea.Name = "lblTipoLinea"
        Me.lblTipoLinea.Size = New System.Drawing.Size(65, 13)
        Me.lblTipoLinea.TabIndex = 246
        Me.lblTipoLinea.Tag = ""
        Me.lblTipoLinea.Text = "Tipo Línea"
        '
        'cbxTipoLinea
        '
        Me.TryDataBinding(cbxTipoLinea, New System.Windows.Forms.Binding("Value", Me, "TipoLinea", True))
        cbxTipoLinea_DesignTimeLayout.LayoutString = resources.GetString("cbxTipoLinea_DesignTimeLayout.LayoutString")
        Me.cbxTipoLinea.DesignTimeLayout = cbxTipoLinea_DesignTimeLayout
        Me.cbxTipoLinea.DisabledBackColor = System.Drawing.Color.White
        Me.cbxTipoLinea.Location = New System.Drawing.Point(110, 84)
        Me.cbxTipoLinea.Name = "cbxTipoLinea"
        Me.cbxTipoLinea.SelectedIndex = -1
        Me.cbxTipoLinea.SelectedItem = Nothing
        Me.cbxTipoLinea.Size = New System.Drawing.Size(124, 21)
        Me.cbxTipoLinea.TabIndex = 6
        '
        'AdvSubSubTipoTrabajo
        '
        Me.TryDataBinding(AdvSubSubTipoTrabajo, New System.Windows.Forms.Binding("Text", Me, "SubSubTipoTrabajo", True))
        Me.AdvSubSubTipoTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvSubSubTipoTrabajo.EntityName = "ObraSubSubtipoTrabajo"
        Me.AdvSubSubTipoTrabajo.Location = New System.Drawing.Point(498, 10)
        Me.AdvSubSubTipoTrabajo.Name = "AdvSubSubTipoTrabajo"
        Me.AdvSubSubTipoTrabajo.SecondaryDataFields = "IDSubSubtipoTrabajo"
        Me.AdvSubSubTipoTrabajo.Size = New System.Drawing.Size(76, 23)
        Me.AdvSubSubTipoTrabajo.TabIndex = 2
        '
        'lblSubSubTipoTrabajo
        '
        Me.lblSubSubTipoTrabajo.Location = New System.Drawing.Point(415, 15)
        Me.lblSubSubTipoTrabajo.Name = "lblSubSubTipoTrabajo"
        Me.lblSubSubTipoTrabajo.Size = New System.Drawing.Size(79, 13)
        Me.lblSubSubTipoTrabajo.TabIndex = 248
        Me.lblSubSubTipoTrabajo.Tag = ""
        Me.lblSubSubTipoTrabajo.Text = "Sub SubTipo"
        '
        'FraImportes
        '
        Me.FraImportes.Controls.Add(Me.txtImpTotalA)
        Me.FraImportes.Controls.Add(Me.txtImpUnitario)
        Me.FraImportes.Controls.Add(Me.lblMargenTrabajo)
        Me.FraImportes.Controls.Add(Me.txtMargenTrabajo)
        Me.FraImportes.Controls.Add(Me.lblImpTotalVtaA)
        Me.FraImportes.Controls.Add(Me.lblImpUnitarioVta)
        Me.FraImportes.Controls.Add(Me.txtImpTotalVtaA)
        Me.FraImportes.Controls.Add(Me.txtImpUnitarioVta)
        Me.FraImportes.Controls.Add(Me.lblImpTotalA)
        Me.FraImportes.Controls.Add(Me.lblImpUnitario)
        Me.FraImportes.Location = New System.Drawing.Point(5, 205)
        Me.FraImportes.Name = "FraImportes"
        Me.FraImportes.Size = New System.Drawing.Size(569, 74)
        Me.FraImportes.TabIndex = 16
        Me.FraImportes.TabStop = False
        Me.FraImportes.Text = "Importes"
        '
        'txtImpTotalA
        '
        Me.TryDataBinding(txtImpTotalA, New System.Windows.Forms.Binding("Value", Me, "ImpPrevQTrabajoA", True))
        Me.txtImpTotalA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpTotalA.Enabled = False
        Me.txtImpTotalA.Location = New System.Drawing.Point(105, 45)
        Me.txtImpTotalA.Name = "txtImpTotalA"
        Me.txtImpTotalA.Size = New System.Drawing.Size(100, 21)
        Me.txtImpTotalA.TabIndex = 1
        Me.txtImpTotalA.TabStop = False
        '
        'txtImpUnitario
        '
        Me.TryDataBinding(txtImpUnitario, New System.Windows.Forms.Binding("Value", Me, "ImpPrevTrabajoA", True))
        Me.txtImpUnitario.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpUnitario.Location = New System.Drawing.Point(105, 20)
        Me.txtImpUnitario.Name = "txtImpUnitario"
        Me.txtImpUnitario.Size = New System.Drawing.Size(100, 21)
        Me.txtImpUnitario.TabIndex = 0
        '
        'lblMargenTrabajo
        '
        Me.lblMargenTrabajo.Location = New System.Drawing.Point(259, 24)
        Me.lblMargenTrabajo.Name = "lblMargenTrabajo"
        Me.lblMargenTrabajo.Size = New System.Drawing.Size(52, 13)
        Me.lblMargenTrabajo.TabIndex = 338
        Me.lblMargenTrabajo.Tag = ""
        Me.lblMargenTrabajo.Text = "% Prev."
        Me.lblMargenTrabajo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMargenTrabajo
        '
        Me.TryDataBinding(txtMargenTrabajo, New System.Windows.Forms.Binding("Value", Me, "MargenPrevTrabajo", True))
        Me.txtMargenTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.txtMargenTrabajo.Location = New System.Drawing.Point(259, 45)
        Me.txtMargenTrabajo.Name = "txtMargenTrabajo"
        Me.txtMargenTrabajo.Size = New System.Drawing.Size(55, 21)
        Me.txtMargenTrabajo.TabIndex = 2
        Me.txtMargenTrabajo.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'lblImpTotalVtaA
        '
        Me.lblImpTotalVtaA.Location = New System.Drawing.Point(363, 49)
        Me.lblImpTotalVtaA.Name = "lblImpTotalVtaA"
        Me.lblImpTotalVtaA.Size = New System.Drawing.Size(70, 13)
        Me.lblImpTotalVtaA.TabIndex = 250
        Me.lblImpTotalVtaA.Tag = ""
        Me.lblImpTotalVtaA.Text = "Total Venta"
        '
        'lblImpUnitarioVta
        '
        Me.lblImpUnitarioVta.Location = New System.Drawing.Point(363, 24)
        Me.lblImpUnitarioVta.Name = "lblImpUnitarioVta"
        Me.lblImpUnitarioVta.Size = New System.Drawing.Size(87, 13)
        Me.lblImpUnitarioVta.TabIndex = 251
        Me.lblImpUnitarioVta.Tag = ""
        Me.lblImpUnitarioVta.Text = "Unitario Venta"
        '
        'txtImpTotalVtaA
        '
        Me.TryDataBinding(txtImpTotalVtaA, New System.Windows.Forms.Binding("Value", Me, "ImpPrevQTrabajoVentaA", True))
        Me.txtImpTotalVtaA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpTotalVtaA.Enabled = False
        Me.txtImpTotalVtaA.Location = New System.Drawing.Point(455, 45)
        Me.txtImpTotalVtaA.Name = "txtImpTotalVtaA"
        Me.txtImpTotalVtaA.Size = New System.Drawing.Size(100, 21)
        Me.txtImpTotalVtaA.TabIndex = 4
        Me.txtImpTotalVtaA.TabStop = False
        '
        'txtImpUnitarioVta
        '
        Me.TryDataBinding(txtImpUnitarioVta, New System.Windows.Forms.Binding("Value", Me, "ImpPrevTrabajoVentaA", True))
        Me.txtImpUnitarioVta.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpUnitarioVta.Location = New System.Drawing.Point(455, 20)
        Me.txtImpUnitarioVta.Name = "txtImpUnitarioVta"
        Me.txtImpUnitarioVta.Size = New System.Drawing.Size(100, 21)
        Me.txtImpUnitarioVta.TabIndex = 3
        '
        'lblImpTotalA
        '
        Me.lblImpTotalA.Location = New System.Drawing.Point(14, 49)
        Me.lblImpTotalA.Name = "lblImpTotalA"
        Me.lblImpTotalA.Size = New System.Drawing.Size(34, 13)
        Me.lblImpTotalA.TabIndex = 246
        Me.lblImpTotalA.Tag = ""
        Me.lblImpTotalA.Text = "Total"
        '
        'lblImpUnitario
        '
        Me.lblImpUnitario.Location = New System.Drawing.Point(14, 24)
        Me.lblImpUnitario.Name = "lblImpUnitario"
        Me.lblImpUnitario.Size = New System.Drawing.Size(51, 13)
        Me.lblImpUnitario.TabIndex = 247
        Me.lblImpUnitario.Tag = ""
        Me.lblImpUnitario.Text = "Unitario"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(9, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 251
        Me.Label1.Tag = "IdRec=11154;"
        Me.Label1.Text = "C. Unitaria"
        '
        'txtQUnidad
        '
        Me.TryDataBinding(txtQUnidad, New System.Windows.Forms.Binding("Value", Me, "QUnidad", True))
        Me.txtQUnidad.DisabledBackColor = System.Drawing.Color.White
        Me.txtQUnidad.Location = New System.Drawing.Point(110, 108)
        Me.txtQUnidad.Name = "txtQUnidad"
        Me.txtQUnidad.Size = New System.Drawing.Size(55, 21)
        Me.txtQUnidad.TabIndex = 7
        '
        'FrmAddTrabajos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(580, 387)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtQUnidad)
        Me.Controls.Add(Me.FraImportes)
        Me.Controls.Add(Me.AdvSubSubTipoTrabajo)
        Me.Controls.Add(Me.lblSubSubTipoTrabajo)
        Me.Controls.Add(Me.lblTipoLinea)
        Me.Controls.Add(Me.cbxTipoLinea)
        Me.Controls.Add(Me.lblQPrevResponsable)
        Me.Controls.Add(Me.txtQPrevResponsable)
        Me.Controls.Add(Me.lblTipoCoste)
        Me.Controls.Add(Me.cbxTipoCoste)
        Me.Controls.Add(Me.FraFechasTrabajo)
        Me.Controls.Add(Me.lblNumPedido)
        Me.Controls.Add(Me.txtNumPedido)
        Me.Controls.Add(Me.AdvSubTipoTrabajo)
        Me.Controls.Add(Me.AdvTipoTrabajo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblUDMedida)
        Me.Controls.Add(Me.lblQPrev)
        Me.Controls.Add(Me.lblCodTrabajo)
        Me.Controls.Add(Me.lblTipoTrabajo)
        Me.Controls.Add(Me.lblSubTipoTrabajo)
        Me.Controls.Add(Me.lblTextoTrabajo)
        Me.Controls.Add(Me.chkNoAcumular)
        Me.Controls.Add(Me.lblTipoFacturacion)
        Me.Controls.Add(Me.txtTextoTrabajo)
        Me.Controls.Add(Me.chkFacturable)
        Me.Controls.Add(Me.cbxTipoFacturacion)
        Me.Controls.Add(Me.cbxIDUDMedida)
        Me.Controls.Add(Me.txtQPrev)
        Me.Controls.Add(Me.txtDescTrabajo)
        Me.Controls.Add(Me.txtCodTrabajo)
        Me.EntityName = "ObraTrabajo"
        Me.MaximizeBox = False
        Me.Name = "FrmAddTrabajos"
        Me.NavigationFields = "IDTrabajo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta de trabajos"
        Me.ViewName = "tbObraTrabajo"
        CType(Me.cbxTipoFacturacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxIDUDMedida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.cbxTipoCoste, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FraFechasTrabajo.ResumeLayout(False)
        Me.FraFechasTrabajo.PerformLayout()
        CType(Me.cbxTipoLinea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FraImportes.ResumeLayout(False)
        Me.FraImportes.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Protected mintIDObra, mintIDTrabajoPadre As Integer
    Protected mstrNumeroPedido, mstrIDTipoObra, mstrIDTipoTrabajo, mstrIDSubTipoTrabajo, mstrIDSubSubTipoTrabajo, mstrIDUDMedida As String
    Protected mDtFechaInicio, mDtFechaFin As Date
    Protected mblnNoAcumular, mblnGestionConstructoras, mblnCancel, mblnFacturable As Boolean
    Protected mContext As BusinessData
    Protected mstrCodTrabajo As String

    Public Overrides ReadOnly Property RequeryRecords() As Engine.RequeryMode
        Get
            Return RequeryMode.ActiveRecord
        End Get
    End Property

    Public Function AbrirAltaTrabajos(ByVal intIDObra As Integer, ByVal strIDTipoObra As String, _
                                      ByVal strIDUDMedida As String, ByVal strNumPedido As String, _
                                      ByVal strIDTipoTrabajo As String, ByVal strIDSubTipoTrabajo As String, _
                                      ByVal strIDSubSubTipoTrabajo As String, ByVal intIDTrabajoPadre As Integer, _
                                      ByVal blnNoAcumular As Boolean, ByVal blnGestionConstructoras As Boolean, _
                                      ByVal Context As BusinessData, ByVal StrIDMoneda As String, _
                                      ByVal OwnerForm As FormBase, ByVal blnFacturable As Boolean, _
                                      Optional ByVal FechaInicio As Date = cnMinDate, Optional ByVal FechaFin As Date = cnMinDate) As DataRow

        mintIDObra = intIDObra
        mstrNumeroPedido = strNumPedido
        mintIDTrabajoPadre = intIDTrabajoPadre
        mstrIDTipoObra = strIDTipoObra
        mstrIDUDMedida = strIDUDMedida
        mstrIDTipoTrabajo = strIDTipoTrabajo
        mstrIDSubTipoTrabajo = strIDSubTipoTrabajo
        mstrIDSubSubTipoTrabajo = strIDSubSubTipoTrabajo
        mblnNoAcumular = blnNoAcumular
        mblnGestionConstructoras = blnGestionConstructoras
        mContext = Context
        mDtFechaInicio = FechaInicio
        mDtFechaFin = FechaFin
        mblnFacturable = blnFacturable

        Dim frm As New Form
        frm = Me

        If Length(StrIDMoneda) > 0 Then
            Dim StDatos As New Moneda.DatosObtenerMoneda
            StDatos.IDMoneda = StrIDMoneda
            Dim DtMoneda As MonedaInfo = ExpertisApp.ExecuteTask(Of Moneda.DatosObtenerMoneda, MonedaInfo)(AddressOf Business.General.Moneda.ObtenerMoneda, StDatos)

            Me.txtImpUnitario.DecimalDigits = DtMoneda.NDecimalesImporte
            Me.txtImpTotalA.DecimalDigits = DtMoneda.NDecimalesImporte
            Me.txtImpUnitarioVta.DecimalDigits = DtMoneda.NDecimalesImporte
            Me.txtImpTotalVtaA.DecimalDigits = DtMoneda.NDecimalesImporte
            Me.txtMargenTrabajo.DecimalDigits = DtMoneda.NDecimalesImporte
        End If

        frm.ShowDialog(OwnerForm) 'Para que no traiga todos los registros

        If Me.DialogResult = DialogResult.OK Then Return SetTrabajo()
        Return Nothing
    End Function

    Protected Overridable Function SetTrabajo() As DataRow
        Dim dtTrabajo As DataTable = New BE.DataEngine().Filter(mContext("ViewName"), New NoRowsFilterItem)
        Dim dr As DataRow = dtTrabajo.NewRow
        For Each dc As DataColumn In Me.CurrentData.Columns
            If dtTrabajo.Columns.Contains(dc.ColumnName) Then
                dr(dc.ColumnName) = Me.CurrentData.Rows(0)(dc.ColumnName)
            End If
        Next

        Return dr
    End Function

    Protected Overridable Sub FrmAddTrabajos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbxTipoCoste.DataSource = New EnumData("enumtcdiTipoCoste")
        cbxTipoFacturacion.DataSource = New EnumData("enumotTipoFacturacion")
        cbxTipoLinea.DataSource = New EnumData("enumTipoLineaTrabajo")

        Me.AddNew()

        Me.CurrentData.Rows(0)("IDObra") = mintIDObra
        Me.CurrentData.Rows(0)("IDTipoObra") = mstrIDTipoObra
        If Length(mstrIDTipoTrabajo) > 0 Then Me.CurrentData.Rows(0)("IDTipoTrabajo") = mstrIDTipoTrabajo
        If Length(mstrIDSubTipoTrabajo) > 0 Then Me.CurrentData.Rows(0)("IDSubTipoTrabajo") = mstrIDSubTipoTrabajo
        If Length(mstrIDSubSubTipoTrabajo) > 0 Then Me.CurrentData.Rows(0)("SubSubTipoTrabajo") = mstrIDSubSubTipoTrabajo
        If mContext.Contains("CodTrabajo") Then Me.CurrentData.Rows(0)("CodTrabajo") = mContext("CodTrabajo")

        Me.CurrentData.Rows(0)("Facturable") = mContext("Facturable") 'True
        Me.CurrentData.Rows(0)("NoAcumular") = mblnNoAcumular
        Me.CurrentData.Rows(0)("TipoFacturacion") = IIf(mblnGestionConstructoras, CInt(enumotTipoFacturacion.otfPorUdsObra), CInt(enumotTipoFacturacion.otfPorVencimientos))
        Me.CurrentData.Rows(0)("QUnidad") = 1
        Me.CurrentData.Rows(0)("QPrev") = 1
        Me.CurrentData.Rows(0)("Facturable") = mblnFacturable

        Me.CurrentData.Rows(0)("IDUDMedida") = mstrIDUDMedida
        Me.CurrentData.Rows(0)("Estado") = CInt(enumotEstado.otPendiente)
        If mDtFechaInicio <> cnMinDate Then Me.CurrentData.Rows(0)("FechaInicio") = mDtFechaInicio
        If mDtFechaFin <> cnMinDate Then Me.CurrentData.Rows(0)("FechaFin") = mDtFechaFin
        cbxTipoCoste.Value = CInt(enumtcdiTipoCoste.tcdiDirecto)
        cbxTipoLinea.Value = CInt(enumTipoLineaTrabajo.tltTrabajo)

        If mintIDTrabajoPadre > 0 Then Me.CurrentData.Rows(0)("IDTrabajoPadre") = mintIDTrabajoPadre
        If Length(mstrNumeroPedido) > 0 Then Me.CurrentData.Rows(0)("NumeroPedido") = mstrNumeroPedido
        mstrCodTrabajo = Me.CurrentData.Rows(0)("CodTrabajo") & String.Empty
    End Sub

    Protected Overridable Sub CmbAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbAceptar.Click
        If Length(txtCodTrabajo.Text) > 0 Then
            Me.DialogResult = DialogResult.OK
            mblnCancel = False
            Me.RecordsState = UI.RecordsState.Saved
            Me.Close()
        Else
            mblnCancel = True
            ExpertisApp.GenerateMessage("El Trabajo es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 'El Cod. Trabajo es un dato obligatorio.
        End If
    End Sub

    Protected Overridable Sub cmbCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCancelar.Click
        mblnCancel = False
        Me.RecordsState = UI.RecordsState.Saved
        Me.Close()
    End Sub

    Protected Overridable Sub chkNoAcumular_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkNoAcumular.CheckedChanged
        txtImpUnitario.Enabled = chkNoAcumular.Checked
        txtMargenTrabajo.Enabled = chkNoAcumular.Checked
        txtImpUnitarioVta.Enabled = chkNoAcumular.Checked
    End Sub

    Protected Overridable Sub AdvTipoTrabajo_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles AdvTipoTrabajo.SetPredefinedFilter
        If Length(mstrIDTipoObra) > 0 Then
            e.Filter.Add(New StringFilterItem("IDTipoObra", mstrIDTipoObra))
        End If
    End Sub

    Protected Overridable Sub AdvSubTipoTrabajo_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles AdvSubTipoTrabajo.SetPredefinedFilter
        If Length(mstrIDTipoObra) > 0 Then
            e.Filter.Add(New StringFilterItem("IDTipoObra", mstrIDTipoObra))
        End If
        If Length(AdvTipoTrabajo.Text) > 0 Then
            e.Filter.Add(New StringFilterItem("IDTipoTrabajo", AdvTipoTrabajo.Text))
        End If
    End Sub

    Protected Overridable Sub AdvSubSubTipoTrabajo_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles AdvSubSubTipoTrabajo.SetPredefinedFilter
        If Length(mstrIDTipoObra) > 0 Then
            e.Filter.Add(New StringFilterItem("IDTipoObra", mstrIDTipoObra))
        End If
        If Length(AdvTipoTrabajo.Text) > 0 Then
            e.Filter.Add(New StringFilterItem("IDTipoTrabajo", AdvTipoTrabajo.Text))
        End If
        If Length(AdvSubTipoTrabajo.Text) > 0 Then
            e.Filter.Add(New StringFilterItem("IDSubTipoTrabajo", AdvSubTipoTrabajo.Text))
        End If
    End Sub

    Protected Overridable Sub FrmAddTrabajos_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = mblnCancel
    End Sub

    Protected Overridable Sub FrmAddTrabajos_BusinessCalling(ByVal sender As Object, ByVal e As Engine.UI.BusinessCallingEventArgs) Handles MyBase.BusinessCalling
        e.Data.Context = mContext
    End Sub

    Protected Overridable Sub txtCodTrabajo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCodTrabajo.Validating
        If Length(txtCodTrabajo.Text) > 0 Then
            Dim dvTrabajos As New DataView(mContext("dtTrabajos"))
            Dim f As New Filter
            f.Add(New StringFilterItem("CodTrabajo", txtCodTrabajo.Text))
            If mContext("PorNivel") Then
                f.Add(New NumberFilterItem("IDTrabajoPadre", mContext("IDTrabajoPadre")))
            Else
                f.Add(New IsNullFilterItem("IDTrabajoPadre", True))
            End If
            dvTrabajos.RowFilter = f.Compose(New AdoFilterComposer)
            If dvTrabajos.Count <> 0 Then
                e.Cancel = True
                ExpertisApp.GenerateMessage("Este Trabajo ya existe a ese nivel.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtCodTrabajo.Text = mstrCodTrabajo
            Else
                mstrCodTrabajo = txtCodTrabajo.Text
            End If
        End If
    End Sub

End Class
