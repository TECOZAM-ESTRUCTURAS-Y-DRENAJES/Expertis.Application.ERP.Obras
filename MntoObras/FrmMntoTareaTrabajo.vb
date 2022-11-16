Public Class FrmMntoTareaTrabajo
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
    Friend WithEvents FrmCabecera As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents PnlButtons As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents FrmTareas As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents BtnAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents BtnCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents GridTareas As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents LblIDObra As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LblTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LblDescObra As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LblDescTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents TxtObra As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents TxtDescObra As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents TxtTrabajo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents TxtDescTrabajo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents FrmFechas As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents LblFechaInicio As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LblFechaFin As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ClbFechaInicio As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents ClbFechaFin As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents PnlMarcas As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents ImgList As System.Windows.Forms.ImageList
    Friend WithEvents BtnMarcarTodos As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents BtnDesmarcarTodos As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvTipoTarea As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents BtnQuitarFiltro As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents BtnFiltrar As Solmicro.Expertis.Engine.UI.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim GridTareas_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridTareas_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.ImageList.ImageStream")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMntoTareaTrabajo))
        Me.FrmCabecera = New Solmicro.Expertis.Engine.UI.Frame
        Me.TxtDescTrabajo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.TxtTrabajo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.TxtDescObra = New Solmicro.Expertis.Engine.UI.TextBox
        Me.TxtObra = New Solmicro.Expertis.Engine.UI.TextBox
        Me.LblDescTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.LblDescObra = New Solmicro.Expertis.Engine.UI.Label
        Me.LblTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.LblIDObra = New Solmicro.Expertis.Engine.UI.Label
        Me.FrmTareas = New Solmicro.Expertis.Engine.UI.Frame
        Me.GridTareas = New Solmicro.Expertis.Engine.UI.Grid
        Me.ImgList = New System.Windows.Forms.ImageList(Me.components)
        Me.PnlMarcas = New Solmicro.Expertis.Engine.UI.Panel
        Me.BtnQuitarFiltro = New Solmicro.Expertis.Engine.UI.Button
        Me.BtnFiltrar = New Solmicro.Expertis.Engine.UI.Button
        Me.AdvTipoTarea = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.BtnDesmarcarTodos = New Solmicro.Expertis.Engine.UI.Button
        Me.BtnMarcarTodos = New Solmicro.Expertis.Engine.UI.Button
        Me.PnlButtons = New Solmicro.Expertis.Engine.UI.Panel
        Me.BtnCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.BtnAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.FrmFechas = New Solmicro.Expertis.Engine.UI.Frame
        Me.ClbFechaFin = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.ClbFechaInicio = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.LblFechaFin = New Solmicro.Expertis.Engine.UI.Label
        Me.LblFechaInicio = New Solmicro.Expertis.Engine.UI.Label
        Me.FrmCabecera.SuspendLayout()
        Me.FrmTareas.SuspendLayout()
        CType(Me.GridTareas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlMarcas.suspendlayout()
        Me.PnlButtons.suspendlayout()
        Me.FrmFechas.SuspendLayout()
        Me.SuspendLayout()
        '
        'FrmCabecera
        '
        Me.FrmCabecera.Controls.Add(Me.TxtDescTrabajo)
        Me.FrmCabecera.Controls.Add(Me.TxtTrabajo)
        Me.FrmCabecera.Controls.Add(Me.TxtDescObra)
        Me.FrmCabecera.Controls.Add(Me.TxtObra)
        Me.FrmCabecera.Controls.Add(Me.LblDescTrabajo)
        Me.FrmCabecera.Controls.Add(Me.LblDescObra)
        Me.FrmCabecera.Controls.Add(Me.LblTrabajo)
        Me.FrmCabecera.Controls.Add(Me.LblIDObra)
        Me.FrmCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.FrmCabecera.Location = New System.Drawing.Point(0, 0)
        Me.FrmCabecera.Name = "FrmCabecera"
        Me.FrmCabecera.Size = New System.Drawing.Size(794, 80)
        Me.FrmCabecera.TabIndex = 0
        Me.FrmCabecera.TabStop = False
        Me.FrmCabecera.Text = "Datos Cabecera"
        '
        'TxtDescTrabajo
        '
        Me.TxtDescTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.TxtDescTrabajo.Enabled = False
        Me.TxtDescTrabajo.Location = New System.Drawing.Point(296, 48)
        Me.TxtDescTrabajo.Name = "TxtDescTrabajo"
        Me.TxtDescTrabajo.Size = New System.Drawing.Size(488, 21)
        Me.TxtDescTrabajo.TabIndex = 7
        '
        'TxtTrabajo
        '
        Me.TxtTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.TxtTrabajo.Enabled = False
        Me.TxtTrabajo.Location = New System.Drawing.Point(70, 48)
        Me.TxtTrabajo.Name = "TxtTrabajo"
        Me.TxtTrabajo.Size = New System.Drawing.Size(112, 21)
        Me.TxtTrabajo.TabIndex = 6
        '
        'TxtDescObra
        '
        Me.TxtDescObra.DisabledBackColor = System.Drawing.Color.White
        Me.TxtDescObra.Enabled = False
        Me.TxtDescObra.Location = New System.Drawing.Point(296, 24)
        Me.TxtDescObra.Name = "TxtDescObra"
        Me.TxtDescObra.Size = New System.Drawing.Size(488, 21)
        Me.TxtDescObra.TabIndex = 5
        '
        'TxtObra
        '
        Me.TxtObra.DisabledBackColor = System.Drawing.Color.White
        Me.TxtObra.Enabled = False
        Me.TxtObra.Location = New System.Drawing.Point(70, 24)
        Me.TxtObra.Name = "TxtObra"
        Me.TxtObra.Size = New System.Drawing.Size(112, 21)
        Me.TxtObra.TabIndex = 4
        '
        'LblDescTrabajo
        '
        Me.LblDescTrabajo.Location = New System.Drawing.Point(200, 52)
        Me.LblDescTrabajo.Name = "LblDescTrabajo"
        Me.LblDescTrabajo.Size = New System.Drawing.Size(86, 13)
        Me.LblDescTrabajo.TabIndex = 3
        Me.LblDescTrabajo.Text = "Desc. Trabajo"
        Me.LblDescTrabajo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblDescObra
        '
        Me.LblDescObra.Location = New System.Drawing.Point(200, 28)
        Me.LblDescObra.Name = "LblDescObra"
        Me.LblDescObra.Size = New System.Drawing.Size(93, 13)
        Me.LblDescObra.TabIndex = 2
        Me.LblDescObra.Text = "Desc. Proyecto"
        Me.LblDescObra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblTrabajo
        '
        Me.LblTrabajo.Location = New System.Drawing.Point(8, 52)
        Me.LblTrabajo.Name = "LblTrabajo"
        Me.LblTrabajo.Size = New System.Drawing.Size(50, 13)
        Me.LblTrabajo.TabIndex = 1
        Me.LblTrabajo.Text = "Trabajo"
        Me.LblTrabajo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblIDObra
        '
        Me.LblIDObra.Location = New System.Drawing.Point(8, 28)
        Me.LblIDObra.Name = "LblIDObra"
        Me.LblIDObra.Size = New System.Drawing.Size(57, 13)
        Me.LblIDObra.TabIndex = 0
        Me.LblIDObra.Text = "Proyecto"
        Me.LblIDObra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FrmTareas
        '
        Me.FrmTareas.Controls.Add(Me.GridTareas)
        Me.FrmTareas.Controls.Add(Me.PnlMarcas)
        Me.FrmTareas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FrmTareas.Location = New System.Drawing.Point(0, 80)
        Me.FrmTareas.Name = "FrmTareas"
        Me.FrmTareas.Size = New System.Drawing.Size(794, 295)
        Me.FrmTareas.TabIndex = 0
        Me.FrmTareas.TabStop = False
        Me.FrmTareas.Text = "Seleccione las Tareas que desee volcar al Trabajo"
        '
        'GridTareas
        '
        Me.GridTareas.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDOperario", "Operario", "IDOperario"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDOperarioSolicitante", "Operario", "IDOperario")})
        Me.GridTareas.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridTareas.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridTareas_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("GridTareas_DesignTimeLayout_Reference_0.Instance"), Object)
        GridTareas_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {GridTareas_DesignTimeLayout_Reference_0})
        GridTareas_DesignTimeLayout.LayoutString = resources.GetString("GridTareas_DesignTimeLayout.LayoutString")
        Me.GridTareas.DesignTimeLayout = GridTareas_DesignTimeLayout
        Me.GridTareas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridTareas.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridTareas.EntityName = ""
        Me.GridTareas.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridTareas.ImageList = Me.ImgList
        Me.GridTareas.KeyField = "IDTareaPredefinida"
        Me.GridTareas.Location = New System.Drawing.Point(3, 17)
        Me.GridTareas.Name = "GridTareas"
        Me.GridTareas.PrimaryDataFields = Nothing
        Me.GridTareas.SecondaryDataFields = Nothing
        Me.GridTareas.Size = New System.Drawing.Size(788, 239)
        Me.GridTareas.TabIndex = 0
        Me.GridTareas.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridTareas.UseCheck = True
        Me.GridTareas.ViewName = ""
        '
        'ImgList
        '
        Me.ImgList.ImageStream = CType(resources.GetObject("ImgList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImgList.TransparentColor = System.Drawing.Color.Transparent
        Me.ImgList.Images.SetKeyName(0, "")
        Me.ImgList.Images.SetKeyName(1, "")
        Me.ImgList.Images.SetKeyName(2, "")
        Me.ImgList.Images.SetKeyName(3, "")
        Me.ImgList.Images.SetKeyName(4, "folder_edit.ico")
        '
        'PnlMarcas
        '
        Me.PnlMarcas.Controls.Add(Me.BtnQuitarFiltro)
        Me.PnlMarcas.Controls.Add(Me.BtnFiltrar)
        Me.PnlMarcas.Controls.Add(Me.AdvTipoTarea)
        Me.PnlMarcas.Controls.Add(Me.Label1)
        Me.PnlMarcas.Controls.Add(Me.BtnDesmarcarTodos)
        Me.PnlMarcas.Controls.Add(Me.BtnMarcarTodos)
        Me.PnlMarcas.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlMarcas.Location = New System.Drawing.Point(3, 256)
        Me.PnlMarcas.Name = "PnlMarcas"
        Me.PnlMarcas.Size = New System.Drawing.Size(788, 36)
        Me.PnlMarcas.TabIndex = 1
        '
        'BtnQuitarFiltro
        '
        Me.BtnQuitarFiltro.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.BtnQuitarFiltro.ImageIndex = 3
        Me.BtnQuitarFiltro.ImageList = Me.ImgList
        Me.BtnQuitarFiltro.Location = New System.Drawing.Point(688, 8)
        Me.BtnQuitarFiltro.Name = "BtnQuitarFiltro"
        Me.BtnQuitarFiltro.Size = New System.Drawing.Size(96, 23)
        Me.BtnQuitarFiltro.TabIndex = 5
        Me.BtnQuitarFiltro.Text = "Quitar Filtro"
        '
        'BtnFiltrar
        '
        Me.BtnFiltrar.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button
        Me.BtnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.BtnFiltrar.ImageIndex = 2
        Me.BtnFiltrar.ImageList = Me.ImgList
        Me.BtnFiltrar.Location = New System.Drawing.Point(584, 8)
        Me.BtnFiltrar.Name = "BtnFiltrar"
        Me.BtnFiltrar.Size = New System.Drawing.Size(96, 23)
        Me.BtnFiltrar.TabIndex = 4
        Me.BtnFiltrar.Text = "Filtrar"
        '
        'AdvTipoTarea
        '
        Me.AdvTipoTarea.DisabledBackColor = System.Drawing.Color.White
        Me.AdvTipoTarea.EntityName = "TipoTarea"
        Me.AdvTipoTarea.Location = New System.Drawing.Point(464, 8)
        Me.AdvTipoTarea.Name = "AdvTipoTarea"
        Me.AdvTipoTarea.SecondaryDataFields = "IDTipoTarea"
        Me.AdvTipoTarea.Size = New System.Drawing.Size(104, 23)
        Me.AdvTipoTarea.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(332, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Filtrar por Tipo Tarea"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnDesmarcarTodos
        '
        Me.BtnDesmarcarTodos.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.BtnDesmarcarTodos.ImageIndex = 1
        Me.BtnDesmarcarTodos.ImageList = Me.ImgList
        Me.BtnDesmarcarTodos.Location = New System.Drawing.Point(144, 8)
        Me.BtnDesmarcarTodos.Name = "BtnDesmarcarTodos"
        Me.BtnDesmarcarTodos.Size = New System.Drawing.Size(128, 23)
        Me.BtnDesmarcarTodos.TabIndex = 1
        Me.BtnDesmarcarTodos.Text = "Desmarcar Todos"
        '
        'BtnMarcarTodos
        '
        Me.BtnMarcarTodos.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button
        Me.BtnMarcarTodos.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.BtnMarcarTodos.ImageIndex = 0
        Me.BtnMarcarTodos.ImageList = Me.ImgList
        Me.BtnMarcarTodos.Location = New System.Drawing.Point(8, 8)
        Me.BtnMarcarTodos.Name = "BtnMarcarTodos"
        Me.BtnMarcarTodos.Size = New System.Drawing.Size(128, 23)
        Me.BtnMarcarTodos.TabIndex = 0
        Me.BtnMarcarTodos.Text = "Marcar Todos"
        '
        'PnlButtons
        '
        Me.PnlButtons.Controls.Add(Me.BtnCancelar)
        Me.PnlButtons.Controls.Add(Me.BtnAceptar)
        Me.PnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlButtons.Location = New System.Drawing.Point(0, 431)
        Me.PnlButtons.Name = "PnlButtons"
        Me.PnlButtons.Size = New System.Drawing.Size(794, 48)
        Me.PnlButtons.TabIndex = 2
        '
        'BtnCancelar
        '
        Me.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancelar.Location = New System.Drawing.Point(411, 8)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(96, 32)
        Me.BtnCancelar.TabIndex = 4
        Me.BtnCancelar.Text = "&Cancelar"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(288, 8)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(99, 32)
        Me.BtnAceptar.TabIndex = 3
        Me.BtnAceptar.Text = "&Aceptar"
        '
        'FrmFechas
        '
        Me.FrmFechas.Controls.Add(Me.ClbFechaFin)
        Me.FrmFechas.Controls.Add(Me.ClbFechaInicio)
        Me.FrmFechas.Controls.Add(Me.LblFechaFin)
        Me.FrmFechas.Controls.Add(Me.LblFechaInicio)
        Me.FrmFechas.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FrmFechas.Location = New System.Drawing.Point(0, 375)
        Me.FrmFechas.Name = "FrmFechas"
        Me.FrmFechas.Size = New System.Drawing.Size(794, 56)
        Me.FrmFechas.TabIndex = 1
        Me.FrmFechas.TabStop = False
        Me.FrmFechas.Text = "Fechas de Inicio / Fin para Tareas Predefinidas sin Fechas Definidas"
        '
        'ClbFechaFin
        '
        Me.ClbFechaFin.DisabledBackColor = System.Drawing.Color.White
        Me.ClbFechaFin.Location = New System.Drawing.Point(672, 24)
        Me.ClbFechaFin.Name = "ClbFechaFin"
        Me.ClbFechaFin.Size = New System.Drawing.Size(112, 21)
        Me.ClbFechaFin.TabIndex = 2
        '
        'ClbFechaInicio
        '
        Me.ClbFechaInicio.DisabledBackColor = System.Drawing.Color.White
        Me.ClbFechaInicio.Location = New System.Drawing.Point(120, 24)
        Me.ClbFechaInicio.Name = "ClbFechaInicio"
        Me.ClbFechaInicio.Size = New System.Drawing.Size(112, 21)
        Me.ClbFechaInicio.TabIndex = 1
        '
        'LblFechaFin
        '
        Me.LblFechaFin.Location = New System.Drawing.Point(574, 28)
        Me.LblFechaFin.Name = "LblFechaFin"
        Me.LblFechaFin.Size = New System.Drawing.Size(93, 13)
        Me.LblFechaFin.TabIndex = 1
        Me.LblFechaFin.Text = "Fecha Fin Prev."
        Me.LblFechaFin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblFechaInicio
        '
        Me.LblFechaInicio.Location = New System.Drawing.Point(7, 27)
        Me.LblFechaInicio.Name = "LblFechaInicio"
        Me.LblFechaInicio.Size = New System.Drawing.Size(108, 13)
        Me.LblFechaInicio.TabIndex = 0
        Me.LblFechaInicio.Text = "Fecha Inicio Prev."
        Me.LblFechaInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FrmMntoTareaTrabajo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(794, 479)
        Me.Controls.Add(Me.FrmTareas)
        Me.Controls.Add(Me.FrmFechas)
        Me.Controls.Add(Me.PnlButtons)
        Me.Controls.Add(Me.FrmCabecera)
        Me.HelpButton = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMntoTareaTrabajo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tareas Predefinidas"
        Me.FrmCabecera.ResumeLayout(False)
        Me.FrmCabecera.PerformLayout()
        Me.FrmTareas.ResumeLayout(False)
        CType(Me.GridTareas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlMarcas.ResumeLayout(False)
        Me.PnlMarcas.PerformLayout()
        Me.PnlButtons.ResumeLayout(False)
        Me.FrmFechas.ResumeLayout(False)
        Me.FrmFechas.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region


#Region "Variables / Propiedades"

    Private mIDObra, mIDTrabajo As Integer
    Private MDtGrid As DataTable

    Public ReadOnly Property DtTareas() As DataTable
        Get
            Return MDtGrid
        End Get
    End Property

#End Region

#Region "Procesos / Funciones"

    Private Function ComprobarDatos() As Boolean
        '1º.- Revisamos si hay tareas sin fechas de inicio establecidas y completar los datos de fechas de inicio
        'con el valor que establezcamos en el control. Si no asimismo controlamos que el control tenga datos para avisar.
        Dim BlnSinFecha As Boolean
        For Each Dr As DataRow In MDtGrid.Select
            If length(Dr("FechaInicioPrev")) = 0 Then
                If length(ClbFechaInicio.Value) > 0 Then
                    Dr("FechaInicio") = ClbFechaInicio.Value
                Else
                    BlnSinFecha = True
                End If
            End If
            If length(Dr("FechaFinPrev")) = 0 AndAlso length(ClbFechaFin.Value) > 0 Then
                Dr("FechaFin") = ClbFechaFin.Value
            End If
        Next
        If BlnSinFecha Then
            ExpertisApp.GenerateMessage("Existen Tareas sin Fecha de Inicio establecida.|Por favor, establezca una por defecto para estas tareas.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, vbNewLine)
            Return False
        End If
        '2º.- Revisamos para las Tareas que tengan establecidas como Fechas de Inicio / Fin las del Trabajo,
        'estén con valores. Si no avisaremos al cliente que no se incluirán en el proceso para que revisen los datos.
        Dim DtTrab As DataTable = New ObraTrabajo().SelOnPrimaryKey(mIDTrabajo)
        Dim DtObra As DataTable = New ObraCabecera().SelOnPrimaryKey(mIDObra)
        For Each Dr2 As DataRow In MDtGrid.Select
            Dr2("IDTrabajo") = mIDTrabajo
            If length(Dr2("FechaInicioPrev")) > 0 Then
                Select Case CInt(Dr2("FechaInicioPrev"))
                    Case EnumFechasObraTrabajo.enumFechaInicioTrabajo
                        If length(DtTrab.Rows(0)("FechaInicio")) > 0 Then
                            Dr2("FechaInicio") = DtTrab.Rows(0)("FechaInicio")
                        Else
                            If length(ClbFechaInicio.Value) > 0 Then
                                Dr2("FechaInicio") = ClbFechaInicio.Value
                            Else
                                ExpertisApp.GenerateMessage("La tarea actual:| tiene como fecha de inicio la del Trabajo.|El Trabajo actual no tiene especificada una fecha de Inicio.|Por favor revise los datos y especifique una fecha de Inicio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, Dr2("DescTarea"), vbNewLine, vbNewLine)
                                Return False
                            End If
                        End If
                    Case EnumFechasObraTrabajo.enumFechaFinTrabajo
                        If length(DtTrab.Rows(0)("FechaFin")) > 0 Then
                            Dr2("FechaInicio") = DtTrab.Rows(0)("FechaFin")
                        Else
                            If length(ClbFechaFin.Value) > 0 Then
                                Dr2("FechaFin") = ClbFechaFin.Value
                            Else
                                ExpertisApp.GenerateMessage("La tarea:| tiene como fecha de fin la del Trabajo.|El Trabajo actual no tiene especificada una fecha de Fin.|Por favor revise los datos y especifique una fecha de fin.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, Dr2("DescTarea"), vbNewLine, vbNewLine)
                                Return False
                            End If
                        End If
                    Case EnumFechasObraTrabajo.enumFechaInicioObra
                        Dr2("FechaInicio") = DtObra.Rows(0)("FechaInicio")
                    Case EnumFechasObraTrabajo.enumFechaFinObra
                        If length(DtObra.Rows(0)("FechaFin")) > 0 Then
                            Dr2("FechaInicio") = DtObra.Rows(0)("Fechafin")
                        Else
                            If length(ClbFechaFin.Value) > 0 Then
                                Dr2("FechaInicio") = ClbFechaInicio.Value
                            Else
                                ExpertisApp.GenerateMessage("La tarea:| tiene como fecha de Inicio la del fin de Obra.|La Obra actual no tiene especificada una fecha de Fin.|Por favor revise los datos y especifique una fecha de fin.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, Dr2("DescTarea"), vbNewLine, vbNewLine)
                                Return False
                            End If
                        End If
                End Select
            End If
            If length(Dr2("FechaFinPrev")) > 0 Then
                Select Case CInt(Dr2("FechaFinPrev"))
                    Case EnumFechasObraTrabajo.enumFechaInicioTrabajo
                        If Length(DtTrab.Rows(0)("FechaInicio")) > 0 Then
                            Dr2("FechaFin") = DtTrab.Rows(0)("FechaInicio")
                        End If
                    Case EnumFechasObraTrabajo.enumFechaFinTrabajo
                        If length(DtTrab.Rows(0)("FechaFin")) > 0 Then
                            Dr2("FechaFin") = DtTrab.Rows(0)("FechaFin")
                        End If
                    Case EnumFechasObraTrabajo.enumFechaInicioObra
                        If length(DtObra.Rows(0)("FechaInicio")) > 0 Then
                            Dr2("FechaFin") = DtObra.Rows(0)("FechaInicio")
                        End If
                    Case EnumFechasObraTrabajo.enumFechaFinObra
                        Dr2("FechaFin") = DtObra.Rows(0)("FechaFin")
                End Select
            End If
        Next
        Return True
    End Function

    Public Function LoadTareasTrabajo(ByVal IntIDObra As Integer, ByVal StrNObra As String, ByVal StrDescObra As String, _
                                      ByVal IntIDTrabajo As Integer, ByVal StrCodTrabajo As String, ByVal StrDescTrabajo As String, _
                                      ByVal StrIDTipoObra As String) As DialogResult

        mIDObra = IntIDObra
        mIDTrabajo = IntIDTrabajo

        TxtObra.Text = StrNObra : TxtTrabajo.Text = StrCodTrabajo
        TxtDescObra.Text = StrDescObra : TxtDescTrabajo.Text = StrDescTrabajo

        EnumData.PopulateValueList("enumcpPeriodo", GridTareas.Columns("Unidad"))
        EnumData.PopulateValueList("EnumFechasObraTrabajo", GridTareas.Columns("FechaInicioPrev"))
        EnumData.PopulateValueList("EnumFechasObraTrabajo", GridTareas.Columns("FechaFinPrev"))
        GridTareas.Columns("Unidad").EditType = EditType.NoEdit
        GridTareas.Columns("Unidad").ButtonStyle = ButtonStyle.NoButton
        GridTareas.Columns("FechaInicioPrev").EditType = EditType.NoEdit
        GridTareas.Columns("FechaInicioPrev").ButtonStyle = ButtonStyle.NoButton
        GridTareas.Columns("FechaFinPrev").EditType = EditType.NoEdit
        GridTareas.Columns("FechaFinPrev").ButtonStyle = ButtonStyle.NoButton
        Dim DtGrid As DataTable = ExpertisApp.ExecuteTask(Of String, DataTable)(AddressOf TareaPredefinida.ObtenerTareasPredefinidas, StrIDTipoObra)
        GridTareas.AddCheckColumnToDataSource(DtGrid, Nothing)
        GridTareas.DataSource = DtGrid
        MDtGrid = GridTareas.DataSource
        MDtGrid.Columns.Add("FechaInicio", GetType(Date))
        MDtGrid.Columns.Add("FechaFin", GetType(Date))
        MDtGrid.Columns.Add("IDTrabajo", GetType(Integer))
        Return Me.ShowDialog
    End Function

#End Region

#Region "Eventos FrmMntoTareaTrabajo"

#Region "Eventos DataGrid"

    Private Sub GridCabecera_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridTareas.Click
        Dim Hit As Janus.Windows.GridEX.GridArea = GridTareas.HitTest()
        If Hit = Janus.Windows.GridEX.GridArea.Cell Then
            Dim c As Janus.Windows.GridEX.GridEXColumn = GridTareas.ColumnFromPoint()
            If Not IsNothing(c) Then
                Select Case c.Key
                    Case "Texto"
                        Dim FrmTexto As New FormularioTexto
                        FrmTexto.Texto = GridTareas.GetValue(c.Key) & String.Empty
                        'FrmTexto.SoloLectura = True
                        If FrmTexto.ShowDialog() = Windows.Forms.DialogResult.OK Then
                            If GridTareas.Value(c.Key) & String.Empty <> FrmTexto.Texto Then
                                GridTareas.SetValue(c.Key, FrmTexto.Texto)
                            End If
                        End If
                End Select
            End If
        End If
    End Sub

#End Region

#Region "Eventos Buttons"

    Private Sub BtnMarcarTodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMarcarTodos.Click
        GridTareas.CheckAllRecords()
    End Sub

    Private Sub BtnDesmarcarTodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDesmarcarTodos.Click
        GridTareas.UnCheckAllRecords()
    End Sub

    Private Sub BtnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFiltrar.Click
        If length(AdvTipoTarea.Value) > 0 Then
            MDtGrid = GridTareas.DataSource
            Dim FilGrid As New Filter
            FilGrid.Add("IDTipoTarea", FilterOperator.Equal, AdvTipoTarea.Value)
            Dim DtGrid As DataTable = MDtGrid.Clone
            Dim Where As String = FilGrid.Compose(New AdoFilterComposer)
            For Each Dr As DataRow In MDtGrid.Select(Where)
                DtGrid.Rows.Add(Dr.ItemArray)
            Next
            GridTareas.DataSource = DtGrid
        End If
    End Sub

    Private Sub BtnQuitarFiltro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuitarFiltro.Click
        AdvTipoTarea.Value = Nothing : AdvTipoTarea.Text = String.Empty
        GridTareas.DataSource = MDtGrid
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        MDtGrid = Nothing : MDtGrid = GridTareas.CheckedRecords
        If Not MDtGrid Is Nothing AndAlso MDtGrid.Rows.Count > 0 Then
            If ComprobarDatos() = True Then Me.DialogResult = DialogResult.OK
        Else
            ExpertisApp.GenerateMessage("Debe seleccionar alguna Tarea.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

#End Region

#End Region

End Class