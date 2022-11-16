Public Class frmContabilizar
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
    Friend WithEvents cmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmbCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents pnlFichero As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents chkGenerarFichero As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents Panel2 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents lblDescApunte As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblCContable As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFechaApunte As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblEjercicio As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblBancoPropio As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtDescApunte As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents txtCContable As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents cbxFechaApunte As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents ulDescEjercicio As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents cbxIDEjercicio As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents chkAgruparBanco As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents ulDescBancoPropio As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents cbxBancoPropio As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents chkCambiarAPagado As Solmicro.Expertis.Engine.UI.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim cbxIDEjercicio_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxBancoPropio_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmContabilizar))
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.pnlFichero = New Solmicro.Expertis.Engine.UI.Panel
        Me.chkGenerarFichero = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.Panel2 = New Solmicro.Expertis.Engine.UI.Panel
        Me.chkCambiarAPagado = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.lblDescApunte = New Solmicro.Expertis.Engine.UI.Label
        Me.lblCContable = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFechaApunte = New Solmicro.Expertis.Engine.UI.Label
        Me.lblEjercicio = New Solmicro.Expertis.Engine.UI.Label
        Me.lblBancoPropio = New Solmicro.Expertis.Engine.UI.Label
        Me.txtDescApunte = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtCContable = New Solmicro.Expertis.Engine.UI.TextBox
        Me.cbxFechaApunte = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.ulDescEjercicio = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.cbxIDEjercicio = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.chkAgruparBanco = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.ulDescBancoPropio = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.cbxBancoPropio = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.Panel1.suspendlayout()
        Me.pnlFichero.suspendlayout()
        Me.Panel2.suspendlayout()
        CType(Me.cbxIDEjercicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxBancoPropio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbAceptar)
        Me.Panel1.Controls.Add(Me.cmbCancelar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 202)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(433, 40)
        Me.Panel1.TabIndex = 67
        '
        'cmbAceptar
        '
        Me.cmbAceptar.Location = New System.Drawing.Point(124, 9)
        Me.cmbAceptar.Name = "cmbAceptar"
        Me.cmbAceptar.Size = New System.Drawing.Size(89, 25)
        Me.cmbAceptar.TabIndex = 20
        Me.cmbAceptar.Text = "Aceptar"
        '
        'cmbCancelar
        '
        Me.cmbCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmbCancelar.Location = New System.Drawing.Point(220, 9)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(89, 25)
        Me.cmbCancelar.TabIndex = 21
        Me.cmbCancelar.Text = "Cancelar"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.RestoreDirectory = True
        '
        'pnlFichero
        '
        Me.pnlFichero.Controls.Add(Me.chkGenerarFichero)
        Me.pnlFichero.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFichero.Location = New System.Drawing.Point(0, 173)
        Me.pnlFichero.Name = "pnlFichero"
        Me.pnlFichero.Size = New System.Drawing.Size(433, 29)
        Me.pnlFichero.TabIndex = 68
        '
        'chkGenerarFichero
        '
        Me.chkGenerarFichero.Location = New System.Drawing.Point(10, 1)
        Me.chkGenerarFichero.Name = "chkGenerarFichero"
        Me.chkGenerarFichero.Size = New System.Drawing.Size(259, 21)
        Me.chkGenerarFichero.TabIndex = 59
        Me.chkGenerarFichero.Text = "Generar Fichero Transferencia"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.chkCambiarAPagado)
        Me.Panel2.Controls.Add(Me.lblDescApunte)
        Me.Panel2.Controls.Add(Me.lblCContable)
        Me.Panel2.Controls.Add(Me.lblFechaApunte)
        Me.Panel2.Controls.Add(Me.lblEjercicio)
        Me.Panel2.Controls.Add(Me.lblBancoPropio)
        Me.Panel2.Controls.Add(Me.txtDescApunte)
        Me.Panel2.Controls.Add(Me.txtCContable)
        Me.Panel2.Controls.Add(Me.cbxFechaApunte)
        Me.Panel2.Controls.Add(Me.ulDescEjercicio)
        Me.Panel2.Controls.Add(Me.cbxIDEjercicio)
        Me.Panel2.Controls.Add(Me.chkAgruparBanco)
        Me.Panel2.Controls.Add(Me.ulDescBancoPropio)
        Me.Panel2.Controls.Add(Me.cbxBancoPropio)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(433, 173)
        Me.Panel2.TabIndex = 69
        '
        'chkCambiarAPagado
        '
        Me.chkCambiarAPagado.Location = New System.Drawing.Point(10, 124)
        Me.chkCambiarAPagado.Name = "chkCambiarAPagado"
        Me.chkCambiarAPagado.Size = New System.Drawing.Size(252, 21)
        Me.chkCambiarAPagado.TabIndex = 81
        Me.chkCambiarAPagado.Text = "Cambiar a Pagado"
        '
        'lblDescApunte
        '
        Me.lblDescApunte.Location = New System.Drawing.Point(10, 101)
        Me.lblDescApunte.Name = "lblDescApunte"
        Me.lblDescApunte.Size = New System.Drawing.Size(83, 13)
        Me.lblDescApunte.TabIndex = 74
        Me.lblDescApunte.Tag = ""
        Me.lblDescApunte.Text = "Desc. Apunte"
        '
        'lblCContable
        '
        Me.lblCContable.Location = New System.Drawing.Point(10, 76)
        Me.lblCContable.Name = "lblCContable"
        Me.lblCContable.Size = New System.Drawing.Size(75, 13)
        Me.lblCContable.TabIndex = 75
        Me.lblCContable.Tag = ""
        Me.lblCContable.Text = "C. Contable"
        '
        'lblFechaApunte
        '
        Me.lblFechaApunte.Location = New System.Drawing.Point(10, 4)
        Me.lblFechaApunte.Name = "lblFechaApunte"
        Me.lblFechaApunte.Size = New System.Drawing.Size(84, 13)
        Me.lblFechaApunte.TabIndex = 76
        Me.lblFechaApunte.Tag = "IdRec=4771;"
        Me.lblFechaApunte.Text = "Fecha Apunte"
        '
        'lblEjercicio
        '
        Me.lblEjercicio.Location = New System.Drawing.Point(10, 28)
        Me.lblEjercicio.Name = "lblEjercicio"
        Me.lblEjercicio.Size = New System.Drawing.Size(55, 13)
        Me.lblEjercicio.TabIndex = 77
        Me.lblEjercicio.Tag = "IdRec=6583;"
        Me.lblEjercicio.Text = "Ejercicio"
        '
        'lblBancoPropio
        '
        Me.lblBancoPropio.Location = New System.Drawing.Point(10, 52)
        Me.lblBancoPropio.Name = "lblBancoPropio"
        Me.lblBancoPropio.Size = New System.Drawing.Size(82, 13)
        Me.lblBancoPropio.TabIndex = 79
        Me.lblBancoPropio.Tag = "IdRec=4613;"
        Me.lblBancoPropio.Text = "Banco Propio"
        '
        'txtDescApunte
        '
        Me.txtDescApunte.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescApunte.Location = New System.Drawing.Point(95, 101)
        Me.txtDescApunte.Name = "txtDescApunte"
        Me.txtDescApunte.Size = New System.Drawing.Size(331, 21)
        Me.txtDescApunte.TabIndex = 72
        '
        'txtCContable
        '
        Me.TryDataBinding(txtCContable, New System.Windows.Forms.Binding("Text", Me.cbxBancoPropio, "CContable", True))
        Me.txtCContable.DisabledBackColor = System.Drawing.Color.White
        Me.txtCContable.Enabled = False
        Me.txtCContable.Location = New System.Drawing.Point(95, 76)
        Me.txtCContable.Name = "txtCContable"
        Me.txtCContable.Size = New System.Drawing.Size(104, 21)
        Me.txtCContable.TabIndex = 70
        '
        'cbxFechaApunte
        '
        Me.cbxFechaApunte.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaApunte.Location = New System.Drawing.Point(95, 4)
        Me.cbxFechaApunte.Name = "cbxFechaApunte"
        Me.cbxFechaApunte.Size = New System.Drawing.Size(104, 21)
        Me.cbxFechaApunte.TabIndex = 67
        '
        'ulDescEjercicio
        '
        Me.TryDataBinding(ulDescEjercicio, New System.Windows.Forms.Binding("Text", Me.cbxIDEjercicio, "DescEjercicio", True))
        Me.ulDescEjercicio.Location = New System.Drawing.Point(202, 28)
        Me.ulDescEjercicio.Name = "ulDescEjercicio"
        Me.ulDescEjercicio.Size = New System.Drawing.Size(224, 21)
        Me.ulDescEjercicio.TabIndex = 78
        '
        'cbxIDEjercicio
        '
        cbxIDEjercicio_DesignTimeLayout.LayoutString = resources.GetString("cbxIDEjercicio_DesignTimeLayout.LayoutString")
        Me.cbxIDEjercicio.DesignTimeLayout = cbxIDEjercicio_DesignTimeLayout
        Me.cbxIDEjercicio.DisabledBackColor = System.Drawing.Color.White
        Me.cbxIDEjercicio.DisplayMember = "IDEjercicio"
        Me.cbxIDEjercicio.Enabled = False
        Me.cbxIDEjercicio.EntityName = "EjercicioContable"
        Me.cbxIDEjercicio.Location = New System.Drawing.Point(95, 28)
        Me.cbxIDEjercicio.Name = "cbxIDEjercicio"
        Me.cbxIDEjercicio.SecondaryDataFields = "IDEjercicio"
        Me.cbxIDEjercicio.SelectedIndex = -1
        Me.cbxIDEjercicio.SelectedItem = Nothing
        Me.cbxIDEjercicio.Size = New System.Drawing.Size(104, 21)
        Me.cbxIDEjercicio.TabIndex = 68
        Me.cbxIDEjercicio.ValueMember = "IDEjercicio"
        Me.cbxIDEjercicio.ViewName = "tbMaestroEjercicio"
        '
        'chkAgruparBanco
        '
        Me.chkAgruparBanco.Location = New System.Drawing.Point(10, 148)
        Me.chkAgruparBanco.Name = "chkAgruparBanco"
        Me.chkAgruparBanco.Size = New System.Drawing.Size(252, 21)
        Me.chkAgruparBanco.TabIndex = 73
        Me.chkAgruparBanco.Text = "Agrupar apunte de Banco"
        '
        'ulDescBancoPropio
        '
        Me.TryDataBinding(ulDescBancoPropio, New System.Windows.Forms.Binding("Text", Me.cbxBancoPropio, "DescBancoPropio", True))
        Me.ulDescBancoPropio.Location = New System.Drawing.Point(202, 52)
        Me.ulDescBancoPropio.Name = "ulDescBancoPropio"
        Me.ulDescBancoPropio.Size = New System.Drawing.Size(224, 21)
        Me.ulDescBancoPropio.TabIndex = 80
        '
        'cbxBancoPropio
        '
        cbxBancoPropio_DesignTimeLayout.LayoutString = resources.GetString("cbxBancoPropio_DesignTimeLayout.LayoutString")
        Me.cbxBancoPropio.DesignTimeLayout = cbxBancoPropio_DesignTimeLayout
        Me.cbxBancoPropio.DisabledBackColor = System.Drawing.Color.White
        Me.cbxBancoPropio.DisplayMember = "IDBancoPropio"
        Me.cbxBancoPropio.EntityName = "BancoPropio"
        Me.cbxBancoPropio.Location = New System.Drawing.Point(95, 52)
        Me.cbxBancoPropio.Name = "cbxBancoPropio"
        Me.cbxBancoPropio.PrimaryDataFields = "IDBancoPropio"
        Me.cbxBancoPropio.SecondaryDataFields = "IDBancoPropio"
        Me.cbxBancoPropio.SelectedIndex = -1
        Me.cbxBancoPropio.SelectedItem = Nothing
        Me.cbxBancoPropio.Size = New System.Drawing.Size(104, 21)
        Me.cbxBancoPropio.TabIndex = 69
        Me.cbxBancoPropio.ValueMember = "IDBancoPropio"
        Me.cbxBancoPropio.ViewName = "tbMaestroBancoPropio"
        '
        'frmContabilizar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(433, 242)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pnlFichero)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.Name = "frmContabilizar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contabilización"
        Me.Panel1.ResumeLayout(False)
        Me.pnlFichero.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.cbxIDEjercicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxBancoPropio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Load "

    Public Function AbrirContabilizacion(ByRef dtFechaApunte As Date, ByRef strIdBPropio As String, _
                                         ByRef intNuevaSituacion As Integer, ByRef strEjercicio As String, _
                                         ByRef blnAgruparBanco As Boolean, ByRef strDescApunte As String, _
                                         ByVal intTipo As enumTipoLiquidacion) As DialogResult

        If intTipo = ObrasGeneral.enumTipoLiquidacion.enumTlVarios Then pnlFichero.Visible = False
        Me.ShowDialog()

        dtFechaApunte = cbxFechaApunte.Value
        strEjercicio = cbxIDEjercicio.Value
        strIdBPropio = cbxBancoPropio.Value

        blnAgruparBanco = chkAgruparBanco.Checked
        intNuevaSituacion = IIf(chkCambiarAPagado.Checked, 1, 0)
        strDescApunte = txtDescApunte.Text

        Return Me.DialogResult
    End Function

    Private Sub frmContabilizar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadDefaultValues()
        LoadERPSettings()
    End Sub

    Private Sub LoadERPSettings()
        cbxFechaApunte_Validated(cbxFechaApunte, New EventArgs)
    End Sub

    Private Sub LoadDefaultValues()
        chkAgruparBanco.Checked = True
        cbxFechaApunte.Value = Date.Today
        chkCambiarAPagado.Checked = True
    End Sub

    Private Sub cbxFechaApunte_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxFechaApunte.Validated
        If Length(cbxFechaApunte.Value) > 0 Then
            cbxIDEjercicio.Value = ExpertisApp.ExecuteTask(Of Date, String)(AddressOf EjercicioContable.Predeterminado, cbxFechaApunte.Value)
        Else
            cbxIDEjercicio.Value = System.DBNull.Value
        End If
    End Sub

#End Region

#Region " Aceptar/Cancelar "

    Private Function ValidarOpciones() As Boolean
        Dim blnCancel As Boolean
        If Length(cbxIDEjercicio.Value) = 0 Then
            blnCancel = True
            ExpertisApp.GenerateMessage("Debe introducir un Ejercicio Contable.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Length(Me.cbxFechaApunte.Value) = 0 Then
            blnCancel = True
            ExpertisApp.GenerateMessage("Debe introducir una Fecha de Apunte.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Length(cbxBancoPropio.Value) = 0 Then
            blnCancel = True
            ExpertisApp.GenerateMessage("El Banco Propio es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        Return blnCancel
    End Function

    Private Sub cmbAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAceptar.Click
        Me.DialogResult = Windows.Forms.DialogResult.None
        If Not ValidarOpciones() Then
            Me.DialogResult = DialogResult.OK
        End If
    End Sub

#End Region

End Class
