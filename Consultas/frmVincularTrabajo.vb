Public Class frmVincularTrabajo
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
    Friend WithEvents pnlBotones As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents pnlFicha As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents fraConfigConceptos As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents pnlGeneral As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents chkVarios As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkGastos As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkCentros As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkMod As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkMateriales As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkConceptosAll As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents pnlTrabajo As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents lblTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvIDTrabajo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents chkAplicarPrimerNivel As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkAplicarMultinivel As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents CmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmbCancelar As Solmicro.Expertis.Engine.UI.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.pnlBotones = New Solmicro.Expertis.Engine.UI.Panel
        Me.pnlFicha = New Solmicro.Expertis.Engine.UI.Panel
        Me.fraConfigConceptos = New Solmicro.Expertis.Engine.UI.Frame
        Me.pnlGeneral = New Solmicro.Expertis.Engine.UI.Panel
        Me.chkAplicarPrimerNivel = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkAplicarMultinivel = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkVarios = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkGastos = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkCentros = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkMod = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkMateriales = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkConceptosAll = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.pnlTrabajo = New Solmicro.Expertis.Engine.UI.Panel
        Me.AdvIDTrabajo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.CmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.pnlBotones.suspendlayout()
        Me.pnlFicha.suspendlayout()
        Me.fraConfigConceptos.SuspendLayout()
        Me.pnlGeneral.suspendlayout()
        Me.pnlTrabajo.suspendlayout()
        Me.SuspendLayout()
        '
        'pnlBotones
        '
        Me.pnlBotones.Controls.Add(Me.CmbAceptar)
        Me.pnlBotones.Controls.Add(Me.cmbCancelar)
        Me.pnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBotones.Location = New System.Drawing.Point(0, 230)
        Me.pnlBotones.Name = "pnlBotones"
        Me.pnlBotones.Size = New System.Drawing.Size(344, 48)
        Me.pnlBotones.TabIndex = 3
        '
        'pnlFicha
        '
        Me.pnlFicha.Controls.Add(Me.fraConfigConceptos)
        Me.pnlFicha.Controls.Add(Me.pnlTrabajo)
        Me.pnlFicha.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFicha.DockPadding.Left = 5
        Me.pnlFicha.DockPadding.Right = 5
        Me.pnlFicha.Location = New System.Drawing.Point(0, 0)
        Me.pnlFicha.Name = "pnlFicha"
        Me.pnlFicha.Size = New System.Drawing.Size(344, 230)
        Me.pnlFicha.TabIndex = 0
        '
        'fraConfigConceptos
        '
        Me.fraConfigConceptos.Controls.Add(Me.pnlGeneral)
        Me.fraConfigConceptos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fraConfigConceptos.Location = New System.Drawing.Point(5, 40)
        Me.fraConfigConceptos.Name = "fraConfigConceptos"
        Me.fraConfigConceptos.Size = New System.Drawing.Size(334, 190)
        Me.fraConfigConceptos.TabIndex = 2
        Me.fraConfigConceptos.TabStop = False
        Me.fraConfigConceptos.Text = "Copiar los Conceptos asociados al Trabajo vinculado"
        '
        'pnlGeneral
        '
        Me.pnlGeneral.Controls.Add(Me.chkAplicarPrimerNivel)
        Me.pnlGeneral.Controls.Add(Me.chkAplicarMultinivel)
        Me.pnlGeneral.Controls.Add(Me.chkVarios)
        Me.pnlGeneral.Controls.Add(Me.chkGastos)
        Me.pnlGeneral.Controls.Add(Me.chkCentros)
        Me.pnlGeneral.Controls.Add(Me.chkMod)
        Me.pnlGeneral.Controls.Add(Me.chkMateriales)
        Me.pnlGeneral.Controls.Add(Me.chkConceptosAll)
        Me.pnlGeneral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGeneral.Location = New System.Drawing.Point(3, 17)
        Me.pnlGeneral.Name = "pnlGeneral"
        Me.pnlGeneral.Size = New System.Drawing.Size(328, 170)
        Me.pnlGeneral.TabIndex = 3
        '
        'chkAplicarPrimerNivel
        '
        Me.chkAplicarPrimerNivel.Location = New System.Drawing.Point(48, 124)
        Me.chkAplicarPrimerNivel.Name = "chkAplicarPrimerNivel"
        Me.chkAplicarPrimerNivel.Size = New System.Drawing.Size(222, 21)
        Me.chkAplicarPrimerNivel.TabIndex = 7
        Me.chkAplicarPrimerNivel.Text = "Aplicar al primer nivel"
        '
        'chkAplicarMultinivel
        '
        Me.chkAplicarMultinivel.Location = New System.Drawing.Point(48, 144)
        Me.chkAplicarMultinivel.Name = "chkAplicarMultinivel"
        Me.chkAplicarMultinivel.Size = New System.Drawing.Size(222, 21)
        Me.chkAplicarMultinivel.TabIndex = 8
        Me.chkAplicarMultinivel.Text = "Aplicar multinivel"
        '
        'chkVarios
        '
        Me.chkVarios.Location = New System.Drawing.Point(70, 102)
        Me.chkVarios.Name = "chkVarios"
        Me.chkVarios.Size = New System.Drawing.Size(220, 21)
        Me.chkVarios.TabIndex = 6
        Me.chkVarios.Text = "Copiar el Concepto de Varios"
        '
        'chkGastos
        '
        Me.chkGastos.Location = New System.Drawing.Point(70, 82)
        Me.chkGastos.Name = "chkGastos"
        Me.chkGastos.Size = New System.Drawing.Size(220, 21)
        Me.chkGastos.TabIndex = 5
        Me.chkGastos.Text = "Copiar el Concepto de Gastos"
        '
        'chkCentros
        '
        Me.chkCentros.Location = New System.Drawing.Point(70, 63)
        Me.chkCentros.Name = "chkCentros"
        Me.chkCentros.Size = New System.Drawing.Size(220, 21)
        Me.chkCentros.TabIndex = 4
        Me.chkCentros.Text = "Copiar el Concepto de Centros"
        '
        'chkMod
        '
        Me.chkMod.Location = New System.Drawing.Point(70, 44)
        Me.chkMod.Name = "chkMod"
        Me.chkMod.Size = New System.Drawing.Size(220, 21)
        Me.chkMod.TabIndex = 3
        Me.chkMod.Text = "Copiar el Concepto de M.O.D."
        '
        'chkMateriales
        '
        Me.chkMateriales.Location = New System.Drawing.Point(70, 25)
        Me.chkMateriales.Name = "chkMateriales"
        Me.chkMateriales.Size = New System.Drawing.Size(220, 21)
        Me.chkMateriales.TabIndex = 2
        Me.chkMateriales.Text = "Copiar el Concepto de Materiales"
        '
        'chkConceptosAll
        '
        Me.chkConceptosAll.Location = New System.Drawing.Point(48, 4)
        Me.chkConceptosAll.Name = "chkConceptosAll"
        Me.chkConceptosAll.Size = New System.Drawing.Size(222, 21)
        Me.chkConceptosAll.TabIndex = 1
        Me.chkConceptosAll.Text = "Copiar todos los Conceptos"
        '
        'pnlTrabajo
        '
        Me.pnlTrabajo.Controls.Add(Me.AdvIDTrabajo)
        Me.pnlTrabajo.Controls.Add(Me.lblTrabajo)
        Me.pnlTrabajo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTrabajo.Location = New System.Drawing.Point(5, 0)
        Me.pnlTrabajo.Name = "pnlTrabajo"
        Me.pnlTrabajo.Size = New System.Drawing.Size(334, 40)
        Me.pnlTrabajo.TabIndex = 1
        '
        'AdvIDTrabajo
        '
        Me.AdvIDTrabajo.DisplayField = "CodTrabajo"
        Me.AdvIDTrabajo.EntityName = "ObraTrabajo"
        Me.AdvIDTrabajo.Location = New System.Drawing.Point(136, 9)
        Me.AdvIDTrabajo.Name = "AdvIDTrabajo"
        Me.AdvIDTrabajo.SecondaryDataFields = "IDTrabajo"
        Me.AdvIDTrabajo.Size = New System.Drawing.Size(105, 23)
        Me.AdvIDTrabajo.TabIndex = 1
        Me.AdvIDTrabajo.ViewName = "tbObraTrabajo"
        '
        'lblTrabajo
        '
        Me.lblTrabajo.Location = New System.Drawing.Point(22, 12)
        Me.lblTrabajo.Name = "lblTrabajo"
        Me.lblTrabajo.Size = New System.Drawing.Size(106, 17)
        Me.lblTrabajo.TabIndex = 127
        Me.lblTrabajo.Tag = ""
        Me.lblTrabajo.Text = "Trabajo Vinculado"
        '
        'CmbAceptar
        '
        Me.CmbAceptar.Location = New System.Drawing.Point(75, 10)
        Me.CmbAceptar.Name = "CmbAceptar"
        Me.CmbAceptar.Size = New System.Drawing.Size(94, 29)
        Me.CmbAceptar.TabIndex = 3
        Me.CmbAceptar.Text = "Aceptar"
        '
        'cmbCancelar
        '
        Me.cmbCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmbCancelar.Location = New System.Drawing.Point(175, 10)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(94, 29)
        Me.cmbCancelar.TabIndex = 4
        Me.cmbCancelar.Text = "Cancelar"
        '
        'frmVincularTrabajo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(344, 278)
        Me.Controls.Add(Me.pnlFicha)
        Me.Controls.Add(Me.pnlBotones)
        Me.Name = "frmVincularTrabajo"
        Me.Text = "Seleccione un trabajo"
        Me.pnlBotones.ResumeLayout(False)
        Me.pnlFicha.ResumeLayout(False)
        Me.fraConfigConceptos.ResumeLayout(False)
        Me.pnlGeneral.ResumeLayout(False)
        Me.pnlTrabajo.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public IDObraVincular As Integer

    Public WriteOnly Property DesVincular() As Boolean
        Set(ByVal Value As Boolean)
            Me.Text = ExpertisApp.Traslate("Desvincular Trabajos")
            pnlTrabajo.Visible = False
            fraConfigConceptos.Text = ExpertisApp.Traslate("Borrar los Conceptos asociados al Trabajo vinculado")
            chkConceptosAll.Text = ExpertisApp.Traslate("Borrar todos los Conceptos")
            chkMateriales.Text = ExpertisApp.Traslate("Borrar los Conceptos de Materiales")
            chkMod.Text = ExpertisApp.Traslate("Borrar los Conceptos de M.O.D.")
            chkCentros.Text = ExpertisApp.Traslate("Borrar los Conceptos de Centros")
            chkGastos.Text = ExpertisApp.Traslate("Borrar los Conceptos de Gastos")
            chkVarios.Text = ExpertisApp.Traslate("Borrar los Conceptos de Varios")
        End Set
    End Property

    Private blnMarcoAll As Boolean
    Public infoConfig As ObraTrabajo.DatosInfoTrabajoAgrupador

    Private Sub frmTrabajoAgrupador_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        chkConceptosAll.Checked = True
    End Sub

    Private Sub TodosMarcados()
        If chkMateriales.Checked And chkMod.Checked And chkCentros.Checked And chkGastos.Checked And chkVarios.Checked Then
            chkConceptosAll.Checked = True
        Else
            chkConceptosAll.Checked = False
        End If
    End Sub

    Private Sub Conceptos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkVarios.CheckedChanged, chkGastos.CheckedChanged, chkCentros.CheckedChanged, chkMod.CheckedChanged, chkMateriales.CheckedChanged
        If Not blnMarcoAll Then TodosMarcados()
    End Sub

    Private Sub chkConceptosAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkConceptosAll.CheckedChanged
        blnMarcoAll = True
        If chkConceptosAll.Checked Then
            chkMateriales.Checked = chkConceptosAll.Checked
            chkMod.Checked = chkConceptosAll.Checked
            chkCentros.Checked = chkConceptosAll.Checked
            chkGastos.Checked = chkConceptosAll.Checked
            chkVarios.Checked = chkConceptosAll.Checked
        End If
        blnMarcoAll = False
    End Sub

    Private Sub chkAplicarPrimerNivel_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkAplicarPrimerNivel.CheckedChanged
        If chkAplicarPrimerNivel.Checked Then chkAplicarMultinivel.Checked = False
    End Sub

    Private Sub chkAplicarMultinivel_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkAplicarMultinivel.CheckedChanged
        If chkAplicarMultinivel.Checked Then chkAplicarPrimerNivel.Checked = False
    End Sub

    Private Sub CmbAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbAceptar.Click
        Me.DialogResult = DialogResult.None
        If (pnlTrabajo.Visible AndAlso Length(AdvIDTrabajo.Value) > 0) Or Not pnlTrabajo.Visible Then
            Me.DialogResult = DialogResult.OK
            infoConfig = New ObraTrabajo.DatosInfoTrabajoAgrupador

            If pnlTrabajo.Visible Then infoConfig.IDTrabajoControlRelacionado = AdvIDTrabajo.Value
            infoConfig.TratarMateriales = chkMateriales.Checked
            infoConfig.TratarMOD = chkMod.Checked
            infoConfig.TratarCentros = chkCentros.Checked
            infoConfig.TratarGastos = chkGastos.Checked
            infoConfig.TratarVarios = chkVarios.Checked
            infoConfig.AplicarPrimerNivel = chkAplicarPrimerNivel.Checked
            infoConfig.AplicarMultiNivel = chkAplicarMultinivel.Checked
        Else
            ExpertisApp.GenerateMessage("El Trabajo es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub AdvIDTrabajo_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles AdvIDTrabajo.SetPredefinedFilter
        e.Filter.Add(New NumberFilterItem("IDObra", IDObraVincular))
        e.Filter.Add(New NumberFilterItem("IDClase", enumClaseObra.Control))
    End Sub

End Class
