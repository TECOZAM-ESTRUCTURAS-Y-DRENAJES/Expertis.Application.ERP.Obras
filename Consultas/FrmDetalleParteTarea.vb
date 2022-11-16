Public Class FrmDetalleParteTarea
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
    Friend WithEvents jngDetalle As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents lblDescTareaValor As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblDescTarea As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LblNTareaValor As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LblNTarea As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents PCabecera As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents PGrid As Solmicro.Expertis.Engine.UI.Panel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim jngDetalle_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim jngDetalle_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.ImageList.ImageStream")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDetalleParteTarea))
        Me.jngDetalle = New Solmicro.Expertis.Engine.UI.Grid
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.lblDescTareaValor = New Solmicro.Expertis.Engine.UI.Label
        Me.lblDescTarea = New Solmicro.Expertis.Engine.UI.Label
        Me.LblNTareaValor = New Solmicro.Expertis.Engine.UI.Label
        Me.LblNTarea = New Solmicro.Expertis.Engine.UI.Label
        Me.PCabecera = New Solmicro.Expertis.Engine.UI.Panel
        Me.PGrid = New Solmicro.Expertis.Engine.UI.Panel
        CType(Me.jngDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PCabecera.suspendlayout()
        Me.PGrid.suspendlayout()
        Me.SuspendLayout()
        '
        'jngDetalle
        '
        Me.jngDetalle.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngDetalle.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngDetalle.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        jngDetalle_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("jngDetalle_DesignTimeLayout_Reference_0.Instance"), Object)
        jngDetalle_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {jngDetalle_DesignTimeLayout_Reference_0})
        jngDetalle_DesignTimeLayout.LayoutString = resources.GetString("jngDetalle_DesignTimeLayout.LayoutString")
        Me.jngDetalle.DesignTimeLayout = jngDetalle_DesignTimeLayout
        Me.jngDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.jngDetalle.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.jngDetalle.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.jngDetalle.EntityName = Nothing
        Me.jngDetalle.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jngDetalle.ImageList = Me.ImageList1
        Me.jngDetalle.Location = New System.Drawing.Point(0, 0)
        Me.jngDetalle.Name = "jngDetalle"
        Me.jngDetalle.PrimaryDataFields = Nothing
        Me.jngDetalle.SecondaryDataFields = Nothing
        Me.jngDetalle.Size = New System.Drawing.Size(851, 322)
        Me.jngDetalle.TabIndex = 0
        Me.jngDetalle.Tag = "IdRec=5860:4519:6154:6138:12785:12786:;"
        Me.jngDetalle.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.jngDetalle.ViewName = Nothing
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "folder_edit.ico")
        '
        'lblDescTareaValor
        '
        Me.lblDescTareaValor.AutoSize = False
        Me.lblDescTareaValor.Location = New System.Drawing.Point(227, 8)
        Me.lblDescTareaValor.Name = "lblDescTareaValor"
        Me.lblDescTareaValor.Size = New System.Drawing.Size(614, 35)
        Me.lblDescTareaValor.TabIndex = 1
        Me.lblDescTareaValor.Tag = ""
        '
        'lblDescTarea
        '
        Me.lblDescTarea.Location = New System.Drawing.Point(142, 8)
        Me.lblDescTarea.Name = "lblDescTarea"
        Me.lblDescTarea.Size = New System.Drawing.Size(78, 13)
        Me.lblDescTarea.TabIndex = 2
        Me.lblDescTarea.Tag = ""
        Me.lblDescTarea.Text = "Descripción:"
        '
        'LblNTareaValor
        '
        Me.LblNTareaValor.Location = New System.Drawing.Point(72, 8)
        Me.LblNTareaValor.Name = "LblNTareaValor"
        Me.LblNTareaValor.Size = New System.Drawing.Size(0, 13)
        Me.LblNTareaValor.TabIndex = 3
        Me.LblNTareaValor.Tag = "IdRec=0;"
        '
        'LblNTarea
        '
        Me.LblNTarea.Location = New System.Drawing.Point(8, 8)
        Me.LblNTarea.Name = "LblNTarea"
        Me.LblNTarea.Size = New System.Drawing.Size(58, 13)
        Me.LblNTarea.TabIndex = 4
        Me.LblNTarea.Tag = "IdRec=12787;"
        Me.LblNTarea.Text = "Tarea Nº"
        '
        'PCabecera
        '
        Me.PCabecera.Controls.Add(Me.lblDescTareaValor)
        Me.PCabecera.Controls.Add(Me.lblDescTarea)
        Me.PCabecera.Controls.Add(Me.LblNTareaValor)
        Me.PCabecera.Controls.Add(Me.LblNTarea)
        Me.PCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.PCabecera.Location = New System.Drawing.Point(0, 0)
        Me.PCabecera.Name = "PCabecera"
        Me.PCabecera.Size = New System.Drawing.Size(851, 48)
        Me.PCabecera.TabIndex = 5
        '
        'PGrid
        '
        Me.PGrid.Controls.Add(Me.jngDetalle)
        Me.PGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PGrid.Location = New System.Drawing.Point(0, 48)
        Me.PGrid.Name = "PGrid"
        Me.PGrid.Size = New System.Drawing.Size(851, 322)
        Me.PGrid.TabIndex = 6
        '
        'FrmDetalleParteTarea
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(851, 370)
        Me.Controls.Add(Me.PGrid)
        Me.Controls.Add(Me.PCabecera)
        Me.Name = "FrmDetalleParteTarea"
        Me.Text = "Detalle Parte Tarea"
        CType(Me.jngDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PCabecera.ResumeLayout(False)
        Me.PCabecera.PerformLayout()
        Me.PGrid.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Sub AbrirDetalleParteTarea(ByVal intIDTarea As Integer, ByVal strNTarea As String, ByVal strDescTarea As String, ByVal OwnerForm As FormBase)
        '// NOTA: En el ShowDialog se hace el RetrieveData, que recupera TODOS los campos de la tabla 
        '// principal de la vista para poder modificar los datos del grid.
        '// En ese momento el grid debe estar ya configurado, por lo que se ha implementado este método
        '// con el fin de obtener los valores de la propiedades necesarias y poder configurar el grid 
        '// antes de que se haga el Load.

        LblNTareaValor.Text = strNTarea
        lblDescTareaValor.Text = strDescTarea
        With jngDetalle
            .EntityName = "ObraMODControl"
            .ViewName = "vCIDetallePartesTarea"
            .SecondaryDataFields = "IDTarea"

            Dim f As New Filter
            f.Add("IDTarea", FilterOperator.Equal, intIDTarea)
            Dim be As New Engine.BE.DataEngine
            .DataSource = be.Filter("vCIDetallePartesTarea", f)

            Me.ShowDialog(OwnerForm)
        End With
    End Sub

    Private Sub jngDetalle_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles jngDetalle.Click
        Dim c As GridEXColumn = jngDetalle.ColumnFromPoint()
        If Not IsNothing(c) Then
            Dim hit As GridArea
            hit = jngDetalle.HitTest()
            If hit = GridArea.Cell Then
                Select Case c.Key
                    Case "Observaciones"
                        Dim FrmObv As New FormularioTexto
                        FrmObv.Text = "Descripción del Parte de Trabajo"
                        FrmObv.Texto = jngDetalle.GetValue("DescParte") & String.Empty
                        FrmObv.SoloLectura = True
                        FrmObv.ShowDialog()
                End Select
            End If
        End If
    End Sub

End Class