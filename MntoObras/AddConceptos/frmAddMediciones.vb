Public Class frmAddMediciones
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
    Friend WithEvents CmbNuevo As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmbCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents CmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents txtDescTrabajo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents txtCodTrabajo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblCodTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblDescMedicion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtDescMedicion As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblQPI As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ntbQPI As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblLargo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ntbLargo As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblAncho As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ntbAncho As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblAlto As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ntbAlto As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblTotal As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ntbTotal As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblCertificar As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cmbCertificar As Solmicro.Expertis.Engine.UI.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.CmbNuevo = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.CmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.txtDescTrabajo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtCodTrabajo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblCodTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.lblDescMedicion = New Solmicro.Expertis.Engine.UI.Label
        Me.txtDescMedicion = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblQPI = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbQPI = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblLargo = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbLargo = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblAncho = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbAncho = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblAlto = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbAlto = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblTotal = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbTotal = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblCertificar = New Solmicro.Expertis.Engine.UI.Label
        Me.cmbCertificar = New Solmicro.Expertis.Engine.UI.ComboBox
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
        Me.Panel1.TabIndex = 234
        '
        'CmbNuevo
        '
        Me.CmbNuevo.Location = New System.Drawing.Point(122, 7)
        Me.CmbNuevo.Name = "CmbNuevo"
        Me.CmbNuevo.Size = New System.Drawing.Size(94, 29)
        Me.CmbNuevo.TabIndex = 6
        Me.CmbNuevo.Text = "Nuevo"
        '
        'cmbCancelar
        '
        Me.cmbCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmbCancelar.Location = New System.Drawing.Point(322, 7)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(94, 29)
        Me.cmbCancelar.TabIndex = 8
        Me.cmbCancelar.Text = "Cancelar"
        '
        'CmbAceptar
        '
        Me.CmbAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.CmbAceptar.Location = New System.Drawing.Point(222, 7)
        Me.CmbAceptar.Name = "CmbAceptar"
        Me.CmbAceptar.Size = New System.Drawing.Size(94, 29)
        Me.CmbAceptar.TabIndex = 7
        Me.CmbAceptar.Text = "Aceptar"
        '
        'txtDescTrabajo
        '
        Me.txtDescTrabajo.Enabled = False
        Me.txtDescTrabajo.Location = New System.Drawing.Point(224, 8)
        Me.txtDescTrabajo.Name = "txtDescTrabajo"
        Me.txtDescTrabajo.Size = New System.Drawing.Size(313, 21)
        Me.txtDescTrabajo.TabIndex = 242
        Me.txtDescTrabajo.TabStop = False
        '
        'txtCodTrabajo
        '
        Me.txtCodTrabajo.Enabled = False
        Me.txtCodTrabajo.Location = New System.Drawing.Point(101, 8)
        Me.txtCodTrabajo.Name = "txtCodTrabajo"
        Me.txtCodTrabajo.Size = New System.Drawing.Size(119, 21)
        Me.txtCodTrabajo.TabIndex = 240
        '
        'lblCodTrabajo
        '
        Me.lblCodTrabajo.Location = New System.Drawing.Point(4, 8)
        Me.lblCodTrabajo.Name = "lblCodTrabajo"
        Me.lblCodTrabajo.Size = New System.Drawing.Size(47, 17)
        Me.lblCodTrabajo.TabIndex = 241
        Me.lblCodTrabajo.Text = "Trabajo"
        '
        'lblDescMedicion
        '
        Me.lblDescMedicion.Location = New System.Drawing.Point(4, 36)
        Me.lblDescMedicion.Name = "lblDescMedicion"
        Me.lblDescMedicion.Size = New System.Drawing.Size(89, 17)
        Me.lblDescMedicion.TabIndex = 243
        Me.lblDescMedicion.Text = "Desc. Medición"
        '
        'txtDescMedicion
        '
        Me.TryDataBinding(txtDescMedicion, New System.Windows.Forms.Binding("Text", Me, "DescMedicion"))
        Me.txtDescMedicion.Location = New System.Drawing.Point(101, 34)
        Me.txtDescMedicion.Name = "txtDescMedicion"
        Me.txtDescMedicion.Size = New System.Drawing.Size(436, 21)
        Me.txtDescMedicion.TabIndex = 0
        '
        'lblQPI
        '
        Me.lblQPI.Location = New System.Drawing.Point(4, 64)
        Me.lblQPI.Name = "lblQPI"
        Me.lblQPI.Size = New System.Drawing.Size(24, 17)
        Me.lblQPI.TabIndex = 245
        Me.lblQPI.Text = "P.I."
        '
        'ntbQPI
        '
        Me.TryDataBinding(ntbQPI, New System.Windows.Forms.Binding("Value", Me, "QPI"))
        Me.ntbQPI.Location = New System.Drawing.Point(101, 66)
        Me.ntbQPI.Name = "ntbQPI"
        Me.ntbQPI.Size = New System.Drawing.Size(92, 21)
        Me.ntbQPI.TabIndex = 1
        '
        'lblLargo
        '
        Me.lblLargo.Location = New System.Drawing.Point(211, 67)
        Me.lblLargo.Name = "lblLargo"
        Me.lblLargo.Size = New System.Drawing.Size(36, 17)
        Me.lblLargo.TabIndex = 247
        Me.lblLargo.Text = "Largo"
        '
        'ntbLargo
        '
        Me.TryDataBinding(ntbLargo, New System.Windows.Forms.Binding("Value", Me, "Largo"))
        Me.ntbLargo.Location = New System.Drawing.Point(264, 66)
        Me.ntbLargo.Name = "ntbLargo"
        Me.ntbLargo.Size = New System.Drawing.Size(92, 21)
        Me.ntbLargo.TabIndex = 3
        '
        'lblAncho
        '
        Me.lblAncho.Location = New System.Drawing.Point(4, 89)
        Me.lblAncho.Name = "lblAncho"
        Me.lblAncho.Size = New System.Drawing.Size(39, 17)
        Me.lblAncho.TabIndex = 249
        Me.lblAncho.Text = "Ancho"
        '
        'ntbAncho
        '
        Me.TryDataBinding(ntbAncho, New System.Windows.Forms.Binding("Value", Me, "Ancho"))
        Me.ntbAncho.Location = New System.Drawing.Point(101, 91)
        Me.ntbAncho.Name = "ntbAncho"
        Me.ntbAncho.Size = New System.Drawing.Size(92, 21)
        Me.ntbAncho.TabIndex = 2
        '
        'lblAlto
        '
        Me.lblAlto.Location = New System.Drawing.Point(211, 93)
        Me.lblAlto.Name = "lblAlto"
        Me.lblAlto.Size = New System.Drawing.Size(26, 17)
        Me.lblAlto.TabIndex = 251
        Me.lblAlto.Text = "Alto"
        '
        'ntbAlto
        '
        Me.TryDataBinding(ntbAlto, New System.Windows.Forms.Binding("Value", Me, "Alto"))
        Me.ntbAlto.Location = New System.Drawing.Point(264, 91)
        Me.ntbAlto.Name = "ntbAlto"
        Me.ntbAlto.Size = New System.Drawing.Size(92, 21)
        Me.ntbAlto.TabIndex = 4
        '
        'lblTotal
        '
        Me.lblTotal.Location = New System.Drawing.Point(389, 67)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(32, 17)
        Me.lblTotal.TabIndex = 253
        Me.lblTotal.Text = "Total"
        '
        'ntbTotal
        '
        Me.TryDataBinding(ntbTotal, New System.Windows.Forms.Binding("Value", Me, "Total"))
        Me.ntbTotal.Enabled = False
        Me.ntbTotal.Location = New System.Drawing.Point(434, 66)
        Me.ntbTotal.Name = "ntbTotal"
        Me.ntbTotal.Size = New System.Drawing.Size(103, 21)
        Me.ntbTotal.TabIndex = 254
        '
        'lblCertificar
        '
        Me.lblCertificar.Location = New System.Drawing.Point(370, 91)
        Me.lblCertificar.Name = "lblCertificar"
        Me.lblCertificar.Size = New System.Drawing.Size(56, 17)
        Me.lblCertificar.TabIndex = 255
        Me.lblCertificar.Text = "Certificar"
        '
        'cmbCertificar
        '
        Me.TryDataBinding(cmbCertificar, New System.Windows.Forms.Binding("Value", Me, "Certificar"))
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
        "le></SelectedInactiveFormatStyle><WatermarkImage /><FlatBorderColor>125, 159, 19" & _
        "0</FlatBorderColor><ControlStyle><ButtonAppearance>Flat</ButtonAppearance></Cont" & _
        "rolStyle><VisualStyle>Standard</VisualStyle><AllowEdit>False</AllowEdit><Expanda" & _
        "bleGroups>False</ExpandableGroups><GroupByBoxVisible>False</GroupByBoxVisible><H" & _
        "ideSelection>Highlight</HideSelection></GridEXLayoutData>"
        Me.cmbCertificar.DesignTimeLayout = GridEXLayout1
        Me.cmbCertificar.Location = New System.Drawing.Point(434, 91)
        Me.cmbCertificar.Name = "cmbCertificar"
        Me.cmbCertificar.SelectedIndex = -1
        Me.cmbCertificar.SelectedItem = Nothing
        Me.cmbCertificar.Size = New System.Drawing.Size(103, 21)
        Me.cmbCertificar.TabIndex = 5
        Me.cmbCertificar.Value = Nothing
        '
        'frmAddMediciones
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(541, 160)
        Me.Controls.Add(Me.cmbCertificar)
        Me.Controls.Add(Me.ntbTotal)
        Me.Controls.Add(Me.ntbAlto)
        Me.Controls.Add(Me.ntbAncho)
        Me.Controls.Add(Me.ntbLargo)
        Me.Controls.Add(Me.ntbQPI)
        Me.Controls.Add(Me.txtDescMedicion)
        Me.Controls.Add(Me.txtDescTrabajo)
        Me.Controls.Add(Me.txtCodTrabajo)
        Me.Controls.Add(Me.lblCodTrabajo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblDescMedicion)
        Me.Controls.Add(Me.lblQPI)
        Me.Controls.Add(Me.lblLargo)
        Me.Controls.Add(Me.lblAncho)
        Me.Controls.Add(Me.lblAlto)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblCertificar)
        Me.EntityName = "ObraMedicion"
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmAddMediciones"
        Me.NavigationFields = "IDObra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta de Mediciones"
        Me.ViewName = "vFrmObraMedicion"
        Me.WindowState = System.Windows.Forms.FormWindowState.Normal
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mdtMediciones As DataTable
    Private mintIDObra, mintIDTrabajo As Integer
    Private mblnCancel As Boolean

    Public Overrides ReadOnly Property RequeryRecords() As Engine.RequeryMode
        Get
            Return RequeryMode.ActiveRecord
        End Get
    End Property

#Region " Load "

    Public Function AbrirAltaMediciones(ByVal IDObra As Integer, ByVal IDTrabajo As Integer, ByVal CodTrabajo As String, _
                                        ByVal DescTrabajo As String) As DataTable

        txtCodTrabajo.Text = CodTrabajo
        txtDescTrabajo.Text = DescTrabajo
        mintIDObra = IDObra
        mintIDTrabajo = IDTrabajo

        Dim frm As New Form
        frm = Me
        frm.ShowDialog() 'Para que no traiga todos los registros

        If Me.DialogResult = DialogResult.OK Then Return mdtMediciones
        Return Nothing
    End Function

    Private Sub frmAddVarios_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadEnums()
        ADDNewMediciones()
    End Sub

    Private Sub LoadEnums()
        cmbCertificar.DataSource = New EnumData("enumSiNo")
    End Sub

    Private Sub ADDNewMediciones()
        Me.AddNew()

        Me.CurrentData.Rows(0)("IDObra") = mintIDObra
        Me.CurrentData.Rows(0)("IDTrabajo") = mintIDTrabajo
        Me.CurrentData.Rows(0)("CodTrabajo") = txtCodTrabajo.Text
        Me.CurrentData.Rows(0)("Certificar") = CInt(enumSiNo.Si)

        If IsNothing(mdtMediciones) Then mdtMediciones = CurrentData.Clone
    End Sub

#End Region

    Private Function ValidaDatosObligatorios() As Boolean
        If Length(txtCodTrabajo.Text) = 0 Then
            mblnCancel = True
            ExpertisApp.GenerateMessage("El Trabajo es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 'El Cod. Trabajo es un dato obligatorio.
        End If
    End Function

    Private Sub CmbNuevo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbNuevo.Click
        mblnCancel = ValidaDatosObligatorios()
        If Not mblnCancel Then
            mdtMediciones.Rows.Add(Me.CurrentData.Rows(0).ItemArray)
            ADDNewMediciones()
        End If
    End Sub

    Private Sub CmbAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbAceptar.Click
        mblnCancel = ValidaDatosObligatorios()
        If Not mblnCancel Then
            Me.DialogResult = DialogResult.OK
            mdtMediciones.Rows.Add(Me.CurrentData.Rows(0).ItemArray)
            Me.RecordsState = UI.RecordsState.Saved
            Me.Close()
        End If
    End Sub

    Private Sub cmbCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCancelar.Click
        mblnCancel = False
        Me.RecordsState = UI.RecordsState.Saved
        Me.Close()
    End Sub

    Private Sub frmAddVarios_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = mblnCancel
    End Sub
End Class
