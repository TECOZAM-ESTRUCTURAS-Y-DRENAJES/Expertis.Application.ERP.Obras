Public Class frmFacturacionProvisional
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
    Friend WithEvents cmbCancel As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmbOK As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents jngDatos As Solmicro.Expertis.Engine.UI.Grid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmbCancel = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbOK = New Solmicro.Expertis.Engine.UI.Button
        Me.jngDatos = New Solmicro.Expertis.Engine.UI.Grid
        Me.Panel1.suspendlayout()
        CType(Me.jngDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbCancel)
        Me.Panel1.Controls.Add(Me.cmbOK)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 253)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(512, 40)
        Me.Panel1.TabIndex = 3
        '
        'cmbCancel
        '
        Me.cmbCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmbCancel.Location = New System.Drawing.Point(259, 7)
        Me.cmbCancel.Name = "cmbCancel"
        Me.cmbCancel.Size = New System.Drawing.Size(105, 27)
        Me.cmbCancel.TabIndex = 4
        Me.cmbCancel.Text = "Cancelar"
        '
        'cmbOK
        '
        Me.cmbOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.cmbOK.Location = New System.Drawing.Point(148, 7)
        Me.cmbOK.Name = "cmbOK"
        Me.cmbOK.Size = New System.Drawing.Size(105, 27)
        Me.cmbOK.TabIndex = 3
        Me.cmbOK.Text = "Aceptar"
        '
        'jngDatos
        '
        Me.jngDatos.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False
        Me.jngDatos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False
        Me.jngDatos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""NFactura""><C" & _
        "aption>Nº Factura</Caption><DataMember>NFactura</DataMember><Key>NFactura</Key><" & _
        "Position>0</Position><TextAlignment>Far</TextAlignment><Width>80</Width></Column" & _
        "0><Column1 ID=""IDCliente""><Caption>Cliente</Caption><DataMember>IDCliente</DataM" & _
        "ember><Key>IDCliente</Key><Position>1</Position><TextAlignment>Near</TextAlignme" & _
        "nt><Width>80</Width></Column1><Column2 ID=""IDContador""><Caption>Contador</Captio" & _
        "n><DataMember>IDContador</DataMember><Key>IDContador</Key><Position>2</Position>" & _
        "<TextAlignment>Near</TextAlignment><Width>60</Width></Column2><Column3 ID=""IDMon" & _
        "eda""><Caption>Moneda</Caption><DataMember>IDMoneda</DataMember><Key>IDMoneda</Ke" & _
        "y><Position>3</Position><TextAlignment>Near</TextAlignment><Width>53</Width></Co" & _
        "lumn3><Column4 ID=""IDFormaPago""><Caption>F. Pago</Caption><DataMember>IDFormaPag" & _
        "o</DataMember><Key>IDFormaPago</Key><Position>4</Position><TextAlignment>Near</T" & _
        "extAlignment><Width>53</Width></Column4><Column5 ID=""IDCondicionPago""><Caption>C" & _
        ". Pago</Caption><DataMember>IDCondicionPago</DataMember><Key>IDCondicionPago</Ke" & _
        "y><Position>5</Position><TextAlignment>Near</TextAlignment><Width>53</Width></Co" & _
        "lumn5><Column6 ID=""FechaFactura""><Caption>Fecha Factura</Caption><DataMember>Fec" & _
        "haFactura</DataMember><EditType>CalendarCombo</EditType><Key>FechaFactura</Key><" & _
        "Position>6</Position><TextAlignment>Near</TextAlignment><Width>91</Width></Colum" & _
        "n6><Column7 ID=""IDEjercicio""><Caption>IDEjercicio</Caption><DataMember>IDEjercic" & _
        "io</DataMember><Key>IDEjercicio</Key><Position>7</Position><TextAlignment>Near</" & _
        "TextAlignment><Visible>False</Visible></Column7></Columns><GroupCondition ID="""" " & _
        "/></RootTable></GridEXLayoutData>"
        Me.jngDatos.DesignTimeLayout = GridEXLayout1
        Me.jngDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.jngDatos.EntityName = Nothing
        Me.jngDatos.FrozenColumns = 3
        Me.jngDatos.Location = New System.Drawing.Point(0, 0)
        Me.jngDatos.Name = "jngDatos"
        Me.jngDatos.PrimaryDataFields = Nothing
        Me.jngDatos.SecondaryDataFields = Nothing
        Me.jngDatos.Size = New System.Drawing.Size(512, 253)
        Me.jngDatos.TabIndex = 4
        Me.jngDatos.Tag = "IdRec=5773:4961:4352:6679:6680:4398:4758:6681:4681:4999:5047:5767:;"
        Me.jngDatos.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.jngDatos.ViewName = Nothing
        '
        'frmFacturacionProvisional
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(512, 293)
        Me.Controls.Add(Me.jngDatos)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmFacturacionProvisional"
        Me.Text = "Datos Provisionales de Facturación"
        Me.Panel1.ResumeLayout(False)
        CType(Me.jngDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form_Activate()
        jngDatos.Focus()
        cmbOK.Enabled = (jngDatos.RowCount > 0)
    End Sub

    Public Function AbrirFormulario(ByRef dtFacturas As DataTable) As DialogResult
        jngDatos.HoldFields()
        jngDatos.DataSource = dtFacturas
        Me.ShowDialog()

        Return Me.DialogResult
    End Function

    Private Sub cmbOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbOK.Click
        Me.DialogResult = DialogResult.OK
        Dim dt As DataTable = jngDatos.DataSource
        If Not dt Is Nothing AndAlso dt.Rows.Count > 0 Then
            Dim fvc As New FacturaVentaCabecera
            For Each dr As DataRow In dt.Rows
                If Length(dr("FechaFactura")) = 0 Then
                    Me.DialogResult = DialogResult.Cancel
                    ExpertisApp.GenerateMessage("Datos incompletos.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    jngDatos.Focus()
                Else
                    'Hay que saber si la facturación es normal o del proceso B
                    Dim ClsGen As New NegocioGeneral
                    If ClsGen.ContadorB(dr("IDContador")) Then
                        dr("IDEjercicio") = ExpertisApp.ExecuteTask(Of Date, String)(AddressOf EjercicioContable.PredeterminadoB, dr("FechaFactura"))
                    Else
                        dr("IDEjercicio") = ExpertisApp.ExecuteTask(Of Date, String)(AddressOf EjercicioContable.Predeterminado, dr("FechaFactura"))
                    End If
                End If
            Next

            If Me.DialogResult = DialogResult.OK Then
                Me.Close()
            Else
                jngDatos.Focus()
                jngDatos.Col = jngDatos.Columns("FechaFactura").Position
            End If
        End If
    End Sub

    Private Sub cmbCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class