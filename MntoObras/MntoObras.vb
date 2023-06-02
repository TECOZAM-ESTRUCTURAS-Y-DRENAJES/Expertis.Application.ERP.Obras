Imports Janus.Windows.UI
Public Class MntoObras
    Inherits Solmicro.Expertis.Engine.UI.SimpleMnto

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cuaquier inicialización después de la llamada a InitializeComponent()
        Me.GridCertificacionTrabajo.LinkFields = New String() {"IdCertificacion"}
        Me.GridCertificacionTrabajo.ParentLinkFields = New String() {"IdCertificacion"}
        Me.GridCertificacionTrabajo.ParentData = Me.GridCertificacion

        Me.GridCertificacionMedicion.LinkFields = New String() {"IdLineaCertificacionTrabajo"}
        Me.GridCertificacionMedicion.ParentLinkFields = New String() {"IdLineaCertificacionTrabajo"}
        Me.GridCertificacionMedicion.ParentData = Me.GridCertificacionTrabajo
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
    Public WithEvents PnlCabecera As System.Windows.Forms.Panel
    Public WithEvents txtDescObra As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents cbxEstado As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents txtNObra As Solmicro.Expertis.Engine.UI.CounterTextBox
    Public WithEvents lblEstado As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblObra As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents TabObras As Solmicro.Expertis.Engine.UI.Tab
    Public WithEvents TabPageCabeceraObra As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents FraCondEconom As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents lblDiaPago As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblCondicionPago As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblFormaPago As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblMoneda As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents FraClientes As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents lblPoblacion As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblCodPostal As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblProvincia As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblDireccion As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblCliente As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents ulDescCliente As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents FraFechas As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents lblFechaInicio As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblFechaFin As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblTipoObra As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents ulDescTipoObra As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents AdvIDDiaPago As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents AdvIDCondicionPago As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents AdvIDFormaPago As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents txtCodPostal As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents txtDireccion As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents AdvIDCliente As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents cbxFechaInicio As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents cbxFechaFin As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents pnlCliente As System.Windows.Forms.Panel
    Public WithEvents txtPoblacion As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents AdvIDTipoObra As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents TabPageTrabajos As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents TabPageCaracteristicas As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents TabPageRecursos As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents TabPageSeguimiento As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents TabPageEstructura As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents TabPageCoste As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents FraDireccion As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents ImageList1 As System.Windows.Forms.ImageList
    Public WithEvents GridRecursos As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents pnlTrabajos As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents Splitter1 As System.Windows.Forms.Splitter
    Public WithEvents TabPageDetalleTrabajos As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents TabPagePrevistos As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents TabPageControl As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents TabPageTareas As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents FraCriterios As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents pnlVerPrevistos As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents FraTotalesPrev As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents lblTotalPrevVenta As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblTotalPrev As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents FraTotalesReal As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents lblTotalFacturado As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtTotalFacturado As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents txtTotalPrevVenta As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblTotalReal As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtTotalReal As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents txtTotalPrev As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblTotalControl As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtTotalControl As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents GridCaracteristicas As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents pnlTotalesHitos As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents lblTotalVtoA As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtTotalVtoA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblTotalA As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtTotalA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblDireccionObra As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtDireccionObra As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblProvinciaObra As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtProvinciaObra As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblCodPostalObra As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtCodPostalObra As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblPoblacionObra As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtPoblacionObra As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents txtProvincia As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents txtIdDireccion As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents TabTrabajos As Solmicro.Expertis.Engine.UI.Tab
    Public WithEvents OpenDialog1 As System.Windows.Forms.OpenFileDialog
    Public WithEvents txtDescTrabajoPrev As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblTrabajoPrev As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtTrabajoPrev As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents FraTotalObraPadre As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents lblFwTotalObraPresup As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblTotalObraReal As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblTotalObraPresupVta As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblTotalObraFacturado As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents Frame1 As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents lblTotalObraHijaFacturado As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblTotalObraHijaReal As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblTotalObraHijaPresupVta As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblTotalObraHijaPresup As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents tvwCostes As System.Windows.Forms.TreeView
    Public WithEvents txtTotalCostePrev As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents txtTotalCosteReal As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents txtTotalCostePrevVta As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents txtTotalCosteFact As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents rbtVerGrid As Solmicro.Expertis.Engine.UI.RadioButton
    Public WithEvents rbtVerFicha As Solmicro.Expertis.Engine.UI.RadioButton
    Public WithEvents TabPageHitos As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents AdvSubTipoTrabajo As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents AdvTipoTrabajo As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents FraSeguimiento As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents txtNivelTrabajo As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblNivelTrabajo As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents FraFechasTrabajo As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents lblFechaFinTrabajo As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxFechaFinTrabajo As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents lblFechaInicioTrabajo As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxFechaInicioTrabajo As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents cbxIDCentroGestion As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents lblNumPedido As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtNumPedido As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblSolapeAnt As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtSolapeAnt As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblSecuencia As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtSecuencia As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblDuracionPrev As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents FraAvance As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents lblAvanceCalculado As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtAvanceCalculado As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblAvanceEstimado As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtAvanceEstimado As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblIDArticulo As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents AdvIDArticulo As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblQCertificada As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtQCertificada As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents chkNoAcumular As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents chkFacturable As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents lblTipoFacturacion As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxTipoFacturacion As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents lblUDMedida As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblQPrev As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblCodTrabajo As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxIDUDMedida As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents lblImpUnitario As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtImpUnitario As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents txtQPrev As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents txtDescTrabajo As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblTipoTrabajo As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblSubTipoTrabajo As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtCodTrabajo As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents pnlGridTrabajo As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents pnlFichaTrabajo As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents pnlFichaTrabajoTop As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents txtFacturadoTrabajo As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents txtRealTrabajo As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents txtPrevistoVentaTrabajo As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents txtPrevistoTrabajo As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblPrevTrabajo As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblPrevVentaTrabajo As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblRealTrabajo As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblFactTrabajo As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents pnlFichaTrabajoFill As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents txtTextoTrabajo As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblTextoTrabajo As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents FraImportesTrabajoFicha As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents FraImportesTrabajoGrid As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents txtFacturadoTrabajoGrid As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents txtRealTrabajoGrid As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents txtPrevistoVentaTrabajoGrid As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents txtPrevistoTrabajoGrid As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblPrevTrabajoGrid As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblPrevVentaTrabajoGrid As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblRealTrabajoGrid As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblFactTrabajoGrid As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtCosteFacturado As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents txtCosteReal As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents txtCostePrevVenta As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents txtCostePrev As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents txtDuracionPrev As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents rbtPrevObra As Solmicro.Expertis.Engine.UI.RadioButton
    Public WithEvents TabPrevistos As Solmicro.Expertis.Engine.UI.Tab
    Public WithEvents TabPageMaterialesPrev As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents GridMaterialPrev As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents TabPageModPrev As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents GridMODPrev As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents TabPageCentrosPrev As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents GridCentrosPrev As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents TabPageGastosPrev As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents GridGastosPrev As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents TabPageVariosPrev As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents GridVariosPrev As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents rbtControlObra As Solmicro.Expertis.Engine.UI.RadioButton
    Public WithEvents pnlVerControl As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents txtDescTrabajoControl As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblTrabajoControl As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtTrabajoControl As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents TabControl As Solmicro.Expertis.Engine.UI.Tab
    Public WithEvents TabPageMaterialesControl As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents GridMaterialControl As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents TabPageModControl As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents GridMODControl As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents TabPageCentrosControl As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents GridCentroControl As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents TabPageGastosControl As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents GridGastosControl As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents TabPageVariosControl As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents GridVariosControl As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents rbtHitosTrabajo As Solmicro.Expertis.Engine.UI.RadioButton
    Public WithEvents rbtHitosObra As Solmicro.Expertis.Engine.UI.RadioButton
    Public WithEvents pnlVerHitos As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents txtDescTrabajoHitos As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblTrabajoHitos As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtTrabajoHitos As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents GridVencimientos As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents rbtTareasTrabajo As Solmicro.Expertis.Engine.UI.RadioButton
    Public WithEvents rbtTareasObra As Solmicro.Expertis.Engine.UI.RadioButton
    Public WithEvents pnlVerTareas As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents txtDescTrabajoTareas As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblTrabajoTareas As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtTrabajoTareas As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents GridTareas As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents rbtOperariosTrabajo As Solmicro.Expertis.Engine.UI.RadioButton
    Public WithEvents rbtOperariosObra As Solmicro.Expertis.Engine.UI.RadioButton
    Public WithEvents pnlVerOperarios As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents txtDescTrabajoOperarios As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblTrabajoOperarios As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtTrabajoOperarios As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents GridOperariosTrabajo As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents lblVerPrevistos As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblVerControl As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblVerHitos As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblVerTareas As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblVerOperarios As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents pnlConfigVerPrevistos As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents pnlConfigVerControl As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents pnlConfigVerHitos As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents pnlConfigVerTareas As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents pnlConfigVerOperarios As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents pnlVerTrabajosGrid As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents txtDescTrabajoGrid As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblTrabajoGrid As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtTrabajoGrid As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents pnlConfigVerTrabajos As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents lblVerTrabajos As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents GridTrabajos As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents GridMediciones As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents lblTotalMedicion As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtTotalMedicion As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents TabPageControlMediciones As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents TabPageMediciones As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents FraImportesMedicionesPrev As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents pnlCertificacionTrabajo As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents GridCertificacionTrabajo As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents pnlLabelCertificacionTrabajo As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents lblCertificacionTrabajo As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents Splitter2 As System.Windows.Forms.Splitter
    Public WithEvents pnlLabelObraCertificacion As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents lblCertificacion As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents pnlCertificacion As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents lblQPrevPrev As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtQPrevTrabajo As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblClaseObra As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxIDClase As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents GridProveedores As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents TabPageProveedor As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents FraRetencion As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents lblFechaRetencion As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxFechaRetencion As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents lblRetencion As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtRetencion As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblTipoRetencion As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxTipoRetencion As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents lblGridCostes As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents GridCostes As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents lblNivel As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtNivel As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblObraPadre As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents AdvIDObraPadre As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblNumeroPedido As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtNumeroPedido As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblFechaObra As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxFechaObra As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents lblURLContrato As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtURLContrato As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblNumPresup As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtNumPresup As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents txtRevPresup As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents CmbUrlContrato As Solmicro.Expertis.Engine.UI.Button
    Public WithEvents LblBarra As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents FraTotalesObra As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents txtImpFactA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents txtImpRealA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblTotalObrasA As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents FraImportes As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Public WithEvents lblCosteIndirecto As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblCosteDirecto As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtMargenRealVarios As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents txtMargenRealGastos As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents txtMargenRealCentros As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents txtMargenRealMod As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents txtMargenRealMat As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblPorcReal As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtImpFactTrabajoA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblImpFact As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtImpFactModA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents txtImpFactCentrosA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents txtImpFactGastosA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents txtImpFactVariosA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents txtImpFactMatA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents txtImpRealMatA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents txtImpRealVariosA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents txtImpRealGastosA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents txtImpRealCentrosA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents txtImpRealModA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblImpReal As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtImpRealTrabajoA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents txtImpPrevQTrabajoVentaA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblImpVentaPrev As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtImpPrevQModVentaA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents txtImpPrevQCentrosVentaA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents txtImpPrevQGastosVentaA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents txtImpPrevQVariosVentaA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents txtImpPrevQMatVentaA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblPorcPrev As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtMargenPrevMat As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents txtMargenPrevMod As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents txtMargenPrevCentro As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents txtMargenPrevGastos As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents txtMargenPrevVarios As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblMaterialesA As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtImpPrevQMatA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents Linea As Janus.Windows.EditControls.UIGroupBox
    Public WithEvents lblVariosA As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtImpPrevQVariosA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblGastosA As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtImpPrevQGastosA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblCentrosA As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtImpPrevQCentrosA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblModA As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtImpPrevQModA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblCostePrev As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtMargenTrabajoPrev As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblTotalTrabajosA As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtImpPrevQTrabajoA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents txtMargenRealTrabajo As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents txtImpVencimientoA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblVencimientosA As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtVencimientosA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxTipoCoste As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents txtPrevVentaIndirecto As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents txtPrevDirecto As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents txtPrevIndirecto As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents txtPrevVentaDirecto As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblQPrevResponsable As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblQReal As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtQReal As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents txtQPrevResponsable As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblTipoIVA As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents AdvIDTipoIVA As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblCambioA As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtCambioA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents ulDescMoneda As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents rbtPorNivelTrabajos As Solmicro.Expertis.Engine.UI.RadioButton
    Public WithEvents rbtPorTrabajosObra As Solmicro.Expertis.Engine.UI.RadioButton
    Public WithEvents rbtPorNivelPrev As Solmicro.Expertis.Engine.UI.RadioButton
    Public WithEvents rbtNivelControl As Solmicro.Expertis.Engine.UI.RadioButton
    Public WithEvents rbtPorMultinivelTrabajos As Solmicro.Expertis.Engine.UI.RadioButton
    Public WithEvents rbtPorMultinivelPrev As Solmicro.Expertis.Engine.UI.RadioButton
    Public WithEvents rbtMultinivelControl As Solmicro.Expertis.Engine.UI.RadioButton
    Public WithEvents txtImpPrevVentaA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents txtImpPrevA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents FraArbol As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents rbtMinimizarTree As Solmicro.Expertis.Engine.UI.RadioButton
    Public WithEvents rbtMaximizarTree As Solmicro.Expertis.Engine.UI.RadioButton
    Public WithEvents lblEstadoDistintoDE As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxEstadoDistintoDE As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents TvwTrabajos As System.Windows.Forms.TreeView
    Public WithEvents cboTipoRetencionImpuestos As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents lblTipoLinea As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxTipoLinea As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents lblPeriodo As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxTipoPeriodo As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents txtPeriodo As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents GridCertificacionMedicion As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents AdvSubSubTipoTrabajo As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblSubSubTipoTrabajo As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents Label7 As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtMargenTrabajoFicha As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblImpUnitarioVta As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents UiTabPage1 As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents UiTabPage2 As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents UiTabPage3 As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents GridPlanningCobros As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents GridPlanningPagos As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents TabCobrosPagos As Solmicro.Expertis.Engine.UI.Tab
    Public WithEvents pnlVerCertificacion As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents lblNumCertificacion As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents chkVerUltimaCertificacion As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents AdvSearchCertificacion As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents TabTiposCertificacion As Solmicro.Expertis.Engine.UI.Tab
    Public WithEvents UiTabCliente As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents UiTabProduccion As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents GridCertificacion As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents UiTabClienteProduccion As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents cbxTipoCertificacion As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents lblVerCertificacionPor As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents optCertificacionPorTrabajo As Solmicro.Expertis.Engine.UI.RadioButton
    Public WithEvents optCertificacionPorCapitulos As Solmicro.Expertis.Engine.UI.RadioButton
    Public WithEvents lblCentroGestionTrabajo As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblCentroGestion As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxCentroGestion As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents chkVerPorcentajes As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents txtMargenReal As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents txtMargenPrev As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblEstadoTrabajo As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxEstadoTrabajo As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents lblTrabajoPresup As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents AdvTrabajoPresup As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblIncremento As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtIncremento As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents TabPageCobrosPagos As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents TvwCobrosPagos As System.Windows.Forms.TreeView
    Public WithEvents Splitter3 As System.Windows.Forms.Splitter
    Public WithEvents GridTramos As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents MnuNuevoTrabajo As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents MenuObras As Janus.Windows.UI.CommandBars.UIContextMenu
    Public WithEvents MnuNuevoTrabajoIncremento As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents MnuGeneraVtos As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents mnuNuevaTarea As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents MnuDeleteTrabajo As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents MnuDeleteIncremento As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents MnuAnalitica As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents MnuADDIncremento As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents MnuNuevoConcepto As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents MnuDesgloseTrabajo As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents MnuVerFichaTrabajo As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents MnuTareasPred As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents mnuGenerarCompras As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents mnuExpedir As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents mnuFacturacion As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents MnuNuevoTrabajo2 As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents MnuNuevoTrabajoIncremento2 As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents MnuGeneraVtos2 As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents mnuNuevaTarea2 As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents MnuDeleteTrabajo2 As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents MnuDeleteIncremento2 As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents MnuADDIncremento2 As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents MnuDesgloseTrabajo2 As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents MnuVerFichaTrabajo2 As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents MnuTareasPred2 As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents mnuGenerarCompras2 As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents mnuExpedir2 As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents mnuFacturacion2 As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents MnuGuion As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents MnuGuion1 As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents MnuGuion3 As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents MnuGuion5 As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents MnuGuion6 As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents MnuNuevoConcepto1 As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents MnuGuion4 As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents MnuVerObras As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents MenuEstructura As Janus.Windows.UI.CommandBars.UIContextMenu
    Public WithEvents MnuVerObras1 As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents mnuPlanificador As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents mnuPlanificador1 As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents MnuGuion7 As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents TabPageOficios As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents FraTotalObraPadreEstructura As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents lblTotalPrevEstructura As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtTotalEstructuraPrev As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblTotalPrevEstructuraReal As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtTotalEstructuraReal As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblTotalPrevEstructuraVta As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtTotalEstructuraPrevVta As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblTotalPrevEstructuraFacturado As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtTotalEstructuraFact As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents FraTotalSeleccionObra As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents lblTotalFacturadoTree As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtTotalFacturadoTree As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblTotalRealTree As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtTotalRealTree As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblTotalPrevVentaTree As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtTotalPrevVentaTree As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblTotalPrevTree As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtTotalPrevTree As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents pnlTopEstructura As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents cmbObraPadre As Solmicro.Expertis.Engine.UI.Button
    Public WithEvents lblNivel2 As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblObraPadre2 As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtNivelObra As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents txtCodTrabajoPadre As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents chkVerTrabajos As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents tvwEstructura As System.Windows.Forms.TreeView
    Public WithEvents fra As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents txtTotalBeneficioIndustrial As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents txtTotalCoefBaja As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents txtTotalGastosGenerales As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents UiGroupBox3 As Janus.Windows.EditControls.UIGroupBox
    Public WithEvents lblImporteIva As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtTotalIva As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblTotal As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtTotal As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblBeneficioIndustrial As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtBeneficioIndustrial As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblCoefBaja As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtCoefBaja As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblGastosGenerales As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtGastosGenerales As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents pnlObservaciones As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents lblTexto As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtTexto As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblTOTALObraVenta As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtImpPrevVentaABis As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents TabPageAvance As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents pnlVerAvance As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents txtDescTrabajoAvance As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblTrabajoAvance As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtTrabajoAvance As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents mnuAvanceTrabajo As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents mnuADDPeriodosAvance As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents mnuActualizarAvanceReal As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents mnuRehacerPeriodos As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents mnuADDPeriodosAvance1 As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents mnuActualizarAvanceReal1 As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents mnuRehacerPeriodos1 As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents MnuGuion9 As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents mnuAvanceTrabajo1 As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents Label3 As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxFechaFinTrabajoAvance As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents Label4 As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxFechaInicioTrabajoAvance As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents mnuVerDesviaciones As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents Separator5 As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents rbtVerProyectoCompleto As Solmicro.Expertis.Engine.UI.RadioButton
    Public WithEvents pnlTrabajosCompleto As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents pnlVerTrabajosCompleto As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents txtDescTrabajoCompleto As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblTrabajoCompleto As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtTrabajoCompleto As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents txtImpUnitarioVta As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents TvwObraCompleta As System.Windows.Forms.TreeView
    Public WithEvents ImageListGrids As System.Windows.Forms.ImageList
    Public WithEvents ImageListTrabajoCompleto As System.Windows.Forms.ImageList
    Public WithEvents Separator6 As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents pnlLeyendaAvance As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents lblPeriodosRecalculados As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents pnlPeriodosRecalculados As System.Windows.Forms.Panel
    Public WithEvents GridAvanceTrabajo As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents AdvIDMoneda As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents MnuGuion2 As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents MnuAnalitica1 As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents ImageListAvance As System.Windows.Forms.ImageList
    Public WithEvents mnuAltaDocumentos As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents mnuVincularDocumentos As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents mnuDocumentosRel As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents mnuAltaDocumentos1 As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents mnuVincularDocumentos1 As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents mnuDocumentosRel1 As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents PnlTimeObras As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents RdTimeObras As Solmicro.Expertis.Engine.UI.RadioButton
    Public WithEvents CtrlTimeLineObras1 As Solmicro.Expertis.Application.ERP.CommonClasses.CtrlTimeLineObras
    Public WithEvents chkPlanificarRecursosPorTareas As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents mnuArbolTrabajos As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents mnuArbolTrabajos1 As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents lblQUnitaria As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents ntxQUnidad As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents txtCambioB As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblCambioB As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents pnlConfigTipoMonedaHitos As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents lblGestionMonedaHitos As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents rbtMonedaA As Solmicro.Expertis.Engine.UI.RadioButton
    Public WithEvents rbtMonedaCliente As Solmicro.Expertis.Engine.UI.RadioButton
    Public WithEvents chkSeguroCambio As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents FraPeriodificacion As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents chkPeriodificable As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents lblPeridoPeriodificacion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblTipoPeriodoPeriodificacion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ntxPeriodoPeriodificacion As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents cbxTipoPeriodoPeriodificacion As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents chkAplicarSobreUltimo As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents lblPorcIncrDecrPerido As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents ntxPorcIncrDecrPerido As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents MnuGeneraVtosPeriodificados As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents MnuGenerarTrabajosPeriodificados As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents MnuPeriodificaciones As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents MnuGenerarTrabajosPeriodificados1 As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents MnuGeneraVtosPeriodificados1 As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents MnuGuion8 As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents MnuPeriodificaciones1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents ntbDiaFacturacion As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblDiaFacturacion As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents mnuVerDesviaciones1 As Janus.Windows.UI.CommandBars.UICommand

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim cbxEstado_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxCentroGestion_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxIDClase_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxTipoPeriodoPeriodificacion_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxEstadoTrabajo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxTipoLinea_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxTipoCoste_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxIDCentroGestion_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxTipoFacturacion_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxIDUDMedida_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridTrabajos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridTrabajos_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column7.ButtonImage")
        Dim GridTrabajos_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column8.ButtonImage")
        Dim GridTrabajos_DesignTimeLayout_Reference_2 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column16.ButtonImage")
        Dim GridTrabajos_DesignTimeLayout_Reference_3 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column30.ButtonImage")
        Dim GridTrabajos_DesignTimeLayout_Reference_4 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column31.ButtonImage")
        Dim GridTrabajos_DesignTimeLayout_Reference_5 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.ImageList.ImageStream")
        Dim GridMaterialPrev_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridMaterialPrev_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column5.ButtonImage")
        Dim GridMaterialPrev_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column7.ButtonImage")
        Dim GridMaterialPrev_DesignTimeLayout_Reference_2 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column9.ButtonImage")
        Dim GridMaterialPrev_DesignTimeLayout_Reference_3 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column10.ButtonImage")
        Dim GridMaterialPrev_DesignTimeLayout_Reference_4 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column11.ButtonImage")
        Dim GridMaterialPrev_DesignTimeLayout_Reference_5 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column12.ButtonImage")
        Dim GridMaterialPrev_DesignTimeLayout_Reference_6 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column18.ButtonImage")
        Dim GridMaterialPrev_DesignTimeLayout_Reference_7 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column19.ButtonImage")
        Dim GridMaterialPrev_DesignTimeLayout_Reference_8 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column20.ButtonImage")
        Dim GridMaterialPrev_DesignTimeLayout_Reference_9 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.ImageList.ImageStream")
        Dim GridMODPrev_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridMODPrev_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column5.ButtonImage")
        Dim GridMODPrev_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column7.ButtonImage")
        Dim GridMODPrev_DesignTimeLayout_Reference_2 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column11.ButtonImage")
        Dim GridMODPrev_DesignTimeLayout_Reference_3 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.ImageList.ImageStream")
        Dim GridCentrosPrev_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridCentrosPrev_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column5.ButtonImage")
        Dim GridCentrosPrev_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column7.ButtonImage")
        Dim GridCentrosPrev_DesignTimeLayout_Reference_2 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.ImageList.ImageStream")
        Dim GridGastosPrev_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridGastosPrev_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column4.ButtonImage")
        Dim GridGastosPrev_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column5.ButtonImage")
        Dim GridGastosPrev_DesignTimeLayout_Reference_2 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.ImageList.ImageStream")
        Dim GridVariosPrev_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridVariosPrev_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column4.ButtonImage")
        Dim GridVariosPrev_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column5.ButtonImage")
        Dim GridVariosPrev_DesignTimeLayout_Reference_2 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.ImageList.ImageStream")
        Dim GridMediciones_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridMediciones_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column3.ButtonImage")
        Dim GridMaterialControl_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridMaterialControl_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column3.ButtonImage")
        Dim GridMaterialControl_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column5.ButtonImage")
        Dim GridMaterialControl_DesignTimeLayout_Reference_2 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.ImageList.ImageStream")
        Dim GridMODControl_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridMODControl_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column4.ButtonImage")
        Dim GridMODControl_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column11.ButtonImage")
        Dim GridMODControl_DesignTimeLayout_Reference_2 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column17.ButtonImage")
        Dim GridCentroControl_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridCentroControl_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column3.ButtonImage")
        Dim GridCentroControl_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column4.ButtonImage")
        Dim GridCentroControl_DesignTimeLayout_Reference_2 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column10.ButtonImage")
        Dim GridGastosControl_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridGastosControl_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column3.ButtonImage")
        Dim GridGastosControl_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column4.ButtonImage")
        Dim GridGastosControl_DesignTimeLayout_Reference_2 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column6.ButtonImage")
        Dim GridGastosControl_DesignTimeLayout_Reference_3 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column15.ButtonImage")
        Dim GridVariosControl_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridVariosControl_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column3.ButtonImage")
        Dim GridVariosControl_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column4.ButtonImage")
        Dim GridCertificacionTrabajo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridCertificacionTrabajo_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.ImageList.ImageStream")
        Dim GridCertificacionMedicion_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridCertificacion_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridCertificacion_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.ImageList.ImageStream")
        Dim cbxTipoCertificacion_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridVencimientos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridVencimientos_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column8.ButtonImage")
        Dim GridVencimientos_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column11.ButtonImage")
        Dim GridVencimientos_DesignTimeLayout_Reference_2 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column12.ButtonImage")
        Dim GridVencimientos_DesignTimeLayout_Reference_3 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column13.ButtonImage")
        Dim GridVencimientos_DesignTimeLayout_Reference_4 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column14.ButtonImage")
        Dim GridVencimientos_DesignTimeLayout_Reference_5 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column16.ButtonImage")
        Dim GridVencimientos_DesignTimeLayout_Reference_6 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column21.ButtonImage")
        Dim GridTareas_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridTareas_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column5.ButtonImage")
        Dim GridTareas_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column9.ButtonImage")
        Dim GridTareas_DesignTimeLayout_Reference_2 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column11.ButtonImage")
        Dim GridTareas_DesignTimeLayout_Reference_3 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column16.ButtonImage")
        Dim GridTareas_DesignTimeLayout_Reference_4 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.ImageList.ImageStream")
        Dim GridOperariosTrabajo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridOperariosTrabajo_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column5.ButtonImage")
        Dim GridOperariosTrabajo_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column6.ButtonImage")
        Dim GridOperariosTrabajo_DesignTimeLayout_Reference_2 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column8.ButtonImage")
        Dim GridOperariosTrabajo_DesignTimeLayout_Reference_3 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.ImageList.ImageStream")
        Dim GridAvanceTrabajo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxEstadoDistintoDE_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridCaracteristicas_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridCaracteristicas_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column4.ButtonImage")
        Dim GridRecursos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridRecursos_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column3.ButtonImage")
        Dim GridRecursos_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.ImageList.ImageStream")
        Dim cbxTipoPeriodo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cboTipoRetencionImpuestos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxTipoRetencion_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridCostes_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridCostes_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column3.ButtonImage")
        Dim GridProveedores_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridProveedores_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.ButtonImage")
        Dim GridTramos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridPlanningCobros_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridPlanningPagos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MntoObras))
        Me.PnlCabecera = New System.Windows.Forms.Panel
        Me.lblEstado = New Solmicro.Expertis.Engine.UI.Label
        Me.lblObra = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxEstado = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.txtDescObra = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtNObra = New Solmicro.Expertis.Engine.UI.CounterTextBox
        Me.TabObras = New Solmicro.Expertis.Engine.UI.Tab
        Me.TabPageCabeceraObra = New Janus.Windows.UI.Tab.UITabPage
        Me.FraImportes = New Solmicro.Expertis.Engine.UI.Frame
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
        Me.lblCosteIndirecto = New Solmicro.Expertis.Engine.UI.Label
        Me.txtPrevIndirecto = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtPrevVentaIndirecto = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblCosteDirecto = New Solmicro.Expertis.Engine.UI.Label
        Me.txtPrevDirecto = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtPrevVentaDirecto = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtMargenRealVarios = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtMargenRealGastos = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtMargenRealCentros = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtMargenRealMod = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtMargenRealMat = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblPorcReal = New Solmicro.Expertis.Engine.UI.Label
        Me.txtImpFactTrabajoA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblImpFact = New Solmicro.Expertis.Engine.UI.Label
        Me.txtImpFactModA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImpFactCentrosA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImpFactGastosA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImpFactVariosA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImpFactMatA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImpRealMatA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImpRealVariosA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImpRealGastosA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImpRealCentrosA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImpRealModA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblImpReal = New Solmicro.Expertis.Engine.UI.Label
        Me.txtImpRealTrabajoA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImpPrevQTrabajoVentaA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblImpVentaPrev = New Solmicro.Expertis.Engine.UI.Label
        Me.txtImpPrevQModVentaA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImpPrevQCentrosVentaA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImpPrevQGastosVentaA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImpPrevQVariosVentaA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImpPrevQMatVentaA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblPorcPrev = New Solmicro.Expertis.Engine.UI.Label
        Me.txtMargenPrevMat = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtMargenPrevMod = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtMargenPrevCentro = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtMargenPrevGastos = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtMargenPrevVarios = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblMaterialesA = New Solmicro.Expertis.Engine.UI.Label
        Me.txtImpPrevQMatA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.Linea = New Janus.Windows.EditControls.UIGroupBox
        Me.lblVariosA = New Solmicro.Expertis.Engine.UI.Label
        Me.txtImpPrevQVariosA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblGastosA = New Solmicro.Expertis.Engine.UI.Label
        Me.txtImpPrevQGastosA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblCentrosA = New Solmicro.Expertis.Engine.UI.Label
        Me.txtImpPrevQCentrosA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblModA = New Solmicro.Expertis.Engine.UI.Label
        Me.txtImpPrevQModA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblCostePrev = New Solmicro.Expertis.Engine.UI.Label
        Me.txtMargenTrabajoPrev = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblTotalTrabajosA = New Solmicro.Expertis.Engine.UI.Label
        Me.txtImpPrevQTrabajoA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtMargenRealTrabajo = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImpVencimientoA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblVencimientosA = New Solmicro.Expertis.Engine.UI.Label
        Me.txtVencimientosA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.FraTotalesObra = New Solmicro.Expertis.Engine.UI.Frame
        Me.txtMargenReal = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtMargenPrev = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImpFactA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImpRealA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImpPrevVentaA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblTotalObrasA = New Solmicro.Expertis.Engine.UI.Label
        Me.txtImpPrevA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.FraCondEconom = New Solmicro.Expertis.Engine.UI.Frame
        Me.chkSeguroCambio = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.txtCambioB = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblCambioB = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDMoneda = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblCentroGestion = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxCentroGestion = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.ulDescMoneda = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.txtCambioA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblCambioA = New Solmicro.Expertis.Engine.UI.Label
        Me.lblTipoIVA = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDTipoIVA = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblDiaPago = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDDiaPago = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblCondicionPago = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDCondicionPago = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblFormaPago = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDFormaPago = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblMoneda = New Solmicro.Expertis.Engine.UI.Label
        Me.pnlCliente = New System.Windows.Forms.Panel
        Me.lblClaseObra = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxIDClase = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.FraClientes = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblPoblacion = New Solmicro.Expertis.Engine.UI.Label
        Me.txtPoblacion = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblCodPostal = New Solmicro.Expertis.Engine.UI.Label
        Me.txtCodPostal = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblProvincia = New Solmicro.Expertis.Engine.UI.Label
        Me.txtProvincia = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblDireccion = New Solmicro.Expertis.Engine.UI.Label
        Me.txtDireccion = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblCliente = New Solmicro.Expertis.Engine.UI.Label
        Me.ulDescCliente = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.AdvIDCliente = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.FraFechas = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblFechaInicio = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaInicio = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaFin = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaFin = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblTipoObra = New Solmicro.Expertis.Engine.UI.Label
        Me.ulDescTipoObra = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.AdvIDTipoObra = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.TabPageTrabajos = New Janus.Windows.UI.Tab.UITabPage
        Me.TabTrabajos = New Solmicro.Expertis.Engine.UI.Tab
        Me.TabPageDetalleTrabajos = New Janus.Windows.UI.Tab.UITabPage
        Me.pnlFichaTrabajo = New Solmicro.Expertis.Engine.UI.Panel
        Me.pnlFichaTrabajoFill = New Solmicro.Expertis.Engine.UI.Panel
        Me.txtTextoTrabajo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblTextoTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.FraImportesTrabajoFicha = New Solmicro.Expertis.Engine.UI.Frame
        Me.txtFacturadoTrabajo = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtRealTrabajo = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtPrevistoVentaTrabajo = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtPrevistoTrabajo = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblPrevTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.lblPrevVentaTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.lblRealTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFactTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.pnlFichaTrabajoTop = New Solmicro.Expertis.Engine.UI.Panel
        Me.FraPeriodificacion = New Solmicro.Expertis.Engine.UI.Frame
        Me.ntxPorcIncrDecrPerido = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblPorcIncrDecrPerido = New Solmicro.Expertis.Engine.UI.Label
        Me.chkAplicarSobreUltimo = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.cbxTipoPeriodoPeriodificacion = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.chkPeriodificable = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.lblPeridoPeriodificacion = New Solmicro.Expertis.Engine.UI.Label
        Me.lblTipoPeriodoPeriodificacion = New Solmicro.Expertis.Engine.UI.Label
        Me.ntxPeriodoPeriodificacion = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblQUnitaria = New Solmicro.Expertis.Engine.UI.Label
        Me.ntxQUnidad = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.chkPlanificarRecursosPorTareas = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.lblEstadoTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxEstadoTrabajo = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.Label7 = New Solmicro.Expertis.Engine.UI.Label
        Me.txtMargenTrabajoFicha = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.chkNoAcumular = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.AdvSubSubTipoTrabajo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblSubSubTipoTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxTipoLinea = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblQReal = New Solmicro.Expertis.Engine.UI.Label
        Me.txtQReal = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblQPrevResponsable = New Solmicro.Expertis.Engine.UI.Label
        Me.txtQPrevResponsable = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxTipoCoste = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.AdvSubTipoTrabajo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.AdvTipoTrabajo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblTipoLinea = New Solmicro.Expertis.Engine.UI.Label
        Me.FraSeguimiento = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblIncremento = New Solmicro.Expertis.Engine.UI.Label
        Me.txtIncremento = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblTrabajoPresup = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvTrabajoPresup = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.txtDuracionPrev = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtNivelTrabajo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblNivelTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.FraFechasTrabajo = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblFechaFinTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaFinTrabajo = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaInicioTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaInicioTrabajo = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblCentroGestionTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxIDCentroGestion = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblNumPedido = New Solmicro.Expertis.Engine.UI.Label
        Me.txtNumPedido = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblSolapeAnt = New Solmicro.Expertis.Engine.UI.Label
        Me.txtSolapeAnt = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblSecuencia = New Solmicro.Expertis.Engine.UI.Label
        Me.txtSecuencia = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblDuracionPrev = New Solmicro.Expertis.Engine.UI.Label
        Me.FraAvance = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblAvanceCalculado = New Solmicro.Expertis.Engine.UI.Label
        Me.txtAvanceCalculado = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblAvanceEstimado = New Solmicro.Expertis.Engine.UI.Label
        Me.txtAvanceEstimado = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblIDArticulo = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDArticulo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblQCertificada = New Solmicro.Expertis.Engine.UI.Label
        Me.txtQCertificada = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.chkFacturable = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.lblTipoFacturacion = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxTipoFacturacion = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblUDMedida = New Solmicro.Expertis.Engine.UI.Label
        Me.lblQPrev = New Solmicro.Expertis.Engine.UI.Label
        Me.lblCodTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxIDUDMedida = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblImpUnitarioVta = New Solmicro.Expertis.Engine.UI.Label
        Me.txtImpUnitarioVta = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblImpUnitario = New Solmicro.Expertis.Engine.UI.Label
        Me.txtImpUnitario = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtQPrev = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtDescTrabajo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblTipoTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.lblSubTipoTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.txtCodTrabajo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.pnlTrabajosCompleto = New Solmicro.Expertis.Engine.UI.Panel
        Me.TvwObraCompleta = New System.Windows.Forms.TreeView
        Me.ImageListTrabajoCompleto = New System.Windows.Forms.ImageList(Me.components)
        Me.pnlVerTrabajosCompleto = New Solmicro.Expertis.Engine.UI.Panel
        Me.txtDescTrabajoCompleto = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblTrabajoCompleto = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTrabajoCompleto = New Solmicro.Expertis.Engine.UI.TextBox
        Me.PnlTimeObras = New Solmicro.Expertis.Engine.UI.Panel
        Me.CtrlTimeLineObras1 = New Solmicro.Expertis.Application.ERP.CommonClasses.CtrlTimeLineObras
        Me.pnlGridTrabajo = New Solmicro.Expertis.Engine.UI.Panel
        Me.GridTrabajos = New Solmicro.Expertis.Engine.UI.Grid
        Me.ImageListGrids = New System.Windows.Forms.ImageList(Me.components)
        Me.pnlVerTrabajosGrid = New Solmicro.Expertis.Engine.UI.Panel
        Me.txtDescTrabajoGrid = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblTrabajoGrid = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTrabajoGrid = New Solmicro.Expertis.Engine.UI.TextBox
        Me.pnlConfigVerTrabajos = New Solmicro.Expertis.Engine.UI.Panel
        Me.rbtPorMultinivelTrabajos = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.lblVerTrabajos = New Solmicro.Expertis.Engine.UI.Label
        Me.rbtPorNivelTrabajos = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.rbtPorTrabajosObra = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.FraImportesTrabajoGrid = New Solmicro.Expertis.Engine.UI.Frame
        Me.txtFacturadoTrabajoGrid = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtRealTrabajoGrid = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtPrevistoVentaTrabajoGrid = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtPrevistoTrabajoGrid = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblPrevTrabajoGrid = New Solmicro.Expertis.Engine.UI.Label
        Me.lblPrevVentaTrabajoGrid = New Solmicro.Expertis.Engine.UI.Label
        Me.lblRealTrabajoGrid = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFactTrabajoGrid = New Solmicro.Expertis.Engine.UI.Label
        Me.TabPagePrevistos = New Janus.Windows.UI.Tab.UITabPage
        Me.TabPrevistos = New Solmicro.Expertis.Engine.UI.Tab
        Me.TabPageMaterialesPrev = New Janus.Windows.UI.Tab.UITabPage
        Me.GridMaterialPrev = New Solmicro.Expertis.Engine.UI.Grid
        Me.TabPageModPrev = New Janus.Windows.UI.Tab.UITabPage
        Me.GridMODPrev = New Solmicro.Expertis.Engine.UI.Grid
        Me.TabPageCentrosPrev = New Janus.Windows.UI.Tab.UITabPage
        Me.GridCentrosPrev = New Solmicro.Expertis.Engine.UI.Grid
        Me.TabPageGastosPrev = New Janus.Windows.UI.Tab.UITabPage
        Me.GridGastosPrev = New Solmicro.Expertis.Engine.UI.Grid
        Me.TabPageVariosPrev = New Janus.Windows.UI.Tab.UITabPage
        Me.GridVariosPrev = New Solmicro.Expertis.Engine.UI.Grid
        Me.TabPageMediciones = New Janus.Windows.UI.Tab.UITabPage
        Me.GridMediciones = New Solmicro.Expertis.Engine.UI.Grid
        Me.FraImportesMedicionesPrev = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblTotalMedicion = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTotalMedicion = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.pnlVerPrevistos = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblQPrevPrev = New Solmicro.Expertis.Engine.UI.Label
        Me.txtQPrevTrabajo = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtDescTrabajoPrev = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblTrabajoPrev = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTrabajoPrev = New Solmicro.Expertis.Engine.UI.TextBox
        Me.pnlConfigVerPrevistos = New Solmicro.Expertis.Engine.UI.Panel
        Me.rbtPorMultinivelPrev = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.lblVerPrevistos = New Solmicro.Expertis.Engine.UI.Label
        Me.rbtPorNivelPrev = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.rbtPrevObra = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.FraTotalesPrev = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblTotalFacturado = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTotalFacturado = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblTotalPrevVenta = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTotalPrevVenta = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblTotalReal = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTotalReal = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblTotalPrev = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTotalPrev = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.TabPageControl = New Janus.Windows.UI.Tab.UITabPage
        Me.TabControl = New Solmicro.Expertis.Engine.UI.Tab
        Me.TabPageMaterialesControl = New Janus.Windows.UI.Tab.UITabPage
        Me.GridMaterialControl = New Solmicro.Expertis.Engine.UI.Grid
        Me.TabPageModControl = New Janus.Windows.UI.Tab.UITabPage
        Me.GridMODControl = New Solmicro.Expertis.Engine.UI.Grid
        Me.TabPageCentrosControl = New Janus.Windows.UI.Tab.UITabPage
        Me.GridCentroControl = New Solmicro.Expertis.Engine.UI.Grid
        Me.TabPageGastosControl = New Janus.Windows.UI.Tab.UITabPage
        Me.GridGastosControl = New Solmicro.Expertis.Engine.UI.Grid
        Me.TabPageVariosControl = New Janus.Windows.UI.Tab.UITabPage
        Me.GridVariosControl = New Solmicro.Expertis.Engine.UI.Grid
        Me.TabPageControlMediciones = New Janus.Windows.UI.Tab.UITabPage
        Me.pnlCertificacionTrabajo = New Solmicro.Expertis.Engine.UI.Panel
        Me.GridCertificacionTrabajo = New Solmicro.Expertis.Engine.UI.Grid
        Me.pnlLabelCertificacionTrabajo = New Solmicro.Expertis.Engine.UI.Panel
        Me.optCertificacionPorCapitulos = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.optCertificacionPorTrabajo = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.lblVerCertificacionPor = New Solmicro.Expertis.Engine.UI.Label
        Me.lblCertificacionTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.GridCertificacionMedicion = New Solmicro.Expertis.Engine.UI.Grid
        Me.Splitter2 = New System.Windows.Forms.Splitter
        Me.pnlCertificacion = New Solmicro.Expertis.Engine.UI.Panel
        Me.GridCertificacion = New Solmicro.Expertis.Engine.UI.Grid
        Me.TabTiposCertificacion = New Solmicro.Expertis.Engine.UI.Tab
        Me.UiTabCliente = New Janus.Windows.UI.Tab.UITabPage
        Me.UiTabProduccion = New Janus.Windows.UI.Tab.UITabPage
        Me.UiTabClienteProduccion = New Janus.Windows.UI.Tab.UITabPage
        Me.pnlLabelObraCertificacion = New Solmicro.Expertis.Engine.UI.Panel
        Me.cbxTipoCertificacion = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.pnlVerCertificacion = New Solmicro.Expertis.Engine.UI.Panel
        Me.chkVerUltimaCertificacion = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.lblNumCertificacion = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvSearchCertificacion = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblCertificacion = New Solmicro.Expertis.Engine.UI.Label
        Me.pnlVerControl = New Solmicro.Expertis.Engine.UI.Panel
        Me.txtDescTrabajoControl = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblTrabajoControl = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTrabajoControl = New Solmicro.Expertis.Engine.UI.TextBox
        Me.pnlConfigVerControl = New Solmicro.Expertis.Engine.UI.Panel
        Me.rbtMultinivelControl = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.lblVerControl = New Solmicro.Expertis.Engine.UI.Label
        Me.rbtNivelControl = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.rbtControlObra = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.FraTotalesReal = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblTotalControl = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTotalControl = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.TabPageHitos = New Janus.Windows.UI.Tab.UITabPage
        Me.GridVencimientos = New Solmicro.Expertis.Engine.UI.Grid
        Me.pnlVerHitos = New Solmicro.Expertis.Engine.UI.Panel
        Me.txtDescTrabajoHitos = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblTrabajoHitos = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTrabajoHitos = New Solmicro.Expertis.Engine.UI.TextBox
        Me.pnlTotalesHitos = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblTotalVtoA = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTotalVtoA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblTotalA = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTotalA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.pnlConfigTipoMonedaHitos = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblGestionMonedaHitos = New Solmicro.Expertis.Engine.UI.Label
        Me.rbtMonedaA = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.rbtMonedaCliente = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.pnlConfigVerHitos = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblVerHitos = New Solmicro.Expertis.Engine.UI.Label
        Me.rbtHitosTrabajo = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.rbtHitosObra = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.TabPageTareas = New Janus.Windows.UI.Tab.UITabPage
        Me.GridTareas = New Solmicro.Expertis.Engine.UI.Grid
        Me.pnlVerTareas = New Solmicro.Expertis.Engine.UI.Panel
        Me.txtDescTrabajoTareas = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblTrabajoTareas = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTrabajoTareas = New Solmicro.Expertis.Engine.UI.TextBox
        Me.pnlConfigVerTareas = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblVerTareas = New Solmicro.Expertis.Engine.UI.Label
        Me.rbtTareasTrabajo = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.rbtTareasObra = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.TabPageOficios = New Janus.Windows.UI.Tab.UITabPage
        Me.GridOperariosTrabajo = New Solmicro.Expertis.Engine.UI.Grid
        Me.pnlVerOperarios = New Solmicro.Expertis.Engine.UI.Panel
        Me.txtDescTrabajoOperarios = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblTrabajoOperarios = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTrabajoOperarios = New Solmicro.Expertis.Engine.UI.TextBox
        Me.pnlConfigVerOperarios = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblVerOperarios = New Solmicro.Expertis.Engine.UI.Label
        Me.rbtOperariosTrabajo = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.rbtOperariosObra = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.TabPageAvance = New Janus.Windows.UI.Tab.UITabPage
        Me.GridAvanceTrabajo = New Solmicro.Expertis.Engine.UI.Grid
        Me.ImageListAvance = New System.Windows.Forms.ImageList(Me.components)
        Me.pnlLeyendaAvance = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblPeriodosRecalculados = New Solmicro.Expertis.Engine.UI.Label
        Me.pnlPeriodosRecalculados = New System.Windows.Forms.Panel
        Me.pnlVerAvance = New Solmicro.Expertis.Engine.UI.Panel
        Me.Label3 = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaFinTrabajoAvance = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.Label4 = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaInicioTrabajoAvance = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.txtDescTrabajoAvance = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblTrabajoAvance = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTrabajoAvance = New Solmicro.Expertis.Engine.UI.TextBox
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.pnlTrabajos = New Solmicro.Expertis.Engine.UI.Panel
        Me.TvwTrabajos = New System.Windows.Forms.TreeView
        Me.FraArbol = New Solmicro.Expertis.Engine.UI.Frame
        Me.chkVerPorcentajes = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.rbtMinimizarTree = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.rbtMaximizarTree = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.lblEstadoDistintoDE = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxEstadoDistintoDE = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.FraCriterios = New Solmicro.Expertis.Engine.UI.Frame
        Me.RdTimeObras = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.rbtVerProyectoCompleto = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.rbtVerGrid = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.rbtVerFicha = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.TabPageCaracteristicas = New Janus.Windows.UI.Tab.UITabPage
        Me.GridCaracteristicas = New Solmicro.Expertis.Engine.UI.Grid
        Me.TabPageRecursos = New Janus.Windows.UI.Tab.UITabPage
        Me.GridRecursos = New Solmicro.Expertis.Engine.UI.Grid
        Me.TabPageSeguimiento = New Janus.Windows.UI.Tab.UITabPage
        Me.pnlObservaciones = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblTexto = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTexto = New Solmicro.Expertis.Engine.UI.TextBox
        Me.fra = New Solmicro.Expertis.Engine.UI.Frame
        Me.txtTotalBeneficioIndustrial = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtTotalCoefBaja = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtTotalGastosGenerales = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.UiGroupBox3 = New Janus.Windows.EditControls.UIGroupBox
        Me.lblImporteIva = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTotalIva = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblTOTALObraVenta = New Solmicro.Expertis.Engine.UI.Label
        Me.txtImpPrevVentaABis = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblTotal = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTotal = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblBeneficioIndustrial = New Solmicro.Expertis.Engine.UI.Label
        Me.txtBeneficioIndustrial = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblCoefBaja = New Solmicro.Expertis.Engine.UI.Label
        Me.txtCoefBaja = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblGastosGenerales = New Solmicro.Expertis.Engine.UI.Label
        Me.txtGastosGenerales = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.ntbDiaFacturacion = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblDiaFacturacion = New Solmicro.Expertis.Engine.UI.Label
        Me.FraRetencion = New Solmicro.Expertis.Engine.UI.Frame
        Me.txtPeriodo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.cbxTipoPeriodo = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblPeriodo = New Solmicro.Expertis.Engine.UI.Label
        Me.cboTipoRetencionImpuestos = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblFechaRetencion = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaRetencion = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblRetencion = New Solmicro.Expertis.Engine.UI.Label
        Me.txtRetencion = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblTipoRetencion = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxTipoRetencion = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblGridCostes = New Solmicro.Expertis.Engine.UI.Label
        Me.GridCostes = New Solmicro.Expertis.Engine.UI.Grid
        Me.lblNivel = New Solmicro.Expertis.Engine.UI.Label
        Me.txtNivel = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblObraPadre = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDObraPadre = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblNumeroPedido = New Solmicro.Expertis.Engine.UI.Label
        Me.txtNumeroPedido = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblFechaObra = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaObra = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblURLContrato = New Solmicro.Expertis.Engine.UI.Label
        Me.txtURLContrato = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblNumPresup = New Solmicro.Expertis.Engine.UI.Label
        Me.txtNumPresup = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtRevPresup = New Solmicro.Expertis.Engine.UI.TextBox
        Me.CmbUrlContrato = New Solmicro.Expertis.Engine.UI.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.LblBarra = New Solmicro.Expertis.Engine.UI.Label
        Me.FraDireccion = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblDireccionObra = New Solmicro.Expertis.Engine.UI.Label
        Me.txtDireccionObra = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblProvinciaObra = New Solmicro.Expertis.Engine.UI.Label
        Me.txtProvinciaObra = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblCodPostalObra = New Solmicro.Expertis.Engine.UI.Label
        Me.txtCodPostalObra = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblPoblacionObra = New Solmicro.Expertis.Engine.UI.Label
        Me.txtPoblacionObra = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtIdDireccion = New Solmicro.Expertis.Engine.UI.TextBox
        Me.TabPageEstructura = New Janus.Windows.UI.Tab.UITabPage
        Me.tvwEstructura = New System.Windows.Forms.TreeView
        Me.pnlTopEstructura = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmbObraPadre = New Solmicro.Expertis.Engine.UI.Button
        Me.lblNivel2 = New Solmicro.Expertis.Engine.UI.Label
        Me.lblObraPadre2 = New Solmicro.Expertis.Engine.UI.Label
        Me.txtNivelObra = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtCodTrabajoPadre = New Solmicro.Expertis.Engine.UI.TextBox
        Me.chkVerTrabajos = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.FraTotalSeleccionObra = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblTotalFacturadoTree = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTotalFacturadoTree = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblTotalRealTree = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTotalRealTree = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblTotalPrevVentaTree = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTotalPrevVentaTree = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblTotalPrevTree = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTotalPrevTree = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.FraTotalObraPadreEstructura = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblTotalPrevEstructura = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTotalEstructuraPrev = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblTotalPrevEstructuraReal = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTotalEstructuraReal = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblTotalPrevEstructuraVta = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTotalEstructuraPrevVta = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblTotalPrevEstructuraFacturado = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTotalEstructuraFact = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.TabPageCoste = New Janus.Windows.UI.Tab.UITabPage
        Me.tvwCostes = New System.Windows.Forms.TreeView
        Me.Frame1 = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblTotalObraHijaFacturado = New Solmicro.Expertis.Engine.UI.Label
        Me.txtCosteFacturado = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblTotalObraHijaReal = New Solmicro.Expertis.Engine.UI.Label
        Me.txtCosteReal = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblTotalObraHijaPresupVta = New Solmicro.Expertis.Engine.UI.Label
        Me.txtCostePrevVenta = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblTotalObraHijaPresup = New Solmicro.Expertis.Engine.UI.Label
        Me.txtCostePrev = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.FraTotalObraPadre = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblFwTotalObraPresup = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTotalCostePrev = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblTotalObraReal = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTotalCosteReal = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblTotalObraPresupVta = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTotalCostePrevVta = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblTotalObraFacturado = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTotalCosteFact = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.TabPageProveedor = New Janus.Windows.UI.Tab.UITabPage
        Me.GridProveedores = New Solmicro.Expertis.Engine.UI.Grid
        Me.TabPageCobrosPagos = New Janus.Windows.UI.Tab.UITabPage
        Me.TabCobrosPagos = New Solmicro.Expertis.Engine.UI.Tab
        Me.UiTabPage1 = New Janus.Windows.UI.Tab.UITabPage
        Me.GridTramos = New Solmicro.Expertis.Engine.UI.Grid
        Me.Splitter3 = New System.Windows.Forms.Splitter
        Me.TvwCobrosPagos = New System.Windows.Forms.TreeView
        Me.UiTabPage2 = New Janus.Windows.UI.Tab.UITabPage
        Me.GridPlanningCobros = New Solmicro.Expertis.Engine.UI.Grid
        Me.UiTabPage3 = New Janus.Windows.UI.Tab.UITabPage
        Me.GridPlanningPagos = New Solmicro.Expertis.Engine.UI.Grid
        Me.OpenDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.MenuObras = New Janus.Windows.UI.CommandBars.UIContextMenu
        Me.MnuNuevoTrabajo2 = New Janus.Windows.UI.CommandBars.UICommand("MnuNuevoTrabajo")
        Me.MnuNuevoTrabajoIncremento2 = New Janus.Windows.UI.CommandBars.UICommand("MnuNuevoTrabajoIncremento")
        Me.MnuGuion = New Janus.Windows.UI.CommandBars.UICommand("MnuGuion")
        Me.MnuGeneraVtos2 = New Janus.Windows.UI.CommandBars.UICommand("MnuGeneraVtos")
        Me.MnuPeriodificaciones1 = New Janus.Windows.UI.CommandBars.UICommand("MnuPeriodificaciones")
        Me.Separator6 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.MnuDeleteTrabajo2 = New Janus.Windows.UI.CommandBars.UICommand("MnuDeleteTrabajo")
        Me.MnuDeleteIncremento2 = New Janus.Windows.UI.CommandBars.UICommand("MnuDeleteIncremento")
        Me.MnuGuion1 = New Janus.Windows.UI.CommandBars.UICommand("MnuGuion1")
        Me.MnuADDIncremento2 = New Janus.Windows.UI.CommandBars.UICommand("MnuADDIncremento")
        Me.MnuGuion3 = New Janus.Windows.UI.CommandBars.UICommand("MnuGuion3")
        Me.MnuNuevoConcepto1 = New Janus.Windows.UI.CommandBars.UICommand("MnuNuevoConcepto")
        Me.MnuGuion4 = New Janus.Windows.UI.CommandBars.UICommand("MnuGuion4")
        Me.MnuDesgloseTrabajo2 = New Janus.Windows.UI.CommandBars.UICommand("MnuDesgloseTrabajo")
        Me.MnuVerFichaTrabajo2 = New Janus.Windows.UI.CommandBars.UICommand("MnuVerFichaTrabajo")
        Me.MnuGuion5 = New Janus.Windows.UI.CommandBars.UICommand("MnuGuion5")
        Me.mnuNuevaTarea2 = New Janus.Windows.UI.CommandBars.UICommand("mnuNuevaTarea")
        Me.MnuTareasPred2 = New Janus.Windows.UI.CommandBars.UICommand("MnuTareasPred")
        Me.MnuGuion2 = New Janus.Windows.UI.CommandBars.UICommand("MnuGuion2")
        Me.MnuAnalitica1 = New Janus.Windows.UI.CommandBars.UICommand("MnuAnalitica")
        Me.MnuGuion6 = New Janus.Windows.UI.CommandBars.UICommand("MnuGuion6")
        Me.mnuGenerarCompras2 = New Janus.Windows.UI.CommandBars.UICommand("mnuGenerarCompras")
        Me.mnuExpedir2 = New Janus.Windows.UI.CommandBars.UICommand("mnuExpedir")
        Me.mnuFacturacion2 = New Janus.Windows.UI.CommandBars.UICommand("mnuFacturacion")
        Me.MnuGuion7 = New Janus.Windows.UI.CommandBars.UICommand("MnuGuion7")
        Me.mnuPlanificador1 = New Janus.Windows.UI.CommandBars.UICommand("mnuPlanificador")
        Me.MnuGuion8 = New Janus.Windows.UI.CommandBars.UICommand("MnuGuion8")
        Me.mnuAvanceTrabajo1 = New Janus.Windows.UI.CommandBars.UICommand("mnuAvanceTrabajo")
        Me.MnuGuion9 = New Janus.Windows.UI.CommandBars.UICommand("MnuGuion9")
        Me.mnuAltaDocumentos1 = New Janus.Windows.UI.CommandBars.UICommand("mnuAltaDocumentos")
        Me.mnuVincularDocumentos1 = New Janus.Windows.UI.CommandBars.UICommand("mnuVincularDocumentos")
        Me.mnuDocumentosRel1 = New Janus.Windows.UI.CommandBars.UICommand("mnuDocumentosRel")
        Me.MnuNuevoTrabajo = New Janus.Windows.UI.CommandBars.UICommand("MnuNuevoTrabajo")
        Me.MnuNuevoTrabajoIncremento = New Janus.Windows.UI.CommandBars.UICommand("MnuNuevoTrabajoIncremento")
        Me.MnuGeneraVtos = New Janus.Windows.UI.CommandBars.UICommand("MnuGeneraVtos")
        Me.mnuNuevaTarea = New Janus.Windows.UI.CommandBars.UICommand("mnuNuevaTarea")
        Me.MnuDeleteTrabajo = New Janus.Windows.UI.CommandBars.UICommand("MnuDeleteTrabajo")
        Me.MnuDeleteIncremento = New Janus.Windows.UI.CommandBars.UICommand("MnuDeleteIncremento")
        Me.MnuAnalitica = New Janus.Windows.UI.CommandBars.UICommand("MnuAnalitica")
        Me.MnuADDIncremento = New Janus.Windows.UI.CommandBars.UICommand("MnuADDIncremento")
        Me.MnuNuevoConcepto = New Janus.Windows.UI.CommandBars.UICommand("MnuNuevoConcepto")
        Me.MnuDesgloseTrabajo = New Janus.Windows.UI.CommandBars.UICommand("MnuDesgloseTrabajo")
        Me.MnuVerFichaTrabajo = New Janus.Windows.UI.CommandBars.UICommand("MnuVerFichaTrabajo")
        Me.MnuTareasPred = New Janus.Windows.UI.CommandBars.UICommand("MnuTareasPred")
        Me.mnuGenerarCompras = New Janus.Windows.UI.CommandBars.UICommand("mnuGenerarCompras")
        Me.mnuExpedir = New Janus.Windows.UI.CommandBars.UICommand("mnuExpedir")
        Me.mnuFacturacion = New Janus.Windows.UI.CommandBars.UICommand("mnuFacturacion")
        Me.MnuVerObras = New Janus.Windows.UI.CommandBars.UICommand("MnuVerObras")
        Me.MenuEstructura = New Janus.Windows.UI.CommandBars.UIContextMenu
        Me.MnuVerObras1 = New Janus.Windows.UI.CommandBars.UICommand("MnuVerObras")
        Me.mnuPlanificador = New Janus.Windows.UI.CommandBars.UICommand("mnuPlanificador")
        Me.mnuAvanceTrabajo = New Janus.Windows.UI.CommandBars.UICommand("mnuAvanceTrabajo")
        Me.mnuADDPeriodosAvance1 = New Janus.Windows.UI.CommandBars.UICommand("mnuADDPeriodosAvance")
        Me.mnuActualizarAvanceReal1 = New Janus.Windows.UI.CommandBars.UICommand("mnuActualizarAvanceReal")
        Me.mnuRehacerPeriodos1 = New Janus.Windows.UI.CommandBars.UICommand("mnuRehacerPeriodos")
        Me.Separator5 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.mnuVerDesviaciones1 = New Janus.Windows.UI.CommandBars.UICommand("mnuVerDesviaciones")
        Me.mnuADDPeriodosAvance = New Janus.Windows.UI.CommandBars.UICommand("mnuADDPeriodosAvance")
        Me.mnuActualizarAvanceReal = New Janus.Windows.UI.CommandBars.UICommand("mnuActualizarAvanceReal")
        Me.mnuRehacerPeriodos = New Janus.Windows.UI.CommandBars.UICommand("mnuRehacerPeriodos")
        Me.mnuVerDesviaciones = New Janus.Windows.UI.CommandBars.UICommand("mnuVerDesviaciones")
        Me.mnuAltaDocumentos = New Janus.Windows.UI.CommandBars.UICommand("mnuAltaDocumentos")
        Me.mnuVincularDocumentos = New Janus.Windows.UI.CommandBars.UICommand("mnuVincularDocumentos")
        Me.mnuDocumentosRel = New Janus.Windows.UI.CommandBars.UICommand("mnuDocumentosRel")
        Me.mnuArbolTrabajos = New Janus.Windows.UI.CommandBars.UICommand("mnuArbolTrabajos")
        Me.mnuArbolTrabajos1 = New Janus.Windows.UI.CommandBars.UICommand("mnuArbolTrabajos")
        Me.MnuGeneraVtosPeriodificados = New Janus.Windows.UI.CommandBars.UICommand("MnuGeneraVtosPeriodificados")
        Me.MnuGenerarTrabajosPeriodificados = New Janus.Windows.UI.CommandBars.UICommand("MnuGenerarTrabajosPeriodificados")
        Me.MnuPeriodificaciones = New Janus.Windows.UI.CommandBars.UICommand("MnuPeriodificaciones")
        Me.MnuGenerarTrabajosPeriodificados1 = New Janus.Windows.UI.CommandBars.UICommand("MnuGenerarTrabajosPeriodificados")
        Me.MnuGeneraVtosPeriodificados1 = New Janus.Windows.UI.CommandBars.UICommand("MnuGeneraVtosPeriodificados")
        CType(Me.ToolBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.suspendlayout()
        Me.PnlCabecera.SuspendLayout()
        CType(Me.cbxEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabObras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabObras.SuspendLayout()
        Me.TabPageCabeceraObra.SuspendLayout()
        Me.FraImportes.SuspendLayout()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Linea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FraTotalesObra.SuspendLayout()
        Me.FraCondEconom.SuspendLayout()
        CType(Me.cbxCentroGestion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCliente.SuspendLayout()
        CType(Me.cbxIDClase, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FraClientes.SuspendLayout()
        Me.FraFechas.SuspendLayout()
        Me.TabPageTrabajos.SuspendLayout()
        CType(Me.TabTrabajos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabTrabajos.SuspendLayout()
        Me.TabPageDetalleTrabajos.SuspendLayout()
        Me.pnlFichaTrabajo.suspendlayout()
        Me.pnlFichaTrabajoFill.suspendlayout()
        Me.FraImportesTrabajoFicha.SuspendLayout()
        Me.pnlFichaTrabajoTop.suspendlayout()
        Me.FraPeriodificacion.SuspendLayout()
        CType(Me.cbxTipoPeriodoPeriodificacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxEstadoTrabajo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxTipoLinea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxTipoCoste, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FraSeguimiento.SuspendLayout()
        Me.FraFechasTrabajo.SuspendLayout()
        CType(Me.cbxIDCentroGestion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FraAvance.SuspendLayout()
        CType(Me.cbxTipoFacturacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxIDUDMedida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTrabajosCompleto.suspendlayout()
        Me.pnlVerTrabajosCompleto.suspendlayout()
        Me.PnlTimeObras.suspendlayout()
        Me.pnlGridTrabajo.suspendlayout()
        CType(Me.GridTrabajos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlVerTrabajosGrid.suspendlayout()
        Me.pnlConfigVerTrabajos.suspendlayout()
        Me.FraImportesTrabajoGrid.SuspendLayout()
        Me.TabPagePrevistos.SuspendLayout()
        CType(Me.TabPrevistos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPrevistos.SuspendLayout()
        Me.TabPageMaterialesPrev.SuspendLayout()
        CType(Me.GridMaterialPrev, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageModPrev.SuspendLayout()
        CType(Me.GridMODPrev, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageCentrosPrev.SuspendLayout()
        CType(Me.GridCentrosPrev, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageGastosPrev.SuspendLayout()
        CType(Me.GridGastosPrev, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageVariosPrev.SuspendLayout()
        CType(Me.GridVariosPrev, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageMediciones.SuspendLayout()
        CType(Me.GridMediciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FraImportesMedicionesPrev.SuspendLayout()
        Me.pnlVerPrevistos.suspendlayout()
        Me.pnlConfigVerPrevistos.suspendlayout()
        Me.FraTotalesPrev.SuspendLayout()
        Me.TabPageControl.SuspendLayout()
        CType(Me.TabControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl.SuspendLayout()
        Me.TabPageMaterialesControl.SuspendLayout()
        CType(Me.GridMaterialControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageModControl.SuspendLayout()
        CType(Me.GridMODControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageCentrosControl.SuspendLayout()
        CType(Me.GridCentroControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageGastosControl.SuspendLayout()
        CType(Me.GridGastosControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageVariosControl.SuspendLayout()
        CType(Me.GridVariosControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageControlMediciones.SuspendLayout()
        Me.pnlCertificacionTrabajo.suspendlayout()
        CType(Me.GridCertificacionTrabajo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLabelCertificacionTrabajo.suspendlayout()
        CType(Me.GridCertificacionMedicion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCertificacion.suspendlayout()
        CType(Me.GridCertificacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabTiposCertificacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabTiposCertificacion.SuspendLayout()
        Me.pnlLabelObraCertificacion.suspendlayout()
        CType(Me.cbxTipoCertificacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlVerCertificacion.suspendlayout()
        Me.pnlVerControl.suspendlayout()
        Me.pnlConfigVerControl.suspendlayout()
        Me.FraTotalesReal.SuspendLayout()
        Me.TabPageHitos.SuspendLayout()
        CType(Me.GridVencimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlVerHitos.suspendlayout()
        Me.pnlTotalesHitos.suspendlayout()
        Me.pnlConfigTipoMonedaHitos.suspendlayout()
        Me.pnlConfigVerHitos.suspendlayout()
        Me.TabPageTareas.SuspendLayout()
        CType(Me.GridTareas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlVerTareas.suspendlayout()
        Me.pnlConfigVerTareas.suspendlayout()
        Me.TabPageOficios.SuspendLayout()
        CType(Me.GridOperariosTrabajo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlVerOperarios.suspendlayout()
        Me.pnlConfigVerOperarios.suspendlayout()
        Me.TabPageAvance.SuspendLayout()
        CType(Me.GridAvanceTrabajo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLeyendaAvance.suspendlayout()
        Me.pnlVerAvance.suspendlayout()
        Me.pnlTrabajos.suspendlayout()
        Me.FraArbol.SuspendLayout()
        CType(Me.cbxEstadoDistintoDE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FraCriterios.SuspendLayout()
        Me.TabPageCaracteristicas.SuspendLayout()
        CType(Me.GridCaracteristicas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageRecursos.SuspendLayout()
        CType(Me.GridRecursos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageSeguimiento.SuspendLayout()
        Me.pnlObservaciones.suspendlayout()
        Me.fra.SuspendLayout()
        CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.suspendlayout()
        Me.FraRetencion.SuspendLayout()
        CType(Me.cbxTipoPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoRetencionImpuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxTipoRetencion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridCostes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FraDireccion.SuspendLayout()
        Me.TabPageEstructura.SuspendLayout()
        Me.pnlTopEstructura.suspendlayout()
        Me.FraTotalSeleccionObra.SuspendLayout()
        Me.FraTotalObraPadreEstructura.SuspendLayout()
        Me.TabPageCoste.SuspendLayout()
        Me.Frame1.SuspendLayout()
        Me.FraTotalObraPadre.SuspendLayout()
        Me.TabPageProveedor.SuspendLayout()
        CType(Me.GridProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageCobrosPagos.SuspendLayout()
        CType(Me.TabCobrosPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabCobrosPagos.SuspendLayout()
        Me.UiTabPage1.SuspendLayout()
        CType(Me.GridTramos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTabPage2.SuspendLayout()
        CType(Me.GridPlanningCobros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTabPage3.SuspendLayout()
        CType(Me.GridPlanningPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuObras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuEstructura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Duplicate
        '
        Me.Duplicate.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'ToolBar
        '
        Me.ToolBar.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.mnuArbolTrabajos1})
        Me.ToolBar.Size = New System.Drawing.Size(747, 39)
        '
        'MenuBar
        '
        Me.MenuBar.Location = New System.Drawing.Point(0, 39)
        Me.MenuBar.Size = New System.Drawing.Size(504, 26)
        '
        'UiCommandManager1
        '
        Me.UiCommandManager1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.MnuNuevoTrabajo, Me.MnuNuevoTrabajoIncremento, Me.MnuGeneraVtos, Me.mnuNuevaTarea, Me.MnuDeleteTrabajo, Me.MnuDeleteIncremento, Me.MnuAnalitica, Me.MnuADDIncremento, Me.MnuNuevoConcepto, Me.MnuDesgloseTrabajo, Me.MnuVerFichaTrabajo, Me.MnuTareasPred, Me.mnuGenerarCompras, Me.mnuExpedir, Me.mnuFacturacion, Me.MnuVerObras, Me.mnuPlanificador, Me.mnuAvanceTrabajo, Me.mnuADDPeriodosAvance, Me.mnuActualizarAvanceReal, Me.mnuRehacerPeriodos, Me.mnuVerDesviaciones, Me.mnuAltaDocumentos, Me.mnuVincularDocumentos, Me.mnuDocumentosRel, Me.mnuArbolTrabajos, Me.MnuGeneraVtosPeriodificados, Me.MnuGenerarTrabajosPeriodificados, Me.MnuPeriodificaciones})
        Me.UiCommandManager1.ContextMenus.AddRange(New Janus.Windows.UI.CommandBars.UIContextMenu() {Me.MenuObras, Me.MenuEstructura})
        '
        'GoFirst
        '
        Me.GoFirst.Icon = CType(resources.GetObject("GoFirst.Icon"), System.Drawing.Icon)
        '
        'GoPrevious
        '
        Me.GoPrevious.Icon = CType(resources.GetObject("GoPrevious.Icon"), System.Drawing.Icon)
        '
        'GoNext
        '
        Me.GoNext.Icon = CType(resources.GetObject("GoNext.Icon"), System.Drawing.Icon)
        '
        'Delete
        '
        Me.Delete.Icon = CType(resources.GetObject("Delete.Icon"), System.Drawing.Icon)
        Me.Delete.Text = ""
        '
        'Ok
        '
        Me.Ok.Icon = CType(resources.GetObject("Ok.Icon"), System.Drawing.Icon)
        Me.Ok.Text = ""
        '
        'Cancel
        '
        Me.Cancel.Icon = CType(resources.GetObject("Cancel.Icon"), System.Drawing.Icon)
        Me.Cancel.Text = ""
        '
        'Print
        '
        Me.Print.Icon = CType(resources.GetObject("Print.Icon"), System.Drawing.Icon)
        Me.Print.Text = ""
        '
        'Search
        '
        Me.Search.Icon = CType(resources.GetObject("Search.Icon"), System.Drawing.Icon)
        Me.Search.Text = ""
        '
        'GoLast
        '
        Me.GoLast.Icon = CType(resources.GetObject("GoLast.Icon"), System.Drawing.Icon)
        '
        'Find
        '
        Me.Find.Icon = CType(resources.GetObject("Find.Icon"), System.Drawing.Icon)
        Me.Find.Text = ""
        '
        'NewRow
        '
        Me.NewRow.Icon = CType(resources.GetObject("NewRow.Icon"), System.Drawing.Icon)
        Me.NewRow.Text = ""
        '
        'Requery
        '
        Me.Requery.Icon = CType(resources.GetObject("Requery.Icon"), System.Drawing.Icon)
        Me.Requery.Text = ""
        '
        'ExecuteActions
        '
        Me.ExecuteActions.Icon = CType(resources.GetObject("ExecuteActions.Icon"), System.Drawing.Icon)
        Me.ExecuteActions.Text = ""
        '
        'MainPanel
        '
        Me.MainPanel.Controls.Add(Me.TabObras)
        Me.MainPanel.Controls.Add(Me.PnlCabecera)
        Me.MainPanel.Size = New System.Drawing.Size(784, 586)
        '
        'PnlCabecera
        '
        Me.PnlCabecera.Controls.Add(Me.lblEstado)
        Me.PnlCabecera.Controls.Add(Me.lblObra)
        Me.PnlCabecera.Controls.Add(Me.cbxEstado)
        Me.PnlCabecera.Controls.Add(Me.txtDescObra)
        Me.PnlCabecera.Controls.Add(Me.txtNObra)
        Me.PnlCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlCabecera.Location = New System.Drawing.Point(0, 0)
        Me.PnlCabecera.Name = "PnlCabecera"
        Me.PnlCabecera.Size = New System.Drawing.Size(784, 32)
        Me.PnlCabecera.TabIndex = 43
        '
        'lblEstado
        '
        Me.lblEstado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEstado.Location = New System.Drawing.Point(593, 9)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(45, 13)
        Me.lblEstado.TabIndex = 5
        Me.lblEstado.Text = "Estado"
        '
        'lblObra
        '
        Me.lblObra.Location = New System.Drawing.Point(7, 9)
        Me.lblObra.Name = "lblObra"
        Me.lblObra.Size = New System.Drawing.Size(75, 13)
        Me.lblObra.TabIndex = 8
        Me.lblObra.Text = "Nº Proyecto"
        '
        'cbxEstado
        '
        Me.cbxEstado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbxEstado.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList
        Me.TryDataBinding(cbxEstado, New System.Windows.Forms.Binding("Value", Me, "Estado", True))
        cbxEstado_DesignTimeLayout.LayoutString = resources.GetString("cbxEstado_DesignTimeLayout.LayoutString")
        Me.cbxEstado.DesignTimeLayout = cbxEstado_DesignTimeLayout
        Me.cbxEstado.DisabledBackColor = System.Drawing.Color.White
        Me.cbxEstado.DisplayMember = "Value"
        Me.cbxEstado.Location = New System.Drawing.Point(643, 5)
        Me.cbxEstado.Name = "cbxEstado"
        Me.cbxEstado.PrimaryDataFields = "Estado"
        Me.cbxEstado.SecondaryDataFields = "Value"
        Me.cbxEstado.SelectedIndex = -1
        Me.cbxEstado.SelectedItem = Nothing
        Me.cbxEstado.Size = New System.Drawing.Size(135, 21)
        Me.cbxEstado.TabIndex = 2
        '
        'txtDescObra
        '
        Me.txtDescObra.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TryDataBinding(txtDescObra, New System.Windows.Forms.Binding("Text", Me, "DescObra", True))
        Me.txtDescObra.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescObra.Location = New System.Drawing.Point(226, 5)
        Me.txtDescObra.Name = "txtDescObra"
        Me.txtDescObra.Size = New System.Drawing.Size(363, 21)
        Me.txtDescObra.TabIndex = 1
        '
        'txtNObra
        '
        Me.TryDataBinding(txtNObra, New System.Windows.Forms.Binding("Text", Me, "NObra", True))
        Me.txtNObra.DisabledBackColor = System.Drawing.Color.White
        Me.txtNObra.Location = New System.Drawing.Point(86, 5)
        Me.txtNObra.Name = "txtNObra"
        Me.txtNObra.Size = New System.Drawing.Size(137, 23)
        Me.txtNObra.TabIndex = 0
        '
        'TabObras
        '
        Me.TabObras.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.TabObras.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabObras.Location = New System.Drawing.Point(0, 32)
        Me.TabObras.Name = "TabObras"
        Me.TabObras.Size = New System.Drawing.Size(784, 554)
        Me.TabObras.TabIndex = 3
        Me.TabObras.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.TabPageCabeceraObra, Me.TabPageTrabajos, Me.TabPageCaracteristicas, Me.TabPageRecursos, Me.TabPageSeguimiento, Me.TabPageEstructura, Me.TabPageCoste, Me.TabPageProveedor, Me.TabPageCobrosPagos})
        Me.TabObras.TabStripOffset = 3
        Me.TabObras.UseThemes = True
        '
        'TabPageCabeceraObra
        '
        Me.TabPageCabeceraObra.Controls.Add(Me.FraImportes)
        Me.TabPageCabeceraObra.Controls.Add(Me.FraTotalesObra)
        Me.TabPageCabeceraObra.Controls.Add(Me.FraCondEconom)
        Me.TabPageCabeceraObra.Controls.Add(Me.pnlCliente)
        Me.TabPageCabeceraObra.Key = "Cabecera"
        Me.TabPageCabeceraObra.Location = New System.Drawing.Point(1, 22)
        Me.TabPageCabeceraObra.Name = "TabPageCabeceraObra"
        Me.TabPageCabeceraObra.Size = New System.Drawing.Size(782, 531)
        Me.TabPageCabeceraObra.TabStop = True
        Me.TabPageCabeceraObra.Text = "Cabecera Proyecto"
        '
        'FraImportes
        '
        Me.FraImportes.Controls.Add(Me.UiGroupBox1)
        Me.FraImportes.Controls.Add(Me.lblCosteIndirecto)
        Me.FraImportes.Controls.Add(Me.txtPrevIndirecto)
        Me.FraImportes.Controls.Add(Me.txtPrevVentaIndirecto)
        Me.FraImportes.Controls.Add(Me.lblCosteDirecto)
        Me.FraImportes.Controls.Add(Me.txtPrevDirecto)
        Me.FraImportes.Controls.Add(Me.txtPrevVentaDirecto)
        Me.FraImportes.Controls.Add(Me.txtMargenRealVarios)
        Me.FraImportes.Controls.Add(Me.txtMargenRealGastos)
        Me.FraImportes.Controls.Add(Me.txtMargenRealCentros)
        Me.FraImportes.Controls.Add(Me.txtMargenRealMod)
        Me.FraImportes.Controls.Add(Me.txtMargenRealMat)
        Me.FraImportes.Controls.Add(Me.lblPorcReal)
        Me.FraImportes.Controls.Add(Me.txtImpFactTrabajoA)
        Me.FraImportes.Controls.Add(Me.lblImpFact)
        Me.FraImportes.Controls.Add(Me.txtImpFactModA)
        Me.FraImportes.Controls.Add(Me.txtImpFactCentrosA)
        Me.FraImportes.Controls.Add(Me.txtImpFactGastosA)
        Me.FraImportes.Controls.Add(Me.txtImpFactVariosA)
        Me.FraImportes.Controls.Add(Me.txtImpFactMatA)
        Me.FraImportes.Controls.Add(Me.txtImpRealMatA)
        Me.FraImportes.Controls.Add(Me.txtImpRealVariosA)
        Me.FraImportes.Controls.Add(Me.txtImpRealGastosA)
        Me.FraImportes.Controls.Add(Me.txtImpRealCentrosA)
        Me.FraImportes.Controls.Add(Me.txtImpRealModA)
        Me.FraImportes.Controls.Add(Me.lblImpReal)
        Me.FraImportes.Controls.Add(Me.txtImpRealTrabajoA)
        Me.FraImportes.Controls.Add(Me.txtImpPrevQTrabajoVentaA)
        Me.FraImportes.Controls.Add(Me.lblImpVentaPrev)
        Me.FraImportes.Controls.Add(Me.txtImpPrevQModVentaA)
        Me.FraImportes.Controls.Add(Me.txtImpPrevQCentrosVentaA)
        Me.FraImportes.Controls.Add(Me.txtImpPrevQGastosVentaA)
        Me.FraImportes.Controls.Add(Me.txtImpPrevQVariosVentaA)
        Me.FraImportes.Controls.Add(Me.txtImpPrevQMatVentaA)
        Me.FraImportes.Controls.Add(Me.lblPorcPrev)
        Me.FraImportes.Controls.Add(Me.txtMargenPrevMat)
        Me.FraImportes.Controls.Add(Me.txtMargenPrevMod)
        Me.FraImportes.Controls.Add(Me.txtMargenPrevCentro)
        Me.FraImportes.Controls.Add(Me.txtMargenPrevGastos)
        Me.FraImportes.Controls.Add(Me.txtMargenPrevVarios)
        Me.FraImportes.Controls.Add(Me.lblMaterialesA)
        Me.FraImportes.Controls.Add(Me.txtImpPrevQMatA)
        Me.FraImportes.Controls.Add(Me.Linea)
        Me.FraImportes.Controls.Add(Me.lblVariosA)
        Me.FraImportes.Controls.Add(Me.txtImpPrevQVariosA)
        Me.FraImportes.Controls.Add(Me.lblGastosA)
        Me.FraImportes.Controls.Add(Me.txtImpPrevQGastosA)
        Me.FraImportes.Controls.Add(Me.lblCentrosA)
        Me.FraImportes.Controls.Add(Me.txtImpPrevQCentrosA)
        Me.FraImportes.Controls.Add(Me.lblModA)
        Me.FraImportes.Controls.Add(Me.txtImpPrevQModA)
        Me.FraImportes.Controls.Add(Me.lblCostePrev)
        Me.FraImportes.Controls.Add(Me.txtMargenTrabajoPrev)
        Me.FraImportes.Controls.Add(Me.lblTotalTrabajosA)
        Me.FraImportes.Controls.Add(Me.txtImpPrevQTrabajoA)
        Me.FraImportes.Controls.Add(Me.txtMargenRealTrabajo)
        Me.FraImportes.Controls.Add(Me.txtImpVencimientoA)
        Me.FraImportes.Controls.Add(Me.lblVencimientosA)
        Me.FraImportes.Controls.Add(Me.txtVencimientosA)
        Me.FraImportes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FraImportes.Location = New System.Drawing.Point(0, 223)
        Me.FraImportes.Name = "FraImportes"
        Me.FraImportes.Size = New System.Drawing.Size(782, 273)
        Me.FraImportes.TabIndex = 172
        Me.FraImportes.TabStop = False
        Me.FraImportes.Text = "Importes por Conceptos imputados a trabajos (Importes Totales)"
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Location = New System.Drawing.Point(16, 212)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Size = New System.Drawing.Size(758, 3)
        Me.UiGroupBox1.TabIndex = 154
        '
        'lblCosteIndirecto
        '
        Me.lblCosteIndirecto.Location = New System.Drawing.Point(20, 242)
        Me.lblCosteIndirecto.Name = "lblCosteIndirecto"
        Me.lblCosteIndirecto.Size = New System.Drawing.Size(98, 13)
        Me.lblCosteIndirecto.TabIndex = 153
        Me.lblCosteIndirecto.Text = "TOTAL Indirecto"
        '
        'txtPrevIndirecto
        '
        Me.txtPrevIndirecto.DisabledBackColor = System.Drawing.Color.White
        Me.txtPrevIndirecto.Enabled = False
        Me.txtPrevIndirecto.Location = New System.Drawing.Point(133, 242)
        Me.txtPrevIndirecto.Name = "txtPrevIndirecto"
        Me.txtPrevIndirecto.Size = New System.Drawing.Size(120, 21)
        Me.txtPrevIndirecto.TabIndex = 152
        Me.txtPrevIndirecto.TabStop = False
        '
        'txtPrevVentaIndirecto
        '
        Me.txtPrevVentaIndirecto.DisabledBackColor = System.Drawing.Color.White
        Me.txtPrevVentaIndirecto.Enabled = False
        Me.txtPrevVentaIndirecto.Location = New System.Drawing.Point(327, 242)
        Me.txtPrevVentaIndirecto.Name = "txtPrevVentaIndirecto"
        Me.txtPrevVentaIndirecto.Size = New System.Drawing.Size(120, 21)
        Me.txtPrevVentaIndirecto.TabIndex = 151
        Me.txtPrevVentaIndirecto.TabStop = False
        '
        'lblCosteDirecto
        '
        Me.lblCosteDirecto.Location = New System.Drawing.Point(20, 218)
        Me.lblCosteDirecto.Name = "lblCosteDirecto"
        Me.lblCosteDirecto.Size = New System.Drawing.Size(88, 13)
        Me.lblCosteDirecto.TabIndex = 150
        Me.lblCosteDirecto.Text = "TOTAL Directo"
        '
        'txtPrevDirecto
        '
        Me.txtPrevDirecto.DisabledBackColor = System.Drawing.Color.White
        Me.txtPrevDirecto.Enabled = False
        Me.txtPrevDirecto.Location = New System.Drawing.Point(133, 218)
        Me.txtPrevDirecto.Name = "txtPrevDirecto"
        Me.txtPrevDirecto.Size = New System.Drawing.Size(120, 21)
        Me.txtPrevDirecto.TabIndex = 149
        Me.txtPrevDirecto.TabStop = False
        '
        'txtPrevVentaDirecto
        '
        Me.txtPrevVentaDirecto.DisabledBackColor = System.Drawing.Color.White
        Me.txtPrevVentaDirecto.Enabled = False
        Me.txtPrevVentaDirecto.Location = New System.Drawing.Point(327, 218)
        Me.txtPrevVentaDirecto.Name = "txtPrevVentaDirecto"
        Me.txtPrevVentaDirecto.Size = New System.Drawing.Size(120, 21)
        Me.txtPrevVentaDirecto.TabIndex = 148
        Me.txtPrevVentaDirecto.TabStop = False
        '
        'txtMargenRealVarios
        '
        Me.txtMargenRealVarios.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.txtMargenRealVarios.DisabledBackColor = System.Drawing.Color.White
        Me.txtMargenRealVarios.Enabled = False
        Me.txtMargenRealVarios.Location = New System.Drawing.Point(577, 144)
        Me.txtMargenRealVarios.Name = "txtMargenRealVarios"
        Me.txtMargenRealVarios.Size = New System.Drawing.Size(64, 19)
        Me.txtMargenRealVarios.TabIndex = 133
        Me.txtMargenRealVarios.TabStop = False
        '
        'txtMargenRealGastos
        '
        Me.txtMargenRealGastos.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.txtMargenRealGastos.DisabledBackColor = System.Drawing.Color.White
        Me.txtMargenRealGastos.Enabled = False
        Me.txtMargenRealGastos.Location = New System.Drawing.Point(577, 122)
        Me.txtMargenRealGastos.Name = "txtMargenRealGastos"
        Me.txtMargenRealGastos.Size = New System.Drawing.Size(64, 19)
        Me.txtMargenRealGastos.TabIndex = 132
        '
        'txtMargenRealCentros
        '
        Me.txtMargenRealCentros.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.txtMargenRealCentros.DisabledBackColor = System.Drawing.Color.White
        Me.txtMargenRealCentros.Enabled = False
        Me.txtMargenRealCentros.Location = New System.Drawing.Point(577, 100)
        Me.txtMargenRealCentros.Name = "txtMargenRealCentros"
        Me.txtMargenRealCentros.Size = New System.Drawing.Size(64, 19)
        Me.txtMargenRealCentros.TabIndex = 131
        Me.txtMargenRealCentros.TabStop = False
        '
        'txtMargenRealMod
        '
        Me.txtMargenRealMod.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.txtMargenRealMod.DisabledBackColor = System.Drawing.Color.White
        Me.txtMargenRealMod.Enabled = False
        Me.txtMargenRealMod.Location = New System.Drawing.Point(577, 78)
        Me.txtMargenRealMod.Name = "txtMargenRealMod"
        Me.txtMargenRealMod.Size = New System.Drawing.Size(64, 19)
        Me.txtMargenRealMod.TabIndex = 130
        Me.txtMargenRealMod.TabStop = False
        '
        'txtMargenRealMat
        '
        Me.txtMargenRealMat.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.txtMargenRealMat.DisabledBackColor = System.Drawing.Color.White
        Me.txtMargenRealMat.Enabled = False
        Me.txtMargenRealMat.Location = New System.Drawing.Point(577, 56)
        Me.txtMargenRealMat.Name = "txtMargenRealMat"
        Me.txtMargenRealMat.Size = New System.Drawing.Size(64, 19)
        Me.txtMargenRealMat.TabIndex = 129
        Me.txtMargenRealMat.TabStop = False
        '
        'lblPorcReal
        '
        Me.lblPorcReal.AutoSize = False
        Me.lblPorcReal.Location = New System.Drawing.Point(577, 37)
        Me.lblPorcReal.Name = "lblPorcReal"
        Me.lblPorcReal.Size = New System.Drawing.Size(64, 13)
        Me.lblPorcReal.TabIndex = 134
        Me.lblPorcReal.Text = "% Real"
        Me.lblPorcReal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtImpFactTrabajoA
        '
        Me.txtImpFactTrabajoA.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.txtImpFactTrabajoA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpFactTrabajoA.Enabled = False
        Me.txtImpFactTrabajoA.Location = New System.Drawing.Point(647, 192)
        Me.txtImpFactTrabajoA.Name = "txtImpFactTrabajoA"
        Me.txtImpFactTrabajoA.Size = New System.Drawing.Size(120, 19)
        Me.txtImpFactTrabajoA.TabIndex = 127
        Me.txtImpFactTrabajoA.TabStop = False
        '
        'lblImpFact
        '
        Me.lblImpFact.AutoSize = False
        Me.lblImpFact.Location = New System.Drawing.Point(647, 37)
        Me.lblImpFact.Name = "lblImpFact"
        Me.lblImpFact.Size = New System.Drawing.Size(120, 13)
        Me.lblImpFact.TabIndex = 135
        Me.lblImpFact.Text = "Imp. Facturado"
        Me.lblImpFact.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtImpFactModA
        '
        Me.txtImpFactModA.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.txtImpFactModA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpFactModA.Enabled = False
        Me.txtImpFactModA.Location = New System.Drawing.Point(647, 78)
        Me.txtImpFactModA.Name = "txtImpFactModA"
        Me.txtImpFactModA.Size = New System.Drawing.Size(120, 19)
        Me.txtImpFactModA.TabIndex = 125
        Me.txtImpFactModA.TabStop = False
        '
        'txtImpFactCentrosA
        '
        Me.txtImpFactCentrosA.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.txtImpFactCentrosA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpFactCentrosA.Enabled = False
        Me.txtImpFactCentrosA.Location = New System.Drawing.Point(647, 100)
        Me.txtImpFactCentrosA.Name = "txtImpFactCentrosA"
        Me.txtImpFactCentrosA.Size = New System.Drawing.Size(120, 19)
        Me.txtImpFactCentrosA.TabIndex = 124
        Me.txtImpFactCentrosA.TabStop = False
        '
        'txtImpFactGastosA
        '
        Me.txtImpFactGastosA.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.txtImpFactGastosA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpFactGastosA.Enabled = False
        Me.txtImpFactGastosA.Location = New System.Drawing.Point(647, 122)
        Me.txtImpFactGastosA.Name = "txtImpFactGastosA"
        Me.txtImpFactGastosA.Size = New System.Drawing.Size(120, 19)
        Me.txtImpFactGastosA.TabIndex = 123
        '
        'txtImpFactVariosA
        '
        Me.txtImpFactVariosA.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.txtImpFactVariosA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpFactVariosA.Enabled = False
        Me.txtImpFactVariosA.Location = New System.Drawing.Point(647, 144)
        Me.txtImpFactVariosA.Name = "txtImpFactVariosA"
        Me.txtImpFactVariosA.Size = New System.Drawing.Size(120, 19)
        Me.txtImpFactVariosA.TabIndex = 122
        Me.txtImpFactVariosA.TabStop = False
        '
        'txtImpFactMatA
        '
        Me.txtImpFactMatA.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.txtImpFactMatA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpFactMatA.Enabled = False
        Me.txtImpFactMatA.Location = New System.Drawing.Point(647, 56)
        Me.txtImpFactMatA.Name = "txtImpFactMatA"
        Me.txtImpFactMatA.Size = New System.Drawing.Size(120, 19)
        Me.txtImpFactMatA.TabIndex = 121
        Me.txtImpFactMatA.TabStop = False
        '
        'txtImpRealMatA
        '
        Me.txtImpRealMatA.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.txtImpRealMatA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpRealMatA.Enabled = False
        Me.txtImpRealMatA.Location = New System.Drawing.Point(451, 56)
        Me.txtImpRealMatA.Name = "txtImpRealMatA"
        Me.txtImpRealMatA.Size = New System.Drawing.Size(120, 19)
        Me.txtImpRealMatA.TabIndex = 120
        Me.txtImpRealMatA.TabStop = False
        '
        'txtImpRealVariosA
        '
        Me.txtImpRealVariosA.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.txtImpRealVariosA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpRealVariosA.Enabled = False
        Me.txtImpRealVariosA.Location = New System.Drawing.Point(451, 144)
        Me.txtImpRealVariosA.Name = "txtImpRealVariosA"
        Me.txtImpRealVariosA.Size = New System.Drawing.Size(120, 19)
        Me.txtImpRealVariosA.TabIndex = 119
        Me.txtImpRealVariosA.TabStop = False
        '
        'txtImpRealGastosA
        '
        Me.txtImpRealGastosA.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.txtImpRealGastosA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpRealGastosA.Enabled = False
        Me.txtImpRealGastosA.Location = New System.Drawing.Point(451, 122)
        Me.txtImpRealGastosA.Name = "txtImpRealGastosA"
        Me.txtImpRealGastosA.Size = New System.Drawing.Size(120, 19)
        Me.txtImpRealGastosA.TabIndex = 118
        '
        'txtImpRealCentrosA
        '
        Me.txtImpRealCentrosA.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.txtImpRealCentrosA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpRealCentrosA.Enabled = False
        Me.txtImpRealCentrosA.Location = New System.Drawing.Point(451, 100)
        Me.txtImpRealCentrosA.Name = "txtImpRealCentrosA"
        Me.txtImpRealCentrosA.Size = New System.Drawing.Size(120, 19)
        Me.txtImpRealCentrosA.TabIndex = 117
        Me.txtImpRealCentrosA.TabStop = False
        '
        'txtImpRealModA
        '
        Me.txtImpRealModA.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.txtImpRealModA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpRealModA.Enabled = False
        Me.txtImpRealModA.Location = New System.Drawing.Point(451, 78)
        Me.txtImpRealModA.Name = "txtImpRealModA"
        Me.txtImpRealModA.Size = New System.Drawing.Size(120, 19)
        Me.txtImpRealModA.TabIndex = 116
        Me.txtImpRealModA.TabStop = False
        '
        'lblImpReal
        '
        Me.lblImpReal.AutoSize = False
        Me.lblImpReal.Location = New System.Drawing.Point(451, 37)
        Me.lblImpReal.Name = "lblImpReal"
        Me.lblImpReal.Size = New System.Drawing.Size(120, 13)
        Me.lblImpReal.TabIndex = 136
        Me.lblImpReal.Text = "Coste Real"
        Me.lblImpReal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtImpRealTrabajoA
        '
        Me.txtImpRealTrabajoA.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.txtImpRealTrabajoA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpRealTrabajoA.Enabled = False
        Me.txtImpRealTrabajoA.Location = New System.Drawing.Point(451, 192)
        Me.txtImpRealTrabajoA.Name = "txtImpRealTrabajoA"
        Me.txtImpRealTrabajoA.Size = New System.Drawing.Size(120, 19)
        Me.txtImpRealTrabajoA.TabIndex = 114
        Me.txtImpRealTrabajoA.TabStop = False
        '
        'txtImpPrevQTrabajoVentaA
        '
        Me.txtImpPrevQTrabajoVentaA.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.txtImpPrevQTrabajoVentaA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPrevQTrabajoVentaA.Enabled = False
        Me.txtImpPrevQTrabajoVentaA.Location = New System.Drawing.Point(326, 192)
        Me.txtImpPrevQTrabajoVentaA.Name = "txtImpPrevQTrabajoVentaA"
        Me.txtImpPrevQTrabajoVentaA.Size = New System.Drawing.Size(120, 19)
        Me.txtImpPrevQTrabajoVentaA.TabIndex = 113
        Me.txtImpPrevQTrabajoVentaA.TabStop = False
        '
        'lblImpVentaPrev
        '
        Me.lblImpVentaPrev.AutoSize = False
        Me.lblImpVentaPrev.Location = New System.Drawing.Point(326, 37)
        Me.lblImpVentaPrev.Name = "lblImpVentaPrev"
        Me.lblImpVentaPrev.Size = New System.Drawing.Size(120, 13)
        Me.lblImpVentaPrev.TabIndex = 137
        Me.lblImpVentaPrev.Text = "Imp. Venta Prev."
        Me.lblImpVentaPrev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtImpPrevQModVentaA
        '
        Me.txtImpPrevQModVentaA.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.txtImpPrevQModVentaA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPrevQModVentaA.Enabled = False
        Me.txtImpPrevQModVentaA.Location = New System.Drawing.Point(326, 78)
        Me.txtImpPrevQModVentaA.Name = "txtImpPrevQModVentaA"
        Me.txtImpPrevQModVentaA.Size = New System.Drawing.Size(120, 19)
        Me.txtImpPrevQModVentaA.TabIndex = 111
        Me.txtImpPrevQModVentaA.TabStop = False
        '
        'txtImpPrevQCentrosVentaA
        '
        Me.txtImpPrevQCentrosVentaA.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.txtImpPrevQCentrosVentaA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPrevQCentrosVentaA.Enabled = False
        Me.txtImpPrevQCentrosVentaA.Location = New System.Drawing.Point(326, 100)
        Me.txtImpPrevQCentrosVentaA.Name = "txtImpPrevQCentrosVentaA"
        Me.txtImpPrevQCentrosVentaA.Size = New System.Drawing.Size(120, 19)
        Me.txtImpPrevQCentrosVentaA.TabIndex = 110
        Me.txtImpPrevQCentrosVentaA.TabStop = False
        '
        'txtImpPrevQGastosVentaA
        '
        Me.txtImpPrevQGastosVentaA.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.txtImpPrevQGastosVentaA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPrevQGastosVentaA.Enabled = False
        Me.txtImpPrevQGastosVentaA.Location = New System.Drawing.Point(326, 122)
        Me.txtImpPrevQGastosVentaA.Name = "txtImpPrevQGastosVentaA"
        Me.txtImpPrevQGastosVentaA.Size = New System.Drawing.Size(120, 19)
        Me.txtImpPrevQGastosVentaA.TabIndex = 109
        '
        'txtImpPrevQVariosVentaA
        '
        Me.txtImpPrevQVariosVentaA.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.txtImpPrevQVariosVentaA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPrevQVariosVentaA.Enabled = False
        Me.txtImpPrevQVariosVentaA.Location = New System.Drawing.Point(326, 144)
        Me.txtImpPrevQVariosVentaA.Name = "txtImpPrevQVariosVentaA"
        Me.txtImpPrevQVariosVentaA.Size = New System.Drawing.Size(120, 19)
        Me.txtImpPrevQVariosVentaA.TabIndex = 108
        Me.txtImpPrevQVariosVentaA.TabStop = False
        '
        'txtImpPrevQMatVentaA
        '
        Me.txtImpPrevQMatVentaA.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.txtImpPrevQMatVentaA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPrevQMatVentaA.Enabled = False
        Me.txtImpPrevQMatVentaA.Location = New System.Drawing.Point(326, 56)
        Me.txtImpPrevQMatVentaA.Name = "txtImpPrevQMatVentaA"
        Me.txtImpPrevQMatVentaA.Size = New System.Drawing.Size(120, 19)
        Me.txtImpPrevQMatVentaA.TabIndex = 107
        Me.txtImpPrevQMatVentaA.TabStop = False
        '
        'lblPorcPrev
        '
        Me.lblPorcPrev.AutoSize = False
        Me.lblPorcPrev.Location = New System.Drawing.Point(258, 37)
        Me.lblPorcPrev.Name = "lblPorcPrev"
        Me.lblPorcPrev.Size = New System.Drawing.Size(63, 13)
        Me.lblPorcPrev.TabIndex = 138
        Me.lblPorcPrev.Text = " % Prev."
        Me.lblPorcPrev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMargenPrevMat
        '
        Me.txtMargenPrevMat.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.txtMargenPrevMat.DisabledBackColor = System.Drawing.Color.White
        Me.txtMargenPrevMat.Enabled = False
        Me.txtMargenPrevMat.Location = New System.Drawing.Point(258, 56)
        Me.txtMargenPrevMat.Name = "txtMargenPrevMat"
        Me.txtMargenPrevMat.Size = New System.Drawing.Size(63, 19)
        Me.txtMargenPrevMat.TabIndex = 105
        Me.txtMargenPrevMat.TabStop = False
        '
        'txtMargenPrevMod
        '
        Me.txtMargenPrevMod.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.txtMargenPrevMod.DisabledBackColor = System.Drawing.Color.White
        Me.txtMargenPrevMod.Enabled = False
        Me.txtMargenPrevMod.Location = New System.Drawing.Point(258, 78)
        Me.txtMargenPrevMod.Name = "txtMargenPrevMod"
        Me.txtMargenPrevMod.Size = New System.Drawing.Size(63, 19)
        Me.txtMargenPrevMod.TabIndex = 104
        Me.txtMargenPrevMod.TabStop = False
        '
        'txtMargenPrevCentro
        '
        Me.txtMargenPrevCentro.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.txtMargenPrevCentro.DisabledBackColor = System.Drawing.Color.White
        Me.txtMargenPrevCentro.Enabled = False
        Me.txtMargenPrevCentro.Location = New System.Drawing.Point(258, 100)
        Me.txtMargenPrevCentro.Name = "txtMargenPrevCentro"
        Me.txtMargenPrevCentro.Size = New System.Drawing.Size(63, 19)
        Me.txtMargenPrevCentro.TabIndex = 103
        Me.txtMargenPrevCentro.TabStop = False
        '
        'txtMargenPrevGastos
        '
        Me.txtMargenPrevGastos.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.txtMargenPrevGastos.DisabledBackColor = System.Drawing.Color.White
        Me.txtMargenPrevGastos.Enabled = False
        Me.txtMargenPrevGastos.Location = New System.Drawing.Point(258, 122)
        Me.txtMargenPrevGastos.Name = "txtMargenPrevGastos"
        Me.txtMargenPrevGastos.Size = New System.Drawing.Size(63, 19)
        Me.txtMargenPrevGastos.TabIndex = 102
        '
        'txtMargenPrevVarios
        '
        Me.txtMargenPrevVarios.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.txtMargenPrevVarios.DisabledBackColor = System.Drawing.Color.White
        Me.txtMargenPrevVarios.Enabled = False
        Me.txtMargenPrevVarios.Location = New System.Drawing.Point(258, 144)
        Me.txtMargenPrevVarios.Name = "txtMargenPrevVarios"
        Me.txtMargenPrevVarios.Size = New System.Drawing.Size(63, 19)
        Me.txtMargenPrevVarios.TabIndex = 101
        Me.txtMargenPrevVarios.TabStop = False
        '
        'lblMaterialesA
        '
        Me.lblMaterialesA.Location = New System.Drawing.Point(20, 56)
        Me.lblMaterialesA.Name = "lblMaterialesA"
        Me.lblMaterialesA.Size = New System.Drawing.Size(65, 13)
        Me.lblMaterialesA.TabIndex = 139
        Me.lblMaterialesA.Text = "Materiales"
        '
        'txtImpPrevQMatA
        '
        Me.txtImpPrevQMatA.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.txtImpPrevQMatA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPrevQMatA.Enabled = False
        Me.txtImpPrevQMatA.Location = New System.Drawing.Point(133, 56)
        Me.txtImpPrevQMatA.Name = "txtImpPrevQMatA"
        Me.txtImpPrevQMatA.Size = New System.Drawing.Size(120, 19)
        Me.txtImpPrevQMatA.TabIndex = 100
        Me.txtImpPrevQMatA.TabStop = False
        '
        'Linea
        '
        Me.Linea.Location = New System.Drawing.Point(16, 186)
        Me.Linea.Name = "Linea"
        Me.Linea.Size = New System.Drawing.Size(758, 3)
        Me.Linea.TabIndex = 140
        '
        'lblVariosA
        '
        Me.lblVariosA.Location = New System.Drawing.Point(20, 144)
        Me.lblVariosA.Name = "lblVariosA"
        Me.lblVariosA.Size = New System.Drawing.Size(42, 13)
        Me.lblVariosA.TabIndex = 141
        Me.lblVariosA.Text = "Varios"
        '
        'txtImpPrevQVariosA
        '
        Me.txtImpPrevQVariosA.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.txtImpPrevQVariosA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPrevQVariosA.Enabled = False
        Me.txtImpPrevQVariosA.Location = New System.Drawing.Point(133, 144)
        Me.txtImpPrevQVariosA.Name = "txtImpPrevQVariosA"
        Me.txtImpPrevQVariosA.Size = New System.Drawing.Size(120, 19)
        Me.txtImpPrevQVariosA.TabIndex = 99
        Me.txtImpPrevQVariosA.TabStop = False
        '
        'lblGastosA
        '
        Me.lblGastosA.Location = New System.Drawing.Point(20, 122)
        Me.lblGastosA.Name = "lblGastosA"
        Me.lblGastosA.Size = New System.Drawing.Size(46, 13)
        Me.lblGastosA.TabIndex = 142
        Me.lblGastosA.Text = "Gastos"
        '
        'txtImpPrevQGastosA
        '
        Me.txtImpPrevQGastosA.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.txtImpPrevQGastosA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPrevQGastosA.Enabled = False
        Me.txtImpPrevQGastosA.Location = New System.Drawing.Point(132, 122)
        Me.txtImpPrevQGastosA.Name = "txtImpPrevQGastosA"
        Me.txtImpPrevQGastosA.Size = New System.Drawing.Size(120, 19)
        Me.txtImpPrevQGastosA.TabIndex = 98
        Me.txtImpPrevQGastosA.TabStop = False
        '
        'lblCentrosA
        '
        Me.lblCentrosA.Location = New System.Drawing.Point(20, 100)
        Me.lblCentrosA.Name = "lblCentrosA"
        Me.lblCentrosA.Size = New System.Drawing.Size(52, 13)
        Me.lblCentrosA.TabIndex = 143
        Me.lblCentrosA.Text = "Centros"
        '
        'txtImpPrevQCentrosA
        '
        Me.txtImpPrevQCentrosA.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.txtImpPrevQCentrosA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPrevQCentrosA.Enabled = False
        Me.txtImpPrevQCentrosA.Location = New System.Drawing.Point(133, 100)
        Me.txtImpPrevQCentrosA.Name = "txtImpPrevQCentrosA"
        Me.txtImpPrevQCentrosA.Size = New System.Drawing.Size(120, 19)
        Me.txtImpPrevQCentrosA.TabIndex = 97
        Me.txtImpPrevQCentrosA.TabStop = False
        '
        'lblModA
        '
        Me.lblModA.Location = New System.Drawing.Point(20, 78)
        Me.lblModA.Name = "lblModA"
        Me.lblModA.Size = New System.Drawing.Size(46, 13)
        Me.lblModA.TabIndex = 144
        Me.lblModA.Text = "M.O.D."
        '
        'txtImpPrevQModA
        '
        Me.txtImpPrevQModA.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.txtImpPrevQModA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPrevQModA.Enabled = False
        Me.txtImpPrevQModA.Location = New System.Drawing.Point(133, 78)
        Me.txtImpPrevQModA.Name = "txtImpPrevQModA"
        Me.txtImpPrevQModA.Size = New System.Drawing.Size(120, 19)
        Me.txtImpPrevQModA.TabIndex = 96
        Me.txtImpPrevQModA.TabStop = False
        '
        'lblCostePrev
        '
        Me.lblCostePrev.AutoSize = False
        Me.lblCostePrev.Location = New System.Drawing.Point(133, 37)
        Me.lblCostePrev.Name = "lblCostePrev"
        Me.lblCostePrev.Size = New System.Drawing.Size(120, 13)
        Me.lblCostePrev.TabIndex = 145
        Me.lblCostePrev.Text = "Coste Previsto"
        Me.lblCostePrev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMargenTrabajoPrev
        '
        Me.txtMargenTrabajoPrev.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.txtMargenTrabajoPrev.DisabledBackColor = System.Drawing.Color.White
        Me.txtMargenTrabajoPrev.Enabled = False
        Me.txtMargenTrabajoPrev.Location = New System.Drawing.Point(258, 192)
        Me.txtMargenTrabajoPrev.Name = "txtMargenTrabajoPrev"
        Me.txtMargenTrabajoPrev.Size = New System.Drawing.Size(63, 19)
        Me.txtMargenTrabajoPrev.TabIndex = 94
        Me.txtMargenTrabajoPrev.TabStop = False
        '
        'lblTotalTrabajosA
        '
        Me.lblTotalTrabajosA.Location = New System.Drawing.Point(20, 192)
        Me.lblTotalTrabajosA.Name = "lblTotalTrabajosA"
        Me.lblTotalTrabajosA.Size = New System.Drawing.Size(107, 13)
        Me.lblTotalTrabajosA.TabIndex = 146
        Me.lblTotalTrabajosA.Text = "TOTAL Conceptos"
        '
        'txtImpPrevQTrabajoA
        '
        Me.txtImpPrevQTrabajoA.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.txtImpPrevQTrabajoA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPrevQTrabajoA.Enabled = False
        Me.txtImpPrevQTrabajoA.Location = New System.Drawing.Point(133, 192)
        Me.txtImpPrevQTrabajoA.Name = "txtImpPrevQTrabajoA"
        Me.txtImpPrevQTrabajoA.Size = New System.Drawing.Size(120, 19)
        Me.txtImpPrevQTrabajoA.TabIndex = 93
        Me.txtImpPrevQTrabajoA.TabStop = False
        '
        'txtMargenRealTrabajo
        '
        Me.txtMargenRealTrabajo.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.txtMargenRealTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.txtMargenRealTrabajo.Enabled = False
        Me.txtMargenRealTrabajo.Location = New System.Drawing.Point(577, 192)
        Me.txtMargenRealTrabajo.Name = "txtMargenRealTrabajo"
        Me.txtMargenRealTrabajo.Size = New System.Drawing.Size(65, 19)
        Me.txtMargenRealTrabajo.TabIndex = 92
        Me.txtMargenRealTrabajo.TabStop = False
        '
        'txtImpVencimientoA
        '
        Me.txtImpVencimientoA.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.txtImpVencimientoA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpVencimientoA.Enabled = False
        Me.txtImpVencimientoA.Location = New System.Drawing.Point(647, 166)
        Me.txtImpVencimientoA.Name = "txtImpVencimientoA"
        Me.txtImpVencimientoA.Size = New System.Drawing.Size(120, 19)
        Me.txtImpVencimientoA.TabIndex = 91
        Me.txtImpVencimientoA.TabStop = False
        '
        'lblVencimientosA
        '
        Me.lblVencimientosA.Location = New System.Drawing.Point(20, 166)
        Me.lblVencimientosA.Name = "lblVencimientosA"
        Me.lblVencimientosA.Size = New System.Drawing.Size(103, 13)
        Me.lblVencimientosA.TabIndex = 147
        Me.lblVencimientosA.Text = "Hitos Facturación"
        '
        'txtVencimientosA
        '
        Me.txtVencimientosA.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.txtVencimientosA.DisabledBackColor = System.Drawing.Color.White
        Me.txtVencimientosA.Enabled = False
        Me.txtVencimientosA.Location = New System.Drawing.Point(133, 166)
        Me.txtVencimientosA.Name = "txtVencimientosA"
        Me.txtVencimientosA.Size = New System.Drawing.Size(120, 19)
        Me.txtVencimientosA.TabIndex = 90
        Me.txtVencimientosA.TabStop = False
        '
        'FraTotalesObra
        '
        Me.FraTotalesObra.Controls.Add(Me.txtMargenReal)
        Me.FraTotalesObra.Controls.Add(Me.txtMargenPrev)
        Me.FraTotalesObra.Controls.Add(Me.txtImpFactA)
        Me.FraTotalesObra.Controls.Add(Me.txtImpRealA)
        Me.FraTotalesObra.Controls.Add(Me.txtImpPrevVentaA)
        Me.FraTotalesObra.Controls.Add(Me.lblTotalObrasA)
        Me.FraTotalesObra.Controls.Add(Me.txtImpPrevA)
        Me.FraTotalesObra.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FraTotalesObra.Location = New System.Drawing.Point(0, 496)
        Me.FraTotalesObra.Name = "FraTotalesObra"
        Me.FraTotalesObra.Size = New System.Drawing.Size(782, 35)
        Me.FraTotalesObra.TabIndex = 171
        Me.FraTotalesObra.TabStop = False
        '
        'txtMargenReal
        '
        Me.txtMargenReal.DisabledBackColor = System.Drawing.Color.White
        Me.txtMargenReal.Enabled = False
        Me.txtMargenReal.Location = New System.Drawing.Point(577, 11)
        Me.txtMargenReal.Name = "txtMargenReal"
        Me.txtMargenReal.Size = New System.Drawing.Size(65, 21)
        Me.txtMargenReal.TabIndex = 171
        '
        'txtMargenPrev
        '
        Me.txtMargenPrev.DisabledBackColor = System.Drawing.Color.White
        Me.txtMargenPrev.Enabled = False
        Me.txtMargenPrev.Location = New System.Drawing.Point(258, 11)
        Me.txtMargenPrev.Name = "txtMargenPrev"
        Me.txtMargenPrev.Size = New System.Drawing.Size(63, 21)
        Me.txtMargenPrev.TabIndex = 169
        '
        'txtImpFactA
        '
        Me.txtImpFactA.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.TryDataBinding(txtImpFactA, New System.Windows.Forms.Binding("Value", Me, "ImpFactA", True))
        Me.txtImpFactA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpFactA.Enabled = False
        Me.txtImpFactA.Location = New System.Drawing.Point(647, 11)
        Me.txtImpFactA.Name = "txtImpFactA"
        Me.txtImpFactA.Size = New System.Drawing.Size(120, 19)
        Me.txtImpFactA.TabIndex = 166
        Me.txtImpFactA.TabStop = False
        '
        'txtImpRealA
        '
        Me.txtImpRealA.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.TryDataBinding(txtImpRealA, New System.Windows.Forms.Binding("Value", Me, "ImpRealA", True))
        Me.txtImpRealA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpRealA.Enabled = False
        Me.txtImpRealA.Location = New System.Drawing.Point(451, 11)
        Me.txtImpRealA.Name = "txtImpRealA"
        Me.txtImpRealA.Size = New System.Drawing.Size(120, 19)
        Me.txtImpRealA.TabIndex = 165
        Me.txtImpRealA.TabStop = False
        '
        'txtImpPrevVentaA
        '
        Me.txtImpPrevVentaA.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.TryDataBinding(txtImpPrevVentaA, New System.Windows.Forms.Binding("Value", Me, "ImpPrevVentaA", True))
        Me.txtImpPrevVentaA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPrevVentaA.Enabled = False
        Me.txtImpPrevVentaA.Location = New System.Drawing.Point(327, 11)
        Me.txtImpPrevVentaA.Name = "txtImpPrevVentaA"
        Me.txtImpPrevVentaA.Size = New System.Drawing.Size(120, 19)
        Me.txtImpPrevVentaA.TabIndex = 164
        Me.txtImpPrevVentaA.TabStop = False
        '
        'lblTotalObrasA
        '
        Me.lblTotalObrasA.Location = New System.Drawing.Point(20, 11)
        Me.lblTotalObrasA.Name = "lblTotalObrasA"
        Me.lblTotalObrasA.Size = New System.Drawing.Size(97, 13)
        Me.lblTotalObrasA.TabIndex = 167
        Me.lblTotalObrasA.Text = "TOTAL Proyecto"
        '
        'txtImpPrevA
        '
        Me.txtImpPrevA.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.TryDataBinding(txtImpPrevA, New System.Windows.Forms.Binding("Value", Me, "ImpPrevA", True))
        Me.txtImpPrevA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPrevA.Enabled = False
        Me.txtImpPrevA.Location = New System.Drawing.Point(133, 11)
        Me.txtImpPrevA.Name = "txtImpPrevA"
        Me.txtImpPrevA.Size = New System.Drawing.Size(120, 19)
        Me.txtImpPrevA.TabIndex = 163
        Me.txtImpPrevA.TabStop = False
        '
        'FraCondEconom
        '
        Me.FraCondEconom.Controls.Add(Me.chkSeguroCambio)
        Me.FraCondEconom.Controls.Add(Me.txtCambioB)
        Me.FraCondEconom.Controls.Add(Me.lblCambioB)
        Me.FraCondEconom.Controls.Add(Me.AdvIDMoneda)
        Me.FraCondEconom.Controls.Add(Me.lblCentroGestion)
        Me.FraCondEconom.Controls.Add(Me.cbxCentroGestion)
        Me.FraCondEconom.Controls.Add(Me.ulDescMoneda)
        Me.FraCondEconom.Controls.Add(Me.txtCambioA)
        Me.FraCondEconom.Controls.Add(Me.lblCambioA)
        Me.FraCondEconom.Controls.Add(Me.lblTipoIVA)
        Me.FraCondEconom.Controls.Add(Me.AdvIDTipoIVA)
        Me.FraCondEconom.Controls.Add(Me.lblDiaPago)
        Me.FraCondEconom.Controls.Add(Me.AdvIDDiaPago)
        Me.FraCondEconom.Controls.Add(Me.lblCondicionPago)
        Me.FraCondEconom.Controls.Add(Me.AdvIDCondicionPago)
        Me.FraCondEconom.Controls.Add(Me.lblFormaPago)
        Me.FraCondEconom.Controls.Add(Me.AdvIDFormaPago)
        Me.FraCondEconom.Controls.Add(Me.lblMoneda)
        Me.FraCondEconom.Dock = System.Windows.Forms.DockStyle.Top
        Me.FraCondEconom.Location = New System.Drawing.Point(0, 138)
        Me.FraCondEconom.Name = "FraCondEconom"
        Me.FraCondEconom.Size = New System.Drawing.Size(782, 85)
        Me.FraCondEconom.TabIndex = 164
        Me.FraCondEconom.TabStop = False
        Me.FraCondEconom.Text = "Condiciones Económicas"
        '
        'chkSeguroCambio
        '
        Me.TryDataBinding(chkSeguroCambio, New System.Windows.Forms.Binding("BindableValue", Me, "SeguroCambio", True))
        Me.chkSeguroCambio.Location = New System.Drawing.Point(628, 27)
        Me.chkSeguroCambio.Name = "chkSeguroCambio"
        Me.chkSeguroCambio.Size = New System.Drawing.Size(147, 20)
        Me.chkSeguroCambio.TabIndex = 5
        Me.chkSeguroCambio.Text = "Seguro de Cambio"
        '
        'txtCambioB
        '
        Me.TryDataBinding(txtCambioB, New System.Windows.Forms.Binding("Value", Me, "CambioB", True))
        Me.txtCambioB.DisabledBackColor = System.Drawing.Color.White
        Me.txtCambioB.Location = New System.Drawing.Point(551, 50)
        Me.txtCambioB.Name = "txtCambioB"
        Me.txtCambioB.Size = New System.Drawing.Size(68, 21)
        Me.txtCambioB.TabIndex = 7
        '
        'lblCambioB
        '
        Me.lblCambioB.Location = New System.Drawing.Point(485, 54)
        Me.lblCambioB.Name = "lblCambioB"
        Me.lblCambioB.Size = New System.Drawing.Size(63, 13)
        Me.lblCambioB.TabIndex = 242
        Me.lblCambioB.Text = "Cambio B"
        '
        'AdvIDMoneda
        '
        Me.TryDataBinding(AdvIDMoneda, New System.Windows.Forms.Binding("Text", Me, "IDMoneda", True))
        Me.AdvIDMoneda.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDMoneda.EntityName = "Moneda"
        Me.AdvIDMoneda.Location = New System.Drawing.Point(414, 24)
        Me.AdvIDMoneda.Name = "AdvIDMoneda"
        Me.AdvIDMoneda.PrimaryDataFields = "IDMoneda"
        Me.AdvIDMoneda.SecondaryDataFields = "IDMoneda"
        Me.AdvIDMoneda.Size = New System.Drawing.Size(68, 23)
        Me.AdvIDMoneda.TabIndex = 4
        '
        'lblCentroGestion
        '
        Me.lblCentroGestion.Location = New System.Drawing.Point(625, 55)
        Me.lblCentroGestion.Name = "lblCentroGestion"
        Me.lblCentroGestion.Size = New System.Drawing.Size(67, 13)
        Me.lblCentroGestion.TabIndex = 240
        Me.lblCentroGestion.Text = "C. Gestión"
        '
        'cbxCentroGestion
        '
        Me.TryDataBinding(cbxCentroGestion, New System.Windows.Forms.Binding("Value", Me, "IDCentroGestion", True))
        cbxCentroGestion_DesignTimeLayout.LayoutString = resources.GetString("cbxCentroGestion_DesignTimeLayout.LayoutString")
        Me.cbxCentroGestion.DesignTimeLayout = cbxCentroGestion_DesignTimeLayout
        Me.cbxCentroGestion.DisabledBackColor = System.Drawing.Color.White
        Me.cbxCentroGestion.DisplayMember = "IDCentroGestion"
        Me.cbxCentroGestion.EntityName = "CentroGestion"
        Me.cbxCentroGestion.Location = New System.Drawing.Point(695, 51)
        Me.cbxCentroGestion.Name = "cbxCentroGestion"
        Me.cbxCentroGestion.PrimaryDataFields = "IDCentroGestion"
        Me.cbxCentroGestion.SecondaryDataFields = "IDCentroGestion"
        Me.cbxCentroGestion.SelectedIndex = -1
        Me.cbxCentroGestion.SelectedItem = Nothing
        Me.cbxCentroGestion.Size = New System.Drawing.Size(72, 21)
        Me.cbxCentroGestion.TabIndex = 8
        '
        'ulDescMoneda
        '
        Me.TryDataBinding(ulDescMoneda, New System.Windows.Forms.Binding("Text", Me.AdvIDMoneda, "DescMoneda", True))
        Me.ulDescMoneda.Location = New System.Drawing.Point(485, 24)
        Me.ulDescMoneda.Name = "ulDescMoneda"
        Me.ulDescMoneda.Size = New System.Drawing.Size(134, 23)
        Me.ulDescMoneda.TabIndex = 216
        Me.ulDescMoneda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCambioA
        '
        Me.TryDataBinding(txtCambioA, New System.Windows.Forms.Binding("Value", Me, "CambioA", True))
        Me.txtCambioA.DisabledBackColor = System.Drawing.Color.White
        Me.txtCambioA.Location = New System.Drawing.Point(414, 50)
        Me.txtCambioA.Name = "txtCambioA"
        Me.txtCambioA.Size = New System.Drawing.Size(68, 21)
        Me.txtCambioA.TabIndex = 6
        '
        'lblCambioA
        '
        Me.lblCambioA.Location = New System.Drawing.Point(348, 54)
        Me.lblCambioA.Name = "lblCambioA"
        Me.lblCambioA.Size = New System.Drawing.Size(63, 13)
        Me.lblCambioA.TabIndex = 210
        Me.lblCambioA.Text = "Cambio A"
        '
        'lblTipoIVA
        '
        Me.lblTipoIVA.Location = New System.Drawing.Point(175, 54)
        Me.lblTipoIVA.Name = "lblTipoIVA"
        Me.lblTipoIVA.Size = New System.Drawing.Size(66, 13)
        Me.lblTipoIVA.TabIndex = 207
        Me.lblTipoIVA.Text = "Tipo I.V.A."
        '
        'AdvIDTipoIVA
        '
        Me.TryDataBinding(AdvIDTipoIVA, New System.Windows.Forms.Binding("Text", Me, "IDTipoIVA", True))
        Me.AdvIDTipoIVA.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDTipoIVA.EntityName = "TipoIva"
        Me.AdvIDTipoIVA.Location = New System.Drawing.Point(247, 50)
        Me.AdvIDTipoIVA.Name = "AdvIDTipoIVA"
        Me.AdvIDTipoIVA.PrimaryDataFields = "IDTipoIVA"
        Me.AdvIDTipoIVA.SecondaryDataFields = "IDTipoIva"
        Me.AdvIDTipoIVA.Size = New System.Drawing.Size(88, 23)
        Me.AdvIDTipoIVA.TabIndex = 3
        Me.AdvIDTipoIVA.ViewName = "tbMaestroTipoIva"
        '
        'lblDiaPago
        '
        Me.lblDiaPago.Location = New System.Drawing.Point(175, 29)
        Me.lblDiaPago.Name = "lblDiaPago"
        Me.lblDiaPago.Size = New System.Drawing.Size(58, 13)
        Me.lblDiaPago.TabIndex = 0
        Me.lblDiaPago.Text = "Día Pago"
        '
        'AdvIDDiaPago
        '
        Me.TryDataBinding(AdvIDDiaPago, New System.Windows.Forms.Binding("Text", Me, "IDDiaPago", True))
        Me.AdvIDDiaPago.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDDiaPago.EntityName = "DiaPago"
        Me.AdvIDDiaPago.Location = New System.Drawing.Point(247, 24)
        Me.AdvIDDiaPago.Name = "AdvIDDiaPago"
        Me.AdvIDDiaPago.PrimaryDataFields = "IDDiaPago"
        Me.AdvIDDiaPago.SecondaryDataFields = "IDDiaPago"
        Me.AdvIDDiaPago.Size = New System.Drawing.Size(88, 23)
        Me.AdvIDDiaPago.TabIndex = 2
        Me.AdvIDDiaPago.ViewName = "tbMaestroDiaPago"
        '
        'lblCondicionPago
        '
        Me.lblCondicionPago.Location = New System.Drawing.Point(20, 54)
        Me.lblCondicionPago.Name = "lblCondicionPago"
        Me.lblCondicionPago.Size = New System.Drawing.Size(52, 13)
        Me.lblCondicionPago.TabIndex = 136
        Me.lblCondicionPago.Text = "C. Pago"
        '
        'AdvIDCondicionPago
        '
        Me.TryDataBinding(AdvIDCondicionPago, New System.Windows.Forms.Binding("Text", Me, "IDCondicionPago", True))
        Me.AdvIDCondicionPago.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDCondicionPago.EntityName = "CondicionPago"
        Me.AdvIDCondicionPago.Location = New System.Drawing.Point(76, 50)
        Me.AdvIDCondicionPago.Name = "AdvIDCondicionPago"
        Me.AdvIDCondicionPago.PrimaryDataFields = "IDCondicionPago"
        Me.AdvIDCondicionPago.SecondaryDataFields = "IDCondicionPago"
        Me.AdvIDCondicionPago.Size = New System.Drawing.Size(88, 23)
        Me.AdvIDCondicionPago.TabIndex = 1
        Me.AdvIDCondicionPago.ViewName = "tbMaestroCondicionPago"
        '
        'lblFormaPago
        '
        Me.lblFormaPago.Location = New System.Drawing.Point(20, 29)
        Me.lblFormaPago.Name = "lblFormaPago"
        Me.lblFormaPago.Size = New System.Drawing.Size(47, 13)
        Me.lblFormaPago.TabIndex = 138
        Me.lblFormaPago.Text = "F. Pago"
        '
        'AdvIDFormaPago
        '
        Me.TryDataBinding(AdvIDFormaPago, New System.Windows.Forms.Binding("Text", Me, "IDFormaPago", True))
        Me.AdvIDFormaPago.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDFormaPago.EntityName = "FormaPago"
        Me.AdvIDFormaPago.Location = New System.Drawing.Point(76, 24)
        Me.AdvIDFormaPago.Name = "AdvIDFormaPago"
        Me.AdvIDFormaPago.PrimaryDataFields = "IDFormaPago"
        Me.AdvIDFormaPago.SecondaryDataFields = "IDFormaPago"
        Me.AdvIDFormaPago.Size = New System.Drawing.Size(88, 23)
        Me.AdvIDFormaPago.TabIndex = 0
        Me.AdvIDFormaPago.ViewName = "tbMaestroFormaPago"
        '
        'lblMoneda
        '
        Me.lblMoneda.Location = New System.Drawing.Point(348, 29)
        Me.lblMoneda.Name = "lblMoneda"
        Me.lblMoneda.Size = New System.Drawing.Size(51, 13)
        Me.lblMoneda.TabIndex = 140
        Me.lblMoneda.Text = "Moneda"
        '
        'pnlCliente
        '
        Me.pnlCliente.Controls.Add(Me.lblClaseObra)
        Me.pnlCliente.Controls.Add(Me.cbxIDClase)
        Me.pnlCliente.Controls.Add(Me.FraClientes)
        Me.pnlCliente.Controls.Add(Me.FraFechas)
        Me.pnlCliente.Controls.Add(Me.lblTipoObra)
        Me.pnlCliente.Controls.Add(Me.ulDescTipoObra)
        Me.pnlCliente.Controls.Add(Me.AdvIDTipoObra)
        Me.pnlCliente.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCliente.Location = New System.Drawing.Point(0, 0)
        Me.pnlCliente.Name = "pnlCliente"
        Me.pnlCliente.Size = New System.Drawing.Size(782, 138)
        Me.pnlCliente.TabIndex = 163
        '
        'lblClaseObra
        '
        Me.lblClaseObra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblClaseObra.Location = New System.Drawing.Point(577, 12)
        Me.lblClaseObra.Name = "lblClaseObra"
        Me.lblClaseObra.Size = New System.Drawing.Size(39, 13)
        Me.lblClaseObra.TabIndex = 170
        Me.lblClaseObra.Text = "Clase"
        '
        'cbxIDClase
        '
        Me.cbxIDClase.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbxIDClase.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList
        Me.TryDataBinding(cbxIDClase, New System.Windows.Forms.Binding("Value", Me, "IDClase", True))
        cbxIDClase_DesignTimeLayout.LayoutString = resources.GetString("cbxIDClase_DesignTimeLayout.LayoutString")
        Me.cbxIDClase.DesignTimeLayout = cbxIDClase_DesignTimeLayout
        Me.cbxIDClase.DisabledBackColor = System.Drawing.Color.White
        Me.cbxIDClase.DisplayMember = "Value"
        Me.cbxIDClase.Location = New System.Drawing.Point(621, 9)
        Me.cbxIDClase.Name = "cbxIDClase"
        Me.cbxIDClase.PrimaryDataFields = "Estado"
        Me.cbxIDClase.SecondaryDataFields = "Value"
        Me.cbxIDClase.SelectedIndex = -1
        Me.cbxIDClase.SelectedItem = Nothing
        Me.cbxIDClase.Size = New System.Drawing.Size(156, 21)
        Me.cbxIDClase.TabIndex = 7
        '
        'FraClientes
        '
        Me.FraClientes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FraClientes.Controls.Add(Me.lblPoblacion)
        Me.FraClientes.Controls.Add(Me.txtPoblacion)
        Me.FraClientes.Controls.Add(Me.lblCodPostal)
        Me.FraClientes.Controls.Add(Me.txtCodPostal)
        Me.FraClientes.Controls.Add(Me.lblProvincia)
        Me.FraClientes.Controls.Add(Me.txtProvincia)
        Me.FraClientes.Controls.Add(Me.lblDireccion)
        Me.FraClientes.Controls.Add(Me.txtDireccion)
        Me.FraClientes.Controls.Add(Me.lblCliente)
        Me.FraClientes.Controls.Add(Me.ulDescCliente)
        Me.FraClientes.Controls.Add(Me.AdvIDCliente)
        Me.FraClientes.Location = New System.Drawing.Point(112, 34)
        Me.FraClientes.Name = "FraClientes"
        Me.FraClientes.Size = New System.Drawing.Size(667, 99)
        Me.FraClientes.TabIndex = 163
        Me.FraClientes.TabStop = False
        Me.FraClientes.Text = "Datos Cliente"
        '
        'lblPoblacion
        '
        Me.lblPoblacion.Location = New System.Drawing.Point(126, 73)
        Me.lblPoblacion.Name = "lblPoblacion"
        Me.lblPoblacion.Size = New System.Drawing.Size(61, 13)
        Me.lblPoblacion.TabIndex = 0
        Me.lblPoblacion.Text = "Población"
        '
        'txtPoblacion
        '
        Me.TryDataBinding(txtPoblacion, New System.Windows.Forms.Binding("Text", Me, "PoblacionCli", True))
        Me.txtPoblacion.DisabledBackColor = System.Drawing.Color.White
        Me.txtPoblacion.Enabled = False
        Me.txtPoblacion.Location = New System.Drawing.Point(189, 69)
        Me.txtPoblacion.Name = "txtPoblacion"
        Me.txtPoblacion.Size = New System.Drawing.Size(240, 21)
        Me.txtPoblacion.TabIndex = 88
        Me.txtPoblacion.TabStop = False
        '
        'lblCodPostal
        '
        Me.lblCodPostal.Location = New System.Drawing.Point(7, 73)
        Me.lblCodPostal.Name = "lblCodPostal"
        Me.lblCodPostal.Size = New System.Drawing.Size(29, 13)
        Me.lblCodPostal.TabIndex = 89
        Me.lblCodPostal.Text = "C.P."
        '
        'txtCodPostal
        '
        Me.TryDataBinding(txtCodPostal, New System.Windows.Forms.Binding("Text", Me, "CodPostalCli", True))
        Me.txtCodPostal.DisabledBackColor = System.Drawing.Color.White
        Me.txtCodPostal.Enabled = False
        Me.txtCodPostal.Location = New System.Drawing.Point(68, 69)
        Me.txtCodPostal.Name = "txtCodPostal"
        Me.txtCodPostal.Size = New System.Drawing.Size(55, 21)
        Me.txtCodPostal.TabIndex = 87
        Me.txtCodPostal.TabStop = False
        '
        'lblProvincia
        '
        Me.lblProvincia.Location = New System.Drawing.Point(435, 73)
        Me.lblProvincia.Name = "lblProvincia"
        Me.lblProvincia.Size = New System.Drawing.Size(59, 13)
        Me.lblProvincia.TabIndex = 90
        Me.lblProvincia.Text = "Provincia"
        '
        'txtProvincia
        '
        Me.TryDataBinding(txtProvincia, New System.Windows.Forms.Binding("Text", Me, "ProvinciaCli", True))
        Me.txtProvincia.DisabledBackColor = System.Drawing.Color.White
        Me.txtProvincia.Enabled = False
        Me.txtProvincia.Location = New System.Drawing.Point(499, 69)
        Me.txtProvincia.Name = "txtProvincia"
        Me.txtProvincia.Size = New System.Drawing.Size(156, 21)
        Me.txtProvincia.TabIndex = 86
        Me.txtProvincia.TabStop = False
        '
        'lblDireccion
        '
        Me.lblDireccion.Location = New System.Drawing.Point(7, 49)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(60, 13)
        Me.lblDireccion.TabIndex = 91
        Me.lblDireccion.Text = "Dirección"
        '
        'txtDireccion
        '
        Me.TryDataBinding(txtDireccion, New System.Windows.Forms.Binding("Text", Me, "DireccionCli", True))
        Me.txtDireccion.DisabledBackColor = System.Drawing.Color.White
        Me.txtDireccion.Enabled = False
        Me.txtDireccion.Location = New System.Drawing.Point(68, 45)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(587, 21)
        Me.txtDireccion.TabIndex = 85
        Me.txtDireccion.TabStop = False
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(7, 24)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(47, 13)
        Me.lblCliente.TabIndex = 92
        Me.lblCliente.Text = "Cliente"
        '
        'ulDescCliente
        '
        Me.TryDataBinding(ulDescCliente, New System.Windows.Forms.Binding("Text", Me.AdvIDCliente, "DescCliente", True))
        Me.ulDescCliente.Location = New System.Drawing.Point(185, 19)
        Me.ulDescCliente.Name = "ulDescCliente"
        Me.ulDescCliente.Size = New System.Drawing.Size(470, 23)
        Me.ulDescCliente.TabIndex = 93
        '
        'AdvIDCliente
        '
        Me.TryDataBinding(AdvIDCliente, New System.Windows.Forms.Binding("Text", Me, "IDCliente", True))
        Me.AdvIDCliente.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDCliente.EntityName = "Cliente"
        Me.AdvIDCliente.Location = New System.Drawing.Point(68, 19)
        Me.AdvIDCliente.Name = "AdvIDCliente"
        Me.AdvIDCliente.PrimaryDataFields = "IDCliente"
        Me.AdvIDCliente.SecondaryDataFields = "IDCliente"
        Me.AdvIDCliente.Size = New System.Drawing.Size(114, 23)
        Me.AdvIDCliente.TabIndex = 8
        Me.AdvIDCliente.ViewName = "tbMaestroCliente"
        '
        'FraFechas
        '
        Me.FraFechas.Controls.Add(Me.lblFechaInicio)
        Me.FraFechas.Controls.Add(Me.cbxFechaInicio)
        Me.FraFechas.Controls.Add(Me.lblFechaFin)
        Me.FraFechas.Controls.Add(Me.cbxFechaFin)
        Me.FraFechas.Location = New System.Drawing.Point(2, 5)
        Me.FraFechas.Name = "FraFechas"
        Me.FraFechas.Size = New System.Drawing.Size(105, 128)
        Me.FraFechas.TabIndex = 162
        Me.FraFechas.TabStop = False
        Me.FraFechas.Text = "Fechas"
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.Location = New System.Drawing.Point(9, 24)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.Size = New System.Drawing.Size(75, 13)
        Me.lblFechaInicio.TabIndex = 0
        Me.lblFechaInicio.Text = "Fecha Inicio"
        '
        'cbxFechaInicio
        '
        Me.TryDataBinding(cbxFechaInicio, New System.Windows.Forms.Binding("BindableValue", Me, "FechaInicio", True))
        Me.cbxFechaInicio.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaInicio.Location = New System.Drawing.Point(9, 45)
        Me.cbxFechaInicio.Name = "cbxFechaInicio"
        Me.cbxFechaInicio.Size = New System.Drawing.Size(87, 21)
        Me.cbxFechaInicio.TabIndex = 4
        '
        'lblFechaFin
        '
        Me.lblFechaFin.Location = New System.Drawing.Point(9, 71)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(60, 13)
        Me.lblFechaFin.TabIndex = 5
        Me.lblFechaFin.Text = "Fecha Fin"
        '
        'cbxFechaFin
        '
        Me.TryDataBinding(cbxFechaFin, New System.Windows.Forms.Binding("BindableValue", Me, "FechaFin", True))
        Me.cbxFechaFin.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaFin.Location = New System.Drawing.Point(9, 92)
        Me.cbxFechaFin.Name = "cbxFechaFin"
        Me.cbxFechaFin.Size = New System.Drawing.Size(87, 21)
        Me.cbxFechaFin.TabIndex = 5
        '
        'lblTipoObra
        '
        Me.lblTipoObra.Location = New System.Drawing.Point(118, 12)
        Me.lblTipoObra.Name = "lblTipoObra"
        Me.lblTipoObra.Size = New System.Drawing.Size(31, 13)
        Me.lblTipoObra.TabIndex = 167
        Me.lblTipoObra.Text = "Tipo"
        '
        'ulDescTipoObra
        '
        Me.ulDescTipoObra.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TryDataBinding(ulDescTipoObra, New System.Windows.Forms.Binding("Text", Me.AdvIDTipoObra, "DescTipoObra", True))
        Me.ulDescTipoObra.Location = New System.Drawing.Point(296, 7)
        Me.ulDescTipoObra.Name = "ulDescTipoObra"
        Me.ulDescTipoObra.Size = New System.Drawing.Size(275, 23)
        Me.ulDescTipoObra.TabIndex = 168
        '
        'AdvIDTipoObra
        '
        Me.TryDataBinding(AdvIDTipoObra, New System.Windows.Forms.Binding("Text", Me, "IDTipoObra", True))
        Me.AdvIDTipoObra.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDTipoObra.EntityName = "ObraTipo"
        Me.AdvIDTipoObra.Location = New System.Drawing.Point(181, 7)
        Me.AdvIDTipoObra.Name = "AdvIDTipoObra"
        Me.AdvIDTipoObra.PrimaryDataFields = "IDTipoObra"
        Me.AdvIDTipoObra.SecondaryDataFields = "IDTipoObra"
        Me.AdvIDTipoObra.Size = New System.Drawing.Size(113, 23)
        Me.AdvIDTipoObra.TabIndex = 6
        Me.AdvIDTipoObra.ViewName = "tbObraTipo"
        '
        'TabPageTrabajos
        '
        Me.TabPageTrabajos.Controls.Add(Me.TabTrabajos)
        Me.TabPageTrabajos.Controls.Add(Me.Splitter1)
        Me.TabPageTrabajos.Controls.Add(Me.pnlTrabajos)
        Me.TabPageTrabajos.Key = "Trabajos"
        Me.TabPageTrabajos.Location = New System.Drawing.Point(1, 22)
        Me.TabPageTrabajos.Name = "TabPageTrabajos"
        Me.TabPageTrabajos.Size = New System.Drawing.Size(782, 531)
        Me.TabPageTrabajos.TabStop = True
        Me.TabPageTrabajos.Text = "Trabajos"
        '
        'TabTrabajos
        '
        Me.TabTrabajos.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.TabTrabajos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabTrabajos.Location = New System.Drawing.Point(275, 0)
        Me.TabTrabajos.Name = "TabTrabajos"
        Me.TabTrabajos.Size = New System.Drawing.Size(507, 531)
        Me.TabTrabajos.TabIndex = 2
        Me.TabTrabajos.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.TabPageDetalleTrabajos, Me.TabPagePrevistos, Me.TabPageControl, Me.TabPageHitos, Me.TabPageTareas, Me.TabPageOficios, Me.TabPageAvance})
        Me.TabTrabajos.TabStripAlignment = Janus.Windows.UI.Tab.TabStripAlignment.Right
        Me.TabTrabajos.UseThemes = True
        '
        'TabPageDetalleTrabajos
        '
        Me.TabPageDetalleTrabajos.Controls.Add(Me.pnlFichaTrabajo)
        Me.TabPageDetalleTrabajos.Controls.Add(Me.pnlTrabajosCompleto)
        Me.TabPageDetalleTrabajos.Controls.Add(Me.PnlTimeObras)
        Me.TabPageDetalleTrabajos.Controls.Add(Me.pnlGridTrabajo)
        Me.TabPageDetalleTrabajos.Key = "Trabajos"
        Me.TabPageDetalleTrabajos.Location = New System.Drawing.Point(1, 1)
        Me.TabPageDetalleTrabajos.Name = "TabPageDetalleTrabajos"
        Me.TabPageDetalleTrabajos.Size = New System.Drawing.Size(484, 529)
        Me.TabPageDetalleTrabajos.TabStop = True
        Me.TabPageDetalleTrabajos.Text = "Trabajos"
        '
        'pnlFichaTrabajo
        '
        Me.pnlFichaTrabajo.Controls.Add(Me.pnlFichaTrabajoFill)
        Me.pnlFichaTrabajo.Controls.Add(Me.FraImportesTrabajoFicha)
        Me.pnlFichaTrabajo.Controls.Add(Me.pnlFichaTrabajoTop)
        Me.pnlFichaTrabajo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFichaTrabajo.Location = New System.Drawing.Point(0, 0)
        Me.pnlFichaTrabajo.Name = "pnlFichaTrabajo"
        Me.pnlFichaTrabajo.Size = New System.Drawing.Size(484, 529)
        Me.pnlFichaTrabajo.TabIndex = 179
        '
        'pnlFichaTrabajoFill
        '
        Me.pnlFichaTrabajoFill.Controls.Add(Me.txtTextoTrabajo)
        Me.pnlFichaTrabajoFill.Controls.Add(Me.lblTextoTrabajo)
        Me.pnlFichaTrabajoFill.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFichaTrabajoFill.Location = New System.Drawing.Point(0, 439)
        Me.pnlFichaTrabajoFill.Name = "pnlFichaTrabajoFill"
        Me.pnlFichaTrabajoFill.Size = New System.Drawing.Size(484, 31)
        Me.pnlFichaTrabajoFill.TabIndex = 41
        '
        'txtTextoTrabajo
        '
        Me.txtTextoTrabajo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTextoTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.txtTextoTrabajo.Location = New System.Drawing.Point(90, 4)
        Me.txtTextoTrabajo.Multiline = True
        Me.txtTextoTrabajo.Name = "txtTextoTrabajo"
        Me.txtTextoTrabajo.Size = New System.Drawing.Size(387, 22)
        Me.txtTextoTrabajo.TabIndex = 53
        '
        'lblTextoTrabajo
        '
        Me.lblTextoTrabajo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTextoTrabajo.Location = New System.Drawing.Point(2, 7)
        Me.lblTextoTrabajo.Name = "lblTextoTrabajo"
        Me.lblTextoTrabajo.Size = New System.Drawing.Size(91, 13)
        Me.lblTextoTrabajo.TabIndex = 0
        Me.lblTextoTrabajo.Text = "Observaciones"
        '
        'FraImportesTrabajoFicha
        '
        Me.FraImportesTrabajoFicha.Controls.Add(Me.txtFacturadoTrabajo)
        Me.FraImportesTrabajoFicha.Controls.Add(Me.txtRealTrabajo)
        Me.FraImportesTrabajoFicha.Controls.Add(Me.txtPrevistoVentaTrabajo)
        Me.FraImportesTrabajoFicha.Controls.Add(Me.txtPrevistoTrabajo)
        Me.FraImportesTrabajoFicha.Controls.Add(Me.lblPrevTrabajo)
        Me.FraImportesTrabajoFicha.Controls.Add(Me.lblPrevVentaTrabajo)
        Me.FraImportesTrabajoFicha.Controls.Add(Me.lblRealTrabajo)
        Me.FraImportesTrabajoFicha.Controls.Add(Me.lblFactTrabajo)
        Me.FraImportesTrabajoFicha.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FraImportesTrabajoFicha.Location = New System.Drawing.Point(0, 470)
        Me.FraImportesTrabajoFicha.Name = "FraImportesTrabajoFicha"
        Me.FraImportesTrabajoFicha.Size = New System.Drawing.Size(484, 59)
        Me.FraImportesTrabajoFicha.TabIndex = 181
        Me.FraImportesTrabajoFicha.TabStop = False
        Me.FraImportesTrabajoFicha.Text = "Importes Trabajo (Importes Totales)"
        '
        'txtFacturadoTrabajo
        '
        Me.txtFacturadoTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.txtFacturadoTrabajo.Enabled = False
        Me.txtFacturadoTrabajo.Location = New System.Drawing.Point(360, 33)
        Me.txtFacturadoTrabajo.Name = "txtFacturadoTrabajo"
        Me.txtFacturadoTrabajo.Size = New System.Drawing.Size(113, 21)
        Me.txtFacturadoTrabajo.TabIndex = 148
        Me.txtFacturadoTrabajo.TabStop = False
        '
        'txtRealTrabajo
        '
        Me.txtRealTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.txtRealTrabajo.Enabled = False
        Me.txtRealTrabajo.Location = New System.Drawing.Point(243, 33)
        Me.txtRealTrabajo.Name = "txtRealTrabajo"
        Me.txtRealTrabajo.Size = New System.Drawing.Size(113, 21)
        Me.txtRealTrabajo.TabIndex = 147
        Me.txtRealTrabajo.TabStop = False
        '
        'txtPrevistoVentaTrabajo
        '
        Me.txtPrevistoVentaTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.txtPrevistoVentaTrabajo.Enabled = False
        Me.txtPrevistoVentaTrabajo.Location = New System.Drawing.Point(126, 33)
        Me.txtPrevistoVentaTrabajo.Name = "txtPrevistoVentaTrabajo"
        Me.txtPrevistoVentaTrabajo.Size = New System.Drawing.Size(113, 21)
        Me.txtPrevistoVentaTrabajo.TabIndex = 146
        Me.txtPrevistoVentaTrabajo.TabStop = False
        '
        'txtPrevistoTrabajo
        '
        Me.txtPrevistoTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.txtPrevistoTrabajo.Enabled = False
        Me.txtPrevistoTrabajo.Location = New System.Drawing.Point(9, 33)
        Me.txtPrevistoTrabajo.Name = "txtPrevistoTrabajo"
        Me.txtPrevistoTrabajo.Size = New System.Drawing.Size(113, 21)
        Me.txtPrevistoTrabajo.TabIndex = 145
        Me.txtPrevistoTrabajo.TabStop = False
        '
        'lblPrevTrabajo
        '
        Me.lblPrevTrabajo.AutoSize = False
        Me.lblPrevTrabajo.Location = New System.Drawing.Point(9, 18)
        Me.lblPrevTrabajo.Name = "lblPrevTrabajo"
        Me.lblPrevTrabajo.Size = New System.Drawing.Size(113, 13)
        Me.lblPrevTrabajo.TabIndex = 139
        Me.lblPrevTrabajo.Text = "Previsto"
        Me.lblPrevTrabajo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPrevVentaTrabajo
        '
        Me.lblPrevVentaTrabajo.AutoSize = False
        Me.lblPrevVentaTrabajo.Location = New System.Drawing.Point(126, 18)
        Me.lblPrevVentaTrabajo.Name = "lblPrevVentaTrabajo"
        Me.lblPrevVentaTrabajo.Size = New System.Drawing.Size(113, 13)
        Me.lblPrevVentaTrabajo.TabIndex = 141
        Me.lblPrevVentaTrabajo.Text = "Previsto Venta"
        Me.lblPrevVentaTrabajo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblRealTrabajo
        '
        Me.lblRealTrabajo.AutoSize = False
        Me.lblRealTrabajo.Location = New System.Drawing.Point(243, 18)
        Me.lblRealTrabajo.Name = "lblRealTrabajo"
        Me.lblRealTrabajo.Size = New System.Drawing.Size(113, 13)
        Me.lblRealTrabajo.TabIndex = 142
        Me.lblRealTrabajo.Text = " Real"
        Me.lblRealTrabajo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFactTrabajo
        '
        Me.lblFactTrabajo.AutoSize = False
        Me.lblFactTrabajo.Location = New System.Drawing.Point(360, 18)
        Me.lblFactTrabajo.Name = "lblFactTrabajo"
        Me.lblFactTrabajo.Size = New System.Drawing.Size(113, 13)
        Me.lblFactTrabajo.TabIndex = 143
        Me.lblFactTrabajo.Text = "Facturado"
        Me.lblFactTrabajo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlFichaTrabajoTop
        '
        Me.pnlFichaTrabajoTop.Controls.Add(Me.FraPeriodificacion)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.lblQUnitaria)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.ntxQUnidad)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.chkPlanificarRecursosPorTareas)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.lblEstadoTrabajo)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.cbxEstadoTrabajo)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.Label7)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.txtMargenTrabajoFicha)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.chkNoAcumular)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.AdvSubSubTipoTrabajo)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.lblSubSubTipoTrabajo)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.cbxTipoLinea)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.lblQReal)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.txtQReal)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.lblQPrevResponsable)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.txtQPrevResponsable)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.Label1)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.cbxTipoCoste)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.AdvSubTipoTrabajo)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.AdvTipoTrabajo)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.lblTipoLinea)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.FraSeguimiento)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.lblIDArticulo)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.AdvIDArticulo)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.lblQCertificada)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.txtQCertificada)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.chkFacturable)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.lblTipoFacturacion)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.cbxTipoFacturacion)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.lblUDMedida)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.lblQPrev)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.lblCodTrabajo)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.cbxIDUDMedida)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.lblImpUnitarioVta)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.txtImpUnitarioVta)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.lblImpUnitario)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.txtImpUnitario)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.txtQPrev)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.txtDescTrabajo)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.lblTipoTrabajo)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.lblSubTipoTrabajo)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.txtCodTrabajo)
        Me.pnlFichaTrabajoTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFichaTrabajoTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlFichaTrabajoTop.Name = "pnlFichaTrabajoTop"
        Me.pnlFichaTrabajoTop.Size = New System.Drawing.Size(484, 439)
        Me.pnlFichaTrabajoTop.TabIndex = 178
        '
        'FraPeriodificacion
        '
        Me.FraPeriodificacion.Controls.Add(Me.ntxPorcIncrDecrPerido)
        Me.FraPeriodificacion.Controls.Add(Me.lblPorcIncrDecrPerido)
        Me.FraPeriodificacion.Controls.Add(Me.chkAplicarSobreUltimo)
        Me.FraPeriodificacion.Controls.Add(Me.cbxTipoPeriodoPeriodificacion)
        Me.FraPeriodificacion.Controls.Add(Me.chkPeriodificable)
        Me.FraPeriodificacion.Controls.Add(Me.lblPeridoPeriodificacion)
        Me.FraPeriodificacion.Controls.Add(Me.lblTipoPeriodoPeriodificacion)
        Me.FraPeriodificacion.Controls.Add(Me.ntxPeriodoPeriodificacion)
        Me.FraPeriodificacion.Location = New System.Drawing.Point(2, 370)
        Me.FraPeriodificacion.Name = "FraPeriodificacion"
        Me.FraPeriodificacion.Size = New System.Drawing.Size(476, 68)
        Me.FraPeriodificacion.TabIndex = 40
        Me.FraPeriodificacion.TabStop = False
        Me.FraPeriodificacion.Text = "Periodificación"
        '
        'ntxPorcIncrDecrPerido
        '
        Me.ntxPorcIncrDecrPerido.DisabledBackColor = System.Drawing.Color.White
        Me.ntxPorcIncrDecrPerido.Location = New System.Drawing.Point(184, 43)
        Me.ntxPorcIncrDecrPerido.Name = "ntxPorcIncrDecrPerido"
        Me.ntxPorcIncrDecrPerido.Size = New System.Drawing.Size(49, 21)
        Me.ntxPorcIncrDecrPerido.TabIndex = 345
        '
        'lblPorcIncrDecrPerido
        '
        Me.lblPorcIncrDecrPerido.Location = New System.Drawing.Point(121, 47)
        Me.lblPorcIncrDecrPerido.Name = "lblPorcIncrDecrPerido"
        Me.lblPorcIncrDecrPerido.Size = New System.Drawing.Size(164, 13)
        Me.lblPorcIncrDecrPerido.TabIndex = 346
        Me.lblPorcIncrDecrPerido.Text = "% Incremento/Decremento"
        '
        'chkAplicarSobreUltimo
        '
        Me.chkAplicarSobreUltimo.Location = New System.Drawing.Point(295, 44)
        Me.chkAplicarSobreUltimo.Name = "chkAplicarSobreUltimo"
        Me.chkAplicarSobreUltimo.Size = New System.Drawing.Size(182, 18)
        Me.chkAplicarSobreUltimo.TabIndex = 3
        Me.chkAplicarSobreUltimo.Text = "Aplicar sobre último periodo"
        '
        'cbxTipoPeriodoPeriodificacion
        '
        cbxTipoPeriodoPeriodificacion_DesignTimeLayout.LayoutString = resources.GetString("cbxTipoPeriodoPeriodificacion_DesignTimeLayout.LayoutString")
        Me.cbxTipoPeriodoPeriodificacion.DesignTimeLayout = cbxTipoPeriodoPeriodificacion_DesignTimeLayout
        Me.cbxTipoPeriodoPeriodificacion.DisabledBackColor = System.Drawing.Color.White
        Me.cbxTipoPeriodoPeriodificacion.Location = New System.Drawing.Point(324, 18)
        Me.cbxTipoPeriodoPeriodificacion.Name = "cbxTipoPeriodoPeriodificacion"
        Me.cbxTipoPeriodoPeriodificacion.SelectedIndex = -1
        Me.cbxTipoPeriodoPeriodificacion.SelectedItem = Nothing
        Me.cbxTipoPeriodoPeriodificacion.Size = New System.Drawing.Size(64, 21)
        Me.cbxTipoPeriodoPeriodificacion.TabIndex = 2
        '
        'chkPeriodificable
        '
        Me.chkPeriodificable.Location = New System.Drawing.Point(14, 14)
        Me.chkPeriodificable.Name = "chkPeriodificable"
        Me.chkPeriodificable.Size = New System.Drawing.Size(104, 23)
        Me.chkPeriodificable.TabIndex = 0
        Me.chkPeriodificable.Text = "Periodificable"
        '
        'lblPeridoPeriodificacion
        '
        Me.lblPeridoPeriodificacion.Location = New System.Drawing.Point(121, 20)
        Me.lblPeridoPeriodificacion.Name = "lblPeridoPeriodificacion"
        Me.lblPeridoPeriodificacion.Size = New System.Drawing.Size(50, 13)
        Me.lblPeridoPeriodificacion.TabIndex = 250
        Me.lblPeridoPeriodificacion.Text = "Periodo"
        '
        'lblTipoPeriodoPeriodificacion
        '
        Me.lblTipoPeriodoPeriodificacion.Location = New System.Drawing.Point(259, 22)
        Me.lblTipoPeriodoPeriodificacion.Name = "lblTipoPeriodoPeriodificacion"
        Me.lblTipoPeriodoPeriodificacion.Size = New System.Drawing.Size(78, 13)
        Me.lblTipoPeriodoPeriodificacion.TabIndex = 249
        Me.lblTipoPeriodoPeriodificacion.Text = "Tipo periodo"
        '
        'ntxPeriodoPeriodificacion
        '
        Me.ntxPeriodoPeriodificacion.DisabledBackColor = System.Drawing.Color.White
        Me.ntxPeriodoPeriodificacion.FormatString = "#"
        Me.ntxPeriodoPeriodificacion.Location = New System.Drawing.Point(184, 18)
        Me.ntxPeriodoPeriodificacion.Name = "ntxPeriodoPeriodificacion"
        Me.ntxPeriodoPeriodificacion.NullBehavior = Janus.Windows.GridEX.NumericEditNullBehavior.AllowNull
        Me.ntxPeriodoPeriodificacion.Size = New System.Drawing.Size(49, 21)
        Me.ntxPeriodoPeriodificacion.TabIndex = 1
        '
        'lblQUnitaria
        '
        Me.lblQUnitaria.Location = New System.Drawing.Point(2, 106)
        Me.lblQUnitaria.Name = "lblQUnitaria"
        Me.lblQUnitaria.Size = New System.Drawing.Size(68, 13)
        Me.lblQUnitaria.TabIndex = 348
        Me.lblQUnitaria.Text = "C. Unitaria"
        '
        'ntxQUnidad
        '
        Me.ntxQUnidad.DisabledBackColor = System.Drawing.Color.White
        Me.ntxQUnidad.Location = New System.Drawing.Point(90, 103)
        Me.ntxQUnidad.Name = "ntxQUnidad"
        Me.ntxQUnidad.Size = New System.Drawing.Size(56, 21)
        Me.ntxQUnidad.TabIndex = 26
        '
        'chkPlanificarRecursosPorTareas
        '
        Me.chkPlanificarRecursosPorTareas.Location = New System.Drawing.Point(264, 205)
        Me.chkPlanificarRecursosPorTareas.Name = "chkPlanificarRecursosPorTareas"
        Me.chkPlanificarRecursosPorTareas.Size = New System.Drawing.Size(214, 21)
        Me.chkPlanificarRecursosPorTareas.TabIndex = 38
        Me.chkPlanificarRecursosPorTareas.Text = "Planificar Recursos Por Tareas"
        '
        'lblEstadoTrabajo
        '
        Me.lblEstadoTrabajo.Location = New System.Drawing.Point(303, 183)
        Me.lblEstadoTrabajo.Name = "lblEstadoTrabajo"
        Me.lblEstadoTrabajo.Size = New System.Drawing.Size(45, 13)
        Me.lblEstadoTrabajo.TabIndex = 346
        Me.lblEstadoTrabajo.Text = "Estado"
        '
        'cbxEstadoTrabajo
        '
        Me.cbxEstadoTrabajo.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList
        cbxEstadoTrabajo_DesignTimeLayout.LayoutString = resources.GetString("cbxEstadoTrabajo_DesignTimeLayout.LayoutString")
        Me.cbxEstadoTrabajo.DesignTimeLayout = cbxEstadoTrabajo_DesignTimeLayout
        Me.cbxEstadoTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.cbxEstadoTrabajo.DisplayMember = "Value"
        Me.cbxEstadoTrabajo.Location = New System.Drawing.Point(354, 179)
        Me.cbxEstadoTrabajo.Name = "cbxEstadoTrabajo"
        Me.cbxEstadoTrabajo.PrimaryDataFields = "Estado"
        Me.cbxEstadoTrabajo.SecondaryDataFields = "Value"
        Me.cbxEstadoTrabajo.SelectedIndex = -1
        Me.cbxEstadoTrabajo.SelectedItem = Nothing
        Me.cbxEstadoTrabajo.Size = New System.Drawing.Size(125, 21)
        Me.cbxEstadoTrabajo.TabIndex = 36
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(179, 132)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 342
        Me.Label7.Text = "% Prev."
        '
        'txtMargenTrabajoFicha
        '
        Me.txtMargenTrabajoFicha.DisabledBackColor = System.Drawing.Color.White
        Me.txtMargenTrabajoFicha.Enabled = False
        Me.txtMargenTrabajoFicha.Location = New System.Drawing.Point(234, 128)
        Me.txtMargenTrabajoFicha.Name = "txtMargenTrabajoFicha"
        Me.txtMargenTrabajoFicha.Size = New System.Drawing.Size(43, 21)
        Me.txtMargenTrabajoFicha.TabIndex = 30
        '
        'chkNoAcumular
        '
        Me.chkNoAcumular.Location = New System.Drawing.Point(383, 101)
        Me.chkNoAcumular.Name = "chkNoAcumular"
        Me.chkNoAcumular.Size = New System.Drawing.Size(92, 21)
        Me.chkNoAcumular.TabIndex = 28
        Me.chkNoAcumular.Text = "No Acumular"
        '
        'AdvSubSubTipoTrabajo
        '
        Me.AdvSubSubTipoTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvSubSubTipoTrabajo.EntityName = "ObraSubSubtipoTrabajo"
        Me.AdvSubSubTipoTrabajo.Location = New System.Drawing.Point(403, 3)
        Me.AdvSubSubTipoTrabajo.Name = "AdvSubSubTipoTrabajo"
        Me.AdvSubSubTipoTrabajo.SecondaryDataFields = "IDSubSubtipoTrabajo"
        Me.AdvSubSubTipoTrabajo.Size = New System.Drawing.Size(76, 23)
        Me.AdvSubSubTipoTrabajo.TabIndex = 19
        '
        'lblSubSubTipoTrabajo
        '
        Me.lblSubSubTipoTrabajo.Location = New System.Drawing.Point(323, 8)
        Me.lblSubSubTipoTrabajo.Name = "lblSubSubTipoTrabajo"
        Me.lblSubSubTipoTrabajo.Size = New System.Drawing.Size(75, 13)
        Me.lblSubSubTipoTrabajo.TabIndex = 243
        Me.lblSubSubTipoTrabajo.Text = "SubSubTipo"
        '
        'cbxTipoLinea
        '
        Me.cbxTipoLinea.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList
        cbxTipoLinea_DesignTimeLayout.LayoutString = resources.GetString("cbxTipoLinea_DesignTimeLayout.LayoutString")
        Me.cbxTipoLinea.DesignTimeLayout = cbxTipoLinea_DesignTimeLayout
        Me.cbxTipoLinea.DisabledBackColor = System.Drawing.Color.White
        Me.cbxTipoLinea.Location = New System.Drawing.Point(264, 78)
        Me.cbxTipoLinea.Name = "cbxTipoLinea"
        Me.cbxTipoLinea.SelectedIndex = -1
        Me.cbxTipoLinea.SelectedItem = Nothing
        Me.cbxTipoLinea.Size = New System.Drawing.Size(114, 21)
        Me.cbxTipoLinea.TabIndex = 24
        '
        'lblQReal
        '
        Me.lblQReal.Location = New System.Drawing.Point(149, 157)
        Me.lblQReal.Name = "lblQReal"
        Me.lblQReal.Size = New System.Drawing.Size(49, 13)
        Me.lblQReal.TabIndex = 220
        Me.lblQReal.Text = "C. Real"
        '
        'txtQReal
        '
        Me.txtQReal.DisabledBackColor = System.Drawing.Color.White
        Me.txtQReal.Enabled = False
        Me.txtQReal.Location = New System.Drawing.Point(203, 153)
        Me.txtQReal.Name = "txtQReal"
        Me.txtQReal.Size = New System.Drawing.Size(56, 21)
        Me.txtQReal.TabIndex = 33
        Me.txtQReal.TabStop = False
        '
        'lblQPrevResponsable
        '
        Me.lblQPrevResponsable.Location = New System.Drawing.Point(295, 155)
        Me.lblQPrevResponsable.Name = "lblQPrevResponsable"
        Me.lblQPrevResponsable.Size = New System.Drawing.Size(129, 13)
        Me.lblQPrevResponsable.TabIndex = 218
        Me.lblQPrevResponsable.Text = "C. Prev. Responsable"
        '
        'txtQPrevResponsable
        '
        Me.txtQPrevResponsable.DisabledBackColor = System.Drawing.Color.White
        Me.txtQPrevResponsable.Location = New System.Drawing.Point(428, 152)
        Me.txtQPrevResponsable.Name = "txtQPrevResponsable"
        Me.txtQPrevResponsable.Size = New System.Drawing.Size(51, 21)
        Me.txtQPrevResponsable.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(2, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 214
        Me.Label1.Text = "Tipo Coste"
        '
        'cbxTipoCoste
        '
        Me.cbxTipoCoste.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList
        cbxTipoCoste_DesignTimeLayout.LayoutString = resources.GetString("cbxTipoCoste_DesignTimeLayout.LayoutString")
        Me.cbxTipoCoste.DesignTimeLayout = cbxTipoCoste_DesignTimeLayout
        Me.cbxTipoCoste.DisabledBackColor = System.Drawing.Color.White
        Me.cbxTipoCoste.DisplayMember = "Value"
        Me.cbxTipoCoste.Location = New System.Drawing.Point(90, 78)
        Me.cbxTipoCoste.Name = "cbxTipoCoste"
        Me.cbxTipoCoste.PrimaryDataFields = "Estado"
        Me.cbxTipoCoste.SecondaryDataFields = "Value"
        Me.cbxTipoCoste.SelectedIndex = -1
        Me.cbxTipoCoste.SelectedItem = Nothing
        Me.cbxTipoCoste.Size = New System.Drawing.Size(97, 21)
        Me.cbxTipoCoste.TabIndex = 23
        '
        'AdvSubTipoTrabajo
        '
        Me.AdvSubTipoTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvSubTipoTrabajo.EntityName = "ObraSubtipoTrabajo"
        Me.AdvSubTipoTrabajo.Location = New System.Drawing.Point(235, 3)
        Me.AdvSubTipoTrabajo.Name = "AdvSubTipoTrabajo"
        Me.AdvSubTipoTrabajo.PrimaryDataFields = "IDSubtipoTrabajo"
        Me.AdvSubTipoTrabajo.SecondaryDataFields = "IDSubtipoTrabajo"
        Me.AdvSubTipoTrabajo.Size = New System.Drawing.Size(77, 23)
        Me.AdvSubTipoTrabajo.TabIndex = 18
        '
        'AdvTipoTrabajo
        '
        Me.AdvTipoTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvTipoTrabajo.EntityName = "ObraTipoTrabajo"
        Me.AdvTipoTrabajo.Location = New System.Drawing.Point(90, 3)
        Me.AdvTipoTrabajo.Name = "AdvTipoTrabajo"
        Me.AdvTipoTrabajo.PrimaryDataFields = "IDTipoTrabajo"
        Me.AdvTipoTrabajo.SecondaryDataFields = "IDTipoTrabajo"
        Me.AdvTipoTrabajo.Size = New System.Drawing.Size(77, 23)
        Me.AdvTipoTrabajo.TabIndex = 17
        '
        'lblTipoLinea
        '
        Me.lblTipoLinea.Location = New System.Drawing.Point(195, 82)
        Me.lblTipoLinea.Name = "lblTipoLinea"
        Me.lblTipoLinea.Size = New System.Drawing.Size(65, 13)
        Me.lblTipoLinea.TabIndex = 212
        Me.lblTipoLinea.Text = "Tipo Línea"
        '
        'FraSeguimiento
        '
        Me.FraSeguimiento.Controls.Add(Me.lblIncremento)
        Me.FraSeguimiento.Controls.Add(Me.txtIncremento)
        Me.FraSeguimiento.Controls.Add(Me.lblTrabajoPresup)
        Me.FraSeguimiento.Controls.Add(Me.AdvTrabajoPresup)
        Me.FraSeguimiento.Controls.Add(Me.txtDuracionPrev)
        Me.FraSeguimiento.Controls.Add(Me.txtNivelTrabajo)
        Me.FraSeguimiento.Controls.Add(Me.lblNivelTrabajo)
        Me.FraSeguimiento.Controls.Add(Me.FraFechasTrabajo)
        Me.FraSeguimiento.Controls.Add(Me.lblCentroGestionTrabajo)
        Me.FraSeguimiento.Controls.Add(Me.cbxIDCentroGestion)
        Me.FraSeguimiento.Controls.Add(Me.lblNumPedido)
        Me.FraSeguimiento.Controls.Add(Me.txtNumPedido)
        Me.FraSeguimiento.Controls.Add(Me.lblSolapeAnt)
        Me.FraSeguimiento.Controls.Add(Me.txtSolapeAnt)
        Me.FraSeguimiento.Controls.Add(Me.lblSecuencia)
        Me.FraSeguimiento.Controls.Add(Me.txtSecuencia)
        Me.FraSeguimiento.Controls.Add(Me.lblDuracionPrev)
        Me.FraSeguimiento.Controls.Add(Me.FraAvance)
        Me.FraSeguimiento.Location = New System.Drawing.Point(2, 227)
        Me.FraSeguimiento.Name = "FraSeguimiento"
        Me.FraSeguimiento.Size = New System.Drawing.Size(476, 143)
        Me.FraSeguimiento.TabIndex = 39
        Me.FraSeguimiento.TabStop = False
        Me.FraSeguimiento.Text = "Seguimiento"
        '
        'lblIncremento
        '
        Me.lblIncremento.Location = New System.Drawing.Point(8, 20)
        Me.lblIncremento.Name = "lblIncremento"
        Me.lblIncremento.Size = New System.Drawing.Size(73, 13)
        Me.lblIncremento.TabIndex = 344
        Me.lblIncremento.Text = "Incremento"
        '
        'txtIncremento
        '
        Me.txtIncremento.DisabledBackColor = System.Drawing.Color.White
        Me.txtIncremento.Location = New System.Drawing.Point(87, 16)
        Me.txtIncremento.Name = "txtIncremento"
        Me.txtIncremento.Size = New System.Drawing.Size(95, 21)
        Me.txtIncremento.TabIndex = 39
        '
        'lblTrabajoPresup
        '
        Me.lblTrabajoPresup.Location = New System.Drawing.Point(244, 21)
        Me.lblTrabajoPresup.Name = "lblTrabajoPresup"
        Me.lblTrabajoPresup.Size = New System.Drawing.Size(97, 13)
        Me.lblTrabajoPresup.TabIndex = 218
        Me.lblTrabajoPresup.Text = "Trabajo Presup."
        '
        'AdvTrabajoPresup
        '
        Me.AdvTrabajoPresup.DisabledBackColor = System.Drawing.Color.White
        Me.AdvTrabajoPresup.DisplayField = "CodTrabajo"
        Me.AdvTrabajoPresup.EntityName = "ObraTrabajoPresup"
        Me.AdvTrabajoPresup.Location = New System.Drawing.Point(345, 16)
        Me.AdvTrabajoPresup.Name = "AdvTrabajoPresup"
        Me.AdvTrabajoPresup.PrimaryDataFields = "IDTrabajoPresup"
        Me.AdvTrabajoPresup.SecondaryDataFields = "IDTrabajoPresup"
        Me.AdvTrabajoPresup.Size = New System.Drawing.Size(125, 23)
        Me.AdvTrabajoPresup.TabIndex = 40
        '
        'txtDuracionPrev
        '
        Me.txtDuracionPrev.DisabledBackColor = System.Drawing.Color.White
        Me.txtDuracionPrev.Location = New System.Drawing.Point(87, 66)
        Me.txtDuracionPrev.Name = "txtDuracionPrev"
        Me.txtDuracionPrev.Size = New System.Drawing.Size(68, 21)
        Me.txtDuracionPrev.TabIndex = 42
        '
        'txtNivelTrabajo
        '
        Me.txtNivelTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.txtNivelTrabajo.Enabled = False
        Me.txtNivelTrabajo.Location = New System.Drawing.Point(87, 116)
        Me.txtNivelTrabajo.Name = "txtNivelTrabajo"
        Me.txtNivelTrabajo.Size = New System.Drawing.Size(68, 21)
        Me.txtNivelTrabajo.TabIndex = 44
        Me.txtNivelTrabajo.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        '
        'lblNivelTrabajo
        '
        Me.lblNivelTrabajo.Location = New System.Drawing.Point(8, 120)
        Me.lblNivelTrabajo.Name = "lblNivelTrabajo"
        Me.lblNivelTrabajo.Size = New System.Drawing.Size(35, 13)
        Me.lblNivelTrabajo.TabIndex = 184
        Me.lblNivelTrabajo.Text = "Nivel"
        '
        'FraFechasTrabajo
        '
        Me.FraFechasTrabajo.Controls.Add(Me.lblFechaFinTrabajo)
        Me.FraFechasTrabajo.Controls.Add(Me.cbxFechaFinTrabajo)
        Me.FraFechasTrabajo.Controls.Add(Me.lblFechaInicioTrabajo)
        Me.FraFechasTrabajo.Controls.Add(Me.cbxFechaInicioTrabajo)
        Me.FraFechasTrabajo.Location = New System.Drawing.Point(319, 39)
        Me.FraFechasTrabajo.Name = "FraFechasTrabajo"
        Me.FraFechasTrabajo.Size = New System.Drawing.Size(153, 74)
        Me.FraFechasTrabajo.TabIndex = 49
        Me.FraFechasTrabajo.TabStop = False
        Me.FraFechasTrabajo.Text = "Fechas"
        '
        'lblFechaFinTrabajo
        '
        Me.lblFechaFinTrabajo.Location = New System.Drawing.Point(9, 48)
        Me.lblFechaFinTrabajo.Name = "lblFechaFinTrabajo"
        Me.lblFechaFinTrabajo.Size = New System.Drawing.Size(23, 13)
        Me.lblFechaFinTrabajo.TabIndex = 183
        Me.lblFechaFinTrabajo.Text = "Fin"
        '
        'cbxFechaFinTrabajo
        '
        Me.cbxFechaFinTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaFinTrabajo.Location = New System.Drawing.Point(49, 44)
        Me.cbxFechaFinTrabajo.Name = "cbxFechaFinTrabajo"
        Me.cbxFechaFinTrabajo.Size = New System.Drawing.Size(97, 21)
        Me.cbxFechaFinTrabajo.TabIndex = 51
        '
        'lblFechaInicioTrabajo
        '
        Me.lblFechaInicioTrabajo.Location = New System.Drawing.Point(9, 23)
        Me.lblFechaInicioTrabajo.Name = "lblFechaInicioTrabajo"
        Me.lblFechaInicioTrabajo.Size = New System.Drawing.Size(38, 13)
        Me.lblFechaInicioTrabajo.TabIndex = 184
        Me.lblFechaInicioTrabajo.Text = "Inicio"
        '
        'cbxFechaInicioTrabajo
        '
        Me.cbxFechaInicioTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaInicioTrabajo.Location = New System.Drawing.Point(49, 19)
        Me.cbxFechaInicioTrabajo.Name = "cbxFechaInicioTrabajo"
        Me.cbxFechaInicioTrabajo.Size = New System.Drawing.Size(97, 21)
        Me.cbxFechaInicioTrabajo.TabIndex = 50
        '
        'lblCentroGestionTrabajo
        '
        Me.lblCentroGestionTrabajo.Location = New System.Drawing.Point(312, 120)
        Me.lblCentroGestionTrabajo.Name = "lblCentroGestionTrabajo"
        Me.lblCentroGestionTrabajo.Size = New System.Drawing.Size(67, 13)
        Me.lblCentroGestionTrabajo.TabIndex = 182
        Me.lblCentroGestionTrabajo.Text = "C. Gestión"
        '
        'cbxIDCentroGestion
        '
        cbxIDCentroGestion_DesignTimeLayout.LayoutString = resources.GetString("cbxIDCentroGestion_DesignTimeLayout.LayoutString")
        Me.cbxIDCentroGestion.DesignTimeLayout = cbxIDCentroGestion_DesignTimeLayout
        Me.cbxIDCentroGestion.DisabledBackColor = System.Drawing.Color.White
        Me.cbxIDCentroGestion.DisplayMember = "IDCentroGestion"
        Me.cbxIDCentroGestion.EntityName = "CentroGestion"
        Me.cbxIDCentroGestion.Location = New System.Drawing.Point(379, 116)
        Me.cbxIDCentroGestion.Name = "cbxIDCentroGestion"
        Me.cbxIDCentroGestion.PrimaryDataFields = "IDCentroGestion"
        Me.cbxIDCentroGestion.SecondaryDataFields = "IDCentroGestion"
        Me.cbxIDCentroGestion.SelectedIndex = -1
        Me.cbxIDCentroGestion.SelectedItem = Nothing
        Me.cbxIDCentroGestion.Size = New System.Drawing.Size(91, 21)
        Me.cbxIDCentroGestion.TabIndex = 52
        Me.cbxIDCentroGestion.ValueMember = "IDCentroGestion"
        Me.cbxIDCentroGestion.ViewName = "tbMaestroCentroGestion"
        '
        'lblNumPedido
        '
        Me.lblNumPedido.Location = New System.Drawing.Point(167, 120)
        Me.lblNumPedido.Name = "lblNumPedido"
        Me.lblNumPedido.Size = New System.Drawing.Size(45, 13)
        Me.lblNumPedido.TabIndex = 147
        Me.lblNumPedido.Text = "Pedido"
        '
        'txtNumPedido
        '
        Me.txtNumPedido.DisabledBackColor = System.Drawing.Color.White
        Me.txtNumPedido.Location = New System.Drawing.Point(217, 116)
        Me.txtNumPedido.Name = "txtNumPedido"
        Me.txtNumPedido.Size = New System.Drawing.Size(87, 21)
        Me.txtNumPedido.TabIndex = 48
        '
        'lblSolapeAnt
        '
        Me.lblSolapeAnt.Location = New System.Drawing.Point(8, 95)
        Me.lblSolapeAnt.Name = "lblSolapeAnt"
        Me.lblSolapeAnt.Size = New System.Drawing.Size(46, 13)
        Me.lblSolapeAnt.TabIndex = 143
        Me.lblSolapeAnt.Text = "Solape"
        '
        'txtSolapeAnt
        '
        Me.txtSolapeAnt.DisabledBackColor = System.Drawing.Color.White
        Me.txtSolapeAnt.Location = New System.Drawing.Point(87, 91)
        Me.txtSolapeAnt.Name = "txtSolapeAnt"
        Me.txtSolapeAnt.Size = New System.Drawing.Size(68, 21)
        Me.txtSolapeAnt.TabIndex = 43
        Me.txtSolapeAnt.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        '
        'lblSecuencia
        '
        Me.lblSecuencia.Location = New System.Drawing.Point(8, 45)
        Me.lblSecuencia.Name = "lblSecuencia"
        Me.lblSecuencia.Size = New System.Drawing.Size(65, 13)
        Me.lblSecuencia.TabIndex = 144
        Me.lblSecuencia.Text = "Secuencia"
        '
        'txtSecuencia
        '
        Me.txtSecuencia.DisabledBackColor = System.Drawing.Color.White
        Me.txtSecuencia.Location = New System.Drawing.Point(87, 41)
        Me.txtSecuencia.Name = "txtSecuencia"
        Me.txtSecuencia.Size = New System.Drawing.Size(68, 21)
        Me.txtSecuencia.TabIndex = 41
        Me.txtSecuencia.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        '
        'lblDuracionPrev
        '
        Me.lblDuracionPrev.Location = New System.Drawing.Point(8, 70)
        Me.lblDuracionPrev.Name = "lblDuracionPrev"
        Me.lblDuracionPrev.Size = New System.Drawing.Size(62, 13)
        Me.lblDuracionPrev.TabIndex = 145
        Me.lblDuracionPrev.Text = "Duración "
        '
        'FraAvance
        '
        Me.FraAvance.Controls.Add(Me.lblAvanceCalculado)
        Me.FraAvance.Controls.Add(Me.txtAvanceCalculado)
        Me.FraAvance.Controls.Add(Me.lblAvanceEstimado)
        Me.FraAvance.Controls.Add(Me.txtAvanceEstimado)
        Me.FraAvance.Location = New System.Drawing.Point(161, 39)
        Me.FraAvance.Name = "FraAvance"
        Me.FraAvance.Size = New System.Drawing.Size(155, 74)
        Me.FraAvance.TabIndex = 45
        Me.FraAvance.TabStop = False
        Me.FraAvance.Text = "Avances "
        '
        'lblAvanceCalculado
        '
        Me.lblAvanceCalculado.Location = New System.Drawing.Point(9, 49)
        Me.lblAvanceCalculado.Name = "lblAvanceCalculado"
        Me.lblAvanceCalculado.Size = New System.Drawing.Size(63, 13)
        Me.lblAvanceCalculado.TabIndex = 0
        Me.lblAvanceCalculado.Text = "Calculado"
        '
        'txtAvanceCalculado
        '
        Me.txtAvanceCalculado.DisabledBackColor = System.Drawing.Color.White
        Me.txtAvanceCalculado.Enabled = False
        Me.txtAvanceCalculado.Location = New System.Drawing.Point(75, 45)
        Me.txtAvanceCalculado.Name = "txtAvanceCalculado"
        Me.txtAvanceCalculado.Size = New System.Drawing.Size(72, 21)
        Me.txtAvanceCalculado.TabIndex = 47
        Me.txtAvanceCalculado.TabStop = False
        '
        'lblAvanceEstimado
        '
        Me.lblAvanceEstimado.Location = New System.Drawing.Point(9, 24)
        Me.lblAvanceEstimado.Name = "lblAvanceEstimado"
        Me.lblAvanceEstimado.Size = New System.Drawing.Size(59, 13)
        Me.lblAvanceEstimado.TabIndex = 78
        Me.lblAvanceEstimado.Text = "Estimado"
        '
        'txtAvanceEstimado
        '
        Me.txtAvanceEstimado.DisabledBackColor = System.Drawing.Color.White
        Me.txtAvanceEstimado.Location = New System.Drawing.Point(75, 20)
        Me.txtAvanceEstimado.Name = "txtAvanceEstimado"
        Me.txtAvanceEstimado.Size = New System.Drawing.Size(72, 21)
        Me.txtAvanceEstimado.TabIndex = 46
        '
        'lblIDArticulo
        '
        Me.lblIDArticulo.Location = New System.Drawing.Point(2, 208)
        Me.lblIDArticulo.Name = "lblIDArticulo"
        Me.lblIDArticulo.Size = New System.Drawing.Size(50, 13)
        Me.lblIDArticulo.TabIndex = 206
        Me.lblIDArticulo.Text = "Artículo"
        '
        'AdvIDArticulo
        '
        Me.AdvIDArticulo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDArticulo.EntityName = "Articulo"
        Me.AdvIDArticulo.Location = New System.Drawing.Point(90, 203)
        Me.AdvIDArticulo.Name = "AdvIDArticulo"
        Me.AdvIDArticulo.PrimaryDataFields = "IDArticulo"
        Me.AdvIDArticulo.SecondaryDataFields = "IDArticulo"
        Me.AdvIDArticulo.Size = New System.Drawing.Size(125, 23)
        Me.AdvIDArticulo.TabIndex = 37
        '
        'lblQCertificada
        '
        Me.lblQCertificada.Location = New System.Drawing.Point(2, 157)
        Me.lblQCertificada.Name = "lblQCertificada"
        Me.lblQCertificada.Size = New System.Drawing.Size(86, 13)
        Me.lblQCertificada.TabIndex = 204
        Me.lblQCertificada.Text = "C. Certificada"
        '
        'txtQCertificada
        '
        Me.txtQCertificada.DisabledBackColor = System.Drawing.Color.White
        Me.txtQCertificada.Enabled = False
        Me.txtQCertificada.Location = New System.Drawing.Point(90, 153)
        Me.txtQCertificada.Name = "txtQCertificada"
        Me.txtQCertificada.Size = New System.Drawing.Size(56, 21)
        Me.txtQCertificada.TabIndex = 32
        Me.txtQCertificada.Visible = False
        '
        'chkFacturable
        '
        Me.chkFacturable.Location = New System.Drawing.Point(383, 78)
        Me.chkFacturable.Name = "chkFacturable"
        Me.chkFacturable.Size = New System.Drawing.Size(83, 20)
        Me.chkFacturable.TabIndex = 25
        Me.chkFacturable.Text = "Facturable"
        '
        'lblTipoFacturacion
        '
        Me.lblTipoFacturacion.AutoSize = False
        Me.lblTipoFacturacion.Location = New System.Drawing.Point(1, 175)
        Me.lblTipoFacturacion.Name = "lblTipoFacturacion"
        Me.lblTipoFacturacion.Size = New System.Drawing.Size(81, 24)
        Me.lblTipoFacturacion.TabIndex = 200
        Me.lblTipoFacturacion.Text = "Tipo Facturación"
        '
        'cbxTipoFacturacion
        '
        Me.cbxTipoFacturacion.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList
        cbxTipoFacturacion_DesignTimeLayout.LayoutString = resources.GetString("cbxTipoFacturacion_DesignTimeLayout.LayoutString")
        Me.cbxTipoFacturacion.DesignTimeLayout = cbxTipoFacturacion_DesignTimeLayout
        Me.cbxTipoFacturacion.DisabledBackColor = System.Drawing.Color.White
        Me.cbxTipoFacturacion.DisplayMember = "Value"
        Me.cbxTipoFacturacion.Location = New System.Drawing.Point(90, 178)
        Me.cbxTipoFacturacion.Name = "cbxTipoFacturacion"
        Me.cbxTipoFacturacion.PrimaryDataFields = "TipoFacturacion"
        Me.cbxTipoFacturacion.SecondaryDataFields = "Value"
        Me.cbxTipoFacturacion.SelectedIndex = -1
        Me.cbxTipoFacturacion.SelectedItem = Nothing
        Me.cbxTipoFacturacion.Size = New System.Drawing.Size(125, 21)
        Me.cbxTipoFacturacion.TabIndex = 35
        '
        'lblUDMedida
        '
        Me.lblUDMedida.Location = New System.Drawing.Point(2, 57)
        Me.lblUDMedida.Name = "lblUDMedida"
        Me.lblUDMedida.Size = New System.Drawing.Size(70, 13)
        Me.lblUDMedida.TabIndex = 195
        Me.lblUDMedida.Text = "Ud. Medida"
        '
        'lblQPrev
        '
        Me.lblQPrev.Location = New System.Drawing.Point(195, 107)
        Me.lblQPrev.Name = "lblQPrev"
        Me.lblQPrev.Size = New System.Drawing.Size(53, 13)
        Me.lblQPrev.TabIndex = 196
        Me.lblQPrev.Text = "C. Prev."
        '
        'lblCodTrabajo
        '
        Me.lblCodTrabajo.Location = New System.Drawing.Point(2, 32)
        Me.lblCodTrabajo.Name = "lblCodTrabajo"
        Me.lblCodTrabajo.Size = New System.Drawing.Size(50, 13)
        Me.lblCodTrabajo.TabIndex = 198
        Me.lblCodTrabajo.Text = "Trabajo"
        '
        'cbxIDUDMedida
        '
        cbxIDUDMedida_DesignTimeLayout.LayoutString = resources.GetString("cbxIDUDMedida_DesignTimeLayout.LayoutString")
        Me.cbxIDUDMedida.DesignTimeLayout = cbxIDUDMedida_DesignTimeLayout
        Me.cbxIDUDMedida.DisabledBackColor = System.Drawing.Color.White
        Me.cbxIDUDMedida.DisplayMember = "IDUdMedida"
        Me.cbxIDUDMedida.EntityName = "UdMedida"
        Me.cbxIDUDMedida.Location = New System.Drawing.Point(90, 53)
        Me.cbxIDUDMedida.Name = "cbxIDUDMedida"
        Me.cbxIDUDMedida.PrimaryDataFields = "IDUdMedida"
        Me.cbxIDUDMedida.SecondaryDataFields = "IDUdMedida"
        Me.cbxIDUDMedida.SelectedIndex = -1
        Me.cbxIDUDMedida.SelectedItem = Nothing
        Me.cbxIDUDMedida.Size = New System.Drawing.Size(124, 21)
        Me.cbxIDUDMedida.TabIndex = 22
        Me.cbxIDUDMedida.ValueMember = "IDUdMedida"
        Me.cbxIDUDMedida.ViewName = "tbMaestroUdMedida"
        '
        'lblImpUnitarioVta
        '
        Me.lblImpUnitarioVta.Location = New System.Drawing.Point(281, 132)
        Me.lblImpUnitarioVta.Name = "lblImpUnitarioVta"
        Me.lblImpUnitarioVta.Size = New System.Drawing.Size(109, 13)
        Me.lblImpUnitarioVta.TabIndex = 191
        Me.lblImpUnitarioVta.Text = "Imp. Unitario Vta."
        '
        'txtImpUnitarioVta
        '
        Me.txtImpUnitarioVta.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpUnitarioVta.Enabled = False
        Me.txtImpUnitarioVta.Location = New System.Drawing.Point(394, 128)
        Me.txtImpUnitarioVta.Name = "txtImpUnitarioVta"
        Me.txtImpUnitarioVta.Size = New System.Drawing.Size(85, 21)
        Me.txtImpUnitarioVta.TabIndex = 31
        Me.txtImpUnitarioVta.TabStop = False
        '
        'lblImpUnitario
        '
        Me.lblImpUnitario.Location = New System.Drawing.Point(2, 132)
        Me.lblImpUnitario.Name = "lblImpUnitario"
        Me.lblImpUnitario.Size = New System.Drawing.Size(82, 13)
        Me.lblImpUnitario.TabIndex = 192
        Me.lblImpUnitario.Text = "Imp. Unitario"
        '
        'txtImpUnitario
        '
        Me.txtImpUnitario.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpUnitario.Location = New System.Drawing.Point(90, 128)
        Me.txtImpUnitario.Name = "txtImpUnitario"
        Me.txtImpUnitario.Size = New System.Drawing.Size(85, 21)
        Me.txtImpUnitario.TabIndex = 29
        '
        'txtQPrev
        '
        Me.txtQPrev.DisabledBackColor = System.Drawing.Color.White
        Me.txtQPrev.Location = New System.Drawing.Point(264, 104)
        Me.txtQPrev.Name = "txtQPrev"
        Me.txtQPrev.Size = New System.Drawing.Size(56, 21)
        Me.txtQPrev.TabIndex = 27
        '
        'txtDescTrabajo
        '
        Me.txtDescTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescTrabajo.Location = New System.Drawing.Point(218, 29)
        Me.txtDescTrabajo.Multiline = True
        Me.txtDescTrabajo.Name = "txtDescTrabajo"
        Me.txtDescTrabajo.Size = New System.Drawing.Size(261, 45)
        Me.txtDescTrabajo.TabIndex = 21
        '
        'lblTipoTrabajo
        '
        Me.lblTipoTrabajo.Location = New System.Drawing.Point(2, 8)
        Me.lblTipoTrabajo.Name = "lblTipoTrabajo"
        Me.lblTipoTrabajo.Size = New System.Drawing.Size(78, 13)
        Me.lblTipoTrabajo.TabIndex = 193
        Me.lblTipoTrabajo.Text = "Tipo Trabajo"
        '
        'lblSubTipoTrabajo
        '
        Me.lblSubTipoTrabajo.Location = New System.Drawing.Point(179, 8)
        Me.lblSubTipoTrabajo.Name = "lblSubTipoTrabajo"
        Me.lblSubTipoTrabajo.Size = New System.Drawing.Size(53, 13)
        Me.lblSubTipoTrabajo.TabIndex = 194
        Me.lblSubTipoTrabajo.Text = "SubTipo"
        '
        'txtCodTrabajo
        '
        Me.txtCodTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.txtCodTrabajo.Enabled = False
        Me.txtCodTrabajo.Location = New System.Drawing.Point(90, 29)
        Me.txtCodTrabajo.Name = "txtCodTrabajo"
        Me.txtCodTrabajo.Size = New System.Drawing.Size(124, 21)
        Me.txtCodTrabajo.TabIndex = 20
        '
        'pnlTrabajosCompleto
        '
        Me.pnlTrabajosCompleto.Controls.Add(Me.TvwObraCompleta)
        Me.pnlTrabajosCompleto.Controls.Add(Me.pnlVerTrabajosCompleto)
        Me.pnlTrabajosCompleto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTrabajosCompleto.Location = New System.Drawing.Point(0, 0)
        Me.pnlTrabajosCompleto.Name = "pnlTrabajosCompleto"
        Me.pnlTrabajosCompleto.Size = New System.Drawing.Size(484, 529)
        Me.pnlTrabajosCompleto.TabIndex = 181
        '
        'TvwObraCompleta
        '
        Me.TvwObraCompleta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TvwObraCompleta.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TvwObraCompleta.ImageIndex = 0
        Me.TvwObraCompleta.ImageList = Me.ImageListTrabajoCompleto
        Me.TvwObraCompleta.Location = New System.Drawing.Point(0, 30)
        Me.TvwObraCompleta.Name = "TvwObraCompleta"
        Me.TvwObraCompleta.SelectedImageIndex = 0
        Me.TvwObraCompleta.Size = New System.Drawing.Size(484, 499)
        Me.TvwObraCompleta.TabIndex = 241
        '
        'ImageListTrabajoCompleto
        '
        Me.ImageListTrabajoCompleto.ImageStream = CType(resources.GetObject("ImageListTrabajoCompleto.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListTrabajoCompleto.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListTrabajoCompleto.Images.SetKeyName(0, "xProyectos.ico")
        Me.ImageListTrabajoCompleto.Images.SetKeyName(1, "")
        Me.ImageListTrabajoCompleto.Images.SetKeyName(2, "")
        Me.ImageListTrabajoCompleto.Images.SetKeyName(3, "")
        Me.ImageListTrabajoCompleto.Images.SetKeyName(4, "")
        Me.ImageListTrabajoCompleto.Images.SetKeyName(5, "")
        Me.ImageListTrabajoCompleto.Images.SetKeyName(6, "")
        Me.ImageListTrabajoCompleto.Images.SetKeyName(7, "")
        Me.ImageListTrabajoCompleto.Images.SetKeyName(8, "")
        Me.ImageListTrabajoCompleto.Images.SetKeyName(9, "")
        Me.ImageListTrabajoCompleto.Images.SetKeyName(10, "")
        '
        'pnlVerTrabajosCompleto
        '
        Me.pnlVerTrabajosCompleto.Controls.Add(Me.txtDescTrabajoCompleto)
        Me.pnlVerTrabajosCompleto.Controls.Add(Me.lblTrabajoCompleto)
        Me.pnlVerTrabajosCompleto.Controls.Add(Me.txtTrabajoCompleto)
        Me.pnlVerTrabajosCompleto.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlVerTrabajosCompleto.Location = New System.Drawing.Point(0, 0)
        Me.pnlVerTrabajosCompleto.Name = "pnlVerTrabajosCompleto"
        Me.pnlVerTrabajosCompleto.Size = New System.Drawing.Size(484, 30)
        Me.pnlVerTrabajosCompleto.TabIndex = 185
        '
        'txtDescTrabajoCompleto
        '
        Me.txtDescTrabajoCompleto.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescTrabajoCompleto.Enabled = False
        Me.txtDescTrabajoCompleto.Location = New System.Drawing.Point(188, 6)
        Me.txtDescTrabajoCompleto.Name = "txtDescTrabajoCompleto"
        Me.txtDescTrabajoCompleto.Size = New System.Drawing.Size(288, 21)
        Me.txtDescTrabajoCompleto.TabIndex = 201
        Me.txtDescTrabajoCompleto.TabStop = False
        '
        'lblTrabajoCompleto
        '
        Me.lblTrabajoCompleto.Location = New System.Drawing.Point(5, 9)
        Me.lblTrabajoCompleto.Name = "lblTrabajoCompleto"
        Me.lblTrabajoCompleto.Size = New System.Drawing.Size(50, 13)
        Me.lblTrabajoCompleto.TabIndex = 200
        Me.lblTrabajoCompleto.Text = "Trabajo"
        '
        'txtTrabajoCompleto
        '
        Me.txtTrabajoCompleto.DisabledBackColor = System.Drawing.Color.White
        Me.txtTrabajoCompleto.Enabled = False
        Me.txtTrabajoCompleto.Location = New System.Drawing.Point(62, 6)
        Me.txtTrabajoCompleto.Name = "txtTrabajoCompleto"
        Me.txtTrabajoCompleto.Size = New System.Drawing.Size(124, 21)
        Me.txtTrabajoCompleto.TabIndex = 199
        Me.txtTrabajoCompleto.TabStop = False
        '
        'PnlTimeObras
        '
        Me.PnlTimeObras.Controls.Add(Me.CtrlTimeLineObras1)
        Me.PnlTimeObras.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlTimeObras.Location = New System.Drawing.Point(0, 0)
        Me.PnlTimeObras.Name = "PnlTimeObras"
        Me.PnlTimeObras.Size = New System.Drawing.Size(484, 529)
        Me.PnlTimeObras.TabIndex = 182
        '
        'CtrlTimeLineObras1
        '
        Me.CtrlTimeLineObras1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CtrlTimeLineObras1.Location = New System.Drawing.Point(0, 0)
        Me.CtrlTimeLineObras1.Name = "CtrlTimeLineObras1"
        Me.CtrlTimeLineObras1.Size = New System.Drawing.Size(484, 529)
        Me.CtrlTimeLineObras1.TabIndex = 0
        '
        'pnlGridTrabajo
        '
        Me.pnlGridTrabajo.Controls.Add(Me.GridTrabajos)
        Me.pnlGridTrabajo.Controls.Add(Me.pnlVerTrabajosGrid)
        Me.pnlGridTrabajo.Controls.Add(Me.pnlConfigVerTrabajos)
        Me.pnlGridTrabajo.Controls.Add(Me.FraImportesTrabajoGrid)
        Me.pnlGridTrabajo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGridTrabajo.Location = New System.Drawing.Point(0, 0)
        Me.pnlGridTrabajo.Name = "pnlGridTrabajo"
        Me.pnlGridTrabajo.Size = New System.Drawing.Size(484, 529)
        Me.pnlGridTrabajo.TabIndex = 180
        '
        'GridTrabajos
        '
        Me.GridTrabajos.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDCentroGestion", "CentroGestion", "IDCentroGestion"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDUdMedida", "UdMedida", "IDUdMedida"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDTipoTrabajo", "ObraTipoTrabajo", "IDTipoTrabajo"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDSubtipoTrabajo", "ObraSubtipoTrabajo", "IDSubtipoTrabajo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDTipoTrabajo", "IDTipoTrabajo")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("CodTrabajoPadre", "ObraTrabajo", "CodTrabajo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDTrabajo", "IDTrabajoPadre")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("CodTrabajoPresup", "ObraTrabajoPresup", "CodTrabajo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDTrabajoPresup", "IDTrabajoPresup")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDArticulo", "Articulo", "IDArticulo"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("SubSubTipoTrabajo", "ObraSubSubtipoTrabajo", "IDSubSubtipoTrabajo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDSubtipoTrabajo", "IDSubtipoTrabajo"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDTipoTrabajo", "IDTipoTrabajo")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDActivo", "Activo", "IDActivo")})
        Me.GridTrabajos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridTrabajos_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("GridTrabajos_DesignTimeLayout_Reference_0.Instance"), Object)
        GridTrabajos_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("GridTrabajos_DesignTimeLayout_Reference_1.Instance"), Object)
        GridTrabajos_DesignTimeLayout_Reference_2.Instance = CType(resources.GetObject("GridTrabajos_DesignTimeLayout_Reference_2.Instance"), Object)
        GridTrabajos_DesignTimeLayout_Reference_3.Instance = CType(resources.GetObject("GridTrabajos_DesignTimeLayout_Reference_3.Instance"), Object)
        GridTrabajos_DesignTimeLayout_Reference_4.Instance = CType(resources.GetObject("GridTrabajos_DesignTimeLayout_Reference_4.Instance"), Object)
        GridTrabajos_DesignTimeLayout_Reference_5.Instance = CType(resources.GetObject("GridTrabajos_DesignTimeLayout_Reference_5.Instance"), Object)
        GridTrabajos_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {GridTrabajos_DesignTimeLayout_Reference_0, GridTrabajos_DesignTimeLayout_Reference_1, GridTrabajos_DesignTimeLayout_Reference_2, GridTrabajos_DesignTimeLayout_Reference_3, GridTrabajos_DesignTimeLayout_Reference_4, GridTrabajos_DesignTimeLayout_Reference_5})
        GridTrabajos_DesignTimeLayout.LayoutString = resources.GetString("GridTrabajos_DesignTimeLayout.LayoutString")
        Me.GridTrabajos.DesignTimeLayout = GridTrabajos_DesignTimeLayout
        Me.GridTrabajos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridTrabajos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridTrabajos.EntityName = ""
        Me.GridTrabajos.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridTrabajos.FrozenColumns = 8
        Me.GridTrabajos.ImageList = Me.ImageListGrids
        Me.GridTrabajos.Location = New System.Drawing.Point(0, 56)
        Me.GridTrabajos.Name = "GridTrabajos"
        Me.GridTrabajos.PrimaryDataFields = Nothing
        Me.GridTrabajos.SecondaryDataFields = Nothing
        Me.GridTrabajos.Size = New System.Drawing.Size(484, 414)
        Me.GridTrabajos.TabIndex = 186
        Me.GridTrabajos.ViewName = ""
        '
        'ImageListGrids
        '
        Me.ImageListGrids.ImageStream = CType(resources.GetObject("ImageListGrids.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListGrids.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListGrids.Images.SetKeyName(0, "percent.ico")
        Me.ImageListGrids.Images.SetKeyName(1, "calculator.ico")
        Me.ImageListGrids.Images.SetKeyName(2, "folder_edit.ico")
        Me.ImageListGrids.Images.SetKeyName(3, "printer.ico")
        Me.ImageListGrids.Images.SetKeyName(4, "document_edit.ico")
        Me.ImageListGrids.Images.SetKeyName(5, "xTareas.ico")
        Me.ImageListGrids.Images.SetKeyName(6, "users3_preferences.ico")
        Me.ImageListGrids.Images.SetKeyName(7, "folders.ico")
        '
        'pnlVerTrabajosGrid
        '
        Me.pnlVerTrabajosGrid.Controls.Add(Me.txtDescTrabajoGrid)
        Me.pnlVerTrabajosGrid.Controls.Add(Me.lblTrabajoGrid)
        Me.pnlVerTrabajosGrid.Controls.Add(Me.txtTrabajoGrid)
        Me.pnlVerTrabajosGrid.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlVerTrabajosGrid.Location = New System.Drawing.Point(0, 26)
        Me.pnlVerTrabajosGrid.Name = "pnlVerTrabajosGrid"
        Me.pnlVerTrabajosGrid.Size = New System.Drawing.Size(484, 30)
        Me.pnlVerTrabajosGrid.TabIndex = 184
        Me.pnlVerTrabajosGrid.Visible = False
        '
        'txtDescTrabajoGrid
        '
        Me.txtDescTrabajoGrid.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescTrabajoGrid.Enabled = False
        Me.txtDescTrabajoGrid.Location = New System.Drawing.Point(188, 6)
        Me.txtDescTrabajoGrid.Name = "txtDescTrabajoGrid"
        Me.txtDescTrabajoGrid.Size = New System.Drawing.Size(288, 21)
        Me.txtDescTrabajoGrid.TabIndex = 201
        Me.txtDescTrabajoGrid.TabStop = False
        '
        'lblTrabajoGrid
        '
        Me.lblTrabajoGrid.Location = New System.Drawing.Point(5, 9)
        Me.lblTrabajoGrid.Name = "lblTrabajoGrid"
        Me.lblTrabajoGrid.Size = New System.Drawing.Size(50, 13)
        Me.lblTrabajoGrid.TabIndex = 200
        Me.lblTrabajoGrid.Text = "Trabajo"
        '
        'txtTrabajoGrid
        '
        Me.txtTrabajoGrid.DisabledBackColor = System.Drawing.Color.White
        Me.txtTrabajoGrid.Enabled = False
        Me.txtTrabajoGrid.Location = New System.Drawing.Point(62, 6)
        Me.txtTrabajoGrid.Name = "txtTrabajoGrid"
        Me.txtTrabajoGrid.Size = New System.Drawing.Size(124, 21)
        Me.txtTrabajoGrid.TabIndex = 199
        Me.txtTrabajoGrid.TabStop = False
        '
        'pnlConfigVerTrabajos
        '
        Me.pnlConfigVerTrabajos.Controls.Add(Me.rbtPorMultinivelTrabajos)
        Me.pnlConfigVerTrabajos.Controls.Add(Me.lblVerTrabajos)
        Me.pnlConfigVerTrabajos.Controls.Add(Me.rbtPorNivelTrabajos)
        Me.pnlConfigVerTrabajos.Controls.Add(Me.rbtPorTrabajosObra)
        Me.pnlConfigVerTrabajos.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlConfigVerTrabajos.Location = New System.Drawing.Point(0, 0)
        Me.pnlConfigVerTrabajos.Name = "pnlConfigVerTrabajos"
        Me.pnlConfigVerTrabajos.Size = New System.Drawing.Size(484, 26)
        Me.pnlConfigVerTrabajos.TabIndex = 185
        '
        'rbtPorMultinivelTrabajos
        '
        Me.rbtPorMultinivelTrabajos.Location = New System.Drawing.Point(379, 6)
        Me.rbtPorMultinivelTrabajos.Name = "rbtPorMultinivelTrabajos"
        Me.rbtPorMultinivelTrabajos.Size = New System.Drawing.Size(98, 15)
        Me.rbtPorMultinivelTrabajos.TabIndex = 12
        Me.rbtPorMultinivelTrabajos.Text = "por Multinivel"
        '
        'lblVerTrabajos
        '
        Me.lblVerTrabajos.Location = New System.Drawing.Point(5, 6)
        Me.lblVerTrabajos.Name = "lblVerTrabajos"
        Me.lblVerTrabajos.Size = New System.Drawing.Size(161, 13)
        Me.lblVerTrabajos.TabIndex = 10
        Me.lblVerTrabajos.Text = "Ver los datos de las líneas:"
        '
        'rbtPorNivelTrabajos
        '
        Me.rbtPorNivelTrabajos.Location = New System.Drawing.Point(297, 6)
        Me.rbtPorNivelTrabajos.Name = "rbtPorNivelTrabajos"
        Me.rbtPorNivelTrabajos.Size = New System.Drawing.Size(78, 15)
        Me.rbtPorNivelTrabajos.TabIndex = 9
        Me.rbtPorNivelTrabajos.Text = "por Nivel"
        '
        'rbtPorTrabajosObra
        '
        Me.rbtPorTrabajosObra.Location = New System.Drawing.Point(197, 6)
        Me.rbtPorTrabajosObra.Name = "rbtPorTrabajosObra"
        Me.rbtPorTrabajosObra.Size = New System.Drawing.Size(98, 15)
        Me.rbtPorTrabajosObra.TabIndex = 8
        Me.rbtPorTrabajosObra.Text = "por Proyecto"
        '
        'FraImportesTrabajoGrid
        '
        Me.FraImportesTrabajoGrid.Controls.Add(Me.txtFacturadoTrabajoGrid)
        Me.FraImportesTrabajoGrid.Controls.Add(Me.txtRealTrabajoGrid)
        Me.FraImportesTrabajoGrid.Controls.Add(Me.txtPrevistoVentaTrabajoGrid)
        Me.FraImportesTrabajoGrid.Controls.Add(Me.txtPrevistoTrabajoGrid)
        Me.FraImportesTrabajoGrid.Controls.Add(Me.lblPrevTrabajoGrid)
        Me.FraImportesTrabajoGrid.Controls.Add(Me.lblPrevVentaTrabajoGrid)
        Me.FraImportesTrabajoGrid.Controls.Add(Me.lblRealTrabajoGrid)
        Me.FraImportesTrabajoGrid.Controls.Add(Me.lblFactTrabajoGrid)
        Me.FraImportesTrabajoGrid.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FraImportesTrabajoGrid.Location = New System.Drawing.Point(0, 470)
        Me.FraImportesTrabajoGrid.Name = "FraImportesTrabajoGrid"
        Me.FraImportesTrabajoGrid.Size = New System.Drawing.Size(484, 59)
        Me.FraImportesTrabajoGrid.TabIndex = 182
        Me.FraImportesTrabajoGrid.TabStop = False
        Me.FraImportesTrabajoGrid.Text = "Importes Trabajo (Importes Totales)"
        '
        'txtFacturadoTrabajoGrid
        '
        Me.txtFacturadoTrabajoGrid.DisabledBackColor = System.Drawing.Color.White
        Me.txtFacturadoTrabajoGrid.Enabled = False
        Me.txtFacturadoTrabajoGrid.Location = New System.Drawing.Point(360, 33)
        Me.txtFacturadoTrabajoGrid.Name = "txtFacturadoTrabajoGrid"
        Me.txtFacturadoTrabajoGrid.Size = New System.Drawing.Size(113, 21)
        Me.txtFacturadoTrabajoGrid.TabIndex = 148
        Me.txtFacturadoTrabajoGrid.TabStop = False
        '
        'txtRealTrabajoGrid
        '
        Me.txtRealTrabajoGrid.DisabledBackColor = System.Drawing.Color.White
        Me.txtRealTrabajoGrid.Enabled = False
        Me.txtRealTrabajoGrid.Location = New System.Drawing.Point(243, 33)
        Me.txtRealTrabajoGrid.Name = "txtRealTrabajoGrid"
        Me.txtRealTrabajoGrid.Size = New System.Drawing.Size(113, 21)
        Me.txtRealTrabajoGrid.TabIndex = 147
        Me.txtRealTrabajoGrid.TabStop = False
        '
        'txtPrevistoVentaTrabajoGrid
        '
        Me.txtPrevistoVentaTrabajoGrid.DisabledBackColor = System.Drawing.Color.White
        Me.txtPrevistoVentaTrabajoGrid.Enabled = False
        Me.txtPrevistoVentaTrabajoGrid.Location = New System.Drawing.Point(126, 33)
        Me.txtPrevistoVentaTrabajoGrid.Name = "txtPrevistoVentaTrabajoGrid"
        Me.txtPrevistoVentaTrabajoGrid.Size = New System.Drawing.Size(113, 21)
        Me.txtPrevistoVentaTrabajoGrid.TabIndex = 146
        Me.txtPrevistoVentaTrabajoGrid.TabStop = False
        '
        'txtPrevistoTrabajoGrid
        '
        Me.txtPrevistoTrabajoGrid.DisabledBackColor = System.Drawing.Color.White
        Me.txtPrevistoTrabajoGrid.Enabled = False
        Me.txtPrevistoTrabajoGrid.Location = New System.Drawing.Point(9, 33)
        Me.txtPrevistoTrabajoGrid.Name = "txtPrevistoTrabajoGrid"
        Me.txtPrevistoTrabajoGrid.Size = New System.Drawing.Size(113, 21)
        Me.txtPrevistoTrabajoGrid.TabIndex = 145
        Me.txtPrevistoTrabajoGrid.TabStop = False
        '
        'lblPrevTrabajoGrid
        '
        Me.lblPrevTrabajoGrid.AutoSize = False
        Me.lblPrevTrabajoGrid.Location = New System.Drawing.Point(9, 17)
        Me.lblPrevTrabajoGrid.Name = "lblPrevTrabajoGrid"
        Me.lblPrevTrabajoGrid.Size = New System.Drawing.Size(113, 13)
        Me.lblPrevTrabajoGrid.TabIndex = 139
        Me.lblPrevTrabajoGrid.Text = "Previsto"
        Me.lblPrevTrabajoGrid.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPrevVentaTrabajoGrid
        '
        Me.lblPrevVentaTrabajoGrid.AutoSize = False
        Me.lblPrevVentaTrabajoGrid.Location = New System.Drawing.Point(126, 17)
        Me.lblPrevVentaTrabajoGrid.Name = "lblPrevVentaTrabajoGrid"
        Me.lblPrevVentaTrabajoGrid.Size = New System.Drawing.Size(113, 13)
        Me.lblPrevVentaTrabajoGrid.TabIndex = 141
        Me.lblPrevVentaTrabajoGrid.Text = "Previsto Venta"
        Me.lblPrevVentaTrabajoGrid.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblRealTrabajoGrid
        '
        Me.lblRealTrabajoGrid.AutoSize = False
        Me.lblRealTrabajoGrid.Location = New System.Drawing.Point(243, 17)
        Me.lblRealTrabajoGrid.Name = "lblRealTrabajoGrid"
        Me.lblRealTrabajoGrid.Size = New System.Drawing.Size(113, 13)
        Me.lblRealTrabajoGrid.TabIndex = 142
        Me.lblRealTrabajoGrid.Text = " Real"
        Me.lblRealTrabajoGrid.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFactTrabajoGrid
        '
        Me.lblFactTrabajoGrid.AutoSize = False
        Me.lblFactTrabajoGrid.Location = New System.Drawing.Point(360, 17)
        Me.lblFactTrabajoGrid.Name = "lblFactTrabajoGrid"
        Me.lblFactTrabajoGrid.Size = New System.Drawing.Size(113, 13)
        Me.lblFactTrabajoGrid.TabIndex = 143
        Me.lblFactTrabajoGrid.Text = "Facturado"
        Me.lblFactTrabajoGrid.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TabPagePrevistos
        '
        Me.TabPagePrevistos.Controls.Add(Me.TabPrevistos)
        Me.TabPagePrevistos.Controls.Add(Me.pnlVerPrevistos)
        Me.TabPagePrevistos.Controls.Add(Me.pnlConfigVerPrevistos)
        Me.TabPagePrevistos.Controls.Add(Me.FraTotalesPrev)
        Me.TabPagePrevistos.Key = "Previstos"
        Me.TabPagePrevistos.Location = New System.Drawing.Point(1, 1)
        Me.TabPagePrevistos.Name = "TabPagePrevistos"
        Me.TabPagePrevistos.Size = New System.Drawing.Size(484, 529)
        Me.TabPagePrevistos.TabStop = True
        Me.TabPagePrevistos.Text = "Previstos"
        '
        'TabPrevistos
        '
        Me.TabPrevistos.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.TabPrevistos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabPrevistos.Location = New System.Drawing.Point(0, 56)
        Me.TabPrevistos.Name = "TabPrevistos"
        Me.TabPrevistos.Size = New System.Drawing.Size(484, 412)
        Me.TabPrevistos.TabIndex = 11
        Me.TabPrevistos.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.TabPageMaterialesPrev, Me.TabPageModPrev, Me.TabPageCentrosPrev, Me.TabPageGastosPrev, Me.TabPageVariosPrev, Me.TabPageMediciones})
        Me.TabPrevistos.UseThemes = True
        '
        'TabPageMaterialesPrev
        '
        Me.TabPageMaterialesPrev.Controls.Add(Me.GridMaterialPrev)
        Me.TabPageMaterialesPrev.Key = "MaterialesPrev"
        Me.TabPageMaterialesPrev.Location = New System.Drawing.Point(1, 21)
        Me.TabPageMaterialesPrev.Name = "TabPageMaterialesPrev"
        Me.TabPageMaterialesPrev.Size = New System.Drawing.Size(482, 390)
        Me.TabPageMaterialesPrev.TabStop = True
        Me.TabPageMaterialesPrev.Text = "Materiales"
        '
        'GridMaterialPrev
        '
        Me.GridMaterialPrev.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDProveedor", "Proveedor", "IDProveedor"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDAlmacen", "Almacen", "IDAlmacen"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDUDInterna", "UDMedida", "IDUDMedida"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDUDCompra", "UDMedida", "IDUDMedida"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDUDVenta", "UDMedida", "IDUDMedida"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("CCVenta", "PlanContable", "IDCContable"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("CCCompra", "PlanContable", "IDCContable"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDMaterial", "Articulo", "IDArticulo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescArticulo", "DescMaterial"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDUdInterna", "IDUdInterna"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDUdCompra", "IDUdCompra"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDUdVenta", "IDUdVenta")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("CodTrabajo", "ObraTrabajo", "CodTrabajo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDTrabajo", "IDTrabajo"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("QPrev", "QPrevTrabajo")}))})
        GridMaterialPrev_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("GridMaterialPrev_DesignTimeLayout_Reference_0.Instance"), Object)
        GridMaterialPrev_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("GridMaterialPrev_DesignTimeLayout_Reference_1.Instance"), Object)
        GridMaterialPrev_DesignTimeLayout_Reference_2.Instance = CType(resources.GetObject("GridMaterialPrev_DesignTimeLayout_Reference_2.Instance"), Object)
        GridMaterialPrev_DesignTimeLayout_Reference_3.Instance = CType(resources.GetObject("GridMaterialPrev_DesignTimeLayout_Reference_3.Instance"), Object)
        GridMaterialPrev_DesignTimeLayout_Reference_4.Instance = CType(resources.GetObject("GridMaterialPrev_DesignTimeLayout_Reference_4.Instance"), Object)
        GridMaterialPrev_DesignTimeLayout_Reference_5.Instance = CType(resources.GetObject("GridMaterialPrev_DesignTimeLayout_Reference_5.Instance"), Object)
        GridMaterialPrev_DesignTimeLayout_Reference_6.Instance = CType(resources.GetObject("GridMaterialPrev_DesignTimeLayout_Reference_6.Instance"), Object)
        GridMaterialPrev_DesignTimeLayout_Reference_7.Instance = CType(resources.GetObject("GridMaterialPrev_DesignTimeLayout_Reference_7.Instance"), Object)
        GridMaterialPrev_DesignTimeLayout_Reference_8.Instance = CType(resources.GetObject("GridMaterialPrev_DesignTimeLayout_Reference_8.Instance"), Object)
        GridMaterialPrev_DesignTimeLayout_Reference_9.Instance = CType(resources.GetObject("GridMaterialPrev_DesignTimeLayout_Reference_9.Instance"), Object)
        GridMaterialPrev_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {GridMaterialPrev_DesignTimeLayout_Reference_0, GridMaterialPrev_DesignTimeLayout_Reference_1, GridMaterialPrev_DesignTimeLayout_Reference_2, GridMaterialPrev_DesignTimeLayout_Reference_3, GridMaterialPrev_DesignTimeLayout_Reference_4, GridMaterialPrev_DesignTimeLayout_Reference_5, GridMaterialPrev_DesignTimeLayout_Reference_6, GridMaterialPrev_DesignTimeLayout_Reference_7, GridMaterialPrev_DesignTimeLayout_Reference_8, GridMaterialPrev_DesignTimeLayout_Reference_9})
        GridMaterialPrev_DesignTimeLayout.LayoutString = resources.GetString("GridMaterialPrev_DesignTimeLayout.LayoutString")
        Me.GridMaterialPrev.DesignTimeLayout = GridMaterialPrev_DesignTimeLayout
        Me.GridMaterialPrev.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridMaterialPrev.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridMaterialPrev.EntityName = ""
        Me.GridMaterialPrev.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridMaterialPrev.FrozenColumns = 5
        Me.GridMaterialPrev.ImageList = Me.ImageListGrids
        Me.GridMaterialPrev.Location = New System.Drawing.Point(0, 0)
        Me.GridMaterialPrev.Name = "GridMaterialPrev"
        Me.GridMaterialPrev.PrimaryDataFields = ""
        Me.GridMaterialPrev.SecondaryDataFields = ""
        Me.GridMaterialPrev.Size = New System.Drawing.Size(482, 390)
        Me.GridMaterialPrev.TabIndex = 83
        Me.GridMaterialPrev.ViewName = ""
        '
        'TabPageModPrev
        '
        Me.TabPageModPrev.Controls.Add(Me.GridMODPrev)
        Me.TabPageModPrev.Key = "ModPrev"
        Me.TabPageModPrev.Location = New System.Drawing.Point(1, 21)
        Me.TabPageModPrev.Name = "TabPageModPrev"
        Me.TabPageModPrev.Size = New System.Drawing.Size(482, 329)
        Me.TabPageModPrev.TabStop = True
        Me.TabPageModPrev.Text = "M.O.D."
        Me.TabPageModPrev.Visible = False
        '
        'GridMODPrev
        '
        Me.GridMODPrev.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("CodTrabajo", "ObraTrabajo", "CodTrabajo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDTrabajo", "IDTrabajo"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("QPrev", "QPrevTrabajo")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDCategoria", "Categoria", "IDCategoria", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescCategoria", "DescCategoria")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDHora", "Hora", "IDHora", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescHora", "DesHora")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDOficio", "Oficio", "IDOficio", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescOficio", "DescOficio")}))})
        GridMODPrev_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("GridMODPrev_DesignTimeLayout_Reference_0.Instance"), Object)
        GridMODPrev_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("GridMODPrev_DesignTimeLayout_Reference_1.Instance"), Object)
        GridMODPrev_DesignTimeLayout_Reference_2.Instance = CType(resources.GetObject("GridMODPrev_DesignTimeLayout_Reference_2.Instance"), Object)
        GridMODPrev_DesignTimeLayout_Reference_3.Instance = CType(resources.GetObject("GridMODPrev_DesignTimeLayout_Reference_3.Instance"), Object)
        GridMODPrev_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {GridMODPrev_DesignTimeLayout_Reference_0, GridMODPrev_DesignTimeLayout_Reference_1, GridMODPrev_DesignTimeLayout_Reference_2, GridMODPrev_DesignTimeLayout_Reference_3})
        GridMODPrev_DesignTimeLayout.LayoutString = resources.GetString("GridMODPrev_DesignTimeLayout.LayoutString")
        Me.GridMODPrev.DesignTimeLayout = GridMODPrev_DesignTimeLayout
        Me.GridMODPrev.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridMODPrev.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridMODPrev.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridMODPrev.EntityName = ""
        Me.GridMODPrev.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridMODPrev.FrozenColumns = 6
        Me.GridMODPrev.ImageList = Me.ImageListGrids
        Me.GridMODPrev.Location = New System.Drawing.Point(0, 0)
        Me.GridMODPrev.Name = "GridMODPrev"
        Me.GridMODPrev.PrimaryDataFields = ""
        Me.GridMODPrev.SecondaryDataFields = ""
        Me.GridMODPrev.Size = New System.Drawing.Size(482, 329)
        Me.GridMODPrev.TabIndex = 44
        Me.GridMODPrev.ViewName = ""
        '
        'TabPageCentrosPrev
        '
        Me.TabPageCentrosPrev.Controls.Add(Me.GridCentrosPrev)
        Me.TabPageCentrosPrev.Key = "CentrosPrev"
        Me.TabPageCentrosPrev.Location = New System.Drawing.Point(1, 21)
        Me.TabPageCentrosPrev.Name = "TabPageCentrosPrev"
        Me.TabPageCentrosPrev.Size = New System.Drawing.Size(482, 329)
        Me.TabPageCentrosPrev.TabStop = True
        Me.TabPageCentrosPrev.Text = "Centros"
        Me.TabPageCentrosPrev.Visible = False
        '
        'GridCentrosPrev
        '
        Me.GridCentrosPrev.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("CodTrabajo", "ObraTrabajo", "CodTrabajo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDTrabajo", "IDTrabajo"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("QPrev", "QPrevTrabajo")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDCentro", "Centro", "IDCentro", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescCentro", "DescCentro")}))})
        GridCentrosPrev_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("GridCentrosPrev_DesignTimeLayout_Reference_0.Instance"), Object)
        GridCentrosPrev_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("GridCentrosPrev_DesignTimeLayout_Reference_1.Instance"), Object)
        GridCentrosPrev_DesignTimeLayout_Reference_2.Instance = CType(resources.GetObject("GridCentrosPrev_DesignTimeLayout_Reference_2.Instance"), Object)
        GridCentrosPrev_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {GridCentrosPrev_DesignTimeLayout_Reference_0, GridCentrosPrev_DesignTimeLayout_Reference_1, GridCentrosPrev_DesignTimeLayout_Reference_2})
        GridCentrosPrev_DesignTimeLayout.LayoutString = resources.GetString("GridCentrosPrev_DesignTimeLayout.LayoutString")
        Me.GridCentrosPrev.DesignTimeLayout = GridCentrosPrev_DesignTimeLayout
        Me.GridCentrosPrev.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridCentrosPrev.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridCentrosPrev.EntityName = ""
        Me.GridCentrosPrev.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridCentrosPrev.FrozenColumns = 6
        Me.GridCentrosPrev.ImageList = Me.ImageListGrids
        Me.GridCentrosPrev.Location = New System.Drawing.Point(0, 0)
        Me.GridCentrosPrev.Name = "GridCentrosPrev"
        Me.GridCentrosPrev.PrimaryDataFields = ""
        Me.GridCentrosPrev.SecondaryDataFields = ""
        Me.GridCentrosPrev.Size = New System.Drawing.Size(482, 329)
        Me.GridCentrosPrev.TabIndex = 37
        Me.GridCentrosPrev.ViewName = ""
        '
        'TabPageGastosPrev
        '
        Me.TabPageGastosPrev.Controls.Add(Me.GridGastosPrev)
        Me.TabPageGastosPrev.Key = "GastosPrev"
        Me.TabPageGastosPrev.Location = New System.Drawing.Point(1, 21)
        Me.TabPageGastosPrev.Name = "TabPageGastosPrev"
        Me.TabPageGastosPrev.Size = New System.Drawing.Size(482, 329)
        Me.TabPageGastosPrev.TabStop = True
        Me.TabPageGastosPrev.Text = "Gastos"
        Me.TabPageGastosPrev.Visible = False
        '
        'GridGastosPrev
        '
        Me.GridGastosPrev.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("CodTrabajo", "ObraTrabajo", "CodTrabajo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDTrabajo", "IDTrabajo"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("Facturable", "Facturable")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDGasto", "Gasto", "IDGasto", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescGasto", "DescGasto"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDArticulo", "IDArticulo")}))})
        GridGastosPrev_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("GridGastosPrev_DesignTimeLayout_Reference_0.Instance"), Object)
        GridGastosPrev_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("GridGastosPrev_DesignTimeLayout_Reference_1.Instance"), Object)
        GridGastosPrev_DesignTimeLayout_Reference_2.Instance = CType(resources.GetObject("GridGastosPrev_DesignTimeLayout_Reference_2.Instance"), Object)
        GridGastosPrev_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {GridGastosPrev_DesignTimeLayout_Reference_0, GridGastosPrev_DesignTimeLayout_Reference_1, GridGastosPrev_DesignTimeLayout_Reference_2})
        GridGastosPrev_DesignTimeLayout.LayoutString = resources.GetString("GridGastosPrev_DesignTimeLayout.LayoutString")
        Me.GridGastosPrev.DesignTimeLayout = GridGastosPrev_DesignTimeLayout
        Me.GridGastosPrev.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridGastosPrev.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridGastosPrev.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridGastosPrev.EntityName = ""
        Me.GridGastosPrev.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridGastosPrev.FrozenColumns = 5
        Me.GridGastosPrev.ImageList = Me.ImageListGrids
        Me.GridGastosPrev.Location = New System.Drawing.Point(0, 0)
        Me.GridGastosPrev.Name = "GridGastosPrev"
        Me.GridGastosPrev.PrimaryDataFields = ""
        Me.GridGastosPrev.SecondaryDataFields = ""
        Me.GridGastosPrev.Size = New System.Drawing.Size(482, 329)
        Me.GridGastosPrev.TabIndex = 34
        Me.GridGastosPrev.ViewName = ""
        '
        'TabPageVariosPrev
        '
        Me.TabPageVariosPrev.Controls.Add(Me.GridVariosPrev)
        Me.TabPageVariosPrev.Key = "VariosPrev"
        Me.TabPageVariosPrev.Location = New System.Drawing.Point(1, 21)
        Me.TabPageVariosPrev.Name = "TabPageVariosPrev"
        Me.TabPageVariosPrev.Size = New System.Drawing.Size(482, 329)
        Me.TabPageVariosPrev.TabStop = True
        Me.TabPageVariosPrev.Text = "Varios"
        Me.TabPageVariosPrev.Visible = False
        '
        'GridVariosPrev
        '
        Me.GridVariosPrev.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("CodTrabajo", "ObraTrabajo", "CodTrabajo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDTrabajo", "IDTrabajo"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("Facturable", "Facturable")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDVarios", "Varios", "IDVarios", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescVarios", "DescVarios"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDArticulo", "IDArticulo")}))})
        GridVariosPrev_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("GridVariosPrev_DesignTimeLayout_Reference_0.Instance"), Object)
        GridVariosPrev_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("GridVariosPrev_DesignTimeLayout_Reference_1.Instance"), Object)
        GridVariosPrev_DesignTimeLayout_Reference_2.Instance = CType(resources.GetObject("GridVariosPrev_DesignTimeLayout_Reference_2.Instance"), Object)
        GridVariosPrev_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {GridVariosPrev_DesignTimeLayout_Reference_0, GridVariosPrev_DesignTimeLayout_Reference_1, GridVariosPrev_DesignTimeLayout_Reference_2})
        GridVariosPrev_DesignTimeLayout.LayoutString = resources.GetString("GridVariosPrev_DesignTimeLayout.LayoutString")
        Me.GridVariosPrev.DesignTimeLayout = GridVariosPrev_DesignTimeLayout
        Me.GridVariosPrev.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridVariosPrev.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridVariosPrev.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridVariosPrev.EntityName = ""
        Me.GridVariosPrev.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridVariosPrev.FrozenColumns = 5
        Me.GridVariosPrev.ImageList = Me.ImageListGrids
        Me.GridVariosPrev.Location = New System.Drawing.Point(0, 0)
        Me.GridVariosPrev.Name = "GridVariosPrev"
        Me.GridVariosPrev.PrimaryDataFields = ""
        Me.GridVariosPrev.SecondaryDataFields = ""
        Me.GridVariosPrev.Size = New System.Drawing.Size(482, 329)
        Me.GridVariosPrev.TabIndex = 39
        Me.GridVariosPrev.ViewName = ""
        '
        'TabPageMediciones
        '
        Me.TabPageMediciones.Controls.Add(Me.GridMediciones)
        Me.TabPageMediciones.Controls.Add(Me.FraImportesMedicionesPrev)
        Me.TabPageMediciones.Key = "Mediciones"
        Me.TabPageMediciones.Location = New System.Drawing.Point(1, 21)
        Me.TabPageMediciones.Name = "TabPageMediciones"
        Me.TabPageMediciones.Size = New System.Drawing.Size(482, 329)
        Me.TabPageMediciones.TabStop = True
        Me.TabPageMediciones.Text = "Mediciones"
        '
        'GridMediciones
        '
        Me.GridMediciones.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("CodTrabajo", "ObraTrabajo", "CodTrabajo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDTrabajo", "IDTrabajo")}))})
        GridMediciones_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("GridMediciones_DesignTimeLayout_Reference_0.Instance"), Object)
        GridMediciones_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {GridMediciones_DesignTimeLayout_Reference_0})
        GridMediciones_DesignTimeLayout.LayoutString = resources.GetString("GridMediciones_DesignTimeLayout.LayoutString")
        Me.GridMediciones.DesignTimeLayout = GridMediciones_DesignTimeLayout
        Me.GridMediciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridMediciones.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridMediciones.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridMediciones.EntityName = ""
        Me.GridMediciones.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridMediciones.FrozenColumns = 4
        Me.GridMediciones.Location = New System.Drawing.Point(0, 0)
        Me.GridMediciones.Name = "GridMediciones"
        Me.GridMediciones.PrimaryDataFields = ""
        Me.GridMediciones.SecondaryDataFields = ""
        Me.GridMediciones.Size = New System.Drawing.Size(482, 270)
        Me.GridMediciones.TabIndex = 10
        Me.GridMediciones.ViewName = ""
        '
        'FraImportesMedicionesPrev
        '
        Me.FraImportesMedicionesPrev.Controls.Add(Me.lblTotalMedicion)
        Me.FraImportesMedicionesPrev.Controls.Add(Me.txtTotalMedicion)
        Me.FraImportesMedicionesPrev.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FraImportesMedicionesPrev.Location = New System.Drawing.Point(0, 270)
        Me.FraImportesMedicionesPrev.Name = "FraImportesMedicionesPrev"
        Me.FraImportesMedicionesPrev.Size = New System.Drawing.Size(482, 59)
        Me.FraImportesMedicionesPrev.TabIndex = 9
        Me.FraImportesMedicionesPrev.TabStop = False
        '
        'lblTotalMedicion
        '
        Me.lblTotalMedicion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTotalMedicion.AutoSize = False
        Me.lblTotalMedicion.Location = New System.Drawing.Point(360, -68)
        Me.lblTotalMedicion.Name = "lblTotalMedicion"
        Me.lblTotalMedicion.Size = New System.Drawing.Size(113, 17)
        Me.lblTotalMedicion.TabIndex = 100
        Me.lblTotalMedicion.Text = "Total Medición"
        Me.lblTotalMedicion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTotalMedicion
        '
        Me.txtTotalMedicion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotalMedicion.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotalMedicion.Enabled = False
        Me.txtTotalMedicion.Location = New System.Drawing.Point(360, -49)
        Me.txtTotalMedicion.Name = "txtTotalMedicion"
        Me.txtTotalMedicion.Size = New System.Drawing.Size(113, 21)
        Me.txtTotalMedicion.TabIndex = 99
        Me.txtTotalMedicion.TabStop = False
        '
        'pnlVerPrevistos
        '
        Me.pnlVerPrevistos.Controls.Add(Me.lblQPrevPrev)
        Me.pnlVerPrevistos.Controls.Add(Me.txtQPrevTrabajo)
        Me.pnlVerPrevistos.Controls.Add(Me.txtDescTrabajoPrev)
        Me.pnlVerPrevistos.Controls.Add(Me.lblTrabajoPrev)
        Me.pnlVerPrevistos.Controls.Add(Me.txtTrabajoPrev)
        Me.pnlVerPrevistos.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlVerPrevistos.Location = New System.Drawing.Point(0, 26)
        Me.pnlVerPrevistos.Name = "pnlVerPrevistos"
        Me.pnlVerPrevistos.Size = New System.Drawing.Size(484, 30)
        Me.pnlVerPrevistos.TabIndex = 4
        Me.pnlVerPrevistos.Visible = False
        '
        'lblQPrevPrev
        '
        Me.lblQPrevPrev.Location = New System.Drawing.Point(348, 9)
        Me.lblQPrevPrev.Name = "lblQPrevPrev"
        Me.lblQPrevPrev.Size = New System.Drawing.Size(53, 13)
        Me.lblQPrevPrev.TabIndex = 203
        Me.lblQPrevPrev.Text = "C. Prev."
        '
        'txtQPrevTrabajo
        '
        Me.txtQPrevTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.txtQPrevTrabajo.Location = New System.Drawing.Point(403, 6)
        Me.txtQPrevTrabajo.Name = "txtQPrevTrabajo"
        Me.txtQPrevTrabajo.Size = New System.Drawing.Size(74, 21)
        Me.txtQPrevTrabajo.TabIndex = 202
        '
        'txtDescTrabajoPrev
        '
        Me.txtDescTrabajoPrev.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescTrabajoPrev.Enabled = False
        Me.txtDescTrabajoPrev.Location = New System.Drawing.Point(157, 6)
        Me.txtDescTrabajoPrev.Name = "txtDescTrabajoPrev"
        Me.txtDescTrabajoPrev.Size = New System.Drawing.Size(190, 21)
        Me.txtDescTrabajoPrev.TabIndex = 201
        Me.txtDescTrabajoPrev.TabStop = False
        '
        'lblTrabajoPrev
        '
        Me.lblTrabajoPrev.Location = New System.Drawing.Point(5, 9)
        Me.lblTrabajoPrev.Name = "lblTrabajoPrev"
        Me.lblTrabajoPrev.Size = New System.Drawing.Size(50, 13)
        Me.lblTrabajoPrev.TabIndex = 200
        Me.lblTrabajoPrev.Text = "Trabajo"
        '
        'txtTrabajoPrev
        '
        Me.txtTrabajoPrev.DisabledBackColor = System.Drawing.Color.White
        Me.txtTrabajoPrev.Enabled = False
        Me.txtTrabajoPrev.Location = New System.Drawing.Point(58, 6)
        Me.txtTrabajoPrev.Name = "txtTrabajoPrev"
        Me.txtTrabajoPrev.Size = New System.Drawing.Size(96, 21)
        Me.txtTrabajoPrev.TabIndex = 199
        Me.txtTrabajoPrev.TabStop = False
        '
        'pnlConfigVerPrevistos
        '
        Me.pnlConfigVerPrevistos.Controls.Add(Me.rbtPorMultinivelPrev)
        Me.pnlConfigVerPrevistos.Controls.Add(Me.lblVerPrevistos)
        Me.pnlConfigVerPrevistos.Controls.Add(Me.rbtPorNivelPrev)
        Me.pnlConfigVerPrevistos.Controls.Add(Me.rbtPrevObra)
        Me.pnlConfigVerPrevistos.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlConfigVerPrevistos.Location = New System.Drawing.Point(0, 0)
        Me.pnlConfigVerPrevistos.Name = "pnlConfigVerPrevistos"
        Me.pnlConfigVerPrevistos.Size = New System.Drawing.Size(484, 26)
        Me.pnlConfigVerPrevistos.TabIndex = 10
        '
        'rbtPorMultinivelPrev
        '
        Me.rbtPorMultinivelPrev.Location = New System.Drawing.Point(379, 6)
        Me.rbtPorMultinivelPrev.Name = "rbtPorMultinivelPrev"
        Me.rbtPorMultinivelPrev.Size = New System.Drawing.Size(98, 15)
        Me.rbtPorMultinivelPrev.TabIndex = 10
        Me.rbtPorMultinivelPrev.Text = "por Multinivel"
        '
        'lblVerPrevistos
        '
        Me.lblVerPrevistos.Location = New System.Drawing.Point(5, 6)
        Me.lblVerPrevistos.Name = "lblVerPrevistos"
        Me.lblVerPrevistos.Size = New System.Drawing.Size(161, 13)
        Me.lblVerPrevistos.TabIndex = 10
        Me.lblVerPrevistos.Text = "Ver los datos de las líneas:"
        '
        'rbtPorNivelPrev
        '
        Me.rbtPorNivelPrev.Location = New System.Drawing.Point(297, 6)
        Me.rbtPorNivelPrev.Name = "rbtPorNivelPrev"
        Me.rbtPorNivelPrev.Size = New System.Drawing.Size(78, 15)
        Me.rbtPorNivelPrev.TabIndex = 9
        Me.rbtPorNivelPrev.Text = "por Nivel"
        '
        'rbtPrevObra
        '
        Me.rbtPrevObra.Location = New System.Drawing.Point(197, 6)
        Me.rbtPrevObra.Name = "rbtPrevObra"
        Me.rbtPrevObra.Size = New System.Drawing.Size(98, 15)
        Me.rbtPrevObra.TabIndex = 8
        Me.rbtPrevObra.Text = "por Proyecto"
        '
        'FraTotalesPrev
        '
        Me.FraTotalesPrev.Controls.Add(Me.lblTotalFacturado)
        Me.FraTotalesPrev.Controls.Add(Me.txtTotalFacturado)
        Me.FraTotalesPrev.Controls.Add(Me.lblTotalPrevVenta)
        Me.FraTotalesPrev.Controls.Add(Me.txtTotalPrevVenta)
        Me.FraTotalesPrev.Controls.Add(Me.lblTotalReal)
        Me.FraTotalesPrev.Controls.Add(Me.txtTotalReal)
        Me.FraTotalesPrev.Controls.Add(Me.lblTotalPrev)
        Me.FraTotalesPrev.Controls.Add(Me.txtTotalPrev)
        Me.FraTotalesPrev.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FraTotalesPrev.Location = New System.Drawing.Point(0, 468)
        Me.FraTotalesPrev.Name = "FraTotalesPrev"
        Me.FraTotalesPrev.Size = New System.Drawing.Size(484, 61)
        Me.FraTotalesPrev.TabIndex = 8
        Me.FraTotalesPrev.TabStop = False
        Me.FraTotalesPrev.Text = "Importes Unitarios"
        '
        'lblTotalFacturado
        '
        Me.lblTotalFacturado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTotalFacturado.AutoSize = False
        Me.lblTotalFacturado.Location = New System.Drawing.Point(364, 15)
        Me.lblTotalFacturado.Name = "lblTotalFacturado"
        Me.lblTotalFacturado.Size = New System.Drawing.Size(113, 17)
        Me.lblTotalFacturado.TabIndex = 100
        Me.lblTotalFacturado.Text = "Total Facturado"
        Me.lblTotalFacturado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTotalFacturado
        '
        Me.txtTotalFacturado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotalFacturado.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotalFacturado.Enabled = False
        Me.txtTotalFacturado.Location = New System.Drawing.Point(364, 34)
        Me.txtTotalFacturado.Name = "txtTotalFacturado"
        Me.txtTotalFacturado.Size = New System.Drawing.Size(113, 21)
        Me.txtTotalFacturado.TabIndex = 99
        Me.txtTotalFacturado.TabStop = False
        '
        'lblTotalPrevVenta
        '
        Me.lblTotalPrevVenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTotalPrevVenta.AutoSize = False
        Me.lblTotalPrevVenta.Location = New System.Drawing.Point(130, 15)
        Me.lblTotalPrevVenta.Name = "lblTotalPrevVenta"
        Me.lblTotalPrevVenta.Size = New System.Drawing.Size(113, 17)
        Me.lblTotalPrevVenta.TabIndex = 101
        Me.lblTotalPrevVenta.Text = "Total Prev. Venta"
        Me.lblTotalPrevVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTotalPrevVenta
        '
        Me.txtTotalPrevVenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotalPrevVenta.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotalPrevVenta.Enabled = False
        Me.txtTotalPrevVenta.Location = New System.Drawing.Point(130, 34)
        Me.txtTotalPrevVenta.Name = "txtTotalPrevVenta"
        Me.txtTotalPrevVenta.Size = New System.Drawing.Size(113, 21)
        Me.txtTotalPrevVenta.TabIndex = 98
        Me.txtTotalPrevVenta.TabStop = False
        '
        'lblTotalReal
        '
        Me.lblTotalReal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTotalReal.AutoSize = False
        Me.lblTotalReal.Location = New System.Drawing.Point(247, 15)
        Me.lblTotalReal.Name = "lblTotalReal"
        Me.lblTotalReal.Size = New System.Drawing.Size(113, 17)
        Me.lblTotalReal.TabIndex = 102
        Me.lblTotalReal.Text = "Total Real"
        Me.lblTotalReal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTotalReal
        '
        Me.txtTotalReal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotalReal.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotalReal.Enabled = False
        Me.txtTotalReal.Location = New System.Drawing.Point(247, 34)
        Me.txtTotalReal.Name = "txtTotalReal"
        Me.txtTotalReal.Size = New System.Drawing.Size(113, 21)
        Me.txtTotalReal.TabIndex = 97
        Me.txtTotalReal.TabStop = False
        '
        'lblTotalPrev
        '
        Me.lblTotalPrev.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTotalPrev.AutoSize = False
        Me.lblTotalPrev.Location = New System.Drawing.Point(13, 15)
        Me.lblTotalPrev.Name = "lblTotalPrev"
        Me.lblTotalPrev.Size = New System.Drawing.Size(113, 17)
        Me.lblTotalPrev.TabIndex = 103
        Me.lblTotalPrev.Text = "Total Previsto"
        Me.lblTotalPrev.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTotalPrev
        '
        Me.txtTotalPrev.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotalPrev.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotalPrev.Enabled = False
        Me.txtTotalPrev.Location = New System.Drawing.Point(13, 34)
        Me.txtTotalPrev.Name = "txtTotalPrev"
        Me.txtTotalPrev.Size = New System.Drawing.Size(113, 21)
        Me.txtTotalPrev.TabIndex = 96
        Me.txtTotalPrev.TabStop = False
        '
        'TabPageControl
        '
        Me.TabPageControl.Controls.Add(Me.TabControl)
        Me.TabPageControl.Controls.Add(Me.pnlVerControl)
        Me.TabPageControl.Controls.Add(Me.pnlConfigVerControl)
        Me.TabPageControl.Controls.Add(Me.FraTotalesReal)
        Me.TabPageControl.Key = "Control"
        Me.TabPageControl.Location = New System.Drawing.Point(1, 1)
        Me.TabPageControl.Name = "TabPageControl"
        Me.TabPageControl.Size = New System.Drawing.Size(484, 529)
        Me.TabPageControl.TabStop = True
        Me.TabPageControl.Text = "Control"
        '
        'TabControl
        '
        Me.TabControl.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.TabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl.Location = New System.Drawing.Point(0, 56)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.Size = New System.Drawing.Size(484, 434)
        Me.TabControl.TabIndex = 14
        Me.TabControl.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.TabPageMaterialesControl, Me.TabPageModControl, Me.TabPageCentrosControl, Me.TabPageGastosControl, Me.TabPageVariosControl, Me.TabPageControlMediciones})
        Me.TabControl.UseThemes = True
        '
        'TabPageMaterialesControl
        '
        Me.TabPageMaterialesControl.Controls.Add(Me.GridMaterialControl)
        Me.TabPageMaterialesControl.Key = "MaterialesControl"
        Me.TabPageMaterialesControl.Location = New System.Drawing.Point(1, 21)
        Me.TabPageMaterialesControl.Name = "TabPageMaterialesControl"
        Me.TabPageMaterialesControl.Size = New System.Drawing.Size(482, 412)
        Me.TabPageMaterialesControl.TabStop = True
        Me.TabPageMaterialesControl.Text = "Materiales"
        '
        'GridMaterialControl
        '
        Me.GridMaterialControl.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("CodTrabajo", "ObraTrabajo", "CodTrabajo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDTrabajo", "IDTrabajo"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDObra", "IDObra")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDMaterial", "Articulo", "IDArticulo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescArticulo", "DescMaterial"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("UdValoracion", "UdValoracion")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDAlmacen", "Almacen", "IDAlmacen"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDLineaMaterial", "ObraMaterial", "IDLineaMaterial")})
        GridMaterialControl_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("GridMaterialControl_DesignTimeLayout_Reference_0.Instance"), Object)
        GridMaterialControl_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("GridMaterialControl_DesignTimeLayout_Reference_1.Instance"), Object)
        GridMaterialControl_DesignTimeLayout_Reference_2.Instance = CType(resources.GetObject("GridMaterialControl_DesignTimeLayout_Reference_2.Instance"), Object)
        GridMaterialControl_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {GridMaterialControl_DesignTimeLayout_Reference_0, GridMaterialControl_DesignTimeLayout_Reference_1, GridMaterialControl_DesignTimeLayout_Reference_2})
        GridMaterialControl_DesignTimeLayout.LayoutString = resources.GetString("GridMaterialControl_DesignTimeLayout.LayoutString")
        Me.GridMaterialControl.DesignTimeLayout = GridMaterialControl_DesignTimeLayout
        Me.GridMaterialControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridMaterialControl.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridMaterialControl.EntityName = "ObraMaterialControl"
        Me.GridMaterialControl.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridMaterialControl.FrozenColumns = 4
        Me.GridMaterialControl.Location = New System.Drawing.Point(0, 0)
        Me.GridMaterialControl.Name = "GridMaterialControl"
        Me.GridMaterialControl.PrimaryDataFields = "IDObra"
        Me.GridMaterialControl.SecondaryDataFields = "IDObra"
        Me.GridMaterialControl.Size = New System.Drawing.Size(482, 412)
        Me.GridMaterialControl.TabIndex = 28
        Me.GridMaterialControl.ViewName = "vFrmObraControlMaterial"
        '
        'TabPageModControl
        '
        Me.TabPageModControl.Controls.Add(Me.GridMODControl)
        Me.TabPageModControl.Key = "ModControl"
        Me.TabPageModControl.Location = New System.Drawing.Point(1, 21)
        Me.TabPageModControl.Name = "TabPageModControl"
        Me.TabPageModControl.Size = New System.Drawing.Size(482, 412)
        Me.TabPageModControl.TabStop = True
        Me.TabPageModControl.Text = "M.O.D."
        Me.TabPageModControl.Visible = False
        '
        'GridMODControl
        '
        Me.GridMODControl.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("CodTrabajo", "ObraTrabajo", "CodTrabajo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDObra", "IDObra"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDTrabajo", "IDTrabajo")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDOperario", "Operario", "IDOperario", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDOficio", "IDOficio"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDCategoria", "IDCategoria")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDHora", "Hora", "IDHora", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescHora", "DesHora")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("NTarea", "ObraTarea", "NTarea", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDTarea", "IDTarea"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescTarea", "DescTarea")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDIncidencia", "Incidencia", "IDIncidencia"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDLineaMod", "ObraMOD", "IDLineaMod", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("PrecioVentaA", "PrecioVentaA"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("Facturable", "Facturable")}))})
        GridMODControl_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("GridMODControl_DesignTimeLayout_Reference_0.Instance"), Object)
        GridMODControl_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("GridMODControl_DesignTimeLayout_Reference_1.Instance"), Object)
        GridMODControl_DesignTimeLayout_Reference_2.Instance = CType(resources.GetObject("GridMODControl_DesignTimeLayout_Reference_2.Instance"), Object)
        GridMODControl_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {GridMODControl_DesignTimeLayout_Reference_0, GridMODControl_DesignTimeLayout_Reference_1, GridMODControl_DesignTimeLayout_Reference_2})
        GridMODControl_DesignTimeLayout.LayoutString = resources.GetString("GridMODControl_DesignTimeLayout.LayoutString")
        Me.GridMODControl.DesignTimeLayout = GridMODControl_DesignTimeLayout
        Me.GridMODControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridMODControl.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridMODControl.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridMODControl.EntityName = "ObraMODControl"
        Me.GridMODControl.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridMODControl.FrozenColumns = 4
        Me.GridMODControl.Location = New System.Drawing.Point(0, 0)
        Me.GridMODControl.Name = "GridMODControl"
        Me.GridMODControl.PrimaryDataFields = "IDObra"
        Me.GridMODControl.SecondaryDataFields = "IDObra"
        Me.GridMODControl.Size = New System.Drawing.Size(482, 412)
        Me.GridMODControl.TabIndex = 14
        Me.GridMODControl.ViewName = "vFrmObraControlMOD"
        '
        'TabPageCentrosControl
        '
        Me.TabPageCentrosControl.Controls.Add(Me.GridCentroControl)
        Me.TabPageCentrosControl.Key = "CentrosControl"
        Me.TabPageCentrosControl.Location = New System.Drawing.Point(1, 21)
        Me.TabPageCentrosControl.Name = "TabPageCentrosControl"
        Me.TabPageCentrosControl.Size = New System.Drawing.Size(482, 344)
        Me.TabPageCentrosControl.TabStop = True
        Me.TabPageCentrosControl.Text = "Centros"
        Me.TabPageCentrosControl.Visible = False
        '
        'GridCentroControl
        '
        Me.GridCentroControl.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDIncidencia", "Incidencia", "IDIncidencia"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("CodTrabajo", "ObraTrabajo", "CodTrabajo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDTrabajo", "IDTrabajo"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDObra", "IDObra")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDCentro", "Centro", "IDCentro", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescCentro", "DescCentro")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDLineaCentro", "ObraCentro", "IDLineaCentro", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDCentro", "IDCentro"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescCentro", "DescCentro")}))})
        GridCentroControl_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("GridCentroControl_DesignTimeLayout_Reference_0.Instance"), Object)
        GridCentroControl_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("GridCentroControl_DesignTimeLayout_Reference_1.Instance"), Object)
        GridCentroControl_DesignTimeLayout_Reference_2.Instance = CType(resources.GetObject("GridCentroControl_DesignTimeLayout_Reference_2.Instance"), Object)
        GridCentroControl_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {GridCentroControl_DesignTimeLayout_Reference_0, GridCentroControl_DesignTimeLayout_Reference_1, GridCentroControl_DesignTimeLayout_Reference_2})
        GridCentroControl_DesignTimeLayout.LayoutString = resources.GetString("GridCentroControl_DesignTimeLayout.LayoutString")
        Me.GridCentroControl.DesignTimeLayout = GridCentroControl_DesignTimeLayout
        Me.GridCentroControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridCentroControl.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridCentroControl.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridCentroControl.EntityName = "ObraCentroControl"
        Me.GridCentroControl.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridCentroControl.FrozenColumns = 4
        Me.GridCentroControl.Location = New System.Drawing.Point(0, 0)
        Me.GridCentroControl.Name = "GridCentroControl"
        Me.GridCentroControl.PrimaryDataFields = "IDObra"
        Me.GridCentroControl.SecondaryDataFields = "IDObra"
        Me.GridCentroControl.Size = New System.Drawing.Size(482, 344)
        Me.GridCentroControl.TabIndex = 24
        Me.GridCentroControl.ViewName = "vFrmObraControlCentro"
        '
        'TabPageGastosControl
        '
        Me.TabPageGastosControl.Controls.Add(Me.GridGastosControl)
        Me.TabPageGastosControl.Key = "GastosControl"
        Me.TabPageGastosControl.Location = New System.Drawing.Point(1, 21)
        Me.TabPageGastosControl.Name = "TabPageGastosControl"
        Me.TabPageGastosControl.Size = New System.Drawing.Size(482, 344)
        Me.TabPageGastosControl.TabStop = True
        Me.TabPageGastosControl.Text = "Gastos"
        Me.TabPageGastosControl.Visible = False
        '
        'GridGastosControl
        '
        Me.GridGastosControl.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDOperario", "Operario", "IDOperario"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDEmpresa", "Empresa", "IDEmpresa"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("CodTrabajo", "ObraTrabajo", "CodTrabajo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDTrabajo", "IDTrabajo"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDObra", "IDObra")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDGasto", "Gasto", "IDGasto", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescGasto", "DescGasto")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDLineaGasto", "ObraGasto", "IDLineaGasto", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDGasto", "IDGasto"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescGasto", "DescGasto"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("Facturable", "Facturable")}))})
        GridGastosControl_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("GridGastosControl_DesignTimeLayout_Reference_0.Instance"), Object)
        GridGastosControl_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("GridGastosControl_DesignTimeLayout_Reference_1.Instance"), Object)
        GridGastosControl_DesignTimeLayout_Reference_2.Instance = CType(resources.GetObject("GridGastosControl_DesignTimeLayout_Reference_2.Instance"), Object)
        GridGastosControl_DesignTimeLayout_Reference_3.Instance = CType(resources.GetObject("GridGastosControl_DesignTimeLayout_Reference_3.Instance"), Object)
        GridGastosControl_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {GridGastosControl_DesignTimeLayout_Reference_0, GridGastosControl_DesignTimeLayout_Reference_1, GridGastosControl_DesignTimeLayout_Reference_2, GridGastosControl_DesignTimeLayout_Reference_3})
        GridGastosControl_DesignTimeLayout.LayoutString = resources.GetString("GridGastosControl_DesignTimeLayout.LayoutString")
        Me.GridGastosControl.DesignTimeLayout = GridGastosControl_DesignTimeLayout
        Me.GridGastosControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridGastosControl.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridGastosControl.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridGastosControl.EntityName = "ObraGastoControl"
        Me.GridGastosControl.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridGastosControl.FrozenColumns = 4
        Me.GridGastosControl.Location = New System.Drawing.Point(0, 0)
        Me.GridGastosControl.Name = "GridGastosControl"
        Me.GridGastosControl.PrimaryDataFields = "IDObra"
        Me.GridGastosControl.SecondaryDataFields = "IDObra"
        Me.GridGastosControl.Size = New System.Drawing.Size(482, 344)
        Me.GridGastosControl.TabIndex = 21
        Me.GridGastosControl.ViewName = "vFrmObraControlGasto"
        '
        'TabPageVariosControl
        '
        Me.TabPageVariosControl.Controls.Add(Me.GridVariosControl)
        Me.TabPageVariosControl.Key = "VariosControl"
        Me.TabPageVariosControl.Location = New System.Drawing.Point(1, 21)
        Me.TabPageVariosControl.Name = "TabPageVariosControl"
        Me.TabPageVariosControl.Size = New System.Drawing.Size(482, 344)
        Me.TabPageVariosControl.TabStop = True
        Me.TabPageVariosControl.Text = "Varios"
        Me.TabPageVariosControl.Visible = False
        '
        'GridVariosControl
        '
        Me.GridVariosControl.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("CodTrabajo", "ObraTrabajo", "CodTrabajo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDTrabajo", "IDTrabajo"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDObra", "IDObra")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDVarios", "Varios", "IDVarios", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescVarios", "DescVarios")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDLineaVarios", "ObraVarios", "IDLineaVarios", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescVarios", "IDVarios")}))})
        GridVariosControl_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("GridVariosControl_DesignTimeLayout_Reference_0.Instance"), Object)
        GridVariosControl_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("GridVariosControl_DesignTimeLayout_Reference_1.Instance"), Object)
        GridVariosControl_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {GridVariosControl_DesignTimeLayout_Reference_0, GridVariosControl_DesignTimeLayout_Reference_1})
        GridVariosControl_DesignTimeLayout.LayoutString = resources.GetString("GridVariosControl_DesignTimeLayout.LayoutString")
        Me.GridVariosControl.DesignTimeLayout = GridVariosControl_DesignTimeLayout
        Me.GridVariosControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridVariosControl.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridVariosControl.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridVariosControl.EntityName = "ObraVariosControl"
        Me.GridVariosControl.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridVariosControl.FrozenColumns = 4
        Me.GridVariosControl.Location = New System.Drawing.Point(0, 0)
        Me.GridVariosControl.Name = "GridVariosControl"
        Me.GridVariosControl.PrimaryDataFields = "IDObra"
        Me.GridVariosControl.SecondaryDataFields = "IDObra"
        Me.GridVariosControl.Size = New System.Drawing.Size(482, 344)
        Me.GridVariosControl.TabIndex = 18
        Me.GridVariosControl.ViewName = "vFrmObraControlVarios"
        '
        'TabPageControlMediciones
        '
        Me.TabPageControlMediciones.Controls.Add(Me.pnlCertificacionTrabajo)
        Me.TabPageControlMediciones.Controls.Add(Me.Splitter2)
        Me.TabPageControlMediciones.Controls.Add(Me.pnlCertificacion)
        Me.TabPageControlMediciones.Key = "MedicionesCertificacion"
        Me.TabPageControlMediciones.Location = New System.Drawing.Point(1, 21)
        Me.TabPageControlMediciones.Name = "TabPageControlMediciones"
        Me.TabPageControlMediciones.Size = New System.Drawing.Size(482, 344)
        Me.TabPageControlMediciones.TabStop = True
        Me.TabPageControlMediciones.Text = "Certificaciones/Mediciones"
        '
        'pnlCertificacionTrabajo
        '
        Me.pnlCertificacionTrabajo.Controls.Add(Me.GridCertificacionTrabajo)
        Me.pnlCertificacionTrabajo.Controls.Add(Me.pnlLabelCertificacionTrabajo)
        Me.pnlCertificacionTrabajo.Controls.Add(Me.GridCertificacionMedicion)
        Me.pnlCertificacionTrabajo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCertificacionTrabajo.Location = New System.Drawing.Point(0, 169)
        Me.pnlCertificacionTrabajo.Name = "pnlCertificacionTrabajo"
        Me.pnlCertificacionTrabajo.Size = New System.Drawing.Size(482, 175)
        Me.pnlCertificacionTrabajo.TabIndex = 126
        '
        'GridCertificacionTrabajo
        '
        Me.GridCertificacionTrabajo.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("CodTrabajo", "ObraTrabajo", "CodTrabajo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDTrabajo", "IDTrabajo"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("QPrev", "QPrev")}))})
        Me.GridCertificacionTrabajo.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridCertificacionTrabajo_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("GridCertificacionTrabajo_DesignTimeLayout_Reference_0.Instance"), Object)
        GridCertificacionTrabajo_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {GridCertificacionTrabajo_DesignTimeLayout_Reference_0})
        GridCertificacionTrabajo_DesignTimeLayout.LayoutString = resources.GetString("GridCertificacionTrabajo_DesignTimeLayout.LayoutString")
        Me.GridCertificacionTrabajo.DesignTimeLayout = GridCertificacionTrabajo_DesignTimeLayout
        Me.GridCertificacionTrabajo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridCertificacionTrabajo.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridCertificacionTrabajo.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridCertificacionTrabajo.EntityName = "ObraCertificacionTrabajo"
        Me.GridCertificacionTrabajo.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridCertificacionTrabajo.FrozenColumns = 5
        Me.GridCertificacionTrabajo.HideColumnsWhenGrouped = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridCertificacionTrabajo.Hierarchical = True
        Me.GridCertificacionTrabajo.ImageList = Me.ImageListGrids
        Me.GridCertificacionTrabajo.Location = New System.Drawing.Point(0, 24)
        Me.GridCertificacionTrabajo.Name = "GridCertificacionTrabajo"
        Me.GridCertificacionTrabajo.PrimaryDataFields = Nothing
        Me.GridCertificacionTrabajo.RelationMode = Solmicro.Expertis.Engine.RelationMode.NoRelation
        Me.GridCertificacionTrabajo.RequeryManually = True
        Me.GridCertificacionTrabajo.SecondaryDataFields = Nothing
        Me.GridCertificacionTrabajo.Size = New System.Drawing.Size(482, 81)
        Me.GridCertificacionTrabajo.TabIndex = 23
        Me.GridCertificacionTrabajo.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridCertificacionTrabajo.ViewName = "vfrmObraCertificacionTrabajo"
        '
        'pnlLabelCertificacionTrabajo
        '
        Me.pnlLabelCertificacionTrabajo.Controls.Add(Me.optCertificacionPorCapitulos)
        Me.pnlLabelCertificacionTrabajo.Controls.Add(Me.optCertificacionPorTrabajo)
        Me.pnlLabelCertificacionTrabajo.Controls.Add(Me.lblVerCertificacionPor)
        Me.pnlLabelCertificacionTrabajo.Controls.Add(Me.lblCertificacionTrabajo)
        Me.pnlLabelCertificacionTrabajo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlLabelCertificacionTrabajo.Location = New System.Drawing.Point(0, 0)
        Me.pnlLabelCertificacionTrabajo.Name = "pnlLabelCertificacionTrabajo"
        Me.pnlLabelCertificacionTrabajo.Size = New System.Drawing.Size(482, 24)
        Me.pnlLabelCertificacionTrabajo.TabIndex = 2
        '
        'optCertificacionPorCapitulos
        '
        Me.optCertificacionPorCapitulos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.optCertificacionPorCapitulos.Location = New System.Drawing.Point(396, 5)
        Me.optCertificacionPorCapitulos.Name = "optCertificacionPorCapitulos"
        Me.optCertificacionPorCapitulos.Size = New System.Drawing.Size(78, 13)
        Me.optCertificacionPorCapitulos.TabIndex = 5
        Me.optCertificacionPorCapitulos.Text = "Capítulos"
        '
        'optCertificacionPorTrabajo
        '
        Me.optCertificacionPorTrabajo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.optCertificacionPorTrabajo.Location = New System.Drawing.Point(310, 5)
        Me.optCertificacionPorTrabajo.Name = "optCertificacionPorTrabajo"
        Me.optCertificacionPorTrabajo.Size = New System.Drawing.Size(73, 13)
        Me.optCertificacionPorTrabajo.TabIndex = 4
        Me.optCertificacionPorTrabajo.Text = "Trabajos"
        '
        'lblVerCertificacionPor
        '
        Me.lblVerCertificacionPor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVerCertificacionPor.Location = New System.Drawing.Point(176, 4)
        Me.lblVerCertificacionPor.Name = "lblVerCertificacionPor"
        Me.lblVerCertificacionPor.Size = New System.Drawing.Size(124, 13)
        Me.lblVerCertificacionPor.TabIndex = 3
        Me.lblVerCertificacionPor.Text = "Ver Certificación por"
        '
        'lblCertificacionTrabajo
        '
        Me.lblCertificacionTrabajo.Location = New System.Drawing.Point(8, 4)
        Me.lblCertificacionTrabajo.Name = "lblCertificacionTrabajo"
        Me.lblCertificacionTrabajo.Size = New System.Drawing.Size(125, 13)
        Me.lblCertificacionTrabajo.TabIndex = 2
        Me.lblCertificacionTrabajo.Text = "Certificación Trabajo"
        '
        'GridCertificacionMedicion
        '
        Me.GridCertificacionMedicion.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridCertificacionMedicion_DesignTimeLayout.LayoutString = resources.GetString("GridCertificacionMedicion_DesignTimeLayout.LayoutString")
        Me.GridCertificacionMedicion.DesignTimeLayout = GridCertificacionMedicion_DesignTimeLayout
        Me.GridCertificacionMedicion.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GridCertificacionMedicion.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridCertificacionMedicion.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridCertificacionMedicion.EntityName = "ObraCertificacionMedicion"
        Me.GridCertificacionMedicion.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridCertificacionMedicion.FrozenColumns = 5
        Me.GridCertificacionMedicion.HideColumnsWhenGrouped = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridCertificacionMedicion.Hierarchical = True
        Me.GridCertificacionMedicion.Location = New System.Drawing.Point(0, 105)
        Me.GridCertificacionMedicion.Name = "GridCertificacionMedicion"
        Me.GridCertificacionMedicion.PrimaryDataFields = Nothing
        Me.GridCertificacionMedicion.RelationMode = Solmicro.Expertis.Engine.RelationMode.NoRelation
        Me.GridCertificacionMedicion.RequeryManually = True
        Me.GridCertificacionMedicion.SecondaryDataFields = Nothing
        Me.GridCertificacionMedicion.Size = New System.Drawing.Size(482, 70)
        Me.GridCertificacionMedicion.TabIndex = 236
        Me.GridCertificacionMedicion.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridCertificacionMedicion.ViewName = "vFrmObraCertificacionMedicion"
        Me.GridCertificacionMedicion.Visible = False
        '
        'Splitter2
        '
        Me.Splitter2.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Splitter2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Splitter2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Splitter2.Location = New System.Drawing.Point(0, 164)
        Me.Splitter2.Name = "Splitter2"
        Me.Splitter2.Size = New System.Drawing.Size(482, 5)
        Me.Splitter2.TabIndex = 123
        Me.Splitter2.TabStop = False
        '
        'pnlCertificacion
        '
        Me.pnlCertificacion.Controls.Add(Me.GridCertificacion)
        Me.pnlCertificacion.Controls.Add(Me.TabTiposCertificacion)
        Me.pnlCertificacion.Controls.Add(Me.pnlLabelObraCertificacion)
        Me.pnlCertificacion.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCertificacion.Location = New System.Drawing.Point(0, 0)
        Me.pnlCertificacion.Name = "pnlCertificacion"
        Me.pnlCertificacion.Size = New System.Drawing.Size(482, 164)
        Me.pnlCertificacion.TabIndex = 122
        '
        'GridCertificacion
        '
        Me.GridCertificacion.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridCertificacion_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("GridCertificacion_DesignTimeLayout_Reference_0.Instance"), Object)
        GridCertificacion_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {GridCertificacion_DesignTimeLayout_Reference_0})
        GridCertificacion_DesignTimeLayout.LayoutString = resources.GetString("GridCertificacion_DesignTimeLayout.LayoutString")
        Me.GridCertificacion.DesignTimeLayout = GridCertificacion_DesignTimeLayout
        Me.GridCertificacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridCertificacion.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridCertificacion.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridCertificacion.EntityName = "ObraCertificacion"
        Me.GridCertificacion.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridCertificacion.FrozenColumns = 3
        Me.GridCertificacion.ImageList = Me.ImageListGrids
        Me.GridCertificacion.Location = New System.Drawing.Point(0, 50)
        Me.GridCertificacion.Name = "GridCertificacion"
        Me.GridCertificacion.PrimaryDataFields = "IDObra"
        Me.GridCertificacion.SecondaryDataFields = "IDObra"
        Me.GridCertificacion.Size = New System.Drawing.Size(482, 114)
        Me.GridCertificacion.TabIndex = 22
        Me.GridCertificacion.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridCertificacion.ViewName = "vFrmObraCertificacion"
        '
        'TabTiposCertificacion
        '
        Me.TabTiposCertificacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.TabTiposCertificacion.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabTiposCertificacion.Location = New System.Drawing.Point(0, 28)
        Me.TabTiposCertificacion.Name = "TabTiposCertificacion"
        Me.TabTiposCertificacion.Size = New System.Drawing.Size(482, 22)
        Me.TabTiposCertificacion.TabDisplay = Janus.Windows.UI.Tab.TabDisplay.Text
        Me.TabTiposCertificacion.TabIndex = 21
        Me.TabTiposCertificacion.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.UiTabCliente, Me.UiTabProduccion, Me.UiTabClienteProduccion})
        Me.TabTiposCertificacion.UseThemes = True
        '
        'UiTabCliente
        '
        Me.UiTabCliente.Key = "Cliente"
        Me.UiTabCliente.Location = New System.Drawing.Point(1, 21)
        Me.UiTabCliente.Name = "UiTabCliente"
        Me.UiTabCliente.Size = New System.Drawing.Size(480, 0)
        Me.UiTabCliente.TabStop = True
        Me.UiTabCliente.Text = "Cliente"
        '
        'UiTabProduccion
        '
        Me.UiTabProduccion.Key = "Produccion"
        Me.UiTabProduccion.Location = New System.Drawing.Point(1, 21)
        Me.UiTabProduccion.Name = "UiTabProduccion"
        Me.UiTabProduccion.Size = New System.Drawing.Size(480, 0)
        Me.UiTabProduccion.TabStop = True
        Me.UiTabProduccion.Text = "Producción"
        Me.UiTabProduccion.Visible = False
        '
        'UiTabClienteProduccion
        '
        Me.UiTabClienteProduccion.Key = "ClienteProduccion"
        Me.UiTabClienteProduccion.Location = New System.Drawing.Point(1, 21)
        Me.UiTabClienteProduccion.Name = "UiTabClienteProduccion"
        Me.UiTabClienteProduccion.Size = New System.Drawing.Size(480, 0)
        Me.UiTabClienteProduccion.TabStop = True
        Me.UiTabClienteProduccion.Text = "Cliente y Producción"
        '
        'pnlLabelObraCertificacion
        '
        Me.pnlLabelObraCertificacion.Controls.Add(Me.cbxTipoCertificacion)
        Me.pnlLabelObraCertificacion.Controls.Add(Me.pnlVerCertificacion)
        Me.pnlLabelObraCertificacion.Controls.Add(Me.lblCertificacion)
        Me.pnlLabelObraCertificacion.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlLabelObraCertificacion.Location = New System.Drawing.Point(0, 0)
        Me.pnlLabelObraCertificacion.Name = "pnlLabelObraCertificacion"
        Me.pnlLabelObraCertificacion.Size = New System.Drawing.Size(482, 28)
        Me.pnlLabelObraCertificacion.TabIndex = 1
        '
        'cbxTipoCertificacion
        '
        Me.TryDataBinding(cbxTipoCertificacion, New System.Windows.Forms.Binding("Value", Me, "TipoCertificacion", True))
        cbxTipoCertificacion_DesignTimeLayout.LayoutString = resources.GetString("cbxTipoCertificacion_DesignTimeLayout.LayoutString")
        Me.cbxTipoCertificacion.DesignTimeLayout = cbxTipoCertificacion_DesignTimeLayout
        Me.cbxTipoCertificacion.DisabledBackColor = System.Drawing.Color.White
        Me.cbxTipoCertificacion.Location = New System.Drawing.Point(99, 4)
        Me.cbxTipoCertificacion.Name = "cbxTipoCertificacion"
        Me.cbxTipoCertificacion.SelectedIndex = -1
        Me.cbxTipoCertificacion.SelectedItem = Nothing
        Me.cbxTipoCertificacion.Size = New System.Drawing.Size(84, 21)
        Me.cbxTipoCertificacion.TabIndex = 31
        '
        'pnlVerCertificacion
        '
        Me.pnlVerCertificacion.Controls.Add(Me.chkVerUltimaCertificacion)
        Me.pnlVerCertificacion.Controls.Add(Me.lblNumCertificacion)
        Me.pnlVerCertificacion.Controls.Add(Me.AdvSearchCertificacion)
        Me.pnlVerCertificacion.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlVerCertificacion.Location = New System.Drawing.Point(187, 0)
        Me.pnlVerCertificacion.Name = "pnlVerCertificacion"
        Me.pnlVerCertificacion.Size = New System.Drawing.Size(295, 28)
        Me.pnlVerCertificacion.TabIndex = 5
        '
        'chkVerUltimaCertificacion
        '
        Me.chkVerUltimaCertificacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkVerUltimaCertificacion.Location = New System.Drawing.Point(204, 8)
        Me.chkVerUltimaCertificacion.Name = "chkVerUltimaCertificacion"
        Me.chkVerUltimaCertificacion.Size = New System.Drawing.Size(82, 15)
        Me.chkVerUltimaCertificacion.TabIndex = 5
        Me.chkVerUltimaCertificacion.Text = "Ver última Certificación"
        '
        'lblNumCertificacion
        '
        Me.lblNumCertificacion.Location = New System.Drawing.Point(6, 8)
        Me.lblNumCertificacion.Name = "lblNumCertificacion"
        Me.lblNumCertificacion.Size = New System.Drawing.Size(100, 13)
        Me.lblNumCertificacion.TabIndex = 7
        Me.lblNumCertificacion.Text = "Nº. Certificación"
        '
        'AdvSearchCertificacion
        '
        Me.AdvSearchCertificacion.DisabledBackColor = System.Drawing.Color.White
        Me.AdvSearchCertificacion.DisplayField = "NCertificacion"
        Me.AdvSearchCertificacion.EntityName = "ObraCertificacion"
        Me.AdvSearchCertificacion.Location = New System.Drawing.Point(108, 4)
        Me.AdvSearchCertificacion.Name = "AdvSearchCertificacion"
        Me.AdvSearchCertificacion.PrimaryDataFields = "IdCertificacion"
        Me.AdvSearchCertificacion.SecondaryDataFields = "IdCertificacion"
        Me.AdvSearchCertificacion.Size = New System.Drawing.Size(92, 23)
        Me.AdvSearchCertificacion.TabIndex = 6
        '
        'lblCertificacion
        '
        Me.lblCertificacion.Location = New System.Drawing.Point(5, 8)
        Me.lblCertificacion.Name = "lblCertificacion"
        Me.lblCertificacion.Size = New System.Drawing.Size(91, 13)
        Me.lblCertificacion.TabIndex = 1
        Me.lblCertificacion.Text = "Certificaciones"
        '
        'pnlVerControl
        '
        Me.pnlVerControl.Controls.Add(Me.txtDescTrabajoControl)
        Me.pnlVerControl.Controls.Add(Me.lblTrabajoControl)
        Me.pnlVerControl.Controls.Add(Me.txtTrabajoControl)
        Me.pnlVerControl.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlVerControl.Location = New System.Drawing.Point(0, 26)
        Me.pnlVerControl.Name = "pnlVerControl"
        Me.pnlVerControl.Size = New System.Drawing.Size(484, 30)
        Me.pnlVerControl.TabIndex = 12
        Me.pnlVerControl.Visible = False
        '
        'txtDescTrabajoControl
        '
        Me.txtDescTrabajoControl.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescTrabajoControl.Enabled = False
        Me.txtDescTrabajoControl.Location = New System.Drawing.Point(188, 6)
        Me.txtDescTrabajoControl.Name = "txtDescTrabajoControl"
        Me.txtDescTrabajoControl.Size = New System.Drawing.Size(288, 21)
        Me.txtDescTrabajoControl.TabIndex = 201
        Me.txtDescTrabajoControl.TabStop = False
        '
        'lblTrabajoControl
        '
        Me.lblTrabajoControl.Location = New System.Drawing.Point(5, 9)
        Me.lblTrabajoControl.Name = "lblTrabajoControl"
        Me.lblTrabajoControl.Size = New System.Drawing.Size(50, 13)
        Me.lblTrabajoControl.TabIndex = 200
        Me.lblTrabajoControl.Text = "Trabajo"
        '
        'txtTrabajoControl
        '
        Me.txtTrabajoControl.DisabledBackColor = System.Drawing.Color.White
        Me.txtTrabajoControl.Enabled = False
        Me.txtTrabajoControl.Location = New System.Drawing.Point(62, 6)
        Me.txtTrabajoControl.Name = "txtTrabajoControl"
        Me.txtTrabajoControl.Size = New System.Drawing.Size(124, 21)
        Me.txtTrabajoControl.TabIndex = 199
        Me.txtTrabajoControl.TabStop = False
        '
        'pnlConfigVerControl
        '
        Me.pnlConfigVerControl.Controls.Add(Me.rbtMultinivelControl)
        Me.pnlConfigVerControl.Controls.Add(Me.lblVerControl)
        Me.pnlConfigVerControl.Controls.Add(Me.rbtNivelControl)
        Me.pnlConfigVerControl.Controls.Add(Me.rbtControlObra)
        Me.pnlConfigVerControl.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlConfigVerControl.Location = New System.Drawing.Point(0, 0)
        Me.pnlConfigVerControl.Name = "pnlConfigVerControl"
        Me.pnlConfigVerControl.Size = New System.Drawing.Size(484, 26)
        Me.pnlConfigVerControl.TabIndex = 13
        '
        'rbtMultinivelControl
        '
        Me.rbtMultinivelControl.Location = New System.Drawing.Point(379, 6)
        Me.rbtMultinivelControl.Name = "rbtMultinivelControl"
        Me.rbtMultinivelControl.Size = New System.Drawing.Size(98, 15)
        Me.rbtMultinivelControl.TabIndex = 10
        Me.rbtMultinivelControl.Text = "por Multinivel"
        '
        'lblVerControl
        '
        Me.lblVerControl.Location = New System.Drawing.Point(5, 6)
        Me.lblVerControl.Name = "lblVerControl"
        Me.lblVerControl.Size = New System.Drawing.Size(161, 13)
        Me.lblVerControl.TabIndex = 11
        Me.lblVerControl.Text = "Ver los datos de las líneas:"
        '
        'rbtNivelControl
        '
        Me.rbtNivelControl.Location = New System.Drawing.Point(297, 6)
        Me.rbtNivelControl.Name = "rbtNivelControl"
        Me.rbtNivelControl.Size = New System.Drawing.Size(78, 15)
        Me.rbtNivelControl.TabIndex = 9
        Me.rbtNivelControl.Text = "por Nivel"
        '
        'rbtControlObra
        '
        Me.rbtControlObra.Location = New System.Drawing.Point(197, 6)
        Me.rbtControlObra.Name = "rbtControlObra"
        Me.rbtControlObra.Size = New System.Drawing.Size(98, 15)
        Me.rbtControlObra.TabIndex = 8
        Me.rbtControlObra.Text = "por Proyecto"
        '
        'FraTotalesReal
        '
        Me.FraTotalesReal.Controls.Add(Me.lblTotalControl)
        Me.FraTotalesReal.Controls.Add(Me.txtTotalControl)
        Me.FraTotalesReal.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FraTotalesReal.Location = New System.Drawing.Point(0, 490)
        Me.FraTotalesReal.Name = "FraTotalesReal"
        Me.FraTotalesReal.Size = New System.Drawing.Size(484, 39)
        Me.FraTotalesReal.TabIndex = 10
        Me.FraTotalesReal.TabStop = False
        Me.FraTotalesReal.Text = "Importes Unitarios"
        '
        'lblTotalControl
        '
        Me.lblTotalControl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTotalControl.AutoSize = False
        Me.lblTotalControl.Location = New System.Drawing.Point(245, 14)
        Me.lblTotalControl.Name = "lblTotalControl"
        Me.lblTotalControl.Size = New System.Drawing.Size(113, 17)
        Me.lblTotalControl.TabIndex = 100
        Me.lblTotalControl.Text = "Total"
        Me.lblTotalControl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTotalControl
        '
        Me.txtTotalControl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotalControl.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotalControl.Enabled = False
        Me.txtTotalControl.Location = New System.Drawing.Point(363, 13)
        Me.txtTotalControl.Name = "txtTotalControl"
        Me.txtTotalControl.Size = New System.Drawing.Size(113, 21)
        Me.txtTotalControl.TabIndex = 99
        Me.txtTotalControl.TabStop = False
        '
        'TabPageHitos
        '
        Me.TabPageHitos.Controls.Add(Me.GridVencimientos)
        Me.TabPageHitos.Controls.Add(Me.pnlVerHitos)
        Me.TabPageHitos.Controls.Add(Me.pnlTotalesHitos)
        Me.TabPageHitos.Controls.Add(Me.pnlConfigTipoMonedaHitos)
        Me.TabPageHitos.Controls.Add(Me.pnlConfigVerHitos)
        Me.TabPageHitos.Key = "Hitos"
        Me.TabPageHitos.Location = New System.Drawing.Point(1, 1)
        Me.TabPageHitos.Name = "TabPageHitos"
        Me.TabPageHitos.Size = New System.Drawing.Size(484, 529)
        Me.TabPageHitos.TabStop = True
        Me.TabPageHitos.Text = "Hitos"
        '
        'GridVencimientos
        '
        Me.GridVencimientos.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDFormaPago", "FormaPago", "IDFormaPago"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDArticulo", "Articulo", "IDArticulo"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDTipoIva", "TipoIva", "IDTipoIva"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDClienteBanco", "ClienteBanco", "IDClienteBanco"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDCondicionPago", "CondicionPago", "IDCondicionPago"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDDiaPago", "DiaPago", "IDDiaPago"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDCContable", "PlanContable", "IDCContable"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("CodTrabajo", "ObraTrabajo", "CodTrabajo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDTrabajo", "IDTrabajo"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDObra", "IDObra")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDMoneda", "Moneda", "IDMoneda")})
        GridVencimientos_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("GridVencimientos_DesignTimeLayout_Reference_0.Instance"), Object)
        GridVencimientos_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("GridVencimientos_DesignTimeLayout_Reference_1.Instance"), Object)
        GridVencimientos_DesignTimeLayout_Reference_2.Instance = CType(resources.GetObject("GridVencimientos_DesignTimeLayout_Reference_2.Instance"), Object)
        GridVencimientos_DesignTimeLayout_Reference_3.Instance = CType(resources.GetObject("GridVencimientos_DesignTimeLayout_Reference_3.Instance"), Object)
        GridVencimientos_DesignTimeLayout_Reference_4.Instance = CType(resources.GetObject("GridVencimientos_DesignTimeLayout_Reference_4.Instance"), Object)
        GridVencimientos_DesignTimeLayout_Reference_5.Instance = CType(resources.GetObject("GridVencimientos_DesignTimeLayout_Reference_5.Instance"), Object)
        GridVencimientos_DesignTimeLayout_Reference_6.Instance = CType(resources.GetObject("GridVencimientos_DesignTimeLayout_Reference_6.Instance"), Object)
        GridVencimientos_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {GridVencimientos_DesignTimeLayout_Reference_0, GridVencimientos_DesignTimeLayout_Reference_1, GridVencimientos_DesignTimeLayout_Reference_2, GridVencimientos_DesignTimeLayout_Reference_3, GridVencimientos_DesignTimeLayout_Reference_4, GridVencimientos_DesignTimeLayout_Reference_5, GridVencimientos_DesignTimeLayout_Reference_6})
        GridVencimientos_DesignTimeLayout.LayoutString = resources.GetString("GridVencimientos_DesignTimeLayout.LayoutString")
        Me.GridVencimientos.DesignTimeLayout = GridVencimientos_DesignTimeLayout
        Me.GridVencimientos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridVencimientos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridVencimientos.EntityName = "ObraTrabajoFacturacion"
        Me.GridVencimientos.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridVencimientos.FrozenColumns = 10
        Me.GridVencimientos.Location = New System.Drawing.Point(0, 81)
        Me.GridVencimientos.Name = "GridVencimientos"
        Me.GridVencimientos.PrimaryDataFields = "IDObra"
        Me.GridVencimientos.SecondaryDataFields = "IDObra"
        Me.GridVencimientos.Size = New System.Drawing.Size(484, 413)
        Me.GridVencimientos.TabIndex = 90
        Me.GridVencimientos.ViewName = "vFrmObraTrabajoFacturacion"
        '
        'pnlVerHitos
        '
        Me.pnlVerHitos.Controls.Add(Me.txtDescTrabajoHitos)
        Me.pnlVerHitos.Controls.Add(Me.lblTrabajoHitos)
        Me.pnlVerHitos.Controls.Add(Me.txtTrabajoHitos)
        Me.pnlVerHitos.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlVerHitos.Location = New System.Drawing.Point(0, 51)
        Me.pnlVerHitos.Name = "pnlVerHitos"
        Me.pnlVerHitos.Size = New System.Drawing.Size(484, 30)
        Me.pnlVerHitos.TabIndex = 88
        Me.pnlVerHitos.Visible = False
        '
        'txtDescTrabajoHitos
        '
        Me.txtDescTrabajoHitos.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescTrabajoHitos.Enabled = False
        Me.txtDescTrabajoHitos.Location = New System.Drawing.Point(188, 6)
        Me.txtDescTrabajoHitos.Name = "txtDescTrabajoHitos"
        Me.txtDescTrabajoHitos.Size = New System.Drawing.Size(288, 21)
        Me.txtDescTrabajoHitos.TabIndex = 201
        Me.txtDescTrabajoHitos.TabStop = False
        '
        'lblTrabajoHitos
        '
        Me.lblTrabajoHitos.Location = New System.Drawing.Point(5, 9)
        Me.lblTrabajoHitos.Name = "lblTrabajoHitos"
        Me.lblTrabajoHitos.Size = New System.Drawing.Size(50, 13)
        Me.lblTrabajoHitos.TabIndex = 200
        Me.lblTrabajoHitos.Text = "Trabajo"
        '
        'txtTrabajoHitos
        '
        Me.txtTrabajoHitos.DisabledBackColor = System.Drawing.Color.White
        Me.txtTrabajoHitos.Enabled = False
        Me.txtTrabajoHitos.Location = New System.Drawing.Point(62, 6)
        Me.txtTrabajoHitos.Name = "txtTrabajoHitos"
        Me.txtTrabajoHitos.Size = New System.Drawing.Size(124, 21)
        Me.txtTrabajoHitos.TabIndex = 199
        Me.txtTrabajoHitos.TabStop = False
        '
        'pnlTotalesHitos
        '
        Me.pnlTotalesHitos.Controls.Add(Me.lblTotalVtoA)
        Me.pnlTotalesHitos.Controls.Add(Me.txtTotalVtoA)
        Me.pnlTotalesHitos.Controls.Add(Me.lblTotalA)
        Me.pnlTotalesHitos.Controls.Add(Me.txtTotalA)
        Me.pnlTotalesHitos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlTotalesHitos.Location = New System.Drawing.Point(0, 494)
        Me.pnlTotalesHitos.Name = "pnlTotalesHitos"
        Me.pnlTotalesHitos.Size = New System.Drawing.Size(484, 35)
        Me.pnlTotalesHitos.TabIndex = 84
        '
        'lblTotalVtoA
        '
        Me.lblTotalVtoA.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTotalVtoA.AutoSize = False
        Me.lblTotalVtoA.Location = New System.Drawing.Point(35, 12)
        Me.lblTotalVtoA.Name = "lblTotalVtoA"
        Me.lblTotalVtoA.Size = New System.Drawing.Size(89, 17)
        Me.lblTotalVtoA.TabIndex = 83
        Me.lblTotalVtoA.Text = "Importe Vto. A"
        '
        'txtTotalVtoA
        '
        Me.txtTotalVtoA.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotalVtoA.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotalVtoA.Enabled = False
        Me.txtTotalVtoA.Location = New System.Drawing.Point(130, 8)
        Me.txtTotalVtoA.Name = "txtTotalVtoA"
        Me.txtTotalVtoA.Size = New System.Drawing.Size(116, 21)
        Me.txtTotalVtoA.TabIndex = 85
        Me.txtTotalVtoA.TabStop = False
        '
        'lblTotalA
        '
        Me.lblTotalA.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTotalA.AutoSize = False
        Me.lblTotalA.Location = New System.Drawing.Point(260, 12)
        Me.lblTotalA.Name = "lblTotalA"
        Me.lblTotalA.Size = New System.Drawing.Size(94, 17)
        Me.lblTotalA.TabIndex = 86
        Me.lblTotalA.Text = "Importe Total A"
        '
        'txtTotalA
        '
        Me.txtTotalA.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotalA.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotalA.Enabled = False
        Me.txtTotalA.Location = New System.Drawing.Point(360, 8)
        Me.txtTotalA.Name = "txtTotalA"
        Me.txtTotalA.Size = New System.Drawing.Size(116, 21)
        Me.txtTotalA.TabIndex = 84
        Me.txtTotalA.TabStop = False
        '
        'pnlConfigTipoMonedaHitos
        '
        Me.pnlConfigTipoMonedaHitos.Controls.Add(Me.lblGestionMonedaHitos)
        Me.pnlConfigTipoMonedaHitos.Controls.Add(Me.rbtMonedaA)
        Me.pnlConfigTipoMonedaHitos.Controls.Add(Me.rbtMonedaCliente)
        Me.pnlConfigTipoMonedaHitos.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlConfigTipoMonedaHitos.Location = New System.Drawing.Point(0, 30)
        Me.pnlConfigTipoMonedaHitos.Name = "pnlConfigTipoMonedaHitos"
        Me.pnlConfigTipoMonedaHitos.Size = New System.Drawing.Size(484, 21)
        Me.pnlConfigTipoMonedaHitos.TabIndex = 88
        '
        'lblGestionMonedaHitos
        '
        Me.lblGestionMonedaHitos.Location = New System.Drawing.Point(6, 2)
        Me.lblGestionMonedaHitos.Name = "lblGestionMonedaHitos"
        Me.lblGestionMonedaHitos.Size = New System.Drawing.Size(200, 13)
        Me.lblGestionMonedaHitos.TabIndex = 15
        Me.lblGestionMonedaHitos.Text = "Gestionar las líneas de Hitos en : "
        '
        'rbtMonedaA
        '
        Me.rbtMonedaA.Location = New System.Drawing.Point(393, 2)
        Me.rbtMonedaA.Name = "rbtMonedaA"
        Me.rbtMonedaA.Size = New System.Drawing.Size(85, 15)
        Me.rbtMonedaA.TabIndex = 1
        Me.rbtMonedaA.Text = "Moneda A"
        '
        'rbtMonedaCliente
        '
        Me.rbtMonedaCliente.Location = New System.Drawing.Point(290, 2)
        Me.rbtMonedaCliente.Name = "rbtMonedaCliente"
        Me.rbtMonedaCliente.Size = New System.Drawing.Size(98, 15)
        Me.rbtMonedaCliente.TabIndex = 0
        Me.rbtMonedaCliente.Text = "Moneda Cliente"
        '
        'pnlConfigVerHitos
        '
        Me.pnlConfigVerHitos.Controls.Add(Me.lblVerHitos)
        Me.pnlConfigVerHitos.Controls.Add(Me.rbtHitosTrabajo)
        Me.pnlConfigVerHitos.Controls.Add(Me.rbtHitosObra)
        Me.pnlConfigVerHitos.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlConfigVerHitos.Location = New System.Drawing.Point(0, 0)
        Me.pnlConfigVerHitos.Name = "pnlConfigVerHitos"
        Me.pnlConfigVerHitos.Size = New System.Drawing.Size(484, 30)
        Me.pnlConfigVerHitos.TabIndex = 89
        '
        'lblVerHitos
        '
        Me.lblVerHitos.Location = New System.Drawing.Point(6, 8)
        Me.lblVerHitos.Name = "lblVerHitos"
        Me.lblVerHitos.Size = New System.Drawing.Size(211, 13)
        Me.lblVerHitos.TabIndex = 12
        Me.lblVerHitos.Text = "Ver los datos de las líneas de Hitos:"
        '
        'rbtHitosTrabajo
        '
        Me.rbtHitosTrabajo.Location = New System.Drawing.Point(393, 6)
        Me.rbtHitosTrabajo.Name = "rbtHitosTrabajo"
        Me.rbtHitosTrabajo.Size = New System.Drawing.Size(85, 15)
        Me.rbtHitosTrabajo.TabIndex = 1
        Me.rbtHitosTrabajo.Text = "por Trabajo"
        '
        'rbtHitosObra
        '
        Me.rbtHitosObra.Location = New System.Drawing.Point(290, 8)
        Me.rbtHitosObra.Name = "rbtHitosObra"
        Me.rbtHitosObra.Size = New System.Drawing.Size(98, 15)
        Me.rbtHitosObra.TabIndex = 0
        Me.rbtHitosObra.Text = "por Proyecto"
        '
        'TabPageTareas
        '
        Me.TabPageTareas.Controls.Add(Me.GridTareas)
        Me.TabPageTareas.Controls.Add(Me.pnlVerTareas)
        Me.TabPageTareas.Controls.Add(Me.pnlConfigVerTareas)
        Me.TabPageTareas.Key = "Tareas"
        Me.TabPageTareas.Location = New System.Drawing.Point(1, 1)
        Me.TabPageTareas.Name = "TabPageTareas"
        Me.TabPageTareas.Size = New System.Drawing.Size(484, 529)
        Me.TabPageTareas.TabStop = True
        Me.TabPageTareas.Text = "Tareas"
        '
        'GridTareas
        '
        Me.GridTareas.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("CodTrabajo", "ObraTrabajo", "CodTrabajo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDTrabajo", "IDTrabajo")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDTipoTarea", "TipoTarea", "IDTipoTarea", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("Incidencia", "Incidencia")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDIncidencia", "Incidencia", "IDIncidencia"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDOperarioSolicitante", "Operario", "IDOperario", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDOperario", "IDOperarioSolicitante"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescOperario", "DescOperarioSolicitante")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDOperario", "Operario", "IDOperario", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescOperario", "DescOperario")}))})
        Me.GridTareas.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridTareas_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("GridTareas_DesignTimeLayout_Reference_0.Instance"), Object)
        GridTareas_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("GridTareas_DesignTimeLayout_Reference_1.Instance"), Object)
        GridTareas_DesignTimeLayout_Reference_2.Instance = CType(resources.GetObject("GridTareas_DesignTimeLayout_Reference_2.Instance"), Object)
        GridTareas_DesignTimeLayout_Reference_3.Instance = CType(resources.GetObject("GridTareas_DesignTimeLayout_Reference_3.Instance"), Object)
        GridTareas_DesignTimeLayout_Reference_4.Instance = CType(resources.GetObject("GridTareas_DesignTimeLayout_Reference_4.Instance"), Object)
        GridTareas_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {GridTareas_DesignTimeLayout_Reference_0, GridTareas_DesignTimeLayout_Reference_1, GridTareas_DesignTimeLayout_Reference_2, GridTareas_DesignTimeLayout_Reference_3, GridTareas_DesignTimeLayout_Reference_4})
        GridTareas_DesignTimeLayout.LayoutString = resources.GetString("GridTareas_DesignTimeLayout.LayoutString")
        Me.GridTareas.DesignTimeLayout = GridTareas_DesignTimeLayout
        Me.GridTareas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridTareas.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridTareas.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridTareas.EntityName = "ObraTarea"
        Me.GridTareas.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridTareas.FrozenColumns = 6
        Me.GridTareas.ImageList = Me.ImageListGrids
        Me.GridTareas.Location = New System.Drawing.Point(0, 56)
        Me.GridTareas.Name = "GridTareas"
        Me.GridTareas.PrimaryDataFields = "IDObra"
        Me.GridTareas.SecondaryDataFields = "IDObra"
        Me.GridTareas.Size = New System.Drawing.Size(484, 473)
        Me.GridTareas.TabIndex = 92
        Me.GridTareas.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridTareas.ViewName = "vCITareasObra"
        '
        'pnlVerTareas
        '
        Me.pnlVerTareas.Controls.Add(Me.txtDescTrabajoTareas)
        Me.pnlVerTareas.Controls.Add(Me.lblTrabajoTareas)
        Me.pnlVerTareas.Controls.Add(Me.txtTrabajoTareas)
        Me.pnlVerTareas.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlVerTareas.Location = New System.Drawing.Point(0, 26)
        Me.pnlVerTareas.Name = "pnlVerTareas"
        Me.pnlVerTareas.Size = New System.Drawing.Size(484, 30)
        Me.pnlVerTareas.TabIndex = 90
        Me.pnlVerTareas.Visible = False
        '
        'txtDescTrabajoTareas
        '
        Me.txtDescTrabajoTareas.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescTrabajoTareas.Enabled = False
        Me.txtDescTrabajoTareas.Location = New System.Drawing.Point(188, 6)
        Me.txtDescTrabajoTareas.Name = "txtDescTrabajoTareas"
        Me.txtDescTrabajoTareas.Size = New System.Drawing.Size(288, 21)
        Me.txtDescTrabajoTareas.TabIndex = 201
        Me.txtDescTrabajoTareas.TabStop = False
        '
        'lblTrabajoTareas
        '
        Me.lblTrabajoTareas.Location = New System.Drawing.Point(5, 9)
        Me.lblTrabajoTareas.Name = "lblTrabajoTareas"
        Me.lblTrabajoTareas.Size = New System.Drawing.Size(50, 13)
        Me.lblTrabajoTareas.TabIndex = 200
        Me.lblTrabajoTareas.Text = "Trabajo"
        '
        'txtTrabajoTareas
        '
        Me.txtTrabajoTareas.DisabledBackColor = System.Drawing.Color.White
        Me.txtTrabajoTareas.Enabled = False
        Me.txtTrabajoTareas.Location = New System.Drawing.Point(62, 6)
        Me.txtTrabajoTareas.Name = "txtTrabajoTareas"
        Me.txtTrabajoTareas.Size = New System.Drawing.Size(124, 21)
        Me.txtTrabajoTareas.TabIndex = 199
        Me.txtTrabajoTareas.TabStop = False
        '
        'pnlConfigVerTareas
        '
        Me.pnlConfigVerTareas.Controls.Add(Me.lblVerTareas)
        Me.pnlConfigVerTareas.Controls.Add(Me.rbtTareasTrabajo)
        Me.pnlConfigVerTareas.Controls.Add(Me.rbtTareasObra)
        Me.pnlConfigVerTareas.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlConfigVerTareas.Location = New System.Drawing.Point(0, 0)
        Me.pnlConfigVerTareas.Name = "pnlConfigVerTareas"
        Me.pnlConfigVerTareas.Size = New System.Drawing.Size(484, 26)
        Me.pnlConfigVerTareas.TabIndex = 91
        '
        'lblVerTareas
        '
        Me.lblVerTareas.Location = New System.Drawing.Point(5, 6)
        Me.lblVerTareas.Name = "lblVerTareas"
        Me.lblVerTareas.Size = New System.Drawing.Size(221, 13)
        Me.lblVerTareas.TabIndex = 13
        Me.lblVerTareas.Text = "Ver los datos de las líneas de Tareas:"
        '
        'rbtTareasTrabajo
        '
        Me.rbtTareasTrabajo.Location = New System.Drawing.Point(392, 6)
        Me.rbtTareasTrabajo.Name = "rbtTareasTrabajo"
        Me.rbtTareasTrabajo.Size = New System.Drawing.Size(85, 15)
        Me.rbtTareasTrabajo.TabIndex = 9
        Me.rbtTareasTrabajo.Text = "por Trabajo"
        '
        'rbtTareasObra
        '
        Me.rbtTareasObra.Location = New System.Drawing.Point(289, 6)
        Me.rbtTareasObra.Name = "rbtTareasObra"
        Me.rbtTareasObra.Size = New System.Drawing.Size(98, 15)
        Me.rbtTareasObra.TabIndex = 8
        Me.rbtTareasObra.Text = "por Proyecto"
        '
        'TabPageOficios
        '
        Me.TabPageOficios.Controls.Add(Me.GridOperariosTrabajo)
        Me.TabPageOficios.Controls.Add(Me.pnlVerOperarios)
        Me.TabPageOficios.Controls.Add(Me.pnlConfigVerOperarios)
        Me.TabPageOficios.Key = "Oficios"
        Me.TabPageOficios.Location = New System.Drawing.Point(1, 1)
        Me.TabPageOficios.Name = "TabPageOficios"
        Me.TabPageOficios.Size = New System.Drawing.Size(484, 529)
        Me.TabPageOficios.TabStop = True
        Me.TabPageOficios.Text = "Operarios / Oficios"
        '
        'GridOperariosTrabajo
        '
        Me.GridOperariosTrabajo.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("CodTrabajo", "ObraTrabajo", "CodTrabajo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDTrabajo", "IDTrabajo")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDOperario", "Operario", "IDOperario", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescOperario", "DescOperario")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDOficio", "Oficio", "IDOficio", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescOficio", "DescOficio")}))})
        GridOperariosTrabajo_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("GridOperariosTrabajo_DesignTimeLayout_Reference_0.Instance"), Object)
        GridOperariosTrabajo_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("GridOperariosTrabajo_DesignTimeLayout_Reference_1.Instance"), Object)
        GridOperariosTrabajo_DesignTimeLayout_Reference_2.Instance = CType(resources.GetObject("GridOperariosTrabajo_DesignTimeLayout_Reference_2.Instance"), Object)
        GridOperariosTrabajo_DesignTimeLayout_Reference_3.Instance = CType(resources.GetObject("GridOperariosTrabajo_DesignTimeLayout_Reference_3.Instance"), Object)
        GridOperariosTrabajo_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {GridOperariosTrabajo_DesignTimeLayout_Reference_0, GridOperariosTrabajo_DesignTimeLayout_Reference_1, GridOperariosTrabajo_DesignTimeLayout_Reference_2, GridOperariosTrabajo_DesignTimeLayout_Reference_3})
        GridOperariosTrabajo_DesignTimeLayout.LayoutString = resources.GetString("GridOperariosTrabajo_DesignTimeLayout.LayoutString")
        Me.GridOperariosTrabajo.DesignTimeLayout = GridOperariosTrabajo_DesignTimeLayout
        Me.GridOperariosTrabajo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridOperariosTrabajo.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridOperariosTrabajo.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridOperariosTrabajo.EntityName = ""
        Me.GridOperariosTrabajo.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridOperariosTrabajo.FrozenColumns = 6
        Me.GridOperariosTrabajo.ImageList = Me.ImageListGrids
        Me.GridOperariosTrabajo.Location = New System.Drawing.Point(0, 56)
        Me.GridOperariosTrabajo.Name = "GridOperariosTrabajo"
        Me.GridOperariosTrabajo.PrimaryDataFields = ""
        Me.GridOperariosTrabajo.SecondaryDataFields = ""
        Me.GridOperariosTrabajo.Size = New System.Drawing.Size(484, 473)
        Me.GridOperariosTrabajo.TabIndex = 94
        Me.GridOperariosTrabajo.ViewName = ""
        '
        'pnlVerOperarios
        '
        Me.pnlVerOperarios.Controls.Add(Me.txtDescTrabajoOperarios)
        Me.pnlVerOperarios.Controls.Add(Me.lblTrabajoOperarios)
        Me.pnlVerOperarios.Controls.Add(Me.txtTrabajoOperarios)
        Me.pnlVerOperarios.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlVerOperarios.Location = New System.Drawing.Point(0, 26)
        Me.pnlVerOperarios.Name = "pnlVerOperarios"
        Me.pnlVerOperarios.Size = New System.Drawing.Size(484, 30)
        Me.pnlVerOperarios.TabIndex = 92
        Me.pnlVerOperarios.Visible = False
        '
        'txtDescTrabajoOperarios
        '
        Me.txtDescTrabajoOperarios.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescTrabajoOperarios.Enabled = False
        Me.txtDescTrabajoOperarios.Location = New System.Drawing.Point(188, 6)
        Me.txtDescTrabajoOperarios.Name = "txtDescTrabajoOperarios"
        Me.txtDescTrabajoOperarios.Size = New System.Drawing.Size(288, 21)
        Me.txtDescTrabajoOperarios.TabIndex = 201
        Me.txtDescTrabajoOperarios.TabStop = False
        '
        'lblTrabajoOperarios
        '
        Me.lblTrabajoOperarios.Location = New System.Drawing.Point(5, 9)
        Me.lblTrabajoOperarios.Name = "lblTrabajoOperarios"
        Me.lblTrabajoOperarios.Size = New System.Drawing.Size(50, 13)
        Me.lblTrabajoOperarios.TabIndex = 200
        Me.lblTrabajoOperarios.Text = "Trabajo"
        '
        'txtTrabajoOperarios
        '
        Me.txtTrabajoOperarios.DisabledBackColor = System.Drawing.Color.White
        Me.txtTrabajoOperarios.Enabled = False
        Me.txtTrabajoOperarios.Location = New System.Drawing.Point(62, 6)
        Me.txtTrabajoOperarios.Name = "txtTrabajoOperarios"
        Me.txtTrabajoOperarios.Size = New System.Drawing.Size(124, 21)
        Me.txtTrabajoOperarios.TabIndex = 199
        Me.txtTrabajoOperarios.TabStop = False
        '
        'pnlConfigVerOperarios
        '
        Me.pnlConfigVerOperarios.Controls.Add(Me.lblVerOperarios)
        Me.pnlConfigVerOperarios.Controls.Add(Me.rbtOperariosTrabajo)
        Me.pnlConfigVerOperarios.Controls.Add(Me.rbtOperariosObra)
        Me.pnlConfigVerOperarios.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlConfigVerOperarios.Location = New System.Drawing.Point(0, 0)
        Me.pnlConfigVerOperarios.Name = "pnlConfigVerOperarios"
        Me.pnlConfigVerOperarios.Size = New System.Drawing.Size(484, 26)
        Me.pnlConfigVerOperarios.TabIndex = 93
        '
        'lblVerOperarios
        '
        Me.lblVerOperarios.Location = New System.Drawing.Point(3, 6)
        Me.lblVerOperarios.Name = "lblVerOperarios"
        Me.lblVerOperarios.Size = New System.Drawing.Size(221, 13)
        Me.lblVerOperarios.TabIndex = 14
        Me.lblVerOperarios.Text = "Ver los datos de las líneas de Oficios:"
        '
        'rbtOperariosTrabajo
        '
        Me.rbtOperariosTrabajo.Location = New System.Drawing.Point(392, 6)
        Me.rbtOperariosTrabajo.Name = "rbtOperariosTrabajo"
        Me.rbtOperariosTrabajo.Size = New System.Drawing.Size(85, 15)
        Me.rbtOperariosTrabajo.TabIndex = 9
        Me.rbtOperariosTrabajo.Text = "por Trabajo"
        '
        'rbtOperariosObra
        '
        Me.rbtOperariosObra.Location = New System.Drawing.Point(289, 6)
        Me.rbtOperariosObra.Name = "rbtOperariosObra"
        Me.rbtOperariosObra.Size = New System.Drawing.Size(98, 15)
        Me.rbtOperariosObra.TabIndex = 8
        Me.rbtOperariosObra.Text = "por Proyecto"
        '
        'TabPageAvance
        '
        Me.TabPageAvance.Controls.Add(Me.GridAvanceTrabajo)
        Me.TabPageAvance.Controls.Add(Me.pnlLeyendaAvance)
        Me.TabPageAvance.Controls.Add(Me.pnlVerAvance)
        Me.TabPageAvance.Key = "Avance"
        Me.TabPageAvance.Location = New System.Drawing.Point(1, 1)
        Me.TabPageAvance.Name = "TabPageAvance"
        Me.TabPageAvance.Size = New System.Drawing.Size(484, 466)
        Me.TabPageAvance.TabStop = True
        Me.TabPageAvance.Text = "Avance"
        '
        'GridAvanceTrabajo
        '
        Me.GridAvanceTrabajo.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridAvanceTrabajo_DesignTimeLayout.LayoutString = resources.GetString("GridAvanceTrabajo_DesignTimeLayout.LayoutString")
        Me.GridAvanceTrabajo.DesignTimeLayout = GridAvanceTrabajo_DesignTimeLayout
        Me.GridAvanceTrabajo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridAvanceTrabajo.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridAvanceTrabajo.EntityName = Nothing
        Me.GridAvanceTrabajo.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridAvanceTrabajo.ImageList = Me.ImageListAvance
        Me.GridAvanceTrabajo.Location = New System.Drawing.Point(0, 54)
        Me.GridAvanceTrabajo.Name = "GridAvanceTrabajo"
        Me.GridAvanceTrabajo.PrimaryDataFields = Nothing
        Me.GridAvanceTrabajo.SecondaryDataFields = Nothing
        Me.GridAvanceTrabajo.Size = New System.Drawing.Size(484, 382)
        Me.GridAvanceTrabajo.TabIndex = 16
        Me.GridAvanceTrabajo.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridAvanceTrabajo.ViewName = "vFrmObraTrabajoAvance"
        '
        'ImageListAvance
        '
        Me.ImageListAvance.ImageStream = CType(resources.GetObject("ImageListAvance.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListAvance.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListAvance.Images.SetKeyName(0, "nav_up_green.ico")
        Me.ImageListAvance.Images.SetKeyName(1, "nav_down_red.ico")
        '
        'pnlLeyendaAvance
        '
        Me.pnlLeyendaAvance.Controls.Add(Me.lblPeriodosRecalculados)
        Me.pnlLeyendaAvance.Controls.Add(Me.pnlPeriodosRecalculados)
        Me.pnlLeyendaAvance.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlLeyendaAvance.Location = New System.Drawing.Point(0, 436)
        Me.pnlLeyendaAvance.Name = "pnlLeyendaAvance"
        Me.pnlLeyendaAvance.Size = New System.Drawing.Size(484, 30)
        Me.pnlLeyendaAvance.TabIndex = 15
        '
        'lblPeriodosRecalculados
        '
        Me.lblPeriodosRecalculados.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPeriodosRecalculados.Location = New System.Drawing.Point(358, 9)
        Me.lblPeriodosRecalculados.Name = "lblPeriodosRecalculados"
        Me.lblPeriodosRecalculados.Size = New System.Drawing.Size(119, 13)
        Me.lblPeriodosRecalculados.TabIndex = 14
        Me.lblPeriodosRecalculados.Text = "Periodo recalculado"
        '
        'pnlPeriodosRecalculados
        '
        Me.pnlPeriodosRecalculados.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlPeriodosRecalculados.BackColor = System.Drawing.Color.PaleGreen
        Me.pnlPeriodosRecalculados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPeriodosRecalculados.Location = New System.Drawing.Point(333, 5)
        Me.pnlPeriodosRecalculados.Name = "pnlPeriodosRecalculados"
        Me.pnlPeriodosRecalculados.Size = New System.Drawing.Size(21, 21)
        Me.pnlPeriodosRecalculados.TabIndex = 13
        '
        'pnlVerAvance
        '
        Me.pnlVerAvance.Controls.Add(Me.Label3)
        Me.pnlVerAvance.Controls.Add(Me.cbxFechaFinTrabajoAvance)
        Me.pnlVerAvance.Controls.Add(Me.Label4)
        Me.pnlVerAvance.Controls.Add(Me.cbxFechaInicioTrabajoAvance)
        Me.pnlVerAvance.Controls.Add(Me.txtDescTrabajoAvance)
        Me.pnlVerAvance.Controls.Add(Me.lblTrabajoAvance)
        Me.pnlVerAvance.Controls.Add(Me.txtTrabajoAvance)
        Me.pnlVerAvance.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlVerAvance.Location = New System.Drawing.Point(0, 0)
        Me.pnlVerAvance.Name = "pnlVerAvance"
        Me.pnlVerAvance.Size = New System.Drawing.Size(484, 54)
        Me.pnlVerAvance.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(212, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 251
        Me.Label3.Text = "Fecha fin"
        '
        'cbxFechaFinTrabajoAvance
        '
        Me.cbxFechaFinTrabajoAvance.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaFinTrabajoAvance.Enabled = False
        Me.cbxFechaFinTrabajoAvance.Location = New System.Drawing.Point(274, 30)
        Me.cbxFechaFinTrabajoAvance.Name = "cbxFechaFinTrabajoAvance"
        Me.cbxFechaFinTrabajoAvance.Size = New System.Drawing.Size(95, 21)
        Me.cbxFechaFinTrabajoAvance.TabIndex = 250
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(5, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 252
        Me.Label4.Text = "Fecha inicio"
        '
        'cbxFechaInicioTrabajoAvance
        '
        Me.cbxFechaInicioTrabajoAvance.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaInicioTrabajoAvance.Enabled = False
        Me.cbxFechaInicioTrabajoAvance.Location = New System.Drawing.Point(83, 30)
        Me.cbxFechaInicioTrabajoAvance.Name = "cbxFechaInicioTrabajoAvance"
        Me.cbxFechaInicioTrabajoAvance.Size = New System.Drawing.Size(95, 21)
        Me.cbxFechaInicioTrabajoAvance.TabIndex = 249
        '
        'txtDescTrabajoAvance
        '
        Me.txtDescTrabajoAvance.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescTrabajoAvance.Enabled = False
        Me.txtDescTrabajoAvance.Location = New System.Drawing.Point(188, 6)
        Me.txtDescTrabajoAvance.Name = "txtDescTrabajoAvance"
        Me.txtDescTrabajoAvance.Size = New System.Drawing.Size(288, 21)
        Me.txtDescTrabajoAvance.TabIndex = 201
        Me.txtDescTrabajoAvance.TabStop = False
        '
        'lblTrabajoAvance
        '
        Me.lblTrabajoAvance.Location = New System.Drawing.Point(5, 7)
        Me.lblTrabajoAvance.Name = "lblTrabajoAvance"
        Me.lblTrabajoAvance.Size = New System.Drawing.Size(50, 13)
        Me.lblTrabajoAvance.TabIndex = 200
        Me.lblTrabajoAvance.Text = "Trabajo"
        '
        'txtTrabajoAvance
        '
        Me.txtTrabajoAvance.DisabledBackColor = System.Drawing.Color.White
        Me.txtTrabajoAvance.Enabled = False
        Me.txtTrabajoAvance.Location = New System.Drawing.Point(62, 6)
        Me.txtTrabajoAvance.Name = "txtTrabajoAvance"
        Me.txtTrabajoAvance.Size = New System.Drawing.Size(124, 21)
        Me.txtTrabajoAvance.TabIndex = 199
        Me.txtTrabajoAvance.TabStop = False
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(270, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(5, 531)
        Me.Splitter1.TabIndex = 1
        Me.Splitter1.TabStop = False
        '
        'pnlTrabajos
        '
        Me.pnlTrabajos.Controls.Add(Me.TvwTrabajos)
        Me.pnlTrabajos.Controls.Add(Me.FraArbol)
        Me.pnlTrabajos.Controls.Add(Me.FraCriterios)
        Me.pnlTrabajos.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlTrabajos.Location = New System.Drawing.Point(0, 0)
        Me.pnlTrabajos.Name = "pnlTrabajos"
        Me.pnlTrabajos.Size = New System.Drawing.Size(270, 531)
        Me.pnlTrabajos.TabIndex = 0
        '
        'TvwTrabajos
        '
        Me.TvwTrabajos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TvwTrabajos.Location = New System.Drawing.Point(0, 87)
        Me.TvwTrabajos.Name = "TvwTrabajos"
        Me.TvwTrabajos.Size = New System.Drawing.Size(270, 404)
        Me.TvwTrabajos.TabIndex = 223
        '
        'FraArbol
        '
        Me.FraArbol.Controls.Add(Me.chkVerPorcentajes)
        Me.FraArbol.Controls.Add(Me.rbtMinimizarTree)
        Me.FraArbol.Controls.Add(Me.rbtMaximizarTree)
        Me.FraArbol.Controls.Add(Me.lblEstadoDistintoDE)
        Me.FraArbol.Controls.Add(Me.cbxEstadoDistintoDE)
        Me.FraArbol.Dock = System.Windows.Forms.DockStyle.Top
        Me.FraArbol.Location = New System.Drawing.Point(0, 0)
        Me.FraArbol.Name = "FraArbol"
        Me.FraArbol.Size = New System.Drawing.Size(270, 87)
        Me.FraArbol.TabIndex = 10
        Me.FraArbol.TabStop = False
        Me.FraArbol.Text = "Criterios árbol"
        '
        'chkVerPorcentajes
        '
        Me.chkVerPorcentajes.Location = New System.Drawing.Point(8, 35)
        Me.chkVerPorcentajes.Name = "chkVerPorcentajes"
        Me.chkVerPorcentajes.Size = New System.Drawing.Size(256, 20)
        Me.chkVerPorcentajes.TabIndex = 13
        Me.chkVerPorcentajes.Text = "Ver incrementos"
        '
        'rbtMinimizarTree
        '
        Me.rbtMinimizarTree.Location = New System.Drawing.Point(167, 16)
        Me.rbtMinimizarTree.Name = "rbtMinimizarTree"
        Me.rbtMinimizarTree.Size = New System.Drawing.Size(97, 15)
        Me.rbtMinimizarTree.TabIndex = 12
        Me.rbtMinimizarTree.Text = "Contraer"
        '
        'rbtMaximizarTree
        '
        Me.rbtMaximizarTree.Location = New System.Drawing.Point(8, 16)
        Me.rbtMaximizarTree.Name = "rbtMaximizarTree"
        Me.rbtMaximizarTree.Size = New System.Drawing.Size(104, 16)
        Me.rbtMaximizarTree.TabIndex = 11
        Me.rbtMaximizarTree.Text = "Expandir"
        '
        'lblEstadoDistintoDE
        '
        Me.lblEstadoDistintoDE.Location = New System.Drawing.Point(5, 62)
        Me.lblEstadoDistintoDE.Name = "lblEstadoDistintoDE"
        Me.lblEstadoDistintoDE.Size = New System.Drawing.Size(67, 13)
        Me.lblEstadoDistintoDE.TabIndex = 222
        Me.lblEstadoDistintoDE.Text = "Estado <>"
        '
        'cbxEstadoDistintoDE
        '
        cbxEstadoDistintoDE_DesignTimeLayout.LayoutString = resources.GetString("cbxEstadoDistintoDE_DesignTimeLayout.LayoutString")
        Me.cbxEstadoDistintoDE.DesignTimeLayout = cbxEstadoDistintoDE_DesignTimeLayout
        Me.cbxEstadoDistintoDE.DisabledBackColor = System.Drawing.Color.White
        Me.cbxEstadoDistintoDE.DisplayMember = "Value"
        Me.cbxEstadoDistintoDE.Location = New System.Drawing.Point(75, 59)
        Me.cbxEstadoDistintoDE.Name = "cbxEstadoDistintoDE"
        Me.cbxEstadoDistintoDE.PrimaryDataFields = "Estado"
        Me.cbxEstadoDistintoDE.SecondaryDataFields = "Value"
        Me.cbxEstadoDistintoDE.SelectedIndex = -1
        Me.cbxEstadoDistintoDE.SelectedItem = Nothing
        Me.cbxEstadoDistintoDE.Size = New System.Drawing.Size(189, 21)
        Me.cbxEstadoDistintoDE.TabIndex = 14
        '
        'FraCriterios
        '
        Me.FraCriterios.Controls.Add(Me.RdTimeObras)
        Me.FraCriterios.Controls.Add(Me.rbtVerProyectoCompleto)
        Me.FraCriterios.Controls.Add(Me.rbtVerGrid)
        Me.FraCriterios.Controls.Add(Me.rbtVerFicha)
        Me.FraCriterios.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FraCriterios.Location = New System.Drawing.Point(0, 491)
        Me.FraCriterios.Name = "FraCriterios"
        Me.FraCriterios.Size = New System.Drawing.Size(270, 40)
        Me.FraCriterios.TabIndex = 0
        Me.FraCriterios.TabStop = False
        Me.FraCriterios.Text = "Formato Trabajo"
        '
        'RdTimeObras
        '
        Me.RdTimeObras.Location = New System.Drawing.Point(199, 18)
        Me.RdTimeObras.Name = "RdTimeObras"
        Me.RdTimeObras.Size = New System.Drawing.Size(65, 16)
        Me.RdTimeObras.TabIndex = 218
        Me.RdTimeObras.Text = "Gráfico"
        '
        'rbtVerProyectoCompleto
        '
        Me.rbtVerProyectoCompleto.Location = New System.Drawing.Point(120, 18)
        Me.rbtVerProyectoCompleto.Name = "rbtVerProyectoCompleto"
        Me.rbtVerProyectoCompleto.Size = New System.Drawing.Size(79, 16)
        Me.rbtVerProyectoCompleto.TabIndex = 217
        Me.rbtVerProyectoCompleto.Text = "Completo"
        '
        'rbtVerGrid
        '
        Me.rbtVerGrid.Location = New System.Drawing.Point(67, 18)
        Me.rbtVerGrid.Name = "rbtVerGrid"
        Me.rbtVerGrid.Size = New System.Drawing.Size(50, 16)
        Me.rbtVerGrid.TabIndex = 216
        Me.rbtVerGrid.Text = "Grid"
        '
        'rbtVerFicha
        '
        Me.rbtVerFicha.Location = New System.Drawing.Point(8, 18)
        Me.rbtVerFicha.Name = "rbtVerFicha"
        Me.rbtVerFicha.Size = New System.Drawing.Size(53, 16)
        Me.rbtVerFicha.TabIndex = 215
        Me.rbtVerFicha.Text = "Ficha"
        '
        'TabPageCaracteristicas
        '
        Me.TabPageCaracteristicas.Controls.Add(Me.GridCaracteristicas)
        Me.TabPageCaracteristicas.Key = "Caracteristicas"
        Me.TabPageCaracteristicas.Location = New System.Drawing.Point(1, 22)
        Me.TabPageCaracteristicas.Name = "TabPageCaracteristicas"
        Me.TabPageCaracteristicas.Size = New System.Drawing.Size(782, 531)
        Me.TabPageCaracteristicas.TabStop = True
        Me.TabPageCaracteristicas.Text = "Características"
        '
        'GridCaracteristicas
        '
        Me.GridCaracteristicas.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDGrupo", "ObraGrupoCaracteristica", "IDGrupo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescGrupo", "DescGrupo")}))})
        GridCaracteristicas_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("GridCaracteristicas_DesignTimeLayout_Reference_0.Instance"), Object)
        GridCaracteristicas_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {GridCaracteristicas_DesignTimeLayout_Reference_0})
        GridCaracteristicas_DesignTimeLayout.LayoutString = resources.GetString("GridCaracteristicas_DesignTimeLayout.LayoutString")
        Me.GridCaracteristicas.DesignTimeLayout = GridCaracteristicas_DesignTimeLayout
        Me.GridCaracteristicas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridCaracteristicas.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridCaracteristicas.EntityName = "ObraCaracteristica"
        Me.GridCaracteristicas.Location = New System.Drawing.Point(0, 0)
        Me.GridCaracteristicas.Name = "GridCaracteristicas"
        Me.GridCaracteristicas.PrimaryDataFields = "IDObra"
        Me.GridCaracteristicas.SecondaryDataFields = "IDObra"
        Me.GridCaracteristicas.Size = New System.Drawing.Size(782, 531)
        Me.GridCaracteristicas.TabIndex = 41
        Me.GridCaracteristicas.ViewName = "vFrmObraCaracteristica"
        '
        'TabPageRecursos
        '
        Me.TabPageRecursos.Controls.Add(Me.GridRecursos)
        Me.TabPageRecursos.Key = "Recursos"
        Me.TabPageRecursos.Location = New System.Drawing.Point(1, 22)
        Me.TabPageRecursos.Name = "TabPageRecursos"
        Me.TabPageRecursos.Size = New System.Drawing.Size(782, 531)
        Me.TabPageRecursos.TabStop = True
        Me.TabPageRecursos.Text = "Recursos"
        '
        'GridRecursos
        '
        Me.GridRecursos.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDOperario", "Operario", "IDOperario", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IdCategoria", "IdCategoria"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDOficio", "IDOficio"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescOperario", "DescOperario")}))})
        GridRecursos_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("GridRecursos_DesignTimeLayout_Reference_0.Instance"), Object)
        GridRecursos_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("GridRecursos_DesignTimeLayout_Reference_1.Instance"), Object)
        GridRecursos_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {GridRecursos_DesignTimeLayout_Reference_0, GridRecursos_DesignTimeLayout_Reference_1})
        GridRecursos_DesignTimeLayout.LayoutString = resources.GetString("GridRecursos_DesignTimeLayout.LayoutString")
        Me.GridRecursos.DesignTimeLayout = GridRecursos_DesignTimeLayout
        Me.GridRecursos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridRecursos.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridRecursos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridRecursos.EntityName = "ObraOperario"
        Me.GridRecursos.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridRecursos.ImageList = Me.ImageListGrids
        Me.GridRecursos.Location = New System.Drawing.Point(0, 0)
        Me.GridRecursos.Name = "GridRecursos"
        Me.GridRecursos.PrimaryDataFields = "IDObra"
        Me.GridRecursos.SecondaryDataFields = "IDObra"
        Me.GridRecursos.Size = New System.Drawing.Size(782, 531)
        Me.GridRecursos.TabIndex = 53
        Me.GridRecursos.ViewName = "vFrmObraOperario"
        '
        'TabPageSeguimiento
        '
        Me.TabPageSeguimiento.Controls.Add(Me.pnlObservaciones)
        Me.TabPageSeguimiento.Controls.Add(Me.fra)
        Me.TabPageSeguimiento.Controls.Add(Me.Panel1)
        Me.TabPageSeguimiento.Controls.Add(Me.FraDireccion)
        Me.TabPageSeguimiento.Controls.Add(Me.txtIdDireccion)
        Me.TabPageSeguimiento.Key = "Seguimiento"
        Me.TabPageSeguimiento.Location = New System.Drawing.Point(1, 22)
        Me.TabPageSeguimiento.Name = "TabPageSeguimiento"
        Me.TabPageSeguimiento.Size = New System.Drawing.Size(782, 531)
        Me.TabPageSeguimiento.TabStop = True
        Me.TabPageSeguimiento.Text = "Seguimiento"
        '
        'pnlObservaciones
        '
        Me.pnlObservaciones.Controls.Add(Me.lblTexto)
        Me.pnlObservaciones.Controls.Add(Me.txtTexto)
        Me.pnlObservaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlObservaciones.Location = New System.Drawing.Point(0, 292)
        Me.pnlObservaciones.Name = "pnlObservaciones"
        Me.pnlObservaciones.Size = New System.Drawing.Size(481, 239)
        Me.pnlObservaciones.TabIndex = 39
        '
        'lblTexto
        '
        Me.lblTexto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTexto.Location = New System.Drawing.Point(3, 5)
        Me.lblTexto.Name = "lblTexto"
        Me.lblTexto.Size = New System.Drawing.Size(91, 13)
        Me.lblTexto.TabIndex = 181
        Me.lblTexto.Text = "Observaciones"
        '
        'txtTexto
        '
        Me.txtTexto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TryDataBinding(txtTexto, New System.Windows.Forms.Binding("Text", Me, "Texto", True))
        Me.txtTexto.DisabledBackColor = System.Drawing.Color.White
        Me.txtTexto.Location = New System.Drawing.Point(96, 2)
        Me.txtTexto.Multiline = True
        Me.txtTexto.Name = "txtTexto"
        Me.txtTexto.Size = New System.Drawing.Size(382, 232)
        Me.txtTexto.TabIndex = 40
        '
        'fra
        '
        Me.fra.Controls.Add(Me.txtTotalBeneficioIndustrial)
        Me.fra.Controls.Add(Me.txtTotalCoefBaja)
        Me.fra.Controls.Add(Me.txtTotalGastosGenerales)
        Me.fra.Controls.Add(Me.UiGroupBox3)
        Me.fra.Controls.Add(Me.lblImporteIva)
        Me.fra.Controls.Add(Me.txtTotalIva)
        Me.fra.Controls.Add(Me.lblTOTALObraVenta)
        Me.fra.Controls.Add(Me.txtImpPrevVentaABis)
        Me.fra.Controls.Add(Me.lblTotal)
        Me.fra.Controls.Add(Me.txtTotal)
        Me.fra.Controls.Add(Me.lblBeneficioIndustrial)
        Me.fra.Controls.Add(Me.txtBeneficioIndustrial)
        Me.fra.Controls.Add(Me.lblCoefBaja)
        Me.fra.Controls.Add(Me.txtCoefBaja)
        Me.fra.Controls.Add(Me.lblGastosGenerales)
        Me.fra.Controls.Add(Me.txtGastosGenerales)
        Me.fra.Dock = System.Windows.Forms.DockStyle.Right
        Me.fra.Location = New System.Drawing.Point(481, 292)
        Me.fra.Name = "fra"
        Me.fra.Size = New System.Drawing.Size(301, 239)
        Me.fra.TabIndex = 41
        Me.fra.TabStop = False
        '
        'txtTotalBeneficioIndustrial
        '
        Me.txtTotalBeneficioIndustrial.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotalBeneficioIndustrial.Enabled = False
        Me.txtTotalBeneficioIndustrial.Location = New System.Drawing.Point(192, 93)
        Me.txtTotalBeneficioIndustrial.Name = "txtTotalBeneficioIndustrial"
        Me.txtTotalBeneficioIndustrial.Size = New System.Drawing.Size(100, 21)
        Me.txtTotalBeneficioIndustrial.TabIndex = 124
        Me.txtTotalBeneficioIndustrial.TabStop = False
        '
        'txtTotalCoefBaja
        '
        Me.txtTotalCoefBaja.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotalCoefBaja.Enabled = False
        Me.txtTotalCoefBaja.Location = New System.Drawing.Point(192, 117)
        Me.txtTotalCoefBaja.Name = "txtTotalCoefBaja"
        Me.txtTotalCoefBaja.Size = New System.Drawing.Size(100, 21)
        Me.txtTotalCoefBaja.TabIndex = 125
        Me.txtTotalCoefBaja.TabStop = False
        '
        'txtTotalGastosGenerales
        '
        Me.txtTotalGastosGenerales.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotalGastosGenerales.Enabled = False
        Me.txtTotalGastosGenerales.Location = New System.Drawing.Point(192, 69)
        Me.txtTotalGastosGenerales.Name = "txtTotalGastosGenerales"
        Me.txtTotalGastosGenerales.Size = New System.Drawing.Size(100, 21)
        Me.txtTotalGastosGenerales.TabIndex = 123
        Me.txtTotalGastosGenerales.TabStop = False
        '
        'UiGroupBox3
        '
        Me.UiGroupBox3.Location = New System.Drawing.Point(16, 163)
        Me.UiGroupBox3.Name = "UiGroupBox3"
        Me.UiGroupBox3.Size = New System.Drawing.Size(280, 3)
        Me.UiGroupBox3.TabIndex = 122
        '
        'lblImporteIva
        '
        Me.lblImporteIva.Location = New System.Drawing.Point(16, 145)
        Me.lblImporteIva.Name = "lblImporteIva"
        Me.lblImporteIva.Size = New System.Drawing.Size(38, 13)
        Me.lblImporteIva.TabIndex = 121
        Me.lblImporteIva.Text = "I.V.A."
        '
        'txtTotalIva
        '
        Me.txtTotalIva.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotalIva.Enabled = False
        Me.txtTotalIva.Location = New System.Drawing.Point(192, 141)
        Me.txtTotalIva.Name = "txtTotalIva"
        Me.txtTotalIva.Size = New System.Drawing.Size(100, 21)
        Me.txtTotalIva.TabIndex = 120
        Me.txtTotalIva.TabStop = False
        '
        'lblTOTALObraVenta
        '
        Me.lblTOTALObraVenta.Location = New System.Drawing.Point(16, 49)
        Me.lblTOTALObraVenta.Name = "lblTOTALObraVenta"
        Me.lblTOTALObraVenta.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblTOTALObraVenta.Size = New System.Drawing.Size(133, 13)
        Me.lblTOTALObraVenta.TabIndex = 119
        Me.lblTOTALObraVenta.Text = "TOTAL Proyecto Venta"
        '
        'txtImpPrevVentaABis
        '
        Me.TryDataBinding(txtImpPrevVentaABis, New System.Windows.Forms.Binding("Value", Me, "ImpPrevVentaA", True))
        Me.txtImpPrevVentaABis.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPrevVentaABis.Enabled = False
        Me.txtImpPrevVentaABis.Location = New System.Drawing.Point(192, 45)
        Me.txtImpPrevVentaABis.Name = "txtImpPrevVentaABis"
        Me.txtImpPrevVentaABis.Size = New System.Drawing.Size(100, 21)
        Me.txtImpPrevVentaABis.TabIndex = 118
        Me.txtImpPrevVentaABis.TabStop = False
        '
        'lblTotal
        '
        Me.lblTotal.Location = New System.Drawing.Point(16, 173)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(43, 13)
        Me.lblTotal.TabIndex = 117
        Me.lblTotal.Text = "TOTAL"
        '
        'txtTotal
        '
        Me.txtTotal.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(192, 169)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(100, 21)
        Me.txtTotal.TabIndex = 116
        Me.txtTotal.TabStop = False
        '
        'lblBeneficioIndustrial
        '
        Me.lblBeneficioIndustrial.Location = New System.Drawing.Point(16, 97)
        Me.lblBeneficioIndustrial.Name = "lblBeneficioIndustrial"
        Me.lblBeneficioIndustrial.Size = New System.Drawing.Size(117, 13)
        Me.lblBeneficioIndustrial.TabIndex = 113
        Me.lblBeneficioIndustrial.Text = "Beneficio Industrial"
        '
        'txtBeneficioIndustrial
        '
        Me.TryDataBinding(txtBeneficioIndustrial, New System.Windows.Forms.Binding("Value", Me, "BeneficioIndustrial", True))
        Me.txtBeneficioIndustrial.DisabledBackColor = System.Drawing.Color.White
        Me.txtBeneficioIndustrial.Location = New System.Drawing.Point(135, 93)
        Me.txtBeneficioIndustrial.Name = "txtBeneficioIndustrial"
        Me.txtBeneficioIndustrial.Size = New System.Drawing.Size(54, 21)
        Me.txtBeneficioIndustrial.TabIndex = 43
        '
        'lblCoefBaja
        '
        Me.lblCoefBaja.Location = New System.Drawing.Point(16, 121)
        Me.lblCoefBaja.Name = "lblCoefBaja"
        Me.lblCoefBaja.Size = New System.Drawing.Size(101, 13)
        Me.lblCoefBaja.TabIndex = 114
        Me.lblCoefBaja.Text = "Coeficiente Baja"
        '
        'txtCoefBaja
        '
        Me.TryDataBinding(txtCoefBaja, New System.Windows.Forms.Binding("Value", Me, "CoefBaja", True))
        Me.txtCoefBaja.DisabledBackColor = System.Drawing.Color.White
        Me.txtCoefBaja.Location = New System.Drawing.Point(135, 117)
        Me.txtCoefBaja.Name = "txtCoefBaja"
        Me.txtCoefBaja.Size = New System.Drawing.Size(54, 21)
        Me.txtCoefBaja.TabIndex = 44
        '
        'lblGastosGenerales
        '
        Me.lblGastosGenerales.Location = New System.Drawing.Point(16, 73)
        Me.lblGastosGenerales.Name = "lblGastosGenerales"
        Me.lblGastosGenerales.Size = New System.Drawing.Size(108, 13)
        Me.lblGastosGenerales.TabIndex = 115
        Me.lblGastosGenerales.Text = "Gastos Generales"
        '
        'txtGastosGenerales
        '
        Me.TryDataBinding(txtGastosGenerales, New System.Windows.Forms.Binding("Value", Me, "GastosGenerales", True))
        Me.txtGastosGenerales.DisabledBackColor = System.Drawing.Color.White
        Me.txtGastosGenerales.Location = New System.Drawing.Point(135, 69)
        Me.txtGastosGenerales.Name = "txtGastosGenerales"
        Me.txtGastosGenerales.Size = New System.Drawing.Size(54, 21)
        Me.txtGastosGenerales.TabIndex = 42
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ntbDiaFacturacion)
        Me.Panel1.Controls.Add(Me.lblDiaFacturacion)
        Me.Panel1.Controls.Add(Me.FraRetencion)
        Me.Panel1.Controls.Add(Me.lblGridCostes)
        Me.Panel1.Controls.Add(Me.GridCostes)
        Me.Panel1.Controls.Add(Me.lblNivel)
        Me.Panel1.Controls.Add(Me.txtNivel)
        Me.Panel1.Controls.Add(Me.lblObraPadre)
        Me.Panel1.Controls.Add(Me.AdvIDObraPadre)
        Me.Panel1.Controls.Add(Me.lblNumeroPedido)
        Me.Panel1.Controls.Add(Me.txtNumeroPedido)
        Me.Panel1.Controls.Add(Me.lblFechaObra)
        Me.Panel1.Controls.Add(Me.cbxFechaObra)
        Me.Panel1.Controls.Add(Me.lblURLContrato)
        Me.Panel1.Controls.Add(Me.txtURLContrato)
        Me.Panel1.Controls.Add(Me.lblNumPresup)
        Me.Panel1.Controls.Add(Me.txtNumPresup)
        Me.Panel1.Controls.Add(Me.txtRevPresup)
        Me.Panel1.Controls.Add(Me.CmbUrlContrato)
        Me.Panel1.Controls.Add(Me.LblBarra)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 80)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(782, 212)
        Me.Panel1.TabIndex = 180
        '
        'ntbDiaFacturacion
        '
        Me.TryDataBinding(ntbDiaFacturacion, New System.Windows.Forms.Binding("Value", Me, "DiaFacturacion", True))
        Me.ntbDiaFacturacion.DecimalDigits = 0
        Me.ntbDiaFacturacion.DisabledBackColor = System.Drawing.Color.White
        Me.ntbDiaFacturacion.Location = New System.Drawing.Point(287, 7)
        Me.ntbDiaFacturacion.Name = "ntbDiaFacturacion"
        Me.ntbDiaFacturacion.Size = New System.Drawing.Size(43, 21)
        Me.ntbDiaFacturacion.TabIndex = 208
        '
        'lblDiaFacturacion
        '
        Me.lblDiaFacturacion.Location = New System.Drawing.Point(229, 12)
        Me.lblDiaFacturacion.Name = "lblDiaFacturacion"
        Me.lblDiaFacturacion.Size = New System.Drawing.Size(52, 13)
        Me.lblDiaFacturacion.TabIndex = 209
        Me.lblDiaFacturacion.Text = "Dia Fact"
        '
        'FraRetencion
        '
        Me.FraRetencion.Controls.Add(Me.txtPeriodo)
        Me.FraRetencion.Controls.Add(Me.cbxTipoPeriodo)
        Me.FraRetencion.Controls.Add(Me.lblPeriodo)
        Me.FraRetencion.Controls.Add(Me.cboTipoRetencionImpuestos)
        Me.FraRetencion.Controls.Add(Me.lblFechaRetencion)
        Me.FraRetencion.Controls.Add(Me.cbxFechaRetencion)
        Me.FraRetencion.Controls.Add(Me.lblRetencion)
        Me.FraRetencion.Controls.Add(Me.txtRetencion)
        Me.FraRetencion.Controls.Add(Me.lblTipoRetencion)
        Me.FraRetencion.Controls.Add(Me.cbxTipoRetencion)
        Me.FraRetencion.Location = New System.Drawing.Point(3, 105)
        Me.FraRetencion.Name = "FraRetencion"
        Me.FraRetencion.Size = New System.Drawing.Size(363, 74)
        Me.FraRetencion.TabIndex = 30
        Me.FraRetencion.TabStop = False
        Me.FraRetencion.Text = "Retención"
        '
        'txtPeriodo
        '
        Me.TryDataBinding(txtPeriodo, New System.Windows.Forms.Binding("Text", Me, "Periodo", True))
        Me.txtPeriodo.DisabledBackColor = System.Drawing.Color.White
        Me.txtPeriodo.Location = New System.Drawing.Point(214, 47)
        Me.txtPeriodo.Name = "txtPeriodo"
        Me.txtPeriodo.Size = New System.Drawing.Size(45, 21)
        Me.txtPeriodo.TabIndex = 35
        '
        'cbxTipoPeriodo
        '
        Me.cbxTipoPeriodo.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList
        Me.TryDataBinding(cbxTipoPeriodo, New System.Windows.Forms.Binding("Value", Me, "TipoPeriodo", True))
        cbxTipoPeriodo_DesignTimeLayout.LayoutString = resources.GetString("cbxTipoPeriodo_DesignTimeLayout.LayoutString")
        Me.cbxTipoPeriodo.DesignTimeLayout = cbxTipoPeriodo_DesignTimeLayout
        Me.cbxTipoPeriodo.DisabledBackColor = System.Drawing.Color.White
        Me.cbxTipoPeriodo.DisplayMember = "Value"
        Me.cbxTipoPeriodo.Location = New System.Drawing.Point(263, 47)
        Me.cbxTipoPeriodo.Name = "cbxTipoPeriodo"
        Me.cbxTipoPeriodo.PrimaryDataFields = "TipoPeriodo"
        Me.cbxTipoPeriodo.SecondaryDataFields = "Value"
        Me.cbxTipoPeriodo.SelectedIndex = -1
        Me.cbxTipoPeriodo.SelectedItem = Nothing
        Me.cbxTipoPeriodo.Size = New System.Drawing.Size(94, 21)
        Me.cbxTipoPeriodo.TabIndex = 36
        '
        'lblPeriodo
        '
        Me.lblPeriodo.Location = New System.Drawing.Point(160, 51)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(50, 13)
        Me.lblPeriodo.TabIndex = 194
        Me.lblPeriodo.Text = "Período"
        '
        'cboTipoRetencionImpuestos
        '
        Me.cboTipoRetencionImpuestos.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList
        Me.TryDataBinding(cboTipoRetencionImpuestos, New System.Windows.Forms.Binding("Value", Me, "Impuestos", True))
        cboTipoRetencionImpuestos_DesignTimeLayout.LayoutString = resources.GetString("cboTipoRetencionImpuestos_DesignTimeLayout.LayoutString")
        Me.cboTipoRetencionImpuestos.DesignTimeLayout = cboTipoRetencionImpuestos_DesignTimeLayout
        Me.cboTipoRetencionImpuestos.DisabledBackColor = System.Drawing.Color.White
        Me.cboTipoRetencionImpuestos.DisplayMember = "Value"
        Me.cboTipoRetencionImpuestos.Location = New System.Drawing.Point(160, 22)
        Me.cboTipoRetencionImpuestos.Name = "cboTipoRetencionImpuestos"
        Me.cboTipoRetencionImpuestos.PrimaryDataFields = "Impuestos"
        Me.cboTipoRetencionImpuestos.SecondaryDataFields = "Value"
        Me.cboTipoRetencionImpuestos.SelectedIndex = -1
        Me.cboTipoRetencionImpuestos.SelectedItem = Nothing
        Me.cboTipoRetencionImpuestos.Size = New System.Drawing.Size(126, 21)
        Me.cboTipoRetencionImpuestos.TabIndex = 32
        '
        'lblFechaRetencion
        '
        Me.lblFechaRetencion.Location = New System.Drawing.Point(8, 51)
        Me.lblFechaRetencion.Name = "lblFechaRetencion"
        Me.lblFechaRetencion.Size = New System.Drawing.Size(40, 13)
        Me.lblFechaRetencion.TabIndex = 193
        Me.lblFechaRetencion.Text = "Fecha"
        '
        'cbxFechaRetencion
        '
        Me.TryDataBinding(cbxFechaRetencion, New System.Windows.Forms.Binding("BindableValue", Me, "FechaRetencion", True))
        Me.cbxFechaRetencion.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaRetencion.Location = New System.Drawing.Point(48, 47)
        Me.cbxFechaRetencion.Name = "cbxFechaRetencion"
        Me.cbxFechaRetencion.Size = New System.Drawing.Size(108, 21)
        Me.cbxFechaRetencion.TabIndex = 34
        '
        'lblRetencion
        '
        Me.lblRetencion.AutoSize = False
        Me.lblRetencion.Location = New System.Drawing.Point(289, 24)
        Me.lblRetencion.Name = "lblRetencion"
        Me.lblRetencion.Size = New System.Drawing.Size(15, 17)
        Me.lblRetencion.TabIndex = 90
        Me.lblRetencion.Text = "%"
        '
        'txtRetencion
        '
        Me.TryDataBinding(txtRetencion, New System.Windows.Forms.Binding("Value", Me, "Retencion", True))
        Me.txtRetencion.DisabledBackColor = System.Drawing.Color.White
        Me.txtRetencion.Location = New System.Drawing.Point(307, 22)
        Me.txtRetencion.Name = "txtRetencion"
        Me.txtRetencion.Size = New System.Drawing.Size(50, 21)
        Me.txtRetencion.TabIndex = 33
        Me.txtRetencion.TabStop = False
        '
        'lblTipoRetencion
        '
        Me.lblTipoRetencion.Location = New System.Drawing.Point(8, 26)
        Me.lblTipoRetencion.Name = "lblTipoRetencion"
        Me.lblTipoRetencion.Size = New System.Drawing.Size(35, 13)
        Me.lblTipoRetencion.TabIndex = 89
        Me.lblTipoRetencion.Text = "Tipo "
        '
        'cbxTipoRetencion
        '
        Me.cbxTipoRetencion.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList
        Me.TryDataBinding(cbxTipoRetencion, New System.Windows.Forms.Binding("Value", Me, "TipoRetencion", True))
        cbxTipoRetencion_DesignTimeLayout.LayoutString = resources.GetString("cbxTipoRetencion_DesignTimeLayout.LayoutString")
        Me.cbxTipoRetencion.DesignTimeLayout = cbxTipoRetencion_DesignTimeLayout
        Me.cbxTipoRetencion.DisabledBackColor = System.Drawing.Color.White
        Me.cbxTipoRetencion.DisplayMember = "Value"
        Me.cbxTipoRetencion.Location = New System.Drawing.Point(48, 22)
        Me.cbxTipoRetencion.Name = "cbxTipoRetencion"
        Me.cbxTipoRetencion.PrimaryDataFields = "Estado"
        Me.cbxTipoRetencion.SecondaryDataFields = "Value"
        Me.cbxTipoRetencion.SelectedIndex = -1
        Me.cbxTipoRetencion.SelectedItem = Nothing
        Me.cbxTipoRetencion.Size = New System.Drawing.Size(108, 21)
        Me.cbxTipoRetencion.TabIndex = 31
        '
        'lblGridCostes
        '
        Me.lblGridCostes.Location = New System.Drawing.Point(369, 12)
        Me.lblGridCostes.Name = "lblGridCostes"
        Me.lblGridCostes.Size = New System.Drawing.Size(274, 13)
        Me.lblGridCostes.TabIndex = 207
        Me.lblGridCostes.Text = "Porcentajes a imputar sobre el proyecto padre"
        '
        'GridCostes
        '
        Me.GridCostes.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("NObraHija", "ObraCabecera", "NObra", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDObra", "IDObraHija"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("ImpPrevA", "ImpPrevA"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("ImpPrevVentaA", "ImpPrevVentaA"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("ImpRealA", "ImpRealA"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("ImpFactA", "ImpFactA")}))})
        GridCostes_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("GridCostes_DesignTimeLayout_Reference_0.Instance"), Object)
        GridCostes_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {GridCostes_DesignTimeLayout_Reference_0})
        GridCostes_DesignTimeLayout.LayoutString = resources.GetString("GridCostes_DesignTimeLayout.LayoutString")
        Me.GridCostes.DesignTimeLayout = GridCostes_DesignTimeLayout
        Me.GridCostes.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridCostes.EntityName = "ObraCoste"
        Me.GridCostes.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridCostes.Location = New System.Drawing.Point(372, 30)
        Me.GridCostes.Name = "GridCostes"
        Me.GridCostes.PrimaryDataFields = "IDObra"
        Me.GridCostes.SecondaryDataFields = "IDObra"
        Me.GridCostes.Size = New System.Drawing.Size(401, 149)
        Me.GridCostes.TabIndex = 36
        Me.GridCostes.ViewName = "vFrmMntoObraCostesAsignados"
        '
        'lblNivel
        '
        Me.lblNivel.Location = New System.Drawing.Point(227, 86)
        Me.lblNivel.Name = "lblNivel"
        Me.lblNivel.Size = New System.Drawing.Size(35, 13)
        Me.lblNivel.TabIndex = 199
        Me.lblNivel.Text = "Nivel"
        '
        'txtNivel
        '
        Me.TryDataBinding(txtNivel, New System.Windows.Forms.Binding("Text", Me, "Nivel", True))
        Me.txtNivel.DisabledBackColor = System.Drawing.Color.White
        Me.txtNivel.Enabled = False
        Me.txtNivel.Location = New System.Drawing.Point(266, 82)
        Me.txtNivel.Name = "txtNivel"
        Me.txtNivel.Size = New System.Drawing.Size(64, 21)
        Me.txtNivel.TabIndex = 191
        Me.txtNivel.TabStop = False
        Me.txtNivel.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'lblObraPadre
        '
        Me.lblObraPadre.Location = New System.Drawing.Point(3, 11)
        Me.lblObraPadre.Name = "lblObraPadre"
        Me.lblObraPadre.Size = New System.Drawing.Size(94, 13)
        Me.lblObraPadre.TabIndex = 200
        Me.lblObraPadre.Text = "Proyecto Padre"
        '
        'AdvIDObraPadre
        '
        Me.TryDataBinding(AdvIDObraPadre, New System.Windows.Forms.Binding("Value", Me, "IDObraPadre", True))
        Me.TryDataBinding(AdvIDObraPadre, New System.Windows.Forms.Binding("Text", Me, "NObraPadre", True))
        Me.AdvIDObraPadre.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDObraPadre.DisplayField = "NObra"
        Me.AdvIDObraPadre.EntityName = "ObraCabecera"
        Me.AdvIDObraPadre.Location = New System.Drawing.Point(100, 6)
        Me.AdvIDObraPadre.Name = "AdvIDObraPadre"
        Me.AdvIDObraPadre.PrimaryDataFields = "IDObraPadre"
        Me.AdvIDObraPadre.SecondaryDataFields = "IDObra"
        Me.AdvIDObraPadre.Size = New System.Drawing.Size(114, 23)
        Me.AdvIDObraPadre.TabIndex = 27
        '
        'lblNumeroPedido
        '
        Me.lblNumeroPedido.Location = New System.Drawing.Point(3, 86)
        Me.lblNumeroPedido.Name = "lblNumeroPedido"
        Me.lblNumeroPedido.Size = New System.Drawing.Size(94, 13)
        Me.lblNumeroPedido.TabIndex = 201
        Me.lblNumeroPedido.Text = "Número Pedido"
        '
        'txtNumeroPedido
        '
        Me.TryDataBinding(txtNumeroPedido, New System.Windows.Forms.Binding("Text", Me, "NumeroPedido", True))
        Me.txtNumeroPedido.DisabledBackColor = System.Drawing.Color.White
        Me.txtNumeroPedido.Location = New System.Drawing.Point(100, 83)
        Me.txtNumeroPedido.Name = "txtNumeroPedido"
        Me.txtNumeroPedido.Size = New System.Drawing.Size(115, 21)
        Me.txtNumeroPedido.TabIndex = 29
        '
        'lblFechaObra
        '
        Me.lblFechaObra.Location = New System.Drawing.Point(3, 36)
        Me.lblFechaObra.Name = "lblFechaObra"
        Me.lblFechaObra.Size = New System.Drawing.Size(94, 13)
        Me.lblFechaObra.TabIndex = 202
        Me.lblFechaObra.Text = "Fecha Proyecto"
        '
        'cbxFechaObra
        '
        Me.TryDataBinding(cbxFechaObra, New System.Windows.Forms.Binding("BindableValue", Me, "FechaObra", True))
        Me.cbxFechaObra.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaObra.Location = New System.Drawing.Point(100, 33)
        Me.cbxFechaObra.Name = "cbxFechaObra"
        Me.cbxFechaObra.Size = New System.Drawing.Size(114, 21)
        Me.cbxFechaObra.TabIndex = 28
        '
        'lblURLContrato
        '
        Me.lblURLContrato.Location = New System.Drawing.Point(3, 184)
        Me.lblURLContrato.Name = "lblURLContrato"
        Me.lblURLContrato.Size = New System.Drawing.Size(83, 13)
        Me.lblURLContrato.TabIndex = 203
        Me.lblURLContrato.Text = "URL Contrato"
        '
        'txtURLContrato
        '
        Me.txtURLContrato.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TryDataBinding(txtURLContrato, New System.Windows.Forms.Binding("Text", Me, "URLContratoTipo", True))
        Me.txtURLContrato.DisabledBackColor = System.Drawing.Color.White
        Me.txtURLContrato.Location = New System.Drawing.Point(96, 184)
        Me.txtURLContrato.Name = "txtURLContrato"
        Me.txtURLContrato.Size = New System.Drawing.Size(654, 21)
        Me.txtURLContrato.TabIndex = 37
        '
        'lblNumPresup
        '
        Me.lblNumPresup.Location = New System.Drawing.Point(3, 61)
        Me.lblNumPresup.Name = "lblNumPresup"
        Me.lblNumPresup.Size = New System.Drawing.Size(77, 13)
        Me.lblNumPresup.TabIndex = 204
        Me.lblNumPresup.Text = "Presupuesto"
        '
        'txtNumPresup
        '
        Me.TryDataBinding(txtNumPresup, New System.Windows.Forms.Binding("Text", Me, "NumPresup", True))
        Me.txtNumPresup.DisabledBackColor = System.Drawing.Color.White
        Me.txtNumPresup.Enabled = False
        Me.txtNumPresup.Location = New System.Drawing.Point(100, 58)
        Me.txtNumPresup.Name = "txtNumPresup"
        Me.txtNumPresup.Size = New System.Drawing.Size(65, 21)
        Me.txtNumPresup.TabIndex = 28
        Me.txtNumPresup.TabStop = False
        '
        'txtRevPresup
        '
        Me.TryDataBinding(txtRevPresup, New System.Windows.Forms.Binding("Text", Me, "RevPresup", True))
        Me.txtRevPresup.DisabledBackColor = System.Drawing.Color.White
        Me.txtRevPresup.Enabled = False
        Me.txtRevPresup.Location = New System.Drawing.Point(178, 58)
        Me.txtRevPresup.Name = "txtRevPresup"
        Me.txtRevPresup.Size = New System.Drawing.Size(36, 21)
        Me.txtRevPresup.TabIndex = 29
        Me.txtRevPresup.TabStop = False
        '
        'CmbUrlContrato
        '
        Me.CmbUrlContrato.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbUrlContrato.ImageIndex = 0
        Me.CmbUrlContrato.ImageList = Me.ImageList1
        Me.CmbUrlContrato.Location = New System.Drawing.Point(752, 184)
        Me.CmbUrlContrato.Name = "CmbUrlContrato"
        Me.CmbUrlContrato.Size = New System.Drawing.Size(21, 21)
        Me.CmbUrlContrato.TabIndex = 38
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        Me.ImageList1.Images.SetKeyName(2, "")
        Me.ImageList1.Images.SetKeyName(3, "")
        Me.ImageList1.Images.SetKeyName(4, "")
        Me.ImageList1.Images.SetKeyName(5, "")
        Me.ImageList1.Images.SetKeyName(6, "")
        Me.ImageList1.Images.SetKeyName(7, "")
        Me.ImageList1.Images.SetKeyName(8, "")
        Me.ImageList1.Images.SetKeyName(9, "")
        Me.ImageList1.Images.SetKeyName(10, "branch_element.ico")
        '
        'LblBarra
        '
        Me.LblBarra.Location = New System.Drawing.Point(167, 59)
        Me.LblBarra.Name = "LblBarra"
        Me.LblBarra.Size = New System.Drawing.Size(12, 13)
        Me.LblBarra.TabIndex = 205
        Me.LblBarra.Text = "/"
        '
        'FraDireccion
        '
        Me.FraDireccion.Controls.Add(Me.lblDireccionObra)
        Me.FraDireccion.Controls.Add(Me.txtDireccionObra)
        Me.FraDireccion.Controls.Add(Me.lblProvinciaObra)
        Me.FraDireccion.Controls.Add(Me.txtProvinciaObra)
        Me.FraDireccion.Controls.Add(Me.lblCodPostalObra)
        Me.FraDireccion.Controls.Add(Me.txtCodPostalObra)
        Me.FraDireccion.Controls.Add(Me.lblPoblacionObra)
        Me.FraDireccion.Controls.Add(Me.txtPoblacionObra)
        Me.FraDireccion.Dock = System.Windows.Forms.DockStyle.Top
        Me.FraDireccion.Location = New System.Drawing.Point(0, 0)
        Me.FraDireccion.Name = "FraDireccion"
        Me.FraDireccion.Size = New System.Drawing.Size(782, 80)
        Me.FraDireccion.TabIndex = 20
        Me.FraDireccion.TabStop = False
        Me.FraDireccion.Text = "Dirección del Proyecto"
        '
        'lblDireccionObra
        '
        Me.lblDireccionObra.Location = New System.Drawing.Point(9, 29)
        Me.lblDireccionObra.Name = "lblDireccionObra"
        Me.lblDireccionObra.Size = New System.Drawing.Size(60, 13)
        Me.lblDireccionObra.TabIndex = 0
        Me.lblDireccionObra.Text = "Dirección"
        '
        'txtDireccionObra
        '
        Me.TryDataBinding(txtDireccionObra, New System.Windows.Forms.Binding("Text", Me, "Direccion", True))
        Me.txtDireccionObra.DisabledBackColor = System.Drawing.Color.White
        Me.txtDireccionObra.Location = New System.Drawing.Point(75, 25)
        Me.txtDireccionObra.Name = "txtDireccionObra"
        Me.txtDireccionObra.Size = New System.Drawing.Size(698, 21)
        Me.txtDireccionObra.TabIndex = 21
        '
        'lblProvinciaObra
        '
        Me.lblProvinciaObra.Location = New System.Drawing.Point(540, 55)
        Me.lblProvinciaObra.Name = "lblProvinciaObra"
        Me.lblProvinciaObra.Size = New System.Drawing.Size(59, 13)
        Me.lblProvinciaObra.TabIndex = 23
        Me.lblProvinciaObra.Text = "Provincia"
        '
        'txtProvinciaObra
        '
        Me.TryDataBinding(txtProvinciaObra, New System.Windows.Forms.Binding("Text", Me, "Provincia", True))
        Me.txtProvinciaObra.DisabledBackColor = System.Drawing.Color.White
        Me.txtProvinciaObra.Location = New System.Drawing.Point(604, 51)
        Me.txtProvinciaObra.Name = "txtProvinciaObra"
        Me.txtProvinciaObra.Size = New System.Drawing.Size(169, 21)
        Me.txtProvinciaObra.TabIndex = 24
        '
        'lblCodPostalObra
        '
        Me.lblCodPostalObra.Location = New System.Drawing.Point(9, 55)
        Me.lblCodPostalObra.Name = "lblCodPostalObra"
        Me.lblCodPostalObra.Size = New System.Drawing.Size(58, 13)
        Me.lblCodPostalObra.TabIndex = 26
        Me.lblCodPostalObra.Text = "C. Postal"
        '
        'txtCodPostalObra
        '
        Me.TryDataBinding(txtCodPostalObra, New System.Windows.Forms.Binding("Text", Me, "CodPostal", True))
        Me.txtCodPostalObra.DisabledBackColor = System.Drawing.Color.White
        Me.txtCodPostalObra.Location = New System.Drawing.Point(75, 51)
        Me.txtCodPostalObra.Name = "txtCodPostalObra"
        Me.txtCodPostalObra.Size = New System.Drawing.Size(73, 21)
        Me.txtCodPostalObra.TabIndex = 22
        '
        'lblPoblacionObra
        '
        Me.lblPoblacionObra.Location = New System.Drawing.Point(159, 55)
        Me.lblPoblacionObra.Name = "lblPoblacionObra"
        Me.lblPoblacionObra.Size = New System.Drawing.Size(61, 13)
        Me.lblPoblacionObra.TabIndex = 27
        Me.lblPoblacionObra.Text = "Población"
        '
        'txtPoblacionObra
        '
        Me.TryDataBinding(txtPoblacionObra, New System.Windows.Forms.Binding("Text", Me, "Poblacion", True))
        Me.txtPoblacionObra.DisabledBackColor = System.Drawing.Color.White
        Me.txtPoblacionObra.Location = New System.Drawing.Point(225, 51)
        Me.txtPoblacionObra.Name = "txtPoblacionObra"
        Me.txtPoblacionObra.Size = New System.Drawing.Size(304, 21)
        Me.txtPoblacionObra.TabIndex = 23
        '
        'txtIdDireccion
        '
        Me.TryDataBinding(txtIdDireccion, New System.Windows.Forms.Binding("Text", Me, "IDDireccion", True))
        Me.txtIdDireccion.DisabledBackColor = System.Drawing.Color.White
        Me.txtIdDireccion.Location = New System.Drawing.Point(261, 331)
        Me.txtIdDireccion.Name = "txtIdDireccion"
        Me.txtIdDireccion.Size = New System.Drawing.Size(57, 21)
        Me.txtIdDireccion.TabIndex = 171
        '
        'TabPageEstructura
        '
        Me.TabPageEstructura.Controls.Add(Me.tvwEstructura)
        Me.TabPageEstructura.Controls.Add(Me.pnlTopEstructura)
        Me.TabPageEstructura.Controls.Add(Me.FraTotalSeleccionObra)
        Me.TabPageEstructura.Controls.Add(Me.FraTotalObraPadreEstructura)
        Me.TabPageEstructura.Key = "Estructura"
        Me.TabPageEstructura.Location = New System.Drawing.Point(1, 22)
        Me.TabPageEstructura.Name = "TabPageEstructura"
        Me.TabPageEstructura.Size = New System.Drawing.Size(782, 531)
        Me.TabPageEstructura.TabStop = True
        Me.TabPageEstructura.Text = "Estructura"
        '
        'tvwEstructura
        '
        Me.tvwEstructura.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvwEstructura.ImageIndex = 0
        Me.tvwEstructura.ImageList = Me.ImageList1
        Me.tvwEstructura.Location = New System.Drawing.Point(0, 35)
        Me.tvwEstructura.Name = "tvwEstructura"
        Me.tvwEstructura.SelectedImageIndex = 0
        Me.tvwEstructura.Size = New System.Drawing.Size(634, 428)
        Me.tvwEstructura.TabIndex = 166
        '
        'pnlTopEstructura
        '
        Me.pnlTopEstructura.Controls.Add(Me.cmbObraPadre)
        Me.pnlTopEstructura.Controls.Add(Me.lblNivel2)
        Me.pnlTopEstructura.Controls.Add(Me.lblObraPadre2)
        Me.pnlTopEstructura.Controls.Add(Me.txtNivelObra)
        Me.pnlTopEstructura.Controls.Add(Me.txtCodTrabajoPadre)
        Me.pnlTopEstructura.Controls.Add(Me.chkVerTrabajos)
        Me.pnlTopEstructura.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopEstructura.Location = New System.Drawing.Point(0, 0)
        Me.pnlTopEstructura.Name = "pnlTopEstructura"
        Me.pnlTopEstructura.Size = New System.Drawing.Size(634, 35)
        Me.pnlTopEstructura.TabIndex = 50
        '
        'cmbObraPadre
        '
        Me.cmbObraPadre.Icon = CType(resources.GetObject("cmbObraPadre.Icon"), System.Drawing.Icon)
        Me.cmbObraPadre.Location = New System.Drawing.Point(500, 8)
        Me.cmbObraPadre.Name = "cmbObraPadre"
        Me.cmbObraPadre.Size = New System.Drawing.Size(21, 21)
        Me.cmbObraPadre.TabIndex = 52
        '
        'lblNivel2
        '
        Me.lblNivel2.Location = New System.Drawing.Point(523, 12)
        Me.lblNivel2.Name = "lblNivel2"
        Me.lblNivel2.Size = New System.Drawing.Size(35, 13)
        Me.lblNivel2.TabIndex = 159
        Me.lblNivel2.Text = "Nivel"
        '
        'lblObraPadre2
        '
        Me.lblObraPadre2.Location = New System.Drawing.Point(293, 12)
        Me.lblObraPadre2.Name = "lblObraPadre2"
        Me.lblObraPadre2.Size = New System.Drawing.Size(94, 13)
        Me.lblObraPadre2.TabIndex = 158
        Me.lblObraPadre2.Text = "Proyecto Padre"
        Me.lblObraPadre2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtNivelObra
        '
        Me.TryDataBinding(txtNivelObra, New System.Windows.Forms.Binding("Text", Me, "Nivel", True))
        Me.txtNivelObra.DisabledBackColor = System.Drawing.Color.White
        Me.txtNivelObra.Enabled = False
        Me.txtNivelObra.Location = New System.Drawing.Point(562, 8)
        Me.txtNivelObra.Name = "txtNivelObra"
        Me.txtNivelObra.Size = New System.Drawing.Size(64, 21)
        Me.txtNivelObra.TabIndex = 157
        Me.txtNivelObra.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtCodTrabajoPadre
        '
        Me.TryDataBinding(txtCodTrabajoPadre, New System.Windows.Forms.Binding("Text", Me, "NObraPadre", True))
        Me.txtCodTrabajoPadre.DisabledBackColor = System.Drawing.Color.White
        Me.txtCodTrabajoPadre.Enabled = False
        Me.txtCodTrabajoPadre.Location = New System.Drawing.Point(391, 8)
        Me.txtCodTrabajoPadre.Name = "txtCodTrabajoPadre"
        Me.txtCodTrabajoPadre.Size = New System.Drawing.Size(105, 21)
        Me.txtCodTrabajoPadre.TabIndex = 156
        '
        'chkVerTrabajos
        '
        Me.chkVerTrabajos.Location = New System.Drawing.Point(7, 6)
        Me.chkVerTrabajos.Name = "chkVerTrabajos"
        Me.chkVerTrabajos.Size = New System.Drawing.Size(102, 24)
        Me.chkVerTrabajos.TabIndex = 51
        Me.chkVerTrabajos.Text = "Ver Trabajos"
        '
        'FraTotalSeleccionObra
        '
        Me.FraTotalSeleccionObra.Controls.Add(Me.lblTotalFacturadoTree)
        Me.FraTotalSeleccionObra.Controls.Add(Me.txtTotalFacturadoTree)
        Me.FraTotalSeleccionObra.Controls.Add(Me.lblTotalRealTree)
        Me.FraTotalSeleccionObra.Controls.Add(Me.txtTotalRealTree)
        Me.FraTotalSeleccionObra.Controls.Add(Me.lblTotalPrevVentaTree)
        Me.FraTotalSeleccionObra.Controls.Add(Me.txtTotalPrevVentaTree)
        Me.FraTotalSeleccionObra.Controls.Add(Me.lblTotalPrevTree)
        Me.FraTotalSeleccionObra.Controls.Add(Me.txtTotalPrevTree)
        Me.FraTotalSeleccionObra.Dock = System.Windows.Forms.DockStyle.Right
        Me.FraTotalSeleccionObra.Location = New System.Drawing.Point(634, 0)
        Me.FraTotalSeleccionObra.Name = "FraTotalSeleccionObra"
        Me.FraTotalSeleccionObra.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.FraTotalSeleccionObra.Size = New System.Drawing.Size(148, 463)
        Me.FraTotalSeleccionObra.TabIndex = 164
        Me.FraTotalSeleccionObra.TabStop = False
        Me.FraTotalSeleccionObra.Text = "Total Selección"
        '
        'lblTotalFacturadoTree
        '
        Me.lblTotalFacturadoTree.AutoSize = False
        Me.lblTotalFacturadoTree.Location = New System.Drawing.Point(9, 208)
        Me.lblTotalFacturadoTree.Name = "lblTotalFacturadoTree"
        Me.lblTotalFacturadoTree.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTotalFacturadoTree.Size = New System.Drawing.Size(131, 17)
        Me.lblTotalFacturadoTree.TabIndex = 0
        Me.lblTotalFacturadoTree.Text = "Total Facturado"
        Me.lblTotalFacturadoTree.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTotalFacturadoTree
        '
        Me.txtTotalFacturadoTree.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotalFacturadoTree.Enabled = False
        Me.txtTotalFacturadoTree.Location = New System.Drawing.Point(9, 229)
        Me.txtTotalFacturadoTree.Name = "txtTotalFacturadoTree"
        Me.txtTotalFacturadoTree.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTotalFacturadoTree.Size = New System.Drawing.Size(131, 21)
        Me.txtTotalFacturadoTree.TabIndex = 148
        '
        'lblTotalRealTree
        '
        Me.lblTotalRealTree.AutoSize = False
        Me.lblTotalRealTree.Location = New System.Drawing.Point(9, 151)
        Me.lblTotalRealTree.Name = "lblTotalRealTree"
        Me.lblTotalRealTree.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTotalRealTree.Size = New System.Drawing.Size(131, 17)
        Me.lblTotalRealTree.TabIndex = 149
        Me.lblTotalRealTree.Text = "Total Real"
        Me.lblTotalRealTree.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTotalRealTree
        '
        Me.txtTotalRealTree.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotalRealTree.Enabled = False
        Me.txtTotalRealTree.Location = New System.Drawing.Point(9, 172)
        Me.txtTotalRealTree.Name = "txtTotalRealTree"
        Me.txtTotalRealTree.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTotalRealTree.Size = New System.Drawing.Size(131, 21)
        Me.txtTotalRealTree.TabIndex = 147
        '
        'lblTotalPrevVentaTree
        '
        Me.lblTotalPrevVentaTree.AutoSize = False
        Me.lblTotalPrevVentaTree.Location = New System.Drawing.Point(9, 94)
        Me.lblTotalPrevVentaTree.Name = "lblTotalPrevVentaTree"
        Me.lblTotalPrevVentaTree.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTotalPrevVentaTree.Size = New System.Drawing.Size(131, 17)
        Me.lblTotalPrevVentaTree.TabIndex = 150
        Me.lblTotalPrevVentaTree.Text = "Total Previsto Venta"
        Me.lblTotalPrevVentaTree.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTotalPrevVentaTree
        '
        Me.txtTotalPrevVentaTree.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotalPrevVentaTree.Enabled = False
        Me.txtTotalPrevVentaTree.Location = New System.Drawing.Point(9, 115)
        Me.txtTotalPrevVentaTree.Name = "txtTotalPrevVentaTree"
        Me.txtTotalPrevVentaTree.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTotalPrevVentaTree.Size = New System.Drawing.Size(131, 21)
        Me.txtTotalPrevVentaTree.TabIndex = 146
        '
        'lblTotalPrevTree
        '
        Me.lblTotalPrevTree.AutoSize = False
        Me.lblTotalPrevTree.Location = New System.Drawing.Point(9, 37)
        Me.lblTotalPrevTree.Name = "lblTotalPrevTree"
        Me.lblTotalPrevTree.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTotalPrevTree.Size = New System.Drawing.Size(131, 17)
        Me.lblTotalPrevTree.TabIndex = 151
        Me.lblTotalPrevTree.Text = "Total Previsto"
        Me.lblTotalPrevTree.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTotalPrevTree
        '
        Me.txtTotalPrevTree.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotalPrevTree.Enabled = False
        Me.txtTotalPrevTree.Location = New System.Drawing.Point(9, 58)
        Me.txtTotalPrevTree.Name = "txtTotalPrevTree"
        Me.txtTotalPrevTree.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTotalPrevTree.Size = New System.Drawing.Size(131, 21)
        Me.txtTotalPrevTree.TabIndex = 145
        '
        'FraTotalObraPadreEstructura
        '
        Me.FraTotalObraPadreEstructura.Controls.Add(Me.lblTotalPrevEstructura)
        Me.FraTotalObraPadreEstructura.Controls.Add(Me.txtTotalEstructuraPrev)
        Me.FraTotalObraPadreEstructura.Controls.Add(Me.lblTotalPrevEstructuraReal)
        Me.FraTotalObraPadreEstructura.Controls.Add(Me.txtTotalEstructuraReal)
        Me.FraTotalObraPadreEstructura.Controls.Add(Me.lblTotalPrevEstructuraVta)
        Me.FraTotalObraPadreEstructura.Controls.Add(Me.txtTotalEstructuraPrevVta)
        Me.FraTotalObraPadreEstructura.Controls.Add(Me.lblTotalPrevEstructuraFacturado)
        Me.FraTotalObraPadreEstructura.Controls.Add(Me.txtTotalEstructuraFact)
        Me.FraTotalObraPadreEstructura.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FraTotalObraPadreEstructura.Location = New System.Drawing.Point(0, 463)
        Me.FraTotalObraPadreEstructura.Name = "FraTotalObraPadreEstructura"
        Me.FraTotalObraPadreEstructura.Size = New System.Drawing.Size(782, 68)
        Me.FraTotalObraPadreEstructura.TabIndex = 163
        Me.FraTotalObraPadreEstructura.TabStop = False
        Me.FraTotalObraPadreEstructura.Text = "Total Proyecto Padre"
        '
        'lblTotalPrevEstructura
        '
        Me.lblTotalPrevEstructura.AutoSize = False
        Me.lblTotalPrevEstructura.Location = New System.Drawing.Point(289, 18)
        Me.lblTotalPrevEstructura.Name = "lblTotalPrevEstructura"
        Me.lblTotalPrevEstructura.Size = New System.Drawing.Size(116, 21)
        Me.lblTotalPrevEstructura.TabIndex = 0
        Me.lblTotalPrevEstructura.Text = "Total Previsto"
        Me.lblTotalPrevEstructura.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTotalEstructuraPrev
        '
        Me.txtTotalEstructuraPrev.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotalEstructuraPrev.Enabled = False
        Me.txtTotalEstructuraPrev.Location = New System.Drawing.Point(289, 39)
        Me.txtTotalEstructuraPrev.Name = "txtTotalEstructuraPrev"
        Me.txtTotalEstructuraPrev.Size = New System.Drawing.Size(116, 21)
        Me.txtTotalEstructuraPrev.TabIndex = 143
        Me.txtTotalEstructuraPrev.TabStop = False
        '
        'lblTotalPrevEstructuraReal
        '
        Me.lblTotalPrevEstructuraReal.AutoSize = False
        Me.lblTotalPrevEstructuraReal.Location = New System.Drawing.Point(534, 18)
        Me.lblTotalPrevEstructuraReal.Name = "lblTotalPrevEstructuraReal"
        Me.lblTotalPrevEstructuraReal.Size = New System.Drawing.Size(116, 21)
        Me.lblTotalPrevEstructuraReal.TabIndex = 144
        Me.lblTotalPrevEstructuraReal.Text = "Total Real"
        Me.lblTotalPrevEstructuraReal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTotalEstructuraReal
        '
        Me.txtTotalEstructuraReal.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotalEstructuraReal.Enabled = False
        Me.txtTotalEstructuraReal.Location = New System.Drawing.Point(534, 39)
        Me.txtTotalEstructuraReal.Name = "txtTotalEstructuraReal"
        Me.txtTotalEstructuraReal.Size = New System.Drawing.Size(116, 21)
        Me.txtTotalEstructuraReal.TabIndex = 142
        Me.txtTotalEstructuraReal.TabStop = False
        '
        'lblTotalPrevEstructuraVta
        '
        Me.lblTotalPrevEstructuraVta.AutoSize = False
        Me.lblTotalPrevEstructuraVta.Location = New System.Drawing.Point(412, 18)
        Me.lblTotalPrevEstructuraVta.Name = "lblTotalPrevEstructuraVta"
        Me.lblTotalPrevEstructuraVta.Size = New System.Drawing.Size(116, 21)
        Me.lblTotalPrevEstructuraVta.TabIndex = 145
        Me.lblTotalPrevEstructuraVta.Text = "Total Prev. Venta"
        Me.lblTotalPrevEstructuraVta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTotalEstructuraPrevVta
        '
        Me.txtTotalEstructuraPrevVta.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotalEstructuraPrevVta.Enabled = False
        Me.txtTotalEstructuraPrevVta.Location = New System.Drawing.Point(412, 39)
        Me.txtTotalEstructuraPrevVta.Name = "txtTotalEstructuraPrevVta"
        Me.txtTotalEstructuraPrevVta.Size = New System.Drawing.Size(116, 21)
        Me.txtTotalEstructuraPrevVta.TabIndex = 141
        Me.txtTotalEstructuraPrevVta.TabStop = False
        '
        'lblTotalPrevEstructuraFacturado
        '
        Me.lblTotalPrevEstructuraFacturado.AutoSize = False
        Me.lblTotalPrevEstructuraFacturado.Location = New System.Drawing.Point(656, 18)
        Me.lblTotalPrevEstructuraFacturado.Name = "lblTotalPrevEstructuraFacturado"
        Me.lblTotalPrevEstructuraFacturado.Size = New System.Drawing.Size(116, 21)
        Me.lblTotalPrevEstructuraFacturado.TabIndex = 146
        Me.lblTotalPrevEstructuraFacturado.Text = "Total Facturado"
        Me.lblTotalPrevEstructuraFacturado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTotalEstructuraFact
        '
        Me.txtTotalEstructuraFact.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotalEstructuraFact.Enabled = False
        Me.txtTotalEstructuraFact.Location = New System.Drawing.Point(656, 39)
        Me.txtTotalEstructuraFact.Name = "txtTotalEstructuraFact"
        Me.txtTotalEstructuraFact.Size = New System.Drawing.Size(116, 21)
        Me.txtTotalEstructuraFact.TabIndex = 140
        Me.txtTotalEstructuraFact.TabStop = False
        '
        'TabPageCoste
        '
        Me.TabPageCoste.Controls.Add(Me.tvwCostes)
        Me.TabPageCoste.Controls.Add(Me.Frame1)
        Me.TabPageCoste.Controls.Add(Me.FraTotalObraPadre)
        Me.TabPageCoste.Key = "Coste"
        Me.TabPageCoste.Location = New System.Drawing.Point(1, 22)
        Me.TabPageCoste.Name = "TabPageCoste"
        Me.TabPageCoste.Size = New System.Drawing.Size(782, 551)
        Me.TabPageCoste.TabStop = True
        Me.TabPageCoste.Text = "Coste"
        '
        'tvwCostes
        '
        Me.tvwCostes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvwCostes.Location = New System.Drawing.Point(0, 0)
        Me.tvwCostes.Name = "tvwCostes"
        Me.tvwCostes.Size = New System.Drawing.Size(634, 483)
        Me.tvwCostes.TabIndex = 156
        '
        'Frame1
        '
        Me.Frame1.Controls.Add(Me.lblTotalObraHijaFacturado)
        Me.Frame1.Controls.Add(Me.txtCosteFacturado)
        Me.Frame1.Controls.Add(Me.lblTotalObraHijaReal)
        Me.Frame1.Controls.Add(Me.txtCosteReal)
        Me.Frame1.Controls.Add(Me.lblTotalObraHijaPresupVta)
        Me.Frame1.Controls.Add(Me.txtCostePrevVenta)
        Me.Frame1.Controls.Add(Me.lblTotalObraHijaPresup)
        Me.Frame1.Controls.Add(Me.txtCostePrev)
        Me.Frame1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Frame1.Location = New System.Drawing.Point(634, 0)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(148, 483)
        Me.Frame1.TabIndex = 154
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Total Selección"
        Me.Frame1.Visible = False
        '
        'lblTotalObraHijaFacturado
        '
        Me.lblTotalObraHijaFacturado.AutoSize = False
        Me.lblTotalObraHijaFacturado.Location = New System.Drawing.Point(9, 208)
        Me.lblTotalObraHijaFacturado.Name = "lblTotalObraHijaFacturado"
        Me.lblTotalObraHijaFacturado.Size = New System.Drawing.Size(131, 21)
        Me.lblTotalObraHijaFacturado.TabIndex = 0
        Me.lblTotalObraHijaFacturado.Text = "Total Facturado"
        Me.lblTotalObraHijaFacturado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCosteFacturado
        '
        Me.txtCosteFacturado.DisabledBackColor = System.Drawing.Color.White
        Me.txtCosteFacturado.Enabled = False
        Me.txtCosteFacturado.Location = New System.Drawing.Point(9, 229)
        Me.txtCosteFacturado.Name = "txtCosteFacturado"
        Me.txtCosteFacturado.Size = New System.Drawing.Size(131, 21)
        Me.txtCosteFacturado.TabIndex = 148
        Me.txtCosteFacturado.TabStop = False
        '
        'lblTotalObraHijaReal
        '
        Me.lblTotalObraHijaReal.AutoSize = False
        Me.lblTotalObraHijaReal.Location = New System.Drawing.Point(9, 151)
        Me.lblTotalObraHijaReal.Name = "lblTotalObraHijaReal"
        Me.lblTotalObraHijaReal.Size = New System.Drawing.Size(131, 21)
        Me.lblTotalObraHijaReal.TabIndex = 149
        Me.lblTotalObraHijaReal.Text = "Total Real"
        Me.lblTotalObraHijaReal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCosteReal
        '
        Me.txtCosteReal.DisabledBackColor = System.Drawing.Color.White
        Me.txtCosteReal.Enabled = False
        Me.txtCosteReal.Location = New System.Drawing.Point(9, 172)
        Me.txtCosteReal.Name = "txtCosteReal"
        Me.txtCosteReal.Size = New System.Drawing.Size(131, 21)
        Me.txtCosteReal.TabIndex = 147
        Me.txtCosteReal.TabStop = False
        '
        'lblTotalObraHijaPresupVta
        '
        Me.lblTotalObraHijaPresupVta.AutoSize = False
        Me.lblTotalObraHijaPresupVta.Location = New System.Drawing.Point(9, 94)
        Me.lblTotalObraHijaPresupVta.Name = "lblTotalObraHijaPresupVta"
        Me.lblTotalObraHijaPresupVta.Size = New System.Drawing.Size(131, 21)
        Me.lblTotalObraHijaPresupVta.TabIndex = 150
        Me.lblTotalObraHijaPresupVta.Text = "Total Previsto Venta"
        Me.lblTotalObraHijaPresupVta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCostePrevVenta
        '
        Me.txtCostePrevVenta.DisabledBackColor = System.Drawing.Color.White
        Me.txtCostePrevVenta.Enabled = False
        Me.txtCostePrevVenta.Location = New System.Drawing.Point(9, 115)
        Me.txtCostePrevVenta.Name = "txtCostePrevVenta"
        Me.txtCostePrevVenta.Size = New System.Drawing.Size(131, 21)
        Me.txtCostePrevVenta.TabIndex = 146
        Me.txtCostePrevVenta.TabStop = False
        '
        'lblTotalObraHijaPresup
        '
        Me.lblTotalObraHijaPresup.AutoSize = False
        Me.lblTotalObraHijaPresup.Location = New System.Drawing.Point(9, 37)
        Me.lblTotalObraHijaPresup.Name = "lblTotalObraHijaPresup"
        Me.lblTotalObraHijaPresup.Size = New System.Drawing.Size(131, 21)
        Me.lblTotalObraHijaPresup.TabIndex = 151
        Me.lblTotalObraHijaPresup.Text = "Total Previsto"
        Me.lblTotalObraHijaPresup.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCostePrev
        '
        Me.txtCostePrev.DisabledBackColor = System.Drawing.Color.White
        Me.txtCostePrev.Enabled = False
        Me.txtCostePrev.Location = New System.Drawing.Point(9, 58)
        Me.txtCostePrev.Name = "txtCostePrev"
        Me.txtCostePrev.Size = New System.Drawing.Size(131, 21)
        Me.txtCostePrev.TabIndex = 145
        Me.txtCostePrev.TabStop = False
        '
        'FraTotalObraPadre
        '
        Me.FraTotalObraPadre.Controls.Add(Me.lblFwTotalObraPresup)
        Me.FraTotalObraPadre.Controls.Add(Me.txtTotalCostePrev)
        Me.FraTotalObraPadre.Controls.Add(Me.lblTotalObraReal)
        Me.FraTotalObraPadre.Controls.Add(Me.txtTotalCosteReal)
        Me.FraTotalObraPadre.Controls.Add(Me.lblTotalObraPresupVta)
        Me.FraTotalObraPadre.Controls.Add(Me.txtTotalCostePrevVta)
        Me.FraTotalObraPadre.Controls.Add(Me.lblTotalObraFacturado)
        Me.FraTotalObraPadre.Controls.Add(Me.txtTotalCosteFact)
        Me.FraTotalObraPadre.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FraTotalObraPadre.Location = New System.Drawing.Point(0, 483)
        Me.FraTotalObraPadre.Name = "FraTotalObraPadre"
        Me.FraTotalObraPadre.Size = New System.Drawing.Size(782, 68)
        Me.FraTotalObraPadre.TabIndex = 153
        Me.FraTotalObraPadre.TabStop = False
        Me.FraTotalObraPadre.Text = "Total Proyecto Padre"
        '
        'lblFwTotalObraPresup
        '
        Me.lblFwTotalObraPresup.AutoSize = False
        Me.lblFwTotalObraPresup.Location = New System.Drawing.Point(289, 18)
        Me.lblFwTotalObraPresup.Name = "lblFwTotalObraPresup"
        Me.lblFwTotalObraPresup.Size = New System.Drawing.Size(116, 21)
        Me.lblFwTotalObraPresup.TabIndex = 0
        Me.lblFwTotalObraPresup.Text = "Total Previsto"
        Me.lblFwTotalObraPresup.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTotalCostePrev
        '
        Me.txtTotalCostePrev.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotalCostePrev.Enabled = False
        Me.txtTotalCostePrev.Location = New System.Drawing.Point(289, 39)
        Me.txtTotalCostePrev.Name = "txtTotalCostePrev"
        Me.txtTotalCostePrev.Size = New System.Drawing.Size(116, 21)
        Me.txtTotalCostePrev.TabIndex = 143
        Me.txtTotalCostePrev.TabStop = False
        '
        'lblTotalObraReal
        '
        Me.lblTotalObraReal.AutoSize = False
        Me.lblTotalObraReal.Location = New System.Drawing.Point(534, 18)
        Me.lblTotalObraReal.Name = "lblTotalObraReal"
        Me.lblTotalObraReal.Size = New System.Drawing.Size(116, 21)
        Me.lblTotalObraReal.TabIndex = 144
        Me.lblTotalObraReal.Text = "Total Real"
        Me.lblTotalObraReal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTotalCosteReal
        '
        Me.txtTotalCosteReal.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotalCosteReal.Enabled = False
        Me.txtTotalCosteReal.Location = New System.Drawing.Point(534, 39)
        Me.txtTotalCosteReal.Name = "txtTotalCosteReal"
        Me.txtTotalCosteReal.Size = New System.Drawing.Size(116, 21)
        Me.txtTotalCosteReal.TabIndex = 142
        Me.txtTotalCosteReal.TabStop = False
        '
        'lblTotalObraPresupVta
        '
        Me.lblTotalObraPresupVta.AutoSize = False
        Me.lblTotalObraPresupVta.Location = New System.Drawing.Point(412, 18)
        Me.lblTotalObraPresupVta.Name = "lblTotalObraPresupVta"
        Me.lblTotalObraPresupVta.Size = New System.Drawing.Size(116, 21)
        Me.lblTotalObraPresupVta.TabIndex = 145
        Me.lblTotalObraPresupVta.Text = "Total Prev. Venta"
        Me.lblTotalObraPresupVta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTotalCostePrevVta
        '
        Me.txtTotalCostePrevVta.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotalCostePrevVta.Enabled = False
        Me.txtTotalCostePrevVta.Location = New System.Drawing.Point(412, 39)
        Me.txtTotalCostePrevVta.Name = "txtTotalCostePrevVta"
        Me.txtTotalCostePrevVta.Size = New System.Drawing.Size(116, 21)
        Me.txtTotalCostePrevVta.TabIndex = 141
        Me.txtTotalCostePrevVta.TabStop = False
        '
        'lblTotalObraFacturado
        '
        Me.lblTotalObraFacturado.AutoSize = False
        Me.lblTotalObraFacturado.Location = New System.Drawing.Point(656, 18)
        Me.lblTotalObraFacturado.Name = "lblTotalObraFacturado"
        Me.lblTotalObraFacturado.Size = New System.Drawing.Size(116, 21)
        Me.lblTotalObraFacturado.TabIndex = 146
        Me.lblTotalObraFacturado.Text = "Total Facturado"
        Me.lblTotalObraFacturado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTotalCosteFact
        '
        Me.txtTotalCosteFact.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotalCosteFact.Enabled = False
        Me.txtTotalCosteFact.Location = New System.Drawing.Point(656, 39)
        Me.txtTotalCosteFact.Name = "txtTotalCosteFact"
        Me.txtTotalCosteFact.Size = New System.Drawing.Size(116, 21)
        Me.txtTotalCosteFact.TabIndex = 140
        Me.txtTotalCosteFact.TabStop = False
        '
        'TabPageProveedor
        '
        Me.TabPageProveedor.Controls.Add(Me.GridProveedores)
        Me.TabPageProveedor.Key = "Proveedores"
        Me.TabPageProveedor.Location = New System.Drawing.Point(1, 22)
        Me.TabPageProveedor.Name = "TabPageProveedor"
        Me.TabPageProveedor.Size = New System.Drawing.Size(782, 551)
        Me.TabPageProveedor.TabStop = True
        Me.TabPageProveedor.Text = "Proveedores"
        '
        'GridProveedores
        '
        Me.GridProveedores.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDProveedor", "Proveedor", "IDProveedor", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescProveedor", "DescProveedor")}), "")})
        GridProveedores_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("GridProveedores_DesignTimeLayout_Reference_0.Instance"), Object)
        GridProveedores_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {GridProveedores_DesignTimeLayout_Reference_0})
        GridProveedores_DesignTimeLayout.LayoutString = resources.GetString("GridProveedores_DesignTimeLayout.LayoutString")
        Me.GridProveedores.DesignTimeLayout = GridProveedores_DesignTimeLayout
        Me.GridProveedores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridProveedores.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridProveedores.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridProveedores.EntityName = "ObraProveedor"
        Me.GridProveedores.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridProveedores.FrozenColumns = 3
        Me.GridProveedores.Location = New System.Drawing.Point(0, 0)
        Me.GridProveedores.Name = "GridProveedores"
        Me.GridProveedores.PrimaryDataFields = "IDObra"
        Me.GridProveedores.SecondaryDataFields = "IDObra"
        Me.GridProveedores.Size = New System.Drawing.Size(782, 551)
        Me.GridProveedores.TabIndex = 0
        Me.GridProveedores.ViewName = "vFrmObraProveedor"
        '
        'TabPageCobrosPagos
        '
        Me.TabPageCobrosPagos.Controls.Add(Me.TabCobrosPagos)
        Me.TabPageCobrosPagos.Key = "CobrosPagos"
        Me.TabPageCobrosPagos.Location = New System.Drawing.Point(1, 23)
        Me.TabPageCobrosPagos.Name = "TabPageCobrosPagos"
        Me.TabPageCobrosPagos.Size = New System.Drawing.Size(686, 467)
        Me.TabPageCobrosPagos.TabStop = True
        Me.TabPageCobrosPagos.TabVisible = False
        Me.TabPageCobrosPagos.Text = "Cobros y Pagos"
        '
        'TabCobrosPagos
        '
        Me.TabCobrosPagos.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.TabCobrosPagos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabCobrosPagos.Location = New System.Drawing.Point(0, 0)
        Me.TabCobrosPagos.Name = "TabCobrosPagos"
        Me.TabCobrosPagos.Size = New System.Drawing.Size(686, 467)
        Me.TabCobrosPagos.TabIndex = 0
        Me.TabCobrosPagos.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.UiTabPage1, Me.UiTabPage2, Me.UiTabPage3})
        Me.TabCobrosPagos.TabStripAlignment = Janus.Windows.UI.Tab.TabStripAlignment.Right
        Me.TabCobrosPagos.UseThemes = True
        '
        'UiTabPage1
        '
        Me.UiTabPage1.Controls.Add(Me.GridTramos)
        Me.UiTabPage1.Controls.Add(Me.Splitter3)
        Me.UiTabPage1.Controls.Add(Me.TvwCobrosPagos)
        Me.UiTabPage1.Key = "TabTramos"
        Me.UiTabPage1.Location = New System.Drawing.Point(1, 1)
        Me.UiTabPage1.Name = "UiTabPage1"
        Me.UiTabPage1.Size = New System.Drawing.Size(663, 465)
        Me.UiTabPage1.TabStop = True
        Me.UiTabPage1.Text = "Tramos"
        '
        'GridTramos
        '
        GridTramos_DesignTimeLayout.LayoutString = resources.GetString("GridTramos_DesignTimeLayout.LayoutString")
        Me.GridTramos.DesignTimeLayout = GridTramos_DesignTimeLayout
        Me.GridTramos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridTramos.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridTramos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridTramos.EntityName = "ObraTramo"
        Me.GridTramos.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridTramos.Location = New System.Drawing.Point(229, 0)
        Me.GridTramos.Name = "GridTramos"
        Me.GridTramos.PrimaryDataFields = ""
        Me.GridTramos.RelationMode = Solmicro.Expertis.Engine.RelationMode.NoRelation
        Me.GridTramos.RequeryManually = True
        Me.GridTramos.SecondaryDataFields = ""
        Me.GridTramos.Size = New System.Drawing.Size(434, 465)
        Me.GridTramos.TabIndex = 5
        Me.GridTramos.ViewName = "tbObraTramo"
        '
        'Splitter3
        '
        Me.Splitter3.BackColor = System.Drawing.Color.White
        Me.Splitter3.Location = New System.Drawing.Point(224, 0)
        Me.Splitter3.Name = "Splitter3"
        Me.Splitter3.Size = New System.Drawing.Size(5, 465)
        Me.Splitter3.TabIndex = 4
        Me.Splitter3.TabStop = False
        '
        'TvwCobrosPagos
        '
        Me.TvwCobrosPagos.Dock = System.Windows.Forms.DockStyle.Left
        Me.TvwCobrosPagos.ImageIndex = 0
        Me.TvwCobrosPagos.ImageList = Me.ImageList1
        Me.TvwCobrosPagos.Location = New System.Drawing.Point(0, 0)
        Me.TvwCobrosPagos.Name = "TvwCobrosPagos"
        Me.TvwCobrosPagos.SelectedImageIndex = 0
        Me.TvwCobrosPagos.Size = New System.Drawing.Size(224, 465)
        Me.TvwCobrosPagos.TabIndex = 3
        '
        'UiTabPage2
        '
        Me.UiTabPage2.Controls.Add(Me.GridPlanningCobros)
        Me.UiTabPage2.Key = "TabPlanCobros"
        Me.UiTabPage2.Location = New System.Drawing.Point(1, 1)
        Me.UiTabPage2.Name = "UiTabPage2"
        Me.UiTabPage2.Size = New System.Drawing.Size(663, 465)
        Me.UiTabPage2.TabStop = True
        Me.UiTabPage2.Text = "Planning Cobros"
        '
        'GridPlanningCobros
        '
        Me.GridPlanningCobros.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridPlanningCobros.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridPlanningCobros.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridPlanningCobros_DesignTimeLayout.LayoutString = resources.GetString("GridPlanningCobros_DesignTimeLayout.LayoutString")
        Me.GridPlanningCobros.DesignTimeLayout = GridPlanningCobros_DesignTimeLayout
        Me.GridPlanningCobros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridPlanningCobros.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridPlanningCobros.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridPlanningCobros.EntityName = Nothing
        Me.GridPlanningCobros.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridPlanningCobros.Location = New System.Drawing.Point(0, 0)
        Me.GridPlanningCobros.Name = "GridPlanningCobros"
        Me.GridPlanningCobros.PrimaryDataFields = Nothing
        Me.GridPlanningCobros.SecondaryDataFields = Nothing
        Me.GridPlanningCobros.Size = New System.Drawing.Size(663, 465)
        Me.GridPlanningCobros.TabIndex = 0
        Me.GridPlanningCobros.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridPlanningCobros.ViewName = Nothing
        '
        'UiTabPage3
        '
        Me.UiTabPage3.Controls.Add(Me.GridPlanningPagos)
        Me.UiTabPage3.Key = "TabPlanPagos"
        Me.UiTabPage3.Location = New System.Drawing.Point(1, 1)
        Me.UiTabPage3.Name = "UiTabPage3"
        Me.UiTabPage3.Size = New System.Drawing.Size(663, 465)
        Me.UiTabPage3.TabStop = True
        Me.UiTabPage3.Text = "Planning Pagos"
        '
        'GridPlanningPagos
        '
        Me.GridPlanningPagos.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridPlanningPagos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridPlanningPagos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridPlanningPagos_DesignTimeLayout.LayoutString = "<GridEXLayoutData><RootTable><GroupCondition /></RootTable></GridEXLayoutData>"
        Me.GridPlanningPagos.DesignTimeLayout = GridPlanningPagos_DesignTimeLayout
        Me.GridPlanningPagos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridPlanningPagos.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridPlanningPagos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridPlanningPagos.EntityName = Nothing
        Me.GridPlanningPagos.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridPlanningPagos.Location = New System.Drawing.Point(0, 0)
        Me.GridPlanningPagos.Name = "GridPlanningPagos"
        Me.GridPlanningPagos.PrimaryDataFields = Nothing
        Me.GridPlanningPagos.SecondaryDataFields = Nothing
        Me.GridPlanningPagos.Size = New System.Drawing.Size(663, 465)
        Me.GridPlanningPagos.TabIndex = 0
        Me.GridPlanningPagos.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridPlanningPagos.ViewName = Nothing
        '
        'OpenDialog1
        '
        Me.OpenDialog1.DefaultExt = "*.doc"
        '
        'MenuObras
        '
        Me.MenuObras.CommandManager = Me.UiCommandManager1
        Me.MenuObras.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.MnuNuevoTrabajo2, Me.MnuNuevoTrabajoIncremento2, Me.MnuGuion, Me.MnuGeneraVtos2, Me.MnuPeriodificaciones1, Me.Separator6, Me.MnuDeleteTrabajo2, Me.MnuDeleteIncremento2, Me.MnuGuion1, Me.MnuADDIncremento2, Me.MnuGuion3, Me.MnuNuevoConcepto1, Me.MnuGuion4, Me.MnuDesgloseTrabajo2, Me.MnuVerFichaTrabajo2, Me.MnuGuion5, Me.mnuNuevaTarea2, Me.MnuTareasPred2, Me.MnuGuion2, Me.MnuAnalitica1, Me.MnuGuion6, Me.mnuGenerarCompras2, Me.mnuExpedir2, Me.mnuFacturacion2, Me.MnuGuion7, Me.mnuPlanificador1, Me.MnuGuion8, Me.mnuAvanceTrabajo1, Me.MnuGuion9, Me.mnuAltaDocumentos1, Me.mnuVincularDocumentos1, Me.mnuDocumentosRel1})
        Me.MenuObras.Key = "MenuObras"
        '
        'MnuNuevoTrabajo2
        '
        Me.MnuNuevoTrabajo2.Key = "MnuNuevoTrabajo"
        Me.MnuNuevoTrabajo2.Name = "MnuNuevoTrabajo2"
        '
        'MnuNuevoTrabajoIncremento2
        '
        Me.MnuNuevoTrabajoIncremento2.Key = "MnuNuevoTrabajoIncremento"
        Me.MnuNuevoTrabajoIncremento2.Name = "MnuNuevoTrabajoIncremento2"
        '
        'MnuGuion
        '
        Me.MnuGuion.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.MnuGuion.Key = "MnuGuion"
        Me.MnuGuion.Name = "MnuGuion"
        '
        'MnuGeneraVtos2
        '
        Me.MnuGeneraVtos2.Key = "MnuGeneraVtos"
        Me.MnuGeneraVtos2.Name = "MnuGeneraVtos2"
        '
        'MnuPeriodificaciones1
        '
        Me.MnuPeriodificaciones1.Key = "MnuPeriodificaciones"
        Me.MnuPeriodificaciones1.Name = "MnuPeriodificaciones1"
        '
        'Separator6
        '
        Me.Separator6.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.Separator6.Key = "Separator"
        Me.Separator6.Name = "Separator6"
        '
        'MnuDeleteTrabajo2
        '
        Me.MnuDeleteTrabajo2.Key = "MnuDeleteTrabajo"
        Me.MnuDeleteTrabajo2.Name = "MnuDeleteTrabajo2"
        '
        'MnuDeleteIncremento2
        '
        Me.MnuDeleteIncremento2.Key = "MnuDeleteIncremento"
        Me.MnuDeleteIncremento2.Name = "MnuDeleteIncremento2"
        '
        'MnuGuion1
        '
        Me.MnuGuion1.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.MnuGuion1.Key = "MnuGuion1"
        Me.MnuGuion1.Name = "MnuGuion1"
        '
        'MnuADDIncremento2
        '
        Me.MnuADDIncremento2.Key = "MnuADDIncremento"
        Me.MnuADDIncremento2.Name = "MnuADDIncremento2"
        '
        'MnuGuion3
        '
        Me.MnuGuion3.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.MnuGuion3.Key = "MnuGuion3"
        Me.MnuGuion3.Name = "MnuGuion3"
        '
        'MnuNuevoConcepto1
        '
        Me.MnuNuevoConcepto1.Key = "MnuNuevoConcepto"
        Me.MnuNuevoConcepto1.Name = "MnuNuevoConcepto1"
        '
        'MnuGuion4
        '
        Me.MnuGuion4.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.MnuGuion4.Key = "MnuGuion4"
        Me.MnuGuion4.Name = "MnuGuion4"
        '
        'MnuDesgloseTrabajo2
        '
        Me.MnuDesgloseTrabajo2.Key = "MnuDesgloseTrabajo"
        Me.MnuDesgloseTrabajo2.Name = "MnuDesgloseTrabajo2"
        '
        'MnuVerFichaTrabajo2
        '
        Me.MnuVerFichaTrabajo2.Key = "MnuVerFichaTrabajo"
        Me.MnuVerFichaTrabajo2.Name = "MnuVerFichaTrabajo2"
        '
        'MnuGuion5
        '
        Me.MnuGuion5.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.MnuGuion5.Key = "MnuGuion5"
        Me.MnuGuion5.Name = "MnuGuion5"
        '
        'mnuNuevaTarea2
        '
        Me.mnuNuevaTarea2.Key = "mnuNuevaTarea"
        Me.mnuNuevaTarea2.Name = "mnuNuevaTarea2"
        '
        'MnuTareasPred2
        '
        Me.MnuTareasPred2.Key = "MnuTareasPred"
        Me.MnuTareasPred2.Name = "MnuTareasPred2"
        '
        'MnuGuion2
        '
        Me.MnuGuion2.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.MnuGuion2.Key = "MnuGuion2"
        Me.MnuGuion2.Name = "MnuGuion2"
        '
        'MnuAnalitica1
        '
        Me.MnuAnalitica1.Key = "MnuAnalitica"
        Me.MnuAnalitica1.Name = "MnuAnalitica1"
        '
        'MnuGuion6
        '
        Me.MnuGuion6.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.MnuGuion6.Key = "MnuGuion6"
        Me.MnuGuion6.Name = "MnuGuion6"
        '
        'mnuGenerarCompras2
        '
        Me.mnuGenerarCompras2.Key = "mnuGenerarCompras"
        Me.mnuGenerarCompras2.Name = "mnuGenerarCompras2"
        '
        'mnuExpedir2
        '
        Me.mnuExpedir2.Key = "mnuExpedir"
        Me.mnuExpedir2.Name = "mnuExpedir2"
        '
        'mnuFacturacion2
        '
        Me.mnuFacturacion2.Key = "mnuFacturacion"
        Me.mnuFacturacion2.Name = "mnuFacturacion2"
        '
        'MnuGuion7
        '
        Me.MnuGuion7.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.MnuGuion7.Key = "MnuGuion7"
        Me.MnuGuion7.Name = "MnuGuion7"
        '
        'mnuPlanificador1
        '
        Me.mnuPlanificador1.Key = "mnuPlanificador"
        Me.mnuPlanificador1.Name = "mnuPlanificador1"
        '
        'MnuGuion8
        '
        Me.MnuGuion8.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.MnuGuion8.Key = "MnuGuion8"
        Me.MnuGuion8.Name = "MnuGuion8"
        '
        'mnuAvanceTrabajo1
        '
        Me.mnuAvanceTrabajo1.Key = "mnuAvanceTrabajo"
        Me.mnuAvanceTrabajo1.Name = "mnuAvanceTrabajo1"
        '
        'MnuGuion9
        '
        Me.MnuGuion9.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.MnuGuion9.Key = "MnuGuion9"
        Me.MnuGuion9.Name = "MnuGuion9"
        '
        'mnuAltaDocumentos1
        '
        Me.mnuAltaDocumentos1.Key = "mnuAltaDocumentos"
        Me.mnuAltaDocumentos1.Name = "mnuAltaDocumentos1"
        '
        'mnuVincularDocumentos1
        '
        Me.mnuVincularDocumentos1.Key = "mnuVincularDocumentos"
        Me.mnuVincularDocumentos1.Name = "mnuVincularDocumentos1"
        '
        'mnuDocumentosRel1
        '
        Me.mnuDocumentosRel1.Key = "mnuDocumentosRel"
        Me.mnuDocumentosRel1.Name = "mnuDocumentosRel1"
        '
        'MnuNuevoTrabajo
        '
        Me.MnuNuevoTrabajo.Icon = CType(resources.GetObject("MnuNuevoTrabajo.Icon"), System.Drawing.Icon)
        Me.MnuNuevoTrabajo.Key = "MnuNuevoTrabajo"
        Me.MnuNuevoTrabajo.Name = "MnuNuevoTrabajo"
        Me.MnuNuevoTrabajo.Text = "Nuevo trabajo"
        '
        'MnuNuevoTrabajoIncremento
        '
        Me.MnuNuevoTrabajoIncremento.Icon = CType(resources.GetObject("MnuNuevoTrabajoIncremento.Icon"), System.Drawing.Icon)
        Me.MnuNuevoTrabajoIncremento.Key = "MnuNuevoTrabajoIncremento"
        Me.MnuNuevoTrabajoIncremento.Name = "MnuNuevoTrabajoIncremento"
        Me.MnuNuevoTrabajoIncremento.Text = "Nuevo Incremento"
        '
        'MnuGeneraVtos
        '
        Me.MnuGeneraVtos.Icon = CType(resources.GetObject("MnuGeneraVtos.Icon"), System.Drawing.Icon)
        Me.MnuGeneraVtos.Key = "MnuGeneraVtos"
        Me.MnuGeneraVtos.Name = "MnuGeneraVtos"
        Me.MnuGeneraVtos.Text = "Generar Vencimientos"
        '
        'mnuNuevaTarea
        '
        Me.mnuNuevaTarea.Icon = CType(resources.GetObject("mnuNuevaTarea.Icon"), System.Drawing.Icon)
        Me.mnuNuevaTarea.Key = "mnuNuevaTarea"
        Me.mnuNuevaTarea.Name = "mnuNuevaTarea"
        Me.mnuNuevaTarea.Text = "Nueva Tarea"
        '
        'MnuDeleteTrabajo
        '
        Me.MnuDeleteTrabajo.Icon = CType(resources.GetObject("MnuDeleteTrabajo.Icon"), System.Drawing.Icon)
        Me.MnuDeleteTrabajo.Key = "MnuDeleteTrabajo"
        Me.MnuDeleteTrabajo.Name = "MnuDeleteTrabajo"
        Me.MnuDeleteTrabajo.Text = "Borrar Trabajo"
        '
        'MnuDeleteIncremento
        '
        Me.MnuDeleteIncremento.Icon = CType(resources.GetObject("MnuDeleteIncremento.Icon"), System.Drawing.Icon)
        Me.MnuDeleteIncremento.Key = "MnuDeleteIncremento"
        Me.MnuDeleteIncremento.Name = "MnuDeleteIncremento"
        Me.MnuDeleteIncremento.Text = "Borrar Incremento"
        '
        'MnuAnalitica
        '
        Me.MnuAnalitica.Icon = CType(resources.GetObject("MnuAnalitica.Icon"), System.Drawing.Icon)
        Me.MnuAnalitica.Key = "MnuAnalitica"
        Me.MnuAnalitica.Name = "MnuAnalitica"
        Me.MnuAnalitica.Text = "Analítica"
        '
        'MnuADDIncremento
        '
        Me.MnuADDIncremento.Icon = CType(resources.GetObject("MnuADDIncremento.Icon"), System.Drawing.Icon)
        Me.MnuADDIncremento.Key = "MnuADDIncremento"
        Me.MnuADDIncremento.Name = "MnuADDIncremento"
        Me.MnuADDIncremento.Text = "Añadir Incremento"
        '
        'MnuNuevoConcepto
        '
        Me.MnuNuevoConcepto.Key = "MnuNuevoConcepto"
        Me.MnuNuevoConcepto.Name = "MnuNuevoConcepto"
        Me.MnuNuevoConcepto.Text = "Nuevo Concepto"
        '
        'MnuDesgloseTrabajo
        '
        Me.MnuDesgloseTrabajo.Icon = CType(resources.GetObject("MnuDesgloseTrabajo.Icon"), System.Drawing.Icon)
        Me.MnuDesgloseTrabajo.Key = "MnuDesgloseTrabajo"
        Me.MnuDesgloseTrabajo.Name = "MnuDesgloseTrabajo"
        Me.MnuDesgloseTrabajo.Text = "Ver desglose trabajo"
        '
        'MnuVerFichaTrabajo
        '
        Me.MnuVerFichaTrabajo.Icon = CType(resources.GetObject("MnuVerFichaTrabajo.Icon"), System.Drawing.Icon)
        Me.MnuVerFichaTrabajo.Key = "MnuVerFichaTrabajo"
        Me.MnuVerFichaTrabajo.Name = "MnuVerFichaTrabajo"
        Me.MnuVerFichaTrabajo.Text = "Ver ficha trabajo"
        '
        'MnuTareasPred
        '
        Me.MnuTareasPred.Icon = CType(resources.GetObject("MnuTareasPred.Icon"), System.Drawing.Icon)
        Me.MnuTareasPred.Key = "MnuTareasPred"
        Me.MnuTareasPred.Name = "MnuTareasPred"
        Me.MnuTareasPred.Text = "Añadir Tareas Predeterminadas"
        '
        'mnuGenerarCompras
        '
        Me.mnuGenerarCompras.Icon = CType(resources.GetObject("mnuGenerarCompras.Icon"), System.Drawing.Icon)
        Me.mnuGenerarCompras.Key = "mnuGenerarCompras"
        Me.mnuGenerarCompras.Name = "mnuGenerarCompras"
        Me.mnuGenerarCompras.Text = "Generar Compra"
        '
        'mnuExpedir
        '
        Me.mnuExpedir.Icon = CType(resources.GetObject("mnuExpedir.Icon"), System.Drawing.Icon)
        Me.mnuExpedir.Key = "mnuExpedir"
        Me.mnuExpedir.Name = "mnuExpedir"
        Me.mnuExpedir.Text = "Expedir"
        '
        'mnuFacturacion
        '
        Me.mnuFacturacion.Icon = CType(resources.GetObject("mnuFacturacion.Icon"), System.Drawing.Icon)
        Me.mnuFacturacion.Key = "mnuFacturacion"
        Me.mnuFacturacion.Name = "mnuFacturacion"
        Me.mnuFacturacion.Text = "Facturar"
        '
        'MnuVerObras
        '
        Me.MnuVerObras.Icon = CType(resources.GetObject("MnuVerObras.Icon"), System.Drawing.Icon)
        Me.MnuVerObras.Key = "MnuVerObras"
        Me.MnuVerObras.Name = "MnuVerObras"
        Me.MnuVerObras.Text = "Ver Proyecto"
        '
        'MenuEstructura
        '
        Me.MenuEstructura.CommandManager = Me.UiCommandManager1
        Me.MenuEstructura.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.MnuVerObras1})
        Me.MenuEstructura.Key = "MenuEstructura"
        '
        'MnuVerObras1
        '
        Me.MnuVerObras1.Key = "MnuVerObras"
        Me.MnuVerObras1.Name = "MnuVerObras1"
        '
        'mnuPlanificador
        '
        Me.mnuPlanificador.Icon = CType(resources.GetObject("mnuPlanificador.Icon"), System.Drawing.Icon)
        Me.mnuPlanificador.Key = "mnuPlanificador"
        Me.mnuPlanificador.Name = "mnuPlanificador"
        Me.mnuPlanificador.Text = "Planificador de Recursos"
        '
        'mnuAvanceTrabajo
        '
        Me.mnuAvanceTrabajo.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.mnuADDPeriodosAvance1, Me.mnuActualizarAvanceReal1, Me.mnuRehacerPeriodos1, Me.Separator5, Me.mnuVerDesviaciones1})
        Me.mnuAvanceTrabajo.Icon = CType(resources.GetObject("mnuAvanceTrabajo.Icon"), System.Drawing.Icon)
        Me.mnuAvanceTrabajo.Key = "mnuAvanceTrabajo"
        Me.mnuAvanceTrabajo.Name = "mnuAvanceTrabajo"
        Me.mnuAvanceTrabajo.Text = "Avance del Trabajo"
        '
        'mnuADDPeriodosAvance1
        '
        Me.mnuADDPeriodosAvance1.Key = "mnuADDPeriodosAvance"
        Me.mnuADDPeriodosAvance1.Name = "mnuADDPeriodosAvance1"
        '
        'mnuActualizarAvanceReal1
        '
        Me.mnuActualizarAvanceReal1.Key = "mnuActualizarAvanceReal"
        Me.mnuActualizarAvanceReal1.Name = "mnuActualizarAvanceReal1"
        '
        'mnuRehacerPeriodos1
        '
        Me.mnuRehacerPeriodos1.Key = "mnuRehacerPeriodos"
        Me.mnuRehacerPeriodos1.Name = "mnuRehacerPeriodos1"
        '
        'Separator5
        '
        Me.Separator5.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.Separator5.Key = "Separator"
        Me.Separator5.Name = "Separator5"
        '
        'mnuVerDesviaciones1
        '
        Me.mnuVerDesviaciones1.Key = "mnuVerDesviaciones"
        Me.mnuVerDesviaciones1.Name = "mnuVerDesviaciones1"
        '
        'mnuADDPeriodosAvance
        '
        Me.mnuADDPeriodosAvance.Icon = CType(resources.GetObject("mnuADDPeriodosAvance.Icon"), System.Drawing.Icon)
        Me.mnuADDPeriodosAvance.Key = "mnuADDPeriodosAvance"
        Me.mnuADDPeriodosAvance.Name = "mnuADDPeriodosAvance"
        Me.mnuADDPeriodosAvance.Text = "Crear Períodos de avance"
        '
        'mnuActualizarAvanceReal
        '
        Me.mnuActualizarAvanceReal.Icon = CType(resources.GetObject("mnuActualizarAvanceReal.Icon"), System.Drawing.Icon)
        Me.mnuActualizarAvanceReal.Key = "mnuActualizarAvanceReal"
        Me.mnuActualizarAvanceReal.Name = "mnuActualizarAvanceReal"
        Me.mnuActualizarAvanceReal.Text = "Actualizar Avance Real"
        '
        'mnuRehacerPeriodos
        '
        Me.mnuRehacerPeriodos.Icon = CType(resources.GetObject("mnuRehacerPeriodos.Icon"), System.Drawing.Icon)
        Me.mnuRehacerPeriodos.Key = "mnuRehacerPeriodos"
        Me.mnuRehacerPeriodos.Name = "mnuRehacerPeriodos"
        Me.mnuRehacerPeriodos.Text = "Rehacer Períodos"
        '
        'mnuVerDesviaciones
        '
        Me.mnuVerDesviaciones.Icon = CType(resources.GetObject("mnuVerDesviaciones.Icon"), System.Drawing.Icon)
        Me.mnuVerDesviaciones.Key = "mnuVerDesviaciones"
        Me.mnuVerDesviaciones.Name = "mnuVerDesviaciones"
        Me.mnuVerDesviaciones.Text = "Ver Desviaciones"
        '
        'mnuAltaDocumentos
        '
        Me.mnuAltaDocumentos.Icon = CType(resources.GetObject("mnuAltaDocumentos.Icon"), System.Drawing.Icon)
        Me.mnuAltaDocumentos.Key = "mnuAltaDocumentos"
        Me.mnuAltaDocumentos.Name = "mnuAltaDocumentos"
        Me.mnuAltaDocumentos.Text = "Alta Documentos"
        '
        'mnuVincularDocumentos
        '
        Me.mnuVincularDocumentos.Icon = CType(resources.GetObject("mnuVincularDocumentos.Icon"), System.Drawing.Icon)
        Me.mnuVincularDocumentos.Key = "mnuVincularDocumentos"
        Me.mnuVincularDocumentos.Name = "mnuVincularDocumentos"
        Me.mnuVincularDocumentos.Text = "Vincular Documentos"
        '
        'mnuDocumentosRel
        '
        Me.mnuDocumentosRel.Icon = CType(resources.GetObject("mnuDocumentosRel.Icon"), System.Drawing.Icon)
        Me.mnuDocumentosRel.Key = "mnuDocumentosRel"
        Me.mnuDocumentosRel.Name = "mnuDocumentosRel"
        Me.mnuDocumentosRel.Text = "Documentos Relacionados"
        '
        'mnuArbolTrabajos
        '
        Me.mnuArbolTrabajos.Icon = CType(resources.GetObject("mnuArbolTrabajos.Icon"), System.Drawing.Icon)
        Me.mnuArbolTrabajos.Key = "mnuArbolTrabajos"
        Me.mnuArbolTrabajos.Name = "mnuArbolTrabajos"
        Me.mnuArbolTrabajos.ToolTipText = "Ver/Ocultar árbol trabajos"
        '
        'mnuArbolTrabajos1
        '
        Me.mnuArbolTrabajos1.Key = "mnuArbolTrabajos"
        Me.mnuArbolTrabajos1.Name = "mnuArbolTrabajos1"
        '
        'MnuGeneraVtosPeriodificados
        '
        Me.MnuGeneraVtosPeriodificados.Icon = CType(resources.GetObject("MnuGeneraVtosPeriodificados.Icon"), System.Drawing.Icon)
        Me.MnuGeneraVtosPeriodificados.Key = "MnuGeneraVtosPeriodificados"
        Me.MnuGeneraVtosPeriodificados.Name = "MnuGeneraVtosPeriodificados"
        Me.MnuGeneraVtosPeriodificados.Text = "Generar Vencimientos Periodificados"
        '
        'MnuGenerarTrabajosPeriodificados
        '
        Me.MnuGenerarTrabajosPeriodificados.Icon = CType(resources.GetObject("MnuGenerarTrabajosPeriodificados.Icon"), System.Drawing.Icon)
        Me.MnuGenerarTrabajosPeriodificados.Key = "MnuGenerarTrabajosPeriodificados"
        Me.MnuGenerarTrabajosPeriodificados.Name = "MnuGenerarTrabajosPeriodificados"
        Me.MnuGenerarTrabajosPeriodificados.Text = "Generar Trabajos Periodificados"
        '
        'MnuPeriodificaciones
        '
        Me.MnuPeriodificaciones.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.MnuGenerarTrabajosPeriodificados1, Me.MnuGeneraVtosPeriodificados1})
        Me.MnuPeriodificaciones.Icon = CType(resources.GetObject("MnuPeriodificaciones.Icon"), System.Drawing.Icon)
        Me.MnuPeriodificaciones.Key = "MnuPeriodificaciones"
        Me.MnuPeriodificaciones.Name = "MnuPeriodificaciones"
        Me.MnuPeriodificaciones.Text = "Periodificaciones"
        '
        'MnuGenerarTrabajosPeriodificados1
        '
        Me.MnuGenerarTrabajosPeriodificados1.Key = "MnuGenerarTrabajosPeriodificados"
        Me.MnuGenerarTrabajosPeriodificados1.Name = "MnuGenerarTrabajosPeriodificados1"
        '
        'MnuGeneraVtosPeriodificados1
        '
        Me.MnuGeneraVtosPeriodificados1.Key = "MnuGeneraVtosPeriodificados"
        Me.MnuGeneraVtosPeriodificados1.Name = "MnuGeneraVtosPeriodificados1"
        '
        'MntoObras
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(792, 659)
        Me.CreateTransaction = True
        Me.EntityName = "ObraCabecera"
        Me.FindTextField = "NObra"
        Me.LastUsedDescFields = "NObra"
        Me.Name = "MntoObras"
        Me.NavigationFields = "NObra"
        Me.ViewName = "frmMntoObras"
        CType(Me.ToolBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.PnlCabecera.ResumeLayout(False)
        Me.PnlCabecera.PerformLayout()
        CType(Me.cbxEstado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabObras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabObras.ResumeLayout(False)
        Me.TabPageCabeceraObra.ResumeLayout(False)
        Me.FraImportes.ResumeLayout(False)
        Me.FraImportes.PerformLayout()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Linea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FraTotalesObra.ResumeLayout(False)
        Me.FraTotalesObra.PerformLayout()
        Me.FraCondEconom.ResumeLayout(False)
        Me.FraCondEconom.PerformLayout()
        CType(Me.cbxCentroGestion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCliente.ResumeLayout(False)
        Me.pnlCliente.PerformLayout()
        CType(Me.cbxIDClase, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FraClientes.ResumeLayout(False)
        Me.FraClientes.PerformLayout()
        Me.FraFechas.ResumeLayout(False)
        Me.FraFechas.PerformLayout()
        Me.TabPageTrabajos.ResumeLayout(False)
        CType(Me.TabTrabajos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabTrabajos.ResumeLayout(False)
        Me.TabPageDetalleTrabajos.ResumeLayout(False)
        Me.pnlFichaTrabajo.ResumeLayout(False)
        Me.pnlFichaTrabajoFill.ResumeLayout(False)
        Me.pnlFichaTrabajoFill.PerformLayout()
        Me.FraImportesTrabajoFicha.ResumeLayout(False)
        Me.FraImportesTrabajoFicha.PerformLayout()
        Me.pnlFichaTrabajoTop.ResumeLayout(False)
        Me.pnlFichaTrabajoTop.PerformLayout()
        Me.FraPeriodificacion.ResumeLayout(False)
        Me.FraPeriodificacion.PerformLayout()
        CType(Me.cbxTipoPeriodoPeriodificacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxEstadoTrabajo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxTipoLinea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxTipoCoste, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FraSeguimiento.ResumeLayout(False)
        Me.FraSeguimiento.PerformLayout()
        Me.FraFechasTrabajo.ResumeLayout(False)
        Me.FraFechasTrabajo.PerformLayout()
        CType(Me.cbxIDCentroGestion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FraAvance.ResumeLayout(False)
        Me.FraAvance.PerformLayout()
        CType(Me.cbxTipoFacturacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxIDUDMedida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTrabajosCompleto.ResumeLayout(False)
        Me.pnlVerTrabajosCompleto.ResumeLayout(False)
        Me.pnlVerTrabajosCompleto.PerformLayout()
        Me.PnlTimeObras.ResumeLayout(False)
        Me.pnlGridTrabajo.ResumeLayout(False)
        CType(Me.GridTrabajos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlVerTrabajosGrid.ResumeLayout(False)
        Me.pnlVerTrabajosGrid.PerformLayout()
        Me.pnlConfigVerTrabajos.ResumeLayout(False)
        Me.pnlConfigVerTrabajos.PerformLayout()
        Me.FraImportesTrabajoGrid.ResumeLayout(False)
        Me.FraImportesTrabajoGrid.PerformLayout()
        Me.TabPagePrevistos.ResumeLayout(False)
        CType(Me.TabPrevistos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPrevistos.ResumeLayout(False)
        Me.TabPageMaterialesPrev.ResumeLayout(False)
        CType(Me.GridMaterialPrev, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageModPrev.ResumeLayout(False)
        CType(Me.GridMODPrev, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageCentrosPrev.ResumeLayout(False)
        CType(Me.GridCentrosPrev, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageGastosPrev.ResumeLayout(False)
        CType(Me.GridGastosPrev, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageVariosPrev.ResumeLayout(False)
        CType(Me.GridVariosPrev, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageMediciones.ResumeLayout(False)
        CType(Me.GridMediciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FraImportesMedicionesPrev.ResumeLayout(False)
        Me.FraImportesMedicionesPrev.PerformLayout()
        Me.pnlVerPrevistos.ResumeLayout(False)
        Me.pnlVerPrevistos.PerformLayout()
        Me.pnlConfigVerPrevistos.ResumeLayout(False)
        Me.pnlConfigVerPrevistos.PerformLayout()
        Me.FraTotalesPrev.ResumeLayout(False)
        Me.FraTotalesPrev.PerformLayout()
        Me.TabPageControl.ResumeLayout(False)
        CType(Me.TabControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl.ResumeLayout(False)
        Me.TabPageMaterialesControl.ResumeLayout(False)
        CType(Me.GridMaterialControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageModControl.ResumeLayout(False)
        CType(Me.GridMODControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageCentrosControl.ResumeLayout(False)
        CType(Me.GridCentroControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageGastosControl.ResumeLayout(False)
        CType(Me.GridGastosControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageVariosControl.ResumeLayout(False)
        CType(Me.GridVariosControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageControlMediciones.ResumeLayout(False)
        Me.pnlCertificacionTrabajo.ResumeLayout(False)
        CType(Me.GridCertificacionTrabajo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLabelCertificacionTrabajo.ResumeLayout(False)
        Me.pnlLabelCertificacionTrabajo.PerformLayout()
        CType(Me.GridCertificacionMedicion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCertificacion.ResumeLayout(False)
        CType(Me.GridCertificacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabTiposCertificacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabTiposCertificacion.ResumeLayout(False)
        Me.pnlLabelObraCertificacion.ResumeLayout(False)
        Me.pnlLabelObraCertificacion.PerformLayout()
        CType(Me.cbxTipoCertificacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlVerCertificacion.ResumeLayout(False)
        Me.pnlVerCertificacion.PerformLayout()
        Me.pnlVerControl.ResumeLayout(False)
        Me.pnlVerControl.PerformLayout()
        Me.pnlConfigVerControl.ResumeLayout(False)
        Me.pnlConfigVerControl.PerformLayout()
        Me.FraTotalesReal.ResumeLayout(False)
        Me.FraTotalesReal.PerformLayout()
        Me.TabPageHitos.ResumeLayout(False)
        CType(Me.GridVencimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlVerHitos.ResumeLayout(False)
        Me.pnlVerHitos.PerformLayout()
        Me.pnlTotalesHitos.ResumeLayout(False)
        Me.pnlTotalesHitos.PerformLayout()
        Me.pnlConfigTipoMonedaHitos.ResumeLayout(False)
        Me.pnlConfigTipoMonedaHitos.PerformLayout()
        Me.pnlConfigVerHitos.ResumeLayout(False)
        Me.pnlConfigVerHitos.PerformLayout()
        Me.TabPageTareas.ResumeLayout(False)
        CType(Me.GridTareas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlVerTareas.ResumeLayout(False)
        Me.pnlVerTareas.PerformLayout()
        Me.pnlConfigVerTareas.ResumeLayout(False)
        Me.pnlConfigVerTareas.PerformLayout()
        Me.TabPageOficios.ResumeLayout(False)
        CType(Me.GridOperariosTrabajo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlVerOperarios.ResumeLayout(False)
        Me.pnlVerOperarios.PerformLayout()
        Me.pnlConfigVerOperarios.ResumeLayout(False)
        Me.pnlConfigVerOperarios.PerformLayout()
        Me.TabPageAvance.ResumeLayout(False)
        CType(Me.GridAvanceTrabajo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLeyendaAvance.ResumeLayout(False)
        Me.pnlLeyendaAvance.PerformLayout()
        Me.pnlVerAvance.ResumeLayout(False)
        Me.pnlVerAvance.PerformLayout()
        Me.pnlTrabajos.ResumeLayout(False)
        Me.FraArbol.ResumeLayout(False)
        Me.FraArbol.PerformLayout()
        CType(Me.cbxEstadoDistintoDE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FraCriterios.ResumeLayout(False)
        Me.TabPageCaracteristicas.ResumeLayout(False)
        CType(Me.GridCaracteristicas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageRecursos.ResumeLayout(False)
        CType(Me.GridRecursos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageSeguimiento.ResumeLayout(False)
        Me.TabPageSeguimiento.PerformLayout()
        Me.pnlObservaciones.ResumeLayout(False)
        Me.pnlObservaciones.PerformLayout()
        Me.fra.ResumeLayout(False)
        Me.fra.PerformLayout()
        CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.FraRetencion.ResumeLayout(False)
        Me.FraRetencion.PerformLayout()
        CType(Me.cbxTipoPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoRetencionImpuestos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxTipoRetencion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridCostes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FraDireccion.ResumeLayout(False)
        Me.FraDireccion.PerformLayout()
        Me.TabPageEstructura.ResumeLayout(False)
        Me.pnlTopEstructura.ResumeLayout(False)
        Me.pnlTopEstructura.PerformLayout()
        Me.FraTotalSeleccionObra.ResumeLayout(False)
        Me.FraTotalSeleccionObra.PerformLayout()
        Me.FraTotalObraPadreEstructura.ResumeLayout(False)
        Me.FraTotalObraPadreEstructura.PerformLayout()
        Me.TabPageCoste.ResumeLayout(False)
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.FraTotalObraPadre.ResumeLayout(False)
        Me.FraTotalObraPadre.PerformLayout()
        Me.TabPageProveedor.ResumeLayout(False)
        CType(Me.GridProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageCobrosPagos.ResumeLayout(False)
        CType(Me.TabCobrosPagos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabCobrosPagos.ResumeLayout(False)
        Me.UiTabPage1.ResumeLayout(False)
        CType(Me.GridTramos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiTabPage2.ResumeLayout(False)
        CType(Me.GridPlanningCobros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiTabPage3.ResumeLayout(False)
        CType(Me.GridPlanningPagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuObras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuEstructura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Constantes "

    Private Const cnCOPIAROBRA As String = "Copiar Proyecto"
    Private Const cnCOPIAROBRACONTROL As String = "Copiar Proyecto para Control"
    Private Const cnCOPIAROBRAFACTURACION As String = "Copiar Proyecto para Facturación"
    Private Const cnABRIRPRESUPUESTO As String = "Abrir Presupuesto"
    Private Const cnCOPIARCERTIFICACIONCLIENTE As String = "Copiar Certificación para Cliente"
    Private Const cnCOPIARCERTIFICACIONPRODUCCION As String = "Copiar Certificación para Producción"
    Private Const cnIMPORTARCERTIFICACION As String = "Importar Certificación"
    Private Const cnABRIRFACTURAVENTA As String = "Abrir Factura Venta"
    Private Const cnEXPEDICION As String = "Expedición"
    Private Const cnFACTURACION As String = "Facturación"
    Private Const cnABRIRMATERIAL As String = "Abrir Material"
    Private Const cnIMPORTARESTRUCTURA As String = "Importar Estructura"
    Private Const cnABRIRALBARANCOMPRA As String = "Abrir Albarán Compra"
    Private Const cnABRIRFACTURACOMPRA As String = "Abrir Factura Compra"
    Private Const cnABRIRCATEGORIAS As String = "Abrir Categoría"
    Private Const cnABRIRACTIVO As String = "Abrir Activo"
    Private Const cnGenerarOT As String = "Lanzamiento OT's"
    Private Const cnConsultaOT As String = "Resumen OT's"

#End Region

    Private dtTrabajos, mdtTotales As DataTable
    Private drTrabajos, drTrabajoCobrosPagos As DataRow
    Private mdblTotalPrev, mdblTotalPrevVenta, mdblTotalReal, mdblTotalFact, mdblTotalPIOrigen As Double
    Private mstrListaObrasEstructura, mstrListaObrasCoste As String
    Private mstrIDOperario, strDescOperario, mstrDescHora, mstrIDHora, mstrEjercicioActual, mstrIDUDMedida, mstrIDCGestion As String
    Private mintIDObraSeleccionado, mintRedondeoA, intTrabajoActual As Integer
    Private mblnGestionConstructoras, blnNoAcumular, blnChecked, blnPintarTrabajos, blnNoBinding, mblnAplicarMultinivel, mblnAnalitica As Boolean
    Private mblnRefresh As Boolean = True
    Private blnTabTiposCertificacionVisible, blnVerTrabajo, mSeleccionarNodoTrabajoDesdeGrid As Boolean
    Private blnRefreshArbol, blnRecordStateChanged As Boolean
    Private mdtGridCobrosPagos As DataTable
    Private mblnCambioFacturableTrabajo As Boolean
    Private mblnCambioTipoFacturacion As Boolean
    Private mblnFacturablePorConceptos As Boolean

    Private ndTrabajos, ndMateriales, ndMOD, ndCentros, ndGastos, ndVarios, ndMediciones, ndTrabajoOperario, ndAvance As ProviderNeededData

    Private WithEvents sctTipoIncremento As AdvancedSearch
    Private WithEvents AdvDireccionEnvio As AdvancedSearch

    Private strTipoTrabajo, strSubTipoTrabajo As String

    Public Enum eTipoArbol
        enumtipoEstructura = 0
        enumtipoCoste = 1
    End Enum

    Private Enum eOrigenCalculo
        eOrigenAccion = 0
        eOrigenFechaObra = 1
        eOrigenFechaTrabajo = 2
        eOrigenFechaTarea = 3
    End Enum

#Region " Binding "

    Protected Overridable Sub GetDatosTrabajo(ByVal row As DataRow)
        ndTrabajos.Row = row
    End Sub

    Private MakeBinding As Boolean
    Protected Overridable Sub BindingDetalleTrabajo()
        If Not MakeBinding Then
            'Me.AddBinding(Me.txtTipoObra, "Text", "IDTipoObra")
            Me.AddBinding(Me.AdvTipoTrabajo, "Text", "IDTipoTrabajo")
            Me.AddBinding(Me.AdvSubTipoTrabajo, "Text", "IDSubTipoTrabajo")
            Me.AddBinding(Me.AdvSubSubTipoTrabajo, "Text", "SubSubTipoTrabajo")
            Me.AddBinding(Me.txtCodTrabajo, "Text", "CodTrabajo")
            Me.AddBinding(Me.txtDescTrabajo, "Text", "DescTrabajo")
            Me.AddBinding(Me.cbxIDUDMedida, "Text", "IDUdMedida")
            Me.AddBinding(Me.ntxQUnidad, "Value", "QUnidad")
            Me.AddBinding(Me.txtQPrev, "Value", "QPrev")
            Me.AddBinding(Me.txtQPrevResponsable, "Value", "QPrevResponsable")
            Me.AddBinding(Me.txtQReal, "Value", "QReal")
            Me.AddBinding(Me.txtImpUnitario, "Value", "ImpPrevTrabajoA")
            Me.AddBinding(Me.txtMargenTrabajoFicha, "Value", "MargenPrevTrabajo")
            Me.AddBinding(Me.txtImpUnitarioVta, "Value", "ImpPrevTrabajoVentaA")
            'Me.AddBinding(Me.txtImpTotalA, "Value", "ImpPrevQTrabajoA")
            Me.AddBinding(Me.chkFacturable, "BindableValue", "Facturable")
            Me.AddBinding(Me.chkNoAcumular, "BindableValue", "NoAcumular")
            Me.AddBinding(Me.cbxTipoCoste, "Value", "TipoCosteDI")
            Me.AddBinding(Me.cbxTipoFacturacion, "Value", "TipoFacturacion")
            Me.AddBinding(Me.txtQCertificada, "Value", "QTotalCertificada")
            Me.AddBinding(Me.AdvIDArticulo, "Text", "IDArticulo")
            Me.AddBinding(Me.cbxTipoLinea, "Value", "TipoLinea")
            Me.AddBinding(Me.cbxEstadoTrabajo, "Value", "Estado")
            Me.AddBinding(Me.txtSecuencia, "Text", "Secuencia")
            Me.AddBinding(Me.txtDuracionPrev, "Value", "DuracionPrev")
            Me.AddBinding(Me.txtSolapeAnt, "Text", "Solape")
            Me.AddBinding(Me.txtNivelTrabajo, "Text", "Nivel")
            Me.AddBinding(Me.txtAvanceEstimado, "Value", "AvanceEstimado")
            Me.AddBinding(Me.txtAvanceCalculado, "Value", "AvanceCalculado")
            Me.AddBinding(Me.cbxFechaInicioTrabajo, "BindableValue", "FechaInicio")
            Me.AddBinding(Me.cbxFechaFinTrabajo, "BindableValue", "FechaFin")
            Me.AddBinding(Me.txtNumPedido, "Text", "NumeroPedido")
            Me.AddBinding(Me.cbxIDCentroGestion, "Value", "IDCentroGestion")
            Me.AddBinding(Me.txtTextoTrabajo, "Text", "Texto")
            Me.AddBinding(Me.AdvTrabajoPresup, "Value", "IDTrabajoPresup")
            Me.AddBinding(Me.AdvTrabajoPresup, "Text", "CodTrabajoPresup")
            Me.AddBinding(Me.txtIncremento, "Value", "Incremento")
            Me.AddBinding(Me.chkPlanificarRecursosPorTareas, "BindableValue", "PlanificarRecursosPorTareas")
            '''''''''''''
            Me.AddBinding(Me.txtTrabajoGrid, "Text", "CodTrabajo")
            Me.AddBinding(Me.txtDescTrabajoGrid, "Text", "DescTrabajo")
            Me.AddBinding(Me.txtTrabajoCompleto, "Text", "CodTrabajo")
            Me.AddBinding(Me.txtDescTrabajoCompleto, "Text", "DescTrabajo")
            Me.AddBinding(Me.txtTrabajoPrev, "Text", "CodTrabajo")
            Me.AddBinding(Me.txtDescTrabajoPrev, "Text", "DescTrabajo")
            Me.AddBinding(Me.txtTrabajoControl, "Text", "CodTrabajo")
            Me.AddBinding(Me.txtDescTrabajoControl, "Text", "DescTrabajo")
            Me.AddBinding(Me.txtTrabajoHitos, "Text", "CodTrabajo")
            Me.AddBinding(Me.txtDescTrabajoHitos, "Text", "DescTrabajo")
            Me.AddBinding(Me.txtTrabajoTareas, "Text", "CodTrabajo")
            Me.AddBinding(Me.txtDescTrabajoTareas, "Text", "DescTrabajo")
            Me.AddBinding(Me.txtTrabajoOperarios, "Text", "CodTrabajo")
            Me.AddBinding(Me.txtDescTrabajoOperarios, "Text", "DescTrabajo")
            Me.AddBinding(Me.txtTrabajoAvance, "Text", "CodTrabajo")
            Me.AddBinding(Me.txtDescTrabajoAvance, "Text", "DescTrabajo")
            Me.AddBinding(Me.cbxFechaInicioTrabajoAvance, "BindableValue", "FechaInicio")
            Me.AddBinding(Me.cbxFechaFinTrabajoAvance, "BindableValue", "FechaFin")
            '''''''''''''
            Me.AddBinding(Me.txtPrevistoTrabajo, "Value", "ImpPrevQTrabajoA")
            Me.AddBinding(Me.txtPrevistoVentaTrabajo, "Value", "ImpPrevQTrabajoVentaA")
            Me.AddBinding(Me.txtRealTrabajo, "Value", "ImpRealTrabajoA")
            Me.AddBinding(Me.txtFacturadoTrabajo, "Value", "ImpFactTrabajoA")

            Me.AddBinding(Me.txtQPrevTrabajo, "Value", "QPrev")

            Me.AddBinding(Me.chkPeriodificable, "BindableValue", "Periodificable")
            Me.AddBinding(Me.ntxPeriodoPeriodificacion, "Value", "Periodo")
            Me.AddBinding(Me.cbxTipoPeriodoPeriodificacion, "Value", "TipoPeriodo")
            Me.AddBinding(Me.chkAplicarSobreUltimo, "BindableValue", "AplicarSobreUltimo")

            MakeBinding = True
        End If
    End Sub

    Protected Overridable Sub AddBinding(ByVal control As Control, ByVal propertyName As String, ByVal dataMember As String)
        If (dataMember = "codtrabajo") Or (dataMember = "Desctrabajo") Then
            control.Enabled = False
        Else
            control.Enabled = True
        End If
        control.DataBindings.Add(propertyName, Me.ndTrabajos, dataMember)

    End Sub
#End Region

#Region " Load "

    Protected Overridable Sub MntoObras_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            LoadERPData()
            LoadNedeedData()
            LoadToolBarActions()
            LoadGridActions()
            LoadEnums()
            LoadMonedasInternas()
            LoadFormParams()
            Configure()
            CreateFormatStyle()
        End If
    End Sub

    Protected Overridable Sub LoadERPData()
        Dim o As Operario.DatosOperario = ExpertisApp.ExecuteTask(Of Object, Operario.DatosOperario)(AddressOf Operario.ObtenerOperarioUsuario, New Object)
        mstrIDOperario = o.IDOficio
        strDescOperario = o.DescOperario

        Dim cgu As New UsuarioCentroGestion.UsuarioCentroGestionInfo
        cgu = ExpertisApp.ExecuteTask(Of UsuarioCentroGestion.UsuarioCentroGestionInfo, UsuarioCentroGestion.UsuarioCentroGestionInfo)(AddressOf UsuarioCentroGestion.ObtenerUsuarioCentroGestion, cgu)
        mstrIDCGestion = cgu.IDCentroGestion


        Dim p As New Parametro
        mstrIDHora = p.HoraPred
        mstrIDUDMedida = p.UdMedidaPred
        mblnGestionConstructoras = p.GestionConstructoras
        blnNoAcumular = p.NoAcumularEnTrabajo
        mblnAplicarMultinivel = p.AplicarMultinivelEnObras
        mblnAnalitica = p.CAnaliticPredet

        If Length(mstrIDHora) > 0 Then
            Dim dtHora As DataTable = New Hora().SelOnPrimaryKey(mstrIDHora)
            If Not dtHora Is Nothing AndAlso dtHora.Rows.Count > 0 Then
                mstrDescHora = dtHora.Rows(0)("DescHora")
            End If
        End If
    End Sub

#Region " NedeedData "

    Protected Overridable Sub LoadNedeedData()
        LoadNedeedDataTrabajos()
        LoadNedeedDataMateriales()
        LoadNedeedDataMOD()
        LoadNedeedDataCentros()
        LoadNedeedDataGastos()
        LoadNedeedDataVarios()
        LoadNedeedDataMediciones()
        LoadNedeedDataTrabajoOperario()
        LoadNedeedDataAvance()
    End Sub

    Protected Overridable Sub LoadNedeedDataTrabajos()
        'Trabajos
        ndTrabajos = New ProviderNeededData
        ndTrabajos.Name = "Trabajos"
        ndTrabajos.EntityName = "ObraTrabajo"
        GridTrabajos.EntityName = ndTrabajos.EntityName
        Dim s(0) As String
        s(0) = "IDObra"
        ndTrabajos.PrimaryDataFields = s
        ndTrabajos.SecondaryDataFields = s
        ndTrabajos.RelationMode = RelationMode.ChildMode
        If mblnAplicarMultinivel Then
            ndTrabajos.ViewName = "vFrmObraTrabajos"
        Else
            ndTrabajos.ViewName = "vFrmObraTrabajosMultinivel"
        End If
        GridTrabajos.ViewName = ndTrabajos.ViewName
        ndTrabajos.UpdateOrder = -1

        Me.AddDataItem(ndTrabajos)
    End Sub

    Protected Overridable Sub LoadNedeedDataMateriales()
        ndMateriales = New ProviderNeededData
        ndMateriales.Name = "Materiales"
        ndMateriales.EntityName = "ObraMaterial"
        GridMaterialPrev.EntityName = ndMateriales.EntityName
        Dim s(0) As String
        s(0) = "IDObra"
        ndMateriales.PrimaryDataFields = s
        ndMateriales.SecondaryDataFields = s
        ndMateriales.RelationMode = RelationMode.ChildMode
        ndMateriales.ViewName = "vFrmObraMateriales"
        GridMaterialPrev.ViewName = ndMateriales.ViewName

        Me.AddDataItem(ndMateriales)
    End Sub

    Protected Overridable Sub LoadNedeedDataMOD()
        ndMOD = New ProviderNeededData
        ndMOD.Name = "MOD"
        ndMOD.EntityName = "ObraMOD"
        GridMODPrev.EntityName = ndMOD.EntityName
        Dim s(0) As String
        s(0) = "IDObra"
        ndMOD.PrimaryDataFields = s
        ndMOD.SecondaryDataFields = s
        ndMOD.RelationMode = RelationMode.ChildMode
        ndMOD.ViewName = "vFrmObraMOD"
        GridMODPrev.ViewName = ndMOD.ViewName

        Me.AddDataItem(ndMOD)
    End Sub

    Protected Overridable Sub LoadNedeedDataCentros()
        ndCentros = New ProviderNeededData
        ndCentros.Name = "Centros"
        ndCentros.EntityName = "ObraCentro"
        GridCentrosPrev.EntityName = ndCentros.EntityName
        Dim s(0) As String
        s(0) = "IDObra"
        ndCentros.PrimaryDataFields = s
        ndCentros.SecondaryDataFields = s
        ndCentros.RelationMode = RelationMode.ChildMode
        ndCentros.ViewName = "vFrmObraCentro"
        GridCentrosPrev.ViewName = ndCentros.ViewName

        Me.AddDataItem(ndCentros)
    End Sub

    Protected Overridable Sub LoadNedeedDataGastos()
        ndGastos = New ProviderNeededData
        ndGastos.Name = "Gastos"
        ndGastos.EntityName = "ObraGasto"
        GridGastosPrev.EntityName = ndGastos.EntityName
        Dim s(0) As String
        s(0) = "IDObra"
        ndGastos.PrimaryDataFields = s
        ndGastos.SecondaryDataFields = s
        ndGastos.RelationMode = RelationMode.ChildMode
        ndGastos.ViewName = "vFrmObraGastos"
        GridGastosPrev.ViewName = ndGastos.ViewName

        Me.AddDataItem(ndGastos)
    End Sub

    Protected Overridable Sub LoadNedeedDataVarios()
        ndVarios = New ProviderNeededData
        ndVarios.Name = "Varios"
        ndVarios.EntityName = "ObraVarios"
        GridVariosPrev.EntityName = ndVarios.EntityName
        Dim s(0) As String
        s(0) = "IDObra"
        ndVarios.PrimaryDataFields = s
        ndVarios.SecondaryDataFields = s
        ndVarios.RelationMode = RelationMode.ChildMode
        ndVarios.ViewName = "vFrmObraVarios"
        GridVariosPrev.ViewName = ndVarios.ViewName

        Me.AddDataItem(ndVarios)
    End Sub

    Protected Overridable Sub LoadNedeedDataMediciones()
        ndMediciones = New ProviderNeededData
        ndMediciones.Name = "Mediciones"
        ndMediciones.EntityName = "ObraMedicion"
        GridMediciones.EntityName = ndMediciones.EntityName
        Dim s(0) As String
        s(0) = "IDObra"
        ndMediciones.PrimaryDataFields = s
        ndMediciones.SecondaryDataFields = s
        ndMediciones.RelationMode = RelationMode.ChildMode
        ndMediciones.ViewName = "vFrmObraMedicion"
        GridMediciones.ViewName = ndMediciones.ViewName

        Me.AddDataItem(ndMediciones)
    End Sub

    Protected Overridable Sub LoadNedeedDataTrabajoOperario()
        ndTrabajoOperario = New ProviderNeededData
        ndTrabajoOperario.Name = "ObraTrabajoOperario"
        ndTrabajoOperario.EntityName = "ObraTrabajoOperario"
        GridOperariosTrabajo.EntityName = ndTrabajoOperario.EntityName
        Dim s(0) As String
        s(0) = "IDObra"
        ndTrabajoOperario.PrimaryDataFields = s
        ndTrabajoOperario.SecondaryDataFields = s
        ndTrabajoOperario.RelationMode = RelationMode.ChildMode
        ndTrabajoOperario.ViewName = "vFrmObrasTrabajoOperario"
        GridOperariosTrabajo.ViewName = ndTrabajoOperario.ViewName

        Me.AddDataItem(ndTrabajoOperario)
    End Sub

    Protected Overridable Sub LoadNedeedDataAvance()
        ndAvance = New ProviderNeededData
        ndAvance.Name = "Avance"
        ndAvance.EntityName = "ObraTrabajoAvance"
        GridAvanceTrabajo.EntityName = ndAvance.EntityName
        Dim s(0) As String
        s(0) = "IDObra"
        ndAvance.PrimaryDataFields = s
        ndAvance.SecondaryDataFields = s
        ndAvance.RelationMode = RelationMode.ChildMode
        ndAvance.ViewName = "vFrmObraTrabajoAvance"
        GridAvanceTrabajo.ViewName = ndAvance.ViewName

        Me.AddDataItem(ndAvance)
    End Sub
#End Region

    Protected Overridable Sub LoadToolBarActions()
        Me.FormActions.Add(cnABRIRPRESUPUESTO, AddressOf AccionAbrirPresupuesto, ExpertisApp.GetIcon("xPresupuestos.ico"))
        Me.FormActions.Add("Generar Trabajos no existentes", AddressOf AccionCopiarTiposTrabajos, ExpertisApp.GetIcon("xCopiaTipoTrabajo.ico"))
        Me.AddSeparator()
        Me.FormActions.Add("Estructura Proyecto", AddressOf AccionEstructuraObra, ExpertisApp.GetIcon("xEstructuras1.ico"))
        Me.AddSeparator()
        Me.FormActions.Add(cnCOPIAROBRA, AddressOf AccionCopiarObra, ExpertisApp.GetIcon("cube_molecule_add.ico"))
        Me.FormActions.Add(cnCOPIAROBRACONTROL, AddressOf AccionCopiarObraParaControl, ExpertisApp.GetIcon("cube_molecule_add.ico"))
        Me.FormActions.Add(cnCOPIAROBRAFACTURACION, AddressOf AccionCopiarObraParaFacturacion, ExpertisApp.GetIcon("cube_molecule_add.ico"))
        Me.AddSeparator()
        Me.FormActions.Add("Direcciones de Envío", AddressOf AccionAbrirDireccionesEnvio, ExpertisApp.GetIcon("find_again.ico"))
        Me.AddSeparator()
        Me.FormActions.Add("Enviar a Microsoft Project", AddressOf CargarMsProject, ExpertisApp.GetIcon("xMSProject.ico"))
        If mblnAnalitica Then
            Me.AddSeparator()
            Me.FormActions.Add("Analítica por Proyecto", AddressOf AccionAnaliticaPorObra, ExpertisApp.GetIcon("folders.ico"))
        End If
        Me.AddSeparator()
        Me.FormActions.Add("Generar Trabajos Periodificados", AddressOf AccionGenerarTrabajosPeriodificados, ExpertisApp.GetIcon("gear_time.ico"))
        Me.FormActions.Add("Generar Vencimientos Periodificados", AddressOf AccionGenerarHitosPeriodificados, ExpertisApp.GetIcon("clock_refresh.ico"))
        Me.AddSeparator()
        Me.FormActions.Add("Nueva Certificación", AddressOf AccionCertificacion, ExpertisApp.GetIcon("book_blue_add.ico"))
        Me.AddSeparator()
        Me.FormActions.Add("Incluir Tareas Predefinidas", AddressOf AccionIncluirTareas, ExpertisApp.GetIcon("xTareas.ico"))
        Me.FormActions.Add("Calendario Tareas", AddressOf CargarCalendarioTareas, ExpertisApp.GetIcon("calendar.ico"))
        Me.AddSeparator()
        Me.FormActions.Add("Calendario Proyecto", AddressOf CargarCalendario, ExpertisApp.GetIcon("calendar_preferences.ico"))
        Me.AddSeparator()
        Me.FormActions.Add("Generar Compra", AddressOf AccionGenerarCompra, ExpertisApp.GetIcon("xComprasObra.ico"))
        Me.FormActions.Add(cnEXPEDICION, AddressOf AccionExpedicion, ExpertisApp.GetIcon("xMaterialesObra.ico"))
        Me.FormActions.Add(cnFACTURACION, AddressOf AccionFacturacion, ExpertisApp.GetIcon("xFacturacionProyectos.ico"))
        Me.AddSeparator()
        Me.FormActions.Add("Recalcular Proyecto", AddressOf AccionRecalcularObra, ExpertisApp.GetIcon("calculator.ico"))
        Me.AddSeparator()
        Me.FormActions.Add("Incorporar Fichero XML SOLID", AddressOf AccionIncorporarFicheroXMLSolid, ExpertisApp.GetIcon("text_code_colored.ico"))
    End Sub

#Region " Load Grid Actions "

    Protected Overridable Sub LoadGridActions()
        LoadGridTrabajos()
        LoadGridPrevistos()
        LoadGridControl()
        LoadGridVencimientos()
        LoadGridCertificacion()
    End Sub

    Protected Overridable Sub LoadGridTrabajos()
        GridTrabajos.Actions.Add("Nuevo Trabajo", AddressOf AccionNuevoTrabajo, ExpertisApp.GetIcon("xPrepExpediciones.ico"))
        GridTrabajos.Actions.Add("Generar Vencimientos", AddressOf AccionGenerarVencimientosTrabajo, ExpertisApp.GetIcon("stopwatch_run.ico"))
        GridTrabajos.Actions.Add("Nueva Tarea", AddressOf AccionNuevaTarea, ExpertisApp.GetIcon("xTareas.ico"))
        If mblnAnalitica Then
            GridTrabajos.Actions.Add("Analítica", AddressOf AccionVerAnaliticaTrabajo, ExpertisApp.GetIcon("folders.ico"))
        End If
        GridTrabajos.AddSeparator()
        GridTrabajos.Actions.Add("Ver Desglose Trabajo", AddressOf AccionDesgloseTrabajo, ExpertisApp.GetIcon("xTesoreria.ico"))
        GridTrabajos.Actions.Add("Ver Ficha Trabajo", AddressOf AccionVerFicha, ExpertisApp.GetIcon("window.ico"))
        GridTrabajos.AddSeparator()
        GridTrabajos.Actions.Add("Alta Documentos", AddressOf AccionAltaDocumentos, ExpertisApp.GetIcon("document_add.ico"))
        GridTrabajos.Actions.Add("Vincular Documentos", AddressOf AccionVincularDocumentos, ExpertisApp.GetIcon("document_into.ico"))
        GridTrabajos.Actions.Add("Documentos Relacionados", AddressOf AccionDocumentosRelacionados, ExpertisApp.GetIcon("document_view.ico"))
        GridTrabajos.AddSeparator()
        GridTrabajos.Actions.Add(cnABRIRACTIVO, AddressOf AccionAbrirActivo, ExpertisApp.GetIcon("xArticulos.ico"))
        GridTrabajos.Actions.Add(cnGenerarOT, AddressOf AccionAbrirLanzamiento, ExpertisApp.GetIcon("xArticulos.ico"))
        GridTrabajos.Actions.Add(cnConsultaOT, AddressOf AccionAbrirResumenOT, ExpertisApp.GetIcon("xArticulos.ico"))

    End Sub

    Protected Overridable Sub LoadGridPrevistos()
        GridMaterialPrev.Actions.Add(cnABRIRMATERIAL, AddressOf AccionAbrirMaterialDesdePrev, ExpertisApp.GetIcon("xArticulos.ico"))
        GridMaterialPrev.Actions.Add(cnIMPORTARESTRUCTURA, AddressOf AccionImportarEstructura, ExpertisApp.GetIcon("xEstructuras1.ico"))
        'GridMaterialPrev.Actions.Add("Abrir Máquina", AddressOf AccionAbrirMantenimientoActivo, ExpertisApp.GetIcon("xActivos.ico"))
        GridMODPrev.Actions.Add(cnABRIRCATEGORIAS, AddressOf AccionAbrirCategoriasDesdePrev, ExpertisApp.GetIcon("xCargo.ico"))
    End Sub

    Protected Overridable Sub LoadGridControl()
        GridMaterialControl.Actions.Add(cnABRIRMATERIAL, AddressOf AccionAbrirMaterialDesdeControl, ExpertisApp.GetIcon("xArticulos.ico"))
        GridMaterialControl.Actions.Add(cnABRIRALBARANCOMPRA, AddressOf AccionAbrirAlbaranCompraDesdeMaterialControl, ExpertisApp.GetIcon("xAlbaranCompra.ico"))
        GridMaterialControl.Actions.Add(cnABRIRFACTURACOMPRA, AddressOf AccionAbrirFacturaCompraDesdeMaterialControl, ExpertisApp.GetIcon("xFacturaCompra.ico"))

        GridMODControl.Actions.Add(cnABRIRCATEGORIAS, AddressOf AccionAbrirCategoriasDesdeControl, ExpertisApp.GetIcon("xCargo.ico"))

        GridGastosControl.Actions.Add(cnABRIRALBARANCOMPRA, AddressOf AccionAbrirAlbaranCompraDesdeGastosControl, ExpertisApp.GetIcon("xAlbaranCompra.ico"))
        GridGastosControl.Actions.Add(cnABRIRFACTURACOMPRA, AddressOf AccionAbrirFacturaCompraDesdeGastosControl, ExpertisApp.GetIcon("xFacturaCompra.ico"))

        GridVariosControl.Actions.Add(cnABRIRALBARANCOMPRA, AddressOf AccionAbrirAlbaranCompraDesdeVariosControl, ExpertisApp.GetIcon("xAlbaranCompra.ico"))
        GridVariosControl.Actions.Add(cnABRIRFACTURACOMPRA, AddressOf AccionAbrirFacturaCompraDesdeVariosControl, ExpertisApp.GetIcon("xFacturaCompra.ico"))
    End Sub

    Protected Overridable Sub LoadGridVencimientos()
        With GridVencimientos
            .Actions.Add(cnABRIRFACTURAVENTA, AddressOf AccionAbrirFacturaVenta, ExpertisApp.GetIcon("xFacturaVenta.ico"))
        End With
    End Sub

    Protected Overridable Sub LoadGridCertificacion()
        With GridCertificacion
            '.Actions.Add(cnIMPORTARCERTIFICACION, AddressOf AccionImportarCertificacion)
            '        .Actions.Add(cnRPTCER, AddressOf AccionImprimirCertificacion)
            '        .Actions.Add(cnRPTCERMED, AddressOf AccionImprimirCertificacionMed)
            '        .Actions.Add(cnRPTFACCER, AddressOf AccionImprimirFacturaCertificacion)
            '        .Actions.Add(cnRPTFACCERO, AddressOf AccionImprimirFacturaCertificacionOrg)
            '        .Actions.Add(cnRPTFACCERR, AddressOf AccionImprimirFacturaCertificacionRes)
            .Actions.Add(cnCOPIARCERTIFICACIONCLIENTE, AddressOf AccionCopiarCertificacionParaCliente)
            .Actions.Add(cnCOPIARCERTIFICACIONPRODUCCION, AddressOf AccionCopiarCertificacionParaProduccion)
        End With
    End Sub

#End Region

#Region " Load Enums "

    Protected Overridable Sub LoadEnums()
        LoadEnumsCabecera()
        LoadEnumsTrabajo()
        LoadEnumsPrevisto()
        LoadEnumsControl()
        LoadEnumsHitos()
        LoadEnumTareas()
        LoadEnumsProveedores()
    End Sub

    Protected Overridable Sub LoadEnumsCabecera()
        cbxEstado.DataSource = New EnumData("enumocEstado")
        cbxIDClase.DataSource = New EnumData("enumClaseObra")
        cbxTipoRetencion.DataSource = New EnumData("enumTipoRetencion")
        cboTipoRetencionImpuestos.DataSource = New EnumData("TipoRetencionImpuestos")
        EnumData.PopulateValueList("enumTipoRetencion", GridProveedores.Columns("TipoRetencion"))
        cbxTipoCertificacion.DataSource = New EnumData("enumTipoCertificacionCabecera")
    End Sub

    Protected Overridable Sub LoadEnumsTrabajo()
        cbxEstadoTrabajo.DataSource = New EnumData("enumotEstado")
        cbxTipoFacturacion.DataSource = New EnumData("enumotTipoFacturacion")
        cbxEstadoDistintoDE.DataSource = New EnumData("enumotEstado")
        cbxEstadoDistintoDE.Value = CInt(enumotEstado.otTerminado)
        EnumData.PopulateValueList("enumotEstado", GridTrabajos.Columns("Estado"))
        EnumData.PopulateValueList("enumotTipoFacturacion", GridTrabajos.Columns("TipoFacturacion"))
        EnumData.PopulateValueList("enumtcdiTipoCoste", GridTrabajos.Columns("TipoCosteDI"))
        EnumData.PopulateValueList("enumTipoLineaTrabajo", GridTrabajos.Columns("TipoLinea"))
        cbxTipoCoste.DataSource = New EnumData("enumtcdiTipoCoste")
        cbxTipoLinea.DataSource = New EnumData("enumTipoLineaTrabajo")
        cbxTipoPeriodoPeriodificacion.DataSource = New EnumData("enumcpPeriodo")
        EnumData.PopulateValueList("enumcpPeriodo", GridTrabajos.Columns("TipoPeriodo"))
    End Sub

    Protected Overridable Sub LoadEnumsPrevisto()
        EnumData.PopulateValueList("enumomEstado", GridMaterialPrev.Columns("Estado"))
        EnumData.PopulateValueList("enumomEstadoFactura", GridMaterialPrev.Columns("EstadoFactura"))
        EnumData.PopulateValueList("enumomTipoFacturacion", GridMaterialPrev.Columns("TipoFacturacion"))
        EnumData.PopulateValueList("enumSiNo", GridMaterialPrev.Columns("TipoIncremento"))

        EnumData.PopulateValueList("enumomodEstado", GridMODPrev.Columns("Estado"))
        EnumData.PopulateValueList("enumomodEstadoFactura", GridMODPrev.Columns("EstadoFactura"))
        EnumData.PopulateValueList("enumomodTipoFacturacion", GridMODPrev.Columns("TipoFacturacion"))
        EnumData.PopulateValueList("enumSiNo", GridMODPrev.Columns("TipoIncremento"))

        EnumData.PopulateValueList("enumocenEstado", GridCentrosPrev.Columns("Estado"))
        EnumData.PopulateValueList("enumocenEstadoFactura", GridCentrosPrev.Columns("EstadoFactura"))
        EnumData.PopulateValueList("enumSiNo", GridCentrosPrev.Columns("TipoIncremento"))

        EnumData.PopulateValueList("enumogEstadoFactura", GridGastosPrev.Columns("EstadoFactura"))
        EnumData.PopulateValueList("enumogTipoFacturacion", GridGastosPrev.Columns("TipoFacturacion"))

        EnumData.PopulateValueList("enumovEstadoFactura", GridVariosPrev.Columns("EstadoFactura"))

        EnumData.PopulateValueList("enumSiNo", GridMediciones.Columns("Certificar"))
    End Sub

    Protected Overridable Sub LoadEnumsControl()
        EnumData.PopulateValueList("enumomcTipoMaterial", GridMaterialControl.Columns("TipoMaterial"))
        EnumData.PopulateValueList("enumomcActualizado", GridMaterialControl.Columns("Actualizado"))
        EnumData.PopulateValueList("enumEstadoCertificacion", GridCertificacion.Columns("Estado"))
        EnumData.PopulateValueList("enumTipoCertificacion", GridCertificacion.Columns("TipoCertificacion"))
        EnumData.PopulateValueList("enumTipoCertificacion", GridCertificacionTrabajo.Columns("TipoCertificacion"))
        EnumData.PopulateValueList("enumTipoLineaTrabajo", GridCertificacionTrabajo.Columns("TipoLinea"))
    End Sub

    Protected Overridable Sub LoadEnumsHitos()
        EnumData.PopulateValueList("enumotfTipoFactura", GridVencimientos.Columns("TipoFactura"))
    End Sub

    Protected Overridable Sub LoadEnumTareas()
        EnumData.PopulateValueList("enumotaEstado", GridTareas.Columns("Estado"))
        EnumData.PopulateValueList("enumotaPrioridad", GridTareas.Columns("Prioridad"))
    End Sub

    Protected Overridable Sub LoadEnumsProveedores()
        cbxTipoPeriodo.DataSource = New EnumData("enumcpPeriodo")
        EnumData.PopulateValueList("TipoRetencionImpuestos", GridProveedores.Columns("Impuestos"))
        EnumData.PopulateValueList("enumcpPeriodo", GridProveedores.Columns("TipoPeriodo"))
    End Sub

#End Region

    Protected Overridable Sub LoadMonedasInternas()
        Dim MonedaA As MonedaInfo = ExpertisApp.ExecuteTask(Of Date, MonedaInfo)(AddressOf Moneda.MonedaA, cnMinDate)
        mintRedondeoA = MonedaA.NDecimalesImporte
    End Sub

    Protected Overridable Sub LoadFormParams()
        If Not IsNothing(Me.Params) Then
            Dim ht As Hashtable = Me.Params
            Dim intIDObra As Integer
            If ht.ContainsKey("IDObra") Then intIDObra = ht("IDObra")
            If ht.ContainsKey("VerTrabajo") Then
                blnVerTrabajo = ht("VerTrabajo")
                intTrabajoActual = ht("IDTrabajo")
            ElseIf Len(intIDObra) > 0 AndAlso intIDObra <> 0 Then
                Dim objFilterCriteria As New Filter
                objFilterCriteria.Clear()
                objFilterCriteria.Add("IDObra", FilterOperator.Equal, intIDObra)
                GotoRecord(DataProviderActions.GoFirst, objFilterCriteria, Me.CurrentData)
            End If
        End If
    End Sub

    Protected Overridable Sub Configure()
        rbtPorTrabajosObra.Checked = True
        rbtPrevObra.Checked = True
        rbtControlObra.Checked = True
        rbtHitosObra.Checked = True
        rbtMonedaA.Checked = True
        rbtTareasObra.Checked = True
        rbtOperariosObra.Checked = True
        rbtVerGrid.Checked = True
        rbtMinimizarTree.Checked = True
        chkVerUltimaCertificacion.Checked = True
        chkVerPorcentajes.Checked = True

        ControlesConstructoras()
        If blnVerTrabajo Then ControlesVerTrabajo()
    End Sub

    Protected Overridable Sub ControlesConstructoras()
        optCertificacionPorTrabajo.Checked = True

        TabPageMediciones.TabVisible = mblnGestionConstructoras
        TabPageControlMediciones.TabVisible = mblnGestionConstructoras
        'TabPageCobrosPagos.TabVisible = mblnGestionConstructoras
    End Sub

    Protected Overridable Sub ControlesVerTrabajo()
        TabObras.TabPages("Trabajos").Selected = True
        rbtVerFicha.Checked = True
        rbtMaximizarTree.Checked = True
    End Sub

    Protected Overridable Sub CamposNoEditables()
        txtPrevistoTrabajo.Enabled = False : txtPrevistoTrabajo.TabStop = False
        txtPrevistoVentaTrabajo.Enabled = False : txtPrevistoVentaTrabajo.TabStop = False
        txtRealTrabajo.Enabled = False : txtRealTrabajo.TabStop = False
        txtFacturadoTrabajo.Enabled = False : txtFacturadoTrabajo.TabStop = False
        txtNivel.Enabled = False : txtNivel.TabStop = False
        If Not Me.CurrentRow Is Nothing Then AdvTrabajoPresup.Enabled = Not (Length(Me.CurrentRow("IDPresup")) = 0)
        AdvTrabajoPresup.TabStop = AdvTrabajoPresup.Enabled
        txtQReal.Enabled = False : txtQReal.TabStop = False
        If Not ndTrabajos.Data Is Nothing Then AdvIDTipoObra.Enabled = ndTrabajos.Data.Rows.Count = 0

        txtPrevistoTrabajo.Enabled = False : txtPrevistoVentaTrabajo.Enabled = False : txtRealTrabajo.Enabled = False : txtFacturadoTrabajo.Enabled = False
        txtPrevistoTrabajoGrid.Enabled = False : txtPrevistoVentaTrabajoGrid.Enabled = False : txtRealTrabajoGrid.Enabled = False : txtFacturadoTrabajoGrid.Enabled = False
        txtTotalPrev.Enabled = False : txtTotalPrevVenta.Enabled = False : txtTotalReal.Enabled = False : txtTotalFacturado.Enabled = False
        txtTotalMedicion.Enabled = False
        txtTotalControl.Enabled = False
        txtTotalVtoA.Enabled = False : txtTotalA.Enabled = False
        txtImpPrevVentaABis.Enabled = False : txtTotalGastosGenerales.Enabled = False : txtTotalBeneficioIndustrial.Enabled = False
        txtTotalCoefBaja.Enabled = False : txtTotalIva.Enabled = False : txtTotal.Enabled = False
        txtTotalEstructuraPrev.Enabled = False : txtTotalEstructuraPrevVta.Enabled = False : txtTotalEstructuraReal.Enabled = False : txtTotalEstructuraFact.Enabled = False
        txtTotalCostePrev.Enabled = False : txtTotalCostePrevVta.Enabled = False : txtTotalCosteReal.Enabled = False : txtTotalCosteFact.Enabled = False

        txtTrabajoGrid.Enabled = False : txtDescTrabajoGrid.Enabled = False
        txtTrabajoCompleto.Enabled = False : txtDescTrabajoCompleto.Enabled = False
        txtTrabajoPrev.Enabled = False : txtDescTrabajoPrev.Enabled = False : txtQPrevTrabajo.Enabled = False
        txtTrabajoControl.Enabled = False : txtDescTrabajoControl.Enabled = False
        txtTrabajoHitos.Enabled = False : txtDescTrabajoHitos.Enabled = False
        txtTrabajoTareas.Enabled = False : txtDescTrabajoTareas.Enabled = False
        txtTrabajoOperarios.Enabled = False : txtDescTrabajoOperarios.Enabled = False

        chkPeriodificable_CheckedChanged(chkPeriodificable, New EventArgs)
    End Sub

    Protected Overridable Sub RefreshObra(Optional ByVal IDObra As Integer = -1)
        If mblnRefresh Then
            If IDObra = -1 Then IDObra = Me.CurrentRow("IDObra")
            Me.GotoRecord(DataProviderActions.GoFirst, New NumberFilterItem("IDObra", IDObra))
        End If
    End Sub

    Protected Overridable Sub CreateFormatStyle()
        Dim fStyle As New Janus.Windows.GridEX.GridEXFormatStyle
        fStyle.Key = "PeriodoRecalculadoFormatStyle"
        fStyle.BackColor = pnlPeriodosRecalculados.BackColor
        GridAvanceTrabajo.FormatStyles.Add(fStyle)
    End Sub

#End Region

#Region " Acciones ToolBar "

    Protected Overridable Sub CargarCalendario()
        Solmicro.Expertis.Engine.UI.ExpertisApp.OpenForm("CALOBRA", New FilterItem("IDObra", Me.CurrentRow("IDObra")))
    End Sub

    Protected Overridable Sub CargarCalendarioTareas()
        Dim HT As New Hashtable
        HT("IDObra") = Me.CurrentRow("IDObra")
        HT("NObra") = txtNObra.Text
        ExpertisApp.OpenForm("CALENTAREA", , HT)
    End Sub

    Protected Overridable Sub AccionAbrirPresupuesto()
        ExpertisApp.OpenForm("MGEPRE", New NumberFilterItem("IDPresup", Me.CurrentRow("IDPresup")), , Me)
    End Sub

#Region " Copia Obra "

    Protected Overridable Sub AccionCopiarObra()
        CopiarObra(enumClaseObra.FacturacionControl)
    End Sub

    Protected Overridable Sub AccionCopiarObraParaControl()
        CopiarObra(enumClaseObra.Control)
    End Sub

    Protected Overridable Sub AccionCopiarObraParaFacturacion()
        CopiarObra(enumClaseObra.Facturacion)
    End Sub

    Protected Overridable Sub CopiarObra(ByVal intClase As enumClaseObra)
        Dim frm As New FrmCopiaObra
        frm.VerContador = True
        frm.VerMediciones = mblnGestionConstructoras
        frm.ClaseObra = intClase

        If frm.ShowDialog = DialogResult.OK Then
            Me.Cursor = Cursors.WaitCursor

            Dim infoCopia As New dataCopiaObra(Me.CurrentRow("IDObra"))
            infoCopia.ConfiguracionCopia = frm.ConfiguracionCopia
            If Length(infoCopia.ConfiguracionCopia.IDContador) = 0 Then
                infoCopia.ConfiguracionCopia.IDContador = Me.CurrentRow("IDContador") & String.Empty
            End If
            If intClase = enumClaseObra.FacturacionControl Then
                infoCopia.ConfiguracionCopia.SinOrigen = True
            End If

            Dim r As ResultadoCopiaObra = ExpertisApp.ExecuteTask(Of dataCopiaObra, ResultadoCopiaObra)(AddressOf ObraCabecera.CopiarObra, infoCopia)

            Me.Cursor = Cursors.Default

            If r.IDObra <> -1 Then
                If ExpertisApp.GenerateMessage("Se ha generado el Proyecto '|'. ¿Desea abrirlo.?", MessageBoxButtons.YesNo, MessageBoxIcon.Information, r.NObra) = DialogResult.Yes Then
                    RefreshObra(r.IDObra)
                    TabObras_Click(TabObras, New System.EventArgs)
                End If
            End If
        End If
    End Sub

#End Region

    Protected Overridable Sub AccionCopiarTiposTrabajos()
        Dim HT As New Hashtable
        HT.Add("IDObra", Me.CurrentRow("IDObra"))
        HT.Add("NObra", Me.CurrentRow("NObra"))
        ExpertisApp.OpenForm("COPIATIPOTRABAJO", , HT, Me)
    End Sub

    Protected Overridable Sub AccionEstructuraObra()
        If Length(Me.CurrentRow("IDObra")) > 0 Then
            Dim frm As New frmEstructuraObra
            frm.AbrirEstructuraObra(Me.CurrentRow("IDObra"), Me.CurrentRow("NObra"), Me.CurrentRow("DescObra") & String.Empty)
        End If
    End Sub

    Protected Overridable Sub AccionRecalcularObra()
        If Length(Me.CurrentRow("IDObra")) > 0 Then
            If ExpertisApp.GenerateMessage("Se va a proceder al recálculo del Proyecto |. Este proceso puede tardar varios minutos. ¿Desea continuar.?", MessageBoxButtons.YesNo, MessageBoxIcon.Information, Me.CurrentRow("NObra")) = DialogResult.Yes Then
                Me.Cursor = Cursors.WaitCursor
                ExpertisApp.ExecuteTask(Of Integer)(AddressOf ObraCabecera.RecalcularObra, Me.CurrentRow("IDObra"))
                Me.Cursor = Cursors.Default
                ExpertisApp.GenerateMessage("Proceso finalizado correctamente.", MessageBoxButtons.OK, MessageBoxIcon.Information)

                RefreshObra()
            Else
                ExpertisApp.GenerateMessage("Proceso cancelado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

#Region " AccionAbrirDireccionesEnvio "

    Protected Overridable Sub AccionAbrirDireccionesEnvio()
        If AdvDireccionEnvio Is Nothing Then AdvDireccionEnvio = New AdvancedSearch
        AdvDireccionEnvio.EntityName = "ClienteDireccion"
        AdvDireccionEnvio.ViewName = "tbClienteDireccion"
        AdvDireccionEnvio.Open()
    End Sub

    Protected Overridable Sub BusquedaDireccion_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles AdvDireccionEnvio.SetPredefinedFilter
        If Length(Me.CurrentRow("IDCliente")) > 0 Then
            e.Filter.Add("IDCliente", FilterOperator.Equal, Me.CurrentRow("IDCliente"))
            e.Filter.Add("Envio", FilterOperator.Equal, True)
        Else
            e.Filter.Add(New NoRowsFilterItem)
        End If
    End Sub

    Protected Overridable Sub BusquedaDireccion_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles AdvDireccionEnvio.SelectionChanged
        Me.CurrentRow("IDDireccion") = AdvDireccionEnvio.SelectedRow.Rows(0)("IDDireccion")
        txtDireccion.Text = AdvDireccionEnvio.SelectedRow.Rows(0)("Direccion") & String.Empty
        txtCodPostal.Text = AdvDireccionEnvio.SelectedRow.Rows(0)("CodPostal") & String.Empty
        txtPoblacion.Text = AdvDireccionEnvio.SelectedRow.Rows(0)("Poblacion") & String.Empty
        txtProvincia.Text = AdvDireccionEnvio.SelectedRow.Rows(0)("Provincia") & String.Empty
    End Sub

#End Region

    Protected Overridable Sub CargarMsProject()
        Dim objProject As Object
        Try
            objProject = CreateObject("MSProject.Application")
        Catch ex As Exception
            ExpertisApp.GenerateMessage("No tiene instalado Microsoft Project.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        If Not IsNothing(ndTrabajos.Data) AndAlso ndTrabajos.Data.Rows.Count > 0 Then
            If ExpertisApp.GenerateMessage("No se agregarán aquellos trabajos que no tengan datos en Fecha Inicio y Fecha Fin. ¿Desea continuar?.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Me.Cursor = Cursors.WaitCursor

                Dim prj As Object = objProject.Projects.Add
                Dim oTask, oResource As Object

                'Insercion de Tareas
                For Each dr As DataRow In ndTrabajos.Data.Rows
                    If Length(dr("FechaInicio")) > 0 AndAlso Length(dr("FechaFin")) > 0 AndAlso dr("FechaInicio") <> cnMinDate AndAlso dr("FechaFin") <> cnMinDate Then
                        oTask = prj.Tasks.Add(CInt(dr("Secuencia")))
                        oTask.Name = dr("DescTrabajo")
                        If Length(dr("FechaInicio")) > 0 AndAlso IsDate(dr("FechaInicio")) Then oTask.Start = CDate(dr("FechaInicio"))
                        If Length(dr("FechaFin")) > 0 AndAlso IsDate(dr("FechaFin")) Then oTask.Finish = CDate(dr("FechaFin"))
                        oTask.Cost = CDbl(Nz(dr("ImpPrevTrabajoA"), 0))
                        oTask.Cost1 = CDbl(Nz(dr("ImpPrevMatA"), 0))
                        oTask.Cost2 = CDbl(Nz(dr("ImpPrevModA"), 0))

                        oTask = Nothing
                    End If
                Next

                'Inserción de Recursos
                Dim dt As DataTable = New ObraOperario().Filter(New FilterItem("IDObra", FilterOperator.Equal, Me.CurrentRow("IDObra")))
                If Not IsNothing(dt) AndAlso dt.Rows.Count > 0 Then
                    For Each dr As DataRow In dt.Rows
                        oResource = prj.Resources.Add(CStr(dr("IDOperario")))
                        oResource.Name = dr("DescOperario") & String.Empty
                        ' oresource.AppendNotes = "Horas Previstas 10"
                        oResource = Nothing
                    Next
                End If

                Dim strPath As String = ExpertisApp.Path & "\Proyecto" & txtNObra.Text
                'If length(Dir(strPath & ".mpp")) > 0 Then
                '    Kill(strPath & ".mpp")
                'End If
                prj.SaveAs(strPath)

                ExpertisApp.GenerateMessage("Proyecto '" & txtNObra.Text & "' generado correctamente.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                '            If MsgBox(9566, vbInformation + vbYesNo, strPath) = vbYes Then 'Contrato generado | correctamente.
                '                objProject.FileOpen
                '                objProject.Visible = True
                '            End If
                ''            objProject.Quit pjSave
                '
                ''            Shell "c:\Proyecto" & fwiIdObra.Value & ".mpp", vbMaximizedFocus
            End If
        Else
            ExpertisApp.GenerateMessage("No hay trabajos en este Proyecto.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        Me.Cursor = Cursors.Default
    End Sub

    Protected Overridable Sub AccionCertificacion()
        Dim Tipo As enumTipoCertificacion = enumTipoCertificacion.Cliente
        If blnTabTiposCertificacionVisible Then
            If TabTiposCertificacion.SelectedTab.Key = "Produccion" Then
                Tipo = enumTipoCertificacion.Produccion
            End If
        Else
            Dim dt As DataTable = CType(GridCertificacion.DataSource, DataTable).Copy
            Dim dv As DataView = dt.DefaultView
            dv.RowFilter = "TipoCertificacion=" & enumTipoCertificacion.ClienteProduccion
            If dv.Count > 0 Then
                Tipo = enumTipoCertificacion.ClienteProduccion
            Else
                Tipo = -1
            End If
        End If

        Dim frm As New frmAddCertificacion
        frm.AbrirAltaCertificacion(Me.CurrentRow("IDObra"), Tipo, Me, blnTabTiposCertificacionVisible AndAlso (TabTiposCertificacion.SelectedTab.Key = "Cliente" OrElse TabTiposCertificacion.SelectedTab.Key = "Produccion"))
        Me.RequeryData()
        FiltrarGridCertificaciones()
    End Sub

    Protected Overridable Sub AccionGenerarTrabajosPeriodificados()
        Dim HT As New Hashtable
        HT("IDObra") = Me.CurrentRow("IDObra")
        HT("NObra") = txtNObra.Text
        ExpertisApp.OpenForm("CITRABPERIODICOS", , HT)
    End Sub

    Protected Overridable Sub AccionGenerarHitosPeriodificados()
        Dim HT As New Hashtable
        HT("IDObra") = Me.CurrentRow("IDObra")
        HT("NObra") = txtNObra.Text
        ExpertisApp.OpenForm("CIGENHITOS", , HT)
    End Sub

    Protected Overridable Sub AccionIncluirTareas()
        ExpertisApp.GenerateMessage("Las Tareas sin fecha de Inicio establecida no se tendrán en cuenta en el proceso de generación.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Dim frm As New FrmNewTrabajoTarea
        frm.IDObra = Me.CurrentRow("IDObra")
        frm.FechaInicio = Me.CurrentRow("FechaInicio")
        If Length(Me.CurrentRow("FechaFin")) > 0 Then
            frm.FechaFin = Me.CurrentRow("FechaFin")
        End If
        If frm.ShowDialog = DialogResult.OK Then
            Me.Cursor = Cursors.WaitCursor

            Dim info As New TareaPredefinida.dataADDTareasPredefinidas(Me.CurrentRow("IDObra"), Me.CurrentRow("IDTipoObra"), frm.CodTrabajo, frm.CodTrabajo, frm.FechaInicio, Nz(frm.FechaFin, cnMinDate))
            ExpertisApp.ExecuteTask(Of TareaPredefinida.dataADDTareasPredefinidas)(AddressOf TareaPredefinida.AddTareasPredefinidas, info)

            Me.Cursor = Cursors.Default
            Me.RefreshObra()
        End If
    End Sub

    Protected Overridable Sub AccionGenerarCompra()
        Dim HT As New Hashtable
        HT("IDObra") = Me.CurrentRow("IDObra")
        HT("NObra") = txtNObra.Text
        ExpertisApp.OpenForm("MGECCO", , HT)
    End Sub

    Protected Overridable Sub AccionExpedicion()
        Dim HT As New Hashtable
        HT("IDObra") = Me.CurrentRow("IDObra")
        HT("NObra") = txtNObra.Text
        ExpertisApp.OpenForm("MEXPO", , HT)
    End Sub

    Protected Overridable Sub AccionFacturacion()
        Dim HT As New Hashtable
        HT("IDObra") = Me.CurrentRow("IDObra")
        HT("NObra") = txtNObra.Text
        ExpertisApp.OpenForm("FACTOBRAS", , HT)
    End Sub

    Protected Overridable Sub AccionAnaliticaPorObra()
        Dim frm As New frmAnalitica
        If drTrabajos("Estado") = enumotEstado.otTerminado Then
            frm.SoloLectura = True
        Else
            frm.SoloLectura = False
        End If
        frm.IDMoneda = Me.CurrentRow("IDMoneda")
        frm.Fecha = Me.CurrentRow("FechaInicio")
        frm.EntityName = Me.EntityName
        frm.NavigationFields = Me.NavigationFields
        frm.ViewName = "tbObraCabecera"
        frm.Grid.EntityName = "ObraAnalitica"
        frm.Grid.PrimaryDataFields = Me.NavigationFields
        frm.Grid.SecondaryDataFields = Me.NavigationFields
        frm.Grid.ViewName = "vFrmObraAnalitica"
        frm.IDOrigen = Me.CurrentRow("IDObra")
        frm.TxtOrigen.Text = Me.CurrentRow("NObra")
        frm.DescOrigen.Text = Me.CurrentRow("DescObra")
        frm.OrigenObra = True
        frm.FilterCriteria = New NumberFilterItem("IDObra", Me.CurrentRow("IDObra"))
        frm.LoadForm()
    End Sub

    Protected Overridable Sub mnuArbolTrabajos1_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles mnuArbolTrabajos1.Click
        pnlTrabajos.Visible = Not pnlTrabajos.Visible
        Splitter1.Visible = pnlTrabajos.Visible
    End Sub

#Region " Integración con SOLID "

    ''Private Sub AccionIncorporarEnObra()
    ''    ExpertisApp.ExecuteTask(Of String, Integer)(AddressOf Articulo.GenerarObraArticulo, Me.CurrentRow("IDArticulo"))
    ''End Sub
    Private mIDArticulo As String
    Protected Overridable Sub AccionIncorporarFicheroXMLSolid()
        Dim FldFileDiag As New OpenFileDialog
        If FldFileDiag.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim XmlDoc As New Xml.XmlDocument
            XmlDoc.Load(FldFileDiag.FileName)
            Dim DataSalida As DataFicheroSolid = CommonMembers.CrearArticulosEstructurasXML(XmlDoc)
            Dim DataEntrada As New Articulo.DataCrearArticulos(DataSalida.Articulos, DataSalida.ArticuloEstructura, DataSalida.Caracteristicas, _
                                                                DataSalida.ArticuloCaracteristicaValor, DataSalida.ArticuloDocumento)
            Dim log As LogProcess = ExpertisApp.ExecuteTask(Of Articulo.DataCrearArticulos, LogProcess)(AddressOf Articulo.CrearArticulosEstructuras, DataEntrada)
            ExpertisApp.GenerateMessage("Proceso Completado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            If Not log Is Nothing AndAlso Not log.CreatedElements Is Nothing AndAlso log.CreatedElements.Length > 0 Then
                mIDArticulo = DataSalida.IDArticuloRaiz
                If Length(mIDArticulo) = 0 Then Exit Sub
                Dim IDObra As Integer = ExpertisApp.ExecuteTask(Of String, Integer)(AddressOf Articulo.GenerarObraArticulo, mIDArticulo)
                If IDObra > 0 Then
                    ExpertisApp.OpenForm("MGEO", New NumberFilterItem("IDObra", IDObra))
                End If
            End If
        End If
    End Sub

#End Region

#End Region

#Region " Acciones Grid "

    Protected Overridable Sub AccionDesgloseTrabajo()
        Dim frm As New frmDesgloseImportesTrabajo

        Dim ImpAcumulado, ImpAcumuladoVenta As Double
        If GridTrabajos.Value("TipoLinea") = enumTipoLineaTrabajo.tltTrabajoConcepto Then
            ImpAcumulado = Nz(GridTrabajos.Value("ImpPrevQTrabajoA"), 0)
            ImpAcumuladoVenta = Nz(GridTrabajos.Value("ImpPrevQTrabajoVentaA"), 0)
        Else
            ImpAcumulado = Nz(GridTrabajos.Value("ImpAcumulado"), 0)
            ImpAcumuladoVenta = Nz(GridTrabajos.Value("ImpAcumuladoVenta"), 0)
        End If
        frm.AbrirDesgloseTrabajo(GridTrabajos.Value("IDTrabajo"), _
                                ImpAcumulado, _
                                 ImpAcumuladoVenta)
    End Sub

    Protected Overridable Sub AccionVerFicha()
        drTrabajos = GetdrTrabajos(GridTrabajos.GetValue("IDTrabajo"))
        GetDatosTrabajo(drTrabajos)
        rbtVerFicha.Checked = True
    End Sub

    Protected Overridable Sub AccionAbrirMaterialDesdePrev()
        AbrirMntoArticulo(GridMaterialPrev.Value("IDMaterial"))
    End Sub

    Protected Overridable Sub AccionAbrirMaterialDesdeControl()
        AbrirMntoArticulo(GridMaterialControl.Value("IDMaterial"))
    End Sub

    Protected Overridable Sub AccionAbrirAlbaranCompraDesdeMaterialControl()
        AbrirMntoAlbaranCompra(GridMaterialControl.Value("IDAlbaran"))
    End Sub

    Protected Overridable Sub AccionAbrirCategoriasDesdePrev()
        AbrirMntoCategoria(GridMODPrev.Value("IDCategoria"))
    End Sub

    Protected Overridable Sub AccionAbrirCategoriasDesdeControl()
        AbrirMntoCategoria(GridMODControl.Value("IDCategoria"))
    End Sub

    Protected Overridable Sub AccionAbrirAlbaranCompraDesdeGastosControl()
        AbrirMntoAlbaranCompra(GridGastosControl.Value("IDAlbaran"))
    End Sub

    Protected Overridable Sub AccionAbrirAlbaranCompraDesdeVariosControl()
        AbrirMntoAlbaranCompra(GridVariosControl.Value("IDAlbaran"))
    End Sub

    Protected Overridable Sub AccionAbrirFacturaCompraDesdeMaterialControl()
        AbrirMntoFacturaCompra(GridMaterialControl.Value("IDFactura"))
    End Sub

    Protected Overridable Sub AccionAbrirFacturaCompraDesdeGastosControl()
        AbrirMntoFacturaCompra(GridGastosControl.Value("IDFactura"))
    End Sub

    Protected Overridable Sub AccionAbrirFacturaCompraDesdeVariosControl()
        AbrirMntoFacturaCompra(GridVariosControl.Value("IDFactura"))
    End Sub

    Protected Overridable Sub AccionAbrirFacturaVenta()
        AbrirMntoFacturaVenta(Nz(GridVencimientos.Value("IDFactura"), 0))
    End Sub

    Protected Overridable Sub AccionImportarEstructura()
        With GridMaterialPrev
            If Length(.Value("IDLineaMaterialPadre")) = 0 Then
                If Length(.Value("IDMaterial")) > 0 AndAlso Length(.Value("IDAlmacen")) > 0 Then
                    Dim frm As New frmImpEstructura
                    frm.IDObra = .Value("IDObra")
                    frm.IDTrabajo = .Value("IDTrabajo")
                    frm.IDArticulo = .Value("IDMaterial")
                    frm.DescArticulo = .Value("DescMaterial")
                    frm.IDLineaMaterial = .Value("IDlineaMaterial")
                    frm.TipoFacturacion = .Value("TipoFacturacion")
                    frm.Expedible = .Value("Expedible")
                    frm.Facturable = .Value("Facturable")
                    frm.QPrevTrabajo = .Value("QPrevTrabajo")
                    frm.QUnidad = .Value("QUnidad")
                    frm.FechaInicioTrabajo = Nz(drTrabajos("FechaInicio"), cnMinDate)

                    frm.ShowDialog(Me)
                    Me.Requery.InvokeOnClick()
                End If
            End If
        End With
    End Sub

    'Protected Overridable Sub AccionAbrirMantenimientoActivo()
    '    If Len(GridMaterialPrev.Value("Lote")) > 0 Then
    '        AbrirMantenimientoActivo(GridMaterialPrev.Value("Lote"))
    '    End If
    'End Sub

    Protected Overridable Sub AccionNuevoTrabajo()
        NuevoTrabajo(GridTrabajos.Value("IDTrabajo"), GridTrabajos.Value("IDTipoTrabajo") & String.Empty, _
                     GridTrabajos.Value("IDSubTipoTrabajo") & String.Empty, _
                     GridTrabajos.Value("SubSubTipoTrabajo") & String.Empty)
    End Sub

    Protected Overridable Sub AccionVerAnaliticaTrabajo()
        Dim dv As New DataView(dtTrabajos)
        dv.RowFilter = "IDTrabajo=" & GridTrabajos.GetValue("IDTrabajo")
        If dv.Count > 0 Then drTrabajos = dv(0).Row
        AccionAnaliticaTrabajo()
    End Sub

    Protected Overridable Sub AccionNuevaTarea()
        AbrirMantenimientoTarea(, False, CurrentRow("IDObra"), CurrentRow("NObra"), GridTrabajos.Value("IDTrabajo"), GridTrabajos.Value("CodTrabajo") & String.Empty)
    End Sub

    Protected Overridable Sub AccionGenerarVencimientosTrabajo()
        AbrirFormVencimientosDesdeTrabajo(True)
    End Sub
    Protected Overridable Sub AccionAbrirActivo()
        If Length(GridTrabajos.Value("IDActivo")) > 0 Then
            AbrirMantenimientoActivo(GridTrabajos.Value("IDActivo"))
        End If
    End Sub
    Protected Overridable Sub AccionAbrirLanzamiento()
        If Length(GridTrabajos.Value("IDActivo")) > 0 Then
            AbrirPlanificacionActivo(GridTrabajos.Value("IDActivo"), GridTrabajos.Value("IDObra"), GridTrabajos.Value("IDTrabajo"), CurrentRow("IDCliente"), GridTrabajos.Value("Facturable"))
        End If
    End Sub
    Protected Overridable Sub AccionAbrirResumenOT()
        If Length(GridTrabajos.Value("IDActivo")) > 0 Then
            AbrirResumenOT(GridTrabajos.Value("IDActivo"), GridTrabajos.Value("IDObra"), GridTrabajos.Value("IDTrabajo"))
        End If
    End Sub

    'Protected Overridable Sub AccionImportarCertificacion()
    '    Dim FrmVariableNGI As New FrmImportarCertificacion

    '    With GridCertificacion
    '        FrmVariableNGI.ht.Add("IDObra", .Value("IDObra"))
    '        FrmVariableNGI.ht.Add("Certificacion", .Value("NCertificacion"))
    '        FrmVariableNGI.ht.Add("IDCertificacion", .Value("IDCertificacion"))
    '        '            FrmVariableNGI.dtc = GridCertificacionTrabajo.DataSource

    '    End With
    '    FrmVariableNGI.ShowDialog()
    '    If FrmVariableNGI.DialogResult = DialogResult.OK Then
    '        GridCertificacion_SelectionChanged(GridCertificacion, New EventArgs)
    '    End If
    'End Sub

    Protected Overridable Sub AccionCopiarCertificacionParaCliente()
        AccionCopiarCertificacionPara(enumTipoCertificacion.Cliente)
    End Sub

    Protected Overridable Sub AccionCopiarCertificacionParaProduccion()
        AccionCopiarCertificacionPara(enumTipoCertificacion.Produccion)
    End Sub

    Protected Overridable Sub AccionCopiarCertificacionPara(ByVal iTipo As enumTipoCertificacion)
        If ExpertisApp.GenerateMessage("Se copiará la Certificación seleccionada. ¿Desea continuar.?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim infoCopia As New ObraCertificacion.datosCopiaCertificacion(GridCertificacion.GetValue("IDCertificacion"), iTipo)
            Dim dt As DataTable = ExpertisApp.ExecuteTask(Of ObraCertificacion.datosCopiaCertificacion, DataTable)(AddressOf ObraCertificacion.CopiaCertificacion, infoCopia)
            Me.RetrieveData(DataProviderActions.Refresh)
            If Not IsNothing(dt) AndAlso dt.Rows.Count > 0 Then
                ExpertisApp.GenerateMessage("Copia Certificación realizada correctamente.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.BindEditEvents(dt)
                GridCertificacionTrabajo.DataSource = dt
                TabTrabajos_Click(TabTrabajos, New System.EventArgs)
            End If
        End If
    End Sub

#Region " Gestion Documental "

    Protected Overridable Sub AccionAltaDocumentos()
        Dim DtFinal As DataTable = dtTrabajos.Clone
        Dim DrGrid() As DataRow = dtTrabajos.Copy.Select("IDTrabajo = " & GridTrabajos.GetValue("IDTrabajo"))
        DtFinal.Rows.Add(DrGrid(0).ItemArray)
        Dim ClsGD As New ClsAltaDocumentosGD
        ClsGD.AltaDocumentos(ndTrabajos.EntityName, DtFinal)
    End Sub

    Protected Overridable Sub AccionVincularDocumentos()
        Dim DtFinal As DataTable = dtTrabajos.Clone
        Dim DrGrid() As DataRow = dtTrabajos.Copy.Select("IDTrabajo = " & GridTrabajos.GetValue("IDTrabajo"))
        DtFinal.Rows.Add(DrGrid(0).ItemArray)
        Dim ClsGD As New clsVinculaDocumentoGD
        ClsGD.VinculaDocumentos(ndTrabajos.EntityName, DtFinal)
    End Sub

    Protected Overridable Sub AccionDocumentosRelacionados()
        Dim DtFinal As DataTable = dtTrabajos.Clone
        Dim DrGrid() As DataRow = dtTrabajos.Copy.Select("IDTrabajo = " & GridTrabajos.GetValue("IDTrabajo"))
        DtFinal.Rows.Add(DrGrid(0).ItemArray)
        Dim ClsGD As New clsDocusRelacionadosGD
        ClsGD.DocumentosRelacionados(ndTrabajos.EntityName, DtFinal)
    End Sub

#End Region

#End Region

    Protected Overridable Sub MntoObras_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles MyBase.SetPredefinedFilter
        e.Filter.Add(New NumberFilterItem("TipoMnto", enumTipoObra.tpObra))
    End Sub

    Protected Overridable Sub GetTrabajos()
        dtTrabajos = ndTrabajos.Data
        If ndTrabajos.Data.Rows.Count = 0 Then
            Me.pnlFichaTrabajo.Enabled = False
            drTrabajos = Nothing
        Else
            Me.pnlFichaTrabajo.Enabled = True
            If blnVerTrabajo AndAlso intTrabajoActual > 0 Then
                drTrabajos = GetdrTrabajos(intTrabajoActual)
            Else
                Dim dv As New DataView(ndTrabajos.Data)
                dv.Sort = "Secuencia"
                If Length(cbxEstadoDistintoDE.Value) > 0 Then
                    dv.RowFilter = "Estado<>" & cbxEstadoDistintoDE.Value
                End If
                If dv.Count > 0 Then
                    drTrabajos = dv(0).Row
                Else
                    Me.pnlFichaTrabajo.Enabled = False
                    drTrabajos = Nothing
                End If
            End If
        End If
        BindingDetalleTrabajo()
    End Sub

    Protected Overridable Function GetdrTrabajos(ByVal IDTrabajo As Integer) As DataRow
        Dim dv As DataView = dtTrabajos.DefaultView
        dv.RowFilter = "IDTrabajo=" & IDTrabajo
        If dv.Count > 0 Then
            Return dv(0).Row
        Else
            Return Nothing
        End If
    End Function

    Protected Overridable Sub MntoObras_RecordStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.RecordStateChanged
        blnRecordStateChanged = True
    End Sub

    Protected Overridable Sub MntoObras_Navigating(ByVal sender As Object, ByVal e As Engine.UI.NavigatingEventArgs) Handles MyBase.Navigating
        Select Case e.Action
            Case DataProviderActions.GoFirst
                blnPintarTrabajos = IIf(blnRecordStateChanged, blnRefreshArbol, True)
            Case DataProviderActions.GoRecord, DataProviderActions.Refresh, DataProviderActions.GoLast, DataProviderActions.GoNext, DataProviderActions.GoPrevious
                blnPintarTrabajos = True
            Case Else
                blnPintarTrabajos = False
        End Select
        blnRecordStateChanged = False
    End Sub

    Protected Overridable Sub MntoObras_Navigated(ByVal sender As Object, ByVal e As Solmicro.Expertis.Engine.UI.NavigatedEventArgs) Handles MyBase.Navigated
        If Not Me.CurrentRow Is Nothing Then
            rbtMonedaA.Checked = True
            GetTrabajos()
            ActiveExecuteActions()
            EjercicioPredeterminado()
            blnPintarTrabajos = True
            'ArbolTrabajos()
            InicializarTabTipoCertificacion()
            TabObras_Click(TabObras, New System.EventArgs)
            ActiveDeleteObra()
            CamposNoEditables()
        End If
    End Sub

    Protected Overridable Sub ActiveDeleteObra()
        Me.Delete.Enabled = IIf(ndTrabajos.Data.Rows.Count = 0 And Me.Cancel.Enabled = InheritableBoolean.False, InheritableBoolean.True, InheritableBoolean.False)
    End Sub

    Protected Overridable Sub ActiveExecuteActions()
        Dim blnEnabledC As InheritableBoolean = InheritableBoolean.False
        Dim blnEnabledF As InheritableBoolean = InheritableBoolean.False
        Dim blnEnabledP As InheritableBoolean = InheritableBoolean.False

        If Length(Me.CurrentRow("IDObraPadre")) = 0 Then
            If cbxIDClase.Value = enumClaseObra.Control Then
                blnEnabledF = InheritableBoolean.True
            ElseIf cbxIDClase.Value = enumClaseObra.Facturacion Then
                blnEnabledC = InheritableBoolean.True
            End If
        End If
        If Length(Me.CurrentRow("IDPresup")) = 0 Then
            blnEnabledP = InheritableBoolean.False
        Else
            blnEnabledP = InheritableBoolean.True
        End If

        Me.ExecuteActions.Commands(cnCOPIAROBRACONTROL).Enabled = blnEnabledC
        Me.ExecuteActions.Commands(cnCOPIAROBRAFACTURACION).Enabled = blnEnabledF
        Me.ExecuteActions.Commands(cnABRIRPRESUPUESTO).Enabled = blnEnabledP

        Dim blnSinCliente As InheritableBoolean = IIf(Length(Me.CurrentRow("IDCliente")) = 0, InheritableBoolean.False, InheritableBoolean.True)
        Me.ExecuteActions.Commands(cnEXPEDICION).Enabled = blnSinCliente
        Me.ExecuteActions.Commands(cnFACTURACION).Enabled = blnSinCliente
    End Sub

    Protected Overridable Sub cbxIDClase_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxIDClase.ValueChanged
        ActiveExecuteActions()
    End Sub

    Protected Overridable Sub MntoObras_RecordAddingUpdating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.RecordAdding, MyBase.RecordUpdating
        GridTrabajos.EntityName = "" : GridMaterialPrev.EntityName = "" : GridMODPrev.EntityName = "" : GridCentrosPrev.EntityName = "" : GridGastosPrev.EntityName = "" : GridVariosPrev.EntityName = "" : GridMediciones.EntityName = "" : GridOperariosTrabajo.EntityName = "" : GridAvanceTrabajo.EntityName = ""
    End Sub

    Protected Overridable Sub MntoObras_Deleting(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.RecordDeleting
        GridTrabajos.EntityName = "" : GridMaterialPrev.EntityName = "" : GridMODPrev.EntityName = "" : GridCentrosPrev.EntityName = "" : GridGastosPrev.EntityName = "" : GridVariosPrev.EntityName = "" : GridMediciones.EntityName = "" : GridOperariosTrabajo.EntityName = "" : GridAvanceTrabajo.EntityName = ""
        blnRecordStateChanged = True
        blnRefreshArbol = True
    End Sub

    Protected Overridable Sub InicializeNeededData()
        GridTrabajos.EntityName = ndTrabajos.EntityName
        GridMaterialPrev.EntityName = ndMateriales.EntityName
        GridMODPrev.EntityName = ndMOD.EntityName
        GridCentrosPrev.EntityName = ndCentros.EntityName
        GridGastosPrev.EntityName = ndGastos.EntityName
        GridVariosPrev.EntityName = ndVarios.EntityName
        GridMediciones.EntityName = ndMediciones.EntityName
        GridOperariosTrabajo.EntityName = ndTrabajoOperario.EntityName
        GridAvanceTrabajo.EntityName = ndAvance.EntityName
    End Sub

    Protected Overridable Sub Added(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.RecordAdded
        TvwTrabajos.Nodes.Clear()
        drTrabajos = Nothing
        GetDatosTrabajo(drTrabajos)
        InicializeNeededData()

        TabObras_Click(TabObras, New System.EventArgs)
        blnRefreshArbol = False
    End Sub

    Protected Overridable Sub UpdatedDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.RecordUpdated, MyBase.RecordDeleted
        InicializeNeededData()
        RefreshObra()
        TabObras_Click(TabObras, New System.EventArgs)
        blnRefreshArbol = False

        'David Velasco 22/05/23
        'Creo un trabajo(si no hay ninguno) para todos los proyectos que se creen para que no haya errores al insertar Partes de Trabajo
        Dim dt As New DataTable
        Dim f As New Filter
        f.Add("IDObra", FilterOperator.Equal, CurrentRow("IDObra"))
        f.Add("CodTrabajo", FilterOperator.Equal, "PT1")
        dt = New BE.DataEngine().Filter("tbObraTrabajo", f)

        If dt.Rows.Count >= 1 Then
        Else
            Dim aux As New Business.ClasesTecozam.MetodosAuxiliares
            Dim sql As String
            Dim codt As String
            codt = "PT1"
            Dim IDTrabajo As String
            IDTrabajo = aux.devuelveAutonumeri
            sql = "Insert into tbObraTrabajo(IDTrabajo, IDObra, IDTipoObra, IDTipoTrabajo, CodTrabajo, DescTrabajo,Secuencia, Solape, Estado," & _
            "ImpPrevMatA,ImpPrevModA,ImpPrevCentrosA,ImpPrevGastosA,ImpPrevVariosA,ImpPrevMatB,ImpPrevModB,ImpPrevCentrosB,ImpPrevGastosB,ImpPrevVariosB,ImpPrevTrabajoA,ImpPrevTrabajoB,ImpRealMatA," & _
            "ImpRealModA,ImpRealCentrosA,ImpRealGastosA,ImpRealVariosA,ImpRealMatB,ImpRealModB,ImpRealCentrosB,ImpRealGastosB,ImpRealVariosB,ImpRealTrabajoA,ImpRealTrabajoB,DuracionPrev,EstadoFactura,AvanceCalculado,AvanceEstimado,ImpPrevMatVentaA,ImpPrevModVentaA,ImpPrevCentrosVentaA,ImpPrevGastosVentaA,ImpPrevVariosVentaA,ImpPrevMatVentaB,ImpPrevModVentaB,ImpPrevCentrosVentaB,ImpPrevGastosVentaB,ImpPrevVariosVentaB,MargenPrevTrabajo,ImpPrevTrabajoVentaA,ImpPrevTrabajoVentaB,MargenRealTrabajo," & _
            "Facturable,ImpFactGastosB,ImpFactVariosB,ImpFactTrabajoB,ImpFactVariosA,ImpFactTrabajoA,MargenRealMat,MargenRealMod,MargenRealCentros,MargenRealGastos,MargenRealVarios,TipoFacturacion,ImpFactMatB,ImpFactModB,ImpFactCentrosB,IDCentroGestion,IDArticulo,MargenPrevMat,MargenPrevMod,MargenPrevCentros,MargenPrevGastos,MargenPrevVarios,ImpFactMatA," & _
            "ImpFactModA,ImpFactCentrosA,ImpFactGastosA,CContable,FechaCreacionAudi,FechaModificacionAudi,UsuarioAudi,IDUdMedida,QPrev,QReal,QFact,ImpPrevQTrabajoA,ImpPrevQTrabajoB,ImpPrevQTrabajoVentaA,ImpPrevQTrabajoVentaB,ImpRealQTrabajoA,ImpRealQTrabajoB,ImpFactQTrabajoA,ImpFactQTrabajoB,NoAcumular,ImpPrevQMatA,ImpPrevQModA,ImpPrevQCentrosA,ImpPrevQGastosA,ImpPrevQVariosA,ImpPrevQMatVentaA,ImpPrevQModVentaA,ImpPrevQCentrosVentaA,ImpPrevQGastosVentaA,ImpPrevQVariosVentaA,ImpPrevQMatB,ImpPrevQModB,ImpPrevQCentrosB,ImpPrevQGastosB,ImpPrevQVariosB,ImpPrevQMatVentaB,ImpPrevQModVentaB," & _
            "ImpPrevQCentrosVentaB,ImpPrevQGastosVentaB,ImpPrevQVariosVentaB,QTotalCertificada,Nivel,ListaMaterial,IDOrigen,TipoFactAlquiler,TipoCosteDI,TipoLinea,FianzaCompensada,Traspasada,PlanificarRecursosPorTareas,ImpTrabajoVentaConceptoA,ImpQTrabajoConceptoA,ImpQTrabajoVentaConceptoA,Inversion,Periodificable)" & _
            "Values('" & IDTrabajo & "','" & CurrentRow("IDObra") & "','" & CurrentRow("IDTipoObra") & "','PT','" & codt & "', 'PARTES DE TRABAJO',10, 0, 0, " & _
            "0,0,0,0,0,0,0,0,0,0,0,0,0," & _
            "0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0," & _
            "1,0,0,0,0,0,0,0,0,0,0,3,0,0,0,'" & "008" & "','" & "PROY" & "',0,0,0,0,0,0," & _
            "0,0,0,7050000000, '" & DateTime.Now & "', '" & DateTime.Now & "', '" & ExpertisApp.UserName & "',00,1,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0," & _
            "0,0,0,0,0,1,'" & IDTrabajo & "',0,0,0,0,0,0,0,0,0,0,0)"
            aux.EjecutarSql(sql)
        End If
        Me.RequeryData()
    End Sub

    Protected Overridable Sub EjercicioPredeterminado()
        mstrEjercicioActual = ExpertisApp.ExecuteTask(Of Date, String)(AddressOf EjercicioContable.Predeterminado, Date.Today)
    End Sub

#Region " Tab TipoCertificacion "

    Protected Overridable Sub InicializarTabTipoCertificacion()
        CType(GridCertificacion.DataSource, DataTable).DefaultView.RowFilter = ""
        blnTabTiposCertificacionVisible = False
        If Not IsNothing(GridCertificacion.DataSource) AndAlso GridCertificacion.RowCount > 0 Then
            EsClienteProduccion()
        End If
        TabTiposCertificacion.Visible = blnTabTiposCertificacionVisible
    End Sub

    Protected Overridable Sub EsClienteProduccion()
        Dim dt As DataTable = CType(GridCertificacion.DataSource, DataTable).Copy
        Dim dv As DataView = dt.DefaultView
        dv.RowFilter = "TipoCertificacion=" & enumTipoCertificacion.ClienteProduccion
        blnTabTiposCertificacionVisible = dv.Count = 0
    End Sub

#End Region

    Protected Overridable Sub CalculoDesgloseEconomico()
        Dim blnInicializar As Boolean

        If Length(Me.CurrentRow("IDObra")) > 0 Then
            Dim dblPrevMAT, dblPrevMOD, dblPrevCEN, dblPrevGAS, dblPrevVAR, dblDirecto, dblIndirecto As Double
            Dim dblPrevVentaMAT, dblPrevVentaMOD, dblPrevVentaCEN, dblPrevVentaGAS, dblPrevVentaVAR, dblDirectoVenta, dblIndirectoVenta As Double
            Dim dblImporte As Double
            Dim dt As DataTable = New BE.DataEngine().Filter("VFrmMntoObrasDesgloseImporte", New FilterItem("IDObra", FilterOperator.Equal, Me.CurrentRow("IDObra")))
            If Not IsNothing(dt) AndAlso dt.Rows.Count > 0 Then
                For Each dr As DataRow In dt.Rows
                    'Importes Previstos
                    dblPrevMAT = dblPrevMAT + dr("ImpPrevQMatA")
                    dblPrevMOD = dblPrevMOD + dr("ImpPrevQModA")
                    dblPrevCEN = dblPrevCEN + dr("ImpPrevQCentrosA")
                    dblPrevGAS = dblPrevGAS + dr("ImpPrevQGastosA")
                    dblPrevVAR = dblPrevVAR + dr("ImpPrevQVariosA")
                    'Importes Venta
                    dblPrevVentaMAT = dblPrevVentaMAT + dr("ImpPrevQMatVentaA")
                    dblPrevVentaMOD = dblPrevVentaMOD + dr("ImpPrevQModVentaA")
                    dblPrevVentaCEN = dblPrevVentaCEN + dr("ImpPrevQCentroVentaA")
                    dblPrevVentaGAS = dblPrevVentaGAS + dr("ImpPrevQGastoVentaA")
                    dblPrevVentaVAR = dblPrevVentaVAR + dr("ImpPrevQVariosVentaA")
                    If dr("TipoCosteDI") = enumtcdiTipoCoste.tcdiDirecto Then
                        dblDirecto = dblDirecto + xRound(dr("ImpPrevQTrabajoA"), mintRedondeoA)
                        dblDirectoVenta = dblDirectoVenta + xRound(dr("ImpPrevQTrabajoVentaA"), mintRedondeoA)
                    Else
                        dblIndirecto = dblIndirecto + xRound(dr("ImpPrevQTrabajoA"), mintRedondeoA)
                        dblIndirectoVenta = dblIndirectoVenta + xRound(dr("ImpPrevQTrabajoVentaA"), mintRedondeoA)
                    End If
                Next
                'Importes Previstos
                txtImpPrevQMatA.Value = xRound(dblPrevMAT - Nz(dt.Rows(0)("TotalMaterialAlquiler"), 0), mintRedondeoA)
                txtImpPrevQModA.Value = xRound(dblPrevMOD, mintRedondeoA)
                txtImpPrevQCentrosA.Value = xRound(dblPrevCEN, mintRedondeoA)
                txtImpPrevQGastosA.Value = xRound(dblPrevGAS, mintRedondeoA)
                txtImpPrevQVariosA.Value = xRound(dblPrevVAR, mintRedondeoA)
                dblImporte = dblPrevMAT + dblPrevMOD + dblPrevCEN + dblPrevGAS + dblPrevVAR
                If txtImpPrevQTrabajoA.Value <> dblImporte Then txtImpPrevQTrabajoA.Value = dblImporte
                txtPrevDirecto.Value = dblDirecto
                txtPrevIndirecto.Value = dblIndirecto

                'Importes Venta
                txtImpPrevQMatVentaA.Value = xRound(dblPrevVentaMAT - Nz(dt.Rows(0)("TotalMaterialAlquilerPrev"), 0), mintRedondeoA)
                txtImpPrevQModVentaA.Value = xRound(dblPrevVentaMOD, mintRedondeoA)
                txtImpPrevQCentrosVentaA.Value = xRound(dblPrevVentaCEN, mintRedondeoA)
                txtImpPrevQGastosVentaA.Value = xRound(dblPrevVentaGAS, mintRedondeoA)
                txtImpPrevQVariosVentaA.Value = xRound(dblPrevVentaVAR, mintRedondeoA)
                dblImporte = dblPrevVentaMAT + dblPrevVentaMOD + dblPrevVentaCEN + dblPrevVentaGAS + dblPrevVentaVAR
                If txtImpPrevQTrabajoVentaA.Value <> dblImporte Then txtImpPrevQTrabajoVentaA.Value = dblImporte
                txtPrevVentaDirecto.Value = dblDirectoVenta
                txtPrevVentaIndirecto.Value = dblIndirectoVenta

                'Margenes Prev
                txtMargenPrevMat.Value = CalcularMargen(txtImpPrevQMatVentaA.Value, txtImpPrevQMatA.Value)
                txtMargenPrevMod.Value = CalcularMargen(txtImpPrevQModVentaA.Value, txtImpPrevQModA.Value)
                txtMargenPrevCentro.Value = CalcularMargen(txtImpPrevQCentrosVentaA.Value, txtImpPrevQCentrosA.Value)
                txtMargenPrevGastos.Value = CalcularMargen(txtImpPrevQGastosVentaA.Value, txtImpPrevQGastosA.Value)
                txtMargenPrevVarios.Value = CalcularMargen(txtImpPrevQVariosVentaA.Value, txtImpPrevQVariosA.Value)
                txtMargenTrabajoPrev.Value = CalcularMargen(txtImpPrevQTrabajoVentaA.Value, txtImpPrevQTrabajoA.Value)
                txtMargenPrev.Value = CalcularMargen(txtImpPrevVentaA.Value, txtImpPrevA.Value)

                'Importes Reales
                txtImpRealMatA.Value = xRound(Nz(dt.Rows(0)("ImpRealMatA"), 0), mintRedondeoA)
                txtImpRealModA.Value = xRound(Nz(dt.Rows(0)("ImpRealModA"), 0), mintRedondeoA)
                txtImpRealCentrosA.Value = xRound(Nz(dt.Rows(0)("ImpRealCentroA"), 0), mintRedondeoA)
                txtImpRealGastosA.Value = xRound(Nz(dt.Rows(0)("ImpRealGastoA"), 0), mintRedondeoA)
                txtImpRealVariosA.Value = xRound(Nz(dt.Rows(0)("ImpRealVariosA"), 0), mintRedondeoA)
                txtImpRealTrabajoA.Value = xRound(CDbl(Nz(dt.Rows(0)("ImpRealMatA"), 0)) + CDbl(Nz(dt.Rows(0)("ImpRealModA"), 0)) + CDbl(Nz(dt.Rows(0)("ImpRealCentroA"), 0)) + CDbl(Nz(dt.Rows(0)("ImpRealGastoA"), 0)) + CDbl(Nz(dt.Rows(0)("ImpRealVariosA"), 0)), mintRedondeoA)

                'Importes Facturados
                txtImpFactMatA.Value = xRound(Nz(dt.Rows(0)("ImpFactMatA"), 0), mintRedondeoA)
                txtImpFactModA.Value = xRound(Nz(dt.Rows(0)("ImpFactModA"), 0), mintRedondeoA)
                txtImpFactCentrosA.Value = xRound(Nz(dt.Rows(0)("ImpFactCentroA"), 0), mintRedondeoA)
                txtImpFactGastosA.Value = xRound(Nz(dt.Rows(0)("ImpFactGastoA"), 0), mintRedondeoA)
                txtImpFactVariosA.Value = xRound(Nz(dt.Rows(0)("ImpFactVariosA"), 0), mintRedondeoA)
                Dim dtVto As DataTable = New BE.DataEngine().Filter("vFrmMntoObrasTotalVencimientosFacturados", New FilterItem("IDObra", FilterOperator.Equal, Me.CurrentRow("IDObra")))
                If Not IsNothing(dtVto) AndAlso dtVto.Rows.Count > 0 Then
                    txtImpVencimientoA.Value = xRound(Nz(dtVto.Rows(0)("ImpVencimientoA"), 0), mintRedondeoA)
                Else
                    txtImpVencimientoA.Value = 0
                End If

                dblImporte = xRound(CDbl(txtImpFactMatA.Value) + CDbl(txtImpFactModA.Value) + CDbl(txtImpFactCentrosA.Value) + CDbl(txtImpFactGastosA.Value) + CDbl(txtImpFactVariosA.Value) + CDbl(txtImpVencimientoA.Value), mintRedondeoA)
                If txtImpFactTrabajoA.Value <> dblImporte Then txtImpFactTrabajoA.Value = dblImporte

                'Margenes Reales
                txtMargenRealMat.Value = CalcularMargen(txtImpFactMatA.Value, txtImpRealMatA.Value)
                txtMargenRealMod.Value = CalcularMargen(txtImpFactModA.Value, txtImpRealModA.Value)
                txtMargenRealCentros.Value = CalcularMargen(txtImpFactCentrosA.Value, txtImpRealCentrosA.Value)
                txtMargenRealGastos.Value = CalcularMargen(txtImpFactGastosA.Value, txtImpRealGastosA.Value)
                txtMargenRealVarios.Value = CalcularMargen(txtImpFactVariosA.Value, txtImpRealVariosA.Value)
                txtMargenRealTrabajo.Value = CalcularMargen(txtImpFactTrabajoA.Value, txtImpRealTrabajoA.Value)
                txtMargenReal.Value = CalcularMargen(txtImpFactA.Value, txtImpRealA.Value)
            Else
                blnInicializar = True
            End If
        Else
            blnInicializar = True
        End If
        If blnInicializar Then
            For Each c As Control In Me.FraImportes.Controls
                If c.GetType.FullName = "Solmicro.Expertis.Engine.UI.NumericTextBox" Then
                    CType(c, Solmicro.Expertis.Engine.UI.NumericTextBox).Value = 0
                End If
            Next
            txtMargenPrev.Value = 0 : txtMargenReal.Value = 0
        End If
        txtTotalGastosGenerales.Value = txtImpPrevVentaA.Value * txtGastosGenerales.Value / 100
        txtTotalBeneficioIndustrial.Value = txtImpPrevVentaA.Value * txtBeneficioIndustrial.Value / 100
        txtTotalCoefBaja.Value = -(txtImpPrevVentaA.Value * Math.Abs(txtCoefBaja.Value) / 100)

        Dim dblTotalSinIva As Double = txtImpPrevVentaA.Value + txtTotalGastosGenerales.Value + txtTotalBeneficioIndustrial.Value + txtTotalCoefBaja.Value
        Dim dblFactor As Double = Nz(Me.CurrentRow("Factor"), 0)
        If dblFactor <> 0 Then dblFactor = dblFactor / 100
        txtTotalIva.Value = dblTotalSinIva * dblFactor
        txtTotal.Value = dblTotalSinIva + txtTotalIva.Value
    End Sub

    Protected Overridable Sub TabObras_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabObras.Click
        If Me.RecordsState <> RecordsState.Initialize Then
            Select Case TabObras.SelectedTab.Key
                Case "Cabecera"
                    CalculoDesgloseEconomico()
                Case "Trabajos"
                    ArbolTrabajos()
                    TabTrabajos_Click(TabTrabajos, New System.EventArgs)
                Case "Estructura"
                    mstrListaObrasEstructura = String.Empty
                    PintarArbolObras(tvwEstructura, eTipoArbol.enumtipoEstructura)
                Case "Coste"
                    PintarArbolObras(tvwCostes, eTipoArbol.enumtipoCoste)
                    'Case "CobrosPagos"
                    '    FiltrarGridTrabajosTipo()
                    '    Planning("TabPlanCobros")
                    '    Planning("TabPlanPagos")
                Case "Seguimiento"
                    CalculoDesgloseEconomico()
            End Select
        End If
    End Sub

    Protected Overridable Sub chkSeguroCambio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSeguroCambio.CheckedChanged
        GridVencimientos.Columns("SeguroCambio").DefaultValue = chkSeguroCambio.Checked
        GridVencimientos.Refetch()
    End Sub

#Region " Pestaña Trabajos "

    Protected Overridable Sub CheckedAll()
        blnChecked = True
        Select Case TabTrabajos.SelectedTab.Key
            Case "Trabajos"
                Dim blnPorTrabajo As Boolean = (rbtPorNivelTrabajos.Checked Or rbtPorMultinivelTrabajos.Checked)
                rbtPorNivelPrev.Checked = rbtPorNivelTrabajos.Checked : rbtPrevObra.Checked = Not blnPorTrabajo
                rbtPorMultinivelPrev.Checked = rbtPorMultinivelTrabajos.Checked : rbtPrevObra.Checked = Not blnPorTrabajo
                rbtNivelControl.Checked = rbtPorNivelTrabajos.Checked : rbtControlObra.Checked = Not blnPorTrabajo
                rbtMultinivelControl.Checked = rbtPorMultinivelTrabajos.Checked : rbtControlObra.Checked = Not blnPorTrabajo
                rbtHitosTrabajo.Checked = blnPorTrabajo : rbtHitosObra.Checked = Not rbtHitosTrabajo.Checked
                rbtTareasTrabajo.Checked = blnPorTrabajo : rbtTareasObra.Checked = Not rbtTareasTrabajo.Checked
                rbtOperariosTrabajo.Checked = blnPorTrabajo : rbtOperariosObra.Checked = Not rbtOperariosTrabajo.Checked
            Case "Previstos"
                Dim blnPorTrabajo As Boolean = (rbtPorNivelPrev.Checked Or rbtPorMultinivelPrev.Checked)
                rbtPorNivelTrabajos.Checked = rbtPorNivelPrev.Checked : rbtPorTrabajosObra.Checked = Not blnPorTrabajo
                rbtPorMultinivelTrabajos.Checked = rbtPorMultinivelPrev.Checked : rbtPorTrabajosObra.Checked = Not blnPorTrabajo
                rbtNivelControl.Checked = rbtPorNivelPrev.Checked : rbtControlObra.Checked = Not blnPorTrabajo
                rbtMultinivelControl.Checked = rbtPorMultinivelPrev.Checked : rbtControlObra.Checked = Not blnPorTrabajo
                rbtHitosTrabajo.Checked = blnPorTrabajo : rbtHitosObra.Checked = Not rbtHitosTrabajo.Checked
                rbtTareasTrabajo.Checked = blnPorTrabajo : rbtTareasObra.Checked = Not rbtTareasTrabajo.Checked
                rbtOperariosTrabajo.Checked = blnPorTrabajo : rbtOperariosObra.Checked = Not rbtOperariosTrabajo.Checked
            Case "Control"
                Dim blnPorTrabajo As Boolean = (rbtNivelControl.Checked Or rbtMultinivelControl.Checked)
                rbtPorNivelTrabajos.Checked = blnPorTrabajo : rbtPorTrabajosObra.Checked = Not blnPorTrabajo
                rbtPorNivelPrev.Checked = rbtNivelControl.Checked : rbtPrevObra.Checked = Not blnPorTrabajo
                rbtPorMultinivelPrev.Checked = rbtMultinivelControl.Checked : rbtPrevObra.Checked = Not blnPorTrabajo
                rbtHitosTrabajo.Checked = blnPorTrabajo : rbtHitosObra.Checked = Not rbtHitosTrabajo.Checked
                rbtTareasTrabajo.Checked = blnPorTrabajo : rbtTareasObra.Checked = Not rbtTareasTrabajo.Checked
                rbtOperariosTrabajo.Checked = blnPorTrabajo : rbtOperariosObra.Checked = Not rbtOperariosTrabajo.Checked
            Case "Hitos"
                rbtPorNivelTrabajos.Checked = rbtHitosTrabajo.Checked : rbtPorTrabajosObra.Checked = Not rbtPorNivelTrabajos.Checked
                rbtPorNivelPrev.Checked = rbtHitosTrabajo.Checked : rbtPrevObra.Checked = Not rbtPorNivelPrev.Checked
                rbtNivelControl.Checked = rbtHitosTrabajo.Checked : rbtControlObra.Checked = Not rbtNivelControl.Checked
                rbtTareasTrabajo.Checked = rbtHitosTrabajo.Checked : rbtTareasObra.Checked = Not rbtTareasTrabajo.Checked
                rbtOperariosTrabajo.Checked = rbtHitosTrabajo.Checked : rbtOperariosObra.Checked = Not rbtOperariosTrabajo.Checked
            Case "Tareas"
                rbtPorNivelTrabajos.Checked = rbtTareasTrabajo.Checked : rbtPorTrabajosObra.Checked = Not rbtPorNivelTrabajos.Checked
                rbtPorNivelPrev.Checked = rbtTareasTrabajo.Checked : rbtPrevObra.Checked = Not rbtPorNivelPrev.Checked
                rbtNivelControl.Checked = rbtTareasTrabajo.Checked : rbtControlObra.Checked = Not rbtNivelControl.Checked
                rbtHitosTrabajo.Checked = rbtTareasTrabajo.Checked : rbtHitosObra.Checked = Not rbtHitosTrabajo.Checked
                rbtOperariosTrabajo.Checked = rbtTareasTrabajo.Checked : rbtOperariosObra.Checked = Not rbtOperariosTrabajo.Checked
            Case "Operarios"
                rbtPorNivelTrabajos.Checked = rbtOperariosTrabajo.Checked : rbtPorTrabajosObra.Checked = Not rbtPorNivelTrabajos.Checked
                rbtPorNivelPrev.Checked = rbtOperariosTrabajo.Checked : rbtPrevObra.Checked = Not rbtPorNivelPrev.Checked
                rbtNivelControl.Checked = rbtOperariosTrabajo.Checked : rbtControlObra.Checked = Not rbtNivelControl.Checked
                rbtHitosTrabajo.Checked = rbtOperariosTrabajo.Checked : rbtHitosObra.Checked = Not rbtHitosTrabajo.Checked
                rbtTareasTrabajo.Checked = rbtOperariosTrabajo.Checked : rbtTareasObra.Checked = Not rbtTareasTrabajo.Checked
        End Select
        blnChecked = False
    End Sub

    Protected Overridable Sub TrabajosObraChecked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtPorNivelTrabajos.CheckedChanged, rbtPorTrabajosObra.CheckedChanged, rbtPorMultinivelTrabajos.CheckedChanged
        If Not IsNothing(dtTrabajos) AndAlso dtTrabajos.Rows.Count > 0 Then
            If rbtVerGrid.Checked Then
                pnlVerTrabajosGrid.Visible = (rbtPorNivelTrabajos.Checked Or rbtPorMultinivelTrabajos.Checked)
                If Not IsNothing(Me.CurrentData) AndAlso Not blnChecked Then
                    BloquearGridTrabajo()
                    CheckedAll()
                    TabTrabajos_Click(TabTrabajos, New System.EventArgs)
                End If
            End If
        End If
    End Sub

    Protected Overridable Sub AccionAnaliticaTrabajo()
        If Me.RecordsState = RecordsState.Saved Then
            If Length(drTrabajos("IDArticulo")) Then
                Dim frm As New frmAnalitica
                If drTrabajos("Estado") = enumotEstado.otTerminado Then
                    frm.SoloLectura = True
                Else
                    frm.SoloLectura = False
                End If
                frm.IDMoneda = Me.CurrentRow("IDMoneda")
                frm.Fecha = Me.CurrentRow("FechaInicio")
                frm.EntityName = "ObraTrabajo"
                frm.NavigationFields = "IDTrabajo"
                frm.ViewName = "tbObraTrabajo"
                frm.Grid.EntityName = "ObraTrabajoAnalitica"
                frm.Grid.PrimaryDataFields = "IDTrabajo"
                frm.Grid.SecondaryDataFields = "IDTrabajo"
                frm.Grid.ViewName = "vFrmObraTrabajoAnalitica"
                frm.IDOrigen = drTrabajos("IDTrabajo")
                frm.TxtOrigen.Text = drTrabajos("CodTrabajo")
                frm.DescOrigen.Text = drTrabajos("DescTrabajo")
                frm.OrigenObra = False

                frm.FilterCriteria = New NumberFilterItem("IDTrabajo", drTrabajos("IDTrabajo"))
                frm.LoadForm()
            End If
        Else
            ExpertisApp.GenerateMessage("Línea pendiente de actualizar.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

#Region " Grid Trabajo "

    Protected Overridable Function GeneraCodTrabajo(Optional ByVal blnPorNivel As Boolean = False) As String
        Dim dvTrabajos As New DataView(ndTrabajos.Data.Copy)
        Dim strRowFilter As String = dvTrabajos.RowFilter
        If Not dvTrabajos Is Nothing Then
            Dim i As Integer = 1
            Dim strCodTrabajoAux As String = drTrabajos("CodTrabajo")
            Dim strCodTrabajo As String = strCodTrabajoAux & "." & dvTrabajos.Count + i

            Dim f As New Filter
            If rbtPorNivelTrabajos.Checked OrElse blnPorNivel Then
                If blnPorNivel Then
                    f.Add(New NumberFilterItem("IDTrabajoPadre", drTrabajos("IDTrabajo")))
                Else
                    f.Add(New StringFilterItem("CodTrabajoPadre", strCodTrabajoAux))
                End If
                strCodTrabajo = strCodTrabajoAux
            Else
                f.Add(New IsNullFilterItem("IDTrabajoPadre", True))
            End If

            dvTrabajos.RowFilter = f.Compose(New AdoFilterComposer)
            If dvTrabajos.Count <> 0 Then
                Dim blnNotExist As Boolean
                i = dvTrabajos.Count
                Do
                    i = i + 1
                    f.Clear()
                    f.Add(New StringFilterItem("CodTrabajo", strCodTrabajoAux & "." & i))
                    dvTrabajos.RowFilter = f.Compose(New AdoFilterComposer)
                    If dvTrabajos.Count = 0 Then
                        blnNotExist = True
                    End If
                Loop Until blnNotExist
            End If
            strCodTrabajo = strCodTrabajo & "." & i
            dvTrabajos.RowFilter = strRowFilter

            Return strCodTrabajo
        End If
        Return String.Empty
    End Function

    Protected Overridable Sub GridTrabajos_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridTrabajos.GotFocus
        With GridTrabajos
            .Columns("TipoLinea").DefaultValue = CInt(enumTipoLineaTrabajo.tltTrabajo)
            .Columns("IDTipoObra").DefaultValue = Me.CurrentRow("IDTipoObra")
            .Columns("IDTipoTrabajo").DefaultValue = System.DBNull.Value
            .Columns("IDSubTipoTrabajo").DefaultValue = System.DBNull.Value
            .Columns("CodTrabajo").DefaultValue = System.DBNull.Value
            .Columns("DescTrabajo").DefaultValue = System.DBNull.Value
            .Columns("CodTrabajoPadre").DefaultValue = System.DBNull.Value
            .Columns("IDTrabajoPadre").DefaultValue = System.DBNull.Value
            If rbtPorNivelTrabajos.Checked AndAlso Not drTrabajos Is Nothing Then
                If Length(drTrabajos("IDTipoTrabajo")) > 0 Then .Columns("IDTipoTrabajo").DefaultValue = drTrabajos("IDTipoTrabajo")
                If Length(drTrabajos("IDSubTipoTrabajo")) > 0 Then .Columns("IDSubTipoTrabajo").DefaultValue = drTrabajos("IDSubTipoTrabajo")
                If Length(drTrabajos("CodTrabajo")) > 0 Then
                    .Columns("CodTrabajo").DefaultValue = GeneraCodTrabajo()
                    .Columns("CodTrabajoPadre").DefaultValue = drTrabajos("CodTrabajo")
                End If
                If Length(drTrabajos("DescTrabajo")) > 0 Then .Columns("DescTrabajo").DefaultValue = drTrabajos("DescTrabajo")
                If Length(drTrabajos("IDTrabajo")) > 0 Then .Columns("IDTrabajoPadre").DefaultValue = drTrabajos("IDTrabajo")
                .Columns("Nivel").DefaultValue = Nz(drTrabajos("Nivel"), 0) + 1
            End If
            .Columns("Estado").DefaultValue = CInt(enumotEstado.otPendiente)

            .Columns("Facturable").DefaultValue = Length(Me.CurrentRow("IDCliente")) > 0
            If mblnGestionConstructoras Then
                .Columns("TipoFacturacion").DefaultValue = CInt(enumotTipoFacturacion.otfPorUdsObra)
            Else
                .Columns("TipoFacturacion").DefaultValue = CInt(enumotTipoFacturacion.otfPorVencimientos)
            End If

            .Columns("NumeroPedido").DefaultValue = Me.CurrentRow("NumeroPedido")
            .Columns("QPrev").DefaultValue = 1
            .Columns("NoAcumular").DefaultValue = blnNoAcumular
            .Columns("IDUDMedida").DefaultValue = mstrIDUDMedida
            .Columns("IDObra").DefaultValue = Me.CurrentRow("IDObra")
            .Columns("IDCentroGestion").DefaultValue = Nz(Me.CurrentRow("IDCentroGestion"), mstrIDCGestion)
        End With
    End Sub

    Protected Overridable Sub GridTrabajos_UpdatingRecord(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GridTrabajos.UpdatingRecord
        With GridTrabajos
            If .RowCount > 0 Then
                If Length(.Value("CodTrabajo")) = 0 Then
                    e.Cancel = True
                    ExpertisApp.GenerateMessage("El Trabajo es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If
        End With
    End Sub

    Protected Overridable Sub GridTrabajos_UpdatingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles GridTrabajos.UpdatingCell
        With GridTrabajos
            Select Case e.Column.Key
                Case "CodTrabajo"
                    If Length(e.Value) > 0 Then
                        .Value("IDContador") = System.DBNull.Value
                        Dim dvTrabajos As New DataView(CType(GridTrabajos.DataSource, DataView).Table.Copy)
                        Dim f As New Filter
                        f.Add(New StringFilterItem("CodTrabajo", e.Value))
                        If rbtPorNivelTrabajos.Checked Then
                            f.Add(New NumberFilterItem("IDTrabajoPadre", drTrabajos("IDTrabajo")))
                        Else
                            f.Add(New IsNullFilterItem("IDTrabajoPadre", True))
                        End If
                        dvTrabajos.RowFilter = f.Compose(New AdoFilterComposer)
                        If dvTrabajos.Count <> 0 Then
                            e.Cancel = True
                            ExpertisApp.GenerateMessage("Este Trabajo ya existe a ese nivel.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        End If
                    End If
                Case "NoAcumular"
                    If .Row <> -1 Then
                        If e.Value Then
                            If ExpertisApp.GenerateMessage("Si marca esta opción, el Importe Unitario será editable pero no irá acumulando los importes que vaya insertando en las diferentes Conceptos. ", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then
                                e.Cancel = True
                            End If
                        ElseIf ExpertisApp.GenerateMessage("Al insertar la línea se recalculará el Importe Unitario sumando los totales de los diferentes conceptos.", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then
                            e.Cancel = True
                        End If
                    End If
            End Select
        End With
    End Sub

    Protected Overridable Sub GridTrabajos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridTrabajos.Click
        With GridTrabajos
            If Length(.GetValue("IDTrabajo")) > 0 Then
                mSeleccionarNodoTrabajoDesdeGrid = True
                SeleccionarNodoTrabajo(.Value("IDTrabajo"))
                mSeleccionarNodoTrabajoDesdeGrid = False
            End If
            Dim hit As GridArea = .HitTest()
            If hit = GridArea.Cell Or hit = GridArea.NewRowCell Then
                Dim c As GridEXColumn = .ColumnFromPoint()
                If Not IsNothing(c) Then
                    Select Case c.Key
                        Case "Texto"
                            Dim frm As New FormularioTexto
                            frm.Texto = .Value("Texto") & String.Empty
                            frm.ShowDialog()
                            If .Value("Texto") & String.Empty <> frm.Texto Then
                                .SetValue("Texto", frm.Texto)
                            End If
                        Case "Analitica"
                            AccionVerAnaliticaTrabajo()
                    End Select
                End If
            End If
        End With
    End Sub

    Protected Overridable Sub GridTrabajos_EditingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles GridTrabajos.EditingCell
        With GridTrabajos
            Dim blnEnabled As Boolean = .Value("TipoLinea") = enumTipoLineaTrabajo.tltCapitulo Or .Value("TipoLinea") = enumTipoLineaTrabajo.tltPorcentajeConcepto
            Select Case e.Column.Key
                Case "Facturable"

                    If Length(Me.CurrentRow("IDCliente")) = 0 Then
                        e.Cancel = True
                    ElseIf .Value("TipoLinea") = enumTipoLineaTrabajo.tltTrabajoConcepto AndAlso Not ValidarTipoFacturacionTrabajoConcepto(.Value("IDTrabajoPadre")) Then
                        e.Cancel = True
                    End If

                Case "Incremento"
                    e.Cancel = (.Value("TipoLinea") <> .Value("TipoLinea") <> enumTipoLineaTrabajo.tltPorcentajeConcepto)
                Case "TipoFacturacion"
                    e.Cancel = blnEnabled
                    If blnEnabled AndAlso Length(.Value("IDTrabajo")) > 0 Then
                        Dim dt As DataTable = GridVencimientos.DataSource
                        Dim dv As DataView = dt.DefaultView
                        dv.RowFilter = "IDTrabajo= " & .Value("IDTrabajo")
                        If dv.Count > 0 Then
                            e.Cancel = True
                        Else
                            .Columns("TipoFacturacion").EditType = Janus.Windows.GridEX.EditType.TextBox
                            .Columns("TipoFacturacion").EditType = Janus.Windows.GridEX.EditType.DropDownList
                        End If
                    ElseIf .Row = -1 Then
                        .Columns("TipoFacturacion").EditType = Janus.Windows.GridEX.EditType.TextBox
                        .Columns("TipoFacturacion").EditType = Janus.Windows.GridEX.EditType.DropDownList
                    End If
                Case "TipoCosteDI"
                    .Columns("TipoCosteDI").EditType = Janus.Windows.GridEX.EditType.DropDownList
                Case "ImpPrevTrabajoA", "MargenPrevTrabajo", "ImpPrevTrabajoVentaA"
                    If Not .Value("NoAcumular") Or .Value("TipoLinea") = enumTipoLineaTrabajo.tltCapitulo Then
                        e.Cancel = True
                    Else
                        .Columns(e.Column.Key).EditType = Janus.Windows.GridEX.EditType.TextBox
                    End If
                Case "NoAcumular"
                    e.Cancel = .Value("TipoLinea") = enumTipoLineaTrabajo.tltCapitulo
                Case "Estado"
                    e.Cancel = True
                Case "CodTrabajoPresup"
                    If Length(Me.CurrentRow("IDPresup")) = 0 Or blnEnabled Then
                        e.Cancel = True
                        .Columns("CodTrabajoPresup").ButtonStyle = ButtonStyle.NoButton
                    Else
                        .Columns("CodTrabajoPresup").ButtonStyle = ButtonStyle.Image
                    End If
                Case "Periodo", "TipoPeriodo", "AplicarSobreUltimo", "PorcIncrDecrPerido"
                    e.Cancel = Not .Value("Periodificable")
            End Select
        End With
    End Sub

    Protected Overridable Sub GridTrabajos_AdvSearchSetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.GridAdvSearchFilterEventArgs) Handles GridTrabajos.AdvSearchSetPredefinedFilter
        With GridTrabajos
            Select Case e.Key
                Case "CodTrabajoPresup"
                    e.Filter.Add("IDPresup", FilterOperator.Equal, Me.CurrentRow("IDPresup"), FilterType.Numeric)
                Case "CodTrabajoPadre"
                    e.Filter.Add("IDObra", FilterOperator.Equal, Me.CurrentRow("IDObra"), FilterType.Numeric)
                    If Length(.Value("IDTrabajo")) > 0 Then e.Filter.Add("IDTrabajo", FilterOperator.NotEqual, .Value("IDTrabajo"), FilterType.Numeric)
                Case "IDTipoTrabajo"
                    e.Filter.Add("IdTipoObra", FilterOperator.Equal, AdvIDTipoObra.Text, FilterType.String)
                Case "IDSubTipoTrabajo"
                    e.Filter.Add("IdTipoObra", FilterOperator.Equal, AdvIDTipoObra.Text, FilterType.String)
                    e.Filter.Add("IDTipoTrabajo", FilterOperator.Equal, GridTrabajos.Value("IDTipoTrabajo") & String.Empty, FilterType.String)
                Case "SubSubTipoTrabajo"
                    e.Filter.Add("IdTipoObra", FilterOperator.Equal, AdvIDTipoObra.Text, FilterType.String)
                    e.Filter.Add("IDTipoTrabajo", FilterOperator.Equal, GridTrabajos.Value("IDTipoTrabajo") & String.Empty, FilterType.String)
                    e.Filter.Add("IDSubTipoTrabajo", FilterOperator.Equal, GridTrabajos.Value("IDSubTipoTrabajo") & String.Empty, FilterType.String)
                Case "CCCompra", "CCVenta"
                    e.Filter.Add("IDEjercicio", FilterOperator.Equal, mstrEjercicioActual, FilterType.String)
            End Select
        End With
    End Sub

    Protected Overridable Sub GridTrabajos_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles GridTrabajos.FormattingRow
        With GridTrabajos
            If e.Row.RowType = RowType.Record Then
                If Not drTrabajos Is Nothing AndAlso drTrabajos("TipoLinea") = enumTipoLineaTrabajo.tltTrabajo AndAlso mblnAnalitica Then
                    .Columns("Analitica").Visible = True
                Else
                    .Columns("Analitica").Visible = False
                End If
                If e.Row.Cells("TipoLinea").Value = enumTipoLineaTrabajo.tltCapitulo OrElse _
                  e.Row.Cells("TipoLinea").Value = enumTipoLineaTrabajo.tltPorcentajeConcepto Then
                    'Los trabajos que sean de tipo Capitulo o Porcentaje sólo mostrarán algunos de los valores
                    'del registro. El resto se ocultan. 
                    'Para ello haremos: e.Row.Cells(dc.ColumnName).Text = String.Empty
                    If e.Row.Cells("Estado").Value = enumotEstado.otTerminado Then
                        If e.Row.Cells("TipoLinea").Value = enumTipoLineaTrabajo.tltCapitulo Then
                            e.Row.RowStyle = .FormatStyles("CapituloTerminadoFormatStyle")
                        Else
                            e.Row.RowStyle = .FormatStyles("IncrementoTerminadoFormatStyle")
                        End If
                    ElseIf e.Row.Cells("TipoLinea").Value = enumTipoLineaTrabajo.tltCapitulo Then
                        e.Row.RowStyle = .FormatStyles("CapituloFormatStyle")
                    ElseIf e.Row.Cells("TipoLinea").Value = enumTipoLineaTrabajo.tltPorcentajeConcepto Then
                        e.Row.RowStyle = .FormatStyles("IncrementoFormatStyle")
                    End If

                    If e.Row.Cells("TipoLinea").Value = enumTipoLineaTrabajo.tltTrabajoConcepto Then
                        e.Row.RowStyle = .FormatStyles("ConceptoFormatStyle")
                    End If

                    For Each dc As DataColumn In dtTrabajos.Columns
                        If dc.ColumnName <> "Secuencia" And dc.ColumnName <> "IDTipoTrabajo" And _
                           dc.ColumnName <> "IDSubtipoTrabajo" And dc.ColumnName <> "SubSubTipoTrabajo" And _
                           dc.ColumnName <> "CodTrabajo" And dc.ColumnName <> "DescTrabajo" And _
                           dc.ColumnName <> "TipoLinea" And dc.ColumnName <> "ImpAcumulado" And _
                           dc.ColumnName <> "ImpAcumuladoVenta" And dc.ColumnName <> "Incremento" Then
                            If e.Row.Table.Columns.Contains(dc.ColumnName) Then
                                e.Row.Cells(dc.ColumnName).Text = String.Empty
                            End If
                        ElseIf dc.ColumnName = "Incremento" Then
                            If e.Row.Cells("TipoLinea").Value = enumTipoLineaTrabajo.tltCapitulo Or Nz(e.Row.Cells(dc.ColumnName).Value, 0) = 0 Then
                                e.Row.Cells(dc.ColumnName).Text = String.Empty
                            End If
                        End If
                    Next
                Else
                    If e.Row.Cells("Estado").Value = enumotEstado.otTerminado Then
                        e.Row.RowStyle = .FormatStyles("EstadoTerminadoFormatStyle")
                    End If
                    e.Row.Cells("ImpAcumulado").FormatStyle = .FormatStyles("ImpAcumuladoFormatStyle")
                    e.Row.Cells("ImpAcumuladoVenta").FormatStyle = .FormatStyles("ImpAcumuladoFormatStyle")
                    e.Row.Cells("Incremento").Text = String.Empty
                End If
            End If
        End With
    End Sub

    Protected Overridable Sub GridTrabajos_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridTrabajos.RecordUpdated
        TotalTrabajos()

        If TypeOf GridTrabajos.DataSource Is DataView Then
            dtTrabajos = CType(GridTrabajos.DataSource, DataView).Table
        Else
            dtTrabajos = CType(GridTrabajos.DataSource, DataTable)
        End If

        If rbtPorNivelTrabajos.Checked Then GridTrabajos_GotFocus(GridTrabajos, New EventArgs)
    End Sub

    Protected Overridable Sub GridTrabajos_RecordAdded_Deleted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridTrabajos.RecordAdded, GridTrabajos.RecordsDeleted
        GridTrabajos_RecordUpdated(GridTrabajos, New EventArgs)
        ActiveDeleteObra()
    End Sub

    Protected Overridable Sub GridTrabajos_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridTrabajos.MouseUp
        If e.Button = MouseButtons.Right Then
            If Not IsNothing(GridTrabajos) AndAlso GridTrabajos.RowCount > 0 Then
                If Length(GridTrabajos.Value("IDACTIVO")) > 0 Then
                    GridTrabajos.UiCommandManager1.Commands(cnGenerarOT).Visible = InheritableBoolean.True
                Else
                    GridTrabajos.UiCommandManager1.Commands(cnGenerarOT).Visible = InheritableBoolean.False
                End If
            End If
        End If
    End Sub
    Protected Overridable Sub TotalTrabajos()
        If Not rbtPorNivelTrabajos.Checked Then
            With GridTrabajos
                Dim Fil As New Janus.Windows.GridEX.GridEXFilterCondition(.Columns("TipoLinea"), ConditionOperator.Equal, 0)
                txtPrevistoTrabajoGrid.Value = xRound(.GetTotal(.Columns("ImpPrevQTrabajoA"), Janus.Windows.GridEX.AggregateFunction.Sum, Fil), mintRedondeoA)
                txtPrevistoVentaTrabajoGrid.Value = xRound(.GetTotal(.Columns("ImpPrevQTrabajoVentaA"), Janus.Windows.GridEX.AggregateFunction.Sum, Fil), mintRedondeoA)
                txtRealTrabajoGrid.Value = xRound(.GetTotal(.Columns("ImpRealTrabajoA"), Janus.Windows.GridEX.AggregateFunction.Sum), mintRedondeoA)
                txtFacturadoTrabajoGrid.Value = xRound(.GetTotal(.Columns("ImpFactTrabajoA"), Janus.Windows.GridEX.AggregateFunction.Sum), mintRedondeoA)
            End With
        ElseIf Not IsNothing(drTrabajos) Then
            txtPrevistoTrabajoGrid.Value = drTrabajos("ImpAcumulado")
            txtPrevistoVentaTrabajoGrid.Value = drTrabajos("ImpAcumuladoVenta")
        Else
            txtPrevistoTrabajoGrid.Value = 0 : txtPrevistoVentaTrabajoGrid.Text = 0
        End If
    End Sub

#End Region

    Protected Overridable Sub cbxEstadoDistintoDE_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxEstadoDistintoDE.ValueChanged
        If Me.RecordsState <> RecordsState.Initialize Then
            RefreshArbolTrabajos()
            If TabTrabajos.SelectedTab.Key = "Trabajos" Then FiltrarGridTrabajos()
        End If
    End Sub

    Protected Overridable Sub chkVerPorcentajes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkVerPorcentajes.CheckedChanged
        If Me.RecordsState <> RecordsState.Initialize Then
            RefreshArbolTrabajos()
            If TabTrabajos.SelectedTab.Key = "Trabajos" Then FiltrarGridTrabajos()
        End If
    End Sub

#Region " Arbol Trabajos "

    Protected Overridable Sub SeleccionarNodoTrabajo(ByVal IDTrabajo As Integer)
        For Each Nd As TreeNode In Me.TvwTrabajos.Nodes
            If CType(Nd.Tag, TagTrabajo).IDTrabajo = IDTrabajo Then
                Me.TvwTrabajos.SelectedNode = Nd
                Exit For
            ElseIf Nd.Nodes.Count > 0 Then
                If GetNode(Nd, IDTrabajo) Then Exit For
            End If
        Next
    End Sub

    Protected Overridable Function GetNode(ByVal NdGet As TreeNode, ByVal IDTrabajo As Integer) As Boolean
        GetNode = False
        For Each Nd As TreeNode In NdGet.Nodes
            If CType(Nd.Tag, TagTrabajo).IDTrabajo = IDTrabajo Then
                Me.TvwTrabajos.SelectedNode = Nd
                Return True
            ElseIf Nd.Nodes.Count > 0 Then
                GetNode(Nd, IDTrabajo)
            End If
        Next
    End Function

    Protected Overridable Sub rbtMaximizarTree_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtMaximizarTree.CheckedChanged
        TvwTrabajos.ExpandAll()
    End Sub

    Protected Overridable Sub rbtMinimizarTree_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtMinimizarTree.CheckedChanged
        TvwTrabajos.CollapseAll()
    End Sub

    Protected Overridable Sub RefreshArbolTrabajos()
        blnPintarTrabajos = True
        ArbolTrabajos()
    End Sub

    Protected Overridable Sub ArbolTrabajos()
        If blnPintarTrabajos Then
            Dim f As New Filter
            Dim dv As New DataView(dtTrabajos)
            If Not chkVerPorcentajes.Checked Then
                f.Add(New NumberFilterItem("TipoLinea", FilterOperator.NotEqual, enumTipoLineaTrabajo.tltPorcentajeConcepto))
            End If
            If Length(cbxEstadoDistintoDE.Value) > 0 Then
                f.Add("Estado", FilterOperator.NotEqual, cbxEstadoDistintoDE.Value)
            End If

            If f.Count > 0 Then dv.RowFilter = f.Compose(New AdoFilterComposer)

            dv.Sort = "Secuencia"
            If Not IsNothing(TvwTrabajos) Then
                TvwTrabajos.Nodes.Clear()
                TvwTrabajos.Visible = False
            End If
            PintarTrabajos(TvwTrabajos, dv)
            blnPintarTrabajos = False
            TvwTrabajos.Visible = True
            If blnVerTrabajo Then
                GetDatosTrabajo(drTrabajos)
                blnVerTrabajo = False
            ElseIf dv.Count = 0 Then
                GetDatosTrabajo(Nothing)
            Else
                GetDatosTrabajo(dv(0).Row)
            End If
            'ArbolCobrosyPagos()
        Else
            drTrabajos = GetdrTrabajos(intTrabajoActual)
            GetDatosTrabajo(drTrabajos)
        End If
        SeleccionarNodoTrabajo(intTrabajoActual)
    End Sub

    Protected Overridable Sub PintarTrabajos(ByVal tvwTreeViewObj As TreeView, ByVal dvTrabajos As DataView, _
                               Optional ByVal oNode As TreeNode = Nothing)

        If Not dvTrabajos Is Nothing AndAlso dvTrabajos.Count > 0 Then
            If Not tvwTreeViewObj.Enabled Then tvwTreeViewObj.Enabled = True
            tvwTreeViewObj.ImageList = ImageList1
            For Each drvTrabajo As DataRowView In dvTrabajos
                If IsDBNull(drvTrabajo.Row("IDTrabajoPadre")) Then
                    PintarNodoTrabajo(tvwTreeViewObj, drvTrabajo.Row, dvTrabajos.Table, oNode)
                End If
            Next
        End If
        If rbtMaximizarTree.Checked OrElse TabObras.SelectedTab.Key = "Estructura" OrElse TabObras.SelectedTab.Key = "Coste" Then
            tvwTreeViewObj.ExpandAll()
        End If
        If Not blnVerTrabajo Then
            tvwTreeViewObj.SelectedNode = tvwTreeViewObj.TopNode
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Protected Overridable Sub PintarNodoTrabajo(ByVal tvwTreeViewObj As TreeView, ByVal drTrabajo As DataRow, _
                                  ByVal dtTrabajos As DataTable, _
                                  Optional ByVal oNode As TreeNode = Nothing)

        Dim strText As String = drTrabajo("CodTrabajo") & String.Empty & " -> " & drTrabajo("DescTrabajo") & String.Empty

        If oNode Is Nothing Then
            oNode = tvwTreeViewObj.Nodes.Add(strText)
        Else
            oNode = oNode.Nodes.Add(strText)
        End If
        oNode.Tag = New TagTrabajo(drTrabajo("IDObra"), drTrabajo("IDTrabajo"))
        'If length(drTrabajo("IDTrabajoPadre")) > 0 Then oNode.ForeColor = Color.DarkBlue
        If Length(drTrabajo("TipoLinea")) = 0 Then drTrabajo("TipoLinea") = enumTipoLineaTrabajo.tltTrabajo

        If drTrabajo("TipoLinea") = enumTipoLineaTrabajo.tltTrabajo Then
            If Nz(drTrabajo("ImpPrevQTrabajoA"), 0) = 0 Then
                oNode.ImageIndex = 0
            Else
                oNode.ImageIndex = 3
            End If
        ElseIf drTrabajo("TipoLinea") = enumTipoLineaTrabajo.tltTrabajoConcepto Then
            oNode.ImageIndex = 0
        ElseIf drTrabajo("TipoLinea") = enumTipoLineaTrabajo.tltCapitulo Then
            oNode.ImageIndex = 8
        ElseIf drTrabajo("TipoLinea") = enumTipoLineaTrabajo.tltPorcentajeConcepto Then
            oNode.ImageIndex = 5
        End If
        oNode.SelectedImageIndex = 7
        oNode.Expand()

        If Length(drTrabajo("IDTrabajo")) > 0 AndAlso tvwTreeViewObj.Name <> TvwCobrosPagos.Name Then
            'pintar sus subtrabajos
            Dim dv As DataView = dtTrabajos.DefaultView
            Dim f As New Filter
            If Not chkVerPorcentajes.Checked Then
                f.Add(New NumberFilterItem("TipoLinea", FilterOperator.NotEqual, enumTipoLineaTrabajo.tltPorcentajeConcepto))
            End If
            If Length(cbxEstadoDistintoDE.Value) > 0 Then
                f.Add("Estado", FilterOperator.NotEqual, cbxEstadoDistintoDE.Value)
            End If
            f.Add("IDTrabajoPadre", FilterOperator.Equal, drTrabajo("IDTrabajo"))
            dv.RowFilter = f.Compose(New AdoFilterComposer)

            dv.Sort = "Secuencia"
            For Each drv As DataRowView In dv
                PintarNodoTrabajo(tvwTreeViewObj, drv.Row, dtTrabajos, oNode)
            Next
        End If
        oNode = Nothing
    End Sub

    Protected Overridable Sub TvwTrabajos_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TvwTrabajos.AfterSelect
        e.Node.EnsureVisible()
        If blnVerTrabajo Then
            TabTrabajos_Click(TabTrabajos, New EventArgs)
        Else
            If TypeOf e.Node.Tag Is TagTrabajo Then
                drTrabajos = GetdrTrabajos(CType(e.Node.Tag, TagTrabajo).IDTrabajo)
                GetDatosTrabajo(drTrabajos)
                If Not mSeleccionarNodoTrabajoDesdeGrid Then TabTrabajos_Click(TabTrabajos, New EventArgs)
            End If
        End If
        intTrabajoActual = 0
        If Not drTrabajos Is Nothing Then
            intTrabajoActual = drTrabajos("IDTrabajo")
        End If
    End Sub

    Protected Overridable Sub TvwTrabajos_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TvwTrabajos.MouseDown
        If e.Button = MouseButtons.Right AndAlso Me.cbxEstado.Value <> enumocEstado.ocTerminado Then
            If Length(AdvIDTipoObra.Value) <> 0 Then
                Dim n As TreeNode = TvwTrabajos.GetNodeAt(e.X, e.Y)
                Dim PORCENTAJES As InheritableBoolean = InheritableBoolean.False
                Dim ADDCONCEPTOS As InheritableBoolean = InheritableBoolean.False
                Dim ADDOFICIOS As InheritableBoolean = InheritableBoolean.False
                Dim AVANCE As InheritableBoolean = InheritableBoolean.False
                Dim VTOS As InheritableBoolean = InheritableBoolean.False
                Dim TRABAJOPERIODIFICABLE As InheritableBoolean = InheritableBoolean.False
                If Not IsNothing(n) Then
                    TvwTrabajos.SelectedNode = n
                    drTrabajos = GetdrTrabajos(CType(n.Tag, TagTrabajo).IDTrabajo)
                    If Not drTrabajos Is Nothing Then
                        If Length(drTrabajos("IDTrabajo")) = 0 Then
                            PORCENTAJES = InheritableBoolean.False
                        Else
                            VTOS = InheritableBoolean.True
                        End If
                        If drTrabajos("TipoLinea") = enumTipoLineaTrabajo.tltTrabajo Or drTrabajos("TipoLinea") = enumTipoLineaTrabajo.tltTrabajoConcepto Then
                            AVANCE = InheritableBoolean.True
                            If TabTrabajos.TabPages("Previstos").Selected Then
                                Select Case TabPrevistos.SelectedTab.Key
                                    Case "MaterialesPrev", "ModPrev", "CentrosPrev", "GastosPrev", "VariosPrev", "Mediciones"
                                        ADDCONCEPTOS = InheritableBoolean.True
                                End Select
                            ElseIf TabTrabajos.TabPages("Oficios").Selected Then
                                ADDOFICIOS = InheritableBoolean.True
                            End If
                        End If
                        If drTrabajos("TipoLinea") = enumTipoLineaTrabajo.tltPorcentajeConcepto Then
                            PORCENTAJES = InheritableBoolean.True
                        End If
                        If drTrabajos("Periodificable") Then
                            TRABAJOPERIODIFICABLE = InheritableBoolean.True
                        End If
                        'No dejaremos generar avances si el trabajo no se ha guardado previamente
                        Dim Where As String = New NumberFilterItem("IDTrabajo", drTrabajos("IDTrabajo")).Compose(New AdoFilterComposer)
                        Dim IDTrabajo() As DataRow = ndTrabajos.Data.Select(Where)
                        If Not IDTrabajo Is Nothing AndAlso IDTrabajo.Length = 1 Then
                            If IDTrabajo(0).RowState = DataRowState.Added Then
                                AVANCE = InheritableBoolean.False
                                VTOS = InheritableBoolean.False
                            End If
                        End If
                    End If
                Else
                    drTrabajos = Nothing
                End If

                If Not IsNothing(n) And PORCENTAJES = InheritableBoolean.False Then
                    MnuGuion.Visible = InheritableBoolean.True
                Else
                    MnuGuion.Visible = InheritableBoolean.False
                End If
                If Not IsNothing(n) Then
                    MnuGuion1.Visible = InheritableBoolean.True
                Else
                    MnuGuion1.Visible = InheritableBoolean.False
                End If
                MnuGuion5.Visible = MnuGuion.Visible
                MnuNuevoTrabajo.Visible = Not PORCENTAJES

                If IsNothing(n) And MnuNuevoTrabajo.Visible Then
                    MnuNuevoTrabajoIncremento.Visible = InheritableBoolean.True
                Else
                    MnuNuevoTrabajoIncremento.Visible = InheritableBoolean.False
                End If
                MnuDeleteIncremento.Visible = PORCENTAJES

                If Me.RecordsState <> RecordsState.Modified Then
                    MnuDeleteIncremento.Enabled = InheritableBoolean.True
                    MnuDeleteTrabajo.Enabled = InheritableBoolean.True
                Else
                    MnuDeleteIncremento.Enabled = InheritableBoolean.False
                    MnuDeleteTrabajo.Enabled = InheritableBoolean.False
                End If

                MnuDeleteTrabajo.Visible = MnuGuion.Visible
                mnuNuevaTarea.Visible = MnuGuion.Visible
                MnuGeneraVtos.Visible = VTOS ' MnuGuion.Visible
                MnuVerFichaTrabajo.Visible = MnuGuion1.Visible
                If PORCENTAJES = InheritableBoolean.True Then
                    MnuVerFichaTrabajo.Text = "Ver ficha incremento"
                Else
                    MnuVerFichaTrabajo.Text = "Ver ficha trabajo"
                End If

                MnuDesgloseTrabajo.Visible = MnuGuion.Visible
                MnuTareasPred.Visible = MnuGuion.Visible
                If Not IsNothing(n) And mblnAnalitica And PORCENTAJES = InheritableBoolean.False Then
                    MnuAnalitica.Visible = InheritableBoolean.True
                Else
                    MnuAnalitica.Visible = InheritableBoolean.False
                End If
                MnuGuion2.Visible = MnuAnalitica.Visible

                MnuADDIncremento.Visible = MnuGuion1.Visible
                MnuADDIncremento.Enabled = MnuDeleteIncremento.Enabled

                If MnuADDIncremento.Visible And PORCENTAJES = InheritableBoolean.False Then
                    MnuGuion3.Visible = InheritableBoolean.True
                Else
                    MnuGuion3.Visible = InheritableBoolean.False
                End If

                If ADDCONCEPTOS = InheritableBoolean.True Then
                    MnuNuevoConcepto.Visible = ADDCONCEPTOS
                    MnuNuevoConcepto.Text = "Nuevo Concepto " & TabPrevistos.SelectedTab.Text
                End If

                If ADDOFICIOS = InheritableBoolean.True Then
                    MnuNuevoConcepto.Visible = ADDOFICIOS
                    MnuNuevoConcepto.Text = "Nuevo " & TabTrabajos.TabPages("Oficios").Text
                End If
                If ADDOFICIOS = InheritableBoolean.False And ADDCONCEPTOS = InheritableBoolean.False Then
                    MnuNuevoConcepto.Visible = InheritableBoolean.False
                End If
                MnuGuion4.Visible = MnuNuevoConcepto.Visible

                MnuGuion6.Visible = MnuGuion1.Visible
                mnuGenerarCompras.Visible = MnuGuion1.Visible
                mnuExpedir.Visible = MnuGuion1.Visible
                mnuFacturacion.Visible = MnuGuion1.Visible
                MnuGuion7.Visible = MnuGuion1.Visible
                mnuPlanificador.Visible = MnuGuion1.Visible

                Dim blnSinCliente As InheritableBoolean = IIf(Length(Me.CurrentRow("IDCliente")) = 0, InheritableBoolean.False, InheritableBoolean.True)
                MnuGeneraVtos.Enabled = blnSinCliente

                MnuPeriodificaciones.Visible = VTOS

                MnuGenerarTrabajosPeriodificados.Visible = TRABAJOPERIODIFICABLE

                mnuExpedir.Enabled = blnSinCliente
                mnuFacturacion.Enabled = blnSinCliente
                If AVANCE = InheritableBoolean.True And MnuGuion1.Visible = InheritableBoolean.True Then
                    mnuAvanceTrabajo.Visible = InheritableBoolean.True
                Else
                    mnuAvanceTrabajo.Visible = InheritableBoolean.False
                End If
                MenuObras.Show()
            End If
        End If
    End Sub

#Region " Acciones Arbol Trabajos "

    Protected Overridable Sub NuevoTrabajo(ByVal intIDTrabajo As Integer, ByVal strIDTipoTrabajo As String, _
                             ByVal strIDSubTipoTrabajo As String, ByVal strIDSubSubTipoTrabajo As String, _
                             Optional ByVal blnIncremento As Boolean = False, Optional ByVal FechaInicio As Date = cnMinDate, _
                             Optional ByVal FechaFin As Date = cnMinDate)

        Dim Context As New BusinessData
        Context("Facturable") = Length(Me.CurrentRow("IDCliente")) > 0
        Context("FechaIniCab") = Me.CurrentRow("FechaInicio")
        Context("FechaFinCab") = Me.CurrentRow("FechaFin")
        FiltrarGridTrabajos()
        Dim dv As DataView
        If TypeOf GridTrabajos.DataSource Is DataView Then
            dv = GridTrabajos.DataSource
        Else
            dv = CType(GridTrabajos.DataSource, DataTable).DefaultView
        End If

        Dim dtTrabajosContext As New DataTable
        dtTrabajosContext.Columns.Add("CodTrabajo", GetType(String))
        dtTrabajosContext.Columns.Add("IDTrabajoPadre", GetType(Integer))

        Dim strFiltro As String = String.Empty
        If intIDTrabajo > 0 Then
            Context("PorNivel") = True
            Context("CodTrabajo") = GeneraCodTrabajo(True)
            Context("Filtrar") = True
            Context("IDTrabajoPadre") = intIDTrabajo
            Context("CodTrabajoPadre") = drTrabajos("CodTrabajo")
            Context("QPrevPadre") = drTrabajos("QPrev")
            strFiltro = "IDTrabajoPadre=" & intIDTrabajo

            Context("Facturable") = ValidarTipoFacturacionTrabajoConcepto(intIDTrabajo)
        End If

        Dim dvT As New DataView(dv.Table.Copy)
        dvT.RowFilter = strFiltro
        For Each drv As DataRowView In dvT
            Dim drContext As DataRow = dtTrabajosContext.NewRow
            drContext("CodTrabajo") = drv("CodTrabajo")
            drContext("IDTrabajoPadre") = drv("IDTrabajoPadre")
            dtTrabajosContext.Rows.Add(drContext.ItemArray)
        Next

        Context("dtTrabajos") = dtTrabajosContext
        Context("ViewName") = ndTrabajos.ViewName

        Dim dr As DataRow
        If blnIncremento Then
            Context("GestionConstructoras") = mblnGestionConstructoras
            Dim frm As New frmAddTrabajosIncremento
            dr = frm.AbrirAltaTrabajos(CurrentRow("IDObra"), CurrentRow("IDTipoObra"), mstrIDUDMedida, _
                                       txtNumeroPedido.Text, strIDTipoTrabajo, _
                                       strIDSubTipoTrabajo, strIDSubSubTipoTrabajo, intIDTrabajo, _
                                       blnNoAcumular, AdvIDCliente.Text, Context, Me)
        Else
            Dim frm As New FrmAddTrabajos
            frm.chkFacturable.Enabled = Length(Me.CurrentRow("IDCliente")) > 0
            dr = frm.AbrirAltaTrabajos(CurrentRow("IDObra"), CurrentRow("IDTipoObra"), mstrIDUDMedida, _
                                       txtNumeroPedido.Text, strIDTipoTrabajo, _
                                       strIDSubTipoTrabajo, strIDSubSubTipoTrabajo, intIDTrabajo, _
                                       blnNoAcumular, mblnGestionConstructoras, Context, Me.AdvIDMoneda.Text, Me, Context("Facturable"), FechaInicio, FechaFin)
        End If

        strIDTipoTrabajo = String.Empty
        strIDSubTipoTrabajo = String.Empty
        intIDTrabajo = 0

        If Not IsNothing(dr) Then
            dr("Secuencia") = (ndTrabajos.Data.Rows.Count + 1) * 10
            ndTrabajos.Data.Rows.Add(dr.ItemArray)
            Me.RecordsState = RecordsState.Modified
            dtTrabajos = ndTrabajos.Data
            Me.pnlFichaTrabajo.Enabled = True
            RefreshArbolTrabajos()
            FiltrarGridTrabajos()
            TotalTrabajos()
            blnPintarTrabajos = True
        End If
    End Sub

    Protected Overridable Sub MnuNuevoTrabajo_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles MnuNuevoTrabajo.Click
        If IsNothing(drTrabajos) Then
            NuevoTrabajo(0, String.Empty, String.Empty, String.Empty)
        ElseIf Length(drTrabajos("IDTrabajo")) > 0 Then
            NuevoTrabajo(drTrabajos("IDTrabajo"), drTrabajos("IDTipoTrabajo") & String.Empty, _
                         drTrabajos("IDSubTipoTrabajo") & String.Empty, drTrabajos("SubSubTipoTrabajo") & String.Empty)
        End If
        ActiveDeleteObra()
    End Sub

    Protected Overridable Sub MnuNuevoTrabajoIncremento_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles MnuNuevoTrabajoIncremento.Click
        If IsNothing(drTrabajos) Then
            NuevoTrabajo(0, String.Empty, String.Empty, String.Empty, True)
        ElseIf Length(drTrabajos("IDTrabajo")) > 0 Then
            NuevoTrabajo(drTrabajos("IDTrabajo"), drTrabajos("IDTipoTrabajo") & String.Empty, _
                         drTrabajos("IDSubTipoTrabajo") & String.Empty, drTrabajos("SubSubTipoTrabajo") & String.Empty, True)
        End If
        blnRefreshArbol = True
    End Sub

    Protected Overridable Sub mnuNuevaTarea_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles mnuNuevaTarea.Click
        AbrirMantenimientoTarea(, False, CurrentRow("IDObra"), CurrentRow("NObra"), drTrabajos("IDTrabajo"), drTrabajos("CodTrabajo") & String.Empty)
    End Sub

    Protected Overridable Sub mnuAnalitica_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles MnuAnalitica.Click
        AccionVerAnaliticaTrabajo()
    End Sub

    Protected Overridable Sub MnuGeneraVtos_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles MnuGeneraVtos.Click
        AbrirFormVencimientosDesdeTrabajo()
    End Sub

    Protected Overridable Sub MnuDeleteTrabajo_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles MnuDeleteTrabajo.Click
        If ExpertisApp.GenerateMessage("Se va a borrar el trabajo seleccionado. ¿Desea continuar?.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Me.Cursor = Cursors.WaitCursor

            ExpertisApp.ExecuteTask(Of Integer)(AddressOf ObraTrabajo.BorrarTrabajo, drTrabajos("IDTrabajo"))

            Me.Cursor = Cursors.Default
            blnRefreshArbol = True
            RefreshObra()
        End If
        ActiveDeleteObra()
    End Sub

    Protected Overridable Sub MnuDeleteIncremento_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles MnuDeleteIncremento.Click
        If Not IsNothing(drTrabajos) Then
            If ExpertisApp.GenerateMessage("Se va a borrar el incremento seleccionado. ¿Desea continuar?.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Me.Cursor = Cursors.WaitCursor

                ExpertisApp.ExecuteTask(Of Integer)(AddressOf Incrementos.DeletePorcentajesObras, drTrabajos("IDTrabajo"))

                Me.Cursor = Cursors.Default
                blnRefreshArbol = True
                RefreshObra()
            End If
        End If
    End Sub

    Protected Overridable Sub MnuVerFichaTrabajo_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles MnuVerFichaTrabajo.Click
        rbtVerFicha.Checked = True
    End Sub

    Protected Overridable Sub MnuDesgloseTrabajo_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles MnuDesgloseTrabajo.Click
        If Not IsNothing(drTrabajos) Then
            Dim frm As New frmDesgloseImportesTrabajo
            Dim ImpAcumulado, ImpAcumuladoVenta As Double
            If drTrabajos("TipoLinea") = enumTipoLineaTrabajo.tltTrabajoConcepto Then
                ImpAcumulado = Nz(drTrabajos("ImpPrevQTrabajoA"), 0)
                ImpAcumuladoVenta = Nz(drTrabajos("ImpPrevQTrabajoVentaA"), 0)
            Else
                ImpAcumulado = Nz(drTrabajos("ImpAcumulado"), 0)
                ImpAcumuladoVenta = Nz(drTrabajos("ImpAcumuladoVenta"), 0)
            End If
            frm.AbrirDesgloseTrabajo(drTrabajos("IDTrabajo"), ImpAcumulado, ImpAcumuladoVenta)
        End If
    End Sub
    Protected Overridable Sub AbrirFormVencimientosDesdeTrabajo(Optional ByVal blnGrid As Boolean = False)
        If blnGrid Then
            If TypeOf GridTrabajos.DataSource Is DataView Then
                drTrabajos = CType(GridTrabajos.DataSource, DataView)(GridTrabajos.GetRow.RowIndex).Row
            Else
                drTrabajos = CType(GridTrabajos.DataSource, DataTable).Rows(GridTrabajos.GetRow.RowIndex)
            End If
        End If
        If Not IsNothing(drTrabajos) Then
            If drTrabajos("Facturable") Then
                If drTrabajos("TipoFacturacion") = enumotTipoFacturacion.otfPorVencimientos Then
                    Dim frm As New FrmGeneraVencimientos
                    frm.AbrirGeneracionVencimientos(drTrabajos, Me.CurrentRow, enumottfClaseVencimiento.ottfTrabajo, Me)
                    Me.RequeryData()
                Else
                    ExpertisApp.GenerateMessage("Este trabajo no es facturable por trabajo completo.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                ExpertisApp.GenerateMessage("Este Trabajo no es facturable.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Protected Overridable Sub MnuTareasPred_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles MnuTareasPred.Click
        Dim frm As New FrmMntoTareaTrabajo
        If frm.LoadTareasTrabajo(Me.CurrentRow("IDObra"), Me.CurrentRow("NObra"), Me.CurrentRow("DescObra") & String.Empty, drTrabajos("IDTrabajo"), _
                                 drTrabajos("CodTrabajo") & String.Empty, drTrabajos("DescTrabajo") & String.Empty, Me.CurrentRow("IDTipoObra") & String.Empty) = DialogResult.OK Then

            Dim data As New TareaPredefinida.datosTareasPredefinidas(Me.CurrentRow("IDObra"), frm.DtTareas)
            ExpertisApp.ExecuteTask(Of TareaPredefinida.datosTareasPredefinidas)(AddressOf TareaPredefinida.GenerarTareasPredefinidas, data)
            Me.RefreshObra()
        End If
    End Sub

    Protected Overridable Sub MnuADDIncremento_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles MnuADDIncremento.Click
        If Not IsNothing(drTrabajos) Then
            'If Me.RecordsState = RecordsState.Modified Then
            '    SendKeys.Send("{F9}")
            'End If
            Dim frm As New frmAddIncremento
            Dim tipo As frmAddIncremento.AplicarPorcentajeA
            Select Case TabTrabajos.SelectedTab.Key
                Case "Materiales"
                    tipo = frmAddIncremento.AplicarPorcentajeA.apMaterial
                Case "Mod"
                    tipo = frmAddIncremento.AplicarPorcentajeA.apMod
                Case "Centros"
                    tipo = frmAddIncremento.AplicarPorcentajeA.apCentro
                Case Else
                    tipo = frmAddIncremento.AplicarPorcentajeA.apTodos
            End Select
            frm.AbrirADDIncrementos(tipo, drTrabajos)
            'blnPintarTrabajos = True
            RefreshObra()
        End If
    End Sub

    Protected Overridable Sub mnuGenerarCompras_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles mnuGenerarCompras.Click
        Dim HT As New Hashtable
        HT("IDObra") = Me.CurrentRow("IDObra")
        HT("NObra") = txtNObra.Text
        If Not drTrabajos Is Nothing Then
            HT.Add("IDTrabajo", drTrabajos("IDTrabajo"))
            HT.Add("CodTrabajo", drTrabajos("CodTrabajo"))
        End If
        ExpertisApp.OpenForm("MGECCO", , HT)
    End Sub

    Protected Overridable Sub mnuExpedir_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles mnuExpedir.Click
        Dim HT As New Hashtable
        HT("IDObra") = Me.CurrentRow("IDObra")
        HT("NObra") = txtNObra.Text
        If Not drTrabajos Is Nothing Then
            HT.Add("IDTrabajo", drTrabajos("IDTrabajo"))
            HT.Add("CodTrabajo", drTrabajos("CodTrabajo"))
        End If
        ExpertisApp.OpenForm("MEXPO", , HT)
    End Sub

    Protected Overridable Sub mnuFacturacion_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles mnuFacturacion.Click
        Dim HT As New Hashtable
        HT.Add("IDObra", Me.CurrentRow("IDObra"))
        HT.Add("NObra", txtNObra.Text)
        If Not drTrabajos Is Nothing Then
            HT.Add("IDTrabajo", drTrabajos("IDTrabajo"))
            HT.Add("CodTrabajo", drTrabajos("CodTrabajo"))
        End If
        ExpertisApp.OpenForm("FACTOBRAS", , HT)
    End Sub

    Protected Overridable Sub MnuGenerarTrabajosPeriodificados_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles MnuGenerarTrabajosPeriodificados.Click
        Dim HT As New Hashtable
        HT("IDObra") = Me.CurrentRow("IDObra")
        HT("NObra") = txtNObra.Text
        If Not drTrabajos Is Nothing Then
            HT.Add("IDTrabajo", drTrabajos("IDTrabajo"))
            HT.Add("CodTrabajo", drTrabajos("CodTrabajo"))
        End If
        If ExpertisApp.IsFormOpen("CITRABPERIODICOS") Then ExpertisApp.CloseForm("CITRABPERIODICOS")
        ExpertisApp.OpenForm("CITRABPERIODICOS", , HT)
    End Sub

    Protected Overridable Sub MnuGeneraVtosPeriodificados_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles MnuGeneraVtosPeriodificados.Click
        Dim HT As New Hashtable
        HT("IDObra") = Me.CurrentRow("IDObra")
        HT("NObra") = txtNObra.Text
        If Not drTrabajos Is Nothing Then
            HT.Add("IDTrabajo", drTrabajos("IDTrabajo"))
            HT.Add("CodTrabajo", drTrabajos("CodTrabajo"))
        End If
        If ExpertisApp.IsFormOpen("CIGENHITOS") Then ExpertisApp.CloseForm("CIGENHITOS")
        ExpertisApp.OpenForm("CIGENHITOS", , HT)
    End Sub

#Region " ADD Conceptos "

    Protected Overridable Sub MnuNuevoConcepto_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles MnuNuevoConcepto.Click
        If TabTrabajos.SelectedTab.Key = "Oficios" Then
            NuevoOficio()
        Else
            Dim blnFacturable As Boolean
            If Length(Me.CurrentRow("IDCliente")) = 0 Then
                blnFacturable = False
            ElseIf Length(drTrabajos("Facturable")) > 0 AndAlso Length(drTrabajos("TipoFacturacion")) > 0 AndAlso drTrabajos("TipoFacturacion") = enumotTipoFacturacion.otfPorConceptos Then
                blnFacturable = drTrabajos("Facturable")
            End If
            Select Case TabPrevistos.SelectedTab.Key
                Case "MaterialesPrev"
                    NuevoMaterial(blnFacturable)
                Case "ModPrev"
                    NuevoMOD(blnFacturable)
                Case "CentrosPrev"
                    NuevoCentro(blnFacturable)
                Case "GastosPrev"
                    NuevoGasto(blnFacturable)
                Case "VariosPrev"
                    NuevoVarios(blnFacturable)
                Case "Mediciones"
                    NuevaMedicion()
            End Select
        End If
    End Sub

    Protected Overridable Sub NuevoMaterial(ByVal blnFacturable As Boolean)
        Dim frm As New frmAddMateriales
        frm.chbFacturable.Enabled = Length(Me.CurrentRow("IDCliente")) > 0
        frm.chbExpedible.Enabled = frm.chbFacturable.Enabled

        Dim dt As DataTable = frm.AbrirAltaMateriales(CurrentRow("IDObra"), drTrabajos("IDTrabajo"), _
                                                      drTrabajos("CodTrabajo") & String.Empty, drTrabajos("DescTrabajo") & String.Empty, _
                                                      Nz(drTrabajos("QPrev"), 0), Nz(Me.CurrentRow("FechaInicio"), cnMinDate), _
                                                      Me.CurrentRow("IDCliente") & String.Empty, _
                                                      mstrEjercicioActual, blnFacturable)
        If Not IsNothing(dt) Then
            For Each dr As DataRow In dt.Rows
                ndMateriales.Data.Rows.Add(dr.ItemArray)
            Next
            Me.RecordsState = RecordsState.Modified
            FiltrarGrid(rbtPorNivelPrev.Checked, GridMaterialPrev, ndMateriales.Data, rbtPorMultinivelPrev.Checked)
            TotalesMaterialPrevisto(GridMaterialPrev, New EventArgs)
        End If
    End Sub

    Protected Overridable Sub NuevoMOD(ByVal blnFacturable As Boolean)
        Dim frm As New frmAddMOD
        frm.chbFacturable.Enabled = Length(Me.CurrentRow("IDCliente")) > 0
        Dim dt As DataTable = frm.AbrirAltaMOD(CurrentRow("IDObra"), drTrabajos("IDTrabajo"), _
                                               drTrabajos("CodTrabajo") & String.Empty, drTrabajos("DescTrabajo") & String.Empty, _
                                               Nz(drTrabajos("QPrev"), 0), mstrIDHora, mstrDescHora, blnFacturable)
        If Not IsNothing(dt) Then
            For Each dr As DataRow In dt.Rows
                ndMOD.Data.Rows.Add(dr.ItemArray)
            Next
            Me.RecordsState = RecordsState.Modified
            FiltrarGrid(rbtPorNivelPrev.Checked, GridMODPrev, ndMOD.Data, rbtPorMultinivelPrev.Checked)
            TotalesModPrevisto(GridMODPrev, New EventArgs)
        End If
    End Sub

    Protected Overridable Sub NuevoCentro(ByVal blnFacturable As Boolean)
        Dim frm As New frmAddCentros
        frm.chbFacturable.Enabled = Length(Me.CurrentRow("IDCliente")) > 0
        Dim dt As DataTable = frm.AbrirAltaCentros(CurrentRow("IDObra"), drTrabajos("IDTrabajo"), _
                                                   drTrabajos("CodTrabajo") & String.Empty, _
                                                   drTrabajos("DescTrabajo") & String.Empty, _
                                                   Nz(drTrabajos("QPrev"), 0), blnFacturable)
        If Not IsNothing(dt) Then
            For Each dr As DataRow In dt.Rows
                ndCentros.Data.Rows.Add(dr.ItemArray)
            Next
            Me.RecordsState = RecordsState.Modified
            FiltrarGrid(rbtPorNivelPrev.Checked, GridCentrosPrev, ndCentros.Data, rbtPorMultinivelPrev.Checked)
            TotalesCentrosPrevisto(GridCentrosPrev, New EventArgs)
        End If
    End Sub

    Protected Overridable Sub NuevoGasto(ByVal blnFacturable As Boolean)
        Dim frm As New frmAddGastos
        frm.chbFacturable.Enabled = Length(Me.CurrentRow("IDCliente")) > 0
        Dim dt As DataTable = frm.AbrirAltaGastos(CurrentRow("IDObra"), drTrabajos("IDTrabajo"), _
                                                  drTrabajos("CodTrabajo") & String.Empty, _
                                                  drTrabajos("DescTrabajo") & String.Empty, _
                                                  blnFacturable)
        If Not IsNothing(dt) Then
            For Each dr As DataRow In dt.Rows
                ndGastos.Data.Rows.Add(dr.ItemArray)
            Next
            Me.RecordsState = RecordsState.Modified
            FiltrarGrid(rbtPorNivelPrev.Checked, GridGastosPrev, ndGastos.Data, rbtPorMultinivelPrev.Checked)
            TotalesGastosPrevisto(GridGastosPrev, New EventArgs)
        End If
    End Sub

    Protected Overridable Sub NuevoVarios(ByVal blnFacturable As Boolean)
        Dim frm As New frmAddVarios
        frm.chbFacturable.Enabled = Length(Me.CurrentRow("IDCliente")) > 0
        Dim dt As DataTable = frm.AbrirAltaVarios(CurrentRow("IDObra"), drTrabajos("IDTrabajo"), _
                                                  drTrabajos("CodTrabajo") & String.Empty, _
                                                  drTrabajos("DescTrabajo") & String.Empty, blnFacturable)
        If Not IsNothing(dt) Then
            For Each dr As DataRow In dt.Rows
                ndVarios.Data.Rows.Add(dr.ItemArray)
            Next
            Me.RecordsState = RecordsState.Modified
            FiltrarGrid(rbtPorNivelPrev.Checked, GridVariosPrev, ndVarios.Data, rbtPorMultinivelPrev.Checked)
            TotalesVariosPrevisto(GridVariosPrev, New EventArgs)
        End If
    End Sub

    Protected Overridable Sub NuevaMedicion()
        Dim frm As New frmAddMediciones
        Dim dt As DataTable = frm.AbrirAltaMediciones(CurrentRow("IDObra"), drTrabajos("IDTrabajo"), _
                                                      drTrabajos("CodTrabajo") & String.Empty, _
                                                      drTrabajos("DescTrabajo") & String.Empty)
        If Not IsNothing(dt) Then
            For Each dr As DataRow In dt.Rows
                ndMediciones.Data.Rows.Add(dr.ItemArray)
            Next
            Me.RecordsState = RecordsState.Modified
            FiltrarGrid(rbtPorNivelPrev.Checked, GridMediciones, ndMediciones.Data, rbtPorMultinivelPrev.Checked)
            TotalesMediciones(GridMediciones, New EventArgs)
        End If
    End Sub

    Protected Overridable Sub NuevoOficio()
        Dim frm As New frmAddOficioOperario
        Dim dt As DataTable = frm.AbrirAltaOficioOperario(CurrentRow("IDObra"), drTrabajos("IDTrabajo"), _
                                                          drTrabajos("CodTrabajo") & String.Empty, _
                                                          drTrabajos("DescTrabajo") & String.Empty)
        If Not IsNothing(dt) Then
            For Each dr As DataRow In dt.Rows
                ndTrabajoOperario.Data.Rows.Add(dr.ItemArray)
            Next
            Me.RecordsState = RecordsState.Modified
            FiltrarGrid(rbtOperariosTrabajo.Checked, GridOperariosTrabajo, ndTrabajoOperario.Data)
        End If
    End Sub

#End Region

#Region " Avance Trabajo "

    Protected Overridable Sub mnuADDPeriodosAvance1_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles mnuADDPeriodosAvance1.Click
        MenuObras.Close()
        If Length(drTrabajos("FechaInicio")) = 0 OrElse Length(drTrabajos("FechaFin")) = 0 Then
            ExpertisApp.GenerateMessage("Las Fechas de Inicio y Fin del Trabajo son necesarias para poder generar los periodos.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim frm As New frmGeneraPeriodosAvance
            frm.txtCodTrabajo.Text = drTrabajos("CodTrabajo")
            frm.txtDescTrabajo.Text = drTrabajos("DescTrabajo") & String.Empty
            If Length(drTrabajos("FechaInicio")) > 0 Then frm.cbxFechaInicio.Value = drTrabajos("FechaInicio")
            If Length(drTrabajos("FechaFin")) > 0 Then frm.cbxFechaFin.Value = drTrabajos("FechaFin")

            If frm.ShowDialog = DialogResult.OK Then
                Dim info As New AvanceTrabajo.dataGeneraPeriodos(drTrabajos("IDTrabajo"), frm.cbxFechaInicio.Value, frm.cbxFechaFin.Value, _
                                                                 frm.cbxTipoPeriodo.Value, frm.txtPeriodo.Text, frm.chkAvancePrevisto.Checked, _
                                                                 Nz(frm.txtPorcFijo.Value, 0), frm.chkAvanceAutomatico.Checked)

                ExpertisApp.ExecuteTask(Of AvanceTrabajo.dataGeneraPeriodos)(AddressOf AvanceTrabajo.GenerarPeriodos, info)
                If Me.RecordsState = UI.RecordsState.Saved Then
                    RefreshObra()
                Else
                    ExpertisApp.GenerateMessage("Los Periodos de Avance se han generado. Para poder visualizarlos debe de confirmar las modificaciones pendientes.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
    End Sub

    Protected Overridable Sub mnuActualizarAvanceReal1_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles mnuActualizarAvanceReal1.Click
        MenuObras.Close()
        If ExpertisApp.GenerateMessage("Se actualizarán todas las líneas con Avance Automático y no Cerradas.{0}¿Desea continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, vbNewLine) = Windows.Forms.DialogResult.Yes Then
            ExpertisApp.ExecuteTask(Of Integer)(AddressOf AvanceTrabajo.ActualizarAvanceReal, drTrabajos("IDTrabajo"))
            ExpertisApp.GenerateMessage("Proceso finalizado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            RefreshObra()
        End If
    End Sub

    Protected Overridable Sub mnuRehacerPeriodos1_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles mnuRehacerPeriodos1.Click
        MenuObras.Close()
        Dim UltimoPeriodoCerrado As Integer = EvaluarPeriodos()
        If UltimoPeriodoCerrado > 0 Then
            Dim frm As New frmRehacerPeriodosAvance
            frm.UltimoPeriodoCerrado = UltimoPeriodoCerrado
            If frm.ShowDialog = DialogResult.OK Then
                Dim Periodo As Integer = -1
                If Length(frm.txtPeriodo.Text) > 0 Then Periodo = frm.txtPeriodo.Text
                Dim info As New AvanceTrabajo.dataRehacerPeriodos(drTrabajos("IDTrabajo"), frm.AccionSeleccionada, frm.CalcularRespecto, Periodo, UltimoPeriodoCerrado)
                ExpertisApp.ExecuteTask(Of AvanceTrabajo.dataRehacerPeriodos)(AddressOf AvanceTrabajo.RehacerPeriodos, info)
                ExpertisApp.GenerateMessage("Proceso finalizado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                RefreshObra()
            End If
        End If
    End Sub

    Protected Overridable Function EvaluarPeriodos() As Integer
        'Validar que el último periodo con avance esté cerrado
        Dim f As New Filter(FilterUnionOperator.Or)
        f.Add(New NumberFilterItem("AvanceRealCliente", FilterOperator.GreaterThan, 0))
        f.Add(New NumberFilterItem("AvanceRealProduccion", FilterOperator.GreaterThan, 0))

        Dim dtAvanceTrabajo As DataTable
        If TypeOf GridAvanceTrabajo.DataSource Is DataView Then
            dtAvanceTrabajo = CType(GridAvanceTrabajo.DataSource, DataView).Table
        Else
            dtAvanceTrabajo = CType(GridAvanceTrabajo.DataSource, DataTable)
        End If

        If Not dtAvanceTrabajo Is Nothing AndAlso dtAvanceTrabajo.Rows.Count > 0 Then
            Dim Where As String = f.Compose(New AdoFilterComposer)
            Dim dr() As DataRow = dtAvanceTrabajo.Select(Where, "Periodo DESC")
            If dr.Length > 0 AndAlso dr(0)("Cerrado") Then
                Return dr(0)("Periodo")
            End If

            ExpertisApp.GenerateMessage("Debe marcar como cerrado el último periodo con avance actualizado.{0}Proceso cancelado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, vbNewLine)
            Return 0
        End If
        Return 0

    End Function

    Protected Overridable Sub mnuVerDesviaciones1_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles mnuVerDesviaciones1.Click
        MenuObras.Close()
        Dim HT As New Hashtable
        HT.Add("IDObra", Me.CurrentRow("IDObra"))
        HT.Add("NObra", txtNObra.Text)
        If Not drTrabajos Is Nothing Then
            HT.Add("IDTrabajo", drTrabajos("IDTrabajo"))
            HT.Add("CodTrabajo", drTrabajos("CodTrabajo"))
        End If
        ExpertisApp.OpenForm("CICERTIFICAPRODOBRA", , HT)
    End Sub

#End Region

#Region " Gestion Documental "

    Protected Overridable Sub mnuAltaDocumentos1_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles mnuAltaDocumentos1.Click
        MenuObras.Close()
        Dim DtFinal As DataTable = dtTrabajos.Clone
        Dim DrGrid() As DataRow = dtTrabajos.Copy.Select("IDTrabajo = " & drTrabajos("IDTrabajo"))
        DtFinal.Rows.Add(DrGrid(0).ItemArray)
        Dim ClsGD As New ClsAltaDocumentosGD
        ClsGD.AltaDocumentos(ndTrabajos.EntityName, DtFinal)
    End Sub

    Protected Overridable Sub mnuDocumentosRel1_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles mnuDocumentosRel1.Click
        MenuObras.Close()
        Dim DtFinal As DataTable = dtTrabajos.Clone
        Dim DrGrid() As DataRow = dtTrabajos.Copy.Select("IDTrabajo = " & drTrabajos("IDTrabajo"))
        DtFinal.Rows.Add(DrGrid(0).ItemArray)
        Dim ClsGD As New clsDocusRelacionadosGD
        ClsGD.DocumentosRelacionados(ndTrabajos.EntityName, DtFinal)
    End Sub

    Protected Overridable Sub mnuVincularDocumentos1_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles mnuVincularDocumentos1.Click
        MenuObras.Close()
        Dim DtFinal As DataTable = dtTrabajos.Clone
        Dim DrGrid() As DataRow = dtTrabajos.Copy.Select("IDTrabajo = " & drTrabajos("IDTrabajo"))
        DtFinal.Rows.Add(DrGrid(0).ItemArray)
        Dim ClsGD As New clsVinculaDocumentoGD
        ClsGD.VinculaDocumentos(ndTrabajos.EntityName, DtFinal)
    End Sub

#End Region

#End Region

#End Region

#Region " Ficha Trabajo "

    Protected Overridable Sub chkNoAcumular_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNoAcumular.CheckedChanged
        txtImpUnitario.Enabled = chkNoAcumular.Checked
        txtMargenTrabajoFicha.Enabled = chkNoAcumular.Checked
        txtImpUnitarioVta.Enabled = chkNoAcumular.Checked
    End Sub

    Protected Overridable Sub cbxTipoFacturacion_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxTipoFacturacion.ValueChanged
        txtQCertificada.Visible = Length(cbxTipoFacturacion.Value) > 0 AndAlso (cbxTipoFacturacion.Value = enumotTipoFacturacion.otfPorUdsObra)
        lblQCertificada.Visible = txtQCertificada.Visible
    End Sub

    Protected Overridable Sub cbxTipoLinea_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxTipoLinea.ValueChanged
        txtIncremento.Visible = Length(cbxTipoLinea.Value) > 0 AndAlso cbxTipoLinea.Value = enumTipoLineaTrabajo.tltPorcentajeConcepto
        lblIncremento.Visible = txtIncremento.Visible
    End Sub

    Protected Overridable Sub AdvTipoTrabajo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles AdvTipoTrabajo.GotFocus
        strTipoTrabajo = AdvTipoTrabajo.Text
    End Sub

    Protected Overridable Sub AdvTipoTrabajo_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles AdvTipoTrabajo.SetPredefinedFilter
        If Length(AdvIDTipoObra.Value) > 0 Then
            e.Filter.Add(New StringFilterItem("IDTipoObra", AdvIDTipoObra.Value))
        End If
    End Sub

    Protected Overridable Sub AdvTipoTrabajo_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles AdvTipoTrabajo.SelectionChanged
        If MakeBinding Then
            If Length(AdvTipoTrabajo.Text) > 0 AndAlso strTipoTrabajo <> AdvTipoTrabajo.Text Then
                AdvSubTipoTrabajo.Text = String.Empty
                txtDescTrabajo.Text = e.Selected.Rows(0)("DescTipoTrabajo") & String.Empty
                txtCodTrabajo.Text = AdvTipoTrabajo.Text & AdvSubTipoTrabajo.Text
            End If
        End If
    End Sub

    Protected Overridable Sub AdvSubTipoTrabajo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles AdvSubTipoTrabajo.GotFocus
        strSubTipoTrabajo = AdvSubTipoTrabajo.Text
    End Sub

    Protected Overridable Sub AdvSubTipoTrabajo_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles AdvSubTipoTrabajo.SetPredefinedFilter
        If Length(AdvIDTipoObra.Value) > 0 Then
            e.Filter.Add(New StringFilterItem("IDTipoObra", AdvIDTipoObra.Value))
        End If
        If Length(AdvTipoTrabajo.Text) > 0 Then
            e.Filter.Add(New StringFilterItem("IDTipoTrabajo", AdvTipoTrabajo.Text))
        End If
    End Sub

    Protected Overridable Sub AdvSubTipoTrabajo_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles AdvSubTipoTrabajo.SelectionChanged
        If MakeBinding AndAlso Length(AdvSubTipoTrabajo.Text) > 0 Then
            If strSubTipoTrabajo <> AdvSubTipoTrabajo.Text Then
                'AdvTipoTrabajo.Text = e.Selected.Rows(0)("IDTipoTrabajo")
                AdvSubSubTipoTrabajo.Text = String.Empty
                Dim intPos As Integer = InStr(txtDescTrabajo.Text, "-")
                If intPos > 0 Then txtDescTrabajo.Text = Mid$(txtDescTrabajo.Text, 1, intPos - 1)
                txtDescTrabajo.Text = txtDescTrabajo.Text & "-" & e.Selected.Rows(0)("DescSubTipoTrabajo") & String.Empty
                txtCodTrabajo.Text = AdvTipoTrabajo.Text & AdvSubTipoTrabajo.Text
            End If
        End If
    End Sub

    Protected Overridable Sub AdvTrabajoPresup_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles AdvTrabajoPresup.SetPredefinedFilter
        If Length(Me.CurrentRow("IDPresup")) > 0 Then
            e.Filter.Add("IDPresup", FilterOperator.Equal, Me.CurrentRow("IDPresup"), FilterType.Numeric)
        End If
    End Sub

    Protected Overridable Sub AdvSubSubTipoTrabajo_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles AdvSubSubTipoTrabajo.SetPredefinedFilter
        If Length(AdvIDTipoObra.Value) > 0 Then
            e.Filter.Add(New StringFilterItem("IDTipoObra", AdvIDTipoObra.Value))
        End If
        If Length(AdvTipoTrabajo.Text) > 0 Then
            e.Filter.Add(New StringFilterItem("IDTipoTrabajo", AdvTipoTrabajo.Text))
        End If
        If Length(AdvSubTipoTrabajo.Text) > 0 Then
            e.Filter.Add(New StringFilterItem("IDSubTipoTrabajo", AdvSubTipoTrabajo.Text))
        End If
    End Sub

    Protected Overridable Sub txtImpUnitario_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImpUnitario.Validated
        Dim t As New ObraTrabajoPresup
        Dim d As New BusinessData(drTrabajos)
        d = t.ApplyBusinessRule("ImpPrevTrabajoA", txtImpUnitario.Value, d)
        txtMargenTrabajoFicha.Value = d("MargenPrevTrabajo")
        txtImpUnitarioVta.Value = d("ImpPrevTrabajoVentaA")
    End Sub

    Protected Overridable Sub txtImpUnitarioVta_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImpUnitarioVta.Validated
        Dim t As New ObraTrabajoPresup
        Dim d As New BusinessData(drTrabajos)
        d = t.ApplyBusinessRule("ImpPrevTrabajoVentaA", txtImpUnitarioVta.Value, d)
        txtImpUnitario.Value = d("ImpPrevTrabajoA")
        txtMargenTrabajoFicha.Value = d("MargenPrevTrabajo")
    End Sub

    Protected Overridable Sub txtMargenTrabajoFicha_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMargenTrabajoFicha.Validated
        Dim t As New ObraTrabajoPresup
        Dim d As New BusinessData(drTrabajos)
        d = t.ApplyBusinessRule("MargenPrevTrabajo", txtMargenTrabajoFicha.Value, d)
        txtImpUnitario.Value = d("ImpPrevTrabajoA")
        txtImpUnitarioVta.Value = d("ImpPrevTrabajoVentaA")
    End Sub

    Protected Overridable Sub chkPeriodificable_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPeriodificable.CheckedChanged
        ntxPeriodoPeriodificacion.Enabled = chkPeriodificable.Checked
        cbxTipoPeriodoPeriodificacion.Enabled = ntxPeriodoPeriodificacion.Enabled
        chkAplicarSobreUltimo.Enabled = ntxPeriodoPeriodificacion.Enabled
        ntxPorcIncrDecrPerido.Enabled = ntxPeriodoPeriodificacion.Enabled
    End Sub

#End Region

    Protected Overridable Sub rbtVerFicha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtVerFicha.CheckedChanged
        pnlFichaTrabajo.Visible = rbtVerFicha.Checked
        pnlTrabajosCompleto.Visible = rbtVerProyectoCompleto.Checked
        pnlGridTrabajo.Visible = rbtVerGrid.Checked
        PnlTimeObras.Visible = RdTimeObras.Checked

        If rbtVerFicha.Checked Then VerFormatoFicha()
        TabTrabajos.TabPages("Trabajos").Selected = True
        CamposNoEditables()
    End Sub

    Protected Overridable Sub rbtVerGrid_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtVerGrid.CheckedChanged
        pnlFichaTrabajo.Visible = rbtVerFicha.Checked
        pnlTrabajosCompleto.Visible = rbtVerProyectoCompleto.Checked
        pnlGridTrabajo.Visible = rbtVerGrid.Checked
        PnlTimeObras.Visible = RdTimeObras.Checked

        If rbtVerGrid.Checked Then VerFormatoGrid()
        TabTrabajos.TabPages("Trabajos").Selected = True
    End Sub

    Protected Overridable Sub rbtVerProyectoCompleto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtVerProyectoCompleto.CheckedChanged
        pnlFichaTrabajo.Visible = rbtVerFicha.Checked
        pnlTrabajosCompleto.Visible = rbtVerProyectoCompleto.Checked
        pnlGridTrabajo.Visible = rbtVerGrid.Checked
        PnlTimeObras.Visible = RdTimeObras.Checked

        If rbtVerProyectoCompleto.Checked Then VerDatosTrabajoCompleto()
        TabTrabajos.TabPages("Trabajos").Selected = True
    End Sub

    Protected Overridable Sub RdTimeObras_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RdTimeObras.CheckedChanged
        pnlFichaTrabajo.Visible = rbtVerFicha.Checked
        pnlTrabajosCompleto.Visible = rbtVerProyectoCompleto.Checked
        pnlGridTrabajo.Visible = rbtVerGrid.Checked
        PnlTimeObras.Visible = RdTimeObras.Checked

        If RdTimeObras.Checked Then VerFormatoTimeObras()
        TabTrabajos.TabPages("Trabajos").Selected = True
    End Sub

#Region " Arbol trabajo completo "

    Private Enum IconIndex
        oObra = 0
        oTrabajos = 1
        oMateriales = 2
        oMod = 3
        oCentros = 4
        oGastos = 5
        oVarios = 6
        oMediciones = 7
        oCapitulos = 8
        oPorcentajes = 9
        oSubcapitulo = 10
    End Enum

    Protected Overridable Sub VerDatosTrabajoCompleto()
        If Not drTrabajos Is Nothing AndAlso Length(drTrabajos("IDTrabajo")) > 0 Then
            'Dim Cancel As Boolean = False
            'If TvwObraCompleta.Nodes.Count > 0 Then
            '    If ExpertisApp.GenerateMessage("¿Desea refrescar el árbol de la estructura completa del trabajo?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            '        Cancel = True
            '    End If
            'End If
            'If Not Cancel Then
            TvwObraCompleta.Nodes.Clear()
            Me.Cursor = Cursors.WaitCursor
            TvwObraCompleta.ImageList = ImageListTrabajoCompleto
            PintarTrabajoCompleto(drTrabajos, Nothing)
            TvwObraCompleta.SelectedNode = TvwObraCompleta.TopNode
            Me.Cursor = Cursors.Default
            'End If
        End If
    End Sub

    Protected Overridable Sub VerFormatoTimeObras()
        If Not drTrabajos Is Nothing AndAlso Length(drTrabajos("IDTrabajo")) > 0 Then
            Me.CtrlTimeLineObras1.IDObra = Me.CurrentRow("IDObra")
            Me.CtrlTimeLineObras1.IDTrabajo = drTrabajos("IDTrabajo")
            Me.CtrlTimeLineObras1.LoadTimeObras()
        End If
    End Sub

    Public Sub UpdateTrabajo(ByVal IDTrabajo As Integer, ByVal StartDate As DateTime, ByVal EndDate As DateTime, ByVal Avance As Double, ByVal TipoAvance As Integer) Handles CtrlTimeLineObras1.UpdateTrabajo
        Dim DrSel() As DataRow = ndTrabajos.Data.Select("IDTrabajo = " & IDTrabajo)
        If DrSel.Length > 0 Then
            DrSel(0)("FechaInicio") = StartDate
            DrSel(0)("FechaFin") = EndDate
            If TipoAvance = 0 Then
                DrSel(0)("AvanceEstimado") = Avance
            Else : DrSel(0)("AvanceCalculado") = Avance
            End If
        End If
    End Sub

    Public Sub UpdateInsertTrabajo(ByVal IDTrabajo As Integer, ByVal FechaInicio As Date, ByVal FechaFin As Date) Handles CtrlTimeLineObras1.UpdateInsertTrabajo
        For Each Nd As TreeNode In Me.TvwTrabajos.Nodes
            If CType(Nd.Tag, TagTrabajo).IDTrabajo = IDTrabajo Then
                Me.TvwTrabajos.SelectedNode = Nd
                Exit For
            ElseIf Nd.Nodes.Count > 0 Then
                If GetNode(Nd, IDTrabajo) Then Exit For
            End If
        Next
        NuevoTrabajo(drTrabajos("IDTrabajo"), drTrabajos("IDTipoTrabajo") & String.Empty, _
                     drTrabajos("IDSubTipoTrabajo") & String.Empty, drTrabajos("SubSubTipoTrabajo") & String.Empty, False, FechaInicio, FechaFin)
    End Sub

    Public Sub VerFichaTrabajo(ByVal IDTrabajo As Integer) Handles CtrlTimeLineObras1.VerFichaTrabajo
        For Each Nd As TreeNode In Me.TvwTrabajos.Nodes
            If CType(Nd.Tag, TagTrabajo).IDTrabajo = IDTrabajo Then
                Me.TvwTrabajos.SelectedNode = Nd
                Exit For
            ElseIf Nd.Nodes.Count > 0 Then
                If GetNode(Nd, IDTrabajo) Then Exit For
            End If
        Next
        rbtVerFicha.Checked = True
    End Sub



#Region " Trabajos "

    Protected Overridable Sub PintarTrabajoCompleto(ByVal drTrabajos As DataRow, Optional ByVal oNode As TreeNode = Nothing)
        If Not dtTrabajos Is Nothing AndAlso dtTrabajos.Rows.Count > 0 Then
            If Not TvwObraCompleta.Enabled Then TvwObraCompleta.Enabled = True
            PintarNodoTrabajoCompleto(drTrabajos, dtTrabajos, oNode)
        End If

        TvwObraCompleta.ExpandAll()
        TvwObraCompleta.Refresh()

        Me.Cursor = Cursors.Default
    End Sub

    Protected Overridable Sub PintarNodoTrabajoCompleto(ByVal drTrabajo As DataRow, ByVal dtTrabajos As DataTable, _
                                          Optional ByVal oNode As TreeNode = Nothing)

        Const cnTRUNCATE As Integer = 75

        Dim strText As String = drTrabajo("CodTrabajo") & " -> " & drTrabajo("DescTrabajo")
        If Len(strText) > cnTRUNCATE Then
            strText = Strings.Left(strText, cnTRUNCATE)
        Else
            strText = strText + Space(cnTRUNCATE - Len(strText))
        End If

        ' Dim strImportes As String = Format(drTrabajo("ImpAcumulado"), "#,##0.00") & Space(5) & Format(drTrabajo("ImpAcumuladoVenta"), "#,##0.00")

        Dim ImpTotal As Double

        If drTrabajo("TipoLinea") = enumTipoLineaTrabajo.tltTrabajo Or drTrabajo("TipoLinea") = enumTipoLineaTrabajo.tltCapitulo Then

            ImpTotal = drTrabajo("ImpAcumuladoVenta")
        Else
            ImpTotal = drTrabajo("ImpPrevQTrabajoVentaA")

        End If

        Dim strImportes As String
        If drTrabajo("TipoLinea") = enumTipoLineaTrabajo.tltCapitulo Then
            strImportes = "  Importe: " & Format(ImpTotal, "#,##0.00")
        Else
            strImportes = "Precio: " & Format(drTrabajo("ImpPrevTrabajoVentaA"), "#,##0.00") & " Ctd: " & Format(drTrabajo("QPrev"), "#,##0.00") & " Importe: " & Format(drTrabajo("ImpPrevQTrabajoVentaA"), "#,##0.00") & Space(5)
        End If

        strText = strText & Space(5) & strImportes

        If oNode Is Nothing Then
            oNode = TvwObraCompleta.Nodes.Add(strText)
        Else
            oNode = oNode.Nodes.Add(strText)
        End If

        If drTrabajo("TipoLinea") = enumTipoLineaTrabajo.tltTrabajo Then
            oNode.ImageIndex = IconIndex.oTrabajos
            If Nz(drTrabajo("ImpPrevQTrabajoA"), 0) = 0 Then
                oNode.ImageIndex = IconIndex.oSubcapitulo
            Else
                oNode.ImageIndex = IconIndex.oTrabajos
            End If
        ElseIf drTrabajo("TipoLinea") = enumTipoLineaTrabajo.tltTrabajoConcepto Then
            oNode.ImageIndex = 10
        ElseIf drTrabajo("TipoLinea") = enumTipoLineaTrabajo.tltCapitulo Then
            oNode.ImageIndex = IconIndex.oCapitulos
            oNode.BackColor = Color.FromArgb(255, 255, 128) 'Color.Yellow 
        ElseIf drTrabajo("TipoLinea") = enumTipoLineaTrabajo.tltPorcentajeConcepto Then
            oNode.ImageIndex = IconIndex.oPorcentajes
            oNode.BackColor = Color.FromArgb(255, 192, 128) 'Color.Orange
        End If
        oNode.SelectedImageIndex = oNode.ImageIndex



        Dim Where As String = New NumberFilterItem("IDTrabajo", drTrabajo("IDTrabajo")).Compose(New AdoFilterComposer)
        PintarMateriales(ndMateriales.Data.Copy.Select(Where), oNode)
        PintarMOD(ndMOD.Data.Copy.Select(Where), oNode)
        PintarCentros(ndCentros.Data.Copy.Select(Where), oNode)
        PintarGastos(ndGastos.Data.Copy.Select(Where), oNode)
        PintarVarios(ndVarios.Data.Copy.Select(Where), oNode)
        PintarMediciones(ndMediciones.Data.Copy.Select(Where), oNode)

        'pintar sus subtrabajos
        Where = New NumberFilterItem("IDTrabajoPadre", drTrabajo("IDTrabajo")).Compose(New AdoFilterComposer)
        For Each drHijos As DataRow In ndTrabajos.Data.Copy.Select(Where, "secuencia")
            PintarNodoTrabajoCompleto(drHijos, dtTrabajos, oNode)
        Next

        oNode = Nothing
    End Sub

#End Region

#Region " Materiales "
    Protected Overridable Sub PintarMateriales(ByVal drMateriales() As DataRow, Optional ByVal oNode As TreeNode = Nothing)
        If Not drMateriales Is Nothing AndAlso drMateriales.Length > 0 Then
            oNode = oNode.Nodes.Add(ExpertisApp.Traslate("MATERIALES"))
            oNode.ImageIndex = IconIndex.oMateriales
            oNode.SelectedImageIndex = IconIndex.oMateriales
            'For Each drMaterial As DataRow In drMateriales
            '    PintarNodoMaterial(drMaterial("IDMaterial") & String.Empty, drMaterial("DescMaterial") & String.Empty, drMaterial("QPrev"), oNode)
            'Next
            For Each drMaterial As DataRow In drMateriales
                Dim strText As String = "Artículo: " & drMaterial("IDMaterial") & " - " & drMaterial("DescMaterial") _
                & String.Empty & " Precio: " & Format(drMaterial("PrecioVentaA"), "#,##0.00") _
                & String.Empty & " Ctd.UD: " & Format(drMaterial("QUnidad"), "#,##0.00") _
                & String.Empty & " Importe UD: " & Format(drMaterial("QUnidad") * drMaterial("PrecioVentaA"), "#,##0.00") _
                & String.Empty & " Ctd.: " & Format(drMaterial("QPrev"), "#,##0.00") _
                & String.Empty & " Importe: " & Format(drMaterial("QPrev") * drMaterial("PrecioVentaA"), "#,##0.00")

                PintarNodoMaterial(strText, oNode)
            Next
        End If

    End Sub

    Protected Overridable Sub PintarNodoMaterial(ByVal strIDMaterial As String, ByVal strDescMaterial As String, ByVal dblQPrev As Double, _
                                   Optional ByVal oNode As TreeNode = Nothing)

        Dim strText As String = "Artículo: " & strIDMaterial & " - " & strDescMaterial & "  Cantidad Total: " & dblQPrev
        If oNode Is Nothing Then
            oNode = TvwObraCompleta.Nodes.Add(strText)
        Else
            oNode = oNode.Nodes.Add(strText)
        End If
        oNode.ImageIndex = IconIndex.oMateriales
        oNode.SelectedImageIndex = IconIndex.oMateriales

        oNode = Nothing
    End Sub
    Protected Overridable Sub PintarNodoMaterial(ByVal strText As String, Optional ByVal oNode As TreeNode = Nothing)

        If oNode Is Nothing Then
            oNode = TvwObraCompleta.Nodes.Add(strText)
        Else
            oNode = oNode.Nodes.Add(strText)
        End If
        oNode.ImageIndex = IconIndex.oMateriales
        oNode.SelectedImageIndex = IconIndex.oMateriales

        oNode = Nothing
    End Sub
#End Region

#Region " MOD "
    Protected Overridable Sub PintarMOD(ByVal dtMOD() As DataRow, Optional ByVal oNode As TreeNode = Nothing)
        If Not dtMOD Is Nothing AndAlso dtMOD.Length > 0 Then
            oNode = oNode.Nodes.Add(ExpertisApp.Traslate("MOD"))
            oNode.ImageIndex = IconIndex.oMod
            oNode.SelectedImageIndex = IconIndex.oMod
            'For Each drMOD As DataRow In dtMOD
            '    PintarNodoMOD(drMOD("IDCategoria") & String.Empty, drMOD("DescCategoria") & String.Empty, _
            '                  drMOD("DesHora") & String.Empty, oNode)
            'Next
            For Each drMOD As DataRow In dtMOD
                Dim strText As String = "Categoría: " & drMOD("IDCategoria") & " - " & drMOD("DescCategoria") & "  Tipo Hora: " & drMOD("DesHora") _
                & String.Empty & " Precio: " & Format(drMOD("PrecioVentaA"), "#,##0.00") _
                & String.Empty & " Ctd.UD: " & Format(drMOD("HorasUnidad"), "#,##0.00") _
                & String.Empty & " Importe UD: " & Format(drMOD("HorasUnidad") * drMOD("PrecioVentaA"), "#,##0.00") _
                & String.Empty & " Ctd.: " & Format(drMOD("HorasPrevMod"), "#,##0.00") _
                & String.Empty & " Importe: " & Format(drMOD("HorasPrevMod") * drMOD("PrecioVentaA"), "#,##0.00")
                PintarNodoMOD(strText, oNode)
            Next
            oNode = Nothing
        End If

    End Sub

    Protected Overridable Sub PintarNodoMOD(ByVal strIDCategoria As String, _
                              ByVal strDescCategoria As String, ByVal strDescHora As String, _
                              Optional ByVal oNode As TreeNode = Nothing)

        Dim strText As String = "Categoría: " & strIDCategoria & " - " & strDescCategoria & "  Tipo Hora: " & strDescHora
        If oNode Is Nothing Then
            oNode = TvwObraCompleta.Nodes.Add(strText)
        Else
            oNode = oNode.Nodes.Add(strText)
        End If
        oNode.ImageIndex = IconIndex.oMod
        oNode.SelectedImageIndex = IconIndex.oMod

        oNode = Nothing
    End Sub
    Protected Overridable Sub PintarNodoMOD(ByVal strText As String, Optional ByVal oNode As TreeNode = Nothing)


        If oNode Is Nothing Then
            oNode = TvwObraCompleta.Nodes.Add(strText)
        Else
            oNode = oNode.Nodes.Add(strText)
        End If
        oNode.ImageIndex = IconIndex.oMod
        oNode.SelectedImageIndex = IconIndex.oMod

        oNode = Nothing
    End Sub
#End Region

#Region " Centros "
    Protected Overridable Sub PintarCentros(ByVal dtCentros() As DataRow, Optional ByVal oNode As TreeNode = Nothing)
        If Not dtCentros Is Nothing AndAlso dtCentros.Length > 0 Then
            oNode = oNode.Nodes.Add(ExpertisApp.Traslate("CENTROS"))
            oNode.ImageIndex = IconIndex.oCentros
            oNode.SelectedImageIndex = IconIndex.oCentros
            For Each drCentros As DataRow In dtCentros
                Dim strText As String = "Centro: " & drCentros("IDCentro") & " - " & drCentros("DescCentro") _
                   & String.Empty & " Ctd.UD: " & Format(drCentros("HorasUnidad"), "#,##0.00") _
                & String.Empty & " Precio: " & Format(drCentros("PrecioVentaA"), "#,##0.00") _
                & String.Empty & " Ctd.: " & Format(drCentros("HorasPrevCentro"), "#,##0.00") _
                & String.Empty & " Importe: " & Format(drCentros("HorasPrevCentro") * drCentros("PrecioVentaA"), "#,##0.00")
                PintarNodoCentros(strText, oNode)
            Next
            oNode = Nothing
        End If
    End Sub

    Protected Overridable Sub PintarNodoCentros(ByVal strIDCentro As String, ByVal strDescCentro As String, _
                                  Optional ByVal oNode As TreeNode = Nothing)

        Dim strText As String = "Centro: " & strIDCentro & " - " & strDescCentro
        If oNode Is Nothing Then
            oNode = TvwObraCompleta.Nodes.Add(strText)
        Else
            oNode = oNode.Nodes.Add(strText)
        End If
        oNode.ImageIndex = IconIndex.oCentros
        oNode.SelectedImageIndex = IconIndex.oCentros

        oNode = Nothing
    End Sub
    Protected Overridable Sub PintarNodoCentros(ByVal strText As String, _
                               Optional ByVal oNode As TreeNode = Nothing)


        If oNode Is Nothing Then
            oNode = TvwObraCompleta.Nodes.Add(strText)
        Else
            oNode = oNode.Nodes.Add(strText)
        End If
        oNode.ImageIndex = IconIndex.oCentros
        oNode.SelectedImageIndex = IconIndex.oCentros

        oNode = Nothing
    End Sub
#End Region

#Region " Gastos "
    Protected Overridable Sub PintarGastos(ByVal dtGastos() As DataRow, Optional ByVal oNode As TreeNode = Nothing)
        If Not dtGastos Is Nothing AndAlso dtGastos.Length > 0 Then
            oNode = oNode.Nodes.Add(ExpertisApp.Traslate("GASTOS"))
            oNode.ImageIndex = IconIndex.oGastos
            oNode.SelectedImageIndex = IconIndex.oGastos
            For Each drGastos As DataRow In dtGastos
                Dim strText As String = "Gasto: " & drGastos("IDGasto") & " - " & drGastos("DescGasto") _
                & String.Empty & " Importe: " & Format(drGastos("ImpPrevGastoVentaA"), "#,##0.00")
                If drGastos("AplicarQ") Then
                    strText = strText & "  Aplicar cantidad"
                End If
                PintarNodoGastos(strText, oNode)
            Next
            oNode = Nothing
        End If
    End Sub
    Protected Overridable Sub PintarNodoGastos(ByVal strText As String, Optional ByVal oNode As TreeNode = Nothing)


        If oNode Is Nothing Then
            oNode = TvwObraCompleta.Nodes.Add(strText)
        Else
            oNode = oNode.Nodes.Add(strText)
        End If
        oNode.ImageIndex = IconIndex.oGastos
        oNode.SelectedImageIndex = IconIndex.oGastos

        oNode = Nothing
    End Sub
    Protected Overridable Sub PintarNodoGastos(ByVal strIDGasto As String, ByVal strDescGasto As String, _
                                 Optional ByVal oNode As TreeNode = Nothing)

        Dim strText As String = "Gasto: " & strIDGasto & " - " & strDescGasto
        If oNode Is Nothing Then
            oNode = TvwObraCompleta.Nodes.Add(strText)
        Else
            oNode = oNode.Nodes.Add(strText)
        End If
        oNode.ImageIndex = IconIndex.oGastos
        oNode.SelectedImageIndex = IconIndex.oGastos

        oNode = Nothing
    End Sub
#End Region

#Region " Varios "
    Protected Overridable Sub PintarVarios(ByVal dtVarios() As DataRow, Optional ByVal oNode As TreeNode = Nothing)
        If Not dtVarios Is Nothing AndAlso dtVarios.Length > 0 Then
            oNode = oNode.Nodes.Add(ExpertisApp.Traslate("VARIOS"))
            oNode.ImageIndex = IconIndex.oVarios
            oNode.SelectedImageIndex = IconIndex.oVarios
            For Each drVarios As DataRow In dtVarios
                Dim strText As String = "Varios: " & drVarios("IDVarios") & " - " & drVarios("DescVarios") _
                & String.Empty & " Importe: " & Format(drVarios("ImpPrevVariosVentaA"), "#,##0.00")
                If drVarios("AplicarQ") Then
                    strText = strText & "  Aplicar cantidad"
                End If

                PintarNodoVarios(strText, oNode)
            Next
            oNode = Nothing
        End If
    End Sub
    Protected Overridable Sub PintarNodoVarios(ByVal strText As String, Optional ByVal oNode As TreeNode = Nothing)


        If oNode Is Nothing Then
            oNode = TvwObraCompleta.Nodes.Add(strText)
        Else
            oNode = oNode.Nodes.Add(strText)
        End If
        oNode.ImageIndex = IconIndex.oVarios
        oNode.SelectedImageIndex = IconIndex.oVarios

        oNode = Nothing
    End Sub
    Protected Overridable Sub PintarNodoVarios(ByVal strIDVarios As String, ByVal strDescVarios As String, _
                                 Optional ByVal oNode As TreeNode = Nothing)

        Dim strText As String = "Varios: " & strIDVarios & " - " & strDescVarios
        If oNode Is Nothing Then
            oNode = TvwObraCompleta.Nodes.Add(strText)
        Else
            oNode = oNode.Nodes.Add(strText)
        End If
        oNode.ImageIndex = IconIndex.oVarios
        oNode.SelectedImageIndex = IconIndex.oVarios

        oNode = Nothing
    End Sub
#End Region

#Region " Mediciones "
    Protected Overridable Sub PintarMediciones(ByVal dtMedicion() As DataRow, Optional ByVal oNode As TreeNode = Nothing)
        If Not dtMedicion Is Nothing AndAlso dtMedicion.Length > 0 Then
            oNode = oNode.Nodes.Add(ExpertisApp.Traslate("MEDICIONES"))
            oNode.ImageIndex = IconIndex.oMediciones
            oNode.SelectedImageIndex = IconIndex.oMediciones
            For Each drMedicion As DataRow In dtMedicion
                PintarNodoMediciones(drMedicion("DescMedicion") & String.Empty, Nz(drMedicion("QPI"), 0), Nz(drMedicion("Largo"), 0), _
                                     Nz(drMedicion("Ancho"), 0), Nz(drMedicion("Alto"), 0), Nz(drMedicion("Total"), 0), oNode)
            Next
            oNode = Nothing
        End If
    End Sub

    Protected Overridable Sub PintarNodoMediciones(ByVal strDescMedicion As String, ByVal dblQPI As Double, ByVal dblLargo As Double, ByVal dblAncho As Double, _
                                     ByVal dblAlto As Double, ByVal dblTotal As Double, Optional ByVal oNode As TreeNode = Nothing)

        Dim strText As String = "Descripción: " & strDescMedicion & " PI: " & dblQPI & " LARGO: " & dblLargo & " ANCHO: " & dblAncho & " ALTO: " & dblAlto & " TOTAL: " & dblTotal
        If oNode Is Nothing Then
            oNode = TvwObraCompleta.Nodes.Add(strText)
        Else
            oNode = oNode.Nodes.Add(strText)
        End If
        oNode.ImageIndex = IconIndex.oMediciones
        oNode.SelectedImageIndex = IconIndex.oMediciones

        oNode = Nothing
    End Sub
#End Region

#End Region

#Region " TABs "

    Protected Overridable Sub TabTrabajos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabTrabajos.Click
        Select Case TabTrabajos.SelectedTab.Key
            Case "Trabajos"
                If rbtVerGrid.Checked Then
                    VerFormatoGrid()
                ElseIf rbtVerFicha.Checked Then
                    VerFormatoFicha()
                ElseIf rbtVerProyectoCompleto.Checked Then
                    VerFormatoTrabajoCompleto()
                ElseIf RdTimeObras.Checked Then
                    VerFormatoTimeObras()
                End If
            Case "Previstos"
                TabPrevistos_Click(TabPrevistos, e)
            Case "Control"
                TabControl_Click(TabControl, e)
            Case "Hitos"
                FiltrarGrid(rbtHitosTrabajo.Checked, GridVencimientos)
                TotalesHitos(GridVencimientos, e)
                rbtMonedaCliente_CheckedChanged(GridVencimientos, e)

                GridVencimientos.AllowAddNew = IIf(Length(Me.CurrentRow("IDCliente")) = 0, InheritableBoolean.False, InheritableBoolean.True)
                GridVencimientos.AllowEdit = GridVencimientos.AllowAddNew
            Case "Tareas"
                FiltrarGrid(rbtTareasTrabajo.Checked, GridTareas)
            Case "Oficios"
                FiltrarGrid(rbtOperariosTrabajo.Checked, GridOperariosTrabajo, ndTrabajoOperario.Data)
            Case "Avance"
                FiltrarGrid(True, GridAvanceTrabajo, ndAvance.Data, , True)
        End Select
    End Sub

    Protected Overridable Sub VerFormatoGrid()
        BloquearGridTrabajo()
        FiltrarGridTrabajos()
        TotalTrabajos()
    End Sub

    Protected Overridable Sub VerFormatoFicha()
        cbxTipoLinea_ValueChanged(cbxTipoLinea, New EventArgs)
        cbxTipoFacturacion_ValueChanged(cbxTipoFacturacion, New EventArgs)
        BloquearFichaTrabajo()
    End Sub

    Protected Overridable Sub VerFormatoTrabajoCompleto()
        Dim Cancel As Boolean = False
        If TvwObraCompleta.Nodes.Count > 0 Then
            If ExpertisApp.GenerateMessage("¿Desea refrescar el árbol de la estructura completa del trabajo?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                Cancel = True
            End If
        End If
        If Not Cancel Then VerDatosTrabajoCompleto()
    End Sub

    Protected Overridable Sub TabPrevistos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPrevistos.Click
        FraTotalesPrev.Visible = (TabPrevistos.SelectedTab.Key <> "Mediciones")
        Select Case TabPrevistos.SelectedTab.Key
            Case "MaterialesPrev"
                FiltrarGrid(rbtPorNivelPrev.Checked, GridMaterialPrev, ndMateriales.Data, rbtPorMultinivelPrev.Checked)
                TotalesMaterialPrevisto(GridMaterialPrev, New EventArgs)
            Case "ModPrev"
                FiltrarGrid(rbtPorNivelPrev.Checked, GridMODPrev, ndMOD.Data, rbtPorMultinivelPrev.Checked)
                TotalesModPrevisto(GridMODPrev, New EventArgs)
            Case "CentrosPrev"
                FiltrarGrid(rbtPorNivelPrev.Checked, GridCentrosPrev, ndCentros.Data, rbtPorMultinivelPrev.Checked)
                TotalesCentrosPrevisto(GridCentrosPrev, New EventArgs)
            Case "GastosPrev"
                FiltrarGrid(rbtPorNivelPrev.Checked, GridGastosPrev, ndGastos.Data, rbtPorMultinivelPrev.Checked)
                TotalesGastosPrevisto(GridGastosPrev, New EventArgs)
            Case "VariosPrev"
                FiltrarGrid(rbtPorNivelPrev.Checked, GridVariosPrev, ndVarios.Data, rbtPorMultinivelPrev.Checked)
                TotalesVariosPrevisto(GridVariosPrev, New EventArgs)
            Case "Mediciones"
                FiltrarGrid(rbtPorNivelPrev.Checked, GridMediciones, ndMediciones.Data, rbtPorMultinivelPrev.Checked)
                TotalesMediciones(GridMediciones, New EventArgs)
        End Select
    End Sub

    Protected Overridable Sub TabControl_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl.Click
        FraTotalesReal.Visible = (TabControl.SelectedTab.Key <> "MedicionesCertificacion")
        Select Case TabControl.SelectedTab.Key
            Case "MaterialesControl"
                FiltrarGrid(rbtNivelControl.Checked, GridMaterialControl, rbtMultinivelControl.Checked)
                TotalesMaterialControl(GridMaterialControl, New EventArgs)
            Case "ModControl"
                FiltrarGrid(rbtNivelControl.Checked, GridMODControl, rbtMultinivelControl.Checked)
                TotalesMODControl(GridMODControl, New EventArgs)
            Case "CentrosControl"
                FiltrarGrid(rbtNivelControl.Checked, GridCentroControl, rbtMultinivelControl.Checked)
                TotalesCentrosControl(GridCentroControl, New EventArgs)
            Case "GastosControl"
                FiltrarGrid(rbtNivelControl.Checked, GridGastosControl, rbtMultinivelControl.Checked)
                TotalesGastosControl(GridGastosControl, New EventArgs)
            Case "VariosControl"
                FiltrarGrid(rbtNivelControl.Checked, GridVariosControl, rbtMultinivelControl.Checked)
                TotalesVariosControl(GridVariosControl, New EventArgs)
            Case "MedicionesCertificacion"
                cbxTipoCertificacion.Enabled = (GridCertificacion.RowCount = 0)
                FiltrarGridCertificaciones()
        End Select
    End Sub

    Protected Overridable Sub ChangeDefaultViewGrid(ByVal blnPorTrabajo As Boolean, ByVal GridAux As Solmicro.Expertis.Engine.UI.Grid)
        If blnPorTrabajo AndAlso Not IsNothing(drTrabajos) AndAlso Nz(drTrabajos("TipoLinea"), 0) = enumTipoLineaTrabajo.tltTrabajo Then
            If Length(drTrabajos("IDTrabajo")) > 0 Then GridAux.Columns("IDTrabajo").DefaultValue = drTrabajos("IDTrabajo")
            If Length(drTrabajos("CodTrabajo")) > 0 Then GridAux.Columns("CodTrabajo").DefaultValue = drTrabajos("CodTrabajo")
        Else
            GridAux.Columns("IDTrabajo").DefaultValue = DBNull.Value
            GridAux.Columns("CodTrabajo").DefaultValue = DBNull.Value
        End If
    End Sub

    Protected Overridable Sub BloquearFichaTrabajo()
        If rbtVerFicha.Checked Then
            Dim blnBloqueado As Boolean = cbxEstado.Value = enumocEstado.ocTerminado
            BloquearInformacion(TabPageTrabajos, blnBloqueado, txtQReal, txtPrevistoTrabajo, txtPrevistoVentaTrabajo, txtRealTrabajo, txtFacturadoTrabajo, rbtMaximizarTree, rbtMinimizarTree, cbxEstadoDistintoDE, rbtVerFicha, rbtVerGrid, rbtPorTrabajosObra, rbtPorNivelTrabajos, rbtPorMultinivelTrabajos, rbtPrevObra, rbtPorNivelPrev, rbtPorMultinivelPrev, rbtControlObra, rbtNivelControl, rbtMultinivelControl, rbtHitosObra, rbtHitosTrabajo, rbtTareasObra, rbtTareasTrabajo, rbtOperariosObra, rbtOperariosTrabajo, rbtMonedaCliente, rbtMonedaA)
            If Not blnBloqueado Then chkNoAcumular_CheckedChanged(chkNoAcumular, New EventArgs)
            txtAvanceCalculado.Enabled = False
            If Not Me.CurrentRow Is Nothing Then
                chkFacturable.Enabled = Length(Me.CurrentRow("IDCliente")) > 0
            Else
                chkFacturable.Enabled = False
            End If
        End If
    End Sub

    Protected Overridable Sub BloquearGridTrabajo()
        If Length(AdvIDTipoObra.Value) = 0 OrElse Length(AdvIDCliente.Value) = 0 OrElse cbxEstado.Value = enumocEstado.ocTerminado OrElse rbtPorMultinivelTrabajos.Checked Then
            GridTrabajos.AllowAddNew = InheritableBoolean.False
        Else
            GridTrabajos.AllowAddNew = InheritableBoolean.True
        End If
    End Sub

#End Region

#Region " Filtrar Grid "

    Protected Overridable Sub FiltrarGridTrabajos()
        If Me.RecordsState <> RecordsState.Initialize Then
            Dim dv As New DataView(dtTrabajos)
            Dim f As New Filter
            f.Add(New NumberFilterItem("IDObra", Me.CurrentRow("IDObra")))
            If Not IsNothing(dtTrabajos) AndAlso dtTrabajos.Rows.Count > 0 Then
                If Length(cbxEstadoDistintoDE.Value) > 0 Then
                    f.Add("Estado", FilterOperator.NotEqual, cbxEstadoDistintoDE.Value)
                End If
                If Not chkVerPorcentajes.Checked Then
                    f.Add(New NumberFilterItem("TipoLinea", FilterOperator.NotEqual, enumTipoLineaTrabajo.tltPorcentajeConcepto))
                End If
                If Not IsNothing(drTrabajos) Then
                    If rbtPorNivelTrabajos.Checked AndAlso Length(drTrabajos("IDTrabajo")) > 0 Then
                        f.Add(New NumberFilterItem("IDTrabajoPadre", drTrabajos("IDTrabajo")))
                    ElseIf rbtPorMultinivelTrabajos.Checked Then
                        If mblnAplicarMultinivel Then
                            If Length(drTrabajos("Hijos")) > 0 Then
                                f.Add(New InListFilterItem("IDTrabajo", Split(drTrabajos("Hijos"), ",", ), FilterType.Numeric))
                            Else
                                f.Add(New NoRowsFilterItem)
                            End If
                        Else
                            If Length(drTrabajos("IDTrabajo")) > 0 Then f.Add(New NumberFilterItem("IDTrabajo", FilterOperator.NotEqual, drTrabajos("IDTrabajo")))
                            If Length(drTrabajos("IDTipoTrabajo")) > 0 Then f.Add(New StringFilterItem("IDTipoTrabajo", drTrabajos("IDTipoTrabajo")))
                            If Length(drTrabajos("IDSubTipoTrabajo")) > 0 Then f.Add(New StringFilterItem("IDSubTipoTrabajo", drTrabajos("IDSubTipoTrabajo")))
                            If Length(drTrabajos("SubSubTipoTrabajo")) > 0 Then f.Add(New StringFilterItem("SubSubTipoTrabajo", drTrabajos("SubSubTipoTrabajo")))
                        End If
                    End If
                End If

                dv.RowFilter = f.Compose(New AdoFilterComposer)
                dv.Sort = "Secuencia, CodTrabajo"
                GridTrabajos.DataSource = dv
            Else
                dv.RowFilter = f.Compose(New AdoFilterComposer)
                GridTrabajos.DataSource = dv
            End If
            If rbtPorNivelTrabajos.Checked Then GridTrabajos_GotFocus(GridTrabajos, New EventArgs)
        End If
    End Sub

    Protected Overridable Sub FiltrarGrid(ByVal blnPorTrabajo As Boolean, ByVal GridAux As Solmicro.Expertis.Engine.UI.Grid, _
                            ByVal dtConcepto As DataTable, Optional ByVal blnPorMultiNivelTrabajo As Boolean = False, _
                            Optional ByVal blnAvanceTrabajo As Boolean = False)

        If Me.RecordsState <> RecordsState.Initialize Then
            Dim dv As New DataView(dtConcepto)
            Dim f As New Filter
            If Not blnAvanceTrabajo Then f.Add(New NumberFilterItem("IDObra", Me.CurrentRow("IDObra")))
            If Not IsNothing(dtConcepto) AndAlso dtConcepto.Rows.Count > 0 Then
                Dim blnIncrementos As Boolean = False
                Select Case TabTrabajos.SelectedTab.Key
                    Case "Materiales", "Mod", "Centros"
                        blnIncrementos = True
                End Select
                If Not chkVerPorcentajes.Checked And blnIncrementos Then
                    f.Add(New NumberFilterItem("TipoIncremento", FilterOperator.NotEqual, enumSiNo.Si))
                End If
                If Not drTrabajos Is Nothing Then
                    If blnPorTrabajo AndAlso Length(drTrabajos("IDTrabajo")) > 0 Then
                        f.Add(New NumberFilterItem("IDTrabajo", drTrabajos("IDTrabajo")))
                    ElseIf blnPorMultiNivelTrabajo Then
                        If mblnAplicarMultinivel Then
                            Dim f_OR As New Filter(FilterUnionOperator.Or)
                            f_OR.Add(New NumberFilterItem("IDTrabajo", drTrabajos("IDTrabajo")))
                            If Length(drTrabajos("Hijos")) > 0 Then
                                f_OR.Add(New InListFilterItem("IDTrabajo", Split(drTrabajos("Hijos"), ",", ), FilterType.Numeric))
                            End If
                            f.Add(f_OR)
                        Else
                            If Length(drTrabajos("IDTrabajo")) > 0 Then f.Add(New NumberFilterItem("IDTrabajo", FilterOperator.NotEqual, drTrabajos("IDTrabajo")))
                            If Length(drTrabajos("IDTipoTrabajo")) > 0 Then f.Add(New StringFilterItem("IDTipoTrabajo", drTrabajos("IDTipoTrabajo")))
                            If Length(drTrabajos("IDSubTipoTrabajo")) > 0 Then f.Add(New StringFilterItem("IDSubTipoTrabajo", drTrabajos("IDSubTipoTrabajo")))
                            If Length(drTrabajos("SubSubTipoTrabajo")) > 0 Then f.Add(New StringFilterItem("SubsubTipoTrabajo", drTrabajos("SUbSubTipoTrabajo")))
                        End If
                    End If
                End If

                dv.RowFilter = f.Compose(New AdoFilterComposer)
                If blnAvanceTrabajo Then
                    dv.Sort = "Periodo"
                Else
                    If blnIncrementos Then
                        dv.Sort = "Secuencia, CodTrabajo"
                    Else
                        dv.Sort = "CodTrabajo"
                    End If
                End If
                GridAux.DataSource = dv
            Else
                dv.RowFilter = f.Compose(New AdoFilterComposer)
                GridAux.DataSource = dv

                If GridAux.EntityName <> GridAvanceTrabajo.EntityName Then
                    Dim blnEnabled As Boolean = IsNothing(dtTrabajos) OrElse dtTrabajos.Rows.Count = 0
                    If GridAux.EntityName <> GridMODControl.EntityName AndAlso GridAux.EntityName <> GridMaterialControl.EntityName AndAlso _
                    GridAux.EntityName <> GridCentroControl.EntityName AndAlso GridAux.EntityName <> GridGastosControl.EntityName AndAlso _
                    GridAux.EntityName <> GridVariosControl.EntityName AndAlso GridAux.EntityName <> GridTareas.EntityName Then
                        GridAux.AllowAddNew = IIf(blnEnabled, InheritableBoolean.False, InheritableBoolean.True)
                    End If
                End If
            End If
            ChangeDefaultViewGrid(blnPorTrabajo, GridAux)
        End If
    End Sub

    Protected Overridable Sub FiltrarGrid(ByVal blnPorTrabajo As Boolean, ByVal GridAux As Solmicro.Expertis.Engine.UI.Grid, _
                            Optional ByVal blnPorMultiNivelTrabajo As Boolean = False)

        Dim dtConcepto As DataTable
        If TypeOf GridAux.DataSource Is DataView Then
            dtConcepto = CType(GridAux.DataSource, DataView).Table
        Else
            dtConcepto = CType(GridAux.DataSource, DataTable)
        End If
        FiltrarGrid(blnPorTrabajo, GridAux, dtConcepto, blnPorMultiNivelTrabajo)
    End Sub

#End Region

#Region " Pestaña Previstos "

    Protected Overridable Sub PrevistosChecked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtPrevObra.CheckedChanged, rbtPorNivelPrev.CheckedChanged, rbtPorMultinivelPrev.CheckedChanged
        If Not IsNothing(dtTrabajos) AndAlso dtTrabajos.Rows.Count > 0 Then
            pnlVerPrevistos.Visible = (rbtPorNivelPrev.Checked Or rbtPorMultinivelPrev.Checked)
            If Not IsNothing(Me.CurrentData) AndAlso Not blnChecked Then
                CheckedAll()
                TabPrevistos_Click(TabPrevistos, New System.EventArgs)
            End If
        End If
    End Sub

    Protected Overridable Function ValidarTipoFacturacionTrabajo(ByVal IDTrabajo As Integer, ByVal TipoFacturacion As enumotTipoFacturacion) As Boolean
        Dim blnOK As Boolean
        If Not IsNothing(dtTrabajos) AndAlso dtTrabajos.Rows.Count > 0 Then
            Dim dv As DataView = dtTrabajos.DefaultView
            dv.RowFilter = "IDTrabajo=" & IDTrabajo
            If dv.Count > 0 Then
                blnOK = (Nz(dtTrabajos.DefaultView(0).Row("TipoFacturacion"), 0) = TipoFacturacion)
            End If
        End If

        Return blnOK
    End Function
    Protected Overridable Function ValidarTipoFacturacionTrabajoConcepto(ByVal IDTrabajoPadre As Integer) As Boolean
        Dim blnOK As Boolean
        If Not IsNothing(dtTrabajos) AndAlso dtTrabajos.Rows.Count > 0 Then
            Dim dv As DataView = dtTrabajos.DefaultView
            dv.RowFilter = "IDTrabajo=" & IDTrabajoPadre
            If dv.Count > 0 Then
                If dtTrabajos.DefaultView(0).Row("Tipolinea") = enumTipoLineaTrabajo.tltTrabajo And Nz(dtTrabajos.DefaultView(0).Row("TipoFacturacion"), 0) = enumotTipoFacturacion.otfPorConceptos And dtTrabajos.DefaultView(0).Row("Facturable") = True Then
                    blnOK = True
                ElseIf dtTrabajos.DefaultView(0).Row("Tipolinea") = enumTipoLineaTrabajo.tltCapitulo Then
                    blnOK = True
                End If
            End If
        End If

        Return blnOK
    End Function

    Protected Overridable Sub CargarFormVencimientos()
        Dim Grid As Solmicro.Expertis.Engine.UI.Grid
        Dim intClaseVto As enumottfClaseVencimiento

        Select Case TabPrevistos.SelectedTab.Key
            Case "MaterialesPrev"
                Grid = GridMaterialPrev
                intClaseVto = enumottfClaseVencimiento.ottfMaterial
            Case "MODPrev"
                Grid = GridMODPrev
                intClaseVto = enumottfClaseVencimiento.ottfMod
            Case "CentrosPrev"
                Grid = GridCentrosPrev
                intClaseVto = enumottfClaseVencimiento.ottfCentro
            Case "GastosPrev"
                Grid = GridGastosPrev
                intClaseVto = enumottfClaseVencimiento.ottfGasto
            Case "VariosPrev"
                Grid = GridVariosPrev
                intClaseVto = enumottfClaseVencimiento.ottfVarios
        End Select
        With Grid
            If ValidarTipoFacturacionTrabajo(.Value("IDTrabajo"), enumotTipoFacturacion.otfPorConceptos) Then
                If Grid.Value("Facturable") Then
                    If intClaseVto = enumottfClaseVencimiento.ottfCentro OrElse intClaseVto = enumottfClaseVencimiento.ottfVarios OrElse Nz(.Value("TipoFacturacion")) = enumomTipoFacturacion.omPorVencimientos Then
                        Dim oRow As DataRowView = .SelectedItems(0).GetRow.DataRow
                        Dim frm As New FrmGeneraVencimientos
                        frm.QPrevTrabajo = drTrabajos("QPrev")
                        frm.AbrirGeneracionVencimientos(oRow.Row, Me.CurrentRow, intClaseVto, Me)
                        Me.RequeryData()
                    Else
                        ExpertisApp.GenerateMessage("La línea seleccionada no es facturable por Hitos de Facturación.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                Else
                    ExpertisApp.GenerateMessage("La línea seleccionada no es facturable.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                ExpertisApp.GenerateMessage("La línea seleccionada es facturable por trabajo completo.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End With
    End Sub

#Region " Search TipoIncremento "

    Protected Overridable Sub OpenSearchTipoIncremento()
        If IsNothing(sctTipoIncremento) Then
            sctTipoIncremento = New AdvancedSearch
            sctTipoIncremento.EntityName = "ObraTrabajo"
        End If
        sctTipoIncremento.Open()
    End Sub

    Protected Overridable Sub sctTipoIncremento_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles sctTipoIncremento.SetPredefinedFilter
        If Length(Me.CurrentRow("IDObra")) > 0 Then
            e.Filter.Add(New NumberFilterItem("IDObra", Me.CurrentRow("IDObra")))
        Else
            e.Filter.Add(New StringFilterItem("1", 2))
        End If
        e.Filter.Add(New NumberFilterItem("TipoLinea", enumTipoLineaTrabajo.tltPorcentajeConcepto))
    End Sub

    Protected Overridable Sub sctTipoIncremento_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles sctTipoIncremento.SelectionChanged
        Dim grid As Expertis.Engine.UI.Grid
        Select Case TabTrabajos.SelectedTab.Key
            Case "Materiales"
                grid = GridMaterialPrev
                grid.SetValue("DescMaterial", e.Selected.Rows(0)("DescTrabajo"))
                grid.SetValue("QUnidad", 1)
                grid.SetValue("QPrev", 1)
            Case "Mod"
                grid = GridMODPrev
                grid.SetValue("DescCategoria", e.Selected.Rows(0)("DescTrabajo"))
                grid.SetValue("HorasUnidad", 1)
                grid.SetValue("HorasPrevMod", 1)
            Case "Centros"
                grid = GridCentrosPrev
                grid.SetValue("DescCentro", e.Selected.Rows(0)("DescTrabajo"))
                grid.SetValue("HorasUnidad", 1)
                grid.SetValue("HorasPrevCentro", 1)
        End Select
        grid.SetValue("IDTrabajoIncremento", e.Selected.Rows(0)("IDTrabajo"))
        grid.SetValue("Incremento", e.Selected.Rows(0)("ImpPrevTrabajoA") * 100)
        grid.SetValue("TipoIncremento", enumSiNo.Si)
    End Sub

#End Region

    Protected Overridable Function ValidaADDIncrementos(ByVal Grid As Solmicro.Expertis.Engine.UI.Grid) As Boolean
        Dim blnCancel As Boolean
        Dim dv As DataView
        Select Case Grid.EntityName
            Case ndMateriales.EntityName
                dv = (ndMateriales.Data.Copy.DefaultView)
            Case ndMOD.EntityName
                dv = (ndMOD.Data.Copy.DefaultView)
            Case ndCentros.EntityName
                dv = (ndCentros.Data.Copy.DefaultView)
        End Select

        Dim f As New Filter
        f.Add(New NumberFilterItem("IDTrabajo", Grid.Value("IDTrabajo")))
        f.Add(New BooleanFilterItem("TipoIncremento", True))
        f.Add(New NumberFilterItem("IDTrabajoIncremento", Grid.Value("IDTrabajoIncremento")))

        dv.RowFilter = f.Compose(New AdoFilterComposer)
        If dv.Count > 0 Then
            blnCancel = True
            ExpertisApp.GenerateMessage("Ya existe este incremento para este trabajo.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        Return blnCancel
    End Function

#Region " Grid Materiales Previstos "

    Protected Overridable Sub GridMaterialPrev_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridMaterialPrev.GotFocus
        With GridMaterialPrev
            .Columns("IDObra").DefaultValue = Me.CurrentRow("IDObra")
            .Columns("PrecioPrevMatA").DefaultValue = 0
            .Columns("PrecioVentaA").DefaultValue = 0
            .Columns("ImpPrevMatA").DefaultValue = 0
            .Columns("ImpPrevMatVentaA").DefaultValue = 0
            .Columns("QUnidad").DefaultValue = 0
            .Columns("QPrev").DefaultValue = 0
            .Columns("Dto1").DefaultValue = 0
            .Columns("Dto2").DefaultValue = 0
            .Columns("Dto3").DefaultValue = 0
            .Columns("DtoVenta1").DefaultValue = 0
            .Columns("DtoVenta2").DefaultValue = 0
            .Columns("DtoVenta3").DefaultValue = 0
            .Columns("EstadoFactura").DefaultValue = CInt(enumomEstadoFactura.omNoFacturado)
            .Columns("Estado").DefaultValue = CInt(enumomEstado.omPendiente)
            .Columns("UdValoracion").DefaultValue = 1
            .Columns("Facturable").DefaultValue = False
            .Columns("Manual").DefaultValue = False
            If rbtPorNivelPrev.Checked AndAlso Not drTrabajos Is Nothing AndAlso (Nz(drTrabajos("TipoLinea"), 0) = enumTipoLineaTrabajo.tltTrabajo Or Nz(drTrabajos("TipoLinea"), 0) = enumTipoLineaTrabajo.tltTrabajoConcepto) Then
                If Length(drTrabajos("IDTrabajo")) > 0 Then .Columns("IDTrabajo").DefaultValue = drTrabajos("IDTrabajo")
                If Length(drTrabajos("CodTrabajo")) > 0 Then .Columns("CodTrabajo").DefaultValue = drTrabajos("CodTrabajo")
                If Length(drTrabajos("QPrev")) > 0 Then .Columns("QPrevTrabajo").DefaultValue = drTrabajos("QPrev")
                If Length(drTrabajos("Facturable")) > 0 AndAlso drTrabajos("TipoFacturacion") = enumotTipoFacturacion.otfPorConceptos Then
                    .Columns("Facturable").DefaultValue = drTrabajos("Facturable")
                End If
            Else
                .Columns("IDTrabajo").DefaultValue = DBNull.Value
                .Columns("CodTrabajo").DefaultValue = DBNull.Value
                .Columns("QPrevTrabajo").DefaultValue = DBNull.Value
            End If
            '.Columns("Facturable").DefaultValue = Length(Me.CurrentRow("IDCliente")) > 0
            .Columns("Expedible").DefaultValue = Length(Me.CurrentRow("IDCliente")) > 0
            .Columns("TipoIncremento").DefaultValue = CInt(enumSiNo.No)
        End With
    End Sub

    Protected Overridable Sub GridMaterialPrev_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridMaterialPrev.Click
        With GridMaterialPrev
            If .Row <> -1 Then
                Dim hit As GridArea = .HitTest()
                If hit = GridArea.Cell Or hit = GridArea.NewRowCell Then
                    Dim c As GridEXColumn = .ColumnFromPoint()
                    If Not IsNothing(c) Then
                        Select Case c.Key
                            Case "Vencimiento"
                                CargarFormVencimientos()
                            Case "IDTrabajoIncremento"
                                If .Value("TipoIncremento") Then
                                    OpenSearchTipoIncremento()
                                End If
                        End Select
                    End If
                End If
            End If
        End With
    End Sub

    Protected Overridable Sub GridMaterialPrev_EditingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles GridMaterialPrev.EditingCell
        With GridMaterialPrev
            If Nz(.Value("TipoIncremento")) = enumSiNo.Si Then
                If e.Column.Key <> "Secuencia" And e.Column.Key <> "IDTrabajoIncremento" Then
                    e.Cancel = True
                    .Columns(e.Column.Key).ButtonStyle = Janus.Windows.GridEX.ButtonStyle.NoButton
                End If
            Else
                Select Case e.Column.Key
                    Case "IDProveedor"
                        If Length(.Value("IDMaterial")) = 0 Then
                            e.Cancel = True
                            .Columns("IDProveedor").ButtonStyle = ButtonStyle.NoButton
                        Else
                            .Columns("IDProveedor").ButtonStyle = ButtonStyle.Image
                        End If
                    Case "TipoIncremento"
                        If .Row <> Grid.newTopRowPosition Then e.Cancel = True
                    Case "Facturable"
                        If Length(Me.CurrentRow("IDCliente")) = 0 OrElse Length(.Value("IDTrabajo")) = 0 Then
                            e.Cancel = True
                        ElseIf ValidarTipoFacturacionTrabajo(.Value("IDTrabajo"), enumotTipoFacturacion.otfPorConceptos) Then
                            .Columns("Facturable").EditType = Janus.Windows.GridEX.EditType.CheckBox
                        Else
                            e.Cancel = True
                        End If
                    Case "Expedible"
                        e.Cancel = (Length(Me.CurrentRow("IDCliente")) = 0)
                    Case "CodTrabajo"
                        If .Row <> Grid.newTopRowPosition AndAlso Length(.Value("CodTrabajo")) > 0 Then
                            e.Cancel = True
                            .Columns("CodTrabajo").ButtonStyle = ButtonStyle.NoButton
                        Else
                            .Columns("CodTrabajo").ButtonStyle = ButtonStyle.Image
                        End If
                    Case "QPrev"
                        If Not .Value("Manual") Then e.Cancel = True
                    Case "MargenPrev"
                        If Nz(.Value("DtoVenta1"), 0) > 0 OrElse Nz(.Value("DtoVenta2"), 0) > 0 OrElse Nz(.Value("DtoVenta3"), 0) > 0 Then e.Cancel = True
                End Select
            End If
        End With

    End Sub

    Protected Overridable Sub GridMaterialPrev_AddingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GridMaterialPrev.AddingRecord
        If Length(GridMaterialPrev.Value("CodTrabajo")) = 0 Then
            e.Cancel = True
            ExpertisApp.GenerateMessage("El Trabajo es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf GridMaterialPrev.Value("TipoIncremento") Then
            e.Cancel = ValidaADDIncrementos(GridMaterialPrev)
        End If
    End Sub

    Protected Overridable Sub GridMaterialPrev_UpdatingRecord(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GridMaterialPrev.UpdatingRecord
        With GridMaterialPrev
            If .RowCount > 0 Then
                Dim CC As New AltaPlanContable
                If Length(.GetValue("CCVenta")) > 0 Then
                    e.Cancel = Not CC.ValidaCuentaContable(.Value("CCVenta"), mstrEjercicioActual)
                End If
                If Length(.GetValue("CCCompra")) > 0 Then
                    e.Cancel = Not CC.ValidaCuentaContable(.Value("CCCompra"), mstrEjercicioActual)
                End If
                If Not e.Cancel Then
                    If Length(.GetValue("CodTrabajo")) = 0 Then
                        e.Cancel = True
                        ExpertisApp.GenerateMessage("El Trabajo es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                End If
            End If
        End With
    End Sub

    Protected Overridable Sub GridMaterialPrev_AdvSearchSetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.GridAdvSearchFilterEventArgs) Handles GridMaterialPrev.AdvSearchSetPredefinedFilter
        With GridMaterialPrev
            Select Case e.Key
                Case "CodTrabajo"
                    e.Filter.Add("IdObra", FilterOperator.Equal, Me.CurrentRow("IDObra"), FilterType.Numeric)
                    Dim eor As New Filter(FilterUnionOperator.Or)
                    eor.Add("TipoLinea", FilterOperator.Equal, enumTipoLineaTrabajo.tltTrabajo, FilterType.Numeric)
                    eor.Add("TipoLinea", FilterOperator.Equal, enumTipoLineaTrabajo.tltTrabajoConcepto, FilterType.Numeric)
                    e.Filter.Add(eor)
                Case "CCVenta", "CCCompra"
                    e.Filter.Add("IDEjercicio", FilterOperator.Equal, mstrEjercicioActual, FilterType.String)
                Case "IDMaterial"
                    e.Filter.Add(New BooleanFilterItem("Activo", FilterOperator.Equal, True))
            End Select
        End With



    End Sub

    Protected Overridable Sub GridMaterialPrev_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles GridMaterialPrev.FormattingRow
        With GridMaterialPrev
            If e.Row.RowType = RowType.Record Then
                If Nz(e.Row.Cells("TipoIncremento").Value) Then
                    e.Row.RowStyle = .FormatStyles("IncrementoFormatStyle")
                    e.Row.Cells("IDTrabajoIncremento").ImageIndex = 0
                    For Each dc As DataColumn In ndMateriales.Data.Columns
                        If dc.ColumnName <> "Secuencia" And dc.ColumnName <> "CodTrabajo" And _
                           dc.ColumnName <> "DescMaterial" And dc.ColumnName <> "TipoIncremento" And _
                           dc.ColumnName <> "IDTrabajoIncremento" And dc.ColumnName <> "ImpPrevMatVentaA" Then
                            If e.Row.Table.Columns.Contains(dc.ColumnName) Then
                                e.Row.Cells(dc.ColumnName).Text = String.Empty
                            End If
                        End If
                    Next
                End If
            End If
        End With
    End Sub

    Protected Overridable Sub TotalesMaterialPrevisto(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridMaterialPrev.RecordAdded, GridMaterialPrev.RecordUpdated, GridMaterialPrev.RecordsDeleted
        With GridMaterialPrev
            txtTotalPrev.Value = xRound(.GetTotal(.Columns("ImpPrevMatA"), Janus.Windows.GridEX.AggregateFunction.Sum), mintRedondeoA)
            txtTotalPrevVenta.Value = xRound(.GetTotal(.Columns("ImpPrevMatVentaA"), Janus.Windows.GridEX.AggregateFunction.Sum), mintRedondeoA)
            txtTotalReal.Value = xRound(.GetTotal(.Columns("ImpRealMatA"), Janus.Windows.GridEX.AggregateFunction.Sum), mintRedondeoA)
            txtTotalFacturado.Value = xRound(.GetTotal(.Columns("ImpFactMatA"), Janus.Windows.GridEX.AggregateFunction.Sum), mintRedondeoA)
        End With
    End Sub

    Protected Overridable Sub GridMaterialPrev_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridMaterialPrev.MouseUp
        If e.Button = MouseButtons.Right Then
            If Not IsNothing(GridMaterialPrev) AndAlso GridMaterialPrev.RowCount > 0 Then
                If Length(GridMaterialPrev.Value("IDMaterial")) > 0 Then
                    GridMaterialPrev.UiCommandManager1.Commands(cnABRIRMATERIAL).Visible = InheritableBoolean.True
                Else
                    GridMaterialPrev.UiCommandManager1.Commands(cnABRIRMATERIAL).Visible = InheritableBoolean.False
                End If
                If Length(GridMaterialPrev.Value("IDLineaMaterialPadre")) = 0 Then
                    GridMaterialPrev.UiCommandManager1.Commands(cnIMPORTARESTRUCTURA).Visible = InheritableBoolean.True
                Else
                    GridMaterialPrev.UiCommandManager1.Commands(cnIMPORTARESTRUCTURA).Visible = InheritableBoolean.False
                End If
            End If
        End If
    End Sub

#End Region

#Region " Grid MOD Previstos "

    Protected Overridable Sub GridMODPrev_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridMODPrev.GotFocus
        With GridMODPrev
            .Columns("IDObra").DefaultValue = Me.CurrentRow("IDObra")
            .Columns("EstadoFactura").DefaultValue = CInt(enumomodEstadoFactura.omodNoFacturado)
            .Columns("Estado").DefaultValue = CInt(enumomodEstado.omodPendiente)
            .Columns("IDHora").DefaultValue = mstrIDHora
            .Columns("DesHora").DefaultValue = mstrDescHora
            .Columns("Facturable").DefaultValue = False
            .Columns("Manual").DefaultValue = False
            If rbtPorNivelPrev.Checked AndAlso Not IsNothing(drTrabajos) AndAlso (Nz(drTrabajos("TipoLinea"), 0) = enumTipoLineaTrabajo.tltTrabajo Or Nz(drTrabajos("TipoLinea"), 0) = enumTipoLineaTrabajo.tltTrabajoConcepto) Then
                If Length(drTrabajos("IDTrabajo")) > 0 Then .Columns("IDTrabajo").DefaultValue = drTrabajos("IDTrabajo")
                If Length(drTrabajos("CodTrabajo")) > 0 Then .Columns("CodTrabajo").DefaultValue = drTrabajos("CodTrabajo")
                If Length(drTrabajos("QPrev")) > 0 Then .Columns("QPrevTrabajo").DefaultValue = drTrabajos("QPrev")
                If Length(drTrabajos("Facturable")) > 0 AndAlso drTrabajos("TipoFacturacion") = enumotTipoFacturacion.otfPorConceptos Then
                    .Columns("Facturable").DefaultValue = drTrabajos("Facturable")
                End If
            Else
                .Columns("IDTrabajo").DefaultValue = DBNull.Value
                .Columns("CodTrabajo").DefaultValue = DBNull.Value
                .Columns("QPrevTrabajo").DefaultValue = DBNull.Value
            End If
            '.Columns("Facturable").DefaultValue = Length(Me.CurrentRow("IDCliente")) > 0
            .Columns("TipoIncremento").DefaultValue = CInt(enumSiNo.No)
        End With
    End Sub

    Protected Overridable Sub GridMODPrev_AddingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GridMODPrev.AddingRecord
        If Length(GridMODPrev.Value("CodTrabajo")) = 0 Then
            e.Cancel = True
            ExpertisApp.GenerateMessage("El Trabajo es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf GridMODPrev.Value("TipoIncremento") Then
            e.Cancel = ValidaADDIncrementos(GridMODPrev)
        End If
    End Sub

    Protected Overridable Sub GridMODPrev_UpdatingRecord(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GridMODPrev.UpdatingRecord
        With GridMODPrev
            If .RowCount > 0 Then
                If Length(.Value("CodTrabajo")) = 0 Then
                    e.Cancel = True
                    ExpertisApp.GenerateMessage("El Trabajo es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If
        End With
    End Sub

    Protected Overridable Sub GridMODPrev_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridMODPrev.Click
        Dim hit As GridArea
        With GridMODPrev
            If .Row <> -1 Then
                hit = .HitTest()
                If hit = GridArea.Cell Or hit = GridArea.NewRowCell Then
                    Dim c As GridEXColumn = .ColumnFromPoint()
                    If Not IsNothing(c) Then
                        Select Case c.Key
                            Case "Vencimiento"
                                CargarFormVencimientos()
                            Case "IDTrabajoIncremento"
                                If .Value("TipoIncremento") Then
                                    OpenSearchTipoIncremento()
                                End If
                        End Select
                    End If
                End If
            End If
        End With
    End Sub

    Protected Overridable Sub GridMODPrev_EditingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles GridMODPrev.EditingCell
        With GridMODPrev
            If Nz(.Value("TipoIncremento")) = enumSiNo.Si Then
                If e.Column.Key <> "Secuencia" And e.Column.Key <> "IDTrabajoIncremento" Then
                    e.Cancel = True
                    .Columns(e.Column.Key).ButtonStyle = Janus.Windows.GridEX.ButtonStyle.NoButton
                End If
            Else
                Select Case e.Column.Key
                    Case "TipoIncremento"
                        If .Row <> Grid.newTopRowPosition Then e.Cancel = True
                    Case "Facturable"
                        If Length(Me.CurrentRow("IDCliente")) = 0 OrElse Length(.Value("IDTrabajo")) = 0 Then
                            e.Cancel = True
                        ElseIf ValidarTipoFacturacionTrabajo(.Value("IDTrabajo"), enumotTipoFacturacion.otfPorConceptos) Then
                            .Columns("Facturable").EditType = Janus.Windows.GridEX.EditType.CheckBox
                        Else
                            e.Cancel = True
                        End If
                    Case "CodTrabajo"
                        If .Row <> Grid.newTopRowPosition AndAlso Length(.Value("CodTrabajo")) > 0 Then
                            e.Cancel = True
                            .Columns("CodTrabajo").ButtonStyle = ButtonStyle.NoButton
                        Else
                            .Columns("CodTrabajo").ButtonStyle = ButtonStyle.Image
                        End If
                    Case "HorasPrevMOD"
                        If .Value("Manual") Then e.Cancel = True
                End Select
            End If
        End With
    End Sub

    Protected Overridable Sub GridMODPrev_AdvSearchSetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.GridAdvSearchFilterEventArgs) Handles GridMODPrev.AdvSearchSetPredefinedFilter
        With GridMODPrev
            Select Case e.Key
                Case "CodTrabajo"
                    e.Filter.Add("IdObra", FilterOperator.Equal, Me.CurrentRow("IDObra"), FilterType.Numeric)
                    Dim eor As New Filter(FilterUnionOperator.Or)
                    eor.Add("TipoLinea", FilterOperator.Equal, enumTipoLineaTrabajo.tltTrabajo, FilterType.Numeric)
                    eor.Add("TipoLinea", FilterOperator.Equal, enumTipoLineaTrabajo.tltTrabajoConcepto, FilterType.Numeric)
                    e.Filter.Add(eor)
            End Select
        End With
    End Sub

    Protected Overridable Sub GridMODPrev_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles GridMODPrev.FormattingRow
        With GridMODPrev
            If e.Row.RowType = RowType.Record Then
                If Nz(e.Row.Cells("TipoIncremento").Value) Then
                    e.Row.RowStyle = .FormatStyles("IncrementoFormatStyle")
                    e.Row.Cells("IDTrabajoIncremento").ImageIndex = 0
                    For Each dc As DataColumn In ndMOD.Data.Columns
                        If dc.ColumnName <> "Secuencia" And dc.ColumnName <> "CodTrabajo" And _
                           dc.ColumnName <> "DescCategoria" And dc.ColumnName <> "DesHora" And _
                           dc.ColumnName <> "TipoIncremento" And dc.ColumnName <> "IDTrabajoIncremento" And _
                           dc.ColumnName <> "ImpPrevModVentaA" Then
                            If e.Row.Table.Columns.Contains(dc.ColumnName) Then
                                e.Row.Cells(dc.ColumnName).Text = String.Empty
                            End If
                        End If
                    Next
                End If
            End If
        End With
    End Sub

    Protected Overridable Sub TotalesModPrevisto(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridMODPrev.RecordAdded, GridMODPrev.RecordUpdated, GridMODPrev.RecordsDeleted
        With GridMODPrev
            txtTotalPrev.Value = xRound(.GetTotal(.Columns("ImpPrevModA"), Janus.Windows.GridEX.AggregateFunction.Sum), mintRedondeoA)
            txtTotalPrevVenta.Value = xRound(.GetTotal(.Columns("ImpPrevModVentaA"), Janus.Windows.GridEX.AggregateFunction.Sum), mintRedondeoA)
            txtTotalReal.Value = xRound(.GetTotal(.Columns("ImpRealModA"), Janus.Windows.GridEX.AggregateFunction.Sum), mintRedondeoA)
            txtTotalFacturado.Value = xRound(.GetTotal(.Columns("ImpFactModA"), Janus.Windows.GridEX.AggregateFunction.Sum), mintRedondeoA)
        End With
    End Sub

    Protected Overridable Sub GridMODPrevl_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridMODPrev.MouseUp
        If e.Button = MouseButtons.Right Then
            If Not IsNothing(GridMODPrev) AndAlso GridMODPrev.RowCount > 0 Then
                If Length(GridMODPrev.Value("IDCategoria")) > 0 Then
                    GridMODPrev.UiCommandManager1.Commands(cnABRIRCATEGORIAS).Visible = InheritableBoolean.True
                Else
                    GridMODPrev.UiCommandManager1.Commands(cnABRIRCATEGORIAS).Visible = InheritableBoolean.False
                End If
            End If
        End If
    End Sub

#End Region

#Region " Grid Centros Previstos "

    Protected Overridable Sub GridCentrosPrev_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridCentrosPrev.GotFocus
        With GridCentrosPrev
            .Columns("IDObra").DefaultValue = Me.CurrentRow("IDObra")
            .Columns("EstadoFactura").DefaultValue = CInt(enumocenEstadoFactura.ocenNoFacturado)
            .Columns("Estado").DefaultValue = CInt(enumocenEstado.ocenPendiente)
            .Columns("Facturable").DefaultValue = False
            .Columns("Manual").DefaultValue = False

            If rbtPorNivelPrev.Checked AndAlso Not IsNothing(drTrabajos) AndAlso (Nz(drTrabajos("TipoLinea"), 0) = enumTipoLineaTrabajo.tltTrabajo Or Nz(drTrabajos("TipoLinea"), 0) = enumTipoLineaTrabajo.tltTrabajoConcepto) Then
                If Length(drTrabajos("IDTrabajo")) > 0 Then .Columns("IDTrabajo").DefaultValue = drTrabajos("IDTrabajo")
                If Length(drTrabajos("CodTrabajo")) > 0 Then .Columns("CodTrabajo").DefaultValue = drTrabajos("CodTrabajo")
                If Length(drTrabajos("QPrev")) > 0 Then .Columns("QPrevTrabajo").DefaultValue = drTrabajos("QPrev")
                If Length(drTrabajos("Facturable")) > 0 AndAlso drTrabajos("TipoFacturacion") = enumotTipoFacturacion.otfPorConceptos Then
                    .Columns("Facturable").DefaultValue = drTrabajos("Facturable")
                End If
            Else
                .Columns("IDTrabajo").DefaultValue = DBNull.Value
                .Columns("CodTrabajo").DefaultValue = DBNull.Value
                .Columns("QPrevTrabajo").DefaultValue = DBNull.Value
            End If
            '.Columns("Facturable").DefaultValue = Length(Me.CurrentRow("IDCliente")) > 0
            .Columns("TipoIncremento").DefaultValue = CInt(enumSiNo.No)
        End With
    End Sub

    Protected Overridable Sub GridCentrosPrev_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridCentrosPrev.Click
        With GridCentrosPrev
            If .Row <> -1 Then
                Dim hit As GridArea = .HitTest()
                If hit = GridArea.Cell Or hit = GridArea.NewRowCell Then
                    Dim c As GridEXColumn = .ColumnFromPoint()
                    If Not IsNothing(c) Then
                        Select Case c.Key
                            Case "Vencimiento"
                                CargarFormVencimientos()
                            Case "IDTrabajoIncremento"
                                If .Value("TipoIncremento") Then
                                    OpenSearchTipoIncremento()
                                End If
                        End Select
                    End If
                End If
            End If
        End With
    End Sub

    Protected Overridable Sub GridCentrosPrev_EditingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles GridCentrosPrev.EditingCell
        With GridCentrosPrev
            If Nz(.Value("TipoIncremento")) = enumSiNo.Si Then
                If e.Column.Key <> "Secuencia" And e.Column.Key <> "IDTrabajoIncremento" Then
                    e.Cancel = True
                    .Columns(e.Column.Key).ButtonStyle = Janus.Windows.GridEX.ButtonStyle.NoButton
                End If
            Else
                Select Case e.Column.Key
                    Case "TipoIncremento"
                        If .Row <> Grid.newTopRowPosition Then e.Cancel = True
                    Case "Facturable"
                        If Length(Me.CurrentRow("IDCliente")) = 0 OrElse Length(.Value("IDTrabajo")) = 0 Then
                            e.Cancel = True
                        ElseIf ValidarTipoFacturacionTrabajo(.Value("IDTrabajo"), enumotTipoFacturacion.otfPorConceptos) Then
                            .Columns("Facturable").EditType = Janus.Windows.GridEX.EditType.CheckBox
                        Else
                            e.Cancel = True
                        End If
                    Case "CodTrabajo"
                        If .Row <> Grid.newTopRowPosition AndAlso Length(.Value("CodTrabajo")) > 0 Then
                            e.Cancel = True
                            .Columns("CodTrabajo").ButtonStyle = ButtonStyle.NoButton
                        Else
                            .Columns("CodTrabajo").ButtonStyle = ButtonStyle.Image
                        End If
                    Case "HorasPrevCentro"
                        If Not .Value("Manual") Then e.Cancel = True
                End Select
            End If
        End With
    End Sub

    Protected Overridable Sub GridCentrosPrev_AddingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GridCentrosPrev.AddingRecord
        If Length(GridCentrosPrev.Value("CodTrabajo")) = 0 Then
            e.Cancel = True
            ExpertisApp.GenerateMessage("El Trabajo es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf GridCentrosPrev.Value("TipoIncremento") Then
            e.Cancel = ValidaADDIncrementos(GridCentrosPrev)
        End If
    End Sub

    Protected Overridable Sub GridCentrosPrev_UpdatingRecord(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GridCentrosPrev.UpdatingRecord
        If GridCentrosPrev.RowCount > 0 Then
            If Length(GridCentrosPrev.Value("CodTrabajo")) = 0 Then
                e.Cancel = True
                ExpertisApp.GenerateMessage("El Trabajo es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Protected Overridable Sub GridCentrosPrev_AdvSearchSetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.GridAdvSearchFilterEventArgs) Handles GridCentrosPrev.AdvSearchSetPredefinedFilter
        With GridCentrosPrev
            Select Case e.Key
                Case "CodTrabajo"
                    e.Filter.Add("IdObra", FilterOperator.Equal, Me.CurrentRow("IDObra"), FilterType.Numeric)
                    Dim eor As New Filter(FilterUnionOperator.Or)
                    eor.Add("TipoLinea", FilterOperator.Equal, enumTipoLineaTrabajo.tltTrabajo, FilterType.Numeric)
                    eor.Add("TipoLinea", FilterOperator.Equal, enumTipoLineaTrabajo.tltTrabajoConcepto, FilterType.Numeric)
                    e.Filter.Add(eor)
            End Select
        End With
    End Sub

    Protected Overridable Sub GridCentrosPrev_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles GridCentrosPrev.FormattingRow
        With GridCentrosPrev
            If e.Row.RowType = RowType.Record Then
                If Nz(e.Row.Cells("TipoIncremento").Value) Then
                    e.Row.RowStyle = .FormatStyles("IncrementoFormatStyle")
                    e.Row.Cells("IDTrabajoIncremento").ImageIndex = 0
                    For Each dc As DataColumn In ndCentros.Data.Columns
                        If dc.ColumnName <> "Secuencia" And dc.ColumnName <> "CodTrabajo" And _
                           dc.ColumnName <> "DescCentro" And dc.ColumnName <> "TipoIncremento" And _
                           dc.ColumnName <> "IDTrabajoIncremento" And dc.ColumnName <> "ImpPrevCentroVentaA" Then
                            If e.Row.Table.Columns.Contains(dc.ColumnName) Then
                                e.Row.Cells(dc.ColumnName).Text = String.Empty
                            End If
                        End If
                    Next
                End If
            End If
        End With
    End Sub

    Protected Overridable Sub TotalesCentrosPrevisto(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridCentrosPrev.RecordAdded, GridCentrosPrev.RecordUpdated, GridCentrosPrev.RecordsDeleted
        With GridCentrosPrev
            txtTotalPrev.Value = xRound(.GetTotal(.Columns("ImpPrevCentroA"), Janus.Windows.GridEX.AggregateFunction.Sum), mintRedondeoA)
            txtTotalPrevVenta.Value = xRound(.GetTotal(.Columns("ImpPrevCentroVentaA"), Janus.Windows.GridEX.AggregateFunction.Sum), mintRedondeoA)
            txtTotalReal.Value = xRound(.GetTotal(.Columns("ImpRealCentroA"), Janus.Windows.GridEX.AggregateFunction.Sum), mintRedondeoA)
            txtTotalFacturado.Value = xRound(.GetTotal(.Columns("ImpFactCentroA"), Janus.Windows.GridEX.AggregateFunction.Sum), mintRedondeoA)
        End With
    End Sub

#End Region

#Region " Grid Gastos Previstos "

    Protected Overridable Sub GridGastosPrev_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridGastosPrev.GotFocus
        With GridGastosPrev
            .Columns("IDObra").DefaultValue = Me.CurrentRow("IDObra")
            .Columns("EstadoFactura").DefaultValue = CInt(enumogEstadoFactura.ogNoFacturado)
            .Columns("Facturable").DefaultValue = False
            If rbtPorNivelPrev.Checked AndAlso Not IsNothing(drTrabajos) AndAlso (Nz(drTrabajos("TipoLinea"), 0) = enumTipoLineaTrabajo.tltTrabajo Or Nz(drTrabajos("TipoLinea"), 0) = enumTipoLineaTrabajo.tltTrabajoConcepto) Then
                If Length(drTrabajos("IDTrabajo")) > 0 Then .Columns("IDTrabajo").DefaultValue = drTrabajos("IDTrabajo")
                If Length(drTrabajos("CodTrabajo")) > 0 Then .Columns("CodTrabajo").DefaultValue = drTrabajos("CodTrabajo")
                If Length(drTrabajos("Facturable")) > 0 AndAlso drTrabajos("TipoFacturacion") = enumotTipoFacturacion.otfPorConceptos Then
                    .Columns("Facturable").DefaultValue = drTrabajos("Facturable")
                End If
            Else
                .Columns("IDTrabajo").DefaultValue = DBNull.Value
                .Columns("CodTrabajo").DefaultValue = DBNull.Value
            End If
            ' .Columns("Facturable").DefaultValue = Length(Me.CurrentRow("IDCliente")) > 0
        End With
    End Sub

    Protected Overridable Sub GridGastosPrev_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridGastosPrev.Click
        With GridGastosPrev
            If .Row <> -1 Then
                Dim hit As GridArea = .HitTest()
                If hit = GridArea.Cell Or hit = GridArea.NewRowCell Then
                    Dim c As GridEXColumn = .ColumnFromPoint()
                    If Not IsNothing(c) Then
                        Select Case c.Key
                            Case "Vencimiento"
                                CargarFormVencimientos()
                        End Select
                    End If
                End If
            End If
        End With
    End Sub

    Protected Overridable Sub GridGastosPrev_EditingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles GridGastosPrev.EditingCell
        With GridGastosPrev
            Select Case e.Column.Key
                Case "Facturable"
                    If Length(Me.CurrentRow("IDCliente")) = 0 OrElse Length(.Value("IDTrabajo")) = 0 Then
                        e.Cancel = True
                    ElseIf ValidarTipoFacturacionTrabajo(.Value("IDTrabajo"), enumotTipoFacturacion.otfPorConceptos) Then
                        .Columns("Facturable").EditType = Janus.Windows.GridEX.EditType.CheckBox
                    Else
                        e.Cancel = True
                    End If
                Case "CodTrabajo"
                    If .Row <> Grid.newTopRowPosition AndAlso Length(.Value("CodTrabajo")) > 0 Then
                        e.Cancel = True
                        .Columns("CodTrabajo").ButtonStyle = ButtonStyle.NoButton
                    Else
                        .Columns("CodTrabajo").ButtonStyle = ButtonStyle.Image
                    End If
            End Select
        End With
    End Sub

    Protected Overridable Sub GridGastosPrev_UpdatingRecord(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GridGastosPrev.AddingRecord, GridGastosPrev.UpdatingRecord
        If GridGastosPrev.RowCount > 0 Then
            If Length(GridGastosPrev.Value("CodTrabajo")) = 0 Then
                e.Cancel = True
                ExpertisApp.GenerateMessage("El Trabajo es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Protected Overridable Sub GridGastosPrev_AdvSearchSetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.GridAdvSearchFilterEventArgs) Handles GridGastosPrev.AdvSearchSetPredefinedFilter
        With GridGastosPrev
            Select Case e.Key
                Case "CodTrabajo"
                    e.Filter.Add("IdObra", FilterOperator.Equal, Me.CurrentRow("IDObra"), FilterType.Numeric)
                    Dim eor As New Filter(FilterUnionOperator.Or)
                    eor.Add("TipoLinea", FilterOperator.Equal, enumTipoLineaTrabajo.tltTrabajo, FilterType.Numeric)
                    eor.Add("TipoLinea", FilterOperator.Equal, enumTipoLineaTrabajo.tltTrabajoConcepto, FilterType.Numeric)
                    e.Filter.Add(eor)
            End Select
        End With
    End Sub

    Protected Overridable Sub TotalesGastosPrevisto(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridGastosPrev.RecordAdded, GridGastosPrev.RecordUpdated, GridGastosPrev.RecordsDeleted
        With GridGastosPrev
            txtTotalPrev.Value = xRound(.GetTotal(.Columns("ImpPrevGastoA"), Janus.Windows.GridEX.AggregateFunction.Sum), mintRedondeoA)
            txtTotalPrevVenta.Value = xRound(.GetTotal(.Columns("ImpPrevGastoVentaA"), Janus.Windows.GridEX.AggregateFunction.Sum), mintRedondeoA)
            txtTotalReal.Value = xRound(.GetTotal(.Columns("ImpRealGastoA"), Janus.Windows.GridEX.AggregateFunction.Sum), mintRedondeoA)
            txtTotalFacturado.Value = xRound(.GetTotal(.Columns("ImpFactGastoA"), Janus.Windows.GridEX.AggregateFunction.Sum), mintRedondeoA)
        End With
    End Sub

#End Region

#Region " Grid Varios Previstos "

    Protected Overridable Sub GridVariosPrev_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridVariosPrev.GotFocus
        With GridVariosPrev
            .Columns("IDObra").DefaultValue = Me.CurrentRow("IDObra")
            .Columns("EstadoFactura").DefaultValue = CInt(enumovEstadoFactura.ovNoFacturado)
            .Columns("Facturable").DefaultValue = False
            If rbtPorNivelPrev.Checked AndAlso Not IsNothing(drTrabajos) AndAlso Nz(drTrabajos("TipoLinea"), 0) = enumTipoLineaTrabajo.tltTrabajo Then
                If Length(drTrabajos("IDTrabajo")) > 0 Then .Columns("IDTrabajo").DefaultValue = drTrabajos("IDTrabajo")
                If Length(drTrabajos("CodTrabajo")) > 0 Then .Columns("CodTrabajo").DefaultValue = drTrabajos("CodTrabajo")
                If Length(drTrabajos("Facturable")) > 0 AndAlso drTrabajos("TipoFacturacion") = enumotTipoFacturacion.otfPorConceptos Then
                    .Columns("Facturable").DefaultValue = drTrabajos("Facturable")
                End If
            Else
                .Columns("IDTrabajo").DefaultValue = DBNull.Value
                .Columns("CodTrabajo").DefaultValue = DBNull.Value
            End If
            '.Columns("Facturable").DefaultValue = (Length(Me.CurrentRow("IDCliente")) > 0)
        End With
    End Sub

    Protected Overridable Sub GridVariosPrev_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridVariosPrev.Click
        With GridVariosPrev
            If .Row <> -1 Then
                Dim hit As GridArea = .HitTest()
                If hit = GridArea.Cell Or hit = GridArea.NewRowCell Then
                    Dim c As GridEXColumn = .ColumnFromPoint()
                    If Not IsNothing(c) Then
                        Select Case c.Key
                            Case "Vencimiento"
                                CargarFormVencimientos()
                        End Select
                    End If
                End If
            End If
        End With
    End Sub

    Protected Overridable Sub GridVariosPrev_EditingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles GridVariosPrev.EditingCell
        With GridVariosPrev
            Select Case e.Column.Key
                Case "Facturable"
                    If Length(Me.CurrentRow("IDCliente")) = 0 OrElse Length(.Value("IDTrabajo")) = 0 Then
                        e.Cancel = True
                    ElseIf ValidarTipoFacturacionTrabajo(.Value("IDTrabajo"), enumotTipoFacturacion.otfPorConceptos) Then
                        .Columns("Facturable").EditType = Janus.Windows.GridEX.EditType.CheckBox
                    Else
                        e.Cancel = True
                    End If
                Case "CodTrabajo"
                    If .Row <> Grid.newTopRowPosition AndAlso Length(.Value("CodTrabajo")) > 0 Then
                        e.Cancel = True
                        .Columns("CodTrabajo").ButtonStyle = ButtonStyle.NoButton
                    Else
                        .Columns("CodTrabajo").ButtonStyle = ButtonStyle.Image
                    End If
            End Select
        End With
    End Sub

    Protected Overridable Sub GridVariosPrev_UpdatingRecord(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GridVariosPrev.AddingRecord, GridVariosPrev.UpdatingRecord
        If GridVariosPrev.RowCount > 0 Then
            If Length(GridVariosPrev.Value("CodTrabajo")) = 0 Then
                e.Cancel = True
                ExpertisApp.GenerateMessage("El Trabajo es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Protected Overridable Sub GridVariosPrev_AdvSearchSetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.GridAdvSearchFilterEventArgs) Handles GridVariosPrev.AdvSearchSetPredefinedFilter
        With GridVariosPrev
            Select Case e.Key
                Case "CodTrabajo"
                    e.Filter.Add("IdObra", FilterOperator.Equal, Me.CurrentRow("IDObra"), FilterType.Numeric)
                    e.Filter.Add("TipoLinea", FilterOperator.Equal, enumTipoLineaTrabajo.tltTrabajo, FilterType.Numeric)
            End Select
        End With
    End Sub

    Protected Overridable Sub TotalesVariosPrevisto(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridVariosPrev.RecordAdded, GridVariosPrev.RecordUpdated, GridVariosPrev.RecordsDeleted
        With GridVariosPrev
            txtTotalPrev.Value = xRound(.GetTotal(.Columns("ImpPrevVariosA"), Janus.Windows.GridEX.AggregateFunction.Sum), mintRedondeoA)
            txtTotalPrevVenta.Value = xRound(.GetTotal(.Columns("ImpPrevVariosVentaA"), Janus.Windows.GridEX.AggregateFunction.Sum), mintRedondeoA)
            txtTotalReal.Value = xRound(.GetTotal(.Columns("ImpRealVariosA"), Janus.Windows.GridEX.AggregateFunction.Sum), mintRedondeoA)
            txtTotalFacturado.Value = xRound(.GetTotal(.Columns("ImpFactVariosA"), Janus.Windows.GridEX.AggregateFunction.Sum), mintRedondeoA)
        End With
    End Sub

#End Region

#Region " Grid Mediciones "

    Protected Overridable Sub GridMediciones_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridMediciones.Click
        With GridMediciones
            .Columns("IDObra").DefaultValue = Me.CurrentRow("IDObra")
            .Columns("Certificar").DefaultValue = CInt(enumSiNo.Si)
            If rbtPorNivelPrev.Checked AndAlso Not IsNothing(drTrabajos) AndAlso Nz(drTrabajos("TipoLinea"), 0) = enumTipoLineaTrabajo.tltTrabajo Then
                If Length(drTrabajos("IDTrabajo")) > 0 Then .Columns("IDTrabajo").DefaultValue = drTrabajos("IDTrabajo")
                If Length(drTrabajos("CodTrabajo")) > 0 Then .Columns("CodTrabajo").DefaultValue = drTrabajos("CodTrabajo")
            Else
                .Columns("IDTrabajo").DefaultValue = DBNull.Value
                .Columns("CodTrabajo").DefaultValue = DBNull.Value
            End If
        End With
    End Sub

    Protected Overridable Sub GridMediciones_UpdatingRecord(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GridMediciones.AddingRecord, GridMediciones.UpdatingRecord
        If GridMediciones.RowCount > 0 Then
            If Length(GridMediciones.Value("CodTrabajo")) = 0 Then
                e.Cancel = True
                ExpertisApp.GenerateMessage("El Trabajo es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Protected Overridable Sub GridMediciones_AdvSearchSetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.GridAdvSearchFilterEventArgs) Handles GridMediciones.AdvSearchSetPredefinedFilter
        With GridMediciones
            Select Case e.Key
                Case "CodTrabajo"
                    e.Filter.Add("IdObra", FilterOperator.Equal, Me.CurrentRow("IDObra"), FilterType.Numeric)
                    e.Filter.Add("TipoFacturacion", FilterOperator.Equal, enumotTipoFacturacion.otfPorUdsObra, FilterType.Numeric)
                    Dim eor As New Filter(FilterUnionOperator.Or)
                    eor.Add("TipoLinea", FilterOperator.Equal, enumTipoLineaTrabajo.tltTrabajo, FilterType.Numeric)
                    eor.Add("TipoLinea", FilterOperator.Equal, enumTipoLineaTrabajo.tltTrabajoConcepto, FilterType.Numeric)
                    e.Filter.Add(eor)
            End Select
        End With
    End Sub

    Protected Overridable Sub GridMediciones_EditingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles GridMediciones.EditingCell
        With GridMediciones
            If Nz(.Value("TieneMedidas"), False) Then
                e.Cancel = True
                .Columns("CodTrabajo").ButtonStyle = ButtonStyle.NoButton
            Else
                Select Case e.Column.Key
                    Case "CodTrabajo"
                        If .Row <> Grid.newTopRowPosition AndAlso Length(.Value("CodTrabajo")) > 0 Then
                            e.Cancel = True
                            .Columns("CodTrabajo").ButtonStyle = ButtonStyle.NoButton
                        Else
                            .Columns("CodTrabajo").ButtonStyle = ButtonStyle.Image
                        End If
                End Select
            End If
        End With
    End Sub

    Protected Overridable Sub TotalesMediciones(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridMediciones.RecordAdded, GridMediciones.RecordUpdated, GridMediciones.RecordsDeleted
        With GridMediciones
            txtTotalMedicion.Value = xRound(.GetTotal(.Columns("Total"), Janus.Windows.GridEX.AggregateFunction.Sum), mintRedondeoA)
        End With
    End Sub

#End Region

#End Region

#Region " Pestaña Control "

    Protected Overridable Sub ControlChecked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtControlObra.CheckedChanged, rbtNivelControl.CheckedChanged, rbtMultinivelControl.CheckedChanged
        If Not IsNothing(dtTrabajos) AndAlso dtTrabajos.Rows.Count > 0 Then
            pnlVerControl.Visible = (rbtNivelControl.Checked Or rbtMultinivelControl.Checked)
            If Not IsNothing(Me.CurrentData) AndAlso Not blnChecked Then
                CheckedAll()
                TabControl_Click(TabControl, New System.EventArgs)
            End If
        End If
    End Sub

#Region " Control Materiales "

    Protected Overridable Sub GridMaterialControl_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridMaterialControl.GotFocus
        With GridMaterialControl
            .Columns("IDObra").DefaultValue = Me.CurrentRow("IDObra")
            .Columns("PrecioRealMatA").DefaultValue = 0
            .Columns("ImpRealMatA").DefaultValue = 0
            .Columns("QReal").DefaultValue = 0
            .Columns("Dto1").DefaultValue = 0
            .Columns("Dto2").DefaultValue = 0
            .Columns("Dto3").DefaultValue = 0
            .Columns("Facturable").DefaultValue = False
            If rbtNivelControl.Checked AndAlso Not IsNothing(drTrabajos) AndAlso Nz(drTrabajos("TipoLinea"), 0) = enumTipoLineaTrabajo.tltTrabajo Then
                If Length(drTrabajos("IDTrabajo")) > 0 Then .Columns("IDTrabajo").DefaultValue = drTrabajos("IDTrabajo")
                If Length(drTrabajos("CodTrabajo")) > 0 Then .Columns("CodTrabajo").DefaultValue = drTrabajos("CodTrabajo")
                If Length(drTrabajos("Facturable")) > 0 AndAlso drTrabajos("TipoFacturacion") = enumotTipoFacturacion.otfPorConceptos Then
                    .Columns("Facturable").DefaultValue = drTrabajos("Facturable")
                End If
            Else
                .Columns("IDTrabajo").DefaultValue = DBNull.Value
                .Columns("CodTrabajo").DefaultValue = DBNull.Value
            End If
            .Columns("TipoMaterial").DefaultValue = CInt(enumomcTipoMaterial.omcAlmacen)
            .Columns("TipoMaterial").EditType = EditType.NoEdit
            .Columns("Actualizado").DefaultValue = enumomcActualizado.omcNoActualizado
            .Columns("Facturado").DefaultValue = False
        End With
    End Sub

    Protected Overridable Sub GridMaterialControl_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GridMaterialControl.AddingRecord, GridMaterialControl.UpdatingRecord
        With GridMaterialControl
            If .RowCount > 0 Then
                If Length(.Value("IdObra")) = 0 Then .Value("IdObra") = Me.CurrentRow("IDObra")
                If Length(.Value("IDMaterial")) = 0 Then
                    e.Cancel = True
                    ExpertisApp.GenerateMessage("El Material es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If
        End With
    End Sub

    Protected Overridable Sub GridMaterialControl_EditingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles GridMaterialControl.EditingCell
        With GridMaterialControl
            Select Case e.Column.Key
                Case "Actualizado"
                    e.Cancel = True
                Case "Facturable"
                    .Columns(e.Column.Key).EditType = EditType.CheckBox
                Case Else
                    e.Cancel = .GetValue("Facturado") Or Length(.GetValue("IDLineaAlbaran")) > 0
                    If e.Cancel Then
                        Dim Fields() As String = New String() {"CodTrabajo", "IDMaterial", "IDAlmacen", "IDLineaMaterial"}
                        For Each Field As String In Fields
                            .Columns(Field).ButtonStyle = ButtonStyle.NoButton
                        Next
                    Else
                        Dim Fields() As String = New String() {"CodTrabajo", "IDMaterial", "IDAlmacen", "IDLineaMaterial"}
                        For Each Field As String In Fields
                            .Columns(Field).ButtonStyle = ButtonStyle.Image
                        Next
                        If Length(.Value("IDLineaMaterial")) > 0 Then
                            '//No se puede modificar ni el artículo ni el trabajo
                            Dim FieldsNoEdit() As String = New String() {"CodTrabajo", "IDMaterial"}
                            Dim NoEdit As Boolean = (Array.IndexOf(FieldsNoEdit, e.Column.Key) >= 0)
                            e.Cancel = NoEdit
                            If NoEdit AndAlso .Columns(e.Column.Key).ButtonStyle = ButtonStyle.Image Then
                                .Columns(e.Column.Key).ButtonStyle = ButtonStyle.NoButton
                            End If
                        End If
                        If .GetValue("Actualizado") <> enumomcActualizado.omcNoActualizado Then
                            e.Cancel = True
                            If .Columns(e.Column.Key).ButtonStyle = ButtonStyle.Image Then
                                .Columns(e.Column.Key).ButtonStyle = ButtonStyle.NoButton
                            End If
                        End If
                    End If
            End Select
        End With
    End Sub

    Protected Overridable Sub TotalesMaterialControl(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridMaterialControl.RecordAdded, GridMaterialControl.RecordUpdated, GridMaterialControl.RecordsDeleted
        With GridMaterialControl
            txtTotalControl.Value = xRound(.GetTotal(.Columns("ImpRealMatA"), Janus.Windows.GridEX.AggregateFunction.Sum), mintRedondeoA)
        End With
    End Sub

    Protected Overridable Sub GridMaterialControl_AdvSearchSetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.GridAdvSearchFilterEventArgs) Handles GridMaterialControl.AdvSearchSetPredefinedFilter
        With GridMaterialControl
            Select Case e.Key
                Case "CodTrabajo"
                    e.Filter.Add("IdObra", FilterOperator.Equal, Me.CurrentRow("IDObra"), FilterType.Numeric)
                    Dim eor As New Filter(FilterUnionOperator.Or)
                    eor.Add("TipoLinea", FilterOperator.Equal, enumTipoLineaTrabajo.tltTrabajo, FilterType.Numeric)
                    eor.Add("TipoLinea", FilterOperator.Equal, enumTipoLineaTrabajo.tltTrabajoConcepto, FilterType.Numeric)
                    e.Filter.Add(eor)
                Case "IDMaterial"
                    e.Filter.Add(New BooleanFilterItem("Activo", FilterOperator.Equal, True))
                Case "IDLineaMaterial"
                    If Length(.Value("IDTrabajo")) > 0 Then
                        e.Filter.Add("IDTrabajo", FilterOperator.Equal, .Value("IDTrabajo"), FilterType.Numeric)
                    Else
                        e.Filter.Add(New NoRowsFilterItem)
                    End If
                    If Length(.Value("IDMaterial")) > 0 Then
                        e.Filter.Add("IDMaterial", FilterOperator.Equal, .Value("IDMaterial"), FilterType.String)
                    End If
            End Select
        End With
    End Sub


    Protected Overridable Sub GridMaterialControl_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridMaterialControl.MouseUp
        If e.Button = MouseButtons.Right Then
            If Not IsNothing(GridMaterialControl) AndAlso GridMaterialControl.RowCount > 0 Then
                If Length(GridMaterialControl.Value("IDMaterial")) > 0 Then
                    GridMaterialControl.UiCommandManager1.Commands(cnABRIRMATERIAL).Visible = InheritableBoolean.True
                Else
                    GridMaterialControl.UiCommandManager1.Commands(cnABRIRMATERIAL).Visible = InheritableBoolean.False
                End If
                If Length(GridMaterialControl.Value("IDAlbaran")) > 0 Then
                    GridMaterialControl.UiCommandManager1.Commands(cnABRIRALBARANCOMPRA).Visible = InheritableBoolean.True
                Else
                    GridMaterialControl.UiCommandManager1.Commands(cnABRIRALBARANCOMPRA).Visible = InheritableBoolean.False
                End If
                If Length(GridMaterialControl.Value("IDFactura")) > 0 Then
                    GridMaterialControl.UiCommandManager1.Commands(cnABRIRFACTURACOMPRA).Visible = InheritableBoolean.True
                Else
                    GridMaterialControl.UiCommandManager1.Commands(cnABRIRFACTURACOMPRA).Visible = InheritableBoolean.False
                End If
            End If
        End If
    End Sub

#End Region

#Region " Control MOD "

    Protected Overridable Sub GridMODControl_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridMODControl.GotFocus
        With GridMODControl
            .Columns("IDObra").DefaultValue = Me.CurrentRow("IDObra")
            .Columns("Facturable").DefaultValue = False
            If IsNothing(drTrabajos) Then
                .Columns("IDTrabajo").DefaultValue = DBNull.Value
                .Columns("CodTrabajo").DefaultValue = DBNull.Value
                .Columns("IDTarea").DefaultValue = DBNull.Value
                .Columns("NTarea").DefaultValue = DBNull.Value
                .Columns("DescTarea").DefaultValue = DBNull.Value
                '.Columns("Facturable").DefaultValue =  DBNull.Value
            Else
                If rbtNivelControl.Checked AndAlso Length(drTrabajos("Facturable")) > 0 AndAlso drTrabajos("TipoFacturacion") = enumotTipoFacturacion.otfPorConceptos Then
                    .Columns("Facturable").DefaultValue = drTrabajos("Facturable")
                End If
            End If
            .Columns("FechaInicio").DefaultValue = Date.Today
            .Columns("FechaFin").DefaultValue = Date.Today
            '.Columns("Facturable").DefaultValue = Length(Me.CurrentRow("IDCliente")) > 0
        End With
    End Sub

    Protected Overridable Sub GridMODControl_EditingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles GridMODControl.EditingCell
        With GridMODControl
            Select Case e.Column.Key
                Case "Facturable"
                    e.Cancel = Length(Me.CurrentRow("IDCliente")) = 0
                    'Case "IDOperario"
                    '    e.Cancel = Length(.Value("IDLineaMOD")) > 0
                    '    If e.Cancel Then
                    '        .Columns(e.Column.Key).ButtonStyle = ButtonStyle.NoButton
                    '    Else
                    '        .Columns(e.Column.Key).ButtonStyle = ButtonStyle.Image
                    '    End If
                Case Else
                    e.Cancel = GridMODControl.GetValue("Facturado") Or (Length(.Value("IDLineaMOD")) > 0 And Length(.Value("IDLineaMODControl")) > 0)
                    If e.Cancel Then
                        Dim Fields() As String = New String() {"CodTrabajo", "IDOperario", "NTarea", "IDLineaMOD", "IDIncidencia", "IDHora", "DescParte"}
                        For Each Field As String In Fields
                            .Columns(Field).ButtonStyle = ButtonStyle.NoButton
                        Next
                    Else
                        Dim Fields() As String = New String() {"CodTrabajo", "IDOperario", "NTarea", "IDLineaMOD", "IDIncidencia", "IDHora"}
                        For Each Field As String In Fields
                            .Columns(Field).ButtonStyle = ButtonStyle.Image
                        Next
                        .Columns("DescParte").ButtonStyle = ButtonStyle.Ellipsis
                    End If
            End Select
        End With
    End Sub

    Protected Overridable Sub GridMODControl_UpdatingRecord(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GridMODControl.UpdatingRecord
        With GridMODControl
            If .RowCount > 0 Then
                If Length(.Value("IdObra")) = 0 Then .Value("IdObra") = Me.CurrentRow("IDObra")
                If Length(.Value("IDOperario")) = 0 Then
                    e.Cancel = True
                    ExpertisApp.GenerateMessage("El Operario es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If
        End With
    End Sub

    Protected Overridable Sub GridMODControl_ColumnButtonClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles GridMODControl.ColumnButtonClick
        With GridMODControl
            Select Case e.Column.Key
                Case "DescParte"
                    Dim frm As New FormularioTexto
                    frm.Text = "Zoom Desc. Parte"
                    frm.Texto = .Value("DescParte") & String.Empty
                    frm.ShowDialog()
                    If .Value(e.Column.Key) & String.Empty <> frm.Texto & String.Empty Then
                        .Value(e.Column.Key) = frm.Texto
                    End If
            End Select
        End With
    End Sub

    Protected Overridable Sub GridMODControl_AdvSearchSetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.GridAdvSearchFilterEventArgs) Handles GridMODControl.AdvSearchSetPredefinedFilter
        With GridMODControl
            Select Case e.Key
                Case "CodTrabajo"
                    e.Filter.Add("IdObra", FilterOperator.Equal, Me.CurrentRow("IDObra"), FilterType.Numeric)
                    Dim eor As New Filter(FilterUnionOperator.Or)
                    eor.Add("TipoLinea", FilterOperator.Equal, enumTipoLineaTrabajo.tltTrabajo, FilterType.Numeric)
                    eor.Add("TipoLinea", FilterOperator.Equal, enumTipoLineaTrabajo.tltTrabajoConcepto, FilterType.Numeric)
                    e.Filter.Add(eor)
                Case "IDLineaMod"
                    If Length(.Value("IDTrabajo")) > 0 Then
                        e.Filter.Add("IDTrabajo", FilterOperator.Equal, .Value("IDTrabajo"), FilterType.Numeric)
                    Else
                        e.Filter.Add(New NoRowsFilterItem)
                    End If
                    If Length(.Value("IDCategoria")) > 0 Then
                        e.Filter.Add("IDCategoria", FilterOperator.Equal, .Value("IDCategoria"), FilterType.String)
                    End If
                Case "NTarea"
                    If Length(.Value("IDObra")) > 0 Then e.Filter.Add("IDObra", FilterOperator.Equal, .Value("IDObra"), FilterType.Numeric)
                    If Length(.Value("IDTrabajo")) > 0 Then e.Filter.Add("IDTrabajo", FilterOperator.Equal, .Value("IDTrabajo"), FilterType.Numeric)
            End Select
        End With
    End Sub


    Protected Overridable Sub GridMODControl_DeletingRecord(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionCancelEventArgs) Handles GridMODControl.DeletingRecord
        If Length(e.Row.DataRow("IDLineaMODControl")) > 0 AndAlso Length(e.Row.DataRow("IDOperario")) > 0 Then
            Dim objFilter As New Filter
            objFilter.Add(New StringFilterItem("IDOperario", e.Row.DataRow("IDOperario")))
            objFilter.Add(New NumberFilterItem("IDLineaMODControl", e.Row.DataRow("IDLineaMODControl")))
            Dim dt As DataTable = New ObraGastoControl().Filter(objFilter)
            If Not IsNothing(dt) AndAlso dt.Rows.Count > 0 Then
                If ExpertisApp.GenerateMessage("El registro seleccionado tiene Gastos asociados. Estos Gastos también se eliminarán ¿Desea continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Protected Overridable Sub TotalesMODControl(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridMODControl.RecordAdded, GridMODControl.RecordUpdated, GridMODControl.RecordsDeleted
        With GridMODControl
            txtTotalControl.Value = xRound(.GetTotal(.Columns("ImpRealModA"), Janus.Windows.GridEX.AggregateFunction.Sum), mintRedondeoA)
        End With
    End Sub

    Protected Overridable Sub GridMODControl_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridMODControl.MouseUp
        If e.Button = MouseButtons.Right Then
            If Not IsNothing(GridMODControl) AndAlso GridMODControl.RowCount > 0 Then
                If Length(GridMODControl.Value("IDCategoria")) > 0 Then
                    GridMODControl.UiCommandManager1.Commands(cnABRIRCATEGORIAS).Visible = InheritableBoolean.True
                Else
                    GridMODControl.UiCommandManager1.Commands(cnABRIRCATEGORIAS).Visible = InheritableBoolean.False
                End If
            End If
        End If
    End Sub

#End Region

#Region " Control Centros "

    Protected Overridable Sub GridCentroControl_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridCentroControl.GotFocus
        With GridCentroControl
            .Columns("IDObra").DefaultValue = Me.CurrentRow("IDObra")
            .Columns("FechaInicio").DefaultValue = Date.Today
            If rbtNivelControl.Checked AndAlso Not IsNothing(drTrabajos) AndAlso Nz(drTrabajos("TipoLinea"), 0) = enumTipoLineaTrabajo.tltTrabajo Then
                If Length(drTrabajos("IDTrabajo")) > 0 Then .Columns("IDTrabajo").DefaultValue = drTrabajos("IDTrabajo")
                If Length(drTrabajos("CodTrabajo")) > 0 Then .Columns("CodTrabajo").DefaultValue = drTrabajos("CodTrabajo")
            Else
                .Columns("IDTrabajo").DefaultValue = DBNull.Value
                .Columns("CodTrabajo").DefaultValue = DBNull.Value
            End If
        End With
    End Sub

    Protected Overridable Sub GridCentroControl_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GridCentroControl.AddingRecord, GridCentroControl.UpdatingRecord
        With GridCentroControl
            If .RowCount > 0 Then
                If Length(.Value("IDCentro")) = 0 Then
                    e.Cancel = True
                    ExpertisApp.GenerateMessage("El Centro es obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If
        End With
    End Sub

    Protected Overridable Sub TotalesCentrosControl(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridCentroControl.RecordAdded, GridCentroControl.RecordUpdated, GridCentroControl.RecordsDeleted
        With GridCentroControl
            txtTotalControl.Value = xRound(.GetTotal(.Columns("ImpRealCentroA"), Janus.Windows.GridEX.AggregateFunction.Sum), mintRedondeoA)
        End With
    End Sub

    Protected Overridable Sub GridCentroControl_AdvSearchSetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.GridAdvSearchFilterEventArgs) Handles GridCentroControl.AdvSearchSetPredefinedFilter
        With GridCentroControl
            Select Case e.Key
                Case "CodTrabajo"
                    e.Filter.Add("IdObra", FilterOperator.Equal, Me.CurrentRow("IDObra"), FilterType.Numeric)
                    Dim eor As New Filter(FilterUnionOperator.Or)
                    eor.Add("TipoLinea", FilterOperator.Equal, enumTipoLineaTrabajo.tltTrabajo, FilterType.Numeric)
                    eor.Add("TipoLinea", FilterOperator.Equal, enumTipoLineaTrabajo.tltTrabajoConcepto, FilterType.Numeric)
                    e.Filter.Add(eor)
                Case "IDLineaCentro"
                    If Length(.Value("IDTrabajo")) > 0 Then
                        e.Filter.Add("IDTrabajo", FilterOperator.Equal, .Value("IDTrabajo"), FilterType.Numeric)
                    Else
                        e.Filter.Add(New NoRowsFilterItem)
                    End If
                    If Length(.Value("IDCentro")) > 0 Then
                        e.Filter.Add("IDCentro", FilterOperator.Equal, .Value("IDCentro"), FilterType.String)
                    End If
            End Select
        End With
    End Sub

#End Region

#Region " Control Gastos "

    Protected Overridable Sub GridGastosControl_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridGastosControl.GotFocus
        With GridGastosControl
            .Columns("IDObra").DefaultValue = Me.CurrentRow("IDObra")
            .Columns("Fecha").DefaultValue = Date.Today
            .Columns("Facturable").DefaultValue = False
            If rbtNivelControl.Checked AndAlso Not IsNothing(drTrabajos) AndAlso Nz(drTrabajos("TipoLinea"), 0) = enumTipoLineaTrabajo.tltTrabajo Then
                If Length(drTrabajos("IDTrabajo")) > 0 Then .Columns("IDTrabajo").DefaultValue = drTrabajos("IDTrabajo")
                If Length(drTrabajos("CodTrabajo")) > 0 Then .Columns("CodTrabajo").DefaultValue = drTrabajos("CodTrabajo")
                'If Length(drTrabajos("Facturable")) > 0 Then .Columns("Facturable").DefaultValue = drTrabajos("Facturable")
                If Length(drTrabajos("Facturable")) > 0 AndAlso drTrabajos("TipoFacturacion") = enumotTipoFacturacion.otfPorConceptos Then
                    .Columns("Facturable").DefaultValue = drTrabajos("Facturable")
                End If
            Else
                .Columns("IDTrabajo").DefaultValue = DBNull.Value
                .Columns("CodTrabajo").DefaultValue = DBNull.Value
                '.Columns("Facturable").DefaultValue = False
                '.Columns("Facturable").DefaultValue = Length(Me.CurrentRow("IDCliente")) > 0
            End If
            .Columns("Contabilizado").DefaultValue = False
        End With
    End Sub

    Protected Overridable Sub GridGastosControl_EditingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles GridGastosControl.EditingCell
        With GridGastosControl
            If Not Nz(.Value("Contabilizado"), False) Then
                Select Case e.Column.Key
                    Case "Tarjeta"
                        .Columns(e.Column.Key).EditType = Janus.Windows.GridEX.EditType.CheckBox
                    Case "Facturable"
                        .Columns(e.Column.Key).EditType = Janus.Windows.GridEX.EditType.CheckBox
                        e.Cancel = Length(Me.CurrentRow("IDCliente")) = 0
                    Case "CodTrabajo", "IDGasto", "IdOperario", "DescGasto", "ImpRealGastoA"
                        .Columns(e.Column.Key).EditType = Janus.Windows.GridEX.EditType.TextBox
                    Case "Fecha"
                        .Columns(e.Column.Key).EditType = Janus.Windows.GridEX.EditType.CalendarCombo
                    Case Else
                        e.Cancel = True
                End Select
            Else
                e.Cancel = True
            End If
        End With
    End Sub

    Protected Overridable Sub GridGastosControl_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GridGastosControl.AddingRecord, GridGastosControl.UpdatingRecord
        With GridGastosControl
            If .RowCount > 0 Then
                If Length(.Value("IDGasto")) = 0 Then
                    e.Cancel = True
                    ExpertisApp.GenerateMessage("El Gasto es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If
        End With
    End Sub

    Protected Overridable Sub TotalesGastosControl(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridGastosControl.RecordAdded, GridGastosControl.RecordUpdated, GridGastosControl.RecordsDeleted
        With GridGastosControl
            txtTotalControl.Value = xRound(.GetTotal(.Columns("ImpRealGastoA"), Janus.Windows.GridEX.AggregateFunction.Sum), mintRedondeoA)
        End With
    End Sub

    Protected Overridable Sub GridGastosControl_AdvSearchSetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.GridAdvSearchFilterEventArgs) Handles GridGastosControl.AdvSearchSetPredefinedFilter
        Select Case e.Key
            Case "CodTrabajo"
                e.Filter.Add("IdObra", FilterOperator.Equal, Me.CurrentRow("IDObra"), FilterType.Numeric)
                Dim eor As New Filter(FilterUnionOperator.Or)
                eor.Add("TipoLinea", FilterOperator.Equal, enumTipoLineaTrabajo.tltTrabajo, FilterType.Numeric)
                eor.Add("TipoLinea", FilterOperator.Equal, enumTipoLineaTrabajo.tltTrabajoConcepto, FilterType.Numeric)
                e.Filter.Add(eor)
            Case "IDLineaGasto"
                If Length(GridGastosControl.Value("IDTrabajo")) > 0 Then
                    e.Filter.Add("IDTrabajo", FilterOperator.Equal, GridGastosControl.Value("IDTrabajo"), FilterType.Numeric)
                Else
                    e.Filter.Add(New NoRowsFilterItem)
                End If
                If Length(GridGastosControl.Value("IDGasto")) > 0 Then
                    e.Filter.Add("IDGasto", FilterOperator.Equal, GridGastosControl.Value("IDGasto"), FilterType.String)
                End If
        End Select
    End Sub


    Protected Overridable Sub GridGastosControl_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridGastosControl.MouseUp
        If e.Button = MouseButtons.Right Then
            If Not IsNothing(GridGastosControl) AndAlso GridGastosControl.RowCount > 0 Then
                If Length(GridGastosControl.Value("IDAlbaran")) > 0 Then
                    GridGastosControl.UiCommandManager1.Commands(cnABRIRALBARANCOMPRA).Visible = InheritableBoolean.True
                Else
                    GridGastosControl.UiCommandManager1.Commands(cnABRIRALBARANCOMPRA).Visible = InheritableBoolean.False
                End If
                If Length(GridGastosControl.Value("IDFactura")) > 0 Then
                    GridGastosControl.UiCommandManager1.Commands(cnABRIRFACTURACOMPRA).Visible = InheritableBoolean.True
                Else
                    GridGastosControl.UiCommandManager1.Commands(cnABRIRFACTURACOMPRA).Visible = InheritableBoolean.False
                End If
            End If
        End If
    End Sub

#End Region

#Region " Control Varios "

    Protected Overridable Sub GridVariosControl_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridVariosControl.GotFocus
        With GridVariosControl
            .Columns("IDObra").DefaultValue = Me.CurrentRow("IDObra")
            If rbtNivelControl.Checked AndAlso Not IsNothing(drTrabajos) AndAlso Nz(drTrabajos("TipoLinea"), 0) = enumTipoLineaTrabajo.tltTrabajo Then
                If Length(drTrabajos("IDTrabajo")) > 0 Then .Columns("IDTrabajo").DefaultValue = drTrabajos("IDTrabajo")
                If Length(drTrabajos("CodTrabajo")) > 0 Then .Columns("CodTrabajo").DefaultValue = drTrabajos("CodTrabajo")
            Else
                .Columns("IDTrabajo").DefaultValue = DBNull.Value
                .Columns("CodTrabajo").DefaultValue = DBNull.Value
            End If
            .Columns("Contabilizado").DefaultValue = False
        End With
    End Sub

    Protected Overridable Sub GridVariosControl_EditingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles GridVariosControl.EditingCell
        With GridVariosControl
            If Not Nz(.Value("Contabilizado"), False) Then
                Select Case e.Column.Key
                    Case "CodTrabajo", "IDVarios", "DescVarios", "ImpRealVariosA"
                        .Columns(e.Column.Key).EditType = Janus.Windows.GridEX.EditType.TextBox
                    Case "Fecha"
                        .Columns(e.Column.Key).EditType = EditType.CalendarDropDown
                    Case Else
                        e.Cancel = True
                End Select
            Else
                e.Cancel = True
            End If
        End With
    End Sub

    Protected Overridable Sub GridVariosControl_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GridVariosControl.AddingRecord, GridVariosControl.UpdatingRecord
        With GridVariosControl
            If .RowCount > 0 Then
                If Length(.Value("IDVarios")) = 0 Then
                    e.Cancel = True
                    ExpertisApp.GenerateMessage("Varios es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If
        End With
    End Sub

    Protected Overridable Sub TotalesVariosControl(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridVariosControl.RecordAdded, GridVariosControl.RecordUpdated, GridVariosControl.RecordsDeleted
        With GridVariosControl
            txtTotalControl.Value = xRound(.GetTotal(.Columns("ImpRealVariosA"), Janus.Windows.GridEX.AggregateFunction.Sum), mintRedondeoA)
        End With
    End Sub

    Protected Overridable Sub GridVariosControl_AdvSearchSetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.GridAdvSearchFilterEventArgs) Handles GridVariosControl.AdvSearchSetPredefinedFilter
        With GridVariosControl
            Select Case e.Key
                Case "CodTrabajo"
                    e.Filter.Add("IdObra", FilterOperator.Equal, Me.CurrentRow("IDObra"), FilterType.Numeric)
                    Dim eor As New Filter(FilterUnionOperator.Or)
                    eor.Add("TipoLinea", FilterOperator.Equal, enumTipoLineaTrabajo.tltTrabajo, FilterType.Numeric)
                    eor.Add("TipoLinea", FilterOperator.Equal, enumTipoLineaTrabajo.tltTrabajoConcepto, FilterType.Numeric)
                    e.Filter.Add(eor)
                Case "IDLineaVarios"
                    If Length(.Value("IDTrabajo")) > 0 Then
                        e.Filter.Add("IDTrabajo", FilterOperator.Equal, .Value("IDTrabajo"), FilterType.Numeric)
                    Else
                        e.Filter.Add(New NoRowsFilterItem)
                    End If
                    If Length(.Value("IDVarios")) > 0 Then
                        e.Filter.Add("IDVarios", FilterOperator.Equal, .Value("IDVarios"), FilterType.String)
                    End If
            End Select
        End With
    End Sub

    Protected Overridable Sub GridVariosControl_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridVariosControl.MouseUp
        If e.Button = MouseButtons.Right Then
            If Not IsNothing(GridVariosControl) AndAlso GridVariosControl.RowCount > 0 Then
                If Length(GridVariosControl.Value("IDAlbaran")) > 0 Then
                    GridVariosControl.UiCommandManager1.Commands(cnABRIRALBARANCOMPRA).Visible = InheritableBoolean.True
                Else
                    GridVariosControl.UiCommandManager1.Commands(cnABRIRALBARANCOMPRA).Visible = InheritableBoolean.False
                End If
                If Length(GridVariosControl.Value("IDFactura")) > 0 Then
                    GridVariosControl.UiCommandManager1.Commands(cnABRIRFACTURACOMPRA).Visible = InheritableBoolean.True
                Else
                    GridVariosControl.UiCommandManager1.Commands(cnABRIRFACTURACOMPRA).Visible = InheritableBoolean.False
                End If
            End If
        End If
    End Sub

#End Region

#Region " Certificaciones "

#Region " Grid Certificacion "

    Protected Overridable Sub FiltrarGridCertificaciones()
        If Me.RecordsState <> RecordsState.Initialize Then
            GridCertificacionTrabajo.DataSource = Nothing
            If Not IsNothing(GridCertificacion.DataSource) Then
                Dim f As New Filter
                CType(GridCertificacion.DataSource, DataTable).DefaultView.RowFilter = ""
                Dim dtCertificacion As DataTable = CType(GridCertificacion.DataSource, DataTable).Copy
                If TabTiposCertificacion.Visible Then
                    Dim dv As New DataView(dtCertificacion.Copy, Nothing, "IDCertificacion DESC", DataViewRowState.CurrentRows)
                    Select Case TabTiposCertificacion.SelectedTab.Key
                        Case "Cliente"
                            f.Add(New NumberFilterItem("TipoCertificacion", enumTipoCertificacion.Cliente))
                            Dim dvCliente As New DataView(dtCertificacion.Copy, f.Compose(New AdoFilterComposer), "IDCertificacion DESC", DataViewRowState.CurrentRows)
                            If chkVerUltimaCertificacion.Checked AndAlso dvCliente.Count > 0 Then
                                f.Add(New NumberFilterItem("IDCertificacion", dvCliente(0).Row("IDCertificacion")))
                            End If
                        Case "Produccion"
                            f.Add(New NumberFilterItem("TipoCertificacion", enumTipoCertificacion.Produccion))
                            Dim dvProduccion As New DataView(dtCertificacion.Copy, f.Compose(New AdoFilterComposer), "IDCertificacion DESC", DataViewRowState.CurrentRows)
                            If chkVerUltimaCertificacion.Checked AndAlso dvProduccion.Count > 0 Then
                                f.Add(New NumberFilterItem("IDCertificacion", dvProduccion(0).Row("IDCertificacion")))
                            End If
                        Case "ClienteProduccion"
                            If chkVerUltimaCertificacion.Checked Then
                                Dim f_OR As New Filter(FilterUnionOperator.Or)
                                Dim fCliente As New Filter
                                fCliente.Add(New NumberFilterItem("TipoCertificacion", enumTipoCertificacion.Cliente))
                                Dim dvCliente As New DataView(dtCertificacion.Copy, fCliente.Compose(New AdoFilterComposer), "IDCertificacion DESC", DataViewRowState.CurrentRows)
                                If dvCliente.Count > 0 Then
                                    fCliente.Clear()
                                    fCliente.Add(New NumberFilterItem("IDCertificacion", dvCliente(0).Row("IDCertificacion")))
                                    fCliente.Add(New NumberFilterItem("TipoCertificacion", enumTipoCertificacion.Cliente))
                                    f_OR.Add(fCliente)
                                End If

                                Dim fProduccion As New Filter
                                fProduccion.Add(New NumberFilterItem("TipoCertificacion", enumTipoCertificacion.Produccion))
                                Dim dvProduccion As New DataView(dtCertificacion.Copy, fProduccion.Compose(New AdoFilterComposer), "IDCertificacion DESC", DataViewRowState.CurrentRows)
                                If dvProduccion.Count > 0 Then
                                    fProduccion.Clear()
                                    fProduccion.Add(New NumberFilterItem("IDCertificacion", dvProduccion(0).Row("IDCertificacion")))
                                    fProduccion.Add(New NumberFilterItem("TipoCertificacion", enumTipoCertificacion.Produccion))
                                    f_OR.Add(fProduccion)
                                End If
                                f.Add(f_OR)
                            End If
                    End Select
                Else
                    f.Add(New NumberFilterItem("TipoCertificacion", enumTipoCertificacion.ClienteProduccion))
                    If chkVerUltimaCertificacion.Checked Then
                        Dim dv As New DataView(dtCertificacion.Copy, f.Compose(New AdoFilterComposer), "IDCertificacion DESC", DataViewRowState.CurrentRows)
                        If dv.Count > 0 Then
                            f.Add(New NumberFilterItem("IDCertificacion", dv(0).Row("IDCertificacion")))
                        End If
                    End If
                End If
                If Length(AdvSearchCertificacion.Value) > 0 Then
                    f.Add(New NumberFilterItem("IDCertificacion", AdvSearchCertificacion.Value))
                End If

                CType(GridCertificacion.DataSource, DataTable).DefaultView.RowFilter = f.Compose(New AdoFilterComposer)
                If CType(GridCertificacion.DataSource, DataTable).DefaultView.Count = 0 Then
                    GridCertificacionTrabajo.DataSource = Nothing
                Else 'Filtrado de las líneas de CertificacionTrabajo: los mismos criterios que su cabecera + el filtro PorTrabajo/PorCapitulo
                    GridCertificacion_SelectionChanged(GridCertificacion, New EventArgs)
                End If

                If TabTiposCertificacion.Visible AndAlso TabTiposCertificacion.SelectedTab.Key = "ClienteProduccion" Then
                    AplicarGrupoCertificacion()
                ElseIf GridCertificacion.Columns("TipoCertificacion").IsGrouped Then
                    GridCertificacion.RootTable.Groups.Remove(GridCertificacion.RootTable.Groups("TipoCertificacion"))
                End If
            End If
        End If
    End Sub

#Region " Agrupación por Certificación "

    Protected Overridable Sub AplicarGrupoCertificacion()
        GridCertificacion.RootTable.Groups.Clear()
        If PermisoGrupoCertificacion() Then
            GridCertificacion.GroupByField("TipoCertificacion")
        End If
    End Sub

    Protected Overridable Function PermisoGrupoCertificacion() As Boolean
        Dim blnPermiso As Boolean

        With GridCertificacion
            Dim dt As DataTable = CType(GridCertificacion.DataSource, DataTable).Copy
            Dim dv As DataView = dt.DefaultView
            dv.RowFilter = "TipoCertificacion=" & enumTipoCertificacion.Cliente
            If dv.Count = 0 Then
                blnPermiso = True
            Else
                'dv.RowFilter = Nothing
                dv.RowFilter = "TipoCertificacion=" & enumTipoCertificacion.Produccion
                If dv.Count = 0 Then blnPermiso = True
            End If
        End With

        Return Not blnPermiso
    End Function

#End Region

    Protected Overridable Sub TabTiposCertificacion_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabTiposCertificacion.Click
        FiltrarGridCertificaciones()
    End Sub

#Region " AdvSearchCertificacion "

    Protected Overridable Sub AdvSearchCertificacion_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles AdvSearchCertificacion.SetPredefinedFilter
        If Length(Me.CurrentRow("IDObra")) > 0 Then
            e.Filter.Add(New NumberFilterItem("IDObra", Me.CurrentRow("IDObra")))
        End If
    End Sub

    Protected Overridable Sub AdvSearchCertificacion_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles AdvSearchCertificacion.SelectionChanged
        FiltrarGridCertificaciones()
    End Sub

#End Region

    Protected Overridable Sub chkVerUltimaCertificacion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkVerUltimaCertificacion.CheckedChanged
        AdvSearchCertificacion.Enabled = Not chkVerUltimaCertificacion.Checked
        AdvSearchCertificacion.Value = Nothing : AdvSearchCertificacion.Text = String.Empty

        FiltrarGridCertificaciones()
    End Sub

    Protected Overridable Sub optCertificacionPorTrabajo_PorCapitulo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optCertificacionPorTrabajo.CheckedChanged, optCertificacionPorCapitulos.CheckedChanged
        GridCertificacion_SelectionChanged(GridCertificacion, New EventArgs)
    End Sub

    Protected Overridable Sub GridCertificacion_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridCertificacion.SelectionChanged
        If Not IsNothing(drTrabajos) AndAlso Not IsNothing(GridCertificacion) AndAlso GridCertificacion.RowCount > 0 AndAlso Not GridCertificacion.GetValue("IDCertificacion") Is Nothing Then
            Dim f As New Filter
            f.Add("IDCertificacion", FilterOperator.Equal, GridCertificacion.Value("IDCertificacion"), FilterType.Numeric)
            If rbtNivelControl.Checked AndAlso Length(drTrabajos("IDTrabajo")) > 0 Then
                f.Add(New NumberFilterItem("IDTrabajo", drTrabajos("IDTrabajo")))
            ElseIf rbtMultinivelControl.Checked Then
                If Length(drTrabajos("Hijos")) > 0 Then
                    f.Add(New InListFilterItem("IDTrabajo", Split(drTrabajos("Hijos"), ",", ), FilterType.Numeric))
                Else
                    f.Add(New NoRowsFilterItem)
                End If
            End If
            If optCertificacionPorTrabajo.Checked Then
                f.Add(New NumberFilterItem("TipoLinea", enumTipoLineaTrabajo.tltTrabajo))
                f.Add(New NumberFilterItem("QPrev", FilterOperator.GreaterThan, 0))
            ElseIf optCertificacionPorCapitulos.Checked Then
                f.Add(New NumberFilterItem("TipoLinea", enumTipoLineaTrabajo.tltCapitulo))
            End If
            GridCertificacionTrabajo.ReQuery(f)

            If GridCertificacion.Value("Estado") = enumEstadoCertificacion.ecPendiente Then
                GridCertificacionTrabajo.Columns("IDCertificacion").DefaultValue = GridCertificacion.Value("IDCertificacion")
                GridCertificacionTrabajo.Columns("NCertificacion").DefaultValue = GridCertificacion.Value("NCertificacion")
                GridCertificacionTrabajo.Columns("TipoCertificacion").DefaultValue = GridCertificacion.Value("TipoCertificacion")
                ChangeDefaultViewGrid(rbtNivelControl.Checked, GridCertificacionTrabajo)
            End If
            ConfigAllowADDNewCertificacionTrabajo()
        Else
            GridCertificacionTrabajo.DataSource = Nothing
            GridCertificacionTrabajo.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False
        End If
    End Sub

    Protected Overridable Sub ConfigAllowADDNewCertificacionTrabajo()
        If GridCertificacion.Value("Estado") <> enumEstadoCertificacion.ecPendiente Then
            GridCertificacionTrabajo.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False
        ElseIf cbxTipoCertificacion.Value = enumTipoCertificacionCabecera.tccCapitulo Then 'And optCertificacionPorTrabajo.Checked Then
            GridCertificacionTrabajo.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False
        ElseIf cbxTipoCertificacion.Value = enumTipoCertificacionCabecera.tccTrabajo And optCertificacionPorCapitulos.Checked Then
            GridCertificacionTrabajo.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False
        Else
            GridCertificacionTrabajo.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True
        End If
    End Sub

    Protected Overridable Sub AplicarGrupoCertificacionTrabajo()
        If Not GridCertificacion.Columns("TipoCertificacion").IsGrouped Then
            GridCertificacion.RootTable.Groups.Add(New Janus.Windows.GridEX.GridEXGroup(GridCertificacion.Columns("TipoCertificacion"), Janus.Windows.GridEX.SortOrder.Ascending))
        End If
        'GridCertificacionTrabajo.RootTable.Groups.Clear()
        'If PermisoGrupo() Then
        '    GridCertificacionTrabajo.GroupByField("TipoCertificacion")
        'End If
    End Sub

    Protected Overridable Sub GridCertificacion_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridCertificacion.GotFocus
        With GridCertificacion
            .Columns("IDObra").DefaultValue = Me.CurrentRow("IDObra")
        End With
    End Sub

    Protected Overridable Sub GridCertificacion_EditingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles GridCertificacion.EditingCell
        With GridCertificacion
            e.Cancel = (.Value("Estado") = enumEstadoCertificacion.ecFacturado)
            Select Case e.Column.Key
                Case "TipoCertificacion"
                    e.Cancel = True
            End Select
        End With
    End Sub

    Protected Overridable Sub GridCertificacion_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridCertificacion.MouseUp
        If e.Button = MouseButtons.Right Then
            If Not IsNothing(GridCertificacion) AndAlso GridCertificacion.RowCount > 0 Then
                GridCertificacion.UiCommandManager1.Commands(cnCOPIARCERTIFICACIONCLIENTE).Visible = InheritableBoolean.False
                GridCertificacion.UiCommandManager1.Commands(cnCOPIARCERTIFICACIONPRODUCCION).Visible = InheritableBoolean.False
                If Not GridCertificacion.GetValue("CopiaGenerada") Then
                    Select Case CInt(GridCertificacion.Value("TipoCertificacion"))
                        Case enumTipoCertificacion.Cliente
                            GridCertificacion.UiCommandManager1.Commands(cnCOPIARCERTIFICACIONPRODUCCION).Visible = InheritableBoolean.True
                        Case enumTipoCertificacion.Produccion
                            GridCertificacion.UiCommandManager1.Commands(cnCOPIARCERTIFICACIONCLIENTE).Visible = InheritableBoolean.True
                    End Select
                End If
            End If
        End If
    End Sub

    Protected Overridable Sub GridCertificacion_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles GridCertificacion.FormattingRow
        With GridCertificacion
            If e.Row.RowType = RowType.Record Then
                Select Case CInt(e.Row.Cells("TipoCertificacion").Value)
                    Case enumTipoCertificacion.Cliente
                        e.Row.RowStyle = .FormatStyles("ClienteFormatStyle")
                    Case enumTipoCertificacion.Produccion
                        e.Row.RowStyle = .FormatStyles("ProduccionFormatStyle")
                End Select
            End If
        End With
    End Sub

    Protected Overridable Sub GridCertificacion_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridCertificacion.Click
        With GridCertificacion
            Dim hit As Janus.Windows.GridEX.GridArea = .HitTest()
            If hit = Janus.Windows.GridEX.GridArea.Cell Or hit = Janus.Windows.GridEX.GridArea.NewRowCell Then
                Dim c As Janus.Windows.GridEX.GridEXColumn = .ColumnFromPoint()
                If Not IsNothing(c) Then
                    Select Case c.Key
                        Case "BotonImpresion"
                            Dim FrmInforme As New frmSeleccionInformeCertificacion
                            If FrmInforme.ShowDialog = DialogResult.OK Then
                                Dim StrAlias As String = IIf(FrmInforme.TipoInforme = 1, "RPTCERDES", "RPTCERSIMP")
                                Dim RptInforme As New Report(StrAlias)
                                RptInforme.Filter.Add(New NumberFilterItem("IDCertificacion", FilterOperator.Equal, .GetValue("IDCertificacion")))

                                ExpertisApp.OpenReport(RptInforme)
                            End If
                    End Select
                End If
            End If
        End With
    End Sub

    Protected Overridable Sub GridCertificacion_UpdatingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles GridCertificacion.UpdatingCell
        With GridCertificacion
            If Not IsNothing(GridCertificacion) Then
                Select Case e.Column.Key
                    Case "Estado"
                        If e.Value = enumEstadoCertificacion.ecFacturado Then
                            e.Value = e.InitialValue
                        End If
                End Select
            End If
        End With
    End Sub

    Protected Overridable Sub GridCertificacion_UpdatingRecord(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GridCertificacion.AddingRecord, GridCertificacion.UpdatingRecord
        If GridCertificacion.RowCount > 0 Then
            If Length(GridCertificacion.Value("FechaCreacion")) = 0 Then
                e.Cancel = True
                ExpertisApp.GenerateMessage("La Fecha Creación es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

#End Region

#Region " Grid Certificacion Trabajo "

    Protected Overridable Sub GridCertificacionTrabajo_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridCertificacionTrabajo.SelectionChanged
        Dim f As New Solmicro.Expertis.Engine.Filter

        If Not IsNothing(GridCertificacionTrabajo) AndAlso Me.RecordsState <> RecordsState.Initialize Then
            If GridCertificacionTrabajo.Row <> Grid.newTopRowPosition Then
                If Length(GridCertificacionTrabajo.GetValue("IdLineaCertificacionTrabajo")) > 0 Then
                    f.Add("IdLineaCertificacionTrabajo", Solmicro.Expertis.Engine.FilterOperator.Equal, GridCertificacionTrabajo.Value("IdLineaCertificacionTrabajo"), Solmicro.Expertis.Engine.FilterType.Numeric)
                Else
                    f.Add("IdLineaCertificacionTrabajo", Solmicro.Expertis.Engine.FilterOperator.Equal, -1, Solmicro.Expertis.Engine.FilterType.Numeric)
                End If
                GridCertificacionMedicion.ReQuery(f)
            Else
                GridCertificacionMedicion.DataSource = Nothing
            End If
        End If
    End Sub

    Protected Overridable Sub GridCertificacionTrabajo_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridCertificacionTrabajo.GotFocus
        With GridCertificacionTrabajo
            .Columns("IDObra").DefaultValue = Me.CurrentRow("IDObra")
            If rbtNivelControl.Checked AndAlso Not IsNothing(drTrabajos) AndAlso Nz(drTrabajos("TipoLinea"), 0) = enumTipoLineaTrabajo.tltTrabajo Then
                If Length(drTrabajos("IDTrabajo")) > 0 Then .Columns("IDTrabajo").DefaultValue = drTrabajos("IDTrabajo")
                If Length(drTrabajos("CodTrabajo")) > 0 Then .Columns("CodTrabajo").DefaultValue = drTrabajos("CodTrabajo")
                If Length(drTrabajos("QPrev")) > 0 Then .Columns("QPrev").DefaultValue = drTrabajos("QPrev")
            Else
                .Columns("IDTrabajo").DefaultValue = DBNull.Value
                .Columns("CodTrabajo").DefaultValue = DBNull.Value
                .Columns("QPrev").DefaultValue = DBNull.Value
            End If
        End With
    End Sub

    Protected Overridable Sub GridCertificacionTrabajo_UpdatingRecord(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GridCertificacionTrabajo.UpdatingRecord, GridCertificacionTrabajo.AddingRecord
        If GridCertificacionTrabajo.RowCount > 0 Then
            If Length(GridCertificacionTrabajo.Value("CodTrabajo")) = 0 Then
                e.Cancel = True
                ExpertisApp.GenerateMessage("El Trabajo es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf Length(GridCertificacionTrabajo.Value("qpi")) = 0 Then
                e.Cancel = True
                ExpertisApp.GenerateMessage("PI es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf Length(GridCertificacionTrabajo.Value("PIPorc")) = 0 Then
                e.Cancel = True
                ExpertisApp.GenerateMessage("% PI es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf Length(GridCertificacionTrabajo.Value("PIOrigen")) = 0 Then
                e.Cancel = True
                ExpertisApp.GenerateMessage("PI Origen es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf Length(GridCertificacionTrabajo.Value("PIPorcOrigen")) = 0 Then
                e.Cancel = True
                ExpertisApp.GenerateMessage("% PI Origen es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                If GridCertificacionTrabajo.Value("IDLineaCertificacionTrabajo") = 0 Then
                    Dim dv As New DataView(CType(GridCertificacionTrabajo.DataSource, DataTable))
                    dv.RowFilter = "IDTrabajo= " & GridCertificacionTrabajo.Value("IDTrabajo") & " AND IDCertificacion= " & GridCertificacionTrabajo.Value("IDCertificacion")
                    If dv.Count > 0 Then
                        e.Cancel = True
                        ExpertisApp.GenerateMessage("Un trabajo no puede tener certificaciones repetidas.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                End If
            End If
        End If
    End Sub

    Protected Overridable Sub GridCertificacionTrabajo_AdvSearchSetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.GridAdvSearchFilterEventArgs) Handles GridCertificacionTrabajo.AdvSearchSetPredefinedFilter
        With GridCertificacionTrabajo
            Select Case e.Key
                Case "CodTrabajo"
                    e.Filter.Add("IdObra", FilterOperator.Equal, Me.CurrentRow("IDObra"), FilterType.Numeric)
                    e.Filter.Add("TipoFacturacion", FilterOperator.Equal, enumotTipoFacturacion.otfPorUdsObra, FilterType.Numeric)
                    Dim eor As New Filter(FilterUnionOperator.Or)
                    eor.Add("TipoLinea", FilterOperator.Equal, enumTipoLineaTrabajo.tltTrabajo, FilterType.Numeric)
                    eor.Add("TipoLinea", FilterOperator.Equal, enumTipoLineaTrabajo.tltTrabajoConcepto, FilterType.Numeric)
                    e.Filter.Add(eor)
                Case "NCertificacion"
                    e.Filter.Add("IdObra", FilterOperator.Equal, Me.CurrentRow("IDObra"), FilterType.Numeric)
                    e.Filter.Add("Estado", FilterOperator.Equal, enumEstadoCertificacion.ecPendiente, FilterType.Numeric)
            End Select
        End With
    End Sub

    Protected Overridable Sub GridCertificacionTrabajo_EditingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles GridCertificacionTrabajo.EditingCell
        With GridCertificacionTrabajo
            If .AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True And (.Row = Grid.newTopRowPosition OrElse (.Value("EstadoCertificacion") <> enumEstadoCertificacion.ecFacturado)) Then
                If optCertificacionPorTrabajo.Checked Then
                    Select Case e.Column.Key
                        Case "CodTrabajo"
                            If .Row <> Grid.newTopRowPosition AndAlso Length(.Value("CodTrabajo")) > 0 Then
                                e.Cancel = True
                                .Columns("CodTrabajo").ButtonStyle = ButtonStyle.NoButton
                            Else
                                .Columns("CodTrabajo").ButtonStyle = ButtonStyle.Image
                            End If
                        Case "TipoCertificacion"
                            e.Cancel = True
                    End Select
                ElseIf e.Column.Key <> "PIPorcOrigen" AndAlso e.Column.Key <> "PIPorc" Then
                    e.Cancel = True
                End If
            Else
                If Me.optCertificacionPorCapitulos.Checked AndAlso Me.cbxTipoCertificacion.Value = CInt(enumTipoCertificacionCabecera.tccCapitulo) Then
                    If e.Column.Key <> "PIPorcOrigen" AndAlso e.Column.Key <> "PIPorc" Then e.Cancel = True
                Else
                    e.Cancel = True
                End If
            End If

        End With
    End Sub

    Protected Overridable Sub GridCertificacionTrabajo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridCertificacionTrabajo.Click
        With GridCertificacionTrabajo
            If .Row <> -1 Then
                Dim hit As GridArea = .HitTest()
                If hit = GridArea.Cell Or hit = GridArea.NewRowCell Then
                    Dim c As GridEXColumn = .ColumnFromPoint()
                    If Not IsNothing(c) Then
                        Select Case c.Key
                            Case "Mediciones"
                                If GridCertificacionMedicion.RecordCount > 0 AndAlso Length(.Value("IDLineaCertificacionTrabajo")) > 0 Then
                                    Dim frm As New frmMedicionesCertificacion
                                    Dim dv As New DataView(GridCertificacionMedicion.DataSource)
                                    dv.RowFilter = "IdLineaCertificacionTrabajo=" & .Value("IDLineaCertificacionTrabajo")
                                    Dim dblTotal As Double
                                    Dim dr As DialogResult
                                    dr = frm.AbrirMediciones(.Value("IDLineaCertificacionTrabajo"), .Value("IDCertificacion"), _
                                                             .Value("NCertificacion"), .Value("DescCertificacion"), _
                                                             .Value("IDTrabajo"), .Value("CodTrabajo"), _
                                                             .Value("DescTrabajo"), .Value("QPrev"), .Value("TipoCertificacion"), _
                                                             .AllowAddNew, dv, dblTotal)
                                    If dr = DialogResult.OK Then
                                        GridCertificacionMedicion.DataSource = dv.Table
                                        .SetValue("Total", dblTotal)
                                    End If
                                End If
                        End Select
                    End If
                End If
            End If
        End With
    End Sub

    Protected Overridable Sub GridCertificacionTrabajo_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles GridCertificacionTrabajo.FormattingRow
        With GridCertificacionTrabajo
            If e.Row.RowType = RowType.Record Then
                Select Case CInt(e.Row.Cells("TipoCertificacion").Value)
                    Case enumTipoCertificacion.Cliente
                        e.Row.RowStyle = .FormatStyles("ClienteFormatStyle")
                    Case enumTipoCertificacion.Produccion
                        e.Row.RowStyle = .FormatStyles("ProduccionFormatStyle")
                End Select
            End If
        End With
    End Sub

    Protected Overridable Sub GridCertificacionTrabajo_FormattingColumns() Handles GridCertificacionTrabajo.FormattingColumns
        GridCertificacionTrabajo.Columns("Mediciones").Visible = optCertificacionPorTrabajo.Checked
    End Sub

#End Region

#End Region

#End Region

#Region " Pestaña Hitos Facturacion "

    Protected Overridable Sub HitosObraChecked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtHitosTrabajo.CheckedChanged, rbtHitosObra.CheckedChanged
        If Not IsNothing(dtTrabajos) AndAlso dtTrabajos.Rows.Count > 0 Then
            pnlVerHitos.Visible = rbtHitosTrabajo.Checked
            If Not IsNothing(Me.CurrentData) AndAlso Not blnChecked Then
                CheckedAll()
                TabTrabajos_Click(TabTrabajos, e)
            End If
        End If
    End Sub

    Protected Overridable Sub rbtMonedaCliente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtMonedaCliente.CheckedChanged, rbtMonedaA.CheckedChanged
        With GridVencimientos
            .Columns("PrecioVto").Visible = rbtMonedaCliente.Checked
            .Columns("PrecioVtoA").Visible = rbtMonedaA.Checked
            .Columns("ImpVencimiento").Visible = rbtMonedaCliente.Checked
            .Columns("ImpVencimientoA").Visible = rbtMonedaA.Checked
            .Columns("ImpIva").Visible = rbtMonedaCliente.Checked
            .Columns("ImpIvaA").Visible = rbtMonedaA.Checked
            .Columns("ImpTotal").Visible = rbtMonedaCliente.Checked
            .Columns("ImpTotalA").Visible = rbtMonedaA.Checked
        End With
    End Sub

    Protected Overridable Sub GridVencimientos_AdvSearchSetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.GridAdvSearchFilterEventArgs) Handles GridVencimientos.AdvSearchSetPredefinedFilter
        With GridVencimientos
            Select Case e.Key
                Case "CodTrabajo"
                    e.Filter.Add("IdObra", FilterOperator.Equal, Me.CurrentRow("IDObra"), FilterType.Numeric)
                Case "IDCContable"
                    e.Filter.Add("IDEjercicio", FilterOperator.Equal, mstrEjercicioActual, FilterType.String)
            End Select
        End With
    End Sub

    Protected Overridable Sub GridVencimientos_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridVencimientos.GotFocus
        With GridVencimientos
            .Columns("IDObra").DefaultValue = Me.CurrentRow("IDObra")
            .Columns("IDMoneda").DefaultValue = Me.CurrentRow("IDMoneda")
            .Columns("CambioA").DefaultValue = Me.CurrentRow("CambioA")
            .Columns("CambioB").DefaultValue = Me.CurrentRow("CambioB")
            .Columns("IDFormaPago").DefaultValue = Me.CurrentRow("IDFormaPago")
            .Columns("IDCondicionPago").DefaultValue = Me.CurrentRow("IDCondicionPago")
            .Columns("IDDiaPago").DefaultValue = Me.CurrentRow("IDDiaPago")
            .Columns("IDTipoIva").DefaultValue = Me.CurrentRow("IDTipoIva")
            If rbtHitosTrabajo.Checked AndAlso Not drTrabajos Is Nothing Then
                If Length(drTrabajos("IDTrabajo")) > 0 Then .Columns("IDTrabajo").DefaultValue = drTrabajos("IDTrabajo")
                If Length(drTrabajos("CodTrabajo")) > 0 Then .Columns("CodTrabajo").DefaultValue = drTrabajos("CodTrabajo")
                If Length(drTrabajos("CContable")) > 0 Then .Columns("IDCContable").DefaultValue = drTrabajos("CContable")
            Else
                .Columns("IDTrabajo").DefaultValue = DBNull.Value
                .Columns("CodTrabajo").DefaultValue = DBNull.Value
                .Columns("IDCContable").DefaultValue = DBNull.Value
            End If
            .Columns("SeguroCambio").DefaultValue = chkSeguroCambio.Checked
        End With
    End Sub

    Protected Overridable Sub GridVencimientos_EditingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles GridVencimientos.EditingCell
        With GridVencimientos
            Select Case e.Column.Key
                Case "CodTrabajo"
                    If .Row <> Grid.newTopRowPosition AndAlso Length(.Value("CodTrabajo")) > 0 Then
                        e.Cancel = True
                        .Columns("CodTrabajo").ButtonStyle = ButtonStyle.NoButton
                    Else
                        .Columns("CodTrabajo").ButtonStyle = ButtonStyle.Image
                    End If
                Case "PrecioVto"
                    If Not rbtMonedaCliente.Checked Then e.Cancel = True
                Case "PrecioVtoA"
                    If Not rbtMonedaA.Checked Then e.Cancel = True
            End Select
        End With
    End Sub

    Protected Overridable Sub GridVencimientos_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GridVencimientos.AddingRecord, GridVencimientos.UpdatingRecord
        With GridVencimientos
            If .RowCount > 0 Then
                If Length(.Value("CodTrabajo")) = 0 Then
                    e.Cancel = True
                    ExpertisApp.GenerateMessage("Trabajo es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                ElseIf Nz(.Value("Facturado"), False) Then
                    e.Cancel = True
                    ExpertisApp.GenerateMessage("El Hito ya está facturado, no se puede modificar.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If
        End With
    End Sub

    Protected Overridable Sub TotalesHitos(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridVencimientos.RecordAdded, GridVencimientos.RecordUpdated, GridVencimientos.RecordsDeleted
        With GridVencimientos
            txtTotalVtoA.Value = xRound(.GetTotal(.Columns("ImpVencimientoA"), Janus.Windows.GridEX.AggregateFunction.Sum), mintRedondeoA)
            txtTotalA.Value = xRound(.GetTotal(.Columns("ImpTotalA"), Janus.Windows.GridEX.AggregateFunction.Sum), mintRedondeoA)
        End With
    End Sub

    Protected Overridable Sub GridVencimientos_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles GridVencimientos.FormattingRow
        With GridVencimientos
            If e.Row.RowType = RowType.Record Then
                Select Case CInt(e.Row.Cells("TipoFactura").Value)
                    Case enumotfTipoFactura.otfHorasMOD
                        e.Row.RowStyle = .FormatStyles("MODFormatStyle")
                    Case enumotfTipoFactura.otfGastos
                        e.Row.RowStyle = .FormatStyles("GastoFormatStyle")
                    Case enumotfTipoFactura.otfAlquiler
                        e.Row.RowStyle = .FormatStyles("AlquilerFormatStyle")
                    Case enumotfTipoFactura.otfMateriales
                        e.Row.RowStyle = .FormatStyles("MaterialFormatStyle")
                End Select
            End If
        End With
    End Sub

    Protected Overridable Sub GridVencimientos_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridVencimientos.MouseUp
        If e.Button = MouseButtons.Right Then
            If Not IsNothing(GridVencimientos) AndAlso GridVencimientos.RowCount > 0 Then
                If Length(GridVencimientos.Value("IDFactura")) > 0 Then
                    GridVencimientos.UiCommandManager1.Commands(cnABRIRFACTURAVENTA).Visible = InheritableBoolean.True
                Else
                    GridVencimientos.UiCommandManager1.Commands(cnABRIRFACTURAVENTA).Visible = InheritableBoolean.False
                End If
            End If
        End If
    End Sub

#End Region

#Region " Pestaña Tareas "

    Protected Overridable Sub TareasObraChecked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtTareasTrabajo.CheckedChanged, rbtTareasObra.CheckedChanged
        If Not IsNothing(dtTrabajos) AndAlso dtTrabajos.Rows.Count > 0 Then
            pnlVerTareas.Visible = rbtTareasTrabajo.Checked
            If Not IsNothing(Me.CurrentData) AndAlso Not blnChecked Then
                CheckedAll()
                TabTrabajos_Click(TabTrabajos, New System.EventArgs)
            End If
        End If
    End Sub

    Protected Overridable Sub GridTareas_EditingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles GridTareas.EditingCell
        With GridTareas
            Select Case e.Column.Key
                Case "Incidencia"
                    If .Value("IDTipoTarea") Then
                        .Columns(e.Column.Key).EditType = Janus.Windows.GridEX.EditType.TextBox
                        .Columns(e.Column.Key).ButtonStyle = ButtonStyle.Image
                    Else
                        e.Cancel = True
                        .Columns(e.Column.Key).ButtonStyle = ButtonStyle.NoButton
                    End If
            End Select
        End With
    End Sub

    Protected Overridable Sub GridTareas_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridTareas.Click
        With GridTareas
            If .Row <> -1 Then
                Dim hit As GridArea = .HitTest()
                If hit = GridArea.Cell Or hit = GridArea.NewRowCell Then
                    Dim c As GridEXColumn = .ColumnFromPoint()
                    If Not IsNothing(c) Then
                        Select Case c.Key
                            Case "Texto"
                                Dim frm As New FormularioTexto
                                frm.Texto = .Value("Texto") & String.Empty
                                frm.ShowDialog()
                                If .Value("Texto") & String.Empty <> frm.Texto Then
                                    .SetValue("Texto", frm.Texto)
                                End If
                            Case "AbrirTarea"
                                If Length(.Value("IdTarea")) > 0 Then
                                    mblnRefresh = False
                                    AbrirMantenimientoTarea(.Value("IdTarea"))
                                    mblnRefresh = True
                                End If
                        End Select
                    End If
                End If
            End If
        End With
    End Sub

    Protected Overridable Sub GridTareas_AdvSearchSetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.GridAdvSearchFilterEventArgs) Handles GridTareas.AdvSearchSetPredefinedFilter
        With GridTareas
            Select Case e.Key
                Case "CodTrabajo"
                    e.Filter.Add("IdObra", FilterOperator.Equal, Me.CurrentRow("IDObra"), FilterType.Numeric)
                    Dim eor As New Filter(FilterUnionOperator.Or)
                    eor.Add("TipoLinea", FilterOperator.Equal, enumTipoLineaTrabajo.tltTrabajo, FilterType.Numeric)
                    eor.Add("TipoLinea", FilterOperator.Equal, enumTipoLineaTrabajo.tltTrabajoConcepto, FilterType.Numeric)
                    e.Filter.Add(eor)
            End Select
        End With
    End Sub

#End Region

#Region " Pestaña Operarios / Oficios "

    Protected Overridable Sub OperariosObraChecked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtOperariosTrabajo.CheckedChanged, rbtOperariosObra.CheckedChanged
        If Not IsNothing(dtTrabajos) AndAlso dtTrabajos.Rows.Count > 0 Then
            pnlVerOperarios.Visible = rbtOperariosTrabajo.Checked
            If Not IsNothing(Me.CurrentData) AndAlso Not blnChecked Then
                CheckedAll()
                TabTrabajos_Click(TabTrabajos, New System.EventArgs)
            End If
        End If
    End Sub

    Protected Overridable Sub GridOperariosTrabajo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridOperariosTrabajo.GotFocus
        With GridOperariosTrabajo
            .Columns("IDObra").DefaultValue = Me.CurrentRow("IDObra")
            If rbtOperariosTrabajo.Checked AndAlso Not IsNothing(drTrabajos) AndAlso Nz(drTrabajos("TipoLinea"), 0) = enumTipoLineaTrabajo.tltTrabajo Then
                If Length(drTrabajos("IDTrabajo")) > 0 Then .Columns("IDTrabajo").DefaultValue = drTrabajos("IDTrabajo")
                If Length(drTrabajos("CodTrabajo")) > 0 Then .Columns("CodTrabajo").DefaultValue = drTrabajos("CodTrabajo")
            Else
                .Columns("IDTrabajo").DefaultValue = DBNull.Value
                .Columns("CodTrabajo").DefaultValue = DBNull.Value
            End If
        End With
    End Sub

    Protected Overridable Sub GridOperariosTrabajo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridOperariosTrabajo.Click
        With GridOperariosTrabajo
            If .Row <> -1 Then
                Dim hit As GridArea = .HitTest()
                If hit = GridArea.Cell Or hit = GridArea.NewRowCell Then
                    Dim c As GridEXColumn = .ColumnFromPoint()
                    If Not IsNothing(c) Then
                        Select Case c.Key
                            Case "Texto"
                                Dim frm As New FormularioTexto
                                frm.Texto = .Value("Texto") & String.Empty
                                frm.ShowDialog()
                                If .Value("Texto") & String.Empty <> frm.Texto Then
                                    .SetValue("Texto", frm.Texto)
                                End If
                            Case "VerPlanificacion"
                                Dim data As New clsPlanificadorRecursosObras.dataPlanificacion(Me.CurrentRow("IDObra"))
                                If Not drTrabajos Is Nothing Then
                                    data.IDTrabajo = drTrabajos("IDTrabajo")
                                End If
                                data.IDOficio = .Value("IDOficio")
                                data.IDOperario = .Value("IDOperario") & String.Empty
                                Dim p As New clsPlanificadorRecursosObras
                                p.PlanificarDesdeTrabajos(data)
                        End Select
                    End If
                End If
            End If
        End With
    End Sub

    Protected Overridable Sub GridOperariosTrabajo_EditingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles GridOperariosTrabajo.EditingCell
        With GridOperariosTrabajo
            Select Case e.Column.Key
                Case "CodTrabajo"
                    If .Row <> Grid.newTopRowPosition AndAlso Length(.Value("CodTrabajo")) > 0 Then
                        e.Cancel = True
                        .Columns("CodTrabajo").ButtonStyle = ButtonStyle.NoButton
                    Else
                        .Columns("CodTrabajo").ButtonStyle = ButtonStyle.Image
                    End If
            End Select
        End With
    End Sub

    Protected Overridable Sub GridOperariosTrabajo_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GridOperariosTrabajo.AddingRecord, GridOperariosTrabajo.UpdatingRecord
        With GridOperariosTrabajo
            If .RowCount > 0 Then
                If Length(.Value("CodTrabajo")) = 0 Then
                    e.Cancel = True
                    ExpertisApp.GenerateMessage("Trabajo es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
                If Length(.Value("IDOficio")) = 0 Then
                    e.Cancel = True
                    ExpertisApp.GenerateMessage("El Oficio es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If
        End With
    End Sub

    Protected Overridable Sub GridOperariosTrabajo_AdvSearchSetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.GridAdvSearchFilterEventArgs) Handles GridOperariosTrabajo.AdvSearchSetPredefinedFilter
        With GridOperariosTrabajo
            Select Case e.Key
                Case "CodTrabajo"
                    e.Filter.Add("IdObra", FilterOperator.Equal, Me.CurrentRow("IDObra"), FilterType.Numeric)
                    Dim eor As New Filter(FilterUnionOperator.Or)
                    eor.Add("TipoLinea", FilterOperator.Equal, enumTipoLineaTrabajo.tltTrabajo, FilterType.Numeric)
                    eor.Add("TipoLinea", FilterOperator.Equal, enumTipoLineaTrabajo.tltTrabajoConcepto, FilterType.Numeric)
                    e.Filter.Add(eor)
                Case "IDOperario"
                    If Length(.Value("IDOficio")) > 0 Then e.Filter.Add("IDOficio", FilterOperator.Equal, .Value("IDOficio"), FilterType.String)
            End Select
        End With
    End Sub


#End Region

#Region " Pestaña Avance "

    Protected Overridable Sub GridAvanceTrabajo_EditingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles GridAvanceTrabajo.EditingCell
        Select Case e.Column.Key
            Case "Cerrado"
            Case "AvanceAutomatico"
                e.Cancel = GridAvanceTrabajo.Value("Cerrado")
                'Case Else
                '    e.Cancel = (GridAvanceTrabajo.Value("Cerrado") Or GridAvanceTrabajo.Value("AvanceAutomatico"))
        End Select
    End Sub

    Private Enum IconoValoracionAvance
        Buena
        Mala
    End Enum
    Protected Overridable Sub GridAvanceTrabajo_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles GridAvanceTrabajo.FormattingRow
        With GridAvanceTrabajo
            If e.Row.RowType = RowType.Record Then
                If Nz(e.Row.Cells("PeriodoRecalculado").Value) Then
                    e.Row.RowStyle = .FormatStyles("PeriodoRecalculadoFormatStyle")
                End If
                If Nz(e.Row.Cells("AvancePrevisto").Value) > Nz(e.Row.Cells("AvanceRealCliente").Value) Then
                    e.Row.Cells("IconoAvanceRealCliente").ImageIndex = IconoValoracionAvance.Mala
                Else
                    e.Row.Cells("IconoAvanceRealCliente").ImageIndex = IconoValoracionAvance.Buena
                End If
                If Nz(e.Row.Cells("AvancePrevisto").Value) > Nz(e.Row.Cells("AvanceRealProduccion").Value) Then
                    e.Row.Cells("IconoAvanceRealProduccion").ImageIndex = IconoValoracionAvance.Mala
                Else
                    e.Row.Cells("IconoAvanceRealProduccion").ImageIndex = IconoValoracionAvance.Buena
                End If
            End If
        End With
    End Sub

#End Region

#End Region

#Region " Arbol Estructura/Costes "

    Protected Overridable Sub cmbObraPadre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbObraPadre.Click
        If Length(Me.CurrentRow("IDObraPadre")) > 0 Then RefreshObra(Me.CurrentRow("IDObraPadre"))
    End Sub

    Protected Overridable Sub PintarArbolObras(ByVal tvwTreeViewObj As TreeView, ByVal etipo As eTipoArbol)
        If Not tvwTreeViewObj.Enabled Then tvwTreeViewObj.Enabled = True
        tvwTreeViewObj.Visible = False
        tvwTreeViewObj.ImageList = ImageList1
        tvwTreeViewObj.Nodes.Clear()

        mdblTotalPrev = 0 : mdblTotalPrevVenta = 0
        mdblTotalReal = 0 : mdblTotalFact = 0
        If etipo = eTipoArbol.enumtipoEstructura Then
            PintarNodoEstructuraObra(tvwTreeViewObj, Me.CurrentRow("IDObra"), Me.CurrentRow("NObra"), _
                                     Me.CurrentRow("DescObra") & String.Empty, _
                                     Me.CurrentRow("ImpPrevA"), Me.CurrentRow("ImpPrevVentaA"), _
                                     Me.CurrentRow("ImpRealA"), Me.CurrentRow("ImpFactA"), Nothing)

            txtTotalEstructuraPrev.Value = mdblTotalPrev
            txtTotalEstructuraPrevVta.Value = mdblTotalPrevVenta
            txtTotalEstructuraReal.Value = mdblTotalReal
            txtTotalEstructuraFact.Value = mdblTotalFact

        ElseIf etipo = eTipoArbol.enumtipoCoste Then
            PintarNodoCostesObra(tvwTreeViewObj, Me.CurrentRow("IDObra"), Me.CurrentRow("NObra"), _
                                 Me.CurrentRow("ImpPrevA"), Me.CurrentRow("ImpPrevVentaA"), _
                                 Me.CurrentRow("ImpRealA"), Me.CurrentRow("ImpFactA"), 0, Nothing)

            txtTotalCostePrev.Value = mdblTotalPrev
            txtTotalCostePrevVta.Value = mdblTotalPrevVenta
            txtTotalCosteReal.Value = mdblTotalReal
            txtTotalCosteFact.Value = mdblTotalFact
        End If

        tvwTreeViewObj.Visible = True
        tvwTreeViewObj.ExpandAll()
        tvwTreeViewObj.Refresh()
    End Sub

#Region " Arbol Estructura "

    Protected Overridable Sub chkVerTrabajos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkVerTrabajos.CheckedChanged
        PintarArbolObras(tvwEstructura, eTipoArbol.enumtipoEstructura)
    End Sub

    Protected Overridable Sub PintarNodoEstructuraObra(ByVal tvwTreeViewObj As TreeView, ByVal intIdObra As Integer, ByVal strNObra As String, _
                                     ByVal strDescObra As String, ByVal dblTotalQPrevA As Double, _
                                     ByVal dblTotalQPrevVentaA As Double, ByVal dblTotalQRealA As Double, _
                                     ByVal dblTotalQFactA As Double, ByVal oNode As TreeNode)

        Dim strText As String = "Proyecto: " & strNObra & " - " & strDescObra
        strText = strText & " (**IMPORTES** : PREVISTO: " & Format(dblTotalQPrevA, "#,##0.00") & Space(5)
        strText = strText & " PREVISTO VENTA: " & Format(dblTotalQPrevVentaA, "#,##0.00") & Space(5)
        strText = strText & " REAL: " & Format(dblTotalQRealA, "#,##0.00") & Space(5)
        strText = strText & " FACTURADO: " & Format(dblTotalQFactA, "#,##0.00") & ")"

        mdblTotalPrev = mdblTotalPrev + dblTotalQPrevA
        mdblTotalPrevVenta = mdblTotalPrevVenta + dblTotalQPrevVentaA
        mdblTotalReal = mdblTotalReal + dblTotalQRealA
        mdblTotalFact = mdblTotalFact + dblTotalQFactA

        If Length(mstrListaObrasEstructura) > 0 Then mstrListaObrasEstructura = mstrListaObrasEstructura & ","
        mstrListaObrasEstructura = mstrListaObrasEstructura & "*" & intIdObra & "*"

        If oNode Is Nothing Then
            oNode = tvwTreeViewObj.Nodes.Add(strText)
        Else
            oNode = oNode.Nodes.Add(strText)
        End If
        oNode.Tag = New TagObra(intIdObra, dblTotalQPrevA, dblTotalQPrevVentaA, dblTotalQRealA, dblTotalQFactA)
        oNode.ImageIndex = 2
        oNode.SelectedImageIndex = 7
        oNode.Expand()
        ''''''''''''''''''
        'pintar las costes
        Dim dtObras As DataTable = New BE.DataEngine().Filter("vMntoObrasCosteObras", New NumberFilterItem("IDObra", intIdObra))

        For Each drObras As DataRow In dtObras.Select
            PintarNodoCostesObra(tvwTreeViewObj, drObras("IDObraHija"), drObras("NObraHija"), _
                                 drObras("TotalPrevA"), drObras("TotalPrevVentaA"), drObras("TotalRealA"), _
                                 drObras("TotalFactA"), drObras("Porcentaje"), oNode, False)
        Next
        ''''''''''''''''''
        If chkVerTrabajos.Checked Then
            Dim dtT As DataTable = New ObraTrabajo().Filter(New FilterItem("IDObra", FilterOperator.Equal, intIdObra))
            PintarTrabajos(tvwTreeViewObj, dtT.DefaultView, oNode)
        End If

        'pintar las subobras
        'Dim strWhere As String = "IDObraPadre = " & intIdObra
        dtObras = New ObraCabecera().Filter(New NumberFilterItem("IDObraPadre", intIdObra))


        For Each drObras As DataRow In dtObras.Select
            PintarNodoEstructuraObra(tvwTreeViewObj, drObras("IDObra"), drObras("NObra"), drObras("DescObra") & String.Empty, _
                                     drObras("ImpPrevA"), drObras("ImpPrevVentaA"), drObras("ImpRealA"), _
                                     drObras("ImpFactA"), oNode)
        Next

    End Sub

    Protected Overridable Sub tvwEstructura_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvwEstructura.AfterSelect
        e.Node.EnsureVisible()

        If TypeOf e.Node.Tag Is TagObra Then
            txtTotalPrevTree.Value = CType(e.Node.Tag, TagObra).TotalPrev
            txtTotalPrevVentaTree.Value = CType(e.Node.Tag, TagObra).TotalPrevVenta
            txtTotalRealTree.Value = CType(e.Node.Tag, TagObra).TotalReal
            txtTotalFacturadoTree.Value = CType(e.Node.Tag, TagObra).TotalFact
        End If
    End Sub

    Protected Overridable Sub tvwEstructura_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tvwEstructura.MouseDown
        If e.Button = MouseButtons.Right Then
            Dim n As TreeNode = tvwEstructura.GetNodeAt(e.X, e.Y)
            MnuVerObras.Visible = False
            If Not IsNothing(n) Then
                If TypeOf n.Tag Is TagObra Then
                    mintIDObraSeleccionado = CType(n.Tag, TagObra).IDObra
                ElseIf TypeOf n.Tag Is TagTrabajo Then
                    mintIDObraSeleccionado = CType(n.Tag, TagTrabajo).IDObra
                End If
                If Me.CurrentRow("IDObra") <> mintIDObraSeleccionado Then
                    'MnuVerObras.Visible = True
                    MenuEstructura.Show()
                End If
            End If
        End If
    End Sub

    Protected Overridable Sub MnuVerObras_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles MnuVerObras.Click
        If mintIDObraSeleccionado > 0 Then
            Me.GotoRecord(DataProviderActions.GoFirst, New NumberFilterItem("IDObra", mintIDObraSeleccionado))
        End If
    End Sub

#End Region

#Region " Arbol Costes "

    Protected Overridable Sub PintarNodoCostesObra(ByVal tvwTreeViewObj As TreeView, ByVal intIdObra As Integer, _
                                     ByVal strNObra As String, ByVal dblTotalPrevA As Double, _
                                     ByVal dblTotalPrevVentaA As Double, ByVal dblTotalRealA As Double, _
                                     ByVal dblTotalFactA As Double, ByVal dblPorcentaje As Double, _
                                     ByVal oNode As TreeNode, Optional ByVal blnPintarSubNodos As Boolean = True)

        Dim intImagen As Integer = 4

        Dim strText As String = "Proyecto: " & strNObra
        If dblPorcentaje <> 0 Then
            intImagen = 5
            strText = strText & " ( " & dblPorcentaje & "% )"
        End If
        strText = strText & Space(2)
        strText = strText & " PREVISTO: " & Format(dblTotalPrevA, "#,##0.00") & Space(5)
        strText = strText & " PREVISTO VENTA: " & Format(dblTotalPrevVentaA, "#,##0.00") & Space(5)
        strText = strText & " REAL: " & Format(dblTotalRealA, "#,##0.00") & Space(5)
        strText = strText & " FACTURADO: " & Format(dblTotalFactA, "#,##0.00")

        mdblTotalPrev = mdblTotalPrev + dblTotalPrevA
        mdblTotalPrevVenta = mdblTotalPrevVenta + dblTotalPrevVentaA
        mdblTotalReal = mdblTotalReal + dblTotalRealA
        mdblTotalFact = mdblTotalFact + dblTotalFactA

        mstrListaObrasCoste = mstrListaObrasCoste & "*" & intIdObra & "*"

        If oNode Is Nothing Then
            oNode = tvwTreeViewObj.Nodes.Add(strText)
        Else
            oNode = oNode.Nodes.Add(strText)
        End If
        oNode.Tag = New TagObra(intIdObra, dblTotalPrevA, dblTotalPrevVentaA, dblTotalRealA, dblTotalFactA)
        oNode.ImageIndex = intImagen
        oNode.SelectedImageIndex = intImagen
        oNode.Expand()

        'pintar las subobras
        If blnPintarSubNodos Then
            Dim dtObras As DataTable = New BE.DataEngine().Filter("vMntoObrasCosteObras", New FilterItem("IDObra", FilterOperator.Equal, intIdObra))
            For Each drObras As DataRow In dtObras.Select
                PintarNodoCostesObra(tvwTreeViewObj, drObras("IDObraHija"), drObras("NObraHija"), _
                                     drObras("TotalPrevA"), drObras("TotalPrevVentaA"), drObras("TotalRealA"), _
                                     drObras("TotalFactA"), drObras("Porcentaje"), oNode)
            Next
        End If
    End Sub
#End Region

#End Region

#Region " Pestaña Recursos "

    Protected Overridable Sub GridRecursos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridRecursos.Click
        With GridRecursos
            If .Row <> -1 Then
                Dim hit As GridArea = .HitTest()
                If hit = GridArea.Cell Or hit = GridArea.NewRowCell Then
                    Dim c As GridEXColumn = .ColumnFromPoint()
                    If Not IsNothing(c) Then
                        Select Case c.Key
                            Case "Texto"
                                Dim frm As New FormularioTexto
                                frm.Texto = .Value("Texto") & String.Empty
                                frm.ShowDialog()
                                If .Value("Texto") & String.Empty <> frm.Texto Then
                                    .SetValue("Texto", frm.Texto)
                                End If
                        End Select
                    End If
                End If
            End If
        End With
    End Sub

#End Region

#Region " Pestaña Seguimiento "

    Protected Overridable Sub AdvIDObraPadre_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles AdvIDObraPadre.Validating
        If Length(AdvIDObraPadre.Text) > 0 Then
            If ExisteEnArbolEstructura() Then
                ExpertisApp.GenerateMessage("La Obra seleccionada ya forma parte de la estructura de la obra |.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, Me.CurrentRow("NObra"))
                e.Cancel = True
            End If
        End If
    End Sub

    Protected Overridable Function ExisteEnArbolEstructura() As Boolean
        ExisteEnArbolEstructura = False
        If Length(mstrListaObrasEstructura) = 0 Then PintarArbolObras(tvwEstructura, eTipoArbol.enumtipoEstructura)
        If InStr(1, mstrListaObrasEstructura, "*" & AdvIDObraPadre.Text & "*", vbTextCompare) Then ExisteEnArbolEstructura = True
    End Function

    Protected Overridable Function ExisteEnArbolCostes(ByVal intIDObra As Integer) As Boolean
        ExisteEnArbolCostes = False
        If Length(mstrListaObrasCoste) = 0 Then PintarArbolObras(tvwCostes, eTipoArbol.enumtipoCoste)
        If InStr(1, mstrListaObrasCoste, "*" & intIDObra & "*", vbTextCompare) Then ExisteEnArbolCostes = True
    End Function

    Protected Overridable Overloads Sub CmbUrlContrato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbUrlContrato.Click
        OpenDialog1.InitialDirectory = ExpertisApp.Path
        OpenDialog1.ShowDialog()

        If OpenDialog1.FileName <> String.Empty Then
            txtURLContrato.Text = OpenDialog1.FileName
        End If
    End Sub

#Region " GridCostes "

    Protected Overridable Sub GridCostes_UpdatingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles GridCostes.UpdatingCell
        With GridCostes
            Select Case e.Column.Key
                Case "NObraHija"
                    If e.Value <> Me.CurrentRow("NObra") Then
                        If Length(.Value("IDObraHija")) > 0 Then
                            e.Cancel = ExisteEnArbolCostes(.Value("IDObraHija"))
                            If e.Cancel Then
                                ExpertisApp.GenerateMessage("El Proyecto seleccionado ya forma parte del coste del Proyecto '|'.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, Me.CurrentRow("NObra"))
                            End If
                        End If
                    Else
                        ExpertisApp.GenerateMessage("El Proyecto seleccionado ya forma parte del coste del Proyecto '|'.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, Me.CurrentRow("NObra"))
                        e.Cancel = True
                        e.Value = e.InitialValue
                    End If
            End Select
        End With
    End Sub

    Protected Overridable Sub GridCostes_AdvSearchSetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.GridAdvSearchFilterEventArgs) Handles GridCostes.AdvSearchSetPredefinedFilter
        With GridCostes
            Select Case e.Key
                Case "NObraHija"
                    e.Filter.Add(New NumberFilterItem("IDObra", FilterOperator.NotEqual, Me.CurrentRow("IDObra")))
            End Select
        End With
    End Sub

    Protected Overridable Sub GridCostes_AddingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GridCostes.AddingRecord
        If Length(GridCostes.Value("NObraHija")) = 0 Then
            e.Cancel = True
            ExpertisApp.GenerateMessage("El Proyecto Hijo es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

#End Region

    Protected Overridable Sub txtGastosGenerales_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGastosGenerales.LostFocus
        txtTotalGastosGenerales.Value = txtImpPrevVentaA.Value * txtGastosGenerales.Value / 100
    End Sub

    Protected Overridable Sub txtBeneficioIndustrial_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBeneficioIndustrial.LostFocus
        txtTotalBeneficioIndustrial.Value = txtImpPrevVentaA.Value * txtBeneficioIndustrial.Value / 100
    End Sub

    Protected Overridable Sub txtCoefBaja_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCoefBaja.LostFocus
        txtTotalCoefBaja.Value = -(txtImpPrevVentaA.Value * Math.Abs(txtCoefBaja.Value) / 100)
    End Sub

#End Region

#Region " Proveedores "

    Protected Overridable Sub GridProveedores_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridProveedores.GotFocus
        With GridProveedores
            .Columns("TipoRetencion").DefaultValue = CInt(enumTipoRetencion.troSobreBI)
            .Columns("Impuestos").DefaultValue = TipoRetencionImpuestos.DespuesImpuestos
        End With
    End Sub

    Protected Overridable Sub GridProveedores_EditingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles GridProveedores.EditingCell
        With GridProveedores
            Select Case e.Column.Key
                Case "IDProveedor"
                    If .Row = Grid.newTopRowPosition Then
                        e.Column.EditType = EditType.TextBox
                        e.Column.ButtonStyle = ButtonStyle.Image
                    Else
                        e.Column.ButtonStyle = ButtonStyle.NoButton
                        e.Cancel = True
                    End If
            End Select
        End With
    End Sub

    Protected Overridable Sub GridProveedores_AddingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GridProveedores.AddingRecord
        With GridProveedores
            If Length(.Value("IDProveedor")) = 0 Then
                e.Cancel = True
                ExpertisApp.GenerateMessage("El Proveedor es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Dim dv As New DataView(CType(GridProveedores.DataSource, DataTable))
                dv.RowFilter = "IDObra= " & Me.CurrentRow("IDObra") & " AND IDProveedor= '" & .Value("IDProveedor") & "'"
                If dv.Count > 0 Then
                    e.Cancel = True
                    ExpertisApp.GenerateMessage("El Proveedor ya está en esta obra.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If

                If Length(.Value("FechaRetencion")) = 0 AndAlso (Length(.Value("Periodo")) = 0 OrElse Length(.Value("TipoPeriodo")) = 0) Then
                    e.Cancel = True
                    ExpertisApp.GenerateMessage("Debe indicar la Fecha de Retención, o bien, el Período.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End With
    End Sub

#End Region

#Region " Business Calling "

    Protected Overridable Sub MntoObras_BusinessCalling(ByVal sender As Object, ByVal e As Engine.UI.BusinessCallingEventArgs) Handles MyBase.BusinessCalling
        e.Data.Context.Clear()
        e.Data.Context("IDCliente") = Me.CurrentRow("IDCliente")

        Select Case e.EntityName
            Case GridTrabajos.EntityName
                e.Data.Context("FechaIniCab") = Me.CurrentRow("FechaInicio")
                e.Data.Context("FechaFinCab") = Me.CurrentRow("FechaFin")
                If TypeOf GridTrabajos.DataSource Is DataView Then
                    e.Data.Context("dtTrabajos") = CType(GridTrabajos.DataSource, DataView).Table
                Else
                    e.Data.Context("dtTrabajos") = GridTrabajos.DataSource
                End If

                '//Si cambiamos el campo Facturable
                mblnCambioFacturableTrabajo = e.Data.NewData.ContainsKey("Facturable")

                '//Si cambiamos el campo TipoFacturacion
                mblnCambioTipoFacturacion = e.Data.NewData.ContainsKey("TipoFacturacion")

                '//Si es Facturable por Conceptos: Si cambiamos el campo TipoFacturación (a valor PorConceptos) OR no cambiamos el campo TipoFacturacion, pero tiene el valor PorConceptos.
                mblnFacturablePorConceptos = (e.Data.NewData.ContainsKey("TipoFacturacion") AndAlso e.Data.NewData("TipoFacturacion") = enumotTipoFacturacion.otfPorConceptos) OrElse _
                                             (Not e.Data.NewData.ContainsKey("TipoFacturacion") AndAlso Not drTrabajos Is Nothing AndAlso drTrabajos("TipoFacturacion") = enumotTipoFacturacion.otfPorConceptos)

                If Not drTrabajos Is Nothing Then
                    e.Data.Context("CodTrabajo") = drTrabajos("CodTrabajo") 'GridTrabajos.Value("CodTrabajo") & String.Empty
                    If rbtPorNivelTrabajos.Checked Then
                        e.Data.Context("PorNivel") = rbtPorNivelTrabajos.Checked
                        e.Data.Context("IDTrabajoPadre") = drTrabajos("IDTrabajo")
                        e.Data.Context("CodTrabajoPadre") = drTrabajos("CodTrabajo")
                        e.Data.Context("QPrevPadre") = drTrabajos("QPrev")
                    End If
                    If Length(drTrabajos("IDTrabajoPadre")) > 0 Then
                        Dim dr() As DataRow = dtTrabajos.Select(New NumberFilterItem("IDtrabajo", drTrabajos("IDTrabajoPadre")).Compose(New AdoFilterComposer))
                        If dr.Length > 0 Then e.Data.Context("QPrevPadre") = dr(0)("QPrev")
                    End If
                End If
            Case GridMaterialPrev.EntityName
                e.Data.Context("IDEjercicio") = mstrEjercicioActual
                e.Data.Context("Fecha") = Me.CurrentRow("FechaInicio")
                e.Data.Context("QPrevTrabajo") = Nz(GridMaterialPrev.Value("QPrevTrabajo"), 0)
            Case GridMODPrev.EntityName
                e.Data.Context("QPrevTrabajo") = Nz(GridMODPrev.Value("QPrevTrabajo"), 0)
            Case GridCentrosPrev.EntityName
                e.Data.Context("QPrevTrabajo") = Nz(GridCentrosPrev.Value("QPrevTrabajo"), 0)
            Case GridCostes.EntityName
                e.Data.Context("PorcImputado") = GridCostes.Value("PorcImputado")
            Case GridCertificacionTrabajo.EntityName
                e.Data.Context("QPrev") = GridCertificacionTrabajo.Value("QPrev")
                e.Data.Context("IDTipoCertificacion") = GridCertificacionTrabajo.Value("TipoCertificacion")
            Case GridAvanceTrabajo.EntityName
                e.Data.Context("QPrevTrabajo") = drTrabajos("QPrev")
            Case GridVencimientos.EntityName
                e.Data.Context("EnMonedaA") = rbtMonedaA.Checked
                'Case GridTramos.EntityName
                '    e.Data.Context("FechaIniCab") = Me.CurrentRow("FechaInicio")
                '    e.Data.Context("FechaFinCab") = Me.CurrentRow("FechaFin")
                '    e.Data.Context("NumeroLineas") = GridTrabajos.RowCount
                '    e.Data.Context("Lineas") = GridTramos.DataSource
        End Select
    End Sub

    Protected Overridable Sub MntoObras_BusinessCalled(ByVal sender As Object, ByVal e As Engine.UI.BusinessCalledEventArgs) Handles MyBase.BusinessCalled
        Select Case e.EntityName
            Case GridCostes.EntityName
                If Not IsNothing(e.Data) AndAlso e.Data.ContainsKey("PorcImputado") Then
                    GridCostes.Value("PorcImputado") = Nz(e.Data("PorcImputado"), 0)
                End If
                'If e.EntityName = ndTrabajos.EntityName Then
                '    blnRefreshArbol = True
                'End If
            Case GridTrabajos.EntityName
                If ((mblnCambioFacturableTrabajo OrElse mblnCambioTipoFacturacion) AndAlso mblnFacturablePorConceptos) Then
                    If GridMaterialPrev.RowCount > 0 OrElse GridMODPrev.RowCount > 0 OrElse GridCentrosPrev.RowCount > 0 OrElse GridGastosPrev.RowCount > 0 OrElse GridVariosPrev.RowCount > 0 Then
                        ExpertisApp.GenerateMessage("Se ha modificado el campo Facturable o el Tipo Facturación del Trabajo {0}. Revise los previstos del Proyecto.", MessageBoxButtons.OK, MessageBoxIcon.Information, Quoted(e.Data("Codtrabajo")))
                    End If
                End If
        End Select
        If Not IsNothing(e.Data) Then
            If e.Data.ContainsKey("Iva") Then txtTotalIva.Value = Nz(e.Data("Iva"), 0)
            If e.Data.ContainsKey("Total") Then txtTotal.Value = Nz(e.Data("Total"), 0)
            '    If e.Data.ContainsKey("Qprev") AndAlso txtQPrev.Value <> Nz(e.Data("Qprev"), 1) Then txtQPrev.Value = Nz(e.Data("Qprev"), 1)
        End If
    End Sub

#End Region

#Region " TAGs "

    Private Class TagTrabajo
        Public IDObra, IDTrabajo As Integer

        Public Sub New(ByVal intIDObra As Integer, ByVal intIDTrabajo As Integer)
            IDObra = intIDObra
            IDTrabajo = intIDTrabajo
        End Sub
    End Class

    Private Class TagObra
        Public IDObra As Integer
        Public TotalPrev, TotalPrevVenta, TotalReal, TotalFact As Double

        Public Sub New(ByVal intObra As Integer, Optional ByVal dblTotalPrev As Double = 0, _
                       Optional ByVal dblTotalPrevVenta As Double = 0, _
                       Optional ByVal dblTotalReal As Double = 0, _
                       Optional ByVal dblTotalFact As Double = 0)

            IDObra = intObra
            TotalPrev = dblTotalPrev
            TotalPrevVenta = dblTotalPrevVenta
            TotalReal = dblTotalReal
            TotalFact = dblTotalFact
        End Sub
    End Class

    'Private Class TagTrabajoTipo
    '    Public IDObra As Integer
    '    Public IDTipoTrabajo, IDSubTipoTrabajo As String
    '    Public GetDatarow As DataRow

    '    Public Sub New(ByVal drTrabajo As DataRow)
    '        IDObra = drTrabajo("IDObra")
    '        IDTipoTrabajo = drTrabajo("IdTipoTrabajo") & String.Empty
    '        GetDatarow = drTrabajo
    '    End Sub
    'End Class
#End Region

    Protected Overridable Sub MntoObras_RecordCanceling(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.RecordCanceling
        blnRecordStateChanged = True
        blnRefreshArbol = True
    End Sub

End Class