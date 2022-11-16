Public Class frmSeleccionInformeCertificacion
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
    Friend WithEvents FrmTipoInforme As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents BtnAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents BtnCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents RadioconIVA As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents RadiosinIVA As Solmicro.Expertis.Engine.UI.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.FrmTipoInforme = New Solmicro.Expertis.Engine.UI.Frame
        Me.RadioconIVA = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.RadiosinIVA = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.BtnAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.BtnCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.FrmTipoInforme.SuspendLayout()
        Me.SuspendLayout()
        '
        'FrmTipoInforme
        '
        Me.FrmTipoInforme.Controls.Add(Me.RadioconIVA)
        Me.FrmTipoInforme.Controls.Add(Me.RadiosinIVA)
        Me.FrmTipoInforme.Location = New System.Drawing.Point(8, 8)
        Me.FrmTipoInforme.Name = "FrmTipoInforme"
        Me.FrmTipoInforme.Size = New System.Drawing.Size(216, 104)
        Me.FrmTipoInforme.TabIndex = 0
        Me.FrmTipoInforme.TabStop = False
        Me.FrmTipoInforme.Text = "Seleccione un Tipo de Informe"
        '
        'RadioconIVA
        '
        Me.RadioconIVA.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RadioconIVA.Location = New System.Drawing.Point(24, 64)
        Me.RadioconIVA.Name = "RadioconIVA"
        Me.RadioconIVA.Size = New System.Drawing.Size(160, 23)
        Me.RadioconIVA.TabIndex = 1
        Me.RadioconIVA.Text = "Informe con I.V.A."
        '
        'RadiosinIVA
        '
        Me.RadiosinIVA.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RadiosinIVA.Location = New System.Drawing.Point(24, 24)
        Me.RadiosinIVA.Name = "RadiosinIVA"
        Me.RadiosinIVA.Size = New System.Drawing.Size(160, 23)
        Me.RadiosinIVA.TabIndex = 0
        Me.RadiosinIVA.Text = "Informe sin I.V.A."
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(8, 120)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(88, 32)
        Me.BtnAceptar.TabIndex = 1
        Me.BtnAceptar.Text = "&Aceptar"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(128, 120)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(88, 32)
        Me.BtnCancelar.TabIndex = 2
        Me.BtnCancelar.Text = "&Cancelar"
        '
        'frmSeleccionInformeCertificacion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(234, 159)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.FrmTipoInforme)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSeleccionInformeCertificacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informes Certificaciones"
        Me.WindowState = System.Windows.Forms.FormWindowState.Normal
        Me.FrmTipoInforme.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


    Dim MIntTipo As Integer

    Public ReadOnly Property TipoInforme() As Integer
        Get
            Return MIntTipo
        End Get
    End Property

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        If RadiosinIVA.Checked OrElse RadioconIVA.Checked Then
            If RadiosinIVA.Checked Then MIntTipo = 1
            If RadioconIVA.Checked Then MIntTipo = 2
            Me.DialogResult = DialogResult.OK
        Else
            ExpertisApp.GenerateMessage("Seleccione alguna de las dos opciones.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

End Class
