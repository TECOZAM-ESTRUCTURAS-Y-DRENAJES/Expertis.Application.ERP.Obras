Public Class frmDesgloseImportesTrabajo
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
    Friend WithEvents txtDescTrabajoPrev As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtTrabajoPrev As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents cmbCerrar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents FraTotalTrabajo As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents lblTotal As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtImpPrevQTrabajoVentaA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtImpPrevQTrabajoA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtImpFactQTrabajoA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtImpRealQTrabajoA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents FraReal As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents txtQReal As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblImpReal As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtImpRealModA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtImpRealCentrosA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtImpRealGastosA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtImpRealVariosA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtImpRealMatA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtImpFactMatA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtImpFactVariosA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtImpFactGastosA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtImpFactCentrosA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtImpFactModA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblImpFact As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblPorcReal As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtMargenRealMat As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtMargenRealMod As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtMargenRealCentros As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtMargenRealGastos As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtMargenRealVarios As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents TabImportes As Solmicro.Expertis.Engine.UI.Tab
    Friend WithEvents UiTabPageTotales As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents UiTabPageUnitarios As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents lblTotalUnitario As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblMOD As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblCentros As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblGastos As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblVarios As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblMateriales As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblQPrev As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtImpPrevTrabajoA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblCostePrev As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtImpPrevModA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtImpPrevCentrosA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtImpPrevGastosA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtImpPrevVariosA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtImpPrevMatA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtMargenPrevVarios As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtMargenPrevGastos As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtMargenPrevCentro As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtMargenPrevMod As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtMargenPrevMat As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblPorcPrev As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtImpPrevMatVentaA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtImpPrevVariosVentaA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtImpPrevGastosVentaA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtImpPrevCentrosVentaA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtImpPrevModVentaA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblImpVentaPrev As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtImpPrevTrabajoVentaA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtQPrev As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lbQlMOD As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblQCentros As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblQGastos As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblQVarios As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lbQlMateriales As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblNoAcumula As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtMargenPrevTrabajo As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtMargenRealTrabajo As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblQReal As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblCosteQPrev As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtImpPrevQModA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtImpPrevQCentrosA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtImpPrevQGastosA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtImpPrevQVariosA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtImpPrevQMatA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblPorcQPrev As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtImpPrevQMatVentaA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtImpPrevVariosQVentaA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtImpPrevGastosQVentaA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtImpPrevCentrosQVentaA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtImpPrevQModVentaA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblImpVentaQPrev As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents pnlBotones As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents pnlTop As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents Linea3 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents Linea1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtMargenPrevQVarios As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtMargenPrevQGastos As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtMargenPrevQCentro As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtMargenPrevQMod As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtMargenPrevQMat As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents Linea2 As Janus.Windows.EditControls.UIGroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.pnlBotones = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmbCerrar = New Solmicro.Expertis.Engine.UI.Button
        Me.pnlTop = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblNoAcumula = New Solmicro.Expertis.Engine.UI.Label
        Me.txtDescTrabajoPrev = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTrabajoPrev = New Solmicro.Expertis.Engine.UI.TextBox
        Me.FraTotalTrabajo = New Solmicro.Expertis.Engine.UI.Frame
        Me.txtMargenRealTrabajo = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtMargenPrevTrabajo = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImpFactQTrabajoA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImpRealQTrabajoA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblTotal = New Solmicro.Expertis.Engine.UI.Label
        Me.txtImpPrevQTrabajoVentaA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImpPrevQTrabajoA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.FraReal = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblQReal = New Solmicro.Expertis.Engine.UI.Label
        Me.Linea3 = New Janus.Windows.EditControls.UIGroupBox
        Me.txtQReal = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblImpReal = New Solmicro.Expertis.Engine.UI.Label
        Me.txtImpRealModA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImpRealCentrosA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImpRealGastosA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImpRealVariosA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImpRealMatA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImpFactMatA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImpFactVariosA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImpFactGastosA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImpFactCentrosA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImpFactModA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblImpFact = New Solmicro.Expertis.Engine.UI.Label
        Me.lblPorcReal = New Solmicro.Expertis.Engine.UI.Label
        Me.txtMargenRealMat = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtMargenRealMod = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtMargenRealCentros = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtMargenRealGastos = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtMargenRealVarios = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.TabImportes = New Solmicro.Expertis.Engine.UI.Tab
        Me.UiTabPageTotales = New Janus.Windows.UI.Tab.UITabPage
        Me.lbQlMOD = New Solmicro.Expertis.Engine.UI.Label
        Me.lblQCentros = New Solmicro.Expertis.Engine.UI.Label
        Me.lblQGastos = New Solmicro.Expertis.Engine.UI.Label
        Me.lblQVarios = New Solmicro.Expertis.Engine.UI.Label
        Me.lbQlMateriales = New Solmicro.Expertis.Engine.UI.Label
        Me.lblCosteQPrev = New Solmicro.Expertis.Engine.UI.Label
        Me.txtImpPrevQModA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImpPrevQCentrosA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImpPrevQGastosA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImpPrevQVariosA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.Linea1 = New Janus.Windows.EditControls.UIGroupBox
        Me.txtImpPrevQMatA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtMargenPrevQVarios = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtMargenPrevQGastos = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtMargenPrevQCentro = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtMargenPrevQMod = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtMargenPrevQMat = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblPorcQPrev = New Solmicro.Expertis.Engine.UI.Label
        Me.txtImpPrevQMatVentaA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImpPrevVariosQVentaA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImpPrevGastosQVentaA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImpPrevCentrosQVentaA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImpPrevQModVentaA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblImpVentaQPrev = New Solmicro.Expertis.Engine.UI.Label
        Me.UiTabPageUnitarios = New Janus.Windows.UI.Tab.UITabPage
        Me.lblTotalUnitario = New Solmicro.Expertis.Engine.UI.Label
        Me.lblMOD = New Solmicro.Expertis.Engine.UI.Label
        Me.lblCentros = New Solmicro.Expertis.Engine.UI.Label
        Me.lblGastos = New Solmicro.Expertis.Engine.UI.Label
        Me.lblVarios = New Solmicro.Expertis.Engine.UI.Label
        Me.lblMateriales = New Solmicro.Expertis.Engine.UI.Label
        Me.lblQPrev = New Solmicro.Expertis.Engine.UI.Label
        Me.txtImpPrevTrabajoA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblCostePrev = New Solmicro.Expertis.Engine.UI.Label
        Me.txtImpPrevModA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImpPrevCentrosA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImpPrevGastosA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImpPrevVariosA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.Linea2 = New Janus.Windows.EditControls.UIGroupBox
        Me.txtImpPrevMatA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtMargenPrevVarios = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtMargenPrevGastos = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtMargenPrevCentro = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtMargenPrevMod = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtMargenPrevMat = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblPorcPrev = New Solmicro.Expertis.Engine.UI.Label
        Me.txtImpPrevMatVentaA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImpPrevVariosVentaA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImpPrevGastosVentaA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImpPrevCentrosVentaA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImpPrevModVentaA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblImpVentaPrev = New Solmicro.Expertis.Engine.UI.Label
        Me.txtImpPrevTrabajoVentaA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtQPrev = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.pnlBotones.suspendlayout()
        Me.pnlTop.suspendlayout()
        Me.FraTotalTrabajo.SuspendLayout()
        Me.FraReal.SuspendLayout()
        CType(Me.Linea3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabImportes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabImportes.SuspendLayout()
        Me.UiTabPageTotales.SuspendLayout()
        CType(Me.Linea1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTabPageUnitarios.SuspendLayout()
        CType(Me.Linea2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlBotones
        '
        Me.pnlBotones.Controls.Add(Me.cmbCerrar)
        Me.pnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBotones.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlBotones.Location = New System.Drawing.Point(0, 306)
        Me.pnlBotones.Name = "pnlBotones"
        Me.pnlBotones.Size = New System.Drawing.Size(646, 42)
        Me.pnlBotones.TabIndex = 231
        '
        'cmbCerrar
        '
        Me.cmbCerrar.Location = New System.Drawing.Point(280, 7)
        Me.cmbCerrar.Name = "cmbCerrar"
        Me.cmbCerrar.Size = New System.Drawing.Size(94, 29)
        Me.cmbCerrar.TabIndex = 21
        Me.cmbCerrar.Text = "Cerrar"
        '
        'pnlTop
        '
        Me.pnlTop.Controls.Add(Me.lblNoAcumula)
        Me.pnlTop.Controls.Add(Me.txtDescTrabajoPrev)
        Me.pnlTop.Controls.Add(Me.lblTrabajo)
        Me.pnlTop.Controls.Add(Me.txtTrabajoPrev)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(646, 33)
        Me.pnlTop.TabIndex = 301
        '
        'lblNoAcumula
        '
        Me.lblNoAcumula.Location = New System.Drawing.Point(483, 8)
        Me.lblNoAcumula.Name = "lblNoAcumula"
        Me.lblNoAcumula.Size = New System.Drawing.Size(164, 13)
        Me.lblNoAcumula.TabIndex = 304
        Me.lblNoAcumula.Text = "NO ACUMULA EN TRABAJO "
        Me.lblNoAcumula.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDescTrabajoPrev
        '
        Me.TryDataBinding(txtDescTrabajoPrev, New System.Windows.Forms.Binding("Text", Me, "DescTrabajo", True))
        Me.txtDescTrabajoPrev.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescTrabajoPrev.Enabled = False
        Me.txtDescTrabajoPrev.Location = New System.Drawing.Point(179, 4)
        Me.txtDescTrabajoPrev.Name = "txtDescTrabajoPrev"
        Me.txtDescTrabajoPrev.Size = New System.Drawing.Size(300, 21)
        Me.txtDescTrabajoPrev.TabIndex = 303
        Me.txtDescTrabajoPrev.TabStop = False
        '
        'lblTrabajo
        '
        Me.lblTrabajo.Location = New System.Drawing.Point(6, 7)
        Me.lblTrabajo.Name = "lblTrabajo"
        Me.lblTrabajo.Size = New System.Drawing.Size(51, 13)
        Me.lblTrabajo.TabIndex = 302
        Me.lblTrabajo.Tag = ""
        Me.lblTrabajo.Text = "Trabajo"
        '
        'txtTrabajoPrev
        '
        Me.TryDataBinding(txtTrabajoPrev, New System.Windows.Forms.Binding("Text", Me, "CodTrabajo", True))
        Me.txtTrabajoPrev.DisabledBackColor = System.Drawing.Color.White
        Me.txtTrabajoPrev.Enabled = False
        Me.txtTrabajoPrev.Location = New System.Drawing.Point(63, 4)
        Me.txtTrabajoPrev.Name = "txtTrabajoPrev"
        Me.txtTrabajoPrev.Size = New System.Drawing.Size(112, 21)
        Me.txtTrabajoPrev.TabIndex = 301
        Me.txtTrabajoPrev.TabStop = False
        '
        'FraTotalTrabajo
        '
        Me.FraTotalTrabajo.Controls.Add(Me.txtMargenRealTrabajo)
        Me.FraTotalTrabajo.Controls.Add(Me.txtMargenPrevTrabajo)
        Me.FraTotalTrabajo.Controls.Add(Me.txtImpFactQTrabajoA)
        Me.FraTotalTrabajo.Controls.Add(Me.txtImpRealQTrabajoA)
        Me.FraTotalTrabajo.Controls.Add(Me.lblTotal)
        Me.FraTotalTrabajo.Controls.Add(Me.txtImpPrevQTrabajoVentaA)
        Me.FraTotalTrabajo.Controls.Add(Me.txtImpPrevQTrabajoA)
        Me.FraTotalTrabajo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FraTotalTrabajo.Location = New System.Drawing.Point(0, 265)
        Me.FraTotalTrabajo.Name = "FraTotalTrabajo"
        Me.FraTotalTrabajo.Size = New System.Drawing.Size(646, 41)
        Me.FraTotalTrabajo.TabIndex = 305
        Me.FraTotalTrabajo.TabStop = False
        '
        'txtMargenRealTrabajo
        '
        Me.txtMargenRealTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.txtMargenRealTrabajo.Enabled = False
        Me.txtMargenRealTrabajo.Location = New System.Drawing.Point(484, 13)
        Me.txtMargenRealTrabajo.Name = "txtMargenRealTrabajo"
        Me.txtMargenRealTrabajo.Size = New System.Drawing.Size(51, 21)
        Me.txtMargenRealTrabajo.TabIndex = 368
        Me.txtMargenRealTrabajo.TabStop = False
        '
        'txtMargenPrevTrabajo
        '
        Me.txtMargenPrevTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.txtMargenPrevTrabajo.Enabled = False
        Me.txtMargenPrevTrabajo.Location = New System.Drawing.Point(211, 13)
        Me.txtMargenPrevTrabajo.Name = "txtMargenPrevTrabajo"
        Me.txtMargenPrevTrabajo.Size = New System.Drawing.Size(51, 21)
        Me.txtMargenPrevTrabajo.TabIndex = 352
        Me.txtMargenPrevTrabajo.TabStop = False
        '
        'txtImpFactQTrabajoA
        '
        Me.TryDataBinding(txtImpFactQTrabajoA, New System.Windows.Forms.Binding("Value", Me, "ImpFactTrabajoA", True))
        Me.txtImpFactQTrabajoA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpFactQTrabajoA.Enabled = False
        Me.txtImpFactQTrabajoA.Location = New System.Drawing.Point(539, 13)
        Me.txtImpFactQTrabajoA.Name = "txtImpFactQTrabajoA"
        Me.txtImpFactQTrabajoA.Size = New System.Drawing.Size(100, 21)
        Me.txtImpFactQTrabajoA.TabIndex = 351
        Me.txtImpFactQTrabajoA.TabStop = False
        '
        'txtImpRealQTrabajoA
        '
        Me.TryDataBinding(txtImpRealQTrabajoA, New System.Windows.Forms.Binding("Value", Me, "ImpRealTrabajoA", True))
        Me.txtImpRealQTrabajoA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpRealQTrabajoA.Enabled = False
        Me.txtImpRealQTrabajoA.Location = New System.Drawing.Point(380, 13)
        Me.txtImpRealQTrabajoA.Name = "txtImpRealQTrabajoA"
        Me.txtImpRealQTrabajoA.Size = New System.Drawing.Size(100, 21)
        Me.txtImpRealQTrabajoA.TabIndex = 350
        Me.txtImpRealQTrabajoA.TabStop = False
        '
        'lblTotal
        '
        Me.lblTotal.Location = New System.Drawing.Point(10, 13)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(92, 13)
        Me.lblTotal.TabIndex = 349
        Me.lblTotal.Tag = ""
        Me.lblTotal.Text = "TOTAL Trabajo"
        '
        'txtImpPrevQTrabajoVentaA
        '
        Me.txtImpPrevQTrabajoVentaA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPrevQTrabajoVentaA.Enabled = False
        Me.txtImpPrevQTrabajoVentaA.Location = New System.Drawing.Point(265, 13)
        Me.txtImpPrevQTrabajoVentaA.Name = "txtImpPrevQTrabajoVentaA"
        Me.txtImpPrevQTrabajoVentaA.Size = New System.Drawing.Size(100, 21)
        Me.txtImpPrevQTrabajoVentaA.TabIndex = 348
        Me.txtImpPrevQTrabajoVentaA.TabStop = False
        '
        'txtImpPrevQTrabajoA
        '
        Me.txtImpPrevQTrabajoA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPrevQTrabajoA.Enabled = False
        Me.txtImpPrevQTrabajoA.Location = New System.Drawing.Point(108, 13)
        Me.txtImpPrevQTrabajoA.Name = "txtImpPrevQTrabajoA"
        Me.txtImpPrevQTrabajoA.Size = New System.Drawing.Size(100, 21)
        Me.txtImpPrevQTrabajoA.TabIndex = 347
        Me.txtImpPrevQTrabajoA.TabStop = False
        '
        'FraReal
        '
        Me.FraReal.Controls.Add(Me.lblQReal)
        Me.FraReal.Controls.Add(Me.Linea3)
        Me.FraReal.Controls.Add(Me.txtQReal)
        Me.FraReal.Controls.Add(Me.lblImpReal)
        Me.FraReal.Controls.Add(Me.txtImpRealModA)
        Me.FraReal.Controls.Add(Me.txtImpRealCentrosA)
        Me.FraReal.Controls.Add(Me.txtImpRealGastosA)
        Me.FraReal.Controls.Add(Me.txtImpRealVariosA)
        Me.FraReal.Controls.Add(Me.txtImpRealMatA)
        Me.FraReal.Controls.Add(Me.txtImpFactMatA)
        Me.FraReal.Controls.Add(Me.txtImpFactVariosA)
        Me.FraReal.Controls.Add(Me.txtImpFactGastosA)
        Me.FraReal.Controls.Add(Me.txtImpFactCentrosA)
        Me.FraReal.Controls.Add(Me.txtImpFactModA)
        Me.FraReal.Controls.Add(Me.lblImpFact)
        Me.FraReal.Controls.Add(Me.lblPorcReal)
        Me.FraReal.Controls.Add(Me.txtMargenRealMat)
        Me.FraReal.Controls.Add(Me.txtMargenRealMod)
        Me.FraReal.Controls.Add(Me.txtMargenRealCentros)
        Me.FraReal.Controls.Add(Me.txtMargenRealGastos)
        Me.FraReal.Controls.Add(Me.txtMargenRealVarios)
        Me.FraReal.Dock = System.Windows.Forms.DockStyle.Right
        Me.FraReal.Location = New System.Drawing.Point(373, 33)
        Me.FraReal.Name = "FraReal"
        Me.FraReal.Size = New System.Drawing.Size(273, 232)
        Me.FraReal.TabIndex = 306
        Me.FraReal.TabStop = False
        Me.FraReal.Text = "Coste Real y Facturado"
        '
        'lblQReal
        '
        Me.lblQReal.AutoSize = False
        Me.lblQReal.Location = New System.Drawing.Point(7, 181)
        Me.lblQReal.Name = "lblQReal"
        Me.lblQReal.Size = New System.Drawing.Size(100, 21)
        Me.lblQReal.TabIndex = 373
        Me.lblQReal.Tag = ""
        Me.lblQReal.Text = "C. Real"
        Me.lblQReal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Linea3
        '
        Me.Linea3.Location = New System.Drawing.Point(2, 172)
        Me.Linea3.Name = "Linea3"
        Me.Linea3.Size = New System.Drawing.Size(265, 3)
        Me.Linea3.TabIndex = 372
        '
        'txtQReal
        '
        Me.TryDataBinding(txtQReal, New System.Windows.Forms.Binding("Value", Me, "QReal", True))
        Me.txtQReal.DisabledBackColor = System.Drawing.Color.White
        Me.txtQReal.Enabled = False
        Me.txtQReal.Location = New System.Drawing.Point(7, 204)
        Me.txtQReal.Name = "txtQReal"
        Me.txtQReal.Size = New System.Drawing.Size(100, 21)
        Me.txtQReal.TabIndex = 371
        Me.txtQReal.TabStop = False
        '
        'lblImpReal
        '
        Me.lblImpReal.AutoSize = False
        Me.lblImpReal.Location = New System.Drawing.Point(7, 27)
        Me.lblImpReal.Name = "lblImpReal"
        Me.lblImpReal.Size = New System.Drawing.Size(100, 21)
        Me.lblImpReal.TabIndex = 368
        Me.lblImpReal.Tag = ""
        Me.lblImpReal.Text = "Coste Real"
        Me.lblImpReal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtImpRealModA
        '
        Me.TryDataBinding(txtImpRealModA, New System.Windows.Forms.Binding("Value", Me, "ImpRealModA", True))
        Me.txtImpRealModA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpRealModA.Enabled = False
        Me.txtImpRealModA.Location = New System.Drawing.Point(7, 76)
        Me.txtImpRealModA.Name = "txtImpRealModA"
        Me.txtImpRealModA.Size = New System.Drawing.Size(100, 21)
        Me.txtImpRealModA.TabIndex = 365
        Me.txtImpRealModA.TabStop = False
        '
        'txtImpRealCentrosA
        '
        Me.TryDataBinding(txtImpRealCentrosA, New System.Windows.Forms.Binding("Value", Me, "ImpRealCentrosA", True))
        Me.txtImpRealCentrosA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpRealCentrosA.Enabled = False
        Me.txtImpRealCentrosA.Location = New System.Drawing.Point(7, 100)
        Me.txtImpRealCentrosA.Name = "txtImpRealCentrosA"
        Me.txtImpRealCentrosA.Size = New System.Drawing.Size(100, 21)
        Me.txtImpRealCentrosA.TabIndex = 364
        Me.txtImpRealCentrosA.TabStop = False
        '
        'txtImpRealGastosA
        '
        Me.TryDataBinding(txtImpRealGastosA, New System.Windows.Forms.Binding("Value", Me, "ImpRealGastosA", True))
        Me.txtImpRealGastosA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpRealGastosA.Enabled = False
        Me.txtImpRealGastosA.Location = New System.Drawing.Point(7, 124)
        Me.txtImpRealGastosA.Name = "txtImpRealGastosA"
        Me.txtImpRealGastosA.Size = New System.Drawing.Size(100, 21)
        Me.txtImpRealGastosA.TabIndex = 363
        Me.txtImpRealGastosA.TabStop = False
        '
        'txtImpRealVariosA
        '
        Me.TryDataBinding(txtImpRealVariosA, New System.Windows.Forms.Binding("Value", Me, "ImpRealVariosA", True))
        Me.txtImpRealVariosA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpRealVariosA.Enabled = False
        Me.txtImpRealVariosA.Location = New System.Drawing.Point(7, 148)
        Me.txtImpRealVariosA.Name = "txtImpRealVariosA"
        Me.txtImpRealVariosA.Size = New System.Drawing.Size(100, 21)
        Me.txtImpRealVariosA.TabIndex = 362
        Me.txtImpRealVariosA.TabStop = False
        '
        'txtImpRealMatA
        '
        Me.TryDataBinding(txtImpRealMatA, New System.Windows.Forms.Binding("Value", Me, "ImpRealMatA", True))
        Me.txtImpRealMatA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpRealMatA.Enabled = False
        Me.txtImpRealMatA.Location = New System.Drawing.Point(7, 52)
        Me.txtImpRealMatA.Name = "txtImpRealMatA"
        Me.txtImpRealMatA.Size = New System.Drawing.Size(100, 21)
        Me.txtImpRealMatA.TabIndex = 361
        Me.txtImpRealMatA.TabStop = False
        '
        'txtImpFactMatA
        '
        Me.TryDataBinding(txtImpFactMatA, New System.Windows.Forms.Binding("Value", Me, "ImpFactMatA", True))
        Me.txtImpFactMatA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpFactMatA.Enabled = False
        Me.txtImpFactMatA.Location = New System.Drawing.Point(164, 52)
        Me.txtImpFactMatA.Name = "txtImpFactMatA"
        Me.txtImpFactMatA.Size = New System.Drawing.Size(100, 21)
        Me.txtImpFactMatA.TabIndex = 360
        Me.txtImpFactMatA.TabStop = False
        '
        'txtImpFactVariosA
        '
        Me.TryDataBinding(txtImpFactVariosA, New System.Windows.Forms.Binding("Value", Me, "ImpFactVariosA", True))
        Me.txtImpFactVariosA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpFactVariosA.Enabled = False
        Me.txtImpFactVariosA.Location = New System.Drawing.Point(164, 148)
        Me.txtImpFactVariosA.Name = "txtImpFactVariosA"
        Me.txtImpFactVariosA.Size = New System.Drawing.Size(100, 21)
        Me.txtImpFactVariosA.TabIndex = 359
        Me.txtImpFactVariosA.TabStop = False
        '
        'txtImpFactGastosA
        '
        Me.TryDataBinding(txtImpFactGastosA, New System.Windows.Forms.Binding("Value", Me, "ImpFactGastosA", True))
        Me.txtImpFactGastosA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpFactGastosA.Enabled = False
        Me.txtImpFactGastosA.Location = New System.Drawing.Point(164, 124)
        Me.txtImpFactGastosA.Name = "txtImpFactGastosA"
        Me.txtImpFactGastosA.Size = New System.Drawing.Size(100, 21)
        Me.txtImpFactGastosA.TabIndex = 358
        Me.txtImpFactGastosA.TabStop = False
        '
        'txtImpFactCentrosA
        '
        Me.TryDataBinding(txtImpFactCentrosA, New System.Windows.Forms.Binding("Value", Me, "ImpFactCentrosA", True))
        Me.txtImpFactCentrosA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpFactCentrosA.Enabled = False
        Me.txtImpFactCentrosA.Location = New System.Drawing.Point(164, 100)
        Me.txtImpFactCentrosA.Name = "txtImpFactCentrosA"
        Me.txtImpFactCentrosA.Size = New System.Drawing.Size(100, 21)
        Me.txtImpFactCentrosA.TabIndex = 357
        Me.txtImpFactCentrosA.TabStop = False
        '
        'txtImpFactModA
        '
        Me.TryDataBinding(txtImpFactModA, New System.Windows.Forms.Binding("Value", Me, "ImpFactModA", True))
        Me.txtImpFactModA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpFactModA.Enabled = False
        Me.txtImpFactModA.Location = New System.Drawing.Point(164, 76)
        Me.txtImpFactModA.Name = "txtImpFactModA"
        Me.txtImpFactModA.Size = New System.Drawing.Size(100, 21)
        Me.txtImpFactModA.TabIndex = 356
        Me.txtImpFactModA.TabStop = False
        '
        'lblImpFact
        '
        Me.lblImpFact.AutoSize = False
        Me.lblImpFact.Location = New System.Drawing.Point(164, 27)
        Me.lblImpFact.Name = "lblImpFact"
        Me.lblImpFact.Size = New System.Drawing.Size(103, 21)
        Me.lblImpFact.TabIndex = 369
        Me.lblImpFact.Tag = ""
        Me.lblImpFact.Text = "Imp. Facturado"
        Me.lblImpFact.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPorcReal
        '
        Me.lblPorcReal.AutoSize = False
        Me.lblPorcReal.Location = New System.Drawing.Point(110, 27)
        Me.lblPorcReal.Name = "lblPorcReal"
        Me.lblPorcReal.Size = New System.Drawing.Size(51, 21)
        Me.lblPorcReal.TabIndex = 370
        Me.lblPorcReal.Tag = "IdRec=7121;"
        Me.lblPorcReal.Text = "% Real"
        Me.lblPorcReal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMargenRealMat
        '
        Me.txtMargenRealMat.DisabledBackColor = System.Drawing.Color.White
        Me.txtMargenRealMat.Enabled = False
        Me.txtMargenRealMat.Location = New System.Drawing.Point(110, 52)
        Me.txtMargenRealMat.Name = "txtMargenRealMat"
        Me.txtMargenRealMat.Size = New System.Drawing.Size(51, 21)
        Me.txtMargenRealMat.TabIndex = 354
        Me.txtMargenRealMat.TabStop = False
        '
        'txtMargenRealMod
        '
        Me.txtMargenRealMod.DisabledBackColor = System.Drawing.Color.White
        Me.txtMargenRealMod.Enabled = False
        Me.txtMargenRealMod.Location = New System.Drawing.Point(110, 76)
        Me.txtMargenRealMod.Name = "txtMargenRealMod"
        Me.txtMargenRealMod.Size = New System.Drawing.Size(51, 21)
        Me.txtMargenRealMod.TabIndex = 353
        Me.txtMargenRealMod.TabStop = False
        '
        'txtMargenRealCentros
        '
        Me.txtMargenRealCentros.DisabledBackColor = System.Drawing.Color.White
        Me.txtMargenRealCentros.Enabled = False
        Me.txtMargenRealCentros.Location = New System.Drawing.Point(110, 100)
        Me.txtMargenRealCentros.Name = "txtMargenRealCentros"
        Me.txtMargenRealCentros.Size = New System.Drawing.Size(51, 21)
        Me.txtMargenRealCentros.TabIndex = 352
        Me.txtMargenRealCentros.TabStop = False
        '
        'txtMargenRealGastos
        '
        Me.txtMargenRealGastos.DisabledBackColor = System.Drawing.Color.White
        Me.txtMargenRealGastos.Enabled = False
        Me.txtMargenRealGastos.Location = New System.Drawing.Point(110, 124)
        Me.txtMargenRealGastos.Name = "txtMargenRealGastos"
        Me.txtMargenRealGastos.Size = New System.Drawing.Size(51, 21)
        Me.txtMargenRealGastos.TabIndex = 351
        Me.txtMargenRealGastos.TabStop = False
        '
        'txtMargenRealVarios
        '
        Me.txtMargenRealVarios.DisabledBackColor = System.Drawing.Color.White
        Me.txtMargenRealVarios.Enabled = False
        Me.txtMargenRealVarios.Location = New System.Drawing.Point(110, 148)
        Me.txtMargenRealVarios.Name = "txtMargenRealVarios"
        Me.txtMargenRealVarios.Size = New System.Drawing.Size(51, 21)
        Me.txtMargenRealVarios.TabIndex = 350
        Me.txtMargenRealVarios.TabStop = False
        '
        'TabImportes
        '
        Me.TabImportes.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.TabImportes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabImportes.Location = New System.Drawing.Point(0, 33)
        Me.TabImportes.Name = "TabImportes"
        Me.TabImportes.Size = New System.Drawing.Size(373, 232)
        Me.TabImportes.TabIndex = 307
        Me.TabImportes.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.UiTabPageTotales, Me.UiTabPageUnitarios})
        Me.TabImportes.UseThemes = True
        '
        'UiTabPageTotales
        '
        Me.UiTabPageTotales.Controls.Add(Me.lbQlMOD)
        Me.UiTabPageTotales.Controls.Add(Me.lblQCentros)
        Me.UiTabPageTotales.Controls.Add(Me.lblQGastos)
        Me.UiTabPageTotales.Controls.Add(Me.lblQVarios)
        Me.UiTabPageTotales.Controls.Add(Me.lbQlMateriales)
        Me.UiTabPageTotales.Controls.Add(Me.lblCosteQPrev)
        Me.UiTabPageTotales.Controls.Add(Me.txtImpPrevQModA)
        Me.UiTabPageTotales.Controls.Add(Me.txtImpPrevQCentrosA)
        Me.UiTabPageTotales.Controls.Add(Me.txtImpPrevQGastosA)
        Me.UiTabPageTotales.Controls.Add(Me.txtImpPrevQVariosA)
        Me.UiTabPageTotales.Controls.Add(Me.Linea1)
        Me.UiTabPageTotales.Controls.Add(Me.txtImpPrevQMatA)
        Me.UiTabPageTotales.Controls.Add(Me.txtMargenPrevQVarios)
        Me.UiTabPageTotales.Controls.Add(Me.txtMargenPrevQGastos)
        Me.UiTabPageTotales.Controls.Add(Me.txtMargenPrevQCentro)
        Me.UiTabPageTotales.Controls.Add(Me.txtMargenPrevQMod)
        Me.UiTabPageTotales.Controls.Add(Me.txtMargenPrevQMat)
        Me.UiTabPageTotales.Controls.Add(Me.lblPorcQPrev)
        Me.UiTabPageTotales.Controls.Add(Me.txtImpPrevQMatVentaA)
        Me.UiTabPageTotales.Controls.Add(Me.txtImpPrevVariosQVentaA)
        Me.UiTabPageTotales.Controls.Add(Me.txtImpPrevGastosQVentaA)
        Me.UiTabPageTotales.Controls.Add(Me.txtImpPrevCentrosQVentaA)
        Me.UiTabPageTotales.Controls.Add(Me.txtImpPrevQModVentaA)
        Me.UiTabPageTotales.Controls.Add(Me.lblImpVentaQPrev)
        Me.UiTabPageTotales.Key = "Totales"
        Me.UiTabPageTotales.Location = New System.Drawing.Point(1, 21)
        Me.UiTabPageTotales.Name = "UiTabPageTotales"
        Me.UiTabPageTotales.Size = New System.Drawing.Size(371, 210)
        Me.UiTabPageTotales.TabStop = True
        Me.UiTabPageTotales.Text = "Importes totales"
        '
        'lbQlMOD
        '
        Me.lbQlMOD.Location = New System.Drawing.Point(10, 54)
        Me.lbQlMOD.Name = "lbQlMOD"
        Me.lbQlMOD.Size = New System.Drawing.Size(46, 13)
        Me.lbQlMOD.TabIndex = 393
        Me.lbQlMOD.Tag = "IdRec=5749;"
        Me.lbQlMOD.Text = "M.O.D."
        '
        'lblQCentros
        '
        Me.lblQCentros.Location = New System.Drawing.Point(10, 78)
        Me.lblQCentros.Name = "lblQCentros"
        Me.lblQCentros.Size = New System.Drawing.Size(52, 13)
        Me.lblQCentros.TabIndex = 394
        Me.lblQCentros.Tag = "IdRec=5748;"
        Me.lblQCentros.Text = "Centros"
        '
        'lblQGastos
        '
        Me.lblQGastos.Location = New System.Drawing.Point(10, 102)
        Me.lblQGastos.Name = "lblQGastos"
        Me.lblQGastos.Size = New System.Drawing.Size(46, 13)
        Me.lblQGastos.TabIndex = 395
        Me.lblQGastos.Tag = "IdRec=5747;"
        Me.lblQGastos.Text = "Gastos"
        '
        'lblQVarios
        '
        Me.lblQVarios.Location = New System.Drawing.Point(10, 126)
        Me.lblQVarios.Name = "lblQVarios"
        Me.lblQVarios.Size = New System.Drawing.Size(43, 13)
        Me.lblQVarios.TabIndex = 396
        Me.lblQVarios.Tag = "IdRec=5333;"
        Me.lblQVarios.Text = "Varios"
        '
        'lbQlMateriales
        '
        Me.lbQlMateriales.Location = New System.Drawing.Point(10, 30)
        Me.lbQlMateriales.Name = "lbQlMateriales"
        Me.lbQlMateriales.Size = New System.Drawing.Size(65, 13)
        Me.lbQlMateriales.TabIndex = 398
        Me.lbQlMateriales.Tag = "IdRec=5750;"
        Me.lbQlMateriales.Text = "Materiales"
        '
        'lblCosteQPrev
        '
        Me.lblCosteQPrev.AutoSize = False
        Me.lblCosteQPrev.Location = New System.Drawing.Point(107, 6)
        Me.lblCosteQPrev.Name = "lblCosteQPrev"
        Me.lblCosteQPrev.Size = New System.Drawing.Size(100, 21)
        Me.lblCosteQPrev.TabIndex = 392
        Me.lblCosteQPrev.Tag = "IdRec=6720;"
        Me.lblCosteQPrev.Text = "Coste Previsto"
        Me.lblCosteQPrev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtImpPrevQModA
        '
        Me.TryDataBinding(txtImpPrevQModA, New System.Windows.Forms.Binding("Value", Me, "ImpPrevQModA", True))
        Me.txtImpPrevQModA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPrevQModA.Enabled = False
        Me.txtImpPrevQModA.Location = New System.Drawing.Point(107, 54)
        Me.txtImpPrevQModA.Name = "txtImpPrevQModA"
        Me.txtImpPrevQModA.Size = New System.Drawing.Size(100, 21)
        Me.txtImpPrevQModA.TabIndex = 387
        Me.txtImpPrevQModA.TabStop = False
        '
        'txtImpPrevQCentrosA
        '
        Me.TryDataBinding(txtImpPrevQCentrosA, New System.Windows.Forms.Binding("Value", Me, "ImpPrevQCentrosA", True))
        Me.txtImpPrevQCentrosA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPrevQCentrosA.Enabled = False
        Me.txtImpPrevQCentrosA.Location = New System.Drawing.Point(107, 78)
        Me.txtImpPrevQCentrosA.Name = "txtImpPrevQCentrosA"
        Me.txtImpPrevQCentrosA.Size = New System.Drawing.Size(100, 21)
        Me.txtImpPrevQCentrosA.TabIndex = 386
        Me.txtImpPrevQCentrosA.TabStop = False
        '
        'txtImpPrevQGastosA
        '
        Me.TryDataBinding(txtImpPrevQGastosA, New System.Windows.Forms.Binding("Value", Me, "ImpPrevQGastosA", True))
        Me.txtImpPrevQGastosA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPrevQGastosA.Enabled = False
        Me.txtImpPrevQGastosA.Location = New System.Drawing.Point(107, 102)
        Me.txtImpPrevQGastosA.Name = "txtImpPrevQGastosA"
        Me.txtImpPrevQGastosA.Size = New System.Drawing.Size(100, 21)
        Me.txtImpPrevQGastosA.TabIndex = 385
        Me.txtImpPrevQGastosA.TabStop = False
        '
        'txtImpPrevQVariosA
        '
        Me.TryDataBinding(txtImpPrevQVariosA, New System.Windows.Forms.Binding("Value", Me, "ImpPrevQVariosA", True))
        Me.txtImpPrevQVariosA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPrevQVariosA.Enabled = False
        Me.txtImpPrevQVariosA.Location = New System.Drawing.Point(107, 126)
        Me.txtImpPrevQVariosA.Name = "txtImpPrevQVariosA"
        Me.txtImpPrevQVariosA.Size = New System.Drawing.Size(100, 21)
        Me.txtImpPrevQVariosA.TabIndex = 384
        Me.txtImpPrevQVariosA.TabStop = False
        '
        'Linea1
        '
        Me.Linea1.Location = New System.Drawing.Point(10, 150)
        Me.Linea1.Name = "Linea1"
        Me.Linea1.Size = New System.Drawing.Size(359, 3)
        Me.Linea1.TabIndex = 397
        '
        'txtImpPrevQMatA
        '
        Me.TryDataBinding(txtImpPrevQMatA, New System.Windows.Forms.Binding("Value", Me, "ImpPrevQMatA", True))
        Me.txtImpPrevQMatA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPrevQMatA.Enabled = False
        Me.txtImpPrevQMatA.Location = New System.Drawing.Point(107, 30)
        Me.txtImpPrevQMatA.Name = "txtImpPrevQMatA"
        Me.txtImpPrevQMatA.Size = New System.Drawing.Size(100, 21)
        Me.txtImpPrevQMatA.TabIndex = 383
        Me.txtImpPrevQMatA.TabStop = False
        '
        'txtMargenPrevQVarios
        '
        Me.txtMargenPrevQVarios.DisabledBackColor = System.Drawing.Color.White
        Me.txtMargenPrevQVarios.Enabled = False
        Me.txtMargenPrevQVarios.Location = New System.Drawing.Point(210, 126)
        Me.txtMargenPrevQVarios.Name = "txtMargenPrevQVarios"
        Me.txtMargenPrevQVarios.Size = New System.Drawing.Size(51, 21)
        Me.txtMargenPrevQVarios.TabIndex = 382
        Me.txtMargenPrevQVarios.TabStop = False
        '
        'txtMargenPrevQGastos
        '
        Me.txtMargenPrevQGastos.DisabledBackColor = System.Drawing.Color.White
        Me.txtMargenPrevQGastos.Enabled = False
        Me.txtMargenPrevQGastos.Location = New System.Drawing.Point(210, 102)
        Me.txtMargenPrevQGastos.Name = "txtMargenPrevQGastos"
        Me.txtMargenPrevQGastos.Size = New System.Drawing.Size(51, 21)
        Me.txtMargenPrevQGastos.TabIndex = 381
        Me.txtMargenPrevQGastos.TabStop = False
        '
        'txtMargenPrevQCentro
        '
        Me.txtMargenPrevQCentro.DisabledBackColor = System.Drawing.Color.White
        Me.txtMargenPrevQCentro.Enabled = False
        Me.txtMargenPrevQCentro.Location = New System.Drawing.Point(210, 78)
        Me.txtMargenPrevQCentro.Name = "txtMargenPrevQCentro"
        Me.txtMargenPrevQCentro.Size = New System.Drawing.Size(51, 21)
        Me.txtMargenPrevQCentro.TabIndex = 380
        Me.txtMargenPrevQCentro.TabStop = False
        '
        'txtMargenPrevQMod
        '
        Me.txtMargenPrevQMod.DisabledBackColor = System.Drawing.Color.White
        Me.txtMargenPrevQMod.Enabled = False
        Me.txtMargenPrevQMod.Location = New System.Drawing.Point(210, 54)
        Me.txtMargenPrevQMod.Name = "txtMargenPrevQMod"
        Me.txtMargenPrevQMod.Size = New System.Drawing.Size(51, 21)
        Me.txtMargenPrevQMod.TabIndex = 379
        Me.txtMargenPrevQMod.TabStop = False
        '
        'txtMargenPrevQMat
        '
        Me.txtMargenPrevQMat.DisabledBackColor = System.Drawing.Color.White
        Me.txtMargenPrevQMat.Enabled = False
        Me.txtMargenPrevQMat.Location = New System.Drawing.Point(210, 30)
        Me.txtMargenPrevQMat.Name = "txtMargenPrevQMat"
        Me.txtMargenPrevQMat.Size = New System.Drawing.Size(51, 21)
        Me.txtMargenPrevQMat.TabIndex = 378
        Me.txtMargenPrevQMat.TabStop = False
        '
        'lblPorcQPrev
        '
        Me.lblPorcQPrev.AutoSize = False
        Me.lblPorcQPrev.Location = New System.Drawing.Point(210, 6)
        Me.lblPorcQPrev.Name = "lblPorcQPrev"
        Me.lblPorcQPrev.Size = New System.Drawing.Size(51, 21)
        Me.lblPorcQPrev.TabIndex = 399
        Me.lblPorcQPrev.Tag = "IdRec=7118;"
        Me.lblPorcQPrev.Text = "% Prev."
        Me.lblPorcQPrev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtImpPrevQMatVentaA
        '
        Me.TryDataBinding(txtImpPrevQMatVentaA, New System.Windows.Forms.Binding("Value", Me, "ImpPrevQMatVentaA", True))
        Me.txtImpPrevQMatVentaA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPrevQMatVentaA.Enabled = False
        Me.txtImpPrevQMatVentaA.Location = New System.Drawing.Point(264, 30)
        Me.txtImpPrevQMatVentaA.Name = "txtImpPrevQMatVentaA"
        Me.txtImpPrevQMatVentaA.Size = New System.Drawing.Size(100, 21)
        Me.txtImpPrevQMatVentaA.TabIndex = 377
        Me.txtImpPrevQMatVentaA.TabStop = False
        '
        'txtImpPrevVariosQVentaA
        '
        Me.TryDataBinding(txtImpPrevVariosQVentaA, New System.Windows.Forms.Binding("Value", Me, "ImpPrevQVariosVentaA", True))
        Me.txtImpPrevVariosQVentaA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPrevVariosQVentaA.Enabled = False
        Me.txtImpPrevVariosQVentaA.Location = New System.Drawing.Point(264, 126)
        Me.txtImpPrevVariosQVentaA.Name = "txtImpPrevVariosQVentaA"
        Me.txtImpPrevVariosQVentaA.Size = New System.Drawing.Size(100, 21)
        Me.txtImpPrevVariosQVentaA.TabIndex = 376
        Me.txtImpPrevVariosQVentaA.TabStop = False
        '
        'txtImpPrevGastosQVentaA
        '
        Me.TryDataBinding(txtImpPrevGastosQVentaA, New System.Windows.Forms.Binding("Value", Me, "ImpPrevQGastosVentaA", True))
        Me.txtImpPrevGastosQVentaA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPrevGastosQVentaA.Enabled = False
        Me.txtImpPrevGastosQVentaA.Location = New System.Drawing.Point(264, 102)
        Me.txtImpPrevGastosQVentaA.Name = "txtImpPrevGastosQVentaA"
        Me.txtImpPrevGastosQVentaA.Size = New System.Drawing.Size(100, 21)
        Me.txtImpPrevGastosQVentaA.TabIndex = 375
        Me.txtImpPrevGastosQVentaA.TabStop = False
        '
        'txtImpPrevCentrosQVentaA
        '
        Me.TryDataBinding(txtImpPrevCentrosQVentaA, New System.Windows.Forms.Binding("Value", Me, "ImpPrevQCentrosVentaA", True))
        Me.txtImpPrevCentrosQVentaA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPrevCentrosQVentaA.Enabled = False
        Me.txtImpPrevCentrosQVentaA.Location = New System.Drawing.Point(264, 78)
        Me.txtImpPrevCentrosQVentaA.Name = "txtImpPrevCentrosQVentaA"
        Me.txtImpPrevCentrosQVentaA.Size = New System.Drawing.Size(100, 21)
        Me.txtImpPrevCentrosQVentaA.TabIndex = 374
        Me.txtImpPrevCentrosQVentaA.TabStop = False
        '
        'txtImpPrevQModVentaA
        '
        Me.TryDataBinding(txtImpPrevQModVentaA, New System.Windows.Forms.Binding("Value", Me, "ImpPrevQModVentaA", True))
        Me.txtImpPrevQModVentaA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPrevQModVentaA.Enabled = False
        Me.txtImpPrevQModVentaA.Location = New System.Drawing.Point(264, 54)
        Me.txtImpPrevQModVentaA.Name = "txtImpPrevQModVentaA"
        Me.txtImpPrevQModVentaA.Size = New System.Drawing.Size(100, 21)
        Me.txtImpPrevQModVentaA.TabIndex = 373
        Me.txtImpPrevQModVentaA.TabStop = False
        '
        'lblImpVentaQPrev
        '
        Me.lblImpVentaQPrev.AutoSize = False
        Me.lblImpVentaQPrev.Location = New System.Drawing.Point(264, 6)
        Me.lblImpVentaQPrev.Name = "lblImpVentaQPrev"
        Me.lblImpVentaQPrev.Size = New System.Drawing.Size(105, 21)
        Me.lblImpVentaQPrev.TabIndex = 400
        Me.lblImpVentaQPrev.Tag = "IdRec=6718;"
        Me.lblImpVentaQPrev.Text = "Imp. Venta Prev."
        Me.lblImpVentaQPrev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UiTabPageUnitarios
        '
        Me.UiTabPageUnitarios.Controls.Add(Me.lblTotalUnitario)
        Me.UiTabPageUnitarios.Controls.Add(Me.lblMOD)
        Me.UiTabPageUnitarios.Controls.Add(Me.lblCentros)
        Me.UiTabPageUnitarios.Controls.Add(Me.lblGastos)
        Me.UiTabPageUnitarios.Controls.Add(Me.lblVarios)
        Me.UiTabPageUnitarios.Controls.Add(Me.lblMateriales)
        Me.UiTabPageUnitarios.Controls.Add(Me.lblQPrev)
        Me.UiTabPageUnitarios.Controls.Add(Me.txtImpPrevTrabajoA)
        Me.UiTabPageUnitarios.Controls.Add(Me.lblCostePrev)
        Me.UiTabPageUnitarios.Controls.Add(Me.txtImpPrevModA)
        Me.UiTabPageUnitarios.Controls.Add(Me.txtImpPrevCentrosA)
        Me.UiTabPageUnitarios.Controls.Add(Me.txtImpPrevGastosA)
        Me.UiTabPageUnitarios.Controls.Add(Me.txtImpPrevVariosA)
        Me.UiTabPageUnitarios.Controls.Add(Me.Linea2)
        Me.UiTabPageUnitarios.Controls.Add(Me.txtImpPrevMatA)
        Me.UiTabPageUnitarios.Controls.Add(Me.txtMargenPrevVarios)
        Me.UiTabPageUnitarios.Controls.Add(Me.txtMargenPrevGastos)
        Me.UiTabPageUnitarios.Controls.Add(Me.txtMargenPrevCentro)
        Me.UiTabPageUnitarios.Controls.Add(Me.txtMargenPrevMod)
        Me.UiTabPageUnitarios.Controls.Add(Me.txtMargenPrevMat)
        Me.UiTabPageUnitarios.Controls.Add(Me.lblPorcPrev)
        Me.UiTabPageUnitarios.Controls.Add(Me.txtImpPrevMatVentaA)
        Me.UiTabPageUnitarios.Controls.Add(Me.txtImpPrevVariosVentaA)
        Me.UiTabPageUnitarios.Controls.Add(Me.txtImpPrevGastosVentaA)
        Me.UiTabPageUnitarios.Controls.Add(Me.txtImpPrevCentrosVentaA)
        Me.UiTabPageUnitarios.Controls.Add(Me.txtImpPrevModVentaA)
        Me.UiTabPageUnitarios.Controls.Add(Me.lblImpVentaPrev)
        Me.UiTabPageUnitarios.Controls.Add(Me.txtImpPrevTrabajoVentaA)
        Me.UiTabPageUnitarios.Controls.Add(Me.txtQPrev)
        Me.UiTabPageUnitarios.Key = "Unitarios"
        Me.UiTabPageUnitarios.Location = New System.Drawing.Point(1, 21)
        Me.UiTabPageUnitarios.Name = "UiTabPageUnitarios"
        Me.UiTabPageUnitarios.Size = New System.Drawing.Size(371, 210)
        Me.UiTabPageUnitarios.TabStop = True
        Me.UiTabPageUnitarios.Text = "Importes unitarios"
        Me.UiTabPageUnitarios.Visible = False
        '
        'lblTotalUnitario
        '
        Me.lblTotalUnitario.Location = New System.Drawing.Point(10, 158)
        Me.lblTotalUnitario.Name = "lblTotalUnitario"
        Me.lblTotalUnitario.Size = New System.Drawing.Size(92, 13)
        Me.lblTotalUnitario.TabIndex = 332
        Me.lblTotalUnitario.Tag = ""
        Me.lblTotalUnitario.Text = "TOTAL Unitario"
        '
        'lblMOD
        '
        Me.lblMOD.Location = New System.Drawing.Point(10, 54)
        Me.lblMOD.Name = "lblMOD"
        Me.lblMOD.Size = New System.Drawing.Size(46, 13)
        Me.lblMOD.TabIndex = 334
        Me.lblMOD.Tag = "IdRec=5749;"
        Me.lblMOD.Text = "M.O.D."
        '
        'lblCentros
        '
        Me.lblCentros.Location = New System.Drawing.Point(10, 78)
        Me.lblCentros.Name = "lblCentros"
        Me.lblCentros.Size = New System.Drawing.Size(52, 13)
        Me.lblCentros.TabIndex = 335
        Me.lblCentros.Tag = "IdRec=5748;"
        Me.lblCentros.Text = "Centros"
        '
        'lblGastos
        '
        Me.lblGastos.Location = New System.Drawing.Point(10, 102)
        Me.lblGastos.Name = "lblGastos"
        Me.lblGastos.Size = New System.Drawing.Size(46, 13)
        Me.lblGastos.TabIndex = 336
        Me.lblGastos.Tag = "IdRec=5747;"
        Me.lblGastos.Text = "Gastos"
        '
        'lblVarios
        '
        Me.lblVarios.Location = New System.Drawing.Point(10, 126)
        Me.lblVarios.Name = "lblVarios"
        Me.lblVarios.Size = New System.Drawing.Size(43, 13)
        Me.lblVarios.TabIndex = 337
        Me.lblVarios.Tag = "IdRec=5333;"
        Me.lblVarios.Text = "Varios"
        '
        'lblMateriales
        '
        Me.lblMateriales.Location = New System.Drawing.Point(10, 30)
        Me.lblMateriales.Name = "lblMateriales"
        Me.lblMateriales.Size = New System.Drawing.Size(65, 13)
        Me.lblMateriales.TabIndex = 339
        Me.lblMateriales.Tag = "IdRec=5750;"
        Me.lblMateriales.Text = "Materiales"
        '
        'lblQPrev
        '
        Me.lblQPrev.Location = New System.Drawing.Point(10, 182)
        Me.lblQPrev.Name = "lblQPrev"
        Me.lblQPrev.Size = New System.Drawing.Size(54, 13)
        Me.lblQPrev.TabIndex = 345
        Me.lblQPrev.Tag = ""
        Me.lblQPrev.Text = "C. Prev."
        '
        'txtImpPrevTrabajoA
        '
        Me.TryDataBinding(txtImpPrevTrabajoA, New System.Windows.Forms.Binding("Value", Me, "ImpPrevTrabajoA", True))
        Me.txtImpPrevTrabajoA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPrevTrabajoA.Enabled = False
        Me.txtImpPrevTrabajoA.Location = New System.Drawing.Point(107, 158)
        Me.txtImpPrevTrabajoA.Name = "txtImpPrevTrabajoA"
        Me.txtImpPrevTrabajoA.Size = New System.Drawing.Size(100, 21)
        Me.txtImpPrevTrabajoA.TabIndex = 330
        Me.txtImpPrevTrabajoA.TabStop = False
        '
        'lblCostePrev
        '
        Me.lblCostePrev.AutoSize = False
        Me.lblCostePrev.Location = New System.Drawing.Point(107, 6)
        Me.lblCostePrev.Name = "lblCostePrev"
        Me.lblCostePrev.Size = New System.Drawing.Size(100, 21)
        Me.lblCostePrev.TabIndex = 333
        Me.lblCostePrev.Tag = "IdRec=6720;"
        Me.lblCostePrev.Text = "Coste Previsto"
        Me.lblCostePrev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtImpPrevModA
        '
        Me.TryDataBinding(txtImpPrevModA, New System.Windows.Forms.Binding("Value", Me, "ImpPrevModA", True))
        Me.txtImpPrevModA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPrevModA.Enabled = False
        Me.txtImpPrevModA.Location = New System.Drawing.Point(107, 54)
        Me.txtImpPrevModA.Name = "txtImpPrevModA"
        Me.txtImpPrevModA.Size = New System.Drawing.Size(100, 21)
        Me.txtImpPrevModA.TabIndex = 328
        Me.txtImpPrevModA.TabStop = False
        '
        'txtImpPrevCentrosA
        '
        Me.TryDataBinding(txtImpPrevCentrosA, New System.Windows.Forms.Binding("Value", Me, "ImpPrevCentrosA", True))
        Me.txtImpPrevCentrosA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPrevCentrosA.Enabled = False
        Me.txtImpPrevCentrosA.Location = New System.Drawing.Point(107, 78)
        Me.txtImpPrevCentrosA.Name = "txtImpPrevCentrosA"
        Me.txtImpPrevCentrosA.Size = New System.Drawing.Size(100, 21)
        Me.txtImpPrevCentrosA.TabIndex = 327
        Me.txtImpPrevCentrosA.TabStop = False
        '
        'txtImpPrevGastosA
        '
        Me.TryDataBinding(txtImpPrevGastosA, New System.Windows.Forms.Binding("Value", Me, "ImpPrevGastosA", True))
        Me.txtImpPrevGastosA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPrevGastosA.Enabled = False
        Me.txtImpPrevGastosA.Location = New System.Drawing.Point(107, 102)
        Me.txtImpPrevGastosA.Name = "txtImpPrevGastosA"
        Me.txtImpPrevGastosA.Size = New System.Drawing.Size(100, 21)
        Me.txtImpPrevGastosA.TabIndex = 326
        Me.txtImpPrevGastosA.TabStop = False
        '
        'txtImpPrevVariosA
        '
        Me.TryDataBinding(txtImpPrevVariosA, New System.Windows.Forms.Binding("Value", Me, "ImpPrevVariosA", True))
        Me.txtImpPrevVariosA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPrevVariosA.Enabled = False
        Me.txtImpPrevVariosA.Location = New System.Drawing.Point(107, 126)
        Me.txtImpPrevVariosA.Name = "txtImpPrevVariosA"
        Me.txtImpPrevVariosA.Size = New System.Drawing.Size(100, 21)
        Me.txtImpPrevVariosA.TabIndex = 325
        Me.txtImpPrevVariosA.TabStop = False
        '
        'Linea2
        '
        Me.Linea2.Location = New System.Drawing.Point(10, 150)
        Me.Linea2.Name = "Linea2"
        Me.Linea2.Size = New System.Drawing.Size(359, 3)
        Me.Linea2.TabIndex = 338
        '
        'txtImpPrevMatA
        '
        Me.TryDataBinding(txtImpPrevMatA, New System.Windows.Forms.Binding("Value", Me, "ImpPrevMatA", True))
        Me.txtImpPrevMatA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPrevMatA.Enabled = False
        Me.txtImpPrevMatA.Location = New System.Drawing.Point(107, 30)
        Me.txtImpPrevMatA.Name = "txtImpPrevMatA"
        Me.txtImpPrevMatA.Size = New System.Drawing.Size(100, 21)
        Me.txtImpPrevMatA.TabIndex = 324
        Me.txtImpPrevMatA.TabStop = False
        '
        'txtMargenPrevVarios
        '
        Me.txtMargenPrevVarios.DisabledBackColor = System.Drawing.Color.White
        Me.txtMargenPrevVarios.Enabled = False
        Me.txtMargenPrevVarios.Location = New System.Drawing.Point(210, 126)
        Me.txtMargenPrevVarios.Name = "txtMargenPrevVarios"
        Me.txtMargenPrevVarios.Size = New System.Drawing.Size(51, 21)
        Me.txtMargenPrevVarios.TabIndex = 323
        Me.txtMargenPrevVarios.TabStop = False
        '
        'txtMargenPrevGastos
        '
        Me.txtMargenPrevGastos.DisabledBackColor = System.Drawing.Color.White
        Me.txtMargenPrevGastos.Enabled = False
        Me.txtMargenPrevGastos.Location = New System.Drawing.Point(210, 102)
        Me.txtMargenPrevGastos.Name = "txtMargenPrevGastos"
        Me.txtMargenPrevGastos.Size = New System.Drawing.Size(51, 21)
        Me.txtMargenPrevGastos.TabIndex = 322
        Me.txtMargenPrevGastos.TabStop = False
        '
        'txtMargenPrevCentro
        '
        Me.txtMargenPrevCentro.DisabledBackColor = System.Drawing.Color.White
        Me.txtMargenPrevCentro.Enabled = False
        Me.txtMargenPrevCentro.Location = New System.Drawing.Point(210, 78)
        Me.txtMargenPrevCentro.Name = "txtMargenPrevCentro"
        Me.txtMargenPrevCentro.Size = New System.Drawing.Size(51, 21)
        Me.txtMargenPrevCentro.TabIndex = 321
        Me.txtMargenPrevCentro.TabStop = False
        '
        'txtMargenPrevMod
        '
        Me.txtMargenPrevMod.DisabledBackColor = System.Drawing.Color.White
        Me.txtMargenPrevMod.Enabled = False
        Me.txtMargenPrevMod.Location = New System.Drawing.Point(210, 54)
        Me.txtMargenPrevMod.Name = "txtMargenPrevMod"
        Me.txtMargenPrevMod.Size = New System.Drawing.Size(51, 21)
        Me.txtMargenPrevMod.TabIndex = 320
        Me.txtMargenPrevMod.TabStop = False
        '
        'txtMargenPrevMat
        '
        Me.txtMargenPrevMat.DisabledBackColor = System.Drawing.Color.White
        Me.txtMargenPrevMat.Enabled = False
        Me.txtMargenPrevMat.Location = New System.Drawing.Point(210, 30)
        Me.txtMargenPrevMat.Name = "txtMargenPrevMat"
        Me.txtMargenPrevMat.Size = New System.Drawing.Size(51, 21)
        Me.txtMargenPrevMat.TabIndex = 319
        Me.txtMargenPrevMat.TabStop = False
        '
        'lblPorcPrev
        '
        Me.lblPorcPrev.AutoSize = False
        Me.lblPorcPrev.Location = New System.Drawing.Point(210, 6)
        Me.lblPorcPrev.Name = "lblPorcPrev"
        Me.lblPorcPrev.Size = New System.Drawing.Size(51, 21)
        Me.lblPorcPrev.TabIndex = 340
        Me.lblPorcPrev.Tag = "IdRec=7118;"
        Me.lblPorcPrev.Text = "% Prev."
        Me.lblPorcPrev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtImpPrevMatVentaA
        '
        Me.TryDataBinding(txtImpPrevMatVentaA, New System.Windows.Forms.Binding("Value", Me, "ImpPrevMatVentaA", True))
        Me.txtImpPrevMatVentaA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPrevMatVentaA.Enabled = False
        Me.txtImpPrevMatVentaA.Location = New System.Drawing.Point(264, 30)
        Me.txtImpPrevMatVentaA.Name = "txtImpPrevMatVentaA"
        Me.txtImpPrevMatVentaA.Size = New System.Drawing.Size(100, 21)
        Me.txtImpPrevMatVentaA.TabIndex = 318
        Me.txtImpPrevMatVentaA.TabStop = False
        '
        'txtImpPrevVariosVentaA
        '
        Me.TryDataBinding(txtImpPrevVariosVentaA, New System.Windows.Forms.Binding("Value", Me, "ImpPrevVariosVentaA", True))
        Me.txtImpPrevVariosVentaA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPrevVariosVentaA.Enabled = False
        Me.txtImpPrevVariosVentaA.Location = New System.Drawing.Point(264, 126)
        Me.txtImpPrevVariosVentaA.Name = "txtImpPrevVariosVentaA"
        Me.txtImpPrevVariosVentaA.Size = New System.Drawing.Size(100, 21)
        Me.txtImpPrevVariosVentaA.TabIndex = 317
        Me.txtImpPrevVariosVentaA.TabStop = False
        '
        'txtImpPrevGastosVentaA
        '
        Me.TryDataBinding(txtImpPrevGastosVentaA, New System.Windows.Forms.Binding("Value", Me, "ImpPrevGastosVentaA", True))
        Me.txtImpPrevGastosVentaA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPrevGastosVentaA.Enabled = False
        Me.txtImpPrevGastosVentaA.Location = New System.Drawing.Point(264, 102)
        Me.txtImpPrevGastosVentaA.Name = "txtImpPrevGastosVentaA"
        Me.txtImpPrevGastosVentaA.Size = New System.Drawing.Size(100, 21)
        Me.txtImpPrevGastosVentaA.TabIndex = 316
        Me.txtImpPrevGastosVentaA.TabStop = False
        '
        'txtImpPrevCentrosVentaA
        '
        Me.TryDataBinding(txtImpPrevCentrosVentaA, New System.Windows.Forms.Binding("Value", Me, "ImpPrevCentrosVentaA", True))
        Me.txtImpPrevCentrosVentaA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPrevCentrosVentaA.Enabled = False
        Me.txtImpPrevCentrosVentaA.Location = New System.Drawing.Point(264, 78)
        Me.txtImpPrevCentrosVentaA.Name = "txtImpPrevCentrosVentaA"
        Me.txtImpPrevCentrosVentaA.Size = New System.Drawing.Size(100, 21)
        Me.txtImpPrevCentrosVentaA.TabIndex = 315
        Me.txtImpPrevCentrosVentaA.TabStop = False
        '
        'txtImpPrevModVentaA
        '
        Me.TryDataBinding(txtImpPrevModVentaA, New System.Windows.Forms.Binding("Value", Me, "ImpPrevModVentaA", True))
        Me.txtImpPrevModVentaA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPrevModVentaA.Enabled = False
        Me.txtImpPrevModVentaA.Location = New System.Drawing.Point(264, 54)
        Me.txtImpPrevModVentaA.Name = "txtImpPrevModVentaA"
        Me.txtImpPrevModVentaA.Size = New System.Drawing.Size(100, 21)
        Me.txtImpPrevModVentaA.TabIndex = 314
        Me.txtImpPrevModVentaA.TabStop = False
        '
        'lblImpVentaPrev
        '
        Me.lblImpVentaPrev.AutoSize = False
        Me.lblImpVentaPrev.Location = New System.Drawing.Point(264, 6)
        Me.lblImpVentaPrev.Name = "lblImpVentaPrev"
        Me.lblImpVentaPrev.Size = New System.Drawing.Size(105, 21)
        Me.lblImpVentaPrev.TabIndex = 341
        Me.lblImpVentaPrev.Tag = "IdRec=6718;"
        Me.lblImpVentaPrev.Text = "Imp. Venta Prev."
        Me.lblImpVentaPrev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtImpPrevTrabajoVentaA
        '
        Me.TryDataBinding(txtImpPrevTrabajoVentaA, New System.Windows.Forms.Binding("Value", Me, "ImpPrevTrabajoVentaA", True))
        Me.txtImpPrevTrabajoVentaA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPrevTrabajoVentaA.Enabled = False
        Me.txtImpPrevTrabajoVentaA.Location = New System.Drawing.Point(264, 158)
        Me.txtImpPrevTrabajoVentaA.Name = "txtImpPrevTrabajoVentaA"
        Me.txtImpPrevTrabajoVentaA.Size = New System.Drawing.Size(100, 21)
        Me.txtImpPrevTrabajoVentaA.TabIndex = 313
        Me.txtImpPrevTrabajoVentaA.TabStop = False
        '
        'txtQPrev
        '
        Me.TryDataBinding(txtQPrev, New System.Windows.Forms.Binding("Value", Me, "QPrev", True))
        Me.txtQPrev.DisabledBackColor = System.Drawing.Color.White
        Me.txtQPrev.Enabled = False
        Me.txtQPrev.Location = New System.Drawing.Point(107, 182)
        Me.txtQPrev.Name = "txtQPrev"
        Me.txtQPrev.Size = New System.Drawing.Size(100, 21)
        Me.txtQPrev.TabIndex = 295
        Me.txtQPrev.TabStop = False
        '
        'frmDesgloseImportesTrabajo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(646, 348)
        Me.Controls.Add(Me.TabImportes)
        Me.Controls.Add(Me.FraReal)
        Me.Controls.Add(Me.FraTotalTrabajo)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.pnlBotones)
        Me.EntityName = "ObraTrabajo"
        Me.MaximizeBox = False
        Me.Name = "frmDesgloseImportesTrabajo"
        Me.NavigationFields = "IDTrabajo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Desglose importes trabajo"
        Me.ViewName = "tbObratrabajo"
        Me.pnlBotones.ResumeLayout(False)
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.FraTotalTrabajo.ResumeLayout(False)
        Me.FraTotalTrabajo.PerformLayout()
        Me.FraReal.ResumeLayout(False)
        Me.FraReal.PerformLayout()
        CType(Me.Linea3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabImportes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabImportes.ResumeLayout(False)
        Me.UiTabPageTotales.ResumeLayout(False)
        Me.UiTabPageTotales.PerformLayout()
        CType(Me.Linea1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiTabPageUnitarios.ResumeLayout(False)
        Me.UiTabPageUnitarios.PerformLayout()
        CType(Me.Linea2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Overrides ReadOnly Property RequeryRecords() As Engine.RequeryMode
        Get
            Return RequeryMode.ActiveRecord
        End Get
    End Property

    Dim mintIDTrabajo As Integer
    Dim mdblImpCapitulo, mdblImpCapituloVenta As Double

    Public Sub AbrirDesgloseTrabajo(ByVal intIDTrabajo As Integer, ByVal dblImpCapitulo As Double, _
                                    ByVal dblImpCapituloVenta As Double)
        mintIDTrabajo = intIDTrabajo
        mdblImpCapitulo = dblImpCapitulo
        mdblImpCapituloVenta = dblImpCapituloVenta
        lblNoAcumula.Text = ExpertisApp.Traslate(lblNoAcumula.Text)

        Dim frm As Form = Me
        frm.ShowDialog()  'Para que no traiga todos los registros
    End Sub

    Private Sub frmDesgloseImportesTrabajo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim f As New Filter
        f.Add(New NumberFilterItem("IDTrabajo", mintIDTrabajo))
        Me.RetrieveData(DataProviderActions.GoFirst, f)

        txtMargenPrevQMat.Value = CalcularMargen(txtImpPrevQMatVentaA.Value, txtImpPrevQMatA.Value)
        txtMargenPrevQMod.Value = CalcularMargen(txtImpPrevQModVentaA.Value, txtImpPrevQModA.Value)
        txtMargenPrevQCentro.Value = CalcularMargen(txtImpPrevCentrosQVentaA.Value, txtImpPrevQCentrosA.Value)
        txtMargenPrevQGastos.Value = CalcularMargen(txtImpPrevGastosQVentaA.Value, txtImpPrevQGastosA.Value)
        txtMargenPrevQVarios.Value = CalcularMargen(txtImpPrevVariosQVentaA.Value, txtImpPrevQVariosA.Value)

        txtMargenPrevMat.Value = txtMargenPrevQMat.Value
        txtMargenPrevMod.Value = txtMargenPrevQMod.Value
        txtMargenPrevCentro.Value = txtMargenPrevQCentro.Value
        txtMargenPrevGastos.Value = txtMargenPrevQGastos.Value
        txtMargenPrevVarios.Value = txtMargenPrevQVarios.Value

        txtMargenRealMat.Value = CalcularMargen(txtImpFactMatA.Value, txtImpRealMatA.Value)
        txtMargenRealMod.Value = CalcularMargen(txtImpFactModA.Value, txtImpRealModA.Value)
        txtMargenRealCentros.Value = CalcularMargen(txtImpFactCentrosA.Value, txtImpRealCentrosA.Value)
        txtMargenRealGastos.Value = CalcularMargen(txtImpFactGastosA.Value, txtImpRealGastosA.Value)
        txtMargenRealVarios.Value = CalcularMargen(txtImpFactVariosA.Value, txtImpRealVariosA.Value)
        txtMargenRealTrabajo.Value = CalcularMargen(txtImpFactQTrabajoA.Value, txtImpRealQTrabajoA.Value)

        txtImpPrevQTrabajoA.Value = mdblImpCapitulo
        txtImpPrevQTrabajoVentaA.Value = mdblImpCapituloVenta
        txtMargenPrevTrabajo.Value = CalcularMargen(mdblImpCapituloVenta, mdblImpCapitulo)

        If Not IsNothing(Me.CurrentData) AndAlso Me.CurrentData.Rows.Count > 0 Then
            If Not Nz(Me.CurrentData.Rows(0)("NoAcumular"), False) Then
                lblNoAcumula.Text = "ACUMULA EN TRABAJO "
            End If
        Else
            lblNoAcumula.Text = String.Empty
        End If
        lblNoAcumula.ForeColor = Color.Red
    End Sub

    Private Sub Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCerrar.Click
        Me.Close()
    End Sub

End Class
