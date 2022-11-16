Public Class frmConfiguraInforme
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
    Friend WithEvents FraConfiguracion As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents chkVarios As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkGastos As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkCentros As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkMod As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkConceptosAll As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkMateriales As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents cmbCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents CmbAceptar As Solmicro.Expertis.Engine.UI.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.chkVarios = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkGastos = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkCentros = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkMod = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkConceptosAll = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkMateriales = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.FraConfiguracion = New Solmicro.Expertis.Engine.UI.Frame
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.CmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.Panel1.suspendlayout()
        Me.SuspendLayout()
        '
        'chkVarios
        '
        Me.chkVarios.Location = New System.Drawing.Point(50, 119)
        Me.chkVarios.Name = "chkVarios"
        Me.chkVarios.Size = New System.Drawing.Size(200, 21)
        Me.chkVarios.TabIndex = 6
        Me.chkVarios.Text = "Imprimir el Concepto de Varios"
        '
        'chkGastos
        '
        Me.chkGastos.Location = New System.Drawing.Point(50, 101)
        Me.chkGastos.Name = "chkGastos"
        Me.chkGastos.Size = New System.Drawing.Size(200, 21)
        Me.chkGastos.TabIndex = 5
        Me.chkGastos.Text = "Imprimir el Concepto de Gastos"
        '
        'chkCentros
        '
        Me.chkCentros.Location = New System.Drawing.Point(50, 83)
        Me.chkCentros.Name = "chkCentros"
        Me.chkCentros.Size = New System.Drawing.Size(214, 21)
        Me.chkCentros.TabIndex = 4
        Me.chkCentros.Text = "Imprimir el Concepto de Centros"
        '
        'chkMod
        '
        Me.chkMod.Location = New System.Drawing.Point(50, 65)
        Me.chkMod.Name = "chkMod"
        Me.chkMod.Size = New System.Drawing.Size(214, 21)
        Me.chkMod.TabIndex = 3
        Me.chkMod.Text = "Imprimir el Concepto de M.O.D."
        '
        'chkConceptosAll
        '
        Me.chkConceptosAll.Location = New System.Drawing.Point(24, 24)
        Me.chkConceptosAll.Name = "chkConceptosAll"
        Me.chkConceptosAll.Size = New System.Drawing.Size(222, 21)
        Me.chkConceptosAll.TabIndex = 1
        Me.chkConceptosAll.Text = "Imprimir todos los Conceptos"
        '
        'chkMateriales
        '
        Me.chkMateriales.Location = New System.Drawing.Point(50, 47)
        Me.chkMateriales.Name = "chkMateriales"
        Me.chkMateriales.Size = New System.Drawing.Size(222, 21)
        Me.chkMateriales.TabIndex = 2
        Me.chkMateriales.Text = "Imprimir el Concepto de Materiales"
        '
        'FraConfiguracion
        '
        Me.FraConfiguracion.Location = New System.Drawing.Point(6, 3)
        Me.FraConfiguracion.Name = "FraConfiguracion"
        Me.FraConfiguracion.Size = New System.Drawing.Size(274, 149)
        Me.FraConfiguracion.TabIndex = 0
        Me.FraConfiguracion.TabStop = False
        Me.FraConfiguracion.Text = "Configuración impresión"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbCancelar)
        Me.Panel1.Controls.Add(Me.CmbAceptar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 158)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(288, 40)
        Me.Panel1.TabIndex = 9
        '
        'cmbCancelar
        '
        Me.cmbCancelar.Location = New System.Drawing.Point(149, 6)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(94, 29)
        Me.cmbCancelar.TabIndex = 8
        Me.cmbCancelar.Text = "Cancelar"
        '
        'CmbAceptar
        '
        Me.CmbAceptar.Location = New System.Drawing.Point(46, 6)
        Me.CmbAceptar.Name = "CmbAceptar"
        Me.CmbAceptar.Size = New System.Drawing.Size(94, 29)
        Me.CmbAceptar.TabIndex = 7
        Me.CmbAceptar.Text = "Aceptar"
        '
        'frmConfiguraInforme
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(288, 198)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.chkVarios)
        Me.Controls.Add(Me.chkGastos)
        Me.Controls.Add(Me.chkCentros)
        Me.Controls.Add(Me.chkMod)
        Me.Controls.Add(Me.chkConceptosAll)
        Me.Controls.Add(Me.chkMateriales)
        Me.Controls.Add(Me.FraConfiguracion)
        Me.Name = "frmConfiguraInforme"
        Me.Text = "Configuración"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mPestañaSeleccionada As String
    Private blnMarcoAll As Boolean
    Private info As New infoConceptosImprimir

    Public Function AbrirConfiguracion(ByVal PestañaSeleccionada As String) As infoConceptosImprimir
        mPestañaSeleccionada = PestañaSeleccionada

        Me.ShowDialog()
        Return info
    End Function

    Private Sub frmConfiguraInforme_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Select Case mPestañaSeleccionada
            Case "Materiales"
                chkMateriales.Checked = True
            Case "MOD"
                chkMod.Checked = True
            Case "Centros"
                chkCentros.Checked = True
            Case "Gastos"
                chkGastos.Checked = True
            Case "Varios"
                chkVarios.Checked = True
            Case Else
                chkConceptosAll.Checked = True
        End Select
    End Sub

    Private Sub TodosMarcados()
        If chkMateriales.Checked And chkMod.Checked And chkCentros.Checked And chkGastos.Checked And chkVarios.Checked Then
            chkConceptosAll.Checked = True
        Else
            chkConceptosAll.Checked = False
        End If
    End Sub

    Private Sub Conceptos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMateriales.CheckedChanged, chkMod.CheckedChanged, chkCentros.CheckedChanged, chkGastos.CheckedChanged, chkVarios.CheckedChanged
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

    Private Sub cmbCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCancelar.Click
        info.Cancel = True
        Me.Close()
    End Sub

    Private Sub CmbAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbAceptar.Click
        If ExpertisApp.GenerateMessage("Se imprimirán las Estadísticas de los conceptos seleccionados. ¿Desea continuar?.", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then
            info.Cancel = True
        End If
        If Not info.Cancel Then
            Me.DialogResult = DialogResult.OK
            info.Material = chkMateriales.Checked
            info.ManoObra = chkMod.Checked
            info.Centro = chkCentros.Checked
            info.Gasto = chkGastos.Checked
            info.Varios = chkVarios.Checked
            Me.Close()
        End If
    End Sub

End Class
