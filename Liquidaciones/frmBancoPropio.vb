Public Class frmBancoPropio
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
    Friend WithEvents lblBancoPropio As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ulDescBancoPropio As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents cbxBancoPropio As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents cmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmbCancelar As Solmicro.Expertis.Engine.UI.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.lblBancoPropio = New Solmicro.Expertis.Engine.UI.Label
        Me.ulDescBancoPropio = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.cbxBancoPropio = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.Panel1.suspendlayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbAceptar)
        Me.Panel1.Controls.Add(Me.cmbCancelar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(367, 44)
        Me.Panel1.TabIndex = 0
        '
        'cmbAceptar
        '
        Me.cmbAceptar.Location = New System.Drawing.Point(91, 10)
        Me.cmbAceptar.Name = "cmbAceptar"
        Me.cmbAceptar.Size = New System.Drawing.Size(89, 25)
        Me.cmbAceptar.TabIndex = 22
        Me.cmbAceptar.Text = "Aceptar"
        '
        'cmbCancelar
        '
        Me.cmbCancelar.Location = New System.Drawing.Point(187, 10)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(89, 25)
        Me.cmbCancelar.TabIndex = 23
        Me.cmbCancelar.Text = "Cancelar"
        '
        'lblBancoPropio
        '
        Me.lblBancoPropio.Location = New System.Drawing.Point(10, 19)
        Me.lblBancoPropio.Name = "lblBancoPropio"
        Me.lblBancoPropio.Size = New System.Drawing.Size(78, 17)
        Me.lblBancoPropio.TabIndex = 51
        Me.lblBancoPropio.Tag = "IdRec=4613;"
        Me.lblBancoPropio.Text = "Banco Propio"
        '
        'ulDescBancoPropio
        '
        Me.TryDataBinding(ulDescBancoPropio, New System.Windows.Forms.Binding("Text", Me.cbxBancoPropio, "DescBancoPropio"))
        Me.ulDescBancoPropio.Location = New System.Drawing.Point(202, 19)
        Me.ulDescBancoPropio.Name = "ulDescBancoPropio"
        Me.ulDescBancoPropio.Size = New System.Drawing.Size(160, 21)
        Me.ulDescBancoPropio.TabIndex = 52
        '
        'cbxBancoPropio
        '
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""IDBancoPropi" & _
        "o""><Caption>Banco Propio</Caption><DataMember>IDBancoPropio</DataMember><Key>IDB" & _
        "ancoPropio</Key><Position>0</Position></Column0><Column1 ID=""DescBancoPropio""><C" & _
        "aption>Descripción</Caption><DataMember>DescBancoPropio</DataMember><Key>DescBan" & _
        "coPropio</Key><Position>1</Position></Column1><Column2 ID=""CContable""><Caption>C" & _
        ". Contable</Caption><DataMember>CContable</DataMember><Key>CContable</Key><Posit" & _
        "ion>2</Position><Visible>False</Visible></Column2></Columns><GroupCondition ID=""" & _
        """ /></RootTable><RowWithErrorsFormatStyle><PredefinedStyle>RowWithErrorsFormatSt" & _
        "yle</PredefinedStyle></RowWithErrorsFormatStyle><LinkFormatStyle><PredefinedStyl" & _
        "e>LinkFormatStyle</PredefinedStyle></LinkFormatStyle><CardCaptionFormatStyle><Pr" & _
        "edefinedStyle>CardCaptionFormatStyle</PredefinedStyle></CardCaptionFormatStyle><" & _
        "GroupByBoxInfoFormatStyle><PredefinedStyle>GroupByBoxInfoFormatStyle</Predefined" & _
        "Style></GroupByBoxInfoFormatStyle><GroupRowFormatStyle><PredefinedStyle>GroupRow" & _
        "FormatStyle</PredefinedStyle></GroupRowFormatStyle><HeaderFormatStyle><Predefine" & _
        "dStyle>HeaderFormatStyle</PredefinedStyle></HeaderFormatStyle><PreviewRowFormatS" & _
        "tyle><PredefinedStyle>PreviewRowFormatStyle</PredefinedStyle></PreviewRowFormatS" & _
        "tyle><RowFormatStyle><PredefinedStyle>RowFormatStyle</PredefinedStyle></RowForma" & _
        "tStyle><SelectedFormatStyle><PredefinedStyle>SelectedFormatStyle</PredefinedStyl" & _
        "e></SelectedFormatStyle><SelectedInactiveFormatStyle><PredefinedStyle>SelectedIn" & _
        "activeFormatStyle</PredefinedStyle></SelectedInactiveFormatStyle><WatermarkImage" & _
        " /><BorderStyle>Flat</BorderStyle><FlatBorderColor>125, 159, 190</FlatBorderColo" & _
        "r><ControlStyle><ButtonAppearance>Flat</ButtonAppearance></ControlStyle><VisualS" & _
        "tyle>Standard</VisualStyle><AllowEdit>False</AllowEdit><ExpandableGroups>False</" & _
        "ExpandableGroups><GroupByBoxVisible>False</GroupByBoxVisible><HideSelection>High" & _
        "light</HideSelection><DisplayMember>IDBancoPropio</DisplayMember><ValueMember>ID" & _
        "BancoPropio</ValueMember></GridEXLayoutData>"
        Me.cbxBancoPropio.DesignTimeLayout = GridEXLayout1
        Me.cbxBancoPropio.DisplayMember = "IDBancoPropio"
        Me.cbxBancoPropio.EntityName = "BancoPropio"
        Me.cbxBancoPropio.Location = New System.Drawing.Point(95, 19)
        Me.cbxBancoPropio.Name = "cbxBancoPropio"
        Me.cbxBancoPropio.PrimaryDataFields = "IDBancoPropio"
        Me.cbxBancoPropio.SecondaryDataFields = "IDBancoPropio"
        Me.cbxBancoPropio.SelectedIndex = -1
        Me.cbxBancoPropio.SelectedItem = Nothing
        Me.cbxBancoPropio.Size = New System.Drawing.Size(104, 21)
        Me.cbxBancoPropio.TabIndex = 50
        Me.cbxBancoPropio.Value = Nothing
        Me.cbxBancoPropio.ValueMember = "IDBancoPropio"
        Me.cbxBancoPropio.ViewName = "tbMaestroBancoPropio"
        '
        'frmBancoPropio
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(367, 104)
        Me.Controls.Add(Me.lblBancoPropio)
        Me.Controls.Add(Me.ulDescBancoPropio)
        Me.Controls.Add(Me.cbxBancoPropio)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.Name = "frmBancoPropio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fichero Transferencia"
        Me.WindowState = System.Windows.Forms.FormWindowState.Normal
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mblnCancel As Boolean = False

    Private Sub cmbCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCancelar.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub cmbAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbAceptar.Click
        
        If Length(cbxBancoPropio.Value) = 0 Then
            mblnCancel = True
            Me.DialogResult = DialogResult.Cancel
            ExpertisApp.GenerateMessage("Debe introducir un Banco Propio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 'Debe introducir la nueva fecha.
        Else
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub frmBancoPropio_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = mblnCancel
    End Sub
End Class
