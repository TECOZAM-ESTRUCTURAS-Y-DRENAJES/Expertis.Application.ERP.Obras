Public Class frmFacturasGeneradas
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
    Friend WithEvents lstFacturasGeneradas As System.Windows.Forms.ListBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lstFacturasGeneradas = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'lstFacturasGeneradas
        '
        Me.lstFacturasGeneradas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstFacturasGeneradas.Location = New System.Drawing.Point(0, 0)
        Me.lstFacturasGeneradas.Name = "lstFacturasGeneradas"
        Me.lstFacturasGeneradas.Size = New System.Drawing.Size(339, 225)
        Me.lstFacturasGeneradas.TabIndex = 0
        '
        'frmFacturasGeneradas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(339, 228)
        Me.Controls.Add(Me.lstFacturasGeneradas)
        Me.Name = "frmFacturasGeneradas"
        Me.Text = "Facturas Generadas"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mintIDTrabajo, mintIdFactura As Integer
    Private mIDCertificacion As Integer

    Public Sub AbrirFacturasGeneradas(ByVal intIDTrabajo As Integer, ByRef intIDFactura As Integer, Optional ByVal IDCertificacion As Integer = -1)
        mintIDTrabajo = intIDTrabajo
        mIDCertificacion = IDCertificacion

        Me.ShowDialog()

        intIDFactura = mintIdFactura
    End Sub

    Private Sub lstFacturasGeneradas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FacturasGeneradas()
    End Sub

    Public Sub FacturasGeneradas()
        lstFacturasGeneradas.Items.Clear()
        Dim f As New Filter
        If mIDCertificacion <> -1 Then f.Add(New NumberFilterItem("IDCertificacion", mIDCertificacion))
        f.Add(New NumberFilterItem("IDTrabajo", mintIDTrabajo))
        Dim dtFVL As DataTable = New BE.DataEngine().Filter("vFrmCIObraFacturacionCertificacionesGeneradas", f)
        If Not IsNothing(dtFVL) AndAlso dtFVL.Rows.Count > 0 Then
            lstFacturasGeneradas.Visible = True
            For Each dr As DataRow In dtFVL.Rows
                lstFacturasGeneradas.Items.Add(dr("NFactura") & " - Fecha Factura: " & dr("FechaFactura"))
            Next
        Else
            lstFacturasGeneradas.Visible = False
        End If
    End Sub

    Private Sub lstFacturasGeneradas_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstFacturasGeneradas.DoubleClick
        If Length(lstFacturasGeneradas.Text) > 0 Then
            Dim intPos As Integer = InStr(1, lstFacturasGeneradas.Text, " - ")
            Dim strFactura As String = Mid$(lstFacturasGeneradas.Text, 1, intPos - 1)

            Dim dtFVC As DataTable = New FacturaVentaCabecera().Filter(New FilterItem("NFactura", FilterOperator.Equal, strFactura))
            'Como estamos buscando por NFactura, puede que haya varias con el mismo NFactura
            'Hay que buscar aquella factura que contenga ese albarán concreto
            If Not IsNothing(dtFVC) AndAlso dtFVC.Rows.Count > 0 Then
                For Each drFVC As DataRow In dtFVC.Rows
                    Dim dtFVL As DataTable = New FacturaVentaLinea().Filter(New FilterItem("IDFactura", FilterOperator.Equal, drFVC("IDFactura")))
                    For Each drFVL As DataRow In dtFVL.Rows
                        If Length(drFVL("IDTrabajo")) > 0 AndAlso drFVL("IDTrabajo") = mintIDTrabajo Then
                            mintIdFactura = drFVC("IDFactura")
                            Exit For
                        End If
                    Next
                    If mintIdFactura <> 0 Then Exit For
                Next
                Me.Close()
            End If
        End If
    End Sub

End Class
