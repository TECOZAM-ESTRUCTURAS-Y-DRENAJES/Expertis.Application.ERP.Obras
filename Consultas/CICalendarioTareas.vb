Public Class CICalendarioTareas
    Inherits Solmicro.Expertis.Engine.UI.CIMnto

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
    Friend WithEvents PnlCalendar As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents PnlSchdTarea As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents SchdTareas As Janus.Windows.Schedule.Schedule
    Friend WithEvents LblObra As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvObra As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents LblFechaInicioPrev As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LblFechaFinPrev As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ClbFechaInicioPrev As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents ClbFechaFinPrev As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents ImgList As System.Windows.Forms.ImageList
    Friend WithEvents ImgPeriodos As System.Windows.Forms.ImageList
    Friend WithEvents UIPnlCalendario As Janus.Windows.UI.Dock.UIPanelManager
    Friend WithEvents PnlCalendarMes As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents FrmOpciones As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents BtnBarOptions As Janus.Windows.ButtonBar.ButtonBar
    Friend WithEvents CldMesTarea As Janus.Windows.Schedule.Calendar
    Friend WithEvents FrmIrAFecha As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents BtnIrAFecha As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents ClbIrAFecha As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents UIPnlPrincipal As Janus.Windows.UI.Dock.UIPanelGroup
    Friend WithEvents UIPnlOpciones As Janus.Windows.UI.Dock.UIPanel
    Friend WithEvents UIPnlOpcionesContainer As Janus.Windows.UI.Dock.UIPanelInnerContainer
    Friend WithEvents UIPnlTareas As Janus.Windows.UI.Dock.UIPanel
    Friend WithEvents UIPnlTareasContainer As Janus.Windows.UI.Dock.UIPanelInnerContainer
    Friend WithEvents FrmTarea As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents LblColorTarea As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents TxtTarea As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents LblTarea As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents TxtObra As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents LblObraTarea As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents TxtTrabajo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents LblTrabajoTarea As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents TxtFecha As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents LblFecha As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents TxtOperario As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents LblOperario As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents TxtOperarioSol As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents LblOperarioSol As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents TxtEstado As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents LblEstado As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents TxtPrioridad As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents LblPrioridad As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents TxtTipoTarea As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents LblTipoTarea As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LblOperarioFil As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvOperario As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents VerObra As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents OpcionesCalendario As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents InformacionRapida As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents VerDia As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents VerSemana As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents VerSemanaLaboral As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents VerMes As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents CtxCalendario As Janus.Windows.UI.CommandBars.UIContextMenu
    Friend WithEvents VerObra1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Separator1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents OpcionesCalendario1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents InformacionRapida1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Separator2 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents VerDia1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents VerSemanaLaboral1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents VerSemana1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents VerMes1 As Janus.Windows.UI.CommandBars.UICommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CICalendarioTareas))
        Dim SchdTareas_DesignTimeLayout As Janus.Windows.Schedule.ScheduleLayout = New Janus.Windows.Schedule.ScheduleLayout
        Dim BtnBarOptions_Group_0 As Janus.Windows.ButtonBar.ButtonBarGroup = New Janus.Windows.ButtonBar.ButtonBarGroup
        Dim BtnBarOptions_Item_0_0 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem
        Dim BtnBarOptions_Item_0_1 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem
        Dim BtnBarOptions_Item_0_2 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem
        Dim BtnBarOptions_Item_0_3 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem
        Me.PnlCalendar = New Solmicro.Expertis.Engine.UI.Panel
        Me.PnlSchdTarea = New Solmicro.Expertis.Engine.UI.Panel
        Me.SchdTareas = New Janus.Windows.Schedule.Schedule
        Me.ImgPeriodos = New System.Windows.Forms.ImageList(Me.components)
        Me.ImgList = New System.Windows.Forms.ImageList(Me.components)
        Me.LblObra = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvObra = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.LblFechaInicioPrev = New Solmicro.Expertis.Engine.UI.Label
        Me.LblFechaFinPrev = New Solmicro.Expertis.Engine.UI.Label
        Me.ClbFechaInicioPrev = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.ClbFechaFinPrev = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.UIPnlCalendario = New Janus.Windows.UI.Dock.UIPanelManager(Me.components)
        Me.UIPnlPrincipal = New Janus.Windows.UI.Dock.UIPanelGroup
        Me.UIPnlOpciones = New Janus.Windows.UI.Dock.UIPanel
        Me.UIPnlOpcionesContainer = New Janus.Windows.UI.Dock.UIPanelInnerContainer
        Me.PnlCalendarMes = New Solmicro.Expertis.Engine.UI.Panel
        Me.FrmOpciones = New Solmicro.Expertis.Engine.UI.Frame
        Me.BtnBarOptions = New Janus.Windows.ButtonBar.ButtonBar
        Me.CldMesTarea = New Janus.Windows.Schedule.Calendar
        Me.FrmIrAFecha = New Solmicro.Expertis.Engine.UI.Frame
        Me.BtnIrAFecha = New Solmicro.Expertis.Engine.UI.Button
        Me.ClbIrAFecha = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.UIPnlTareas = New Janus.Windows.UI.Dock.UIPanel
        Me.UIPnlTareasContainer = New Janus.Windows.UI.Dock.UIPanelInnerContainer
        Me.FrmTarea = New Solmicro.Expertis.Engine.UI.Frame
        Me.LblColorTarea = New Solmicro.Expertis.Engine.UI.Label
        Me.TxtTipoTarea = New Solmicro.Expertis.Engine.UI.TextBox
        Me.LblTipoTarea = New Solmicro.Expertis.Engine.UI.Label
        Me.TxtPrioridad = New Solmicro.Expertis.Engine.UI.TextBox
        Me.LblPrioridad = New Solmicro.Expertis.Engine.UI.Label
        Me.TxtEstado = New Solmicro.Expertis.Engine.UI.TextBox
        Me.LblEstado = New Solmicro.Expertis.Engine.UI.Label
        Me.TxtOperarioSol = New Solmicro.Expertis.Engine.UI.TextBox
        Me.LblOperarioSol = New Solmicro.Expertis.Engine.UI.Label
        Me.TxtOperario = New Solmicro.Expertis.Engine.UI.TextBox
        Me.LblOperario = New Solmicro.Expertis.Engine.UI.Label
        Me.TxtFecha = New Solmicro.Expertis.Engine.UI.TextBox
        Me.LblFecha = New Solmicro.Expertis.Engine.UI.Label
        Me.TxtTrabajo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.LblTrabajoTarea = New Solmicro.Expertis.Engine.UI.Label
        Me.TxtObra = New Solmicro.Expertis.Engine.UI.TextBox
        Me.LblObraTarea = New Solmicro.Expertis.Engine.UI.Label
        Me.TxtTarea = New Solmicro.Expertis.Engine.UI.TextBox
        Me.LblTarea = New Solmicro.Expertis.Engine.UI.Label
        Me.LblOperarioFil = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvOperario = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.VerObra = New Janus.Windows.UI.CommandBars.UICommand("VerObra")
        Me.OpcionesCalendario = New Janus.Windows.UI.CommandBars.UICommand("OpcionesCalendario")
        Me.InformacionRapida = New Janus.Windows.UI.CommandBars.UICommand("InformacionRapida")
        Me.VerDia = New Janus.Windows.UI.CommandBars.UICommand("VerDia")
        Me.VerSemana = New Janus.Windows.UI.CommandBars.UICommand("VerSemana")
        Me.VerSemanaLaboral = New Janus.Windows.UI.CommandBars.UICommand("VerSemanaLaboral")
        Me.VerMes = New Janus.Windows.UI.CommandBars.UICommand("VerMes")
        Me.CtxCalendario = New Janus.Windows.UI.CommandBars.UIContextMenu
        Me.VerObra1 = New Janus.Windows.UI.CommandBars.UICommand("VerObra")
        Me.Separator1 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.OpcionesCalendario1 = New Janus.Windows.UI.CommandBars.UICommand("OpcionesCalendario")
        Me.InformacionRapida1 = New Janus.Windows.UI.CommandBars.UICommand("InformacionRapida")
        Me.Separator2 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.VerDia1 = New Janus.Windows.UI.CommandBars.UICommand("VerDia")
        Me.VerSemanaLaboral1 = New Janus.Windows.UI.CommandBars.UICommand("VerSemanaLaboral")
        Me.VerSemana1 = New Janus.Windows.UI.CommandBars.UICommand("VerSemana")
        Me.VerMes1 = New Janus.Windows.UI.CommandBars.UICommand("VerMes")
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        Me.PnlCalendar.suspendlayout()
        Me.PnlSchdTarea.suspendlayout()
        CType(Me.SchdTareas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UIPnlCalendario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UIPnlPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UIPnlPrincipal.SuspendLayout()
        CType(Me.UIPnlOpciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UIPnlOpciones.SuspendLayout()
        Me.UIPnlOpcionesContainer.SuspendLayout()
        Me.PnlCalendarMes.suspendlayout()
        Me.FrmOpciones.SuspendLayout()
        CType(Me.BtnBarOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CldMesTarea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FrmIrAFecha.SuspendLayout()
        CType(Me.UIPnlTareas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UIPnlTareas.SuspendLayout()
        Me.UIPnlTareasContainer.SuspendLayout()
        Me.FrmTarea.SuspendLayout()
        CType(Me.CtxCalendario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.AdvOperario)
        Me.FilterPanel.Controls.Add(Me.LblOperarioFil)
        Me.FilterPanel.Controls.Add(Me.ClbFechaFinPrev)
        Me.FilterPanel.Controls.Add(Me.ClbFechaInicioPrev)
        Me.FilterPanel.Controls.Add(Me.LblFechaFinPrev)
        Me.FilterPanel.Controls.Add(Me.LblFechaInicioPrev)
        Me.FilterPanel.Controls.Add(Me.LblObra)
        Me.FilterPanel.Controls.Add(Me.AdvObra)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 351)
        Me.FilterPanel.Size = New System.Drawing.Size(578, 80)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Controls.Add(Me.PnlCalendar)
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(578, 351)
        Me.CIMntoGridPanel.Controls.SetChildIndex(Me.Grid, 0)
        Me.CIMntoGridPanel.Controls.SetChildIndex(Me.PnlCalendar, 0)
        '
        'Grid
        '
        Me.Grid.Size = New System.Drawing.Size(578, 351)
        Me.Grid.Visible = False
        '
        'UiCommandManager1
        '
        Me.UiCommandManager1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.VerObra, Me.OpcionesCalendario, Me.InformacionRapida, Me.VerDia, Me.VerSemana, Me.VerSemanaLaboral, Me.VerMes})
        Me.UiCommandManager1.ContextMenus.AddRange(New Janus.Windows.UI.CommandBars.UIContextMenu() {Me.CtxCalendario})
        '
        'CheckAll
        '
        Me.CheckAll.Icon = CType(resources.GetObject("CheckAll.Icon"), System.Drawing.Icon)
        '
        'UncheckAll
        '
        Me.UncheckAll.Icon = CType(resources.GetObject("UncheckAll.Icon"), System.Drawing.Icon)
        '
        'ExecuteQuery
        '
        Me.ExecuteQuery.Icon = CType(resources.GetObject("ExecuteQuery.Icon"), System.Drawing.Icon)
        '
        'ShowAllCheckedItems
        '
        Me.ShowAllCheckedItems.Icon = CType(resources.GetObject("ShowAllCheckedItems.Icon"), System.Drawing.Icon)
        '
        'ClearFilter
        '
        Me.ClearFilter.Icon = CType(resources.GetObject("ClearFilter.Icon"), System.Drawing.Icon)
        '
        'Export
        '
        Me.Export.Icon = CType(resources.GetObject("Export.Icon"), System.Drawing.Icon)
        '
        'Toolbar
        '
        Me.Toolbar.Size = New System.Drawing.Size(245, 28)
        '
        'Menubar
        '
        Me.Menubar.Location = New System.Drawing.Point(0, 28)
        '
        'MainPanel
        '
        Me.MainPanel.Size = New System.Drawing.Size(578, 431)
        '
        'ExecuteActions
        '
        Me.ExecuteActions.Icon = CType(resources.GetObject("ExecuteActions.Icon"), System.Drawing.Icon)
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(578, 431)
        '
        'PnlCalendar
        '
        Me.PnlCalendar.Controls.Add(Me.PnlSchdTarea)
        Me.PnlCalendar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlCalendar.Location = New System.Drawing.Point(0, 0)
        Me.PnlCalendar.Name = "PnlCalendar"
        Me.PnlCalendar.Size = New System.Drawing.Size(578, 351)
        Me.PnlCalendar.TabIndex = 1
        '
        'PnlSchdTarea
        '
        Me.PnlSchdTarea.Controls.Add(Me.SchdTareas)
        Me.PnlSchdTarea.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlSchdTarea.Location = New System.Drawing.Point(0, 0)
        Me.PnlSchdTarea.Name = "PnlSchdTarea"
        Me.PnlSchdTarea.Size = New System.Drawing.Size(578, 351)
        Me.PnlSchdTarea.TabIndex = 0
        '
        'SchdTareas
        '
        Me.SchdTareas.AllowAppointmentDrag = Janus.Windows.Schedule.AllowAppointmentDrag.None
        Me.SchdTareas.AllowDayResize = False
        Me.SchdTareas.AllowDelete = False
        Me.SchdTareas.AllowEdit = False
        Me.UiCommandManager1.SetContextMenu(Me.SchdTareas, Me.CtxCalendario)
        Me.SchdTareas.Date = New Date(2007, 7, 9, 0, 0, 0, 0)
        Me.SchdTareas.DayNavigationButtons = True
        SchdTareas_DesignTimeLayout.LayoutString = "<ScheduleLayoutData><Fields Collection=""true"" ElementName=""Field""><Field0 ID=""IDO" & _
            "bra""><DataMember>IDObra</DataMember><Key>IDObra</Key><TypeCode>UInt32</TypeCode>" & _
            "</Field0></Fields></ScheduleLayoutData>"
        Me.SchdTareas.DesignTimeLayout = SchdTareas_DesignTimeLayout
        Me.SchdTareas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SchdTareas.FirstDayOfWeek = Janus.Windows.Schedule.ScheduleDayOfWeek.Monday
        Me.SchdTareas.FirstVisibleTime = System.TimeSpan.Parse("00:00:00")
        Me.SchdTareas.HourBackgroundStyle.BackColor = System.Drawing.Color.Khaki
        Me.SchdTareas.Location = New System.Drawing.Point(0, 0)
        Me.SchdTareas.Name = "SchdTareas"
        Me.SchdTareas.Size = New System.Drawing.Size(578, 351)
        Me.SchdTareas.TabIndex = 6
        Me.SchdTareas.VerticalScrollPosition = 0
        Me.SchdTareas.TimeFormat = Janus.Windows.Schedule.TimeFormat.TwentyFourHours
        Me.SchdTareas.WorkEndTime = System.TimeSpan.Parse("18:00:00")
        Me.SchdTareas.WorkingHourBackgroundStyle.BackColor = System.Drawing.Color.LemonChiffon
        '
        'ImgPeriodos
        '
        Me.ImgPeriodos.ImageStream = CType(resources.GetObject("ImgPeriodos.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImgPeriodos.TransparentColor = System.Drawing.Color.Transparent
        Me.ImgPeriodos.Images.SetKeyName(0, "")
        Me.ImgPeriodos.Images.SetKeyName(1, "")
        Me.ImgPeriodos.Images.SetKeyName(2, "")
        Me.ImgPeriodos.Images.SetKeyName(3, "")
        Me.ImgPeriodos.Images.SetKeyName(4, "")
        Me.ImgPeriodos.Images.SetKeyName(5, "")
        Me.ImgPeriodos.Images.SetKeyName(6, "")
        Me.ImgPeriodos.Images.SetKeyName(7, "")
        Me.ImgPeriodos.Images.SetKeyName(8, "")
        Me.ImgPeriodos.Images.SetKeyName(9, "")
        Me.ImgPeriodos.Images.SetKeyName(10, "")
        Me.ImgPeriodos.Images.SetKeyName(11, "")
        Me.ImgPeriodos.Images.SetKeyName(12, "")
        '
        'ImgList
        '
        Me.ImgList.ImageStream = CType(resources.GetObject("ImgList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImgList.TransparentColor = System.Drawing.Color.Transparent
        Me.ImgList.Images.SetKeyName(0, "")
        '
        'LblObra
        '
        Me.LblObra.Location = New System.Drawing.Point(8, 28)
        Me.LblObra.Name = "LblObra"
        Me.LblObra.Size = New System.Drawing.Size(57, 13)
        Me.LblObra.TabIndex = 0
        Me.LblObra.Text = "Proyecto"
        Me.LblObra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AdvObra
        '
        Me.AdvObra.DisabledBackColor = System.Drawing.Color.White
        Me.AdvObra.DisplayField = "NObra"
        Me.AdvObra.EntityName = "ObraCabecera"
        Me.AdvObra.Location = New System.Drawing.Point(72, 22)
        Me.AdvObra.Name = "AdvObra"
        Me.AdvObra.SecondaryDataFields = "IDObra"
        Me.AdvObra.Size = New System.Drawing.Size(128, 23)
        Me.AdvObra.TabIndex = 0
        '
        'LblFechaInicioPrev
        '
        Me.LblFechaInicioPrev.Location = New System.Drawing.Point(368, 28)
        Me.LblFechaInicioPrev.Name = "LblFechaInicioPrev"
        Me.LblFechaInicioPrev.Size = New System.Drawing.Size(97, 13)
        Me.LblFechaInicioPrev.TabIndex = 2
        Me.LblFechaInicioPrev.Text = "Fecha Ini. Prev."
        Me.LblFechaInicioPrev.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblFechaFinPrev
        '
        Me.LblFechaFinPrev.Location = New System.Drawing.Point(368, 51)
        Me.LblFechaFinPrev.Name = "LblFechaFinPrev"
        Me.LblFechaFinPrev.Size = New System.Drawing.Size(94, 13)
        Me.LblFechaFinPrev.TabIndex = 3
        Me.LblFechaFinPrev.Text = "Fecha Fin Prev."
        Me.LblFechaFinPrev.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ClbFechaInicioPrev
        '
        Me.ClbFechaInicioPrev.DisabledBackColor = System.Drawing.Color.White
        Me.ClbFechaInicioPrev.Location = New System.Drawing.Point(472, 24)
        Me.ClbFechaInicioPrev.Name = "ClbFechaInicioPrev"
        Me.ClbFechaInicioPrev.Size = New System.Drawing.Size(96, 21)
        Me.ClbFechaInicioPrev.TabIndex = 2
        '
        'ClbFechaFinPrev
        '
        Me.ClbFechaFinPrev.DisabledBackColor = System.Drawing.Color.White
        Me.ClbFechaFinPrev.Location = New System.Drawing.Point(472, 48)
        Me.ClbFechaFinPrev.Name = "ClbFechaFinPrev"
        Me.ClbFechaFinPrev.Size = New System.Drawing.Size(96, 21)
        Me.ClbFechaFinPrev.TabIndex = 3
        '
        'UIPnlCalendario
        '
        Me.UIPnlCalendario.ContainerControl = Me
        Me.UIPnlCalendario.DefaultPanelSettings.AutoHideButtonVisible = False
        Me.UIPnlCalendario.DefaultPanelSettings.CloseButtonVisible = False
        Me.UIPnlCalendario.ImageList = Me.ImgPeriodos
        Me.UIPnlPrincipal.Id = New System.Guid("9a04706c-6689-4f35-b344-158b8e1ab385")
        Me.UIPnlPrincipal.StaticGroup = True
        Me.UIPnlOpciones.Id = New System.Guid("0a2851af-b755-4979-8b60-ef0d5fcdc99f")
        Me.UIPnlPrincipal.Panels.Add(Me.UIPnlOpciones)
        Me.UIPnlTareas.Id = New System.Guid("55e2bf3a-4052-4213-9992-5778c96aa5f8")
        Me.UIPnlPrincipal.Panels.Add(Me.UIPnlTareas)
        Me.UIPnlCalendario.Panels.Add(Me.UIPnlPrincipal)
        '
        'Design Time Panel Info:
        '
        Me.UIPnlCalendario.BeginPanelInfo()
        Me.UIPnlCalendario.AddDockPanelInfo(New System.Guid("9a04706c-6689-4f35-b344-158b8e1ab385"), Janus.Windows.UI.Dock.PanelGroupStyle.OutlookNavigator, Janus.Windows.UI.Dock.PanelDockStyle.Right, True, New System.Drawing.Size(248, 462), True)
        Me.UIPnlCalendario.AddDockPanelInfo(New System.Guid("0a2851af-b755-4979-8b60-ef0d5fcdc99f"), New System.Guid("9a04706c-6689-4f35-b344-158b8e1ab385"), 460, True)
        Me.UIPnlCalendario.AddDockPanelInfo(New System.Guid("55e2bf3a-4052-4213-9992-5778c96aa5f8"), New System.Guid("9a04706c-6689-4f35-b344-158b8e1ab385"), -1, True)
        Me.UIPnlCalendario.AddFloatingPanelInfo(New System.Guid("2897f57a-62be-4153-b908-41fb6408505c"), New System.Drawing.Point(584, 203), New System.Drawing.Size(148, 229), False)
        Me.UIPnlCalendario.AddFloatingPanelInfo(New System.Guid("9a04706c-6689-4f35-b344-158b8e1ab385"), Janus.Windows.UI.Dock.PanelGroupStyle.OutlookNavigator, True, New System.Drawing.Point(-1, -1), New System.Drawing.Size(-1, -1), False)
        Me.UIPnlCalendario.AddFloatingPanelInfo(New System.Guid("816e4868-fcb6-4e0e-9884-c94bcf676691"), Janus.Windows.UI.Dock.PanelGroupStyle.HorizontalTiles, True, New System.Drawing.Point(-1, -1), New System.Drawing.Size(-1, -1), False)
        Me.UIPnlCalendario.AddFloatingPanelInfo(New System.Guid("0a2851af-b755-4979-8b60-ef0d5fcdc99f"), New System.Drawing.Point(-1, -1), New System.Drawing.Size(-1, -1), False)
        Me.UIPnlCalendario.AddFloatingPanelInfo(New System.Guid("9edc0557-1a02-4e88-a494-9d825a535ab9"), Janus.Windows.UI.Dock.PanelGroupStyle.HorizontalTiles, True, New System.Drawing.Point(-1, -1), New System.Drawing.Size(-1, -1), False)
        Me.UIPnlCalendario.AddFloatingPanelInfo(New System.Guid("55e2bf3a-4052-4213-9992-5778c96aa5f8"), New System.Drawing.Point(-1, -1), New System.Drawing.Size(-1, -1), False)
        Me.UIPnlCalendario.EndPanelInfo()
        '
        'UIPnlPrincipal
        '
        Me.UIPnlPrincipal.Cursor = System.Windows.Forms.Cursors.VSplit
        Me.UIPnlPrincipal.GroupStyle = Janus.Windows.UI.Dock.PanelGroupStyle.OutlookNavigator
        Me.UIPnlPrincipal.Location = New System.Drawing.Point(586, 60)
        Me.UIPnlPrincipal.Name = "UIPnlPrincipal"
        Me.UIPnlPrincipal.SelectedPanel = Me.UIPnlOpciones
        Me.UIPnlPrincipal.Size = New System.Drawing.Size(248, 462)
        Me.UIPnlPrincipal.TabIndex = 4
        Me.UIPnlPrincipal.Text = "Panel 0"
        Me.UIPnlPrincipal.VisibleOutlookButtons = 0
        '
        'UIPnlOpciones
        '
        Me.UIPnlOpciones.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.UIPnlOpciones.ImageIndex = 2
        Me.UIPnlOpciones.InnerContainer = Me.UIPnlOpcionesContainer
        Me.UIPnlOpciones.Location = New System.Drawing.Point(4, 0)
        Me.UIPnlOpciones.Name = "UIPnlOpciones"
        Me.UIPnlOpciones.Size = New System.Drawing.Size(244, 424)
        Me.UIPnlOpciones.TabIndex = 4
        Me.UIPnlOpciones.Text = "Opciones Calendario"
        '
        'UIPnlOpcionesContainer
        '
        Me.UIPnlOpcionesContainer.Controls.Add(Me.PnlCalendarMes)
        Me.UIPnlOpcionesContainer.Location = New System.Drawing.Point(1, 24)
        Me.UIPnlOpcionesContainer.Name = "UIPnlOpcionesContainer"
        Me.UIPnlOpcionesContainer.Size = New System.Drawing.Size(242, 400)
        Me.UIPnlOpcionesContainer.TabIndex = 0
        '
        'PnlCalendarMes
        '
        Me.PnlCalendarMes.Controls.Add(Me.FrmOpciones)
        Me.PnlCalendarMes.Controls.Add(Me.FrmIrAFecha)
        Me.PnlCalendarMes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlCalendarMes.Location = New System.Drawing.Point(0, 0)
        Me.PnlCalendarMes.Name = "PnlCalendarMes"
        Me.PnlCalendarMes.Size = New System.Drawing.Size(242, 400)
        Me.PnlCalendarMes.TabIndex = 10
        '
        'FrmOpciones
        '
        Me.FrmOpciones.Controls.Add(Me.BtnBarOptions)
        Me.FrmOpciones.Controls.Add(Me.CldMesTarea)
        Me.FrmOpciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FrmOpciones.Location = New System.Drawing.Point(0, 48)
        Me.FrmOpciones.Name = "FrmOpciones"
        Me.FrmOpciones.Size = New System.Drawing.Size(242, 352)
        Me.FrmOpciones.TabIndex = 12
        Me.FrmOpciones.TabStop = False
        Me.FrmOpciones.Text = "Cambiar Fecha / Vista"
        '
        'BtnBarOptions
        '
        BtnBarOptions_Group_0.ImageAlignment = Janus.Windows.ButtonBar.Alignment.Far
        BtnBarOptions_Item_0_0.Key = "PorDia"
        BtnBarOptions_Item_0_0.SmallImageIndex = 5
        BtnBarOptions_Item_0_0.StateStyles.FormatStyle.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BtnBarOptions_Item_0_0.Text = "Por Día"
        BtnBarOptions_Item_0_1.Key = "PorSemanaLab"
        BtnBarOptions_Item_0_1.SmallImageIndex = 6
        BtnBarOptions_Item_0_1.StateStyles.FormatStyle.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BtnBarOptions_Item_0_1.StateStyles.FormatStyle.ForeColor = System.Drawing.Color.Red
        BtnBarOptions_Item_0_1.Text = "Por Semana Laboral"
        BtnBarOptions_Item_0_2.Key = "PorSemana"
        BtnBarOptions_Item_0_2.SmallImageIndex = 7
        BtnBarOptions_Item_0_2.StateStyles.FormatStyle.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BtnBarOptions_Item_0_2.Text = "Por Semana"
        BtnBarOptions_Item_0_3.Key = "PorMes"
        BtnBarOptions_Item_0_3.SmallImageIndex = 8
        BtnBarOptions_Item_0_3.StateStyles.FormatStyle.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BtnBarOptions_Item_0_3.Text = "Por Mes"
        BtnBarOptions_Group_0.Items.AddRange(New Janus.Windows.ButtonBar.ButtonBarItem() {BtnBarOptions_Item_0_0, BtnBarOptions_Item_0_1, BtnBarOptions_Item_0_2, BtnBarOptions_Item_0_3})
        BtnBarOptions_Group_0.Key = "GrpPeriodos"
        BtnBarOptions_Group_0.Text = "Ver Calendario Por..."
        BtnBarOptions_Group_0.TextAlignment = Janus.Windows.ButtonBar.Alignment.Near
        BtnBarOptions_Group_0.View = Janus.Windows.ButtonBar.ButtonBarView.SmallIcons
        Me.BtnBarOptions.Groups.AddRange(New Janus.Windows.ButtonBar.ButtonBarGroup() {BtnBarOptions_Group_0})
        Me.BtnBarOptions.Location = New System.Drawing.Point(24, 216)
        Me.BtnBarOptions.Name = "BtnBarOptions"
        Me.BtnBarOptions.Size = New System.Drawing.Size(192, 120)
        Me.BtnBarOptions.SmallImageList = Me.ImgPeriodos
        Me.BtnBarOptions.TabIndex = 6
        Me.BtnBarOptions.Text = "ButtonBar1"
        Me.BtnBarOptions.VisualStyle = Janus.Windows.ButtonBar.VisualStyle.Office2003
        '
        'CldMesTarea
        '
        Me.CldMesTarea.AutoSize = False
        Me.CldMesTarea.FirstDayOfWeek = Janus.Windows.Schedule.CalendarDayOfWeek.Monday
        Me.CldMesTarea.FirstMonth = New Date(2007, 7, 1, 0, 0, 0, 0)
        Me.CldMesTarea.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CldMesTarea.Location = New System.Drawing.Point(24, 32)
        Me.CldMesTarea.Name = "CldMesTarea"
        Me.CldMesTarea.Schedule = Me.SchdTareas
        Me.CldMesTarea.SelectionStyle = Janus.Windows.Schedule.CalendarSelectionStyle.Schedule
        Me.CldMesTarea.Size = New System.Drawing.Size(192, 160)
        Me.CldMesTarea.TabIndex = 9
        Me.CldMesTarea.TodayRectColor = System.Drawing.Color.Blue
        Me.CldMesTarea.VisualStyle = Janus.Windows.Schedule.VisualStyle.Office2003
        Me.CldMesTarea.WeekNumbers = True
        '
        'FrmIrAFecha
        '
        Me.FrmIrAFecha.Controls.Add(Me.BtnIrAFecha)
        Me.FrmIrAFecha.Controls.Add(Me.ClbIrAFecha)
        Me.FrmIrAFecha.Dock = System.Windows.Forms.DockStyle.Top
        Me.FrmIrAFecha.Location = New System.Drawing.Point(0, 0)
        Me.FrmIrAFecha.Name = "FrmIrAFecha"
        Me.FrmIrAFecha.Size = New System.Drawing.Size(242, 48)
        Me.FrmIrAFecha.TabIndex = 11
        Me.FrmIrAFecha.TabStop = False
        Me.FrmIrAFecha.Text = "Ir a Fecha..."
        '
        'BtnIrAFecha
        '
        Me.BtnIrAFecha.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText
        Me.BtnIrAFecha.ImageIndex = 0
        Me.BtnIrAFecha.ImageList = Me.ImgList
        Me.BtnIrAFecha.Location = New System.Drawing.Point(160, 16)
        Me.BtnIrAFecha.Name = "BtnIrAFecha"
        Me.BtnIrAFecha.Size = New System.Drawing.Size(72, 23)
        Me.BtnIrAFecha.TabIndex = 11
        Me.BtnIrAFecha.Text = "&IR"
        '
        'ClbIrAFecha
        '
        Me.ClbIrAFecha.DisabledBackColor = System.Drawing.Color.White
        Me.ClbIrAFecha.Location = New System.Drawing.Point(8, 16)
        Me.ClbIrAFecha.Name = "ClbIrAFecha"
        Me.ClbIrAFecha.Size = New System.Drawing.Size(136, 21)
        Me.ClbIrAFecha.TabIndex = 10
        '
        'UIPnlTareas
        '
        Me.UIPnlTareas.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.UIPnlTareas.ImageIndex = 12
        Me.UIPnlTareas.InnerContainer = Me.UIPnlTareasContainer
        Me.UIPnlTareas.Location = New System.Drawing.Point(4, 0)
        Me.UIPnlTareas.Name = "UIPnlTareas"
        Me.UIPnlTareas.Size = New System.Drawing.Size(244, 424)
        Me.UIPnlTareas.TabIndex = 4
        Me.UIPnlTareas.Text = "Información Rápida Tarea"
        '
        'UIPnlTareasContainer
        '
        Me.UIPnlTareasContainer.Controls.Add(Me.FrmTarea)
        Me.UIPnlTareasContainer.Location = New System.Drawing.Point(1, 24)
        Me.UIPnlTareasContainer.Name = "UIPnlTareasContainer"
        Me.UIPnlTareasContainer.Size = New System.Drawing.Size(242, 400)
        Me.UIPnlTareasContainer.TabIndex = 0
        '
        'FrmTarea
        '
        Me.FrmTarea.Controls.Add(Me.LblColorTarea)
        Me.FrmTarea.Controls.Add(Me.TxtTipoTarea)
        Me.FrmTarea.Controls.Add(Me.LblTipoTarea)
        Me.FrmTarea.Controls.Add(Me.TxtPrioridad)
        Me.FrmTarea.Controls.Add(Me.LblPrioridad)
        Me.FrmTarea.Controls.Add(Me.TxtEstado)
        Me.FrmTarea.Controls.Add(Me.LblEstado)
        Me.FrmTarea.Controls.Add(Me.TxtOperarioSol)
        Me.FrmTarea.Controls.Add(Me.LblOperarioSol)
        Me.FrmTarea.Controls.Add(Me.TxtOperario)
        Me.FrmTarea.Controls.Add(Me.LblOperario)
        Me.FrmTarea.Controls.Add(Me.TxtFecha)
        Me.FrmTarea.Controls.Add(Me.LblFecha)
        Me.FrmTarea.Controls.Add(Me.TxtTrabajo)
        Me.FrmTarea.Controls.Add(Me.LblTrabajoTarea)
        Me.FrmTarea.Controls.Add(Me.TxtObra)
        Me.FrmTarea.Controls.Add(Me.LblObraTarea)
        Me.FrmTarea.Controls.Add(Me.TxtTarea)
        Me.FrmTarea.Controls.Add(Me.LblTarea)
        Me.FrmTarea.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FrmTarea.Location = New System.Drawing.Point(0, 0)
        Me.FrmTarea.Name = "FrmTarea"
        Me.FrmTarea.Size = New System.Drawing.Size(242, 400)
        Me.FrmTarea.TabIndex = 0
        Me.FrmTarea.TabStop = False
        Me.FrmTarea.Text = "Datos Tarea"
        '
        'LblColorTarea
        '
        Me.LblColorTarea.BackColor = System.Drawing.Color.White
        Me.LblColorTarea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblColorTarea.Location = New System.Drawing.Point(184, 352)
        Me.LblColorTarea.Name = "LblColorTarea"
        Me.LblColorTarea.Size = New System.Drawing.Size(48, 23)
        Me.LblColorTarea.TabIndex = 18
        '
        'TxtTipoTarea
        '
        Me.TxtTipoTarea.DisabledBackColor = System.Drawing.Color.White
        Me.TxtTipoTarea.Location = New System.Drawing.Point(8, 352)
        Me.TxtTipoTarea.Multiline = True
        Me.TxtTipoTarea.Name = "TxtTipoTarea"
        Me.TxtTipoTarea.ReadOnly = True
        Me.TxtTipoTarea.Size = New System.Drawing.Size(168, 24)
        Me.TxtTipoTarea.TabIndex = 17
        '
        'LblTipoTarea
        '
        Me.LblTipoTarea.Location = New System.Drawing.Point(8, 328)
        Me.LblTipoTarea.Name = "LblTipoTarea"
        Me.LblTipoTarea.Size = New System.Drawing.Size(68, 13)
        Me.LblTipoTarea.TabIndex = 16
        Me.LblTipoTarea.Text = "Tipo Tarea"
        Me.LblTipoTarea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtPrioridad
        '
        Me.TxtPrioridad.DisabledBackColor = System.Drawing.Color.White
        Me.TxtPrioridad.Location = New System.Drawing.Point(72, 296)
        Me.TxtPrioridad.Multiline = True
        Me.TxtPrioridad.Name = "TxtPrioridad"
        Me.TxtPrioridad.ReadOnly = True
        Me.TxtPrioridad.Size = New System.Drawing.Size(160, 24)
        Me.TxtPrioridad.TabIndex = 15
        '
        'LblPrioridad
        '
        Me.LblPrioridad.Location = New System.Drawing.Point(8, 296)
        Me.LblPrioridad.Name = "LblPrioridad"
        Me.LblPrioridad.Size = New System.Drawing.Size(58, 13)
        Me.LblPrioridad.TabIndex = 14
        Me.LblPrioridad.Text = "Prioridad"
        Me.LblPrioridad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtEstado
        '
        Me.TxtEstado.DisabledBackColor = System.Drawing.Color.White
        Me.TxtEstado.Location = New System.Drawing.Point(72, 264)
        Me.TxtEstado.Multiline = True
        Me.TxtEstado.Name = "TxtEstado"
        Me.TxtEstado.ReadOnly = True
        Me.TxtEstado.Size = New System.Drawing.Size(160, 24)
        Me.TxtEstado.TabIndex = 13
        '
        'LblEstado
        '
        Me.LblEstado.Location = New System.Drawing.Point(8, 264)
        Me.LblEstado.Name = "LblEstado"
        Me.LblEstado.Size = New System.Drawing.Size(45, 13)
        Me.LblEstado.TabIndex = 12
        Me.LblEstado.Text = "Estado"
        Me.LblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtOperarioSol
        '
        Me.TxtOperarioSol.DisabledBackColor = System.Drawing.Color.White
        Me.TxtOperarioSol.Location = New System.Drawing.Point(96, 232)
        Me.TxtOperarioSol.Multiline = True
        Me.TxtOperarioSol.Name = "TxtOperarioSol"
        Me.TxtOperarioSol.ReadOnly = True
        Me.TxtOperarioSol.Size = New System.Drawing.Size(136, 24)
        Me.TxtOperarioSol.TabIndex = 11
        '
        'LblOperarioSol
        '
        Me.LblOperarioSol.Location = New System.Drawing.Point(8, 232)
        Me.LblOperarioSol.Name = "LblOperarioSol"
        Me.LblOperarioSol.Size = New System.Drawing.Size(83, 13)
        Me.LblOperarioSol.TabIndex = 10
        Me.LblOperarioSol.Text = "Operario Sol."
        Me.LblOperarioSol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtOperario
        '
        Me.TxtOperario.DisabledBackColor = System.Drawing.Color.White
        Me.TxtOperario.Location = New System.Drawing.Point(72, 200)
        Me.TxtOperario.Multiline = True
        Me.TxtOperario.Name = "TxtOperario"
        Me.TxtOperario.ReadOnly = True
        Me.TxtOperario.Size = New System.Drawing.Size(160, 24)
        Me.TxtOperario.TabIndex = 9
        '
        'LblOperario
        '
        Me.LblOperario.Location = New System.Drawing.Point(8, 200)
        Me.LblOperario.Name = "LblOperario"
        Me.LblOperario.Size = New System.Drawing.Size(57, 13)
        Me.LblOperario.TabIndex = 8
        Me.LblOperario.Text = "Operario"
        Me.LblOperario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtFecha
        '
        Me.TxtFecha.DisabledBackColor = System.Drawing.Color.White
        Me.TxtFecha.Location = New System.Drawing.Point(72, 168)
        Me.TxtFecha.Multiline = True
        Me.TxtFecha.Name = "TxtFecha"
        Me.TxtFecha.ReadOnly = True
        Me.TxtFecha.Size = New System.Drawing.Size(160, 24)
        Me.TxtFecha.TabIndex = 7
        '
        'LblFecha
        '
        Me.LblFecha.Location = New System.Drawing.Point(8, 168)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(40, 13)
        Me.LblFecha.TabIndex = 6
        Me.LblFecha.Text = "Fecha"
        Me.LblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtTrabajo
        '
        Me.TxtTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.TxtTrabajo.Location = New System.Drawing.Point(72, 120)
        Me.TxtTrabajo.Multiline = True
        Me.TxtTrabajo.Name = "TxtTrabajo"
        Me.TxtTrabajo.ReadOnly = True
        Me.TxtTrabajo.Size = New System.Drawing.Size(160, 40)
        Me.TxtTrabajo.TabIndex = 5
        '
        'LblTrabajoTarea
        '
        Me.LblTrabajoTarea.Location = New System.Drawing.Point(8, 120)
        Me.LblTrabajoTarea.Name = "LblTrabajoTarea"
        Me.LblTrabajoTarea.Size = New System.Drawing.Size(51, 13)
        Me.LblTrabajoTarea.TabIndex = 4
        Me.LblTrabajoTarea.Text = "Trabajo"
        Me.LblTrabajoTarea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtObra
        '
        Me.TxtObra.DisabledBackColor = System.Drawing.Color.White
        Me.TxtObra.Location = New System.Drawing.Point(72, 72)
        Me.TxtObra.Multiline = True
        Me.TxtObra.Name = "TxtObra"
        Me.TxtObra.ReadOnly = True
        Me.TxtObra.Size = New System.Drawing.Size(160, 40)
        Me.TxtObra.TabIndex = 3
        '
        'LblObraTarea
        '
        Me.LblObraTarea.Location = New System.Drawing.Point(8, 72)
        Me.LblObraTarea.Name = "LblObraTarea"
        Me.LblObraTarea.Size = New System.Drawing.Size(35, 13)
        Me.LblObraTarea.TabIndex = 2
        Me.LblObraTarea.Text = "Obra"
        Me.LblObraTarea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtTarea
        '
        Me.TxtTarea.DisabledBackColor = System.Drawing.Color.White
        Me.TxtTarea.Location = New System.Drawing.Point(72, 24)
        Me.TxtTarea.Multiline = True
        Me.TxtTarea.Name = "TxtTarea"
        Me.TxtTarea.ReadOnly = True
        Me.TxtTarea.Size = New System.Drawing.Size(160, 40)
        Me.TxtTarea.TabIndex = 1
        '
        'LblTarea
        '
        Me.LblTarea.Location = New System.Drawing.Point(8, 24)
        Me.LblTarea.Name = "LblTarea"
        Me.LblTarea.Size = New System.Drawing.Size(40, 13)
        Me.LblTarea.TabIndex = 0
        Me.LblTarea.Text = "Tarea"
        Me.LblTarea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblOperarioFil
        '
        Me.LblOperarioFil.Location = New System.Drawing.Point(8, 53)
        Me.LblOperarioFil.Name = "LblOperarioFil"
        Me.LblOperarioFil.Size = New System.Drawing.Size(57, 13)
        Me.LblOperarioFil.TabIndex = 6
        Me.LblOperarioFil.Text = "Operario"
        '
        'AdvOperario
        '
        Me.AdvOperario.DisabledBackColor = System.Drawing.Color.White
        Me.AdvOperario.EntityName = "Operario"
        Me.AdvOperario.Location = New System.Drawing.Point(72, 48)
        Me.AdvOperario.Name = "AdvOperario"
        Me.AdvOperario.SecondaryDataFields = "IDOperario"
        Me.AdvOperario.Size = New System.Drawing.Size(128, 23)
        Me.AdvOperario.TabIndex = 1
        '
        'VerObra
        '
        Me.VerObra.Key = "VerObra"
        Me.VerObra.Name = "VerObra"
        Me.VerObra.Text = "Ver Obra"
        '
        'OpcionesCalendario
        '
        Me.OpcionesCalendario.Key = "OpcionesCalendario"
        Me.OpcionesCalendario.Name = "OpcionesCalendario"
        Me.OpcionesCalendario.Text = "Opciones Calendario"
        '
        'InformacionRapida
        '
        Me.InformacionRapida.Key = "InformacionRapida"
        Me.InformacionRapida.Name = "InformacionRapida"
        Me.InformacionRapida.Text = "Ver Información Rápida Tarea"
        '
        'VerDia
        '
        Me.VerDia.Key = "VerDia"
        Me.VerDia.Name = "VerDia"
        Me.VerDia.Text = "Ver por Día"
        '
        'VerSemana
        '
        Me.VerSemana.Key = "VerSemana"
        Me.VerSemana.Name = "VerSemana"
        Me.VerSemana.Text = "Ver por Semana"
        '
        'VerSemanaLaboral
        '
        Me.VerSemanaLaboral.Checked = Janus.Windows.UI.InheritableBoolean.[True]
        Me.VerSemanaLaboral.Key = "VerSemanaLaboral"
        Me.VerSemanaLaboral.Name = "VerSemanaLaboral"
        Me.VerSemanaLaboral.Text = "Ver por Semana Laboral"
        '
        'VerMes
        '
        Me.VerMes.Key = "VerMes"
        Me.VerMes.Name = "VerMes"
        Me.VerMes.Text = "Ver por Mes"
        '
        'CtxCalendario
        '
        Me.CtxCalendario.CommandManager = Me.UiCommandManager1
        Me.CtxCalendario.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.VerObra1, Me.Separator1, Me.OpcionesCalendario1, Me.InformacionRapida1, Me.Separator2, Me.VerDia1, Me.VerSemanaLaboral1, Me.VerSemana1, Me.VerMes1})
        Me.CtxCalendario.Key = "CtxCalendario"
        '
        'VerObra1
        '
        Me.VerObra1.Key = "VerObra"
        Me.VerObra1.Name = "VerObra1"
        '
        'Separator1
        '
        Me.Separator1.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.Separator1.Key = "Separator"
        Me.Separator1.Name = "Separator1"
        '
        'OpcionesCalendario1
        '
        Me.OpcionesCalendario1.Key = "OpcionesCalendario"
        Me.OpcionesCalendario1.Name = "OpcionesCalendario1"
        '
        'InformacionRapida1
        '
        Me.InformacionRapida1.Key = "InformacionRapida"
        Me.InformacionRapida1.Name = "InformacionRapida1"
        '
        'Separator2
        '
        Me.Separator2.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.Separator2.Key = "Separator"
        Me.Separator2.Name = "Separator2"
        '
        'VerDia1
        '
        Me.VerDia1.Key = "VerDia"
        Me.VerDia1.Name = "VerDia1"
        '
        'VerSemanaLaboral1
        '
        Me.VerSemanaLaboral1.Key = "VerSemanaLaboral"
        Me.VerSemanaLaboral1.Name = "VerSemanaLaboral1"
        '
        'VerSemana1
        '
        Me.VerSemana1.Key = "VerSemana"
        Me.VerSemana1.Name = "VerSemana1"
        '
        'VerMes1
        '
        Me.VerMes1.Key = "VerMes"
        Me.VerMes1.Name = "VerMes1"
        '
        'CICalendarioTareas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(840, 525)
        Me.Controls.Add(Me.UIPnlPrincipal)
        Me.Name = "CICalendarioTareas"
        Me.Text = "CICalendarioTareas"
        Me.Controls.SetChildIndex(Me.UIPnlPrincipal, 0)
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        Me.PnlCalendar.ResumeLayout(False)
        Me.PnlSchdTarea.ResumeLayout(False)
        CType(Me.SchdTareas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UIPnlCalendario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UIPnlPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UIPnlPrincipal.ResumeLayout(False)
        CType(Me.UIPnlOpciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UIPnlOpciones.ResumeLayout(False)
        Me.UIPnlOpcionesContainer.ResumeLayout(False)
        Me.PnlCalendarMes.ResumeLayout(False)
        Me.FrmOpciones.ResumeLayout(False)
        CType(Me.BtnBarOptions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CldMesTarea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FrmIrAFecha.ResumeLayout(False)
        Me.FrmIrAFecha.PerformLayout()
        CType(Me.UIPnlTareas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UIPnlTareas.ResumeLayout(False)
        Me.UIPnlTareasContainer.ResumeLayout(False)
        Me.FrmTarea.ResumeLayout(False)
        Me.FrmTarea.PerformLayout()
        CType(Me.CtxCalendario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables Privadas"

    Dim DrObraTarea As DataRowView
    Dim DtDatos As DataTable

#End Region

#Region "Funciones Privadas"

    Private Sub LoadFormOptions()
        Me.SchdTareas.Date = Today.Date
        Me.SchdTareas.StartTimeMember = "FechaInicioPrev"
        Me.SchdTareas.EndTimeMember = "FechaFinPrev"
        Me.SchdTareas.DescriptionMember = "DescObra; DescTarea"
        Me.SchdTareas.TextMember = "DescTarea"
        BtnBarOptions.Groups(0).Items("PorSemanaLab").InvokeOnClick()
        BtnBarOptions.SelectedItem = BtnBarOptions.Groups(0).Items("PorSemanaLab")
        'Me.SchdTareas.ContextMen = Me.CtxCalendario
    End Sub

    Private Sub LoadParams()
        If Not IsNothing(Me.Params) Then
            Dim HT As Hashtable = Me.Params
            AdvObra.Value = HT("IDObra")
            AdvObra.Text = HT("NObra")

            Me.Execute()
        End If
    End Sub

    Private Sub LoadToolbarActions()
        Me.FormActions.Add("Sincronizar con Outlook", AddressOf AccionSincronizarOutlook, ExpertisApp.GetIcon("recycle.ico"))
    End Sub

    Private Sub AccionSincronizarOutlook()
        If Length(AdvObra.Value) > 0 Then
            ActionSincronizarTarea.SincronizarTareasProyecto(AdvObra.Value)
        Else
            ExpertisApp.GenerateMessage("Debe de indicar el Proyecto a sincronizar.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub AplicarFiltros(ByRef e As Expertis.Engine.UI.QueryExecutingEventArgs)
        'Obra 1151
        e.Filter.Add("IDObra", FilterOperator.Equal, AdvObra.Value, FilterType.Numeric)
        e.Filter.Add("IDOperario", FilterOperator.Equal, AdvOperario.Value, FilterType.String)
        e.Filter.Add("FechaInicioPrev", FilterOperator.GreaterThanOrEqual, ClbFechaInicioPrev.Value, FilterType.DateTime)
        e.Filter.Add("FechaFinPrev", FilterOperator.LessThanOrEqual, ClbFechaFinPrev.Value, FilterType.DateTime)
        DtDatos = New BE.DataEngine().Filter("vFrmCalendarioTarea", e.Filter.InnerFilter)
        Me.BindEditEvents(DtDatos)
        Me.SchdTareas.DataSource = DtDatos
        Me.SchdTareas.Refresh()
        LimpiarQuickInfo()
    End Sub

    Private Sub LimpiarDataGrid()
        DtDatos = Nothing
        Me.SchdTareas.DataSource = Nothing
    End Sub

    Private Sub CargarQuickInfo()
        TxtTarea.Text = DrObraTarea("DescTarea") & String.Empty
        TxtObra.Text = DrObraTarea("DescObra") & String.Empty
        TxtTrabajo.Text = DrObraTarea("DescTrabajo") & String.Empty
        TxtFecha.Text = DrObraTarea("FechaTarea")
        TxtOperario.Text = DrObraTarea("DescOperario") & String.Empty
        TxtOperarioSol.Text = DrObraTarea("DescOperarioSol") & String.Empty
        TxtEstado.Text = RecuperarDescripcionEnumerado("enumotaEstado", DrObraTarea("Estado"))
        TxtPrioridad.Text = RecuperarDescripcionEnumerado("enumotaPrioridad", DrObraTarea("Prioridad"))
        TxtTipoTarea.Text = DrObraTarea("DescTipoTarea") & String.Empty
        LblColorTarea.BackColor = ColorTranslator.FromWin32(DrObraTarea("Color"))
    End Sub

    Private Sub LimpiarQuickInfo()
        TxtTarea.Text = String.Empty : TxtObra.Text = String.Empty
        TxtTrabajo.Text = String.Empty : TxtFecha.Text = String.Empty
        TxtOperario.Text = String.Empty : TxtOperarioSol.Text = String.Empty
        TxtEstado.Text = String.Empty : TxtPrioridad.Text = String.Empty
        TxtTipoTarea.Text = String.Empty : LblColorTarea.BackColor = Drawing.Color.White
    End Sub

#End Region

#Region "Eventos CICalendarioTareas"

#Region "Eventos Formulario"

    Private Sub CICalendarioTareas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadFormOptions()
        LoadParams()
        LoadToolbarActions()
    End Sub

    Private Sub CICalendarioTareas_QueryExecuting(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        If Length(AdvObra.Value) > 0 OrElse Length(AdvOperario.Value) > 0 Then
            AplicarFiltros(e)
        Else
            ExpertisApp.GenerateMessage("Es necesario filtrar por lo menos por una obra o por un operario.|Por favor, seleccione alguno de estos dos criterios de selección.", MessageBoxButtons.OK, MessageBoxIcon.Information, vbNewLine)
            LimpiarDataGrid()
            LimpiarQuickInfo()
            e.Cancel = True
        End If
    End Sub

    Private Sub CICalendarioTareas_FilterCleared(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.FilterCleared
        ClbFechaInicioPrev.Value = Nothing : ClbFechaFinPrev.Value = Nothing
    End Sub

#End Region

#Region "Eventos SchdTareas"

    Private Sub SchdTareas_AddingAppointment(ByVal sender As Object, ByVal e As Janus.Windows.Schedule.AddAppointmentEventArgs) Handles SchdTareas.AddingAppointment
        e.Cancel = True
    End Sub

    Private Sub SchdTareas_AppointmentDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.Schedule.AppointmentEventArgs) Handles SchdTareas.AppointmentDoubleClick
        If Not DrObraTarea Is Nothing Then
            If ExpertisApp.IsFormOpen("MGOTAREA") Then ExpertisApp.CloseForm("MGOTAREA")
            ExpertisApp.OpenForm("MGOTAREA", New FilterItem("IDTarea", FilterOperator.Equal, DrObraTarea("IDTarea"), FilterType.Numeric))
        End If
    End Sub

    Private Sub SchdTareas_AppointmentRead(ByVal sender As Object, ByVal e As Janus.Windows.Schedule.AppointmentEventArgs) Handles SchdTareas.AppointmentRead
        If Not e.Appointment.DataRow Is Nothing Then
            If Length(e.Appointment.DataRow("Color")) > 0 Then
                e.Appointment.FormatStyle.BackColor = ColorTranslator.FromWin32(e.Appointment.DataRow("Color"))
            End If
        End If
    End Sub

    Private Sub SchdTareas_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SchdTareas.Click
        Dim Appoints As Janus.Windows.Schedule.ScheduleSelectedAppointments = SchdTareas.SelectedAppointments
        If Not Appoints Is Nothing AndAlso Appoints.Count > 0 Then
            DrObraTarea = Appoints(0).DataRow
            CargarQuickInfo()
        Else
            LimpiarQuickInfo()
        End If
    End Sub

#End Region

#Region "Eventos CldMesTarea"

    Private Sub CldMesTarea_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CldMesTarea.SelectionChanged
        Select Case CldMesTarea.SelectedDates.Length
            Case Is < 5
                BtnBarOptions.Groups(0).Items("PorDia").InvokeOnClick()
            Case Is = 5
                BtnBarOptions.Groups(0).Items("PorSemanaLab").InvokeOnClick()
            Case Is = 7
                BtnBarOptions.Groups(0).Items("PorSemana").InvokeOnClick()
            Case Is > 7
                BtnBarOptions.Groups(0).Items("PorMes").InvokeOnClick()
        End Select
    End Sub

#End Region

#Region "Eventos ContextMenu"

    Private Sub CTxtCalendario_Popup(ByVal sender As Object, ByVal e As System.EventArgs) Handles CtxCalendario.Popup
        If SchdTareas.SelectedAppointments.Count = 1 Then
            DrObraTarea = SchdTareas.SelectedAppointments(0).DataRow
            If Length(DrObraTarea.Row("IDObra")) > 0 Then
                Me.VerObra.Enabled = Janus.Windows.UI.InheritableBoolean.True
            Else
                Me.VerObra.Enabled = Janus.Windows.UI.InheritableBoolean.False
            End If
        Else
            Me.VerObra.Enabled = Janus.Windows.UI.InheritableBoolean.False
        End If
    End Sub

    Private Sub VerObra_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles VerObra.Click
        If Not DrObraTarea.Row Is Nothing Then
            If Length(DrObraTarea.Row("IDObra")) > 0 Then
                If ExpertisApp.IsFormOpen("MGEO") Then ExpertisApp.CloseForm("MGEO")
                ExpertisApp.OpenForm("MGEO", New FilterItem("IDObra", FilterOperator.Equal, DrObraTarea.Row("IDObra"), FilterType.Numeric))
            End If
        End If
    End Sub

    Private Sub InformacionRapida_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles InformacionRapida.Click
        Me.UIPnlPrincipal.SelectedPanel = Me.UIPnlTareas
        Me.OpcionesCalendario.Checked = Janus.Windows.UI.InheritableBoolean.False : Me.InformacionRapida.Checked = Janus.Windows.UI.InheritableBoolean.True
    End Sub

    Private Sub OpcionesCalendario_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles OpcionesCalendario.Click
        Me.UIPnlPrincipal.SelectedPanel = Me.UIPnlOpciones
        Me.OpcionesCalendario.Checked = Janus.Windows.UI.InheritableBoolean.True : Me.InformacionRapida.Checked = Janus.Windows.UI.InheritableBoolean.False
    End Sub

    Private Sub VerDia_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles VerDia.Click
        BtnBarOptions.Groups(0).Items("PorDia").InvokeOnClick()
        VerDia.Checked = Janus.Windows.UI.InheritableBoolean.True : VerSemanaLaboral.Checked = Janus.Windows.UI.InheritableBoolean.False
        VerSemana.Checked = Janus.Windows.UI.InheritableBoolean.False : VerMes.Checked = Janus.Windows.UI.InheritableBoolean.False
    End Sub

    Private Sub VerSemanaLaboral_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles VerSemanaLaboral.Click
        BtnBarOptions.Groups(0).Items("PorSemanaLab").InvokeOnClick()
        VerDia.Checked = Janus.Windows.UI.InheritableBoolean.False : VerSemanaLaboral.Checked = Janus.Windows.UI.InheritableBoolean.True
        VerSemana.Checked = Janus.Windows.UI.InheritableBoolean.False : VerMes.Checked = Janus.Windows.UI.InheritableBoolean.False
    End Sub

    Private Sub VerSemana_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles VerSemana.Click
        BtnBarOptions.Groups(0).Items("PorSemana").InvokeOnClick()
        VerDia.Checked = Janus.Windows.UI.InheritableBoolean.False : VerSemanaLaboral.Checked = Janus.Windows.UI.InheritableBoolean.False
        VerSemana.Checked = Janus.Windows.UI.InheritableBoolean.True : VerMes.Checked = Janus.Windows.UI.InheritableBoolean.False
    End Sub

    Private Sub VerMes_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles VerMes.Click
        BtnBarOptions.Groups(0).Items("PorMes").InvokeOnClick()
        VerDia.Checked = Janus.Windows.UI.InheritableBoolean.False : VerSemanaLaboral.Checked = Janus.Windows.UI.InheritableBoolean.False
        VerSemana.Checked = Janus.Windows.UI.InheritableBoolean.False : VerMes.Checked = Janus.Windows.UI.InheritableBoolean.True
    End Sub

#End Region

#Region "Eventos Varios"

    Private Sub BtnIrAFecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIrAFecha.Click
        If Length(ClbIrAFecha.Value) > 0 Then SchdTareas.Date = ClbIrAFecha.Value
    End Sub

    Private Sub BtnBarOptions_ItemClick(ByVal sender As System.Object, ByVal e As Janus.Windows.ButtonBar.ItemEventArgs) Handles BtnBarOptions.ItemClick
        Select Case e.Item.Key
            Case "PorDia"
                Me.SchdTareas.View = Janus.Windows.Schedule.ScheduleView.DayView
                e.Item.StateStyles.FormatStyle.ForeColor = Drawing.Color.Red
                BtnBarOptions.SelectedItem = e.Item
                BtnBarOptions.Groups(0).Items("PorSemana").StateStyles.FormatStyle.ForeColor = Drawing.Color.Black
                BtnBarOptions.Groups(0).Items("PorSemanaLab").StateStyles.FormatStyle.ForeColor = Drawing.Color.Black
                BtnBarOptions.Groups(0).Items("PorMes").StateStyles.FormatStyle.ForeColor = Drawing.Color.Black
                VerDia.Checked = Janus.Windows.UI.InheritableBoolean.True : VerSemanaLaboral.Checked = Janus.Windows.UI.InheritableBoolean.False
                VerSemana.Checked = Janus.Windows.UI.InheritableBoolean.False : VerMes.Checked = Janus.Windows.UI.InheritableBoolean.False
            Case "PorSemana"
                Me.SchdTareas.View = Janus.Windows.Schedule.ScheduleView.WeekView
                e.Item.StateStyles.FormatStyle.ForeColor = Drawing.Color.Red
                BtnBarOptions.SelectedItem = e.Item
                BtnBarOptions.Groups(0).Items("PorDia").StateStyles.FormatStyle.ForeColor = Drawing.Color.Black
                BtnBarOptions.Groups(0).Items("PorSemanaLab").StateStyles.FormatStyle.ForeColor = Drawing.Color.Black
                BtnBarOptions.Groups(0).Items("PorMes").StateStyles.FormatStyle.ForeColor = Drawing.Color.Black
                VerDia.Checked = Janus.Windows.UI.InheritableBoolean.False : VerSemanaLaboral.Checked = Janus.Windows.UI.InheritableBoolean.False
                VerSemana.Checked = Janus.Windows.UI.InheritableBoolean.True : VerMes.Checked = Janus.Windows.UI.InheritableBoolean.False
            Case "PorSemanaLab"
                Me.SchdTareas.View = Janus.Windows.Schedule.ScheduleView.WorkWeek
                e.Item.StateStyles.FormatStyle.ForeColor = Drawing.Color.Red
                BtnBarOptions.SelectedItem = e.Item
                BtnBarOptions.Groups(0).Items("PorDia").StateStyles.FormatStyle.ForeColor = Drawing.Color.Black
                BtnBarOptions.Groups(0).Items("PorSemana").StateStyles.FormatStyle.ForeColor = Drawing.Color.Black
                BtnBarOptions.Groups(0).Items("PorMes").StateStyles.FormatStyle.ForeColor = Drawing.Color.Black
                VerDia.Checked = Janus.Windows.UI.InheritableBoolean.False : VerSemanaLaboral.Checked = Janus.Windows.UI.InheritableBoolean.True
                VerSemana.Checked = Janus.Windows.UI.InheritableBoolean.False : VerMes.Checked = Janus.Windows.UI.InheritableBoolean.False
            Case "PorMes"
                Me.SchdTareas.View = Janus.Windows.Schedule.ScheduleView.MonthView
                e.Item.StateStyles.FormatStyle.ForeColor = Drawing.Color.Red
                BtnBarOptions.SelectedItem = e.Item
                BtnBarOptions.Groups(0).Items("PorDia").StateStyles.FormatStyle.ForeColor = Drawing.Color.Black
                BtnBarOptions.Groups(0).Items("PorSemana").StateStyles.FormatStyle.ForeColor = Drawing.Color.Black
                BtnBarOptions.Groups(0).Items("PorSemanaLab").StateStyles.FormatStyle.ForeColor = Drawing.Color.Black
                VerDia.Checked = Janus.Windows.UI.InheritableBoolean.False : VerSemanaLaboral.Checked = Janus.Windows.UI.InheritableBoolean.False
                VerSemana.Checked = Janus.Windows.UI.InheritableBoolean.False : VerMes.Checked = Janus.Windows.UI.InheritableBoolean.True
        End Select
    End Sub

    Private Sub UIPnlCalendario_GroupSelectedPanelChanged(ByVal sender As Object, ByVal e As Janus.Windows.UI.Dock.GroupSelectedPanelChangedEventArgs) Handles UIPnlCalendario.GroupSelectedPanelChanged
        Select Case e.SelectedPanel.Name
            Case "UIPnlOpciones"
                Me.OpcionesCalendario.Checked = Janus.Windows.UI.InheritableBoolean.True : Me.InformacionRapida.Checked = Janus.Windows.UI.InheritableBoolean.False
            Case "UIPnlTareas"
                Me.OpcionesCalendario.Checked = Janus.Windows.UI.InheritableBoolean.False : Me.InformacionRapida.Checked = Janus.Windows.UI.InheritableBoolean.True
        End Select
    End Sub

#End Region

#End Region

End Class