Public Class frmRehacerPeriodosAvance
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
    Public WithEvents cmbCancelar As Solmicro.Expertis.Engine.UI.Button
    Public WithEvents CmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Public WithEvents FraRespecto As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents optRespectoProduccion As Solmicro.Expertis.Engine.UI.RadioButton
    Public WithEvents fraTratarDiferencias As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents lblPeriodo As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtPeriodo As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents optCrearPeriodo As Solmicro.Expertis.Engine.UI.RadioButton
    Public WithEvents optRepartir As Solmicro.Expertis.Engine.UI.RadioButton
    Public WithEvents optIndicarPeriodo As Solmicro.Expertis.Engine.UI.RadioButton
    Public WithEvents optRespectoCliente As Solmicro.Expertis.Engine.UI.RadioButton

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.CmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.FraRespecto = New Solmicro.Expertis.Engine.UI.Frame
        Me.optRespectoProduccion = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.optRespectoCliente = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.fraTratarDiferencias = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblPeriodo = New Solmicro.Expertis.Engine.UI.Label
        Me.txtPeriodo = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.optCrearPeriodo = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.optRepartir = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.optIndicarPeriodo = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.Panel1.suspendlayout()
        Me.FraRespecto.SuspendLayout()
        Me.fraTratarDiferencias.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbCancelar)
        Me.Panel1.Controls.Add(Me.CmbAceptar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 193)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(328, 42)
        Me.Panel1.TabIndex = 2
        '
        'cmbCancelar
        '
        Me.cmbCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmbCancelar.Location = New System.Drawing.Point(169, 7)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(94, 29)
        Me.cmbCancelar.TabIndex = 1
        Me.cmbCancelar.Text = "Cancelar"
        '
        'CmbAceptar
        '
        Me.CmbAceptar.Location = New System.Drawing.Point(65, 7)
        Me.CmbAceptar.Name = "CmbAceptar"
        Me.CmbAceptar.Size = New System.Drawing.Size(94, 29)
        Me.CmbAceptar.TabIndex = 0
        Me.CmbAceptar.Text = "Aceptar"
        '
        'FraRespecto
        '
        Me.FraRespecto.Controls.Add(Me.optRespectoProduccion)
        Me.FraRespecto.Controls.Add(Me.optRespectoCliente)
        Me.FraRespecto.Dock = System.Windows.Forms.DockStyle.Top
        Me.FraRespecto.Location = New System.Drawing.Point(0, 0)
        Me.FraRespecto.Name = "FraRespecto"
        Me.FraRespecto.Size = New System.Drawing.Size(328, 72)
        Me.FraRespecto.TabIndex = 0
        Me.FraRespecto.TabStop = False
        Me.FraRespecto.Text = "Calcular diferencia"
        '
        'optRespectoProduccion
        '
        Me.optRespectoProduccion.Location = New System.Drawing.Point(18, 40)
        Me.optRespectoProduccion.Name = "optRespectoProduccion"
        Me.optRespectoProduccion.Size = New System.Drawing.Size(286, 23)
        Me.optRespectoProduccion.TabIndex = 1
        Me.optRespectoProduccion.Text = "Respecto a Producción"
        '
        'optRespectoCliente
        '
        Me.optRespectoCliente.Checked = True
        Me.optRespectoCliente.Location = New System.Drawing.Point(18, 16)
        Me.optRespectoCliente.Name = "optRespectoCliente"
        Me.optRespectoCliente.Size = New System.Drawing.Size(286, 23)
        Me.optRespectoCliente.TabIndex = 0
        Me.optRespectoCliente.TabStop = True
        Me.optRespectoCliente.Text = "Respecto a Cliente"
        '
        'fraTratarDiferencias
        '
        Me.fraTratarDiferencias.Controls.Add(Me.lblPeriodo)
        Me.fraTratarDiferencias.Controls.Add(Me.txtPeriodo)
        Me.fraTratarDiferencias.Controls.Add(Me.optCrearPeriodo)
        Me.fraTratarDiferencias.Controls.Add(Me.optRepartir)
        Me.fraTratarDiferencias.Controls.Add(Me.optIndicarPeriodo)
        Me.fraTratarDiferencias.Dock = System.Windows.Forms.DockStyle.Top
        Me.fraTratarDiferencias.Location = New System.Drawing.Point(0, 72)
        Me.fraTratarDiferencias.Name = "fraTratarDiferencias"
        Me.fraTratarDiferencias.Size = New System.Drawing.Size(328, 120)
        Me.fraTratarDiferencias.TabIndex = 1
        Me.fraTratarDiferencias.TabStop = False
        Me.fraTratarDiferencias.Text = "Tratar diferencias respecto al previsto"
        '
        'lblPeriodo
        '
        Me.lblPeriodo.Location = New System.Drawing.Point(40, 43)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(50, 13)
        Me.lblPeriodo.TabIndex = 248
        Me.lblPeriodo.Text = "Periodo"
        '
        'txtPeriodo
        '
        Me.txtPeriodo.DisabledBackColor = System.Drawing.Color.White
        Me.txtPeriodo.FormatString = "#"
        Me.txtPeriodo.Location = New System.Drawing.Point(96, 42)
        Me.txtPeriodo.Name = "txtPeriodo"
        Me.txtPeriodo.NullBehavior = Janus.Windows.GridEX.NumericEditNullBehavior.AllowNull
        Me.txtPeriodo.Size = New System.Drawing.Size(76, 21)
        Me.txtPeriodo.TabIndex = 1
        '
        'optCrearPeriodo
        '
        Me.optCrearPeriodo.Location = New System.Drawing.Point(18, 90)
        Me.optCrearPeriodo.Name = "optCrearPeriodo"
        Me.optCrearPeriodo.Size = New System.Drawing.Size(286, 23)
        Me.optCrearPeriodo.TabIndex = 3
        Me.optCrearPeriodo.Text = "Crear un nuevo periodo con las diferencias"
        '
        'optRepartir
        '
        Me.optRepartir.Location = New System.Drawing.Point(18, 66)
        Me.optRepartir.Name = "optRepartir"
        Me.optRepartir.Size = New System.Drawing.Size(286, 23)
        Me.optRepartir.TabIndex = 2
        Me.optRepartir.Text = "Repartir diferencias en los siguientes periodos"
        '
        'optIndicarPeriodo
        '
        Me.optIndicarPeriodo.Checked = True
        Me.optIndicarPeriodo.Location = New System.Drawing.Point(18, 16)
        Me.optIndicarPeriodo.Name = "optIndicarPeriodo"
        Me.optIndicarPeriodo.Size = New System.Drawing.Size(246, 23)
        Me.optIndicarPeriodo.TabIndex = 0
        Me.optIndicarPeriodo.TabStop = True
        Me.optIndicarPeriodo.Text = "Llevar diferencias al siguiente periodo"
        '
        'frmRehacerPeriodosAvance
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(328, 235)
        Me.Controls.Add(Me.fraTratarDiferencias)
        Me.Controls.Add(Me.FraRespecto)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmRehacerPeriodosAvance"
        Me.Text = "Rehacer Periodos"
        Me.Panel1.ResumeLayout(False)
        Me.FraRespecto.ResumeLayout(False)
        Me.fraTratarDiferencias.ResumeLayout(False)
        Me.fraTratarDiferencias.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Protected mUltimoPeriodoCerrado As Integer
    Public WriteOnly Property UltimoPeriodoCerrado() As Integer
        Set(ByVal value As Integer)
            mUltimoPeriodoCerrado = value
        End Set
    End Property

    Public ReadOnly Property AccionSeleccionada() As AvanceTrabajo.dataRehacerPeriodos.enumRehacerPeriodos
        Get
            If optIndicarPeriodo.Checked Then
                Return AvanceTrabajo.dataRehacerPeriodos.enumRehacerPeriodos.IndicarPeriodo
            ElseIf optCrearPeriodo.Checked Then
                Return AvanceTrabajo.dataRehacerPeriodos.enumRehacerPeriodos.CrearNuevoPeriodo
            Else
                Return AvanceTrabajo.dataRehacerPeriodos.enumRehacerPeriodos.RepartirDiferencias
            End If
        End Get
    End Property

    Public ReadOnly Property CalcularRespecto() As AvanceTrabajo.dataRehacerPeriodos.enumCalcularDiferencia
        Get
            If optRespectoCliente.Checked Then
                Return AvanceTrabajo.dataRehacerPeriodos.enumCalcularDiferencia.PorCliente
            ElseIf optRespectoProduccion.Checked Then
                Return AvanceTrabajo.dataRehacerPeriodos.enumCalcularDiferencia.PorProduccion
            End If
        End Get
    End Property

    Protected Overridable Sub options_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optIndicarPeriodo.CheckedChanged
        txtPeriodo.Enabled = optIndicarPeriodo.Checked
    End Sub

    Protected Overridable Sub CmbAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbAceptar.Click
        Me.DialogResult = Windows.Forms.DialogResult.None
        If optIndicarPeriodo.Checked Then
            If Length(txtPeriodo.Text) = 0 Then
                ExpertisApp.GenerateMessage("Debe de indicar el Periodo donde llevar las diferencias.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        Else
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Protected Overridable Sub txtPeriodo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPeriodo.Validating
        If txtPeriodo.Text > 0 Then
            If txtPeriodo.Text <= mUltimoPeriodoCerrado Then
                e.Cancel = True
                ExpertisApp.GenerateMessage("El primer Periodo no cerrado es el {0}.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, mUltimoPeriodoCerrado + 1)
            End If
        End If
    End Sub

End Class
