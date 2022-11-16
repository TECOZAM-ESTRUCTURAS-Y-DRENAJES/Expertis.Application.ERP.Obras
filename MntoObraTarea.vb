Public Class MntoObraTarea
    Inherits Solmicro.Expertis.Engine.UI.SimpleMnto

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
    Friend WithEvents FraOtros As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents FraOperario As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents FraSolicitadaPor As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents FraReal As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents Panel2 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents lblNTarea As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFechaTarea As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblObra As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvTipoTarea As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblSecuencia As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtSecuencia As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents chkFacturable As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents cbxFechaFinReal As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents cbxFechaInicioReal As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblHorasReal As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtHorasReal As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblFechaFinReal As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFechaInicioReal As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtDescTrabajo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents txtNTarea As Solmicro.Expertis.Engine.UI.CounterTextBox
    Friend WithEvents txtDescTarea As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblPrioridad As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxPrioridad As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents cbxFechaTarea As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblEstado As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxEstado As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblTexto As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvIdTrabajo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvIDObra As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents ulDescTipoTarea As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents ulDescIncidencia As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents cbxIDIncidencia As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents txtTexto As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblIncidencia As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblTipoTarea As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtEmail As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblIDOperarioSolicitante As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDOperarioSolicitante As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents ulbDescOperario As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents lblIDOperario As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDOperario As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents ulbDescOperario1 As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents ulbNObra As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents FraPrev As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents lblImporte As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtImporte As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblPrecio As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtPrecio As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblHorasPrev As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtHorasPrev As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblFechaFinPrev As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaFinPrev As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaInicioPrev As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblOficio As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvIDOficio As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblHorasPlanificadas As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtHorasPlanificadas As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents cbxFechaInicioPrev As Solmicro.Expertis.Engine.UI.CalendarBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim cbxPrioridad_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MntoObraTarea))
        Dim cbxEstado_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxIDIncidencia_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.FraPrev = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblImporte = New Solmicro.Expertis.Engine.UI.Label
        Me.txtImporte = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblPrecio = New Solmicro.Expertis.Engine.UI.Label
        Me.txtPrecio = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblHorasPrev = New Solmicro.Expertis.Engine.UI.Label
        Me.txtHorasPrev = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblFechaFinPrev = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaFinPrev = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaInicioPrev = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaInicioPrev = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.ulbNObra = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.AdvTipoTarea = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.FraOtros = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblSecuencia = New Solmicro.Expertis.Engine.UI.Label
        Me.txtSecuencia = New Solmicro.Expertis.Engine.UI.TextBox
        Me.chkFacturable = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.FraOperario = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblOficio = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDOficio = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.ulbDescOperario1 = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.advIDOperario = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblIDOperario = New Solmicro.Expertis.Engine.UI.Label
        Me.FraSolicitadaPor = New Solmicro.Expertis.Engine.UI.Frame
        Me.ulbDescOperario = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.advIDOperarioSolicitante = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblIDOperarioSolicitante = New Solmicro.Expertis.Engine.UI.Label
        Me.FraReal = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblHorasPlanificadas = New Solmicro.Expertis.Engine.UI.Label
        Me.txtHorasPlanificadas = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.cbxFechaFinReal = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.cbxFechaInicioReal = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblHorasReal = New Solmicro.Expertis.Engine.UI.Label
        Me.txtHorasReal = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblFechaFinReal = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFechaInicioReal = New Solmicro.Expertis.Engine.UI.Label
        Me.txtDescTrabajo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblNTarea = New Solmicro.Expertis.Engine.UI.Label
        Me.txtNTarea = New Solmicro.Expertis.Engine.UI.CounterTextBox
        Me.txtDescTarea = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblPrioridad = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxPrioridad = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblFechaTarea = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaTarea = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblEstado = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxEstado = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblTexto = New Solmicro.Expertis.Engine.UI.Label
        Me.lblTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIdTrabajo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblObra = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDObra = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblTipoTarea = New Solmicro.Expertis.Engine.UI.Label
        Me.ulDescTipoTarea = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.lblIncidencia = New Solmicro.Expertis.Engine.UI.Label
        Me.ulDescIncidencia = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.cbxIDIncidencia = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.txtEmail = New Solmicro.Expertis.Engine.UI.TextBox
        Me.Panel2 = New Solmicro.Expertis.Engine.UI.Panel
        Me.txtTexto = New Solmicro.Expertis.Engine.UI.TextBox
        CType(Me.ToolBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.suspendlayout()
        Me.Panel1.suspendlayout()
        Me.FraPrev.SuspendLayout()
        Me.FraOtros.SuspendLayout()
        Me.FraOperario.SuspendLayout()
        Me.FraSolicitadaPor.SuspendLayout()
        Me.FraReal.SuspendLayout()
        CType(Me.cbxPrioridad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxIDIncidencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.suspendlayout()
        Me.SuspendLayout()
        '
        'ToolBar
        '
        Me.ToolBar.Size = New System.Drawing.Size(721, 39)
        '
        'MenuBar
        '
        Me.MenuBar.Location = New System.Drawing.Point(0, 42)
        Me.MenuBar.Size = New System.Drawing.Size(504, 26)
        '
        'MainPanel
        '
        Me.MainPanel.Controls.Add(Me.Panel1)
        Me.MainPanel.Controls.Add(Me.Panel2)
        Me.MainPanel.Size = New System.Drawing.Size(784, 436)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.FraPrev)
        Me.Panel1.Controls.Add(Me.ulbNObra)
        Me.Panel1.Controls.Add(Me.AdvTipoTarea)
        Me.Panel1.Controls.Add(Me.FraOtros)
        Me.Panel1.Controls.Add(Me.FraOperario)
        Me.Panel1.Controls.Add(Me.FraSolicitadaPor)
        Me.Panel1.Controls.Add(Me.FraReal)
        Me.Panel1.Controls.Add(Me.txtDescTrabajo)
        Me.Panel1.Controls.Add(Me.lblNTarea)
        Me.Panel1.Controls.Add(Me.txtNTarea)
        Me.Panel1.Controls.Add(Me.txtDescTarea)
        Me.Panel1.Controls.Add(Me.lblPrioridad)
        Me.Panel1.Controls.Add(Me.cbxPrioridad)
        Me.Panel1.Controls.Add(Me.lblFechaTarea)
        Me.Panel1.Controls.Add(Me.cbxFechaTarea)
        Me.Panel1.Controls.Add(Me.lblEstado)
        Me.Panel1.Controls.Add(Me.cbxEstado)
        Me.Panel1.Controls.Add(Me.lblTexto)
        Me.Panel1.Controls.Add(Me.lblTrabajo)
        Me.Panel1.Controls.Add(Me.AdvIdTrabajo)
        Me.Panel1.Controls.Add(Me.lblObra)
        Me.Panel1.Controls.Add(Me.AdvIDObra)
        Me.Panel1.Controls.Add(Me.lblTipoTarea)
        Me.Panel1.Controls.Add(Me.ulDescTipoTarea)
        Me.Panel1.Controls.Add(Me.lblIncidencia)
        Me.Panel1.Controls.Add(Me.ulDescIncidencia)
        Me.Panel1.Controls.Add(Me.cbxIDIncidencia)
        Me.Panel1.Controls.Add(Me.txtEmail)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 288)
        Me.Panel1.TabIndex = 0
        '
        'FraPrev
        '
        Me.FraPrev.Controls.Add(Me.lblImporte)
        Me.FraPrev.Controls.Add(Me.txtImporte)
        Me.FraPrev.Controls.Add(Me.lblPrecio)
        Me.FraPrev.Controls.Add(Me.txtPrecio)
        Me.FraPrev.Controls.Add(Me.lblHorasPrev)
        Me.FraPrev.Controls.Add(Me.txtHorasPrev)
        Me.FraPrev.Controls.Add(Me.lblFechaFinPrev)
        Me.FraPrev.Controls.Add(Me.cbxFechaFinPrev)
        Me.FraPrev.Controls.Add(Me.lblFechaInicioPrev)
        Me.FraPrev.Controls.Add(Me.cbxFechaInicioPrev)
        Me.FraPrev.Location = New System.Drawing.Point(404, 122)
        Me.FraPrev.Name = "FraPrev"
        Me.FraPrev.Size = New System.Drawing.Size(187, 147)
        Me.FraPrev.TabIndex = 12
        Me.FraPrev.TabStop = False
        Me.FraPrev.Tag = ""
        Me.FraPrev.Text = "Fechas y Horas Previstas"
        '
        'lblImporte
        '
        Me.lblImporte.Location = New System.Drawing.Point(8, 124)
        Me.lblImporte.Name = "lblImporte"
        Me.lblImporte.Size = New System.Drawing.Size(53, 13)
        Me.lblImporte.TabIndex = 0
        Me.lblImporte.Tag = "IdRec=4389;"
        Me.lblImporte.Text = "Importe"
        '
        'txtImporte
        '
        Me.TryDataBinding(txtImporte, New System.Windows.Forms.Binding("Value", Me, "Importe", True))
        Me.txtImporte.DisabledBackColor = System.Drawing.Color.White
        Me.txtImporte.Location = New System.Drawing.Point(88, 120)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(88, 21)
        Me.txtImporte.TabIndex = 20
        '
        'lblPrecio
        '
        Me.lblPrecio.Location = New System.Drawing.Point(8, 100)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(42, 13)
        Me.lblPrecio.TabIndex = 16
        Me.lblPrecio.Tag = "IdRec=4385;"
        Me.lblPrecio.Text = "Precio"
        '
        'txtPrecio
        '
        Me.TryDataBinding(txtPrecio, New System.Windows.Forms.Binding("Value", Me, "Precio", True))
        Me.txtPrecio.DisabledBackColor = System.Drawing.Color.White
        Me.txtPrecio.Location = New System.Drawing.Point(88, 96)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(88, 21)
        Me.txtPrecio.TabIndex = 19
        '
        'lblHorasPrev
        '
        Me.lblHorasPrev.Location = New System.Drawing.Point(8, 76)
        Me.lblHorasPrev.Name = "lblHorasPrev"
        Me.lblHorasPrev.Size = New System.Drawing.Size(40, 13)
        Me.lblHorasPrev.TabIndex = 18
        Me.lblHorasPrev.Tag = "IdRec=6154;"
        Me.lblHorasPrev.Text = "Horas"
        '
        'txtHorasPrev
        '
        Me.TryDataBinding(txtHorasPrev, New System.Windows.Forms.Binding("Value", Me, "HorasPrev", True))
        Me.txtHorasPrev.DisabledBackColor = System.Drawing.Color.White
        Me.txtHorasPrev.Location = New System.Drawing.Point(88, 72)
        Me.txtHorasPrev.Name = "txtHorasPrev"
        Me.txtHorasPrev.Size = New System.Drawing.Size(88, 21)
        Me.txtHorasPrev.TabIndex = 18
        '
        'lblFechaFinPrev
        '
        Me.lblFechaFinPrev.Location = New System.Drawing.Point(8, 50)
        Me.lblFechaFinPrev.Name = "lblFechaFinPrev"
        Me.lblFechaFinPrev.Size = New System.Drawing.Size(60, 13)
        Me.lblFechaFinPrev.TabIndex = 19
        Me.lblFechaFinPrev.Tag = "IdRec=5288;"
        Me.lblFechaFinPrev.Text = "Fecha Fin"
        '
        'cbxFechaFinPrev
        '
        Me.TryDataBinding(cbxFechaFinPrev, New System.Windows.Forms.Binding("BindableValue", Me, "FechaFinPrev", True))
        Me.cbxFechaFinPrev.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaFinPrev.Location = New System.Drawing.Point(88, 48)
        Me.cbxFechaFinPrev.Name = "cbxFechaFinPrev"
        Me.cbxFechaFinPrev.Size = New System.Drawing.Size(88, 21)
        Me.cbxFechaFinPrev.TabIndex = 17
        '
        'lblFechaInicioPrev
        '
        Me.lblFechaInicioPrev.Location = New System.Drawing.Point(8, 28)
        Me.lblFechaInicioPrev.Name = "lblFechaInicioPrev"
        Me.lblFechaInicioPrev.Size = New System.Drawing.Size(75, 13)
        Me.lblFechaInicioPrev.TabIndex = 20
        Me.lblFechaInicioPrev.Tag = "IdRec=5165;"
        Me.lblFechaInicioPrev.Text = "Fecha Inicio"
        '
        'cbxFechaInicioPrev
        '
        Me.TryDataBinding(cbxFechaInicioPrev, New System.Windows.Forms.Binding("BindableValue", Me, "FechaInicioPrev", True))
        Me.cbxFechaInicioPrev.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaInicioPrev.Location = New System.Drawing.Point(88, 24)
        Me.cbxFechaInicioPrev.Name = "cbxFechaInicioPrev"
        Me.cbxFechaInicioPrev.Size = New System.Drawing.Size(88, 21)
        Me.cbxFechaInicioPrev.TabIndex = 16
        '
        'ulbNObra
        '
        Me.TryDataBinding(ulbNObra, New System.Windows.Forms.Binding("Text", Me.AdvIDObra, "DescObra", True))
        Me.ulbNObra.Location = New System.Drawing.Point(182, 29)
        Me.ulbNObra.Name = "ulbNObra"
        Me.ulbNObra.Size = New System.Drawing.Size(410, 23)
        Me.ulbNObra.TabIndex = 71
        '
        'AdvTipoTarea
        '
        Me.TryDataBinding(AdvTipoTarea, New System.Windows.Forms.Binding("Text", Me, "IDTipoTarea", True))
        Me.AdvTipoTarea.DisabledBackColor = System.Drawing.Color.White
        Me.AdvTipoTarea.EntityName = "TipoTarea"
        Me.AdvTipoTarea.Location = New System.Drawing.Point(283, 54)
        Me.AdvTipoTarea.Name = "AdvTipoTarea"
        Me.AdvTipoTarea.PrimaryDataFields = "IDTipoTarea"
        Me.AdvTipoTarea.SecondaryDataFields = "IDTipoTarea"
        Me.AdvTipoTarea.Size = New System.Drawing.Size(75, 23)
        Me.AdvTipoTarea.TabIndex = 6
        Me.AdvTipoTarea.ViewName = "tbMaestroTipoTarea"
        '
        'FraOtros
        '
        Me.FraOtros.Controls.Add(Me.lblSecuencia)
        Me.FraOtros.Controls.Add(Me.txtSecuencia)
        Me.FraOtros.Controls.Add(Me.chkFacturable)
        Me.FraOtros.Location = New System.Drawing.Point(4, 224)
        Me.FraOtros.Name = "FraOtros"
        Me.FraOtros.Size = New System.Drawing.Size(394, 45)
        Me.FraOtros.TabIndex = 11
        Me.FraOtros.TabStop = False
        Me.FraOtros.Tag = ""
        Me.FraOtros.Text = "Otros"
        '
        'lblSecuencia
        '
        Me.lblSecuencia.Location = New System.Drawing.Point(192, 18)
        Me.lblSecuencia.Name = "lblSecuencia"
        Me.lblSecuencia.Size = New System.Drawing.Size(65, 13)
        Me.lblSecuencia.TabIndex = 0
        Me.lblSecuencia.Tag = "IdRec=4500;"
        Me.lblSecuencia.Text = "Secuencia"
        '
        'txtSecuencia
        '
        Me.TryDataBinding(txtSecuencia, New System.Windows.Forms.Binding("Text", Me, "Secuencia", True))
        Me.txtSecuencia.DisabledBackColor = System.Drawing.Color.White
        Me.txtSecuencia.Location = New System.Drawing.Point(263, 14)
        Me.txtSecuencia.Name = "txtSecuencia"
        Me.txtSecuencia.Size = New System.Drawing.Size(63, 21)
        Me.txtSecuencia.TabIndex = 14
        Me.txtSecuencia.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        '
        'chkFacturable
        '
        Me.TryDataBinding(chkFacturable, New System.Windows.Forms.Binding("BindableValue", Me, "Facturable", True))
        Me.chkFacturable.Location = New System.Drawing.Point(56, 16)
        Me.chkFacturable.Name = "chkFacturable"
        Me.chkFacturable.Size = New System.Drawing.Size(97, 19)
        Me.chkFacturable.TabIndex = 13
        Me.chkFacturable.Text = "Facturable"
        '
        'FraOperario
        '
        Me.FraOperario.Controls.Add(Me.lblOficio)
        Me.FraOperario.Controls.Add(Me.AdvIDOficio)
        Me.FraOperario.Controls.Add(Me.ulbDescOperario1)
        Me.FraOperario.Controls.Add(Me.advIDOperario)
        Me.FraOperario.Controls.Add(Me.lblIDOperario)
        Me.FraOperario.Location = New System.Drawing.Point(4, 172)
        Me.FraOperario.Name = "FraOperario"
        Me.FraOperario.Size = New System.Drawing.Size(394, 50)
        Me.FraOperario.TabIndex = 10
        Me.FraOperario.TabStop = False
        Me.FraOperario.Tag = ""
        Me.FraOperario.Text = "Operario asignado"
        '
        'lblOficio
        '
        Me.lblOficio.Location = New System.Drawing.Point(3, 26)
        Me.lblOficio.Name = "lblOficio"
        Me.lblOficio.Size = New System.Drawing.Size(39, 13)
        Me.lblOficio.TabIndex = 13
        Me.lblOficio.Text = "Oficio"
        '
        'AdvIDOficio
        '
        Me.TryDataBinding(AdvIDOficio, New System.Windows.Forms.Binding("Text", Me, "IDOficio", True))
        Me.AdvIDOficio.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDOficio.EntityName = "Oficio"
        Me.AdvIDOficio.Location = New System.Drawing.Point(60, 21)
        Me.AdvIDOficio.Name = "AdvIDOficio"
        Me.AdvIDOficio.SecondaryDataFields = "IdOficio"
        Me.AdvIDOficio.Size = New System.Drawing.Size(75, 23)
        Me.AdvIDOficio.TabIndex = 0
        '
        'ulbDescOperario1
        '
        Me.TryDataBinding(ulbDescOperario1, New System.Windows.Forms.Binding("Text", Me.advIDOperario, "DescOperario", True))
        Me.ulbDescOperario1.Location = New System.Drawing.Point(276, 12)
        Me.ulbDescOperario1.Name = "ulbDescOperario1"
        Me.ulbDescOperario1.Size = New System.Drawing.Size(109, 32)
        Me.ulbDescOperario1.TabIndex = 2
        '
        'advIDOperario
        '
        Me.TryDataBinding(advIDOperario, New System.Windows.Forms.Binding("Text", Me, "IDOperario", True))
        Me.advIDOperario.DisabledBackColor = System.Drawing.Color.White
        Me.advIDOperario.EntityName = "Operario"
        Me.advIDOperario.Location = New System.Drawing.Point(197, 21)
        Me.advIDOperario.Name = "advIDOperario"
        Me.advIDOperario.PrimaryDataFields = "IDOperario"
        Me.advIDOperario.SecondaryDataFields = "IDOperario"
        Me.advIDOperario.Size = New System.Drawing.Size(75, 23)
        Me.advIDOperario.TabIndex = 1
        '
        'lblIDOperario
        '
        Me.lblIDOperario.Location = New System.Drawing.Point(138, 25)
        Me.lblIDOperario.Name = "lblIDOperario"
        Me.lblIDOperario.Size = New System.Drawing.Size(57, 13)
        Me.lblIDOperario.TabIndex = 1
        Me.lblIDOperario.Text = "Operario"
        '
        'FraSolicitadaPor
        '
        Me.FraSolicitadaPor.Controls.Add(Me.ulbDescOperario)
        Me.FraSolicitadaPor.Controls.Add(Me.advIDOperarioSolicitante)
        Me.FraSolicitadaPor.Controls.Add(Me.lblIDOperarioSolicitante)
        Me.FraSolicitadaPor.Location = New System.Drawing.Point(4, 122)
        Me.FraSolicitadaPor.Name = "FraSolicitadaPor"
        Me.FraSolicitadaPor.Size = New System.Drawing.Size(394, 50)
        Me.FraSolicitadaPor.TabIndex = 9
        Me.FraSolicitadaPor.TabStop = False
        Me.FraSolicitadaPor.Tag = "IdRec=12773;"
        Me.FraSolicitadaPor.Text = "Tarea solicitada por ..."
        '
        'ulbDescOperario
        '
        Me.TryDataBinding(ulbDescOperario, New System.Windows.Forms.Binding("Text", Me.advIDOperarioSolicitante, "DescOperario", True))
        Me.ulbDescOperario.Location = New System.Drawing.Point(138, 21)
        Me.ulbDescOperario.Name = "ulbDescOperario"
        Me.ulbDescOperario.Size = New System.Drawing.Size(247, 23)
        Me.ulbDescOperario.TabIndex = 2
        '
        'advIDOperarioSolicitante
        '
        Me.TryDataBinding(advIDOperarioSolicitante, New System.Windows.Forms.Binding("Text", Me, "IDOperarioSolicitante", True))
        Me.advIDOperarioSolicitante.DisabledBackColor = System.Drawing.Color.White
        Me.advIDOperarioSolicitante.EntityName = "Operario"
        Me.advIDOperarioSolicitante.Location = New System.Drawing.Point(60, 21)
        Me.advIDOperarioSolicitante.Name = "advIDOperarioSolicitante"
        Me.advIDOperarioSolicitante.PrimaryDataFields = "IDOperarioSolicitante"
        Me.advIDOperarioSolicitante.SecondaryDataFields = "IDOperario"
        Me.advIDOperarioSolicitante.Size = New System.Drawing.Size(75, 23)
        Me.advIDOperarioSolicitante.TabIndex = 9
        '
        'lblIDOperarioSolicitante
        '
        Me.lblIDOperarioSolicitante.Location = New System.Drawing.Point(3, 25)
        Me.lblIDOperarioSolicitante.Name = "lblIDOperarioSolicitante"
        Me.lblIDOperarioSolicitante.Size = New System.Drawing.Size(57, 13)
        Me.lblIDOperarioSolicitante.TabIndex = 0
        Me.lblIDOperarioSolicitante.Text = "Operario"
        '
        'FraReal
        '
        Me.FraReal.Controls.Add(Me.lblHorasPlanificadas)
        Me.FraReal.Controls.Add(Me.txtHorasPlanificadas)
        Me.FraReal.Controls.Add(Me.cbxFechaFinReal)
        Me.FraReal.Controls.Add(Me.cbxFechaInicioReal)
        Me.FraReal.Controls.Add(Me.lblHorasReal)
        Me.FraReal.Controls.Add(Me.txtHorasReal)
        Me.FraReal.Controls.Add(Me.lblFechaFinReal)
        Me.FraReal.Controls.Add(Me.lblFechaInicioReal)
        Me.FraReal.Location = New System.Drawing.Point(594, 122)
        Me.FraReal.Name = "FraReal"
        Me.FraReal.Size = New System.Drawing.Size(184, 121)
        Me.FraReal.TabIndex = 13
        Me.FraReal.TabStop = False
        Me.FraReal.Tag = ""
        Me.FraReal.Text = "Fechas y Horas Reales"
        '
        'lblHorasPlanificadas
        '
        Me.lblHorasPlanificadas.Location = New System.Drawing.Point(10, 98)
        Me.lblHorasPlanificadas.Name = "lblHorasPlanificadas"
        Me.lblHorasPlanificadas.Size = New System.Drawing.Size(78, 13)
        Me.lblHorasPlanificadas.TabIndex = 28
        Me.lblHorasPlanificadas.Tag = ""
        Me.lblHorasPlanificadas.Text = "Horas Planif."
        '
        'txtHorasPlanificadas
        '
        Me.TryDataBinding(txtHorasPlanificadas, New System.Windows.Forms.Binding("Value", Me, "HorasPlanificadas", True))
        Me.txtHorasPlanificadas.DisabledBackColor = System.Drawing.Color.White
        Me.txtHorasPlanificadas.Enabled = False
        Me.txtHorasPlanificadas.Location = New System.Drawing.Point(89, 94)
        Me.txtHorasPlanificadas.Name = "txtHorasPlanificadas"
        Me.txtHorasPlanificadas.Size = New System.Drawing.Size(83, 21)
        Me.txtHorasPlanificadas.TabIndex = 29
        '
        'cbxFechaFinReal
        '
        Me.TryDataBinding(cbxFechaFinReal, New System.Windows.Forms.Binding("BindableValue", Me, "FechaFinReal", True))
        Me.cbxFechaFinReal.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaFinReal.Location = New System.Drawing.Point(89, 45)
        Me.cbxFechaFinReal.Name = "cbxFechaFinReal"
        Me.cbxFechaFinReal.Size = New System.Drawing.Size(83, 21)
        Me.cbxFechaFinReal.TabIndex = 24
        '
        'cbxFechaInicioReal
        '
        Me.TryDataBinding(cbxFechaInicioReal, New System.Windows.Forms.Binding("BindableValue", Me, "FechaInicioReal", True))
        Me.cbxFechaInicioReal.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaInicioReal.Enabled = False
        Me.cbxFechaInicioReal.Location = New System.Drawing.Point(89, 21)
        Me.cbxFechaInicioReal.Name = "cbxFechaInicioReal"
        Me.cbxFechaInicioReal.Size = New System.Drawing.Size(83, 21)
        Me.cbxFechaInicioReal.TabIndex = 23
        '
        'lblHorasReal
        '
        Me.lblHorasReal.Location = New System.Drawing.Point(10, 74)
        Me.lblHorasReal.Name = "lblHorasReal"
        Me.lblHorasReal.Size = New System.Drawing.Size(40, 13)
        Me.lblHorasReal.TabIndex = 0
        Me.lblHorasReal.Tag = "IdRec=6154;"
        Me.lblHorasReal.Text = "Horas"
        '
        'txtHorasReal
        '
        Me.TryDataBinding(txtHorasReal, New System.Windows.Forms.Binding("Value", Me, "HorasReal", True))
        Me.txtHorasReal.DisabledBackColor = System.Drawing.Color.White
        Me.txtHorasReal.Enabled = False
        Me.txtHorasReal.Location = New System.Drawing.Point(89, 70)
        Me.txtHorasReal.Name = "txtHorasReal"
        Me.txtHorasReal.Size = New System.Drawing.Size(83, 21)
        Me.txtHorasReal.TabIndex = 25
        '
        'lblFechaFinReal
        '
        Me.lblFechaFinReal.Location = New System.Drawing.Point(10, 48)
        Me.lblFechaFinReal.Name = "lblFechaFinReal"
        Me.lblFechaFinReal.Size = New System.Drawing.Size(60, 13)
        Me.lblFechaFinReal.TabIndex = 26
        Me.lblFechaFinReal.Tag = "IdRec=5288;"
        Me.lblFechaFinReal.Text = "Fecha Fin"
        '
        'lblFechaInicioReal
        '
        Me.lblFechaInicioReal.Location = New System.Drawing.Point(10, 25)
        Me.lblFechaInicioReal.Name = "lblFechaInicioReal"
        Me.lblFechaInicioReal.Size = New System.Drawing.Size(75, 13)
        Me.lblFechaInicioReal.TabIndex = 27
        Me.lblFechaInicioReal.Tag = "IdRec=5165;"
        Me.lblFechaInicioReal.Text = "Fecha Inicio"
        '
        'txtDescTrabajo
        '
        Me.TryDataBinding(txtDescTrabajo, New System.Windows.Forms.Binding("Text", Me.AdvIdTrabajo, "DescTrabajo", True))
        Me.txtDescTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescTrabajo.Enabled = False
        Me.txtDescTrabajo.Location = New System.Drawing.Point(63, 81)
        Me.txtDescTrabajo.Multiline = True
        Me.txtDescTrabajo.Name = "txtDescTrabajo"
        Me.txtDescTrabajo.Size = New System.Drawing.Size(710, 38)
        Me.txtDescTrabajo.TabIndex = 8
        Me.txtDescTrabajo.TabStop = False
        '
        'lblNTarea
        '
        Me.lblNTarea.Location = New System.Drawing.Point(4, 7)
        Me.lblNTarea.Name = "lblNTarea"
        Me.lblNTarea.Size = New System.Drawing.Size(39, 13)
        Me.lblNTarea.TabIndex = 60
        Me.lblNTarea.Tag = "IdRec=6104;"
        Me.lblNTarea.Text = "Tarea"
        '
        'txtNTarea
        '
        Me.TryDataBinding(txtNTarea, New System.Windows.Forms.Binding("Text", Me, "NTarea", True))
        Me.txtNTarea.DisabledBackColor = System.Drawing.Color.White
        Me.txtNTarea.Location = New System.Drawing.Point(63, 3)
        Me.txtNTarea.Name = "txtNTarea"
        Me.txtNTarea.Size = New System.Drawing.Size(116, 23)
        Me.txtNTarea.TabIndex = 0
        '
        'txtDescTarea
        '
        Me.TryDataBinding(txtDescTarea, New System.Windows.Forms.Binding("Text", Me, "DescTarea", True))
        Me.txtDescTarea.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescTarea.Location = New System.Drawing.Point(182, 3)
        Me.txtDescTarea.Name = "txtDescTarea"
        Me.txtDescTarea.Size = New System.Drawing.Size(410, 21)
        Me.txtDescTarea.TabIndex = 1
        '
        'lblPrioridad
        '
        Me.lblPrioridad.Location = New System.Drawing.Point(594, 253)
        Me.lblPrioridad.Name = "lblPrioridad"
        Me.lblPrioridad.Size = New System.Drawing.Size(58, 13)
        Me.lblPrioridad.TabIndex = 61
        Me.lblPrioridad.Tag = "IdRec=4705;"
        Me.lblPrioridad.Text = "Prioridad"
        '
        'cbxPrioridad
        '
        Me.TryDataBinding(cbxPrioridad, New System.Windows.Forms.Binding("Value", Me, "Prioridad", True))
        cbxPrioridad_DesignTimeLayout.LayoutString = resources.GetString("cbxPrioridad_DesignTimeLayout.LayoutString")
        Me.cbxPrioridad.DesignTimeLayout = cbxPrioridad_DesignTimeLayout
        Me.cbxPrioridad.DisabledBackColor = System.Drawing.Color.White
        Me.cbxPrioridad.DisplayMember = "Value"
        Me.cbxPrioridad.Location = New System.Drawing.Point(658, 249)
        Me.cbxPrioridad.Name = "cbxPrioridad"
        Me.cbxPrioridad.PrimaryDataFields = "Prioridad"
        Me.cbxPrioridad.SecondaryDataFields = "Value"
        Me.cbxPrioridad.SelectedIndex = -1
        Me.cbxPrioridad.SelectedItem = Nothing
        Me.cbxPrioridad.Size = New System.Drawing.Size(115, 21)
        Me.cbxPrioridad.TabIndex = 14
        '
        'lblFechaTarea
        '
        Me.lblFechaTarea.Location = New System.Drawing.Point(594, 7)
        Me.lblFechaTarea.Name = "lblFechaTarea"
        Me.lblFechaTarea.Size = New System.Drawing.Size(76, 13)
        Me.lblFechaTarea.TabIndex = 62
        Me.lblFechaTarea.Tag = "IdRec=12778;"
        Me.lblFechaTarea.Text = "Fecha Tarea"
        '
        'cbxFechaTarea
        '
        Me.TryDataBinding(cbxFechaTarea, New System.Windows.Forms.Binding("BindableValue", Me, "FechaTarea", True))
        Me.cbxFechaTarea.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaTarea.Location = New System.Drawing.Point(674, 3)
        Me.cbxFechaTarea.Name = "cbxFechaTarea"
        Me.cbxFechaTarea.Size = New System.Drawing.Size(99, 21)
        Me.cbxFechaTarea.TabIndex = 2
        '
        'lblEstado
        '
        Me.lblEstado.Location = New System.Drawing.Point(594, 34)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(45, 13)
        Me.lblEstado.TabIndex = 63
        Me.lblEstado.Tag = "IdRec=4405;"
        Me.lblEstado.Text = "Estado"
        '
        'cbxEstado
        '
        Me.cbxEstado.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList
        Me.TryDataBinding(cbxEstado, New System.Windows.Forms.Binding("Value", Me, "Estado", True))
        cbxEstado_DesignTimeLayout.LayoutString = resources.GetString("cbxEstado_DesignTimeLayout.LayoutString")
        Me.cbxEstado.DesignTimeLayout = cbxEstado_DesignTimeLayout
        Me.cbxEstado.DisabledBackColor = System.Drawing.Color.White
        Me.cbxEstado.DisplayMember = "Value"
        Me.cbxEstado.Location = New System.Drawing.Point(658, 29)
        Me.cbxEstado.Name = "cbxEstado"
        Me.cbxEstado.PrimaryDataFields = "Estado"
        Me.cbxEstado.SecondaryDataFields = "Value"
        Me.cbxEstado.SelectedIndex = -1
        Me.cbxEstado.SelectedItem = Nothing
        Me.cbxEstado.Size = New System.Drawing.Size(115, 21)
        Me.cbxEstado.TabIndex = 4
        '
        'lblTexto
        '
        Me.lblTexto.Location = New System.Drawing.Point(4, 269)
        Me.lblTexto.Name = "lblTexto"
        Me.lblTexto.Size = New System.Drawing.Size(38, 13)
        Me.lblTexto.TabIndex = 64
        Me.lblTexto.Tag = "IdRec=5257;"
        Me.lblTexto.Text = "Texto"
        '
        'lblTrabajo
        '
        Me.lblTrabajo.Location = New System.Drawing.Point(4, 58)
        Me.lblTrabajo.Name = "lblTrabajo"
        Me.lblTrabajo.Size = New System.Drawing.Size(50, 13)
        Me.lblTrabajo.TabIndex = 65
        Me.lblTrabajo.Tag = ""
        Me.lblTrabajo.Text = "Trabajo"
        '
        'AdvIdTrabajo
        '
        Me.TryDataBinding(AdvIdTrabajo, New System.Windows.Forms.Binding("Value", Me, "IDTrabajo", True))
        Me.AdvIdTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIdTrabajo.DisplayField = "CodTrabajo"
        Me.AdvIdTrabajo.EntityName = "ObraTrabajo"
        Me.AdvIdTrabajo.Location = New System.Drawing.Point(63, 55)
        Me.AdvIdTrabajo.Name = "AdvIdTrabajo"
        Me.AdvIdTrabajo.PrimaryDataFields = "IDTrabajo"
        Me.AdvIdTrabajo.SecondaryDataFields = "IDTrabajo"
        Me.AdvIdTrabajo.Size = New System.Drawing.Size(116, 23)
        Me.AdvIdTrabajo.TabIndex = 5
        '
        'lblObra
        '
        Me.lblObra.Location = New System.Drawing.Point(4, 33)
        Me.lblObra.Name = "lblObra"
        Me.lblObra.Size = New System.Drawing.Size(57, 13)
        Me.lblObra.TabIndex = 66
        Me.lblObra.Tag = ""
        Me.lblObra.Text = "Proyecto"
        '
        'AdvIDObra
        '
        Me.TryDataBinding(AdvIDObra, New System.Windows.Forms.Binding("Value", Me, "IDObra", True))
        Me.AdvIDObra.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDObra.DisplayField = "NObra"
        Me.AdvIDObra.EntityName = "ObraCabecera"
        Me.AdvIDObra.Location = New System.Drawing.Point(63, 29)
        Me.AdvIDObra.Name = "AdvIDObra"
        Me.AdvIDObra.PrimaryDataFields = "IDObra"
        Me.AdvIDObra.SecondaryDataFields = "IDObra"
        Me.AdvIDObra.Size = New System.Drawing.Size(116, 23)
        Me.AdvIDObra.TabIndex = 3
        '
        'lblTipoTarea
        '
        Me.lblTipoTarea.Location = New System.Drawing.Point(213, 59)
        Me.lblTipoTarea.Name = "lblTipoTarea"
        Me.lblTipoTarea.Size = New System.Drawing.Size(67, 13)
        Me.lblTipoTarea.TabIndex = 67
        Me.lblTipoTarea.Tag = "IdRec=12766;"
        Me.lblTipoTarea.Text = "Tipo Tarea"
        '
        'ulDescTipoTarea
        '
        Me.TryDataBinding(ulDescTipoTarea, New System.Windows.Forms.Binding("Text", Me.AdvTipoTarea, "DescTipoTarea", True))
        Me.ulDescTipoTarea.Location = New System.Drawing.Point(361, 54)
        Me.ulDescTipoTarea.Name = "ulDescTipoTarea"
        Me.ulDescTipoTarea.Size = New System.Drawing.Size(125, 23)
        Me.ulDescTipoTarea.TabIndex = 68
        '
        'lblIncidencia
        '
        Me.lblIncidencia.Location = New System.Drawing.Point(501, 59)
        Me.lblIncidencia.Name = "lblIncidencia"
        Me.lblIncidencia.Size = New System.Drawing.Size(65, 13)
        Me.lblIncidencia.TabIndex = 69
        Me.lblIncidencia.Tag = "IdRec=5863;"
        Me.lblIncidencia.Text = "Incidencia"
        '
        'ulDescIncidencia
        '
        Me.TryDataBinding(ulDescIncidencia, New System.Windows.Forms.Binding("Text", Me.cbxIDIncidencia, "DescIncidencia", True))
        Me.ulDescIncidencia.Location = New System.Drawing.Point(649, 55)
        Me.ulDescIncidencia.Name = "ulDescIncidencia"
        Me.ulDescIncidencia.Size = New System.Drawing.Size(125, 21)
        Me.ulDescIncidencia.TabIndex = 70
        '
        'cbxIDIncidencia
        '
        Me.TryDataBinding(cbxIDIncidencia, New System.Windows.Forms.Binding("Value", Me, "IDIncidencia", True))
        cbxIDIncidencia_DesignTimeLayout.LayoutString = resources.GetString("cbxIDIncidencia_DesignTimeLayout.LayoutString")
        Me.cbxIDIncidencia.DesignTimeLayout = cbxIDIncidencia_DesignTimeLayout
        Me.cbxIDIncidencia.DisabledBackColor = System.Drawing.Color.White
        Me.cbxIDIncidencia.DisplayMember = "IDIncidencia"
        Me.cbxIDIncidencia.EntityName = "Incidencia"
        Me.cbxIDIncidencia.Location = New System.Drawing.Point(571, 55)
        Me.cbxIDIncidencia.Name = "cbxIDIncidencia"
        Me.cbxIDIncidencia.PrimaryDataFields = "IDIncidencia"
        Me.cbxIDIncidencia.SecondaryDataFields = "IDIncidencia"
        Me.cbxIDIncidencia.SelectedIndex = -1
        Me.cbxIDIncidencia.SelectedItem = Nothing
        Me.cbxIDIncidencia.Size = New System.Drawing.Size(75, 21)
        Me.cbxIDIncidencia.TabIndex = 7
        Me.cbxIDIncidencia.ValueMember = "IDIncidencia"
        Me.cbxIDIncidencia.ViewName = "tbMaestroIncidencia"
        '
        'txtEmail
        '
        Me.txtEmail.DisabledBackColor = System.Drawing.Color.White
        Me.txtEmail.Enabled = False
        Me.txtEmail.Location = New System.Drawing.Point(16, 79)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(49, 21)
        Me.txtEmail.TabIndex = 54
        Me.txtEmail.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.txtTexto)
        Me.Panel2.Location = New System.Drawing.Point(0, 288)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(784, 145)
        Me.Panel2.TabIndex = 15
        '
        'txtTexto
        '
        Me.txtTexto.AcceptsTab = True
        Me.txtTexto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TryDataBinding(txtTexto, New System.Windows.Forms.Binding("Text", Me, "Texto", True))
        Me.txtTexto.DisabledBackColor = System.Drawing.Color.White
        Me.txtTexto.Location = New System.Drawing.Point(8, 0)
        Me.txtTexto.Multiline = True
        Me.txtTexto.Name = "txtTexto"
        Me.txtTexto.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtTexto.Size = New System.Drawing.Size(771, 143)
        Me.txtTexto.TabIndex = 28
        '
        'MntoObraTarea
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(792, 509)
        Me.EntityName = "ObraTarea"
        Me.Name = "MntoObraTarea"
        Me.NavigationFields = "NTarea"
        Me.NoEditableControls = New Solmicro.Expertis.Engine.UI.NoEditableControls(New System.Windows.Forms.Control() {Me.txtNTarea})
        Me.ViewName = "frmMntoObraTarea"
        CType(Me.ToolBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.FraPrev.ResumeLayout(False)
        Me.FraPrev.PerformLayout()
        Me.FraOtros.ResumeLayout(False)
        Me.FraOtros.PerformLayout()
        Me.FraOperario.ResumeLayout(False)
        Me.FraOperario.PerformLayout()
        Me.FraSolicitadaPor.ResumeLayout(False)
        Me.FraSolicitadaPor.PerformLayout()
        Me.FraReal.ResumeLayout(False)
        Me.FraReal.PerformLayout()
        CType(Me.cbxPrioridad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxEstado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxIDIncidencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Load "

    Private Sub MntoObraTarea_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        If Not IsNothing(Me.Params) And Me.RecordsState = RecordsState.Initialize Then Me.RecordsState = RecordsState.[New]
    End Sub

    Private Sub MntoObraTarea_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadEnums()
        LoadParams()
    End Sub

    Private Sub LoadEnums()
        cbxPrioridad.DataSource = New EnumData("enumotaPrioridad")
        cbxEstado.DataSource = New EnumData("enumotaEstado")
    End Sub

    Private Sub LoadParams()
        Dim HT As Hashtable = Me.Params
        If Not IsNothing(HT) Then
            If HT.ContainsKey("Consulta") AndAlso Not Nz(HT("Consulta"), True) Then Me.AddNew()
            AdvIDObra.Value = HT("IDObra")
            AdvIDObra.Text = HT("NObra")
            AdvIdTrabajo.Value = HT("IDTrabajo")
            AdvIdTrabajo.Text = HT("CodTrabajo")
            Me.RecordsState = RecordsState.Modified
        End If
    End Sub

#End Region

    Private Sub MntoObraTarea_Navigated(ByVal sender As Object, ByVal e As Solmicro.Expertis.Engine.UI.NavigatedEventArgs) Handles MyBase.Navigated
        If Not IsNothing(Me.CurrentData) AndAlso Me.CurrentData.Rows.Count > 0 Then
            If Length(AdvTipoTarea.Text) > 0 Then
                cbxIDIncidencia.Enabled = Me.CurrentRow("Incidencia")
            Else
                cbxIDIncidencia.Enabled = False
            End If
        End If
    End Sub

    Private Sub AdvTipoTarea_SelectionChanged(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchSelectionChangedEventArgs) Handles AdvTipoTarea.SelectionChanged
        cbxIDIncidencia.Enabled = e.Selected.Rows(0)("Incidencia")
    End Sub

    Private Sub AdvIdTrabajo_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles AdvIdTrabajo.SetPredefinedFilter
        If Length(AdvIDObra.Value) > 0 Then e.Filter.Add(New NumberFilterItem("IDObra", AdvIDObra.Value))
    End Sub

    Private Sub AdvIdTrabajo_SelectionChanged(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchSelectionChangedEventArgs) Handles AdvIdTrabajo.SelectionChanged
        If Length(AdvIDObra.Value) = 0 Then AdvIDObra.Value = e.Selected.Rows(0)("IDObra")
    End Sub

    Private Sub AdvIDObra_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles AdvIDObra.SelectionChanged
        If Length(AdvIDObra.Value) > 0 Then AdvIdTrabajo.Value = String.Empty
    End Sub

    Private Sub advIDOperario_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles advIDOperario.SetPredefinedFilter
        If Length(AdvIDOficio.Text) > 0 Then e.Filter.Add(New StringFilterItem("IDOficio", AdvIDOficio.Text))
    End Sub

    Private Sub advIDOperario_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles advIDOperario.SelectionChanged
        AdvIDOficio.Text = e.Selected.Rows(0)("IDOficio") & String.Empty
    End Sub

#Region " Informes "
    '    Private Sub MntoObraTarea_SetReportProperties() Handles MyBase.SetReportProperties
    '        Dim FwCriterio As clsFilterCriteria
    '        Dim strFiltro As String

    '        If objReport.Alias = "VRptTareasOperario" Then
    '            FwCriterio = New clsFilterCriteria
    '            With FwCriterio
    '                .Alias = objReport.Alias
    '                .WhereFormat = wfCrystal
    '                .AddFilterItem("NTarea", dtNumeric, opEqual, FwiNTarea.Value)
    '                strFiltro = .GenerateFilterCriterias
    '                objReport.SelectionFormula = strFiltro
    '            End With
    '            objReport.Destination = fwmToEmail
    '            objReport.MailToList = txtEmail.text
    '            objReport.ExportFormat = cefRichText
    '        ElseIf (objReport.Name = "TAREAS") Or (objReport.Name = "TAREASVB") Then
    '            FwCriterio = New clsFilterCriteria
    '            With FwCriterio
    '                .Alias = objReport.Alias
    '                .WhereFormat = wfCrystal
    '                .AddFilterItem("NTarea", dtNumeric, opEqual, FwiNTarea.Value)
    '                strFiltro = .GenerateFilterCriterias
    '                objReport.SelectionFormula = strFiltro
    '            End With
    '        End If
#End Region

    Private Sub txtTexto_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTexto.KeyUp
        If Me.RecordsState <> UI.RecordsState.Saved Then
            If e.KeyCode = Keys.F9 Then Me.Ok.InvokeOnClick()
        End If
    End Sub

   
End Class