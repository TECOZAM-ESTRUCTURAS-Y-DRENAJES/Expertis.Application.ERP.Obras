Public Class frmHitosPeriodificadosPropuestos

    Private mIDTipoVencimiento As Integer
    Private mIDEjercicioActual As String

    Private Sub frmHitosPeriodificadosPropuestos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        mIDEjercicioActual = ExpertisApp.ExecuteTask(Of Date, String)(AddressOf EjercicioContable.Predeterminado, Date.Today)
        Me.MaximizeBox = True
        'grid.CheckAllRecords()
    End Sub

    Private Sub UiCommandBar1_CommandClick(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles UiCommandBar1.CommandClick
        Select Case e.Command.Key
            Case cmdCheckAll.Key
                Grid.CheckAllRecords()
            Case cmdUncheckAll.Key
                Grid.UnCheckAllRecords()
        End Select
    End Sub

    Protected Overrides Function ProcessDialogKey(ByVal keyData As System.Windows.Forms.Keys) As Boolean
        Select Case keyData
            Case Keys.F7
                Grid.CheckAllRecords()
            Case Keys.F8
                Grid.UnCheckAllRecords()
            Case Else
                Return MyBase.ProcessDialogKey(keyData)
        End Select
    End Function

#Region " Grid "

    Protected Overridable Sub GridVencimientos_AdvSearchSetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.GridAdvSearchFilterEventArgs) Handles grid.AdvSearchSetPredefinedFilter
        Select Case e.Key
            Case "IDCContable"
                e.Filter.Add(New StringFilterItem("IDEjercicio", mIDEjercicioActual))
        End Select
    End Sub

    Protected Overridable Sub Grid_EditingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles grid.EditingCell
        Select Case e.Column.Key
            Case "Expertis.Check"
                mIDTipoVencimiento = grid.Value("IDTipoVencimiento")
        End Select
    End Sub

    Private Sub Grid_RecordChecked(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.CheckedEventArgs) Handles grid.RecordChecked
        If mIDTipoVencimiento = e.Row.DataRow("IDTipoVencimiento") Then
            MarcarDesMarcarVencimientoCompleto(e.CheckState = CheckStates.Checked)
        End If
    End Sub
    Private Sub MarcarDesMarcarVencimientoCompleto(ByVal Marcar As Boolean)
        Dim jFilter As New Janus.Windows.GridEX.GridEXFilterCondition
        jFilter.AddCondition()
        jFilter.Conditions(0).Column = grid.Columns("IDTipoVencimiento")
        jFilter.Conditions(0).ConditionOperator = Janus.Windows.GridEX.ConditionOperator.Equal
        jFilter.Conditions(0).Value1 = mIDTipoVencimiento

        mIDTipoVencimiento = 0
        grid.FindAll(jFilter)
        If Marcar Then
            grid.CheckRecord()
        Else
            grid.UnCheckRecord()
        End If
        grid.SelectedItems.Clear()
    End Sub

#End Region

    Private Sub cmbOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbOK.Click
        If grid.CheckedRecordsCount > 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            ExpertisApp.GenerateMessage("No hay registros seleccionados.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

End Class