Public Class frmGeneraPeriodosAvance
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
    Public WithEvents txtDescTrabajo As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents txtCodTrabajo As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblCodTrabajo As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents FraCriteriosConfig As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents lblPeriodo As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblTipoPeriodo As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtPeriodo As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents cbxTipoPeriodo As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents fraTipoAvance As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents lblPorcFijo As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtPorcFijo As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblFechaFin As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxFechaFin As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents lblFechaInicio As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxFechaInicio As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents chkAvanceAutomatico As Solmicro.Expertis.Engine.UI.CheckBox

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents cmbCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents CmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Public WithEvents chkAvancePrevisto As Solmicro.Expertis.Engine.UI.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim cbxTipoPeriodo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGeneraPeriodosAvance))
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.CmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.txtDescTrabajo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtCodTrabajo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblCodTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.FraCriteriosConfig = New Solmicro.Expertis.Engine.UI.Frame
        Me.fraTipoAvance = New Solmicro.Expertis.Engine.UI.Frame
        Me.chkAvanceAutomatico = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkAvancePrevisto = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.lblPorcFijo = New Solmicro.Expertis.Engine.UI.Label
        Me.txtPorcFijo = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblPeriodo = New Solmicro.Expertis.Engine.UI.Label
        Me.lblTipoPeriodo = New Solmicro.Expertis.Engine.UI.Label
        Me.txtPeriodo = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.cbxTipoPeriodo = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblFechaFin = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaFin = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaInicio = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaInicio = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.Panel1.suspendlayout()
        Me.FraCriteriosConfig.SuspendLayout()
        Me.fraTipoAvance.SuspendLayout()
        CType(Me.cbxTipoPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbCancelar)
        Me.Panel1.Controls.Add(Me.CmbAceptar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 185)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(367, 42)
        Me.Panel1.TabIndex = 235
        '
        'cmbCancelar
        '
        Me.cmbCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmbCancelar.Location = New System.Drawing.Point(188, 7)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(94, 29)
        Me.cmbCancelar.TabIndex = 2
        Me.cmbCancelar.Text = "Cancelar"
        '
        'CmbAceptar
        '
        Me.CmbAceptar.Location = New System.Drawing.Point(84, 7)
        Me.CmbAceptar.Name = "CmbAceptar"
        Me.CmbAceptar.Size = New System.Drawing.Size(94, 29)
        Me.CmbAceptar.TabIndex = 1
        Me.CmbAceptar.Text = "Aceptar"
        '
        'txtDescTrabajo
        '
        Me.txtDescTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescTrabajo.Enabled = False
        Me.txtDescTrabajo.Location = New System.Drawing.Point(178, 8)
        Me.txtDescTrabajo.Name = "txtDescTrabajo"
        Me.txtDescTrabajo.Size = New System.Drawing.Size(185, 21)
        Me.txtDescTrabajo.TabIndex = 239
        Me.txtDescTrabajo.TabStop = False
        '
        'txtCodTrabajo
        '
        Me.txtCodTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.txtCodTrabajo.Enabled = False
        Me.txtCodTrabajo.Location = New System.Drawing.Point(80, 8)
        Me.txtCodTrabajo.Name = "txtCodTrabajo"
        Me.txtCodTrabajo.Size = New System.Drawing.Size(95, 21)
        Me.txtCodTrabajo.TabIndex = 237
        '
        'lblCodTrabajo
        '
        Me.lblCodTrabajo.Location = New System.Drawing.Point(7, 8)
        Me.lblCodTrabajo.Name = "lblCodTrabajo"
        Me.lblCodTrabajo.Size = New System.Drawing.Size(50, 13)
        Me.lblCodTrabajo.TabIndex = 238
        Me.lblCodTrabajo.Text = "Trabajo"
        '
        'FraCriteriosConfig
        '
        Me.FraCriteriosConfig.Controls.Add(Me.fraTipoAvance)
        Me.FraCriteriosConfig.Controls.Add(Me.lblPeriodo)
        Me.FraCriteriosConfig.Controls.Add(Me.lblTipoPeriodo)
        Me.FraCriteriosConfig.Controls.Add(Me.txtPeriodo)
        Me.FraCriteriosConfig.Controls.Add(Me.cbxTipoPeriodo)
        Me.FraCriteriosConfig.Location = New System.Drawing.Point(4, 64)
        Me.FraCriteriosConfig.Name = "FraCriteriosConfig"
        Me.FraCriteriosConfig.Size = New System.Drawing.Size(359, 120)
        Me.FraCriteriosConfig.TabIndex = 0
        Me.FraCriteriosConfig.TabStop = False
        Me.FraCriteriosConfig.Text = "Criterios para la generación de períodos"
        '
        'fraTipoAvance
        '
        Me.fraTipoAvance.Controls.Add(Me.chkAvanceAutomatico)
        Me.fraTipoAvance.Controls.Add(Me.chkAvancePrevisto)
        Me.fraTipoAvance.Controls.Add(Me.lblPorcFijo)
        Me.fraTipoAvance.Controls.Add(Me.txtPorcFijo)
        Me.fraTipoAvance.Location = New System.Drawing.Point(12, 43)
        Me.fraTipoAvance.Name = "fraTipoAvance"
        Me.fraTipoAvance.Size = New System.Drawing.Size(340, 70)
        Me.fraTipoAvance.TabIndex = 2
        Me.fraTipoAvance.TabStop = False
        '
        'chkAvanceAutomatico
        '
        Me.chkAvanceAutomatico.Location = New System.Drawing.Point(18, 38)
        Me.chkAvanceAutomatico.Name = "chkAvanceAutomatico"
        Me.chkAvanceAutomatico.Size = New System.Drawing.Size(174, 23)
        Me.chkAvanceAutomatico.TabIndex = 2
        Me.chkAvanceAutomatico.Text = "% Avance automático"
        '
        'chkAvancePrevisto
        '
        Me.chkAvancePrevisto.Location = New System.Drawing.Point(18, 14)
        Me.chkAvancePrevisto.Name = "chkAvancePrevisto"
        Me.chkAvancePrevisto.Size = New System.Drawing.Size(174, 23)
        Me.chkAvancePrevisto.TabIndex = 0
        Me.chkAvancePrevisto.Text = "% Avance previsto"
        '
        'lblPorcFijo
        '
        Me.lblPorcFijo.Location = New System.Drawing.Point(208, 18)
        Me.lblPorcFijo.Name = "lblPorcFijo"
        Me.lblPorcFijo.Size = New System.Drawing.Size(43, 13)
        Me.lblPorcFijo.TabIndex = 253
        Me.lblPorcFijo.Text = "% Fijo"
        Me.lblPorcFijo.Visible = False
        '
        'txtPorcFijo
        '
        Me.txtPorcFijo.DisabledBackColor = System.Drawing.Color.White
        Me.txtPorcFijo.Location = New System.Drawing.Point(256, 16)
        Me.txtPorcFijo.Name = "txtPorcFijo"
        Me.txtPorcFijo.Size = New System.Drawing.Size(75, 21)
        Me.txtPorcFijo.TabIndex = 1
        Me.txtPorcFijo.Visible = False
        '
        'lblPeriodo
        '
        Me.lblPeriodo.Location = New System.Drawing.Point(16, 24)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(50, 13)
        Me.lblPeriodo.TabIndex = 246
        Me.lblPeriodo.Text = "Periodo"
        '
        'lblTipoPeriodo
        '
        Me.lblTipoPeriodo.Location = New System.Drawing.Point(164, 24)
        Me.lblTipoPeriodo.Name = "lblTipoPeriodo"
        Me.lblTipoPeriodo.Size = New System.Drawing.Size(78, 13)
        Me.lblTipoPeriodo.TabIndex = 245
        Me.lblTipoPeriodo.Text = "Tipo periodo"
        '
        'txtPeriodo
        '
        Me.txtPeriodo.DisabledBackColor = System.Drawing.Color.White
        Me.txtPeriodo.FormatString = "#"
        Me.txtPeriodo.Location = New System.Drawing.Point(72, 22)
        Me.txtPeriodo.Name = "txtPeriodo"
        Me.txtPeriodo.NullBehavior = Janus.Windows.GridEX.NumericEditNullBehavior.AllowNull
        Me.txtPeriodo.Size = New System.Drawing.Size(76, 21)
        Me.txtPeriodo.TabIndex = 0
        '
        'cbxTipoPeriodo
        '
        cbxTipoPeriodo_DesignTimeLayout.LayoutString = resources.GetString("cbxTipoPeriodo_DesignTimeLayout.LayoutString")
        Me.cbxTipoPeriodo.DesignTimeLayout = cbxTipoPeriodo_DesignTimeLayout
        Me.cbxTipoPeriodo.DisabledBackColor = System.Drawing.Color.White
        Me.cbxTipoPeriodo.Location = New System.Drawing.Point(247, 22)
        Me.cbxTipoPeriodo.Name = "cbxTipoPeriodo"
        Me.cbxTipoPeriodo.SelectedIndex = -1
        Me.cbxTipoPeriodo.SelectedItem = Nothing
        Me.cbxTipoPeriodo.Size = New System.Drawing.Size(104, 21)
        Me.cbxTipoPeriodo.TabIndex = 1
        '
        'lblFechaFin
        '
        Me.lblFechaFin.Location = New System.Drawing.Point(203, 36)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(58, 13)
        Me.lblFechaFin.TabIndex = 247
        Me.lblFechaFin.Tag = ""
        Me.lblFechaFin.Text = "Fecha fin"
        '
        'cbxFechaFin
        '
        Me.cbxFechaFin.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaFin.Enabled = False
        Me.cbxFechaFin.Location = New System.Drawing.Point(267, 32)
        Me.cbxFechaFin.Name = "cbxFechaFin"
        Me.cbxFechaFin.Size = New System.Drawing.Size(95, 21)
        Me.cbxFechaFin.TabIndex = 246
        Me.cbxFechaFin.TabStop = False
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.Location = New System.Drawing.Point(7, 32)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.Size = New System.Drawing.Size(73, 13)
        Me.lblFechaInicio.TabIndex = 248
        Me.lblFechaInicio.Tag = ""
        Me.lblFechaInicio.Text = "Fecha inicio"
        '
        'cbxFechaInicio
        '
        Me.cbxFechaInicio.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaInicio.Enabled = False
        Me.cbxFechaInicio.Location = New System.Drawing.Point(80, 32)
        Me.cbxFechaInicio.Name = "cbxFechaInicio"
        Me.cbxFechaInicio.Size = New System.Drawing.Size(95, 21)
        Me.cbxFechaInicio.TabIndex = 245
        Me.cbxFechaInicio.TabStop = False
        '
        'frmGeneraPeriodosAvance
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(367, 227)
        Me.Controls.Add(Me.lblFechaFin)
        Me.Controls.Add(Me.cbxFechaFin)
        Me.Controls.Add(Me.lblFechaInicio)
        Me.Controls.Add(Me.cbxFechaInicio)
        Me.Controls.Add(Me.FraCriteriosConfig)
        Me.Controls.Add(Me.txtDescTrabajo)
        Me.Controls.Add(Me.txtCodTrabajo)
        Me.Controls.Add(Me.lblCodTrabajo)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmGeneraPeriodosAvance"
        Me.NavigationFields = ""
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generación de los períodos de avance"
        Me.Panel1.ResumeLayout(False)
        Me.FraCriteriosConfig.ResumeLayout(False)
        Me.FraCriteriosConfig.PerformLayout()
        Me.fraTipoAvance.ResumeLayout(False)
        Me.fraTipoAvance.PerformLayout()
        CType(Me.cbxTipoPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region " Load "

    Protected Overridable Sub frmGeneraPeriodosAvance_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadEnums()
    End Sub

    Protected Overridable Sub LoadEnums()
        cbxTipoPeriodo.DataSource = New EnumData("enumcpPeriodo")
    End Sub

#End Region

    Protected Overridable Sub CmbAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbAceptar.Click
        Me.DialogResult = DialogResult.None
        If Length(cbxTipoPeriodo.Value) = 0 OrElse Length(txtPeriodo.Text) = 0 OrElse Length(cbxFechaInicio.Value) = 0 OrElse Length(cbxFechaFin.Value) = 0 Then
            ExpertisApp.GenerateMessage("La Fecha Inicio, la Fecha Fin, el Periodo y el Tipo Periodo son datos obligatorios.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Me.DialogResult = DialogResult.OK
        End If
    End Sub

    'Private Sub optPorcPrevisto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAvancePrevisto.CheckedChanged
    '    lblPorcFijo.Visible = chkAvancePrevisto.Checked
    '    txtPorcFijo.Visible = chkAvancePrevisto.Checked
    'End Sub

End Class
