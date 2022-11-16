Public Class frmMedicionesCertificacion
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
    Friend WithEvents Panel2 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents txtNCertificacion As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblNCertificacion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtDescTrabajoPrev As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents GridCertificacionMedicion As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents txtTrabajo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents txtDescCertificacion As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents cmdAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents CmdCancelar As Solmicro.Expertis.Engine.UI.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim GridCertificacionMedicion_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMedicionesCertificacion))
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmdAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.CmdCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.Panel2 = New Solmicro.Expertis.Engine.UI.Panel
        Me.txtDescCertificacion = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtDescTrabajoPrev = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTrabajo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtNCertificacion = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblNCertificacion = New Solmicro.Expertis.Engine.UI.Label
        Me.GridCertificacionMedicion = New Solmicro.Expertis.Engine.UI.Grid
        Me.Panel1.suspendlayout()
        Me.Panel2.suspendlayout()
        CType(Me.GridCertificacionMedicion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmdAceptar)
        Me.Panel1.Controls.Add(Me.CmdCancelar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 294)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(764, 42)
        Me.Panel1.TabIndex = 231
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(286, 7)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(94, 29)
        Me.cmdAceptar.TabIndex = 27
        Me.cmdAceptar.Text = "Aceptar"
        '
        'CmdCancelar
        '
        Me.CmdCancelar.Location = New System.Drawing.Point(385, 7)
        Me.CmdCancelar.Name = "CmdCancelar"
        Me.CmdCancelar.Size = New System.Drawing.Size(94, 29)
        Me.CmdCancelar.TabIndex = 26
        Me.CmdCancelar.Text = "Cancelar"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtDescCertificacion)
        Me.Panel2.Controls.Add(Me.txtDescTrabajoPrev)
        Me.Panel2.Controls.Add(Me.lblTrabajo)
        Me.Panel2.Controls.Add(Me.txtTrabajo)
        Me.Panel2.Controls.Add(Me.txtNCertificacion)
        Me.Panel2.Controls.Add(Me.lblNCertificacion)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(764, 59)
        Me.Panel2.TabIndex = 232
        '
        'txtDescCertificacion
        '
        Me.txtDescCertificacion.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescCertificacion.Enabled = False
        Me.txtDescCertificacion.Location = New System.Drawing.Point(239, 8)
        Me.txtDescCertificacion.Name = "txtDescCertificacion"
        Me.txtDescCertificacion.Size = New System.Drawing.Size(518, 21)
        Me.txtDescCertificacion.TabIndex = 304
        Me.txtDescCertificacion.TabStop = False
        '
        'txtDescTrabajoPrev
        '
        Me.txtDescTrabajoPrev.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescTrabajoPrev.Enabled = False
        Me.txtDescTrabajoPrev.Location = New System.Drawing.Point(239, 32)
        Me.txtDescTrabajoPrev.Name = "txtDescTrabajoPrev"
        Me.txtDescTrabajoPrev.Size = New System.Drawing.Size(518, 21)
        Me.txtDescTrabajoPrev.TabIndex = 303
        Me.txtDescTrabajoPrev.TabStop = False
        '
        'lblTrabajo
        '
        Me.lblTrabajo.Location = New System.Drawing.Point(8, 35)
        Me.lblTrabajo.Name = "lblTrabajo"
        Me.lblTrabajo.Size = New System.Drawing.Size(51, 13)
        Me.lblTrabajo.TabIndex = 302
        Me.lblTrabajo.Tag = ""
        Me.lblTrabajo.Text = "Trabajo"
        '
        'txtTrabajo
        '
        Me.txtTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.txtTrabajo.Enabled = False
        Me.txtTrabajo.Location = New System.Drawing.Point(110, 32)
        Me.txtTrabajo.Name = "txtTrabajo"
        Me.txtTrabajo.Size = New System.Drawing.Size(126, 21)
        Me.txtTrabajo.TabIndex = 301
        Me.txtTrabajo.TabStop = False
        '
        'txtNCertificacion
        '
        Me.txtNCertificacion.DisabledBackColor = System.Drawing.Color.White
        Me.txtNCertificacion.Enabled = False
        Me.txtNCertificacion.Location = New System.Drawing.Point(110, 8)
        Me.txtNCertificacion.Name = "txtNCertificacion"
        Me.txtNCertificacion.Size = New System.Drawing.Size(126, 21)
        Me.txtNCertificacion.TabIndex = 234
        Me.txtNCertificacion.TabStop = False
        '
        'lblNCertificacion
        '
        Me.lblNCertificacion.Location = New System.Drawing.Point(8, 8)
        Me.lblNCertificacion.Name = "lblNCertificacion"
        Me.lblNCertificacion.Size = New System.Drawing.Size(100, 13)
        Me.lblNCertificacion.TabIndex = 235
        Me.lblNCertificacion.Text = "Nº. Certificación"
        '
        'GridCertificacionMedicion
        '
        GridCertificacionMedicion_DesignTimeLayout.LayoutString = resources.GetString("GridCertificacionMedicion_DesignTimeLayout.LayoutString")
        Me.GridCertificacionMedicion.DesignTimeLayout = GridCertificacionMedicion_DesignTimeLayout
        Me.GridCertificacionMedicion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridCertificacionMedicion.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridCertificacionMedicion.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridCertificacionMedicion.EntityName = "ObraCertificacionMedicion"
        Me.GridCertificacionMedicion.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridCertificacionMedicion.FrozenColumns = 5
        Me.GridCertificacionMedicion.HideColumnsWhenGrouped = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridCertificacionMedicion.Hierarchical = True
        Me.GridCertificacionMedicion.Location = New System.Drawing.Point(0, 59)
        Me.GridCertificacionMedicion.Name = "GridCertificacionMedicion"
        Me.GridCertificacionMedicion.PrimaryDataFields = ""
        Me.GridCertificacionMedicion.RelationMode = Solmicro.Expertis.Engine.RelationMode.NoRelation
        Me.GridCertificacionMedicion.RequeryManually = True
        Me.GridCertificacionMedicion.SecondaryDataFields = ""
        Me.GridCertificacionMedicion.Size = New System.Drawing.Size(764, 235)
        Me.GridCertificacionMedicion.TabIndex = 234
        Me.GridCertificacionMedicion.ViewName = "vFrmObraCertificacionMedicion"
        '
        'frmMedicionesCertificacion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(764, 336)
        Me.Controls.Add(Me.GridCertificacionMedicion)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmMedicionesCertificacion"
        Me.Text = "Mediciones"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.GridCertificacionMedicion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mintTipoCertificacion As Integer
    Public Function AbrirMediciones(ByVal intIDLineaCertificacionTrabajo As Integer, ByVal intIDCertificacion As Integer, _
                                    ByVal strNCertificacion As String, ByVal strDescCertificacion As String, _
                                    ByVal intIDTrabajo As Integer, ByVal strCodTrabajo As String, _
                                    ByVal strDescTrabajo As String, ByVal dblQPrev As Double, ByVal intTipoCertificacion As Integer, _
                                    ByVal blnEditable As Janus.Windows.GridEX.InheritableBoolean, _
                                    ByRef dv As DataView, ByRef DblTotal As Double) As DialogResult

        txtNCertificacion.Text = strNCertificacion
        txtDescCertificacion.Text = strDescCertificacion
        txtTrabajo.Text = strCodTrabajo
        txtDescTrabajoPrev.Text = strDescTrabajo
        mintTipoCertificacion = intTipoCertificacion

        With GridCertificacionMedicion
            .AllowDelete = blnEditable
            .AllowAddNew = blnEditable
            .AllowEdit = blnEditable

            .Columns("IDTrabajo").DefaultValue = intIDTrabajo
            .Columns("IDLineaCertificacionTrabajo").DefaultValue = intIDLineaCertificacionTrabajo
            .Columns("IDCertificacion").DefaultValue = intIDCertificacion
            .Columns("QPrev").DefaultValue = 0 'dblQPrev
            .Columns("PIPorc").DefaultValue = 0
            .Columns("PIOrigen").DefaultValue = 0
            .Columns("PIPorcOrigen").DefaultValue = 0

            .DataSource = dv

            Me.ShowDialog()

            dv = .DataSource
            DblTotal = .GetTotal(.Columns("Total"), Janus.Windows.GridEX.AggregateFunction.Sum)
        End With

        Return Me.DialogResult
    End Function

    Private Sub frmMedicionesCertificacion_BusinessCalling(ByVal sender As Object, ByVal e As Engine.UI.BusinessCallingEventArgs) Handles MyBase.BusinessCalling
        e.Data.Context.Clear()
        Select Case e.EntityName
            Case GridCertificacionMedicion.EntityName
                e.Data.Context("PIMedicion") = GridCertificacionMedicion.Value("PIMedicion")
                e.Data.Context("IDTipoCertificacion") = mintTipoCertificacion
        End Select
    End Sub

    Private Sub frmMedicionesCertificacion_BusinessCalled(ByVal sender As Object, ByVal e As Engine.UI.BusinessCalledEventArgs) Handles MyBase.BusinessCalled
        If Not e.Data Is Nothing AndAlso length(e.Data("Total")) > 0 AndAlso (length(e.Data("IDLineaMedicion")) = 0) Then
            e.Data("QPrev") = e.Data("Total")
        End If
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub


    Private Sub CmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCancelar.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub GridCertificacionMedicion_EditingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles GridCertificacionMedicion.EditingCell
        With GridCertificacionMedicion
            Select Case e.Column.Key
                Case "QPrev"
                    e.Cancel = True
                Case "PIPorc", "PIOrigen", "PIPorcOrigen"
                    e.Cancel = (length(.Value("IDLineaMedicion")) = 0)
            End Select
        End With
    End Sub

    Private Sub GridCertificacionMedicion_UpdatingRecord(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GridCertificacionMedicion.UpdatingRecord, GridCertificacionMedicion.AddingRecord
        If Length(GridCertificacionMedicion.Value("qpi")) = 0 Then
            e.Cancel = True
            ExpertisApp.GenerateMessage("PI es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Length(GridCertificacionMedicion.Value("PIPorc")) = 0 Then
            e.Cancel = True
            ExpertisApp.GenerateMessage("% PI es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Length(GridCertificacionMedicion.Value("PIOrigen")) = 0 Then
            e.Cancel = True
            ExpertisApp.GenerateMessage("PI Origen es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Length(GridCertificacionMedicion.Value("PIPorcOrigen")) = 0 Then
            e.Cancel = True
            ExpertisApp.GenerateMessage("% PI Origen es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

End Class
