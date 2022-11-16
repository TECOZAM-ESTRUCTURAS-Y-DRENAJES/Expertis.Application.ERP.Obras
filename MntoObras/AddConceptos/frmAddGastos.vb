Public Class frmAddGastos
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
    Public WithEvents advIDGasto As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents txtDescGasto As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblIDGasto As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents ntbMargenPrev As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblMargenPrev As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents ntbImpPrevGastoVentaA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents ntbImpPrevGastoA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblImpPrevGastoA As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblImpPrevGastoVentaA As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents chbAplicarQ As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents Frame1 As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents cmbTipoFacturacion As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents chbFacturable As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents lblTipoFacturacion As Solmicro.Expertis.Engine.UI.Label

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.CmbNuevo = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.CmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.advIDGasto = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.txtDescGasto = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtDescTrabajo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtCodTrabajo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblCodTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.lblIDGasto = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbImpPrevGastoVentaA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.ntbMargenPrev = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.ntbImpPrevGastoA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblImpPrevGastoA = New Solmicro.Expertis.Engine.UI.Label
        Me.lblMargenPrev = New Solmicro.Expertis.Engine.UI.Label
        Me.lblImpPrevGastoVentaA = New Solmicro.Expertis.Engine.UI.Label
        Me.chbAplicarQ = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.Frame1 = New Solmicro.Expertis.Engine.UI.Frame
        Me.cmbTipoFacturacion = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.chbFacturable = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.lblTipoFacturacion = New Solmicro.Expertis.Engine.UI.Label
        Me.Panel1.suspendlayout()
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CmbNuevo)
        Me.Panel1.Controls.Add(Me.cmbCancelar)
        Me.Panel1.Controls.Add(Me.CmbAceptar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 166)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(541, 42)
        Me.Panel1.TabIndex = 235
        '
        'CmbNuevo
        '
        Me.CmbNuevo.Location = New System.Drawing.Point(122, 7)
        Me.CmbNuevo.Name = "CmbNuevo"
        Me.CmbNuevo.Size = New System.Drawing.Size(94, 29)
        Me.CmbNuevo.TabIndex = 8
        Me.CmbNuevo.Text = "Nuevo"
        '
        'cmbCancelar
        '
        Me.cmbCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmbCancelar.Location = New System.Drawing.Point(322, 7)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(94, 29)
        Me.cmbCancelar.TabIndex = 10
        Me.cmbCancelar.Text = "Cancelar"
        '
        'CmbAceptar
        '
        Me.CmbAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.CmbAceptar.Location = New System.Drawing.Point(222, 7)
        Me.CmbAceptar.Name = "CmbAceptar"
        Me.CmbAceptar.Size = New System.Drawing.Size(94, 29)
        Me.CmbAceptar.TabIndex = 9
        Me.CmbAceptar.Text = "Aceptar"
        '
        'advIDGasto
        '
        Me.TryDataBinding(advIDGasto, New System.Windows.Forms.Binding("Text", Me, "IDGasto"))
        Me.advIDGasto.EntityName = "Gasto"
        Me.advIDGasto.Location = New System.Drawing.Point(71, 34)
        Me.advIDGasto.Name = "advIDGasto"
        Me.advIDGasto.PrimaryDataFields = "IDGasto"
        Me.advIDGasto.SecondaryDataFields = "IDGasto"
        Me.advIDGasto.Size = New System.Drawing.Size(119, 23)
        Me.advIDGasto.TabIndex = 0
        '
        'txtDescGasto
        '
        Me.TryDataBinding(txtDescGasto, New System.Windows.Forms.Binding("Text", Me, "DescGasto"))
        Me.txtDescGasto.Location = New System.Drawing.Point(195, 34)
        Me.txtDescGasto.Name = "txtDescGasto"
        Me.txtDescGasto.Size = New System.Drawing.Size(342, 21)
        Me.txtDescGasto.TabIndex = 1
        '
        'txtDescTrabajo
        '
        Me.txtDescTrabajo.Enabled = False
        Me.txtDescTrabajo.Location = New System.Drawing.Point(195, 8)
        Me.txtDescTrabajo.Name = "txtDescTrabajo"
        Me.txtDescTrabajo.Size = New System.Drawing.Size(342, 21)
        Me.txtDescTrabajo.TabIndex = 239
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
        Me.lblCodTrabajo.Location = New System.Drawing.Point(4, 8)
        Me.lblCodTrabajo.Name = "lblCodTrabajo"
        Me.lblCodTrabajo.Size = New System.Drawing.Size(50, 13)
        Me.lblCodTrabajo.TabIndex = 238
        Me.lblCodTrabajo.Text = "Trabajo"
        '
        'lblIDGasto
        '
        Me.lblIDGasto.Location = New System.Drawing.Point(4, 36)
        Me.lblIDGasto.Name = "lblIDGasto"
        Me.lblIDGasto.Size = New System.Drawing.Size(40, 13)
        Me.lblIDGasto.TabIndex = 243
        Me.lblIDGasto.Text = "Gasto"
        '
        'ntbImpPrevGastoVentaA
        '
        Me.TryDataBinding(ntbImpPrevGastoVentaA, New System.Windows.Forms.Binding("Value", Me, "ImpPrevGastoVentaA"))
        Me.ntbImpPrevGastoVentaA.Location = New System.Drawing.Point(416, 90)
        Me.ntbImpPrevGastoVentaA.Name = "ntbImpPrevGastoVentaA"
        Me.ntbImpPrevGastoVentaA.Size = New System.Drawing.Size(121, 21)
        Me.ntbImpPrevGastoVentaA.TabIndex = 5
        '
        'ntbMargenPrev
        '
        Me.TryDataBinding(ntbMargenPrev, New System.Windows.Forms.Binding("Value", Me, "MargenPrev"))
        Me.ntbMargenPrev.Location = New System.Drawing.Point(262, 90)
        Me.ntbMargenPrev.Name = "ntbMargenPrev"
        Me.ntbMargenPrev.Size = New System.Drawing.Size(61, 21)
        Me.ntbMargenPrev.TabIndex = 4
        '
        'ntbImpPrevGastoA
        '
        Me.TryDataBinding(ntbImpPrevGastoA, New System.Windows.Forms.Binding("Value", Me, "ImpPrevGastoA"))
        Me.ntbImpPrevGastoA.Location = New System.Drawing.Point(71, 90)
        Me.ntbImpPrevGastoA.Name = "ntbImpPrevGastoA"
        Me.ntbImpPrevGastoA.Size = New System.Drawing.Size(121, 21)
        Me.ntbImpPrevGastoA.TabIndex = 3
        '
        'lblImpPrevGastoA
        '
        Me.lblImpPrevGastoA.Location = New System.Drawing.Point(4, 90)
        Me.lblImpPrevGastoA.Name = "lblImpPrevGastoA"
        Me.lblImpPrevGastoA.Size = New System.Drawing.Size(67, 13)
        Me.lblImpPrevGastoA.TabIndex = 245
        Me.lblImpPrevGastoA.Text = "Imp. Prev."
        '
        'lblMargenPrev
        '
        Me.lblMargenPrev.Location = New System.Drawing.Point(209, 90)
        Me.lblMargenPrev.Name = "lblMargenPrev"
        Me.lblMargenPrev.Size = New System.Drawing.Size(49, 13)
        Me.lblMargenPrev.TabIndex = 247
        Me.lblMargenPrev.Text = "Margen"
        '
        'lblImpPrevGastoVentaA
        '
        Me.lblImpPrevGastoVentaA.Location = New System.Drawing.Point(339, 90)
        Me.lblImpPrevGastoVentaA.Name = "lblImpPrevGastoVentaA"
        Me.lblImpPrevGastoVentaA.Size = New System.Drawing.Size(70, 13)
        Me.lblImpPrevGastoVentaA.TabIndex = 248
        Me.lblImpPrevGastoVentaA.Text = "Imp. Venta"
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
        'Frame1
        '
        Me.Frame1.Controls.Add(Me.cmbTipoFacturacion)
        Me.Frame1.Controls.Add(Me.chbFacturable)
        Me.Frame1.Controls.Add(Me.lblTipoFacturacion)
        Me.Frame1.Location = New System.Drawing.Point(4, 114)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(536, 52)
        Me.Frame1.TabIndex = 249
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
        Me.cmbTipoFacturacion.Location = New System.Drawing.Point(300, 18)
        Me.cmbTipoFacturacion.Name = "cmbTipoFacturacion"
        Me.cmbTipoFacturacion.SelectedIndex = -1
        Me.cmbTipoFacturacion.SelectedItem = Nothing
        Me.cmbTipoFacturacion.Size = New System.Drawing.Size(162, 21)
        Me.cmbTipoFacturacion.TabIndex = 7
        Me.cmbTipoFacturacion.Value = Nothing
        '
        'chbFacturable
        '
        Me.TryDataBinding(chbFacturable, New System.Windows.Forms.Binding("BindableValue", Me, "Facturable"))
        Me.chbFacturable.Location = New System.Drawing.Point(78, 18)
        Me.chbFacturable.Name = "chbFacturable"
        Me.chbFacturable.Size = New System.Drawing.Size(93, 23)
        Me.chbFacturable.TabIndex = 6
        Me.chbFacturable.Text = "Facturable"
        '
        'lblTipoFacturacion
        '
        Me.lblTipoFacturacion.Location = New System.Drawing.Point(195, 21)
        Me.lblTipoFacturacion.Name = "lblTipoFacturacion"
        Me.lblTipoFacturacion.Size = New System.Drawing.Size(99, 13)
        Me.lblTipoFacturacion.TabIndex = 4
        Me.lblTipoFacturacion.Text = "Tipo Facturación"
        '
        'frmAddGastos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(541, 208)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.chbAplicarQ)
        Me.Controls.Add(Me.ntbImpPrevGastoVentaA)
        Me.Controls.Add(Me.ntbMargenPrev)
        Me.Controls.Add(Me.ntbImpPrevGastoA)
        Me.Controls.Add(Me.lblImpPrevGastoA)
        Me.Controls.Add(Me.lblMargenPrev)
        Me.Controls.Add(Me.lblImpPrevGastoVentaA)
        Me.Controls.Add(Me.advIDGasto)
        Me.Controls.Add(Me.txtDescGasto)
        Me.Controls.Add(Me.txtDescTrabajo)
        Me.Controls.Add(Me.txtCodTrabajo)
        Me.Controls.Add(Me.lblCodTrabajo)
        Me.Controls.Add(Me.lblIDGasto)
        Me.Controls.Add(Me.Panel1)
        Me.EntityName = "ObraGasto"
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmAddGastos"
        Me.NavigationFields = "IDObra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta de Gastos"
        Me.ViewName = "VFrmObraGastos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Normal
        Me.Panel1.ResumeLayout(False)
        Me.Frame1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Protected mdtGastos As DataTable
    Protected mintIDObra, mintIDTrabajo As Integer
    Protected mblnCancel, mblnFacturable As Boolean

    Public Overrides ReadOnly Property RequeryRecords() As Engine.RequeryMode
        Get
            Return RequeryMode.ActiveRecord
        End Get
    End Property

#Region " Load "

    Public Function AbrirAltaGastos(ByVal IDObra As Integer, ByVal IDTrabajo As Integer, ByVal CodTrabajo As String, _
                                    ByVal DescTrabajo As String, ByVal blnFacturable As Boolean) As DataTable

        txtCodTrabajo.Text = CodTrabajo
        txtDescTrabajo.Text = DescTrabajo
        mintIDObra = IDObra
        mintIDTrabajo = IDTrabajo
        mblnFacturable = blnFacturable

        Dim frm As New Form
        frm = Me
        frm.ShowDialog() 'Para que no traiga todos los registros

        If Me.DialogResult = DialogResult.OK Then Return mdtGastos
        Return Nothing
    End Function

    Protected Overridable Sub frmAddGastos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadEnums()
        ADDNewGasto()
    End Sub

    Protected Overridable Sub LoadEnums()
        cmbTipoFacturacion.DataSource = New EnumData("enumogTipoFacturacion")
    End Sub

    Protected Overridable Sub ADDNewGasto()
        Me.AddNew()

        Me.CurrentData.Rows(0)("IDObra") = mintIDObra
        Me.CurrentData.Rows(0)("IDTrabajo") = mintIDTrabajo
        Me.CurrentData.Rows(0)("CodTrabajo") = txtCodTrabajo.Text
        Me.CurrentData.Rows(0)("AplicarQ") = False
        Me.CurrentData.Rows(0)("Facturable") = mblnFacturable

        If IsNothing(mdtGastos) Then mdtGastos = CurrentData.Clone
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
            mdtGastos.Rows.Add(Me.CurrentData.Rows(0).ItemArray)
            ADDNewGasto()
        End If
    End Sub

    Protected Overridable Sub CmbAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbAceptar.Click
        mblnCancel = ValidaDatosObligatorios()
        If Not mblnCancel Then
            Me.DialogResult = DialogResult.OK
            mdtGastos.Rows.Add(Me.CurrentData.Rows(0).ItemArray)
            Me.RecordsState = UI.RecordsState.Saved
            Me.Close()
        End If
    End Sub

    Protected Overridable Sub cmbCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCancelar.Click
        mblnCancel = False
        Me.RecordsState = UI.RecordsState.Saved
        Me.Close()
    End Sub

    Protected Overridable Sub frmAddGastos_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = mblnCancel
    End Sub

End Class
