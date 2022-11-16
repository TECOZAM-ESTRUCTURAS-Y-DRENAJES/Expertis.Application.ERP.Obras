<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGetPorcentaje
    Inherits Solmicro.Expertis.Engine.UI.FormBase

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ntxPorcIncrDecrPerido = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblPorcIncrDecrPerido = New Solmicro.Expertis.Engine.UI.Label
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmbCancel = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbOK = New Solmicro.Expertis.Engine.UI.Button
        Me.Panel1.suspendlayout()
        Me.SuspendLayout()
        '
        'ntxPorcIncrDecrPerido
        '
        Me.ntxPorcIncrDecrPerido.DisabledBackColor = System.Drawing.Color.White
        Me.ntxPorcIncrDecrPerido.Location = New System.Drawing.Point(197, 27)
        Me.ntxPorcIncrDecrPerido.Name = "ntxPorcIncrDecrPerido"
        Me.ntxPorcIncrDecrPerido.NullBehavior = Janus.Windows.GridEX.NumericEditNullBehavior.AllowNull
        Me.ntxPorcIncrDecrPerido.Size = New System.Drawing.Size(49, 21)
        Me.ntxPorcIncrDecrPerido.TabIndex = 349
        '
        'lblPorcIncrDecrPerido
        '
        Me.lblPorcIncrDecrPerido.Location = New System.Drawing.Point(28, 31)
        Me.lblPorcIncrDecrPerido.Name = "lblPorcIncrDecrPerido"
        Me.lblPorcIncrDecrPerido.Size = New System.Drawing.Size(164, 13)
        Me.lblPorcIncrDecrPerido.TabIndex = 350
        Me.lblPorcIncrDecrPerido.Text = "% Incremento/Decremento"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbCancel)
        Me.Panel1.Controls.Add(Me.cmbOK)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 66)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(309, 40)
        Me.Panel1.TabIndex = 351
        '
        'cmbCancel
        '
        Me.cmbCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmbCancel.Location = New System.Drawing.Point(157, 7)
        Me.cmbCancel.Name = "cmbCancel"
        Me.cmbCancel.Size = New System.Drawing.Size(105, 27)
        Me.cmbCancel.TabIndex = 4
        Me.cmbCancel.Text = "Cancelar"
        '
        'cmbOK
        '
        Me.cmbOK.Location = New System.Drawing.Point(47, 7)
        Me.cmbOK.Name = "cmbOK"
        Me.cmbOK.Size = New System.Drawing.Size(105, 27)
        Me.cmbOK.TabIndex = 3
        Me.cmbOK.Text = "Aceptar"
        '
        'frmGetPorcentaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 106)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ntxPorcIncrDecrPerido)
        Me.Controls.Add(Me.lblPorcIncrDecrPerido)
        Me.Name = "frmGetPorcentaje"
        Me.Text = "Seleccione un Porcentaje"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents ntxPorcIncrDecrPerido As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblPorcIncrDecrPerido As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents cmbCancel As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmbOK As Solmicro.Expertis.Engine.UI.Button
End Class
