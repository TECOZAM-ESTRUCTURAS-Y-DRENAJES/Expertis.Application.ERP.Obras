Imports System.Threading

Public Class frmAddCertificacion
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
    Friend WithEvents txtDescCertificacion As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents txtNCertificacion As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblEstado As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblDescripcion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Panel2 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents cmbCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents CmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cbxEstado As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents cbxFechaCreacion As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaCreacion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblNCertificacion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxTipo As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblTipoCertificacion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblClienteProveedor As Solmicro.Expertis.Engine.UI.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim cbxEstado_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxTipo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddCertificacion))
        Me.txtDescCertificacion = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtNCertificacion = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblEstado = New Solmicro.Expertis.Engine.UI.Label
        Me.lblDescripcion = New Solmicro.Expertis.Engine.UI.Label
        Me.Panel2 = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.CmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.cbxEstado = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.cbxFechaCreacion = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaCreacion = New Solmicro.Expertis.Engine.UI.Label
        Me.lblNCertificacion = New Solmicro.Expertis.Engine.UI.Label
        Me.lblTipoCertificacion = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxTipo = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblClienteProveedor = New Solmicro.Expertis.Engine.UI.Label
        Me.Panel2.suspendlayout()
        CType(Me.cbxEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxTipo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDescCertificacion
        '
        Me.TryDataBinding(txtDescCertificacion, New System.Windows.Forms.Binding("Text", Me, "DescCertificacion", True))
        Me.txtDescCertificacion.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescCertificacion.Location = New System.Drawing.Point(111, 34)
        Me.txtDescCertificacion.Multiline = True
        Me.txtDescCertificacion.Name = "txtDescCertificacion"
        Me.txtDescCertificacion.Size = New System.Drawing.Size(245, 58)
        Me.txtDescCertificacion.TabIndex = 1
        '
        'txtNCertificacion
        '
        Me.TryDataBinding(txtNCertificacion, New System.Windows.Forms.Binding("Text", Me, "NCertificacion", True))
        Me.txtNCertificacion.DisabledBackColor = System.Drawing.Color.White
        Me.txtNCertificacion.Enabled = False
        Me.txtNCertificacion.Location = New System.Drawing.Point(111, 9)
        Me.txtNCertificacion.Name = "txtNCertificacion"
        Me.txtNCertificacion.Size = New System.Drawing.Size(138, 21)
        Me.txtNCertificacion.TabIndex = 0
        Me.txtNCertificacion.TabStop = False
        Me.txtNCertificacion.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        '
        'lblEstado
        '
        Me.lblEstado.Location = New System.Drawing.Point(4, 124)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(45, 13)
        Me.lblEstado.TabIndex = 238
        Me.lblEstado.Text = "Estado"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Location = New System.Drawing.Point(4, 34)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(73, 13)
        Me.lblDescripcion.TabIndex = 234
        Me.lblDescripcion.Text = "Descripción"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cmbCancelar)
        Me.Panel2.Controls.Add(Me.CmbAceptar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(0, 174)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(360, 45)
        Me.Panel2.TabIndex = 240
        '
        'cmbCancelar
        '
        Me.cmbCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmbCancelar.Location = New System.Drawing.Point(184, 7)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(113, 31)
        Me.cmbCancelar.TabIndex = 6
        Me.cmbCancelar.Text = "Cancelar"
        '
        'CmbAceptar
        '
        Me.CmbAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.CmbAceptar.Location = New System.Drawing.Point(64, 7)
        Me.CmbAceptar.Name = "CmbAceptar"
        Me.CmbAceptar.Size = New System.Drawing.Size(113, 31)
        Me.CmbAceptar.TabIndex = 5
        Me.CmbAceptar.Text = "Aceptar"
        '
        'cbxEstado
        '
        Me.TryDataBinding(cbxEstado, New System.Windows.Forms.Binding("Value", Me, "Estado", True))
        cbxEstado_DesignTimeLayout.LayoutString = resources.GetString("cbxEstado_DesignTimeLayout.LayoutString")
        Me.cbxEstado.DesignTimeLayout = cbxEstado_DesignTimeLayout
        Me.cbxEstado.DisabledBackColor = System.Drawing.Color.White
        Me.cbxEstado.Location = New System.Drawing.Point(111, 121)
        Me.cbxEstado.Name = "cbxEstado"
        Me.cbxEstado.SelectedIndex = -1
        Me.cbxEstado.SelectedItem = Nothing
        Me.cbxEstado.Size = New System.Drawing.Size(142, 21)
        Me.cbxEstado.TabIndex = 3
        '
        'cbxFechaCreacion
        '
        Me.TryDataBinding(cbxFechaCreacion, New System.Windows.Forms.Binding("BindableValue", Me, "FechaCreacion", True))
        Me.cbxFechaCreacion.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaCreacion.Location = New System.Drawing.Point(111, 96)
        Me.cbxFechaCreacion.Name = "cbxFechaCreacion"
        Me.cbxFechaCreacion.Size = New System.Drawing.Size(142, 21)
        Me.cbxFechaCreacion.TabIndex = 2
        '
        'lblFechaCreacion
        '
        Me.lblFechaCreacion.Location = New System.Drawing.Point(4, 100)
        Me.lblFechaCreacion.Name = "lblFechaCreacion"
        Me.lblFechaCreacion.Size = New System.Drawing.Size(95, 13)
        Me.lblFechaCreacion.TabIndex = 236
        Me.lblFechaCreacion.Text = "Fecha Creación"
        '
        'lblNCertificacion
        '
        Me.lblNCertificacion.Location = New System.Drawing.Point(4, 13)
        Me.lblNCertificacion.Name = "lblNCertificacion"
        Me.lblNCertificacion.Size = New System.Drawing.Size(100, 13)
        Me.lblNCertificacion.TabIndex = 233
        Me.lblNCertificacion.Text = "Nº. Certificación"
        '
        'lblTipoCertificacion
        '
        Me.lblTipoCertificacion.Location = New System.Drawing.Point(4, 149)
        Me.lblTipoCertificacion.Name = "lblTipoCertificacion"
        Me.lblTipoCertificacion.Size = New System.Drawing.Size(106, 13)
        Me.lblTipoCertificacion.TabIndex = 242
        Me.lblTipoCertificacion.Text = "Tipo Certificación"
        '
        'cbxTipo
        '
        Me.TryDataBinding(cbxTipo, New System.Windows.Forms.Binding("Value", Me, "TipoCertificacion", True))
        cbxTipo_DesignTimeLayout.LayoutString = resources.GetString("cbxTipo_DesignTimeLayout.LayoutString")
        Me.cbxTipo.DesignTimeLayout = cbxTipo_DesignTimeLayout
        Me.cbxTipo.DisabledBackColor = System.Drawing.Color.White
        Me.cbxTipo.Location = New System.Drawing.Point(111, 146)
        Me.cbxTipo.Name = "cbxTipo"
        Me.cbxTipo.SelectedIndex = -1
        Me.cbxTipo.SelectedItem = Nothing
        Me.cbxTipo.Size = New System.Drawing.Size(142, 21)
        Me.cbxTipo.TabIndex = 4
        '
        'lblClienteProveedor
        '
        Me.lblClienteProveedor.Location = New System.Drawing.Point(258, 150)
        Me.lblClienteProveedor.Name = "lblClienteProveedor"
        Me.lblClienteProveedor.Size = New System.Drawing.Size(31, 13)
        Me.lblClienteProveedor.TabIndex = 243
        Me.lblClienteProveedor.Text = "Tipo"
        Me.lblClienteProveedor.Visible = False
        '
        'frmAddCertificacion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(360, 219)
        Me.Controls.Add(Me.lblClienteProveedor)
        Me.Controls.Add(Me.lblTipoCertificacion)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.lblFechaCreacion)
        Me.Controls.Add(Me.lblNCertificacion)
        Me.Controls.Add(Me.cbxTipo)
        Me.Controls.Add(Me.txtDescCertificacion)
        Me.Controls.Add(Me.txtNCertificacion)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.cbxEstado)
        Me.Controls.Add(Me.cbxFechaCreacion)
        Me.EntityName = "ObraCertificacion"
        Me.MaximizeBox = False
        Me.Name = "frmAddCertificacion"
        Me.NavigationFields = "IdCertificacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Certificaciones"
        Me.ViewName = "tbObraCertificacion"
        Me.Panel2.ResumeLayout(False)
        CType(Me.cbxEstado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxTipo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Const cnTipoCertificacionCP As String = "enumTipoCertificacionCP"
    Private Const cnTipoCertificacion As String = "enumTipoCertificacion"

    Private mblnCancel, mDisabledTipoCertificacion As Boolean
    Private mIDObra, mTipoCertificacion As Integer
    Private mstrTipoCertificacion As String = cnTipoCertificacion
    Private Delegate Sub NCertificacion(ByVal datos As ObraCertificacion.dataNuevaCertificacion)


    Public Overrides ReadOnly Property RequeryRecords() As Engine.RequeryMode
        Get
            Return RequeryMode.ActiveRecord
        End Get
    End Property

    Public Sub AbrirAltaCertificacion(ByVal intIDObra As Integer, ByVal TipoCertificacion As Integer, _
                                      ByVal OwnerForm As FormBase, ByVal DisabledTipoCertificacion As Boolean)
        Dim f As New Filter
        f.Add(New NumberFilterItem("IDObra", intIDObra))
        f.Add(New NumberFilterItem("Estado", enumEstadoCertificacion.ecPendiente))

        Dim c As New ObraCertificacion
        Dim dt As DataTable = c.Filter(f)

        Dim blnCancel As Boolean
        If Not IsNothing(dt) AndAlso dt.Rows.Count > 0 Then
            If ExpertisApp.GenerateMessage("Tiene certificaciones pendientes. ¿Desea continuar.?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                blnCancel = True
            End If
        End If
        If Not blnCancel Then
            If TipoCertificacion <> -1 Then
                Dim blnSoloClienteProveedor As Boolean = (TipoCertificacion = enumTipoCertificacion.ClienteProduccion)
                lblClienteProveedor.Location = cbxTipo.Location
                lblClienteProveedor.Visible = blnSoloClienteProveedor
                cbxTipo.Visible = Not blnSoloClienteProveedor
                mTipoCertificacion = TipoCertificacion
                If blnSoloClienteProveedor Then
                    lblClienteProveedor.Text = RecuperarDescripcionEnumerado("enumTipoCertificacion", enumTipoCertificacion.ClienteProduccion)
                Else
                    mstrTipoCertificacion = cnTipoCertificacionCP
                End If
            End If
            mDisabledTipoCertificacion = DisabledTipoCertificacion
            mIDObra = intIDObra
            Dim frm As Form = Me
            frm.ShowDialog(OwnerForm) 'Para que no traiga todos los registros
        End If
    End Sub

    Private Sub FrmAddCertificacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.AddNew()

        cbxEstado.DataSource = New EnumData("enumEstadoCertificacion")
        If mstrTipoCertificacion = cnTipoCertificacionCP Then
            cbxTipo.DataSource = New EnumData("enumTipoCertificacionCP")
        Else
            cbxTipo.DataSource = New EnumData("enumTipoCertificacion")
        End If

        Me.CurrentData.Rows(0)("IDObra") = mIDObra
        Me.CurrentData.Rows(0)("TipoCertificacion") = CInt(IIf(mTipoCertificacion = -1, enumTipoCertificacion.ClienteProduccion, mTipoCertificacion))

        cbxTipo.Value = Me.CurrentData.Rows(0)("TipoCertificacion")
        cbxTipo.Enabled = Not mDisabledTipoCertificacion
        txtNCertificacion.Text = NumeroCertificacion()
    End Sub

    Private Function NumeroCertificacion() As Integer
        Dim ec As New ObraCertificacion
        Dim intNumCertificacion As Integer = 1

        Dim f As New Filter
        f.Add(New NumberFilterItem("IDObra", mIDObra))
        f.Add(New NumberFilterItem("TipoCertificacion", cbxTipo.Value))

        Dim dt As DataTable = ec.Filter(f)
        If Not IsNothing(dt) Then intNumCertificacion = dt.Rows.Count + 1

        Return intNumCertificacion
    End Function

    Private Sub cbxTipo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxTipo.LostFocus
        txtNCertificacion.Text = NumeroCertificacion()
    End Sub

   

    Private Sub CmbAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbAceptar.Click
        If Length(cbxFechaCreacion.Value) > 0 Then
            Me.Cursor = Windows.Forms.Cursors.WaitCursor
            Me.Refresh()
            Dim BlnError As Boolean = False
            Try
                Dim StrTexto As String = "La certificación se está realizando."
                Dim StrNomForm As String = "Espere unos momentos..."
                Dim info As New ObraCertificacion.dataNuevaCertificacion(mIDObra, txtNCertificacion.Text, cbxFechaCreacion.Value, txtDescCertificacion.Text, Nz(cbxEstado.Value, enumEstadoCertificacion.ecPendiente), Me.CurrentData.Rows(0)("TipoCertificacion"))
                Dim StartDelegate As New NCertificacion(AddressOf New ObraCertificacion().NCertificacion)
                Dim dtCertificacion As DataTable = New FrmProgresoProceso().Start(StartDelegate, New Object() {info}, StrTexto, StrNomForm)
                mblnCancel = False

            Catch ex As Exception
                BlnError = True
                Me.Refresh()
                Me.Cursor = Windows.Forms.Cursors.Default
                ExpertisApp.GenerateMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If Not BlnError Then
                    Me.Refresh()
                    Me.Cursor = Windows.Forms.Cursors.Default
                End If
                Me.Close()
            End Try
        Else
            mblnCancel = True
            ExpertisApp.GenerateMessage("La Fecha Creación es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub cmbCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCancelar.Click
        mblnCancel = False
        Me.Close()
    End Sub

    Private Sub frmAddCertificacion_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = mblnCancel
    End Sub

End Class
