Imports Janus.Windows.GridEX
Public Class CIObras
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
    Friend WithEvents cbxFechaHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvObraHasta As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblObraHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvCliente As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblCliente As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvObraDesde As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblObraDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxEstado As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblEstado As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ulbDescObra As Solmicro.Expertis.Engine.UI.UnderLineLabel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxEstado_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIObras))
        Me.cbxFechaHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvObraHasta = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblObraHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvCliente = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblCliente = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvObraDesde = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblObraDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxEstado = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblEstado = New Solmicro.Expertis.Engine.UI.Label
        Me.ulbDescObra = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        CType(Me.cbxEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.lblFechaHasta)
        Me.FilterPanel.Controls.Add(Me.ulbDescObra)
        Me.FilterPanel.Controls.Add(Me.cbxFechaHasta)
        Me.FilterPanel.Controls.Add(Me.lblFechaDesde)
        Me.FilterPanel.Controls.Add(Me.cbxFechaDesde)
        Me.FilterPanel.Controls.Add(Me.lblObraHasta)
        Me.FilterPanel.Controls.Add(Me.AdvObraHasta)
        Me.FilterPanel.Controls.Add(Me.lblCliente)
        Me.FilterPanel.Controls.Add(Me.AdvCliente)
        Me.FilterPanel.Controls.Add(Me.lblObraDesde)
        Me.FilterPanel.Controls.Add(Me.AdvObraDesde)
        Me.FilterPanel.Controls.Add(Me.lblEstado)
        Me.FilterPanel.Controls.Add(Me.cbxEstado)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 269)
        Me.FilterPanel.Size = New System.Drawing.Size(616, 80)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(616, 269)
        '
        'Grid
        '
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EntityName = "ObraCabecera"
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Grid.Size = New System.Drawing.Size(616, 269)
        Me.Grid.TabIndex = 6
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.ViewName = "VFrmMntoConsultaProyecto"
        '
        'CheckAll
        '
        Me.CheckAll.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'UncheckAll
        '
        Me.UncheckAll.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'ShowAllCheckedItems
        '
        Me.ShowAllCheckedItems.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'ClearFilter
        '
        Me.ClearFilter.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'Export
        '
        Me.Export.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
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
        Me.MainPanel.Size = New System.Drawing.Size(616, 349)
        '
        'ExecuteActions
        '
        Me.ExecuteActions.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(616, 349)
        '
        'cbxFechaHasta
        '
        Me.cbxFechaHasta.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaHasta.Location = New System.Drawing.Point(512, 51)
        Me.cbxFechaHasta.Name = "cbxFechaHasta"
        Me.cbxFechaHasta.Size = New System.Drawing.Size(96, 21)
        Me.cbxFechaHasta.TabIndex = 5
        '
        'lblFechaHasta
        '
        Me.lblFechaHasta.Location = New System.Drawing.Point(432, 54)
        Me.lblFechaHasta.Name = "lblFechaHasta"
        Me.lblFechaHasta.Size = New System.Drawing.Size(76, 13)
        Me.lblFechaHasta.TabIndex = 0
        Me.lblFechaHasta.Tag = "IdRec=4633;"
        Me.lblFechaHasta.Text = "Fecha Hasta"
        '
        'cbxFechaDesde
        '
        Me.TryDataBinding(cbxFechaDesde, New System.Windows.Forms.Binding("BindableValue", Me, "FechaObra", True))
        Me.cbxFechaDesde.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaDesde.Location = New System.Drawing.Point(512, 24)
        Me.cbxFechaDesde.Name = "cbxFechaDesde"
        Me.cbxFechaDesde.Size = New System.Drawing.Size(96, 21)
        Me.cbxFechaDesde.TabIndex = 4
        '
        'lblFechaDesde
        '
        Me.lblFechaDesde.Location = New System.Drawing.Point(432, 27)
        Me.lblFechaDesde.Name = "lblFechaDesde"
        Me.lblFechaDesde.Size = New System.Drawing.Size(80, 13)
        Me.lblFechaDesde.TabIndex = 8
        Me.lblFechaDesde.Tag = "IdRec=4841;"
        Me.lblFechaDesde.Text = "Fecha Desde"
        '
        'AdvObraHasta
        '
        Me.AdvObraHasta.DisabledBackColor = System.Drawing.Color.White
        Me.AdvObraHasta.DisplayField = "NObra"
        Me.AdvObraHasta.EntityName = "ObraCabecera"
        Me.AdvObraHasta.Location = New System.Drawing.Point(109, 51)
        Me.AdvObraHasta.Name = "AdvObraHasta"
        Me.AdvObraHasta.SecondaryDataFields = "IDObra"
        Me.AdvObraHasta.Size = New System.Drawing.Size(104, 23)
        Me.AdvObraHasta.TabIndex = 1
        '
        'lblObraHasta
        '
        Me.lblObraHasta.Location = New System.Drawing.Point(8, 55)
        Me.lblObraHasta.Name = "lblObraHasta"
        Me.lblObraHasta.Size = New System.Drawing.Size(93, 13)
        Me.lblObraHasta.TabIndex = 9
        Me.lblObraHasta.Tag = ""
        Me.lblObraHasta.Text = "Proyecto Hasta"
        '
        'AdvCliente
        '
        Me.AdvCliente.DisabledBackColor = System.Drawing.Color.White
        Me.AdvCliente.EntityName = "Cliente"
        Me.AdvCliente.Location = New System.Drawing.Point(298, 24)
        Me.AdvCliente.Name = "AdvCliente"
        Me.AdvCliente.SecondaryDataFields = "IDCliente"
        Me.AdvCliente.Size = New System.Drawing.Size(104, 23)
        Me.AdvCliente.TabIndex = 2
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(242, 28)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(47, 13)
        Me.lblCliente.TabIndex = 11
        Me.lblCliente.Tag = "IdRec=4365;"
        Me.lblCliente.Text = "Cliente"
        '
        'AdvObraDesde
        '
        Me.AdvObraDesde.DisabledBackColor = System.Drawing.Color.White
        Me.AdvObraDesde.DisplayField = "NObra"
        Me.AdvObraDesde.EntityName = "ObraCabecera"
        Me.AdvObraDesde.Location = New System.Drawing.Point(109, 24)
        Me.AdvObraDesde.Name = "AdvObraDesde"
        Me.AdvObraDesde.SecondaryDataFields = "IDObra"
        Me.AdvObraDesde.Size = New System.Drawing.Size(104, 23)
        Me.AdvObraDesde.TabIndex = 0
        '
        'lblObraDesde
        '
        Me.lblObraDesde.Location = New System.Drawing.Point(8, 28)
        Me.lblObraDesde.Name = "lblObraDesde"
        Me.lblObraDesde.Size = New System.Drawing.Size(97, 13)
        Me.lblObraDesde.TabIndex = 13
        Me.lblObraDesde.Tag = ""
        Me.lblObraDesde.Text = "Proyecto Desde"
        '
        'cbxEstado
        '
        cbxEstado_DesignTimeLayout.LayoutString = resources.GetString("cbxEstado_DesignTimeLayout.LayoutString")
        Me.cbxEstado.DesignTimeLayout = cbxEstado_DesignTimeLayout
        Me.cbxEstado.DisabledBackColor = System.Drawing.Color.White
        Me.cbxEstado.DisplayMember = "Text"
        Me.cbxEstado.Location = New System.Drawing.Point(298, 51)
        Me.cbxEstado.Name = "cbxEstado"
        Me.cbxEstado.SelectedIndex = -1
        Me.cbxEstado.SelectedItem = Nothing
        Me.cbxEstado.Size = New System.Drawing.Size(104, 21)
        Me.cbxEstado.TabIndex = 3
        Me.cbxEstado.ValueMember = "Value"
        '
        'lblEstado
        '
        Me.lblEstado.Location = New System.Drawing.Point(242, 54)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(45, 13)
        Me.lblEstado.TabIndex = 15
        Me.lblEstado.Tag = "IdRec=4405;"
        Me.lblEstado.Text = "Estado"
        '
        'ulbDescObra
        '
        Me.TryDataBinding(ulbDescObra, New System.Windows.Forms.Binding("Text", Me.AdvObraDesde, "DescObra", True))
        Me.ulbDescObra.Location = New System.Drawing.Point(219, 5)
        Me.ulbDescObra.Name = "ulbDescObra"
        Me.ulbDescObra.Size = New System.Drawing.Size(17, 23)
        Me.ulbDescObra.TabIndex = 16
        Me.ulbDescObra.Visible = False
        '
        'CIObras
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(624, 437)
        Me.EntityName = "ObraCabecera"
        Me.Name = "CIObras"
        Me.Text = "Consulta de Obras"
        Me.ViewName = "VFrmMntoConsultaProyecto"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        CType(Me.cbxEstado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Const cnABRIRCLIENTE As String = "Abrir Cliente"

#Region " Load "

    Protected Overridable Sub CIObras_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            LoadEnum()
            LoadGridActions()
            LoadParams()
        End If
    End Sub

    Protected Overridable Sub LoadEnum()
        cbxEstado.DataSource = New EnumData("enumocEstado")
        EnumData.PopulateValueList("enumocEstado", Grid.Columns("Estado"))
    End Sub

    Protected Overridable Sub LoadGridActions()
        Grid.Actions.Add("Abrir Proyecto", AddressOf AccionAbrirObras, ExpertisApp.GetIcon("xProyectos.ico"))
        Grid.Actions.Add(cnABRIRCLIENTE, AddressOf AccionAbrirCliente, ExpertisApp.GetIcon("xClientes.ico"))
    End Sub

    Protected Overridable Sub LoadParams()
        If Not IsNothing(Me.Params) Then
            If CType(Me.Params, Hashtable).ContainsKey("IDCliente") Then
                Me.AdvCliente.Text = Me.Params("IDCliente")
            End If
            Me.Execute()
        End If
    End Sub

#End Region

#Region " Grid Actions "

    Protected Overridable Sub AccionAbrirObras()
        If ExpertisApp.IsFormOpen("MGEO") Then ExpertisApp.CloseForm("MGEO")
        ExpertisApp.OpenForm("MGEO", New NumberFilterItem("IDObra", Grid.GetValue("IDObra")))
    End Sub

    Protected Overridable Sub AccionAbrirCliente()
        If ExpertisApp.IsFormOpen("MCLIENTE") Then ExpertisApp.CloseForm("MCLIENTE")
        ExpertisApp.OpenForm("MCLIENTE", New FilterItem("IDCliente", FilterOperator.Equal, Grid.GetValue("IDCliente")))
    End Sub

#End Region

    Protected Overridable Sub Grid_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Grid.MouseUp
        If e.Button = MouseButtons.Right Then
            If Not IsNothing(Grid) AndAlso Grid.RowCount > 0 Then
                If Length(Grid.Value("IDCliente")) > 0 Then
                    Grid.UiCommandManager1.Commands(cnABRIRCLIENTE).Visible = InheritableBoolean.True
                Else
                    Grid.UiCommandManager1.Commands(cnABRIRCLIENTE).Visible = InheritableBoolean.False
                End If
            End If
        End If
    End Sub

    Protected Overridable Sub CIObras_QueryExecuting(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting

        e.Filter.Add("NObra", FilterOperator.GreaterThanOrEqual, AdvObraDesde.Text, FilterType.String)
        e.Filter.Add("NObra", FilterOperator.LessThanOrEqual, AdvObraHasta.Text, FilterType.String)

        e.Filter.Add("IDCliente", FilterOperator.Equal, AdvCliente.Text, FilterType.String)
        e.Filter.Add("FechaInicio", FilterOperator.GreaterThanOrEqual, cbxFechaDesde.Value, FilterType.DateTime)
        e.Filter.Add("FechaInicio", FilterOperator.LessThanOrEqual, cbxFechaHasta.Value, FilterType.DateTime)
        e.Filter.Add("Estado", FilterOperator.Equal, cbxEstado.Value, FilterType.Numeric)
    End Sub

    Protected Overridable Sub CIObras_FilterCleared(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.FilterCleared
        Me.cbxFechaDesde.TextBox.Clear() : Me.cbxFechaDesde.Value = Nothing
        Me.cbxFechaHasta.TextBox.Clear() : Me.cbxFechaHasta.Value = Nothing
    End Sub

    Private Sub CIObras_SetReportDesignObjects(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.ReportDesignObjectsEventArgs) Handles MyBase.SetReportDesignObjects
        Dim vMesDesde, vMesHasta As Integer
        Dim vAnio As Integer
        Dim cancel As Boolean

        'Abrir Imprimir Costes laborales
        If e.Alias = "COSLAB" Or e.Alias = "LISTRAB" Then

            Dim frm As New frmInformeCostesLaboral
            frm.ShowDialog()
            vMesDesde = frm.VMDesde
            vMesHasta = frm.VMHasta

            ' Advertencia de todos los meses del año
            If vMesDesde = 0 Then
                MsgBox("Ha seleccionado mes 0, se sacarán los datos de todo el año", MsgBoxStyle.Exclamation, "Información de proceso")
            End If
            vAnio = frm.VA

            If frm.blEstado = True Then
                MessageBox.Show("Proceso Cancelado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                e.Cancel = True
                Exit Sub
            End If
            GenerarInformeCostesLaborales(CInt(vMesDesde), CInt(vMesHasta), CInt(vAnio))
        ElseIf e.Alias = "SINVALORACION" Then
            Dim frm As New frmInformeCostesLaboral
            frm.ShowDialog()
            vMesDesde = frm.VMDesde
            vMesHasta = frm.VMHasta
            vAnio = frm.VA

            If frm.blEstado = True Then
                MessageBox.Show("Proceso Cancelado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                e.Cancel = True
                Exit Sub
            End If
            GenerarInformeSinValoracion(CInt(vMesDesde), CInt(vAnio))
            e.Cancel = True
        ElseIf e.Alias = "CALSINCAL" Then
            Dim frm As New frmInformeCostesLaboral
            frm.ShowDialog()
            vMesDesde = frm.VMDesde
            vAnio = frm.VA

            If frm.blEstado = True Then
                MessageBox.Show("Proceso Cancelado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                e.Cancel = True
                Exit Sub
            End If
            If vMesDesde <> 0 And vAnio <> 0 Then
                Dim strIn As String
                Dim arrIn() As String
                strIn = RecuperarDatosGuardados(vMesDesde, vAnio)
                If Len(strIn) > 0 Then
                    arrIn = Split(strIn, ",")
                    InformeOperariosSinCalcular(strIn)
                    e.Cancel = True
                End If
            End If
        End If
    End Sub
    Private Sub InformeOperariosSinCalcular(ByVal strIn As String)
        Dim rp As New Report("CALSINCAL")
        'Dim strSelect As String
        'strSelect = "SELECT * FROM vCalendarioOsinC WHERE IDOperario IN (" & strIn & ")"
        rp.DataSource = New BE.DataEngine().Filter("vCalendarioOsinC", "*", "IDOperario NOT IN (" & strIn & ")")
        ExpertisApp.OpenReport(rp)
    End Sub
    Private Function RecuperarDatosGuardados(ByVal Mes As Integer, ByVal anio As Integer) As String
        Dim txtSQL As String
        Dim rs As New DataTable
        Dim strIn As String
        Dim fechaR As String
        Try
            fechaR = "01" & "/" & Mes & "/" & anio
            txtSQL = "Mes=" & Mes & " and anyo=" & anio
            Dim filtro As New Filter
            filtro.Add("Mes", FilterOperator.Equal, Mes)
            filtro.Add("anyo", FilterOperator.Equal, anio)


            rs = New BE.DataEngine().Filter("tbOperarioCalendario", filtro)
            strIn = ""
            Dim contador As Integer
            contador = 0
            For Each dr As DataRow In rs.Rows
                If Len(strIn) > 0 Then strIn = strIn & ","
                strIn = strIn & "'" & rs.Rows(contador)("IDOperario").ToString & "'"
                contador += 1
            Next
            'If Not rs.EOF Then
            '    Do Until rs.EOF
            '        If Len(strIn) > 0 Then strIn = strIn & ","
            '        strIn = strIn & "'" & rs.Fields("IDOperario").Value & "'"
            '        rs.MoveNext()
            '    Loop
            'End If
            RecuperarDatosGuardados = strIn
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Private Function GenerarInformeSinValoracion(ByVal sMes As Integer, ByVal sAño As Integer)
        Dim rp As New Report("SINVALORACION")
        Dim filtro As New Filter
        filtro.Add("Anyo", FilterOperator.Equal, sAño)
        filtro.Add("Mes", FilterOperator.Equal, sMes)
        rp.DataSource = New BE.DataEngine().Filter("vInforme1", filtro)
        ExpertisApp.OpenReport(rp)
    End Function

    Public Sub GenerarInformeCostesLaborales(ByVal sMesDesde As Integer, ByVal SmesHasta As Integer, ByVal sAño As Integer)
        Dim sSQL As String
        Dim rsOperarios As New DataTable
        Dim rsaux As New DataTable
        Dim iHorasHN As Integer
        Dim iHorasHX As Integer
        Dim iHorasHE As Integer
        Dim dblCosteHora As Double
        Dim dblCosteHX As Double
        Dim dblCosteHE As Double
        Dim dblSueldo As Double
        Dim dblSumaASueldo As Double
        Dim iHorasTeoricas As Integer
        Dim iHorasReales As Integer
        Dim dblCosteTotal As Double
        Dim dblACCTotal, dblCCTotal, dblVacavTotal As Double
        Dim dblSS, dblDerechos, dblIRPF As Double
        Dim dblTOTAL As Double
        Dim i As Integer

        'De momento eliminamos la tabla actual (es posible que
        'para el futuro nos haga falta)
        Dim metodos As New Business.ClasesTecozam.Mes
        sSQL = "Delete from tbObraCostes"
        metodos.borrar(sSQL)

        Grid.MoveFirst()
        i = 0
        While i < Grid.RowCount

            'Obtenemos los operarios que vamos a necesitar
            ' Control de todo el año. 04/03/2009 Use
            Dim dt As New DataTable
            dt = Grid.DataSource


            'MsgBox(dt.Rows(i)("IDObra").ToString())


            If sMesDesde = 0 Then
                sSQL = "IdObra='" & dt.Rows(i)("IDObra").ToString() & "' and " & _
                "(FechaInicio >='21/" & MesAnterior(1, sAño) & _
                " and FechaInicio <='20/12/" & sAño & "')"
            Else
                sSQL = "IdObra='" & dt.Rows(i)("IDObra").ToString() & "' and " & _
                "(FechaInicio >='21/" & MesAnterior(sMesDesde, sAño) & _
                " and FechaInicio <='20/" & SmesHasta & "/" & sAño & "')"
            End If
            'rsOperarios = AdminData.Filter("vOperariosObra", "distinct(idoperario) as idoperario", sSQL)
            rsOperarios = New BE.DataEngine().Filter("vOperariosObra", "distinct(idoperario) as idoperario", sSQL)

            Dim contador As Integer
            contador = 0
            For Each dr As DataRow In rsOperarios.Rows
                'PARAMETROS INICIALES
                dblACCTotal = 0
                dblCCTotal = 0
                dblVacavTotal = 0
                dblSS = 0
                dblDerechos = 0
                dblIRPF = 0

                'Obtenemos las horas trabajadas (HO)
                ' Control de todo el año. 04/03/2009 Use
                If sMesDesde = 0 Then
                    sSQL = "IdObra='" & dt.Rows(i)("IDObra").ToString() & "' and " & _
                    "(FechaInicio >='21/" & MesAnterior(1, sAño) & _
                    " and FechaInicio <='20/12/" & sAño & "') and idOperario='" & _
                    rsOperarios.Rows(contador)("IdOperario").ToString & "' and IdHora='HO'"
                Else
                    sSQL = "IdObra='" & dt.Rows(i)("IDObra").ToString() & "' and " & _
                           "(FechaInicio >='21/" & MesAnterior(sMesDesde, sAño) & _
                           " and FechaInicio <='20/" & SmesHasta & "/" & sAño & "') and idOperario='" & _
                           rsOperarios.Rows(contador)("IdOperario") & "' and IdHora='HO'"
                End If
                rsaux = New BE.DataEngine().Filter("tbObramodControl", "sum(HorasRealMod) as Suma", sSQL)

                If (rsaux.Rows(0)("Suma") Is DBNull.Value) Then
                    iHorasHN = 0
                Else
                    iHorasHN = CDbl(Nz(rsaux.Rows(0)("Suma"), 0))
                End If


                'Obtenemos las horas trabajadas (HX)
                ' Control de todo el año. 04/03/2009 Use
                If sMesDesde = 0 Then
                    sSQL = "IdObra='" & dt.Rows(i)("IDObra").ToString() & "' and " & _
                    "(FechaInicio >='21/" & MesAnterior(1, sAño) & _
                    " and FechaInicio <='20/12/" & sAño & "') and idOperario='" & _
                    rsOperarios.Rows(contador)("IdOperario").ToString & "' and IdHora='HX'"
                Else
                    sSQL = "IdObra='" & dt.Rows(i)("IDObra").ToString() & "' and " & _
                           "(FechaInicio >='21/" & MesAnterior(sMesDesde, sAño) & _
                           " and FechaInicio <='20/" & SmesHasta & "/" & sAño & "') and idOperario='" & _
                           rsOperarios.Rows(contador)("IdOperario").ToString & "' and IdHora='HX'"
                End If

                rsaux = New BE.DataEngine().Filter("tbObramodControl", "sum(HorasRealMod) as Suma", sSQL)

                If (rsaux.Rows(0)("Suma") Is DBNull.Value) Then
                    iHorasHX = 0
                Else
                    iHorasHX = CDbl(Nz(rsaux.Rows(0)("Suma"), 0))
                End If

                'Obtenemos las horas trabajadas (HE)
                ' Control de todo el año. 04/03/2009 Use
                If sMesDesde = 0 Then
                    sSQL = "IdObra='" & dt.Rows(i)("IDObra").ToString() & "' and " & _
                    "(FechaInicio >='21/" & MesAnterior(1, sAño) & _
                    " and FechaInicio <='20/12/" & sAño & "') and idOperario='" & _
                    rsOperarios.Rows(contador)("IdOperario").ToString & "' and IdHora='HE'"
                Else
                    sSQL = "IdObra='" & dt.Rows(i)("IDObra").ToString() & "' and " & _
                           "(FechaInicio >='21/" & MesAnterior(sMesDesde, sAño) & _
                           " and FechaInicio <='20/" & SmesHasta & "/" & sAño & "') and idOperario='" & _
                           rsOperarios.Rows(contador)("IdOperario").ToString & "' and IdHora='HE'"
                End If
                rsaux = New BE.DataEngine().Filter("tbObramodControl", "sum(HorasRealMod) as Suma", sSQL)


                If (rsaux.Rows(0)("Suma") Is DBNull.Value) Then
                    iHorasHE = 0
                Else
                    iHorasHE = CDbl(Nz(rsaux.Rows(0)("Suma"), 0))
                End If

                rsaux = Nothing

                'Obtenemos el preciohora
                ' Control error Angel
                If rsOperarios.Rows(contador)("IdOperario").ToString = "A0596" Then
                    rsOperarios.Rows(contador)("IdOperario") = rsOperarios.Rows(contador)("IdOperario").ToString
                End If
                sSQL = "idOperario='" & _
                       rsOperarios.Rows(contador)("IdOperario").ToString & "'"

                rsaux = New BE.DataEngine().Filter("tbmaestrooperariosat", "C_H_N, C_H_X, C_H_E, Sueldo, Varios, dieta, Plus", sSQL)


                dblCosteHX = CDbl(Nz(rsaux.Rows(0)("C_H_X"), 0))
                dblCosteHE = CDbl(Nz(rsaux.Rows(0)("C_H_E"), 0))
                dblSueldo = CDbl(Nz(rsaux.Rows(0)("Sueldo"), 0))
                dblSumaASueldo = CDbl(Nz(rsaux.Rows(0)("varios"), 0)) + CDbl(Nz(rsaux.Rows(0)("dieta"), 0)) + CDbl(Nz(rsaux.Rows(0)("plus"), 0))

                If CDbl(Nz(rsaux.Rows(0)("Sueldo"), 0)) > 0 Then
                    'Obtengo el sueldo para hacer el calculo
                    rsaux = Nothing
                    'Necesitamos las horas teoricas y las horas reales trabajadas (mes anterior)
                    ' Control de todo el año. 04/03/2009 Use
                    If sMesDesde = 0 Then
                        sSQL = "idOperario='" & _
                        rsOperarios.Rows(contador)("IdOperario").ToString & "' and Anyo=" & sAño
                    Else
                        sSQL = "idOperario='" & _
                        rsOperarios.Rows(contador)("IdOperario").ToString & "' and Mes=" & _
                       Month(Replace("21/" & MesAnterior(sMesDesde, sAño), "'", "")) & _
                       " and Anyo=" & Year(Replace("21/" & MesAnterior(SmesHasta, sAño), "'", ""))
                    End If

                    rsaux = New BE.DataEngine().Filter("tbOperarioCalendario", "HorasLab2131, HorasTrab2131", sSQL)

                    'If Not (rsaux.Rows(0)("HorasLab2131") Is DBNull.Value) Then
                    If (rsaux.Rows.Count <> 0) Then

                        iHorasTeoricas = Nz(rsaux.Rows(0)("HorasLab2131").ToString, 0)
                        iHorasReales = Nz(rsaux.Rows(0)("HorasTrab2131").ToString, 0)
                    Else
                        ' Si no tiene horas se le debe de aplicar las horas del calentario de obra, porque el trabajador no tenia horas y se coge las teóricas.
                        ' Sino el importe de la hora saldría superior.
                        'iHorasTeoricas = 0
                        'iHorasReales = 0



                        iHorasTeoricas = HorasLabCentroTrabajo(dt.Rows(i)("IDObra"), CDate("21/" & MesAnterior2(sMesDesde, sAño)), CDate("01/" & sMesDesde & "/" & sAño))
                        'iHorasTeoricas = HorasLabCentroTrabajo(dt.Rows(i)("IDObra"), CDate("21/" & sMesDesde & "/" & sAño), CDate("01/" & sMesDesde & "/" & sAño))
                        iHorasReales = iHorasTeoricas


                        'Dim sSql2 As String
                        'Dim shresta As Short = 0
                        'sSQL = "SELECT COUNT(1) " & _
                        '       " FROM tbCalendarioCentro " & _
                        '       " WHERE (Fecha > '" & CDate("21/" & MesAnterior(sMesDesde, sAño)) & "') AND (Fecha < '" & CDate("01/" & sMesDesde & "/" & sAño) & "') AND (IDCentro = '" & dt.Rows(i)("IDObra") & "') "
                        'Try

                        '    Dim dt3 As New DataTable
                        '    Dim lab As New Business.ClasesTecozam.CalendarioCentro
                        '    dt3 = lab.devuelveTabla(sSQL)
                        '    If dt.Rows.Count > 0 AndAlso Not IsDBNull(dt3.Rows(0)(0)) Then
                        '        shresta = dt3.Rows(0)(0)
                        '    End If
                        '    ' La diferencia de días - los días encontrados. * 8h el día.
                        '    iHorasReales = (DateDiff(DateInterval.Day, CDate("21/" & MesAnterior(sMesDesde, sAño)), CDate("01/" & sMesDesde & "/" & sAño)) - shresta) * 8
                        'Catch ex As Exception
                        '    MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error al calcular días laborales en el centro de trabajo.")

                        'End Try
                    End If



                    'Necesitamos las horas teoricas y las horas reales trabajadas
                    rsaux = Nothing
                    ' Control de todo el año. 04/03/2009 Use
                    If sMesDesde = 0 Then
                        sSQL = "idOperario='" & _
                        rsOperarios.Rows(contador)("IdOperario").ToString & "' And Anyo = " & sAño
                    Else
                        sSQL = "idOperario='" & _
                        rsOperarios.Rows(contador)("IdOperario").ToString & "' and Mes=" & _
                        sMesDesde & " and Anyo=" & sAño
                    End If
                    rsaux = New BE.DataEngine().Filter("tbOperarioCalendario", "IdObraPredet, HorasLab0120, HorasTrab0120, ACCTotal, CCTotal, VacavTotal, SSocial, Derechos, IRPF", sSQL)
                    If (rsaux.Rows.Count <> 0) Then
                        'If Not (rsaux.Rows(0)("IDObraPredet") Is DBNull.Value) Then
                        iHorasTeoricas = Nz(iHorasTeoricas, 0) + Nz(rsaux.Rows(0)("HorasLab0120").ToString, 0)
                        iHorasReales = Nz(iHorasReales, 0) + Nz(rsaux.Rows(0)("HorasTrab0120").ToString, 0)

                        'ATENCION SOLO SE SUMAN LA SS, ACC, CC, DERECHOS E IRPF A LA OBRA PREDETERMINADA
                        If rsaux.Rows(0)("IdObraPredet").ToString = dt.Rows(i)("IDObra").ToString() Then
                            dblACCTotal = Nz(rsaux.Rows(0)("ACCTotal").ToString, 0)
                            dblCCTotal = Nz(rsaux.Rows(0)("CCTotal").ToString, 0)
                            dblVacavTotal = Nz(rsaux.Rows(0)("VacavTotal").ToString, 0)
                            dblSS = Nz(rsaux.Rows(0)("SSocial").ToString, 0)
                            dblDerechos = Nz(rsaux.Rows(0)("Derechos").ToString, 0)
                            dblIRPF = Nz(rsaux.Rows(0)("IRPF").ToString, 0)
                        Else
                            dblACCTotal = 0
                            dblCCTotal = 0
                            dblVacavTotal = 0
                            dblSS = 0
                            dblDerechos = 0
                            dblIRPF = 0
                        End If
                    Else
                        iHorasTeoricas = Nz(iHorasTeoricas, 0) + 0
                        iHorasReales = Nz(iHorasReales, 0) + 0
                        dblACCTotal = 0
                        dblCCTotal = 0
                        dblVacavTotal = 0
                        dblSS = 0
                        dblDerechos = 0
                        dblIRPF = 0
                    End If
                    'Coste hora (con sueldo)
                    If iHorasTeoricas = 0 Then
                        dblCosteHora = 0
                    Else
                        dblCosteHora = xRound((Nz(dblSueldo, 0) + Nz(dblSumaASueldo, 0)) / Nz(iHorasTeoricas, 0), 2)
                    End If
                Else
                    'El coste hora viene en la ficha (sin sueldo)
                    dblCosteHora = Nz(rsaux.Rows(0)("C_H_N").ToString, 0)

                End If
                    dblCosteTotal = Nz(dblCosteHora, 0) * Nz(iHorasHN, 0) + (Nz(dblCosteHX, 0) * Nz(iHorasHX, 0)) + (Nz(dblCosteHE, 0) * Nz(iHorasHE, 0))
                    dblTOTAL = Nz(dblCosteTotal, 0) + Nz(dblACCTotal, 0) + Nz(dblCCTotal, 0) + Nz(dblVacavTotal, 0) + Nz(dblSS, 0) + Nz(dblDerechos, 0) + Nz(dblIRPF, 0)

                    'Inserto
                    sSQL = "Insert into tbObraCostes(Id, IdObra, DescObra, Mes, Anyo, IdOperario, Horas, PrecioHora, CosteTotal, ACC, CC, VACAV, SS, Derechos, IRPF, Total) " & _
                            "Values ('" & contador & "','" & dt.Rows(i)("IDObra").ToString() & "','" & Nz(ulbDescObra.Text, "") & "','" & sMesDesde & _
                            "','" & sAño & "', '" & rsOperarios.Rows(contador)("IdOperario").ToString & "', " & (Nz(iHorasHN, 0) + Nz(iHorasHX, 0) + Nz(iHorasHE, 0)) & _
                            ", " & IIf(dblSueldo > 0, "Null", Replace(Nz(dblCosteHora, 0), ",", ".")) & ", " & Replace(Nz(dblCosteTotal, 0), ",", ".") & _
                            ", " & Replace(Nz(dblACCTotal, 0), ",", ".") & ", " & Replace(Nz(dblCCTotal, 0), ",", ".") & ", " & Replace(Nz(dblVacavTotal, 0), ",", ".") & _
                            ", " & Replace(Nz(dblSS, 0), ",", ".") & ", " & Replace(Nz(dblDerechos, 0), ",", ".") & ", " & Replace(Nz(dblIRPF, 0), ",", ".") & _
                            ", " & Replace(Nz(dblTOTAL, 0), ",", ".") & ")"

                    Dim labo As New Business.ClasesTecozam.CalendarioCentro
                    labo.ejecutaSql(sSQL)

                    contador += 1
            Next
            'Libero memoria
            rsOperarios = Nothing
            rsaux = Nothing
            'FWNConsulta = Nothing
            i = i + 1
            'Grid.MoveNext()
        End While
    End Sub

    Function MesAnterior(ByVal Mes As Integer, ByVal Ano As Integer) As String
        Select Case Mes
            Case 1
                MesAnterior = "12/" & Ano - 1 & "'"
            Case Else
                MesAnterior = Mes - 1 & "/" & Ano & "'"
        End Select
    End Function
    Function MesAnterior2(ByVal Mes As Integer, ByVal Ano As Integer) As String
        Select Case Mes
            Case 1
                MesAnterior2 = "12/" & Ano - 1 & "'"
            Case Else
                MesAnterior2 = Mes - 1 & "/" & Ano & ""
        End Select
    End Function

    Function HorasLabCentroTrabajo(ByVal idObra As Integer, ByVal dDesde As Date, ByVal dHasta As Date) As Integer
        ' Obtiene las horas del centro de trabajo entre fechas dadas. 1 Día - 8 h.
        Dim sSql As String
        Dim shresta As Short = 0
        sSql = "SELECT COUNT(1) " & _
               " FROM tbCalendarioCentro " & _
               " WHERE (Fecha > '" & dDesde & "') AND (Fecha < '" & dHasta & "') AND (IDCentro = '" & idObra & "') "
        Try

            Dim dt As New DataTable
            Dim lab As New Business.ClasesTecozam.CalendarioCentro
            dt = lab.devuelveTabla(sSql)
            If dt.Rows.Count > 0 AndAlso Not IsDBNull(dt.Rows(0)(0)) Then
                shresta = dt.Rows(0)(0)
            End If
            ' La diferencia de días - los días encontrados. * 8h el día.
            Return (DateDiff(DateInterval.Day, dDesde, dHasta) - shresta) * 8
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error al calcular días laborales en el centro de trabajo.")
            Return 0
        End Try
    End Function

End Class