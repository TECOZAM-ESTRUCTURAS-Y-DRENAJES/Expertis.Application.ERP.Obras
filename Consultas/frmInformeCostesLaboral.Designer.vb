<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInformeCostesLaboral
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
        Dim fwiMesDesde_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInformeCostesLaboral))
        Dim fwiMesHasta_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim fwiAno_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.Button1 = New Solmicro.Expertis.Engine.UI.Button
        Me.Button2 = New Solmicro.Expertis.Engine.UI.Button
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.Label2 = New Solmicro.Expertis.Engine.UI.Label
        Me.Label3 = New Solmicro.Expertis.Engine.UI.Label
        Me.Filtros = New Solmicro.Expertis.Engine.UI.Frame
        Me.fwiMesDesde = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.fwiMesHasta = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.fwiAno = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.Filtros.SuspendLayout()
        CType(Me.fwiMesDesde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fwiMesHasta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fwiAno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(24, 227)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Aceptar"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(147, 227)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Cancelar"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Desde Mes"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Hasta Mes"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(6, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Año"
        '
        'Filtros
        '
        Me.Filtros.Controls.Add(Me.fwiAno)
        Me.Filtros.Controls.Add(Me.fwiMesHasta)
        Me.Filtros.Controls.Add(Me.fwiMesDesde)
        Me.Filtros.Controls.Add(Me.Label1)
        Me.Filtros.Controls.Add(Me.Label3)
        Me.Filtros.Controls.Add(Me.Label2)
        Me.Filtros.Location = New System.Drawing.Point(24, 21)
        Me.Filtros.Name = "Filtros"
        Me.Filtros.Size = New System.Drawing.Size(198, 189)
        Me.Filtros.TabIndex = 5
        Me.Filtros.TabStop = False
        Me.Filtros.Text = "Filtros"
        '
        'fwiMesDesde
        '
        fwiMesDesde_DesignTimeLayout.LayoutString = resources.GetString("fwiMesDesde_DesignTimeLayout.LayoutString")
        Me.fwiMesDesde.DesignTimeLayout = fwiMesDesde_DesignTimeLayout
        Me.fwiMesDesde.DisabledBackColor = System.Drawing.Color.White
        Me.fwiMesDesde.Location = New System.Drawing.Point(92, 40)
        Me.fwiMesDesde.Name = "fwiMesDesde"
        Me.fwiMesDesde.SelectedIndex = -1
        Me.fwiMesDesde.SelectedItem = Nothing
        Me.fwiMesDesde.Size = New System.Drawing.Size(100, 21)
        Me.fwiMesDesde.TabIndex = 5
        '
        'fwiMesHasta
        '
        fwiMesHasta_DesignTimeLayout.LayoutString = resources.GetString("fwiMesHasta_DesignTimeLayout.LayoutString")
        Me.fwiMesHasta.DesignTimeLayout = fwiMesHasta_DesignTimeLayout
        Me.fwiMesHasta.DisabledBackColor = System.Drawing.Color.White
        Me.fwiMesHasta.Location = New System.Drawing.Point(92, 84)
        Me.fwiMesHasta.Name = "fwiMesHasta"
        Me.fwiMesHasta.SelectedIndex = -1
        Me.fwiMesHasta.SelectedItem = Nothing
        Me.fwiMesHasta.Size = New System.Drawing.Size(100, 21)
        Me.fwiMesHasta.TabIndex = 6
        '
        'fwiAno
        '
        fwiAno_DesignTimeLayout.LayoutString = resources.GetString("fwiAno_DesignTimeLayout.LayoutString")
        Me.fwiAno.DesignTimeLayout = fwiAno_DesignTimeLayout
        Me.fwiAno.DisabledBackColor = System.Drawing.Color.White
        Me.fwiAno.Location = New System.Drawing.Point(92, 123)
        Me.fwiAno.Name = "fwiAno"
        Me.fwiAno.SelectedIndex = -1
        Me.fwiAno.SelectedItem = Nothing
        Me.fwiAno.Size = New System.Drawing.Size(100, 21)
        Me.fwiAno.TabIndex = 7
        '
        'frmInformeCostesLaboral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(252, 264)
        Me.Controls.Add(Me.Filtros)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmInformeCostesLaboral"
        Me.Text = "frmInformeCostesLaboral"
        Me.Filtros.ResumeLayout(False)
        Me.Filtros.PerformLayout()
        CType(Me.fwiMesDesde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fwiMesHasta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fwiAno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents Button2 As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Label2 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Label3 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Filtros As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents fwiAno As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents fwiMesHasta As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents fwiMesDesde As Solmicro.Expertis.Engine.UI.ComboBox
End Class
