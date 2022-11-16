Public Class frmAddVarios
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
    Public WithEvents txtDescTrabajo As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents txtCodTrabajo As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblCodTrabajo As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents ntbMargenPrev As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblMargenPrev As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblIDVarios As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents ntbImpPrevVariosVentaA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents ntbImpPrevVariosA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblImpPrevVariosA As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblImpPrevVariosVentaA As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents advIDVarios As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents txtDescVarios As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents chbAplicarQ As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents chbFacturable As Solmicro.Expertis.Engine.UI.CheckBox

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.CmbNuevo = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.CmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.advIDVarios = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.txtDescVarios = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtDescTrabajo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtCodTrabajo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblCodTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.lblIDVarios = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbImpPrevVariosVentaA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.ntbMargenPrev = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.ntbImpPrevVariosA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblImpPrevVariosA = New Solmicro.Expertis.Engine.UI.Label
        Me.lblMargenPrev = New Solmicro.Expertis.Engine.UI.Label
        Me.lblImpPrevVariosVentaA = New Solmicro.Expertis.Engine.UI.Label
        Me.chbAplicarQ = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chbFacturable = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.Panel1.suspendlayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CmbNuevo)
        Me.Panel1.Controls.Add(Me.cmbCancelar)
        Me.Panel1.Controls.Add(Me.CmbAceptar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 118)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(541, 42)
        Me.Panel1.TabIndex = 235
        '
        'CmbNuevo
        '
        Me.CmbNuevo.Location = New System.Drawing.Point(122, 7)
        Me.CmbNuevo.Name = "CmbNuevo"
        Me.CmbNuevo.Size = New System.Drawing.Size(94, 29)
        Me.CmbNuevo.TabIndex = 7
        Me.CmbNuevo.Text = "Nuevo"
        '
        'cmbCancelar
        '
        Me.cmbCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmbCancelar.Location = New System.Drawing.Point(322, 7)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(94, 29)
        Me.cmbCancelar.TabIndex = 9
        Me.cmbCancelar.Text = "Cancelar"
        '
        'CmbAceptar
        '
        Me.CmbAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.CmbAceptar.Location = New System.Drawing.Point(222, 7)
        Me.CmbAceptar.Name = "CmbAceptar"
        Me.CmbAceptar.Size = New System.Drawing.Size(94, 29)
        Me.CmbAceptar.TabIndex = 8
        Me.CmbAceptar.Text = "Aceptar"
        '
        'advIDVarios
        '
        Me.TryDataBinding(advIDVarios, New System.Windows.Forms.Binding("Text", Me, "IDVarios"))
        Me.advIDVarios.EntityName = "Varios"
        Me.advIDVarios.Location = New System.Drawing.Point(71, 34)
        Me.advIDVarios.Name = "advIDVarios"
        Me.advIDVarios.PrimaryDataFields = "IDVarios"
        Me.advIDVarios.SecondaryDataFields = "IDVarios"
        Me.advIDVarios.Size = New System.Drawing.Size(119, 23)
        Me.advIDVarios.TabIndex = 0
        '
        'txtDescVarios
        '
        Me.TryDataBinding(txtDescVarios, New System.Windows.Forms.Binding("Text", Me, "DescVarios"))
        Me.txtDescVarios.Location = New System.Drawing.Point(195, 34)
        Me.txtDescVarios.Name = "txtDescVarios"
        Me.txtDescVarios.Size = New System.Drawing.Size(342, 21)
        Me.txtDescVarios.TabIndex = 1
        '
        'txtDescTrabajo
        '
        Me.txtDescTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescTrabajo.Enabled = False
        Me.txtDescTrabajo.Location = New System.Drawing.Point(195, 8)
        Me.txtDescTrabajo.Name = "txtDescTrabajo"
        Me.txtDescTrabajo.Size = New System.Drawing.Size(342, 21)
        Me.txtDescTrabajo.TabIndex = 239
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
        Me.lblCodTrabajo.Location = New System.Drawing.Point(4, 8)
        Me.lblCodTrabajo.Name = "lblCodTrabajo"
        Me.lblCodTrabajo.Size = New System.Drawing.Size(50, 13)
        Me.lblCodTrabajo.TabIndex = 238
        Me.lblCodTrabajo.Text = "Trabajo"
        '
        'lblIDVarios
        '
        Me.lblIDVarios.Location = New System.Drawing.Point(4, 36)
        Me.lblIDVarios.Name = "lblIDVarios"
        Me.lblIDVarios.Size = New System.Drawing.Size(42, 13)
        Me.lblIDVarios.TabIndex = 243
        Me.lblIDVarios.Text = "Varios"
        '
        'ntbImpPrevVariosVentaA
        '
        Me.TryDataBinding(ntbImpPrevVariosVentaA, New System.Windows.Forms.Binding("Value", Me, "ImpPrevVariosVentaA"))
        Me.ntbImpPrevVariosVentaA.Location = New System.Drawing.Point(416, 90)
        Me.ntbImpPrevVariosVentaA.Name = "ntbImpPrevVariosVentaA"
        Me.ntbImpPrevVariosVentaA.Size = New System.Drawing.Size(121, 21)
        Me.ntbImpPrevVariosVentaA.TabIndex = 6
        '
        'ntbMargenPrev
        '
        Me.TryDataBinding(ntbMargenPrev, New System.Windows.Forms.Binding("Value", Me, "MargenPrev"))
        Me.ntbMargenPrev.Location = New System.Drawing.Point(260, 90)
        Me.ntbMargenPrev.Name = "ntbMargenPrev"
        Me.ntbMargenPrev.Size = New System.Drawing.Size(61, 21)
        Me.ntbMargenPrev.TabIndex = 5
        '
        'ntbImpPrevVariosA
        '
        Me.TryDataBinding(ntbImpPrevVariosA, New System.Windows.Forms.Binding("Value", Me, "ImpPrevVariosA"))
        Me.ntbImpPrevVariosA.Location = New System.Drawing.Point(71, 90)
        Me.ntbImpPrevVariosA.Name = "ntbImpPrevVariosA"
        Me.ntbImpPrevVariosA.Size = New System.Drawing.Size(121, 21)
        Me.ntbImpPrevVariosA.TabIndex = 4
        '
        'lblImpPrevVariosA
        '
        Me.lblImpPrevVariosA.Location = New System.Drawing.Point(4, 90)
        Me.lblImpPrevVariosA.Name = "lblImpPrevVariosA"
        Me.lblImpPrevVariosA.Size = New System.Drawing.Size(67, 13)
        Me.lblImpPrevVariosA.TabIndex = 245
        Me.lblImpPrevVariosA.Text = "Imp. Prev."
        '
        'lblMargenPrev
        '
        Me.lblMargenPrev.Location = New System.Drawing.Point(207, 90)
        Me.lblMargenPrev.Name = "lblMargenPrev"
        Me.lblMargenPrev.Size = New System.Drawing.Size(49, 13)
        Me.lblMargenPrev.TabIndex = 247
        Me.lblMargenPrev.Text = "Margen"
        '
        'lblImpPrevVariosVentaA
        '
        Me.lblImpPrevVariosVentaA.Location = New System.Drawing.Point(339, 90)
        Me.lblImpPrevVariosVentaA.Name = "lblImpPrevVariosVentaA"
        Me.lblImpPrevVariosVentaA.Size = New System.Drawing.Size(70, 13)
        Me.lblImpPrevVariosVentaA.TabIndex = 248
        Me.lblImpPrevVariosVentaA.Text = "Imp. Venta"
        '
        'chbAplicarQ
        '
        Me.TryDataBinding(chbAplicarQ, New System.Windows.Forms.Binding("BindableValue", Me, "AplicarQ"))
        Me.chbAplicarQ.Location = New System.Drawing.Point(4, 60)
        Me.chbAplicarQ.Name = "chbAplicarQ"
        Me.chbAplicarQ.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chbAplicarQ.Size = New System.Drawing.Size(82, 23)
        Me.chbAplicarQ.TabIndex = 2
        Me.chbAplicarQ.Text = "Aplicar Cantidad"
        Me.chbAplicarQ.TextAlignment = Janus.Windows.EditControls.TextAlignment.Far
        '
        'chbFacturable
        '
        Me.TryDataBinding(chbFacturable, New System.Windows.Forms.Binding("BindableValue", Me, "Facturable"))
        Me.chbFacturable.Location = New System.Drawing.Point(439, 60)
        Me.chbFacturable.Name = "chbFacturable"
        Me.chbFacturable.Size = New System.Drawing.Size(93, 23)
        Me.chbFacturable.TabIndex = 3
        Me.chbFacturable.Text = "Facturable"
        '
        'frmAddVarios
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(541, 160)
        Me.Controls.Add(Me.chbFacturable)
        Me.Controls.Add(Me.chbAplicarQ)
        Me.Controls.Add(Me.ntbImpPrevVariosVentaA)
        Me.Controls.Add(Me.ntbMargenPrev)
        Me.Controls.Add(Me.ntbImpPrevVariosA)
        Me.Controls.Add(Me.lblImpPrevVariosA)
        Me.Controls.Add(Me.lblMargenPrev)
        Me.Controls.Add(Me.lblImpPrevVariosVentaA)
        Me.Controls.Add(Me.lblCodTrabajo)
        Me.Controls.Add(Me.lblIDVarios)
        Me.Controls.Add(Me.advIDVarios)
        Me.Controls.Add(Me.txtDescVarios)
        Me.Controls.Add(Me.txtDescTrabajo)
        Me.Controls.Add(Me.txtCodTrabajo)
        Me.Controls.Add(Me.Panel1)
        Me.EntityName = "ObraVarios"
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmAddVarios"
        Me.NavigationFields = "IDObra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta de Varios"
        Me.ViewName = "VFrmObraVarios"
        Me.WindowState = System.Windows.Forms.FormWindowState.Normal
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Protected mdtVarios As DataTable
    Protected mintIDObra, mintIDTrabajo As Integer
    Protected mblnCancel, mblnFacturable As Boolean

    Public Overrides ReadOnly Property RequeryRecords() As Engine.RequeryMode
        Get
            Return RequeryMode.ActiveRecord
        End Get
    End Property

#Region " Load "

    Public Function AbrirAltaVarios(ByVal IDObra As Integer, ByVal IDTrabajo As Integer, ByVal CodTrabajo As String, _
                                    ByVal DescTrabajo As String, ByVal blnFacturable As Boolean) As DataTable

        txtCodTrabajo.Text = CodTrabajo
        txtDescTrabajo.Text = DescTrabajo
        mintIDObra = IDObra
        mintIDTrabajo = IDTrabajo
        mblnFacturable = blnFacturable

        Dim frm As New Form
        frm = Me
        frm.ShowDialog() 'Para que no traiga todos los registros

        If Me.DialogResult = DialogResult.OK Then Return mdtVarios
        Return Nothing
    End Function

    Protected Overridable Sub frmAddVarios_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ADDNewVarios()
    End Sub

    Protected Overridable Sub ADDNewVarios()
        Me.AddNew()

        Me.CurrentData.Rows(0)("IDObra") = mintIDObra
        Me.CurrentData.Rows(0)("IDTrabajo") = mintIDTrabajo
        Me.CurrentData.Rows(0)("CodTrabajo") = txtCodTrabajo.Text
        Me.CurrentData.Rows(0)("AplicarQ") = False
        Me.CurrentData.Rows(0)("Facturable") = mblnFacturable

        If IsNothing(mdtVarios) Then mdtVarios = CurrentData.Clone
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
            mdtVarios.Rows.Add(Me.CurrentData.Rows(0).ItemArray)
            ADDNewVarios()
        End If
    End Sub

    Protected Overridable Sub CmbAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbAceptar.Click
        mblnCancel = ValidaDatosObligatorios()
        If Not mblnCancel Then
            Me.DialogResult = DialogResult.OK
            mdtVarios.Rows.Add(Me.CurrentData.Rows(0).ItemArray)
            Me.RecordsState = UI.RecordsState.Saved
            Me.Close()
        End If
    End Sub

    Protected Overridable Sub cmbCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCancelar.Click
        mblnCancel = False
        Me.RecordsState = UI.RecordsState.Saved
        Me.Close()
    End Sub

    Protected Overridable Sub frmAddVarios_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = mblnCancel
    End Sub

End Class
