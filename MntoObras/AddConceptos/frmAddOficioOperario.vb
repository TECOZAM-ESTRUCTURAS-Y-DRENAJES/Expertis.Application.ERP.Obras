Public Class frmAddOficioOperario
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
    Friend WithEvents Panel2 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents ulDescOficio As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents ulDescOperario As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents advIDOficio As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents advIDOperario As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents txtDescTrabajo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents txtCodTrabajo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblCodTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblIDOperario As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblIDOficio As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblHorasPrev As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ntbHorasPrev As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents CmbNuevo As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmbCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents CmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents Panel3 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents lblTexto As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtTexto As Solmicro.Expertis.Engine.UI.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.Panel2 = New Solmicro.Expertis.Engine.UI.Panel
        Me.ulDescOficio = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.ulDescOperario = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.advIDOficio = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.advIDOperario = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.txtDescTrabajo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtCodTrabajo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblCodTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.lblIDOperario = New Solmicro.Expertis.Engine.UI.Label
        Me.lblIDOficio = New Solmicro.Expertis.Engine.UI.Label
        Me.lblHorasPrev = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbHorasPrev = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.CmbNuevo = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.CmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.Panel3 = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblTexto = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTexto = New Solmicro.Expertis.Engine.UI.TextBox
        Me.Panel1.suspendlayout()
        Me.Panel2.suspendlayout()
        Me.Panel3.suspendlayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CmbNuevo)
        Me.Panel1.Controls.Add(Me.cmbCancelar)
        Me.Panel1.Controls.Add(Me.CmbAceptar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 194)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(488, 42)
        Me.Panel1.TabIndex = 234
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ntbHorasPrev)
        Me.Panel2.Controls.Add(Me.ulDescOficio)
        Me.Panel2.Controls.Add(Me.ulDescOperario)
        Me.Panel2.Controls.Add(Me.advIDOficio)
        Me.Panel2.Controls.Add(Me.advIDOperario)
        Me.Panel2.Controls.Add(Me.txtDescTrabajo)
        Me.Panel2.Controls.Add(Me.txtCodTrabajo)
        Me.Panel2.Controls.Add(Me.lblCodTrabajo)
        Me.Panel2.Controls.Add(Me.lblIDOperario)
        Me.Panel2.Controls.Add(Me.lblIDOficio)
        Me.Panel2.Controls.Add(Me.lblHorasPrev)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(488, 105)
        Me.Panel2.TabIndex = 247
        '
        'ulDescOficio
        '
        Me.TryDataBinding(ulDescOficio, New System.Windows.Forms.Binding("Text", Me.advIDOficio, "DescOficio"))
        Me.ulDescOficio.Location = New System.Drawing.Point(220, 55)
        Me.ulDescOficio.Name = "ulDescOficio"
        Me.ulDescOficio.Size = New System.Drawing.Size(262, 21)
        Me.ulDescOficio.TabIndex = 255
        '
        'ulDescOperario
        '
        Me.TryDataBinding(ulDescOperario, New System.Windows.Forms.Binding("Text", Me, "DescOperario"))
        Me.ulDescOperario.Location = New System.Drawing.Point(220, 29)
        Me.ulDescOperario.Name = "ulDescOperario"
        Me.ulDescOperario.Size = New System.Drawing.Size(262, 21)
        Me.ulDescOperario.TabIndex = 254
        '
        'advIDOficio
        '
        Me.TryDataBinding(advIDOficio, New System.Windows.Forms.Binding("Text", Me, "IDOficio"))
        Me.advIDOficio.EntityName = "Oficio"
        Me.advIDOficio.Location = New System.Drawing.Point(97, 55)
        Me.advIDOficio.Name = "advIDOficio"
        Me.advIDOficio.PrimaryDataFields = "IDOficio"
        Me.advIDOficio.SecondaryDataFields = "IDOficio"
        Me.advIDOficio.Size = New System.Drawing.Size(119, 21)
        Me.advIDOficio.TabIndex = 248
        '
        'advIDOperario
        '
        Me.TryDataBinding(advIDOperario, New System.Windows.Forms.Binding("Text", Me, "IDOperario"))
        Me.advIDOperario.EntityName = "Operario"
        Me.advIDOperario.Location = New System.Drawing.Point(97, 29)
        Me.advIDOperario.Name = "advIDOperario"
        Me.advIDOperario.PrimaryDataFields = "IDOperario"
        Me.advIDOperario.SecondaryDataFields = "IDOperario"
        Me.advIDOperario.Size = New System.Drawing.Size(119, 21)
        Me.advIDOperario.TabIndex = 247
        '
        'txtDescTrabajo
        '
        Me.txtDescTrabajo.Enabled = False
        Me.txtDescTrabajo.Location = New System.Drawing.Point(220, 3)
        Me.txtDescTrabajo.Name = "txtDescTrabajo"
        Me.txtDescTrabajo.Size = New System.Drawing.Size(262, 21)
        Me.txtDescTrabajo.TabIndex = 251
        Me.txtDescTrabajo.TabStop = False
        '
        'txtCodTrabajo
        '
        Me.txtCodTrabajo.Enabled = False
        Me.txtCodTrabajo.Location = New System.Drawing.Point(97, 3)
        Me.txtCodTrabajo.Name = "txtCodTrabajo"
        Me.txtCodTrabajo.Size = New System.Drawing.Size(119, 21)
        Me.txtCodTrabajo.TabIndex = 250
        '
        'lblCodTrabajo
        '
        Me.lblCodTrabajo.Location = New System.Drawing.Point(7, 5)
        Me.lblCodTrabajo.Name = "lblCodTrabajo"
        Me.lblCodTrabajo.Size = New System.Drawing.Size(47, 17)
        Me.lblCodTrabajo.TabIndex = 249
        Me.lblCodTrabajo.Text = "Trabajo"
        '
        'lblIDOperario
        '
        Me.lblIDOperario.Location = New System.Drawing.Point(7, 29)
        Me.lblIDOperario.Name = "lblIDOperario"
        Me.lblIDOperario.Size = New System.Drawing.Size(53, 17)
        Me.lblIDOperario.TabIndex = 252
        Me.lblIDOperario.Text = "Operario"
        '
        'lblIDOficio
        '
        Me.lblIDOficio.Location = New System.Drawing.Point(7, 55)
        Me.lblIDOficio.Name = "lblIDOficio"
        Me.lblIDOficio.Size = New System.Drawing.Size(36, 17)
        Me.lblIDOficio.TabIndex = 253
        Me.lblIDOficio.Text = "Oficio"
        '
        'lblHorasPrev
        '
        Me.lblHorasPrev.Location = New System.Drawing.Point(7, 81)
        Me.lblHorasPrev.Name = "lblHorasPrev"
        Me.lblHorasPrev.Size = New System.Drawing.Size(70, 17)
        Me.lblHorasPrev.TabIndex = 256
        Me.lblHorasPrev.Text = "Horas Prev."
        '
        'ntbHorasPrev
        '
        Me.TryDataBinding(ntbHorasPrev, New System.Windows.Forms.Binding("Value", Me, "HorasPrev"))
        Me.ntbHorasPrev.Location = New System.Drawing.Point(97, 81)
        Me.ntbHorasPrev.Name = "ntbHorasPrev"
        Me.ntbHorasPrev.Size = New System.Drawing.Size(121, 21)
        Me.ntbHorasPrev.TabIndex = 257
        '
        'CmbNuevo
        '
        Me.CmbNuevo.Location = New System.Drawing.Point(97, 7)
        Me.CmbNuevo.Name = "CmbNuevo"
        Me.CmbNuevo.Size = New System.Drawing.Size(94, 29)
        Me.CmbNuevo.TabIndex = 21
        Me.CmbNuevo.Text = "Nuevo"
        '
        'cmbCancelar
        '
        Me.cmbCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmbCancelar.Location = New System.Drawing.Point(297, 7)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(94, 29)
        Me.cmbCancelar.TabIndex = 23
        Me.cmbCancelar.Text = "Cancelar"
        '
        'CmbAceptar
        '
        Me.CmbAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.CmbAceptar.Location = New System.Drawing.Point(197, 7)
        Me.CmbAceptar.Name = "CmbAceptar"
        Me.CmbAceptar.Size = New System.Drawing.Size(94, 29)
        Me.CmbAceptar.TabIndex = 22
        Me.CmbAceptar.Text = "Aceptar"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txtTexto)
        Me.Panel3.Controls.Add(Me.lblTexto)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 105)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(488, 89)
        Me.Panel3.TabIndex = 248
        '
        'lblTexto
        '
        Me.lblTexto.Location = New System.Drawing.Point(7, 5)
        Me.lblTexto.Name = "lblTexto"
        Me.lblTexto.Size = New System.Drawing.Size(87, 17)
        Me.lblTexto.TabIndex = 0
        Me.lblTexto.Text = "Observaciones"
        '
        'txtTexto
        '
        Me.txtTexto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TryDataBinding(txtTexto, New System.Windows.Forms.Binding("Text", Me, "Texto"))
        Me.txtTexto.Location = New System.Drawing.Point(97, 5)
        Me.txtTexto.Multiline = True
        Me.txtTexto.Name = "txtTexto"
        Me.txtTexto.Size = New System.Drawing.Size(385, 80)
        Me.txtTexto.TabIndex = 1
        '
        'frmAddOficioOperario
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(488, 236)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.EntityName = "ObraTrabajoOperario"
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmAddOficioOperario"
        Me.NavigationFields = "IDObra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta de Operarios / Oficios"
        Me.ViewName = "vFrmObrasTrabajoOperario"
        Me.WindowState = System.Windows.Forms.FormWindowState.Normal
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mdtOficioOperario As DataTable
    Private mintIDObra, mintIDTrabajo As Integer
    Private mblnCancel As Boolean

    Public Overrides ReadOnly Property RequeryRecords() As Engine.RequeryMode
        Get
            Return RequeryMode.ActiveRecord
        End Get
    End Property

#Region " Load "

    Public Function AbrirAltaOficioOperario(ByVal IDObra As Integer, ByVal IDTrabajo As Integer, _
                                            ByVal CodTrabajo As String, ByVal DescTrabajo As String) As DataTable

        txtCodTrabajo.Text = CodTrabajo
        txtDescTrabajo.Text = DescTrabajo
        mintIDObra = IDObra
        mintIDTrabajo = IDTrabajo

        Dim frm As New Form
        frm = Me
        frm.ShowDialog() 'Para que no traiga todos los registros

        If Me.DialogResult = DialogResult.OK Then Return mdtOficioOperario
        Return Nothing
    End Function

    Private Sub frmAddOficioOperario_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ADDNewMOD()
    End Sub

    Private Sub ADDNewMOD()
        Me.AddNew()

        Me.CurrentData.Rows(0)("IDObra") = mintIDObra
        Me.CurrentData.Rows(0)("IDTrabajo") = mintIDTrabajo
        Me.CurrentData.Rows(0)("CodTrabajo") = txtCodTrabajo.Text

        If IsNothing(mdtOficioOperario) Then mdtOficioOperario = CurrentData.Clone
    End Sub

#End Region

    Private Function ValidaDatosObligatorios() As Boolean
        If Length(txtCodTrabajo.Text) = 0 Then
            mblnCancel = True
            ExpertisApp.GenerateMessage("El Trabajo es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 'El Cod. Trabajo es un dato obligatorio.
        End If
        If Length(advIDOficio.Text) = 0 Then
            mblnCancel = True
            ExpertisApp.GenerateMessage("El Oficio es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Function

    Private Sub CmbNuevo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbNuevo.Click
        mblnCancel = ValidaDatosObligatorios()
        If Not mblnCancel Then
            mdtOficioOperario.Rows.Add(Me.CurrentData.Rows(0).ItemArray)
            ADDNewMOD()
        End If
    End Sub

    Private Sub CmbAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbAceptar.Click
        mblnCancel = ValidaDatosObligatorios()
        If Not mblnCancel Then
            Me.DialogResult = DialogResult.OK
            mdtOficioOperario.Rows.Add(Me.CurrentData.Rows(0).ItemArray)
            Me.Close()
        End If
    End Sub

    Private Sub cmbCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCancelar.Click
        mblnCancel = False
        Me.Close()
    End Sub

    Private Sub frmAddOficioOperario_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = mblnCancel
    End Sub

End Class
