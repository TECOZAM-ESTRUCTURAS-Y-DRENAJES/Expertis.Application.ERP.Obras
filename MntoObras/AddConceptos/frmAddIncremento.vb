Public Class frmAddIncremento
    Inherits Solmicro.Expertis.Engine.UI.FormBase

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        txtSecuencia.Value = System.DBNull.Value
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
    Friend WithEvents FraConfigAddPorcentaje As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents chkAddTodos As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents cmbCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents CmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents txtSecuencia As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblIncremento As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblSecuencia As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblAsterisco As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblTextoInfo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents chkAddCentros As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkAddMOD As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkAddMateriales As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents AdvIncremento As Solmicro.Expertis.Engine.UI.AdvSearch
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.CmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.FraConfigAddPorcentaje = New Solmicro.Expertis.Engine.UI.Frame
        Me.chkAddCentros = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkAddMOD = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkAddMateriales = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkAddTodos = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.lblIncremento = New Solmicro.Expertis.Engine.UI.Label
        Me.lblSecuencia = New Solmicro.Expertis.Engine.UI.Label
        Me.txtSecuencia = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblAsterisco = New Solmicro.Expertis.Engine.UI.Label
        Me.lblTextoInfo = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIncremento = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.Panel1.suspendlayout()
        Me.FraConfigAddPorcentaje.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbCancelar)
        Me.Panel1.Controls.Add(Me.CmbAceptar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 147)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(320, 42)
        Me.Panel1.TabIndex = 231
        '
        'cmbCancelar
        '
        Me.cmbCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmbCancelar.Location = New System.Drawing.Point(163, 7)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(94, 29)
        Me.cmbCancelar.TabIndex = 7
        Me.cmbCancelar.Text = "Cancelar"
        '
        'CmbAceptar
        '
        Me.CmbAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.CmbAceptar.Location = New System.Drawing.Point(63, 7)
        Me.CmbAceptar.Name = "CmbAceptar"
        Me.CmbAceptar.Size = New System.Drawing.Size(94, 29)
        Me.CmbAceptar.TabIndex = 6
        Me.CmbAceptar.Text = "Aceptar"
        '
        'FraConfigAddPorcentaje
        '
        Me.FraConfigAddPorcentaje.Controls.Add(Me.chkAddCentros)
        Me.FraConfigAddPorcentaje.Controls.Add(Me.chkAddMOD)
        Me.FraConfigAddPorcentaje.Controls.Add(Me.chkAddMateriales)
        Me.FraConfigAddPorcentaje.Controls.Add(Me.chkAddTodos)
        Me.FraConfigAddPorcentaje.Dock = System.Windows.Forms.DockStyle.Top
        Me.FraConfigAddPorcentaje.Location = New System.Drawing.Point(0, 0)
        Me.FraConfigAddPorcentaje.Name = "FraConfigAddPorcentaje"
        Me.FraConfigAddPorcentaje.Size = New System.Drawing.Size(320, 56)
        Me.FraConfigAddPorcentaje.TabIndex = 232
        Me.FraConfigAddPorcentaje.TabStop = False
        Me.FraConfigAddPorcentaje.Text = "Nuevo Porcentaje para ..."
        '
        'chkAddCentros
        '
        Me.chkAddCentros.Location = New System.Drawing.Point(176, 20)
        Me.chkAddCentros.Name = "chkAddCentros"
        Me.chkAddCentros.Size = New System.Drawing.Size(72, 21)
        Me.chkAddCentros.TabIndex = 2
        Me.chkAddCentros.Text = "Centros"
        '
        'chkAddMOD
        '
        Me.chkAddMOD.Location = New System.Drawing.Point(104, 20)
        Me.chkAddMOD.Name = "chkAddMOD"
        Me.chkAddMOD.Size = New System.Drawing.Size(66, 21)
        Me.chkAddMOD.TabIndex = 1
        Me.chkAddMOD.Text = "M.O.D."
        '
        'chkAddMateriales
        '
        Me.chkAddMateriales.Location = New System.Drawing.Point(14, 20)
        Me.chkAddMateriales.Name = "chkAddMateriales"
        Me.chkAddMateriales.Size = New System.Drawing.Size(85, 21)
        Me.chkAddMateriales.TabIndex = 0
        Me.chkAddMateriales.Text = "Materiales"
        '
        'chkAddTodos
        '
        Me.chkAddTodos.Location = New System.Drawing.Point(256, 20)
        Me.chkAddTodos.Name = "chkAddTodos"
        Me.chkAddTodos.Size = New System.Drawing.Size(72, 21)
        Me.chkAddTodos.TabIndex = 3
        Me.chkAddTodos.Text = "Todos"
        '
        'lblIncremento
        '
        Me.lblIncremento.Location = New System.Drawing.Point(40, 96)
        Me.lblIncremento.Name = "lblIncremento"
        Me.lblIncremento.Size = New System.Drawing.Size(70, 17)
        Me.lblIncremento.TabIndex = 250
        Me.lblIncremento.Tag = ""
        Me.lblIncremento.Text = "Incremento"
        '
        'lblSecuencia
        '
        Me.lblSecuencia.Location = New System.Drawing.Point(40, 71)
        Me.lblSecuencia.Name = "lblSecuencia"
        Me.lblSecuencia.Size = New System.Drawing.Size(61, 17)
        Me.lblSecuencia.TabIndex = 251
        Me.lblSecuencia.Tag = ""
        Me.lblSecuencia.Text = "Secuencia"
        '
        'txtSecuencia
        '
        Me.txtSecuencia.DecimalDigits = 0
        Me.txtSecuencia.Location = New System.Drawing.Point(128, 71)
        Me.txtSecuencia.Name = "txtSecuencia"
        Me.txtSecuencia.NullBehavior = Janus.Windows.GridEX.NumericEditNullBehavior.AllowNull
        Me.txtSecuencia.Size = New System.Drawing.Size(100, 21)
        Me.txtSecuencia.TabIndex = 4
        '
        'lblAsterisco
        '
        Me.lblAsterisco.ForeColor = System.Drawing.Color.Red
        Me.lblAsterisco.Location = New System.Drawing.Point(232, 72)
        Me.lblAsterisco.Name = "lblAsterisco"
        Me.lblAsterisco.Size = New System.Drawing.Size(26, 18)
        Me.lblAsterisco.TabIndex = 252
        Me.lblAsterisco.Text = "(*)"
        '
        'lblTextoInfo
        '
        Me.lblTextoInfo.ForeColor = System.Drawing.Color.Red
        Me.lblTextoInfo.Location = New System.Drawing.Point(12, 128)
        Me.lblTextoInfo.Name = "lblTextoInfo"
        Me.lblTextoInfo.Size = New System.Drawing.Size(296, 19)
        Me.lblTextoInfo.TabIndex = 253
        Me.lblTextoInfo.Text = "(*) Por defecto será el número de registros + 10"
        '
        'AdvIncremento
        '
        Me.AdvIncremento.DisplayField = "CodTrabajo"
        Me.AdvIncremento.EntityName = "ObraTrabajo"
        Me.AdvIncremento.Location = New System.Drawing.Point(128, 96)
        Me.AdvIncremento.Name = "AdvIncremento"
        Me.AdvIncremento.SecondaryDataFields = "IDTrabajo"
        Me.AdvIncremento.Size = New System.Drawing.Size(100, 21)
        Me.AdvIncremento.TabIndex = 5
        '
        'frmAddIncremento
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(320, 189)
        Me.Controls.Add(Me.AdvIncremento)
        Me.Controls.Add(Me.lblTextoInfo)
        Me.Controls.Add(Me.lblAsterisco)
        Me.Controls.Add(Me.lblIncremento)
        Me.Controls.Add(Me.lblSecuencia)
        Me.Controls.Add(Me.txtSecuencia)
        Me.Controls.Add(Me.FraConfigAddPorcentaje)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.Name = "frmAddIncremento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta de Incrementos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Normal
        Me.Panel1.ResumeLayout(False)
        Me.FraConfigAddPorcentaje.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Enum AplicarPorcentajeA
        apMaterial = 0
        apMod = 1
        apCentro = 2
        apTodos = 3
    End Enum

    Private mdrTrabajo As DataRow
    Private mblnCancel, blnMarcoAll As Boolean
    Private mintIDTrabajoIncremento As Integer
    Private mdblIncremento As Double
    Private mstrDescTrabajo As String

#Region " Load "

    Public Sub AbrirADDIncrementos(ByVal IncrementoA As AplicarPorcentajeA, ByVal drTrabajo As DataRow)
        mdrTrabajo = drTrabajo
        Select Case IncrementoA
            Case AplicarPorcentajeA.apMaterial
                chkAddMateriales.Checked = True
            Case AplicarPorcentajeA.apMod
                chkAddMOD.Checked = True
            Case AplicarPorcentajeA.apCentro
                chkAddCentros.Checked = True
            Case AplicarPorcentajeA.apTodos
                chkAddTodos.Checked = True
        End Select
        If mdrTrabajo("TipoLinea") = enumTipoLineaTrabajo.tltPorcentajeConcepto Then
            AdvIncremento.Text = drTrabajo("CodTrabajo") & String.Empty
            mintIDTrabajoIncremento = drTrabajo("IDTrabajo")
            mdblIncremento = drTrabajo("ImpPrevTrabajoA") * 100
        End If

        Dim frm As New Form
        frm = Me
        frm.ShowDialog() 'Para que no traiga todos los registros
    End Sub

#End Region

#Region " Tratamiento Checks "

    Private Sub TodosMarcados()
        If chkAddMateriales.Checked And chkAddMOD.Checked And chkAddCentros.Checked Then
            chkAddTodos.Checked = True
        Else
            chkAddTodos.Checked = False
        End If
    End Sub

    Private Sub Conceptos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAddMateriales.CheckedChanged, chkAddMOD.CheckedChanged, chkAddCentros.CheckedChanged
        If Not blnMarcoAll Then TodosMarcados()
    End Sub

    Private Sub chkAddTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAddTodos.CheckedChanged
        blnMarcoAll = True
        If chkAddTodos.Checked Then
            chkAddMateriales.Checked = chkAddTodos.Checked
            chkAddMOD.Checked = chkAddTodos.Checked
            chkAddCentros.Checked = chkAddTodos.Checked
        End If
        chkAddTodos.Enabled = Not chkAddTodos.Checked
        blnMarcoAll = False
    End Sub

#End Region

    Private Sub AdvIncremento_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles AdvIncremento.SetPredefinedFilter
        If Length(mdrTrabajo("IDObra")) > 0 Then
            e.Filter.Add(New NumberFilterItem("IDObra", mdrTrabajo("IDObra")))
        End If
        e.Filter.Add(New NumberFilterItem("TipoLinea", enumTipoLineaTrabajo.tltPorcentajeConcepto))
    End Sub

    Private Sub AdvIncremento_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles AdvIncremento.SelectionChanged
        If Not IsNothing(e.Selected) AndAlso Length(e.Selected.Rows(0)("IDTrabajo")) > 0 Then
            mintIDTrabajoIncremento = e.Selected.Rows(0)("IDTrabajo")
            mdblIncremento = e.Selected.Rows(0)("ImpPrevTrabajoA") * 100
            mstrDescTrabajo = e.Selected.Rows(0)("DescTrabajo") & String.Empty
        End If
    End Sub

    Private Sub CmbAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbAceptar.Click
        If Not chkAddMateriales.Checked AndAlso Not chkAddMOD.Checked AndAlso Not chkAddCentros.Checked Then
            mblnCancel = True
            ExpertisApp.GenerateMessage("Debe seleccionar, como mínimo, un concepto donde generar el incremento.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 'El Cod. Trabajo es un dato obligatorio.
        ElseIf Length(AdvIncremento.Value) > 0 Then
            Dim info As New Incrementos.dataIncrementos
            info.blnMaterial = chkAddMateriales.Checked
            info.blnMOD = chkAddMOD.Checked
            info.blnCentros = chkAddCentros.Checked
            info.TipoLinea = mdrTrabajo("TipoLinea")
            info.IDObra = mdrTrabajo("IDObra")
            info.IDTrabajo = mdrTrabajo("IDTrabajo")
            info.DescTrabajo = mstrDescTrabajo
            info.IDTrabajoIncremento = mintIDTrabajoIncremento
            info.Incremento = mdblIncremento
            info.Secuencia = txtSecuencia.Value

            ExpertisApp.ExecuteTask(Of Incrementos.dataIncrementos)(AddressOf Incrementos.ADDPorcentajesObras, info)

            Me.DialogResult = DialogResult.OK
            mblnCancel = False
            Me.Close()
        Else
            mblnCancel = True
            ExpertisApp.GenerateMessage("El Incremento ha de ser mayor que cero.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 'El Cod. Trabajo es un dato obligatorio.
        End If
    End Sub

    Private Sub cmbCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCancelar.Click
        mblnCancel = False
        Me.Close()
    End Sub

    Private Sub frmAddIncremento_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = mblnCancel
    End Sub

End Class

