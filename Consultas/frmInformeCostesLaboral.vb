Public Class frmInformeCostesLaboral
    Inherits Solmicro.Expertis.Engine.UI.FormBase

    Public blEstado As Boolean
    Public VMDesde, VMHasta As Integer
    Public VA As Integer


    Private Sub frmInformeCostesLaboral_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim txtSQL As String
        Dim txtSQL2 As String
        Dim dtmes As DataTable
        Dim dtaño As DataTable
        Try

            txtSQL = "SELECT * from tbMes"
            Dim mes As New Business.ClasesTecozam.Mes
            dtmes = mes.DevuelveMeses(txtSQL)
            fwiMesDesde.DataSource = dtmes
            fwiMesHasta.DataSource = dtmes

            Dim año As New Business.ClasesTecozam.Anio
            txtSQL2 = "SELECT * from tbAño"
            dtaño = año.DevuelveAños(txtSQL2)
            fwiAno.DataSource = dtaño

            fwiMesDesde.Value = Month(Today)
            fwiMesHasta.Value = Month(Today)
            fwiAno.Value = Year(Today)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al obtener datos")
        End Try

    End Sub

    Function Month(ByVal Fecha As Date) As Integer
        Month = Fecha.Month
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        VMDesde = Nz(fwiMesDesde.Value, 0)
        VMHasta = Nz(fwiMesHasta.Value, 0)
        VA = Nz(fwiAno.Value, 0)
        blEstado = False
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        VMDesde = Nz(fwiMesDesde.Value, 0)
        VMHasta = Nz(fwiMesHasta.Value, 0)
        VA = Nz(fwiAno.Value, 0)
        blEstado = False
        Me.Close()
    End Sub
End Class