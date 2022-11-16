Public Class frmStockActualizado
    Inherits Solmicro.Expertis.Engine.UI.FormBase

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        Me.Grid.RelationMode = RelationMode.NoRelation
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
    Friend WithEvents Grid As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents CmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmbCancelar As Solmicro.Expertis.Engine.UI.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.CmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.Grid = New Solmicro.Expertis.Engine.UI.Grid
        Me.Panel1.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CmbAceptar)
        Me.Panel1.Controls.Add(Me.cmbCancelar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 275)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(569, 42)
        Me.Panel1.TabIndex = 232
        '
        'CmbAceptar
        '
        Me.CmbAceptar.Location = New System.Drawing.Point(187, 7)
        Me.CmbAceptar.Name = "CmbAceptar"
        Me.CmbAceptar.Size = New System.Drawing.Size(94, 29)
        Me.CmbAceptar.TabIndex = 13
        Me.CmbAceptar.Text = "Aceptar"
        '
        'cmbCancelar
        '
        Me.cmbCancelar.Location = New System.Drawing.Point(287, 7)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(94, 29)
        Me.cmbCancelar.TabIndex = 14
        Me.cmbCancelar.Text = "Cancelar"
        '
        'Grid
        '
        Me.Grid.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""IDLineaLote""" & _
        "><Caption>IDLineaLote</Caption><DataMember>IDLineaLote</DataMember><EditType>NoE" & _
        "dit</EditType><Key>IDLineaLote</Key><Position>0</Position><Visible>False</Visibl" & _
        "e></Column0><Column1 ID=""IDLineaMaterialControl""><Caption>IDLineaMaterialControl" & _
        "</Caption><DataMember>IDLineaMaterialControl</DataMember><EditType>NoEdit</EditT" & _
        "ype><Key>IDLineaMaterialControl</Key><Position>1</Position><Visible>False</Visib" & _
        "le></Column1><Column2 ID=""IDArticulo""><Caption>Material</Caption><DataMember>IDA" & _
        "rticulo</DataMember><EditType>NoEdit</EditType><Key>IDArticulo</Key><Position>2<" & _
        "/Position></Column2><Column3 ID=""DescMaterial""><Caption>Desc. Material</Caption>" & _
        "<DataMember>DescMaterial</DataMember><EditType>NoEdit</EditType><Key>DescMateria" & _
        "l</Key><Position>3</Position><Width>133</Width></Column3><Column4 ID=""IDAlmacen""" & _
        "><Caption>Almacén</Caption><DataMember>IDAlmacen</DataMember><EditType>NoEdit</E" & _
        "ditType><Key>IDAlmacen</Key><Position>4</Position><Width>69</Width></Column4><Co" & _
        "lumn5 ID=""Lote""><Caption>Lote</Caption><DataMember>Lote</DataMember><EditType>No" & _
        "Edit</EditType><Key>Lote</Key><Position>5</Position><Width>61</Width></Column5><" & _
        "Column6 ID=""Ubicacion""><Caption>Ubicación</Caption><DataMember>Ubicacion</DataMe" & _
        "mber><EditType>NoEdit</EditType><Key>Ubicacion</Key><Position>6</Position></Colu" & _
        "mn6><Column7 ID=""QInterna""><Caption>Cantidad</Caption><DataMember>QInterna</Data" & _
        "Member><HeaderAlignment>Far</HeaderAlignment><Key>QInterna</Key><Position>7</Pos" & _
        "ition><TextAlignment>Far</TextAlignment><Width>66</Width></Column7><Column8 ID=""" & _
        "IDMovimientoSalida""><Caption>IDMovimientoSalida</Caption><DataMember>IDMovimient" & _
        "oSalida</DataMember><EditType>NoEdit</EditType><Key>IDMovimientoSalida</Key><Pos" & _
        "ition>8</Position><Visible>False</Visible></Column8></Columns><GroupCondition ID" & _
        "="""" /></RootTable></GridEXLayoutData>"
        Me.Grid.DesignTimeLayout = GridEXLayout1
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.EntityName = ""
        Me.Grid.Location = New System.Drawing.Point(0, 0)
        Me.Grid.Name = "Grid"
        Me.Grid.PrimaryDataFields = Nothing
        Me.Grid.SecondaryDataFields = Nothing
        Me.Grid.Size = New System.Drawing.Size(569, 275)
        Me.Grid.TabIndex = 233
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.ViewName = ""
        '
        'frmStockActualizado
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(569, 317)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.Panel1)
        Me.EntityName = "ObraMaterialControlLote"
        Me.Name = "frmStockActualizado"
        Me.NavigationFields = "IDLineaMaterialControl"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock actualizado"
        Me.ViewName = "vFrmObrasStockActualizado"
        Me.WindowState = System.Windows.Forms.FormWindowState.Normal
        Me.Panel1.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Overrides ReadOnly Property RequeryRecords() As Engine.RequeryMode
        Get
            Return RequeryMode.ActiveRecord
        End Get
    End Property

    Public Sub AbrirStockActualizado(ByVal intIDLineaMaterialControl As Integer)
        With Grid
            .EntityName = "ObraMaterialControlLote"
            .ViewName = "vFrmObrasStockActualizado"

            Dim f As New Filter
            f.Add(New NumberFilterItem("IDLineaMaterialControl", intIDLineaMaterialControl))
            .Filter = f
        End With

        Me.ShowDialog()
    End Sub

    Private Sub CmbAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbAceptar.Click
        Me.UpdateData()
        Me.Close()
    End Sub

    Private Sub cmbCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCancelar.Click
        Me.Close()
    End Sub

End Class
