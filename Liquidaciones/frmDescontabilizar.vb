Public Class frmDescontabilizar
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
    Friend WithEvents cmdCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmdAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents GridDiario As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents Grid As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents FraLinSel As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents FraAptesDescontabilizar As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents chkCambiarNoPagado As Solmicro.Expertis.Engine.UI.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim GridDiario_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDescontabilizar))
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.chkCambiarNoPagado = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.cmdCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmdAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.GridDiario = New Solmicro.Expertis.Engine.UI.Grid
        Me.Grid = New Solmicro.Expertis.Engine.UI.Grid
        Me.FraLinSel = New Solmicro.Expertis.Engine.UI.Frame
        Me.FraAptesDescontabilizar = New Solmicro.Expertis.Engine.UI.Frame
        Me.Panel1.suspendlayout()
        CType(Me.GridDiario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FraLinSel.SuspendLayout()
        Me.FraAptesDescontabilizar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.chkCambiarNoPagado)
        Me.Panel1.Controls.Add(Me.cmdCancelar)
        Me.Panel1.Controls.Add(Me.cmdAceptar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 333)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(598, 40)
        Me.Panel1.TabIndex = 11
        '
        'chkCambiarNoPagado
        '
        Me.chkCambiarNoPagado.Location = New System.Drawing.Point(11, 10)
        Me.chkCambiarNoPagado.Name = "chkCambiarNoPagado"
        Me.chkCambiarNoPagado.Size = New System.Drawing.Size(252, 21)
        Me.chkCambiarNoPagado.TabIndex = 82
        Me.chkCambiarNoPagado.Text = "Cambiar a no Pagado"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(509, 8)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(79, 26)
        Me.cmdCancelar.TabIndex = 11
        Me.cmdCancelar.Text = "Cancelar"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Enabled = False
        Me.cmdAceptar.Location = New System.Drawing.Point(421, 8)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(79, 26)
        Me.cmdAceptar.TabIndex = 10
        Me.cmdAceptar.Text = "Aceptar"
        '
        'GridDiario
        '
        Me.GridDiario.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridDiario.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridDiario_DesignTimeLayout.LayoutString = resources.GetString("GridDiario_DesignTimeLayout.LayoutString")
        Me.GridDiario.DesignTimeLayout = GridDiario_DesignTimeLayout
        Me.GridDiario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridDiario.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridDiario.EntityName = "DiarioContable"
        Me.GridDiario.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridDiario.FrozenColumns = 2
        Me.GridDiario.Location = New System.Drawing.Point(3, 17)
        Me.GridDiario.Name = "GridDiario"
        Me.GridDiario.PrimaryDataFields = Nothing
        Me.GridDiario.RequeryManually = True
        Me.GridDiario.SecondaryDataFields = Nothing
        Me.GridDiario.Size = New System.Drawing.Size(592, 172)
        Me.GridDiario.TabIndex = 12
        Me.GridDiario.Tag = "IdRec=4595:4734:4596:4735:4736:4737:4738:4739:;"
        Me.GridDiario.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridDiario.ViewName = "tbDiarioContable"
        '
        'Grid
        '
        Me.Grid.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.Grid.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.Grid.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.Grid.EntityName = "ObraGastoControl"
        Me.Grid.Location = New System.Drawing.Point(3, 17)
        Me.Grid.Name = "Grid"
        Me.Grid.PrimaryDataFields = Nothing
        Me.Grid.RequeryManually = True
        Me.Grid.SecondaryDataFields = Nothing
        Me.Grid.Size = New System.Drawing.Size(592, 121)
        Me.Grid.TabIndex = 15
        Me.Grid.Tag = ""
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.ViewName = "frmGastoDescontabilizar"
        '
        'FraLinSel
        '
        Me.FraLinSel.Controls.Add(Me.Grid)
        Me.FraLinSel.Dock = System.Windows.Forms.DockStyle.Top
        Me.FraLinSel.Location = New System.Drawing.Point(0, 0)
        Me.FraLinSel.Name = "FraLinSel"
        Me.FraLinSel.Size = New System.Drawing.Size(598, 141)
        Me.FraLinSel.TabIndex = 17
        Me.FraLinSel.TabStop = False
        Me.FraLinSel.Text = "Líneas Seleccionadas"
        '
        'FraAptesDescontabilizar
        '
        Me.FraAptesDescontabilizar.Controls.Add(Me.GridDiario)
        Me.FraAptesDescontabilizar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FraAptesDescontabilizar.Location = New System.Drawing.Point(0, 141)
        Me.FraAptesDescontabilizar.Name = "FraAptesDescontabilizar"
        Me.FraAptesDescontabilizar.Size = New System.Drawing.Size(598, 192)
        Me.FraAptesDescontabilizar.TabIndex = 18
        Me.FraAptesDescontabilizar.TabStop = False
        Me.FraAptesDescontabilizar.Text = "Apuntes a Descontabilizar"
        '
        'frmDescontabilizar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(598, 373)
        Me.Controls.Add(Me.FraAptesDescontabilizar)
        Me.Controls.Add(Me.FraLinSel)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmDescontabilizar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Descontabilización"
        Me.Panel1.ResumeLayout(False)
        CType(Me.GridDiario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FraLinSel.ResumeLayout(False)
        Me.FraAptesDescontabilizar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mintTipo As enumTipoLiquidacion
    Private mIDProcess As System.Guid

    Public Function AbrirFormulario(ByVal intTipo As enumTipoLiquidacion, ByVal IDProcess As System.Guid) As DialogResult
        mintTipo = intTipo
        If intTipo = ObrasGeneral.enumTipoLiquidacion.enumTlVarios Then
            Grid.EntityName = "ObraVariosControl"
            Grid.ViewName = "frmVariosDescontabilizar"
            Grid.Columns("ID").Caption = "Varios"
        Else
            Grid.Columns("ID").Caption = "Gastos"
        End If
        mIDProcess = IDProcess

        Me.ShowDialog()

        Return Me.DialogResult
    End Function

    Private Sub frmDescontabilizar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        chkCambiarNoPagado.Checked = True

        'Inicializar Grid de Pagos
        Dim clsFilter As New Filter
        clsFilter.Add(New GuidFilterItem("IDProcess", FilterOperator.Equal, mIDProcess))

        Grid.Filter = clsFilter
        Grid.ReQuery()

        FiltrarGridDiario()
    End Sub

    Private Sub FiltrarGridDiario()
        Dim dtPagos As DataTable = Grid.DataSource
        If Not dtPagos Is Nothing AndAlso dtPagos.Rows.Count > 0 Then
            Dim oFilterOR As New Filter
            oFilterOR.UnionOperator = FilterUnionOperator.Or

            For Each dr As DataRow In dtPagos.Select
                oFilterOR.Add("IDDocumento", dr("IDLinea"))
            Next
            GridDiario.ReQuery(oFilterOR)

            If GridDiario.RecordCount > 0 Then cmdAceptar.Enabled = True
        End If
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        'Comprobamos si algun pago de los que se va a descontabilizar esta agrupado por banco
        'con otro que no se va a descontabilizar. En ese caso habra un descuadre en el grid y no
        'se dejara descontabilizar el pago
        Me.DialogResult = Windows.Forms.DialogResult.None
        If ComprobarDescuadreAsiento() Then
            Dim intNuevaSituacion As Integer = Not chkCambiarNoPagado.Checked

            Dim data As New DataDescontabilizacion(mIDProcess, intNuevaSituacion)
            If mintTipo = ObrasGeneral.enumTipoLiquidacion.enumTlGasto Then
                ExpertisApp.ExecuteTask(Of DataDescontabilizacion)(AddressOf ContabilizacionGastos.Descontabilizar, data)
            Else
                ExpertisApp.ExecuteTask(Of DataDescontabilizacion)(AddressOf ContabilizacionVarios.Descontabilizar, data)
            End If
            Me.DialogResult = DialogResult.OK
        End If
    End Sub

    Private Function ComprobarDescuadreAsiento() As Boolean
        'Comprueba que todos los apuntes del grid pertenecientes a un mismo asiento estan cuadrados.
        'Tendremos asientos descuadrados en el grid cuando no se van a descontabilizar todos los cobros
        'que se han contabilizado agrupados por banco

        Dim dblDebeAsiento, dblHaberAsiento As Double
        Dim strAsientosDescuadrados As String = String.Empty
        Dim intNAsientosNoDescuadrados As Integer = 0
        Dim intAsientoAnt As Integer
        Dim dtGrid As DataTable = GridDiario.DataSource

        Dim dv As DataView = dtGrid.DefaultView
        dv.Sort = "IDEjercicio, NAsiento ASC"
        If dv.Count > 0 Then
            Dim IDEjercicioAnt As String = dtGrid.DefaultView(0).Row("IDEjercicio")
            intAsientoAnt = dtGrid.DefaultView(0).Row("NAsiento")

            For Each drv As DataRowView In dtGrid.DefaultView
                Dim dr As DataRow = drv.Row
                If dr("NAsiento") <> intAsientoAnt OrElse dr("IDEjercicio") <> IDEjercicioAnt Then
                    If dblHaberAsiento <> dblDebeAsiento Then
                        strAsientosDescuadrados = strAsientosDescuadrados & intAsientoAnt & ", "
                    Else
                        intNAsientosNoDescuadrados = intNAsientosNoDescuadrados + 1
                    End If
                    dblDebeAsiento = 0
                    dblHaberAsiento = 0
                End If
                dblDebeAsiento = dblDebeAsiento + dr("ImpDebeA")
                dblHaberAsiento = dblHaberAsiento + dr("ImpHaberA")
                intAsientoAnt = dr("NAsiento")
                IDEjercicioAnt = dr("IDEjercicio")
            Next
        End If
        If dblHaberAsiento <> dblDebeAsiento Then
            strAsientosDescuadrados = strAsientosDescuadrados & intAsientoAnt & ", "
        Else
            intNAsientosNoDescuadrados = intNAsientosNoDescuadrados + 1
        End If
        If Len(strAsientosDescuadrados) > 0 Then
            strAsientosDescuadrados = Microsoft.VisualBasic.Left(strAsientosDescuadrados, Len(strAsientosDescuadrados) - Len(", "))
        End If

        Dim blnContinuar As Boolean = True
        If Len(strAsientosDescuadrados) > 0 Then
            ExpertisApp.GenerateMessage("No se pueden borrar de forma automática algunos asientos porque se crearian asientos descuadrados. Debe descontabilizar de manera conjunta todos los cobros agrupados en los asientos: |", MessageBoxButtons.OK, MessageBoxIcon.Information, strAsientosDescuadrados)
            blnContinuar = False
        End If

        If blnContinuar And intNAsientosNoDescuadrados > 0 Then
            If ExpertisApp.GenerateMessage("Se eliminarán todos los apuntes contables de los pagos contabilizados seleccionados.", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then
                blnContinuar = False
            End If
        End If

        Return blnContinuar
    End Function

End Class
