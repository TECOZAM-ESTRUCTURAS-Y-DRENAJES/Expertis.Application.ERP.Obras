Public Class FrmNewTrabajoTarea
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
    Friend WithEvents Label4 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents FrmDatosTarea As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents BtnAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents BtnCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents LblFechaInicio As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LblFechaFin As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LblDescTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents TxtCodTrabajo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents TxtDescTrabajo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents ClbFechaInicio As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents ClbFechaFin As Solmicro.Expertis.Engine.UI.CalendarBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.FrmDatosTarea = New Solmicro.Expertis.Engine.UI.Frame
        Me.ClbFechaFin = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.ClbFechaInicio = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.TxtDescTrabajo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.TxtCodTrabajo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.Label4 = New Solmicro.Expertis.Engine.UI.Label
        Me.LblDescTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.LblFechaFin = New Solmicro.Expertis.Engine.UI.Label
        Me.LblFechaInicio = New Solmicro.Expertis.Engine.UI.Label
        Me.BtnAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.BtnCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.FrmDatosTarea.SuspendLayout()
        Me.SuspendLayout()
        '
        'FrmDatosTarea
        '
        Me.FrmDatosTarea.Controls.Add(Me.ClbFechaFin)
        Me.FrmDatosTarea.Controls.Add(Me.ClbFechaInicio)
        Me.FrmDatosTarea.Controls.Add(Me.TxtDescTrabajo)
        Me.FrmDatosTarea.Controls.Add(Me.TxtCodTrabajo)
        Me.FrmDatosTarea.Controls.Add(Me.Label4)
        Me.FrmDatosTarea.Controls.Add(Me.LblDescTrabajo)
        Me.FrmDatosTarea.Controls.Add(Me.LblFechaFin)
        Me.FrmDatosTarea.Controls.Add(Me.LblFechaInicio)
        Me.FrmDatosTarea.Location = New System.Drawing.Point(8, 8)
        Me.FrmDatosTarea.Name = "FrmDatosTarea"
        Me.FrmDatosTarea.Size = New System.Drawing.Size(312, 165)
        Me.FrmDatosTarea.TabIndex = 0
        Me.FrmDatosTarea.TabStop = False
        Me.FrmDatosTarea.Text = "Nuevo Trabajo"
        '
        'ClbFechaFin
        '
        Me.ClbFechaFin.DisabledBackColor = System.Drawing.Color.White
        Me.ClbFechaFin.Location = New System.Drawing.Point(104, 136)
        Me.ClbFechaFin.Name = "ClbFechaFin"
        Me.ClbFechaFin.Size = New System.Drawing.Size(120, 21)
        Me.ClbFechaFin.TabIndex = 3
        '
        'ClbFechaInicio
        '
        Me.ClbFechaInicio.DisabledBackColor = System.Drawing.Color.White
        Me.ClbFechaInicio.Location = New System.Drawing.Point(104, 111)
        Me.ClbFechaInicio.Name = "ClbFechaInicio"
        Me.ClbFechaInicio.Size = New System.Drawing.Size(120, 21)
        Me.ClbFechaInicio.TabIndex = 2
        '
        'TxtDescTrabajo
        '
        Me.TxtDescTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.TxtDescTrabajo.Location = New System.Drawing.Point(104, 49)
        Me.TxtDescTrabajo.MaxLength = 300
        Me.TxtDescTrabajo.Multiline = True
        Me.TxtDescTrabajo.Name = "TxtDescTrabajo"
        Me.TxtDescTrabajo.Size = New System.Drawing.Size(192, 58)
        Me.TxtDescTrabajo.TabIndex = 1
        '
        'TxtCodTrabajo
        '
        Me.TxtCodTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.TxtCodTrabajo.Location = New System.Drawing.Point(104, 24)
        Me.TxtCodTrabajo.Name = "TxtCodTrabajo"
        Me.TxtCodTrabajo.Size = New System.Drawing.Size(120, 21)
        Me.TxtCodTrabajo.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Trabajo"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblDescTrabajo
        '
        Me.LblDescTrabajo.Location = New System.Drawing.Point(8, 49)
        Me.LblDescTrabajo.Name = "LblDescTrabajo"
        Me.LblDescTrabajo.Size = New System.Drawing.Size(87, 13)
        Me.LblDescTrabajo.TabIndex = 2
        Me.LblDescTrabajo.Text = "Desc. Trabajo"
        Me.LblDescTrabajo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblFechaFin
        '
        Me.LblFechaFin.Location = New System.Drawing.Point(8, 136)
        Me.LblFechaFin.Name = "LblFechaFin"
        Me.LblFechaFin.Size = New System.Drawing.Size(60, 13)
        Me.LblFechaFin.TabIndex = 1
        Me.LblFechaFin.Text = "Fecha Fin"
        Me.LblFechaFin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblFechaInicio
        '
        Me.LblFechaInicio.Location = New System.Drawing.Point(8, 111)
        Me.LblFechaInicio.Name = "LblFechaInicio"
        Me.LblFechaInicio.Size = New System.Drawing.Size(75, 13)
        Me.LblFechaInicio.TabIndex = 0
        Me.LblFechaInicio.Text = "Fecha Inicio"
        Me.LblFechaInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(60, 179)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(99, 32)
        Me.BtnAceptar.TabIndex = 4
        Me.BtnAceptar.Text = "&Aceptar"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancelar.Location = New System.Drawing.Point(172, 179)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(99, 32)
        Me.BtnCancelar.TabIndex = 5
        Me.BtnCancelar.Text = "&Cancelar"
        '
        'FrmNewTrabajoTarea
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(330, 216)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.FrmDatosTarea)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmNewTrabajoTarea"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos Nuevo Trabajo"
        Me.FrmDatosTarea.ResumeLayout(False)
        Me.FrmDatosTarea.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables / Propiedades"

    Private mFechaInicio, mFechaFin As Date
    Private mCodTrabajo, mDescTrabajo As String
    Private mIDObra As Integer

    Public WriteOnly Property IDObra() As Integer
        Set(ByVal Value As Integer)
            mIDObra = Value
        End Set
    End Property

    Public Property FechaInicio() As Date
        Set(ByVal Value As Date)
            mFechaInicio = Value
        End Set
        Get
            Return Me.ClbFechaInicio.Value
        End Get
    End Property

    Public ReadOnly Property CodTrabajo() As String
        Get
            Return Me.TxtCodTrabajo.Text
        End Get
    End Property

    Public ReadOnly Property DescTrabajo() As String
        Get
            Return Me.TxtDescTrabajo.Text
        End Get
    End Property

    Public Property FechaFin() As Date
        Set(ByVal Value As Date)
            mFechaFin = Value
        End Set
        Get
            Return mFechaFin
        End Get
    End Property

#End Region

    Private Sub FrmNewTrabajoTarea_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TxtCodTrabajo.Text = New Parametro().TrabajoTareaPredefinida
        Me.ClbFechaInicio.Value = mFechaInicio
        Me.ClbFechaFin.Value = mFechaFin
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        Me.DialogResult = Windows.Forms.DialogResult.None
        If ComprobarDatos() Then
            If ExpertisApp.GenerateMessage("Se va a proceder a generar el Trabajo con las correspondientes Tareas Predefinidas.|¿Desea Continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, vbNewLine) = DialogResult.Yes Then
                Me.DialogResult = DialogResult.OK
            End If
        End If
    End Sub

    Private Function ComprobarDatos() As Boolean
        If Len(TxtDescTrabajo.Text) = 0 Then
            ExpertisApp.GenerateMessage("La Descripción del Trabajo es obligatoria.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        Else
            mDescTrabajo = TxtDescTrabajo.Text
        End If
        If Length(ClbFechaInicio.Value) = 0 Then
            ExpertisApp.GenerateMessage("La Fecha de Inicio del Trabajo es obligatoria.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
        If Length(ClbFechaFin.Value) = 0 Then
            If Length(mFechaFin) = 0 Then
                ExpertisApp.GenerateMessage("La Fecha de Fin del Trabajo es obligatoria.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            End If
        Else
            mFechaFin = ClbFechaFin.Value
        End If
        Dim f As New Filter
        f.Add(New StringFilterItem("CodTrabajo", TxtCodTrabajo.Text))
        f.Add(New NumberFilterItem("IDObra", mIDObra))
        Dim dtOT As DataTable = New ObraTrabajo().Filter(f)
        If Not dtOT Is Nothing AndAlso dtOT.Rows.Count > 0 Then
            ExpertisApp.GenerateMessage("El Trabajo | ya existe. Introduzaca otro código de Trabajo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, Me.TxtCodTrabajo.Text)
            Return False
        End If
        mCodTrabajo = Me.TxtCodTrabajo.Text
        Return True
    End Function

End Class