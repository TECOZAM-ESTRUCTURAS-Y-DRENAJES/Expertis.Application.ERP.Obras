Public Class frmTrabajosPeriodificadosPropuestos

    Private Sub frmTrabajosPeriodificadosPropuestos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.MaximizeBox = True
        Grid.CheckAllRecords()
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

End Class